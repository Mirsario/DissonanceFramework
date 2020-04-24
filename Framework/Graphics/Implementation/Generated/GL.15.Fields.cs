#pragma warning disable CS0649

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[MethodImport("glGenQueries")]
		private static GenQueriesDelegate glGenQueries;
		
		[MethodImport("glDeleteQueries")]
		private static DeleteQueriesDelegate glDeleteQueries;
		
		[MethodImport("glIsQuery")]
		private static IsQueryDelegate glIsQuery;
		
		[MethodImport("glBeginQuery")]
		private static BeginQueryDelegate glBeginQuery;
		
		[MethodImport("glEndQuery")]
		private static EndQueryDelegate glEndQuery;
		
		[MethodImport("glGetQueryiv")]
		private static GetQueryivDelegate glGetQueryiv;
		
		[MethodImport("glGetQueryObjectiv")]
		private static GetQueryObjectivDelegate glGetQueryObjectiv;
		
		[MethodImport("glGetQueryObjectuiv")]
		private static GetQueryObjectuivDelegate glGetQueryObjectuiv;
		
		[MethodImport("glBindBuffer")]
		private static BindBufferDelegate glBindBuffer;
		
		[MethodImport("glDeleteBuffers")]
		private static DeleteBuffersDelegate glDeleteBuffers;
		
		[MethodImport("glGenBuffers")]
		private static GenBuffersDelegate glGenBuffers;
		
		[MethodImport("glIsBuffer")]
		private static IsBufferDelegate glIsBuffer;
		
		[MethodImport("glBufferData")]
		private static BufferDataDelegate glBufferData;
		
		[MethodImport("glBufferSubData")]
		private static BufferSubDataDelegate glBufferSubData;
		
		[MethodImport("glGetBufferSubData")]
		private static GetBufferSubDataDelegate glGetBufferSubData;
		
		[MethodImport("glMapBuffer")]
		private static MapBufferDelegate glMapBuffer;
		
		[MethodImport("glUnmapBuffer")]
		private static UnmapBufferDelegate glUnmapBuffer;
		
		[MethodImport("glGetBufferParameteriv")]
		private static GetBufferParameterivDelegate glGetBufferParameteriv;
		
		[MethodImport("glGetBufferPointerv")]
		private static GetBufferPointervDelegate glGetBufferPointerv;
	}
}
