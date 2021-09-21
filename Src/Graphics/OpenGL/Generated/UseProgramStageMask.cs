namespace Dissonance.Framework.Graphics.OpenGL
{
	public enum UseProgramStageMask : uint
	{
		VertexShaderBit = 0x00000001,
		VertexShaderBitExt = 0x00000001,
		FragmentShaderBit = 0x00000002,
		FragmentShaderBitExt = 0x00000002,
		GeometryShaderBit = 0x00000004,
		GeometryShaderBitExt = 0x00000004,
		GeometryShaderBitOes = 0x00000004,
		TessControlShaderBit = 0x00000008,
		TessControlShaderBitExt = 0x00000008,
		TessControlShaderBitOes = 0x00000008,
		TessEvaluationShaderBit = 0x00000010,
		TessEvaluationShaderBitExt = 0x00000010,
		TessEvaluationShaderBitOes = 0x00000010,
		ComputeShaderBit = 0x00000020,
		MeshShaderBitNv = 0x00000040,
		TaskShaderBitNv = 0x00000080,
		AllShaderBits = 0xFFFFFFFF,
		AllShaderBitsExt = 0xFFFFFFFF,
	}
}

