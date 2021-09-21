namespace Dissonance.Framework.Graphics.OpenGL
{
	public enum CopyImageSubDataTarget : uint
	{
		Texture1d = 0x0DE0,
		Texture2d = 0x0DE1,
		Texture3d = 0x806F,
		TextureRectangle = 0x84F5,
		TextureCubeMap = 0x8513,
		Texture1dArray = 0x8C18,
		Texture2dArray = 0x8C1A,
		Renderbuffer = 0x8D41,
		TextureCubeMapArray = 0x9009,
		Texture2dMultisample = 0x9100,
		Texture2dMultisampleArray = 0x9102,
	}
}

