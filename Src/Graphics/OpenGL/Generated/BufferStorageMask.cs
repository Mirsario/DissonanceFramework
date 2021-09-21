namespace Dissonance.Framework.Graphics.OpenGL
{
	public enum BufferStorageMask : uint
	{
		DynamicStorageBit = 0x0100,
		DynamicStorageBitExt = 0x0100,
		ClientStorageBit = 0x0200,
		ClientStorageBitExt = 0x0200,
		SparseStorageBitArb = 0x0400,
		LgpuSeparateStorageBitNvx = 0x0800,
		PerGpuStorageBitNv = 0x0800,
		ExternalStorageBitNvx = 0x2000,
		MapReadBit = 0x0001,
		MapReadBitExt = 0x0001,
		MapWriteBit = 0x0002,
		MapWriteBitExt = 0x0002,
		MapPersistentBit = 0x0040,
		MapPersistentBitExt = 0x0040,
		MapCoherentBit = 0x0080,
		MapCoherentBitExt = 0x0080,
	}
}

