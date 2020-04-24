using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[MethodImpl(ImplOptions)]
		public unsafe static void ColorMask(uint index,byte r,byte g,byte b,byte a)
			=> glColorMaski(index,r,g,b,a);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetBoolean(uint target,uint index,IntPtr data)
			=> glGetBooleani_v(target,index,data);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetInteger(uint target,uint index,ref int data)
			=> glGetIntegeri_v(target,index,ref data);
		
		[MethodImpl(ImplOptions)]
		public unsafe static IntPtr GetStringPtr(uint name,uint index)
			=> glGetStringi(name,index);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Enable(uint target,uint index)
			=> glEnablei(target,index);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Disable(uint target,uint index)
			=> glDisablei(target,index);
		
		[MethodImpl(ImplOptions)]
		public unsafe static byte IsEnabled(uint target,uint index)
			=> glIsEnabledi(target,index);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void BeginTransformFeedback(uint primitiveMode)
			=> glBeginTransformFeedback(primitiveMode);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void EndTransformFeedback()
			=> glEndTransformFeedback();
		
		[MethodImpl(ImplOptions)]
		public unsafe static void BindBufferRange(BufferRangeTarget target,uint index,uint buffer,int offset,int size)
			=> glBindBufferRange(target,index,buffer,offset,size);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void BindBufferBase(BufferRangeTarget target,uint index,uint buffer)
			=> glBindBufferBase(target,index,buffer);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TransformFeedbackVaryings(uint program,int count,IntPtr varyings,uint bufferMode)
			=> glTransformFeedbackVaryings(program,count,varyings,bufferMode);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetTransformFeedbackVarying(uint program,uint index,int bufSize,ref int length,ref int size,ref uint type,IntPtr name)
			=> glGetTransformFeedbackVarying(program,index,bufSize,ref length,ref size,ref type,name);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ClampColor(uint target,uint clamp)
			=> glClampColor(target,clamp);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void BeginConditionalRender(uint id,uint mode)
			=> glBeginConditionalRender(id,mode);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void EndConditionalRender()
			=> glEndConditionalRender();
		
		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttribIPointer(uint index,int size,uint type,int stride,IntPtr pointer)
			=> glVertexAttribIPointer(index,size,type,stride,pointer);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetVertexAttribI(uint index,uint pName,ref int parameters)
			=> glGetVertexAttribIiv(index,pName,ref parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetVertexAttribI(uint index,uint pName,ref uint parameters)
			=> glGetVertexAttribIuiv(index,pName,ref parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttribI1(uint index,int x)
			=> glVertexAttribI1i(index,x);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttribI2(uint index,int x,int y)
			=> glVertexAttribI2i(index,x,y);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttribI3(uint index,int x,int y,int z)
			=> glVertexAttribI3i(index,x,y,z);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttribI4(uint index,int x,int y,int z,int w)
			=> glVertexAttribI4i(index,x,y,z,w);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttribI1(uint index,uint x)
			=> glVertexAttribI1ui(index,x);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttribI2(uint index,uint x,uint y)
			=> glVertexAttribI2ui(index,x,y);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttribI3(uint index,uint x,uint y,uint z)
			=> glVertexAttribI3ui(index,x,y,z);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttribI4(uint index,uint x,uint y,uint z,uint w)
			=> glVertexAttribI4ui(index,x,y,z,w);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttribI1(uint index,ref int v)
			=> glVertexAttribI1iv(index,ref v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttribI2(uint index,ref int v)
			=> glVertexAttribI2iv(index,ref v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttribI3(uint index,ref int v)
			=> glVertexAttribI3iv(index,ref v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttribI4(uint index,ref int v)
			=> glVertexAttribI4iv(index,ref v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttribI1(uint index,ref uint v)
			=> glVertexAttribI1uiv(index,ref v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttribI2(uint index,ref uint v)
			=> glVertexAttribI2uiv(index,ref v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttribI3(uint index,ref uint v)
			=> glVertexAttribI3uiv(index,ref v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttribI4(uint index,ref uint v)
			=> glVertexAttribI4uiv(index,ref v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttribI4(uint index,sbyte[] v)
			=> glVertexAttribI4bv(index,v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttribI4(uint index,ref short v)
			=> glVertexAttribI4sv(index,ref v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttribI4(uint index,byte[] v)
			=> glVertexAttribI4ubv(index,v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttribI4(uint index,ref ushort v)
			=> glVertexAttribI4usv(index,ref v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetUniform(uint program,int location,ref uint parameters)
			=> glGetUniformuiv(program,location,ref parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void BindFragDataLocation(uint program,uint color,IntPtr name)
			=> glBindFragDataLocation(program,color,name);
		
		[MethodImpl(ImplOptions)]
		public unsafe static int GetFragDataLocation(uint program,IntPtr name)
			=> glGetFragDataLocation(program,name);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Uniform1(int location,uint v0)
			=> glUniform1ui(location,v0);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Uniform2(int location,uint v0,uint v1)
			=> glUniform2ui(location,v0,v1);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Uniform3(int location,uint v0,uint v1,uint v2)
			=> glUniform3ui(location,v0,v1,v2);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Uniform4(int location,uint v0,uint v1,uint v2,uint v3)
			=> glUniform4ui(location,v0,v1,v2,v3);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Uniform1(int location,int count,ref uint value)
			=> glUniform1uiv(location,count,ref value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Uniform2(int location,int count,ref uint value)
			=> glUniform2uiv(location,count,ref value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Uniform3(int location,int count,ref uint value)
			=> glUniform3uiv(location,count,ref value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Uniform4(int location,int count,ref uint value)
			=> glUniform4uiv(location,count,ref value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexParameterI(TextureTarget target,uint pName,ref int parameters)
			=> glTexParameterIiv(target,pName,ref parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexParameterI(TextureTarget target,uint pName,ref uint parameters)
			=> glTexParameterIuiv(target,pName,ref parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetTexParameterI(TextureTarget target,GetTextureParameter parameterName,ref int parameters)
			=> glGetTexParameterIiv(target,parameterName,ref parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetTexParameterI(TextureTarget target,GetTextureParameter parameterName,ref uint parameters)
			=> glGetTexParameterIuiv(target,parameterName,ref parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ClearBuffer(uint buffer,int drawbuffer,ref int value)
			=> glClearBufferiv(buffer,drawbuffer,ref value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ClearBuffer(uint buffer,int drawbuffer,ref uint value)
			=> glClearBufferuiv(buffer,drawbuffer,ref value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ClearBuffer(uint buffer,int drawbuffer,ref float value)
			=> glClearBufferfv(buffer,drawbuffer,ref value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ClearBuffer(uint buffer,int drawbuffer,float depth,int stencil)
			=> glClearBufferfi(buffer,drawbuffer,depth,stencil);
		
		[MethodImpl(ImplOptions)]
		public unsafe static byte IsRenderbuffer(uint renderbuffer)
			=> glIsRenderbuffer(renderbuffer);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void BindRenderbuffer(RenderbufferTarget target,uint renderbuffer)
			=> glBindRenderbuffer(target,renderbuffer);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void DeleteRenderbuffers(int numRenderbuffers,uint* renderbuffers)
			=> glDeleteRenderbuffers(numRenderbuffers,renderbuffers);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GenRenderbuffers(int numRenderbuffers,uint* renderbuffers)
			=> glGenRenderbuffers(numRenderbuffers,renderbuffers);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void RenderbufferStorage(RenderbufferTarget target,RenderbufferStorage internalFormat,int width,int height)
			=> glRenderbufferStorage(target,internalFormat,width,height);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetRenderbufferParameter(uint target,uint pName,ref int parameters)
			=> glGetRenderbufferParameteriv(target,pName,ref parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static byte IsFramebuffer(uint framebuffer)
			=> glIsFramebuffer(framebuffer);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void BindFramebuffer(FramebufferTarget target,uint framebuffer)
			=> glBindFramebuffer(target,framebuffer);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void DeleteFramebuffers(int n,[Out] uint* framebuffers)
			=> glDeleteFramebuffers(n,framebuffers);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GenFramebuffers(int numFramebuffers,[Out] uint* framebuffers)
			=> glGenFramebuffers(numFramebuffers,framebuffers);
		
		[MethodImpl(ImplOptions)]
		public unsafe static FramebufferStatus CheckFramebufferStatus(FramebufferTarget target)
			=> glCheckFramebufferStatus(target);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void FramebufferTexture1D(FramebufferTarget target,FramebufferAttachment attachment,TextureTarget texTarget,uint texture,int level)
			=> glFramebufferTexture1D(target,attachment,texTarget,texture,level);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void FramebufferTexture2D(FramebufferTarget target,FramebufferAttachment attachment,TextureTarget texTarget,uint texture,int level)
			=> glFramebufferTexture2D(target,attachment,texTarget,texture,level);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void FramebufferTexture3D(FramebufferTarget target,FramebufferAttachment attachment,TextureTarget texTarget,uint texture,int level,int zOffset)
			=> glFramebufferTexture3D(target,attachment,texTarget,texture,level,zOffset);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void FramebufferRenderbuffer(FramebufferTarget target,FramebufferAttachment attachment,RenderbufferTarget renderbuffertarget,uint renderbuffer)
			=> glFramebufferRenderbuffer(target,attachment,renderbuffertarget,renderbuffer);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetFramebufferAttachmentParameter(FramebufferTarget target,FramebufferAttachment attachment,uint pName,ref int parameters)
			=> glGetFramebufferAttachmentParameteriv(target,attachment,pName,ref parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GenerateMipmap(GenerateMipmapTarget target)
			=> glGenerateMipmap(target);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void BlitFramebuffer(int srcX0,int srcY0,int srcX1,int srcY1,int dstX0,int dstY0,int dstX1,int dstY1,ClearBufferMask mask,BlitFramebufferFilter filter)
			=> glBlitFramebuffer(srcX0,srcY0,srcX1,srcY1,dstX0,dstY0,dstX1,dstY1,mask,filter);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void RenderbufferStorageMultisample(uint target,int samples,uint internalFormat,int width,int height)
			=> glRenderbufferStorageMultisample(target,samples,internalFormat,width,height);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void FramebufferTextureLayer(FramebufferTarget target,FramebufferAttachment attachment,uint texture,int level,int layer)
			=> glFramebufferTextureLayer(target,attachment,texture,level,layer);
		
		[MethodImpl(ImplOptions)]
		public unsafe static IntPtr MapBufferRange(BufferTarget target,int offset,int length,uint access)
			=> glMapBufferRange(target,offset,length,access);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void FlushMappedBufferRange(BufferTarget target,int offset,int length)
			=> glFlushMappedBufferRange(target,offset,length);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void BindVertexArray(uint array)
			=> glBindVertexArray(array);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void DeleteVertexArrays(int numArrays,uint* arrays)
			=> glDeleteVertexArrays(numArrays,arrays);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GenVertexArrays(int numArrays,uint* arrays)
			=> glGenVertexArrays(numArrays,arrays);
		
		[MethodImpl(ImplOptions)]
		public unsafe static byte IsVertexArray(uint array)
			=> glIsVertexArray(array);
	}
}
