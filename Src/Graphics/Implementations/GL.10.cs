using System;
using System.Runtime.InteropServices;

#pragma warning disable IDE0060 //Unused parameter.

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[MethodImport("glAccum","1.0")]
		public static void Accum(uint op,float value)
			=> throw new NotImplementedException();
		
		[MethodImport("glAlphaFunc","1.0")]
		public static void AlphaFunc(uint func,float alpha)
			=> throw new NotImplementedException();
		
		[MethodImport("glAreTexturesResident","1.0")]
		public static byte AreTexturesResident(int n,uint[] textures,IntPtr residences)
			=> throw new NotImplementedException();
		
		[MethodImport("glArrayElement","1.0")]
		public static void ArrayElement(int i)
			=> throw new NotImplementedException();
		
		[MethodImport("glBegin","1.0")]
		public static void Begin(PrimitiveType mode)
			=> throw new NotImplementedException();
		
		[MethodImport("glBindTexture","1.0")]
		public static void BindTexture(TextureTarget target,uint texture)
			=> throw new NotImplementedException();
		
		[MethodImport("glBitmap","1.0")]
		public static void Bitmap(int width,int height,float xOrig,float yOrig,float xMove,float yMove,IntPtr bitmap)
			=> throw new NotImplementedException();
		
		[MethodImport("glBlendFunc","1.0")]
		public static void BlendFunc(BlendingFactor sfactor,BlendingFactor dfactor)
			=> throw new NotImplementedException();
		
		[MethodImport("glCallList","1.0")]
		public static void CallList(uint list)
			=> throw new NotImplementedException();
		
		[MethodImport("glCallLists","1.0")]
		public static void CallLists(int n,uint type,IntPtr lists)
			=> throw new NotImplementedException();
		
		[MethodImport("glClear","1.0")]
		public static void Clear(ClearBufferMask mask)
			=> throw new NotImplementedException();
		
		[MethodImport("glClearAccum","1.0")]
		public static void ClearAccum(float red,float green,float blue,float alpha = 1f)
			=> throw new NotImplementedException();
		
		[MethodImport("glClearAccum","1.0")]
		public static void ClearAccum(int red,int green,int blue,int alpha = 255)
			=> throw new NotImplementedException();
		
		[MethodImport("glClearAccum","1.0")]
		public static void ClearAccum(byte red,byte green,byte blue,byte alpha = 255)
			=> throw new NotImplementedException();
		
		[MethodImport("glClearColor","1.0")]
		public static void ClearColor(float red,float green,float blue,float alpha = 1f)
			=> throw new NotImplementedException();
		
		[MethodImport("glClearColor","1.0")]
		public static void ClearColor(int red,int green,int blue,int alpha = 255)
			=> throw new NotImplementedException();
		
		[MethodImport("glClearColor","1.0")]
		public static void ClearColor(byte red,byte green,byte blue,byte alpha = 255)
			=> throw new NotImplementedException();
		
		[MethodImport("glClearDepth","1.0")]
		public static void ClearDepth(double depth)
			=> throw new NotImplementedException();
		
		[MethodImport("glClearIndex","1.0")]
		public static void ClearIndex(float c)
			=> throw new NotImplementedException();
		
		[MethodImport("glClearStencil","1.0")]
		public static void ClearStencil(int s)
			=> throw new NotImplementedException();
		
		[MethodImport("glClipPlane","1.0")]
		public static void ClipPlane(uint plane,double[] equation)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor3b","1.0")]
		public static void Color3(sbyte red,sbyte green,sbyte blue)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor3bv","1.0")]
		public static void Color3(sbyte[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor3d","1.0")]
		public static void Color3(double red,double green,double blue)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor3dv","1.0")]
		public static void Color3(double[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor3f","1.0")]
		public static void Color3(float red,float green,float blue)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor3fv","1.0")]
		public static void Color3(float[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor3i","1.0")]
		public static void Color3(int red,int green,int blue)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor3iv","1.0")]
		public static void Color3(int[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor3s","1.0")]
		public static void Color3(short red,short green,short blue)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor3sv","1.0")]
		public static void Color3(short[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor3ub","1.0")]
		public static void Color3(byte red,byte green,byte blue)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor3ubv","1.0")]
		public static void Color3(byte[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor3ui","1.0")]
		public static void Color3(uint red,uint green,uint blue)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor3uiv","1.0")]
		public static void Color3(uint[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor3us","1.0")]
		public static void Color3(ushort red,ushort green,ushort blue)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor3usv","1.0")]
		public static void Color3(ushort[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor4b","1.0")]
		public static void Color4(sbyte red,sbyte green,sbyte blue,sbyte alpha)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor4bv","1.0")]
		public static void Color4(sbyte[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor4d","1.0")]
		public static void Color4(double red,double green,double blue,double alpha)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor4dv","1.0")]
		public static void Color4(double[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor4f","1.0")]
		public static void Color4(float red,float green,float blue,float alpha)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor4fv","1.0")]
		public static void Color4(float[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor4i","1.0")]
		public static void Color4(int red,int green,int blue,int alpha)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor4iv","1.0")]
		public static void Color4(int[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor4s","1.0")]
		public static void Color4(short red,short green,short blue,short alpha)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor4sv","1.0")]
		public static void Color4(short[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor4ub","1.0")]
		public static void Color4(byte red,byte green,byte blue,byte alpha)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor4ubv","1.0")]
		public static void Color4(byte[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor4ui","1.0")]
		public static void Color4(uint red,uint green,uint blue,uint alpha)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor4uiv","1.0")]
		public static void Color4(uint[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor4us","1.0")]
		public static void Color4(ushort red,ushort green,ushort blue,ushort alpha)
			=> throw new NotImplementedException();
		
		[MethodImport("glColor4usv","1.0")]
		public static void Color4(ushort[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glColorMask","1.0")]
		public static void ColorMask(byte red,byte green,byte blue,byte alpha)
			=> throw new NotImplementedException();
		
		[MethodImport("glColorMaterial","1.0")]
		public static void ColorMaterial(uint face,uint mode)
			=> throw new NotImplementedException();
		
		[MethodImport("glColorPointer","1.0")]
		public static void ColorPointer(int size,uint type,int stride,IntPtr pointer)
			=> throw new NotImplementedException();
		
		[MethodImport("glCopyPixels","1.0")]
		public static void CopyPixels(int x,int y,int width,int height,uint type)
			=> throw new NotImplementedException();
		
		[MethodImport("glCopyTexImage1D","1.0")]
		public static void CopyTexImage1D(TextureTarget target,int level,uint internalFormat,int x,int y,int width,int border)
			=> throw new NotImplementedException();
		
		[MethodImport("glCopyTexImage2D","1.0")]
		public static void CopyTexImage2D(TextureTarget target,int level,uint internalFormat,int x,int y,int width,int height,int border)
			=> throw new NotImplementedException();
		
		[MethodImport("glCopyTexSubImage1D","1.0")]
		public static void CopyTexSubImage1D(TextureTarget target,int level,int xOffset,int x,int y,int width)
			=> throw new NotImplementedException();
		
		[MethodImport("glCopyTexSubImage2D","1.0")]
		public static void CopyTexSubImage2D(TextureTarget target,int level,int xOffset,int yOffset,int x,int y,int width,int height)
			=> throw new NotImplementedException();
		
		[MethodImport("glCullFace","1.0")]
		public static void CullFace(CullFaceMode mode)
			=> throw new NotImplementedException();
		
		[MethodImport("glDeleteLists","1.0")]
		public static void DeleteLists(uint list,int range)
			=> throw new NotImplementedException();
		
		[MethodImport("glDepthFunc","1.0")]
		public static void DepthFunc(DepthFunction func)
			=> throw new NotImplementedException();
		
		[MethodImport("glDepthMask","1.0")]
		public static void DepthMask(bool flag)
			=> throw new NotImplementedException();
		
		[MethodImport("glDepthRange","1.0")]
		public static void DepthRange(double zNear,double zFar)
			=> throw new NotImplementedException();
		
		[MethodImport("glDisable","1.0")]
		public static void Disable(EnableCap cap)
			=> throw new NotImplementedException();
		
		[MethodImport("glDisableClientState","1.0")]
		public static void DisableClientState(uint capability)
			=> throw new NotImplementedException();
		
		[MethodImport("glDrawArrays","1.0")]
		public static void DrawArrays(PrimitiveType mode,int first,int count)
			=> throw new NotImplementedException();
		
		[MethodImport("glDrawBuffer","1.0")]
		public static void DrawBuffer(DrawBufferMode mode)
			=> throw new NotImplementedException();
		
		[MethodImport("glDrawElements","1.0")]
		public static void DrawElements(PrimitiveType mode,int count,DrawElementsType type,IntPtr indices)
			=> throw new NotImplementedException();
		
		[MethodImport("glDrawPixels","1.0")]
		public static void DrawPixels(int width,int height,PixelFormat format,PixelType type,IntPtr pixels)
			=> throw new NotImplementedException();
		
		[MethodImport("glEdgeFlag","1.0")]
		public static void EdgeFlag(byte flag)
			=> throw new NotImplementedException();
		
		[MethodImport("glEdgeFlagPointer","1.0")]
		public static void EdgeFlagPointer(int stride,IntPtr pointer)
			=> throw new NotImplementedException();
		
		[MethodImport("glEdgeFlagv","1.0")]
		public static void EdgeFlag(IntPtr flag)
			=> throw new NotImplementedException();
		
		[MethodImport("glEnable","1.0")]
		public static void Enable(EnableCap cap)
			=> throw new NotImplementedException();
		
		[MethodImport("glEnableClientState","1.0")]
		public static void EnableClientState(uint capability)
			=> throw new NotImplementedException();
		
		[MethodImport("glEnd","1.0")]
		public static void End()
			=> throw new NotImplementedException();
		
		[MethodImport("glEndList","1.0")]
		public static void EndList()
			=> throw new NotImplementedException();
		
		[MethodImport("glEvalCoord1d","1.0")]
		public static void EvalCoord1(double u)
			=> throw new NotImplementedException();
		
		[MethodImport("glEvalCoord1dv","1.0")]
		public static void EvalCoord1(double[] u)
			=> throw new NotImplementedException();
		
		[MethodImport("glEvalCoord1f","1.0")]
		public static void EvalCoord1(float u)
			=> throw new NotImplementedException();
		
		[MethodImport("glEvalCoord1fv","1.0")]
		public static void EvalCoord1(float[] u)
			=> throw new NotImplementedException();
		
		[MethodImport("glEvalCoord2d","1.0")]
		public static void EvalCoord2(double u,double v)
			=> throw new NotImplementedException();
		
		[MethodImport("glEvalCoord2dv","1.0")]
		public static void EvalCoord2(double[] u)
			=> throw new NotImplementedException();
		
		[MethodImport("glEvalCoord2f","1.0")]
		public static void EvalCoord2(float u,float v)
			=> throw new NotImplementedException();
		
		[MethodImport("glEvalCoord2fv","1.0")]
		public static void EvalCoord2(float[] u)
			=> throw new NotImplementedException();
		
		[MethodImport("glEvalMesh1","1.0")]
		public static void EvalMesh1(uint mode,int i1,int i2)
			=> throw new NotImplementedException();
		
		[MethodImport("glEvalMesh2","1.0")]
		public static void EvalMesh2(uint mode,int i1,int i2,int j1,int j2)
			=> throw new NotImplementedException();
		
		[MethodImport("glEvalPoint1","1.0")]
		public static void EvalPoint1(int i)
			=> throw new NotImplementedException();
		
		[MethodImport("glEvalPoint2","1.0")]
		public static void EvalPoint2(int i,int j)
			=> throw new NotImplementedException();
		
		[MethodImport("glFeedbackBuffer","1.0")]
		public static void FeedbackBuffer(int size,uint type,float[] buffer)
			=> throw new NotImplementedException();
		
		[MethodImport("glFinish","1.0")]
		public static void Finish()
			=> throw new NotImplementedException();
		
		[MethodImport("glFlush","1.0")]
		public static void Flush()
			=> throw new NotImplementedException();
		
		[MethodImport("glFogf","1.0")]
		public static void Fog(uint pName,float param)
			=> throw new NotImplementedException();
		
		[MethodImport("glFogfv","1.0")]
		public static void Fog(uint pName,float[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glFogi","1.0")]
		public static void Fog(uint pName,int param)
			=> throw new NotImplementedException();
		
		[MethodImport("glFogiv","1.0")]
		public static void Fog(uint pName,int[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glFrontFace","1.0")]
		public static void FrontFace(uint mode)
			=> throw new NotImplementedException();
		
		[MethodImport("glFrustum","1.0")]
		public static void Frustum(double left,double right,double bottom,double top,double zNear,double zFar)
			=> throw new NotImplementedException();
		
		[MethodImport("glGenLists","1.0")]
		public static uint GenLists(int range)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetBooleanv","1.0")]
		public static void GetBoolean(uint pName,IntPtr parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetClipPlane","1.0")]
		public static void GetClipPlane(uint plane,double[] equation)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetDoublev","1.0")]
		public static void GetDouble(uint pName,double[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetError","1.0")]
		public static GraphicsError GetError()
			=> throw new NotImplementedException();
		
		[MethodImport("glGetFloatv","1.0")]
		public static void GetFloat(uint pName,float[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetIntegerv","1.0")]
		public static void GetInteger(uint pName,int[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetLightfv","1.0")]
		public static void GetLight(uint light,uint pName,float[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetLightiv","1.0")]
		public static void GetLight(uint light,uint pName,int[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetMapdv","1.0")]
		public static void GetMap(uint target,uint query,double[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetMapfv","1.0")]
		public static void GetMap(uint target,uint query,float[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetMapiv","1.0")]
		public static void GetMap(uint target,uint query,int[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetMaterialfv","1.0")]
		public static void GetMaterial(uint face,uint pName,float[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetMaterialiv","1.0")]
		public static void GetMaterial(uint face,uint pName,int[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetPixelMapfv","1.0")]
		public static void GetPixelMap(uint map,float[] values)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetPixelMapuiv","1.0")]
		public static void GetPixelMap(uint map,uint[] values)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetPixelMapusv","1.0")]
		public static void GetPixelMap(uint map,ushort[] values)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetPointerv","1.0")]
		public static void GetPointer(uint pName,ref IntPtr parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetPolygonStipple","1.0")]
		public static void GetPolygonStipple(IntPtr mask)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetTexEnvfv","1.0")]
		public static void GetTexEnv(TextureEnvTarget target,uint pName,float[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetTexEnviv","1.0")]
		public static void GetTexEnv(TextureEnvTarget target,uint pName,int[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetTexGendv","1.0")]
		public static void GetTexGen(uint coord,uint pName,double[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetTexGenfv","1.0")]
		public static void GetTexGen(uint coord,uint pName,float[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetTexGeniv","1.0")]
		public static void GetTexGen(uint coord,uint pName,int[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetTexImage","1.0")]
		public static void GetTexImage(TextureTarget target,int level,PixelFormat format,PixelType type,IntPtr pixels)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetTexLevelParameterfv","1.0")]
		public static void GetTexLevelParameter(TextureTarget target,int level,uint pName,float[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetTexLevelParameteriv","1.0")]
		public static void GetTexLevelParameter(TextureTarget target,int level,uint pName,int[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetTexParameterfv","1.0")]
		public static void GetTexParameter(TextureTarget target,GetTextureParameter parameterName,float[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glGetTexParameteriv","1.0")]
		public static void GetTexParameter(TextureTarget target,GetTextureParameter parameterName,int[] parameters)
			=> throw new NotImplementedException();

		[MethodImport("glGenTextures","1.0")]
		public unsafe static void GenTextures(int numTextures,[Out] uint* textures)
			=> throw new NotImplementedException();

		[MethodImport("glDeleteTextures","1.0")]
		public unsafe static void DeleteTextures(int numTextures,[Out] uint* textures)
			=> throw new NotImplementedException();

		[MethodImport("glHint","1.0")]
		public static void Hint(uint target,uint mode)
			=> throw new NotImplementedException();
		
		[MethodImport("glIndexMask","1.0")]
		public static void IndexMask(uint mask)
			=> throw new NotImplementedException();
		
		[MethodImport("glIndexPointer","1.0")]
		public static void IndexPointer(uint type,int stride,IntPtr pointer)
			=> throw new NotImplementedException();
		
		[MethodImport("glIndexd","1.0")]
		public static void Index(double c)
			=> throw new NotImplementedException();
		
		[MethodImport("glIndexdv","1.0")]
		public static void Index(double[] c)
			=> throw new NotImplementedException();
		
		[MethodImport("glIndexf","1.0")]
		public static void Index(float c)
			=> throw new NotImplementedException();
		
		[MethodImport("glIndexfv","1.0")]
		public static void Index(float[] c)
			=> throw new NotImplementedException();
		
		[MethodImport("glIndexi","1.0")]
		public static void Index(int c)
			=> throw new NotImplementedException();
		
		[MethodImport("glIndexiv","1.0")]
		public static void Index(int[] c)
			=> throw new NotImplementedException();
		
		[MethodImport("glIndexs","1.0")]
		public static void Index(short c)
			=> throw new NotImplementedException();
		
		[MethodImport("glIndexsv","1.0")]
		public static void Index(short[] c)
			=> throw new NotImplementedException();
		
		[MethodImport("glIndexub","1.0")]
		public static void Index(byte c)
			=> throw new NotImplementedException();
		
		[MethodImport("glIndexubv","1.0")]
		public static void Index(IntPtr c)
			=> throw new NotImplementedException();
		
		[MethodImport("glInitNames","1.0")]
		public static void InitNames()
			=> throw new NotImplementedException();
		
		[MethodImport("glInterleavedArrays","1.0")]
		public static void InterleavedArrays(uint format,int stride,IntPtr pointer)
			=> throw new NotImplementedException();
		
		[MethodImport("glIsEnabled","1.0")]
		public static byte IsEnabled(EnableCap cap)
			=> throw new NotImplementedException();
		
		[MethodImport("glIsList","1.0")]
		public static byte IsList(uint list)
			=> throw new NotImplementedException();
		
		[MethodImport("glIsTexture","1.0")]
		public static byte IsTexture(uint texture)
			=> throw new NotImplementedException();
		
		[MethodImport("glLightModelf","1.0")]
		public static void LightMode(uint pName,float param)
			=> throw new NotImplementedException();
		
		[MethodImport("glLightModelfv","1.0")]
		public static void LightMode(uint pName,float[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glLightModeli","1.0")]
		public static void LightMode(uint pName,int param)
			=> throw new NotImplementedException();
		
		[MethodImport("glLightModeliv","1.0")]
		public static void LightMode(uint pName,int[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glLightf","1.0")]
		public static void Light(uint light,uint pName,float param)
			=> throw new NotImplementedException();
		
		[MethodImport("glLightfv","1.0")]
		public static void Light(uint light,uint pName,float[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glLighti","1.0")]
		public static void Light(uint light,uint pName,int param)
			=> throw new NotImplementedException();
		
		[MethodImport("glLightiv","1.0")]
		public static void Light(uint light,uint pName,int[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glLineStipple","1.0")]
		public static void LineStipple(int factor,ushort pattern)
			=> throw new NotImplementedException();
		
		[MethodImport("glLineWidth","1.0")]
		public static void LineWidth(float width)
			=> throw new NotImplementedException();
		
		[MethodImport("glListBase","1.0")]
		public static void ListBase(uint b)
			=> throw new NotImplementedException();
		
		[MethodImport("glLoadIdentity","1.0")]
		public static void LoadIdentity()
			=> throw new NotImplementedException();
		
		[MethodImport("glLoadMatrixd","1.0")]
		public static void LoadMatrix(double[] m)
			=> throw new NotImplementedException();
		
		[MethodImport("glLoadMatrixf","1.0")]
		public static void LoadMatrix(float[] m)
			=> throw new NotImplementedException();
		
		[MethodImport("glLoadName","1.0")]
		public static void LoadName(uint name)
			=> throw new NotImplementedException();
		
		[MethodImport("glLogicOp","1.0")]
		public static void LogicOp(uint opcode)
			=> throw new NotImplementedException();
		
		[MethodImport("glMap1d","1.0")]
		public static void Map1(uint target,double u1,double u2,int stride,int order,double[] points)
			=> throw new NotImplementedException();
		
		[MethodImport("glMap1f","1.0")]
		public static void Map1(uint target,float u1,float u2,int stride,int order,float[] points)
			=> throw new NotImplementedException();
		
		[MethodImport("glMap2d","1.0")]
		public static void Map2(uint target,double u1,double u2,int ustride,int uorder,double v1,double v2,int vstride,int vorder,double[] points)
			=> throw new NotImplementedException();
		
		[MethodImport("glMap2f","1.0")]
		public static void Map2(uint target,float u1,float u2,int ustride,int uorder,float v1,float v2,int vstride,int vorder,float[] points)
			=> throw new NotImplementedException();
		
		[MethodImport("glMapGrid1d","1.0")]
		public static void MapGrid1(int un,double u1,double u2)
			=> throw new NotImplementedException();
		
		[MethodImport("glMapGrid1f","1.0")]
		public static void MapGrid1(int un,float u1,float u2)
			=> throw new NotImplementedException();
		
		[MethodImport("glMapGrid2d","1.0")]
		public static void MapGrid2(int un,double u1,double u2,int vn,double v1,double v2)
			=> throw new NotImplementedException();
		
		[MethodImport("glMapGrid2f","1.0")]
		public static void MapGrid2(int un,float u1,float u2,int vn,float v1,float v2)
			=> throw new NotImplementedException();
		
		[MethodImport("glMaterialf","1.0")]
		public static void Material(uint face,uint pName,float param)
			=> throw new NotImplementedException();
		
		[MethodImport("glMaterialfv","1.0")]
		public static void Material(uint face,uint pName,float[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glMateriali","1.0")]
		public static void Material(uint face,uint pName,int param)
			=> throw new NotImplementedException();
		
		[MethodImport("glMaterialiv","1.0")]
		public static void Material(uint face,uint pName,int[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glMatrixMode","1.0")]
		public static void MatrixMode(uint mode)
			=> throw new NotImplementedException();
		
		[MethodImport("glMultMatrixd","1.0")]
		public static void MultMatrix(double[] m)
			=> throw new NotImplementedException();
		
		[MethodImport("glMultMatrixf","1.0")]
		public static void MultMatrix(float[] m)
			=> throw new NotImplementedException();
		
		[MethodImport("glNewList","1.0")]
		public static void NewList(uint list,uint mode)
			=> throw new NotImplementedException();
		
		[MethodImport("glNormal3b","1.0")]
		public static void Normal3(sbyte nx,sbyte ny,sbyte nz)
			=> throw new NotImplementedException();
		
		[MethodImport("glNormal3bv","1.0")]
		public static void Normal3(IntPtr v)
			=> throw new NotImplementedException();
		
		[MethodImport("glNormal3d","1.0")]
		public static void Normal3(double nx,double ny,double nz)
			=> throw new NotImplementedException();
		
		[MethodImport("glNormal3dv","1.0")]
		public static void Normal3(double[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glNormal3f","1.0")]
		public static void Normal3(float nx,float ny,float nz)
			=> throw new NotImplementedException();
		
		[MethodImport("glNormal3fv","1.0")]
		public static void Normal3(float[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glNormal3i","1.0")]
		public static void Normal3(int nx,int ny,int nz)
			=> throw new NotImplementedException();
		
		[MethodImport("glNormal3iv","1.0")]
		public static void Normal3(int[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glNormal3s","1.0")]
		public static void Normal3(short nx,short ny,short nz)
			=> throw new NotImplementedException();
		
		[MethodImport("glNormal3sv","1.0")]
		public static void Normal3(short[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glNormalPointer","1.0")]
		public static void NormalPointer(uint type,int stride,IntPtr pointer)
			=> throw new NotImplementedException();
		
		[MethodImport("glOrtho","1.0")]
		public static void Ortho(double left,double right,double bottom,double top,double zNear,double zFar)
			=> throw new NotImplementedException();
		
		[MethodImport("glPassThrough","1.0")]
		public static void PassThrough(float token)
			=> throw new NotImplementedException();
		
		[MethodImport("glPixelMapfv","1.0")]
		public static void PixelMap(uint map,int mapSize,float[] values)
			=> throw new NotImplementedException();
		
		[MethodImport("glPixelMapuiv","1.0")]
		public static void PixelMap(uint map,int mapSize,uint[] values)
			=> throw new NotImplementedException();
		
		[MethodImport("glPixelMapusv","1.0")]
		public static void PixelMap(uint map,int mapSize,ushort[] values)
			=> throw new NotImplementedException();
		
		[MethodImport("glPixelStoref","1.0")]
		public static void PixelStore(uint pName,float param)
			=> throw new NotImplementedException();
		
		[MethodImport("glPixelStorei","1.0")]
		public static void PixelStore(uint pName,int param)
			=> throw new NotImplementedException();
		
		[MethodImport("glPixelTransferf","1.0")]
		public static void PixelTransfer(uint pName,float param)
			=> throw new NotImplementedException();
		
		[MethodImport("glPixelTransferi","1.0")]
		public static void PixelTransfer(uint pName,int param)
			=> throw new NotImplementedException();
		
		[MethodImport("glPixelZoom","1.0")]
		public static void PixelZoom(float xFactor,float yFactor)
			=> throw new NotImplementedException();
		
		[MethodImport("glPointSize","1.0")]
		public static void PointSize(float size)
			=> throw new NotImplementedException();
		
		[MethodImport("glPolygonMode","1.0")]
		public static void PolygonMode(MaterialFace face,PolygonMode mode)
			=> throw new NotImplementedException();
		
		[MethodImport("glPolygonOffset","1.0")]
		public static void PolygonOffset(float factor,float units)
			=> throw new NotImplementedException();
		
		[MethodImport("glPolygonStipple","1.0")]
		public static void PolygonStipple(IntPtr mask)
			=> throw new NotImplementedException();
		
		[MethodImport("glPopAttrib","1.0")]
		public static void PopAttrib()
			=> throw new NotImplementedException();
		
		[MethodImport("glPopClientAttrib","1.0")]
		public static void PopClientAttrib()
			=> throw new NotImplementedException();
		
		[MethodImport("glPopMatrix","1.0")]
		public static void PopMatrix()
			=> throw new NotImplementedException();
		
		[MethodImport("glPopName","1.0")]
		public static void PopName()
			=> throw new NotImplementedException();
		
		[MethodImport("glPrioritizeTextures","1.0")]
		public static void PrioritizeTextures(int n,uint[] textures,float[] priorities)
			=> throw new NotImplementedException();
		
		[MethodImport("glPushAttrib","1.0")]
		public static void PushAttrib(uint mask)
			=> throw new NotImplementedException();
		
		[MethodImport("glPushClientAttrib","1.0")]
		public static void PushClientAttrib(uint mask)
			=> throw new NotImplementedException();
		
		[MethodImport("glPushMatrix","1.0")]
		public static void PushMatrix()
			=> throw new NotImplementedException();
		
		[MethodImport("glPushName","1.0")]
		public static void PushName(uint name)
			=> throw new NotImplementedException();
		
		[MethodImport("glRasterPos2d","1.0")]
		public static void RasterPos2(double x,double y)
			=> throw new NotImplementedException();
		
		[MethodImport("glRasterPos2dv","1.0")]
		public static void RasterPos2(double[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glRasterPos2f","1.0")]
		public static void RasterPos2(float x,float y)
			=> throw new NotImplementedException();
		
		[MethodImport("glRasterPos2fv","1.0")]
		public static void RasterPos2(float[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glRasterPos2i","1.0")]
		public static void RasterPos2(int x,int y)
			=> throw new NotImplementedException();
		
		[MethodImport("glRasterPos2iv","1.0")]
		public static void RasterPos2(int[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glRasterPos2s","1.0")]
		public static void RasterPos2(short x,short y)
			=> throw new NotImplementedException();
		
		[MethodImport("glRasterPos2sv","1.0")]
		public static void RasterPos2(short[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glRasterPos3d","1.0")]
		public static void RasterPos3(double x,double y,double z)
			=> throw new NotImplementedException();
		
		[MethodImport("glRasterPos3dv","1.0")]
		public static void RasterPos3(double[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glRasterPos3f","1.0")]
		public static void RasterPos3(float x,float y,float z)
			=> throw new NotImplementedException();
		
		[MethodImport("glRasterPos3fv","1.0")]
		public static void RasterPos3(float[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glRasterPos3i","1.0")]
		public static void RasterPos3(int x,int y,int z)
			=> throw new NotImplementedException();
		
		[MethodImport("glRasterPos3iv","1.0")]
		public static void RasterPos3(int[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glRasterPos3s","1.0")]
		public static void RasterPos3(short x,short y,short z)
			=> throw new NotImplementedException();
		
		[MethodImport("glRasterPos3sv","1.0")]
		public static void RasterPos3(short[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glRasterPos4d","1.0")]
		public static void RasterPos4(double x,double y,double z,double w)
			=> throw new NotImplementedException();
		
		[MethodImport("glRasterPos4dv","1.0")]
		public static void RasterPos4(double[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glRasterPos4f","1.0")]
		public static void RasterPos4(float x,float y,float z,float w)
			=> throw new NotImplementedException();
		
		[MethodImport("glRasterPos4fv","1.0")]
		public static void RasterPos4(float[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glRasterPos4i","1.0")]
		public static void RasterPos4(int x,int y,int z,int w)
			=> throw new NotImplementedException();
		
		[MethodImport("glRasterPos4iv","1.0")]
		public static void RasterPos4(int[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glRasterPos4s","1.0")]
		public static void RasterPos4(short x,short y,short z,short w)
			=> throw new NotImplementedException();
		
		[MethodImport("glRasterPos4sv","1.0")]
		public static void RasterPos4(short[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glReadBuffer","1.0")]
		public static void ReadBuffer(ReadBufferMode mode)
			=> throw new NotImplementedException();
		
		[MethodImport("glReadPixels","1.0")]
		public static void ReadPixels(int x,int y,int width,int height,PixelFormat format,PixelType type,IntPtr pixels)
			=> throw new NotImplementedException();
		
		[MethodImport("glRectd","1.0")]
		public static void Rect(double x1,double y1,double x2,double y2)
			=> throw new NotImplementedException();
		
		[MethodImport("glRectdv","1.0")]
		public static void Rect(double[] v1,double[] v2)
			=> throw new NotImplementedException();
		
		[MethodImport("glRectf","1.0")]
		public static void Rect(float x1,float y1,float x2,float y2)
			=> throw new NotImplementedException();
		
		[MethodImport("glRectfv","1.0")]
		public static void Rect(float[] v1,float[] v2)
			=> throw new NotImplementedException();
		
		[MethodImport("glRecti","1.0")]
		public static void Rect(int x1,int y1,int x2,int y2)
			=> throw new NotImplementedException();
		
		[MethodImport("glRectiv","1.0")]
		public static void Rect(int[] v1,int[] v2)
			=> throw new NotImplementedException();
		
		[MethodImport("glRects","1.0")]
		public static void Rect(short x1,short y1,short x2,short y2)
			=> throw new NotImplementedException();
		
		[MethodImport("glRectsv","1.0")]
		public static void Rect(short[] v1,short[] v2)
			=> throw new NotImplementedException();
		
		[MethodImport("glRenderMode","1.0")]
		public static int RenderMode(uint mode)
			=> throw new NotImplementedException();
		
		[MethodImport("glRotated","1.0")]
		public static void Rotate(double angle,double x,double y,double z)
			=> throw new NotImplementedException();
		
		[MethodImport("glRotatef","1.0")]
		public static void Rotate(float angle,float x,float y,float z)
			=> throw new NotImplementedException();
		
		[MethodImport("glScaled","1.0")]
		public static void Scale(double x,double y,double z)
			=> throw new NotImplementedException();
		
		[MethodImport("glScalef","1.0")]
		public static void Scale(float x,float y,float z)
			=> throw new NotImplementedException();
		
		[MethodImport("glScissor","1.0")]
		public static void Scissor(int x,int y,int width,int height)
			=> throw new NotImplementedException();
		
		[MethodImport("glSelectBuffer","1.0")]
		public static void SelectBuffer(int size,uint[] buffer)
			=> throw new NotImplementedException();
		
		[MethodImport("glShadeModel","1.0")]
		public static void ShadeModel(uint mode)
			=> throw new NotImplementedException();
		
		[MethodImport("glStencilFunc","1.0")]
		public static void StencilFunc(uint func,int refer,uint mask)
			=> throw new NotImplementedException();
		
		[MethodImport("glStencilMask","1.0")]
		public static void StencilMask(uint mask)
			=> throw new NotImplementedException();
		
		[MethodImport("glStencilOp","1.0")]
		public static void StencilOp(uint fail,uint zfail,uint zpass)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord1d","1.0")]
		public static void TexCoord1(double s)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord1dv","1.0")]
		public static void TexCoord1(double[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord1f","1.0")]
		public static void TexCoord1(float s)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord1fv","1.0")]
		public static void TexCoord1(float[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord1i","1.0")]
		public static void TexCoord1(int s)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord1iv","1.0")]
		public static void TexCoord1(int[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord1s","1.0")]
		public static void TexCoord1(short s)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord1sv","1.0")]
		public static void TexCoord1(short[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord2d","1.0")]
		public static void TexCoord2(double s,double t)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord2dv","1.0")]
		public static void TexCoord2(double[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord2f","1.0")]
		public static void TexCoord2(float s,float t)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord2fv","1.0")]
		public static void TexCoord2(float[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord2i","1.0")]
		public static void TexCoord2(int s,int t)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord2iv","1.0")]
		public static void TexCoord2(int[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord2s","1.0")]
		public static void TexCoord2(short s,short t)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord2sv","1.0")]
		public static void TexCoord2(short[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord3d","1.0")]
		public static void TexCoord3(double s,double t,double r)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord3dv","1.0")]
		public static void TexCoord3(double[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord3f","1.0")]
		public static void TexCoord3(float s,float t,float r)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord3fv","1.0")]
		public static void TexCoord3(float[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord3i","1.0")]
		public static void TexCoord3(int s,int t,int r)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord3iv","1.0")]
		public static void TexCoord3(int[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord3s","1.0")]
		public static void TexCoord3(short s,short t,short r)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord3sv","1.0")]
		public static void TexCoord3(short[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord4d","1.0")]
		public static void TexCoord4(double s,double t,double r,double q)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord4dv","1.0")]
		public static void TexCoord4(double[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord4f","1.0")]
		public static void TexCoord4(float s,float t,float r,float q)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord4fv","1.0")]
		public static void TexCoord4(float[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord4i","1.0")]
		public static void TexCoord4(int s,int t,int r,int q)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord4iv","1.0")]
		public static void TexCoord4(int[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord4s","1.0")]
		public static void TexCoord4(short s,short t,short r,short q)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoord4sv","1.0")]
		public static void TexCoord4(short[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexCoordPointer","1.0")]
		public static void TexCoordPointer(int size,uint type,int stride,IntPtr pointer)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexEnvf","1.0")]
		public static void TexEnv(TextureEnvTarget target,uint pName,float param)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexEnvfv","1.0")]
		public static void TexEnv(TextureEnvTarget target,uint pName,float[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexEnvi","1.0")]
		public static void TexEnv(TextureEnvTarget target,uint pName,int param)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexEnviv","1.0")]
		public static void TexEnv(TextureEnvTarget target,uint pName,int[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexGend","1.0")]
		public static void TexGen(uint coord,uint pName,double param)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexGendv","1.0")]
		public static void TexGen(uint coord,uint pName,double[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexGenf","1.0")]
		public static void TexGen(uint coord,uint pName,float param)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexGenfv","1.0")]
		public static void TexGen(uint coord,uint pName,float[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexGeni","1.0")]
		public static void TexGen(uint coord,uint pName,int param)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexGeniv","1.0")]
		public static void TexGen(uint coord,uint pName,int[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexImage1D","1.0")]
		public static void TexImage1D(TextureTarget target,int level,PixelInternalFormat internalFormat,int width,int border,PixelFormat format,PixelType type,IntPtr pixels)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexImage2D","1.0")]
		public static void TexImage2D(TextureTarget target,int level,PixelInternalFormat internalFormat,int width,int height,int border,PixelFormat format,PixelType type,IntPtr pixels)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexParameterf","1.0")]
		public static void TexParameter(TextureTarget target,TextureParameterName parameterName,float param)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexParameterfv","1.0")]
		public static void TexParameter(TextureTarget target,TextureParameterName parameterName,float[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexParameteri","1.0")]
		public static void TexParameter(TextureTarget target,TextureParameterName parameterName,int param)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexParameteriv","1.0")]
		public static void TexParameter(TextureTarget target,TextureParameterName parameterName,int[] parameters)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexSubImage1D","1.0")]
		public static void TexSubImage1D(TextureTarget target,int level,int xOffset,int width,PixelFormat format,PixelType type,IntPtr pixels)
			=> throw new NotImplementedException();
		
		[MethodImport("glTexSubImage2D","1.0")]
		public static void TexSubImage2D(TextureTarget target,int level,int xOffset,int yOffset,int width,int height,PixelFormat format,PixelType type,IntPtr pixels)
			=> throw new NotImplementedException();
		
		[MethodImport("glTranslated","1.0")]
		public static void Translate(double x,double y,double z)
			=> throw new NotImplementedException();
		
		[MethodImport("glTranslatef","1.0")]
		public static void Translate(float x,float y,float z)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertex2d","1.0")]
		public static void Vertex2(double x,double y)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertex2dv","1.0")]
		public static void Vertex2(double[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertex2f","1.0")]
		public static void Vertex2(float x,float y)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertex2fv","1.0")]
		public static void Vertex2(float[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertex2i","1.0")]
		public static void Vertex2(int x,int y)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertex2iv","1.0")]
		public static void Vertex2(int[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertex2s","1.0")]
		public static void Vertex2(short x,short y)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertex2sv","1.0")]
		public static void Vertex2(short[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertex3d","1.0")]
		public static void Vertex3(double x,double y,double z)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertex3dv","1.0")]
		public static void Vertex3(double[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertex3f","1.0")]
		public static void Vertex3(float x,float y,float z)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertex3fv","1.0")]
		public static void Vertex3(float[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertex3i","1.0")]
		public static void Vertex3(int x,int y,int z)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertex3iv","1.0")]
		public static void Vertex3(int[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertex3s","1.0")]
		public static void Vertex3(short x,short y,short z)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertex3sv","1.0")]
		public static void Vertex3(short[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertex4d","1.0")]
		public static void Vertex4(double x,double y,double z,double w)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertex4dv","1.0")]
		public static void Vertex4(double[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertex4f","1.0")]
		public static void Vertex4(float x,float y,float z,float w)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertex4fv","1.0")]
		public static void Vertex4(float[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertex4i","1.0")]
		public static void Vertex4(int x,int y,int z,int w)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertex4iv","1.0")]
		public static void Vertex4(int[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertex4s","1.0")]
		public static void Vertex4(short x,short y,short z,short w)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertex4sv","1.0")]
		public static void Vertex4(short[] v)
			=> throw new NotImplementedException();
		
		[MethodImport("glVertexPointer","1.0")]
		public static void VertexPointer(int size,uint type,int stride,IntPtr pointer)
			=> throw new NotImplementedException();
		
		[MethodImport("glViewport","1.0")]
		public static void Viewport(int x,int y,int width,int height)
			=> throw new NotImplementedException();

		//Internal functions. Used in GL.X.Helpers.cs

		[MethodImport("glGetString","1.0")]
		private static IntPtr GetStringInternal(StringName name)
			=> throw new NotImplementedException();
	}
}