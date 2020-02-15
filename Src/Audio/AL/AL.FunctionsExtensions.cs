using System;
using System.Runtime.InteropServices;
using CC = System.Runtime.InteropServices.CallingConvention;

namespace Dissonance.Framework.Audio
{
	partial class AL
	{
		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alIsExtensionPresent")]
		public static extern bool IsExtensionPresent([In()] [MarshalAs(UnmanagedType.LPStr)] string extName);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alGetProcAddress")]
		public static extern IntPtr GetProcAddress([In()] [MarshalAs(UnmanagedType.LPStr)] string fname);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alGetEnumValue")]
		public static extern int GetEnumValue([In()] [MarshalAs(UnmanagedType.LPStr)] string ename);
	}
}
