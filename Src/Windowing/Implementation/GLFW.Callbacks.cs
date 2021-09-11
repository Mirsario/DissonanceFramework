using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

#pragma warning disable IDE0060 //Unused parameter.

namespace Dissonance.Framework.Windowing
{
	partial class GLFW
	{
		private static readonly Dictionary<string, Delegate> CallbackCache = new Dictionary<string, Delegate>(); //Prevents delegates from getting GC'd.
		private static readonly object Lock = new object();

		//General

		public static void SetErrorCallback(ErrorCallback callback)
		{
			lock (Lock) {
				CallbackCache[nameof(SetErrorCallback)] = callback;
			}

			SetErrorCallback(callback == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback));
		}

		public static void SetFramebufferSizeCallback(IntPtr window, FramebufferSizeCallback callback)
		{
			lock (Lock) {
				CallbackCache[nameof(SetFramebufferSizeCallback)] = callback;
			}

			SetFramebufferSizeCallback(window, callback == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback));
		}

		//Window

		public static void SetWindowPosCallback(IntPtr window, WindowPosCallback callback)
		{
			lock (Lock) {
				CallbackCache[nameof(SetWindowPosCallback)] = callback;
			}

			SetWindowPosCallback(window, callback == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback));
		}

		public static void SetWindowSizeCallback(IntPtr window, WindowSizeCallback callback)
		{
			lock (Lock) {
				CallbackCache[nameof(SetWindowSizeCallback)] = callback;
			}

			SetWindowSizeCallback(window, callback == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback));
		}

		public static void SetWindowCloseCallback(IntPtr window, WindowCloseCallback callback)
		{
			lock (Lock) {
				CallbackCache[nameof(SetWindowCloseCallback)] = callback;
			}

			SetWindowCloseCallback(window, callback == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback));
		}

		public static void SetWindowRefreshCallback(IntPtr window, WindowRefreshCallback callback)
		{
			lock (Lock) {
				CallbackCache[nameof(SetWindowRefreshCallback)] = callback;
			}

			SetWindowRefreshCallback(window, callback == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback));
		}

		public static void SetWindowFocusCallback(IntPtr window, WindowFocusCallback callback)
		{
			lock (Lock) {
				CallbackCache[nameof(SetWindowFocusCallback)] = callback;
			}

			SetWindowFocusCallback(window, callback == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback));
		}

		public static void SetWindowIconifyCallback(IntPtr window, WindowIconifyCallback callback)
		{
			lock (Lock) {
				CallbackCache[nameof(SetWindowIconifyCallback)] = callback;
			}

			SetWindowIconifyCallback(window, callback == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback));
		}

		//Monitors

		public static void SetMonitorCallback(MonitorCallback callback)
		{
			lock (Lock) {
				CallbackCache[nameof(SetMonitorCallback)] = callback;
			}

			SetMonitorCallback(callback == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback));
		}

		//Input

		public static void SetKeyCallback(IntPtr window, KeyCallback callback)
		{
			lock (Lock) {
				CallbackCache[nameof(SetKeyCallback)] = callback;
			}

			SetKeyCallback(window, callback == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback));
		}

		public static void SetCharCallback(IntPtr window, CharCallback callback)
		{
			lock (Lock) {
				CallbackCache[nameof(SetCharCallback)] = callback;
			}

			SetCharCallback(window, callback == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback));
		}

		public static void SetCharModsCallback(IntPtr window, CharModsCallback callback)
		{
			lock (Lock) {
				CallbackCache[nameof(SetCharModsCallback)] = callback;
			}

			SetCharModsCallback(window, callback == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback));
		}

		public static void SetMouseButtonCallback(IntPtr window, MouseButtonCallback callback)
		{
			lock (Lock) {
				CallbackCache[nameof(SetMouseButtonCallback)] = callback;
			}

			SetMouseButtonCallback(window, callback == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback));
		}

		public static void SetCursorPosCallback(IntPtr window, CursorPosCallback callback)
		{
			lock (Lock) {
				CallbackCache[nameof(SetCursorPosCallback)] = callback;
			}

			SetCursorPosCallback(window, callback == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback));
		}

		public static void SetCursorEnterCallback(IntPtr window, CursorEnterCallback callback)
		{
			lock (Lock) {
				CallbackCache[nameof(SetCursorEnterCallback)] = callback;
			}

			SetCursorEnterCallback(window, callback == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback));
		}

		public static void SetScrollCallback(IntPtr window, ScrollCallback callback)
		{
			lock (Lock) {
				CallbackCache[nameof(SetScrollCallback)] = callback;
			}

			SetScrollCallback(window, callback == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback));
		}

		public static void SetDropCallback(IntPtr window, DropCallback callback)
		{
			lock (Lock) {
				CallbackCache[nameof(SetDropCallback)] = callback;
			}

			SetDropCallback(window, callback == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback));
		}

		public static void SetJoystickCallback(JoystickCallback callback)
		{
			lock (Lock) {
				CallbackCache[nameof(SetJoystickCallback)] = callback;
			}

			SetJoystickCallback(callback == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback));
		}
	}
}
