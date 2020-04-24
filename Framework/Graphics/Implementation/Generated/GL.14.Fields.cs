#pragma warning disable CS0649

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[MethodImport("glBlendFuncSeparate")]
		private static BlendFuncSeparateDelegate glBlendFuncSeparate;
		
		[MethodImport("glMultiDrawArrays")]
		private static MultiDrawArraysDelegate glMultiDrawArrays;
		
		[MethodImport("glMultiDrawElements")]
		private static MultiDrawElementsDelegate glMultiDrawElements;
		
		[MethodImport("glPointParameterf")]
		private static PointParameterfDelegate glPointParameterf;
		
		[MethodImport("glPointParameterfv")]
		private static PointParameterfvDelegate glPointParameterfv;
		
		[MethodImport("glPointParameteri")]
		private static PointParameteriDelegate glPointParameteri;
		
		[MethodImport("glPointParameteriv")]
		private static PointParameterivDelegate glPointParameteriv;
		
		[MethodImport("glBlendColor")]
		private static BlendColorDelegate glBlendColor;
		
		[MethodImport("glBlendEquation")]
		private static BlendEquationDelegate glBlendEquation;
	}
}
