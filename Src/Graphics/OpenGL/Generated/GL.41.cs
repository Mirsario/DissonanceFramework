using System;

namespace Dissonance.Framework.Graphics.OpenGL
{
	unsafe partial class GL
	{
		[MethodImport("glReleaseShaderCompiler", "4.1")]
		private static delegate*<void> glReleaseShaderCompiler;
		
		public static void ReleaseShaderCompiler()
		{
			glReleaseShaderCompiler();
		}
		
		[MethodImport("glShaderBinary", "4.1")]
		private static delegate*<int, uint*, ShaderBinaryFormat, void*, int, void> glShaderBinary;
		
		public static void ShaderBinary(int count, uint* shaders, ShaderBinaryFormat binaryFormat, void* binary, int length)
		{
			glShaderBinary(count, shaders, binaryFormat, binary, length);
		}
		
		[MethodImport("glGetShaderPrecisionFormat", "4.1")]
		private static delegate*<ShaderType, PrecisionType, int*, int*, void> glGetShaderPrecisionFormat;
		
		public static void GetShaderPrecisionFormat(ShaderType shadertype, PrecisionType precisiontype, int* range, int* precision)
		{
			glGetShaderPrecisionFormat(shadertype, precisiontype, range, precision);
		}
		
		[MethodImport("glDepthRangef", "4.1")]
		private static delegate*<float, float, void> glDepthRangef;
		
		public static void DepthRangef(float n, float f)
		{
			glDepthRangef(n, f);
		}
		
		[MethodImport("glClearDepthf", "4.1")]
		private static delegate*<float, void> glClearDepthf;
		
		public static void ClearDepthf(float d)
		{
			glClearDepthf(d);
		}
		
		[MethodImport("glGetProgramBinary", "4.1")]
		private static delegate*<uint, int, int*, uint*, void*, void> glGetProgramBinary;
		
		public static void GetProgramBinary(uint program, int bufSize, int* length, uint* binaryFormat, void* binary)
		{
			glGetProgramBinary(program, bufSize, length, binaryFormat, binary);
		}
		
		[MethodImport("glProgramBinary", "4.1")]
		private static delegate*<uint, uint, void*, int, void> glProgramBinary;
		
		public static void ProgramBinary(uint program, uint binaryFormat, void* binary, int length)
		{
			glProgramBinary(program, binaryFormat, binary, length);
		}
		
		[MethodImport("glProgramParameteri", "4.1")]
		private static delegate*<uint, ProgramParameterPName, int, void> glProgramParameteri;
		
		public static void ProgramParameteri(uint program, ProgramParameterPName pname, int value)
		{
			glProgramParameteri(program, pname, value);
		}
		
		[MethodImport("glUseProgramStages", "4.1")]
		private static delegate*<uint, UseProgramStageMask, uint, void> glUseProgramStages;
		
		public static void UseProgramStages(uint pipeline, UseProgramStageMask stages, uint program)
		{
			glUseProgramStages(pipeline, stages, program);
		}
		
		[MethodImport("glActiveShaderProgram", "4.1")]
		private static delegate*<uint, uint, void> glActiveShaderProgram;
		
		public static void ActiveShaderProgram(uint pipeline, uint program)
		{
			glActiveShaderProgram(pipeline, program);
		}
		
		[MethodImport("glCreateShaderProgramv", "4.1")]
		private static delegate*<ShaderType, int, byte**, uint> glCreateShaderProgramv;
		
		public static uint CreateShaderProgramv(ShaderType type, int count, byte** strings)
		{
			return glCreateShaderProgramv(type, count, strings);
		}
		
		[MethodImport("glBindProgramPipeline", "4.1")]
		private static delegate*<uint, void> glBindProgramPipeline;
		
		public static void BindProgramPipeline(uint pipeline)
		{
			glBindProgramPipeline(pipeline);
		}
		
		[MethodImport("glDeleteProgramPipelines", "4.1")]
		private static delegate*<int, uint*, void> glDeleteProgramPipelines;
		
