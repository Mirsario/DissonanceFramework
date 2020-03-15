using System;
using System.Runtime.CompilerServices;

#pragma warning disable IDE0060 //Unused parameter.

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[MethodImpl(ImplOptions)]
		[MethodImport("glUniformMatrix2x3fv","2.1")]
		public static void UniformMatrix2x3(int location,int count,byte transpose,ref float value)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glUniformMatrix3x2fv","2.1")]
		public static void UniformMatrix3x2(int location,int count,byte transpose,ref float value)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glUniformMatrix2x4fv","2.1")]
		public static void UniformMatrix2x4(int location,int count,byte transpose,ref float value)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glUniformMatrix4x2fv","2.1")]
		public static void UniformMatrix4x2(int location,int count,byte transpose,ref float value)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glUniformMatrix3x4fv","2.1")]
		public static void UniformMatrix3x4(int location,int count,byte transpose,ref float value)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glUniformMatrix4x3fv","2.1")]
		public static void UniformMatrix4x3(int location,int count,byte transpose,ref float value)
			=> throw new NotImplementedException();
	}
}