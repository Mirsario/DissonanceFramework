namespace Dissonance.Framework.Graphics.OpenGL
{
	partial class GL
	{
		/// <inheritdoc cref="GenBuffers(int, out uint)" />
		public unsafe static uint GenBuffer()
		{
			uint result;

			GenBuffers(1, &result);

			return result;
		}

		/// <inheritdoc cref="GenVertexArray(int, out uint)" />
		public unsafe static uint GenVertexArray()
		{
			uint result;

			GenVertexArrays(1, &result);

			return result;
		}
	}
}
