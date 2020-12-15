using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[MethodImpl(ImplOptions)]
		public unsafe static void ClipControl(uint origin, uint depth)
			=> glClipControl(origin, depth);

		[MethodImpl(ImplOptions)]
		public unsafe static void CreateTransformFeedbacks(int n, ref uint ids)
			=> glCreateTransformFeedbacks(n, ref ids);

		[MethodImpl(ImplOptions)]
		public unsafe static void TransformFeedbackBufferBase(uint xfb, uint index, uint buffer)
			=> glTransformFeedbackBufferBase(xfb, index, buffer);

		[MethodImpl(ImplOptions)]
		public unsafe static void TransformFeedbackBufferRange(uint xfb, uint index, uint buffer, int offset, int size)
			=> glTransformFeedbackBufferRange(xfb, index, buffer, offset, size);

		[MethodImpl(ImplOptions)]
		public unsafe static void GetTransformFeedback(uint xfb, uint pName, ref int param)
			=> glGetTransformFeedbackiv(xfb, pName, ref param);

		[MethodImpl(ImplOptions)]
		public unsafe static void GetTransformFeedback(uint xfb, uint pName, uint index, ref int param)
			=> glGetTransformFeedbacki_v(xfb, pName, index, ref param);

		[MethodImpl(ImplOptions)]
		public unsafe static void GetTransformFeedback(uint xfb, uint pName, uint index, ref long param)
			=> glGetTransformFeedbacki64_v(xfb, pName, index, ref param);

		[MethodImpl(ImplOptions)]
		public unsafe static void CreateBuffers(int n, [Out] uint[] buffers)
			=> glCreateBuffers(n, buffers);

		[MethodImpl(ImplOptions)]
		public unsafe static void NamedBufferStorage(uint buffer, int size, IntPtr data, uint flags)
			=> glNamedBufferStorage(buffer, size, data, flags);

		[MethodImpl(ImplOptions)]
		public unsafe static void NamedBufferData(uint buffer, int size, IntPtr data, BufferUsageHint usage)
			=> glNamedBufferData(buffer, size, data, usage);

		[MethodImpl(ImplOptions)]
		public unsafe static void NamedBufferSubData(uint buffer, int offset, int size, IntPtr data)
			=> glNamedBufferSubData(buffer, offset, size, data);

		[MethodImpl(ImplOptions)]
		public unsafe static void CopyNamedBufferSubData(uint readBuffer, uint writeBuffer, int readOffset, int writeOffset, int size)
			=> glCopyNamedBufferSubData(readBuffer, writeBuffer, readOffset, writeOffset, size);

		[MethodImpl(ImplOptions)]
		public unsafe static void ClearNamedBufferData(uint buffer, PixelInternalFormat internalFormat, PixelFormat format, PixelType type, IntPtr data)
			=> glClearNamedBufferData(buffer, internalFormat, format, type, data);

		[MethodImpl(ImplOptions)]
		public unsafe static void ClearNamedBufferSubData(uint buffer, PixelInternalFormat internalFormat, int offset, int size, PixelFormat format, PixelType type, IntPtr data)
			=> glClearNamedBufferSubData(buffer, internalFormat, offset, size, format, type, data);

		[MethodImpl(ImplOptions)]
		public unsafe static IntPtr MapNamedBuffer(uint buffer, uint access)
			=> glMapNamedBuffer(buffer, access);

		[MethodImpl(ImplOptions)]
		public unsafe static IntPtr MapNamedBufferRange(uint buffer, int offset, int length, uint access)
			=> glMapNamedBufferRange(buffer, offset, length, access);

		[MethodImpl(ImplOptions)]
		public unsafe static byte UnmapNamedBuffer(uint buffer)
			=> glUnmapNamedBuffer(buffer);

		[MethodImpl(ImplOptions)]
		public unsafe static void FlushMappedNamedBufferRange(uint buffer, int offset, int length)
			=> glFlushMappedNamedBufferRange(buffer, offset, length);

		[MethodImpl(ImplOptions)]
		public unsafe static void GetNamedBufferParameter(uint buffer, uint pName, ref int parameters)
			=> glGetNamedBufferParameteriv(buffer, pName, ref parameters);

		[MethodImpl(ImplOptions)]
		public unsafe static void GetNamedBufferParameter(uint buffer, uint pName, ref long parameters)
			=> glGetNamedBufferParameteri64v(buffer, pName, ref parameters);

		[MethodImpl(ImplOptions)]
		public unsafe static void GetNamedBufferPointer(uint buffer, uint pName, ref IntPtr parameters)
			=> glGetNamedBufferPointerv(buffer, pName, ref parameters);

		[MethodImpl(ImplOptions)]
		public unsafe static void GetNamedBufferSubData(uint buffer, int offset, int size, IntPtr data)
			=> glGetNamedBufferSubData(buffer, offset, size, data);

		[MethodImpl(ImplOptions)]
		public unsafe static void CreateFramebuffers(int n, ref uint framebuffers)
			=> glCreateFramebuffers(n, ref framebuffers);

		[MethodImpl(ImplOptions)]
		public unsafe static void NamedFramebufferRenderbuffer(uint framebuffer, uint attachment, RenderbufferTarget renderbuffertarget, uint renderbuffer)
			=> glNamedFramebufferRenderbuffer(framebuffer, attachment, renderbuffertarget, renderbuffer);

		[MethodImpl(ImplOptions)]
		public unsafe static void NamedFramebufferParameter(uint framebuffer, uint pName, int param)
			=> glNamedFramebufferParameteri(framebuffer, pName, param);

		[MethodImpl(ImplOptions)]
		public unsafe static void NamedFramebufferTexture(uint framebuffer, FramebufferAttachment attachment, uint texture, int level)
			=> glNamedFramebufferTexture(framebuffer, attachment, texture, level);

		[MethodImpl(ImplOptions)]
		public unsafe static void NamedFramebufferTextureLayer(uint framebuffer, FramebufferAttachment attachment, uint texture, int level, int layer)
			=> glNamedFramebufferTextureLayer(framebuffer, attachment, texture, level, layer);

		[MethodImpl(ImplOptions)]
		public unsafe static void NamedFramebufferDrawBuffer(uint framebuffer, DrawBufferMode buf)
			=> glNamedFramebufferDrawBuffer(framebuffer, buf);

		[MethodImpl(ImplOptions)]
		public unsafe static void NamedFramebufferDrawBuffers(uint framebuffer, int n, DrawBufferMode[] bufs)
			=> glNamedFramebufferDrawBuffers(framebuffer, n, bufs);

		[MethodImpl(ImplOptions)]
		public unsafe static void NamedFramebufferReadBuffer(uint framebuffer, uint src)
			=> glNamedFramebufferReadBuffer(framebuffer, src);

		[MethodImpl(ImplOptions)]
		public unsafe static void InvalidateNamedFramebufferData(uint framebuffer, int numAttachments, FramebufferAttachment* attachments)
			=> glInvalidateNamedFramebufferData(framebuffer, numAttachments, attachments);

		[MethodImpl(ImplOptions)]
		public unsafe static void InvalidateNamedFramebufferSubData(uint framebuffer, int numAttachments, FramebufferAttachment* attachments, int x, int y, int width, int height)
			=> glInvalidateNamedFramebufferSubData(framebuffer, numAttachments, attachments, x, y, width, height);

		[MethodImpl(ImplOptions)]
		public unsafe static void ClearNamedFramebuffer(uint framebuffer, uint buffer, int drawbuffer, ref int value)
			=> glClearNamedFramebufferiv(framebuffer, buffer, drawbuffer, ref value);

		[MethodImpl(ImplOptions)]
		public unsafe static void ClearNamedFramebuffer(uint framebuffer, uint buffer, int drawbuffer, ref uint value)
			=> glClearNamedFramebufferuiv(framebuffer, buffer, drawbuffer, ref value);

		[MethodImpl(ImplOptions)]
		public unsafe static void ClearNamedFramebuffer(uint framebuffer, uint buffer, int drawbuffer, ref float value)
			=> glClearNamedFramebufferfv(framebuffer, buffer, drawbuffer, ref value);

		[MethodImpl(ImplOptions)]
		public unsafe static void ClearNamedFramebuffer(uint framebuffer, uint buffer, int drawbuffer, float depth, int stencil)
			=> glClearNamedFramebufferfi(framebuffer, buffer, drawbuffer, depth, stencil);

		[MethodImpl(ImplOptions)]
		public unsafe static void BlitNamedFramebuffer(uint readFramebuffer, uint drawFramebuffer, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter)
			=> glBlitNamedFramebuffer(readFramebuffer, drawFramebuffer, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);

		[MethodImpl(ImplOptions)]
		public unsafe static uint CheckNamedFramebufferStatus(uint framebuffer, FramebufferTarget target)
			=> glCheckNamedFramebufferStatus(framebuffer, target);

		[MethodImpl(ImplOptions)]
		public unsafe static void GetNamedFramebufferParameter(uint framebuffer, uint pName, ref int param)
			=> glGetNamedFramebufferParameteriv(framebuffer, pName, ref param);

		[MethodImpl(ImplOptions)]
		public unsafe static void GetNamedFramebufferAttachmentParameter(uint framebuffer, FramebufferAttachment attachment, uint pName, ref int parameters)
			=> glGetNamedFramebufferAttachmentParameteriv(framebuffer, attachment, pName, ref parameters);

		[MethodImpl(ImplOptions)]
		public unsafe static void CreateRenderbuffers(int n, ref uint renderbuffers)
			=> glCreateRenderbuffers(n, ref renderbuffers);

		[MethodImpl(ImplOptions)]
		public unsafe static void NamedRenderbufferStorage(uint renderbuffer, PixelInternalFormat internalFormat, int width, int height)
			=> glNamedRenderbufferStorage(renderbuffer, internalFormat, width, height);

		[MethodImpl(ImplOptions)]
		public unsafe static void NamedRenderbufferStorageMultisample(uint renderbuffer, int samples, PixelInternalFormat internalFormat, int width, int height)
			=> glNamedRenderbufferStorageMultisample(renderbuffer, samples, internalFormat, width, height);

		[MethodImpl(ImplOptions)]
		public unsafe static void GetNamedRenderbufferParameter(uint renderbuffer, uint pName, ref int parameters)
			=> glGetNamedRenderbufferParameteriv(renderbuffer, pName, ref parameters);

		[MethodImpl(ImplOptions)]
		public unsafe static void CreateTextures(TextureTarget target, uint n, IntPtr textures)
			=> glCreateTextures(target, n, textures);

		[MethodImpl(ImplOptions)]
		public unsafe static void TextureBuffer(uint texture, uint internalFormat, uint buffer)
			=> glTextureBuffer(texture, internalFormat, buffer);

		[MethodImpl(ImplOptions)]
		public unsafe static void TextureBufferRange(uint texture, uint internalFormat, uint buffer, IntPtr offset, IntPtr size)
			=> glTextureBufferRange(texture, internalFormat, buffer, offset, size);

		[MethodImpl(ImplOptions)]
		public unsafe static void TextureStorage1D(uint texture, int levels, uint internalFormat, int width)
			=> glTextureStorage1D(texture, levels, internalFormat, width);

		[MethodImpl(ImplOptions)]
		public unsafe static void TextureStorage2D(uint texture, int levels, uint internalFormat, int width, int height)
			=> glTextureStorage2D(texture, levels, internalFormat, width, height);

		[MethodImpl(ImplOptions)]
		public unsafe static void TextureStorage3D(uint texture, int levels, uint internalFormat, int width, int height, int depth)
			=> glTextureStorage3D(texture, levels, internalFormat, width, height, depth);

		[MethodImpl(ImplOptions)]
		public unsafe static void TextureStorage2DMultisample(uint texture, int samples, uint internalFormat, int width, int height, byte fixedsamplelocations)
			=> glTextureStorage2DMultisample(texture, samples, internalFormat, width, height, fixedsamplelocations);

		[MethodImpl(ImplOptions)]
		public unsafe static void TextureStorage3DMultisample(uint texture, int samples, uint internalFormat, int width, int height, int depth, byte fixedsamplelocations)
			=> glTextureStorage3DMultisample(texture, samples, internalFormat, width, height, depth, fixedsamplelocations);

		[MethodImpl(ImplOptions)]
		public unsafe static void TextureSubImage1D(uint texture, int level, int xOffset, int width, PixelFormat format, PixelType type, IntPtr pixels)
			=> glTextureSubImage1D(texture, level, xOffset, width, format, type, pixels);

		[MethodImpl(ImplOptions)]
		public unsafe static void TextureSubImage2D(uint texture, int level, int xOffset, int yOffset, int width, int height, PixelFormat format, PixelType type, IntPtr pixels)
			=> glTextureSubImage2D(texture, level, xOffset, yOffset, width, height, format, type, pixels);

		[MethodImpl(ImplOptions)]
		public unsafe static void TextureSubImage3D(uint texture, int level, int xOffset, int yOffset, int zOffset, int width, int height, int depth, PixelFormat format, PixelType type, IntPtr pixels)
			=> glTextureSubImage3D(texture, level, xOffset, yOffset, zOffset, width, height, depth, format, type, pixels);

		[MethodImpl(ImplOptions)]
		public unsafe static void CompressedTextureSubImage1D(uint texture, int level, int xOffset, int width, uint format, int imageSize, IntPtr data)
			=> glCompressedTextureSubImage1D(texture, level, xOffset, width, format, imageSize, data);

		[MethodImpl(ImplOptions)]
		public unsafe static void CompressedTextureSubImage2D(uint texture, int level, int xOffset, int yOffset, int width, int height, uint format, int imageSize, IntPtr data)
			=> glCompressedTextureSubImage2D(texture, level, xOffset, yOffset, width, height, format, imageSize, data);

		[MethodImpl(ImplOptions)]
		public unsafe static void CompressedTextureSubImage3D(uint texture, int level, int xOffset, int yOffset, int zOffset, int width, int height, int depth, uint format, int imageSize, IntPtr data)
			=> glCompressedTextureSubImage3D(texture, level, xOffset, yOffset, zOffset, width, height, depth, format, imageSize, data);

		[MethodImpl(ImplOptions)]
		public unsafe static void CopyTextureSubImage1D(uint texture, int level, int xOffset, int x, int y, int width)
			=> glCopyTextureSubImage1D(texture, level, xOffset, x, y, width);

		[MethodImpl(ImplOptions)]
		public unsafe static void CopyTextureSubImage2D(uint texture, int level, int xOffset, int yOffset, int x, int y, int width, int height)
			=> glCopyTextureSubImage2D(texture, level, xOffset, yOffset, x, y, width, height);

		[MethodImpl(ImplOptions)]
		public unsafe static void CopyTextureSubImage3D(uint texture, int level, int xOffset, int yOffset, int zOffset, int x, int y, int width, int height)
			=> glCopyTextureSubImage3D(texture, level, xOffset, yOffset, zOffset, x, y, width, height);

		[MethodImpl(ImplOptions)]
		public unsafe static void TextureParameter(uint texture, uint pName, float param)
			=> glTextureParameterf(texture, pName, param);

		[MethodImpl(ImplOptions)]
		public unsafe static void TextureParameter(uint texture, uint pName, ref float param)
			=> glTextureParameterfv(texture, pName, ref param);

		[MethodImpl(ImplOptions)]
		public unsafe static void TextureParameter(uint texture, uint pName, int param)
			=> glTextureParameteri(texture, pName, param);

		[MethodImpl(ImplOptions)]
		public unsafe static void TextureParameterI(uint texture, uint pName, ref int parameters)
			=> glTextureParameterIiv(texture, pName, ref parameters);

		[MethodImpl(ImplOptions)]
		public unsafe static void TextureParameterI(uint texture, uint pName, ref uint parameters)
			=> glTextureParameterIuiv(texture, pName, ref parameters);

		[MethodImpl(ImplOptions)]
		public unsafe static void TextureParameter(uint texture, uint pName, ref int param)
			=> glTextureParameteriv(texture, pName, ref param);

		[MethodImpl(ImplOptions)]
		public unsafe static void GenerateTextureMipmap(uint texture)
			=> glGenerateTextureMipmap(texture);

		[MethodImpl(ImplOptions)]
		public unsafe static void BindTextureUnit(uint unit, uint texture)
			=> glBindTextureUnit(unit, texture);

		[MethodImpl(ImplOptions)]
		public unsafe static void GetTextureImage(uint texture, int level, PixelFormat format, PixelType type, int bufSize, IntPtr pixels)
			=> glGetTextureImage(texture, level, format, type, bufSize, pixels);

		[MethodImpl(ImplOptions)]
		public unsafe static void GetCompressedTextureImage(uint texture, int level, int bufSize, IntPtr pixels)
			=> glGetCompressedTextureImage(texture, level, bufSize, pixels);

		[MethodImpl(ImplOptions)]
		public unsafe static void GetTextureLevelParameter(TextureTarget texture, int level, uint pName, ref float parameters)
			=> glGetTextureLevelParameterfv(texture, level, pName, ref parameters);

		[MethodImpl(ImplOptions)]
		public unsafe static void GetTextureLevelParameter(TextureTarget texture, int level, uint pName, ref int parameters)
			=> glGetTextureLevelParameteriv(texture, level, pName, ref parameters);

		[MethodImpl(ImplOptions)]
		public unsafe static void GetTextureParameter(uint texture, uint pName, ref float parameters)
			=> glGetTextureParameterfv(texture, pName, ref parameters);

		[MethodImpl(ImplOptions)]
		public unsafe static void GetTextureParameterI(uint texture, uint pName, ref int parameters)
			=> glGetTextureParameterIiv(texture, pName, ref parameters);

		[MethodImpl(ImplOptions)]
		public unsafe static void GetTextureParameterI(uint texture, uint pName, ref uint parameters)
			=> glGetTextureParameterIuiv(texture, pName, ref parameters);

		[MethodImpl(ImplOptions)]
		public unsafe static void GetTextureParameter(uint texture, uint pName, ref int parameters)
			=> glGetTextureParameteriv(texture, pName, ref parameters);

		[MethodImpl(ImplOptions)]
		public unsafe static void CreateVertexArrays(int n, ref uint arrays)
			=> glCreateVertexArrays(n, ref arrays);

		[MethodImpl(ImplOptions)]
		public unsafe static void DisableVertexArrayAttrib(uint vaobj, uint index)
			=> glDisableVertexArrayAttrib(vaobj, index);

		[MethodImpl(ImplOptions)]
		public unsafe static void EnableVertexArrayAttrib(uint vaobj, uint index)
			=> glEnableVertexArrayAttrib(vaobj, index);

		[MethodImpl(ImplOptions)]
		public unsafe static void VertexArrayElementBuffer(uint vaobj, uint buffer)
			=> glVertexArrayElementBuffer(vaobj, buffer);

		[MethodImpl(ImplOptions)]
		public unsafe static void VertexArrayVertexBuffer(uint vaobj, uint bindingindex, uint buffer, int offset, int stride)
			=> glVertexArrayVertexBuffer(vaobj, bindingindex, buffer, offset, stride);

		[MethodImpl(ImplOptions)]
		public unsafe static void VertexArrayVertexBuffers(uint vaobj, uint first, int count, ref uint buffers, ref int offsets, ref int strides)
			=> glVertexArrayVertexBuffers(vaobj, first, count, ref buffers, ref offsets, ref strides);

		[MethodImpl(ImplOptions)]
		public unsafe static void VertexArrayAttribBinding(uint vaobj, uint attribindex, uint bindingindex)
			=> glVertexArrayAttribBinding(vaobj, attribindex, bindingindex);

		[MethodImpl(ImplOptions)]
		public unsafe static void VertexArrayAttribFormat(uint vaobj, uint attribindex, int size, uint type, byte normalized, uint relativeoffset)
			=> glVertexArrayAttribFormat(vaobj, attribindex, size, type, normalized, relativeoffset);

		[MethodImpl(ImplOptions)]
		public unsafe static void VertexArrayAttribIFormat(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset)
			=> glVertexArrayAttribIFormat(vaobj, attribindex, size, type, relativeoffset);

		[MethodImpl(ImplOptions)]
		public unsafe static void VertexArrayAttribLFormat(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset)
			=> glVertexArrayAttribLFormat(vaobj, attribindex, size, type, relativeoffset);

		[MethodImpl(ImplOptions)]
		public unsafe static void VertexArrayBindingDivisor(uint vaobj, uint bindingindex, uint divisor)
			=> glVertexArrayBindingDivisor(vaobj, bindingindex, divisor);

		[MethodImpl(ImplOptions)]
		public unsafe static void GetVertexArray(uint vaobj, uint pName, ref int param)
			=> glGetVertexArrayiv(vaobj, pName, ref param);

		[MethodImpl(ImplOptions)]
		public unsafe static void GetVertexArrayIndexed(uint vaobj, uint index, uint pName, ref int param)
			=> glGetVertexArrayIndexediv(vaobj, index, pName, ref param);

		[MethodImpl(ImplOptions)]
		public unsafe static void GetVertexArrayIndexed(uint vaobj, uint index, uint pName, ref long param)
			=> glGetVertexArrayIndexed64iv(vaobj, index, pName, ref param);

		[MethodImpl(ImplOptions)]
		public unsafe static void CreateSamplers(int n, ref uint samplers)
			=> glCreateSamplers(n, ref samplers);

		[MethodImpl(ImplOptions)]
		public unsafe static void CreateProgramPipelines(int n, ref uint pipelines)
			=> glCreateProgramPipelines(n, ref pipelines);

		[MethodImpl(ImplOptions)]
		public unsafe static void CreateQueries(uint target, int n, ref uint ids)
			=> glCreateQueries(target, n, ref ids);

		[MethodImpl(ImplOptions)]
		public unsafe static void GetQueryBufferObjectLong(uint id, uint buffer, uint pName, int offset)
			=> glGetQueryBufferObjecti64v(id, buffer, pName, offset);

		[MethodImpl(ImplOptions)]
		public unsafe static void GetQueryBufferObjectInt(uint id, uint buffer, uint pName, int offset)
			=> glGetQueryBufferObjectiv(id, buffer, pName, offset);

		[MethodImpl(ImplOptions)]
		public unsafe static void GetQueryBufferObjectULong(uint id, uint buffer, uint pName, int offset)
			=> glGetQueryBufferObjectui64v(id, buffer, pName, offset);

		[MethodImpl(ImplOptions)]
		public unsafe static void GetQueryBufferObjectUInt(uint id, uint buffer, uint pName, int offset)
			=> glGetQueryBufferObjectuiv(id, buffer, pName, offset);

		[MethodImpl(ImplOptions)]
		public unsafe static void MemoryBarrierByRegion(uint barriers)
			=> glMemoryBarrierByRegion(barriers);

		[MethodImpl(ImplOptions)]
		public unsafe static void GetTextureSubImage(uint texture, int level, int xOffset, int yOffset, int zOffset, int width, int height, int depth, PixelFormat format, PixelType type, int bufSize, IntPtr pixels)
			=> glGetTextureSubImage(texture, level, xOffset, yOffset, zOffset, width, height, depth, format, type, bufSize, pixels);

		[MethodImpl(ImplOptions)]
		public unsafe static void GetCompressedTextureSubImage(uint texture, int level, int xOffset, int yOffset, int zOffset, int width, int height, int depth, int bufSize, IntPtr pixels)
			=> glGetCompressedTextureSubImage(texture, level, xOffset, yOffset, zOffset, width, height, depth, bufSize, pixels);

		[MethodImpl(ImplOptions)]
		public unsafe static uint GetGraphicsResetStatus()
			=> glGetGraphicsResetStatus();

		[MethodImpl(ImplOptions)]
		public unsafe static void GetnCompressedTexImage(TextureTarget target, int lod, int bufSize, IntPtr pixels)
			=> glGetnCompressedTexImage(target, lod, bufSize, pixels);

		[MethodImpl(ImplOptions)]
		public unsafe static void GetnTexImage(TextureTarget target, int level, PixelFormat format, PixelType type, int bufSize, IntPtr pixels)
			=> glGetnTexImage(target, level, format, type, bufSize, pixels);

		[MethodImpl(ImplOptions)]
		public unsafe static void GetnUniform(uint program, int location, int bufSize, ref double parameters)
			=> glGetnUniformdv(program, location, bufSize, ref parameters);

		[MethodImpl(ImplOptions)]
		public unsafe static void GetnUniform(uint program, int location, int bufSize, ref float parameters)
			=> glGetnUniformfv(program, location, bufSize, ref parameters);

		[MethodImpl(ImplOptions)]
		public unsafe static void GetnUniform(uint program, int location, int bufSize, ref int parameters)
			=> glGetnUniformiv(program, location, bufSize, ref parameters);

		[MethodImpl(ImplOptions)]
		public unsafe static void GetnUniform(uint program, int location, int bufSize, ref uint parameters)
			=> glGetnUniformuiv(program, location, bufSize, ref parameters);

		[MethodImpl(ImplOptions)]
		public unsafe static void ReadnPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, IntPtr data)
			=> glReadnPixels(x, y, width, height, format, type, bufSize, data);

		[MethodImpl(ImplOptions)]
		public unsafe static void TextureBarrier()
			=> glTextureBarrier();
	}
}
