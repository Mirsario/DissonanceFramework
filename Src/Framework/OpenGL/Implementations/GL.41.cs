﻿using System;

#pragma warning disable IDE0060 //Unused parameter.

namespace Dissonance.Framework.OpenGL
{
	partial class GL
	{
		[MethodImport("glReleaseShaderCompiler","4.1")]
		public static void ReleaseShaderCompiler()
			=> throw new NotImplementedException();

		[MethodImport("glShaderBinary","4.1")]
		public static void ShaderBinary(int count,ref uint shaders,uint binaryformat,IntPtr binary,int length)
			=> throw new NotImplementedException();

		[MethodImport("glGetShaderPrecisionFormat","4.1")]
		public static void GetShaderPrecisionFormat(uint shadertype,uint precisiontype,ref int range,ref int precision)
			=> throw new NotImplementedException();

		[MethodImport("glDepthRangef","4.1")]
		public static void DepthRange(float n,float f)
			=> throw new NotImplementedException();

		[MethodImport("glClearDepthf","4.1")]
		public static void ClearDepth(float d)
			=> throw new NotImplementedException();

		[MethodImport("glGetProgramBinary","4.1")]
		public static void GetProgramBinary(uint program,int bufSize,ref int length,ref uint binaryFormat,IntPtr binary)
			=> throw new NotImplementedException();

		[MethodImport("glProgramBinary","4.1")]
		public static void ProgramBinary(uint program,uint binaryFormat,IntPtr binary,int length)
			=> throw new NotImplementedException();

		[MethodImport("glProgramParameteri","4.1")]
		public static void ProgramParameter(uint program,uint pName,int value)
			=> throw new NotImplementedException();

		[MethodImport("glUseProgramStages","4.1")]
		public static void UseProgramStages(uint pipeline,uint stages,uint program)
			=> throw new NotImplementedException();

		[MethodImport("glActiveShaderProgram","4.1")]
		public static void ActiveShaderProgram(uint pipeline,uint program)
			=> throw new NotImplementedException();

		[MethodImport("glCreateShaderProgramv","4.1")]
		public static uint CreateShaderProgram(uint type,int count,IntPtr strings)
			=> throw new NotImplementedException();

		[MethodImport("glBindProgramPipeline","4.1")]
		public static void BindProgramPipeline(uint pipeline)
			=> throw new NotImplementedException();

		[MethodImport("glDeleteProgramPipelines","4.1")]
		public static void DeleteProgramPipelines(int n,ref uint pipelines)
			=> throw new NotImplementedException();

		[MethodImport("glGenProgramPipelines","4.1")]
		public static void GenProgramPipelines(int n,ref uint pipelines)
			=> throw new NotImplementedException();

		[MethodImport("glIsProgramPipeline","4.1")]
		public static byte IsProgramPipeline(uint pipeline)
			=> throw new NotImplementedException();

		[MethodImport("glGetProgramPipelineiv","4.1")]
		public static void GetProgramPipeline(uint pipeline,uint pName,ref int parameters)
			=> throw new NotImplementedException();

		[MethodImport("glProgramUniform1i","4.1")]
		public static void ProgramUniform1(uint program,int location,int v0)
			=> throw new NotImplementedException();

		[MethodImport("glProgramUniform1iv","4.1")]
		public static void ProgramUniform1(uint program,int location,int count,ref int value)
			=> throw new NotImplementedException();

		[MethodImport("glProgramUniform1f","4.1")]
		public static void ProgramUniform1(uint program,int location,float v0)
			=> throw new NotImplementedException();

		[MethodImport("glProgramUniform1fv","4.1")]
		public static void ProgramUniform1(uint program,int location,int count,ref float value)
			=> throw new NotImplementedException();

		[MethodImport("glProgramUniform1d","4.1")]
		public static void ProgramUniform1(uint program,int location,double v0)
			=> throw new NotImplementedException();

