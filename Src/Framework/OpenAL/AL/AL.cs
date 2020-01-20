using Dissonance.Utils;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Dissonance.Framework.OpenAL
{
	public static partial class AL
	{
		internal const string Library = "soft_oal.dll";

		private const int AI = (int)MethodImplOptions.AggressiveInlining;

		private static readonly string[] DefaultPathsWindows = {
			"soft_oal.dll"
		};
		private static readonly string[] DefaultPathsLinux = {
			"libopenal.so.1",
			"libopenal.so",
			"soft_oal.so"
		};
		private static readonly string[] DefaultPathsOSX = {
			"libopenal.so.1",
			"libopenal.so",
			"soft_oal.so"
		};

		static AL() => DllManager.PrepareResolvers();

		internal static IEnumerable<string> GetLibraryPaths() => InternalUtils.GetOS() switch {
			OS.Windows => DefaultPathsWindows,
			OS.Linux => DefaultPathsLinux,
			OS.OSX => DefaultPathsOSX,
			_ => null
		};
	}
}
