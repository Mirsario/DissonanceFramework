using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using MI = System.Runtime.CompilerServices.MethodImplAttribute;

#pragma warning disable IDE0060 //Unused parameter.

namespace Dissonance.Framework.OpenGL
{
	public static partial class GL
	{
		private const int AI = (int)MethodImplOptions.AggressiveInlining;

		#region OpenGL 1.0 + OpenGL 1.1

		[MethodImport("glAccum","4.5")]
		public static void Accum(uint op,float value)
			=> throw new NotImplementedException();
		
		[MethodImport("glAlphaFunc","4.5")]
		public static void AlphaFunc(uint func,float alpha)
			=> throw new NotImplementedException();
		
		[MethodImport("glAreTexturesResident","4.5")]
		public static byte AreTexturesResident(int n,uint[] textures,IntPtr residences)
			=> throw new NotImplementedException();
		
		[MethodImport("glArrayElement","4.5")]
		public static void ArrayElement(int i)
			=> throw new NotImplementedException();
		
		[MethodImport("glBegin","4.5")]
		public static void Begin(PrimitiveType mode)
			=> throw new NotImplementedException();
		
		[MethodImport("glBindTexture","4.5")]
		public static void BindTexture(uint target,uint texture)
			=> throw new NotImplementedException();
		
		[MethodImport("glBitmap","4.5")]
		public static void Bitmap(int width,int height,float xOrig,float yOrig,float xMove,float yMove,[In] [MarshalAs(UnmanagedType.LPStr)] string bitmap)
			=> throw new NotImplementedException();
		
		[MethodImport("glBlendFunc","4.5")]
		public static void BlendFunc(BlendingFactor sfactor,BlendingFactor dfactor)
			=> throw new NotImplementedException();
		
		[MethodImport("glCallList","4.5")]
		public static void CallList(uint list)
			=> throw new NotImplementedException();
		
		[MethodImport("glCallLists","4.5")]
		public static void CallLists(int n,uint type,IntPtr lists)
			=> throw new NotImplementedException();
		
		[MethodImport("glClear","4.5")]
		public static void Clear(ClearBufferMask mask)
			=> throw new NotImplementedException();
		
		[MethodImport("glClearAccum","4.5")]
		public static void ClearAccum(float red,float green,float blue,float alpha = 1f)
			=> throw new NotImplementedException();
		
		[MethodImport("glClearAccum","4.5")]
		public static void ClearAccum(int red,int green,int blue,int alpha = 255)
			=> throw new NotImplementedException();
		
		[MethodImport("glClearAccum","4.5")]
		public static void ClearAccum(byte red,byte green,byte blue,byte alpha = 255)
			=> throw new NotImplementedException();
		
		[MethodImport("glClearColor","4.5")]
		public static void ClearColor(float red,float green,float blue,float alpha = 1f)
			=> throw new NotImplementedException();
		
		[MethodImport("glClearColor","4.5")]
		public static void ClearColor(int red,int green,int blue,int alpha = 255)
			=> throw new NotImplementedException();
		
		[MethodImport("glClearColor","4.5")]
		public static void ClearColor(byte red,byte green,byte blue,byte alpha = 255)
			=> throw new NotImplementedException();
		
		[MethodImport("glClearDepth","4.5")]
		public static void ClearDepth(double depth)
			=> throw new NotImplementedException();
		
		[MethodImport("glClearIndex","4.5")]
		public static void ClearIndex(float c)
			=> throw new NotImplementedException();
		
		[MethodImport("glClearStencil","4.5")]
		public static void ClearStencil(int s)
			=> throw new NotImplementedException();
		
