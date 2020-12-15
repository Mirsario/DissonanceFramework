using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[MethodImpl(ImplOptions)]
		public unsafe static void UniformMatrix2x3(int location, int count, byte transpose, ref float value)
			=> glUniformMatrix2x3fv(location, count, transpose, ref value);

		[MethodImpl(ImplOptions)]
		public unsafe static void UniformMatrix3x2(int location, int count, byte transpose, ref float value)
			=> glUniformMatrix3x2fv(location, count, transpose, ref value);

		[MethodImpl(ImplOptions)]
		public unsafe static void UniformMatrix2x4(int location, int count, byte transpose, ref float value)
			=> glUniformMatrix2x4fv(location, count, transpose, ref value);

		[MethodImpl(ImplOptions)]
		public unsafe static void UniformMatrix4x2(int location, int count, byte transpose, ref float value)
			=> glUniformMatrix4x2fv(location, count, transpose, ref value);

		[MethodImpl(ImplOptions)]
		public unsafe static void UniformMatrix3x4(int location, int count, byte transpose, ref float value)
			=> glUniformMatrix3x4fv(location, count, transpose, ref value);

		[MethodImpl(ImplOptions)]
		public unsafe static void UniformMatrix4x3(int location, int count, byte transpose, ref float value)
			=> glUniformMatrix4x3fv(location, count, transpose, ref value);
	}
}
