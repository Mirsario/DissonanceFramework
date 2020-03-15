using Dissonance.Framework.Windowing;
using System.Runtime.CompilerServices;

namespace Dissonance.Framework.Graphics
{
	public static partial class GL
	{
		private const int AI = (int)MethodImplOptions.AggressiveInlining;
		private const short ImplOptions = (short)(MethodImplOptions.NoInlining|MethodImplOptions.NoOptimization);

		static GL() => DllManager.PrepareResolvers();

		public static void Load() => DllManager.ImportTypeMethods(typeof(GL),functionName => GLFW.GetProcAddress(functionName));
	}
}
