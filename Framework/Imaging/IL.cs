using System.Collections.Generic;
using static Dissonance.Framework.OSUtils;

namespace Dissonance.Framework.Imaging
{
	public static partial class IL
	{
		internal const string Library = "DevIL.dll";

		private static readonly string[] LibraryNamesWindows = {
			Library
		};
		private static readonly string[] LibraryNamesLinux = {
			"libIL.so.1.1.0",
			"libIL.so.1",
			"libIL.so"
		};
		private static readonly string[] LibraryNamesOSX = {
			"libIL.dylib"
		};

		static IL() => DllManager.PrepareResolvers();

		internal static string[] GetLibraryNames() => GetOS() switch
		{
			OS.Windows => LibraryNamesWindows,
			OS.Linux => LibraryNamesLinux,
			OS.OSX => LibraryNamesOSX,
			_ => null
		};
	}
}