		[MethodImport("glProgramUniform1dv","4.1")]
		public static void ProgramUniform1(uint program,int location,int count,ref double value)
			=> throw new NotImplementedException();

		[MethodImport("glProgramUniform1ui","4.1")]
		public static void ProgramUniform1(uint program,int location,uint v0)
			=> throw new NotImplementedException();

		[MethodImport("glProgramUniform1uiv","4.1")]
		public static void ProgramUniform1(uint program,int location,int count,ref uint value)
			=> throw new NotImplementedException();

		[MethodImport("glProgramUniform2i","4.1")]
		public static void ProgramUniform2(uint program,int location,int v0,int v1)
			=> throw new NotImplementedException();

		[MethodImport("glProgramUniform2iv","4.1")]
		public static void ProgramUniform2(uint program,int location,int count,ref int value)
			=> throw new NotImplementedException();

		[MethodImport("glProgramUniform2f","4.1")]
		public static void ProgramUniform2(uint program,int location,float v0,float v1)
			=> throw new NotImplementedException();

		[MethodImport("glProgramUniform2fv","4.1")]
		public static void ProgramUniform2(uint program,int location,int count,ref float value)
			=> throw new NotImplementedException();

		[MethodImport("glProgramUniform2d","4.1")]
		public static void ProgramUniform2(uint program,int location,double v0,double v1)
			=> throw new NotImplementedException();

		[MethodImport("glProgramUniform2dv","4.1")]
		public static void ProgramUniform2(uint program,int location,int count,ref double value)
			=> throw new NotImplementedException();

		[MethodImport("glProgramUniform2ui","4.1")]
		public static void ProgramUniform2(uint program,int location,uint v0,uint v1)
			=> throw new NotImplementedException();

		[MethodImport("glProgramUniform2uiv","4.1")]
		public static void ProgramUniform2(uint program,int location,int count,ref uint value)
			=> throw new NotImplementedException();

		[MethodImport("glProgramUniform3i","4.1")]
		public static void ProgramUniform3(uint program,int location,int v0,int v1,int v2)
			=> throw new NotImplementedException();

		[MethodImport("glProgramUniform3iv","4.1")]
		public static void ProgramUniform3(uint program,int location,int count,ref int value)
			=> throw new NotImplementedException();

		[MethodImport("glProgramUniform3f","4.1")]
		public static void ProgramUniform3(uint program,int location,float v0,float v1,float v2)
			=> throw new NotImplementedException();

		[MethodImport("glProgramUniform3fv","4.1")]
		public static void ProgramUniform3(uint program,int location,int count,ref float value)
			=> throw new NotImplementedException();

		[MethodImport("glProgramUniform3d","4.1")]
		public static void ProgramUniform3(uint program,int location,double v0,double v1,double v2)
			=> throw new NotImplementedException();

		[MethodImport("glProgramUniform3dv","4.1")]
		public static void ProgramUniform3(uint program,int location,int count,ref double value)
			=> throw new NotImplementedException();

		[MethodImport("glProgramUniform3ui","4.1")]
		public static void ProgramUniform3(uint program,int location,uint v0,uint v1,uint v2)
			=> throw new NotImplementedException();

		[MethodImport("glProgramUniform3uiv","4.1")]
		public static void ProgramUniform3(uint program,int location,int count,ref uint value)
			=> throw new NotImplementedException();

		[MethodImport("glProgramUniform4i","4.1")]
		public static void ProgramUniform4(uint program,int location,int v0,int v1,int v2,int v3)
			=> throw new NotImplementedException();

		[MethodImport("glProgramUniform4iv","4.1")]
		public static void ProgramUniform4(uint program,int location,int count,ref int value)
			=> throw new NotImplementedException();

		[MethodImport("glProgramUniform4f","4.1")]
		public static void ProgramUniform4(uint program,int location,float v0,float v1,float v2,float v3)
			=> throw new NotImplementedException();

		[MethodImport("glProgramUniform4fv","4.1")]
		public static void ProgramUniform4(uint program,int location,int count,ref float value)
			=> throw new NotImplementedException();

