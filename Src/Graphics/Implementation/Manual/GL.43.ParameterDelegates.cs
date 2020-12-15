using System;
using System.Runtime.InteropServices;

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void DebugCallback(uint source, uint type, uint id, uint severity, int length, [In][MarshalAs(UnmanagedType.LPStr)] string message, IntPtr userParameter);
	}
}