		public static void DeleteProgramPipelines(int n, uint* pipelines)
		{
			glDeleteProgramPipelines(n, pipelines);
		}
		
		[MethodImport("glGenProgramPipelines", "4.1")]
		private static delegate*<int, uint*, void> glGenProgramPipelines;
		
		public static void GenProgramPipelines(int n, uint* pipelines)
		{
			glGenProgramPipelines(n, pipelines);
		}
		
		[MethodImport("glIsProgramPipeline", "4.1")]
		private static delegate*<uint, bool> glIsProgramPipeline;
		
		public static bool IsProgramPipeline(uint pipeline)
		{
			return glIsProgramPipeline(pipeline);
		}
		
		[MethodImport("glGetProgramPipelineiv", "4.1")]
		private static delegate*<uint, PipelineParameterName, int*, void> glGetProgramPipelineiv;
		
		public static void GetProgramPipelineiv(uint pipeline, PipelineParameterName pname, int* @params)
		{
			glGetProgramPipelineiv(pipeline, pname, @params);
		}
		
		[MethodImport("glProgramUniform1i", "4.1")]
		private static delegate*<uint, int, int, void> glProgramUniform1i;
		
		public static void ProgramUniform1i(uint program, int location, int v0)
		{
			glProgramUniform1i(program, location, v0);
		}
		
		[MethodImport("glProgramUniform1iv", "4.1")]
		private static delegate*<uint, int, int, int*, void> glProgramUniform1iv;
		
		public static void ProgramUniform1iv(uint program, int location, int count, int* value)
		{
			glProgramUniform1iv(program, location, count, value);
		}
		
		[MethodImport("glProgramUniform1f", "4.1")]
		private static delegate*<uint, int, float, void> glProgramUniform1f;
		
		public static void ProgramUniform1f(uint program, int location, float v0)
		{
			glProgramUniform1f(program, location, v0);
		}
		
		[MethodImport("glProgramUniform1fv", "4.1")]
		private static delegate*<uint, int, int, float*, void> glProgramUniform1fv;
		
		public static void ProgramUniform1fv(uint program, int location, int count, float* value)
		{
			glProgramUniform1fv(program, location, count, value);
		}
		
		[MethodImport("glProgramUniform1d", "4.1")]
		private static delegate*<uint, int, double, void> glProgramUniform1d;
		
		public static void ProgramUniform1d(uint program, int location, double v0)
		{
			glProgramUniform1d(program, location, v0);
		}
		
		[MethodImport("glProgramUniform1dv", "4.1")]
		private static delegate*<uint, int, int, double*, void> glProgramUniform1dv;
		
		public static void ProgramUniform1dv(uint program, int location, int count, double* value)
		{
			glProgramUniform1dv(program, location, count, value);
		}
		
		[MethodImport("glProgramUniform1ui", "4.1")]
		private static delegate*<uint, int, uint, void> glProgramUniform1ui;
		
		public static void ProgramUniform1ui(uint program, int location, uint v0)
		{
			glProgramUniform1ui(program, location, v0);
		}
		
		[MethodImport("glProgramUniform1uiv", "4.1")]
		private static delegate*<uint, int, int, uint*, void> glProgramUniform1uiv;
		
		public static void ProgramUniform1uiv(uint program, int location, int count, uint* value)
		{
			glProgramUniform1uiv(program, location, count, value);
		}
		
		[MethodImport("glProgramUniform2i", "4.1")]
		private static delegate*<uint, int, int, int, void> glProgramUniform2i;
		
		public static void ProgramUniform2i(uint program, int location, int v0, int v1)
		{
			glProgramUniform2i(program, location, v0, v1);
		}
		
		[MethodImport("glProgramUniform2iv", "4.1")]
		private static delegate*<uint, int, int, int*, void> glProgramUniform2iv;
		
		public static void ProgramUniform2iv(uint program, int location, int count, int* value)
		{
			glProgramUniform2iv(program, location, count, value);
		}
		
		[MethodImport("glProgramUniform2f", "4.1")]
		private static delegate*<uint, int, float, float, void> glProgramUniform2f;
		
