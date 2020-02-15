using System;

#pragma warning disable IDE0060 //Unused parameter.

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[MethodImport("glActiveTexture","1.3")]
		public static void ActiveTexture(TextureUnit texture)
			=> throw new NotImplementedException();

		[MethodImport("glSampleCoverage","1.3")]
		public static void SampleCoverage(float value,byte invert)
			=> throw new NotImplementedException();

		[MethodImport("glCompressedTexImage3D","1.3")]
		public static void CompressedTexImage3D(TextureTarget target,int level,uint internalFormat,int width,int height,int depth,int border,int imageSize,IntPtr data)
			=> throw new NotImplementedException();

		[MethodImport("glCompressedTexImage2D","1.3")]
		public static void CompressedTexImage2D(TextureTarget target,int level,uint internalFormat,int width,int height,int border,int imageSize,IntPtr data)
			=> throw new NotImplementedException();

		[MethodImport("glCompressedTexImage1D","1.3")]
		public static void CompressedTexImage1D(TextureTarget target,int level,uint internalFormat,int width,int border,int imageSize,IntPtr data)
			=> throw new NotImplementedException();

		[MethodImport("glCompressedTexSubImage3D","1.3")]
		public static void CompressedTexSubImage3D(TextureTarget target,int level,int xOffset,int yOffset,int zOffset,int width,int height,int depth,uint format,int imageSize,IntPtr data)
			=> throw new NotImplementedException();

		[MethodImport("glCompressedTexSubImage2D","1.3")]
		public static void CompressedTexSubImage2D(TextureTarget target,int level,int xOffset,int yOffset,int width,int height,uint format,int imageSize,IntPtr data)
			=> throw new NotImplementedException();

		[MethodImport("glCompressedTexSubImage1D","1.3")]
		public static void CompressedTexSubImage1D(TextureTarget target,int level,int xOffset,int width,uint format,int imageSize,IntPtr data)
			=> throw new NotImplementedException();

		[MethodImport("glGetCompressedTexImage","1.3")]
		public static void GetCompressedTexImage(TextureTarget target,int level,IntPtr img)
			=> throw new NotImplementedException();
	}
}