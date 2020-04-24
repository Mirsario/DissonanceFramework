#pragma warning disable CS0649

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[MethodImport("glMinSampleShading")]
		private static MinSampleShadingDelegate glMinSampleShading;
		
		[MethodImport("glBlendEquationi")]
		private static BlendEquationiDelegate glBlendEquationi;
		
		[MethodImport("glBlendEquationSeparatei")]
		private static BlendEquationSeparateiDelegate glBlendEquationSeparatei;
		
		[MethodImport("glBlendFunci")]
		private static BlendFunciDelegate glBlendFunci;
		
		[MethodImport("glBlendFuncSeparatei")]
		private static BlendFuncSeparateiDelegate glBlendFuncSeparatei;
		
		[MethodImport("glDrawArraysIndirect")]
		private static DrawArraysIndirectDelegate glDrawArraysIndirect;
		
		[MethodImport("glDrawElementsIndirect")]
		private static DrawElementsIndirectDelegate glDrawElementsIndirect;
		
		[MethodImport("glUniform1d")]
		private static Uniform1dDelegate glUniform1d;
		
		[MethodImport("glUniform2d")]
		private static Uniform2dDelegate glUniform2d;
		
		[MethodImport("glUniform3d")]
		private static Uniform3dDelegate glUniform3d;
		
		[MethodImport("glUniform4d")]
		private static Uniform4dDelegate glUniform4d;
		
		[MethodImport("glUniform1dv")]
		private static Uniform1dvDelegate glUniform1dv;
		
		[MethodImport("glUniform2dv")]
		private static Uniform2dvDelegate glUniform2dv;
		
		[MethodImport("glUniform3dv")]
		private static Uniform3dvDelegate glUniform3dv;
		
		[MethodImport("glUniform4dv")]
		private static Uniform4dvDelegate glUniform4dv;
		
		[MethodImport("glUniformMatrix2dv")]
		private static UniformMatrix2dvDelegate glUniformMatrix2dv;
		
		[MethodImport("glUniformMatrix3dv")]
		private static UniformMatrix3dvDelegate glUniformMatrix3dv;
		
		[MethodImport("glUniformMatrix4dv")]
		private static UniformMatrix4dvDelegate glUniformMatrix4dv;
		
		[MethodImport("glUniformMatrix2x3dv")]
		private static UniformMatrix2x3dvDelegate glUniformMatrix2x3dv;
		
		[MethodImport("glUniformMatrix2x4dv")]
		private static UniformMatrix2x4dvDelegate glUniformMatrix2x4dv;
		
		[MethodImport("glUniformMatrix3x2dv")]
		private static UniformMatrix3x2dvDelegate glUniformMatrix3x2dv;
		
		[MethodImport("glUniformMatrix3x4dv")]
		private static UniformMatrix3x4dvDelegate glUniformMatrix3x4dv;
		
		[MethodImport("glUniformMatrix4x2dv")]
		private static UniformMatrix4x2dvDelegate glUniformMatrix4x2dv;
		
		[MethodImport("glUniformMatrix4x3dv")]
		private static UniformMatrix4x3dvDelegate glUniformMatrix4x3dv;
		
		[MethodImport("glGetUniformdv")]
		private static GetUniformdvDelegate glGetUniformdv;
		
		[MethodImport("glGetSubroutineUniformLocation")]
		private static GetSubroutineUniformLocationDelegate glGetSubroutineUniformLocation;
		
		[MethodImport("glGetSubroutineIndex")]
		private static GetSubroutineIndexDelegate glGetSubroutineIndex;
		
		[MethodImport("glGetActiveSubroutineUniformiv")]
		private static GetActiveSubroutineUniformivDelegate glGetActiveSubroutineUniformiv;
		
		[MethodImport("glGetActiveSubroutineUniformName")]
		private static GetActiveSubroutineUniformNameDelegate glGetActiveSubroutineUniformName;
		
		[MethodImport("glGetActiveSubroutineName")]
		private static GetActiveSubroutineNameDelegate glGetActiveSubroutineName;
		
		[MethodImport("glUniformSubroutinesuiv")]
		private static UniformSubroutinesuivDelegate glUniformSubroutinesuiv;
		
		[MethodImport("glGetUniformSubroutineuiv")]
		private static GetUniformSubroutineuivDelegate glGetUniformSubroutineuiv;
		
		[MethodImport("glGetProgramStageiv")]
		private static GetProgramStageivDelegate glGetProgramStageiv;
		
		[MethodImport("glPatchParameteri")]
		private static PatchParameteriDelegate glPatchParameteri;
		
		[MethodImport("glPatchParameterfv")]
		private static PatchParameterfvDelegate glPatchParameterfv;
		
		[MethodImport("glBindTransformFeedback")]
		private static BindTransformFeedbackDelegate glBindTransformFeedback;
		
		[MethodImport("glDeleteTransformFeedbacks")]
		private static DeleteTransformFeedbacksDelegate glDeleteTransformFeedbacks;
		
		[MethodImport("glGenTransformFeedbacks")]
		private static GenTransformFeedbacksDelegate glGenTransformFeedbacks;
		
		[MethodImport("glIsTransformFeedback")]
		private static IsTransformFeedbackDelegate glIsTransformFeedback;
		
		[MethodImport("glPauseTransformFeedback")]
		private static PauseTransformFeedbackDelegate glPauseTransformFeedback;
		
		[MethodImport("glResumeTransformFeedback")]
		private static ResumeTransformFeedbackDelegate glResumeTransformFeedback;
		
		[MethodImport("glDrawTransformFeedback")]
		private static DrawTransformFeedbackDelegate glDrawTransformFeedback;
		
		[MethodImport("glDrawTransformFeedbackStream")]
		private static DrawTransformFeedbackStreamDelegate glDrawTransformFeedbackStream;
		
		[MethodImport("glBeginQueryIndexed")]
		private static BeginQueryIndexedDelegate glBeginQueryIndexed;
		
		[MethodImport("glEndQueryIndexed")]
		private static EndQueryIndexedDelegate glEndQueryIndexed;
		
		[MethodImport("glGetQueryIndexediv")]
		private static GetQueryIndexedivDelegate glGetQueryIndexediv;
	}
}
