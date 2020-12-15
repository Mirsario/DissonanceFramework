namespace Dissonance.Framework.Audio
{
	/// <summary> String AL.Get() parameters. </summary>
	public enum StateString
	{
		/// <summary> Vendor name. </summary>
		Vendor = 0xB001,
		/// <summary> Driver version. </summary>
		Version = 0xB002,
		/// <summary> Renderer mode. </summary>
		Renderer = 0xB003,
		/// <summary> List of all available extensions, separated by spaces. </summary>
		Extensions = 0xB004,
	}
}
