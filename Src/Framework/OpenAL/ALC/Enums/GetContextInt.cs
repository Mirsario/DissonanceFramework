namespace Dissonance.Framework.OpenAL
{
	/// <summary> 32-bit integer ALC.Getparameters. </summary>
	public enum GetContextInt
	{
		/// <summary> The major version of this implementation. NULL is an acceptable device. </summary>
		MajorVersion = 0x1000,
		/// <summary> The minor version of this implementation. NULL is an acceptable device. </summary>
		MinorVersion = 0x1001,
		/// <summary> The size required for a zero-terminated attributes list, for the current context. NULL is an invalid device. </summary>
		AttributesSize = 0x1002,
		/// <summary> Expects a destination of ALC_ATTRIBUTES_SIZE, and provides an attribute list for the current context of the specified device. NULL is an invalid device. </summary>
		AllAttributes = 0x1003,
	}
}
