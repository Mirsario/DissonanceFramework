using CppAst;

namespace CodeGenerator.Utilities
{
	public static class CppTypeExtensions
	{
		public static CppType GetLastElementType(this CppType type)
		{
			while(type is CppTypeWithElementType typeWithElement) {
				type = typeWithElement.ElementType;
			}

			return type;
		}
	}
}
