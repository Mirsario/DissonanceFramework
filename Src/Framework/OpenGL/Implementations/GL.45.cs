﻿using System;

#pragma warning disable IDE0060 //Unused parameter.

namespace Dissonance.Framework.OpenGL
{
	partial class GL
	{
		[MethodImport("glClipControl","4.5")]
		public static void ClipControl(uint origin,uint depth)
			=> throw new NotImplementedException();

		[MethodImport("glCreateTransformFeedbacks","4.5")]
		public static void CreateTransformFeedbacks(int n,ref uint ids)
			=> throw new NotImplementedException();

		[MethodImport("glTransformFeedbackBufferBase","4.5")]
		public static void TransformFeedbackBufferBase(uint xfb,uint index,uint buffer)
			=> throw new NotImplementedException();

		[MethodImport("glTransformFeedbackBufferRange","4.5")]
		public static void TransformFeedbackBufferRange(uint xfb,uint index,uint buffer,int offset,int size)
			=> throw new NotImplementedException();

		[MethodImport("glGetTransformFeedbackiv","4.5")]
		public static void GetTransformFeedback(uint xfb,uint pName,ref int param)
			=> throw new NotImplementedException();

		[MethodImport("glGetTransformFeedbacki_v","4.5")]
		public static void GetTransformFeedback(uint xfb,uint pName,uint index,ref int param)
			=> throw new NotImplementedException();

		[MethodImport("glGetTransformFeedbacki64_v","4.5")]
		public static void GetTransformFeedback(uint xfb,uint pName,uint index,ref long param)
			=> throw new NotImplementedException();

		[MethodImport("glCreateBuffers","4.5")]
		public static void CreateBuffers(int n,ref uint buffers)
			=> throw new NotImplementedException();

		[MethodImport("glNamedBufferStorage","4.5")]
		public static void NamedBufferStorage(uint buffer,int size,IntPtr data,uint flags)
			=> throw new NotImplementedException();

		[MethodImport("glNamedBufferData","4.5")]
		public static void NamedBufferData(uint buffer,int size,IntPtr data,uint usage)
			=> throw new NotImplementedException();

		[MethodImport("glNamedBufferSubData","4.5")]
		public static void NamedBufferSubData(uint buffer,int offset,int size,IntPtr data)
			=> throw new NotImplementedException();

		[MethodImport("glCopyNamedBufferSubData","4.5")]
		public static void CopyNamedBufferSubData(uint readBuffer,uint writeBuffer,int readOffset,int writeOffset,int size)
			=> throw new NotImplementedException();

		[MethodImport("glClearNamedBufferData","4.5")]
		public static void ClearNamedBufferData(uint buffer,PixelInternalFormat internalFormat,uint format,uint type,IntPtr data)
			=> throw new NotImplementedException();

		[MethodImport("glClearNamedBufferSubData","4.5")]
		public static void ClearNamedBufferSubData(uint buffer,PixelInternalFormat internalFormat,int offset,int size,uint format,uint type,IntPtr data)
			=> throw new NotImplementedException();

		[MethodImport("glMapNamedBuffer","4.5")]
		public static IntPtr MapNamedBuffer(uint buffer,uint access)
			=> throw new NotImplementedException();

		[MethodImport("glMapNamedBufferRange","4.5")]
		public static IntPtr MapNamedBufferRange(uint buffer,int offset,int length,uint access)
			=> throw new NotImplementedException();

		[MethodImport("glUnmapNamedBuffer","4.5")]
		public static byte UnmapNamedBuffer(uint buffer)
			=> throw new NotImplementedException();

		[MethodImport("glFlushMappedNamedBufferRange","4.5")]
		public static void FlushMappedNamedBufferRange(uint buffer,int offset,int length)
			=> throw new NotImplementedException();

		[MethodImport("glGetNamedBufferParameteriv","4.5")]
		public static void GetNamedBufferParameter(uint buffer,uint pName,ref int parameters)
			=> throw new NotImplementedException();

		[MethodImport("glGetNamedBufferParameteri64v","4.5")]
		public static void GetNamedBufferParameter(uint buffer,uint pName,ref long parameters)
			=> throw new NotImplementedException();

		[MethodImport("glGetNamedBufferPointerv","4.5")]
		public static void GetNamedBufferPointer(uint buffer,uint pName,ref IntPtr parameters)
			=> throw new NotImplementedException();

		[MethodImport("glGetNamedBufferSubData","4.5")]
		public static void GetNamedBufferSubData(uint buffer,int offset,int size,IntPtr data)
			=> throw new NotImplementedException();

