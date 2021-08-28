using System.Runtime.CompilerServices;

namespace Dissonance.Framework.Audio
{
	public static partial class AL
	{
		internal const string Library = "soft_oal.dll";

		private const int AI = (int)MethodImplOptions.AggressiveInlining;

		static AL() => DllMapResolver.PrepareOwnResolver();
	}
}
