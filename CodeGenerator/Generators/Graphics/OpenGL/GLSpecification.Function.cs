using System;

namespace CodeGenerator.Generators.Graphics.OpenGL
{
	partial class GLSpecification
	{
		public class Function
		{
			public readonly string Name;
			public readonly GLType? ReturnType;
			public readonly string VectorEquivalent;

			private readonly Parameter[] parameters;

			public ReadOnlySpan<Parameter> Parameters => parameters;

			public Function(string name, GLType? returnType, Parameter[] parameters, string vectorEquivalent = null)
			{
				Name = name;
				ReturnType = returnType;
				this.parameters = parameters;
				VectorEquivalent = vectorEquivalent;
			}
		}
	}
}
