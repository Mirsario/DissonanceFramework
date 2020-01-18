namespace Dissonance.Framework.OpenAL
{
	/// <summary> 32-bit integer AL.DistanceModel() parameters. The current distance model can be retrieved by calling <see cref="AL.Get(StateInt)"/> with <see cref="StateInt.DistanceModel"/>. </summary>
	public enum DistanceModel
	{
		/// <summary> No distance-based attenuation. </summary>
		None = 0,
		/// <summary> Equivalent of the IASIG I3DL2 model, with the exception that SourceFloat.ReferenceDistance does not imply any clamping. </summary>
		InverseDistance = 0xD001,
		/// <summary> The IASIG I3DL2 model, with SourceFloat.ReferenceDistance indicating both the reference distance and the distance below which gain will be clamped. </summary>
		InverseDistanceClamped = 0xD002,
		/// <summary>  Linear attenuation with no clamping. </summary>
		LinearDistance = 0xD003,
		/// <summary> Linear attenuation with clamping. </summary>
		LinearDistanceClamped = 0xD004,
		/// <summary> Exponential attenuation with no clamping.</summary>
		ExponentDistance = 0xD005,
		/// <summary> Exponential attenuation with clamping.</summary>
		ExponentDistanceClamped = 0xD006,
	}
}
