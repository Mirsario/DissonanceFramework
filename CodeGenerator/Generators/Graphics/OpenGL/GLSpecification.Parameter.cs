using System;
using System.Xml.Linq;

namespace CodeGenerator.Generators.Graphics.OpenGL
{
	partial class GLSpecification
	{
		public struct Parameter
		{
			public string Name;
			public GLType Type;

			public Parameter(string name, GLType type)
			{
				Name = name;
				Type = type;
			}

			public static Parameter Parse(XElement xmlParameter)
			{
				string parameterName = xmlParameter.Element("name").Value;
				var parameterType = GLType.Parse(xmlParameter.Value.Substring(0, xmlParameter.Value.LastIndexOf(parameterName, StringComparison.Ordinal)));

				parameterType.Group = xmlParameter.Attribute("group")?.Value;

				return new Parameter(parameterName, parameterType);
			}
		}
	}
}
