using System;
using System.Runtime.InteropServices;
using CC = System.Runtime.InteropServices.CallingConvention;
using UFP = System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute;

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[UFP(CC.Cdecl)]
		private unsafe delegate void UniformMatrix2x3fvDelegate(int location,int count,byte transpose,ref float value);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void UniformMatrix3x2fvDelegate(int location,int count,byte transpose,ref float value);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void UniformMatrix2x4fvDelegate(int location,int count,byte transpose,ref float value);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void UniformMatrix4x2fvDelegate(int location,int count,byte transpose,ref float value);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void UniformMatrix3x4fvDelegate(int location,int count,byte transpose,ref float value);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void UniformMatrix4x3fvDelegate(int location,int count,byte transpose,ref float value);
	}
}
