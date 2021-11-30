using System;
using System.Runtime.InteropServices;

namespace TS3D.Exchange.Direct
{
    public class API
    {
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
        d.m_usUnit = Constants.A3D_DEFAULT_NO_UNIT;
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
        public static PFA3DTessBaseGet A3DTessBaseGet = null;
        public delegate A3DStatus PFA3DTessBaseSet(IntPtr pTessBase, ref A3DTessBaseData pData);
        public static PFA3DTessBaseSet A3DTessBaseSet = null;
        public delegate A3DStatus PFA3DTessBaseSetNoHash(IntPtr pTessBase, ref A3DTessBaseData pData);
        public static PFA3DTessBaseSetNoHash A3DTessBaseSetNoHash = null;
        public delegate A3DStatus PFA3DTess3DGet(IntPtr pTess, ref A3DTess3DData pData);
        public static PFA3DTess3DGet A3DTess3DGet = null;
        public delegate A3DStatus PFA3DTess3DCreate(ref A3DTess3DData pData, out IntPtr ppTess);
        public static PFA3DTess3DCreate A3DTess3DCreate = null;
        public delegate A3DStatus PFA3DTess3DWireGet(IntPtr pTess, ref A3DTess3DWireData pData);
        public static PFA3DTess3DWireGet A3DTess3DWireGet = null;
        public delegate A3DStatus PFA3DTess3DWireCreate(ref A3DTess3DWireData pData, out IntPtr ppTess);
        public static PFA3DTess3DWireCreate A3DTess3DWireCreate = null;
        public delegate A3DStatus PFA3DTessMarkupGet(IntPtr pTess, ref A3DTessMarkupData pData);
        public static PFA3DTessMarkupGet A3DTessMarkupGet = null;
        public delegate A3DStatus PFA3DTessMarkupCreate(ref A3DTessMarkupData pData, out IntPtr ppTess);
        public static PFA3DTessMarkupCreate A3DTessMarkupCreate = null;
        public delegate A3DStatus PFA3DGraphicsGet(IntPtr pGraphics, ref A3DGraphicsData pData);
        public static PFA3DGraphicsGet A3DGraphicsGet = null;
        public delegate A3DStatus PFA3DGraphicsCreate(ref A3DGraphicsData pData, out IntPtr ppGraphics);
        public static PFA3DGraphicsCreate A3DGraphicsCreate = null;
        public delegate A3DStatus PFA3DGraphicsDelete(IntPtr pGraphics);
        public static PFA3DGraphicsDelete A3DGraphicsDelete = null;
        public delegate A3DStatus PFA3DGlobalGetGraphStyleData(uint uiIndexStyle, ref A3DGraphStyleData pData);
        public static PFA3DGlobalGetGraphStyleData A3DGlobalGetGraphStyleData = null;
        public delegate A3DStatus PFA3DGlobalInsertGraphStyle(ref A3DGraphStyleData pData, out uint puiIndexStyle);
        public static PFA3DGlobalInsertGraphStyle A3DGlobalInsertGraphStyle = null;
        public delegate A3DStatus PFA3DGlobalGetGraphRgbColorData(uint uiIndexRgbColor, ref A3DGraphRgbColorData pData);
        public static PFA3DGlobalGetGraphRgbColorData A3DGlobalGetGraphRgbColorData = null;
        public delegate A3DStatus PFA3DGlobalInsertGraphRgbColor(ref A3DGraphRgbColorData pData, out uint puiIndexRgbColor);
        public static PFA3DGlobalInsertGraphRgbColor A3DGlobalInsertGraphRgbColor = null;
        public delegate A3DStatus PFA3DGlobalGetGraphLinePatternData(uint uiIndexLinePattern, ref A3DGraphLinePatternData pData);
        public static PFA3DGlobalGetGraphLinePatternData A3DGlobalGetGraphLinePatternData = null;
        public delegate A3DStatus PFA3DGlobalInsertGraphLinePattern(ref A3DGraphLinePatternData pData, out uint puiIndexLinePattern);
        public static PFA3DGlobalInsertGraphLinePattern A3DGlobalInsertGraphLinePattern = null;
        public delegate A3DStatus PFA3DGlobalGetGraphMaterialData(uint uiIndexMaterial, ref A3DGraphMaterialData pData);
        public static PFA3DGlobalGetGraphMaterialData A3DGlobalGetGraphMaterialData = null;
        public delegate A3DStatus PFA3DGlobalInsertGraphMaterial(ref A3DGraphMaterialData pData, out uint puiIndexMaterial);
        public static PFA3DGlobalInsertGraphMaterial A3DGlobalInsertGraphMaterial = null;
        public delegate A3DStatus PFA3DGlobalGetGraphPictureData(uint uiIndexPicture, ref A3DGraphPictureData pData);
        public static PFA3DGlobalGetGraphPictureData A3DGlobalGetGraphPictureData = null;
        public delegate A3DStatus PFA3DGlobalInsertGraphPicture(ref A3DGraphPictureData pData, out uint puiPictureIndex);
        public static PFA3DGlobalInsertGraphPicture A3DGlobalInsertGraphPicture = null;
        public delegate A3DStatus PFA3DGlobalGetGraphDottingPatternData(uint uiIndexDottingPattern, ref A3DGraphDottingPatternData pData);
        public static PFA3DGlobalGetGraphDottingPatternData A3DGlobalGetGraphDottingPatternData = null;
        public delegate A3DStatus PFA3DGlobalInsertGraphDottingPattern(ref A3DGraphDottingPatternData pData, out uint puiIndexDottingPattern);
        public static PFA3DGlobalInsertGraphDottingPattern A3DGlobalInsertGraphDottingPattern = null;
        public delegate A3DStatus PFA3DGlobalGetGraphHatchingPatternData(uint uiIndexHatchingPattern, ref A3DGraphHatchingPatternData pData);
        public static PFA3DGlobalGetGraphHatchingPatternData A3DGlobalGetGraphHatchingPatternData = null;
        public delegate A3DStatus PFA3DGlobalInsertGraphHatchingPattern(ref A3DGraphHatchingPatternData pData, out uint puiIndexHatchingPattern);
        public static PFA3DGlobalInsertGraphHatchingPattern A3DGlobalInsertGraphHatchingPattern = null;
        public delegate A3DStatus PFA3DGlobalGetGraphSolidPatternData(uint uiIndexSolidPattern, ref A3DGraphSolidPatternData pData);
        public static PFA3DGlobalGetGraphSolidPatternData A3DGlobalGetGraphSolidPatternData = null;
        public delegate A3DStatus PFA3DGlobalInsertGraphSolidPattern(ref A3DGraphSolidPatternData pData, out uint puiIndexSolidPattern);
        public static PFA3DGlobalInsertGraphSolidPattern A3DGlobalInsertGraphSolidPattern = null;
        public delegate A3DStatus PFA3DGlobalGetGraphVPicturePatternData(uint uiIndexVPicturePattern, ref A3DGraphVPicturePatternData pData);
        public static PFA3DGlobalGetGraphVPicturePatternData A3DGlobalGetGraphVPicturePatternData = null;
        public delegate A3DStatus PFA3DGlobalInsertGraphVPicturePattern(ref A3DGraphVPicturePatternData pData, out uint puiIndexVPicturePattern);
        public static PFA3DGlobalInsertGraphVPicturePattern A3DGlobalInsertGraphVPicturePattern = null;
        public delegate A3DStatus PFA3DGraphCameraGet(IntPtr pCamera, ref A3DGraphCameraData pData);
        public static PFA3DGraphCameraGet A3DGraphCameraGet = null;
        public delegate A3DStatus PFA3DGraphCameraCreate(ref A3DGraphCameraData pData, out IntPtr ppCamera);
        public static PFA3DGraphCameraCreate A3DGraphCameraCreate = null;
        public delegate A3DStatus PFA3DGraphAmbientLightGet(IntPtr pLight, ref A3DGraphAmbientLightData pData);
        public static PFA3DGraphAmbientLightGet A3DGraphAmbientLightGet = null;
        public delegate A3DStatus PFA3DGraphAmbientLightCreate(ref A3DGraphAmbientLightData pData, out IntPtr ppLight);
        public static PFA3DGraphAmbientLightCreate A3DGraphAmbientLightCreate = null;
        public delegate A3DStatus PFA3DGraphPointLightGet(IntPtr pLight, ref A3DGraphPointLightData pData);
        public static PFA3DGraphPointLightGet A3DGraphPointLightGet = null;
        public delegate A3DStatus PFA3DGraphPointLightCreate(ref A3DGraphPointLightData pData, out IntPtr ppLight);
        public static PFA3DGraphPointLightCreate A3DGraphPointLightCreate = null;
        public delegate A3DStatus PFA3DGraphSpotLightGet(IntPtr pLight, ref A3DGraphSpotLightData pData);
        public static PFA3DGraphSpotLightGet A3DGraphSpotLightGet = null;
        public delegate A3DStatus PFA3DGraphSpotLightCreate(ref A3DGraphSpotLightData pData, out IntPtr ppLight);
        public static PFA3DGraphSpotLightCreate A3DGraphSpotLightCreate = null;
        public delegate A3DStatus PFA3DGraphDirectionalLightGet(IntPtr pLight, ref A3DGraphDirectionalLightData pData);
        public static PFA3DGraphDirectionalLightGet A3DGraphDirectionalLightGet = null;
        public delegate A3DStatus PFA3DGraphDirectionalLightCreate(ref A3DGraphDirectionalLightData pData, out IntPtr ppLight);
        public static PFA3DGraphDirectionalLightCreate A3DGraphDirectionalLightCreate = null;
        public delegate A3DStatus PFA3DGraphSceneDisplayParametersGet(IntPtr pSceneDisplayParameters, ref A3DGraphSceneDisplayParametersData pData);
        public static PFA3DGraphSceneDisplayParametersGet A3DGraphSceneDisplayParametersGet = null;
        public delegate A3DStatus PFA3DGraphSceneDisplayParametersCreate(ref A3DGraphSceneDisplayParametersData pData, out IntPtr ppSceneDisplayParameters);
        public static PFA3DGraphSceneDisplayParametersCreate A3DGraphSceneDisplayParametersCreate = null;
        public delegate A3DStatus PFA3DMiscCascadedAttributesCreate(out IntPtr ppAttr);
        public static PFA3DMiscCascadedAttributesCreate A3DMiscCascadedAttributesCreate = null;
        public delegate A3DStatus PFA3DMiscCascadedAttributesDelete(IntPtr pAttr);
        public static PFA3DMiscCascadedAttributesDelete A3DMiscCascadedAttributesDelete = null;
        public delegate A3DStatus PFA3DMiscCascadedAttributesGet(IntPtr pAttr, ref A3DMiscCascadedAttributesData psData);
        public static PFA3DMiscCascadedAttributesGet A3DMiscCascadedAttributesGet = null;
        public delegate A3DStatus PFA3DMiscCascadedAttributesPush(IntPtr pAttr, IntPtr pBase, IntPtr pFather);
        public static PFA3DMiscCascadedAttributesPush A3DMiscCascadedAttributesPush = null;
        public delegate A3DStatus PFA3DMiscCascadedAttributesPushTessFace(IntPtr pAttr, IntPtr pRepItem, IntPtr pTessBase, ref A3DTessFaceData psTessFaceData, uint uiFaceIndex, IntPtr pFather);
        public static PFA3DMiscCascadedAttributesPushTessFace A3DMiscCascadedAttributesPushTessFace = null;
        public delegate A3DStatus PFA3DMiscCascadedAttributesEntityReferencePush(IntPtr pAttr, IntPtr pOccurrence, out IntPtr ppPtr);
        public static PFA3DMiscCascadedAttributesEntityReferencePush A3DMiscCascadedAttributesEntityReferencePush = null;
        public delegate A3DStatus PFA3DMiscPointerFromIndexGet(uint uiIndex, A3DEEntityType eType, out IntPtr ppEntity);
        public static PFA3DMiscPointerFromIndexGet A3DMiscPointerFromIndexGet = null;
        public delegate A3DStatus PFA3DMiscRootBaseInsertAttribute(IntPtr pRootBase, IntPtr pAttribute);
        public static PFA3DMiscRootBaseInsertAttribute A3DMiscRootBaseInsertAttribute = null;
        public delegate A3DStatus PFA3DMiscGeneralTransformationGet(IntPtr pGeneralTransformation3d, ref A3DMiscGeneralTransformationData pData);
        public static PFA3DMiscGeneralTransformationGet A3DMiscGeneralTransformationGet = null;
        public delegate A3DStatus PFA3DMiscGeneralTransformationCreate(ref A3DMiscGeneralTransformationData pData, out IntPtr ppGeneralTransformation3d);
        public static PFA3DMiscGeneralTransformationCreate A3DMiscGeneralTransformationCreate = null;
        public delegate A3DStatus PFA3DMiscCartesianTransformationGet(IntPtr pCartesianTransformation3d, ref A3DMiscCartesianTransformationData pData);
        public static PFA3DMiscCartesianTransformationGet A3DMiscCartesianTransformationGet = null;
        public delegate A3DStatus PFA3DMiscCartesianTransformationCreate(ref A3DMiscCartesianTransformationData pData, out IntPtr ppCartesianTransformation3d);
        public static PFA3DMiscCartesianTransformationCreate A3DMiscCartesianTransformationCreate = null;
        public delegate A3DStatus PFA3DMiscEntityReferenceGet(IntPtr pEntityReference, ref A3DMiscEntityReferenceData pData);
        public static PFA3DMiscEntityReferenceGet A3DMiscEntityReferenceGet = null;
        public delegate A3DStatus PFA3DMiscEntityReferenceCreate(ref A3DMiscEntityReferenceData pData, out IntPtr ppEntityReference);
        public static PFA3DMiscEntityReferenceCreate A3DMiscEntityReferenceCreate = null;
        public delegate A3DStatus PFA3DMiscEntityReferenceSet(IntPtr pEntityReference, ref A3DMiscEntityReferenceData pData);
        public static PFA3DMiscEntityReferenceSet A3DMiscEntityReferenceSet = null;
        public delegate A3DStatus PFA3DMiscReferenceOnTopologyGet(IntPtr pReferenceOnTopoItem, ref A3DMiscReferenceOnTopologyData pData);
        public static PFA3DMiscReferenceOnTopologyGet A3DMiscReferenceOnTopologyGet = null;
        public delegate A3DStatus PFA3DMiscReferenceOnTessGet(IntPtr pReferenceOnTess, ref A3DMiscReferenceOnTessData pData);
        public static PFA3DMiscReferenceOnTessGet A3DMiscReferenceOnTessGet = null;
        public delegate A3DStatus PFA3DMiscReferenceOnTessCreate(ref A3DMiscReferenceOnTessData pData, out IntPtr ppReferenceOnTess);
        public static PFA3DMiscReferenceOnTessCreate A3DMiscReferenceOnTessCreate = null;
        public delegate A3DStatus PFA3DMiscReferenceOnTopologyCreate(ref A3DMiscReferenceOnTopologyData pData, out IntPtr ppReferenceOnTopoItem);
        public static PFA3DMiscReferenceOnTopologyCreate A3DMiscReferenceOnTopologyCreate = null;
        public delegate A3DStatus PFA3DMiscReferenceOnCsysItemGet(IntPtr pReferenceOnCSYSItem, ref A3DMiscReferenceOnCsysItemData pData);
        public static PFA3DMiscReferenceOnCsysItemGet A3DMiscReferenceOnCsysItemGet = null;
        public delegate A3DStatus PFA3DMiscReferenceOnCsysItemCreate(ref A3DMiscReferenceOnCsysItemData pData, out IntPtr ppReferenceOnCSYSItem);
        public static PFA3DMiscReferenceOnCsysItemCreate A3DMiscReferenceOnCsysItemCreate = null;
        public delegate A3DStatus PFA3DMiscUTF8ToUnicode([MarshalAs(UnmanagedType.LPStr)] string pcInputBuffer, IntPtr acOutputBuffer);
        public static PFA3DMiscUTF8ToUnicode A3DMiscUTF8ToUnicode = null;
        public delegate A3DStatus PFA3DMiscUnicodeToUTF8([MarshalAs(UnmanagedType.LPStr)] string pcInputBuffer, IntPtr acOutputBuffer);
        public static PFA3DMiscUnicodeToUTF8 A3DMiscUnicodeToUTF8 = null;
        public delegate A3DStatus PFA3DMiscUTF8ToUTF16([MarshalAs(UnmanagedType.LPStr)] string pcInputBuffer, IntPtr acOutputBuffer);
        public static PFA3DMiscUTF8ToUTF16 A3DMiscUTF8ToUTF16 = null;
        public delegate A3DStatus PFA3DMiscUTF16ToUTF8([MarshalAs(UnmanagedType.LPStr)] string pcInputBuffer, IntPtr acOutputBuffer);
        public static PFA3DMiscUTF16ToUTF8 A3DMiscUTF16ToUTF8 = null;
        public delegate IntPtr PFA3DMiscGetErrorMsg(A3DStatus arg1);
        public static PFA3DMiscGetErrorMsg A3DMiscGetErrorMsg = null;
        public delegate IntPtr PFA3DMiscGetEntityTypeMsg(A3DEEntityType eType);
        public static PFA3DMiscGetEntityTypeMsg A3DMiscGetEntityTypeMsg = null;
        public delegate A3DStatus PFA3DMiscGetMaterialProperties(IntPtr pEntity, ref A3DMiscMaterialPropertiesData pMaterialPropertiesData);
        public static PFA3DMiscGetMaterialProperties A3DMiscGetMaterialProperties = null;
        public delegate A3DStatus PFA3DMiscGetBoundingBox(IntPtr pEntity, ref A3DBoundingBoxData pAABB);
        public static PFA3DMiscGetBoundingBox A3DMiscGetBoundingBox = null;
        public delegate A3DStatus PFA3DMiscComputeBoundingBox(IntPtr pEntity, out double pOptPlacement, ref A3DBoundingBoxData pAABB);
        public static PFA3DMiscComputeBoundingBox A3DMiscComputeBoundingBox = null;
        public delegate A3DStatus PFA3DAsmModelFileGet(IntPtr pModelFile, ref A3DAsmModelFileData pData);
        public static PFA3DAsmModelFileGet A3DAsmModelFileGet = null;
        public delegate A3DStatus PFA3DAsmModelFileCreate(ref A3DAsmModelFileData pData, out IntPtr ppModelFile);
        public static PFA3DAsmModelFileCreate A3DAsmModelFileCreate = null;
        public delegate A3DStatus PFA3DAsmModelFileDelete(IntPtr pModelFile);
        public static PFA3DAsmModelFileDelete A3DAsmModelFileDelete = null;
        public delegate A3DStatus PFA3DAsmModelFileUnloadParts(IntPtr pModelFile, uint uiPartsSize, out IntPtr ppParts);
        public static PFA3DAsmModelFileUnloadParts A3DAsmModelFileUnloadParts = null;
        public delegate A3DStatus PFA3DAsmModelFileGetUnit(IntPtr pModelFile, out double pdUnit);
        public static PFA3DAsmModelFileGetUnit A3DAsmModelFileGetUnit = null;
        public delegate A3DStatus PFA3DAsmProductOccurrenceGet(IntPtr pProductOccurrence, ref A3DAsmProductOccurrenceData pData);
        public static PFA3DAsmProductOccurrenceGet A3DAsmProductOccurrenceGet = null;
        public delegate A3DStatus PFA3DAsmProductOccurrenceCreate(ref A3DAsmProductOccurrenceData pData, out IntPtr ppProductOccurrence);
        public static PFA3DAsmProductOccurrenceCreate A3DAsmProductOccurrenceCreate = null;
        public delegate A3DStatus PFA3DAsmProductOccurrenceSetProductPrototype(IntPtr pProductOccurrence, IntPtr pProductPrototype);
        public static PFA3DAsmProductOccurrenceSetProductPrototype A3DAsmProductOccurrenceSetProductPrototype = null;
        public delegate A3DStatus PFA3DAsmProductOccurrenceUnload(IntPtr pProductOccurrence);
        public static PFA3DAsmProductOccurrenceUnload A3DAsmProductOccurrenceUnload = null;
        public delegate A3DStatus PFA3DAsmProductOccurrenceGetFilePathName(IntPtr pProductOccurrence, IntPtr ppcFileName);
        public static PFA3DAsmProductOccurrenceGetFilePathName A3DAsmProductOccurrenceGetFilePathName = null;
        public delegate A3DStatus PFA3DAsmProductOccurrenceGetOriginalFilePathName(IntPtr pProductOccurrence, IntPtr ppcFileName);
        public static PFA3DAsmProductOccurrenceGetOriginalFilePathName A3DAsmProductOccurrenceGetOriginalFilePathName = null;
        public delegate A3DStatus PFA3DAsmProductOccurrenceAddView(IntPtr pProductOccurrence, IntPtr pView);
        public static PFA3DAsmProductOccurrenceAddView A3DAsmProductOccurrenceAddView = null;
        public delegate A3DStatus PFA3DAsmProductOccurrenceEdit(ref A3DAsmProductOccurrenceData pData, IntPtr pProductOccurrence);
        public static PFA3DAsmProductOccurrenceEdit A3DAsmProductOccurrenceEdit = null;
        public delegate A3DStatus PFA3DAsmProductOccurrenceDeepCopy(IntPtr pProductOccurrence, out IntPtr ppNewProductOccurrence);
        public static PFA3DAsmProductOccurrenceDeepCopy A3DAsmProductOccurrenceDeepCopy = null;
        public delegate A3DStatus PFA3DAsmProductOccurrenceGetFather(IntPtr pProductOccurrence, out IntPtr ppProductOccurrenceFather);
        public static PFA3DAsmProductOccurrenceGetFather A3DAsmProductOccurrenceGetFather = null;
        public delegate A3DStatus PFA3DAsmProductOccurrenceGetSLW(IntPtr pProductOccurrence, ref A3DAsmProductOccurrenceDataSLW pData);
        public static PFA3DAsmProductOccurrenceGetSLW A3DAsmProductOccurrenceGetSLW = null;
        public delegate A3DStatus PFA3DAsmProductOccurrenceGetCat(IntPtr pProductOccurrence, ref A3DAsmProductOccurrenceDataCat pData);
        public static PFA3DAsmProductOccurrenceGetCat A3DAsmProductOccurrenceGetCat = null;
        public delegate A3DStatus PFA3DAsmProductOccurrenceGetCV5(IntPtr pProductOccurrence, ref A3DAsmProductOccurrenceDataCV5 pData);
        public static PFA3DAsmProductOccurrenceGetCV5 A3DAsmProductOccurrenceGetCV5 = null;
        public delegate A3DStatus PFA3DAsmProductOccurrenceGetUg(IntPtr pProductOccurrence, ref A3DAsmProductOccurrenceDataUg pData);
        public static PFA3DAsmProductOccurrenceGetUg A3DAsmProductOccurrenceGetUg = null;
        public delegate A3DStatus PFA3DAsmProductOccurrenceGetProe(IntPtr pProductOccurrence, ref A3DAsmProductOccurrenceDataProe pData);
        public static PFA3DAsmProductOccurrenceGetProe A3DAsmProductOccurrenceGetProe = null;
        public delegate A3DStatus PFA3DAsmProductOccurrenceGetInv(IntPtr pProductOccurrence, ref A3DAsmProductOccurrenceDataInv pData);
        public static PFA3DAsmProductOccurrenceGetInv A3DAsmProductOccurrenceGetInv = null;
        public delegate A3DStatus PFA3DAsmProductOccurrenceGetJT(IntPtr pProductOccurrence, ref A3DAsmProductOccurrenceDataJT pData);
        public static PFA3DAsmProductOccurrenceGetJT A3DAsmProductOccurrenceGetJT = null;
        public delegate A3DStatus PFA3DAsmProductOccurrenceGetLayerList(IntPtr pProductOccurrence, out uint piLayers, IntPtr ppLayerArray);
        public static PFA3DAsmProductOccurrenceGetLayerList A3DAsmProductOccurrenceGetLayerList = null;
        public delegate A3DStatus PFA3DAsmProductOccurrenceGetIdentifier(IntPtr pProductOccurrence, IntPtr ppcIdentifier);
        public static PFA3DAsmProductOccurrenceGetIdentifier A3DAsmProductOccurrenceGetIdentifier = null;
        public delegate A3DStatus PFA3DAsmPartDefinitionGet(IntPtr pPartDefinition, ref A3DAsmPartDefinitionData pData);
        public static PFA3DAsmPartDefinitionGet A3DAsmPartDefinitionGet = null;
        public delegate A3DStatus PFA3DAsmPartDefinitionCreate(ref A3DAsmPartDefinitionData pData, out IntPtr ppPartDefinition);
        public static PFA3DAsmPartDefinitionCreate A3DAsmPartDefinitionCreate = null;
        public delegate A3DStatus PFA3DDrawingGetReferencesList(IntPtr pPartDefinition, out uint puiNumberOfFilePaths, IntPtr pppcSrcFilePaths);
        public static PFA3DDrawingGetReferencesList A3DDrawingGetReferencesList = null;
        public delegate A3DStatus PFA3DAsmPartDefinitionAddView(IntPtr pPartDefinition, IntPtr pView);
        public static PFA3DAsmPartDefinitionAddView A3DAsmPartDefinitionAddView = null;
        public delegate A3DStatus PFA3DAsmPartDefinitionEdit(ref A3DAsmPartDefinitionData pData, IntPtr pPartDefinition);
        public static PFA3DAsmPartDefinitionEdit A3DAsmPartDefinitionEdit = null;
        public delegate A3DStatus PFA3DAsmFilterGet(IntPtr pFilter, ref A3DAsmFilterData pData);
        public static PFA3DAsmFilterGet A3DAsmFilterGet = null;
        public delegate A3DStatus PFA3DAsmFilterCreate(ref A3DAsmFilterData pData, out IntPtr ppFilter);
        public static PFA3DAsmFilterCreate A3DAsmFilterCreate = null;
        public delegate A3DStatus PFA3DAsmGetFixedComponents(IntPtr pOwnerNode, out uint puiNumberOfFixedSubNodes, IntPtr pppFixedSubNodes);
        public static PFA3DAsmGetFixedComponents A3DAsmGetFixedComponents = null;
        public delegate A3DStatus PFA3DAsmGetFixedTogetherComponents(IntPtr pOwnerNode, out uint ppuiSizeCount, IntPtr ppuiSizeArray, IntPtr pppFixedTogetherNodes);
        public static PFA3DAsmGetFixedTogetherComponents A3DAsmGetFixedTogetherComponents = null;
        public delegate A3DStatus PFA3DAsmGetFlexibleComponents(IntPtr pOwnerNode, out uint puiNumberOfFlexibleSubNodes, IntPtr pppFlexibleSubNodes);
        public static PFA3DAsmGetFlexibleComponents A3DAsmGetFlexibleComponents = null;
        public delegate A3DStatus PFA3DAsmModelFileLoadFromFile([MarshalAs(UnmanagedType.LPStr)] string pcFileName, ref A3DRWParamsLoadData pLoadParametersData, out IntPtr ppModelFile);
        public static PFA3DAsmModelFileLoadFromFile A3DAsmModelFileLoadFromFile = null;
        public delegate A3DStatus PFA3DAsmModelFileLoadFromPrcStream([MarshalAs(UnmanagedType.LPStr)] string pcBufferStream, uint uBufferLength, out IntPtr ppPrcReadHelper, out IntPtr ppModelFile);
        public static PFA3DAsmModelFileLoadFromPrcStream A3DAsmModelFileLoadFromPrcStream = null;
        public delegate void PFA3DRWParamsPrcReadHelperFree(IntPtr pA3DRWParamsPrcReadHelper);
        public static PFA3DRWParamsPrcReadHelperFree A3DRWParamsPrcReadHelperFree = null;
        public delegate A3DStatus PFA3DAsmModelFileLoadFromPrcFile([MarshalAs(UnmanagedType.LPStr)] string pcFileName, out IntPtr ppPrcReadHelper, out IntPtr ppModelFile);
        public static PFA3DAsmModelFileLoadFromPrcFile A3DAsmModelFileLoadFromPrcFile = null;
        public delegate A3DStatus PFA3DGet3DPDFStreams([MarshalAs(UnmanagedType.LPStr)] string pcFileName, IntPtr ppStreamData, out int piNumStreams);
        public static PFA3DGet3DPDFStreams A3DGet3DPDFStreams = null;
        public delegate A3DStatus PFA3DAsmModelFileExportToPrcFile(IntPtr pA3DAsmModelFile, ref A3DRWParamsExportPrcData pParamsExportData, [MarshalAs(UnmanagedType.LPStr)] string pcCADFileName, out IntPtr ppPrcWriteHelper);
        public static PFA3DAsmModelFileExportToPrcFile A3DAsmModelFileExportToPrcFile = null;
        public delegate void PFA3DRWParamsPrcWriteHelperFree(IntPtr pA3DRWParamsPrcWriteHelper);
        public static PFA3DRWParamsPrcWriteHelperFree A3DRWParamsPrcWriteHelperFree = null;
        public delegate A3DStatus PFA3DAsmModelFileExportToU3DFile(IntPtr pA3DAsmModelFile, ref A3DRWParamsExportU3DData pParamsExportData, [MarshalAs(UnmanagedType.LPStr)] string pcCADFileName);
        public static PFA3DAsmModelFileExportToU3DFile A3DAsmModelFileExportToU3DFile = null;
        public delegate A3DStatus PFA3DAsmModelFileExportToStepFile(IntPtr pA3DAsmModelFile, ref A3DRWParamsExportStepData pParamsExportData, [MarshalAs(UnmanagedType.LPStr)] string pcCADFileName);
        public static PFA3DAsmModelFileExportToStepFile A3DAsmModelFileExportToStepFile = null;
        public delegate A3DStatus PFA3DAsmModelFileExportToJTFile(IntPtr pA3DAsmModelFile, ref A3DRWParamsExportJTData pParamsExportData, [MarshalAs(UnmanagedType.LPStr)] string pcCADFileName);
        public static PFA3DAsmModelFileExportToJTFile A3DAsmModelFileExportToJTFile = null;
        public delegate A3DStatus PFA3DAsmModelFileExportToVrmlFile(IntPtr pA3DAsmModelFile, [MarshalAs(UnmanagedType.LPStr)] string pcCADFileName);
        public static PFA3DAsmModelFileExportToVrmlFile A3DAsmModelFileExportToVrmlFile = null;
        public delegate A3DStatus PFA3DAsmModelFileExportToIgesFile(IntPtr pA3DAsmModelFile, ref A3DRWParamsExportIgesData pParamsExportData, [MarshalAs(UnmanagedType.LPStr)] string pcCADFileName);
        public static PFA3DAsmModelFileExportToIgesFile A3DAsmModelFileExportToIgesFile = null;
        public delegate A3DStatus PFA3DAsmModelFileExportToStlFile(IntPtr pA3DAsmModelFile, ref A3DRWParamsExportStlData pParamsExportData, [MarshalAs(UnmanagedType.LPStr)] string pcCADFileName);
        public static PFA3DAsmModelFileExportToStlFile A3DAsmModelFileExportToStlFile = null;
        public delegate A3DStatus PFA3DAsmModelFileExportTo3mfFile(IntPtr pA3DAsmModelFile, ref A3DRWParamsExport3mfData pParamsExportData, [MarshalAs(UnmanagedType.LPStr)] string pcCADFileName);
        public static PFA3DAsmModelFileExportTo3mfFile A3DAsmModelFileExportTo3mfFile = null;
        public delegate A3DStatus PFA3DAsmModelFileExportToXMLFile(IntPtr pA3DAsmModelFile, ref A3DRWParamsExportXMLData pParamsExportData, [MarshalAs(UnmanagedType.LPStr)] string pcXMLFileName, IntPtr uMapSize, IntPtr puMapXmlIds, IntPtr ppMapProductOccurrences);
        public static PFA3DAsmModelFileExportToXMLFile A3DAsmModelFileExportToXMLFile = null;
        public delegate A3DStatus PFA3DAsmModelFileExportToObjFile(IntPtr pA3DAsmModelFile, ref A3DRWParamsExportObjData pParamsExportData, [MarshalAs(UnmanagedType.LPStr)] string pcCADFileName);
        public static PFA3DAsmModelFileExportToObjFile A3DAsmModelFileExportToObjFile = null;
        public delegate A3DStatus PFA3DAsmModelFileExportToFbxFile(IntPtr pA3DAsmModelFile, ref A3DRWParamsExportFbxData pParamsExportData, [MarshalAs(UnmanagedType.LPStr)] string pcCADFileName);
        public static PFA3DAsmModelFileExportToFbxFile A3DAsmModelFileExportToFbxFile = null;
        public delegate A3DStatus PFA3DCrvGetInterval(IntPtr pCrv, ref A3DIntervalData pInterval);
        public static PFA3DCrvGetInterval A3DCrvGetInterval = null;
        public delegate A3DStatus PFA3DCrvEvaluate(IntPtr pCrv, double dParameter, uint uiNbDerivatives, ref A3DVector3dData pPointAndDerivatives);
        public static PFA3DCrvEvaluate A3DCrvEvaluate = null;
        public delegate A3DStatus PFA3DCrvEvaluatePointAndNormal(IntPtr psCrv, double dParameter, uint uiNbSurfaces, out IntPtr ppsSurfaces, uint uiNbDerivatives, ref A3DVector3dData psPointAndDerivatives, ref A3DVector3dData psNormal);
        public static PFA3DCrvEvaluatePointAndNormal A3DCrvEvaluatePointAndNormal = null;
        public delegate A3DStatus PFA3DCrvIsPeriodic(IntPtr pCrv, out bool pbIsPeriodic);
        public static PFA3DCrvIsPeriodic A3DCrvIsPeriodic = null;
        public delegate A3DStatus PFA3DSrfGetDomain(IntPtr pSrf, ref A3DDomainData pDomain);
        public static PFA3DSrfGetDomain A3DSrfGetDomain = null;
        public delegate A3DStatus PFA3DSurfEvaluate(IntPtr pSurf, ref A3DVector2dData pUVParameter, uint uiNbDerivatives, ref A3DVector3dData pPointAndDerivatives);
        public static PFA3DSurfEvaluate A3DSurfEvaluate = null;
        public delegate A3DStatus PFA3DSurfIsDegenerated(IntPtr pSurf, ref A3DVector2dData pUVParameter, double dTolerance, out bool pbIsDegenerated, out bool pbUDirection);
        public static PFA3DSurfIsDegenerated A3DSurfIsDegenerated = null;
        public delegate A3DStatus PFA3DSurfIsPeriodic(IntPtr pSrf, out bool pbUIsPeriodic, out bool pbVIsPeriodic);
        public static PFA3DSurfIsPeriodic A3DSurfIsPeriodic = null;
        public delegate A3DStatus PFA3DSurfIsG1Continuous(IntPtr pSurf, ref A3DVector2dData pUVParameter, double dAngleTolerance, out bool pbUG1Continuous, out bool pbVG1Continuous);
        public static PFA3DSurfIsG1Continuous A3DSurfIsG1Continuous = null;
        public delegate A3DStatus PFA3DGetCurveAsAnalytic(IntPtr pCurve, double dTol, out IntPtr pAnalyticCurve, ref A3DEAnalyticType peAnalyticType);
        public static PFA3DGetCurveAsAnalytic A3DGetCurveAsAnalytic = null;
        public delegate A3DStatus PFA3DSimplifyCurveWithAnalytics(IntPtr pCurve, double dTol, uint uNbRecognizedType, IntPtr pOptRecognizedType, out IntPtr pAnalyticCurve, ref A3DEAnalyticType peAnalyticType);
        public static PFA3DSimplifyCurveWithAnalytics A3DSimplifyCurveWithAnalytics = null;
        public delegate A3DStatus PFA3DGetCurveAsAnalyticFromCoEdge(IntPtr pCoEdge, double dTol, out IntPtr pAnalyticCurve, ref A3DEAnalyticType peAnalyticType);
        public static PFA3DGetCurveAsAnalyticFromCoEdge A3DGetCurveAsAnalyticFromCoEdge = null;
        public delegate A3DStatus PFA3DSimplifyCurveWithAnalyticsFromCoEdge(IntPtr pCoEdge, double dTol, uint uNbRecognizedType, IntPtr pOptRecognizedType, out IntPtr pAnalyticCurve, ref A3DEAnalyticType peAnalyticType);
        public static PFA3DSimplifyCurveWithAnalyticsFromCoEdge A3DSimplifyCurveWithAnalyticsFromCoEdge = null;
        public delegate A3DStatus PFA3DGetSurfaceAsAnalytic(IntPtr pSrf, double dTol, out IntPtr pAnalyticSurface, ref A3DEAnalyticType peAnalyticType);
        public static PFA3DGetSurfaceAsAnalytic A3DGetSurfaceAsAnalytic = null;
        public delegate A3DStatus PFA3DSimplifySurfaceWithAnalytics(IntPtr pSrf, double dTol, uint uNbRecognizedType, IntPtr pOptRecognizedType, out IntPtr pAnalyticSurface, ref A3DEAnalyticType peAnalyticType);
        public static PFA3DSimplifySurfaceWithAnalytics A3DSimplifySurfaceWithAnalytics = null;
        public delegate A3DStatus PFA3DCrvProjectPoint(IntPtr pCrv, ref A3DVector3dData pPointToProject, out uint puiNbSolutions, IntPtr ppdSolutionParameter, IntPtr ppdSolutionDistance);
        public static PFA3DCrvProjectPoint A3DCrvProjectPoint = null;
        public delegate A3DStatus PFA3DSurfProjectPoint(IntPtr pSurf, ref A3DVector3dData pPointToProject, out uint puiNbSolutions, IntPtr ppdSolutionParameters, IntPtr ppdSolutionDistance);
        public static PFA3DSurfProjectPoint A3DSurfProjectPoint = null;
        public delegate A3DStatus PFA3DCrvLocalProjectPoint(IntPtr pCrv, ref A3DVector3dData pPointToProject, double dGuessParameter, out bool pbFindSolution, out double pdSolutionParameter, out double pdSolutionDistance);
        public static PFA3DCrvLocalProjectPoint A3DCrvLocalProjectPoint = null;
        public delegate A3DStatus PFA3DSurfLocalProjectPoint(IntPtr pSurf, ref A3DVector3dData pPointToProject, ref A3DVector2dData pGuessPoint, out bool pbFindSolution, ref A3DVector2dData pSolutionParameter, out double pdSolutionDistance);
        public static PFA3DSurfLocalProjectPoint A3DSurfLocalProjectPoint = null;
        public delegate A3DStatus PFA3DSurfEvaluateNormal(IntPtr pSurf, ref A3DVector2dData pUVParameter, ref A3DVector3dData pNormal);
        public static PFA3DSurfEvaluateNormal A3DSurfEvaluateNormal = null;
        public delegate A3DStatus PFA3DSewBrep(IntPtr p, uint uNbBrepModels, double dTolerance, ref A3DSewOptionsData pData, IntPtr pBrepModelsOut, out uint uNbBrepOut);
        public static PFA3DSewBrep A3DSewBrep = null;
        public delegate A3DStatus PFA3DAsmModelFileSew(out IntPtr ppModelFile, double dToleranceInMM, ref A3DSewOptionsData pData);
        public static PFA3DAsmModelFileSew A3DAsmModelFileSew = null;
        public delegate A3DStatus PFA3DFaceUVPointInsideManagerCreate(ref A3DFaceUVPointInsideManagerData pData, out IntPtr pManager);
        public static PFA3DFaceUVPointInsideManagerCreate A3DFaceUVPointInsideManagerCreate = null;
        public delegate A3DStatus PFA3DFaceUVPointInsideManagerDelete(IntPtr pManager);
        public static PFA3DFaceUVPointInsideManagerDelete A3DFaceUVPointInsideManagerDelete = null;
        public delegate A3DStatus PFA3DFaceUVPointInside(IntPtr pManager, IntPtr psFace, ref A3DVector2dData pUVParameter, double dTol3D, out byte puiUVInFace);
        public static PFA3DFaceUVPointInside A3DFaceUVPointInside = null;
        public delegate A3DStatus PFA3DProjectPointCloud(uint uRiBrepModelSize, out IntPtr pRiBrepModel, uint uPointCloudSize, ref A3DVector3dData pPointCloudToProject, bool bUseExactComputation, uint uNbThreads, IntPtr ppProjectedPointCloud);
        public static PFA3DProjectPointCloud A3DProjectPointCloud = null;
        public delegate A3DStatus PFA3DProjectPointCloudManagerCreateFromRI(ref A3DProjectPointCloudManagerDataFromRI pData, out IntPtr pManager);
        public static PFA3DProjectPointCloudManagerCreateFromRI A3DProjectPointCloudManagerCreateFromRI = null;
        public delegate A3DStatus PFA3DProjectPointCloudManagerCreateFromModelFile(IntPtr pModelFile, out IntPtr pManager);
        public static PFA3DProjectPointCloudManagerCreateFromModelFile A3DProjectPointCloudManagerCreateFromModelFile = null;
        public delegate A3DStatus PFA3DProjectPointCloudManagerDelete(IntPtr pManager);
        public static PFA3DProjectPointCloudManagerDelete A3DProjectPointCloudManagerDelete = null;
        public delegate A3DStatus PFA3DProjectPointCloud2(IntPtr pManager, uint uPointCloudSize, ref A3DVector3dData pPointCloudToProject, bool bUseExactComputation, uint uNbThreads, double dInsidePointEdgeTolerance, IntPtr ppProjectedPointCloud);
        public static PFA3DProjectPointCloud2 A3DProjectPointCloud2 = null;
        public delegate A3DStatus PFA3DComputePlanarSectionOnRepresentationItem(IntPtr pRiBrepModel, ref A3DPlanarSectionData psSectionParametersData, out IntPtr ppRISectionResults);
        public static PFA3DComputePlanarSectionOnRepresentationItem A3DComputePlanarSectionOnRepresentationItem = null;
        public delegate A3DStatus PFA3DComputePlanarSectionOnModelFile(IntPtr pModelFile, ref A3DPlanarSectionData psSectionParametersData, out uint pNumberOfSections, IntPtr pppRISectionElements);
        public static PFA3DComputePlanarSectionOnModelFile A3DComputePlanarSectionOnModelFile = null;
        public delegate A3DStatus PFA3DCurveLength(IntPtr pCrv, ref A3DIntervalData pOptInterval, out double pdLength);
        public static PFA3DCurveLength A3DCurveLength = null;
        public delegate A3DStatus PFA3DCompareFaces(ref A3DCompareInputData pInput, ref A3DCompareOutputData pOutput);
        public static PFA3DCompareFaces A3DCompareFaces = null;
        public delegate A3DStatus PFA3DCompareFacesInBrepModels(IntPtr pFirstModelFile, IntPtr pSecondModelFile, double dTolerance, ref A3DCompareOutputData pOutput);
        public static PFA3DCompareFacesInBrepModels A3DCompareFacesInBrepModels = null;
        public delegate A3DStatus PFA3DCutWithMultiPlanarSectionOnRepresentationItems(uint uiNbRepItems, out IntPtr apRepItems, IntPtr pOptPlacements, ref A3DMultiPlanarSectionData psSectionParametersData, out uint pNumberOfRepItems, IntPtr pppRIRepresentationItem, IntPtr pppRIPlanarSections);
        public static PFA3DCutWithMultiPlanarSectionOnRepresentationItems A3DCutWithMultiPlanarSectionOnRepresentationItems = null;
        public delegate A3DStatus PFA3DCutWithMultiPlanarSectionOnModelFile(IntPtr pModelFile, IntPtr pOptMrkRView, ref A3DMultiPlanarSectionData psSectionParametersData, out uint pNumberOfRepItems, IntPtr pppRIRepresentationItem, IntPtr pppRIPlanarSections);
        public static PFA3DCutWithMultiPlanarSectionOnModelFile A3DCutWithMultiPlanarSectionOnModelFile = null;
        public delegate A3DStatus PFA3DComputeOrthoHLROnRepresentationItems(uint uiNbRepItems, out IntPtr apRepItems, IntPtr pOptPlacements, ref A3DHLRViewPlaneData psHLRViewPlaneData, out uint pNumberHLRData, IntPtr pppHLRData);
        public static PFA3DComputeOrthoHLROnRepresentationItems A3DComputeOrthoHLROnRepresentationItems = null;
        public delegate A3DStatus PFA3DComputeOrthoHLROnModelFile(IntPtr pModelFile, IntPtr pOptMrkRView, ref A3DHLRViewPlaneData psHLRViewPlaneData, out uint pNumberHLRData, IntPtr pppHLRData);
        public static PFA3DComputeOrthoHLROnModelFile A3DComputeOrthoHLROnModelFile = null;
        public delegate A3DStatus PFA3DComputeOrthoHLROnModelFile2(IntPtr pModelFile, IntPtr pOptMrkRView, ref A3DHLRViewPlaneData psHLRViewPlaneData, out uint pNumberHLRRepItem, IntPtr pppHLRRepItem);
        public static PFA3DComputeOrthoHLROnModelFile2 A3DComputeOrthoHLROnModelFile2 = null;
        public delegate A3DStatus PFA3DComputeOrthoHLROnModelFile3(IntPtr pModelFile, IntPtr pOptMrkRView, ref A3DHLRViewPlaneData psHLRViewPlaneData, ref A3DHLROptionsData psHLROptionsData, out uint pNumberHLRRepItem, IntPtr ppHLRRepItems);
        public static PFA3DComputeOrthoHLROnModelFile3 A3DComputeOrthoHLROnModelFile3 = null;
        public delegate A3DStatus PFA3DHLRRepresentationItemGet(IntPtr pHLRRepItem, ref A3DHLRRepresentationItemData psRIData);
        public static PFA3DHLRRepresentationItemGet A3DHLRRepresentationItemGet = null;
        public delegate void PFA3DDllActivateXMLTrace(bool activate);
        public static PFA3DDllActivateXMLTrace A3DDllActivateXMLTrace = null;
        public delegate A3DStatus PFA3DXmlParsing(IntPtr pModelfile, [MarshalAs(UnmanagedType.LPStr)] string pcFileName);
        public static PFA3DXmlParsing A3DXmlParsing = null;
        public delegate A3DStatus PFA3DCollisionCompute(ref A3DCollisionGroupData pGroup1, ref A3DCollisionGroupData pGroup2, ref A3DCollisionParameterData pParameterData, out uint uCollisionResultsSize, IntPtr pCollisionResults);
        public static PFA3DCollisionCompute A3DCollisionCompute = null;
        public delegate A3DStatus PFA3DDllInitialize(int iMajorVersion, int iMinorVersion);
        public static PFA3DDllInitialize A3DDllInitialize = null;
        public delegate A3DStatus PFA3DDllGetVersion(out int piMajorVersion, out int piMinorVersion);
        public static PFA3DDllGetVersion A3DDllGetVersion = null;
        public delegate void A3DCallbackMemoryFree(IntPtr arg1);
        public delegate A3DStatus PFA3DDllSetCallbacksMemory(IntPtr arg1, IntPtr arg2);
        public static PFA3DDllSetCallbacksMemory A3DDllSetCallbacksMemory = null;
        public delegate int A3DCallbackReportMessage([MarshalAs(UnmanagedType.LPStr)] string arg1);
        public delegate int A3DCallbackReportWarning([MarshalAs(UnmanagedType.LPStr)] string arg1, [MarshalAs(UnmanagedType.LPStr)] string arg2);
        public delegate int A3DCallbackReportError([MarshalAs(UnmanagedType.LPStr)] string arg1, [MarshalAs(UnmanagedType.LPStr)] string arg2);
        public delegate A3DStatus PFA3DDllSetCallbacksReport(IntPtr arg1, IntPtr arg2, IntPtr arg3);
        public static PFA3DDllSetCallbacksReport A3DDllSetCallbacksReport = null;
        public delegate void A3DCallbackAPITrace([MarshalAs(UnmanagedType.LPStr)] string arg1, uint arg2, IntPtr arg3, [MarshalAs(UnmanagedType.LPStr)] string arg4);
        public delegate A3DStatus PFA3DDllSetCallbackAPITrace(IntPtr arg1);
        public static PFA3DDllSetCallbackAPITrace A3DDllSetCallbackAPITrace = null;
        public delegate void A3DCallbackProgressStart(int arg1);
        public delegate void A3DCallbackProgressSize(int arg1);
        public delegate void A3DCallbackProgressIncrement(int arg1);
        public delegate void A3DCallbackProgressTitle([MarshalAs(UnmanagedType.LPStr)] string msg);
        public delegate A3DStatus PFA3DDllSetCallbacksProgress(IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, out int arg6);
        public static PFA3DDllSetCallbacksProgress A3DDllSetCallbacksProgress = null;
        public delegate A3DStatus PFA3DMkpLeaderGet(IntPtr pLeader, ref A3DMkpLeaderData pData);
        public static PFA3DMkpLeaderGet A3DMkpLeaderGet = null;
        public delegate A3DStatus PFA3DMkpLeaderCreate(ref A3DMkpLeaderData pData, out IntPtr ppLeader);
        public static PFA3DMkpLeaderCreate A3DMkpLeaderCreate = null;
        public delegate A3DStatus PFA3DMkpAnnotationItemGet(IntPtr pAnnotation, ref A3DMkpAnnotationItemData pData);
        public static PFA3DMkpAnnotationItemGet A3DMkpAnnotationItemGet = null;
        public delegate A3DStatus PFA3DMkpAnnotationItemCreate(ref A3DMkpAnnotationItemData pData, out IntPtr ppAnnotation);
        public static PFA3DMkpAnnotationItemCreate A3DMkpAnnotationItemCreate = null;
        public delegate A3DStatus PFA3DMkpAnnotationSetGet(IntPtr pAnnotation, ref A3DMkpAnnotationSetData pData);
        public static PFA3DMkpAnnotationSetGet A3DMkpAnnotationSetGet = null;
        public delegate A3DStatus PFA3DMkpAnnotationSetCreate(ref A3DMkpAnnotationSetData pData, out IntPtr ppAnnotation);
        public static PFA3DMkpAnnotationSetCreate A3DMkpAnnotationSetCreate = null;
        public delegate A3DStatus PFA3DMkpAnnotationReferenceGet(IntPtr pAnnotation, ref A3DMkpAnnotationReferenceData pData);
        public static PFA3DMkpAnnotationReferenceGet A3DMkpAnnotationReferenceGet = null;
        public delegate A3DStatus PFA3DMkpAnnotationReferenceCreate(ref A3DMkpAnnotationReferenceData pData, out IntPtr ppAnnotation);
        public static PFA3DMkpAnnotationReferenceCreate A3DMkpAnnotationReferenceCreate = null;
        public delegate A3DStatus PFA3DMkpViewGet(IntPtr pView, ref A3DMkpViewData pData);
        public static PFA3DMkpViewGet A3DMkpViewGet = null;
        public delegate A3DStatus PFA3DMkpViewCreate(ref A3DMkpViewData pData, out IntPtr ppView);
        public static PFA3DMkpViewCreate A3DMkpViewCreate = null;
        public delegate A3DStatus PFA3DMkpViewGetFlags(IntPtr pView, ref A3DMkpViewFlagsData pFlags);
        public static PFA3DMkpViewGetFlags A3DMkpViewGetFlags = null;
        public delegate A3DStatus PFA3DMiscMarkupLinkedItemGet(IntPtr pLinkedItem, ref A3DMiscMarkupLinkedItemData pData);
        public static PFA3DMiscMarkupLinkedItemGet A3DMiscMarkupLinkedItemGet = null;
        public delegate A3DStatus PFA3DMiscMarkupLinkedItemCreate(ref A3DMiscMarkupLinkedItemData pData, out IntPtr ppLinkedItem);
        public static PFA3DMiscMarkupLinkedItemCreate A3DMiscMarkupLinkedItemCreate = null;
        public delegate A3DStatus PFA3DMkpMarkupGet(IntPtr pMarkup, ref A3DMkpMarkupData pData);
        public static PFA3DMkpMarkupGet A3DMkpMarkupGet = null;
        public delegate A3DStatus PFA3DMkpMarkupCreate(ref A3DMkpMarkupData pData, out IntPtr ppMarkup);
        public static PFA3DMkpMarkupCreate A3DMkpMarkupCreate = null;
        public delegate A3DStatus PFA3DMkpLinkForMarkupReferenceGet(IntPtr pMarkup, out uint puiLinkedItemsSize, IntPtr ppLinkedItems);
        public static PFA3DMkpLinkForMarkupReferenceGet A3DMkpLinkForMarkupReferenceGet = null;
        public delegate A3DStatus PFA3DMkpLinkForAdditionalMarkupReferenceGet(IntPtr pMarkup, out uint puiLinkedItemsSize, IntPtr pppLinkedItems);
        public static PFA3DMkpLinkForAdditionalMarkupReferenceGet A3DMkpLinkForAdditionalMarkupReferenceGet = null;
        public delegate A3DStatus PFA3DMkpRTFFieldCreate([MarshalAs(UnmanagedType.LPStr)] string pRTFString, out IntPtr pRTFField);
        public static PFA3DMkpRTFFieldCreate A3DMkpRTFFieldCreate = null;
        public delegate A3DStatus PFA3DMkpRTFInit([MarshalAs(UnmanagedType.LPStr)] string pRTF, out IntPtr pRTFData);
        public static PFA3DMkpRTFInit A3DMkpRTFInit = null;
        public delegate A3DStatus PFA3DMkpRTFFieldGet(IntPtr pRTFField, ref A3DMkpRTFFieldData pRTFFieldData);
        public static PFA3DMkpRTFFieldGet A3DMkpRTFFieldGet = null;
        public delegate A3DStatus PFA3DMkpRTFGetField(IntPtr pRTFData, out A3DMkpRTFFieldData pRTFField);
        public static PFA3DMkpRTFGetField A3DMkpRTFGetField = null;
        public delegate A3DStatus PFA3DMkpRTFFieldDelete(IntPtr pRTFField);
        public static PFA3DMkpRTFFieldDelete A3DMkpRTFFieldDelete = null;
        public delegate A3DStatus PFA3DMkpRTFDelete(IntPtr pRTFData);
        public static PFA3DMkpRTFDelete A3DMkpRTFDelete = null;
        public delegate A3DStatus PFA3DGlobalFontKeyGet(ref A3DFontKeyData pFontKeyData, ref A3DFontData pFontData);
        public static PFA3DGlobalFontKeyGet A3DGlobalFontKeyGet = null;
        public delegate A3DStatus PFA3DGlobalFontTextBoxGet(ref A3DFontKeyData psFontKeyData, [MarshalAs(UnmanagedType.LPStr)] string pcText, out double pdLength, out double pdHeight);
        public static PFA3DGlobalFontTextBoxGet A3DGlobalFontTextBoxGet = null;
        public delegate A3DStatus PFA3DGlobalFontTextBoxAndScaleGet(ref A3DFontKeyData psFontKeyData, [MarshalAs(UnmanagedType.LPStr)] string pcText, out double pdLength, out double pdHeight, out double pdScale);
        public static PFA3DGlobalFontTextBoxAndScaleGet A3DGlobalFontTextBoxAndScaleGet = null;
        public delegate A3DStatus PFA3DGlobalFontKeyCreate(ref A3DFontData pFontData, ref A3DFontKeyData pFontKeyData);
        public static PFA3DGlobalFontKeyCreate A3DGlobalFontKeyCreate = null;
        public delegate A3DStatus PFA3DGlobalFontTextTessellationGet(ref A3DFontKeyData psFontKeyData, [MarshalAs(UnmanagedType.LPStr)] string pcOneChar, out IntPtr ppset, out double pdCharWidth);
        public static PFA3DGlobalFontTextTessellationGet A3DGlobalFontTextTessellationGet = null;
        public delegate A3DStatus PFA3DGraphTextureTransformationGet(IntPtr pTextureTransformation, ref A3DGraphTextureTransformationData pData);
        public static PFA3DGraphTextureTransformationGet A3DGraphTextureTransformationGet = null;
        public delegate A3DStatus PFA3DGraphTextureTransformationCreate(ref A3DGraphTextureTransformationData pData, out IntPtr ppTextureTransformation);
        public static PFA3DGraphTextureTransformationCreate A3DGraphTextureTransformationCreate = null;
        public delegate A3DStatus PFA3DGlobalGetGraphTextureDefinitionData(uint uiIndexTextureDefinition, ref A3DGraphTextureDefinitionData pData);
        public static PFA3DGlobalGetGraphTextureDefinitionData A3DGlobalGetGraphTextureDefinitionData = null;
        public delegate A3DStatus PFA3DGlobalInsertGraphTextureDefinition(ref A3DGraphTextureDefinitionData pData, out uint puiIndexTextureDefinition);
        public static PFA3DGlobalInsertGraphTextureDefinition A3DGlobalInsertGraphTextureDefinition = null;
        public delegate A3DStatus PFA3DGlobalGetGraphTextureApplicationData(uint uiIndexTextureApplication, ref A3DGraphTextureApplicationData pData);
        public static PFA3DGlobalGetGraphTextureApplicationData A3DGlobalGetGraphTextureApplicationData = null;
        public delegate A3DStatus PFA3DGlobalInsertGraphTextureApplication(ref A3DGraphTextureApplicationData pData, out uint puiIndexTextureApplication);
        public static PFA3DGlobalInsertGraphTextureApplication A3DGlobalInsertGraphTextureApplication = null;
        public delegate A3DStatus PFA3DDrawingModelGet(IntPtr pDrawingModel, ref A3DDrawingModelData pData);
        public static PFA3DDrawingModelGet A3DDrawingModelGet = null;
        public delegate A3DStatus PFA3DDrawingModelCreate(ref A3DDrawingModelData pData, out IntPtr ppDrawingModel);
        public static PFA3DDrawingModelCreate A3DDrawingModelCreate = null;
        public delegate A3DStatus PFA3DDrawingSheetFormatGet(IntPtr pDrwSheetFormat, ref A3DDrawingSheetFormatData pData);
        public static PFA3DDrawingSheetFormatGet A3DDrawingSheetFormatGet = null;
        public delegate A3DStatus PFA3DDrawingSheetFormatCreate(ref A3DDrawingSheetFormatData pData, out IntPtr ppDrwSheetFormat);
        public static PFA3DDrawingSheetFormatCreate A3DDrawingSheetFormatCreate = null;
        public delegate A3DStatus PFA3DDrawingSheetGet(IntPtr pDrawingSheet, ref A3DDrawingSheetData pData);
        public static PFA3DDrawingSheetGet A3DDrawingSheetGet = null;
        public delegate A3DStatus PFA3DDrawingSheetCreate(ref A3DDrawingSheetData pData, out IntPtr ppDrawingSheet);
        public static PFA3DDrawingSheetCreate A3DDrawingSheetCreate = null;
        public delegate A3DStatus PFA3DDrawingClipFrameGet(IntPtr pDrwClipFrame, ref A3DDrawingClipFrameData pData);
        public static PFA3DDrawingClipFrameGet A3DDrawingClipFrameGet = null;
        public delegate A3DStatus PFA3DDrawingClipFrameCreate(ref A3DDrawingClipFrameData pData, out IntPtr ppDrwClipFrame);
        public static PFA3DDrawingClipFrameCreate A3DDrawingClipFrameCreate = null;
        public delegate A3DStatus PFA3DDrawingViewGet(IntPtr pDrawingView, ref A3DDrawingViewData pData);
        public static PFA3DDrawingViewGet A3DDrawingViewGet = null;
        public delegate A3DStatus PFA3DDrawingViewCreate(ref A3DDrawingViewData pData, out IntPtr ppDrawingView);
        public static PFA3DDrawingViewCreate A3DDrawingViewCreate = null;
        public delegate A3DStatus PFA3DDrawingBlockBasicGet(IntPtr pDrawingBlock, ref A3DDrawingBlockBasicData pData);
        public static PFA3DDrawingBlockBasicGet A3DDrawingBlockBasicGet = null;
        public delegate A3DStatus PFA3DDrawingBlockBasicCreate(ref A3DDrawingBlockBasicData pData, out IntPtr ppDrawingBlock);
        public static PFA3DDrawingBlockBasicCreate A3DDrawingBlockBasicCreate = null;
        public delegate A3DStatus PFA3DDrawingBlockOperatorGet(IntPtr pDrawingOperator, ref A3DDrawingBlockOperatorData pData);
        public static PFA3DDrawingBlockOperatorGet A3DDrawingBlockOperatorGet = null;
        public delegate A3DStatus PFA3DDrawingBlockOperatorCreate(ref A3DDrawingBlockOperatorData pData, out IntPtr ppDrawingOperator);
        public static PFA3DDrawingBlockOperatorCreate A3DDrawingBlockOperatorCreate = null;
        public delegate A3DStatus PFA3DDrawingBlockPushMiscCascadedAttributes(IntPtr pAttr, IntPtr pBlock, uint uiEntityIndex, IntPtr pFather);
        public static PFA3DDrawingBlockPushMiscCascadedAttributes A3DDrawingBlockPushMiscCascadedAttributes = null;
        public delegate A3DStatus PFA3DDrawingCurveGet(IntPtr pDrawingCrv, ref A3DDrawingCurveData pData);
        public static PFA3DDrawingCurveGet A3DDrawingCurveGet = null;
        public delegate A3DStatus PFA3DDrawingCurveCreate(ref A3DDrawingCurveData pData, out IntPtr ppDrawingCrv);
        public static PFA3DDrawingCurveCreate A3DDrawingCurveCreate = null;
        public delegate A3DStatus PFA3DDrawingFilledAreaGet(IntPtr pDrwFilledArea, ref A3DDrawingFilledAreaData pData);
        public static PFA3DDrawingFilledAreaGet A3DDrawingFilledAreaGet = null;
        public delegate A3DStatus PFA3DDrawingFilledAreaCreate(ref A3DDrawingFilledAreaData pData, out IntPtr ppDrwFilledArea);
        public static PFA3DDrawingFilledAreaCreate A3DDrawingFilledAreaCreate = null;
        public delegate A3DStatus PFA3DDrawingPictureGet(IntPtr pDrawingPicture, ref A3DDrawingPictureData pData);
        public static PFA3DDrawingPictureGet A3DDrawingPictureGet = null;
        public delegate A3DStatus PFA3DDrawingPictureCreate(ref A3DDrawingPictureData pData, out IntPtr ppDrawingPicture);
        public static PFA3DDrawingPictureCreate A3DDrawingPictureCreate = null;
        public delegate A3DStatus PFA3DDrawingVerticesGet(IntPtr pDrawingVertices, ref A3DDrawingVerticesData pData);
        public static PFA3DDrawingVerticesGet A3DDrawingVerticesGet = null;
        public delegate A3DStatus PFA3DDrawingVerticesCreate(ref A3DDrawingVerticesData pData, out IntPtr ppDrawingVertices);
        public static PFA3DDrawingVerticesCreate A3DDrawingVerticesCreate = null;
        public delegate A3DStatus PFA3DGetFileFormat([MarshalAs(UnmanagedType.LPStr)] string pcFileName, ref A3DEModellerType peModellerType);
        public static PFA3DGetFileFormat A3DGetFileFormat = null;
        public delegate A3DStatus PFA3DCheckFileFormat([MarshalAs(UnmanagedType.LPStr)] string pcFileName, A3DEModellerType eCadTypeWanted);
        public static PFA3DCheckFileFormat A3DCheckFileFormat = null;
        public delegate A3DStatus PFA3DExtractFileThumbnail([MarshalAs(UnmanagedType.LPStr)] string pcFileName, ref A3DThumbnailData pThumbnailData);
        public static PFA3DExtractFileThumbnail A3DExtractFileThumbnail = null;
        public delegate A3DStatus PFA3DGetFileInformation([MarshalAs(UnmanagedType.LPStr)] string pcFileName, ref A3DFileInformationData pFileInformationData);
        public static PFA3DGetFileInformation A3DGetFileInformation = null;
        public delegate A3DStatus PFA3DAsmGetFilesPathFromModelFile(IntPtr pA3DAsmModelFile, out uint uNbPartFiles, IntPtr ppPartFilesPaths, out uint uNbAssemblyFiles, IntPtr ppAssemblyFilesPaths, out uint uNbMissingFiles, IntPtr ppMissingFilesPaths);
        public static PFA3DAsmGetFilesPathFromModelFile A3DAsmGetFilesPathFromModelFile = null;
        public delegate A3DStatus PFA3DAsmGetFilesContextsFromModelFile(IntPtr pA3DAsmModelFile, out uint uNbFilesContexts, IntPtr ppFilesContexts);
        public static PFA3DAsmGetFilesContextsFromModelFile A3DAsmGetFilesContextsFromModelFile = null;
        public delegate A3DStatus PFA3DFileContextDelete(ref A3DFileContextData pData);
        public static PFA3DFileContextDelete A3DFileContextDelete = null;
        public delegate A3DStatus PFA3DAsmModelFileLoadFromPRCFiles([MarshalAs(UnmanagedType.LPStr)] string pcRootPrcFilePath, uint uNbFile, IntPtr ppPRCFilePath, IntPtr ppCADFilePath, ref A3DRWParamsLoadData pParamsLoadData, out IntPtr pA3DAsmModelFile);
        public static PFA3DAsmModelFileLoadFromPRCFiles A3DAsmModelFileLoadFromPRCFiles = null;
        public delegate A3DStatus PFA3DAsmModelFileLoadFromMultiplePrcFile([MarshalAs(UnmanagedType.LPStr)] string pcFileName, uint uNbPart, IntPtr ppCADFilePath, IntPtr ppPRCFilePath, ref A3DRWParamsLoadData pParamsLoadData, out IntPtr pA3DAsmModelFile);
        public static PFA3DAsmModelFileLoadFromMultiplePrcFile A3DAsmModelFileLoadFromMultiplePrcFile = null;
        public delegate A3DStatus PFA3DAsmModelFileExportToParasolidFile(IntPtr pA3DAsmModelFile, ref A3DRWParamsExportParasolidData pParamsExportData, [MarshalAs(UnmanagedType.LPStr)] string pcCADFileName);
        public static PFA3DAsmModelFileExportToParasolidFile A3DAsmModelFileExportToParasolidFile = null;
        public delegate A3DStatus PFA3DChainedBufferFree(ref A3DChainedBuffer pBuffer);
        public static PFA3DChainedBufferFree A3DChainedBufferFree = null;
        public delegate A3DStatus PFA3DAsmModelFileExportToParasolidBuffer(IntPtr pA3DAsmModelFile, ref A3DRWParamsExportParasolidData pParamsExportData, IntPtr pBuffer);
        public static PFA3DAsmModelFileExportToParasolidBuffer A3DAsmModelFileExportToParasolidBuffer = null;
        public delegate A3DStatus PFA3DRepresentationItemExportToParasolidFile(IntPtr pRepItem, [MarshalAs(UnmanagedType.LPStr)] string pcTempFileName, double dUnit);
        public static PFA3DRepresentationItemExportToParasolidFile A3DRepresentationItemExportToParasolidFile = null;
        public delegate A3DStatus PFA3DRepresentationItemExportToParasolidBuffer(IntPtr pRepItem, IntPtr pBuffer, double dUnit);
        public static PFA3DRepresentationItemExportToParasolidBuffer A3DRepresentationItemExportToParasolidBuffer = null;
        public delegate A3DStatus PFA3DAsmModelFileTranslateToPkParts(IntPtr pA3DAsmModelFile, ref A3DRWParamsExportParasolidData pParamsExportData, ref A3DRWParamsTranslateToPkPartsData pParamsTranslateToPkPartsData, IntPtr pNbPkParts, IntPtr pPkParts);
        public static PFA3DAsmModelFileTranslateToPkParts A3DAsmModelFileTranslateToPkParts = null;
        public delegate A3DStatus PFA3DRepresentationItemTranslateToPkParts(IntPtr pRepItem, ref A3DRWParamsTranslateToPkPartsData pParamsTranslateToPkPartsData, double dUnit, IntPtr pNbPkParts, IntPtr pPkParts);
        public static PFA3DRepresentationItemTranslateToPkParts A3DRepresentationItemTranslateToPkParts = null;
        public delegate A3DStatus PFA3DRepresentationItemsTranslateToPkPartsMultiProcess(uint uiNbProc, ref A3DRWParamsTranslateToPkPartsData pParamsTranslateToPkPartsData, uint uiNbRepItem, out IntPtr pRepItem, out double padUnit, IntPtr pNbPkParts, IntPtr pPkParts);
        public static PFA3DRepresentationItemsTranslateToPkPartsMultiProcess A3DRepresentationItemsTranslateToPkPartsMultiProcess = null;
        public delegate A3DStatus PFA3DHealPkParts(IntPtr pNbPkParts, IntPtr pPkParts, ref A3DRWParamsTranslateToPkPartsData pParamsTranslateToPkPartsData);
        public static PFA3DHealPkParts A3DHealPkParts = null;
        public delegate A3DStatus PFA3DMiscPKMapperGetPKEntitiesFromA3DEntity(IntPtr pMapper, IntPtr pA3DEntity, IntPtr piNbPKEntities, IntPtr ppPKEntities);
        public static PFA3DMiscPKMapperGetPKEntitiesFromA3DEntity A3DMiscPKMapperGetPKEntitiesFromA3DEntity = null;
        public delegate A3DStatus PFA3DMiscPKMapperGetA3DEntitiesFromPKEntity(IntPtr pMapper, int pPKEntity, IntPtr piNbA3DEntities, IntPtr ppA3DEntities);
        public static PFA3DMiscPKMapperGetA3DEntitiesFromPKEntity A3DMiscPKMapperGetA3DEntitiesFromPKEntity = null;
        public delegate A3DStatus PFA3DAsmModelFileExportToParasolidFileWithMapper(IntPtr pA3DAsmModelFile, IntPtr pMapper, ref A3DRWParamsExportParasolidData pParamsExportData, [MarshalAs(UnmanagedType.LPStr)] string pcCADFileName);
        public static PFA3DAsmModelFileExportToParasolidFileWithMapper A3DAsmModelFileExportToParasolidFileWithMapper = null;
        public delegate A3DStatus PFA3DPkPartsTranslateToA3DAsmModelFile(int pNbPkParts, IntPtr pPkParts, ref A3DRWParamsLoadData pLoadParam, out IntPtr ppA3DAsmModelFile, out IntPtr pMapper);
        public static PFA3DPkPartsTranslateToA3DAsmModelFile A3DPkPartsTranslateToA3DAsmModelFile = null;
        public delegate A3DStatus PFA3DAsmModelFileExportToParasolidBufferWithMapper(IntPtr pA3DAsmModelFile, IntPtr pMapper, ref A3DRWParamsExportParasolidData pParamsExportData, IntPtr pBuffer);
        public static PFA3DAsmModelFileExportToParasolidBufferWithMapper A3DAsmModelFileExportToParasolidBufferWithMapper = null;
        public delegate A3DStatus PFA3DAsmModelFileExportToPrcStream(IntPtr pA3DAsmModelFile, ref A3DRWParamsExportPrcData pParamsExportData, IntPtr pcStream, out uint uLength, out IntPtr ppPrcWriteHelper);
        public static PFA3DAsmModelFileExportToPrcStream A3DAsmModelFileExportToPrcStream = null;
        public delegate A3DStatus PFA3DAsmModelFileExportToAcisFile(IntPtr pA3DAsmModelFile, ref A3DRWParamsExportAcisData pParamsExportData, [MarshalAs(UnmanagedType.LPStr)] string pcCADFileName);
        public static PFA3DAsmModelFileExportToAcisFile A3DAsmModelFileExportToAcisFile = null;
        public delegate A3DStatus PFA3DAsmModelFileExportToAcisBuffer(IntPtr pA3DAsmModelFile, ref A3DRWParamsExportAcisData pParamsExportData, IntPtr pBuffer);
        public static PFA3DAsmModelFileExportToAcisBuffer A3DAsmModelFileExportToAcisBuffer = null;
        public delegate A3DStatus PFA3DRepresentationItemExportToAcisBuffer(IntPtr pRepItem, IntPtr pBuffer, double dScale);
        public static PFA3DRepresentationItemExportToAcisBuffer A3DRepresentationItemExportToAcisBuffer = null;
        public delegate A3DStatus PFA3DAsmModelFileLoadFromXMLFile([MarshalAs(UnmanagedType.LPStr)] string pcFileName, ref A3DRWParamsLoadData pLoadParametersData, out IntPtr ppModelFile);
        public static PFA3DAsmModelFileLoadFromXMLFile A3DAsmModelFileLoadFromXMLFile = null;
        public delegate A3DStatus PFA3DAsmModelFileLoadFromXMLStream([MarshalAs(UnmanagedType.LPStr)] string pcBuffer, ref A3DRWParamsLoadData pLoadParametersData, out IntPtr ppModelFile);
        public static PFA3DAsmModelFileLoadFromXMLStream A3DAsmModelFileLoadFromXMLStream = null;
        public delegate A3DStatus PFA3DRiRepresentationItemGet(IntPtr pRi, ref A3DRiRepresentationItemData pData);
        public static PFA3DRiRepresentationItemGet A3DRiRepresentationItemGet = null;
        public delegate A3DStatus PFA3DRiRepresentationItemSet(IntPtr pRi, ref A3DRiRepresentationItemData pData);
        public static PFA3DRiRepresentationItemSet A3DRiRepresentationItemSet = null;
        public delegate A3DStatus PFA3DRiRepresentationItemDeepCopy(IntPtr pRi, out IntPtr ppNewRi);
        public static PFA3DRiRepresentationItemDeepCopy A3DRiRepresentationItemDeepCopy = null;
        public delegate A3DStatus PFA3DRiRepresentationItemComputeTessellation(IntPtr pRi, ref A3DRWParamsTessellationData pTessellationParametersData);
        public static PFA3DRiRepresentationItemComputeTessellation A3DRiRepresentationItemComputeTessellation = null;
        public delegate A3DStatus PFA3DRiReleaseTessellation(IntPtr pRepresentationItem);
        public static PFA3DRiReleaseTessellation A3DRiReleaseTessellation = null;
        public delegate A3DStatus PFA3DRiRepresentationItemEditCoordinateSystem(IntPtr pNewCoordinateSystem, IntPtr pRepresentationItem);
        public static PFA3DRiRepresentationItemEditCoordinateSystem A3DRiRepresentationItemEditCoordinateSystem = null;
        public delegate A3DStatus PFA3DRiSetGet(IntPtr pSet, ref A3DRiSetData pData);
        public static PFA3DRiSetGet A3DRiSetGet = null;
        public delegate A3DStatus PFA3DRiSetCreate(ref A3DRiSetData pData, out IntPtr ppSet);
        public static PFA3DRiSetCreate A3DRiSetCreate = null;
        public delegate A3DStatus PFA3DRiSetEdit(ref A3DRiSetData pData, IntPtr pSet);
        public static PFA3DRiSetEdit A3DRiSetEdit = null;
        public delegate A3DStatus PFA3DRiPointSetGet(IntPtr pPointSet, ref A3DRiPointSetData pData);
        public static PFA3DRiPointSetGet A3DRiPointSetGet = null;
        public delegate A3DStatus PFA3DRiPointSetCreate(ref A3DRiPointSetData pData, out IntPtr ppPointSet);
        public static PFA3DRiPointSetCreate A3DRiPointSetCreate = null;
        public delegate A3DStatus PFA3DRiPointSetEdit(ref A3DRiPointSetData pData, IntPtr pPointSet);
        public static PFA3DRiPointSetEdit A3DRiPointSetEdit = null;
        public delegate A3DStatus PFA3DRiDirectionGet(IntPtr pDirection, ref A3DRiDirectionData pData);
        public static PFA3DRiDirectionGet A3DRiDirectionGet = null;
        public delegate A3DStatus PFA3DRiDirectionCreate(ref A3DRiDirectionData pData, out IntPtr ppDirection);
        public static PFA3DRiDirectionCreate A3DRiDirectionCreate = null;
        public delegate A3DStatus PFA3DRiDirectionEdit(ref A3DRiDirectionData pData, IntPtr pDirection);
        public static PFA3DRiDirectionEdit A3DRiDirectionEdit = null;
        public delegate A3DStatus PFA3DRiCoordinateSystemGet(IntPtr pCoordinateSystem, ref A3DRiCoordinateSystemData pData);
        public static PFA3DRiCoordinateSystemGet A3DRiCoordinateSystemGet = null;
        public delegate A3DStatus PFA3DRiCoordinateSystemCreate(ref A3DRiCoordinateSystemData pData, out IntPtr ppCoordinateSystem);
        public static PFA3DRiCoordinateSystemCreate A3DRiCoordinateSystemCreate = null;
        public delegate A3DStatus PFA3DRiCoordinateSystemEdit(ref A3DRiCoordinateSystemData pData, IntPtr pCoordinateSystem);
        public static PFA3DRiCoordinateSystemEdit A3DRiCoordinateSystemEdit = null;
        public delegate A3DStatus PFA3DRiCurveGet(IntPtr pRICrv, ref A3DRiCurveData pData);
        public static PFA3DRiCurveGet A3DRiCurveGet = null;
        public delegate A3DStatus PFA3DRiCurveCreate(ref A3DRiCurveData pData, out IntPtr ppRICrv);
        public static PFA3DRiCurveCreate A3DRiCurveCreate = null;
        public delegate A3DStatus PFA3DRiCurveEdit(ref A3DRiCurveData pData, IntPtr pRICrv);
        public static PFA3DRiCurveEdit A3DRiCurveEdit = null;
        public delegate A3DStatus PFA3DRiCurveSupportGet(IntPtr pRiCurve, out IntPtr ppLinkedItem);
        public static PFA3DRiCurveSupportGet A3DRiCurveSupportGet = null;
        public delegate A3DStatus PFA3DRiPlaneGet(IntPtr pRiPlane, ref A3DRiPlaneData pData);
        public static PFA3DRiPlaneGet A3DRiPlaneGet = null;
        public delegate A3DStatus PFA3DRiPlaneCreate(ref A3DRiPlaneData pData, out IntPtr ppRIPlane);
        public static PFA3DRiPlaneCreate A3DRiPlaneCreate = null;
        public delegate A3DStatus PFA3DRiPlaneEdit(ref A3DRiPlaneData pData, IntPtr pRIPlane);
        public static PFA3DRiPlaneEdit A3DRiPlaneEdit = null;
        public delegate A3DStatus PFA3DRiPlaneSupportGet(IntPtr pRiPlane, out IntPtr ppLinkedItem);
        public static PFA3DRiPlaneSupportGet A3DRiPlaneSupportGet = null;
        public delegate A3DStatus PFA3DRiBrepModelGet(IntPtr pRIBrepModel, ref A3DRiBrepModelData pData);
        public static PFA3DRiBrepModelGet A3DRiBrepModelGet = null;
        public delegate A3DStatus PFA3DRiBrepModelCreate(ref A3DRiBrepModelData pData, out IntPtr ppRIBrepModel);
        public static PFA3DRiBrepModelCreate A3DRiBrepModelCreate = null;
        public delegate A3DStatus PFA3DRiBrepModelEdit(ref A3DRiBrepModelData pData, IntPtr pRIBrepModel);
        public static PFA3DRiBrepModelEdit A3DRiBrepModelEdit = null;
        public delegate A3DStatus PFA3DRiPolyBrepModelGet(IntPtr pRIPolyBrepModel, ref A3DRiPolyBrepModelData pData);
        public static PFA3DRiPolyBrepModelGet A3DRiPolyBrepModelGet = null;
        public delegate A3DStatus PFA3DRiPolyBrepModelCreate(ref A3DRiPolyBrepModelData pData, out IntPtr ppRIPolyBrepModel);
        public static PFA3DRiPolyBrepModelCreate A3DRiPolyBrepModelCreate = null;
        public delegate A3DStatus PFA3DRiPolyBrepModelEdit(ref A3DRiPolyBrepModelData pData, IntPtr pRIPolyBrepModel);
        public static PFA3DRiPolyBrepModelEdit A3DRiPolyBrepModelEdit = null;
        public delegate A3DStatus PFA3DRiPolyWireGet(IntPtr pRIPolyWire, ref A3DRiPolyWireData pData);
        public static PFA3DRiPolyWireGet A3DRiPolyWireGet = null;
        public delegate A3DStatus PFA3DRiPolyWireCreate(ref A3DRiPolyWireData pData, out IntPtr ppRIPolyWire);
        public static PFA3DRiPolyWireCreate A3DRiPolyWireCreate = null;
        public delegate A3DStatus PFA3DFRMFeatureTreeGet(IntPtr pTree, ref A3DFRMFeatureTreeData pData);
        public static PFA3DFRMFeatureTreeGet A3DFRMFeatureTreeGet = null;
        public delegate A3DStatus PFA3DFRMParameterGet(IntPtr pParameter, ref A3DFRMParameterData pData);
        public static PFA3DFRMParameterGet A3DFRMParameterGet = null;
        public delegate A3DStatus PFA3DFRMStringDataGet(IntPtr pFeature, ref A3DFRMStringData pData);
        public static PFA3DFRMStringDataGet A3DFRMStringDataGet = null;
        public delegate A3DStatus PFA3DFRMDoubleDataGet(IntPtr pFeature, ref A3DFRMDoubleData pData);
        public static PFA3DFRMDoubleDataGet A3DFRMDoubleDataGet = null;
        public delegate A3DStatus PFA3DFRMIntegerDataGet(IntPtr pFeature, ref A3DFRMIntegerData pData);
        public static PFA3DFRMIntegerDataGet A3DFRMIntegerDataGet = null;
        public delegate A3DStatus PFA3DFRMEnumDataGet(IntPtr pFeature, out int m_piEnumValue, IntPtr ppcValueAsString);
        public static PFA3DFRMEnumDataGet A3DFRMEnumDataGet = null;
        public delegate A3DStatus PFA3DFRMFeatureLinkedItemGet(IntPtr p, ref A3DFRMFeatureLinkedItemData pData);
        public static PFA3DFRMFeatureLinkedItemGet A3DFRMFeatureLinkedItemGet = null;
        public delegate A3DStatus PFA3DFRMFeatureGet(IntPtr pFeature, ref A3DFRMFeatureData pData);
        public static PFA3DFRMFeatureGet A3DFRMFeatureGet = null;
        public delegate A3DStatus PFA3DFRMFeatureGetTypeAsString(IntPtr pFeature, IntPtr ppcFeatureType);
        public static PFA3DFRMFeatureGetTypeAsString A3DFRMFeatureGetTypeAsString = null;
        public delegate A3DStatus PFA3DFRMGetSpecificNodes(IntPtr pTree, EA3DFRMEnumValue_CadType eCADType, out uint piSize, IntPtr pppFeatureNodes);
        public static PFA3DFRMGetSpecificNodes A3DFRMGetSpecificNodes = null;
        public delegate A3DStatus PFA3DAsmPartDefinitionFeatureTreesGet(IntPtr pPartDefinition, out uint puiSize, IntPtr pppFeatureTrees);
        public static PFA3DAsmPartDefinitionFeatureTreesGet A3DAsmPartDefinitionFeatureTreesGet = null;
        public delegate A3DStatus PFA3DFRMFeatureGeomEntitiesExtract(IntPtr pFeature, ref A3DFRMFeatureGeomEntitiesData pFeatureGeomEntities);
        public static PFA3DFRMFeatureGeomEntitiesExtract A3DFRMFeatureGeomEntitiesExtract = null;
        public delegate A3DStatus PFA3DCrvNurbsGet(IntPtr pCrv, ref A3DCrvNurbsData pData);
        public static PFA3DCrvNurbsGet A3DCrvNurbsGet = null;
        public delegate A3DStatus PFA3DCrvNurbsCreate(ref A3DCrvNurbsData pData, out IntPtr ppCrv);
        public static PFA3DCrvNurbsCreate A3DCrvNurbsCreate = null;
        public delegate A3DStatus PFA3DCrvBaseGetAsNurbs(IntPtr pCrv, double dTolerance, bool bUseSameParameterization, ref A3DCrvNurbsData pData);
        public static PFA3DCrvBaseGetAsNurbs A3DCrvBaseGetAsNurbs = null;
        public delegate A3DStatus PFA3DCrvLineGet(IntPtr pCrv, ref A3DCrvLineData pData);
        public static PFA3DCrvLineGet A3DCrvLineGet = null;
        public delegate A3DStatus PFA3DCrvLineCreate(ref A3DCrvLineData pData, out IntPtr ppCrv);
        public static PFA3DCrvLineCreate A3DCrvLineCreate = null;
        public delegate A3DStatus PFA3DCrvCircleGet(IntPtr pCrv, ref A3DCrvCircleData pData);
        public static PFA3DCrvCircleGet A3DCrvCircleGet = null;
        public delegate A3DStatus PFA3DCrvCircleCreate(ref A3DCrvCircleData pData, out IntPtr ppCrv);
        public static PFA3DCrvCircleCreate A3DCrvCircleCreate = null;
        public delegate A3DStatus PFA3DCrvEllipseGet(IntPtr pCrv, ref A3DCrvEllipseData pData);
        public static PFA3DCrvEllipseGet A3DCrvEllipseGet = null;
        public delegate A3DStatus PFA3DCrvEllipseCreate(ref A3DCrvEllipseData pData, out IntPtr ppCrv);
        public static PFA3DCrvEllipseCreate A3DCrvEllipseCreate = null;
        public delegate A3DStatus PFA3DCrvParabolaGet(IntPtr pCrv, ref A3DCrvParabolaData pData);
        public static PFA3DCrvParabolaGet A3DCrvParabolaGet = null;
        public delegate A3DStatus PFA3DCrvParabolaCreate(ref A3DCrvParabolaData pData, out IntPtr ppCrv);
        public static PFA3DCrvParabolaCreate A3DCrvParabolaCreate = null;
        public delegate A3DStatus PFA3DCrvHyperbolaGet(IntPtr pCrv, ref A3DCrvHyperbolaData pData);
        public static PFA3DCrvHyperbolaGet A3DCrvHyperbolaGet = null;
        public delegate A3DStatus PFA3DCrvHyperbolaCreate(ref A3DCrvHyperbolaData pData, out IntPtr ppCrv);
        public static PFA3DCrvHyperbolaCreate A3DCrvHyperbolaCreate = null;
        public delegate A3DStatus PFA3DCrvPolyLineGet(IntPtr pCrv, ref A3DCrvPolyLineData pData);
        public static PFA3DCrvPolyLineGet A3DCrvPolyLineGet = null;
        public delegate A3DStatus PFA3DCrvPolyLineCreate(ref A3DCrvPolyLineData pData, out IntPtr ppCrv);
        public static PFA3DCrvPolyLineCreate A3DCrvPolyLineCreate = null;
        public delegate A3DStatus PFA3DCrvCompositeGet(IntPtr pCrv, ref A3DCrvCompositeData pData);
        public static PFA3DCrvCompositeGet A3DCrvCompositeGet = null;
        public delegate A3DStatus PFA3DCrvCompositeCreate(ref A3DCrvCompositeData pData, out IntPtr ppCrv);
        public static PFA3DCrvCompositeCreate A3DCrvCompositeCreate = null;
        public delegate A3DStatus PFA3DCrvEquationGet(IntPtr pCrv, ref A3DCrvEquationData pData);
        public static PFA3DCrvEquationGet A3DCrvEquationGet = null;
        public delegate A3DStatus PFA3DCrvEquationCreate(ref A3DCrvEquationData pData, out IntPtr ppCrv);
        public static PFA3DCrvEquationCreate A3DCrvEquationCreate = null;
        public delegate A3DStatus PFA3DCrvTransformGet(IntPtr pCrv, ref A3DCrvTransformData pData);
        public static PFA3DCrvTransformGet A3DCrvTransformGet = null;
        public delegate A3DStatus PFA3DCrvTransformCreate(ref A3DCrvTransformData pData, out IntPtr ppCrv);
        public static PFA3DCrvTransformCreate A3DCrvTransformCreate = null;
        public delegate A3DStatus PFA3DCrvOnSurfGet(IntPtr pCrv, ref A3DCrvOnSurfData pData);
        public static PFA3DCrvOnSurfGet A3DCrvOnSurfGet = null;
        public delegate A3DStatus PFA3DCrvOnSurfCreate(ref A3DCrvOnSurfData pData, out IntPtr ppCrv);
        public static PFA3DCrvOnSurfCreate A3DCrvOnSurfCreate = null;
        public delegate A3DStatus PFA3DCrvOffsetGet(IntPtr pCrv, ref A3DCrvOffsetData pData);
        public static PFA3DCrvOffsetGet A3DCrvOffsetGet = null;
        public delegate A3DStatus PFA3DCrvOffsetCreate(ref A3DCrvOffsetData pData, out IntPtr ppCrv);
        public static PFA3DCrvOffsetCreate A3DCrvOffsetCreate = null;
        public delegate A3DStatus PFA3DCrvHelixGet(IntPtr pCrv, ref A3DCrvHelixData pData);
        public static PFA3DCrvHelixGet A3DCrvHelixGet = null;
        public delegate A3DStatus PFA3DCrvHelixCreate(ref A3DCrvHelixData pData, out IntPtr ppCrv);
        public static PFA3DCrvHelixCreate A3DCrvHelixCreate = null;
        public delegate A3DStatus PFA3DCrvIntersectionGet(IntPtr pCrv, ref A3DCrvIntersectionData pData);
        public static PFA3DCrvIntersectionGet A3DCrvIntersectionGet = null;
        public delegate A3DStatus PFA3DCrvIntersectionCreate(ref A3DCrvIntersectionData pData, out IntPtr ppCrv);
        public static PFA3DCrvIntersectionCreate A3DCrvIntersectionCreate = null;
        public delegate A3DStatus PFA3DCrvBlend02BoundaryGet(IntPtr pCrv, ref A3DCrvBlend02BoundaryData pData);
        public static PFA3DCrvBlend02BoundaryGet A3DCrvBlend02BoundaryGet = null;
        public delegate A3DStatus PFA3DCrvBlend02BoundaryCreate(ref A3DCrvBlend02BoundaryData pData, out IntPtr ppCrv);
        public static PFA3DCrvBlend02BoundaryCreate A3DCrvBlend02BoundaryCreate = null;
        public delegate A3DStatus PFA3DSurfNurbsGet(IntPtr pSrf, ref A3DSurfNurbsData pData);
        public static PFA3DSurfNurbsGet A3DSurfNurbsGet = null;
        public delegate A3DStatus PFA3DSurfNurbsCreate(ref A3DSurfNurbsData pData, out IntPtr ppSrf);
        public static PFA3DSurfNurbsCreate A3DSurfNurbsCreate = null;
        public delegate A3DStatus PFA3DSurfBaseGetAsNurbs(IntPtr pSrf, double dTolerance, bool bUseSameParameterization, ref A3DSurfNurbsData pData);
        public static PFA3DSurfBaseGetAsNurbs A3DSurfBaseGetAsNurbs = null;
        public delegate A3DStatus PFA3DSurfSphereGet(IntPtr pSrf, ref A3DSurfSphereData pData);
        public static PFA3DSurfSphereGet A3DSurfSphereGet = null;
        public delegate A3DStatus PFA3DSurfSphereCreate(ref A3DSurfSphereData pData, out IntPtr ppSrf);
        public static PFA3DSurfSphereCreate A3DSurfSphereCreate = null;
        public delegate A3DStatus PFA3DSurfCylinderGet(IntPtr pSrf, ref A3DSurfCylinderData pData);
        public static PFA3DSurfCylinderGet A3DSurfCylinderGet = null;
        public delegate A3DStatus PFA3DSurfCylinderCreate(ref A3DSurfCylinderData pData, out IntPtr ppSrf);
        public static PFA3DSurfCylinderCreate A3DSurfCylinderCreate = null;
        public delegate A3DStatus PFA3DSurfTorusGet(IntPtr pSrf, ref A3DSurfTorusData pData);
        public static PFA3DSurfTorusGet A3DSurfTorusGet = null;
        public delegate A3DStatus PFA3DSurfTorusCreate(ref A3DSurfTorusData pData, out IntPtr ppSrf);
        public static PFA3DSurfTorusCreate A3DSurfTorusCreate = null;
        public delegate A3DStatus PFA3DSurfRevolutionGet(IntPtr pSrf, ref A3DSurfRevolutionData pData);
        public static PFA3DSurfRevolutionGet A3DSurfRevolutionGet = null;
        public delegate A3DStatus PFA3DSurfRevolutionCreate(ref A3DSurfRevolutionData pData, out IntPtr ppSrf);
        public static PFA3DSurfRevolutionCreate A3DSurfRevolutionCreate = null;
        public delegate A3DStatus PFA3DSurfExtrusionGet(IntPtr pSrf, ref A3DSurfExtrusionData pData);
        public static PFA3DSurfExtrusionGet A3DSurfExtrusionGet = null;
        public delegate A3DStatus PFA3DSurfExtrusionCreate(ref A3DSurfExtrusionData pData, out IntPtr ppSrf);
        public static PFA3DSurfExtrusionCreate A3DSurfExtrusionCreate = null;
        public delegate A3DStatus PFA3DSurfOffsetGet(IntPtr pSrf, ref A3DSurfOffsetData pData);
        public static PFA3DSurfOffsetGet A3DSurfOffsetGet = null;
        public delegate A3DStatus PFA3DSurfOffsetCreate(ref A3DSurfOffsetData pData, out IntPtr ppSrf);
        public static PFA3DSurfOffsetCreate A3DSurfOffsetCreate = null;
        public delegate A3DStatus PFA3DSurfPlaneGet(IntPtr pSrf, ref A3DSurfPlaneData pData);
        public static PFA3DSurfPlaneGet A3DSurfPlaneGet = null;
        public delegate A3DStatus PFA3DSurfPlaneCreate(ref A3DSurfPlaneData pData, out IntPtr ppSrf);
        public static PFA3DSurfPlaneCreate A3DSurfPlaneCreate = null;
        public delegate A3DStatus PFA3DSurfBlend01Get(IntPtr pSrf, ref A3DSurfBlend01Data pData);
        public static PFA3DSurfBlend01Get A3DSurfBlend01Get = null;
        public delegate A3DStatus PFA3DSurfBlend01Create(ref A3DSurfBlend01Data pData, out IntPtr ppSrf);
        public static PFA3DSurfBlend01Create A3DSurfBlend01Create = null;
        public delegate A3DStatus PFA3DSurfBlend02Get(IntPtr pSrf, ref A3DSurfBlend02Data pData);
        public static PFA3DSurfBlend02Get A3DSurfBlend02Get = null;
        public delegate A3DStatus PFA3DSurfBlend02Create(ref A3DSurfBlend02Data pData, out IntPtr ppSrf);
        public static PFA3DSurfBlend02Create A3DSurfBlend02Create = null;
        public delegate A3DStatus PFA3DSurfBlend03Get(IntPtr pSrf, ref A3DSurfBlend03Data pData);
        public static PFA3DSurfBlend03Get A3DSurfBlend03Get = null;
        public delegate A3DStatus PFA3DSurfBlend03Create(ref A3DSurfBlend03Data pData, out IntPtr ppSrf);
        public static PFA3DSurfBlend03Create A3DSurfBlend03Create = null;
        public delegate A3DStatus PFA3DSurfConeGet(IntPtr pSrf, ref A3DSurfConeData pData);
        public static PFA3DSurfConeGet A3DSurfConeGet = null;
        public delegate A3DStatus PFA3DSurfConeCreate(ref A3DSurfConeData pData, out IntPtr ppSrf);
        public static PFA3DSurfConeCreate A3DSurfConeCreate = null;
        public delegate A3DStatus PFA3DSurfCylindricalGet(IntPtr pSrf, ref A3DSurfCylindricalData pData);
        public static PFA3DSurfCylindricalGet A3DSurfCylindricalGet = null;
        public delegate A3DStatus PFA3DSurfCylindricalCreate(ref A3DSurfCylindricalData pData, out IntPtr ppSrf);
        public static PFA3DSurfCylindricalCreate A3DSurfCylindricalCreate = null;
        public delegate A3DStatus PFA3DSurfRuledGet(IntPtr pSrf, ref A3DSurfRuledData pData);
        public static PFA3DSurfRuledGet A3DSurfRuledGet = null;
        public delegate A3DStatus PFA3DSurfRuledCreate(ref A3DSurfRuledData pData, out IntPtr ppSrf);
        public static PFA3DSurfRuledCreate A3DSurfRuledCreate = null;
        public delegate A3DStatus PFA3DSurfPipeGet(IntPtr pSrf, ref A3DSurfPipeData pData);
        public static PFA3DSurfPipeGet A3DSurfPipeGet = null;
        public delegate A3DStatus PFA3DSurfPipeCreate(ref A3DSurfPipeData pData, out IntPtr ppSrf);
        public static PFA3DSurfPipeCreate A3DSurfPipeCreate = null;
        public delegate A3DStatus PFA3DSurfTransformGet(IntPtr pSrf, ref A3DSurfTransformData pData);
        public static PFA3DSurfTransformGet A3DSurfTransformGet = null;
        public delegate A3DStatus PFA3DSurfTransformCreate(ref A3DSurfTransformData pData, out IntPtr ppSrf);
        public static PFA3DSurfTransformCreate A3DSurfTransformCreate = null;
        public delegate A3DStatus PFA3DSurfFromCurvesGet(IntPtr pSrf, ref A3DSurfFromCurvesData pData);
        public static PFA3DSurfFromCurvesGet A3DSurfFromCurvesGet = null;
        public delegate A3DStatus PFA3DSurfFromCurvesCreate(ref A3DSurfFromCurvesData pData, out IntPtr ppSrf);
        public static PFA3DSurfFromCurvesCreate A3DSurfFromCurvesCreate = null;
        public delegate A3DStatus PFA3DGlobalGetPointer(out IntPtr ppGlobal);
        public static PFA3DGlobalGetPointer A3DGlobalGetPointer = null;
        public delegate A3DStatus PFA3DGlobalGet(IntPtr pGlobal, ref A3DGlobalData pData);
        public static PFA3DGlobalGet A3DGlobalGet = null;
        public delegate A3DStatus PFA3DGlobalIsMaterialTexture(uint uiIndexMaterial, out bool pbIsTexture);
        public static PFA3DGlobalIsMaterialTexture A3DGlobalIsMaterialTexture = null;
        public delegate A3DStatus PFA3DGlobalGetFillPatternType(uint uiIndexPattern, ref A3DEEntityType pePatternType);
        public static PFA3DGlobalGetFillPatternType A3DGlobalGetFillPatternType = null;
        public delegate A3DStatus PFA3DLicPutUnifiedLicense([MarshalAs(UnmanagedType.LPStr)] string pcUnifiedKey);
        public static PFA3DLicPutUnifiedLicense A3DLicPutUnifiedLicense = null;
        public delegate A3DStatus PFA3DMDPosition3DGet(IntPtr pPosition3D, ref A3DMDPosition3DData pData);
        public static PFA3DMDPosition3DGet A3DMDPosition3DGet = null;
        public delegate A3DStatus PFA3DMDPosition2DGet(IntPtr pPosition2D, ref A3DMDPosition2DData pData);
        public static PFA3DMDPosition2DGet A3DMDPosition2DGet = null;
        public delegate A3DStatus PFA3DMDPositionReferenceGet(IntPtr pPositionReference, ref A3DMDPositionReferenceData pData);
        public static PFA3DMDPositionReferenceGet A3DMDPositionReferenceGet = null;
        public delegate A3DStatus PFA3DMDLeaderSymbolGet(IntPtr pLeaderSymbol, ref A3DMDLeaderSymbolData pData);
        public static PFA3DMDLeaderSymbolGet A3DMDLeaderSymbolGet = null;
        public delegate A3DStatus PFA3DMDMarkupLeaderStubGet(IntPtr pLeaderStub, ref A3DMDMarkupLeaderStubData pData);
        public static PFA3DMDMarkupLeaderStubGet A3DMDMarkupLeaderStubGet = null;
        public delegate A3DStatus PFA3DMDLeaderDefinitionGet(IntPtr pLeader, ref A3DMDLeaderDefinitionData pData);
        public static PFA3DMDLeaderDefinitionGet A3DMDLeaderDefinitionGet = null;
        public delegate A3DStatus PFA3DMDTextPropertiesGet(IntPtr pTextProperties, ref A3DMDTextPropertiesData pData);
        public static PFA3DMDTextPropertiesGet A3DMDTextPropertiesGet = null;
        public delegate A3DStatus PFA3DMarkupDefinitionGet(IntPtr pMarkupDefinition, ref A3DMarkupDefinitionData pData);
        public static PFA3DMarkupDefinitionGet A3DMarkupDefinitionGet = null;
        public delegate A3DStatus PFA3DMarkupPositionIsScreenLocation(IntPtr pMarkupDefinition, out bool pIsScreenLocation, ref A3DMDPosition2DData pPosition, ref A3DVector2dData pOffsetAnchorPoint);
        public static PFA3DMarkupPositionIsScreenLocation A3DMarkupPositionIsScreenLocation = null;
        public delegate A3DStatus PFA3DMDDimensionValueFormatGet(IntPtr pDimensionValueFormat, ref A3DMDDimensionValueFormatData pData);
        public static PFA3DMDDimensionValueFormatGet A3DMDDimensionValueFormatGet = null;
        public delegate A3DStatus PFA3DMDDimensionSimpleToleranceFormatGet(IntPtr pDimensionToleranceFormat, ref A3DMDDimensionSimpleToleranceFormatData pData);
        public static PFA3DMDDimensionSimpleToleranceFormatGet A3DMDDimensionSimpleToleranceFormatGet = null;
        public delegate A3DStatus PFA3DMDDimensionCombinedToleranceFormatGet(IntPtr pDimensionCombinedToleranceFormat, ref A3DMDDimensionCombinedToleranceFormatData pData);
        public static PFA3DMDDimensionCombinedToleranceFormatGet A3DMDDimensionCombinedToleranceFormatGet = null;
        public delegate A3DStatus PFA3DMDDimensionValueGet(IntPtr pDimensionValue, ref A3DMDDimensionValueData pData);
        public static PFA3DMDDimensionValueGet A3DMDDimensionValueGet = null;
        public delegate A3DStatus PFA3DMDDimensionSecondPartGet(IntPtr pDimensionSecondPart, ref A3DMDDimensionSecondPartData pData);
        public static PFA3DMDDimensionSecondPartGet A3DMDDimensionSecondPartGet = null;
        public delegate A3DStatus PFA3DMDDimensionForeshortenedGet(IntPtr pDimensionForeshortened, ref A3DMDDimensionForeshortenedData pData);
        public static PFA3DMDDimensionForeshortenedGet A3DMDDimensionForeshortenedGet = null;
        public delegate A3DStatus PFA3DMDDimensionLineSymbolGet(IntPtr pDimensionLineSymbol, ref A3DMDDimensionLineSymbolData pData);
        public static PFA3DMDDimensionLineSymbolGet A3DMDDimensionLineSymbolGet = null;
        public delegate A3DStatus PFA3DMDDimensionLineGet(IntPtr pDimensionLine, ref A3DMDDimensionLineData pData);
        public static PFA3DMDDimensionLineGet A3DMDDimensionLineGet = null;
        public delegate A3DStatus PFA3DMDDimensionFunnelGet(IntPtr pDimensionFunnel, ref A3DMDDimensionFunnelData pData);
        public static PFA3DMDDimensionFunnelGet A3DMDDimensionFunnelGet = null;
        public delegate A3DStatus PFA3DMDDimensionExtremityGet(IntPtr pDimensionExtremity, ref A3DMDDimensionExtremityData pData);
        public static PFA3DMDDimensionExtremityGet A3DMDDimensionExtremityGet = null;
        public delegate A3DStatus PFA3DMDDimensionExtentionLineGet(IntPtr pDimensionExtentionLine, ref A3DMDDimensionExtentionLineData pData);
        public static PFA3DMDDimensionExtentionLineGet A3DMDDimensionExtentionLineGet = null;
        public delegate A3DStatus PFA3DMarkupDimensionGet(IntPtr pDimension, ref A3DMarkupDimensionData pData);
        public static PFA3DMarkupDimensionGet A3DMarkupDimensionGet = null;
        public delegate A3DStatus PFA3DMarkupRoughnessGet(IntPtr pMarkupRoughness, ref A3DMarkupRoughnessData pData);
        public static PFA3DMarkupRoughnessGet A3DMarkupRoughnessGet = null;
        public delegate A3DStatus PFA3DMarkupBalloonGet(IntPtr pBalloon, ref A3DMarkupBalloonData pData);
        public static PFA3DMarkupBalloonGet A3DMarkupBalloonGet = null;
        public delegate A3DStatus PFA3DMarkupFastenerGet(IntPtr pFastener, ref A3DMarkupFastenerData pData);
        public static PFA3DMarkupFastenerGet A3DMarkupFastenerGet = null;
        public delegate A3DStatus PFA3DMarkupLocatorGet(IntPtr pLocator, ref A3DMarkupLocatorData pData);
        public static PFA3DMarkupLocatorGet A3DMarkupLocatorGet = null;
        public delegate A3DStatus PFA3DMarkupMeasurementPointGet(IntPtr pMeasurementPoint, ref A3DMarkupMeasurementPointData pData);
        public static PFA3DMarkupMeasurementPointGet A3DMarkupMeasurementPointGet = null;
        public delegate A3DStatus PFA3DMDTextPositionGet(IntPtr pTextPosition, ref A3DMDTextPositionData pData);
        public static PFA3DMDTextPositionGet A3DMDTextPositionGet = null;
        public delegate A3DStatus PFA3DMarkupTextGet(IntPtr pMarkupText, ref A3DMarkupTextData pData);
        public static PFA3DMarkupTextGet A3DMarkupTextGet = null;
        public delegate A3DStatus PFA3DMarkupCoordinateGet(IntPtr pMarkupCoordinate, ref A3DMarkupCoordinateData pData);
        public static PFA3DMarkupCoordinateGet A3DMarkupCoordinateGet = null;
        public delegate A3DStatus PFA3DMarkupRichTextGet(IntPtr pMarkupRichText, ref A3DMarkupRichTextData pData);
        public static PFA3DMarkupRichTextGet A3DMarkupRichTextGet = null;
        public delegate A3DStatus PFA3DMarkupDatumGet(IntPtr pMarkupDatum, ref A3DMarkupDatumData pData);
        public static PFA3DMarkupDatumGet A3DMarkupDatumGet = null;
        public delegate A3DStatus PFA3DMDFCFDraftingRowGet(IntPtr pDraftingRow, ref A3DMDFCFDraftingRowData pData);
        public static PFA3DMDFCFDraftingRowGet A3DMDFCFDraftingRowGet = null;
        public delegate A3DStatus PFA3DMDFCValueGet(IntPtr pValue, ref A3DMDFCValueData pData);
        public static PFA3DMDFCValueGet A3DMDFCValueGet = null;
        public delegate A3DStatus PFA3DMDFCTolerancePerUnitGet(IntPtr pTolerancePerUnit, ref A3DMDFCTolerancePerUnitData pData);
        public static PFA3DMDFCTolerancePerUnitGet A3DMDFCTolerancePerUnitGet = null;
        public delegate A3DStatus PFA3DMDFCProjectedZoneGet(IntPtr pProjectedZone, ref A3DMDFCProjectedZoneData pData);
        public static PFA3DMDFCProjectedZoneGet A3DMDFCProjectedZoneGet = null;
        public delegate A3DStatus PFA3DMDFCFToleranceValueGet(IntPtr pToleranceValue, ref A3DMDFCFToleranceValueData pData);
        public static PFA3DMDFCFToleranceValueGet A3DMDFCFToleranceValueGet = null;
        public delegate A3DStatus PFA3DMDFCFRowDatumGet(IntPtr pRowDatum, ref A3DMDFCFRowDatumData pData);
        public static PFA3DMDFCFRowDatumGet A3DMDFCFRowDatumGet = null;
        public delegate A3DStatus PFA3DMDFCFDrawingRowGet(IntPtr pDrawingRow, ref A3DMDFCFDrawingRowData pData);
        public static PFA3DMDFCFDrawingRowGet A3DMDFCFDrawingRowGet = null;
        public delegate A3DStatus PFA3DMDFCFSemanticRowGet(IntPtr pRow, ref A3DMDFCFDrawingRowData pData);
        public static PFA3DMDFCFSemanticRowGet A3DMDFCFSemanticRowGet = null;
        public delegate A3DStatus PFA3DMDFCFIndicatorGet(IntPtr pIndicator, ref A3DMDFCFIndicatorData pData);
        public static PFA3DMDFCFIndicatorGet A3DMDFCFIndicatorGet = null;
        public delegate A3DStatus PFA3DMDFeatureControlFrameGet(IntPtr pFCF, ref A3DMDFeatureControlFrameData pData);
        public static PFA3DMDFeatureControlFrameGet A3DMDFeatureControlFrameGet = null;
        public delegate A3DStatus PFA3DMDSemanticFeatureControlFrameGet(IntPtr pFCF, ref A3DMDFeatureControlFrameData pData);
        public static PFA3DMDSemanticFeatureControlFrameGet A3DMDSemanticFeatureControlFrameGet = null;
        public delegate A3DStatus PFA3DMDToleranceSizeGet(IntPtr pToleranceSize, ref A3DMDToleranceSizeData pData);
        public static PFA3DMDToleranceSizeGet A3DMDToleranceSizeGet = null;
        public delegate A3DStatus PFA3DMDToleranceSizeValueGet(IntPtr pToleranceSizeValue, ref A3DMDToleranceSizeValueData pData);
        public static PFA3DMDToleranceSizeValueGet A3DMDToleranceSizeValueGet = null;
        public delegate A3DStatus PFA3DMarkupGDTGet(IntPtr pMarkupGDT, ref A3DMarkupGDTData pData);
        public static PFA3DMarkupGDTGet A3DMarkupGDTGet = null;
        public delegate A3DStatus PFA3DMarkupSpotWeldingGet(IntPtr pSpotWelding, ref A3DMarkupSpotWeldingData pData);
        public static PFA3DMarkupSpotWeldingGet A3DMarkupSpotWeldingGet = null;
        public delegate A3DStatus PFA3DMarkupLineWeldingGet(IntPtr pLineWelding, ref A3DMarkupLineWeldingData pData);
        public static PFA3DMarkupLineWeldingGet A3DMarkupLineWeldingGet = null;
        public delegate A3DStatus PFA3DMathFct1DPolynomGet(IntPtr pMathFn, ref A3DMathFct1DPolynomData pData);
        public static PFA3DMathFct1DPolynomGet A3DMathFct1DPolynomGet = null;
        public delegate A3DStatus PFA3DMathFct1DPolynomCreate(ref A3DMathFct1DPolynomData pData, out IntPtr ppMathFn);
        public static PFA3DMathFct1DPolynomCreate A3DMathFct1DPolynomCreate = null;
        public delegate A3DStatus PFA3DMathFct1DTrigonometricGet(IntPtr pMathFn, ref A3DMathFct1DTrigonometricData pData);
        public static PFA3DMathFct1DTrigonometricGet A3DMathFct1DTrigonometricGet = null;
        public delegate A3DStatus PFA3DMathFct1DTrigonometricCreate(ref A3DMathFct1DTrigonometricData pData, out IntPtr ppMathFn);
        public static PFA3DMathFct1DTrigonometricCreate A3DMathFct1DTrigonometricCreate = null;
        public delegate A3DStatus PFA3DMathFct1DFractionGet(IntPtr pMathFn, ref A3DMathFct1DFractionData pData);
        public static PFA3DMathFct1DFractionGet A3DMathFct1DFractionGet = null;
        public delegate A3DStatus PFA3DMathFct1DFractionCreate(ref A3DMathFct1DFractionData pData, out IntPtr ppMathFn);
        public static PFA3DMathFct1DFractionCreate A3DMathFct1DFractionCreate = null;
        public delegate A3DStatus PFA3DMathFct1DArctanCosGet(IntPtr pMathFn, ref A3DMathFct1DArctanCosData pData);
        public static PFA3DMathFct1DArctanCosGet A3DMathFct1DArctanCosGet = null;
        public delegate A3DStatus PFA3DMathFct1DArctanCosCreate(ref A3DMathFct1DArctanCosData pData, out IntPtr ppMathFn);
        public static PFA3DMathFct1DArctanCosCreate A3DMathFct1DArctanCosCreate = null;
        public delegate A3DStatus PFA3DMathFct1DCombinationGet(IntPtr pMathFn, ref A3DMathFct1DCombinationData pData);
        public static PFA3DMathFct1DCombinationGet A3DMathFct1DCombinationGet = null;
        public delegate A3DStatus PFA3DMathFct1DCombinationCreate(ref A3DMathFct1DCombinationData pData, out IntPtr ppMathFn);
        public static PFA3DMathFct1DCombinationCreate A3DMathFct1DCombinationCreate = null;
        public delegate A3DStatus PFA3DMathFct3DLinearGet(IntPtr pMathFn, ref A3DMathFct3DLinearData pData);
        public static PFA3DMathFct3DLinearGet A3DMathFct3DLinearGet = null;
        public delegate A3DStatus PFA3DMathFct3DLinearCreate(ref A3DMathFct3DLinearData pData, out IntPtr ppMathFn);
        public static PFA3DMathFct3DLinearCreate A3DMathFct3DLinearCreate = null;
        public delegate A3DStatus PFA3DMathFct3DNonLinearGet(IntPtr pMathFn, ref A3DMathFct3DNonLinearData pData);
        public static PFA3DMathFct3DNonLinearGet A3DMathFct3DNonLinearGet = null;
        public delegate A3DStatus PFA3DMathFct3DNonLinearCreate(ref A3DMathFct3DNonLinearData pData, out IntPtr ppMathFn);
        public static PFA3DMathFct3DNonLinearCreate A3DMathFct3DNonLinearCreate = null;
        public delegate A3DStatus PFA3DEntityGetType(IntPtr pEntity, ref A3DEEntityType peEntityType);
        public static PFA3DEntityGetType A3DEntityGetType = null;
        public delegate bool PFA3DEntityIsBaseWithGraphicsType(IntPtr pEntity);
        public static PFA3DEntityIsBaseWithGraphicsType A3DEntityIsBaseWithGraphicsType = null;
        public delegate bool PFA3DEntityIsBaseType(IntPtr pEntity);
        public static PFA3DEntityIsBaseType A3DEntityIsBaseType = null;
        public delegate A3DStatus PFA3DRootBaseGet(IntPtr pRootBase, ref A3DRootBaseData pData);
        public static PFA3DRootBaseGet A3DRootBaseGet = null;
        public delegate A3DStatus PFA3DRootBaseSet(IntPtr pRootBase, ref A3DRootBaseData pData);
        public static PFA3DRootBaseSet A3DRootBaseSet = null;
        public delegate A3DStatus PFA3DRootBaseAttributeRemoveAll(IntPtr pEntity);
        public static PFA3DRootBaseAttributeRemoveAll A3DRootBaseAttributeRemoveAll = null;
        public delegate A3DStatus PFA3DRootBaseAttributeRemove(IntPtr pEntity, [MarshalAs(UnmanagedType.LPStr)] string pcTitle);
        public static PFA3DRootBaseAttributeRemove A3DRootBaseAttributeRemove = null;
        public delegate A3DStatus PFA3DRootBaseAttributeRemoveAt(IntPtr pEntity, uint uIndex);
        public static PFA3DRootBaseAttributeRemoveAt A3DRootBaseAttributeRemoveAt = null;
        public delegate A3DStatus PFA3DRootBaseAttributeAppend(IntPtr pEntity, uint uiSize, out IntPtr m_ppAttributes);
        public static PFA3DRootBaseAttributeAppend A3DRootBaseAttributeAppend = null;
        public delegate A3DStatus PFA3DRootBaseAttributeAdd(IntPtr pEntity, [MarshalAs(UnmanagedType.LPStr)] string pcTitle, [MarshalAs(UnmanagedType.LPStr)] string pcValue);
        public static PFA3DRootBaseAttributeAdd A3DRootBaseAttributeAdd = null;
        public delegate A3DStatus PFA3DRootBaseWithGraphicsGet(IntPtr pRoot, ref A3DRootBaseWithGraphicsData pData);
        public static PFA3DRootBaseWithGraphicsGet A3DRootBaseWithGraphicsGet = null;
        public delegate A3DStatus PFA3DRootBaseWithGraphicsSet(IntPtr pRoot, ref A3DRootBaseWithGraphicsData pData);
        public static PFA3DRootBaseWithGraphicsSet A3DRootBaseWithGraphicsSet = null;
        public delegate A3DStatus PFA3DMiscAttributeGet(IntPtr pAttribute, ref A3DMiscAttributeData pData);
        public static PFA3DMiscAttributeGet A3DMiscAttributeGet = null;
        public delegate A3DStatus PFA3DMiscAttributeCreate(ref A3DMiscAttributeData pData, out IntPtr ppAttribute);
        public static PFA3DMiscAttributeCreate A3DMiscAttributeCreate = null;
        public delegate A3DStatus PFA3DGlobalGetUnit(uint uiIndexUnit, out IntPtr ppUnit);
        public static PFA3DGlobalGetUnit A3DGlobalGetUnit = null;
        public delegate A3DStatus PFA3DGlobalGetUnitData(IntPtr pUnit, ref A3DMiscAttributeUnitData pData);
        public static PFA3DGlobalGetUnitData A3DGlobalGetUnitData = null;
        public delegate A3DStatus PFA3DCopyAndAdaptBrepModel(IntPtr p, ref A3DCopyAndAdaptBrepModelData psSetting, out IntPtr pp);
        public static PFA3DCopyAndAdaptBrepModel A3DCopyAndAdaptBrepModel = null;
        public delegate A3DStatus PFA3DCopyAndAdaptBrepModelAdvanced(IntPtr p, ref A3DCopyAndAdaptBrepModelData psSetting, out IntPtr pp, out uint puiNbErrors, IntPtr paiErrors);
        public static PFA3DCopyAndAdaptBrepModelAdvanced A3DCopyAndAdaptBrepModelAdvanced = null;
        public delegate A3DStatus PFA3DAdaptAndReplaceAllBrepInModelFile(IntPtr pModelFile, ref A3DCopyAndAdaptBrepModelData psSetting);
        public static PFA3DAdaptAndReplaceAllBrepInModelFile A3DAdaptAndReplaceAllBrepInModelFile = null;
        public delegate A3DStatus PFA3DAdaptAndReplaceAllBrepInModelFileAdvanced(IntPtr p, ref A3DCopyAndAdaptBrepModelData psSetting, out uint puiNbErrors, IntPtr pErrors);
        public static PFA3DAdaptAndReplaceAllBrepInModelFileAdvanced A3DAdaptAndReplaceAllBrepInModelFileAdvanced = null;
        public delegate A3DStatus PFA3DEntityDelete(IntPtr pEntity);
        public static PFA3DEntityDelete A3DEntityDelete = null;
        public delegate A3DStatus PFA3DEntityGetPDFNodeIdFromWrite(IntPtr pEntity, IntPtr pEntityFather, IntPtr pA3DRWParamsPrcWriteHelper, IntPtr pcUTF8Name);
        public static PFA3DEntityGetPDFNodeIdFromWrite A3DEntityGetPDFNodeIdFromWrite = null;
        public delegate A3DStatus PFA3DEntityGetPDFNodeIdFromRead(IntPtr pEntity, IntPtr pEntityFather, IntPtr pA3DRWParamsPrcReadHelper, IntPtr pcUTF8Name);
        public static PFA3DEntityGetPDFNodeIdFromRead A3DEntityGetPDFNodeIdFromRead = null;
        public delegate A3DStatus PFA3DTopoItemOwnersManagerGet(IntPtr pBrepOwner, out IntPtr ppTopoItemOwnersManager);
        public static PFA3DTopoItemOwnersManagerGet A3DTopoItemOwnersManagerGet = null;
        public delegate A3DStatus PFA3DTopoItemOwnersGet(IntPtr pTopoItemOwnersManager, IntPtr pTopoItem, IntPtr ppTopoItemOwner);
        public static PFA3DTopoItemOwnersGet A3DTopoItemOwnersGet = null;
        public delegate A3DStatus PFA3DComputePhysicalProperties(IntPtr p, ref A3DVector3dData psScale, ref A3DPhysicalPropertiesData psPhysicalPropertiesData);
        public static PFA3DComputePhysicalProperties A3DComputePhysicalProperties = null;
        public delegate A3DStatus PFA3DComputeFaceArea(IntPtr pFace, IntPtr pBrepDataTopoContext, out double pArea);
        public static PFA3DComputeFaceArea A3DComputeFaceArea = null;
        public delegate A3DStatus PFA3DComputePolyBrepPhysicalProperties(IntPtr p, ref A3DVector3dData psScale, ref A3DPhysicalPropertiesData psPhysicalPropertiesData);
        public static PFA3DComputePolyBrepPhysicalProperties A3DComputePolyBrepPhysicalProperties = null;
        public delegate A3DStatus PFA3DComputeModelFilePhysicalProperties(IntPtr p, ref A3DPhysicalPropertiesData psPhysicalProperties);
        public static PFA3DComputeModelFilePhysicalProperties A3DComputeModelFilePhysicalProperties = null;
        public delegate A3DStatus PFA3DSimplifyModelFileCurveAndSurfaceAsAnalytic(IntPtr p, double dTol);
        public static PFA3DSimplifyModelFileCurveAndSurfaceAsAnalytic A3DSimplifyModelFileCurveAndSurfaceAsAnalytic = null;
        public delegate A3DStatus PFA3DSimplifyModelFileWithAnalytics(IntPtr p, double dTol, uint uNbRecognizedType, IntPtr pOptRecognizedType);
        public static PFA3DSimplifyModelFileWithAnalytics A3DSimplifyModelFileWithAnalytics = null;
        public delegate A3DStatus PFA3DTopoBodyGet(IntPtr pBody, ref A3DTopoBodyData pData);
        public static PFA3DTopoBodyGet A3DTopoBodyGet = null;
        public delegate A3DStatus PFA3DTopoBodySet(IntPtr pBody, ref A3DTopoBodyData pData);
        public static PFA3DTopoBodySet A3DTopoBodySet = null;
        public delegate A3DStatus PFA3DTopoContextGet(IntPtr pContext, ref A3DTopoContextData pData);
        public static PFA3DTopoContextGet A3DTopoContextGet = null;
        public delegate A3DStatus PFA3DTopoContextCreate(ref A3DTopoContextData pData, out IntPtr ppContext);
        public static PFA3DTopoContextCreate A3DTopoContextCreate = null;
        public delegate A3DStatus PFA3DTopoSingleWireBodyGet(IntPtr pSingleWireBody, ref A3DTopoSingleWireBodyData pData);
        public static PFA3DTopoSingleWireBodyGet A3DTopoSingleWireBodyGet = null;
        public delegate A3DStatus PFA3DTopoSingleWireBodyCreate(ref A3DTopoSingleWireBodyData pData, out IntPtr ppSingleWireBody);
        public static PFA3DTopoSingleWireBodyCreate A3DTopoSingleWireBodyCreate = null;
        public delegate A3DStatus PFA3DTopoBrepDataGet(IntPtr pBrep, ref A3DTopoBrepDataData pData);
        public static PFA3DTopoBrepDataGet A3DTopoBrepDataGet = null;
        public delegate A3DStatus PFA3DTopoBrepDataCreate(ref A3DTopoBrepDataData pData, out IntPtr ppBrep);
        public static PFA3DTopoBrepDataCreate A3DTopoBrepDataCreate = null;
        public delegate A3DStatus PFA3DTopoBrepDataGetFaces(IntPtr psBrepData, out uint psNbFaces, IntPtr papsFaces);
        public static PFA3DTopoBrepDataGetFaces A3DTopoBrepDataGetFaces = null;
        public delegate A3DStatus PFA3DTopoBrepDataGetEdges(IntPtr psBrepData, out uint piNbEdges, IntPtr papsEdges);
        public static PFA3DTopoBrepDataGetEdges A3DTopoBrepDataGetEdges = null;
        public delegate A3DStatus PFA3DTopoConnexGet(IntPtr pConnex, ref A3DTopoConnexData pData);
        public static PFA3DTopoConnexGet A3DTopoConnexGet = null;
        public delegate A3DStatus PFA3DTopoConnexCreate(ref A3DTopoConnexData pData, out IntPtr ppConnex);
        public static PFA3DTopoConnexCreate A3DTopoConnexCreate = null;
        public delegate A3DStatus PFA3DTopoShellGet(IntPtr pShell, ref A3DTopoShellData pData);
        public static PFA3DTopoShellGet A3DTopoShellGet = null;
        public delegate A3DStatus PFA3DTopoShellCreate(ref A3DTopoShellData pData, out IntPtr ppShell);
        public static PFA3DTopoShellCreate A3DTopoShellCreate = null;
        public delegate A3DStatus PFA3DTopoFaceGet(IntPtr pFace, ref A3DTopoFaceData pData);
        public static PFA3DTopoFaceGet A3DTopoFaceGet = null;
        public delegate A3DStatus PFA3DTopoFaceCreate(ref A3DTopoFaceData pData, out IntPtr ppFace);
        public static PFA3DTopoFaceCreate A3DTopoFaceCreate = null;
        public delegate A3DStatus PFA3DTopoFaceGetShellAndOrientation(IntPtr psBrepData, IntPtr psFace, out IntPtr ppsShell, out byte pusOrientation);
        public static PFA3DTopoFaceGetShellAndOrientation A3DTopoFaceGetShellAndOrientation = null;
        public delegate A3DStatus PFA3DTopoFaceGetShell(IntPtr psBrepData, IntPtr psFace, out IntPtr ppsShell);
        public static PFA3DTopoFaceGetShell A3DTopoFaceGetShell = null;
        public delegate A3DStatus PFA3DTopoLoopGet(IntPtr pLoop, ref A3DTopoLoopData pData);
        public static PFA3DTopoLoopGet A3DTopoLoopGet = null;
        public delegate A3DStatus PFA3DTopoLoopCreate(ref A3DTopoLoopData pData, out IntPtr ppLoop);
        public static PFA3DTopoLoopCreate A3DTopoLoopCreate = null;
        public delegate A3DStatus PFA3DTopoLoopGetFace(IntPtr psBrepData, IntPtr psLoop, out IntPtr ppsFace);
        public static PFA3DTopoLoopGetFace A3DTopoLoopGetFace = null;
        public delegate A3DStatus PFA3DTopoCoEdgeGet(IntPtr pCoEdge, ref A3DTopoCoEdgeData pData);
        public static PFA3DTopoCoEdgeGet A3DTopoCoEdgeGet = null;
        public delegate A3DStatus PFA3DTopoCoEdgeCreate(ref A3DTopoCoEdgeData pData, out IntPtr ppCoEdge);
        public static PFA3DTopoCoEdgeCreate A3DTopoCoEdgeCreate = null;
        public delegate A3DStatus PFA3DTopoCoEdgeSetNeighbour(IntPtr pCoEdge, IntPtr pNeighbour);
        public static PFA3DTopoCoEdgeSetNeighbour A3DTopoCoEdgeSetNeighbour = null;
        public delegate A3DStatus PFA3DTopoCoedgeGetLoop(IntPtr psCoEdge, out IntPtr ppsLoop);
        public static PFA3DTopoCoedgeGetLoop A3DTopoCoedgeGetLoop = null;
        public delegate A3DStatus PFA3DTopoEdgeGet(IntPtr pEdge, ref A3DTopoEdgeData pData);
        public static PFA3DTopoEdgeGet A3DTopoEdgeGet = null;
        public delegate A3DStatus PFA3DTopoEdgeCreate(ref A3DTopoEdgeData pData, out IntPtr ppEdge);
        public static PFA3DTopoEdgeCreate A3DTopoEdgeCreate = null;
        public delegate A3DStatus PFA3DTopoEdgeGetCoEdges(IntPtr psBrepData, IntPtr psEdge, out uint piNbCoedges, IntPtr papsCoEdges);
        public static PFA3DTopoEdgeGetCoEdges A3DTopoEdgeGetCoEdges = null;
        public delegate A3DStatus PFA3DTopoEdgeGetSurfaces(IntPtr psBrepData, IntPtr psEdge, out uint piNbSurfaces, IntPtr papsSurfaces);
        public static PFA3DTopoEdgeGetSurfaces A3DTopoEdgeGetSurfaces = null;
        public delegate A3DStatus PFA3DTopoEdgeGetOrCompute3DCurve(IntPtr psBrepData, IntPtr psEdge, out IntPtr pps3DCurve);
        public static PFA3DTopoEdgeGetOrCompute3DCurve A3DTopoEdgeGetOrCompute3DCurve = null;
        public delegate A3DStatus PFA3DTopoWireEdgeGet(IntPtr pWireEdge, ref A3DTopoWireEdgeData pData);
        public static PFA3DTopoWireEdgeGet A3DTopoWireEdgeGet = null;
        public delegate A3DStatus PFA3DTopoWireEdgeCreate(ref A3DTopoWireEdgeData pData, out IntPtr ppWireEdge);
        public static PFA3DTopoWireEdgeCreate A3DTopoWireEdgeCreate = null;
        public delegate A3DStatus PFA3DTopoUniqueVertexGet(IntPtr pUniqueVertex, ref A3DTopoUniqueVertexData pData);
        public static PFA3DTopoUniqueVertexGet A3DTopoUniqueVertexGet = null;
        public delegate A3DStatus PFA3DTopoUniqueVertexCreate(ref A3DTopoUniqueVertexData pData, out IntPtr ppUniqueVertex);
        public static PFA3DTopoUniqueVertexCreate A3DTopoUniqueVertexCreate = null;
        public delegate A3DStatus PFA3DTopoMultipleVertexGet(IntPtr pMultipleVertex, ref A3DTopoMultipleVertexData pData);
        public static PFA3DTopoMultipleVertexGet A3DTopoMultipleVertexGet = null;
        public delegate A3DStatus PFA3DTopoMultipleVertexCreate(ref A3DTopoMultipleVertexData pData, out IntPtr ppMultipleVertex);
        public static PFA3DTopoMultipleVertexCreate A3DTopoMultipleVertexCreate = null;
    }
}
