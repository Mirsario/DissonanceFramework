using System;

namespace Dissonance.Framework.Graphics.OpenGL
{
	unsafe partial class GL
	{
		[MethodImport("glBlendEquationSeparate", "2.0")]
		private static delegate*<BlendEquationModeEXT, BlendEquationModeEXT, void> glBlendEquationSeparate;
		
		public static void BlendEquationSeparate(BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha)
		{
			glBlendEquationSeparate(modeRGB, modeAlpha);
		}
		
		[MethodImport("glDrawBuffers", "2.0")]
		private static delegate*<int, DrawBufferMode, void> glDrawBuffers;
		
		public static void DrawBuffers(int n, DrawBufferMode bufs)
		{
			glDrawBuffers(n, bufs);
		}
		
		[MethodImport("glStencilOpSeparate", "2.0")]
		private static delegate*<StencilFaceDirection, StencilOp, StencilOp, StencilOp, void> glStencilOpSeparate;
		
		public static void StencilOpSeparate(StencilFaceDirection face, StencilOp sfail, StencilOp dpfail, StencilOp dppass)
		{
			glStencilOpSeparate(face, sfail, dpfail, dppass);
		}
		
		[MethodImport("glStencilFuncSeparate", "2.0")]
		private static delegate*<StencilFaceDirection, StencilFunction, int, uint, void> glStencilFuncSeparate;
		
		public static void StencilFuncSeparate(StencilFaceDirection face, StencilFunction func, int @ref, uint mask)
		{
			glStencilFuncSeparate(face, func, @ref, mask);
		}
		
		[MethodImport("glStencilMaskSeparate", "2.0")]
		private static delegate*<StencilFaceDirection, uint, void> glStencilMaskSeparate;
		
		public static void StencilMaskSeparate(StencilFaceDirection face, uint mask)
		{
			glStencilMaskSeparate(face, mask);
		}
		
		[MethodImport("glAttachShader", "2.0")]
		private static delegate*<uint, uint, void> glAttachShader;
		
		public static void AttachShader(uint program, uint shader)
		{
			glAttachShader(program, shader);
		}
		
		[MethodImport("glBindAttribLocation", "2.0")]
		private static delegate*<uint, uint, byte*, void> glBindAttribLocation;
		
		public static void BindAttribLocation(uint program, uint index, byte* name)
		{
			glBindAttribLocation(program, index, name);
		}
		
		[MethodImport("glCompileShader", "2.0")]
		private static delegate*<uint, void> glCompileShader;
		
		public static void CompileShader(uint shader)
		{
			glCompileShader(shader);
		}
		
		[MethodImport("glCreateProgram", "2.0")]
		private static delegate*<uint> glCreateProgram;
		
		public static uint CreateProgram()
		{
			return glCreateProgram();
		}
		
		[MethodImport("glCreateShader", "2.0")]
		private static delegate*<ShaderType, uint> glCreateShader;
		
		public static uint CreateShader(ShaderType type)
		{
			return glCreateShader(type);
		}
		
		[MethodImport("glDeleteProgram", "2.0")]
		private static delegate*<uint, void> glDeleteProgram;
		
		public static void DeleteProgram(uint program)
		{
			glDeleteProgram(program);
		}
		
		[MethodImport("glDeleteShader", "2.0")]
		private static delegate*<uint, void> glDeleteShader;
		
		public static void DeleteShader(uint shader)
		{
			glDeleteShader(shader);
		}
		
		[MethodImport("glDetachShader", "2.0")]
		private static delegate*<uint, uint, void> glDetachShader;
		
		public static void DetachShader(uint program, uint shader)
		{
			glDetachShader(program, shader);
		}
		
		[MethodImport("glDisableVertexAttribArray", "2.0")]
		private static delegate*<uint, void> glDisableVertexAttribArray;
		
		public static void DisableVertexAttribArray(uint index)
		{
			glDisableVertexAttribArray(index);
		}
		
		[MethodImport("glEnableVertexAttribArray", "2.0")]
		private static delegate*<uint, void> glEnableVertexAttribArray;
		
		public static void EnableVertexAttribArray(uint index)
		{
			glEnableVertexAttribArray(index);
		}
		
		[MethodImport("glGetActiveAttrib", "2.0")]
		private static delegate*<uint, uint, int, int*, int*, AttributeType, byte*, void> glGetActiveAttrib;
		
