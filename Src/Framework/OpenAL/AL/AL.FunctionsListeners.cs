using System.Runtime.InteropServices;
using CC = System.Runtime.InteropServices.CallingConvention;

namespace Dissonance.Framework.OpenAL
{
	partial class AL
	{
		#region SetListener

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alListeneri")]
		public static extern void Listener(ListenerInt parameter,int value);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alListenerf")]
		public static extern void Listener(ListenerFloat parameter,float value);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alListeneriv")]
		public static extern void Listener(ListenerIntArray parameter,int[] values);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alListenerfv")]
		public static extern void Listener(ListenerFloatArray parameter,float[] values);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alListener3i")]
		public static extern void Listener3(ListenerInt3 parameter,int x,int y,int z);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alListener3f")]
		public static extern void Listener3(ListenerFloat3 parameter,float x,float y,float z);

		#endregion

		#region GetListener

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alGetListeneri")]
		public static extern void GetListener(ListenerInt parameter,out int value);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alGetListenerf")]
		public static extern void GetListener(ListenerFloat parameter,out float value);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alGetListeneriv")]
		public static extern void GetListener(ListenerIntArray parameter,int[] values);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alGetListenerfv")]
		public static extern void GetListener(ListenerFloatArray parameter,float[] values);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alGetListener3i")]
		public static extern void GetListener3(ListenerInt3 parameter,out int x,out int y,out int z);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alGetListener3f")]
		public static extern void GetListener3(ListenerFloat3 parameter,out float x,out float y,out float z);

		#endregion
	}
}
