namespace TS3D.Exchange.Direct
{
    public enum A3DEEntityType
    {
        kA3DTypeUnknown = -1,
        kA3DTypeRootBase = 1,
        kA3DTypeRootBaseWithGraphics = 2,
        kA3DTypeTopoContext = 141,
        kA3DTypeTopoItem = 142,
        kA3DTypeTopoMultipleVertex = 143,
        kA3DTypeTopoUniqueVertex = 144,
        kA3DTypeTopoWireEdge = 145,
        kA3DTypeTopoEdge = 146,
        kA3DTypeTopoCoEdge = 147,
        kA3DTypeTopoLoop = 148,
        kA3DTypeTopoFace = 149,
        kA3DTypeTopoShell = 150,
        kA3DTypeTopoConnex = 151,
        kA3DTypeTopoBody = 152,
        kA3DTypeTopoSingleWireBody = 153,
        kA3DTypeTopoBrepData = 154,
        kA3DTypeTopoWireBody = 157,
        kA3DTypeTessBase = 171,
        kA3DTypeTess3D = 172,
        kA3DTypeTessFace = 174,
        kA3DTypeTess3DWire = 175,
        kA3DTypeTessMarkup = 176,
        kA3DTypeTessEdge = 177,
        kA3DTypeTessVertex = 178,
        kA3DTypeMiscAttribute = 201,
        kA3DTypeMiscCartesianTransformation = 202,
        kA3DTypeMiscEntityReference = 203,
        kA3DTypeMiscMarkupLinkedItem = 204,
        kA3DTypeMiscReferenceOnTopology = 206,
        kA3DTypeMiscGeneralTransformation = 207,
        kA3DTypeMiscReferenceOnCsysItem = 208,
        kA3DTypeMiscPKMapper = 209,
        kA3DTypeRiRepresentationItem = 231,
        kA3DTypeRiBrepModel = 232,
        kA3DTypeRiCurve = 233,
        kA3DTypeRiDirection = 234,
        kA3DTypeRiPlane = 235,
        kA3DTypeRiPointSet = 236,
        kA3DTypeRiPolyBrepModel = 237,
        kA3DTypeRiPolyWire = 238,
        kA3DTypeRiSet = 239,
        kA3DTypeRiCoordinateSystem = 240,
        kA3DTypeRiCoordinateSystemItem = 241,
        kA3DTypeAsmModelFile = 301,
        kA3DTypeAsmProductOccurrence = 310,
        kA3DTypeAsmPartDefinition = 311,
        kA3DTypeAsmFilter = 320,
        kA3DTypeMkpView = 501,
        kA3DTypeMkpMarkup = 502,
        kA3DTypeMkpLeader = 503,
        kA3DTypeMkpAnnotationItem = 504,
        kA3DTypeMkpAnnotationSet = 505,
        kA3DTypeMkpAnnotationReference = 506,
        kA3DTypeMDPosition3D = 10101,
        kA3DTypeMDPosition2D = 10102,
        kA3DTypeMDPositionReference = 10103,
        kA3DTypeMDLeaderSymbol = 10104,
        kA3DTypeMDTextProperties = 10105,
        kA3DTypeMDTextPosition = 10106,
        kA3DTypeMDLeaderDefinition = 10107,
        kA3DTypeMDMarkupLeaderStub = 10108,
        kA3DTypeMarkupText = 10111,
        kA3DTypeMarkupRichText = 10112,
        kA3DTypeMarkupCoordinate = 10113,
        kA3DTypeMarkupBalloon = 10114,
        kA3DTypeMarkupDatum = 10115,
        kA3DTypeMarkupGDT = 10116,
        kA3DTypeMarkupRoughness = 10117,
        kA3DTypeMarkupDimension = 10118,
        kA3DTypeMarkupLocator = 10119,
        kA3DTypeMarkupMeasurementPoint = 10120,
        kA3DTypeMarkupFastener = 10121,
        kA3DTypeMarkupSpotWelding = 10122,
        kA3DTypeMarkupLineWelding = 10123,
        kA3DTypeMDDimensionValue = 10130,
        kA3DTypeMDDimensionToleranceFormat = 10131,
        kA3DTypeMDDimensionSimpleToleranceFormat = 10132,
        kA3DTypeMDDimensionCombinedToleranceFormat = 10133,
        kA3DTypeMDDimensionValueFormat = 10134,
        kA3DTypeMDDimensionFunnel = 10135,
        kA3DTypeMDDimensionExtentionLine = 10136,
        kA3DTypeMDDimensionLineSymbol = 10137,
        kA3DTypeMDDimensionLine = 10138,
        kA3DTypeMDDimensionSecondPart = 10139,
        kA3DTypeMDFeatureControlFrame = 10140,
        kA3DTypeMDFCFRow = 10141,
        kA3DTypeMDFCFDrawingRow = 10142,
        kA3DTypeMDFCFDraftingRow = 10143,
        kA3DTypeMDFCFRowDatum = 10144,
        kA3DTypeMDToleranceSize = 10145,
        kA3DTypeMDToleranceSizeValue = 10146,
        kA3DTypeMDFCFIndicator = 10147,
        kA3DTypeGraphStyle = 701,
        kA3DTypeGraphMaterial = 702,
        kA3DTypeGraphPicture = 703,
        kA3DTypeGraphTextureApplication = 711,
        kA3DTypeGraphTextureDefinition = 712,
        kA3DTypeGraphTextureTransformation = 713,
        kA3DTypeGraphLinePattern = 721,
        kA3DTypeGraphFillPattern = 722,
        kA3DTypeGraphDottingPattern = 723,
        kA3DTypeGraphHatchingPattern = 724,
        kA3DTypeGraphSolidPattern = 725,
        kA3DTypeGraphVPicturePattern = 726,
        kA3DTypeGraphAmbientLight = 731,
        kA3DTypeGraphPointLight = 732,
        kA3DTypeGraphDirectionalLight = 733,
        kA3DTypeGraphSpotLight = 734,
        kA3DTypeGraphSceneDisplayParameters = 741,
        kA3DTypeGraphCamera = 742,
        kA3DTypeCrvBase = 11,
        kA3DTypeCrvBlend02Boundary = 12,
        kA3DTypeCrvNurbs = 13,
        kA3DTypeCrvCircle = 14,
        kA3DTypeCrvComposite = 15,
        kA3DTypeCrvOnSurf = 16,
        kA3DTypeCrvEllipse = 17,
        kA3DTypeCrvEquation = 18,
        kA3DTypeCrvHelix = 19,
        kA3DTypeCrvHyperbola = 20,
        kA3DTypeCrvIntersection = 21,
        kA3DTypeCrvLine = 22,
        kA3DTypeCrvOffset = 23,
        kA3DTypeCrvParabola = 24,
        kA3DTypeCrvPolyLine = 25,
        kA3DTypeCrvTransform = 26,
        kA3DTypeSurfBase = 76,
        kA3DTypeSurfBlend01 = 77,
        kA3DTypeSurfBlend02 = 78,
        kA3DTypeSurfBlend03 = 79,
        kA3DTypeSurfNurbs = 80,
        kA3DTypeSurfCone = 81,
        kA3DTypeSurfCylinder = 82,
        kA3DTypeSurfCylindrical = 83,
        kA3DTypeSurfOffset = 84,
        kA3DTypeSurfPipe = 85,
        kA3DTypeSurfPlane = 86,
        kA3DTypeSurfRuled = 87,
        kA3DTypeSurfSphere = 88,
        kA3DTypeSurfRevolution = 89,
        kA3DTypeSurfExtrusion = 90,
        kA3DTypeSurfFromCurves = 91,
        kA3DTypeSurfTorus = 92,
        kA3DTypeSurfTransform = 93,
        kA3DTypeSurfBlend04 = 94,
        kA3DTypeMathFct1D = 901,
        kA3DTypeMathFct1DPolynom = 902,
        kA3DTypeMathFct1DTrigonometric = 903,
        kA3DTypeMathFct1DFraction = 904,
        kA3DTypeMathFct1DArctanCos = 905,
        kA3DTypeMathFct1DCombination = 906,
        kA3DTypeMathFct3D = 910,
        kA3DTypeMathFct3DLinear = 911,
        kA3DTypeMathFct3DNonLinear = 912,
        kA3DTypeDrawingModel = 1301,
        kA3DTypeDrawingSheet = 1302,
        kA3DTypeDrawingSheetFormat = 1303,
        kA3DTypeDrawingView = 1304,
        kA3DTypeDrawingClipFrame = 1305,
        kA3DTypeDrawingBlock = 1306,
        kA3DTypeDrawingBlockBasic = 1307,
        kA3DTypeDrawingBlockOperator = 1308,
        kA3DTypeDrawingEntity = 1310,
        kA3DTypeDrawingFilledArea = 1311,
        kA3DTypeDrawingPicture = 1312,
        kA3DTypeDrawingVertices = 1313,
        kA3DTypeDrawingCurve = 1314,
        kA3DTypeFRMFeature = 2001,
        kA3DTypeFRMFeatureLinkedItem = 2002,
        kA3DTypeFRMFeatureParameter = 2003
}

    public enum A3DETextureMappingOperator
    {
        kA3DTextureMappingOperatorUnknown = 0,
        kA3DTextureMappingOperatorPlanar = 1,
        kA3DTextureMappingOperatorCylindrical = 2,
        kA3DTextureMappingOperatorSpherical = 3,
        kA3DTextureMappingOperatorCubical = 4
}

    public enum A3DETextureMappingType
    {
        kA3DTextureMappingTypeUnknown = 0,
        kA3DTextureMappingTypeStored = 1,
        kA3DTextureMappingTypeParametric = 2,
        kA3DTextureMappingTypeOperator = 3
}

    public enum A3DETextureFunction
    {
        kA3DTextureFunctionUnknown = 0,
        kA3DTextureFunctionModulate = 1,
        kA3DTextureFunctionReplace = 2,
        kA3DTextureFunctionBlend = 3,
        kA3DTextureFunctionDecal = 4
}

    public enum A3DETextureBlendParameter
    {
        kA3DTextureBlendParameterUnknown = 0,
        kA3DTextureBlendParameterZero = 1,
        kA3DTextureBlendParameterOne = 2,
        kA3DTextureBlendParameterSrcColor = 3,
        kA3DTextureBlendParameterOneMinusSrcColor = 4,
        kA3DTextureBlendParameterDstColor = 5,
        kA3DTextureBlendParameterOneMinusDstColor = 6,
        kA3DTextureBlendParameterSrcAlpha = 7,
        kA3DTextureBlendParameterOneMinusSrcAlpha = 8,
        kA3DTextureBlendParameterDstAlpha = 9,
        kA3DTextureBlendParameterOneMinusDstAlpha = 10,
        kA3DTextureBlendParameterSrcAlphaSaturate = 11
}

    public enum A3DETextureAlphaMode
    {
        A3DETextureAlphaModeNone = 0,
        A3DETextureAlphaModeOpaque = 1,
        A3DETextureAlphaModeMask = 2,
        A3DETextureAlphaModeBlend = 3
}

    public enum A3DETextureAlphaTest
    {
        kA3DTextureAlphaTestUnknown = 0,
        kA3DTextureAlphaTestNever = 1,
        kA3DTextureAlphaTestLess = 2,
        kA3DTextureAlphaTestEqual = 3,
        kA3DTextureAlphaTestLequal = 4,
        kA3DTextureAlphaTestGreater = 5,
        kA3DTextureAlphaTestNotequal = 6,
        kA3DTextureAlphaTestGequal = 7,
        kA3DTextureAlphaTestAlways = 8
}

    public enum A3DETextureWrappingMode
    {
        kA3DTextureWrappingModeUnknown = 0,
        kA3DTextureWrappingModeRepeat = 1,
        kA3DTextureWrappingModeClampToBorder = 2,
        kA3DTextureWrappingModeClamp = 3,
        kA3DTextureWrappingModeClampToEdge = 4,
        kA3DTextureWrappingModeMirroredRepeat = 5
}

    public enum A3DEModellerType
    {
        kA3DModellerUnknown = 0,
        kA3DModellerCatia = 2,
        kA3DModellerCatiaV5 = 3,
        kA3DModellerCadds = 4,
        kA3DModellerUnigraphics = 5,
        kA3DModellerParasolid = 6,
        kA3DModellerEuclid = 7,
        kA3DModellerIges = 9,
        kA3DModellerUnisurf = 10,
        kA3DModellerVda = 11,
        kA3DModellerStl = 12,
        kA3DModellerWrl = 13,
        kA3DModellerDxf = 14,
        kA3DModellerAcis = 15,
        kA3DModellerProE = 16,
        kA3DModellerStep = 18,
        kA3DModellerIdeas = 19,
        kA3DModellerJt = 20,
        kA3DModellerSlw = 22,
        kA3DModellerCgr = 23,
        kA3DModellerPrc = 24,
        kA3DModellerXvl = 25,
        kA3DModellerHpgl = 26,
        kA3DModellerTopSolid = 27,
        kA3DModellerOneSpaceDesigner = 28,
        kA3DModeller3dxml = 29,
        kA3DModellerInventor = 30,
        kA3DModellerPostScript = 31,
        kA3DModellerPDF = 32,
        kA3DModellerU3D = 33,
        kA3DModellerIFC = 34,
        kA3DModellerDWG = 35,
        kA3DModellerDWF = 36,
        kA3DModellerSE = 37,
        kA3DModellerOBJ = 38,
        kA3DModellerKMZ = 39,
        kA3DModellerDAE = 40,
        kA3DModeller3DS = 41,
        kA3DModellerRhino = 43,
        kA3DModellerXML = 44,
        kA3DModeller3mf = 45,
        kA3DModellerScs = 46,
        kA3DModeller3dHtml = 47,
        kA3DModellerHsf = 48,
        kA3DModellerGltf = 49,
        kA3DModellerRevit = 50,
        kA3DModellerFBX = 51,
        kA3DModellerStepXML = 52,
        kA3DModellerPLMXML = 53,
        kA3DModellerLast = 54
}

