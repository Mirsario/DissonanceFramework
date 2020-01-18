namespace Dissonance.Framework.OpenAL
{
	/// <summary> Buffer Formats, to be used in AL.BufferData. </summary>
	public enum BufferFormat
	{
		/// <summary> 1 channel, 8 bits per sample. </summary>
		Mono8 = 0x1100,
		/// <summary> 1 channel, 16 bits per sample. </summary>
		Mono16 = 0x1101,
		/// <summary>  2 channels, 8 bits per sample each. </summary>
		Stereo8 = 0x1102,
		/// <summary>  2 channels, 16 bits per sample each. </summary>
		Stereo16 = 0x1103,
	}
}
