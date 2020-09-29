using System;
using System.Runtime.InteropServices;
using CC = System.Runtime.InteropServices.CallingConvention;
using UFP = System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute;

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[UFP(CC.Cdecl)]
		private unsafe delegate void DrawArraysInstancedBaseInstanceDelegate(uint mode, int first, int count, int instanceCount, uint baseinstance);

		[UFP(CC.Cdecl)]
		private unsafe delegate void DrawElementsInstancedBaseInstanceDelegate(uint mode, int count, uint type, IntPtr indices, int instanceCount, uint baseinstance);

		[UFP(CC.Cdecl)]
		private unsafe delegate void DrawElementsInstancedBaseVertexBaseInstanceDelegate(uint mode, int count, uint type, IntPtr indices, int instanceCount, int basevertex, uint baseinstance);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetInternalformativDelegate(uint target, uint internalFormat, uint pName, int bufSize, ref int parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetActiveAtomicCounterBufferivDelegate(uint program, uint bufferIndex, uint pName, ref int parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void BindImageTextureDelegate(uint unit, uint texture, int level, byte layered, int layer, uint access, uint format);

		[UFP(CC.Cdecl)]
		private unsafe delegate void MemoryBarrierDelegate(uint barriers);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TexStorage1DDelegate(TextureTarget1D target, int levels, uint internalFormat, int width);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TexStorage2DDelegate(TextureTarget2D target, int levels, uint internalFormat, int width, int height);

		[UFP(CC.Cdecl)]
		private unsafe delegate void TexStorage3DDelegate(TextureTarget3D target, int levels, uint internalFormat, int width, int height, int depth);

		[UFP(CC.Cdecl)]
		private unsafe delegate void DrawTransformFeedbackInstancedDelegate(uint mode, uint id, int instanceCount);

		[UFP(CC.Cdecl)]
		private unsafe delegate void DrawTransformFeedbackStreamInstancedDelegate(uint mode, uint id, uint stream, int instanceCount);
	}
}
