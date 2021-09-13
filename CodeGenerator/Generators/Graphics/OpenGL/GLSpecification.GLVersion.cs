using System;
using System.Collections.Generic;

namespace CodeGenerator.Generators.Graphics.OpenGL
{
	partial class GLSpecification
	{
		public class GLVersion
		{
			public readonly string Api;
			public readonly string Directive;
			public readonly Version Version;
			public readonly List<FeatureSet> FeatureSets = new();

			public GLVersion(string api, string directive, Version version)
			{
				Api = api;
				Directive = directive;
				Version = version;
			}

			public override string ToString()
				=> $"{{{nameof(Api)}: {Api}, {nameof(Version)}: {Version}, {nameof(Directive)}: {Directive}}}";
		}
	}
}
