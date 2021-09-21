namespace Dissonance.Framework.Graphics.OpenGL
{
	public enum ConditionalRenderMode : uint
	{
		QueryWait = 0x8E13,
		QueryNoWait = 0x8E14,
		QueryByRegionWait = 0x8E15,
		QueryByRegionNoWait = 0x8E16,
		QueryWaitInverted = 0x8E17,
		QueryNoWaitInverted = 0x8E18,
		QueryByRegionWaitInverted = 0x8E19,
		QueryByRegionNoWaitInverted = 0x8E1A,
	}
}

