namespace Dissonance.Framework.OpenAL
{
	/// <summary> Source state information, can be retrieved by AL.Source() with SourceInt.SourceState. </summary>
	public enum SourceState
	{
		/// <summary> Default State when loaded. Can be set with AL.SourceRewind(). </summary>
		Initial = 0x1011,
		/// <summary> The source is currently playing. </summary>
		Playing = 0x1012,
		/// <summary> The source has paused playback. </summary>
		Paused = 0x1013,
		/// <summary> The source is not playing. </summary>
		Stopped = 0x1014,
	}
}
