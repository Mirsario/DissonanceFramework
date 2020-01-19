using System;
using NotImplementedException = System.NotImplementedException;

#pragma warning disable IDE0060 //Unused parameter.

namespace Dissonance.Framework.GLFW3
{
	partial class GLFW
	{
		[MethodImport("glfwInit")]
		public static int Init()
			=> throw new NotImplementedException();

		[MethodImport("glfwTerminate")]
		public static void Terminate()
			=> throw new NotImplementedException();

		[MethodImport("glfwGetVersion")]
		public static void GetVersion(ref int major,ref int minor,ref int rev)
			=> throw new NotImplementedException();

		[MethodImport("glfwSetErrorCallback")]
		public static errorfun SetErrorCallback(errorfun cbfun)
			=> throw new NotImplementedException();

		[MethodImport("glfwGetMonitors")]
		public static IntPtr GetMonitors(ref int count)
			=> throw new NotImplementedException();

		[MethodImport("glfwGetPrimaryMonitor")]
		public static IntPtr GetPrimaryMonitor()
			=> throw new NotImplementedException();

		[MethodImport("glfwGetMonitorPos")]
		public static void GetMonitorPos(IntPtr monitor,ref int xpos,ref int ypos)
			=> throw new NotImplementedException();

		[MethodImport("glfwGetMonitorPhysicalSize")]
		public static void GetMonitorPhysicalSize(IntPtr monitor,ref int widthMM,ref int heightMM)
			=> throw new NotImplementedException();

		[MethodImport("glfwGetMonitorName")]
		public static IntPtr GetMonitorName(IntPtr monitor)
			=> throw new NotImplementedException();

		[MethodImport("glfwSetMonitorCallback")]
		public static monitorfun SetMonitorCallback(monitorfun cbfun)
			=> throw new NotImplementedException();

		[MethodImport("glfwGetVideoModes")]
		public static IntPtr GetVideoModes(IntPtr monitor,ref int count)
			=> throw new NotImplementedException();

		[MethodImport("glfwGetVideoMode")]
		public static IntPtr GetVideoMode(IntPtr monitor)
			=> throw new NotImplementedException();

		[MethodImport("glfwSetGamma")]
		public static void SetGamma(IntPtr monitor,float gamma)
			=> throw new NotImplementedException();

		[MethodImport("glfwGetGammaRamp")]
		public static IntPtr GetGammaRamp(IntPtr monitor)
			=> throw new NotImplementedException();

		[MethodImport("glfwSetGammaRamp")]
		public static void SetGammaRamp(IntPtr monitor,ref GammaRamp ramp)
			=> throw new NotImplementedException();

		[MethodImport("glfwDefaultWindowHints")]
		public static void DefaultWindowHints()
			=> throw new NotImplementedException();

		[MethodImport("glfwWindowHint")]
		public static void WindowHint(int hint,int value)
			=> throw new NotImplementedException();

		[MethodImport("glfwDestroyWindow")]
		public static void DestroyWindow(IntPtr window)
			=> throw new NotImplementedException();

		[MethodImport("glfwWindowShouldClose")]
		public static int WindowShouldClose(IntPtr window)
			=> throw new NotImplementedException();

		[MethodImport("glfwSetWindowShouldClose")]
		public static void SetWindowShouldClose(IntPtr window,int value)
			=> throw new NotImplementedException();

		[MethodImport("glfwSetWindowIcon")]
		public static void SetWindowIcon(IntPtr window,int count,ref Image images)
			=> throw new NotImplementedException();

		[MethodImport("glfwGetWindowPos")]
		public static void GetWindowPos(IntPtr window,ref int xpos,ref int ypos)
			=> throw new NotImplementedException();

		[MethodImport("glfwSetWindowPos")]
		public static void SetWindowPos(IntPtr window,int xpos,int ypos)
			=> throw new NotImplementedException();

		[MethodImport("glfwGetWindowSize")]
		public static void GetWindowSize(IntPtr window,ref int width,ref int height)
			=> throw new NotImplementedException();

		[MethodImport("glfwSetWindowSizeLimits")]
		public static void SetWindowSizeLimits(IntPtr window,int minwidth,int minheight,int maxwidth,int maxheight)
			=> throw new NotImplementedException();

		[MethodImport("glfwSetWindowAspectRatio")]
		public static void SetWindowAspectRatio(IntPtr window,int numer,int denom)
			=> throw new NotImplementedException();

		[MethodImport("glfwSetWindowSize")]
		public static void SetWindowSize(IntPtr window,int width,int height)
			=> throw new NotImplementedException();

		[MethodImport("glfwGetFramebufferSize")]
		public static void GetFramebufferSize(IntPtr window,ref int width,ref int height)
			=> throw new NotImplementedException();

