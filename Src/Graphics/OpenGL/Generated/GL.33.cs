using System;

namespace Dissonance.Framework.Graphics.OpenGL
{
	unsafe partial class GL
	{
		[MethodImport("glBindFragDataLocationIndexed", "3.3")]
		private static delegate*<uint, uint, uint, byte*, void> glBindFragDataLocationIndexed;
		
		public static void BindFragDataLocationIndexed(uint program, uint colorNumber, uint index, byte* name)
		{
			glBindFragDataLocationIndexed(program, colorNumber, index, name);
		}
		
		[MethodImport("glGetFragDataIndex", "3.3")]
		private static delegate*<uint, byte*, int> glGetFragDataIndex;
		
		public static int GetFragDataIndex(uint program, byte* name)
		{
			return glGetFragDataIndex(program, name);
		}
		
		[MethodImport("glGenSamplers", "3.3")]
		private static delegate*<int, uint*, void> glGenSamplers;
		
		public static void GenSamplers(int count, uint* samplers)
		{
			glGenSamplers(count, samplers);
		}
		
		[MethodImport("glDeleteSamplers", "3.3")]
		private static delegate*<int, uint*, void> glDeleteSamplers;
		
		public static void DeleteSamplers(int count, uint* samplers)
		{
			glDeleteSamplers(count, samplers);
		}
		
		[MethodImport("glIsSampler", "3.3")]
		private static delegate*<uint, bool> glIsSampler;
		
		public static bool IsSampler(uint sampler)
		{
			return glIsSampler(sampler);
		}
		
		[MethodImport("glBindSampler", "3.3")]
		private static delegate*<uint, uint, void> glBindSampler;
		
		public static void BindSampler(uint unit, uint sampler)
		{
			glBindSampler(unit, sampler);
		}
		
		[MethodImport("glSamplerParameteri", "3.3")]
		private static delegate*<uint, SamplerParameterI, int, void> glSamplerParameteri;
		
		public static void SamplerParameteri(uint sampler, SamplerParameterI pname, int param)
		{
			glSamplerParameteri(sampler, pname, param);
		}
		
		[MethodImport("glSamplerParameteriv", "3.3")]
		private static delegate*<uint, SamplerParameterI, int*, void> glSamplerParameteriv;
		
		public static void SamplerParameteriv(uint sampler, SamplerParameterI pname, int* param)
		{
			glSamplerParameteriv(sampler, pname, param);
		}
		
		[MethodImport("glSamplerParameterf", "3.3")]
		private static delegate*<uint, SamplerParameterF, float, void> glSamplerParameterf;
		
		public static void SamplerParameterf(uint sampler, SamplerParameterF pname, float param)
		{
			glSamplerParameterf(sampler, pname, param);
		}
		
		[MethodImport("glSamplerParameterfv", "3.3")]
		private static delegate*<uint, SamplerParameterF, float*, void> glSamplerParameterfv;
		
		public static void SamplerParameterfv(uint sampler, SamplerParameterF pname, float* param)
		{
			glSamplerParameterfv(sampler, pname, param);
		}
		
		[MethodImport("glSamplerParameterIiv", "3.3")]
		private static delegate*<uint, SamplerParameterI, int*, void> glSamplerParameterIiv;
		
		public static void SamplerParameterIiv(uint sampler, SamplerParameterI pname, int* param)
		{
			glSamplerParameterIiv(sampler, pname, param);
		}
		
		[MethodImport("glSamplerParameterIuiv", "3.3")]
		private static delegate*<uint, SamplerParameterI, uint*, void> glSamplerParameterIuiv;
		
		public static void SamplerParameterIuiv(uint sampler, SamplerParameterI pname, uint* param)
		{
			glSamplerParameterIuiv(sampler, pname, param);
		}
		
		[MethodImport("glGetSamplerParameteriv", "3.3")]
		private static delegate*<uint, SamplerParameterI, int*, void> glGetSamplerParameteriv;
		
		public static void GetSamplerParameteriv(uint sampler, SamplerParameterI pname, int* @params)
		{
			glGetSamplerParameteriv(sampler, pname, @params);
		}
		
		[MethodImport("glGetSamplerParameterIiv", "3.3")]
		private static delegate*<uint, SamplerParameterI, int*, void> glGetSamplerParameterIiv;
		
		public static void GetSamplerParameterIiv(uint sampler, SamplerParameterI pname, int* @params)
		{
			glGetSamplerParameterIiv(sampler, pname, @params);
		}
		
		[MethodImport("glGetSamplerParameterfv", "3.3")]
		private static delegate*<uint, SamplerParameterF, float*, void> glGetSamplerParameterfv;
		
