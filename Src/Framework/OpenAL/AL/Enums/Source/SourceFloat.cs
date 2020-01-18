namespace Dissonance.Framework.OpenAL
{
	/// <summary> 32-bit float AL.Source/AL.GetSource parameters. </summary>
	public enum SourceFloat
	{
		/// <summary> Source specific reference distance. Range: [0.0 - float.PositiveInfinity]. Default: 1.0f. </summary>
		ReferenceDistance = 0x1020,
		/// <summary> Distance, above which sources are not attenuated using the inverse clamped distance model. Range: [0.0 - float.PositiveInfinity]. Default: float.PositiveInfinity. </summary>
		MaxDistance = 0x1023,
		/// <summary> Source specific rolloff factor. Range: [0.0 - float.PositiveInfinity]. </summary>
		RolloffFactor = 0x1021,
		/// <summary> Source's pitch, to be applied, either at source, or on mixer results, at listener. Range: [0.5 - 2.0]. Default: 1.0f. </summary>
		Pitch = 0x1003,
		/// <summary> The volume amplification that will be applied to this source's audio. Range: [0.0 - ? ]. Default: 1.0f. A value of 1.0f means un-attenuated/unchanged. 
		/// Each division by 2 equals an attenuation of -6dB. Each multiplicaton with 2 equals an amplification of +6dB.
		/// A value of 0.0f disables the channel. </summary>
		Gain = 0x100A,
		/// <summary> Indicate minimum Source attenuation. Range: [0.0 - 1.0] (Logarthmic). </summary>
		MinGain = 0x100D,
		/// <summary> Indicate maximum Source attenuation. [0.0f - 1.0f] (Logarthmic). </summary>
		MaxGain = 0x100E,
		/// <summary> Directional Source, inner cone angle, in degrees. Range: [0.0 - 360]. Default: 360f. </summary>
		ConeInnerAngle = 0x1001,
		/// <summary> Directional Source, outer cone angle, in degrees. Range: [0.0 - 360]. Default: 360. </summary>
		ConeOuterAngle = 0x1002,
		/// <summary> Directional Source, outer cone gain. Default: 0.0f Range: [0.0 - 1.0]. (Logarithmic). </summary>
		ConeOuterGain = 0x1022,
		/// <summary> The playback position in seconds. </summary>
		SecOffset = 0x1024,
	}
}
