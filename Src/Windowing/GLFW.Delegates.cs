using System;
using UFP = System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute;
using CC = System.Runtime.InteropServices.CallingConvention;
using System.Runtime.InteropServices;
using Dissonance.Framework.Windowing.Input;

namespace Dissonance.Framework.Windowing
{
	partial class GLFW
	{
		[UFP(CC.Cdecl)] public delegate void ErrorCallback(GLFWError code,[In] [MarshalAs(UnmanagedType.LPStr)] string description);
		[UFP(CC.Cdecl)] public delegate void WindowPosCallback(IntPtr window,int x,int y);
		[UFP(CC.Cdecl)] public delegate void WindowSizeCallback(IntPtr window,int w,int h);
		[UFP(CC.Cdecl)] public delegate void WindowCloseCallback(IntPtr window);
		[UFP(CC.Cdecl)] public delegate void WindowRefreshCallback(IntPtr window);
		[UFP(CC.Cdecl)] public delegate void WindowFocusCallback(IntPtr window,int got);
		[UFP(CC.Cdecl)] public delegate void WindowIconifyCallback(IntPtr window,int iconify);
		[UFP(CC.Cdecl)] public delegate void FramebufferSizeCallback(IntPtr window,int w,int h);
		[UFP(CC.Cdecl)] public delegate void MouseButtonCallback(IntPtr window,MouseButton button,MouseAction action,KeyModifiers mods);
		[UFP(CC.Cdecl)] public delegate void CursorPosCallback(IntPtr window,double x,double y);
		[UFP(CC.Cdecl)] public delegate void CursorEnterCallback(IntPtr window,int entered);
		[UFP(CC.Cdecl)] public delegate void ScrollCallback(IntPtr window,double xOffset,double yOffset);
		[UFP(CC.Cdecl)] public delegate void KeyCallback(IntPtr window,Keys key,int scanCode,KeyAction action,KeyModifiers mods);
		[UFP(CC.Cdecl)] public delegate void CharCallback(IntPtr window,uint codePoint);
		[UFP(CC.Cdecl)] public delegate void CharModsCallback(IntPtr window,uint codePoint,int mods);
		[UFP(CC.Cdecl)] public delegate void DropCallback(IntPtr window,int count,[Out] string[] paths);
		[UFP(CC.Cdecl)] public delegate void MonitorCallback(IntPtr window,int ev);
		[UFP(CC.Cdecl)] public delegate void JoystickCallback(int window,int ev);
	}
}
