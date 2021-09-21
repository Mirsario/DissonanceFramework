using System;

namespace Dissonance.Framework.Graphics.OpenGL
{
	unsafe partial class GL
	{
		[MethodImport("glCullFace", "1.0")]
		private static delegate*<CullFaceMode, void> glCullFace;
		
		public static void CullFace(CullFaceMode mode)
		{
			glCullFace(mode);
		}
		
		[MethodImport("glFrontFace", "1.0")]
		private static delegate*<FrontFaceDirection, void> glFrontFace;
		
		public static void FrontFace(FrontFaceDirection mode)
		{
			glFrontFace(mode);
		}
		
		[MethodImport("glHint", "1.0")]
		private static delegate*<HintTarget, HintMode, void> glHint;
		
		public static void Hint(HintTarget target, HintMode mode)
		{
			glHint(target, mode);
		}
		
		[MethodImport("glLineWidth", "1.0")]
		private static delegate*<float, void> glLineWidth;
		
		public static void LineWidth(float width)
		{
			glLineWidth(width);
		}
		
		[MethodImport("glPointSize", "1.0")]
		private static delegate*<float, void> glPointSize;
		
		public static void PointSize(float size)
		{
			glPointSize(size);
		}
		
		[MethodImport("glPolygonMode", "1.0")]
		private static delegate*<MaterialFace, PolygonMode, void> glPolygonMode;
		
		public static void PolygonMode(MaterialFace face, PolygonMode mode)
		{
			glPolygonMode(face, mode);
		}
		
		[MethodImport("glScissor", "1.0")]
		private static delegate*<int, int, int, int, void> glScissor;
		
		public static void Scissor(int x, int y, int width, int height)
		{
			glScissor(x, y, width, height);
		}
		
		[MethodImport("glTexParameterf", "1.0")]
		private static delegate*<TextureTarget, TextureParameterName, float, void> glTexParameterf;
		
		public static void TexParameterf(TextureTarget target, TextureParameterName pname, float param)
		{
			glTexParameterf(target, pname, param);
		}
		
		[MethodImport("glTexParameterfv", "1.0")]
		private static delegate*<TextureTarget, TextureParameterName, float*, void> glTexParameterfv;
		
		public static void TexParameterfv(TextureTarget target, TextureParameterName pname, float* @params)
		{
			glTexParameterfv(target, pname, @params);
		}
		
		[MethodImport("glTexParameteri", "1.0")]
		private static delegate*<TextureTarget, TextureParameterName, int, void> glTexParameteri;
		
		public static void TexParameteri(TextureTarget target, TextureParameterName pname, int param)
		{
			glTexParameteri(target, pname, param);
		}
		
		[MethodImport("glTexParameteriv", "1.0")]
		private static delegate*<TextureTarget, TextureParameterName, int*, void> glTexParameteriv;
		
		public static void TexParameteriv(TextureTarget target, TextureParameterName pname, int* @params)
		{
			glTexParameteriv(target, pname, @params);
		}
		
		[MethodImport("glTexImage1D", "1.0")]
		private static delegate*<TextureTarget, int, int, int, int, PixelFormat, PixelType, void*, void> glTexImage1D;
		
		public static void TexImage1D(TextureTarget target, int level, int internalformat, int width, int border, PixelFormat format, PixelType type, void* pixels)
		{
			glTexImage1D(target, level, internalformat, width, border, format, type, pixels);
		}
		
		[MethodImport("glTexImage2D", "1.0")]
		private static delegate*<TextureTarget, int, int, int, int, int, PixelFormat, PixelType, void*, void> glTexImage2D;
		
		public static void TexImage2D(TextureTarget target, int level, int internalformat, int width, int height, int border, PixelFormat format, PixelType type, void* pixels)
		{
			glTexImage2D(target, level, internalformat, width, height, border, format, type, pixels);
		}
		
		[MethodImport("glDrawBuffer", "1.0")]
		private static delegate*<DrawBufferMode, void> glDrawBuffer;
		
		public static void DrawBuffer(DrawBufferMode buf)
		{
			glDrawBuffer(buf);
		}
		
		[MethodImport("glClear", "1.0")]
		private static delegate*<ClearBufferMask, void> glClear;
		
		public static void Clear(ClearBufferMask mask)
		{
			glClear(mask);
		}
		
		[MethodImport("glClearColor", "1.0")]
		private static delegate*<float, float, float, float, void> glClearColor;
		
		public static void ClearColor(float red, float green, float blue, float alpha)
		{
			glClearColor(red, green, blue, alpha);
		}
		
		[MethodImport("glClearStencil", "1.0")]
		private static delegate*<int, void> glClearStencil;
		
		public static void ClearStencil(int s)
		{
			glClearStencil(s);
		}
		
		[MethodImport("glClearDepth", "1.0")]
		private static delegate*<double, void> glClearDepth;
		
		public static void ClearDepth(double depth)
		{
			glClearDepth(depth);
		}
		
		[MethodImport("glStencilMask", "1.0")]
		private static delegate*<uint, void> glStencilMask;
		
		public static void StencilMask(uint mask)
		{
			glStencilMask(mask);
		}
		
		[MethodImport("glColorMask", "1.0")]
		private static delegate*<bool, bool, bool, bool, void> glColorMask;
		
		public static void ColorMask(bool red, bool green, bool blue, bool alpha)
		{
			glColorMask(red, green, blue, alpha);
		}
		
		[MethodImport("glDepthMask", "1.0")]
		private static delegate*<bool, void> glDepthMask;
		
		public static void DepthMask(bool flag)
		{
			glDepthMask(flag);
		}
		
		[MethodImport("glDisable", "1.0")]
		private static delegate*<EnableCap, void> glDisable;
		
		public static void Disable(EnableCap cap)
		{
			glDisable(cap);
		}
		
		[MethodImport("glEnable", "1.0")]
		private static delegate*<EnableCap, void> glEnable;
		
		public static void Enable(EnableCap cap)
		{
			glEnable(cap);
		}
		
		[MethodImport("glFinish", "1.0")]
		private static delegate*<void> glFinish;
		
		public static void Finish()
		{
			glFinish();
		}
		
		[MethodImport("glFlush", "1.0")]
		private static delegate*<void> glFlush;
		
		public static void Flush()
		{
			glFlush();
		}
		
		[MethodImport("glBlendFunc", "1.0")]
		private static delegate*<BlendingFactor, BlendingFactor, void> glBlendFunc;
		
		public static void BlendFunc(BlendingFactor sfactor, BlendingFactor dfactor)
		{
			glBlendFunc(sfactor, dfactor);
		}
		
		[MethodImport("glLogicOp", "1.0")]
		private static delegate*<LogicOp, void> glLogicOp;
		
		public static void LogicOp(LogicOp opcode)
		{
			glLogicOp(opcode);
		}
		
		[MethodImport("glStencilFunc", "1.0")]
		private static delegate*<StencilFunction, int, uint, void> glStencilFunc;
		
		public static void StencilFunc(StencilFunction func, int @ref, uint mask)
		{
			glStencilFunc(func, @ref, mask);
		}
		
		[MethodImport("glStencilOp", "1.0")]
		private static delegate*<StencilOp, StencilOp, StencilOp, void> glStencilOp;
		
		public static void StencilOp(StencilOp fail, StencilOp zfail, StencilOp zpass)
		{
			glStencilOp(fail, zfail, zpass);
		}
		
		[MethodImport("glDepthFunc", "1.0")]
		private static delegate*<DepthFunction, void> glDepthFunc;
		
		public static void DepthFunc(DepthFunction func)
		{
			glDepthFunc(func);
		}
		
		[MethodImport("glPixelStoref", "1.0")]
		private static delegate*<PixelStoreParameter, float, void> glPixelStoref;
		
		public static void PixelStoref(PixelStoreParameter pname, float param)
		{
			glPixelStoref(pname, param);
		}
		
		[MethodImport("glPixelStorei", "1.0")]
		private static delegate*<PixelStoreParameter, int, void> glPixelStorei;
		
		public static void PixelStorei(PixelStoreParameter pname, int param)
		{
			glPixelStorei(pname, param);
		}
		
		[MethodImport("glReadBuffer", "1.0")]
		private static delegate*<ReadBufferMode, void> glReadBuffer;
		
		public static void ReadBuffer(ReadBufferMode src)
		{
			glReadBuffer(src);
		}
		
		[MethodImport("glReadPixels", "1.0")]
		private static delegate*<int, int, int, int, PixelFormat, PixelType, void*, void> glReadPixels;
		
		public static void ReadPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, void* pixels)
		{
			glReadPixels(x, y, width, height, format, type, pixels);
		}
		
		[MethodImport("glGetBooleanv", "1.0")]
		private static delegate*<GetPName, bool*, void> glGetBooleanv;
		
		public static void GetBooleanv(GetPName pname, bool* data)
		{
			glGetBooleanv(pname, data);
		}
		
		[MethodImport("glGetDoublev", "1.0")]
		private static delegate*<GetPName, double*, void> glGetDoublev;
		
		public static void GetDoublev(GetPName pname, double* data)
		{
			glGetDoublev(pname, data);
		}
		
		[MethodImport("glGetError", "1.0")]
		private static delegate*<ErrorCode> glGetError;
		
		public static ErrorCode GetError()
		{
			return glGetError();
		}
		
