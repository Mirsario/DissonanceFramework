#pragma warning disable CS0649

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[MethodImport("glDrawElementsBaseVertex")]
		private static DrawElementsBaseVertexDelegate glDrawElementsBaseVertex;
		
		[MethodImport("glDrawRangeElementsBaseVertex")]
		private static DrawRangeElementsBaseVertexDelegate glDrawRangeElementsBaseVertex;
		
		[MethodImport("glDrawElementsInstancedBaseVertex")]
		private static DrawElementsInstancedBaseVertexDelegate glDrawElementsInstancedBaseVertex;
		
		[MethodImport("glMultiDrawElementsBaseVertex")]
		private static MultiDrawElementsBaseVertexDelegate glMultiDrawElementsBaseVertex;
		
		[MethodImport("glProvokingVertex")]
		private static ProvokingVertexDelegate glProvokingVertex;
		
		[MethodImport("glFenceSync")]
		private static FenceSyncDelegate glFenceSync;
		
		[MethodImport("glIsSync")]
		private static IsSyncDelegate glIsSync;
		
		[MethodImport("glDeleteSync")]
		private static DeleteSyncDelegate glDeleteSync;
		
		[MethodImport("glClientWaitSync")]
		private static ClientWaitSyncDelegate glClientWaitSync;
		
		[MethodImport("glWaitSync")]
		private static WaitSyncDelegate glWaitSync;
		
		[MethodImport("glGetInteger64v")]
		private static GetInteger64vDelegate glGetInteger64v;
		
		[MethodImport("glGetSynciv")]
		private static GetSyncivDelegate glGetSynciv;
		
		[MethodImport("glGetInteger64i_v")]
		private static GetInteger64i_vDelegate glGetInteger64i_v;
		
		[MethodImport("glGetBufferParameteri64v")]
		private static GetBufferParameteri64vDelegate glGetBufferParameteri64v;
		
		[MethodImport("glFramebufferTexture")]
		private static FramebufferTextureDelegate glFramebufferTexture;
		
		[MethodImport("glTexImage2DMultisample")]
		private static TexImage2DMultisampleDelegate glTexImage2DMultisample;
		
		[MethodImport("glTexImage3DMultisample")]
		private static TexImage3DMultisampleDelegate glTexImage3DMultisample;
		
		[MethodImport("glGetMultisamplefv")]
		private static GetMultisamplefvDelegate glGetMultisamplefv;
		
		[MethodImport("glSampleMaski")]
		private static SampleMaskiDelegate glSampleMaski;
	}
}
