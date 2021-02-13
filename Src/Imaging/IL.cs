namespace Dissonance.Framework.Imaging
{
	public static partial class IL
	{
		internal const string Library = "DevIL.dll";

		static IL() => DllManager.PrepareResolver();
	}
}
