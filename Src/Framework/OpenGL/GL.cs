using Dissonance.Framework.GLFW3;
using System;

namespace Dissonance.Framework.OpenGL
{
	public static partial class GL
	{
		static GL() => DllManager.PrepareResolvers();

		public static void Load()
		{
			var thisType = typeof(GL);

			/*if(!GLFW.IsReady) {
				throw new InvalidOperationException($"'{nameof(GL)}.{nameof(Load)}()' must be called after '{nameof(GLFW)}.{nameof(GLFW.Load)}()'.");
			}*/

			DllManager.ImportTypeMethods(typeof(GL),functionName => GLFW.GetProcAddress(functionName));
		}
	}
}
