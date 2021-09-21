using System;

namespace Dissonance.Framework.Graphics.OpenGL
{
	unsafe partial class GL
	{
		[MethodImport("glColorMaski", "3.0")]
		private static delegate*<uint, bool, bool, bool, bool, void> glColorMaski;
		
		public static void ColorMaski(uint index, bool r, bool g, bool b, bool a)
		{
			glColorMaski(index, r, g, b, a);
		}
		
		[MethodImport("glGetBooleani_v", "3.0")]
		private static delegate*<BufferTargetARB, uint, bool*, void> glGetBooleani_v;
		
		public static void GetBooleani_v(BufferTargetARB target, uint index, bool* data)
		{
			glGetBooleani_v(target, index, data);
		}
		
		[MethodImport("glGetIntegeri_v", "3.0")]
		private static delegate*<GetPName, uint, int*, void> glGetIntegeri_v;
		
		public static void GetIntegeri_v(GetPName target, uint index, int* data)
		{
			glGetIntegeri_v(target, index, data);
		}
		
		[MethodImport("glEnablei", "3.0")]
		private static delegate*<EnableCap, uint, void> glEnablei;
		
		public static void Enablei(EnableCap target, uint index)
		{
			glEnablei(target, index);
		}
		
		[MethodImport("glDisablei", "3.0")]
		private static delegate*<EnableCap, uint, void> glDisablei;
		
		public static void Disablei(EnableCap target, uint index)
		{
			glDisablei(target, index);
		}
		
		[MethodImport("glIsEnabledi", "3.0")]
		private static delegate*<EnableCap, uint, bool> glIsEnabledi;
		
		public static bool IsEnabledi(EnableCap target, uint index)
		{
			return glIsEnabledi(target, index);
		}
		
		[MethodImport("glBeginTransformFeedback", "3.0")]
		private static delegate*<PrimitiveType, void> glBeginTransformFeedback;
		
		public static void BeginTransformFeedback(PrimitiveType primitiveMode)
		{
			glBeginTransformFeedback(primitiveMode);
		}
		
		[MethodImport("glEndTransformFeedback", "3.0")]
		private static delegate*<void> glEndTransformFeedback;
		
		public static void EndTransformFeedback()
		{
			glEndTransformFeedback();
		}
		
		[MethodImport("glBindBufferRange", "3.0")]
		private static delegate*<BufferTargetARB, uint, uint, IntPtr, IntPtr, void> glBindBufferRange;
		
		public static void BindBufferRange(BufferTargetARB target, uint index, uint buffer, IntPtr offset, IntPtr size)
		{
			glBindBufferRange(target, index, buffer, offset, size);
		}
		
		[MethodImport("glBindBufferBase", "3.0")]
		private static delegate*<BufferTargetARB, uint, uint, void> glBindBufferBase;
		
		public static void BindBufferBase(BufferTargetARB target, uint index, uint buffer)
		{
			glBindBufferBase(target, index, buffer);
		}
		
		[MethodImport("glTransformFeedbackVaryings", "3.0")]
		private static delegate*<uint, int, byte**, TransformFeedbackBufferMode, void> glTransformFeedbackVaryings;
		
		public static void TransformFeedbackVaryings(uint program, int count, byte** varyings, TransformFeedbackBufferMode bufferMode)
		{
			glTransformFeedbackVaryings(program, count, varyings, bufferMode);
		}
		
		[MethodImport("glGetTransformFeedbackVarying", "3.0")]
		private static delegate*<uint, uint, int, int*, int*, AttributeType, byte*, void> glGetTransformFeedbackVarying;
		
		public static void GetTransformFeedbackVarying(uint program, uint index, int bufSize, int* length, int* size, AttributeType type, byte* name)
		{
			glGetTransformFeedbackVarying(program, index, bufSize, length, size, type, name);
		}
		
		[MethodImport("glClampColor", "3.0")]
		private static delegate*<ClampColorTargetARB, ClampColorModeARB, void> glClampColor;
		
		public static void ClampColor(ClampColorTargetARB target, ClampColorModeARB clamp)
		{
			glClampColor(target, clamp);
		}
		
		[MethodImport("glBeginConditionalRender", "3.0")]
		private static delegate*<uint, ConditionalRenderMode, void> glBeginConditionalRender;
		
