using System;

namespace Dissonance.Framework.Audio
{
	partial class ALC
	{
		public unsafe static IntPtr CreateContext(IntPtr device, ReadOnlySpan<int> attrlist = default)
		{
			if (attrlist.IsEmpty) {
				return CreateContext(device, (int*)null);
			}

			Span<int> attributeList = stackalloc int[attrlist.Length + 1];

			for (int i = 0; i < attrlist.Length; i++) {
				attributeList[i] = attrlist[i];
			}

			attributeList[attrlist.Length] = 0; // The passed list must be zero-terminated.

			fixed (int* ptr = attributeList) {
				return CreateContext(device, ptr);
			}
		}
	}
}
