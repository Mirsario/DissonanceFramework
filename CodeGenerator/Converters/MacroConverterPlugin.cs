using System.Collections.Generic;
using System.Text.RegularExpressions;
using CodeGenerator.Converters;
using CppAst.CodeGen.CSharp;

namespace CodeGenerator
{
	public class MacroConverterPlugin : ICSharpConverterPlugin
	{
		public List<MacroRule> Rules { get; } = new List<MacroRule>();

		public void Register(CSharpConverter converter, CSharpConverterPipeline pipeline)
		{
			pipeline.ConvertBegin.Add(ConvertBegin);
		}

		private void ConvertBegin(CSharpConverter converter)
		{
			// converter.CurrentCSharpCompilation.Members.Add(new CSharpEnum("Test"));

			var cpp = converter.CurrentCppCompilation;

			foreach (var macro in cpp.Macros) {
				if (string.IsNullOrWhiteSpace(macro.Value)) {
					continue;
				}

				foreach (var rule in Rules) {
					var match = Regex.Match(macro.Name, rule.MacroNameRegex);

					if (match.Success) {
						rule.Process(converter, macro, match);
					}
				}
			}
		}
	}
}
