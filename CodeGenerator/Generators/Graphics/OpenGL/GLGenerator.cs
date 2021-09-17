using System;
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

			foreach (var version in specification.Versions) {
				string file = Path.Combine(outputPath, $"GL.{version.Version.Major}{version.Version.Minor}.cs");
				var code = new CodeWriter(file);

				code.WriteLine("using System;");
				code.WriteLine();
				code.WriteLine($"namespace {Namespace}");
				code.WriteLine("{");
				code.Indent();
				code.WriteLine($"unsafe partial class {Class}");
				code.WriteLine("{");
				code.Indent();

				foreach (var featureSet in version.FeatureSets.Where(f => f.Type == GLSpecification.FeatureSetType.Requires)) {
					foreach (string functionName in featureSet.Functions) {
						var function = specification.Functions[functionName];

						code.WriteLine($"private static delegate*<{string.Join(", ", function.Parameters.Select(p => p.Type.Type))}> {function.Name};");
						code.WriteLine();
					}
				}

				code.Unindent();
				code.WriteLine("}");
				code.Unindent();
				code.WriteLine("}");

				code.Save();
			}
		}
	}
}
