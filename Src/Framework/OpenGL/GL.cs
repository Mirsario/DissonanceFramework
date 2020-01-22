using Dissonance.Framework.GLFW3;
using System.Runtime.CompilerServices;

namespace Dissonance.Framework.OpenGL
{
	public static partial class GL
	{
		private const int AI = (int)MethodImplOptions.AggressiveInlining;

		static GL() => DllManager.PrepareResolvers();

		public static void Load() => DllManager.ImportTypeMethods(typeof(GL),functionName => GLFW.GetProcAddress(functionName));
	}
}
