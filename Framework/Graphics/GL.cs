using Dissonance.Framework.Windowing;
using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Dissonance.Framework.Graphics
{
	public static partial class GL
	{
		private const short ImplOptions = (short)(MethodImplOptions.AggressiveInlining|MethodImplOptions.AggressiveOptimization);

		public static readonly Version[] SupportedVersions = new Version[] {
			//1.0+
			new Version(1,0),
			new Version(1,1),
			new Version(1,2),
			new Version(1,3),
			new Version(1,4),
			new Version(1,5),
			//2.0+
			new Version(2,0),
			new Version(2,1),
			//3.0+
			new Version(3,0),
			new Version(3,1),
			new Version(3,2),
			new Version(3,3),
			//4.0+
			new Version(4,0),
			new Version(4,1),
			new Version(4,2),
			new Version(4,3),
			new Version(4,4),
			new Version(4,5),
			//new Version(4,6)
		};

		static GL() => DllManager.PrepareResolvers();

		public static void Load(Version version)
		{
			if(!SupportedVersions.Contains(version)) {
				throw new InvalidOperationException($"OpenGL version '{version}' is unknown or not supported. The following versions are supported:\r\n{string.Join("\r\n",GL.SupportedVersions.Select(v => $"{v};"))}.");
			}

			DllManager.ImportTypeMethods(typeof(GL),version,function => GLFW.GetProcAddress(function));
		}
	}
}
