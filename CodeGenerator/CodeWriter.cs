using System;
using System.IO;
using System.Text;

namespace CodeGenerator
{
	public class CodeWriter
	{
		public readonly StringBuilder StringBuilder;
		public readonly string OutputPath;

		private int numTabs;
		private string tabs;

		public CodeWriter(string outputPath)
		{
			OutputPath = outputPath;
			StringBuilder = new StringBuilder();

			tabs = string.Empty;
		}

		public void Indent() => tabs = new string('\t',++numTabs);
		public void Unindent()
		{
			if(numTabs<=0) {
				throw new InvalidOperationException("Already at <=0 tabs.");
			}

			tabs = new string('\t',--numTabs);
		}
		public void AppendLine() => StringBuilder.AppendLine(tabs);
		public void AppendLine(string line) => StringBuilder.AppendLine($"{tabs}{line}");
		public void Save()
		{
			File.WriteAllText(OutputPath,StringBuilder.ToString());
		}
	}
}
