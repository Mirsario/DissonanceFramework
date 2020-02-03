using System;
using System.Runtime.InteropServices;

#pragma warning disable IDE0060 //Unused parameter.

namespace Dissonance.Framework.OpenGL
{
	partial class GL
	{
		[MethodImport("glBindFragDataLocationIndexed","3.3")]
		public static void BindFragDataLocationIndexed(uint program,uint colorNumber,uint index,IntPtr name)
			=> throw new NotImplementedException();

		[MethodImport("glGetFragDataIndex","3.3")]
		public static int GetFragDataIndex(uint program,IntPtr name)
			=> throw new NotImplementedException();

		[MethodImport("glGenSamplers","3.3")]
		public static void GenSamplers(int count,ref uint samplers)
			=> throw new NotImplementedException();

		[MethodImport("glDeleteSamplers","3.3")]
		public static void DeleteSamplers(int count,ref uint samplers)
			=> throw new NotImplementedException();

		[MethodImport("glIsSampler","3.3")]
		public static byte IsSampler(uint sampler)
			=> throw new NotImplementedException();

		[MethodImport("glBindSampler","3.3")]
		public static void BindSampler(uint unit,uint sampler)
			=> throw new NotImplementedException();

		[MethodImport("glSamplerParameteri","3.3")]
		public static void SamplerParameter(uint sampler,uint pName,int param)
			=> throw new NotImplementedException();

		[MethodImport("glSamplerParameteriv","3.3")]
		public static void SamplerParameter(uint sampler,uint pName,ref int param)
			=> throw new NotImplementedException();

		[MethodImport("glSamplerParameterf","3.3")]
		public static void SamplerParameter(uint sampler,uint pName,float param)
			=> throw new NotImplementedException();

		[MethodImport("glSamplerParameterfv","3.3")]
		public static void SamplerParameter(uint sampler,uint pName,ref float param)
			=> throw new NotImplementedException();

		[MethodImport("glSamplerParameterIiv","3.3")]
		public static void SamplerParameterI(uint sampler,uint pName,ref int param)
			=> throw new NotImplementedException();

		[MethodImport("glSamplerParameterIuiv","3.3")]
		public static void SamplerParameterI(uint sampler,uint pName,ref uint param)
			=> throw new NotImplementedException();

		[MethodImport("glGetSamplerParameteriv","3.3")]
		public static void GetSamplerParameter(uint sampler,uint pName,ref int parameters)
			=> throw new NotImplementedException();

		[MethodImport("glGetSamplerParameterIiv","3.3")]
		public static void GetSamplerParameterI(uint sampler,uint pName,ref int parameters)
			=> throw new NotImplementedException();

		[MethodImport("glGetSamplerParameterfv","3.3")]
		public static void GetSamplerParameter(uint sampler,uint pName,ref float parameters)
			=> throw new NotImplementedException();

		[MethodImport("glGetSamplerParameterIuiv","3.3")]
		public static void GetSamplerParameterI(uint sampler,uint pName,ref uint parameters)
			=> throw new NotImplementedException();

		[MethodImport("glQueryCounter","3.3")]
		public static void QueryCounter(uint id,uint target)
			=> throw new NotImplementedException();

		[MethodImport("glGetQueryObjecti64v","3.3")]
		public static void GetQueryObject(uint id,uint pName,ref long parameters)
			=> throw new NotImplementedException();

		[MethodImport("glGetQueryObjectui64v","3.3")]
		public static void GetQueryObject(uint id,uint pName,ref ulong parameters)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttribDivisor","3.3")]
		public static void VertexAttribDivisor(uint index,uint divisor)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttribP1ui","3.3")]
		public static void VertexAttribP1(uint index,uint type,byte normalized,uint value)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttribP1uiv","3.3")]
		public static void VertexAttribP1(uint index,uint type,byte normalized,ref uint value)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttribP2ui","3.3")]
		public static void VertexAttribP2(uint index,uint type,byte normalized,uint value)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttribP2uiv","3.3")]
		public static void VertexAttribP2(uint index,uint type,byte normalized,ref uint value)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttribP3ui","3.3")]
		public static void VertexAttribP3(uint index,uint type,byte normalized,uint value)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttribP3uiv","3.3")]
		public static void VertexAttribP3(uint index,uint type,byte normalized,ref uint value)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttribP4ui","3.3")]
		public static void VertexAttribP4(uint index,uint type,byte normalized,uint value)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttribP4uiv","3.3")]
		public static void VertexAttribP4(uint index,uint type,byte normalized,ref uint value)
			=> throw new NotImplementedException();
	}
}