using System;
using Dissonance.Framework.Graphics.OpenGL;

namespace Test
{
	partial class TestProgram
	{
		private static void PrepareOpenGL()
		{
			GL.Load(OpenGLVersion);

			Console.WriteLine("Calling GL.GetError()...");

			CheckGLErrors();

			Console.WriteLine($"Loaded OpenGL {GL.GetString(StringName.GL_VERSION)} (using {OpenGLVersion})");
		}

		private static void CheckGLErrors()
		{
			ErrorCode error = GL.GetError();

			if (error != ErrorCode.GL_NO_ERROR) {
				throw new Exception($"OpenGL Error: {error}");
			}
		}
	}
}
