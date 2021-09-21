using System;

namespace Dissonance.Framework.Graphics.OpenGL
{
	unsafe partial class GL
	{
		[MethodImport("glBufferStorage", "4.4")]
		private static delegate*<BufferStorageTarget, IntPtr, void*, BufferStorageMask, void> glBufferStorage;
		
		public static void BufferStorage(BufferStorageTarget target, IntPtr size, void* data, BufferStorageMask flags)
		{
			glBufferStorage(target, size, data, flags);
		}
		
		[MethodImport("glClearTexImage", "4.4")]
		private static delegate*<uint, int, PixelFormat, PixelType, void*, void> glClearTexImage;
		
		public static void ClearTexImage(uint texture, int level, PixelFormat format, PixelType type, void* data)
		{
			glClearTexImage(texture, level, format, type, data);
		}
		
		[MethodImport("glClearTexSubImage", "4.4")]
		private static delegate*<uint, int, int, int, int, int, int, int, PixelFormat, PixelType, void*, void> glClearTexSubImage;
		
		public static void ClearTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, void* data)
		{
			glClearTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, data);
		}
		
		[MethodImport("glBindBuffersBase", "4.4")]
		private static delegate*<BufferTargetARB, uint, int, uint*, void> glBindBuffersBase;
		
		public static void BindBuffersBase(BufferTargetARB target, uint first, int count, uint* buffers)
		{
			glBindBuffersBase(target, first, count, buffers);
		}
		
		[MethodImport("glBindBuffersRange", "4.4")]
		private static delegate*<BufferTargetARB, uint, int, uint*, IntPtr*, IntPtr*, void> glBindBuffersRange;
		
		public static void BindBuffersRange(BufferTargetARB target, uint first, int count, uint* buffers, IntPtr* offsets, IntPtr* sizes)
		{
			glBindBuffersRange(target, first, count, buffers, offsets, sizes);
		}
		
		[MethodImport("glBindTextures", "4.4")]
		private static delegate*<uint, int, uint*, void> glBindTextures;
		
		public static void BindTextures(uint first, int count, uint* textures)
		{
			glBindTextures(first, count, textures);
		}
		
		[MethodImport("glBindSamplers", "4.4")]
		private static delegate*<uint, int, uint*, void> glBindSamplers;
		
		public static void BindSamplers(uint first, int count, uint* samplers)
		{
			glBindSamplers(first, count, samplers);
		}
		
		[MethodImport("glBindImageTextures", "4.4")]
		private static delegate*<uint, int, uint*, void> glBindImageTextures;
		
		public static void BindImageTextures(uint first, int count, uint* textures)
		{
			glBindImageTextures(first, count, textures);
		}
		
		[MethodImport("glBindVertexBuffers", "4.4")]
		private static delegate*<uint, int, uint*, IntPtr*, int*, void> glBindVertexBuffers;
		
		public static void BindVertexBuffers(uint first, int count, uint* buffers, IntPtr* offsets, int* strides)
		{
			glBindVertexBuffers(first, count, buffers, offsets, strides);
		}
	}
}

