using System;

namespace Dissonance.Framework.Graphics.OpenGL
{
	unsafe partial class GL
	{
		[MethodImport("glDrawArraysInstanced", "3.1")]
		private static delegate*<PrimitiveType, int, int, int, void> glDrawArraysInstanced;
		
		public static void DrawArraysInstanced(PrimitiveType mode, int first, int count, int instancecount)
		{
			glDrawArraysInstanced(mode, first, count, instancecount);
		}
		
		[MethodImport("glDrawElementsInstanced", "3.1")]
		private static delegate*<PrimitiveType, int, DrawElementsType, void*, int, void> glDrawElementsInstanced;
		
		public static void DrawElementsInstanced(PrimitiveType mode, int count, DrawElementsType type, void* indices, int instancecount)
		{
			glDrawElementsInstanced(mode, count, type, indices, instancecount);
		}
		
		[MethodImport("glTexBuffer", "3.1")]
		private static delegate*<TextureTarget, SizedInternalFormat, uint, void> glTexBuffer;
		
		public static void TexBuffer(TextureTarget target, SizedInternalFormat internalformat, uint buffer)
		{
			glTexBuffer(target, internalformat, buffer);
		}
		
		[MethodImport("glPrimitiveRestartIndex", "3.1")]
		private static delegate*<uint, void> glPrimitiveRestartIndex;
		
		public static void PrimitiveRestartIndex(uint index)
		{
			glPrimitiveRestartIndex(index);
		}
		
		[MethodImport("glCopyBufferSubData", "3.1")]
		private static delegate*<CopyBufferSubDataTarget, CopyBufferSubDataTarget, IntPtr, IntPtr, IntPtr, void> glCopyBufferSubData;
		
		public static void CopyBufferSubData(CopyBufferSubDataTarget readTarget, CopyBufferSubDataTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, IntPtr size)
		{
			glCopyBufferSubData(readTarget, writeTarget, readOffset, writeOffset, size);
		}
		
		[MethodImport("glGetUniformIndices", "3.1")]
		private static delegate*<uint, int, byte**, uint*, void> glGetUniformIndices;
		
		public static void GetUniformIndices(uint program, int uniformCount, byte** uniformNames, uint* uniformIndices)
		{
			glGetUniformIndices(program, uniformCount, uniformNames, uniformIndices);
		}
		
		[MethodImport("glGetActiveUniformsiv", "3.1")]
		private static delegate*<uint, int, uint*, UniformPName, int*, void> glGetActiveUniformsiv;
		
		public static void GetActiveUniformsiv(uint program, int uniformCount, uint* uniformIndices, UniformPName pname, int* @params)
		{
			glGetActiveUniformsiv(program, uniformCount, uniformIndices, pname, @params);
		}
		
		[MethodImport("glGetActiveUniformName", "3.1")]
		private static delegate*<uint, uint, int, int*, byte*, void> glGetActiveUniformName;
		
		public static void GetActiveUniformName(uint program, uint uniformIndex, int bufSize, int* length, byte* uniformName)
		{
			glGetActiveUniformName(program, uniformIndex, bufSize, length, uniformName);
		}
		
		[MethodImport("glGetUniformBlockIndex", "3.1")]
		private static delegate*<uint, byte*, uint> glGetUniformBlockIndex;
		
		public static uint GetUniformBlockIndex(uint program, byte* uniformBlockName)
		{
			return glGetUniformBlockIndex(program, uniformBlockName);
		}
		
		[MethodImport("glGetActiveUniformBlockiv", "3.1")]
		private static delegate*<uint, uint, UniformBlockPName, int*, void> glGetActiveUniformBlockiv;
		
		public static void GetActiveUniformBlockiv(uint program, uint uniformBlockIndex, UniformBlockPName pname, int* @params)
		{
			glGetActiveUniformBlockiv(program, uniformBlockIndex, pname, @params);
		}
		
		[MethodImport("glGetActiveUniformBlockName", "3.1")]
		private static delegate*<uint, uint, int, int*, byte*, void> glGetActiveUniformBlockName;
		
		public static void GetActiveUniformBlockName(uint program, uint uniformBlockIndex, int bufSize, int* length, byte* uniformBlockName)
		{
			glGetActiveUniformBlockName(program, uniformBlockIndex, bufSize, length, uniformBlockName);
		}
		
		[MethodImport("glUniformBlockBinding", "3.1")]
		private static delegate*<uint, uint, uint, void> glUniformBlockBinding;
		
		public static void UniformBlockBinding(uint program, uint uniformBlockIndex, uint uniformBlockBinding)
		{
			glUniformBlockBinding(program, uniformBlockIndex, uniformBlockBinding);
		}
	}
}

