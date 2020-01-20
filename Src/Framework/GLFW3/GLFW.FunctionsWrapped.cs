using System;
using System.Runtime.InteropServices;
using CC = System.Runtime.InteropServices.CallingConvention;

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

		[DllImport(Library,EntryPoint = "glfwGetProcAddress",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		private static extern IntPtr GetProcAddressInternal(IntPtr name);

		[DllImport(Library,EntryPoint = "glfwGetVersionString",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		private static extern IntPtr GetVersionStringInternal();

		[DllImport(Library,EntryPoint = "glfwGetClipboardString",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		private static extern IntPtr GetClipboardStringInternal(IntPtr window);

		[DllImport(Library,EntryPoint = "glfwSetClipboardString",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		private static extern void SetClipboardStringInternal(IntPtr window,IntPtr str);

		[DllImport(Library,EntryPoint = "glfwSetWindowTitle",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		private static extern void SetWindowTitleInternal(IntPtr window,IntPtr title);

		[DllImport(Library,EntryPoint = "glfwCreateWindow",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		private static extern IntPtr CreateWindowInternal(int width,int height,IntPtr title,IntPtr monitor,IntPtr share);

		[DllImport(Library,EntryPoint = "glfwExtensionSupported",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		private static extern int ExtensionSupportedInternal(IntPtr extension);
	}
}