		public static void BeginConditionalRender(uint id, ConditionalRenderMode mode)
		{
			glBeginConditionalRender(id, mode);
		}
		
		[MethodImport("glEndConditionalRender", "3.0")]
		private static delegate*<void> glEndConditionalRender;
		
		public static void EndConditionalRender()
		{
			glEndConditionalRender();
		}
		
		[MethodImport("glVertexAttribIPointer", "3.0")]
		private static delegate*<uint, int, VertexAttribIType, int, void*, void> glVertexAttribIPointer;
		
		public static void VertexAttribIPointer(uint index, int size, VertexAttribIType type, int stride, void* pointer)
		{
			glVertexAttribIPointer(index, size, type, stride, pointer);
		}
		
		[MethodImport("glGetVertexAttribIiv", "3.0")]
		private static delegate*<uint, VertexAttribEnum, int*, void> glGetVertexAttribIiv;
		
		public static void GetVertexAttribIiv(uint index, VertexAttribEnum pname, int* @params)
		{
			glGetVertexAttribIiv(index, pname, @params);
		}
		
		[MethodImport("glGetVertexAttribIuiv", "3.0")]
		private static delegate*<uint, VertexAttribEnum, uint*, void> glGetVertexAttribIuiv;
		
		public static void GetVertexAttribIuiv(uint index, VertexAttribEnum pname, uint* @params)
		{
			glGetVertexAttribIuiv(index, pname, @params);
		}
		
		[MethodImport("glVertexAttribI1i", "3.0")]
		private static delegate*<uint, int, void> glVertexAttribI1i;
		
		public static void VertexAttribI1i(uint index, int x)
		{
			glVertexAttribI1i(index, x);
		}
		
		[MethodImport("glVertexAttribI2i", "3.0")]
		private static delegate*<uint, int, int, void> glVertexAttribI2i;
		
		public static void VertexAttribI2i(uint index, int x, int y)
		{
			glVertexAttribI2i(index, x, y);
		}
		
		[MethodImport("glVertexAttribI3i", "3.0")]
		private static delegate*<uint, int, int, int, void> glVertexAttribI3i;
		
		public static void VertexAttribI3i(uint index, int x, int y, int z)
		{
			glVertexAttribI3i(index, x, y, z);
		}
		
		[MethodImport("glVertexAttribI4i", "3.0")]
		private static delegate*<uint, int, int, int, int, void> glVertexAttribI4i;
		
		public static void VertexAttribI4i(uint index, int x, int y, int z, int w)
		{
			glVertexAttribI4i(index, x, y, z, w);
		}
		
		[MethodImport("glVertexAttribI1ui", "3.0")]
		private static delegate*<uint, uint, void> glVertexAttribI1ui;
		
		public static void VertexAttribI1ui(uint index, uint x)
		{
			glVertexAttribI1ui(index, x);
		}
		
		[MethodImport("glVertexAttribI2ui", "3.0")]
		private static delegate*<uint, uint, uint, void> glVertexAttribI2ui;
		
		public static void VertexAttribI2ui(uint index, uint x, uint y)
		{
			glVertexAttribI2ui(index, x, y);
		}
		
		[MethodImport("glVertexAttribI3ui", "3.0")]
		private static delegate*<uint, uint, uint, uint, void> glVertexAttribI3ui;
		
		public static void VertexAttribI3ui(uint index, uint x, uint y, uint z)
		{
			glVertexAttribI3ui(index, x, y, z);
		}
		
		[MethodImport("glVertexAttribI4ui", "3.0")]
		private static delegate*<uint, uint, uint, uint, uint, void> glVertexAttribI4ui;
		
		public static void VertexAttribI4ui(uint index, uint x, uint y, uint z, uint w)
		{
			glVertexAttribI4ui(index, x, y, z, w);
		}
		
		[MethodImport("glVertexAttribI1iv", "3.0")]
		private static delegate*<uint, int*, void> glVertexAttribI1iv;
		
		public static void VertexAttribI1iv(uint index, int* v)
		{
			glVertexAttribI1iv(index, v);
		}
		
		[MethodImport("glVertexAttribI2iv", "3.0")]
		private static delegate*<uint, int*, void> glVertexAttribI2iv;
		
		public static void VertexAttribI2iv(uint index, int* v)
		{
			glVertexAttribI2iv(index, v);
		}
		
