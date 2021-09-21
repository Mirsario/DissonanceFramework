using System;

namespace Dissonance.Framework.Graphics.OpenGL
{
	unsafe partial class GL
	{
		[MethodImport("glClipControl", "4.5")]
		private static delegate*<ClipControlOrigin, ClipControlDepth, void> glClipControl;
		
		public static void ClipControl(ClipControlOrigin origin, ClipControlDepth depth)
		{
			glClipControl(origin, depth);
		}
		
		[MethodImport("glCreateTransformFeedbacks", "4.5")]
		private static delegate*<int, uint*, void> glCreateTransformFeedbacks;
		
		public static void CreateTransformFeedbacks(int n, uint* ids)
		{
			glCreateTransformFeedbacks(n, ids);
		}
		
		[MethodImport("glTransformFeedbackBufferBase", "4.5")]
		private static delegate*<uint, uint, uint, void> glTransformFeedbackBufferBase;
		
		public static void TransformFeedbackBufferBase(uint xfb, uint index, uint buffer)
		{
			glTransformFeedbackBufferBase(xfb, index, buffer);
		}
		
		[MethodImport("glTransformFeedbackBufferRange", "4.5")]
		private static delegate*<uint, uint, uint, IntPtr, IntPtr, void> glTransformFeedbackBufferRange;
		
		public static void TransformFeedbackBufferRange(uint xfb, uint index, uint buffer, IntPtr offset, IntPtr size)
		{
			glTransformFeedbackBufferRange(xfb, index, buffer, offset, size);
		}
		
		[MethodImport("glGetTransformFeedbackiv", "4.5")]
		private static delegate*<uint, TransformFeedbackPName, int*, void> glGetTransformFeedbackiv;
		
		public static void GetTransformFeedbackiv(uint xfb, TransformFeedbackPName pname, int* param)
		{
			glGetTransformFeedbackiv(xfb, pname, param);
		}
		
		[MethodImport("glGetTransformFeedbacki_v", "4.5")]
		private static delegate*<uint, TransformFeedbackPName, uint, int*, void> glGetTransformFeedbacki_v;
		
		public static void GetTransformFeedbacki_v(uint xfb, TransformFeedbackPName pname, uint index, int* param)
		{
			glGetTransformFeedbacki_v(xfb, pname, index, param);
		}
		
		[MethodImport("glGetTransformFeedbacki64_v", "4.5")]
		private static delegate*<uint, TransformFeedbackPName, uint, long*, void> glGetTransformFeedbacki64_v;
		
		public static void GetTransformFeedbacki64_v(uint xfb, TransformFeedbackPName pname, uint index, long* param)
		{
			glGetTransformFeedbacki64_v(xfb, pname, index, param);
		}
		
		[MethodImport("glCreateBuffers", "4.5")]
		private static delegate*<int, uint*, void> glCreateBuffers;
		
		public static void CreateBuffers(int n, uint* buffers)
		{
			glCreateBuffers(n, buffers);
		}
		
		[MethodImport("glNamedBufferStorage", "4.5")]
		private static delegate*<uint, IntPtr, void*, BufferStorageMask, void> glNamedBufferStorage;
		
		public static void NamedBufferStorage(uint buffer, IntPtr size, void* data, BufferStorageMask flags)
		{
			glNamedBufferStorage(buffer, size, data, flags);
		}
		
		[MethodImport("glNamedBufferData", "4.5")]
		private static delegate*<uint, IntPtr, void*, VertexBufferObjectUsage, void> glNamedBufferData;
		
		public static void NamedBufferData(uint buffer, IntPtr size, void* data, VertexBufferObjectUsage usage)
		{
			glNamedBufferData(buffer, size, data, usage);
		}
		
		[MethodImport("glNamedBufferSubData", "4.5")]
		private static delegate*<uint, IntPtr, IntPtr, void*, void> glNamedBufferSubData;
		
		public static void NamedBufferSubData(uint buffer, IntPtr offset, IntPtr size, void* data)
		{
			glNamedBufferSubData(buffer, offset, size, data);
		}
		
		[MethodImport("glCopyNamedBufferSubData", "4.5")]
		private static delegate*<uint, uint, IntPtr, IntPtr, IntPtr, void> glCopyNamedBufferSubData;
		
		public static void CopyNamedBufferSubData(uint readBuffer, uint writeBuffer, IntPtr readOffset, IntPtr writeOffset, IntPtr size)
		{
			glCopyNamedBufferSubData(readBuffer, writeBuffer, readOffset, writeOffset, size);
		}
		
		[MethodImport("glClearNamedBufferData", "4.5")]
		private static delegate*<uint, SizedInternalFormat, PixelFormat, PixelType, void*, void> glClearNamedBufferData;
		
		public static void ClearNamedBufferData(uint buffer, SizedInternalFormat internalformat, PixelFormat format, PixelType type, void* data)
		{
			glClearNamedBufferData(buffer, internalformat, format, type, data);
		}
		
		[MethodImport("glClearNamedBufferSubData", "4.5")]
		private static delegate*<uint, SizedInternalFormat, IntPtr, IntPtr, PixelFormat, PixelType, void*, void> glClearNamedBufferSubData;
		
		public static void ClearNamedBufferSubData(uint buffer, SizedInternalFormat internalformat, IntPtr offset, IntPtr size, PixelFormat format, PixelType type, void* data)
		{
			glClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, data);
		}
		
		[MethodImport("glMapNamedBuffer", "4.5")]
		private static delegate*<uint, BufferAccessARB, void> glMapNamedBuffer;
		