    public enum A3DEProductLoadStatus
    {
        kA3DProductLoadStatusUnknown = 0,
        kA3DProductLoadStatusError = 1,
        kA3DProductLoadStatusNotLoaded = 2,
        kA3DProductLoadStatusNotLoadable = 3,
        kA3DProductLoadStatusLoaded = 4
}

    public enum A3DEProductOccurrenceTypeCat
    {
        A3DEProductOccurrenceTypeCat_unknown = -1,
        A3DEProductOccurrenceTypeCat_model = 0,
        A3DEProductOccurrenceTypeCat_sessionModel = 1,
        A3DEProductOccurrenceTypeCat_session = 2,
        A3DEProductOccurrenceTypeCat_export = 3
}

    public enum A3DEProductOccurrenceTypeInv
    {
        A3DEProductOccurrenceTypeInv_none = 0,
        A3DEProductOccurrenceTypeInv_iam = 1,
        A3DEProductOccurrenceTypeInv_ipt = 2
}

    public enum A3DEProductOccurrenceTypeSLW
    {
        A3DEProductOccurrenceTypeSLW_ContainerTess = -2,
        A3DEProductOccurrenceTypeSLW_Container = -1,
        A3DEProductOccurrenceTypeSLW_Part = 0,
        A3DEProductOccurrenceTypeSLW_Assembly = 1,
        A3DEProductOccurrenceTypeSLW_Drawing = 2,
        A3DEProductOccurrenceTypeSLW_Unknown = 3,
        A3DEProductOccurrenceTypeSLW_PartTesselated = 4,
        A3DEProductOccurrenceTypeSLW_AssemblyTesselated = 5,
        A3DEProductOccurrenceTypeSLW_StandalonePart = 6
}

    public enum A3DEModellerAttributeType
    {
        kA3DModellerAttributeTypeNull = 0,
        kA3DModellerAttributeTypeInt = 1,
        kA3DModellerAttributeTypeReal = 2,
        kA3DModellerAttributeTypeTime = 3,
        kA3DModellerAttributeTypeString = 4
}

    public enum A3DEReadGeomTessMode
    {
        kA3DReadGeomOnly = 0,
        kA3DReadGeomAndTess = 1,
        kA3DReadTessOnly = 2
}

    public enum A3DEWriteGeomTessMode
    {
        kA3DWriteGeomOnly = 0,
        kA3DWriteGeomAndTess = 1,
        kA3DWriteTessOnly = 2
}

    public enum A3DEUnits
    {
        kA3DUnitPoint = 0,
        kA3DUnitInch = 1,
        kA3DUnitMillimeter = 2,
        kA3DUnitCentimeter = 3,
        kA3DUnitPicas = 4,
        kA3DUnitFoot = 5,
        kA3DUnitYard = 6,
        kA3DUnitMeter = 7,
        kA3DUnitKilometer = 8,
        kA3DUnitMile = 9,
        kA3DUnitUnknown = 10
}

    public enum A3DETessellationLevelOfDetail
    {
        kA3DTessLODExtraLow = 0,
        kA3DTessLODLow = 1,
        kA3DTessLODMedium = 2,
        kA3DTessLODHigh = 3,
        kA3DTessLODExtraHigh = 4,
        kA3DTessLODUserDefined = 5,
        kA3DTessLODControlledPrecision = 6
}

    public enum A3DProESessionColorType
    {
        kA3DLastCreoVersionSessionColor = 0,
        kA3DHExchangeSessionColor = 1,
        kA3DFileVersionSessionColor = 2
}

    public enum A3DProEReadConstructEntities
    {
        A3DProEReadConstructEntities_AsDatum = 0,
        A3DProEReadConstructEntities_Yes = 1,
        A3DProEReadConstructEntities_No = 2
}

    public enum A3DProEFamilyTables
    {
        A3DProEFamTabAcceleratorFileOnly = 0,
        A3DProEFamTabOrUseTessellation = 1,
        A3DProEFamTabOrUseWireAndGeneric = 2
}

    public enum A3DEStepNameFromNAUO
    {
        kA3DStepNameFromNAUO_ID = 0,
        kA3DStepNameFromNAUO_NAME = 1,
        kA3DStepNameFromNAUO_DESCRIPTION = 2
}

    public enum A3DEJTReadTessellationLevelOfDetail
    {
        kA3DJTTessLODLow = 0,
        kA3DJTTessLODMedium = 1,
        kA3DJTTessLODHigh = 2
}

    public enum A3DECompressBrepType
    {
        kA3DCompressionLow = 0,
        kA3DCompressionMedium = 1,
        kA3DCompressionHigh = 2
}

    public enum A3DEStepFormat
    {
        kA3DStepAP203 = 0,
        kA3DStepAP214 = 1,
        kA3DStepAP242 = 2
}

    public enum A3DETranslateToPkPartsHealing
    {
        kA3DE_HEALING_NO = 0,
        kA3DE_HEALING_YES = 1,
        kA3DE_HEALING_ONLY_IF_NOT_PARASOLID = 2
}

    public enum A3DETranslateToPkPartsAccurate
    {
        kA3DE_ACCURATE_NO = 0,
        kA3DE_ACCURATE_YES = 1,
        kA3DE_ACCURATE_ONLY_IF_NOT_PARASOLID = 2
}

    public enum A3DETranslateToPkPartsSimplifyGeometry
    {
        kA3DE_SIMPLIFY_NO = 0,
        kA3DE_SIMPLIFY_YES = 1,
        kA3DE_SIMPLIFY_ONLY_IF_NOT_PARASOLID = 2
}

    public enum A3DETranslateToPkPartsMergeEntities
    {
        kA3DE_MERGE_NO = 0,
        kA3DE_MERGE_YES = 1,
        kA3DE_MERGE_ONLY_IF_NOT_PARASOLID = 2
}

    public enum A3DEU3DVersion
    {
        kA3DECMA1 = 0,
        kA3DECMA3 = 1
}

    public enum A3DEJTVersion
    {
        kA3DE_JT81 = 0,
        kA3DE_JT95 = 1,
        kA3DE_JT100 = 2
}

    public enum EA3DMDLineWeldingType
    {
        KEA3DMDWeldTypeUnknown = -1,
        KEA3DMDWeldTypeNone = 0,
        KEA3DMDWeldTypeEdgeFlange = 1,
        KEA3DMDWeldTypeSquare = 2,
        KEA3DMDWeldTypeSingleV = 3,
        KEA3DMDWeldTypeSingleBevel = 4,
        KEA3DMDWeldTypeBroadRootFaceSingleV = 5,
        KEA3DMDWeldTypeBroadRootFaceSingleBevel = 6,
        KEA3DMDWeldTypeSingleU = 7,
        KEA3DMDWeldTypeSingleJ = 8,
        KEA3DMDWeldTypeBacking = 9,
        KEA3DMDWeldTypeFillet = 10,
        KEA3DMDWeldTypePlug = 11,
        KEA3DMDWeldTypeSeam = 12,
        KEA3DMDWeldTypeSteepFlankedSingleV = 13,
        KEA3DMDWeldTypeSteepFlankedSingleBevel = 14,
        KEA3DMDWeldTypeEdge = 15,
        KEA3DMDWeldTypeSurface = 16,
        KEA3DMDWeldTypeSurfaceJoint = 17,
        KEA3DMDWeldTypeInclinedJoint = 18,
        KEA3DMDWeldTypeFoldJoint = 19,
        KEA3DMDWeldTypeSpot = 20,
        KEA3DMDWeldTypePermanentBackStrip = 21,
        KEA3DMDWeldTypeRemovableBackStrip = 22,
        KEA3DMDWeldTypeUnspecifiedEdgeType = 23,
        KEA3DMDWeldTypeFlare_V_Butt = 24,
        KEA3DMDWeldTypeFlare_Bevel_Butt = 25,
        KEA3DMDWeldTypeSingleEdgeFlange = 26
}

    public enum EA3DMDLineWeldingSupplSymbolType
    {
        KEA3DMDWeldAddSymbolUnknown = -1,
        KEA3DMDWeldAddSymbolNone = 0,
        KEA3DMDWeldAddSymbolFlush = 1,
        KEA3DMDWeldAddSymbolConvex = 2,
        KEA3DMDWeldAddSymbolConcave = 3,
        KEA3DMDWeldAddSymbolToesBlended = 4,
        KEA3DMDWeldAddSymbolFlushFinished = 5,
        KEA3DMDWeldAddSymbolBackingPermanent = 6,
        KEA3DMDWeldAddSymbolBackingpRemovable = 7
}

    public enum EA3DMDLineWeldingFinishSymbol
    {
        KEA3DMDWeldFinishSymbolNone = 0,
        KEA3DMDWeldFinishSymbolC = 1,
        KEA3DMDWeldFinishSymbolF = 2,
        KEA3DMDWeldFinishSymbolG = 3,
        KEA3DMDWeldFinishSymbolH = 4,
        KEA3DMDWeldFinishSymbolM = 5,
        KEA3DMDWeldFinishSymbolR = 6,
        KEA3DMDWeldFinishSymbolU = 7,
        KEA3DMDWeldFinishSymbolChipping = 8,
        KEA3DMDWeldFinishSymbolGrinding = 9,
        KEA3DMDWeldFinishSymbolHammering = 10,
        KEA3DMDWeldFinishSymbolMachining = 11,
        KEA3DMDWeldFinishSymbolRolling = 12,
        KEA3DMDWeldFinishSymbolPeening = 13
}

    public enum EA3DMDLineWeldingOption
    {
        KEA3DMDLineWeldOptionUnknown = -1,
        KEA3DMDLineWeldOptionNone = 0,
        KEA3DMDLineWeldOptionAllAround = 256,
        KEA3DMDLineWeldOptionFieldWeld = 512,
        KEA3DMDLineWeldOptionReferenceSign = 1024,
        KEA3DMDLineWeldOptionTail = 2048,
        KEA3DMDLineWeldOptionIdentifLine = 4096,
        KEA3DMDLineWeldOptionIdentifLineUp = 8192,
        KEA3DMDLineWeldOptionTextSideDown = 16384
}

    public enum EA3DMDSpotWeldType
    {
        KEA3DMDSpotWeldTypeUnknown = -1,
        KEA3DMDSpotWeldTypeNone = 0,
        KEA3DMDSpotWeldTypeResistance = 1,
        KEA3DMDSpotWeldTypeProjection = 2
}

    public enum EA3DMDSpotWeldThickness
    {
        KEA3DMDSpotWeldThickUnknown = -1,
        KEA3DMDSpotWeldThick_None = 0,
        KEA3DMDSpotWeldTwoThick = 1,
        KEA3DMDSpotWeldThreeThick = 2,
        KEA3DMDSpotWeldE_FourThick = 3
}

    public enum EA3DGDTType
    {
        KEA3DGDTTypeNone = 0,
        KEA3DGDTTypeStraightness = 1,
        KEA3DGDTTypeFlatness = 2,
        KEA3DGDTTypeCircularity = 3,
        KEA3DGDTTypeCylindricity = 4,
        KEA3DGDTTypeLineProfile = 5,
        KEA3DGDTTypeSurfaceProfile = 6,
        KEA3DGDTTypeAngularity = 7,
        KEA3DGDTTypePerpendicularity = 8,
        KEA3DGDTTypeParallelism = 9,
        KEA3DGDTTypePosition = 10,
        KEA3DGDTTypeConcentricity = 11,
        KEA3DGDTTypeSymmetry = 12,
        KEA3DGDTTypeCircularRunout = 13,
        KEA3DGDTTypeTotalRunout = 14
}

    public enum A3DMDGDTValueType
    {
        KEA3DGDTValueNone = 0,
        KEA3DGDTValueDiameter = 1,
        KEA3DGDTValueRadius = 2,
        KEA3DGDTValueSpherical = 3
}

    public enum EA3DMDGDTModifierType
    {
        KEA3DGDTModifierNone = 0,
        KEA3DGDTModifierMax = 1,
        KEA3DGDTModifierMin = 2,
        KEA3DGDTModifierProj = 3,
        KEA3DGDTModifierFree = 4,
        KEA3DGDTModifierRfs = 5,
        KEA3DGDTModifierTangent = 6,
        KEA3DGDTModifierST = 8
}

    public enum EA3DMarkupFrameType
    {
        KA3DMarkupFrameNone = 0,
        KA3DMarkupFrameRectangle = 1,
        KA3DMarkupFrameSquare = 2,
        KA3DMarkupFrameCircle = 3,
        KA3DMarkupFrameScoredCircle = 4,
        KA3DMarkupFrameDiamond = 5,
        KA3DMarkupFrameTriangle = 6,
        KA3DMarkupFrameRightFlag = 7,
        KA3DMarkupFrameLeftFlag = 8,
        KA3DMarkupFrameBothFlag = 9,
        KA3DMarkupFrameOblong = 10,
        KA3DMarkupFrameEllipse = 11,
        KA3DMarkupFrameFixRectangle = 51,
        KA3DMarkupFrameFixSquare = 52,
        KA3DMarkupFrameFixCircle = 53,
        KA3DMarkupFrameFixScoredCircle = 54,
        KA3DMarkupFrameFixDiamond = 55,
        KA3DMarkupFrameFixTriangle = 56,
        KA3DMarkupFrameFixRightFlag = 57,
        KA3DMarkupFrameFixLeftFlag = 58,
        KA3DMarkupFrameFixBothFlag = 59,
        KA3DMarkupFrameFixOblong = 60,
        KA3DMarkupFrameFixEllipse = 61,
        KA3DMarkupFrameCustom = 255
}

