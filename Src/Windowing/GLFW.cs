namespace Dissonance.Framework.Windowing
{
	public static partial class GLFW
	{
		internal const string Library = "glfw3.dll";

		static GLFW() => DllMapResolver.PrepareOwnResolver();
	}
}
