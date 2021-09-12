using System;
using CodeGenerator.Converters;
using CodeGenerator.Utilities;
using CppAst;
using CppAst.CodeGen.CSharp;

namespace CodeGenerator.Generators.Audio
{
	public class ALGenerator : AudioGenerator
	{
		public ALGenerator(string inputFile, string defaultNamespace, string defaultClass, string outputFile) : base(inputFile, defaultNamespace, defaultClass, outputFile)
		{
			static string EnumItemRenamer(string name) => StringUtils.SnakeCaseToUpperCamelCase(name.Replace("AL_", null));

			MacroPlugin.Rules.AddRange(new[] {
				// State
				new MacroToEnumRule(@"AL_(DISTANCE_MODEL)$", "StateInt", EnumItemRenamer),
				new MacroToEnumRule(@"AL_(DOPPLER_FACTOR|SPEED_OF_SOUND)$", "StateFloat", EnumItemRenamer),
				new MacroToEnumRule(@"AL_(DOPPLER_FACTOR|SPEED_OF_SOUND)$", "StateDouble", EnumItemRenamer),
				new MacroToEnumRule(@"AL_(VENDOR|VERSION|RENDERER|EXTENSIONS)$", "StateString", EnumItemRenamer),
				// Listener
				new MacroToEnumRule(@"AL_(GAIN)$", "ListenerFloat", EnumItemRenamer),
				new MacroToEnumRule(@"AL_(POSITION|VELOCITY)$", "ListenerFloat3", EnumItemRenamer),
				new MacroToEnumRule(@"AL_(POSITION|VELOCITY|ORIENTATION)$", "ListenerFloatArray", EnumItemRenamer),
				// Source
				new MacroToEnumRule(@"AL_(SOURCE_RELATIVE)$", "GetSourceBool", EnumItemRenamer),
				new MacroToEnumRule(@"AL_(BUFFER|SOURCE_STATE|BUFFERS_QUEUED|BUFFERS_PROCESSED)$", "GetSourceInt", EnumItemRenamer),
				new MacroToEnumRule(@"AL_(SOURCE_RELATIVE|LOOPING)$", "SourceBool", EnumItemRenamer),
				new MacroToEnumRule(@"AL_(BUFFER|SOURCE_STATE)$", "SourceInt", EnumItemRenamer),
				new MacroToEnumRule(@"AL_(PITCH|GAIN|MIN_GAIN|MAX_GAIN|MAX_DISTANCE|ROLLOFF_FACTOR|CONE_OUTER_GAIN|CONE_INNER_ANGLE|CONE_OUTER_ANGLE|REFERENCE_DISTANCE)$", "SourceFloat", EnumItemRenamer),
				// Buffer
				new MacroToEnumRule(@"AL_(FREQUENCY|BITS|CHANNELS|SIZE|DATA)$", "GetBufferInt", EnumItemRenamer),
				// Other
				new MacroToEnumRule(@"AL_(FORMAT_MONO8|FORMAT_MONO16|FORMAT_STEREO8|FORMAT_STEREO16)$", "BufferFormat", s => EnumItemRenamer(s.Replace("FORMAT_", null))),
				new MacroToEnumRule(@"AL_(NO_ERROR|INVALID_NAME|INVALID_ENUM|INVALID_VALUE|INVALID_OPERATION|OUT_OF_MEMORY)$", "AudioError", EnumItemRenamer),
			});

			Options.MappingRules.AddRange(new Func<CppMappingRules, CppElementMappingRule>[] {
				// Remove prefixes from elements' names.
				e => RemovePrefixes(e, "AL", $"AL_", "al"),
				
				// Fix strings and booleans.
				e => FixBooleansAndStrings(e, "ALboolean", "ALchar"),
				
				// Change all 'alGet*' and 'alGen*" 'ref' parameters to 'out'.
				e => e.MapAll<CppParameter>().CSharpAction((converter, element) => {
					var parameter = (CSharpParameter)element;

					if (parameter.ParameterType is not CSharpRefType refType) {
						return;
					}

					var cppFunction = (CppFunction)parameter.Parent.CppElement;

					if ((cppFunction.Name.StartsWith("alGet") || cppFunction.Name.StartsWith("alGen")) && refType.Kind == CSharpRefKind.Ref) {
						refType.Kind = CSharpRefKind.Out;
					}
				}),

				// Manual fixes

				// Use enums for state getters, since they don't follow other naming schemes
				e => e.Map<CppParameter>("alGetInteger::param").ParameterType($"{Namespace}.StateInt"),
				e => e.Map<CppParameter>("alGetFloat::param").ParameterType($"{Namespace}.StateFloat"),
				e => e.Map<CppParameter>("alGetDouble::param").ParameterType($"{Namespace}.StateDouble"),
				e => e.Map<CppParameter>("alGetString::param").ParameterType($"{Namespace}.StateString"),
				// Use other enums
				e => e.Map<CppParameter>("alBufferData::format").ParameterType($"{Namespace}.BufferFormat"),
				e => e.Map<CppFunction>("alGetError").ReturnType($"{Namespace}.AudioError"),
			});
		}
	}
}
