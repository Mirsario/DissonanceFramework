using MI = System.Runtime.CompilerServices.MethodImplAttribute;

#pragma warning disable IDE0060 //Unused parameter.

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		//GenFramebuffer(s)

		[MI(ImplOptions)]
		public unsafe static uint GenFramebuffer()
		{
			uint result;

			GenFramebuffers(1, &result);

			return result;
		}
		[MI(ImplOptions)]
		public unsafe static void GenFramebuffers(int numFramebuffers, uint[] framebuffers)
		{
			fixed(uint* ptr = &(framebuffers != null && framebuffers.Length != 0 ? ref framebuffers[0] : ref *(uint*)null)) {
				GenFramebuffers(numFramebuffers, ptr);
			}
		}

		//DeleteFramebuffer(s)

		[MI(ImplOptions)]
		public unsafe static void DeleteFramebuffer(uint framebuffer) => DeleteFramebuffers(1, &framebuffer);
		[MI(ImplOptions)]
		public unsafe static void DeleteFramebuffers(int numFramebuffers, uint[] framebuffers)
		{
			fixed(uint* ptr = &(framebuffers != null && framebuffers.Length != 0 ? ref framebuffers[0] : ref *(uint*)null)) {
				DeleteFramebuffers(numFramebuffers, ptr);
			}
		}

		//GenRenderbuffer(s)

		[MI(ImplOptions)]
		public unsafe static uint GenRenderbuffer()
		{
			uint result;

			GenRenderbuffers(1, &result);

			return result;
		}
		[MI(ImplOptions)]
		public unsafe static void GenRenderbuffers(int numRenderBuffers, uint[] renderbuffers)
		{
			fixed(uint* ptr = &(renderbuffers != null && renderbuffers.Length != 0 ? ref renderbuffers[0] : ref *(uint*)null)) {
				GenRenderbuffers(numRenderBuffers, ptr);
			}
		}

		//DeleteRenderbuffer(s)

		[MI(ImplOptions)]
		public unsafe static void DeleteRenderbuffer(uint renderbuffer) => DeleteRenderbuffers(1, &renderbuffer);
		[MI(ImplOptions)]
		public unsafe static void DeleteRenderbuffers(int numRenderbuffers, uint[] renderbuffers)
		{
			fixed(uint* ptr = &(renderbuffers != null && renderbuffers.Length != 0 ? ref renderbuffers[0] : ref *(uint*)null)) {
				DeleteRenderbuffers(numRenderbuffers, ptr);
			}
		}


		//GenVertexArray(s)

		[MI(ImplOptions)]
		public unsafe static uint GenVertexArray()
		{
			uint result;

			GenVertexArrays(1, &result);

			return result;
		}
		[MI(ImplOptions)]
		public unsafe static void GenVertexArrays(int numArrays, uint[] vertexArrays)
		{
			fixed(uint* ptr = &(vertexArrays != null && vertexArrays.Length != 0 ? ref vertexArrays[0] : ref *(uint*)null)) {
				GenVertexArrays(numArrays, ptr);
			}
		}

		//DeleteVertexArray(s)

		[MI(ImplOptions)]
		public unsafe static void DeleteVertexArray(uint vertexArray) => DeleteVertexArrays(1, &vertexArray);
		[MI(ImplOptions)]
		public unsafe static void DeleteVertexArrays(int numArrays, uint[] vertexArrays)
		{
			fixed(uint* ptr = &(vertexArrays != null && vertexArrays.Length != 0 ? ref vertexArrays[0] : ref *(uint*)null)) {
				DeleteVertexArrays(numArrays, ptr);
			}
		}
	}
}