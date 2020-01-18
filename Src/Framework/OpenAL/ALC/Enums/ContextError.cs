namespace Dissonance.Framework.OpenAL
{
	/// <summary> OpenAL context errors. </summary>
	public enum ContextError
	{
		/// <summary> No audio context error. </summary>
		NoError = 0,
		/// <summary> Device is missing or invalid. The device handle or specifier names an inaccessible driver/server. </summary>
		InvalidDevice = 0xA001,
		/// <summary> An invalid context parameter has been passed to an ALC call. </summary>
		InvalidContext = 0xA002,
		/// <summary> An invalid enum parameter has been passed to an ALC call. </summary>
		InvalidEnum = 0xA003,
		/// <summary> An invalid value has been passed to an ALC call. </summary>
		InvalidValue = 0xA004,
		/// <summary> OpenAL has been unable to allocate enough memory. </summary>
		OutOfMemory = 0xA005
	}
}