		[MethodImport("glGetFloatv", "1.0")]
		private static delegate*<GetPName, float*, void> glGetFloatv;
		
		public static void GetFloatv(GetPName pname, float* data)
		{
			glGetFloatv(pname, data);
		}
		
		[MethodImport("glGetIntegerv", "1.0")]
		private static delegate*<GetPName, int*, void> glGetIntegerv;
		
		public static void GetIntegerv(GetPName pname, int* data)
		{
			glGetIntegerv(pname, data);
		}
		
		[MethodImport("glGetString", "1.0")]
		private static delegate*<StringName, byte> glGetString;
		
		public static byte GetString(StringName name)
		{
			return glGetString(name);
		}
		
		[MethodImport("glGetTexImage", "1.0")]
		private static delegate*<TextureTarget, int, PixelFormat, PixelType, void*, void> glGetTexImage;
		
		public static void GetTexImage(TextureTarget target, int level, PixelFormat format, PixelType type, void* pixels)
		{
			glGetTexImage(target, level, format, type, pixels);
		}
		
		[MethodImport("glGetTexParameterfv", "1.0")]
		private static delegate*<TextureTarget, GetTextureParameter, float*, void> glGetTexParameterfv;
		
		public static void GetTexParameterfv(TextureTarget target, GetTextureParameter pname, float* @params)
		{
			glGetTexParameterfv(target, pname, @params);
		}
		
		[MethodImport("glGetTexParameteriv", "1.0")]
		private static delegate*<TextureTarget, GetTextureParameter, int*, void> glGetTexParameteriv;
		
		public static void GetTexParameteriv(TextureTarget target, GetTextureParameter pname, int* @params)
		{
			glGetTexParameteriv(target, pname, @params);
		}
		
		[MethodImport("glGetTexLevelParameterfv", "1.0")]
		private static delegate*<TextureTarget, int, GetTextureParameter, float*, void> glGetTexLevelParameterfv;
		
		public static void GetTexLevelParameterfv(TextureTarget target, int level, GetTextureParameter pname, float* @params)
		{
			glGetTexLevelParameterfv(target, level, pname, @params);
		}
		
		[MethodImport("glGetTexLevelParameteriv", "1.0")]
		private static delegate*<TextureTarget, int, GetTextureParameter, int*, void> glGetTexLevelParameteriv;
		
		public static void GetTexLevelParameteriv(TextureTarget target, int level, GetTextureParameter pname, int* @params)
		{
			glGetTexLevelParameteriv(target, level, pname, @params);
		}
		
		[MethodImport("glIsEnabled", "1.0")]
		private static delegate*<EnableCap, bool> glIsEnabled;
		
		public static bool IsEnabled(EnableCap cap)
		{
			return glIsEnabled(cap);
		}
		
		[MethodImport("glDepthRange", "1.0")]
		private static delegate*<double, double, void> glDepthRange;
		
		public static void DepthRange(double n, double f)
		{
			glDepthRange(n, f);
		}
		
		[MethodImport("glViewport", "1.0")]
		private static delegate*<int, int, int, int, void> glViewport;
		
		public static void Viewport(int x, int y, int width, int height)
		{
			glViewport(x, y, width, height);
		}
		
		[MethodImport("glNewList", "1.0")]
		private static delegate*<uint, ListMode, void> glNewList;
		
		public static void NewList(uint list, ListMode mode)
		{
			glNewList(list, mode);
		}
		
		[MethodImport("glEndList", "1.0")]
		private static delegate*<void> glEndList;
		
		public static void EndList()
		{
			glEndList();
		}
		
		[MethodImport("glCallList", "1.0")]
		private static delegate*<uint, void> glCallList;
		
		public static void CallList(uint list)
		{
			glCallList(list);
		}
		
		[MethodImport("glCallLists", "1.0")]
		private static delegate*<int, ListNameType, void*, void> glCallLists;
		
		public static void CallLists(int n, ListNameType type, void* lists)
		{
			glCallLists(n, type, lists);
		}
		
		[MethodImport("glDeleteLists", "1.0")]
		private static delegate*<uint, int, void> glDeleteLists;
		
		public static void DeleteLists(uint list, int range)
		{
			glDeleteLists(list, range);
		}
		
		[MethodImport("glGenLists", "1.0")]
		private static delegate*<int, uint> glGenLists;
		
		public static uint GenLists(int range)
		{
			return glGenLists(range);
		}
		
		[MethodImport("glListBase", "1.0")]
		private static delegate*<uint, void> glListBase;
		
		public static void ListBase(uint @base)
		{
			glListBase(@base);
		}
		
		[MethodImport("glBegin", "1.0")]
		private static delegate*<PrimitiveType, void> glBegin;
		
		public static void Begin(PrimitiveType mode)
		{
			glBegin(mode);
		}
		
		[MethodImport("glBitmap", "1.0")]
		private static delegate*<int, int, float, float, float, float, byte*, void> glBitmap;
		
		public static void Bitmap(int width, int height, float xorig, float yorig, float xmove, float ymove, byte* bitmap)
		{
			glBitmap(width, height, xorig, yorig, xmove, ymove, bitmap);
		}
		
		[MethodImport("glColor3b", "1.0")]
		private static delegate*<sbyte, sbyte, sbyte, void> glColor3b;
		
		public static void Color3b(sbyte red, sbyte green, sbyte blue)
		{
			glColor3b(red, green, blue);
		}
		
		[MethodImport("glColor3bv", "1.0")]
		private static delegate*<sbyte*, void> glColor3bv;
		
		public static void Color3bv(sbyte* v)
		{
			glColor3bv(v);
		}
		
		[MethodImport("glColor3d", "1.0")]
		private static delegate*<double, double, double, void> glColor3d;
		
		public static void Color3d(double red, double green, double blue)
		{
			glColor3d(red, green, blue);
		}
		
		[MethodImport("glColor3dv", "1.0")]
		private static delegate*<double*, void> glColor3dv;
		
		public static void Color3dv(double* v)
		{
			glColor3dv(v);
		}
		
		[MethodImport("glColor3f", "1.0")]
		private static delegate*<float, float, float, void> glColor3f;
		
		public static void Color3f(float red, float green, float blue)
		{
			glColor3f(red, green, blue);
		}
		
		[MethodImport("glColor3fv", "1.0")]
		private static delegate*<float*, void> glColor3fv;
		
		public static void Color3fv(float* v)
		{
			glColor3fv(v);
		}
		
		[MethodImport("glColor3i", "1.0")]
		private static delegate*<int, int, int, void> glColor3i;
		
		public static void Color3i(int red, int green, int blue)
		{
			glColor3i(red, green, blue);
		}
		
		[MethodImport("glColor3iv", "1.0")]
		private static delegate*<int*, void> glColor3iv;
		
		public static void Color3iv(int* v)
		{
			glColor3iv(v);
		}
		
		[MethodImport("glColor3s", "1.0")]
		private static delegate*<short, short, short, void> glColor3s;
		
		public static void Color3s(short red, short green, short blue)
		{
			glColor3s(red, green, blue);
		}
		
		[MethodImport("glColor3sv", "1.0")]
		private static delegate*<short*, void> glColor3sv;
		
		public static void Color3sv(short* v)
		{
			glColor3sv(v);
		}
		
		[MethodImport("glColor3ub", "1.0")]
		private static delegate*<byte, byte, byte, void> glColor3ub;
		
		public static void Color3ub(byte red, byte green, byte blue)
		{
			glColor3ub(red, green, blue);
		}
		
		[MethodImport("glColor3ubv", "1.0")]
		private static delegate*<byte*, void> glColor3ubv;
		
		public static void Color3ubv(byte* v)
		{
			glColor3ubv(v);
		}
		
		[MethodImport("glColor3ui", "1.0")]
		private static delegate*<uint, uint, uint, void> glColor3ui;
		
		public static void Color3ui(uint red, uint green, uint blue)
		{
			glColor3ui(red, green, blue);
		}
		
		[MethodImport("glColor3uiv", "1.0")]
		private static delegate*<uint*, void> glColor3uiv;
		
		public static void Color3uiv(uint* v)
		{
			glColor3uiv(v);
		}
		
		[MethodImport("glColor3us", "1.0")]
		private static delegate*<ushort, ushort, ushort, void> glColor3us;
		
		public static void Color3us(ushort red, ushort green, ushort blue)
		{
			glColor3us(red, green, blue);
		}
		
		[MethodImport("glColor3usv", "1.0")]
		private static delegate*<ushort*, void> glColor3usv;
		
		public static void Color3usv(ushort* v)
		{
			glColor3usv(v);
		}
		
		[MethodImport("glColor4b", "1.0")]
		private static delegate*<sbyte, sbyte, sbyte, sbyte, void> glColor4b;
		
		public static void Color4b(sbyte red, sbyte green, sbyte blue, sbyte alpha)
		{
			glColor4b(red, green, blue, alpha);
		}
		
		[MethodImport("glColor4bv", "1.0")]
		private static delegate*<sbyte*, void> glColor4bv;
		
		public static void Color4bv(sbyte* v)
		{
			glColor4bv(v);
		}
		
		[MethodImport("glColor4d", "1.0")]
		private static delegate*<double, double, double, double, void> glColor4d;
		