		public static void GetSamplerParameterfv(uint sampler, SamplerParameterF pname, float* @params)
		{
			glGetSamplerParameterfv(sampler, pname, @params);
		}
		
		[MethodImport("glGetSamplerParameterIuiv", "3.3")]
		private static delegate*<uint, SamplerParameterI, uint*, void> glGetSamplerParameterIuiv;
		
		public static void GetSamplerParameterIuiv(uint sampler, SamplerParameterI pname, uint* @params)
		{
			glGetSamplerParameterIuiv(sampler, pname, @params);
		}
		
		[MethodImport("glQueryCounter", "3.3")]
		private static delegate*<uint, QueryCounterTarget, void> glQueryCounter;
		
		public static void QueryCounter(uint id, QueryCounterTarget target)
		{
			glQueryCounter(id, target);
		}
		
		[MethodImport("glGetQueryObjecti64v", "3.3")]
		private static delegate*<uint, QueryObjectParameterName, long*, void> glGetQueryObjecti64v;
		
		public static void GetQueryObjecti64v(uint id, QueryObjectParameterName pname, long* @params)
		{
			glGetQueryObjecti64v(id, pname, @params);
		}
		
		[MethodImport("glGetQueryObjectui64v", "3.3")]
		private static delegate*<uint, QueryObjectParameterName, ulong*, void> glGetQueryObjectui64v;
		
		public static void GetQueryObjectui64v(uint id, QueryObjectParameterName pname, ulong* @params)
		{
			glGetQueryObjectui64v(id, pname, @params);
		}
		
		[MethodImport("glVertexAttribDivisor", "3.3")]
		private static delegate*<uint, uint, void> glVertexAttribDivisor;
		
		public static void VertexAttribDivisor(uint index, uint divisor)
		{
			glVertexAttribDivisor(index, divisor);
		}
		
		[MethodImport("glVertexAttribP1ui", "3.3")]
		private static delegate*<uint, VertexAttribPointerType, bool, uint, void> glVertexAttribP1ui;
		
		public static void VertexAttribP1ui(uint index, VertexAttribPointerType type, bool normalized, uint value)
		{
			glVertexAttribP1ui(index, type, normalized, value);
		}
		
		[MethodImport("glVertexAttribP1uiv", "3.3")]
		private static delegate*<uint, VertexAttribPointerType, bool, uint*, void> glVertexAttribP1uiv;
		
		public static void VertexAttribP1uiv(uint index, VertexAttribPointerType type, bool normalized, uint* value)
		{
			glVertexAttribP1uiv(index, type, normalized, value);
		}
		
		[MethodImport("glVertexAttribP2ui", "3.3")]
		private static delegate*<uint, VertexAttribPointerType, bool, uint, void> glVertexAttribP2ui;
		
		public static void VertexAttribP2ui(uint index, VertexAttribPointerType type, bool normalized, uint value)
		{
			glVertexAttribP2ui(index, type, normalized, value);
		}
		
		[MethodImport("glVertexAttribP2uiv", "3.3")]
		private static delegate*<uint, VertexAttribPointerType, bool, uint*, void> glVertexAttribP2uiv;
		
		public static void VertexAttribP2uiv(uint index, VertexAttribPointerType type, bool normalized, uint* value)
		{
			glVertexAttribP2uiv(index, type, normalized, value);
		}
		
		[MethodImport("glVertexAttribP3ui", "3.3")]
		private static delegate*<uint, VertexAttribPointerType, bool, uint, void> glVertexAttribP3ui;
		
		public static void VertexAttribP3ui(uint index, VertexAttribPointerType type, bool normalized, uint value)
		{
			glVertexAttribP3ui(index, type, normalized, value);
		}
		
		[MethodImport("glVertexAttribP3uiv", "3.3")]
		private static delegate*<uint, VertexAttribPointerType, bool, uint*, void> glVertexAttribP3uiv;
		
		public static void VertexAttribP3uiv(uint index, VertexAttribPointerType type, bool normalized, uint* value)
		{
			glVertexAttribP3uiv(index, type, normalized, value);
		}
		
		[MethodImport("glVertexAttribP4ui", "3.3")]
		private static delegate*<uint, VertexAttribPointerType, bool, uint, void> glVertexAttribP4ui;
		
		public static void VertexAttribP4ui(uint index, VertexAttribPointerType type, bool normalized, uint value)
		{
			glVertexAttribP4ui(index, type, normalized, value);
		}
		
		[MethodImport("glVertexAttribP4uiv", "3.3")]
		private static delegate*<uint, VertexAttribPointerType, bool, uint*, void> glVertexAttribP4uiv;
		
		public static void VertexAttribP4uiv(uint index, VertexAttribPointerType type, bool normalized, uint* value)
		{
			glVertexAttribP4uiv(index, type, normalized, value);
		}
		