		public static void ProgramUniform2f(uint program, int location, float v0, float v1)
		{
			glProgramUniform2f(program, location, v0, v1);
		}
		
		[MethodImport("glProgramUniform2fv", "4.1")]
		private static delegate*<uint, int, int, float*, void> glProgramUniform2fv;
		
		public static void ProgramUniform2fv(uint program, int location, int count, float* value)
		{
			glProgramUniform2fv(program, location, count, value);
		}
		
		[MethodImport("glProgramUniform2d", "4.1")]
		private static delegate*<uint, int, double, double, void> glProgramUniform2d;
		
		public static void ProgramUniform2d(uint program, int location, double v0, double v1)
		{
			glProgramUniform2d(program, location, v0, v1);
		}
		
		[MethodImport("glProgramUniform2dv", "4.1")]
		private static delegate*<uint, int, int, double*, void> glProgramUniform2dv;
		
		public static void ProgramUniform2dv(uint program, int location, int count, double* value)
		{
			glProgramUniform2dv(program, location, count, value);
		}
		
		[MethodImport("glProgramUniform2ui", "4.1")]
		private static delegate*<uint, int, uint, uint, void> glProgramUniform2ui;
		
		public static void ProgramUniform2ui(uint program, int location, uint v0, uint v1)
		{
			glProgramUniform2ui(program, location, v0, v1);
		}
		
		[MethodImport("glProgramUniform2uiv", "4.1")]
		private static delegate*<uint, int, int, uint*, void> glProgramUniform2uiv;
		
		public static void ProgramUniform2uiv(uint program, int location, int count, uint* value)
		{
			glProgramUniform2uiv(program, location, count, value);
		}
		
		[MethodImport("glProgramUniform3i", "4.1")]
		private static delegate*<uint, int, int, int, int, void> glProgramUniform3i;
		
		public static void ProgramUniform3i(uint program, int location, int v0, int v1, int v2)
		{
			glProgramUniform3i(program, location, v0, v1, v2);
		}
		
		[MethodImport("glProgramUniform3iv", "4.1")]
		private static delegate*<uint, int, int, int*, void> glProgramUniform3iv;
		
		public static void ProgramUniform3iv(uint program, int location, int count, int* value)
		{
			glProgramUniform3iv(program, location, count, value);
		}
		
		[MethodImport("glProgramUniform3f", "4.1")]
		private static delegate*<uint, int, float, float, float, void> glProgramUniform3f;
		
		public static void ProgramUniform3f(uint program, int location, float v0, float v1, float v2)
		{
			glProgramUniform3f(program, location, v0, v1, v2);
		}
		
		[MethodImport("glProgramUniform3fv", "4.1")]
		private static delegate*<uint, int, int, float*, void> glProgramUniform3fv;
		
		public static void ProgramUniform3fv(uint program, int location, int count, float* value)
		{
			glProgramUniform3fv(program, location, count, value);
		}
		
		[MethodImport("glProgramUniform3d", "4.1")]
		private static delegate*<uint, int, double, double, double, void> glProgramUniform3d;
		
		public static void ProgramUniform3d(uint program, int location, double v0, double v1, double v2)
		{
			glProgramUniform3d(program, location, v0, v1, v2);
		}
		
		[MethodImport("glProgramUniform3dv", "4.1")]
		private static delegate*<uint, int, int, double*, void> glProgramUniform3dv;
		
		public static void ProgramUniform3dv(uint program, int location, int count, double* value)
		{
			glProgramUniform3dv(program, location, count, value);
		}
		
		[MethodImport("glProgramUniform3ui", "4.1")]
		private static delegate*<uint, int, uint, uint, uint, void> glProgramUniform3ui;
		
		public static void ProgramUniform3ui(uint program, int location, uint v0, uint v1, uint v2)
		{
			glProgramUniform3ui(program, location, v0, v1, v2);
		}
		
		[MethodImport("glProgramUniform3uiv", "4.1")]
		private static delegate*<uint, int, int, uint*, void> glProgramUniform3uiv;
		
