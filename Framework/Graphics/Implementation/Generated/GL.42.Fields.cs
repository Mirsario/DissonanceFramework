#pragma warning disable CS0649

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[MethodImport("glDrawArraysInstancedBaseInstance")]
		private static DrawArraysInstancedBaseInstanceDelegate glDrawArraysInstancedBaseInstance;
		
		[MethodImport("glDrawElementsInstancedBaseInstance")]
		private static DrawElementsInstancedBaseInstanceDelegate glDrawElementsInstancedBaseInstance;
		
		[MethodImport("glDrawElementsInstancedBaseVertexBaseInstance")]
		private static DrawElementsInstancedBaseVertexBaseInstanceDelegate glDrawElementsInstancedBaseVertexBaseInstance;
		
		[MethodImport("glGetInternalformativ")]
		private static GetInternalformativDelegate glGetInternalformativ;
		
		[MethodImport("glGetActiveAtomicCounterBufferiv")]
		private static GetActiveAtomicCounterBufferivDelegate glGetActiveAtomicCounterBufferiv;
		
		[MethodImport("glBindImageTexture")]
		private static BindImageTextureDelegate glBindImageTexture;
		
		[MethodImport("glMemoryBarrier")]
		private static MemoryBarrierDelegate glMemoryBarrier;
		
		[MethodImport("glTexStorage1D")]
		private static TexStorage1DDelegate glTexStorage1D;
		
		[MethodImport("glTexStorage2D")]
		private static TexStorage2DDelegate glTexStorage2D;
		
		[MethodImport("glTexStorage3D")]
		private static TexStorage3DDelegate glTexStorage3D;
		
		[MethodImport("glDrawTransformFeedbackInstanced")]
		private static DrawTransformFeedbackInstancedDelegate glDrawTransformFeedbackInstanced;
		
		[MethodImport("glDrawTransformFeedbackStreamInstanced")]
		private static DrawTransformFeedbackStreamInstancedDelegate glDrawTransformFeedbackStreamInstanced;
	}
}
