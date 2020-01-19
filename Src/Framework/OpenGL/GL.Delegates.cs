using System;
using System.Runtime.InteropServices;
using UFP = System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute;
using CC = System.Runtime.InteropServices.CallingConvention;

#pragma warning disable IDE0060 //Unused parameter.

namespace Dissonance.Framework.OpenGL
{
	public static partial class GL
	{
		#region OpenGL 4.3

		[UFP(CC.Cdecl)]
		public delegate void DebugCallback(uint source,uint type,uint id,uint severity,int length,[In] [MarshalAs(UnmanagedType.LPStr)] string message,IntPtr userParameter);

		#endregion
	}
}