		[MethodImport("glProgramUniform4d","4.1")]
		public static void ProgramUniform4(uint program,int location,double v0,double v1,double v2,double v3)
			=> throw new NotImplementedException();

		[MethodImport("glProgramUniform4dv","4.1")]
		public static void ProgramUniform4(uint program,int location,int count,ref double value)
			=> throw new NotImplementedException();

		[MethodImport("glProgramUniform4ui","4.1")]
		public static void ProgramUniform4(uint program,int location,uint v0,uint v1,uint v2,uint v3)
			=> throw new NotImplementedException();

		[MethodImport("glProgramUniform4uiv","4.1")]
		public static void ProgramUniform4(uint program,int location,int count,ref uint value)
			=> throw new NotImplementedException();

		[MethodImport("glProgramUniformMatrix2fv","4.1")]
		public static void ProgramUniformMatrix2(uint program,int location,int count,byte transpose,ref float value)
			=> throw new NotImplementedException();

		[MethodImport("glProgramUniformMatrix3fv","4.1")]
		public static void ProgramUniformMatrix3(uint program,int location,int count,byte transpose,ref float value)
			=> throw new NotImplementedException();

		[MethodImport("glProgramUniformMatrix4fv","4.1")]
		public static void ProgramUniformMatrix4(uint program,int location,int count,byte transpose,ref float value)
			=> throw new NotImplementedException();

		[MethodImport("glProgramUniformMatrix2dv","4.1")]
		public static void ProgramUniformMatrix2(uint program,int location,int count,byte transpose,ref double value)
			=> throw new NotImplementedException();

		[MethodImport("glProgramUniformMatrix3dv","4.1")]
		public static void ProgramUniformMatrix3(uint program,int location,int count,byte transpose,ref double value)
			=> throw new NotImplementedException();

		[MethodImport("glProgramUniformMatrix4dv","4.1")]
		public static void ProgramUniformMatrix4(uint program,int location,int count,byte transpose,ref double value)
			=> throw new NotImplementedException();

		[MethodImport("glProgramUniformMatrix2x3fv","4.1")]
		public static void ProgramUniformMatrix2x3(uint program,int location,int count,byte transpose,ref float value)
			=> throw new NotImplementedException();

		[MethodImport("glProgramUniformMatrix3x2fv","4.1")]
		public static void ProgramUniformMatrix3x2(uint program,int location,int count,byte transpose,ref float value)
			=> throw new NotImplementedException();

		[MethodImport("glProgramUniformMatrix2x4fv","4.1")]
		public static void ProgramUniformMatrix2x4(uint program,int location,int count,byte transpose,ref float value)
			=> throw new NotImplementedException();

		[MethodImport("glProgramUniformMatrix4x2fv","4.1")]
		public static void ProgramUniformMatrix4x2(uint program,int location,int count,byte transpose,ref float value)
			=> throw new NotImplementedException();

		[MethodImport("glProgramUniformMatrix3x4fv","4.1")]
		public static void ProgramUniformMatrix3x4(uint program,int location,int count,byte transpose,ref float value)
			=> throw new NotImplementedException();

		[MethodImport("glProgramUniformMatrix4x3fv","4.1")]
		public static void ProgramUniformMatrix4x3(uint program,int location,int count,byte transpose,ref float value)
			=> throw new NotImplementedException();

		[MethodImport("glProgramUniformMatrix2x3dv","4.1")]
		public static void ProgramUniformMatrix2x3(uint program,int location,int count,byte transpose,ref double value)
			=> throw new NotImplementedException();

		[MethodImport("glProgramUniformMatrix3x2dv","4.1")]
		public static void ProgramUniformMatrix3x2(uint program,int location,int count,byte transpose,ref double value)
			=> throw new NotImplementedException();

		[MethodImport("glProgramUniformMatrix2x4dv","4.1")]
		public static void ProgramUniformMatrix2x4(uint program,int location,int count,byte transpose,ref double value)
			=> throw new NotImplementedException();

