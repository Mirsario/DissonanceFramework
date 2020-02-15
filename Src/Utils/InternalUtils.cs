using System.Runtime.InteropServices;

namespace Dissonance.Framework.Utils
{
	internal static class InternalUtils
	{
		public static bool IsOS(OS os)
		{
			return os switch
			{
				OS.Windows => RuntimeInformation.IsOSPlatform(OSPlatform.Windows),
				OS.Linux => RuntimeInformation.IsOSPlatform(OSPlatform.Linux),
				OS.OSX => RuntimeInformation.IsOSPlatform(OSPlatform.OSX),
				OS.FreeBSD => RuntimeInformation.IsOSPlatform(OSPlatform.FreeBSD),
				_ => false
			};
		}
		public static OS GetOS()
		{
			if(IsOS(OS.Linux)) {
				return OS.Linux;
			}

			if(IsOS(OS.OSX)) {
				return OS.OSX;
			}

			if(IsOS(OS.FreeBSD)) {
				return OS.FreeBSD;
			}

			return OS.Windows;
		}
	}
}
