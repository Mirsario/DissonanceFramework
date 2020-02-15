using System;

#pragma warning disable IDE0060 //Unused parameter.

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[MethodImport("glDrawElementsBaseVertex","3.2")]
		public static void DrawElementsBaseVertex(uint mode,int count,uint type,IntPtr indices,int basevertex)
			=> throw new NotImplementedException();

		[MethodImport("glDrawRangeElementsBaseVertex","3.2")]
		public static void DrawRangeElementsBaseVertex(uint mode,uint start,uint end,int count,uint type,IntPtr indices,int basevertex)
			=> throw new NotImplementedException();

		[MethodImport("glDrawElementsInstancedBaseVertex","3.2")]
		public static void DrawElementsInstancedBaseVertex(uint mode,int count,uint type,IntPtr indices,int instanceCount,int basevertex)
			=> throw new NotImplementedException();

		[MethodImport("glMultiDrawElementsBaseVertex","3.2")]
		public static void MultiDrawElementsBaseVertex(uint mode,ref int count,uint type,IntPtr indices,int drawcount,ref int basevertex)
			=> throw new NotImplementedException();

		[MethodImport("glProvokingVertex","3.2")]
		public static void ProvokingVertex(uint mode)
			=> throw new NotImplementedException();

		[MethodImport("glFenceSync","3.2")]
		public static IntPtr FenceSync(uint condition,uint flags)
			=> throw new NotImplementedException();

		[MethodImport("glIsSync","3.2")]
		public static byte IsSync(IntPtr sync)
			=> throw new NotImplementedException();

		[MethodImport("glDeleteSync","3.2")]
		public static void DeleteSync(IntPtr sync)
			=> throw new NotImplementedException();

		[MethodImport("glClientWaitSync","3.2")]
		public static uint ClientWaitSync(IntPtr sync,uint flags,uint timeout)
			=> throw new NotImplementedException();

		[MethodImport("glWaitSync","3.2")]
		public static void WaitSync(IntPtr sync,uint flags,uint timeout)
			=> throw new NotImplementedException();

		[MethodImport("glGetInteger64v","3.2")]
		public static void GetInteger(uint pName,ref int data)
			=> throw new NotImplementedException();

		[MethodImport("glGetSynciv","3.2")]
		public static void GetSync(IntPtr sync,uint pName,int bufSize,ref int length,ref int values)
			=> throw new NotImplementedException();

		[MethodImport("glGetInteger64i_v","3.2")]
		public static void GetInteger(uint target,uint index,ref long data)
			=> throw new NotImplementedException();

		[MethodImport("glGetBufferParameteri64v","3.2")]
		public static void GetBufferParameter(BufferTarget target,uint pName,ref long parameters)
			=> throw new NotImplementedException();

		[MethodImport("glFramebufferTexture","3.2")]
		public static void FramebufferTexture(FramebufferTarget target,FramebufferAttachment attachment,uint texture,int level)
			=> throw new NotImplementedException();

		[MethodImport("glTexImage2DMultisample","3.2")]
		public static void TexImage2DMultisample(TextureTarget target,int samples,PixelInternalFormat internalFormat,int width,int height,byte fixedsamplelocations)
			=> throw new NotImplementedException();

		[MethodImport("glTexImage3DMultisample","3.2")]
		public static void TexImage3DMultisample(TextureTarget target,int samples,PixelInternalFormat internalFormat,int width,int height,int depth,byte fixedsamplelocations)
			=> throw new NotImplementedException();

		[MethodImport("glGetMultisamplefv","3.2")]
		public static void GetMultisample(uint pName,uint index,ref float val)
			=> throw new NotImplementedException();

		[MethodImport("glSampleMaski","3.2")]
		public static void SampleMask(uint maskNumber,uint mask)
			=> throw new NotImplementedException();
	}
}