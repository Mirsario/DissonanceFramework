using System;
using System.Xml;
using System.Xml.Linq;

namespace CodeGenerator.Generators.Graphics.OpenGL
{
	public class GLGenerator : Generator
	{
		public readonly string InputFile;

		public GLGenerator(string inputFile)
		{
			InputFile = inputFile;
		}

		public override void Generate(string outputPath)
		{
			var specification = new GLSpecification(InputFile);

			/*
			using var reader = new XmlTextReader(InputFile);

			int level = 0;

			string Indentation() => new string('\t', level);

			while (reader.Read()) {
				switch (reader.NodeType) {
					case XmlNodeType.Element:
						Console.WriteLine($"{Indentation()}<{reader.Name}>");
						level++;
						break;
					case XmlNodeType.Text:
						Console.WriteLine($"{Indentation()}{reader.Value}");
						break;
					case XmlNodeType.EndElement:
						level--;
						Console.WriteLine($"{Indentation()}</{reader.Name}>");
						break;
					case XmlNodeType.Comment:
					case XmlNodeType.Whitespace:

						break;
					default:
						Console.WriteLine($"{Indentation()}Other node {reader.NodeType} with value {reader.Value}");
						break;
				}
			}*/
		}
	}
}