		[MethodImport("glVertexAttribI3iv", "3.0")]
		private static delegate*<uint, int*, void> glVertexAttribI3iv;
		
		public static void VertexAttribI3iv(uint index, int* v)
		{
			glVertexAttribI3iv(index, v);
		}
		
		[MethodImport("glVertexAttribI4iv", "3.0")]
		private static delegate*<uint, int*, void> glVertexAttribI4iv;
		
		public static void VertexAttribI4iv(uint index, int* v)
		{
			glVertexAttribI4iv(index, v);
		}
		
		[MethodImport("glVertexAttribI1uiv", "3.0")]
		private static delegate*<uint, uint*, void> glVertexAttribI1uiv;
		
		public static void VertexAttribI1uiv(uint index, uint* v)
		{
			glVertexAttribI1uiv(index, v);
		}
		
		[MethodImport("glVertexAttribI2uiv", "3.0")]
		private static delegate*<uint, uint*, void> glVertexAttribI2uiv;
		
		public static void VertexAttribI2uiv(uint index, uint* v)
		{
			glVertexAttribI2uiv(index, v);
		}
		
		[MethodImport("glVertexAttribI3uiv", "3.0")]
		private static delegate*<uint, uint*, void> glVertexAttribI3uiv;
		
		public static void VertexAttribI3uiv(uint index, uint* v)
		{
			glVertexAttribI3uiv(index, v);
		}
		
		[MethodImport("glVertexAttribI4uiv", "3.0")]
		private static delegate*<uint, uint*, void> glVertexAttribI4uiv;
		
		public static void VertexAttribI4uiv(uint index, uint* v)
		{
			glVertexAttribI4uiv(index, v);
		}
		
		[MethodImport("glVertexAttribI4bv", "3.0")]
		private static delegate*<uint, sbyte*, void> glVertexAttribI4bv;
		
		public static void VertexAttribI4bv(uint index, sbyte* v)
		{
			glVertexAttribI4bv(index, v);
		}
		
		[MethodImport("glVertexAttribI4sv", "3.0")]
		private static delegate*<uint, short*, void> glVertexAttribI4sv;
		
		public static void VertexAttribI4sv(uint index, short* v)
		{
			glVertexAttribI4sv(index, v);
		}
		
		[MethodImport("glVertexAttribI4ubv", "3.0")]
		private static delegate*<uint, byte*, void> glVertexAttribI4ubv;
		
		public static void VertexAttribI4ubv(uint index, byte* v)
		{
			glVertexAttribI4ubv(index, v);
		}
		
		[MethodImport("glVertexAttribI4usv", "3.0")]
		private static delegate*<uint, ushort*, void> glVertexAttribI4usv;
		
		public static void VertexAttribI4usv(uint index, ushort* v)
		{
			glVertexAttribI4usv(index, v);
		}
		
		[MethodImport("glGetUniformuiv", "3.0")]
		private static delegate*<uint, int, uint*, void> glGetUniformuiv;
		
		public static void GetUniformuiv(uint program, int location, uint* @params)
		{
			glGetUniformuiv(program, location, @params);
		}
		
		[MethodImport("glBindFragDataLocation", "3.0")]
		private static delegate*<uint, uint, byte*, void> glBindFragDataLocation;
		
		public static void BindFragDataLocation(uint program, uint color, byte* name)
		{
			glBindFragDataLocation(program, color, name);
		}
		
		[MethodImport("glGetFragDataLocation", "3.0")]
		private static delegate*<uint, byte*, int> glGetFragDataLocation;
		
		public static int GetFragDataLocation(uint program, byte* name)
		{
			return glGetFragDataLocation(program, name);
		}
		
		[MethodImport("glUniform1ui", "3.0")]
		private static delegate*<int, uint, void> glUniform1ui;
		
		public static void Uniform1ui(int location, uint v0)
		{
			glUniform1ui(location, v0);
		}
		
		[MethodImport("glUniform2ui", "3.0")]
		private static delegate*<int, uint, uint, void> glUniform2ui;
		
		public static void Uniform2ui(int location, uint v0, uint v1)
		{
			glUniform2ui(location, v0, v1);
		}
		
		[MethodImport("glUniform3ui", "3.0")]
		private static delegate*<int, uint, uint, uint, void> glUniform3ui;
		
