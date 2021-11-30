using System;
using System.Linq;
using System.Reflection;
using Dissonance.Framework.Windowing;

namespace Dissonance.Framework.Graphics.OpenGL
{
	public static partial class GL
	{
		static GL() => DllMapResolver.PrepareOwnResolver();

		public static void Load(Version version)
		{
			ImportTypeMethods(typeof(GL), version, function => Glfw.GetProcAddress(function));
		}

		private static void ImportTypeMethods(Type type, Version version, Func<string, IntPtr> functionToPointer)
		{
			var fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static)
				.Select<FieldInfo, (FieldInfo field, MethodImportAttribute attribute)>(f => (f, f.GetCustomAttribute<MethodImportAttribute>()))
				.Where(tuple => tuple.attribute != null && tuple.attribute.Version <= version)
				.OrderBy(tuple => tuple.attribute.Version)
				.ToArray();

			for (int i = 0; i < fields.Length; i++) {
				var tuple = fields[i];
				var field = tuple.field;
				var attribute = tuple.attribute;

				IntPtr ptr = functionToPointer(attribute.Function);

				if (ptr != IntPtr.Zero) {
					field.SetValue(null, ptr);
				} else {
					Console.WriteLine($"Unable to find function '{attribute.Function}'.");
				}
			}
		}
	}
}
