using System;
using System.Runtime.InteropServices;

#pragma warning disable IDE0060 //Unused parameter.

namespace Dissonance.Framework.OpenGL
{
	partial class GL
	{
		[MethodImport("glBlendEquationSeparate","2.0")]
		public static void BlendEquationSeparate(uint modeRGB,uint modeAlpha)
			=> throw new NotImplementedException();

		[MethodImport("glDrawBuffers","2.0")]
		public static void DrawBuffers(int numDrawBuffers,ref uint bufs)
			=> throw new NotImplementedException();

		[MethodImport("glStencilOpSeparate","2.0")]
		public static void StencilOpSeparate(uint face,uint sfail,uint dpfail,uint dppass)
			=> throw new NotImplementedException();

		[MethodImport("glStencilFuncSeparate","2.0")]
		public static void StencilFuncSeparate(uint face,uint func,int refer,uint mask)
			=> throw new NotImplementedException();

		[MethodImport("glStencilMaskSeparate","2.0")]
		public static void StencilMaskSeparate(uint face,uint mask)
			=> throw new NotImplementedException();

		[MethodImport("glAttachShader","2.0")]
		public static void AttachShader(uint program,uint shader)
			=> throw new NotImplementedException();

		[MethodImport("glBindAttribLocation","2.0")]
		public static void BindAttribLocation(uint program,uint index,[In] [MarshalAs(UnmanagedType.LPStr)] string name)
			=> throw new NotImplementedException();

		[MethodImport("glCompileShader","2.0")]
		public static void CompileShader(uint shader)
			=> throw new NotImplementedException();

		[MethodImport("glCreateProgram","2.0")]
		public static uint CreateProgram()
			=> throw new NotImplementedException();

		[MethodImport("glCreateShader","2.0")]
		public static uint CreateShader(ShaderType type)
			=> throw new NotImplementedException();

		[MethodImport("glDeleteProgram","2.0")]
		public static void DeleteProgram(uint program)
			=> throw new NotImplementedException();

		[MethodImport("glDeleteShader","2.0")]
		public static void DeleteShader(uint shader)
			=> throw new NotImplementedException();

		[MethodImport("glDetachShader","2.0")]
		public static void DetachShader(uint program,uint shader)
			=> throw new NotImplementedException();

		[MethodImport("glDisableVertexAttribArray","2.0")]
		public static void DisableVertexAttribArray(uint index)
			=> throw new NotImplementedException();

		[MethodImport("glEnableVertexAttribArray","2.0")]
		public static void EnableVertexAttribArray(uint index)
			=> throw new NotImplementedException();

		[MethodImport("glGetActiveAttrib","2.0")]
		public static void GetActiveAttrib(uint program,uint index,int bufSize,ref int length,ref int size,ref uint type,IntPtr name)
			=> throw new NotImplementedException();

		[MethodImport("glGetActiveUniform","2.0")]
		public static void GetActiveUniform(uint program,uint index,int bufSize,ref int length,ref int size,out ActiveUniformType type,IntPtr name)
			=> throw new NotImplementedException();

		[MethodImport("glGetAttachedShaders","2.0")]
		public static void GetAttachedShaders(uint program,int maxCount,ref int count,ref uint shaders)
			=> throw new NotImplementedException();

		[MethodImport("glGetAttribLocation","2.0")]
		public static int GetAttribLocation(uint program,[In] [MarshalAs(UnmanagedType.LPStr)] string name)
			=> throw new NotImplementedException();

		[MethodImport("glGetProgramiv","2.0")]
		public static void GetProgram(uint program,GetProgramParameter parameter,out int results)
			=> throw new NotImplementedException();

		[MethodImport("glGetProgramInfoLog","2.0")]
		public static void GetProgramInfoLog(uint program,int bufSize,ref int length,IntPtr infoLog)
			=> throw new NotImplementedException();

		[MethodImport("glGetShaderiv","2.0")]
		public static void GetShader(uint shader,uint pName,ref int parameters)
			=> throw new NotImplementedException();

		[MethodImport("glGetShaderInfoLog","2.0")]
		public static void GetShaderInfoLog(uint shader,int bufSize,ref int length,IntPtr infoLog)
			=> throw new NotImplementedException();

		[MethodImport("glGetShaderSource","2.0")]
		public static void GetShaderSource(uint shader,int bufSize,ref int length,IntPtr source)
			=> throw new NotImplementedException();

