using System;

namespace Dissonance.Framework
{
	public class MethodImportAttribute : Attribute
	{
		public readonly string Function;
		public readonly Version Version;

		public MethodImportAttribute(string function = null, string version = null)
		{
			Function = function;
			Version = version != null ? new Version(version) : null;
		}
	}
}
