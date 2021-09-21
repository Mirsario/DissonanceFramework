using System;

namespace Dissonance.Framework.Graphics.OpenGL
{
	unsafe partial class GL
	{
		[MethodImport("glActiveTexture", "1.3")]
		private static delegate*<TextureUnit, void> glActiveTexture;
		
		public static void ActiveTexture(TextureUnit texture)
		{
			glActiveTexture(texture);
		}
		
		[MethodImport("glSampleCoverage", "1.3")]
		private static delegate*<float, bool, void> glSampleCoverage;
		
		public static void SampleCoverage(float value, bool invert)
		{
			glSampleCoverage(value, invert);
		}
		
		[MethodImport("glCompressedTexImage3D", "1.3")]
		private static delegate*<TextureTarget, int, InternalFormat, int, int, int, int, int, void*, void> glCompressedTexImage3D;
		
		public static void CompressedTexImage3D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, int imageSize, void* data)
		{
			glCompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data);
		}
		
		[MethodImport("glCompressedTexImage2D", "1.3")]
		private static delegate*<TextureTarget, int, InternalFormat, int, int, int, int, void*, void> glCompressedTexImage2D;
		
		public static void CompressedTexImage2D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, int imageSize, void* data)
		{
			glCompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data);
		}
		
		[MethodImport("glCompressedTexImage1D", "1.3")]
		private static delegate*<TextureTarget, int, InternalFormat, int, int, int, void*, void> glCompressedTexImage1D;
		
		public static void CompressedTexImage1D(TextureTarget target, int level, InternalFormat internalformat, int width, int border, int imageSize, void* data)
		{
			glCompressedTexImage1D(target, level, internalformat, width, border, imageSize, data);
		}
		
		[MethodImport("glCompressedTexSubImage3D", "1.3")]
		private static delegate*<TextureTarget, int, int, int, int, int, int, int, InternalFormat, int, void*, void> glCompressedTexSubImage3D;
		
		public static void CompressedTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, InternalFormat format, int imageSize, void* data)
		{
			glCompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
		}
		
		[MethodImport("glCompressedTexSubImage2D", "1.3")]
		private static delegate*<TextureTarget, int, int, int, int, int, InternalFormat, int, void*, void> glCompressedTexSubImage2D;
		
		public static void CompressedTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, InternalFormat format, int imageSize, void* data)
		{
			glCompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data);
		}
		
		[MethodImport("glCompressedTexSubImage1D", "1.3")]
		private static delegate*<TextureTarget, int, int, int, InternalFormat, int, void*, void> glCompressedTexSubImage1D;
		
		public static void CompressedTexSubImage1D(TextureTarget target, int level, int xoffset, int width, InternalFormat format, int imageSize, void* data)
		{
			glCompressedTexSubImage1D(target, level, xoffset, width, format, imageSize, data);
		}
		
		[MethodImport("glGetCompressedTexImage", "1.3")]
		private static delegate*<TextureTarget, int, void*, void> glGetCompressedTexImage;
		
		public static void GetCompressedTexImage(TextureTarget target, int level, void* img)
		{
			glGetCompressedTexImage(target, level, img);
		}
		
		[MethodImport("glClientActiveTexture", "1.3")]
		private static delegate*<TextureUnit, void> glClientActiveTexture;
		
		public static void ClientActiveTexture(TextureUnit texture)
		{
			glClientActiveTexture(texture);
		}
		
		[MethodImport("glMultiTexCoord1d", "1.3")]
		private static delegate*<TextureUnit, double, void> glMultiTexCoord1d;
		
		public static void MultiTexCoord1d(TextureUnit target, double s)
		{
			glMultiTexCoord1d(target, s);
		}
		
		[MethodImport("glMultiTexCoord1dv", "1.3")]
		private static delegate*<TextureUnit, double*, void> glMultiTexCoord1dv;
		
		public static void MultiTexCoord1dv(TextureUnit target, double* v)
		{
			glMultiTexCoord1dv(target, v);
		}
		
		[MethodImport("glMultiTexCoord1f", "1.3")]
		private static delegate*<TextureUnit, float, void> glMultiTexCoord1f;
		
		public static void MultiTexCoord1f(TextureUnit target, float s)
		{
			glMultiTexCoord1f(target, s);
		}
		
		[MethodImport("glMultiTexCoord1fv", "1.3")]
		private static delegate*<TextureUnit, float*, void> glMultiTexCoord1fv;
		
		public static void MultiTexCoord1fv(TextureUnit target, float* v)
		{
			glMultiTexCoord1fv(target, v);
		}
		
		[MethodImport("glMultiTexCoord1i", "1.3")]
		private static delegate*<TextureUnit, int, void> glMultiTexCoord1i;
		
		public static void MultiTexCoord1i(TextureUnit target, int s)
		{
			glMultiTexCoord1i(target, s);
		}
		
		[MethodImport("glMultiTexCoord1iv", "1.3")]
		private static delegate*<TextureUnit, int*, void> glMultiTexCoord1iv;
		
		public static void MultiTexCoord1iv(TextureUnit target, int* v)
		{
			glMultiTexCoord1iv(target, v);
		}
		
		[MethodImport("glMultiTexCoord1s", "1.3")]
		private static delegate*<TextureUnit, short, void> glMultiTexCoord1s;
		
		public static void MultiTexCoord1s(TextureUnit target, short s)
		{
			glMultiTexCoord1s(target, s);
		}
		
		[MethodImport("glMultiTexCoord1sv", "1.3")]
		private static delegate*<TextureUnit, short*, void> glMultiTexCoord1sv;
		
		public static void MultiTexCoord1sv(TextureUnit target, short* v)
		{
			glMultiTexCoord1sv(target, v);
		}
		
		[MethodImport("glMultiTexCoord2d", "1.3")]
		private static delegate*<TextureUnit, double, double, void> glMultiTexCoord2d;
		
		public static void MultiTexCoord2d(TextureUnit target, double s, double t)
		{
			glMultiTexCoord2d(target, s, t);
		}
		
		[MethodImport("glMultiTexCoord2dv", "1.3")]
		private static delegate*<TextureUnit, double*, void> glMultiTexCoord2dv;
		
		public static void MultiTexCoord2dv(TextureUnit target, double* v)
		{
			glMultiTexCoord2dv(target, v);
		}
		
		[MethodImport("glMultiTexCoord2f", "1.3")]
		private static delegate*<TextureUnit, float, float, void> glMultiTexCoord2f;
		
		public static void MultiTexCoord2f(TextureUnit target, float s, float t)
		{
			glMultiTexCoord2f(target, s, t);
		}
		
		[MethodImport("glMultiTexCoord2fv", "1.3")]
		private static delegate*<TextureUnit, float*, void> glMultiTexCoord2fv;
		
		public static void MultiTexCoord2fv(TextureUnit target, float* v)
		{
			glMultiTexCoord2fv(target, v);
		}
		
		[MethodImport("glMultiTexCoord2i", "1.3")]
		private static delegate*<TextureUnit, int, int, void> glMultiTexCoord2i;
		
		public static void MultiTexCoord2i(TextureUnit target, int s, int t)
		{
			glMultiTexCoord2i(target, s, t);
		}
		
		[MethodImport("glMultiTexCoord2iv", "1.3")]
		private static delegate*<TextureUnit, int*, void> glMultiTexCoord2iv;
		
		public static void MultiTexCoord2iv(TextureUnit target, int* v)
		{
			glMultiTexCoord2iv(target, v);
		}
		
		[MethodImport("glMultiTexCoord2s", "1.3")]
		private static delegate*<TextureUnit, short, short, void> glMultiTexCoord2s;
		
		public static void MultiTexCoord2s(TextureUnit target, short s, short t)
		{
			glMultiTexCoord2s(target, s, t);
		}
		
		[MethodImport("glMultiTexCoord2sv", "1.3")]
		private static delegate*<TextureUnit, short*, void> glMultiTexCoord2sv;
		
		public static void MultiTexCoord2sv(TextureUnit target, short* v)
		{
			glMultiTexCoord2sv(target, v);
		}
		
		[MethodImport("glMultiTexCoord3d", "1.3")]
		private static delegate*<TextureUnit, double, double, double, void> glMultiTexCoord3d;
		
		public static void MultiTexCoord3d(TextureUnit target, double s, double t, double r)
		{
			glMultiTexCoord3d(target, s, t, r);
		}
		
		[MethodImport("glMultiTexCoord3dv", "1.3")]
		private static delegate*<TextureUnit, double*, void> glMultiTexCoord3dv;
		
		public static void MultiTexCoord3dv(TextureUnit target, double* v)
		{
			glMultiTexCoord3dv(target, v);
		}
		
		[MethodImport("glMultiTexCoord3f", "1.3")]
		private static delegate*<TextureUnit, float, float, float, void> glMultiTexCoord3f;
		
		public static void MultiTexCoord3f(TextureUnit target, float s, float t, float r)
		{
			glMultiTexCoord3f(target, s, t, r);
		}
		
		[MethodImport("glMultiTexCoord3fv", "1.3")]
		private static delegate*<TextureUnit, float*, void> glMultiTexCoord3fv;
		
		public static void MultiTexCoord3fv(TextureUnit target, float* v)
		{
			glMultiTexCoord3fv(target, v);
		}
		
		[MethodImport("glMultiTexCoord3i", "1.3")]
		private static delegate*<TextureUnit, int, int, int, void> glMultiTexCoord3i;
		
		public static void MultiTexCoord3i(TextureUnit target, int s, int t, int r)
		{
			glMultiTexCoord3i(target, s, t, r);
		}
		
		[MethodImport("glMultiTexCoord3iv", "1.3")]
		private static delegate*<TextureUnit, int*, void> glMultiTexCoord3iv;
		
		public static void MultiTexCoord3iv(TextureUnit target, int* v)
		{
			glMultiTexCoord3iv(target, v);
		}
		
		[MethodImport("glMultiTexCoord3s", "1.3")]
		private static delegate*<TextureUnit, short, short, short, void> glMultiTexCoord3s;
		
		public static void MultiTexCoord3s(TextureUnit target, short s, short t, short r)
		{
			glMultiTexCoord3s(target, s, t, r);
		}
		
		[MethodImport("glMultiTexCoord3sv", "1.3")]
		private static delegate*<TextureUnit, short*, void> glMultiTexCoord3sv;
		
		public static void MultiTexCoord3sv(TextureUnit target, short* v)
		{
			glMultiTexCoord3sv(target, v);
		}
		
		[MethodImport("glMultiTexCoord4d", "1.3")]
		private static delegate*<TextureUnit, double, double, double, double, void> glMultiTexCoord4d;
		
		public static void MultiTexCoord4d(TextureUnit target, double s, double t, double r, double q)
		{
			glMultiTexCoord4d(target, s, t, r, q);
		}
		
		[MethodImport("glMultiTexCoord4dv", "1.3")]
		private static delegate*<TextureUnit, double*, void> glMultiTexCoord4dv;
		
		public static void MultiTexCoord4dv(TextureUnit target, double* v)
		{
			glMultiTexCoord4dv(target, v);
		}
		
		[MethodImport("glMultiTexCoord4f", "1.3")]
		private static delegate*<TextureUnit, float, float, float, float, void> glMultiTexCoord4f;
		
		public static void MultiTexCoord4f(TextureUnit target, float s, float t, float r, float q)
		{
			glMultiTexCoord4f(target, s, t, r, q);
		}
		
		[MethodImport("glMultiTexCoord4fv", "1.3")]
		private static delegate*<TextureUnit, float*, void> glMultiTexCoord4fv;
		
		public static void MultiTexCoord4fv(TextureUnit target, float* v)
		{
			glMultiTexCoord4fv(target, v);
		}
		
		[MethodImport("glMultiTexCoord4i", "1.3")]
		private static delegate*<TextureUnit, int, int, int, int, void> glMultiTexCoord4i;
		
		public static void MultiTexCoord4i(TextureUnit target, int s, int t, int r, int q)
		{
			glMultiTexCoord4i(target, s, t, r, q);
		}
		
		[MethodImport("glMultiTexCoord4iv", "1.3")]
		private static delegate*<TextureUnit, int*, void> glMultiTexCoord4iv;
		
		public static void MultiTexCoord4iv(TextureUnit target, int* v)
		{
			glMultiTexCoord4iv(target, v);
		}
		
		[MethodImport("glMultiTexCoord4s", "1.3")]
		private static delegate*<TextureUnit, short, short, short, short, void> glMultiTexCoord4s;
		
		public static void MultiTexCoord4s(TextureUnit target, short s, short t, short r, short q)
		{
			glMultiTexCoord4s(target, s, t, r, q);
		}
		
		[MethodImport("glMultiTexCoord4sv", "1.3")]
		private static delegate*<TextureUnit, short*, void> glMultiTexCoord4sv;
		
		public static void MultiTexCoord4sv(TextureUnit target, short* v)
		{
			glMultiTexCoord4sv(target, v);
		}
		
		[MethodImport("glLoadTransposeMatrixf", "1.3")]
		private static delegate*<float*, void> glLoadTransposeMatrixf;
		
		public static void LoadTransposeMatrixf(float* m)
		{
			glLoadTransposeMatrixf(m);
		}
		
		[MethodImport("glLoadTransposeMatrixd", "1.3")]
		private static delegate*<double*, void> glLoadTransposeMatrixd;
		
		public static void LoadTransposeMatrixd(double* m)
		{
			glLoadTransposeMatrixd(m);
		}
		
		[MethodImport("glMultTransposeMatrixf", "1.3")]
		private static delegate*<float*, void> glMultTransposeMatrixf;
		
		public static void MultTransposeMatrixf(float* m)
		{
			glMultTransposeMatrixf(m);
		}
		
		[MethodImport("glMultTransposeMatrixd", "1.3")]
		private static delegate*<double*, void> glMultTransposeMatrixd;
		
		public static void MultTransposeMatrixd(double* m)
		{
			glMultTransposeMatrixd(m);
		}
	}
}

