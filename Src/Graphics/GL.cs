using Dissonance.Engine.Graphics.Enums;
using Dissonance.Framework.Windowing;
using System;
using System.Runtime.CompilerServices;

namespace Dissonance.Framework.Graphics
{
	public static partial class GL
	{
		private const int AI = (int)MethodImplOptions.AggressiveInlining;
		private const short ImplOptions = (short)(MethodImplOptions.NoInlining|MethodImplOptions.NoOptimization);

		static GL() => DllManager.PrepareResolvers();

		public static void Load(GLVersion version)
		{
			int value = (int)version;

			DllManager.ImportTypeMethods(
				typeof(GL),
				new Version(value/10,value%10),
				function => GLFW.GetProcAddress(function)
			);
		}
	}
}