		[MethodImport("glGetUniformLocation","2.0")]
		public static int GetUniformLocation(uint program,[In] [MarshalAs(UnmanagedType.LPStr)] string name)
			=> throw new NotImplementedException();

		[MethodImport("glGetUniformfv","2.0")]
		public static void GetUniform(uint program,int location,ref float parameters)
			=> throw new NotImplementedException();

		[MethodImport("glGetUniformiv","2.0")]
		public static void GetUniform(uint program,int location,ref int parameters)
			=> throw new NotImplementedException();

		[MethodImport("glGetVertexAttribdv","2.0")]
		public static void GetVertexAttrib(uint index,uint pName,ref double parameters)
			=> throw new NotImplementedException();

		[MethodImport("glGetVertexAttribfv","2.0")]
		public static void GetVertexAttrib(uint index,uint pName,ref float parameters)
			=> throw new NotImplementedException();

		[MethodImport("glGetVertexAttribiv","2.0")]
		public static void GetVertexAttrib(uint index,uint pName,ref int parameters)
			=> throw new NotImplementedException();

		[MethodImport("glGetVertexAttribPointerv","2.0")]
		public static void GetVertexAttribPointer(uint index,uint pName,ref IntPtr pointer)
			=> throw new NotImplementedException();

		[MethodImport("glIsProgram","2.0")]
		public static byte IsProgram(uint program)
			=> throw new NotImplementedException();

		[MethodImport("glIsShader","2.0")]
		public static byte IsShader(uint shader)
			=> throw new NotImplementedException();

		[MethodImport("glLinkProgram","2.0")]
		public static void LinkProgram(uint program)
			=> throw new NotImplementedException();

		[MethodImport("glShaderSource","2.0")]
		public static void ShaderSource(uint shader,int count,ref IntPtr str,ref int length)
			=> throw new NotImplementedException();

		[MethodImport("glUseProgram","2.0")]
		public static void UseProgram(uint program)
			=> throw new NotImplementedException();

		[MethodImport("glUniform1f","2.0")]
		public static void Uniform1(int location,float v0)
			=> throw new NotImplementedException();

		[MethodImport("glUniform2f","2.0")]
		public static void Uniform2(int location,float v0,float v1)
			=> throw new NotImplementedException();

		[MethodImport("glUniform3f","2.0")]
		public static void Uniform3(int location,float v0,float v1,float v2)
			=> throw new NotImplementedException();

		[MethodImport("glUniform4f","2.0")]
		public static void Uniform4(int location,float v0,float v1,float v2,float v3)
			=> throw new NotImplementedException();

		[MethodImport("glUniform1i","2.0")]
		public static void Uniform1(int location,int v0)
			=> throw new NotImplementedException();

		[MethodImport("glUniform2i","2.0")]
		public static void Uniform2(int location,int v0,int v1)
			=> throw new NotImplementedException();

		[MethodImport("glUniform3i","2.0")]
		public static void Uniform3(int location,int v0,int v1,int v2)
			=> throw new NotImplementedException();

		[MethodImport("glUniform4i","2.0")]
		public static void Uniform4(int location,int v0,int v1,int v2,int v3)
			=> throw new NotImplementedException();

		[MethodImport("glUniform1fv","2.0")]
		public static void Uniform1(int location,int count,ref float value)
			=> throw new NotImplementedException();

		[MethodImport("glUniform2fv","2.0")]
		public static void Uniform2(int location,int count,ref float value)
			=> throw new NotImplementedException();

		[MethodImport("glUniform3fv","2.0")]
		public static void Uniform3(int location,int count,ref float value)
			=> throw new NotImplementedException();

		[MethodImport("glUniform4fv","2.0")]
		public static void Uniform4(int location,int count,ref float value)
			=> throw new NotImplementedException();

		[MethodImport("glUniform1iv","2.0")]
		public static void Uniform1(int location,int count,ref int value)
			=> throw new NotImplementedException();

		[MethodImport("glUniform2iv","2.0")]
		public static void Uniform2(int location,int count,ref int value)
			=> throw new NotImplementedException();

		[MethodImport("glUniform3iv","2.0")]
		public static void Uniform3(int location,int count,ref int value)
			=> throw new NotImplementedException();

		[MethodImport("glUniform4iv","2.0")]
		public static void Uniform4(int location,int count,ref int value)
			=> throw new NotImplementedException();

