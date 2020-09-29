using System.Collections.Generic;
using System.Runtime.CompilerServices;
using static Dissonance.Framework.OSUtils;

namespace Dissonance.Framework.Audio
{
	public static partial class AL
	{
		internal const string Library = "soft_oal.dll";

		private const int AI = (int)MethodImplOptions.AggressiveInlining;

		private static readonly string[] LibraryNamesWindows = {
			Library
		};
		private static readonly string[] LibraryNamesLinux = {
			"libopenal.so.1",
			"libopenal.so",
			"soft_oal.so"
		};
		private static readonly string[] LibraryNamesOSX = {
			"libopenal.1.20.1.dylib",
			"libopenal.1.dylib",
			"libopenal.dylib"
		};

		static AL() => DllManager.PrepareResolvers();

		internal static string[] GetLibraryNames() => GetOS() switch
		{
			OS.Windows => LibraryNamesWindows,
			OS.Linux => LibraryNamesLinux,
			OS.OSX => LibraryNamesOSX,
			_ => null
		};
	}
}