		[MethodImport("glCreateFramebuffers","4.5")]
		public static void CreateFramebuffers(int n,ref uint framebuffers)
			=> throw new NotImplementedException();

		[MethodImport("glNamedFramebufferRenderbuffer","4.5")]
		public static void NamedFramebufferRenderbuffer(uint framebuffer,uint attachment,uint renderbuffertarget,uint renderbuffer)
			=> throw new NotImplementedException();

		[MethodImport("glNamedFramebufferParameteri","4.5")]
		public static void NamedFramebufferParameter(uint framebuffer,uint pName,int param)
			=> throw new NotImplementedException();

		[MethodImport("glNamedFramebufferTexture","4.5")]
		public static void NamedFramebufferTexture(uint framebuffer,uint attachment,uint texture,int level)
			=> throw new NotImplementedException();

		[MethodImport("glNamedFramebufferTextureLayer","4.5")]
		public static void NamedFramebufferTextureLayer(uint framebuffer,uint attachment,uint texture,int level,int layer)
			=> throw new NotImplementedException();

		[MethodImport("glNamedFramebufferDrawBuffer","4.5")]
		public static void NamedFramebufferDrawBuffer(uint framebuffer,DrawBufferMode buf)
			=> throw new NotImplementedException();

		[MethodImport("glNamedFramebufferDrawBuffers","4.5")]
		public static void NamedFramebufferDrawBuffers(uint framebuffer,int n,DrawBufferMode[] bufs)
			=> throw new NotImplementedException();

		[MethodImport("glNamedFramebufferReadBuffer","4.5")]
		public static void NamedFramebufferReadBuffer(uint framebuffer,uint src)
			=> throw new NotImplementedException();

		[MethodImport("glInvalidateNamedFramebufferData","4.5")]
		public static void InvalidateNamedFramebufferData(uint framebuffer,int numAttachments,ref uint attachments)
			=> throw new NotImplementedException();

		[MethodImport("glInvalidateNamedFramebufferSubData","4.5")]
		public static void InvalidateNamedFramebufferSubData(uint framebuffer,int numAttachments,ref uint attachments,int x,int y,int width,int height)
			=> throw new NotImplementedException();

		[MethodImport("glClearNamedFramebufferiv","4.5")]
		public static void ClearNamedFramebuffer(uint framebuffer,uint buffer,int drawbuffer,ref int value)
			=> throw new NotImplementedException();

		[MethodImport("glClearNamedFramebufferuiv","4.5")]
		public static void ClearNamedFramebuffer(uint framebuffer,uint buffer,int drawbuffer,ref uint value)
			=> throw new NotImplementedException();

		[MethodImport("glClearNamedFramebufferfv","4.5")]
		public static void ClearNamedFramebuffer(uint framebuffer,uint buffer,int drawbuffer,ref float value)
			=> throw new NotImplementedException();

		[MethodImport("glClearNamedFramebufferfi","4.5")]
		public static void ClearNamedFramebuffer(uint framebuffer,uint buffer,int drawbuffer,float depth,int stencil)
			=> throw new NotImplementedException();

		[MethodImport("glBlitNamedFramebuffer","4.5")]
		public static void BlitNamedFramebuffer(uint readFramebuffer,uint drawFramebuffer,int srcX0,int srcY0,int srcX1,int srcY1,int dstX0,int dstY0,int dstX1,int dstY1,uint mask,uint filter)
			=> throw new NotImplementedException();

		[MethodImport("glCheckNamedFramebufferStatus","4.5")]
		public static uint CheckNamedFramebufferStatus(uint framebuffer,FramebufferTarget target)
			=> throw new NotImplementedException();

		[MethodImport("glGetNamedFramebufferParameteriv","4.5")]
		public static void GetNamedFramebufferParameter(uint framebuffer,uint pName,ref int param)
			=> throw new NotImplementedException();

		[MethodImport("glGetNamedFramebufferAttachmentParameteriv","4.5")]
		public static void GetNamedFramebufferAttachmentParameter(uint framebuffer,uint attachment,uint pName,ref int parameters)
			=> throw new NotImplementedException();

		[MethodImport("glCreateRenderbuffers","4.5")]
		public static void CreateRenderbuffers(int n,ref uint renderbuffers)
			=> throw new NotImplementedException();

		[MethodImport("glNamedRenderbufferStorage","4.5")]
		public static void NamedRenderbufferStorage(uint renderbuffer,PixelInternalFormat internalFormat,int width,int height)
			=> throw new NotImplementedException();

