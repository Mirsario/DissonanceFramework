using System.Collections.Generic;
using CppAst.CodeGen.Common;
using CppAst.CodeGen.CSharp;

namespace CodeGenerator
{
	public class CSharpGenericType : CSharpTypeWithElement
	{
		public List<CSharpType> TypeArguments { get; } = new();

		public CSharpGenericType(CSharpType elementType) : base(elementType) { }

		public override void DumpTo(CodeWriter writer)
        {
            ElementType?.DumpReferenceTo(writer);

            writer.Write("<");

			bool first = true;

			foreach (var argument in TypeArguments) {
				if (!first) {
					writer.Write(", ");
				} else {
					first = false;
				}

				argument.DumpReferenceTo(writer);
			}

			writer.Write(">");
		}
	}
}
