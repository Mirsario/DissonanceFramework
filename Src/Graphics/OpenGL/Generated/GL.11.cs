using System;

namespace Dissonance.Framework.Graphics.OpenGL
{
	unsafe partial class GL
	{
		[MethodImport("glDrawArrays", "1.1")]
		private static delegate*<PrimitiveType, int, int, void> glDrawArrays;
		
		public static void DrawArrays(PrimitiveType mode, int first, int count)
		{
			glDrawArrays(mode, first, count);
		}
		
		[MethodImport("glDrawElements", "1.1")]
		private static delegate*<PrimitiveType, int, DrawElementsType, void*, void> glDrawElements;
		
		public static void DrawElements(PrimitiveType mode, int count, DrawElementsType type, void* indices)
		{
			glDrawElements(mode, count, type, indices);
		}
		
		[MethodImport("glGetPointerv", "1.1")]
		private static delegate*<GetPointervPName, void**, void> glGetPointerv;
		
		public static void GetPointerv(GetPointervPName pname, void** @params)
		{
			glGetPointerv(pname, @params);
		}
		
		[MethodImport("glPolygonOffset", "1.1")]
		private static delegate*<float, float, void> glPolygonOffset;
		
		public static void PolygonOffset(float factor, float units)
		{
			glPolygonOffset(factor, units);
		}
		
		[MethodImport("glCopyTexImage1D", "1.1")]
		private static delegate*<TextureTarget, int, InternalFormat, int, int, int, int, void> glCopyTexImage1D;
		
		public static void CopyTexImage1D(TextureTarget target, int level, InternalFormat internalformat, int x, int y, int width, int border)
		{
			glCopyTexImage1D(target, level, internalformat, x, y, width, border);
		}
		
		[MethodImport("glCopyTexImage2D", "1.1")]
		private static delegate*<TextureTarget, int, InternalFormat, int, int, int, int, int, void> glCopyTexImage2D;
		
		public static void CopyTexImage2D(TextureTarget target, int level, InternalFormat internalformat, int x, int y, int width, int height, int border)
		{
			glCopyTexImage2D(target, level, internalformat, x, y, width, height, border);
		}
		
		[MethodImport("glCopyTexSubImage1D", "1.1")]
		private static delegate*<TextureTarget, int, int, int, int, int, void> glCopyTexSubImage1D;
		
		public static void CopyTexSubImage1D(TextureTarget target, int level, int xoffset, int x, int y, int width)
		{
			glCopyTexSubImage1D(target, level, xoffset, x, y, width);
		}
		
		[MethodImport("glCopyTexSubImage2D", "1.1")]
		private static delegate*<TextureTarget, int, int, int, int, int, int, int, void> glCopyTexSubImage2D;
		
		public static void CopyTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int x, int y, int width, int height)
		{
			glCopyTexSubImage2D(target, level, xoffset, yoffset, x, y, width, height);
		}
		
		[MethodImport("glTexSubImage1D", "1.1")]
		private static delegate*<TextureTarget, int, int, int, PixelFormat, PixelType, void*, void> glTexSubImage1D;
		
		public static void TexSubImage1D(TextureTarget target, int level, int xoffset, int width, PixelFormat format, PixelType type, void* pixels)
		{
			glTexSubImage1D(target, level, xoffset, width, format, type, pixels);
		}
		
		[MethodImport("glTexSubImage2D", "1.1")]
		private static delegate*<TextureTarget, int, int, int, int, int, PixelFormat, PixelType, void*, void> glTexSubImage2D;
		
