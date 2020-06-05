using System;
using System.IO;
using Dissonance.Framework.Graphics;
using Dissonance.Framework.Windowing;

namespace Test
{
	public static partial class TestProgram
	{
		public static readonly Version OpenGLVersion = new Version(2,1);

		public static bool Fullscreen = false;

		static void Main()
		{
			Console.WriteLine($"Working directory: '{Path.GetFullPath(".")}'.");

			PrepareGLFW();
			PrepareOpenGL();
			PrepareOpenAL();

			//double timePrev = 0d;

			CheckGLErrors();

			while(GLFW.WindowShouldClose(window)==0) {
				double time = GLFW.GetTime();
				//double deltaTime = time-timePrev;
				//timePrev = time;

				GLFW.GetFramebufferSize(window,out int width,out int height);

				GL.Viewport(0,0,width,height);

				var (colorR,colorG,colorB) = GetRainbowColor((float)time*0.75f);

				colorR = Math.Max(colorR,0.5f);
				colorG = Math.Max(colorG,0.5f);
				colorB = Math.Max(colorB,0.5f);

				GL.ClearColor(70/255f,130/255f,180/255f);
				GL.Clear(ClearBufferMask.ColorBufferBit);

				GL.Color3(colorR,colorG,colorB);

				//Draw
				GL.Begin(PrimitiveType.Triangles);

				GL.Vertex3(-1.0f,-1.0f, 0.0f);
				GL.Vertex3( 1.0f,-1.0f, 0.0f);
				GL.Vertex3( 0.0f, 1.0f, 0.0f);

				GL.End();

				GLFW.SwapBuffers(window);
				GLFW.PollEvents();
			}

			UnloadOpenAL();
			UnloadGLFW();
		}

		public static float Lerp(float a,float b,float time) => a+(b-a)*Clamp01(time);
		public static float Clamp01(float value) => value<0f ? 0f : value>1f ? 1f : value;
	}
}
