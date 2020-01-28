using System;

#pragma warning disable IDE0060 //Unused parameter.

namespace Dissonance.Framework.OpenGL
{
	partial class GL
	{
		[MethodImport("glBufferStorage","4.4")]
		public static void BufferStorage(BufferTarget target,int size,IntPtr data,uint flags)
			=> throw new NotImplementedException();

		[MethodImport("glClearTexImage","4.4")]
		public static void ClearTexImage(uint texture,int level,PixelFormat format,PixelType type,IntPtr data)
			=> throw new NotImplementedException();

		[MethodImport("glClearTexSubImage","4.4")]
		public static void ClearTexSubImage(uint texture,int level,int xOffset,int yOffset,int zOffset,int width,int height,int depth,PixelFormat format,PixelType type,IntPtr data)
			=> throw new NotImplementedException();

		[MethodImport("glBindBuffersBase","4.4")]
		public static void BindBuffersBase(BufferRangeTarget target,uint first,int count,ref uint buffers)
			=> throw new NotImplementedException();

		[MethodImport("glBindBuffersRange","4.4")]
		public static void BindBuffersRange(BufferRangeTarget target,uint first,int count,ref uint buffers,ref int offsets,ref int sizes)
			=> throw new NotImplementedException();

		[MethodImport("glBindTextures","4.4")]
		public static void BindTextures(uint first,int count,ref uint textures)
			=> throw new NotImplementedException();

		[MethodImport("glBindSamplers","4.4")]
		public static void BindSamplers(uint first,int count,ref uint samplers)
			=> throw new NotImplementedException();

		[MethodImport("glBindImageTextures","4.4")]
		public static void BindImageTextures(uint first,int count,ref uint textures)
			=> throw new NotImplementedException();

		[MethodImport("glBindVertexBuffers","4.4")]
		public static void BindVertexBuffers(uint first,int count,ref uint buffers,ref int offsets,ref int strides)
			=> throw new NotImplementedException();
	}
}