		[MethodImport("glNamedRenderbufferStorageMultisample","4.5")]
		public static void NamedRenderbufferStorageMultisample(uint renderbuffer,int samples,PixelInternalFormat internalFormat,int width,int height)
			=> throw new NotImplementedException();

		[MethodImport("glGetNamedRenderbufferParameteriv","4.5")]
		public static void GetNamedRenderbufferParameter(uint renderbuffer,uint pName,ref int parameters)
			=> throw new NotImplementedException();

		[MethodImport("glCreateTextures","4.5")]
		public static void CreateTextures(uint target,int n,ref uint textures)
			=> throw new NotImplementedException();

		[MethodImport("glTextureBuffer","4.5")]
		public static void TextureBuffer(uint texture,uint internalFormat,uint buffer)
			=> throw new NotImplementedException();

		[MethodImport("glTextureBufferRange","4.5")]
		public static void TextureBufferRange(uint texture,uint internalFormat,uint buffer,int offset,int size)
			=> throw new NotImplementedException();

		[MethodImport("glTextureStorage1D","4.5")]
		public static void TextureStorage1D(uint texture,int levels,uint internalFormat,int width)
			=> throw new NotImplementedException();

		[MethodImport("glTextureStorage2D","4.5")]
		public static void TextureStorage2D(uint texture,int levels,uint internalFormat,int width,int height)
			=> throw new NotImplementedException();

		[MethodImport("glTextureStorage3D","4.5")]
		public static void TextureStorage3D(uint texture,int levels,uint internalFormat,int width,int height,int depth)
			=> throw new NotImplementedException();

		[MethodImport("glTextureStorage2DMultisample","4.5")]
		public static void TextureStorage2DMultisample(uint texture,int samples,uint internalFormat,int width,int height,byte fixedsamplelocations)
			=> throw new NotImplementedException();

		[MethodImport("glTextureStorage3DMultisample","4.5")]
		public static void TextureStorage3DMultisample(uint texture,int samples,uint internalFormat,int width,int height,int depth,byte fixedsamplelocations)
			=> throw new NotImplementedException();

		[MethodImport("glTextureSubImage1D","4.5")]
		public static void TextureSubImage1D(uint texture,int level,int xOffset,int width,uint format,uint type,IntPtr pixels)
			=> throw new NotImplementedException();

		[MethodImport("glTextureSubImage2D","4.5")]
		public static void TextureSubImage2D(uint texture,int level,int xOffset,int yOffset,int width,int height,uint format,uint type,IntPtr pixels)
			=> throw new NotImplementedException();

		[MethodImport("glTextureSubImage3D","4.5")]
		public static void TextureSubImage3D(uint texture,int level,int xOffset,int yOffset,int zOffset,int width,int height,int depth,uint format,uint type,IntPtr pixels)
			=> throw new NotImplementedException();

		[MethodImport("glCompressedTextureSubImage1D","4.5")]
		public static void CompressedTextureSubImage1D(uint texture,int level,int xOffset,int width,uint format,int imageSize,IntPtr data)
			=> throw new NotImplementedException();

		[MethodImport("glCompressedTextureSubImage2D","4.5")]
		public static void CompressedTextureSubImage2D(uint texture,int level,int xOffset,int yOffset,int width,int height,uint format,int imageSize,IntPtr data)
			=> throw new NotImplementedException();

		[MethodImport("glCompressedTextureSubImage3D","4.5")]
		public static void CompressedTextureSubImage3D(uint texture,int level,int xOffset,int yOffset,int zOffset,int width,int height,int depth,uint format,int imageSize,IntPtr data)
			=> throw new NotImplementedException();

		[MethodImport("glCopyTextureSubImage1D","4.5")]
		public static void CopyTextureSubImage1D(uint texture,int level,int xOffset,int x,int y,int width)
			=> throw new NotImplementedException();

		[MethodImport("glCopyTextureSubImage2D","4.5")]
		public static void CopyTextureSubImage2D(uint texture,int level,int xOffset,int yOffset,int x,int y,int width,int height)
			=> throw new NotImplementedException();

		[MethodImport("glCopyTextureSubImage3D","4.5")]
		public static void CopyTextureSubImage3D(uint texture,int level,int xOffset,int yOffset,int zOffset,int x,int y,int width,int height)
			=> throw new NotImplementedException();

		[MethodImport("glTextureParameterf","4.5")]
		public static void TextureParameter(uint texture,uint pName,float param)
			=> throw new NotImplementedException();

		[MethodImport("glTextureParameterfv","4.5")]
		public static void TextureParameter(uint texture,uint pName,ref float param)
			=> throw new NotImplementedException();