    public enum EA3DLeaderAlignementType
    {
        KA3DLeaderAlignement_Simple = 0,
        KA3DLeaderAlignement_Bellow = 1,
        KA3DLeaderAlignement_Underline = 2,
        KA3DLeaderAlignement_ExtToMax = 3,
        KA3DLeaderAlignement_OnBoxPoint = 4,
        KA3DLeaderAlignement_SimpleOnBoxPoint = 5,
        KA3DLeaderAlignement_Maximal_Underline = 6,
        KA3DLeaderAlignement_Simple_OppositeAnchor = 7
}

    public enum EA3DMDRoughnessType
    {
        KA3DRoughnessTypeBasic = 1,
        KA3DRoughnessTypeMachining_Required = 2,
        KA3DRoughnessTypeMachining_Prohibited = 3
}

    public enum EA3DMDRoughnessContactArea
    {
        KA3DRoughnessContactSurfTexture = 1,
        KA3DRoughnessContactSurfTextAndAllSrfAround = 2,
        KA3DRoughnessContactBasic = 3,
        KA3DRoughnessContactSrfAround = 4
}

    public enum EA3DMDRoughnessMode
    {
        KA3DRoughnessMode_None = 0,
        KA3DRoughnessModeM = 1,
        KA3DRoughnessModeC = 2,
        KA3DRoughnessModeR = 3,
        KA3DRoughnessModeP = 4,
        KA3DRoughnessModeX = 5,
        KA3DRoughnessModePARA = 6,
        KA3DRoughnessModePERP = 7
}

    public enum EA3DMDBalloonShape
    {
        KA3DMDBalloonCircle = 0,
        KEA3DMDBalloonSquare = 1,
        KEA3DMDBalloonDividedSquare = 2,
        KEA3DMDBalloonQuadrantCircle = 3,
        KEA3DMDBalloonDividedCircle = 4,
        KEA3DMDBalloonRoundedBox = 5,
        KEA3DMDBalloonTriangle = 6,
        KEA3DMDBalloonTriangleUp = 7,
        KEA3DMDBalloonTriangleDown = 8,
        KEA3DMDBalloonHexagon = 9,
        KEA3DMDBalloonDividedHexagon = 10
}

    public enum EA3DLocatorSymbol
    {
        KEA3DSymbolUnknown = -1,
        KEA3DEdge = 0,
        KEA3DHole = 1,
        KEA3DSurface = 2,
        KEA3DRectangle = 3,
        KEA3DSlot = 4,
        KEA3DFreeform = 5
}

    public enum EA3DLocatorType
    {
        KEA3DLocatorUnknown = -1,
        KEA3DMain = 0,
        KEA3DSecondary = 1,
        KEA3DMainPermTransf = 2,
        KEA3DSecondaryPermTransf = 3,
        KEA3DSecondaryCoordination = 4,
        KEA3DCoordination = 5,
        KEA3DAccessClearance = 6,
        KEA3DDetached = 7,
        KEA3DBlank = 8,
        KEA3DCorrectable = 9,
        KEA3DAuxiliaryRest = 10,
        KEA3DJclamps = 11
}

    public enum EA3DLocatorSubType
    {
        KEA3DSubtypeUnknown = -1,
        KEA3DDiesMolds = 0,
        KEA3DFixing = 1,
        KEA3DTemporaryTransferred = 2,
        KEA3DMechanicallyFastened = 3,
        KEA3DManufacturingAssembly = 4
}

    public enum EA3DLocatorCoordinatePlane
    {
        KEA3DCoordPlaneUnknown = -1,
        KEA3DCoordPlaneX = 0,
        KEA3DCoordPlaneY = 1,
        KEA3DCoordPlaneZ = 2,
        KEA3DCoordPlaneXY = 3,
        KEA3DCoordPlaneXZ = 4,
        KEA3DCoordPlaneYZ = 5,
        KEA3DCoordPlaneXYZ = 6
}

    public enum EA3DLocatorChangeLevel
    {
        KEA3DLevelUnknown = -1,
        KEA3DHard = 0,
        KEA3DMedium = 1,
        KEA3DSoft = 2
}

    public enum EA3DLocatorSubscript
    {
        KEA3DLocatorSubscriptO = 1,
        KEA3DLocatorSubscriptS = 2,
        KEA3DLocatorSubscriptK = 4,
        KEA3DLocatorSubscriptC = 8,
        KEA3DLocatorSubscriptF = 16
}

    public enum EA3DMDAnchorPointType
    {
        KEA3DMDAnchorIgnored = -1,
        KEA3DMDAnchorTop_left = 0,
        KEA3DMDAnchorTop_center = 1,
        KEA3DMDAnchorTop_right = 2,
        KEA3DMDAnchorMiddle_left = 10,
        KEA3DMDAnchorMiddle_center = 11,
        KEA3DMDAnchorMiddle_right = 12,
        KEA3DMDAnchorMiddle_auto = 13,
        KEA3DMDAnchorBottom_left = 20,
        KEA3DMDAnchorBottom_center = 21,
        KEA3DMDAnchorBottom_right = 22,
        KEA3DMDAnchorBottom_auto = 23,
        KEA3DMDAnchorAutomatic = 24
}

    public enum A3DMDLeaderSymbolType
    {
        KA3DMDLeaderSymbolNotUsed = 0,
        KA3DMDLeaderSymbolCross = 1,
        KA3DMDLeaderSymbolPlus = 2,
        KA3DMDLeaderSymbolConcentric = 3,
        KA3DMDLeaderSymbolCoincident = 4,
        KA3DMDLeaderSymbolFullCircle = 5,
        KA3DMDLeaderSymbolFullSquare = 6,
        KA3DMDLeaderSymbolStar = 7,
        KA3DMDLeaderSymbolDot = 8,
        KA3DMDLeaderSymbolSmallDot = 9,
        KA3DMDLeaderSymbolMisc1 = 10,
        KA3DMDLeaderSymbolMisc2 = 11,
        KA3DMDLeaderSymbolFullCircle2 = 12,
        KA3DMDLeaderSymbolFullSquare2 = 13,
        KA3DMDLeaderSymbolOpenArrow = 14,
        KA3DMDLeaderSymbolUnfilledArrow = 15,
        KA3DMDLeaderSymbolBlankedArrow = 16,
        KA3DMDLeaderSymbolFilledArrow = 17,
        KA3DMDLeaderSymbolUnfilledCircle = 18,
        KA3DMDLeaderSymbolBlankedCircle = 19,
        KA3DMDLeaderSymbolFilledCircle = 20,
        KA3DMDLeaderSymbolCrossedCircle = 21,
        KA3DMDLeaderSymbolBlankedSquare = 22,
        KA3DMDLeaderSymbolFilledSquare = 23,
        KA3DMDLeaderSymbolBlankedTriangle = 24,
        KA3DMDLeaderSymbolFilledTriangle = 25,
        KA3DMDLeaderSymbolManipulatorSquare = 26,
        KA3DMDLeaderSymbolMamipulatorDiamond = 27,
        KA3DMDLeaderSymbolManipulatorCircle = 28,
        KA3DMDLeaderSymbolManipulatorTriangle = 29,
        KA3DMDLeaderSymbolDoubleOpenArrow = 30,
        KA3DMDLeaderSymbolWave = 31,
        KA3DMDLeaderSymbolSegment = 32,
        KA3DMDLeaderSymbolDoubleFilledArrow = 33,
        KA3DMDLeaderSymbolDoubleClosedArrow = 34,
        KA3DMDLeaderSymbolHalfOpenArrowUp = 35,
        KA3DMDLeaderSymbolHalfOpenArrowDown = 36,
        KA3DMDLeaderSymbolHalfFilledArrowUp = 37,
        KA3DMDLeaderSymbolHalfFilledArrowDown = 38,
        KA3DMDLeaderSymbolSlash = 39,
        KA3DMDLeaderSymbolDoubleBlankedArrow = 40,
        KA3DMDLeaderSymbolIntegral = 41,
        KA3DMDLeaderSymbolZoneGlobalAllAround = 50,
        KA3DMDLeaderSymbolZonePartialAllAround = 51,
        KA3DMDLeaderSymbolZoneGlobalAllAboutWithHorizontalAxisIndicator = 52,
        KA3DMDLeaderSymbolZoneGlobalAllAboutWithVerticalAxisIndicator = 53,
        KA3DMDLeaderSymbolZonePartialAllAboutWithHorizontalAxisIndicator = 54,
        KA3DMDLeaderSymbolZonePartialAllAboutWithVerticalAxisIndicator = 55,
        KA3DMDLeaderSymbolZoneGlobalAllOver = 56,
        KA3DMDLeaderSymbolZonePartialAllOver = 57
}

    public enum EA3DMDDimensionValueOption
    {
        KEA3DMDDimensionValueOptionNone = 0,
        KEA3DMDDimensionValueOptionMin = 1,
        KEA3DMDDimensionValueOptionMax = 2,
        KEA3DMDDimensionValueOptionEnvelopeModifier = 4,
        KEA3DMDDimensionValueOptionIndependencyModifier = 8,
        KEA3DMDDimensionValueOptionStaticalTolerancingModifier = 16,
        KEA3DMDDimensionValueOptionPerfectFormAtMMCNotRequired = 32,
        KEA3DMDDimensionValueOptionReferenceOrAuxiliary = 64,
        KEA3DMDDimensionValueOptionBasicOrTheorical = 128
}

    public enum EA3DMDDimensionLineGraphicalRepresentation
    {
        KEA3DMDDimensionGraphicalRepresentationRegular = 0,
        KEA3DMDDimensionGraphicalRepresentationTwoParts = 1,
        KEA3DMDDimensionGraphicalRepresentationLeaderOnePart = 2,
        KEA3DMDDimensionGraphicalRepresentationLeaderTwoParts = 3
}

    public enum EA3DMDDimensionOrientation
    {
        KEA3DMDDimensionOrientationScreenHorizontal = 0,
        KEA3DMDDimensionOrientationScreenVertical = 1,
        KEA3DMDDimensionOrientationScreenAngle = 2,
        KEA3DMDDimensionOrientationViewHorizontal = 3,
        KEA3DMDDimensionOrientationViewVertical = 4,
        KEA3DMDDimensionOrientationViewAngle = 5,
        KEA3DMDDimensionOrientationParallel = 6,
        KEA3DMDDimensionOrientationPerpendicular = 7,
        KEA3DMDDimensionOrientationAngle = 8
}

    public enum EA3DMDDimensionSymbolType
    {
        KEA3DDimensionSymbolTypeUNKNOW = -1,
        KEA3DDimensionSymbolTypeNONE = 0,
        KEA3DDimensionSymbolTypePROJTOLZONE = 1,
        KEA3DDimensionSymbolTypeMAXMATERIAL = 2,
        KEA3DDimensionSymbolTypeLEASTMATERIAL = 3,
        KEA3DDimensionSymbolTypeFREESTATE = 4,
        KEA3DDimensionSymbolTypeOHM = 5,
        KEA3DDimensionSymbolTypeCENTERLINE = 6,
        KEA3DDimensionSymbolTypeDEPTH = 7,
        KEA3DDimensionSymbolTypeCOUNTERBORE = 8,
        KEA3DDimensionSymbolTypeCOUNTERSUNK = 9,
        KEA3DDimensionSymbolTypeCIRCULARRUNOUT = 10,
        KEA3DDimensionSymbolTypeSURFPROFILE = 11,
        KEA3DDimensionSymbolTypeLINEPROFILE = 12,
        KEA3DDimensionSymbolTypeFLATNESS = 13,
        KEA3DDimensionSymbolTypeSTRAIGHT = 14,
        KEA3DDimensionSymbolTypeTOTALRUNOUT = 15,
        KEA3DDimensionSymbolTypeSYMMETRY = 16,
        KEA3DDimensionSymbolTypePERPENDICULAR = 17,
        KEA3DDimensionSymbolTypePARALLEL = 18,
        KEA3DDimensionSymbolTypeCYLINDRIC = 19,
        KEA3DDimensionSymbolTypeCONCENTRIC = 20,
        KEA3DDimensionSymbolTypeCIRCULAR = 21,
        KEA3DDimensionSymbolTypeANGULAR = 22,
        KEA3DDimensionSymbolTypeMICRO = 23,
        KEA3DDimensionSymbolTypeDEGREE = 24,
        KEA3DDimensionSymbolTypePLUSMINUS = 25,
        KEA3DDimensionSymbolTypePOSITION = 26,
        KEA3DDimensionSymbolTypeDIAMETER = 27,
        KEA3DDimensionSymbolTypeENVELOPE = 28,
        KEA3DDimensionSymbolTypeARROW = 29,
        KEA3DDimensionSymbolTypeNOACTUALSIZE = 30,
        KEA3DDimensionSymbolTypeTANGENTPLANE = 31,
        KEA3DDimensionSymbolTypeLOWEROREQUAL = 32,
        KEA3DDimensionSymbolTypeGREATEROREQUAL = 33,
        KEA3DDimensionSymbolTypeTHREADPREFIX = 34,
        KEA3DDimensionSymbolTypeSLOPE = 35,
        KEA3DDimensionSymbolTypeCONICALTAPER = 36,
        KEA3DDimensionSymbolTypeUPTRIANGLE = 37,
        KEA3DDimensionSymbolTypeSQUARE = 38,
        KEA3DDimensionSymbolTypeST = 39,
        KEA3DDimensionSymbolTypeSDIAMETER = 40,
        KEA3DDimensionSymbolTypeRADIUS = 41,
        KEA3DDimensionSymbolTypeSRADIUS = 42,
        KEA3DDimensionSymbolTypeCRADIUS = 43,
        KEA3DDimensionSymbolTypeUNEQUALLY = 44,
        KEA3DDimensionSymbolTypeCF = 45,
        KEA3DDimensionSymbolTypeSET_AFTER = 1000
}

