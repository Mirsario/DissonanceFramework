using System;
using System.Runtime.InteropServices;
using CC = System.Runtime.InteropServices.CallingConvention;
using UFP = System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute;

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[UFP(CC.Cdecl)]
		private unsafe delegate void MinSampleShadingDelegate(float value);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void BlendEquationiDelegate(uint buf,uint mode);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void BlendEquationSeparateiDelegate(uint buf,uint modeRGB,uint modeAlpha);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void BlendFunciDelegate(uint buf,BlendingFactor src,BlendingFactor dst);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void BlendFuncSeparateiDelegate(uint buf,uint srcRGB,uint dstRGB,uint srcAlpha,uint dstAlpha);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void DrawArraysIndirectDelegate(uint mode,IntPtr indirect);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void DrawElementsIndirectDelegate(uint mode,uint type,IntPtr indirect);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void Uniform1dDelegate(int location,double x);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void Uniform2dDelegate(int location,double x,double y);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void Uniform3dDelegate(int location,double x,double y,double z);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void Uniform4dDelegate(int location,double x,double y,double z,double w);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void Uniform1dvDelegate(int location,int count,double* value);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void Uniform2dvDelegate(int location,int count,double* value);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void Uniform3dvDelegate(int location,int count,double* value);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void Uniform4dvDelegate(int location,int count,double* value);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void UniformMatrix2dvDelegate(int location,int count,byte transpose,double* value);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void UniformMatrix3dvDelegate(int location,int count,byte transpose,double* value);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void UniformMatrix4dvDelegate(int location,int count,byte transpose,double* value);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void UniformMatrix2x3dvDelegate(int location,int count,byte transpose,double* value);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void UniformMatrix2x4dvDelegate(int location,int count,byte transpose,double* value);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void UniformMatrix3x2dvDelegate(int location,int count,byte transpose,double* value);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void UniformMatrix3x4dvDelegate(int location,int count,byte transpose,double* value);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void UniformMatrix4x2dvDelegate(int location,int count,byte transpose,double* value);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void UniformMatrix4x3dvDelegate(int location,int count,byte transpose,double* value);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void GetUniformdvDelegate(uint program,int location,double* parameters);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate int GetSubroutineUniformLocationDelegate(uint program,uint shadertype,IntPtr name);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate uint GetSubroutineIndexDelegate(uint program,uint shadertype,IntPtr name);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void GetActiveSubroutineUniformivDelegate(uint program,uint shadertype,uint index,uint pName,int* values);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void GetActiveSubroutineUniformNameDelegate(uint program,uint shadertype,uint index,int bufsize,int* length,IntPtr name);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void GetActiveSubroutineNameDelegate(uint program,uint shadertype,uint index,int bufsize,int* length,IntPtr name);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void UniformSubroutinesuivDelegate(uint shadertype,int count,uint* indices);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void GetUniformSubroutineuivDelegate(uint shadertype,int location,uint* parameters);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void GetProgramStageivDelegate(uint program,uint shadertype,uint pName,int* values);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void PatchParameteriDelegate(uint pName,int value);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void PatchParameterfvDelegate(uint pName,float* values);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void BindTransformFeedbackDelegate(uint target,uint id);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void DeleteTransformFeedbacksDelegate(int n,uint* ids);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void GenTransformFeedbacksDelegate(int n,uint* ids);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate byte IsTransformFeedbackDelegate(uint id);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void PauseTransformFeedbackDelegate();
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void ResumeTransformFeedbackDelegate();
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void DrawTransformFeedbackDelegate(uint mode,uint id);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void DrawTransformFeedbackStreamDelegate(uint mode,uint id,uint stream);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void BeginQueryIndexedDelegate(uint target,uint index,uint id);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void EndQueryIndexedDelegate(uint target,uint index);
		
		[UFP(CC.Cdecl)]
		private unsafe delegate void GetQueryIndexedivDelegate(uint target,uint index,uint pName,int* parameters);
	}
}
