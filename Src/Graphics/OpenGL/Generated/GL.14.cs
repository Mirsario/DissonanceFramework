using System;

namespace Dissonance.Framework.Graphics.OpenGL
{
	unsafe partial class GL
	{
		[MethodImport("glBlendFuncSeparate", "1.4")]
		private static delegate*<BlendingFactor, BlendingFactor, BlendingFactor, BlendingFactor, void> glBlendFuncSeparate;
		
		public static void BlendFuncSeparate(BlendingFactor sfactorRGB, BlendingFactor dfactorRGB, BlendingFactor sfactorAlpha, BlendingFactor dfactorAlpha)
		{
			glBlendFuncSeparate(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
		}
		
		[MethodImport("glMultiDrawArrays", "1.4")]
		private static delegate*<PrimitiveType, int*, int*, int, void> glMultiDrawArrays;
		
		public static void MultiDrawArrays(PrimitiveType mode, int* first, int* count, int drawcount)
		{
			glMultiDrawArrays(mode, first, count, drawcount);
		}
		
		[MethodImport("glMultiDrawElements", "1.4")]
		private static delegate*<PrimitiveType, int*, DrawElementsType, void**, int, void> glMultiDrawElements;
		
		public static void MultiDrawElements(PrimitiveType mode, int* count, DrawElementsType type, void** indices, int drawcount)
		{
			glMultiDrawElements(mode, count, type, indices, drawcount);
		}
		
		[MethodImport("glPointParameterf", "1.4")]
		private static delegate*<PointParameterNameARB, float, void> glPointParameterf;
		
		public static void PointParameterf(PointParameterNameARB pname, float param)
		{
			glPointParameterf(pname, param);
		}
		
		[MethodImport("glPointParameterfv", "1.4")]
		private static delegate*<PointParameterNameARB, float*, void> glPointParameterfv;
		
		public static void PointParameterfv(PointParameterNameARB pname, float* @params)
		{
			glPointParameterfv(pname, @params);
		}
		
		[MethodImport("glPointParameteri", "1.4")]
		private static delegate*<PointParameterNameARB, int, void> glPointParameteri;
		
		public static void PointParameteri(PointParameterNameARB pname, int param)
		{
			glPointParameteri(pname, param);
		}
		
		[MethodImport("glPointParameteriv", "1.4")]
		private static delegate*<PointParameterNameARB, int*, void> glPointParameteriv;
		
		public static void PointParameteriv(PointParameterNameARB pname, int* @params)
		{
			glPointParameteriv(pname, @params);
		}
		
		[MethodImport("glFogCoordf", "1.4")]
		private static delegate*<float, void> glFogCoordf;
		
		public static void FogCoordf(float coord)
		{
			glFogCoordf(coord);
		}
		
		[MethodImport("glFogCoordfv", "1.4")]
		private static delegate*<float*, void> glFogCoordfv;
		
		public static void FogCoordfv(float* coord)
		{
			glFogCoordfv(coord);
		}
		
		[MethodImport("glFogCoordd", "1.4")]
		private static delegate*<double, void> glFogCoordd;
		
		public static void FogCoordd(double coord)
		{
			glFogCoordd(coord);
		}
		
		[MethodImport("glFogCoorddv", "1.4")]
		private static delegate*<double*, void> glFogCoorddv;
		
		public static void FogCoorddv(double* coord)
		{
			glFogCoorddv(coord);
		}
		
		[MethodImport("glFogCoordPointer", "1.4")]
		private static delegate*<FogPointerTypeEXT, int, void*, void> glFogCoordPointer;
		
		public static void FogCoordPointer(FogPointerTypeEXT type, int stride, void* pointer)
		{
			glFogCoordPointer(type, stride, pointer);
		}
		
		[MethodImport("glSecondaryColor3b", "1.4")]
		private static delegate*<sbyte, sbyte, sbyte, void> glSecondaryColor3b;
		
		public static void SecondaryColor3b(sbyte red, sbyte green, sbyte blue)
		{
			glSecondaryColor3b(red, green, blue);
		}
		
		[MethodImport("glSecondaryColor3bv", "1.4")]
		private static delegate*<sbyte*, void> glSecondaryColor3bv;
		
		public static void SecondaryColor3bv(sbyte* v)
		{
			glSecondaryColor3bv(v);
		}
		
		[MethodImport("glSecondaryColor3d", "1.4")]
		private static delegate*<double, double, double, void> glSecondaryColor3d;
		
		public static void SecondaryColor3d(double red, double green, double blue)
		{
			glSecondaryColor3d(red, green, blue);
		}
		
		[MethodImport("glSecondaryColor3dv", "1.4")]
		private static delegate*<double*, void> glSecondaryColor3dv;
		
		public static void SecondaryColor3dv(double* v)
		{
			glSecondaryColor3dv(v);
		}
		
		[MethodImport("glSecondaryColor3f", "1.4")]
		private static delegate*<float, float, float, void> glSecondaryColor3f;
		
		public static void SecondaryColor3f(float red, float green, float blue)
		{
			glSecondaryColor3f(red, green, blue);
		}
		
		[MethodImport("glSecondaryColor3fv", "1.4")]
		private static delegate*<float*, void> glSecondaryColor3fv;
		
		public static void SecondaryColor3fv(float* v)
		{
			glSecondaryColor3fv(v);
		}
		
		[MethodImport("glSecondaryColor3i", "1.4")]
		private static delegate*<int, int, int, void> glSecondaryColor3i;
		
		public static void SecondaryColor3i(int red, int green, int blue)
		{
			glSecondaryColor3i(red, green, blue);
		}
		
		[MethodImport("glSecondaryColor3iv", "1.4")]
		private static delegate*<int*, void> glSecondaryColor3iv;
		
		public static void SecondaryColor3iv(int* v)
		{
			glSecondaryColor3iv(v);
		}
		
		[MethodImport("glSecondaryColor3s", "1.4")]
		private static delegate*<short, short, short, void> glSecondaryColor3s;
		
		public static void SecondaryColor3s(short red, short green, short blue)
		{
			glSecondaryColor3s(red, green, blue);
		}
		
		[MethodImport("glSecondaryColor3sv", "1.4")]
		private static delegate*<short*, void> glSecondaryColor3sv;
		
		public static void SecondaryColor3sv(short* v)
		{
			glSecondaryColor3sv(v);
		}
		
		[MethodImport("glSecondaryColor3ub", "1.4")]
		private static delegate*<byte, byte, byte, void> glSecondaryColor3ub;
		
		public static void SecondaryColor3ub(byte red, byte green, byte blue)
		{
			glSecondaryColor3ub(red, green, blue);
		}
		
		[MethodImport("glSecondaryColor3ubv", "1.4")]
		private static delegate*<byte*, void> glSecondaryColor3ubv;
		
		public static void SecondaryColor3ubv(byte* v)
		{
			glSecondaryColor3ubv(v);
		}
		
		[MethodImport("glSecondaryColor3ui", "1.4")]
		private static delegate*<uint, uint, uint, void> glSecondaryColor3ui;
		
		public static void SecondaryColor3ui(uint red, uint green, uint blue)
		{
			glSecondaryColor3ui(red, green, blue);
		}
		
		[MethodImport("glSecondaryColor3uiv", "1.4")]
		private static delegate*<uint*, void> glSecondaryColor3uiv;
		
		public static void SecondaryColor3uiv(uint* v)
		{
			glSecondaryColor3uiv(v);
		}
		
		[MethodImport("glSecondaryColor3us", "1.4")]
		private static delegate*<ushort, ushort, ushort, void> glSecondaryColor3us;
		
		public static void SecondaryColor3us(ushort red, ushort green, ushort blue)
		{
			glSecondaryColor3us(red, green, blue);
		}
		
		[MethodImport("glSecondaryColor3usv", "1.4")]
		private static delegate*<ushort*, void> glSecondaryColor3usv;
		
		public static void SecondaryColor3usv(ushort* v)
		{
			glSecondaryColor3usv(v);
		}
		
		[MethodImport("glSecondaryColorPointer", "1.4")]
		private static delegate*<int, ColorPointerType, int, void*, void> glSecondaryColorPointer;
		
		public static void SecondaryColorPointer(int size, ColorPointerType type, int stride, void* pointer)
		{
			glSecondaryColorPointer(size, type, stride, pointer);
		}
		
		[MethodImport("glWindowPos2d", "1.4")]
		private static delegate*<double, double, void> glWindowPos2d;
		
		public static void WindowPos2d(double x, double y)
		{
			glWindowPos2d(x, y);
		}
		
		[MethodImport("glWindowPos2dv", "1.4")]
		private static delegate*<double*, void> glWindowPos2dv;
		
		public static void WindowPos2dv(double* v)
		{
			glWindowPos2dv(v);
		}
		
		[MethodImport("glWindowPos2f", "1.4")]
		private static delegate*<float, float, void> glWindowPos2f;
		
		public static void WindowPos2f(float x, float y)
		{
			glWindowPos2f(x, y);
		}
		
		[MethodImport("glWindowPos2fv", "1.4")]
		private static delegate*<float*, void> glWindowPos2fv;
		
		public static void WindowPos2fv(float* v)
		{
			glWindowPos2fv(v);
		}
		
		[MethodImport("glWindowPos2i", "1.4")]
		private static delegate*<int, int, void> glWindowPos2i;
		
		public static void WindowPos2i(int x, int y)
		{
			glWindowPos2i(x, y);
		}
		
		[MethodImport("glWindowPos2iv", "1.4")]
		private static delegate*<int*, void> glWindowPos2iv;
		
		public static void WindowPos2iv(int* v)
		{
			glWindowPos2iv(v);
		}
		
		[MethodImport("glWindowPos2s", "1.4")]
		private static delegate*<short, short, void> glWindowPos2s;
		
		public static void WindowPos2s(short x, short y)
		{
			glWindowPos2s(x, y);
		}
		
		[MethodImport("glWindowPos2sv", "1.4")]
		private static delegate*<short*, void> glWindowPos2sv;
		
		public static void WindowPos2sv(short* v)
		{
			glWindowPos2sv(v);
		}
		
		[MethodImport("glWindowPos3d", "1.4")]
		private static delegate*<double, double, double, void> glWindowPos3d;
		
		public static void WindowPos3d(double x, double y, double z)
		{
			glWindowPos3d(x, y, z);
		}
		
		[MethodImport("glWindowPos3dv", "1.4")]
		private static delegate*<double*, void> glWindowPos3dv;
		
		public static void WindowPos3dv(double* v)
		{
			glWindowPos3dv(v);
		}
		
		[MethodImport("glWindowPos3f", "1.4")]
		private static delegate*<float, float, float, void> glWindowPos3f;
		
		public static void WindowPos3f(float x, float y, float z)
		{
			glWindowPos3f(x, y, z);
		}
		
		[MethodImport("glWindowPos3fv", "1.4")]
		private static delegate*<float*, void> glWindowPos3fv;
		
		public static void WindowPos3fv(float* v)
		{
			glWindowPos3fv(v);
		}
		
		[MethodImport("glWindowPos3i", "1.4")]
		private static delegate*<int, int, int, void> glWindowPos3i;
		
		public static void WindowPos3i(int x, int y, int z)
		{
			glWindowPos3i(x, y, z);
		}
		
		[MethodImport("glWindowPos3iv", "1.4")]
		private static delegate*<int*, void> glWindowPos3iv;
		
		public static void WindowPos3iv(int* v)
		{
			glWindowPos3iv(v);
		}
		
		[MethodImport("glWindowPos3s", "1.4")]
		private static delegate*<short, short, short, void> glWindowPos3s;
		
		public static void WindowPos3s(short x, short y, short z)
		{
			glWindowPos3s(x, y, z);
		}
		
		[MethodImport("glWindowPos3sv", "1.4")]
		private static delegate*<short*, void> glWindowPos3sv;
		
		public static void WindowPos3sv(short* v)
		{
			glWindowPos3sv(v);
		}
		
		[MethodImport("glBlendColor", "1.4")]
		private static delegate*<float, float, float, float, void> glBlendColor;
		
		public static void BlendColor(float red, float green, float blue, float alpha)
		{
			glBlendColor(red, green, blue, alpha);
		}
		
		[MethodImport("glBlendEquation", "1.4")]
		private static delegate*<BlendEquationModeEXT, void> glBlendEquation;
		
		public static void BlendEquation(BlendEquationModeEXT mode)
		{
			glBlendEquation(mode);
		}
	}
}