    public enum EA3DMDDimensionSymbolShape
    {
        KEA3DDimensionSymbolNone = 0,
        KEA3DDimensionSymbolOpenArrow = 1,
        KEA3DDimensionSymbolClosedArrow = 2,
        KEA3DDimensionSymbolFilledArrow = 3,
        KEA3DDimensionSymbolSymArrow = 4,
        KEA3DDimensionSymbolSlash = 5,
        KEA3DDimensionSymbolCircle = 6,
        KEA3DDimensionSymbolFilledCircle = 7,
        KEA3DDimensionSymbolScoredCircle = 8,
        KEA3DDimensionSymbolCircledCross = 9,
        KEA3DDimensionSymbolTriangle = 10,
        KEA3DDimensionSymbolFilledTriangle = 11,
        KEA3DDimensionSymbolCross = 12,
        KEA3DDimensionSymbolXCross = 13,
        KEA3DDimensionSymbolDoubleArrow = 14,
        KEA3DDimensionSymbolSquare = 15,
        KEA3DDimensionSymbolFilledSquare = 16,
        KEA3DDimensionSymbolWave = 17
}

    public enum EA3DMDDimensionLineExtensionType
    {
        KEA3DMDDimensionExtensionFromStandard = 0,
        KEA3DMDDimensionExtensionTillCenter = 1,
        KEA3DMDDimensionExtensionNotTillCenter = 2,
        KEA3DMDDimensionExtensionHideFirstPartOfDimLine = 4,
        KEA3DMDDimensionExtensionHideFSecondPartOfDimLine = 8,
        KEA3DMDDimensionExtensionHideEntireDimLine = 16,
        KEA3DMDDimensionExtensionAddIsoLineUnderTextValue = 32
}

    public enum EA3DMDDimensionType
    {
        KEA3DMDDimensionTypeDistance = 0,
        KEA3DMDDimensionTypeDistanceOffset = 1,
        KEA3DMDDimensionTypeLength = 2,
        KEA3DMDDimensionTypeLengthCurvilinear = 3,
        KEA3DMDDimensionTypeAngle = 4,
        KEA3DMDDimensionTypeRadius = 5,
        KEA3DMDDimensionTypeRadiusTangent = 6,
        KEA3DMDDimensionTypeRadiusCylinder = 7,
        KEA3DMDDimensionTypeRadiusEdge = 8,
        KEA3DMDDimensionTypeDiameter = 9,
        KEA3DMDDimensionTypeDiameterTangent = 10,
        KEA3DMDDimensionTypeDiameterCylinder = 11,
        KEA3DMDDimensionTypeDiameterEdge = 12,
        KEA3DMDDimensionTypeDiameterCone = 13,
        KEA3DMDDimensionTypeChamfer = 14,
        KEA3DMDDimensionTypeSlope = 15
}

    public enum EA3DMDDimensionDualDisplay
    {
        KEA3DMDDimensionDualDisplayNone = 0,
        KEA3DMDDimensionDualDisplayBelow = 1,
        KEA3DMDDimensionDualDisplayFractional = 2,
        KEA3DMDDimensionDualDisplaySideBySide = 3,
        KEA3DMDDimensionDualDisplayOnLeft = 4,
        KEA3DMDDimensionDualDisplayOnRight = 5,
        KEA3DMDDimensionDualDisplayAbove = 6,
        KEA3DMDDimensionDualDisplayOnly = 7
}

    public enum EA3DMDDimensionFrame
    {
        KEA3DMDDimensionFrameNone = 0,
        KEA3DMDDimensionFrameCircle = 1,
        KEA3DMDDimensionFrameScoredCircle = 2,
        KEA3DMDDimensionFrameDiamondShaped = 3,
        KEA3DMDDimensionFrameSquare = 4,
        KEA3DMDDimensionFrameRectangle = 5,
        KEA3DMDDimensionFrameOblong = 6,
        KEA3DMDDimensionFrameRightFlag = 7,
        KEA3DMDDimensionFrameRightTriangle = 8
}

    public enum EA3DMDDimensionScore
    {
        KEA3DMDDimensionScoreNone = 0,
        KEA3DMDDimensionUnderScored = 1,
        KEA3DMDDimensionScored = 2,
        KEA3DMDDimensionOverScored = 3
}

    public enum EA3DMDDimensionAngleSector
    {
        KEA3DMDDimensionAngleSector_None = 0,
        KEA3DMDDimensionAngleSector_1 = 1,
        KEA3DMDDimensionAngleSector_2 = 2,
        KEA3DMDDimensionAngleSector_3 = 3,
        KEA3DMDDimensionAngleSector_4 = 4,
        KEA3DMDDimensionAngleSector_Complementary = 5
}

    public enum EA3DMDDimensionReferenceType
    {
        KEA3DMDDimensionRefType_None = 0,
        KEA3DMDDimensionRefType_Reference = 1,
        KEA3DMDDimensionRefType_Parenthesis = 2,
        KEA3DMDDimensionRefType_Match = 3,
        KEA3DMDDimensionRefType_Diameter_Reference = 4,
        KEA3DMDDimensionRefType_Not_To_Scale = 5,
        KEA3DMDDimensionRefType_Basic = 6
}

    public enum EA3DMDMarkupDisplayType
    {
        KEA3DMDDisplayType_Unknown = -1,
        KEA3DMDDisplayType_Unspecified = 0,
        KEA3DMDDisplayType_FlatToScreen = 1,
        KEA3DMDDisplayType_FlatToSurface = 2
}

    public enum EA3DMDTextPropertiesScore
    {
        KEA3DMDTextPropertiesScoreNone = 0,
        KEA3DMDTextPropertiesUnderScored = 1,
        KEA3DMDTextPropertiesScored = 2,
        KEA3DMDTextPropertiesOverScored = 3
}

    public enum EA3DMDTextPropertiesFormat
    {
        KEA3DMDTextPropertiesFormatNormal = 0,
        KEA3DMDTextPropertiesFormatUnderLine = 1,
        KEA3DMDTextPropertiesFormatOverLine = 2,
        KEA3DMDTextPropertiesFormatExposant = 3,
        KEA3DMDTextPropertiesFormatindice = 4
}

    public enum EA3DMDTextPropertiesJustification
    {
        KEA3DMDTextPropertiesJustificationLeft = 0,
        KEA3DMDTextPropertiesJustificationCenter = 1,
        KEA3DMDTextPropertiesJustificationRight = 2
}

    public enum A3DEMarkupType
    {
        kA3DMarkupTypeUnknown = 0,
        kA3DMarkupTypeText = 1,
        kA3DMarkupTypeDimension = 2,
        kA3DMarkupTypeArrow = 3,
        kA3DMarkupTypeBalloon = 4,
        kA3DMarkupTypeCircleCenter = 5,
        kA3DMarkupTypeCoordinate = 6,
        kA3DMarkupTypeDatum = 7,
        kA3DMarkupTypeFastener = 8,
        kA3DMarkupTypeGdt = 9,
        kA3DMarkupTypeLocator = 10,
        kA3DMarkupTypeMeasurementPoint = 11,
        kA3DMarkupTypeRoughness = 12,
        kA3DMarkupTypeWelding = 13,
        kA3DMarkupTypeTable = 14,
        kA3DMarkupTypeOther = 15
}

    public enum A3DEMarkupSubType
    {
        kA3DMarkupSubTypeUnknown = 0,
        kA3DMarkupSubTypeEnumMax = 1,
        kA3DMarkupSubTypeDatumIdent = 1,
        kA3DMarkupSubTypeDatumTarget = 2,
        kA3DMarkupSubTypeDatumEnumMax = 3,
        kA3DMarkupSubTypeDimensionDistance = 1,
        kA3DMarkupSubTypeDimensionDistanceOffset = 2,
        kA3DMarkupSubTypeDimensionDistanceCumulate = 3,
        kA3DMarkupSubTypeDimensionChamfer = 4,
        kA3DMarkupSubTypeDimensionSlope = 5,
        kA3DMarkupSubTypeDimensionOrdinate = 6,
        kA3DMarkupSubTypeDimensionRadius = 7,
        kA3DMarkupSubTypeDimensionRadiusTangent = 8,
        kA3DMarkupSubTypeDimensionRadiusCylinder = 9,
        kA3DMarkupSubTypeDimensionRadiusEdge = 10,
        kA3DMarkupSubTypeDimensionDiameter = 11,
        kA3DMarkupSubTypeDimensionDiameterTangent = 12,
        kA3DMarkupSubTypeDimensionDiameterCylinder = 13,
        kA3DMarkupSubTypeDimensionDiameterEdge = 14,
        kA3DMarkupSubTypeDimensionDiameterCone = 15,
        kA3DMarkupSubTypeDimensionLength = 16,
        kA3DMarkupSubTypeDimensionLengthCurvilinear = 17,
        kA3DMarkupSubTypeDimensionLengthCircular = 18,
        kA3DMarkupSubTypeDimensionAngle = 19,
        kA3DMarkupSubTypeDimensionEnumMax = 20,
        kA3DMarkupSubTypeGdtFcf = 1,
        kA3DMarkupSubTypeGdtEnumMax = 2,
        kA3DMarkupSubTypeWeldingLine = 1,
        kA3DMarkupSubTypeWeldingSpot = 2,
        kA3DMarkupSubTypeWeldingEnumMax = 3,
        kA3DMarkupSubTypeOtherSymbolUser = 1,
        kA3DMarkupSubTypeOtherSymbolUtility = 2,
        kA3DMarkupSubTypeOtherSymbolCustom = 3,
        kA3DMarkupSubTypeOtherGeometricReference = 4,
        kA3DMarkupSubTypeOtherRegion = 5,
        kA3DMarkupSubTypeOtherEnumMax = 6
}

    public enum A3DEMarkupSymbol
    {
        KEA3DSymbol_UNKNOWN = 0,
        KEA3DSymbol_Angularity = 1,
        KEA3DSymbol_MoreOrLess = 2,
        KEA3DSymbol_Micron = 3,
        KEA3DSymbol_Circularity = 4,
        KEA3DSymbol_Concentricity = 5,
        KEA3DSymbol_Cylindricity = 6,
        KEA3DSymbol_Parallelism = 7,
        KEA3DSymbol_Perpendicularity = 8,
        KEA3DSymbol_Symmetry = 9,
        KEA3DSymbol_TotalRunout = 10,
        KEA3DSymbol_Straightness = 11,
        KEA3DSymbol_Flatness = 12,
        KEA3DSymbol_LineProfile = 13,
        KEA3DSymbol_SurfaceProfile = 14,
        KEA3DSymbol_Runout = 15,
        KEA3DSymbol_Countersink = 16,
        KEA3DSymbol_Counterbore = 17,
        KEA3DSymbol_Depth = 18,
        KEA3DSymbol_Centerline = 19,
        KEA3DSymbol_Ohm = 20,
        KEA3DSymbol_Omega = 21,
        KEA3DSymbol_SmallerOrEqual = 22,
        KEA3DSymbol_GreaterOrEqual = 23,
        KEA3DSymbol_Slope = 24,
        KEA3DSymbol_ConicalTaper = 25,
        KEA3DSymbol_Diameter = 26,
        KEA3DSymbol_FreeState = 27,
        KEA3DSymbol_LeastMaterial = 28,
        KEA3DSymbol_MaximumMaterial = 29,
        KEA3DSymbol_ProjectedTolerance = 30,
        KEA3DSymbol_TangentPlane = 31,
        KEA3DSymbol_Statistical = 32,
        KEA3DSymbol_Position = 33,
        KEA3DSymbol_Square = 34,
        KEA3DSymbol_Triangle = 35,
        KEA3DSymbol_between = 36,
        KEA3DSymbol_RegardlessOfFeatureSize = 37,
        KEA3DSymbol_Degre = 38,
        KEA3DSymbol_Encompassing = 39,
        KEA3DSymbol_CircledU = 40,
        KEA3DSymbol_CircledR = 41,
        KEA3DSymbol_RightwardArrow = 42,
        KEA3DSymbol_SubsetOf = 43,
        KEA3DSymbol_1STANG = 44,
        KEA3DSymbol_3RDANG = 45,
        KEA3DSymbol_BREAK15 = 46,
        KEA3DSymbol_BREAK30 = 47,
        KEA3DSymbol_DATUM1 = 48,
        KEA3DSymbol_DATUM2 = 49,
        KEA3DSymbol_MINUS = 50,
        KEA3DSymbol_PLINE = 51,
        KEA3DSymbol_PLUS = 52,
        KEA3DSymbol_STRETCH = 53,
        KEA3DSymbol_STS = 54,
        KEA3DSymbol_STS_ = 55,
        KEA3DSymbol_STS_ANG = 56,
        KEA3DSymbol_STS_ANG_ = 57,
        KEA3DSymbol_STS_BAS = 58,
        KEA3DSymbol_STS_BAS_ = 59,
        KEA3DSymbol_STS_CIR = 60,
        KEA3DSymbol_STS_CIR_ = 61,
        KEA3DSymbol_STS_MAT = 62,
        KEA3DSymbol_STS_MAT_ = 63,
        KEA3DSymbol_STS_MLT = 64,
        KEA3DSymbol_STS_MLT_ = 65,
        KEA3DSymbol_STS_NOM = 66,
        KEA3DSymbol_STS_NOM_ = 67,
        KEA3DSymbol_STS_PAR = 68,
        KEA3DSymbol_STS_PAR_ = 69,
        KEA3DSymbol_STS_PER = 70,
        KEA3DSymbol_STS_PER_ = 71,
        KEA3DSymbol_STS_PRT = 72,
        KEA3DSymbol_STS_PRT_ = 73,
        KEA3DSymbol_STS_RAD = 74,
        KEA3DSymbol_STS_RAD_ = 75
}

