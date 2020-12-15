using System;
using System.Runtime.InteropServices;
using CC = System.Runtime.InteropServices.CallingConvention;
using UFP = System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute;

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[UFP(CC.Cdecl)]
		private unsafe delegate void ReleaseShaderCompilerDelegate();

		[UFP(CC.Cdecl)]
		private unsafe delegate void ShaderBinaryDelegate(int count, ref uint shaders, uint binaryformat, IntPtr binary, int length);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetShaderPrecisionFormatDelegate(uint shadertype, uint precisiontype, ref int range, ref int precision);

		[UFP(CC.Cdecl)]
		private unsafe delegate void DepthRangefDelegate(float n, float f);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ClearDepthfDelegate(float d);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetProgramBinaryDelegate(uint program, int bufSize, ref int length, ref uint binaryFormat, IntPtr binary);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ProgramBinaryDelegate(uint program, uint binaryFormat, IntPtr binary, int length);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ProgramParameteriDelegate(uint program, uint pName, int value);

		[UFP(CC.Cdecl)]
		private unsafe delegate void UseProgramStagesDelegate(uint pipeline, uint stages, uint program);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ActiveShaderProgramDelegate(uint pipeline, uint program);

		[UFP(CC.Cdecl)]
		private unsafe delegate uint CreateShaderProgramvDelegate(uint type, int count, IntPtr strings);

		[UFP(CC.Cdecl)]
		private unsafe delegate void BindProgramPipelineDelegate(uint pipeline);

		[UFP(CC.Cdecl)]
		private unsafe delegate void DeleteProgramPipelinesDelegate(int n, ref uint pipelines);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GenProgramPipelinesDelegate(int n, ref uint pipelines);

		[UFP(CC.Cdecl)]
		private unsafe delegate byte IsProgramPipelineDelegate(uint pipeline);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetProgramPipelineivDelegate(uint pipeline, uint pName, ref int parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ProgramUniform1iDelegate(uint program, int location, int v0);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ProgramUniform1ivDelegate(uint program, int location, int count, ref int value);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ProgramUniform1fDelegate(uint program, int location, float v0);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ProgramUniform1fvDelegate(uint program, int location, int count, ref float value);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ProgramUniform1dDelegate(uint program, int location, double v0);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ProgramUniform1dvDelegate(uint program, int location, int count, ref double value);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ProgramUniform1uiDelegate(uint program, int location, uint v0);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ProgramUniform1uivDelegate(uint program, int location, int count, ref uint value);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ProgramUniform2iDelegate(uint program, int location, int v0, int v1);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ProgramUniform2ivDelegate(uint program, int location, int count, ref int value);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ProgramUniform2fDelegate(uint program, int location, float v0, float v1);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ProgramUniform2fvDelegate(uint program, int location, int count, ref float value);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ProgramUniform2dDelegate(uint program, int location, double v0, double v1);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ProgramUniform2dvDelegate(uint program, int location, int count, ref double value);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ProgramUniform2uiDelegate(uint program, int location, uint v0, uint v1);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ProgramUniform2uivDelegate(uint program, int location, int count, ref uint value);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ProgramUniform3iDelegate(uint program, int location, int v0, int v1, int v2);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ProgramUniform3ivDelegate(uint program, int location, int count, ref int value);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ProgramUniform3fDelegate(uint program, int location, float v0, float v1, float v2);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ProgramUniform3fvDelegate(uint program, int location, int count, ref float value);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ProgramUniform3dDelegate(uint program, int location, double v0, double v1, double v2);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ProgramUniform3dvDelegate(uint program, int location, int count, ref double value);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ProgramUniform3uiDelegate(uint program, int location, uint v0, uint v1, uint v2);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ProgramUniform3uivDelegate(uint program, int location, int count, ref uint value);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ProgramUniform4iDelegate(uint program, int location, int v0, int v1, int v2, int v3);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ProgramUniform4ivDelegate(uint program, int location, int count, ref int value);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ProgramUniform4fDelegate(uint program, int location, float v0, float v1, float v2, float v3);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ProgramUniform4fvDelegate(uint program, int location, int count, ref float value);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ProgramUniform4dDelegate(uint program, int location, double v0, double v1, double v2, double v3);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ProgramUniform4dvDelegate(uint program, int location, int count, ref double value);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ProgramUniform4uiDelegate(uint program, int location, uint v0, uint v1, uint v2, uint v3);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ProgramUniform4uivDelegate(uint program, int location, int count, ref uint value);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ProgramUniformMatrix2fvDelegate(uint program, int location, int count, byte transpose, ref float value);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ProgramUniformMatrix3fvDelegate(uint program, int location, int count, byte transpose, ref float value);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ProgramUniformMatrix4fvDelegate(uint program, int location, int count, byte transpose, ref float value);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ProgramUniformMatrix2dvDelegate(uint program, int location, int count, byte transpose, ref double value);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ProgramUniformMatrix3dvDelegate(uint program, int location, int count, byte transpose, ref double value);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ProgramUniformMatrix4dvDelegate(uint program, int location, int count, byte transpose, ref double value);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ProgramUniformMatrix2x3fvDelegate(uint program, int location, int count, byte transpose, ref float value);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ProgramUniformMatrix3x2fvDelegate(uint program, int location, int count, byte transpose, ref float value);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ProgramUniformMatrix2x4fvDelegate(uint program, int location, int count, byte transpose, ref float value);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ProgramUniformMatrix4x2fvDelegate(uint program, int location, int count, byte transpose, ref float value);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ProgramUniformMatrix3x4fvDelegate(uint program, int location, int count, byte transpose, ref float value);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ProgramUniformMatrix4x3fvDelegate(uint program, int location, int count, byte transpose, ref float value);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ProgramUniformMatrix2x3dvDelegate(uint program, int location, int count, byte transpose, ref double value);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ProgramUniformMatrix3x2dvDelegate(uint program, int location, int count, byte transpose, ref double value);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ProgramUniformMatrix2x4dvDelegate(uint program, int location, int count, byte transpose, ref double value);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ProgramUniformMatrix4x2dvDelegate(uint program, int location, int count, byte transpose, ref double value);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ProgramUniformMatrix3x4dvDelegate(uint program, int location, int count, byte transpose, ref double value);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ProgramUniformMatrix4x3dvDelegate(uint program, int location, int count, byte transpose, ref double value);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ValidateProgramPipelineDelegate(uint pipeline);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetProgramPipelineInfoLogDelegate(uint pipeline, int bufSize, ref int length, IntPtr infoLog);

		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttribL1dDelegate(uint index, double x);

		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttribL2dDelegate(uint index, double x, double y);

		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttribL3dDelegate(uint index, double x, double y, double z);

		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttribL4dDelegate(uint index, double x, double y, double z, double w);

		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttribL1dvDelegate(uint index, ref double v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttribL2dvDelegate(uint index, ref double v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttribL3dvDelegate(uint index, ref double v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttribL4dvDelegate(uint index, ref double v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void VertexAttribLPointerDelegate(uint index, int size, uint type, int stride, IntPtr pointer);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetVertexAttribLdvDelegate(uint index, uint pName, ref double parameters);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ViewportArrayvDelegate(uint first, int count, ref float v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ViewportIndexedfDelegate(uint index, float x, float y, float w, float h);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ViewportIndexedfvDelegate(uint index, ref float v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ScissorArrayvDelegate(uint first, int count, ref int v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ScissorIndexedDelegate(uint index, int left, int bottom, int width, int height);

		[UFP(CC.Cdecl)]
		private unsafe delegate void ScissorIndexedvDelegate(uint index, ref int v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void DepthRangeArrayvDelegate(uint first, int count, ref double v);

		[UFP(CC.Cdecl)]
		private unsafe delegate void DepthRangeIndexedDelegate(uint index, double n, double f);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetFloati_vDelegate(uint target, uint index, ref float data);

		[UFP(CC.Cdecl)]
		private unsafe delegate void GetDoublei_vDelegate(uint target, uint index, ref double data);
	}
}