		[MethodImport("glTextureParameteri","4.5")]
		public static void TextureParameter(uint texture,uint pName,int param)
			=> throw new NotImplementedException();

		[MethodImport("glTextureParameterIiv","4.5")]
		public static void TextureParameterI(uint texture,uint pName,ref int parameters)
			=> throw new NotImplementedException();

		[MethodImport("glTextureParameterIuiv","4.5")]
		public static void TextureParameterI(uint texture,uint pName,ref uint parameters)
			=> throw new NotImplementedException();

		[MethodImport("glTextureParameteriv","4.5")]
		public static void TextureParameter(uint texture,uint pName,ref int param)
			=> throw new NotImplementedException();

		[MethodImport("glGenerateTextureMipmap","4.5")]
		public static void GenerateTextureMipmap(uint texture)
			=> throw new NotImplementedException();

		[MethodImport("glBindTextureUnit","4.5")]
		public static void BindTextureUnit(uint unit,uint texture)
			=> throw new NotImplementedException();

		[MethodImport("glGetTextureImage","4.5")]
		public static void GetTextureImage(uint texture,int level,uint format,uint type,int bufSize,IntPtr pixels)
			=> throw new NotImplementedException();

		[MethodImport("glGetCompressedTextureImage","4.5")]
		public static void GetCompressedTextureImage(uint texture,int level,int bufSize,IntPtr pixels)
			=> throw new NotImplementedException();

		[MethodImport("glGetTextureLevelParameterfv","4.5")]
		public static void GetTextureLevelParameter(TextureTarget texture,int level,uint pName,ref float parameters)
			=> throw new NotImplementedException();

		[MethodImport("glGetTextureLevelParameteriv","4.5")]
		public static void GetTextureLevelParameter(TextureTarget texture,int level,uint pName,ref int parameters)
			=> throw new NotImplementedException();

		[MethodImport("glGetTextureParameterfv","4.5")]
		public static void GetTextureParameter(uint texture,uint pName,ref float parameters)
			=> throw new NotImplementedException();

		[MethodImport("glGetTextureParameterIiv","4.5")]
		public static void GetTextureParameterI(uint texture,uint pName,ref int parameters)
			=> throw new NotImplementedException();

		[MethodImport("glGetTextureParameterIuiv","4.5")]
		public static void GetTextureParameterI(uint texture,uint pName,ref uint parameters)
			=> throw new NotImplementedException();

		[MethodImport("glGetTextureParameteriv","4.5")]
		public static void GetTextureParameter(uint texture,uint pName,ref int parameters)
			=> throw new NotImplementedException();

		[MethodImport("glCreateVertexArrays","4.5")]
		public static void CreateVertexArrays(int n,ref uint arrays)
			=> throw new NotImplementedException();

		[MethodImport("glDisableVertexArrayAttrib","4.5")]
		public static void DisableVertexArrayAttrib(uint vaobj,uint index)
			=> throw new NotImplementedException();

		[MethodImport("glEnableVertexArrayAttrib","4.5")]
		public static void EnableVertexArrayAttrib(uint vaobj,uint index)
			=> throw new NotImplementedException();

		[MethodImport("glVertexArrayElementBuffer","4.5")]
		public static void VertexArrayElementBuffer(uint vaobj,uint buffer)
			=> throw new NotImplementedException();

		[MethodImport("glVertexArrayVertexBuffer","4.5")]
		public static void VertexArrayVertexBuffer(uint vaobj,uint bindingindex,uint buffer,int offset,int stride)
			=> throw new NotImplementedException();

		[MethodImport("glVertexArrayVertexBuffers","4.5")]
		public static void VertexArrayVertexBuffers(uint vaobj,uint first,int count,ref uint buffers,ref int offsets,ref int strides)
			=> throw new NotImplementedException();

		[MethodImport("glVertexArrayAttribBinding","4.5")]
		public static void VertexArrayAttribBinding(uint vaobj,uint attribindex,uint bindingindex)
			=> throw new NotImplementedException();

		[MethodImport("glVertexArrayAttribFormat","4.5")]
		public static void VertexArrayAttribFormat(uint vaobj,uint attribindex,int size,uint type,byte normalized,uint relativeoffset)
			=> throw new NotImplementedException();

		[MethodImport("glVertexArrayAttribIFormat","4.5")]
		public static void VertexArrayAttribIFormat(uint vaobj,uint attribindex,int size,uint type,uint relativeoffset)
			=> throw new NotImplementedException();

		[MethodImport("glVertexArrayAttribLFormat","4.5")]
		public static void VertexArrayAttribLFormat(uint vaobj,uint attribindex,int size,uint type,uint relativeoffset)
			=> throw new NotImplementedException();

