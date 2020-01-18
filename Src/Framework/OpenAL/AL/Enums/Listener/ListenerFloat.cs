namespace Dissonance.Framework.OpenAL
{
	/// <summary> 32-bit float AL.Listener/AL.GetListener parameters. </summary>
	public enum ListenerFloat
	{
		/// <summary> The volume amplification that will be applied to all audio. Range: [0.0 - ? ]. Default: 1.0f. A value of 1.0f means un-attenuated/unchanged. 
		/// Each division by 2 equals an attenuation of -6dB. Each multiplicaton with 2 equals an amplification of +6dB.
		/// A value of 0.0f disables the channel. </summary>
		Gain = 0x100A
	}
}