		public static void ProgramUniform3uiv(uint program, int location, int count, uint* value)
		{
			glProgramUniform3uiv(program, location, count, value);
		}
		
		[MethodImport("glProgramUniform4i", "4.1")]
		private static delegate*<uint, int, int, int, int, int, void> glProgramUniform4i;
		
		public static void ProgramUniform4i(uint program, int location, int v0, int v1, int v2, int v3)
		{
			glProgramUniform4i(program, location, v0, v1, v2, v3);
		}
		
		[MethodImport("glProgramUniform4iv", "4.1")]
		private static delegate*<uint, int, int, int*, void> glProgramUniform4iv;
		
		public static void ProgramUniform4iv(uint program, int location, int count, int* value)
		{
			glProgramUniform4iv(program, location, count, value);
		}
		
		[MethodImport("glProgramUniform4f", "4.1")]
		private static delegate*<uint, int, float, float, float, float, void> glProgramUniform4f;
		
		public static void ProgramUniform4f(uint program, int location, float v0, float v1, float v2, float v3)
		{
			glProgramUniform4f(program, location, v0, v1, v2, v3);
		}
		
		[MethodImport("glProgramUniform4fv", "4.1")]
		private static delegate*<uint, int, int, float*, void> glProgramUniform4fv;
		
		public static void ProgramUniform4fv(uint program, int location, int count, float* value)
		{
			glProgramUniform4fv(program, location, count, value);
		}
		
		[MethodImport("glProgramUniform4d", "4.1")]
		private static delegate*<uint, int, double, double, double, double, void> glProgramUniform4d;
		
		public static void ProgramUniform4d(uint program, int location, double v0, double v1, double v2, double v3)
		{
			glProgramUniform4d(program, location, v0, v1, v2, v3);
		}
		
		[MethodImport("glProgramUniform4dv", "4.1")]
		private static delegate*<uint, int, int, double*, void> glProgramUniform4dv;
		
		public static void ProgramUniform4dv(uint program, int location, int count, double* value)
		{
			glProgramUniform4dv(program, location, count, value);
		}
		
		[MethodImport("glProgramUniform4ui", "4.1")]
		private static delegate*<uint, int, uint, uint, uint, uint, void> glProgramUniform4ui;
		
		public static void ProgramUniform4ui(uint program, int location, uint v0, uint v1, uint v2, uint v3)
		{
			glProgramUniform4ui(program, location, v0, v1, v2, v3);
		}
		
		[MethodImport("glProgramUniform4uiv", "4.1")]
		private static delegate*<uint, int, int, uint*, void> glProgramUniform4uiv;
		
		public static void ProgramUniform4uiv(uint program, int location, int count, uint* value)
		{
			glProgramUniform4uiv(program, location, count, value);
		}
		
		[MethodImport("glProgramUniformMatrix2fv", "4.1")]
		private static delegate*<uint, int, int, bool, float*, void> glProgramUniformMatrix2fv;
		
		public static void ProgramUniformMatrix2fv(uint program, int location, int count, bool transpose, float* value)
		{
			glProgramUniformMatrix2fv(program, location, count, transpose, value);
		}
		
		[MethodImport("glProgramUniformMatrix3fv", "4.1")]
		private static delegate*<uint, int, int, bool, float*, void> glProgramUniformMatrix3fv;
		
		public static void ProgramUniformMatrix3fv(uint program, int location, int count, bool transpose, float* value)
		{
			glProgramUniformMatrix3fv(program, location, count, transpose, value);
		}
		
		[MethodImport("glProgramUniformMatrix4fv", "4.1")]
		private static delegate*<uint, int, int, bool, float*, void> glProgramUniformMatrix4fv;
		
		public static void ProgramUniformMatrix4fv(uint program, int location, int count, bool transpose, float* value)
		{
			glProgramUniformMatrix4fv(program, location, count, transpose, value);
		}
		
		[MethodImport("glProgramUniformMatrix2dv", "4.1")]
		private static delegate*<uint, int, int, bool, double*, void> glProgramUniformMatrix2dv;
		