		[MethodImport("glVertexArrayBindingDivisor","4.5")]
		public static void VertexArrayBindingDivisor(uint vaobj,uint bindingindex,uint divisor)
			=> throw new NotImplementedException();

		[MethodImport("glGetVertexArrayiv","4.5")]
		public static void GetVertexArray(uint vaobj,uint pName,ref int param)
			=> throw new NotImplementedException();

		[MethodImport("glGetVertexArrayIndexediv","4.5")]
		public static void GetVertexArrayIndexed(uint vaobj,uint index,uint pName,ref int param)
			=> throw new NotImplementedException();

		[MethodImport("glGetVertexArrayIndexed64iv","4.5")]
		public static void GetVertexArrayIndexed(uint vaobj,uint index,uint pName,ref long param)
			=> throw new NotImplementedException();

		[MethodImport("glCreateSamplers","4.5")]
		public static void CreateSamplers(int n,ref uint samplers)
			=> throw new NotImplementedException();

		[MethodImport("glCreateProgramPipelines","4.5")]
		public static void CreateProgramPipelines(int n,ref uint pipelines)
			=> throw new NotImplementedException();

		[MethodImport("glCreateQueries","4.5")]
		public static void CreateQueries(uint target,int n,ref uint ids)
			=> throw new NotImplementedException();

		[MethodImport("glGetQueryBufferObjecti64v","4.5")]
		public static void GetQueryBufferObjectLong(uint id,uint buffer,uint pName,int offset)
			=> throw new NotImplementedException();

		[MethodImport("glGetQueryBufferObjectiv","4.5")]
		public static void GetQueryBufferObjectInt(uint id,uint buffer,uint pName,int offset)
			=> throw new NotImplementedException();

		[MethodImport("glGetQueryBufferObjectui64v","4.5")]
		public static void GetQueryBufferObjectULong(uint id,uint buffer,uint pName,int offset)
			=> throw new NotImplementedException();

		[MethodImport("glGetQueryBufferObjectuiv","4.5")]
		public static void GetQueryBufferObjectUInt(uint id,uint buffer,uint pName,int offset)
			=> throw new NotImplementedException();

		[MethodImport("glMemoryBarrierByRegion","4.5")]
		public static void MemoryBarrierByRegion(uint barriers)
			=> throw new NotImplementedException();

		[MethodImport("glGetTextureSubImage","4.5")]
		public static void GetTextureSubImage(uint texture,int level,int xOffset,int yOffset,int zOffset,int width,int height,int depth,uint format,uint type,int bufSize,IntPtr pixels)
			=> throw new NotImplementedException();

		[MethodImport("glGetCompressedTextureSubImage","4.5")]
		public static void GetCompressedTextureSubImage(uint texture,int level,int xOffset,int yOffset,int zOffset,int width,int height,int depth,int bufSize,IntPtr pixels)
			=> throw new NotImplementedException();

		[MethodImport("glGetGraphicsResetStatus","4.5")]
		public static uint GetGraphicsResetStatus()
			=> throw new NotImplementedException();

		[MethodImport("glGetnCompressedTexImage","4.5")]
		public static void GetnCompressedTexImage(TextureTarget target,int lod,int bufSize,IntPtr pixels)
			=> throw new NotImplementedException();

		[MethodImport("glGetnTexImage","4.5")]
		public static void GetnTexImage(TextureTarget target,int level,uint format,uint type,int bufSize,IntPtr pixels)
			=> throw new NotImplementedException();

		[MethodImport("glGetnUniformdv","4.5")]
		public static void GetnUniform(uint program,int location,int bufSize,ref double parameters)
			=> throw new NotImplementedException();

		[MethodImport("glGetnUniformfv","4.5")]
		public static void GetnUniform(uint program,int location,int bufSize,ref float parameters)
			=> throw new NotImplementedException();

		[MethodImport("glGetnUniformiv","4.5")]
		public static void GetnUniform(uint program,int location,int bufSize,ref int parameters)
			=> throw new NotImplementedException();

		[MethodImport("glGetnUniformuiv","4.5")]
		public static void GetnUniform(uint program,int location,int bufSize,ref uint parameters)
			=> throw new NotImplementedException();

		[MethodImport("glReadnPixels","4.5")]
		public static void ReadnPixels(int x,int y,int width,int height,uint format,uint type,int bufSize,IntPtr data)
			=> throw new NotImplementedException();

		[MethodImport("glTextureBarrier","4.5")]
		public static void TextureBarrier()
			=> throw new NotImplementedException();
	}
}