    public enum A3DECharSet
    {
        kA3DCharsetUnknown = -1,
        kA3DCharsetRoman = 0,
        kA3DCharsetJapanese = 1,
        kA3DCharsetTraditionalChinese = 2,
        kA3DCharsetKorean = 3,
        kA3DCharsetArabic = 4,
        kA3DCharsetHebrew = 5,
        kA3DCharsetGreek = 6,
        kA3DCharsetCyrillic = 7,
        kA3DCharsetRightLeft = 8,
        kA3DCharsetDevanagari = 9,
        kA3DCharsetGurmukhi = 10,
        kA3DCharsetGujarati = 11,
        kA3DCharsetOriya = 12,
        kA3DCharsetBengali = 13,
        kA3DCharsetTamil = 14,
        kA3DCharsetTelugu = 15,
        kA3DCharsetKannada = 16,
        kA3DCharsetMalayalam = 17,
        kA3DCharsetSinhalese = 18,
        kA3DCharsetBurmese = 19,
        kA3DCharsetKhmer = 20,
        kA3DCharsetThai = 21,
        kA3DCharsetLaotian = 22,
        kA3DCharsetGeorgian = 23,
        kA3DCharsetArmenian = 24,
        kA3DCharsetSimplifiedChinese = 25,
        kA3DCharsetTibetan = 26,
        kA3DCharsetMongolian = 27,
        kA3DCharsetGeez = 28,
        kA3DCharsetEastEuropeanRoman = 29,
        kA3DCharsetVietnamese = 30,
        kA3DCharsetExtendedArabic = 31
}

    public enum A3DERenderingMode
    {
        kA3DSolid = 0,
        kA3DSolidOutline = 1,
        kA3DWireframe = 2,
        kA3DHLR = 3,
        kA3DRMDefault = 100
}

    public enum A3DEPictureDataFormat
    {
        kA3DPicturePng = 0,
        kA3DPictureJpg = 1,
        kA3DPictureBmp = 2,
        kA3DPictureBitmapRgbByte = 3,
        kA3DPictureBitmapRgbaByte = 4,
        kA3DPictureBitmapGreyByte = 5,
        kA3DPictureBitmapGreyaByte = 6
}

    public enum A3DEBSplineSurfaceForm
    {
        kA3DBSplineSurfaceFormPlane = 0,
        kA3DBSplineSurfaceFormCylindrical = 1,
        kA3DBSplineSurfaceFormConical = 2,
        kA3DBSplineSurfaceFormSpherical = 3,
        kA3DBSplineSurfaceFormRevolution = 4,
        kA3DBSplineSurfaceFormRuled = 5,
        kA3DBSplineSurfaceFormGeneralizedCone = 6,
        kA3DBSplineSurfaceFormQuadric = 7,
        kA3DBSplineSurfaceFormLinearExtrusion = 8,
        kA3DBSplineSurfaceFormUnspecified = 9,
        kA3DBSplineSurfaceFormPolynomial = 10
}

    public enum A3DEKnotType
    {
        kA3DKnotTypeUniformKnots = 0,
        kA3DKnotTypeUnspecified = 1,
        kA3DKnotTypeQuasiUniformKnots = 2,
        kA3DKnotTypePieceWiseBezierKnots = 3
}

    public enum A3DEBSplineCurveForm
    {
        kA3DBSplineCurveFormUnspecified = 0,
        kA3DBSplineCurveFormPolyline = 1,
        kA3DBSplineCurveFormCircularArc = 2,
        kA3DBSplineCurveFormEllipticArc = 3,
        kA3DBSplineCurveFormParabolicArc = 4,
        kA3DBSplineCurveFormHyperbolicArc = 5
}

    public enum A3DEHelixType
    {
        kA3DConstantPitch = 0,
        kA3DVariablePitch = 1
}

    public enum A3DEIntersectionLimitType
    {
        kA3DIntersectionLimitTypeHelp = 0,
        kA3DIntersectionLimitTypeTerminator = 1,
        kA3DIntersectionLimitTypeLimit = 2,
        kA3DIntersectionLimitTypeBoundary = 3
}

    public enum A3DEDrawingViewType
    {
        kA3DDrawingViewTypeUnknown = 0,
        kA3DDrawingViewTypeIso = 1,
        kA3DDrawingViewTypeTop = 2,
        kA3DDrawingViewTypeBottom = 3,
        kA3DDrawingViewTypeLeft = 4,
        kA3DDrawingViewTypeRight = 5,
        kA3DDrawingViewTypeFront = 6,
        kA3DDrawingViewTypeBack = 7,
        kA3DDrawingViewTypeBackground = 8,
        kA3DDrawingViewTypeWorking = 9,
        kA3DDrawingViewTypeProjected = 10,
        kA3DDrawingViewTypeAuxiliary = 11,
        kA3DDrawingViewTypeSection = 12,
        kA3DDrawingViewTypeDetail = 13
}

    public enum A3DEDrawingClipFrameType
    {
        kA3DDrawingClipFrameTypeNone = 0,
        kA3DDrawingClipFrameTypeRectangular = 1,
        kA3DDrawingClipFrameTypeUserDefine = 2
}

    public enum A3DEDrawingOperatorType
    {
        kA3DDrawingOperatorTypeUnknwon = 0,
        kA3DDrawingOperatorTypeDetail = 1,
        kA3DDrawingOperatorTypeSection = 2
}

    public enum A3DEDrawingFilledAreaMode
    {
        kA3DDrawingFiledAreaModeOR = 0,
        kA3DDrawingFiledAreaModeAND = 1,
        kA3DDrawingFiledAreaModeXOR = 2
}

    public enum A3DEDrawMaterialType
    {
        kA3DDrawMaterialAmbient = 0,
        kA3DDrawMaterialDiffuse = 1,
        kA3DDrawMaterialSpecular = 2,
        kA3DDrawMaterialEmission = 3,
        kA3DDrawMaterialShininess = 4
}

    public enum A3DEDrawBeginEndType
    {
        kA3DDrawBeginEndProductOccurrence = 0,
        kA3DDrawBeginEndRepresentationItem = 1,
        kA3DDrawBeginEndMarkup = 2
}

    public enum A3DEAnalyticType
    {
        kA3DAnalyticNone = 0,
        kA3DAnalyticCircle = 1,
        kA3DAnalyticAlreadyCircle = 2,
        kA3DAnalyticLine = 3,
        kA3DAnalyticAlreadyLine = 4,
        kA3DAnalyticCone = 5,
        kA3DAnalyticAlreadyCone = 6,
        kA3DAnalyticCylinder = 7,
        kA3DAnalyticAlreadyCylinder = 8,
        kA3DAnalyticPlane = 9,
        kA3DAnalyticAlreadyPlane = 10,
        kA3DAnalyticSphere = 11,
        kA3DAnalyticAlreadySphere = 12,
        kA3DAnalyticTorus = 13,
        kA3DAnalyticAlreadyTorus = 14
}

    public enum A3DMaterialPhysicType
    {
        A3DPhysicType_None = 0,
        A3DPhysicType_Fiber = 1,
        A3DPhysicType_HoneyComb = 2,
        A3DPhysicType_Isotropic = 3,
        A3DPhysicType_Orthotropic2D = 4,
        A3DPhysicType_Orthotropic3D = 5,
        A3DPhysicType_Anisotropic = 6
}

    public enum A3DCollisionType
    {
        A3DCollision_Unknown = 0,
        A3DCollision_NoCollision = 1,
        A3DCollision_Clearance = 2,
        A3DCollision_Contact = 3,
        A3DCollision_Collision = 4,
        A3DCollision_FirstInside = 5,
        A3DCollision_SecondInside = 6
}

    public enum A3DEReadingMode2D3D
    {
        kA3DRead_3D = 0,
        kA3DRead_Drawings = 1,
        kA3DRead_Both = 2
}

    public enum A3DEBasicUnit
    {
        kA3DUnit_None = 0,
        kA3DUnit_Ampere = 1,
        kA3DUnit_Becquerel = 2,
        kA3DUnit_Candela = 3,
        kA3DUnit_Coulomb = 4,
        kA3DUnit_Degree_celsius = 5,
        kA3DUnit_Fahrenheit = 6,
        kA3DUnit_Farad = 7,
        kA3DUnit_Foot = 8,
        kA3DUnit_GallonUS = 9,
        kA3DUnit_Gram = 10,
        kA3DUnit_Gray = 11,
        kA3DUnit_Henry = 12,
        kA3DUnit_Hertz = 13,
        kA3DUnit_Hour = 14,
        kA3DUnit_Inch = 15,
        kA3DUnit_Joule = 16,
        kA3DUnit_Kelvin = 17,
        kA3DUnit_Liter = 18,
        kA3DUnit_Lumen = 19,
        kA3DUnit_Lux = 20,
        kA3DUnit_Metre = 21,
        kA3DUnit_Minute = 22,
        kA3DUnit_Mole = 23,
        kA3DUnit_Newton = 24,
        kA3DUnit_Ohm = 25,
        kA3DUnit_Pascal = 26,
        kA3DUnit_Radian = 27,
        kA3DUnit_Rankine = 28,
        kA3DUnit_Second = 29,
        kA3DUnit_Siemens = 30,
        kA3DUnit_Sievert = 31,
        kA3DUnit_Steradian = 32,
        kA3DUnit_Tesla = 33,
        kA3DUnit_Volt = 34,
        kA3DUnit_Watt = 35,
        kA3DUnit_Weber = 36
}

    public enum EA3DFCFIndicatorType
    {
        kA3DFCFIndicatorType_Undef = 0,
        kA3DFCFIndicatorType_DirectionFeature = 1,
        kA3DFCFIndicatorType_CollectionPlane = 2,
        kA3DFCFIndicatorType_IntersectionPlane = 3,
        kA3DFCFIndicatorType_OrientationPlane = 4
}

    public enum EA3DFCFIndicatorSymbol
    {
        kA3DFCFIndicatorSymbol_Undef = 0,
        kA3DFCFIndicatorSymbol_Angularity = 1,
        kA3DFCFIndicatorSymbol_Perpendicularity = 2,
        kA3DFCFIndicatorSymbol_Parallelism = 3,
        kA3DFCFIndicatorSymbol_Symmetry = 4
}

    public enum EA3DRevitPhysicalProperties
    {
        kA3DRevitPhysicalProperties_NotComputed = 0,
        kA3DRevitPhysicalProperties_Computed = 1
}

