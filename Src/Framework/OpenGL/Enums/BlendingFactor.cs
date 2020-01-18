namespace Dissonance.Framework.OpenGL
{
	public enum BlendingFactor
	{
		//OpenGL 1.0 + OpenGL 1.1
		Zero = 0,
		One = 1,
		SrcColor = 768,
		OneMinusSrcColor = 769,
		SrcAlpha = 770,
		OneMinusSrcAlpha = 771,
		DstAlpha = 772,
		OneMinusDstAlpha = 773,
		DstColor = 774,
		OneMinusDstColor = 775,
		SrcAlphaSaturate = 776,

		//OpenGL 1.4
		ConstantColor = 32769,
		OneMinusConstantColor = 32770,
		ConstantAlpha = 32771,
		OneMinusConstantAlpha = 32772,

		//OpenGL 1.5
		Src1Alpha = 34185,

		//OpenGL 3.3
		Src1Color = 35065,
		OneMinusSrc1Color = 35066,
		OneMinusSrc1Alpha = 35067
	}
}