		public static void Uniform3ui(int location, uint v0, uint v1, uint v2)
		{
			glUniform3ui(location, v0, v1, v2);
		}
		
		[MethodImport("glUniform4ui", "3.0")]
		private static delegate*<int, uint, uint, uint, uint, void> glUniform4ui;
		
		public static void Uniform4ui(int location, uint v0, uint v1, uint v2, uint v3)
		{
			glUniform4ui(location, v0, v1, v2, v3);
		}
		
		[MethodImport("glUniform1uiv", "3.0")]
		private static delegate*<int, int, uint*, void> glUniform1uiv;
		
		public static void Uniform1uiv(int location, int count, uint* value)
		{
			glUniform1uiv(location, count, value);
		}
		
		[MethodImport("glUniform2uiv", "3.0")]
		private static delegate*<int, int, uint*, void> glUniform2uiv;
		
		public static void Uniform2uiv(int location, int count, uint* value)
		{
			glUniform2uiv(location, count, value);
		}
		
		[MethodImport("glUniform3uiv", "3.0")]
		private static delegate*<int, int, uint*, void> glUniform3uiv;
		
		public static void Uniform3uiv(int location, int count, uint* value)
		{
			glUniform3uiv(location, count, value);
		}
		
		[MethodImport("glUniform4uiv", "3.0")]
		private static delegate*<int, int, uint*, void> glUniform4uiv;
		
		public static void Uniform4uiv(int location, int count, uint* value)
		{
			glUniform4uiv(location, count, value);
		}
		
		[MethodImport("glTexParameterIiv", "3.0")]
		private static delegate*<TextureTarget, TextureParameterName, int*, void> glTexParameterIiv;
		
		public static void TexParameterIiv(TextureTarget target, TextureParameterName pname, int* @params)
		{
			glTexParameterIiv(target, pname, @params);
		}
		
		[MethodImport("glTexParameterIuiv", "3.0")]
		private static delegate*<TextureTarget, TextureParameterName, uint*, void> glTexParameterIuiv;
		
		public static void TexParameterIuiv(TextureTarget target, TextureParameterName pname, uint* @params)
		{
			glTexParameterIuiv(target, pname, @params);
		}
		
		[MethodImport("glGetTexParameterIiv", "3.0")]
		private static delegate*<TextureTarget, GetTextureParameter, int*, void> glGetTexParameterIiv;
		
		public static void GetTexParameterIiv(TextureTarget target, GetTextureParameter pname, int* @params)
		{
			glGetTexParameterIiv(target, pname, @params);
		}
		
		[MethodImport("glGetTexParameterIuiv", "3.0")]
		private static delegate*<TextureTarget, GetTextureParameter, uint*, void> glGetTexParameterIuiv;
		
		public static void GetTexParameterIuiv(TextureTarget target, GetTextureParameter pname, uint* @params)
		{
			glGetTexParameterIuiv(target, pname, @params);
		}
		
		[MethodImport("glClearBufferiv", "3.0")]
		private static delegate*<Buffer, int, int*, void> glClearBufferiv;
		
		public static void ClearBufferiv(Buffer buffer, int drawbuffer, int* value)
		{
			glClearBufferiv(buffer, drawbuffer, value);
		}
		
		[MethodImport("glClearBufferuiv", "3.0")]
		private static delegate*<Buffer, int, uint*, void> glClearBufferuiv;
		
		public static void ClearBufferuiv(Buffer buffer, int drawbuffer, uint* value)
		{
			glClearBufferuiv(buffer, drawbuffer, value);
		}
		
		[MethodImport("glClearBufferfv", "3.0")]
		private static delegate*<Buffer, int, float*, void> glClearBufferfv;
		
		public static void ClearBufferfv(Buffer buffer, int drawbuffer, float* value)
		{
			glClearBufferfv(buffer, drawbuffer, value);
		}
		
		[MethodImport("glClearBufferfi", "3.0")]
		private static delegate*<Buffer, int, float, int, void> glClearBufferfi;
		
		public static void ClearBufferfi(Buffer buffer, int drawbuffer, float depth, int stencil)
		{
			glClearBufferfi(buffer, drawbuffer, depth, stencil);
		}
		
		[MethodImport("glGetStringi", "3.0")]
		private static delegate*<StringName, uint, byte> glGetStringi;
		
