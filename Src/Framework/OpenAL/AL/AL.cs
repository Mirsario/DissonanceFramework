using System.Runtime.CompilerServices;

namespace Dissonance.Framework.OpenAL
{
	public static partial class AL
	{
		internal const string Library = "soft_oal.dll";

		private const int AI = (int)MethodImplOptions.AggressiveInlining;

		public static string LibraryWindows = "soft_oal.dll";
		public static string LibraryLinux = "./soft_oal.so";
		public static string LibraryMac = "./soft_oal.dylib";
	}
}
