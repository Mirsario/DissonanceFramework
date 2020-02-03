using System;
using System.Runtime.InteropServices;
using CC = System.Runtime.InteropServices.CallingConvention;

namespace Dissonance.Framework.DevIL
{
	partial class IL
	{
		//Init

		[DllImport(Library,EntryPoint = "ilInit",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void Init();

		//Load

		[DllImport(Library,EntryPoint = "ilLoad",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern bool Load(LoadImageType type,string fileName);

		[DllImport(Library,EntryPoint = "ilLoadF",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern bool Load(LoadImageTypeStreaming type,IntPtr fileHandle);

		[DllImport(Library,EntryPoint = "ilLoadL",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern bool Load(LoadImageTypeLumps type,IntPtr lump,int size);

		[DllImport(Library,EntryPoint = "ilLoadL",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern bool Load(LoadImageTypeLumps type,byte[] lump,int size);

		[DllImport(Library,EntryPoint = "ilLoadImage",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern bool LoadImage(string fileName);

		[DllImport(Library,EntryPoint = "ilLoadPal",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern bool LoadPal(string fileName);

		[DllImport(Library,EntryPoint = "ilLoadData",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern bool LoadData(string fileName,int width,int height,int depth,byte bpp);

		[DllImport(Library,EntryPoint = "ilLoadDataL",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern bool LoadData(IntPtr lump,int size,int width,int height,int depth,byte bpp);

		//Save

		[DllImport(Library,EntryPoint = "ilSave",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern bool Save(SaveImageType type,string fileName);

		[DllImport(Library,EntryPoint = "ilSaveF",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern int Save(SaveImageTypeStreaming type,IntPtr file);

		[DllImport(Library,EntryPoint = "ilSaveL",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern int Save(SaveImageTypeLumps type,IntPtr lump,int size);

		[DllImport(Library,EntryPoint = "ilSaveImage",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern bool SaveImage(string fileName);

		[DllImport(Library,EntryPoint = "ilSavePal",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern bool SavePal(string fileName);

		[DllImport(Library,EntryPoint = "ilSaveData",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern bool SaveData(string fileName);

		//Get

		[DllImport(Library,EntryPoint = "ilGetData",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern IntPtr GetData();

		[DllImport(Library,EntryPoint = "ilGetError",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern int GetError();

		[DllImport(Library,EntryPoint = "ilGetAlpha",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern IntPtr GetAlpha(int type);

		[DllImport(Library,EntryPoint = "ilGetBoolean",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern bool GetBoolean(int mode);

		[DllImport(Library,EntryPoint = "ilGetBooleanv",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void GetBooleanv(int mode,out bool Param);

		[DllImport(Library,EntryPoint = "ilGetBooleanv",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void GetBooleanv(int mode,[Out] bool[] Param);

		[DllImport(Library,EntryPoint = "ilGetDXTCData",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern int GetDXTCData(IntPtr buffer,int bufferSize,int dXTCFormat);

		[DllImport(Library,EntryPoint = "ilGetDXTCData",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern int GetDXTCData(byte[] buffer,int bufferSize,int dXTCFormat);

		[DllImport(Library,EntryPoint = "ilGetInteger",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern int GetInteger(int mode);

		[DllImport(Library,EntryPoint = "ilGetIntegerv",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void GetIntegerv(int mode,out int param);

		[DllImport(Library,EntryPoint = "ilGetIntegerv",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void GetIntegerv(int mode,[Out] int[] param);

		[DllImport(Library,EntryPoint = "ilGetLumpPos",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern int GetLumpPos();

		[DllImport(Library,EntryPoint = "ilGetPalette",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern IntPtr GetPalette();

		[DllImport(Library,EntryPoint = "ilGetString",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern string GetString(int stringName);

		//Etc

		[DllImport(Library,EntryPoint = "ilActiveImage",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern bool ActiveImage(int number);

		[DllImport(Library,EntryPoint = "ilActiveLayer",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern bool ActiveLayer(int number);

		[DllImport(Library,EntryPoint = "ilActiveMipmap",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern bool ActiveMipmap(int number);

		[DllImport(Library,EntryPoint = "ilApplyPal",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern bool ApplyPal(string fileName);

		[DllImport(Library,EntryPoint = "ilApplyProfile",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern bool ApplyProfile(string inProfile,string outProfile);

		[DllImport(Library,EntryPoint = "ilBindImage",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void BindImage(int image);

		[DllImport(Library,EntryPoint = "ilBlit",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern bool Blit(int source,int destX,int destY,int destZ,int srcX,int srcY,int srcZ,int width,int height,int depth);

		[DllImport(Library,EntryPoint = "ilClearColour",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void ClearColour(float red,float green,float blue,float alpha);

		[DllImport(Library,EntryPoint = "ilClearColour",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void ClearColor(float red,float green,float blue,float alpha);

		[DllImport(Library,EntryPoint = "ilClearImage",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern bool ClearImage();

		[DllImport(Library,EntryPoint = "ilCloneCurImage",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern int CloneCurImage();

		[DllImport(Library,EntryPoint = "ilCompressFunc",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern bool CompressFunc(int mode);

		[DllImport(Library,EntryPoint = "ilConvertImage",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern bool ConvertImage(int destFormat,int destType);

		[DllImport(Library,EntryPoint = "ilConvertPal",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern bool ConvertPal(int destFormat);

		[DllImport(Library,EntryPoint = "ilCopyImage",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern bool CopyImage(int src);

		[DllImport(Library,EntryPoint = "ilCopyPixels",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern int CopyPixels(int xOff,int yOff,int zOff,int width,int height,int depth,int format,int type,IntPtr data);

		[DllImport(Library,EntryPoint = "ilCopyPixels",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern int CopyPixels(int xOff,int yOff,int zOff,int width,int height,int depth,int format,int type,byte[] data);

		[DllImport(Library,EntryPoint = "ilCreateSubImage",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern int CreateSubImage(int type,int num);

		[DllImport(Library,EntryPoint = "ilDefaultImage",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern bool DefaultImage();

		[DllImport(Library,EntryPoint = "ilDeleteImages",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void DeleteImages(int num,ref int Images);

		[DllImport(Library,EntryPoint = "ilDeleteImages",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void DeleteImages(int num,int[] images);

		[DllImport(Library,EntryPoint = "ilDisable",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern bool Disable(int mode);

		[DllImport(Library,EntryPoint = "ilEnable",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern bool Enable(int mode);

		[DllImport(Library,EntryPoint = "ilFormatFunc",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern bool FormatFunc(int mode);

		[DllImport(Library,EntryPoint = "ilGenImages",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void GenImages(int num,out int Images);

		[DllImport(Library,EntryPoint = "ilGenImages",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void GenImages(int num,[Out] int[] Images);

		[DllImport(Library,EntryPoint = "ilHint",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void Hint(int target,int mode);

		[DllImport(Library,EntryPoint = "ilIsDisabled",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern bool IsDisabled(int mode);

		[DllImport(Library,EntryPoint = "ilIsEnabled",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern bool IsEnabled(int mode);

		[DllImport(Library,EntryPoint = "ilIsImage",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern bool IsImage(int image);

		[DllImport(Library,EntryPoint = "ilIsValid",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern bool IsValid(int type,string fileName);

		[DllImport(Library,EntryPoint = "ilIsValidL",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern bool IsValidL(int type,IntPtr lump,int size);

		[DllImport(Library,EntryPoint = "ilIsValidL",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern bool IsValidL(int type,byte[] lump,int size);

		[DllImport(Library,EntryPoint = "ilKeyColour",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void KeyColour(float red,float green,float blue,float alpha);

		[DllImport(Library,EntryPoint = "ilModAlpha",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void ModAlpha(int alphaValue);

		[DllImport(Library,EntryPoint = "ilOriginFunc",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern bool OriginFunc(int mode);

		[DllImport(Library,EntryPoint = "ilOverlayImage",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern bool OverlayImage(int source,int xCoord,int yCoord,int zCoord);

		[DllImport(Library,EntryPoint = "ilPopAttrib",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void PopAttrib();

		[DllImport(Library,EntryPoint = "ilPushAttrib",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void PushAttrib(int bits);

		[DllImport(Library,EntryPoint = "ilRegisterFormat",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void RegisterFormat(int format);

		[DllImport(Library,EntryPoint = "ilRegisterMipNum",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern bool RegisterMipNum(int num);

		[DllImport(Library,EntryPoint = "ilRegisterNumImages",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern bool RegisterNumImages(int num);

		[DllImport(Library,EntryPoint = "ilRegisterOrigin",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void RegisterOrigin(int origin);

		[DllImport(Library,EntryPoint = "ilRegisterPal",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void RegisterPal(IntPtr pal,int size,int type);

		[DllImport(Library,EntryPoint = "ilRegisterType",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void RegisterType(int type);

		[DllImport(Library,EntryPoint = "ilRemoveLoad",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern bool RemoveLoad(string ext);

		[DllImport(Library,EntryPoint = "ilRemoveSave",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern bool RemoveSave(string ext);

		[DllImport(Library,EntryPoint = "ilResetMemory",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void ResetMemory();

		[DllImport(Library,EntryPoint = "ilResetRead",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void ResetRead();

		[DllImport(Library,EntryPoint = "ilResetWrite",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void ResetWrite();

		[DllImport(Library,EntryPoint = "ilSetAlpha",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void SetAlpha(int alphaValue);

		[DllImport(Library,EntryPoint = "ilSetData",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern bool SetData(IntPtr data);

		[DllImport(Library,EntryPoint = "ilSetDuration",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern bool SetDuration(int duration);

		[DllImport(Library,EntryPoint = "ilSetInteger",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void SetInteger(int mode,int param);

		[DllImport(Library,EntryPoint = "ilSetPixels",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void SetPixels(int xOff,int yOff,int zOff,int width,int height,int depth,int format,int type,IntPtr data);

		[DllImport(Library,EntryPoint = "ilSetString",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void SetString(int mode,string str);

		[DllImport(Library,EntryPoint = "ilShutDown",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern void ShutDown();

		[DllImport(Library,EntryPoint = "ilTexImage",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern bool TexImage(int width,int height,int depth,byte bpp,int format,int type,IntPtr data);

		[DllImport(Library,EntryPoint = "ilTexImage",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern bool TexImage(int width,int height,int depth,byte bpp,int format,int type,byte[] data);

		[DllImport(Library,EntryPoint = "ilTypeFunc",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern bool TypeFunc(int mode);

		[DllImport(Library,EntryPoint = "ilLoadFromJpegStruct",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern bool LoadFromJpegStruct(IntPtr jpegDecompressorPtr);

		[DllImport(Library,EntryPoint = "ilSaveFromJpegStruct",CallingConvention = CC.Cdecl,CharSet = CharSet.Ansi,ExactSpelling = true)]
		public static extern bool SaveFromJpegStruct(IntPtr jpegCompressorPtr);
	}
}