		public static void Color4d(double red, double green, double blue, double alpha)
		{
			glColor4d(red, green, blue, alpha);
		}
		
		[MethodImport("glColor4dv", "1.0")]
		private static delegate*<double*, void> glColor4dv;
		
		public static void Color4dv(double* v)
		{
			glColor4dv(v);
		}
		
		[MethodImport("glColor4f", "1.0")]
		private static delegate*<float, float, float, float, void> glColor4f;
		
		public static void Color4f(float red, float green, float blue, float alpha)
		{
			glColor4f(red, green, blue, alpha);
		}
		
		[MethodImport("glColor4fv", "1.0")]
		private static delegate*<float*, void> glColor4fv;
		
		public static void Color4fv(float* v)
		{
			glColor4fv(v);
		}
		
		[MethodImport("glColor4i", "1.0")]
		private static delegate*<int, int, int, int, void> glColor4i;
		
		public static void Color4i(int red, int green, int blue, int alpha)
		{
			glColor4i(red, green, blue, alpha);
		}
		
		[MethodImport("glColor4iv", "1.0")]
		private static delegate*<int*, void> glColor4iv;
		
		public static void Color4iv(int* v)
		{
			glColor4iv(v);
		}
		
		[MethodImport("glColor4s", "1.0")]
		private static delegate*<short, short, short, short, void> glColor4s;
		
		public static void Color4s(short red, short green, short blue, short alpha)
		{
			glColor4s(red, green, blue, alpha);
		}
		
		[MethodImport("glColor4sv", "1.0")]
		private static delegate*<short*, void> glColor4sv;
		
		public static void Color4sv(short* v)
		{
			glColor4sv(v);
		}
		
		[MethodImport("glColor4ub", "1.0")]
		private static delegate*<byte, byte, byte, byte, void> glColor4ub;
		
		public static void Color4ub(byte red, byte green, byte blue, byte alpha)
		{
			glColor4ub(red, green, blue, alpha);
		}
		
		[MethodImport("glColor4ubv", "1.0")]
		private static delegate*<byte*, void> glColor4ubv;
		
		public static void Color4ubv(byte* v)
		{
			glColor4ubv(v);
		}
		
		[MethodImport("glColor4ui", "1.0")]
		private static delegate*<uint, uint, uint, uint, void> glColor4ui;
		
		public static void Color4ui(uint red, uint green, uint blue, uint alpha)
		{
			glColor4ui(red, green, blue, alpha);
		}
		
		[MethodImport("glColor4uiv", "1.0")]
		private static delegate*<uint*, void> glColor4uiv;
		
		public static void Color4uiv(uint* v)
		{
			glColor4uiv(v);
		}
		
		[MethodImport("glColor4us", "1.0")]
		private static delegate*<ushort, ushort, ushort, ushort, void> glColor4us;
		
		public static void Color4us(ushort red, ushort green, ushort blue, ushort alpha)
		{
			glColor4us(red, green, blue, alpha);
		}
		
		[MethodImport("glColor4usv", "1.0")]
		private static delegate*<ushort*, void> glColor4usv;
		
		public static void Color4usv(ushort* v)
		{
			glColor4usv(v);
		}
		
		[MethodImport("glEdgeFlag", "1.0")]
		private static delegate*<bool, void> glEdgeFlag;
		
		public static void EdgeFlag(bool flag)
		{
			glEdgeFlag(flag);
		}
		
		[MethodImport("glEdgeFlagv", "1.0")]
		private static delegate*<bool*, void> glEdgeFlagv;
		
		public static void EdgeFlagv(bool* flag)
		{
			glEdgeFlagv(flag);
		}
		
		[MethodImport("glEnd", "1.0")]
		private static delegate*<void> glEnd;
		
		public static void End()
		{
			glEnd();
		}
		
		[MethodImport("glIndexd", "1.0")]
		private static delegate*<double, void> glIndexd;
		
		public static void Indexd(double c)
		{
			glIndexd(c);
		}
		
		[MethodImport("glIndexdv", "1.0")]
		private static delegate*<double*, void> glIndexdv;
		
		public static void Indexdv(double* c)
		{
			glIndexdv(c);
		}
		
		[MethodImport("glIndexf", "1.0")]
		private static delegate*<float, void> glIndexf;
		
		public static void Indexf(float c)
		{
			glIndexf(c);
		}
		
		[MethodImport("glIndexfv", "1.0")]
		private static delegate*<float*, void> glIndexfv;
		
		public static void Indexfv(float* c)
		{
			glIndexfv(c);
		}
		
		[MethodImport("glIndexi", "1.0")]
		private static delegate*<int, void> glIndexi;
		
		public static void Indexi(int c)
		{
			glIndexi(c);
		}
		
		[MethodImport("glIndexiv", "1.0")]
		private static delegate*<int*, void> glIndexiv;
		
		public static void Indexiv(int* c)
		{
			glIndexiv(c);
		}
		
		[MethodImport("glIndexs", "1.0")]
		private static delegate*<short, void> glIndexs;
		
		public static void Indexs(short c)
		{
			glIndexs(c);
		}
		
		[MethodImport("glIndexsv", "1.0")]
		private static delegate*<short*, void> glIndexsv;
		
		public static void Indexsv(short* c)
		{
			glIndexsv(c);
		}
		
		[MethodImport("glNormal3b", "1.0")]
		private static delegate*<sbyte, sbyte, sbyte, void> glNormal3b;
		
		public static void Normal3b(sbyte nx, sbyte ny, sbyte nz)
		{
			glNormal3b(nx, ny, nz);
		}
		
		[MethodImport("glNormal3bv", "1.0")]
		private static delegate*<sbyte*, void> glNormal3bv;
		
		public static void Normal3bv(sbyte* v)
		{
			glNormal3bv(v);
		}
		
		[MethodImport("glNormal3d", "1.0")]
		private static delegate*<double, double, double, void> glNormal3d;
		
		public static void Normal3d(double nx, double ny, double nz)
		{
			glNormal3d(nx, ny, nz);
		}
		
		[MethodImport("glNormal3dv", "1.0")]
		private static delegate*<double*, void> glNormal3dv;
		
		public static void Normal3dv(double* v)
		{
			glNormal3dv(v);
		}
		
		[MethodImport("glNormal3f", "1.0")]
		private static delegate*<float, float, float, void> glNormal3f;
		
		public static void Normal3f(float nx, float ny, float nz)
		{
			glNormal3f(nx, ny, nz);
		}
		
		[MethodImport("glNormal3fv", "1.0")]
		private static delegate*<float*, void> glNormal3fv;
		
		public static void Normal3fv(float* v)
		{
			glNormal3fv(v);
		}
		
		[MethodImport("glNormal3i", "1.0")]
		private static delegate*<int, int, int, void> glNormal3i;
		
		public static void Normal3i(int nx, int ny, int nz)
		{
			glNormal3i(nx, ny, nz);
		}
		
		[MethodImport("glNormal3iv", "1.0")]
		private static delegate*<int*, void> glNormal3iv;
		
		public static void Normal3iv(int* v)
		{
			glNormal3iv(v);
		}
		
		[MethodImport("glNormal3s", "1.0")]
		private static delegate*<short, short, short, void> glNormal3s;
		
		public static void Normal3s(short nx, short ny, short nz)
		{
			glNormal3s(nx, ny, nz);
		}
		
		[MethodImport("glNormal3sv", "1.0")]
		private static delegate*<short*, void> glNormal3sv;
		
		public static void Normal3sv(short* v)
		{
			glNormal3sv(v);
		}
		
		[MethodImport("glRasterPos2d", "1.0")]
		private static delegate*<double, double, void> glRasterPos2d;
		
		public static void RasterPos2d(double x, double y)
		{
			glRasterPos2d(x, y);
		}
		
		[MethodImport("glRasterPos2dv", "1.0")]
		private static delegate*<double*, void> glRasterPos2dv;
		
		public static void RasterPos2dv(double* v)
		{
			glRasterPos2dv(v);
		}
		
		[MethodImport("glRasterPos2f", "1.0")]
		private static delegate*<float, float, void> glRasterPos2f;
		
		public static void RasterPos2f(float x, float y)
		{
			glRasterPos2f(x, y);
		}
		
		[MethodImport("glRasterPos2fv", "1.0")]
		private static delegate*<float*, void> glRasterPos2fv;
		
		public static void RasterPos2fv(float* v)
		{
			glRasterPos2fv(v);
		}
		
		[MethodImport("glRasterPos2i", "1.0")]
		private static delegate*<int, int, void> glRasterPos2i;
		
		public static void RasterPos2i(int x, int y)
		{
			glRasterPos2i(x, y);
		}
		
		[MethodImport("glRasterPos2iv", "1.0")]
		private static delegate*<int*, void> glRasterPos2iv;
		
		public static void RasterPos2iv(int* v)
		{
			glRasterPos2iv(v);
		}
		
		[MethodImport("glRasterPos2s", "1.0")]
		private static delegate*<short, short, void> glRasterPos2s;
		
		public static void RasterPos2s(short x, short y)
		{
			glRasterPos2s(x, y);
		}
		
		[MethodImport("glRasterPos2sv", "1.0")]
		private static delegate*<short*, void> glRasterPos2sv;
		
		public static void RasterPos2sv(short* v)
		{
			glRasterPos2sv(v);
		}
		