		[MethodImport("glUniformMatrix2fv","2.0")]
		public static void UniformMatrix2(int location,int count,byte transpose,ref float value)
			=> throw new NotImplementedException();

		[MethodImport("glUniformMatrix3fv","2.0")]
		public static void UniformMatrix3(int location,int count,byte transpose,ref float value)
			=> throw new NotImplementedException();

		[MethodImport("glUniformMatrix4fv","2.0")]
		public static void UniformMatrix4(int location,int count,byte transpose,ref float value)
			=> throw new NotImplementedException();

		[MethodImport("glValidateProgram","2.0")]
		public static void ValidateProgram(uint program)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttrib1d","2.0")]
		public static void VertexAttrib1(uint index,double x)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttrib1dv","2.0")]
		public static void VertexAttrib1(uint index,ref double v)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttrib1f","2.0")]
		public static void VertexAttrib1(uint index,float x)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttrib1fv","2.0")]
		public static void VertexAttrib1(uint index,ref float v)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttrib1s","2.0")]
		public static void VertexAttrib1(uint index,short x)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttrib1sv","2.0")]
		public static void VertexAttrib1(uint index,ref short v)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttrib2d","2.0")]
		public static void VertexAttrib2(uint index,double x,double y)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttrib2dv","2.0")]
		public static void VertexAttrib2(uint index,ref double v)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttrib2f","2.0")]
		public static void VertexAttrib2(uint index,float x,float y)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttrib2fv","2.0")]
		public static void VertexAttrib2(uint index,ref float v)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttrib2s","2.0")]
		public static void VertexAttrib2(uint index,short x,short y)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttrib2sv","2.0")]
		public static void VertexAttrib2(uint index,ref short v)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttrib3d","2.0")]
		public static void VertexAttrib3(uint index,double x,double y,double z)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttrib3dv","2.0")]
		public static void VertexAttrib3(uint index,ref double v)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttrib3f","2.0")]
		public static void VertexAttrib3(uint index,float x,float y,float z)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttrib3fv","2.0")]
		public static void VertexAttrib3(uint index,ref float v)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttrib3s","2.0")]
		public static void VertexAttrib3(uint index,short x,short y,short z)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttrib3sv","2.0")]
		public static void VertexAttrib3(uint index,ref short v)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttrib4Nbv","2.0")]
		public static void VertexAttrib4N(uint index,sbyte[] v)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttrib4Niv","2.0")]
		public static void VertexAttrib4N(uint index,ref int v)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttrib4Nsv","2.0")]
		public static void VertexAttrib4N(uint index,ref short v)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttrib4Nub","2.0")]
		public static void VertexAttrib4N(uint index,byte x,byte y,byte z,byte w)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttrib4Nubv","2.0")]
		public static void VertexAttrib4N(uint index,byte[] v)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttrib4Nuiv","2.0")]
		public static void VertexAttrib4N(uint index,ref uint v)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttrib4Nusv","2.0")]
		public static void VertexAttrib4N(uint index,ref ushort v)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttrib4bv","2.0")]
		public static void VertexAttrib4(uint index,sbyte[] v)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttrib4d","2.0")]
		public static void VertexAttrib4(uint index,double x,double y,double z,double w)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttrib4dv","2.0")]
		public static void VertexAttrib4(uint index,ref double v)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttrib4f","2.0")]
		public static void VertexAttrib4(uint index,float x,float y,float z,float w)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttrib4fv","2.0")]
		public static void VertexAttrib4(uint index,ref float v)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttrib4iv","2.0")]
		public static void VertexAttrib4(uint index,ref int v)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttrib4s","2.0")]
		public static void VertexAttrib4(uint index,short x,short y,short z,short w)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttrib4sv","2.0")]
		public static void VertexAttrib4(uint index,ref short v)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttrib4ubv","2.0")]
		public static void VertexAttrib4(uint index,byte[] v)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttrib4uiv","2.0")]
		public static void VertexAttrib4(uint index,ref uint v)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttrib4usv","2.0")]
		public static void VertexAttrib4(uint index,ref ushort v)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttribPointer","2.0")]
		public static void VertexAttribPointer(uint index,int size,VertexAttribPointerType type,bool normalized,int stride,IntPtr pointer)
			=> throw new NotImplementedException();
	}
}