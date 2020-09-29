#pragma warning disable CS0649

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		[MethodImport("glDrawRangeElements")]
		private static DrawRangeElementsDelegate glDrawRangeElements;

		[MethodImport("glTexImage3D")]
		private static TexImage3DDelegate glTexImage3D;

		[MethodImport("glTexSubImage3D")]
		private static TexSubImage3DDelegate glTexSubImage3D;

		[MethodImport("glCopyTexSubImage3D")]
		private static CopyTexSubImage3DDelegate glCopyTexSubImage3D;
	}
}
