namespace Dissonance.Framework.Graphics.OpenGL
{
	public enum FramebufferStatus : uint
	{
		FramebufferUndefined = 0x8219,
		FramebufferComplete = 0x8CD5,
		FramebufferIncompleteAttachment = 0x8CD6,
		FramebufferIncompleteMissingAttachment = 0x8CD7,
		FramebufferIncompleteDrawBuffer = 0x8CDB,
		FramebufferIncompleteReadBuffer = 0x8CDC,
		FramebufferUnsupported = 0x8CDD,
		FramebufferIncompleteMultisample = 0x8D56,
		FramebufferIncompleteLayerTargets = 0x8DA8,
	}
}

