using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Dissonance.Framework.OpenAL;
using Dissonance.Utils;

#pragma warning disable IDE1006 //Naming rule violation

namespace Dissonance.Framework
{
	internal static partial class DllManager
	{
		private const int RTLD_NOW = 2;

		private static readonly Type DelegateType = typeof(MulticastDelegate);

		private static bool linuxSet;
		private static bool linux;

		public static bool Linux {
			get {
				if(!linuxSet) {
					int p = (int)Environment.OSVersion.Platform;

					linux = p==4 || p==6 || p==128;
					linuxSet = true;
				}

				return linux;
			}
		}

		static DllManager()
		{
			//public delegate IntPtr DllImportResolver(string libraryName,Assembly assembly,DllImportSearchPath? searchPath);

			NativeLibrary.SetDllImportResolver(typeof(DllManager).Assembly,(name,assembly,path) => {
				string lib = name switch {
					/*GLNew.Library => InternalUtils.GetOS() switch {
						OS.Windows => GLNew.LibraryWindows,
						OS.Linux => GLNew.LibraryLinux,
						OS.OSX => GLNew.LibraryMac,
						_ => null,
					},*/
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
				Console.WriteLine($"{nameof(args.Name)}: {args.Name}");
				Console.WriteLine($"e");

				return null;
			};
		}

		public static IntPtr DllLoad(string fileName)
		{
			IntPtr mHnd;

			if(Linux) {
				mHnd = dlopen(fileName,RTLD_NOW);
			} else {
				mHnd = LoadLibrary(fileName);
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

			if(Linux) {
				symPtr = dlsym(mHnd,symbol);
			} else {
				symPtr = GetProcAddress(mHnd,symbol);
			}

			return symPtr;
		}
		public static Delegate DllDelegate(Type delegateType,IntPtr mHnd,string symbol)
		{
			return Marshal.GetDelegateForFunctionPointer(DllSymbol(mHnd,symbol),delegateType);
		}
		public static void DllLinkAllDelegates(Type ofType,IntPtr mHnd,string prefix = null)
		{
			FieldInfo[] fields = ofType.GetFields(BindingFlags.Public|BindingFlags.Static);

			foreach(FieldInfo fi in fields) {
				if(fi.FieldType.BaseType!=DelegateType) {
					continue;
				}

				IntPtr ptr = DllSymbol(mHnd,prefix+fi.Name);

				if(ptr!=IntPtr.Zero) {
					fi.SetValue(null,Marshal.GetDelegateForFunctionPointer(ptr,fi.FieldType));
				}
			}
		}
		public static void Memcpy(IntPtr dest,IntPtr source,uint count)
		{
			if(Linux) {
				memcpy(dest,source,count);
			} else {
				CopyMemory(dest,source,count);
			}
		}

		[DllImport("kernel32.dll")] private static extern IntPtr LoadLibrary(string filename);
		[DllImport("kernel32.dll")] private static extern IntPtr GetProcAddress(IntPtr hModule,string name);
		[DllImport("kernel32.dll")] private static extern void CopyMemory(IntPtr dest,IntPtr src,uint count);
		[DllImport("libdl.so")] private static extern IntPtr dlopen(string filename,int flags);
		[DllImport("libdl.so")] private static extern IntPtr dlsym(IntPtr handle,string symbol);
		[DllImport("libc.so.6")] private static extern void memcpy(IntPtr dest,IntPtr src,uint n);
	}
}