		public static void TexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, void* pixels)
		{
			glTexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels);
		}
		
		[MethodImport("glBindTexture", "1.1")]
		private static delegate*<TextureTarget, uint, void> glBindTexture;
		
		public static void BindTexture(TextureTarget target, uint texture)
		{
			glBindTexture(target, texture);
		}
		
		[MethodImport("glDeleteTextures", "1.1")]
		private static delegate*<int, uint*, void> glDeleteTextures;
		
		public static void DeleteTextures(int n, uint* textures)
		{
			glDeleteTextures(n, textures);
		}
		
		[MethodImport("glGenTextures", "1.1")]
		private static delegate*<int, uint*, void> glGenTextures;
		
		public static void GenTextures(int n, uint* textures)
		{
			glGenTextures(n, textures);
		}
		
		[MethodImport("glIsTexture", "1.1")]
		private static delegate*<uint, bool> glIsTexture;
		
		public static bool IsTexture(uint texture)
		{
			return glIsTexture(texture);
		}
		
		[MethodImport("glArrayElement", "1.1")]
		private static delegate*<int, void> glArrayElement;
		
		public static void ArrayElement(int i)
		{
			glArrayElement(i);
		}
		
		[MethodImport("glColorPointer", "1.1")]
		private static delegate*<int, ColorPointerType, int, void*, void> glColorPointer;
		
		public static void ColorPointer(int size, ColorPointerType type, int stride, void* pointer)
		{
			glColorPointer(size, type, stride, pointer);
		}
		
		[MethodImport("glDisableClientState", "1.1")]
		private static delegate*<EnableCap, void> glDisableClientState;
		
		public static void DisableClientState(EnableCap array)
		{
			glDisableClientState(array);
		}
		
		[MethodImport("glEdgeFlagPointer", "1.1")]
		private static delegate*<int, void*, void> glEdgeFlagPointer;
		
		public static void EdgeFlagPointer(int stride, void* pointer)
		{
			glEdgeFlagPointer(stride, pointer);
		}
		
		[MethodImport("glEnableClientState", "1.1")]
		private static delegate*<EnableCap, void> glEnableClientState;
		
		public static void EnableClientState(EnableCap array)
		{
			glEnableClientState(array);
		}
		
		[MethodImport("glIndexPointer", "1.1")]
		private static delegate*<IndexPointerType, int, void*, void> glIndexPointer;
		
		public static void IndexPointer(IndexPointerType type, int stride, void* pointer)
		{
			glIndexPointer(type, stride, pointer);
		}
		
		[MethodImport("glInterleavedArrays", "1.1")]
		private static delegate*<InterleavedArrayFormat, int, void*, void> glInterleavedArrays;
		
		public static void InterleavedArrays(InterleavedArrayFormat format, int stride, void* pointer)
		{
			glInterleavedArrays(format, stride, pointer);
		}
		
		[MethodImport("glNormalPointer", "1.1")]
		private static delegate*<NormalPointerType, int, void*, void> glNormalPointer;
		
		public static void NormalPointer(NormalPointerType type, int stride, void* pointer)
		{
			glNormalPointer(type, stride, pointer);
		}
		
		[MethodImport("glTexCoordPointer", "1.1")]
		private static delegate*<int, TexCoordPointerType, int, void*, void> glTexCoordPointer;
		
		public static void TexCoordPointer(int size, TexCoordPointerType type, int stride, void* pointer)
		{
			glTexCoordPointer(size, type, stride, pointer);
		}
		
		[MethodImport("glVertexPointer", "1.1")]
		private static delegate*<int, VertexPointerType, int, void*, void> glVertexPointer;
		
		public static void VertexPointer(int size, VertexPointerType type, int stride, void* pointer)
		{
			glVertexPointer(size, type, stride, pointer);
		}
		
		[MethodImport("glAreTexturesResident", "1.1")]
		private static delegate*<int, uint*, bool*, bool> glAreTexturesResident;
		
		public static bool AreTexturesResident(int n, uint* textures, bool* residences)
		{
			return glAreTexturesResident(n, textures, residences);
		}
		
		[MethodImport("glPrioritizeTextures", "1.1")]
		private static delegate*<int, uint*, float*, void> glPrioritizeTextures;
		
		public static void PrioritizeTextures(int n, uint* textures, float* priorities)
		{
			glPrioritizeTextures(n, textures, priorities);
		}
		
		[MethodImport("glIndexub", "1.1")]
		private static delegate*<byte, void> glIndexub;
		
		public static void Indexub(byte c)
		{
			glIndexub(c);
		}
		
		[MethodImport("glIndexubv", "1.1")]
		private static delegate*<byte*, void> glIndexubv;
		
		public static void Indexubv(byte* c)
		{
			glIndexubv(c);
		}
		
		[MethodImport("glPopClientAttrib", "1.1")]
		private static delegate*<void> glPopClientAttrib;
		
		public static void PopClientAttrib()
		{
			glPopClientAttrib();
		}
		
		[MethodImport("glPushClientAttrib", "1.1")]
		private static delegate*<ClientAttribMask, void> glPushClientAttrib;
		
		public static void PushClientAttrib(ClientAttribMask mask)
		{
			glPushClientAttrib(mask);
		}
	}
}

