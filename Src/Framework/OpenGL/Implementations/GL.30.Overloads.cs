using MI = System.Runtime.CompilerServices.MethodImplAttribute;

#pragma warning disable IDE0060 //Unused parameter.

namespace Dissonance.Framework.OpenGL
{
	partial class GL
	{
		//GenFramebuffer(s)

		[MI(AI)]
		public unsafe static uint GenFramebuffer()
		{
			uint result;

			GenFramebuffers(1,&result);

			return result;
		}
		[MI(AI)]
		public unsafe static void GenFramebuffers(int numFramebuffers,uint[] framebuffers)
		{
			fixed (uint* ptr = &(framebuffers!=null && framebuffers.Length!=0 ? ref framebuffers[0] : ref *(uint*)null)) {
				GenFramebuffers(numFramebuffers,ptr);
			}
		}

		//DeleteFramebuffer(s)

		[MI(AI)]
		public unsafe static void DeleteFramebuffer(uint framebuffer) => DeleteFramebuffers(1,&framebuffer);
		[MI(AI)]
		public unsafe static void DeleteFramebuffers(int numFramebuffers,uint[] framebuffers)
		{
			fixed(uint* ptr = &(framebuffers!=null && framebuffers.Length!=0 ? ref framebuffers[0] : ref *(uint*)null)) {
				DeleteFramebuffers(numFramebuffers,ptr);
			}
		}
	}
}