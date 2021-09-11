using System;
using System.Collections.Generic;
using CppAst.CodeGen.CSharp;

namespace CodeGenerator.Utilities
{
	public static class CSharpTypeExtensions
	{
		public static CSharpType FindType(this CSharpElement element, string fullPath)
			=> TryFindType(element, fullPath, out var result) ? result : throw new Exception($"Couldn't find a type with full path of '{fullPath}'.");

		public static bool TryFindType(this CSharpElement element, string fullPath, out CSharpType result)
		{
			var topParent = element;

			while(topParent.Parent != null) {
				topParent = topParent.Parent;
			}

			if(!(topParent is CSharpCompilation csCompilation)) {
				throw new ArgumentException("Element does not have a compilation in its parents.");
			}

			bool RecursiveSearch(string path, IEnumerable<CSharpElement> elements, out CSharpType result)
			{
				foreach(CSharpElement csElement in elements) {
					if(!(csElement is CSharpNamedType subType)) {
						continue;
					}

					string subPath = $"{path}.{subType.Name}";

					if(subPath == fullPath) {
						result = subType;

						return true;
					}

					if(subType is CSharpTypeWithMembers subTypeWithMembers && RecursiveSearch(subPath, subTypeWithMembers.Members, out result)) {
						return true;
					}
				}

				result = default;

				return false;
			}


			foreach(CSharpGeneratedFile csFile in csCompilation.Members) {
				foreach(CSharpNamespace csNamespace in csFile.Members) {
					if(RecursiveSearch(csNamespace.Name, csNamespace.Members, out result)) {
						return true;
					}
				}
			}

			result = default;

			return false;
		}
	}
}
