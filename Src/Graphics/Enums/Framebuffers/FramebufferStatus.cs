namespace Dissonance.Framework.Graphics
{
	public enum FramebufferStatus
	{
		/// <summary> No framebuffer has been defined. </summary>
		FramebufferUndefined = 33305,

		/// <summary> No error. The framebuffer is complete. </summary>
		FramebufferComplete = 36053,

		/// <summary> An attachment could not be bound to frame buffer object. </summary>
		FramebufferIncompleteAttachment = 36054,

		/// <summary> Attachments are missing. At least one texture must be bound to the framebuffer object. </summary>
		FramebufferIncompleteMissingAttachment = 36055,

		/// <summary> The dimensions of the buffers attached to the currently used framebuffer object do not match. </summary>
		FramebufferIncompleteDimensionsExt = 36057,

		/// <summary> The formats of the currently used frame buffer object are not supported or do not fit together. </summary>
		FramebufferIncompleteFormatsExt = 36058,

		/// <summary> A Draw buffer is incomplete or undefinied. All draw buffers must specify attachment points that have textures attached. </summary>
		FramebufferIncompleteDrawBuffer = 36059,

		/// <summary> A Read buffer is incomplete or undefinied. All read buffers must specify attachment points that have textures attached. </summary>
		FramebufferIncompleteReadBuffer = 36060,

		/// <summary> Attempted to use an unsupported format combinaton. </summary>
		FramebufferUnsupported = 36061,

		/// <summary> All textures must have the same number of multisample samples. </summary>
		FramebufferIncompleteMultisample = 36182,

		/// <summary> If a layered image is attached to one attachment, then all attachments must be layered attachments. The attached layers do not have to have the same number of layers, nor do the layers have to come from the same kind of texture. </summary>
		FramebufferIncompleteLayerTargets = 36264
	}
}
