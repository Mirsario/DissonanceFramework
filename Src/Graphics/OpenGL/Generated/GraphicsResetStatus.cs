namespace Dissonance.Framework.Graphics.OpenGL
{
	public enum GraphicsResetStatus : uint
	{
		NoError = 0,
		GuiltyContextReset = 0x8253,
		InnocentContextReset = 0x8254,
		UnknownContextReset = 0x8255,
	}
}

