using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[MethodImpl(ImplOptions)]
		public unsafe static void ReleaseShaderCompiler()
			=> glReleaseShaderCompiler();
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ShaderBinary(int count,ref uint shaders,uint binaryformat,IntPtr binary,int length)
			=> glShaderBinary(count,ref shaders,binaryformat,binary,length);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetShaderPrecisionFormat(uint shadertype,uint precisiontype,ref int range,ref int precision)
			=> glGetShaderPrecisionFormat(shadertype,precisiontype,ref range,ref precision);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void DepthRange(float n,float f)
			=> glDepthRangef(n,f);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ClearDepth(float d)
			=> glClearDepthf(d);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetProgramBinary(uint program,int bufSize,ref int length,ref uint binaryFormat,IntPtr binary)
			=> glGetProgramBinary(program,bufSize,ref length,ref binaryFormat,binary);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ProgramBinary(uint program,uint binaryFormat,IntPtr binary,int length)
			=> glProgramBinary(program,binaryFormat,binary,length);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ProgramParameter(uint program,uint pName,int value)
			=> glProgramParameteri(program,pName,value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void UseProgramStages(uint pipeline,uint stages,uint program)
			=> glUseProgramStages(pipeline,stages,program);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ActiveShaderProgram(uint pipeline,uint program)
			=> glActiveShaderProgram(pipeline,program);
		
		[MethodImpl(ImplOptions)]
		public unsafe static uint CreateShaderProgram(uint type,int count,IntPtr strings)
			=> glCreateShaderProgramv(type,count,strings);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void BindProgramPipeline(uint pipeline)
			=> glBindProgramPipeline(pipeline);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void DeleteProgramPipelines(int n,ref uint pipelines)
			=> glDeleteProgramPipelines(n,ref pipelines);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GenProgramPipelines(int n,ref uint pipelines)
			=> glGenProgramPipelines(n,ref pipelines);
		
		[MethodImpl(ImplOptions)]
		public unsafe static byte IsProgramPipeline(uint pipeline)
			=> glIsProgramPipeline(pipeline);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetProgramPipeline(uint pipeline,uint pName,ref int parameters)
			=> glGetProgramPipelineiv(pipeline,pName,ref parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ProgramUniform1(uint program,int location,int v0)
			=> glProgramUniform1i(program,location,v0);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ProgramUniform1(uint program,int location,int count,ref int value)
			=> glProgramUniform1iv(program,location,count,ref value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ProgramUniform1(uint program,int location,float v0)
			=> glProgramUniform1f(program,location,v0);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ProgramUniform1(uint program,int location,int count,ref float value)
			=> glProgramUniform1fv(program,location,count,ref value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ProgramUniform1(uint program,int location,double v0)
			=> glProgramUniform1d(program,location,v0);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ProgramUniform1(uint program,int location,int count,ref double value)
			=> glProgramUniform1dv(program,location,count,ref value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ProgramUniform1(uint program,int location,uint v0)
			=> glProgramUniform1ui(program,location,v0);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ProgramUniform1(uint program,int location,int count,ref uint value)
			=> glProgramUniform1uiv(program,location,count,ref value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ProgramUniform2(uint program,int location,int v0,int v1)
			=> glProgramUniform2i(program,location,v0,v1);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ProgramUniform2(uint program,int location,int count,ref int value)
			=> glProgramUniform2iv(program,location,count,ref value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ProgramUniform2(uint program,int location,float v0,float v1)
			=> glProgramUniform2f(program,location,v0,v1);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ProgramUniform2(uint program,int location,int count,ref float value)
			=> glProgramUniform2fv(program,location,count,ref value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ProgramUniform2(uint program,int location,double v0,double v1)
			=> glProgramUniform2d(program,location,v0,v1);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ProgramUniform2(uint program,int location,int count,ref double value)
			=> glProgramUniform2dv(program,location,count,ref value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ProgramUniform2(uint program,int location,uint v0,uint v1)
			=> glProgramUniform2ui(program,location,v0,v1);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ProgramUniform2(uint program,int location,int count,ref uint value)
			=> glProgramUniform2uiv(program,location,count,ref value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ProgramUniform3(uint program,int location,int v0,int v1,int v2)
			=> glProgramUniform3i(program,location,v0,v1,v2);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ProgramUniform3(uint program,int location,int count,ref int value)
			=> glProgramUniform3iv(program,location,count,ref value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ProgramUniform3(uint program,int location,float v0,float v1,float v2)
			=> glProgramUniform3f(program,location,v0,v1,v2);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ProgramUniform3(uint program,int location,int count,ref float value)
			=> glProgramUniform3fv(program,location,count,ref value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ProgramUniform3(uint program,int location,double v0,double v1,double v2)
			=> glProgramUniform3d(program,location,v0,v1,v2);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ProgramUniform3(uint program,int location,int count,ref double value)
			=> glProgramUniform3dv(program,location,count,ref value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ProgramUniform3(uint program,int location,uint v0,uint v1,uint v2)
			=> glProgramUniform3ui(program,location,v0,v1,v2);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ProgramUniform3(uint program,int location,int count,ref uint value)
			=> glProgramUniform3uiv(program,location,count,ref value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ProgramUniform4(uint program,int location,int v0,int v1,int v2,int v3)
			=> glProgramUniform4i(program,location,v0,v1,v2,v3);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ProgramUniform4(uint program,int location,int count,ref int value)
			=> glProgramUniform4iv(program,location,count,ref value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ProgramUniform4(uint program,int location,float v0,float v1,float v2,float v3)
			=> glProgramUniform4f(program,location,v0,v1,v2,v3);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ProgramUniform4(uint program,int location,int count,ref float value)
			=> glProgramUniform4fv(program,location,count,ref value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ProgramUniform4(uint program,int location,double v0,double v1,double v2,double v3)
			=> glProgramUniform4d(program,location,v0,v1,v2,v3);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ProgramUniform4(uint program,int location,int count,ref double value)
			=> glProgramUniform4dv(program,location,count,ref value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ProgramUniform4(uint program,int location,uint v0,uint v1,uint v2,uint v3)
			=> glProgramUniform4ui(program,location,v0,v1,v2,v3);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ProgramUniform4(uint program,int location,int count,ref uint value)
			=> glProgramUniform4uiv(program,location,count,ref value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ProgramUniformMatrix2(uint program,int location,int count,byte transpose,ref float value)
			=> glProgramUniformMatrix2fv(program,location,count,transpose,ref value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ProgramUniformMatrix3(uint program,int location,int count,byte transpose,ref float value)
			=> glProgramUniformMatrix3fv(program,location,count,transpose,ref value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ProgramUniformMatrix4(uint program,int location,int count,byte transpose,ref float value)
			=> glProgramUniformMatrix4fv(program,location,count,transpose,ref value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ProgramUniformMatrix2(uint program,int location,int count,byte transpose,ref double value)
			=> glProgramUniformMatrix2dv(program,location,count,transpose,ref value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ProgramUniformMatrix3(uint program,int location,int count,byte transpose,ref double value)
			=> glProgramUniformMatrix3dv(program,location,count,transpose,ref value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ProgramUniformMatrix4(uint program,int location,int count,byte transpose,ref double value)
			=> glProgramUniformMatrix4dv(program,location,count,transpose,ref value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ProgramUniformMatrix2x3(uint program,int location,int count,byte transpose,ref float value)
			=> glProgramUniformMatrix2x3fv(program,location,count,transpose,ref value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ProgramUniformMatrix3x2(uint program,int location,int count,byte transpose,ref float value)
			=> glProgramUniformMatrix3x2fv(program,location,count,transpose,ref value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ProgramUniformMatrix2x4(uint program,int location,int count,byte transpose,ref float value)
			=> glProgramUniformMatrix2x4fv(program,location,count,transpose,ref value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ProgramUniformMatrix4x2(uint program,int location,int count,byte transpose,ref float value)
			=> glProgramUniformMatrix4x2fv(program,location,count,transpose,ref value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ProgramUniformMatrix3x4(uint program,int location,int count,byte transpose,ref float value)
			=> glProgramUniformMatrix3x4fv(program,location,count,transpose,ref value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ProgramUniformMatrix4x3(uint program,int location,int count,byte transpose,ref float value)
			=> glProgramUniformMatrix4x3fv(program,location,count,transpose,ref value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ProgramUniformMatrix2x3(uint program,int location,int count,byte transpose,ref double value)
			=> glProgramUniformMatrix2x3dv(program,location,count,transpose,ref value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ProgramUniformMatrix3x2(uint program,int location,int count,byte transpose,ref double value)
			=> glProgramUniformMatrix3x2dv(program,location,count,transpose,ref value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ProgramUniformMatrix2x4(uint program,int location,int count,byte transpose,ref double value)
			=> glProgramUniformMatrix2x4dv(program,location,count,transpose,ref value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ProgramUniformMatrix4x2(uint program,int location,int count,byte transpose,ref double value)
			=> glProgramUniformMatrix4x2dv(program,location,count,transpose,ref value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ProgramUniformMatrix3x4(uint program,int location,int count,byte transpose,ref double value)
			=> glProgramUniformMatrix3x4dv(program,location,count,transpose,ref value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ProgramUniformMatrix4x3(uint program,int location,int count,byte transpose,ref double value)
			=> glProgramUniformMatrix4x3dv(program,location,count,transpose,ref value);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ValidateProgramPipeline(uint pipeline)
			=> glValidateProgramPipeline(pipeline);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetProgramPipelineInfoLog(uint pipeline,int bufSize,ref int length,IntPtr infoLog)
			=> glGetProgramPipelineInfoLog(pipeline,bufSize,ref length,infoLog);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttribL1(uint index,double x)
			=> glVertexAttribL1d(index,x);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttribL2(uint index,double x,double y)
			=> glVertexAttribL2d(index,x,y);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttribL3(uint index,double x,double y,double z)
			=> glVertexAttribL3d(index,x,y,z);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttribL4(uint index,double x,double y,double z,double w)
			=> glVertexAttribL4d(index,x,y,z,w);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttribL1(uint index,ref double v)
			=> glVertexAttribL1dv(index,ref v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttribL2(uint index,ref double v)
			=> glVertexAttribL2dv(index,ref v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttribL3(uint index,ref double v)
			=> glVertexAttribL3dv(index,ref v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttribL4(uint index,ref double v)
			=> glVertexAttribL4dv(index,ref v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void VertexAttribLPointer(uint index,int size,uint type,int stride,IntPtr pointer)
			=> glVertexAttribLPointer(index,size,type,stride,pointer);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetVertexAttribL(uint index,uint pName,ref double parameters)
			=> glGetVertexAttribLdv(index,pName,ref parameters);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ViewportArray(uint first,int count,ref float v)
			=> glViewportArrayv(first,count,ref v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ViewportIndexed(uint index,float x,float y,float w,float h)
			=> glViewportIndexedf(index,x,y,w,h);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ViewportIndexed(uint index,ref float v)
			=> glViewportIndexedfv(index,ref v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ScissorArray(uint first,int count,ref int v)
			=> glScissorArrayv(first,count,ref v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ScissorIndexed(uint index,int left,int bottom,int width,int height)
			=> glScissorIndexed(index,left,bottom,width,height);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void ScissorIndexed(uint index,ref int v)
			=> glScissorIndexedv(index,ref v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void DepthRangeArray(uint first,int count,ref double v)
			=> glDepthRangeArrayv(first,count,ref v);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void DepthRangeIndexed(uint index,double n,double f)
			=> glDepthRangeIndexed(index,n,f);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetFloat(uint target,uint index,ref float data)
			=> glGetFloati_v(target,index,ref data);
		
		[MethodImpl(ImplOptions)]
		public unsafe static void GetDouble(uint target,uint index,ref double data)
			=> glGetDoublei_v(target,index,ref data);
	}
}
