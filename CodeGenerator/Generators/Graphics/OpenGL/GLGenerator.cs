using System.Collections.Generic;
using System.IO;
using System.Linq;
using CodeGenerator.Utilities;

namespace CodeGenerator.Generators.Graphics.OpenGL
{
	public class GLGenerator : Generator
	{
		public readonly string InputFile;
		public readonly string Namespace;
		public readonly string Class;

		public GLGenerator(string inputFile, string @namespace, string @class)
		{
			InputFile = inputFile;
			Namespace = @namespace;
			Class = @class;
		}

		public override void Generate(string outputPath)
		{
			var specification = new GLSpecification(InputFile);

			Directory.CreateDirectory(outputPath);

			var requiredFunctions = new HashSet<string>();
			var functionsByVersion = new Dictionary<GLSpecification.ApiVersion, List<GLSpecification.Function>>();

			foreach (var apiVersion in specification.ApiVersions) {
				if (apiVersion.Api != "gl") {
					continue;
				}

				var versionFunctions = functionsByVersion[apiVersion] = new List<GLSpecification.Function>();

				foreach (var featureSet in apiVersion.FeatureSets.Where(f => f.Type == GLSpecification.FeatureSetType.Requires)) {
					foreach (string functionName in featureSet.Functions) {
						var function = specification.Functions[functionName];

						if (requiredFunctions.Add(function.Name)) {
							versionFunctions.Add(function);
						}
					}
				}
			}

			void WriteHeader(CodeWriter code, string @namespace, params string[] usings)
			{
				if (usings?.Length > 0) {
					foreach (string @using in usings) {
						code.WriteLine($"using {@using};");
					}

					code.WriteLine();
				}

				code.WriteLine($"namespace {@namespace}");
				code.WriteLine("{");
				code.Indent();
			}

			void WriteFooter(CodeWriter code)
			{
				code.Unindent();
				code.WriteLine("}");
				code.WriteLine();
			}

			var usedEnumGroups = new HashSet<string>();

			// Generate files with functions.

			foreach (var apiVersion in specification.ApiVersions) {
				if (apiVersion.Api != "gl") {
					continue;
				}

				string file = Path.Combine(outputPath, $"GL.{apiVersion.Version.Major}{apiVersion.Version.Minor}.cs");
				var code = new CodeWriter(file);

				WriteHeader(code, Namespace, "System");
				
				code.WriteLine($"unsafe partial class {Class}");
				code.WriteLine("{");
				code.Indent();

				bool firstMember = true;

				foreach (var function in functionsByVersion[apiVersion]) {
					if (firstMember) {
						firstMember = false;
					} else {
						code.WriteLine();
					}

					var parameterPairs = (IEnumerable<(string csharpTypeName, string csharpParameterName)>)function.Parameters.Select(p => (ConvertTypeToCSharpType(p.Type, usedEnumGroups), SanitizeLocalName(p.Name)));
					string returnType = ConvertTypeToCSharpType(function.ReturnType, usedEnumGroups);

					string functionGenerics = string.Join(", ", parameterPairs.Select(t => t.csharpTypeName).Append(returnType));

					code.WriteLine($@"[MethodImport(""{function.Name}"", ""{apiVersion.Version}"")]");
					code.WriteLine($"private static delegate*<{functionGenerics}> {function.Name};");
					code.WriteLine();

					string methodParameters = string.Join(", ", parameterPairs.Select(t => $"{t.csharpTypeName} {t.csharpParameterName}"));

					code.WriteLine($"public static {returnType} {function.Name.Substring(2)}({methodParameters})");
					code.WriteLine("{");
					code.Indent();

					string functionCallArguments = string.Join(", ", parameterPairs.Select(t => t.csharpParameterName));

					code.WriteLine($"{(returnType != "void" ? "return " : null)}{function.Name}({functionCallArguments});");

					code.Unindent();
					code.WriteLine("}");
				}

				code.Unindent();
				code.WriteLine("}");

				WriteFooter(code);

				code.Save();
			}

			// Generate files with enums

			foreach (var pair in specification.EnumGroups) {
				if (pair.Key != string.Empty && !usedEnumGroups.Contains(pair.Key)) {
					continue;
				}

				string name = pair.Key != string.Empty ? pair.Key : "Enums";
				string file = Path.Combine(outputPath, $"{name}.cs");
				var code = new CodeWriter(file);

				WriteHeader(code, Namespace);

				code.WriteLine($"public enum {name} : uint");
				code.WriteLine("{");
				code.Indent();

				var entries = pair.Value.Entries;

				foreach (var entryPair in entries) {
					string keyName = entryPair.Key;

					if (keyName.StartsWith("GL_")) {
						keyName = keyName.Substring(3);
					}

					keyName = StringUtils.SnakeCaseToUpperCamelCase(keyName);

					code.WriteLine($"{keyName} = {entryPair.Value},");
				}

				code.Unindent();
				code.WriteLine("}");

				WriteFooter(code);

				code.Save();
			}
		}

		private static string SanitizeLocalName(string name)
		{
			return name switch {
				"params" or "ref" or "in" or "out" or "string" or "base" => $"@{name}",
				_ => name,
			};
		}

		private static string ConvertTypeToCSharpType(GLSpecification.GLType type, HashSet<string> usedEnumGroups = null)
		{
			if (type.Group != null && (type.Name == "GLenum" || type.Name == "GLbitfield")) {
				usedEnumGroups?.Add(type.Group);

				return type.Group;
			}

			string name = type.Name switch {
				"GLboolean" => "bool",
				"GLbyte" => "sbyte",
				"GLubyte" => "byte",
				"GLshort" => "short",
				"GLushort" => "ushort",
				"GLint" => "int",
				"GLuint" => "uint",
				"GLfixed" => "int",
				"GLint64" => "long",
				"GLuint64" => "ulong",
				"GLsizei" => "int",
				"GLenum" => "uint",
				"GLintptr" => "IntPtr",
				"GLsizeiptr" => "IntPtr",
				"GLsync" => "IntPtr",
				"GLhalf" => "Half",
				"GLfloat" => "float",
				"GLclampf" => "float",
				"GLdouble" => "double",
				"GLclampd" => "double",
				"GLclampx" => "int",
				"GLchar" => "byte",
				"GLbitfield" => "uint",

				// TODO: Temporary hardcode
				"GLDEBUGPROC" => "delegate*<uint, uint, uint, uint, int, byte*, void*, void>",

				_ => type.Name
			};

			int pointerLevel = type.PointerLevel;

			if (pointerLevel > 0) {
				name += new string('*', type.PointerLevel);
			}

			return name;
		}
	}
}
