using System;

namespace Dissonance.Framework.Graphics.OpenGL
{
	unsafe partial class GL
	{
		[MethodImport("glUniformMatrix2x3fv", "2.1")]
		private static delegate*<int, int, bool, float*, void> glUniformMatrix2x3fv;
		
		public static void UniformMatrix2x3fv(int location, int count, bool transpose, float* value)
		{
			glUniformMatrix2x3fv(location, count, transpose, value);
		}
		
		[MethodImport("glUniformMatrix3x2fv", "2.1")]
		private static delegate*<int, int, bool, float*, void> glUniformMatrix3x2fv;
		
		public static void UniformMatrix3x2fv(int location, int count, bool transpose, float* value)
		{
			glUniformMatrix3x2fv(location, count, transpose, value);
		}
		
		[MethodImport("glUniformMatrix2x4fv", "2.1")]
		private static delegate*<int, int, bool, float*, void> glUniformMatrix2x4fv;
		
		public static void UniformMatrix2x4fv(int location, int count, bool transpose, float* value)
		{
			glUniformMatrix2x4fv(location, count, transpose, value);
		}
		
		[MethodImport("glUniformMatrix4x2fv", "2.1")]
		private static delegate*<int, int, bool, float*, void> glUniformMatrix4x2fv;
		
		public static void UniformMatrix4x2fv(int location, int count, bool transpose, float* value)
		{
			glUniformMatrix4x2fv(location, count, transpose, value);
		}
		
		[MethodImport("glUniformMatrix3x4fv", "2.1")]
		private static delegate*<int, int, bool, float*, void> glUniformMatrix3x4fv;
		
		public static void UniformMatrix3x4fv(int location, int count, bool transpose, float* value)
		{
			glUniformMatrix3x4fv(location, count, transpose, value);
		}
		
		[MethodImport("glUniformMatrix4x3fv", "2.1")]
		private static delegate*<int, int, bool, float*, void> glUniformMatrix4x3fv;
		
		public static void UniformMatrix4x3fv(int location, int count, bool transpose, float* value)
		{
			glUniformMatrix4x3fv(location, count, transpose, value);
		}
	}
}

