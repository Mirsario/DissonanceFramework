using System;
using System.Xml.Linq;

namespace CodeGenerator.Generators.Graphics.OpenGL
{
	partial class GLSpecification
	{
		public readonly struct Parameter
		{
			public readonly string Name;
			public readonly GLType Type;
			public readonly string Group;

			public Parameter(string name, GLType type, string group = null)
			{
				Name = name;
				Type = type;
				Group = group;
			}

			public static Parameter Parse(XElement xmlParameter)
			{
				string parameterName = xmlParameter.Element("name").Value;
				var parameterType = GLType.Parse(xmlParameter.Value.Substring(0, xmlParameter.Value.LastIndexOf(parameterName, StringComparison.Ordinal)));
				string parameterGroup = xmlParameter.Attribute("group")?.Value;

				return new Parameter(parameterName, parameterType, parameterGroup);
			}
		}
	}
}
