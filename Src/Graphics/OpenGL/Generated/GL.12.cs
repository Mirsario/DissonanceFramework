using System;

namespace Dissonance.Framework.Graphics.OpenGL
{
	unsafe partial class GL
	{
		[MethodImport("glDrawRangeElements", "1.2")]
		private static delegate*<PrimitiveType, uint, uint, int, DrawElementsType, void*, void> glDrawRangeElements;
		
		public static void DrawRangeElements(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, void* indices)
		{
			glDrawRangeElements(mode, start, end, count, type, indices);
		}
		
		[MethodImport("glTexImage3D", "1.2")]
		private static delegate*<TextureTarget, int, int, int, int, int, int, PixelFormat, PixelType, void*, void> glTexImage3D;
		
		public static void TexImage3D(TextureTarget target, int level, int internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, void* pixels)
		{
			glTexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixels);
		}
		
		[MethodImport("glTexSubImage3D", "1.2")]
		private static delegate*<TextureTarget, int, int, int, int, int, int, int, PixelFormat, PixelType, void*, void> glTexSubImage3D;
		
		public static void TexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, void* pixels)
		{
			glTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
		}
		
		[MethodImport("glCopyTexSubImage3D", "1.2")]
		private static delegate*<TextureTarget, int, int, int, int, int, int, int, int, void> glCopyTexSubImage3D;
		
		public static void CopyTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height)
		{
			glCopyTexSubImage3D(target, level, xoffset, yoffset, zoffset, x, y, width, height);
		}
	}
}

