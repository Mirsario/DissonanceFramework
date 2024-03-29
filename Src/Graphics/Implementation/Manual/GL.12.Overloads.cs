﻿using System;
using System.Runtime.InteropServices;

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		public unsafe static void TexImage3D<T>(TextureTarget target, int level, PixelInternalFormat internalFormat, int width, int height, int depth, int border, PixelFormat format, PixelType type, [In] T[] pixels) where T : unmanaged
		{
			fixed (T* ptr = &(pixels != null && pixels.Length != 0 ? ref pixels[0] : ref *(T*)null)) {
				TexImage3D(target, level, internalFormat, width, height, depth, border, format, type, (IntPtr)ptr);
			}
		}

		public unsafe static void TexImage3D<T>(TextureTarget target, int level, PixelInternalFormat internalFormat, int width, int height, int depth, int border, PixelFormat format, PixelType type, [In] T[,] pixels) where T : unmanaged
		{
			fixed (T* ptr = &(pixels != null && pixels.Length != 0 ? ref pixels[0, 0] : ref *(T*)null)) {
				TexImage3D(target, level, internalFormat, width, height, depth, border, format, type, (IntPtr)ptr);
			}
		}

		public unsafe static void TexImage3D<T>(TextureTarget target, int level, PixelInternalFormat internalFormat, int width, int height, int depth, int border, PixelFormat format, PixelType type, [In] T[,,] pixels) where T : unmanaged
		{
			fixed (T* ptr = &(pixels != null && pixels.Length != 0 ? ref pixels[0, 0, 0] : ref *(T*)null)) {
				TexImage3D(target, level, internalFormat, width, height, depth, border, format, type, (IntPtr)ptr);
			}
		}
	}
}