		public static void GetActiveAttrib(uint program, uint index, int bufSize, int* length, int* size, AttributeType type, byte* name)
		{
			glGetActiveAttrib(program, index, bufSize, length, size, type, name);
		}
		
		[MethodImport("glGetActiveUniform", "2.0")]
		private static delegate*<uint, uint, int, int*, int*, UniformType, byte*, void> glGetActiveUniform;
		
		public static void GetActiveUniform(uint program, uint index, int bufSize, int* length, int* size, UniformType type, byte* name)
		{
			glGetActiveUniform(program, index, bufSize, length, size, type, name);
		}
		
		[MethodImport("glGetAttachedShaders", "2.0")]
		private static delegate*<uint, int, int*, uint*, void> glGetAttachedShaders;
		
		public static void GetAttachedShaders(uint program, int maxCount, int* count, uint* shaders)
		{
			glGetAttachedShaders(program, maxCount, count, shaders);
		}
		
		[MethodImport("glGetAttribLocation", "2.0")]
		private static delegate*<uint, byte*, int> glGetAttribLocation;
		
		public static int GetAttribLocation(uint program, byte* name)
		{
			return glGetAttribLocation(program, name);
		}
		
		[MethodImport("glGetProgramiv", "2.0")]
		private static delegate*<uint, ProgramPropertyARB, int*, void> glGetProgramiv;
		
		public static void GetProgramiv(uint program, ProgramPropertyARB pname, int* @params)
		{
			glGetProgramiv(program, pname, @params);
		}
		
		[MethodImport("glGetProgramInfoLog", "2.0")]
		private static delegate*<uint, int, int*, byte*, void> glGetProgramInfoLog;
		
		public static void GetProgramInfoLog(uint program, int bufSize, int* length, byte* infoLog)
		{
			glGetProgramInfoLog(program, bufSize, length, infoLog);
		}
		
		[MethodImport("glGetShaderiv", "2.0")]
		private static delegate*<uint, ShaderParameterName, int*, void> glGetShaderiv;
		
		public static void GetShaderiv(uint shader, ShaderParameterName pname, int* @params)
		{
			glGetShaderiv(shader, pname, @params);
		}
		
		[MethodImport("glGetShaderInfoLog", "2.0")]
		private static delegate*<uint, int, int*, byte*, void> glGetShaderInfoLog;
		
		public static void GetShaderInfoLog(uint shader, int bufSize, int* length, byte* infoLog)
		{
			glGetShaderInfoLog(shader, bufSize, length, infoLog);
		}
		
		[MethodImport("glGetShaderSource", "2.0")]
		private static delegate*<uint, int, int*, byte*, void> glGetShaderSource;
		
		public static void GetShaderSource(uint shader, int bufSize, int* length, byte* source)
		{
			glGetShaderSource(shader, bufSize, length, source);
		}
		
		[MethodImport("glGetUniformLocation", "2.0")]
		private static delegate*<uint, byte*, int> glGetUniformLocation;
		
		public static int GetUniformLocation(uint program, byte* name)
		{
			return glGetUniformLocation(program, name);
		}
		
		[MethodImport("glGetUniformfv", "2.0")]
		private static delegate*<uint, int, float*, void> glGetUniformfv;
		
		public static void GetUniformfv(uint program, int location, float* @params)
		{
			glGetUniformfv(program, location, @params);
		}
		
		[MethodImport("glGetUniformiv", "2.0")]
		private static delegate*<uint, int, int*, void> glGetUniformiv;
		
		public static void GetUniformiv(uint program, int location, int* @params)
		{
			glGetUniformiv(program, location, @params);
		}
		
		[MethodImport("glGetVertexAttribdv", "2.0")]
		private static delegate*<uint, VertexAttribPropertyARB, double*, void> glGetVertexAttribdv;
		
		public static void GetVertexAttribdv(uint index, VertexAttribPropertyARB pname, double* @params)
		{
			glGetVertexAttribdv(index, pname, @params);
		}
		
		[MethodImport("glGetVertexAttribfv", "2.0")]
		private static delegate*<uint, VertexAttribPropertyARB, float*, void> glGetVertexAttribfv;
		
		public static void GetVertexAttribfv(uint index, VertexAttribPropertyARB pname, float* @params)
		{
			glGetVertexAttribfv(index, pname, @params);
		}
		
