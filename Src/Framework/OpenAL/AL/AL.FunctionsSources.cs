using System.Runtime.InteropServices;
using CC = System.Runtime.InteropServices.CallingConvention;
using MI = System.Runtime.CompilerServices.MethodImplAttribute;

namespace Dissonance.Framework.OpenAL
{
	partial class AL
	{
		#region Source

		[MI(AI)] public static void Source(uint sourceId,SourceBool parameter,bool value) => Source(sourceId,(SourceInt)parameter,value ? 1 : 0);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alSourcei")]
		public static extern void Source(uint sourceId,SourceInt parameter,int value);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alSourcef")]
		public static extern void Source(uint sourceId,SourceFloat parameter,float value);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alSourceiv")]
		public static extern void Source3(uint sourceId,SourceIntArray parameter,int[] values);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alSourcefv")]
		public static extern void Source3(uint sourceId,SourceFloatArray parameter,float[] values);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alSource3i")]
		public static extern void Source3(uint sourceId,SourceVector3Int parameter,int x,int y,int z);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alSource3f")]
		public static extern void Source3(uint sourceId,SourceVector3Float parameter,float x,float y,float z);

		#endregion

		#region GetSource

		[MI(AI)]
		public static bool GetSource(uint sourceId,SourceBool parameter)
		{
			GetSource(sourceId,(SourceInt)parameter,out int result);

			return result==1;
		}

		[MI(AI)]
		public static int GetSource(uint sourceId,SourceInt parameter)
		{
			GetSource(sourceId,parameter,out int result);

			return result;
		}

		[MI(AI)]
		public static float GetSource(uint sourceId,SourceFloat parameter)
		{
			GetSource(sourceId,parameter,out float result);

			return result;
		}

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alGetSourcei")]
		public static extern void GetSource(uint sourceId,SourceInt parameter,out int value);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alGetSourcef")]
		public static extern void GetSource(uint sourceId,SourceFloat parameter,out float value);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alGetSourceiv")]
		public static extern void GetSource3(uint sourceId,SourceIntArray parameter,int[] values);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alGetSourcefv")]
		public static extern void GetSource3(uint sourceId,SourceFloatArray parameter,float[] values);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alGetSource3i")]
		public static extern void GetSource3(uint sourceId,SourceVector3Int parameter,out int x,out int y,out int z);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alGetSource3f")]
		public static extern void GetSource3(uint sourceId,SourceVector3Float parameter,out float x,out float y,out float z);

		#endregion

		#region GenSource(s)

		public static void GenSource(out uint sourceId) => GenSourceInternal(1,out sourceId);
		public static uint GenSource()
		{
			GenSourceInternal(1,out uint sourceId);

			return sourceId;
		}

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alGenSources")]
		public static extern void GenSources(int numSources,uint[] sourceIdOutputArray);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alGenSources")]
		private static extern void GenSourceInternal(int numSources,out uint sourceId);

		#endregion

		#region DeleteSource(s)

		public static void DeleteSource(uint sourceId) => DeleteSourceInternal(1,ref sourceId);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alDeleteSources")]
		public static extern void DeleteSources(int numSources,uint[] sourceIds);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alDeleteSources")]
		private static extern void DeleteSourceInternal(int numSources,ref uint sourceId);

		#endregion

		#region SourceX

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alIsSource")]
		public static extern bool IsSource(uint sourceId);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alSourcePlay")]
		public static extern void SourcePlay(uint sourceId);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alSourcePlayv")]
		public static extern void SourcePlay(int numSources,uint[] sourceIds);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alSourcePause")]
		public static extern void SourcePause(uint sourceId);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alSourcePausev")]
		public static extern void SourcePause(int numSources,uint[] sourceIds);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alSourceStop")]
		public static extern void SourceStop(uint sourceId);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alSourceStopv")]
		public static extern void SourceStop(int numSources,uint[] sourceIds);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alSourceRewind")]
		public static extern void SourceRewind(uint sourceId);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alSourceRewindv")]
		public static extern void SourceRewind(int numSources,uint[] sourceIds);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alSourceQueueBuffers")]
		public static extern void SourceQueueBuffers(uint sourceId,int numBuffers,uint[] bufferIds);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alSourceQueueBuffers")]
		public static extern void SourceQueueBuffers(uint sourceId,int numBuffers,ref uint bufferIds);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alSourceUnqueueBuffers")]
		public static extern void SourceUnqueueBuffers(uint sourceId,int numBuffers,uint[] bufferIds);

		[DllImport(Library,CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true,EntryPoint = "alSourceUnqueueBuffers")]
		public static extern void SourceUnqueueBuffers(uint sourceId,int numBuffers,ref uint bufferIds);

		#endregion
	}
}
