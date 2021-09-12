using System;
using System.Linq;
using System.Text.RegularExpressions;
using CppAst;
using CppAst.CodeGen.CSharp;
using Zio;

namespace CodeGenerator.Converters
{
	public class MacroToConstantRule : MacroRule
	{
		public string ClassName { get; set; }
		public string RegexNameReplacement { get; set; }
		public CSharpPrimitiveType ConstantType { get; set; }
		public Func<string, string> Renamer { get; set; }

		public MacroToConstantRule(string regexNameMatch, string className, string regexNameReplacement, CSharpPrimitiveType constantType, Func<string, string> renamer = null) : base(regexNameMatch)
		{
			ClassName = className;
			RegexNameReplacement = regexNameReplacement;
			ConstantType = constantType;
			Renamer = renamer;
		}

		public override void Process(CSharpConverter converter, CppMacro macro, Match match)
		{
			var csCompilation = converter.CurrentCSharpCompilation;
			string filePath = $"{ClassName}.cs";

			if (csCompilation.Members.FirstOrDefault(m => m is CSharpGeneratedFile f && f.FilePath == filePath) is not CSharpGeneratedFile file
			|| file.Members.FirstOrDefault(m => m is CSharpNamespace ns && ns.Name == converter.Options.DefaultNamespace) is not CSharpNamespace csNamespace) {
				file = new CSharpGeneratedFile(new UPath(filePath));
				csNamespace = new CSharpNamespace(converter.Options.DefaultNamespace);

				csCompilation.Members.Add(file);
				file.Members.Add(csNamespace);
			}

			if (csNamespace.Members.FirstOrDefault(e => e is CSharpClass csClass && csClass.Name == ClassName) is not CSharpClass csClass) {
				csClass = new CSharpClass(ClassName);

				csNamespace.Members.Insert(0, csClass);
			}

			string itemName = match.Result(RegexNameReplacement);

			if (Renamer != null) {
				itemName = Renamer(itemName);
			}

			csClass.Members.Add(new CSharpField(itemName) {
				Modifiers = CSharpModifiers.Const,
				InitValue = macro.Value,
				FieldType = ConstantType
			});
		}
	}
}
