using CppAst;
using CppAst.CodeGen.CSharp;

namespace CodeGenerator
{
	public class StructToVoidConverterPlugin : ICSharpConverterPlugin
	{
		public void Register(CSharpConverter converter, CSharpConverterPipeline pipeline)
		{
			pipeline.ClassConverters.Add(ConvertClass);
		}

		public static CSharpElement ConvertClass(CSharpConverter converter, CppClass cppClass, CSharpElement context)
		{
			// This converter only supports plain structs without fields
			if (cppClass.ClassKind != CppClassKind.Struct || cppClass.IsDefinition || cppClass.Fields.Count > 0) {
				return null;
			}

			return CSharpPrimitiveType.Void(); // Relying on 'ref void' being turned into IntPtr.
		}
	}
}
