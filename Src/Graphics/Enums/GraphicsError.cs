namespace Dissonance.Framework.Graphics
{
	/// <summary> OpenGL errors, returned by GL.GetError. </summary>
	public enum GraphicsError
	{
		/// <summary> No graphics errors have occured. </summary>
		NoError = 0,
		/// <summary> An invalid enum parameter has been passed to an OpenGL call. </summary>
		InvalidEnum = 1280,
		/// <summary> An invalid value has been passed to an OpenGL call. </summary>
		InvalidValue = 1281,
		/// <summary> Invalid OpenGL call. </summary>
		InvalidOperation = 1282,
		/// <summary> OpenGL has run out of memory. </summary>
		OutOfMemory = 1285,
		InvalidFramebufferOperation = 1286,
		InvalidFramebufferOperationExt = 1286,
		InvalidFramebufferOperationOes = 1286,
		ContextLost = 1287,
		TableTooLarge = 32817,
		TableTooLargeExt = 32817,
		TextureTooLargeExt = 32869
	}
}
