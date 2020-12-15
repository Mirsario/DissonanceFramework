namespace Dissonance.Framework.Audio
{
	/// <summary> 32-bit integer AL.GetSource parameters. </summary>
	public enum GetSourceInt
	{
		/// <summary> Playback position in bytes. AL_EXT_OFFSET extension. </summary>
		ByteOffset = 0x1026,
		/// <summary> Playback position in samples. AL_EXT_OFFSET extension. </summary>
		SampleOffset = 0x1025,
		/// <summary> Id of source's buffer. </summary>
		Buffer = 0x1009,
		/// <summary> The source's state. Use the enum SourceType for comparison. </summary>
		SourceState = 0x1010,
		/// <summary> The number of buffers queued on this source. </summary>
		BuffersQueued = 0x1015,
		/// <summary> The number of buffers in the queue that have been processed. </summary>
		BuffersProcessed = 0x1016,
		/// <summary> Source type (static, streaming or undetermined). Use SourceType enum for comparison. </summary>
		SourceType = 0x1027
	}
}
