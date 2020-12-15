using System;
using System.Runtime.InteropServices;
using CC = System.Runtime.InteropServices.CallingConvention;
using UFP = System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute;

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[UFP(CC.Cdecl)]
		private unsafe delegate void GenQueriesDelegate(int n, ref uint ids);

		[UFP(CC.Cdecl)]
		private unsafe delegate void DeleteQueriesDelegate(int n, ref uint ids);

		[UFP(CC.Cdecl)]
		private unsafe delegate byte IsQueryDelegate(uint id);

		[UFP(CC.Cdecl)]
		private unsafe delegate void BeginQueryDelegate(uint target, uint id);

		[UFP(CC.Cdecl)]
		private unsafe delegate void EndQueryDelegate(uint target);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetQueryivDelegate(uint target, uint pName, ref int parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetQueryObjectivDelegate(uint id, uint pName, ref int parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetQueryObjectuivDelegate(uint id, uint pName, ref uint parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void BindBufferDelegate(BufferTarget target, uint buffer);

		[UFP(CC.Cdecl)]
		private unsafe delegate void DeleteBuffersDelegate(int numBuffers, uint* buffers);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GenBuffersDelegate(int numBuffers, uint* buffers);

		[UFP(CC.Cdecl)]
		private unsafe delegate byte IsBufferDelegate(uint buffer);

		[UFP(CC.Cdecl)]
		private unsafe delegate void BufferDataDelegate(BufferTarget target, IntPtr size, IntPtr data, BufferUsageHint usage);

		[UFP(CC.Cdecl)]
		private unsafe delegate void BufferSubDataDelegate(BufferTarget target, int offset, int size, IntPtr data);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetBufferSubDataDelegate(BufferTarget target, int offset, int size, IntPtr data);

		[UFP(CC.Cdecl)]
		private unsafe delegate IntPtr MapBufferDelegate(BufferTarget target, uint access);

		[UFP(CC.Cdecl)]
		private unsafe delegate byte UnmapBufferDelegate(BufferTarget target);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetBufferParameterivDelegate(BufferTarget target, uint pName, ref int parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetBufferPointervDelegate(BufferTarget target, uint pName, ref IntPtr parameters);
	}
}
