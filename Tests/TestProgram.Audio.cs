using System;
using System.IO;
using Dissonance.Framework.Audio;

namespace Test
{
	partial class TestProgram
	{
		public static IntPtr audioDevice;
		public static IntPtr audioContext;

		private static unsafe void PrepareOpenAL()
		{
			audioDevice = ALC.OpenDevice(null);
			audioContext = ALC.CreateContext(audioDevice, null);

			if (!ALC.MakeContextCurrent(audioContext)) {
				throw new InvalidOperationException("Unable to make context current");
			}

			Console.WriteLine("Created audio context.");

			CheckALErrors();

			const string AudioFile = "Audio.raw";

			if (!File.Exists(AudioFile)) {
				Console.WriteLine($"No {AudioFile} found.");
				return;
			}

			//Buffer
			uint bufferId = AL.GenBuffer();
			byte[] data = File.ReadAllBytes(AudioFile);

			fixed (byte* ptr = data) {
				AL.BufferData(bufferId, BufferFormat.Stereo16, (IntPtr)ptr, data.Length, 44100);
			}

			//Source
			uint sourceId = AL.GenSource();

			AL.Source(sourceId, SourceInt.Buffer, (int)bufferId);
			AL.Source(sourceId, SourceBool.Looping, true);

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

			if (error != AudioError.NoError) {
				throw new Exception($"OpenAL Error: {error}");
			}
		}
	}
}