		[MethodImport("glGetVertexAttribiv", "2.0")]
		private static delegate*<uint, VertexAttribPropertyARB, int*, void> glGetVertexAttribiv;
		
		public static void GetVertexAttribiv(uint index, VertexAttribPropertyARB pname, int* @params)
		{
			glGetVertexAttribiv(index, pname, @params);
		}
		
		[MethodImport("glGetVertexAttribPointerv", "2.0")]
		private static delegate*<uint, VertexAttribPointerPropertyARB, void**, void> glGetVertexAttribPointerv;
		
		public static void GetVertexAttribPointerv(uint index, VertexAttribPointerPropertyARB pname, void** pointer)
		{
			glGetVertexAttribPointerv(index, pname, pointer);
		}
		
		[MethodImport("glIsProgram", "2.0")]
		private static delegate*<uint, bool> glIsProgram;
		
		public static bool IsProgram(uint program)
		{
			return glIsProgram(program);
		}
		
		[MethodImport("glIsShader", "2.0")]
		private static delegate*<uint, bool> glIsShader;
		
		public static bool IsShader(uint shader)
		{
			return glIsShader(shader);
		}
		
		[MethodImport("glLinkProgram", "2.0")]
		private static delegate*<uint, void> glLinkProgram;
		
		public static void LinkProgram(uint program)
		{
			glLinkProgram(program);
		}
		
		[MethodImport("glShaderSource", "2.0")]
		private static delegate*<uint, int, byte**, int*, void> glShaderSource;
		
		public static void ShaderSource(uint shader, int count, byte** @string, int* length)
		{
			glShaderSource(shader, count, @string, length);
		}
		
		[MethodImport("glUseProgram", "2.0")]
		private static delegate*<uint, void> glUseProgram;
		
		public static void UseProgram(uint program)
		{
			glUseProgram(program);
		}
		
		[MethodImport("glUniform1f", "2.0")]
		private static delegate*<int, float, void> glUniform1f;
		
		public static void Uniform1f(int location, float v0)
		{
			glUniform1f(location, v0);
		}
		
		[MethodImport("glUniform2f", "2.0")]
		private static delegate*<int, float, float, void> glUniform2f;
		
		public static void Uniform2f(int location, float v0, float v1)
		{
			glUniform2f(location, v0, v1);
		}
		
		[MethodImport("glUniform3f", "2.0")]
		private static delegate*<int, float, float, float, void> glUniform3f;
		
		public static void Uniform3f(int location, float v0, float v1, float v2)
		{
			glUniform3f(location, v0, v1, v2);
		}
		
		[MethodImport("glUniform4f", "2.0")]
		private static delegate*<int, float, float, float, float, void> glUniform4f;
		
		public static void Uniform4f(int location, float v0, float v1, float v2, float v3)
		{
			glUniform4f(location, v0, v1, v2, v3);
		}
		
		[MethodImport("glUniform1i", "2.0")]
		private static delegate*<int, int, void> glUniform1i;
		
		public static void Uniform1i(int location, int v0)
		{
			glUniform1i(location, v0);
		}
		
		[MethodImport("glUniform2i", "2.0")]
		private static delegate*<int, int, int, void> glUniform2i;
		
		public static void Uniform2i(int location, int v0, int v1)
		{
			glUniform2i(location, v0, v1);
		}
		
		[MethodImport("glUniform3i", "2.0")]
		private static delegate*<int, int, int, int, void> glUniform3i;
		
		public static void Uniform3i(int location, int v0, int v1, int v2)
		{
			glUniform3i(location, v0, v1, v2);
		}
		
		[MethodImport("glUniform4i", "2.0")]
		private static delegate*<int, int, int, int, int, void> glUniform4i;
		
		public static void Uniform4i(int location, int v0, int v1, int v2, int v3)
		{
			glUniform4i(location, v0, v1, v2, v3);
		}
		
		[MethodImport("glUniform1fv", "2.0")]
		private static delegate*<int, int, float*, void> glUniform1fv;
		
		public static void Uniform1fv(int location, int count, float* value)
		{
			glUniform1fv(location, count, value);
		}
		
		[MethodImport("glUniform2fv", "2.0")]
		private static delegate*<int, int, float*, void> glUniform2fv;
		
		public static void Uniform2fv(int location, int count, float* value)
		{
			glUniform2fv(location, count, value);
		}
		
		[MethodImport("glUniform3fv", "2.0")]
		private static delegate*<int, int, float*, void> glUniform3fv;
		
