using System;
using System.Runtime.InteropServices;
using CC = System.Runtime.InteropServices.CallingConvention;
using UFP = System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute;

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[UFP(CC.Cdecl)]
		private unsafe delegate void DrawArraysInstancedDelegate(uint mode,int first,int count,int instanceCount);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void DrawElementsInstancedDelegate(uint mode,int count,uint type,IntPtr indices,int instanceCount);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void TexBufferDelegate(TextureBufferTarget target,uint internalFormat,uint buffer);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void PrimitiveRestartIndexDelegate(uint index);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void CopyBufferSubDataDelegate(uint readTarget,uint writeTarget,int readOffset,int writeOffset,int size);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void GetUniformIndicesDelegate(uint program,int uniformCount,IntPtr uniformNames,ref uint uniformIndices);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void GetActiveUniformsivDelegate(uint program,int uniformCount,ref uint uniformIndices,uint pName,ref int parameters);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void GetActiveUniformNameDelegate(uint program,uint uniformIndex,int bufSize,ref int length,IntPtr uniformName);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate uint GetUniformBlockIndexDelegate(uint program,IntPtr uniformBlockName);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void GetActiveUniformBlockivDelegate(uint program,uint uniformBlockIndex,uint pName,ref int parameters);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void GetActiveUniformBlockNameDelegate(uint program,uint uniformBlockIndex,int bufSize,ref int length,IntPtr uniformBlockName);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void UniformBlockBindingDelegate(uint program,uint uniformBlockIndex,uint uniformBlockBinding);
	}
}
