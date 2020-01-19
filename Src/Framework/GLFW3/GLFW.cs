using Dissonance.Utils;
using System;

namespace Dissonance.Framework.GLFW3
{
	public static partial class GLFW
	{
		public const string DefaultPathWindows = "glfw3.dll";
		public const string DefaultPathLinux = "./libglfw.so";
		public const string DefaultPathOSX = "./libglfw3.dylib";

		private static IntPtr glfwHandle;

		public static bool IsReady { get; private set; }

		public static void Load() => Load(DefaultPathWindows,DefaultPathLinux,DefaultPathOSX);
		public static void Load(string windowsPath,string linuxPath,string osxPath) 
			=> Load(InternalUtils.GetOS() switch {
				OS.Windows => windowsPath,
				OS.Linux => linuxPath,
				OS.OSX => osxPath,
				_ => null
			});
		public static void Load(string osDependentPath)
		{
			if(IsReady) {
				return;
			}

			glfwHandle = DllManager.DllLoad(osDependentPath);

			DllManager.ImportTypeMethods(typeof(GLFW),functionName => DllManager.DllSymbol(glfwHandle,functionName));

			IsReady = true;
		}
	}
}