		[MethodImport("glVertexP2ui", "3.3")]
		private static delegate*<VertexPointerType, uint, void> glVertexP2ui;
		
		public static void VertexP2ui(VertexPointerType type, uint value)
		{
			glVertexP2ui(type, value);
		}
		
		[MethodImport("glVertexP2uiv", "3.3")]
		private static delegate*<VertexPointerType, uint*, void> glVertexP2uiv;
		
		public static void VertexP2uiv(VertexPointerType type, uint* value)
		{
			glVertexP2uiv(type, value);
		}
		
		[MethodImport("glVertexP3ui", "3.3")]
		private static delegate*<VertexPointerType, uint, void> glVertexP3ui;
		
		public static void VertexP3ui(VertexPointerType type, uint value)
		{
			glVertexP3ui(type, value);
		}
		
		[MethodImport("glVertexP3uiv", "3.3")]
		private static delegate*<VertexPointerType, uint*, void> glVertexP3uiv;
		
		public static void VertexP3uiv(VertexPointerType type, uint* value)
		{
			glVertexP3uiv(type, value);
		}
		
		[MethodImport("glVertexP4ui", "3.3")]
		private static delegate*<VertexPointerType, uint, void> glVertexP4ui;
		
		public static void VertexP4ui(VertexPointerType type, uint value)
		{
			glVertexP4ui(type, value);
		}
		
		[MethodImport("glVertexP4uiv", "3.3")]
		private static delegate*<VertexPointerType, uint*, void> glVertexP4uiv;
		
		public static void VertexP4uiv(VertexPointerType type, uint* value)
		{
			glVertexP4uiv(type, value);
		}
		
		[MethodImport("glTexCoordP1ui", "3.3")]
		private static delegate*<TexCoordPointerType, uint, void> glTexCoordP1ui;
		
		public static void TexCoordP1ui(TexCoordPointerType type, uint coords)
		{
			glTexCoordP1ui(type, coords);
		}
		
		[MethodImport("glTexCoordP1uiv", "3.3")]
		private static delegate*<TexCoordPointerType, uint*, void> glTexCoordP1uiv;
		
		public static void TexCoordP1uiv(TexCoordPointerType type, uint* coords)
		{
			glTexCoordP1uiv(type, coords);
		}
		
		[MethodImport("glTexCoordP2ui", "3.3")]
		private static delegate*<TexCoordPointerType, uint, void> glTexCoordP2ui;
		
		public static void TexCoordP2ui(TexCoordPointerType type, uint coords)
		{
			glTexCoordP2ui(type, coords);
		}
		
		[MethodImport("glTexCoordP2uiv", "3.3")]
		private static delegate*<TexCoordPointerType, uint*, void> glTexCoordP2uiv;
		
		public static void TexCoordP2uiv(TexCoordPointerType type, uint* coords)
		{
			glTexCoordP2uiv(type, coords);
		}
		
		[MethodImport("glTexCoordP3ui", "3.3")]
		private static delegate*<TexCoordPointerType, uint, void> glTexCoordP3ui;
		
		public static void TexCoordP3ui(TexCoordPointerType type, uint coords)
		{
			glTexCoordP3ui(type, coords);
		}
		
		[MethodImport("glTexCoordP3uiv", "3.3")]
		private static delegate*<TexCoordPointerType, uint*, void> glTexCoordP3uiv;
		
		public static void TexCoordP3uiv(TexCoordPointerType type, uint* coords)
		{
			glTexCoordP3uiv(type, coords);
		}
		
		[MethodImport("glTexCoordP4ui", "3.3")]
		private static delegate*<TexCoordPointerType, uint, void> glTexCoordP4ui;
		
		public static void TexCoordP4ui(TexCoordPointerType type, uint coords)
		{
			glTexCoordP4ui(type, coords);
		}
		
		[MethodImport("glTexCoordP4uiv", "3.3")]
		private static delegate*<TexCoordPointerType, uint*, void> glTexCoordP4uiv;
		
		public static void TexCoordP4uiv(TexCoordPointerType type, uint* coords)
		{
			glTexCoordP4uiv(type, coords);
		}
		
		[MethodImport("glMultiTexCoordP1ui", "3.3")]
		private static delegate*<TextureUnit, TexCoordPointerType, uint, void> glMultiTexCoordP1ui;
		
		public static void MultiTexCoordP1ui(TextureUnit texture, TexCoordPointerType type, uint coords)
		{
			glMultiTexCoordP1ui(texture, type, coords);
		}
		
		[MethodImport("glMultiTexCoordP1uiv", "3.3")]
		private static delegate*<TextureUnit, TexCoordPointerType, uint*, void> glMultiTexCoordP1uiv;
		
