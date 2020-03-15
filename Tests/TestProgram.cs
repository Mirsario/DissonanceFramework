using System;
using System.IO;
using Dissonance.Framework.Windowing;
using Dissonance.Framework.Graphics;
using Dissonance.Framework.Audio;
using Dissonance.Framework;
//using GL = Dissonance.Framework.OpenGL.GLNew;

namespace Test
{
	public static class TestProgram
	{
		public static bool Fullscreen = false;

		public static IntPtr window;
		public static IntPtr audioDevice;
		public static IntPtr audioContext;

		static void Main()
		{
			Console.WriteLine($"Working directory: '{Path.GetFullPath(".")}'.");

			PrepareGLFW();
			PrepareOpenGL();
			//PrepareOpenAL();

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
			Console.WriteLine("GLFW Preparing...");

			GLFW.SetErrorCallback((GLFWError code,string description) => Console.WriteLine(code switch {
				GLFWError.VersionUnavailable => throw new GraphicsException(description),
				_ => $"GLFW Error {code}: {description}"
			}));

			if(GLFW.Init()==0) {
				throw new Exception("Unable to initialize GLFW!");
			}

			GLFW.WindowHint(WindowHint.ContextVersionMajor,2); //Targeted major version
			GLFW.WindowHint(WindowHint.ContextVersionMinor,1); //Targeted minor version

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
		}
		private static void UnloadGLFW()
		{
			GLFW.DestroyWindow(window);
			GLFW.Terminate();
		}
		private static void PrepareOpenGL()
		{
			GL.Load();

			CheckGLErrors();

			Console.WriteLine($"Loaded OpenGL {GL.GetString(StringName.Version)}");
		}
		private static void PrepareOpenAL()
		{
			audioDevice = ALC.OpenDevice(null);
			audioContext = ALC.CreateContext(audioDevice,new int[] { });

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
			AL.Source(sourceId,SourceBool.Looping,true);

			AL.SourcePlay(sourceId);
		}
		private static void UnloadOpenAL()
		{
			ALC.DestroyContext(audioContext);
			ALC.CloseDevice(audioDevice);
		}
		private static void CheckGLErrors()
		{
			var error = GL.GetError();

			if(error!=GraphicsError.NoError) {
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
