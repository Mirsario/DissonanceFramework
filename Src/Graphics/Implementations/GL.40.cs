using System;

#pragma warning disable IDE0060 //Unused parameter.

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[MethodImport("glMinSampleShading","4.0")]
		public static void MinSampleShading(float value)
			=> throw new NotImplementedException();

		[MethodImport("glBlendEquationi","4.0")]
		public static void BlendEquation(uint buf,uint mode)
			=> throw new NotImplementedException();

		[MethodImport("glBlendEquationSeparatei","4.0")]
		public static void BlendEquationSeparate(uint buf,uint modeRGB,uint modeAlpha)
			=> throw new NotImplementedException();

		[MethodImport("glBlendFunci","4.0")]
		public static void BlendFunc(uint buf,BlendingFactor src,BlendingFactor dst)
			=> throw new NotImplementedException();

		[MethodImport("glBlendFuncSeparatei","4.0")]
		public static void BlendFuncSeparate(uint buf,uint srcRGB,uint dstRGB,uint srcAlpha,uint dstAlpha)
			=> throw new NotImplementedException();

		[MethodImport("glDrawArraysIndirect","4.0")]
		public static void DrawArraysIndirect(uint mode,IntPtr indirect)
			=> throw new NotImplementedException();

		[MethodImport("glDrawElementsIndirect","4.0")]
		public static void DrawElementsIndirect(uint mode,uint type,IntPtr indirect)
			=> throw new NotImplementedException();

		[MethodImport("glUniform1d","4.0")]
		public static void Uniform1(int location,double x)
			=> throw new NotImplementedException();

		[MethodImport("glUniform2d","4.0")]
		public static void Uniform2(int location,double x,double y)
			=> throw new NotImplementedException();

		[MethodImport("glUniform3d","4.0")]
		public static void Uniform3(int location,double x,double y,double z)
			=> throw new NotImplementedException();

		[MethodImport("glUniform4d","4.0")]
		public static void Uniform4(int location,double x,double y,double z,double w)
			=> throw new NotImplementedException();

		[MethodImport("glUniform1dv","4.0")]
		public unsafe static void Uniform1(int location,int count,double* value)
			=> throw new NotImplementedException();

		[MethodImport("glUniform2dv","4.0")]
		public unsafe static void Uniform2(int location,int count,double* value)
			=> throw new NotImplementedException();

		[MethodImport("glUniform3dv","4.0")]
		public unsafe static void Uniform3(int location,int count,double* value)
			=> throw new NotImplementedException();

		[MethodImport("glUniform4dv","4.0")]
		public unsafe static void Uniform4(int location,int count,double* value)
			=> throw new NotImplementedException();

		[MethodImport("glUniformMatrix2dv","4.0")]
		public unsafe static void UniformMatrix2(int location,int count,byte transpose,double* value)
			=> throw new NotImplementedException();

		[MethodImport("glUniformMatrix3dv","4.0")]
		public unsafe static void UniformMatrix3(int location,int count,byte transpose,double* value)
			=> throw new NotImplementedException();

		[MethodImport("glUniformMatrix4dv","4.0")]
		public unsafe static void UniformMatrix4(int location,int count,byte transpose,double* value)
			=> throw new NotImplementedException();

		[MethodImport("glUniformMatrix2x3dv","4.0")]
		public unsafe static void UniformMatrix2x3(int location,int count,byte transpose,double* value)
			=> throw new NotImplementedException();

		[MethodImport("glUniformMatrix2x4dv","4.0")]
		public unsafe static void UniformMatrix2x4(int location,int count,byte transpose,double* value)
			=> throw new NotImplementedException();

		[MethodImport("glUniformMatrix3x2dv","4.0")]
		public unsafe static void UniformMatrix3x2(int location,int count,byte transpose,double* value)
			=> throw new NotImplementedException();

		[MethodImport("glUniformMatrix3x4dv","4.0")]
		public unsafe static void UniformMatrix3x4(int location,int count,byte transpose,double* value)
			=> throw new NotImplementedException();

		[MethodImport("glUniformMatrix4x2dv","4.0")]
		public unsafe static void UniformMatrix4x2(int location,int count,byte transpose,double* value)
			=> throw new NotImplementedException();

		[MethodImport("glUniformMatrix4x3dv","4.0")]
		public unsafe static void UniformMatrix4x3(int location,int count,byte transpose,double* value)
			=> throw new NotImplementedException();

		[MethodImport("glGetUniformdv","4.0")]
		public unsafe static void GetUniform(uint program,int location,double* parameters)
			=> throw new NotImplementedException();

		[MethodImport("glGetSubroutineUniformLocation","4.0")]
		public static int GetSubroutineUniformLocation(uint program,uint shadertype,IntPtr name)
			=> throw new NotImplementedException();

		[MethodImport("glGetSubroutineIndex","4.0")]
		public static uint GetSubroutineIndex(uint program,uint shadertype,IntPtr name)
			=> throw new NotImplementedException();

		[MethodImport("glGetActiveSubroutineUniformiv","4.0")]
		public unsafe static void GetActiveSubroutineUniform(uint program,uint shadertype,uint index,uint pName,int* values)
			=> throw new NotImplementedException();

		[MethodImport("glGetActiveSubroutineUniformName","4.0")]
		public unsafe static void GetActiveSubroutineUniformName(uint program,uint shadertype,uint index,int bufsize,int* length,IntPtr name)
			=> throw new NotImplementedException();

		[MethodImport("glGetActiveSubroutineName","4.0")]
		public unsafe static void GetActiveSubroutineName(uint program,uint shadertype,uint index,int bufsize,int* length,IntPtr name)
			=> throw new NotImplementedException();

		[MethodImport("glUniformSubroutinesuiv","4.0")]
		public unsafe static void UniformSubroutines(uint shadertype,int count,uint* indices)
			=> throw new NotImplementedException();

		[MethodImport("glGetUniformSubroutineuiv","4.0")]
		public unsafe static void GetUniformSubroutine(uint shadertype,int location,uint* parameters)
			=> throw new NotImplementedException();

		[MethodImport("glGetProgramStageiv","4.0")]
		public unsafe static void GetProgramStage(uint program,uint shadertype,uint pName,int* values)
			=> throw new NotImplementedException();

		[MethodImport("glPatchParameteri","4.0")]
		public static void PatchParameter(uint pName,int value)
			=> throw new NotImplementedException();

		[MethodImport("glPatchParameterfv","4.0")]
		public unsafe static void PatchParameter(uint pName,float* values)
			=> throw new NotImplementedException();

		[MethodImport("glBindTransformFeedback","4.0")]
		public static void BindTransformFeedback(uint target,uint id)
			=> throw new NotImplementedException();

		[MethodImport("glDeleteTransformFeedbacks","4.0")]
		public unsafe static void DeleteTransformFeedbacks(int n,uint* ids)
			=> throw new NotImplementedException();

		[MethodImport("glGenTransformFeedbacks","4.0")]
		public unsafe static void GenTransformFeedbacks(int n,uint* ids)
			=> throw new NotImplementedException();

		[MethodImport("glIsTransformFeedback","4.0")]
		public static byte IsTransformFeedback(uint id)
			=> throw new NotImplementedException();

		[MethodImport("glPauseTransformFeedback","4.0")]
		public static void PauseTransformFeedback()
			=> throw new NotImplementedException();

		[MethodImport("glResumeTransformFeedback","4.0")]
		public static void ResumeTransformFeedback()
			=> throw new NotImplementedException();

		[MethodImport("glDrawTransformFeedback","4.0")]
		public static void DrawTransformFeedback(uint mode,uint id)
			=> throw new NotImplementedException();

		[MethodImport("glDrawTransformFeedbackStream","4.0")]
		public static void DrawTransformFeedbackStream(uint mode,uint id,uint stream)
			=> throw new NotImplementedException();

		[MethodImport("glBeginQueryIndexed","4.0")]
		public static void BeginQueryIndexed(uint target,uint index,uint id)
			=> throw new NotImplementedException();

		[MethodImport("glEndQueryIndexed","4.0")]
		public static void EndQueryIndexed(uint target,uint index)
			=> throw new NotImplementedException();

		[MethodImport("glGetQueryIndexediv","4.0")]
		public unsafe static void GetQueryIndexed(uint target,uint index,uint pName,int* parameters)
			=> throw new NotImplementedException();
	}
}