		[MethodImport("glRasterPos3d", "1.0")]
		private static delegate*<double, double, double, void> glRasterPos3d;
		
		public static void RasterPos3d(double x, double y, double z)
		{
			glRasterPos3d(x, y, z);
		}
		
		[MethodImport("glRasterPos3dv", "1.0")]
		private static delegate*<double*, void> glRasterPos3dv;
		
		public static void RasterPos3dv(double* v)
		{
			glRasterPos3dv(v);
		}
		
		[MethodImport("glRasterPos3f", "1.0")]
		private static delegate*<float, float, float, void> glRasterPos3f;
		
		public static void RasterPos3f(float x, float y, float z)
		{
			glRasterPos3f(x, y, z);
		}
		
		[MethodImport("glRasterPos3fv", "1.0")]
		private static delegate*<float*, void> glRasterPos3fv;
		
		public static void RasterPos3fv(float* v)
		{
			glRasterPos3fv(v);
		}
		
		[MethodImport("glRasterPos3i", "1.0")]
		private static delegate*<int, int, int, void> glRasterPos3i;
		
		public static void RasterPos3i(int x, int y, int z)
		{
			glRasterPos3i(x, y, z);
		}
		
		[MethodImport("glRasterPos3iv", "1.0")]
		private static delegate*<int*, void> glRasterPos3iv;
		
		public static void RasterPos3iv(int* v)
		{
			glRasterPos3iv(v);
		}
		
		[MethodImport("glRasterPos3s", "1.0")]
		private static delegate*<short, short, short, void> glRasterPos3s;
		
		public static void RasterPos3s(short x, short y, short z)
		{
			glRasterPos3s(x, y, z);
		}
		
		[MethodImport("glRasterPos3sv", "1.0")]
		private static delegate*<short*, void> glRasterPos3sv;
		
		public static void RasterPos3sv(short* v)
		{
			glRasterPos3sv(v);
		}
		
		[MethodImport("glRasterPos4d", "1.0")]
		private static delegate*<double, double, double, double, void> glRasterPos4d;
		
		public static void RasterPos4d(double x, double y, double z, double w)
		{
			glRasterPos4d(x, y, z, w);
		}
		
		[MethodImport("glRasterPos4dv", "1.0")]
		private static delegate*<double*, void> glRasterPos4dv;
		
		public static void RasterPos4dv(double* v)
		{
			glRasterPos4dv(v);
		}
		
		[MethodImport("glRasterPos4f", "1.0")]
		private static delegate*<float, float, float, float, void> glRasterPos4f;
		
		public static void RasterPos4f(float x, float y, float z, float w)
		{
			glRasterPos4f(x, y, z, w);
		}
		
		[MethodImport("glRasterPos4fv", "1.0")]
		private static delegate*<float*, void> glRasterPos4fv;
		
		public static void RasterPos4fv(float* v)
		{
			glRasterPos4fv(v);
		}
		
		[MethodImport("glRasterPos4i", "1.0")]
		private static delegate*<int, int, int, int, void> glRasterPos4i;
		
		public static void RasterPos4i(int x, int y, int z, int w)
		{
			glRasterPos4i(x, y, z, w);
		}
		
		[MethodImport("glRasterPos4iv", "1.0")]
		private static delegate*<int*, void> glRasterPos4iv;
		
		public static void RasterPos4iv(int* v)
		{
			glRasterPos4iv(v);
		}
		
		[MethodImport("glRasterPos4s", "1.0")]
		private static delegate*<short, short, short, short, void> glRasterPos4s;
		
		public static void RasterPos4s(short x, short y, short z, short w)
		{
			glRasterPos4s(x, y, z, w);
		}
		
		[MethodImport("glRasterPos4sv", "1.0")]
		private static delegate*<short*, void> glRasterPos4sv;
		
		public static void RasterPos4sv(short* v)
		{
			glRasterPos4sv(v);
		}
		
		[MethodImport("glRectd", "1.0")]
		private static delegate*<double, double, double, double, void> glRectd;
		
		public static void Rectd(double x1, double y1, double x2, double y2)
		{
			glRectd(x1, y1, x2, y2);
		}
		
		[MethodImport("glRectdv", "1.0")]
		private static delegate*<double*, double*, void> glRectdv;
		
		public static void Rectdv(double* v1, double* v2)
		{
			glRectdv(v1, v2);
		}
		
		[MethodImport("glRectf", "1.0")]
		private static delegate*<float, float, float, float, void> glRectf;
		
		public static void Rectf(float x1, float y1, float x2, float y2)
		{
			glRectf(x1, y1, x2, y2);
		}
		
		[MethodImport("glRectfv", "1.0")]
		private static delegate*<float*, float*, void> glRectfv;
		
		public static void Rectfv(float* v1, float* v2)
		{
			glRectfv(v1, v2);
		}
		
		[MethodImport("glRecti", "1.0")]
		private static delegate*<int, int, int, int, void> glRecti;
		
		public static void Recti(int x1, int y1, int x2, int y2)
		{
			glRecti(x1, y1, x2, y2);
		}
		
		[MethodImport("glRectiv", "1.0")]
		private static delegate*<int*, int*, void> glRectiv;
		
		public static void Rectiv(int* v1, int* v2)
		{
			glRectiv(v1, v2);
		}
		
		[MethodImport("glRects", "1.0")]
		private static delegate*<short, short, short, short, void> glRects;
		
		public static void Rects(short x1, short y1, short x2, short y2)
		{
			glRects(x1, y1, x2, y2);
		}
		
		[MethodImport("glRectsv", "1.0")]
		private static delegate*<short*, short*, void> glRectsv;
		
		public static void Rectsv(short* v1, short* v2)
		{
			glRectsv(v1, v2);
		}
		
		[MethodImport("glTexCoord1d", "1.0")]
		private static delegate*<double, void> glTexCoord1d;
		
		public static void TexCoord1d(double s)
		{
			glTexCoord1d(s);
		}
		
		[MethodImport("glTexCoord1dv", "1.0")]
		private static delegate*<double*, void> glTexCoord1dv;
		
		public static void TexCoord1dv(double* v)
		{
			glTexCoord1dv(v);
		}
		
		[MethodImport("glTexCoord1f", "1.0")]
		private static delegate*<float, void> glTexCoord1f;
		
		public static void TexCoord1f(float s)
		{
			glTexCoord1f(s);
		}
		
		[MethodImport("glTexCoord1fv", "1.0")]
		private static delegate*<float*, void> glTexCoord1fv;
		
		public static void TexCoord1fv(float* v)
		{
			glTexCoord1fv(v);
		}
		
		[MethodImport("glTexCoord1i", "1.0")]
		private static delegate*<int, void> glTexCoord1i;
		
		public static void TexCoord1i(int s)
		{
			glTexCoord1i(s);
		}
		
		[MethodImport("glTexCoord1iv", "1.0")]
		private static delegate*<int*, void> glTexCoord1iv;
		
		public static void TexCoord1iv(int* v)
		{
			glTexCoord1iv(v);
		}
		
		[MethodImport("glTexCoord1s", "1.0")]
		private static delegate*<short, void> glTexCoord1s;
		
		public static void TexCoord1s(short s)
		{
			glTexCoord1s(s);
		}
		
		[MethodImport("glTexCoord1sv", "1.0")]
		private static delegate*<short*, void> glTexCoord1sv;
		
		public static void TexCoord1sv(short* v)
		{
			glTexCoord1sv(v);
		}
		
		[MethodImport("glTexCoord2d", "1.0")]
		private static delegate*<double, double, void> glTexCoord2d;
		
		public static void TexCoord2d(double s, double t)
		{
			glTexCoord2d(s, t);
		}
		
		[MethodImport("glTexCoord2dv", "1.0")]
		private static delegate*<double*, void> glTexCoord2dv;
		
		public static void TexCoord2dv(double* v)
		{
			glTexCoord2dv(v);
		}
		
		[MethodImport("glTexCoord2f", "1.0")]
		private static delegate*<float, float, void> glTexCoord2f;
		
		public static void TexCoord2f(float s, float t)
		{
			glTexCoord2f(s, t);
		}
		
		[MethodImport("glTexCoord2fv", "1.0")]
		private static delegate*<float*, void> glTexCoord2fv;
		
		public static void TexCoord2fv(float* v)
		{
			glTexCoord2fv(v);
		}
		
		[MethodImport("glTexCoord2i", "1.0")]
		private static delegate*<int, int, void> glTexCoord2i;
		
		public static void TexCoord2i(int s, int t)
		{
			glTexCoord2i(s, t);
		}
		
		[MethodImport("glTexCoord2iv", "1.0")]
		private static delegate*<int*, void> glTexCoord2iv;
		
		public static void TexCoord2iv(int* v)
		{
			glTexCoord2iv(v);
		}
		
		[MethodImport("glTexCoord2s", "1.0")]
		private static delegate*<short, short, void> glTexCoord2s;
		
		public static void TexCoord2s(short s, short t)
		{
			glTexCoord2s(s, t);
		}
		
		[MethodImport("glTexCoord2sv", "1.0")]
		private static delegate*<short*, void> glTexCoord2sv;
		
		public static void TexCoord2sv(short* v)
		{
			glTexCoord2sv(v);
		}
		
