using System;
using System.Runtime.InteropServices;
using CC = System.Runtime.InteropServices.CallingConvention;
using UFP = System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute;

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[UFP(CC.Cdecl)]
		private unsafe delegate void ClipControlDelegate(uint origin, uint depth);

		[UFP(CC.Cdecl)]
		private unsafe delegate void CreateTransformFeedbacksDelegate(int n, ref uint ids);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TransformFeedbackBufferBaseDelegate(uint xfb, uint index, uint buffer);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TransformFeedbackBufferRangeDelegate(uint xfb, uint index, uint buffer, int offset, int size);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetTransformFeedbackivDelegate(uint xfb, uint pName, ref int param);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetTransformFeedbacki_vDelegate(uint xfb, uint pName, uint index, ref int param);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetTransformFeedbacki64_vDelegate(uint xfb, uint pName, uint index, ref long param);

		[UFP(CC.Cdecl)]
		private unsafe delegate void CreateBuffersDelegate(int n, [Out] uint[] buffers);

		[UFP(CC.Cdecl)]
		private unsafe delegate void NamedBufferStorageDelegate(uint buffer, int size, IntPtr data, uint flags);

		[UFP(CC.Cdecl)]
		private unsafe delegate void NamedBufferDataDelegate(uint buffer, int size, IntPtr data, BufferUsageHint usage);

		[UFP(CC.Cdecl)]
		private unsafe delegate void NamedBufferSubDataDelegate(uint buffer, int offset, int size, IntPtr data);

		[UFP(CC.Cdecl)]
		private unsafe delegate void CopyNamedBufferSubDataDelegate(uint readBuffer, uint writeBuffer, int readOffset, int writeOffset, int size);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ClearNamedBufferDataDelegate(uint buffer, PixelInternalFormat internalFormat, PixelFormat format, PixelType type, IntPtr data);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ClearNamedBufferSubDataDelegate(uint buffer, PixelInternalFormat internalFormat, int offset, int size, PixelFormat format, PixelType type, IntPtr data);

		[UFP(CC.Cdecl)]
		private unsafe delegate IntPtr MapNamedBufferDelegate(uint buffer, uint access);

		[UFP(CC.Cdecl)]
		private unsafe delegate IntPtr MapNamedBufferRangeDelegate(uint buffer, int offset, int length, uint access);

		[UFP(CC.Cdecl)]
		private unsafe delegate byte UnmapNamedBufferDelegate(uint buffer);

		[UFP(CC.Cdecl)]
		private unsafe delegate void FlushMappedNamedBufferRangeDelegate(uint buffer, int offset, int length);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetNamedBufferParameterivDelegate(uint buffer, uint pName, ref int parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetNamedBufferParameteri64vDelegate(uint buffer, uint pName, ref long parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetNamedBufferPointervDelegate(uint buffer, uint pName, ref IntPtr parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetNamedBufferSubDataDelegate(uint buffer, int offset, int size, IntPtr data);

		[UFP(CC.Cdecl)]
		private unsafe delegate void CreateFramebuffersDelegate(int n, ref uint framebuffers);

		[UFP(CC.Cdecl)]
		private unsafe delegate void NamedFramebufferRenderbufferDelegate(uint framebuffer, uint attachment, RenderbufferTarget renderbuffertarget, uint renderbuffer);

		[UFP(CC.Cdecl)]
		private unsafe delegate void NamedFramebufferParameteriDelegate(uint framebuffer, uint pName, int param);

		[UFP(CC.Cdecl)]
		private unsafe delegate void NamedFramebufferTextureDelegate(uint framebuffer, FramebufferAttachment attachment, uint texture, int level);

		[UFP(CC.Cdecl)]
		private unsafe delegate void NamedFramebufferTextureLayerDelegate(uint framebuffer, FramebufferAttachment attachment, uint texture, int level, int layer);

		[UFP(CC.Cdecl)]
		private unsafe delegate void NamedFramebufferDrawBufferDelegate(uint framebuffer, DrawBufferMode buf);

		[UFP(CC.Cdecl)]
		private unsafe delegate void NamedFramebufferDrawBuffersDelegate(uint framebuffer, int n, DrawBufferMode[] bufs);

		[UFP(CC.Cdecl)]
		private unsafe delegate void NamedFramebufferReadBufferDelegate(uint framebuffer, uint src);

		[UFP(CC.Cdecl)]
		private unsafe delegate void InvalidateNamedFramebufferDataDelegate(uint framebuffer, int numAttachments, FramebufferAttachment* attachments);

		[UFP(CC.Cdecl)]
		private unsafe delegate void InvalidateNamedFramebufferSubDataDelegate(uint framebuffer, int numAttachments, FramebufferAttachment* attachments, int x, int y, int width, int height);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ClearNamedFramebufferivDelegate(uint framebuffer, uint buffer, int drawbuffer, ref int value);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ClearNamedFramebufferuivDelegate(uint framebuffer, uint buffer, int drawbuffer, ref uint value);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ClearNamedFramebufferfvDelegate(uint framebuffer, uint buffer, int drawbuffer, ref float value);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ClearNamedFramebufferfiDelegate(uint framebuffer, uint buffer, int drawbuffer, float depth, int stencil);

		[UFP(CC.Cdecl)]
		private unsafe delegate void BlitNamedFramebufferDelegate(uint readFramebuffer, uint drawFramebuffer, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter);

		[UFP(CC.Cdecl)]
		private unsafe delegate uint CheckNamedFramebufferStatusDelegate(uint framebuffer, FramebufferTarget target);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetNamedFramebufferParameterivDelegate(uint framebuffer, uint pName, ref int param);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetNamedFramebufferAttachmentParameterivDelegate(uint framebuffer, FramebufferAttachment attachment, uint pName, ref int parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void CreateRenderbuffersDelegate(int n, ref uint renderbuffers);

		[UFP(CC.Cdecl)]
		private unsafe delegate void NamedRenderbufferStorageDelegate(uint renderbuffer, PixelInternalFormat internalFormat, int width, int height);

		[UFP(CC.Cdecl)]
		private unsafe delegate void NamedRenderbufferStorageMultisampleDelegate(uint renderbuffer, int samples, PixelInternalFormat internalFormat, int width, int height);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetNamedRenderbufferParameterivDelegate(uint renderbuffer, uint pName, ref int parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void CreateTexturesDelegate(TextureTarget target, uint n, IntPtr textures);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TextureBufferDelegate(uint texture, uint internalFormat, uint buffer);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TextureBufferRangeDelegate(uint texture, uint internalFormat, uint buffer, IntPtr offset, IntPtr size);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TextureStorage1DDelegate(uint texture, int levels, uint internalFormat, int width);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TextureStorage2DDelegate(uint texture, int levels, uint internalFormat, int width, int height);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TextureStorage3DDelegate(uint texture, int levels, uint internalFormat, int width, int height, int depth);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TextureStorage2DMultisampleDelegate(uint texture, int samples, uint internalFormat, int width, int height, byte fixedsamplelocations);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TextureStorage3DMultisampleDelegate(uint texture, int samples, uint internalFormat, int width, int height, int depth, byte fixedsamplelocations);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TextureSubImage1DDelegate(uint texture, int level, int xOffset, int width, PixelFormat format, PixelType type, IntPtr pixels);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TextureSubImage2DDelegate(uint texture, int level, int xOffset, int yOffset, int width, int height, PixelFormat format, PixelType type, IntPtr pixels);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TextureSubImage3DDelegate(uint texture, int level, int xOffset, int yOffset, int zOffset, int width, int height, int depth, PixelFormat format, PixelType type, IntPtr pixels);

		[UFP(CC.Cdecl)]
		private unsafe delegate void CompressedTextureSubImage1DDelegate(uint texture, int level, int xOffset, int width, uint format, int imageSize, IntPtr data);

		[UFP(CC.Cdecl)]
		private unsafe delegate void CompressedTextureSubImage2DDelegate(uint texture, int level, int xOffset, int yOffset, int width, int height, uint format, int imageSize, IntPtr data);

		[UFP(CC.Cdecl)]
		private unsafe delegate void CompressedTextureSubImage3DDelegate(uint texture, int level, int xOffset, int yOffset, int zOffset, int width, int height, int depth, uint format, int imageSize, IntPtr data);

		[UFP(CC.Cdecl)]
		private unsafe delegate void CopyTextureSubImage1DDelegate(uint texture, int level, int xOffset, int x, int y, int width);

		[UFP(CC.Cdecl)]
		private unsafe delegate void CopyTextureSubImage2DDelegate(uint texture, int level, int xOffset, int yOffset, int x, int y, int width, int height);

		[UFP(CC.Cdecl)]
		private unsafe delegate void CopyTextureSubImage3DDelegate(uint texture, int level, int xOffset, int yOffset, int zOffset, int x, int y, int width, int height);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TextureParameterfDelegate(uint texture, uint pName, float param);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TextureParameterfvDelegate(uint texture, uint pName, ref float param);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TextureParameteriDelegate(uint texture, uint pName, int param);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TextureParameterIivDelegate(uint texture, uint pName, ref int parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TextureParameterIuivDelegate(uint texture, uint pName, ref uint parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TextureParameterivDelegate(uint texture, uint pName, ref int param);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GenerateTextureMipmapDelegate(uint texture);

		[UFP(CC.Cdecl)]
		private unsafe delegate void BindTextureUnitDelegate(uint unit, uint texture);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetTextureImageDelegate(uint texture, int level, PixelFormat format, PixelType type, int bufSize, IntPtr pixels);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetCompressedTextureImageDelegate(uint texture, int level, int bufSize, IntPtr pixels);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetTextureLevelParameterfvDelegate(TextureTarget texture, int level, uint pName, ref float parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetTextureLevelParameterivDelegate(TextureTarget texture, int level, uint pName, ref int parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetTextureParameterfvDelegate(uint texture, uint pName, ref float parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetTextureParameterIivDelegate(uint texture, uint pName, ref int parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetTextureParameterIuivDelegate(uint texture, uint pName, ref uint parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetTextureParameterivDelegate(uint texture, uint pName, ref int parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void CreateVertexArraysDelegate(int n, ref uint arrays);

		[UFP(CC.Cdecl)]
		private unsafe delegate void DisableVertexArrayAttribDelegate(uint vaobj, uint index);

		[UFP(CC.Cdecl)]
		private unsafe delegate void EnableVertexArrayAttribDelegate(uint vaobj, uint index);

		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexArrayElementBufferDelegate(uint vaobj, uint buffer);

		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexArrayVertexBufferDelegate(uint vaobj, uint bindingindex, uint buffer, int offset, int stride);

		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexArrayVertexBuffersDelegate(uint vaobj, uint first, int count, ref uint buffers, ref int offsets, ref int strides);

		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexArrayAttribBindingDelegate(uint vaobj, uint attribindex, uint bindingindex);

		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexArrayAttribFormatDelegate(uint vaobj, uint attribindex, int size, uint type, byte normalized, uint relativeoffset);

		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexArrayAttribIFormatDelegate(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset);

		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexArrayAttribLFormatDelegate(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset);

		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexArrayBindingDivisorDelegate(uint vaobj, uint bindingindex, uint divisor);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetVertexArrayivDelegate(uint vaobj, uint pName, ref int param);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetVertexArrayIndexedivDelegate(uint vaobj, uint index, uint pName, ref int param);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetVertexArrayIndexed64ivDelegate(uint vaobj, uint index, uint pName, ref long param);

		[UFP(CC.Cdecl)]
		private unsafe delegate void CreateSamplersDelegate(int n, ref uint samplers);

		[UFP(CC.Cdecl)]
		private unsafe delegate void CreateProgramPipelinesDelegate(int n, ref uint pipelines);

		[UFP(CC.Cdecl)]
		private unsafe delegate void CreateQueriesDelegate(uint target, int n, ref uint ids);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetQueryBufferObjecti64vDelegate(uint id, uint buffer, uint pName, int offset);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetQueryBufferObjectivDelegate(uint id, uint buffer, uint pName, int offset);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetQueryBufferObjectui64vDelegate(uint id, uint buffer, uint pName, int offset);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetQueryBufferObjectuivDelegate(uint id, uint buffer, uint pName, int offset);

		[UFP(CC.Cdecl)]
		private unsafe delegate void MemoryBarrierByRegionDelegate(uint barriers);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetTextureSubImageDelegate(uint texture, int level, int xOffset, int yOffset, int zOffset, int width, int height, int depth, PixelFormat format, PixelType type, int bufSize, IntPtr pixels);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetCompressedTextureSubImageDelegate(uint texture, int level, int xOffset, int yOffset, int zOffset, int width, int height, int depth, int bufSize, IntPtr pixels);

		[UFP(CC.Cdecl)]
		private unsafe delegate uint GetGraphicsResetStatusDelegate();

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetnCompressedTexImageDelegate(TextureTarget target, int lod, int bufSize, IntPtr pixels);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetnTexImageDelegate(TextureTarget target, int level, PixelFormat format, PixelType type, int bufSize, IntPtr pixels);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetnUniformdvDelegate(uint program, int location, int bufSize, ref double parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetnUniformfvDelegate(uint program, int location, int bufSize, ref float parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetnUniformivDelegate(uint program, int location, int bufSize, ref int parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetnUniformuivDelegate(uint program, int location, int bufSize, ref uint parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ReadnPixelsDelegate(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, IntPtr data);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TextureBarrierDelegate();
	}
}
