namespace Dissonance.Framework.Graphics.OpenGL
{
	public enum StencilOp : uint
	{
		Zero = 0,
		Invert = 0x150A,
		Keep = 0x1E00,
		Replace = 0x1E01,
		Incr = 0x1E02,
		Decr = 0x1E03,
		IncrWrap = 0x8507,
		DecrWrap = 0x8508,
	}
}