		[MethodImport("glProgramUniformMatrix4x2dv","4.1")]
		public static void ProgramUniformMatrix4x2(uint program,int location,int count,byte transpose,ref double value)
			=> throw new NotImplementedException();

		[MethodImport("glProgramUniformMatrix3x4dv","4.1")]
		public static void ProgramUniformMatrix3x4(uint program,int location,int count,byte transpose,ref double value)
			=> throw new NotImplementedException();

		[MethodImport("glProgramUniformMatrix4x3dv","4.1")]
		public static void ProgramUniformMatrix4x3(uint program,int location,int count,byte transpose,ref double value)
			=> throw new NotImplementedException();

		[MethodImport("glValidateProgramPipeline","4.1")]
		public static void ValidateProgramPipeline(uint pipeline)
			=> throw new NotImplementedException();

		[MethodImport("glGetProgramPipelineInfoLog","4.1")]
		public static void GetProgramPipelineInfoLog(uint pipeline,int bufSize,ref int length,IntPtr infoLog)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttribL1d","4.1")]
		public static void VertexAttribL1(uint index,double x)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttribL2d","4.1")]
		public static void VertexAttribL2(uint index,double x,double y)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttribL3d","4.1")]
		public static void VertexAttribL3(uint index,double x,double y,double z)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttribL4d","4.1")]
		public static void VertexAttribL4(uint index,double x,double y,double z,double w)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttribL1dv","4.1")]
		public static void VertexAttribL1(uint index,ref double v)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttribL2dv","4.1")]
		public static void VertexAttribL2(uint index,ref double v)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttribL3dv","4.1")]
		public static void VertexAttribL3(uint index,ref double v)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttribL4dv","4.1")]
		public static void VertexAttribL4(uint index,ref double v)
			=> throw new NotImplementedException();

		[MethodImport("glVertexAttribLPointer","4.1")]
		public static void VertexAttribLPointer(uint index,int size,uint type,int stride,IntPtr pointer)
			=> throw new NotImplementedException();

		[MethodImport("glGetVertexAttribLdv","4.1")]
		public static void GetVertexAttribL(uint index,uint pName,ref double parameters)
			=> throw new NotImplementedException();

		[MethodImport("glViewportArrayv","4.1")]
		public static void ViewportArray(uint first,int count,ref float v)
			=> throw new NotImplementedException();

		[MethodImport("glViewportIndexedf","4.1")]
		public static void ViewportIndexed(uint index,float x,float y,float w,float h)
			=> throw new NotImplementedException();

		[MethodImport("glViewportIndexedfv","4.1")]
		public static void ViewportIndexed(uint index,ref float v)
			=> throw new NotImplementedException();

		[MethodImport("glScissorArrayv","4.1")]
		public static void ScissorArray(uint first,int count,ref int v)
			=> throw new NotImplementedException();

		[MethodImport("glScissorIndexed","4.1")]
		public static void ScissorIndexed(uint index,int left,int bottom,int width,int height)
			=> throw new NotImplementedException();

		[MethodImport("glScissorIndexedv","4.1")]
		public static void ScissorIndexed(uint index,ref int v)
			=> throw new NotImplementedException();

		[MethodImport("glDepthRangeArrayv","4.1")]
		public static void DepthRangeArray(uint first,int count,ref double v)
			=> throw new NotImplementedException();

		[MethodImport("glDepthRangeIndexed","4.1")]
		public static void DepthRangeIndexed(uint index,double n,double f)
			=> throw new NotImplementedException();

		[MethodImport("glGetFloati_v","4.1")]
		public static void GetFloat(uint target,uint index,ref float data)
			=> throw new NotImplementedException();

		[MethodImport("glGetDoublei_v","4.1")]
		public static void GetDouble(uint target,uint index,ref double data)
			=> throw new NotImplementedException();
	}
}