		public static void MapNamedBuffer(uint buffer, BufferAccessARB access)
		{
			glMapNamedBuffer(buffer, access);
		}
		
		[MethodImport("glMapNamedBufferRange", "4.5")]
		private static delegate*<uint, IntPtr, IntPtr, MapBufferAccessMask, void> glMapNamedBufferRange;
		
		public static void MapNamedBufferRange(uint buffer, IntPtr offset, IntPtr length, MapBufferAccessMask access)
		{
			glMapNamedBufferRange(buffer, offset, length, access);
		}
		
		[MethodImport("glUnmapNamedBuffer", "4.5")]
		private static delegate*<uint, bool> glUnmapNamedBuffer;
		
		public static bool UnmapNamedBuffer(uint buffer)
		{
			return glUnmapNamedBuffer(buffer);
		}
		
		[MethodImport("glFlushMappedNamedBufferRange", "4.5")]
		private static delegate*<uint, IntPtr, IntPtr, void> glFlushMappedNamedBufferRange;
		
		public static void FlushMappedNamedBufferRange(uint buffer, IntPtr offset, IntPtr length)
		{
			glFlushMappedNamedBufferRange(buffer, offset, length);
		}
		
		[MethodImport("glGetNamedBufferParameteriv", "4.5")]
		private static delegate*<uint, BufferPNameARB, int*, void> glGetNamedBufferParameteriv;
		
		public static void GetNamedBufferParameteriv(uint buffer, BufferPNameARB pname, int* @params)
		{
			glGetNamedBufferParameteriv(buffer, pname, @params);
		}
		
		[MethodImport("glGetNamedBufferParameteri64v", "4.5")]
		private static delegate*<uint, BufferPNameARB, long*, void> glGetNamedBufferParameteri64v;
		
		public static void GetNamedBufferParameteri64v(uint buffer, BufferPNameARB pname, long* @params)
		{
			glGetNamedBufferParameteri64v(buffer, pname, @params);
		}
		
		[MethodImport("glGetNamedBufferPointerv", "4.5")]
		private static delegate*<uint, BufferPointerNameARB, void**, void> glGetNamedBufferPointerv;
		
		public static void GetNamedBufferPointerv(uint buffer, BufferPointerNameARB pname, void** @params)
		{
			glGetNamedBufferPointerv(buffer, pname, @params);
		}
		
		[MethodImport("glGetNamedBufferSubData", "4.5")]
		private static delegate*<uint, IntPtr, IntPtr, void*, void> glGetNamedBufferSubData;
		
		public static void GetNamedBufferSubData(uint buffer, IntPtr offset, IntPtr size, void* data)
		{
			glGetNamedBufferSubData(buffer, offset, size, data);
		}
		
		[MethodImport("glCreateFramebuffers", "4.5")]
		private static delegate*<int, uint*, void> glCreateFramebuffers;
		
		public static void CreateFramebuffers(int n, uint* framebuffers)
		{
			glCreateFramebuffers(n, framebuffers);
		}
		
		[MethodImport("glNamedFramebufferRenderbuffer", "4.5")]
		private static delegate*<uint, FramebufferAttachment, RenderbufferTarget, uint, void> glNamedFramebufferRenderbuffer;
		
		public static void NamedFramebufferRenderbuffer(uint framebuffer, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, uint renderbuffer)
		{
			glNamedFramebufferRenderbuffer(framebuffer, attachment, renderbuffertarget, renderbuffer);
		}
		
		[MethodImport("glNamedFramebufferParameteri", "4.5")]
		private static delegate*<uint, FramebufferParameterName, int, void> glNamedFramebufferParameteri;
		
		public static void NamedFramebufferParameteri(uint framebuffer, FramebufferParameterName pname, int param)
		{
			glNamedFramebufferParameteri(framebuffer, pname, param);
		}
		
		[MethodImport("glNamedFramebufferTexture", "4.5")]
		private static delegate*<uint, FramebufferAttachment, uint, int, void> glNamedFramebufferTexture;
		
		public static void NamedFramebufferTexture(uint framebuffer, FramebufferAttachment attachment, uint texture, int level)
		{
			glNamedFramebufferTexture(framebuffer, attachment, texture, level);
		}
		
		[MethodImport("glNamedFramebufferTextureLayer", "4.5")]
		private static delegate*<uint, FramebufferAttachment, uint, int, int, void> glNamedFramebufferTextureLayer;
		
		public static void NamedFramebufferTextureLayer(uint framebuffer, FramebufferAttachment attachment, uint texture, int level, int layer)
		{
			glNamedFramebufferTextureLayer(framebuffer, attachment, texture, level, layer);
		}
		
		[MethodImport("glNamedFramebufferDrawBuffer", "4.5")]
		private static delegate*<uint, ColorBuffer, void> glNamedFramebufferDrawBuffer;
		
		public static void NamedFramebufferDrawBuffer(uint framebuffer, ColorBuffer buf)
		{
			glNamedFramebufferDrawBuffer(framebuffer, buf);
		}
		
		[MethodImport("glNamedFramebufferDrawBuffers", "4.5")]
		private static delegate*<uint, int, ColorBuffer, void> glNamedFramebufferDrawBuffers;
		
		public static void NamedFramebufferDrawBuffers(uint framebuffer, int n, ColorBuffer bufs)
		{
			glNamedFramebufferDrawBuffers(framebuffer, n, bufs);
		}
		
		[MethodImport("glNamedFramebufferReadBuffer", "4.5")]
		private static delegate*<uint, ColorBuffer, void> glNamedFramebufferReadBuffer;
		
