using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

namespace CodeGenerator
{
	public static class Generator
	{
		private static readonly Regex FunctionRegex = new Regex(@"function\s+(?:(unsafe\s)\s*)?(\S+)\s+(\w+)\((.*?)\)\s+:\s+(\w+)\s*;",RegexOptions.Compiled);
		private static readonly Regex ParameterRegex = new Regex(@"(?:\[.+?\]\s*)*((?:ref|in|out)\s+)?[\w\[\]*]+\s+(\w+)(?:\s*=\s*.+?)?(,|$)",RegexOptions.Compiled);
		private static readonly Regex DelegateNameRegex = new Regex(@"[a-z]*(\w+)",RegexOptions.Compiled);

		internal static void Main(string[] args)
		{
			string mainDirectory = args[0] ?? Path.GetFullPath("");

			var files = Directory.GetFiles(mainDirectory,"*.bindings",SearchOption.AllDirectories);

			for(int i = 0;i<files.Length;i++) {
				var file = files[i];

				ProcessFile(file);
			}

			Console.WriteLine("Success.");

			Thread.Sleep(500);
		}

		public static void ProcessFile(string file)
		{
			file = Path.GetFullPath(file);

			string fileName = Path.GetFileNameWithoutExtension(file);
			string outputDirectory = Path.Combine(Path.GetDirectoryName(file),"Generated");

			Console.Write($"Processing file '{fileName}'...");

			Directory.CreateDirectory(outputDirectory);

			var delegatesCode = CreateCode(
				Path.Combine(outputDirectory,$"{fileName}.Delegates.cs"),
				code => {
					code.AppendLine("using System;");
					code.AppendLine("using System.Runtime.InteropServices;");
					code.AppendLine("using CC = System.Runtime.InteropServices.CallingConvention;");
					code.AppendLine("using UFP = System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute;");
					code.AppendLine();
				}
			);

			var fieldsCode = CreateCode(
				Path.Combine(outputDirectory,$"{fileName}.Fields.cs"),
				code => {
					code.AppendLine("#pragma warning disable CS0649");
					code.AppendLine();
				}
			);

			var methodsCode = CreateCode(
				Path.Combine(outputDirectory,$"{fileName}.Methods.cs"),
				code => {
					code.AppendLine("using System;");
					code.AppendLine("using System.Runtime.InteropServices;");
					code.AppendLine("using System.Runtime.CompilerServices;");
					code.AppendLine();
				}
			);

			string text = File.ReadAllText(file);
			var functions = FunctionRegex.Matches(text);

			bool firstMatch = true;

			foreach(Match match in functions) {
				string modifiers = match.Groups[1].Value;
				string returnType = match.Groups[2].Value;
				string methodName = match.Groups[3].Value;
				string parameters = match.Groups[4].Value;
				string functionName = match.Groups[5].Value;

				string arguments = ParameterRegex.Replace(parameters,"$1$2$3");

				if(firstMatch) {
					firstMatch = false;
				} else {
					delegatesCode.AppendLine();
					fieldsCode.AppendLine();
					methodsCode.AppendLine();
				}

				string delegateName = DelegateNameRegex.Replace($"{functionName}Delegate","$1");

				//Delegates
				delegatesCode.AppendLine("[UFP(CC.Cdecl)]");
				delegatesCode.AppendLine($"private unsafe delegate {returnType} {delegateName}({parameters});");

				//Fields
				fieldsCode.AppendLine($@"[MethodImport(""{functionName}"")]");
				fieldsCode.AppendLine($"private static {delegateName} {functionName};");

				//Methods
				methodsCode.AppendLine($"[MethodImpl(ImplOptions)]");
				methodsCode.AppendLine($"public unsafe static {returnType} {methodName}({parameters})");
				methodsCode.AppendLine($"\t=> {functionName}({arguments});");
			}

			SaveCode(methodsCode);
			SaveCode(delegatesCode);
			SaveCode(fieldsCode);

			Console.WriteLine(" Done.");
		}

		private static CodeWriter CreateCode(string outputPath,Action<CodeWriter> preInit = null)
		{
			var code = new CodeWriter(outputPath);

			preInit?.Invoke(code);

			code.AppendLine("namespace Dissonance.Framework.Graphics");
			code.AppendLine("{");

			code.Indent();

			code.AppendLine("partial class GL");
			code.AppendLine("{");

			code.Indent();

			return code;
		}
		private static void SaveCode(CodeWriter code)
		{
			code.Unindent();
			code.AppendLine(@"}");
			code.Unindent();
			code.AppendLine(@"}");

			code.Save();
		}
	}
}
