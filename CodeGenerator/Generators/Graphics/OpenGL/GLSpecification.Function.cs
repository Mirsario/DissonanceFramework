using System;
using System.Collections.Generic;
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

			public readonly IReadOnlyList<Parameter> Parameters;

			public Function(string name, GLType returnType, Parameter[] parameters, string returnGroup = null, string vectorEquivalent = null)
			{
				Name = name;
				ReturnType = returnType;
				Parameters = parameters.ToList().AsReadOnly();
				ReturnGroup = returnGroup;
				VectorEquivalent = vectorEquivalent;
			}

			public override string ToString()
			{
				return $"{ReturnType} {Name}({string.Join(", ", Parameters.Select(p => $"{p.Type} {p.Name}"))})";
			}
		}
	}
}
