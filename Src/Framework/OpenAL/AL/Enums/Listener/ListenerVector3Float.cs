﻿namespace Dissonance.Framework.OpenAL
{
	/// <summary> 3D 32-bit float vector AL.Listener/AL.GetListener parameters. </summary>
	public enum ListenerVector3Float
	{
		/// <summary> Listener's current location in 3D space in right-handed coordinate system. </summary>
		Position = 0x1004,
		/// <summary> Listener's current velocity in three dimensional space. </summary>
		Velocity = 0x1006,
	}
}
