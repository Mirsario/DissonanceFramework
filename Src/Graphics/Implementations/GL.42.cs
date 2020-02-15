using System;

#pragma warning disable IDE0060 //Unused parameter.

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[MethodImport("glDrawArraysInstancedBaseInstance","4.2")]
		public static void DrawArraysInstancedBaseInstance(uint mode,int first,int count,int instanceCount,uint baseinstance)
			=> throw new NotImplementedException();

		[MethodImport("glDrawElementsInstancedBaseInstance","4.2")]
		public static void DrawElementsInstancedBaseInstance(uint mode,int count,uint type,IntPtr indices,int instanceCount,uint baseinstance)
			=> throw new NotImplementedException();

		[MethodImport("glDrawElementsInstancedBaseVertexBaseInstance","4.2")]
		public static void DrawElementsInstancedBaseVertexBaseInstance(uint mode,int count,uint type,IntPtr indices,int instanceCount,int basevertex,uint baseinstance)
			=> throw new NotImplementedException();

		[MethodImport("glGetInternalformativ","4.2")]
		public static void GetInternalformat(uint target,uint internalFormat,uint pName,int bufSize,ref int parameters)
			=> throw new NotImplementedException();

		[MethodImport("glGetActiveAtomicCounterBufferiv","4.2")]
		public static void GetActiveAtomicCounterBuffer(uint program,uint bufferIndex,uint pName,ref int parameters)
			=> throw new NotImplementedException();

		[MethodImport("glBindImageTexture","4.2")]
		public static void BindImageTexture(uint unit,uint texture,int level,byte layered,int layer,uint access,uint format)
			=> throw new NotImplementedException();

		[MethodImport("glMemoryBarrier","4.2")]
		public static void MemoryBarrier(uint barriers)
			=> throw new NotImplementedException();

		[MethodImport("glTexStorage1D","4.2")]
		public static void TexStorage1D(TextureTarget1D target,int levels,uint internalFormat,int width)
			=> throw new NotImplementedException();

		[MethodImport("glTexStorage2D","4.2")]
		public static void TexStorage2D(TextureTarget2D target,int levels,uint internalFormat,int width,int height)
			=> throw new NotImplementedException();

		[MethodImport("glTexStorage3D","4.2")]
		public static void TexStorage3D(TextureTarget3D target,int levels,uint internalFormat,int width,int height,int depth)
			=> throw new NotImplementedException();

		[MethodImport("glDrawTransformFeedbackInstanced","4.2")]
		public static void DrawTransformFeedbackInstanced(uint mode,uint id,int instanceCount)
			=> throw new NotImplementedException();

		[MethodImport("glDrawTransformFeedbackStreamInstanced","4.2")]
		public static void DrawTransformFeedbackStreamInstanced(uint mode,uint id,uint stream,int instanceCount)
			=> throw new NotImplementedException();
	}
}