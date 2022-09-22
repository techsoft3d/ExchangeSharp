#include <memory>
#include <A3DSDKIncludes.h>

#ifdef _MSC_VER
#define DECL_SPEC __declspec(dllexport)
#else
#define DECL_SPEC
#endif

extern "C" {
    DECL_SPEC int32_t Verify_A3DVector2dData(A3DVector2dData *from_csharp) {
        A3DVector2dData d;
        A3D_INITIALIZE_DATA( A3DVector2dData, d );
        return memcmp( &d, from_csharp, sizeof(A3DVector2dData));
    }
    DECL_SPEC int32_t Verify_A3DVector3dData(A3DVector3dData *from_csharp) {
        A3DVector3dData d;
        A3D_INITIALIZE_DATA( A3DVector3dData, d );
        return memcmp( &d, from_csharp, sizeof(A3DVector3dData));
    }
    DECL_SPEC int32_t Verify_A3DIntervalData(A3DIntervalData *from_csharp) {
        A3DIntervalData d;
        A3D_INITIALIZE_DATA( A3DIntervalData, d );
        return memcmp( &d, from_csharp, sizeof(A3DIntervalData));
    }
    DECL_SPEC int32_t Verify_A3DDomainData(A3DDomainData *from_csharp) {
        A3DDomainData d;
        A3D_INITIALIZE_DATA( A3DDomainData, d );
        return memcmp( &d, from_csharp, sizeof(A3DDomainData));
    }
    DECL_SPEC int32_t Verify_A3DBoundingBoxData(A3DBoundingBoxData *from_csharp) {
        A3DBoundingBoxData d;
        A3D_INITIALIZE_DATA( A3DBoundingBoxData, d );
        return memcmp( &d, from_csharp, sizeof(A3DBoundingBoxData));
    }
    DECL_SPEC int32_t Verify_A3DParameterizationData(A3DParameterizationData *from_csharp) {
        A3DParameterizationData d;
        A3D_INITIALIZE_DATA( A3DParameterizationData, d );
        return memcmp( &d, from_csharp, sizeof(A3DParameterizationData));
    }
    DECL_SPEC int32_t Verify_A3DUVParameterizationData(A3DUVParameterizationData *from_csharp) {
        A3DUVParameterizationData d;
        A3D_INITIALIZE_DATA( A3DUVParameterizationData, d );
        return memcmp( &d, from_csharp, sizeof(A3DUVParameterizationData));
    }
    DECL_SPEC int32_t Verify_A3DTessBaseData(A3DTessBaseData *from_csharp) {
        A3DTessBaseData d;
        A3D_INITIALIZE_DATA( A3DTessBaseData, d );
        return memcmp( &d, from_csharp, sizeof(A3DTessBaseData));
    }
    DECL_SPEC int32_t Verify_A3DTessFaceData(A3DTessFaceData *from_csharp) {
        A3DTessFaceData d;
        A3D_INITIALIZE_DATA( A3DTessFaceData, d );
        return memcmp( &d, from_csharp, sizeof(A3DTessFaceData));
    }
    DECL_SPEC int32_t Verify_A3DTess3DData(A3DTess3DData *from_csharp) {
        A3DTess3DData d;
        A3D_INITIALIZE_DATA( A3DTess3DData, d );
        return memcmp( &d, from_csharp, sizeof(A3DTess3DData));
    }
    DECL_SPEC int32_t Verify_A3DTess3DWireData(A3DTess3DWireData *from_csharp) {
        A3DTess3DWireData d;
        A3D_INITIALIZE_DATA( A3DTess3DWireData, d );
        return memcmp( &d, from_csharp, sizeof(A3DTess3DWireData));
    }
    DECL_SPEC int32_t Verify_A3DTessMarkupData(A3DTessMarkupData *from_csharp) {
        A3DTessMarkupData d;
        A3D_INITIALIZE_DATA( A3DTessMarkupData, d );
        return memcmp( &d, from_csharp, sizeof(A3DTessMarkupData));
    }
    DECL_SPEC int32_t Verify_A3DGraphicsData(A3DGraphicsData *from_csharp) {
        A3DGraphicsData d;
        A3D_INITIALIZE_DATA( A3DGraphicsData, d );
        return memcmp( &d, from_csharp, sizeof(A3DGraphicsData));
    }
    DECL_SPEC int32_t Verify_A3DGraphStyleData(A3DGraphStyleData *from_csharp) {
        A3DGraphStyleData d;
        A3D_INITIALIZE_DATA( A3DGraphStyleData, d );
        return memcmp( &d, from_csharp, sizeof(A3DGraphStyleData));
    }
    DECL_SPEC int32_t Verify_A3DGraphRgbColorData(A3DGraphRgbColorData *from_csharp) {
        A3DGraphRgbColorData d;
        A3D_INITIALIZE_DATA( A3DGraphRgbColorData, d );
        return memcmp( &d, from_csharp, sizeof(A3DGraphRgbColorData));
    }
    DECL_SPEC int32_t Verify_A3DGraphLinePatternData(A3DGraphLinePatternData *from_csharp) {
        A3DGraphLinePatternData d;
        A3D_INITIALIZE_DATA( A3DGraphLinePatternData, d );
        return memcmp( &d, from_csharp, sizeof(A3DGraphLinePatternData));
    }
    DECL_SPEC int32_t Verify_A3DGraphMaterialData(A3DGraphMaterialData *from_csharp) {
        A3DGraphMaterialData d;
        A3D_INITIALIZE_DATA( A3DGraphMaterialData, d );
        return memcmp( &d, from_csharp, sizeof(A3DGraphMaterialData));
    }
    DECL_SPEC int32_t Verify_A3DGraphPictureData(A3DGraphPictureData *from_csharp) {
        A3DGraphPictureData d;
        A3D_INITIALIZE_DATA( A3DGraphPictureData, d );
        return memcmp( &d, from_csharp, sizeof(A3DGraphPictureData));
    }
    DECL_SPEC int32_t Verify_A3DGraphDottingPatternData(A3DGraphDottingPatternData *from_csharp) {
        A3DGraphDottingPatternData d;
        A3D_INITIALIZE_DATA( A3DGraphDottingPatternData, d );
        return memcmp( &d, from_csharp, sizeof(A3DGraphDottingPatternData));
    }
    DECL_SPEC int32_t Verify_A3DGraphHatchingPatternLineData(A3DGraphHatchingPatternLineData *from_csharp) {
        A3DGraphHatchingPatternLineData d;
        A3D_INITIALIZE_DATA( A3DGraphHatchingPatternLineData, d );
        return memcmp( &d, from_csharp, sizeof(A3DGraphHatchingPatternLineData));
    }
    DECL_SPEC int32_t Verify_A3DGraphHatchingPatternData(A3DGraphHatchingPatternData *from_csharp) {
        A3DGraphHatchingPatternData d;
        A3D_INITIALIZE_DATA( A3DGraphHatchingPatternData, d );
        return memcmp( &d, from_csharp, sizeof(A3DGraphHatchingPatternData));
    }
    DECL_SPEC int32_t Verify_A3DGraphSolidPatternData(A3DGraphSolidPatternData *from_csharp) {
        A3DGraphSolidPatternData d;
        A3D_INITIALIZE_DATA( A3DGraphSolidPatternData, d );
        return memcmp( &d, from_csharp, sizeof(A3DGraphSolidPatternData));
    }
    DECL_SPEC int32_t Verify_A3DGraphVPicturePatternData(A3DGraphVPicturePatternData *from_csharp) {
        A3DGraphVPicturePatternData d;
        A3D_INITIALIZE_DATA( A3DGraphVPicturePatternData, d );
        return memcmp( &d, from_csharp, sizeof(A3DGraphVPicturePatternData));
    }
    DECL_SPEC int32_t Verify_A3DGraphCameraData(A3DGraphCameraData *from_csharp) {
        A3DGraphCameraData d;
        A3D_INITIALIZE_DATA( A3DGraphCameraData, d );
        return memcmp( &d, from_csharp, sizeof(A3DGraphCameraData));
    }
    DECL_SPEC int32_t Verify_A3DGraphAmbientLightData(A3DGraphAmbientLightData *from_csharp) {
        A3DGraphAmbientLightData d;
        A3D_INITIALIZE_DATA( A3DGraphAmbientLightData, d );
        return memcmp( &d, from_csharp, sizeof(A3DGraphAmbientLightData));
    }
    DECL_SPEC int32_t Verify_A3DGraphPointLightData(A3DGraphPointLightData *from_csharp) {
        A3DGraphPointLightData d;
        A3D_INITIALIZE_DATA( A3DGraphPointLightData, d );
        return memcmp( &d, from_csharp, sizeof(A3DGraphPointLightData));
    }
    DECL_SPEC int32_t Verify_A3DGraphSpotLightData(A3DGraphSpotLightData *from_csharp) {
        A3DGraphSpotLightData d;
        A3D_INITIALIZE_DATA( A3DGraphSpotLightData, d );
        return memcmp( &d, from_csharp, sizeof(A3DGraphSpotLightData));
    }
    DECL_SPEC int32_t Verify_A3DGraphDirectionalLightData(A3DGraphDirectionalLightData *from_csharp) {
        A3DGraphDirectionalLightData d;
        A3D_INITIALIZE_DATA( A3DGraphDirectionalLightData, d );
        return memcmp( &d, from_csharp, sizeof(A3DGraphDirectionalLightData));
    }
    DECL_SPEC int32_t Verify_A3DGraphSceneDisplayParametersData(A3DGraphSceneDisplayParametersData *from_csharp) {
        A3DGraphSceneDisplayParametersData d;
        A3D_INITIALIZE_DATA( A3DGraphSceneDisplayParametersData, d );
        return memcmp( &d, from_csharp, sizeof(A3DGraphSceneDisplayParametersData));
    }
    DECL_SPEC int32_t Verify_A3DMiscCascadedAttributesData(A3DMiscCascadedAttributesData *from_csharp) {
        A3DMiscCascadedAttributesData d;
        A3D_INITIALIZE_DATA( A3DMiscCascadedAttributesData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMiscCascadedAttributesData));
    }
    DECL_SPEC int32_t Verify_A3DMiscGeneralTransformationData(A3DMiscGeneralTransformationData *from_csharp) {
        A3DMiscGeneralTransformationData d;
        A3D_INITIALIZE_DATA( A3DMiscGeneralTransformationData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMiscGeneralTransformationData));
    }
    DECL_SPEC int32_t Verify_A3DMiscCartesianTransformationData(A3DMiscCartesianTransformationData *from_csharp) {
        A3DMiscCartesianTransformationData d;
        A3D_INITIALIZE_DATA( A3DMiscCartesianTransformationData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMiscCartesianTransformationData));
    }
    DECL_SPEC int32_t Verify_A3DMiscEntityReferenceData(A3DMiscEntityReferenceData *from_csharp) {
        A3DMiscEntityReferenceData d;
        A3D_INITIALIZE_DATA( A3DMiscEntityReferenceData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMiscEntityReferenceData));
    }
    DECL_SPEC int32_t Verify_A3DMiscReferenceOnTopologyData(A3DMiscReferenceOnTopologyData *from_csharp) {
        A3DMiscReferenceOnTopologyData d;
        A3D_INITIALIZE_DATA( A3DMiscReferenceOnTopologyData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMiscReferenceOnTopologyData));
    }
    DECL_SPEC int32_t Verify_A3DMiscReferenceOnTessData(A3DMiscReferenceOnTessData *from_csharp) {
        A3DMiscReferenceOnTessData d;
        A3D_INITIALIZE_DATA( A3DMiscReferenceOnTessData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMiscReferenceOnTessData));
    }
    DECL_SPEC int32_t Verify_A3DMiscReferenceOnCsysItemData(A3DMiscReferenceOnCsysItemData *from_csharp) {
        A3DMiscReferenceOnCsysItemData d;
        A3D_INITIALIZE_DATA( A3DMiscReferenceOnCsysItemData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMiscReferenceOnCsysItemData));
    }
    DECL_SPEC int32_t Verify_A3DMiscPhysicMaterialData(A3DMiscPhysicMaterialData *from_csharp) {
        A3DMiscPhysicMaterialData d;
        A3D_INITIALIZE_DATA( A3DMiscPhysicMaterialData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMiscPhysicMaterialData));
    }
    DECL_SPEC int32_t Verify_A3DMiscMaterialFiberData(A3DMiscMaterialFiberData *from_csharp) {
        A3DMiscMaterialFiberData d;
        A3D_INITIALIZE_DATA( A3DMiscMaterialFiberData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMiscMaterialFiberData));
    }
    DECL_SPEC int32_t Verify_A3DMiscMaterialHoneyCombData(A3DMiscMaterialHoneyCombData *from_csharp) {
        A3DMiscMaterialHoneyCombData d;
        A3D_INITIALIZE_DATA( A3DMiscMaterialHoneyCombData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMiscMaterialHoneyCombData));
    }
    DECL_SPEC int32_t Verify_A3DMiscMaterialIsotropicData(A3DMiscMaterialIsotropicData *from_csharp) {
        A3DMiscMaterialIsotropicData d;
        A3D_INITIALIZE_DATA( A3DMiscMaterialIsotropicData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMiscMaterialIsotropicData));
    }
    DECL_SPEC int32_t Verify_A3DMiscMaterialOrthotropic2DData(A3DMiscMaterialOrthotropic2DData *from_csharp) {
        A3DMiscMaterialOrthotropic2DData d;
        A3D_INITIALIZE_DATA( A3DMiscMaterialOrthotropic2DData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMiscMaterialOrthotropic2DData));
    }
    DECL_SPEC int32_t Verify_A3DMiscMaterialOrthotropic3DData(A3DMiscMaterialOrthotropic3DData *from_csharp) {
        A3DMiscMaterialOrthotropic3DData d;
        A3D_INITIALIZE_DATA( A3DMiscMaterialOrthotropic3DData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMiscMaterialOrthotropic3DData));
    }
    DECL_SPEC int32_t Verify_A3DMiscMaterialAnisotropicData(A3DMiscMaterialAnisotropicData *from_csharp) {
        A3DMiscMaterialAnisotropicData d;
        A3D_INITIALIZE_DATA( A3DMiscMaterialAnisotropicData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMiscMaterialAnisotropicData));
    }
    DECL_SPEC int32_t Verify_A3DMiscMaterialPropertiesData(A3DMiscMaterialPropertiesData *from_csharp) {
        A3DMiscMaterialPropertiesData d;
        A3D_INITIALIZE_DATA( A3DMiscMaterialPropertiesData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMiscMaterialPropertiesData));
    }
    DECL_SPEC int32_t Verify_A3DAsmModelFileData(A3DAsmModelFileData *from_csharp) {
        A3DAsmModelFileData d;
        A3D_INITIALIZE_DATA( A3DAsmModelFileData, d );
        return memcmp( &d, from_csharp, sizeof(A3DAsmModelFileData));
    }
    DECL_SPEC int32_t Verify_A3DAsmProductOccurrenceData(A3DAsmProductOccurrenceData *from_csharp) {
        A3DAsmProductOccurrenceData d;
        A3D_INITIALIZE_DATA( A3DAsmProductOccurrenceData, d );
        return memcmp( &d, from_csharp, sizeof(A3DAsmProductOccurrenceData));
    }
    DECL_SPEC int32_t Verify_A3DAsmProductOccurrenceDataSLW(A3DAsmProductOccurrenceDataSLW *from_csharp) {
        A3DAsmProductOccurrenceDataSLW d;
        A3D_INITIALIZE_DATA( A3DAsmProductOccurrenceDataSLW, d );
        return memcmp( &d, from_csharp, sizeof(A3DAsmProductOccurrenceDataSLW));
    }
    DECL_SPEC int32_t Verify_A3DAsmProductOccurrenceDataCat(A3DAsmProductOccurrenceDataCat *from_csharp) {
        A3DAsmProductOccurrenceDataCat d;
        A3D_INITIALIZE_DATA( A3DAsmProductOccurrenceDataCat, d );
        return memcmp( &d, from_csharp, sizeof(A3DAsmProductOccurrenceDataCat));
    }
    DECL_SPEC int32_t Verify_A3DAsmProductOccurrenceDataCV5(A3DAsmProductOccurrenceDataCV5 *from_csharp) {
        A3DAsmProductOccurrenceDataCV5 d;
        A3D_INITIALIZE_DATA( A3DAsmProductOccurrenceDataCV5, d );
        return memcmp( &d, from_csharp, sizeof(A3DAsmProductOccurrenceDataCV5));
    }
    DECL_SPEC int32_t Verify_A3DAsmProductOccurrenceDataUg(A3DAsmProductOccurrenceDataUg *from_csharp) {
        A3DAsmProductOccurrenceDataUg d;
        A3D_INITIALIZE_DATA( A3DAsmProductOccurrenceDataUg, d );
        return memcmp( &d, from_csharp, sizeof(A3DAsmProductOccurrenceDataUg));
    }
    DECL_SPEC int32_t Verify_A3DAsmProductOccurrenceDataProe(A3DAsmProductOccurrenceDataProe *from_csharp) {
        A3DAsmProductOccurrenceDataProe d;
        A3D_INITIALIZE_DATA( A3DAsmProductOccurrenceDataProe, d );
        return memcmp( &d, from_csharp, sizeof(A3DAsmProductOccurrenceDataProe));
    }
    DECL_SPEC int32_t Verify_A3DAsmProductOccurrenceDataInv(A3DAsmProductOccurrenceDataInv *from_csharp) {
        A3DAsmProductOccurrenceDataInv d;
        A3D_INITIALIZE_DATA( A3DAsmProductOccurrenceDataInv, d );
        return memcmp( &d, from_csharp, sizeof(A3DAsmProductOccurrenceDataInv));
    }
    DECL_SPEC int32_t Verify_A3DAsmProductOccurrenceDataJT(A3DAsmProductOccurrenceDataJT *from_csharp) {
        A3DAsmProductOccurrenceDataJT d;
        A3D_INITIALIZE_DATA( A3DAsmProductOccurrenceDataJT, d );
        return memcmp( &d, from_csharp, sizeof(A3DAsmProductOccurrenceDataJT));
    }
    DECL_SPEC int32_t Verify_A3DAsmPartDefinitionData(A3DAsmPartDefinitionData *from_csharp) {
        A3DAsmPartDefinitionData d;
        A3D_INITIALIZE_DATA( A3DAsmPartDefinitionData, d );
        return memcmp( &d, from_csharp, sizeof(A3DAsmPartDefinitionData));
    }
    DECL_SPEC int32_t Verify_A3DAsmLayerFilterItemData(A3DAsmLayerFilterItemData *from_csharp) {
        A3DAsmLayerFilterItemData d;
        A3D_INITIALIZE_DATA( A3DAsmLayerFilterItemData, d );
        return memcmp( &d, from_csharp, sizeof(A3DAsmLayerFilterItemData));
    }
    DECL_SPEC int32_t Verify_A3DAsmEntityFilterItemData(A3DAsmEntityFilterItemData *from_csharp) {
        A3DAsmEntityFilterItemData d;
        A3D_INITIALIZE_DATA( A3DAsmEntityFilterItemData, d );
        return memcmp( &d, from_csharp, sizeof(A3DAsmEntityFilterItemData));
    }
    DECL_SPEC int32_t Verify_A3DAsmFilterData(A3DAsmFilterData *from_csharp) {
        A3DAsmFilterData d;
        A3D_INITIALIZE_DATA( A3DAsmFilterData, d );
        return memcmp( &d, from_csharp, sizeof(A3DAsmFilterData));
    }
    DECL_SPEC int32_t Verify_A3DRWParamsGeneralData(A3DRWParamsGeneralData *from_csharp) {
        A3DRWParamsGeneralData d;
        A3D_INITIALIZE_DATA( A3DRWParamsGeneralData, d );
        return memcmp( &d, from_csharp, sizeof(A3DRWParamsGeneralData));
    }
    DECL_SPEC int32_t Verify_A3DRWParamsPmiData(A3DRWParamsPmiData *from_csharp) {
        A3DRWParamsPmiData d;
        A3D_INITIALIZE_DATA( A3DRWParamsPmiData, d );
        return memcmp( &d, from_csharp, sizeof(A3DRWParamsPmiData));
    }
    DECL_SPEC int32_t Verify_A3DRWParamsTessellationData(A3DRWParamsTessellationData *from_csharp) {
        A3DRWParamsTessellationData d;
        A3D_INITIALIZE_DATA( A3DRWParamsTessellationData, d );
        return memcmp( &d, from_csharp, sizeof(A3DRWParamsTessellationData));
    }
    DECL_SPEC int32_t Verify_A3DRWParamsSearchDirData(A3DRWParamsSearchDirData *from_csharp) {
        A3DRWParamsSearchDirData d;
        A3D_INITIALIZE_DATA( A3DRWParamsSearchDirData, d );
        return memcmp( &d, from_csharp, sizeof(A3DRWParamsSearchDirData));
    }
    DECL_SPEC int32_t Verify_A3DRWParamsAssemblyData(A3DRWParamsAssemblyData *from_csharp) {
        A3DRWParamsAssemblyData d;
        A3D_INITIALIZE_DATA( A3DRWParamsAssemblyData, d );
        return memcmp( &d, from_csharp, sizeof(A3DRWParamsAssemblyData));
    }
    DECL_SPEC int32_t Verify_A3DRWParamsMultiEntriesData(A3DRWParamsMultiEntriesData *from_csharp) {
        A3DRWParamsMultiEntriesData d;
        A3D_INITIALIZE_DATA( A3DRWParamsMultiEntriesData, d );
        return memcmp( &d, from_csharp, sizeof(A3DRWParamsMultiEntriesData));
    }
    DECL_SPEC int32_t Verify_A3DRWParamsCatiaV4Data(A3DRWParamsCatiaV4Data *from_csharp) {
        A3DRWParamsCatiaV4Data d;
        A3D_INITIALIZE_DATA( A3DRWParamsCatiaV4Data, d );
        return memcmp( &d, from_csharp, sizeof(A3DRWParamsCatiaV4Data));
    }
    DECL_SPEC int32_t Verify_A3DRWParamsCatiaV5Data(A3DRWParamsCatiaV5Data *from_csharp) {
        A3DRWParamsCatiaV5Data d;
        A3D_INITIALIZE_DATA( A3DRWParamsCatiaV5Data, d );
        return memcmp( &d, from_csharp, sizeof(A3DRWParamsCatiaV5Data));
    }
    DECL_SPEC int32_t Verify_A3DRWParamsUnigraphicsData(A3DRWParamsUnigraphicsData *from_csharp) {
        A3DRWParamsUnigraphicsData d;
        A3D_INITIALIZE_DATA( A3DRWParamsUnigraphicsData, d );
        return memcmp( &d, from_csharp, sizeof(A3DRWParamsUnigraphicsData));
    }
    DECL_SPEC int32_t Verify_A3DRWParamsProEData(A3DRWParamsProEData *from_csharp) {
        A3DRWParamsProEData d;
        A3D_INITIALIZE_DATA( A3DRWParamsProEData, d );
        return memcmp( &d, from_csharp, sizeof(A3DRWParamsProEData));
    }
    DECL_SPEC int32_t Verify_A3DRWValidationPropertiesThresholdData(A3DRWValidationPropertiesThresholdData *from_csharp) {
        A3DRWValidationPropertiesThresholdData d;
        A3D_INITIALIZE_DATA( A3DRWValidationPropertiesThresholdData, d );
        return memcmp( &d, from_csharp, sizeof(A3DRWValidationPropertiesThresholdData));
    }
    DECL_SPEC int32_t Verify_A3DRWParamsStepData(A3DRWParamsStepData *from_csharp) {
        A3DRWParamsStepData d;
        A3D_INITIALIZE_DATA( A3DRWParamsStepData, d );
        return memcmp( &d, from_csharp, sizeof(A3DRWParamsStepData));
    }
    DECL_SPEC int32_t Verify_A3DRWParamsIGESData(A3DRWParamsIGESData *from_csharp) {
        A3DRWParamsIGESData d;
        A3D_INITIALIZE_DATA( A3DRWParamsIGESData, d );
        return memcmp( &d, from_csharp, sizeof(A3DRWParamsIGESData));
    }
    DECL_SPEC int32_t Verify_A3DRWParamsIFCData(A3DRWParamsIFCData *from_csharp) {
        A3DRWParamsIFCData d;
        A3D_INITIALIZE_DATA( A3DRWParamsIFCData, d );
        return memcmp( &d, from_csharp, sizeof(A3DRWParamsIFCData));
    }
    DECL_SPEC int32_t Verify_A3DRWParamsJTData(A3DRWParamsJTData *from_csharp) {
        A3DRWParamsJTData d;
        A3D_INITIALIZE_DATA( A3DRWParamsJTData, d );
        return memcmp( &d, from_csharp, sizeof(A3DRWParamsJTData));
    }
    DECL_SPEC int32_t Verify_A3DRWParamsParasolidData(A3DRWParamsParasolidData *from_csharp) {
        A3DRWParamsParasolidData d;
        A3D_INITIALIZE_DATA( A3DRWParamsParasolidData, d );
        return memcmp( &d, from_csharp, sizeof(A3DRWParamsParasolidData));
    }
    DECL_SPEC int32_t Verify_A3DRWParamsSolidworksData(A3DRWParamsSolidworksData *from_csharp) {
        A3DRWParamsSolidworksData d;
        A3D_INITIALIZE_DATA( A3DRWParamsSolidworksData, d );
        return memcmp( &d, from_csharp, sizeof(A3DRWParamsSolidworksData));
    }
    DECL_SPEC int32_t Verify_A3DRWParamsInventorData(A3DRWParamsInventorData *from_csharp) {
        A3DRWParamsInventorData d;
        A3D_INITIALIZE_DATA( A3DRWParamsInventorData, d );
        return memcmp( &d, from_csharp, sizeof(A3DRWParamsInventorData));
    }
    DECL_SPEC int32_t Verify_A3DRWParamsRhinoData(A3DRWParamsRhinoData *from_csharp) {
        A3DRWParamsRhinoData d;
        A3D_INITIALIZE_DATA( A3DRWParamsRhinoData, d );
        return memcmp( &d, from_csharp, sizeof(A3DRWParamsRhinoData));
    }
    DECL_SPEC int32_t Verify_A3DRWParamsRevitData(A3DRWParamsRevitData *from_csharp) {
        A3DRWParamsRevitData d;
        A3D_INITIALIZE_DATA( A3DRWParamsRevitData, d );
        return memcmp( &d, from_csharp, sizeof(A3DRWParamsRevitData));
    }
    DECL_SPEC int32_t Verify_A3DRWParamsSpecificLoadData(A3DRWParamsSpecificLoadData *from_csharp) {
        A3DRWParamsSpecificLoadData d;
        A3D_INITIALIZE_DATA( A3DRWParamsSpecificLoadData, d );
        return memcmp( &d, from_csharp, sizeof(A3DRWParamsSpecificLoadData));
    }
    DECL_SPEC int32_t Verify_A3DRWParamsIncrementalLoadData(A3DRWParamsIncrementalLoadData *from_csharp) {
        A3DRWParamsIncrementalLoadData d;
        A3D_INITIALIZE_DATA( A3DRWParamsIncrementalLoadData, d );
        return memcmp( &d, from_csharp, sizeof(A3DRWParamsIncrementalLoadData));
    }
    DECL_SPEC int32_t Verify_A3DRWParamsLoadData(A3DRWParamsLoadData *from_csharp) {
        A3DRWParamsLoadData d;
        A3D_INITIALIZE_DATA( A3DRWParamsLoadData, d );
        return memcmp( &d, from_csharp, sizeof(A3DRWParamsLoadData));
    }
    DECL_SPEC int32_t Verify_A3DStream3DPDFData(A3DStream3DPDFData *from_csharp) {
        A3DStream3DPDFData d;
        A3D_INITIALIZE_DATA( A3DStream3DPDFData, d );
        return memcmp( &d, from_csharp, sizeof(A3DStream3DPDFData));
    }
    DECL_SPEC int32_t Verify_A3DRWParamsExportPrcData(A3DRWParamsExportPrcData *from_csharp) {
        A3DRWParamsExportPrcData d;
        A3D_INITIALIZE_DATA( A3DRWParamsExportPrcData, d );
        return memcmp( &d, from_csharp, sizeof(A3DRWParamsExportPrcData));
    }
    DECL_SPEC int32_t Verify_A3DRWParamsExportU3DData(A3DRWParamsExportU3DData *from_csharp) {
        A3DRWParamsExportU3DData d;
        A3D_INITIALIZE_DATA( A3DRWParamsExportU3DData, d );
        return memcmp( &d, from_csharp, sizeof(A3DRWParamsExportU3DData));
    }
    DECL_SPEC int32_t Verify_A3DRWParamsExportStepData(A3DRWParamsExportStepData *from_csharp) {
        A3DRWParamsExportStepData d;
        A3D_INITIALIZE_DATA( A3DRWParamsExportStepData, d );
        return memcmp( &d, from_csharp, sizeof(A3DRWParamsExportStepData));
    }
    DECL_SPEC int32_t Verify_A3DRWParamsExportJTData(A3DRWParamsExportJTData *from_csharp) {
        A3DRWParamsExportJTData d;
        A3D_INITIALIZE_DATA( A3DRWParamsExportJTData, d );
        return memcmp( &d, from_csharp, sizeof(A3DRWParamsExportJTData));
    }
    DECL_SPEC int32_t Verify_A3DRWParamsExportIgesData(A3DRWParamsExportIgesData *from_csharp) {
        A3DRWParamsExportIgesData d;
        A3D_INITIALIZE_DATA( A3DRWParamsExportIgesData, d );
        return memcmp( &d, from_csharp, sizeof(A3DRWParamsExportIgesData));
    }
    DECL_SPEC int32_t Verify_A3DRWParamsExportStlData(A3DRWParamsExportStlData *from_csharp) {
        A3DRWParamsExportStlData d;
        A3D_INITIALIZE_DATA( A3DRWParamsExportStlData, d );
        return memcmp( &d, from_csharp, sizeof(A3DRWParamsExportStlData));
    }
    DECL_SPEC int32_t Verify_A3DRWParamsExport3mfData(A3DRWParamsExport3mfData *from_csharp) {
        A3DRWParamsExport3mfData d;
        A3D_INITIALIZE_DATA( A3DRWParamsExport3mfData, d );
        return memcmp( &d, from_csharp, sizeof(A3DRWParamsExport3mfData));
    }
    DECL_SPEC int32_t Verify_A3DRWParamsExportXMLData(A3DRWParamsExportXMLData *from_csharp) {
        A3DRWParamsExportXMLData d;
        A3D_INITIALIZE_DATA( A3DRWParamsExportXMLData, d );
        return memcmp( &d, from_csharp, sizeof(A3DRWParamsExportXMLData));
    }
    DECL_SPEC int32_t Verify_A3DRWParamsExportObjData(A3DRWParamsExportObjData *from_csharp) {
        A3DRWParamsExportObjData d;
        A3D_INITIALIZE_DATA( A3DRWParamsExportObjData, d );
        return memcmp( &d, from_csharp, sizeof(A3DRWParamsExportObjData));
    }
    DECL_SPEC int32_t Verify_A3DRWParamsExportFbxData(A3DRWParamsExportFbxData *from_csharp) {
        A3DRWParamsExportFbxData d;
        A3D_INITIALIZE_DATA( A3DRWParamsExportFbxData, d );
        return memcmp( &d, from_csharp, sizeof(A3DRWParamsExportFbxData));
    }
    DECL_SPEC int32_t Verify_A3DRWParamsExportGltfData(A3DRWParamsExportGltfData *from_csharp) {
        A3DRWParamsExportGltfData d;
        A3D_INITIALIZE_DATA( A3DRWParamsExportGltfData, d );
        return memcmp( &d, from_csharp, sizeof(A3DRWParamsExportGltfData));
    }
    DECL_SPEC int32_t Verify_A3DSewOptionsData(A3DSewOptionsData *from_csharp) {
        A3DSewOptionsData d;
        A3D_INITIALIZE_DATA( A3DSewOptionsData, d );
        return memcmp( &d, from_csharp, sizeof(A3DSewOptionsData));
    }
    DECL_SPEC int32_t Verify_A3DFaceUVPointInsideManagerData(A3DFaceUVPointInsideManagerData *from_csharp) {
        A3DFaceUVPointInsideManagerData d;
        A3D_INITIALIZE_DATA( A3DFaceUVPointInsideManagerData, d );
        return memcmp( &d, from_csharp, sizeof(A3DFaceUVPointInsideManagerData));
    }
    DECL_SPEC int32_t Verify_A3DProjectedPointCloudData(A3DProjectedPointCloudData *from_csharp) {
        A3DProjectedPointCloudData d;
        A3D_INITIALIZE_DATA( A3DProjectedPointCloudData, d );
        return memcmp( &d, from_csharp, sizeof(A3DProjectedPointCloudData));
    }
    DECL_SPEC int32_t Verify_A3DProjectPointCloudManagerDataFromRI(A3DProjectPointCloudManagerDataFromRI *from_csharp) {
        A3DProjectPointCloudManagerDataFromRI d;
        A3D_INITIALIZE_DATA( A3DProjectPointCloudManagerDataFromRI, d );
        return memcmp( &d, from_csharp, sizeof(A3DProjectPointCloudManagerDataFromRI));
    }
    DECL_SPEC int32_t Verify_A3DProjectPointCloudOptionsData(A3DProjectPointCloudOptionsData *from_csharp) {
        A3DProjectPointCloudOptionsData d;
        A3D_INITIALIZE_DATA( A3DProjectPointCloudOptionsData, d );
        return memcmp( &d, from_csharp, sizeof(A3DProjectPointCloudOptionsData));
    }
    DECL_SPEC int32_t Verify_A3DPlanarSectionData(A3DPlanarSectionData *from_csharp) {
        A3DPlanarSectionData d;
        A3D_INITIALIZE_DATA( A3DPlanarSectionData, d );
        return memcmp( &d, from_csharp, sizeof(A3DPlanarSectionData));
    }
    DECL_SPEC int32_t Verify_A3DCompareInputData(A3DCompareInputData *from_csharp) {
        A3DCompareInputData d;
        A3D_INITIALIZE_DATA( A3DCompareInputData, d );
        return memcmp( &d, from_csharp, sizeof(A3DCompareInputData));
    }
    DECL_SPEC int32_t Verify_A3DCompareOutputData(A3DCompareOutputData *from_csharp) {
        A3DCompareOutputData d;
        A3D_INITIALIZE_DATA( A3DCompareOutputData, d );
        return memcmp( &d, from_csharp, sizeof(A3DCompareOutputData));
    }
    DECL_SPEC int32_t Verify_A3DMultiPlanarSectionData(A3DMultiPlanarSectionData *from_csharp) {
        A3DMultiPlanarSectionData d;
        A3D_INITIALIZE_DATA( A3DMultiPlanarSectionData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMultiPlanarSectionData));
    }
    DECL_SPEC int32_t Verify_A3DHLRViewPlaneData(A3DHLRViewPlaneData *from_csharp) {
        A3DHLRViewPlaneData d;
        A3D_INITIALIZE_DATA( A3DHLRViewPlaneData, d );
        return memcmp( &d, from_csharp, sizeof(A3DHLRViewPlaneData));
    }
    DECL_SPEC int32_t Verify_A3DHLRCurveData(A3DHLRCurveData *from_csharp) {
        A3DHLRCurveData d;
        A3D_INITIALIZE_DATA( A3DHLRCurveData, d );
        return memcmp( &d, from_csharp, sizeof(A3DHLRCurveData));
    }
    DECL_SPEC int32_t Verify_A3DHLRSectionFaceData(A3DHLRSectionFaceData *from_csharp) {
        A3DHLRSectionFaceData d;
        A3D_INITIALIZE_DATA( A3DHLRSectionFaceData, d );
        return memcmp( &d, from_csharp, sizeof(A3DHLRSectionFaceData));
    }
    DECL_SPEC int32_t Verify_A3DHLRRepresentationItemData(A3DHLRRepresentationItemData *from_csharp) {
        A3DHLRRepresentationItemData d;
        A3D_INITIALIZE_DATA( A3DHLRRepresentationItemData, d );
        return memcmp( &d, from_csharp, sizeof(A3DHLRRepresentationItemData));
    }
    DECL_SPEC int32_t Verify_A3DHLROptionsData(A3DHLROptionsData *from_csharp) {
        A3DHLROptionsData d;
        A3D_INITIALIZE_DATA( A3DHLROptionsData, d );
        return memcmp( &d, from_csharp, sizeof(A3DHLROptionsData));
    }
    DECL_SPEC int32_t Verify_A3DTransfoRepresentationItemData(A3DTransfoRepresentationItemData *from_csharp) {
        A3DTransfoRepresentationItemData d;
        A3D_INITIALIZE_DATA( A3DTransfoRepresentationItemData, d );
        return memcmp( &d, from_csharp, sizeof(A3DTransfoRepresentationItemData));
    }
    DECL_SPEC int32_t Verify_A3DCollisionGroupData(A3DCollisionGroupData *from_csharp) {
        A3DCollisionGroupData d;
        A3D_INITIALIZE_DATA( A3DCollisionGroupData, d );
        return memcmp( &d, from_csharp, sizeof(A3DCollisionGroupData));
    }
    DECL_SPEC int32_t Verify_A3DCollisionParameterData(A3DCollisionParameterData *from_csharp) {
        A3DCollisionParameterData d;
        A3D_INITIALIZE_DATA( A3DCollisionParameterData, d );
        return memcmp( &d, from_csharp, sizeof(A3DCollisionParameterData));
    }
    DECL_SPEC int32_t Verify_A3DCollisionResultData(A3DCollisionResultData *from_csharp) {
        A3DCollisionResultData d;
        A3D_INITIALIZE_DATA( A3DCollisionResultData, d );
        return memcmp( &d, from_csharp, sizeof(A3DCollisionResultData));
    }
    DECL_SPEC int32_t Verify_A3DBIMDataData(A3DBIMDataData *from_csharp) {
        A3DBIMDataData d;
        A3D_INITIALIZE_DATA( A3DBIMDataData, d );
        return memcmp( &d, from_csharp, sizeof(A3DBIMDataData));
    }
    DECL_SPEC int32_t Verify_A3DBIMRelContainedInSpatialStructureData(A3DBIMRelContainedInSpatialStructureData *from_csharp) {
        A3DBIMRelContainedInSpatialStructureData d;
        A3D_INITIALIZE_DATA( A3DBIMRelContainedInSpatialStructureData, d );
        return memcmp( &d, from_csharp, sizeof(A3DBIMRelContainedInSpatialStructureData));
    }
    DECL_SPEC int32_t Verify_A3DBIMRelFillsElementData(A3DBIMRelFillsElementData *from_csharp) {
        A3DBIMRelFillsElementData d;
        A3D_INITIALIZE_DATA( A3DBIMRelFillsElementData, d );
        return memcmp( &d, from_csharp, sizeof(A3DBIMRelFillsElementData));
    }
    DECL_SPEC int32_t Verify_A3DBIMRelSpaceBoundaryData(A3DBIMRelSpaceBoundaryData *from_csharp) {
        A3DBIMRelSpaceBoundaryData d;
        A3D_INITIALIZE_DATA( A3DBIMRelSpaceBoundaryData, d );
        return memcmp( &d, from_csharp, sizeof(A3DBIMRelSpaceBoundaryData));
    }
    DECL_SPEC int32_t Verify_A3DBIMRelAggregatesData(A3DBIMRelAggregatesData *from_csharp) {
        A3DBIMRelAggregatesData d;
        A3D_INITIALIZE_DATA( A3DBIMRelAggregatesData, d );
        return memcmp( &d, from_csharp, sizeof(A3DBIMRelAggregatesData));
    }
    DECL_SPEC int32_t Verify_A3DBIMRelVoidsElementData(A3DBIMRelVoidsElementData *from_csharp) {
        A3DBIMRelVoidsElementData d;
        A3D_INITIALIZE_DATA( A3DBIMRelVoidsElementData, d );
        return memcmp( &d, from_csharp, sizeof(A3DBIMRelVoidsElementData));
    }
    DECL_SPEC int32_t Verify_A3DBIMRelConnectsPathElementsData(A3DBIMRelConnectsPathElementsData *from_csharp) {
        A3DBIMRelConnectsPathElementsData d;
        A3D_INITIALIZE_DATA( A3DBIMRelConnectsPathElementsData, d );
        return memcmp( &d, from_csharp, sizeof(A3DBIMRelConnectsPathElementsData));
    }
    DECL_SPEC int32_t Verify_A3DBIMRootData(A3DBIMRootData *from_csharp) {
        A3DBIMRootData d;
        A3D_INITIALIZE_DATA( A3DBIMRootData, d );
        return memcmp( &d, from_csharp, sizeof(A3DBIMRootData));
    }
    DECL_SPEC int32_t Verify_A3DMiscConstraintLinkedItemData(A3DMiscConstraintLinkedItemData *from_csharp) {
        A3DMiscConstraintLinkedItemData d;
        A3D_INITIALIZE_DATA( A3DMiscConstraintLinkedItemData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMiscConstraintLinkedItemData));
    }
    DECL_SPEC int32_t Verify_A3DAsmConstraintData(A3DAsmConstraintData *from_csharp) {
        A3DAsmConstraintData d;
        A3D_INITIALIZE_DATA( A3DAsmConstraintData, d );
        return memcmp( &d, from_csharp, sizeof(A3DAsmConstraintData));
    }
    DECL_SPEC int32_t Verify_A3DMkpLeaderData(A3DMkpLeaderData *from_csharp) {
        A3DMkpLeaderData d;
        A3D_INITIALIZE_DATA( A3DMkpLeaderData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMkpLeaderData));
    }
    DECL_SPEC int32_t Verify_A3DMkpAnnotationItemData(A3DMkpAnnotationItemData *from_csharp) {
        A3DMkpAnnotationItemData d;
        A3D_INITIALIZE_DATA( A3DMkpAnnotationItemData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMkpAnnotationItemData));
    }
    DECL_SPEC int32_t Verify_A3DMkpAnnotationSetData(A3DMkpAnnotationSetData *from_csharp) {
        A3DMkpAnnotationSetData d;
        A3D_INITIALIZE_DATA( A3DMkpAnnotationSetData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMkpAnnotationSetData));
    }
    DECL_SPEC int32_t Verify_A3DMkpAnnotationReferenceData(A3DMkpAnnotationReferenceData *from_csharp) {
        A3DMkpAnnotationReferenceData d;
        A3D_INITIALIZE_DATA( A3DMkpAnnotationReferenceData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMkpAnnotationReferenceData));
    }
    DECL_SPEC int32_t Verify_A3DMkpViewData(A3DMkpViewData *from_csharp) {
        A3DMkpViewData d;
        A3D_INITIALIZE_DATA( A3DMkpViewData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMkpViewData));
    }
    DECL_SPEC int32_t Verify_A3DMkpViewFlagsData(A3DMkpViewFlagsData *from_csharp) {
        A3DMkpViewFlagsData d;
        A3D_INITIALIZE_DATA( A3DMkpViewFlagsData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMkpViewFlagsData));
    }
    DECL_SPEC int32_t Verify_A3DMiscMarkupLinkedItemData(A3DMiscMarkupLinkedItemData *from_csharp) {
        A3DMiscMarkupLinkedItemData d;
        A3D_INITIALIZE_DATA( A3DMiscMarkupLinkedItemData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMiscMarkupLinkedItemData));
    }
    DECL_SPEC int32_t Verify_A3DMkpMarkupData(A3DMkpMarkupData *from_csharp) {
        A3DMkpMarkupData d;
        A3D_INITIALIZE_DATA( A3DMkpMarkupData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMkpMarkupData));
    }
    DECL_SPEC int32_t Verify_A3DMkpRTFFieldData(A3DMkpRTFFieldData *from_csharp) {
        A3DMkpRTFFieldData d;
        A3D_INITIALIZE_DATA( A3DMkpRTFFieldData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMkpRTFFieldData));
    }
    DECL_SPEC int32_t Verify_A3DFontKeyData(A3DFontKeyData *from_csharp) {
        A3DFontKeyData d;
        A3D_INITIALIZE_DATA( A3DFontKeyData, d );
        return memcmp( &d, from_csharp, sizeof(A3DFontKeyData));
    }
    DECL_SPEC int32_t Verify_A3DFontData(A3DFontData *from_csharp) {
        A3DFontData d;
        A3D_INITIALIZE_DATA( A3DFontData, d );
        return memcmp( &d, from_csharp, sizeof(A3DFontData));
    }
    DECL_SPEC int32_t Verify_A3DGraphTextureTransformationData(A3DGraphTextureTransformationData *from_csharp) {
        A3DGraphTextureTransformationData d;
        A3D_INITIALIZE_DATA( A3DGraphTextureTransformationData, d );
        return memcmp( &d, from_csharp, sizeof(A3DGraphTextureTransformationData));
    }
    DECL_SPEC int32_t Verify_A3DGraphTextureDefinitionData(A3DGraphTextureDefinitionData *from_csharp) {
        A3DGraphTextureDefinitionData d;
        A3D_INITIALIZE_DATA( A3DGraphTextureDefinitionData, d );
        return memcmp( &d, from_csharp, sizeof(A3DGraphTextureDefinitionData));
    }
    DECL_SPEC int32_t Verify_A3DGraphTextureApplicationData(A3DGraphTextureApplicationData *from_csharp) {
        A3DGraphTextureApplicationData d;
        A3D_INITIALIZE_DATA( A3DGraphTextureApplicationData, d );
        return memcmp( &d, from_csharp, sizeof(A3DGraphTextureApplicationData));
    }
    DECL_SPEC int32_t Verify_A3DDrawingModelData(A3DDrawingModelData *from_csharp) {
        A3DDrawingModelData d;
        A3D_INITIALIZE_DATA( A3DDrawingModelData, d );
        return memcmp( &d, from_csharp, sizeof(A3DDrawingModelData));
    }
    DECL_SPEC int32_t Verify_A3DDrawingSheetFormatData(A3DDrawingSheetFormatData *from_csharp) {
        A3DDrawingSheetFormatData d;
        A3D_INITIALIZE_DATA( A3DDrawingSheetFormatData, d );
        return memcmp( &d, from_csharp, sizeof(A3DDrawingSheetFormatData));
    }
    DECL_SPEC int32_t Verify_A3DDrawingSheetData(A3DDrawingSheetData *from_csharp) {
        A3DDrawingSheetData d;
        A3D_INITIALIZE_DATA( A3DDrawingSheetData, d );
        return memcmp( &d, from_csharp, sizeof(A3DDrawingSheetData));
    }
    DECL_SPEC int32_t Verify_A3DDrawingClipFrameData(A3DDrawingClipFrameData *from_csharp) {
        A3DDrawingClipFrameData d;
        A3D_INITIALIZE_DATA( A3DDrawingClipFrameData, d );
        return memcmp( &d, from_csharp, sizeof(A3DDrawingClipFrameData));
    }
    DECL_SPEC int32_t Verify_A3DDrawingViewData(A3DDrawingViewData *from_csharp) {
        A3DDrawingViewData d;
        A3D_INITIALIZE_DATA( A3DDrawingViewData, d );
        return memcmp( &d, from_csharp, sizeof(A3DDrawingViewData));
    }
    DECL_SPEC int32_t Verify_A3DDrawingBlockBasicData(A3DDrawingBlockBasicData *from_csharp) {
        A3DDrawingBlockBasicData d;
        A3D_INITIALIZE_DATA( A3DDrawingBlockBasicData, d );
        return memcmp( &d, from_csharp, sizeof(A3DDrawingBlockBasicData));
    }
    DECL_SPEC int32_t Verify_A3DDrawingBlockOperatorData(A3DDrawingBlockOperatorData *from_csharp) {
        A3DDrawingBlockOperatorData d;
        A3D_INITIALIZE_DATA( A3DDrawingBlockOperatorData, d );
        return memcmp( &d, from_csharp, sizeof(A3DDrawingBlockOperatorData));
    }
    DECL_SPEC int32_t Verify_A3DDrawingCurveData(A3DDrawingCurveData *from_csharp) {
        A3DDrawingCurveData d;
        A3D_INITIALIZE_DATA( A3DDrawingCurveData, d );
        return memcmp( &d, from_csharp, sizeof(A3DDrawingCurveData));
    }
    DECL_SPEC int32_t Verify_A3DDrawingFilledAreaData(A3DDrawingFilledAreaData *from_csharp) {
        A3DDrawingFilledAreaData d;
        A3D_INITIALIZE_DATA( A3DDrawingFilledAreaData, d );
        return memcmp( &d, from_csharp, sizeof(A3DDrawingFilledAreaData));
    }
    DECL_SPEC int32_t Verify_A3DDrawingPictureData(A3DDrawingPictureData *from_csharp) {
        A3DDrawingPictureData d;
        A3D_INITIALIZE_DATA( A3DDrawingPictureData, d );
        return memcmp( &d, from_csharp, sizeof(A3DDrawingPictureData));
    }
    DECL_SPEC int32_t Verify_A3DDrawingVerticesData(A3DDrawingVerticesData *from_csharp) {
        A3DDrawingVerticesData d;
        A3D_INITIALIZE_DATA( A3DDrawingVerticesData, d );
        return memcmp( &d, from_csharp, sizeof(A3DDrawingVerticesData));
    }
    DECL_SPEC int32_t Verify_A3DThumbnailData(A3DThumbnailData *from_csharp) {
        A3DThumbnailData d;
        A3D_INITIALIZE_DATA( A3DThumbnailData, d );
        return memcmp( &d, from_csharp, sizeof(A3DThumbnailData));
    }
    DECL_SPEC int32_t Verify_A3DFileInformationData(A3DFileInformationData *from_csharp) {
        A3DFileInformationData d;
        A3D_INITIALIZE_DATA( A3DFileInformationData, d );
        return memcmp( &d, from_csharp, sizeof(A3DFileInformationData));
    }
    DECL_SPEC int32_t Verify_A3DFileContextData(A3DFileContextData *from_csharp) {
        A3DFileContextData d;
        A3D_INITIALIZE_DATA( A3DFileContextData, d );
        return memcmp( &d, from_csharp, sizeof(A3DFileContextData));
    }
    DECL_SPEC int32_t Verify_A3DRWParamsExportParasolidData(A3DRWParamsExportParasolidData *from_csharp) {
        A3DRWParamsExportParasolidData d;
        A3D_INITIALIZE_DATA( A3DRWParamsExportParasolidData, d );
        return memcmp( &d, from_csharp, sizeof(A3DRWParamsExportParasolidData));
    }
    DECL_SPEC int32_t Verify_A3DRWParamsTranslateToPkPartsData(A3DRWParamsTranslateToPkPartsData *from_csharp) {
        A3DRWParamsTranslateToPkPartsData d;
        A3D_INITIALIZE_DATA( A3DRWParamsTranslateToPkPartsData, d );
        return memcmp( &d, from_csharp, sizeof(A3DRWParamsTranslateToPkPartsData));
    }
    DECL_SPEC int32_t Verify_A3DRWParamsExportAcisData(A3DRWParamsExportAcisData *from_csharp) {
        A3DRWParamsExportAcisData d;
        A3D_INITIALIZE_DATA( A3DRWParamsExportAcisData, d );
        return memcmp( &d, from_csharp, sizeof(A3DRWParamsExportAcisData));
    }
    DECL_SPEC int32_t Verify_A3DRiRepresentationItemData(A3DRiRepresentationItemData *from_csharp) {
        A3DRiRepresentationItemData d;
        A3D_INITIALIZE_DATA( A3DRiRepresentationItemData, d );
        return memcmp( &d, from_csharp, sizeof(A3DRiRepresentationItemData));
    }
    DECL_SPEC int32_t Verify_A3DRiSetData(A3DRiSetData *from_csharp) {
        A3DRiSetData d;
        A3D_INITIALIZE_DATA( A3DRiSetData, d );
        return memcmp( &d, from_csharp, sizeof(A3DRiSetData));
    }
    DECL_SPEC int32_t Verify_A3DRiPointSetData(A3DRiPointSetData *from_csharp) {
        A3DRiPointSetData d;
        A3D_INITIALIZE_DATA( A3DRiPointSetData, d );
        return memcmp( &d, from_csharp, sizeof(A3DRiPointSetData));
    }
    DECL_SPEC int32_t Verify_A3DRiDirectionData(A3DRiDirectionData *from_csharp) {
        A3DRiDirectionData d;
        A3D_INITIALIZE_DATA( A3DRiDirectionData, d );
        return memcmp( &d, from_csharp, sizeof(A3DRiDirectionData));
    }
    DECL_SPEC int32_t Verify_A3DRiCoordinateSystemData(A3DRiCoordinateSystemData *from_csharp) {
        A3DRiCoordinateSystemData d;
        A3D_INITIALIZE_DATA( A3DRiCoordinateSystemData, d );
        return memcmp( &d, from_csharp, sizeof(A3DRiCoordinateSystemData));
    }
    DECL_SPEC int32_t Verify_A3DRiCurveData(A3DRiCurveData *from_csharp) {
        A3DRiCurveData d;
        A3D_INITIALIZE_DATA( A3DRiCurveData, d );
        return memcmp( &d, from_csharp, sizeof(A3DRiCurveData));
    }
    DECL_SPEC int32_t Verify_A3DRiPlaneData(A3DRiPlaneData *from_csharp) {
        A3DRiPlaneData d;
        A3D_INITIALIZE_DATA( A3DRiPlaneData, d );
        return memcmp( &d, from_csharp, sizeof(A3DRiPlaneData));
    }
    DECL_SPEC int32_t Verify_A3DRiBrepModelData(A3DRiBrepModelData *from_csharp) {
        A3DRiBrepModelData d;
        A3D_INITIALIZE_DATA( A3DRiBrepModelData, d );
        return memcmp( &d, from_csharp, sizeof(A3DRiBrepModelData));
    }
    DECL_SPEC int32_t Verify_A3DRiPolyBrepModelData(A3DRiPolyBrepModelData *from_csharp) {
        A3DRiPolyBrepModelData d;
        A3D_INITIALIZE_DATA( A3DRiPolyBrepModelData, d );
        return memcmp( &d, from_csharp, sizeof(A3DRiPolyBrepModelData));
    }
    DECL_SPEC int32_t Verify_A3DRiPolyWireData(A3DRiPolyWireData *from_csharp) {
        A3DRiPolyWireData d;
        A3D_INITIALIZE_DATA( A3DRiPolyWireData, d );
        return memcmp( &d, from_csharp, sizeof(A3DRiPolyWireData));
    }
    DECL_SPEC int32_t Verify_A3DFRMFeatureTreeData(A3DFRMFeatureTreeData *from_csharp) {
        A3DFRMFeatureTreeData d;
        A3D_INITIALIZE_DATA( A3DFRMFeatureTreeData, d );
        return memcmp( &d, from_csharp, sizeof(A3DFRMFeatureTreeData));
    }
    DECL_SPEC int32_t Verify_A3DFRMParameterData(A3DFRMParameterData *from_csharp) {
        A3DFRMParameterData d;
        A3D_INITIALIZE_DATA( A3DFRMParameterData, d );
        return memcmp( &d, from_csharp, sizeof(A3DFRMParameterData));
    }
    DECL_SPEC int32_t Verify_A3DFRMFeatureTypeData(A3DFRMFeatureTypeData *from_csharp) {
        A3DFRMFeatureTypeData d;
        A3D_INITIALIZE_DATA( A3DFRMFeatureTypeData, d );
        return memcmp( &d, from_csharp, sizeof(A3DFRMFeatureTypeData));
    }
    DECL_SPEC int32_t Verify_A3DFRMStringData(A3DFRMStringData *from_csharp) {
        A3DFRMStringData d;
        A3D_INITIALIZE_DATA( A3DFRMStringData, d );
        return memcmp( &d, from_csharp, sizeof(A3DFRMStringData));
    }
    DECL_SPEC int32_t Verify_A3DFRMDoubleData(A3DFRMDoubleData *from_csharp) {
        A3DFRMDoubleData d;
        A3D_INITIALIZE_DATA( A3DFRMDoubleData, d );
        return memcmp( &d, from_csharp, sizeof(A3DFRMDoubleData));
    }
    DECL_SPEC int32_t Verify_A3DFRMIntegerData(A3DFRMIntegerData *from_csharp) {
        A3DFRMIntegerData d;
        A3D_INITIALIZE_DATA( A3DFRMIntegerData, d );
        return memcmp( &d, from_csharp, sizeof(A3DFRMIntegerData));
    }
    DECL_SPEC int32_t Verify_A3DFRMFeatureLinkedItemData(A3DFRMFeatureLinkedItemData *from_csharp) {
        A3DFRMFeatureLinkedItemData d;
        A3D_INITIALIZE_DATA( A3DFRMFeatureLinkedItemData, d );
        return memcmp( &d, from_csharp, sizeof(A3DFRMFeatureLinkedItemData));
    }
    DECL_SPEC int32_t Verify_A3DFRMFeatureData(A3DFRMFeatureData *from_csharp) {
        A3DFRMFeatureData d;
        A3D_INITIALIZE_DATA( A3DFRMFeatureData, d );
        return memcmp( &d, from_csharp, sizeof(A3DFRMFeatureData));
    }
    DECL_SPEC int32_t Verify_A3DFRMFeatureGeomEntitiesData(A3DFRMFeatureGeomEntitiesData *from_csharp) {
        A3DFRMFeatureGeomEntitiesData d;
        A3D_INITIALIZE_DATA( A3DFRMFeatureGeomEntitiesData, d );
        return memcmp( &d, from_csharp, sizeof(A3DFRMFeatureGeomEntitiesData));
    }
    DECL_SPEC int32_t Verify_A3DCrvNurbsData(A3DCrvNurbsData *from_csharp) {
        A3DCrvNurbsData d;
        A3D_INITIALIZE_DATA( A3DCrvNurbsData, d );
        return memcmp( &d, from_csharp, sizeof(A3DCrvNurbsData));
    }
    DECL_SPEC int32_t Verify_A3DCrvLineData(A3DCrvLineData *from_csharp) {
        A3DCrvLineData d;
        A3D_INITIALIZE_DATA( A3DCrvLineData, d );
        return memcmp( &d, from_csharp, sizeof(A3DCrvLineData));
    }
    DECL_SPEC int32_t Verify_A3DCrvCircleData(A3DCrvCircleData *from_csharp) {
        A3DCrvCircleData d;
        A3D_INITIALIZE_DATA( A3DCrvCircleData, d );
        return memcmp( &d, from_csharp, sizeof(A3DCrvCircleData));
    }
    DECL_SPEC int32_t Verify_A3DCrvEllipseData(A3DCrvEllipseData *from_csharp) {
        A3DCrvEllipseData d;
        A3D_INITIALIZE_DATA( A3DCrvEllipseData, d );
        return memcmp( &d, from_csharp, sizeof(A3DCrvEllipseData));
    }
    DECL_SPEC int32_t Verify_A3DCrvParabolaData(A3DCrvParabolaData *from_csharp) {
        A3DCrvParabolaData d;
        A3D_INITIALIZE_DATA( A3DCrvParabolaData, d );
        return memcmp( &d, from_csharp, sizeof(A3DCrvParabolaData));
    }
    DECL_SPEC int32_t Verify_A3DCrvHyperbolaData(A3DCrvHyperbolaData *from_csharp) {
        A3DCrvHyperbolaData d;
        A3D_INITIALIZE_DATA( A3DCrvHyperbolaData, d );
        return memcmp( &d, from_csharp, sizeof(A3DCrvHyperbolaData));
    }
    DECL_SPEC int32_t Verify_A3DCrvPolyLineData(A3DCrvPolyLineData *from_csharp) {
        A3DCrvPolyLineData d;
        A3D_INITIALIZE_DATA( A3DCrvPolyLineData, d );
        return memcmp( &d, from_csharp, sizeof(A3DCrvPolyLineData));
    }
    DECL_SPEC int32_t Verify_A3DCrvCompositeData(A3DCrvCompositeData *from_csharp) {
        A3DCrvCompositeData d;
        A3D_INITIALIZE_DATA( A3DCrvCompositeData, d );
        return memcmp( &d, from_csharp, sizeof(A3DCrvCompositeData));
    }
    DECL_SPEC int32_t Verify_A3DCrvEquationData(A3DCrvEquationData *from_csharp) {
        A3DCrvEquationData d;
        A3D_INITIALIZE_DATA( A3DCrvEquationData, d );
        return memcmp( &d, from_csharp, sizeof(A3DCrvEquationData));
    }
    DECL_SPEC int32_t Verify_A3DCrvTransformData(A3DCrvTransformData *from_csharp) {
        A3DCrvTransformData d;
        A3D_INITIALIZE_DATA( A3DCrvTransformData, d );
        return memcmp( &d, from_csharp, sizeof(A3DCrvTransformData));
    }
    DECL_SPEC int32_t Verify_A3DCrvOnSurfData(A3DCrvOnSurfData *from_csharp) {
        A3DCrvOnSurfData d;
        A3D_INITIALIZE_DATA( A3DCrvOnSurfData, d );
        return memcmp( &d, from_csharp, sizeof(A3DCrvOnSurfData));
    }
    DECL_SPEC int32_t Verify_A3DCrvOffsetData(A3DCrvOffsetData *from_csharp) {
        A3DCrvOffsetData d;
        A3D_INITIALIZE_DATA( A3DCrvOffsetData, d );
        return memcmp( &d, from_csharp, sizeof(A3DCrvOffsetData));
    }
    DECL_SPEC int32_t Verify_A3DCrvHelixPitchCstData(A3DCrvHelixPitchCstData *from_csharp) {
        A3DCrvHelixPitchCstData d;
        A3D_INITIALIZE_DATA( A3DCrvHelixPitchCstData, d );
        return memcmp( &d, from_csharp, sizeof(A3DCrvHelixPitchCstData));
    }
    DECL_SPEC int32_t Verify_A3DCrvHelixPitchVarData(A3DCrvHelixPitchVarData *from_csharp) {
        A3DCrvHelixPitchVarData d;
        A3D_INITIALIZE_DATA( A3DCrvHelixPitchVarData, d );
        return memcmp( &d, from_csharp, sizeof(A3DCrvHelixPitchVarData));
    }
    DECL_SPEC int32_t Verify_A3DCrvHelixData(A3DCrvHelixData *from_csharp) {
        A3DCrvHelixData d;
        A3D_INITIALIZE_DATA( A3DCrvHelixData, d );
        return memcmp( &d, from_csharp, sizeof(A3DCrvHelixData));
    }
    DECL_SPEC int32_t Verify_A3DCrossingPointsCrvIntersectionData(A3DCrossingPointsCrvIntersectionData *from_csharp) {
        A3DCrossingPointsCrvIntersectionData d;
        A3D_INITIALIZE_DATA( A3DCrossingPointsCrvIntersectionData, d );
        return memcmp( &d, from_csharp, sizeof(A3DCrossingPointsCrvIntersectionData));
    }
    DECL_SPEC int32_t Verify_A3DCrvIntersectionData(A3DCrvIntersectionData *from_csharp) {
        A3DCrvIntersectionData d;
        A3D_INITIALIZE_DATA( A3DCrvIntersectionData, d );
        return memcmp( &d, from_csharp, sizeof(A3DCrvIntersectionData));
    }
    DECL_SPEC int32_t Verify_A3DCrvBlend02BoundaryData(A3DCrvBlend02BoundaryData *from_csharp) {
        A3DCrvBlend02BoundaryData d;
        A3D_INITIALIZE_DATA( A3DCrvBlend02BoundaryData, d );
        return memcmp( &d, from_csharp, sizeof(A3DCrvBlend02BoundaryData));
    }
    DECL_SPEC int32_t Verify_A3DSurfNurbsData(A3DSurfNurbsData *from_csharp) {
        A3DSurfNurbsData d;
        A3D_INITIALIZE_DATA( A3DSurfNurbsData, d );
        return memcmp( &d, from_csharp, sizeof(A3DSurfNurbsData));
    }
    DECL_SPEC int32_t Verify_A3DSurfSphereData(A3DSurfSphereData *from_csharp) {
        A3DSurfSphereData d;
        A3D_INITIALIZE_DATA( A3DSurfSphereData, d );
        return memcmp( &d, from_csharp, sizeof(A3DSurfSphereData));
    }
    DECL_SPEC int32_t Verify_A3DSurfCylinderData(A3DSurfCylinderData *from_csharp) {
        A3DSurfCylinderData d;
        A3D_INITIALIZE_DATA( A3DSurfCylinderData, d );
        return memcmp( &d, from_csharp, sizeof(A3DSurfCylinderData));
    }
    DECL_SPEC int32_t Verify_A3DSurfTorusData(A3DSurfTorusData *from_csharp) {
        A3DSurfTorusData d;
        A3D_INITIALIZE_DATA( A3DSurfTorusData, d );
        return memcmp( &d, from_csharp, sizeof(A3DSurfTorusData));
    }
    DECL_SPEC int32_t Verify_A3DSurfRevolutionData(A3DSurfRevolutionData *from_csharp) {
        A3DSurfRevolutionData d;
        A3D_INITIALIZE_DATA( A3DSurfRevolutionData, d );
        return memcmp( &d, from_csharp, sizeof(A3DSurfRevolutionData));
    }
    DECL_SPEC int32_t Verify_A3DSurfExtrusionData(A3DSurfExtrusionData *from_csharp) {
        A3DSurfExtrusionData d;
        A3D_INITIALIZE_DATA( A3DSurfExtrusionData, d );
        return memcmp( &d, from_csharp, sizeof(A3DSurfExtrusionData));
    }
    DECL_SPEC int32_t Verify_A3DSurfOffsetData(A3DSurfOffsetData *from_csharp) {
        A3DSurfOffsetData d;
        A3D_INITIALIZE_DATA( A3DSurfOffsetData, d );
        return memcmp( &d, from_csharp, sizeof(A3DSurfOffsetData));
    }
    DECL_SPEC int32_t Verify_A3DSurfPlaneData(A3DSurfPlaneData *from_csharp) {
        A3DSurfPlaneData d;
        A3D_INITIALIZE_DATA( A3DSurfPlaneData, d );
        return memcmp( &d, from_csharp, sizeof(A3DSurfPlaneData));
    }
    DECL_SPEC int32_t Verify_A3DSurfBlend01Data(A3DSurfBlend01Data *from_csharp) {
        A3DSurfBlend01Data d;
        A3D_INITIALIZE_DATA( A3DSurfBlend01Data, d );
        return memcmp( &d, from_csharp, sizeof(A3DSurfBlend01Data));
    }
    DECL_SPEC int32_t Verify_A3DSurfBlend02Data(A3DSurfBlend02Data *from_csharp) {
        A3DSurfBlend02Data d;
        A3D_INITIALIZE_DATA( A3DSurfBlend02Data, d );
        return memcmp( &d, from_csharp, sizeof(A3DSurfBlend02Data));
    }
    DECL_SPEC int32_t Verify_A3DSurfBlend03Data(A3DSurfBlend03Data *from_csharp) {
        A3DSurfBlend03Data d;
        A3D_INITIALIZE_DATA( A3DSurfBlend03Data, d );
        return memcmp( &d, from_csharp, sizeof(A3DSurfBlend03Data));
    }
    DECL_SPEC int32_t Verify_A3DSurfConeData(A3DSurfConeData *from_csharp) {
        A3DSurfConeData d;
        A3D_INITIALIZE_DATA( A3DSurfConeData, d );
        return memcmp( &d, from_csharp, sizeof(A3DSurfConeData));
    }
    DECL_SPEC int32_t Verify_A3DSurfCylindricalData(A3DSurfCylindricalData *from_csharp) {
        A3DSurfCylindricalData d;
        A3D_INITIALIZE_DATA( A3DSurfCylindricalData, d );
        return memcmp( &d, from_csharp, sizeof(A3DSurfCylindricalData));
    }
    DECL_SPEC int32_t Verify_A3DSurfRuledData(A3DSurfRuledData *from_csharp) {
        A3DSurfRuledData d;
        A3D_INITIALIZE_DATA( A3DSurfRuledData, d );
        return memcmp( &d, from_csharp, sizeof(A3DSurfRuledData));
    }
    DECL_SPEC int32_t Verify_A3DSurfPipeData(A3DSurfPipeData *from_csharp) {
        A3DSurfPipeData d;
        A3D_INITIALIZE_DATA( A3DSurfPipeData, d );
        return memcmp( &d, from_csharp, sizeof(A3DSurfPipeData));
    }
    DECL_SPEC int32_t Verify_A3DSurfTransformData(A3DSurfTransformData *from_csharp) {
        A3DSurfTransformData d;
        A3D_INITIALIZE_DATA( A3DSurfTransformData, d );
        return memcmp( &d, from_csharp, sizeof(A3DSurfTransformData));
    }
    DECL_SPEC int32_t Verify_A3DSurfFromCurvesData(A3DSurfFromCurvesData *from_csharp) {
        A3DSurfFromCurvesData d;
        A3D_INITIALIZE_DATA( A3DSurfFromCurvesData, d );
        return memcmp( &d, from_csharp, sizeof(A3DSurfFromCurvesData));
    }
    DECL_SPEC int32_t Verify_A3DGlobalData(A3DGlobalData *from_csharp) {
        A3DGlobalData d;
        A3D_INITIALIZE_DATA( A3DGlobalData, d );
        return memcmp( &d, from_csharp, sizeof(A3DGlobalData));
    }
    DECL_SPEC int32_t Verify_A3DMDPosition3DData(A3DMDPosition3DData *from_csharp) {
        A3DMDPosition3DData d;
        A3D_INITIALIZE_DATA( A3DMDPosition3DData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMDPosition3DData));
    }
    DECL_SPEC int32_t Verify_A3DMDPosition2DData(A3DMDPosition2DData *from_csharp) {
        A3DMDPosition2DData d;
        A3D_INITIALIZE_DATA( A3DMDPosition2DData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMDPosition2DData));
    }
    DECL_SPEC int32_t Verify_A3DMDPositionReferenceData(A3DMDPositionReferenceData *from_csharp) {
        A3DMDPositionReferenceData d;
        A3D_INITIALIZE_DATA( A3DMDPositionReferenceData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMDPositionReferenceData));
    }
    DECL_SPEC int32_t Verify_A3DMDLeaderSymbolData(A3DMDLeaderSymbolData *from_csharp) {
        A3DMDLeaderSymbolData d;
        A3D_INITIALIZE_DATA( A3DMDLeaderSymbolData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMDLeaderSymbolData));
    }
    DECL_SPEC int32_t Verify_A3DMDMarkupLeaderStubData(A3DMDMarkupLeaderStubData *from_csharp) {
        A3DMDMarkupLeaderStubData d;
        A3D_INITIALIZE_DATA( A3DMDMarkupLeaderStubData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMDMarkupLeaderStubData));
    }
    DECL_SPEC int32_t Verify_A3DMDLeaderDefinitionData(A3DMDLeaderDefinitionData *from_csharp) {
        A3DMDLeaderDefinitionData d;
        A3D_INITIALIZE_DATA( A3DMDLeaderDefinitionData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMDLeaderDefinitionData));
    }
    DECL_SPEC int32_t Verify_A3DMDTextPropertiesData(A3DMDTextPropertiesData *from_csharp) {
        A3DMDTextPropertiesData d;
        A3D_INITIALIZE_DATA( A3DMDTextPropertiesData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMDTextPropertiesData));
    }
    DECL_SPEC int32_t Verify_A3DMarkupDefinitionData(A3DMarkupDefinitionData *from_csharp) {
        A3DMarkupDefinitionData d;
        A3D_INITIALIZE_DATA( A3DMarkupDefinitionData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMarkupDefinitionData));
    }
    DECL_SPEC int32_t Verify_A3DMDDimensionValueFormatData(A3DMDDimensionValueFormatData *from_csharp) {
        A3DMDDimensionValueFormatData d;
        A3D_INITIALIZE_DATA( A3DMDDimensionValueFormatData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMDDimensionValueFormatData));
    }
    DECL_SPEC int32_t Verify_A3DMDDimensionSimpleToleranceFormatData(A3DMDDimensionSimpleToleranceFormatData *from_csharp) {
        A3DMDDimensionSimpleToleranceFormatData d;
        A3D_INITIALIZE_DATA( A3DMDDimensionSimpleToleranceFormatData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMDDimensionSimpleToleranceFormatData));
    }
    DECL_SPEC int32_t Verify_A3DMDDimensionCombinedToleranceFormatData(A3DMDDimensionCombinedToleranceFormatData *from_csharp) {
        A3DMDDimensionCombinedToleranceFormatData d;
        A3D_INITIALIZE_DATA( A3DMDDimensionCombinedToleranceFormatData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMDDimensionCombinedToleranceFormatData));
    }
    DECL_SPEC int32_t Verify_A3DMDDimensionValueData(A3DMDDimensionValueData *from_csharp) {
        A3DMDDimensionValueData d;
        A3D_INITIALIZE_DATA( A3DMDDimensionValueData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMDDimensionValueData));
    }
    DECL_SPEC int32_t Verify_A3DMDDimensionSecondPartData(A3DMDDimensionSecondPartData *from_csharp) {
        A3DMDDimensionSecondPartData d;
        A3D_INITIALIZE_DATA( A3DMDDimensionSecondPartData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMDDimensionSecondPartData));
    }
    DECL_SPEC int32_t Verify_A3DMDDimensionForeshortenedData(A3DMDDimensionForeshortenedData *from_csharp) {
        A3DMDDimensionForeshortenedData d;
        A3D_INITIALIZE_DATA( A3DMDDimensionForeshortenedData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMDDimensionForeshortenedData));
    }
    DECL_SPEC int32_t Verify_A3DMDDimensionLineSymbolData(A3DMDDimensionLineSymbolData *from_csharp) {
        A3DMDDimensionLineSymbolData d;
        A3D_INITIALIZE_DATA( A3DMDDimensionLineSymbolData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMDDimensionLineSymbolData));
    }
    DECL_SPEC int32_t Verify_A3DMDDimensionLineData(A3DMDDimensionLineData *from_csharp) {
        A3DMDDimensionLineData d;
        A3D_INITIALIZE_DATA( A3DMDDimensionLineData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMDDimensionLineData));
    }
    DECL_SPEC int32_t Verify_A3DMDDimensionFunnelData(A3DMDDimensionFunnelData *from_csharp) {
        A3DMDDimensionFunnelData d;
        A3D_INITIALIZE_DATA( A3DMDDimensionFunnelData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMDDimensionFunnelData));
    }
    DECL_SPEC int32_t Verify_A3DMDDimensionExtremityData(A3DMDDimensionExtremityData *from_csharp) {
        A3DMDDimensionExtremityData d;
        A3D_INITIALIZE_DATA( A3DMDDimensionExtremityData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMDDimensionExtremityData));
    }
    DECL_SPEC int32_t Verify_A3DMDDimensionExtentionLineData(A3DMDDimensionExtentionLineData *from_csharp) {
        A3DMDDimensionExtentionLineData d;
        A3D_INITIALIZE_DATA( A3DMDDimensionExtentionLineData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMDDimensionExtentionLineData));
    }
    DECL_SPEC int32_t Verify_A3DMarkupDimensionData(A3DMarkupDimensionData *from_csharp) {
        A3DMarkupDimensionData d;
        A3D_INITIALIZE_DATA( A3DMarkupDimensionData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMarkupDimensionData));
    }
    DECL_SPEC int32_t Verify_A3DMarkupRoughnessData(A3DMarkupRoughnessData *from_csharp) {
        A3DMarkupRoughnessData d;
        A3D_INITIALIZE_DATA( A3DMarkupRoughnessData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMarkupRoughnessData));
    }
    DECL_SPEC int32_t Verify_A3DMarkupBalloonData(A3DMarkupBalloonData *from_csharp) {
        A3DMarkupBalloonData d;
        A3D_INITIALIZE_DATA( A3DMarkupBalloonData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMarkupBalloonData));
    }
    DECL_SPEC int32_t Verify_A3DMarkupFastenerData(A3DMarkupFastenerData *from_csharp) {
        A3DMarkupFastenerData d;
        A3D_INITIALIZE_DATA( A3DMarkupFastenerData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMarkupFastenerData));
    }
    DECL_SPEC int32_t Verify_A3DMarkupLocatorData(A3DMarkupLocatorData *from_csharp) {
        A3DMarkupLocatorData d;
        A3D_INITIALIZE_DATA( A3DMarkupLocatorData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMarkupLocatorData));
    }
    DECL_SPEC int32_t Verify_A3DMarkupMeasurementPointData(A3DMarkupMeasurementPointData *from_csharp) {
        A3DMarkupMeasurementPointData d;
        A3D_INITIALIZE_DATA( A3DMarkupMeasurementPointData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMarkupMeasurementPointData));
    }
    DECL_SPEC int32_t Verify_A3DMDTextPositionData(A3DMDTextPositionData *from_csharp) {
        A3DMDTextPositionData d;
        A3D_INITIALIZE_DATA( A3DMDTextPositionData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMDTextPositionData));
    }
    DECL_SPEC int32_t Verify_A3DMarkupTextData(A3DMarkupTextData *from_csharp) {
        A3DMarkupTextData d;
        A3D_INITIALIZE_DATA( A3DMarkupTextData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMarkupTextData));
    }
    DECL_SPEC int32_t Verify_A3DMarkupCoordinateData(A3DMarkupCoordinateData *from_csharp) {
        A3DMarkupCoordinateData d;
        A3D_INITIALIZE_DATA( A3DMarkupCoordinateData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMarkupCoordinateData));
    }
    DECL_SPEC int32_t Verify_A3DMarkupRichTextData(A3DMarkupRichTextData *from_csharp) {
        A3DMarkupRichTextData d;
        A3D_INITIALIZE_DATA( A3DMarkupRichTextData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMarkupRichTextData));
    }
    DECL_SPEC int32_t Verify_A3DMarkupDatumData(A3DMarkupDatumData *from_csharp) {
        A3DMarkupDatumData d;
        A3D_INITIALIZE_DATA( A3DMarkupDatumData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMarkupDatumData));
    }
    DECL_SPEC int32_t Verify_A3DMDFCFDraftingRowData(A3DMDFCFDraftingRowData *from_csharp) {
        A3DMDFCFDraftingRowData d;
        A3D_INITIALIZE_DATA( A3DMDFCFDraftingRowData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMDFCFDraftingRowData));
    }
    DECL_SPEC int32_t Verify_A3DMDFCValueData(A3DMDFCValueData *from_csharp) {
        A3DMDFCValueData d;
        A3D_INITIALIZE_DATA( A3DMDFCValueData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMDFCValueData));
    }
    DECL_SPEC int32_t Verify_A3DMDFCTolerancePerUnitData(A3DMDFCTolerancePerUnitData *from_csharp) {
        A3DMDFCTolerancePerUnitData d;
        A3D_INITIALIZE_DATA( A3DMDFCTolerancePerUnitData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMDFCTolerancePerUnitData));
    }
    DECL_SPEC int32_t Verify_A3DMDFCProjectedZoneData(A3DMDFCProjectedZoneData *from_csharp) {
        A3DMDFCProjectedZoneData d;
        A3D_INITIALIZE_DATA( A3DMDFCProjectedZoneData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMDFCProjectedZoneData));
    }
    DECL_SPEC int32_t Verify_A3DMDFCFToleranceValueData(A3DMDFCFToleranceValueData *from_csharp) {
        A3DMDFCFToleranceValueData d;
        A3D_INITIALIZE_DATA( A3DMDFCFToleranceValueData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMDFCFToleranceValueData));
    }
    DECL_SPEC int32_t Verify_A3DMDFCFRowDatumData(A3DMDFCFRowDatumData *from_csharp) {
        A3DMDFCFRowDatumData d;
        A3D_INITIALIZE_DATA( A3DMDFCFRowDatumData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMDFCFRowDatumData));
    }
    DECL_SPEC int32_t Verify_A3DMDFCFDrawingRowData(A3DMDFCFDrawingRowData *from_csharp) {
        A3DMDFCFDrawingRowData d;
        A3D_INITIALIZE_DATA( A3DMDFCFDrawingRowData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMDFCFDrawingRowData));
    }
    DECL_SPEC int32_t Verify_A3DMDFCFIndicatorData(A3DMDFCFIndicatorData *from_csharp) {
        A3DMDFCFIndicatorData d;
        A3D_INITIALIZE_DATA( A3DMDFCFIndicatorData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMDFCFIndicatorData));
    }
    DECL_SPEC int32_t Verify_A3DMDFCFDraftingIndicatorData(A3DMDFCFDraftingIndicatorData *from_csharp) {
        A3DMDFCFDraftingIndicatorData d;
        A3D_INITIALIZE_DATA( A3DMDFCFDraftingIndicatorData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMDFCFDraftingIndicatorData));
    }
    DECL_SPEC int32_t Verify_A3DMDFeatureControlFrameData(A3DMDFeatureControlFrameData *from_csharp) {
        A3DMDFeatureControlFrameData d;
        A3D_INITIALIZE_DATA( A3DMDFeatureControlFrameData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMDFeatureControlFrameData));
    }
    DECL_SPEC int32_t Verify_A3DMDToleranceSizeValueData(A3DMDToleranceSizeValueData *from_csharp) {
        A3DMDToleranceSizeValueData d;
        A3D_INITIALIZE_DATA( A3DMDToleranceSizeValueData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMDToleranceSizeValueData));
    }
    DECL_SPEC int32_t Verify_A3DMDToleranceSizeData(A3DMDToleranceSizeData *from_csharp) {
        A3DMDToleranceSizeData d;
        A3D_INITIALIZE_DATA( A3DMDToleranceSizeData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMDToleranceSizeData));
    }
    DECL_SPEC int32_t Verify_A3DMarkupGDTData(A3DMarkupGDTData *from_csharp) {
        A3DMarkupGDTData d;
        A3D_INITIALIZE_DATA( A3DMarkupGDTData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMarkupGDTData));
    }
    DECL_SPEC int32_t Verify_A3DMarkupSpotWeldingData(A3DMarkupSpotWeldingData *from_csharp) {
        A3DMarkupSpotWeldingData d;
        A3D_INITIALIZE_DATA( A3DMarkupSpotWeldingData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMarkupSpotWeldingData));
    }
    DECL_SPEC int32_t Verify_A3DMarkupLineWeldingData(A3DMarkupLineWeldingData *from_csharp) {
        A3DMarkupLineWeldingData d;
        A3D_INITIALIZE_DATA( A3DMarkupLineWeldingData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMarkupLineWeldingData));
    }
    DECL_SPEC int32_t Verify_A3DMathFct1DPolynomData(A3DMathFct1DPolynomData *from_csharp) {
        A3DMathFct1DPolynomData d;
        A3D_INITIALIZE_DATA( A3DMathFct1DPolynomData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMathFct1DPolynomData));
    }
    DECL_SPEC int32_t Verify_A3DMathFct1DTrigonometricData(A3DMathFct1DTrigonometricData *from_csharp) {
        A3DMathFct1DTrigonometricData d;
        A3D_INITIALIZE_DATA( A3DMathFct1DTrigonometricData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMathFct1DTrigonometricData));
    }
    DECL_SPEC int32_t Verify_A3DMathFct1DFractionData(A3DMathFct1DFractionData *from_csharp) {
        A3DMathFct1DFractionData d;
        A3D_INITIALIZE_DATA( A3DMathFct1DFractionData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMathFct1DFractionData));
    }
    DECL_SPEC int32_t Verify_A3DMathFct1DArctanCosData(A3DMathFct1DArctanCosData *from_csharp) {
        A3DMathFct1DArctanCosData d;
        A3D_INITIALIZE_DATA( A3DMathFct1DArctanCosData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMathFct1DArctanCosData));
    }
    DECL_SPEC int32_t Verify_A3DMathFct1DCombinationData(A3DMathFct1DCombinationData *from_csharp) {
        A3DMathFct1DCombinationData d;
        A3D_INITIALIZE_DATA( A3DMathFct1DCombinationData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMathFct1DCombinationData));
    }
    DECL_SPEC int32_t Verify_A3DMathFct3DLinearData(A3DMathFct3DLinearData *from_csharp) {
        A3DMathFct3DLinearData d;
        A3D_INITIALIZE_DATA( A3DMathFct3DLinearData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMathFct3DLinearData));
    }
    DECL_SPEC int32_t Verify_A3DMathFct3DNonLinearData(A3DMathFct3DNonLinearData *from_csharp) {
        A3DMathFct3DNonLinearData d;
        A3D_INITIALIZE_DATA( A3DMathFct3DNonLinearData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMathFct3DNonLinearData));
    }
    DECL_SPEC int32_t Verify_A3DRootBaseData(A3DRootBaseData *from_csharp) {
        A3DRootBaseData d;
        A3D_INITIALIZE_DATA( A3DRootBaseData, d );
        return memcmp( &d, from_csharp, sizeof(A3DRootBaseData));
    }
    DECL_SPEC int32_t Verify_A3DRootBaseWithGraphicsData(A3DRootBaseWithGraphicsData *from_csharp) {
        A3DRootBaseWithGraphicsData d;
        A3D_INITIALIZE_DATA( A3DRootBaseWithGraphicsData, d );
        return memcmp( &d, from_csharp, sizeof(A3DRootBaseWithGraphicsData));
    }
    DECL_SPEC int32_t Verify_A3DMiscSingleAttributeData(A3DMiscSingleAttributeData *from_csharp) {
        A3DMiscSingleAttributeData d;
        A3D_INITIALIZE_DATA( A3DMiscSingleAttributeData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMiscSingleAttributeData));
    }
    DECL_SPEC int32_t Verify_A3DMiscAttributeData(A3DMiscAttributeData *from_csharp) {
        A3DMiscAttributeData d;
        A3D_INITIALIZE_DATA( A3DMiscAttributeData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMiscAttributeData));
    }
    DECL_SPEC int32_t Verify_A3DMiscAttributeBasicUnitData(A3DMiscAttributeBasicUnitData *from_csharp) {
        A3DMiscAttributeBasicUnitData d;
        A3D_INITIALIZE_DATA( A3DMiscAttributeBasicUnitData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMiscAttributeBasicUnitData));
    }
    DECL_SPEC int32_t Verify_A3DMiscAttributeUnitData(A3DMiscAttributeUnitData *from_csharp) {
        A3DMiscAttributeUnitData d;
        A3D_INITIALIZE_DATA( A3DMiscAttributeUnitData, d );
        return memcmp( &d, from_csharp, sizeof(A3DMiscAttributeUnitData));
    }
    DECL_SPEC int32_t Verify_A3DCopyAndAdaptBrepModelData(A3DCopyAndAdaptBrepModelData *from_csharp) {
        A3DCopyAndAdaptBrepModelData d;
        A3D_INITIALIZE_DATA( A3DCopyAndAdaptBrepModelData, d );
        return memcmp( &d, from_csharp, sizeof(A3DCopyAndAdaptBrepModelData));
    }
    DECL_SPEC int32_t Verify_A3DPhysicalPropertiesData(A3DPhysicalPropertiesData *from_csharp) {
        A3DPhysicalPropertiesData d;
        A3D_INITIALIZE_DATA( A3DPhysicalPropertiesData, d );
        return memcmp( &d, from_csharp, sizeof(A3DPhysicalPropertiesData));
    }
    DECL_SPEC int32_t Verify_A3DTopoBodyData(A3DTopoBodyData *from_csharp) {
        A3DTopoBodyData d;
        A3D_INITIALIZE_DATA( A3DTopoBodyData, d );
        return memcmp( &d, from_csharp, sizeof(A3DTopoBodyData));
    }
    DECL_SPEC int32_t Verify_A3DTopoContextData(A3DTopoContextData *from_csharp) {
        A3DTopoContextData d;
        A3D_INITIALIZE_DATA( A3DTopoContextData, d );
        return memcmp( &d, from_csharp, sizeof(A3DTopoContextData));
    }
    DECL_SPEC int32_t Verify_A3DTopoSingleWireBodyData(A3DTopoSingleWireBodyData *from_csharp) {
        A3DTopoSingleWireBodyData d;
        A3D_INITIALIZE_DATA( A3DTopoSingleWireBodyData, d );
        return memcmp( &d, from_csharp, sizeof(A3DTopoSingleWireBodyData));
    }
    DECL_SPEC int32_t Verify_A3DTopoBrepDataData(A3DTopoBrepDataData *from_csharp) {
        A3DTopoBrepDataData d;
        A3D_INITIALIZE_DATA( A3DTopoBrepDataData, d );
        return memcmp( &d, from_csharp, sizeof(A3DTopoBrepDataData));
    }
    DECL_SPEC int32_t Verify_A3DTopoConnexData(A3DTopoConnexData *from_csharp) {
        A3DTopoConnexData d;
        A3D_INITIALIZE_DATA( A3DTopoConnexData, d );
        return memcmp( &d, from_csharp, sizeof(A3DTopoConnexData));
    }
    DECL_SPEC int32_t Verify_A3DTopoShellData(A3DTopoShellData *from_csharp) {
        A3DTopoShellData d;
        A3D_INITIALIZE_DATA( A3DTopoShellData, d );
        return memcmp( &d, from_csharp, sizeof(A3DTopoShellData));
    }
    DECL_SPEC int32_t Verify_A3DTopoFaceData(A3DTopoFaceData *from_csharp) {
        A3DTopoFaceData d;
        A3D_INITIALIZE_DATA( A3DTopoFaceData, d );
        return memcmp( &d, from_csharp, sizeof(A3DTopoFaceData));
    }
    DECL_SPEC int32_t Verify_A3DTopoLoopData(A3DTopoLoopData *from_csharp) {
        A3DTopoLoopData d;
        A3D_INITIALIZE_DATA( A3DTopoLoopData, d );
        return memcmp( &d, from_csharp, sizeof(A3DTopoLoopData));
    }
    DECL_SPEC int32_t Verify_A3DTopoCoEdgeData(A3DTopoCoEdgeData *from_csharp) {
        A3DTopoCoEdgeData d;
        A3D_INITIALIZE_DATA( A3DTopoCoEdgeData, d );
        return memcmp( &d, from_csharp, sizeof(A3DTopoCoEdgeData));
    }
    DECL_SPEC int32_t Verify_A3DTopoEdgeData(A3DTopoEdgeData *from_csharp) {
        A3DTopoEdgeData d;
        A3D_INITIALIZE_DATA( A3DTopoEdgeData, d );
        return memcmp( &d, from_csharp, sizeof(A3DTopoEdgeData));
    }
    DECL_SPEC int32_t Verify_A3DTopoWireEdgeData(A3DTopoWireEdgeData *from_csharp) {
        A3DTopoWireEdgeData d;
        A3D_INITIALIZE_DATA( A3DTopoWireEdgeData, d );
        return memcmp( &d, from_csharp, sizeof(A3DTopoWireEdgeData));
    }
    DECL_SPEC int32_t Verify_A3DTopoUniqueVertexData(A3DTopoUniqueVertexData *from_csharp) {
        A3DTopoUniqueVertexData d;
        A3D_INITIALIZE_DATA( A3DTopoUniqueVertexData, d );
        return memcmp( &d, from_csharp, sizeof(A3DTopoUniqueVertexData));
    }
    DECL_SPEC int32_t Verify_A3DTopoMultipleVertexData(A3DTopoMultipleVertexData *from_csharp) {
        A3DTopoMultipleVertexData d;
        A3D_INITIALIZE_DATA( A3DTopoMultipleVertexData, d );
        return memcmp( &d, from_csharp, sizeof(A3DTopoMultipleVertexData));
    }
}
