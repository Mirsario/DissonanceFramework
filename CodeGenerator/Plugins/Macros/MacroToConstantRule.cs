using System;
using System.Linq;
using System.Text.RegularExpressions;
using CodeGenerator.Utilities;
using CppAst;
using CppAst.CodeGen.CSharp;
using Zio;

namespace CodeGenerator.Plugins.Macros
{
	public class MacroToConstantRule : MacroRule
	{
		public string FileName { get; set; }
		public string ClassName { get; set; }
		public CSharpPrimitiveType ConstantType { get; set; }
		public Func<string, string> Renamer { get; set; }

		public MacroToConstantRule(string regexNameMatch, CSharpPrimitiveType constantType, string fileName, string className, Func<string, string> renamer = null) : base(regexNameMatch)
		{
			FileName = fileName;
			ClassName = className;
			ConstantType = constantType;
			Renamer = renamer;
		}

		public override void Process(CSharpConverter converter, CppMacro macro, Match match)
		{
			var csCompilation = converter.CurrentCSharpCompilation;

			if (csCompilation.Members.FirstOrDefault(m => m is CSharpGeneratedFile f && f.FilePath == FileName) is not CSharpGeneratedFile file
			|| file.Members.FirstOrDefault(m => m is CSharpNamespace ns && ns.Name == converter.Options.DefaultNamespace) is not CSharpNamespace csNamespace) {
				file = new CSharpGeneratedFile(new UPath(FileName));
				csNamespace = new CSharpNamespace(converter.Options.DefaultNamespace);

				csCompilation.Members.Add(file);
				file.Members.Add(csNamespace);
			}

			if (csNamespace.Members.FirstOrDefault(e => e is CSharpClass csClass && csClass.Name == ClassName) is not CSharpClass csClass) {
				csClass = new CSharpClass(ClassName);

				csNamespace.Members.Insert(0, csClass);
			}

			string itemName = match.Value;

			if (Renamer != null) {
				itemName = Renamer(itemName);
			}

			string value = macro.Value;

			// Try to detect references to other macros
			if (!int.TryParse(value, out _)) {
				value = MacroUtils.RenameMacrosInExpression(value, converter.CurrentCppCompilation.Macros, Renamer);
			}

			csClass.Members.Add(new CSharpField(itemName) {
				Modifiers = CSharpModifiers.Const,
				InitValue = value,
				FieldType = ConstantType
			});
		}
	}
}
