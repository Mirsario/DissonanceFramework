using System;
using System.Runtime.CompilerServices;

#pragma warning disable IDE0060 //Unused parameter.

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[MethodImpl(ImplOptions)]
		[MethodImport("glDrawArraysInstanced","3.1")]
		public static void DrawArraysInstanced(uint mode,int first,int count,int instanceCount)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glDrawElementsInstanced","3.1")]
		public static void DrawElementsInstanced(uint mode,int count,uint type,IntPtr indices,int instanceCount)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glTexBuffer","3.1")]
		public static void TexBuffer(TextureBufferTarget target,uint internalFormat,uint buffer)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glPrimitiveRestartIndex","3.1")]
		public static void PrimitiveRestartIndex(uint index)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glCopyBufferSubData","3.1")]
		public static void CopyBufferSubData(uint readTarget,uint writeTarget,int readOffset,int writeOffset,int size)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetUniformIndices","3.1")]
		public static void GetUniformIndices(uint program,int uniformCount,IntPtr uniformNames,ref uint uniformIndices)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetActiveUniformsiv","3.1")]
		public static void GetActiveUniforms(uint program,int uniformCount,ref uint uniformIndices,uint pName,ref int parameters)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetActiveUniformName","3.1")]
		public static void GetActiveUniformName(uint program,uint uniformIndex,int bufSize,ref int length,IntPtr uniformName)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetUniformBlockIndex","3.1")]
		public static uint GetUniformBlockIndex(uint program,IntPtr uniformBlockName)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetActiveUniformBlockiv","3.1")]
		public static void GetActiveUniformBlock(uint program,uint uniformBlockIndex,uint pName,ref int parameters)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glGetActiveUniformBlockName","3.1")]
		public static void GetActiveUniformBlockName(uint program,uint uniformBlockIndex,int bufSize,ref int length,IntPtr uniformBlockName)
			=> throw new NotImplementedException();

		[MethodImpl(ImplOptions)]
		[MethodImport("glUniformBlockBinding","3.1")]
		public static void UniformBlockBinding(uint program,uint uniformBlockIndex,uint uniformBlockBinding)
			=> throw new NotImplementedException();
	}
}