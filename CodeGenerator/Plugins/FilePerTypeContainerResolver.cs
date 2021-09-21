using System.Collections.Generic;
using System.IO;
using CppAst;
using CppAst.CodeGen.CSharp;
using Zio;

namespace CodeGenerator.Plugins
{
	public class FilePerTypeContainerResolver : ICSharpConverterPlugin
	{
        private static readonly string CacheContainerKey = $"{typeof(FilePerTypeContainerResolver)}.{nameof(CacheContainerKey)}";

		public void Register(CSharpConverter converter, CSharpConverterPipeline pipeline)
		{
			pipeline.GetCSharpContainerResolvers.Add(GetCSharpContainer);
		}

		public static ICSharpContainer GetCSharpContainer(CSharpConverter converter, CppElement element, CSharpElement context)
		{
			var cacheContainer = converter.GetTagValueOrDefault<CacheContainer>(CacheContainerKey);

			if (cacheContainer == null) {
				converter.Tags[CacheContainerKey] = cacheContainer = new CacheContainer();
			}

			if (element is CppTypeDeclaration cppTypeDeclaration && cppTypeDeclaration is ICppMember cppMember) {
				//if (!cacheContainer.CSharpElementToNamespace.TryGetValue(element, out var csNamespace)) {
					string filePath = Path.Combine(Path.GetDirectoryName(converter.Options.DefaultOutputFilePath.FullName), $"{cppMember.Name}.cs");
					var file = new CSharpGeneratedFile(new UPath(filePath));

					converter.CurrentCSharpCompilation.Members.Add(file);

					var csNamespace = new CSharpNamespace(converter.Options.DefaultNamespace);

					file.Members.Add(csNamespace);

					//cacheContainer.CSharpElementToNamespace[element] = csNamespace;
				//}

				return csNamespace;
			}

			return null;
		}

		private class CacheContainer
		{
			public Dictionary<CppElement, CSharpNamespace> CSharpElementToNamespace { get; } = new();
		}
	}
}
