namespace Dissonance.Framework.Audio
{
	/// <summary> 32-bit float array AL.Listener/AL.GetListener parameters. </summary>
	public enum ListenerFloatArray
	{
		/// <summary> Listener's current location in 3D space in right-handed coordinate system. </summary>
		Position = 0x1004,
		/// <summary> Listener's current velocity in three dimensional space. </summary>
		Velocity = 0x1006,
		/// <summary> Listener's orientation. Expects two 3D vectors, Forward and Up.</summary>
		Orientation = 0x100F
	}
}
