using System;
using System.Runtime.InteropServices;
using MI = System.Runtime.CompilerServices.MethodImplAttribute;

namespace Dissonance.Framework.OpenGL
{
	partial class GL
	{
		//DrawBuffers
		[MI(AI)]
		public unsafe static void DrawBuffers(int numDrawBuffers,DrawBuffersEnum[] drawBuffers)
		{
			fixed(DrawBuffersEnum* ptr = &(drawBuffers!=null && drawBuffers.Length!=0 ? ref drawBuffers[0] : ref *(DrawBuffersEnum*)null)) {
				DeleteFramebuffers(numDrawBuffers,(uint*)ptr);
			}
		}

		//GetShaderInfoLog
		[MI(AI)]
		public unsafe static string GetShaderInfoLog(uint shader)
		{
			GetShader(shader,ShaderParameterName.InfoLogLength,out int length);

			if(length<=0) {
				return string.Empty;
			}

			int bufferSize = length*2;
			IntPtr intPtr = Marshal.AllocHGlobal(bufferSize+1);

			GL.GetShaderInfoLog(shader,bufferSize,out length,intPtr);

			string result = Marshal.PtrToStringAnsi(intPtr);
			Marshal.FreeHGlobal(intPtr);

			return result;
		}

		//GetShaderInfoLog
		[MI(AI)]
		public unsafe static void ShaderSource(uint shader,string source)
		{
			int sourceLength = source.Length;

			ShaderSource(shader,1,new[] { source },&sourceLength);
		}
		[MI(AI)]
		public unsafe static void ShaderSource(uint shader,int count,string[] sources,int* length)
		{
			IntPtr arrayPointer = Marshal.AllocHGlobal(sources.Length*IntPtr.Size);

			if(arrayPointer==IntPtr.Zero) {
				throw new OutOfMemoryException();
			}

			for(int i = 0;i<sources.Length;i++) {
				IntPtr sourcePointer = Marshal.StringToHGlobalAnsi(sources[i]);
				Marshal.WriteIntPtr(arrayPointer,i*IntPtr.Size,sourcePointer);
			}

			ShaderSource(shader,count,arrayPointer,length);

			for(int i = 0;i<sources.Length;i++) {
				Marshal.FreeHGlobal(Marshal.ReadIntPtr(arrayPointer,i*IntPtr.Size));
			}

			Marshal.FreeHGlobal(arrayPointer);
		}

		//GetActiveUniform
		public unsafe static void GetActiveUniform(uint program,uint index,int bufferSize,out int length,out int size,out ActiveUniformType type,out string name)
		{
			fixed(int* lengthPtr = &length) {
				fixed(int* sizePtr = &size) {
					fixed(ActiveUniformType* typePtr = &type) {
						IntPtr stringPtr = Marshal.AllocHGlobal(bufferSize+1);

						GetActiveUniform(program,index,bufferSize,lengthPtr,sizePtr,typePtr,stringPtr);

						name = Marshal.PtrToStringAnsi(stringPtr);

						Marshal.FreeHGlobal(stringPtr);
					}
				}
			}
		}

		//Uniforms float[]

		[MI(AI)]
		public unsafe static void Uniform1(int location,int count,float[] values)
		{
			fixed(float* ptr = values) {
				GL.Uniform1(location,count,ptr);
			}
		}
		[MI(AI)]
		public unsafe static void Uniform2(int location,int count,float[] values)
		{
			fixed(float* ptr = values) {
				GL.Uniform2(location,count,ptr);
			}
		}
		[MI(AI)]
		public unsafe static void Uniform3(int location,int count,float[] values)
		{
			fixed(float* ptr = values) {
				GL.Uniform3(location,count,ptr);
			}
		}
		[MI(AI)]
		public unsafe static void Uniform4(int location,int count,float[] values)
		{
			fixed(float* ptr = values) {
				GL.Uniform4(location,count,ptr);
			}
		}

		//Uniforms int[]

		[MI(AI)]
		public unsafe static void Uniform1(int location,int count,int[] values)
		{
			fixed(int* ptr = values) {
				GL.Uniform1(location,count,ptr);
			}
		}
		[MI(AI)]
		public unsafe static void Uniform2(int location,int count,int[] values)
		{
			fixed(int* ptr = values) {
				GL.Uniform2(location,count,ptr);
			}
		}
		[MI(AI)]
		public unsafe static void Uniform3(int location,int count,int[] values)
		{
			fixed(int* ptr = values) {
				GL.Uniform3(location,count,ptr);
			}
		}
		[MI(AI)]
		public unsafe static void Uniform4(int location,int count,int[] values)
		{
			fixed(int* ptr = values) {
				GL.Uniform4(location,count,ptr);
			}
		}
	}
}