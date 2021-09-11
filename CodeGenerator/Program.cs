using System;
using System.Threading;

namespace CodeGenerator
{
	public static class Program
	{
		internal static void Main(string[] args)
		{
			try {
				if(args.Length == 0) {
					throw new ArgumentException("An output path must be provided in command line arguments.");
				}

				new GlfwGenerator()
					.Generate("include/glfw/glfw3.h", "../Src/Windowing/Generated");

				new ALGenerator("Dissonance.Framework.Audio", "AL", "AL.Generated.cs")
					.Generate("include/openal-soft/al.h", "../Src/Audio/AL/Generated");

				new ALCGenerator("Dissonance.Framework.Audio", "ALC", "ALC.Generated.cs")
					.Generate("include/openal-soft/alc.h", "../Src/Audio/ALC/Generated");

				Console.WriteLine("Success.");
				Thread.Sleep(500);
			}
			catch(DllNotFoundException e) {
				Console.WriteLine($"{e.GetType().Name}: {e.Message}");
				Console.WriteLine("Please install LLVM (and add it to PATH) to use this generator.");
				Console.ReadKey();
			}
			catch(Exception e) {
				Console.WriteLine($"{e.GetType().Name}: {e.Message}");
				Console.WriteLine();
				Console.WriteLine("Press any key to close the application...");
				Console.ReadKey();
			}
		}
	}
}
