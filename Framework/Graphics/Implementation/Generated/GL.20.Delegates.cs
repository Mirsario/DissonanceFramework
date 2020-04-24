using System;
using System.Runtime.InteropServices;
using CC = System.Runtime.InteropServices.CallingConvention;
using UFP = System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute;

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[UFP(CC.Cdecl)]
		private unsafe delegate void BlendEquationSeparateDelegate(uint modeRGB,uint modeAlpha);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void DrawBuffersDelegate(int numDrawBuffers,uint* drawBuffers);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void StencilOpSeparateDelegate(uint face,uint sfail,uint dpfail,uint dppass);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void StencilFuncSeparateDelegate(uint face,uint func,int refer,uint mask);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void StencilMaskSeparateDelegate(uint face,uint mask);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void AttachShaderDelegate(uint program,uint shader);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void BindAttribLocationDelegate(uint program,uint index,IntPtr name);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void CompileShaderDelegate(uint shader);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate uint CreateProgramDelegate();
		
		[UFP(CC.Cdecl)]
		private unsafe delegate uint CreateShaderDelegate(ShaderType type);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void DeleteProgramDelegate(uint program);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void DeleteShaderDelegate(uint shader);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void DetachShaderDelegate(uint program,uint shader);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void DisableVertexAttribArrayDelegate(uint index);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void EnableVertexAttribArrayDelegate(uint index);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void GetActiveAttribDelegate(uint program,uint index,int bufSize,ref int length,ref int size,ref uint type,IntPtr name);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void GetActiveUniformDelegate(uint program,uint index,int bufSize,int* length,int* size,ActiveUniformType* type,IntPtr name);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void GetAttachedShadersDelegate(uint program,int maxCount,ref int count,ref uint shaders);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate int GetAttribLocationDelegate(uint program,IntPtr name);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void GetProgramivDelegate(uint program,GetProgramParameter parameter,out int results);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void GetProgramInfoLogDelegate(uint program,int bufSize,ref int length,IntPtr infoLog);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void GetShaderivDelegate(uint shader,ShaderParameterName pName,out int result);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void GetShaderInfoLogDelegate(uint shader,int bufSize,out int length,IntPtr infoLog);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void GetShaderSourceDelegate(uint shader,int bufSize,ref int length,IntPtr source);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate int GetUniformLocationDelegate(uint program,IntPtr name);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void GetUniformfvDelegate(uint program,int location,ref float parameters);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void GetUniformivDelegate(uint program,int location,ref int parameters);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void GetVertexAttribdvDelegate(uint index,uint pName,ref double parameters);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void GetVertexAttribfvDelegate(uint index,uint pName,ref float parameters);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void GetVertexAttribivDelegate(uint index,uint pName,ref int parameters);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void GetVertexAttribPointervDelegate(uint index,uint pName,ref IntPtr pointer);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate byte IsProgramDelegate(uint program);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate byte IsShaderDelegate(uint shader);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void LinkProgramDelegate(uint program);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void ShaderSourceDelegate(uint shader,int count,IntPtr str,int* length);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void UseProgramDelegate(uint program);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void Uniform1fDelegate(int location,float v0);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void Uniform2fDelegate(int location,float v0,float v1);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void Uniform3fDelegate(int location,float v0,float v1,float v2);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void Uniform4fDelegate(int location,float v0,float v1,float v2,float v3);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void Uniform1iDelegate(int location,int v0);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void Uniform2iDelegate(int location,int v0,int v1);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void Uniform3iDelegate(int location,int v0,int v1,int v2);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void Uniform4iDelegate(int location,int v0,int v1,int v2,int v3);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void Uniform1fvDelegate(int location,int count,float* value);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void Uniform2fvDelegate(int location,int count,float* value);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void Uniform3fvDelegate(int location,int count,float* value);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void Uniform4fvDelegate(int location,int count,float* value);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void Uniform1ivDelegate(int location,int count,int* value);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void Uniform2ivDelegate(int location,int count,int* value);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void Uniform3ivDelegate(int location,int count,int* value);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void Uniform4ivDelegate(int location,int count,int* value);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void UniformMatrix2fvDelegate(int location,int count,bool transpose,float* value);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void UniformMatrix3fvDelegate(int location,int count,bool transpose,float* value);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void UniformMatrix4fvDelegate(int location,int count,bool transpose,float* value);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void ValidateProgramDelegate(uint program);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttrib1dDelegate(uint index,double x);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttrib1dvDelegate(uint index,ref double v);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttrib1fDelegate(uint index,float x);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttrib1fvDelegate(uint index,ref float v);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttrib1sDelegate(uint index,short x);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttrib1svDelegate(uint index,ref short v);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttrib2dDelegate(uint index,double x,double y);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttrib2dvDelegate(uint index,double* v);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttrib2fDelegate(uint index,float x,float y);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttrib2fvDelegate(uint index,float* v);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttrib2sDelegate(uint index,short x,short y);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttrib2svDelegate(uint index,ref short v);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttrib3dDelegate(uint index,double x,double y,double z);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttrib3dvDelegate(uint index,ref double v);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttrib3fDelegate(uint index,float x,float y,float z);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttrib3fvDelegate(uint index,ref float v);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttrib3sDelegate(uint index,short x,short y,short z);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttrib3svDelegate(uint index,ref short v);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttrib4NbvDelegate(uint index,sbyte[] v);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttrib4NivDelegate(uint index,ref int v);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttrib4NsvDelegate(uint index,ref short v);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttrib4NubDelegate(uint index,byte x,byte y,byte z,byte w);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttrib4NubvDelegate(uint index,byte[] v);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttrib4NuivDelegate(uint index,ref uint v);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttrib4NusvDelegate(uint index,ref ushort v);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttrib4bvDelegate(uint index,sbyte[] v);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttrib4dDelegate(uint index,double x,double y,double z,double w);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttrib4dvDelegate(uint index,ref double v);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttrib4fDelegate(uint index,float x,float y,float z,float w);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttrib4fvDelegate(uint index,ref float v);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttrib4ivDelegate(uint index,ref int v);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttrib4sDelegate(uint index,short x,short y,short z,short w);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttrib4svDelegate(uint index,ref short v);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttrib4ubvDelegate(uint index,byte[] v);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttrib4uivDelegate(uint index,ref uint v);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttrib4usvDelegate(uint index,ref ushort v);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttribPointerDelegate(uint index,int size,VertexAttribPointerType type,bool normalized,int stride,IntPtr pointer);
	}
}
