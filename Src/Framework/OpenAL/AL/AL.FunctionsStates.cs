using System;
using System.Runtime.InteropServices;
using CC = System.Runtime.InteropServices.CallingConvention;

namespace Dissonance.Framework.OpenAL
{
	partial class AL
	{
		#region Getters

		public static string GetString(StateString parameter) => Marshal.PtrToStringAnsi(GetStringInternal(parameter));

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alGetError")]
		public static extern AudioError GetError();

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alGetBoolean")]
		public static extern bool Get(StateBool parameter);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alGetInteger")]
		public static extern int Get(StateInt parameter);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alGetFloat")]
		public static extern float Get(StateFloat parameter);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alGetDouble")]
		public static extern double Get(StateDouble parameter);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alGetBooleanv")]
		public static extern void Get(StateBool parameter,out bool values);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alGetIntegerv")]
		public static extern void Get(StateInt parameter,out int values);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alGetFloatv")]
		public static extern void Get(StateFloat parameter,out float values);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alGetDoublev")]
		public static extern void Get(StateDouble parameter,out double values);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alGetString")]
		internal static extern IntPtr GetStringInternal(StateString parameter);

		#endregion

		#region Setters

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alDopplerFactor")]
		public static extern void DopplerFactor(float value);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alDistanceModel")]
		public static extern void DistanceModel(int distanceModel);

		#endregion

		#region Capabilities

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alEnable")]
		public static extern void Enable(int capability);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alDisable")]
		public static extern void Disable(int capability);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alIsEnabled")]
		public static extern bool IsEnabled(int capability);

		#endregion
	}
}
