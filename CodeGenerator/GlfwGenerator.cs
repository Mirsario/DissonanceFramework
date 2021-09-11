using System;
using CodeGenerator.Utilities;
using CppAst;
using CppAst.CodeGen.CSharp;

namespace CodeGenerator
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

			Options.MappingRules.AddRange(new Func<CppMappingRules, CppElementMappingRule>[] {
				e => RemovePrefixes(e, "GLFW", "GLFW_", "glfw"),
				
				// Manually fix casing
				e => e.Map<CppClass>("Vidmode").Name("VidMode"),
				e => e.Map<CppClass>("Gammaramp").Name("GammaRamp"),
				e => e.Map<CppClass>("Gamepadstate").Name("GamepadState"),

				// Parameter type fixes
				e => ParameterToBool(e.Map<CppParameter>("glfwSetWindowAttrib::value")),
				e => ParameterToBool(e.Map<CppParameter>("glfwSetInputMode::value")),

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
