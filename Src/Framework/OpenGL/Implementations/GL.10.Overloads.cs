using System;
using System.Runtime.InteropServices;
using MI = System.Runtime.CompilerServices.MethodImplAttribute;

#pragma warning disable IDE0060 //Unused parameter.

namespace Dissonance.Framework.OpenGL
{
	partial class GL
	{
		//GetString

		[MI(AI)]
		public static string GetString(StringName name) => Marshal.PtrToStringAnsi(GetStringInternal(name));

		//GenTexture(s)

		[MI(AI)]
		public unsafe static uint GenTexture()
		{
			uint result;

			GenTextures(1,&result);

			return result;
		}
		[MI(AI)]
		public unsafe static void GenTextures(int numTextures,uint[] textures)
		{
			fixed(uint* ptr = &(textures!=null && textures.Length!=0 ? ref textures[0] : ref *(uint*)null)) {
				GenTextures(numTextures,ptr);
			}
		}

		//DeleteTexture(s)

		[MI(AI)]
		public unsafe static void DeleteTexture(uint texture) => DeleteTextures(1,&texture);
		[MI(AI)]
		public unsafe static void DeleteTextures(int numTextures,uint[] textures)
		{
			fixed(uint* ptr = &(textures!=null && textures.Length!=0 ? ref textures[0] : ref *(uint*)null)) {
				DeleteTextures(numTextures,ptr);
			}
		}

		//GetTexImage
		public unsafe static void GetTexImage<T>(TextureTarget target,int level,PixelFormat format,PixelType type,T[] pixels) where T : unmanaged
		{
			fixed (T* ptr = &(pixels!=null && pixels.Length!=0 ? ref pixels[0] : ref *(T*)null)) {
				GetTexImage(target,level,format,type,(IntPtr)ptr);
			}
		}

		//DrawElements
		public static void DrawElements(PrimitiveType mode,int count,DrawElementsType type,int offset)
			=> DrawElements(mode,count,type,(IntPtr)offset);

		//TexImageX

		//TexImage1D
		public unsafe static void TexImage1D<T>(TextureTarget target,int level,PixelInternalFormat internalFormat,int width,int border,PixelFormat format,PixelType type,[In] T[] pixels) where T : unmanaged
		{
			fixed(T* ptr = &(pixels!=null && pixels.Length!=0 ? ref pixels[0] : ref *(T*)null)) {
				TexImage1D(target,level,internalFormat,width,border,format,type,(IntPtr)ptr);
			}
		}
		public unsafe static void TexImage1D<T>(TextureTarget target,int level,PixelInternalFormat internalFormat,int width,int border,PixelFormat format,PixelType type,[In] T[,] pixels) where T : unmanaged
		{
			fixed(T* ptr = &(pixels!=null && pixels.Length!=0 ? ref pixels[0,0] : ref *(T*)null)) {
				TexImage1D(target,level,internalFormat,width,border,format,type,(IntPtr)ptr);
			}
		}
		public unsafe static void TexImage1D<T>(TextureTarget target,int level,PixelInternalFormat internalFormat,int width,int border,PixelFormat format,PixelType type,[In] T[,,] pixels) where T : unmanaged
		{
			fixed(T* ptr = &(pixels!=null && pixels.Length!=0 ? ref pixels[0,0,0] : ref *(T*)null)) {
				TexImage1D(target,level,internalFormat,width,border,format,type,(IntPtr)ptr);
			}
		}

