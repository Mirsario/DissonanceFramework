using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CodeGenerator.Generators.Graphics.OpenGL
{
	public partial class GLSpecification
	{
		public readonly List<GLVersion> Versions = new();
		public readonly List<Function> Functions = new();

		public GLSpecification(string xmlPath)
		{
			var xDocument = XDocument.Load(xmlPath);

			// Parse functions (commands)

			foreach (var functionElement in xDocument.Root.Element("commands").Elements("command")) {
				var xmlProto = functionElement.Element("proto");
				var xmlPType = xmlProto.Element("ptype");
				var xmlParameters = functionElement.Elements("param").ToArray();

				string name = xmlProto.Element("name").Value;
				GLType? returnType = xmlPType != null ? new GLType(xmlPType.Value, xmlProto.Attribute("group")?.Value) : null;
				Parameter[] parameters = xmlParameters.Length > 0 ? new Parameter[xmlParameters.Length] : null;

				for (int i = 0; i < xmlParameters.Length; i++) {
					var xmlParameter = xmlParameters[i];
					//var xmlParameterType = xmlParameter.Element("ptype");

					string parameterName = xmlParameter.Element("name").Value;
					var parameterType = GLType.Parse(xmlParameter.Value.Substring(0, xmlParameter.Value.IndexOf(parameterName, StringComparison.Ordinal)));

					parameters[i] = new Parameter(parameterName, parameterType);
				}

				var function = new Function(name, returnType, parameters);

				Functions.Add(function);
			}

			// Parse versions (features)

			foreach (var featureElement in xDocument.Root.Elements("feature")) {
				string api = featureElement.Attribute("api").Value;
				string directive = featureElement.Attribute("name").Value;
				var versionNumber = new Version(featureElement.Attribute("number").Value);

				var glVersion = new GLVersion(api, directive, versionNumber);

				void HandleFeatureSet(FeatureSetType type, XElement element)
				{
					var featureSet = new FeatureSet(type);

					foreach (var e in element.Elements("enum")) {
						featureSet.Enums.Add(e.Attribute("name").Value);
					}

					foreach (var e in element.Elements("command")) {
						featureSet.Functions.Add(e.Attribute("name").Value);
					}

					glVersion.FeatureSets.Add(featureSet);
				}

				foreach (var requireElement in featureElement.Elements("require")) {
					HandleFeatureSet(FeatureSetType.Requires, requireElement);
				}

				foreach (var removeElement in featureElement.Elements("remove")) {
					HandleFeatureSet(FeatureSetType.Removes, removeElement);
				}

				Versions.Add(glVersion);
			}

			Console.ReadKey();
		}
	}
}
