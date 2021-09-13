using System;
using System.Linq;

namespace CodeGenerator.Generators.Graphics.OpenGL
{
	partial class GLSpecification
	{
		public class Function
		{
			public readonly string Name;
			public readonly GLType ReturnType;
			public readonly string VectorEquivalent;
			public readonly string ReturnGroup;

			private readonly Parameter[] parameters;

			public ReadOnlySpan<Parameter> Parameters => parameters;

			public Function(string name, GLType returnType, Parameter[] parameters, string returnGroup = null, string vectorEquivalent = null)
			{
				Name = name;
				ReturnType = returnType;
				this.parameters = parameters;
				ReturnGroup = returnGroup;
				VectorEquivalent = vectorEquivalent;
			}

			public override string ToString()
			{
				return $"{ReturnType} {Name}({string.Join(", ", parameters.Select(p => $"{p.Type} {p.Name}"))})";
			}
		}
	}
}
