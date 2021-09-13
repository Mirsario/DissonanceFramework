using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using CodeGenerator.Generators.Audio;
using CodeGenerator.Generators.Graphics.OpenGL;
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
				const string OpenGLOutput = "../Src/Graphics/OpenGL/Generated";

				var filesToPotentiallyDelete = new List<FileInfo>();
				var startDate = DateTime.Now;

				filesToPotentiallyDelete.AddRange(new DirectoryInfo(WindowingOutput).EnumerateFiles("*.cs", SearchOption.AllDirectories));
				filesToPotentiallyDelete.AddRange(new DirectoryInfo(AudioOutput).EnumerateFiles("*.cs", SearchOption.AllDirectories));

				new GlfwGenerator("Generators/Windowing/Include/glfw3.h")
					.Generate(WindowingOutput);

				new ALGenerator("Generators/Audio/Include/al.h", "Dissonance.Framework.Audio", "AL", "AL.Generated.cs")
					.Generate(Path.Combine(AudioOutput, "AL"));

				new ALCGenerator("Generators/Audio/Include/alc.h", "Dissonance.Framework.Audio", "ALC", "ALC.Generated.cs")
					.Generate(Path.Combine(AudioOutput, "ALC"));

				new GLGenerator("Generators/Graphics/OpenGL/Include/gl.xml")
					.Generate(OpenGLOutput);

				foreach (var file in filesToPotentiallyDelete) {
					file.Refresh();

					if (file.LastWriteTime < startDate) {
						file.Delete();
					}
				}

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
