using System;
using System.Collections.Generic;
using System.Text;

namespace Dissonance.Framework.GLFW3
{
	public enum WindowHint
	{
		/// <summary> Input focus window hint and attribute. </summary>
		Focused = 131073,
		/// <summary> Window resize-ability window hint and attribute. </summary>
		Resizable = 131075,
		/// <summary> Window visibility window hint and attribute. </summary>
		Visible = 131076,
		/// <summary> Window decoration window hint and attribute. </summary>
		Decorated = 131077,
		/// <summary> Window auto-iconification window hint and attribute. </summary>
		AutoIconify = 131078,
		/// <summary> Window decoration window hint and attribute. </summary>
		Floating = 131079,
		/// <summary> Window maximization window hint and attribute. </summary>
		Maximized = 131080,
		/// <summary> Window framebuffer transparency hint and attribute. </summary>
		TransparentFramebuffer = 131082,
		/// <summary> Input focus on calling show window hint and attribute. </summary>
		FocusOnShow = 131084,
		/// <summary> Framebuffer bit depth hint. </summary>
		RedBits = 135169,
		/// <summary> Framebuffer bit depth hint. </summary>
		GreenBits = 135170,
		/// <summary> Framebuffer bit depth hint. </summary>
		BlueBits = 135171,
		/// <summary> Framebuffer bit depth hint. </summary>
		AlphaBits = 135172,
		/// <summary> Framebuffer bit depth hint. </summary>
		DepthBits = 135173,
		/// <summary> Framebuffer bit depth hint. </summary>
		StencilBits = 135174,
		/// <summary> Framebuffer bit depth hint. </summary>
		AccumRedbits = 135175,
		/// <summary> Framebuffer bit depth hint. </summary>
		AccumGreenBits = 135176,
		/// <summary> Framebuffer bit depth hint. </summary>
		AccumBlueBits = 135177,
		/// <summary> Framebuffer bit depth hint. </summary>
		AccumAlphaBits = 135178,
		/// <summary> Framebuffer auxiliary buffer hint. </summary>
		AuxBuffers = 135179,
		/// <summary> OpenGL stereoscopic rendering hint. </summary>
		Stereo = 135180,
		/// <summary> Framebuffer msaa samples hint. </summary>
		Samples = 135181,
		/// <summary> Framebuffer srgb hint. </summary>
		SrgbCapable = 135182,
		/// <summary> Monitor refresh rate hint. </summary>
		RefreshRate = 135183,
		/// <summary> Framebuffer double buffering hint. </summary>
		DoubleBuffer = 135184,
		/// <summary> Context client api hint and attribute. </summary>
		ClientAPI = 139265,
		/// <summary> Context client api major version hint and attribute. </summary>
		ContextVersionMajor = 139266,
		/// <summary> Context client api minor version hint and attribute. </summary>
		ContextVersionMinor = 139267,
		/// <summary> Context client api revision number hint and attribute. </summary>
		ContextRevision = 139268,
		/// <summary> Context robustness hint and attribute. </summary>
		ContextRobustness = 139269,
		/// <summary> OpenGL forward-compatibility hint and attribute. </summary>
		OpenGLForwardCompat = 139270,
		/// <summary> OpenGL debug context hint and attribute. </summary>
		OpenGLDebugContext = 139271,
		/// <summary> OpenGL profile hint and attribute. </summary>
		OpenGLProfile = 139272,
		/// <summary> Context flush-on-release hint and attribute. </summary>
		ContextReleaseBehavior = 139273,
		/// <summary> Context error suppression hint and attribute. </summary>
		ContextNoError = 139274,
		/// <summary> Context creation api hint and attribute. </summary>
		ContextCreationAPI = 139275,
		/// <summary> Window content area scaling window window hint. </summary>
		ScaleToMonitor = 139276,
		/// <summary> MacOS specific window hint. </summary>
		CocoaRetinaFramebuffer = 143361,
		/// <summary> MacOS specific window hint. </summary>
		CocoaFrameName = 143362,
		/// <summary> MacOS specific window hint. </summary>
		CocoaGraphicsSwitching = 143363,
		/// <summary> X11 specific window hint. </summary>
		X11ClassName = 147457,
		/// <summary> X11 specific window hint. </summary>
		X11InstanceName = 147458
	}
}
