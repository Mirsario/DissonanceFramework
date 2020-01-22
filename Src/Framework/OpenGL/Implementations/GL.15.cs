using System;

#pragma warning disable IDE0060 //Unused parameter.

namespace Dissonance.Framework.OpenGL
{
	partial class GL
	{
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
	}
}