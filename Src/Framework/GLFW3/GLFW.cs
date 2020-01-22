using Dissonance.Utils;
using System.Collections.Generic;

namespace Dissonance.Framework.GLFW3
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

		internal static IEnumerable<string> GetLibraryPaths() => InternalUtils.GetOS() switch {
			OS.Windows => DefaultPathsWindows,
			OS.Linux => DefaultPathsLinux,
			OS.OSX => DefaultPathsOSX,
			_ => null
		};
	}
}
