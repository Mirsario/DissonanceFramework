using System.Collections.Generic;
using static Dissonance.Framework.OSUtils;

namespace Dissonance.Framework.Imaging
{
	public static partial class IL
	{
		internal const string Library = "DevIL.dll";

		private static readonly string[] DefaultPathsWindows = {
			Library
		};
		private static readonly string[] DefaultPathsLinux = {
			"libdevil.so.3",
			"libdevil.so"
		};
		private static readonly string[] DefaultPathsOSX = {
			"libdevil.dylib",
			"libdevil.dylib",
			"libdevil.so.3",
			"libdevil.so"
		};

		static IL() => DllManager.PrepareResolvers();

		internal static IEnumerable<string> GetLibraryPaths() => GetOS() switch {
			OS.Windows => DefaultPathsWindows,
			OS.Linux => DefaultPathsLinux,
			OS.OSX => DefaultPathsOSX,
			_ => null
		};
	}
}
