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
			Options.DefaultClassLib = "Glfw";
			Options.DefaultOutputFilePath = "Glfw.Generated.cs";
			Options.DefaultDllImportNameAndArguments = "Library";

			static CppElementMappingRule ParameterToBool(CppElementMappingRule e)
				=> e.ParameterType(CSharpPrimitiveType.Bool()).MarshalAs(CSharpUnmanagedKind.I4);

			static CppElementMappingRule ReturnToBool(CppElementMappingRule e)
				=> e.ReturnType(CSharpPrimitiveType.Bool()).MarshalAs(CSharpUnmanagedKind.U1);

			static string EnumItemRenamer(string name)
				=> StringUtils.SnakeCaseToUpperCamelCase(name.Replace("GLFW_", null)).Replace("Opengl", "OpenGL");

			static string PrefixNumbers(string str, string prefix)
			{
				if (int.TryParse(str, out _)) {
					str = $"{prefix}{str}";
				}

				return str;
			}

			const string WindowHintEnum = "WindowHint";

			// language=regex
			MacroPlugin.Rules.AddRange(new MacroRule[] {
				// Macros to enums

				// Window Hints
				new MacroToEnumRule(@"GLFW_(NOT_INITIALIZED|NO_CURRENT_CONTEXT|INVALID_ENUM|INVALID_VALUE|OUT_OF_MEMORY|API_UNAVAILABLE|VERSION_UNAVAILABLE|PLATFORM_ERROR|FORMAT_UNAVAILABLE)$", "GlfwError", EnumItemRenamer),
				// Window related hints
				new MacroToEnumRule(@"GLFW_(RESIZABLE|VISIBLE|DECORATED|FOCUSED|AUTO_ICONIFY|FLOATING|MAXIMIZED|CENTER_CURSOR|TRANSPARENT_FRAMEBUFFER|FOCUS_ON_SHOW|SCALE_TO_MONITOR)$", WindowHintEnum, EnumItemRenamer),
				// Framebuffer related hints
				new MacroToEnumRule(@"GLFW_((?:ACCUM_)?(?:RED_BITS|GREEN_BITS|BLUE_BITS|ALPHA_BITS|DEPTH_BITS|STENCIL_BITS))$", WindowHintEnum, EnumItemRenamer),
				new MacroToEnumRule(@"GLFW_(AUX_BUFFERS|STEREO|SAMPLES|SRGB_CAPABLE|DOUBLEBUFFER)$", WindowHintEnum, EnumItemRenamer),
				// Monitor related hints
				new MacroToEnumRule(@"GLFW_(REFRESH_RATE)$", WindowHintEnum, EnumItemRenamer),
				// Context related hints
				new MacroToEnumRule(@"GLFW_(CLIENT_API|CONTEXT_(?:CREATION_API|DEBUG|VERSION_(?:MINOR|MAJOR)|ROBUSTNESS)|RELEASE_BEHAVIOR|NO_ERROR)$", WindowHintEnum, EnumItemRenamer),
				new MacroToEnumRule(@"GLFW_(OPENGL_(?:FORWARD_COMPAT|PROFILE))$", WindowHintEnum, EnumItemRenamer),
				// MacOS specific window hints
				new MacroToEnumRule(@"GLFW_(COCOA_(?:RETINA_FRAMEBUFFER|FRAME_NAME|GRAPHICS_SWITCHING))$", WindowHintEnum, EnumItemRenamer),
				// X11 specific window hints
				new MacroToEnumRule(@"GLFW_(X11_(?:CLASS_NAME|INSTANCE_NAME))$", WindowHintEnum, EnumItemRenamer),
				
				// Input
				new MacroToEnumRule(@"GLFW_GAMEPAD_BUTTON_(.+)$", "GamepadButton", s => EnumItemRenamer(s.Replace("GLFW_GAMEPAD_BUTTON_", null))),
				new MacroToEnumRule(@"GLFW_GAMEPAD_AXIS_(.+)$", "GamepadAxis", s => EnumItemRenamer(s.Replace("GLFW_GAMEPAD_AXIS_", null))),
				new MacroToEnumRule(@"GLFW_JOYSTICK_([\dA-Z]+)$", "Joystick", s => EnumItemRenamer(PrefixNumbers(s.Replace("GLFW_JOYSTICK_", null), "Joystick"))),
				new MacroToEnumRule(@"GLFW_HAT_(.+)$", "JoystickHatState", s => EnumItemRenamer(s.Replace("GLFW_HAT_", null))),
				new MacroToEnumRule(@"GLFW_MOD_(.+)$", "KeyModifier", s => EnumItemRenamer(s.Replace("GLFW_MOD_", null))),
				new MacroToEnumRule(@"GLFW_KEY_(.+)$", "Keys", s => EnumItemRenamer(PrefixNumbers(s.Replace("GLFW_KEY_", null), "Number"))),
				new MacroToEnumRule(@"GLFW_MOUSE_BUTTON_(.+)$", "MouseButton", s => EnumItemRenamer(PrefixNumbers(s.Replace("GLFW_MOUSE_BUTTON_", null), "Button"))),
				new MacroToEnumRule(@"GLFW_(?:PRESS|RELEASE)$", "ButtonState", s => EnumItemRenamer(s.Replace("GLFW_", null))),
				new MacroToEnumRule(@"GLFW_(?:PRESS|RELEASE|REPEAT)$", "KeyState", s => EnumItemRenamer(s.Replace("GLFW_", null))),

				// Other
				new MacroToEnumRule(@"GLFW_(?:CURSOR|STICKY_KEYS|STICKY_MOUSE_BUTTONS|LOCK_KEY_MODS|RAW_MOUSE_MOTION)$", "InputMode", s => EnumItemRenamer(s.Replace("GLFW_", null))),

				// Macros to constants

				new MacroToConstantRule(@"GLFW_(?!OPENGL_DEBUG_CONTEXT)(?!TRUE)(?!FALSE)(.+)$", CSharpPrimitiveType.Int(), $"{Options.DefaultClassLib}.Constants.cs", Options.DefaultClassLib, EnumItemRenamer) {
					OnlyNonProcessedMacros = true
				},
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
				e => e.Map<CppParameter>("glfwSetInputMode::mode").ParameterType($"{Options.DefaultNamespace}.InputMode"),
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