		public static void MultiTexCoordP1uiv(TextureUnit texture, TexCoordPointerType type, uint* coords)
		{
			glMultiTexCoordP1uiv(texture, type, coords);
		}
		
		[MethodImport("glMultiTexCoordP2ui", "3.3")]
		private static delegate*<TextureUnit, TexCoordPointerType, uint, void> glMultiTexCoordP2ui;
		
		public static void MultiTexCoordP2ui(TextureUnit texture, TexCoordPointerType type, uint coords)
		{
			glMultiTexCoordP2ui(texture, type, coords);
		}
		
		[MethodImport("glMultiTexCoordP2uiv", "3.3")]
		private static delegate*<TextureUnit, TexCoordPointerType, uint*, void> glMultiTexCoordP2uiv;
		
		public static void MultiTexCoordP2uiv(TextureUnit texture, TexCoordPointerType type, uint* coords)
		{
			glMultiTexCoordP2uiv(texture, type, coords);
		}
		
		[MethodImport("glMultiTexCoordP3ui", "3.3")]
		private static delegate*<TextureUnit, TexCoordPointerType, uint, void> glMultiTexCoordP3ui;
		
		public static void MultiTexCoordP3ui(TextureUnit texture, TexCoordPointerType type, uint coords)
		{
			glMultiTexCoordP3ui(texture, type, coords);
		}
		
		[MethodImport("glMultiTexCoordP3uiv", "3.3")]
		private static delegate*<TextureUnit, TexCoordPointerType, uint*, void> glMultiTexCoordP3uiv;
		
		public static void MultiTexCoordP3uiv(TextureUnit texture, TexCoordPointerType type, uint* coords)
		{
			glMultiTexCoordP3uiv(texture, type, coords);
		}
		
		[MethodImport("glMultiTexCoordP4ui", "3.3")]
		private static delegate*<TextureUnit, TexCoordPointerType, uint, void> glMultiTexCoordP4ui;
		
		public static void MultiTexCoordP4ui(TextureUnit texture, TexCoordPointerType type, uint coords)
		{
			glMultiTexCoordP4ui(texture, type, coords);
		}
		
		[MethodImport("glMultiTexCoordP4uiv", "3.3")]
		private static delegate*<TextureUnit, TexCoordPointerType, uint*, void> glMultiTexCoordP4uiv;
		
		public static void MultiTexCoordP4uiv(TextureUnit texture, TexCoordPointerType type, uint* coords)
		{
			glMultiTexCoordP4uiv(texture, type, coords);
		}
		
		[MethodImport("glNormalP3ui", "3.3")]
		private static delegate*<NormalPointerType, uint, void> glNormalP3ui;
		
		public static void NormalP3ui(NormalPointerType type, uint coords)
		{
			glNormalP3ui(type, coords);
		}
		
		[MethodImport("glNormalP3uiv", "3.3")]
		private static delegate*<NormalPointerType, uint*, void> glNormalP3uiv;
		
		public static void NormalP3uiv(NormalPointerType type, uint* coords)
		{
			glNormalP3uiv(type, coords);
		}
		
		[MethodImport("glColorP3ui", "3.3")]
		private static delegate*<ColorPointerType, uint, void> glColorP3ui;
		
		public static void ColorP3ui(ColorPointerType type, uint color)
		{
			glColorP3ui(type, color);
		}
		
		[MethodImport("glColorP3uiv", "3.3")]
		private static delegate*<ColorPointerType, uint*, void> glColorP3uiv;
		
		public static void ColorP3uiv(ColorPointerType type, uint* color)
		{
			glColorP3uiv(type, color);
		}
		
		[MethodImport("glColorP4ui", "3.3")]
		private static delegate*<ColorPointerType, uint, void> glColorP4ui;
		
		public static void ColorP4ui(ColorPointerType type, uint color)
		{
			glColorP4ui(type, color);
		}
		
		[MethodImport("glColorP4uiv", "3.3")]
		private static delegate*<ColorPointerType, uint*, void> glColorP4uiv;
		
		public static void ColorP4uiv(ColorPointerType type, uint* color)
		{
			glColorP4uiv(type, color);
		}
		
		[MethodImport("glSecondaryColorP3ui", "3.3")]
		private static delegate*<ColorPointerType, uint, void> glSecondaryColorP3ui;
		
		public static void SecondaryColorP3ui(ColorPointerType type, uint color)
		{
			glSecondaryColorP3ui(type, color);
		}
		
		[MethodImport("glSecondaryColorP3uiv", "3.3")]
		private static delegate*<ColorPointerType, uint*, void> glSecondaryColorP3uiv;
		
		public static void SecondaryColorP3uiv(ColorPointerType type, uint* color)
		{
			glSecondaryColorP3uiv(type, color);
		}
	}
}