		[MethodImport("glTexCoord3d", "1.0")]
		private static delegate*<double, double, double, void> glTexCoord3d;
		
		public static void TexCoord3d(double s, double t, double r)
		{
			glTexCoord3d(s, t, r);
		}
		
		[MethodImport("glTexCoord3dv", "1.0")]
		private static delegate*<double*, void> glTexCoord3dv;
		
		public static void TexCoord3dv(double* v)
		{
			glTexCoord3dv(v);
		}
		
		[MethodImport("glTexCoord3f", "1.0")]
		private static delegate*<float, float, float, void> glTexCoord3f;
		
		public static void TexCoord3f(float s, float t, float r)
		{
			glTexCoord3f(s, t, r);
		}
		
		[MethodImport("glTexCoord3fv", "1.0")]
		private static delegate*<float*, void> glTexCoord3fv;
		
		public static void TexCoord3fv(float* v)
		{
			glTexCoord3fv(v);
		}
		
		[MethodImport("glTexCoord3i", "1.0")]
		private static delegate*<int, int, int, void> glTexCoord3i;
		
		public static void TexCoord3i(int s, int t, int r)
		{
			glTexCoord3i(s, t, r);
		}
		
		[MethodImport("glTexCoord3iv", "1.0")]
		private static delegate*<int*, void> glTexCoord3iv;
		
		public static void TexCoord3iv(int* v)
		{
			glTexCoord3iv(v);
		}
		
		[MethodImport("glTexCoord3s", "1.0")]
		private static delegate*<short, short, short, void> glTexCoord3s;
		
		public static void TexCoord3s(short s, short t, short r)
		{
			glTexCoord3s(s, t, r);
		}
		
		[MethodImport("glTexCoord3sv", "1.0")]
		private static delegate*<short*, void> glTexCoord3sv;
		
		public static void TexCoord3sv(short* v)
		{
			glTexCoord3sv(v);
		}
		
		[MethodImport("glTexCoord4d", "1.0")]
		private static delegate*<double, double, double, double, void> glTexCoord4d;
		
		public static void TexCoord4d(double s, double t, double r, double q)
		{
			glTexCoord4d(s, t, r, q);
		}
		
		[MethodImport("glTexCoord4dv", "1.0")]
		private static delegate*<double*, void> glTexCoord4dv;
		
		public static void TexCoord4dv(double* v)
		{
			glTexCoord4dv(v);
		}
		
		[MethodImport("glTexCoord4f", "1.0")]
		private static delegate*<float, float, float, float, void> glTexCoord4f;
		
		public static void TexCoord4f(float s, float t, float r, float q)
		{
			glTexCoord4f(s, t, r, q);
		}
		
		[MethodImport("glTexCoord4fv", "1.0")]
		private static delegate*<float*, void> glTexCoord4fv;
		
		public static void TexCoord4fv(float* v)
		{
			glTexCoord4fv(v);
		}
		
		[MethodImport("glTexCoord4i", "1.0")]
		private static delegate*<int, int, int, int, void> glTexCoord4i;
		
		public static void TexCoord4i(int s, int t, int r, int q)
		{
			glTexCoord4i(s, t, r, q);
		}
		
		[MethodImport("glTexCoord4iv", "1.0")]
		private static delegate*<int*, void> glTexCoord4iv;
		
		public static void TexCoord4iv(int* v)
		{
			glTexCoord4iv(v);
		}
		
		[MethodImport("glTexCoord4s", "1.0")]
		private static delegate*<short, short, short, short, void> glTexCoord4s;
		
		public static void TexCoord4s(short s, short t, short r, short q)
		{
			glTexCoord4s(s, t, r, q);
		}
		
		[MethodImport("glTexCoord4sv", "1.0")]
		private static delegate*<short*, void> glTexCoord4sv;
		
		public static void TexCoord4sv(short* v)
		{
			glTexCoord4sv(v);
		}
		
		[MethodImport("glVertex2d", "1.0")]
		private static delegate*<double, double, void> glVertex2d;
		
		public static void Vertex2d(double x, double y)
		{
			glVertex2d(x, y);
		}
		
		[MethodImport("glVertex2dv", "1.0")]
		private static delegate*<double*, void> glVertex2dv;
		
		public static void Vertex2dv(double* v)
		{
			glVertex2dv(v);
		}
		
		[MethodImport("glVertex2f", "1.0")]
		private static delegate*<float, float, void> glVertex2f;
		
		public static void Vertex2f(float x, float y)
		{
			glVertex2f(x, y);
		}
		
		[MethodImport("glVertex2fv", "1.0")]
		private static delegate*<float*, void> glVertex2fv;
		
		public static void Vertex2fv(float* v)
		{
			glVertex2fv(v);
		}
		
		[MethodImport("glVertex2i", "1.0")]
		private static delegate*<int, int, void> glVertex2i;
		
		public static void Vertex2i(int x, int y)
		{
			glVertex2i(x, y);
		}
		
		[MethodImport("glVertex2iv", "1.0")]
		private static delegate*<int*, void> glVertex2iv;
		
		public static void Vertex2iv(int* v)
		{
			glVertex2iv(v);
		}
		
		[MethodImport("glVertex2s", "1.0")]
		private static delegate*<short, short, void> glVertex2s;
		
		public static void Vertex2s(short x, short y)
		{
			glVertex2s(x, y);
		}
		
		[MethodImport("glVertex2sv", "1.0")]
		private static delegate*<short*, void> glVertex2sv;
		
		public static void Vertex2sv(short* v)
		{
			glVertex2sv(v);
		}
		
		[MethodImport("glVertex3d", "1.0")]
		private static delegate*<double, double, double, void> glVertex3d;
		
		public static void Vertex3d(double x, double y, double z)
		{
			glVertex3d(x, y, z);
		}
		
		[MethodImport("glVertex3dv", "1.0")]
		private static delegate*<double*, void> glVertex3dv;
		
		public static void Vertex3dv(double* v)
		{
			glVertex3dv(v);
		}
		
		[MethodImport("glVertex3f", "1.0")]
		private static delegate*<float, float, float, void> glVertex3f;
		
		public static void Vertex3f(float x, float y, float z)
		{
			glVertex3f(x, y, z);
		}
		
		[MethodImport("glVertex3fv", "1.0")]
		private static delegate*<float*, void> glVertex3fv;
		
		public static void Vertex3fv(float* v)
		{
			glVertex3fv(v);
		}
		
		[MethodImport("glVertex3i", "1.0")]
		private static delegate*<int, int, int, void> glVertex3i;
		
		public static void Vertex3i(int x, int y, int z)
		{
			glVertex3i(x, y, z);
		}
		
		[MethodImport("glVertex3iv", "1.0")]
		private static delegate*<int*, void> glVertex3iv;
		
		public static void Vertex3iv(int* v)
		{
			glVertex3iv(v);
		}
		
		[MethodImport("glVertex3s", "1.0")]
		private static delegate*<short, short, short, void> glVertex3s;
		
		public static void Vertex3s(short x, short y, short z)
		{
			glVertex3s(x, y, z);
		}
		
		[MethodImport("glVertex3sv", "1.0")]
		private static delegate*<short*, void> glVertex3sv;
		
		public static void Vertex3sv(short* v)
		{
			glVertex3sv(v);
		}
		
		[MethodImport("glVertex4d", "1.0")]
		private static delegate*<double, double, double, double, void> glVertex4d;
		
		public static void Vertex4d(double x, double y, double z, double w)
		{
			glVertex4d(x, y, z, w);
		}
		
		[MethodImport("glVertex4dv", "1.0")]
		private static delegate*<double*, void> glVertex4dv;
		
		public static void Vertex4dv(double* v)
		{
			glVertex4dv(v);
		}
		
		[MethodImport("glVertex4f", "1.0")]
		private static delegate*<float, float, float, float, void> glVertex4f;
		
		public static void Vertex4f(float x, float y, float z, float w)
		{
			glVertex4f(x, y, z, w);
		}
		
		[MethodImport("glVertex4fv", "1.0")]
		private static delegate*<float*, void> glVertex4fv;
		
		public static void Vertex4fv(float* v)
		{
			glVertex4fv(v);
		}
		
		[MethodImport("glVertex4i", "1.0")]
		private static delegate*<int, int, int, int, void> glVertex4i;
		
		public static void Vertex4i(int x, int y, int z, int w)
		{
			glVertex4i(x, y, z, w);
		}
		
		[MethodImport("glVertex4iv", "1.0")]
		private static delegate*<int*, void> glVertex4iv;
		
		public static void Vertex4iv(int* v)
		{
			glVertex4iv(v);
		}
		
		[MethodImport("glVertex4s", "1.0")]
		private static delegate*<short, short, short, short, void> glVertex4s;
		
		public static void Vertex4s(short x, short y, short z, short w)
		{
			glVertex4s(x, y, z, w);
		}
		
		[MethodImport("glVertex4sv", "1.0")]
		private static delegate*<short*, void> glVertex4sv;
		
		public static void Vertex4sv(short* v)
		{
			glVertex4sv(v);
		}
		
		[MethodImport("glClipPlane", "1.0")]
		private static delegate*<ClipPlaneName, double*, void> glClipPlane;
		
		public static void ClipPlane(ClipPlaneName plane, double* equation)
		{
			glClipPlane(plane, equation);
		}
		
