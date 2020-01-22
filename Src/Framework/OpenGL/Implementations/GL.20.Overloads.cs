using MI = System.Runtime.CompilerServices.MethodImplAttribute;

#pragma warning disable IDE0060 //Unused parameter.

namespace Dissonance.Framework.OpenGL
{
	partial class GL
	{
		[MI(AI)]
		public unsafe static void DrawBuffers(int numDrawBuffers,DrawBuffersEnum[] drawBuffers)
		{
			fixed(DrawBuffersEnum* ptr = &(drawBuffers!=null && drawBuffers.Length!=0 ? ref drawBuffers[0] : ref *(DrawBuffersEnum*)null)) {
				DeleteFramebuffers(numDrawBuffers,(uint*)ptr);
			}
		}
	}
}