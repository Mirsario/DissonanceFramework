namespace Dissonance.Framework.Graphics
{
	public enum BufferTarget
	{
		/// <summary> Vertex attributes. </summary>
		ArrayBuffer = 34962,

		/// <summary> Vertex array indices. </summary>
		ElementArrayBuffer = 34963,

		/// <summary> Pixel read target. </summary>
		PixelPackBuffer = 35051,

		/// <summary> Texture data source. </summary>
		PixelUnpackBuffer = 35052,

		/// <summary> Uniform block storage. </summary>
		UniformBuffer = 35345,

		/// <summary> Texture data buffer. </summary>
		TextureBuffer = 35882,

		/// <summary> Transform feedback buffer. </summary>
		TransformFeedbackBuffer = 35982,

		/// <summary> Buffer copy source. </summary>
		CopyReadBuffer = 36662,

		/// <summary> Buffer copy destination. </summary>
		CopyWriteBuffer = 36663,

		/// <summary> Indirect command arguments. </summary>
		DrawIndirectBuffer = 36671,

		/// <summary> Read-write storage for shaders. </summary>
		ShaderStorageBuffer = 37074,

		/// <summary> Indirect compute dispatch commands. </summary>
		DispatchIndirectBuffer = 37102,

		/// <summary> Query result buffer. </summary>
		QueryBuffer = 37266,

		/// <summary> Atomic counter storage. </summary>
		AtomicCounterBuffer = 37568
	}
}