		public static void ProgramUniformMatrix2dv(uint program, int location, int count, bool transpose, double* value)
		{
			glProgramUniformMatrix2dv(program, location, count, transpose, value);
		}
		
		[MethodImport("glProgramUniformMatrix3dv", "4.1")]
		private static delegate*<uint, int, int, bool, double*, void> glProgramUniformMatrix3dv;
		
		public static void ProgramUniformMatrix3dv(uint program, int location, int count, bool transpose, double* value)
		{
			glProgramUniformMatrix3dv(program, location, count, transpose, value);
		}
		
		[MethodImport("glProgramUniformMatrix4dv", "4.1")]
		private static delegate*<uint, int, int, bool, double*, void> glProgramUniformMatrix4dv;
		
		public static void ProgramUniformMatrix4dv(uint program, int location, int count, bool transpose, double* value)
		{
			glProgramUniformMatrix4dv(program, location, count, transpose, value);
		}
		
		[MethodImport("glProgramUniformMatrix2x3fv", "4.1")]
		private static delegate*<uint, int, int, bool, float*, void> glProgramUniformMatrix2x3fv;
		
		public static void ProgramUniformMatrix2x3fv(uint program, int location, int count, bool transpose, float* value)
		{
			glProgramUniformMatrix2x3fv(program, location, count, transpose, value);
		}
		
		[MethodImport("glProgramUniformMatrix3x2fv", "4.1")]
		private static delegate*<uint, int, int, bool, float*, void> glProgramUniformMatrix3x2fv;
		
		public static void ProgramUniformMatrix3x2fv(uint program, int location, int count, bool transpose, float* value)
		{
			glProgramUniformMatrix3x2fv(program, location, count, transpose, value);
		}
		
		[MethodImport("glProgramUniformMatrix2x4fv", "4.1")]
		private static delegate*<uint, int, int, bool, float*, void> glProgramUniformMatrix2x4fv;
		
		public static void ProgramUniformMatrix2x4fv(uint program, int location, int count, bool transpose, float* value)
		{
			glProgramUniformMatrix2x4fv(program, location, count, transpose, value);
		}
		
		[MethodImport("glProgramUniformMatrix4x2fv", "4.1")]
		private static delegate*<uint, int, int, bool, float*, void> glProgramUniformMatrix4x2fv;
		
		public static void ProgramUniformMatrix4x2fv(uint program, int location, int count, bool transpose, float* value)
		{
			glProgramUniformMatrix4x2fv(program, location, count, transpose, value);
		}
		
		[MethodImport("glProgramUniformMatrix3x4fv", "4.1")]
		private static delegate*<uint, int, int, bool, float*, void> glProgramUniformMatrix3x4fv;
		
		public static void ProgramUniformMatrix3x4fv(uint program, int location, int count, bool transpose, float* value)
		{
			glProgramUniformMatrix3x4fv(program, location, count, transpose, value);
		}
		
		[MethodImport("glProgramUniformMatrix4x3fv", "4.1")]
		private static delegate*<uint, int, int, bool, float*, void> glProgramUniformMatrix4x3fv;
		
		public static void ProgramUniformMatrix4x3fv(uint program, int location, int count, bool transpose, float* value)
		{
			glProgramUniformMatrix4x3fv(program, location, count, transpose, value);
		}
		
		[MethodImport("glProgramUniformMatrix2x3dv", "4.1")]
		private static delegate*<uint, int, int, bool, double*, void> glProgramUniformMatrix2x3dv;
		
		public static void ProgramUniformMatrix2x3dv(uint program, int location, int count, bool transpose, double* value)
		{
			glProgramUniformMatrix2x3dv(program, location, count, transpose, value);
		}
		
		[MethodImport("glProgramUniformMatrix3x2dv", "4.1")]
		private static delegate*<uint, int, int, bool, double*, void> glProgramUniformMatrix3x2dv;
		
		public static void ProgramUniformMatrix3x2dv(uint program, int location, int count, bool transpose, double* value)
		{
			glProgramUniformMatrix3x2dv(program, location, count, transpose, value);
		}
		