		public static void NamedFramebufferReadBuffer(uint framebuffer, ColorBuffer src)
		{
			glNamedFramebufferReadBuffer(framebuffer, src);
		}
		
		[MethodImport("glInvalidateNamedFramebufferData", "4.5")]
		private static delegate*<uint, int, FramebufferAttachment, void> glInvalidateNamedFramebufferData;
		
		public static void InvalidateNamedFramebufferData(uint framebuffer, int numAttachments, FramebufferAttachment attachments)
		{
			glInvalidateNamedFramebufferData(framebuffer, numAttachments, attachments);
		}
		
		[MethodImport("glInvalidateNamedFramebufferSubData", "4.5")]
		private static delegate*<uint, int, FramebufferAttachment, int, int, int, int, void> glInvalidateNamedFramebufferSubData;
		
		public static void InvalidateNamedFramebufferSubData(uint framebuffer, int numAttachments, FramebufferAttachment attachments, int x, int y, int width, int height)
		{
			glInvalidateNamedFramebufferSubData(framebuffer, numAttachments, attachments, x, y, width, height);
		}
		
		[MethodImport("glClearNamedFramebufferiv", "4.5")]
		private static delegate*<uint, Buffer, int, int*, void> glClearNamedFramebufferiv;
		
		public static void ClearNamedFramebufferiv(uint framebuffer, Buffer buffer, int drawbuffer, int* value)
		{
			glClearNamedFramebufferiv(framebuffer, buffer, drawbuffer, value);
		}
		
		[MethodImport("glClearNamedFramebufferuiv", "4.5")]
		private static delegate*<uint, Buffer, int, uint*, void> glClearNamedFramebufferuiv;
		
		public static void ClearNamedFramebufferuiv(uint framebuffer, Buffer buffer, int drawbuffer, uint* value)
		{
			glClearNamedFramebufferuiv(framebuffer, buffer, drawbuffer, value);
		}
		
		[MethodImport("glClearNamedFramebufferfv", "4.5")]
		private static delegate*<uint, Buffer, int, float*, void> glClearNamedFramebufferfv;
		
		public static void ClearNamedFramebufferfv(uint framebuffer, Buffer buffer, int drawbuffer, float* value)
		{
			glClearNamedFramebufferfv(framebuffer, buffer, drawbuffer, value);
		}
		
		[MethodImport("glClearNamedFramebufferfi", "4.5")]
		private static delegate*<uint, Buffer, int, float, int, void> glClearNamedFramebufferfi;
		
		public static void ClearNamedFramebufferfi(uint framebuffer, Buffer buffer, int drawbuffer, float depth, int stencil)
		{
			glClearNamedFramebufferfi(framebuffer, buffer, drawbuffer, depth, stencil);
		}
		
		[MethodImport("glBlitNamedFramebuffer", "4.5")]
		private static delegate*<uint, uint, int, int, int, int, int, int, int, int, ClearBufferMask, BlitFramebufferFilter, void> glBlitNamedFramebuffer;
		
