using System;
using System.Runtime.CompilerServices;

#pragma warning disable IDE0060 //Unused parameter.

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[MethodImpl(ImplOptions)]
		[MethodImport("glClearBufferData","4.3")]
		public static void ClearBufferData(BufferTarget target,PixelInternalFormat internalFormat,PixelFormat format,PixelType type,IntPtr data)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glClearBufferSubData","4.3")]
		public static void ClearBufferSubData(BufferTarget target,PixelInternalFormat internalFormat,int offset,int size,PixelFormat format,PixelType type,IntPtr data)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glDispatchCompute","4.3")]
		public static void DispatchCompute(uint num_groups_x,uint num_groups_y,uint num_groups_z)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glDispatchComputeIndirect","4.3")]
		public static void DispatchComputeIndirect(int indirect)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glCopyImageSubData","4.3")]
		public static void CopyImageSubData(uint srcName,uint srcTarget,int srcLevel,int srcX,int srcY,int srcZ,uint dstName,uint dstTarget,int dstLevel,int dstX,int dstY,int dstZ,int srcWidth,int srcHeight,int srcDepth)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glFramebufferParameteri","4.3")]
		public static void FramebufferParameter(FramebufferTarget target,uint pName,int param)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetFramebufferParameteriv","4.3")]
		public static void GetFramebufferParameter(FramebufferTarget target,uint pName,ref int parameters)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetInternalformati64v","4.3")]
		public static void GetInternalformat(uint target,uint internalFormat,uint pName,int bufSize,ref long parameters)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glInvalidateTexSubImage","4.3")]
		public static void InvalidateTexSubImage(uint texture,int level,int xOffset,int yOffset,int zOffset,int width,int height,int depth)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glInvalidateTexImage","4.3")]
		public static void InvalidateTexImage(uint texture,int level)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glInvalidateBufferSubData","4.3")]
		public static void InvalidateBufferSubData(uint buffer,int offset,int length)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glInvalidateBufferData","4.3")]
		public static void InvalidateBufferData(uint buffer)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glInvalidateFramebuffer","4.3")]
		public static unsafe void InvalidateFramebuffer(FramebufferTarget target,int numAttachments,FramebufferAttachment* attachments)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glInvalidateSubFramebuffer","4.3")]
		public static unsafe void InvalidateSubFramebuffer(FramebufferTarget target,int numAttachments,FramebufferAttachment* attachments,int x,int y,int width,int height)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glMultiDrawArraysIndirect","4.3")]
		public static void MultiDrawArraysIndirect(uint mode,IntPtr indirect,int drawcount,int stride)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glMultiDrawElementsIndirect","4.3")]
		public static void MultiDrawElementsIndirect(uint mode,uint type,IntPtr indirect,int drawcount,int stride)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetProgramInterfaceiv","4.3")]
		public static void GetProgramInterface(uint program,uint programInterface,uint pName,ref int parameters)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetProgramResourceIndex","4.3")]
		public static uint GetProgramResourceIndex(uint program,uint programInterface,IntPtr name)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetProgramResourceName","4.3")]
		public static void GetProgramResourceName(uint program,uint programInterface,uint index,int bufSize,ref int length,IntPtr name)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetProgramResourceiv","4.3")]
		public static void GetProgramResource(uint program,uint programInterface,uint index,int propCount,ref uint props,int bufSize,ref int length,ref int parameters)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetProgramResourceLocation","4.3")]
		public static int GetProgramResourceLocation(uint program,uint programInterface,IntPtr name)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetProgramResourceLocationIndex","4.3")]
		public static int GetProgramResourceLocationIndex(uint program,uint programInterface,IntPtr name)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glShaderStorageBlockBinding","4.3")]
		public static void ShaderStorageBlockBinding(uint program,uint storageBlockIndex,uint storageBlockBinding)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glTexBufferRange","4.3")]
		public static void TexBufferRange(TextureBufferTarget target,uint internalFormat,uint buffer,int offset,int size)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glTexStorage2DMultisample","4.3")]
		public static void TexStorage2DMultisample(TextureTargetMultisample2D target,int samples,uint internalFormat,int width,int height,byte fixedsamplelocations)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glTexStorage3DMultisample","4.3")]
		public static void TexStorage3DMultisample(TextureTargetMultisample3D target,int samples,uint internalFormat,int width,int height,int depth,byte fixedsamplelocations)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glTextureView","4.3")]
		public static void TextureView(uint texture,TextureTarget target,uint origtexture,PixelInternalFormat internalFormat,uint minlevel,uint numlevels,uint minlayer,uint numlayers)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glBindVertexBuffer","4.3")]
		public static void BindVertexBuffer(uint bindingindex,uint buffer,int offset,int stride)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glVertexAttribFormat","4.3")]
		public static void VertexAttribFormat(uint attribindex,int size,uint type,byte normalized,uint relativeoffset)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glVertexAttribIFormat","4.3")]
		public static void VertexAttribIFormat(uint attribindex,int size,uint type,uint relativeoffset)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glVertexAttribLFormat","4.3")]
		public static void VertexAttribLFormat(uint attribindex,int size,uint type,uint relativeoffset)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glVertexAttribBinding","4.3")]
		public static void VertexAttribBinding(uint attribindex,uint bindingindex)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glVertexBindingDivisor","4.3")]
		public static void VertexBindingDivisor(uint bindingindex,uint divisor)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glDebugMessageControl","4.3")]
		public static void DebugMessageControl(uint source,uint type,uint severity,int count,ref uint ids,byte enabled)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glDebugMessageInsert","4.3")]
		public static void DebugMessageInsert(uint source,uint type,uint id,uint severity,int length,IntPtr buf)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glDebugMessageCallback","4.3")]
		public static void DebugMessageCallback(DebugCallback callback,IntPtr userParameter)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetDebugMessageLog","4.3")]
		public static uint GetDebugMessageLog(uint count,int bufSize,ref uint sources,ref uint types,ref uint ids,ref uint severities,ref int lengths,IntPtr messageLog)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glPushDebugGroup","4.3")]
		public static void PushDebugGroup(uint source,uint id,int length,IntPtr message)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glPopDebugGroup","4.3")]
		public static void PopDebugGroup()
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glObjectLabel","4.3")]
		public static void ObjectLabel(uint identifier,uint name,int length,IntPtr label)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetObjectLabel","4.3")]
		public static void GetObjectLabel(uint identifier,uint name,int bufSize,ref int length,IntPtr label)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glObjectPtrLabel","4.3")]
		public static void ObjectPtrLabel(IntPtr ptr,int length,IntPtr label)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetObjectPtrLabel","4.3")]
		public static void GetObjectPtrLabel(IntPtr ptr,int bufSize,ref int length,IntPtr label)
			=> throw new NotImplementedException();
	}
}