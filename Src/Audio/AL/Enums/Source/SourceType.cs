namespace Dissonance.Framework.Audio
{
	/// <summary> Source type information, can be retrieved by AL.Source() with SourceInteger.SourceType. </summary>
	public enum SourceType
	{
		/// <summary> Source is Static if a buffer has been attached using SourceInt.Buffer. </summary>
		Static = 0x1028,
		/// <summary> Source is Streaming when one or more buffers have been attached using AL.SourceQueueBuffers. </summary>
		Streaming = 0x1029,
		/// <summary> Source is undetermined when it has a null Buffer attached. </summary>
		Undetermined = 0x1030,
	}
}
