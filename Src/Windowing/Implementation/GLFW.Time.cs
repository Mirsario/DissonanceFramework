using System.Runtime.InteropServices;
using CC = System.Runtime.InteropServices.CallingConvention;

#pragma warning disable IDE0060 //Unused parameter.

namespace Dissonance.Framework.Windowing
{
	partial class GLFW
	{
		//Get

		[DllImport(Library, EntryPoint = "glfwGetTime", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern double GetTime();

		[DllImport(Library, EntryPoint = "glfwGetTimerValue", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern uint GetTimerValue();

		[DllImport(Library, EntryPoint = "glfwGetTimerFrequency", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern uint GetTimerFrequency();

		//Set

		[DllImport(Library, EntryPoint = "glfwSetTime", CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern void SetTime(double time);
	}
}
