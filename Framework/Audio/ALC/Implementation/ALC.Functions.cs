using System;
using System.Runtime.InteropServices;
using CC = System.Runtime.InteropServices.CallingConvention;

namespace Dissonance.Framework.Audio
{
	public partial class ALC
	{
		//GetX

		[DllImport(Library, CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true, EntryPoint = "alcGetIntegerv")]
		public static extern void Get(IntPtr device, GetContextInt parameter, int size, int[] outputArray);

		[DllImport(Library, CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true, EntryPoint = "alcGetString")]
		public static extern IntPtr Get(IntPtr device, GetContextString parameter);

		[DllImport(Library, CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true, EntryPoint = "alcGetEnumValue")]
		public static extern int GetEnumValue(IntPtr device, [In()][MarshalAs(UnmanagedType.LPStr)] string enumName);

		[DllImport(Library, CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true, EntryPoint = "alcGetError")]
		public static extern int GetError(IntPtr device);

		[DllImport(Library, CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true, EntryPoint = "alcGetProcAddress")]
		public static extern IntPtr GetProcAddress(IntPtr device, [In()][MarshalAs(UnmanagedType.LPStr)] string funcName);

		//Devices

		[DllImport(Library, CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true, EntryPoint = "alcOpenDevice")]
		public static extern IntPtr OpenDevice([In()][MarshalAs(UnmanagedType.LPStr)] string deviceName);

		[DllImport(Library, CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true, EntryPoint = "alcCloseDevice")]
		public static extern bool CloseDevice(IntPtr device);

		//Contexts

		[DllImport(Library, CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true, EntryPoint = "alcGetCurrentContext")]
		public static extern IntPtr GetCurrentContext();

		[DllImport(Library, CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true, EntryPoint = "alcGetContextsDevice")]
		public static extern IntPtr GetContextsDevice(IntPtr context);

		[DllImport(Library, CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true, EntryPoint = "alcCreateContext")]
		public static extern IntPtr CreateContext(IntPtr device, int[] attrList);

		[DllImport(Library, CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true, EntryPoint = "alcMakeContextCurrent")]
		public static extern bool MakeContextCurrent(IntPtr context);

		[DllImport(Library, CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true, EntryPoint = "alcSuspendContext")]
		public static extern void SuspendContext(IntPtr context);

		[DllImport(Library, CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true, EntryPoint = "alcProcessContext")]
		public static extern void ProcessContext(IntPtr context);

		[DllImport(Library, CallingConvention = CC.Cdecl, CharSet = CharSet.Ansi, ExactSpelling = true, EntryPoint = "alcDestroyContext")]
		public static extern void DestroyContext(IntPtr context);
	}
}
