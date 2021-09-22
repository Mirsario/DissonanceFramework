using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Linq;
using CodeGenerator.Plugins;
using CodeGenerator.Utilities;
using CppAst;
using CppAst.CodeGen.CSharp;

namespace CodeGenerator.Generators.Graphics.OpenGL
{
	public class GLGenerator : CppGeneratorBase
	{
		public readonly string InputFile;
		public readonly string Namespace;
		public readonly string Class;

		public GLGenerator(string inputFile, string @namespace, string @class) : base()
		{
			InputFile = inputFile;
			Namespace = @namespace;
			Class = @class;

			Options.DefaultNamespace = "Dissonance.Framework.Graphics.OpenGL";
			Options.DefaultClassLib = "GL";
			Options.DefaultOutputFilePath = "GL.Generated.cs";

			Options.Plugins.Insert(0, new FunctionsAsPointersConverter());
			Options.Plugins.Insert(0, new FilePerTypeContainerResolver());

			Options.MappingRules.AddRange(new Func<CppMappingRules, CppElementMappingRule>[] {
				// Remove prefixes from elements' names.
				e => e.MapAll<CppFunction>().CSharpAction((csConverter, csElement) => {
					var csMethod = (CSharpMethod)csElement;

					if (csMethod.Name.StartsWith("gl")) {
						string newName = csMethod.Name.Substring(2);

						// Check for enums named the same way, and rename them if needed.
						//string path = csMethod.Parent.FullIdentifier();
						//string newPath = $"{path}.{newName}";

						csMethod.Name = newName;
					}
				}),

				e => e.MapAll<CppEnumItem>().CSharpAction((csConverter, csElement) => {
					var csEnumItem = (CSharpEnumItem)csElement;

					csEnumItem.Name = StringUtils.RemovePrefix(csEnumItem.Name, "GL_");
					csEnumItem.Name = StringUtils.SnakeCaseToUpperCamelCase(csEnumItem.Name);

					if (char.IsDigit(csEnumItem.Name[0])) {
						csEnumItem.Name = $"GL{csEnumItem.Name}";
					}
				}),

				e => e.Map<CppEnum>("khronos_boolean_enum_t").Discard(),
			});
		}

		public override CSharpCompilation GetCSharpCompilation()
		{
			var xml = XDocument.Load(InputFile);

			// Generate C++

			var csConversionFunc = (Func<CppParserOptions, CppCompilation>)(cppParserOptions => GenerateCpp(cppParserOptions, xml));

			// Convert it to C#

			object csConverter = Activator.CreateInstance(typeof(CSharpConverter), BindingFlags.NonPublic | BindingFlags.Instance, null, new object[] { Options }, null);

			var csCompilation = (CSharpCompilation)typeof(CSharpConverter)
				.GetMethod("Run", BindingFlags.Instance | BindingFlags.NonPublic)
				.Invoke(csConverter, new object[] { csConversionFunc });

			return csCompilation;
		}

