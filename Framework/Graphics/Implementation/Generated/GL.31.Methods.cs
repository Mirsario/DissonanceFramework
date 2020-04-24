using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[MethodImpl(ImplOptions)]
		public unsafe static void DrawArraysInstanced(uint mode,int first,int count,int instanceCount)
			=> glDrawArraysInstanced(mode,first,count,instanceCount);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void DrawElementsInstanced(uint mode,int count,uint type,IntPtr indices,int instanceCount)
			=> glDrawElementsInstanced(mode,count,type,indices,instanceCount);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void TexBuffer(TextureBufferTarget target,uint internalFormat,uint buffer)
			=> glTexBuffer(target,internalFormat,buffer);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void PrimitiveRestartIndex(uint index)
			=> glPrimitiveRestartIndex(index);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void CopyBufferSubData(uint readTarget,uint writeTarget,int readOffset,int writeOffset,int size)
			=> glCopyBufferSubData(readTarget,writeTarget,readOffset,writeOffset,size);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetUniformIndices(uint program,int uniformCount,IntPtr uniformNames,ref uint uniformIndices)
			=> glGetUniformIndices(program,uniformCount,uniformNames,ref uniformIndices);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetActiveUniforms(uint program,int uniformCount,ref uint uniformIndices,uint pName,ref int parameters)
			=> glGetActiveUniformsiv(program,uniformCount,ref uniformIndices,pName,ref parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetActiveUniformName(uint program,uint uniformIndex,int bufSize,ref int length,IntPtr uniformName)
			=> glGetActiveUniformName(program,uniformIndex,bufSize,ref length,uniformName);
		
		[MethodImpl(ImplOptions)]
		public unsafe static uint GetUniformBlockIndex(uint program,IntPtr uniformBlockName)
			=> glGetUniformBlockIndex(program,uniformBlockName);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetActiveUniformBlock(uint program,uint uniformBlockIndex,uint pName,ref int parameters)
			=> glGetActiveUniformBlockiv(program,uniformBlockIndex,pName,ref parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetActiveUniformBlockName(uint program,uint uniformBlockIndex,int bufSize,ref int length,IntPtr uniformBlockName)
			=> glGetActiveUniformBlockName(program,uniformBlockIndex,bufSize,ref length,uniformBlockName);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void UniformBlockBinding(uint program,uint uniformBlockIndex,uint uniformBlockBinding)
			=> glUniformBlockBinding(program,uniformBlockIndex,uniformBlockBinding);
	}
}
