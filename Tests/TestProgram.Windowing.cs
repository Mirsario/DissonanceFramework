using System;
using System.IO;
using Dissonance.Framework.Graphics;
using Dissonance.Framework.Windowing;

namespace Test
{
	partial class TestProgram
	{
		public static IntPtr window;

		private static void PrepareGLFW()
		{
			Console.WriteLine("GLFW Preparing...");

			GLFW.SetErrorCallback((GLFWError code,string description) => Console.WriteLine(code switch {
				GLFWError.VersionUnavailable => throw new GraphicsException(description),
				GLFWError.APIUnavailable => throw new GraphicsException(description),
				_ => $"GLFW Error {code}: {description}"
			}));

			if(GLFW.Init()==0) {
				throw new Exception("Unable to initialize GLFW!");
			}

			GLFW.WindowHint(WindowHint.ContextVersionMajor,OpenGLVersion.Major); //Targeted major version
			GLFW.WindowHint(WindowHint.ContextVersionMinor,OpenGLVersion.Minor); //Targeted minor version
			GLFW.WindowHint(WindowHint.OpenGLProfile,GLFW.OPENGL_CORE_PROFILE);
			GLFW.WindowHint(WindowHint.OpenGLForwardCompat,1);

			IntPtr monitor = IntPtr.Zero;
			int resolutionWidth = 800;
			int resolutionHeight = 600;

			if(Fullscreen) {
				monitor = GLFW.GetPrimaryMonitor();

				var videoMode = GLFW.GetVideoMode(monitor);

				GLFW.WindowHint(WindowHint.RedBits,videoMode.redBits);
				GLFW.WindowHint(WindowHint.GreenBits,videoMode.greenBits);
				GLFW.WindowHint(WindowHint.BlueBits,videoMode.blueBits);
				GLFW.WindowHint(WindowHint.RefreshRate,videoMode.refreshRate);

				resolutionWidth = videoMode.width;
				resolutionHeight = videoMode.height;
			}

			window = GLFW.CreateWindow(resolutionWidth,resolutionHeight,"Unnamed Window",monitor,IntPtr.Zero);

			GLFW.MakeContextCurrent(window);

			GLFW.SwapInterval(0);
		}
		private static void UnloadGLFW()
		{
			GLFW.DestroyWindow(window);
			GLFW.Terminate();
		}
	}
}
