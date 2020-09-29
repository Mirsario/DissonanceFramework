using System;
using System.Runtime.InteropServices;
using CC = System.Runtime.InteropServices.CallingConvention;
using UFP = System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute;

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[UFP(CC.Cdecl)]
		private unsafe delegate void BufferStorageDelegate(BufferTarget target, int size, IntPtr data, uint flags);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ClearTexImageDelegate(uint texture, int level, PixelFormat format, PixelType type, IntPtr data);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ClearTexSubImageDelegate(uint texture, int level, int xOffset, int yOffset, int zOffset, int width, int height, int depth, PixelFormat format, PixelType type, IntPtr data);

		[UFP(CC.Cdecl)]
		private unsafe delegate void BindBuffersBaseDelegate(BufferRangeTarget target, uint first, int count, ref uint buffers);

		[UFP(CC.Cdecl)]
		private unsafe delegate void BindBuffersRangeDelegate(BufferRangeTarget target, uint first, int count, ref uint buffers, ref int offsets, ref int sizes);

		[UFP(CC.Cdecl)]
		private unsafe delegate void BindTexturesDelegate(uint first, int count, ref uint textures);

		[UFP(CC.Cdecl)]
		private unsafe delegate void BindSamplersDelegate(uint first, int count, ref uint samplers);

		[UFP(CC.Cdecl)]
		private unsafe delegate void BindImageTexturesDelegate(uint first, int count, ref uint textures);

		[UFP(CC.Cdecl)]
		private unsafe delegate void BindVertexBuffersDelegate(uint first, int count, ref uint buffers, ref int offsets, ref int strides);
	}
}
