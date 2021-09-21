using System.Collections.Generic;

namespace CodeGenerator.Generators.Graphics.OpenGL
{
	partial class GLSpecification
	{
		public class EnumGroup
		{
			public readonly string Name;
			public readonly Dictionary<string, string> Entries = new();

			public EnumGroup(string name)
			{
				Name = name;
			}
		}
	}
}