		[MethodImport("glClipPlane","4.5")]
		public static void ClipPlane(uint plane,double[] equation)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor3b","4.5")]
		public static void Color3(sbyte red,sbyte green,sbyte blue)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor3bv","4.5")]
		public static void Color3(sbyte[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor3d","4.5")]
		public static void Color3(double red,double green,double blue)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor3dv","4.5")]
		public static void Color3(double[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor3f","4.5")]
		public static void Color3(float red,float green,float blue)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor3fv","4.5")]
		public static void Color3(float[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor3i","4.5")]
		public static void Color3(int red,int green,int blue)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor3iv","4.5")]
		public static void Color3(int[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor3s","4.5")]
		public static void Color3(short red,short green,short blue)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor3sv","4.5")]
		public static void Color3(short[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor3ub","4.5")]
		public static void Color3(byte red,byte green,byte blue)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor3ubv","4.5")]
		public static void Color3(byte[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor3ui","4.5")]
		public static void Color3(uint red,uint green,uint blue)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor3uiv","4.5")]
		public static void Color3(uint[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor3us","4.5")]
		public static void Color3(ushort red,ushort green,ushort blue)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor3usv","4.5")]
		public static void Color3(ushort[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor4b","4.5")]
		public static void Color4(sbyte red,sbyte green,sbyte blue,sbyte alpha)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor4bv","4.5")]
		public static void Color4(sbyte[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor4d","4.5")]
		public static void Color4(double red,double green,double blue,double alpha)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor4dv","4.5")]
		public static void Color4(double[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor4f","4.5")]
		public static void Color4(float red,float green,float blue,float alpha)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor4fv","4.5")]
		public static void Color4(float[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor4i","4.5")]
		public static void Color4(int red,int green,int blue,int alpha)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor4iv","4.5")]
		public static void Color4(int[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor4s","4.5")]
		public static void Color4(short red,short green,short blue,short alpha)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor4sv","4.5")]
		public static void Color4(short[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor4ub","4.5")]
		public static void Color4(byte red,byte green,byte blue,byte alpha)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor4ubv","4.5")]
		public static void Color4(byte[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor4ui","4.5")]
		public static void Color4(uint red,uint green,uint blue,uint alpha)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor4uiv","4.5")]
		public static void Color4(uint[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor4us","4.5")]
		public static void Color4(ushort red,ushort green,ushort blue,ushort alpha)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor4usv","4.5")]
		public static void Color4(ushort[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glColorMask","4.5")]
		public static void ColorMask(byte red,byte green,byte blue,byte alpha)
			=> throw new NotImplementedException();
		
		[MethodImport("glColorMaterial","4.5")]
		public static void ColorMaterial(uint face,uint mode)
			=> throw new NotImplementedException();
		
		[MethodImport("glColorPointer","4.5")]
		public static void ColorPointer(int size,uint type,int stride,IntPtr pointer)
			=> throw new NotImplementedException();
		
		[MethodImport("glCopyPixels","4.5")]
		public static void CopyPixels(int x,int y,int width,int height,uint type)
			=> throw new NotImplementedException();
		
		[MethodImport("glCopyTexImage1D","4.5")]
		public static void CopyTexImage1D(uint target,int level,uint internalFormat,int x,int y,int width,int border)
			=> throw new NotImplementedException();
		
		[MethodImport("glCopyTexImage2D","4.5")]
		public static void CopyTexImage2D(uint target,int level,uint internalFormat,int x,int y,int width,int height,int border)
			=> throw new NotImplementedException();
		
		[MethodImport("glCopyTexSubImage1D","4.5")]
		public static void CopyTexSubImage1D(uint target,int level,int xOffset,int x,int y,int width)
			=> throw new NotImplementedException();
		
		[MethodImport("glCopyTexSubImage2D","4.5")]
		public static void CopyTexSubImage2D(uint target,int level,int xOffset,int yOffset,int x,int y,int width,int height)
			=> throw new NotImplementedException();
		
		[MethodImport("glCullFace","4.5")]
		public static void CullFace(CullFaceMode mode)
			=> throw new NotImplementedException();
		
		[MethodImport("glDeleteLists","4.5")]
		public static void DeleteLists(uint list,int range)
			=> throw new NotImplementedException();
		
		[MethodImport("glDeleteTextures","4.5")]
		public static void DeleteTextures(int n,uint[] textures)
			=> throw new NotImplementedException();
		
		[MethodImport("glDepthFunc","4.5")]
		public static void DepthFunc(DepthFunction func)
			=> throw new NotImplementedException();
		
		[MethodImport("glDepthMask","4.5")]
		public static void DepthMask(byte flag)
			=> throw new NotImplementedException();
		
		[MethodImport("glDepthRange","4.5")]
		public static void DepthRange(double zNear,double zFar)
			=> throw new NotImplementedException();
		
		[MethodImport("glDisable","4.5")]
		public static void Disable(EnableCap cap)
			=> throw new NotImplementedException();
		
		[MethodImport("glDisableClientState","4.5")]
		public static void DisableClientState(uint capability)
			=> throw new NotImplementedException();
		
		[MethodImport("glDrawArrays","4.5")]
		public static void DrawArrays(PrimitiveType mode,int first,int count)
			=> throw new NotImplementedException();
		
		[MethodImport("glDrawBuffer","4.5")]
		public static void DrawBuffer(DrawBufferMode mode)
			=> throw new NotImplementedException();
		
		[MethodImport("glDrawElements","4.5")]
		public static void DrawElements(uint mode,int count,uint type,IntPtr indices)
			=> throw new NotImplementedException();
		
		[MethodImport("glDrawPixels","4.5")]
		public static void DrawPixels(int width,int height,uint format,uint type,IntPtr pixels)
			=> throw new NotImplementedException();
		
		[MethodImport("glEdgeFlag","4.5")]
		public static void EdgeFlag(byte flag)
			=> throw new NotImplementedException();
		
		[MethodImport("glEdgeFlagPointer","4.5")]
		public static void EdgeFlagPointer(int stride,IntPtr pointer)
			=> throw new NotImplementedException();
		
		[MethodImport("glEdgeFlagv","4.5")]
		public static void EdgeFlag([In] [MarshalAs(UnmanagedType.LPStr)] string flag)
			=> throw new NotImplementedException();
		
		[MethodImport("glEnable","4.5")]
		public static void Enable(EnableCap cap)
			=> throw new NotImplementedException();
		
		[MethodImport("glEnableClientState","4.5")]
		public static void EnableClientState(uint capability)
			=> throw new NotImplementedException();
		
		[MethodImport("glEnd","4.5")]
		public static void End()
			=> throw new NotImplementedException();
		
		[MethodImport("glEndList","4.5")]
		public static void EndList()
			=> throw new NotImplementedException();
		
		[MethodImport("glEvalCoord1d","4.5")]
		public static void EvalCoord1(double u)
			=> throw new NotImplementedException();
		
		[MethodImport("glEvalCoord1dv","4.5")]
		public static void EvalCoord1(double[] u)
			=> throw new NotImplementedException();
		
		[MethodImport("glEvalCoord1f","4.5")]
		public static void EvalCoord1(float u)
			=> throw new NotImplementedException();
		
		[MethodImport("glEvalCoord1fv","4.5")]
		public static void EvalCoord1(float[] u)
			=> throw new NotImplementedException();
		
		[MethodImport("glEvalCoord2d","4.5")]
		public static void EvalCoord2(double u,double v)
			=> throw new NotImplementedException();
		
		[MethodImport("glEvalCoord2dv","4.5")]
		public static void EvalCoord2(double[] u)
			=> throw new NotImplementedException();
		
		[MethodImport("glEvalCoord2f","4.5")]
		public static void EvalCoord2(float u,float v)
			=> throw new NotImplementedException();
		
		[MethodImport("glEvalCoord2fv","4.5")]
		public static void EvalCoord2(float[] u)
			=> throw new NotImplementedException();
		
		[MethodImport("glEvalMesh1","4.5")]
		public static void EvalMesh1(uint mode,int i1,int i2)
			=> throw new NotImplementedException();
		
		[MethodImport("glEvalMesh2","4.5")]
		public static void EvalMesh2(uint mode,int i1,int i2,int j1,int j2)
			=> throw new NotImplementedException();
		
		[MethodImport("glEvalPoint1","4.5")]
		public static void EvalPoint1(int i)
			=> throw new NotImplementedException();
		
		[MethodImport("glEvalPoint2","4.5")]
		public static void EvalPoint2(int i,int j)
			=> throw new NotImplementedException();
		
		[MethodImport("glFeedbackBuffer","4.5")]
		public static void FeedbackBuffer(int size,uint type,float[] buffer)
			=> throw new NotImplementedException();
		
		[MethodImport("glFinish","4.5")]
		public static void Finish()
			=> throw new NotImplementedException();
		
		[MethodImport("glFlush","4.5")]
		public static void Flush()
			=> throw new NotImplementedException();
		
		[MethodImport("glFogf","4.5")]
		public static void Fog(uint pName,float param)
			=> throw new NotImplementedException();
		
		[MethodImport("glFogfv","4.5")]
		public static void Fog(uint pName,float[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glFogi","4.5")]
		public static void Fog(uint pName,int param)
			=> throw new NotImplementedException();
		
		[MethodImport("glFogiv","4.5")]
		public static void Fog(uint pName,int[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glFrontFace","4.5")]
		public static void FrontFace(uint mode)
			=> throw new NotImplementedException();
		
		[MethodImport("glFrustum","4.5")]
		public static void Frustum(double left,double right,double bottom,double top,double zNear,double zFar)
			=> throw new NotImplementedException();
		
		[MethodImport("glGenLists","4.5")]
		public static uint GenLists(int range)
			=> throw new NotImplementedException();
		
		[MethodImport("glGenTextures","4.5")]
		public static void GenTextures(int n,ref uint textures)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetBooleanv","4.5")]
		public static void GetBoolean(uint pName,IntPtr parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetClipPlane","4.5")]
		public static void GetClipPlane(uint plane,double[] equation)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetDoublev","4.5")]
		public static void GetDouble(uint pName,double[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetError","4.5")]
		public static GraphicsError GetError()
			=> throw new NotImplementedException();
		
		[MethodImport("glGetFloatv","4.5")]
		public static void GetFloat(uint pName,float[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetIntegerv","4.5")]
		public static void GetInteger(uint pName,int[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetLightfv","4.5")]
		public static void GetLight(uint light,uint pName,float[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetLightiv","4.5")]
		public static void GetLight(uint light,uint pName,int[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetMapdv","4.5")]
		public static void GetMap(uint target,uint query,double[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetMapfv","4.5")]
		public static void GetMap(uint target,uint query,float[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetMapiv","4.5")]
		public static void GetMap(uint target,uint query,int[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetMaterialfv","4.5")]
		public static void GetMaterial(uint face,uint pName,float[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetMaterialiv","4.5")]
		public static void GetMaterial(uint face,uint pName,int[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetPixelMapfv","4.5")]
		public static void GetPixelMap(uint map,float[] values)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetPixelMapuiv","4.5")]
		public static void GetPixelMap(uint map,uint[] values)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetPixelMapusv","4.5")]
		public static void GetPixelMap(uint map,ushort[] values)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetPointerv","4.5")]
		public static void GetPointer(uint pName,ref IntPtr parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetPolygonStipple","4.5")]
		public static void GetPolygonStipple(IntPtr mask)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetTexEnvfv","4.5")]
		public static void GetTexEnv(uint target,uint pName,float[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetTexEnviv","4.5")]
		public static void GetTexEnv(uint target,uint pName,int[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetTexGendv","4.5")]
		public static void GetTexGen(uint coord,uint pName,double[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetTexGenfv","4.5")]
		public static void GetTexGen(uint coord,uint pName,float[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetTexGeniv","4.5")]
		public static void GetTexGen(uint coord,uint pName,int[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetTexImage","4.5")]
		public static void GetTexImage(uint target,int level,uint format,uint type,IntPtr pixels)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetTexLevelParameterfv","4.5")]
		public static void GetTexLevelParameter(uint target,int level,uint pName,float[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetTexLevelParameteriv","4.5")]
		public static void GetTexLevelParameter(uint target,int level,uint pName,int[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetTexParameterfv","4.5")]
		public static void GetTexParameter(uint target,uint pName,float[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetTexParameteriv","4.5")]
		public static void GetTexParameter(uint target,uint pName,int[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glHint","4.5")]
		public static void Hint(uint target,uint mode)
			=> throw new NotImplementedException();
		
		[MethodImport("glIndexMask","4.5")]
		public static void IndexMask(uint mask)
			=> throw new NotImplementedException();
		
		[MethodImport("glIndexPointer","4.5")]
		public static void IndexPointer(uint type,int stride,IntPtr pointer)
			=> throw new NotImplementedException();
		
		[MethodImport("glIndexd","4.5")]
		public static void Index(double c)
			=> throw new NotImplementedException();
		
		[MethodImport("glIndexdv","4.5")]
		public static void Index(double[] c)
			=> throw new NotImplementedException();
		
		[MethodImport("glIndexf","4.5")]
		public static void Index(float c)
			=> throw new NotImplementedException();
		
		[MethodImport("glIndexfv","4.5")]
		public static void Index(float[] c)
			=> throw new NotImplementedException();
		
		[MethodImport("glIndexi","4.5")]
		public static void Index(int c)
			=> throw new NotImplementedException();
		
		[MethodImport("glIndexiv","4.5")]
		public static void Index(int[] c)
			=> throw new NotImplementedException();
		
		[MethodImport("glIndexs","4.5")]
		public static void Index(short c)
			=> throw new NotImplementedException();
		
		[MethodImport("glIndexsv","4.5")]
		public static void Index(short[] c)
			=> throw new NotImplementedException();
		
		[MethodImport("glIndexub","4.5")]
		public static void Index(byte c)
			=> throw new NotImplementedException();
		
		[MethodImport("glIndexubv","4.5")]
		public static void Index([In] [MarshalAs(UnmanagedType.LPStr)] string c)
			=> throw new NotImplementedException();
		
		[MethodImport("glInitNames","4.5")]
		public static void InitNames()
			=> throw new NotImplementedException();
		
		[MethodImport("glInterleavedArrays","4.5")]
		public static void InterleavedArrays(uint format,int stride,IntPtr pointer)
			=> throw new NotImplementedException();
		
		[MethodImport("glIsEnabled","4.5")]
		public static byte IsEnabled(EnableCap cap)
			=> throw new NotImplementedException();
		
		[MethodImport("glIsList","4.5")]
		public static byte IsList(uint list)
			=> throw new NotImplementedException();
		
		[MethodImport("glIsTexture","4.5")]
		public static byte IsTexture(uint texture)
			=> throw new NotImplementedException();
		
		[MethodImport("glLightModelf","4.5")]
		public static void LightMode(uint pName,float param)
			=> throw new NotImplementedException();
		
		[MethodImport("glLightModelfv","4.5")]
		public static void LightMode(uint pName,float[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glLightModeli","4.5")]
		public static void LightMode(uint pName,int param)
			=> throw new NotImplementedException();
		
		[MethodImport("glLightModeliv","4.5")]
		public static void LightMode(uint pName,int[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glLightf","4.5")]
		public static void Light(uint light,uint pName,float param)
			=> throw new NotImplementedException();
		
		[MethodImport("glLightfv","4.5")]
		public static void Light(uint light,uint pName,float[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glLighti","4.5")]
		public static void Light(uint light,uint pName,int param)
			=> throw new NotImplementedException();
		
		[MethodImport("glLightiv","4.5")]
		public static void Light(uint light,uint pName,int[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glLineStipple","4.5")]
		public static void LineStipple(int factor,ushort pattern)
			=> throw new NotImplementedException();
		
		[MethodImport("glLineWidth","4.5")]
		public static void LineWidth(float width)
			=> throw new NotImplementedException();
		
		[MethodImport("glListBase","4.5")]
		public static void ListBase(uint b)
			=> throw new NotImplementedException();
		
		[MethodImport("glLoadIdentity","4.5")]
		public static void LoadIdentity()
			=> throw new NotImplementedException();
		
		[MethodImport("glLoadMatrixd","4.5")]
		public static void LoadMatrix(double[] m)
			=> throw new NotImplementedException();
		
		[MethodImport("glLoadMatrixf","4.5")]
		public static void LoadMatrix(float[] m)
			=> throw new NotImplementedException();
		
		[MethodImport("glLoadName","4.5")]
		public static void LoadName(uint name)
			=> throw new NotImplementedException();
		
		[MethodImport("glLogicOp","4.5")]
		public static void LogicOp(uint opcode)
			=> throw new NotImplementedException();
		
		[MethodImport("glMap1d","4.5")]
		public static void Map1(uint target,double u1,double u2,int stride,int order,double[] points)
			=> throw new NotImplementedException();
		
		[MethodImport("glMap1f","4.5")]
		public static void Map1(uint target,float u1,float u2,int stride,int order,float[] points)
			=> throw new NotImplementedException();
		
		[MethodImport("glMap2d","4.5")]
		public static void Map2(uint target,double u1,double u2,int ustride,int uorder,double v1,double v2,int vstride,int vorder,double[] points)
			=> throw new NotImplementedException();
		
		[MethodImport("glMap2f","4.5")]
		public static void Map2(uint target,float u1,float u2,int ustride,int uorder,float v1,float v2,int vstride,int vorder,float[] points)
			=> throw new NotImplementedException();
		
		[MethodImport("glMapGrid1d","4.5")]
		public static void MapGrid1(int un,double u1,double u2)
			=> throw new NotImplementedException();
		
		[MethodImport("glMapGrid1f","4.5")]
		public static void MapGrid1(int un,float u1,float u2)
			=> throw new NotImplementedException();
		
		[MethodImport("glMapGrid2d","4.5")]
		public static void MapGrid2(int un,double u1,double u2,int vn,double v1,double v2)
			=> throw new NotImplementedException();
		
		[MethodImport("glMapGrid2f","4.5")]
		public static void MapGrid2(int un,float u1,float u2,int vn,float v1,float v2)
			=> throw new NotImplementedException();
		
		[MethodImport("glMaterialf","4.5")]
		public static void Material(uint face,uint pName,float param)
			=> throw new NotImplementedException();
		
		[MethodImport("glMaterialfv","4.5")]
		public static void Material(uint face,uint pName,float[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glMateriali","4.5")]
		public static void Material(uint face,uint pName,int param)
			=> throw new NotImplementedException();
		
		[MethodImport("glMaterialiv","4.5")]
		public static void Material(uint face,uint pName,int[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glMatrixMode","4.5")]
		public static void MatrixMode(uint mode)
			=> throw new NotImplementedException();
		
		[MethodImport("glMultMatrixd","4.5")]
		public static void MultMatrix(double[] m)
			=> throw new NotImplementedException();
		
		[MethodImport("glMultMatrixf","4.5")]
		public static void MultMatrix(float[] m)
			=> throw new NotImplementedException();
		
		[MethodImport("glNewList","4.5")]
		public static void NewList(uint list,uint mode)
			=> throw new NotImplementedException();
		
		[MethodImport("glNormal3b","4.5")]
		public static void Normal3(sbyte nx,sbyte ny,sbyte nz)
			=> throw new NotImplementedException();
		
		[MethodImport("glNormal3bv","4.5")]
		public static void Normal3([In] [MarshalAs(UnmanagedType.LPStr)] string v)
			=> throw new NotImplementedException();
		
		[MethodImport("glNormal3d","4.5")]
		public static void Normal3(double nx,double ny,double nz)
			=> throw new NotImplementedException();
		
		[MethodImport("glNormal3dv","4.5")]
		public static void Normal3(double[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glNormal3f","4.5")]
		public static void Normal3(float nx,float ny,float nz)
			=> throw new NotImplementedException();
		
		[MethodImport("glNormal3fv","4.5")]
		public static void Normal3(float[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glNormal3i","4.5")]
		public static void Normal3(int nx,int ny,int nz)
			=> throw new NotImplementedException();
		
		[MethodImport("glNormal3iv","4.5")]
		public static void Normal3(int[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glNormal3s","4.5")]
		public static void Normal3(short nx,short ny,short nz)
			=> throw new NotImplementedException();
		
		[MethodImport("glNormal3sv","4.5")]
		public static void Normal3(short[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glNormalPointer","4.5")]
		public static void NormalPointer(uint type,int stride,IntPtr pointer)
			=> throw new NotImplementedException();
		
		[MethodImport("glOrtho","4.5")]
		public static void Ortho(double left,double right,double bottom,double top,double zNear,double zFar)
			=> throw new NotImplementedException();
		
		[MethodImport("glPassThrough","4.5")]
		public static void PassThrough(float token)
			=> throw new NotImplementedException();
		
		[MethodImport("glPixelMapfv","4.5")]
		public static void PixelMap(uint map,int mapSize,float[] values)
			=> throw new NotImplementedException();
		
		[MethodImport("glPixelMapuiv","4.5")]
		public static void PixelMap(uint map,int mapSize,uint[] values)
			=> throw new NotImplementedException();
		
		[MethodImport("glPixelMapusv","4.5")]
		public static void PixelMap(uint map,int mapSize,ushort[] values)
			=> throw new NotImplementedException();
		
		[MethodImport("glPixelStoref","4.5")]
		public static void PixelStore(uint pName,float param)
			=> throw new NotImplementedException();
		
		[MethodImport("glPixelStorei","4.5")]
		public static void PixelStore(uint pName,int param)
			=> throw new NotImplementedException();
		
		[MethodImport("glPixelTransferf","4.5")]
		public static void PixelTransfer(uint pName,float param)
			=> throw new NotImplementedException();
		
		[MethodImport("glPixelTransferi","4.5")]
		public static void PixelTransfer(uint pName,int param)
			=> throw new NotImplementedException();
		
		[MethodImport("glPixelZoom","4.5")]
		public static void PixelZoom(float xFactor,float yFactor)
			=> throw new NotImplementedException();
		
		[MethodImport("glPointSize","4.5")]
		public static void PointSize(float size)
			=> throw new NotImplementedException();
		
		[MethodImport("glPolygonMode","4.5")]
		public static void PolygonMode(uint face,uint mode)
			=> throw new NotImplementedException();
		
		[MethodImport("glPolygonOffset","4.5")]
		public static void PolygonOffset(float factor,float units)
			=> throw new NotImplementedException();
		
		[MethodImport("glPolygonStipple","4.5")]
		public static void PolygonStipple([In] [MarshalAs(UnmanagedType.LPStr)] string mask)
			=> throw new NotImplementedException();
		
		[MethodImport("glPopAttrib","4.5")]
		public static void PopAttrib()
			=> throw new NotImplementedException();
		
		[MethodImport("glPopClientAttrib","4.5")]
		public static void PopClientAttrib()
			=> throw new NotImplementedException();
		
		[MethodImport("glPopMatrix","4.5")]
		public static void PopMatrix()
			=> throw new NotImplementedException();
		
		[MethodImport("glPopName","4.5")]
		public static void PopName()
			=> throw new NotImplementedException();
		
		[MethodImport("glPrioritizeTextures","4.5")]
		public static void PrioritizeTextures(int n,uint[] textures,float[] priorities)
			=> throw new NotImplementedException();
		
		[MethodImport("glPushAttrib","4.5")]
		public static void PushAttrib(uint mask)
			=> throw new NotImplementedException();
		
		[MethodImport("glPushClientAttrib","4.5")]
		public static void PushClientAttrib(uint mask)
			=> throw new NotImplementedException();
		
		[MethodImport("glPushMatrix","4.5")]
		public static void PushMatrix()
			=> throw new NotImplementedException();
		
		[MethodImport("glPushName","4.5")]
		public static void PushName(uint name)
			=> throw new NotImplementedException();
		
		[MethodImport("glRasterPos2d","4.5")]
		public static void RasterPos2(double x,double y)
			=> throw new NotImplementedException();
		
		[MethodImport("glRasterPos2dv","4.5")]
		public static void RasterPos2(double[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glRasterPos2f","4.5")]
		public static void RasterPos2(float x,float y)
			=> throw new NotImplementedException();
		
		[MethodImport("glRasterPos2fv","4.5")]
		public static void RasterPos2(float[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glRasterPos2i","4.5")]
		public static void RasterPos2(int x,int y)
			=> throw new NotImplementedException();
		
		[MethodImport("glRasterPos2iv","4.5")]
		public static void RasterPos2(int[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glRasterPos2s","4.5")]
		public static void RasterPos2(short x,short y)
			=> throw new NotImplementedException();
		
		[MethodImport("glRasterPos2sv","4.5")]
		public static void RasterPos2(short[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glRasterPos3d","4.5")]
		public static void RasterPos3(double x,double y,double z)
			=> throw new NotImplementedException();
		
		[MethodImport("glRasterPos3dv","4.5")]
		public static void RasterPos3(double[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glRasterPos3f","4.5")]
		public static void RasterPos3(float x,float y,float z)
			=> throw new NotImplementedException();
		
		[MethodImport("glRasterPos3fv","4.5")]
		public static void RasterPos3(float[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glRasterPos3i","4.5")]
		public static void RasterPos3(int x,int y,int z)
			=> throw new NotImplementedException();
		
		[MethodImport("glRasterPos3iv","4.5")]
		public static void RasterPos3(int[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glRasterPos3s","4.5")]
		public static void RasterPos3(short x,short y,short z)
			=> throw new NotImplementedException();
		
		[MethodImport("glRasterPos3sv","4.5")]
		public static void RasterPos3(short[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glRasterPos4d","4.5")]
		public static void RasterPos4(double x,double y,double z,double w)
			=> throw new NotImplementedException();
		
		[MethodImport("glRasterPos4dv","4.5")]
		public static void RasterPos4(double[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glRasterPos4f","4.5")]
		public static void RasterPos4(float x,float y,float z,float w)
			=> throw new NotImplementedException();
		
		[MethodImport("glRasterPos4fv","4.5")]
		public static void RasterPos4(float[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glRasterPos4i","4.5")]
		public static void RasterPos4(int x,int y,int z,int w)
			=> throw new NotImplementedException();
		
		[MethodImport("glRasterPos4iv","4.5")]
		public static void RasterPos4(int[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glRasterPos4s","4.5")]
		public static void RasterPos4(short x,short y,short z,short w)
			=> throw new NotImplementedException();
		
		[MethodImport("glRasterPos4sv","4.5")]
		public static void RasterPos4(short[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glReadBuffer","4.5")]
		public static void ReadBuffer(uint mode)
			=> throw new NotImplementedException();
		
		[MethodImport("glReadPixels","4.5")]
		public static void ReadPixels(int x,int y,int width,int height,uint format,uint type,IntPtr pixels)
			=> throw new NotImplementedException();
		
		[MethodImport("glRectd","4.5")]
		public static void Rect(double x1,double y1,double x2,double y2)
			=> throw new NotImplementedException();
		
		[MethodImport("glRectdv","4.5")]
		public static void Rect(double[] v1,double[] v2)
			=> throw new NotImplementedException();
		
		[MethodImport("glRectf","4.5")]
		public static void Rect(float x1,float y1,float x2,float y2)
			=> throw new NotImplementedException();
		
		[MethodImport("glRectfv","4.5")]
		public static void Rect(float[] v1,float[] v2)
			=> throw new NotImplementedException();
		
		[MethodImport("glRecti","4.5")]
		public static void Rect(int x1,int y1,int x2,int y2)
			=> throw new NotImplementedException();
		
		[MethodImport("glRectiv","4.5")]
		public static void Rect(int[] v1,int[] v2)
			=> throw new NotImplementedException();
		
		[MethodImport("glRects","4.5")]
		public static void Rect(short x1,short y1,short x2,short y2)
			=> throw new NotImplementedException();
		
		[MethodImport("glRectsv","4.5")]
		public static void Rect(short[] v1,short[] v2)
			=> throw new NotImplementedException();
		
		[MethodImport("glRenderMode","4.5")]
		public static int RenderMode(uint mode)
			=> throw new NotImplementedException();
		
		[MethodImport("glRotated","4.5")]
		public static void Rotate(double angle,double x,double y,double z)
			=> throw new NotImplementedException();
		
		[MethodImport("glRotatef","4.5")]
		public static void Rotate(float angle,float x,float y,float z)
			=> throw new NotImplementedException();
		
		[MethodImport("glScaled","4.5")]
		public static void Scale(double x,double y,double z)
			=> throw new NotImplementedException();
		
		[MethodImport("glScalef","4.5")]
		public static void Scale(float x,float y,float z)
			=> throw new NotImplementedException();
		
		[MethodImport("glScissor","4.5")]
		public static void Scissor(int x,int y,int width,int height)
			=> throw new NotImplementedException();
		
		[MethodImport("glSelectBuffer","4.5")]
		public static void SelectBuffer(int size,uint[] buffer)
			=> throw new NotImplementedException();
		
		[MethodImport("glShadeModel","4.5")]
		public static void ShadeModel(uint mode)
			=> throw new NotImplementedException();
		
		[MethodImport("glStencilFunc","4.5")]
		public static void StencilFunc(uint func,int refer,uint mask)
			=> throw new NotImplementedException();
		
		[MethodImport("glStencilMask","4.5")]
		public static void StencilMask(uint mask)
			=> throw new NotImplementedException();
		
		[MethodImport("glStencilOp","4.5")]
		public static void StencilOp(uint fail,uint zfail,uint zpass)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord1d","4.5")]
		public static void TexCoord1(double s)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord1dv","4.5")]
		public static void TexCoord1(double[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord1f","4.5")]
		public static void TexCoord1(float s)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord1fv","4.5")]
		public static void TexCoord1(float[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord1i","4.5")]
		public static void TexCoord1(int s)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord1iv","4.5")]
		public static void TexCoord1(int[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord1s","4.5")]
		public static void TexCoord1(short s)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord1sv","4.5")]
		public static void TexCoord1(short[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord2d","4.5")]
		public static void TexCoord2(double s,double t)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord2dv","4.5")]
		public static void TexCoord2(double[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord2f","4.5")]
		public static void TexCoord2(float s,float t)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord2fv","4.5")]
		public static void TexCoord2(float[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord2i","4.5")]
		public static void TexCoord2(int s,int t)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord2iv","4.5")]
		public static void TexCoord2(int[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord2s","4.5")]
		public static void TexCoord2(short s,short t)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord2sv","4.5")]
		public static void TexCoord2(short[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord3d","4.5")]
		public static void TexCoord3(double s,double t,double r)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord3dv","4.5")]
		public static void TexCoord3(double[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord3f","4.5")]
		public static void TexCoord3(float s,float t,float r)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord3fv","4.5")]
		public static void TexCoord3(float[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord3i","4.5")]
		public static void TexCoord3(int s,int t,int r)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord3iv","4.5")]
		public static void TexCoord3(int[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord3s","4.5")]
		public static void TexCoord3(short s,short t,short r)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord3sv","4.5")]
		public static void TexCoord3(short[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord4d","4.5")]
		public static void TexCoord4(double s,double t,double r,double q)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord4dv","4.5")]
		public static void TexCoord4(double[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord4f","4.5")]
		public static void TexCoord4(float s,float t,float r,float q)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord4fv","4.5")]
		public static void TexCoord4(float[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord4i","4.5")]
		public static void TexCoord4(int s,int t,int r,int q)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord4iv","4.5")]
		public static void TexCoord4(int[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord4s","4.5")]
		public static void TexCoord4(short s,short t,short r,short q)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord4sv","4.5")]
		public static void TexCoord4(short[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoordPointer","4.5")]
		public static void TexCoordPointer(int size,uint type,int stride,IntPtr pointer)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexEnvf","4.5")]
		public static void TexEnv(uint target,uint pName,float param)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexEnvfv","4.5")]
		public static void TexEnv(uint target,uint pName,float[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexEnvi","4.5")]
		public static void TexEnv(uint target,uint pName,int param)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexEnviv","4.5")]
		public static void TexEnv(uint target,uint pName,int[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexGend","4.5")]
		public static void TexGen(uint coord,uint pName,double param)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexGendv","4.5")]
		public static void TexGen(uint coord,uint pName,double[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexGenf","4.5")]
		public static void TexGen(uint coord,uint pName,float param)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexGenfv","4.5")]
		public static void TexGen(uint coord,uint pName,float[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexGeni","4.5")]
		public static void TexGen(uint coord,uint pName,int param)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexGeniv","4.5")]
		public static void TexGen(uint coord,uint pName,int[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexImage1D","4.5")]
		public static void TexImage1D(uint target,int level,int internalFormat,int width,int border,uint format,uint type,IntPtr pixels)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexImage2D","4.5")]
		public static void TexImage2D(uint target,int level,int internalFormat,int width,int height,int border,uint format,uint type,IntPtr pixels)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexParameterf","4.5")]
		public static void TexParameter(uint target,uint pName,float param)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexParameterfv","4.5")]
		public static void TexParameter(uint target,uint pName,float[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexParameteri","4.5")]
		public static void TexParameter(uint target,uint pName,int param)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexParameteriv","4.5")]
		public static void TexParameter(uint target,uint pName,int[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexSubImage1D","4.5")]
		public static void TexSubImage1D(uint target,int level,int xOffset,int width,uint format,uint type,IntPtr pixels)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexSubImage2D","4.5")]
		public static void TexSubImage2D(uint target,int level,int xOffset,int yOffset,int width,int height,uint format,uint type,IntPtr pixels)
			=> throw new NotImplementedException();
		
		[MethodImport("glTranslated","4.5")]
		public static void Translate(double x,double y,double z)
			=> throw new NotImplementedException();
		
		[MethodImport("glTranslatef","4.5")]
		public static void Translate(float x,float y,float z)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertex2d","4.5")]
		public static void Vertex2(double x,double y)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertex2dv","4.5")]
		public static void Vertex2(double[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertex2f","4.5")]
		public static void Vertex2(float x,float y)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertex2fv","4.5")]
		public static void Vertex2(float[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertex2i","4.5")]
		public static void Vertex2(int x,int y)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertex2iv","4.5")]
		public static void Vertex2(int[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertex2s","4.5")]
		public static void Vertex2(short x,short y)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertex2sv","4.5")]
		public static void Vertex2(short[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertex3d","4.5")]
		public static void Vertex3(double x,double y,double z)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertex3dv","4.5")]
		public static void Vertex3(double[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertex3f","4.5")]
		public static void Vertex3(float x,float y,float z)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertex3fv","4.5")]
		public static void Vertex3(float[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertex3i","4.5")]
		public static void Vertex3(int x,int y,int z)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertex3iv","4.5")]
		public static void Vertex3(int[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertex3s","4.5")]
		public static void Vertex3(short x,short y,short z)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertex3sv","4.5")]
		public static void Vertex3(short[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertex4d","4.5")]
		public static void Vertex4(double x,double y,double z,double w)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertex4dv","4.5")]
		public static void Vertex4(double[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertex4f","4.5")]
		public static void Vertex4(float x,float y,float z,float w)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertex4fv","4.5")]
		public static void Vertex4(float[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertex4i","4.5")]
		public static void Vertex4(int x,int y,int z,int w)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertex4iv","4.5")]
		public static void Vertex4(int[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertex4s","4.5")]
		public static void Vertex4(short x,short y,short z,short w)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertex4sv","4.5")]
		public static void Vertex4(short[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexPointer","4.5")]
		public static void VertexPointer(int size,uint type,int stride,IntPtr pointer)
			=> throw new NotImplementedException();
		
		[MethodImport("glViewport","4.5")]
		public static void Viewport(int x,int y,int width,int height)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetString","4.5")]
		private static IntPtr GetStringInternal(StringName name)
			=> throw new NotImplementedException();

		[MI(AI)] public static string GetString(StringName name) => Marshal.PtrToStringAnsi(GetStringInternal(name));

		#endregion

		#region OpenGL 1.2

		[MethodImport("glDrawRangeElements","1.2")]
		public static void DrawRangeElements(uint mode,uint start,uint end,int count,uint type,IntPtr indices)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexImage3D","1.2")]
		public static void TexImage3D(uint target,int level,int internalFormat,int width,int height,int depth,int border,uint format,uint type,IntPtr pixels)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexSubImage3D","1.2")]
		public static void TexSubImage3D(uint target,int level,int xOffset,int yOffset,int zOffset,int width,int height,int depth,uint format,uint type,IntPtr pixels)
			=> throw new NotImplementedException();
		
		[MethodImport("glCopyTexSubImage3D","1.2")]
		public static void CopyTexSubImage3D(uint target,int level,int xOffset,int yOffset,int zOffset,int x,int y,int width,int height)
			=> throw new NotImplementedException();
		
		#endregion

		#region OpenGL 1.3

		[MethodImport("glActiveTexture","1.3")]
		public static void ActiveTexture(uint texture)
			=> throw new NotImplementedException();
		
		[MethodImport("glSampleCoverage","1.3")]
		public static void SampleCoverage(float value,byte invert)
			=> throw new NotImplementedException();
		
		[MethodImport("glCompressedTexImage3D","1.3")]
		public static void CompressedTexImage3D(uint target,int level,uint internalFormat,int width,int height,int depth,int border,int imageSize,IntPtr data)
			=> throw new NotImplementedException();
		
		[MethodImport("glCompressedTexImage2D","1.3")]
		public static void CompressedTexImage2D(uint target,int level,uint internalFormat,int width,int height,int border,int imageSize,IntPtr data)
			=> throw new NotImplementedException();
		
		[MethodImport("glCompressedTexImage1D","1.3")]
		public static void CompressedTexImage1D(uint target,int level,uint internalFormat,int width,int border,int imageSize,IntPtr data)
			=> throw new NotImplementedException();
		
		[MethodImport("glCompressedTexSubImage3D","1.3")]
		public static void CompressedTexSubImage3D(uint target,int level,int xOffset,int yOffset,int zOffset,int width,int height,int depth,uint format,int imageSize,IntPtr data)
			=> throw new NotImplementedException();
		
		[MethodImport("glCompressedTexSubImage2D","1.3")]
		public static void CompressedTexSubImage2D(uint target,int level,int xOffset,int yOffset,int width,int height,uint format,int imageSize,IntPtr data)
			=> throw new NotImplementedException();
		
		[MethodImport("glCompressedTexSubImage1D","1.3")]
		public static void CompressedTexSubImage1D(uint target,int level,int xOffset,int width,uint format,int imageSize,IntPtr data)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetCompressedTexImage","1.3")]
		public static void GetCompressedTexImage(uint target,int level,IntPtr img)
			=> throw new NotImplementedException();
		
		#endregion

		#region OpenGL 1.4

		[MethodImport("glBlendFuncSeparate","1.4")]
		public static void BlendFuncSeparate(uint sfactorRGB,uint dfactorRGB,uint sfactorAlpha,uint dfactorAlpha)
			=> throw new NotImplementedException();
		
		[MethodImport("glMultiDrawArrays","1.4")]
		public static void MultiDrawArrays(uint mode,ref int first,ref int count,int drawcount)
			=> throw new NotImplementedException();
		
		[MethodImport("glMultiDrawElements","1.4")]
		public static void MultiDrawElements(uint mode,ref int count,uint type,IntPtr indices,int drawcount)
			=> throw new NotImplementedException();
		
		[MethodImport("glPointParameterf","1.4")]
		public static void PointParameter(uint pName,float param)
			=> throw new NotImplementedException();
		
		[MethodImport("glPointParameterfv","1.4")]
		public static void PointParameter(uint pName,ref float parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glPointParameteri","1.4")]
		public static void PointParameter(uint pName,int param)
			=> throw new NotImplementedException();
		
		[MethodImport("glPointParameteriv","1.4")]
		public static void PointParameter(uint pName,ref int parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glBlendColor","1.4")]
		public static void BlendColor(float red,float green,float blue,float alpha)
			=> throw new NotImplementedException();
		
		[MethodImport("glBlendEquation","1.4")]
		public static void BlendEquation(uint mode)
			=> throw new NotImplementedException();
		
		#endregion

		#region OpenGL 1.5

		[MethodImport("glGenQueries","1.5")]
		public static void GenQueries(int n,ref uint ids)
			=> throw new NotImplementedException();
		
		[MethodImport("glDeleteQueries","1.5")]
		public static void DeleteQueries(int n,ref uint ids)
			=> throw new NotImplementedException();
		
		[MethodImport("glIsQuery","1.5")]
		public static byte IsQuery(uint id)
			=> throw new NotImplementedException();
		
		[MethodImport("glBeginQuery","1.5")]
		public static void BeginQuery(uint target,uint id)
			=> throw new NotImplementedException();
		
		[MethodImport("glEndQuery","1.5")]
		public static void EndQuery(uint target)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetQueryiv","1.5")]
		public static void GetQuery(uint target,uint pName,ref int parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetQueryObjectiv","1.5")]
		public static void GetQueryObject(uint id,uint pName,ref int parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetQueryObjectuiv","1.5")]
		public static void GetQueryObject(uint id,uint pName,ref uint parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glBindBuffer","1.5")]
		public static void BindBuffer(BufferTarget target,uint buffer)
			=> throw new NotImplementedException();
		
		[MethodImport("glDeleteBuffers","1.5")]
		public static void DeleteBuffers(int n,ref uint buffers)
			=> throw new NotImplementedException();
		
		[MethodImport("glGenBuffers","1.5")]
		public static void GenBuffers(int n,ref uint buffers)
			=> throw new NotImplementedException();
		
		[MethodImport("glIsBuffer","1.5")]
		public static byte IsBuffer(uint buffer)
			=> throw new NotImplementedException();
		
		[MethodImport("glBufferData","1.5")]
		public static void BufferData(BufferTarget target,int size,IntPtr data,uint usage)
			=> throw new NotImplementedException();
		
		[MethodImport("glBufferSubData","1.5")]
		public static void BufferSubData(BufferTarget target,int offset,int size,IntPtr data)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetBufferSubData","1.5")]
		public static void GetBufferSubData(BufferTarget target,int offset,int size,IntPtr data)
			=> throw new NotImplementedException();
		
		[MethodImport("glMapBuffer","1.5")]
		public static IntPtr MapBuffer(BufferTarget target,uint access)
			=> throw new NotImplementedException();
		
		[MethodImport("glUnmapBuffer","1.5")]
		public static byte UnmapBuffer(BufferTarget target)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetBufferParameteriv","1.5")]
		public static void GetBufferParameter(BufferTarget target,uint pName,ref int parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetBufferPointerv","1.5")]
		public static void GetBufferPointer(BufferTarget target,uint pName,ref IntPtr parameters)
			=> throw new NotImplementedException();
		
		#endregion

		#region OpenGL 2.0

		[MethodImport("glBlendEquationSeparate","2.0")]
		public static void BlendEquationSeparate(uint modeRGB,uint modeAlpha)
			=> throw new NotImplementedException();
		
		[MethodImport("glDrawBuffers","2.0")]
		public static void DrawBuffers(int n,ref uint bufs)
			=> throw new NotImplementedException();
		
		[MethodImport("glStencilOpSeparate","2.0")]
		public static void StencilOpSeparate(uint face,uint sfail,uint dpfail,uint dppass)
			=> throw new NotImplementedException();
		
		[MethodImport("glStencilFuncSeparate","2.0")]
		public static void StencilFuncSeparate(uint face,uint func,int refer,uint mask)
			=> throw new NotImplementedException();
		
		[MethodImport("glStencilMaskSeparate","2.0")]
		public static void StencilMaskSeparate(uint face,uint mask)
			=> throw new NotImplementedException();
		
		[MethodImport("glAttachShader","2.0")]
		public static void AttachShader(uint program,uint shader)
			=> throw new NotImplementedException();
		
		[MethodImport("glBindAttribLocation","2.0")]
		public static void BindAttribLocation(uint program,uint index,[In] [MarshalAs(UnmanagedType.LPStr)] string name)
			=> throw new NotImplementedException();
		
		[MethodImport("glCompileShader","2.0")]
		public static void CompileShader(uint shader)
			=> throw new NotImplementedException();
		
		[MethodImport("glCreateProgram","2.0")]
		public static uint CreateProgram()
			=> throw new NotImplementedException();
		
		[MethodImport("glCreateShader","2.0")]
		public static uint CreateShader(uint type)
			=> throw new NotImplementedException();
		
		[MethodImport("glDeleteProgram","2.0")]
		public static void DeleteProgram(uint program)
			=> throw new NotImplementedException();
		
		[MethodImport("glDeleteShader","2.0")]
		public static void DeleteShader(uint shader)
			=> throw new NotImplementedException();
		
		[MethodImport("glDetachShader","2.0")]
		public static void DetachShader(uint program,uint shader)
			=> throw new NotImplementedException();
		
		[MethodImport("glDisableVertexAttribArray","2.0")]
		public static void DisableVertexAttribArray(uint index)
			=> throw new NotImplementedException();
		
		[MethodImport("glEnableVertexAttribArray","2.0")]
		public static void EnableVertexAttribArray(uint index)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetActiveAttrib","2.0")]
		public static void GetActiveAttrib(uint program,uint index,int bufSize,ref int length,ref int size,ref uint type,IntPtr name)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetActiveUniform","2.0")]
		public static void GetActiveUniform(uint program,uint index,int bufSize,ref int length,ref int size,ref uint type,IntPtr name)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetAttachedShaders","2.0")]
		public static void GetAttachedShaders(uint program,int maxCount,ref int count,ref uint shaders)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetAttribLocation","2.0")]
		public static int GetAttribLocation(uint program,[In] [MarshalAs(UnmanagedType.LPStr)] string name)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetProgramiv","2.0")]
		public static void GetProgram(uint program,GetProgramParameter parameter,out int results)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetProgramInfoLog","2.0")]
		public static void GetProgramInfoLog(uint program,int bufSize,ref int length,IntPtr infoLog)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetShaderiv","2.0")]
		public static void GetShader(uint shader,uint pName,ref int parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetShaderInfoLog","2.0")]
		public static void GetShaderInfoLog(uint shader,int bufSize,ref int length,IntPtr infoLog)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetShaderSource","2.0")]
		public static void GetShaderSource(uint shader,int bufSize,ref int length,IntPtr source)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetUniformLocation","2.0")]
		public static int GetUniformLocation(uint program,[In] [MarshalAs(UnmanagedType.LPStr)] string name)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetUniformfv","2.0")]
		public static void GetUniform(uint program,int location,ref float parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetUniformiv","2.0")]
		public static void GetUniform(uint program,int location,ref int parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetVertexAttribdv","2.0")]
		public static void GetVertexAttrib(uint index,uint pName,ref double parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetVertexAttribfv","2.0")]
		public static void GetVertexAttrib(uint index,uint pName,ref float parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetVertexAttribiv","2.0")]
		public static void GetVertexAttrib(uint index,uint pName,ref int parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetVertexAttribPointerv","2.0")]
		public static void GetVertexAttribPointer(uint index,uint pName,ref IntPtr pointer)
			=> throw new NotImplementedException();
		
		[MethodImport("glIsProgram","2.0")]
		public static byte IsProgram(uint program)
			=> throw new NotImplementedException();
		
		[MethodImport("glIsShader","2.0")]
		public static byte IsShader(uint shader)
			=> throw new NotImplementedException();
		
		[MethodImport("glLinkProgram","2.0")]
		public static void LinkProgram(uint program)
			=> throw new NotImplementedException();
		
		[MethodImport("glShaderSource","2.0")]
		public static void ShaderSource(uint shader,int count,ref IntPtr str,ref int length)
			=> throw new NotImplementedException();
		
		[MethodImport("glUseProgram","2.0")]
		public static void UseProgram(uint program)
			=> throw new NotImplementedException();
		
		[MethodImport("glUniform1f","2.0")]
		public static void Uniform1(int location,float v0)
			=> throw new NotImplementedException();
		
		[MethodImport("glUniform2f","2.0")]
		public static void Uniform2(int location,float v0,float v1)
			=> throw new NotImplementedException();
		
		[MethodImport("glUniform3f","2.0")]
		public static void Uniform3(int location,float v0,float v1,float v2)
			=> throw new NotImplementedException();
		
		[MethodImport("glUniform4f","2.0")]
		public static void Uniform4(int location,float v0,float v1,float v2,float v3)
			=> throw new NotImplementedException();
		
		[MethodImport("glUniform1i","2.0")]
		public static void Uniform1(int location,int v0)
			=> throw new NotImplementedException();
		
		[MethodImport("glUniform2i","2.0")]
		public static void Uniform2(int location,int v0,int v1)
			=> throw new NotImplementedException();
		
		[MethodImport("glUniform3i","2.0")]
		public static void Uniform3(int location,int v0,int v1,int v2)
			=> throw new NotImplementedException();
		
		[MethodImport("glUniform4i","2.0")]
		public static void Uniform4(int location,int v0,int v1,int v2,int v3)
			=> throw new NotImplementedException();
		
		[MethodImport("glUniform1fv","2.0")]
		public static void Uniform1(int location,int count,ref float value)
			=> throw new NotImplementedException();
		
		[MethodImport("glUniform2fv","2.0")]
		public static void Uniform2(int location,int count,ref float value)
			=> throw new NotImplementedException();
		
		[MethodImport("glUniform3fv","2.0")]
		public static void Uniform3(int location,int count,ref float value)
			=> throw new NotImplementedException();
		
		[MethodImport("glUniform4fv","2.0")]
		public static void Uniform4(int location,int count,ref float value)
			=> throw new NotImplementedException();
		
		[MethodImport("glUniform1iv","2.0")]
		public static void Uniform1(int location,int count,ref int value)
			=> throw new NotImplementedException();
		
		[MethodImport("glUniform2iv","2.0")]
		public static void Uniform2(int location,int count,ref int value)
			=> throw new NotImplementedException();
		
		[MethodImport("glUniform3iv","2.0")]
		public static void Uniform3(int location,int count,ref int value)
			=> throw new NotImplementedException();
		
		[MethodImport("glUniform4iv","2.0")]
		public static void Uniform4(int location,int count,ref int value)
			=> throw new NotImplementedException();
		
		[MethodImport("glUniformMatrix2fv","2.0")]
		public static void UniformMatrix2(int location,int count,byte transpose,ref float value)
			=> throw new NotImplementedException();
		
		[MethodImport("glUniformMatrix3fv","2.0")]
		public static void UniformMatrix3(int location,int count,byte transpose,ref float value)
			=> throw new NotImplementedException();
		
		[MethodImport("glUniformMatrix4fv","2.0")]
		public static void UniformMatrix4(int location,int count,byte transpose,ref float value)
			=> throw new NotImplementedException();
		
		[MethodImport("glValidateProgram","2.0")]
		public static void ValidateProgram(uint program)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttrib1d","2.0")]
		public static void VertexAttrib1(uint index,double x)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttrib1dv","2.0")]
		public static void VertexAttrib1(uint index,ref double v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttrib1f","2.0")]
		public static void VertexAttrib1(uint index,float x)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttrib1fv","2.0")]
		public static void VertexAttrib1(uint index,ref float v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttrib1s","2.0")]
		public static void VertexAttrib1(uint index,short x)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttrib1sv","2.0")]
		public static void VertexAttrib1(uint index,ref short v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttrib2d","2.0")]
		public static void VertexAttrib2(uint index,double x,double y)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttrib2dv","2.0")]
		public static void VertexAttrib2(uint index,ref double v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttrib2f","2.0")]
		public static void VertexAttrib2(uint index,float x,float y)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttrib2fv","2.0")]
		public static void VertexAttrib2(uint index,ref float v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttrib2s","2.0")]
		public static void VertexAttrib2(uint index,short x,short y)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttrib2sv","2.0")]
		public static void VertexAttrib2(uint index,ref short v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttrib3d","2.0")]
		public static void VertexAttrib3(uint index,double x,double y,double z)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttrib3dv","2.0")]
		public static void VertexAttrib3(uint index,ref double v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttrib3f","2.0")]
		public static void VertexAttrib3(uint index,float x,float y,float z)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttrib3fv","2.0")]
		public static void VertexAttrib3(uint index,ref float v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttrib3s","2.0")]
		public static void VertexAttrib3(uint index,short x,short y,short z)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttrib3sv","2.0")]
		public static void VertexAttrib3(uint index,ref short v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttrib4Nbv","2.0")]
		public static void VertexAttrib4N(uint index,sbyte[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttrib4Niv","2.0")]
		public static void VertexAttrib4N(uint index,ref int v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttrib4Nsv","2.0")]
		public static void VertexAttrib4N(uint index,ref short v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttrib4Nub","2.0")]
		public static void VertexAttrib4N(uint index,byte x,byte y,byte z,byte w)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttrib4Nubv","2.0")]
		public static void VertexAttrib4N(uint index,byte[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttrib4Nuiv","2.0")]
		public static void VertexAttrib4N(uint index,ref uint v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttrib4Nusv","2.0")]
		public static void VertexAttrib4N(uint index,ref ushort v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttrib4bv","2.0")]
		public static void VertexAttrib4(uint index,sbyte[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttrib4d","2.0")]
		public static void VertexAttrib4(uint index,double x,double y,double z,double w)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttrib4dv","2.0")]
		public static void VertexAttrib4(uint index,ref double v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttrib4f","2.0")]
		public static void VertexAttrib4(uint index,float x,float y,float z,float w)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttrib4fv","2.0")]
		public static void VertexAttrib4(uint index,ref float v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttrib4iv","2.0")]
		public static void VertexAttrib4(uint index,ref int v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttrib4s","2.0")]
		public static void VertexAttrib4(uint index,short x,short y,short z,short w)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttrib4sv","2.0")]
		public static void VertexAttrib4(uint index,ref short v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttrib4ubv","2.0")]
		public static void VertexAttrib4(uint index,byte[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttrib4uiv","2.0")]
		public static void VertexAttrib4(uint index,ref uint v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttrib4usv","2.0")]
		public static void VertexAttrib4(uint index,ref ushort v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttribPointer","2.0")]
		public static void VertexAttribPointer(uint index,int size,uint type,byte normalized,int stride,IntPtr pointer)
			=> throw new NotImplementedException();
		
		#endregion

		#region OpenGL 2.1

		[MethodImport("glUniformMatrix2x3fv","2.1")]
		public static void UniformMatrix2x3(int location,int count,byte transpose,ref float value)
			=> throw new NotImplementedException();
		
		[MethodImport("glUniformMatrix3x2fv","2.1")]
		public static void UniformMatrix3x2(int location,int count,byte transpose,ref float value)
			=> throw new NotImplementedException();
		
		[MethodImport("glUniformMatrix2x4fv","2.1")]
		public static void UniformMatrix2x4(int location,int count,byte transpose,ref float value)
			=> throw new NotImplementedException();
		
		[MethodImport("glUniformMatrix4x2fv","2.1")]
		public static void UniformMatrix4x2(int location,int count,byte transpose,ref float value)
			=> throw new NotImplementedException();
		
		[MethodImport("glUniformMatrix3x4fv","2.1")]
		public static void UniformMatrix3x4(int location,int count,byte transpose,ref float value)
			=> throw new NotImplementedException();
		
		[MethodImport("glUniformMatrix4x3fv","2.1")]
		public static void UniformMatrix4x3(int location,int count,byte transpose,ref float value)
			=> throw new NotImplementedException();
		
		#endregion

		#region OpenGL 3.0

		[MethodImport("glColorMaski","3.0")]
		public static void ColorMask(uint index,byte r,byte g,byte b,byte a)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetBooleani_v","3.0")]
		public static void GetBoolean(uint target,uint index,IntPtr data)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetIntegeri_v","3.0")]
		public static void GetInteger(uint target,uint index,ref int data)
			=> throw new NotImplementedException();
		
		[MethodImport("glEnablei","3.0")]
		public static void Enable(uint target,uint index)
			=> throw new NotImplementedException();
		
		[MethodImport("glDisablei","3.0")]
		public static void Disable(uint target,uint index)
			=> throw new NotImplementedException();
		
		[MethodImport("glIsEnabledi","3.0")]
		public static byte IsEnabled(uint target,uint index)
			=> throw new NotImplementedException();
		
		[MethodImport("glBeginTransformFeedback","3.0")]
		public static void BeginTransformFeedback(uint primitiveMode)
			=> throw new NotImplementedException();
		
		[MethodImport("glEndTransformFeedback","3.0")]
		public static void EndTransformFeedback()
			=> throw new NotImplementedException();
		
		[MethodImport("glBindBufferRange","3.0")]
		public static void BindBufferRange(BufferRangeTarget target,uint index,uint buffer,int offset,int size)
			=> throw new NotImplementedException();
		
		[MethodImport("glBindBufferBase","3.0")]
		public static void BindBufferBase(BufferRangeTarget target,uint index,uint buffer)
			=> throw new NotImplementedException();
		
		[MethodImport("glTransformFeedbackVaryings","3.0")]
		public static void TransformFeedbackVaryings(uint program,int count,IntPtr varyings,uint bufferMode)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetTransformFeedbackVarying","3.0")]
		public static void GetTransformFeedbackVarying(uint program,uint index,int bufSize,ref int length,ref int size,ref uint type,IntPtr name)
			=> throw new NotImplementedException();
		
		[MethodImport("glClampColor","3.0")]
		public static void ClampColor(uint target,uint clamp)
			=> throw new NotImplementedException();
		
		[MethodImport("glBeginConditionalRender","3.0")]
		public static void BeginConditionalRender(uint id,uint mode)
			=> throw new NotImplementedException();
		
		[MethodImport("glEndConditionalRender","3.0")]
		public static void EndConditionalRender()
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttribIPointer","3.0")]
		public static void VertexAttribIPointer(uint index,int size,uint type,int stride,IntPtr pointer)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetVertexAttribIiv","3.0")]
		public static void GetVertexAttribI(uint index,uint pName,ref int parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetVertexAttribIuiv","3.0")]
		public static void GetVertexAttribI(uint index,uint pName,ref uint parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttribI1i","3.0")]
		public static void VertexAttribI1(uint index,int x)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttribI2i","3.0")]
		public static void VertexAttribI2(uint index,int x,int y)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttribI3i","3.0")]
		public static void VertexAttribI3(uint index,int x,int y,int z)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttribI4i","3.0")]
		public static void VertexAttribI4(uint index,int x,int y,int z,int w)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttribI1ui","3.0")]
		public static void VertexAttribI1(uint index,uint x)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttribI2ui","3.0")]
		public static void VertexAttribI2(uint index,uint x,uint y)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttribI3ui","3.0")]
		public static void VertexAttribI3(uint index,uint x,uint y,uint z)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttribI4ui","3.0")]
		public static void VertexAttribI4(uint index,uint x,uint y,uint z,uint w)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttribI1iv","3.0")]
		public static void VertexAttribI1(uint index,ref int v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttribI2iv","3.0")]
		public static void VertexAttribI2(uint index,ref int v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttribI3iv","3.0")]
		public static void VertexAttribI3(uint index,ref int v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttribI4iv","3.0")]
		public static void VertexAttribI4(uint index,ref int v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttribI1uiv","3.0")]
		public static void VertexAttribI1(uint index,ref uint v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttribI2uiv","3.0")]
		public static void VertexAttribI2(uint index,ref uint v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttribI3uiv","3.0")]
		public static void VertexAttribI3(uint index,ref uint v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttribI4uiv","3.0")]
		public static void VertexAttribI4(uint index,ref uint v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttribI4bv","3.0")]
		public static void VertexAttribI4(uint index,sbyte[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttribI4sv","3.0")]
		public static void VertexAttribI4(uint index,ref short v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttribI4ubv","3.0")]
		public static void VertexAttribI4(uint index,byte[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttribI4usv","3.0")]
		public static void VertexAttribI4(uint index,ref ushort v)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetUniformuiv","3.0")]
		public static void GetUniform(uint program,int location,ref uint parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glBindFragDataLocation","3.0")]
		public static void BindFragDataLocation(uint program,uint color,[In] [MarshalAs(UnmanagedType.LPStr)] string name)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetFragDataLocation","3.0")]
		public static int GetFragDataLocation(uint program,[In] [MarshalAs(UnmanagedType.LPStr)] string name)
			=> throw new NotImplementedException();
		
		[MethodImport("glUniform1ui","3.0")]
		public static void Uniform1(int location,uint v0)
			=> throw new NotImplementedException();
		
		[MethodImport("glUniform2ui","3.0")]
		public static void Uniform2(int location,uint v0,uint v1)
			=> throw new NotImplementedException();
		
		[MethodImport("glUniform3ui","3.0")]
		public static void Uniform3(int location,uint v0,uint v1,uint v2)
			=> throw new NotImplementedException();
		
		[MethodImport("glUniform4ui","3.0")]
		public static void Uniform4(int location,uint v0,uint v1,uint v2,uint v3)
			=> throw new NotImplementedException();
		
		[MethodImport("glUniform1uiv","3.0")]
		public static void Uniform1(int location,int count,ref uint value)
			=> throw new NotImplementedException();
		
		[MethodImport("glUniform2uiv","3.0")]
		public static void Uniform2(int location,int count,ref uint value)
			=> throw new NotImplementedException();
		
		[MethodImport("glUniform3uiv","3.0")]
		public static void Uniform3(int location,int count,ref uint value)
			=> throw new NotImplementedException();
		
		[MethodImport("glUniform4uiv","3.0")]
		public static void Uniform4(int location,int count,ref uint value)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexParameterIiv","3.0")]
		public static void TexParameterI(uint target,uint pName,ref int parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexParameterIuiv","3.0")]
		public static void TexParameterI(uint target,uint pName,ref uint parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetTexParameterIiv","3.0")]
		public static void GetTexParameterI(uint target,uint pName,ref int parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetTexParameterIuiv","3.0")]
		public static void GetTexParameterI(uint target,uint pName,ref uint parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glClearBufferiv","3.0")]
		public static void ClearBuffer(uint buffer,int drawbuffer,ref int value)
			=> throw new NotImplementedException();
		
		[MethodImport("glClearBufferuiv","3.0")]
		public static void ClearBuffer(uint buffer,int drawbuffer,ref uint value)
			=> throw new NotImplementedException();
		
		[MethodImport("glClearBufferfv","3.0")]
		public static void ClearBuffer(uint buffer,int drawbuffer,ref float value)
			=> throw new NotImplementedException();
		
		[MethodImport("glClearBufferfi","3.0")]
		public static void ClearBuffer(uint buffer,int drawbuffer,float depth,int stencil)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetStringi","3.0")]
		public static IntPtr GetString(uint name,uint index)
			=> throw new NotImplementedException();
		
		[MethodImport("glIsRenderbuffer","3.0")]
		public static byte IsRenderbuffer(uint renderbuffer)
			=> throw new NotImplementedException();
		
		[MethodImport("glBindRenderbuffer","3.0")]
		public static void BindRenderbuffer(uint target,uint renderbuffer)
			=> throw new NotImplementedException();
		
		[MethodImport("glDeleteRenderbuffers","3.0")]
		public static void DeleteRenderbuffers(int n,ref uint renderbuffers)
			=> throw new NotImplementedException();
		
		[MethodImport("glGenRenderbuffers","3.0")]
		public static void GenRenderbuffers(int n,ref uint renderbuffers)
			=> throw new NotImplementedException();
		
		[MethodImport("glRenderbufferStorage","3.0")]
		public static void RenderbufferStorage(uint target,uint internalFormat,int width,int height)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetRenderbufferParameteriv","3.0")]
		public static void GetRenderbufferParameter(uint target,uint pName,ref int parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glIsFramebuffer","3.0")]
		public static byte IsFramebuffer(uint framebuffer)
			=> throw new NotImplementedException();
		
		[MethodImport("glBindFramebuffer","3.0")]
		public static void BindFramebuffer(FramebufferTarget target,uint framebuffer)
			=> throw new NotImplementedException();
		
		[MethodImport("glDeleteFramebuffers","3.0")]
		public static void DeleteFramebuffers(int n,ref uint framebuffers)
			=> throw new NotImplementedException();
		
		[MethodImport("glGenFramebuffers","3.0")]
		public static void GenFramebuffers(int n,ref uint framebuffers)
			=> throw new NotImplementedException();
		
		[MethodImport("glCheckFramebufferStatus","3.0")]
		public static uint CheckFramebufferStatus(FramebufferTarget target)
			=> throw new NotImplementedException();
		
		[MethodImport("glFramebufferTexture1D","3.0")]
		public static void FramebufferTexture1D(FramebufferTarget target,uint attachment,uint texTarget,uint texture,int level)
			=> throw new NotImplementedException();
		
		[MethodImport("glFramebufferTexture2D","3.0")]
		public static void FramebufferTexture2D(FramebufferTarget target,uint attachment,uint texTarget,uint texture,int level)
			=> throw new NotImplementedException();
		
		[MethodImport("glFramebufferTexture3D","3.0")]
		public static void FramebufferTexture3D(FramebufferTarget target,uint attachment,uint texTarget,uint texture,int level,int zOffset)
			=> throw new NotImplementedException();
		
		[MethodImport("glFramebufferRenderbuffer","3.0")]
		public static void FramebufferRenderbuffer(FramebufferTarget target,uint attachment,uint renderbuffertarget,uint renderbuffer)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetFramebufferAttachmentParameteriv","3.0")]
		public static void GetFramebufferAttachmentParameter(FramebufferTarget target,uint attachment,uint pName,ref int parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGenerateMipmap","3.0")]
		public static void GenerateMipmap(GenerateMipmapTarget target)
			=> throw new NotImplementedException();
		
		[MethodImport("glBlitFramebuffer","3.0")]
		public static void BlitFramebuffer(int srcX0,int srcY0,int srcX1,int srcY1,int dstX0,int dstY0,int dstX1,int dstY1,uint mask,uint filter)
			=> throw new NotImplementedException();
		
		[MethodImport("glRenderbufferStorageMultisample","3.0")]
		public static void RenderbufferStorageMultisample(uint target,int samples,uint internalFormat,int width,int height)
			=> throw new NotImplementedException();
		
		[MethodImport("glFramebufferTextureLayer","3.0")]
		public static void FramebufferTextureLayer(FramebufferTarget target,uint attachment,uint texture,int level,int layer)
			=> throw new NotImplementedException();
		
		[MethodImport("glMapBufferRange","3.0")]
		public static IntPtr MapBufferRange(BufferTarget target,int offset,int length,uint access)
			=> throw new NotImplementedException();
		
		[MethodImport("glFlushMappedBufferRange","3.0")]
		public static void FlushMappedBufferRange(BufferTarget target,int offset,int length)
			=> throw new NotImplementedException();
		
		[MethodImport("glBindVertexArray","3.0")]
		public static void BindVertexArray(uint array)
			=> throw new NotImplementedException();
		
		[MethodImport("glDeleteVertexArrays","3.0")]
		public static void DeleteVertexArrays(int n,ref uint arrays)
			=> throw new NotImplementedException();
		
		[MethodImport("glGenVertexArrays","3.0")]
		public static void GenVertexArrays(int n,ref uint arrays)
			=> throw new NotImplementedException();
		
		[MethodImport("glIsVertexArray","3.0")]
		public static byte IsVertexArray(uint array)
			=> throw new NotImplementedException();

		#endregion

		#region OpenGL 3.1

		[MethodImport("glDrawArraysInstanced","3.1")]
		public static void DrawArraysInstanced(uint mode,int first,int count,int instanceCount)
			=> throw new NotImplementedException();
		
		[MethodImport("glDrawElementsInstanced","3.1")]
		public static void DrawElementsInstanced(uint mode,int count,uint type,IntPtr indices,int instanceCount)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexBuffer","3.1")]
		public static void TexBuffer(uint target,uint internalFormat,uint buffer)
			=> throw new NotImplementedException();
		
		[MethodImport("glPrimitiveRestartIndex","3.1")]
		public static void PrimitiveRestartIndex(uint index)
			=> throw new NotImplementedException();
		
		[MethodImport("glCopyBufferSubData","3.1")]
		public static void CopyBufferSubData(uint readTarget,uint writeTarget,int readOffset,int writeOffset,int size)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetUniformIndices","3.1")]
		public static void GetUniformIndices(uint program,int uniformCount,IntPtr uniformNames,ref uint uniformIndices)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetActiveUniformsiv","3.1")]
		public static void GetActiveUniforms(uint program,int uniformCount,ref uint uniformIndices,uint pName,ref int parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetActiveUniformName","3.1")]
		public static void GetActiveUniformName(uint program,uint uniformIndex,int bufSize,ref int length,IntPtr uniformName)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetUniformBlockIndex","3.1")]
		public static uint GetUniformBlockIndex(uint program,[In] [MarshalAs(UnmanagedType.LPStr)] string uniformBlockName)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetActiveUniformBlockiv","3.1")]
		public static void GetActiveUniformBlock(uint program,uint uniformBlockIndex,uint pName,ref int parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetActiveUniformBlockName","3.1")]
		public static void GetActiveUniformBlockName(uint program,uint uniformBlockIndex,int bufSize,ref int length,IntPtr uniformBlockName)
			=> throw new NotImplementedException();
		
		[MethodImport("glUniformBlockBinding","3.1")]
		public static void UniformBlockBinding(uint program,uint uniformBlockIndex,uint uniformBlockBinding)
			=> throw new NotImplementedException();
		
		#endregion

		#region OpenGL 3.2

		[MethodImport("glDrawElementsBaseVertex","3.2")]
		public static void DrawElementsBaseVertex(uint mode,int count,uint type,IntPtr indices,int basevertex)
			=> throw new NotImplementedException();
		
		[MethodImport("glDrawRangeElementsBaseVertex","3.2")]
		public static void DrawRangeElementsBaseVertex(uint mode,uint start,uint end,int count,uint type,IntPtr indices,int basevertex)
			=> throw new NotImplementedException();
		
		[MethodImport("glDrawElementsInstancedBaseVertex","3.2")]
		public static void DrawElementsInstancedBaseVertex(uint mode,int count,uint type,IntPtr indices,int instanceCount,int basevertex)
			=> throw new NotImplementedException();
		
		[MethodImport("glMultiDrawElementsBaseVertex","3.2")]
		public static void MultiDrawElementsBaseVertex(uint mode,ref int count,uint type,IntPtr indices,int drawcount,ref int basevertex)
			=> throw new NotImplementedException();
		
		[MethodImport("glProvokingVertex","3.2")]
		public static void ProvokingVertex(uint mode)
			=> throw new NotImplementedException();
		
		[MethodImport("glFenceSync","3.2")]
		public static IntPtr FenceSync(uint condition,uint flags)
			=> throw new NotImplementedException();
		
		[MethodImport("glIsSync","3.2")]
		public static byte IsSync(IntPtr sync)
			=> throw new NotImplementedException();
		
		[MethodImport("glDeleteSync","3.2")]
		public static void DeleteSync(IntPtr sync)
			=> throw new NotImplementedException();
		
		[MethodImport("glClientWaitSync","3.2")]
		public static uint ClientWaitSync(IntPtr sync,uint flags,uint timeout)
			=> throw new NotImplementedException();
		
		[MethodImport("glWaitSync","3.2")]
		public static void WaitSync(IntPtr sync,uint flags,uint timeout)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetInteger64v","3.2")]
		public static void GetInteger(uint pName,ref int data)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetSynciv","3.2")]
		public static void GetSync(IntPtr sync,uint pName,int bufSize,ref int length,ref int values)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetInteger64i_v","3.2")]
		public static void GetInteger(uint target,uint index,ref long data)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetBufferParameteri64v","3.2")]
		public static void GetBufferParameter(BufferTarget target,uint pName,ref long parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glFramebufferTexture","3.2")]
		public static void FramebufferTexture(FramebufferTarget target,uint attachment,uint texture,int level)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexImage2DMultisample","3.2")]
		public static void TexImage2DMultisample(uint target,int samples,uint internalFormat,int width,int height,byte fixedsamplelocations)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexImage3DMultisample","3.2")]
		public static void TexImage3DMultisample(uint target,int samples,uint internalFormat,int width,int height,int depth,byte fixedsamplelocations)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetMultisamplefv","3.2")]
		public static void GetMultisample(uint pName,uint index,ref float val)
			=> throw new NotImplementedException();
		
		[MethodImport("glSampleMaski","3.2")]
		public static void SampleMask(uint maskNumber,uint mask)
			=> throw new NotImplementedException();

		#endregion

		#region OpenGL 3.3

		[MethodImport("glBindFragDataLocationIndexed","3.3")]
		public static void BindFragDataLocationIndexed(uint program,uint colorNumber,uint index,[In] [MarshalAs(UnmanagedType.LPStr)] string name)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetFragDataIndex","3.3")]
		public static int GetFragDataIndex(uint program,[In] [MarshalAs(UnmanagedType.LPStr)] string name)
			=> throw new NotImplementedException();
		
		[MethodImport("glGenSamplers","3.3")]
		public static void GenSamplers(int count,ref uint samplers)
			=> throw new NotImplementedException();
		
		[MethodImport("glDeleteSamplers","3.3")]
		public static void DeleteSamplers(int count,ref uint samplers)
			=> throw new NotImplementedException();
		
		[MethodImport("glIsSampler","3.3")]
		public static byte IsSampler(uint sampler)
			=> throw new NotImplementedException();
		
		[MethodImport("glBindSampler","3.3")]
		public static void BindSampler(uint unit,uint sampler)
			=> throw new NotImplementedException();
		
		[MethodImport("glSamplerParameteri","3.3")]
		public static void SamplerParameter(uint sampler,uint pName,int param)
			=> throw new NotImplementedException();
		
		[MethodImport("glSamplerParameteriv","3.3")]
		public static void SamplerParameter(uint sampler,uint pName,ref int param)
			=> throw new NotImplementedException();
		
		[MethodImport("glSamplerParameterf","3.3")]
		public static void SamplerParameter(uint sampler,uint pName,float param)
			=> throw new NotImplementedException();
		
		[MethodImport("glSamplerParameterfv","3.3")]
		public static void SamplerParameter(uint sampler,uint pName,ref float param)
			=> throw new NotImplementedException();
		
		[MethodImport("glSamplerParameterIiv","3.3")]
		public static void SamplerParameterI(uint sampler,uint pName,ref int param)
			=> throw new NotImplementedException();
		
		[MethodImport("glSamplerParameterIuiv","3.3")]
		public static void SamplerParameterI(uint sampler,uint pName,ref uint param)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetSamplerParameteriv","3.3")]
		public static void GetSamplerParameter(uint sampler,uint pName,ref int parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetSamplerParameterIiv","3.3")]
		public static void GetSamplerParameterI(uint sampler,uint pName,ref int parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetSamplerParameterfv","3.3")]
		public static void GetSamplerParameter(uint sampler,uint pName,ref float parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetSamplerParameterIuiv","3.3")]
		public static void GetSamplerParameterI(uint sampler,uint pName,ref uint parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glQueryCounter","3.3")]
		public static void QueryCounter(uint id,uint target)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetQueryObjecti64v","3.3")]
		public static void GetQueryObject(uint id,uint pName,ref long parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetQueryObjectui64v","3.3")]
		public static void GetQueryObject(uint id,uint pName,ref ulong parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttribDivisor","3.3")]
		public static void VertexAttribDivisor(uint index,uint divisor)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttribP1ui","3.3")]
		public static void VertexAttribP1(uint index,uint type,byte normalized,uint value)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttribP1uiv","3.3")]
		public static void VertexAttribP1(uint index,uint type,byte normalized,ref uint value)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttribP2ui","3.3")]
		public static void VertexAttribP2(uint index,uint type,byte normalized,uint value)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttribP2uiv","3.3")]
		public static void VertexAttribP2(uint index,uint type,byte normalized,ref uint value)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttribP3ui","3.3")]
		public static void VertexAttribP3(uint index,uint type,byte normalized,uint value)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttribP3uiv","3.3")]
		public static void VertexAttribP3(uint index,uint type,byte normalized,ref uint value)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttribP4ui","3.3")]
		public static void VertexAttribP4(uint index,uint type,byte normalized,uint value)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttribP4uiv","3.3")]
		public static void VertexAttribP4(uint index,uint type,byte normalized,ref uint value)
			=> throw new NotImplementedException();

		#endregion

		#region OpenGL 4.0

		[MethodImport("glMinSampleShading","4.0")]
		public static void MinSampleShading(float value)
			=> throw new NotImplementedException();
		
		[MethodImport("glBlendEquationi","4.0")]
		public static void BlendEquation(uint buf,uint mode)
			=> throw new NotImplementedException();
		
		[MethodImport("glBlendEquationSeparatei","4.0")]
		public static void BlendEquationSeparate(uint buf,uint modeRGB,uint modeAlpha)
			=> throw new NotImplementedException();
		
		[MethodImport("glBlendFunci","4.0")]
		public static void BlendFunc(uint buf,BlendingFactor src,BlendingFactor dst)
			=> throw new NotImplementedException();
		
		[MethodImport("glBlendFuncSeparatei","4.0")]
		public static void BlendFuncSeparate(uint buf,uint srcRGB,uint dstRGB,uint srcAlpha,uint dstAlpha)
			=> throw new NotImplementedException();
		
		[MethodImport("glDrawArraysIndirect","4.0")]
		public static void DrawArraysIndirect(uint mode,IntPtr indirect)
			=> throw new NotImplementedException();
		
		[MethodImport("glDrawElementsIndirect","4.0")]
		public static void DrawElementsIndirect(uint mode,uint type,IntPtr indirect)
			=> throw new NotImplementedException();
		
		[MethodImport("glUniform1d","4.0")]
		public static void Uniform1(int location,double x)
			=> throw new NotImplementedException();
		
		[MethodImport("glUniform2d","4.0")]
		public static void Uniform2(int location,double x,double y)
			=> throw new NotImplementedException();
		
		[MethodImport("glUniform3d","4.0")]
		public static void Uniform3(int location,double x,double y,double z)
			=> throw new NotImplementedException();
		
		[MethodImport("glUniform4d","4.0")]
		public static void Uniform4(int location,double x,double y,double z,double w)
			=> throw new NotImplementedException();
		
		[MethodImport("glUniform1dv","4.0")]
		public static void Uniform1(int location,int count,ref double value)
			=> throw new NotImplementedException();
		
		[MethodImport("glUniform2dv","4.0")]
		public static void Uniform2(int location,int count,ref double value)
			=> throw new NotImplementedException();
		
		[MethodImport("glUniform3dv","4.0")]
		public static void Uniform3(int location,int count,ref double value)
			=> throw new NotImplementedException();
		
		[MethodImport("glUniform4dv","4.0")]
		public static void Uniform4(int location,int count,ref double value)
			=> throw new NotImplementedException();
		
		[MethodImport("glUniformMatrix2dv","4.0")]
		public static void UniformMatrix2(int location,int count,byte transpose,ref double value)
			=> throw new NotImplementedException();
		
		[MethodImport("glUniformMatrix3dv","4.0")]
		public static void UniformMatrix3(int location,int count,byte transpose,ref double value)
			=> throw new NotImplementedException();
		
		[MethodImport("glUniformMatrix4dv","4.0")]
		public static void UniformMatrix4(int location,int count,byte transpose,ref double value)
			=> throw new NotImplementedException();
		
		[MethodImport("glUniformMatrix2x3dv","4.0")]
		public static void UniformMatrix2x3(int location,int count,byte transpose,ref double value)
			=> throw new NotImplementedException();
		
		[MethodImport("glUniformMatrix2x4dv","4.0")]
		public static void UniformMatrix2x4(int location,int count,byte transpose,ref double value)
			=> throw new NotImplementedException();
		
		[MethodImport("glUniformMatrix3x2dv","4.0")]
		public static void UniformMatrix3x2(int location,int count,byte transpose,ref double value)
			=> throw new NotImplementedException();
		
		[MethodImport("glUniformMatrix3x4dv","4.0")]
		public static void UniformMatrix3x4(int location,int count,byte transpose,ref double value)
			=> throw new NotImplementedException();
		
		[MethodImport("glUniformMatrix4x2dv","4.0")]
		public static void UniformMatrix4x2(int location,int count,byte transpose,ref double value)
			=> throw new NotImplementedException();
		
		[MethodImport("glUniformMatrix4x3dv","4.0")]
		public static void UniformMatrix4x3(int location,int count,byte transpose,ref double value)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetUniformdv","4.0")]
		public static void GetUniform(uint program,int location,ref double parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetSubroutineUniformLocation","4.0")]
		public static int GetSubroutineUniformLocation(uint program,uint shadertype,[In] [MarshalAs(UnmanagedType.LPStr)] string name)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetSubroutineIndex","4.0")]
		public static uint GetSubroutineIndex(uint program,uint shadertype,[In] [MarshalAs(UnmanagedType.LPStr)] string name)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetActiveSubroutineUniformiv","4.0")]
		public static void GetActiveSubroutineUniform(uint program,uint shadertype,uint index,uint pName,ref int values)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetActiveSubroutineUniformName","4.0")]
		public static void GetActiveSubroutineUniformName(uint program,uint shadertype,uint index,int bufsize,ref int length,IntPtr name)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetActiveSubroutineName","4.0")]
		public static void GetActiveSubroutineName(uint program,uint shadertype,uint index,int bufsize,ref int length,IntPtr name)
			=> throw new NotImplementedException();
		
		[MethodImport("glUniformSubroutinesuiv","4.0")]
		public static void UniformSubroutines(uint shadertype,int count,ref uint indices)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetUniformSubroutineuiv","4.0")]
		public static void GetUniformSubroutine(uint shadertype,int location,ref uint parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetProgramStageiv","4.0")]
		public static void GetProgramStage(uint program,uint shadertype,uint pName,ref int values)
			=> throw new NotImplementedException();
		
		[MethodImport("glPatchParameteri","4.0")]
		public static void PatchParameter(uint pName,int value)
			=> throw new NotImplementedException();
		
		[MethodImport("glPatchParameterfv","4.0")]
		public static void PatchParameter(uint pName,ref float values)
			=> throw new NotImplementedException();
		
		[MethodImport("glBindTransformFeedback","4.0")]
		public static void BindTransformFeedback(uint target,uint id)
			=> throw new NotImplementedException();
		
		[MethodImport("glDeleteTransformFeedbacks","4.0")]
		public static void DeleteTransformFeedbacks(int n,ref uint ids)
			=> throw new NotImplementedException();
		
		[MethodImport("glGenTransformFeedbacks","4.0")]
		public static void GenTransformFeedbacks(int n,ref uint ids)
			=> throw new NotImplementedException();
		
		[MethodImport("glIsTransformFeedback","4.0")]
		public static byte IsTransformFeedback(uint id)
			=> throw new NotImplementedException();
		
		[MethodImport("glPauseTransformFeedback","4.0")]
		public static void PauseTransformFeedback()
			=> throw new NotImplementedException();
		
		[MethodImport("glResumeTransformFeedback","4.0")]
		public static void ResumeTransformFeedback()
			=> throw new NotImplementedException();
		
		[MethodImport("glDrawTransformFeedback","4.0")]
		public static void DrawTransformFeedback(uint mode,uint id)
			=> throw new NotImplementedException();
		
		[MethodImport("glDrawTransformFeedbackStream","4.0")]
		public static void DrawTransformFeedbackStream(uint mode,uint id,uint stream)
			=> throw new NotImplementedException();
		
		[MethodImport("glBeginQueryIndexed","4.0")]
		public static void BeginQueryIndexed(uint target,uint index,uint id)
			=> throw new NotImplementedException();
		
		[MethodImport("glEndQueryIndexed","4.0")]
		public static void EndQueryIndexed(uint target,uint index)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetQueryIndexediv","4.0")]
		public static void GetQueryIndexed(uint target,uint index,uint pName,ref int parameters)
			=> throw new NotImplementedException();
		
		#endregion

		#region OpenGL 4.1

		[MethodImport("glReleaseShaderCompiler","4.1")]
		public static void ReleaseShaderCompiler()
			=> throw new NotImplementedException();
		
		[MethodImport("glShaderBinary","4.1")]
		public static void ShaderBinary(int count,ref uint shaders,uint binaryformat,IntPtr binary,int length)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetShaderPrecisionFormat","4.1")]
		public static void GetShaderPrecisionFormat(uint shadertype,uint precisiontype,ref int range,ref int precision)
			=> throw new NotImplementedException();
		
		[MethodImport("glDepthRangef","4.1")]
		public static void DepthRange(float n,float f)
			=> throw new NotImplementedException();
		
		[MethodImport("glClearDepthf","4.1")]
		public static void ClearDepth(float d)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetProgramBinary","4.1")]
		public static void GetProgramBinary(uint program,int bufSize,ref int length,ref uint binaryFormat,IntPtr binary)
			=> throw new NotImplementedException();
		
		[MethodImport("glProgramBinary","4.1")]
		public static void ProgramBinary(uint program,uint binaryFormat,IntPtr binary,int length)
			=> throw new NotImplementedException();
		
		[MethodImport("glProgramParameteri","4.1")]
		public static void ProgramParameter(uint program,uint pName,int value)
			=> throw new NotImplementedException();
		
		[MethodImport("glUseProgramStages","4.1")]
		public static void UseProgramStages(uint pipeline,uint stages,uint program)
			=> throw new NotImplementedException();
		
		[MethodImport("glActiveShaderProgram","4.1")]
		public static void ActiveShaderProgram(uint pipeline,uint program)
			=> throw new NotImplementedException();
		
		[MethodImport("glCreateShaderProgramv","4.1")]
		public static uint CreateShaderProgram(uint type,int count,IntPtr strings)
			=> throw new NotImplementedException();
		
		[MethodImport("glBindProgramPipeline","4.1")]
		public static void BindProgramPipeline(uint pipeline)
			=> throw new NotImplementedException();
		
		[MethodImport("glDeleteProgramPipelines","4.1")]
		public static void DeleteProgramPipelines(int n,ref uint pipelines)
			=> throw new NotImplementedException();
		
		[MethodImport("glGenProgramPipelines","4.1")]
		public static void GenProgramPipelines(int n,ref uint pipelines)
			=> throw new NotImplementedException();
		
		[MethodImport("glIsProgramPipeline","4.1")]
		public static byte IsProgramPipeline(uint pipeline)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetProgramPipelineiv","4.1")]
		public static void GetProgramPipeline(uint pipeline,uint pName,ref int parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glProgramUniform1i","4.1")]
		public static void ProgramUniform1(uint program,int location,int v0)
			=> throw new NotImplementedException();
		
		[MethodImport("glProgramUniform1iv","4.1")]
		public static void ProgramUniform1(uint program,int location,int count,ref int value)
			=> throw new NotImplementedException();
		
		[MethodImport("glProgramUniform1f","4.1")]
		public static void ProgramUniform1(uint program,int location,float v0)
			=> throw new NotImplementedException();
		
		[MethodImport("glProgramUniform1fv","4.1")]
		public static void ProgramUniform1(uint program,int location,int count,ref float value)
			=> throw new NotImplementedException();
		
		[MethodImport("glProgramUniform1d","4.1")]
		public static void ProgramUniform1(uint program,int location,double v0)
			=> throw new NotImplementedException();
		
		[MethodImport("glProgramUniform1dv","4.1")]
		public static void ProgramUniform1(uint program,int location,int count,ref double value)
			=> throw new NotImplementedException();
		
		[MethodImport("glProgramUniform1ui","4.1")]
		public static void ProgramUniform1(uint program,int location,uint v0)
			=> throw new NotImplementedException();
		
		[MethodImport("glProgramUniform1uiv","4.1")]
		public static void ProgramUniform1(uint program,int location,int count,ref uint value)
			=> throw new NotImplementedException();
		
		[MethodImport("glProgramUniform2i","4.1")]
		public static void ProgramUniform2(uint program,int location,int v0,int v1)
			=> throw new NotImplementedException();
		
		[MethodImport("glProgramUniform2iv","4.1")]
		public static void ProgramUniform2(uint program,int location,int count,ref int value)
			=> throw new NotImplementedException();
		
		[MethodImport("glProgramUniform2f","4.1")]
		public static void ProgramUniform2(uint program,int location,float v0,float v1)
			=> throw new NotImplementedException();
		
		[MethodImport("glProgramUniform2fv","4.1")]
		public static void ProgramUniform2(uint program,int location,int count,ref float value)
			=> throw new NotImplementedException();
		
		[MethodImport("glProgramUniform2d","4.1")]
		public static void ProgramUniform2(uint program,int location,double v0,double v1)
			=> throw new NotImplementedException();
		
		[MethodImport("glProgramUniform2dv","4.1")]
		public static void ProgramUniform2(uint program,int location,int count,ref double value)
			=> throw new NotImplementedException();
		
		[MethodImport("glProgramUniform2ui","4.1")]
		public static void ProgramUniform2(uint program,int location,uint v0,uint v1)
			=> throw new NotImplementedException();
		
		[MethodImport("glProgramUniform2uiv","4.1")]
		public static void ProgramUniform2(uint program,int location,int count,ref uint value)
			=> throw new NotImplementedException();
		
		[MethodImport("glProgramUniform3i","4.1")]
		public static void ProgramUniform3(uint program,int location,int v0,int v1,int v2)
			=> throw new NotImplementedException();
		
		[MethodImport("glProgramUniform3iv","4.1")]
		public static void ProgramUniform3(uint program,int location,int count,ref int value)
			=> throw new NotImplementedException();
		
		[MethodImport("glProgramUniform3f","4.1")]
		public static void ProgramUniform3(uint program,int location,float v0,float v1,float v2)
			=> throw new NotImplementedException();
		
		[MethodImport("glProgramUniform3fv","4.1")]
		public static void ProgramUniform3(uint program,int location,int count,ref float value)
			=> throw new NotImplementedException();
		
		[MethodImport("glProgramUniform3d","4.1")]
		public static void ProgramUniform3(uint program,int location,double v0,double v1,double v2)
			=> throw new NotImplementedException();
		
		[MethodImport("glProgramUniform3dv","4.1")]
		public static void ProgramUniform3(uint program,int location,int count,ref double value)
			=> throw new NotImplementedException();
		
		[MethodImport("glProgramUniform3ui","4.1")]
		public static void ProgramUniform3(uint program,int location,uint v0,uint v1,uint v2)
			=> throw new NotImplementedException();
		
		[MethodImport("glProgramUniform3uiv","4.1")]
		public static void ProgramUniform3(uint program,int location,int count,ref uint value)
			=> throw new NotImplementedException();
		
		[MethodImport("glProgramUniform4i","4.1")]
		public static void ProgramUniform4(uint program,int location,int v0,int v1,int v2,int v3)
			=> throw new NotImplementedException();
		
		[MethodImport("glProgramUniform4iv","4.1")]
		public static void ProgramUniform4(uint program,int location,int count,ref int value)
			=> throw new NotImplementedException();
		
		[MethodImport("glProgramUniform4f","4.1")]
		public static void ProgramUniform4(uint program,int location,float v0,float v1,float v2,float v3)
			=> throw new NotImplementedException();
		
		[MethodImport("glProgramUniform4fv","4.1")]
		public static void ProgramUniform4(uint program,int location,int count,ref float value)
			=> throw new NotImplementedException();
		
		[MethodImport("glProgramUniform4d","4.1")]
		public static void ProgramUniform4(uint program,int location,double v0,double v1,double v2,double v3)
			=> throw new NotImplementedException();
		
		[MethodImport("glProgramUniform4dv","4.1")]
		public static void ProgramUniform4(uint program,int location,int count,ref double value)
			=> throw new NotImplementedException();
		
		[MethodImport("glProgramUniform4ui","4.1")]
		public static void ProgramUniform4(uint program,int location,uint v0,uint v1,uint v2,uint v3)
			=> throw new NotImplementedException();
		
		[MethodImport("glProgramUniform4uiv","4.1")]
		public static void ProgramUniform4(uint program,int location,int count,ref uint value)
			=> throw new NotImplementedException();
		
		[MethodImport("glProgramUniformMatrix2fv","4.1")]
		public static void ProgramUniformMatrix2(uint program,int location,int count,byte transpose,ref float value)
			=> throw new NotImplementedException();
		
		[MethodImport("glProgramUniformMatrix3fv","4.1")]
		public static void ProgramUniformMatrix3(uint program,int location,int count,byte transpose,ref float value)
			=> throw new NotImplementedException();
		
		[MethodImport("glProgramUniformMatrix4fv","4.1")]
		public static void ProgramUniformMatrix4(uint program,int location,int count,byte transpose,ref float value)
			=> throw new NotImplementedException();
		
		[MethodImport("glProgramUniformMatrix2dv","4.1")]
		public static void ProgramUniformMatrix2(uint program,int location,int count,byte transpose,ref double value)
			=> throw new NotImplementedException();
		
		[MethodImport("glProgramUniformMatrix3dv","4.1")]
		public static void ProgramUniformMatrix3(uint program,int location,int count,byte transpose,ref double value)
			=> throw new NotImplementedException();
		
		[MethodImport("glProgramUniformMatrix4dv","4.1")]
		public static void ProgramUniformMatrix4(uint program,int location,int count,byte transpose,ref double value)
			=> throw new NotImplementedException();
		
		[MethodImport("glProgramUniformMatrix2x3fv","4.1")]
		public static void ProgramUniformMatrix2x3(uint program,int location,int count,byte transpose,ref float value)
			=> throw new NotImplementedException();
		
		[MethodImport("glProgramUniformMatrix3x2fv","4.1")]
		public static void ProgramUniformMatrix3x2(uint program,int location,int count,byte transpose,ref float value)
			=> throw new NotImplementedException();
		
		[MethodImport("glProgramUniformMatrix2x4fv","4.1")]
		public static void ProgramUniformMatrix2x4(uint program,int location,int count,byte transpose,ref float value)
			=> throw new NotImplementedException();
		
		[MethodImport("glProgramUniformMatrix4x2fv","4.1")]
		public static void ProgramUniformMatrix4x2(uint program,int location,int count,byte transpose,ref float value)
			=> throw new NotImplementedException();
		
		[MethodImport("glProgramUniformMatrix3x4fv","4.1")]
		public static void ProgramUniformMatrix3x4(uint program,int location,int count,byte transpose,ref float value)
			=> throw new NotImplementedException();
		
		[MethodImport("glProgramUniformMatrix4x3fv","4.1")]
		public static void ProgramUniformMatrix4x3(uint program,int location,int count,byte transpose,ref float value)
			=> throw new NotImplementedException();
		
		[MethodImport("glProgramUniformMatrix2x3dv","4.1")]
		public static void ProgramUniformMatrix2x3(uint program,int location,int count,byte transpose,ref double value)
			=> throw new NotImplementedException();
		
		[MethodImport("glProgramUniformMatrix3x2dv","4.1")]
		public static void ProgramUniformMatrix3x2(uint program,int location,int count,byte transpose,ref double value)
			=> throw new NotImplementedException();
		
		[MethodImport("glProgramUniformMatrix2x4dv","4.1")]
		public static void ProgramUniformMatrix2x4(uint program,int location,int count,byte transpose,ref double value)
			=> throw new NotImplementedException();
		
		[MethodImport("glProgramUniformMatrix4x2dv","4.1")]
		public static void ProgramUniformMatrix4x2(uint program,int location,int count,byte transpose,ref double value)
			=> throw new NotImplementedException();
		
		[MethodImport("glProgramUniformMatrix3x4dv","4.1")]
		public static void ProgramUniformMatrix3x4(uint program,int location,int count,byte transpose,ref double value)
			=> throw new NotImplementedException();
		
		[MethodImport("glProgramUniformMatrix4x3dv","4.1")]
		public static void ProgramUniformMatrix4x3(uint program,int location,int count,byte transpose,ref double value)
			=> throw new NotImplementedException();
		
		[MethodImport("glValidateProgramPipeline","4.1")]
		public static void ValidateProgramPipeline(uint pipeline)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetProgramPipelineInfoLog","4.1")]
		public static void GetProgramPipelineInfoLog(uint pipeline,int bufSize,ref int length,IntPtr infoLog)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttribL1d","4.1")]
		public static void VertexAttribL1(uint index,double x)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttribL2d","4.1")]
		public static void VertexAttribL2(uint index,double x,double y)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttribL3d","4.1")]
		public static void VertexAttribL3(uint index,double x,double y,double z)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttribL4d","4.1")]
		public static void VertexAttribL4(uint index,double x,double y,double z,double w)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttribL1dv","4.1")]
		public static void VertexAttribL1(uint index,ref double v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttribL2dv","4.1")]
		public static void VertexAttribL2(uint index,ref double v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttribL3dv","4.1")]
		public static void VertexAttribL3(uint index,ref double v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttribL4dv","4.1")]
		public static void VertexAttribL4(uint index,ref double v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttribLPointer","4.1")]
		public static void VertexAttribLPointer(uint index,int size,uint type,int stride,IntPtr pointer)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetVertexAttribLdv","4.1")]
		public static void GetVertexAttribL(uint index,uint pName,ref double parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glViewportArrayv","4.1")]
		public static void ViewportArray(uint first,int count,ref float v)
			=> throw new NotImplementedException();
		
		[MethodImport("glViewportIndexedf","4.1")]
		public static void ViewportIndexed(uint index,float x,float y,float w,float h)
			=> throw new NotImplementedException();
		
		[MethodImport("glViewportIndexedfv","4.1")]
		public static void ViewportIndexed(uint index,ref float v)
			=> throw new NotImplementedException();
		
		[MethodImport("glScissorArrayv","4.1")]
		public static void ScissorArray(uint first,int count,ref int v)
			=> throw new NotImplementedException();
		
		[MethodImport("glScissorIndexed","4.1")]
		public static void ScissorIndexed(uint index,int left,int bottom,int width,int height)
			=> throw new NotImplementedException();
		
		[MethodImport("glScissorIndexedv","4.1")]
		public static void ScissorIndexed(uint index,ref int v)
			=> throw new NotImplementedException();
		
		[MethodImport("glDepthRangeArrayv","4.1")]
		public static void DepthRangeArray(uint first,int count,ref double v)
			=> throw new NotImplementedException();
		
		[MethodImport("glDepthRangeIndexed","4.1")]
		public static void DepthRangeIndexed(uint index,double n,double f)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetFloati_v","4.1")]
		public static void GetFloat(uint target,uint index,ref float data)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetDoublei_v","4.1")]
		public static void GetDouble(uint target,uint index,ref double data)
			=> throw new NotImplementedException();

		#endregion

		#region OpenGL 4.2

		[MethodImport("glDrawArraysInstancedBaseInstance","4.2")]
		public static void DrawArraysInstancedBaseInstance(uint mode,int first,int count,int instanceCount,uint baseinstance)
			=> throw new NotImplementedException();
		
		[MethodImport("glDrawElementsInstancedBaseInstance","4.2")]
		public static void DrawElementsInstancedBaseInstance(uint mode,int count,uint type,IntPtr indices,int instanceCount,uint baseinstance)
			=> throw new NotImplementedException();
		
		[MethodImport("glDrawElementsInstancedBaseVertexBaseInstance","4.2")]
		public static void DrawElementsInstancedBaseVertexBaseInstance(uint mode,int count,uint type,IntPtr indices,int instanceCount,int basevertex,uint baseinstance)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetInternalformativ","4.2")]
		public static void GetInternalformat(uint target,uint internalFormat,uint pName,int bufSize,ref int parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetActiveAtomicCounterBufferiv","4.2")]
		public static void GetActiveAtomicCounterBuffer(uint program,uint bufferIndex,uint pName,ref int parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glBindImageTexture","4.2")]
		public static void BindImageTexture(uint unit,uint texture,int level,byte layered,int layer,uint access,uint format)
			=> throw new NotImplementedException();
		
		[MethodImport("glMemoryBarrier","4.2")]
		public static void MemoryBarrier(uint barriers)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexStorage1D","4.2")]
		public static void TexStorage1D(uint target,int levels,uint internalFormat,int width)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexStorage2D","4.2")]
		public static void TexStorage2D(uint target,int levels,uint internalFormat,int width,int height)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexStorage3D","4.2")]
		public static void TexStorage3D(uint target,int levels,uint internalFormat,int width,int height,int depth)
			=> throw new NotImplementedException();
		
		[MethodImport("glDrawTransformFeedbackInstanced","4.2")]
		public static void DrawTransformFeedbackInstanced(uint mode,uint id,int instanceCount)
			=> throw new NotImplementedException();
		
		[MethodImport("glDrawTransformFeedbackStreamInstanced","4.2")]
		public static void DrawTransformFeedbackStreamInstanced(uint mode,uint id,uint stream,int instanceCount)
			=> throw new NotImplementedException();
		
		#endregion

		#region OpenGL 4.3

		[MethodImport("glClearBufferData","4.3")]
		public static void ClearBufferData(BufferTarget target,uint internalFormat,uint format,uint type,IntPtr data)
			=> throw new NotImplementedException();
		
		[MethodImport("glClearBufferSubData","4.3")]
		public static void ClearBufferSubData(BufferTarget target,uint internalFormat,int offset,int size,uint format,uint type,IntPtr data)
			=> throw new NotImplementedException();
		
		[MethodImport("glDispatchCompute","4.3")]
		public static void DispatchCompute(uint num_groups_x,uint num_groups_y,uint num_groups_z)
			=> throw new NotImplementedException();
		
		[MethodImport("glDispatchComputeIndirect","4.3")]
		public static void DispatchComputeIndirect(int indirect)
			=> throw new NotImplementedException();
		
		[MethodImport("glCopyImageSubData","4.3")]
		public static void CopyImageSubData(uint srcName,uint srcTarget,int srcLevel,int srcX,int srcY,int srcZ,uint dstName,uint dstTarget,int dstLevel,int dstX,int dstY,int dstZ,int srcWidth,int srcHeight,int srcDepth)
			=> throw new NotImplementedException();
		
		[MethodImport("glFramebufferParameteri","4.3")]
		public static void FramebufferParameter(FramebufferTarget target,uint pName,int param)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetFramebufferParameteriv","4.3")]
		public static void GetFramebufferParameter(FramebufferTarget target,uint pName,ref int parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetInternalformati64v","4.3")]
		public static void GetInternalformat(uint target,uint internalFormat,uint pName,int bufSize,ref long parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glInvalidateTexSubImage","4.3")]
		public static void InvalidateTexSubImage(uint texture,int level,int xOffset,int yOffset,int zOffset,int width,int height,int depth)
			=> throw new NotImplementedException();
		
		[MethodImport("glInvalidateTexImage","4.3")]
		public static void InvalidateTexImage(uint texture,int level)
			=> throw new NotImplementedException();
		
		[MethodImport("glInvalidateBufferSubData","4.3")]
		public static void InvalidateBufferSubData(uint buffer,int offset,int length)
			=> throw new NotImplementedException();
		
		[MethodImport("glInvalidateBufferData","4.3")]
		public static void InvalidateBufferData(uint buffer)
			=> throw new NotImplementedException();
		
		[MethodImport("glInvalidateFramebuffer","4.3")]
		public static void InvalidateFramebuffer(FramebufferTarget target,int numAttachments,ref uint attachments)
			=> throw new NotImplementedException();
		
		[MethodImport("glInvalidateSubFramebuffer","4.3")]
		public static void InvalidateSubFramebuffer(FramebufferTarget target,int numAttachments,ref uint attachments,int x,int y,int width,int height)
			=> throw new NotImplementedException();
		
		[MethodImport("glMultiDrawArraysIndirect","4.3")]
		public static void MultiDrawArraysIndirect(uint mode,IntPtr indirect,int drawcount,int stride)
			=> throw new NotImplementedException();
		
		[MethodImport("glMultiDrawElementsIndirect","4.3")]
		public static void MultiDrawElementsIndirect(uint mode,uint type,IntPtr indirect,int drawcount,int stride)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetProgramInterfaceiv","4.3")]
		public static void GetProgramInterface(uint program,uint programInterface,uint pName,ref int parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetProgramResourceIndex","4.3")]
		public static uint GetProgramResourceIndex(uint program,uint programInterface,[In] [MarshalAs(UnmanagedType.LPStr)] string name)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetProgramResourceName","4.3")]
		public static void GetProgramResourceName(uint program,uint programInterface,uint index,int bufSize,ref int length,IntPtr name)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetProgramResourceiv","4.3")]
		public static void GetProgramResource(uint program,uint programInterface,uint index,int propCount,ref uint props,int bufSize,ref int length,ref int parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetProgramResourceLocation","4.3")]
		public static int GetProgramResourceLocation(uint program,uint programInterface,[In] [MarshalAs(UnmanagedType.LPStr)] string name)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetProgramResourceLocationIndex","4.3")]
		public static int GetProgramResourceLocationIndex(uint program,uint programInterface,[In] [MarshalAs(UnmanagedType.LPStr)] string name)
			=> throw new NotImplementedException();
		
		[MethodImport("glShaderStorageBlockBinding","4.3")]
		public static void ShaderStorageBlockBinding(uint program,uint storageBlockIndex,uint storageBlockBinding)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexBufferRange","4.3")]
		public static void TexBufferRange(uint target,uint internalFormat,uint buffer,int offset,int size)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexStorage2DMultisample","4.3")]
		public static void TexStorage2DMultisample(uint target,int samples,uint internalFormat,int width,int height,byte fixedsamplelocations)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexStorage3DMultisample","4.3")]
		public static void TexStorage3DMultisample(uint target,int samples,uint internalFormat,int width,int height,int depth,byte fixedsamplelocations)
			=> throw new NotImplementedException();
		
		[MethodImport("glTextureView","4.3")]
		public static void TextureView(uint texture,uint target,uint origtexture,uint internalFormat,uint minlevel,uint numlevels,uint minlayer,uint numlayers)
			=> throw new NotImplementedException();
		
		[MethodImport("glBindVertexBuffer","4.3")]
		public static void BindVertexBuffer(uint bindingindex,uint buffer,int offset,int stride)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttribFormat","4.3")]
		public static void VertexAttribFormat(uint attribindex,int size,uint type,byte normalized,uint relativeoffset)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttribIFormat","4.3")]
		public static void VertexAttribIFormat(uint attribindex,int size,uint type,uint relativeoffset)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttribLFormat","4.3")]
		public static void VertexAttribLFormat(uint attribindex,int size,uint type,uint relativeoffset)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexAttribBinding","4.3")]
		public static void VertexAttribBinding(uint attribindex,uint bindingindex)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexBindingDivisor","4.3")]
		public static void VertexBindingDivisor(uint bindingindex,uint divisor)
			=> throw new NotImplementedException();
		
		[MethodImport("glDebugMessageControl","4.3")]
		public static void DebugMessageControl(uint source,uint type,uint severity,int count,ref uint ids,byte enabled)
			=> throw new NotImplementedException();
		
		[MethodImport("glDebugMessageInsert","4.3")]
		public static void DebugMessageInsert(uint source,uint type,uint id,uint severity,int length,[In] [MarshalAs(UnmanagedType.LPStr)] string buf)
			=> throw new NotImplementedException();
		
		[MethodImport("glDebugMessageCallback","4.3")]
		public static void DebugMessageCallback(DebugCallback callback,IntPtr userParameter)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetDebugMessageLog","4.3")]
		public static uint GetDebugMessageLog(uint count,int bufSize,ref uint sources,ref uint types,ref uint ids,ref uint severities,ref int lengths,IntPtr messageLog)
			=> throw new NotImplementedException();
		
		[MethodImport("glPushDebugGroup","4.3")]
		public static void PushDebugGroup(uint source,uint id,int length,[In] [MarshalAs(UnmanagedType.LPStr)] string message)
			=> throw new NotImplementedException();
		
		[MethodImport("glPopDebugGroup","4.3")]
		public static void PopDebugGroup()
			=> throw new NotImplementedException();
		
		[MethodImport("glObjectLabel","4.3")]
		public static void ObjectLabel(uint identifier,uint name,int length,[In] [MarshalAs(UnmanagedType.LPStr)] string label)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetObjectLabel","4.3")]
		public static void GetObjectLabel(uint identifier,uint name,int bufSize,ref int length,IntPtr label)
			=> throw new NotImplementedException();
		
		[MethodImport("glObjectPtrLabel","4.3")]
		public static void ObjectPtrLabel(IntPtr ptr,int length,[In] [MarshalAs(UnmanagedType.LPStr)] string label)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetObjectPtrLabel","4.3")]
		public static void GetObjectPtrLabel(IntPtr ptr,int bufSize,ref int length,IntPtr label)
			=> throw new NotImplementedException();
		
		#endregion

		#region OpenGL 4.4

		[MethodImport("glBufferStorage","4.4")]
		public static void BufferStorage(BufferTarget target,int size,IntPtr data,uint flags)
			=> throw new NotImplementedException();
		
		[MethodImport("glClearTexImage","4.4")]
		public static void ClearTexImage(uint texture,int level,uint format,uint type,IntPtr data)
			=> throw new NotImplementedException();
		
		[MethodImport("glClearTexSubImage","4.4")]
		public static void ClearTexSubImage(uint texture,int level,int xOffset,int yOffset,int zOffset,int width,int height,int depth,uint format,uint type,IntPtr data)
			=> throw new NotImplementedException();
		
		[MethodImport("glBindBuffersBase","4.4")]
		public static void BindBuffersBase(BufferRangeTarget target,uint first,int count,ref uint buffers)
			=> throw new NotImplementedException();
		
		[MethodImport("glBindBuffersRange","4.4")]
		public static void BindBuffersRange(BufferRangeTarget target,uint first,int count,ref uint buffers,ref int offsets,ref int sizes)
			=> throw new NotImplementedException();
		
		[MethodImport("glBindTextures","4.4")]
		public static void BindTextures(uint first,int count,ref uint textures)
			=> throw new NotImplementedException();
		
		[MethodImport("glBindSamplers","4.4")]
		public static void BindSamplers(uint first,int count,ref uint samplers)
			=> throw new NotImplementedException();
		
		[MethodImport("glBindImageTextures","4.4")]
		public static void BindImageTextures(uint first,int count,ref uint textures)
			=> throw new NotImplementedException();
		
		[MethodImport("glBindVertexBuffers","4.4")]
		public static void BindVertexBuffers(uint first,int count,ref uint buffers,ref int offsets,ref int strides)
			=> throw new NotImplementedException();
		
		#endregion

		#region OpenGL 4.5

		[MethodImport("glClipControl","4.5")]
		public static void ClipControl(uint origin,uint depth)
			=> throw new NotImplementedException();
		
		[MethodImport("glCreateTransformFeedbacks","4.5")]
		public static void CreateTransformFeedbacks(int n,ref uint ids)
			=> throw new NotImplementedException();
		
		[MethodImport("glTransformFeedbackBufferBase","4.5")]
		public static void TransformFeedbackBufferBase(uint xfb,uint index,uint buffer)
			=> throw new NotImplementedException();
		
		[MethodImport("glTransformFeedbackBufferRange","4.5")]
		public static void TransformFeedbackBufferRange(uint xfb,uint index,uint buffer,int offset,int size)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetTransformFeedbackiv","4.5")]
		public static void GetTransformFeedback(uint xfb,uint pName,ref int param)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetTransformFeedbacki_v","4.5")]
		public static void GetTransformFeedback(uint xfb,uint pName,uint index,ref int param)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetTransformFeedbacki64_v","4.5")]
		public static void GetTransformFeedback(uint xfb,uint pName,uint index,ref long param)
			=> throw new NotImplementedException();
		
		[MethodImport("glCreateBuffers","4.5")]
		public static void CreateBuffers(int n,ref uint buffers)
			=> throw new NotImplementedException();
		
		[MethodImport("glNamedBufferStorage","4.5")]
		public static void NamedBufferStorage(uint buffer,int size,IntPtr data,uint flags)
			=> throw new NotImplementedException();
		
		[MethodImport("glNamedBufferData","4.5")]
		public static void NamedBufferData(uint buffer,int size,IntPtr data,uint usage)
			=> throw new NotImplementedException();
		
		[MethodImport("glNamedBufferSubData","4.5")]
		public static void NamedBufferSubData(uint buffer,int offset,int size,IntPtr data)
			=> throw new NotImplementedException();
		
		[MethodImport("glCopyNamedBufferSubData","4.5")]
		public static void CopyNamedBufferSubData(uint readBuffer,uint writeBuffer,int readOffset,int writeOffset,int size)
			=> throw new NotImplementedException();
		
		[MethodImport("glClearNamedBufferData","4.5")]
		public static void ClearNamedBufferData(uint buffer,uint internalFormat,uint format,uint type,IntPtr data)
			=> throw new NotImplementedException();
		
		[MethodImport("glClearNamedBufferSubData","4.5")]
		public static void ClearNamedBufferSubData(uint buffer,uint internalFormat,int offset,int size,uint format,uint type,IntPtr data)
			=> throw new NotImplementedException();
		
		[MethodImport("glMapNamedBuffer","4.5")]
		public static IntPtr MapNamedBuffer(uint buffer,uint access)
			=> throw new NotImplementedException();
		
		[MethodImport("glMapNamedBufferRange","4.5")]
		public static IntPtr MapNamedBufferRange(uint buffer,int offset,int length,uint access)
			=> throw new NotImplementedException();
		
		[MethodImport("glUnmapNamedBuffer","4.5")]
		public static byte UnmapNamedBuffer(uint buffer)
			=> throw new NotImplementedException();
		
		[MethodImport("glFlushMappedNamedBufferRange","4.5")]
		public static void FlushMappedNamedBufferRange(uint buffer,int offset,int length)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetNamedBufferParameteriv","4.5")]
		public static void GetNamedBufferParameter(uint buffer,uint pName,ref int parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetNamedBufferParameteri64v","4.5")]
		public static void GetNamedBufferParameter(uint buffer,uint pName,ref long parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetNamedBufferPointerv","4.5")]
		public static void GetNamedBufferPointer(uint buffer,uint pName,ref IntPtr parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetNamedBufferSubData","4.5")]
		public static void GetNamedBufferSubData(uint buffer,int offset,int size,IntPtr data)
			=> throw new NotImplementedException();
		
		[MethodImport("glCreateFramebuffers","4.5")]
		public static void CreateFramebuffers(int n,ref uint framebuffers)
			=> throw new NotImplementedException();
		
		[MethodImport("glNamedFramebufferRenderbuffer","4.5")]
		public static void NamedFramebufferRenderbuffer(uint framebuffer,uint attachment,uint renderbuffertarget,uint renderbuffer)
			=> throw new NotImplementedException();
		
		[MethodImport("glNamedFramebufferParameteri","4.5")]
		public static void NamedFramebufferParameter(uint framebuffer,uint pName,int param)
			=> throw new NotImplementedException();
		
		[MethodImport("glNamedFramebufferTexture","4.5")]
		public static void NamedFramebufferTexture(uint framebuffer,uint attachment,uint texture,int level)
			=> throw new NotImplementedException();
		
		[MethodImport("glNamedFramebufferTextureLayer","4.5")]
		public static void NamedFramebufferTextureLayer(uint framebuffer,uint attachment,uint texture,int level,int layer)
			=> throw new NotImplementedException();
		
		[MethodImport("glNamedFramebufferDrawBuffer","4.5")]
		public static void NamedFramebufferDrawBuffer(uint framebuffer,DrawBufferMode buf)
			=> throw new NotImplementedException();
		
		[MethodImport("glNamedFramebufferDrawBuffers","4.5")]
		public static void NamedFramebufferDrawBuffers(uint framebuffer,int n,DrawBufferMode[] bufs)
			=> throw new NotImplementedException();
		
		[MethodImport("glNamedFramebufferReadBuffer","4.5")]
		public static void NamedFramebufferReadBuffer(uint framebuffer,uint src)
			=> throw new NotImplementedException();
		
		[MethodImport("glInvalidateNamedFramebufferData","4.5")]
		public static void InvalidateNamedFramebufferData(uint framebuffer,int numAttachments,ref uint attachments)
			=> throw new NotImplementedException();
		
		[MethodImport("glInvalidateNamedFramebufferSubData","4.5")]
		public static void InvalidateNamedFramebufferSubData(uint framebuffer,int numAttachments,ref uint attachments,int x,int y,int width,int height)
			=> throw new NotImplementedException();
		
		[MethodImport("glClearNamedFramebufferiv","4.5")]
		public static void ClearNamedFramebuffer(uint framebuffer,uint buffer,int drawbuffer,ref int value)
			=> throw new NotImplementedException();
		
		[MethodImport("glClearNamedFramebufferuiv","4.5")]
		public static void ClearNamedFramebuffer(uint framebuffer,uint buffer,int drawbuffer,ref uint value)
			=> throw new NotImplementedException();
		
		[MethodImport("glClearNamedFramebufferfv","4.5")]
		public static void ClearNamedFramebuffer(uint framebuffer,uint buffer,int drawbuffer,ref float value)
			=> throw new NotImplementedException();
		
		[MethodImport("glClearNamedFramebufferfi","4.5")]
		public static void ClearNamedFramebuffer(uint framebuffer,uint buffer,int drawbuffer,float depth,int stencil)
			=> throw new NotImplementedException();
		
		[MethodImport("glBlitNamedFramebuffer","4.5")]
		public static void BlitNamedFramebuffer(uint readFramebuffer,uint drawFramebuffer,int srcX0,int srcY0,int srcX1,int srcY1,int dstX0,int dstY0,int dstX1,int dstY1,uint mask,uint filter)
			=> throw new NotImplementedException();
		
		[MethodImport("glCheckNamedFramebufferStatus","4.5")]
		public static uint CheckNamedFramebufferStatus(uint framebuffer,FramebufferTarget target)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetNamedFramebufferParameteriv","4.5")]
		public static void GetNamedFramebufferParameter(uint framebuffer,uint pName,ref int param)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetNamedFramebufferAttachmentParameteriv","4.5")]
		public static void GetNamedFramebufferAttachmentParameter(uint framebuffer,uint attachment,uint pName,ref int parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glCreateRenderbuffers","4.5")]
		public static void CreateRenderbuffers(int n,ref uint renderbuffers)
			=> throw new NotImplementedException();
		
		[MethodImport("glNamedRenderbufferStorage","4.5")]
		public static void NamedRenderbufferStorage(uint renderbuffer,uint internalFormat,int width,int height)
			=> throw new NotImplementedException();
		
		[MethodImport("glNamedRenderbufferStorageMultisample","4.5")]
		public static void NamedRenderbufferStorageMultisample(uint renderbuffer,int samples,uint internalFormat,int width,int height)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetNamedRenderbufferParameteriv","4.5")]
		public static void GetNamedRenderbufferParameter(uint renderbuffer,uint pName,ref int parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glCreateTextures","4.5")]
		public static void CreateTextures(uint target,int n,ref uint textures)
			=> throw new NotImplementedException();
		
		[MethodImport("glTextureBuffer","4.5")]
		public static void TextureBuffer(uint texture,uint internalFormat,uint buffer)
			=> throw new NotImplementedException();
		
		[MethodImport("glTextureBufferRange","4.5")]
		public static void TextureBufferRange(uint texture,uint internalFormat,uint buffer,int offset,int size)
			=> throw new NotImplementedException();
		
		[MethodImport("glTextureStorage1D","4.5")]
		public static void TextureStorage1D(uint texture,int levels,uint internalFormat,int width)
			=> throw new NotImplementedException();
		
		[MethodImport("glTextureStorage2D","4.5")]
		public static void TextureStorage2D(uint texture,int levels,uint internalFormat,int width,int height)
			=> throw new NotImplementedException();
		
		[MethodImport("glTextureStorage3D","4.5")]
		public static void TextureStorage3D(uint texture,int levels,uint internalFormat,int width,int height,int depth)
			=> throw new NotImplementedException();
		
		[MethodImport("glTextureStorage2DMultisample","4.5")]
		public static void TextureStorage2DMultisample(uint texture,int samples,uint internalFormat,int width,int height,byte fixedsamplelocations)
			=> throw new NotImplementedException();
		
		[MethodImport("glTextureStorage3DMultisample","4.5")]
		public static void TextureStorage3DMultisample(uint texture,int samples,uint internalFormat,int width,int height,int depth,byte fixedsamplelocations)
			=> throw new NotImplementedException();
		
		[MethodImport("glTextureSubImage1D","4.5")]
		public static void TextureSubImage1D(uint texture,int level,int xOffset,int width,uint format,uint type,IntPtr pixels)
			=> throw new NotImplementedException();
		
		[MethodImport("glTextureSubImage2D","4.5")]
		public static void TextureSubImage2D(uint texture,int level,int xOffset,int yOffset,int width,int height,uint format,uint type,IntPtr pixels)
			=> throw new NotImplementedException();
		
		[MethodImport("glTextureSubImage3D","4.5")]
		public static void TextureSubImage3D(uint texture,int level,int xOffset,int yOffset,int zOffset,int width,int height,int depth,uint format,uint type,IntPtr pixels)
			=> throw new NotImplementedException();
		
		[MethodImport("glCompressedTextureSubImage1D","4.5")]
		public static void CompressedTextureSubImage1D(uint texture,int level,int xOffset,int width,uint format,int imageSize,IntPtr data)
			=> throw new NotImplementedException();
		
		[MethodImport("glCompressedTextureSubImage2D","4.5")]
		public static void CompressedTextureSubImage2D(uint texture,int level,int xOffset,int yOffset,int width,int height,uint format,int imageSize,IntPtr data)
			=> throw new NotImplementedException();
		
		[MethodImport("glCompressedTextureSubImage3D","4.5")]
		public static void CompressedTextureSubImage3D(uint texture,int level,int xOffset,int yOffset,int zOffset,int width,int height,int depth,uint format,int imageSize,IntPtr data)
			=> throw new NotImplementedException();
		
		[MethodImport("glCopyTextureSubImage1D","4.5")]
		public static void CopyTextureSubImage1D(uint texture,int level,int xOffset,int x,int y,int width)
			=> throw new NotImplementedException();
		
		[MethodImport("glCopyTextureSubImage2D","4.5")]
		public static void CopyTextureSubImage2D(uint texture,int level,int xOffset,int yOffset,int x,int y,int width,int height)
			=> throw new NotImplementedException();
		
		[MethodImport("glCopyTextureSubImage3D","4.5")]
		public static void CopyTextureSubImage3D(uint texture,int level,int xOffset,int yOffset,int zOffset,int x,int y,int width,int height)
			=> throw new NotImplementedException();
		
		[MethodImport("glTextureParameterf","4.5")]
		public static void TextureParameter(uint texture,uint pName,float param)
			=> throw new NotImplementedException();
		
		[MethodImport("glTextureParameterfv","4.5")]
		public static void TextureParameter(uint texture,uint pName,ref float param)
			=> throw new NotImplementedException();
		
		[MethodImport("glTextureParameteri","4.5")]
		public static void TextureParameter(uint texture,uint pName,int param)
			=> throw new NotImplementedException();
		
		[MethodImport("glTextureParameterIiv","4.5")]
		public static void TextureParameterI(uint texture,uint pName,ref int parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glTextureParameterIuiv","4.5")]
		public static void TextureParameterI(uint texture,uint pName,ref uint parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glTextureParameteriv","4.5")]
		public static void TextureParameter(uint texture,uint pName,ref int param)
			=> throw new NotImplementedException();
		
		[MethodImport("glGenerateTextureMipmap","4.5")]
		public static void GenerateTextureMipmap(uint texture)
			=> throw new NotImplementedException();
		
		[MethodImport("glBindTextureUnit","4.5")]
		public static void BindTextureUnit(uint unit,uint texture)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetTextureImage","4.5")]
		public static void GetTextureImage(uint texture,int level,uint format,uint type,int bufSize,IntPtr pixels)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetCompressedTextureImage","4.5")]
		public static void GetCompressedTextureImage(uint texture,int level,int bufSize,IntPtr pixels)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetTextureLevelParameterfv","4.5")]
		public static void GetTextureLevelParameter(uint texture,int level,uint pName,ref float parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetTextureLevelParameteriv","4.5")]
		public static void GetTextureLevelParameter(uint texture,int level,uint pName,ref int parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetTextureParameterfv","4.5")]
		public static void GetTextureParameter(uint texture,uint pName,ref float parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetTextureParameterIiv","4.5")]
		public static void GetTextureParameterI(uint texture,uint pName,ref int parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetTextureParameterIuiv","4.5")]
		public static void GetTextureParameterI(uint texture,uint pName,ref uint parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetTextureParameteriv","4.5")]
		public static void GetTextureParameter(uint texture,uint pName,ref int parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glCreateVertexArrays","4.5")]
		public static void CreateVertexArrays(int n,ref uint arrays)
			=> throw new NotImplementedException();
		
		[MethodImport("glDisableVertexArrayAttrib","4.5")]
		public static void DisableVertexArrayAttrib(uint vaobj,uint index)
			=> throw new NotImplementedException();
		
		[MethodImport("glEnableVertexArrayAttrib","4.5")]
		public static void EnableVertexArrayAttrib(uint vaobj,uint index)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexArrayElementBuffer","4.5")]
		public static void VertexArrayElementBuffer(uint vaobj,uint buffer)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexArrayVertexBuffer","4.5")]
		public static void VertexArrayVertexBuffer(uint vaobj,uint bindingindex,uint buffer,int offset,int stride)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexArrayVertexBuffers","4.5")]
		public static void VertexArrayVertexBuffers(uint vaobj,uint first,int count,ref uint buffers,ref int offsets,ref int strides)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexArrayAttribBinding","4.5")]
		public static void VertexArrayAttribBinding(uint vaobj,uint attribindex,uint bindingindex)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexArrayAttribFormat","4.5")]
		public static void VertexArrayAttribFormat(uint vaobj,uint attribindex,int size,uint type,byte normalized,uint relativeoffset)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexArrayAttribIFormat","4.5")]
		public static void VertexArrayAttribIFormat(uint vaobj,uint attribindex,int size,uint type,uint relativeoffset)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexArrayAttribLFormat","4.5")]
		public static void VertexArrayAttribLFormat(uint vaobj,uint attribindex,int size,uint type,uint relativeoffset)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexArrayBindingDivisor","4.5")]
		public static void VertexArrayBindingDivisor(uint vaobj,uint bindingindex,uint divisor)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetVertexArrayiv","4.5")]
		public static void GetVertexArray(uint vaobj,uint pName,ref int param)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetVertexArrayIndexediv","4.5")]
		public static void GetVertexArrayIndexed(uint vaobj,uint index,uint pName,ref int param)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetVertexArrayIndexed64iv","4.5")]
		public static void GetVertexArrayIndexed(uint vaobj,uint index,uint pName,ref long param)
			=> throw new NotImplementedException();
		
		[MethodImport("glCreateSamplers","4.5")]
		public static void CreateSamplers(int n,ref uint samplers)
			=> throw new NotImplementedException();
		
		[MethodImport("glCreateProgramPipelines","4.5")]
		public static void CreateProgramPipelines(int n,ref uint pipelines)
			=> throw new NotImplementedException();
		
		[MethodImport("glCreateQueries","4.5")]
		public static void CreateQueries(uint target,int n,ref uint ids)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetQueryBufferObjecti64v","4.5")]
		public static void GetQueryBufferObjectLong(uint id,uint buffer,uint pName,int offset)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetQueryBufferObjectiv","4.5")]
		public static void GetQueryBufferObjectInt(uint id,uint buffer,uint pName,int offset)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetQueryBufferObjectui64v","4.5")]
		public static void GetQueryBufferObjectULong(uint id,uint buffer,uint pName,int offset)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetQueryBufferObjectuiv","4.5")]
		public static void GetQueryBufferObjectUInt(uint id,uint buffer,uint pName,int offset)
			=> throw new NotImplementedException();
		
		[MethodImport("glMemoryBarrierByRegion","4.5")]
		public static void MemoryBarrierByRegion(uint barriers)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetTextureSubImage","4.5")]
		public static void GetTextureSubImage(uint texture,int level,int xOffset,int yOffset,int zOffset,int width,int height,int depth,uint format,uint type,int bufSize,IntPtr pixels)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetCompressedTextureSubImage","4.5")]
		public static void GetCompressedTextureSubImage(uint texture,int level,int xOffset,int yOffset,int zOffset,int width,int height,int depth,int bufSize,IntPtr pixels)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetGraphicsResetStatus","4.5")]
		public static uint GetGraphicsResetStatus()
			=> throw new NotImplementedException();
		
		[MethodImport("glGetnCompressedTexImage","4.5")]
		public static void GetnCompressedTexImage(uint target,int lod,int bufSize,IntPtr pixels)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetnTexImage","4.5")]
		public static void GetnTexImage(uint target,int level,uint format,uint type,int bufSize,IntPtr pixels)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetnUniformdv","4.5")]
		public static void GetnUniform(uint program,int location,int bufSize,ref double parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetnUniformfv","4.5")]
		public static void GetnUniform(uint program,int location,int bufSize,ref float parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetnUniformiv","4.5")]
		public static void GetnUniform(uint program,int location,int bufSize,ref int parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetnUniformuiv","4.5")]
		public static void GetnUniform(uint program,int location,int bufSize,ref uint parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glReadnPixels","4.5")]
		public static void ReadnPixels(int x,int y,int width,int height,uint format,uint type,int bufSize,IntPtr data)
			=> throw new NotImplementedException();
		
		[MethodImport("glTextureBarrier","4.5")]
		public static void TextureBarrier()
			=> throw new NotImplementedException();

		#endregion
	}
}