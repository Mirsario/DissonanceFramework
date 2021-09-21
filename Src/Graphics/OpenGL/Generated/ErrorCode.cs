namespace Dissonance.Framework.Graphics.OpenGL
{
	public enum ErrorCode : uint
	{
		NoError = 0,
		InvalidEnum = 0x0500,
		InvalidValue = 0x0501,
		InvalidOperation = 0x0502,
		StackOverflow = 0x0503,
		StackUnderflow = 0x0504,
		OutOfMemory = 0x0505,
		InvalidFramebufferOperation = 0x0506,
		InvalidFramebufferOperationExt = 0x0506,
		InvalidFramebufferOperationOes = 0x0506,
		TableTooLargeExt = 0x8031,
		TableTooLarge = 0x8031,
		TextureTooLargeExt = 0x8065,
	}
}

