#pragma warning disable CS0649

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[MethodImport("glColorMaski")]
		private static ColorMaskiDelegate glColorMaski;

		[MethodImport("glGetBooleani_v")]
		private static GetBooleani_vDelegate glGetBooleani_v;

		[MethodImport("glGetIntegeri_v")]
		private static GetIntegeri_vDelegate glGetIntegeri_v;

		[MethodImport("glGetStringi")]
		private static GetStringiDelegate glGetStringi;

		[MethodImport("glEnablei")]
		private static EnableiDelegate glEnablei;

		[MethodImport("glDisablei")]
		private static DisableiDelegate glDisablei;

		[MethodImport("glIsEnabledi")]
		private static IsEnablediDelegate glIsEnabledi;

		[MethodImport("glBeginTransformFeedback")]
		private static BeginTransformFeedbackDelegate glBeginTransformFeedback;

		[MethodImport("glEndTransformFeedback")]
		private static EndTransformFeedbackDelegate glEndTransformFeedback;

		[MethodImport("glBindBufferRange")]
		private static BindBufferRangeDelegate glBindBufferRange;

		[MethodImport("glBindBufferBase")]
		private static BindBufferBaseDelegate glBindBufferBase;

		[MethodImport("glTransformFeedbackVaryings")]
		private static TransformFeedbackVaryingsDelegate glTransformFeedbackVaryings;

		[MethodImport("glGetTransformFeedbackVarying")]
		private static GetTransformFeedbackVaryingDelegate glGetTransformFeedbackVarying;

		[MethodImport("glClampColor")]
		private static ClampColorDelegate glClampColor;

		[MethodImport("glBeginConditionalRender")]
		private static BeginConditionalRenderDelegate glBeginConditionalRender;

		[MethodImport("glEndConditionalRender")]
		private static EndConditionalRenderDelegate glEndConditionalRender;

		[MethodImport("glVertexAttribIPointer")]
		private static VertexAttribIPointerDelegate glVertexAttribIPointer;

		[MethodImport("glGetVertexAttribIiv")]
		private static GetVertexAttribIivDelegate glGetVertexAttribIiv;

		[MethodImport("glGetVertexAttribIuiv")]
		private static GetVertexAttribIuivDelegate glGetVertexAttribIuiv;

		[MethodImport("glVertexAttribI1i")]
		private static VertexAttribI1iDelegate glVertexAttribI1i;

		[MethodImport("glVertexAttribI2i")]
		private static VertexAttribI2iDelegate glVertexAttribI2i;

		[MethodImport("glVertexAttribI3i")]
		private static VertexAttribI3iDelegate glVertexAttribI3i;

		[MethodImport("glVertexAttribI4i")]
		private static VertexAttribI4iDelegate glVertexAttribI4i;

		[MethodImport("glVertexAttribI1ui")]
		private static VertexAttribI1uiDelegate glVertexAttribI1ui;

		[MethodImport("glVertexAttribI2ui")]
		private static VertexAttribI2uiDelegate glVertexAttribI2ui;

		[MethodImport("glVertexAttribI3ui")]
		private static VertexAttribI3uiDelegate glVertexAttribI3ui;

		[MethodImport("glVertexAttribI4ui")]
		private static VertexAttribI4uiDelegate glVertexAttribI4ui;

		[MethodImport("glVertexAttribI1iv")]
		private static VertexAttribI1ivDelegate glVertexAttribI1iv;

		[MethodImport("glVertexAttribI2iv")]
		private static VertexAttribI2ivDelegate glVertexAttribI2iv;

		[MethodImport("glVertexAttribI3iv")]
		private static VertexAttribI3ivDelegate glVertexAttribI3iv;

		[MethodImport("glVertexAttribI4iv")]
		private static VertexAttribI4ivDelegate glVertexAttribI4iv;

		[MethodImport("glVertexAttribI1uiv")]
		private static VertexAttribI1uivDelegate glVertexAttribI1uiv;

		[MethodImport("glVertexAttribI2uiv")]
		private static VertexAttribI2uivDelegate glVertexAttribI2uiv;

		[MethodImport("glVertexAttribI3uiv")]
		private static VertexAttribI3uivDelegate glVertexAttribI3uiv;

		[MethodImport("glVertexAttribI4uiv")]
		private static VertexAttribI4uivDelegate glVertexAttribI4uiv;

		[MethodImport("glVertexAttribI4bv")]
		private static VertexAttribI4bvDelegate glVertexAttribI4bv;

		[MethodImport("glVertexAttribI4sv")]
		private static VertexAttribI4svDelegate glVertexAttribI4sv;

		[MethodImport("glVertexAttribI4ubv")]
		private static VertexAttribI4ubvDelegate glVertexAttribI4ubv;

		[MethodImport("glVertexAttribI4usv")]
		private static VertexAttribI4usvDelegate glVertexAttribI4usv;

		[MethodImport("glGetUniformuiv")]
		private static GetUniformuivDelegate glGetUniformuiv;

		[MethodImport("glBindFragDataLocation")]
		private static BindFragDataLocationDelegate glBindFragDataLocation;

		[MethodImport("glGetFragDataLocation")]
		private static GetFragDataLocationDelegate glGetFragDataLocation;

		[MethodImport("glUniform1ui")]
		private static Uniform1uiDelegate glUniform1ui;

		[MethodImport("glUniform2ui")]
		private static Uniform2uiDelegate glUniform2ui;

		[MethodImport("glUniform3ui")]
		private static Uniform3uiDelegate glUniform3ui;

		[MethodImport("glUniform4ui")]
		private static Uniform4uiDelegate glUniform4ui;

		[MethodImport("glUniform1uiv")]
		private static Uniform1uivDelegate glUniform1uiv;

		[MethodImport("glUniform2uiv")]
		private static Uniform2uivDelegate glUniform2uiv;

		[MethodImport("glUniform3uiv")]
		private static Uniform3uivDelegate glUniform3uiv;

		[MethodImport("glUniform4uiv")]
		private static Uniform4uivDelegate glUniform4uiv;

		[MethodImport("glTexParameterIiv")]
		private static TexParameterIivDelegate glTexParameterIiv;

		[MethodImport("glTexParameterIuiv")]
		private static TexParameterIuivDelegate glTexParameterIuiv;

		[MethodImport("glGetTexParameterIiv")]
		private static GetTexParameterIivDelegate glGetTexParameterIiv;

		[MethodImport("glGetTexParameterIuiv")]
		private static GetTexParameterIuivDelegate glGetTexParameterIuiv;

		[MethodImport("glClearBufferiv")]
		private static ClearBufferivDelegate glClearBufferiv;

		[MethodImport("glClearBufferuiv")]
		private static ClearBufferuivDelegate glClearBufferuiv;

		[MethodImport("glClearBufferfv")]
		private static ClearBufferfvDelegate glClearBufferfv;

		[MethodImport("glClearBufferfi")]
		private static ClearBufferfiDelegate glClearBufferfi;

		[MethodImport("glIsRenderbuffer")]
		private static IsRenderbufferDelegate glIsRenderbuffer;

		[MethodImport("glBindRenderbuffer")]
		private static BindRenderbufferDelegate glBindRenderbuffer;

		[MethodImport("glDeleteRenderbuffers")]
		private static DeleteRenderbuffersDelegate glDeleteRenderbuffers;

		[MethodImport("glGenRenderbuffers")]
		private static GenRenderbuffersDelegate glGenRenderbuffers;

		[MethodImport("glRenderbufferStorage")]
		private static RenderbufferStorageDelegate glRenderbufferStorage;

		[MethodImport("glGetRenderbufferParameteriv")]
		private static GetRenderbufferParameterivDelegate glGetRenderbufferParameteriv;

		[MethodImport("glIsFramebuffer")]
		private static IsFramebufferDelegate glIsFramebuffer;

		[MethodImport("glBindFramebuffer")]
		private static BindFramebufferDelegate glBindFramebuffer;

		[MethodImport("glDeleteFramebuffers")]
		private static DeleteFramebuffersDelegate glDeleteFramebuffers;

		[MethodImport("glGenFramebuffers")]
		private static GenFramebuffersDelegate glGenFramebuffers;

		[MethodImport("glCheckFramebufferStatus")]
		private static CheckFramebufferStatusDelegate glCheckFramebufferStatus;

		[MethodImport("glFramebufferTexture1D")]
		private static FramebufferTexture1DDelegate glFramebufferTexture1D;

		[MethodImport("glFramebufferTexture2D")]
		private static FramebufferTexture2DDelegate glFramebufferTexture2D;

		[MethodImport("glFramebufferTexture3D")]
		private static FramebufferTexture3DDelegate glFramebufferTexture3D;

		[MethodImport("glFramebufferRenderbuffer")]
		private static FramebufferRenderbufferDelegate glFramebufferRenderbuffer;

		[MethodImport("glGetFramebufferAttachmentParameteriv")]
		private static GetFramebufferAttachmentParameterivDelegate glGetFramebufferAttachmentParameteriv;

		[MethodImport("glGenerateMipmap")]
		private static GenerateMipmapDelegate glGenerateMipmap;

		[MethodImport("glBlitFramebuffer")]
		private static BlitFramebufferDelegate glBlitFramebuffer;

		[MethodImport("glRenderbufferStorageMultisample")]
		private static RenderbufferStorageMultisampleDelegate glRenderbufferStorageMultisample;

		[MethodImport("glFramebufferTextureLayer")]
		private static FramebufferTextureLayerDelegate glFramebufferTextureLayer;

		[MethodImport("glMapBufferRange")]
		private static MapBufferRangeDelegate glMapBufferRange;

		[MethodImport("glFlushMappedBufferRange")]
		private static FlushMappedBufferRangeDelegate glFlushMappedBufferRange;

		[MethodImport("glBindVertexArray")]
		private static BindVertexArrayDelegate glBindVertexArray;

		[MethodImport("glDeleteVertexArrays")]
		private static DeleteVertexArraysDelegate glDeleteVertexArrays;

		[MethodImport("glGenVertexArrays")]
		private static GenVertexArraysDelegate glGenVertexArrays;

		[MethodImport("glIsVertexArray")]
		private static IsVertexArrayDelegate glIsVertexArray;
	}
}
