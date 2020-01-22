using System.Runtime.InteropServices;
using MI = System.Runtime.CompilerServices.MethodImplAttribute;

#pragma warning disable IDE0060 //Unused parameter.

namespace Dissonance.Framework.OpenGL
{
	partial class GL
	{
		//GenTexture(s)

		[MI(AI)]
		public unsafe static uint GenTexture()
		{
			uint result;

			GenTextures(1,&result);

			return result;
		}
		[MI(AI)]
		public unsafe static void GenTextures(int numTextures,uint[] textures)
		{
			fixed (uint* ptr = &(textures!=null && textures.Length!=0 ? ref textures[0] : ref *(uint*)null)) {
				GenTextures(numTextures,ptr);
			}
		}

		//DeleteTexture(s)

		[MI(AI)]
		public unsafe static void DeleteTexture(uint texture) => DeleteTextures(1,&texture);
		[MI(AI)]
		public unsafe static void DeleteTextures(int numTextures,uint[] textures)
		{
			fixed(uint* ptr = &(textures!=null && textures.Length!=0 ? ref textures[0] : ref *(uint*)null)) {
				DeleteTextures(numTextures,ptr);
			}
		}

		//GetString

		[MI(AI)]
		public static string GetString(StringName name) => Marshal.PtrToStringAnsi(GetStringInternal(name));
	}
}