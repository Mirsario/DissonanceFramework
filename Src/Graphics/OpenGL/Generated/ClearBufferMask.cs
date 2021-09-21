namespace Dissonance.Framework.Graphics.OpenGL
{
	public enum ClearBufferMask : uint
	{
		DepthBufferBit = 0x00000100,
		AccumBufferBit = 0x00000200,
		StencilBufferBit = 0x00000400,
		ColorBufferBit = 0x00004000,
		CoverageBufferBitNv = 0x00008000,
	}
}

