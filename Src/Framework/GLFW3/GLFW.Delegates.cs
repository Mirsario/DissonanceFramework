using System;
using UFP = System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute;
using CC = System.Runtime.InteropServices.CallingConvention;
using System.Runtime.InteropServices;

namespace Dissonance.Framework.GLFW3
{
	partial class GLFW
	{
		[UFP(CC.Cdecl)] public delegate void vk();
		[UFP(CC.Cdecl)] public delegate void errorfun(int code,[In] [MarshalAs(UnmanagedType.LPStr)] string description);
		[UFP(CC.Cdecl)] public delegate void windowposfun(IntPtr window,int x,int y);
		[UFP(CC.Cdecl)] public delegate void windowsizefun(IntPtr window,int w,int h);
		[UFP(CC.Cdecl)] public delegate void windowclosefun(IntPtr window);
		[UFP(CC.Cdecl)] public delegate void windowrefreshfun(IntPtr window);
		[UFP(CC.Cdecl)] public delegate void windowfocusfun(IntPtr window,int got);
		[UFP(CC.Cdecl)] public delegate void windowiconifyfun(IntPtr window,int iconify);
		[UFP(CC.Cdecl)] public delegate void framebuffersizefun(IntPtr window,int w,int h);
		[UFP(CC.Cdecl)] public delegate void mousebuttonfun(IntPtr window,int button,int action,int mods);
		[UFP(CC.Cdecl)] public delegate void cursorposfun(IntPtr window,double x,double y);
		[UFP(CC.Cdecl)] public delegate void cursorenterfun(IntPtr window,int entered);
		[UFP(CC.Cdecl)] public delegate void scrollfun(IntPtr window,double xoffset,double yoffset);
		[UFP(CC.Cdecl)] public delegate void keyfun(IntPtr window,int key,int scancode,int action,int mods);
		[UFP(CC.Cdecl)] public delegate void charfun(IntPtr window,uint codepoint);
		[UFP(CC.Cdecl)] public delegate void charmodsfun(IntPtr window,uint codepoint,int mods);
		[UFP(CC.Cdecl)] public delegate void dropfun(IntPtr window,int count,[Out] string[] paths);
		[UFP(CC.Cdecl)] public delegate void monitorfun(IntPtr window,int ev);
		[UFP(CC.Cdecl)] public delegate void joystickfun(int window,int ev);
	}
}
