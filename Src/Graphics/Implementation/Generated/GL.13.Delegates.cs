using System;
using System.Runtime.InteropServices;
using CC = System.Runtime.InteropServices.CallingConvention;
using UFP = System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute;

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[UFP(CC.Cdecl)]
		private unsafe delegate void ActiveTextureDelegate(TextureUnit texture);

		[UFP(CC.Cdecl)]
		private unsafe delegate void SampleCoverageDelegate(float value, byte invert);

		[UFP(CC.Cdecl)]
		private unsafe delegate void CompressedTexImage3DDelegate(TextureTarget target, int level, uint internalFormat, int width, int height, int depth, int border, int imageSize, IntPtr data);

		[UFP(CC.Cdecl)]
		private unsafe delegate void CompressedTexImage2DDelegate(TextureTarget target, int level, uint internalFormat, int width, int height, int border, int imageSize, IntPtr data);

		[UFP(CC.Cdecl)]
		private unsafe delegate void CompressedTexImage1DDelegate(TextureTarget target, int level, uint internalFormat, int width, int border, int imageSize, IntPtr data);

		[UFP(CC.Cdecl)]
		private unsafe delegate void CompressedTexSubImage3DDelegate(TextureTarget target, int level, int xOffset, int yOffset, int zOffset, int width, int height, int depth, uint format, int imageSize, IntPtr data);

		[UFP(CC.Cdecl)]
		private unsafe delegate void CompressedTexSubImage2DDelegate(TextureTarget target, int level, int xOffset, int yOffset, int width, int height, uint format, int imageSize, IntPtr data);

		[UFP(CC.Cdecl)]
		private unsafe delegate void CompressedTexSubImage1DDelegate(TextureTarget target, int level, int xOffset, int width, uint format, int imageSize, IntPtr data);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetCompressedTexImageDelegate(TextureTarget target, int level, IntPtr img);
	}
}
