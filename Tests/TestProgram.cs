using System;
using System.IO;
using System.Threading;
using Dissonance.Framework.Graphics;
using Dissonance.Framework.Windowing;

namespace Test
{
	public static partial class TestProgram
	{
		public static readonly Version OpenGLVersion = new Version(3, 2);

		public static bool Fullscreen = false;

		static void Main()
		{
			Console.WriteLine($"Working directory: '{Path.GetFullPath(".")}'.");

			//PrepareGLFW();
			//PrepareOpenGL();
			PrepareOpenAL();

			//double timePrev = 0d;

			/*
			CheckGLErrors();

			float[] points = {
				 0.0f,   0.5f,  0.0f,
				 0.5f,  -0.5f,  0.0f,
				-0.5f,  -0.5f,  0.0f
			};

			uint vbo = GL.GenBuffer();
			GL.BindBuffer(BufferTarget.ArrayBuffer, vbo);
			GL.BufferData(BufferTarget.ArrayBuffer, points.Length * sizeof(float), points, BufferUsageHint.StaticDraw);

			uint vao = GL.GenVertexArray();
			GL.BindVertexArray(vao);
			GL.EnableVertexAttribArray(0);
			GL.BindBuffer(BufferTarget.ArrayBuffer, vbo);
			GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, 0, IntPtr.Zero);

			string vertexShader = @"#version 330 core
in vec3 vertex;
void main() {
	gl_Position = vec4(vertex,1.0);
}";
			string fragmentShader = @"#version 330 core
out vec4 color;
void main() {
	color = vec4(1.0,0.5,0.0,1.0);
}";

			uint vs = GL.CreateShader(ShaderType.VertexShader);
			GL.ShaderSource(vs, vertexShader);
			GL.CompileShader(vs);

			uint fs = GL.CreateShader(ShaderType.FragmentShader);
			GL.ShaderSource(fs, fragmentShader);
			GL.CompileShader(fs);

			uint program = GL.CreateProgram();
			GL.AttachShader(program, vs);
			GL.AttachShader(program, fs);
			GL.LinkProgram(program);

			while(GLFW.WindowShouldClose(window) == 0) {
				GLFW.PollEvents();

				double time = GLFW.GetTime();
				//double deltaTime = time-timePrev;
				//timePrev = time;

				GLFW.GetFramebufferSize(window, out int width, out int height);

				GL.Viewport(0, 0, width, height);

				var (colorR, colorG, colorB) = GetRainbowColor((float)time * 0.75f);

				colorR = Math.Max(colorR, 0.9f);
				colorG = Math.Max(colorG, 0.9f);
				colorB = Math.Max(colorB, 0.9f);

				GL.ClearColor(colorR, colorG, colorB); //GL.ClearColor(70/255f,130/255f,180/255f);
				GL.Clear(ClearBufferMask.ColorBufferBit);

				GL.UseProgram(program);
				GL.BindVertexArray(vao);
				GL.DrawArrays(PrimitiveType.Triangles, 0, points.Length / 3);

				GLFW.SwapBuffers(window);

				CheckGLErrors();

				Thread.Sleep(1);
			}
			*/

			Console.ReadLine();

			UnloadOpenAL();
			//UnloadGLFW();
		}

		public static float Lerp(float a, float b, float time) => a + (b - a) * Clamp01(time);
		public static float Clamp01(float value) => value < 0f ? 0f : value > 1f ? 1f : value;
	}
}
