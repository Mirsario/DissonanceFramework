using System;
using System.Runtime.InteropServices;

namespace Dissonance.Framework.GLFW3
{
	partial class GLFW
	{
		[StructLayout(LayoutKind.Sequential)]
		public struct VideoMode
		{
			public int width;
			public int height;
			public int redBits;
			public int greenBits;
			public int blueBits;
			public int refreshRate;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GammaRamp
		{
			public IntPtr red;
			public IntPtr green;
			public IntPtr blue;
			public uint size;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct Image
		{
			public int width;
			public int height;
			[MarshalAs(UnmanagedType.LPStr)]
			public string pixels;
		}
	}
}
