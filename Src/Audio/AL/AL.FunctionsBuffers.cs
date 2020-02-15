using System;
using System.Runtime.InteropServices;
using CC = System.Runtime.InteropServices.CallingConvention;

namespace Dissonance.Framework.Audio
{
	partial class AL
	{
		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alIsBuffer")]
		public static extern bool IsBuffer(uint buffer);

		#region Buffer

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alBufferi")]
		public static extern void Buffer(uint buffer,BufferInt parameter,int value);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alBufferf")]
		public static extern void Buffer(uint buffer,BufferFloat parameter,float value);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alBufferiv")]
		public static extern void Buffer(uint buffer,BufferIntArray parameter,int[] values);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alBufferfv")]
		public static extern void Buffer(uint buffer,BufferFloatArray parameter,float[] values);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alBuffer3i")]
		public static extern void Buffer3(uint buffer,BufferInt3 parameter,int x,int y,int z);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alBuffer3f")]
		public static extern void Buffer3(uint buffer,BufferFloat3 parameter,float x,float y,float z);

		#endregion

		#region GetBuffer

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alGetBufferi")]
		public static extern void GetBuffer(uint buffer,GetBufferInt parameter,out int value);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alGetBufferf")]
		public static extern void GetBuffer(uint buffer,BufferFloat parameter,out float value);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alGetBufferiv")]
		public static extern void GetBuffer(uint buffer,BufferIntArray parameter,int[] values);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alGetBufferfv")]
		public static extern void GetBuffer(uint buffer,BufferFloatArray parameter,float[] values);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alGetBuffer3i")]
		public static extern void GetBuffer3(uint buffer,BufferInt3 parameter,out int x,out int y,out int z);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alGetBuffer3f")]
		public static extern void GetBuffer3(uint buffer,BufferFloat3 parameter,out float value1,out float value2,out float value3);

		#endregion

		#region BufferData

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alBufferData")]
		public static extern void BufferData(uint buffer,BufferFormat format,IntPtr data,int size,int frequency);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alBufferData")]
		public static extern void BufferData(uint buffer,BufferFormat format,byte[] data,int size,int frequency);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alBufferData")]
		public static extern void BufferData(uint buffer,BufferFormat format,short[] data,int size,int frequency);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alBufferData")]
		public static extern void BufferData(uint buffer,BufferFormat format,float[] data,int size,int frequency);

		#endregion

		#region GenBuffer(s)

		public static void GenBuffer(out uint bufferId) => GenBufferInternal(1,out bufferId);
		public static uint GenBuffer()
		{
			GenBufferInternal(1,out uint bufferId);

			return bufferId;
		}

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alGenBuffers")]
		public static extern void GenBuffers(int numBuffers,uint[] bufferIdOutputArray);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alGenBuffers")]
		private static extern void GenBufferInternal(int numBuffers,out uint bufferId);

		#endregion

		#region DeleteBuffer(s)

		public static void DeleteBuffer(uint bufferId) => DeleteBufferInternal(1,ref bufferId);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alDeleteBuffers")]
		public static extern void DeleteBuffers(int numBuffers,uint[] bufferIds);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alDeleteBuffers")]
		private static extern void DeleteBufferInternal(int numBuffers,ref uint bufferId);

		#endregion
	}
}
