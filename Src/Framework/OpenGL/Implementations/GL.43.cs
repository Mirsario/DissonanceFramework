using System;
using System.Runtime.InteropServices;

#pragma warning disable IDE0060 //Unused parameter.

namespace Dissonance.Framework.OpenGL
{
	partial class GL
	{
		[MethodImport("glClearBufferData","4.3")]
		public static void ClearBufferData(BufferTarget target,PixelInternalFormat internalFormat,PixelFormat format,PixelType type,IntPtr data)
			=> throw new NotImplementedException();

		[MethodImport("glClearBufferSubData","4.3")]
		public static void ClearBufferSubData(BufferTarget target,PixelInternalFormat internalFormat,int offset,int size,PixelFormat format,PixelType type,IntPtr data)
			=> throw new NotImplementedException();

		[MethodImport("glDispatchCompute","4.3")]
		public static void DispatchCompute(uint num_groups_x,uint num_groups_y,uint num_groups_z)
			=> throw new NotImplementedException();

		[MethodImport("glDispatchComputeIndirect","4.3")]
		public static void DispatchComputeIndirect(int indirect)
			=> throw new NotImplementedException();

		[MethodImport("glCopyImageSubData","4.3")]
		public static void CopyImageSubData(uint srcName,uint srcTarget,int srcLevel,int srcX,int srcY,int srcZ,uint dstName,uint dstTarget,int dstLevel,int dstX,int dstY,int dstZ,int srcWidth,int srcHeight,int srcDepth)
			=> throw new NotImplementedException();

		[MethodImport("glFramebufferParameteri","4.3")]
		public static void FramebufferParameter(FramebufferTarget target,uint pName,int param)
			=> throw new NotImplementedException();

		[MethodImport("glGetFramebufferParameteriv","4.3")]
		public static void GetFramebufferParameter(FramebufferTarget target,uint pName,ref int parameters)
			=> throw new NotImplementedException();

		[MethodImport("glGetInternalformati64v","4.3")]
		public static void GetInternalformat(uint target,uint internalFormat,uint pName,int bufSize,ref long parameters)
			=> throw new NotImplementedException();

		[MethodImport("glInvalidateTexSubImage","4.3")]
		public static void InvalidateTexSubImage(uint texture,int level,int xOffset,int yOffset,int zOffset,int width,int height,int depth)
			=> throw new NotImplementedException();

		[MethodImport("glInvalidateTexImage","4.3")]
		public static void InvalidateTexImage(uint texture,int level)
			=> throw new NotImplementedException();

		[MethodImport("glInvalidateBufferSubData","4.3")]
		public static void InvalidateBufferSubData(uint buffer,int offset,int length)
			=> throw new NotImplementedException();

		[MethodImport("glInvalidateBufferData","4.3")]
		public static void InvalidateBufferData(uint buffer)
			=> throw new NotImplementedException();

		[MethodImport("glInvalidateFramebuffer","4.3")]
		public static unsafe void InvalidateFramebuffer(FramebufferTarget target,int numAttachments,FramebufferAttachment* attachments)
			=> throw new NotImplementedException();

		[MethodImport("glInvalidateSubFramebuffer","4.3")]
		public static unsafe void InvalidateSubFramebuffer(FramebufferTarget target,int numAttachments,FramebufferAttachment* attachments,int x,int y,int width,int height)
			=> throw new NotImplementedException();

		[MethodImport("glMultiDrawArraysIndirect","4.3")]
		public static void MultiDrawArraysIndirect(uint mode,IntPtr indirect,int drawcount,int stride)
			=> throw new NotImplementedException();

		[MethodImport("glMultiDrawElementsIndirect","4.3")]
		public static void MultiDrawElementsIndirect(uint mode,uint type,IntPtr indirect,int drawcount,int stride)
			=> throw new NotImplementedException();

		[MethodImport("glGetProgramInterfaceiv","4.3")]
		public static void GetProgramInterface(uint program,uint programInterface,uint pName,ref int parameters)
			=> throw new NotImplementedException();

		[MethodImport("glGetProgramResourceIndex","4.3")]
		public static uint GetProgramResourceIndex(uint program,uint programInterface,IntPtr name)
			=> throw new NotImplementedException();

		[MethodImport("glGetProgramResourceName","4.3")]
		public static void GetProgramResourceName(uint program,uint programInterface,uint index,int bufSize,ref int length,IntPtr name)
			=> throw new NotImplementedException();

		[MethodImport("glGetProgramResourceiv","4.3")]
		public static void GetProgramResource(uint program,uint programInterface,uint index,int propCount,ref uint props,int bufSize,ref int length,ref int parameters)
			=> throw new NotImplementedException();

