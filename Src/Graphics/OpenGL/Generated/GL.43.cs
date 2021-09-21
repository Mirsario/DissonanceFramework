using System;

namespace Dissonance.Framework.Graphics.OpenGL
{
	unsafe partial class GL
	{
		[MethodImport("glClearBufferData", "4.3")]
		private static delegate*<BufferStorageTarget, SizedInternalFormat, PixelFormat, PixelType, void*, void> glClearBufferData;
		
		public static void ClearBufferData(BufferStorageTarget target, SizedInternalFormat internalformat, PixelFormat format, PixelType type, void* data)
		{
			glClearBufferData(target, internalformat, format, type, data);
		}
		
		[MethodImport("glClearBufferSubData", "4.3")]
		private static delegate*<BufferTargetARB, SizedInternalFormat, IntPtr, IntPtr, PixelFormat, PixelType, void*, void> glClearBufferSubData;
		
		public static void ClearBufferSubData(BufferTargetARB target, SizedInternalFormat internalformat, IntPtr offset, IntPtr size, PixelFormat format, PixelType type, void* data)
		{
			glClearBufferSubData(target, internalformat, offset, size, format, type, data);
		}
		
		[MethodImport("glDispatchCompute", "4.3")]
		private static delegate*<uint, uint, uint, void> glDispatchCompute;
		
		public static void DispatchCompute(uint num_groups_x, uint num_groups_y, uint num_groups_z)
		{
			glDispatchCompute(num_groups_x, num_groups_y, num_groups_z);
		}
		
		[MethodImport("glDispatchComputeIndirect", "4.3")]
		private static delegate*<IntPtr, void> glDispatchComputeIndirect;
		
		public static void DispatchComputeIndirect(IntPtr indirect)
		{
			glDispatchComputeIndirect(indirect);
		}
		
		[MethodImport("glCopyImageSubData", "4.3")]
		private static delegate*<uint, CopyImageSubDataTarget, int, int, int, int, uint, CopyImageSubDataTarget, int, int, int, int, int, int, int, void> glCopyImageSubData;
		
		public static void CopyImageSubData(uint srcName, CopyImageSubDataTarget srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, CopyImageSubDataTarget dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth)
		{
			glCopyImageSubData(srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
		}
		
		[MethodImport("glFramebufferParameteri", "4.3")]
		private static delegate*<FramebufferTarget, FramebufferParameterName, int, void> glFramebufferParameteri;
		
		public static void FramebufferParameteri(FramebufferTarget target, FramebufferParameterName pname, int param)
		{
			glFramebufferParameteri(target, pname, param);
		}
		
		[MethodImport("glGetFramebufferParameteriv", "4.3")]
		private static delegate*<FramebufferTarget, FramebufferAttachmentParameterName, int*, void> glGetFramebufferParameteriv;
		
		public static void GetFramebufferParameteriv(FramebufferTarget target, FramebufferAttachmentParameterName pname, int* @params)
		{
			glGetFramebufferParameteriv(target, pname, @params);
		}
		
		[MethodImport("glGetInternalformati64v", "4.3")]
		private static delegate*<TextureTarget, InternalFormat, InternalFormatPName, int, long*, void> glGetInternalformati64v;
		
		public static void GetInternalformati64v(TextureTarget target, InternalFormat internalformat, InternalFormatPName pname, int count, long* @params)
		{
			glGetInternalformati64v(target, internalformat, pname, count, @params);
		}
		
		[MethodImport("glInvalidateTexSubImage", "4.3")]
		private static delegate*<uint, int, int, int, int, int, int, int, void> glInvalidateTexSubImage;
		
		public static void InvalidateTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth)
		{
			glInvalidateTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth);
		}
		
		[MethodImport("glInvalidateTexImage", "4.3")]
		private static delegate*<uint, int, void> glInvalidateTexImage;
		
		public static void InvalidateTexImage(uint texture, int level)
		{
			glInvalidateTexImage(texture, level);
		}
		
		[MethodImport("glInvalidateBufferSubData", "4.3")]
		private static delegate*<uint, IntPtr, IntPtr, void> glInvalidateBufferSubData;
		
