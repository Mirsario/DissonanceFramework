using System.Runtime.InteropServices;

namespace Dissonance.Utils
{
	internal static class InternalUtils
	{
		public static OS GetOS()
		{
			if(RuntimeInformation.IsOSPlatform(OSPlatform.Linux)) {
				return OS.Linux;
			}

			if(RuntimeInformation.IsOSPlatform(OSPlatform.OSX)) {
				return OS.OSX;
			}

			if(RuntimeInformation.IsOSPlatform(OSPlatform.FreeBSD)) {
				return OS.FreeBSD;
			}

			return OS.Windows;
		}
	}
}
