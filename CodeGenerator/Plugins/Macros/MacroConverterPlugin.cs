using System.Collections.Generic;
using System.Text.RegularExpressions;
using CppAst.CodeGen.CSharp;

namespace CodeGenerator.Plugins.Macros
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

				bool processed = false;

				foreach (var rule in Rules) {
					var match = Regex.Match(macro.Name, rule.MacroNameRegex);

					if (match.Success && (!processed || !rule.OnlyNonProcessedMacros)) {
						rule.Process(converter, macro, match);

						processed = true;
					}
				}
			}
		}
	}
}