		public static byte GetStringi(StringName name, uint index)
		{
			return glGetStringi(name, index);
		}
		
		[MethodImport("glIsRenderbuffer", "3.0")]
		private static delegate*<uint, bool> glIsRenderbuffer;
		
		public static bool IsRenderbuffer(uint renderbuffer)
		{
			return glIsRenderbuffer(renderbuffer);
		}
		
		[MethodImport("glBindRenderbuffer", "3.0")]
		private static delegate*<RenderbufferTarget, uint, void> glBindRenderbuffer;
		
		public static void BindRenderbuffer(RenderbufferTarget target, uint renderbuffer)
		{
			glBindRenderbuffer(target, renderbuffer);
		}
		
		[MethodImport("glDeleteRenderbuffers", "3.0")]
		private static delegate*<int, uint*, void> glDeleteRenderbuffers;
		
		public static void DeleteRenderbuffers(int n, uint* renderbuffers)
		{
			glDeleteRenderbuffers(n, renderbuffers);
		}
		
		[MethodImport("glGenRenderbuffers", "3.0")]
		private static delegate*<int, uint*, void> glGenRenderbuffers;
		
		public static void GenRenderbuffers(int n, uint* renderbuffers)
		{
			glGenRenderbuffers(n, renderbuffers);
		}
		
		[MethodImport("glRenderbufferStorage", "3.0")]
		private static delegate*<RenderbufferTarget, InternalFormat, int, int, void> glRenderbufferStorage;
		
		public static void RenderbufferStorage(RenderbufferTarget target, InternalFormat internalformat, int width, int height)
		{
			glRenderbufferStorage(target, internalformat, width, height);
		}
		
		[MethodImport("glGetRenderbufferParameteriv", "3.0")]
		private static delegate*<RenderbufferTarget, RenderbufferParameterName, int*, void> glGetRenderbufferParameteriv;
		
		public static void GetRenderbufferParameteriv(RenderbufferTarget target, RenderbufferParameterName pname, int* @params)
		{
			glGetRenderbufferParameteriv(target, pname, @params);
		}
		
		[MethodImport("glIsFramebuffer", "3.0")]
		private static delegate*<uint, bool> glIsFramebuffer;
		
		public static bool IsFramebuffer(uint framebuffer)
		{
			return glIsFramebuffer(framebuffer);
		}
		
		[MethodImport("glBindFramebuffer", "3.0")]
		private static delegate*<FramebufferTarget, uint, void> glBindFramebuffer;
		
		public static void BindFramebuffer(FramebufferTarget target, uint framebuffer)
		{
			glBindFramebuffer(target, framebuffer);
		}
		
		[MethodImport("glDeleteFramebuffers", "3.0")]
		private static delegate*<int, uint*, void> glDeleteFramebuffers;
		
		public static void DeleteFramebuffers(int n, uint* framebuffers)
		{
			glDeleteFramebuffers(n, framebuffers);
		}
		
		[MethodImport("glGenFramebuffers", "3.0")]
		private static delegate*<int, uint*, void> glGenFramebuffers;
		
		public static void GenFramebuffers(int n, uint* framebuffers)
		{
			glGenFramebuffers(n, framebuffers);
		}
		
		[MethodImport("glCheckFramebufferStatus", "3.0")]
		private static delegate*<FramebufferTarget, FramebufferStatus> glCheckFramebufferStatus;
		
		public static FramebufferStatus CheckFramebufferStatus(FramebufferTarget target)
		{
			return glCheckFramebufferStatus(target);
		}
		
		[MethodImport("glFramebufferTexture1D", "3.0")]
		private static delegate*<FramebufferTarget, FramebufferAttachment, TextureTarget, uint, int, void> glFramebufferTexture1D;
		
		public static void FramebufferTexture1D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level)
		{
			glFramebufferTexture1D(target, attachment, textarget, texture, level);
		}
		
		[MethodImport("glFramebufferTexture2D", "3.0")]
		private static delegate*<FramebufferTarget, FramebufferAttachment, TextureTarget, uint, int, void> glFramebufferTexture2D;
		