    public enum A3DStatus
    {
        A3D_SUCCESS = 0,
        A3D_ERROR = -1,
        A3D_EXCEPTION = -2,
        A3D_MEMORY_ALLOCATION_FAILURE = -3,
        A3D_ALLOC_FATAL_ERROR = -10,
        A3D_NOT_IMPLEMENTED = -33,
        A3D_INVALID_LICENSE = -34,
        A3D_NOT_AVAILABLE = -35,
        A3D_INCREMENTAL_MODE_AND_MULTI_PROCESS_NOT_COMPATIBLE = -11,
        A3D_LOCKED_LIBRARY = -12,
        A3D_INVALID_DATA_STRUCT_SIZE = -100,
        A3D_INVALID_DATA_STRUCT_NULL = -101,
        A3D_INVALID_ENTITY_NULL = -102,
        A3D_INVALID_ENTITY_TYPE = -103,
        A3D_INVALID_DATA = -104,
        A3D_INVALID_DATA_NULL = -105,
        A3D_INCOMPATIBLE_FUNCTION_WITH_KEEP_PARSED_ENTITY_MODE = -106,
        A3D_INITIALIZE_ALREADY_CALLED = -200,
        A3D_INITIALIZE_NOT_CALLED = -201,
        A3D_INITIALIZE_BAD_VALUES = -202,
        A3D_INITIALIZE_CANNOT_PROCESS = -205,
        A3D_TESSELLATION_FILIFORM_TRIS = -401,
        A3D_TESSELLATION_FREE_EDGES = -402,
        A3D_TESSELLATION_FILIFORM_TRIS_FREE_EDGES = -403,
        A3D_CRV_CANNOT_REPARAMETERIZE = -990,
        A3D_CRV_INVALID_PARAMETER = -991,
        A3D_CRV_CANNOT_ACCESS_CANONICAL = -1000,
        A3D_CRV_LINE_CANNOT_CREATE_CANONICAL = -1001,
        A3D_CRV_CIRCLE_CANNOT_CREATE_CANONICAL = -1011,
        A3D_CRV_ELLIPSE_CANNOT_CREATE_CANONICAL = -1021,
        A3D_CRV_HYPERBOLA_CANNOT_CREATE_CANONICAL = -1022,
        A3D_CRV_PARABOLA_CANNOT_CREATE_CANONICAL = -1023,
        A3D_CRV_OFFSET_CANNOT_CREATE_CANONICAL = -1041,
        A3D_CRV_EQUATION_CANNOT_CREATE_CANONICAL = -1051,
        A3D_CRV_TRANSFORM_CANNOT_CREATE_CANONICAL = -1052,
        A3D_CRV_CRVONSURF_CANNOT_CREATE_CANONICAL = -1053,
        A3D_CRV_HELIX_CANNOT_CREATE_CANONICAL = -1054,
        A3D_CRV_POLYLINE_CANNOT_CREATE_CANONICAL = -1061,
        A3D_CRV_INTERSECTION_CANNOT_CREATE_CANONICAL = -1063,
        A3D_CRV_NURBS_CANNOT_ACCESS_INTERNAL = -1070,
        A3D_CRV_NURBS_CANNOT_ACCESS_CONTROL_POINTS = -1072,
        A3D_CRV_NURBS_INCONSISTENT_DATA = -1073,
        A3D_CRV_NURBS_CANNOT_ACCESS_APPROX = -1074,
        A3D_CRV_NURBS_TOO_TINY_TOLERANCE = -1075,
        A3D_CRV_COMPOSITE_CANNOT_CREATE_CANONICAL = -1081,
        A3D_SRF_CANNOT_ACCESS_CANONICAL = -1500,
        A3D_SRF_CANNOT_CREATE_CANONICAL = -1501,
        A3D_SRF_NURBS_CANNOT_ACCESS_APPROX = -1502,
        A3D_SRF_NURBS_CANNOT_KEEP_PARAMETERIZATION = -1503,
        A3D_SRF_NURBS_TOO_TINY_TOLERANCE = -1504,
        A3D_SRF_PLANE_CANNOT_CREATE_CANONICAL = -1521,
        A3D_SRF_INVALID_PARAMETERS = -1522,
        A3D_EMPTY_STRING = -2000,
        A3D_DEFAULT_COLOR = -2001,
        A3D_DEFAULT_LINEPATTERN = -2002,
        A3D_DEFAULT_STYLE = -2003,
        A3D_DEFAULT_MATERIAL = -2004,
        A3D_DEFAULT_PICTURE = -2005,
        A3D_DEFAULT_PATTERN = -2006,
        A3D_BASE_BAD_ENTITY_TYPE = -2050,
        A3D_BASEWITHGRAPHICS_BAD_ENTITY_TYPE = -2051,
        A3D_BASEWITHGRAPHICS_INCONSISTENT_EMPTY = -2052,
        A3D_INVALID_COLOR_INDEX = -2101,
        A3D_INVALID_LINEPATTERN_INDEX = -2102,
        A3D_INVALID_STYLE_INDEX = -2103,
        A3D_INVALID_MATERIAL_INDEX = -2104,
        A3D_INVALID_PICTURE_INDEX = -2105,
        A3D_INVALID_PATTERN_INDEX = -2106,
        A3D_INVALID_TEXTURE_DEFINITION_INDEX = -2107,
        A3D_INVALID_TEXTURE_APPLICATION_INDEX = -2108,
        A3D_INVALID_UNIT_INDEX = -2109,
        A3D_INVALID_PICTURE_FORMAT = -2200,
        A3D_RI_CANNOT_ACCESS_TESS = -2500,
        A3D_RI_CANNOT_ATTACH_BREPDATA = -2501,
        A3D_RI_CANNOT_ATTACH_TESS = -2502,
        A3D_RI_BREPMODEL_CANNOT_ACCESS_GEOMETRY = -2503,
        A3D_RI_CRV_INCONSISTENT_DATA = -2510,
        A3D_RI_PLANE_INCONSISTENT_DATA = -2511,
        A3D_RI_BREPMODEL_INCONSISTENT_DATA = -2512,
        A3D_SET_INCONSISTENT_EMPTY = -2520,
        A3D_CSYS_INCONSISTENT_EMPTY = -2530,
        A3D_POINTSET_BADSIZE = -2540,
        A3D_MODELFILE_INCONSISTENT_EMPTY = -3000,
        A3D_MODELFILE_INCONSISTENT_UNIT = -3001,
        A3D_PRODUCTOCCURRENCE_INCONSISTENT_EMPTY = -3010,
        A3D_PRODUCTOCCURRENCE_INCONSISTENT_PART_EXTERNAL = -3011,
        A3D_PARTDEFINITION_INCONSISTENT_EMPTY = -3020,
        A3D_ENTITYREFERENCE_INCONSISTENT_REFERENCE = -3030,
        A3D_ENTITYREFERENCE_INCONSISTENT = -3031,
        A3D_INTERVAL_INCONSISTENT_DATA = -3500,
        A3D_TRANSFORMATION3D_NON_ORTHO_NOR_UNIT = -3520,
        A3D_TRANSFORMATION3D_INCONSISTENT = -3521,
        A3D_BREPDATA_INCONSISTENT_DATA = -4000,
        A3D_BREPDATA_CANNOT_CREATE = -4001,
        A3D_BREPDATA_CANNOT_GETBOUNDINGBOX = -4002,
        A3D_BREPDATA_CANNOT_SETBOUNDINGBOX = -4003,
        A3D_TOPOCONTEXT_INVALID = -4004,
        A3D_CONNEX_INCONSISTENT_DATA = -4010,
        A3D_SHELL_INCONSISTENT_DATA = -4020,
        A3D_SHELL_BAD_ORIENTATION_DATA = -4021,
        A3D_SHELL_CANNOT_CREATE = -4022,
        A3D_FACE_INCONSISTENT_DATA = -4030,
        A3D_FACE_CANNOT_LIFT_CRV_INTERNAL1 = -4031,
        A3D_FACE_CANNOT_LIFT_CRV_INTERNAL2 = -4032,
        A3D_FACE_CANNOT_LIFT_CRV_INTERNAL3 = -4033,
        A3D_FACE_INCONSISTENT_DOMAIN = -4034,
        A3D_LOOP_INCONSISTENT_DATA = -4400,
        A3D_LOOP_BAD_ORIENTATION_DATA = -4401,
        A3D_LOOP_CANNOT_COMPUTE_ORIENTATION = -4402,
        A3D_LOOP_CANNOT_FIND_OUTER_LOOP = -4403,
        A3D_COEDGE_INCONSISTENT_DATA = -4500,
        A3D_COEDGE_BAD_ORIENTATION_DATA = -4501,
        A3D_EDGE_BAD_INTERVAL = -4600,
        A3D_EDGE_INCONSISTENT_DATA = -4601,
        A3D_EDGE_BAD_3DCURVE = -4602,
        A3D_SINGLEWIREBODY_INCONSISTENT_DATA = -4700,
        A3D_SINGLEWIREBODY_CANNOT_CREATE = -4701,
        A3D_TOPO_VERTICES_MISSING = -4800,
        A3D_TOPO_GEOMETRY_MISSING = -4801,
        A3D_TOPO_CONSISTENCY = -4802,
        A3D_TOPO_NON_CONNEX_SHELL = -4803,
        A3D_TOPO_WRONG_TOLERANCES = -4804,
        A3D_TOPO_OPEN_SOLID = -4805,
        A3D_TOPO_MULTIPLEVERTEX_INCONSISTENT_DATA = -4900,
        A3D_TESS3D_NORMALS_INCONSISTENT_DATA = -7010,
        A3D_TESS3D_NORMALS_BAD_SIZE = -7011,
        A3D_TESS3D_NORMALS_ISNAN = -7012,
        A3D_TESS3D_FACE_INCONSISTENT_DATA = -7020,
        A3D_TESSFACE_TRIANGULATED_INCONSISTENT_DATA = -7030,
        A3D_TESSFACE_TRIANGULATED_INCONSISTENT_EMPTY = -7031,
        A3D_TESSFACE_USEDENTITIES_BAD_TYPE = -7032,
        A3D_TESSFACE_STARTTRIANGULATED_INCONSISTENT_DATA = -7033,
        A3D_TESSFACE_STARTWIRE_INCONSISTENT_DATA = -7034,
        A3D_TESSFACE_STYLEINDEXESSIZE_INCONSISTENT_DATA = -7035,
        A3D_TESSFACE_RGBAVERTICESSIZE_INCONSISTENT_DATA = -7036,
        A3D_TESSWIRE_RGBAVERTICESSIZE_INCONSISTENT_DATA = -7052,
        A3D_TESSMARKUP_HAS_INVALID_FONTKEY = -7060,
        A3D_TESSMARKUP_HAS_INVALID_TEXT_INDEX = -7061,
        A3D_TESSBASE_POINTS_INCONSISTENT_DATA = -7070,
        A3D_TESSBASE_POINTS_BAD_SIZE = -7071,
        A3D_TESSBASE_INCONSISTENT = -7072,
        A3D_TESSBASE_BAD_TYPE = -7100,
        A3D_TESSBASE_BAD_INIT = -7101,
        A3D_TESSBASE_BAD_ONENORMAL = -7102,
        A3D_TESSBASE_BAD_INDEX = -7103,
        A3D_TESSBASE_BAD_VERTEX = -7104,
        A3D_TOOLS_NURBSCONVERT_GENERAL_FAILURE = -8000,
        A3D_TOOLS_NURBSCONVERT_SURFACE_FAILURE = -8001,
        A3D_TOOLS_NURBSCONVERT_UV_FAILURE = -8002,
        A3D_TOOLS_NURBSCONVERT_3D_FAILURE = -8003,
        A3D_TOOLS_SPLIT_FAILURE = -8005,
        A3D_TOOLS_COMPUTE_UV_FAILURE = -8006,
        A3D_TOOLS_COMPUTE_3D_FAILURE = -8007,
        A3D_TOOLS_UNITIZE = -8008,
        A3D_TOOLS_CLAMP_UV = -8009,
        A3D_TOOLS_DUPLICATE = -8010,
        A3D_TOOLS_INVALID_SECTION_PLANE = -8011,
        A3D_TOOLS_CONTINUE_ON_ERROR = -8012,
        A3D_TOOLS_TESSELLATION_ISSUE = -8013,
        A3D_TOOLS_PHYSICALPROPERTIES_FAILURE = -8014,
        A3D_ANNOTATIONSET_INCONSISTENT_EMPTY = -9000,
        A3D_ANNOTATIONSET_WITH_NULL_ELEMENT = -9001,
        A3D_ANNOTATIONITEM_INCONSISTENT_EMPTY = -9005,
        A3D_MARKUP_CANNOT_ATTACH_TESS = -9020,
        A3D_MARKUP_CANNOT_ACCESS_TESS = -9021,
        A3D_MARKUP_CANNOT_ACCESS_FONT = -9040,
        A3D_MARKUP_CANNOT_CREATE_FONTKEY = -9041,
        A3D_MARKUP_INVALID_FONTKEY = -9042,
        A3D_MARKUP_SEMANTIC_DEFINITION_NOT_SET = -9043,
        A3D_MARKUP_SEMANTIC_TOL_VALUE_NOT_SET = -9044,
        A3D_LOAD_INVALID_FILE_NAME = -10000,
        A3D_LOAD_MULTI_MODELS_CADFILE = -10001,
        A3D_LOAD_CANNOT_ACCESS_CADFILE = -10002,
        A3D_LOAD_CANNOT_READ_SETTINGS = -10003,
        A3D_LOAD_MISSING_COMPONENTS = -10004,
        A3D_LOAD_INVALID_FILE_FORMAT = -10005,
        A3D_LOAD_READER_NOT_IMPLEMENTED = -10006,
        A3D_LOAD_CANNOT_LOAD_MODEL = -10007,
        A3D_LOAD_CANNOT_LOAD_MULTIENTRY = -10008,
        A3D_LOAD_EMPTY_MULTI_MODEL = -10009,
        A3D_LOAD_INVALID_READER_FOR_INCREMENTAL_LOAD = -10010,
        A3D_LOAD_INVALID_PARAMETERS_FOR_INCREMENTAL_LOAD = -10011,
        A3D_LOAD_CANNOT_USE_MULTIPROCESS = -10012,
        A3D_LOAD_FILE_TOO_OLD = -10013,
        A3D_LOAD_FILE_TOO_RECENT = -10014,
        A3D_LOADPRC_INITIALIZATION_FAILURE = -10300,
        A3D_LOADPRC_CANNOT_OPEN_FILE = -10301,
        A3D_LOADPRC_READING_ERROR = -10302,
        A3D_LOADPRC_BUILD_ERROR = -10303,
        A3D_LOADPRC_PDFLINIT_ERROR = -10304,
        A3D_LOADPRC_INVALID_ANNOT_INDEX = -10305,
        A3D_LOADPRC_INVALID_ANNOT = -10306,
        A3D_LOADPRC_EMPTY_FILE = -10307,
        A3D_LOADPRC_NO_3D = -10308,
        A3D_WRITE_ERROR = -10400,
        A3D_WRITE_CANNOT_LOAD_WRITER = -10401,
        A3D_WRITE_WRITER_NOT_IMPLEMENTED = -10402,
        A3D_WRITE_INVALID_FILE_NAME = -10403,
        A3D_WRITE_INVALID_INPUT = -10404,
        A3D_WRITE_KEEPPARSEDENTITIES_DISABLED = -10405,
        A3D_WRITE_HTMLCONVERSION_FAILED = -10406,
        A3D_WRITE_INVALID_INPUT_FILE_NAME = -10407,
        A3D_WRITE_PERMISSION_DENIED = -10408,
        A3D_WRITE_NO_SPACE_ON_DEVICE = -10409,
        A3D_DRW_CANNOT_CREATE = -11000,
        A3D_DRW_SHEET_CANNOT_CREATE = -11001,
        A3D_DRW_SHEET_FORMAT_CANNOT_CREATE = -11002,
        A3D_DRW_SHEET_INVALID_SIZE = -11003,
        A3D_DRW_SHEET_INVALID_SCALE = -11004,
        A3D_DRW_VIEW_CANNOT_CREATE = -11005,
        A3D_DRW_VIEW_INVALID_SCALE = -11006,
        A3D_DRW_VIEW_INVALID_TYPE = -11007,
        A3D_DRW_BLOCK_CANNOT_CREATE = -11008,
        A3D_DRW_OPERATOR_CANNOT_CREATE = -11009,
        A3D_DRW_OPERATOR_INVALID_TYPE = -11010,
        A3D_DRW_CURVE_CANNOT_CREATE = -11011,
        A3D_DRW_CURVE_INVALID_DIMENSION = -11012,
        A3D_DRW_CURVE_BAD_INTERVAL = -11013,
        A3D_DRW_FILLEDAREA_CANNOT_CREATE = -11014,
        A3D_DRW_FILLEDAREA_INVALID_MODE = -11015,
        A3D_DRW_FILLEDAREA_INVALID_SCALE = -11016,
        A3D_DRW_FILLEDAREA_CLOSED_BOUNDARY = -11017,
        A3D_DRW_PICTURE_CANNOT_CREATE = -11018,
        A3D_DRW_VERTICES_CANNOT_CREATE = -11019,
        A3D_MATH_INCONSISTENT_DATA = -40000,
        A3D_MATH_FRACTION_INCONSISTENT_NUMERATOR = -40001,
        A3D_MATH_FRACTION_INCONSISTENT_DENOMINATOR = -40002,
        A3D_CALLBACK_MEMORY_FUNCTIONS_ALREADY_SET = -900000,
        A3D_CALLBACK_INVALID_BREAK_VALUE = -900001,
        A3D_CALLBACK_CONTINUE = -900002,
        A3DPDF_PDFLIB_ERROR = -1000000,
        A3DPDF_ONLY_ONE_PAGE_AUTHORIZED = -1000001,
        A3DPDF_3D_ANNOT_REQUIRED = -1000002,
        A3DPDF_ERR_AFTER_SAVE = -1000003,
        A3DPDF_OPT_NOT_PERMITTED = -1000004,
        A3DPDF_FILE_ALREADY_OPEN = -1000005,
        A3DPDF_FILE_LOCKED = -1000006,
        A3DPDF_BAD_FONT_PARAMETERS = -1000007,
        A3DPDF_BAD_PARAMETERS = -1000008,
        A3DPDF_CANNOT_ACCESS_FILE = -1000009,
        A3DPDF_UNKNOWN_FIELD = -1000010,
        A3DPDF_DEFAULT_VIEW_ERROR = -1000011,
        A3DPDF_INVALID_DIMENSIONS = -1000014,
        A3DPDF_MEMORY_ERROR = -1000015,
        A3DPDF_CANNOT_FIND_FONT = -1000016,
        A3DPDF_CANNOT_CREATE_ENCODING = -1000017,
        A3DPDF_CANNOT_CREATE_FONT = -1000018,
        A3DPDF_CANNOT_CONVERT_PICTURE = -1000019,
        A3DPDF_CANNOT_SNAPSHOT_VIEW_WITHOUT_CAMERA = -1000020,
        A3DPDF_CANNOT_LOAD_TABLETOPDF_DLL = -1000021,
        A3DPDF_HTML_TABLE_ERROR = -1000022,
        A3DPDF_HTML_STYLE_ERROR = -1000023,
        A3DPDF_CANNOT_INITIALIZE_RESOURCES = -1000024,
        A3DPDF_INVALID_PAGE_INDEX = -1000025,
        A3DPDF_CANNOT_GENERATE_IMAGE_FROM_VIEW = -1000026,
        A3DPDF_ANIMATION_NULL_MOTION = -1000027,
        A3DPDF_SLIDETABLE_NBCOLUMNS_ERROR = -1000028,
        A3DPDF_SLIDETABLE_TEXTDATA_ERROR = -1000029,
        A3DPDF_CANNOT_LOAD_PDFLIB_DLL = -1000030,
        A3DPDF_CANNOT_LOAD_IMAGEMAGICK_DLL = -1000031,
        A3DPDF_NO_3D_ON_PAGE = -1000032,
        A3DPDF_3D_NOTFOUND_ON_PAGE = -1000033,
        A3DPDF_CANNOT_READSTREAM = -1000035,
        A3DPDF_CANNOT_CONVERTSTREAM = -1000036,
        A3DPDF_SLIDETABLE_SLIDER_ERROR = -1000037,
        A3DPDF_SLIDETABLE_TEXT_FIELD_ERROR = -1000038,
        A3DPDF_SLIDETABLE_NOT_EXIST = -1000039,
        A3DPDF_CAROUSEL_NOT_EXIST = -1000040,
        A3DPDF_XML_VERSION_INCOMPATIBLE = -1000041,
        A3DPDF_INVALID_VIEW_INDEX = -1000042,
        A3DPDF_CANNOT_CREATE_LAYER = -1000043,
        A3DPDF_TABLE_FRAME_PROBLEM = -1000044,
        A3DPDF_CANNOT_EMBED_FONT = -1000045,
        A3DPDF_INVALID_LAYER_INDEX = -1000046,
        A3DPDF_IMAGE_NOT_INSERTED = -1000047,
        A3DPDF_IMAGE_UNKNOWNFORMAT = -1000048,
        A3DPDF_DOCUMENT_NULL = -1000049,
        A3DPDF_ANNOT_NOT_INSERTED = -1000050,
        A3DPDF_EMPTY_DOCUMENT = -1000051,
        A3DPDF_CANNOT_LOAD_PDFPARSER_DLL = -1000055,
        A3DPDF_TABLE_DEFINITION_ERROR = -1000056,
        A3DPDF_FILE_NEEDPASSWORD = -1000057,
        A3DPDF_FILE_INVALIDPDF = -1000058,
        A3DPDF_FILE_TOOBIG = -1000059,
        A3DPDF_FILE_INVALIDFILENAME = -1000060,
        A3DPDF_FILE_INCOMPATIBLE_FONT_ENCODING = -1000061,
        A3DPDF_FILE_INCOMPLETE_FONT_PACKAGE = -1000062,
        A3DPDF_FILE_INCOMPATIBLE_CODEPAGE = -1000063,
        A3DPDF_XML_LOAD_ERROR = -1000064,
        A3DPDF_XML_PARSING_ERROR = -1000065,
        A3DPDF_INVALID_INDEX = -1000066,
        A3D_PARASOLID_ERROR = -2000000,
        A3D_PARASOLID_ERROR_970 = -2000970,
        A3D_PARASOLID_ERROR_555 = -2000555,
        A3D_HEPB_MISSING = -3000001,
        A3D_BODYSHOP_MISSING = -3000002,
        A3D_DELTAFRUSTRUM_MISSING = -3000003,
        A3D_PARASOLID_MEMORY_ERROR = -3000004
}

