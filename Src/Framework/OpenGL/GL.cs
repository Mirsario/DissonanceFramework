using Dissonance.Framework.GLFW3;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Dissonance.Framework.OpenGL
{
	public static partial class GL
	{
		private static readonly Type InternalType = typeof(GLDirect);
		private static readonly Type DelegateType = typeof(MulticastDelegate);

		public static void Load()
		{
			if(GLFW.GetProcAddress==null) {
				throw new InvalidOperationException($"'{nameof(GL)}.{nameof(Load)}()' must be called after '{nameof(GLFW)}.{nameof(GLFW.Load)}()'.");
			}

			foreach(FieldInfo fi in InternalType.GetFields(BindingFlags.Public|BindingFlags.Static)) {
				if(fi.FieldType.BaseType!=DelegateType) {
					continue;
				}

				IntPtr ptr = GLFW.GetProcAddress("gl"+fi.Name);

				if(ptr!=IntPtr.Zero) {
					fi.SetValue(null,Marshal.GetDelegateForFunctionPointer(ptr,fi.FieldType));
				}
			}
		}
	}
}
