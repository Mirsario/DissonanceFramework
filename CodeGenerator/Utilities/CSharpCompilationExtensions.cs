using System;
using System.Collections.Generic;
using CppAst.CodeGen.CSharp;

namespace CodeGenerator.Utilities
{
	public static class CSharpCompilationExtensions
	{
		public static T FindElement<T>(this CSharpCompilation csCompilation, string fullPath) where T : CSharpElement
			=> TryFindElement<T>(csCompilation, fullPath, out var result) ? result : throw new Exception($"Couldn't find an element with full path of '{fullPath}'.");

		public static bool TryFindElement<T>(this CSharpCompilation csCompilation, string fullPath, out T result) where T : CSharpElement
		{
			int lastPeriodIndex = fullPath.LastIndexOf('.');
			string partialPath = fullPath.Substring(0, lastPeriodIndex);
			string lastPathMember = fullPath.Substring(lastPeriodIndex + 1);
			;

			bool RecursiveSearch(string path, IEnumerable<CSharpElement> elements, out T result)
			{
				foreach (CSharpElement csElement in elements) {
					string name = csElement.GetName();

					if (name == null) {
						continue;
					}

					string newPath = path != null ? $"{path}.{name}" : name;

					if (csElement is T tElement && newPath == fullPath) {
						result = tElement;

						return true;
					}

					if (!fullPath.StartsWith($"{newPath}.")) {
						continue;
					}

					if (csElement is ICSharpContainer csharpContainer && RecursiveSearch(newPath, csharpContainer.Members, out result)) {
						return true;
					}
				}

				result = default;

				return false;
			}


			foreach (CSharpGeneratedFile csFile in csCompilation.Members) {
				if (RecursiveSearch(null, csFile.Members, out result)) {
					return true;
				}
			}

			result = default;

			return false;
		}
	}
}
