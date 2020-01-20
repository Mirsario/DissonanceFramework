using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using MI = System.Runtime.CompilerServices.MethodImplAttribute;

#pragma warning disable IDE0060 //Unused parameter.

namespace Dissonance.Framework.OpenGL
{
	public static partial class GL
	{
		#region OpenGL 1.0 + OpenGL 1.1

		[MethodImport("glGenTextures","1.0")]
		private unsafe static void GenTexturesInternal(int numTextures,[Out] uint* textures)
			=> throw new NotImplementedException();

		[MethodImport("glDeleteTextures","1.0")]
		private unsafe static void DeleteTexturesInternal(int numTextures,[Out] uint* textures)
			=> throw new NotImplementedException();

		[MethodImport("glGetString","1.0")]
		private static IntPtr GetStringInternal(StringName name)
			=> throw new NotImplementedException();

		#endregion

		#region OpenGL 3.0

		[MethodImport("glGetStringi","3.0")]
		private static IntPtr GetStringInternal(uint name,uint index)
			=> throw new NotImplementedException();

		#endregion
	}
}