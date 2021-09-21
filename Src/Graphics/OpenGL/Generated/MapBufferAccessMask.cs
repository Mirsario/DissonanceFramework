namespace Dissonance.Framework.Graphics.OpenGL
{
	public enum MapBufferAccessMask : uint
	{
		MapReadBit = 0x0001,
		MapReadBitExt = 0x0001,
		MapWriteBit = 0x0002,
		MapWriteBitExt = 0x0002,
		MapInvalidateRangeBit = 0x0004,
		MapInvalidateRangeBitExt = 0x0004,
		MapInvalidateBufferBit = 0x0008,
		MapInvalidateBufferBitExt = 0x0008,
		MapFlushExplicitBit = 0x0010,
		MapFlushExplicitBitExt = 0x0010,
		MapUnsynchronizedBit = 0x0020,
		MapUnsynchronizedBitExt = 0x0020,
		MapPersistentBit = 0x0040,
		MapPersistentBitExt = 0x0040,
		MapCoherentBit = 0x0080,
		MapCoherentBitExt = 0x0080,
	}
}

