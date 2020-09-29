using System;
using System.Runtime.InteropServices;
using CC = System.Runtime.InteropServices.CallingConvention;
using UFP = System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute;

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[UFP(CC.Cdecl)]
		private unsafe delegate void BindFragDataLocationIndexedDelegate(uint program, uint colorNumber, uint index, IntPtr name);

		[UFP(CC.Cdecl)]
		private unsafe delegate int GetFragDataIndexDelegate(uint program, IntPtr name);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GenSamplersDelegate(int count, ref uint samplers);

		[UFP(CC.Cdecl)]
		private unsafe delegate void DeleteSamplersDelegate(int count, ref uint samplers);

		[UFP(CC.Cdecl)]
		private unsafe delegate byte IsSamplerDelegate(uint sampler);

		[UFP(CC.Cdecl)]
		private unsafe delegate void BindSamplerDelegate(uint unit, uint sampler);

		[UFP(CC.Cdecl)]
		private unsafe delegate void SamplerParameteriDelegate(uint sampler, uint pName, int param);

		[UFP(CC.Cdecl)]
		private unsafe delegate void SamplerParameterivDelegate(uint sampler, uint pName, ref int param);

		[UFP(CC.Cdecl)]
		private unsafe delegate void SamplerParameterfDelegate(uint sampler, uint pName, float param);

		[UFP(CC.Cdecl)]
		private unsafe delegate void SamplerParameterfvDelegate(uint sampler, uint pName, ref float param);

		[UFP(CC.Cdecl)]
		private unsafe delegate void SamplerParameterIivDelegate(uint sampler, uint pName, ref int param);

		[UFP(CC.Cdecl)]
		private unsafe delegate void SamplerParameterIuivDelegate(uint sampler, uint pName, ref uint param);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetSamplerParameterivDelegate(uint sampler, uint pName, ref int parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetSamplerParameterIivDelegate(uint sampler, uint pName, ref int parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetSamplerParameterfvDelegate(uint sampler, uint pName, ref float parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetSamplerParameterIuivDelegate(uint sampler, uint pName, ref uint parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void QueryCounterDelegate(uint id, uint target);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetQueryObjecti64vDelegate(uint id, uint pName, ref long parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetQueryObjectui64vDelegate(uint id, uint pName, ref ulong parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttribDivisorDelegate(uint index, uint divisor);

		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttribP1uiDelegate(uint index, uint type, byte normalized, uint value);

		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttribP1uivDelegate(uint index, uint type, byte normalized, ref uint value);

		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttribP2uiDelegate(uint index, uint type, byte normalized, uint value);

		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttribP2uivDelegate(uint index, uint type, byte normalized, ref uint value);

		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttribP3uiDelegate(uint index, uint type, byte normalized, uint value);

		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttribP3uivDelegate(uint index, uint type, byte normalized, ref uint value);

		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttribP4uiDelegate(uint index, uint type, byte normalized, uint value);

		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttribP4uivDelegate(uint index, uint type, byte normalized, ref uint value);
	}
}
