using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[MethodImpl(ImplOptions)]
		public unsafe static void DrawElementsBaseVertex(uint mode,int count,uint type,IntPtr indices,int basevertex)
			=> glDrawElementsBaseVertex(mode,count,type,indices,basevertex);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void DrawRangeElementsBaseVertex(uint mode,uint start,uint end,int count,uint type,IntPtr indices,int basevertex)
			=> glDrawRangeElementsBaseVertex(mode,start,end,count,type,indices,basevertex);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void DrawElementsInstancedBaseVertex(uint mode,int count,uint type,IntPtr indices,int instanceCount,int basevertex)
			=> glDrawElementsInstancedBaseVertex(mode,count,type,indices,instanceCount,basevertex);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void MultiDrawElementsBaseVertex(uint mode,ref int count,uint type,IntPtr indices,int drawcount,ref int basevertex)
			=> glMultiDrawElementsBaseVertex(mode,ref count,type,indices,drawcount,ref basevertex);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ProvokingVertex(uint mode)
			=> glProvokingVertex(mode);
		
		[MethodImpl(ImplOptions)]
		public unsafe static IntPtr FenceSync(uint condition,uint flags)
			=> glFenceSync(condition,flags);
		
		[MethodImpl(ImplOptions)]
		public unsafe static byte IsSync(IntPtr sync)
			=> glIsSync(sync);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void DeleteSync(IntPtr sync)
			=> glDeleteSync(sync);
		
		[MethodImpl(ImplOptions)]
		public unsafe static uint ClientWaitSync(IntPtr sync,uint flags,uint timeout)
			=> glClientWaitSync(sync,flags,timeout);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void WaitSync(IntPtr sync,uint flags,uint timeout)
			=> glWaitSync(sync,flags,timeout);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetInteger(uint pName,ref int data)
			=> glGetInteger64v(pName,ref data);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetSync(IntPtr sync,uint pName,int bufSize,ref int length,ref int values)
			=> glGetSynciv(sync,pName,bufSize,ref length,ref values);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetInteger(uint target,uint index,ref long data)
			=> glGetInteger64i_v(target,index,ref data);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetBufferParameter(BufferTarget target,uint pName,ref long parameters)
			=> glGetBufferParameteri64v(target,pName,ref parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void FramebufferTexture(FramebufferTarget target,FramebufferAttachment attachment,uint texture,int level)
			=> glFramebufferTexture(target,attachment,texture,level);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexImage2DMultisample(TextureTarget target,int samples,PixelInternalFormat internalFormat,int width,int height,byte fixedsamplelocations)
			=> glTexImage2DMultisample(target,samples,internalFormat,width,height,fixedsamplelocations);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexImage3DMultisample(TextureTarget target,int samples,PixelInternalFormat internalFormat,int width,int height,int depth,byte fixedsamplelocations)
			=> glTexImage3DMultisample(target,samples,internalFormat,width,height,depth,fixedsamplelocations);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetMultisample(uint pName,uint index,ref float val)
			=> glGetMultisamplefv(pName,index,ref val);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void SampleMask(uint maskNumber,uint mask)
			=> glSampleMaski(maskNumber,mask);
	}
}
