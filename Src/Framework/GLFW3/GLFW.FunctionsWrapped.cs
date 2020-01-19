using System;
using System.Runtime.InteropServices;

#pragma warning disable IDE0060 //Unused parameter.

namespace Dissonance.Framework.GLFW3
{
	partial class GLFW
	{
		public static IntPtr GetProcAddress(string name)
			=> GetProcAddressInternal(Marshal.StringToHGlobalAnsi(name));

		public static string GetVersionString()
			=> Marshal.PtrToStringAnsi(GetVersionStringInternal());

		public static string GetClipboardString(IntPtr window)
			=> Marshal.PtrToStringAnsi(GetClipboardStringInternal(window));

		public static void SetClipboardString(IntPtr window,string str)
			=> SetClipboardStringInternal(window,Marshal.StringToHGlobalAnsi(str));

		public static void SetWindowTitle(IntPtr window,string title)
			=> SetWindowTitleInternal(window,Marshal.StringToHGlobalAnsi(title));

		public static IntPtr CreateWindow(int width,int height,string title,IntPtr monitor,IntPtr share)
			=> CreateWindowInternal(width,height,Marshal.StringToHGlobalAnsi(title),monitor,share);

		public static int ExtensionSupported(string extension)
			=> ExtensionSupportedInternal(Marshal.StringToHGlobalAnsi(extension));

		[MethodImport("glfwGetProcAddress")]
		private static IntPtr GetProcAddressInternal(IntPtr name)
			=> throw new NotImplementedException();

		[MethodImport("glfwGetVersionString")]
		private static IntPtr GetVersionStringInternal()
			=> throw new NotImplementedException();

		[MethodImport("glfwGetClipboardString")]
		private static IntPtr GetClipboardStringInternal(IntPtr window)
			=> throw new NotImplementedException();

		[MethodImport("glfwSetClipboardString")]
		private static void SetClipboardStringInternal(IntPtr window,IntPtr str)
			=> throw new NotImplementedException();

		[MethodImport("glfwSetWindowTitle")]
		private static void SetWindowTitleInternal(IntPtr window,IntPtr title)
			=> throw new NotImplementedException();

		[MethodImport("glfwCreateWindow")]
		private static IntPtr CreateWindowInternal(int width,int height,IntPtr title,IntPtr monitor,IntPtr share)
			=> throw new NotImplementedException();

		[MethodImport("glfwExtensionSupported")]
		private static int ExtensionSupportedInternal(IntPtr extension)
			=> throw new NotImplementedException();
	}
}
