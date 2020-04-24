using System;
using System.Runtime.InteropServices;
using CC = System.Runtime.InteropServices.CallingConvention;
using UFP = System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute;

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[UFP(CC.Cdecl)]
		private unsafe delegate void ClearBufferDataDelegate(BufferTarget target,PixelInternalFormat internalFormat,PixelFormat format,PixelType type,IntPtr data);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void ClearBufferSubDataDelegate(BufferTarget target,PixelInternalFormat internalFormat,int offset,int size,PixelFormat format,PixelType type,IntPtr data);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void DispatchComputeDelegate(uint num_groups_x,uint num_groups_y,uint num_groups_z);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void DispatchComputeIndirectDelegate(int indirect);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void CopyImageSubDataDelegate(uint srcName,uint srcTarget,int srcLevel,int srcX,int srcY,int srcZ,uint dstName,uint dstTarget,int dstLevel,int dstX,int dstY,int dstZ,int srcWidth,int srcHeight,int srcDepth);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void FramebufferParameteriDelegate(FramebufferTarget target,uint pName,int param);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void GetFramebufferParameterivDelegate(FramebufferTarget target,uint pName,ref int parameters);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void GetInternalformati64vDelegate(uint target,uint internalFormat,uint pName,int bufSize,ref long parameters);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void InvalidateTexSubImageDelegate(uint texture,int level,int xOffset,int yOffset,int zOffset,int width,int height,int depth);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void InvalidateTexImageDelegate(uint texture,int level);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void InvalidateBufferSubDataDelegate(uint buffer,int offset,int length);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void InvalidateBufferDataDelegate(uint buffer);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void InvalidateFramebufferDelegate(FramebufferTarget target,int numAttachments,FramebufferAttachment* attachments);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void InvalidateSubFramebufferDelegate(FramebufferTarget target,int numAttachments,FramebufferAttachment* attachments,int x,int y,int width,int height);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void MultiDrawArraysIndirectDelegate(uint mode,IntPtr indirect,int drawcount,int stride);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void MultiDrawElementsIndirectDelegate(uint mode,uint type,IntPtr indirect,int drawcount,int stride);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void GetProgramInterfaceivDelegate(uint program,uint programInterface,uint pName,ref int parameters);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate uint GetProgramResourceIndexDelegate(uint program,uint programInterface,IntPtr name);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void GetProgramResourceNameDelegate(uint program,uint programInterface,uint index,int bufSize,ref int length,IntPtr name);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void GetProgramResourceivDelegate(uint program,uint programInterface,uint index,int propCount,ref uint props,int bufSize,ref int length,ref int parameters);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate int GetProgramResourceLocationDelegate(uint program,uint programInterface,IntPtr name);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate int GetProgramResourceLocationIndexDelegate(uint program,uint programInterface,IntPtr name);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void ShaderStorageBlockBindingDelegate(uint program,uint storageBlockIndex,uint storageBlockBinding);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void TexBufferRangeDelegate(TextureBufferTarget target,uint internalFormat,uint buffer,int offset,int size);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void TexStorage2DMultisampleDelegate(TextureTargetMultisample2D target,int samples,uint internalFormat,int width,int height,byte fixedsamplelocations);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void TexStorage3DMultisampleDelegate(TextureTargetMultisample3D target,int samples,uint internalFormat,int width,int height,int depth,byte fixedsamplelocations);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void TextureViewDelegate(uint texture,TextureTarget target,uint origtexture,PixelInternalFormat internalFormat,uint minlevel,uint numlevels,uint minlayer,uint numlayers);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void BindVertexBufferDelegate(uint bindingindex,uint buffer,int offset,int stride);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttribFormatDelegate(uint attribindex,int size,uint type,byte normalized,uint relativeoffset);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttribIFormatDelegate(uint attribindex,int size,uint type,uint relativeoffset);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttribLFormatDelegate(uint attribindex,int size,uint type,uint relativeoffset);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttribBindingDelegate(uint attribindex,uint bindingindex);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexBindingDivisorDelegate(uint bindingindex,uint divisor);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void DebugMessageControlDelegate(uint source,uint type,uint severity,int count,ref uint ids,byte enabled);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void DebugMessageInsertDelegate(uint source,uint type,uint id,uint severity,int length,IntPtr buf);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void DebugMessageCallbackDelegate(DebugCallback callback,IntPtr userParameter);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate uint GetDebugMessageLogDelegate(uint count,int bufSize,ref uint sources,ref uint types,ref uint ids,ref uint severities,ref int lengths,IntPtr messageLog);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void PushDebugGroupDelegate(uint source,uint id,int length,IntPtr message);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void PopDebugGroupDelegate();
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void ObjectLabelDelegate(uint identifier,uint name,int length,IntPtr label);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void GetObjectLabelDelegate(uint identifier,uint name,int bufSize,ref int length,IntPtr label);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void ObjectPtrLabelDelegate(IntPtr ptr,int length,IntPtr label);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void GetObjectPtrLabelDelegate(IntPtr ptr,int bufSize,ref int length,IntPtr label);
	}
}
