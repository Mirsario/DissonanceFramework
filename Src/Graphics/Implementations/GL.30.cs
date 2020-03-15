using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#pragma warning disable IDE0060 //Unused parameter.

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[MethodImpl(ImplOptions)]
		[MethodImport("glColorMaski","3.0")]
		public static void ColorMask(uint index,byte r,byte g,byte b,byte a)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetBooleani_v","3.0")]
		public static void GetBoolean(uint target,uint index,IntPtr data)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetIntegeri_v","3.0")]
		public static void GetInteger(uint target,uint index,ref int data)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glEnablei","3.0")]
		public static void Enable(uint target,uint index)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glDisablei","3.0")]
		public static void Disable(uint target,uint index)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glIsEnabledi","3.0")]
		public static byte IsEnabled(uint target,uint index)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glBeginTransformFeedback","3.0")]
		public static void BeginTransformFeedback(uint primitiveMode)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glEndTransformFeedback","3.0")]
		public static void EndTransformFeedback()
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glBindBufferRange","3.0")]
		public static void BindBufferRange(BufferRangeTarget target,uint index,uint buffer,int offset,int size)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glBindBufferBase","3.0")]
		public static void BindBufferBase(BufferRangeTarget target,uint index,uint buffer)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glTransformFeedbackVaryings","3.0")]
		public static void TransformFeedbackVaryings(uint program,int count,IntPtr varyings,uint bufferMode)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetTransformFeedbackVarying","3.0")]
		public static void GetTransformFeedbackVarying(uint program,uint index,int bufSize,ref int length,ref int size,ref uint type,IntPtr name)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glClampColor","3.0")]
		public static void ClampColor(uint target,uint clamp)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glBeginConditionalRender","3.0")]
		public static void BeginConditionalRender(uint id,uint mode)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glEndConditionalRender","3.0")]
		public static void EndConditionalRender()
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glVertexAttribIPointer","3.0")]
		public static void VertexAttribIPointer(uint index,int size,uint type,int stride,IntPtr pointer)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetVertexAttribIiv","3.0")]
		public static void GetVertexAttribI(uint index,uint pName,ref int parameters)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetVertexAttribIuiv","3.0")]
		public static void GetVertexAttribI(uint index,uint pName,ref uint parameters)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glVertexAttribI1i","3.0")]
		public static void VertexAttribI1(uint index,int x)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glVertexAttribI2i","3.0")]
		public static void VertexAttribI2(uint index,int x,int y)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glVertexAttribI3i","3.0")]
		public static void VertexAttribI3(uint index,int x,int y,int z)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glVertexAttribI4i","3.0")]
		public static void VertexAttribI4(uint index,int x,int y,int z,int w)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glVertexAttribI1ui","3.0")]
		public static void VertexAttribI1(uint index,uint x)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glVertexAttribI2ui","3.0")]
		public static void VertexAttribI2(uint index,uint x,uint y)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glVertexAttribI3ui","3.0")]
		public static void VertexAttribI3(uint index,uint x,uint y,uint z)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glVertexAttribI4ui","3.0")]
		public static void VertexAttribI4(uint index,uint x,uint y,uint z,uint w)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glVertexAttribI1iv","3.0")]
		public static void VertexAttribI1(uint index,ref int v)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glVertexAttribI2iv","3.0")]
		public static void VertexAttribI2(uint index,ref int v)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glVertexAttribI3iv","3.0")]
		public static void VertexAttribI3(uint index,ref int v)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glVertexAttribI4iv","3.0")]
		public static void VertexAttribI4(uint index,ref int v)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glVertexAttribI1uiv","3.0")]
		public static void VertexAttribI1(uint index,ref uint v)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glVertexAttribI2uiv","3.0")]
		public static void VertexAttribI2(uint index,ref uint v)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glVertexAttribI3uiv","3.0")]
		public static void VertexAttribI3(uint index,ref uint v)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glVertexAttribI4uiv","3.0")]
		public static void VertexAttribI4(uint index,ref uint v)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glVertexAttribI4bv","3.0")]
		public static void VertexAttribI4(uint index,sbyte[] v)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glVertexAttribI4sv","3.0")]
		public static void VertexAttribI4(uint index,ref short v)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glVertexAttribI4ubv","3.0")]
		public static void VertexAttribI4(uint index,byte[] v)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glVertexAttribI4usv","3.0")]
		public static void VertexAttribI4(uint index,ref ushort v)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetUniformuiv","3.0")]
		public static void GetUniform(uint program,int location,ref uint parameters)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glBindFragDataLocation","3.0")]
		public static void BindFragDataLocation(uint program,uint color,IntPtr name)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetFragDataLocation","3.0")]
		public static int GetFragDataLocation(uint program,IntPtr name)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glUniform1ui","3.0")]
		public static void Uniform1(int location,uint v0)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glUniform2ui","3.0")]
		public static void Uniform2(int location,uint v0,uint v1)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glUniform3ui","3.0")]
		public static void Uniform3(int location,uint v0,uint v1,uint v2)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glUniform4ui","3.0")]
		public static void Uniform4(int location,uint v0,uint v1,uint v2,uint v3)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glUniform1uiv","3.0")]
		public static void Uniform1(int location,int count,ref uint value)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glUniform2uiv","3.0")]
		public static void Uniform2(int location,int count,ref uint value)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glUniform3uiv","3.0")]
		public static void Uniform3(int location,int count,ref uint value)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glUniform4uiv","3.0")]
		public static void Uniform4(int location,int count,ref uint value)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glTexParameterIiv","3.0")]
		public static void TexParameterI(TextureTarget target,uint pName,ref int parameters)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glTexParameterIuiv","3.0")]
		public static void TexParameterI(TextureTarget target,uint pName,ref uint parameters)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetTexParameterIiv","3.0")]
		public static void GetTexParameterI(TextureTarget target,GetTextureParameter parameterName,ref int parameters)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetTexParameterIuiv","3.0")]
		public static void GetTexParameterI(TextureTarget target,GetTextureParameter parameterName,ref uint parameters)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glClearBufferiv","3.0")]
		public static void ClearBuffer(uint buffer,int drawbuffer,ref int value)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glClearBufferuiv","3.0")]
		public static void ClearBuffer(uint buffer,int drawbuffer,ref uint value)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glClearBufferfv","3.0")]
		public static void ClearBuffer(uint buffer,int drawbuffer,ref float value)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glClearBufferfi","3.0")]
		public static void ClearBuffer(uint buffer,int drawbuffer,float depth,int stencil)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glIsRenderbuffer","3.0")]
		public static byte IsRenderbuffer(uint renderbuffer)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glBindRenderbuffer","3.0")]
		public static void BindRenderbuffer(RenderbufferTarget target,uint renderbuffer)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glDeleteRenderbuffers","3.0")]
		public unsafe static void DeleteRenderbuffers(int numRenderbuffers,uint* renderbuffers)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGenRenderbuffers","3.0")]
		public unsafe static void GenRenderbuffers(int numRenderbuffers,uint* renderbuffers)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glRenderbufferStorage","3.0")]
		public static void RenderbufferStorage(RenderbufferTarget target,RenderbufferStorage internalFormat,int width,int height)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetRenderbufferParameteriv","3.0")]
		public static void GetRenderbufferParameter(uint target,uint pName,ref int parameters)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glIsFramebuffer","3.0")]
		public static byte IsFramebuffer(uint framebuffer)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glBindFramebuffer","3.0")]
		public static void BindFramebuffer(FramebufferTarget target,uint framebuffer)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glDeleteFramebuffers","3.0")]
		public unsafe static void DeleteFramebuffers(int n,[Out] uint* framebuffers)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGenFramebuffers","3.0")]
		public unsafe static void GenFramebuffers(int numFramebuffers,[Out] uint* framebuffers)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glCheckFramebufferStatus","3.0")]
		public static FramebufferStatus CheckFramebufferStatus(FramebufferTarget target)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glFramebufferTexture1D","3.0")]
		public static void FramebufferTexture1D(FramebufferTarget target,FramebufferAttachment attachment,TextureTarget texTarget,uint texture,int level)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glFramebufferTexture2D","3.0")]
		public static void FramebufferTexture2D(FramebufferTarget target,FramebufferAttachment attachment,TextureTarget texTarget,uint texture,int level)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glFramebufferTexture3D","3.0")]
		public static void FramebufferTexture3D(FramebufferTarget target,FramebufferAttachment attachment,TextureTarget texTarget,uint texture,int level,int zOffset)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glFramebufferRenderbuffer","3.0")]
		public static void FramebufferRenderbuffer(FramebufferTarget target,FramebufferAttachment attachment,RenderbufferTarget renderbuffertarget,uint renderbuffer)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetFramebufferAttachmentParameteriv","3.0")]
		public static void GetFramebufferAttachmentParameter(FramebufferTarget target,FramebufferAttachment attachment,uint pName,ref int parameters)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGenerateMipmap","3.0")]
		public static void GenerateMipmap(GenerateMipmapTarget target)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glBlitFramebuffer","3.0")]
		public static void BlitFramebuffer(int srcX0,int srcY0,int srcX1,int srcY1,int dstX0,int dstY0,int dstX1,int dstY1,ClearBufferMask mask,BlitFramebufferFilter filter)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glRenderbufferStorageMultisample","3.0")]
		public static void RenderbufferStorageMultisample(uint target,int samples,uint internalFormat,int width,int height)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glFramebufferTextureLayer","3.0")]
		public static void FramebufferTextureLayer(FramebufferTarget target,FramebufferAttachment attachment,uint texture,int level,int layer)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glMapBufferRange","3.0")]
		public static IntPtr MapBufferRange(BufferTarget target,int offset,int length,uint access)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glFlushMappedBufferRange","3.0")]
		public static void FlushMappedBufferRange(BufferTarget target,int offset,int length)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glBindVertexArray","3.0")]
		public static void BindVertexArray(uint array)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glDeleteVertexArrays","3.0")]
		public static unsafe void DeleteVertexArrays(int numArrays,uint* arrays)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGenVertexArrays","3.0")]
		public static unsafe void GenVertexArrays(int numArrays,uint* arrays)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glIsVertexArray","3.0")]
		public static byte IsVertexArray(uint array)
			=> throw new NotImplementedException();

		//Internal functions. Used in GL.X.Helpers.cs

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetStringi","3.0")]
		private static IntPtr GetStringInternal(uint name,uint index)
			=> throw new NotImplementedException();
	}
}