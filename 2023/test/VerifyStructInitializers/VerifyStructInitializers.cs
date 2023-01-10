using System;
using System.Runtime.InteropServices;
using TS3D.Exchange.Direct;

namespace TS3D.Exchange.Test {
    class Program {
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DVector2dData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DVector3dData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DIntervalData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DDomainData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DBoundingBoxData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DParameterizationData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DUVParameterizationData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DTessBaseData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DTessFaceData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DTess3DData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DTess3DWireData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DTessMarkupData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DGraphicsData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DGraphStyleData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DGraphRgbColorData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DGraphLinePatternData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DGraphMaterialData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DGraphPictureData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DGraphDottingPatternData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DGraphHatchingPatternLineData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DGraphHatchingPatternData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DGraphSolidPatternData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DGraphVPicturePatternData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DGraphCameraData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DGraphAmbientLightData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DGraphPointLightData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DGraphSpotLightData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DGraphDirectionalLightData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DGraphSceneDisplayParametersData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMiscCascadedAttributesData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMiscGeneralTransformationData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMiscCartesianTransformationData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMiscEntityReferenceData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMiscReferenceOnTopologyData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMiscReferenceOnTessData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMiscReferenceOnCsysItemData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMiscPhysicMaterialData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMiscMaterialFiberData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMiscMaterialHoneyCombData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMiscMaterialIsotropicData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMiscMaterialOrthotropic2DData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMiscMaterialOrthotropic3DData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMiscMaterialAnisotropicData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMiscMaterialPropertiesData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DAsmModelFileData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DAsmProductOccurrenceData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DAsmProductOccurrenceDataSLW(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DAsmProductOccurrenceDataCat(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DAsmProductOccurrenceDataCV5(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DAsmProductOccurrenceDataUg(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DAsmProductOccurrenceDataProe(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DAsmProductOccurrenceDataInv(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DAsmProductOccurrenceDataJT(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DAsmPartDefinitionData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DAsmLayerFilterItemData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DAsmEntityFilterItemData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DAsmFilterData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DRWParamsGeneralData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DRWParamsPmiData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DRWParamsTessellationData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DRWParamsSearchDirData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DRWParamsAssemblyData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DRWParamsMultiEntriesData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DRWParamsCatiaV4Data(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DRWParamsCatiaV5Data(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DRWParamsUnigraphicsData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DRWParamsProEData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DRWValidationPropertiesThresholdData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DRWParamsStepData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DRWParamsIGESData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DRWParamsIFCData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DRWParamsJTData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DRWParamsParasolidData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DRWParamsSolidworksData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DRWParamsInventorData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DRWParamsRhinoData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DRWParamsRevitData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DRWParamsSpecificLoadData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DRWParamsIncrementalLoadData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DRWParamsLoadData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DStream3DPDFData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DRWParamsExportPrcData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DRWParamsExportU3DData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DRWParamsExportStepData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DRWParamsExportJTData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DRWParamsExportIgesData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DRWParamsExportStlData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DRWParamsExport3mfData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DRWParamsExportXMLData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DRWParamsExportObjData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DRWParamsExportFbxData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DRWParamsExportGltfData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DSewOptionsData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DFaceUVPointInsideManagerData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DProjectedPointCloudData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DProjectPointCloudManagerDataFromRI(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DProjectPointCloudOptionsData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DPlanarSectionData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DCompareInputData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DCompareOutputData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMultiPlanarSectionData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DHLRViewPlaneData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DHLRCurveData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DHLRSectionFaceData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DHLRRepresentationItemData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DHLROptionsData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DTransfoRepresentationItemData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DCollisionGroupData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DCollisionParameterData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DCollisionResultData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DBIMDataData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DBIMRelContainedInSpatialStructureData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DBIMRelFillsElementData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DBIMRelSpaceBoundaryData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DBIMRelAggregatesData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DBIMRelVoidsElementData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DBIMRelConnectsPathElementsData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DBIMRootData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMiscConstraintLinkedItemData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DAsmConstraintData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMkpLeaderData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMkpAnnotationItemData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMkpAnnotationSetData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMkpAnnotationReferenceData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMkpViewData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMkpViewFlagsData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMiscMarkupLinkedItemData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMkpMarkupData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMkpRTFFieldData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DFontKeyData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DFontData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DGraphTextureTransformationData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DGraphTextureDefinitionData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DGraphTextureApplicationData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DDrawingModelData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DDrawingSheetFormatData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DDrawingSheetData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DDrawingClipFrameData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DDrawingViewData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DDrawingBlockBasicData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DDrawingBlockOperatorData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DDrawingCurveData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DDrawingFilledAreaData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DDrawingPictureData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DDrawingVerticesData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DThumbnailData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DFileInformationData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DFileContextData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DRWParamsExportParasolidData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DRWParamsTranslateToPkPartsData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DRWParamsExportAcisData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DRiRepresentationItemData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DRiSetData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DRiPointSetData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DRiDirectionData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DRiCoordinateSystemData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DRiCurveData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DRiPlaneData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DRiBrepModelData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DRiPolyBrepModelData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DRiPolyWireData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DFRMTreeData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DFRMParameterData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DFRMTypeData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DFRMStringData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DFRMDoubleData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DFRMIntegerData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DFRMLinkedItemData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DFRMFeatureData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DFRMGeomEntitiesData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DCrvNurbsData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DCrvLineData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DCrvCircleData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DCrvEllipseData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DCrvParabolaData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DCrvHyperbolaData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DCrvPolyLineData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DCrvCompositeData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DCrvEquationData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DCrvTransformData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DCrvOnSurfData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DCrvOffsetData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DCrvHelixPitchCstData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DCrvHelixPitchVarData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DCrvHelixData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DCrossingPointsCrvIntersectionData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DCrvIntersectionData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DCrvBlend02BoundaryData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DSurfNurbsData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DSurfSphereData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DSurfCylinderData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DSurfTorusData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DSurfRevolutionData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DSurfExtrusionData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DSurfOffsetData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DSurfPlaneData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DSurfBlend01Data(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DSurfBlend02Data(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DSurfBlend03Data(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DSurfConeData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DSurfCylindricalData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DSurfRuledData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DSurfPipeData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DSurfTransformData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DSurfFromCurvesData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DGlobalData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMDPosition3DData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMDPosition2DData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMDPositionReferenceData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMDLeaderSymbolData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMDMarkupLeaderStubData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMDLeaderDefinitionData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMDTextPropertiesData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMarkupDefinitionData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMDDimensionValueFormatData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMDDimensionSimpleToleranceFormatData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMDDimensionCombinedToleranceFormatData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMDDimensionValueData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMDDimensionSecondPartData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMDDimensionForeshortenedData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMDDimensionLineSymbolData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMDDimensionLineData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMDDimensionFunnelData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMDDimensionExtremityData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMDDimensionExtentionLineData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMarkupDimensionData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMarkupRoughnessData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMarkupBalloonData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMarkupFastenerData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMarkupLocatorData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMarkupMeasurementPointData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMDTextPositionData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMarkupTextData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMarkupCoordinateData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMarkupRichTextData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMarkupDatumData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMDFCFDraftingRowData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMDFCValueData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMDFCTolerancePerUnitData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMDFCProjectedZoneData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMDFCFToleranceValueData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMDFCFRowDatumData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMDFCFDrawingRowData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMDFCFIndicatorData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMDFCFDraftingIndicatorData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMDFeatureControlFrameData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMDToleranceSizeValueData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMDToleranceSizeData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMarkupGDTData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMarkupSpotWeldingData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMarkupLineWeldingData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMathFct1DPolynomData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMathFct1DTrigonometricData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMathFct1DFractionData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMathFct1DArctanCosData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMathFct1DCombinationData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMathFct3DLinearData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMathFct3DNonLinearData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DRootBaseData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DRootBaseWithGraphicsData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMiscSingleAttributeData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMiscAttributeData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMiscAttributeBasicUnitData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DMiscAttributeUnitData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DCopyAndAdaptBrepModelData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DPhysicalPropertiesData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DTopoBodyData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DTopoContextData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DTopoSingleWireBodyData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DTopoBrepDataData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DTopoConnexData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DTopoShellData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DTopoFaceData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DTopoLoopData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DTopoCoEdgeData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DTopoEdgeData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DTopoWireEdgeData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DTopoUniqueVertexData(IntPtr d);
        [DllImport("build/VerifyInitializers.test")]
        private static extern Int32 Verify_A3DTopoMultipleVertexData(IntPtr d);
        static void Main( string[] args) {
            {
                A3DVector2dData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DVector2dData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DVector2dData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DVector3dData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DVector3dData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DVector3dData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DIntervalData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DIntervalData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DIntervalData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DDomainData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DDomainData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DDomainData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DBoundingBoxData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DBoundingBoxData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DBoundingBoxData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DParameterizationData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DParameterizationData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DParameterizationData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DUVParameterizationData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DUVParameterizationData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DUVParameterizationData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DTessBaseData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DTessBaseData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DTessBaseData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DTessFaceData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DTessFaceData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DTessFaceData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DTess3DData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DTess3DData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DTess3DData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DTess3DWireData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DTess3DWireData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DTess3DWireData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DTessMarkupData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DTessMarkupData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DTessMarkupData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DGraphicsData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DGraphicsData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DGraphicsData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DGraphStyleData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DGraphStyleData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DGraphStyleData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DGraphRgbColorData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DGraphRgbColorData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DGraphRgbColorData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DGraphLinePatternData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DGraphLinePatternData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DGraphLinePatternData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DGraphMaterialData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DGraphMaterialData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DGraphMaterialData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DGraphPictureData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DGraphPictureData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DGraphPictureData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DGraphDottingPatternData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DGraphDottingPatternData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DGraphDottingPatternData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DGraphHatchingPatternLineData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DGraphHatchingPatternLineData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DGraphHatchingPatternLineData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DGraphHatchingPatternData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DGraphHatchingPatternData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DGraphHatchingPatternData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DGraphSolidPatternData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DGraphSolidPatternData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DGraphSolidPatternData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DGraphVPicturePatternData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DGraphVPicturePatternData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DGraphVPicturePatternData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DGraphCameraData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DGraphCameraData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DGraphCameraData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DGraphAmbientLightData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DGraphAmbientLightData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DGraphAmbientLightData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DGraphPointLightData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DGraphPointLightData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DGraphPointLightData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DGraphSpotLightData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DGraphSpotLightData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DGraphSpotLightData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DGraphDirectionalLightData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DGraphDirectionalLightData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DGraphDirectionalLightData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DGraphSceneDisplayParametersData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DGraphSceneDisplayParametersData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DGraphSceneDisplayParametersData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMiscCascadedAttributesData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMiscCascadedAttributesData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMiscCascadedAttributesData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMiscGeneralTransformationData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMiscGeneralTransformationData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMiscGeneralTransformationData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMiscCartesianTransformationData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMiscCartesianTransformationData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMiscCartesianTransformationData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMiscEntityReferenceData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMiscEntityReferenceData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMiscEntityReferenceData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMiscReferenceOnTopologyData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMiscReferenceOnTopologyData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMiscReferenceOnTopologyData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMiscReferenceOnTessData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMiscReferenceOnTessData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMiscReferenceOnTessData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMiscReferenceOnCsysItemData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMiscReferenceOnCsysItemData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMiscReferenceOnCsysItemData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMiscPhysicMaterialData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMiscPhysicMaterialData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMiscPhysicMaterialData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMiscMaterialFiberData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMiscMaterialFiberData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMiscMaterialFiberData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMiscMaterialHoneyCombData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMiscMaterialHoneyCombData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMiscMaterialHoneyCombData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMiscMaterialIsotropicData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMiscMaterialIsotropicData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMiscMaterialIsotropicData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMiscMaterialOrthotropic2DData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMiscMaterialOrthotropic2DData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMiscMaterialOrthotropic2DData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMiscMaterialOrthotropic3DData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMiscMaterialOrthotropic3DData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMiscMaterialOrthotropic3DData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMiscMaterialAnisotropicData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMiscMaterialAnisotropicData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMiscMaterialAnisotropicData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMiscMaterialPropertiesData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMiscMaterialPropertiesData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMiscMaterialPropertiesData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DAsmModelFileData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DAsmModelFileData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DAsmModelFileData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DAsmProductOccurrenceData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DAsmProductOccurrenceData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DAsmProductOccurrenceData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DAsmProductOccurrenceDataSLW d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DAsmProductOccurrenceDataSLW(ptr)) {
                    Console.WriteLine( "FAILURE: A3DAsmProductOccurrenceDataSLW" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DAsmProductOccurrenceDataCat d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DAsmProductOccurrenceDataCat(ptr)) {
                    Console.WriteLine( "FAILURE: A3DAsmProductOccurrenceDataCat" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DAsmProductOccurrenceDataCV5 d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DAsmProductOccurrenceDataCV5(ptr)) {
                    Console.WriteLine( "FAILURE: A3DAsmProductOccurrenceDataCV5" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DAsmProductOccurrenceDataUg d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DAsmProductOccurrenceDataUg(ptr)) {
                    Console.WriteLine( "FAILURE: A3DAsmProductOccurrenceDataUg" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DAsmProductOccurrenceDataProe d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DAsmProductOccurrenceDataProe(ptr)) {
                    Console.WriteLine( "FAILURE: A3DAsmProductOccurrenceDataProe" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DAsmProductOccurrenceDataInv d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DAsmProductOccurrenceDataInv(ptr)) {
                    Console.WriteLine( "FAILURE: A3DAsmProductOccurrenceDataInv" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DAsmProductOccurrenceDataJT d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DAsmProductOccurrenceDataJT(ptr)) {
                    Console.WriteLine( "FAILURE: A3DAsmProductOccurrenceDataJT" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DAsmPartDefinitionData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DAsmPartDefinitionData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DAsmPartDefinitionData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DAsmLayerFilterItemData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DAsmLayerFilterItemData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DAsmLayerFilterItemData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DAsmEntityFilterItemData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DAsmEntityFilterItemData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DAsmEntityFilterItemData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DAsmFilterData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DAsmFilterData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DAsmFilterData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DRWParamsGeneralData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DRWParamsGeneralData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DRWParamsGeneralData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DRWParamsPmiData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DRWParamsPmiData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DRWParamsPmiData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DRWParamsTessellationData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DRWParamsTessellationData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DRWParamsTessellationData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DRWParamsSearchDirData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DRWParamsSearchDirData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DRWParamsSearchDirData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DRWParamsAssemblyData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DRWParamsAssemblyData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DRWParamsAssemblyData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DRWParamsMultiEntriesData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DRWParamsMultiEntriesData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DRWParamsMultiEntriesData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DRWParamsCatiaV4Data d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DRWParamsCatiaV4Data(ptr)) {
                    Console.WriteLine( "FAILURE: A3DRWParamsCatiaV4Data" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DRWParamsCatiaV5Data d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DRWParamsCatiaV5Data(ptr)) {
                    Console.WriteLine( "FAILURE: A3DRWParamsCatiaV5Data" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DRWParamsUnigraphicsData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DRWParamsUnigraphicsData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DRWParamsUnigraphicsData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DRWParamsProEData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DRWParamsProEData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DRWParamsProEData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DRWValidationPropertiesThresholdData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DRWValidationPropertiesThresholdData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DRWValidationPropertiesThresholdData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DRWParamsStepData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DRWParamsStepData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DRWParamsStepData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DRWParamsIGESData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DRWParamsIGESData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DRWParamsIGESData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DRWParamsIFCData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DRWParamsIFCData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DRWParamsIFCData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DRWParamsJTData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DRWParamsJTData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DRWParamsJTData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DRWParamsParasolidData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DRWParamsParasolidData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DRWParamsParasolidData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DRWParamsSolidworksData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DRWParamsSolidworksData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DRWParamsSolidworksData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DRWParamsInventorData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DRWParamsInventorData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DRWParamsInventorData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DRWParamsRhinoData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DRWParamsRhinoData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DRWParamsRhinoData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DRWParamsRevitData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DRWParamsRevitData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DRWParamsRevitData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DRWParamsSpecificLoadData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DRWParamsSpecificLoadData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DRWParamsSpecificLoadData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DRWParamsIncrementalLoadData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DRWParamsIncrementalLoadData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DRWParamsIncrementalLoadData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DRWParamsLoadData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DRWParamsLoadData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DRWParamsLoadData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DStream3DPDFData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DStream3DPDFData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DStream3DPDFData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DRWParamsExportPrcData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DRWParamsExportPrcData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DRWParamsExportPrcData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DRWParamsExportU3DData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DRWParamsExportU3DData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DRWParamsExportU3DData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DRWParamsExportStepData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DRWParamsExportStepData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DRWParamsExportStepData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DRWParamsExportJTData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DRWParamsExportJTData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DRWParamsExportJTData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DRWParamsExportIgesData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DRWParamsExportIgesData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DRWParamsExportIgesData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DRWParamsExportStlData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DRWParamsExportStlData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DRWParamsExportStlData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DRWParamsExport3mfData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DRWParamsExport3mfData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DRWParamsExport3mfData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DRWParamsExportXMLData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DRWParamsExportXMLData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DRWParamsExportXMLData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DRWParamsExportObjData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DRWParamsExportObjData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DRWParamsExportObjData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DRWParamsExportFbxData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DRWParamsExportFbxData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DRWParamsExportFbxData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DRWParamsExportGltfData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DRWParamsExportGltfData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DRWParamsExportGltfData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DSewOptionsData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DSewOptionsData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DSewOptionsData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DFaceUVPointInsideManagerData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DFaceUVPointInsideManagerData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DFaceUVPointInsideManagerData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DProjectedPointCloudData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DProjectedPointCloudData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DProjectedPointCloudData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DProjectPointCloudManagerDataFromRI d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DProjectPointCloudManagerDataFromRI(ptr)) {
                    Console.WriteLine( "FAILURE: A3DProjectPointCloudManagerDataFromRI" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DProjectPointCloudOptionsData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DProjectPointCloudOptionsData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DProjectPointCloudOptionsData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DPlanarSectionData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DPlanarSectionData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DPlanarSectionData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DCompareInputData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DCompareInputData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DCompareInputData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DCompareOutputData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DCompareOutputData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DCompareOutputData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMultiPlanarSectionData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMultiPlanarSectionData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMultiPlanarSectionData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DHLRViewPlaneData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DHLRViewPlaneData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DHLRViewPlaneData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DHLRCurveData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DHLRCurveData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DHLRCurveData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DHLRSectionFaceData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DHLRSectionFaceData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DHLRSectionFaceData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DHLRRepresentationItemData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DHLRRepresentationItemData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DHLRRepresentationItemData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DHLROptionsData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DHLROptionsData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DHLROptionsData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DTransfoRepresentationItemData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DTransfoRepresentationItemData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DTransfoRepresentationItemData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DCollisionGroupData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DCollisionGroupData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DCollisionGroupData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DCollisionParameterData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DCollisionParameterData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DCollisionParameterData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DCollisionResultData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DCollisionResultData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DCollisionResultData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DBIMDataData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DBIMDataData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DBIMDataData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DBIMRelContainedInSpatialStructureData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DBIMRelContainedInSpatialStructureData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DBIMRelContainedInSpatialStructureData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DBIMRelFillsElementData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DBIMRelFillsElementData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DBIMRelFillsElementData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DBIMRelSpaceBoundaryData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DBIMRelSpaceBoundaryData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DBIMRelSpaceBoundaryData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DBIMRelAggregatesData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DBIMRelAggregatesData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DBIMRelAggregatesData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DBIMRelVoidsElementData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DBIMRelVoidsElementData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DBIMRelVoidsElementData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DBIMRelConnectsPathElementsData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DBIMRelConnectsPathElementsData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DBIMRelConnectsPathElementsData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DBIMRootData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DBIMRootData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DBIMRootData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMiscConstraintLinkedItemData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMiscConstraintLinkedItemData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMiscConstraintLinkedItemData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DAsmConstraintData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DAsmConstraintData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DAsmConstraintData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMkpLeaderData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMkpLeaderData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMkpLeaderData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMkpAnnotationItemData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMkpAnnotationItemData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMkpAnnotationItemData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMkpAnnotationSetData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMkpAnnotationSetData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMkpAnnotationSetData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMkpAnnotationReferenceData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMkpAnnotationReferenceData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMkpAnnotationReferenceData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMkpViewData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMkpViewData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMkpViewData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMkpViewFlagsData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMkpViewFlagsData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMkpViewFlagsData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMiscMarkupLinkedItemData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMiscMarkupLinkedItemData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMiscMarkupLinkedItemData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMkpMarkupData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMkpMarkupData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMkpMarkupData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMkpRTFFieldData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMkpRTFFieldData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMkpRTFFieldData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DFontKeyData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DFontKeyData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DFontKeyData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DFontData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DFontData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DFontData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DGraphTextureTransformationData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DGraphTextureTransformationData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DGraphTextureTransformationData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DGraphTextureDefinitionData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DGraphTextureDefinitionData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DGraphTextureDefinitionData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DGraphTextureApplicationData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DGraphTextureApplicationData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DGraphTextureApplicationData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DDrawingModelData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DDrawingModelData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DDrawingModelData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DDrawingSheetFormatData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DDrawingSheetFormatData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DDrawingSheetFormatData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DDrawingSheetData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DDrawingSheetData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DDrawingSheetData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DDrawingClipFrameData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DDrawingClipFrameData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DDrawingClipFrameData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DDrawingViewData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DDrawingViewData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DDrawingViewData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DDrawingBlockBasicData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DDrawingBlockBasicData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DDrawingBlockBasicData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DDrawingBlockOperatorData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DDrawingBlockOperatorData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DDrawingBlockOperatorData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DDrawingCurveData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DDrawingCurveData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DDrawingCurveData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DDrawingFilledAreaData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DDrawingFilledAreaData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DDrawingFilledAreaData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DDrawingPictureData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DDrawingPictureData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DDrawingPictureData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DDrawingVerticesData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DDrawingVerticesData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DDrawingVerticesData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DThumbnailData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DThumbnailData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DThumbnailData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DFileInformationData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DFileInformationData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DFileInformationData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DFileContextData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DFileContextData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DFileContextData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DRWParamsExportParasolidData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DRWParamsExportParasolidData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DRWParamsExportParasolidData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DRWParamsTranslateToPkPartsData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DRWParamsTranslateToPkPartsData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DRWParamsTranslateToPkPartsData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DRWParamsExportAcisData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DRWParamsExportAcisData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DRWParamsExportAcisData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DRiRepresentationItemData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DRiRepresentationItemData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DRiRepresentationItemData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DRiSetData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DRiSetData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DRiSetData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DRiPointSetData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DRiPointSetData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DRiPointSetData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DRiDirectionData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DRiDirectionData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DRiDirectionData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DRiCoordinateSystemData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DRiCoordinateSystemData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DRiCoordinateSystemData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DRiCurveData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DRiCurveData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DRiCurveData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DRiPlaneData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DRiPlaneData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DRiPlaneData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DRiBrepModelData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DRiBrepModelData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DRiBrepModelData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DRiPolyBrepModelData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DRiPolyBrepModelData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DRiPolyBrepModelData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DRiPolyWireData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DRiPolyWireData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DRiPolyWireData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DFRMTreeData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DFRMTreeData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DFRMTreeData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DFRMParameterData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DFRMParameterData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DFRMParameterData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DFRMTypeData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DFRMTypeData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DFRMTypeData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DFRMStringData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DFRMStringData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DFRMStringData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DFRMDoubleData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DFRMDoubleData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DFRMDoubleData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DFRMIntegerData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DFRMIntegerData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DFRMIntegerData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DFRMLinkedItemData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DFRMLinkedItemData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DFRMLinkedItemData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DFRMFeatureData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DFRMFeatureData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DFRMFeatureData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DFRMGeomEntitiesData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DFRMGeomEntitiesData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DFRMGeomEntitiesData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DCrvNurbsData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DCrvNurbsData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DCrvNurbsData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DCrvLineData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DCrvLineData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DCrvLineData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DCrvCircleData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DCrvCircleData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DCrvCircleData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DCrvEllipseData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DCrvEllipseData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DCrvEllipseData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DCrvParabolaData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DCrvParabolaData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DCrvParabolaData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DCrvHyperbolaData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DCrvHyperbolaData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DCrvHyperbolaData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DCrvPolyLineData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DCrvPolyLineData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DCrvPolyLineData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DCrvCompositeData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DCrvCompositeData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DCrvCompositeData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DCrvEquationData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DCrvEquationData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DCrvEquationData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DCrvTransformData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DCrvTransformData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DCrvTransformData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DCrvOnSurfData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DCrvOnSurfData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DCrvOnSurfData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DCrvOffsetData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DCrvOffsetData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DCrvOffsetData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DCrvHelixPitchCstData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DCrvHelixPitchCstData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DCrvHelixPitchCstData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DCrvHelixPitchVarData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DCrvHelixPitchVarData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DCrvHelixPitchVarData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DCrvHelixData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DCrvHelixData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DCrvHelixData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DCrossingPointsCrvIntersectionData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DCrossingPointsCrvIntersectionData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DCrossingPointsCrvIntersectionData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DCrvIntersectionData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DCrvIntersectionData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DCrvIntersectionData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DCrvBlend02BoundaryData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DCrvBlend02BoundaryData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DCrvBlend02BoundaryData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DSurfNurbsData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DSurfNurbsData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DSurfNurbsData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DSurfSphereData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DSurfSphereData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DSurfSphereData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DSurfCylinderData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DSurfCylinderData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DSurfCylinderData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DSurfTorusData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DSurfTorusData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DSurfTorusData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DSurfRevolutionData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DSurfRevolutionData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DSurfRevolutionData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DSurfExtrusionData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DSurfExtrusionData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DSurfExtrusionData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DSurfOffsetData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DSurfOffsetData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DSurfOffsetData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DSurfPlaneData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DSurfPlaneData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DSurfPlaneData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DSurfBlend01Data d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DSurfBlend01Data(ptr)) {
                    Console.WriteLine( "FAILURE: A3DSurfBlend01Data" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DSurfBlend02Data d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DSurfBlend02Data(ptr)) {
                    Console.WriteLine( "FAILURE: A3DSurfBlend02Data" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DSurfBlend03Data d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DSurfBlend03Data(ptr)) {
                    Console.WriteLine( "FAILURE: A3DSurfBlend03Data" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DSurfConeData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DSurfConeData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DSurfConeData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DSurfCylindricalData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DSurfCylindricalData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DSurfCylindricalData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DSurfRuledData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DSurfRuledData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DSurfRuledData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DSurfPipeData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DSurfPipeData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DSurfPipeData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DSurfTransformData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DSurfTransformData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DSurfTransformData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DSurfFromCurvesData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DSurfFromCurvesData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DSurfFromCurvesData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DGlobalData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DGlobalData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DGlobalData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMDPosition3DData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMDPosition3DData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMDPosition3DData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMDPosition2DData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMDPosition2DData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMDPosition2DData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMDPositionReferenceData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMDPositionReferenceData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMDPositionReferenceData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMDLeaderSymbolData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMDLeaderSymbolData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMDLeaderSymbolData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMDMarkupLeaderStubData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMDMarkupLeaderStubData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMDMarkupLeaderStubData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMDLeaderDefinitionData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMDLeaderDefinitionData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMDLeaderDefinitionData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMDTextPropertiesData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMDTextPropertiesData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMDTextPropertiesData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMarkupDefinitionData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMarkupDefinitionData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMarkupDefinitionData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMDDimensionValueFormatData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMDDimensionValueFormatData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMDDimensionValueFormatData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMDDimensionSimpleToleranceFormatData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMDDimensionSimpleToleranceFormatData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMDDimensionSimpleToleranceFormatData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMDDimensionCombinedToleranceFormatData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMDDimensionCombinedToleranceFormatData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMDDimensionCombinedToleranceFormatData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMDDimensionValueData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMDDimensionValueData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMDDimensionValueData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMDDimensionSecondPartData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMDDimensionSecondPartData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMDDimensionSecondPartData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMDDimensionForeshortenedData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMDDimensionForeshortenedData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMDDimensionForeshortenedData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMDDimensionLineSymbolData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMDDimensionLineSymbolData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMDDimensionLineSymbolData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMDDimensionLineData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMDDimensionLineData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMDDimensionLineData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMDDimensionFunnelData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMDDimensionFunnelData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMDDimensionFunnelData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMDDimensionExtremityData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMDDimensionExtremityData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMDDimensionExtremityData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMDDimensionExtentionLineData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMDDimensionExtentionLineData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMDDimensionExtentionLineData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMarkupDimensionData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMarkupDimensionData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMarkupDimensionData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMarkupRoughnessData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMarkupRoughnessData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMarkupRoughnessData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMarkupBalloonData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMarkupBalloonData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMarkupBalloonData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMarkupFastenerData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMarkupFastenerData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMarkupFastenerData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMarkupLocatorData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMarkupLocatorData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMarkupLocatorData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMarkupMeasurementPointData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMarkupMeasurementPointData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMarkupMeasurementPointData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMDTextPositionData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMDTextPositionData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMDTextPositionData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMarkupTextData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMarkupTextData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMarkupTextData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMarkupCoordinateData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMarkupCoordinateData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMarkupCoordinateData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMarkupRichTextData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMarkupRichTextData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMarkupRichTextData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMarkupDatumData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMarkupDatumData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMarkupDatumData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMDFCFDraftingRowData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMDFCFDraftingRowData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMDFCFDraftingRowData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMDFCValueData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMDFCValueData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMDFCValueData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMDFCTolerancePerUnitData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMDFCTolerancePerUnitData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMDFCTolerancePerUnitData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMDFCProjectedZoneData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMDFCProjectedZoneData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMDFCProjectedZoneData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMDFCFToleranceValueData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMDFCFToleranceValueData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMDFCFToleranceValueData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMDFCFRowDatumData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMDFCFRowDatumData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMDFCFRowDatumData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMDFCFDrawingRowData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMDFCFDrawingRowData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMDFCFDrawingRowData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMDFCFIndicatorData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMDFCFIndicatorData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMDFCFIndicatorData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMDFCFDraftingIndicatorData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMDFCFDraftingIndicatorData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMDFCFDraftingIndicatorData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMDFeatureControlFrameData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMDFeatureControlFrameData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMDFeatureControlFrameData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMDToleranceSizeValueData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMDToleranceSizeValueData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMDToleranceSizeValueData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMDToleranceSizeData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMDToleranceSizeData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMDToleranceSizeData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMarkupGDTData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMarkupGDTData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMarkupGDTData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMarkupSpotWeldingData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMarkupSpotWeldingData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMarkupSpotWeldingData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMarkupLineWeldingData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMarkupLineWeldingData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMarkupLineWeldingData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMathFct1DPolynomData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMathFct1DPolynomData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMathFct1DPolynomData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMathFct1DTrigonometricData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMathFct1DTrigonometricData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMathFct1DTrigonometricData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMathFct1DFractionData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMathFct1DFractionData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMathFct1DFractionData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMathFct1DArctanCosData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMathFct1DArctanCosData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMathFct1DArctanCosData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMathFct1DCombinationData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMathFct1DCombinationData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMathFct1DCombinationData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMathFct3DLinearData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMathFct3DLinearData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMathFct3DLinearData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMathFct3DNonLinearData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMathFct3DNonLinearData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMathFct3DNonLinearData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DRootBaseData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DRootBaseData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DRootBaseData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DRootBaseWithGraphicsData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DRootBaseWithGraphicsData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DRootBaseWithGraphicsData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMiscSingleAttributeData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMiscSingleAttributeData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMiscSingleAttributeData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMiscAttributeData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMiscAttributeData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMiscAttributeData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMiscAttributeBasicUnitData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMiscAttributeBasicUnitData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMiscAttributeBasicUnitData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DMiscAttributeUnitData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DMiscAttributeUnitData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DMiscAttributeUnitData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DCopyAndAdaptBrepModelData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DCopyAndAdaptBrepModelData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DCopyAndAdaptBrepModelData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DPhysicalPropertiesData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DPhysicalPropertiesData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DPhysicalPropertiesData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DTopoBodyData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DTopoBodyData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DTopoBodyData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DTopoContextData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DTopoContextData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DTopoContextData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DTopoSingleWireBodyData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DTopoSingleWireBodyData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DTopoSingleWireBodyData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DTopoBrepDataData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DTopoBrepDataData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DTopoBrepDataData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DTopoConnexData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DTopoConnexData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DTopoConnexData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DTopoShellData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DTopoShellData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DTopoShellData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DTopoFaceData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DTopoFaceData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DTopoFaceData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DTopoLoopData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DTopoLoopData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DTopoLoopData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DTopoCoEdgeData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DTopoCoEdgeData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DTopoCoEdgeData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DTopoEdgeData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DTopoEdgeData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DTopoEdgeData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DTopoWireEdgeData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DTopoWireEdgeData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DTopoWireEdgeData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DTopoUniqueVertexData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DTopoUniqueVertexData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DTopoUniqueVertexData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
            {
                A3DTopoMultipleVertexData d;
                API.Initialize(out d);
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(d));
                Marshal.StructureToPtr(d, ptr, false);
                if(0 != Verify_A3DTopoMultipleVertexData(ptr)) {
                    Console.WriteLine( "FAILURE: A3DTopoMultipleVertexData" );
                }
                Marshal.FreeHGlobal(ptr);
            }
        }
    }
}
