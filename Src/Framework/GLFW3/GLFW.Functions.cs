using System;
using System.Runtime.InteropServices;
using CC = System.Runtime.InteropServices.CallingConvention;

#pragma warning disable IDE0060 //Unused parameter.

namespace Dissonance.Framework.GLFW3
{
	partial class GLFW
	{
		#region General

		[DllImport(Library,EntryPoint = "glfwInit",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern int Init();

		[DllImport(Library,EntryPoint = "glfwTerminate",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void Terminate();

		[DllImport(Library,EntryPoint = "glfwExtensionSupported",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern int ExtensionSupported([In] [MarshalAs(UnmanagedType.LPStr)] string extension);

		[DllImport(Library,EntryPoint = "glfwPollEvents",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void PollEvents();

		[DllImport(Library,EntryPoint = "glfwWaitEvents",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void WaitEvents();

		[DllImport(Library,EntryPoint = "glfwWaitEventsTimeout",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void WaitEventsTimeout(double timeout);

		[DllImport(Library,EntryPoint = "glfwPostEmptyEvent",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void PostEmptyEvent();

		[DllImport(Library,EntryPoint = "glfwMakeContextCurrent",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void MakeContextCurrent(IntPtr window);

		[DllImport(Library,EntryPoint = "glfwSwapBuffers",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void SwapBuffers(IntPtr window);

		[DllImport(Library,EntryPoint = "glfwSwapInterval",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void SwapInterval(int interval);

		//Get

		[DllImport(Library,EntryPoint = "glfwGetProcAddress",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern IntPtr GetProcAddress([In] [MarshalAs(UnmanagedType.LPStr)] string name);

		[DllImport(Library,EntryPoint = "glfwGetVersion",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void GetVersion([Out] out int major,[Out] out int minor,[Out] out int rev);

		[DllImport(Library,EntryPoint = "glfwGetCurrentContext",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern IntPtr GetCurrentContext();

		[DllImport(Library,EntryPoint = "glfwGetFramebufferSize",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void GetFramebufferSize(IntPtr window,ref int width,ref int height);

		[DllImport(Library,EntryPoint = "glfwGetRequiredInstanceExtensions",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern IntPtr GetRequiredInstanceExtensions(ref uint count);

		[DllImport(Library,EntryPoint = "glfwVulkanSupported",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern int VulkanSupported();

		//Set

		[DllImport(Library,EntryPoint = "glfwSetErrorCallback",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern IntPtr SetErrorCallback(IntPtr cbfun);

		[DllImport(Library,EntryPoint = "glfwSetFramebufferSizeCallback",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern framebuffersizefun SetFramebufferSizeCallback(IntPtr window,framebuffersizefun cbfun);

		#endregion

		#region Window

		//Get

		[DllImport(Library,EntryPoint = "glfwGetWindowPos",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void GetWindowPos(IntPtr window,ref int xpos,ref int ypos);

		[DllImport(Library,EntryPoint = "glfwGetWindowSize",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void GetWindowSize(IntPtr window,ref int width,ref int height);

		[DllImport(Library,EntryPoint = "glfwGetWindowFrameSize",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void GetWindowFrameSize(IntPtr window,ref int left,ref int top,ref int right,ref int bottom);

		[DllImport(Library,EntryPoint = "glfwGetWindowMonitor",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern IntPtr GetWindowMonitor(IntPtr window);

		[DllImport(Library,EntryPoint = "glfwGetWindowAttrib",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern int GetWindowAttrib(IntPtr window,WindowAttribute attrib);

		[DllImport(Library,EntryPoint = "glfwGetWindowUserPointer",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern IntPtr GetWindowUserPointer(IntPtr window);

		//Set

		[DllImport(Library,EntryPoint = "glfwSetWindowShouldClose",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void SetWindowShouldClose(IntPtr window,int value);

		[DllImport(Library,EntryPoint = "glfwSetWindowIcon",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void SetWindowIcon(IntPtr window,int count,ref Image images);

		[DllImport(Library,EntryPoint = "glfwSetWindowPos",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void SetWindowPos(IntPtr window,int xpos,int ypos);

		[DllImport(Library,EntryPoint = "glfwSetWindowSizeLimits",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void SetWindowSizeLimits(IntPtr window,int minwidth,int minheight,int maxwidth,int maxheight);

		[DllImport(Library,EntryPoint = "glfwSetWindowAspectRatio",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void SetWindowAspectRatio(IntPtr window,int numer,int denom);

		[DllImport(Library,EntryPoint = "glfwSetWindowSize",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void SetWindowSize(IntPtr window,int width,int height);

		[DllImport(Library,EntryPoint = "glfwSetWindowMonitor",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void SetWindowMonitor(IntPtr window,IntPtr monitor,int xpos,int ypos,int width,int height,int refreshRate);

		[DllImport(Library,EntryPoint = "glfwSetWindowUserPointer",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void SetWindowUserPointer(IntPtr window,IntPtr pointer);

		[DllImport(Library,EntryPoint = "glfwSetWindowTitle",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void SetWindowTitle(IntPtr window,[In] [MarshalAs(UnmanagedType.LPStr)] string title);

		//Callbacks

		[DllImport(Library,EntryPoint = "glfwSetWindowPosCallback",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern windowposfun SetWindowPosCallback(IntPtr window,windowposfun cbfun);

		[DllImport(Library,EntryPoint = "glfwSetWindowSizeCallback",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern windowsizefun SetWindowSizeCallback(IntPtr window,windowsizefun cbfun);

		[DllImport(Library,EntryPoint = "glfwSetWindowCloseCallback",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern windowclosefun SetWindowCloseCallback(IntPtr window,windowclosefun cbfun);

		[DllImport(Library,EntryPoint = "glfwSetWindowRefreshCallback",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern windowrefreshfun SetWindowRefreshCallback(IntPtr window,windowrefreshfun cbfun);

		[DllImport(Library,EntryPoint = "glfwSetWindowFocusCallback",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern windowfocusfun SetWindowFocusCallback(IntPtr window,windowfocusfun cbfun);

		[DllImport(Library,EntryPoint = "glfwSetWindowIconifyCallback",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern windowiconifyfun SetWindowIconifyCallback(IntPtr window,windowiconifyfun cbfun);

		//Etc

		[DllImport(Library,EntryPoint = "glfwCreateWindow",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern IntPtr CreateWindow(int width,int height,[In] [MarshalAs(UnmanagedType.LPStr)] string title,IntPtr monitor,IntPtr share);

		[DllImport(Library,EntryPoint = "glfwDefaultWindowHints",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void DefaultWindowHints();

		[DllImport(Library,EntryPoint = "glfwWindowHint",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void WindowHint(WindowHint hint,int value);

		[DllImport(Library,EntryPoint = "glfwDestroyWindow",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void DestroyWindow(IntPtr window);

		[DllImport(Library,EntryPoint = "glfwWindowShouldClose",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern int WindowShouldClose(IntPtr window);

		[DllImport(Library,EntryPoint = "glfwIconifyWindow",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void IconifyWindow(IntPtr window);

		[DllImport(Library,EntryPoint = "glfwRestoreWindow",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void RestoreWindow(IntPtr window);

		[DllImport(Library,EntryPoint = "glfwMaximizeWindow",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void MaximizeWindow(IntPtr window);

		[DllImport(Library,EntryPoint = "glfwShowWindow",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void ShowWindow(IntPtr window);

		[DllImport(Library,EntryPoint = "glfwHideWindow",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void HideWindow(IntPtr window);

		[DllImport(Library,EntryPoint = "glfwFocusWindow",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void FocusWindow(IntPtr window);

		#endregion

		#region Monitors

		//Get

		[DllImport(Library,EntryPoint = "glfwGetPrimaryMonitor",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern IntPtr GetPrimaryMonitor();

		[DllImport(Library,EntryPoint = "glfwGetMonitors",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern IntPtr GetMonitors(ref int count);

		[DllImport(Library,EntryPoint = "glfwGetMonitorName",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern IntPtr GetMonitorName(IntPtr monitor);

		[DllImport(Library,EntryPoint = "glfwGetMonitorPos",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void GetMonitorPos(IntPtr monitor,ref int xpos,ref int ypos);

		[DllImport(Library,EntryPoint = "glfwGetMonitorPhysicalSize",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void GetMonitorPhysicalSize(IntPtr monitor,ref int widthMM,ref int heightMM);

		[DllImport(Library,EntryPoint = "glfwGetVideoMode",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern IntPtr GetVideoMode(IntPtr monitor);

		[DllImport(Library,EntryPoint = "glfwGetVideoModes",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern IntPtr GetVideoModes(IntPtr monitor,ref int count);

		[DllImport(Library,EntryPoint = "glfwGetGammaRamp",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern IntPtr GetGammaRamp(IntPtr monitor);

		//Set

		[DllImport(Library,EntryPoint = "glfwSetGamma",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void SetGamma(IntPtr monitor,float gamma);

		[DllImport(Library,EntryPoint = "glfwSetGammaRamp",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void SetGammaRamp(IntPtr monitor,ref GammaRamp ramp);

		//Callbacks

		[DllImport(Library,EntryPoint = "glfwSetMonitorCallback",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern monitorfun SetMonitorCallback(monitorfun cbfun);

		#endregion

		#region Input

		//Get

		[DllImport(Library,EntryPoint = "glfwGetInputMode",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern int GetInputMode(IntPtr window,int mode);

		[DllImport(Library,EntryPoint = "glfwGetKey",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern int GetKey(IntPtr window,int key);

		[DllImport(Library,EntryPoint = "glfwGetKeyName",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern IntPtr GetKeyName(int key,int scancode);

		[DllImport(Library,EntryPoint = "glfwGetCursorPos",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void GetCursorPos(IntPtr window,ref double xpos,ref double ypos);

		[DllImport(Library,EntryPoint = "glfwGetMouseButton",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern int GetMouseButton(IntPtr window,int button);

		[DllImport(Library,EntryPoint = "glfwGetJoystickAxes",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern IntPtr GetJoystickAxes(int joy,ref int count);

		[DllImport(Library,EntryPoint = "glfwGetJoystickButtons",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern IntPtr GetJoystickButtons(int joy,ref int count);

		[DllImport(Library,EntryPoint = "glfwGetJoystickName",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern IntPtr GetJoystickName(int joy);

		//Set

		[DllImport(Library,EntryPoint = "glfwSetInputMode",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void SetInputMode(IntPtr window,int mode,int value);

		[DllImport(Library,EntryPoint = "glfwSetCursorPos",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void SetCursorPos(IntPtr window,double xpos,double ypos);

		[DllImport(Library,EntryPoint = "glfwJoystickPresent",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern int JoystickPresent(int joy);

		//Callbacks

		[DllImport(Library,EntryPoint = "glfwSetKeyCallback",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern keyfun SetKeyCallback(IntPtr window,keyfun cbfun);

		[DllImport(Library,EntryPoint = "glfwSetCharCallback",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern charfun SetCharCallback(IntPtr window,charfun cbfun);

		[DllImport(Library,EntryPoint = "glfwSetCharModsCallback",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern charmodsfun SetCharModsCallback(IntPtr window,charmodsfun cbfun);

		[DllImport(Library,EntryPoint = "glfwSetMouseButtonCallback",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern mousebuttonfun SetMouseButtonCallback(IntPtr window,mousebuttonfun cbfun);

		[DllImport(Library,EntryPoint = "glfwSetCursorPosCallback",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern cursorposfun SetCursorPosCallback(IntPtr window,cursorposfun cbfun);

		[DllImport(Library,EntryPoint = "glfwSetCursorEnterCallback",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern cursorenterfun SetCursorEnterCallback(IntPtr window,cursorenterfun cbfun);

		[DllImport(Library,EntryPoint = "glfwSetScrollCallback",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern scrollfun SetScrollCallback(IntPtr window,scrollfun cbfun);

		[DllImport(Library,EntryPoint = "glfwSetDropCallback",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern dropfun SetDropCallback(IntPtr window,dropfun cbfun);

		[DllImport(Library,EntryPoint = "glfwSetJoystickCallback",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern joystickfun SetJoystickCallback(joystickfun cbfun);

		#endregion

		#region Time

		//Get

		[DllImport(Library,EntryPoint = "glfwGetTime",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern double GetTime();

		[DllImport(Library,EntryPoint = "glfwGetTimerValue",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern uint GetTimerValue();

		[DllImport(Library,EntryPoint = "glfwGetTimerFrequency",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern uint GetTimerFrequency();

		//Set

		[DllImport(Library,EntryPoint = "glfwSetTime",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void SetTime(double time);

		#endregion

		#region CursorImage

		[DllImport(Library,EntryPoint = "glfwCreateCursor",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern IntPtr CreateCursor(ref Image image,int xhot,int yhot);

		[DllImport(Library,EntryPoint = "glfwCreateStandardCursor",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern IntPtr CreateStandardCursor(int shape);

		[DllImport(Library,EntryPoint = "glfwSetCursor",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void SetCursor(IntPtr window,IntPtr cursor);

		[DllImport(Library,EntryPoint = "glfwDestroyCursor",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void DestroyCursor(IntPtr cursor);

		#endregion

		#region Clipboard

		[DllImport(Library,EntryPoint = "glfwSetClipboardString",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void SetClipboardString(IntPtr window,[In] [MarshalAs(UnmanagedType.LPStr)] string str);

		public static string GetClipboardString(IntPtr window) => Marshal.PtrToStringAnsi(GetClipboardStringInternal(window));

		[DllImport(Library,EntryPoint = "glfwGetClipboardString",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		private static extern IntPtr GetClipboardStringInternal(IntPtr window);

		#endregion

		#region Version

		public static string GetVersionString() => Marshal.PtrToStringAnsi(GetVersionStringInternal());

		[DllImport(Library,EntryPoint = "glfwGetVersionString",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		private static extern IntPtr GetVersionStringInternal();

		#endregion
	}
}
