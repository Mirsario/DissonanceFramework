using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[MethodImpl(ImplOptions)]
		public unsafe static void BlendFuncSeparate(uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha)
			=> glBlendFuncSeparate(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);

		[MethodImpl(ImplOptions)]
		public unsafe static void MultiDrawArrays(uint mode, ref int first, ref int count, int drawcount)
			=> glMultiDrawArrays(mode, ref first, ref count, drawcount);

		[MethodImpl(ImplOptions)]
		public unsafe static void MultiDrawElements(uint mode, ref int count, uint type, IntPtr indices, int drawcount)
			=> glMultiDrawElements(mode, ref count, type, indices, drawcount);

		[MethodImpl(ImplOptions)]
		public unsafe static void PointParameter(uint pName, float param)
			=> glPointParameterf(pName, param);

		[MethodImpl(ImplOptions)]
		public unsafe static void PointParameter(uint pName, ref float parameters)
			=> glPointParameterfv(pName, ref parameters);

		[MethodImpl(ImplOptions)]
		public unsafe static void PointParameter(uint pName, int param)
			=> glPointParameteri(pName, param);

		[MethodImpl(ImplOptions)]
		public unsafe static void PointParameter(uint pName, ref int parameters)
			=> glPointParameteriv(pName, ref parameters);

		[MethodImpl(ImplOptions)]
		public unsafe static void BlendColor(float red, float green, float blue, float alpha)
			=> glBlendColor(red, green, blue, alpha);

		[MethodImpl(ImplOptions)]
		public unsafe static void BlendEquation(uint mode)
			=> glBlendEquation(mode);
	}
}
