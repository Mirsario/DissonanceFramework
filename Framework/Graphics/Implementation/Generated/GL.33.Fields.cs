#pragma warning disable CS0649

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[MethodImport("glBindFragDataLocationIndexed")]
		private static BindFragDataLocationIndexedDelegate glBindFragDataLocationIndexed;

		[MethodImport("glGetFragDataIndex")]
		private static GetFragDataIndexDelegate glGetFragDataIndex;

		[MethodImport("glGenSamplers")]
		private static GenSamplersDelegate glGenSamplers;

		[MethodImport("glDeleteSamplers")]
		private static DeleteSamplersDelegate glDeleteSamplers;

		[MethodImport("glIsSampler")]
		private static IsSamplerDelegate glIsSampler;

		[MethodImport("glBindSampler")]
		private static BindSamplerDelegate glBindSampler;

		[MethodImport("glSamplerParameteri")]
		private static SamplerParameteriDelegate glSamplerParameteri;

		[MethodImport("glSamplerParameteriv")]
		private static SamplerParameterivDelegate glSamplerParameteriv;

		[MethodImport("glSamplerParameterf")]
		private static SamplerParameterfDelegate glSamplerParameterf;

		[MethodImport("glSamplerParameterfv")]
		private static SamplerParameterfvDelegate glSamplerParameterfv;

		[MethodImport("glSamplerParameterIiv")]
		private static SamplerParameterIivDelegate glSamplerParameterIiv;

		[MethodImport("glSamplerParameterIuiv")]
		private static SamplerParameterIuivDelegate glSamplerParameterIuiv;

		[MethodImport("glGetSamplerParameteriv")]
		private static GetSamplerParameterivDelegate glGetSamplerParameteriv;

		[MethodImport("glGetSamplerParameterIiv")]
		private static GetSamplerParameterIivDelegate glGetSamplerParameterIiv;

		[MethodImport("glGetSamplerParameterfv")]
		private static GetSamplerParameterfvDelegate glGetSamplerParameterfv;

		[MethodImport("glGetSamplerParameterIuiv")]
		private static GetSamplerParameterIuivDelegate glGetSamplerParameterIuiv;

		[MethodImport("glQueryCounter")]
		private static QueryCounterDelegate glQueryCounter;

		[MethodImport("glGetQueryObjecti64v")]
		private static GetQueryObjecti64vDelegate glGetQueryObjecti64v;

		[MethodImport("glGetQueryObjectui64v")]
		private static GetQueryObjectui64vDelegate glGetQueryObjectui64v;

		[MethodImport("glVertexAttribDivisor")]
		private static VertexAttribDivisorDelegate glVertexAttribDivisor;

		[MethodImport("glVertexAttribP1ui")]
		private static VertexAttribP1uiDelegate glVertexAttribP1ui;

		[MethodImport("glVertexAttribP1uiv")]
		private static VertexAttribP1uivDelegate glVertexAttribP1uiv;

		[MethodImport("glVertexAttribP2ui")]
		private static VertexAttribP2uiDelegate glVertexAttribP2ui;

		[MethodImport("glVertexAttribP2uiv")]
		private static VertexAttribP2uivDelegate glVertexAttribP2uiv;

		[MethodImport("glVertexAttribP3ui")]
		private static VertexAttribP3uiDelegate glVertexAttribP3ui;

		[MethodImport("glVertexAttribP3uiv")]
		private static VertexAttribP3uivDelegate glVertexAttribP3uiv;

		[MethodImport("glVertexAttribP4ui")]
		private static VertexAttribP4uiDelegate glVertexAttribP4ui;

		[MethodImport("glVertexAttribP4uiv")]
		private static VertexAttribP4uivDelegate glVertexAttribP4uiv;
	}
}