		[MethodImport("glProgramUniformMatrix2x4dv", "4.1")]
		private static delegate*<uint, int, int, bool, double*, void> glProgramUniformMatrix2x4dv;
		
		public static void ProgramUniformMatrix2x4dv(uint program, int location, int count, bool transpose, double* value)
		{
			glProgramUniformMatrix2x4dv(program, location, count, transpose, value);
		}
		
		[MethodImport("glProgramUniformMatrix4x2dv", "4.1")]
		private static delegate*<uint, int, int, bool, double*, void> glProgramUniformMatrix4x2dv;
		
		public static void ProgramUniformMatrix4x2dv(uint program, int location, int count, bool transpose, double* value)
		{
			glProgramUniformMatrix4x2dv(program, location, count, transpose, value);
		}
		
		[MethodImport("glProgramUniformMatrix3x4dv", "4.1")]
		private static delegate*<uint, int, int, bool, double*, void> glProgramUniformMatrix3x4dv;
		
		public static void ProgramUniformMatrix3x4dv(uint program, int location, int count, bool transpose, double* value)
		{
			glProgramUniformMatrix3x4dv(program, location, count, transpose, value);
		}
		
		[MethodImport("glProgramUniformMatrix4x3dv", "4.1")]
		private static delegate*<uint, int, int, bool, double*, void> glProgramUniformMatrix4x3dv;
		
		public static void ProgramUniformMatrix4x3dv(uint program, int location, int count, bool transpose, double* value)
		{
			glProgramUniformMatrix4x3dv(program, location, count, transpose, value);
		}
		
		[MethodImport("glValidateProgramPipeline", "4.1")]
		private static delegate*<uint, void> glValidateProgramPipeline;
		
		public static void ValidateProgramPipeline(uint pipeline)
		{
			glValidateProgramPipeline(pipeline);
		}
		
		[MethodImport("glGetProgramPipelineInfoLog", "4.1")]
		private static delegate*<uint, int, int*, byte*, void> glGetProgramPipelineInfoLog;
		
		public static void GetProgramPipelineInfoLog(uint pipeline, int bufSize, int* length, byte* infoLog)
		{
			glGetProgramPipelineInfoLog(pipeline, bufSize, length, infoLog);
		}
		
		[MethodImport("glVertexAttribL1d", "4.1")]
		private static delegate*<uint, double, void> glVertexAttribL1d;
		
		public static void VertexAttribL1d(uint index, double x)
		{
			glVertexAttribL1d(index, x);
		}
		
		[MethodImport("glVertexAttribL2d", "4.1")]
		private static delegate*<uint, double, double, void> glVertexAttribL2d;
		
		public static void VertexAttribL2d(uint index, double x, double y)
		{
			glVertexAttribL2d(index, x, y);
		}
		
		[MethodImport("glVertexAttribL3d", "4.1")]
		private static delegate*<uint, double, double, double, void> glVertexAttribL3d;
		
		public static void VertexAttribL3d(uint index, double x, double y, double z)
		{
			glVertexAttribL3d(index, x, y, z);
		}
		
		[MethodImport("glVertexAttribL4d", "4.1")]
		private static delegate*<uint, double, double, double, double, void> glVertexAttribL4d;
		
		public static void VertexAttribL4d(uint index, double x, double y, double z, double w)
		{
			glVertexAttribL4d(index, x, y, z, w);
		}
		
		[MethodImport("glVertexAttribL1dv", "4.1")]
		private static delegate*<uint, double*, void> glVertexAttribL1dv;
		
		public static void VertexAttribL1dv(uint index, double* v)
		{
			glVertexAttribL1dv(index, v);
		}
		
		[MethodImport("glVertexAttribL2dv", "4.1")]
		private static delegate*<uint, double*, void> glVertexAttribL2dv;
		
		public static void VertexAttribL2dv(uint index, double* v)
		{
			glVertexAttribL2dv(index, v);
		}
		
