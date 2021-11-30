using System;
using System.Collections.Generic;
using System.Text;
using CppAst.CodeGen.CSharp;

namespace CodeGenerator.Utilities
{
	public static class CSharpElementExtensions
	{
		public static string GetName(this CSharpElement csharpELement)
		{
			// Workarounds for lacking interfaces..
			return (csharpELement as ICSharpMember)?.Name
				?? (csharpELement as CSharpMethod)?.Name
				?? (csharpELement as CSharpProperty)?.Name
				?? (csharpELement as CSharpEnumItem)?.Name
				?? (csharpELement as CSharpNamespace)?.Name;
		}

		public static string FullIdentifier(this CSharpElement csharpElement)
		{
			var currentElement = csharpElement;
			var sb = new StringBuilder();

			while (currentElement != null) {
				string name = currentElement.GetName();

				if (name != null) {
					sb.Insert(0, $"{name}{(currentElement != csharpElement ? "." : null)}");

					if (currentElement is CSharpNamespace) {
						break;
					}
				}

				currentElement = currentElement.Parent;
			}

			return sb.ToString();
		}

		public static T FindElement<T>(this CSharpElement element, string fullPath) where T : CSharpElement
			=> TryFindElement<T>(element, fullPath, out var result) ? result : throw new Exception($"Couldn't find an element with full path of '{fullPath}'.");

		public static bool TryFindElement<T>(this CSharpElement element, string fullPath, out T result) where T : CSharpElement
		{
			var topParent = element;

			while (topParent.Parent != null) {
				topParent = topParent.Parent;
			}
			
			if (topParent is not CSharpCompilation csCompilation) {
				throw new ArgumentException("Element does not have a compilation in its parents.");
			}

			return csCompilation.TryFindElement<T>(fullPath, out result);
		}
	}
}
