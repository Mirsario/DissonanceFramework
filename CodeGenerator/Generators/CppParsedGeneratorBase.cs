using System.Collections.Generic;
using System.IO;
using CppAst.CodeGen.CSharp;

namespace CodeGenerator.Generators
{
	public abstract class CppParsedGeneratorBase : CppGeneratorBase
	{
		public readonly string InputFile;

		public CppParsedGeneratorBase(string inputFile) : base()
		{
			InputFile = inputFile;
		}

		public override CSharpCompilation GetCSharpCompilation()
		{
			Options.IncludeFolders.Clear();
			Options.IncludeFolders.Add(Path.GetDirectoryName(InputFile));

			var csCompilation = CSharpConverter.Convert(new List<string> { InputFile }, Options);

			return csCompilation;
		}
	}
}
