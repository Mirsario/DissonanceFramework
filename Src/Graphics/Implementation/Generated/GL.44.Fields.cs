#pragma warning disable CS0649

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[MethodImport("glBufferStorage")]
		private static BufferStorageDelegate glBufferStorage;

		[MethodImport("glClearTexImage")]
		private static ClearTexImageDelegate glClearTexImage;

		[MethodImport("glClearTexSubImage")]
		private static ClearTexSubImageDelegate glClearTexSubImage;

		[MethodImport("glBindBuffersBase")]
		private static BindBuffersBaseDelegate glBindBuffersBase;

		[MethodImport("glBindBuffersRange")]
		private static BindBuffersRangeDelegate glBindBuffersRange;

		[MethodImport("glBindTextures")]
		private static BindTexturesDelegate glBindTextures;

		[MethodImport("glBindSamplers")]
		private static BindSamplersDelegate glBindSamplers;

		[MethodImport("glBindImageTextures")]
		private static BindImageTexturesDelegate glBindImageTextures;

		[MethodImport("glBindVertexBuffers")]
		private static BindVertexBuffersDelegate glBindVertexBuffers;
	}
}
