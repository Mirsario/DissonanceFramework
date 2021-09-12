using System;
using System.IO;
using System.Threading;
using CodeGenerator.Generators.Audio;
using CodeGenerator.Generators.Windowing;

namespace CodeGenerator
{
	public static class Program
	{
		internal static void Main(string[] args)
		{
			try {
				if (args.Length == 0) {
					throw new ArgumentException("An output path must be provided in command line arguments.");
				}

				const string WindowingOutput = "../Src/Windowing/Generated";
				const string AudioOutput = "../Src/Audio/Generated";

				if (Directory.Exists(WindowingOutput)) {
					Directory.Delete(WindowingOutput, true);
				}

				if (Directory.Exists(AudioOutput)) {
					Directory.Delete(AudioOutput, true);
				}

				new GlfwGenerator()
					.Generate("Generators/Windowing/Include/glfw3.h", WindowingOutput);

				new ALGenerator("Dissonance.Framework.Audio", "AL", "AL.Generated.cs")
					.Generate("Generators/Audio/Include/al.h", Path.Combine(AudioOutput, "AL"));

				new ALCGenerator("Dissonance.Framework.Audio", "ALC", "ALC.Generated.cs")
					.Generate("Generators/Audio/Include/alc.h", Path.Combine(AudioOutput, "ALC"));

				Console.WriteLine("Success.");
				Thread.Sleep(500);
			}
			catch (DllNotFoundException e) {
				Console.WriteLine($"{e.GetType().Name}: {e.Message}");
				Console.WriteLine("Please install LLVM (and add it to PATH) to use this generator.");
				Console.ReadKey();
			}
			catch (Exception e) {
				Console.WriteLine($"{e.GetType().Name}: {e.Message}");
				Console.WriteLine();
				Console.WriteLine("Press any key to close the application...");
				Console.ReadKey();
			}
		}
	}
}
