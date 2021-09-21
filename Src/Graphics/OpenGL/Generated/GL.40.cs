using System;

namespace Dissonance.Framework.Graphics.OpenGL
{
	unsafe partial class GL
	{
		[MethodImport("glMinSampleShading", "4.0")]
		private static delegate*<float, void> glMinSampleShading;
		
		public static void MinSampleShading(float value)
		{
			glMinSampleShading(value);
		}
		
		[MethodImport("glBlendEquationi", "4.0")]
		private static delegate*<uint, BlendEquationModeEXT, void> glBlendEquationi;
		
		public static void BlendEquationi(uint buf, BlendEquationModeEXT mode)
		{
			glBlendEquationi(buf, mode);
		}
		
		[MethodImport("glBlendEquationSeparatei", "4.0")]
		private static delegate*<uint, BlendEquationModeEXT, BlendEquationModeEXT, void> glBlendEquationSeparatei;
		
		public static void BlendEquationSeparatei(uint buf, BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha)
		{
			glBlendEquationSeparatei(buf, modeRGB, modeAlpha);
		}
		
		[MethodImport("glBlendFunci", "4.0")]
		private static delegate*<uint, BlendingFactor, BlendingFactor, void> glBlendFunci;
		
		public static void BlendFunci(uint buf, BlendingFactor src, BlendingFactor dst)
		{
			glBlendFunci(buf, src, dst);
		}
		
		[MethodImport("glBlendFuncSeparatei", "4.0")]
		private static delegate*<uint, BlendingFactor, BlendingFactor, BlendingFactor, BlendingFactor, void> glBlendFuncSeparatei;
		