		[MethodImport("glfwGetWindowFrameSize")]
		public static void GetWindowFrameSize(IntPtr window,ref int left,ref int top,ref int right,ref int bottom)
			=> throw new NotImplementedException();

		[MethodImport("glfwIconifyWindow")]
		public static void IconifyWindow(IntPtr window)
			=> throw new NotImplementedException();

		[MethodImport("glfwRestoreWindow")]
		public static void RestoreWindow(IntPtr window)
			=> throw new NotImplementedException();

		[MethodImport("glfwMaximizeWindow")]
		public static void MaximizeWindow(IntPtr window)
			=> throw new NotImplementedException();

		[MethodImport("glfwShowWindow")]
		public static void ShowWindow(IntPtr window)
			=> throw new NotImplementedException();

		[MethodImport("glfwHideWindow")]
		public static void HideWindow(IntPtr window)
			=> throw new NotImplementedException();

		[MethodImport("glfwFocusWindow")]
		public static void FocusWindow(IntPtr window)
			=> throw new NotImplementedException();

		[MethodImport("glfwGetWindowMonitor")]
		public static IntPtr GetWindowMonitor(IntPtr window)
			=> throw new NotImplementedException();

		[MethodImport("glfwSetWindowMonitor")]
		public static void SetWindowMonitor(IntPtr window,IntPtr monitor,int xpos,int ypos,int width,int height,int refreshRate)
			=> throw new NotImplementedException();

		[MethodImport("glfwGetWindowAttrib")]
		public static int GetWindowAttrib(IntPtr window,int attrib)
			=> throw new NotImplementedException();

		[MethodImport("glfwSetWindowUserPointer")]
		public static void SetWindowUserPointer(IntPtr window,IntPtr pointer)
			=> throw new NotImplementedException();

		[MethodImport("glfwGetWindowUserPointer")]
		public static IntPtr GetWindowUserPointer(IntPtr window)
			=> throw new NotImplementedException();

		[MethodImport("glfwSetWindowPosCallback")]
		public static windowposfun SetWindowPosCallback(IntPtr window,windowposfun cbfun)
			=> throw new NotImplementedException();

		[MethodImport("glfwSetWindowSizeCallback")]
		public static windowsizefun SetWindowSizeCallback(IntPtr window,windowsizefun cbfun)
			=> throw new NotImplementedException();

		[MethodImport("glfwSetWindowCloseCallback")]
		public static windowclosefun SetWindowCloseCallback(IntPtr window,windowclosefun cbfun)
			=> throw new NotImplementedException();

		[MethodImport("glfwSetWindowRefreshCallback")]
		public static windowrefreshfun SetWindowRefreshCallback(IntPtr window,windowrefreshfun cbfun)
			=> throw new NotImplementedException();

		[MethodImport("glfwSetWindowFocusCallback")]
		public static windowfocusfun SetWindowFocusCallback(IntPtr window,windowfocusfun cbfun)
			=> throw new NotImplementedException();

		[MethodImport("glfwSetWindowIconifyCallback")]
		public static windowiconifyfun SetWindowIconifyCallback(IntPtr window,windowiconifyfun cbfun)
			=> throw new NotImplementedException();

		[MethodImport("glfwSetFramebufferSizeCallback")]
		public static framebuffersizefun SetFramebufferSizeCallback(IntPtr window,framebuffersizefun cbfun)
			=> throw new NotImplementedException();

		[MethodImport("glfwPollEvents")]
		public static void PollEvents()
			=> throw new NotImplementedException();

		[MethodImport("glfwWaitEvents")]
		public static void WaitEvents()
			=> throw new NotImplementedException();

		[MethodImport("glfwWaitEventsTimeout")]
		public static void WaitEventsTimeout(double timeout)
			=> throw new NotImplementedException();

		[MethodImport("glfwPostEmptyEvent")]
		public static void PostEmptyEvent()
			=> throw new NotImplementedException();

		[MethodImport("glfwGetInputMode")]
		public static int GetInputMode(IntPtr window,int mode)
			=> throw new NotImplementedException();

		[MethodImport("glfwSetInputMode")]
		public static void SetInputMode(IntPtr window,int mode,int value)
			=> throw new NotImplementedException();

		[MethodImport("glfwGetKeyName")]
		public static IntPtr GetKeyName(int key,int scancode)
			=> throw new NotImplementedException();

		[MethodImport("glfwGetKey")]
		public static int GetKey(IntPtr window,int key)
			=> throw new NotImplementedException();

		[MethodImport("glfwGetMouseButton")]
		public static int GetMouseButton(IntPtr window,int button)
			=> throw new NotImplementedException();

