using System;
using System.Runtime.CompilerServices;

#pragma warning disable IDE0060 //Unused parameter.

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[MethodImpl(ImplOptions)]
		[MethodImport("glBlendFuncSeparate","1.4")]
		public static void BlendFuncSeparate(uint sfactorRGB,uint dfactorRGB,uint sfactorAlpha,uint dfactorAlpha)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glMultiDrawArrays","1.4")]
		public static void MultiDrawArrays(uint mode,ref int first,ref int count,int drawcount)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glMultiDrawElements","1.4")]
		public static void MultiDrawElements(uint mode,ref int count,uint type,IntPtr indices,int drawcount)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glPointParameterf","1.4")]
		public static void PointParameter(uint pName,float param)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glPointParameterfv","1.4")]
		public static void PointParameter(uint pName,ref float parameters)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glPointParameteri","1.4")]
		public static void PointParameter(uint pName,int param)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glPointParameteriv","1.4")]
		public static void PointParameter(uint pName,ref int parameters)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glBlendColor","1.4")]
		public static void BlendColor(float red,float green,float blue,float alpha)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glBlendEquation","1.4")]
		public static void BlendEquation(uint mode)
			=> throw new NotImplementedException();
	}
}