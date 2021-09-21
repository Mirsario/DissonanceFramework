using System;
using System.IO;
using System.Threading;
using Dissonance.Framework.Graphics.OpenGL;
using Dissonance.Framework.Windowing;

namespace Test
{
	public static partial class TestProgram
	{
		public static readonly Version OpenGLVersion = new Version(3, 2);

		public static bool Fullscreen = false;

		unsafe static void Main()
		{
			Console.WriteLine($"Working directory: '{Path.GetFullPath(".")}'.");

			PrepareOpenAL();
			PrepareGlfw();
			PrepareOpenGL();

			Span<float> points = stackalloc[] {
				 0.0f,   0.5f,  0.0f,
				 0.5f,  -0.5f,  0.0f,
				-0.5f,  -0.5f,  0.0f
			};

			uint vbo = GL.GenBuffer();

			fixed (float* pointsPtr = points) {
				GL.BindBuffer(BufferTargetARB.ArrayBuffer, vbo);
				GL.BufferData(BufferTargetARB.ArrayBuffer, (IntPtr)(points.Length * sizeof(float)), pointsPtr, BufferUsageARB.StaticDraw);
			}

			uint vao = GL.GenVertexArray();

			GL.BindVertexArray(vao);
			GL.EnableVertexAttribArray(0);
			GL.BindBuffer(BufferTargetARB.ArrayBuffer, vbo);
			GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, 0, null);

			string vertexShader = @"
#version 330 core
in vec3 vertex;
void main() {
	gl_Position = vec4(vertex,1.0);
}";
			string fragmentShader = @"
#version 330 core
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

			while(Glfw.WindowShouldClose(window) == 0) {
				Glfw.PollEvents();

				double time = Glfw.GetTime();
				//double deltaTime = time-timePrev;
				//timePrev = time;

				Glfw.GetFramebufferSize(window, out int width, out int height);

				GL.Viewport(0, 0, width, height);

				var (colorR, colorG, colorB) = GetRainbowColor((float)time * 0.75f);

				colorR = Math.Max(colorR, 0.9f);
				colorG = Math.Max(colorG, 0.9f);
				colorB = Math.Max(colorB, 0.9f);

				GL.ClearColor(colorR, colorG, colorB, 1f);
				GL.Clear(ClearBufferMask.ColorBufferBit);

				GL.UseProgram(program);
				GL.BindVertexArray(vao);
				GL.DrawArrays(PrimitiveType.Triangles, 0, points.Length / 3);

				Glfw.SwapBuffers(window);

				CheckGLErrors();

				Thread.Sleep(1);
			}

			Console.ReadLine();

			UnloadOpenAL();
			UnloadGlfw();
		}

		private static (float r, float g, float b) GetRainbowColor(float progress)
		{
			float div = Math.Abs(progress % 1) * 6f;
			float ascending = div % 1;
			float descending = 1f - ascending;

			return (int)div switch {
				0 => (255f, ascending, 0f),
				1 => (descending, 255f, 0f),
				2 => (0f, 255f, ascending),
				3 => (0f, descending, 255f),
				4 => (ascending, 0f, 255f),
				_ => (255f, 0f, descending),
			};
		}
	}
}