		[MethodImport("glfwGetCursorPos")]
		public static void GetCursorPos(IntPtr window,ref double xpos,ref double ypos)
			=> throw new NotImplementedException();

		[MethodImport("glfwSetCursorPos")]
		public static void SetCursorPos(IntPtr window,double xpos,double ypos)
			=> throw new NotImplementedException();

		[MethodImport("glfwCreateCursor")]
		public static IntPtr CreateCursor(ref Image image,int xhot,int yhot)
			=> throw new NotImplementedException();

		[MethodImport("glfwCreateStandardCursor")]
		public static IntPtr CreateStandardCursor(int shape)
			=> throw new NotImplementedException();

		[MethodImport("glfwDestroyCursor")]
		public static void DestroyCursor(IntPtr cursor)
			=> throw new NotImplementedException();

		[MethodImport("glfwSetCursor")]
		public static void SetCursor(IntPtr window,IntPtr cursor)
			=> throw new NotImplementedException();

		[MethodImport("glfwSetKeyCallback")]
		public static keyfun SetKeyCallback(IntPtr window,keyfun cbfun)
			=> throw new NotImplementedException();

		[MethodImport("glfwSetCharCallback")]
		public static charfun SetCharCallback(IntPtr window,charfun cbfun)
			=> throw new NotImplementedException();

		[MethodImport("glfwSetCharModsCallback")]
		public static charmodsfun SetCharModsCallback(IntPtr window,charmodsfun cbfun)
			=> throw new NotImplementedException();

		[MethodImport("glfwSetMouseButtonCallback")]
		public static mousebuttonfun SetMouseButtonCallback(IntPtr window,mousebuttonfun cbfun)
			=> throw new NotImplementedException();

		[MethodImport("glfwSetCursorPosCallback")]
		public static cursorposfun SetCursorPosCallback(IntPtr window,cursorposfun cbfun)
			=> throw new NotImplementedException();

		[MethodImport("glfwSetCursorEnterCallback")]
		public static cursorenterfun SetCursorEnterCallback(IntPtr window,cursorenterfun cbfun)
			=> throw new NotImplementedException();

		[MethodImport("glfwSetScrollCallback")]
		public static scrollfun SetScrollCallback(IntPtr window,scrollfun cbfun)
			=> throw new NotImplementedException();

		[MethodImport("glfwSetDropCallback")]
		public static dropfun SetDropCallback(IntPtr window,dropfun cbfun)
			=> throw new NotImplementedException();

		[MethodImport("glfwJoystickPresent")]
		public static int JoystickPresent(int joy)
			=> throw new NotImplementedException();

		[MethodImport("glfwGetJoystickAxes")]
		public static IntPtr GetJoystickAxes(int joy,ref int count)
			=> throw new NotImplementedException();

		[MethodImport("glfwGetJoystickButtons")]
		public static IntPtr GetJoystickButtons(int joy,ref int count)
			=> throw new NotImplementedException();

		[MethodImport("glfwGetJoystickName")]
		public static IntPtr GetJoystickName(int joy)
			=> throw new NotImplementedException();

		[MethodImport("glfwSetJoystickCallback")]
		public static joystickfun SetJoystickCallback(joystickfun cbfun)
			=> throw new NotImplementedException();

		[MethodImport("glfwGetTime")]
		public static double GetTime()
			=> throw new NotImplementedException();

		[MethodImport("glfwSetTime")]
		public static void SetTime(double time)
			=> throw new NotImplementedException();

		[MethodImport("glfwGetTimerValue")]
		public static uint GetTimerValue()
			=> throw new NotImplementedException();

		[MethodImport("glfwGetTimerFrequency")]
		public static uint GetTimerFrequency()
			=> throw new NotImplementedException();

		[MethodImport("glfwMakeContextCurrent")]
		public static void MakeContextCurrent(IntPtr window)
			=> throw new NotImplementedException();

		[MethodImport("glfwGetCurrentContext")]
		public static IntPtr GetCurrentContext()
			=> throw new NotImplementedException();

		[MethodImport("glfwSwapBuffers")]
		public static void SwapBuffers(IntPtr window)
			=> throw new NotImplementedException();

		[MethodImport("glfwSwapInterval")]
		public static void SwapInterval(int interval)
			=> throw new NotImplementedException();

		[MethodImport("glfwVulkanSupported")]
		public static int VulkanSupported()
			=> throw new NotImplementedException();

		[MethodImport("glfwGetRequiredInstanceExtensions")]
		public static IntPtr GetRequiredInstanceExtensions(ref uint count)
			=> throw new NotImplementedException();
	}
}
