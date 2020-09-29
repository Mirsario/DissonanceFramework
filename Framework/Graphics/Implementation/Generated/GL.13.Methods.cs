using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[MethodImpl(ImplOptions)]
		public unsafe static void ActiveTexture(TextureUnit texture)
			=> glActiveTexture(texture);

		[MethodImpl(ImplOptions)]
		public unsafe static void SampleCoverage(float value, byte invert)
			=> glSampleCoverage(value, invert);

		[MethodImpl(ImplOptions)]
		public unsafe static void CompressedTexImage3D(TextureTarget target, int level, uint internalFormat, int width, int height, int depth, int border, int imageSize, IntPtr data)
			=> glCompressedTexImage3D(target, level, internalFormat, width, height, depth, border, imageSize, data);

		[MethodImpl(ImplOptions)]
		public unsafe static void CompressedTexImage2D(TextureTarget target, int level, uint internalFormat, int width, int height, int border, int imageSize, IntPtr data)
			=> glCompressedTexImage2D(target, level, internalFormat, width, height, border, imageSize, data);

		[MethodImpl(ImplOptions)]
		public unsafe static void CompressedTexImage1D(TextureTarget target, int level, uint internalFormat, int width, int border, int imageSize, IntPtr data)
			=> glCompressedTexImage1D(target, level, internalFormat, width, border, imageSize, data);

		[MethodImpl(ImplOptions)]
		public unsafe static void CompressedTexSubImage3D(TextureTarget target, int level, int xOffset, int yOffset, int zOffset, int width, int height, int depth, uint format, int imageSize, IntPtr data)
			=> glCompressedTexSubImage3D(target, level, xOffset, yOffset, zOffset, width, height, depth, format, imageSize, data);

		[MethodImpl(ImplOptions)]
		public unsafe static void CompressedTexSubImage2D(TextureTarget target, int level, int xOffset, int yOffset, int width, int height, uint format, int imageSize, IntPtr data)
			=> glCompressedTexSubImage2D(target, level, xOffset, yOffset, width, height, format, imageSize, data);

		[MethodImpl(ImplOptions)]
		public unsafe static void CompressedTexSubImage1D(TextureTarget target, int level, int xOffset, int width, uint format, int imageSize, IntPtr data)
			=> glCompressedTexSubImage1D(target, level, xOffset, width, format, imageSize, data);

		[MethodImpl(ImplOptions)]
		public unsafe static void GetCompressedTexImage(TextureTarget target, int level, IntPtr img)
			=> glGetCompressedTexImage(target, level, img);
	}
}
