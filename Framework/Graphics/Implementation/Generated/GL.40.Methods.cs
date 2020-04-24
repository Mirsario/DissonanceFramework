using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[MethodImpl(ImplOptions)]
		public unsafe static void MinSampleShading(float value)
			=> glMinSampleShading(value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void BlendEquation(uint buf,uint mode)
			=> glBlendEquationi(buf,mode);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void BlendEquationSeparate(uint buf,uint modeRGB,uint modeAlpha)
			=> glBlendEquationSeparatei(buf,modeRGB,modeAlpha);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void BlendFunc(uint buf,BlendingFactor src,BlendingFactor dst)
			=> glBlendFunci(buf,src,dst);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void BlendFuncSeparate(uint buf,uint srcRGB,uint dstRGB,uint srcAlpha,uint dstAlpha)
			=> glBlendFuncSeparatei(buf,srcRGB,dstRGB,srcAlpha,dstAlpha);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void DrawArraysIndirect(uint mode,IntPtr indirect)
			=> glDrawArraysIndirect(mode,indirect);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void DrawElementsIndirect(uint mode,uint type,IntPtr indirect)
			=> glDrawElementsIndirect(mode,type,indirect);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Uniform1(int location,double x)
			=> glUniform1d(location,x);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Uniform2(int location,double x,double y)
			=> glUniform2d(location,x,y);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Uniform3(int location,double x,double y,double z)
			=> glUniform3d(location,x,y,z);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Uniform4(int location,double x,double y,double z,double w)
			=> glUniform4d(location,x,y,z,w);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Uniform1(int location,int count,double* value)
			=> glUniform1dv(location,count,value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Uniform2(int location,int count,double* value)
			=> glUniform2dv(location,count,value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Uniform3(int location,int count,double* value)
			=> glUniform3dv(location,count,value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void Uniform4(int location,int count,double* value)
			=> glUniform4dv(location,count,value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void UniformMatrix2(int location,int count,byte transpose,double* value)
			=> glUniformMatrix2dv(location,count,transpose,value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void UniformMatrix3(int location,int count,byte transpose,double* value)
			=> glUniformMatrix3dv(location,count,transpose,value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void UniformMatrix4(int location,int count,byte transpose,double* value)
			=> glUniformMatrix4dv(location,count,transpose,value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void UniformMatrix2x3(int location,int count,byte transpose,double* value)
			=> glUniformMatrix2x3dv(location,count,transpose,value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void UniformMatrix2x4(int location,int count,byte transpose,double* value)
			=> glUniformMatrix2x4dv(location,count,transpose,value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void UniformMatrix3x2(int location,int count,byte transpose,double* value)
			=> glUniformMatrix3x2dv(location,count,transpose,value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void UniformMatrix3x4(int location,int count,byte transpose,double* value)
			=> glUniformMatrix3x4dv(location,count,transpose,value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void UniformMatrix4x2(int location,int count,byte transpose,double* value)
			=> glUniformMatrix4x2dv(location,count,transpose,value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void UniformMatrix4x3(int location,int count,byte transpose,double* value)
			=> glUniformMatrix4x3dv(location,count,transpose,value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetUniform(uint program,int location,double* parameters)
			=> glGetUniformdv(program,location,parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static int GetSubroutineUniformLocation(uint program,uint shadertype,IntPtr name)
			=> glGetSubroutineUniformLocation(program,shadertype,name);
		
		[MethodImpl(ImplOptions)]
		public unsafe static uint GetSubroutineIndex(uint program,uint shadertype,IntPtr name)
			=> glGetSubroutineIndex(program,shadertype,name);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetActiveSubroutineUniform(uint program,uint shadertype,uint index,uint pName,int* values)
			=> glGetActiveSubroutineUniformiv(program,shadertype,index,pName,values);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetActiveSubroutineUniformName(uint program,uint shadertype,uint index,int bufsize,int* length,IntPtr name)
			=> glGetActiveSubroutineUniformName(program,shadertype,index,bufsize,length,name);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetActiveSubroutineName(uint program,uint shadertype,uint index,int bufsize,int* length,IntPtr name)
			=> glGetActiveSubroutineName(program,shadertype,index,bufsize,length,name);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void UniformSubroutines(uint shadertype,int count,uint* indices)
			=> glUniformSubroutinesuiv(shadertype,count,indices);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetUniformSubroutine(uint shadertype,int location,uint* parameters)
			=> glGetUniformSubroutineuiv(shadertype,location,parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetProgramStage(uint program,uint shadertype,uint pName,int* values)
			=> glGetProgramStageiv(program,shadertype,pName,values);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void PatchParameter(uint pName,int value)
			=> glPatchParameteri(pName,value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void PatchParameter(uint pName,float* values)
			=> glPatchParameterfv(pName,values);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void BindTransformFeedback(uint target,uint id)
			=> glBindTransformFeedback(target,id);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void DeleteTransformFeedbacks(int n,uint* ids)
			=> glDeleteTransformFeedbacks(n,ids);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GenTransformFeedbacks(int n,uint* ids)
			=> glGenTransformFeedbacks(n,ids);
		
		[MethodImpl(ImplOptions)]
		public unsafe static byte IsTransformFeedback(uint id)
			=> glIsTransformFeedback(id);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void PauseTransformFeedback()
			=> glPauseTransformFeedback();
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ResumeTransformFeedback()
			=> glResumeTransformFeedback();
		
		[MethodImpl(ImplOptions)]
		public unsafe static void DrawTransformFeedback(uint mode,uint id)
			=> glDrawTransformFeedback(mode,id);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void DrawTransformFeedbackStream(uint mode,uint id,uint stream)
			=> glDrawTransformFeedbackStream(mode,id,stream);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void BeginQueryIndexed(uint target,uint index,uint id)
			=> glBeginQueryIndexed(target,index,id);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void EndQueryIndexed(uint target,uint index)
			=> glEndQueryIndexed(target,index);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetQueryIndexed(uint target,uint index,uint pName,int* parameters)
			=> glGetQueryIndexediv(target,index,pName,parameters);
	}
}
