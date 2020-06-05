using System;
using System.IO;
using Dissonance.Framework.Graphics;
using Dissonance.Framework.Windowing;

namespace Test
{
	partial class TestProgram
	{
		private static void PrepareOpenGL()
		{
			GL.Load(OpenGLVersion);

			Console.WriteLine("Calling GL.GetError()...");

			CheckGLErrors();

			Console.WriteLine($"Loaded OpenGL {GL.GetString(StringName.Version)} (using {OpenGLVersion})");
		}
		private static void CheckGLErrors()
		{
			var error = GL.GetError();

			if(error!=GraphicsError.NoError) {
				throw new Exception($"OpenGL Error: {error}");
			}
		}
		private static (float r, float g, float b) GetRainbowColor(float progress)
		{
			float div = Math.Abs(progress%1)*6f;
			float ascending = div%1;
			float descending = 1f-ascending;

			return (int)div switch
			{
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
