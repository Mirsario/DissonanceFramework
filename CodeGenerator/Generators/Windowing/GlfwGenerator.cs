using System;
using CodeGenerator.Converters;
using CodeGenerator.Utilities;
using CppAst;
using CppAst.CodeGen.CSharp;

namespace CodeGenerator.Generators.Windowing
{
	public class GlfwGenerator : CppGenerator
	{
		public GlfwGenerator() : base()
		{
			Options.DefaultNamespace = "Dissonance.Framework.Windowing";
			Options.DefaultClassLib = "GLFW";
			Options.DefaultOutputFilePath = "GLFW.Generated.cs";
			Options.DefaultDllImportNameAndArguments = "Library";

			static CppElementMappingRule ParameterToBool(CppElementMappingRule e)
				=> e.ParameterType(CSharpPrimitiveType.Bool()).MarshalAs(CSharpUnmanagedKind.I4);

			static CppElementMappingRule ReturnToBool(CppElementMappingRule e)
				=> e.ReturnType(CSharpPrimitiveType.Bool()).MarshalAs(CSharpUnmanagedKind.I4);

			static string EnumItemNaming(string name)
				=> StringUtils.SnakeCaseToUpperCamelCase(name).Replace("Opengl", "OpenGL");

			const string WindowHintEnum = "WindowHint";

			MacroPlugin.Rules.AddRange(new[] {
				new MacroToEnumRule(@"GLFW_(NOT_INITIALIZED|NO_CURRENT_CONTEXT|INVALID_ENUM|INVALID_VALUE|OUT_OF_MEMORY|API_UNAVAILABLE|VERSION_UNAVAILABLE|PLATFORM_ERROR|FORMAT_UNAVAILABLE)$", "GlfwError", "$1", EnumItemNaming),
				// Window related hints
				new MacroToEnumRule(@"GLFW_(RESIZABLE|VISIBLE|DECORATED|FOCUSED|AUTO_ICONIFY|FLOATING|MAXIMIZED|CENTER_CURSOR|TRANSPARENT_FRAMEBUFFER|FOCUS_ON_SHOW|SCALE_TO_MONITOR)$", WindowHintEnum, "$1", EnumItemNaming),
				// Framebuffer related hints
				new MacroToEnumRule(@"GLFW_((?:ACCUM_)?(?:RED_BITS|GREEN_BITS|BLUE_BITS|ALPHA_BITS|DEPTH_BITS|STENCIL_BITS))$", WindowHintEnum, "$1", EnumItemNaming),
				new MacroToEnumRule(@"GLFW_(AUX_BUFFERS|STEREO|SAMPLES|SRGB_CAPABLE|DOUBLEBUFFER)$", WindowHintEnum, "$1", EnumItemNaming),
				// Monitor related hints
				new MacroToEnumRule(@"GLFW_(REFRESH_RATE)$", WindowHintEnum, "$1", EnumItemNaming),
				// Context related hints
				new MacroToEnumRule(@"GLFW_(CLIENT_API|CONTEXT_(?:CREATION_API|DEBUG|VERSION_(?:MINOR|MAJOR)|ROBUSTNESS)|RELEASE_BEHAVIOR|NO_ERROR)$", WindowHintEnum, "$1", EnumItemNaming),
				new MacroToEnumRule(@"GLFW_(OPENGL_(?:FORWARD_COMPAT|PROFILE))$", WindowHintEnum, "$1", EnumItemNaming),
				// MacOS specific window hints
				new MacroToEnumRule(@"GLFW_(COCOA_(?:RETINA_FRAMEBUFFER|FRAME_NAME|GRAPHICS_SWITCHING))$", WindowHintEnum, "$1", EnumItemNaming),
				// X11 specific window hints
				new MacroToEnumRule(@"GLFW_(X11_(?:CLASS_NAME|INSTANCE_NAME))$", WindowHintEnum, "$1", EnumItemNaming),
			});

			Options.MappingRules.AddRange(new Func<CppMappingRules, CppElementMappingRule>[] {
				e => RemovePrefixes(
					e,
					typePrefix: "GLFW",
					enumPrefix: "GLFW_",
					functionPrefix: "glfw",
					typedefPrefix: "GLFW"
				),

				// Manually fix casing
				e => e.Map<CppClass>("Vidmode").Name("VidMode"),
				e => e.Map<CppClass>("Gammaramp").Name("GammaRamp"),
				e => e.Map<CppClass>("Gamepadstate").Name("GamepadState"),

				// Method parameter type fixes
				e => e.Map<CppParameter>("glfwWindowHint::hint").ParameterType($"{Options.DefaultNamespace}.{WindowHintEnum}"),
				e => ParameterToBool(e.Map<CppParameter>("glfwSetWindowAttrib::value")),
				e => ParameterToBool(e.Map<CppParameter>("glfwSetInputMode::value")),

				// Delegate parameter type fixes
				e => e.Map<CppTypedef>("Errorfun").ParameterType("arg0", $"{Options.DefaultNamespace}.GlfwError"),

				// Return type fixes
				e => ReturnToBool(e.Map<CppFunction>("glfwInit")),
				e => ReturnToBool(e.Map<CppFunction>("glfwRawMouseMotionSupported")),
				e => ReturnToBool(e.Map<CppFunction>("glfwJoystickPresent")),
				e => ReturnToBool(e.Map<CppFunction>("glfwJoystickIsGamepad")),
				e => ReturnToBool(e.Map<CppFunction>("glfwUpdateGamepadMappings")),
				e => ReturnToBool(e.Map<CppFunction>("glfwGetGamepadState")),
				e => ReturnToBool(e.Map<CppFunction>("glfwExtensionSupported")),
				e => ReturnToBool(e.Map<CppFunction>("glfwVulkanSupported")),
				e => ReturnToBool(e.Map<CppFunction>("glfwGetPhysicalDevicePresentationSupport")),
			});
		}
	}
}