		public static void InvalidateBufferSubData(uint buffer, IntPtr offset, IntPtr length)
		{
			glInvalidateBufferSubData(buffer, offset, length);
		}
		
		[MethodImport("glInvalidateBufferData", "4.3")]
		private static delegate*<uint, void> glInvalidateBufferData;
		
		public static void InvalidateBufferData(uint buffer)
		{
			glInvalidateBufferData(buffer);
		}
		
		[MethodImport("glInvalidateFramebuffer", "4.3")]
		private static delegate*<FramebufferTarget, int, InvalidateFramebufferAttachment, void> glInvalidateFramebuffer;
		
		public static void InvalidateFramebuffer(FramebufferTarget target, int numAttachments, InvalidateFramebufferAttachment attachments)
		{
			glInvalidateFramebuffer(target, numAttachments, attachments);
		}
		
		[MethodImport("glInvalidateSubFramebuffer", "4.3")]
		private static delegate*<FramebufferTarget, int, InvalidateFramebufferAttachment, int, int, int, int, void> glInvalidateSubFramebuffer;
		
		public static void InvalidateSubFramebuffer(FramebufferTarget target, int numAttachments, InvalidateFramebufferAttachment attachments, int x, int y, int width, int height)
		{
			glInvalidateSubFramebuffer(target, numAttachments, attachments, x, y, width, height);
		}
		
		[MethodImport("glMultiDrawArraysIndirect", "4.3")]
		private static delegate*<PrimitiveType, void*, int, int, void> glMultiDrawArraysIndirect;
		
		public static void MultiDrawArraysIndirect(PrimitiveType mode, void* indirect, int drawcount, int stride)
		{
			glMultiDrawArraysIndirect(mode, indirect, drawcount, stride);
		}
		
		[MethodImport("glMultiDrawElementsIndirect", "4.3")]
		private static delegate*<PrimitiveType, DrawElementsType, void*, int, int, void> glMultiDrawElementsIndirect;
		
		public static void MultiDrawElementsIndirect(PrimitiveType mode, DrawElementsType type, void* indirect, int drawcount, int stride)
		{
			glMultiDrawElementsIndirect(mode, type, indirect, drawcount, stride);
		}
		
		[MethodImport("glGetProgramInterfaceiv", "4.3")]
		private static delegate*<uint, ProgramInterface, ProgramInterfacePName, int*, void> glGetProgramInterfaceiv;
		
		public static void GetProgramInterfaceiv(uint program, ProgramInterface programInterface, ProgramInterfacePName pname, int* @params)
		{
			glGetProgramInterfaceiv(program, programInterface, pname, @params);
		}
		
		[MethodImport("glGetProgramResourceIndex", "4.3")]
		private static delegate*<uint, ProgramInterface, byte*, uint> glGetProgramResourceIndex;
		
		public static uint GetProgramResourceIndex(uint program, ProgramInterface programInterface, byte* name)
		{
			return glGetProgramResourceIndex(program, programInterface, name);
		}
		
		[MethodImport("glGetProgramResourceName", "4.3")]
		private static delegate*<uint, ProgramInterface, uint, int, int*, byte*, void> glGetProgramResourceName;
		
		public static void GetProgramResourceName(uint program, ProgramInterface programInterface, uint index, int bufSize, int* length, byte* name)
		{
			glGetProgramResourceName(program, programInterface, index, bufSize, length, name);
		}
		
		[MethodImport("glGetProgramResourceiv", "4.3")]
		private static delegate*<uint, ProgramInterface, uint, int, ProgramResourceProperty, int, int*, int*, void> glGetProgramResourceiv;
		
		public static void GetProgramResourceiv(uint program, ProgramInterface programInterface, uint index, int propCount, ProgramResourceProperty props, int count, int* length, int* @params)
		{
			glGetProgramResourceiv(program, programInterface, index, propCount, props, count, length, @params);
		}
		
		[MethodImport("glGetProgramResourceLocation", "4.3")]
		private static delegate*<uint, ProgramInterface, byte*, int> glGetProgramResourceLocation;
		
