using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Dissonance.Framework.OpenAL;
using Dissonance.Utils;
using MonoMod.RuntimeDetour;

#pragma warning disable IDE1006 //Naming rule violation

namespace Dissonance.Framework
{
	internal static partial class DllManager
	{
		private const int RTLD_NOW = 2;

		private static Assembly monoModRuntimeDetourAssembly;
		private static Assembly monoModUtilsAssembly;

		static DllManager()
		{
			NativeLibrary.SetDllImportResolver(typeof(DllManager).Assembly,(name,assembly,path) => {
				string lib = name switch {
					AL.Library => InternalUtils.GetOS() switch {
						OS.Windows => AL.LibraryWindows,
						OS.Linux => AL.LibraryLinux,
						OS.OSX => AL.LibraryMac,
						_ => null,
					},
					_ => null
				};

				return lib!=null ? NativeLibrary.Load(lib,assembly,path) : IntPtr.Zero;
			});

			AppDomain.CurrentDomain.AssemblyResolve += (obj,args) => {
				if(args.Name.StartsWith("MonoMod.RuntimeDetour")) {
					return monoModRuntimeDetourAssembly ?? (monoModRuntimeDetourAssembly = Assembly.Load(Properties.Resources.MonoMod_RuntimeDetour));
				}

				if(args.Name.StartsWith("MonoMod.Utils")) {
					return monoModUtilsAssembly ?? (monoModUtilsAssembly = Assembly.Load(Properties.Resources.MonoMod_Utils));
				}

				return null;
			};
		}

		public static void ImportTypeMethods(Type type,Func<string,IntPtr> functionToPointer)
		{
			foreach(MethodInfo method in type.GetMethods(BindingFlags.Public|BindingFlags.NonPublic|BindingFlags.Static)) {
				var attribute = method.GetCustomAttribute<MethodImportAttribute>();

				if(attribute==null) {
					continue;
				}

				var encodingSrc = Encoding.UTF8;
				var encodingDst = Encoding.ASCII;

				string functionName = attribute.Function; //encodingDst.GetString(Encoding.Convert(encodingSrc,encodingDst,encodingSrc.GetBytes(attribute.Function)));

				IntPtr ptr = functionToPointer(functionName);

				if(ptr!=IntPtr.Zero) {
					CreatePermanentDetour(method,ptr);
				} else {
					Console.WriteLine($"Unable to find function '{attribute.Function}'.");
				}
			}
		}
		public static IntPtr DllLoad(string fileName)
		{
			IntPtr mHnd;

			if(InternalUtils.IsOS(OS.Windows)) {
				mHnd = LoadLibrary(fileName);
			} else {
				mHnd = dlopen(fileName,RTLD_NOW);
			}

			if(mHnd!=IntPtr.Zero) {
				Console.WriteLine($"Linked '{fileName}'-> '0x{mHnd:X}'");
			} else {
				throw new DllNotFoundException($"Failed to link '{fileName}'");
			}

			return mHnd;
		}
		public static IntPtr DllSymbol(IntPtr mHnd,string symbol)
		{
			IntPtr symPtr;

			if(InternalUtils.IsOS(OS.Windows)) {
				symPtr = GetProcAddress(mHnd,symbol);
			} else {
				symPtr = dlsym(mHnd,symbol);
			}

			return symPtr;
		}
		public static Delegate DllDelegate(Type delegateType,IntPtr mHnd,string symbol)
		{
			return Marshal.GetDelegateForFunctionPointer(DllSymbol(mHnd,symbol),delegateType);
		}
		public static void MemoryCopy(IntPtr dest,IntPtr source,uint count)
		{
			if(InternalUtils.IsOS(OS.Windows)) {
				CopyMemory(dest,source,count);
			} else {
				memcpy(dest,source,count);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining|MethodImplOptions.NoOptimization)]
		private static void CreatePermanentDetour(MethodInfo from,IntPtr to)
		{
			new NativeDetour(from,to,new NativeDetourConfig() { SkipILCopy = true });
		}

		[DllImport("kernel32.dll")] private static extern IntPtr LoadLibrary(string filename);
		[DllImport("kernel32.dll")] private static extern IntPtr GetProcAddress(IntPtr hModule,string name);
		[DllImport("kernel32.dll")] private static extern void CopyMemory(IntPtr dest,IntPtr src,uint count);
		[DllImport("libdl.so")] private static extern IntPtr dlopen(string filename,int flags);
		[DllImport("libdl.so")] private static extern IntPtr dlsym(IntPtr handle,string symbol);
		[DllImport("libc.so.6")] private static extern void memcpy(IntPtr dest,IntPtr src,uint n);
	}
}