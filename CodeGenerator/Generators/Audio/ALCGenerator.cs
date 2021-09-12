using System;
using CodeGenerator.Utilities;
using CppAst;
using CppAst.CodeGen.CSharp;

namespace CodeGenerator.Generators.Audio
{
	public class ALCGenerator : AudioGenerator
	{
		public ALCGenerator(string defaultNamespace, string defaultClass, string outputFile) : base(defaultNamespace, defaultClass, outputFile)
		{
			Options.MappingRules.AddRange(new Func<CppMappingRules, CppElementMappingRule>[] {
				// Remove prefixes from elements' names.
				e => RemovePrefixes(e, "ALC", $"ALC_", "alc"),
				
				// Fix strings and booleans.
				e => FixBooleansAndStrings(e, "ALCboolean", "ALCchar"),

				// Manual fixes

				// Turn things internal or unsafe
				e => e.Map<CppFunction>("alcCreateContext").Internal(),
				// Fix pointer parameters
				e => e.Map<CppParameter>("alcCreateContext::attrlist").ParameterType(new CSharpPointerType(CSharpPrimitiveType.Int())).Unsafe(),
			});
		}
	}
}
