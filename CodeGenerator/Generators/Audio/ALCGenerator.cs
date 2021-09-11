using System;
using CodeGenerator.Utilities;
using CppAst.CodeGen.CSharp;

namespace CodeGenerator.Generators.Audio
{
	public class ALCGenerator : AudioGenerator
	{
		public ALCGenerator(string defaultNamespace, string defaultClass, string outputFile) : base(defaultNamespace, defaultClass, outputFile)
		{
			/*static string EnumItemCasing(string name) => StringUtils.SnakeCaseToUpperCamelCase(name);

			MacroPlugin.Rules.AddRange(new[] {
				new MacroToEnumRule(@"AL_(FORMAT_MONO8|FORMAT_MONO16|FORMAT_STEREO8|FORMAT_STEREO16)", "BufferFormat", "$1", EnumItemCasing),
			});*/

			Options.MappingRules.AddRange(new Func<CppMappingRules, CppElementMappingRule>[] {
				// Remove prefixes from elements' names.
				e => RemovePrefixes(e, "ALC", $"ALC_", "alc"),
				
				// Fix strings and booleans.
				e => FixBooleansAndStrings(e, "ALCboolean", "ALCchar"),
			});
		}
	}
}
