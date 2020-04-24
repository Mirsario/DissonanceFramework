using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[MethodImpl(ImplOptions)]
		public unsafe static void BindFragDataLocationIndexed(uint program,uint colorNumber,uint index,IntPtr name)
			=> glBindFragDataLocationIndexed(program,colorNumber,index,name);
		
		[MethodImpl(ImplOptions)]
		public unsafe static int GetFragDataIndex(uint program,IntPtr name)
			=> glGetFragDataIndex(program,name);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GenSamplers(int count,ref uint samplers)
			=> glGenSamplers(count,ref samplers);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void DeleteSamplers(int count,ref uint samplers)
			=> glDeleteSamplers(count,ref samplers);
		
		[MethodImpl(ImplOptions)]
		public unsafe static byte IsSampler(uint sampler)
			=> glIsSampler(sampler);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void BindSampler(uint unit,uint sampler)
			=> glBindSampler(unit,sampler);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void SamplerParameter(uint sampler,uint pName,int param)
			=> glSamplerParameteri(sampler,pName,param);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void SamplerParameter(uint sampler,uint pName,ref int param)
			=> glSamplerParameteriv(sampler,pName,ref param);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void SamplerParameter(uint sampler,uint pName,float param)
			=> glSamplerParameterf(sampler,pName,param);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void SamplerParameter(uint sampler,uint pName,ref float param)
			=> glSamplerParameterfv(sampler,pName,ref param);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void SamplerParameterI(uint sampler,uint pName,ref int param)
			=> glSamplerParameterIiv(sampler,pName,ref param);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void SamplerParameterI(uint sampler,uint pName,ref uint param)
			=> glSamplerParameterIuiv(sampler,pName,ref param);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetSamplerParameter(uint sampler,uint pName,ref int parameters)
			=> glGetSamplerParameteriv(sampler,pName,ref parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetSamplerParameterI(uint sampler,uint pName,ref int parameters)
			=> glGetSamplerParameterIiv(sampler,pName,ref parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetSamplerParameter(uint sampler,uint pName,ref float parameters)
			=> glGetSamplerParameterfv(sampler,pName,ref parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetSamplerParameterI(uint sampler,uint pName,ref uint parameters)
			=> glGetSamplerParameterIuiv(sampler,pName,ref parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void QueryCounter(uint id,uint target)
			=> glQueryCounter(id,target);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetQueryObject(uint id,uint pName,ref long parameters)
			=> glGetQueryObjecti64v(id,pName,ref parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetQueryObject(uint id,uint pName,ref ulong parameters)
			=> glGetQueryObjectui64v(id,pName,ref parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttribDivisor(uint index,uint divisor)
			=> glVertexAttribDivisor(index,divisor);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttribP1(uint index,uint type,byte normalized,uint value)
			=> glVertexAttribP1ui(index,type,normalized,value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttribP1(uint index,uint type,byte normalized,ref uint value)
			=> glVertexAttribP1uiv(index,type,normalized,ref value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttribP2(uint index,uint type,byte normalized,uint value)
			=> glVertexAttribP2ui(index,type,normalized,value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttribP2(uint index,uint type,byte normalized,ref uint value)
			=> glVertexAttribP2uiv(index,type,normalized,ref value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttribP3(uint index,uint type,byte normalized,uint value)
			=> glVertexAttribP3ui(index,type,normalized,value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttribP3(uint index,uint type,byte normalized,ref uint value)
			=> glVertexAttribP3uiv(index,type,normalized,ref value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttribP4(uint index,uint type,byte normalized,uint value)
			=> glVertexAttribP4ui(index,type,normalized,value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttribP4(uint index,uint type,byte normalized,ref uint value)
			=> glVertexAttribP4uiv(index,type,normalized,ref value);
	}
}
