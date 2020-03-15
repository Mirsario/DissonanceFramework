﻿using System.Collections.Generic;
using System.Runtime.CompilerServices;
using static Dissonance.Framework.OSUtils;

namespace Dissonance.Framework.Audio
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

		internal static IEnumerable<string> GetLibraryPaths() => GetOS() switch {
			OS.Windows => DefaultPathsWindows,
			OS.Linux => DefaultPathsLinux,
			OS.OSX => DefaultPathsOSX,
			_ => null
		};
	}
}
