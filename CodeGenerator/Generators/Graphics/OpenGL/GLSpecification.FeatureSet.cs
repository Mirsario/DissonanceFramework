using System.Collections.Generic;

namespace CodeGenerator.Generators.Graphics.OpenGL
{
	public partial class GLSpecification
	{
		public enum FeatureSetType
		{
			Requires,
			Removes
		}

		public class FeatureSet
		{
			public readonly FeatureSetType Type;
			public readonly List<string> Enums = new();
			public readonly List<string> Functions = new();

			public FeatureSet(FeatureSetType type)
			{
				Type = type;
			}
		}
	}
}
