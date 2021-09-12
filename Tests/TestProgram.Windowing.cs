using System;
using Dissonance.Framework.Windowing;

namespace Test
{
	partial class TestProgram
	{
		public static IntPtr window;

		private static void PrepareGlfw()
		{
			Console.WriteLine("GLFW Preparing...");

			GLFW.SetErrorCallback((GlfwError code, string description) => Console.WriteLine(code switch {
				GlfwError.VersionUnavailable => throw new Exception(description),
				GlfwError.ApiUnavailable => throw new Exception(description),
				_ => $"GLFW Error {code}: {description}"
			}));

			if (!GLFW.Init()) {
				throw new Exception("Unable to initialize GLFW!");
			}

			GLFW.WindowHint(WindowHint.ContextVersionMajor, OpenGLVersion.Major); // Targeted major version
			GLFW.WindowHint(WindowHint.ContextVersionMinor, OpenGLVersion.Minor); // Targeted minor version
			GLFW.WindowHint(WindowHint.OpenGLProfile, GLFW.OpenGLCoreProfile);
			GLFW.WindowHint(WindowHint.OpenGLForwardCompat, true);

			IntPtr monitor = IntPtr.Zero;
			int resolutionWidth = 800;
			int resolutionHeight = 600;

			if (Fullscreen) {
				monitor = GLFW.GetPrimaryMonitor();

				var videoMode = GLFW.GetVideoMode(monitor);

				GLFW.WindowHint(WindowHint.RedBits, videoMode.RedBits);
				GLFW.WindowHint(WindowHint.GreenBits, videoMode.GreenBits);
				GLFW.WindowHint(WindowHint.BlueBits, videoMode.BlueBits);
				GLFW.WindowHint(WindowHint.RefreshRate, videoMode.RefreshRate);

				resolutionWidth = videoMode.Width;
				resolutionHeight = videoMode.Height;
			}

			window = GLFW.CreateWindow(resolutionWidth, resolutionHeight, "Unnamed Window", monitor, IntPtr.Zero);

			GLFW.MakeContextCurrent(window);

			GLFW.SwapInterval(0);
		}

		private static void UnloadGlfw()
		{
			GLFW.DestroyWindow(window);
			GLFW.Terminate();
		}
	}
}
