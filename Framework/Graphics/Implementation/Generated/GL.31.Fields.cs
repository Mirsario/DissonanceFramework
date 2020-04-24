#pragma warning disable CS0649

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[MethodImport("glDrawArraysInstanced")]
		private static DrawArraysInstancedDelegate glDrawArraysInstanced;
		
		[MethodImport("glDrawElementsInstanced")]
		private static DrawElementsInstancedDelegate glDrawElementsInstanced;
		
		[MethodImport("glTexBuffer")]
		private static TexBufferDelegate glTexBuffer;
		
		[MethodImport("glPrimitiveRestartIndex")]
		private static PrimitiveRestartIndexDelegate glPrimitiveRestartIndex;
		
		[MethodImport("glCopyBufferSubData")]
		private static CopyBufferSubDataDelegate glCopyBufferSubData;
		
		[MethodImport("glGetUniformIndices")]
		private static GetUniformIndicesDelegate glGetUniformIndices;
		
		[MethodImport("glGetActiveUniformsiv")]
		private static GetActiveUniformsivDelegate glGetActiveUniformsiv;
		
		[MethodImport("glGetActiveUniformName")]
		private static GetActiveUniformNameDelegate glGetActiveUniformName;
		
		[MethodImport("glGetUniformBlockIndex")]
		private static GetUniformBlockIndexDelegate glGetUniformBlockIndex;
		
		[MethodImport("glGetActiveUniformBlockiv")]
		private static GetActiveUniformBlockivDelegate glGetActiveUniformBlockiv;
		
		[MethodImport("glGetActiveUniformBlockName")]
		private static GetActiveUniformBlockNameDelegate glGetActiveUniformBlockName;
		
		[MethodImport("glUniformBlockBinding")]
		private static UniformBlockBindingDelegate glUniformBlockBinding;
	}
}
