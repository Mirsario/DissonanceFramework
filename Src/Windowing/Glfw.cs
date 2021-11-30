namespace Dissonance.Framework.Windowing
{
	public static partial class Glfw
	{
		public const string Library = "glfw3.dll";

		static Glfw() => DllMapResolver.PrepareOwnResolver();

		// Below are methods which are added for the sake of comfort.

		/// <inheritdoc cref="WindowHint(WindowHint, int)" />
		public static void WindowHint(WindowHint hint, bool value)
			=> WindowHint(hint, value ? 1 : 0);
	}
}
