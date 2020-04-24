using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[MethodImpl(ImplOptions)]
		public unsafe static void BufferStorage(BufferTarget target,int size,IntPtr data,uint flags)
			=> glBufferStorage(target,size,data,flags);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ClearTexImage(uint texture,int level,PixelFormat format,PixelType type,IntPtr data)
			=> glClearTexImage(texture,level,format,type,data);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ClearTexSubImage(uint texture,int level,int xOffset,int yOffset,int zOffset,int width,int height,int depth,PixelFormat format,PixelType type,IntPtr data)
			=> glClearTexSubImage(texture,level,xOffset,yOffset,zOffset,width,height,depth,format,type,data);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void BindBuffersBase(BufferRangeTarget target,uint first,int count,ref uint buffers)
			=> glBindBuffersBase(target,first,count,ref buffers);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void BindBuffersRange(BufferRangeTarget target,uint first,int count,ref uint buffers,ref int offsets,ref int sizes)
			=> glBindBuffersRange(target,first,count,ref buffers,ref offsets,ref sizes);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void BindTextures(uint first,int count,ref uint textures)
			=> glBindTextures(first,count,ref textures);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void BindSamplers(uint first,int count,ref uint samplers)
			=> glBindSamplers(first,count,ref samplers);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void BindImageTextures(uint first,int count,ref uint textures)
			=> glBindImageTextures(first,count,ref textures);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void BindVertexBuffers(uint first,int count,ref uint buffers,ref int offsets,ref int strides)
			=> glBindVertexBuffers(first,count,ref buffers,ref offsets,ref strides);
	}
}
