namespace CodeGenerator.Generators.Graphics.OpenGL
{
	partial class GLSpecification
	{
		public readonly struct Parameter
		{
			public readonly string Name;
			public readonly GLType Type;

			public Parameter(string name, GLType type)
			{
				Name = name;
				Type = type;
			}
		}
	}
}
