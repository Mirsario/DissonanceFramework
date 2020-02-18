using System;
using System.Runtime.InteropServices;
using Dissonance.Framework.Windowing.Input;
using CC = System.Runtime.InteropServices.CallingConvention;

#pragma warning disable IDE0060 //Unused parameter.

namespace Dissonance.Framework.Windowing
{
	partial class GLFW
	{
		//Get

		[DllImport(Library,EntryPoint = "glfwGetInputMode",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern int GetInputMode(IntPtr window,InputMode mode);

		[DllImport(Library,EntryPoint = "glfwGetKey",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern int GetKey(IntPtr window,Keys key);

		[DllImport(Library,EntryPoint = "glfwGetKeyName",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern IntPtr GetKeyName(Keys key,int scancode);

		[DllImport(Library,EntryPoint = "glfwGetCursorPos",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void GetCursorPos(IntPtr window,out double xPos,out double yPos);

		[DllImport(Library,EntryPoint = "glfwGetMouseButton",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern int GetMouseButton(IntPtr window,MouseButton button);

		[DllImport(Library,EntryPoint = "glfwGetJoystickAxes",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern IntPtr GetJoystickAxes(int joy,out int count);

		[DllImport(Library,EntryPoint = "glfwGetJoystickButtons",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern IntPtr GetJoystickButtons(int joy,out int count);

		[DllImport(Library,EntryPoint = "glfwGetJoystickName",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern IntPtr GetJoystickName(int joy);

		//Set

		[DllImport(Library,EntryPoint = "glfwSetInputMode",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void SetInputMode(IntPtr window,InputMode mode,int value);

		[DllImport(Library,EntryPoint = "glfwSetCursorPos",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void SetCursorPos(IntPtr window,double xPos,double yPos);

		[DllImport(Library,EntryPoint = "glfwJoystickPresent",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern int JoystickPresent(int joy);

		//Callbacks

		[DllImport(Library,EntryPoint = "glfwSetKeyCallback",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void SetKeyCallback(IntPtr window,IntPtr callback);

		[DllImport(Library,EntryPoint = "glfwSetCharCallback",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void SetCharCallback(IntPtr window,IntPtr callback);

		[DllImport(Library,EntryPoint = "glfwSetCharModsCallback",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void SetCharModsCallback(IntPtr window,IntPtr callback);

		[DllImport(Library,EntryPoint = "glfwSetMouseButtonCallback",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void SetMouseButtonCallback(IntPtr window,IntPtr callback);

		[DllImport(Library,EntryPoint = "glfwSetCursorPosCallback",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void SetCursorPosCallback(IntPtr window,IntPtr callback);

		[DllImport(Library,EntryPoint = "glfwSetCursorEnterCallback",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void SetCursorEnterCallback(IntPtr window,IntPtr callback);

		[DllImport(Library,EntryPoint = "glfwSetScrollCallback",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void SetScrollCallback(IntPtr window,IntPtr callback);

		[DllImport(Library,EntryPoint = "glfwSetDropCallback",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void SetDropCallback(IntPtr window,IntPtr callback);

		[DllImport(Library,EntryPoint = "glfwSetJoystickCallback",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void SetJoystickCallback(IntPtr callback);
	}
}