		public static int GetProgramResourceLocation(uint program, ProgramInterface programInterface, byte* name)
		{
			return glGetProgramResourceLocation(program, programInterface, name);
		}
		
		[MethodImport("glGetProgramResourceLocationIndex", "4.3")]
		private static delegate*<uint, ProgramInterface, byte*, int> glGetProgramResourceLocationIndex;
		
		public static int GetProgramResourceLocationIndex(uint program, ProgramInterface programInterface, byte* name)
		{
			return glGetProgramResourceLocationIndex(program, programInterface, name);
		}
		
		[MethodImport("glShaderStorageBlockBinding", "4.3")]
		private static delegate*<uint, uint, uint, void> glShaderStorageBlockBinding;
		
		public static void ShaderStorageBlockBinding(uint program, uint storageBlockIndex, uint storageBlockBinding)
		{
			glShaderStorageBlockBinding(program, storageBlockIndex, storageBlockBinding);
		}
		
		[MethodImport("glTexBufferRange", "4.3")]
		private static delegate*<TextureTarget, SizedInternalFormat, uint, IntPtr, IntPtr, void> glTexBufferRange;
		
		public static void TexBufferRange(TextureTarget target, SizedInternalFormat internalformat, uint buffer, IntPtr offset, IntPtr size)
		{
			glTexBufferRange(target, internalformat, buffer, offset, size);
		}
		
		[MethodImport("glTexStorage2DMultisample", "4.3")]
		private static delegate*<TextureTarget, int, SizedInternalFormat, int, int, bool, void> glTexStorage2DMultisample;
		
		public static void TexStorage2DMultisample(TextureTarget target, int samples, SizedInternalFormat internalformat, int width, int height, bool fixedsamplelocations)
		{
			glTexStorage2DMultisample(target, samples, internalformat, width, height, fixedsamplelocations);
		}
		
		[MethodImport("glTexStorage3DMultisample", "4.3")]
		private static delegate*<TextureTarget, int, SizedInternalFormat, int, int, int, bool, void> glTexStorage3DMultisample;
		
		public static void TexStorage3DMultisample(TextureTarget target, int samples, SizedInternalFormat internalformat, int width, int height, int depth, bool fixedsamplelocations)
		{
			glTexStorage3DMultisample(target, samples, internalformat, width, height, depth, fixedsamplelocations);
		}
		
		[MethodImport("glTextureView", "4.3")]
		private static delegate*<uint, TextureTarget, uint, SizedInternalFormat, uint, uint, uint, uint, void> glTextureView;
		
		public static void TextureView(uint texture, TextureTarget target, uint origtexture, SizedInternalFormat internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers)
		{
			glTextureView(texture, target, origtexture, internalformat, minlevel, numlevels, minlayer, numlayers);
		}
		
		[MethodImport("glBindVertexBuffer", "4.3")]
		private static delegate*<uint, uint, IntPtr, int, void> glBindVertexBuffer;
		
		public static void BindVertexBuffer(uint bindingindex, uint buffer, IntPtr offset, int stride)
		{
			glBindVertexBuffer(bindingindex, buffer, offset, stride);
		}
		
		[MethodImport("glVertexAttribFormat", "4.3")]
		private static delegate*<uint, int, VertexAttribType, bool, uint, void> glVertexAttribFormat;
		
		public static void VertexAttribFormat(uint attribindex, int size, VertexAttribType type, bool normalized, uint relativeoffset)
		{
			glVertexAttribFormat(attribindex, size, type, normalized, relativeoffset);
		}
		
		[MethodImport("glVertexAttribIFormat", "4.3")]
		private static delegate*<uint, int, VertexAttribIType, uint, void> glVertexAttribIFormat;
		
		public static void VertexAttribIFormat(uint attribindex, int size, VertexAttribIType type, uint relativeoffset)
		{
			glVertexAttribIFormat(attribindex, size, type, relativeoffset);
		}
		
		[MethodImport("glVertexAttribLFormat", "4.3")]
		private static delegate*<uint, int, VertexAttribLType, uint, void> glVertexAttribLFormat;
		
		public static void VertexAttribLFormat(uint attribindex, int size, VertexAttribLType type, uint relativeoffset)
		{
			glVertexAttribLFormat(attribindex, size, type, relativeoffset);
		}
		
