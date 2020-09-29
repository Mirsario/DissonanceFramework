using System;
using System.Runtime.InteropServices;
using CC = System.Runtime.InteropServices.CallingConvention;

#pragma warning disable IDE0060 //Unused parameter.

namespace Dissonance.Framework.Windowing
{
	partial class GLFW
	{
		[DllImport(Library, EntryPoint = "glfwInit", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern int Init();

		[DllImport(Library, EntryPoint = "glfwTerminate", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern void Terminate();

		[DllImport(Library, EntryPoint = "glfwExtensionSupported", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern int ExtensionSupported([In][MarshalAs(UnmanagedType.LPStr)] string extension);

		[DllImport(Library, EntryPoint = "glfwPollEvents", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern void PollEvents();

		[DllImport(Library, EntryPoint = "glfwWaitEvents", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern void WaitEvents();

		[DllImport(Library, EntryPoint = "glfwWaitEventsTimeout", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern void WaitEventsTimeout(double timeout);

		[DllImport(Library, EntryPoint = "glfwPostEmptyEvent", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern void PostEmptyEvent();

		[DllImport(Library, EntryPoint = "glfwMakeContextCurrent", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern void MakeContextCurrent(IntPtr window);

		[DllImport(Library, EntryPoint = "glfwSwapBuffers", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern void SwapBuffers(IntPtr window);

		[DllImport(Library, EntryPoint = "glfwSwapInterval", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern void SwapInterval(int interval);

		//Get

		[DllImport(Library, EntryPoint = "glfwGetProcAddress", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern IntPtr GetProcAddress([In][MarshalAs(UnmanagedType.LPStr)] string name);

		[DllImport(Library, EntryPoint = "glfwGetVersion", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern void GetVersion([Out] out int major, [Out] out int minor, [Out] out int rev);

		[DllImport(Library, EntryPoint = "glfwGetCurrentContext", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern IntPtr GetCurrentContext();

		[DllImport(Library, EntryPoint = "glfwGetFramebufferSize", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern void GetFramebufferSize(IntPtr window, [Out] out int width, [Out] out int height);

		[DllImport(Library, EntryPoint = "glfwGetRequiredInstanceExtensions", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern IntPtr GetRequiredInstanceExtensions(out uint count);

		[DllImport(Library, EntryPoint = "glfwVulkanSupported", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern int VulkanSupported();

		public static string GetVersionString() => Marshal.PtrToStringAnsi(GetVersionStringInternal());

		[DllImport(Library, EntryPoint = "glfwGetVersionString", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		private static extern IntPtr GetVersionStringInternal();

		public static string GetClipboardString(IntPtr window) => Marshal.PtrToStringAnsi(GetClipboardStringInternal(window));

		[DllImport(Library, EntryPoint = "glfwGetClipboardString", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		private static extern IntPtr GetClipboardStringInternal(IntPtr window);

		//Set

		[DllImport(Library, EntryPoint = "glfwSetClipboardString", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern void SetClipboardString(IntPtr window, [In][MarshalAs(UnmanagedType.LPStr)] string str);

		//Callbacks

		[DllImport(Library, EntryPoint = "glfwSetErrorCallback", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern void SetErrorCallback(IntPtr callback);

		[DllImport(Library, EntryPoint = "glfwSetFramebufferSizeCallback", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern void SetFramebufferSizeCallback(IntPtr window, IntPtr callback);
	}
}