		public static void Uniform3fv(int location, int count, float* value)
		{
			glUniform3fv(location, count, value);
		}
		
		[MethodImport("glUniform4fv", "2.0")]
		private static delegate*<int, int, float*, void> glUniform4fv;
		
		public static void Uniform4fv(int location, int count, float* value)
		{
			glUniform4fv(location, count, value);
		}
		
		[MethodImport("glUniform1iv", "2.0")]
		private static delegate*<int, int, int*, void> glUniform1iv;
		
		public static void Uniform1iv(int location, int count, int* value)
		{
			glUniform1iv(location, count, value);
		}
		
		[MethodImport("glUniform2iv", "2.0")]
		private static delegate*<int, int, int*, void> glUniform2iv;
		
		public static void Uniform2iv(int location, int count, int* value)
		{
			glUniform2iv(location, count, value);
		}
		
		[MethodImport("glUniform3iv", "2.0")]
		private static delegate*<int, int, int*, void> glUniform3iv;
		
		public static void Uniform3iv(int location, int count, int* value)
		{
			glUniform3iv(location, count, value);
		}
		
		[MethodImport("glUniform4iv", "2.0")]
		private static delegate*<int, int, int*, void> glUniform4iv;
		
		public static void Uniform4iv(int location, int count, int* value)
		{
			glUniform4iv(location, count, value);
		}
		
		[MethodImport("glUniformMatrix2fv", "2.0")]
		private static delegate*<int, int, bool, float*, void> glUniformMatrix2fv;
		
		public static void UniformMatrix2fv(int location, int count, bool transpose, float* value)
		{
			glUniformMatrix2fv(location, count, transpose, value);
		}
		
		[MethodImport("glUniformMatrix3fv", "2.0")]
		private static delegate*<int, int, bool, float*, void> glUniformMatrix3fv;
		
		public static void UniformMatrix3fv(int location, int count, bool transpose, float* value)
		{
			glUniformMatrix3fv(location, count, transpose, value);
		}
		
		[MethodImport("glUniformMatrix4fv", "2.0")]
		private static delegate*<int, int, bool, float*, void> glUniformMatrix4fv;
		
		public static void UniformMatrix4fv(int location, int count, bool transpose, float* value)
		{
			glUniformMatrix4fv(location, count, transpose, value);
		}
		
		[MethodImport("glValidateProgram", "2.0")]
		private static delegate*<uint, void> glValidateProgram;
		
		public static void ValidateProgram(uint program)
		{
			glValidateProgram(program);
		}
		
		[MethodImport("glVertexAttrib1d", "2.0")]
		private static delegate*<uint, double, void> glVertexAttrib1d;
		
		public static void VertexAttrib1d(uint index, double x)
		{
			glVertexAttrib1d(index, x);
		}
		
		[MethodImport("glVertexAttrib1dv", "2.0")]
		private static delegate*<uint, double*, void> glVertexAttrib1dv;
		
		public static void VertexAttrib1dv(uint index, double* v)
		{
			glVertexAttrib1dv(index, v);
		}
		
		[MethodImport("glVertexAttrib1f", "2.0")]
		private static delegate*<uint, float, void> glVertexAttrib1f;
		
		public static void VertexAttrib1f(uint index, float x)
		{
			glVertexAttrib1f(index, x);
		}
		
		[MethodImport("glVertexAttrib1fv", "2.0")]
		private static delegate*<uint, float*, void> glVertexAttrib1fv;
		
		public static void VertexAttrib1fv(uint index, float* v)
		{
			glVertexAttrib1fv(index, v);
		}
		
		[MethodImport("glVertexAttrib1s", "2.0")]
		private static delegate*<uint, short, void> glVertexAttrib1s;
		
		public static void VertexAttrib1s(uint index, short x)
		{
			glVertexAttrib1s(index, x);
		}
		
		[MethodImport("glVertexAttrib1sv", "2.0")]
		private static delegate*<uint, short*, void> glVertexAttrib1sv;
		
		public static void VertexAttrib1sv(uint index, short* v)
		{
			glVertexAttrib1sv(index, v);
		}
		
		[MethodImport("glVertexAttrib2d", "2.0")]
		private static delegate*<uint, double, double, void> glVertexAttrib2d;
		
		public static void VertexAttrib2d(uint index, double x, double y)
		{
			glVertexAttrib2d(index, x, y);
		}
		
