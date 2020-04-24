using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[MethodImpl(ImplOptions)]
		public unsafe static void GenQueries(int n,ref uint ids)
			=> glGenQueries(n,ref ids);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void DeleteQueries(int n,ref uint ids)
			=> glDeleteQueries(n,ref ids);
		
		[MethodImpl(ImplOptions)]
		public unsafe static byte IsQuery(uint id)
			=> glIsQuery(id);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void BeginQuery(uint target,uint id)
			=> glBeginQuery(target,id);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void EndQuery(uint target)
			=> glEndQuery(target);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetQuery(uint target,uint pName,ref int parameters)
			=> glGetQueryiv(target,pName,ref parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetQueryObject(uint id,uint pName,ref int parameters)
			=> glGetQueryObjectiv(id,pName,ref parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetQueryObject(uint id,uint pName,ref uint parameters)
			=> glGetQueryObjectuiv(id,pName,ref parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void BindBuffer(BufferTarget target,uint buffer)
			=> glBindBuffer(target,buffer);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void DeleteBuffers(int numBuffers,uint* buffers)
			=> glDeleteBuffers(numBuffers,buffers);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GenBuffers(int numBuffers,uint* buffers)
			=> glGenBuffers(numBuffers,buffers);
		
		[MethodImpl(ImplOptions)]
		public unsafe static byte IsBuffer(uint buffer)
			=> glIsBuffer(buffer);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void BufferData(BufferTarget target,IntPtr size,IntPtr data,BufferUsageHint usage)
			=> glBufferData(target,size,data,usage);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void BufferSubData(BufferTarget target,int offset,int size,IntPtr data)
			=> glBufferSubData(target,offset,size,data);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetBufferSubData(BufferTarget target,int offset,int size,IntPtr data)
			=> glGetBufferSubData(target,offset,size,data);
		
		[MethodImpl(ImplOptions)]
		public unsafe static IntPtr MapBuffer(BufferTarget target,uint access)
			=> glMapBuffer(target,access);
		
		[MethodImpl(ImplOptions)]
		public unsafe static byte UnmapBuffer(BufferTarget target)
			=> glUnmapBuffer(target);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetBufferParameter(BufferTarget target,uint pName,ref int parameters)
			=> glGetBufferParameteriv(target,pName,ref parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetBufferPointer(BufferTarget target,uint pName,ref IntPtr parameters)
			=> glGetBufferPointerv(target,pName,ref parameters);
	}
}
