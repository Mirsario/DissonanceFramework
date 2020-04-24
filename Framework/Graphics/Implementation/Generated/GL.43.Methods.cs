using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[MethodImpl(ImplOptions)]
		public unsafe static void ClearBufferData(BufferTarget target,PixelInternalFormat internalFormat,PixelFormat format,PixelType type,IntPtr data)
			=> glClearBufferData(target,internalFormat,format,type,data);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ClearBufferSubData(BufferTarget target,PixelInternalFormat internalFormat,int offset,int size,PixelFormat format,PixelType type,IntPtr data)
			=> glClearBufferSubData(target,internalFormat,offset,size,format,type,data);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void DispatchCompute(uint num_groups_x,uint num_groups_y,uint num_groups_z)
			=> glDispatchCompute(num_groups_x,num_groups_y,num_groups_z);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void DispatchComputeIndirect(int indirect)
			=> glDispatchComputeIndirect(indirect);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void CopyImageSubData(uint srcName,uint srcTarget,int srcLevel,int srcX,int srcY,int srcZ,uint dstName,uint dstTarget,int dstLevel,int dstX,int dstY,int dstZ,int srcWidth,int srcHeight,int srcDepth)
			=> glCopyImageSubData(srcName,srcTarget,srcLevel,srcX,srcY,srcZ,dstName,dstTarget,dstLevel,dstX,dstY,dstZ,srcWidth,srcHeight,srcDepth);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void FramebufferParameter(FramebufferTarget target,uint pName,int param)
			=> glFramebufferParameteri(target,pName,param);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetFramebufferParameter(FramebufferTarget target,uint pName,ref int parameters)
			=> glGetFramebufferParameteriv(target,pName,ref parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetInternalformat(uint target,uint internalFormat,uint pName,int bufSize,ref long parameters)
			=> glGetInternalformati64v(target,internalFormat,pName,bufSize,ref parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void InvalidateTexSubImage(uint texture,int level,int xOffset,int yOffset,int zOffset,int width,int height,int depth)
			=> glInvalidateTexSubImage(texture,level,xOffset,yOffset,zOffset,width,height,depth);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void InvalidateTexImage(uint texture,int level)
			=> glInvalidateTexImage(texture,level);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void InvalidateBufferSubData(uint buffer,int offset,int length)
			=> glInvalidateBufferSubData(buffer,offset,length);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void InvalidateBufferData(uint buffer)
			=> glInvalidateBufferData(buffer);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void InvalidateFramebuffer(FramebufferTarget target,int numAttachments,FramebufferAttachment* attachments)
			=> glInvalidateFramebuffer(target,numAttachments,attachments);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void InvalidateSubFramebuffer(FramebufferTarget target,int numAttachments,FramebufferAttachment* attachments,int x,int y,int width,int height)
			=> glInvalidateSubFramebuffer(target,numAttachments,attachments,x,y,width,height);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void MultiDrawArraysIndirect(uint mode,IntPtr indirect,int drawcount,int stride)
			=> glMultiDrawArraysIndirect(mode,indirect,drawcount,stride);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void MultiDrawElementsIndirect(uint mode,uint type,IntPtr indirect,int drawcount,int stride)
			=> glMultiDrawElementsIndirect(mode,type,indirect,drawcount,stride);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetProgramInterface(uint program,uint programInterface,uint pName,ref int parameters)
			=> glGetProgramInterfaceiv(program,programInterface,pName,ref parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static uint GetProgramResourceIndex(uint program,uint programInterface,IntPtr name)
			=> glGetProgramResourceIndex(program,programInterface,name);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetProgramResourceName(uint program,uint programInterface,uint index,int bufSize,ref int length,IntPtr name)
			=> glGetProgramResourceName(program,programInterface,index,bufSize,ref length,name);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetProgramResource(uint program,uint programInterface,uint index,int propCount,ref uint props,int bufSize,ref int length,ref int parameters)
			=> glGetProgramResourceiv(program,programInterface,index,propCount,ref props,bufSize,ref length,ref parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static int GetProgramResourceLocation(uint program,uint programInterface,IntPtr name)
			=> glGetProgramResourceLocation(program,programInterface,name);
		
		[MethodImpl(ImplOptions)]
		public unsafe static int GetProgramResourceLocationIndex(uint program,uint programInterface,IntPtr name)
			=> glGetProgramResourceLocationIndex(program,programInterface,name);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ShaderStorageBlockBinding(uint program,uint storageBlockIndex,uint storageBlockBinding)
			=> glShaderStorageBlockBinding(program,storageBlockIndex,storageBlockBinding);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexBufferRange(TextureBufferTarget target,uint internalFormat,uint buffer,int offset,int size)
			=> glTexBufferRange(target,internalFormat,buffer,offset,size);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexStorage2DMultisample(TextureTargetMultisample2D target,int samples,uint internalFormat,int width,int height,byte fixedsamplelocations)
			=> glTexStorage2DMultisample(target,samples,internalFormat,width,height,fixedsamplelocations);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexStorage3DMultisample(TextureTargetMultisample3D target,int samples,uint internalFormat,int width,int height,int depth,byte fixedsamplelocations)
			=> glTexStorage3DMultisample(target,samples,internalFormat,width,height,depth,fixedsamplelocations);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TextureView(uint texture,TextureTarget target,uint origtexture,PixelInternalFormat internalFormat,uint minlevel,uint numlevels,uint minlayer,uint numlayers)
			=> glTextureView(texture,target,origtexture,internalFormat,minlevel,numlevels,minlayer,numlayers);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void BindVertexBuffer(uint bindingindex,uint buffer,int offset,int stride)
			=> glBindVertexBuffer(bindingindex,buffer,offset,stride);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttribFormat(uint attribindex,int size,uint type,byte normalized,uint relativeoffset)
			=> glVertexAttribFormat(attribindex,size,type,normalized,relativeoffset);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttribIFormat(uint attribindex,int size,uint type,uint relativeoffset)
			=> glVertexAttribIFormat(attribindex,size,type,relativeoffset);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttribLFormat(uint attribindex,int size,uint type,uint relativeoffset)
			=> glVertexAttribLFormat(attribindex,size,type,relativeoffset);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttribBinding(uint attribindex,uint bindingindex)
			=> glVertexAttribBinding(attribindex,bindingindex);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void VertexBindingDivisor(uint bindingindex,uint divisor)
			=> glVertexBindingDivisor(bindingindex,divisor);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void DebugMessageControl(uint source,uint type,uint severity,int count,ref uint ids,byte enabled)
			=> glDebugMessageControl(source,type,severity,count,ref ids,enabled);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void DebugMessageInsert(uint source,uint type,uint id,uint severity,int length,IntPtr buf)
			=> glDebugMessageInsert(source,type,id,severity,length,buf);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void DebugMessageCallback(DebugCallback callback,IntPtr userParameter)
			=> glDebugMessageCallback(callback,userParameter);
		
		[MethodImpl(ImplOptions)]
		public unsafe static uint GetDebugMessageLog(uint count,int bufSize,ref uint sources,ref uint types,ref uint ids,ref uint severities,ref int lengths,IntPtr messageLog)
			=> glGetDebugMessageLog(count,bufSize,ref sources,ref types,ref ids,ref severities,ref lengths,messageLog);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void PushDebugGroup(uint source,uint id,int length,IntPtr message)
			=> glPushDebugGroup(source,id,length,message);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void PopDebugGroup()
			=> glPopDebugGroup();
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ObjectLabel(uint identifier,uint name,int length,IntPtr label)
			=> glObjectLabel(identifier,name,length,label);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetObjectLabel(uint identifier,uint name,int bufSize,ref int length,IntPtr label)
			=> glGetObjectLabel(identifier,name,bufSize,ref length,label);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ObjectPtrLabel(IntPtr ptr,int length,IntPtr label)
			=> glObjectPtrLabel(ptr,length,label);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetObjectPtrLabel(IntPtr ptr,int bufSize,ref int length,IntPtr label)
			=> glGetObjectPtrLabel(ptr,bufSize,ref length,label);
	}
}
