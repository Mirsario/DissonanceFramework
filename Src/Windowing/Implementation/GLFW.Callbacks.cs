﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

#pragma warning disable IDE0060 //Unused parameter.

namespace Dissonance.Framework.Windowing
{
	partial class GLFW
	{
		private static readonly Dictionary<string,Delegate> CallbackCache = new Dictionary<string,Delegate>(); //Prevents delegates from getting GC'd.

		//General

		public static void SetErrorCallback(ErrorCallback callback)
		{
			CallbackCache[nameof(SetErrorCallback)] = callback;

			SetErrorCallback(callback==null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback));
		}

		public static void SetFramebufferSizeCallback(IntPtr window,FramebufferSizeCallback callback)
		{
			CallbackCache[nameof(SetFramebufferSizeCallback)] = callback;

			SetFramebufferSizeCallback(window,callback==null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback));
		}

		//Window

		public static void SetWindowPosCallback(IntPtr window,WindowPosCallback callback)
		{
			CallbackCache[nameof(SetWindowPosCallback)] = callback;

			SetWindowPosCallback(window,callback==null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback));
		}

		public static void SetWindowSizeCallback(IntPtr window,WindowSizeCallback callback)
		{
			CallbackCache[nameof(SetWindowSizeCallback)] = callback;

			SetWindowSizeCallback(window,callback==null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback));
		}

		public static void SetWindowCloseCallback(IntPtr window,WindowCloseCallback callback)
		{
			CallbackCache[nameof(SetWindowCloseCallback)] = callback;

			SetWindowCloseCallback(window,callback==null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback));
		}

		public static void SetWindowRefreshCallback(IntPtr window,WindowRefreshCallback callback)
		{
			CallbackCache[nameof(SetWindowRefreshCallback)] = callback;

			SetWindowRefreshCallback(window,callback==null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback));
		}

		public static void SetWindowFocusCallback(IntPtr window,WindowFocusCallback callback)
		{
			CallbackCache[nameof(SetWindowFocusCallback)] = callback;

			SetWindowFocusCallback(window,callback==null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback));
		}

		public static void SetWindowIconifyCallback(IntPtr window,WindowIconifyCallback callback)
		{
			CallbackCache[nameof(SetWindowIconifyCallback)] = callback;

			SetWindowIconifyCallback(window,callback==null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback));
		}

		//Monitors

		public static void SetMonitorCallback(MonitorCallback callback)
		{
			CallbackCache[nameof(SetMonitorCallback)] = callback;

			SetMonitorCallback(callback==null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback));
		}

		//Input

		public static void SetKeyCallback(IntPtr window,KeyCallback callback)
		{
			CallbackCache[nameof(SetKeyCallback)] = callback;

			SetKeyCallback(window,callback==null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback));
		}

		public static void SetCharCallback(IntPtr window,CharCallback callback)
		{
			CallbackCache[nameof(SetCharCallback)] = callback;

			SetCharCallback(window,callback==null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback));
		}

		public static void SetCharModsCallback(IntPtr window,CharModsCallback callback)
		{
			CallbackCache[nameof(SetCharModsCallback)] = callback;

			SetCharModsCallback(window,callback==null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback));
		}

		public static void SetMouseButtonCallback(IntPtr window,MouseButtonCallback callback)
		{
			CallbackCache[nameof(SetMouseButtonCallback)] = callback;

			SetMouseButtonCallback(window,callback==null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback));
		}

		public static void SetCursorPosCallback(IntPtr window,CursorPosCallback callback)
		{
			CallbackCache[nameof(SetCursorPosCallback)] = callback;

			SetCursorPosCallback(window,callback==null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback));
		}

		public static void SetCursorEnterCallback(IntPtr window,CursorEnterCallback callback)
		{
			CallbackCache[nameof(SetCursorEnterCallback)] = callback;

			SetCursorEnterCallback(window,callback==null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback));
		}

		public static void SetScrollCallback(IntPtr window,ScrollCallback callback)
		{
			CallbackCache[nameof(SetScrollCallback)] = callback;

			SetScrollCallback(window,callback==null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback));
		}

		public static void SetDropCallback(IntPtr window,DropCallback callback)
		{
			CallbackCache[nameof(SetDropCallback)] = callback;

			SetDropCallback(window,callback==null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback));
		}

		public static void SetJoystickCallback(JoystickCallback callback)
		{
			CallbackCache[nameof(SetJoystickCallback)] = callback;

			SetJoystickCallback(callback==null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback));
		}
	}
}