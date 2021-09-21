using System;

namespace Dissonance.Framework.Graphics.OpenGL
{
	unsafe partial class GL
	{
		[MethodImport("glSpecializeShader", "4.6")]
		private static delegate*<uint, byte*, uint, uint*, uint*, void> glSpecializeShader;
		
		public static void SpecializeShader(uint shader, byte* pEntryPoint, uint numSpecializationConstants, uint* pConstantIndex, uint* pConstantValue)
		{
			glSpecializeShader(shader, pEntryPoint, numSpecializationConstants, pConstantIndex, pConstantValue);
		}
		
		[MethodImport("glMultiDrawArraysIndirectCount", "4.6")]
		private static delegate*<PrimitiveType, void*, IntPtr, int, int, void> glMultiDrawArraysIndirectCount;
		
		public static void MultiDrawArraysIndirectCount(PrimitiveType mode, void* indirect, IntPtr drawcount, int maxdrawcount, int stride)
		{
			glMultiDrawArraysIndirectCount(mode, indirect, drawcount, maxdrawcount, stride);
		}
		
		[MethodImport("glMultiDrawElementsIndirectCount", "4.6")]
		private static delegate*<PrimitiveType, DrawElementsType, void*, IntPtr, int, int, void> glMultiDrawElementsIndirectCount;
		
		public static void MultiDrawElementsIndirectCount(PrimitiveType mode, DrawElementsType type, void* indirect, IntPtr drawcount, int maxdrawcount, int stride)
		{
			glMultiDrawElementsIndirectCount(mode, type, indirect, drawcount, maxdrawcount, stride);
		}
		
		[MethodImport("glPolygonOffsetClamp", "4.6")]
		private static delegate*<float, float, float, void> glPolygonOffsetClamp;
		
		public static void PolygonOffsetClamp(float factor, float units, float clamp)
		{
			glPolygonOffsetClamp(factor, units, clamp);
		}
	}
}

