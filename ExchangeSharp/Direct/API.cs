using System;
using System.Runtime.InteropServices;

namespace TS3D.Exchange.Direct
{
    public class API
    {
    public static int DLL_MAJORVERSION = 13;
    public static int DLL_MINORVERSION = 2;
    public static ushort DEFAULT_LAYER = ushort.MaxValue;
    public static byte DEFAULT_TRANSPARENCY = 255;
    public static double DEFAULT_LINE_WIDTH = 0.1;
    public static uint DEFAULT_COLOR_INDEX = uint.MaxValue;
    public static uint DEFAULT_PATTERN_INDEX = uint.MaxValue;
    public static ushort DEFAULT_STYLE_INDEX = ushort.MaxValue;
    public static uint DEFAULT_LINEPATTERN_INDEX = uint.MaxValue;
    public static uint DEFAULT_MATERIAL_INDEX = uint.MaxValue;
    public static uint DEFAULT_PICTURE_INDEX = uint.MaxValue;
    public static uint DEFAULT_TEXTURE_DEFINITION_INDEX = uint.MaxValue;
    public static uint DEFAULT_TEXTURE_APPLICATION_INDEX = uint.MaxValue;
    public static ushort DEFAULT_NO_UNIT = ushort.MaxValue;
    public static uint LOOP_UNKNOWN_OUTER_INDEX = uint.MaxValue;
    public static void Initialize(out A3DVector2dData d ) { 
        d = new A3DVector2dData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DVector2dData));
    }
    public static void Initialize(out A3DVector3dData d ) { 
        d = new A3DVector3dData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DVector3dData));
    }
    public static void Initialize(out A3DIntervalData d ) { 
        d = new A3DIntervalData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DIntervalData));
    }
    public static void Initialize(out A3DDomainData d ) { 
        d = new A3DDomainData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DDomainData));
        API.Initialize( out d.m_sMax );
        API.Initialize( out d.m_sMin );
    }
    public static void Initialize(out A3DBoundingBoxData d ) { 
        d = new A3DBoundingBoxData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DBoundingBoxData));
        API.Initialize( out d.m_sMax );
        API.Initialize( out d.m_sMin );
    }
    public static void Initialize(out A3DParameterizationData d ) { 
        d = new A3DParameterizationData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DParameterizationData));
        API.Initialize( out d.m_sInterval );
    }
    public static void Initialize(out A3DUVParameterizationData d ) { 
        d = new A3DUVParameterizationData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DUVParameterizationData));
        API.Initialize( out d.m_sUVDomain );
    }
    public static void Initialize(out A3DTessBaseData d ) { 
        d = new A3DTessBaseData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DTessBaseData));
    }
    public static void Initialize(out A3DTessFaceData d ) { 
        d = new A3DTessFaceData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DTessFaceData));
    }
    public static void Initialize(out A3DTess3DData d ) { 
        d = new A3DTess3DData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DTess3DData));
    }
    public static void Initialize(out A3DTess3DWireData d ) { 
        d = new A3DTess3DWireData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DTess3DWireData));
    }
    public static void Initialize(out A3DTessMarkupData d ) { 
        d = new A3DTessMarkupData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DTessMarkupData));
    }
    public static void Initialize(out A3DGraphicsData d ) { 
        d = new A3DGraphicsData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DGraphicsData));
    }
    public static void Initialize(out A3DGraphStyleData d ) { 
        d = new A3DGraphStyleData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DGraphStyleData));
    }
    public static void Initialize(out A3DGraphRgbColorData d ) { 
        d = new A3DGraphRgbColorData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DGraphRgbColorData));
    }
    public static void Initialize(out A3DGraphLinePatternData d ) { 
        d = new A3DGraphLinePatternData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DGraphLinePatternData));
    }
    public static void Initialize(out A3DGraphMaterialData d ) { 
        d = new A3DGraphMaterialData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DGraphMaterialData));
    }
    public static void Initialize(out A3DGraphPictureData d ) { 
        d = new A3DGraphPictureData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DGraphPictureData));
    }
    public static void Initialize(out A3DGraphDottingPatternData d ) { 
        d = new A3DGraphDottingPatternData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DGraphDottingPatternData));
    }
    public static void Initialize(out A3DGraphHatchingPatternLineData d ) { 
        d = new A3DGraphHatchingPatternLineData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DGraphHatchingPatternLineData));
        API.Initialize( out d.m_sOffset );
        API.Initialize( out d.m_sStart );
    }
    public static void Initialize(out A3DGraphHatchingPatternData d ) { 
        d = new A3DGraphHatchingPatternData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DGraphHatchingPatternData));
    }
    public static void Initialize(out A3DGraphSolidPatternData d ) { 
        d = new A3DGraphSolidPatternData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DGraphSolidPatternData));
    }
    public static void Initialize(out A3DGraphVPicturePatternData d ) { 
        d = new A3DGraphVPicturePatternData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DGraphVPicturePatternData));
    }
    public static void Initialize(out A3DGraphCameraData d ) { 
        d = new A3DGraphCameraData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DGraphCameraData));
        API.Initialize( out d.m_sLocation );
        API.Initialize( out d.m_sLookAt );
        API.Initialize( out d.m_sUp );
    }
    public static void Initialize(out A3DGraphAmbientLightData d ) { 
        d = new A3DGraphAmbientLightData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DGraphAmbientLightData));
    }
    public static void Initialize(out A3DGraphPointLightData d ) { 
        d = new A3DGraphPointLightData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DGraphPointLightData));
        API.Initialize( out d.m_sLocation );
    }
    public static void Initialize(out A3DGraphSpotLightData d ) { 
        d = new A3DGraphSpotLightData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DGraphSpotLightData));
        API.Initialize( out d.m_sDirection );
        API.Initialize( out d.m_sLocation );
    }
    public static void Initialize(out A3DGraphDirectionalLightData d ) { 
        d = new A3DGraphDirectionalLightData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DGraphDirectionalLightData));
        API.Initialize( out d.m_sDirection );
    }
    public static void Initialize(out A3DGraphSceneDisplayParametersData d ) { 
        d = new A3DGraphSceneDisplayParametersData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DGraphSceneDisplayParametersData));
        API.Initialize( out d.m_sRotationCenter );
    }
    public static void Initialize(out A3DMiscCascadedAttributesData d ) { 
        d = new A3DMiscCascadedAttributesData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMiscCascadedAttributesData));
        API.Initialize( out d.m_sStyle );
    }
    public static void Initialize(out A3DMiscGeneralTransformationData d ) { 
        d = new A3DMiscGeneralTransformationData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMiscGeneralTransformationData));
    }
    public static void Initialize(out A3DMiscCartesianTransformationData d ) { 
        d = new A3DMiscCartesianTransformationData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMiscCartesianTransformationData));
        API.Initialize( out d.m_sOrigin );
        API.Initialize( out d.m_sScale );
        API.Initialize( out d.m_sXVector );
        API.Initialize( out d.m_sYVector );
    }
    public static void Initialize(out A3DMiscEntityReferenceData d ) { 
        d = new A3DMiscEntityReferenceData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMiscEntityReferenceData));
    }
    public static void Initialize(out A3DMiscReferenceOnTopologyData d ) { 
        d = new A3DMiscReferenceOnTopologyData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMiscReferenceOnTopologyData));
    }
    public static void Initialize(out A3DMiscReferenceOnTessData d ) { 
        d = new A3DMiscReferenceOnTessData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMiscReferenceOnTessData));
    }
    public static void Initialize(out A3DMiscReferenceOnCsysItemData d ) { 
        d = new A3DMiscReferenceOnCsysItemData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMiscReferenceOnCsysItemData));
    }
    public static void Initialize(out A3DMiscPhysicMaterialData d ) { 
        d = new A3DMiscPhysicMaterialData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMiscPhysicMaterialData));
    }
    public static void Initialize(out A3DMiscMaterialFiberData d ) { 
        d = new A3DMiscMaterialFiberData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMiscMaterialFiberData));
    }
    public static void Initialize(out A3DMiscMaterialHoneyCombData d ) { 
        d = new A3DMiscMaterialHoneyCombData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMiscMaterialHoneyCombData));
    }
    public static void Initialize(out A3DMiscMaterialIsotropicData d ) { 
        d = new A3DMiscMaterialIsotropicData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMiscMaterialIsotropicData));
    }
    public static void Initialize(out A3DMiscMaterialOrthotropic2DData d ) { 
        d = new A3DMiscMaterialOrthotropic2DData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMiscMaterialOrthotropic2DData));
    }
    public static void Initialize(out A3DMiscMaterialOrthotropic3DData d ) { 
        d = new A3DMiscMaterialOrthotropic3DData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMiscMaterialOrthotropic3DData));
    }
    public static void Initialize(out A3DMiscMaterialAnisotropicData d ) { 
        d = new A3DMiscMaterialAnisotropicData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMiscMaterialAnisotropicData));
    }
    public static void Initialize(out A3DMiscMaterialPropertiesData d ) { 
        d = new A3DMiscMaterialPropertiesData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMiscMaterialPropertiesData));
    }
    public static void Initialize(out A3DAsmModelFileData d ) { 
        d = new A3DAsmModelFileData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DAsmModelFileData));
    }
    public static void Initialize(out A3DAsmProductOccurrenceData d ) { 
        d = new A3DAsmProductOccurrenceData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DAsmProductOccurrenceData));
    }
    public static void Initialize(out A3DAsmProductOccurrenceDataSLW d ) { 
        d = new A3DAsmProductOccurrenceDataSLW();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DAsmProductOccurrenceDataSLW));
    }
    public static void Initialize(out A3DAsmProductOccurrenceDataCat d ) { 
        d = new A3DAsmProductOccurrenceDataCat();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DAsmProductOccurrenceDataCat));
    }
    public static void Initialize(out A3DAsmProductOccurrenceDataCV5 d ) { 
        d = new A3DAsmProductOccurrenceDataCV5();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DAsmProductOccurrenceDataCV5));
    }
    public static void Initialize(out A3DAsmProductOccurrenceDataUg d ) { 
        d = new A3DAsmProductOccurrenceDataUg();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DAsmProductOccurrenceDataUg));
    }
    public static void Initialize(out A3DAsmProductOccurrenceDataProe d ) { 
        d = new A3DAsmProductOccurrenceDataProe();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DAsmProductOccurrenceDataProe));
    }
    public static void Initialize(out A3DAsmProductOccurrenceDataInv d ) { 
        d = new A3DAsmProductOccurrenceDataInv();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DAsmProductOccurrenceDataInv));
    }
    public static void Initialize(out A3DAsmProductOccurrenceDataJT d ) { 
        d = new A3DAsmProductOccurrenceDataJT();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DAsmProductOccurrenceDataJT));
    }
    public static void Initialize(out A3DAsmPartDefinitionData d ) { 
        d = new A3DAsmPartDefinitionData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DAsmPartDefinitionData));
        API.Initialize( out d.m_sBoundingBox );
    }
    public static void Initialize(out A3DAsmLayerFilterItemData d ) { 
        d = new A3DAsmLayerFilterItemData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DAsmLayerFilterItemData));
    }
    public static void Initialize(out A3DAsmEntityFilterItemData d ) { 
        d = new A3DAsmEntityFilterItemData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DAsmEntityFilterItemData));
    }
    public static void Initialize(out A3DAsmFilterData d ) { 
        d = new A3DAsmFilterData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DAsmFilterData));
        API.Initialize( out d.m_sEntityFilterItem );
        API.Initialize( out d.m_sLayerFilterItem );
    }
    public static void Initialize(out A3DRWParamsGeneralData d ) { 
        d = new A3DRWParamsGeneralData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsGeneralData));
    }
    public static void Initialize(out A3DRWParamsPmiData d ) { 
        d = new A3DRWParamsPmiData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsPmiData));
    }
    public static void Initialize(out A3DRWParamsTessellationData d ) { 
        d = new A3DRWParamsTessellationData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsTessellationData));
    }
    public static void Initialize(out A3DRWParamsSearchDirData d ) { 
        d = new A3DRWParamsSearchDirData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsSearchDirData));
    }
    public static void Initialize(out A3DRWParamsAssemblyData d ) { 
        d = new A3DRWParamsAssemblyData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsAssemblyData));
    }
    public static void Initialize(out A3DRWParamsMultiEntriesData d ) { 
        d = new A3DRWParamsMultiEntriesData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsMultiEntriesData));
    }
    public static void Initialize(out A3DRWParamsCatiaV4Data d ) { 
        d = new A3DRWParamsCatiaV4Data();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsCatiaV4Data));
    }
    public static void Initialize(out A3DRWParamsCatiaV5Data d ) { 
        d = new A3DRWParamsCatiaV5Data();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsCatiaV5Data));
    }
    public static void Initialize(out A3DRWParamsUnigraphicsData d ) { 
        d = new A3DRWParamsUnigraphicsData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsUnigraphicsData));
    }
    public static void Initialize(out A3DRWParamsProEData d ) { 
        d = new A3DRWParamsProEData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsProEData));
        d.m_eFamilyTables = A3DProEFamilyTables.A3DProEFamTabOrUseTessellation;
        d.m_bBoolOpUseGenericIfNoTess = false;
        d.m_bFlexCompUseGenericIfNoTess = false;
        d.m_bHideSkeletons = false;
    }
    public static void Initialize(out A3DRWValidationPropertiesThresholdData d ) { 
        d = new A3DRWValidationPropertiesThresholdData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWValidationPropertiesThresholdData));
        d.m_dGEOMPercentVolume = 0.5;
        d.m_dGEOMPercentSurfaceArea = 0.5;
        d.m_dGEOMPercentIndependentSurfaceArea = 0.5;
        d.m_dGEOMPercentIndependentCurveLength = 0.5;
        d.m_dGEOMDeviationCentroid = 0.1;
        d.m_dGEOMDeviationIndependentSurfaceCentroid = 0.1;
        d.m_dGEOMDeviationIndependentCurveCentroid = 0.1;
        d.m_dGEOMDeviationPointSetCentroid = 0.1;
        d.m_dGEOMDeviationBoundingBox = 0.1;
        d.m_dPMIPercentAffectedArea = 0.5;
        d.m_dPMIPercentAffectedCurveLength = 0.5;
        d.m_dPMIPercentCurveLength = 0.5;
        d.m_dPMIPercentSurfaceArea = 0.5;
        d.m_dPMIDeviationCurveCentroid = 0.1;
        d.m_dPMIDeviationSurfaceCentroid = 0.1;
        d.m_dASMDeviationNotionalSolidsCentroid = 0.1;
    }
    public static void Initialize(out A3DRWParamsStepData d ) { 
        d = new A3DRWParamsStepData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsStepData));
        API.Initialize( out d.m_sValidationPropertiesThreshold );
        d.m_eNameFromNAUO = A3DEStepNameFromNAUO.kA3DStepNameFromNAUO_DESCRIPTION;
        d.m_bSplitSHELL_BASED_SURFACE_MODEL = true;
        d.m_bHealOrientations = false;
    }
    public static void Initialize(out A3DRWParamsIGESData d ) { 
        d = new A3DRWParamsIGESData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsIGESData));
    }
    public static void Initialize(out A3DRWParamsIFCData d ) { 
        d = new A3DRWParamsIFCData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsIFCData));
        d.m_bFACETED_BREPAsOneFace = true;
    }
    public static void Initialize(out A3DRWParamsJTData d ) { 
        d = new A3DRWParamsJTData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsJTData));
        d.m_eReadTessellationLevelOfDetail = A3DEJTReadTessellationLevelOfDetail.kA3DJTTessLODHigh;
    }
    public static void Initialize(out A3DRWParamsParasolidData d ) { 
        d = new A3DRWParamsParasolidData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsParasolidData));
    }
    public static void Initialize(out A3DRWParamsSolidworksData d ) { 
        d = new A3DRWParamsSolidworksData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsSolidworksData));
        d.m_bLoadAllConfigsData = false;
        d.m_usDisplayVisibleDatum = 0;
    }
    public static void Initialize(out A3DRWParamsInventorData d ) { 
        d = new A3DRWParamsInventorData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsInventorData));
        d.m_bUseTessForFile = true;
    }
    public static void Initialize(out A3DRWParamsRhinoData d ) { 
        d = new A3DRWParamsRhinoData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsRhinoData));
        d.m_bForceRenderedModeColors = false;
    }
    public static void Initialize(out A3DRWParamsRevitData d ) { 
        d = new A3DRWParamsRevitData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsRevitData));
        d.m_ePhysicalProperties = EA3DRevitPhysicalProperties.kA3DRevitPhysicalProperties_NotComputed;
    }
    public static void Initialize(out A3DRWParamsSpecificLoadData d ) { 
        d = new A3DRWParamsSpecificLoadData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsSpecificLoadData));
        API.Initialize( out d.m_sCatiaV4 );
        API.Initialize( out d.m_sCatiaV5 );
        API.Initialize( out d.m_sIFC );
        API.Initialize( out d.m_sIGES );
        API.Initialize( out d.m_sInventor );
        API.Initialize( out d.m_sJT );
        API.Initialize( out d.m_sParasolid );
        API.Initialize( out d.m_sProE );
        API.Initialize( out d.m_sRevit );
        API.Initialize( out d.m_sRhino );
        API.Initialize( out d.m_sSolidworks );
        API.Initialize( out d.m_sStep );
        API.Initialize( out d.m_sUnigraphics );
    }
    public static void Initialize(out A3DRWParamsIncrementalLoadData d ) { 
        d = new A3DRWParamsIncrementalLoadData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsIncrementalLoadData));
    }
    public static void Initialize(out A3DRWParamsLoadData d ) { 
        d = new A3DRWParamsLoadData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsLoadData));
        API.Initialize( out d.m_sAssembly );
        API.Initialize( out d.m_sGeneral );
        API.Initialize( out d.m_sIncremental );
        API.Initialize( out d.m_sMultiEntries );
        API.Initialize( out d.m_sPmi );
        API.Initialize( out d.m_sSpecifics );
        API.Initialize( out d.m_sTessellation );
    }
    public static void Initialize(out A3DStream3DPDFData d ) { 
        d = new A3DStream3DPDFData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DStream3DPDFData));
    }
    public static void Initialize(out A3DRWParamsExportPrcData d ) { 
        d = new A3DRWParamsExportPrcData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsExportPrcData));
    }
    public static void Initialize(out A3DRWParamsExportU3DData d ) { 
        d = new A3DRWParamsExportU3DData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsExportU3DData));
    }
    public static void Initialize(out A3DRWParamsExportStepData d ) { 
        d = new A3DRWParamsExportStepData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsExportStepData));
    }
    public static void Initialize(out A3DRWParamsExportJTData d ) { 
        d = new A3DRWParamsExportJTData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsExportJTData));
        d.m_eWriteGeomTessMode = A3DEWriteGeomTessMode.kA3DWriteGeomAndTess;
        d.m_bWriteHiddenObjects = false;
        d.m_bWritePMI = true;
        d.m_eJTVersion = A3DEJTVersion.kA3DE_JT81;
    }
    public static void Initialize(out A3DRWParamsExportIgesData d ) { 
        d = new A3DRWParamsExportIgesData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsExportIgesData));
    }
    public static void Initialize(out A3DRWParamsExportStlData d ) { 
        d = new A3DRWParamsExportStlData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsExportStlData));
        d.m_eExportUnit = A3DEUnits.kA3DUnitMillimeter;
    }
    public static void Initialize(out A3DRWParamsExport3mfData d ) { 
        d = new A3DRWParamsExport3mfData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsExport3mfData));
        API.Initialize( out d.m_sTessellation );
        d.m_bKeepCurrentTessellation = true;
    }
    public static void Initialize(out A3DRWParamsExportXMLData d ) { 
        d = new A3DRWParamsExportXMLData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsExportXMLData));
        d.m_bExportMetadata = true;
        d.m_bExportTransformations = true;
        d.m_bExportColorMaterial = true;
        d.m_bExportProductInformationByFormat = false;
    }
    public static void Initialize(out A3DRWParamsExportObjData d ) { 
        d = new A3DRWParamsExportObjData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsExportObjData));
    }
    public static void Initialize(out A3DRWParamsExportFbxData d ) { 
        d = new A3DRWParamsExportFbxData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsExportFbxData));
    }
    public static void Initialize(out A3DSewOptionsData d ) { 
        d = new A3DSewOptionsData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DSewOptionsData));
    }
    public static void Initialize(out A3DFaceUVPointInsideManagerData d ) { 
        d = new A3DFaceUVPointInsideManagerData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DFaceUVPointInsideManagerData));
    }
    public static void Initialize(out A3DProjectedPointCloudData d ) { 
        d = new A3DProjectedPointCloudData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DProjectedPointCloudData));
        API.Initialize( out d.m_sPt );
        API.Initialize( out d.m_sUV );
    }
    public static void Initialize(out A3DProjectPointCloudManagerDataFromRI d ) { 
        d = new A3DProjectPointCloudManagerDataFromRI();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DProjectPointCloudManagerDataFromRI));
    }
    public static void Initialize(out A3DPlanarSectionData d ) { 
        d = new A3DPlanarSectionData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DPlanarSectionData));
        API.Initialize( out d.m_sDirection );
        API.Initialize( out d.m_sOrigin );
    }
    public static void Initialize(out A3DCompareInputData d ) { 
        d = new A3DCompareInputData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DCompareInputData));
    }
    public static void Initialize(out A3DCompareOutputData d ) { 
        d = new A3DCompareOutputData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DCompareOutputData));
    }
    public static void Initialize(out A3DMultiPlanarSectionData d ) { 
        d = new A3DMultiPlanarSectionData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMultiPlanarSectionData));
        API.Initialize( out d.m_sExtrudeDirection );
        API.Initialize( out d.m_sProfileNormal );
    }
    public static void Initialize(out A3DHLRViewPlaneData d ) { 
        d = new A3DHLRViewPlaneData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DHLRViewPlaneData));
    }
    public static void Initialize(out A3DHLRCurveData d ) { 
        d = new A3DHLRCurveData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DHLRCurveData));
    }
    public static void Initialize(out A3DHLRSectionFaceData d ) { 
        d = new A3DHLRSectionFaceData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DHLRSectionFaceData));
    }
    public static void Initialize(out A3DHLRRepresentationItemData d ) { 
        d = new A3DHLRRepresentationItemData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DHLRRepresentationItemData));
    }
    public static void Initialize(out A3DHLROptionsData d ) { 
        d = new A3DHLROptionsData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DHLROptionsData));
    }
    public static void Initialize(out A3DTransfoRepresentationItemData d ) { 
        d = new A3DTransfoRepresentationItemData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DTransfoRepresentationItemData));
    }
    public static void Initialize(out A3DCollisionGroupData d ) { 
        d = new A3DCollisionGroupData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DCollisionGroupData));
    }
    public static void Initialize(out A3DCollisionParameterData d ) { 
        d = new A3DCollisionParameterData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DCollisionParameterData));
    }
    public static void Initialize(out A3DCollisionResultData d ) { 
        d = new A3DCollisionResultData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DCollisionResultData));
    }
    public static void Initialize(out A3DMkpLeaderData d ) { 
        d = new A3DMkpLeaderData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMkpLeaderData));
    }
    public static void Initialize(out A3DMkpAnnotationItemData d ) { 
        d = new A3DMkpAnnotationItemData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMkpAnnotationItemData));
    }
    public static void Initialize(out A3DMkpAnnotationSetData d ) { 
        d = new A3DMkpAnnotationSetData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMkpAnnotationSetData));
    }
    public static void Initialize(out A3DMkpAnnotationReferenceData d ) { 
        d = new A3DMkpAnnotationReferenceData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMkpAnnotationReferenceData));
    }
    public static void Initialize(out A3DMkpViewData d ) { 
        d = new A3DMkpViewData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMkpViewData));
    }
    public static void Initialize(out A3DMkpViewFlagsData d ) { 
        d = new A3DMkpViewFlagsData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMkpViewFlagsData));
    }
    public static void Initialize(out A3DMiscMarkupLinkedItemData d ) { 
        d = new A3DMiscMarkupLinkedItemData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMiscMarkupLinkedItemData));
    }
    public static void Initialize(out A3DMkpMarkupData d ) { 
        d = new A3DMkpMarkupData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMkpMarkupData));
    }
    public static void Initialize(out A3DMkpRTFFieldData d ) { 
        d = new A3DMkpRTFFieldData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMkpRTFFieldData));
    }
    public static void Initialize(out A3DFontKeyData d ) { 
        d = new A3DFontKeyData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DFontKeyData));
    }
    public static void Initialize(out A3DFontData d ) { 
        d = new A3DFontData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DFontData));
    }
    public static void Initialize(out A3DGraphTextureTransformationData d ) { 
        d = new A3DGraphTextureTransformationData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DGraphTextureTransformationData));
    }
    public static void Initialize(out A3DGraphTextureDefinitionData d ) { 
        d = new A3DGraphTextureDefinitionData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DGraphTextureDefinitionData));
    }
    public static void Initialize(out A3DGraphTextureApplicationData d ) { 
        d = new A3DGraphTextureApplicationData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DGraphTextureApplicationData));
    }
    public static void Initialize(out A3DDrawCallbacksData d ) { 
        d = new A3DDrawCallbacksData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DDrawCallbacksData));
    }
    public static void Initialize(out A3DDrawingModelData d ) { 
        d = new A3DDrawingModelData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DDrawingModelData));
    }
    public static void Initialize(out A3DDrawingSheetFormatData d ) { 
        d = new A3DDrawingSheetFormatData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DDrawingSheetFormatData));
        API.Initialize( out d.m_sSize );
    }
    public static void Initialize(out A3DDrawingSheetData d ) { 
        d = new A3DDrawingSheetData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DDrawingSheetData));
        API.Initialize( out d.m_sRefPoint );
        API.Initialize( out d.m_sSize );
    }
    public static void Initialize(out A3DDrawingClipFrameData d ) { 
        d = new A3DDrawingClipFrameData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DDrawingClipFrameData));
        API.Initialize( out d.m_sRectangularBox );
    }
    public static void Initialize(out A3DDrawingViewData d ) { 
        d = new A3DDrawingViewData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DDrawingViewData));
        API.Initialize( out d.m_sOffsetLocation );
        API.Initialize( out d.m_sOriginOnSheet );
    }
    public static void Initialize(out A3DDrawingBlockBasicData d ) { 
        d = new A3DDrawingBlockBasicData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DDrawingBlockBasicData));
    }
    public static void Initialize(out A3DDrawingBlockOperatorData d ) { 
        d = new A3DDrawingBlockOperatorData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DDrawingBlockOperatorData));
    }
    public static void Initialize(out A3DDrawingCurveData d ) { 
        d = new A3DDrawingCurveData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DDrawingCurveData));
        API.Initialize( out d.m_sTrimInterval );
    }
    public static void Initialize(out A3DDrawingFilledAreaData d ) { 
        d = new A3DDrawingFilledAreaData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DDrawingFilledAreaData));
    }
    public static void Initialize(out A3DDrawingPictureData d ) { 
        d = new A3DDrawingPictureData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DDrawingPictureData));
        API.Initialize( out d.m_sPosition );
        API.Initialize( out d.m_sSize );
    }
    public static void Initialize(out A3DDrawingVerticesData d ) { 
        d = new A3DDrawingVerticesData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DDrawingVerticesData));
    }
    public static void Initialize(out A3DThumbnailData d ) { 
        d = new A3DThumbnailData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DThumbnailData));
    }
    public static void Initialize(out A3DFileInformationData d ) { 
        d = new A3DFileInformationData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DFileInformationData));
    }
    public static void Initialize(out A3DFileContextData d ) { 
        d = new A3DFileContextData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DFileContextData));
    }
    public static void Initialize(out A3DRWParamsExportParasolidData d ) { 
        d = new A3DRWParamsExportParasolidData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsExportParasolidData));
    }
    public static void Initialize(out A3DRWParamsTranslateToPkPartsData d ) { 
        d = new A3DRWParamsTranslateToPkPartsData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsTranslateToPkPartsData));
        d.m_eHealing = A3DETranslateToPkPartsHealing.kA3DE_HEALING_ONLY_IF_NOT_PARASOLID;
        d.m_eComputeAccurateEdges = A3DETranslateToPkPartsAccurate.kA3DE_ACCURATE_ONLY_IF_NOT_PARASOLID;
        d.m_bExportNormalsWithTessellation = true;
    }
    public static void Initialize(out A3DRWParamsExportAcisData d ) { 
        d = new A3DRWParamsExportAcisData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRWParamsExportAcisData));
    }
    public static void Initialize(out A3DRiRepresentationItemData d ) { 
        d = new A3DRiRepresentationItemData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRiRepresentationItemData));
    }
    public static void Initialize(out A3DRiSetData d ) { 
        d = new A3DRiSetData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRiSetData));
    }
    public static void Initialize(out A3DRiPointSetData d ) { 
        d = new A3DRiPointSetData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRiPointSetData));
    }
    public static void Initialize(out A3DRiDirectionData d ) { 
        d = new A3DRiDirectionData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRiDirectionData));
        API.Initialize( out d.m_sDirection );
        API.Initialize( out d.m_sOrigin );
    }
    public static void Initialize(out A3DRiCoordinateSystemData d ) { 
        d = new A3DRiCoordinateSystemData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRiCoordinateSystemData));
    }
    public static void Initialize(out A3DRiCurveData d ) { 
        d = new A3DRiCurveData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRiCurveData));
    }
    public static void Initialize(out A3DRiPlaneData d ) { 
        d = new A3DRiPlaneData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRiPlaneData));
    }
    public static void Initialize(out A3DRiBrepModelData d ) { 
        d = new A3DRiBrepModelData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRiBrepModelData));
    }
    public static void Initialize(out A3DRiPolyBrepModelData d ) { 
        d = new A3DRiPolyBrepModelData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRiPolyBrepModelData));
    }
    public static void Initialize(out A3DRiPolyWireData d ) { 
        d = new A3DRiPolyWireData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRiPolyWireData));
    }
    public static void Initialize(out A3DFRMFeatureTreeData d ) { 
        d = new A3DFRMFeatureTreeData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DFRMFeatureTreeData));
    }
    public static void Initialize(out A3DFRMParameterData d ) { 
        d = new A3DFRMParameterData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DFRMParameterData));
    }
    public static void Initialize(out A3DFRMFeatureTypeData d ) { 
        d = new A3DFRMFeatureTypeData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DFRMFeatureTypeData));
    }
    public static void Initialize(out A3DFRMStringData d ) { 
        d = new A3DFRMStringData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DFRMStringData));
    }
    public static void Initialize(out A3DFRMDoubleData d ) { 
        d = new A3DFRMDoubleData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DFRMDoubleData));
    }
    public static void Initialize(out A3DFRMIntegerData d ) { 
        d = new A3DFRMIntegerData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DFRMIntegerData));
    }
    public static void Initialize(out A3DFRMFeatureLinkedItemData d ) { 
        d = new A3DFRMFeatureLinkedItemData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DFRMFeatureLinkedItemData));
    }
    public static void Initialize(out A3DFRMFeatureData d ) { 
        d = new A3DFRMFeatureData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DFRMFeatureData));
        API.Initialize( out d.m_sType );
    }
    public static void Initialize(out A3DFRMFeatureGeomEntitiesData d ) { 
        d = new A3DFRMFeatureGeomEntitiesData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DFRMFeatureGeomEntitiesData));
    }
    public static void Initialize(out A3DCrvNurbsData d ) { 
        d = new A3DCrvNurbsData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DCrvNurbsData));
    }
    public static void Initialize(out A3DCrvLineData d ) { 
        d = new A3DCrvLineData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DCrvLineData));
        API.Initialize( out d.m_sParam );
        API.Initialize( out d.m_sTrsf );
    }
    public static void Initialize(out A3DCrvCircleData d ) { 
        d = new A3DCrvCircleData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DCrvCircleData));
        API.Initialize( out d.m_sParam );
        API.Initialize( out d.m_sTrsf );
    }
    public static void Initialize(out A3DCrvEllipseData d ) { 
        d = new A3DCrvEllipseData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DCrvEllipseData));
        API.Initialize( out d.m_sParam );
        API.Initialize( out d.m_sTrsf );
    }
    public static void Initialize(out A3DCrvParabolaData d ) { 
        d = new A3DCrvParabolaData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DCrvParabolaData));
        API.Initialize( out d.m_sParam );
        API.Initialize( out d.m_sTrsf );
    }
    public static void Initialize(out A3DCrvHyperbolaData d ) { 
        d = new A3DCrvHyperbolaData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DCrvHyperbolaData));
        API.Initialize( out d.m_sParam );
        API.Initialize( out d.m_sTrsf );
    }
    public static void Initialize(out A3DCrvPolyLineData d ) { 
        d = new A3DCrvPolyLineData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DCrvPolyLineData));
        API.Initialize( out d.m_sParam );
        API.Initialize( out d.m_sTrsf );
    }
    public static void Initialize(out A3DCrvCompositeData d ) { 
        d = new A3DCrvCompositeData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DCrvCompositeData));
        API.Initialize( out d.m_sParam );
        API.Initialize( out d.m_sTrsf );
    }
    public static void Initialize(out A3DCrvEquationData d ) { 
        d = new A3DCrvEquationData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DCrvEquationData));
        API.Initialize( out d.m_sMaxInterval );
        API.Initialize( out d.m_sParam );
        API.Initialize( out d.m_sTrsf );
    }
    public static void Initialize(out A3DCrvTransformData d ) { 
        d = new A3DCrvTransformData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DCrvTransformData));
        API.Initialize( out d.m_sParam );
        API.Initialize( out d.m_sTrsf );
    }
    public static void Initialize(out A3DCrvOnSurfData d ) { 
        d = new A3DCrvOnSurfData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DCrvOnSurfData));
        API.Initialize( out d.m_sParam );
        API.Initialize( out d.m_sTrsf );
    }
    public static void Initialize(out A3DCrvOffsetData d ) { 
        d = new A3DCrvOffsetData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DCrvOffsetData));
        API.Initialize( out d.m_sParam );
        API.Initialize( out d.m_sTrsf );
        API.Initialize( out d.m_sVector );
    }
    public static void Initialize(out A3DCrvHelixPitchCstData d ) { 
        d = new A3DCrvHelixPitchCstData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DCrvHelixPitchCstData));
        API.Initialize( out d.m_sDirection );
        API.Initialize( out d.m_sOrigin );
        API.Initialize( out d.m_sStartPoint );
    }
    public static void Initialize(out A3DCrvHelixPitchVarData d ) { 
        d = new A3DCrvHelixPitchVarData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DCrvHelixPitchVarData));
        API.Initialize( out d.m_sStartPoint );
        API.Initialize( out d.m_sUnitU );
        API.Initialize( out d.m_sUnitZ );
    }
    public static void Initialize(out A3DCrvHelixData d ) { 
        d = new A3DCrvHelixData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DCrvHelixData));
        API.Initialize( out d.m_sCstHelixData );
        API.Initialize( out d.m_sParam );
        API.Initialize( out d.m_sTrsf );
        API.Initialize( out d.m_sVarHelixData );
    }
    public static void Initialize(out A3DCrossingPointsCrvIntersectionData d ) { 
        d = new A3DCrossingPointsCrvIntersectionData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DCrossingPointsCrvIntersectionData));
        API.Initialize( out d.m_sPosition );
        API.Initialize( out d.m_sTangent );
        API.Initialize( out d.m_sUVPosition1 );
        API.Initialize( out d.m_sUVPosition2 );
    }
    public static void Initialize(out A3DCrvIntersectionData d ) { 
        d = new A3DCrvIntersectionData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DCrvIntersectionData));
        API.Initialize( out d.m_sEndLimitPoint );
        API.Initialize( out d.m_sParam );
        API.Initialize( out d.m_sStartLimitPoint );
        API.Initialize( out d.m_sTrsf );
    }
    public static void Initialize(out A3DCrvBlend02BoundaryData d ) { 
        d = new A3DCrvBlend02BoundaryData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DCrvBlend02BoundaryData));
        API.Initialize( out d.m_sEndLimitPoint );
        API.Initialize( out d.m_sParam );
        API.Initialize( out d.m_sStartLimitPoint );
        API.Initialize( out d.m_sTrsf );
    }
    public static void Initialize(out A3DSurfNurbsData d ) { 
        d = new A3DSurfNurbsData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DSurfNurbsData));
    }
    public static void Initialize(out A3DSurfSphereData d ) { 
        d = new A3DSurfSphereData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DSurfSphereData));
        API.Initialize( out d.m_sParam );
        API.Initialize( out d.m_sTrsf );
    }
    public static void Initialize(out A3DSurfCylinderData d ) { 
        d = new A3DSurfCylinderData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DSurfCylinderData));
        API.Initialize( out d.m_sParam );
        API.Initialize( out d.m_sTrsf );
    }
    public static void Initialize(out A3DSurfTorusData d ) { 
        d = new A3DSurfTorusData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DSurfTorusData));
        API.Initialize( out d.m_sParam );
        API.Initialize( out d.m_sTrsf );
    }
    public static void Initialize(out A3DSurfRevolutionData d ) { 
        d = new A3DSurfRevolutionData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DSurfRevolutionData));
        API.Initialize( out d.m_sDirection );
        API.Initialize( out d.m_sOrigin );
        API.Initialize( out d.m_sParam );
        API.Initialize( out d.m_sTrsf );
    }
    public static void Initialize(out A3DSurfExtrusionData d ) { 
        d = new A3DSurfExtrusionData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DSurfExtrusionData));
        API.Initialize( out d.m_sDirection );
        API.Initialize( out d.m_sParam );
        API.Initialize( out d.m_sTrsf );
    }
    public static void Initialize(out A3DSurfOffsetData d ) { 
        d = new A3DSurfOffsetData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DSurfOffsetData));
        API.Initialize( out d.m_sParam );
        API.Initialize( out d.m_sTrsf );
    }
    public static void Initialize(out A3DSurfPlaneData d ) { 
        d = new A3DSurfPlaneData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DSurfPlaneData));
        API.Initialize( out d.m_sParam );
        API.Initialize( out d.m_sTrsf );
    }
    public static void Initialize(out A3DSurfBlend01Data d ) { 
        d = new A3DSurfBlend01Data();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DSurfBlend01Data));
        API.Initialize( out d.m_sParam );
        API.Initialize( out d.m_sTrsf );
    }
    public static void Initialize(out A3DSurfBlend02Data d ) { 
        d = new A3DSurfBlend02Data();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DSurfBlend02Data));
        API.Initialize( out d.m_sParam );
        API.Initialize( out d.m_sTrsf );
    }
    public static void Initialize(out A3DSurfBlend03Data d ) { 
        d = new A3DSurfBlend03Data();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DSurfBlend03Data));
        API.Initialize( out d.m_sParam );
        API.Initialize( out d.m_sTrsf );
    }
    public static void Initialize(out A3DSurfConeData d ) { 
        d = new A3DSurfConeData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DSurfConeData));
        API.Initialize( out d.m_sParam );
        API.Initialize( out d.m_sTrsf );
    }
    public static void Initialize(out A3DSurfCylindricalData d ) { 
        d = new A3DSurfCylindricalData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DSurfCylindricalData));
        API.Initialize( out d.m_sParam );
        API.Initialize( out d.m_sTrsf );
    }
    public static void Initialize(out A3DSurfRuledData d ) { 
        d = new A3DSurfRuledData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DSurfRuledData));
        API.Initialize( out d.m_sParam );
        API.Initialize( out d.m_sTrsf );
    }
    public static void Initialize(out A3DSurfPipeData d ) { 
        d = new A3DSurfPipeData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DSurfPipeData));
        API.Initialize( out d.m_sParam );
        API.Initialize( out d.m_sTrsf );
    }
    public static void Initialize(out A3DSurfTransformData d ) { 
        d = new A3DSurfTransformData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DSurfTransformData));
        API.Initialize( out d.m_sParam );
        API.Initialize( out d.m_sTrsf );
    }
    public static void Initialize(out A3DSurfFromCurvesData d ) { 
        d = new A3DSurfFromCurvesData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DSurfFromCurvesData));
        API.Initialize( out d.m_sOrigin );
        API.Initialize( out d.m_sParam );
        API.Initialize( out d.m_sTrsf );
    }
    public static void Initialize(out A3DGlobalData d ) { 
        d = new A3DGlobalData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DGlobalData));
    }
    public static void Initialize(out A3DMDPosition3DData d ) { 
        d = new A3DMDPosition3DData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDPosition3DData));
        API.Initialize( out d.m_sPosition );
    }
    public static void Initialize(out A3DMDPosition2DData d ) { 
        d = new A3DMDPosition2DData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDPosition2DData));
        API.Initialize( out d.m_sPosition );
    }
    public static void Initialize(out A3DMDPositionReferenceData d ) { 
        d = new A3DMDPositionReferenceData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDPositionReferenceData));
        API.Initialize( out d.m_sOffsetToReference );
    }
    public static void Initialize(out A3DMDLeaderSymbolData d ) { 
        d = new A3DMDLeaderSymbolData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDLeaderSymbolData));
    }
    public static void Initialize(out A3DMDMarkupLeaderStubData d ) { 
        d = new A3DMDMarkupLeaderStubData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDMarkupLeaderStubData));
    }
    public static void Initialize(out A3DMDLeaderDefinitionData d ) { 
        d = new A3DMDLeaderDefinitionData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDLeaderDefinitionData));
    }
    public static void Initialize(out A3DMDTextPropertiesData d ) { 
        d = new A3DMDTextPropertiesData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDTextPropertiesData));
    }
    public static void Initialize(out A3DMarkupDefinitionData d ) { 
        d = new A3DMarkupDefinitionData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMarkupDefinitionData));
    }
    public static void Initialize(out A3DMDDimensionValueFormatData d ) { 
        d = new A3DMDDimensionValueFormatData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDDimensionValueFormatData));
    }
    public static void Initialize(out A3DMDDimensionSimpleToleranceFormatData d ) { 
        d = new A3DMDDimensionSimpleToleranceFormatData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDDimensionSimpleToleranceFormatData));
    }
    public static void Initialize(out A3DMDDimensionCombinedToleranceFormatData d ) { 
        d = new A3DMDDimensionCombinedToleranceFormatData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDDimensionCombinedToleranceFormatData));
    }
    public static void Initialize(out A3DMDDimensionValueData d ) { 
        d = new A3DMDDimensionValueData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDDimensionValueData));
    }
    public static void Initialize(out A3DMDDimensionSecondPartData d ) { 
        d = new A3DMDDimensionSecondPartData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDDimensionSecondPartData));
    }
    public static void Initialize(out A3DMDDimensionForeshortenedData d ) { 
        d = new A3DMDDimensionForeshortenedData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDDimensionForeshortenedData));
    }
    public static void Initialize(out A3DMDDimensionLineSymbolData d ) { 
        d = new A3DMDDimensionLineSymbolData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDDimensionLineSymbolData));
    }
    public static void Initialize(out A3DMDDimensionLineData d ) { 
        d = new A3DMDDimensionLineData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDDimensionLineData));
    }
    public static void Initialize(out A3DMDDimensionFunnelData d ) { 
        d = new A3DMDDimensionFunnelData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDDimensionFunnelData));
    }
    public static void Initialize(out A3DMDDimensionExtremityData d ) { 
        d = new A3DMDDimensionExtremityData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDDimensionExtremityData));
    }
    public static void Initialize(out A3DMDDimensionExtentionLineData d ) { 
        d = new A3DMDDimensionExtentionLineData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDDimensionExtentionLineData));
        API.Initialize( out d.m_sExtremity1 );
        API.Initialize( out d.m_sExtremity2 );
    }
    public static void Initialize(out A3DMarkupDimensionData d ) { 
        d = new A3DMarkupDimensionData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMarkupDimensionData));
        API.Initialize( out d.m_sOffSet );
    }
    public static void Initialize(out A3DMarkupRoughnessData d ) { 
        d = new A3DMarkupRoughnessData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMarkupRoughnessData));
    }
    public static void Initialize(out A3DMarkupBalloonData d ) { 
        d = new A3DMarkupBalloonData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMarkupBalloonData));
    }
    public static void Initialize(out A3DMarkupFastenerData d ) { 
        d = new A3DMarkupFastenerData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMarkupFastenerData));
        API.Initialize( out d.m_sAxisVector );
        API.Initialize( out d.m_sIndexVector );
        API.Initialize( out d.m_sOptionalVector );
    }
    public static void Initialize(out A3DMarkupLocatorData d ) { 
        d = new A3DMarkupLocatorData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMarkupLocatorData));
        API.Initialize( out d.m_sHotSpot );
        API.Initialize( out d.m_sNormalDirection );
        API.Initialize( out d.m_sPinDirection );
        API.Initialize( out d.m_sPunchDirection );
    }
    public static void Initialize(out A3DMarkupMeasurementPointData d ) { 
        d = new A3DMarkupMeasurementPointData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMarkupMeasurementPointData));
        API.Initialize( out d.m_sCoordinationVector );
        API.Initialize( out d.m_sLocation );
        API.Initialize( out d.m_sMeasurementVector );
        API.Initialize( out d.m_sNormalVector );
    }
    public static void Initialize(out A3DMDTextPositionData d ) { 
        d = new A3DMDTextPositionData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDTextPositionData));
        API.Initialize( out d.m_sBaseVector );
        API.Initialize( out d.m_sPosition );
        API.Initialize( out d.m_sUpVector );
    }
    public static void Initialize(out A3DMarkupTextData d ) { 
        d = new A3DMarkupTextData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMarkupTextData));
    }
    public static void Initialize(out A3DMarkupCoordinateData d ) { 
        d = new A3DMarkupCoordinateData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMarkupCoordinateData));
    }
    public static void Initialize(out A3DMarkupRichTextData d ) { 
        d = new A3DMarkupRichTextData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMarkupRichTextData));
    }
    public static void Initialize(out A3DMarkupDatumData d ) { 
        d = new A3DMarkupDatumData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMarkupDatumData));
    }
    public static void Initialize(out A3DMDFCFDraftingRowData d ) { 
        d = new A3DMDFCFDraftingRowData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDFCFDraftingRowData));
    }
    public static void Initialize(out A3DMDFCValueData d ) { 
        d = new A3DMDFCValueData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDFCValueData));
    }
    public static void Initialize(out A3DMDFCTolerancePerUnitData d ) { 
        d = new A3DMDFCTolerancePerUnitData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDFCTolerancePerUnitData));
    }
    public static void Initialize(out A3DMDFCProjectedZoneData d ) { 
        d = new A3DMDFCProjectedZoneData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDFCProjectedZoneData));
        API.Initialize( out d.m_sLength );
    }
    public static void Initialize(out A3DMDFCFToleranceValueData d ) { 
        d = new A3DMDFCFToleranceValueData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDFCFToleranceValueData));
        API.Initialize( out d.m_sValue );
    }
    public static void Initialize(out A3DMDFCFRowDatumData d ) { 
        d = new A3DMDFCFRowDatumData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDFCFRowDatumData));
    }
    public static void Initialize(out A3DMDFCFDrawingRowData d ) { 
        d = new A3DMDFCFDrawingRowData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDFCFDrawingRowData));
    }
    public static void Initialize(out A3DMDFCFIndicatorData d ) { 
        d = new A3DMDFCFIndicatorData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDFCFIndicatorData));
    }
    public static void Initialize(out A3DMDFeatureControlFrameData d ) { 
        d = new A3DMDFeatureControlFrameData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDFeatureControlFrameData));
    }
    public static void Initialize(out A3DMDToleranceSizeValueData d ) { 
        d = new A3DMDToleranceSizeValueData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDToleranceSizeValueData));
        API.Initialize( out d.m_sMainValue );
    }
    public static void Initialize(out A3DMDToleranceSizeData d ) { 
        d = new A3DMDToleranceSizeData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMDToleranceSizeData));
    }
    public static void Initialize(out A3DMarkupGDTData d ) { 
        d = new A3DMarkupGDTData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMarkupGDTData));
    }
    public static void Initialize(out A3DMarkupSpotWeldingData d ) { 
        d = new A3DMarkupSpotWeldingData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMarkupSpotWeldingData));
        API.Initialize( out d.m_sApproachVector );
        API.Initialize( out d.m_sClampingVector );
        API.Initialize( out d.m_sNormalVector );
    }
    public static void Initialize(out A3DMarkupLineWeldingData d ) { 
        d = new A3DMarkupLineWeldingData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMarkupLineWeldingData));
    }
    public static void Initialize(out A3DMathFct1DPolynomData d ) { 
        d = new A3DMathFct1DPolynomData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMathFct1DPolynomData));
    }
    public static void Initialize(out A3DMathFct1DTrigonometricData d ) { 
        d = new A3DMathFct1DTrigonometricData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMathFct1DTrigonometricData));
    }
    public static void Initialize(out A3DMathFct1DFractionData d ) { 
        d = new A3DMathFct1DFractionData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMathFct1DFractionData));
    }
    public static void Initialize(out A3DMathFct1DArctanCosData d ) { 
        d = new A3DMathFct1DArctanCosData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMathFct1DArctanCosData));
    }
    public static void Initialize(out A3DMathFct1DCombinationData d ) { 
        d = new A3DMathFct1DCombinationData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMathFct1DCombinationData));
    }
    public static void Initialize(out A3DMathFct3DLinearData d ) { 
        d = new A3DMathFct3DLinearData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMathFct3DLinearData));
    }
    public static void Initialize(out A3DMathFct3DNonLinearData d ) { 
        d = new A3DMathFct3DNonLinearData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMathFct3DNonLinearData));
    }
    public static void Initialize(out A3DRootBaseData d ) { 
        d = new A3DRootBaseData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRootBaseData));
    }
    public static void Initialize(out A3DRootBaseWithGraphicsData d ) { 
        d = new A3DRootBaseWithGraphicsData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DRootBaseWithGraphicsData));
    }
    public static void Initialize(out A3DMiscSingleAttributeData d ) { 
        d = new A3DMiscSingleAttributeData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMiscSingleAttributeData));
        d.m_usUnit = DEFAULT_NO_UNIT;
    }
    public static void Initialize(out A3DMiscAttributeData d ) { 
        d = new A3DMiscAttributeData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMiscAttributeData));
    }
    public static void Initialize(out A3DMiscAttributeBasicUnitData d ) { 
        d = new A3DMiscAttributeBasicUnitData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMiscAttributeBasicUnitData));
    }
    public static void Initialize(out A3DMiscAttributeUnitData d ) { 
        d = new A3DMiscAttributeUnitData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DMiscAttributeUnitData));
    }
    public static void Initialize(out A3DCopyAndAdaptBrepModelData d ) { 
        d = new A3DCopyAndAdaptBrepModelData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DCopyAndAdaptBrepModelData));
    }
    public static void Initialize(out A3DPhysicalPropertiesData d ) { 
        d = new A3DPhysicalPropertiesData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DPhysicalPropertiesData));
        API.Initialize( out d.m_sGravityCenter );
        API.Initialize( out d.m_sSurfacicGravityCenter );
        d.m_dAccuracyLevel = 0.99;
        d.m_bIncludeHiddenRIs = false;
    }
    public static void Initialize(out A3DTopoBodyData d ) { 
        d = new A3DTopoBodyData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DTopoBodyData));
    }
    public static void Initialize(out A3DTopoContextData d ) { 
        d = new A3DTopoContextData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DTopoContextData));
    }
    public static void Initialize(out A3DTopoSingleWireBodyData d ) { 
        d = new A3DTopoSingleWireBodyData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DTopoSingleWireBodyData));
    }
    public static void Initialize(out A3DTopoBrepDataData d ) { 
        d = new A3DTopoBrepDataData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DTopoBrepDataData));
        API.Initialize( out d.m_sBoundingBox );
    }
    public static void Initialize(out A3DTopoConnexData d ) { 
        d = new A3DTopoConnexData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DTopoConnexData));
    }
    public static void Initialize(out A3DTopoShellData d ) { 
        d = new A3DTopoShellData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DTopoShellData));
    }
    public static void Initialize(out A3DTopoFaceData d ) { 
        d = new A3DTopoFaceData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DTopoFaceData));
        API.Initialize( out d.m_sSurfaceDomain );
    }
    public static void Initialize(out A3DTopoLoopData d ) { 
        d = new A3DTopoLoopData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DTopoLoopData));
    }
    public static void Initialize(out A3DTopoCoEdgeData d ) { 
        d = new A3DTopoCoEdgeData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DTopoCoEdgeData));
    }
    public static void Initialize(out A3DTopoEdgeData d ) { 
        d = new A3DTopoEdgeData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DTopoEdgeData));
        API.Initialize( out d.m_sInterval );
    }
    public static void Initialize(out A3DTopoWireEdgeData d ) { 
        d = new A3DTopoWireEdgeData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DTopoWireEdgeData));
        API.Initialize( out d.m_sInterval );
    }
    public static void Initialize(out A3DTopoUniqueVertexData d ) { 
        d = new A3DTopoUniqueVertexData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DTopoUniqueVertexData));
        API.Initialize( out d.m_sPoint );
    }
    public static void Initialize(out A3DTopoMultipleVertexData d ) { 
        d = new A3DTopoMultipleVertexData();
        d.m_usStructSize = (UInt16)Marshal.SizeOf(typeof(A3DTopoMultipleVertexData));
    }
        public delegate A3DStatus PFA3DTessBaseGet(IntPtr pTessBase, ref A3DTessBaseData pData);
        public static PFA3DTessBaseGet A3DTessBaseGet = Marshal.GetDelegateForFunctionPointer<PFA3DTessBaseGet>(Library.A3DGetProcAddress("A3DTessBaseGet", 1));
        public delegate A3DStatus PFA3DTessBaseSet(IntPtr pTessBase, ref A3DTessBaseData pData);
        public static PFA3DTessBaseSet A3DTessBaseSet = Marshal.GetDelegateForFunctionPointer<PFA3DTessBaseSet>(Library.A3DGetProcAddress("A3DTessBaseSet", 1));
        public delegate A3DStatus PFA3DTessBaseSetNoHash(IntPtr pTessBase, ref A3DTessBaseData pData);
        public static PFA3DTessBaseSetNoHash A3DTessBaseSetNoHash = Marshal.GetDelegateForFunctionPointer<PFA3DTessBaseSetNoHash>(Library.A3DGetProcAddress("A3DTessBaseSetNoHash", 1));
        public delegate A3DStatus PFA3DTess3DGet(IntPtr pTess, ref A3DTess3DData pData);
        public static PFA3DTess3DGet A3DTess3DGet = Marshal.GetDelegateForFunctionPointer<PFA3DTess3DGet>(Library.A3DGetProcAddress("A3DTess3DGet", 1));
        public delegate A3DStatus PFA3DTess3DCreate(ref A3DTess3DData pData, out IntPtr ppTess);
        public static PFA3DTess3DCreate A3DTess3DCreate = Marshal.GetDelegateForFunctionPointer<PFA3DTess3DCreate>(Library.A3DGetProcAddress("A3DTess3DCreate", 1));
        public delegate A3DStatus PFA3DTess3DWireGet(IntPtr pTess, ref A3DTess3DWireData pData);
        public static PFA3DTess3DWireGet A3DTess3DWireGet = Marshal.GetDelegateForFunctionPointer<PFA3DTess3DWireGet>(Library.A3DGetProcAddress("A3DTess3DWireGet", 1));
        public delegate A3DStatus PFA3DTess3DWireCreate(ref A3DTess3DWireData pData, out IntPtr ppTess);
        public static PFA3DTess3DWireCreate A3DTess3DWireCreate = Marshal.GetDelegateForFunctionPointer<PFA3DTess3DWireCreate>(Library.A3DGetProcAddress("A3DTess3DWireCreate", 1));
        public delegate A3DStatus PFA3DTessMarkupGet(IntPtr pTess, ref A3DTessMarkupData pData);
        public static PFA3DTessMarkupGet A3DTessMarkupGet = Marshal.GetDelegateForFunctionPointer<PFA3DTessMarkupGet>(Library.A3DGetProcAddress("A3DTessMarkupGet", 1));
        public delegate A3DStatus PFA3DTessMarkupCreate(ref A3DTessMarkupData pData, out IntPtr ppTess);
        public static PFA3DTessMarkupCreate A3DTessMarkupCreate = Marshal.GetDelegateForFunctionPointer<PFA3DTessMarkupCreate>(Library.A3DGetProcAddress("A3DTessMarkupCreate", 1));
        public delegate A3DStatus PFA3DGraphicsGet(IntPtr pGraphics, ref A3DGraphicsData pData);
        public static PFA3DGraphicsGet A3DGraphicsGet = Marshal.GetDelegateForFunctionPointer<PFA3DGraphicsGet>(Library.A3DGetProcAddress("A3DGraphicsGet", 1));
        public delegate A3DStatus PFA3DGraphicsCreate(ref A3DGraphicsData pData, out IntPtr ppGraphics);
        public static PFA3DGraphicsCreate A3DGraphicsCreate = Marshal.GetDelegateForFunctionPointer<PFA3DGraphicsCreate>(Library.A3DGetProcAddress("A3DGraphicsCreate", 1));
        public delegate A3DStatus PFA3DGraphicsDelete(IntPtr pGraphics);
        public static PFA3DGraphicsDelete A3DGraphicsDelete = Marshal.GetDelegateForFunctionPointer<PFA3DGraphicsDelete>(Library.A3DGetProcAddress("A3DGraphicsDelete", 1));
        public delegate A3DStatus PFA3DGlobalGetGraphStyleData(uint uiIndexStyle, ref A3DGraphStyleData pData);
        public static PFA3DGlobalGetGraphStyleData A3DGlobalGetGraphStyleData = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalGetGraphStyleData>(Library.A3DGetProcAddress("A3DGlobalGetGraphStyleData", 1));
        public delegate A3DStatus PFA3DGlobalInsertGraphStyle(ref A3DGraphStyleData pData, out uint puiIndexStyle);
        public static PFA3DGlobalInsertGraphStyle A3DGlobalInsertGraphStyle = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalInsertGraphStyle>(Library.A3DGetProcAddress("A3DGlobalInsertGraphStyle", 1));
        public delegate A3DStatus PFA3DGlobalGetGraphRgbColorData(uint uiIndexRgbColor, ref A3DGraphRgbColorData pData);
        public static PFA3DGlobalGetGraphRgbColorData A3DGlobalGetGraphRgbColorData = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalGetGraphRgbColorData>(Library.A3DGetProcAddress("A3DGlobalGetGraphRgbColorData", 1));
        public delegate A3DStatus PFA3DGlobalInsertGraphRgbColor(ref A3DGraphRgbColorData pData, out uint puiIndexRgbColor);
        public static PFA3DGlobalInsertGraphRgbColor A3DGlobalInsertGraphRgbColor = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalInsertGraphRgbColor>(Library.A3DGetProcAddress("A3DGlobalInsertGraphRgbColor", 1));
        public delegate A3DStatus PFA3DGlobalGetGraphLinePatternData(uint uiIndexLinePattern, ref A3DGraphLinePatternData pData);
        public static PFA3DGlobalGetGraphLinePatternData A3DGlobalGetGraphLinePatternData = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalGetGraphLinePatternData>(Library.A3DGetProcAddress("A3DGlobalGetGraphLinePatternData", 1));
        public delegate A3DStatus PFA3DGlobalInsertGraphLinePattern(ref A3DGraphLinePatternData pData, out uint puiIndexLinePattern);
        public static PFA3DGlobalInsertGraphLinePattern A3DGlobalInsertGraphLinePattern = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalInsertGraphLinePattern>(Library.A3DGetProcAddress("A3DGlobalInsertGraphLinePattern", 1));
        public delegate A3DStatus PFA3DGlobalGetGraphMaterialData(uint uiIndexMaterial, ref A3DGraphMaterialData pData);
        public static PFA3DGlobalGetGraphMaterialData A3DGlobalGetGraphMaterialData = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalGetGraphMaterialData>(Library.A3DGetProcAddress("A3DGlobalGetGraphMaterialData", 1));
        public delegate A3DStatus PFA3DGlobalInsertGraphMaterial(ref A3DGraphMaterialData pData, out uint puiIndexMaterial);
        public static PFA3DGlobalInsertGraphMaterial A3DGlobalInsertGraphMaterial = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalInsertGraphMaterial>(Library.A3DGetProcAddress("A3DGlobalInsertGraphMaterial", 1));
        public delegate A3DStatus PFA3DGlobalGetGraphPictureData(uint uiIndexPicture, ref A3DGraphPictureData pData);
        public static PFA3DGlobalGetGraphPictureData A3DGlobalGetGraphPictureData = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalGetGraphPictureData>(Library.A3DGetProcAddress("A3DGlobalGetGraphPictureData", 1));
        public delegate A3DStatus PFA3DGlobalInsertGraphPicture(ref A3DGraphPictureData pData, out uint puiPictureIndex);
        public static PFA3DGlobalInsertGraphPicture A3DGlobalInsertGraphPicture = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalInsertGraphPicture>(Library.A3DGetProcAddress("A3DGlobalInsertGraphPicture", 1));
        public delegate A3DStatus PFA3DGlobalGetGraphDottingPatternData(uint uiIndexDottingPattern, ref A3DGraphDottingPatternData pData);
        public static PFA3DGlobalGetGraphDottingPatternData A3DGlobalGetGraphDottingPatternData = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalGetGraphDottingPatternData>(Library.A3DGetProcAddress("A3DGlobalGetGraphDottingPatternData", 1));
        public delegate A3DStatus PFA3DGlobalInsertGraphDottingPattern(ref A3DGraphDottingPatternData pData, out uint puiIndexDottingPattern);
        public static PFA3DGlobalInsertGraphDottingPattern A3DGlobalInsertGraphDottingPattern = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalInsertGraphDottingPattern>(Library.A3DGetProcAddress("A3DGlobalInsertGraphDottingPattern", 1));
        public delegate A3DStatus PFA3DGlobalGetGraphHatchingPatternData(uint uiIndexHatchingPattern, ref A3DGraphHatchingPatternData pData);
        public static PFA3DGlobalGetGraphHatchingPatternData A3DGlobalGetGraphHatchingPatternData = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalGetGraphHatchingPatternData>(Library.A3DGetProcAddress("A3DGlobalGetGraphHatchingPatternData", 1));
        public delegate A3DStatus PFA3DGlobalInsertGraphHatchingPattern(ref A3DGraphHatchingPatternData pData, out uint puiIndexHatchingPattern);
        public static PFA3DGlobalInsertGraphHatchingPattern A3DGlobalInsertGraphHatchingPattern = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalInsertGraphHatchingPattern>(Library.A3DGetProcAddress("A3DGlobalInsertGraphHatchingPattern", 1));
        public delegate A3DStatus PFA3DGlobalGetGraphSolidPatternData(uint uiIndexSolidPattern, ref A3DGraphSolidPatternData pData);
        public static PFA3DGlobalGetGraphSolidPatternData A3DGlobalGetGraphSolidPatternData = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalGetGraphSolidPatternData>(Library.A3DGetProcAddress("A3DGlobalGetGraphSolidPatternData", 1));
        public delegate A3DStatus PFA3DGlobalInsertGraphSolidPattern(ref A3DGraphSolidPatternData pData, out uint puiIndexSolidPattern);
        public static PFA3DGlobalInsertGraphSolidPattern A3DGlobalInsertGraphSolidPattern = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalInsertGraphSolidPattern>(Library.A3DGetProcAddress("A3DGlobalInsertGraphSolidPattern", 1));
        public delegate A3DStatus PFA3DGlobalGetGraphVPicturePatternData(uint uiIndexVPicturePattern, ref A3DGraphVPicturePatternData pData);
        public static PFA3DGlobalGetGraphVPicturePatternData A3DGlobalGetGraphVPicturePatternData = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalGetGraphVPicturePatternData>(Library.A3DGetProcAddress("A3DGlobalGetGraphVPicturePatternData", 1));
        public delegate A3DStatus PFA3DGlobalInsertGraphVPicturePattern(ref A3DGraphVPicturePatternData pData, out uint puiIndexVPicturePattern);
        public static PFA3DGlobalInsertGraphVPicturePattern A3DGlobalInsertGraphVPicturePattern = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalInsertGraphVPicturePattern>(Library.A3DGetProcAddress("A3DGlobalInsertGraphVPicturePattern", 1));
        public delegate A3DStatus PFA3DGraphCameraGet(IntPtr pCamera, ref A3DGraphCameraData pData);
        public static PFA3DGraphCameraGet A3DGraphCameraGet = Marshal.GetDelegateForFunctionPointer<PFA3DGraphCameraGet>(Library.A3DGetProcAddress("A3DGraphCameraGet", 1));
        public delegate A3DStatus PFA3DGraphCameraCreate(ref A3DGraphCameraData pData, out IntPtr ppCamera);
        public static PFA3DGraphCameraCreate A3DGraphCameraCreate = Marshal.GetDelegateForFunctionPointer<PFA3DGraphCameraCreate>(Library.A3DGetProcAddress("A3DGraphCameraCreate", 1));
        public delegate A3DStatus PFA3DGraphAmbientLightGet(IntPtr pLight, ref A3DGraphAmbientLightData pData);
        public static PFA3DGraphAmbientLightGet A3DGraphAmbientLightGet = Marshal.GetDelegateForFunctionPointer<PFA3DGraphAmbientLightGet>(Library.A3DGetProcAddress("A3DGraphAmbientLightGet", 1));
        public delegate A3DStatus PFA3DGraphAmbientLightCreate(ref A3DGraphAmbientLightData pData, out IntPtr ppLight);
        public static PFA3DGraphAmbientLightCreate A3DGraphAmbientLightCreate = Marshal.GetDelegateForFunctionPointer<PFA3DGraphAmbientLightCreate>(Library.A3DGetProcAddress("A3DGraphAmbientLightCreate", 1));
        public delegate A3DStatus PFA3DGraphPointLightGet(IntPtr pLight, ref A3DGraphPointLightData pData);
        public static PFA3DGraphPointLightGet A3DGraphPointLightGet = Marshal.GetDelegateForFunctionPointer<PFA3DGraphPointLightGet>(Library.A3DGetProcAddress("A3DGraphPointLightGet", 1));
        public delegate A3DStatus PFA3DGraphPointLightCreate(ref A3DGraphPointLightData pData, out IntPtr ppLight);
        public static PFA3DGraphPointLightCreate A3DGraphPointLightCreate = Marshal.GetDelegateForFunctionPointer<PFA3DGraphPointLightCreate>(Library.A3DGetProcAddress("A3DGraphPointLightCreate", 1));
        public delegate A3DStatus PFA3DGraphSpotLightGet(IntPtr pLight, ref A3DGraphSpotLightData pData);
        public static PFA3DGraphSpotLightGet A3DGraphSpotLightGet = Marshal.GetDelegateForFunctionPointer<PFA3DGraphSpotLightGet>(Library.A3DGetProcAddress("A3DGraphSpotLightGet", 1));
        public delegate A3DStatus PFA3DGraphSpotLightCreate(ref A3DGraphSpotLightData pData, out IntPtr ppLight);
        public static PFA3DGraphSpotLightCreate A3DGraphSpotLightCreate = Marshal.GetDelegateForFunctionPointer<PFA3DGraphSpotLightCreate>(Library.A3DGetProcAddress("A3DGraphSpotLightCreate", 1));
        public delegate A3DStatus PFA3DGraphDirectionalLightGet(IntPtr pLight, ref A3DGraphDirectionalLightData pData);
        public static PFA3DGraphDirectionalLightGet A3DGraphDirectionalLightGet = Marshal.GetDelegateForFunctionPointer<PFA3DGraphDirectionalLightGet>(Library.A3DGetProcAddress("A3DGraphDirectionalLightGet", 1));
        public delegate A3DStatus PFA3DGraphDirectionalLightCreate(ref A3DGraphDirectionalLightData pData, out IntPtr ppLight);
        public static PFA3DGraphDirectionalLightCreate A3DGraphDirectionalLightCreate = Marshal.GetDelegateForFunctionPointer<PFA3DGraphDirectionalLightCreate>(Library.A3DGetProcAddress("A3DGraphDirectionalLightCreate", 1));
        public delegate A3DStatus PFA3DGraphSceneDisplayParametersGet(IntPtr pSceneDisplayParameters, ref A3DGraphSceneDisplayParametersData pData);
        public static PFA3DGraphSceneDisplayParametersGet A3DGraphSceneDisplayParametersGet = Marshal.GetDelegateForFunctionPointer<PFA3DGraphSceneDisplayParametersGet>(Library.A3DGetProcAddress("A3DGraphSceneDisplayParametersGet", 1));
        public delegate A3DStatus PFA3DGraphSceneDisplayParametersCreate(ref A3DGraphSceneDisplayParametersData pData, out IntPtr ppSceneDisplayParameters);
        public static PFA3DGraphSceneDisplayParametersCreate A3DGraphSceneDisplayParametersCreate = Marshal.GetDelegateForFunctionPointer<PFA3DGraphSceneDisplayParametersCreate>(Library.A3DGetProcAddress("A3DGraphSceneDisplayParametersCreate", 1));
        public delegate A3DStatus PFA3DMiscCascadedAttributesCreate(out IntPtr ppAttr);
        public static PFA3DMiscCascadedAttributesCreate A3DMiscCascadedAttributesCreate = Marshal.GetDelegateForFunctionPointer<PFA3DMiscCascadedAttributesCreate>(Library.A3DGetProcAddress("A3DMiscCascadedAttributesCreate", 1));
        public delegate A3DStatus PFA3DMiscCascadedAttributesDelete(IntPtr pAttr);
        public static PFA3DMiscCascadedAttributesDelete A3DMiscCascadedAttributesDelete = Marshal.GetDelegateForFunctionPointer<PFA3DMiscCascadedAttributesDelete>(Library.A3DGetProcAddress("A3DMiscCascadedAttributesDelete", 1));
        public delegate A3DStatus PFA3DMiscCascadedAttributesGet(IntPtr pAttr, ref A3DMiscCascadedAttributesData psData);
        public static PFA3DMiscCascadedAttributesGet A3DMiscCascadedAttributesGet = Marshal.GetDelegateForFunctionPointer<PFA3DMiscCascadedAttributesGet>(Library.A3DGetProcAddress("A3DMiscCascadedAttributesGet", 1));
        public delegate A3DStatus PFA3DMiscCascadedAttributesPush(IntPtr pAttr, IntPtr pBase, IntPtr pFather);
        public static PFA3DMiscCascadedAttributesPush A3DMiscCascadedAttributesPush = Marshal.GetDelegateForFunctionPointer<PFA3DMiscCascadedAttributesPush>(Library.A3DGetProcAddress("A3DMiscCascadedAttributesPush", 1));
        public delegate A3DStatus PFA3DMiscCascadedAttributesPushTessFace(IntPtr pAttr, IntPtr pRepItem, IntPtr pTessBase, ref A3DTessFaceData psTessFaceData, uint uiFaceIndex, IntPtr pFather);
        public static PFA3DMiscCascadedAttributesPushTessFace A3DMiscCascadedAttributesPushTessFace = Marshal.GetDelegateForFunctionPointer<PFA3DMiscCascadedAttributesPushTessFace>(Library.A3DGetProcAddress("A3DMiscCascadedAttributesPushTessFace", 1));
        public delegate A3DStatus PFA3DMiscCascadedAttributesEntityReferencePush(IntPtr pAttr, IntPtr pOccurrence, out IntPtr ppPtr);
        public static PFA3DMiscCascadedAttributesEntityReferencePush A3DMiscCascadedAttributesEntityReferencePush = Marshal.GetDelegateForFunctionPointer<PFA3DMiscCascadedAttributesEntityReferencePush>(Library.A3DGetProcAddress("A3DMiscCascadedAttributesEntityReferencePush", 1));
        public delegate A3DStatus PFA3DMiscPointerFromIndexGet(uint uiIndex, A3DEEntityType eType, out IntPtr ppEntity);
        public static PFA3DMiscPointerFromIndexGet A3DMiscPointerFromIndexGet = Marshal.GetDelegateForFunctionPointer<PFA3DMiscPointerFromIndexGet>(Library.A3DGetProcAddress("A3DMiscPointerFromIndexGet", 1));
        public delegate A3DStatus PFA3DMiscRootBaseInsertAttribute(IntPtr pRootBase, IntPtr pAttribute);
        public static PFA3DMiscRootBaseInsertAttribute A3DMiscRootBaseInsertAttribute = Marshal.GetDelegateForFunctionPointer<PFA3DMiscRootBaseInsertAttribute>(Library.A3DGetProcAddress("A3DMiscRootBaseInsertAttribute", 1));
        public delegate A3DStatus PFA3DMiscGeneralTransformationGet(IntPtr pGeneralTransformation3d, ref A3DMiscGeneralTransformationData pData);
        public static PFA3DMiscGeneralTransformationGet A3DMiscGeneralTransformationGet = Marshal.GetDelegateForFunctionPointer<PFA3DMiscGeneralTransformationGet>(Library.A3DGetProcAddress("A3DMiscGeneralTransformationGet", 1));
        public delegate A3DStatus PFA3DMiscGeneralTransformationCreate(ref A3DMiscGeneralTransformationData pData, out IntPtr ppGeneralTransformation3d);
        public static PFA3DMiscGeneralTransformationCreate A3DMiscGeneralTransformationCreate = Marshal.GetDelegateForFunctionPointer<PFA3DMiscGeneralTransformationCreate>(Library.A3DGetProcAddress("A3DMiscGeneralTransformationCreate", 1));
        public delegate A3DStatus PFA3DMiscCartesianTransformationGet(IntPtr pCartesianTransformation3d, ref A3DMiscCartesianTransformationData pData);
        public static PFA3DMiscCartesianTransformationGet A3DMiscCartesianTransformationGet = Marshal.GetDelegateForFunctionPointer<PFA3DMiscCartesianTransformationGet>(Library.A3DGetProcAddress("A3DMiscCartesianTransformationGet", 1));
        public delegate A3DStatus PFA3DMiscCartesianTransformationCreate(ref A3DMiscCartesianTransformationData pData, out IntPtr ppCartesianTransformation3d);
        public static PFA3DMiscCartesianTransformationCreate A3DMiscCartesianTransformationCreate = Marshal.GetDelegateForFunctionPointer<PFA3DMiscCartesianTransformationCreate>(Library.A3DGetProcAddress("A3DMiscCartesianTransformationCreate", 1));
        public delegate A3DStatus PFA3DMiscEntityReferenceGet(IntPtr pEntityReference, ref A3DMiscEntityReferenceData pData);
        public static PFA3DMiscEntityReferenceGet A3DMiscEntityReferenceGet = Marshal.GetDelegateForFunctionPointer<PFA3DMiscEntityReferenceGet>(Library.A3DGetProcAddress("A3DMiscEntityReferenceGet", 1));
        public delegate A3DStatus PFA3DMiscEntityReferenceCreate(ref A3DMiscEntityReferenceData pData, out IntPtr ppEntityReference);
        public static PFA3DMiscEntityReferenceCreate A3DMiscEntityReferenceCreate = Marshal.GetDelegateForFunctionPointer<PFA3DMiscEntityReferenceCreate>(Library.A3DGetProcAddress("A3DMiscEntityReferenceCreate", 1));
        public delegate A3DStatus PFA3DMiscEntityReferenceSet(IntPtr pEntityReference, ref A3DMiscEntityReferenceData pData);
        public static PFA3DMiscEntityReferenceSet A3DMiscEntityReferenceSet = Marshal.GetDelegateForFunctionPointer<PFA3DMiscEntityReferenceSet>(Library.A3DGetProcAddress("A3DMiscEntityReferenceSet", 1));
        public delegate A3DStatus PFA3DMiscReferenceOnTopologyGet(IntPtr pReferenceOnTopoItem, ref A3DMiscReferenceOnTopologyData pData);
        public static PFA3DMiscReferenceOnTopologyGet A3DMiscReferenceOnTopologyGet = Marshal.GetDelegateForFunctionPointer<PFA3DMiscReferenceOnTopologyGet>(Library.A3DGetProcAddress("A3DMiscReferenceOnTopologyGet", 1));
        public delegate A3DStatus PFA3DMiscReferenceOnTessGet(IntPtr pReferenceOnTess, ref A3DMiscReferenceOnTessData pData);
        public static PFA3DMiscReferenceOnTessGet A3DMiscReferenceOnTessGet = Marshal.GetDelegateForFunctionPointer<PFA3DMiscReferenceOnTessGet>(Library.A3DGetProcAddress("A3DMiscReferenceOnTessGet", 1));
        public delegate A3DStatus PFA3DMiscReferenceOnTessCreate(ref A3DMiscReferenceOnTessData pData, out IntPtr ppReferenceOnTess);
        public static PFA3DMiscReferenceOnTessCreate A3DMiscReferenceOnTessCreate = Marshal.GetDelegateForFunctionPointer<PFA3DMiscReferenceOnTessCreate>(Library.A3DGetProcAddress("A3DMiscReferenceOnTessCreate", 1));
        public delegate A3DStatus PFA3DMiscReferenceOnTopologyCreate(ref A3DMiscReferenceOnTopologyData pData, out IntPtr ppReferenceOnTopoItem);
        public static PFA3DMiscReferenceOnTopologyCreate A3DMiscReferenceOnTopologyCreate = Marshal.GetDelegateForFunctionPointer<PFA3DMiscReferenceOnTopologyCreate>(Library.A3DGetProcAddress("A3DMiscReferenceOnTopologyCreate", 1));
        public delegate A3DStatus PFA3DMiscReferenceOnCsysItemGet(IntPtr pReferenceOnCSYSItem, ref A3DMiscReferenceOnCsysItemData pData);
        public static PFA3DMiscReferenceOnCsysItemGet A3DMiscReferenceOnCsysItemGet = Marshal.GetDelegateForFunctionPointer<PFA3DMiscReferenceOnCsysItemGet>(Library.A3DGetProcAddress("A3DMiscReferenceOnCsysItemGet", 1));
        public delegate A3DStatus PFA3DMiscReferenceOnCsysItemCreate(ref A3DMiscReferenceOnCsysItemData pData, out IntPtr ppReferenceOnCSYSItem);
        public static PFA3DMiscReferenceOnCsysItemCreate A3DMiscReferenceOnCsysItemCreate = Marshal.GetDelegateForFunctionPointer<PFA3DMiscReferenceOnCsysItemCreate>(Library.A3DGetProcAddress("A3DMiscReferenceOnCsysItemCreate", 1));
        public delegate A3DStatus PFA3DMiscUTF8ToUnicode([MarshalAs(UnmanagedType.LPStr)] string pcInputBuffer, IntPtr acOutputBuffer);
        public static PFA3DMiscUTF8ToUnicode A3DMiscUTF8ToUnicode = Marshal.GetDelegateForFunctionPointer<PFA3DMiscUTF8ToUnicode>(Library.A3DGetProcAddress("A3DMiscUTF8ToUnicode", 1));
        public delegate A3DStatus PFA3DMiscUnicodeToUTF8([MarshalAs(UnmanagedType.LPStr)] string pcInputBuffer, IntPtr acOutputBuffer);
        public static PFA3DMiscUnicodeToUTF8 A3DMiscUnicodeToUTF8 = Marshal.GetDelegateForFunctionPointer<PFA3DMiscUnicodeToUTF8>(Library.A3DGetProcAddress("A3DMiscUnicodeToUTF8", 1));
        public delegate A3DStatus PFA3DMiscUTF8ToUTF16([MarshalAs(UnmanagedType.LPStr)] string pcInputBuffer, IntPtr acOutputBuffer);
        public static PFA3DMiscUTF8ToUTF16 A3DMiscUTF8ToUTF16 = Marshal.GetDelegateForFunctionPointer<PFA3DMiscUTF8ToUTF16>(Library.A3DGetProcAddress("A3DMiscUTF8ToUTF16", 1));
        public delegate A3DStatus PFA3DMiscUTF16ToUTF8([MarshalAs(UnmanagedType.LPStr)] string pcInputBuffer, IntPtr acOutputBuffer);
        public static PFA3DMiscUTF16ToUTF8 A3DMiscUTF16ToUTF8 = Marshal.GetDelegateForFunctionPointer<PFA3DMiscUTF16ToUTF8>(Library.A3DGetProcAddress("A3DMiscUTF16ToUTF8", 1));
        public delegate IntPtr PFA3DMiscGetErrorMsg(A3DStatus arg1);
        public static PFA3DMiscGetErrorMsg A3DMiscGetErrorMsg = Marshal.GetDelegateForFunctionPointer<PFA3DMiscGetErrorMsg>(Library.A3DGetProcAddress("A3DMiscGetErrorMsg", 1));
        public delegate IntPtr PFA3DMiscGetEntityTypeMsg(A3DEEntityType eType);
        public static PFA3DMiscGetEntityTypeMsg A3DMiscGetEntityTypeMsg = Marshal.GetDelegateForFunctionPointer<PFA3DMiscGetEntityTypeMsg>(Library.A3DGetProcAddress("A3DMiscGetEntityTypeMsg", 1));
        public delegate A3DStatus PFA3DMiscGetMaterialProperties(IntPtr pEntity, ref A3DMiscMaterialPropertiesData pMaterialPropertiesData);
        public static PFA3DMiscGetMaterialProperties A3DMiscGetMaterialProperties = Marshal.GetDelegateForFunctionPointer<PFA3DMiscGetMaterialProperties>(Library.A3DGetProcAddress("A3DMiscGetMaterialProperties", 1));
        public delegate A3DStatus PFA3DMiscGetBoundingBox(IntPtr pEntity, ref A3DBoundingBoxData pAABB);
        public static PFA3DMiscGetBoundingBox A3DMiscGetBoundingBox = Marshal.GetDelegateForFunctionPointer<PFA3DMiscGetBoundingBox>(Library.A3DGetProcAddress("A3DMiscGetBoundingBox", 1));
        public delegate A3DStatus PFA3DMiscComputeBoundingBox(IntPtr pEntity, out double pOptPlacement, ref A3DBoundingBoxData pAABB);
        public static PFA3DMiscComputeBoundingBox A3DMiscComputeBoundingBox = Marshal.GetDelegateForFunctionPointer<PFA3DMiscComputeBoundingBox>(Library.A3DGetProcAddress("A3DMiscComputeBoundingBox", 1));
        public delegate A3DStatus PFA3DAsmModelFileGet(IntPtr pModelFile, ref A3DAsmModelFileData pData);
        public static PFA3DAsmModelFileGet A3DAsmModelFileGet = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileGet>(Library.A3DGetProcAddress("A3DAsmModelFileGet", 1));
        public delegate A3DStatus PFA3DAsmModelFileCreate(ref A3DAsmModelFileData pData, out IntPtr ppModelFile);
        public static PFA3DAsmModelFileCreate A3DAsmModelFileCreate = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileCreate>(Library.A3DGetProcAddress("A3DAsmModelFileCreate", 1));
        public delegate A3DStatus PFA3DAsmModelFileDelete(IntPtr pModelFile);
        public static PFA3DAsmModelFileDelete A3DAsmModelFileDelete = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileDelete>(Library.A3DGetProcAddress("A3DAsmModelFileDelete", 1));
        public delegate A3DStatus PFA3DAsmModelFileUnloadParts(IntPtr pModelFile, uint uiPartsSize, out IntPtr ppParts);
        public static PFA3DAsmModelFileUnloadParts A3DAsmModelFileUnloadParts = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileUnloadParts>(Library.A3DGetProcAddress("A3DAsmModelFileUnloadParts", 1));
        public delegate A3DStatus PFA3DAsmModelFileGetUnit(IntPtr pModelFile, out double pdUnit);
        public static PFA3DAsmModelFileGetUnit A3DAsmModelFileGetUnit = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileGetUnit>(Library.A3DGetProcAddress("A3DAsmModelFileGetUnit", 1));
        public delegate A3DStatus PFA3DAsmProductOccurrenceGet(IntPtr pProductOccurrence, ref A3DAsmProductOccurrenceData pData);
        public static PFA3DAsmProductOccurrenceGet A3DAsmProductOccurrenceGet = Marshal.GetDelegateForFunctionPointer<PFA3DAsmProductOccurrenceGet>(Library.A3DGetProcAddress("A3DAsmProductOccurrenceGet", 1));
        public delegate A3DStatus PFA3DAsmProductOccurrenceCreate(ref A3DAsmProductOccurrenceData pData, out IntPtr ppProductOccurrence);
        public static PFA3DAsmProductOccurrenceCreate A3DAsmProductOccurrenceCreate = Marshal.GetDelegateForFunctionPointer<PFA3DAsmProductOccurrenceCreate>(Library.A3DGetProcAddress("A3DAsmProductOccurrenceCreate", 1));
        public delegate A3DStatus PFA3DAsmProductOccurrenceSetProductPrototype(IntPtr pProductOccurrence, IntPtr pProductPrototype);
        public static PFA3DAsmProductOccurrenceSetProductPrototype A3DAsmProductOccurrenceSetProductPrototype = Marshal.GetDelegateForFunctionPointer<PFA3DAsmProductOccurrenceSetProductPrototype>(Library.A3DGetProcAddress("A3DAsmProductOccurrenceSetProductPrototype", 1));
        public delegate A3DStatus PFA3DAsmProductOccurrenceUnload(IntPtr pProductOccurrence);
        public static PFA3DAsmProductOccurrenceUnload A3DAsmProductOccurrenceUnload = Marshal.GetDelegateForFunctionPointer<PFA3DAsmProductOccurrenceUnload>(Library.A3DGetProcAddress("A3DAsmProductOccurrenceUnload", 1));
        public delegate A3DStatus PFA3DAsmProductOccurrenceGetFilePathName(IntPtr pProductOccurrence, IntPtr ppcFileName);
        public static PFA3DAsmProductOccurrenceGetFilePathName A3DAsmProductOccurrenceGetFilePathName = Marshal.GetDelegateForFunctionPointer<PFA3DAsmProductOccurrenceGetFilePathName>(Library.A3DGetProcAddress("A3DAsmProductOccurrenceGetFilePathName", 1));
        public delegate A3DStatus PFA3DAsmProductOccurrenceGetOriginalFilePathName(IntPtr pProductOccurrence, IntPtr ppcFileName);
        public static PFA3DAsmProductOccurrenceGetOriginalFilePathName A3DAsmProductOccurrenceGetOriginalFilePathName = Marshal.GetDelegateForFunctionPointer<PFA3DAsmProductOccurrenceGetOriginalFilePathName>(Library.A3DGetProcAddress("A3DAsmProductOccurrenceGetOriginalFilePathName", 1));
        public delegate A3DStatus PFA3DAsmProductOccurrenceAddView(IntPtr pProductOccurrence, IntPtr pView);
        public static PFA3DAsmProductOccurrenceAddView A3DAsmProductOccurrenceAddView = Marshal.GetDelegateForFunctionPointer<PFA3DAsmProductOccurrenceAddView>(Library.A3DGetProcAddress("A3DAsmProductOccurrenceAddView", 1));
        public delegate A3DStatus PFA3DAsmProductOccurrenceEdit(ref A3DAsmProductOccurrenceData pData, IntPtr pProductOccurrence);
        public static PFA3DAsmProductOccurrenceEdit A3DAsmProductOccurrenceEdit = Marshal.GetDelegateForFunctionPointer<PFA3DAsmProductOccurrenceEdit>(Library.A3DGetProcAddress("A3DAsmProductOccurrenceEdit", 1));
        public delegate A3DStatus PFA3DAsmProductOccurrenceDeepCopy(IntPtr pProductOccurrence, out IntPtr ppNewProductOccurrence);
        public static PFA3DAsmProductOccurrenceDeepCopy A3DAsmProductOccurrenceDeepCopy = Marshal.GetDelegateForFunctionPointer<PFA3DAsmProductOccurrenceDeepCopy>(Library.A3DGetProcAddress("A3DAsmProductOccurrenceDeepCopy", 1));
        public delegate A3DStatus PFA3DAsmProductOccurrenceGetFather(IntPtr pProductOccurrence, out IntPtr ppProductOccurrenceFather);
        public static PFA3DAsmProductOccurrenceGetFather A3DAsmProductOccurrenceGetFather = Marshal.GetDelegateForFunctionPointer<PFA3DAsmProductOccurrenceGetFather>(Library.A3DGetProcAddress("A3DAsmProductOccurrenceGetFather", 1));
        public delegate A3DStatus PFA3DAsmProductOccurrenceGetSLW(IntPtr pProductOccurrence, ref A3DAsmProductOccurrenceDataSLW pData);
        public static PFA3DAsmProductOccurrenceGetSLW A3DAsmProductOccurrenceGetSLW = Marshal.GetDelegateForFunctionPointer<PFA3DAsmProductOccurrenceGetSLW>(Library.A3DGetProcAddress("A3DAsmProductOccurrenceGetSLW", 1));
        public delegate A3DStatus PFA3DAsmProductOccurrenceGetCat(IntPtr pProductOccurrence, ref A3DAsmProductOccurrenceDataCat pData);
        public static PFA3DAsmProductOccurrenceGetCat A3DAsmProductOccurrenceGetCat = Marshal.GetDelegateForFunctionPointer<PFA3DAsmProductOccurrenceGetCat>(Library.A3DGetProcAddress("A3DAsmProductOccurrenceGetCat", 1));
        public delegate A3DStatus PFA3DAsmProductOccurrenceGetCV5(IntPtr pProductOccurrence, ref A3DAsmProductOccurrenceDataCV5 pData);
        public static PFA3DAsmProductOccurrenceGetCV5 A3DAsmProductOccurrenceGetCV5 = Marshal.GetDelegateForFunctionPointer<PFA3DAsmProductOccurrenceGetCV5>(Library.A3DGetProcAddress("A3DAsmProductOccurrenceGetCV5", 1));
        public delegate A3DStatus PFA3DAsmProductOccurrenceGetUg(IntPtr pProductOccurrence, ref A3DAsmProductOccurrenceDataUg pData);
        public static PFA3DAsmProductOccurrenceGetUg A3DAsmProductOccurrenceGetUg = Marshal.GetDelegateForFunctionPointer<PFA3DAsmProductOccurrenceGetUg>(Library.A3DGetProcAddress("A3DAsmProductOccurrenceGetUg", 1));
        public delegate A3DStatus PFA3DAsmProductOccurrenceGetProe(IntPtr pProductOccurrence, ref A3DAsmProductOccurrenceDataProe pData);
        public static PFA3DAsmProductOccurrenceGetProe A3DAsmProductOccurrenceGetProe = Marshal.GetDelegateForFunctionPointer<PFA3DAsmProductOccurrenceGetProe>(Library.A3DGetProcAddress("A3DAsmProductOccurrenceGetProe", 1));
        public delegate A3DStatus PFA3DAsmProductOccurrenceGetInv(IntPtr pProductOccurrence, ref A3DAsmProductOccurrenceDataInv pData);
        public static PFA3DAsmProductOccurrenceGetInv A3DAsmProductOccurrenceGetInv = Marshal.GetDelegateForFunctionPointer<PFA3DAsmProductOccurrenceGetInv>(Library.A3DGetProcAddress("A3DAsmProductOccurrenceGetInv", 1));
        public delegate A3DStatus PFA3DAsmProductOccurrenceGetJT(IntPtr pProductOccurrence, ref A3DAsmProductOccurrenceDataJT pData);
        public static PFA3DAsmProductOccurrenceGetJT A3DAsmProductOccurrenceGetJT = Marshal.GetDelegateForFunctionPointer<PFA3DAsmProductOccurrenceGetJT>(Library.A3DGetProcAddress("A3DAsmProductOccurrenceGetJT", 1));
        public delegate A3DStatus PFA3DAsmProductOccurrenceGetLayerList(IntPtr pProductOccurrence, out uint piLayers, IntPtr ppLayerArray);
        public static PFA3DAsmProductOccurrenceGetLayerList A3DAsmProductOccurrenceGetLayerList = Marshal.GetDelegateForFunctionPointer<PFA3DAsmProductOccurrenceGetLayerList>(Library.A3DGetProcAddress("A3DAsmProductOccurrenceGetLayerList", 1));
        public delegate A3DStatus PFA3DAsmProductOccurrenceGetIdentifier(IntPtr pProductOccurrence, IntPtr ppcIdentifier);
        public static PFA3DAsmProductOccurrenceGetIdentifier A3DAsmProductOccurrenceGetIdentifier = Marshal.GetDelegateForFunctionPointer<PFA3DAsmProductOccurrenceGetIdentifier>(Library.A3DGetProcAddress("A3DAsmProductOccurrenceGetIdentifier", 1));
        public delegate A3DStatus PFA3DAsmPartDefinitionGet(IntPtr pPartDefinition, ref A3DAsmPartDefinitionData pData);
        public static PFA3DAsmPartDefinitionGet A3DAsmPartDefinitionGet = Marshal.GetDelegateForFunctionPointer<PFA3DAsmPartDefinitionGet>(Library.A3DGetProcAddress("A3DAsmPartDefinitionGet", 1));
        public delegate A3DStatus PFA3DAsmPartDefinitionCreate(ref A3DAsmPartDefinitionData pData, out IntPtr ppPartDefinition);
        public static PFA3DAsmPartDefinitionCreate A3DAsmPartDefinitionCreate = Marshal.GetDelegateForFunctionPointer<PFA3DAsmPartDefinitionCreate>(Library.A3DGetProcAddress("A3DAsmPartDefinitionCreate", 1));
        public delegate A3DStatus PFA3DDrawingGetReferencesList(IntPtr pPartDefinition, out uint puiNumberOfFilePaths, IntPtr pppcSrcFilePaths);
        public static PFA3DDrawingGetReferencesList A3DDrawingGetReferencesList = Marshal.GetDelegateForFunctionPointer<PFA3DDrawingGetReferencesList>(Library.A3DGetProcAddress("A3DDrawingGetReferencesList", 1));
        public delegate A3DStatus PFA3DAsmPartDefinitionAddView(IntPtr pPartDefinition, IntPtr pView);
        public static PFA3DAsmPartDefinitionAddView A3DAsmPartDefinitionAddView = Marshal.GetDelegateForFunctionPointer<PFA3DAsmPartDefinitionAddView>(Library.A3DGetProcAddress("A3DAsmPartDefinitionAddView", 1));
        public delegate A3DStatus PFA3DAsmPartDefinitionEdit(ref A3DAsmPartDefinitionData pData, IntPtr pPartDefinition);
        public static PFA3DAsmPartDefinitionEdit A3DAsmPartDefinitionEdit = Marshal.GetDelegateForFunctionPointer<PFA3DAsmPartDefinitionEdit>(Library.A3DGetProcAddress("A3DAsmPartDefinitionEdit", 1));
        public delegate A3DStatus PFA3DAsmFilterGet(IntPtr pFilter, ref A3DAsmFilterData pData);
        public static PFA3DAsmFilterGet A3DAsmFilterGet = Marshal.GetDelegateForFunctionPointer<PFA3DAsmFilterGet>(Library.A3DGetProcAddress("A3DAsmFilterGet", 1));
        public delegate A3DStatus PFA3DAsmFilterCreate(ref A3DAsmFilterData pData, out IntPtr ppFilter);
        public static PFA3DAsmFilterCreate A3DAsmFilterCreate = Marshal.GetDelegateForFunctionPointer<PFA3DAsmFilterCreate>(Library.A3DGetProcAddress("A3DAsmFilterCreate", 1));
        public delegate A3DStatus PFA3DAsmGetFixedComponents(IntPtr pOwnerNode, out uint puiNumberOfFixedSubNodes, IntPtr pppFixedSubNodes);
        public static PFA3DAsmGetFixedComponents A3DAsmGetFixedComponents = Marshal.GetDelegateForFunctionPointer<PFA3DAsmGetFixedComponents>(Library.A3DGetProcAddress("A3DAsmGetFixedComponents", 1));
        public delegate A3DStatus PFA3DAsmGetFixedTogetherComponents(IntPtr pOwnerNode, out uint ppuiSizeCount, IntPtr ppuiSizeArray, IntPtr pppFixedTogetherNodes);
        public static PFA3DAsmGetFixedTogetherComponents A3DAsmGetFixedTogetherComponents = Marshal.GetDelegateForFunctionPointer<PFA3DAsmGetFixedTogetherComponents>(Library.A3DGetProcAddress("A3DAsmGetFixedTogetherComponents", 1));
        public delegate A3DStatus PFA3DAsmGetFlexibleComponents(IntPtr pOwnerNode, out uint puiNumberOfFlexibleSubNodes, IntPtr pppFlexibleSubNodes);
        public static PFA3DAsmGetFlexibleComponents A3DAsmGetFlexibleComponents = Marshal.GetDelegateForFunctionPointer<PFA3DAsmGetFlexibleComponents>(Library.A3DGetProcAddress("A3DAsmGetFlexibleComponents", 1));
        public delegate A3DStatus PFA3DAsmModelFileLoadFromFile([MarshalAs(UnmanagedType.LPStr)] string pcFileName, ref A3DRWParamsLoadData pLoadParametersData, out IntPtr ppModelFile);
        public static PFA3DAsmModelFileLoadFromFile A3DAsmModelFileLoadFromFile = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileLoadFromFile>(Library.A3DGetProcAddress("A3DAsmModelFileLoadFromFile", 1));
        public delegate A3DStatus PFA3DAsmModelFileLoadFromPrcStream([MarshalAs(UnmanagedType.LPStr)] string pcBufferStream, uint uBufferLength, out IntPtr ppPrcReadHelper, out IntPtr ppModelFile);
        public static PFA3DAsmModelFileLoadFromPrcStream A3DAsmModelFileLoadFromPrcStream = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileLoadFromPrcStream>(Library.A3DGetProcAddress("A3DAsmModelFileLoadFromPrcStream", 1));
        public delegate void PFA3DRWParamsPrcReadHelperFree(IntPtr pA3DRWParamsPrcReadHelper);
        public static PFA3DRWParamsPrcReadHelperFree A3DRWParamsPrcReadHelperFree = Marshal.GetDelegateForFunctionPointer<PFA3DRWParamsPrcReadHelperFree>(Library.A3DGetProcAddress("A3DRWParamsPrcReadHelperFree", 1));
        public delegate A3DStatus PFA3DAsmModelFileLoadFromPrcFile([MarshalAs(UnmanagedType.LPStr)] string pcFileName, out IntPtr ppPrcReadHelper, out IntPtr ppModelFile);
        public static PFA3DAsmModelFileLoadFromPrcFile A3DAsmModelFileLoadFromPrcFile = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileLoadFromPrcFile>(Library.A3DGetProcAddress("A3DAsmModelFileLoadFromPrcFile", 1));
        public delegate A3DStatus PFA3DGet3DPDFStreams([MarshalAs(UnmanagedType.LPStr)] string pcFileName, IntPtr ppStreamData, out int piNumStreams);
        public static PFA3DGet3DPDFStreams A3DGet3DPDFStreams = Marshal.GetDelegateForFunctionPointer<PFA3DGet3DPDFStreams>(Library.A3DGetProcAddress("A3DGet3DPDFStreams", 1));
        public delegate A3DStatus PFA3DAsmModelFileExportToPrcFile(IntPtr pA3DAsmModelFile, ref A3DRWParamsExportPrcData pParamsExportData, [MarshalAs(UnmanagedType.LPStr)] string pcCADFileName, out IntPtr ppPrcWriteHelper);
        public static PFA3DAsmModelFileExportToPrcFile A3DAsmModelFileExportToPrcFile = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileExportToPrcFile>(Library.A3DGetProcAddress("A3DAsmModelFileExportToPrcFile", 1));
        public delegate void PFA3DRWParamsPrcWriteHelperFree(IntPtr pA3DRWParamsPrcWriteHelper);
        public static PFA3DRWParamsPrcWriteHelperFree A3DRWParamsPrcWriteHelperFree = Marshal.GetDelegateForFunctionPointer<PFA3DRWParamsPrcWriteHelperFree>(Library.A3DGetProcAddress("A3DRWParamsPrcWriteHelperFree", 1));
        public delegate A3DStatus PFA3DAsmModelFileExportToU3DFile(IntPtr pA3DAsmModelFile, ref A3DRWParamsExportU3DData pParamsExportData, [MarshalAs(UnmanagedType.LPStr)] string pcCADFileName);
        public static PFA3DAsmModelFileExportToU3DFile A3DAsmModelFileExportToU3DFile = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileExportToU3DFile>(Library.A3DGetProcAddress("A3DAsmModelFileExportToU3DFile", 1));
        public delegate A3DStatus PFA3DAsmModelFileExportToStepFile(IntPtr pA3DAsmModelFile, ref A3DRWParamsExportStepData pParamsExportData, [MarshalAs(UnmanagedType.LPStr)] string pcCADFileName);
        public static PFA3DAsmModelFileExportToStepFile A3DAsmModelFileExportToStepFile = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileExportToStepFile>(Library.A3DGetProcAddress("A3DAsmModelFileExportToStepFile", 1));
        public delegate A3DStatus PFA3DAsmModelFileExportToJTFile(IntPtr pA3DAsmModelFile, ref A3DRWParamsExportJTData pParamsExportData, [MarshalAs(UnmanagedType.LPStr)] string pcCADFileName);
        public static PFA3DAsmModelFileExportToJTFile A3DAsmModelFileExportToJTFile = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileExportToJTFile>(Library.A3DGetProcAddress("A3DAsmModelFileExportToJTFile", 1));
        public delegate A3DStatus PFA3DAsmModelFileExportToVrmlFile(IntPtr pA3DAsmModelFile, [MarshalAs(UnmanagedType.LPStr)] string pcCADFileName);
        public static PFA3DAsmModelFileExportToVrmlFile A3DAsmModelFileExportToVrmlFile = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileExportToVrmlFile>(Library.A3DGetProcAddress("A3DAsmModelFileExportToVrmlFile", 1));
        public delegate A3DStatus PFA3DAsmModelFileExportToIgesFile(IntPtr pA3DAsmModelFile, ref A3DRWParamsExportIgesData pParamsExportData, [MarshalAs(UnmanagedType.LPStr)] string pcCADFileName);
        public static PFA3DAsmModelFileExportToIgesFile A3DAsmModelFileExportToIgesFile = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileExportToIgesFile>(Library.A3DGetProcAddress("A3DAsmModelFileExportToIgesFile", 1));
        public delegate A3DStatus PFA3DAsmModelFileExportToStlFile(IntPtr pA3DAsmModelFile, ref A3DRWParamsExportStlData pParamsExportData, [MarshalAs(UnmanagedType.LPStr)] string pcCADFileName);
        public static PFA3DAsmModelFileExportToStlFile A3DAsmModelFileExportToStlFile = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileExportToStlFile>(Library.A3DGetProcAddress("A3DAsmModelFileExportToStlFile", 1));
        public delegate A3DStatus PFA3DAsmModelFileExportTo3mfFile(IntPtr pA3DAsmModelFile, ref A3DRWParamsExport3mfData pParamsExportData, [MarshalAs(UnmanagedType.LPStr)] string pcCADFileName);
        public static PFA3DAsmModelFileExportTo3mfFile A3DAsmModelFileExportTo3mfFile = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileExportTo3mfFile>(Library.A3DGetProcAddress("A3DAsmModelFileExportTo3mfFile", 1));
        public delegate A3DStatus PFA3DAsmModelFileExportToXMLFile(IntPtr pA3DAsmModelFile, ref A3DRWParamsExportXMLData pParamsExportData, [MarshalAs(UnmanagedType.LPStr)] string pcXMLFileName, IntPtr uMapSize, IntPtr puMapXmlIds, IntPtr ppMapProductOccurrences);
        public static PFA3DAsmModelFileExportToXMLFile A3DAsmModelFileExportToXMLFile = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileExportToXMLFile>(Library.A3DGetProcAddress("A3DAsmModelFileExportToXMLFile", 1));
        public delegate A3DStatus PFA3DAsmModelFileExportToObjFile(IntPtr pA3DAsmModelFile, ref A3DRWParamsExportObjData pParamsExportData, [MarshalAs(UnmanagedType.LPStr)] string pcCADFileName);
        public static PFA3DAsmModelFileExportToObjFile A3DAsmModelFileExportToObjFile = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileExportToObjFile>(Library.A3DGetProcAddress("A3DAsmModelFileExportToObjFile", 1));
        public delegate A3DStatus PFA3DAsmModelFileExportToFbxFile(IntPtr pA3DAsmModelFile, ref A3DRWParamsExportFbxData pParamsExportData, [MarshalAs(UnmanagedType.LPStr)] string pcCADFileName);
        public static PFA3DAsmModelFileExportToFbxFile A3DAsmModelFileExportToFbxFile = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileExportToFbxFile>(Library.A3DGetProcAddress("A3DAsmModelFileExportToFbxFile", 1));
        public delegate A3DStatus PFA3DCrvGetInterval(IntPtr pCrv, ref A3DIntervalData pInterval);
        public static PFA3DCrvGetInterval A3DCrvGetInterval = Marshal.GetDelegateForFunctionPointer<PFA3DCrvGetInterval>(Library.A3DGetProcAddress("A3DCrvGetInterval", 1));
        public delegate A3DStatus PFA3DCrvEvaluate(IntPtr pCrv, double dParameter, uint uiNbDerivatives, ref A3DVector3dData pPointAndDerivatives);
        public static PFA3DCrvEvaluate A3DCrvEvaluate = Marshal.GetDelegateForFunctionPointer<PFA3DCrvEvaluate>(Library.A3DGetProcAddress("A3DCrvEvaluate", 1));
        public delegate A3DStatus PFA3DCrvEvaluatePointAndNormal(IntPtr psCrv, double dParameter, uint uiNbSurfaces, out IntPtr ppsSurfaces, uint uiNbDerivatives, ref A3DVector3dData psPointAndDerivatives, ref A3DVector3dData psNormal);
        public static PFA3DCrvEvaluatePointAndNormal A3DCrvEvaluatePointAndNormal = Marshal.GetDelegateForFunctionPointer<PFA3DCrvEvaluatePointAndNormal>(Library.A3DGetProcAddress("A3DCrvEvaluatePointAndNormal", 1));
        public delegate A3DStatus PFA3DCrvIsPeriodic(IntPtr pCrv, out bool pbIsPeriodic);
        public static PFA3DCrvIsPeriodic A3DCrvIsPeriodic = Marshal.GetDelegateForFunctionPointer<PFA3DCrvIsPeriodic>(Library.A3DGetProcAddress("A3DCrvIsPeriodic", 1));
        public delegate A3DStatus PFA3DSrfGetDomain(IntPtr pSrf, ref A3DDomainData pDomain);
        public static PFA3DSrfGetDomain A3DSrfGetDomain = Marshal.GetDelegateForFunctionPointer<PFA3DSrfGetDomain>(Library.A3DGetProcAddress("A3DSrfGetDomain", 1));
        public delegate A3DStatus PFA3DSurfEvaluate(IntPtr pSurf, ref A3DVector2dData pUVParameter, uint uiNbDerivatives, ref A3DVector3dData pPointAndDerivatives);
        public static PFA3DSurfEvaluate A3DSurfEvaluate = Marshal.GetDelegateForFunctionPointer<PFA3DSurfEvaluate>(Library.A3DGetProcAddress("A3DSurfEvaluate", 1));
        public delegate A3DStatus PFA3DSurfIsDegenerated(IntPtr pSurf, ref A3DVector2dData pUVParameter, double dTolerance, out bool pbIsDegenerated, out bool pbUDirection);
        public static PFA3DSurfIsDegenerated A3DSurfIsDegenerated = Marshal.GetDelegateForFunctionPointer<PFA3DSurfIsDegenerated>(Library.A3DGetProcAddress("A3DSurfIsDegenerated", 1));
        public delegate A3DStatus PFA3DSurfIsPeriodic(IntPtr pSrf, out bool pbUIsPeriodic, out bool pbVIsPeriodic);
        public static PFA3DSurfIsPeriodic A3DSurfIsPeriodic = Marshal.GetDelegateForFunctionPointer<PFA3DSurfIsPeriodic>(Library.A3DGetProcAddress("A3DSurfIsPeriodic", 1));
        public delegate A3DStatus PFA3DSurfIsG1Continuous(IntPtr pSurf, ref A3DVector2dData pUVParameter, double dAngleTolerance, out bool pbUG1Continuous, out bool pbVG1Continuous);
        public static PFA3DSurfIsG1Continuous A3DSurfIsG1Continuous = Marshal.GetDelegateForFunctionPointer<PFA3DSurfIsG1Continuous>(Library.A3DGetProcAddress("A3DSurfIsG1Continuous", 1));
        public delegate A3DStatus PFA3DGetCurveAsAnalytic(IntPtr pCurve, double dTol, out IntPtr pAnalyticCurve, ref A3DEAnalyticType peAnalyticType);
        public static PFA3DGetCurveAsAnalytic A3DGetCurveAsAnalytic = Marshal.GetDelegateForFunctionPointer<PFA3DGetCurveAsAnalytic>(Library.A3DGetProcAddress("A3DGetCurveAsAnalytic", 1));
        public delegate A3DStatus PFA3DSimplifyCurveWithAnalytics(IntPtr pCurve, double dTol, uint uNbRecognizedType, IntPtr pOptRecognizedType, out IntPtr pAnalyticCurve, ref A3DEAnalyticType peAnalyticType);
        public static PFA3DSimplifyCurveWithAnalytics A3DSimplifyCurveWithAnalytics = Marshal.GetDelegateForFunctionPointer<PFA3DSimplifyCurveWithAnalytics>(Library.A3DGetProcAddress("A3DSimplifyCurveWithAnalytics", 1));
        public delegate A3DStatus PFA3DGetCurveAsAnalyticFromCoEdge(IntPtr pCoEdge, double dTol, out IntPtr pAnalyticCurve, ref A3DEAnalyticType peAnalyticType);
        public static PFA3DGetCurveAsAnalyticFromCoEdge A3DGetCurveAsAnalyticFromCoEdge = Marshal.GetDelegateForFunctionPointer<PFA3DGetCurveAsAnalyticFromCoEdge>(Library.A3DGetProcAddress("A3DGetCurveAsAnalyticFromCoEdge", 1));
        public delegate A3DStatus PFA3DSimplifyCurveWithAnalyticsFromCoEdge(IntPtr pCoEdge, double dTol, uint uNbRecognizedType, IntPtr pOptRecognizedType, out IntPtr pAnalyticCurve, ref A3DEAnalyticType peAnalyticType);
        public static PFA3DSimplifyCurveWithAnalyticsFromCoEdge A3DSimplifyCurveWithAnalyticsFromCoEdge = Marshal.GetDelegateForFunctionPointer<PFA3DSimplifyCurveWithAnalyticsFromCoEdge>(Library.A3DGetProcAddress("A3DSimplifyCurveWithAnalyticsFromCoEdge", 1));
        public delegate A3DStatus PFA3DGetSurfaceAsAnalytic(IntPtr pSrf, double dTol, out IntPtr pAnalyticSurface, ref A3DEAnalyticType peAnalyticType);
        public static PFA3DGetSurfaceAsAnalytic A3DGetSurfaceAsAnalytic = Marshal.GetDelegateForFunctionPointer<PFA3DGetSurfaceAsAnalytic>(Library.A3DGetProcAddress("A3DGetSurfaceAsAnalytic", 1));
        public delegate A3DStatus PFA3DSimplifySurfaceWithAnalytics(IntPtr pSrf, double dTol, uint uNbRecognizedType, IntPtr pOptRecognizedType, out IntPtr pAnalyticSurface, ref A3DEAnalyticType peAnalyticType);
        public static PFA3DSimplifySurfaceWithAnalytics A3DSimplifySurfaceWithAnalytics = Marshal.GetDelegateForFunctionPointer<PFA3DSimplifySurfaceWithAnalytics>(Library.A3DGetProcAddress("A3DSimplifySurfaceWithAnalytics", 1));
        public delegate A3DStatus PFA3DCrvProjectPoint(IntPtr pCrv, ref A3DVector3dData pPointToProject, out uint puiNbSolutions, IntPtr ppdSolutionParameter, IntPtr ppdSolutionDistance);
        public static PFA3DCrvProjectPoint A3DCrvProjectPoint = Marshal.GetDelegateForFunctionPointer<PFA3DCrvProjectPoint>(Library.A3DGetProcAddress("A3DCrvProjectPoint", 1));
        public delegate A3DStatus PFA3DSurfProjectPoint(IntPtr pSurf, ref A3DVector3dData pPointToProject, out uint puiNbSolutions, IntPtr ppdSolutionParameters, IntPtr ppdSolutionDistance);
        public static PFA3DSurfProjectPoint A3DSurfProjectPoint = Marshal.GetDelegateForFunctionPointer<PFA3DSurfProjectPoint>(Library.A3DGetProcAddress("A3DSurfProjectPoint", 1));
        public delegate A3DStatus PFA3DCrvLocalProjectPoint(IntPtr pCrv, ref A3DVector3dData pPointToProject, double dGuessParameter, out bool pbFindSolution, out double pdSolutionParameter, out double pdSolutionDistance);
        public static PFA3DCrvLocalProjectPoint A3DCrvLocalProjectPoint = Marshal.GetDelegateForFunctionPointer<PFA3DCrvLocalProjectPoint>(Library.A3DGetProcAddress("A3DCrvLocalProjectPoint", 1));
        public delegate A3DStatus PFA3DSurfLocalProjectPoint(IntPtr pSurf, ref A3DVector3dData pPointToProject, ref A3DVector2dData pGuessPoint, out bool pbFindSolution, ref A3DVector2dData pSolutionParameter, out double pdSolutionDistance);
        public static PFA3DSurfLocalProjectPoint A3DSurfLocalProjectPoint = Marshal.GetDelegateForFunctionPointer<PFA3DSurfLocalProjectPoint>(Library.A3DGetProcAddress("A3DSurfLocalProjectPoint", 1));
        public delegate A3DStatus PFA3DSurfEvaluateNormal(IntPtr pSurf, ref A3DVector2dData pUVParameter, ref A3DVector3dData pNormal);
        public static PFA3DSurfEvaluateNormal A3DSurfEvaluateNormal = Marshal.GetDelegateForFunctionPointer<PFA3DSurfEvaluateNormal>(Library.A3DGetProcAddress("A3DSurfEvaluateNormal", 1));
        public delegate A3DStatus PFA3DSewBrep(IntPtr p, uint uNbBrepModels, double dTolerance, ref A3DSewOptionsData pData, IntPtr pBrepModelsOut, out uint uNbBrepOut);
        public static PFA3DSewBrep A3DSewBrep = Marshal.GetDelegateForFunctionPointer<PFA3DSewBrep>(Library.A3DGetProcAddress("A3DSewBrep", 1));
        public delegate A3DStatus PFA3DAsmModelFileSew(out IntPtr ppModelFile, double dToleranceInMM, ref A3DSewOptionsData pData);
        public static PFA3DAsmModelFileSew A3DAsmModelFileSew = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileSew>(Library.A3DGetProcAddress("A3DAsmModelFileSew", 1));
        public delegate A3DStatus PFA3DFaceUVPointInsideManagerCreate(ref A3DFaceUVPointInsideManagerData pData, out IntPtr pManager);
        public static PFA3DFaceUVPointInsideManagerCreate A3DFaceUVPointInsideManagerCreate = Marshal.GetDelegateForFunctionPointer<PFA3DFaceUVPointInsideManagerCreate>(Library.A3DGetProcAddress("A3DFaceUVPointInsideManagerCreate", 1));
        public delegate A3DStatus PFA3DFaceUVPointInsideManagerDelete(IntPtr pManager);
        public static PFA3DFaceUVPointInsideManagerDelete A3DFaceUVPointInsideManagerDelete = Marshal.GetDelegateForFunctionPointer<PFA3DFaceUVPointInsideManagerDelete>(Library.A3DGetProcAddress("A3DFaceUVPointInsideManagerDelete", 1));
        public delegate A3DStatus PFA3DFaceUVPointInside(IntPtr pManager, IntPtr psFace, ref A3DVector2dData pUVParameter, double dTol3D, out byte puiUVInFace);
        public static PFA3DFaceUVPointInside A3DFaceUVPointInside = Marshal.GetDelegateForFunctionPointer<PFA3DFaceUVPointInside>(Library.A3DGetProcAddress("A3DFaceUVPointInside", 1));
        public delegate A3DStatus PFA3DProjectPointCloud(uint uRiBrepModelSize, out IntPtr pRiBrepModel, uint uPointCloudSize, ref A3DVector3dData pPointCloudToProject, bool bUseExactComputation, uint uNbThreads, IntPtr ppProjectedPointCloud);
        public static PFA3DProjectPointCloud A3DProjectPointCloud = Marshal.GetDelegateForFunctionPointer<PFA3DProjectPointCloud>(Library.A3DGetProcAddress("A3DProjectPointCloud", 1));
        public delegate A3DStatus PFA3DProjectPointCloudManagerCreateFromRI(ref A3DProjectPointCloudManagerDataFromRI pData, out IntPtr pManager);
        public static PFA3DProjectPointCloudManagerCreateFromRI A3DProjectPointCloudManagerCreateFromRI = Marshal.GetDelegateForFunctionPointer<PFA3DProjectPointCloudManagerCreateFromRI>(Library.A3DGetProcAddress("A3DProjectPointCloudManagerCreateFromRI", 1));
        public delegate A3DStatus PFA3DProjectPointCloudManagerCreateFromModelFile(IntPtr pModelFile, out IntPtr pManager);
        public static PFA3DProjectPointCloudManagerCreateFromModelFile A3DProjectPointCloudManagerCreateFromModelFile = Marshal.GetDelegateForFunctionPointer<PFA3DProjectPointCloudManagerCreateFromModelFile>(Library.A3DGetProcAddress("A3DProjectPointCloudManagerCreateFromModelFile", 1));
        public delegate A3DStatus PFA3DProjectPointCloudManagerDelete(IntPtr pManager);
        public static PFA3DProjectPointCloudManagerDelete A3DProjectPointCloudManagerDelete = Marshal.GetDelegateForFunctionPointer<PFA3DProjectPointCloudManagerDelete>(Library.A3DGetProcAddress("A3DProjectPointCloudManagerDelete", 1));
        public delegate A3DStatus PFA3DProjectPointCloud2(IntPtr pManager, uint uPointCloudSize, ref A3DVector3dData pPointCloudToProject, bool bUseExactComputation, uint uNbThreads, double dInsidePointEdgeTolerance, IntPtr ppProjectedPointCloud);
        public static PFA3DProjectPointCloud2 A3DProjectPointCloud2 = Marshal.GetDelegateForFunctionPointer<PFA3DProjectPointCloud2>(Library.A3DGetProcAddress("A3DProjectPointCloud2", 1));
        public delegate A3DStatus PFA3DComputePlanarSectionOnRepresentationItem(IntPtr pRiBrepModel, ref A3DPlanarSectionData psSectionParametersData, out IntPtr ppRISectionResults);
        public static PFA3DComputePlanarSectionOnRepresentationItem A3DComputePlanarSectionOnRepresentationItem = Marshal.GetDelegateForFunctionPointer<PFA3DComputePlanarSectionOnRepresentationItem>(Library.A3DGetProcAddress("A3DComputePlanarSectionOnRepresentationItem", 1));
        public delegate A3DStatus PFA3DComputePlanarSectionOnModelFile(IntPtr pModelFile, ref A3DPlanarSectionData psSectionParametersData, out uint pNumberOfSections, IntPtr pppRISectionElements);
        public static PFA3DComputePlanarSectionOnModelFile A3DComputePlanarSectionOnModelFile = Marshal.GetDelegateForFunctionPointer<PFA3DComputePlanarSectionOnModelFile>(Library.A3DGetProcAddress("A3DComputePlanarSectionOnModelFile", 1));
        public delegate A3DStatus PFA3DCurveLength(IntPtr pCrv, ref A3DIntervalData pOptInterval, out double pdLength);
        public static PFA3DCurveLength A3DCurveLength = Marshal.GetDelegateForFunctionPointer<PFA3DCurveLength>(Library.A3DGetProcAddress("A3DCurveLength", 1));
        public delegate A3DStatus PFA3DCompareFaces(ref A3DCompareInputData pInput, ref A3DCompareOutputData pOutput);
        public static PFA3DCompareFaces A3DCompareFaces = Marshal.GetDelegateForFunctionPointer<PFA3DCompareFaces>(Library.A3DGetProcAddress("A3DCompareFaces", 1));
        public delegate A3DStatus PFA3DCompareFacesInBrepModels(IntPtr pFirstModelFile, IntPtr pSecondModelFile, double dTolerance, ref A3DCompareOutputData pOutput);
        public static PFA3DCompareFacesInBrepModels A3DCompareFacesInBrepModels = Marshal.GetDelegateForFunctionPointer<PFA3DCompareFacesInBrepModels>(Library.A3DGetProcAddress("A3DCompareFacesInBrepModels", 1));
        public delegate A3DStatus PFA3DCutWithMultiPlanarSectionOnRepresentationItems(uint uiNbRepItems, out IntPtr apRepItems, IntPtr pOptPlacements, ref A3DMultiPlanarSectionData psSectionParametersData, out uint pNumberOfRepItems, IntPtr pppRIRepresentationItem, IntPtr pppRIPlanarSections);
        public static PFA3DCutWithMultiPlanarSectionOnRepresentationItems A3DCutWithMultiPlanarSectionOnRepresentationItems = Marshal.GetDelegateForFunctionPointer<PFA3DCutWithMultiPlanarSectionOnRepresentationItems>(Library.A3DGetProcAddress("A3DCutWithMultiPlanarSectionOnRepresentationItems", 1));
        public delegate A3DStatus PFA3DCutWithMultiPlanarSectionOnModelFile(IntPtr pModelFile, IntPtr pOptMrkRView, ref A3DMultiPlanarSectionData psSectionParametersData, out uint pNumberOfRepItems, IntPtr pppRIRepresentationItem, IntPtr pppRIPlanarSections);
        public static PFA3DCutWithMultiPlanarSectionOnModelFile A3DCutWithMultiPlanarSectionOnModelFile = Marshal.GetDelegateForFunctionPointer<PFA3DCutWithMultiPlanarSectionOnModelFile>(Library.A3DGetProcAddress("A3DCutWithMultiPlanarSectionOnModelFile", 1));
        public delegate A3DStatus PFA3DComputeOrthoHLROnRepresentationItems(uint uiNbRepItems, out IntPtr apRepItems, IntPtr pOptPlacements, ref A3DHLRViewPlaneData psHLRViewPlaneData, out uint pNumberHLRData, IntPtr pppHLRData);
        public static PFA3DComputeOrthoHLROnRepresentationItems A3DComputeOrthoHLROnRepresentationItems = Marshal.GetDelegateForFunctionPointer<PFA3DComputeOrthoHLROnRepresentationItems>(Library.A3DGetProcAddress("A3DComputeOrthoHLROnRepresentationItems", 1));
        public delegate A3DStatus PFA3DComputeOrthoHLROnModelFile(IntPtr pModelFile, IntPtr pOptMrkRView, ref A3DHLRViewPlaneData psHLRViewPlaneData, out uint pNumberHLRData, IntPtr pppHLRData);
        public static PFA3DComputeOrthoHLROnModelFile A3DComputeOrthoHLROnModelFile = Marshal.GetDelegateForFunctionPointer<PFA3DComputeOrthoHLROnModelFile>(Library.A3DGetProcAddress("A3DComputeOrthoHLROnModelFile", 1));
        public delegate A3DStatus PFA3DComputeOrthoHLROnModelFile2(IntPtr pModelFile, IntPtr pOptMrkRView, ref A3DHLRViewPlaneData psHLRViewPlaneData, out uint pNumberHLRRepItem, IntPtr pppHLRRepItem);
        public static PFA3DComputeOrthoHLROnModelFile2 A3DComputeOrthoHLROnModelFile2 = Marshal.GetDelegateForFunctionPointer<PFA3DComputeOrthoHLROnModelFile2>(Library.A3DGetProcAddress("A3DComputeOrthoHLROnModelFile2", 1));
        public delegate A3DStatus PFA3DComputeOrthoHLROnModelFile3(IntPtr pModelFile, IntPtr pOptMrkRView, ref A3DHLRViewPlaneData psHLRViewPlaneData, ref A3DHLROptionsData psHLROptionsData, out uint pNumberHLRRepItem, IntPtr ppHLRRepItems);
        public static PFA3DComputeOrthoHLROnModelFile3 A3DComputeOrthoHLROnModelFile3 = Marshal.GetDelegateForFunctionPointer<PFA3DComputeOrthoHLROnModelFile3>(Library.A3DGetProcAddress("A3DComputeOrthoHLROnModelFile3", 1));
        public delegate A3DStatus PFA3DHLRRepresentationItemGet(IntPtr pHLRRepItem, ref A3DHLRRepresentationItemData psRIData);
        public static PFA3DHLRRepresentationItemGet A3DHLRRepresentationItemGet = Marshal.GetDelegateForFunctionPointer<PFA3DHLRRepresentationItemGet>(Library.A3DGetProcAddress("A3DHLRRepresentationItemGet", 1));
        public delegate void PFA3DDllActivateXMLTrace(bool activate);
        public static PFA3DDllActivateXMLTrace A3DDllActivateXMLTrace = Marshal.GetDelegateForFunctionPointer<PFA3DDllActivateXMLTrace>(Library.A3DGetProcAddress("A3DDllActivateXMLTrace", 1));
        public delegate A3DStatus PFA3DXmlParsing(IntPtr pModelfile, [MarshalAs(UnmanagedType.LPStr)] string pcFileName);
        public static PFA3DXmlParsing A3DXmlParsing = Marshal.GetDelegateForFunctionPointer<PFA3DXmlParsing>(Library.A3DGetProcAddress("A3DXmlParsing", 1));
        public delegate A3DStatus PFA3DCollisionCompute(ref A3DCollisionGroupData pGroup1, ref A3DCollisionGroupData pGroup2, ref A3DCollisionParameterData pParameterData, out uint uCollisionResultsSize, IntPtr pCollisionResults);
        public static PFA3DCollisionCompute A3DCollisionCompute = Marshal.GetDelegateForFunctionPointer<PFA3DCollisionCompute>(Library.A3DGetProcAddress("A3DCollisionCompute", 1));
        public delegate A3DStatus PFA3DDllInitialize(int iMajorVersion, int iMinorVersion);
        public static PFA3DDllInitialize A3DDllInitialize = Marshal.GetDelegateForFunctionPointer<PFA3DDllInitialize>(Library.A3DGetProcAddress("A3DDllInitialize", 1));
        public delegate A3DStatus PFA3DDllGetVersion(out int piMajorVersion, out int piMinorVersion);
        public static PFA3DDllGetVersion A3DDllGetVersion = Marshal.GetDelegateForFunctionPointer<PFA3DDllGetVersion>(Library.A3DGetProcAddress("A3DDllGetVersion", 1));
        public delegate void A3DCallbackMemoryFree(IntPtr arg1);
        public delegate A3DStatus PFA3DDllSetCallbacksMemory(IntPtr arg1, IntPtr arg2);
        public static PFA3DDllSetCallbacksMemory A3DDllSetCallbacksMemory = Marshal.GetDelegateForFunctionPointer<PFA3DDllSetCallbacksMemory>(Library.A3DGetProcAddress("A3DDllSetCallbacksMemory", 1));
        public delegate int A3DCallbackReportMessage([MarshalAs(UnmanagedType.LPStr)] string arg1);
        public delegate int A3DCallbackReportWarning([MarshalAs(UnmanagedType.LPStr)] string arg1, [MarshalAs(UnmanagedType.LPStr)] string arg2);
        public delegate int A3DCallbackReportError([MarshalAs(UnmanagedType.LPStr)] string arg1, [MarshalAs(UnmanagedType.LPStr)] string arg2);
        public delegate A3DStatus PFA3DDllSetCallbacksReport(IntPtr arg1, IntPtr arg2, IntPtr arg3);
        public static PFA3DDllSetCallbacksReport A3DDllSetCallbacksReport = Marshal.GetDelegateForFunctionPointer<PFA3DDllSetCallbacksReport>(Library.A3DGetProcAddress("A3DDllSetCallbacksReport", 1));
        public delegate void A3DCallbackAPITrace([MarshalAs(UnmanagedType.LPStr)] string arg1, uint arg2, IntPtr arg3, [MarshalAs(UnmanagedType.LPStr)] string arg4);
        public delegate A3DStatus PFA3DDllSetCallbackAPITrace(IntPtr arg1);
        public static PFA3DDllSetCallbackAPITrace A3DDllSetCallbackAPITrace = Marshal.GetDelegateForFunctionPointer<PFA3DDllSetCallbackAPITrace>(Library.A3DGetProcAddress("A3DDllSetCallbackAPITrace", 1));
        public delegate void A3DCallbackProgressStart(int arg1);
        public delegate void A3DCallbackProgressSize(int arg1);
        public delegate void A3DCallbackProgressIncrement(int arg1);
        public delegate void A3DCallbackProgressTitle([MarshalAs(UnmanagedType.LPStr)] string msg);
        public delegate A3DStatus PFA3DDllSetCallbacksProgress(IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, out int arg6);
        public static PFA3DDllSetCallbacksProgress A3DDllSetCallbacksProgress = Marshal.GetDelegateForFunctionPointer<PFA3DDllSetCallbacksProgress>(Library.A3DGetProcAddress("A3DDllSetCallbacksProgress", 1));
        public delegate A3DStatus PFA3DMkpLeaderGet(IntPtr pLeader, ref A3DMkpLeaderData pData);
        public static PFA3DMkpLeaderGet A3DMkpLeaderGet = Marshal.GetDelegateForFunctionPointer<PFA3DMkpLeaderGet>(Library.A3DGetProcAddress("A3DMkpLeaderGet", 1));
        public delegate A3DStatus PFA3DMkpLeaderCreate(ref A3DMkpLeaderData pData, out IntPtr ppLeader);
        public static PFA3DMkpLeaderCreate A3DMkpLeaderCreate = Marshal.GetDelegateForFunctionPointer<PFA3DMkpLeaderCreate>(Library.A3DGetProcAddress("A3DMkpLeaderCreate", 1));
        public delegate A3DStatus PFA3DMkpAnnotationItemGet(IntPtr pAnnotation, ref A3DMkpAnnotationItemData pData);
        public static PFA3DMkpAnnotationItemGet A3DMkpAnnotationItemGet = Marshal.GetDelegateForFunctionPointer<PFA3DMkpAnnotationItemGet>(Library.A3DGetProcAddress("A3DMkpAnnotationItemGet", 1));
        public delegate A3DStatus PFA3DMkpAnnotationItemCreate(ref A3DMkpAnnotationItemData pData, out IntPtr ppAnnotation);
        public static PFA3DMkpAnnotationItemCreate A3DMkpAnnotationItemCreate = Marshal.GetDelegateForFunctionPointer<PFA3DMkpAnnotationItemCreate>(Library.A3DGetProcAddress("A3DMkpAnnotationItemCreate", 1));
        public delegate A3DStatus PFA3DMkpAnnotationSetGet(IntPtr pAnnotation, ref A3DMkpAnnotationSetData pData);
        public static PFA3DMkpAnnotationSetGet A3DMkpAnnotationSetGet = Marshal.GetDelegateForFunctionPointer<PFA3DMkpAnnotationSetGet>(Library.A3DGetProcAddress("A3DMkpAnnotationSetGet", 1));
        public delegate A3DStatus PFA3DMkpAnnotationSetCreate(ref A3DMkpAnnotationSetData pData, out IntPtr ppAnnotation);
        public static PFA3DMkpAnnotationSetCreate A3DMkpAnnotationSetCreate = Marshal.GetDelegateForFunctionPointer<PFA3DMkpAnnotationSetCreate>(Library.A3DGetProcAddress("A3DMkpAnnotationSetCreate", 1));
        public delegate A3DStatus PFA3DMkpAnnotationReferenceGet(IntPtr pAnnotation, ref A3DMkpAnnotationReferenceData pData);
        public static PFA3DMkpAnnotationReferenceGet A3DMkpAnnotationReferenceGet = Marshal.GetDelegateForFunctionPointer<PFA3DMkpAnnotationReferenceGet>(Library.A3DGetProcAddress("A3DMkpAnnotationReferenceGet", 1));
        public delegate A3DStatus PFA3DMkpAnnotationReferenceCreate(ref A3DMkpAnnotationReferenceData pData, out IntPtr ppAnnotation);
        public static PFA3DMkpAnnotationReferenceCreate A3DMkpAnnotationReferenceCreate = Marshal.GetDelegateForFunctionPointer<PFA3DMkpAnnotationReferenceCreate>(Library.A3DGetProcAddress("A3DMkpAnnotationReferenceCreate", 1));
        public delegate A3DStatus PFA3DMkpViewGet(IntPtr pView, ref A3DMkpViewData pData);
        public static PFA3DMkpViewGet A3DMkpViewGet = Marshal.GetDelegateForFunctionPointer<PFA3DMkpViewGet>(Library.A3DGetProcAddress("A3DMkpViewGet", 1));
        public delegate A3DStatus PFA3DMkpViewCreate(ref A3DMkpViewData pData, out IntPtr ppView);
        public static PFA3DMkpViewCreate A3DMkpViewCreate = Marshal.GetDelegateForFunctionPointer<PFA3DMkpViewCreate>(Library.A3DGetProcAddress("A3DMkpViewCreate", 1));
        public delegate A3DStatus PFA3DMkpViewGetFlags(IntPtr pView, ref A3DMkpViewFlagsData pFlags);
        public static PFA3DMkpViewGetFlags A3DMkpViewGetFlags = Marshal.GetDelegateForFunctionPointer<PFA3DMkpViewGetFlags>(Library.A3DGetProcAddress("A3DMkpViewGetFlags", 1));
        public delegate A3DStatus PFA3DMiscMarkupLinkedItemGet(IntPtr pLinkedItem, ref A3DMiscMarkupLinkedItemData pData);
        public static PFA3DMiscMarkupLinkedItemGet A3DMiscMarkupLinkedItemGet = Marshal.GetDelegateForFunctionPointer<PFA3DMiscMarkupLinkedItemGet>(Library.A3DGetProcAddress("A3DMiscMarkupLinkedItemGet", 1));
        public delegate A3DStatus PFA3DMiscMarkupLinkedItemCreate(ref A3DMiscMarkupLinkedItemData pData, out IntPtr ppLinkedItem);
        public static PFA3DMiscMarkupLinkedItemCreate A3DMiscMarkupLinkedItemCreate = Marshal.GetDelegateForFunctionPointer<PFA3DMiscMarkupLinkedItemCreate>(Library.A3DGetProcAddress("A3DMiscMarkupLinkedItemCreate", 1));
        public delegate A3DStatus PFA3DMkpMarkupGet(IntPtr pMarkup, ref A3DMkpMarkupData pData);
        public static PFA3DMkpMarkupGet A3DMkpMarkupGet = Marshal.GetDelegateForFunctionPointer<PFA3DMkpMarkupGet>(Library.A3DGetProcAddress("A3DMkpMarkupGet", 1));
        public delegate A3DStatus PFA3DMkpMarkupCreate(ref A3DMkpMarkupData pData, out IntPtr ppMarkup);
        public static PFA3DMkpMarkupCreate A3DMkpMarkupCreate = Marshal.GetDelegateForFunctionPointer<PFA3DMkpMarkupCreate>(Library.A3DGetProcAddress("A3DMkpMarkupCreate", 1));
        public delegate A3DStatus PFA3DMkpLinkForMarkupReferenceGet(IntPtr pMarkup, out uint puiLinkedItemsSize, IntPtr ppLinkedItems);
        public static PFA3DMkpLinkForMarkupReferenceGet A3DMkpLinkForMarkupReferenceGet = Marshal.GetDelegateForFunctionPointer<PFA3DMkpLinkForMarkupReferenceGet>(Library.A3DGetProcAddress("A3DMkpLinkForMarkupReferenceGet", 1));
        public delegate A3DStatus PFA3DMkpLinkForAdditionalMarkupReferenceGet(IntPtr pMarkup, out uint puiLinkedItemsSize, IntPtr pppLinkedItems);
        public static PFA3DMkpLinkForAdditionalMarkupReferenceGet A3DMkpLinkForAdditionalMarkupReferenceGet = Marshal.GetDelegateForFunctionPointer<PFA3DMkpLinkForAdditionalMarkupReferenceGet>(Library.A3DGetProcAddress("A3DMkpLinkForAdditionalMarkupReferenceGet", 1));
        public delegate A3DStatus PFA3DMkpRTFFieldCreate([MarshalAs(UnmanagedType.LPStr)] string pRTFString, out IntPtr pRTFField);
        public static PFA3DMkpRTFFieldCreate A3DMkpRTFFieldCreate = Marshal.GetDelegateForFunctionPointer<PFA3DMkpRTFFieldCreate>(Library.A3DGetProcAddress("A3DMkpRTFFieldCreate", 1));
        public delegate A3DStatus PFA3DMkpRTFInit([MarshalAs(UnmanagedType.LPStr)] string pRTF, out IntPtr pRTFData);
        public static PFA3DMkpRTFInit A3DMkpRTFInit = Marshal.GetDelegateForFunctionPointer<PFA3DMkpRTFInit>(Library.A3DGetProcAddress("A3DMkpRTFInit", 1));
        public delegate A3DStatus PFA3DMkpRTFFieldGet(IntPtr pRTFField, ref A3DMkpRTFFieldData pRTFFieldData);
        public static PFA3DMkpRTFFieldGet A3DMkpRTFFieldGet = Marshal.GetDelegateForFunctionPointer<PFA3DMkpRTFFieldGet>(Library.A3DGetProcAddress("A3DMkpRTFFieldGet", 1));
        public delegate A3DStatus PFA3DMkpRTFGetField(IntPtr pRTFData, out A3DMkpRTFFieldData pRTFField);
        public static PFA3DMkpRTFGetField A3DMkpRTFGetField = Marshal.GetDelegateForFunctionPointer<PFA3DMkpRTFGetField>(Library.A3DGetProcAddress("A3DMkpRTFGetField", 1));
        public delegate A3DStatus PFA3DMkpRTFFieldDelete(IntPtr pRTFField);
        public static PFA3DMkpRTFFieldDelete A3DMkpRTFFieldDelete = Marshal.GetDelegateForFunctionPointer<PFA3DMkpRTFFieldDelete>(Library.A3DGetProcAddress("A3DMkpRTFFieldDelete", 1));
        public delegate A3DStatus PFA3DMkpRTFDelete(IntPtr pRTFData);
        public static PFA3DMkpRTFDelete A3DMkpRTFDelete = Marshal.GetDelegateForFunctionPointer<PFA3DMkpRTFDelete>(Library.A3DGetProcAddress("A3DMkpRTFDelete", 1));
        public delegate A3DStatus PFA3DGlobalFontKeyGet(ref A3DFontKeyData pFontKeyData, ref A3DFontData pFontData);
        public static PFA3DGlobalFontKeyGet A3DGlobalFontKeyGet = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalFontKeyGet>(Library.A3DGetProcAddress("A3DGlobalFontKeyGet", 1));
        public delegate A3DStatus PFA3DGlobalFontTextBoxGet(ref A3DFontKeyData psFontKeyData, [MarshalAs(UnmanagedType.LPStr)] string pcText, out double pdLength, out double pdHeight);
        public static PFA3DGlobalFontTextBoxGet A3DGlobalFontTextBoxGet = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalFontTextBoxGet>(Library.A3DGetProcAddress("A3DGlobalFontTextBoxGet", 1));
        public delegate A3DStatus PFA3DGlobalFontTextBoxAndScaleGet(ref A3DFontKeyData psFontKeyData, [MarshalAs(UnmanagedType.LPStr)] string pcText, out double pdLength, out double pdHeight, out double pdScale);
        public static PFA3DGlobalFontTextBoxAndScaleGet A3DGlobalFontTextBoxAndScaleGet = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalFontTextBoxAndScaleGet>(Library.A3DGetProcAddress("A3DGlobalFontTextBoxAndScaleGet", 1));
        public delegate A3DStatus PFA3DGlobalFontKeyCreate(ref A3DFontData pFontData, ref A3DFontKeyData pFontKeyData);
        public static PFA3DGlobalFontKeyCreate A3DGlobalFontKeyCreate = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalFontKeyCreate>(Library.A3DGetProcAddress("A3DGlobalFontKeyCreate", 1));
        public delegate A3DStatus PFA3DGlobalFontTextTessellationGet(ref A3DFontKeyData psFontKeyData, [MarshalAs(UnmanagedType.LPStr)] string pcOneChar, out IntPtr ppset, out double pdCharWidth);
        public static PFA3DGlobalFontTextTessellationGet A3DGlobalFontTextTessellationGet = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalFontTextTessellationGet>(Library.A3DGetProcAddress("A3DGlobalFontTextTessellationGet", 1));
        public delegate A3DStatus PFA3DGraphTextureTransformationGet(IntPtr pTextureTransformation, ref A3DGraphTextureTransformationData pData);
        public static PFA3DGraphTextureTransformationGet A3DGraphTextureTransformationGet = Marshal.GetDelegateForFunctionPointer<PFA3DGraphTextureTransformationGet>(Library.A3DGetProcAddress("A3DGraphTextureTransformationGet", 1));
        public delegate A3DStatus PFA3DGraphTextureTransformationCreate(ref A3DGraphTextureTransformationData pData, out IntPtr ppTextureTransformation);
        public static PFA3DGraphTextureTransformationCreate A3DGraphTextureTransformationCreate = Marshal.GetDelegateForFunctionPointer<PFA3DGraphTextureTransformationCreate>(Library.A3DGetProcAddress("A3DGraphTextureTransformationCreate", 1));
        public delegate A3DStatus PFA3DGlobalGetGraphTextureDefinitionData(uint uiIndexTextureDefinition, ref A3DGraphTextureDefinitionData pData);
        public static PFA3DGlobalGetGraphTextureDefinitionData A3DGlobalGetGraphTextureDefinitionData = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalGetGraphTextureDefinitionData>(Library.A3DGetProcAddress("A3DGlobalGetGraphTextureDefinitionData", 1));
        public delegate A3DStatus PFA3DGlobalInsertGraphTextureDefinition(ref A3DGraphTextureDefinitionData pData, out uint puiIndexTextureDefinition);
        public static PFA3DGlobalInsertGraphTextureDefinition A3DGlobalInsertGraphTextureDefinition = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalInsertGraphTextureDefinition>(Library.A3DGetProcAddress("A3DGlobalInsertGraphTextureDefinition", 1));
        public delegate A3DStatus PFA3DGlobalGetGraphTextureApplicationData(uint uiIndexTextureApplication, ref A3DGraphTextureApplicationData pData);
        public static PFA3DGlobalGetGraphTextureApplicationData A3DGlobalGetGraphTextureApplicationData = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalGetGraphTextureApplicationData>(Library.A3DGetProcAddress("A3DGlobalGetGraphTextureApplicationData", 1));
        public delegate A3DStatus PFA3DGlobalInsertGraphTextureApplication(ref A3DGraphTextureApplicationData pData, out uint puiIndexTextureApplication);
        public static PFA3DGlobalInsertGraphTextureApplication A3DGlobalInsertGraphTextureApplication = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalInsertGraphTextureApplication>(Library.A3DGetProcAddress("A3DGlobalInsertGraphTextureApplication", 1));
        public delegate A3DStatus PFA3DDrawingModelGet(IntPtr pDrawingModel, ref A3DDrawingModelData pData);
        public static PFA3DDrawingModelGet A3DDrawingModelGet = Marshal.GetDelegateForFunctionPointer<PFA3DDrawingModelGet>(Library.A3DGetProcAddress("A3DDrawingModelGet", 1));
        public delegate A3DStatus PFA3DDrawingModelCreate(ref A3DDrawingModelData pData, out IntPtr ppDrawingModel);
        public static PFA3DDrawingModelCreate A3DDrawingModelCreate = Marshal.GetDelegateForFunctionPointer<PFA3DDrawingModelCreate>(Library.A3DGetProcAddress("A3DDrawingModelCreate", 1));
        public delegate A3DStatus PFA3DDrawingSheetFormatGet(IntPtr pDrwSheetFormat, ref A3DDrawingSheetFormatData pData);
        public static PFA3DDrawingSheetFormatGet A3DDrawingSheetFormatGet = Marshal.GetDelegateForFunctionPointer<PFA3DDrawingSheetFormatGet>(Library.A3DGetProcAddress("A3DDrawingSheetFormatGet", 1));
        public delegate A3DStatus PFA3DDrawingSheetFormatCreate(ref A3DDrawingSheetFormatData pData, out IntPtr ppDrwSheetFormat);
        public static PFA3DDrawingSheetFormatCreate A3DDrawingSheetFormatCreate = Marshal.GetDelegateForFunctionPointer<PFA3DDrawingSheetFormatCreate>(Library.A3DGetProcAddress("A3DDrawingSheetFormatCreate", 1));
        public delegate A3DStatus PFA3DDrawingSheetGet(IntPtr pDrawingSheet, ref A3DDrawingSheetData pData);
        public static PFA3DDrawingSheetGet A3DDrawingSheetGet = Marshal.GetDelegateForFunctionPointer<PFA3DDrawingSheetGet>(Library.A3DGetProcAddress("A3DDrawingSheetGet", 1));
        public delegate A3DStatus PFA3DDrawingSheetCreate(ref A3DDrawingSheetData pData, out IntPtr ppDrawingSheet);
        public static PFA3DDrawingSheetCreate A3DDrawingSheetCreate = Marshal.GetDelegateForFunctionPointer<PFA3DDrawingSheetCreate>(Library.A3DGetProcAddress("A3DDrawingSheetCreate", 1));
        public delegate A3DStatus PFA3DDrawingClipFrameGet(IntPtr pDrwClipFrame, ref A3DDrawingClipFrameData pData);
        public static PFA3DDrawingClipFrameGet A3DDrawingClipFrameGet = Marshal.GetDelegateForFunctionPointer<PFA3DDrawingClipFrameGet>(Library.A3DGetProcAddress("A3DDrawingClipFrameGet", 1));
        public delegate A3DStatus PFA3DDrawingClipFrameCreate(ref A3DDrawingClipFrameData pData, out IntPtr ppDrwClipFrame);
        public static PFA3DDrawingClipFrameCreate A3DDrawingClipFrameCreate = Marshal.GetDelegateForFunctionPointer<PFA3DDrawingClipFrameCreate>(Library.A3DGetProcAddress("A3DDrawingClipFrameCreate", 1));
        public delegate A3DStatus PFA3DDrawingViewGet(IntPtr pDrawingView, ref A3DDrawingViewData pData);
        public static PFA3DDrawingViewGet A3DDrawingViewGet = Marshal.GetDelegateForFunctionPointer<PFA3DDrawingViewGet>(Library.A3DGetProcAddress("A3DDrawingViewGet", 1));
        public delegate A3DStatus PFA3DDrawingViewCreate(ref A3DDrawingViewData pData, out IntPtr ppDrawingView);
        public static PFA3DDrawingViewCreate A3DDrawingViewCreate = Marshal.GetDelegateForFunctionPointer<PFA3DDrawingViewCreate>(Library.A3DGetProcAddress("A3DDrawingViewCreate", 1));
        public delegate A3DStatus PFA3DDrawingBlockBasicGet(IntPtr pDrawingBlock, ref A3DDrawingBlockBasicData pData);
        public static PFA3DDrawingBlockBasicGet A3DDrawingBlockBasicGet = Marshal.GetDelegateForFunctionPointer<PFA3DDrawingBlockBasicGet>(Library.A3DGetProcAddress("A3DDrawingBlockBasicGet", 1));
        public delegate A3DStatus PFA3DDrawingBlockBasicCreate(ref A3DDrawingBlockBasicData pData, out IntPtr ppDrawingBlock);
        public static PFA3DDrawingBlockBasicCreate A3DDrawingBlockBasicCreate = Marshal.GetDelegateForFunctionPointer<PFA3DDrawingBlockBasicCreate>(Library.A3DGetProcAddress("A3DDrawingBlockBasicCreate", 1));
        public delegate A3DStatus PFA3DDrawingBlockOperatorGet(IntPtr pDrawingOperator, ref A3DDrawingBlockOperatorData pData);
        public static PFA3DDrawingBlockOperatorGet A3DDrawingBlockOperatorGet = Marshal.GetDelegateForFunctionPointer<PFA3DDrawingBlockOperatorGet>(Library.A3DGetProcAddress("A3DDrawingBlockOperatorGet", 1));
        public delegate A3DStatus PFA3DDrawingBlockOperatorCreate(ref A3DDrawingBlockOperatorData pData, out IntPtr ppDrawingOperator);
        public static PFA3DDrawingBlockOperatorCreate A3DDrawingBlockOperatorCreate = Marshal.GetDelegateForFunctionPointer<PFA3DDrawingBlockOperatorCreate>(Library.A3DGetProcAddress("A3DDrawingBlockOperatorCreate", 1));
        public delegate A3DStatus PFA3DDrawingBlockPushMiscCascadedAttributes(IntPtr pAttr, IntPtr pBlock, uint uiEntityIndex, IntPtr pFather);
        public static PFA3DDrawingBlockPushMiscCascadedAttributes A3DDrawingBlockPushMiscCascadedAttributes = Marshal.GetDelegateForFunctionPointer<PFA3DDrawingBlockPushMiscCascadedAttributes>(Library.A3DGetProcAddress("A3DDrawingBlockPushMiscCascadedAttributes", 1));
        public delegate A3DStatus PFA3DDrawingCurveGet(IntPtr pDrawingCrv, ref A3DDrawingCurveData pData);
        public static PFA3DDrawingCurveGet A3DDrawingCurveGet = Marshal.GetDelegateForFunctionPointer<PFA3DDrawingCurveGet>(Library.A3DGetProcAddress("A3DDrawingCurveGet", 1));
        public delegate A3DStatus PFA3DDrawingCurveCreate(ref A3DDrawingCurveData pData, out IntPtr ppDrawingCrv);
        public static PFA3DDrawingCurveCreate A3DDrawingCurveCreate = Marshal.GetDelegateForFunctionPointer<PFA3DDrawingCurveCreate>(Library.A3DGetProcAddress("A3DDrawingCurveCreate", 1));
        public delegate A3DStatus PFA3DDrawingFilledAreaGet(IntPtr pDrwFilledArea, ref A3DDrawingFilledAreaData pData);
        public static PFA3DDrawingFilledAreaGet A3DDrawingFilledAreaGet = Marshal.GetDelegateForFunctionPointer<PFA3DDrawingFilledAreaGet>(Library.A3DGetProcAddress("A3DDrawingFilledAreaGet", 1));
        public delegate A3DStatus PFA3DDrawingFilledAreaCreate(ref A3DDrawingFilledAreaData pData, out IntPtr ppDrwFilledArea);
        public static PFA3DDrawingFilledAreaCreate A3DDrawingFilledAreaCreate = Marshal.GetDelegateForFunctionPointer<PFA3DDrawingFilledAreaCreate>(Library.A3DGetProcAddress("A3DDrawingFilledAreaCreate", 1));
        public delegate A3DStatus PFA3DDrawingPictureGet(IntPtr pDrawingPicture, ref A3DDrawingPictureData pData);
        public static PFA3DDrawingPictureGet A3DDrawingPictureGet = Marshal.GetDelegateForFunctionPointer<PFA3DDrawingPictureGet>(Library.A3DGetProcAddress("A3DDrawingPictureGet", 1));
        public delegate A3DStatus PFA3DDrawingPictureCreate(ref A3DDrawingPictureData pData, out IntPtr ppDrawingPicture);
        public static PFA3DDrawingPictureCreate A3DDrawingPictureCreate = Marshal.GetDelegateForFunctionPointer<PFA3DDrawingPictureCreate>(Library.A3DGetProcAddress("A3DDrawingPictureCreate", 1));
        public delegate A3DStatus PFA3DDrawingVerticesGet(IntPtr pDrawingVertices, ref A3DDrawingVerticesData pData);
        public static PFA3DDrawingVerticesGet A3DDrawingVerticesGet = Marshal.GetDelegateForFunctionPointer<PFA3DDrawingVerticesGet>(Library.A3DGetProcAddress("A3DDrawingVerticesGet", 1));
        public delegate A3DStatus PFA3DDrawingVerticesCreate(ref A3DDrawingVerticesData pData, out IntPtr ppDrawingVertices);
        public static PFA3DDrawingVerticesCreate A3DDrawingVerticesCreate = Marshal.GetDelegateForFunctionPointer<PFA3DDrawingVerticesCreate>(Library.A3DGetProcAddress("A3DDrawingVerticesCreate", 1));
        public delegate A3DStatus PFA3DGetFileFormat([MarshalAs(UnmanagedType.LPStr)] string pcFileName, ref A3DEModellerType peModellerType);
        public static PFA3DGetFileFormat A3DGetFileFormat = Marshal.GetDelegateForFunctionPointer<PFA3DGetFileFormat>(Library.A3DGetProcAddress("A3DGetFileFormat", 1));
        public delegate A3DStatus PFA3DCheckFileFormat([MarshalAs(UnmanagedType.LPStr)] string pcFileName, A3DEModellerType eCadTypeWanted);
        public static PFA3DCheckFileFormat A3DCheckFileFormat = Marshal.GetDelegateForFunctionPointer<PFA3DCheckFileFormat>(Library.A3DGetProcAddress("A3DCheckFileFormat", 1));
        public delegate A3DStatus PFA3DExtractFileThumbnail([MarshalAs(UnmanagedType.LPStr)] string pcFileName, ref A3DThumbnailData pThumbnailData);
        public static PFA3DExtractFileThumbnail A3DExtractFileThumbnail = Marshal.GetDelegateForFunctionPointer<PFA3DExtractFileThumbnail>(Library.A3DGetProcAddress("A3DExtractFileThumbnail", 1));
        public delegate A3DStatus PFA3DGetFileInformation([MarshalAs(UnmanagedType.LPStr)] string pcFileName, ref A3DFileInformationData pFileInformationData);
        public static PFA3DGetFileInformation A3DGetFileInformation = Marshal.GetDelegateForFunctionPointer<PFA3DGetFileInformation>(Library.A3DGetProcAddress("A3DGetFileInformation", 1));
        public delegate A3DStatus PFA3DAsmGetFilesPathFromModelFile(IntPtr pA3DAsmModelFile, out uint uNbPartFiles, IntPtr ppPartFilesPaths, out uint uNbAssemblyFiles, IntPtr ppAssemblyFilesPaths, out uint uNbMissingFiles, IntPtr ppMissingFilesPaths);
        public static PFA3DAsmGetFilesPathFromModelFile A3DAsmGetFilesPathFromModelFile = Marshal.GetDelegateForFunctionPointer<PFA3DAsmGetFilesPathFromModelFile>(Library.A3DGetProcAddress("A3DAsmGetFilesPathFromModelFile", 1));
        public delegate A3DStatus PFA3DAsmGetFilesContextsFromModelFile(IntPtr pA3DAsmModelFile, out uint uNbFilesContexts, IntPtr ppFilesContexts);
        public static PFA3DAsmGetFilesContextsFromModelFile A3DAsmGetFilesContextsFromModelFile = Marshal.GetDelegateForFunctionPointer<PFA3DAsmGetFilesContextsFromModelFile>(Library.A3DGetProcAddress("A3DAsmGetFilesContextsFromModelFile", 1));
        public delegate A3DStatus PFA3DFileContextDelete(ref A3DFileContextData pData);
        public static PFA3DFileContextDelete A3DFileContextDelete = Marshal.GetDelegateForFunctionPointer<PFA3DFileContextDelete>(Library.A3DGetProcAddress("A3DFileContextDelete", 1));
        public delegate A3DStatus PFA3DAsmModelFileLoadFromPRCFiles([MarshalAs(UnmanagedType.LPStr)] string pcRootPrcFilePath, uint uNbFile, IntPtr ppPRCFilePath, IntPtr ppCADFilePath, ref A3DRWParamsLoadData pParamsLoadData, out IntPtr pA3DAsmModelFile);
        public static PFA3DAsmModelFileLoadFromPRCFiles A3DAsmModelFileLoadFromPRCFiles = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileLoadFromPRCFiles>(Library.A3DGetProcAddress("A3DAsmModelFileLoadFromPRCFiles", 1));
        public delegate A3DStatus PFA3DAsmModelFileLoadFromMultiplePrcFile([MarshalAs(UnmanagedType.LPStr)] string pcFileName, uint uNbPart, IntPtr ppCADFilePath, IntPtr ppPRCFilePath, ref A3DRWParamsLoadData pParamsLoadData, out IntPtr pA3DAsmModelFile);
        public static PFA3DAsmModelFileLoadFromMultiplePrcFile A3DAsmModelFileLoadFromMultiplePrcFile = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileLoadFromMultiplePrcFile>(Library.A3DGetProcAddress("A3DAsmModelFileLoadFromMultiplePrcFile", 1));
        public delegate A3DStatus PFA3DAsmModelFileExportToParasolidFile(IntPtr pA3DAsmModelFile, ref A3DRWParamsExportParasolidData pParamsExportData, [MarshalAs(UnmanagedType.LPStr)] string pcCADFileName);
        public static PFA3DAsmModelFileExportToParasolidFile A3DAsmModelFileExportToParasolidFile = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileExportToParasolidFile>(Library.A3DGetProcAddress("A3DAsmModelFileExportToParasolidFile", 1));
        public delegate A3DStatus PFA3DChainedBufferFree(ref A3DChainedBuffer pBuffer);
        public static PFA3DChainedBufferFree A3DChainedBufferFree = Marshal.GetDelegateForFunctionPointer<PFA3DChainedBufferFree>(Library.A3DGetProcAddress("A3DChainedBufferFree", 1));
        public delegate A3DStatus PFA3DAsmModelFileExportToParasolidBuffer(IntPtr pA3DAsmModelFile, ref A3DRWParamsExportParasolidData pParamsExportData, IntPtr pBuffer);
        public static PFA3DAsmModelFileExportToParasolidBuffer A3DAsmModelFileExportToParasolidBuffer = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileExportToParasolidBuffer>(Library.A3DGetProcAddress("A3DAsmModelFileExportToParasolidBuffer", 1));
        public delegate A3DStatus PFA3DRepresentationItemExportToParasolidFile(IntPtr pRepItem, [MarshalAs(UnmanagedType.LPStr)] string pcTempFileName, double dUnit);
        public static PFA3DRepresentationItemExportToParasolidFile A3DRepresentationItemExportToParasolidFile = Marshal.GetDelegateForFunctionPointer<PFA3DRepresentationItemExportToParasolidFile>(Library.A3DGetProcAddress("A3DRepresentationItemExportToParasolidFile", 1));
        public delegate A3DStatus PFA3DRepresentationItemExportToParasolidBuffer(IntPtr pRepItem, IntPtr pBuffer, double dUnit);
        public static PFA3DRepresentationItemExportToParasolidBuffer A3DRepresentationItemExportToParasolidBuffer = Marshal.GetDelegateForFunctionPointer<PFA3DRepresentationItemExportToParasolidBuffer>(Library.A3DGetProcAddress("A3DRepresentationItemExportToParasolidBuffer", 1));
        public delegate A3DStatus PFA3DAsmModelFileTranslateToPkParts(IntPtr pA3DAsmModelFile, ref A3DRWParamsExportParasolidData pParamsExportData, ref A3DRWParamsTranslateToPkPartsData pParamsTranslateToPkPartsData, IntPtr pNbPkParts, IntPtr pPkParts);
        public static PFA3DAsmModelFileTranslateToPkParts A3DAsmModelFileTranslateToPkParts = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileTranslateToPkParts>(Library.A3DGetProcAddress("A3DAsmModelFileTranslateToPkParts", 1));
        public delegate A3DStatus PFA3DRepresentationItemTranslateToPkParts(IntPtr pRepItem, ref A3DRWParamsTranslateToPkPartsData pParamsTranslateToPkPartsData, double dUnit, IntPtr pNbPkParts, IntPtr pPkParts);
        public static PFA3DRepresentationItemTranslateToPkParts A3DRepresentationItemTranslateToPkParts = Marshal.GetDelegateForFunctionPointer<PFA3DRepresentationItemTranslateToPkParts>(Library.A3DGetProcAddress("A3DRepresentationItemTranslateToPkParts", 1));
        public delegate A3DStatus PFA3DRepresentationItemsTranslateToPkPartsMultiProcess(uint uiNbProc, ref A3DRWParamsTranslateToPkPartsData pParamsTranslateToPkPartsData, uint uiNbRepItem, out IntPtr pRepItem, out double padUnit, IntPtr pNbPkParts, IntPtr pPkParts);
        public static PFA3DRepresentationItemsTranslateToPkPartsMultiProcess A3DRepresentationItemsTranslateToPkPartsMultiProcess = Marshal.GetDelegateForFunctionPointer<PFA3DRepresentationItemsTranslateToPkPartsMultiProcess>(Library.A3DGetProcAddress("A3DRepresentationItemsTranslateToPkPartsMultiProcess", 1));
        public delegate A3DStatus PFA3DHealPkParts(IntPtr pNbPkParts, IntPtr pPkParts, ref A3DRWParamsTranslateToPkPartsData pParamsTranslateToPkPartsData);
        public static PFA3DHealPkParts A3DHealPkParts = Marshal.GetDelegateForFunctionPointer<PFA3DHealPkParts>(Library.A3DGetProcAddress("A3DHealPkParts", 1));
        public delegate A3DStatus PFA3DMiscPKMapperGetPKEntitiesFromA3DEntity(IntPtr pMapper, IntPtr pA3DEntity, IntPtr piNbPKEntities, IntPtr ppPKEntities);
        public static PFA3DMiscPKMapperGetPKEntitiesFromA3DEntity A3DMiscPKMapperGetPKEntitiesFromA3DEntity = Marshal.GetDelegateForFunctionPointer<PFA3DMiscPKMapperGetPKEntitiesFromA3DEntity>(Library.A3DGetProcAddress("A3DMiscPKMapperGetPKEntitiesFromA3DEntity", 1));
        public delegate A3DStatus PFA3DMiscPKMapperGetA3DEntitiesFromPKEntity(IntPtr pMapper, int pPKEntity, IntPtr piNbA3DEntities, IntPtr ppA3DEntities);
        public static PFA3DMiscPKMapperGetA3DEntitiesFromPKEntity A3DMiscPKMapperGetA3DEntitiesFromPKEntity = Marshal.GetDelegateForFunctionPointer<PFA3DMiscPKMapperGetA3DEntitiesFromPKEntity>(Library.A3DGetProcAddress("A3DMiscPKMapperGetA3DEntitiesFromPKEntity", 1));
        public delegate A3DStatus PFA3DAsmModelFileExportToParasolidFileWithMapper(IntPtr pA3DAsmModelFile, IntPtr pMapper, ref A3DRWParamsExportParasolidData pParamsExportData, [MarshalAs(UnmanagedType.LPStr)] string pcCADFileName);
        public static PFA3DAsmModelFileExportToParasolidFileWithMapper A3DAsmModelFileExportToParasolidFileWithMapper = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileExportToParasolidFileWithMapper>(Library.A3DGetProcAddress("A3DAsmModelFileExportToParasolidFileWithMapper", 1));
        public delegate A3DStatus PFA3DPkPartsTranslateToA3DAsmModelFile(int pNbPkParts, IntPtr pPkParts, ref A3DRWParamsLoadData pLoadParam, out IntPtr ppA3DAsmModelFile, out IntPtr pMapper);
        public static PFA3DPkPartsTranslateToA3DAsmModelFile A3DPkPartsTranslateToA3DAsmModelFile = Marshal.GetDelegateForFunctionPointer<PFA3DPkPartsTranslateToA3DAsmModelFile>(Library.A3DGetProcAddress("A3DPkPartsTranslateToA3DAsmModelFile", 1));
        public delegate A3DStatus PFA3DAsmModelFileExportToParasolidBufferWithMapper(IntPtr pA3DAsmModelFile, IntPtr pMapper, ref A3DRWParamsExportParasolidData pParamsExportData, IntPtr pBuffer);
        public static PFA3DAsmModelFileExportToParasolidBufferWithMapper A3DAsmModelFileExportToParasolidBufferWithMapper = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileExportToParasolidBufferWithMapper>(Library.A3DGetProcAddress("A3DAsmModelFileExportToParasolidBufferWithMapper", 1));
        public delegate A3DStatus PFA3DAsmModelFileExportToPrcStream(IntPtr pA3DAsmModelFile, ref A3DRWParamsExportPrcData pParamsExportData, IntPtr pcStream, out uint uLength, out IntPtr ppPrcWriteHelper);
        public static PFA3DAsmModelFileExportToPrcStream A3DAsmModelFileExportToPrcStream = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileExportToPrcStream>(Library.A3DGetProcAddress("A3DAsmModelFileExportToPrcStream", 1));
        public delegate A3DStatus PFA3DAsmModelFileExportToAcisFile(IntPtr pA3DAsmModelFile, ref A3DRWParamsExportAcisData pParamsExportData, [MarshalAs(UnmanagedType.LPStr)] string pcCADFileName);
        public static PFA3DAsmModelFileExportToAcisFile A3DAsmModelFileExportToAcisFile = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileExportToAcisFile>(Library.A3DGetProcAddress("A3DAsmModelFileExportToAcisFile", 1));
        public delegate A3DStatus PFA3DAsmModelFileExportToAcisBuffer(IntPtr pA3DAsmModelFile, ref A3DRWParamsExportAcisData pParamsExportData, IntPtr pBuffer);
        public static PFA3DAsmModelFileExportToAcisBuffer A3DAsmModelFileExportToAcisBuffer = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileExportToAcisBuffer>(Library.A3DGetProcAddress("A3DAsmModelFileExportToAcisBuffer", 1));
        public delegate A3DStatus PFA3DRepresentationItemExportToAcisBuffer(IntPtr pRepItem, IntPtr pBuffer, double dScale);
        public static PFA3DRepresentationItemExportToAcisBuffer A3DRepresentationItemExportToAcisBuffer = Marshal.GetDelegateForFunctionPointer<PFA3DRepresentationItemExportToAcisBuffer>(Library.A3DGetProcAddress("A3DRepresentationItemExportToAcisBuffer", 1));
        public delegate A3DStatus PFA3DAsmModelFileLoadFromXMLFile([MarshalAs(UnmanagedType.LPStr)] string pcFileName, ref A3DRWParamsLoadData pLoadParametersData, out IntPtr ppModelFile);
        public static PFA3DAsmModelFileLoadFromXMLFile A3DAsmModelFileLoadFromXMLFile = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileLoadFromXMLFile>(Library.A3DGetProcAddress("A3DAsmModelFileLoadFromXMLFile", 1));
        public delegate A3DStatus PFA3DAsmModelFileLoadFromXMLStream([MarshalAs(UnmanagedType.LPStr)] string pcBuffer, ref A3DRWParamsLoadData pLoadParametersData, out IntPtr ppModelFile);
        public static PFA3DAsmModelFileLoadFromXMLStream A3DAsmModelFileLoadFromXMLStream = Marshal.GetDelegateForFunctionPointer<PFA3DAsmModelFileLoadFromXMLStream>(Library.A3DGetProcAddress("A3DAsmModelFileLoadFromXMLStream", 1));
        public delegate A3DStatus PFA3DRiRepresentationItemGet(IntPtr pRi, ref A3DRiRepresentationItemData pData);
        public static PFA3DRiRepresentationItemGet A3DRiRepresentationItemGet = Marshal.GetDelegateForFunctionPointer<PFA3DRiRepresentationItemGet>(Library.A3DGetProcAddress("A3DRiRepresentationItemGet", 1));
        public delegate A3DStatus PFA3DRiRepresentationItemSet(IntPtr pRi, ref A3DRiRepresentationItemData pData);
        public static PFA3DRiRepresentationItemSet A3DRiRepresentationItemSet = Marshal.GetDelegateForFunctionPointer<PFA3DRiRepresentationItemSet>(Library.A3DGetProcAddress("A3DRiRepresentationItemSet", 1));
        public delegate A3DStatus PFA3DRiRepresentationItemDeepCopy(IntPtr pRi, out IntPtr ppNewRi);
        public static PFA3DRiRepresentationItemDeepCopy A3DRiRepresentationItemDeepCopy = Marshal.GetDelegateForFunctionPointer<PFA3DRiRepresentationItemDeepCopy>(Library.A3DGetProcAddress("A3DRiRepresentationItemDeepCopy", 1));
        public delegate A3DStatus PFA3DRiRepresentationItemComputeTessellation(IntPtr pRi, ref A3DRWParamsTessellationData pTessellationParametersData);
        public static PFA3DRiRepresentationItemComputeTessellation A3DRiRepresentationItemComputeTessellation = Marshal.GetDelegateForFunctionPointer<PFA3DRiRepresentationItemComputeTessellation>(Library.A3DGetProcAddress("A3DRiRepresentationItemComputeTessellation", 1));
        public delegate A3DStatus PFA3DRiReleaseTessellation(IntPtr pRepresentationItem);
        public static PFA3DRiReleaseTessellation A3DRiReleaseTessellation = Marshal.GetDelegateForFunctionPointer<PFA3DRiReleaseTessellation>(Library.A3DGetProcAddress("A3DRiReleaseTessellation", 1));
        public delegate A3DStatus PFA3DRiRepresentationItemEditCoordinateSystem(IntPtr pNewCoordinateSystem, IntPtr pRepresentationItem);
        public static PFA3DRiRepresentationItemEditCoordinateSystem A3DRiRepresentationItemEditCoordinateSystem = Marshal.GetDelegateForFunctionPointer<PFA3DRiRepresentationItemEditCoordinateSystem>(Library.A3DGetProcAddress("A3DRiRepresentationItemEditCoordinateSystem", 1));
        public delegate A3DStatus PFA3DRiSetGet(IntPtr pSet, ref A3DRiSetData pData);
        public static PFA3DRiSetGet A3DRiSetGet = Marshal.GetDelegateForFunctionPointer<PFA3DRiSetGet>(Library.A3DGetProcAddress("A3DRiSetGet", 1));
        public delegate A3DStatus PFA3DRiSetCreate(ref A3DRiSetData pData, out IntPtr ppSet);
        public static PFA3DRiSetCreate A3DRiSetCreate = Marshal.GetDelegateForFunctionPointer<PFA3DRiSetCreate>(Library.A3DGetProcAddress("A3DRiSetCreate", 1));
        public delegate A3DStatus PFA3DRiSetEdit(ref A3DRiSetData pData, IntPtr pSet);
        public static PFA3DRiSetEdit A3DRiSetEdit = Marshal.GetDelegateForFunctionPointer<PFA3DRiSetEdit>(Library.A3DGetProcAddress("A3DRiSetEdit", 1));
        public delegate A3DStatus PFA3DRiPointSetGet(IntPtr pPointSet, ref A3DRiPointSetData pData);
        public static PFA3DRiPointSetGet A3DRiPointSetGet = Marshal.GetDelegateForFunctionPointer<PFA3DRiPointSetGet>(Library.A3DGetProcAddress("A3DRiPointSetGet", 1));
        public delegate A3DStatus PFA3DRiPointSetCreate(ref A3DRiPointSetData pData, out IntPtr ppPointSet);
        public static PFA3DRiPointSetCreate A3DRiPointSetCreate = Marshal.GetDelegateForFunctionPointer<PFA3DRiPointSetCreate>(Library.A3DGetProcAddress("A3DRiPointSetCreate", 1));
        public delegate A3DStatus PFA3DRiPointSetEdit(ref A3DRiPointSetData pData, IntPtr pPointSet);
        public static PFA3DRiPointSetEdit A3DRiPointSetEdit = Marshal.GetDelegateForFunctionPointer<PFA3DRiPointSetEdit>(Library.A3DGetProcAddress("A3DRiPointSetEdit", 1));
        public delegate A3DStatus PFA3DRiDirectionGet(IntPtr pDirection, ref A3DRiDirectionData pData);
        public static PFA3DRiDirectionGet A3DRiDirectionGet = Marshal.GetDelegateForFunctionPointer<PFA3DRiDirectionGet>(Library.A3DGetProcAddress("A3DRiDirectionGet", 1));
        public delegate A3DStatus PFA3DRiDirectionCreate(ref A3DRiDirectionData pData, out IntPtr ppDirection);
        public static PFA3DRiDirectionCreate A3DRiDirectionCreate = Marshal.GetDelegateForFunctionPointer<PFA3DRiDirectionCreate>(Library.A3DGetProcAddress("A3DRiDirectionCreate", 1));
        public delegate A3DStatus PFA3DRiDirectionEdit(ref A3DRiDirectionData pData, IntPtr pDirection);
        public static PFA3DRiDirectionEdit A3DRiDirectionEdit = Marshal.GetDelegateForFunctionPointer<PFA3DRiDirectionEdit>(Library.A3DGetProcAddress("A3DRiDirectionEdit", 1));
        public delegate A3DStatus PFA3DRiCoordinateSystemGet(IntPtr pCoordinateSystem, ref A3DRiCoordinateSystemData pData);
        public static PFA3DRiCoordinateSystemGet A3DRiCoordinateSystemGet = Marshal.GetDelegateForFunctionPointer<PFA3DRiCoordinateSystemGet>(Library.A3DGetProcAddress("A3DRiCoordinateSystemGet", 1));
        public delegate A3DStatus PFA3DRiCoordinateSystemCreate(ref A3DRiCoordinateSystemData pData, out IntPtr ppCoordinateSystem);
        public static PFA3DRiCoordinateSystemCreate A3DRiCoordinateSystemCreate = Marshal.GetDelegateForFunctionPointer<PFA3DRiCoordinateSystemCreate>(Library.A3DGetProcAddress("A3DRiCoordinateSystemCreate", 1));
        public delegate A3DStatus PFA3DRiCoordinateSystemEdit(ref A3DRiCoordinateSystemData pData, IntPtr pCoordinateSystem);
        public static PFA3DRiCoordinateSystemEdit A3DRiCoordinateSystemEdit = Marshal.GetDelegateForFunctionPointer<PFA3DRiCoordinateSystemEdit>(Library.A3DGetProcAddress("A3DRiCoordinateSystemEdit", 1));
        public delegate A3DStatus PFA3DRiCurveGet(IntPtr pRICrv, ref A3DRiCurveData pData);
        public static PFA3DRiCurveGet A3DRiCurveGet = Marshal.GetDelegateForFunctionPointer<PFA3DRiCurveGet>(Library.A3DGetProcAddress("A3DRiCurveGet", 1));
        public delegate A3DStatus PFA3DRiCurveCreate(ref A3DRiCurveData pData, out IntPtr ppRICrv);
        public static PFA3DRiCurveCreate A3DRiCurveCreate = Marshal.GetDelegateForFunctionPointer<PFA3DRiCurveCreate>(Library.A3DGetProcAddress("A3DRiCurveCreate", 1));
        public delegate A3DStatus PFA3DRiCurveEdit(ref A3DRiCurveData pData, IntPtr pRICrv);
        public static PFA3DRiCurveEdit A3DRiCurveEdit = Marshal.GetDelegateForFunctionPointer<PFA3DRiCurveEdit>(Library.A3DGetProcAddress("A3DRiCurveEdit", 1));
        public delegate A3DStatus PFA3DRiCurveSupportGet(IntPtr pRiCurve, out IntPtr ppLinkedItem);
        public static PFA3DRiCurveSupportGet A3DRiCurveSupportGet = Marshal.GetDelegateForFunctionPointer<PFA3DRiCurveSupportGet>(Library.A3DGetProcAddress("A3DRiCurveSupportGet", 1));
        public delegate A3DStatus PFA3DRiPlaneGet(IntPtr pRiPlane, ref A3DRiPlaneData pData);
        public static PFA3DRiPlaneGet A3DRiPlaneGet = Marshal.GetDelegateForFunctionPointer<PFA3DRiPlaneGet>(Library.A3DGetProcAddress("A3DRiPlaneGet", 1));
        public delegate A3DStatus PFA3DRiPlaneCreate(ref A3DRiPlaneData pData, out IntPtr ppRIPlane);
        public static PFA3DRiPlaneCreate A3DRiPlaneCreate = Marshal.GetDelegateForFunctionPointer<PFA3DRiPlaneCreate>(Library.A3DGetProcAddress("A3DRiPlaneCreate", 1));
        public delegate A3DStatus PFA3DRiPlaneEdit(ref A3DRiPlaneData pData, IntPtr pRIPlane);
        public static PFA3DRiPlaneEdit A3DRiPlaneEdit = Marshal.GetDelegateForFunctionPointer<PFA3DRiPlaneEdit>(Library.A3DGetProcAddress("A3DRiPlaneEdit", 1));
        public delegate A3DStatus PFA3DRiPlaneSupportGet(IntPtr pRiPlane, out IntPtr ppLinkedItem);
        public static PFA3DRiPlaneSupportGet A3DRiPlaneSupportGet = Marshal.GetDelegateForFunctionPointer<PFA3DRiPlaneSupportGet>(Library.A3DGetProcAddress("A3DRiPlaneSupportGet", 1));
        public delegate A3DStatus PFA3DRiBrepModelGet(IntPtr pRIBrepModel, ref A3DRiBrepModelData pData);
        public static PFA3DRiBrepModelGet A3DRiBrepModelGet = Marshal.GetDelegateForFunctionPointer<PFA3DRiBrepModelGet>(Library.A3DGetProcAddress("A3DRiBrepModelGet", 1));
        public delegate A3DStatus PFA3DRiBrepModelCreate(ref A3DRiBrepModelData pData, out IntPtr ppRIBrepModel);
        public static PFA3DRiBrepModelCreate A3DRiBrepModelCreate = Marshal.GetDelegateForFunctionPointer<PFA3DRiBrepModelCreate>(Library.A3DGetProcAddress("A3DRiBrepModelCreate", 1));
        public delegate A3DStatus PFA3DRiBrepModelEdit(ref A3DRiBrepModelData pData, IntPtr pRIBrepModel);
        public static PFA3DRiBrepModelEdit A3DRiBrepModelEdit = Marshal.GetDelegateForFunctionPointer<PFA3DRiBrepModelEdit>(Library.A3DGetProcAddress("A3DRiBrepModelEdit", 1));
        public delegate A3DStatus PFA3DRiPolyBrepModelGet(IntPtr pRIPolyBrepModel, ref A3DRiPolyBrepModelData pData);
        public static PFA3DRiPolyBrepModelGet A3DRiPolyBrepModelGet = Marshal.GetDelegateForFunctionPointer<PFA3DRiPolyBrepModelGet>(Library.A3DGetProcAddress("A3DRiPolyBrepModelGet", 1));
        public delegate A3DStatus PFA3DRiPolyBrepModelCreate(ref A3DRiPolyBrepModelData pData, out IntPtr ppRIPolyBrepModel);
        public static PFA3DRiPolyBrepModelCreate A3DRiPolyBrepModelCreate = Marshal.GetDelegateForFunctionPointer<PFA3DRiPolyBrepModelCreate>(Library.A3DGetProcAddress("A3DRiPolyBrepModelCreate", 1));
        public delegate A3DStatus PFA3DRiPolyBrepModelEdit(ref A3DRiPolyBrepModelData pData, IntPtr pRIPolyBrepModel);
        public static PFA3DRiPolyBrepModelEdit A3DRiPolyBrepModelEdit = Marshal.GetDelegateForFunctionPointer<PFA3DRiPolyBrepModelEdit>(Library.A3DGetProcAddress("A3DRiPolyBrepModelEdit", 1));
        public delegate A3DStatus PFA3DRiPolyWireGet(IntPtr pRIPolyWire, ref A3DRiPolyWireData pData);
        public static PFA3DRiPolyWireGet A3DRiPolyWireGet = Marshal.GetDelegateForFunctionPointer<PFA3DRiPolyWireGet>(Library.A3DGetProcAddress("A3DRiPolyWireGet", 1));
        public delegate A3DStatus PFA3DRiPolyWireCreate(ref A3DRiPolyWireData pData, out IntPtr ppRIPolyWire);
        public static PFA3DRiPolyWireCreate A3DRiPolyWireCreate = Marshal.GetDelegateForFunctionPointer<PFA3DRiPolyWireCreate>(Library.A3DGetProcAddress("A3DRiPolyWireCreate", 1));
        public delegate A3DStatus PFA3DFRMFeatureTreeGet(IntPtr pTree, ref A3DFRMFeatureTreeData pData);
        public static PFA3DFRMFeatureTreeGet A3DFRMFeatureTreeGet = Marshal.GetDelegateForFunctionPointer<PFA3DFRMFeatureTreeGet>(Library.A3DGetProcAddress("A3DFRMFeatureTreeGet", 1));
        public delegate A3DStatus PFA3DFRMParameterGet(IntPtr pParameter, ref A3DFRMParameterData pData);
        public static PFA3DFRMParameterGet A3DFRMParameterGet = Marshal.GetDelegateForFunctionPointer<PFA3DFRMParameterGet>(Library.A3DGetProcAddress("A3DFRMParameterGet", 1));
        public delegate A3DStatus PFA3DFRMStringDataGet(IntPtr pFeature, ref A3DFRMStringData pData);
        public static PFA3DFRMStringDataGet A3DFRMStringDataGet = Marshal.GetDelegateForFunctionPointer<PFA3DFRMStringDataGet>(Library.A3DGetProcAddress("A3DFRMStringDataGet", 1));
        public delegate A3DStatus PFA3DFRMDoubleDataGet(IntPtr pFeature, ref A3DFRMDoubleData pData);
        public static PFA3DFRMDoubleDataGet A3DFRMDoubleDataGet = Marshal.GetDelegateForFunctionPointer<PFA3DFRMDoubleDataGet>(Library.A3DGetProcAddress("A3DFRMDoubleDataGet", 1));
        public delegate A3DStatus PFA3DFRMIntegerDataGet(IntPtr pFeature, ref A3DFRMIntegerData pData);
        public static PFA3DFRMIntegerDataGet A3DFRMIntegerDataGet = Marshal.GetDelegateForFunctionPointer<PFA3DFRMIntegerDataGet>(Library.A3DGetProcAddress("A3DFRMIntegerDataGet", 1));
        public delegate A3DStatus PFA3DFRMEnumDataGet(IntPtr pFeature, out int m_piEnumValue, IntPtr ppcValueAsString);
        public static PFA3DFRMEnumDataGet A3DFRMEnumDataGet = Marshal.GetDelegateForFunctionPointer<PFA3DFRMEnumDataGet>(Library.A3DGetProcAddress("A3DFRMEnumDataGet", 1));
        public delegate A3DStatus PFA3DFRMFeatureLinkedItemGet(IntPtr p, ref A3DFRMFeatureLinkedItemData pData);
        public static PFA3DFRMFeatureLinkedItemGet A3DFRMFeatureLinkedItemGet = Marshal.GetDelegateForFunctionPointer<PFA3DFRMFeatureLinkedItemGet>(Library.A3DGetProcAddress("A3DFRMFeatureLinkedItemGet", 1));
        public delegate A3DStatus PFA3DFRMFeatureGet(IntPtr pFeature, ref A3DFRMFeatureData pData);
        public static PFA3DFRMFeatureGet A3DFRMFeatureGet = Marshal.GetDelegateForFunctionPointer<PFA3DFRMFeatureGet>(Library.A3DGetProcAddress("A3DFRMFeatureGet", 1));
        public delegate A3DStatus PFA3DFRMFeatureGetTypeAsString(IntPtr pFeature, IntPtr ppcFeatureType);
        public static PFA3DFRMFeatureGetTypeAsString A3DFRMFeatureGetTypeAsString = Marshal.GetDelegateForFunctionPointer<PFA3DFRMFeatureGetTypeAsString>(Library.A3DGetProcAddress("A3DFRMFeatureGetTypeAsString", 1));
        public delegate A3DStatus PFA3DFRMGetSpecificNodes(IntPtr pTree, EA3DFRMEnumValue_CadType eCADType, out uint piSize, IntPtr pppFeatureNodes);
        public static PFA3DFRMGetSpecificNodes A3DFRMGetSpecificNodes = Marshal.GetDelegateForFunctionPointer<PFA3DFRMGetSpecificNodes>(Library.A3DGetProcAddress("A3DFRMGetSpecificNodes", 1));
        public delegate A3DStatus PFA3DAsmPartDefinitionFeatureTreesGet(IntPtr pPartDefinition, out uint puiSize, IntPtr pppFeatureTrees);
        public static PFA3DAsmPartDefinitionFeatureTreesGet A3DAsmPartDefinitionFeatureTreesGet = Marshal.GetDelegateForFunctionPointer<PFA3DAsmPartDefinitionFeatureTreesGet>(Library.A3DGetProcAddress("A3DAsmPartDefinitionFeatureTreesGet", 1));
        public delegate A3DStatus PFA3DFRMFeatureGeomEntitiesExtract(IntPtr pFeature, ref A3DFRMFeatureGeomEntitiesData pFeatureGeomEntities);
        public static PFA3DFRMFeatureGeomEntitiesExtract A3DFRMFeatureGeomEntitiesExtract = Marshal.GetDelegateForFunctionPointer<PFA3DFRMFeatureGeomEntitiesExtract>(Library.A3DGetProcAddress("A3DFRMFeatureGeomEntitiesExtract", 1));
        public delegate A3DStatus PFA3DCrvNurbsGet(IntPtr pCrv, ref A3DCrvNurbsData pData);
        public static PFA3DCrvNurbsGet A3DCrvNurbsGet = Marshal.GetDelegateForFunctionPointer<PFA3DCrvNurbsGet>(Library.A3DGetProcAddress("A3DCrvNurbsGet", 1));
        public delegate A3DStatus PFA3DCrvNurbsCreate(ref A3DCrvNurbsData pData, out IntPtr ppCrv);
        public static PFA3DCrvNurbsCreate A3DCrvNurbsCreate = Marshal.GetDelegateForFunctionPointer<PFA3DCrvNurbsCreate>(Library.A3DGetProcAddress("A3DCrvNurbsCreate", 1));
        public delegate A3DStatus PFA3DCrvBaseGetAsNurbs(IntPtr pCrv, double dTolerance, bool bUseSameParameterization, ref A3DCrvNurbsData pData);
        public static PFA3DCrvBaseGetAsNurbs A3DCrvBaseGetAsNurbs = Marshal.GetDelegateForFunctionPointer<PFA3DCrvBaseGetAsNurbs>(Library.A3DGetProcAddress("A3DCrvBaseGetAsNurbs", 1));
        public delegate A3DStatus PFA3DCrvLineGet(IntPtr pCrv, ref A3DCrvLineData pData);
        public static PFA3DCrvLineGet A3DCrvLineGet = Marshal.GetDelegateForFunctionPointer<PFA3DCrvLineGet>(Library.A3DGetProcAddress("A3DCrvLineGet", 1));
        public delegate A3DStatus PFA3DCrvLineCreate(ref A3DCrvLineData pData, out IntPtr ppCrv);
        public static PFA3DCrvLineCreate A3DCrvLineCreate = Marshal.GetDelegateForFunctionPointer<PFA3DCrvLineCreate>(Library.A3DGetProcAddress("A3DCrvLineCreate", 1));
        public delegate A3DStatus PFA3DCrvCircleGet(IntPtr pCrv, ref A3DCrvCircleData pData);
        public static PFA3DCrvCircleGet A3DCrvCircleGet = Marshal.GetDelegateForFunctionPointer<PFA3DCrvCircleGet>(Library.A3DGetProcAddress("A3DCrvCircleGet", 1));
        public delegate A3DStatus PFA3DCrvCircleCreate(ref A3DCrvCircleData pData, out IntPtr ppCrv);
        public static PFA3DCrvCircleCreate A3DCrvCircleCreate = Marshal.GetDelegateForFunctionPointer<PFA3DCrvCircleCreate>(Library.A3DGetProcAddress("A3DCrvCircleCreate", 1));
        public delegate A3DStatus PFA3DCrvEllipseGet(IntPtr pCrv, ref A3DCrvEllipseData pData);
        public static PFA3DCrvEllipseGet A3DCrvEllipseGet = Marshal.GetDelegateForFunctionPointer<PFA3DCrvEllipseGet>(Library.A3DGetProcAddress("A3DCrvEllipseGet", 1));
        public delegate A3DStatus PFA3DCrvEllipseCreate(ref A3DCrvEllipseData pData, out IntPtr ppCrv);
        public static PFA3DCrvEllipseCreate A3DCrvEllipseCreate = Marshal.GetDelegateForFunctionPointer<PFA3DCrvEllipseCreate>(Library.A3DGetProcAddress("A3DCrvEllipseCreate", 1));
        public delegate A3DStatus PFA3DCrvParabolaGet(IntPtr pCrv, ref A3DCrvParabolaData pData);
        public static PFA3DCrvParabolaGet A3DCrvParabolaGet = Marshal.GetDelegateForFunctionPointer<PFA3DCrvParabolaGet>(Library.A3DGetProcAddress("A3DCrvParabolaGet", 1));
        public delegate A3DStatus PFA3DCrvParabolaCreate(ref A3DCrvParabolaData pData, out IntPtr ppCrv);
        public static PFA3DCrvParabolaCreate A3DCrvParabolaCreate = Marshal.GetDelegateForFunctionPointer<PFA3DCrvParabolaCreate>(Library.A3DGetProcAddress("A3DCrvParabolaCreate", 1));
        public delegate A3DStatus PFA3DCrvHyperbolaGet(IntPtr pCrv, ref A3DCrvHyperbolaData pData);
        public static PFA3DCrvHyperbolaGet A3DCrvHyperbolaGet = Marshal.GetDelegateForFunctionPointer<PFA3DCrvHyperbolaGet>(Library.A3DGetProcAddress("A3DCrvHyperbolaGet", 1));
        public delegate A3DStatus PFA3DCrvHyperbolaCreate(ref A3DCrvHyperbolaData pData, out IntPtr ppCrv);
        public static PFA3DCrvHyperbolaCreate A3DCrvHyperbolaCreate = Marshal.GetDelegateForFunctionPointer<PFA3DCrvHyperbolaCreate>(Library.A3DGetProcAddress("A3DCrvHyperbolaCreate", 1));
        public delegate A3DStatus PFA3DCrvPolyLineGet(IntPtr pCrv, ref A3DCrvPolyLineData pData);
        public static PFA3DCrvPolyLineGet A3DCrvPolyLineGet = Marshal.GetDelegateForFunctionPointer<PFA3DCrvPolyLineGet>(Library.A3DGetProcAddress("A3DCrvPolyLineGet", 1));
        public delegate A3DStatus PFA3DCrvPolyLineCreate(ref A3DCrvPolyLineData pData, out IntPtr ppCrv);
        public static PFA3DCrvPolyLineCreate A3DCrvPolyLineCreate = Marshal.GetDelegateForFunctionPointer<PFA3DCrvPolyLineCreate>(Library.A3DGetProcAddress("A3DCrvPolyLineCreate", 1));
        public delegate A3DStatus PFA3DCrvCompositeGet(IntPtr pCrv, ref A3DCrvCompositeData pData);
        public static PFA3DCrvCompositeGet A3DCrvCompositeGet = Marshal.GetDelegateForFunctionPointer<PFA3DCrvCompositeGet>(Library.A3DGetProcAddress("A3DCrvCompositeGet", 1));
        public delegate A3DStatus PFA3DCrvCompositeCreate(ref A3DCrvCompositeData pData, out IntPtr ppCrv);
        public static PFA3DCrvCompositeCreate A3DCrvCompositeCreate = Marshal.GetDelegateForFunctionPointer<PFA3DCrvCompositeCreate>(Library.A3DGetProcAddress("A3DCrvCompositeCreate", 1));
        public delegate A3DStatus PFA3DCrvEquationGet(IntPtr pCrv, ref A3DCrvEquationData pData);
        public static PFA3DCrvEquationGet A3DCrvEquationGet = Marshal.GetDelegateForFunctionPointer<PFA3DCrvEquationGet>(Library.A3DGetProcAddress("A3DCrvEquationGet", 1));
        public delegate A3DStatus PFA3DCrvEquationCreate(ref A3DCrvEquationData pData, out IntPtr ppCrv);
        public static PFA3DCrvEquationCreate A3DCrvEquationCreate = Marshal.GetDelegateForFunctionPointer<PFA3DCrvEquationCreate>(Library.A3DGetProcAddress("A3DCrvEquationCreate", 1));
        public delegate A3DStatus PFA3DCrvTransformGet(IntPtr pCrv, ref A3DCrvTransformData pData);
        public static PFA3DCrvTransformGet A3DCrvTransformGet = Marshal.GetDelegateForFunctionPointer<PFA3DCrvTransformGet>(Library.A3DGetProcAddress("A3DCrvTransformGet", 1));
        public delegate A3DStatus PFA3DCrvTransformCreate(ref A3DCrvTransformData pData, out IntPtr ppCrv);
        public static PFA3DCrvTransformCreate A3DCrvTransformCreate = Marshal.GetDelegateForFunctionPointer<PFA3DCrvTransformCreate>(Library.A3DGetProcAddress("A3DCrvTransformCreate", 1));
        public delegate A3DStatus PFA3DCrvOnSurfGet(IntPtr pCrv, ref A3DCrvOnSurfData pData);
        public static PFA3DCrvOnSurfGet A3DCrvOnSurfGet = Marshal.GetDelegateForFunctionPointer<PFA3DCrvOnSurfGet>(Library.A3DGetProcAddress("A3DCrvOnSurfGet", 1));
        public delegate A3DStatus PFA3DCrvOnSurfCreate(ref A3DCrvOnSurfData pData, out IntPtr ppCrv);
        public static PFA3DCrvOnSurfCreate A3DCrvOnSurfCreate = Marshal.GetDelegateForFunctionPointer<PFA3DCrvOnSurfCreate>(Library.A3DGetProcAddress("A3DCrvOnSurfCreate", 1));
        public delegate A3DStatus PFA3DCrvOffsetGet(IntPtr pCrv, ref A3DCrvOffsetData pData);
        public static PFA3DCrvOffsetGet A3DCrvOffsetGet = Marshal.GetDelegateForFunctionPointer<PFA3DCrvOffsetGet>(Library.A3DGetProcAddress("A3DCrvOffsetGet", 1));
        public delegate A3DStatus PFA3DCrvOffsetCreate(ref A3DCrvOffsetData pData, out IntPtr ppCrv);
        public static PFA3DCrvOffsetCreate A3DCrvOffsetCreate = Marshal.GetDelegateForFunctionPointer<PFA3DCrvOffsetCreate>(Library.A3DGetProcAddress("A3DCrvOffsetCreate", 1));
        public delegate A3DStatus PFA3DCrvHelixGet(IntPtr pCrv, ref A3DCrvHelixData pData);
        public static PFA3DCrvHelixGet A3DCrvHelixGet = Marshal.GetDelegateForFunctionPointer<PFA3DCrvHelixGet>(Library.A3DGetProcAddress("A3DCrvHelixGet", 1));
        public delegate A3DStatus PFA3DCrvHelixCreate(ref A3DCrvHelixData pData, out IntPtr ppCrv);
        public static PFA3DCrvHelixCreate A3DCrvHelixCreate = Marshal.GetDelegateForFunctionPointer<PFA3DCrvHelixCreate>(Library.A3DGetProcAddress("A3DCrvHelixCreate", 1));
        public delegate A3DStatus PFA3DCrvIntersectionGet(IntPtr pCrv, ref A3DCrvIntersectionData pData);
        public static PFA3DCrvIntersectionGet A3DCrvIntersectionGet = Marshal.GetDelegateForFunctionPointer<PFA3DCrvIntersectionGet>(Library.A3DGetProcAddress("A3DCrvIntersectionGet", 1));
        public delegate A3DStatus PFA3DCrvIntersectionCreate(ref A3DCrvIntersectionData pData, out IntPtr ppCrv);
        public static PFA3DCrvIntersectionCreate A3DCrvIntersectionCreate = Marshal.GetDelegateForFunctionPointer<PFA3DCrvIntersectionCreate>(Library.A3DGetProcAddress("A3DCrvIntersectionCreate", 1));
        public delegate A3DStatus PFA3DCrvBlend02BoundaryGet(IntPtr pCrv, ref A3DCrvBlend02BoundaryData pData);
        public static PFA3DCrvBlend02BoundaryGet A3DCrvBlend02BoundaryGet = Marshal.GetDelegateForFunctionPointer<PFA3DCrvBlend02BoundaryGet>(Library.A3DGetProcAddress("A3DCrvBlend02BoundaryGet", 1));
        public delegate A3DStatus PFA3DCrvBlend02BoundaryCreate(ref A3DCrvBlend02BoundaryData pData, out IntPtr ppCrv);
        public static PFA3DCrvBlend02BoundaryCreate A3DCrvBlend02BoundaryCreate = Marshal.GetDelegateForFunctionPointer<PFA3DCrvBlend02BoundaryCreate>(Library.A3DGetProcAddress("A3DCrvBlend02BoundaryCreate", 1));
        public delegate A3DStatus PFA3DSurfNurbsGet(IntPtr pSrf, ref A3DSurfNurbsData pData);
        public static PFA3DSurfNurbsGet A3DSurfNurbsGet = Marshal.GetDelegateForFunctionPointer<PFA3DSurfNurbsGet>(Library.A3DGetProcAddress("A3DSurfNurbsGet", 1));
        public delegate A3DStatus PFA3DSurfNurbsCreate(ref A3DSurfNurbsData pData, out IntPtr ppSrf);
        public static PFA3DSurfNurbsCreate A3DSurfNurbsCreate = Marshal.GetDelegateForFunctionPointer<PFA3DSurfNurbsCreate>(Library.A3DGetProcAddress("A3DSurfNurbsCreate", 1));
        public delegate A3DStatus PFA3DSurfBaseGetAsNurbs(IntPtr pSrf, double dTolerance, bool bUseSameParameterization, ref A3DSurfNurbsData pData);
        public static PFA3DSurfBaseGetAsNurbs A3DSurfBaseGetAsNurbs = Marshal.GetDelegateForFunctionPointer<PFA3DSurfBaseGetAsNurbs>(Library.A3DGetProcAddress("A3DSurfBaseGetAsNurbs", 1));
        public delegate A3DStatus PFA3DSurfSphereGet(IntPtr pSrf, ref A3DSurfSphereData pData);
        public static PFA3DSurfSphereGet A3DSurfSphereGet = Marshal.GetDelegateForFunctionPointer<PFA3DSurfSphereGet>(Library.A3DGetProcAddress("A3DSurfSphereGet", 1));
        public delegate A3DStatus PFA3DSurfSphereCreate(ref A3DSurfSphereData pData, out IntPtr ppSrf);
        public static PFA3DSurfSphereCreate A3DSurfSphereCreate = Marshal.GetDelegateForFunctionPointer<PFA3DSurfSphereCreate>(Library.A3DGetProcAddress("A3DSurfSphereCreate", 1));
        public delegate A3DStatus PFA3DSurfCylinderGet(IntPtr pSrf, ref A3DSurfCylinderData pData);
        public static PFA3DSurfCylinderGet A3DSurfCylinderGet = Marshal.GetDelegateForFunctionPointer<PFA3DSurfCylinderGet>(Library.A3DGetProcAddress("A3DSurfCylinderGet", 1));
        public delegate A3DStatus PFA3DSurfCylinderCreate(ref A3DSurfCylinderData pData, out IntPtr ppSrf);
        public static PFA3DSurfCylinderCreate A3DSurfCylinderCreate = Marshal.GetDelegateForFunctionPointer<PFA3DSurfCylinderCreate>(Library.A3DGetProcAddress("A3DSurfCylinderCreate", 1));
        public delegate A3DStatus PFA3DSurfTorusGet(IntPtr pSrf, ref A3DSurfTorusData pData);
        public static PFA3DSurfTorusGet A3DSurfTorusGet = Marshal.GetDelegateForFunctionPointer<PFA3DSurfTorusGet>(Library.A3DGetProcAddress("A3DSurfTorusGet", 1));
        public delegate A3DStatus PFA3DSurfTorusCreate(ref A3DSurfTorusData pData, out IntPtr ppSrf);
        public static PFA3DSurfTorusCreate A3DSurfTorusCreate = Marshal.GetDelegateForFunctionPointer<PFA3DSurfTorusCreate>(Library.A3DGetProcAddress("A3DSurfTorusCreate", 1));
        public delegate A3DStatus PFA3DSurfRevolutionGet(IntPtr pSrf, ref A3DSurfRevolutionData pData);
        public static PFA3DSurfRevolutionGet A3DSurfRevolutionGet = Marshal.GetDelegateForFunctionPointer<PFA3DSurfRevolutionGet>(Library.A3DGetProcAddress("A3DSurfRevolutionGet", 1));
        public delegate A3DStatus PFA3DSurfRevolutionCreate(ref A3DSurfRevolutionData pData, out IntPtr ppSrf);
        public static PFA3DSurfRevolutionCreate A3DSurfRevolutionCreate = Marshal.GetDelegateForFunctionPointer<PFA3DSurfRevolutionCreate>(Library.A3DGetProcAddress("A3DSurfRevolutionCreate", 1));
        public delegate A3DStatus PFA3DSurfExtrusionGet(IntPtr pSrf, ref A3DSurfExtrusionData pData);
        public static PFA3DSurfExtrusionGet A3DSurfExtrusionGet = Marshal.GetDelegateForFunctionPointer<PFA3DSurfExtrusionGet>(Library.A3DGetProcAddress("A3DSurfExtrusionGet", 1));
        public delegate A3DStatus PFA3DSurfExtrusionCreate(ref A3DSurfExtrusionData pData, out IntPtr ppSrf);
        public static PFA3DSurfExtrusionCreate A3DSurfExtrusionCreate = Marshal.GetDelegateForFunctionPointer<PFA3DSurfExtrusionCreate>(Library.A3DGetProcAddress("A3DSurfExtrusionCreate", 1));
        public delegate A3DStatus PFA3DSurfOffsetGet(IntPtr pSrf, ref A3DSurfOffsetData pData);
        public static PFA3DSurfOffsetGet A3DSurfOffsetGet = Marshal.GetDelegateForFunctionPointer<PFA3DSurfOffsetGet>(Library.A3DGetProcAddress("A3DSurfOffsetGet", 1));
        public delegate A3DStatus PFA3DSurfOffsetCreate(ref A3DSurfOffsetData pData, out IntPtr ppSrf);
        public static PFA3DSurfOffsetCreate A3DSurfOffsetCreate = Marshal.GetDelegateForFunctionPointer<PFA3DSurfOffsetCreate>(Library.A3DGetProcAddress("A3DSurfOffsetCreate", 1));
        public delegate A3DStatus PFA3DSurfPlaneGet(IntPtr pSrf, ref A3DSurfPlaneData pData);
        public static PFA3DSurfPlaneGet A3DSurfPlaneGet = Marshal.GetDelegateForFunctionPointer<PFA3DSurfPlaneGet>(Library.A3DGetProcAddress("A3DSurfPlaneGet", 1));
        public delegate A3DStatus PFA3DSurfPlaneCreate(ref A3DSurfPlaneData pData, out IntPtr ppSrf);
        public static PFA3DSurfPlaneCreate A3DSurfPlaneCreate = Marshal.GetDelegateForFunctionPointer<PFA3DSurfPlaneCreate>(Library.A3DGetProcAddress("A3DSurfPlaneCreate", 1));
        public delegate A3DStatus PFA3DSurfBlend01Get(IntPtr pSrf, ref A3DSurfBlend01Data pData);
        public static PFA3DSurfBlend01Get A3DSurfBlend01Get = Marshal.GetDelegateForFunctionPointer<PFA3DSurfBlend01Get>(Library.A3DGetProcAddress("A3DSurfBlend01Get", 1));
        public delegate A3DStatus PFA3DSurfBlend01Create(ref A3DSurfBlend01Data pData, out IntPtr ppSrf);
        public static PFA3DSurfBlend01Create A3DSurfBlend01Create = Marshal.GetDelegateForFunctionPointer<PFA3DSurfBlend01Create>(Library.A3DGetProcAddress("A3DSurfBlend01Create", 1));
        public delegate A3DStatus PFA3DSurfBlend02Get(IntPtr pSrf, ref A3DSurfBlend02Data pData);
        public static PFA3DSurfBlend02Get A3DSurfBlend02Get = Marshal.GetDelegateForFunctionPointer<PFA3DSurfBlend02Get>(Library.A3DGetProcAddress("A3DSurfBlend02Get", 1));
        public delegate A3DStatus PFA3DSurfBlend02Create(ref A3DSurfBlend02Data pData, out IntPtr ppSrf);
        public static PFA3DSurfBlend02Create A3DSurfBlend02Create = Marshal.GetDelegateForFunctionPointer<PFA3DSurfBlend02Create>(Library.A3DGetProcAddress("A3DSurfBlend02Create", 1));
        public delegate A3DStatus PFA3DSurfBlend03Get(IntPtr pSrf, ref A3DSurfBlend03Data pData);
        public static PFA3DSurfBlend03Get A3DSurfBlend03Get = Marshal.GetDelegateForFunctionPointer<PFA3DSurfBlend03Get>(Library.A3DGetProcAddress("A3DSurfBlend03Get", 1));
        public delegate A3DStatus PFA3DSurfBlend03Create(ref A3DSurfBlend03Data pData, out IntPtr ppSrf);
        public static PFA3DSurfBlend03Create A3DSurfBlend03Create = Marshal.GetDelegateForFunctionPointer<PFA3DSurfBlend03Create>(Library.A3DGetProcAddress("A3DSurfBlend03Create", 1));
        public delegate A3DStatus PFA3DSurfConeGet(IntPtr pSrf, ref A3DSurfConeData pData);
        public static PFA3DSurfConeGet A3DSurfConeGet = Marshal.GetDelegateForFunctionPointer<PFA3DSurfConeGet>(Library.A3DGetProcAddress("A3DSurfConeGet", 1));
        public delegate A3DStatus PFA3DSurfConeCreate(ref A3DSurfConeData pData, out IntPtr ppSrf);
        public static PFA3DSurfConeCreate A3DSurfConeCreate = Marshal.GetDelegateForFunctionPointer<PFA3DSurfConeCreate>(Library.A3DGetProcAddress("A3DSurfConeCreate", 1));
        public delegate A3DStatus PFA3DSurfCylindricalGet(IntPtr pSrf, ref A3DSurfCylindricalData pData);
        public static PFA3DSurfCylindricalGet A3DSurfCylindricalGet = Marshal.GetDelegateForFunctionPointer<PFA3DSurfCylindricalGet>(Library.A3DGetProcAddress("A3DSurfCylindricalGet", 1));
        public delegate A3DStatus PFA3DSurfCylindricalCreate(ref A3DSurfCylindricalData pData, out IntPtr ppSrf);
        public static PFA3DSurfCylindricalCreate A3DSurfCylindricalCreate = Marshal.GetDelegateForFunctionPointer<PFA3DSurfCylindricalCreate>(Library.A3DGetProcAddress("A3DSurfCylindricalCreate", 1));
        public delegate A3DStatus PFA3DSurfRuledGet(IntPtr pSrf, ref A3DSurfRuledData pData);
        public static PFA3DSurfRuledGet A3DSurfRuledGet = Marshal.GetDelegateForFunctionPointer<PFA3DSurfRuledGet>(Library.A3DGetProcAddress("A3DSurfRuledGet", 1));
        public delegate A3DStatus PFA3DSurfRuledCreate(ref A3DSurfRuledData pData, out IntPtr ppSrf);
        public static PFA3DSurfRuledCreate A3DSurfRuledCreate = Marshal.GetDelegateForFunctionPointer<PFA3DSurfRuledCreate>(Library.A3DGetProcAddress("A3DSurfRuledCreate", 1));
        public delegate A3DStatus PFA3DSurfPipeGet(IntPtr pSrf, ref A3DSurfPipeData pData);
        public static PFA3DSurfPipeGet A3DSurfPipeGet = Marshal.GetDelegateForFunctionPointer<PFA3DSurfPipeGet>(Library.A3DGetProcAddress("A3DSurfPipeGet", 1));
        public delegate A3DStatus PFA3DSurfPipeCreate(ref A3DSurfPipeData pData, out IntPtr ppSrf);
        public static PFA3DSurfPipeCreate A3DSurfPipeCreate = Marshal.GetDelegateForFunctionPointer<PFA3DSurfPipeCreate>(Library.A3DGetProcAddress("A3DSurfPipeCreate", 1));
        public delegate A3DStatus PFA3DSurfTransformGet(IntPtr pSrf, ref A3DSurfTransformData pData);
        public static PFA3DSurfTransformGet A3DSurfTransformGet = Marshal.GetDelegateForFunctionPointer<PFA3DSurfTransformGet>(Library.A3DGetProcAddress("A3DSurfTransformGet", 1));
        public delegate A3DStatus PFA3DSurfTransformCreate(ref A3DSurfTransformData pData, out IntPtr ppSrf);
        public static PFA3DSurfTransformCreate A3DSurfTransformCreate = Marshal.GetDelegateForFunctionPointer<PFA3DSurfTransformCreate>(Library.A3DGetProcAddress("A3DSurfTransformCreate", 1));
        public delegate A3DStatus PFA3DSurfFromCurvesGet(IntPtr pSrf, ref A3DSurfFromCurvesData pData);
        public static PFA3DSurfFromCurvesGet A3DSurfFromCurvesGet = Marshal.GetDelegateForFunctionPointer<PFA3DSurfFromCurvesGet>(Library.A3DGetProcAddress("A3DSurfFromCurvesGet", 1));
        public delegate A3DStatus PFA3DSurfFromCurvesCreate(ref A3DSurfFromCurvesData pData, out IntPtr ppSrf);
        public static PFA3DSurfFromCurvesCreate A3DSurfFromCurvesCreate = Marshal.GetDelegateForFunctionPointer<PFA3DSurfFromCurvesCreate>(Library.A3DGetProcAddress("A3DSurfFromCurvesCreate", 1));
        public delegate A3DStatus PFA3DGlobalGetPointer(out IntPtr ppGlobal);
        public static PFA3DGlobalGetPointer A3DGlobalGetPointer = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalGetPointer>(Library.A3DGetProcAddress("A3DGlobalGetPointer", 1));
        public delegate A3DStatus PFA3DGlobalGet(IntPtr pGlobal, ref A3DGlobalData pData);
        public static PFA3DGlobalGet A3DGlobalGet = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalGet>(Library.A3DGetProcAddress("A3DGlobalGet", 1));
        public delegate A3DStatus PFA3DGlobalIsMaterialTexture(uint uiIndexMaterial, out bool pbIsTexture);
        public static PFA3DGlobalIsMaterialTexture A3DGlobalIsMaterialTexture = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalIsMaterialTexture>(Library.A3DGetProcAddress("A3DGlobalIsMaterialTexture", 1));
        public delegate A3DStatus PFA3DGlobalGetFillPatternType(uint uiIndexPattern, ref A3DEEntityType pePatternType);
        public static PFA3DGlobalGetFillPatternType A3DGlobalGetFillPatternType = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalGetFillPatternType>(Library.A3DGetProcAddress("A3DGlobalGetFillPatternType", 1));
        public delegate A3DStatus PFA3DLicPutUnifiedLicense([MarshalAs(UnmanagedType.LPStr)] string pcUnifiedKey);
        public static PFA3DLicPutUnifiedLicense A3DLicPutUnifiedLicense = Marshal.GetDelegateForFunctionPointer<PFA3DLicPutUnifiedLicense>(Library.A3DGetProcAddress("A3DLicPutUnifiedLicense", 1));
        public delegate A3DStatus PFA3DMDPosition3DGet(IntPtr pPosition3D, ref A3DMDPosition3DData pData);
        public static PFA3DMDPosition3DGet A3DMDPosition3DGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDPosition3DGet>(Library.A3DGetProcAddress("A3DMDPosition3DGet", 1));
        public delegate A3DStatus PFA3DMDPosition2DGet(IntPtr pPosition2D, ref A3DMDPosition2DData pData);
        public static PFA3DMDPosition2DGet A3DMDPosition2DGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDPosition2DGet>(Library.A3DGetProcAddress("A3DMDPosition2DGet", 1));
        public delegate A3DStatus PFA3DMDPositionReferenceGet(IntPtr pPositionReference, ref A3DMDPositionReferenceData pData);
        public static PFA3DMDPositionReferenceGet A3DMDPositionReferenceGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDPositionReferenceGet>(Library.A3DGetProcAddress("A3DMDPositionReferenceGet", 1));
        public delegate A3DStatus PFA3DMDLeaderSymbolGet(IntPtr pLeaderSymbol, ref A3DMDLeaderSymbolData pData);
        public static PFA3DMDLeaderSymbolGet A3DMDLeaderSymbolGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDLeaderSymbolGet>(Library.A3DGetProcAddress("A3DMDLeaderSymbolGet", 1));
        public delegate A3DStatus PFA3DMDMarkupLeaderStubGet(IntPtr pLeaderStub, ref A3DMDMarkupLeaderStubData pData);
        public static PFA3DMDMarkupLeaderStubGet A3DMDMarkupLeaderStubGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDMarkupLeaderStubGet>(Library.A3DGetProcAddress("A3DMDMarkupLeaderStubGet", 1));
        public delegate A3DStatus PFA3DMDLeaderDefinitionGet(IntPtr pLeader, ref A3DMDLeaderDefinitionData pData);
        public static PFA3DMDLeaderDefinitionGet A3DMDLeaderDefinitionGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDLeaderDefinitionGet>(Library.A3DGetProcAddress("A3DMDLeaderDefinitionGet", 1));
        public delegate A3DStatus PFA3DMDTextPropertiesGet(IntPtr pTextProperties, ref A3DMDTextPropertiesData pData);
        public static PFA3DMDTextPropertiesGet A3DMDTextPropertiesGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDTextPropertiesGet>(Library.A3DGetProcAddress("A3DMDTextPropertiesGet", 1));
        public delegate A3DStatus PFA3DMarkupDefinitionGet(IntPtr pMarkupDefinition, ref A3DMarkupDefinitionData pData);
        public static PFA3DMarkupDefinitionGet A3DMarkupDefinitionGet = Marshal.GetDelegateForFunctionPointer<PFA3DMarkupDefinitionGet>(Library.A3DGetProcAddress("A3DMarkupDefinitionGet", 1));
        public delegate A3DStatus PFA3DMarkupPositionIsScreenLocation(IntPtr pMarkupDefinition, out bool pIsScreenLocation, ref A3DMDPosition2DData pPosition, ref A3DVector2dData pOffsetAnchorPoint);
        public static PFA3DMarkupPositionIsScreenLocation A3DMarkupPositionIsScreenLocation = Marshal.GetDelegateForFunctionPointer<PFA3DMarkupPositionIsScreenLocation>(Library.A3DGetProcAddress("A3DMarkupPositionIsScreenLocation", 1));
        public delegate A3DStatus PFA3DMDDimensionValueFormatGet(IntPtr pDimensionValueFormat, ref A3DMDDimensionValueFormatData pData);
        public static PFA3DMDDimensionValueFormatGet A3DMDDimensionValueFormatGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDDimensionValueFormatGet>(Library.A3DGetProcAddress("A3DMDDimensionValueFormatGet", 1));
        public delegate A3DStatus PFA3DMDDimensionSimpleToleranceFormatGet(IntPtr pDimensionToleranceFormat, ref A3DMDDimensionSimpleToleranceFormatData pData);
        public static PFA3DMDDimensionSimpleToleranceFormatGet A3DMDDimensionSimpleToleranceFormatGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDDimensionSimpleToleranceFormatGet>(Library.A3DGetProcAddress("A3DMDDimensionSimpleToleranceFormatGet", 1));
        public delegate A3DStatus PFA3DMDDimensionCombinedToleranceFormatGet(IntPtr pDimensionCombinedToleranceFormat, ref A3DMDDimensionCombinedToleranceFormatData pData);
        public static PFA3DMDDimensionCombinedToleranceFormatGet A3DMDDimensionCombinedToleranceFormatGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDDimensionCombinedToleranceFormatGet>(Library.A3DGetProcAddress("A3DMDDimensionCombinedToleranceFormatGet", 1));
        public delegate A3DStatus PFA3DMDDimensionValueGet(IntPtr pDimensionValue, ref A3DMDDimensionValueData pData);
        public static PFA3DMDDimensionValueGet A3DMDDimensionValueGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDDimensionValueGet>(Library.A3DGetProcAddress("A3DMDDimensionValueGet", 1));
        public delegate A3DStatus PFA3DMDDimensionSecondPartGet(IntPtr pDimensionSecondPart, ref A3DMDDimensionSecondPartData pData);
        public static PFA3DMDDimensionSecondPartGet A3DMDDimensionSecondPartGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDDimensionSecondPartGet>(Library.A3DGetProcAddress("A3DMDDimensionSecondPartGet", 1));
        public delegate A3DStatus PFA3DMDDimensionForeshortenedGet(IntPtr pDimensionForeshortened, ref A3DMDDimensionForeshortenedData pData);
        public static PFA3DMDDimensionForeshortenedGet A3DMDDimensionForeshortenedGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDDimensionForeshortenedGet>(Library.A3DGetProcAddress("A3DMDDimensionForeshortenedGet", 1));
        public delegate A3DStatus PFA3DMDDimensionLineSymbolGet(IntPtr pDimensionLineSymbol, ref A3DMDDimensionLineSymbolData pData);
        public static PFA3DMDDimensionLineSymbolGet A3DMDDimensionLineSymbolGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDDimensionLineSymbolGet>(Library.A3DGetProcAddress("A3DMDDimensionLineSymbolGet", 1));
        public delegate A3DStatus PFA3DMDDimensionLineGet(IntPtr pDimensionLine, ref A3DMDDimensionLineData pData);
        public static PFA3DMDDimensionLineGet A3DMDDimensionLineGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDDimensionLineGet>(Library.A3DGetProcAddress("A3DMDDimensionLineGet", 1));
        public delegate A3DStatus PFA3DMDDimensionFunnelGet(IntPtr pDimensionFunnel, ref A3DMDDimensionFunnelData pData);
        public static PFA3DMDDimensionFunnelGet A3DMDDimensionFunnelGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDDimensionFunnelGet>(Library.A3DGetProcAddress("A3DMDDimensionFunnelGet", 1));
        public delegate A3DStatus PFA3DMDDimensionExtremityGet(IntPtr pDimensionExtremity, ref A3DMDDimensionExtremityData pData);
        public static PFA3DMDDimensionExtremityGet A3DMDDimensionExtremityGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDDimensionExtremityGet>(Library.A3DGetProcAddress("A3DMDDimensionExtremityGet", 1));
        public delegate A3DStatus PFA3DMDDimensionExtentionLineGet(IntPtr pDimensionExtentionLine, ref A3DMDDimensionExtentionLineData pData);
        public static PFA3DMDDimensionExtentionLineGet A3DMDDimensionExtentionLineGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDDimensionExtentionLineGet>(Library.A3DGetProcAddress("A3DMDDimensionExtentionLineGet", 1));
        public delegate A3DStatus PFA3DMarkupDimensionGet(IntPtr pDimension, ref A3DMarkupDimensionData pData);
        public static PFA3DMarkupDimensionGet A3DMarkupDimensionGet = Marshal.GetDelegateForFunctionPointer<PFA3DMarkupDimensionGet>(Library.A3DGetProcAddress("A3DMarkupDimensionGet", 1));
        public delegate A3DStatus PFA3DMarkupRoughnessGet(IntPtr pMarkupRoughness, ref A3DMarkupRoughnessData pData);
        public static PFA3DMarkupRoughnessGet A3DMarkupRoughnessGet = Marshal.GetDelegateForFunctionPointer<PFA3DMarkupRoughnessGet>(Library.A3DGetProcAddress("A3DMarkupRoughnessGet", 1));
        public delegate A3DStatus PFA3DMarkupBalloonGet(IntPtr pBalloon, ref A3DMarkupBalloonData pData);
        public static PFA3DMarkupBalloonGet A3DMarkupBalloonGet = Marshal.GetDelegateForFunctionPointer<PFA3DMarkupBalloonGet>(Library.A3DGetProcAddress("A3DMarkupBalloonGet", 1));
        public delegate A3DStatus PFA3DMarkupFastenerGet(IntPtr pFastener, ref A3DMarkupFastenerData pData);
        public static PFA3DMarkupFastenerGet A3DMarkupFastenerGet = Marshal.GetDelegateForFunctionPointer<PFA3DMarkupFastenerGet>(Library.A3DGetProcAddress("A3DMarkupFastenerGet", 1));
        public delegate A3DStatus PFA3DMarkupLocatorGet(IntPtr pLocator, ref A3DMarkupLocatorData pData);
        public static PFA3DMarkupLocatorGet A3DMarkupLocatorGet = Marshal.GetDelegateForFunctionPointer<PFA3DMarkupLocatorGet>(Library.A3DGetProcAddress("A3DMarkupLocatorGet", 1));
        public delegate A3DStatus PFA3DMarkupMeasurementPointGet(IntPtr pMeasurementPoint, ref A3DMarkupMeasurementPointData pData);
        public static PFA3DMarkupMeasurementPointGet A3DMarkupMeasurementPointGet = Marshal.GetDelegateForFunctionPointer<PFA3DMarkupMeasurementPointGet>(Library.A3DGetProcAddress("A3DMarkupMeasurementPointGet", 1));
        public delegate A3DStatus PFA3DMDTextPositionGet(IntPtr pTextPosition, ref A3DMDTextPositionData pData);
        public static PFA3DMDTextPositionGet A3DMDTextPositionGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDTextPositionGet>(Library.A3DGetProcAddress("A3DMDTextPositionGet", 1));
        public delegate A3DStatus PFA3DMarkupTextGet(IntPtr pMarkupText, ref A3DMarkupTextData pData);
        public static PFA3DMarkupTextGet A3DMarkupTextGet = Marshal.GetDelegateForFunctionPointer<PFA3DMarkupTextGet>(Library.A3DGetProcAddress("A3DMarkupTextGet", 1));
        public delegate A3DStatus PFA3DMarkupCoordinateGet(IntPtr pMarkupCoordinate, ref A3DMarkupCoordinateData pData);
        public static PFA3DMarkupCoordinateGet A3DMarkupCoordinateGet = Marshal.GetDelegateForFunctionPointer<PFA3DMarkupCoordinateGet>(Library.A3DGetProcAddress("A3DMarkupCoordinateGet", 1));
        public delegate A3DStatus PFA3DMarkupRichTextGet(IntPtr pMarkupRichText, ref A3DMarkupRichTextData pData);
        public static PFA3DMarkupRichTextGet A3DMarkupRichTextGet = Marshal.GetDelegateForFunctionPointer<PFA3DMarkupRichTextGet>(Library.A3DGetProcAddress("A3DMarkupRichTextGet", 1));
        public delegate A3DStatus PFA3DMarkupDatumGet(IntPtr pMarkupDatum, ref A3DMarkupDatumData pData);
        public static PFA3DMarkupDatumGet A3DMarkupDatumGet = Marshal.GetDelegateForFunctionPointer<PFA3DMarkupDatumGet>(Library.A3DGetProcAddress("A3DMarkupDatumGet", 1));
        public delegate A3DStatus PFA3DMDFCFDraftingRowGet(IntPtr pDraftingRow, ref A3DMDFCFDraftingRowData pData);
        public static PFA3DMDFCFDraftingRowGet A3DMDFCFDraftingRowGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDFCFDraftingRowGet>(Library.A3DGetProcAddress("A3DMDFCFDraftingRowGet", 1));
        public delegate A3DStatus PFA3DMDFCValueGet(IntPtr pValue, ref A3DMDFCValueData pData);
        public static PFA3DMDFCValueGet A3DMDFCValueGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDFCValueGet>(Library.A3DGetProcAddress("A3DMDFCValueGet", 1));
        public delegate A3DStatus PFA3DMDFCTolerancePerUnitGet(IntPtr pTolerancePerUnit, ref A3DMDFCTolerancePerUnitData pData);
        public static PFA3DMDFCTolerancePerUnitGet A3DMDFCTolerancePerUnitGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDFCTolerancePerUnitGet>(Library.A3DGetProcAddress("A3DMDFCTolerancePerUnitGet", 1));
        public delegate A3DStatus PFA3DMDFCProjectedZoneGet(IntPtr pProjectedZone, ref A3DMDFCProjectedZoneData pData);
        public static PFA3DMDFCProjectedZoneGet A3DMDFCProjectedZoneGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDFCProjectedZoneGet>(Library.A3DGetProcAddress("A3DMDFCProjectedZoneGet", 1));
        public delegate A3DStatus PFA3DMDFCFToleranceValueGet(IntPtr pToleranceValue, ref A3DMDFCFToleranceValueData pData);
        public static PFA3DMDFCFToleranceValueGet A3DMDFCFToleranceValueGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDFCFToleranceValueGet>(Library.A3DGetProcAddress("A3DMDFCFToleranceValueGet", 1));
        public delegate A3DStatus PFA3DMDFCFRowDatumGet(IntPtr pRowDatum, ref A3DMDFCFRowDatumData pData);
        public static PFA3DMDFCFRowDatumGet A3DMDFCFRowDatumGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDFCFRowDatumGet>(Library.A3DGetProcAddress("A3DMDFCFRowDatumGet", 1));
        public delegate A3DStatus PFA3DMDFCFDrawingRowGet(IntPtr pDrawingRow, ref A3DMDFCFDrawingRowData pData);
        public static PFA3DMDFCFDrawingRowGet A3DMDFCFDrawingRowGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDFCFDrawingRowGet>(Library.A3DGetProcAddress("A3DMDFCFDrawingRowGet", 1));
        public delegate A3DStatus PFA3DMDFCFSemanticRowGet(IntPtr pRow, ref A3DMDFCFDrawingRowData pData);
        public static PFA3DMDFCFSemanticRowGet A3DMDFCFSemanticRowGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDFCFSemanticRowGet>(Library.A3DGetProcAddress("A3DMDFCFSemanticRowGet", 1));
        public delegate A3DStatus PFA3DMDFCFIndicatorGet(IntPtr pIndicator, ref A3DMDFCFIndicatorData pData);
        public static PFA3DMDFCFIndicatorGet A3DMDFCFIndicatorGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDFCFIndicatorGet>(Library.A3DGetProcAddress("A3DMDFCFIndicatorGet", 1));
        public delegate A3DStatus PFA3DMDFeatureControlFrameGet(IntPtr pFCF, ref A3DMDFeatureControlFrameData pData);
        public static PFA3DMDFeatureControlFrameGet A3DMDFeatureControlFrameGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDFeatureControlFrameGet>(Library.A3DGetProcAddress("A3DMDFeatureControlFrameGet", 1));
        public delegate A3DStatus PFA3DMDSemanticFeatureControlFrameGet(IntPtr pFCF, ref A3DMDFeatureControlFrameData pData);
        public static PFA3DMDSemanticFeatureControlFrameGet A3DMDSemanticFeatureControlFrameGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDSemanticFeatureControlFrameGet>(Library.A3DGetProcAddress("A3DMDSemanticFeatureControlFrameGet", 1));
        public delegate A3DStatus PFA3DMDToleranceSizeGet(IntPtr pToleranceSize, ref A3DMDToleranceSizeData pData);
        public static PFA3DMDToleranceSizeGet A3DMDToleranceSizeGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDToleranceSizeGet>(Library.A3DGetProcAddress("A3DMDToleranceSizeGet", 1));
        public delegate A3DStatus PFA3DMDToleranceSizeValueGet(IntPtr pToleranceSizeValue, ref A3DMDToleranceSizeValueData pData);
        public static PFA3DMDToleranceSizeValueGet A3DMDToleranceSizeValueGet = Marshal.GetDelegateForFunctionPointer<PFA3DMDToleranceSizeValueGet>(Library.A3DGetProcAddress("A3DMDToleranceSizeValueGet", 1));
        public delegate A3DStatus PFA3DMarkupGDTGet(IntPtr pMarkupGDT, ref A3DMarkupGDTData pData);
        public static PFA3DMarkupGDTGet A3DMarkupGDTGet = Marshal.GetDelegateForFunctionPointer<PFA3DMarkupGDTGet>(Library.A3DGetProcAddress("A3DMarkupGDTGet", 1));
        public delegate A3DStatus PFA3DMarkupSpotWeldingGet(IntPtr pSpotWelding, ref A3DMarkupSpotWeldingData pData);
        public static PFA3DMarkupSpotWeldingGet A3DMarkupSpotWeldingGet = Marshal.GetDelegateForFunctionPointer<PFA3DMarkupSpotWeldingGet>(Library.A3DGetProcAddress("A3DMarkupSpotWeldingGet", 1));
        public delegate A3DStatus PFA3DMarkupLineWeldingGet(IntPtr pLineWelding, ref A3DMarkupLineWeldingData pData);
        public static PFA3DMarkupLineWeldingGet A3DMarkupLineWeldingGet = Marshal.GetDelegateForFunctionPointer<PFA3DMarkupLineWeldingGet>(Library.A3DGetProcAddress("A3DMarkupLineWeldingGet", 1));
        public delegate A3DStatus PFA3DMathFct1DPolynomGet(IntPtr pMathFn, ref A3DMathFct1DPolynomData pData);
        public static PFA3DMathFct1DPolynomGet A3DMathFct1DPolynomGet = Marshal.GetDelegateForFunctionPointer<PFA3DMathFct1DPolynomGet>(Library.A3DGetProcAddress("A3DMathFct1DPolynomGet", 1));
        public delegate A3DStatus PFA3DMathFct1DPolynomCreate(ref A3DMathFct1DPolynomData pData, out IntPtr ppMathFn);
        public static PFA3DMathFct1DPolynomCreate A3DMathFct1DPolynomCreate = Marshal.GetDelegateForFunctionPointer<PFA3DMathFct1DPolynomCreate>(Library.A3DGetProcAddress("A3DMathFct1DPolynomCreate", 1));
        public delegate A3DStatus PFA3DMathFct1DTrigonometricGet(IntPtr pMathFn, ref A3DMathFct1DTrigonometricData pData);
        public static PFA3DMathFct1DTrigonometricGet A3DMathFct1DTrigonometricGet = Marshal.GetDelegateForFunctionPointer<PFA3DMathFct1DTrigonometricGet>(Library.A3DGetProcAddress("A3DMathFct1DTrigonometricGet", 1));
        public delegate A3DStatus PFA3DMathFct1DTrigonometricCreate(ref A3DMathFct1DTrigonometricData pData, out IntPtr ppMathFn);
        public static PFA3DMathFct1DTrigonometricCreate A3DMathFct1DTrigonometricCreate = Marshal.GetDelegateForFunctionPointer<PFA3DMathFct1DTrigonometricCreate>(Library.A3DGetProcAddress("A3DMathFct1DTrigonometricCreate", 1));
        public delegate A3DStatus PFA3DMathFct1DFractionGet(IntPtr pMathFn, ref A3DMathFct1DFractionData pData);
        public static PFA3DMathFct1DFractionGet A3DMathFct1DFractionGet = Marshal.GetDelegateForFunctionPointer<PFA3DMathFct1DFractionGet>(Library.A3DGetProcAddress("A3DMathFct1DFractionGet", 1));
        public delegate A3DStatus PFA3DMathFct1DFractionCreate(ref A3DMathFct1DFractionData pData, out IntPtr ppMathFn);
        public static PFA3DMathFct1DFractionCreate A3DMathFct1DFractionCreate = Marshal.GetDelegateForFunctionPointer<PFA3DMathFct1DFractionCreate>(Library.A3DGetProcAddress("A3DMathFct1DFractionCreate", 1));
        public delegate A3DStatus PFA3DMathFct1DArctanCosGet(IntPtr pMathFn, ref A3DMathFct1DArctanCosData pData);
        public static PFA3DMathFct1DArctanCosGet A3DMathFct1DArctanCosGet = Marshal.GetDelegateForFunctionPointer<PFA3DMathFct1DArctanCosGet>(Library.A3DGetProcAddress("A3DMathFct1DArctanCosGet", 1));
        public delegate A3DStatus PFA3DMathFct1DArctanCosCreate(ref A3DMathFct1DArctanCosData pData, out IntPtr ppMathFn);
        public static PFA3DMathFct1DArctanCosCreate A3DMathFct1DArctanCosCreate = Marshal.GetDelegateForFunctionPointer<PFA3DMathFct1DArctanCosCreate>(Library.A3DGetProcAddress("A3DMathFct1DArctanCosCreate", 1));
        public delegate A3DStatus PFA3DMathFct1DCombinationGet(IntPtr pMathFn, ref A3DMathFct1DCombinationData pData);
        public static PFA3DMathFct1DCombinationGet A3DMathFct1DCombinationGet = Marshal.GetDelegateForFunctionPointer<PFA3DMathFct1DCombinationGet>(Library.A3DGetProcAddress("A3DMathFct1DCombinationGet", 1));
        public delegate A3DStatus PFA3DMathFct1DCombinationCreate(ref A3DMathFct1DCombinationData pData, out IntPtr ppMathFn);
        public static PFA3DMathFct1DCombinationCreate A3DMathFct1DCombinationCreate = Marshal.GetDelegateForFunctionPointer<PFA3DMathFct1DCombinationCreate>(Library.A3DGetProcAddress("A3DMathFct1DCombinationCreate", 1));
        public delegate A3DStatus PFA3DMathFct3DLinearGet(IntPtr pMathFn, ref A3DMathFct3DLinearData pData);
        public static PFA3DMathFct3DLinearGet A3DMathFct3DLinearGet = Marshal.GetDelegateForFunctionPointer<PFA3DMathFct3DLinearGet>(Library.A3DGetProcAddress("A3DMathFct3DLinearGet", 1));
        public delegate A3DStatus PFA3DMathFct3DLinearCreate(ref A3DMathFct3DLinearData pData, out IntPtr ppMathFn);
        public static PFA3DMathFct3DLinearCreate A3DMathFct3DLinearCreate = Marshal.GetDelegateForFunctionPointer<PFA3DMathFct3DLinearCreate>(Library.A3DGetProcAddress("A3DMathFct3DLinearCreate", 1));
        public delegate A3DStatus PFA3DMathFct3DNonLinearGet(IntPtr pMathFn, ref A3DMathFct3DNonLinearData pData);
        public static PFA3DMathFct3DNonLinearGet A3DMathFct3DNonLinearGet = Marshal.GetDelegateForFunctionPointer<PFA3DMathFct3DNonLinearGet>(Library.A3DGetProcAddress("A3DMathFct3DNonLinearGet", 1));
        public delegate A3DStatus PFA3DMathFct3DNonLinearCreate(ref A3DMathFct3DNonLinearData pData, out IntPtr ppMathFn);
        public static PFA3DMathFct3DNonLinearCreate A3DMathFct3DNonLinearCreate = Marshal.GetDelegateForFunctionPointer<PFA3DMathFct3DNonLinearCreate>(Library.A3DGetProcAddress("A3DMathFct3DNonLinearCreate", 1));
        public delegate A3DStatus PFA3DEntityGetType(IntPtr pEntity, ref A3DEEntityType peEntityType);
        public static PFA3DEntityGetType A3DEntityGetType = Marshal.GetDelegateForFunctionPointer<PFA3DEntityGetType>(Library.A3DGetProcAddress("A3DEntityGetType", 1));
        public delegate bool PFA3DEntityIsBaseWithGraphicsType(IntPtr pEntity);
        public static PFA3DEntityIsBaseWithGraphicsType A3DEntityIsBaseWithGraphicsType = Marshal.GetDelegateForFunctionPointer<PFA3DEntityIsBaseWithGraphicsType>(Library.A3DGetProcAddress("A3DEntityIsBaseWithGraphicsType", 1));
        public delegate bool PFA3DEntityIsBaseType(IntPtr pEntity);
        public static PFA3DEntityIsBaseType A3DEntityIsBaseType = Marshal.GetDelegateForFunctionPointer<PFA3DEntityIsBaseType>(Library.A3DGetProcAddress("A3DEntityIsBaseType", 1));
        public delegate A3DStatus PFA3DRootBaseGet(IntPtr pRootBase, ref A3DRootBaseData pData);
        public static PFA3DRootBaseGet A3DRootBaseGet = Marshal.GetDelegateForFunctionPointer<PFA3DRootBaseGet>(Library.A3DGetProcAddress("A3DRootBaseGet", 1));
        public delegate A3DStatus PFA3DRootBaseSet(IntPtr pRootBase, ref A3DRootBaseData pData);
        public static PFA3DRootBaseSet A3DRootBaseSet = Marshal.GetDelegateForFunctionPointer<PFA3DRootBaseSet>(Library.A3DGetProcAddress("A3DRootBaseSet", 1));
        public delegate A3DStatus PFA3DRootBaseAttributeRemoveAll(IntPtr pEntity);
        public static PFA3DRootBaseAttributeRemoveAll A3DRootBaseAttributeRemoveAll = Marshal.GetDelegateForFunctionPointer<PFA3DRootBaseAttributeRemoveAll>(Library.A3DGetProcAddress("A3DRootBaseAttributeRemoveAll", 1));
        public delegate A3DStatus PFA3DRootBaseAttributeRemove(IntPtr pEntity, [MarshalAs(UnmanagedType.LPStr)] string pcTitle);
        public static PFA3DRootBaseAttributeRemove A3DRootBaseAttributeRemove = Marshal.GetDelegateForFunctionPointer<PFA3DRootBaseAttributeRemove>(Library.A3DGetProcAddress("A3DRootBaseAttributeRemove", 1));
        public delegate A3DStatus PFA3DRootBaseAttributeRemoveAt(IntPtr pEntity, uint uIndex);
        public static PFA3DRootBaseAttributeRemoveAt A3DRootBaseAttributeRemoveAt = Marshal.GetDelegateForFunctionPointer<PFA3DRootBaseAttributeRemoveAt>(Library.A3DGetProcAddress("A3DRootBaseAttributeRemoveAt", 1));
        public delegate A3DStatus PFA3DRootBaseAttributeAppend(IntPtr pEntity, uint uiSize, out IntPtr m_ppAttributes);
        public static PFA3DRootBaseAttributeAppend A3DRootBaseAttributeAppend = Marshal.GetDelegateForFunctionPointer<PFA3DRootBaseAttributeAppend>(Library.A3DGetProcAddress("A3DRootBaseAttributeAppend", 1));
        public delegate A3DStatus PFA3DRootBaseAttributeAdd(IntPtr pEntity, [MarshalAs(UnmanagedType.LPStr)] string pcTitle, [MarshalAs(UnmanagedType.LPStr)] string pcValue);
        public static PFA3DRootBaseAttributeAdd A3DRootBaseAttributeAdd = Marshal.GetDelegateForFunctionPointer<PFA3DRootBaseAttributeAdd>(Library.A3DGetProcAddress("A3DRootBaseAttributeAdd", 1));
        public delegate A3DStatus PFA3DRootBaseWithGraphicsGet(IntPtr pRoot, ref A3DRootBaseWithGraphicsData pData);
        public static PFA3DRootBaseWithGraphicsGet A3DRootBaseWithGraphicsGet = Marshal.GetDelegateForFunctionPointer<PFA3DRootBaseWithGraphicsGet>(Library.A3DGetProcAddress("A3DRootBaseWithGraphicsGet", 1));
        public delegate A3DStatus PFA3DRootBaseWithGraphicsSet(IntPtr pRoot, ref A3DRootBaseWithGraphicsData pData);
        public static PFA3DRootBaseWithGraphicsSet A3DRootBaseWithGraphicsSet = Marshal.GetDelegateForFunctionPointer<PFA3DRootBaseWithGraphicsSet>(Library.A3DGetProcAddress("A3DRootBaseWithGraphicsSet", 1));
        public delegate A3DStatus PFA3DMiscAttributeGet(IntPtr pAttribute, ref A3DMiscAttributeData pData);
        public static PFA3DMiscAttributeGet A3DMiscAttributeGet = Marshal.GetDelegateForFunctionPointer<PFA3DMiscAttributeGet>(Library.A3DGetProcAddress("A3DMiscAttributeGet", 1));
        public delegate A3DStatus PFA3DMiscAttributeCreate(ref A3DMiscAttributeData pData, out IntPtr ppAttribute);
        public static PFA3DMiscAttributeCreate A3DMiscAttributeCreate = Marshal.GetDelegateForFunctionPointer<PFA3DMiscAttributeCreate>(Library.A3DGetProcAddress("A3DMiscAttributeCreate", 1));
        public delegate A3DStatus PFA3DGlobalGetUnit(uint uiIndexUnit, out IntPtr ppUnit);
        public static PFA3DGlobalGetUnit A3DGlobalGetUnit = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalGetUnit>(Library.A3DGetProcAddress("A3DGlobalGetUnit", 1));
        public delegate A3DStatus PFA3DGlobalGetUnitData(IntPtr pUnit, ref A3DMiscAttributeUnitData pData);
        public static PFA3DGlobalGetUnitData A3DGlobalGetUnitData = Marshal.GetDelegateForFunctionPointer<PFA3DGlobalGetUnitData>(Library.A3DGetProcAddress("A3DGlobalGetUnitData", 1));
        public delegate A3DStatus PFA3DCopyAndAdaptBrepModel(IntPtr p, ref A3DCopyAndAdaptBrepModelData psSetting, out IntPtr pp);
        public static PFA3DCopyAndAdaptBrepModel A3DCopyAndAdaptBrepModel = Marshal.GetDelegateForFunctionPointer<PFA3DCopyAndAdaptBrepModel>(Library.A3DGetProcAddress("A3DCopyAndAdaptBrepModel", 1));
        public delegate A3DStatus PFA3DCopyAndAdaptBrepModelAdvanced(IntPtr p, ref A3DCopyAndAdaptBrepModelData psSetting, out IntPtr pp, out uint puiNbErrors, IntPtr paiErrors);
        public static PFA3DCopyAndAdaptBrepModelAdvanced A3DCopyAndAdaptBrepModelAdvanced = Marshal.GetDelegateForFunctionPointer<PFA3DCopyAndAdaptBrepModelAdvanced>(Library.A3DGetProcAddress("A3DCopyAndAdaptBrepModelAdvanced", 1));
        public delegate A3DStatus PFA3DAdaptAndReplaceAllBrepInModelFile(IntPtr pModelFile, ref A3DCopyAndAdaptBrepModelData psSetting);
        public static PFA3DAdaptAndReplaceAllBrepInModelFile A3DAdaptAndReplaceAllBrepInModelFile = Marshal.GetDelegateForFunctionPointer<PFA3DAdaptAndReplaceAllBrepInModelFile>(Library.A3DGetProcAddress("A3DAdaptAndReplaceAllBrepInModelFile", 1));
        public delegate A3DStatus PFA3DAdaptAndReplaceAllBrepInModelFileAdvanced(IntPtr p, ref A3DCopyAndAdaptBrepModelData psSetting, out uint puiNbErrors, IntPtr pErrors);
        public static PFA3DAdaptAndReplaceAllBrepInModelFileAdvanced A3DAdaptAndReplaceAllBrepInModelFileAdvanced = Marshal.GetDelegateForFunctionPointer<PFA3DAdaptAndReplaceAllBrepInModelFileAdvanced>(Library.A3DGetProcAddress("A3DAdaptAndReplaceAllBrepInModelFileAdvanced", 1));
        public delegate A3DStatus PFA3DEntityDelete(IntPtr pEntity);
        public static PFA3DEntityDelete A3DEntityDelete = Marshal.GetDelegateForFunctionPointer<PFA3DEntityDelete>(Library.A3DGetProcAddress("A3DEntityDelete", 1));
        public delegate A3DStatus PFA3DEntityGetPDFNodeIdFromWrite(IntPtr pEntity, IntPtr pEntityFather, IntPtr pA3DRWParamsPrcWriteHelper, IntPtr pcUTF8Name);
        public static PFA3DEntityGetPDFNodeIdFromWrite A3DEntityGetPDFNodeIdFromWrite = Marshal.GetDelegateForFunctionPointer<PFA3DEntityGetPDFNodeIdFromWrite>(Library.A3DGetProcAddress("A3DEntityGetPDFNodeIdFromWrite", 1));
        public delegate A3DStatus PFA3DEntityGetPDFNodeIdFromRead(IntPtr pEntity, IntPtr pEntityFather, IntPtr pA3DRWParamsPrcReadHelper, IntPtr pcUTF8Name);
        public static PFA3DEntityGetPDFNodeIdFromRead A3DEntityGetPDFNodeIdFromRead = Marshal.GetDelegateForFunctionPointer<PFA3DEntityGetPDFNodeIdFromRead>(Library.A3DGetProcAddress("A3DEntityGetPDFNodeIdFromRead", 1));
        public delegate A3DStatus PFA3DTopoItemOwnersManagerGet(IntPtr pBrepOwner, out IntPtr ppTopoItemOwnersManager);
        public static PFA3DTopoItemOwnersManagerGet A3DTopoItemOwnersManagerGet = Marshal.GetDelegateForFunctionPointer<PFA3DTopoItemOwnersManagerGet>(Library.A3DGetProcAddress("A3DTopoItemOwnersManagerGet", 1));
        public delegate A3DStatus PFA3DTopoItemOwnersGet(IntPtr pTopoItemOwnersManager, IntPtr pTopoItem, IntPtr ppTopoItemOwner);
        public static PFA3DTopoItemOwnersGet A3DTopoItemOwnersGet = Marshal.GetDelegateForFunctionPointer<PFA3DTopoItemOwnersGet>(Library.A3DGetProcAddress("A3DTopoItemOwnersGet", 1));
        public delegate A3DStatus PFA3DComputePhysicalProperties(IntPtr p, ref A3DVector3dData psScale, ref A3DPhysicalPropertiesData psPhysicalPropertiesData);
        public static PFA3DComputePhysicalProperties A3DComputePhysicalProperties = Marshal.GetDelegateForFunctionPointer<PFA3DComputePhysicalProperties>(Library.A3DGetProcAddress("A3DComputePhysicalProperties", 1));
        public delegate A3DStatus PFA3DComputeFaceArea(IntPtr pFace, IntPtr pBrepDataTopoContext, out double pArea);
        public static PFA3DComputeFaceArea A3DComputeFaceArea = Marshal.GetDelegateForFunctionPointer<PFA3DComputeFaceArea>(Library.A3DGetProcAddress("A3DComputeFaceArea", 1));
        public delegate A3DStatus PFA3DComputePolyBrepPhysicalProperties(IntPtr p, ref A3DVector3dData psScale, ref A3DPhysicalPropertiesData psPhysicalPropertiesData);
        public static PFA3DComputePolyBrepPhysicalProperties A3DComputePolyBrepPhysicalProperties = Marshal.GetDelegateForFunctionPointer<PFA3DComputePolyBrepPhysicalProperties>(Library.A3DGetProcAddress("A3DComputePolyBrepPhysicalProperties", 1));
        public delegate A3DStatus PFA3DComputeModelFilePhysicalProperties(IntPtr p, ref A3DPhysicalPropertiesData psPhysicalProperties);
        public static PFA3DComputeModelFilePhysicalProperties A3DComputeModelFilePhysicalProperties = Marshal.GetDelegateForFunctionPointer<PFA3DComputeModelFilePhysicalProperties>(Library.A3DGetProcAddress("A3DComputeModelFilePhysicalProperties", 1));
        public delegate A3DStatus PFA3DSimplifyModelFileCurveAndSurfaceAsAnalytic(IntPtr p, double dTol);
        public static PFA3DSimplifyModelFileCurveAndSurfaceAsAnalytic A3DSimplifyModelFileCurveAndSurfaceAsAnalytic = Marshal.GetDelegateForFunctionPointer<PFA3DSimplifyModelFileCurveAndSurfaceAsAnalytic>(Library.A3DGetProcAddress("A3DSimplifyModelFileCurveAndSurfaceAsAnalytic", 1));
        public delegate A3DStatus PFA3DSimplifyModelFileWithAnalytics(IntPtr p, double dTol, uint uNbRecognizedType, IntPtr pOptRecognizedType);
        public static PFA3DSimplifyModelFileWithAnalytics A3DSimplifyModelFileWithAnalytics = Marshal.GetDelegateForFunctionPointer<PFA3DSimplifyModelFileWithAnalytics>(Library.A3DGetProcAddress("A3DSimplifyModelFileWithAnalytics", 1));
        public delegate A3DStatus PFA3DTopoBodyGet(IntPtr pBody, ref A3DTopoBodyData pData);
        public static PFA3DTopoBodyGet A3DTopoBodyGet = Marshal.GetDelegateForFunctionPointer<PFA3DTopoBodyGet>(Library.A3DGetProcAddress("A3DTopoBodyGet", 1));
        public delegate A3DStatus PFA3DTopoBodySet(IntPtr pBody, ref A3DTopoBodyData pData);
        public static PFA3DTopoBodySet A3DTopoBodySet = Marshal.GetDelegateForFunctionPointer<PFA3DTopoBodySet>(Library.A3DGetProcAddress("A3DTopoBodySet", 1));
        public delegate A3DStatus PFA3DTopoContextGet(IntPtr pContext, ref A3DTopoContextData pData);
        public static PFA3DTopoContextGet A3DTopoContextGet = Marshal.GetDelegateForFunctionPointer<PFA3DTopoContextGet>(Library.A3DGetProcAddress("A3DTopoContextGet", 1));
        public delegate A3DStatus PFA3DTopoContextCreate(ref A3DTopoContextData pData, out IntPtr ppContext);
        public static PFA3DTopoContextCreate A3DTopoContextCreate = Marshal.GetDelegateForFunctionPointer<PFA3DTopoContextCreate>(Library.A3DGetProcAddress("A3DTopoContextCreate", 1));
        public delegate A3DStatus PFA3DTopoSingleWireBodyGet(IntPtr pSingleWireBody, ref A3DTopoSingleWireBodyData pData);
        public static PFA3DTopoSingleWireBodyGet A3DTopoSingleWireBodyGet = Marshal.GetDelegateForFunctionPointer<PFA3DTopoSingleWireBodyGet>(Library.A3DGetProcAddress("A3DTopoSingleWireBodyGet", 1));
        public delegate A3DStatus PFA3DTopoSingleWireBodyCreate(ref A3DTopoSingleWireBodyData pData, out IntPtr ppSingleWireBody);
        public static PFA3DTopoSingleWireBodyCreate A3DTopoSingleWireBodyCreate = Marshal.GetDelegateForFunctionPointer<PFA3DTopoSingleWireBodyCreate>(Library.A3DGetProcAddress("A3DTopoSingleWireBodyCreate", 1));
        public delegate A3DStatus PFA3DTopoBrepDataGet(IntPtr pBrep, ref A3DTopoBrepDataData pData);
        public static PFA3DTopoBrepDataGet A3DTopoBrepDataGet = Marshal.GetDelegateForFunctionPointer<PFA3DTopoBrepDataGet>(Library.A3DGetProcAddress("A3DTopoBrepDataGet", 1));
        public delegate A3DStatus PFA3DTopoBrepDataCreate(ref A3DTopoBrepDataData pData, out IntPtr ppBrep);
        public static PFA3DTopoBrepDataCreate A3DTopoBrepDataCreate = Marshal.GetDelegateForFunctionPointer<PFA3DTopoBrepDataCreate>(Library.A3DGetProcAddress("A3DTopoBrepDataCreate", 1));
        public delegate A3DStatus PFA3DTopoBrepDataGetFaces(IntPtr psBrepData, out uint psNbFaces, IntPtr papsFaces);
        public static PFA3DTopoBrepDataGetFaces A3DTopoBrepDataGetFaces = Marshal.GetDelegateForFunctionPointer<PFA3DTopoBrepDataGetFaces>(Library.A3DGetProcAddress("A3DTopoBrepDataGetFaces", 1));
        public delegate A3DStatus PFA3DTopoBrepDataGetEdges(IntPtr psBrepData, out uint piNbEdges, IntPtr papsEdges);
        public static PFA3DTopoBrepDataGetEdges A3DTopoBrepDataGetEdges = Marshal.GetDelegateForFunctionPointer<PFA3DTopoBrepDataGetEdges>(Library.A3DGetProcAddress("A3DTopoBrepDataGetEdges", 1));
        public delegate A3DStatus PFA3DTopoConnexGet(IntPtr pConnex, ref A3DTopoConnexData pData);
        public static PFA3DTopoConnexGet A3DTopoConnexGet = Marshal.GetDelegateForFunctionPointer<PFA3DTopoConnexGet>(Library.A3DGetProcAddress("A3DTopoConnexGet", 1));
        public delegate A3DStatus PFA3DTopoConnexCreate(ref A3DTopoConnexData pData, out IntPtr ppConnex);
        public static PFA3DTopoConnexCreate A3DTopoConnexCreate = Marshal.GetDelegateForFunctionPointer<PFA3DTopoConnexCreate>(Library.A3DGetProcAddress("A3DTopoConnexCreate", 1));
        public delegate A3DStatus PFA3DTopoShellGet(IntPtr pShell, ref A3DTopoShellData pData);
        public static PFA3DTopoShellGet A3DTopoShellGet = Marshal.GetDelegateForFunctionPointer<PFA3DTopoShellGet>(Library.A3DGetProcAddress("A3DTopoShellGet", 1));
        public delegate A3DStatus PFA3DTopoShellCreate(ref A3DTopoShellData pData, out IntPtr ppShell);
        public static PFA3DTopoShellCreate A3DTopoShellCreate = Marshal.GetDelegateForFunctionPointer<PFA3DTopoShellCreate>(Library.A3DGetProcAddress("A3DTopoShellCreate", 1));
        public delegate A3DStatus PFA3DTopoFaceGet(IntPtr pFace, ref A3DTopoFaceData pData);
        public static PFA3DTopoFaceGet A3DTopoFaceGet = Marshal.GetDelegateForFunctionPointer<PFA3DTopoFaceGet>(Library.A3DGetProcAddress("A3DTopoFaceGet", 1));
        public delegate A3DStatus PFA3DTopoFaceCreate(ref A3DTopoFaceData pData, out IntPtr ppFace);
        public static PFA3DTopoFaceCreate A3DTopoFaceCreate = Marshal.GetDelegateForFunctionPointer<PFA3DTopoFaceCreate>(Library.A3DGetProcAddress("A3DTopoFaceCreate", 1));
        public delegate A3DStatus PFA3DTopoFaceGetShellAndOrientation(IntPtr psBrepData, IntPtr psFace, out IntPtr ppsShell, out byte pusOrientation);
        public static PFA3DTopoFaceGetShellAndOrientation A3DTopoFaceGetShellAndOrientation = Marshal.GetDelegateForFunctionPointer<PFA3DTopoFaceGetShellAndOrientation>(Library.A3DGetProcAddress("A3DTopoFaceGetShellAndOrientation", 1));
        public delegate A3DStatus PFA3DTopoFaceGetShell(IntPtr psBrepData, IntPtr psFace, out IntPtr ppsShell);
        public static PFA3DTopoFaceGetShell A3DTopoFaceGetShell = Marshal.GetDelegateForFunctionPointer<PFA3DTopoFaceGetShell>(Library.A3DGetProcAddress("A3DTopoFaceGetShell", 1));
        public delegate A3DStatus PFA3DTopoLoopGet(IntPtr pLoop, ref A3DTopoLoopData pData);
        public static PFA3DTopoLoopGet A3DTopoLoopGet = Marshal.GetDelegateForFunctionPointer<PFA3DTopoLoopGet>(Library.A3DGetProcAddress("A3DTopoLoopGet", 1));
        public delegate A3DStatus PFA3DTopoLoopCreate(ref A3DTopoLoopData pData, out IntPtr ppLoop);
        public static PFA3DTopoLoopCreate A3DTopoLoopCreate = Marshal.GetDelegateForFunctionPointer<PFA3DTopoLoopCreate>(Library.A3DGetProcAddress("A3DTopoLoopCreate", 1));
        public delegate A3DStatus PFA3DTopoLoopGetFace(IntPtr psBrepData, IntPtr psLoop, out IntPtr ppsFace);
        public static PFA3DTopoLoopGetFace A3DTopoLoopGetFace = Marshal.GetDelegateForFunctionPointer<PFA3DTopoLoopGetFace>(Library.A3DGetProcAddress("A3DTopoLoopGetFace", 1));
        public delegate A3DStatus PFA3DTopoCoEdgeGet(IntPtr pCoEdge, ref A3DTopoCoEdgeData pData);
        public static PFA3DTopoCoEdgeGet A3DTopoCoEdgeGet = Marshal.GetDelegateForFunctionPointer<PFA3DTopoCoEdgeGet>(Library.A3DGetProcAddress("A3DTopoCoEdgeGet", 1));
        public delegate A3DStatus PFA3DTopoCoEdgeCreate(ref A3DTopoCoEdgeData pData, out IntPtr ppCoEdge);
        public static PFA3DTopoCoEdgeCreate A3DTopoCoEdgeCreate = Marshal.GetDelegateForFunctionPointer<PFA3DTopoCoEdgeCreate>(Library.A3DGetProcAddress("A3DTopoCoEdgeCreate", 1));
        public delegate A3DStatus PFA3DTopoCoEdgeSetNeighbour(IntPtr pCoEdge, IntPtr pNeighbour);
        public static PFA3DTopoCoEdgeSetNeighbour A3DTopoCoEdgeSetNeighbour = Marshal.GetDelegateForFunctionPointer<PFA3DTopoCoEdgeSetNeighbour>(Library.A3DGetProcAddress("A3DTopoCoEdgeSetNeighbour", 1));
        public delegate A3DStatus PFA3DTopoCoedgeGetLoop(IntPtr psCoEdge, out IntPtr ppsLoop);
        public static PFA3DTopoCoedgeGetLoop A3DTopoCoedgeGetLoop = Marshal.GetDelegateForFunctionPointer<PFA3DTopoCoedgeGetLoop>(Library.A3DGetProcAddress("A3DTopoCoedgeGetLoop", 1));
        public delegate A3DStatus PFA3DTopoEdgeGet(IntPtr pEdge, ref A3DTopoEdgeData pData);
        public static PFA3DTopoEdgeGet A3DTopoEdgeGet = Marshal.GetDelegateForFunctionPointer<PFA3DTopoEdgeGet>(Library.A3DGetProcAddress("A3DTopoEdgeGet", 1));
        public delegate A3DStatus PFA3DTopoEdgeCreate(ref A3DTopoEdgeData pData, out IntPtr ppEdge);
        public static PFA3DTopoEdgeCreate A3DTopoEdgeCreate = Marshal.GetDelegateForFunctionPointer<PFA3DTopoEdgeCreate>(Library.A3DGetProcAddress("A3DTopoEdgeCreate", 1));
        public delegate A3DStatus PFA3DTopoEdgeGetCoEdges(IntPtr psBrepData, IntPtr psEdge, out uint piNbCoedges, IntPtr papsCoEdges);
        public static PFA3DTopoEdgeGetCoEdges A3DTopoEdgeGetCoEdges = Marshal.GetDelegateForFunctionPointer<PFA3DTopoEdgeGetCoEdges>(Library.A3DGetProcAddress("A3DTopoEdgeGetCoEdges", 1));
        public delegate A3DStatus PFA3DTopoEdgeGetSurfaces(IntPtr psBrepData, IntPtr psEdge, out uint piNbSurfaces, IntPtr papsSurfaces);
        public static PFA3DTopoEdgeGetSurfaces A3DTopoEdgeGetSurfaces = Marshal.GetDelegateForFunctionPointer<PFA3DTopoEdgeGetSurfaces>(Library.A3DGetProcAddress("A3DTopoEdgeGetSurfaces", 1));
        public delegate A3DStatus PFA3DTopoEdgeGetOrCompute3DCurve(IntPtr psBrepData, IntPtr psEdge, out IntPtr pps3DCurve);
        public static PFA3DTopoEdgeGetOrCompute3DCurve A3DTopoEdgeGetOrCompute3DCurve = Marshal.GetDelegateForFunctionPointer<PFA3DTopoEdgeGetOrCompute3DCurve>(Library.A3DGetProcAddress("A3DTopoEdgeGetOrCompute3DCurve", 1));
        public delegate A3DStatus PFA3DTopoWireEdgeGet(IntPtr pWireEdge, ref A3DTopoWireEdgeData pData);
        public static PFA3DTopoWireEdgeGet A3DTopoWireEdgeGet = Marshal.GetDelegateForFunctionPointer<PFA3DTopoWireEdgeGet>(Library.A3DGetProcAddress("A3DTopoWireEdgeGet", 1));
        public delegate A3DStatus PFA3DTopoWireEdgeCreate(ref A3DTopoWireEdgeData pData, out IntPtr ppWireEdge);
        public static PFA3DTopoWireEdgeCreate A3DTopoWireEdgeCreate = Marshal.GetDelegateForFunctionPointer<PFA3DTopoWireEdgeCreate>(Library.A3DGetProcAddress("A3DTopoWireEdgeCreate", 1));
        public delegate A3DStatus PFA3DTopoUniqueVertexGet(IntPtr pUniqueVertex, ref A3DTopoUniqueVertexData pData);
        public static PFA3DTopoUniqueVertexGet A3DTopoUniqueVertexGet = Marshal.GetDelegateForFunctionPointer<PFA3DTopoUniqueVertexGet>(Library.A3DGetProcAddress("A3DTopoUniqueVertexGet", 1));
        public delegate A3DStatus PFA3DTopoUniqueVertexCreate(ref A3DTopoUniqueVertexData pData, out IntPtr ppUniqueVertex);
        public static PFA3DTopoUniqueVertexCreate A3DTopoUniqueVertexCreate = Marshal.GetDelegateForFunctionPointer<PFA3DTopoUniqueVertexCreate>(Library.A3DGetProcAddress("A3DTopoUniqueVertexCreate", 1));
        public delegate A3DStatus PFA3DTopoMultipleVertexGet(IntPtr pMultipleVertex, ref A3DTopoMultipleVertexData pData);
        public static PFA3DTopoMultipleVertexGet A3DTopoMultipleVertexGet = Marshal.GetDelegateForFunctionPointer<PFA3DTopoMultipleVertexGet>(Library.A3DGetProcAddress("A3DTopoMultipleVertexGet", 1));
        public delegate A3DStatus PFA3DTopoMultipleVertexCreate(ref A3DTopoMultipleVertexData pData, out IntPtr ppMultipleVertex);
        public static PFA3DTopoMultipleVertexCreate A3DTopoMultipleVertexCreate = Marshal.GetDelegateForFunctionPointer<PFA3DTopoMultipleVertexCreate>(Library.A3DGetProcAddress("A3DTopoMultipleVertexCreate", 1));
    }
}