		[MethodImport("glVertexAttribBinding", "4.3")]
		private static delegate*<uint, uint, void> glVertexAttribBinding;
		
		public static void VertexAttribBinding(uint attribindex, uint bindingindex)
		{
			glVertexAttribBinding(attribindex, bindingindex);
		}
		
		[MethodImport("glVertexBindingDivisor", "4.3")]
		private static delegate*<uint, uint, void> glVertexBindingDivisor;
		
		public static void VertexBindingDivisor(uint bindingindex, uint divisor)
		{
			glVertexBindingDivisor(bindingindex, divisor);
		}
		
		[MethodImport("glDebugMessageControl", "4.3")]
		private static delegate*<DebugSource, DebugType, DebugSeverity, int, uint*, bool, void> glDebugMessageControl;
		
		public static void DebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, int count, uint* ids, bool enabled)
		{
			glDebugMessageControl(source, type, severity, count, ids, enabled);
		}
		
		[MethodImport("glDebugMessageInsert", "4.3")]
		private static delegate*<DebugSource, DebugType, uint, DebugSeverity, int, byte*, void> glDebugMessageInsert;
		
		public static void DebugMessageInsert(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, byte* buf)
		{
			glDebugMessageInsert(source, type, id, severity, length, buf);
		}
		
		[MethodImport("glDebugMessageCallback", "4.3")]
		private static delegate*<delegate*<uint, uint, uint, uint, int, byte*, void*, void>, void*, void> glDebugMessageCallback;
		
		public static void DebugMessageCallback(delegate*<uint, uint, uint, uint, int, byte*, void*, void> callback, void* userParam)
		{
			glDebugMessageCallback(callback, userParam);
		}
		
		[MethodImport("glGetDebugMessageLog", "4.3")]
		private static delegate*<uint, int, DebugSource, DebugType, uint*, DebugSeverity, int*, byte*, uint> glGetDebugMessageLog;
		
		public static uint GetDebugMessageLog(uint count, int bufSize, DebugSource sources, DebugType types, uint* ids, DebugSeverity severities, int* lengths, byte* messageLog)
		{
			return glGetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, messageLog);
		}
		
		[MethodImport("glPushDebugGroup", "4.3")]
		private static delegate*<DebugSource, uint, int, byte*, void> glPushDebugGroup;
		
		public static void PushDebugGroup(DebugSource source, uint id, int length, byte* message)
		{
			glPushDebugGroup(source, id, length, message);
		}
		
		[MethodImport("glPopDebugGroup", "4.3")]
		private static delegate*<void> glPopDebugGroup;
		
		public static void PopDebugGroup()
		{
			glPopDebugGroup();
		}
		
		[MethodImport("glObjectLabel", "4.3")]
		private static delegate*<ObjectIdentifier, uint, int, byte*, void> glObjectLabel;
		
		public static void ObjectLabel(ObjectIdentifier identifier, uint name, int length, byte* label)
		{
			glObjectLabel(identifier, name, length, label);
		}
		
		[MethodImport("glGetObjectLabel", "4.3")]
		private static delegate*<ObjectIdentifier, uint, int, int*, byte*, void> glGetObjectLabel;
		
		public static void GetObjectLabel(ObjectIdentifier identifier, uint name, int bufSize, int* length, byte* label)
		{
			glGetObjectLabel(identifier, name, bufSize, length, label);
		}
		
		[MethodImport("glObjectPtrLabel", "4.3")]
		private static delegate*<void*, int, byte*, void> glObjectPtrLabel;
		
		public static void ObjectPtrLabel(void* ptr, int length, byte* label)
		{
			glObjectPtrLabel(ptr, length, label);
		}
		
		[MethodImport("glGetObjectPtrLabel", "4.3")]
		private static delegate*<void*, int, int*, byte*, void> glGetObjectPtrLabel;
		
		public static void GetObjectPtrLabel(void* ptr, int bufSize, int* length, byte* label)
		{
			glGetObjectPtrLabel(ptr, bufSize, length, label);
		}
	}
}