		[MethodImport("glGetProgramResourceLocation","4.3")]
		public static int GetProgramResourceLocation(uint program,uint programInterface,IntPtr name)
			=> throw new NotImplementedException();

		[MethodImport("glGetProgramResourceLocationIndex","4.3")]
		public static int GetProgramResourceLocationIndex(uint program,uint programInterface,IntPtr name)
			=> throw new NotImplementedException();

		[MethodImport("glShaderStorageBlockBinding","4.3")]
		public static void ShaderStorageBlockBinding(uint program,uint storageBlockIndex,uint storageBlockBinding)
			=> throw new NotImplementedException();

		[MethodImport("glTexBufferRange","4.3")]
		public static void TexBufferRange(TextureBufferTarget target,uint internalFormat,uint buffer,int offset,int size)
			=> throw new NotImplementedException();

		[MethodImport("glTexStorage2DMultisample","4.3")]
		public static void TexStorage2DMultisample(TextureTargetMultisample2D target,int samples,uint internalFormat,int width,int height,byte fixedsamplelocations)
			=> throw new NotImplementedException();

		[MethodImport("glTexStorage3DMultisample","4.3")]
		public static void TexStorage3DMultisample(TextureTargetMultisample3D target,int samples,uint internalFormat,int width,int height,int depth,byte fixedsamplelocations)
			=> throw new NotImplementedException();

		[MethodImport("glTextureView","4.3")]
		public static void TextureView(uint texture,TextureTarget target,uint origtexture,PixelInternalFormat internalFormat,uint minlevel,uint numlevels,uint minlayer,uint numlayers)
			=> throw new NotImplementedException();

		[MethodImport("glBindVertexBuffer","4.3")]
		public static void BindVertexBuffer(uint bindingindex,uint buffer,int offset,int stride)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttribFormat","4.3")]
		public static void VertexAttribFormat(uint attribindex,int size,uint type,byte normalized,uint relativeoffset)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttribIFormat","4.3")]
		public static void VertexAttribIFormat(uint attribindex,int size,uint type,uint relativeoffset)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttribLFormat","4.3")]
		public static void VertexAttribLFormat(uint attribindex,int size,uint type,uint relativeoffset)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttribBinding","4.3")]
		public static void VertexAttribBinding(uint attribindex,uint bindingindex)
			=> throw new NotImplementedException();

		[MethodImport("glVertexBindingDivisor","4.3")]
		public static void VertexBindingDivisor(uint bindingindex,uint divisor)
			=> throw new NotImplementedException();

		[MethodImport("glDebugMessageControl","4.3")]
		public static void DebugMessageControl(uint source,uint type,uint severity,int count,ref uint ids,byte enabled)
			=> throw new NotImplementedException();

		[MethodImport("glDebugMessageInsert","4.3")]
		public static void DebugMessageInsert(uint source,uint type,uint id,uint severity,int length,IntPtr buf)
			=> throw new NotImplementedException();

		[MethodImport("glDebugMessageCallback","4.3")]
		public static void DebugMessageCallback(DebugCallback callback,IntPtr userParameter)
			=> throw new NotImplementedException();

		[MethodImport("glGetDebugMessageLog","4.3")]
		public static uint GetDebugMessageLog(uint count,int bufSize,ref uint sources,ref uint types,ref uint ids,ref uint severities,ref int lengths,IntPtr messageLog)
			=> throw new NotImplementedException();

		[MethodImport("glPushDebugGroup","4.3")]
		public static void PushDebugGroup(uint source,uint id,int length,IntPtr message)
			=> throw new NotImplementedException();

		[MethodImport("glPopDebugGroup","4.3")]
		public static void PopDebugGroup()
			=> throw new NotImplementedException();

		[MethodImport("glObjectLabel","4.3")]
		public static void ObjectLabel(uint identifier,uint name,int length,IntPtr label)
			=> throw new NotImplementedException();

		[MethodImport("glGetObjectLabel","4.3")]
		public static void GetObjectLabel(uint identifier,uint name,int bufSize,ref int length,IntPtr label)
			=> throw new NotImplementedException();

		[MethodImport("glObjectPtrLabel","4.3")]
		public static void ObjectPtrLabel(IntPtr ptr,int length,IntPtr label)
			=> throw new NotImplementedException();

		[MethodImport("glGetObjectPtrLabel","4.3")]
		public static void GetObjectPtrLabel(IntPtr ptr,int bufSize,ref int length,IntPtr label)
			=> throw new NotImplementedException();
	}
}