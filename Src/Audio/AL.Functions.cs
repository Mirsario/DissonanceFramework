namespace Dissonance.Framework.Audio
{
	partial class AL
	{
		/// <inheritdoc cref="GenSources(int, out uint)" />
		public static uint GenSource()
		{
			GenSources(1, out uint result);

			return result;
		}

		/// <inheritdoc cref="GenBuffers(int, out uint)" />
		public static uint GenBuffer()
		{
			GenBuffers(1, out uint result);

			return result;
		}

		/// <inheritdoc cref="Source(uint, SourceInt, int)" />
		public static void Source(uint sourceId, SourceBool param, bool value)
		{
			Source(sourceId, (SourceInt)param, value ? 1 : 0);
		}
	}
}
