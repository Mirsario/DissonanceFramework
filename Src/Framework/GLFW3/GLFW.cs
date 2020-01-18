using System;

namespace Dissonance.Framework.GLFW3
{
	public static partial class GLFW
	{
		public const string DefaultGLFWPathWindows = "glfw3.dll";
		public const string DefaultGLFWPathLinux = "./libglfw.so";
		//public const string DefaultGLFWPathMac = "./libglfw3.dylib";

		private static IntPtr glfwHandle;

		public static void Load(string windowsPath = DefaultGLFWPathWindows,string linuxPath = DefaultGLFWPathLinux)
		{
			string path = DllManager.Linux ? linuxPath : windowsPath;

			glfwHandle = DllManager.DllLoad(path);

			DllManager.DllLinkAllDelegates(typeof(GLFW),glfwHandle,"glfw");
		}
	}
}
