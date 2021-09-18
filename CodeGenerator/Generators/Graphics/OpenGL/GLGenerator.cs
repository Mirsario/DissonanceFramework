using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
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
			var functionsByVersion = new Dictionary<Version, List<GLSpecification.Function>>();

			foreach (var version in specification.ApiVersions) {
				var versionFunctions = functionsByVersion[version.Version] = new List<GLSpecification.Function>();

				foreach (var featureSet in version.FeatureSets.Where(f => f.Type == GLSpecification.FeatureSetType.Requires)) {
					foreach (string functionName in featureSet.Functions) {
						var function = specification.Functions[functionName];

						if (requiredFunctions.Add(function.Name)) {
							versionFunctions.Add(function);
						}
					}
				}
			}

			foreach (var apiVersion in specification.ApiVersions) {
				string file = Path.Combine(outputPath, $"GL.{apiVersion.Version.Major}{apiVersion.Version.Minor}.cs");
				var code = new CodeWriter(file);

				code.WriteLine("using System;");
				code.WriteLine();
				code.WriteLine($"namespace {Namespace}");
				code.WriteLine("{");
				code.Indent();
				code.WriteLine($"unsafe partial class {Class}");
				code.WriteLine("{");
				code.Indent();

				foreach (var function in functionsByVersion[apiVersion.Version]) {
					var parameterNames = function.Parameters.Select(p => GetTypeName(p.Type));
					string generics = string.Join(", ", parameterNames.Append(GetTypeName(function.ReturnType)));

					code.WriteLine($"private static delegate*<{generics}> {function.Name};");
					code.WriteLine();
				}

				code.Unindent();
				code.WriteLine("}");
				code.Unindent();
				code.WriteLine("}");

				code.Save();
			}
		}

		private static string GetTypeName(GLSpecification.GLType type)
		{
			string name = type.Type switch {
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

				_ => type.Type
			};

			int pointerLevel = type.PointerLevel;

			if (pointerLevel > 0) {
				name += new string('*', type.PointerLevel);
			}

			return name;
		}
	}
}
