using System;
using System.Runtime.InteropServices;
using CC = System.Runtime.InteropServices.CallingConvention;
using UFP = System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute;

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[UFP(CC.Cdecl)]
		private unsafe delegate void ColorMaskiDelegate(uint index,byte r,byte g,byte b,byte a);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void GetBooleani_vDelegate(uint target,uint index,IntPtr data);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void GetIntegeri_vDelegate(uint target,uint index,ref int data);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate IntPtr GetStringiDelegate(uint name,uint index);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void EnableiDelegate(uint target,uint index);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void DisableiDelegate(uint target,uint index);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate byte IsEnablediDelegate(uint target,uint index);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void BeginTransformFeedbackDelegate(uint primitiveMode);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void EndTransformFeedbackDelegate();
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void BindBufferRangeDelegate(BufferRangeTarget target,uint index,uint buffer,int offset,int size);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void BindBufferBaseDelegate(BufferRangeTarget target,uint index,uint buffer);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void TransformFeedbackVaryingsDelegate(uint program,int count,IntPtr varyings,uint bufferMode);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void GetTransformFeedbackVaryingDelegate(uint program,uint index,int bufSize,ref int length,ref int size,ref uint type,IntPtr name);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void ClampColorDelegate(uint target,uint clamp);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void BeginConditionalRenderDelegate(uint id,uint mode);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void EndConditionalRenderDelegate();
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttribIPointerDelegate(uint index,int size,uint type,int stride,IntPtr pointer);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void GetVertexAttribIivDelegate(uint index,uint pName,ref int parameters);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void GetVertexAttribIuivDelegate(uint index,uint pName,ref uint parameters);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttribI1iDelegate(uint index,int x);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttribI2iDelegate(uint index,int x,int y);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttribI3iDelegate(uint index,int x,int y,int z);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttribI4iDelegate(uint index,int x,int y,int z,int w);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttribI1uiDelegate(uint index,uint x);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttribI2uiDelegate(uint index,uint x,uint y);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttribI3uiDelegate(uint index,uint x,uint y,uint z);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttribI4uiDelegate(uint index,uint x,uint y,uint z,uint w);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttribI1ivDelegate(uint index,ref int v);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttribI2ivDelegate(uint index,ref int v);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttribI3ivDelegate(uint index,ref int v);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttribI4ivDelegate(uint index,ref int v);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttribI1uivDelegate(uint index,ref uint v);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttribI2uivDelegate(uint index,ref uint v);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttribI3uivDelegate(uint index,ref uint v);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttribI4uivDelegate(uint index,ref uint v);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttribI4bvDelegate(uint index,sbyte[] v);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttribI4svDelegate(uint index,ref short v);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttribI4ubvDelegate(uint index,byte[] v);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttribI4usvDelegate(uint index,ref ushort v);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void GetUniformuivDelegate(uint program,int location,ref uint parameters);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void BindFragDataLocationDelegate(uint program,uint color,IntPtr name);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate int GetFragDataLocationDelegate(uint program,IntPtr name);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void Uniform1uiDelegate(int location,uint v0);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void Uniform2uiDelegate(int location,uint v0,uint v1);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void Uniform3uiDelegate(int location,uint v0,uint v1,uint v2);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void Uniform4uiDelegate(int location,uint v0,uint v1,uint v2,uint v3);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void Uniform1uivDelegate(int location,int count,ref uint value);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void Uniform2uivDelegate(int location,int count,ref uint value);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void Uniform3uivDelegate(int location,int count,ref uint value);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void Uniform4uivDelegate(int location,int count,ref uint value);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void TexParameterIivDelegate(TextureTarget target,uint pName,ref int parameters);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void TexParameterIuivDelegate(TextureTarget target,uint pName,ref uint parameters);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void GetTexParameterIivDelegate(TextureTarget target,GetTextureParameter parameterName,ref int parameters);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void GetTexParameterIuivDelegate(TextureTarget target,GetTextureParameter parameterName,ref uint parameters);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void ClearBufferivDelegate(uint buffer,int drawbuffer,ref int value);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void ClearBufferuivDelegate(uint buffer,int drawbuffer,ref uint value);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void ClearBufferfvDelegate(uint buffer,int drawbuffer,ref float value);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void ClearBufferfiDelegate(uint buffer,int drawbuffer,float depth,int stencil);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate byte IsRenderbufferDelegate(uint renderbuffer);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void BindRenderbufferDelegate(RenderbufferTarget target,uint renderbuffer);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void DeleteRenderbuffersDelegate(int numRenderbuffers,uint* renderbuffers);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void GenRenderbuffersDelegate(int numRenderbuffers,uint* renderbuffers);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void RenderbufferStorageDelegate(RenderbufferTarget target,RenderbufferStorage internalFormat,int width,int height);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void GetRenderbufferParameterivDelegate(uint target,uint pName,ref int parameters);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate byte IsFramebufferDelegate(uint framebuffer);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void BindFramebufferDelegate(FramebufferTarget target,uint framebuffer);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void DeleteFramebuffersDelegate(int n,[Out] uint* framebuffers);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void GenFramebuffersDelegate(int numFramebuffers,[Out] uint* framebuffers);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate FramebufferStatus CheckFramebufferStatusDelegate(FramebufferTarget target);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void FramebufferTexture1DDelegate(FramebufferTarget target,FramebufferAttachment attachment,TextureTarget texTarget,uint texture,int level);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void FramebufferTexture2DDelegate(FramebufferTarget target,FramebufferAttachment attachment,TextureTarget texTarget,uint texture,int level);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void FramebufferTexture3DDelegate(FramebufferTarget target,FramebufferAttachment attachment,TextureTarget texTarget,uint texture,int level,int zOffset);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void FramebufferRenderbufferDelegate(FramebufferTarget target,FramebufferAttachment attachment,RenderbufferTarget renderbuffertarget,uint renderbuffer);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void GetFramebufferAttachmentParameterivDelegate(FramebufferTarget target,FramebufferAttachment attachment,uint pName,ref int parameters);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void GenerateMipmapDelegate(GenerateMipmapTarget target);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void BlitFramebufferDelegate(int srcX0,int srcY0,int srcX1,int srcY1,int dstX0,int dstY0,int dstX1,int dstY1,ClearBufferMask mask,BlitFramebufferFilter filter);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void RenderbufferStorageMultisampleDelegate(uint target,int samples,uint internalFormat,int width,int height);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void FramebufferTextureLayerDelegate(FramebufferTarget target,FramebufferAttachment attachment,uint texture,int level,int layer);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate IntPtr MapBufferRangeDelegate(BufferTarget target,int offset,int length,uint access);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void FlushMappedBufferRangeDelegate(BufferTarget target,int offset,int length);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void BindVertexArrayDelegate(uint array);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void DeleteVertexArraysDelegate(int numArrays,uint* arrays);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void GenVertexArraysDelegate(int numArrays,uint* arrays);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate byte IsVertexArrayDelegate(uint array);
	}
}
