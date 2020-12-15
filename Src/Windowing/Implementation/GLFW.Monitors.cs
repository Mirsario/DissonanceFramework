using System;
using System.Runtime.InteropServices;
using CC = System.Runtime.InteropServices.CallingConvention;

#pragma warning disable IDE0060 //Unused parameter.

namespace Dissonance.Framework.Windowing
{
	partial class GLFW
	{
		//Get

		[DllImport(Library, EntryPoint = "glfwGetPrimaryMonitor", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern IntPtr GetPrimaryMonitor();

		[DllImport(Library, EntryPoint = "glfwGetMonitors", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern IntPtr GetMonitors(out int count);

		[DllImport(Library, EntryPoint = "glfwGetMonitorName", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern IntPtr GetMonitorName(IntPtr monitor);

		[DllImport(Library, EntryPoint = "glfwGetMonitorPos", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern void GetMonitorPos(IntPtr monitor, out int xPos, out int yPos);

		[DllImport(Library, EntryPoint = "glfwGetMonitorPhysicalSize", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern void GetMonitorPhysicalSize(IntPtr monitor, out int widthMM, out int heightMM);

		[DllImport(Library, EntryPoint = "glfwGetVideoModes", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern IntPtr GetVideoModes(IntPtr monitor, out int count);

		[DllImport(Library, EntryPoint = "glfwGetGammaRamp", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern IntPtr GetGammaRamp(IntPtr monitor);

		public static VideoMode GetVideoMode(IntPtr monitor) => Marshal.PtrToStructure<VideoMode>(GetVideoModeInternal(monitor));

		[DllImport(Library, EntryPoint = "glfwGetVideoMode", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		private static extern IntPtr GetVideoModeInternal(IntPtr monitor);

		//Set

		[DllImport(Library, EntryPoint = "glfwSetGamma", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern void SetGamma(IntPtr monitor, float gamma);

		[DllImport(Library, EntryPoint = "glfwSetGammaRamp", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern void SetGammaRamp(IntPtr monitor, ref GammaRamp ramp);

		//Callbacks

		[DllImport(Library, EntryPoint = "glfwSetMonitorCallback", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern void SetMonitorCallback(IntPtr callback);
	}
}
