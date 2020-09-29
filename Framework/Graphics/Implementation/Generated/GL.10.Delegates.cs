using System;
using System.Runtime.InteropServices;
using CC = System.Runtime.InteropServices.CallingConvention;
using UFP = System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute;

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[UFP(CC.Cdecl)]
		private unsafe delegate void AccumDelegate(uint op, float value);

		[UFP(CC.Cdecl)]
		private unsafe delegate void AlphaFuncDelegate(uint func, float alpha);

		[UFP(CC.Cdecl)]
		private unsafe delegate byte AreTexturesResidentDelegate(int n, uint[] textures, IntPtr residences);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ArrayElementDelegate(int i);

		[UFP(CC.Cdecl)]
		private unsafe delegate void BeginDelegate(PrimitiveType mode);

		[UFP(CC.Cdecl)]
		private unsafe delegate void BindTextureDelegate(TextureTarget target, uint texture);

		[UFP(CC.Cdecl)]
		private unsafe delegate void BitmapDelegate(int width, int height, float xOrig, float yOrig, float xMove, float yMove, IntPtr bitmap);

		[UFP(CC.Cdecl)]
		private unsafe delegate void BlendFuncDelegate(BlendingFactor sfactor, BlendingFactor dfactor);

		[UFP(CC.Cdecl)]
		private unsafe delegate void CallListDelegate(uint list);

		[UFP(CC.Cdecl)]
		private unsafe delegate void CallListsDelegate(int n, uint type, IntPtr lists);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ClearDelegate(ClearBufferMask mask);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ClearAccumDelegate(float red, float green, float blue, float alpha = 1f);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ClearColorDelegate(float red, float green, float blue, float alpha = 1f);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ClearDepthDelegate(double depth);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ClearIndexDelegate(float c);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ClearStencilDelegate(int s);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ClipPlaneDelegate(uint plane, double[] equation);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Color3bDelegate(sbyte red, sbyte green, sbyte blue);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Color3bvDelegate(sbyte[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Color3dDelegate(double red, double green, double blue);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Color3dvDelegate(double[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Color3fDelegate(float red, float green, float blue);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Color3fvDelegate(float[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Color3iDelegate(int red, int green, int blue);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Color3ivDelegate(int[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Color3sDelegate(short red, short green, short blue);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Color3svDelegate(short[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Color3ubDelegate(byte red, byte green, byte blue);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Color3ubvDelegate(byte[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Color3uiDelegate(uint red, uint green, uint blue);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Color3uivDelegate(uint[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Color3usDelegate(ushort red, ushort green, ushort blue);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Color3usvDelegate(ushort[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Color4bDelegate(sbyte red, sbyte green, sbyte blue, sbyte alpha);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Color4bvDelegate(sbyte[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Color4dDelegate(double red, double green, double blue, double alpha);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Color4dvDelegate(double[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Color4fDelegate(float red, float green, float blue, float alpha);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Color4fvDelegate(float[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Color4iDelegate(int red, int green, int blue, int alpha);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Color4ivDelegate(int[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Color4sDelegate(short red, short green, short blue, short alpha);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Color4svDelegate(short[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Color4ubDelegate(byte red, byte green, byte blue, byte alpha);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Color4ubvDelegate(byte[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Color4uiDelegate(uint red, uint green, uint blue, uint alpha);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Color4uivDelegate(uint[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Color4usDelegate(ushort red, ushort green, ushort blue, ushort alpha);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Color4usvDelegate(ushort[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ColorMaskDelegate(byte red, byte green, byte blue, byte alpha);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ColorMaterialDelegate(uint face, uint mode);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ColorPointerDelegate(int size, uint type, int stride, IntPtr pointer);

		[UFP(CC.Cdecl)]
		private unsafe delegate void CopyPixelsDelegate(int x, int y, int width, int height, uint type);

		[UFP(CC.Cdecl)]
		private unsafe delegate void CopyTexImage1DDelegate(TextureTarget target, int level, uint internalFormat, int x, int y, int width, int border);

		[UFP(CC.Cdecl)]
		private unsafe delegate void CopyTexImage2DDelegate(TextureTarget target, int level, uint internalFormat, int x, int y, int width, int height, int border);

		[UFP(CC.Cdecl)]
		private unsafe delegate void CopyTexSubImage1DDelegate(TextureTarget target, int level, int xOffset, int x, int y, int width);

		[UFP(CC.Cdecl)]
		private unsafe delegate void CopyTexSubImage2DDelegate(TextureTarget target, int level, int xOffset, int yOffset, int x, int y, int width, int height);

		[UFP(CC.Cdecl)]
		private unsafe delegate void CullFaceDelegate(CullFaceMode mode);

		[UFP(CC.Cdecl)]
		private unsafe delegate void DeleteListsDelegate(uint list, int range);

		[UFP(CC.Cdecl)]
		private unsafe delegate void DepthFuncDelegate(DepthFunction func);

		[UFP(CC.Cdecl)]
		private unsafe delegate void DepthMaskDelegate(bool flag);

		[UFP(CC.Cdecl)]
		private unsafe delegate void DepthRangeDelegate(double zNear, double zFar);

		[UFP(CC.Cdecl)]
		private unsafe delegate void DisableDelegate(EnableCap cap);

		[UFP(CC.Cdecl)]
		private unsafe delegate void DisableClientStateDelegate(uint capability);

		[UFP(CC.Cdecl)]
		private unsafe delegate void DrawArraysDelegate(PrimitiveType mode, int first, int count);

		[UFP(CC.Cdecl)]
		private unsafe delegate void DrawBufferDelegate(DrawBufferMode mode);

		[UFP(CC.Cdecl)]
		private unsafe delegate void DrawElementsDelegate(PrimitiveType mode, int count, DrawElementsType type, IntPtr indices);

		[UFP(CC.Cdecl)]
		private unsafe delegate void DrawPixelsDelegate(int width, int height, PixelFormat format, PixelType type, IntPtr pixels);

		[UFP(CC.Cdecl)]
		private unsafe delegate void EdgeFlagDelegate(byte flag);

		[UFP(CC.Cdecl)]
		private unsafe delegate void EdgeFlagPointerDelegate(int stride, IntPtr pointer);

		[UFP(CC.Cdecl)]
		private unsafe delegate void EdgeFlagvDelegate(IntPtr flag);

		[UFP(CC.Cdecl)]
		private unsafe delegate void EnableDelegate(EnableCap cap);

		[UFP(CC.Cdecl)]
		private unsafe delegate void EnableClientStateDelegate(uint capability);

		[UFP(CC.Cdecl)]
		private unsafe delegate void EndDelegate();

		[UFP(CC.Cdecl)]
		private unsafe delegate void EndListDelegate();

		[UFP(CC.Cdecl)]
		private unsafe delegate void EvalCoord1dDelegate(double u);

		[UFP(CC.Cdecl)]
		private unsafe delegate void EvalCoord1dvDelegate(double[] u);

		[UFP(CC.Cdecl)]
		private unsafe delegate void EvalCoord1fDelegate(float u);

		[UFP(CC.Cdecl)]
		private unsafe delegate void EvalCoord1fvDelegate(float[] u);

		[UFP(CC.Cdecl)]
		private unsafe delegate void EvalCoord2dDelegate(double u, double v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void EvalCoord2dvDelegate(double[] u);

		[UFP(CC.Cdecl)]
		private unsafe delegate void EvalCoord2fDelegate(float u, float v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void EvalCoord2fvDelegate(float[] u);

		[UFP(CC.Cdecl)]
		private unsafe delegate void EvalMesh1Delegate(uint mode, int i1, int i2);

		[UFP(CC.Cdecl)]
		private unsafe delegate void EvalMesh2Delegate(uint mode, int i1, int i2, int j1, int j2);

		[UFP(CC.Cdecl)]
		private unsafe delegate void EvalPoint1Delegate(int i);

		[UFP(CC.Cdecl)]
		private unsafe delegate void EvalPoint2Delegate(int i, int j);

		[UFP(CC.Cdecl)]
		private unsafe delegate void FeedbackBufferDelegate(int size, uint type, float[] buffer);

		[UFP(CC.Cdecl)]
		private unsafe delegate void FinishDelegate();

		[UFP(CC.Cdecl)]
		private unsafe delegate void FlushDelegate();

		[UFP(CC.Cdecl)]
		private unsafe delegate void FogfDelegate(uint pName, float param);

		[UFP(CC.Cdecl)]
		private unsafe delegate void FogfvDelegate(uint pName, float[] parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void FogiDelegate(uint pName, int param);

		[UFP(CC.Cdecl)]
		private unsafe delegate void FogivDelegate(uint pName, int[] parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void FrontFaceDelegate(uint mode);

		[UFP(CC.Cdecl)]
		private unsafe delegate void FrustumDelegate(double left, double right, double bottom, double top, double zNear, double zFar);

		[UFP(CC.Cdecl)]
		private unsafe delegate uint GenListsDelegate(int range);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetBooleanvDelegate(uint pName, IntPtr parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetClipPlaneDelegate(uint plane, double[] equation);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetDoublevDelegate(uint pName, double[] parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate GraphicsError GetErrorDelegate();

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetFloatvDelegate(uint pName, float[] parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetIntegervDelegate(uint pName, int[] parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetLightfvDelegate(uint light, uint pName, float[] parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetLightivDelegate(uint light, uint pName, int[] parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetMapdvDelegate(uint target, uint query, double[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetMapfvDelegate(uint target, uint query, float[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetMapivDelegate(uint target, uint query, int[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetMaterialfvDelegate(uint face, uint pName, float[] parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetMaterialivDelegate(uint face, uint pName, int[] parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetPixelMapfvDelegate(uint map, float[] values);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetPixelMapuivDelegate(uint map, uint[] values);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetPixelMapusvDelegate(uint map, ushort[] values);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetPointervDelegate(uint pName, ref IntPtr parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetPolygonStippleDelegate(IntPtr mask);

		[UFP(CC.Cdecl)]
		private unsafe delegate IntPtr GetStringDelegate(StringName name);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetTexEnvfvDelegate(TextureEnvTarget target, uint pName, float[] parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetTexEnvivDelegate(TextureEnvTarget target, uint pName, int[] parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetTexGendvDelegate(uint coord, uint pName, double[] parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetTexGenfvDelegate(uint coord, uint pName, float[] parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetTexGenivDelegate(uint coord, uint pName, int[] parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetTexImageDelegate(TextureTarget target, int level, PixelFormat format, PixelType type, IntPtr pixels);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetTexLevelParameterfvDelegate(TextureTarget target, int level, uint pName, float[] parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetTexLevelParameterivDelegate(TextureTarget target, int level, uint pName, int[] parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetTexParameterfvDelegate(TextureTarget target, GetTextureParameter parameterName, float[] parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetTexParameterivDelegate(TextureTarget target, GetTextureParameter parameterName, int[] parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GenTexturesDelegate(int numTextures, [Out] uint* textures);

		[UFP(CC.Cdecl)]
		private unsafe delegate void DeleteTexturesDelegate(int numTextures, [Out] uint* textures);

		[UFP(CC.Cdecl)]
		private unsafe delegate void HintDelegate(uint target, uint mode);

		[UFP(CC.Cdecl)]
		private unsafe delegate void IndexMaskDelegate(uint mask);

		[UFP(CC.Cdecl)]
		private unsafe delegate void IndexPointerDelegate(uint type, int stride, IntPtr pointer);

		[UFP(CC.Cdecl)]
		private unsafe delegate void IndexdDelegate(double c);

		[UFP(CC.Cdecl)]
		private unsafe delegate void IndexdvDelegate(double[] c);

		[UFP(CC.Cdecl)]
		private unsafe delegate void IndexfDelegate(float c);

		[UFP(CC.Cdecl)]
		private unsafe delegate void IndexfvDelegate(float[] c);

		[UFP(CC.Cdecl)]
		private unsafe delegate void IndexiDelegate(int c);

		[UFP(CC.Cdecl)]
		private unsafe delegate void IndexivDelegate(int[] c);

		[UFP(CC.Cdecl)]
		private unsafe delegate void IndexsDelegate(short c);

		[UFP(CC.Cdecl)]
		private unsafe delegate void IndexsvDelegate(short[] c);

		[UFP(CC.Cdecl)]
		private unsafe delegate void IndexubDelegate(byte c);

		[UFP(CC.Cdecl)]
		private unsafe delegate void IndexubvDelegate(IntPtr c);

		[UFP(CC.Cdecl)]
		private unsafe delegate void InitNamesDelegate();

		[UFP(CC.Cdecl)]
		private unsafe delegate void InterleavedArraysDelegate(uint format, int stride, IntPtr pointer);

		[UFP(CC.Cdecl)]
		private unsafe delegate byte IsEnabledDelegate(EnableCap cap);

		[UFP(CC.Cdecl)]
		private unsafe delegate byte IsListDelegate(uint list);

		[UFP(CC.Cdecl)]
		private unsafe delegate byte IsTextureDelegate(uint texture);

		[UFP(CC.Cdecl)]
		private unsafe delegate void LightModelfDelegate(uint pName, float param);

		[UFP(CC.Cdecl)]
		private unsafe delegate void LightModelfvDelegate(uint pName, float[] parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void LightModeliDelegate(uint pName, int param);

		[UFP(CC.Cdecl)]
		private unsafe delegate void LightModelivDelegate(uint pName, int[] parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void LightfDelegate(uint light, uint pName, float param);

		[UFP(CC.Cdecl)]
		private unsafe delegate void LightfvDelegate(uint light, uint pName, float[] parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void LightiDelegate(uint light, uint pName, int param);

		[UFP(CC.Cdecl)]
		private unsafe delegate void LightivDelegate(uint light, uint pName, int[] parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void LineStippleDelegate(int factor, ushort pattern);

		[UFP(CC.Cdecl)]
		private unsafe delegate void LineWidthDelegate(float width);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ListBaseDelegate(uint b);

		[UFP(CC.Cdecl)]
		private unsafe delegate void LoadIdentityDelegate();

		[UFP(CC.Cdecl)]
		private unsafe delegate void LoadMatrixdDelegate(double[] m);

		[UFP(CC.Cdecl)]
		private unsafe delegate void LoadMatrixfDelegate(float[] m);

		[UFP(CC.Cdecl)]
		private unsafe delegate void LoadNameDelegate(uint name);

		[UFP(CC.Cdecl)]
		private unsafe delegate void LogicOpDelegate(uint opcode);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Map1dDelegate(uint target, double u1, double u2, int stride, int order, double[] points);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Map1fDelegate(uint target, float u1, float u2, int stride, int order, float[] points);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Map2dDelegate(uint target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double[] points);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Map2fDelegate(uint target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float[] points);

		[UFP(CC.Cdecl)]
		private unsafe delegate void MapGrid1dDelegate(int un, double u1, double u2);

		[UFP(CC.Cdecl)]
		private unsafe delegate void MapGrid1fDelegate(int un, float u1, float u2);

		[UFP(CC.Cdecl)]
		private unsafe delegate void MapGrid2dDelegate(int un, double u1, double u2, int vn, double v1, double v2);

		[UFP(CC.Cdecl)]
		private unsafe delegate void MapGrid2fDelegate(int un, float u1, float u2, int vn, float v1, float v2);

		[UFP(CC.Cdecl)]
		private unsafe delegate void MaterialfDelegate(uint face, uint pName, float param);

		[UFP(CC.Cdecl)]
		private unsafe delegate void MaterialfvDelegate(uint face, uint pName, float[] parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void MaterialiDelegate(uint face, uint pName, int param);

		[UFP(CC.Cdecl)]
		private unsafe delegate void MaterialivDelegate(uint face, uint pName, int[] parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void MatrixModeDelegate(uint mode);

		[UFP(CC.Cdecl)]
		private unsafe delegate void MultMatrixdDelegate(double[] m);

		[UFP(CC.Cdecl)]
		private unsafe delegate void MultMatrixfDelegate(float[] m);

		[UFP(CC.Cdecl)]
		private unsafe delegate void NewListDelegate(uint list, uint mode);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Normal3bDelegate(sbyte nx, sbyte ny, sbyte nz);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Normal3bvDelegate(IntPtr v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Normal3dDelegate(double nx, double ny, double nz);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Normal3dvDelegate(double[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Normal3fDelegate(float nx, float ny, float nz);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Normal3fvDelegate(float[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Normal3iDelegate(int nx, int ny, int nz);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Normal3ivDelegate(int[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Normal3sDelegate(short nx, short ny, short nz);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Normal3svDelegate(short[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void NormalPointerDelegate(uint type, int stride, IntPtr pointer);

		[UFP(CC.Cdecl)]
		private unsafe delegate void OrthoDelegate(double left, double right, double bottom, double top, double zNear, double zFar);

		[UFP(CC.Cdecl)]
		private unsafe delegate void PassThroughDelegate(float token);

		[UFP(CC.Cdecl)]
		private unsafe delegate void PixelMapfvDelegate(uint map, int mapSize, float[] values);

		[UFP(CC.Cdecl)]
		private unsafe delegate void PixelMapuivDelegate(uint map, int mapSize, uint[] values);

		[UFP(CC.Cdecl)]
		private unsafe delegate void PixelMapusvDelegate(uint map, int mapSize, ushort[] values);

		[UFP(CC.Cdecl)]
		private unsafe delegate void PixelStorefDelegate(uint pName, float param);

		[UFP(CC.Cdecl)]
		private unsafe delegate void PixelStoreiDelegate(uint pName, int param);

		[UFP(CC.Cdecl)]
		private unsafe delegate void PixelTransferfDelegate(uint pName, float param);

		[UFP(CC.Cdecl)]
		private unsafe delegate void PixelTransferiDelegate(uint pName, int param);

		[UFP(CC.Cdecl)]
		private unsafe delegate void PixelZoomDelegate(float xFactor, float yFactor);

		[UFP(CC.Cdecl)]
		private unsafe delegate void PointSizeDelegate(float size);

		[UFP(CC.Cdecl)]
		private unsafe delegate void PolygonModeDelegate(MaterialFace face, PolygonMode mode);

		[UFP(CC.Cdecl)]
		private unsafe delegate void PolygonOffsetDelegate(float factor, float units);

		[UFP(CC.Cdecl)]
		private unsafe delegate void PolygonStippleDelegate(IntPtr mask);

		[UFP(CC.Cdecl)]
		private unsafe delegate void PopAttribDelegate();

		[UFP(CC.Cdecl)]
		private unsafe delegate void PopClientAttribDelegate();

		[UFP(CC.Cdecl)]
		private unsafe delegate void PopMatrixDelegate();

		[UFP(CC.Cdecl)]
		private unsafe delegate void PopNameDelegate();

		[UFP(CC.Cdecl)]
		private unsafe delegate void PrioritizeTexturesDelegate(int n, uint[] textures, float[] priorities);

		[UFP(CC.Cdecl)]
		private unsafe delegate void PushAttribDelegate(uint mask);

		[UFP(CC.Cdecl)]
		private unsafe delegate void PushClientAttribDelegate(uint mask);

		[UFP(CC.Cdecl)]
		private unsafe delegate void PushMatrixDelegate();

		[UFP(CC.Cdecl)]
		private unsafe delegate void PushNameDelegate(uint name);

		[UFP(CC.Cdecl)]
		private unsafe delegate void RasterPos2dDelegate(double x, double y);

		[UFP(CC.Cdecl)]
		private unsafe delegate void RasterPos2dvDelegate(double[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void RasterPos2fDelegate(float x, float y);

		[UFP(CC.Cdecl)]
		private unsafe delegate void RasterPos2fvDelegate(float[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void RasterPos2iDelegate(int x, int y);

		[UFP(CC.Cdecl)]
		private unsafe delegate void RasterPos2ivDelegate(int[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void RasterPos2sDelegate(short x, short y);

		[UFP(CC.Cdecl)]
		private unsafe delegate void RasterPos2svDelegate(short[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void RasterPos3dDelegate(double x, double y, double z);

		[UFP(CC.Cdecl)]
		private unsafe delegate void RasterPos3dvDelegate(double[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void RasterPos3fDelegate(float x, float y, float z);

		[UFP(CC.Cdecl)]
		private unsafe delegate void RasterPos3fvDelegate(float[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void RasterPos3iDelegate(int x, int y, int z);

		[UFP(CC.Cdecl)]
		private unsafe delegate void RasterPos3ivDelegate(int[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void RasterPos3sDelegate(short x, short y, short z);

		[UFP(CC.Cdecl)]
		private unsafe delegate void RasterPos3svDelegate(short[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void RasterPos4dDelegate(double x, double y, double z, double w);

		[UFP(CC.Cdecl)]
		private unsafe delegate void RasterPos4dvDelegate(double[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void RasterPos4fDelegate(float x, float y, float z, float w);

		[UFP(CC.Cdecl)]
		private unsafe delegate void RasterPos4fvDelegate(float[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void RasterPos4iDelegate(int x, int y, int z, int w);

		[UFP(CC.Cdecl)]
		private unsafe delegate void RasterPos4ivDelegate(int[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void RasterPos4sDelegate(short x, short y, short z, short w);

		[UFP(CC.Cdecl)]
		private unsafe delegate void RasterPos4svDelegate(short[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ReadBufferDelegate(ReadBufferMode mode);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ReadPixelsDelegate(int x, int y, int width, int height, PixelFormat format, PixelType type, IntPtr pixels);

		[UFP(CC.Cdecl)]
		private unsafe delegate void RectdDelegate(double x1, double y1, double x2, double y2);

		[UFP(CC.Cdecl)]
		private unsafe delegate void RectdvDelegate(double[] v1, double[] v2);

		[UFP(CC.Cdecl)]
		private unsafe delegate void RectfDelegate(float x1, float y1, float x2, float y2);

		[UFP(CC.Cdecl)]
		private unsafe delegate void RectfvDelegate(float[] v1, float[] v2);

		[UFP(CC.Cdecl)]
		private unsafe delegate void RectiDelegate(int x1, int y1, int x2, int y2);

		[UFP(CC.Cdecl)]
		private unsafe delegate void RectivDelegate(int[] v1, int[] v2);

		[UFP(CC.Cdecl)]
		private unsafe delegate void RectsDelegate(short x1, short y1, short x2, short y2);

		[UFP(CC.Cdecl)]
		private unsafe delegate void RectsvDelegate(short[] v1, short[] v2);

		[UFP(CC.Cdecl)]
		private unsafe delegate int RenderModeDelegate(uint mode);

		[UFP(CC.Cdecl)]
		private unsafe delegate void RotatedDelegate(double angle, double x, double y, double z);

		[UFP(CC.Cdecl)]
		private unsafe delegate void RotatefDelegate(float angle, float x, float y, float z);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ScaledDelegate(double x, double y, double z);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ScalefDelegate(float x, float y, float z);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ScissorDelegate(int x, int y, int width, int height);

		[UFP(CC.Cdecl)]
		private unsafe delegate void SelectBufferDelegate(int size, uint[] buffer);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ShadeModelDelegate(uint mode);

		[UFP(CC.Cdecl)]
		private unsafe delegate void StencilFuncDelegate(uint func, int refer, uint mask);

		[UFP(CC.Cdecl)]
		private unsafe delegate void StencilMaskDelegate(uint mask);

		[UFP(CC.Cdecl)]
		private unsafe delegate void StencilOpDelegate(uint fail, uint zfail, uint zpass);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TexCoord1dDelegate(double s);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TexCoord1dvDelegate(double[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TexCoord1fDelegate(float s);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TexCoord1fvDelegate(float[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TexCoord1iDelegate(int s);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TexCoord1ivDelegate(int[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TexCoord1sDelegate(short s);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TexCoord1svDelegate(short[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TexCoord2dDelegate(double s, double t);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TexCoord2dvDelegate(double[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TexCoord2fDelegate(float s, float t);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TexCoord2fvDelegate(float[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TexCoord2iDelegate(int s, int t);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TexCoord2ivDelegate(int[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TexCoord2sDelegate(short s, short t);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TexCoord2svDelegate(short[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TexCoord3dDelegate(double s, double t, double r);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TexCoord3dvDelegate(double[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TexCoord3fDelegate(float s, float t, float r);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TexCoord3fvDelegate(float[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TexCoord3iDelegate(int s, int t, int r);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TexCoord3ivDelegate(int[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TexCoord3sDelegate(short s, short t, short r);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TexCoord3svDelegate(short[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TexCoord4dDelegate(double s, double t, double r, double q);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TexCoord4dvDelegate(double[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TexCoord4fDelegate(float s, float t, float r, float q);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TexCoord4fvDelegate(float[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TexCoord4iDelegate(int s, int t, int r, int q);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TexCoord4ivDelegate(int[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TexCoord4sDelegate(short s, short t, short r, short q);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TexCoord4svDelegate(short[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TexCoordPointerDelegate(int size, uint type, int stride, IntPtr pointer);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TexEnvfDelegate(TextureEnvTarget target, uint pName, float param);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TexEnvfvDelegate(TextureEnvTarget target, uint pName, float[] parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TexEnviDelegate(TextureEnvTarget target, uint pName, int param);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TexEnvivDelegate(TextureEnvTarget target, uint pName, int[] parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TexGendDelegate(uint coord, uint pName, double param);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TexGendvDelegate(uint coord, uint pName, double[] parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TexGenfDelegate(uint coord, uint pName, float param);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TexGenfvDelegate(uint coord, uint pName, float[] parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TexGeniDelegate(uint coord, uint pName, int param);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TexGenivDelegate(uint coord, uint pName, int[] parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TexImage1DDelegate(TextureTarget target, int level, PixelInternalFormat internalFormat, int width, int border, PixelFormat format, PixelType type, IntPtr pixels);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TexImage2DDelegate(TextureTarget target, int level, PixelInternalFormat internalFormat, int width, int height, int border, PixelFormat format, PixelType type, IntPtr pixels);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TexParameterfDelegate(TextureTarget target, TextureParameterName parameterName, float param);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TexParameterfvDelegate(TextureTarget target, TextureParameterName parameterName, float[] parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TexParameteriDelegate(TextureTarget target, TextureParameterName parameterName, int param);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TexParameterivDelegate(TextureTarget target, TextureParameterName parameterName, int[] parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TexSubImage1DDelegate(TextureTarget target, int level, int xOffset, int width, PixelFormat format, PixelType type, IntPtr pixels);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TexSubImage2DDelegate(TextureTarget target, int level, int xOffset, int yOffset, int width, int height, PixelFormat format, PixelType type, IntPtr pixels);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TranslatedDelegate(double x, double y, double z);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TranslatefDelegate(float x, float y, float z);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Vertex2dDelegate(double x, double y);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Vertex2dvDelegate(double[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Vertex2fDelegate(float x, float y);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Vertex2fvDelegate(float[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Vertex2iDelegate(int x, int y);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Vertex2ivDelegate(int[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Vertex2sDelegate(short x, short y);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Vertex2svDelegate(short[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Vertex3dDelegate(double x, double y, double z);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Vertex3dvDelegate(double[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Vertex3fDelegate(float x, float y, float z);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Vertex3fvDelegate(float[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Vertex3iDelegate(int x, int y, int z);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Vertex3ivDelegate(int[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Vertex3sDelegate(short x, short y, short z);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Vertex3svDelegate(short[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Vertex4dDelegate(double x, double y, double z, double w);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Vertex4dvDelegate(double[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Vertex4fDelegate(float x, float y, float z, float w);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Vertex4fvDelegate(float[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Vertex4iDelegate(int x, int y, int z, int w);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Vertex4ivDelegate(int[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Vertex4sDelegate(short x, short y, short z, short w);

		[UFP(CC.Cdecl)]
		private unsafe delegate void Vertex4svDelegate(short[] v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexPointerDelegate(int size, uint type, int stride, IntPtr pointer);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ViewportDelegate(int x, int y, int width, int height);
	}
}
