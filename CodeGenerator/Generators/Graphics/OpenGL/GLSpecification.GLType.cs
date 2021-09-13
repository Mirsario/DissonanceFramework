using System;

namespace CodeGenerator.Generators.Graphics.OpenGL
{
	partial class GLSpecification
	{
		public readonly struct GLType
		{
			public readonly string Type;
			public readonly string Group;
			public readonly bool Constant;

			public GLType(string type, string typeGroup = null, bool constant = false)
			{
				Type = type;
				Group = typeGroup;
				Constant = constant;
			}

			public override string ToString()
				=> $"{{ {nameof(Type)}: {Type}, {nameof(Group)}: {Group} }}";

			public static GLType Parse(string str)
			{
				string type = str;
				bool constant = false;

				if (type.StartsWith("const ")) {
					type = type.Substring(6);
					constant = true;
				}

				Console.WriteLine($"Parsed type: '{type}'");

				return new GLType(type, constant: constant);
			}
		}
	}
}