    public enum EA3DFRMEnumValue_Hole
    {
        kA3DFRMEnumValue_HoleShape_None = 0,
        kA3DFRMEnumValue_HoleShape_Simple = 1,
        kA3DFRMEnumValue_HoleShape_Bore = 2,
        kA3DFRMEnumValue_HoleShape_Sunk = 3,
        kA3DFRMEnumValue_HoleShape_Tapered = 4,
        kA3DFRMEnumValue_HoleShape_Sketch = 5,
        kA3DFRMEnumValue_HoleShape_General = 6,
        kA3DFRMEnumValue_HoleShape_Standard = 7,
        kA3DFRMEnumValue_HoleShape_StandardClearance = 8,
        kA3DFRMEnumValue_HoleShape_ByElement = 9
}

    public enum EA3DFRMEnumValue_DepthLevel
    {
        kA3DFRMEnumValue_DepthLevel_None = 0,
        kA3DFRMEnumValue_DepthLevel_Start = 1,
        kA3DFRMEnumValue_DepthLevel_Neck = 2,
        kA3DFRMEnumValue_DepthLevel_VStart = 3,
        kA3DFRMEnumValue_DepthLevel_End = 4,
        kA3DFRMEnumValue_DepthLevel_Profile = 5
}

    public enum EA3DFRMDefinitionHoleType
    {
        kA3DFRMDefinitionHoleType_None = 0,
        kA3DFRMDefinitionHoleType_RectangularDefinition = 1,
        kA3DFRMDefinitionHoleType_ChamferDefinition = 2,
        kA3DFRMDefinitionHoleType_CboreDefinition = 3,
        kA3DFRMDefinitionHoleType_SunkDefinition = 4,
        kA3DFRMDefinitionHoleType_TaperedDefinition = 5,
        kA3DFRMDefinitionHoleType_StandardDefinition = 6,
        kA3DFRMDefinitionHoleType_ElementDefinition = 7
}

    public enum EA3DFRMEnumValue_Pattern
    {
        kA3DFRMEnumValue_Pattern_None = 0,
        kA3DFRMEnumValue_Pattern_General = 1,
        kA3DFRMEnumValue_Pattern_Linear = 2,
        kA3DFRMEnumValue_Pattern_Cyclic = 3,
        kA3DFRMEnumValue_Pattern_Matrix = 4,
        kA3DFRMEnumValue_Pattern_CyclicMultiple = 5,
        kA3DFRMEnumValue_Pattern_Polygonal = 6,
        kA3DFRMEnumValue_Pattern_PolygonalMultiple = 7,
        kA3DFRMEnumValue_Pattern_Spiral = 8,
        kA3DFRMEnumValue_Pattern_ByReference = 9,
        kA3DFRMEnumValue_Pattern_Point = 10,
        kA3DFRMEnumValue_Pattern_Curve = 11,
        kA3DFRMEnumValue_Pattern_Table = 12,
        kA3DFRMEnumValue_Pattern_Dimension = 13,
        kA3DFRMEnumValue_Pattern_Fill = 14,
        kA3DFRMEnumValue_Pattern_LinearMultiple = 15
}

    public enum EA3DFRMDefinitionPatternType
    {
        kA3DFRMDefinitionPatternType_None = 0,
        kA3DFRMDefinitionPatternType_PatternMaster = 1,
        kA3DFRMDefinitionPatternType_PolygonalShape = 2,
        kA3DFRMDefinitionPatternType_SpiralShape = 3,
        kA3DFRMDefinitionPatternType_DirectionSpacing = 4,
        kA3DFRMDefinitionPatternType_AxialSpacing = 5,
        kA3DFRMDefinitionPatternType_RadialSpacing = 6,
        kA3DFRMDefinitionPatternType_PolygonalSpacing = 7,
        kA3DFRMDefinitionPatternType_SpiralSpacing = 8,
        kA3DFRMDefinitionPatternType_InstanceStatus = 9,
        kA3DFRMDefinitionPatternType_InstanceInformation = 10
}

    public enum EA3DFRMEnumValue_PatternMaster
    {
        kA3DFRMEnumValue_PatternMaster_None = 0,
        kA3DFRMEnumValue_PatternMaster_Features = 1,
        kA3DFRMEnumValue_PatternMaster_CurrentBody = 2,
        kA3DFRMEnumValue_PatternMaster_Geometries = 3
}

    public enum EA3DFRMParameterType
    {
        kA3DParameterType_None = 0,
        kA3DParameterType_Information = 1,
        kA3DParameterType_Type = 2,
        kA3DParameterType_Specification = 3,
        kA3DParameterType_FeatureDefinition = 4,
        kA3DParameterType_Definition = 5,
        kA3DParameterType_Container = 6,
        kA3DParameterType_ContainerInternal = 7,
        kA3DParameterType_Data = 8
}

    public enum EA3DFRMFamily
    {
        kA3DFamily_None = 0,
        kA3DFamily_Root = 1,
        kA3DFamily_Information = 2,
        kA3DFamily_Type = 3,
        kA3DFamily_FeatureDefinition = 4,
        kA3DFamily_DoubleData = 5,
        kA3DFamily_IntegerData = 6,
        kA3DFamily_StringData = 7,
        kA3DFamily_Value = 8,
        kA3DFamily_Definition = 9,
        kA3DFamily_Definition_Hole = 10,
        kA3DFamily_Definition_Pattern = 11
}

    public enum EA3DFRMRoot
    {
        kA3DFRMRoot_None = 0,
        kA3DFRMRoot_Node = 1,
        kA3DFRMRoot_Container = 2,
        kA3DFRMRoot_Package = 3
}

    public enum EA3DFRMDoubleDataType
    {
        kA3DFRMDoubleNone = 0,
        kA3DFRMDoubleValue = 1,
        kA3DFRMDoubleUnit = 2,
        kA3DFRMDoubleOffset = 3,
        kA3DFRMDoubleDepth = 4,
        kA3DFRMDoubleDiameter = 5,
        kA3DFRMDoubleAngle = 6,
        kA3DFRMDoublePitch = 7,
        kA3DFRMDoubleDistance = 8,
        kA3DFRMDoubleExtensionAndStep = 9,
        kA3DFRMDoubleLinearParameter = 10,
        kA3DFRMDoubleUVParameter = 11
}

    public enum EA3DFRMIntegerDataType
    {
        kA3DFRMIntegerDataNone = 0,
        kA3DFRMIntegerDataValue = 1,
        kA3DFRMIntegerDataBoolean = 2,
        kA3DFRMIntegerDataIndex = 3,
        kA3DFRMIntegerDataKeepSpecification = 4,
        kA3DFRMIntegerDataRadialAlignment = 5,
        kA3DFRMIntegerDataClockwise = 6,
        kA3DFRMIntegerDataId = 7,
        kA3DFRMIntegerDataFlip = 8,
        kA3DFRMIntegerDataType = 9,
        kA3DFRMIntegerDataCount = 10,
        kA3DFRMIntegerDataSize = 11,
        kA3DFRMIntegerDataNbStart = 12
}

