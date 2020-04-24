using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[MethodImpl(ImplOptions)]
		public unsafe static void DrawRangeElements(uint mode,uint start,uint end,int count,uint type,IntPtr indices)
			=> glDrawRangeElements(mode,start,end,count,type,indices);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexImage3D(TextureTarget target,int level,PixelInternalFormat internalFormat,int width,int height,int depth,int border,PixelFormat format,PixelType type,IntPtr pixels)
			=> glTexImage3D(target,level,internalFormat,width,height,depth,border,format,type,pixels);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexSubImage3D(TextureTarget target,int level,int xOffset,int yOffset,int zOffset,int width,int height,int depth,PixelFormat format,PixelType type,IntPtr pixels)
			=> glTexSubImage3D(target,level,xOffset,yOffset,zOffset,width,height,depth,format,type,pixels);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void CopyTexSubImage3D(TextureTarget target,int level,int xOffset,int yOffset,int zOffset,int x,int y,int width,int height)
			=> glCopyTexSubImage3D(target,level,xOffset,yOffset,zOffset,x,y,width,height);
	}
}
