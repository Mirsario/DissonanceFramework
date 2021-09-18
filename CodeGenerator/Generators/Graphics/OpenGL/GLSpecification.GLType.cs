using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeGenerator.Generators.Graphics.OpenGL
{
	partial class GLSpecification
	{
		public readonly struct GLType
		{
			private static readonly Regex parserRegex = new(@"(const)?\s*(\w+)\s*((?:\*|const)*)", RegexOptions.Compiled);

			public readonly string Type;
			public readonly int PointerLevel;
			public readonly bool Constant;

			public GLType(string type, int pointerLevel = 0, bool constant = false)
			{
				Type = type;
				PointerLevel = pointerLevel;
				Constant = constant;
			}

			public override string ToString()
				=> $"{(Constant ? "const " : null)}{Type}{(PointerLevel > 0 ? new string('*', PointerLevel) : null)}";

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
