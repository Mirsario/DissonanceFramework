namespace Dissonance.Framework.OpenAL
{
	/// <summary> 32-bit integer AL.Source/AL.GetSource parameters. </summary>
	public enum SourceInt
	{
		/// <summary> Playback position in bytes. AL_EXT_OFFSET extension. </summary>
		ByteOffset = 0x1026,
		/// <summary> Playback position in samples. AL_EXT_OFFSET extension. </summary>
		SampleOffset = 0x1025,
		/// <summary> Id of source's buffer. </summary>
		Buffer = 0x1009,
		/// <summary> Source's type (static, streaming, or undetermined). </summary>
		SourceType = 0x1027,
	}
}