		private CppCompilation GenerateCpp(CppParserOptions cppParserOptions, XDocument xml)
		{
			var cppCode = new StringBuilder();

			// Parse typedefs (using CppAst)

			foreach (var xmlTypes in xml.Root.Elements("types")) {
				foreach (var xmlType in xmlTypes.Elements("type")) {
					cppCode.AppendLine(xmlType.Value);
				}
			}

			var cppCompilation = CppParser.Parse(cppCode.ToString(), new CppParserOptions {
				IncludeFolders = {
					Path.GetDirectoryName(InputFile)
				}
			});

			if (cppCompilation.HasErrors) {
				throw new InvalidOperationException($"Cpp compilation had errors:\r\n{string.Join("\r\n", cppCompilation.Diagnostics.Messages.Where(m => m.Type == CppLogMessageType.Error).Select(m => m.Text))}");
			}

			// Collect lists of functions and enums referenced in versions

			var enabledFunctions = new HashSet<string>(); 
			var enabledEnumItems = new HashSet<string>(); 

			foreach (var xmlFeature in xml.Root.Elements("feature")) {
				string api = xmlFeature.Attribute("api").Value;

				if (api != "gl") {
					continue;
				}

				string directive = xmlFeature.Attribute("name").Value;
				var versionNumber = new Version(xmlFeature.Attribute("number").Value);

				foreach (var xmlRequire in xmlFeature.Elements("require")) {
					foreach (var xmlEnum in xmlRequire.Elements("enum")) {
						enabledEnumItems.Add(xmlEnum.Attribute("name").Value);
					}

					foreach (var xmlCommand in xmlRequire.Elements("command")) {
						enabledFunctions.Add(xmlCommand.Attribute("name").Value);
					}
				}

				/*
				foreach (var removeElement in featureElement.Elements("remove")) {
					HandleFeatureSet(removeElement, true);
				}
				*/
			}

			// Parse enums

			var cppEnums = new Dictionary<string, (CppEnum cppEnum, HashSet<string> knownEntries)>();

			foreach (var xmlEnums in xml.Root.Elements("enums")) {
				string enumsNamespace = xmlEnums.Attribute("namespace").Value;
				string enumsVendor = xmlEnums.Attribute("vendor")?.Value;
				string enumsComment = xmlEnums.Attribute("comment")?.Value;

				foreach (var xmlEnum in xmlEnums.Elements("enum")) {
					string enumItemName = xmlEnum.Attribute("name").Value;

					if (!enabledEnumItems.Contains(enumItemName)) {
						continue;
					}

					string enumItemValue = xmlEnum.Attribute("value").Value;
					string[] enumItemGroups = xmlEnum.Attribute("group")?.Value?.Split(',');

					void HandleGroup(string enumName)
					{
						if (!cppEnums.TryGetValue(enumName, out var enumTuple)) {
							var cppEnum = new CppEnum(enumName) {
								IntegerType = CppPrimitiveType.UnsignedInt
							};

							cppEnums[enumName] = enumTuple = (cppEnum, new HashSet<string>());

							cppCompilation.Enums.Add(cppEnum);
						}

						if (enumTuple.knownEntries.Add(enumItemName)) {
							var enumItem = new CppEnumItem(enumItemName, 0) {
								ValueExpression = new CppLiteralExpression(CppExpressionKind.IntegerLiteral, enumItemValue)
							};

							enumTuple.cppEnum.Items.Add(enumItem);
						}
					}

					if (enumItemGroups != null) {
						foreach (string enumGroup in enumItemGroups) {
							HandleGroup(enumGroup);
						}
					} else {
						//HandleGroup("Uncategorized");
					}
				}
			}

			// Parse functions

			foreach (var xmlCommands in xml.Root.Elements("commands")) {
				foreach (var xmlCommand in xmlCommands.Elements("command")) {
					var xmlProto = xmlCommand.Element("proto");
					string functionName = xmlProto.Element("name").Value;

					if (!enabledFunctions.Contains(functionName)) {
						continue;
					}

					var cppFunction = new CppFunction(functionName) {
						LinkageKind = CppLinkageKind.Internal
					};

					// Parse return type

					string returnTypeName = xmlProto.Element("ptype")?.Value;
					var returnType = (returnTypeName != null ? cppCompilation.FindByName(returnTypeName) : null) as CppType ?? CppPrimitiveType.Void;

					cppFunction.ReturnType = returnType;

					// Parse parameters

					var xmlParameters = xmlCommand.Elements("param").ToArray();

					foreach (var xmlParameter in xmlParameters) {
						string parameterName = xmlParameter.Element("name").Value;
						string parameterTypeName = xmlParameter.Element("ptype")?.Value;
						string parameterGroup = xmlParameter.Attribute("group")?.Value;

						var parameterType = (parameterTypeName != null ? cppCompilation.FindByName(parameterTypeName) : null) as CppType ?? CppPrimitiveType.Void;

						// Use enums if possible
						if (parameterGroup != null && parameterType is CppTypedef parameterTypedef && parameterTypedef.Name == "GLenum") {
							parameterType = cppCompilation.FindByName<CppType>(parameterGroup);
						}

						int pointerLevel = xmlParameter.ToString().Count(c => c == '*');

						for (int i = 0; i < pointerLevel; i++) {
							parameterType = new CppPointerType(parameterType);
						}

						var cppParameter = new CppParameter(parameterType, parameterName);

						cppFunction.Parameters.Add(cppParameter);
					}

					cppCompilation.Functions.Add(cppFunction);
				}
			}

			return cppCompilation;
		}
	}
}
