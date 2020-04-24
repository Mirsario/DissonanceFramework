#pragma warning disable CS0649

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[MethodImport("glActiveTexture")]
		private static ActiveTextureDelegate glActiveTexture;
		
		[MethodImport("glSampleCoverage")]
		private static SampleCoverageDelegate glSampleCoverage;
		
		[MethodImport("glCompressedTexImage3D")]
		private static CompressedTexImage3DDelegate glCompressedTexImage3D;
		
		[MethodImport("glCompressedTexImage2D")]
		private static CompressedTexImage2DDelegate glCompressedTexImage2D;
		
		[MethodImport("glCompressedTexImage1D")]
		private static CompressedTexImage1DDelegate glCompressedTexImage1D;
		
		[MethodImport("glCompressedTexSubImage3D")]
		private static CompressedTexSubImage3DDelegate glCompressedTexSubImage3D;
		
		[MethodImport("glCompressedTexSubImage2D")]
		private static CompressedTexSubImage2DDelegate glCompressedTexSubImage2D;
		
		[MethodImport("glCompressedTexSubImage1D")]
		private static CompressedTexSubImage1DDelegate glCompressedTexSubImage1D;
		
		[MethodImport("glGetCompressedTexImage")]
		private static GetCompressedTexImageDelegate glGetCompressedTexImage;
	}
}
