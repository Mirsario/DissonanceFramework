using MI = System.Runtime.CompilerServices.MethodImplAttribute;

#pragma warning disable IDE0060 //Unused parameter.

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[MI(ImplOptions)]
		public unsafe static bool TryGetAttribLocation(uint program,string name,out int result) => (result = GetAttribLocation(program,name))>=0;
		[MI(ImplOptions)]
		public unsafe static bool TryGetAttribLocation(uint program,string name,out uint result)
		{
			int tempResult = GetAttribLocation(program,name);

			if(tempResult>=0) {
				result = (uint)tempResult;
				return true;
			}

			result = 0;
			return false;
		}
	}
}