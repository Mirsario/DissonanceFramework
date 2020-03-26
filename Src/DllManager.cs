﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Dissonance.Framework.Windowing;
using Dissonance.Framework.Audio;
using Dissonance.Framework.Imaging;
using MonoMod.RuntimeDetour;
using static Dissonance.Framework.OSUtils;

namespace Dissonance.Framework
{
	internal static partial class DllManager
	{
		private static readonly Dictionary<string,IntPtr> DllImportCache = new Dictionary<string,IntPtr>();
		private static readonly string[] EmbeddedAssemblies = {
			"MonoMod.RuntimeDetour",
			"MonoMod.Utils",
			"Mono.Cecil"
		};

		private static bool resolversReady;
		private static object lockObj = new object();
		private static List<NativeDetour> detours;
		private static Dictionary<string,Assembly> assemblyCache;

		static DllManager() => PrepareResolvers();

		public static void ImportTypeMethods(Type type,Func<string,IntPtr> functionToPointer)
		{
			detours = new List<NativeDetour>();

			lock(lockObj) {
				foreach(MethodInfo method in type.GetMethods(BindingFlags.Public|BindingFlags.NonPublic|BindingFlags.Static)) {
					var attribute = method.GetCustomAttribute<MethodImportAttribute>();

					if(attribute==null) {
						continue;
					}

					string functionName = attribute.Function;

					IntPtr ptr = functionToPointer(functionName);

					if(ptr!=IntPtr.Zero) {
						Console.WriteLine($"Detouring method '{method.DeclaringType.Name}.{method.Name}'...");	

						detours.Add(new NativeDetour(method,ptr,new NativeDetourConfig() { SkipILCopy = true }));
					} else {
						Console.WriteLine($"Unable to find function '{attribute.Function}'.");
					}
				}
			}
		}
		public static IntPtr DllLoad(string fileName)
		{
			IntPtr mHnd;

			if(IsOS(OS.Windows)) {
				mHnd = LoadLibraryWindows(fileName);
			} else {
				mHnd = LoadLibraryUnix(fileName,2);
			}

			if(mHnd==IntPtr.Zero) {
				throw new DllNotFoundException($"Failed to load library '{fileName}'");
			}

			return mHnd;
		}
		public static IntPtr DllSymbol(IntPtr mHnd,string symbol)
		{
			IntPtr symPtr;

			if(IsOS(OS.Windows)) {
				symPtr = GetProcAddressWindows(mHnd,symbol);
			} else {
				symPtr = GetProcAddressUnix(mHnd,symbol);
			}

			return symPtr;
		}
		public static Delegate DllDelegate(Type delegateType,IntPtr mHnd,string symbol)
		{
			return Marshal.GetDelegateForFunctionPointer(DllSymbol(mHnd,symbol),delegateType);
		}
		public static void MemoryCopy(IntPtr dest,IntPtr source,uint count)
		{
			if(IsOS(OS.Windows)) {
				CopyMemoryWindows(dest,source,count);
			} else {
				CopyMemoryUnix(dest,source,count);
			}
		}

		internal static void PrepareResolvers()
		{
			if(resolversReady) {
				return;
			}

			assemblyCache = new Dictionary<string,Assembly>();

			NativeLibrary.SetDllImportResolver(typeof(DllManager).Assembly,(name,assembly,path) => {
				if(DllImportCache.TryGetValue(name,out IntPtr pointer)) {
					return pointer;
				}

				IEnumerable<string> paths = name switch {
					GLFW.Library => GLFW.GetLibraryPaths(),
					AL.Library => AL.GetLibraryPaths(),
					IL.Library => IL.GetLibraryPaths(),
					_ => null
				};

				if(paths!=null) {
					foreach(string currentPath in paths) {
						try {
							DllImportCache[name] = pointer = NativeLibrary.Load(currentPath,assembly,path);
						}
						catch { }

						if(pointer!=IntPtr.Zero) {
							break;
						}
					}
				}

				return pointer;
			});

			AppDomain.CurrentDomain.AssemblyResolve += (obj,args) => {
				string assemblyName = args.Name;

				if(assemblyCache.TryGetValue(assemblyName,out var assembly)) {
					return assembly;
				}

				for(int i = 0;i<EmbeddedAssemblies.Length;i++) {
					var embeddedAssembly = EmbeddedAssemblies[i];

					if(args.Name.StartsWith(embeddedAssembly)) {
						return assemblyCache[assemblyName] = Assembly.Load((byte[])Properties.Resources.ResourceManager.GetObject(embeddedAssembly));
					}
				}

				return null;
			};

			resolversReady = true;
		}

		[DllImport("kernel32.dll",EntryPoint = "LoadLibrary",CharSet = CharSet.Ansi,ExactSpelling = true)]
		private static extern IntPtr LoadLibraryWindows(string filename);

		[DllImport("kernel32.dll",EntryPoint = "GetProcAddress",CharSet = CharSet.Ansi,ExactSpelling = true)]
		private static extern IntPtr GetProcAddressWindows(IntPtr hModule,string name);

		[DllImport("kernel32.dll",EntryPoint = "CopyMemory",CharSet = CharSet.Ansi,ExactSpelling = true)]
		private static extern void CopyMemoryWindows(IntPtr dest,IntPtr src,uint count);

		[DllImport("libdl.so",EntryPoint = "dlopen",CharSet = CharSet.Ansi,ExactSpelling = true)]
		private static extern IntPtr LoadLibraryUnix(string filename,int flags);

		[DllImport("libdl.so",EntryPoint = "dlsym",CharSet = CharSet.Ansi,ExactSpelling = true)]
		private static extern IntPtr GetProcAddressUnix(IntPtr handle,string symbol);

		[DllImport("libc.so.6",EntryPoint = "memcpy",CharSet = CharSet.Ansi,ExactSpelling = true)]
		private static extern void CopyMemoryUnix(IntPtr dest,IntPtr src,uint n);
	}
}