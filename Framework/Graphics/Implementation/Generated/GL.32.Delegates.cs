using System;
using System.Runtime.InteropServices;
using CC = System.Runtime.InteropServices.CallingConvention;
using UFP = System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute;

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[UFP(CC.Cdecl)]
		private unsafe delegate void DrawElementsBaseVertexDelegate(uint mode,int count,uint type,IntPtr indices,int basevertex);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void DrawRangeElementsBaseVertexDelegate(uint mode,uint start,uint end,int count,uint type,IntPtr indices,int basevertex);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void DrawElementsInstancedBaseVertexDelegate(uint mode,int count,uint type,IntPtr indices,int instanceCount,int basevertex);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void MultiDrawElementsBaseVertexDelegate(uint mode,ref int count,uint type,IntPtr indices,int drawcount,ref int basevertex);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void ProvokingVertexDelegate(uint mode);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate IntPtr FenceSyncDelegate(uint condition,uint flags);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate byte IsSyncDelegate(IntPtr sync);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void DeleteSyncDelegate(IntPtr sync);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate uint ClientWaitSyncDelegate(IntPtr sync,uint flags,uint timeout);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void WaitSyncDelegate(IntPtr sync,uint flags,uint timeout);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void GetInteger64vDelegate(uint pName,ref int data);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void GetSyncivDelegate(IntPtr sync,uint pName,int bufSize,ref int length,ref int values);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void GetInteger64i_vDelegate(uint target,uint index,ref long data);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void GetBufferParameteri64vDelegate(BufferTarget target,uint pName,ref long parameters);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void FramebufferTextureDelegate(FramebufferTarget target,FramebufferAttachment attachment,uint texture,int level);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void TexImage2DMultisampleDelegate(TextureTarget target,int samples,PixelInternalFormat internalFormat,int width,int height,byte fixedsamplelocations);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void TexImage3DMultisampleDelegate(TextureTarget target,int samples,PixelInternalFormat internalFormat,int width,int height,int depth,byte fixedsamplelocations);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void GetMultisamplefvDelegate(uint pName,uint index,ref float val);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void SampleMaskiDelegate(uint maskNumber,uint mask);
	}
}
