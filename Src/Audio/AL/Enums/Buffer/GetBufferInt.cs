namespace Dissonance.Framework.Audio
{
	/// <summary> 32-bit int AL.GetBuffer parameters. </summary>
	public enum GetBufferInt
	{
		/// <summary> Sound frequency, or sample rate, in hertz. Half of the sample frequency is the maximum significant frequency component. </summary>
		Frequency = 0x2001,
		/// <summary> Bit depth of the buffer. </summary>
		Bits = 0x2002,
		/// <summary> Number of channels in buffer. 1 for mono, 2 for stereo. > 1 values won't have positional audio. </summary>
		Channels = 0x2003,
		/// <summary> Size of the buffer in bytes. </summary>
		Size = 0x2004
	}
}
