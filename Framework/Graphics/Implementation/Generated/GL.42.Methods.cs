using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[MethodImpl(ImplOptions)]
		public unsafe static void DrawArraysInstancedBaseInstance(uint mode,int first,int count,int instanceCount,uint baseinstance)
			=> glDrawArraysInstancedBaseInstance(mode,first,count,instanceCount,baseinstance);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void DrawElementsInstancedBaseInstance(uint mode,int count,uint type,IntPtr indices,int instanceCount,uint baseinstance)
			=> glDrawElementsInstancedBaseInstance(mode,count,type,indices,instanceCount,baseinstance);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void DrawElementsInstancedBaseVertexBaseInstance(uint mode,int count,uint type,IntPtr indices,int instanceCount,int basevertex,uint baseinstance)
			=> glDrawElementsInstancedBaseVertexBaseInstance(mode,count,type,indices,instanceCount,basevertex,baseinstance);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetInternalformat(uint target,uint internalFormat,uint pName,int bufSize,ref int parameters)
			=> glGetInternalformativ(target,internalFormat,pName,bufSize,ref parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetActiveAtomicCounterBuffer(uint program,uint bufferIndex,uint pName,ref int parameters)
			=> glGetActiveAtomicCounterBufferiv(program,bufferIndex,pName,ref parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void BindImageTexture(uint unit,uint texture,int level,byte layered,int layer,uint access,uint format)
			=> glBindImageTexture(unit,texture,level,layered,layer,access,format);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void MemoryBarrier(uint barriers)
			=> glMemoryBarrier(barriers);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexStorage1D(TextureTarget1D target,int levels,uint internalFormat,int width)
			=> glTexStorage1D(target,levels,internalFormat,width);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexStorage2D(TextureTarget2D target,int levels,uint internalFormat,int width,int height)
			=> glTexStorage2D(target,levels,internalFormat,width,height);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexStorage3D(TextureTarget3D target,int levels,uint internalFormat,int width,int height,int depth)
			=> glTexStorage3D(target,levels,internalFormat,width,height,depth);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void DrawTransformFeedbackInstanced(uint mode,uint id,int instanceCount)
			=> glDrawTransformFeedbackInstanced(mode,id,instanceCount);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void DrawTransformFeedbackStreamInstanced(uint mode,uint id,uint stream,int instanceCount)
			=> glDrawTransformFeedbackStreamInstanced(mode,id,stream,instanceCount);
	}
}
