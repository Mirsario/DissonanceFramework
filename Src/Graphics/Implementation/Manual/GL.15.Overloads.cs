using System;
using MI = System.Runtime.CompilerServices.MethodImplAttribute;

#pragma warning disable IDE0060 //Unused parameter.

namespace Dissonance.Framework.Graphics
{
	partial class GL
	{
		//GenBuffer(s)

		[MI(ImplOptions)]
		public unsafe static uint GenBuffer()
		{
			uint result;

			GenBuffers(1, &result);

			return result;
		}

		[MI(ImplOptions)]
		public unsafe static void GenBuffers(int numBuffers, uint[] buffers)
		{
			fixed(uint* ptr = &(buffers != null && buffers.Length != 0 ? ref buffers[0] : ref *(uint*)null)) {
				GenBuffers(numBuffers, ptr);
			}
		}

		//DeleteBuffer(s)

		[MI(ImplOptions)]
		public unsafe static void DeleteBuffer(uint buffer) => DeleteBuffers(1, &buffer);

		[MI(ImplOptions)]
		public unsafe static void DeleteBuffers(int numBuffers, uint[] buffers)
		{
			fixed(uint* ptr = &(buffers != null && buffers.Length != 0 ? ref buffers[0] : ref *(uint*)null)) {
				DeleteBuffers(numBuffers, ptr);
			}
		}

		//BufferData
		public static unsafe void BufferData<T>(BufferTarget target, int size, T[] data, BufferUsageHint usage) where T : unmanaged
		{
			fixed(T* ptr = &(data != null && data.Length != 0 ? ref data[0] : ref *(T*)null)) {
				BufferData(target, (IntPtr)size, (IntPtr)ptr, usage);
			}
		}
	}
}