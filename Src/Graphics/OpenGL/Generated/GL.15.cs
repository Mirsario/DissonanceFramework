using System;

namespace Dissonance.Framework.Graphics.OpenGL
{
	unsafe partial class GL
	{
		[MethodImport("glGenQueries", "1.5")]
		private static delegate*<int, uint*, void> glGenQueries;
		
		public static void GenQueries(int n, uint* ids)
		{
			glGenQueries(n, ids);
		}
		
		[MethodImport("glDeleteQueries", "1.5")]
		private static delegate*<int, uint*, void> glDeleteQueries;
		
		public static void DeleteQueries(int n, uint* ids)
		{
			glDeleteQueries(n, ids);
		}
		
		[MethodImport("glIsQuery", "1.5")]
		private static delegate*<uint, bool> glIsQuery;
		
		public static bool IsQuery(uint id)
		{
			return glIsQuery(id);
		}
		
		[MethodImport("glBeginQuery", "1.5")]
		private static delegate*<QueryTarget, uint, void> glBeginQuery;
		
		public static void BeginQuery(QueryTarget target, uint id)
		{
			glBeginQuery(target, id);
		}
		
		[MethodImport("glEndQuery", "1.5")]
		private static delegate*<QueryTarget, void> glEndQuery;
		
		public static void EndQuery(QueryTarget target)
		{
			glEndQuery(target);
		}
		
		[MethodImport("glGetQueryiv", "1.5")]
		private static delegate*<QueryTarget, QueryParameterName, int*, void> glGetQueryiv;
		
		public static void GetQueryiv(QueryTarget target, QueryParameterName pname, int* @params)
		{
			glGetQueryiv(target, pname, @params);
		}
		
		[MethodImport("glGetQueryObjectiv", "1.5")]
		private static delegate*<uint, QueryObjectParameterName, int*, void> glGetQueryObjectiv;
		
		public static void GetQueryObjectiv(uint id, QueryObjectParameterName pname, int* @params)
		{
			glGetQueryObjectiv(id, pname, @params);
		}
		
		[MethodImport("glGetQueryObjectuiv", "1.5")]
		private static delegate*<uint, QueryObjectParameterName, uint*, void> glGetQueryObjectuiv;
		
		public static void GetQueryObjectuiv(uint id, QueryObjectParameterName pname, uint* @params)
		{
			glGetQueryObjectuiv(id, pname, @params);
		}
		
		[MethodImport("glBindBuffer", "1.5")]
		private static delegate*<BufferTargetARB, uint, void> glBindBuffer;
		
		public static void BindBuffer(BufferTargetARB target, uint buffer)
		{
			glBindBuffer(target, buffer);
		}
		
		[MethodImport("glDeleteBuffers", "1.5")]
		private static delegate*<int, uint*, void> glDeleteBuffers;
		
		public static void DeleteBuffers(int n, uint* buffers)
		{
			glDeleteBuffers(n, buffers);
		}
		
		[MethodImport("glGenBuffers", "1.5")]
		private static delegate*<int, uint*, void> glGenBuffers;
		
		public static void GenBuffers(int n, uint* buffers)
		{
			glGenBuffers(n, buffers);
		}
		
		[MethodImport("glIsBuffer", "1.5")]
		private static delegate*<uint, bool> glIsBuffer;
		
		public static bool IsBuffer(uint buffer)
		{
			return glIsBuffer(buffer);
		}
		
		[MethodImport("glBufferData", "1.5")]
		private static delegate*<BufferTargetARB, IntPtr, void*, BufferUsageARB, void> glBufferData;
		
		public static void BufferData(BufferTargetARB target, IntPtr size, void* data, BufferUsageARB usage)
		{
			glBufferData(target, size, data, usage);
		}
		
		[MethodImport("glBufferSubData", "1.5")]
		private static delegate*<BufferTargetARB, IntPtr, IntPtr, void*, void> glBufferSubData;
		
		public static void BufferSubData(BufferTargetARB target, IntPtr offset, IntPtr size, void* data)
		{
			glBufferSubData(target, offset, size, data);
		}
		
		[MethodImport("glGetBufferSubData", "1.5")]
		private static delegate*<BufferTargetARB, IntPtr, IntPtr, void*, void> glGetBufferSubData;
		
		public static void GetBufferSubData(BufferTargetARB target, IntPtr offset, IntPtr size, void* data)
		{
			glGetBufferSubData(target, offset, size, data);
		}
		
		[MethodImport("glMapBuffer", "1.5")]
		private static delegate*<BufferTargetARB, BufferAccessARB, void> glMapBuffer;
		
		public static void MapBuffer(BufferTargetARB target, BufferAccessARB access)
		{
			glMapBuffer(target, access);
		}
		
		[MethodImport("glUnmapBuffer", "1.5")]
		private static delegate*<BufferTargetARB, bool> glUnmapBuffer;
		
		public static bool UnmapBuffer(BufferTargetARB target)
		{
			return glUnmapBuffer(target);
		}
		
		[MethodImport("glGetBufferParameteriv", "1.5")]
		private static delegate*<BufferTargetARB, BufferPNameARB, int*, void> glGetBufferParameteriv;
		
		public static void GetBufferParameteriv(BufferTargetARB target, BufferPNameARB pname, int* @params)
		{
			glGetBufferParameteriv(target, pname, @params);
		}
		
		[MethodImport("glGetBufferPointerv", "1.5")]
		private static delegate*<BufferTargetARB, BufferPointerNameARB, void**, void> glGetBufferPointerv;
		
		public static void GetBufferPointerv(BufferTargetARB target, BufferPointerNameARB pname, void** @params)
		{
			glGetBufferPointerv(target, pname, @params);
		}
	}
}