		[MethodImport("glVertexAttrib2dv", "2.0")]
		private static delegate*<uint, double*, void> glVertexAttrib2dv;
		
		public static void VertexAttrib2dv(uint index, double* v)
		{
			glVertexAttrib2dv(index, v);
		}
		
		[MethodImport("glVertexAttrib2f", "2.0")]
		private static delegate*<uint, float, float, void> glVertexAttrib2f;
		
		public static void VertexAttrib2f(uint index, float x, float y)
		{
			glVertexAttrib2f(index, x, y);
		}
		
		[MethodImport("glVertexAttrib2fv", "2.0")]
		private static delegate*<uint, float*, void> glVertexAttrib2fv;
		
		public static void VertexAttrib2fv(uint index, float* v)
		{
			glVertexAttrib2fv(index, v);
		}
		
		[MethodImport("glVertexAttrib2s", "2.0")]
		private static delegate*<uint, short, short, void> glVertexAttrib2s;
		
		public static void VertexAttrib2s(uint index, short x, short y)
		{
			glVertexAttrib2s(index, x, y);
		}
		
		[MethodImport("glVertexAttrib2sv", "2.0")]
		private static delegate*<uint, short*, void> glVertexAttrib2sv;
		
		public static void VertexAttrib2sv(uint index, short* v)
		{
			glVertexAttrib2sv(index, v);
		}
		
		[MethodImport("glVertexAttrib3d", "2.0")]
		private static delegate*<uint, double, double, double, void> glVertexAttrib3d;
		
		public static void VertexAttrib3d(uint index, double x, double y, double z)
		{
			glVertexAttrib3d(index, x, y, z);
		}
		
		[MethodImport("glVertexAttrib3dv", "2.0")]
		private static delegate*<uint, double*, void> glVertexAttrib3dv;
		
		public static void VertexAttrib3dv(uint index, double* v)
		{
			glVertexAttrib3dv(index, v);
		}
		
		[MethodImport("glVertexAttrib3f", "2.0")]
		private static delegate*<uint, float, float, float, void> glVertexAttrib3f;
		
		public static void VertexAttrib3f(uint index, float x, float y, float z)
		{
			glVertexAttrib3f(index, x, y, z);
		}
		
		[MethodImport("glVertexAttrib3fv", "2.0")]
		private static delegate*<uint, float*, void> glVertexAttrib3fv;
		
		public static void VertexAttrib3fv(uint index, float* v)
		{
			glVertexAttrib3fv(index, v);
		}
		
		[MethodImport("glVertexAttrib3s", "2.0")]
		private static delegate*<uint, short, short, short, void> glVertexAttrib3s;
		
		public static void VertexAttrib3s(uint index, short x, short y, short z)
		{
			glVertexAttrib3s(index, x, y, z);
		}
		
		[MethodImport("glVertexAttrib3sv", "2.0")]
		private static delegate*<uint, short*, void> glVertexAttrib3sv;
		
		public static void VertexAttrib3sv(uint index, short* v)
		{
			glVertexAttrib3sv(index, v);
		}
		
		[MethodImport("glVertexAttrib4Nbv", "2.0")]
		private static delegate*<uint, sbyte*, void> glVertexAttrib4Nbv;
		
		public static void VertexAttrib4Nbv(uint index, sbyte* v)
		{
			glVertexAttrib4Nbv(index, v);
		}
		
		[MethodImport("glVertexAttrib4Niv", "2.0")]
		private static delegate*<uint, int*, void> glVertexAttrib4Niv;
		
		public static void VertexAttrib4Niv(uint index, int* v)
		{
			glVertexAttrib4Niv(index, v);
		}
		
		[MethodImport("glVertexAttrib4Nsv", "2.0")]
		private static delegate*<uint, short*, void> glVertexAttrib4Nsv;
		
		public static void VertexAttrib4Nsv(uint index, short* v)
		{
			glVertexAttrib4Nsv(index, v);
		}
		
		[MethodImport("glVertexAttrib4Nub", "2.0")]
		private static delegate*<uint, byte, byte, byte, byte, void> glVertexAttrib4Nub;
		
		public static void VertexAttrib4Nub(uint index, byte x, byte y, byte z, byte w)
		{
			glVertexAttrib4Nub(index, x, y, z, w);
		}
		
		[MethodImport("glVertexAttrib4Nubv", "2.0")]
		private static delegate*<uint, byte*, void> glVertexAttrib4Nubv;
		
