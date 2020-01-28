using System;

#pragma warning disable IDE0060 //Unused parameter.

namespace Dissonance.Framework.OpenGL
{
	partial class GL
	{
		[MethodImport("glDrawRangeElements","1.2")]
		public static void DrawRangeElements(uint mode,uint start,uint end,int count,uint type,IntPtr indices)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexImage3D","1.2")]
		public static void TexImage3D(TextureTarget target,int level,PixelInternalFormat internalFormat,int width,int height,int depth,int border,PixelFormat format,PixelType type,IntPtr pixels)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexSubImage3D","1.2")]
		public static void TexSubImage3D(TextureTarget target,int level,int xOffset,int yOffset,int zOffset,int width,int height,int depth,PixelFormat format,PixelType type,IntPtr pixels)
			=> throw new NotImplementedException();
		
		[MethodImport("glCopyTexSubImage3D","1.2")]
		public static void CopyTexSubImage3D(TextureTarget target,int level,int xOffset,int yOffset,int zOffset,int x,int y,int width,int height)
			=> throw new NotImplementedException();
	}
}