		[MethodImport("glVertexAttribL3dv", "4.1")]
		private static delegate*<uint, double*, void> glVertexAttribL3dv;
		
		public static void VertexAttribL3dv(uint index, double* v)
		{
			glVertexAttribL3dv(index, v);
		}
		
		[MethodImport("glVertexAttribL4dv", "4.1")]
		private static delegate*<uint, double*, void> glVertexAttribL4dv;
		
		public static void VertexAttribL4dv(uint index, double* v)
		{
			glVertexAttribL4dv(index, v);
		}
		
		[MethodImport("glVertexAttribLPointer", "4.1")]
		private static delegate*<uint, int, VertexAttribLType, int, void*, void> glVertexAttribLPointer;
		
		public static void VertexAttribLPointer(uint index, int size, VertexAttribLType type, int stride, void* pointer)
		{
			glVertexAttribLPointer(index, size, type, stride, pointer);
		}
		
		[MethodImport("glGetVertexAttribLdv", "4.1")]
		private static delegate*<uint, VertexAttribEnum, double*, void> glGetVertexAttribLdv;
		
		public static void GetVertexAttribLdv(uint index, VertexAttribEnum pname, double* @params)
		{
			glGetVertexAttribLdv(index, pname, @params);
		}
		
		[MethodImport("glViewportArrayv", "4.1")]
		private static delegate*<uint, int, float*, void> glViewportArrayv;
		
		public static void ViewportArrayv(uint first, int count, float* v)
		{
			glViewportArrayv(first, count, v);
		}
		
		[MethodImport("glViewportIndexedf", "4.1")]
		private static delegate*<uint, float, float, float, float, void> glViewportIndexedf;
		
		public static void ViewportIndexedf(uint index, float x, float y, float w, float h)
		{
			glViewportIndexedf(index, x, y, w, h);
		}
		
		[MethodImport("glViewportIndexedfv", "4.1")]
		private static delegate*<uint, float*, void> glViewportIndexedfv;
		
		public static void ViewportIndexedfv(uint index, float* v)
		{
			glViewportIndexedfv(index, v);
		}
		
		[MethodImport("glScissorArrayv", "4.1")]
		private static delegate*<uint, int, int*, void> glScissorArrayv;
		
		public static void ScissorArrayv(uint first, int count, int* v)
		{
			glScissorArrayv(first, count, v);
		}
		
		[MethodImport("glScissorIndexed", "4.1")]
		private static delegate*<uint, int, int, int, int, void> glScissorIndexed;
		
		public static void ScissorIndexed(uint index, int left, int bottom, int width, int height)
		{
			glScissorIndexed(index, left, bottom, width, height);
		}
		
		[MethodImport("glScissorIndexedv", "4.1")]
		private static delegate*<uint, int*, void> glScissorIndexedv;
		
		public static void ScissorIndexedv(uint index, int* v)
		{
			glScissorIndexedv(index, v);
		}
		
		[MethodImport("glDepthRangeArrayv", "4.1")]
		private static delegate*<uint, int, double*, void> glDepthRangeArrayv;
		
		public static void DepthRangeArrayv(uint first, int count, double* v)
		{
			glDepthRangeArrayv(first, count, v);
		}
		
		[MethodImport("glDepthRangeIndexed", "4.1")]
		private static delegate*<uint, double, double, void> glDepthRangeIndexed;
		
		public static void DepthRangeIndexed(uint index, double n, double f)
		{
			glDepthRangeIndexed(index, n, f);
		}
		
		[MethodImport("glGetFloati_v", "4.1")]
		private static delegate*<GetPName, uint, float*, void> glGetFloati_v;
		
		public static void GetFloati_v(GetPName target, uint index, float* data)
		{
			glGetFloati_v(target, index, data);
		}
		
		[MethodImport("glGetDoublei_v", "4.1")]
		private static delegate*<GetPName, uint, double*, void> glGetDoublei_v;
		
		public static void GetDoublei_v(GetPName target, uint index, double* data)
		{
			glGetDoublei_v(target, index, data);
		}
	}
}

