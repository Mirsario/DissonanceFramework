using System;
using System.Runtime.CompilerServices;

#pragma warning disable IDE0060 //Unused parameter.

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[MethodImpl(ImplOptions)]
		[MethodImport("glActiveTexture","1.3")]
		public static void ActiveTexture(TextureUnit texture)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glSampleCoverage","1.3")]
		public static void SampleCoverage(float value,byte invert)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glCompressedTexImage3D","1.3")]
		public static void CompressedTexImage3D(TextureTarget target,int level,uint internalFormat,int width,int height,int depth,int border,int imageSize,IntPtr data)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glCompressedTexImage2D","1.3")]
		public static void CompressedTexImage2D(TextureTarget target,int level,uint internalFormat,int width,int height,int border,int imageSize,IntPtr data)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glCompressedTexImage1D","1.3")]
		public static void CompressedTexImage1D(TextureTarget target,int level,uint internalFormat,int width,int border,int imageSize,IntPtr data)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glCompressedTexSubImage3D","1.3")]
		public static void CompressedTexSubImage3D(TextureTarget target,int level,int xOffset,int yOffset,int zOffset,int width,int height,int depth,uint format,int imageSize,IntPtr data)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glCompressedTexSubImage2D","1.3")]
		public static void CompressedTexSubImage2D(TextureTarget target,int level,int xOffset,int yOffset,int width,int height,uint format,int imageSize,IntPtr data)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glCompressedTexSubImage1D","1.3")]
		public static void CompressedTexSubImage1D(TextureTarget target,int level,int xOffset,int width,uint format,int imageSize,IntPtr data)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetCompressedTexImage","1.3")]
		public static void GetCompressedTexImage(TextureTarget target,int level,IntPtr img)
			=> throw new NotImplementedException();
	}
}