		[MethodImport("glColorMaterial", "1.0")]
		private static delegate*<MaterialFace, ColorMaterialParameter, void> glColorMaterial;
		
		public static void ColorMaterial(MaterialFace face, ColorMaterialParameter mode)
		{
			glColorMaterial(face, mode);
		}
		
		[MethodImport("glFogf", "1.0")]
		private static delegate*<FogParameter, float, void> glFogf;
		
		public static void Fogf(FogParameter pname, float param)
		{
			glFogf(pname, param);
		}
		
		[MethodImport("glFogfv", "1.0")]
		private static delegate*<FogParameter, float*, void> glFogfv;
		
		public static void Fogfv(FogParameter pname, float* @params)
		{
			glFogfv(pname, @params);
		}
		
		[MethodImport("glFogi", "1.0")]
		private static delegate*<FogParameter, int, void> glFogi;
		
		public static void Fogi(FogParameter pname, int param)
		{
			glFogi(pname, param);
		}
		
		[MethodImport("glFogiv", "1.0")]
		private static delegate*<FogParameter, int*, void> glFogiv;
		
		public static void Fogiv(FogParameter pname, int* @params)
		{
			glFogiv(pname, @params);
		}
		
		[MethodImport("glLightf", "1.0")]
		private static delegate*<LightName, LightParameter, float, void> glLightf;
		
		public static void Lightf(LightName light, LightParameter pname, float param)
		{
			glLightf(light, pname, param);
		}
		
		[MethodImport("glLightfv", "1.0")]
		private static delegate*<LightName, LightParameter, float*, void> glLightfv;
		
		public static void Lightfv(LightName light, LightParameter pname, float* @params)
		{
			glLightfv(light, pname, @params);
		}
		
		[MethodImport("glLighti", "1.0")]
		private static delegate*<LightName, LightParameter, int, void> glLighti;
		
		public static void Lighti(LightName light, LightParameter pname, int param)
		{
			glLighti(light, pname, param);
		}
		
		[MethodImport("glLightiv", "1.0")]
		private static delegate*<LightName, LightParameter, int*, void> glLightiv;
		
		public static void Lightiv(LightName light, LightParameter pname, int* @params)
		{
			glLightiv(light, pname, @params);
		}
		
		[MethodImport("glLightModelf", "1.0")]
		private static delegate*<LightModelParameter, float, void> glLightModelf;
		
		public static void LightModelf(LightModelParameter pname, float param)
		{
			glLightModelf(pname, param);
		}
		
		[MethodImport("glLightModelfv", "1.0")]
		private static delegate*<LightModelParameter, float*, void> glLightModelfv;
		
		public static void LightModelfv(LightModelParameter pname, float* @params)
		{
			glLightModelfv(pname, @params);
		}
		
		[MethodImport("glLightModeli", "1.0")]
		private static delegate*<LightModelParameter, int, void> glLightModeli;
		
		public static void LightModeli(LightModelParameter pname, int param)
		{
			glLightModeli(pname, param);
		}
		
		[MethodImport("glLightModeliv", "1.0")]
		private static delegate*<LightModelParameter, int*, void> glLightModeliv;
		
		public static void LightModeliv(LightModelParameter pname, int* @params)
		{
			glLightModeliv(pname, @params);
		}
		
		[MethodImport("glLineStipple", "1.0")]
		private static delegate*<int, ushort, void> glLineStipple;
		
		public static void LineStipple(int factor, ushort pattern)
		{
			glLineStipple(factor, pattern);
		}
		
		[MethodImport("glMaterialf", "1.0")]
		private static delegate*<MaterialFace, MaterialParameter, float, void> glMaterialf;
		
		public static void Materialf(MaterialFace face, MaterialParameter pname, float param)
		{
			glMaterialf(face, pname, param);
		}
		
		[MethodImport("glMaterialfv", "1.0")]
		private static delegate*<MaterialFace, MaterialParameter, float*, void> glMaterialfv;
		
		public static void Materialfv(MaterialFace face, MaterialParameter pname, float* @params)
		{
			glMaterialfv(face, pname, @params);
		}
		
		[MethodImport("glMateriali", "1.0")]
		private static delegate*<MaterialFace, MaterialParameter, int, void> glMateriali;
		
		public static void Materiali(MaterialFace face, MaterialParameter pname, int param)
		{
			glMateriali(face, pname, param);
		}
		
		[MethodImport("glMaterialiv", "1.0")]
		private static delegate*<MaterialFace, MaterialParameter, int*, void> glMaterialiv;
		
		public static void Materialiv(MaterialFace face, MaterialParameter pname, int* @params)
		{
			glMaterialiv(face, pname, @params);
		}
		
		[MethodImport("glPolygonStipple", "1.0")]
		private static delegate*<byte*, void> glPolygonStipple;
		
		public static void PolygonStipple(byte* mask)
		{
			glPolygonStipple(mask);
		}
		
		[MethodImport("glShadeModel", "1.0")]
		private static delegate*<ShadingModel, void> glShadeModel;
		
		public static void ShadeModel(ShadingModel mode)
		{
			glShadeModel(mode);
		}
		
		[MethodImport("glTexEnvf", "1.0")]
		private static delegate*<TextureEnvTarget, TextureEnvParameter, float, void> glTexEnvf;
		
		public static void TexEnvf(TextureEnvTarget target, TextureEnvParameter pname, float param)
		{
			glTexEnvf(target, pname, param);
		}
		
		[MethodImport("glTexEnvfv", "1.0")]
		private static delegate*<TextureEnvTarget, TextureEnvParameter, float*, void> glTexEnvfv;
		
		public static void TexEnvfv(TextureEnvTarget target, TextureEnvParameter pname, float* @params)
		{
			glTexEnvfv(target, pname, @params);
		}
		
		[MethodImport("glTexEnvi", "1.0")]
		private static delegate*<TextureEnvTarget, TextureEnvParameter, int, void> glTexEnvi;
		
		public static void TexEnvi(TextureEnvTarget target, TextureEnvParameter pname, int param)
		{
			glTexEnvi(target, pname, param);
		}
		
		[MethodImport("glTexEnviv", "1.0")]
		private static delegate*<TextureEnvTarget, TextureEnvParameter, int*, void> glTexEnviv;
		
		public static void TexEnviv(TextureEnvTarget target, TextureEnvParameter pname, int* @params)
		{
			glTexEnviv(target, pname, @params);
		}
		
		[MethodImport("glTexGend", "1.0")]
		private static delegate*<TextureCoordName, TextureGenParameter, double, void> glTexGend;
		
		public static void TexGend(TextureCoordName coord, TextureGenParameter pname, double param)
		{
			glTexGend(coord, pname, param);
		}
		
		[MethodImport("glTexGendv", "1.0")]
		private static delegate*<TextureCoordName, TextureGenParameter, double*, void> glTexGendv;
		
		public static void TexGendv(TextureCoordName coord, TextureGenParameter pname, double* @params)
		{
			glTexGendv(coord, pname, @params);
		}
		
		[MethodImport("glTexGenf", "1.0")]
		private static delegate*<TextureCoordName, TextureGenParameter, float, void> glTexGenf;
		
		public static void TexGenf(TextureCoordName coord, TextureGenParameter pname, float param)
		{
			glTexGenf(coord, pname, param);
		}
		
		[MethodImport("glTexGenfv", "1.0")]
		private static delegate*<TextureCoordName, TextureGenParameter, float*, void> glTexGenfv;
		
		public static void TexGenfv(TextureCoordName coord, TextureGenParameter pname, float* @params)
		{
			glTexGenfv(coord, pname, @params);
		}
		
		[MethodImport("glTexGeni", "1.0")]
		private static delegate*<TextureCoordName, TextureGenParameter, int, void> glTexGeni;
		
		public static void TexGeni(TextureCoordName coord, TextureGenParameter pname, int param)
		{
			glTexGeni(coord, pname, param);
		}
		
		[MethodImport("glTexGeniv", "1.0")]
		private static delegate*<TextureCoordName, TextureGenParameter, int*, void> glTexGeniv;
		
		public static void TexGeniv(TextureCoordName coord, TextureGenParameter pname, int* @params)
		{
			glTexGeniv(coord, pname, @params);
		}
		
		[MethodImport("glFeedbackBuffer", "1.0")]
		private static delegate*<int, FeedbackType, float*, void> glFeedbackBuffer;
		
		public static void FeedbackBuffer(int size, FeedbackType type, float* buffer)
		{
			glFeedbackBuffer(size, type, buffer);
		}
		
		[MethodImport("glSelectBuffer", "1.0")]
		private static delegate*<int, uint*, void> glSelectBuffer;
		
		public static void SelectBuffer(int size, uint* buffer)
		{
			glSelectBuffer(size, buffer);
		}
		
		[MethodImport("glRenderMode", "1.0")]
		private static delegate*<RenderingMode, int> glRenderMode;
		
		public static int RenderMode(RenderingMode mode)
		{
			return glRenderMode(mode);
		}
		
		[MethodImport("glInitNames", "1.0")]
		private static delegate*<void> glInitNames;
		
		public static void InitNames()
		{
			glInitNames();
		}
		
		[MethodImport("glLoadName", "1.0")]
		private static delegate*<uint, void> glLoadName;
		
