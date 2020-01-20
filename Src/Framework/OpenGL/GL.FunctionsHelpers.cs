using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using MI = System.Runtime.CompilerServices.MethodImplAttribute;

namespace Dissonance.Framework.OpenGL
{
	partial class GL
	{
		#region OpenGL 1.0 + OpenGL 1.1

		[MI(AI)] public unsafe static uint GenTexture()
		{
			uint result;

			GenTexturesInternal(1,&result);

			return result;
		}
		[MI(AI)] public unsafe static void GenTextures(int numTextures,[Out] uint[] textures)
		{
			fixed(uint* ptr = &(textures!=null && textures.Length!=0 ? ref textures[0] : ref *(uint*)null)) {
				GenTexturesInternal(numTextures,ptr);
			}
		}

		[MI(AI)] public unsafe static void DeleteTexture(uint texture) => DeleteTexturesInternal(1,&texture);

		[MI(AI)] public static string GetString(StringName name) => Marshal.PtrToStringAnsi(GetStringInternal(name));

		#endregion

		#region OpenGL 3.0



		#endregion
	}
}
