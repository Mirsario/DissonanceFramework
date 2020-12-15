namespace Dissonance.Framework.Audio
{
	/// <summary> 3D 32-bit float vector AL.Source/AL.GetSource parameters. </summary>
	public enum SourceFloat3
	{
		/// <summary> Source's current location in 3D space in right-handed coordinate system. </summary>
		Position = 0x1004,
		/// <summary> Source's current velocity in three dimensional space. </summary>
		Velocity = 0x1006,
		/// <summary> Source's current direction vector. </summary>
		Direction = 0x1005,
	}
}