		public static void LoadName(uint name)
		{
			glLoadName(name);
		}
		
		[MethodImport("glPassThrough", "1.0")]
		private static delegate*<float, void> glPassThrough;
		
		public static void PassThrough(float token)
		{
			glPassThrough(token);
		}
		
		[MethodImport("glPopName", "1.0")]
		private static delegate*<void> glPopName;
		
		public static void PopName()
		{
			glPopName();
		}
		
		[MethodImport("glPushName", "1.0")]
		private static delegate*<uint, void> glPushName;
		
		public static void PushName(uint name)
		{
			glPushName(name);
		}
		
		[MethodImport("glClearAccum", "1.0")]
		private static delegate*<float, float, float, float, void> glClearAccum;
		
		public static void ClearAccum(float red, float green, float blue, float alpha)
		{
			glClearAccum(red, green, blue, alpha);
		}
		
		[MethodImport("glClearIndex", "1.0")]
		private static delegate*<float, void> glClearIndex;
		
		public static void ClearIndex(float c)
		{
			glClearIndex(c);
		}
		
		[MethodImport("glIndexMask", "1.0")]
		private static delegate*<uint, void> glIndexMask;
		
		public static void IndexMask(uint mask)
		{
			glIndexMask(mask);
		}
		
		[MethodImport("glAccum", "1.0")]
		private static delegate*<AccumOp, float, void> glAccum;
		
		public static void Accum(AccumOp op, float value)
		{
			glAccum(op, value);
		}
		
		[MethodImport("glPopAttrib", "1.0")]
		private static delegate*<void> glPopAttrib;
		
		public static void PopAttrib()
		{
			glPopAttrib();
		}
		
		[MethodImport("glPushAttrib", "1.0")]
		private static delegate*<AttribMask, void> glPushAttrib;
		
		public static void PushAttrib(AttribMask mask)
		{
			glPushAttrib(mask);
		}
		
		[MethodImport("glMap1d", "1.0")]
		private static delegate*<MapTarget, double, double, int, int, double*, void> glMap1d;
		
		public static void Map1d(MapTarget target, double u1, double u2, int stride, int order, double* points)
		{
			glMap1d(target, u1, u2, stride, order, points);
		}
		
		[MethodImport("glMap1f", "1.0")]
		private static delegate*<MapTarget, float, float, int, int, float*, void> glMap1f;
		
		public static void Map1f(MapTarget target, float u1, float u2, int stride, int order, float* points)
		{
			glMap1f(target, u1, u2, stride, order, points);
		}
		
		[MethodImport("glMap2d", "1.0")]
		private static delegate*<MapTarget, double, double, int, int, double, double, int, int, double*, void> glMap2d;
		
