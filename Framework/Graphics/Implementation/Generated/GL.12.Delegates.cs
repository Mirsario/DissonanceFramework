using System;
using System.Runtime.InteropServices;
using CC = System.Runtime.InteropServices.CallingConvention;
using UFP = System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute;

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[UFP(CC.Cdecl)]
		private unsafe delegate void DrawRangeElementsDelegate(uint mode,uint start,uint end,int count,uint type,IntPtr indices);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void TexImage3DDelegate(TextureTarget target,int level,PixelInternalFormat internalFormat,int width,int height,int depth,int border,PixelFormat format,PixelType type,IntPtr pixels);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void TexSubImage3DDelegate(TextureTarget target,int level,int xOffset,int yOffset,int zOffset,int width,int height,int depth,PixelFormat format,PixelType type,IntPtr pixels);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void CopyTexSubImage3DDelegate(TextureTarget target,int level,int xOffset,int yOffset,int zOffset,int x,int y,int width,int height);
	}
}
