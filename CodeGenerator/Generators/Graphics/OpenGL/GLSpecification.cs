using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace CodeGenerator.Generators.Graphics.OpenGL
{
	public partial class GLSpecification
	{
		public readonly List<ApiVersion> ApiVersions = new();
		public readonly Dictionary<string, Function> Functions = new();
		public readonly Dictionary<string, EnumGroup> EnumGroups = new();
		//public readonly Dictionary<string, List<EnumGroup>> EnumGroupByEntryName = new();

		public GLSpecification(string xmlPath)
		{
			var xDocument = XDocument.Load(xmlPath);

			// Parse functions (commands)

			foreach (var xmlCommands in xDocument.Root.Elements("commands")) {
				foreach (var xmlCommand in xmlCommands.Elements("command")) {
					var xmlProto = xmlCommand.Element("proto");
					var xmlPType = xmlProto.Element("ptype");
					var xmlParameters = xmlCommand.Elements("param").ToArray();

					string name = xmlProto.Element("name").Value;
					var returnType = new GLType(xmlPType?.Value ?? "void", group: xmlProto.Attribute("group")?.Value);
					var parameters = xmlParameters.Length > 0 ? new Parameter[xmlParameters.Length] : Array.Empty<Parameter>();

					for (int i = 0; i < xmlParameters.Length; i++) {
						parameters[i] = Parameter.Parse(xmlParameters[i]);
					}

					Functions.Add(name, new Function(name, returnType, parameters));
				}
			}

			// Parse enums (enum groups)

			foreach (var xmlEnums in xDocument.Root.Elements("enums")) {
				string enumsNamespace = xmlEnums.Attribute("namespace").Value;
				string enumsVendor = xmlEnums.Attribute("vendor")?.Value;
				string enumsComment = xmlEnums.Attribute("comment")?.Value;

				foreach (var xmlEnum in xmlEnums.Elements("enum")) {
					string enumName = xmlEnum.Attribute("name").Value;
					string enumValue = xmlEnum.Attribute("value").Value;
					string[] enumGroups = xmlEnum.Attribute("group")?.Value?.Split(',');

					void HandleGroup(string groupName)
					{
						if (!EnumGroups.TryGetValue(groupName, out var enumGroup)) {
							EnumGroups[groupName] = enumGroup = new(groupName);
						}

						enumGroup.Entries[enumName] = enumValue;
					}

					if (enumGroups != null) {
						foreach (string enumGroup in enumGroups) {
							HandleGroup(enumGroup);
						}
					} else {
						HandleGroup(string.Empty);
					}
				}
			}

			// Parse versions (features)

			foreach (var featureElement in xDocument.Root.Elements("feature")) {
				string api = featureElement.Attribute("api").Value;
				string directive = featureElement.Attribute("name").Value;
				var versionNumber = new Version(featureElement.Attribute("number").Value);

				var glVersion = new ApiVersion(api, directive, versionNumber);

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

				ApiVersions.Add(glVersion);
			}
		}
	}
}
