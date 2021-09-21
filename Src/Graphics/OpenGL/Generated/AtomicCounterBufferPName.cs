namespace Dissonance.Framework.Graphics.OpenGL
{
	public enum AtomicCounterBufferPName : uint
	{
		AtomicCounterBufferReferencedByComputeShader = 0x90ED,
		AtomicCounterBufferBinding = 0x92C1,
		AtomicCounterBufferDataSize = 0x92C4,
		AtomicCounterBufferActiveAtomicCounters = 0x92C5,
		AtomicCounterBufferActiveAtomicCounterIndices = 0x92C6,
		AtomicCounterBufferReferencedByVertexShader = 0x92C7,
		AtomicCounterBufferReferencedByTessControlShader = 0x92C8,
		AtomicCounterBufferReferencedByTessEvaluationShader = 0x92C9,
		AtomicCounterBufferReferencedByGeometryShader = 0x92CA,
		AtomicCounterBufferReferencedByFragmentShader = 0x92CB,
	}
}

