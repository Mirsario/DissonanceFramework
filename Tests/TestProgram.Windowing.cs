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

			Glfw.SetErrorCallback((GlfwError code, string description) => Console.WriteLine(code switch {
				GlfwError.VersionUnavailable => throw new Exception(description),
				GlfwError.ApiUnavailable => throw new Exception(description),
				_ => $"GLFW Error {code}: {description}"
			}));

			if (!Glfw.Init()) {
				throw new Exception("Unable to initialize GLFW!");
			}

			Glfw.WindowHint(WindowHint.ContextVersionMajor, OpenGLVersion.Major); // Targeted major version
			Glfw.WindowHint(WindowHint.ContextVersionMinor, OpenGLVersion.Minor); // Targeted minor version
			Glfw.WindowHint(WindowHint.OpenGLProfile, Glfw.OpenGLCoreProfile);
			Glfw.WindowHint(WindowHint.OpenGLForwardCompat, true);

			IntPtr monitor = IntPtr.Zero;
			int resolutionWidth = 800;
			int resolutionHeight = 600;

			if (Fullscreen) {
				monitor = Glfw.GetPrimaryMonitor();

				var videoMode = Glfw.GetVideoMode(monitor);

				Glfw.WindowHint(WindowHint.RedBits, videoMode.RedBits);
				Glfw.WindowHint(WindowHint.GreenBits, videoMode.GreenBits);
				Glfw.WindowHint(WindowHint.BlueBits, videoMode.BlueBits);
				Glfw.WindowHint(WindowHint.RefreshRate, videoMode.RefreshRate);

				resolutionWidth = videoMode.Width;
				resolutionHeight = videoMode.Height;
			}

			window = Glfw.CreateWindow(resolutionWidth, resolutionHeight, "Unnamed Window", monitor, IntPtr.Zero);

			Glfw.MakeContextCurrent(window);

			Glfw.SwapInterval(0);
		}

		private static void UnloadGlfw()
		{
			Glfw.DestroyWindow(window);
			Glfw.Terminate();
		}
	}
}