		public static void FramebufferTexture2D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level)
		{
			glFramebufferTexture2D(target, attachment, textarget, texture, level);
		}
		
		[MethodImport("glFramebufferTexture3D", "3.0")]
		private static delegate*<FramebufferTarget, FramebufferAttachment, TextureTarget, uint, int, int, void> glFramebufferTexture3D;
		
		public static void FramebufferTexture3D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level, int zoffset)
		{
			glFramebufferTexture3D(target, attachment, textarget, texture, level, zoffset);
		}
		
		[MethodImport("glFramebufferRenderbuffer", "3.0")]
		private static delegate*<FramebufferTarget, FramebufferAttachment, RenderbufferTarget, uint, void> glFramebufferRenderbuffer;
		
		public static void FramebufferRenderbuffer(FramebufferTarget target, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, uint renderbuffer)
		{
			glFramebufferRenderbuffer(target, attachment, renderbuffertarget, renderbuffer);
		}
		
		[MethodImport("glGetFramebufferAttachmentParameteriv", "3.0")]
		private static delegate*<FramebufferTarget, FramebufferAttachment, FramebufferAttachmentParameterName, int*, void> glGetFramebufferAttachmentParameteriv;
		
		public static void GetFramebufferAttachmentParameteriv(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, int* @params)
		{
			glGetFramebufferAttachmentParameteriv(target, attachment, pname, @params);
		}
		
		[MethodImport("glGenerateMipmap", "3.0")]
		private static delegate*<TextureTarget, void> glGenerateMipmap;
		
		public static void GenerateMipmap(TextureTarget target)
		{
			glGenerateMipmap(target);
		}
		
		[MethodImport("glBlitFramebuffer", "3.0")]
		private static delegate*<int, int, int, int, int, int, int, int, ClearBufferMask, BlitFramebufferFilter, void> glBlitFramebuffer;
		
		public static void BlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, BlitFramebufferFilter filter)
		{
			glBlitFramebuffer(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
		}
		
		[MethodImport("glRenderbufferStorageMultisample", "3.0")]
		private static delegate*<RenderbufferTarget, int, InternalFormat, int, int, void> glRenderbufferStorageMultisample;
		
		public static void RenderbufferStorageMultisample(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height)
		{
			glRenderbufferStorageMultisample(target, samples, internalformat, width, height);
		}
		
		[MethodImport("glFramebufferTextureLayer", "3.0")]
		private static delegate*<FramebufferTarget, FramebufferAttachment, uint, int, int, void> glFramebufferTextureLayer;
		
		public static void FramebufferTextureLayer(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level, int layer)
		{
			glFramebufferTextureLayer(target, attachment, texture, level, layer);
		}
		
		[MethodImport("glMapBufferRange", "3.0")]
		private static delegate*<BufferTargetARB, IntPtr, IntPtr, MapBufferAccessMask, void> glMapBufferRange;
		
		public static void MapBufferRange(BufferTargetARB target, IntPtr offset, IntPtr length, MapBufferAccessMask access)
		{
			glMapBufferRange(target, offset, length, access);
		}
		
		[MethodImport("glFlushMappedBufferRange", "3.0")]
		private static delegate*<BufferTargetARB, IntPtr, IntPtr, void> glFlushMappedBufferRange;
		
		public static void FlushMappedBufferRange(BufferTargetARB target, IntPtr offset, IntPtr length)
		{
			glFlushMappedBufferRange(target, offset, length);
		}
		
		[MethodImport("glBindVertexArray", "3.0")]
		private static delegate*<uint, void> glBindVertexArray;
		
		public static void BindVertexArray(uint array)
		{
			glBindVertexArray(array);
		}
		
		[MethodImport("glDeleteVertexArrays", "3.0")]
		private static delegate*<int, uint*, void> glDeleteVertexArrays;
		
		public static void DeleteVertexArrays(int n, uint* arrays)
		{
			glDeleteVertexArrays(n, arrays);
		}
		
		[MethodImport("glGenVertexArrays", "3.0")]
		private static delegate*<int, uint*, void> glGenVertexArrays;
		
		public static void GenVertexArrays(int n, uint* arrays)
		{
			glGenVertexArrays(n, arrays);
		}
		
		[MethodImport("glIsVertexArray", "3.0")]
		private static delegate*<uint, bool> glIsVertexArray;
		
		public static bool IsVertexArray(uint array)
		{
			return glIsVertexArray(array);
		}
	}
}

