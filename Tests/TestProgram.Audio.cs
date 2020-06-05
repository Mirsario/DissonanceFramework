using System;
using System.IO;
using Dissonance.Framework.Audio;
using Dissonance.Framework.Graphics;
using Dissonance.Framework.Windowing;

namespace Test
{
	partial class TestProgram
	{
		public static IntPtr audioDevice;
		public static IntPtr audioContext;

		private static void PrepareOpenAL()
		{
			audioDevice = ALC.OpenDevice(null);
			audioContext = ALC.CreateContext(audioDevice,null);

			if(!ALC.MakeContextCurrent(audioContext)) {
				throw new InvalidOperationException("Unable to make context current");
			}

			Console.WriteLine("Created audio context.");

			CheckALErrors();

			const string AudioFile = "Audio.raw";

			if(!File.Exists(AudioFile)) {
				Console.WriteLine($"No {AudioFile} found.");
				return;
			}

			//Buffer
			AL.GenBuffer(out uint bufferId);

			byte[] data = File.ReadAllBytes(AudioFile);

			AL.BufferData(bufferId,BufferFormat.Stereo16,data,data.Length,44100);

			//Source
			AL.GenSource(out uint sourceId);

			AL.Source(sourceId,SourceInt.Buffer,(int)bufferId);
			AL.Source(sourceId,SourceBool.Looping,true);

			AL.SourcePlay(sourceId);

			Console.WriteLine($"Played {AudioFile}.");
		}
		private static void UnloadOpenAL()
		{
			ALC.DestroyContext(audioContext);
			ALC.CloseDevice(audioDevice);
		}
		private static void CheckALErrors()
		{
			var error = AL.GetError();

			if(error!=AudioError.NoError) {
				throw new Exception($"OpenAL Error: {error}");
			}
		}
	}
}