		public static void Map2d(MapTarget target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double* points)
		{
			glMap2d(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
		}
		
		[MethodImport("glMap2f", "1.0")]
		private static delegate*<MapTarget, float, float, int, int, float, float, int, int, float*, void> glMap2f;
		
		public static void Map2f(MapTarget target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float* points)
		{
			glMap2f(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
		}
		
		[MethodImport("glMapGrid1d", "1.0")]
		private static delegate*<int, double, double, void> glMapGrid1d;
		
		public static void MapGrid1d(int un, double u1, double u2)
		{
			glMapGrid1d(un, u1, u2);
		}
		
		[MethodImport("glMapGrid1f", "1.0")]
		private static delegate*<int, float, float, void> glMapGrid1f;
		
		public static void MapGrid1f(int un, float u1, float u2)
		{
			glMapGrid1f(un, u1, u2);
		}
		
		[MethodImport("glMapGrid2d", "1.0")]
		private static delegate*<int, double, double, int, double, double, void> glMapGrid2d;
		
		public static void MapGrid2d(int un, double u1, double u2, int vn, double v1, double v2)
		{
			glMapGrid2d(un, u1, u2, vn, v1, v2);
		}
		
		[MethodImport("glMapGrid2f", "1.0")]
		private static delegate*<int, float, float, int, float, float, void> glMapGrid2f;
		
		public static void MapGrid2f(int un, float u1, float u2, int vn, float v1, float v2)
		{
			glMapGrid2f(un, u1, u2, vn, v1, v2);
		}
		
		[MethodImport("glEvalCoord1d", "1.0")]
		private static delegate*<double, void> glEvalCoord1d;
		
		public static void EvalCoord1d(double u)
		{
			glEvalCoord1d(u);
		}
		
		[MethodImport("glEvalCoord1dv", "1.0")]
		private static delegate*<double*, void> glEvalCoord1dv;
		
		public static void EvalCoord1dv(double* u)
		{
			glEvalCoord1dv(u);
		}
		
		[MethodImport("glEvalCoord1f", "1.0")]
		private static delegate*<float, void> glEvalCoord1f;
		
		public static void EvalCoord1f(float u)
		{
			glEvalCoord1f(u);
		}
		
		[MethodImport("glEvalCoord1fv", "1.0")]
		private static delegate*<float*, void> glEvalCoord1fv;
		
		public static void EvalCoord1fv(float* u)
		{
			glEvalCoord1fv(u);
		}
		
		[MethodImport("glEvalCoord2d", "1.0")]
		private static delegate*<double, double, void> glEvalCoord2d;
		
		public static void EvalCoord2d(double u, double v)
		{
			glEvalCoord2d(u, v);
		}
		
		[MethodImport("glEvalCoord2dv", "1.0")]
		private static delegate*<double*, void> glEvalCoord2dv;
		
		public static void EvalCoord2dv(double* u)
		{
			glEvalCoord2dv(u);
		}
		
		[MethodImport("glEvalCoord2f", "1.0")]
		private static delegate*<float, float, void> glEvalCoord2f;
		
		public static void EvalCoord2f(float u, float v)
		{
			glEvalCoord2f(u, v);
		}
		
		[MethodImport("glEvalCoord2fv", "1.0")]
		private static delegate*<float*, void> glEvalCoord2fv;
		
		public static void EvalCoord2fv(float* u)
		{
			glEvalCoord2fv(u);
		}
		
		[MethodImport("glEvalMesh1", "1.0")]
		private static delegate*<MeshMode1, int, int, void> glEvalMesh1;
		
		public static void EvalMesh1(MeshMode1 mode, int i1, int i2)
		{
			glEvalMesh1(mode, i1, i2);
		}
		
		[MethodImport("glEvalPoint1", "1.0")]
		private static delegate*<int, void> glEvalPoint1;
		
		public static void EvalPoint1(int i)
		{
			glEvalPoint1(i);
		}
		
		[MethodImport("glEvalMesh2", "1.0")]
		private static delegate*<MeshMode2, int, int, int, int, void> glEvalMesh2;
		
		public static void EvalMesh2(MeshMode2 mode, int i1, int i2, int j1, int j2)
		{
			glEvalMesh2(mode, i1, i2, j1, j2);
		}
		
		[MethodImport("glEvalPoint2", "1.0")]
		private static delegate*<int, int, void> glEvalPoint2;
		
		public static void EvalPoint2(int i, int j)
		{
			glEvalPoint2(i, j);
		}
		
		[MethodImport("glAlphaFunc", "1.0")]
		private static delegate*<AlphaFunction, float, void> glAlphaFunc;
		
		public static void AlphaFunc(AlphaFunction func, float @ref)
		{
			glAlphaFunc(func, @ref);
		}
		
		[MethodImport("glPixelZoom", "1.0")]
		private static delegate*<float, float, void> glPixelZoom;
		
		public static void PixelZoom(float xfactor, float yfactor)
		{
			glPixelZoom(xfactor, yfactor);
		}
		
		[MethodImport("glPixelTransferf", "1.0")]
		private static delegate*<PixelTransferParameter, float, void> glPixelTransferf;
		
		public static void PixelTransferf(PixelTransferParameter pname, float param)
		{
			glPixelTransferf(pname, param);
		}
		
		[MethodImport("glPixelTransferi", "1.0")]
		private static delegate*<PixelTransferParameter, int, void> glPixelTransferi;
		
		public static void PixelTransferi(PixelTransferParameter pname, int param)
		{
			glPixelTransferi(pname, param);
		}
		
		[MethodImport("glPixelMapfv", "1.0")]
		private static delegate*<PixelMap, int, float*, void> glPixelMapfv;
		
		public static void PixelMapfv(PixelMap map, int mapsize, float* values)
		{
			glPixelMapfv(map, mapsize, values);
		}
		
		[MethodImport("glPixelMapuiv", "1.0")]
		private static delegate*<PixelMap, int, uint*, void> glPixelMapuiv;
		
		public static void PixelMapuiv(PixelMap map, int mapsize, uint* values)
		{
			glPixelMapuiv(map, mapsize, values);
		}
		
		[MethodImport("glPixelMapusv", "1.0")]
		private static delegate*<PixelMap, int, ushort*, void> glPixelMapusv;
		
		public static void PixelMapusv(PixelMap map, int mapsize, ushort* values)
		{
			glPixelMapusv(map, mapsize, values);
		}
		
		[MethodImport("glCopyPixels", "1.0")]
		private static delegate*<int, int, int, int, PixelCopyType, void> glCopyPixels;
		
		public static void CopyPixels(int x, int y, int width, int height, PixelCopyType type)
		{
			glCopyPixels(x, y, width, height, type);
		}
		
		[MethodImport("glDrawPixels", "1.0")]
		private static delegate*<int, int, PixelFormat, PixelType, void*, void> glDrawPixels;
		
		public static void DrawPixels(int width, int height, PixelFormat format, PixelType type, void* pixels)
		{
			glDrawPixels(width, height, format, type, pixels);
		}
		
		[MethodImport("glGetClipPlane", "1.0")]
		private static delegate*<ClipPlaneName, double*, void> glGetClipPlane;
		
		public static void GetClipPlane(ClipPlaneName plane, double* equation)
		{
			glGetClipPlane(plane, equation);
		}
		
		[MethodImport("glGetLightfv", "1.0")]
		private static delegate*<LightName, LightParameter, float*, void> glGetLightfv;
		
		public static void GetLightfv(LightName light, LightParameter pname, float* @params)
		{
			glGetLightfv(light, pname, @params);
		}
		
		[MethodImport("glGetLightiv", "1.0")]
		private static delegate*<LightName, LightParameter, int*, void> glGetLightiv;
		
		public static void GetLightiv(LightName light, LightParameter pname, int* @params)
		{
			glGetLightiv(light, pname, @params);
		}
		
		[MethodImport("glGetMapdv", "1.0")]
		private static delegate*<MapTarget, GetMapQuery, double*, void> glGetMapdv;
		
		public static void GetMapdv(MapTarget target, GetMapQuery query, double* v)
		{
			glGetMapdv(target, query, v);
		}
		
		[MethodImport("glGetMapfv", "1.0")]
		private static delegate*<MapTarget, GetMapQuery, float*, void> glGetMapfv;
		
		public static void GetMapfv(MapTarget target, GetMapQuery query, float* v)
		{
			glGetMapfv(target, query, v);
		}
		
		[MethodImport("glGetMapiv", "1.0")]
		private static delegate*<MapTarget, GetMapQuery, int*, void> glGetMapiv;
		
		public static void GetMapiv(MapTarget target, GetMapQuery query, int* v)
		{
			glGetMapiv(target, query, v);
		}
		
		[MethodImport("glGetMaterialfv", "1.0")]
		private static delegate*<MaterialFace, MaterialParameter, float*, void> glGetMaterialfv;
		
		public static void GetMaterialfv(MaterialFace face, MaterialParameter pname, float* @params)
		{
			glGetMaterialfv(face, pname, @params);
		}
		
		[MethodImport("glGetMaterialiv", "1.0")]
		private static delegate*<MaterialFace, MaterialParameter, int*, void> glGetMaterialiv;
		
		public static void GetMaterialiv(MaterialFace face, MaterialParameter pname, int* @params)
		{
			glGetMaterialiv(face, pname, @params);
		}
		
		[MethodImport("glGetPixelMapfv", "1.0")]
		private static delegate*<PixelMap, float*, void> glGetPixelMapfv;
		
		public static void GetPixelMapfv(PixelMap map, float* values)
		{
			glGetPixelMapfv(map, values);
		}
		
		[MethodImport("glGetPixelMapuiv", "1.0")]
		private static delegate*<PixelMap, uint*, void> glGetPixelMapuiv;
		
		public static void GetPixelMapuiv(PixelMap map, uint* values)
		{
			glGetPixelMapuiv(map, values);
		}
		
		[MethodImport("glGetPixelMapusv", "1.0")]
		private static delegate*<PixelMap, ushort*, void> glGetPixelMapusv;
		
		public static void GetPixelMapusv(PixelMap map, ushort* values)
		{
			glGetPixelMapusv(map, values);
		}
		
		[MethodImport("glGetPolygonStipple", "1.0")]
		private static delegate*<byte*, void> glGetPolygonStipple;
		
		public static void GetPolygonStipple(byte* mask)
		{
			glGetPolygonStipple(mask);
		}
		
		[MethodImport("glGetTexEnvfv", "1.0")]
		private static delegate*<TextureEnvTarget, TextureEnvParameter, float*, void> glGetTexEnvfv;
		
		public static void GetTexEnvfv(TextureEnvTarget target, TextureEnvParameter pname, float* @params)
		{
			glGetTexEnvfv(target, pname, @params);
		}
		
		[MethodImport("glGetTexEnviv", "1.0")]
		private static delegate*<TextureEnvTarget, TextureEnvParameter, int*, void> glGetTexEnviv;
		
		public static void GetTexEnviv(TextureEnvTarget target, TextureEnvParameter pname, int* @params)
		{
			glGetTexEnviv(target, pname, @params);
		}
		
		[MethodImport("glGetTexGendv", "1.0")]
		private static delegate*<TextureCoordName, TextureGenParameter, double*, void> glGetTexGendv;
		
		public static void GetTexGendv(TextureCoordName coord, TextureGenParameter pname, double* @params)
		{
			glGetTexGendv(coord, pname, @params);
		}
		
		[MethodImport("glGetTexGenfv", "1.0")]
		private static delegate*<TextureCoordName, TextureGenParameter, float*, void> glGetTexGenfv;
		
		public static void GetTexGenfv(TextureCoordName coord, TextureGenParameter pname, float* @params)
		{
			glGetTexGenfv(coord, pname, @params);
		}
		
		[MethodImport("glGetTexGeniv", "1.0")]
		private static delegate*<TextureCoordName, TextureGenParameter, int*, void> glGetTexGeniv;
		
		public static void GetTexGeniv(TextureCoordName coord, TextureGenParameter pname, int* @params)
		{
			glGetTexGeniv(coord, pname, @params);
		}
		
		[MethodImport("glIsList", "1.0")]
		private static delegate*<uint, bool> glIsList;
		
		public static bool IsList(uint list)
		{
			return glIsList(list);
		}
		
		[MethodImport("glFrustum", "1.0")]
		private static delegate*<double, double, double, double, double, double, void> glFrustum;
		
		public static void Frustum(double left, double right, double bottom, double top, double zNear, double zFar)
		{
			glFrustum(left, right, bottom, top, zNear, zFar);
		}
		
		[MethodImport("glLoadIdentity", "1.0")]
		private static delegate*<void> glLoadIdentity;
		
		public static void LoadIdentity()
		{
			glLoadIdentity();
		}
		
		[MethodImport("glLoadMatrixf", "1.0")]
		private static delegate*<float*, void> glLoadMatrixf;
		
		public static void LoadMatrixf(float* m)
		{
			glLoadMatrixf(m);
		}
		
		[MethodImport("glLoadMatrixd", "1.0")]
		private static delegate*<double*, void> glLoadMatrixd;
		
		public static void LoadMatrixd(double* m)
		{
			glLoadMatrixd(m);
		}
		
		[MethodImport("glMatrixMode", "1.0")]
		private static delegate*<MatrixMode, void> glMatrixMode;
		
		public static void MatrixMode(MatrixMode mode)
		{
			glMatrixMode(mode);
		}
		
		[MethodImport("glMultMatrixf", "1.0")]
		private static delegate*<float*, void> glMultMatrixf;
		
		public static void MultMatrixf(float* m)
		{
			glMultMatrixf(m);
		}
		
		[MethodImport("glMultMatrixd", "1.0")]
		private static delegate*<double*, void> glMultMatrixd;
		
		public static void MultMatrixd(double* m)
		{
			glMultMatrixd(m);
		}
		
		[MethodImport("glOrtho", "1.0")]
		private static delegate*<double, double, double, double, double, double, void> glOrtho;
		
		public static void Ortho(double left, double right, double bottom, double top, double zNear, double zFar)
		{
			glOrtho(left, right, bottom, top, zNear, zFar);
		}
		
		[MethodImport("glPopMatrix", "1.0")]
		private static delegate*<void> glPopMatrix;
		
		public static void PopMatrix()
		{
			glPopMatrix();
		}
		
		[MethodImport("glPushMatrix", "1.0")]
		private static delegate*<void> glPushMatrix;
		
		public static void PushMatrix()
		{
			glPushMatrix();
		}
		
		[MethodImport("glRotated", "1.0")]
		private static delegate*<double, double, double, double, void> glRotated;
		
		public static void Rotated(double angle, double x, double y, double z)
		{
			glRotated(angle, x, y, z);
		}
		
		[MethodImport("glRotatef", "1.0")]
		private static delegate*<float, float, float, float, void> glRotatef;
		
		public static void Rotatef(float angle, float x, float y, float z)
		{
			glRotatef(angle, x, y, z);
		}
		
		[MethodImport("glScaled", "1.0")]
		private static delegate*<double, double, double, void> glScaled;
		
		public static void Scaled(double x, double y, double z)
		{
			glScaled(x, y, z);
		}
		
		[MethodImport("glScalef", "1.0")]
		private static delegate*<float, float, float, void> glScalef;
		
		public static void Scalef(float x, float y, float z)
		{
			glScalef(x, y, z);
		}
		
		[MethodImport("glTranslated", "1.0")]
		private static delegate*<double, double, double, void> glTranslated;
		
		public static void Translated(double x, double y, double z)
		{
			glTranslated(x, y, z);
		}
		
		[MethodImport("glTranslatef", "1.0")]
		private static delegate*<float, float, float, void> glTranslatef;
		
		public static void Translatef(float x, float y, float z)
		{
			glTranslatef(x, y, z);
		}
	}
}