		//TexImage2D
		public unsafe static void TexImage2D<T>(TextureTarget target,int level,PixelInternalFormat internalFormat,int width,int height,int border,PixelFormat format,PixelType type,[In] T[] pixels) where T : unmanaged
		{
			fixed(T* ptr = &(pixels!=null && pixels.Length!=0 ? ref pixels[0] : ref *(T*)null)) {
				TexImage2D(target,level,internalFormat,width,height,border,format,type,(IntPtr)ptr);
			}
		}
		public unsafe static void TexImage2D<T>(TextureTarget target,int level,PixelInternalFormat internalFormat,int width,int height,int border,PixelFormat format,PixelType type,[In] T[,] pixels) where T : unmanaged
		{
			fixed(T* ptr = &(pixels!=null && pixels.Length!=0 ? ref pixels[0,0] : ref *(T*)null)) {
				TexImage2D(target,level,internalFormat,width,height,border,format,type,(IntPtr)ptr);
			}
		}
		public unsafe static void TexImage2D<T>(TextureTarget target,int level,PixelInternalFormat internalFormat,int width,int height,int border,PixelFormat format,PixelType type,[In] T[,,] pixels) where T : unmanaged
		{
			fixed(T* ptr = &(pixels!=null && pixels.Length!=0 ? ref pixels[0,0,0] : ref *(T*)null)) {
				TexImage2D(target,level,internalFormat,width,height,border,format,type,(IntPtr)ptr);
			}
		}

		//TexSubImageX

		//TexSubImage1D
		public unsafe static void TexSubImage1D<T>(TextureTarget target,int level,int xOffset,int width,PixelFormat format,PixelType type,[In] T[] pixels) where T : unmanaged
		{
			fixed(T* ptr = &(pixels!=null && pixels.Length!=0 ? ref pixels[0] : ref *(T*)null)) {
				TexSubImage1D(target,level,xOffset,width,format,type,(IntPtr)ptr);
			}
		}
		public unsafe static void TexSubImage1D<T>(TextureTarget target,int level,int xOffset,int width,PixelFormat format,PixelType type,[In] T[,] pixels) where T : unmanaged
		{
			fixed(T* ptr = &(pixels!=null && pixels.Length!=0 ? ref pixels[0,0] : ref *(T*)null)) {
				TexSubImage1D(target,level,xOffset,width,format,type,(IntPtr)ptr);
			}
		}
		public unsafe static void TexSubImage1D<T>(TextureTarget target,int level,int xOffset,int width,PixelFormat format,PixelType type,[In] T[,,] pixels) where T : unmanaged
		{
			fixed(T* ptr = &(pixels!=null && pixels.Length!=0 ? ref pixels[0,0,0] : ref *(T*)null)) {
				TexSubImage1D(target,level,xOffset,width,format,type,(IntPtr)ptr);
			}
		}

		//TexSubImage2D
		public unsafe static void TexSubImage2D<T>(TextureTarget target,int level,int xOffset,int yOffset,int width,int height,PixelFormat format,PixelType type,[In] T[] pixels) where T : unmanaged
		{
			fixed(T* ptr = &(pixels!=null && pixels.Length!=0 ? ref pixels[0] : ref *(T*)null)) {
				TexSubImage2D(target,level,xOffset,yOffset,width,height,format,type,(IntPtr)ptr);
			}
		}
		public unsafe static void TexSubImage2D<T>(TextureTarget target,int level,int xOffset,int yOffset,int width,int height,PixelFormat format,PixelType type,[In] T[,] pixels) where T : unmanaged
		{
			fixed(T* ptr = &(pixels!=null && pixels.Length!=0 ? ref pixels[0,0] : ref *(T*)null)) {
				TexSubImage2D(target,level,xOffset,yOffset,width,height,format,type,(IntPtr)ptr);
			}
		}
		public unsafe static void TexSubImage2D<T>(TextureTarget target,int level,int xOffset,int yOffset,int width,int height,PixelFormat format,PixelType type,[In] T[,,] pixels) where T : unmanaged
		{
			fixed(T* ptr = &(pixels!=null && pixels.Length!=0 ? ref pixels[0,0,0] : ref *(T*)null)) {
				TexSubImage2D(target,level,xOffset,yOffset,width,height,format,type,(IntPtr)ptr);
			}
		}
	}
}