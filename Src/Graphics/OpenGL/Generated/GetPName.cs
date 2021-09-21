namespace Dissonance.Framework.Graphics.OpenGL
{
	public enum GetPName : uint
	{
		CurrentColor = 0x0B00,
		CurrentIndex = 0x0B01,
		CurrentNormal = 0x0B02,
		CurrentTextureCoords = 0x0B03,
		CurrentRasterColor = 0x0B04,
		CurrentRasterIndex = 0x0B05,
		CurrentRasterTextureCoords = 0x0B06,
		CurrentRasterPosition = 0x0B07,
		CurrentRasterPositionValid = 0x0B08,
		CurrentRasterDistance = 0x0B09,
		PointSmooth = 0x0B10,
		PointSize = 0x0B11,
		PointSizeRange = 0x0B12,
		SmoothPointSizeRange = 0x0B12,
		PointSizeGranularity = 0x0B13,
		SmoothPointSizeGranularity = 0x0B13,
		LineSmooth = 0x0B20,
		LineWidth = 0x0B21,
		LineWidthRange = 0x0B22,
		SmoothLineWidthRange = 0x0B22,
		LineWidthGranularity = 0x0B23,
		SmoothLineWidthGranularity = 0x0B23,
		LineStipple = 0x0B24,
		LineStipplePattern = 0x0B25,
		LineStippleRepeat = 0x0B26,
		ListMode = 0x0B30,
		MaxListNesting = 0x0B31,
		ListBase = 0x0B32,
		ListIndex = 0x0B33,
		PolygonMode = 0x0B40,
		PolygonSmooth = 0x0B41,
		PolygonStipple = 0x0B42,
		EdgeFlag = 0x0B43,
		CullFace = 0x0B44,
		CullFaceMode = 0x0B45,
		FrontFace = 0x0B46,
		Lighting = 0x0B50,
		LightModelLocalViewer = 0x0B51,
		LightModelTwoSide = 0x0B52,
		LightModelAmbient = 0x0B53,
		ShadeModel = 0x0B54,
		ColorMaterialFace = 0x0B55,
		ColorMaterialParameter = 0x0B56,
		ColorMaterial = 0x0B57,
		Fog = 0x0B60,
		FogIndex = 0x0B61,
		FogDensity = 0x0B62,
		FogStart = 0x0B63,
		FogEnd = 0x0B64,
		FogMode = 0x0B65,
		FogColor = 0x0B66,
		DepthRange = 0x0B70,
		DepthTest = 0x0B71,
		DepthWritemask = 0x0B72,
		DepthClearValue = 0x0B73,
		DepthFunc = 0x0B74,
		AccumClearValue = 0x0B80,
		StencilTest = 0x0B90,
		StencilClearValue = 0x0B91,
		StencilFunc = 0x0B92,
		StencilValueMask = 0x0B93,
		StencilFail = 0x0B94,
		StencilPassDepthFail = 0x0B95,
		StencilPassDepthPass = 0x0B96,
		StencilRef = 0x0B97,
		StencilWritemask = 0x0B98,
		MatrixMode = 0x0BA0,
		Normalize = 0x0BA1,
		Viewport = 0x0BA2,
		ModelviewStackDepth = 0x0BA3,
		Modelview0StackDepthExt = 0x0BA3,
		ProjectionStackDepth = 0x0BA4,
		TextureStackDepth = 0x0BA5,
		ModelviewMatrix = 0x0BA6,
		Modelview0MatrixExt = 0x0BA6,
		ProjectionMatrix = 0x0BA7,
		TextureMatrix = 0x0BA8,
		AttribStackDepth = 0x0BB0,
		ClientAttribStackDepth = 0x0BB1,
		AlphaTest = 0x0BC0,
		AlphaTestQcom = 0x0BC0,
		AlphaTestFunc = 0x0BC1,
		AlphaTestFuncQcom = 0x0BC1,
		AlphaTestRef = 0x0BC2,
		AlphaTestRefQcom = 0x0BC2,
		Dither = 0x0BD0,
		BlendDst = 0x0BE0,
		BlendSrc = 0x0BE1,
		Blend = 0x0BE2,
		LogicOpMode = 0x0BF0,
		IndexLogicOp = 0x0BF1,
		LogicOp = 0x0BF1,
		ColorLogicOp = 0x0BF2,
		AuxBuffers = 0x0C00,
		DrawBuffer = 0x0C01,
		DrawBufferExt = 0x0C01,
		ReadBuffer = 0x0C02,
		ReadBufferExt = 0x0C02,
		ReadBufferNv = 0x0C02,
		ScissorBox = 0x0C10,
		ScissorTest = 0x0C11,
		IndexClearValue = 0x0C20,
		IndexWritemask = 0x0C21,
		ColorClearValue = 0x0C22,
		ColorWritemask = 0x0C23,
		IndexMode = 0x0C30,
		RgbaMode = 0x0C31,
		Doublebuffer = 0x0C32,
		Stereo = 0x0C33,
		RenderMode = 0x0C40,
		PerspectiveCorrectionHint = 0x0C50,
		PointSmoothHint = 0x0C51,
		LineSmoothHint = 0x0C52,
		PolygonSmoothHint = 0x0C53,
		FogHint = 0x0C54,
		TextureGenS = 0x0C60,
		TextureGenT = 0x0C61,
		TextureGenR = 0x0C62,
		TextureGenQ = 0x0C63,
		PixelMapIToISize = 0x0CB0,
		PixelMapSToSSize = 0x0CB1,
		PixelMapIToRSize = 0x0CB2,
		PixelMapIToGSize = 0x0CB3,
		PixelMapIToBSize = 0x0CB4,
		PixelMapIToASize = 0x0CB5,
		PixelMapRToRSize = 0x0CB6,
		PixelMapGToGSize = 0x0CB7,
		PixelMapBToBSize = 0x0CB8,
		PixelMapAToASize = 0x0CB9,
		UnpackSwapBytes = 0x0CF0,
		UnpackLsbFirst = 0x0CF1,
		UnpackRowLength = 0x0CF2,
		UnpackSkipRows = 0x0CF3,
		UnpackSkipPixels = 0x0CF4,
		UnpackAlignment = 0x0CF5,
		PackSwapBytes = 0x0D00,
		PackLsbFirst = 0x0D01,
		PackRowLength = 0x0D02,
		PackSkipRows = 0x0D03,
		PackSkipPixels = 0x0D04,
		PackAlignment = 0x0D05,
		MapColor = 0x0D10,
		MapStencil = 0x0D11,
		IndexShift = 0x0D12,
		IndexOffset = 0x0D13,
		RedScale = 0x0D14,
		RedBias = 0x0D15,
		ZoomX = 0x0D16,
		ZoomY = 0x0D17,
		GreenScale = 0x0D18,
		GreenBias = 0x0D19,
		BlueScale = 0x0D1A,
		BlueBias = 0x0D1B,
		AlphaScale = 0x0D1C,
		AlphaBias = 0x0D1D,
		DepthScale = 0x0D1E,
		DepthBias = 0x0D1F,
		MaxEvalOrder = 0x0D30,
		MaxLights = 0x0D31,
		MaxClipPlanes = 0x0D32,
		MaxClipDistances = 0x0D32,
		MaxTextureSize = 0x0D33,
		MaxPixelMapTable = 0x0D34,
		MaxAttribStackDepth = 0x0D35,
		MaxModelviewStackDepth = 0x0D36,
		MaxNameStackDepth = 0x0D37,
		MaxProjectionStackDepth = 0x0D38,
		MaxTextureStackDepth = 0x0D39,
		MaxViewportDims = 0x0D3A,
		MaxClientAttribStackDepth = 0x0D3B,
		SubpixelBits = 0x0D50,
		IndexBits = 0x0D51,
		RedBits = 0x0D52,
		GreenBits = 0x0D53,
		BlueBits = 0x0D54,
		AlphaBits = 0x0D55,
		DepthBits = 0x0D56,
		StencilBits = 0x0D57,
		AccumRedBits = 0x0D58,
		AccumGreenBits = 0x0D59,
		AccumBlueBits = 0x0D5A,
		AccumAlphaBits = 0x0D5B,
		NameStackDepth = 0x0D70,
		AutoNormal = 0x0D80,
		Map1Color4 = 0x0D90,
		Map1Index = 0x0D91,
		Map1Normal = 0x0D92,
		Map1TextureCoord1 = 0x0D93,
		Map1TextureCoord2 = 0x0D94,
		Map1TextureCoord3 = 0x0D95,
		Map1TextureCoord4 = 0x0D96,
		Map1Vertex3 = 0x0D97,
		Map1Vertex4 = 0x0D98,
		Map2Color4 = 0x0DB0,
		Map2Index = 0x0DB1,
		Map2Normal = 0x0DB2,
		Map2TextureCoord1 = 0x0DB3,
		Map2TextureCoord2 = 0x0DB4,
		Map2TextureCoord3 = 0x0DB5,
		Map2TextureCoord4 = 0x0DB6,
		Map2Vertex3 = 0x0DB7,
		Map2Vertex4 = 0x0DB8,
		Map1GridDomain = 0x0DD0,
		Map1GridSegments = 0x0DD1,
		Map2GridDomain = 0x0DD2,
		Map2GridSegments = 0x0DD3,
		Texture1d = 0x0DE0,
		Texture2d = 0x0DE1,
		FeedbackBufferSize = 0x0DF1,
		FeedbackBufferType = 0x0DF2,
		SelectionBufferSize = 0x0DF4,
		PolygonOffsetUnits = 0x2A00,
		PolygonOffsetPoint = 0x2A01,
		PolygonOffsetLine = 0x2A02,
		ClipPlane0 = 0x3000,
		ClipPlane1 = 0x3001,
		ClipPlane2 = 0x3002,
		ClipPlane3 = 0x3003,
		ClipPlane4 = 0x3004,
		ClipPlane5 = 0x3005,
		Light0 = 0x4000,
		Light1 = 0x4001,
		Light2 = 0x4002,
		Light3 = 0x4003,
		Light4 = 0x4004,
		Light5 = 0x4005,
		Light6 = 0x4006,
		Light7 = 0x4007,
		BlendColor = 0x8005,
		BlendColorExt = 0x8005,
		BlendEquationExt = 0x8009,
		BlendEquationRgb = 0x8009,
		PackCmykHintExt = 0x800E,
		UnpackCmykHintExt = 0x800F,
		Convolution1dExt = 0x8010,
		Convolution2dExt = 0x8011,
		Separable2dExt = 0x8012,
		PostConvolutionRedScaleExt = 0x801C,
		PostConvolutionGreenScaleExt = 0x801D,
		PostConvolutionBlueScaleExt = 0x801E,
		PostConvolutionAlphaScaleExt = 0x801F,
		PostConvolutionRedBiasExt = 0x8020,
		PostConvolutionGreenBiasExt = 0x8021,
		PostConvolutionBlueBiasExt = 0x8022,
		PostConvolutionAlphaBiasExt = 0x8023,
		HistogramExt = 0x8024,
		MinmaxExt = 0x802E,
		PolygonOffsetFill = 0x8037,
		PolygonOffsetFactor = 0x8038,
		PolygonOffsetBiasExt = 0x8039,
		RescaleNormalExt = 0x803A,
		TextureBinding1d = 0x8068,
		TextureBinding2d = 0x8069,
		Texture3dBindingExt = 0x806A,
		TextureBinding3d = 0x806A,
		PackSkipImages = 0x806B,
		PackSkipImagesExt = 0x806B,
		PackImageHeight = 0x806C,
		PackImageHeightExt = 0x806C,
		UnpackSkipImages = 0x806D,
		UnpackSkipImagesExt = 0x806D,
		UnpackImageHeight = 0x806E,
		UnpackImageHeightExt = 0x806E,
		Texture3dExt = 0x806F,
		Max3dTextureSize = 0x8073,
		Max3dTextureSizeExt = 0x8073,
		VertexArray = 0x8074,
		NormalArray = 0x8075,
		ColorArray = 0x8076,
		IndexArray = 0x8077,
		TextureCoordArray = 0x8078,
		EdgeFlagArray = 0x8079,
		VertexArraySize = 0x807A,
		VertexArrayType = 0x807B,
		VertexArrayStride = 0x807C,
		VertexArrayCountExt = 0x807D,
		NormalArrayType = 0x807E,
		NormalArrayStride = 0x807F,
		NormalArrayCountExt = 0x8080,
		ColorArraySize = 0x8081,
		ColorArrayType = 0x8082,
		ColorArrayStride = 0x8083,
		ColorArrayCountExt = 0x8084,
		IndexArrayType = 0x8085,
		IndexArrayStride = 0x8086,
		IndexArrayCountExt = 0x8087,
		TextureCoordArraySize = 0x8088,
		TextureCoordArrayType = 0x8089,
		TextureCoordArrayStride = 0x808A,
		TextureCoordArrayCountExt = 0x808B,
		EdgeFlagArrayStride = 0x808C,
		EdgeFlagArrayCountExt = 0x808D,
		InterlaceSgix = 0x8094,
		DetailTexture2dBindingSgis = 0x8096,
		MultisampleSgis = 0x809D,
		SampleAlphaToMaskSgis = 0x809E,
		SampleAlphaToOneSgis = 0x809F,
		SampleMaskSgis = 0x80A0,
		SampleBuffers = 0x80A8,
		SampleBuffersSgis = 0x80A8,
		Samples = 0x80A9,
		SamplesSgis = 0x80A9,
		SampleCoverageValue = 0x80AA,
		SampleMaskValueSgis = 0x80AA,
		SampleCoverageInvert = 0x80AB,
		SampleMaskInvertSgis = 0x80AB,
		SamplePatternSgis = 0x80AC,
		ColorMatrixSgi = 0x80B1,
		ColorMatrixStackDepthSgi = 0x80B2,
		MaxColorMatrixStackDepthSgi = 0x80B3,
		PostColorMatrixRedScaleSgi = 0x80B4,
		PostColorMatrixGreenScaleSgi = 0x80B5,
		PostColorMatrixBlueScaleSgi = 0x80B6,
		PostColorMatrixAlphaScaleSgi = 0x80B7,
		PostColorMatrixRedBiasSgi = 0x80B8,
		PostColorMatrixGreenBiasSgi = 0x80B9,
		PostColorMatrixBlueBiasSgi = 0x80BA,
		PostColorMatrixAlphaBiasSgi = 0x80BB,
		TextureColorTableSgi = 0x80BC,
		BlendDstRgb = 0x80C8,
		BlendSrcRgb = 0x80C9,
		BlendDstAlpha = 0x80CA,
		BlendSrcAlpha = 0x80CB,
		ColorTableSgi = 0x80D0,
		PostConvolutionColorTableSgi = 0x80D1,
		PostColorMatrixColorTableSgi = 0x80D2,
		MaxElementsVertices = 0x80E8,
		MaxElementsIndices = 0x80E9,
		PointSizeMinSgis = 0x8126,
		PointSizeMaxSgis = 0x8127,
		PointFadeThresholdSize = 0x8128,
		PointFadeThresholdSizeSgis = 0x8128,
		DistanceAttenuationSgis = 0x8129,
		FogFuncPointsSgis = 0x812B,
		MaxFogFuncPointsSgis = 0x812C,
		PackSkipVolumesSgis = 0x8130,
		PackImageDepthSgis = 0x8131,
		UnpackSkipVolumesSgis = 0x8132,
		UnpackImageDepthSgis = 0x8133,
		Texture4dSgis = 0x8134,
		Max4dTextureSizeSgis = 0x8138,
		PixelTexGenSgix = 0x8139,
		PixelTileBestAlignmentSgix = 0x813E,
		PixelTileCacheIncrementSgix = 0x813F,
		PixelTileWidthSgix = 0x8140,
		PixelTileHeightSgix = 0x8141,
		PixelTileGridWidthSgix = 0x8142,
		PixelTileGridHeightSgix = 0x8143,
		PixelTileGridDepthSgix = 0x8144,
		PixelTileCacheSizeSgix = 0x8145,
		SpriteSgix = 0x8148,
		SpriteModeSgix = 0x8149,
		SpriteAxisSgix = 0x814A,
		SpriteTranslationSgix = 0x814B,
		Texture4dBindingSgis = 0x814F,
		MaxClipmapDepthSgix = 0x8177,
		MaxClipmapVirtualDepthSgix = 0x8178,
		PostTextureFilterBiasRangeSgix = 0x817B,
		PostTextureFilterScaleRangeSgix = 0x817C,
		ReferencePlaneSgix = 0x817D,
		ReferencePlaneEquationSgix = 0x817E,
		IrInstrument1Sgix = 0x817F,
		InstrumentMeasurementsSgix = 0x8181,
		CalligraphicFragmentSgix = 0x8183,
		FramezoomSgix = 0x818B,
		FramezoomFactorSgix = 0x818C,
		MaxFramezoomFactorSgix = 0x818D,
		GenerateMipmapHintSgis = 0x8192,
		DeformationsMaskSgix = 0x8196,
		FogOffsetSgix = 0x8198,
		FogOffsetValueSgix = 0x8199,
		LightModelColorControl = 0x81F8,
		SharedTexturePaletteExt = 0x81FB,
		MajorVersion = 0x821B,
		MinorVersion = 0x821C,
		NumExtensions = 0x821D,
		ContextFlags = 0x821E,
		ProgramPipelineBinding = 0x825A,
		MaxViewports = 0x825B,
		ViewportSubpixelBits = 0x825C,
		ViewportBoundsRange = 0x825D,
		LayerProvokingVertex = 0x825E,
		ViewportIndexProvokingVertex = 0x825F,
		MaxComputeUniformComponents = 0x8263,
		MaxComputeAtomicCounterBuffers = 0x8264,
		MaxComputeAtomicCounters = 0x8265,
		MaxCombinedComputeUniformComponents = 0x8266,
		MaxDebugGroupStackDepth = 0x826C,
		DebugGroupStackDepth = 0x826D,
		MaxUniformLocations = 0x826E,
		VertexBindingDivisor = 0x82D6,
		VertexBindingOffset = 0x82D7,
		VertexBindingStride = 0x82D8,
		MaxVertexAttribRelativeOffset = 0x82D9,
		MaxVertexAttribBindings = 0x82DA,
		MaxLabelLength = 0x82E8,
		ConvolutionHintSgix = 0x8316,
		AsyncMarkerSgix = 0x8329,
		PixelTexGenModeSgix = 0x832B,
		AsyncHistogramSgix = 0x832C,
		MaxAsyncHistogramSgix = 0x832D,
		PixelTextureSgis = 0x8353,
		AsyncTexImageSgix = 0x835C,
		AsyncDrawPixelsSgix = 0x835D,
		AsyncReadPixelsSgix = 0x835E,
		MaxAsyncTexImageSgix = 0x835F,
		MaxAsyncDrawPixelsSgix = 0x8360,
		MaxAsyncReadPixelsSgix = 0x8361,
		VertexPreclipSgix = 0x83EE,
		VertexPreclipHintSgix = 0x83EF,
		FragmentLightingSgix = 0x8400,
		FragmentColorMaterialSgix = 0x8401,
		FragmentColorMaterialFaceSgix = 0x8402,
		FragmentColorMaterialParameterSgix = 0x8403,
		MaxFragmentLightsSgix = 0x8404,
		MaxActiveLightsSgix = 0x8405,
		LightEnvModeSgix = 0x8407,
		FragmentLightModelLocalViewerSgix = 0x8408,
		FragmentLightModelTwoSideSgix = 0x8409,
		FragmentLightModelAmbientSgix = 0x840A,
		FragmentLightModelNormalInterpolationSgix = 0x840B,
		FragmentLight0Sgix = 0x840C,
		PackResampleSgix = 0x842E,
		UnpackResampleSgix = 0x842F,
		AliasedPointSizeRange = 0x846D,
		AliasedLineWidthRange = 0x846E,
		ActiveTexture = 0x84E0,
		MaxRenderbufferSize = 0x84E8,
		TextureCompressionHint = 0x84EF,
		TextureBindingRectangle = 0x84F6,
		MaxRectangleTextureSize = 0x84F8,
		MaxTextureLodBias = 0x84FD,
		TextureBindingCubeMap = 0x8514,
		MaxCubeMapTextureSize = 0x851C,
		PackSubsampleRateSgix = 0x85A0,
		UnpackSubsampleRateSgix = 0x85A1,
		VertexArrayBinding = 0x85B5,
		ProgramPointSize = 0x8642,
		NumCompressedTextureFormats = 0x86A2,
		CompressedTextureFormats = 0x86A3,
		NumProgramBinaryFormats = 0x87FE,
		ProgramBinaryFormats = 0x87FF,
		StencilBackFunc = 0x8800,
		StencilBackFail = 0x8801,
		StencilBackPassDepthFail = 0x8802,
		StencilBackPassDepthPass = 0x8803,
		MaxDrawBuffers = 0x8824,
		BlendEquationAlpha = 0x883D,
		MaxVertexAttribs = 0x8869,
		MaxTextureImageUnits = 0x8872,
		ArrayBufferBinding = 0x8894,
		ElementArrayBufferBinding = 0x8895,
		PixelPackBufferBinding = 0x88ED,
		PixelUnpackBufferBinding = 0x88EF,
		MaxDualSourceDrawBuffers = 0x88FC,
		MaxArrayTextureLayers = 0x88FF,
		MinProgramTexelOffset = 0x8904,
		MaxProgramTexelOffset = 0x8905,
		SamplerBinding = 0x8919,
		UniformBufferBinding = 0x8A28,
		UniformBufferStart = 0x8A29,
		UniformBufferSize = 0x8A2A,
		MaxVertexUniformBlocks = 0x8A2B,
		MaxGeometryUniformBlocks = 0x8A2C,
		MaxFragmentUniformBlocks = 0x8A2D,
		MaxCombinedUniformBlocks = 0x8A2E,
		MaxUniformBufferBindings = 0x8A2F,
		MaxUniformBlockSize = 0x8A30,
		MaxCombinedVertexUniformComponents = 0x8A31,
		MaxCombinedGeometryUniformComponents = 0x8A32,
		MaxCombinedFragmentUniformComponents = 0x8A33,
		UniformBufferOffsetAlignment = 0x8A34,
		MaxFragmentUniformComponents = 0x8B49,
		MaxVertexUniformComponents = 0x8B4A,
		MaxVaryingFloats = 0x8B4B,
		MaxVaryingComponents = 0x8B4B,
		MaxVertexTextureImageUnits = 0x8B4C,
		MaxCombinedTextureImageUnits = 0x8B4D,
		FragmentShaderDerivativeHint = 0x8B8B,
		CurrentProgram = 0x8B8D,
		ImplementationColorReadType = 0x8B9A,
		ImplementationColorReadFormat = 0x8B9B,
		TextureBinding1dArray = 0x8C1C,
		TextureBinding2dArray = 0x8C1D,
		MaxGeometryTextureImageUnits = 0x8C29,
		MaxTextureBufferSize = 0x8C2B,
		TextureBindingBuffer = 0x8C2C,
		TransformFeedbackBufferStart = 0x8C84,
		TransformFeedbackBufferSize = 0x8C85,
		TransformFeedbackBufferBinding = 0x8C8F,
		MotionEstimationSearchBlockXQcom = 0x8C90,
		MotionEstimationSearchBlockYQcom = 0x8C91,
		StencilBackRef = 0x8CA3,
		StencilBackValueMask = 0x8CA4,
		StencilBackWritemask = 0x8CA5,
		DrawFramebufferBinding = 0x8CA6,
		RenderbufferBinding = 0x8CA7,
		ReadFramebufferBinding = 0x8CAA,
		MaxElementIndex = 0x8D6B,
		MaxGeometryUniformComponents = 0x8DDF,
		ShaderBinaryFormats = 0x8DF8,
		NumShaderBinaryFormats = 0x8DF9,
		ShaderCompiler = 0x8DFA,
		MaxVertexUniformVectors = 0x8DFB,
		MaxVaryingVectors = 0x8DFC,
		MaxFragmentUniformVectors = 0x8DFD,
		Timestamp = 0x8E28,
		ProvokingVertex = 0x8E4F,
		MaxSampleMaskWords = 0x8E59,
		MaxTessControlUniformBlocks = 0x8E89,
		MaxTessEvaluationUniformBlocks = 0x8E8A,
		FetchPerSampleArm = 0x8F65,
		FragmentShaderFramebufferFetchMrtArm = 0x8F66,
		PrimitiveRestartIndex = 0x8F9E,
		MinMapBufferAlignment = 0x90BC,
		ShaderStorageBufferBinding = 0x90D3,
		ShaderStorageBufferStart = 0x90D4,
		ShaderStorageBufferSize = 0x90D5,
		MaxVertexShaderStorageBlocks = 0x90D6,
		MaxGeometryShaderStorageBlocks = 0x90D7,
		MaxTessControlShaderStorageBlocks = 0x90D8,
		MaxTessEvaluationShaderStorageBlocks = 0x90D9,
		MaxFragmentShaderStorageBlocks = 0x90DA,
		MaxComputeShaderStorageBlocks = 0x90DB,
		MaxCombinedShaderStorageBlocks = 0x90DC,
		MaxShaderStorageBufferBindings = 0x90DD,
		ShaderStorageBufferOffsetAlignment = 0x90DF,
		MaxComputeWorkGroupInvocations = 0x90EB,
		DispatchIndirectBufferBinding = 0x90EF,
		TextureBinding2dMultisample = 0x9104,
		TextureBinding2dMultisampleArray = 0x9105,
		MaxColorTextureSamples = 0x910E,
		MaxDepthTextureSamples = 0x910F,
		MaxIntegerSamples = 0x9110,
		MaxServerWaitTimeout = 0x9111,
		MaxVertexOutputComponents = 0x9122,
		MaxGeometryInputComponents = 0x9123,
		MaxGeometryOutputComponents = 0x9124,
		MaxFragmentInputComponents = 0x9125,
		ContextProfileMask = 0x9126,
		TextureBufferOffsetAlignment = 0x919F,
		MaxComputeUniformBlocks = 0x91BB,
		MaxComputeTextureImageUnits = 0x91BC,
		MaxComputeWorkGroupCount = 0x91BE,
		MaxComputeWorkGroupSize = 0x91BF,
		MaxVertexAtomicCounters = 0x92D2,
		MaxTessControlAtomicCounters = 0x92D3,
		MaxTessEvaluationAtomicCounters = 0x92D4,
		MaxGeometryAtomicCounters = 0x92D5,
		MaxFragmentAtomicCounters = 0x92D6,
		MaxCombinedAtomicCounters = 0x92D7,
		MaxFramebufferWidth = 0x9315,
		MaxFramebufferHeight = 0x9316,
		MaxFramebufferLayers = 0x9317,
		MaxFramebufferSamples = 0x9318,
		NumDeviceUuidsExt = 0x9596,
		DeviceUuidExt = 0x9597,
		DriverUuidExt = 0x9598,
		DeviceLuidExt = 0x9599,
		DeviceNodeMaskExt = 0x959A,
		ShadingRateImagePerPrimitiveNv = 0x95B1,
		ShadingRateImagePaletteCountNv = 0x95B2,
		MaxTimelineSemaphoreValueDifferenceNv = 0x95B6,
		ShadingRateQcom = 0x96A4,
	}
}

