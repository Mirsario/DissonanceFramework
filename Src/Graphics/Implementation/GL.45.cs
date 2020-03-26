using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#pragma warning disable IDE0060 //Unused parameter.

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[MethodImpl(ImplOptions)]
		[MethodImport("glClipControl","4.5")]
		public static void ClipControl(uint origin,uint depth)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glCreateTransformFeedbacks","4.5")]
		public static void CreateTransformFeedbacks(int n,ref uint ids)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glTransformFeedbackBufferBase","4.5")]
		public static void TransformFeedbackBufferBase(uint xfb,uint index,uint buffer)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glTransformFeedbackBufferRange","4.5")]
		public static void TransformFeedbackBufferRange(uint xfb,uint index,uint buffer,int offset,int size)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetTransformFeedbackiv","4.5")]
		public static void GetTransformFeedback(uint xfb,uint pName,ref int param)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetTransformFeedbacki_v","4.5")]
		public static void GetTransformFeedback(uint xfb,uint pName,uint index,ref int param)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetTransformFeedbacki64_v","4.5")]
		public static void GetTransformFeedback(uint xfb,uint pName,uint index,ref long param)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glCreateBuffers","4.5")]
		public static void CreateBuffers(int n,[Out] uint[] buffers)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glNamedBufferStorage","4.5")]
		public static void NamedBufferStorage(uint buffer,int size,IntPtr data,uint flags)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glNamedBufferData","4.5")]
		public static void NamedBufferData(uint buffer,int size,IntPtr data,BufferUsageHint usage)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glNamedBufferSubData","4.5")]
		public static void NamedBufferSubData(uint buffer,int offset,int size,IntPtr data)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glCopyNamedBufferSubData","4.5")]
		public static void CopyNamedBufferSubData(uint readBuffer,uint writeBuffer,int readOffset,int writeOffset,int size)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glClearNamedBufferData","4.5")]
		public static void ClearNamedBufferData(uint buffer,PixelInternalFormat internalFormat,PixelFormat format,PixelType type,IntPtr data)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glClearNamedBufferSubData","4.5")]
		public static void ClearNamedBufferSubData(uint buffer,PixelInternalFormat internalFormat,int offset,int size,PixelFormat format,PixelType type,IntPtr data)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glMapNamedBuffer","4.5")]
		public static IntPtr MapNamedBuffer(uint buffer,uint access)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glMapNamedBufferRange","4.5")]
		public static IntPtr MapNamedBufferRange(uint buffer,int offset,int length,uint access)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glUnmapNamedBuffer","4.5")]
		public static byte UnmapNamedBuffer(uint buffer)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glFlushMappedNamedBufferRange","4.5")]
		public static void FlushMappedNamedBufferRange(uint buffer,int offset,int length)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetNamedBufferParameteriv","4.5")]
		public static void GetNamedBufferParameter(uint buffer,uint pName,ref int parameters)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetNamedBufferParameteri64v","4.5")]
		public static void GetNamedBufferParameter(uint buffer,uint pName,ref long parameters)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetNamedBufferPointerv","4.5")]
		public static void GetNamedBufferPointer(uint buffer,uint pName,ref IntPtr parameters)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetNamedBufferSubData","4.5")]
		public static void GetNamedBufferSubData(uint buffer,int offset,int size,IntPtr data)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glCreateFramebuffers","4.5")]
		public static void CreateFramebuffers(int n,ref uint framebuffers)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glNamedFramebufferRenderbuffer","4.5")]
		public static void NamedFramebufferRenderbuffer(uint framebuffer,uint attachment,RenderbufferTarget renderbuffertarget,uint renderbuffer)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glNamedFramebufferParameteri","4.5")]
		public static void NamedFramebufferParameter(uint framebuffer,uint pName,int param)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glNamedFramebufferTexture","4.5")]
		public static void NamedFramebufferTexture(uint framebuffer,FramebufferAttachment attachment,uint texture,int level)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glNamedFramebufferTextureLayer","4.5")]
		public static void NamedFramebufferTextureLayer(uint framebuffer,FramebufferAttachment attachment,uint texture,int level,int layer)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glNamedFramebufferDrawBuffer","4.5")]
		public static void NamedFramebufferDrawBuffer(uint framebuffer,DrawBufferMode buf)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glNamedFramebufferDrawBuffers","4.5")]
		public static void NamedFramebufferDrawBuffers(uint framebuffer,int n,DrawBufferMode[] bufs)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glNamedFramebufferReadBuffer","4.5")]
		public static void NamedFramebufferReadBuffer(uint framebuffer,uint src)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glInvalidateNamedFramebufferData","4.5")]
		public static unsafe void InvalidateNamedFramebufferData(uint framebuffer,int numAttachments,FramebufferAttachment* attachments)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glInvalidateNamedFramebufferSubData","4.5")]
		public static unsafe void InvalidateNamedFramebufferSubData(uint framebuffer,int numAttachments,FramebufferAttachment* attachments,int x,int y,int width,int height)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glClearNamedFramebufferiv","4.5")]
		public static void ClearNamedFramebuffer(uint framebuffer,uint buffer,int drawbuffer,ref int value)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glClearNamedFramebufferuiv","4.5")]
		public static void ClearNamedFramebuffer(uint framebuffer,uint buffer,int drawbuffer,ref uint value)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glClearNamedFramebufferfv","4.5")]
		public static void ClearNamedFramebuffer(uint framebuffer,uint buffer,int drawbuffer,ref float value)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glClearNamedFramebufferfi","4.5")]
		public static void ClearNamedFramebuffer(uint framebuffer,uint buffer,int drawbuffer,float depth,int stencil)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glBlitNamedFramebuffer","4.5")]
		public static void BlitNamedFramebuffer(uint readFramebuffer,uint drawFramebuffer,int srcX0,int srcY0,int srcX1,int srcY1,int dstX0,int dstY0,int dstX1,int dstY1,uint mask,uint filter)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glCheckNamedFramebufferStatus","4.5")]
		public static uint CheckNamedFramebufferStatus(uint framebuffer,FramebufferTarget target)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetNamedFramebufferParameteriv","4.5")]
		public static void GetNamedFramebufferParameter(uint framebuffer,uint pName,ref int param)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetNamedFramebufferAttachmentParameteriv","4.5")]
		public static void GetNamedFramebufferAttachmentParameter(uint framebuffer,FramebufferAttachment attachment,uint pName,ref int parameters)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glCreateRenderbuffers","4.5")]
		public static void CreateRenderbuffers(int n,ref uint renderbuffers)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glNamedRenderbufferStorage","4.5")]
		public static void NamedRenderbufferStorage(uint renderbuffer,PixelInternalFormat internalFormat,int width,int height)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glNamedRenderbufferStorageMultisample","4.5")]
		public static void NamedRenderbufferStorageMultisample(uint renderbuffer,int samples,PixelInternalFormat internalFormat,int width,int height)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetNamedRenderbufferParameteriv","4.5")]
		public static void GetNamedRenderbufferParameter(uint renderbuffer,uint pName,ref int parameters)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glCreateTextures","4.5")]
		public static void CreateTextures(TextureTarget target,uint n,IntPtr textures)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glTextureBuffer","4.5")]
		public static void TextureBuffer(uint texture,uint internalFormat,uint buffer)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glTextureBufferRange","4.5")]
		public static void TextureBufferRange(uint texture,uint internalFormat,uint buffer,IntPtr offset,IntPtr size)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glTextureStorage1D","4.5")]
		public static void TextureStorage1D(uint texture,int levels,uint internalFormat,int width)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glTextureStorage2D","4.5")]
		public static void TextureStorage2D(uint texture,int levels,uint internalFormat,int width,int height)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glTextureStorage3D","4.5")]
		public static void TextureStorage3D(uint texture,int levels,uint internalFormat,int width,int height,int depth)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glTextureStorage2DMultisample","4.5")]
		public static void TextureStorage2DMultisample(uint texture,int samples,uint internalFormat,int width,int height,byte fixedsamplelocations)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glTextureStorage3DMultisample","4.5")]
		public static void TextureStorage3DMultisample(uint texture,int samples,uint internalFormat,int width,int height,int depth,byte fixedsamplelocations)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glTextureSubImage1D","4.5")]
		public static void TextureSubImage1D(uint texture,int level,int xOffset,int width,PixelFormat format,PixelType type,IntPtr pixels)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glTextureSubImage2D","4.5")]
		public static void TextureSubImage2D(uint texture,int level,int xOffset,int yOffset,int width,int height,PixelFormat format,PixelType type,IntPtr pixels)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glTextureSubImage3D","4.5")]
		public static void TextureSubImage3D(uint texture,int level,int xOffset,int yOffset,int zOffset,int width,int height,int depth,PixelFormat format,PixelType type,IntPtr pixels)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glCompressedTextureSubImage1D","4.5")]
		public static void CompressedTextureSubImage1D(uint texture,int level,int xOffset,int width,uint format,int imageSize,IntPtr data)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glCompressedTextureSubImage2D","4.5")]
		public static void CompressedTextureSubImage2D(uint texture,int level,int xOffset,int yOffset,int width,int height,uint format,int imageSize,IntPtr data)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glCompressedTextureSubImage3D","4.5")]
		public static void CompressedTextureSubImage3D(uint texture,int level,int xOffset,int yOffset,int zOffset,int width,int height,int depth,uint format,int imageSize,IntPtr data)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glCopyTextureSubImage1D","4.5")]
		public static void CopyTextureSubImage1D(uint texture,int level,int xOffset,int x,int y,int width)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glCopyTextureSubImage2D","4.5")]
		public static void CopyTextureSubImage2D(uint texture,int level,int xOffset,int yOffset,int x,int y,int width,int height)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glCopyTextureSubImage3D","4.5")]
		public static void CopyTextureSubImage3D(uint texture,int level,int xOffset,int yOffset,int zOffset,int x,int y,int width,int height)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glTextureParameterf","4.5")]
		public static void TextureParameter(uint texture,uint pName,float param)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glTextureParameterfv","4.5")]
		public static void TextureParameter(uint texture,uint pName,ref float param)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glTextureParameteri","4.5")]
		public static void TextureParameter(uint texture,uint pName,int param)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glTextureParameterIiv","4.5")]
		public static void TextureParameterI(uint texture,uint pName,ref int parameters)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glTextureParameterIuiv","4.5")]
		public static void TextureParameterI(uint texture,uint pName,ref uint parameters)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glTextureParameteriv","4.5")]
		public static void TextureParameter(uint texture,uint pName,ref int param)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGenerateTextureMipmap","4.5")]
		public static void GenerateTextureMipmap(uint texture)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glBindTextureUnit","4.5")]
		public static void BindTextureUnit(uint unit,uint texture)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetTextureImage","4.5")]
		public static void GetTextureImage(uint texture,int level,PixelFormat format,PixelType type,int bufSize,IntPtr pixels)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetCompressedTextureImage","4.5")]
		public static void GetCompressedTextureImage(uint texture,int level,int bufSize,IntPtr pixels)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetTextureLevelParameterfv","4.5")]
		public static void GetTextureLevelParameter(TextureTarget texture,int level,uint pName,ref float parameters)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetTextureLevelParameteriv","4.5")]
		public static void GetTextureLevelParameter(TextureTarget texture,int level,uint pName,ref int parameters)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetTextureParameterfv","4.5")]
		public static void GetTextureParameter(uint texture,uint pName,ref float parameters)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetTextureParameterIiv","4.5")]
		public static void GetTextureParameterI(uint texture,uint pName,ref int parameters)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetTextureParameterIuiv","4.5")]
		public static void GetTextureParameterI(uint texture,uint pName,ref uint parameters)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetTextureParameteriv","4.5")]
		public static void GetTextureParameter(uint texture,uint pName,ref int parameters)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glCreateVertexArrays","4.5")]
		public static void CreateVertexArrays(int n,ref uint arrays)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glDisableVertexArrayAttrib","4.5")]
		public static void DisableVertexArrayAttrib(uint vaobj,uint index)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glEnableVertexArrayAttrib","4.5")]
		public static void EnableVertexArrayAttrib(uint vaobj,uint index)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glVertexArrayElementBuffer","4.5")]
		public static void VertexArrayElementBuffer(uint vaobj,uint buffer)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glVertexArrayVertexBuffer","4.5")]
		public static void VertexArrayVertexBuffer(uint vaobj,uint bindingindex,uint buffer,int offset,int stride)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glVertexArrayVertexBuffers","4.5")]
		public static void VertexArrayVertexBuffers(uint vaobj,uint first,int count,ref uint buffers,ref int offsets,ref int strides)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glVertexArrayAttribBinding","4.5")]
		public static void VertexArrayAttribBinding(uint vaobj,uint attribindex,uint bindingindex)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glVertexArrayAttribFormat","4.5")]
		public static void VertexArrayAttribFormat(uint vaobj,uint attribindex,int size,uint type,byte normalized,uint relativeoffset)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glVertexArrayAttribIFormat","4.5")]
		public static void VertexArrayAttribIFormat(uint vaobj,uint attribindex,int size,uint type,uint relativeoffset)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glVertexArrayAttribLFormat","4.5")]
		public static void VertexArrayAttribLFormat(uint vaobj,uint attribindex,int size,uint type,uint relativeoffset)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glVertexArrayBindingDivisor","4.5")]
		public static void VertexArrayBindingDivisor(uint vaobj,uint bindingindex,uint divisor)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetVertexArrayiv","4.5")]
		public static void GetVertexArray(uint vaobj,uint pName,ref int param)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetVertexArrayIndexediv","4.5")]
		public static void GetVertexArrayIndexed(uint vaobj,uint index,uint pName,ref int param)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetVertexArrayIndexed64iv","4.5")]
		public static void GetVertexArrayIndexed(uint vaobj,uint index,uint pName,ref long param)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glCreateSamplers","4.5")]
		public static void CreateSamplers(int n,ref uint samplers)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glCreateProgramPipelines","4.5")]
		public static void CreateProgramPipelines(int n,ref uint pipelines)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glCreateQueries","4.5")]
		public static void CreateQueries(uint target,int n,ref uint ids)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetQueryBufferObjecti64v","4.5")]
		public static void GetQueryBufferObjectLong(uint id,uint buffer,uint pName,int offset)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetQueryBufferObjectiv","4.5")]
		public static void GetQueryBufferObjectInt(uint id,uint buffer,uint pName,int offset)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetQueryBufferObjectui64v","4.5")]
		public static void GetQueryBufferObjectULong(uint id,uint buffer,uint pName,int offset)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetQueryBufferObjectuiv","4.5")]
		public static void GetQueryBufferObjectUInt(uint id,uint buffer,uint pName,int offset)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glMemoryBarrierByRegion","4.5")]
		public static void MemoryBarrierByRegion(uint barriers)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetTextureSubImage","4.5")]
		public static void GetTextureSubImage(uint texture,int level,int xOffset,int yOffset,int zOffset,int width,int height,int depth,PixelFormat format,PixelType type,int bufSize,IntPtr pixels)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetCompressedTextureSubImage","4.5")]
		public static void GetCompressedTextureSubImage(uint texture,int level,int xOffset,int yOffset,int zOffset,int width,int height,int depth,int bufSize,IntPtr pixels)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetGraphicsResetStatus","4.5")]
		public static uint GetGraphicsResetStatus()
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetnCompressedTexImage","4.5")]
		public static void GetnCompressedTexImage(TextureTarget target,int lod,int bufSize,IntPtr pixels)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetnTexImage","4.5")]
		public static void GetnTexImage(TextureTarget target,int level,PixelFormat format,PixelType type,int bufSize,IntPtr pixels)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetnUniformdv","4.5")]
		public static void GetnUniform(uint program,int location,int bufSize,ref double parameters)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetnUniformfv","4.5")]
		public static void GetnUniform(uint program,int location,int bufSize,ref float parameters)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetnUniformiv","4.5")]
		public static void GetnUniform(uint program,int location,int bufSize,ref int parameters)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetnUniformuiv","4.5")]
		public static void GetnUniform(uint program,int location,int bufSize,ref uint parameters)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glReadnPixels","4.5")]
		public static void ReadnPixels(int x,int y,int width,int height,PixelFormat format,PixelType type,int bufSize,IntPtr data)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glTextureBarrier","4.5")]
		public static void TextureBarrier()
			=> throw new NotImplementedException();
	}
}