		public static void BlendFuncSeparatei(uint buf, BlendingFactor srcRGB, BlendingFactor dstRGB, BlendingFactor srcAlpha, BlendingFactor dstAlpha)
		{
			glBlendFuncSeparatei(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
		}
		
		[MethodImport("glDrawArraysIndirect", "4.0")]
		private static delegate*<PrimitiveType, void*, void> glDrawArraysIndirect;
		
		public static void DrawArraysIndirect(PrimitiveType mode, void* indirect)
		{
			glDrawArraysIndirect(mode, indirect);
		}
		
		[MethodImport("glDrawElementsIndirect", "4.0")]
		private static delegate*<PrimitiveType, DrawElementsType, void*, void> glDrawElementsIndirect;
		
		public static void DrawElementsIndirect(PrimitiveType mode, DrawElementsType type, void* indirect)
		{
			glDrawElementsIndirect(mode, type, indirect);
		}
		
		[MethodImport("glUniform1d", "4.0")]
		private static delegate*<int, double, void> glUniform1d;
		
		public static void Uniform1d(int location, double x)
		{
			glUniform1d(location, x);
		}
		
		[MethodImport("glUniform2d", "4.0")]
		private static delegate*<int, double, double, void> glUniform2d;
		
		public static void Uniform2d(int location, double x, double y)
		{
			glUniform2d(location, x, y);
		}
		
		[MethodImport("glUniform3d", "4.0")]
		private static delegate*<int, double, double, double, void> glUniform3d;
		
		public static void Uniform3d(int location, double x, double y, double z)
		{
			glUniform3d(location, x, y, z);
		}
		
		[MethodImport("glUniform4d", "4.0")]
		private static delegate*<int, double, double, double, double, void> glUniform4d;
		
		public static void Uniform4d(int location, double x, double y, double z, double w)
		{
			glUniform4d(location, x, y, z, w);
		}
		
		[MethodImport("glUniform1dv", "4.0")]
		private static delegate*<int, int, double*, void> glUniform1dv;
		
		public static void Uniform1dv(int location, int count, double* value)
		{
			glUniform1dv(location, count, value);
		}
		
		[MethodImport("glUniform2dv", "4.0")]
		private static delegate*<int, int, double*, void> glUniform2dv;
		
		public static void Uniform2dv(int location, int count, double* value)
		{
			glUniform2dv(location, count, value);
		}
		
		[MethodImport("glUniform3dv", "4.0")]
		private static delegate*<int, int, double*, void> glUniform3dv;
		
		public static void Uniform3dv(int location, int count, double* value)
		{
			glUniform3dv(location, count, value);
		}
		
		[MethodImport("glUniform4dv", "4.0")]
		private static delegate*<int, int, double*, void> glUniform4dv;
		
		public static void Uniform4dv(int location, int count, double* value)
		{
			glUniform4dv(location, count, value);
		}
		
		[MethodImport("glUniformMatrix2dv", "4.0")]
		private static delegate*<int, int, bool, double*, void> glUniformMatrix2dv;
		
		public static void UniformMatrix2dv(int location, int count, bool transpose, double* value)
		{
			glUniformMatrix2dv(location, count, transpose, value);
		}
		
		[MethodImport("glUniformMatrix3dv", "4.0")]
		private static delegate*<int, int, bool, double*, void> glUniformMatrix3dv;
		
		public static void UniformMatrix3dv(int location, int count, bool transpose, double* value)
		{
			glUniformMatrix3dv(location, count, transpose, value);
		}
		
		[MethodImport("glUniformMatrix4dv", "4.0")]
		private static delegate*<int, int, bool, double*, void> glUniformMatrix4dv;
		
		public static void UniformMatrix4dv(int location, int count, bool transpose, double* value)
		{
			glUniformMatrix4dv(location, count, transpose, value);
		}
		
		[MethodImport("glUniformMatrix2x3dv", "4.0")]
		private static delegate*<int, int, bool, double*, void> glUniformMatrix2x3dv;
		
		public static void UniformMatrix2x3dv(int location, int count, bool transpose, double* value)
		{
			glUniformMatrix2x3dv(location, count, transpose, value);
		}
		
		[MethodImport("glUniformMatrix2x4dv", "4.0")]
		private static delegate*<int, int, bool, double*, void> glUniformMatrix2x4dv;
		
		public static void UniformMatrix2x4dv(int location, int count, bool transpose, double* value)
		{
			glUniformMatrix2x4dv(location, count, transpose, value);
		}
		
		[MethodImport("glUniformMatrix3x2dv", "4.0")]
		private static delegate*<int, int, bool, double*, void> glUniformMatrix3x2dv;
		
		public static void UniformMatrix3x2dv(int location, int count, bool transpose, double* value)
		{
			glUniformMatrix3x2dv(location, count, transpose, value);
		}
		
		[MethodImport("glUniformMatrix3x4dv", "4.0")]
		private static delegate*<int, int, bool, double*, void> glUniformMatrix3x4dv;
		
		public static void UniformMatrix3x4dv(int location, int count, bool transpose, double* value)
		{
			glUniformMatrix3x4dv(location, count, transpose, value);
		}
		
		[MethodImport("glUniformMatrix4x2dv", "4.0")]
		private static delegate*<int, int, bool, double*, void> glUniformMatrix4x2dv;
		
		public static void UniformMatrix4x2dv(int location, int count, bool transpose, double* value)
		{
			glUniformMatrix4x2dv(location, count, transpose, value);
		}
		
		[MethodImport("glUniformMatrix4x3dv", "4.0")]
		private static delegate*<int, int, bool, double*, void> glUniformMatrix4x3dv;
		
		public static void UniformMatrix4x3dv(int location, int count, bool transpose, double* value)
		{
			glUniformMatrix4x3dv(location, count, transpose, value);
		}
		
		[MethodImport("glGetUniformdv", "4.0")]
		private static delegate*<uint, int, double*, void> glGetUniformdv;
		
		public static void GetUniformdv(uint program, int location, double* @params)
		{
			glGetUniformdv(program, location, @params);
		}
		
		[MethodImport("glGetSubroutineUniformLocation", "4.0")]
		private static delegate*<uint, ShaderType, byte*, int> glGetSubroutineUniformLocation;
		
		public static int GetSubroutineUniformLocation(uint program, ShaderType shadertype, byte* name)
		{
			return glGetSubroutineUniformLocation(program, shadertype, name);
		}
		
		[MethodImport("glGetSubroutineIndex", "4.0")]
		private static delegate*<uint, ShaderType, byte*, uint> glGetSubroutineIndex;
		
		public static uint GetSubroutineIndex(uint program, ShaderType shadertype, byte* name)
		{
			return glGetSubroutineIndex(program, shadertype, name);
		}
		
		[MethodImport("glGetActiveSubroutineUniformiv", "4.0")]
		private static delegate*<uint, ShaderType, uint, SubroutineParameterName, int*, void> glGetActiveSubroutineUniformiv;
		
		public static void GetActiveSubroutineUniformiv(uint program, ShaderType shadertype, uint index, SubroutineParameterName pname, int* values)
		{
			glGetActiveSubroutineUniformiv(program, shadertype, index, pname, values);
		}
		
		[MethodImport("glGetActiveSubroutineUniformName", "4.0")]
		private static delegate*<uint, ShaderType, uint, int, int*, byte*, void> glGetActiveSubroutineUniformName;
		
		public static void GetActiveSubroutineUniformName(uint program, ShaderType shadertype, uint index, int bufSize, int* length, byte* name)
		{
			glGetActiveSubroutineUniformName(program, shadertype, index, bufSize, length, name);
		}
		
		[MethodImport("glGetActiveSubroutineName", "4.0")]
		private static delegate*<uint, ShaderType, uint, int, int*, byte*, void> glGetActiveSubroutineName;
		
		public static void GetActiveSubroutineName(uint program, ShaderType shadertype, uint index, int bufSize, int* length, byte* name)
		{
			glGetActiveSubroutineName(program, shadertype, index, bufSize, length, name);
		}
		
		[MethodImport("glUniformSubroutinesuiv", "4.0")]
		private static delegate*<ShaderType, int, uint*, void> glUniformSubroutinesuiv;
		
		public static void UniformSubroutinesuiv(ShaderType shadertype, int count, uint* indices)
		{
			glUniformSubroutinesuiv(shadertype, count, indices);
		}
		
		[MethodImport("glGetUniformSubroutineuiv", "4.0")]
		private static delegate*<ShaderType, int, uint*, void> glGetUniformSubroutineuiv;
		
		public static void GetUniformSubroutineuiv(ShaderType shadertype, int location, uint* @params)
		{
			glGetUniformSubroutineuiv(shadertype, location, @params);
		}
		
		[MethodImport("glGetProgramStageiv", "4.0")]
		private static delegate*<uint, ShaderType, ProgramStagePName, int*, void> glGetProgramStageiv;
		
		public static void GetProgramStageiv(uint program, ShaderType shadertype, ProgramStagePName pname, int* values)
		{
			glGetProgramStageiv(program, shadertype, pname, values);
		}
		
		[MethodImport("glPatchParameteri", "4.0")]
		private static delegate*<PatchParameterName, int, void> glPatchParameteri;
		
		public static void PatchParameteri(PatchParameterName pname, int value)
		{
			glPatchParameteri(pname, value);
		}
		
		[MethodImport("glPatchParameterfv", "4.0")]
		private static delegate*<PatchParameterName, float*, void> glPatchParameterfv;
		
		public static void PatchParameterfv(PatchParameterName pname, float* values)
		{
			glPatchParameterfv(pname, values);
		}
		
		[MethodImport("glBindTransformFeedback", "4.0")]
		private static delegate*<BindTransformFeedbackTarget, uint, void> glBindTransformFeedback;
		
		public static void BindTransformFeedback(BindTransformFeedbackTarget target, uint id)
		{
			glBindTransformFeedback(target, id);
		}
		
		[MethodImport("glDeleteTransformFeedbacks", "4.0")]
		private static delegate*<int, uint*, void> glDeleteTransformFeedbacks;
		
		public static void DeleteTransformFeedbacks(int n, uint* ids)
		{
			glDeleteTransformFeedbacks(n, ids);
		}
		
		[MethodImport("glGenTransformFeedbacks", "4.0")]
		private static delegate*<int, uint*, void> glGenTransformFeedbacks;
		
		public static void GenTransformFeedbacks(int n, uint* ids)
		{
			glGenTransformFeedbacks(n, ids);
		}
		
		[MethodImport("glIsTransformFeedback", "4.0")]
		private static delegate*<uint, bool> glIsTransformFeedback;
		
		public static bool IsTransformFeedback(uint id)
		{
			return glIsTransformFeedback(id);
		}
		
		[MethodImport("glPauseTransformFeedback", "4.0")]
		private static delegate*<void> glPauseTransformFeedback;
		
		public static void PauseTransformFeedback()
		{
			glPauseTransformFeedback();
		}
		
		[MethodImport("glResumeTransformFeedback", "4.0")]
		private static delegate*<void> glResumeTransformFeedback;
		
		public static void ResumeTransformFeedback()
		{
			glResumeTransformFeedback();
		}
		
		[MethodImport("glDrawTransformFeedback", "4.0")]
		private static delegate*<PrimitiveType, uint, void> glDrawTransformFeedback;
		
		public static void DrawTransformFeedback(PrimitiveType mode, uint id)
		{
			glDrawTransformFeedback(mode, id);
		}
		
		[MethodImport("glDrawTransformFeedbackStream", "4.0")]
		private static delegate*<PrimitiveType, uint, uint, void> glDrawTransformFeedbackStream;
		
		public static void DrawTransformFeedbackStream(PrimitiveType mode, uint id, uint stream)
		{
			glDrawTransformFeedbackStream(mode, id, stream);
		}
		
		[MethodImport("glBeginQueryIndexed", "4.0")]
		private static delegate*<QueryTarget, uint, uint, void> glBeginQueryIndexed;
		
		public static void BeginQueryIndexed(QueryTarget target, uint index, uint id)
		{
			glBeginQueryIndexed(target, index, id);
		}
		
		[MethodImport("glEndQueryIndexed", "4.0")]
		private static delegate*<QueryTarget, uint, void> glEndQueryIndexed;
		
		public static void EndQueryIndexed(QueryTarget target, uint index)
		{
			glEndQueryIndexed(target, index);
		}
		
		[MethodImport("glGetQueryIndexediv", "4.0")]
		private static delegate*<QueryTarget, uint, QueryParameterName, int*, void> glGetQueryIndexediv;
		
		public static void GetQueryIndexediv(QueryTarget target, uint index, QueryParameterName pname, int* @params)
		{
			glGetQueryIndexediv(target, index, pname, @params);
		}
	}
}