		public static void VertexAttrib4Nubv(uint index, byte* v)
		{
			glVertexAttrib4Nubv(index, v);
		}
		
		[MethodImport("glVertexAttrib4Nuiv", "2.0")]
		private static delegate*<uint, uint*, void> glVertexAttrib4Nuiv;
		
		public static void VertexAttrib4Nuiv(uint index, uint* v)
		{
			glVertexAttrib4Nuiv(index, v);
		}
		
		[MethodImport("glVertexAttrib4Nusv", "2.0")]
		private static delegate*<uint, ushort*, void> glVertexAttrib4Nusv;
		
		public static void VertexAttrib4Nusv(uint index, ushort* v)
		{
			glVertexAttrib4Nusv(index, v);
		}
		
		[MethodImport("glVertexAttrib4bv", "2.0")]
		private static delegate*<uint, sbyte*, void> glVertexAttrib4bv;
		
		public static void VertexAttrib4bv(uint index, sbyte* v)
		{
			glVertexAttrib4bv(index, v);
		}
		
		[MethodImport("glVertexAttrib4d", "2.0")]
		private static delegate*<uint, double, double, double, double, void> glVertexAttrib4d;
		
		public static void VertexAttrib4d(uint index, double x, double y, double z, double w)
		{
			glVertexAttrib4d(index, x, y, z, w);
		}
		
		[MethodImport("glVertexAttrib4dv", "2.0")]
		private static delegate*<uint, double*, void> glVertexAttrib4dv;
		
		public static void VertexAttrib4dv(uint index, double* v)
		{
			glVertexAttrib4dv(index, v);
		}
		
		[MethodImport("glVertexAttrib4f", "2.0")]
		private static delegate*<uint, float, float, float, float, void> glVertexAttrib4f;
		
		public static void VertexAttrib4f(uint index, float x, float y, float z, float w)
		{
			glVertexAttrib4f(index, x, y, z, w);
		}
		
		[MethodImport("glVertexAttrib4fv", "2.0")]
		private static delegate*<uint, float*, void> glVertexAttrib4fv;
		
		public static void VertexAttrib4fv(uint index, float* v)
		{
			glVertexAttrib4fv(index, v);
		}
		
		[MethodImport("glVertexAttrib4iv", "2.0")]
		private static delegate*<uint, int*, void> glVertexAttrib4iv;
		
		public static void VertexAttrib4iv(uint index, int* v)
		{
			glVertexAttrib4iv(index, v);
		}
		
		[MethodImport("glVertexAttrib4s", "2.0")]
		private static delegate*<uint, short, short, short, short, void> glVertexAttrib4s;
		
		public static void VertexAttrib4s(uint index, short x, short y, short z, short w)
		{
			glVertexAttrib4s(index, x, y, z, w);
		}
		
		[MethodImport("glVertexAttrib4sv", "2.0")]
		private static delegate*<uint, short*, void> glVertexAttrib4sv;
		
		public static void VertexAttrib4sv(uint index, short* v)
		{
			glVertexAttrib4sv(index, v);
		}
		
		[MethodImport("glVertexAttrib4ubv", "2.0")]
		private static delegate*<uint, byte*, void> glVertexAttrib4ubv;
		
		public static void VertexAttrib4ubv(uint index, byte* v)
		{
			glVertexAttrib4ubv(index, v);
		}
		
		[MethodImport("glVertexAttrib4uiv", "2.0")]
		private static delegate*<uint, uint*, void> glVertexAttrib4uiv;
		
		public static void VertexAttrib4uiv(uint index, uint* v)
		{
			glVertexAttrib4uiv(index, v);
		}
		
		[MethodImport("glVertexAttrib4usv", "2.0")]
		private static delegate*<uint, ushort*, void> glVertexAttrib4usv;
		
		public static void VertexAttrib4usv(uint index, ushort* v)
		{
			glVertexAttrib4usv(index, v);
		}
		
		[MethodImport("glVertexAttribPointer", "2.0")]
		private static delegate*<uint, int, VertexAttribPointerType, bool, int, void*, void> glVertexAttribPointer;
		
		public static void VertexAttribPointer(uint index, int size, VertexAttribPointerType type, bool normalized, int stride, void* pointer)
		{
			glVertexAttribPointer(index, size, type, normalized, stride, pointer);
		}
	}
}

