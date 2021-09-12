namespace Dissonance.Framework.Audio
{
	public static partial class ALC
	{
		public const string Library = AL.Library;

		static ALC() => DllMapResolver.PrepareOwnResolver();
	}
}
