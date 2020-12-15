using System;
using System.Runtime.InteropServices;
using CC = System.Runtime.InteropServices.CallingConvention;
using UFP = System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute;

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[UFP(CC.Cdecl)]
		private unsafe delegate void BlendFuncSeparateDelegate(uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha);

		[UFP(CC.Cdecl)]
		private unsafe delegate void MultiDrawArraysDelegate(uint mode, ref int first, ref int count, int drawcount);

		[UFP(CC.Cdecl)]
		private unsafe delegate void MultiDrawElementsDelegate(uint mode, ref int count, uint type, IntPtr indices, int drawcount);

		[UFP(CC.Cdecl)]
		private unsafe delegate void PointParameterfDelegate(uint pName, float param);

		[UFP(CC.Cdecl)]
		private unsafe delegate void PointParameterfvDelegate(uint pName, ref float parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void PointParameteriDelegate(uint pName, int param);

		[UFP(CC.Cdecl)]
		private unsafe delegate void PointParameterivDelegate(uint pName, ref int parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void BlendColorDelegate(float red, float green, float blue, float alpha);

		[UFP(CC.Cdecl)]
		private unsafe delegate void BlendEquationDelegate(uint mode);
	}
}
