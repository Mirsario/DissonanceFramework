using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[MethodImpl(ImplOptions)]
		public unsafe static void Accum(uint op,float value)
			=> glAccum(op,value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void AlphaFunc(uint func,float alpha)
			=> glAlphaFunc(func,alpha);
		
		[MethodImpl(ImplOptions)]
		public unsafe static byte AreTexturesResident(int n,uint[] textures,IntPtr residences)
			=> glAreTexturesResident(n,textures,residences);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ArrayElement(int i)
			=> glArrayElement(i);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Begin(PrimitiveType mode)
			=> glBegin(mode);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void BindTexture(TextureTarget target,uint texture)
			=> glBindTexture(target,texture);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Bitmap(int width,int height,float xOrig,float yOrig,float xMove,float yMove,IntPtr bitmap)
			=> glBitmap(width,height,xOrig,yOrig,xMove,yMove,bitmap);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void BlendFunc(BlendingFactor sfactor,BlendingFactor dfactor)
			=> glBlendFunc(sfactor,dfactor);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void CallList(uint list)
			=> glCallList(list);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void CallLists(int n,uint type,IntPtr lists)
			=> glCallLists(n,type,lists);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Clear(ClearBufferMask mask)
			=> glClear(mask);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ClearAccum(float red,float green,float blue,float alpha = 1f)
			=> glClearAccum(red,green,blue,alpha);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ClearColor(float red,float green,float blue,float alpha = 1f)
			=> glClearColor(red,green,blue,alpha);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ClearDepth(double depth)
			=> glClearDepth(depth);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ClearIndex(float c)
			=> glClearIndex(c);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ClearStencil(int s)
			=> glClearStencil(s);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ClipPlane(uint plane,double[] equation)
			=> glClipPlane(plane,equation);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Color3(sbyte red,sbyte green,sbyte blue)
			=> glColor3b(red,green,blue);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Color3(sbyte[] v)
			=> glColor3bv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Color3(double red,double green,double blue)
			=> glColor3d(red,green,blue);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Color3(double[] v)
			=> glColor3dv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Color3(float red,float green,float blue)
			=> glColor3f(red,green,blue);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Color3(float[] v)
			=> glColor3fv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Color3(int red,int green,int blue)
			=> glColor3i(red,green,blue);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Color3(int[] v)
			=> glColor3iv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Color3(short red,short green,short blue)
			=> glColor3s(red,green,blue);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Color3(short[] v)
			=> glColor3sv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Color3(byte red,byte green,byte blue)
			=> glColor3ub(red,green,blue);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Color3(byte[] v)
			=> glColor3ubv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Color3(uint red,uint green,uint blue)
			=> glColor3ui(red,green,blue);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Color3(uint[] v)
			=> glColor3uiv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Color3(ushort red,ushort green,ushort blue)
			=> glColor3us(red,green,blue);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Color3(ushort[] v)
			=> glColor3usv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Color4(sbyte red,sbyte green,sbyte blue,sbyte alpha)
			=> glColor4b(red,green,blue,alpha);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Color4(sbyte[] v)
			=> glColor4bv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Color4(double red,double green,double blue,double alpha)
			=> glColor4d(red,green,blue,alpha);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Color4(double[] v)
			=> glColor4dv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Color4(float red,float green,float blue,float alpha)
			=> glColor4f(red,green,blue,alpha);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Color4(float[] v)
			=> glColor4fv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Color4(int red,int green,int blue,int alpha)
			=> glColor4i(red,green,blue,alpha);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Color4(int[] v)
			=> glColor4iv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Color4(short red,short green,short blue,short alpha)
			=> glColor4s(red,green,blue,alpha);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Color4(short[] v)
			=> glColor4sv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Color4(byte red,byte green,byte blue,byte alpha)
			=> glColor4ub(red,green,blue,alpha);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Color4(byte[] v)
			=> glColor4ubv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Color4(uint red,uint green,uint blue,uint alpha)
			=> glColor4ui(red,green,blue,alpha);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Color4(uint[] v)
			=> glColor4uiv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Color4(ushort red,ushort green,ushort blue,ushort alpha)
			=> glColor4us(red,green,blue,alpha);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Color4(ushort[] v)
			=> glColor4usv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ColorMask(byte red,byte green,byte blue,byte alpha)
			=> glColorMask(red,green,blue,alpha);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ColorMaterial(uint face,uint mode)
			=> glColorMaterial(face,mode);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ColorPointer(int size,uint type,int stride,IntPtr pointer)
			=> glColorPointer(size,type,stride,pointer);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void CopyPixels(int x,int y,int width,int height,uint type)
			=> glCopyPixels(x,y,width,height,type);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void CopyTexImage1D(TextureTarget target,int level,uint internalFormat,int x,int y,int width,int border)
			=> glCopyTexImage1D(target,level,internalFormat,x,y,width,border);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void CopyTexImage2D(TextureTarget target,int level,uint internalFormat,int x,int y,int width,int height,int border)
			=> glCopyTexImage2D(target,level,internalFormat,x,y,width,height,border);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void CopyTexSubImage1D(TextureTarget target,int level,int xOffset,int x,int y,int width)
			=> glCopyTexSubImage1D(target,level,xOffset,x,y,width);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void CopyTexSubImage2D(TextureTarget target,int level,int xOffset,int yOffset,int x,int y,int width,int height)
			=> glCopyTexSubImage2D(target,level,xOffset,yOffset,x,y,width,height);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void CullFace(CullFaceMode mode)
			=> glCullFace(mode);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void DeleteLists(uint list,int range)
			=> glDeleteLists(list,range);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void DepthFunc(DepthFunction func)
			=> glDepthFunc(func);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void DepthMask(bool flag)
			=> glDepthMask(flag);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void DepthRange(double zNear,double zFar)
			=> glDepthRange(zNear,zFar);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Disable(EnableCap cap)
			=> glDisable(cap);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void DisableClientState(uint capability)
			=> glDisableClientState(capability);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void DrawArrays(PrimitiveType mode,int first,int count)
			=> glDrawArrays(mode,first,count);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void DrawBuffer(DrawBufferMode mode)
			=> glDrawBuffer(mode);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void DrawElements(PrimitiveType mode,int count,DrawElementsType type,IntPtr indices)
			=> glDrawElements(mode,count,type,indices);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void DrawPixels(int width,int height,PixelFormat format,PixelType type,IntPtr pixels)
			=> glDrawPixels(width,height,format,type,pixels);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void EdgeFlag(byte flag)
			=> glEdgeFlag(flag);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void EdgeFlagPointer(int stride,IntPtr pointer)
			=> glEdgeFlagPointer(stride,pointer);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void EdgeFlag(IntPtr flag)
			=> glEdgeFlagv(flag);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Enable(EnableCap cap)
			=> glEnable(cap);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void EnableClientState(uint capability)
			=> glEnableClientState(capability);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void End()
			=> glEnd();
		
		[MethodImpl(ImplOptions)]
		public unsafe static void EndList()
			=> glEndList();
		
		[MethodImpl(ImplOptions)]
		public unsafe static void EvalCoord1(double u)
			=> glEvalCoord1d(u);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void EvalCoord1(double[] u)
			=> glEvalCoord1dv(u);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void EvalCoord1(float u)
			=> glEvalCoord1f(u);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void EvalCoord1(float[] u)
			=> glEvalCoord1fv(u);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void EvalCoord2(double u,double v)
			=> glEvalCoord2d(u,v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void EvalCoord2(double[] u)
			=> glEvalCoord2dv(u);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void EvalCoord2(float u,float v)
			=> glEvalCoord2f(u,v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void EvalCoord2(float[] u)
			=> glEvalCoord2fv(u);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void EvalMesh1(uint mode,int i1,int i2)
			=> glEvalMesh1(mode,i1,i2);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void EvalMesh2(uint mode,int i1,int i2,int j1,int j2)
			=> glEvalMesh2(mode,i1,i2,j1,j2);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void EvalPoint1(int i)
			=> glEvalPoint1(i);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void EvalPoint2(int i,int j)
			=> glEvalPoint2(i,j);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void FeedbackBuffer(int size,uint type,float[] buffer)
			=> glFeedbackBuffer(size,type,buffer);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Finish()
			=> glFinish();
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Flush()
			=> glFlush();
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Fog(uint pName,float param)
			=> glFogf(pName,param);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Fog(uint pName,float[] parameters)
			=> glFogfv(pName,parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Fog(uint pName,int param)
			=> glFogi(pName,param);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Fog(uint pName,int[] parameters)
			=> glFogiv(pName,parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void FrontFace(uint mode)
			=> glFrontFace(mode);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Frustum(double left,double right,double bottom,double top,double zNear,double zFar)
			=> glFrustum(left,right,bottom,top,zNear,zFar);
		
		[MethodImpl(ImplOptions)]
		public unsafe static uint GenLists(int range)
			=> glGenLists(range);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetBoolean(uint pName,IntPtr parameters)
			=> glGetBooleanv(pName,parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetClipPlane(uint plane,double[] equation)
			=> glGetClipPlane(plane,equation);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetDouble(uint pName,double[] parameters)
			=> glGetDoublev(pName,parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static GraphicsError GetError()
			=> glGetError();
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetFloat(uint pName,float[] parameters)
			=> glGetFloatv(pName,parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetInteger(uint pName,int[] parameters)
			=> glGetIntegerv(pName,parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetLight(uint light,uint pName,float[] parameters)
			=> glGetLightfv(light,pName,parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetLight(uint light,uint pName,int[] parameters)
			=> glGetLightiv(light,pName,parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetMap(uint target,uint query,double[] v)
			=> glGetMapdv(target,query,v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetMap(uint target,uint query,float[] v)
			=> glGetMapfv(target,query,v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetMap(uint target,uint query,int[] v)
			=> glGetMapiv(target,query,v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetMaterial(uint face,uint pName,float[] parameters)
			=> glGetMaterialfv(face,pName,parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetMaterial(uint face,uint pName,int[] parameters)
			=> glGetMaterialiv(face,pName,parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetPixelMap(uint map,float[] values)
			=> glGetPixelMapfv(map,values);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetPixelMap(uint map,uint[] values)
			=> glGetPixelMapuiv(map,values);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetPixelMap(uint map,ushort[] values)
			=> glGetPixelMapusv(map,values);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetPointer(uint pName,ref IntPtr parameters)
			=> glGetPointerv(pName,ref parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetPolygonStipple(IntPtr mask)
			=> glGetPolygonStipple(mask);
		
		[MethodImpl(ImplOptions)]
		public unsafe static IntPtr GetStringPtr(StringName name)
			=> glGetString(name);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetTexEnv(TextureEnvTarget target,uint pName,float[] parameters)
			=> glGetTexEnvfv(target,pName,parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetTexEnv(TextureEnvTarget target,uint pName,int[] parameters)
			=> glGetTexEnviv(target,pName,parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetTexGen(uint coord,uint pName,double[] parameters)
			=> glGetTexGendv(coord,pName,parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetTexGen(uint coord,uint pName,float[] parameters)
			=> glGetTexGenfv(coord,pName,parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetTexGen(uint coord,uint pName,int[] parameters)
			=> glGetTexGeniv(coord,pName,parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetTexImage(TextureTarget target,int level,PixelFormat format,PixelType type,IntPtr pixels)
			=> glGetTexImage(target,level,format,type,pixels);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetTexLevelParameter(TextureTarget target,int level,uint pName,float[] parameters)
			=> glGetTexLevelParameterfv(target,level,pName,parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetTexLevelParameter(TextureTarget target,int level,uint pName,int[] parameters)
			=> glGetTexLevelParameteriv(target,level,pName,parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetTexParameter(TextureTarget target,GetTextureParameter parameterName,float[] parameters)
			=> glGetTexParameterfv(target,parameterName,parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetTexParameter(TextureTarget target,GetTextureParameter parameterName,int[] parameters)
			=> glGetTexParameteriv(target,parameterName,parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GenTextures(int numTextures,[Out] uint* textures)
			=> glGenTextures(numTextures,textures);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void DeleteTextures(int numTextures,[Out] uint* textures)
			=> glDeleteTextures(numTextures,textures);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Hint(uint target,uint mode)
			=> glHint(target,mode);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void IndexMask(uint mask)
			=> glIndexMask(mask);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void IndexPointer(uint type,int stride,IntPtr pointer)
			=> glIndexPointer(type,stride,pointer);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Index(double c)
			=> glIndexd(c);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Index(double[] c)
			=> glIndexdv(c);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Index(float c)
			=> glIndexf(c);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Index(float[] c)
			=> glIndexfv(c);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Index(int c)
			=> glIndexi(c);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Index(int[] c)
			=> glIndexiv(c);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Index(short c)
			=> glIndexs(c);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Index(short[] c)
			=> glIndexsv(c);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Index(byte c)
			=> glIndexub(c);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Index(IntPtr c)
			=> glIndexubv(c);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void InitNames()
			=> glInitNames();
		
		[MethodImpl(ImplOptions)]
		public unsafe static void InterleavedArrays(uint format,int stride,IntPtr pointer)
			=> glInterleavedArrays(format,stride,pointer);
		
		[MethodImpl(ImplOptions)]
		public unsafe static byte IsEnabled(EnableCap cap)
			=> glIsEnabled(cap);
		
		[MethodImpl(ImplOptions)]
		public unsafe static byte IsList(uint list)
			=> glIsList(list);
		
		[MethodImpl(ImplOptions)]
		public unsafe static byte IsTexture(uint texture)
			=> glIsTexture(texture);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void LightMode(uint pName,float param)
			=> glLightModelf(pName,param);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void LightMode(uint pName,float[] parameters)
			=> glLightModelfv(pName,parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void LightMode(uint pName,int param)
			=> glLightModeli(pName,param);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void LightMode(uint pName,int[] parameters)
			=> glLightModeliv(pName,parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Light(uint light,uint pName,float param)
			=> glLightf(light,pName,param);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Light(uint light,uint pName,float[] parameters)
			=> glLightfv(light,pName,parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Light(uint light,uint pName,int param)
			=> glLighti(light,pName,param);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Light(uint light,uint pName,int[] parameters)
			=> glLightiv(light,pName,parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void LineStipple(int factor,ushort pattern)
			=> glLineStipple(factor,pattern);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void LineWidth(float width)
			=> glLineWidth(width);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ListBase(uint b)
			=> glListBase(b);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void LoadIdentity()
			=> glLoadIdentity();
		
		[MethodImpl(ImplOptions)]
		public unsafe static void LoadMatrix(double[] m)
			=> glLoadMatrixd(m);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void LoadMatrix(float[] m)
			=> glLoadMatrixf(m);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void LoadName(uint name)
			=> glLoadName(name);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void LogicOp(uint opcode)
			=> glLogicOp(opcode);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Map1(uint target,double u1,double u2,int stride,int order,double[] points)
			=> glMap1d(target,u1,u2,stride,order,points);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Map1(uint target,float u1,float u2,int stride,int order,float[] points)
			=> glMap1f(target,u1,u2,stride,order,points);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Map2(uint target,double u1,double u2,int ustride,int uorder,double v1,double v2,int vstride,int vorder,double[] points)
			=> glMap2d(target,u1,u2,ustride,uorder,v1,v2,vstride,vorder,points);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Map2(uint target,float u1,float u2,int ustride,int uorder,float v1,float v2,int vstride,int vorder,float[] points)
			=> glMap2f(target,u1,u2,ustride,uorder,v1,v2,vstride,vorder,points);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void MapGrid1(int un,double u1,double u2)
			=> glMapGrid1d(un,u1,u2);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void MapGrid1(int un,float u1,float u2)
			=> glMapGrid1f(un,u1,u2);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void MapGrid2(int un,double u1,double u2,int vn,double v1,double v2)
			=> glMapGrid2d(un,u1,u2,vn,v1,v2);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void MapGrid2(int un,float u1,float u2,int vn,float v1,float v2)
			=> glMapGrid2f(un,u1,u2,vn,v1,v2);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Material(uint face,uint pName,float param)
			=> glMaterialf(face,pName,param);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Material(uint face,uint pName,float[] parameters)
			=> glMaterialfv(face,pName,parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Material(uint face,uint pName,int param)
			=> glMateriali(face,pName,param);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Material(uint face,uint pName,int[] parameters)
			=> glMaterialiv(face,pName,parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void MatrixMode(uint mode)
			=> glMatrixMode(mode);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void MultMatrix(double[] m)
			=> glMultMatrixd(m);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void MultMatrix(float[] m)
			=> glMultMatrixf(m);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void NewList(uint list,uint mode)
			=> glNewList(list,mode);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Normal3(sbyte nx,sbyte ny,sbyte nz)
			=> glNormal3b(nx,ny,nz);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Normal3(IntPtr v)
			=> glNormal3bv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Normal3(double nx,double ny,double nz)
			=> glNormal3d(nx,ny,nz);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Normal3(double[] v)
			=> glNormal3dv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Normal3(float nx,float ny,float nz)
			=> glNormal3f(nx,ny,nz);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Normal3(float[] v)
			=> glNormal3fv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Normal3(int nx,int ny,int nz)
			=> glNormal3i(nx,ny,nz);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Normal3(int[] v)
			=> glNormal3iv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Normal3(short nx,short ny,short nz)
			=> glNormal3s(nx,ny,nz);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Normal3(short[] v)
			=> glNormal3sv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void NormalPointer(uint type,int stride,IntPtr pointer)
			=> glNormalPointer(type,stride,pointer);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Ortho(double left,double right,double bottom,double top,double zNear,double zFar)
			=> glOrtho(left,right,bottom,top,zNear,zFar);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void PassThrough(float token)
			=> glPassThrough(token);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void PixelMap(uint map,int mapSize,float[] values)
			=> glPixelMapfv(map,mapSize,values);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void PixelMap(uint map,int mapSize,uint[] values)
			=> glPixelMapuiv(map,mapSize,values);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void PixelMap(uint map,int mapSize,ushort[] values)
			=> glPixelMapusv(map,mapSize,values);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void PixelStore(uint pName,float param)
			=> glPixelStoref(pName,param);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void PixelStore(uint pName,int param)
			=> glPixelStorei(pName,param);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void PixelTransfer(uint pName,float param)
			=> glPixelTransferf(pName,param);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void PixelTransfer(uint pName,int param)
			=> glPixelTransferi(pName,param);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void PixelZoom(float xFactor,float yFactor)
			=> glPixelZoom(xFactor,yFactor);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void PointSize(float size)
			=> glPointSize(size);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void PolygonMode(MaterialFace face,PolygonMode mode)
			=> glPolygonMode(face,mode);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void PolygonOffset(float factor,float units)
			=> glPolygonOffset(factor,units);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void PolygonStipple(IntPtr mask)
			=> glPolygonStipple(mask);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void PopAttrib()
			=> glPopAttrib();
		
		[MethodImpl(ImplOptions)]
		public unsafe static void PopClientAttrib()
			=> glPopClientAttrib();
		
		[MethodImpl(ImplOptions)]
		public unsafe static void PopMatrix()
			=> glPopMatrix();
		
		[MethodImpl(ImplOptions)]
		public unsafe static void PopName()
			=> glPopName();
		
		[MethodImpl(ImplOptions)]
		public unsafe static void PrioritizeTextures(int n,uint[] textures,float[] priorities)
			=> glPrioritizeTextures(n,textures,priorities);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void PushAttrib(uint mask)
			=> glPushAttrib(mask);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void PushClientAttrib(uint mask)
			=> glPushClientAttrib(mask);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void PushMatrix()
			=> glPushMatrix();
		
		[MethodImpl(ImplOptions)]
		public unsafe static void PushName(uint name)
			=> glPushName(name);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void RasterPos2(double x,double y)
			=> glRasterPos2d(x,y);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void RasterPos2(double[] v)
			=> glRasterPos2dv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void RasterPos2(float x,float y)
			=> glRasterPos2f(x,y);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void RasterPos2(float[] v)
			=> glRasterPos2fv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void RasterPos2(int x,int y)
			=> glRasterPos2i(x,y);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void RasterPos2(int[] v)
			=> glRasterPos2iv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void RasterPos2(short x,short y)
			=> glRasterPos2s(x,y);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void RasterPos2(short[] v)
			=> glRasterPos2sv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void RasterPos3(double x,double y,double z)
			=> glRasterPos3d(x,y,z);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void RasterPos3(double[] v)
			=> glRasterPos3dv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void RasterPos3(float x,float y,float z)
			=> glRasterPos3f(x,y,z);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void RasterPos3(float[] v)
			=> glRasterPos3fv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void RasterPos3(int x,int y,int z)
			=> glRasterPos3i(x,y,z);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void RasterPos3(int[] v)
			=> glRasterPos3iv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void RasterPos3(short x,short y,short z)
			=> glRasterPos3s(x,y,z);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void RasterPos3(short[] v)
			=> glRasterPos3sv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void RasterPos4(double x,double y,double z,double w)
			=> glRasterPos4d(x,y,z,w);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void RasterPos4(double[] v)
			=> glRasterPos4dv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void RasterPos4(float x,float y,float z,float w)
			=> glRasterPos4f(x,y,z,w);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void RasterPos4(float[] v)
			=> glRasterPos4fv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void RasterPos4(int x,int y,int z,int w)
			=> glRasterPos4i(x,y,z,w);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void RasterPos4(int[] v)
			=> glRasterPos4iv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void RasterPos4(short x,short y,short z,short w)
			=> glRasterPos4s(x,y,z,w);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void RasterPos4(short[] v)
			=> glRasterPos4sv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ReadBuffer(ReadBufferMode mode)
			=> glReadBuffer(mode);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ReadPixels(int x,int y,int width,int height,PixelFormat format,PixelType type,IntPtr pixels)
			=> glReadPixels(x,y,width,height,format,type,pixels);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Rect(double x1,double y1,double x2,double y2)
			=> glRectd(x1,y1,x2,y2);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Rect(double[] v1,double[] v2)
			=> glRectdv(v1,v2);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Rect(float x1,float y1,float x2,float y2)
			=> glRectf(x1,y1,x2,y2);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Rect(float[] v1,float[] v2)
			=> glRectfv(v1,v2);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Rect(int x1,int y1,int x2,int y2)
			=> glRecti(x1,y1,x2,y2);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Rect(int[] v1,int[] v2)
			=> glRectiv(v1,v2);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Rect(short x1,short y1,short x2,short y2)
			=> glRects(x1,y1,x2,y2);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Rect(short[] v1,short[] v2)
			=> glRectsv(v1,v2);
		
		[MethodImpl(ImplOptions)]
		public unsafe static int RenderMode(uint mode)
			=> glRenderMode(mode);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Rotate(double angle,double x,double y,double z)
			=> glRotated(angle,x,y,z);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Rotate(float angle,float x,float y,float z)
			=> glRotatef(angle,x,y,z);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Scale(double x,double y,double z)
			=> glScaled(x,y,z);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Scale(float x,float y,float z)
			=> glScalef(x,y,z);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Scissor(int x,int y,int width,int height)
			=> glScissor(x,y,width,height);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void SelectBuffer(int size,uint[] buffer)
			=> glSelectBuffer(size,buffer);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ShadeModel(uint mode)
			=> glShadeModel(mode);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void StencilFunc(uint func,int refer,uint mask)
			=> glStencilFunc(func,refer,mask);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void StencilMask(uint mask)
			=> glStencilMask(mask);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void StencilOp(uint fail,uint zfail,uint zpass)
			=> glStencilOp(fail,zfail,zpass);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexCoord1(double s)
			=> glTexCoord1d(s);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexCoord1(double[] v)
			=> glTexCoord1dv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexCoord1(float s)
			=> glTexCoord1f(s);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexCoord1(float[] v)
			=> glTexCoord1fv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexCoord1(int s)
			=> glTexCoord1i(s);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexCoord1(int[] v)
			=> glTexCoord1iv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexCoord1(short s)
			=> glTexCoord1s(s);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexCoord1(short[] v)
			=> glTexCoord1sv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexCoord2(double s,double t)
			=> glTexCoord2d(s,t);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexCoord2(double[] v)
			=> glTexCoord2dv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexCoord2(float s,float t)
			=> glTexCoord2f(s,t);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexCoord2(float[] v)
			=> glTexCoord2fv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexCoord2(int s,int t)
			=> glTexCoord2i(s,t);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexCoord2(int[] v)
			=> glTexCoord2iv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexCoord2(short s,short t)
			=> glTexCoord2s(s,t);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexCoord2(short[] v)
			=> glTexCoord2sv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexCoord3(double s,double t,double r)
			=> glTexCoord3d(s,t,r);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexCoord3(double[] v)
			=> glTexCoord3dv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexCoord3(float s,float t,float r)
			=> glTexCoord3f(s,t,r);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexCoord3(float[] v)
			=> glTexCoord3fv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexCoord3(int s,int t,int r)
			=> glTexCoord3i(s,t,r);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexCoord3(int[] v)
			=> glTexCoord3iv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexCoord3(short s,short t,short r)
			=> glTexCoord3s(s,t,r);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexCoord3(short[] v)
			=> glTexCoord3sv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexCoord4(double s,double t,double r,double q)
			=> glTexCoord4d(s,t,r,q);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexCoord4(double[] v)
			=> glTexCoord4dv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexCoord4(float s,float t,float r,float q)
			=> glTexCoord4f(s,t,r,q);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexCoord4(float[] v)
			=> glTexCoord4fv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexCoord4(int s,int t,int r,int q)
			=> glTexCoord4i(s,t,r,q);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexCoord4(int[] v)
			=> glTexCoord4iv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexCoord4(short s,short t,short r,short q)
			=> glTexCoord4s(s,t,r,q);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexCoord4(short[] v)
			=> glTexCoord4sv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexCoordPointer(int size,uint type,int stride,IntPtr pointer)
			=> glTexCoordPointer(size,type,stride,pointer);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexEnv(TextureEnvTarget target,uint pName,float param)
			=> glTexEnvf(target,pName,param);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexEnv(TextureEnvTarget target,uint pName,float[] parameters)
			=> glTexEnvfv(target,pName,parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexEnv(TextureEnvTarget target,uint pName,int param)
			=> glTexEnvi(target,pName,param);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexEnv(TextureEnvTarget target,uint pName,int[] parameters)
			=> glTexEnviv(target,pName,parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexGen(uint coord,uint pName,double param)
			=> glTexGend(coord,pName,param);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexGen(uint coord,uint pName,double[] parameters)
			=> glTexGendv(coord,pName,parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexGen(uint coord,uint pName,float param)
			=> glTexGenf(coord,pName,param);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexGen(uint coord,uint pName,float[] parameters)
			=> glTexGenfv(coord,pName,parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexGen(uint coord,uint pName,int param)
			=> glTexGeni(coord,pName,param);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexGen(uint coord,uint pName,int[] parameters)
			=> glTexGeniv(coord,pName,parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexImage1D(TextureTarget target,int level,PixelInternalFormat internalFormat,int width,int border,PixelFormat format,PixelType type,IntPtr pixels)
			=> glTexImage1D(target,level,internalFormat,width,border,format,type,pixels);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexImage2D(TextureTarget target,int level,PixelInternalFormat internalFormat,int width,int height,int border,PixelFormat format,PixelType type,IntPtr pixels)
			=> glTexImage2D(target,level,internalFormat,width,height,border,format,type,pixels);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexParameter(TextureTarget target,TextureParameterName parameterName,float param)
			=> glTexParameterf(target,parameterName,param);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexParameter(TextureTarget target,TextureParameterName parameterName,float[] parameters)
			=> glTexParameterfv(target,parameterName,parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexParameter(TextureTarget target,TextureParameterName parameterName,int param)
			=> glTexParameteri(target,parameterName,param);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexParameter(TextureTarget target,TextureParameterName parameterName,int[] parameters)
			=> glTexParameteriv(target,parameterName,parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexSubImage1D(TextureTarget target,int level,int xOffset,int width,PixelFormat format,PixelType type,IntPtr pixels)
			=> glTexSubImage1D(target,level,xOffset,width,format,type,pixels);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexSubImage2D(TextureTarget target,int level,int xOffset,int yOffset,int width,int height,PixelFormat format,PixelType type,IntPtr pixels)
			=> glTexSubImage2D(target,level,xOffset,yOffset,width,height,format,type,pixels);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Translate(double x,double y,double z)
			=> glTranslated(x,y,z);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Translate(float x,float y,float z)
			=> glTranslatef(x,y,z);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Vertex2(double x,double y)
			=> glVertex2d(x,y);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Vertex2(double[] v)
			=> glVertex2dv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Vertex2(float x,float y)
			=> glVertex2f(x,y);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Vertex2(float[] v)
			=> glVertex2fv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Vertex2(int x,int y)
			=> glVertex2i(x,y);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Vertex2(int[] v)
			=> glVertex2iv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Vertex2(short x,short y)
			=> glVertex2s(x,y);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Vertex2(short[] v)
			=> glVertex2sv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Vertex3(double x,double y,double z)
			=> glVertex3d(x,y,z);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Vertex3(double[] v)
			=> glVertex3dv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Vertex3(float x,float y,float z)
			=> glVertex3f(x,y,z);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Vertex3(float[] v)
			=> glVertex3fv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Vertex3(int x,int y,int z)
			=> glVertex3i(x,y,z);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Vertex3(int[] v)
			=> glVertex3iv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Vertex3(short x,short y,short z)
			=> glVertex3s(x,y,z);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Vertex3(short[] v)
			=> glVertex3sv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Vertex4(double x,double y,double z,double w)
			=> glVertex4d(x,y,z,w);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Vertex4(double[] v)
			=> glVertex4dv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Vertex4(float x,float y,float z,float w)
			=> glVertex4f(x,y,z,w);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Vertex4(float[] v)
			=> glVertex4fv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Vertex4(int x,int y,int z,int w)
			=> glVertex4i(x,y,z,w);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Vertex4(int[] v)
			=> glVertex4iv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Vertex4(short x,short y,short z,short w)
			=> glVertex4s(x,y,z,w);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Vertex4(short[] v)
			=> glVertex4sv(v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void VertexPointer(int size,uint type,int stride,IntPtr pointer)
			=> glVertexPointer(size,type,stride,pointer);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Viewport(int x,int y,int width,int height)
			=> glViewport(x,y,width,height);
	}
}
