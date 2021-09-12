namespace Dissonance.Framework.Audio
{
	public static partial class AL
	{
		public const string Library = "soft_oal.dll";

		static AL() => DllMapResolver.PrepareOwnResolver();
	}
}
