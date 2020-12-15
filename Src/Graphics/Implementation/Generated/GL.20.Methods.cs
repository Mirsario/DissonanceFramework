using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[MethodImpl(ImplOptions)]
		public unsafe static void BlendEquationSeparate(uint modeRGB, uint modeAlpha)
			=> glBlendEquationSeparate(modeRGB, modeAlpha);

		[MethodImpl(ImplOptions)]
		public unsafe static void DrawBuffers(int numDrawBuffers, uint* drawBuffers)
			=> glDrawBuffers(numDrawBuffers, drawBuffers);

		[MethodImpl(ImplOptions)]
		public unsafe static void StencilOpSeparate(uint face, uint sfail, uint dpfail, uint dppass)
			=> glStencilOpSeparate(face, sfail, dpfail, dppass);

		[MethodImpl(ImplOptions)]
		public unsafe static void StencilFuncSeparate(uint face, uint func, int refer, uint mask)
			=> glStencilFuncSeparate(face, func, refer, mask);

		[MethodImpl(ImplOptions)]
		public unsafe static void StencilMaskSeparate(uint face, uint mask)
			=> glStencilMaskSeparate(face, mask);

		[MethodImpl(ImplOptions)]
		public unsafe static void AttachShader(uint program, uint shader)
			=> glAttachShader(program, shader);

		[MethodImpl(ImplOptions)]
		public unsafe static void BindAttribLocation(uint program, uint index, IntPtr name)
			=> glBindAttribLocation(program, index, name);

		[MethodImpl(ImplOptions)]
		public unsafe static void CompileShader(uint shader)
			=> glCompileShader(shader);

		[MethodImpl(ImplOptions)]
		public unsafe static uint CreateProgram()
			=> glCreateProgram();

		[MethodImpl(ImplOptions)]
		public unsafe static uint CreateShader(ShaderType type)
			=> glCreateShader(type);

		[MethodImpl(ImplOptions)]
		public unsafe static void DeleteProgram(uint program)
			=> glDeleteProgram(program);

		[MethodImpl(ImplOptions)]
		public unsafe static void DeleteShader(uint shader)
			=> glDeleteShader(shader);

		[MethodImpl(ImplOptions)]
		public unsafe static void DetachShader(uint program, uint shader)
			=> glDetachShader(program, shader);

		[MethodImpl(ImplOptions)]
		public unsafe static void DisableVertexAttribArray(uint index)
			=> glDisableVertexAttribArray(index);

		[MethodImpl(ImplOptions)]
		public unsafe static void EnableVertexAttribArray(uint index)
			=> glEnableVertexAttribArray(index);

		[MethodImpl(ImplOptions)]
		public unsafe static void GetActiveAttrib(uint program, uint index, int bufSize, ref int length, ref int size, ref uint type, IntPtr name)
			=> glGetActiveAttrib(program, index, bufSize, ref length, ref size, ref type, name);

		[MethodImpl(ImplOptions)]
		public unsafe static void GetActiveUniform(uint program, uint index, int bufSize, int* length, int* size, ActiveUniformType* type, IntPtr name)
			=> glGetActiveUniform(program, index, bufSize, length, size, type, name);

		[MethodImpl(ImplOptions)]
		public unsafe static void GetAttachedShaders(uint program, int maxCount, ref int count, ref uint shaders)
			=> glGetAttachedShaders(program, maxCount, ref count, ref shaders);

		[MethodImpl(ImplOptions)]
		public unsafe static int GetAttribLocation(uint program, IntPtr name)
			=> glGetAttribLocation(program, name);

		[MethodImpl(ImplOptions)]
		public unsafe static void GetProgram(uint program, GetProgramParameter parameter, out int results)
			=> glGetProgramiv(program, parameter, out results);

		[MethodImpl(ImplOptions)]
		public unsafe static void GetProgramInfoLog(uint program, int bufSize, ref int length, IntPtr infoLog)
			=> glGetProgramInfoLog(program, bufSize, ref length, infoLog);

		[MethodImpl(ImplOptions)]
		public unsafe static void GetShader(uint shader, ShaderParameterName pName, out int result)
			=> glGetShaderiv(shader, pName, out result);

		[MethodImpl(ImplOptions)]
		public unsafe static void GetShaderInfoLog(uint shader, int bufSize, out int length, IntPtr infoLog)
			=> glGetShaderInfoLog(shader, bufSize, out length, infoLog);

		[MethodImpl(ImplOptions)]
		public unsafe static void GetShaderSource(uint shader, int bufSize, ref int length, IntPtr source)
			=> glGetShaderSource(shader, bufSize, ref length, source);

		[MethodImpl(ImplOptions)]
		public unsafe static int GetUniformLocation(uint program, IntPtr name)
			=> glGetUniformLocation(program, name);

		[MethodImpl(ImplOptions)]
		public unsafe static void GetUniform(uint program, int location, ref float parameters)
			=> glGetUniformfv(program, location, ref parameters);

		[MethodImpl(ImplOptions)]
		public unsafe static void GetUniform(uint program, int location, ref int parameters)
			=> glGetUniformiv(program, location, ref parameters);

		[MethodImpl(ImplOptions)]
		public unsafe static void GetVertexAttrib(uint index, uint pName, ref double parameters)
			=> glGetVertexAttribdv(index, pName, ref parameters);

		[MethodImpl(ImplOptions)]
		public unsafe static void GetVertexAttrib(uint index, uint pName, ref float parameters)
			=> glGetVertexAttribfv(index, pName, ref parameters);

		[MethodImpl(ImplOptions)]
		public unsafe static void GetVertexAttrib(uint index, uint pName, ref int parameters)
			=> glGetVertexAttribiv(index, pName, ref parameters);

		[MethodImpl(ImplOptions)]
		public unsafe static void GetVertexAttribPointer(uint index, uint pName, ref IntPtr pointer)
			=> glGetVertexAttribPointerv(index, pName, ref pointer);

		[MethodImpl(ImplOptions)]
		public unsafe static byte IsProgram(uint program)
			=> glIsProgram(program);

		[MethodImpl(ImplOptions)]
		public unsafe static byte IsShader(uint shader)
			=> glIsShader(shader);

		[MethodImpl(ImplOptions)]
		public unsafe static void LinkProgram(uint program)
			=> glLinkProgram(program);

		[MethodImpl(ImplOptions)]
		public unsafe static void ShaderSource(uint shader, int count, IntPtr str, int* length)
			=> glShaderSource(shader, count, str, length);

		[MethodImpl(ImplOptions)]
		public unsafe static void UseProgram(uint program)
			=> glUseProgram(program);

		[MethodImpl(ImplOptions)]
		public unsafe static void Uniform1(int location, float v0)
			=> glUniform1f(location, v0);

		[MethodImpl(ImplOptions)]
		public unsafe static void Uniform2(int location, float v0, float v1)
			=> glUniform2f(location, v0, v1);

		[MethodImpl(ImplOptions)]
		public unsafe static void Uniform3(int location, float v0, float v1, float v2)
			=> glUniform3f(location, v0, v1, v2);

		[MethodImpl(ImplOptions)]
		public unsafe static void Uniform4(int location, float v0, float v1, float v2, float v3)
			=> glUniform4f(location, v0, v1, v2, v3);

		[MethodImpl(ImplOptions)]
		public unsafe static void Uniform1(int location, int v0)
			=> glUniform1i(location, v0);

		[MethodImpl(ImplOptions)]
		public unsafe static void Uniform2(int location, int v0, int v1)
			=> glUniform2i(location, v0, v1);

		[MethodImpl(ImplOptions)]
		public unsafe static void Uniform3(int location, int v0, int v1, int v2)
			=> glUniform3i(location, v0, v1, v2);

		[MethodImpl(ImplOptions)]
		public unsafe static void Uniform4(int location, int v0, int v1, int v2, int v3)
			=> glUniform4i(location, v0, v1, v2, v3);

		[MethodImpl(ImplOptions)]
		public unsafe static void Uniform1(int location, int count, float* value)
			=> glUniform1fv(location, count, value);

		[MethodImpl(ImplOptions)]
		public unsafe static void Uniform2(int location, int count, float* value)
			=> glUniform2fv(location, count, value);

		[MethodImpl(ImplOptions)]
		public unsafe static void Uniform3(int location, int count, float* value)
			=> glUniform3fv(location, count, value);

		[MethodImpl(ImplOptions)]
		public unsafe static void Uniform4(int location, int count, float* value)
			=> glUniform4fv(location, count, value);

		[MethodImpl(ImplOptions)]
		public unsafe static void Uniform1(int location, int count, int* value)
			=> glUniform1iv(location, count, value);

		[MethodImpl(ImplOptions)]
		public unsafe static void Uniform2(int location, int count, int* value)
			=> glUniform2iv(location, count, value);

		[MethodImpl(ImplOptions)]
		public unsafe static void Uniform3(int location, int count, int* value)
			=> glUniform3iv(location, count, value);

		[MethodImpl(ImplOptions)]
		public unsafe static void Uniform4(int location, int count, int* value)
			=> glUniform4iv(location, count, value);

		[MethodImpl(ImplOptions)]
		public unsafe static void UniformMatrix2(int location, int count, bool transpose, float* value)
			=> glUniformMatrix2fv(location, count, transpose, value);

		[MethodImpl(ImplOptions)]
		public unsafe static void UniformMatrix3(int location, int count, bool transpose, float* value)
			=> glUniformMatrix3fv(location, count, transpose, value);

		[MethodImpl(ImplOptions)]
		public unsafe static void UniformMatrix4(int location, int count, bool transpose, float* value)
			=> glUniformMatrix4fv(location, count, transpose, value);

		[MethodImpl(ImplOptions)]
		public unsafe static void ValidateProgram(uint program)
			=> glValidateProgram(program);

		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttrib1(uint index, double x)
			=> glVertexAttrib1d(index, x);

		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttrib1(uint index, ref double v)
			=> glVertexAttrib1dv(index, ref v);

		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttrib1(uint index, float x)
			=> glVertexAttrib1f(index, x);

		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttrib1(uint index, ref float v)
			=> glVertexAttrib1fv(index, ref v);

		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttrib1(uint index, short x)
			=> glVertexAttrib1s(index, x);

		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttrib1(uint index, ref short v)
			=> glVertexAttrib1sv(index, ref v);

		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttrib2(uint index, double x, double y)
			=> glVertexAttrib2d(index, x, y);

		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttrib2(uint index, double* v)
			=> glVertexAttrib2dv(index, v);

		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttrib2(uint index, float x, float y)
			=> glVertexAttrib2f(index, x, y);

		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttrib2(uint index, float* v)
			=> glVertexAttrib2fv(index, v);

		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttrib2(uint index, short x, short y)
			=> glVertexAttrib2s(index, x, y);

		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttrib2(uint index, ref short v)
			=> glVertexAttrib2sv(index, ref v);

		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttrib3(uint index, double x, double y, double z)
			=> glVertexAttrib3d(index, x, y, z);

		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttrib3(uint index, ref double v)
			=> glVertexAttrib3dv(index, ref v);

		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttrib3(uint index, float x, float y, float z)
			=> glVertexAttrib3f(index, x, y, z);

		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttrib3(uint index, ref float v)
			=> glVertexAttrib3fv(index, ref v);

		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttrib3(uint index, short x, short y, short z)
			=> glVertexAttrib3s(index, x, y, z);

		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttrib3(uint index, ref short v)
			=> glVertexAttrib3sv(index, ref v);

		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttrib4N(uint index, sbyte[] v)
			=> glVertexAttrib4Nbv(index, v);

		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttrib4N(uint index, ref int v)
			=> glVertexAttrib4Niv(index, ref v);

		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttrib4N(uint index, ref short v)
			=> glVertexAttrib4Nsv(index, ref v);

		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttrib4N(uint index, byte x, byte y, byte z, byte w)
			=> glVertexAttrib4Nub(index, x, y, z, w);

		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttrib4N(uint index, byte[] v)
			=> glVertexAttrib4Nubv(index, v);

		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttrib4N(uint index, ref uint v)
			=> glVertexAttrib4Nuiv(index, ref v);

		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttrib4N(uint index, ref ushort v)
			=> glVertexAttrib4Nusv(index, ref v);

		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttrib4(uint index, sbyte[] v)
			=> glVertexAttrib4bv(index, v);

		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttrib4(uint index, double x, double y, double z, double w)
			=> glVertexAttrib4d(index, x, y, z, w);

		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttrib4(uint index, ref double v)
			=> glVertexAttrib4dv(index, ref v);

		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttrib4(uint index, float x, float y, float z, float w)
			=> glVertexAttrib4f(index, x, y, z, w);

		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttrib4(uint index, ref float v)
			=> glVertexAttrib4fv(index, ref v);

		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttrib4(uint index, ref int v)
			=> glVertexAttrib4iv(index, ref v);

		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttrib4(uint index, short x, short y, short z, short w)
			=> glVertexAttrib4s(index, x, y, z, w);

		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttrib4(uint index, ref short v)
			=> glVertexAttrib4sv(index, ref v);

		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttrib4(uint index, byte[] v)
			=> glVertexAttrib4ubv(index, v);

		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttrib4(uint index, ref uint v)
			=> glVertexAttrib4uiv(index, ref v);

		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttrib4(uint index, ref ushort v)
			=> glVertexAttrib4usv(index, ref v);

		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttribPointer(uint index, int size, VertexAttribPointerType type, bool normalized, int stride, IntPtr pointer)
			=> glVertexAttribPointer(index, size, type, normalized, stride, pointer);
	}
}
