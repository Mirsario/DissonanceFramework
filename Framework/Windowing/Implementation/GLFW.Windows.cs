using System;
using System.Runtime.InteropServices;
using CC = System.Runtime.InteropServices.CallingConvention;

#pragma warning disable IDE0060 //Unused parameter.

namespace Dissonance.Framework.Windowing
{
	partial class GLFW
	{
		//Get

		[DllImport(Library, EntryPoint = "glfwGetWindowPos", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern void GetWindowPos(IntPtr window, out int xPos, out int yPos);

		[DllImport(Library, EntryPoint = "glfwGetWindowSize", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern void GetWindowSize(IntPtr window, out int width, out int height);

		[DllImport(Library, EntryPoint = "glfwGetWindowFrameSize", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern void GetWindowFrameSize(IntPtr window, out int left, out int top, out int right, out int bottom);

		[DllImport(Library, EntryPoint = "glfwGetWindowMonitor", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern IntPtr GetWindowMonitor(IntPtr window);

		[DllImport(Library, EntryPoint = "glfwGetWindowAttrib", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern int GetWindowAttrib(IntPtr window, WindowAttribute attrib);

		[DllImport(Library, EntryPoint = "glfwGetWindowUserPointer", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern IntPtr GetWindowUserPointer(IntPtr window);

		//Set

		[DllImport(Library, EntryPoint = "glfwSetWindowShouldClose", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern void SetWindowShouldClose(IntPtr window, int value);

		[DllImport(Library, EntryPoint = "glfwSetWindowIcon", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern void SetWindowIcon(IntPtr window, int count, ref Image images);

		[DllImport(Library, EntryPoint = "glfwSetWindowPos", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern void SetWindowPos(IntPtr window, int xPos, int yPos);

		[DllImport(Library, EntryPoint = "glfwSetWindowSizeLimits", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern void SetWindowSizeLimits(IntPtr window, int minwidth, int minheight, int maxwidth, int maxheight);

		[DllImport(Library, EntryPoint = "glfwSetWindowAspectRatio", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern void SetWindowAspectRatio(IntPtr window, int numer, int denom);

		[DllImport(Library, EntryPoint = "glfwSetWindowSize", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern void SetWindowSize(IntPtr window, int width, int height);

		[DllImport(Library, EntryPoint = "glfwSetWindowMonitor", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern void SetWindowMonitor(IntPtr window, IntPtr monitor, int xPos, int yPos, int width, int height, int refreshRate);

		[DllImport(Library, EntryPoint = "glfwSetWindowUserPointer", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern void SetWindowUserPointer(IntPtr window, IntPtr pointer);

		[DllImport(Library, EntryPoint = "glfwSetWindowTitle", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern void SetWindowTitle(IntPtr window, [In][MarshalAs(UnmanagedType.LPStr)] string title);

		//Callbacks

		[DllImport(Library, EntryPoint = "glfwSetWindowPosCallback", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern void SetWindowPosCallback(IntPtr window, IntPtr callback);

		[DllImport(Library, EntryPoint = "glfwSetWindowSizeCallback", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern void SetWindowSizeCallback(IntPtr window, IntPtr callback);

		[DllImport(Library, EntryPoint = "glfwSetWindowCloseCallback", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern void SetWindowCloseCallback(IntPtr window, IntPtr callback);

		[DllImport(Library, EntryPoint = "glfwSetWindowRefreshCallback", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern void SetWindowRefreshCallback(IntPtr window, IntPtr callback);

		[DllImport(Library, EntryPoint = "glfwSetWindowFocusCallback", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern void SetWindowFocusCallback(IntPtr window, IntPtr callback);

		[DllImport(Library, EntryPoint = "glfwSetWindowIconifyCallback", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern void SetWindowIconifyCallback(IntPtr window, IntPtr callback);

		//Etc

		[DllImport(Library, EntryPoint = "glfwCreateWindow", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern IntPtr CreateWindow(int width, int height, [In][MarshalAs(UnmanagedType.LPStr)] string title, IntPtr monitor, IntPtr share);

		[DllImport(Library, EntryPoint = "glfwDefaultWindowHints", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern void DefaultWindowHints();

		[DllImport(Library, EntryPoint = "glfwWindowHint", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern void WindowHint(WindowHint hint, int value);

		[DllImport(Library, EntryPoint = "glfwDestroyWindow", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern void DestroyWindow(IntPtr window);

		[DllImport(Library, EntryPoint = "glfwWindowShouldClose", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern int WindowShouldClose(IntPtr window);

		[DllImport(Library, EntryPoint = "glfwIconifyWindow", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern void IconifyWindow(IntPtr window);

		[DllImport(Library, EntryPoint = "glfwRestoreWindow", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern void RestoreWindow(IntPtr window);

		[DllImport(Library, EntryPoint = "glfwMaximizeWindow", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern void MaximizeWindow(IntPtr window);

		[DllImport(Library, EntryPoint = "glfwShowWindow", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern void ShowWindow(IntPtr window);

		[DllImport(Library, EntryPoint = "glfwHideWindow", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern void HideWindow(IntPtr window);

		[DllImport(Library, EntryPoint = "glfwFocusWindow", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern void FocusWindow(IntPtr window);
	}
}
