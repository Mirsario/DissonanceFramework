using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CodeGenerator.Utilities;
using CppAst;
using CppAst.CodeGen.Common;
using CppAst.CodeGen.CSharp;
using Zio.FileSystems;

namespace CodeGenerator
{
	public abstract class CppGenerator : Generator
	{
		public CSharpConverterOptions Options { get; protected set; }
		public MacroConverterPlugin MacroPlugin { get; protected set; }

		public CppGenerator()
		{
			Options = new CSharpConverterOptions {
				DispatchOutputPerInclude = false,
				GenerateEnumItemAsFields = false,
				TypedefCodeGenKind = CppTypedefCodeGenKind.NoWrap,

				MappingRules = {
					// Fix weird 'ref void' parameters.
					e => e.MapAll<CppParameter>().CSharpAction((converter, element) => {
						var parameter = (CSharpParameter)element;
						var parameterType = parameter.ParameterType;

						if(parameterType is CSharpRefType refType && refType.ElementType is CSharpPrimitiveType primitiveType && primitiveType.Kind == CSharpPrimitiveKind.Void) {
							parameter.ParameterType = CSharpPrimitiveType.IntPtr();
						}
					}),
					// ..And returns.
					e => e.MapAll<CppFunction>().CSharpAction((converter, element) => {
						var method = (CSharpMethod)element;
						var returnType = method.ReturnType;

						if(returnType is CSharpRefType refType && refType.ElementType is CSharpPrimitiveType primitiveType && primitiveType.Kind == CSharpPrimitiveKind.Void) {
							method.ReturnType = CSharpPrimitiveType.IntPtr();
						}
					}),

					// Add an EntryPoint parameter to the DllImportAttribute, so that renames don't break anything.
					e => e.MapAll<CppFunction>().CSharpAction((converter, element) => {
						var method = (CSharpMethod)element;
						var function = (CppFunction)element.CppElement;

						if(method.Attributes.FirstOrDefault(attrib => attrib is CSharpDllImportAttribute) is CSharpDllImportAttribute dllImportAttribute) {
							dllImportAttribute.EntryPoint = $@"""{function.Name}""";
						}
					}),
				}
			};

			Options.Plugins.Insert(0, new StructToVoidConverterPlugin());
			Options.Plugins.Add(MacroPlugin = new MacroConverterPlugin());
		}

		public override void Generate(string inputFile, string outputPath)
		{
			Console.WriteLine($"{GetType().Name}: Processing {Path.GetFileName(inputFile)}...");

			Options.IncludeFolders.Clear();
			Options.IncludeFolders.Add(Path.GetDirectoryName(inputFile));

			var compilation = CSharpConverter.Convert(new List<string> { inputFile }, Options);

			if(compilation.HasErrors) {
				foreach(var message in compilation.Diagnostics.Messages) {
					if(message.Type == CppLogMessageType.Error) {
						Console.WriteLine(message);
					}
				}

				Console.ReadKey();

				return;
			}

			Directory.CreateDirectory(outputPath);

			using var fileSystem = new PhysicalFileSystem();
			using var subFileSystem = new SubFileSystem(fileSystem, fileSystem.ConvertPathFromInternal(outputPath));

			var codeWriterOptions = new CodeWriterOptions(subFileSystem);
			var codeWriter = new CodeWriter(codeWriterOptions);

			compilation.DumpTo(codeWriter);
		}

		protected static CppElementMappingRule RemovePrefixes(CppMappingRules rules, string typePrefix, string enumPrefix, string functionPrefix)
		{
			static string FixName(string name, string prefix)
				=> StringUtils.Capitalize(StringUtils.RemovePrefix(name, prefix));

			return rules.MapAll<CppElement>()
				.CppAction((converter, element) => {
					switch(element) {
						case CppClass cppClass:
							cppClass.Name = FixName(cppClass.Name, typePrefix);
							break;
					}
				})
				.CSharpAction((converter, element) => {
					switch(element) {
						case CSharpEnumItem enumItem:
							enumItem.Name = FixName(enumItem.Name, enumPrefix);
							break;
						case CSharpMethod method:
							method.Name = FixName(method.Name, functionPrefix);
							break;
					}
				});
		}

		protected static CppElementMappingRule FixBooleansAndStrings(CppMappingRules rules, string boolTypedef, string charTypedef)
		{
			return rules.MapAll<CppDeclaration>().CSharpAction((converter, element) => {
				if(!(element is CSharpMethod || element is CSharpParameter)) {
					return;
				}

				CppType lastElementType = element.CppElement switch {
					CppFunction function => function.ReturnType.GetLastElementType(),
					CppParameter parameter => parameter.Type.GetLastElementType(),
					_ => throw new Exception()
				};

				if(!(lastElementType is CppTypedef typedef)) {
					return;
				}

				CSharpType newType;
				CSharpUnmanagedKind? marshalAs;
				bool keepRef;

				if(typedef.Name == boolTypedef) {
					newType = CSharpPrimitiveType.Bool();
					marshalAs = CSharpUnmanagedKind.I1;
					keepRef = true;
				} else if(typedef.Name == charTypedef) {
					newType = CSharpPrimitiveType.String();
					marshalAs = CSharpUnmanagedKind.LPStr;
					keepRef = false;
				} else {
					return;
				}

				CSharpType GetCSType(CSharpType originalType)
				{
					if(keepRef) {
						if(originalType is CSharpRefType refType) {
							refType.ElementType = newType;

							return refType;
						}
					}

					return newType;
				}

				switch(element) {
					case CSharpParameter parameter:
						parameter.ParameterType = GetCSType(parameter.ParameterType);
						parameter.Attributes.Add(new CSharpMarshalAttribute(marshalAs.Value));
						break;
					case CSharpMethod method:
						method.ReturnType = GetCSType(method.ReturnType);
						method.Attributes.Add(new CSharpMarshalAttribute(marshalAs.Value) { Scope = CSharpAttributeScope.Return });
						break;
				}
			});
		}

		protected static CppElementMappingRule RemoveOpaqueStructures(CppMappingRules rules)
		{
			return rules.MapAll<CppClass>()
				.CppAction((converter, element) => {
					/*var cppStruct = (CppClass)element;

					if(cppStruct.ClassKind != CppClassKind.Struct || cppStruct.Fields.Count > 0) {
						return;
					}

					converter.Discard(cppStruct);*/
				});
		}

	}
}
