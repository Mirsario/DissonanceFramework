namespace Dissonance.Framework.Graphics.OpenGL
{
	public enum BufferTargetARB : uint
	{
		ParameterBuffer = 0x80EE,
		ArrayBuffer = 0x8892,
		ElementArrayBuffer = 0x8893,
		PixelPackBuffer = 0x88EB,
		PixelUnpackBuffer = 0x88EC,
		UniformBuffer = 0x8A11,
		TextureBuffer = 0x8C2A,
		TransformFeedbackBuffer = 0x8C8E,
		CopyReadBuffer = 0x8F36,
		CopyWriteBuffer = 0x8F37,
		DrawIndirectBuffer = 0x8F3F,
		ShaderStorageBuffer = 0x90D2,
		DispatchIndirectBuffer = 0x90EE,
		QueryBuffer = 0x9192,
		AtomicCounterBuffer = 0x92C0,
	}
}

