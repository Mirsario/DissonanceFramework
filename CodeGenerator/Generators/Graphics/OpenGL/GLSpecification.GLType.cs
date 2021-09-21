using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeGenerator.Generators.Graphics.OpenGL
{
	partial class GLSpecification
	{
		public struct GLType
		{
			private static readonly Regex parserRegex = new(@"(const)?\s*(\w+)\s*((?:\*|const)*)", RegexOptions.Compiled);

			public string Name;
			public int PointerLevel;
			public bool Constant;
			public string Group;

			public GLType(string type, int pointerLevel = 0, bool constant = false, string group = null)
			{
				Name = type;
				PointerLevel = pointerLevel;
				Constant = constant;
				Group = group;
			}

			public override string ToString()
				=> $"{(Constant ? "const " : null)}{Name}{(PointerLevel > 0 ? new string('*', PointerLevel) : null)}";

			public static GLType Parse(string input)
				=> TryParse(input, out var result) ? result : throw new InvalidOperationException($"Unable to parse string '{input}' to a {nameof(GLType)}.");

			public static bool TryParse(string input, out GLType result)
			{
				if (string.IsNullOrWhiteSpace(input)) {
					result = default;

					return false;
				}

				var match = parserRegex.Match(input);

				if (!match.Success) {
					result = default;

					return false;
				}

				string type = match.Groups[2].Value;
				bool constant = match.Groups[1].Success;
				int pointerLevel = match.Groups[3].Value.Count(c => c == '*');

				result = new GLType(type, pointerLevel, constant);

				return true;
			}
		}
	}
}
