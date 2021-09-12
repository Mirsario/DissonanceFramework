using System.Text.RegularExpressions;
using CppAst;
using CppAst.CodeGen.CSharp;

namespace CodeGenerator.Converters
{
	public abstract class MacroRule
	{
		public string MacroNameRegex { get; set; }
		public bool OnlyNonProcessedMacros { get; set; }

		protected MacroRule(string cppRegexName)
		{
			MacroNameRegex = cppRegexName;
		}

		public abstract void Process(CSharpConverter converter, CppMacro macro, Match regexMatch);
	}
}
