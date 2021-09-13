using System;

namespace CodeGenerator.Generators.Graphics.OpenGL
{
	partial class GLSpecification
	{
		public readonly struct GLType
		{
			public readonly string Type;
			public readonly bool Constant;

			public GLType(string type, bool constant = false)
			{
				Type = type;
				Constant = constant;
			}

			public override string ToString()
				=> $"{(Constant ? "const " : null)}{Type}";

			public static GLType Parse(string input)
			{
				if (string.IsNullOrWhiteSpace(input)) {
					throw new ArgumentNullException(nameof(input));
				}

				string type = input;
				bool constant = false;

				if (type.StartsWith("const ")) {
					type = type.Substring(6);
					constant = true;
				}

				type = type.Replace(" *", "*");

				return new GLType(type, constant);
			}
		}
	}
}
