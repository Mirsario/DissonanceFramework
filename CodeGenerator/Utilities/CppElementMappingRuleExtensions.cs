using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CppAst.CodeGen.CSharp;

namespace CodeGenerator.Utilities
{
	public static class CppElementMappingRuleExtensions
	{
		public static CppElementMappingRule ParameterRefKind(this CppElementMappingRule rule, CSharpRefKind refKind)
		{
			return rule.CSharpAction((converter, element) => {
				var parameter = (CSharpParameter)element;
				var type = (CSharpRefType)parameter.ParameterType;

				type.Kind = refKind;
			});
		}
		public static CppElementMappingRule ParameterType(this CppElementMappingRule rule, string fullTypeName)
		{
			return rule.CSharpAction((converter, element) => {
				((CSharpParameter)element).ParameterType = element.FindType(fullTypeName);
			});
		}
		public static CppElementMappingRule ParameterType(this CppElementMappingRule rule, CSharpType type)
		{
			return rule.CSharpAction((converter, element) => {
				((CSharpParameter)element).ParameterType = type;
			});
		}
		public static CppElementMappingRule ReturnType(this CppElementMappingRule rule, string fullTypeName)
		{
			return rule.CSharpAction((converter, element) => {
				((CSharpMethod)element).ReturnType = element.FindType(fullTypeName);
			});
		}
		public static CppElementMappingRule ReturnType(this CppElementMappingRule rule, CSharpType type)
		{
			return rule.CSharpAction((converter, element) => {
				((CSharpMethod)element).ReturnType = type;
			});
		}
	}
}
