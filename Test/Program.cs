using System;
using Dissonance.Framework.GLFW3;
using Dissonance.Framework.OpenGL;
using Dissonance.Framework.OpenAL;
using System.IO;

namespace Test
{
	public static class Program
	{
		public static IntPtr window;

		static void Main()
		{
			PrepareGLFW();
			PrepareOpenGL();
			PrepareOpenAL();

			var random = new Random();

			double time = 0d;
			double timePrev = 0d;

			while(GLFW.WindowShouldClose(window)==0) {
				int width = 0;
				int height = 0;

				time = GLFW.GetTime();

				double deltaTime = time-timePrev;

				timePrev = time;

				GLFW.GetFramebufferSize(window,ref width,ref height);

				GL.Viewport(0,0,width,height);

				var (colorR,colorG,colorB) = GetRainbowColor((float)time*0.75f);

				colorR = Math.Max(colorR,0.5f);
				colorG = Math.Max(colorG,0.5f);
				colorB = Math.Max(colorB,0.5f);

				GL.ClearColor(70,130,180);
				GL.Clear(ClearBufferMask.ColorBufferBit);

				GL.Color3(colorR,colorG,colorB);

				//Draw
				GL.Begin(PrimitiveType.Triangles);

				GL.Vertex3(-1.0f,-1.0f,0.0f);
				GL.Vertex3(1.0f,-1.0f,0.0f);
				GL.Vertex3(0.0f,1.0f,0.0f);

				GL.End();

				GLFW.SwapBuffers(window);
				GLFW.PollEvents();
			}

			GLFW.DestroyWindow(window);
		}

		public static float Lerp(float a,float b,float time) => a+(b-a)*Clamp01(time);
		public static float Clamp01(float value) => value<0f ? 0f : value>1f ? 1f : value;

		public static (float r,float g,float b) GetRainbowColor(float progress)
		{
			float div = Math.Abs(progress%1)*6f;
			float ascending = div%1;
			float descending = 1f-ascending;

			return (int)div switch {
				0 => (255f,ascending,0f),
				1 => (descending,255f,0f),
				2 => (0f,255f,ascending),
				3 => (0f,descending,255f),
				4 => (ascending,0f,255f),
				_ => (255f,0f,descending),
			};
		}

		private static void PrepareGLFW()
		{
			GLFW.Load();
			GLFW.Init();

			GLFW.WindowHint(GLFW.CONTEXT_VERSION_MAJOR,3); //Targeted major version
			GLFW.WindowHint(GLFW.CONTEXT_VERSION_MINOR,0); //Targeted minor version

			window = GLFW.CreateWindow(640,480,"Unnamed Window",IntPtr.Zero,IntPtr.Zero);

			GLFW.MakeContextCurrent(window);
		}
		private static void PrepareOpenGL()
		{
			GL.Load();

			CheckGLErrors();
		}
		private static void PrepareOpenAL()
		{
			var device = ALC.OpenDevice(null);
			var audioContext = ALC.CreateContext(device,new int[] { });

			if(!ALC.MakeContextCurrent(audioContext)) {
				throw new InvalidOperationException("Unable to make context current");
			}

			Console.WriteLine("Created audio context.");

			CheckALErrors();

			//Buffer
			AL.GenBuffer(out uint bufferId);

			byte[] data = File.ReadAllBytes("Audio.raw");

			AL.BufferData(bufferId,BufferFormat.Mono16,data,data.Length,44100);

			//Source
			AL.GenSource(out uint sourceId);

			AL.Source(sourceId,SourceInt.Buffer,(int)bufferId);

			AL.SourcePlay(sourceId);
		}
		private static void CheckGLErrors()
		{
			var error = GL.GetError();

			if(error!=GLDirect.NO_ERROR) {
				throw new Exception($"OpenGL Error: {error}");
			}
		}
		private static void CheckALErrors()
		{
			var error = AL.GetError();

			if(error!=AudioError.NoError) {
				throw new Exception($"OpenAL Error: {error}");
			}
		}
	}
}
