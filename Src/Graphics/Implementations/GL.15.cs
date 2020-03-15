using System;
using System.Runtime.CompilerServices;

#pragma warning disable IDE0060 //Unused parameter.

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[MethodImpl(ImplOptions)]
		[MethodImport("glGenQueries","1.5")]
		public static void GenQueries(int n,ref uint ids)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glDeleteQueries","1.5")]
		public static void DeleteQueries(int n,ref uint ids)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glIsQuery","1.5")]
		public static byte IsQuery(uint id)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glBeginQuery","1.5")]
		public static void BeginQuery(uint target,uint id)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glEndQuery","1.5")]
		public static void EndQuery(uint target)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetQueryiv","1.5")]
		public static void GetQuery(uint target,uint pName,ref int parameters)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetQueryObjectiv","1.5")]
		public static void GetQueryObject(uint id,uint pName,ref int parameters)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetQueryObjectuiv","1.5")]
		public static void GetQueryObject(uint id,uint pName,ref uint parameters)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glBindBuffer","1.5")]
		public static void BindBuffer(BufferTarget target,uint buffer)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glDeleteBuffers","1.5")]
		public unsafe static void DeleteBuffers(int numBuffers,uint* buffers)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGenBuffers","1.5")]
		public unsafe static void GenBuffers(int numBuffers,uint* buffers)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glIsBuffer","1.5")]
		public static byte IsBuffer(uint buffer)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glBufferData","1.5")]
		public static void BufferData(BufferTarget target,IntPtr size,IntPtr data,BufferUsageHint usage)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glBufferSubData","1.5")]
		public static void BufferSubData(BufferTarget target,int offset,int size,IntPtr data)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetBufferSubData","1.5")]
		public static void GetBufferSubData(BufferTarget target,int offset,int size,IntPtr data)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glMapBuffer","1.5")]
		public static IntPtr MapBuffer(BufferTarget target,uint access)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glUnmapBuffer","1.5")]
		public static byte UnmapBuffer(BufferTarget target)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetBufferParameteriv","1.5")]
		public static void GetBufferParameter(BufferTarget target,uint pName,ref int parameters)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetBufferPointerv","1.5")]
		public static void GetBufferPointer(BufferTarget target,uint pName,ref IntPtr parameters)
			=> throw new NotImplementedException();
	}
}