namespace Dissonance.Framework.Graphics.OpenGL
{
	public enum MemoryBarrierMask : uint
	{
		VertexAttribArrayBarrierBit = 0x00000001,
		VertexAttribArrayBarrierBitExt = 0x00000001,
		ElementArrayBarrierBit = 0x00000002,
		ElementArrayBarrierBitExt = 0x00000002,
		UniformBarrierBit = 0x00000004,
		UniformBarrierBitExt = 0x00000004,
		TextureFetchBarrierBit = 0x00000008,
		TextureFetchBarrierBitExt = 0x00000008,
		ShaderGlobalAccessBarrierBitNv = 0x00000010,
		ShaderImageAccessBarrierBit = 0x00000020,
		ShaderImageAccessBarrierBitExt = 0x00000020,
		CommandBarrierBit = 0x00000040,
		CommandBarrierBitExt = 0x00000040,
		PixelBufferBarrierBit = 0x00000080,
		PixelBufferBarrierBitExt = 0x00000080,
		TextureUpdateBarrierBit = 0x00000100,
		TextureUpdateBarrierBitExt = 0x00000100,
		BufferUpdateBarrierBit = 0x00000200,
		BufferUpdateBarrierBitExt = 0x00000200,
		FramebufferBarrierBit = 0x00000400,
		FramebufferBarrierBitExt = 0x00000400,
		TransformFeedbackBarrierBit = 0x00000800,
		TransformFeedbackBarrierBitExt = 0x00000800,
		AtomicCounterBarrierBit = 0x00001000,
		AtomicCounterBarrierBitExt = 0x00001000,
		ShaderStorageBarrierBit = 0x00002000,
		ClientMappedBufferBarrierBit = 0x00004000,
		ClientMappedBufferBarrierBitExt = 0x00004000,
		QueryBufferBarrierBit = 0x00008000,
		AllBarrierBits = 0xFFFFFFFF,
		AllBarrierBitsExt = 0xFFFFFFFF,
	}
}

