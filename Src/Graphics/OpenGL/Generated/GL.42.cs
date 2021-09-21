using System;

namespace Dissonance.Framework.Graphics.OpenGL
{
	unsafe partial class GL
	{
		[MethodImport("glDrawArraysInstancedBaseInstance", "4.2")]
		private static delegate*<PrimitiveType, int, int, int, uint, void> glDrawArraysInstancedBaseInstance;
		
		public static void DrawArraysInstancedBaseInstance(PrimitiveType mode, int first, int count, int instancecount, uint baseinstance)
		{
			glDrawArraysInstancedBaseInstance(mode, first, count, instancecount, baseinstance);
		}
		
		[MethodImport("glDrawElementsInstancedBaseInstance", "4.2")]
		private static delegate*<PrimitiveType, int, PrimitiveType, void*, int, uint, void> glDrawElementsInstancedBaseInstance;
		
		public static void DrawElementsInstancedBaseInstance(PrimitiveType mode, int count, PrimitiveType type, void* indices, int instancecount, uint baseinstance)
		{
			glDrawElementsInstancedBaseInstance(mode, count, type, indices, instancecount, baseinstance);
		}
		
		[MethodImport("glDrawElementsInstancedBaseVertexBaseInstance", "4.2")]
		private static delegate*<PrimitiveType, int, DrawElementsType, void*, int, int, uint, void> glDrawElementsInstancedBaseVertexBaseInstance;
		
		public static void DrawElementsInstancedBaseVertexBaseInstance(PrimitiveType mode, int count, DrawElementsType type, void* indices, int instancecount, int basevertex, uint baseinstance)
		{
			glDrawElementsInstancedBaseVertexBaseInstance(mode, count, type, indices, instancecount, basevertex, baseinstance);
		}
		
		[MethodImport("glGetInternalformativ", "4.2")]
		private static delegate*<TextureTarget, InternalFormat, InternalFormatPName, int, int*, void> glGetInternalformativ;
		
		public static void GetInternalformativ(TextureTarget target, InternalFormat internalformat, InternalFormatPName pname, int count, int* @params)
		{
			glGetInternalformativ(target, internalformat, pname, count, @params);
		}
		
		[MethodImport("glGetActiveAtomicCounterBufferiv", "4.2")]
		private static delegate*<uint, uint, AtomicCounterBufferPName, int*, void> glGetActiveAtomicCounterBufferiv;
		
		public static void GetActiveAtomicCounterBufferiv(uint program, uint bufferIndex, AtomicCounterBufferPName pname, int* @params)
		{
			glGetActiveAtomicCounterBufferiv(program, bufferIndex, pname, @params);
		}
		
		[MethodImport("glBindImageTexture", "4.2")]
		private static delegate*<uint, uint, int, bool, int, BufferAccessARB, InternalFormat, void> glBindImageTexture;
		
		public static void BindImageTexture(uint unit, uint texture, int level, bool layered, int layer, BufferAccessARB access, InternalFormat format)
		{
			glBindImageTexture(unit, texture, level, layered, layer, access, format);
		}
		
		[MethodImport("glMemoryBarrier", "4.2")]
		private static delegate*<MemoryBarrierMask, void> glMemoryBarrier;
		
		public static void MemoryBarrier(MemoryBarrierMask barriers)
		{
			glMemoryBarrier(barriers);
		}
		
		[MethodImport("glTexStorage1D", "4.2")]
		private static delegate*<TextureTarget, int, SizedInternalFormat, int, void> glTexStorage1D;
		
		public static void TexStorage1D(TextureTarget target, int levels, SizedInternalFormat internalformat, int width)
		{
			glTexStorage1D(target, levels, internalformat, width);
		}
		
		[MethodImport("glTexStorage2D", "4.2")]
		private static delegate*<TextureTarget, int, SizedInternalFormat, int, int, void> glTexStorage2D;
		
		public static void TexStorage2D(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height)
		{
			glTexStorage2D(target, levels, internalformat, width, height);
		}
		
		[MethodImport("glTexStorage3D", "4.2")]
		private static delegate*<TextureTarget, int, SizedInternalFormat, int, int, int, void> glTexStorage3D;
		
		public static void TexStorage3D(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height, int depth)
		{
			glTexStorage3D(target, levels, internalformat, width, height, depth);
		}
		
		[MethodImport("glDrawTransformFeedbackInstanced", "4.2")]
		private static delegate*<PrimitiveType, uint, int, void> glDrawTransformFeedbackInstanced;
		
		public static void DrawTransformFeedbackInstanced(PrimitiveType mode, uint id, int instancecount)
		{
			glDrawTransformFeedbackInstanced(mode, id, instancecount);
		}
		
		[MethodImport("glDrawTransformFeedbackStreamInstanced", "4.2")]
		private static delegate*<PrimitiveType, uint, uint, int, void> glDrawTransformFeedbackStreamInstanced;
		
		public static void DrawTransformFeedbackStreamInstanced(PrimitiveType mode, uint id, uint stream, int instancecount)
		{
			glDrawTransformFeedbackStreamInstanced(mode, id, stream, instancecount);
		}
	}
}

