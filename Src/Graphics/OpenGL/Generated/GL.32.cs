using System;

namespace Dissonance.Framework.Graphics.OpenGL
{
	unsafe partial class GL
	{
		[MethodImport("glDrawElementsBaseVertex", "3.2")]
		private static delegate*<PrimitiveType, int, DrawElementsType, void*, int, void> glDrawElementsBaseVertex;
		
		public static void DrawElementsBaseVertex(PrimitiveType mode, int count, DrawElementsType type, void* indices, int basevertex)
		{
			glDrawElementsBaseVertex(mode, count, type, indices, basevertex);
		}
		
		[MethodImport("glDrawRangeElementsBaseVertex", "3.2")]
		private static delegate*<PrimitiveType, uint, uint, int, DrawElementsType, void*, int, void> glDrawRangeElementsBaseVertex;
		
		public static void DrawRangeElementsBaseVertex(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, void* indices, int basevertex)
		{
			glDrawRangeElementsBaseVertex(mode, start, end, count, type, indices, basevertex);
		}
		
		[MethodImport("glDrawElementsInstancedBaseVertex", "3.2")]
		private static delegate*<PrimitiveType, int, DrawElementsType, void*, int, int, void> glDrawElementsInstancedBaseVertex;
		
		public static void DrawElementsInstancedBaseVertex(PrimitiveType mode, int count, DrawElementsType type, void* indices, int instancecount, int basevertex)
		{
			glDrawElementsInstancedBaseVertex(mode, count, type, indices, instancecount, basevertex);
		}
		
		[MethodImport("glMultiDrawElementsBaseVertex", "3.2")]
		private static delegate*<PrimitiveType, int*, DrawElementsType, void**, int, int*, void> glMultiDrawElementsBaseVertex;
		
		public static void MultiDrawElementsBaseVertex(PrimitiveType mode, int* count, DrawElementsType type, void** indices, int drawcount, int* basevertex)
		{
			glMultiDrawElementsBaseVertex(mode, count, type, indices, drawcount, basevertex);
		}
		
		[MethodImport("glProvokingVertex", "3.2")]
		private static delegate*<VertexProvokingMode, void> glProvokingVertex;
		
		public static void ProvokingVertex(VertexProvokingMode mode)
		{
			glProvokingVertex(mode);
		}
		
		[MethodImport("glFenceSync", "3.2")]
		private static delegate*<SyncCondition, SyncBehaviorFlags, IntPtr> glFenceSync;
		
		public static IntPtr FenceSync(SyncCondition condition, SyncBehaviorFlags flags)
		{
			return glFenceSync(condition, flags);
		}
		
		[MethodImport("glIsSync", "3.2")]
		private static delegate*<IntPtr, bool> glIsSync;
		
		public static bool IsSync(IntPtr sync)
		{
			return glIsSync(sync);
		}
		
		[MethodImport("glDeleteSync", "3.2")]
		private static delegate*<IntPtr, void> glDeleteSync;
		
		public static void DeleteSync(IntPtr sync)
		{
			glDeleteSync(sync);
		}
		
		[MethodImport("glClientWaitSync", "3.2")]
		private static delegate*<IntPtr, SyncObjectMask, ulong, SyncStatus> glClientWaitSync;
		
		public static SyncStatus ClientWaitSync(IntPtr sync, SyncObjectMask flags, ulong timeout)
		{
			return glClientWaitSync(sync, flags, timeout);
		}
		
		[MethodImport("glWaitSync", "3.2")]
		private static delegate*<IntPtr, SyncBehaviorFlags, ulong, void> glWaitSync;
		
		public static void WaitSync(IntPtr sync, SyncBehaviorFlags flags, ulong timeout)
		{
			glWaitSync(sync, flags, timeout);
		}
		
		[MethodImport("glGetInteger64v", "3.2")]
		private static delegate*<GetPName, long*, void> glGetInteger64v;
		
		public static void GetInteger64v(GetPName pname, long* data)
		{
			glGetInteger64v(pname, data);
		}
		
		[MethodImport("glGetSynciv", "3.2")]
		private static delegate*<IntPtr, SyncParameterName, int, int*, int*, void> glGetSynciv;
		
		public static void GetSynciv(IntPtr sync, SyncParameterName pname, int count, int* length, int* values)
		{
			glGetSynciv(sync, pname, count, length, values);
		}
		
		[MethodImport("glGetInteger64i_v", "3.2")]
		private static delegate*<GetPName, uint, long*, void> glGetInteger64i_v;
		
		public static void GetInteger64i_v(GetPName target, uint index, long* data)
		{
			glGetInteger64i_v(target, index, data);
		}
		
		[MethodImport("glGetBufferParameteri64v", "3.2")]
		private static delegate*<BufferTargetARB, BufferPNameARB, long*, void> glGetBufferParameteri64v;
		
		public static void GetBufferParameteri64v(BufferTargetARB target, BufferPNameARB pname, long* @params)
		{
			glGetBufferParameteri64v(target, pname, @params);
		}
		
		[MethodImport("glFramebufferTexture", "3.2")]
		private static delegate*<FramebufferTarget, FramebufferAttachment, uint, int, void> glFramebufferTexture;
		
		public static void FramebufferTexture(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level)
		{
			glFramebufferTexture(target, attachment, texture, level);
		}
		
		[MethodImport("glTexImage2DMultisample", "3.2")]
		private static delegate*<TextureTarget, int, InternalFormat, int, int, bool, void> glTexImage2DMultisample;
		
		public static void TexImage2DMultisample(TextureTarget target, int samples, InternalFormat internalformat, int width, int height, bool fixedsamplelocations)
		{
			glTexImage2DMultisample(target, samples, internalformat, width, height, fixedsamplelocations);
		}
		
		[MethodImport("glTexImage3DMultisample", "3.2")]
		private static delegate*<TextureTarget, int, InternalFormat, int, int, int, bool, void> glTexImage3DMultisample;
		
		public static void TexImage3DMultisample(TextureTarget target, int samples, InternalFormat internalformat, int width, int height, int depth, bool fixedsamplelocations)
		{
			glTexImage3DMultisample(target, samples, internalformat, width, height, depth, fixedsamplelocations);
		}
		
		[MethodImport("glGetMultisamplefv", "3.2")]
		private static delegate*<GetMultisamplePNameNV, uint, float*, void> glGetMultisamplefv;
		
		public static void GetMultisamplefv(GetMultisamplePNameNV pname, uint index, float* val)
		{
			glGetMultisamplefv(pname, index, val);
		}
		
		[MethodImport("glSampleMaski", "3.2")]
		private static delegate*<uint, uint, void> glSampleMaski;
		
		public static void SampleMaski(uint maskNumber, uint mask)
		{
			glSampleMaski(maskNumber, mask);
		}
	}
}

