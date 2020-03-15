using System.Collections.Generic;

namespace Dissonance.Framework.Windowing
{
	public static partial class GLFW
	{
		internal const string Library = "glfw3.dll";

		private static readonly string[] DefaultPathsWindows = {
			"glfw3.dll"
		};
		private static readonly string[] DefaultPathsLinux = {
			"libglfw.so.3",
			"libglfw.so"
		};
		private static readonly string[] DefaultPathsOSX = {
			"libglfw3.dylib",
			"libglfw.dylib",
			"libglfw.so.3",
			"libglfw.so"
		};

		static GLFW() => DllManager.PrepareResolvers();

		internal static IEnumerable<string> GetLibraryPaths() => OSUtils.GetOS() switch {
			OSUtils.OS.Windows => DefaultPathsWindows,
			OSUtils.OS.Linux => DefaultPathsLinux,
			OSUtils.OS.OSX => DefaultPathsOSX,
			_ => null
		};
	}
}
