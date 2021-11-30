using CppAst;
using CppAst.CodeGen.CSharp;

namespace CodeGenerator.Plugins
{
	public class FunctionsAsPointersConverter : ICSharpConverterPlugin
	{
		public void Register(CSharpConverter converter, CSharpConverterPipeline pipeline)
		{
			pipeline.FunctionConverters.Add(ConvertFunction);
		}

		public static CSharpElement ConvertFunction(CSharpConverter converter, CppFunction cppFunction, CSharpElement context)
		{
			// Only process internal functions
			if (cppFunction.LinkageKind != CppLinkageKind.Internal) {
				return null;
			}

			if ((cppFunction.Flags & (CppFunctionFlags.Inline | CppFunctionFlags.Method | CppFunctionFlags.Constructor | CppFunctionFlags.Destructor)) != 0 && (cppFunction.Flags & CppFunctionFlags.Virtual) == 0) {
				return null;
			}

			var container = converter.GetCSharpContainer(cppFunction, context);

			var csFunctionPointerField = CreateFunctionPointerField(converter, container, cppFunction, context);
			var csFunctionPointerMethod = CreateFunctionPointerMethod(converter, container, cppFunction, context, csFunctionPointerField);

			return csFunctionPointerMethod;
		}

		private static CSharpField CreateFunctionPointerField(CSharpConverter converter, ICSharpContainer container, CppFunction cppFunction, CSharpElement context)
		{
			// Create a function pointer field

			var fieldType = new CSharpGenericType(new CSharpStruct("delegate*"));

			foreach (var cppParameter in cppFunction.Parameters) {
				fieldType.TypeArguments.Add(converter.GetCSharpType(cppParameter.Type, context));
			}

			fieldType.TypeArguments.Add(converter.GetCSharpType(cppFunction.ReturnType, context));

			//FieldType = new CSharpClass("delegate*<void>"),

			var result = new CSharpField($"_{cppFunction.Name}") {
				FieldType = fieldType,
				Modifiers = CSharpModifiers.Static | CSharpModifiers.Unsafe
			};

			converter.ApplyDefaultVisibility(result, container);
			container.Members.Add(result);

			return result;
		}

		private static CSharpMethod CreateFunctionPointerMethod(CSharpConverter converter, ICSharpContainer container, CppFunction cppFunction, CSharpElement context, CSharpField csFunctionPointerField)
		{
			// Create a method that wraps over the provided function pointer field
			var result = new CSharpMethod();

			// Sucks that reflection has to be used.
			typeof(CSharpMethod)
				.GetProperty(nameof(CSharpMethod.CppElement))
				.SetValue(result, cppFunction);

			converter.ApplyDefaultVisibility(result, container);
			container.Members.Add(result);

			if ((cppFunction.Flags & CppFunctionFlags.Virtual) == 0) {
				result.Modifiers |= CSharpModifiers.Static;
			} else {
				result.Visibility = CSharpVisibility.None;
			}

			result.Modifiers |= CSharpModifiers.Unsafe;
			result.Name = converter.GetCSharpName(cppFunction, result);
			result.Comment = converter.GetCSharpComment(cppFunction, result);
			result.ReturnType = converter.GetCSharpType(cppFunction.ReturnType, result);

			result.Body = (code, element) => {
				if (result.ReturnType is not (null or CSharpPrimitiveType { Kind: CSharpPrimitiveKind.Void })) {
					code.Write("return ");
				}

				var csharpMethod = (CSharpMethod)element;
				var csharpFunctionPointerType = (CSharpGenericType)csFunctionPointerField.FieldType;

				code.Write($"{csFunctionPointerField.Name}(");

				bool first = true;

				for (int i = 0; i < csharpMethod.Parameters.Count; i++) {
					if (!first) {
						code.Write(", ");
					} else {
						first = false;
					}

					var csharpParameter = csharpMethod.Parameters[i];
					var csharpFunctionPointerTypeArgument = csharpFunctionPointerType.TypeArguments[i];

					if (csharpParameter.ParameterType != csharpFunctionPointerTypeArgument) {
						code.Write($"({csharpFunctionPointerTypeArgument.GetName()})");
					}

					code.Write(csharpParameter.Name);
				}

				code.WriteLine(");");
			};

			return result;
		}
	}
}
