using System.Collections.Generic;

namespace Dissonance.Framework.Windowing
{
	public static partial class GLFW
	{
		internal const string Library = "glfw3.dll";

		private static readonly string[] LibraryNamesWindows = {
			Library
		};
		private static readonly string[] LibraryNamesLinux = {
			"libglfw.so.3",
			"libglfw.so"
		};
		private static readonly string[] LibraryNamesOSX = {
			"libglfw.3.dylib",
			"libglfw.dylib",
			"libglfw.so.3",
			"libglfw.so"
		};

		static GLFW() => DllManager.PrepareResolvers();

		internal static string[] GetLibraryNames() => OSUtils.GetOS() switch
		{
			OSUtils.OS.Windows => LibraryNamesWindows,
			OSUtils.OS.Linux => LibraryNamesLinux,
			OSUtils.OS.OSX => LibraryNamesOSX,
			_ => null
		};
	}
}