		public static void BlitNamedFramebuffer(uint readFramebuffer, uint drawFramebuffer, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, BlitFramebufferFilter filter)
		{
			glBlitNamedFramebuffer(readFramebuffer, drawFramebuffer, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
		}
		
		[MethodImport("glCheckNamedFramebufferStatus", "4.5")]
		private static delegate*<uint, FramebufferTarget, FramebufferStatus> glCheckNamedFramebufferStatus;
		
		public static FramebufferStatus CheckNamedFramebufferStatus(uint framebuffer, FramebufferTarget target)
		{
			return glCheckNamedFramebufferStatus(framebuffer, target);
		}
		
		[MethodImport("glGetNamedFramebufferParameteriv", "4.5")]
		private static delegate*<uint, GetFramebufferParameter, int*, void> glGetNamedFramebufferParameteriv;
		
		public static void GetNamedFramebufferParameteriv(uint framebuffer, GetFramebufferParameter pname, int* param)
		{
			glGetNamedFramebufferParameteriv(framebuffer, pname, param);
		}
		
		[MethodImport("glGetNamedFramebufferAttachmentParameteriv", "4.5")]
		private static delegate*<uint, FramebufferAttachment, FramebufferAttachmentParameterName, int*, void> glGetNamedFramebufferAttachmentParameteriv;
		
		public static void GetNamedFramebufferAttachmentParameteriv(uint framebuffer, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, int* @params)
		{
			glGetNamedFramebufferAttachmentParameteriv(framebuffer, attachment, pname, @params);
		}
		
		[MethodImport("glCreateRenderbuffers", "4.5")]
		private static delegate*<int, uint*, void> glCreateRenderbuffers;
		
		public static void CreateRenderbuffers(int n, uint* renderbuffers)
		{
			glCreateRenderbuffers(n, renderbuffers);
		}
		
		[MethodImport("glNamedRenderbufferStorage", "4.5")]
		private static delegate*<uint, InternalFormat, int, int, void> glNamedRenderbufferStorage;
		
		public static void NamedRenderbufferStorage(uint renderbuffer, InternalFormat internalformat, int width, int height)
		{
			glNamedRenderbufferStorage(renderbuffer, internalformat, width, height);
		}
		
		[MethodImport("glNamedRenderbufferStorageMultisample", "4.5")]
		private static delegate*<uint, int, InternalFormat, int, int, void> glNamedRenderbufferStorageMultisample;
		
		public static void NamedRenderbufferStorageMultisample(uint renderbuffer, int samples, InternalFormat internalformat, int width, int height)
		{
			glNamedRenderbufferStorageMultisample(renderbuffer, samples, internalformat, width, height);
		}
		
		[MethodImport("glGetNamedRenderbufferParameteriv", "4.5")]
		private static delegate*<uint, RenderbufferParameterName, int*, void> glGetNamedRenderbufferParameteriv;
		
		public static void GetNamedRenderbufferParameteriv(uint renderbuffer, RenderbufferParameterName pname, int* @params)
		{
			glGetNamedRenderbufferParameteriv(renderbuffer, pname, @params);
		}
		
		[MethodImport("glCreateTextures", "4.5")]
		private static delegate*<TextureTarget, int, uint*, void> glCreateTextures;
		
		public static void CreateTextures(TextureTarget target, int n, uint* textures)
		{
			glCreateTextures(target, n, textures);
		}
		
		[MethodImport("glTextureBuffer", "4.5")]
		private static delegate*<uint, SizedInternalFormat, uint, void> glTextureBuffer;
		
		public static void TextureBuffer(uint texture, SizedInternalFormat internalformat, uint buffer)
		{
			glTextureBuffer(texture, internalformat, buffer);
		}
		
		[MethodImport("glTextureBufferRange", "4.5")]
		private static delegate*<uint, SizedInternalFormat, uint, IntPtr, IntPtr, void> glTextureBufferRange;
		
		public static void TextureBufferRange(uint texture, SizedInternalFormat internalformat, uint buffer, IntPtr offset, IntPtr size)
		{
			glTextureBufferRange(texture, internalformat, buffer, offset, size);
		}
		
		[MethodImport("glTextureStorage1D", "4.5")]
		private static delegate*<uint, int, SizedInternalFormat, int, void> glTextureStorage1D;
		
		public static void TextureStorage1D(uint texture, int levels, SizedInternalFormat internalformat, int width)
		{
			glTextureStorage1D(texture, levels, internalformat, width);
		}
		
		[MethodImport("glTextureStorage2D", "4.5")]
		private static delegate*<uint, int, SizedInternalFormat, int, int, void> glTextureStorage2D;
		
		public static void TextureStorage2D(uint texture, int levels, SizedInternalFormat internalformat, int width, int height)
		{
			glTextureStorage2D(texture, levels, internalformat, width, height);
		}
		
		[MethodImport("glTextureStorage3D", "4.5")]
		private static delegate*<uint, int, SizedInternalFormat, int, int, int, void> glTextureStorage3D;
		
		public static void TextureStorage3D(uint texture, int levels, SizedInternalFormat internalformat, int width, int height, int depth)
		{
			glTextureStorage3D(texture, levels, internalformat, width, height, depth);
		}
		
		[MethodImport("glTextureStorage2DMultisample", "4.5")]
		private static delegate*<uint, int, SizedInternalFormat, int, int, bool, void> glTextureStorage2DMultisample;
		
		public static void TextureStorage2DMultisample(uint texture, int samples, SizedInternalFormat internalformat, int width, int height, bool fixedsamplelocations)
		{
			glTextureStorage2DMultisample(texture, samples, internalformat, width, height, fixedsamplelocations);
		}
		
		[MethodImport("glTextureStorage3DMultisample", "4.5")]
		private static delegate*<uint, int, SizedInternalFormat, int, int, int, bool, void> glTextureStorage3DMultisample;
		
		public static void TextureStorage3DMultisample(uint texture, int samples, SizedInternalFormat internalformat, int width, int height, int depth, bool fixedsamplelocations)
		{
			glTextureStorage3DMultisample(texture, samples, internalformat, width, height, depth, fixedsamplelocations);
		}
		
		[MethodImport("glTextureSubImage1D", "4.5")]
		private static delegate*<uint, int, int, int, PixelFormat, PixelType, void*, void> glTextureSubImage1D;
		
		public static void TextureSubImage1D(uint texture, int level, int xoffset, int width, PixelFormat format, PixelType type, void* pixels)
		{
			glTextureSubImage1D(texture, level, xoffset, width, format, type, pixels);
		}
		
		[MethodImport("glTextureSubImage2D", "4.5")]
		private static delegate*<uint, int, int, int, int, int, PixelFormat, PixelType, void*, void> glTextureSubImage2D;
		
		public static void TextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, void* pixels)
		{
			glTextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, type, pixels);
		}
		
		[MethodImport("glTextureSubImage3D", "4.5")]
		private static delegate*<uint, int, int, int, int, int, int, int, PixelFormat, PixelType, void*, void> glTextureSubImage3D;
		
		public static void TextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, void* pixels)
		{
			glTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
		}
		
		[MethodImport("glCompressedTextureSubImage1D", "4.5")]
		private static delegate*<uint, int, int, int, InternalFormat, int, void*, void> glCompressedTextureSubImage1D;
		
		public static void CompressedTextureSubImage1D(uint texture, int level, int xoffset, int width, InternalFormat format, int imageSize, void* data)
		{
			glCompressedTextureSubImage1D(texture, level, xoffset, width, format, imageSize, data);
		}
		
		[MethodImport("glCompressedTextureSubImage2D", "4.5")]
		private static delegate*<uint, int, int, int, int, int, InternalFormat, int, void*, void> glCompressedTextureSubImage2D;
		
		public static void CompressedTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, InternalFormat format, int imageSize, void* data)
		{
			glCompressedTextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, imageSize, data);
		}
		
		[MethodImport("glCompressedTextureSubImage3D", "4.5")]
		private static delegate*<uint, int, int, int, int, int, int, int, InternalFormat, int, void*, void> glCompressedTextureSubImage3D;
		
		public static void CompressedTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, InternalFormat format, int imageSize, void* data)
		{
			glCompressedTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
		}
		
		[MethodImport("glCopyTextureSubImage1D", "4.5")]
		private static delegate*<uint, int, int, int, int, int, void> glCopyTextureSubImage1D;
		
		public static void CopyTextureSubImage1D(uint texture, int level, int xoffset, int x, int y, int width)
		{
			glCopyTextureSubImage1D(texture, level, xoffset, x, y, width);
		}
		
		[MethodImport("glCopyTextureSubImage2D", "4.5")]
		private static delegate*<uint, int, int, int, int, int, int, int, void> glCopyTextureSubImage2D;
		
		public static void CopyTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int x, int y, int width, int height)
		{
			glCopyTextureSubImage2D(texture, level, xoffset, yoffset, x, y, width, height);
		}
		
		[MethodImport("glCopyTextureSubImage3D", "4.5")]
		private static delegate*<uint, int, int, int, int, int, int, int, int, void> glCopyTextureSubImage3D;
		
		public static void CopyTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height)
		{
			glCopyTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, x, y, width, height);
		}
		
		[MethodImport("glTextureParameterf", "4.5")]
		private static delegate*<uint, TextureParameterName, float, void> glTextureParameterf;
		
		public static void TextureParameterf(uint texture, TextureParameterName pname, float param)
		{
			glTextureParameterf(texture, pname, param);
		}
		
		[MethodImport("glTextureParameterfv", "4.5")]
		private static delegate*<uint, TextureParameterName, float*, void> glTextureParameterfv;
		
		public static void TextureParameterfv(uint texture, TextureParameterName pname, float* param)
		{
			glTextureParameterfv(texture, pname, param);
		}
		
		[MethodImport("glTextureParameteri", "4.5")]
		private static delegate*<uint, TextureParameterName, int, void> glTextureParameteri;
		
		public static void TextureParameteri(uint texture, TextureParameterName pname, int param)
		{
			glTextureParameteri(texture, pname, param);
		}
		
		[MethodImport("glTextureParameterIiv", "4.5")]
		private static delegate*<uint, TextureParameterName, int*, void> glTextureParameterIiv;
		
		public static void TextureParameterIiv(uint texture, TextureParameterName pname, int* @params)
		{
			glTextureParameterIiv(texture, pname, @params);
		}
		
		[MethodImport("glTextureParameterIuiv", "4.5")]
		private static delegate*<uint, TextureParameterName, uint*, void> glTextureParameterIuiv;
		
		public static void TextureParameterIuiv(uint texture, TextureParameterName pname, uint* @params)
		{
			glTextureParameterIuiv(texture, pname, @params);
		}
		
		[MethodImport("glTextureParameteriv", "4.5")]
		private static delegate*<uint, TextureParameterName, int*, void> glTextureParameteriv;
		
		public static void TextureParameteriv(uint texture, TextureParameterName pname, int* param)
		{
			glTextureParameteriv(texture, pname, param);
		}
		
		[MethodImport("glGenerateTextureMipmap", "4.5")]
		private static delegate*<uint, void> glGenerateTextureMipmap;
		
		public static void GenerateTextureMipmap(uint texture)
		{
			glGenerateTextureMipmap(texture);
		}
		
		[MethodImport("glBindTextureUnit", "4.5")]
		private static delegate*<uint, uint, void> glBindTextureUnit;
		
		public static void BindTextureUnit(uint unit, uint texture)
		{
			glBindTextureUnit(unit, texture);
		}
		
		[MethodImport("glGetTextureImage", "4.5")]
		private static delegate*<uint, int, PixelFormat, PixelType, int, void*, void> glGetTextureImage;
		
		public static void GetTextureImage(uint texture, int level, PixelFormat format, PixelType type, int bufSize, void* pixels)
		{
			glGetTextureImage(texture, level, format, type, bufSize, pixels);
		}
		
		[MethodImport("glGetCompressedTextureImage", "4.5")]
		private static delegate*<uint, int, int, void*, void> glGetCompressedTextureImage;
		
		public static void GetCompressedTextureImage(uint texture, int level, int bufSize, void* pixels)
		{
			glGetCompressedTextureImage(texture, level, bufSize, pixels);
		}
		
		[MethodImport("glGetTextureLevelParameterfv", "4.5")]
		private static delegate*<uint, int, GetTextureParameter, float*, void> glGetTextureLevelParameterfv;
		
		public static void GetTextureLevelParameterfv(uint texture, int level, GetTextureParameter pname, float* @params)
		{
			glGetTextureLevelParameterfv(texture, level, pname, @params);
		}
		
		[MethodImport("glGetTextureLevelParameteriv", "4.5")]
		private static delegate*<uint, int, GetTextureParameter, int*, void> glGetTextureLevelParameteriv;
		
		public static void GetTextureLevelParameteriv(uint texture, int level, GetTextureParameter pname, int* @params)
		{
			glGetTextureLevelParameteriv(texture, level, pname, @params);
		}
		
		[MethodImport("glGetTextureParameterfv", "4.5")]
		private static delegate*<uint, GetTextureParameter, float*, void> glGetTextureParameterfv;
		
		public static void GetTextureParameterfv(uint texture, GetTextureParameter pname, float* @params)
		{
			glGetTextureParameterfv(texture, pname, @params);
		}
		
		[MethodImport("glGetTextureParameterIiv", "4.5")]
		private static delegate*<uint, GetTextureParameter, int*, void> glGetTextureParameterIiv;
		
		public static void GetTextureParameterIiv(uint texture, GetTextureParameter pname, int* @params)
		{
			glGetTextureParameterIiv(texture, pname, @params);
		}
		
		[MethodImport("glGetTextureParameterIuiv", "4.5")]
		private static delegate*<uint, GetTextureParameter, uint*, void> glGetTextureParameterIuiv;
		
		public static void GetTextureParameterIuiv(uint texture, GetTextureParameter pname, uint* @params)
		{
			glGetTextureParameterIuiv(texture, pname, @params);
		}
		
		[MethodImport("glGetTextureParameteriv", "4.5")]
		private static delegate*<uint, GetTextureParameter, int*, void> glGetTextureParameteriv;
		
		public static void GetTextureParameteriv(uint texture, GetTextureParameter pname, int* @params)
		{
			glGetTextureParameteriv(texture, pname, @params);
		}
		
		[MethodImport("glCreateVertexArrays", "4.5")]
		private static delegate*<int, uint*, void> glCreateVertexArrays;
		
		public static void CreateVertexArrays(int n, uint* arrays)
		{
			glCreateVertexArrays(n, arrays);
		}
		
		[MethodImport("glDisableVertexArrayAttrib", "4.5")]
		private static delegate*<uint, uint, void> glDisableVertexArrayAttrib;
		
		public static void DisableVertexArrayAttrib(uint vaobj, uint index)
		{
			glDisableVertexArrayAttrib(vaobj, index);
		}
		
		[MethodImport("glEnableVertexArrayAttrib", "4.5")]
		private static delegate*<uint, uint, void> glEnableVertexArrayAttrib;
		
		public static void EnableVertexArrayAttrib(uint vaobj, uint index)
		{
			glEnableVertexArrayAttrib(vaobj, index);
		}
		
		[MethodImport("glVertexArrayElementBuffer", "4.5")]
		private static delegate*<uint, uint, void> glVertexArrayElementBuffer;
		
		public static void VertexArrayElementBuffer(uint vaobj, uint buffer)
		{
			glVertexArrayElementBuffer(vaobj, buffer);
		}
		
		[MethodImport("glVertexArrayVertexBuffer", "4.5")]
		private static delegate*<uint, uint, uint, IntPtr, int, void> glVertexArrayVertexBuffer;
		
		public static void VertexArrayVertexBuffer(uint vaobj, uint bindingindex, uint buffer, IntPtr offset, int stride)
		{
			glVertexArrayVertexBuffer(vaobj, bindingindex, buffer, offset, stride);
		}
		
		[MethodImport("glVertexArrayVertexBuffers", "4.5")]
		private static delegate*<uint, uint, int, uint*, IntPtr*, int*, void> glVertexArrayVertexBuffers;
		
		public static void VertexArrayVertexBuffers(uint vaobj, uint first, int count, uint* buffers, IntPtr* offsets, int* strides)
		{
			glVertexArrayVertexBuffers(vaobj, first, count, buffers, offsets, strides);
		}
		
		[MethodImport("glVertexArrayAttribBinding", "4.5")]
		private static delegate*<uint, uint, uint, void> glVertexArrayAttribBinding;
		
		public static void VertexArrayAttribBinding(uint vaobj, uint attribindex, uint bindingindex)
		{
			glVertexArrayAttribBinding(vaobj, attribindex, bindingindex);
		}
		
		[MethodImport("glVertexArrayAttribFormat", "4.5")]
		private static delegate*<uint, uint, int, VertexAttribType, bool, uint, void> glVertexArrayAttribFormat;
		
		public static void VertexArrayAttribFormat(uint vaobj, uint attribindex, int size, VertexAttribType type, bool normalized, uint relativeoffset)
		{
			glVertexArrayAttribFormat(vaobj, attribindex, size, type, normalized, relativeoffset);
		}
		
		[MethodImport("glVertexArrayAttribIFormat", "4.5")]
		private static delegate*<uint, uint, int, VertexAttribIType, uint, void> glVertexArrayAttribIFormat;
		
		public static void VertexArrayAttribIFormat(uint vaobj, uint attribindex, int size, VertexAttribIType type, uint relativeoffset)
		{
			glVertexArrayAttribIFormat(vaobj, attribindex, size, type, relativeoffset);
		}
		
		[MethodImport("glVertexArrayAttribLFormat", "4.5")]
		private static delegate*<uint, uint, int, VertexAttribLType, uint, void> glVertexArrayAttribLFormat;
		
		public static void VertexArrayAttribLFormat(uint vaobj, uint attribindex, int size, VertexAttribLType type, uint relativeoffset)
		{
			glVertexArrayAttribLFormat(vaobj, attribindex, size, type, relativeoffset);
		}
		
		[MethodImport("glVertexArrayBindingDivisor", "4.5")]
		private static delegate*<uint, uint, uint, void> glVertexArrayBindingDivisor;
		
		public static void VertexArrayBindingDivisor(uint vaobj, uint bindingindex, uint divisor)
		{
			glVertexArrayBindingDivisor(vaobj, bindingindex, divisor);
		}
		
		[MethodImport("glGetVertexArrayiv", "4.5")]
		private static delegate*<uint, VertexArrayPName, int*, void> glGetVertexArrayiv;
		
		public static void GetVertexArrayiv(uint vaobj, VertexArrayPName pname, int* param)
		{
			glGetVertexArrayiv(vaobj, pname, param);
		}
		
		[MethodImport("glGetVertexArrayIndexediv", "4.5")]
		private static delegate*<uint, uint, VertexArrayPName, int*, void> glGetVertexArrayIndexediv;
		
		public static void GetVertexArrayIndexediv(uint vaobj, uint index, VertexArrayPName pname, int* param)
		{
			glGetVertexArrayIndexediv(vaobj, index, pname, param);
		}
		
		[MethodImport("glGetVertexArrayIndexed64iv", "4.5")]
		private static delegate*<uint, uint, VertexArrayPName, long*, void> glGetVertexArrayIndexed64iv;
		
		public static void GetVertexArrayIndexed64iv(uint vaobj, uint index, VertexArrayPName pname, long* param)
		{
			glGetVertexArrayIndexed64iv(vaobj, index, pname, param);
		}
		
		[MethodImport("glCreateSamplers", "4.5")]
		private static delegate*<int, uint*, void> glCreateSamplers;
		
		public static void CreateSamplers(int n, uint* samplers)
		{
			glCreateSamplers(n, samplers);
		}
		
		[MethodImport("glCreateProgramPipelines", "4.5")]
		private static delegate*<int, uint*, void> glCreateProgramPipelines;
		
		public static void CreateProgramPipelines(int n, uint* pipelines)
		{
			glCreateProgramPipelines(n, pipelines);
		}
		
		[MethodImport("glCreateQueries", "4.5")]
		private static delegate*<QueryTarget, int, uint*, void> glCreateQueries;
		
		public static void CreateQueries(QueryTarget target, int n, uint* ids)
		{
			glCreateQueries(target, n, ids);
		}
		
		[MethodImport("glGetQueryBufferObjecti64v", "4.5")]
		private static delegate*<uint, uint, QueryObjectParameterName, IntPtr, void> glGetQueryBufferObjecti64v;
		
		public static void GetQueryBufferObjecti64v(uint id, uint buffer, QueryObjectParameterName pname, IntPtr offset)
		{
			glGetQueryBufferObjecti64v(id, buffer, pname, offset);
		}
		
		[MethodImport("glGetQueryBufferObjectiv", "4.5")]
		private static delegate*<uint, uint, QueryObjectParameterName, IntPtr, void> glGetQueryBufferObjectiv;
		
		public static void GetQueryBufferObjectiv(uint id, uint buffer, QueryObjectParameterName pname, IntPtr offset)
		{
			glGetQueryBufferObjectiv(id, buffer, pname, offset);
		}
		
		[MethodImport("glGetQueryBufferObjectui64v", "4.5")]
		private static delegate*<uint, uint, QueryObjectParameterName, IntPtr, void> glGetQueryBufferObjectui64v;
		
		public static void GetQueryBufferObjectui64v(uint id, uint buffer, QueryObjectParameterName pname, IntPtr offset)
		{
			glGetQueryBufferObjectui64v(id, buffer, pname, offset);
		}
		
		[MethodImport("glGetQueryBufferObjectuiv", "4.5")]
		private static delegate*<uint, uint, QueryObjectParameterName, IntPtr, void> glGetQueryBufferObjectuiv;
		
		public static void GetQueryBufferObjectuiv(uint id, uint buffer, QueryObjectParameterName pname, IntPtr offset)
		{
			glGetQueryBufferObjectuiv(id, buffer, pname, offset);
		}
		
		[MethodImport("glMemoryBarrierByRegion", "4.5")]
		private static delegate*<MemoryBarrierMask, void> glMemoryBarrierByRegion;
		
		public static void MemoryBarrierByRegion(MemoryBarrierMask barriers)
		{
			glMemoryBarrierByRegion(barriers);
		}
		
		[MethodImport("glGetTextureSubImage", "4.5")]
		private static delegate*<uint, int, int, int, int, int, int, int, PixelFormat, PixelType, int, void*, void> glGetTextureSubImage;
		
		public static void GetTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, int bufSize, void* pixels)
		{
			glGetTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, bufSize, pixels);
		}
		
		[MethodImport("glGetCompressedTextureSubImage", "4.5")]
		private static delegate*<uint, int, int, int, int, int, int, int, int, void*, void> glGetCompressedTextureSubImage;
		
		public static void GetCompressedTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int bufSize, void* pixels)
		{
			glGetCompressedTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, bufSize, pixels);
		}
		
		[MethodImport("glGetGraphicsResetStatus", "4.5")]
		private static delegate*<GraphicsResetStatus> glGetGraphicsResetStatus;
		
		public static GraphicsResetStatus GetGraphicsResetStatus()
		{
			return glGetGraphicsResetStatus();
		}
		
		[MethodImport("glGetnCompressedTexImage", "4.5")]
		private static delegate*<TextureTarget, int, int, void*, void> glGetnCompressedTexImage;
		
		public static void GetnCompressedTexImage(TextureTarget target, int lod, int bufSize, void* pixels)
		{
			glGetnCompressedTexImage(target, lod, bufSize, pixels);
		}
		
		[MethodImport("glGetnTexImage", "4.5")]
		private static delegate*<TextureTarget, int, PixelFormat, PixelType, int, void*, void> glGetnTexImage;
		
		public static void GetnTexImage(TextureTarget target, int level, PixelFormat format, PixelType type, int bufSize, void* pixels)
		{
			glGetnTexImage(target, level, format, type, bufSize, pixels);
		}
		
		[MethodImport("glGetnUniformdv", "4.5")]
		private static delegate*<uint, int, int, double*, void> glGetnUniformdv;
		
		public static void GetnUniformdv(uint program, int location, int bufSize, double* @params)
		{
			glGetnUniformdv(program, location, bufSize, @params);
		}
		
		[MethodImport("glGetnUniformfv", "4.5")]
		private static delegate*<uint, int, int, float*, void> glGetnUniformfv;
		
		public static void GetnUniformfv(uint program, int location, int bufSize, float* @params)
		{
			glGetnUniformfv(program, location, bufSize, @params);
		}
		
		[MethodImport("glGetnUniformiv", "4.5")]
		private static delegate*<uint, int, int, int*, void> glGetnUniformiv;
		
		public static void GetnUniformiv(uint program, int location, int bufSize, int* @params)
		{
			glGetnUniformiv(program, location, bufSize, @params);
		}
		
		[MethodImport("glGetnUniformuiv", "4.5")]
		private static delegate*<uint, int, int, uint*, void> glGetnUniformuiv;
		
		public static void GetnUniformuiv(uint program, int location, int bufSize, uint* @params)
		{
			glGetnUniformuiv(program, location, bufSize, @params);
		}
		
		[MethodImport("glReadnPixels", "4.5")]
		private static delegate*<int, int, int, int, PixelFormat, PixelType, int, void*, void> glReadnPixels;
		
		public static void ReadnPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, void* data)
		{
			glReadnPixels(x, y, width, height, format, type, bufSize, data);
		}
		
		[MethodImport("glGetnMapdv", "4.5")]
		private static delegate*<MapTarget, MapQuery, int, double*, void> glGetnMapdv;
		
		public static void GetnMapdv(MapTarget target, MapQuery query, int bufSize, double* v)
		{
			glGetnMapdv(target, query, bufSize, v);
		}
		
		[MethodImport("glGetnMapfv", "4.5")]
		private static delegate*<MapTarget, MapQuery, int, float*, void> glGetnMapfv;
		
		public static void GetnMapfv(MapTarget target, MapQuery query, int bufSize, float* v)
		{
			glGetnMapfv(target, query, bufSize, v);
		}
		
		[MethodImport("glGetnMapiv", "4.5")]
		private static delegate*<MapTarget, MapQuery, int, int*, void> glGetnMapiv;
		
		public static void GetnMapiv(MapTarget target, MapQuery query, int bufSize, int* v)
		{
			glGetnMapiv(target, query, bufSize, v);
		}
		
		[MethodImport("glGetnPixelMapfv", "4.5")]
		private static delegate*<PixelMap, int, float*, void> glGetnPixelMapfv;
		
		public static void GetnPixelMapfv(PixelMap map, int bufSize, float* values)
		{
			glGetnPixelMapfv(map, bufSize, values);
		}
		
		[MethodImport("glGetnPixelMapuiv", "4.5")]
		private static delegate*<PixelMap, int, uint*, void> glGetnPixelMapuiv;
		
		public static void GetnPixelMapuiv(PixelMap map, int bufSize, uint* values)
		{
			glGetnPixelMapuiv(map, bufSize, values);
		}
		
		[MethodImport("glGetnPixelMapusv", "4.5")]
		private static delegate*<PixelMap, int, ushort*, void> glGetnPixelMapusv;
		
		public static void GetnPixelMapusv(PixelMap map, int bufSize, ushort* values)
		{
			glGetnPixelMapusv(map, bufSize, values);
		}
		
		[MethodImport("glGetnPolygonStipple", "4.5")]
		private static delegate*<int, byte*, void> glGetnPolygonStipple;
		
		public static void GetnPolygonStipple(int bufSize, byte* pattern)
		{
			glGetnPolygonStipple(bufSize, pattern);
		}
		
		[MethodImport("glGetnColorTable", "4.5")]
		private static delegate*<ColorTableTarget, PixelFormat, PixelType, int, void*, void> glGetnColorTable;
		
		public static void GetnColorTable(ColorTableTarget target, PixelFormat format, PixelType type, int bufSize, void* table)
		{
			glGetnColorTable(target, format, type, bufSize, table);
		}
		
		[MethodImport("glGetnConvolutionFilter", "4.5")]
		private static delegate*<ConvolutionTarget, PixelFormat, PixelType, int, void*, void> glGetnConvolutionFilter;
		
		public static void GetnConvolutionFilter(ConvolutionTarget target, PixelFormat format, PixelType type, int bufSize, void* image)
		{
			glGetnConvolutionFilter(target, format, type, bufSize, image);
		}
		
		[MethodImport("glGetnSeparableFilter", "4.5")]
		private static delegate*<SeparableTarget, PixelFormat, PixelType, int, void*, int, void*, void*, void> glGetnSeparableFilter;
		
		public static void GetnSeparableFilter(SeparableTarget target, PixelFormat format, PixelType type, int rowBufSize, void* row, int columnBufSize, void* column, void* span)
		{
			glGetnSeparableFilter(target, format, type, rowBufSize, row, columnBufSize, column, span);
		}
		
		[MethodImport("glGetnHistogram", "4.5")]
		private static delegate*<HistogramTarget, bool, PixelFormat, PixelType, int, void*, void> glGetnHistogram;
		
		public static void GetnHistogram(HistogramTarget target, bool reset, PixelFormat format, PixelType type, int bufSize, void* values)
		{
			glGetnHistogram(target, reset, format, type, bufSize, values);
		}
		
		[MethodImport("glGetnMinmax", "4.5")]
		private static delegate*<MinmaxTarget, bool, PixelFormat, PixelType, int, void*, void> glGetnMinmax;
		
		public static void GetnMinmax(MinmaxTarget target, bool reset, PixelFormat format, PixelType type, int bufSize, void* values)
		{
			glGetnMinmax(target, reset, format, type, bufSize, values);
		}
		
		[MethodImport("glTextureBarrier", "4.5")]
		private static delegate*<void> glTextureBarrier;
		
		public static void TextureBarrier()
		{
			glTextureBarrier();
		}
	}
}

