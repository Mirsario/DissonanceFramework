namespace Dissonance.Framework.OpenAL
{
	/// <summary> String ALC.Get() parameters. </summary>
	public enum GetContextString
	{
		/// <summary> List of all available context extensions, separated by spaces. </summary>
		Extensions = 0x1006,
		/// <summary> Gets the name of the provided device. </summary>
		DeviceSpecifier = 0x1005,
	}
}
