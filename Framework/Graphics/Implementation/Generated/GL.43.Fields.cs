#pragma warning disable CS0649

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[MethodImport("glClearBufferData")]
		private static ClearBufferDataDelegate glClearBufferData;
		
		[MethodImport("glClearBufferSubData")]
		private static ClearBufferSubDataDelegate glClearBufferSubData;
		
		[MethodImport("glDispatchCompute")]
		private static DispatchComputeDelegate glDispatchCompute;
		
		[MethodImport("glDispatchComputeIndirect")]
		private static DispatchComputeIndirectDelegate glDispatchComputeIndirect;
		
		[MethodImport("glCopyImageSubData")]
		private static CopyImageSubDataDelegate glCopyImageSubData;
		
		[MethodImport("glFramebufferParameteri")]
		private static FramebufferParameteriDelegate glFramebufferParameteri;
		
		[MethodImport("glGetFramebufferParameteriv")]
		private static GetFramebufferParameterivDelegate glGetFramebufferParameteriv;
		
		[MethodImport("glGetInternalformati64v")]
		private static GetInternalformati64vDelegate glGetInternalformati64v;
		
		[MethodImport("glInvalidateTexSubImage")]
		private static InvalidateTexSubImageDelegate glInvalidateTexSubImage;
		
		[MethodImport("glInvalidateTexImage")]
		private static InvalidateTexImageDelegate glInvalidateTexImage;
		
		[MethodImport("glInvalidateBufferSubData")]
		private static InvalidateBufferSubDataDelegate glInvalidateBufferSubData;
		
		[MethodImport("glInvalidateBufferData")]
		private static InvalidateBufferDataDelegate glInvalidateBufferData;
		
		[MethodImport("glInvalidateFramebuffer")]
		private static InvalidateFramebufferDelegate glInvalidateFramebuffer;
		
		[MethodImport("glInvalidateSubFramebuffer")]
		private static InvalidateSubFramebufferDelegate glInvalidateSubFramebuffer;
		
		[MethodImport("glMultiDrawArraysIndirect")]
		private static MultiDrawArraysIndirectDelegate glMultiDrawArraysIndirect;
		
		[MethodImport("glMultiDrawElementsIndirect")]
		private static MultiDrawElementsIndirectDelegate glMultiDrawElementsIndirect;
		
		[MethodImport("glGetProgramInterfaceiv")]
		private static GetProgramInterfaceivDelegate glGetProgramInterfaceiv;
		
		[MethodImport("glGetProgramResourceIndex")]
		private static GetProgramResourceIndexDelegate glGetProgramResourceIndex;
		
		[MethodImport("glGetProgramResourceName")]
		private static GetProgramResourceNameDelegate glGetProgramResourceName;
		
		[MethodImport("glGetProgramResourceiv")]
		private static GetProgramResourceivDelegate glGetProgramResourceiv;
		
		[MethodImport("glGetProgramResourceLocation")]
		private static GetProgramResourceLocationDelegate glGetProgramResourceLocation;
		
		[MethodImport("glGetProgramResourceLocationIndex")]
		private static GetProgramResourceLocationIndexDelegate glGetProgramResourceLocationIndex;
		
		[MethodImport("glShaderStorageBlockBinding")]
		private static ShaderStorageBlockBindingDelegate glShaderStorageBlockBinding;
		
		[MethodImport("glTexBufferRange")]
		private static TexBufferRangeDelegate glTexBufferRange;
		
		[MethodImport("glTexStorage2DMultisample")]
		private static TexStorage2DMultisampleDelegate glTexStorage2DMultisample;
		
		[MethodImport("glTexStorage3DMultisample")]
		private static TexStorage3DMultisampleDelegate glTexStorage3DMultisample;
		
		[MethodImport("glTextureView")]
		private static TextureViewDelegate glTextureView;
		
		[MethodImport("glBindVertexBuffer")]
		private static BindVertexBufferDelegate glBindVertexBuffer;
		
		[MethodImport("glVertexAttribFormat")]
		private static VertexAttribFormatDelegate glVertexAttribFormat;
		
		[MethodImport("glVertexAttribIFormat")]
		private static VertexAttribIFormatDelegate glVertexAttribIFormat;
		
		[MethodImport("glVertexAttribLFormat")]
		private static VertexAttribLFormatDelegate glVertexAttribLFormat;
		
		[MethodImport("glVertexAttribBinding")]
		private static VertexAttribBindingDelegate glVertexAttribBinding;
		
		[MethodImport("glVertexBindingDivisor")]
		private static VertexBindingDivisorDelegate glVertexBindingDivisor;
		
		[MethodImport("glDebugMessageControl")]
		private static DebugMessageControlDelegate glDebugMessageControl;
		
		[MethodImport("glDebugMessageInsert")]
		private static DebugMessageInsertDelegate glDebugMessageInsert;
		
		[MethodImport("glDebugMessageCallback")]
		private static DebugMessageCallbackDelegate glDebugMessageCallback;
		
		[MethodImport("glGetDebugMessageLog")]
		private static GetDebugMessageLogDelegate glGetDebugMessageLog;
		
		[MethodImport("glPushDebugGroup")]
		private static PushDebugGroupDelegate glPushDebugGroup;
		
		[MethodImport("glPopDebugGroup")]
		private static PopDebugGroupDelegate glPopDebugGroup;
		
		[MethodImport("glObjectLabel")]
		private static ObjectLabelDelegate glObjectLabel;
		
		[MethodImport("glGetObjectLabel")]
		private static GetObjectLabelDelegate glGetObjectLabel;
		
		[MethodImport("glObjectPtrLabel")]
		private static ObjectPtrLabelDelegate glObjectPtrLabel;
		
		[MethodImport("glGetObjectPtrLabel")]
		private static GetObjectPtrLabelDelegate glGetObjectPtrLabel;
	}
}
