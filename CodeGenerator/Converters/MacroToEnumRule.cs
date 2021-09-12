using System;
using System.Linq;
using System.Text.RegularExpressions;
using CppAst;
using CppAst.CodeGen.CSharp;
using Zio;

namespace CodeGenerator.Converters
{
	public class MacroToEnumRule : MacroRule
	{
		public string EnumTypeName { get; set; }
		public Func<string, string> Renamer { get; set; }

		public MacroToEnumRule(string cppRegexName, string cppEnumTypeName, Func<string, string> renamer = null) : base(cppRegexName)
		{
			EnumTypeName = cppEnumTypeName;
			Renamer = renamer;
		}

		public override void Process(CSharpConverter converter, CppMacro macro, Match match)
		{
			var csCompilation = converter.CurrentCSharpCompilation;
			string filePath = $"{EnumTypeName}.cs";

			if (csCompilation.Members.FirstOrDefault(m => m is CSharpGeneratedFile f && f.FilePath == filePath) is not CSharpGeneratedFile file
			|| file.Members.FirstOrDefault(m => m is CSharpNamespace ns && ns.Name == converter.Options.DefaultNamespace) is not CSharpNamespace csNamespace) {
				file = new CSharpGeneratedFile(new UPath(filePath));
				csNamespace = new CSharpNamespace(converter.Options.DefaultNamespace);

				csCompilation.Members.Add(file);
				file.Members.Add(csNamespace);
			}

			if (csNamespace.Members.FirstOrDefault(e => e is CSharpEnum csEnum && csEnum.Name == EnumTypeName) is not CSharpEnum csharpEnum) {
				csharpEnum = new CSharpEnum(EnumTypeName);

				csNamespace.Members.Insert(0, csharpEnum);
			}

			string itemName = match.Value;

			if (Renamer != null) {
				itemName = Renamer(itemName);
			}

			string value = macro.Value;

			// Try to detect references to other macros
			if (!int.TryParse(value, out _)) {
				var cppCompilation = converter.CurrentCppCompilation;
				var matchingMacro = cppCompilation.Macros.FirstOrDefault(m => m.Name == value);

				if (matchingMacro != null) {
					value = Renamer(value);
				}
			}

			csharpEnum.Members.Add(new CSharpEnumItem(itemName, value));
		}
	}
}
