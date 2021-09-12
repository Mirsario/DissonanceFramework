using System;
using System.Linq;
using System.Text.RegularExpressions;
using CodeGenerator.Utilities;
using CppAst;
using CppAst.CodeGen.CSharp;

namespace CodeGenerator.Generators.Audio
{
	public abstract class AudioGenerator : CppGenerator
	{
		private static CppComment previousFunctionComment;

		private readonly Regex FunctionTypeSuffixRegex;

		public string Namespace { get; private set; }
		public string Class { get; private set; }

		public AudioGenerator(string inputFile, string defaultNamespace, string defaultClass, string outputFile) : base(inputFile)
		{
			Options.DefaultNamespace = Namespace = defaultNamespace;
			Options.DefaultClassLib = Class = defaultClass;
			Options.DefaultOutputFilePath = outputFile;
			Options.DefaultDllImportNameAndArguments = "Library";

			FunctionTypeSuffixRegex = new Regex($@"\b{defaultClass.ToLower()}((?:Get)?(\w+?))(3i|3f|iv?|fv?|v)\b");

			Options.MappingRules.AddRange(new Func<CppMappingRules, CppElementMappingRule>[] {
				// Ignore all 'Pointer-to-function' delegates.
				e => e.MapAll<CppTypedef>().CppAction((converter, element) => {
					var typedef = (CppTypedef)element;

					if (typedef.ElementType.TypeKind == CppTypeKind.Pointer && typedef.Name.StartsWith($"LP")) {
						converter.Discard(element);
					}
				}),

				// Share summaries for groups of functions, where only the first one has it.
				e => e.MapAll<CppFunction>().CppAction((converter, element) => {
					var function = (CppFunction)element;

					if (function.Comment != null) {
						previousFunctionComment = function.Comment;
					} else {
						function.Comment = previousFunctionComment;
					}
				}),

				// Process functions that end with type suffixes. Like 'alSource3f'.
				e => e.MapAll<CppFunction>().CSharpAction((converter, element) => {
					var method = (CSharpMethod)element;
					var function = (CppFunction)method.CppElement;
					var match = FunctionTypeSuffixRegex.Match(function.Name);

					if (!match.Success) {
						return;
					}

					string primaryName = match.Groups[1].Value;
					string alternateName = match.Groups[2].Value;
					string originalSuffix = match.Groups[3].Value;

					// Change type of 'param' parameters to enums if a fitting one exists.

					if (method.Parameters.FirstOrDefault(p => p.Name == "param") is CSharpParameter parameter) {
						string suffix = originalSuffix switch {
							"i" => "Int",
							"f" => "Float",
							"3i" => "Int3",
							"3f" => "Float3",
							"iv" => "IntArray",
							"fv" => "FloatArray",
							_ => null
						};

						if (element.TryFindType($"{Namespace}.{primaryName}{suffix}", out var type) || alternateName != primaryName && element.TryFindType($"{Namespace}.{alternateName}{suffix}", out type)) {
							parameter.ParameterType = type;
						}
					}

					// Change last parameter's type from ref/out to array, for functions that end with 'v'.

					Func<CSharpType, CSharpType> getForcedValueType = originalSuffix switch {
						"iv" => _ => new CSharpArrayType(CSharpPrimitiveType.Int()),
						"fv" => _ => new CSharpArrayType(CSharpPrimitiveType.Float()),
						"v" => t => new CSharpArrayType((t as CSharpRefType)?.ElementType ?? t),
						_ => null
					};

					if (getForcedValueType != null && method.Parameters.LastOrDefault() is CSharpParameter valuesParameter) {
						valuesParameter.ParameterType = getForcedValueType(valuesParameter.ParameterType);
					}

					// Remove the suffix from the method's name.

					method.Name = primaryName;
				}),
			});
		}

		public override void Generate(string inputFile, string outputPath)
		{
			previousFunctionComment = null;

			base.Generate(inputFile, outputPath);
		}
	}
}
