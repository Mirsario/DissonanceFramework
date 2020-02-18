using System;
using System.Runtime.InteropServices;
using CC = System.Runtime.InteropServices.CallingConvention;

#pragma warning disable IDE0060 //Unused parameter.

namespace Dissonance.Framework.Windowing
{
	partial class GLFW
	{
		[DllImport(Library,EntryPoint = "glfwCreateCursor",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern IntPtr CreateCursor(ref Image image,int xhot,int yhot);

		[DllImport(Library,EntryPoint = "glfwCreateStandardCursor",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern IntPtr CreateStandardCursor(int shape);

		[DllImport(Library,EntryPoint = "glfwSetCursor",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void SetCursor(IntPtr window,IntPtr cursor);

		[DllImport(Library,EntryPoint = "glfwDestroyCursor",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void DestroyCursor(IntPtr cursor);
	}
}
