using System;
using System.Collections.Generic;
using System.Text;
using CppAst.CodeGen.CSharp;

namespace CodeGenerator.Utilities
{
	public static class CppMappingRulesExtensions
	{
		public static void AddRange(this CppMappingRules rules, params Func<CppMappingRules, CppElementMappingRule>[] values)
			=> AddRange(rules, (IEnumerable<Func<CppMappingRules, CppElementMappingRule>>)values);

		public static void AddRange(this CppMappingRules rules, params Func<CppMappingRules, CppMacroMappingRule>[] values)
			=> AddRange(rules, (IEnumerable<Func<CppMappingRules, CppMacroMappingRule>>)values);

		public static void AddRange(this CppMappingRules rules, IEnumerable<Func<CppMappingRules, CppElementMappingRule>> values)
		{
			foreach (var value in values) {
				rules.Add(value);
			}
		}

		public static void AddRange(this CppMappingRules rules, IEnumerable<Func<CppMappingRules, CppMacroMappingRule>> values)
		{
			foreach (var value in values) {
				rules.Add(value);
			}
		}
	}
}
