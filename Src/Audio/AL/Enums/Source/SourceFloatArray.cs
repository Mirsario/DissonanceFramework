namespace Dissonance.Framework.Audio
{
	/// <summary> 32-bit float array AL.Listener/AL.GetListener parameters. </summary>
	public enum SourceFloatArray
	{
		/// <summary> Source's current location in 3D space in right-handed coordinate system. </summary>
		Position = 0x1004,
		/// <summary> Source's current velocity in three dimensional space. </summary>
		Velocity = 0x1006,
		/// <summary> Source's current direction vector. </summary>
		Direction = 0x1005,
	}
}
