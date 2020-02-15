namespace Dissonance.Framework.Windowing
{
	/// <summary> GLFW error codes, used in <see cref="GLFW.ErrorCallback"/>. </summary>
	public enum GLFWError
	{
		/// <summary> No error. </summary>
		NoError = 0,
		/// <summary> A GLFW function was called that must not be called before GLFW is initialized. </summary>
		NotInitialized = 65537,
		/// <summary> This occurs if a GLFW function was called that needs and operates on the current OpenGL context but no context is current on the calling thread. </summary>
		NoCurrentContext = 65538,
		/// <summary> An invalid enum parameter has been passed to a GLFW call. </summary>
		InvalidEnum = 65539,
		/// <summary> An invalid value has been passed to a GLFW call. </summary>
		InvalidValue = 65540,
		/// <summary> A memory allocation failed. </summary>
		OutOfMemory = 65541,
		/// <summary> GLFW could not find support for the requested API on the system. </summary>
		APIUnavailable = 65542,
		/// <summary> The requested OpenGL or OpenGL ES version (including any requested context or framebuffer hints) is not available on this machine. </summary>
		VersionUnavailable = 65543,
		/// <summary> A platform-specific error occurred that does not match any of the more specific categories. </summary>
		PlatformError = 65544,
		/// <summary> If emitted during window creation, the requested pixel format is not supported; If emitted when querying the clipboard, the contents of the clipboard could not be converted to the requested format. </summary>
		FormatUnavailable = 65545,
		/// <summary> A window that does not have an OpenGL context was passed to a function that requires it to have one. </summary>
		NoWindowContext = 65546,
	}
}