    public enum EA3DFRMStringDataType
    {
        kA3DFRMStringDataNone = 0,
        kA3DFRMStringDataName = 1,
        kA3DFRMStringDataAttribute = 2,
        kA3DFRMStringDataType = 3,
        kA3DFRMStringDataValue = 4,
        kA3DFRMStringDataOption = 5
}

    public enum EA3DFRMEnumDataType
    {
        kA3DFRMEnumDataType_None = 0,
        kA3DFRMEnumDataType_CAD = 1,
        kA3DFRMEnumDataType_Mode = 2,
        kA3DFRMEnumDataType_Depth = 3,
        kA3DFRMEnumDataType_Pattern = 4,
        kA3DFRMEnumDataType_HoleShape = 5,
        kA3DFRMEnumDataType_DepthLevel = 6,
        kA3DFRMEnumDataType_RevolveAngle = 7,
        kA3DFRMEnumDataType_Chamfer = 8,
        kA3DFRMEnumDataType_Fillet = 9,
        kA3DFRMEnumDataType_FilletLength = 10,
        kA3DFRMEnumDataType_FilletConic = 11,
        kA3DFRMEnumDataType_LengthMode = 12,
        kA3DFRMEnumDataType_PatternMaster = 13,
        kA3DFRMEnumDataType_ReferenceMaster = 14
}

    public enum EA3DFRMDefinitionType
    {
        kA3DFRMDefinitionType_None = 0,
        kA3DFRMDefinitionType_Depth = 1,
        kA3DFRMDefinitionType_DepthFrom = 2,
        kA3DFRMDefinitionType_Position = 3,
        kA3DFRMDefinitionType_Direction = 4,
        kA3DFRMDefinitionType_Thread = 5,
        kA3DFRMDefinitionType_Shape = 6,
        kA3DFRMDefinitionType_Reference = 7,
        kA3DFRMDefinitionType_Sketch = 8,
        kA3DFRMDefinitionType_RevolveAngle = 9,
        kA3DFRMDefinitionType_RevolveAngleFrom = 10,
        kA3DFRMDefinitionType_Axis = 11,
        kA3DFRMDefinitionType_Chamfer = 12,
        kA3DFRMDefinitionType_FilletLength = 13,
        kA3DFRMDefinitionType_ReferenceMaster = 14
}

    public enum EA3DFRMFeatureDefinitionType
    {
        kA3DFRMFeatureDefinitionType_None = 0,
        kA3DFRMFeatureDefinitionType_Hole = 1,
        kA3DFRMFeatureDefinitionType_Pattern = 2,
        kA3DFRMFeatureDefinitionType_Sketch = 3,
        kA3DFRMFeatureDefinitionType_Thread = 4,
        kA3DFRMFeatureDefinitionType_Extrude = 5,
        kA3DFRMFeatureDefinitionType_Revolve = 6,
        kA3DFRMFeatureDefinitionType_Cosmetic = 7,
        kA3DFRMFeatureDefinitionType_Chamfer = 8,
        kA3DFRMFeatureDefinitionType_Fillet = 9,
        kA3DFRMFeatureDefinitionType_Mirror = 10,
        kA3DFRMFeatureDefinitionType_Symmetry = 11,
        kA3DFRMFeatureDefinitionType_Translate = 12,
        kA3DFRMFeatureDefinitionType_Rotate = 13
}

    public enum EA3DFRMDataType
    {
        kA3DFRMDataNone = 0,
        kA3DFRMDataInteger = 1,
        kA3DFRMDataDouble = 2,
        kA3DFRMDataString = 3,
        kA3DFRMDataEnum = 4
}

    public enum EA3DFRMValueType
    {
        kA3DFRMValueType_None = 0,
        kA3DFRMValueType_Length = 1,
        kA3DFRMValueType_Angle = 2,
        kA3DFRMValueType_Diameter = 3,
        kA3DFRMValueType_Radius = 4,
        kA3DFRMValueType_Depth = 5,
        kA3DFRMValueType_Thickness = 6,
        kA3DFRMValueType_Offset = 7,
        kA3DFRMValueType_Distance = 8,
        kA3DFRMValueType_Coords = 9,
        kA3DFRMValueType_Vector = 10,
        kA3DFRMValueType_Matrix = 11,
        kA3DFRMValueType_Area = 12,
        kA3DFRMValueType_Volume = 13,
        kA3DFRMValueType_Mass = 14,
        kA3DFRMValueType_Time = 15
}

    public enum EA3DFRMLinkType
    {
        kA3DFRMLink_None = 0,
        kA3DFRMLink_Outcome = 1,
        kA3DFRMLink_Position = 2,
        kA3DFRMLink_Construction = 3,
        kA3DFRMLink_Support = 4
}

    public enum EA3DFRMStatus
    {
        kA3DFRMStatus_Success = 0,
        kA3DFRMStatus_Failed = 1,
        kA3DFRMStatus_NotYetImplemented = 2
}

    public enum EA3DFRMEnumValue_CadType
    {
        kA3DFRMEnumValue_CadType_None = 0,
        kA3DFRMEnumValue_CadType_Sketch = 1,
        kA3DFRMEnumValue_CadType_Plane = 2,
        kA3DFRMEnumValue_CadType_Point = 3,
        kA3DFRMEnumValue_CadType_CoordinateSystem = 4,
        kA3DFRMEnumValue_CadType_Direction = 5,
        kA3DFRMEnumValue_CadType_Curve = 6,
        kA3DFRMEnumValue_CadType_Analysis = 7,
        kA3DFRMEnumValue_CadType_ImportedSolid = 8,
        kA3DFRMEnumValue_CadType_Extrusion = 9,
        kA3DFRMEnumValue_CadType_Revolution = 10,
        kA3DFRMEnumValue_CadType_Surface = 11,
        kA3DFRMEnumValue_CadType_Block = 12,
        kA3DFRMEnumValue_CadType_Sphere = 13,
        kA3DFRMEnumValue_CadType_Cone = 14,
        kA3DFRMEnumValue_CadType_Cylinder = 15,
        kA3DFRMEnumValue_CadType_Torus = 16,
        kA3DFRMEnumValue_CadType_Dome = 17,
        kA3DFRMEnumValue_CadType_Helix = 18,
        kA3DFRMEnumValue_CadType_TruncatedPrism = 19,
        kA3DFRMEnumValue_CadType_Hole = 20,
        kA3DFRMEnumValue_CadType_Chamfer = 21,
        kA3DFRMEnumValue_CadType_Blend = 22,
        kA3DFRMEnumValue_CadType_Fillet = 23,
        kA3DFRMEnumValue_CadType_Groove = 24,
        kA3DFRMEnumValue_CadType_Pocket = 25,
        kA3DFRMEnumValue_CadType_Sweep = 26,
        kA3DFRMEnumValue_CadType_Pipe = 27,
        kA3DFRMEnumValue_CadType_Group = 28,
        kA3DFRMEnumValue_CadType_Mirror = 29,
        kA3DFRMEnumValue_CadType_Pattern = 30,
        kA3DFRMEnumValue_CadType_GroupPattern = 31,
        kA3DFRMEnumValue_CadType_Instance = 32,
        kA3DFRMEnumValue_CadType_Package = 33,
        kA3DFRMEnumValue_CadType_Shell = 34,
        kA3DFRMEnumValue_CadType_Trim = 35,
        kA3DFRMEnumValue_CadType_Split = 36,
        kA3DFRMEnumValue_CadType_Sew = 37,
        kA3DFRMEnumValue_CadType_Rib = 38,
        kA3DFRMEnumValue_CadType_Draft = 39,
        kA3DFRMEnumValue_CadType_Hollow = 40,
        kA3DFRMEnumValue_CadType_Quilt = 41,
        kA3DFRMEnumValue_CadType_LocalPush = 42,
        kA3DFRMEnumValue_CadType_BooleanOperation = 43,
        kA3DFRMEnumValue_CadType_Intersect = 44,
        kA3DFRMEnumValue_CadType_CutOut = 45,
        kA3DFRMEnumValue_CadType_Merge = 46,
        kA3DFRMEnumValue_CadType_Translate = 47,
        kA3DFRMEnumValue_CadType_Rotate = 48,
        kA3DFRMEnumValue_CadType_Scale = 49,
        kA3DFRMEnumValue_CadType_Offset = 50,
        kA3DFRMEnumValue_CadType_Transformation = 51,
        kA3DFRMEnumValue_CadType_Thread = 52,
        kA3DFRMEnumValue_CadType_Cosmetic = 53,
        kA3DFRMEnumValue_CadType_Material = 54,
        kA3DFRMEnumValue_CadType_Thickness = 55,
        kA3DFRMEnumValue_CadType_RemoveFace = 56,
        kA3DFRMEnumValue_CadType_UserDefined = 57,
        kA3DFRMEnumValue_CadType_Member = 58,
        kA3DFRMEnumValue_CadType_Symmetry = 59
}

    public enum EA3DFRMEnumValue_ModeType
    {
        kA3DFRMEnumValue_ModeType_None = 0,
        kA3DFRMEnumValue_ModeType_Cut = 1,
        kA3DFRMEnumValue_ModeType_CutOut = 2,
        kA3DFRMEnumValue_ModeType_Surface = 3,
        kA3DFRMEnumValue_ModeType_SurfaceCappedEnds = 4,
        kA3DFRMEnumValue_ModeType_PatternGeometry = 5,
        kA3DFRMEnumValue_ModeType_Symbolic = 6
}

    public enum EA3DFRMEnumValue_DepthType
    {
        kA3DFRMEnumValue_DepthType_None = 0,
        kA3DFRMEnumValue_DepthType_Blind = 1,
        kA3DFRMEnumValue_DepthType_ThruAll = 2,
        kA3DFRMEnumValue_DepthType_Reference = 3,
        kA3DFRMEnumValue_DepthType_Next = 4,
        kA3DFRMEnumValue_DepthType_Until = 5,
        kA3DFRMEnumValue_DepthType_AsReference = 6,
        kA3DFRMEnumValue_DepthType_ThreadPitchCount = 7
}

    public enum EA3DFRMEnumValue_RevolveAngleType
    {
        kA3DFRMEnumValue_RevolveAngleType_None = 0,
        kA3DFRMEnumValue_RevolveAngleType_Variable = 1,
        kA3DFRMEnumValue_RevolveAngleType_Variable_Symmetric = 2,
        kA3DFRMEnumValue_RevolveAngleType_Reference = 3,
        kA3DFRMEnumValue_RevolveAngleType_Next = 4
}

    public enum EA3DFRMEnumValue_ChamferType
    {
        kA3DFRMEnumValue_ChamferType_None = 0,
        kA3DFRMEnumValue_ChamferType_Distance_Distance = 1,
        kA3DFRMEnumValue_ChamferType_Distance1_Distance2 = 2,
        kA3DFRMEnumValue_ChamferType_Offset_Offset = 3,
        kA3DFRMEnumValue_ChamferType_Offset1_Offset2 = 4,
        kA3DFRMEnumValue_ChamferType_Length_Angle = 5,
        kA3DFRMEnumValue_ChamferType_ChordalLength_Angle = 6,
        kA3DFRMEnumValue_ChamferType_Height_Angle = 7,
        kA3DFRMEnumValue_ChamferType_Corner = 8
}

    public enum EA3DFRMEnumValue_FilletType
    {
        kA3DFRMEnumValue_FilletType_None = 0,
        kA3DFRMEnumValue_FilletType_Edge = 1,
        kA3DFRMEnumValue_FilletType_FaceToFace = 2,
        kA3DFRMEnumValue_FilletType_Tritangent = 3
}

    public enum EA3DFRMEnumValue_FilletLengthType
    {
        kA3DFRMEnumValue_FilletLengthType_None = 0,
        kA3DFRMEnumValue_FilletLengthType_Circular = 1,
        kA3DFRMEnumValue_FilletLengthType_Conic = 2,
        kA3DFRMEnumValue_FilletLengthType_Conic_Asymmetric = 3,
        kA3DFRMEnumValue_FilletLengthType_Continue = 4,
        kA3DFRMEnumValue_FilletLengthType_Continue_Asymmetric = 5,
        kA3DFRMEnumValue_FilletLengthType_Curvature = 6,
        kA3DFRMEnumValue_FilletLengthType_Curvature_Asymmetric = 7
}

    public enum EA3DFRMEnumValue_FilletConicType
    {
        kA3DFRMEnumValue_FilletConicType_None = 0,
        kA3DFRMEnumValue_FilletConicType_Boundary_Rho = 1,
        kA3DFRMEnumValue_FilletConicType_Center_Rho = 2,
        kA3DFRMEnumValue_FilletConicType_Boundary_Center = 3,
        kA3DFRMEnumValue_FilletConicType_Chordal_Rho = 4
}

    public enum EA3DFRMEnumValue_LengthModeType
    {
        kA3DFRMEnumValue_LengthModeType_None = 0,
        kA3DFRMEnumValue_LengthModeType_ByValue = 1,
        kA3DFRMEnumValue_LengthModeType_Parameter = 2,
        kA3DFRMEnumValue_LengthModeType_Reference = 3
}

    public enum EA3DFRMEnumValue_ReferenceMaster
    {
        kA3DFRMEnumValue_ReferenceMaster_None = 0,
        kA3DFRMEnumValue_ReferenceMaster_Features = 1,
        kA3DFRMEnumValue_ReferenceMaster_CurrentBody = 2,
        kA3DFRMEnumValue_ReferenceMaster_Geometries = 3
}

}
