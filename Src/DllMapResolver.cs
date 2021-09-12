using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace Dissonance.Framework
{
	public static partial class DllMapResolver
	{
		private static bool resolverReady;

		static DllMapResolver() => PrepareOwnResolver();

		// This method implements a *barebones* dllmap resolver for the framework's native libraries. It expects 'DissonanceFramework.dll.config' to be present next to the framework's dll.
		public static void SetForAssembly(Assembly assembly, string configPath = null)
		{
			var stringComparer = StringComparer.InvariantCultureIgnoreCase;
			string osString = OSUtils.GetOS().ToString().ToLower();
			string cpuString = RuntimeInformation.OSArchitecture switch {
				Architecture.Arm => "arm",
				Architecture.Arm64 => "armv8",
				Architecture.X86 => "x86",
				_ => "x86-64",
			};
			string wordSizeString = RuntimeInformation.OSArchitecture switch {
				Architecture.X86 => "32",
				Architecture.Arm => "32",
				_ => "64",
			};

			bool StringNullOrEqual(string a, string b)
				=> a == null || stringComparer.Equals(a, b);

			NativeLibrary.SetDllImportResolver(assembly, (name, assembly, path) => {
				string usedConfigPath = configPath;

				if (configPath == null) {
					if (string.IsNullOrWhiteSpace(assembly.Location)) {
						usedConfigPath = $"{assembly.ManifestModule.ScopeName}.config";
					} else {
						usedConfigPath = $"{assembly.Location}.config";
					}
				}

				if (!File.Exists(usedConfigPath)) {
					return IntPtr.Zero;
				}

				XElement root = XElement.Load(usedConfigPath);

				var maps = root
					.Elements("dllmap")
					.Where(element => stringComparer.Equals(element.Attribute("dll")?.Value, name))
					.Where(element => StringNullOrEqual(element.Attribute("os")?.Value, osString))
					.Where(element => StringNullOrEqual(element.Attribute("cpu")?.Value, cpuString))
					.Where(element => StringNullOrEqual(element.Attribute("wordsize")?.Value, wordSizeString));

				var map = maps.SingleOrDefault();

				if (map == null) {
					throw new ArgumentException($"'{Path.GetFileName(usedConfigPath)}' - Found {maps.Count()} possible mapping candidates for dll '{name}'.");
				}

				return NativeLibrary.Load(map.Attribute("target").Value);
			});
		}

		internal static void PrepareOwnResolver()
		{
			if (!resolverReady) {
				SetForAssembly(Assembly.GetExecutingAssembly());

				resolverReady = true;
			}
		}
	}
}
