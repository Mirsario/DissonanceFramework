namespace Dissonance.Framework.OpenAL
{
	/// <summary> OpenAL errors, returned by AL.GetError. </summary>
	public enum AudioError
	{
		/// <summary> No audio error. </summary>
		NoError = 0x0000,
		/// <summary> An invalid name parameter has been passed to an OpenAL call. </summary>
		InvalidName = 0xA001,
		/// <summary> An invalid enum parameter has been passed to an OpenAL call. </summary>
		InvalidEnum = 0xA002,
		/// <summary> An invalid value has been passed to an OpenAL call. </summary>
		InvalidValue = 0xA003,
		/// <summary> Invalid OpenAL call. </summary>
		InvalidOperation = 0xA004,
		/// <summary> OpenAL has run out of memory. </summary>
		OutOfMemory = 0xA005
	}
}
