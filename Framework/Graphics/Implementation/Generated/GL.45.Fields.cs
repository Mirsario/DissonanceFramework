#pragma warning disable CS0649

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[MethodImport("glClipControl")]
		private static ClipControlDelegate glClipControl;
		
		[MethodImport("glCreateTransformFeedbacks")]
		private static CreateTransformFeedbacksDelegate glCreateTransformFeedbacks;
		
		[MethodImport("glTransformFeedbackBufferBase")]
		private static TransformFeedbackBufferBaseDelegate glTransformFeedbackBufferBase;
		
		[MethodImport("glTransformFeedbackBufferRange")]
		private static TransformFeedbackBufferRangeDelegate glTransformFeedbackBufferRange;
		
		[MethodImport("glGetTransformFeedbackiv")]
		private static GetTransformFeedbackivDelegate glGetTransformFeedbackiv;
		
		[MethodImport("glGetTransformFeedbacki_v")]
		private static GetTransformFeedbacki_vDelegate glGetTransformFeedbacki_v;
		
		[MethodImport("glGetTransformFeedbacki64_v")]
		private static GetTransformFeedbacki64_vDelegate glGetTransformFeedbacki64_v;
		
		[MethodImport("glCreateBuffers")]
		private static CreateBuffersDelegate glCreateBuffers;
		
		[MethodImport("glNamedBufferStorage")]
		private static NamedBufferStorageDelegate glNamedBufferStorage;
		
		[MethodImport("glNamedBufferData")]
		private static NamedBufferDataDelegate glNamedBufferData;
		
		[MethodImport("glNamedBufferSubData")]
		private static NamedBufferSubDataDelegate glNamedBufferSubData;
		
		[MethodImport("glCopyNamedBufferSubData")]
		private static CopyNamedBufferSubDataDelegate glCopyNamedBufferSubData;
		
		[MethodImport("glClearNamedBufferData")]
		private static ClearNamedBufferDataDelegate glClearNamedBufferData;
		
		[MethodImport("glClearNamedBufferSubData")]
		private static ClearNamedBufferSubDataDelegate glClearNamedBufferSubData;
		
		[MethodImport("glMapNamedBuffer")]
		private static MapNamedBufferDelegate glMapNamedBuffer;
		
		[MethodImport("glMapNamedBufferRange")]
		private static MapNamedBufferRangeDelegate glMapNamedBufferRange;
		
		[MethodImport("glUnmapNamedBuffer")]
		private static UnmapNamedBufferDelegate glUnmapNamedBuffer;
		
		[MethodImport("glFlushMappedNamedBufferRange")]
		private static FlushMappedNamedBufferRangeDelegate glFlushMappedNamedBufferRange;
		
		[MethodImport("glGetNamedBufferParameteriv")]
		private static GetNamedBufferParameterivDelegate glGetNamedBufferParameteriv;
		
		[MethodImport("glGetNamedBufferParameteri64v")]
		private static GetNamedBufferParameteri64vDelegate glGetNamedBufferParameteri64v;
		
		[MethodImport("glGetNamedBufferPointerv")]
		private static GetNamedBufferPointervDelegate glGetNamedBufferPointerv;
		
		[MethodImport("glGetNamedBufferSubData")]
		private static GetNamedBufferSubDataDelegate glGetNamedBufferSubData;
		
		[MethodImport("glCreateFramebuffers")]
		private static CreateFramebuffersDelegate glCreateFramebuffers;
		
		[MethodImport("glNamedFramebufferRenderbuffer")]
		private static NamedFramebufferRenderbufferDelegate glNamedFramebufferRenderbuffer;
		
		[MethodImport("glNamedFramebufferParameteri")]
		private static NamedFramebufferParameteriDelegate glNamedFramebufferParameteri;
		
		[MethodImport("glNamedFramebufferTexture")]
		private static NamedFramebufferTextureDelegate glNamedFramebufferTexture;
		
		[MethodImport("glNamedFramebufferTextureLayer")]
		private static NamedFramebufferTextureLayerDelegate glNamedFramebufferTextureLayer;
		
		[MethodImport("glNamedFramebufferDrawBuffer")]
		private static NamedFramebufferDrawBufferDelegate glNamedFramebufferDrawBuffer;
		
		[MethodImport("glNamedFramebufferDrawBuffers")]
		private static NamedFramebufferDrawBuffersDelegate glNamedFramebufferDrawBuffers;
		
		[MethodImport("glNamedFramebufferReadBuffer")]
		private static NamedFramebufferReadBufferDelegate glNamedFramebufferReadBuffer;
		
		[MethodImport("glInvalidateNamedFramebufferData")]
		private static InvalidateNamedFramebufferDataDelegate glInvalidateNamedFramebufferData;
		
		[MethodImport("glInvalidateNamedFramebufferSubData")]
		private static InvalidateNamedFramebufferSubDataDelegate glInvalidateNamedFramebufferSubData;
		
		[MethodImport("glClearNamedFramebufferiv")]
		private static ClearNamedFramebufferivDelegate glClearNamedFramebufferiv;
		
		[MethodImport("glClearNamedFramebufferuiv")]
		private static ClearNamedFramebufferuivDelegate glClearNamedFramebufferuiv;
		
		[MethodImport("glClearNamedFramebufferfv")]
		private static ClearNamedFramebufferfvDelegate glClearNamedFramebufferfv;
		
		[MethodImport("glClearNamedFramebufferfi")]
		private static ClearNamedFramebufferfiDelegate glClearNamedFramebufferfi;
		
		[MethodImport("glBlitNamedFramebuffer")]
		private static BlitNamedFramebufferDelegate glBlitNamedFramebuffer;
		
		[MethodImport("glCheckNamedFramebufferStatus")]
		private static CheckNamedFramebufferStatusDelegate glCheckNamedFramebufferStatus;
		
		[MethodImport("glGetNamedFramebufferParameteriv")]
		private static GetNamedFramebufferParameterivDelegate glGetNamedFramebufferParameteriv;
		
		[MethodImport("glGetNamedFramebufferAttachmentParameteriv")]
		private static GetNamedFramebufferAttachmentParameterivDelegate glGetNamedFramebufferAttachmentParameteriv;
		
		[MethodImport("glCreateRenderbuffers")]
		private static CreateRenderbuffersDelegate glCreateRenderbuffers;
		
		[MethodImport("glNamedRenderbufferStorage")]
		private static NamedRenderbufferStorageDelegate glNamedRenderbufferStorage;
		
		[MethodImport("glNamedRenderbufferStorageMultisample")]
		private static NamedRenderbufferStorageMultisampleDelegate glNamedRenderbufferStorageMultisample;
		
		[MethodImport("glGetNamedRenderbufferParameteriv")]
		private static GetNamedRenderbufferParameterivDelegate glGetNamedRenderbufferParameteriv;
		
		[MethodImport("glCreateTextures")]
		private static CreateTexturesDelegate glCreateTextures;
		
		[MethodImport("glTextureBuffer")]
		private static TextureBufferDelegate glTextureBuffer;
		
		[MethodImport("glTextureBufferRange")]
		private static TextureBufferRangeDelegate glTextureBufferRange;
		
		[MethodImport("glTextureStorage1D")]
		private static TextureStorage1DDelegate glTextureStorage1D;
		
		[MethodImport("glTextureStorage2D")]
		private static TextureStorage2DDelegate glTextureStorage2D;
		
		[MethodImport("glTextureStorage3D")]
		private static TextureStorage3DDelegate glTextureStorage3D;
		
		[MethodImport("glTextureStorage2DMultisample")]
		private static TextureStorage2DMultisampleDelegate glTextureStorage2DMultisample;
		
		[MethodImport("glTextureStorage3DMultisample")]
		private static TextureStorage3DMultisampleDelegate glTextureStorage3DMultisample;
		
		[MethodImport("glTextureSubImage1D")]
		private static TextureSubImage1DDelegate glTextureSubImage1D;
		
		[MethodImport("glTextureSubImage2D")]
		private static TextureSubImage2DDelegate glTextureSubImage2D;
		
		[MethodImport("glTextureSubImage3D")]
		private static TextureSubImage3DDelegate glTextureSubImage3D;
		
		[MethodImport("glCompressedTextureSubImage1D")]
		private static CompressedTextureSubImage1DDelegate glCompressedTextureSubImage1D;
		
		[MethodImport("glCompressedTextureSubImage2D")]
		private static CompressedTextureSubImage2DDelegate glCompressedTextureSubImage2D;
		
		[MethodImport("glCompressedTextureSubImage3D")]
		private static CompressedTextureSubImage3DDelegate glCompressedTextureSubImage3D;
		
		[MethodImport("glCopyTextureSubImage1D")]
		private static CopyTextureSubImage1DDelegate glCopyTextureSubImage1D;
		
		[MethodImport("glCopyTextureSubImage2D")]
		private static CopyTextureSubImage2DDelegate glCopyTextureSubImage2D;
		
		[MethodImport("glCopyTextureSubImage3D")]
		private static CopyTextureSubImage3DDelegate glCopyTextureSubImage3D;
		
		[MethodImport("glTextureParameterf")]
		private static TextureParameterfDelegate glTextureParameterf;
		
		[MethodImport("glTextureParameterfv")]
		private static TextureParameterfvDelegate glTextureParameterfv;
		
		[MethodImport("glTextureParameteri")]
		private static TextureParameteriDelegate glTextureParameteri;
		
		[MethodImport("glTextureParameterIiv")]
		private static TextureParameterIivDelegate glTextureParameterIiv;
		
		[MethodImport("glTextureParameterIuiv")]
		private static TextureParameterIuivDelegate glTextureParameterIuiv;
		
		[MethodImport("glTextureParameteriv")]
		private static TextureParameterivDelegate glTextureParameteriv;
		
		[MethodImport("glGenerateTextureMipmap")]
		private static GenerateTextureMipmapDelegate glGenerateTextureMipmap;
		
		[MethodImport("glBindTextureUnit")]
		private static BindTextureUnitDelegate glBindTextureUnit;
		
		[MethodImport("glGetTextureImage")]
		private static GetTextureImageDelegate glGetTextureImage;
		
		[MethodImport("glGetCompressedTextureImage")]
		private static GetCompressedTextureImageDelegate glGetCompressedTextureImage;
		
		[MethodImport("glGetTextureLevelParameterfv")]
		private static GetTextureLevelParameterfvDelegate glGetTextureLevelParameterfv;
		
		[MethodImport("glGetTextureLevelParameteriv")]
		private static GetTextureLevelParameterivDelegate glGetTextureLevelParameteriv;
		
		[MethodImport("glGetTextureParameterfv")]
		private static GetTextureParameterfvDelegate glGetTextureParameterfv;
		
		[MethodImport("glGetTextureParameterIiv")]
		private static GetTextureParameterIivDelegate glGetTextureParameterIiv;
		
		[MethodImport("glGetTextureParameterIuiv")]
		private static GetTextureParameterIuivDelegate glGetTextureParameterIuiv;
		
		[MethodImport("glGetTextureParameteriv")]
		private static GetTextureParameterivDelegate glGetTextureParameteriv;
		
		[MethodImport("glCreateVertexArrays")]
		private static CreateVertexArraysDelegate glCreateVertexArrays;
		
		[MethodImport("glDisableVertexArrayAttrib")]
		private static DisableVertexArrayAttribDelegate glDisableVertexArrayAttrib;
		
		[MethodImport("glEnableVertexArrayAttrib")]
		private static EnableVertexArrayAttribDelegate glEnableVertexArrayAttrib;
		
		[MethodImport("glVertexArrayElementBuffer")]
		private static VertexArrayElementBufferDelegate glVertexArrayElementBuffer;
		
		[MethodImport("glVertexArrayVertexBuffer")]
		private static VertexArrayVertexBufferDelegate glVertexArrayVertexBuffer;
		
		[MethodImport("glVertexArrayVertexBuffers")]
		private static VertexArrayVertexBuffersDelegate glVertexArrayVertexBuffers;
		
		[MethodImport("glVertexArrayAttribBinding")]
		private static VertexArrayAttribBindingDelegate glVertexArrayAttribBinding;
		
		[MethodImport("glVertexArrayAttribFormat")]
		private static VertexArrayAttribFormatDelegate glVertexArrayAttribFormat;
		
		[MethodImport("glVertexArrayAttribIFormat")]
		private static VertexArrayAttribIFormatDelegate glVertexArrayAttribIFormat;
		
		[MethodImport("glVertexArrayAttribLFormat")]
		private static VertexArrayAttribLFormatDelegate glVertexArrayAttribLFormat;
		
		[MethodImport("glVertexArrayBindingDivisor")]
		private static VertexArrayBindingDivisorDelegate glVertexArrayBindingDivisor;
		
		[MethodImport("glGetVertexArrayiv")]
		private static GetVertexArrayivDelegate glGetVertexArrayiv;
		
		[MethodImport("glGetVertexArrayIndexediv")]
		private static GetVertexArrayIndexedivDelegate glGetVertexArrayIndexediv;
		
		[MethodImport("glGetVertexArrayIndexed64iv")]
		private static GetVertexArrayIndexed64ivDelegate glGetVertexArrayIndexed64iv;
		
		[MethodImport("glCreateSamplers")]
		private static CreateSamplersDelegate glCreateSamplers;
		
		[MethodImport("glCreateProgramPipelines")]
		private static CreateProgramPipelinesDelegate glCreateProgramPipelines;
		
		[MethodImport("glCreateQueries")]
		private static CreateQueriesDelegate glCreateQueries;
		
		[MethodImport("glGetQueryBufferObjecti64v")]
		private static GetQueryBufferObjecti64vDelegate glGetQueryBufferObjecti64v;
		
		[MethodImport("glGetQueryBufferObjectiv")]
		private static GetQueryBufferObjectivDelegate glGetQueryBufferObjectiv;
		
		[MethodImport("glGetQueryBufferObjectui64v")]
		private static GetQueryBufferObjectui64vDelegate glGetQueryBufferObjectui64v;
		
		[MethodImport("glGetQueryBufferObjectuiv")]
		private static GetQueryBufferObjectuivDelegate glGetQueryBufferObjectuiv;
		
		[MethodImport("glMemoryBarrierByRegion")]
		private static MemoryBarrierByRegionDelegate glMemoryBarrierByRegion;
		
		[MethodImport("glGetTextureSubImage")]
		private static GetTextureSubImageDelegate glGetTextureSubImage;
		
		[MethodImport("glGetCompressedTextureSubImage")]
		private static GetCompressedTextureSubImageDelegate glGetCompressedTextureSubImage;
		
		[MethodImport("glGetGraphicsResetStatus")]
		private static GetGraphicsResetStatusDelegate glGetGraphicsResetStatus;
		
		[MethodImport("glGetnCompressedTexImage")]
		private static GetnCompressedTexImageDelegate glGetnCompressedTexImage;
		
		[MethodImport("glGetnTexImage")]
		private static GetnTexImageDelegate glGetnTexImage;
		
		[MethodImport("glGetnUniformdv")]
		private static GetnUniformdvDelegate glGetnUniformdv;
		
		[MethodImport("glGetnUniformfv")]
		private static GetnUniformfvDelegate glGetnUniformfv;
		
		[MethodImport("glGetnUniformiv")]
		private static GetnUniformivDelegate glGetnUniformiv;
		
		[MethodImport("glGetnUniformuiv")]
		private static GetnUniformuivDelegate glGetnUniformuiv;
		
		[MethodImport("glReadnPixels")]
		private static ReadnPixelsDelegate glReadnPixels;
		
		[MethodImport("glTextureBarrier")]
		private static TextureBarrierDelegate glTextureBarrier;
	}
}
