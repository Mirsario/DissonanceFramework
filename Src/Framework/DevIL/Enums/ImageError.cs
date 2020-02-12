namespace Dissonance.Framework.DevIL
{
	public enum ImageError
	{
		NoError = 0,
		InvalidEnum = 1281,
		OutofMemory = 1282,
		FormatNotSupported = 1283,
		InternalError = 1284,
		InvalidValue = 1285,
		IllegalOperation = 1286,
		IllegalFileValue = 1287,
		InvalidFileHeader = 1288,
		InvalidParam = 1289,
		CouldNotOpenFile = 1290,
		InvalidExtension = 1291,
		FileAlreadyExists = 1292,
		OutFormatSame = 1293,
		StackOverflow = 1294,
		StackUnderflow = 1295,
		InvalidConversion = 1296,
		BadDimensions = 1297,
		FileReadError = 1298,
		FileWriteError = 1298,
		UnknownError = 1535,

		//Format-specific

		LibGifError = 1505,
		LibJpegError = 1506,
		LibPngError = 1507,
		LibTiffError = 1508,
		LibMngError = 1509,
	}
}
