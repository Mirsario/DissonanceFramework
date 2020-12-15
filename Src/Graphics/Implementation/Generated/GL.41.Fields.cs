#pragma warning disable CS0649

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[MethodImport("glReleaseShaderCompiler")]
		private static ReleaseShaderCompilerDelegate glReleaseShaderCompiler;

		[MethodImport("glShaderBinary")]
		private static ShaderBinaryDelegate glShaderBinary;

		[MethodImport("glGetShaderPrecisionFormat")]
		private static GetShaderPrecisionFormatDelegate glGetShaderPrecisionFormat;

		[MethodImport("glDepthRangef")]
		private static DepthRangefDelegate glDepthRangef;

		[MethodImport("glClearDepthf")]
		private static ClearDepthfDelegate glClearDepthf;

		[MethodImport("glGetProgramBinary")]
		private static GetProgramBinaryDelegate glGetProgramBinary;

		[MethodImport("glProgramBinary")]
		private static ProgramBinaryDelegate glProgramBinary;

		[MethodImport("glProgramParameteri")]
		private static ProgramParameteriDelegate glProgramParameteri;

		[MethodImport("glUseProgramStages")]
		private static UseProgramStagesDelegate glUseProgramStages;

		[MethodImport("glActiveShaderProgram")]
		private static ActiveShaderProgramDelegate glActiveShaderProgram;

		[MethodImport("glCreateShaderProgramv")]
		private static CreateShaderProgramvDelegate glCreateShaderProgramv;

		[MethodImport("glBindProgramPipeline")]
		private static BindProgramPipelineDelegate glBindProgramPipeline;

		[MethodImport("glDeleteProgramPipelines")]
		private static DeleteProgramPipelinesDelegate glDeleteProgramPipelines;

		[MethodImport("glGenProgramPipelines")]
		private static GenProgramPipelinesDelegate glGenProgramPipelines;

		[MethodImport("glIsProgramPipeline")]
		private static IsProgramPipelineDelegate glIsProgramPipeline;

		[MethodImport("glGetProgramPipelineiv")]
		private static GetProgramPipelineivDelegate glGetProgramPipelineiv;

		[MethodImport("glProgramUniform1i")]
		private static ProgramUniform1iDelegate glProgramUniform1i;

		[MethodImport("glProgramUniform1iv")]
		private static ProgramUniform1ivDelegate glProgramUniform1iv;

		[MethodImport("glProgramUniform1f")]
		private static ProgramUniform1fDelegate glProgramUniform1f;

		[MethodImport("glProgramUniform1fv")]
		private static ProgramUniform1fvDelegate glProgramUniform1fv;

		[MethodImport("glProgramUniform1d")]
		private static ProgramUniform1dDelegate glProgramUniform1d;

		[MethodImport("glProgramUniform1dv")]
		private static ProgramUniform1dvDelegate glProgramUniform1dv;

		[MethodImport("glProgramUniform1ui")]
		private static ProgramUniform1uiDelegate glProgramUniform1ui;

		[MethodImport("glProgramUniform1uiv")]
		private static ProgramUniform1uivDelegate glProgramUniform1uiv;

		[MethodImport("glProgramUniform2i")]
		private static ProgramUniform2iDelegate glProgramUniform2i;

		[MethodImport("glProgramUniform2iv")]
		private static ProgramUniform2ivDelegate glProgramUniform2iv;

		[MethodImport("glProgramUniform2f")]
		private static ProgramUniform2fDelegate glProgramUniform2f;

		[MethodImport("glProgramUniform2fv")]
		private static ProgramUniform2fvDelegate glProgramUniform2fv;

		[MethodImport("glProgramUniform2d")]
		private static ProgramUniform2dDelegate glProgramUniform2d;

		[MethodImport("glProgramUniform2dv")]
		private static ProgramUniform2dvDelegate glProgramUniform2dv;

		[MethodImport("glProgramUniform2ui")]
		private static ProgramUniform2uiDelegate glProgramUniform2ui;

		[MethodImport("glProgramUniform2uiv")]
		private static ProgramUniform2uivDelegate glProgramUniform2uiv;

		[MethodImport("glProgramUniform3i")]
		private static ProgramUniform3iDelegate glProgramUniform3i;

		[MethodImport("glProgramUniform3iv")]
		private static ProgramUniform3ivDelegate glProgramUniform3iv;

		[MethodImport("glProgramUniform3f")]
		private static ProgramUniform3fDelegate glProgramUniform3f;

		[MethodImport("glProgramUniform3fv")]
		private static ProgramUniform3fvDelegate glProgramUniform3fv;

		[MethodImport("glProgramUniform3d")]
		private static ProgramUniform3dDelegate glProgramUniform3d;

		[MethodImport("glProgramUniform3dv")]
		private static ProgramUniform3dvDelegate glProgramUniform3dv;

		[MethodImport("glProgramUniform3ui")]
		private static ProgramUniform3uiDelegate glProgramUniform3ui;

		[MethodImport("glProgramUniform3uiv")]
		private static ProgramUniform3uivDelegate glProgramUniform3uiv;

		[MethodImport("glProgramUniform4i")]
		private static ProgramUniform4iDelegate glProgramUniform4i;

		[MethodImport("glProgramUniform4iv")]
		private static ProgramUniform4ivDelegate glProgramUniform4iv;

		[MethodImport("glProgramUniform4f")]
		private static ProgramUniform4fDelegate glProgramUniform4f;

		[MethodImport("glProgramUniform4fv")]
		private static ProgramUniform4fvDelegate glProgramUniform4fv;

		[MethodImport("glProgramUniform4d")]
		private static ProgramUniform4dDelegate glProgramUniform4d;

		[MethodImport("glProgramUniform4dv")]
		private static ProgramUniform4dvDelegate glProgramUniform4dv;

		[MethodImport("glProgramUniform4ui")]
		private static ProgramUniform4uiDelegate glProgramUniform4ui;

		[MethodImport("glProgramUniform4uiv")]
		private static ProgramUniform4uivDelegate glProgramUniform4uiv;

		[MethodImport("glProgramUniformMatrix2fv")]
		private static ProgramUniformMatrix2fvDelegate glProgramUniformMatrix2fv;

		[MethodImport("glProgramUniformMatrix3fv")]
		private static ProgramUniformMatrix3fvDelegate glProgramUniformMatrix3fv;

		[MethodImport("glProgramUniformMatrix4fv")]
		private static ProgramUniformMatrix4fvDelegate glProgramUniformMatrix4fv;

		[MethodImport("glProgramUniformMatrix2dv")]
		private static ProgramUniformMatrix2dvDelegate glProgramUniformMatrix2dv;

		[MethodImport("glProgramUniformMatrix3dv")]
		private static ProgramUniformMatrix3dvDelegate glProgramUniformMatrix3dv;

		[MethodImport("glProgramUniformMatrix4dv")]
		private static ProgramUniformMatrix4dvDelegate glProgramUniformMatrix4dv;

		[MethodImport("glProgramUniformMatrix2x3fv")]
		private static ProgramUniformMatrix2x3fvDelegate glProgramUniformMatrix2x3fv;

		[MethodImport("glProgramUniformMatrix3x2fv")]
		private static ProgramUniformMatrix3x2fvDelegate glProgramUniformMatrix3x2fv;

		[MethodImport("glProgramUniformMatrix2x4fv")]
		private static ProgramUniformMatrix2x4fvDelegate glProgramUniformMatrix2x4fv;

		[MethodImport("glProgramUniformMatrix4x2fv")]
		private static ProgramUniformMatrix4x2fvDelegate glProgramUniformMatrix4x2fv;

		[MethodImport("glProgramUniformMatrix3x4fv")]
		private static ProgramUniformMatrix3x4fvDelegate glProgramUniformMatrix3x4fv;

		[MethodImport("glProgramUniformMatrix4x3fv")]
		private static ProgramUniformMatrix4x3fvDelegate glProgramUniformMatrix4x3fv;

		[MethodImport("glProgramUniformMatrix2x3dv")]
		private static ProgramUniformMatrix2x3dvDelegate glProgramUniformMatrix2x3dv;

		[MethodImport("glProgramUniformMatrix3x2dv")]
		private static ProgramUniformMatrix3x2dvDelegate glProgramUniformMatrix3x2dv;

		[MethodImport("glProgramUniformMatrix2x4dv")]
		private static ProgramUniformMatrix2x4dvDelegate glProgramUniformMatrix2x4dv;

		[MethodImport("glProgramUniformMatrix4x2dv")]
		private static ProgramUniformMatrix4x2dvDelegate glProgramUniformMatrix4x2dv;

		[MethodImport("glProgramUniformMatrix3x4dv")]
		private static ProgramUniformMatrix3x4dvDelegate glProgramUniformMatrix3x4dv;

		[MethodImport("glProgramUniformMatrix4x3dv")]
		private static ProgramUniformMatrix4x3dvDelegate glProgramUniformMatrix4x3dv;

		[MethodImport("glValidateProgramPipeline")]
		private static ValidateProgramPipelineDelegate glValidateProgramPipeline;

		[MethodImport("glGetProgramPipelineInfoLog")]
		private static GetProgramPipelineInfoLogDelegate glGetProgramPipelineInfoLog;

		[MethodImport("glVertexAttribL1d")]
		private static VertexAttribL1dDelegate glVertexAttribL1d;

		[MethodImport("glVertexAttribL2d")]
		private static VertexAttribL2dDelegate glVertexAttribL2d;

		[MethodImport("glVertexAttribL3d")]
		private static VertexAttribL3dDelegate glVertexAttribL3d;

		[MethodImport("glVertexAttribL4d")]
		private static VertexAttribL4dDelegate glVertexAttribL4d;

		[MethodImport("glVertexAttribL1dv")]
		private static VertexAttribL1dvDelegate glVertexAttribL1dv;

		[MethodImport("glVertexAttribL2dv")]
		private static VertexAttribL2dvDelegate glVertexAttribL2dv;

		[MethodImport("glVertexAttribL3dv")]
		private static VertexAttribL3dvDelegate glVertexAttribL3dv;

		[MethodImport("glVertexAttribL4dv")]
		private static VertexAttribL4dvDelegate glVertexAttribL4dv;

		[MethodImport("glVertexAttribLPointer")]
		private static VertexAttribLPointerDelegate glVertexAttribLPointer;

		[MethodImport("glGetVertexAttribLdv")]
		private static GetVertexAttribLdvDelegate glGetVertexAttribLdv;

		[MethodImport("glViewportArrayv")]
		private static ViewportArrayvDelegate glViewportArrayv;

		[MethodImport("glViewportIndexedf")]
		private static ViewportIndexedfDelegate glViewportIndexedf;

		[MethodImport("glViewportIndexedfv")]
		private static ViewportIndexedfvDelegate glViewportIndexedfv;

		[MethodImport("glScissorArrayv")]
		private static ScissorArrayvDelegate glScissorArrayv;

		[MethodImport("glScissorIndexed")]
		private static ScissorIndexedDelegate glScissorIndexed;

		[MethodImport("glScissorIndexedv")]
		private static ScissorIndexedvDelegate glScissorIndexedv;

		[MethodImport("glDepthRangeArrayv")]
		private static DepthRangeArrayvDelegate glDepthRangeArrayv;

		[MethodImport("glDepthRangeIndexed")]
		private static DepthRangeIndexedDelegate glDepthRangeIndexed;

		[MethodImport("glGetFloati_v")]
		private static GetFloati_vDelegate glGetFloati_v;

		[MethodImport("glGetDoublei_v")]
		private static GetDoublei_vDelegate glGetDoublei_v;
	}
}
