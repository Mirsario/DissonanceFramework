using Dissonance.Utils;
using System;
using System.Collections.Generic;

namespace Dissonance.Framework.GLFW3
{
	public static partial class GLFW
	{
		private static readonly string[] DefaultPathsWindows = {
			"glfw3.dll"
		};
		private static readonly string[] DefaultPathsLinux = {
			"libglfw.so.3.2",
			"libglfw.so.3.1",
			"libglfw.so.3",
			"libglfw.so"
		};
		private static readonly string[] DefaultPathsOSX = {
			"libglfw3.dylib",
			"libglfw.dylib",
			"libglfw.so.3.2",
			"libglfw.so.3.1",
			"libglfw.so.3",
			"libglfw.so"
		};

		private static IntPtr glfwHandle;

		public static bool IsReady { get; private set; }

		public static void Load() => Load(DefaultPathsWindows,DefaultPathsLinux,DefaultPathsOSX);
		public static void Load(IEnumerable<string> windowsPaths,IEnumerable<string> linuxPaths,IEnumerable<string> osxPaths) 
			=> Load(InternalUtils.GetOS() switch {
				OS.Windows => windowsPaths,
				OS.Linux => linuxPaths,
				OS.OSX => osxPaths,
				_ => null
			});
		public static void Load(IEnumerable<string> osDependentPaths)
		{
			if(IsReady) {
				return;
			}

			foreach(string path in osDependentPaths) {
				try {
					glfwHandle = DllManager.DllLoad(path);
					break;
				}
				catch {}
			}

			if(glfwHandle==IntPtr.Zero) {
				throw new DllNotFoundException("Unable to locate GLFW libraries.");
			}

			DllManager.ImportTypeMethods(typeof(GLFW),functionName => DllManager.DllSymbol(glfwHandle,functionName));

			IsReady = true;
		}

		/*internal static IEnumerable<string> GetLibraryPaths()
			=> InternalUtils.GetOS() switch {
				OS.Windows => DefaultPathsWindows,
				OS.Linux => DefaultPathsLinux,
				OS.OSX => DefaultPathsOSX,
				_ => null
			};*/
	}
}
