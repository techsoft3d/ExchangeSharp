using System;
using System.Runtime.InteropServices;

namespace TS3D.Exchange.Direct
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DVector2dData
    {
        public ushort m_usStructSize;
        public double m_dX;
        public double m_dY;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DVector3dData
    {
        public ushort m_usStructSize;
        public double m_dX;
        public double m_dY;
        public double m_dZ;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DIntervalData
    {
        public ushort m_usStructSize;
        public double m_dMin;
        public double m_dMax;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DDomainData
    {
        public ushort m_usStructSize;
        public A3DVector2dData m_sMin;
        public A3DVector2dData m_sMax;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DBoundingBoxData
    {
        public ushort m_usStructSize;
        public A3DVector3dData m_sMin;
        public A3DVector3dData m_sMax;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DParameterizationData
    {
        public ushort m_usStructSize;
        public A3DIntervalData m_sInterval;
        public double m_dCoeffA;
        public double m_dCoeffB;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DUVParameterizationData
    {
        public ushort m_usStructSize;
        public A3DDomainData m_sUVDomain;
        [MarshalAs(UnmanagedType.I1)] public bool m_bSwapUV;
        public double m_dUCoeffA;
        public double m_dVCoeffA;
        public double m_dUCoeffB;
        public double m_dVCoeffB;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DTessBaseData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bIsCalculated;
        public uint m_uiCoordSize;
        public IntPtr m_pdCoords;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DTessFaceData
    {
        public ushort m_usStructSize;
        public uint m_uiStyleIndexesSize;
        public IntPtr m_puiStyleIndexes;
        public uint m_uiStartWire;
        public uint m_uiSizesWiresSize;
        public IntPtr m_puiSizesWires;
        public ushort m_usUsedEntitiesFlags;
        public uint m_uiStartTriangulated;
        public uint m_uiSizesTriangulatedSize;
        public IntPtr m_puiSizesTriangulated;
        [MarshalAs(UnmanagedType.I1)] public bool m_bIsRGBA;
        public uint m_uiRGBAVerticesSize;
        public IntPtr m_pucRGBAVertices;
        public ushort m_usBehaviour;
        public uint m_uiTextureCoordIndexesSize;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DTess3DData
    {
        public ushort m_usStructSize;
        public uint m_bHasFaces;
        public uint m_uiNormalSize;
        public IntPtr m_pdNormals;
        public uint m_uiWireIndexSize;
        public IntPtr m_puiWireIndexes;
        public uint m_uiTriangulatedIndexSize;
        public IntPtr m_puiTriangulatedIndexes;
        public uint m_uiFaceTessSize;
        public IntPtr m_psFaceTessData;
        public uint m_uiTextureCoordSize;
        public IntPtr m_pdTextureCoords;
        [MarshalAs(UnmanagedType.I1)] public bool m_bMustRecalculateNormals;
        public byte m_ucNormalsRecalculationFlags;
        public double m_dCreaseAngle;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DTess3DWireData
    {
        public ushort m_usStructSize;
        public uint m_uiSizesWiresSize;
        public IntPtr m_puiSizesWires;
        [MarshalAs(UnmanagedType.I1)] public bool m_bIsRGBA;
        [MarshalAs(UnmanagedType.I1)] public bool m_bIsSegmentColor;
        public uint m_uiRGBAVerticesSize;
        public IntPtr m_pucRGBAVertices;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DTessMarkupData
    {
        public ushort m_usStructSize;
        public uint m_uiCodesSize;
        public IntPtr m_puiCodes;
        public uint m_uiTextsSize;
        public IntPtr m_ppcTexts;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcLabel;
        public byte m_cBehaviour;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DGraphicsData
    {
        public ushort m_usStructSize;
        public uint m_uiLayerIndex;
        public uint m_uiStyleIndex;
        public ushort m_usBehaviour;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DGraphStyleData
    {
        public ushort m_usStructSize;
        public double m_dWidth;
        [MarshalAs(UnmanagedType.I1)] public bool m_bVPicture;
        public uint m_uiLinePatternIndex;
        [MarshalAs(UnmanagedType.I1)] public bool m_bMaterial;
        public uint m_uiRgbColorIndex;
        [MarshalAs(UnmanagedType.I1)] public bool m_bIsTransparencyDefined;
        public byte m_ucTransparency;
        [MarshalAs(UnmanagedType.I1)] public bool m_bSpecialCulling;
        [MarshalAs(UnmanagedType.I1)] public bool m_bFrontCulling;
        [MarshalAs(UnmanagedType.I1)] public bool m_bBackCulling;
        [MarshalAs(UnmanagedType.I1)] public bool m_bNoLight;
        public A3DERenderingMode m_eRenderingMode;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DGraphRgbColorData
    {
        public ushort m_usStructSize;
        public double m_dRed;
        public double m_dGreen;
        public double m_dBlue;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DGraphLinePatternData
    {
        public ushort m_usStructSize;
        public uint m_uiNumberOfLengths;
        public IntPtr m_pdLengths;
        public double m_dPhase;
        [MarshalAs(UnmanagedType.I1)] public bool m_bRealLength;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DGraphMaterialData
    {
        public ushort m_usStructSize;
        public uint m_uiAmbient;
        public uint m_uiDiffuse;
        public uint m_uiEmissive;
        public uint m_uiSpecular;
        public double m_dAmbientAlpha;
        public double m_dDiffuseAlpha;
        public double m_dEmissiveAlpha;
        public double m_dSpecularAlpha;
        public double m_dShininess;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DGraphPictureData
    {
        public ushort m_usStructSize;
        public A3DEPictureDataFormat m_eFormat;
        public uint m_uiSize;
        public IntPtr m_pucBinaryData;
        public uint m_uiPixelWidth;
        public uint m_uiPixelHeight;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DGraphDottingPatternData
    {
        public ushort m_usStructSize;
        public double m_dPitch;
        [MarshalAs(UnmanagedType.I1)] public bool m_bZigZag;
        public uint m_uiColorIndex;
        public uint m_uiNextPatternIndex;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DGraphHatchingPatternLineData
    {
        public ushort m_usStructSize;
        public A3DVector2dData m_sStart;
        public A3DVector2dData m_sOffset;
        public double m_dAngle;
        public uint m_uiStyleIndex;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DGraphHatchingPatternData
    {
        public ushort m_usStructSize;
        public uint m_uiSize;
        public IntPtr m_psHatchLines;
        public uint m_uiNextPatternIndex;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DGraphSolidPatternData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bMaterial;
        public uint m_uiRgbColorIndex;
        public uint m_uiNextPatternIndex;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DGraphVPicturePatternData
    {
        public ushort m_usStructSize;
        public uint m_uiNextPatternIndex;
        public IntPtr m_pMarkupTess;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DGraphCameraData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bOrthographic;
        public A3DVector3dData m_sLocation;
        public A3DVector3dData m_sLookAt;
        public A3DVector3dData m_sUp;
        public double m_dXFovy;
        public double m_dYFovy;
        public double m_dAspectRatio;
        public double m_dZNear;
        public double m_dZFar;
        public double m_dZoomFactor;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DGraphAmbientLightData
    {
        public ushort m_usStructSize;
        public uint m_uiAmbientColorIndex;
        public uint m_uiDiffuseColorIndex;
        public uint m_uiSpecularColorIndex;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DGraphPointLightData
    {
        public ushort m_usStructSize;
        public uint m_uiAmbientColorIndex;
        public uint m_uiDiffuseColorIndex;
        public uint m_uiSpecularColorIndex;
        public A3DVector3dData m_sLocation;
        public double m_dConstantAttenuation;
        public double m_dLinearAttenuation;
        public double m_dQuadraticAttenuation;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DGraphSpotLightData
    {
        public ushort m_usStructSize;
        public uint m_uiAmbientColorIndex;
        public uint m_uiDiffuseColorIndex;
        public uint m_uiSpecularColorIndex;
        public A3DVector3dData m_sDirection;
        public double m_dFallOffAngle;
        public double m_dFallOffExponent;
        public A3DVector3dData m_sLocation;
        public double m_dConstantAttenuation;
        public double m_dLinearAttenuation;
        public double m_dQuadraticAttenuation;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DGraphDirectionalLightData
    {
        public ushort m_usStructSize;
        public uint m_uiAmbientColorIndex;
        public uint m_uiDiffuseColorIndex;
        public uint m_uiSpecularColorIndex;
        public double m_dIntensity;
        public A3DVector3dData m_sDirection;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DGraphSceneDisplayParametersData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bIsActive;
        public IntPtr m_pCamera;
        public uint m_uiLightSize;
        public IntPtr m_ppLights;
        public uint m_uiPlaneSize;
        public IntPtr m_ppClippingPlanes;
        [MarshalAs(UnmanagedType.I1)] public bool m_bHasRotationCenter;
        public A3DVector3dData m_sRotationCenter;
        public uint m_uiBackgroundStyleIndex;
        public uint m_uiDefaultStyleIndex;
        public uint m_uiDefaultPerTypeIndexSize;
        public IntPtr m_puiDefaultStyleIndexesPerType;
        public IntPtr m_puiTypesOfDefaultStyleIndexes;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMiscCascadedAttributesData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bShow;
        [MarshalAs(UnmanagedType.I1)] public bool m_bRemoved;
        public ushort m_usLayer;
        public A3DGraphStyleData m_sStyle;
        public IntPtr m_pCoordinateSystem;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMiscGeneralTransformationData
    {
        public ushort m_usStructSize;
        public fixed double m_adCoeff[16];
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMiscCartesianTransformationData
    {
        public ushort m_usStructSize;
        public A3DVector3dData m_sOrigin;
        public A3DVector3dData m_sXVector;
        public A3DVector3dData m_sYVector;
        public A3DVector3dData m_sScale;
        public byte m_ucBehaviour;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMiscEntityReferenceData
    {
        public ushort m_usStructSize;
        public IntPtr m_pEntity;
        public IntPtr m_pCoordinateSystem;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMiscReferenceOnTopologyData
    {
        public ushort m_usStructSize;
        public A3DEEntityType m_eTopoItemType;
        public IntPtr m_pBrepData;
        public uint m_uiSize;
        public IntPtr m_puiAdditionalIndexes;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMiscReferenceOnTessData
    {
        public ushort m_usStructSize;
        public A3DEEntityType m_eTopoItemType;
        public IntPtr m_pPolyBrepModel;
        public uint m_uiSize;
        public IntPtr m_puiAdditionalIndexes;
        public IntPtr m_pTargetProductOccurrence;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMiscReferenceOnCsysItemData
    {
        public ushort m_usStructSize;
        public IntPtr m_pCoordinateSystem;
        public ushort m_uiIndex;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMiscPhysicMaterialData
    {
        public ushort m_usStructSize;
        public double m_dDensity;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMiscMaterialFiberData
    {
        public ushort m_usStructSize;
        public double m_dYoungModulus_X;
        public double m_dYoungModulus_Y;
        public double m_dPoissonRatio_XY;
        public double m_dShearModulus_XY;
        public double m_dShearModulus_YZ;
        public double m_dThermalExpansion_X;
        public double m_dThermalExpansion_Y;
        public double m_dTensileStressLimit_X;
        public double m_dCompressiveStressLimit_X;
        public double m_dTensileStressLimit_Y;
        public double m_dCompressiveStressLimit_Y;
        public double m_dShearStressLimit_XY;
        public double m_dShearStressLimit_YZ;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMiscMaterialHoneyCombData
    {
        public ushort m_usStructSize;
        public double m_dYoungModulus;
        public double m_dShearModulus_XZ;
        public double m_dShearModulus_YZ;
        public double m_dShearStressLimit_XZ;
        public double m_dShearStressLimit_YZ;
        public double m_dThermalExpansion;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMiscMaterialIsotropicData
    {
        public ushort m_usStructSize;
        public double m_dYoungModulus;
        public double m_dPoissonRatio;
        public double m_dShearModulus;
        public double m_dThermalExpansion;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMiscMaterialOrthotropic2DData
    {
        public ushort m_usStructSize;
        public double m_dYoungModulus_X;
        public double m_dYoungModulus_Y;
        public double m_dPoissonRatio_XY;
        public double m_dShearModulus_XY;
        public double m_dShearModulus_XZ;
        public double m_dShearModulus_YZ;
        public double m_dTensileStressLimit_X;
        public double m_dCompressiveStressLimit_X;
        public double m_dTensileStressLimit_Y;
        public double m_dCompressiveStressLimit_Y;
        public double m_dThermalExpansion_X;
        public double m_dThermalExpansion_Y;
        public double m_dTensileStrainLimit_X;
        public double m_dCompressiveStrainLimit_X;
        public double m_dTensileStrainLimit_Y;
        public double m_dCompressiveStrainLimit_Y;
        public double m_dShearStressLimit_XY;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMiscMaterialOrthotropic3DData
    {
        public ushort m_usStructSize;
        public double m_dYoungModulus_X;
        public double m_dYoungModulus_Y;
        public double m_dYoungModulus_Z;
        public double m_dPoissonRatio_XY;
        public double m_dPoissonRatio_XZ;
        public double m_dPoissonRatio_YZ;
        public double m_dShearModulus_XY;
        public double m_dShearModulus_XZ;
        public double m_dShearModulus_YZ;
        public double m_dThermalExpansion_X;
        public double m_dThermalExpansion_Y;
        public double m_dThermalExpansion_Z;
        public double m_dTensileStressLimit_X;
        public double m_dCompressiveStressLimit_X;
        public double m_dTensileStressLimit_Y;
        public double m_dCompressiveStressLimit_Y;
        public double m_dShearStressLimit_XY;
        public double m_dShearStressLimit_XZ;
        public double m_dShearStressLimit_YZ;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMiscMaterialAnisotropicData
    {
        public ushort m_usStructSize;
        public double m_dShearModulus_XX;
        public double m_dShearModulus_XY;
        public double m_dShearModulus_XZ;
        public double m_dShearModulus_YY;
        public double m_dShearModulus_YZ;
        public double m_dShearModulus_ZZ;
        public double m_dThermalExpansion_X;
        public double m_dThermalExpansion_Y;
        public double m_dThermalExpansion_Z;
        public double m_dTensileStressLimit;
        public double m_dCompressiveStressLimit;
        public double m_dShearStressLimit;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMiscMaterialPropertiesData
    {
        public ushort m_usStructSize;
        public double m_dDensity;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcMaterialName;
        public A3DMaterialPhysicType m_ePhysicType;
        private fixed byte _union[160];
        public A3DMiscMaterialFiberData m_sFiber
        {
            get
            {
                fixed( byte *p = _union )
                {
                    IntPtr ptr = new IntPtr((void*)p);
                    return Marshal.PtrToStructure<A3DMiscMaterialFiberData>(ptr);
                }
            }
        }
        public A3DMiscMaterialHoneyCombData m_sHoneyComb
        {
            get
            {
                fixed( byte *p = _union )
                {
                    IntPtr ptr = new IntPtr((void*)p);
                    return Marshal.PtrToStructure<A3DMiscMaterialHoneyCombData>(ptr);
                }
            }
        }
        public A3DMiscMaterialIsotropicData m_sIsotropic
        {
            get
            {
                fixed( byte *p = _union )
                {
                    IntPtr ptr = new IntPtr((void*)p);
                    return Marshal.PtrToStructure<A3DMiscMaterialIsotropicData>(ptr);
                }
            }
        }
        public A3DMiscMaterialOrthotropic2DData m_sOrthotropic2D
        {
            get
            {
                fixed( byte *p = _union )
                {
                    IntPtr ptr = new IntPtr((void*)p);
                    return Marshal.PtrToStructure<A3DMiscMaterialOrthotropic2DData>(ptr);
                }
            }
        }
        public A3DMiscMaterialOrthotropic3DData m_sOrthotropic3D
        {
            get
            {
                fixed( byte *p = _union )
                {
                    IntPtr ptr = new IntPtr((void*)p);
                    return Marshal.PtrToStructure<A3DMiscMaterialOrthotropic3DData>(ptr);
                }
            }
        }
        public A3DMiscMaterialAnisotropicData m_sAnisotropic
        {
            get
            {
                fixed( byte *p = _union )
                {
                    IntPtr ptr = new IntPtr((void*)p);
                    return Marshal.PtrToStructure<A3DMiscMaterialAnisotropicData>(ptr);
                }
            }
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DAsmModelFileData
    {
        public ushort m_usStructSize;
        public A3DEModellerType m_eModellerType;
        [MarshalAs(UnmanagedType.I1)] public bool m_bUnitFromCAD;
        public double m_dUnit;
        public uint m_uiPOccurrencesSize;
        public IntPtr m_ppPOccurrences;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMaterialAndVisualisationInfos
    {
        public uint m_uiPathInAssemblyTreeSize;
        public IntPtr m_ppPathInAssemblyTree;
        public IntPtr m_pMaterial;
        public IntPtr m_pTransform;
        [MarshalAs(UnmanagedType.I1)] public bool m_bIsSuppressed;
        public ushort m_usLayer;
        public ushort m_usBehaviour;
        public byte m_ucType;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DViewMaterialAndVisualisationInfos
    {
        public uint m_uiViewIndex;
        public uint m_uiMaterialAndVisualisationSetupSize;
        public IntPtr m_psMaterialAndVisualisationSetup;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DAsmProductOccurrenceData
    {
        public ushort m_usStructSize;
        public uint m_uiPOccurrencesSize;
        public IntPtr m_ppPOccurrences;
        public IntPtr m_pPart;
        public IntPtr m_pPrototype;
        public IntPtr m_pExternalData;
        public byte m_ucBehaviour;
        public IntPtr m_pLocation;
        public uint m_uiEntityReferenceSize;
        public IntPtr m_ppEntityReferences;
        public uint m_uiAnnotationsSize;
        public IntPtr m_ppAnnotations;
        public uint m_uiViewsSize;
        public IntPtr m_ppViews;
        public IntPtr m_pEntityFilter;
        public uint m_uiDisplayFilterSize;
        public IntPtr m_ppDisplayFilters;
        public uint m_uiSceneDisplayParameterSize;
        public IntPtr m_psSceneDisplayParameters;
        public A3DEProductLoadStatus m_eProductLoadStatus;
        public uint m_uiProductFlags;
        [MarshalAs(UnmanagedType.I1)] public bool m_bUnitFromCAD;
        public double m_dUnit;
        public double m_dDensityVolumeUnit;
        public double m_dDensityMassUnit;
        public A3DEModellerType m_eModellerType;
        [MarshalAs(UnmanagedType.I1)] public bool m_bInactivateAnnotations;
        public uint m_uiMaterialAndVisualisationSetupSize;
        public IntPtr m_psMaterialAndVisualisationSetup;
        public uint m_uiCameraSize;
        public IntPtr m_ppCamera;
        public uint m_uiFeatureBasedEntitiesSize;
        public IntPtr m_ppFeatureBasedEntities;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DAsmAttachmentsInfosSLW
    {
        public int m_iRiIndex;
        public int m_iConfigID;
        [MarshalAs(UnmanagedType.LPStr)] public string m_psReplacedFilePath;
        public uint m_uiPathsInAssemblyTreeSize;
        public IntPtr m_ppsPathsInAssemblyTree;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DAsmProductOccurrenceDataSLW
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.LPStr)] public string m_psNodeSlwID;
        public int m_iIndexCfg;
        [MarshalAs(UnmanagedType.LPStr)] public string m_psCfgName;
        public A3DEProductOccurrenceTypeSLW m_usType;
        public uint m_uiAttachementsSize;
        public IntPtr m_psAttachements;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DAsmProductOccurrenceDataCat
    {
        public ushort m_usStructSize;
        public A3DEProductOccurrenceTypeCat m_eCatiaFileType;
        public int m_iModelNumber;
        public uint m_uiIdWorkspace;
        public int m_iTypeWorkspace;
        [MarshalAs(UnmanagedType.LPStr)] public string m_psModelName;
        [MarshalAs(UnmanagedType.LPStr)] public string m_psUser;
        [MarshalAs(UnmanagedType.LPStr)] public string m_psDatm;
        [MarshalAs(UnmanagedType.LPStr)] public string m_psTimem;
        [MarshalAs(UnmanagedType.LPStr)] public string m_psVersion;
        [MarshalAs(UnmanagedType.LPStr)] public string m_psRelease;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DAsmProductOccurrenceDataCV5
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.LPStr)] public string m_psRootFilePath;
        public int m_iRootModificationTime;
        public int m_iRootUpdateIndex;
        public int m_iCurrentAsmProductIdentifier;
        public int m_iNotUpdatedAsmProductIdentifier;
        public fixed int m_aiCLSID[4];
        [MarshalAs(UnmanagedType.I1)] public bool m_bProductInError;
        [MarshalAs(UnmanagedType.I1)] public bool m_bHasCGMInformation;
        [MarshalAs(UnmanagedType.I1)] public bool m_bFromCATPart;
        [MarshalAs(UnmanagedType.LPStr)] public string m_psVersion;
        [MarshalAs(UnmanagedType.LPStr)] public string m_psPartNumber;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DPromotedBodyUg
    {
        public uint m_uiBaseTagOcc;
        public uint m_uiBaseTag;
        public uint m_uiPromotedBodyID;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DElementsByRefsetUg
    {
        [MarshalAs(UnmanagedType.LPStr)] public string m_psRefset;
        public uint m_uiElementsSize;
        public IntPtr m_auiElements;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DAsmProductOccurrenceDataUg
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.LPStr)] public string m_psRootFilePath;
        [MarshalAs(UnmanagedType.LPStr)] public string m_psFileName;
        [MarshalAs(UnmanagedType.LPStr)] public string m_psInstanceFileName;
        [MarshalAs(UnmanagedType.LPStr)] public string m_psRefSet;
        [MarshalAs(UnmanagedType.LPStr)] public string m_psPartUID;
        public uint m_uiInstanceTag;
        public uint m_uiPromotedBodiesSize;
        public IntPtr m_asPromotedBodies;
        public uint m_uiChildrenByRefsetsSize;
        public IntPtr m_asChildrenByRefsets;
        public uint m_uiSolidsByRefsetsSize;
        public IntPtr m_asSolidsByRefsets;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DAsmProductOccurrenceDataProe
    {
        public ushort m_usStructSize;
        public double m_dAccuracy;
        [MarshalAs(UnmanagedType.LPStr)] public string m_sPartName;
        public int m_iProEMemberType;
        public int m_iProEMemberId;
        [MarshalAs(UnmanagedType.I1)] public bool m_bXprOrXas;
        [MarshalAs(UnmanagedType.I1)] public bool m_bHasFamilyTable;
        [MarshalAs(UnmanagedType.I1)] public bool m_bHasBooleanOperation;
        [MarshalAs(UnmanagedType.I1)] public bool m_bHasFlexibleComponent;
        public IntPtr m_pDefaultExplodePosition;
        public uint m_uiExplodedProductsSize;
        public IntPtr m_ppExplodedProducts;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DAsmProductOccurrenceDataInv
    {
        public ushort m_usStructSize;
        public A3DEProductOccurrenceTypeInv m_eType;
        public fixed int m_aiCLSID[4];
        public int m_iNodeID;
        public uint m_uiOccurrenceIDsSize;
        public IntPtr m_aiOccurrenceIDs;
        public uint m_uiFlexibleOccurrenceIDsSize;
        public IntPtr m_aiFlexibleOccurrenceIDs;
        [MarshalAs(UnmanagedType.I1)] public bool m_bIsSubstituted;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DAsmProductOccurrenceDataJT
    {
        public ushort m_usStructSize;
        public ushort m_usValidDisplayFields;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DAsmLayer
    {
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcLayerName;
        public ushort m_usLayer;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DAsmPartDefinitionData
    {
        public ushort m_usStructSize;
        public A3DBoundingBoxData m_sBoundingBox;
        public uint m_uiRepItemsSize;
        public IntPtr m_ppRepItems;
        public uint m_uiAnnotationsSize;
        public IntPtr m_ppAnnotations;
        public uint m_uiViewsSize;
        public IntPtr m_ppViews;
        public uint m_uiDrawingModelsSize;
        public IntPtr m_ppDrawingModels;
        [MarshalAs(UnmanagedType.I1)] public bool m_bInactivateAnnotations;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DAsmLayerFilterItemData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bIsInclusive;
        public uint m_uiSize;
        public IntPtr m_puiLayerIndexes;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DAsmEntityFilterItemData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bIsInclusive;
        public uint m_uiSize;
        public IntPtr m_ppEntities;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DAsmFilterData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bIsActive;
        public A3DAsmLayerFilterItemData m_sLayerFilterItem;
        public A3DAsmEntityFilterItemData m_sEntityFilterItem;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DRWParamsGeneralData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bReadSolids;
        [MarshalAs(UnmanagedType.I1)] public bool m_bReadSurfaces;
        [MarshalAs(UnmanagedType.I1)] public bool m_bReadWireframes;
        [MarshalAs(UnmanagedType.I1)] public bool m_bReadPmis;
        [MarshalAs(UnmanagedType.I1)] public bool m_bReadAttributes;
        [MarshalAs(UnmanagedType.I1)] public bool m_bReadHiddenObjects;
        [MarshalAs(UnmanagedType.I1)] public bool m_bReadConstructionAndReferences;
        [MarshalAs(UnmanagedType.I1)] public bool m_bReadActiveFilter;
        public A3DEReadingMode2D3D m_eReadingMode2D3D;
        public A3DEReadGeomTessMode m_eReadGeomTessMode;
        public A3DEUnits m_eDefaultUnit;
        [MarshalAs(UnmanagedType.I1)] public bool m_bReadFeature;
        public int m_iNbMultiProcess;
        public uint m_uiSearchTextureDirectoriesSize;
        public IntPtr m_ppcSearchTextureDirectories;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DRWParamsPmiData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bAlwaysSubstituteFont;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcSubstitutionFont;
        public int m_iNumberOfDigitsAfterDot;
        public A3DEUnits m_eDefaultUnit;
        public uint m_uiProprietaryFontDirectoriesSize;
        public IntPtr m_ppcProprietaryFontDirectories;
        public A3DGraphRgbColorData m_sDefaultColor;
        [MarshalAs(UnmanagedType.I1)] public bool m_bAlwaysUseDefaultColor;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DRWParamsTessellationData
    {
        public ushort m_usStructSize;
        public A3DETessellationLevelOfDetail m_eTessellationLevelOfDetail;
        public double m_dChordHeightRatio;
        public double m_dAngleToleranceDeg;
        public double m_dMinimalTriangleAngleDeg;
        public double m_dMaxChordHeight;
        [MarshalAs(UnmanagedType.I1)] public bool m_bAccurateTessellation;
        [MarshalAs(UnmanagedType.I1)] public bool m_bAccurateTessellationWithGrid;
        public double m_dAccurateTessellationWithGridMaximumStitchLength;
        [MarshalAs(UnmanagedType.I1)] public bool m_bAccurateSurfaceCurvatures;
        [MarshalAs(UnmanagedType.I1)] public bool m_bDoNotComputeNormalsInAccurateTessellation;
        [MarshalAs(UnmanagedType.I1)] public bool m_bKeepUVPoints;
        [MarshalAs(UnmanagedType.I1)] public bool m_bUseHeightInsteadOfRatio;
        public double m_dMaximalTriangleEdgeLength;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DRWParamsSearchDirData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcPhysicalPath;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcLogicalName;
        [MarshalAs(UnmanagedType.I1)] public bool m_bRecursive;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DRWParamsAssemblyData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bUseRootDirectory;
        [MarshalAs(UnmanagedType.I1)] public bool m_bRootDirRecursive;
        public uint m_uiSearchDirectoriesSize;
        public IntPtr m_ppcSearchDirectories;
        public uint m_uiPathDefinitionsSize;
        public IntPtr m_ppcPathDefinitions;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DRWParamsMultiEntriesData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bLoadDefault;
        public uint m_uiEntriesSize;
        public IntPtr m_ppcEntries;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DRWParamsCatiaV4Data
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcRootDirLogicalName;
        [MarshalAs(UnmanagedType.I1)] public bool m_bAllowSearchInOtherLogicalNames;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DRWParamsCatiaV5Data
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bCacheActivation;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcCachePath;
        [MarshalAs(UnmanagedType.I1)] public bool m_bUseMaterialRendering;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DRWParamsUnigraphicsData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bApplyToAllLevels;
        public uint m_uiPreferredReferenceSetsSize;
        public IntPtr m_ppcPreferredReferenceSets;
        [MarshalAs(UnmanagedType.I1)] public bool m_bFitAllToUpdateViewCameras;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DRWParamsProEData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcCodePageName;
        [MarshalAs(UnmanagedType.I1)] public bool m_bDisplayTolerance;
        [MarshalAs(UnmanagedType.I1)] public bool m_bDisplaySubpartAnnotations;
        public A3DProESessionColorType m_eSessionColorType;
        public A3DProEFamilyTables m_eFamilyTables;
        [MarshalAs(UnmanagedType.I1)] public bool m_bBoolOpUseGenericIfNoTess;
        [MarshalAs(UnmanagedType.I1)] public bool m_bFlexCompUseGenericIfNoTess;
        [MarshalAs(UnmanagedType.I1)] public bool m_bHideSkeletons;
        [MarshalAs(UnmanagedType.I1)] public bool m_bReadExplodeStateAsView;
        [MarshalAs(UnmanagedType.I1)] public bool m_bDisplayVisibleDatum;
        public A3DProEReadConstructEntities m_eReadConstructEntities;
        [MarshalAs(UnmanagedType.I1)] public bool m_bComputeHomeView;
        [MarshalAs(UnmanagedType.I1)] public bool m_bHandlePMIScreenLocation;
        [MarshalAs(UnmanagedType.I1)] public bool m_bIsometricDefaultView;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DRWValidationPropertiesThresholdData
    {
        public ushort m_usStructSize;
        public double m_dGEOMPercentVolume;
        public double m_dGEOMPercentSurfaceArea;
        public double m_dGEOMPercentIndependentSurfaceArea;
        public double m_dGEOMPercentIndependentCurveLength;
        public double m_dGEOMDeviationCentroid;
        public double m_dGEOMDeviationIndependentSurfaceCentroid;
        public double m_dGEOMDeviationIndependentCurveCentroid;
        public double m_dGEOMDeviationPointSetCentroid;
        public double m_dGEOMDeviationBoundingBox;
        public double m_dPMIPercentAffectedArea;
        public double m_dPMIPercentAffectedCurveLength;
        public double m_dPMIPercentCurveLength;
        public double m_dPMIPercentSurfaceArea;
        public double m_dPMIDeviationCurveCentroid;
        public double m_dPMIDeviationSurfaceCentroid;
        public double m_dASMDeviationNotionalSolidsCentroid;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DRWParamsStepData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bPreferProductName;
        [MarshalAs(UnmanagedType.I1)] public bool m_bPreferFirstColor;
        public A3DEStepNameFromNAUO m_eNameFromNAUO;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcCodePageName;
        [MarshalAs(UnmanagedType.I1)] public bool m_bSplitSHELL_BASED_SURFACE_MODEL;
        [MarshalAs(UnmanagedType.I1)] public bool m_bHealOrientations;
        [MarshalAs(UnmanagedType.I1)] public bool m_bReadValidationProperties;
        [MarshalAs(UnmanagedType.I1)] public bool m_bComputeValidationProperties;
        [MarshalAs(UnmanagedType.I1)] public bool m_bAddResultToName;
        public A3DRWValidationPropertiesThresholdData m_sValidationPropertiesThreshold;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DRWParamsIGESData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bSewBrepModels;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DRWParamsIFCData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcCodePageName;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcXMLFilePathForAttributes;
        [MarshalAs(UnmanagedType.I1)] public bool m_bIFCOWNERHISTORYOptimized;
        [MarshalAs(UnmanagedType.I1)] public bool m_bFACETED_BREPAsOneFace;
        [MarshalAs(UnmanagedType.I1)] public bool m_bAttributesOnlyGlobalId;
        [MarshalAs(UnmanagedType.I1)] public bool m_bHideWireframes;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DRWParamsJTData
    {
        public ushort m_usStructSize;
        public A3DEJTReadTessellationLevelOfDetail m_eReadTessellationLevelOfDetail;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DRWParamsParasolidData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bKeepParsedEntities;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DRWParamsSolidworksData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bLoadAllConfigsData;
        public ushort m_usDisplayVisibleDatum;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DRWParamsInventorData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bUseTessForFile;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DRWParamsRhinoData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bForceRenderedModeColors;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DRWParamsRevitData
    {
        public ushort m_usStructSize;
        public EA3DRevitPhysicalProperties m_ePhysicalProperties;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DRWParamsSpecificLoadData
    {
        public ushort m_usStructSize;
        public A3DRWParamsCatiaV4Data m_sCatiaV4;
        public A3DRWParamsCatiaV5Data m_sCatiaV5;
        public A3DRWParamsUnigraphicsData m_sUnigraphics;
        public A3DRWParamsProEData m_sProE;
        public A3DRWParamsStepData m_sStep;
        public A3DRWParamsIGESData m_sIGES;
        public A3DRWParamsIFCData m_sIFC;
        public A3DRWParamsJTData m_sJT;
        public A3DRWParamsParasolidData m_sParasolid;
        public A3DRWParamsSolidworksData m_sSolidworks;
        public A3DRWParamsInventorData m_sInventor;
        public A3DRWParamsRhinoData m_sRhino;
        public A3DRWParamsRevitData m_sRevit;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DRWParamsIncrementalLoadData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bLoadStructureOnly;
        [MarshalAs(UnmanagedType.I1)] public bool m_bLoadNoDependencies;
        public IntPtr m_pRootProductOccurrence;
        public uint m_uiProductOccurrencesSize;
        public IntPtr m_ppProductOccurrences;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DRWParamsLoadData
    {
        public ushort m_usStructSize;
        public A3DRWParamsGeneralData m_sGeneral;
        public A3DRWParamsPmiData m_sPmi;
        public A3DRWParamsTessellationData m_sTessellation;
        public A3DRWParamsAssemblyData m_sAssembly;
        public A3DRWParamsMultiEntriesData m_sMultiEntries;
        public A3DRWParamsSpecificLoadData m_sSpecifics;
        public A3DRWParamsIncrementalLoadData m_sIncremental;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DStream3DPDFData
    {
        public ushort m_usStructSize;
        public uint m_uiStreamSize;
        [MarshalAs(UnmanagedType.LPStr)] public string m_acStream;
        [MarshalAs(UnmanagedType.I1)] public bool m_bIsPrc;
        public uint m_uiIdentifier;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DRWParamsExportPrcData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bCompressBrep;
        [MarshalAs(UnmanagedType.I1)] public bool m_bCompressTessellation;
        public A3DECompressBrepType m_eCompressBrepType;
        [MarshalAs(UnmanagedType.I1)] public bool m_bRemoveBRep;
        [MarshalAs(UnmanagedType.I1)] public bool m_bRemoveAttributes;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DRWParamsExportU3DData
    {
        public ushort m_usStructSize;
        public A3DEU3DVersion m_eU3DVersion;
        [MarshalAs(UnmanagedType.I1)] public bool m_bMeshQuality;
        public byte m_ucMeshQualityValue;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DRWParamsExportStepData
    {
        public ushort m_usStructSize;
        public A3DEStepFormat m_eStepFormat;
        [MarshalAs(UnmanagedType.I1)] public bool m_bSaveFacetedToWireframe;
        [MarshalAs(UnmanagedType.I1)] public bool m_bSaveAnalyticsToNurbs;
        [MarshalAs(UnmanagedType.I1)] public bool m_bUseShortNames;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcApplication;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcVersion;
        [MarshalAs(UnmanagedType.I1)] public bool m_bWritePMI;
        [MarshalAs(UnmanagedType.I1)] public bool m_bWriteAttributes;
        [MarshalAs(UnmanagedType.I1)] public bool m_bWriteUVCurves;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcConfig;
        [MarshalAs(UnmanagedType.I1)] public bool m_bWriteValidationProperties;
        [MarshalAs(UnmanagedType.I1)] public bool m_bWritePMIWithSemantic;
        [MarshalAs(UnmanagedType.I1)] public bool m_bWritePMIAsTessellated;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcUser;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcOrganisation;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcAuthorisation;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DRWParamsExportJTData
    {
        public ushort m_usStructSize;
        public A3DEWriteGeomTessMode m_eWriteGeomTessMode;
        [MarshalAs(UnmanagedType.I1)] public bool m_bWriteHiddenObjects;
        [MarshalAs(UnmanagedType.I1)] public bool m_bWritePMI;
        public A3DEJTVersion m_eJTVersion;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DRWParamsExportIgesData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bSaveAnalyticsToNurbs;
        [MarshalAs(UnmanagedType.I1)] public bool m_bSaveFacetedToWireframe;
        [MarshalAs(UnmanagedType.I1)] public bool m_bSaveSolidsAsFaces;
        [MarshalAs(UnmanagedType.I1)] public bool m_bWriteHiddenObjects;
        [MarshalAs(UnmanagedType.I1)] public bool m_bWriteTessellation;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcApplication;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcVersion;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DRWParamsExportStlData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bBinaryFile;
        public A3DETessellationLevelOfDetail m_eTessellationLevelOfDetail;
        public double m_dChordHeightRatio;
        public double m_dAngleToleranceDeg;
        public double m_dMinimalTriangleAngleDeg;
        public double m_dMaxChordHeight;
        [MarshalAs(UnmanagedType.I1)] public bool m_bAccurateTessellation;
        [MarshalAs(UnmanagedType.I1)] public bool m_bAccurateTessellationWithGrid;
        public double m_dAccurateTessellationWithGridMaximumStitchLength;
        [MarshalAs(UnmanagedType.I1)] public bool m_bAccurateSurfaceCurvatures;
        [MarshalAs(UnmanagedType.I1)] public bool m_bKeepCurrentTessellation;
        [MarshalAs(UnmanagedType.I1)] public bool m_bUseHeightInsteadOfRatio;
        public double m_dMaximalTriangleEdgeLength;
        public A3DEUnits m_eExportUnit;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DRWParamsExport3mfData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bKeepCurrentTessellation;
        public A3DRWParamsTessellationData m_sTessellation;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcDescription;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcCopyright;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcLicenseTerms;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DRWParamsExportXMLData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bExportMetadata;
        [MarshalAs(UnmanagedType.I1)] public bool m_bExportTransformations;
        [MarshalAs(UnmanagedType.I1)] public bool m_bExportColorMaterial;
        [MarshalAs(UnmanagedType.I1)] public bool m_bExportProductInformationByFormat;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DRWParamsExportObjData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcTextureFolder;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DRWParamsExportFbxData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bAscii;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcTextureFolder;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DSewOptionsData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bComputePreferredOpenShellOrientation;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DFaceUVPointInsideManagerData
    {
        public ushort m_usStructSize;
        public uint m_uiFaceSize;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DProjectedPointCloudData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bSuccess;
        public double m_dDist;
        public A3DVector3dData m_sPt;
        public int m_iBRepIndice;
        public int m_iFaceIndice;
        public int m_iEdgeIndice;
        public A3DVector2dData m_sUV;
        public double m_dEdgeParameter;
        [MarshalAs(UnmanagedType.I1)] public bool m_bIsInFace;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DProjectPointCloudManagerDataFromRI
    {
        public ushort m_usStructSize;
        public uint m_uRepItemSize;
        public IntPtr m_pRepItems;
        public IntPtr m_pOptPlacements;
        [MarshalAs(UnmanagedType.I1)] public bool m_bUseExactComputation;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DPlanarSectionData
    {
        public ushort m_usStructSize;
        public A3DVector3dData m_sOrigin;
        public A3DVector3dData m_sDirection;
        [MarshalAs(UnmanagedType.I1)] public bool m_bColor;
        [MarshalAs(UnmanagedType.I1)] public bool m_bCreateFaces;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DCompareInputData
    {
        public ushort m_usStructSize;
        public double m_dTol;
        public uint m_uiOldRiBrepModelsSize;
        public IntPtr m_ppOldRiBrepModels;
        public IntPtr m_pOldRiBrepModelPlacements;
        public uint m_uiNewRiBrepModelsSize;
        public IntPtr m_ppNewRiBrepModels;
        public IntPtr m_pNewRiBrepModelPlacements;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DCompareOutputData
    {
        public ushort m_usStructSize;
        public uint m_uiOldFaceSize;
        public IntPtr m_pOldFace;
        public IntPtr m_pOldFaceMatch;
        public uint m_uiNewFaceSize;
        public IntPtr m_pNewFace;
        public IntPtr m_pNewFaceMatch;
        public IntPtr m_pResultRiSet;
        public IntPtr m_pResultAsmModeFile;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMultiPlanarSectionData
    {
        public ushort m_usStructSize;
        public uint m_uiPointSize;
        public IntPtr m_pPoints;
        public A3DVector3dData m_sExtrudeDirection;
        public A3DVector3dData m_sProfileNormal;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DHLRViewPlaneData
    {
        public ushort m_usStructSize;
        public fixed double m_adOrigin[3];
        public fixed double m_adAxis1[3];
        public fixed double m_adAxis2[3];
        [MarshalAs(UnmanagedType.I1)] public bool m_bUseClipBox;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DHLRCurveData
    {
        public ushort m_usStructSize;
        public IntPtr m_pProjectedPolyLine;
        public IntPtr m_psTopoEdge;
        public IntPtr m_psTopoFirstFace;
        public IntPtr m_psTopoSecondFace;
        [MarshalAs(UnmanagedType.I1)] public bool m_bFirstFaceIsSection;
        [MarshalAs(UnmanagedType.I1)] public bool m_bSecondFaceIsSection;
        public byte m_cType;
        [MarshalAs(UnmanagedType.I1)] public bool m_bIsHidden;
        [MarshalAs(UnmanagedType.I1)] public bool m_bIsEdge;
        [MarshalAs(UnmanagedType.I1)] public bool m_bIsSection;
        [MarshalAs(UnmanagedType.I1)] public bool m_bIsSilhouette;
        [MarshalAs(UnmanagedType.I1)] public bool m_bIsTanEdge;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DHLRSectionFaceData
    {
        public ushort m_usStructSize;
        public uint m_uiNbLoop;
        public IntPtr m_puiLoopSize;
        public IntPtr m_puiCurveIndex;
        public IntPtr m_pbCurveOrientation;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DHLRRepresentationItemData
    {
        public ushort m_usStructSize;
        public IntPtr m_pRepItem;
        public fixed double m_adMatrix[16];
        public uint m_uiNumberHLRCurves;
        public IntPtr m_pppHLRCurves;
        public uint m_uiNumberSectionFace;
        public IntPtr m_pHLRSectionFaces;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DHLROptionsData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bTangentEdgeDetect;
        public double m_dTangentEdgeAngle;
        [MarshalAs(UnmanagedType.I1)] public bool m_bRemoveHidden;
        [MarshalAs(UnmanagedType.I1)] public bool m_bRemoveTangentEdge;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DTransfoRepresentationItemData
    {
        public ushort m_usStructSize;
        public IntPtr m_pRepItem;
        public IntPtr m_pOptPlacement;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DCollisionGroupData
    {
        public ushort m_usStructSize;
        public uint m_uRepItemSize;
        public IntPtr m_apRepItems;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DCollisionParameterData
    {
        public ushort m_usStructSize;
        public double m_dSafetyDistance;
        public double m_dContactLimit;
        public double m_dTessellationTolerance;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DCollisionResultData
    {
        public ushort m_usStructSize;
        public uint m_iRepItemIndex1;
        public uint m_iRepItemIndex2;
        public A3DCollisionType m_eStatus;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMkpLeaderData
    {
        public ushort m_usStructSize;
        public IntPtr m_pLinkedItem;
        public IntPtr m_pTessellation;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMkpAnnotationItemData
    {
        public ushort m_usStructSize;
        public IntPtr m_pMarkup;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMkpAnnotationSetData
    {
        public ushort m_usStructSize;
        public uint m_uiAnnotationsSize;
        public IntPtr m_ppAnnotations;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMkpAnnotationReferenceData
    {
        public ushort m_usStructSize;
        public uint m_uiLinkedItemsSize;
        public IntPtr m_ppLinkedItems;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMkpViewData
    {
        public ushort m_usStructSize;
        public uint m_uiAnnotationsSize;
        public IntPtr m_ppAnnotations;
        public IntPtr m_pPlane;
        public IntPtr m_pSceneDisplayParameters;
        [MarshalAs(UnmanagedType.I1)] public bool m_bIsAnnotationView;
        [MarshalAs(UnmanagedType.I1)] public bool m_bIsDefaultView;
        public uint m_uiLinkedItemsSize;
        public IntPtr m_ppLinkedItems;
        public uint m_uiDisplayFilterSize;
        public IntPtr m_ppDisplayFilters;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMkpViewFlagsData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bIsCameraSet;
        [MarshalAs(UnmanagedType.I1)] public bool m_bIsPMIFilteringSet;
        [MarshalAs(UnmanagedType.I1)] public bool m_bIsGeomFilteringSet;
        [MarshalAs(UnmanagedType.I1)] public bool m_bIsCrossSectionSet;
        [MarshalAs(UnmanagedType.I1)] public bool m_bIsExplosionSet;
        [MarshalAs(UnmanagedType.I1)] public bool m_bIsCombineState;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMiscMarkupLinkedItemData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bMarkupShowControl;
        [MarshalAs(UnmanagedType.I1)] public bool m_bMarkupDeleteControl;
        [MarshalAs(UnmanagedType.I1)] public bool m_bLeaderShowControl;
        [MarshalAs(UnmanagedType.I1)] public bool m_bLeaderDeleteControl;
        public IntPtr m_pTargetProductOccurrence;
        public IntPtr m_pReference;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMkpMarkupData
    {
        public ushort m_usStructSize;
        public A3DEMarkupType m_eType;
        public A3DEMarkupSubType m_eSubType;
        public uint m_uiLeadersSize;
        public IntPtr m_ppLeaders;
        public uint m_uiLinkedItemsSize;
        public IntPtr m_ppLinkedItems;
        public IntPtr m_pTessellation;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMkpRTFFieldData
    {
        public ushort m_usStructSize;
        public uint m_usGetFieldIndex;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcText;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcFamilyName;
        public A3DEMarkupSymbol m_eSymbol;
        public fixed int m_aRGB[3];
        public float m_fHeight;
        public byte m_cAttributes;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DFontKeyData
    {
        public ushort m_usStructSize;
        public int m_iFontFamilyIndex;
        public int m_iFontStyleIndex;
        public int m_iFontSizeIndex;
        public byte m_cAttributes;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DFontData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcFamilyName;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcFontFilePath;
        public A3DECharSet m_eCharset;
        public uint m_uiSize;
        public byte m_cAttributes;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DGraphTextureTransformationData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bTextureFlipS;
        [MarshalAs(UnmanagedType.I1)] public bool m_bTextureFlipT;
        public fixed double m_dMatrix[16];
        [MarshalAs(UnmanagedType.I1)] public bool m_bIs2D;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DGraphTextureDefinitionData
    {
        public ushort m_usStructSize;
        public uint m_uiPictureIndex;
        public byte m_ucTextureDimension;
        public A3DETextureMappingType m_eMappingType;
        public A3DETextureMappingOperator m_eMappingOperator;
        public IntPtr m_pOperatorTransfo;
        public uint m_uiMappingAttributes;
        public uint m_uiMappingAttributesIntensitySize;
        public IntPtr m_pdMappingAttributesIntensity;
        public uint m_uiMappingAttributesComponentsSize;
        public IntPtr m_pucMappingAttributesComponents;
        public A3DETextureFunction m_eTextureFunction;
        public double m_dRed;
        public double m_dGreen;
        public double m_dBlue;
        public double m_dAlpha;
        public A3DETextureBlendParameter m_eBlend_src_RGB;
        public A3DETextureBlendParameter m_eBlend_dst_RGB;
        public A3DETextureBlendParameter m_eBlend_src_Alpha;
        public A3DETextureBlendParameter m_eBlend_dst_Alpha;
        public byte m_ucTextureApplyingMode;
        public A3DETextureAlphaTest m_eTextureAlphaTest;
        public double m_dAlphaTestReference;
        public A3DETextureWrappingMode m_eTextureWrappingModeS;
        public A3DETextureWrappingMode m_eTextureWrappingModeT;
        public IntPtr m_pTextureTransfo;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DGraphTextureApplicationData
    {
        public ushort m_usStructSize;
        public uint m_uiMaterialIndex;
        public uint m_uiTextureDefinitionIndex;
        public int m_iUVCoordinatesIndex;
        public uint m_uiNextTextureApplicationIndex;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DDrawCallbacksData
    {
        public ushort m_usStructSize;
        public IntPtr m_pfuncPushMatrix;
        public IntPtr m_pfuncPopMatrix;
        public IntPtr m_pfuncMultMatrix;
        public IntPtr m_pfuncBegin;
        public IntPtr m_pfuncEnd;
        public IntPtr m_pfuncSetTessellationPoints;
        public IntPtr m_pfuncTriangle;
        public IntPtr m_pfuncTriangleFan;
        public IntPtr m_pfuncTriangleStripe;
        public IntPtr m_pfuncTriangleOneNormal;
        public IntPtr m_pfuncTriangleFanOneNormal;
        public IntPtr m_pfuncTriangleStripeOneNormal;
        public IntPtr m_pfuncTriangleTextured;
        public IntPtr m_pfuncTriangleFanTextured;
        public IntPtr m_pfuncTriangleStripeTextured;
        public IntPtr m_pfuncTriangleOneNormalTextured;
        public IntPtr m_pfuncTriangleFanOneNormalTextured;
        public IntPtr m_pfuncTriangleStripeOneNormalTextured;
        public IntPtr m_pfuncMaterial;
        public IntPtr m_pfuncGetDrawContext;
        public IntPtr m_pfuncMarkupTriangle;
        public IntPtr m_pfuncUnProject;
        public IntPtr m_pfuncBeginFrameDraw;
        public IntPtr m_pfuncEndFrameDraw;
        public IntPtr m_pfuncBeginFixedSize;
        public IntPtr m_pfuncEndFixedSize;
        public IntPtr m_pfuncCylinder;
        public IntPtr m_pfuncPolygon;
        public IntPtr m_pfuncBeginLineWidth;
        public IntPtr m_pfuncEndLineWidth;
        public IntPtr m_pfuncPoint;
        public IntPtr m_pfuncFont;
        public IntPtr m_pfuncBeginLineStipple;
        public IntPtr m_pfuncEndLineStipple;
        public IntPtr m_pfuncSymbol;
        public IntPtr m_pfuncPolyLine;
        public IntPtr m_pfuncText;
        public IntPtr m_pfuncPattern;
        public IntPtr m_pfuncPicture;
        public IntPtr m_pfuncBeginMaterial;
        public IntPtr m_pfuncEndMaterial;
        public IntPtr m_pfuncColor;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DDrawingModelData
    {
        public ushort m_usStructSize;
        public uint m_uiDrwSheetsSize;
        public IntPtr m_ppDrwSheets;
        public uint m_uiActiveSheet;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DDrawingSheetFormatData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcName;
        public A3DVector2dData m_sSize;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DDrawingSheetData
    {
        public ushort m_usStructSize;
        public IntPtr m_pFormat;
        public A3DVector2dData m_sSize;
        public A3DVector2dData m_sRefPoint;
        public double m_dScale;
        [MarshalAs(UnmanagedType.I1)] public bool m_bDrawFrame;
        public ushort m_usStyle;
        public ushort m_usBackgroundStyle;
        public IntPtr m_pBackgroundBlocks;
        public uint m_uiDrwBlocksSize;
        public IntPtr m_ppDrwBlocks;
        public uint m_uiDrwViewsSize;
        public IntPtr m_ppDrwViews;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DDrawingClipFrameData
    {
        public ushort m_usStructSize;
        public ushort m_uiStyle;
        [MarshalAs(UnmanagedType.I1)] public bool m_bDrawBound;
        [MarshalAs(UnmanagedType.I1)] public bool m_bClipBound;
        public A3DEDrawingClipFrameType m_eType;
        public A3DDomainData m_sRectangularBox;
        public IntPtr m_pCurve;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DDrawingViewData
    {
        public ushort m_usStructSize;
        public A3DEDrawingViewType m_eType;
        public IntPtr m_pClipFrame;
        public A3DVector2dData m_sOriginOnSheet;
        public A3DVector2dData m_sOffsetLocation;
        public double m_dScale;
        public double m_dAngle;
        public uint m_uiSrcFilesNamesSize;
        public IntPtr m_ppcSrcFilesNames;
        public IntPtr m_pLocalBlocks;
        public uint m_uiDrwBlocksSize;
        public IntPtr m_ppDrwBlocks;
        public IntPtr m_pBaseView;
        public IntPtr m_pFilter;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DDrawingBlockBasicData
    {
        public ushort m_usStructSize;
        public uint m_uiDrwEntitiesSize;
        public IntPtr m_ppDrwEntities;
        public uint m_uiMarkupsSize;
        public IntPtr m_ppMarkups;
        public uint m_uiDrwBlocksSize;
        public IntPtr m_ppDrwBlocks;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DDrawingBlockOperatorData
    {
        public ushort m_usStructSize;
        public A3DEDrawingOperatorType m_eType;
        public IntPtr m_pViewResult;
        public uint m_uiDrwEntitiesSize;
        public IntPtr m_ppDrwEntities;
        public uint m_uiMarkupsSize;
        public IntPtr m_ppMarkups;
        public uint m_uiDrwBlocksSize;
        public IntPtr m_ppDrwBlocks;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DDrawingCurveData
    {
        public ushort m_usStructSize;
        public IntPtr m_pCurve;
        public A3DIntervalData m_sTrimInterval;
        public IntPtr m_pPlane;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DDrawingFilledAreaData
    {
        public ushort m_usStructSize;
        public A3DEDrawingFilledAreaMode m_eMode;
        public uint m_uiPatternIndex;
        [MarshalAs(UnmanagedType.I1)] public bool m_bIgnoreViewTransfo;
        public uint m_uiBoundaryCurvesSize;
        public IntPtr m_ppBoundaryCurves;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DDrawingPictureData
    {
        public ushort m_usStructSize;
        public uint m_uiPictureIndex;
        public A3DVector2dData m_sPosition;
        public A3DVector2dData m_sSize;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DDrawingVerticesData
    {
        public ushort m_usStructSize;
        public uint m_uiPointsSize;
        public IntPtr m_pPoints;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DThumbnailData
    {
        public ushort m_usStructSize;
        public IntPtr m_pcBuffer;
        public A3DEPictureDataFormat m_eFormat;
        public uint m_iLength;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DFileInformationData
    {
        public ushort m_usStructSize;
        public A3DEModellerType m_eModellerType;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcModelName;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcSoftwareVersion;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcAuthor;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcOrganization;
        public int m_iTimeStamp;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DFileContextData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcFileName;
        public uint m_uiNbContexts;
        public IntPtr m_apcContexts;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DRWParamsExportParasolidData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bSaveSolidsAsFaces;
        [MarshalAs(UnmanagedType.I1)] public bool m_bWriteTessellation;
        [MarshalAs(UnmanagedType.I1)] public bool m_bWriteBlankedEntities;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcApplication;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcVersion;
        [MarshalAs(UnmanagedType.I1)] public bool m_bBStrictAssemblyStructure;
        [MarshalAs(UnmanagedType.I1)] public bool m_bExplodeMultiBodies;
        [MarshalAs(UnmanagedType.I1)] public bool m_bMakePointsWithCoordinateSystems;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DChainedBuffer
    {
        public IntPtr m_pNext;
        public int m_sSize;
        public IntPtr m_pBuffer;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DRWParamsTranslateToPkPartsData
    {
        public ushort m_usStructSize;
        public A3DETranslateToPkPartsHealing m_eHealing;
        public A3DETranslateToPkPartsAccurate m_eComputeAccurateEdges;
        [MarshalAs(UnmanagedType.I1)] public bool m_bDisjoinIfFaceFaceError;
        [MarshalAs(UnmanagedType.I1)] public bool m_bSew;
        public double m_dSewingTolerance;
        public A3DETranslateToPkPartsSimplifyGeometry m_eSimplifyGeometry;
        public A3DETranslateToPkPartsMergeEntities m_eMergeEntities;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcPSBodyShopPath;
        public IntPtr m_pMapper;
        [MarshalAs(UnmanagedType.I1)] public bool m_bUseColour2Attribute;
        [MarshalAs(UnmanagedType.I1)] public bool m_bUseUNameAttribute;
        [MarshalAs(UnmanagedType.I1)] public bool m_bUseLayerAttribute;
        public uint m_uiNbProc;
        [MarshalAs(UnmanagedType.I1)] public bool m_bExportNormalsWithTessellation;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DRWParamsExportAcisData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bSaveAsMillimeter;
        [MarshalAs(UnmanagedType.I1)] public bool m_bSaveAsBinary;
        [MarshalAs(UnmanagedType.I1)] public bool m_bForceSurfaceDuplication;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DRiRepresentationItemData
    {
        public ushort m_usStructSize;
        public IntPtr m_pTessBase;
        public IntPtr m_pCoordinateSystem;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DRiSetData
    {
        public ushort m_usStructSize;
        public uint m_uiRepItemsSize;
        public IntPtr m_ppRepItems;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DRiPointSetData
    {
        public ushort m_usStructSize;
        public uint m_uiSize;
        public IntPtr m_pPts;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DRiDirectionData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bHasOrigin;
        public A3DVector3dData m_sOrigin;
        public A3DVector3dData m_sDirection;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DRiCoordinateSystemData
    {
        public ushort m_usStructSize;
        public IntPtr m_pTransformation;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DRiCurveData
    {
        public ushort m_usStructSize;
        public IntPtr m_pBody;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DRiPlaneData
    {
        public ushort m_usStructSize;
        public IntPtr m_pBrepData;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DRiBrepModelData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bSolid;
        public IntPtr m_pBrepData;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DRiPolyBrepModelData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bIsClosed;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DRiPolyWireData
    {
        public ushort m_usStructSize;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DFRMFeatureTreeData
    {
        public ushort m_usStructSize;
        public uint m_uiParametersSize;
        public IntPtr m_ppsParameters;
        public uint m_uiIntermediateGeometriesSize;
        public IntPtr m_ppIntermediateGeometries;
        public uint m_uiInternalGeometriesSize;
        public IntPtr m_ppInternalGeometries;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DFRMParameterData
    {
        public ushort m_usStructSize;
        public uint m_uiFeatureSize;
        public IntPtr m_ppFeatures;
        public EA3DFRMParameterType m_eType;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DFRMFeatureTypeData
    {
        public ushort m_usStructSize;
        public EA3DFRMFamily m_eFamily;
        public uint m_uiType;
        public EA3DFRMStatus m_eStatus;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DFRMStringData
    {
        public ushort m_usStructSize;
        public uint m_uiValuesSize;
        public IntPtr m_ppcValues;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DFRMDoubleData
    {
        public ushort m_usStructSize;
        public uint m_uiValuesSize;
        public IntPtr m_pdValues;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DFRMIntegerData
    {
        public ushort m_usStructSize;
        public uint m_uiValuesSize;
        public IntPtr m_piValues;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DFRMFeatureLinkedItemData
    {
        public ushort m_usStructSize;
        public EA3DFRMLinkType m_eType;
        public IntPtr m_pTargetProductOccurrence;
        public IntPtr m_pReference;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DFRMFeatureData
    {
        public ushort m_usStructSize;
        public A3DFRMFeatureTypeData m_sType;
        public uint m_uiParametersSize;
        public IntPtr m_ppParameters;
        public EA3DFRMDataType m_eDataType;
        public uint m_uiConnectionSize;
        public IntPtr m_ppConnections;
        [MarshalAs(UnmanagedType.I1)] public bool m_bIsNode;
        [MarshalAs(UnmanagedType.I1)] public bool m_bIsSubTree;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DFRMFeatureGeomEntitiesData
    {
        public ushort m_usStructSize;
        public uint m_uiGeomEntitiesSize;
        public IntPtr m_ppGeomEntities;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DCrvNurbsData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bIs2D;
        [MarshalAs(UnmanagedType.I1)] public bool m_bRational;
        public uint m_uiDegree;
        public uint m_uiCtrlSize;
        public IntPtr m_pCtrlPts;
        public uint m_uiWeightSize;
        public IntPtr m_pdWeights;
        public uint m_uiKnotSize;
        public IntPtr m_pdKnots;
        public A3DEKnotType m_eKnotType;
        public A3DEBSplineCurveForm m_eCurveForm;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DCrvLineData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bIs2D;
        public A3DMiscCartesianTransformationData m_sTrsf;
        public A3DParameterizationData m_sParam;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DCrvCircleData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bIs2D;
        public A3DMiscCartesianTransformationData m_sTrsf;
        public A3DParameterizationData m_sParam;
        public double m_dRadius;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DCrvEllipseData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bIs2D;
        public A3DMiscCartesianTransformationData m_sTrsf;
        public A3DParameterizationData m_sParam;
        public double m_dXRadius;
        public double m_dYRadius;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DCrvParabolaData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bIs2D;
        public A3DMiscCartesianTransformationData m_sTrsf;
        public A3DParameterizationData m_sParam;
        public double m_dFocal;
        public byte m_cParamType;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DCrvHyperbolaData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bIs2D;
        public A3DMiscCartesianTransformationData m_sTrsf;
        public A3DParameterizationData m_sParam;
        public double m_dSemiAxis;
        public double m_dSemiImageAxis;
        public byte m_cParamType;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DCrvPolyLineData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bIs2D;
        public A3DMiscCartesianTransformationData m_sTrsf;
        public A3DParameterizationData m_sParam;
        public uint m_uiSize;
        public IntPtr m_pPts;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DCrvCompositeData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bIs2D;
        public A3DMiscCartesianTransformationData m_sTrsf;
        public A3DParameterizationData m_sParam;
        public uint m_uiSize;
        public IntPtr m_ppCurves;
        public IntPtr m_pbSenses;
        [MarshalAs(UnmanagedType.I1)] public bool m_bClosed;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DCrvEquationData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bIs2D;
        public A3DMiscCartesianTransformationData m_sTrsf;
        public A3DParameterizationData m_sParam;
        public A3DIntervalData m_sMaxInterval;
        public IntPtr m_pFunctionX;
        public IntPtr m_pFunctionY;
        public IntPtr m_pFunctionZ;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DCrvTransformData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bIs2D;
        public A3DMiscCartesianTransformationData m_sTrsf;
        public A3DParameterizationData m_sParam;
        public IntPtr m_pTransfo;
        public IntPtr m_pBasisCrv;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DCrvOnSurfData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bIs2D;
        public A3DMiscCartesianTransformationData m_sTrsf;
        public A3DParameterizationData m_sParam;
        public IntPtr m_pUVCurve;
        public IntPtr m_pSurface;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DCrvOffsetData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bIs2D;
        public A3DMiscCartesianTransformationData m_sTrsf;
        public A3DParameterizationData m_sParam;
        public IntPtr m_pBasisCrv;
        public double m_dOffset;
        public A3DVector3dData m_sVector;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DCrvHelixPitchCstData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bTrigonometricOrientation;
        public A3DVector3dData m_sStartPoint;
        public A3DVector3dData m_sOrigin;
        public A3DVector3dData m_sDirection;
        public double m_dPitch;
        public double m_dRadiusEvolution;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DCrvHelixPitchVarData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bTrigonometricOrientation;
        public A3DVector3dData m_sStartPoint;
        public A3DVector3dData m_sUnitZ;
        public A3DVector3dData m_sUnitU;
        public IntPtr m_psRadiusLaw;
        public IntPtr m_psZLaw;
        public IntPtr m_psThetaLaw;
        public double m_dRatioU;
        public double m_dRatioV;
        public double m_dRatioZ;
        public double m_dTheta0;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DCrvHelixData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bIs2D;
        public A3DMiscCartesianTransformationData m_sTrsf;
        public A3DParameterizationData m_sParam;
        public A3DEHelixType m_eType;
        public A3DCrvHelixPitchCstData m_sCstHelixData;
        public A3DCrvHelixPitchVarData m_sVarHelixData;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DCrossingPointsCrvIntersectionData
    {
        public ushort m_usStructSize;
        public A3DVector3dData m_sPosition;
        public A3DVector2dData m_sUVPosition1;
        public A3DVector2dData m_sUVPosition2;
        public A3DVector3dData m_sTangent;
        public double m_dParameter;
        public double m_dScale;
        public byte m_cFlags;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DCrvIntersectionData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bIs2D;
        public A3DMiscCartesianTransformationData m_sTrsf;
        public A3DParameterizationData m_sParam;
        public IntPtr m_pSurface1;
        public IntPtr m_pSurface2;
        [MarshalAs(UnmanagedType.I1)] public bool m_bSensSurface1;
        [MarshalAs(UnmanagedType.I1)] public bool m_bSensSurface2;
        [MarshalAs(UnmanagedType.I1)] public bool m_bSens;
        public uint m_uiCrossingPtsSize;
        public IntPtr m_pCrossingPts;
        public A3DVector3dData m_sStartLimitPoint;
        public A3DEIntersectionLimitType m_sStartLimitType;
        public A3DVector3dData m_sEndLimitPoint;
        public A3DEIntersectionLimitType m_sEndLimitType;
        public double m_dChordalError;
        public double m_dAngularError;
        [MarshalAs(UnmanagedType.I1)] public bool m_bParameterizationDefinitionRespected;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DCrvBlend02BoundaryData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bIs2D;
        public A3DMiscCartesianTransformationData m_sTrsf;
        public A3DParameterizationData m_sParam;
        public IntPtr m_pBlend;
        public uint m_uiBlend;
        public uint m_uiCrossingPtsSize;
        public IntPtr m_pCrossingPts;
        public double m_dChordalError;
        public double m_dAngularError;
        public IntPtr m_pBoundingSurface;
        [MarshalAs(UnmanagedType.I1)] public bool m_bBoundingSurfaceSens;
        [MarshalAs(UnmanagedType.I1)] public bool m_bIntersectionOrder;
        [MarshalAs(UnmanagedType.I1)] public bool m_bIntersectionCurveSens;
        public double m_dBaseParameter;
        public double m_dBaseScale;
        public A3DVector3dData m_sStartLimitPoint;
        public A3DEIntersectionLimitType m_sStartLimitType;
        public A3DVector3dData m_sEndLimitPoint;
        public A3DEIntersectionLimitType m_sEndLimitType;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DSurfNurbsData
    {
        public ushort m_usStructSize;
        public A3DEKnotType m_eKnotType;
        public A3DEBSplineSurfaceForm m_eSurfaceForm;
        public uint m_uiUDegree;
        public uint m_uiVDegree;
        public uint m_uiUKnotSize;
        public uint m_uiVKnotSize;
        public uint m_uiUCtrlSize;
        public uint m_uiVCtrlSize;
        public IntPtr m_pdUKnots;
        public IntPtr m_pdVKnots;
        public IntPtr m_pdWeights;
        public IntPtr m_pCtrlPts;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DSurfSphereData
    {
        public ushort m_usStructSize;
        public A3DMiscCartesianTransformationData m_sTrsf;
        public A3DUVParameterizationData m_sParam;
        public double m_dRadius;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DSurfCylinderData
    {
        public ushort m_usStructSize;
        public A3DMiscCartesianTransformationData m_sTrsf;
        public A3DUVParameterizationData m_sParam;
        public double m_dRadius;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DSurfTorusData
    {
        public ushort m_usStructSize;
        public A3DMiscCartesianTransformationData m_sTrsf;
        public A3DUVParameterizationData m_sParam;
        public double m_dMajorRadius;
        public double m_dMinorRadius;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DSurfRevolutionData
    {
        public ushort m_usStructSize;
        public A3DMiscCartesianTransformationData m_sTrsf;
        public A3DUVParameterizationData m_sParam;
        public IntPtr m_pCurve;
        public A3DVector3dData m_sOrigin;
        public A3DVector3dData m_sDirection;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DSurfExtrusionData
    {
        public ushort m_usStructSize;
        public A3DMiscCartesianTransformationData m_sTrsf;
        public A3DUVParameterizationData m_sParam;
        public IntPtr m_pCurve;
        public A3DVector3dData m_sDirection;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DSurfOffsetData
    {
        public ushort m_usStructSize;
        public A3DMiscCartesianTransformationData m_sTrsf;
        public A3DUVParameterizationData m_sParam;
        public IntPtr m_pBasisSurf;
        public double m_dOffset;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DSurfPlaneData
    {
        public ushort m_usStructSize;
        public A3DMiscCartesianTransformationData m_sTrsf;
        public A3DUVParameterizationData m_sParam;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DSurfBlend01Data
    {
        public ushort m_usStructSize;
        public A3DMiscCartesianTransformationData m_sTrsf;
        public A3DUVParameterizationData m_sParam;
        public IntPtr m_pPntCurve;
        public IntPtr m_pCtrCurve;
        public IntPtr m_pTanCurve;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DSurfBlend02Data
    {
        public ushort m_usStructSize;
        public A3DMiscCartesianTransformationData m_sTrsf;
        public A3DUVParameterizationData m_sParam;
        public IntPtr m_pSurface0;
        public IntPtr m_pCurve0;
        public IntPtr m_pSurface1;
        public IntPtr m_pCurve1;
        public IntPtr m_pCenterCurve;
        [MarshalAs(UnmanagedType.I1)] public bool m_bCenterCurveSens;
        [MarshalAs(UnmanagedType.I1)] public bool m_bBound0Sens;
        [MarshalAs(UnmanagedType.I1)] public bool m_bBound1Sens;
        public double m_dRadius0;
        public double m_dRadius1;
        public byte m_cParameterizationType;
        public IntPtr m_pCliffSurface0;
        public IntPtr m_pCliffSurface1;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DSurfBlend03Data
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool Struct_not_implemented_____A3DSurfBlend03Data;
        public A3DMiscCartesianTransformationData m_sTrsf;
        public A3DUVParameterizationData m_sParam;
        public uint m_uiNbOfElement;
        public IntPtr m_pdParameters;
        public IntPtr m_piMultiplicities;
        public IntPtr m_pPositions;
        public IntPtr m_pdRail2AnglesV;
        public IntPtr m_pTangent;
        public IntPtr m_pdRail2DerivativesV;
        public IntPtr m_pSecondDerivatives;
        public IntPtr m_pdRail2SecondDerivatives;
        public double m_dRail2ParameterV;
        public double m_dTrimVMin;
        public double m_dTrimVMax;
        public fixed int m_piReserveInt[6];
        public byte m_cReservedChar0;
        public byte m_cReservedChar1;
        public byte m_cReservedChar2;
        public uint m_uiReservedDoublesSize;
        public IntPtr m_pdReservedDoubles;
        public double m_dInitialMaxV;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DSurfConeData
    {
        public ushort m_usStructSize;
        public A3DMiscCartesianTransformationData m_sTrsf;
        public A3DUVParameterizationData m_sParam;
        public double m_dRadius;
        public double m_dSemiAngle;
        [MarshalAs(UnmanagedType.I1)] public bool m_bInsideOut;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DSurfCylindricalData
    {
        public ushort m_usStructSize;
        public A3DMiscCartesianTransformationData m_sTrsf;
        public A3DUVParameterizationData m_sParam;
        public IntPtr m_pBasisSurf;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DSurfRuledData
    {
        public ushort m_usStructSize;
        public A3DMiscCartesianTransformationData m_sTrsf;
        public A3DUVParameterizationData m_sParam;
        public IntPtr m_pFirstCurve;
        public IntPtr m_pSecondCurve;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DSurfPipeData
    {
        public ushort m_usStructSize;
        public A3DMiscCartesianTransformationData m_sTrsf;
        public A3DUVParameterizationData m_sParam;
        public double m_dRadius;
        public IntPtr m_pSpine;
        public IntPtr m_pOrigine;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DSurfTransformData
    {
        public ushort m_usStructSize;
        public A3DMiscCartesianTransformationData m_sTrsf;
        public A3DUVParameterizationData m_sParam;
        public IntPtr m_pTransfo;
        public IntPtr m_pBasisSurf;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DSurfFromCurvesData
    {
        public ushort m_usStructSize;
        public A3DMiscCartesianTransformationData m_sTrsf;
        public A3DUVParameterizationData m_sParam;
        public A3DVector3dData m_sOrigin;
        public IntPtr m_pFirstCurve;
        public IntPtr m_pSecondCurve;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DGlobalData
    {
        public ushort m_usStructSize;
        public uint m_uiColorsSize;
        public uint m_uiPicturesSize;
        public uint m_uiTextureDefinitionsSize;
        public uint m_uiMaterialsSize;
        public uint m_uiLinePatternsSize;
        public uint m_uiStylesSize;
        public uint m_uiFillPatternsSize;
        public uint m_uiUnitsSize;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMDPosition3DData
    {
        public ushort m_usStructSize;
        public A3DVector3dData m_sPosition;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMDPosition2DData
    {
        public ushort m_usStructSize;
        public A3DVector2dData m_sPosition;
        public double m_dOffset;
        public IntPtr m_pPlane;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMDPositionReferenceData
    {
        public ushort m_usStructSize;
        public IntPtr m_psLinkedItem;
        public EA3DMDAnchorPointType m_eAttachType;
        public A3DVector2dData m_sOffsetToReference;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMDLeaderSymbolData
    {
        public ushort m_usStructSize;
        public A3DMDLeaderSymbolType m_eHeadSymbol;
        public double m_dLength;
        public double m_dAdditionalParameter;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMDMarkupLeaderStubData
    {
        public ushort m_usStructSize;
        public uint m_uiValuesAndAnchorTypesSize;
        public IntPtr m_pdValues;
        public IntPtr m_piAnchorTypes;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMDLeaderDefinitionData
    {
        public ushort m_usStructSize;
        public uint m_uiNumberOfPathLeaderPositions;
        public IntPtr m_ppsPathLeaderPositions;
        public uint m_uiNbGapsElements;
        public IntPtr m_pdGapList;
        public IntPtr m_pHeadSymbol;
        public A3DMDLeaderSymbolType m_eTailSymbol;
        public IntPtr m_pNextLeader;
        public uint m_uAnchorFrame;
        public uint m_uAnchorPoint;
        public IntPtr m_pStub;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMDTextPropertiesData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcFont;
        public double m_dAngle;
        [MarshalAs(UnmanagedType.I1)] public bool m_bSlant;
        public ushort m_ucThickness;
        public ushort m_ucSize;
        public ushort m_usLineStyle;
        public double m_dCharHeight;
        public double m_dCharSpacing;
        public double m_dCharWidth;
        public ushort m_iCharFixedRatioMode;
        public EA3DMDTextPropertiesScore m_eGlobalTextScoring;
        public EA3DMDTextPropertiesFormat m_eFormat;
        public EA3DMDTextPropertiesJustification m_eJustification;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMarkupDefinitionData
    {
        public ushort m_usStructSize;
        public IntPtr m_pAttach;
        public EA3DMDAnchorPointType m_eAttachType;
        public double m_dAttachAngle;
        [MarshalAs(UnmanagedType.I1)] public bool m_bDisplayParallelOnScreen;
        [MarshalAs(UnmanagedType.I1)] public bool m_bZoomable;
        [MarshalAs(UnmanagedType.I1)] public bool m_bLeaderNotIntersectWithBox;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMDDimensionValueFormatData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcName;
        public int m_iType;
        public int m_iUnit;
        public double m_dGlobFact;
        public int m_iNulFac_1;
        public int m_iNulFac_2;
        public int m_iExise;
        public int m_iSep1000;
        public double m_dFact_1;
        public double m_dFact_2;
        public double m_dFact_3;
        public double m_dValPos_1;
        public double m_dValPos_2;
        public double m_dValPos_3;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcSepar_1;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcSepar_2;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcSepar_3;
        public double m_dSepScl_1;
        public double m_dSepScl_2;
        public double m_dSepScl_3;
        public double m_dSepPos_1;
        public double m_dSepPos_2;
        public double m_dSepPos_3;
        public double m_dRestY;
        public int m_iFinZer;
        public int m_iSepNum;
        public int m_iTypFrac;
        public int m_iSepDen;
        public double m_dOperY;
        public int m_iNulOther;
        public double m_dResScl;
        public int m_iFact;
        public double m_dRestX;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMDDimensionSimpleToleranceFormatData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcName;
        public int m_iType;
        public int m_iSepar_1;
        public int m_iSepar_2;
        public double m_dSymbolH;
        public int m_iSepTo_1;
        public int m_iSepTo_2;
        public int m_iSepTo_3;
        public int m_iTrailing;
        public int m_iFractLine;
        public int m_iPtOnValue;
        public int m_iAnchorPt;
        public double m_dIntX;
        public double m_dIntY;
        public double m_dExtX;
        public double m_dExtY;
        public int m_iMergeSame;
        public int m_iShowNull;
        public double m_dScale;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMDDimensionCombinedToleranceFormatData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcName;
        public int m_iType;
        public IntPtr m_pToleranceFormat1;
        public double m_dExtX1;
        public double m_dExtY1;
        public int m_iAnchorPt1;
        public int m_iPtOnValue1;
        public int m_iSepar_1;
        public IntPtr m_pToleranceFormat2;
        public double m_dExtX2;
        public double m_dExtY2;
        public int m_iAnchorPt2;
        public int m_iPtOnValue2;
        public int m_iSepar_2;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMDDimensionValueData
    {
        public ushort m_usStructSize;
        public int m_iType;
        [MarshalAs(UnmanagedType.I1)] public bool m_bFormat;
        public double m_dAccuracy;
        public double m_dToleranceAccuracy;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcFakeValue;
        public double m_dTolNumSup;
        public double m_dTolNumInf;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcTolTxtSup;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcTolTxtInf;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcBeforeText;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcAfterText;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcAboveText;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcBelowText;
        public ushort m_usLastSeparDefinedNum;
        public IntPtr m_pDimValueFormat;
        public IntPtr m_pToleranceFormat;
        public int m_iOption;
        public double m_dDeltaForMinMax;
        public IntPtr m_pChamferDimSecondValue;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMDDimensionSecondPartData
    {
        public ushort m_usStructSize;
        public EA3DMDDimensionOrientation m_eOrientation;
        public double m_dAngle;
        public double m_dOffSet;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMDDimensionForeshortenedData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bTextPosition;
        [MarshalAs(UnmanagedType.I1)] public bool m_bOrientation;
        public double m_dAngle;
        public float m_fRatio;
        public ushort m_usPointScale;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMDDimensionLineSymbolData
    {
        public ushort m_usStructSize;
        public EA3DMDDimensionSymbolShape m_eShape;
        public uint m_iLineColor;
        public float m_fThickness;
        public float m_fArrowLength;
        public float m_fArrowAngle;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMDDimensionLineData
    {
        public ushort m_usStructSize;
        public IntPtr m_pSymbol1;
        public IntPtr m_pSymbol2;
        public IntPtr m_pLeaderSymbol;
        public EA3DMDDimensionLineGraphicalRepresentation m_eGraphRepresentation;
        public IntPtr m_pSecondPart;
        public ushort m_usStyle;
        public float m_fThickness;
        public ushort m_usReversal;
        public IntPtr m_psForeshortened;
        public double m_dLeaderAngle;
        public EA3DMDDimensionLineExtensionType m_eExtension;
        public IntPtr m_pExplicitCurve;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMDDimensionFunnelData
    {
        public ushort m_usStructSize;
        public ushort m_usIndex;
        [MarshalAs(UnmanagedType.I1)] public bool m_bMode;
        public double m_dAngle;
        public double m_dHeight;
        public double m_dWidth;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMDDimensionExtremityData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bShow;
        public double m_dBlanking;
        public double m_dOverrun;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMDDimensionExtentionLineData
    {
        public ushort m_usStructSize;
        public IntPtr m_pFunnel;
        public A3DMDDimensionExtremityData m_sExtremity1;
        public A3DMDDimensionExtremityData m_sExtremity2;
        public double m_dLineSlant;
        public ushort m_usStyle;
        public float m_fThickness;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMarkupDimensionData
    {
        public ushort m_usStructSize;
        public EA3DMDDimensionType m_eType;
        public IntPtr m_pMainValue;
        public IntPtr m_pDualValue;
        public EA3DMDDimensionDualDisplay m_eDualDisplay;
        public double m_dValue;
        public EA3DMDDimensionSymbolType m_eSymbol;
        public EA3DMDDimensionSymbolType m_eAdditionnalSymbol;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcSuffixe;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcPrefixe;
        public IntPtr m_pExtentionLine;
        public IntPtr m_pLine;
        public EA3DMDDimensionOrientation m_eOrientation;
        public A3DVector3dData m_sOffSet;
        public ushort m_usPosition;
        public EA3DMDDimensionScore m_eScore;
        public ushort m_usScore;
        public ushort m_usScoreGroup;
        public EA3DMDDimensionFrame m_eFrame;
        public ushort m_usFrame;
        public ushort m_usFrameGroup;
        public IntPtr m_pTextProperties;
        public double m_dChamferDimSecondValue;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMarkupRoughnessData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcField1;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcField2;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcField3;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcField4;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcField5;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcField6;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcField7;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcField8;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcRoughMode;
        public EA3DMDRoughnessType m_eRoughType;
        public EA3DMDRoughnessMode m_eRoughMode;
        public EA3DMDRoughnessContactArea m_eRoughContactArea;
        public IntPtr m_pTextProperties;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMarkupBalloonData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcUpText;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcDownText;
        public EA3DMDBalloonShape m_eBalloonShape;
        public double m_dBallownSize;
        public IntPtr m_psTextPosition;
        public uint m_uiFileLinksSize;
        public IntPtr m_ppFileLinks;
        public IntPtr m_pTextProperties;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMarkupFastenerData
    {
        public ushort m_usStructSize;
        public double m_dDiameter1;
        public double m_dDepth1;
        public double m_dDiameter2;
        public double m_dDepth2;
        public double m_dDiameter3;
        public double m_dDepth3;
        public double m_dDiameter4;
        public double m_dDepth4;
        [MarshalAs(UnmanagedType.LPStr)] public string m_sType;
        [MarshalAs(UnmanagedType.LPStr)] public string m_sTypeId;
        [MarshalAs(UnmanagedType.LPStr)] public string m_sSubtypeId;
        public uint m_uiNoteTextsSize;
        public IntPtr m_ppNoteTextsNotes;
        public ushort m_iDecimalPlaces;
        public A3DVector3dData m_sAxisVector;
        public A3DVector3dData m_sIndexVector;
        public A3DVector3dData m_sOptionalVector;
        public uint m_uiCoordinateEntitiesNotesSize;
        public IntPtr m_ppCoordinateEntitiesNotes;
        [MarshalAs(UnmanagedType.LPStr)] public string m_sStandard;
        public IntPtr m_pTextProperties;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMarkupLocatorData
    {
        public ushort m_usStructSize;
        public EA3DLocatorSymbol m_eSymbol;
        public EA3DLocatorType m_eType;
        public EA3DLocatorSubType m_eSubType;
        public EA3DLocatorCoordinatePlane m_eCoordinatePlane;
        public EA3DLocatorChangeLevel m_eChangeLevel;
        public uint m_iDecimalPlaces;
        [MarshalAs(UnmanagedType.LPStr)] public string m_sNoteFont;
        [MarshalAs(UnmanagedType.LPStr)] public string m_sNote;
        [MarshalAs(UnmanagedType.LPStr)] public string m_sPartNumberFont;
        [MarshalAs(UnmanagedType.LPStr)] public string m_sPartNumber;
        public uint m_uiCoordinateEntitiesNotesSize;
        public IntPtr m_sCoordinateEntitiesNotesFont;
        public IntPtr m_sCoordinateEntitiesNotes;
        public A3DVector3dData m_sHotSpot;
        public A3DVector3dData m_sPunchDirection;
        public A3DVector3dData m_sPinDirection;
        public A3DVector3dData m_sNormalDirection;
        public uint m_iUnit;
        public double m_dAccuracy;
        public ushort m_ucSubscripts;
        public IntPtr m_pTextProperties;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMarkupMeasurementPointData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.LPStr)] public string m_sLevel;
        public A3DVector3dData m_sLocation;
        public A3DVector3dData m_sMeasurementVector;
        public A3DVector3dData m_sCoordinationVector;
        public A3DVector3dData m_sNormalVector;
        public uint m_uiCoordinateEntitiesNotesSize;
        public IntPtr m_sCoordinateEntitiesNotesFont;
        public IntPtr m_sCoordinateEntitiesNotes;
        public EA3DMDMarkupDisplayType m_eDisplayType;
        public IntPtr m_pTextProperties;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMDTextPositionData
    {
        public ushort m_usStructSize;
        public A3DVector3dData m_sPosition;
        public A3DVector3dData m_sBaseVector;
        public A3DVector3dData m_sUpVector;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMarkupTextData
    {
        public ushort m_usStructSize;
        public uint m_uiLinesSize;
        public IntPtr m_ppLines;
        public uint m_uiFileLinksSize;
        public IntPtr m_ppFileLinks;
        public double m_dWrappingWidth;
        public EA3DMarkupFrameType m_eFrameType;
        public EA3DLeaderAlignementType m_eLeaderAlignementType;
        public IntPtr m_pTextProperties;
        public IntPtr m_psTextPosition;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMarkupCoordinateData
    {
        public ushort m_usStructSize;
        public double m_dLitDimensionedX;
        public double m_dLitDimensionedY;
        public double m_dLitDimensionedZ;
        [MarshalAs(UnmanagedType.I1)] public bool m_bType3D;
        public IntPtr m_psTextPosition;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMarkupRichTextData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcRichText;
        public uint m_uLength;
        public uint m_uiFileLinksSize;
        public IntPtr m_ppFileLinks;
        public double m_dWrappingWidth;
        public EA3DMarkupFrameType m_eFrameType;
        public EA3DLeaderAlignementType m_eLeaderAlignementType;
        public IntPtr m_psTextPosition;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMarkupDatumData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcUpText;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcDownText;
        [MarshalAs(UnmanagedType.I1)] public bool m_bTarget;
        [MarshalAs(UnmanagedType.I1)] public bool m_bDiameter;
        [MarshalAs(UnmanagedType.I1)] public bool m_bIndividual;
        public IntPtr m_pTextProperties;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcAboveText;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcBelowText;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcBeforeText;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcAfterText;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMDFCFDraftingRowData
    {
        public ushort m_usStructSize;
        public EA3DGDTType m_eType;
        public uint m_uiNumberOfTextsInBoxes;
        public IntPtr m_ppcTextsInBoxes;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMDFCValueData
    {
        public ushort m_usStructSize;
        public double m_dValue;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcValue;
        [MarshalAs(UnmanagedType.I1)] public bool m_bIsValue;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMDFCTolerancePerUnitData
    {
        public ushort m_usStructSize;
        public double m_dUnitLengthOrAreaFirstValue;
        public IntPtr m_pdUnitAreaSecondLength;
        public IntPtr m_psRefinementZone;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMDFCProjectedZoneData
    {
        public ushort m_usStructSize;
        public A3DMDFCValueData m_sLength;
        public IntPtr m_pdPosition;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMDFCFToleranceValueData
    {
        public ushort m_usStructSize;
        public A3DMDFCValueData m_sValue;
        public IntPtr m_psTolerancePerUnit;
        public IntPtr m_psProjectedZone;
        public IntPtr m_psProfileTolerance;
        public IntPtr m_psMaximumBonus;
        public A3DMDGDTValueType m_eValueType;
        public EA3DMDGDTModifierType m_eModifier;
        [MarshalAs(UnmanagedType.I1)] public bool m_bFreeState;
        [MarshalAs(UnmanagedType.I1)] public bool m_bStatistical;
        public IntPtr m_psNext;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMDFCFRowDatumData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcDatum;
        public EA3DMDGDTModifierType m_eModifier;
        public IntPtr m_pNext;
        public IntPtr m_pLinkedItem;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMDFCFDrawingRowData
    {
        public ushort m_usStructSize;
        public EA3DGDTType m_eType;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcValue;
        public IntPtr m_psSemanticValue;
        public IntPtr m_psPrimaryRef;
        public IntPtr m_psSecondaryRef;
        public IntPtr m_psTertiaryRef;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMDFCFIndicatorData
    {
        public ushort m_usStructSize;
        public EA3DFCFIndicatorType m_eType;
        public EA3DFCFIndicatorSymbol m_eSymbol;
        public IntPtr m_pDatum;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMDFeatureControlFrameData
    {
        public ushort m_usStructSize;
        public uint m_uiNumberOfRows;
        public IntPtr m_ppRows;
        public uint m_uiNumberOfIndicators;
        public IntPtr m_ppIndicators;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMDToleranceSizeValueData
    {
        public ushort m_usStructSize;
        public EA3DMDDimensionType m_eType;
        public A3DMDDimensionValueData m_sMainValue;
        public IntPtr m_pDualValue;
        public double m_dValue;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcSeparator;
        public EA3DMDDimensionSymbolType m_eSymbol;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMDToleranceSizeData
    {
        public ushort m_usStructSize;
        public uint m_uiNumberOfSizeValues;
        public IntPtr m_ppTolSizeValue;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMarkupGDTData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcAboveText;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcBelowText;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcBeforeText;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcAfterText;
        public uint m_uiNumberOfMarkupTolerances;
        public IntPtr m_ppsMarkupTolerances;
        public IntPtr m_pTextProperties;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMarkupSpotWeldingData
    {
        public ushort m_usStructSize;
        public EA3DMDSpotWeldType m_eType;
        public EA3DMDSpotWeldThickness m_eThickness;
        [MarshalAs(UnmanagedType.I1)] public bool m_bIsCritical;
        public double m_dDiameter;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcJointId;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcGroupId;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcProcess;
        public uint m_uiCoordinateEntitiesNotesSize;
        public IntPtr m_ppCoordinateEntitiesNotes;
        public A3DVector3dData m_sApproachVector;
        public A3DVector3dData m_sClampingVector;
        public A3DVector3dData m_sNormalVector;
        public IntPtr m_pTextProperties;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMarkupLineWeldingData
    {
        public ushort m_usStructSize;
        public EA3DMDLineWeldingType m_eArrowSideType;
        public EA3DMDLineWeldingSupplSymbolType m_eArrowSideSupplType;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcArrowSideValue;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcArrowSideLongitudinalValue;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcArrowSideStaggeredValue;
        public EA3DMDLineWeldingFinishSymbol m_eArrowSideFinishSymbol;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcArrowSideAngle;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcArrowSideNumRootDepth;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcArrowSideSize;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcArrowSidePitch;
        public EA3DMDLineWeldingType m_eOtherSideType;
        public EA3DMDLineWeldingSupplSymbolType m_eOtherSideSupplType;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcOtherSideValue;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcOtherSideLongitudinalValue;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcOtherSideStaggeredValue;
        public EA3DMDLineWeldingFinishSymbol m_eOtherSideFinishSymbol;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcOtherSideAngle;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcOtherSideNumRootDepth;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcOtherSideSize;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcOtherSidePitch;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcStandard;
        public uint m_uiNumberOfProcesses;
        public uint m_uiNumberOfCoordinate;
        public IntPtr m_ppcProcess;
        public uint m_uiCoordinateEntitiesNotesSize;
        public IntPtr m_ppCoordinateEntitiesNotes;
        public uint m_uiProcessNotesSize;
        public IntPtr m_ppProcessNotes;
        public IntPtr m_pTextProperties;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMathFct1DPolynomData
    {
        public ushort m_usStructSize;
        public uint m_uiSize;
        public IntPtr m_pdCoeffs;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMathFct1DTrigonometricData
    {
        public ushort m_usStructSize;
        public double m_dAmplitude;
        public double m_dPhase;
        public double m_dFreq;
        public double m_dDCOffset;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMathFct1DFractionData
    {
        public ushort m_usStructSize;
        public IntPtr m_pP;
        public IntPtr m_pQ;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMathFct1DArctanCosData
    {
        public ushort m_usStructSize;
        public double m_dA;
        public double m_dB;
        public double m_dC;
        public double m_dD;
        public double m_dE;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMathFct1DCombinationData
    {
        public ushort m_usStructSize;
        public uint m_uiSize;
        public IntPtr m_ppFunctions;
        public IntPtr m_pdCoeffs;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMathFct3DLinearData
    {
        public ushort m_usStructSize;
        public fixed double m_adMatrix[9];
        public fixed double m_adVector[3];
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMathFct3DNonLinearData
    {
        public ushort m_usStructSize;
        public IntPtr m_pLeftLinear;
        public IntPtr m_pRightLinear;
        public double m_d2;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DRootBaseData
    {
        public ushort m_usStructSize;
        public uint m_uiSize;
        public IntPtr m_ppAttributes;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcName;
        public uint m_uiPersistentId;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcPersistentId;
        public uint m_uiNonPersistentId;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DRootBaseWithGraphicsData
    {
        public ushort m_usStructSize;
        public IntPtr m_pGraphics;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMiscSingleAttributeData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bTitleIsInt;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcTitle;
        public A3DEModellerAttributeType m_eType;
        public IntPtr m_pcData;
        public ushort m_usUnit;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMiscAttributeData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bTitleIsInt;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcTitle;
        public uint m_uiSize;
        public IntPtr m_asSingleAttributesData;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMiscAttributeBasicUnitData
    {
        public ushort m_usStructSize;
        public A3DEBasicUnit m_eUnit;
        public int m_iExponent;
        public double m_dFactor;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DMiscAttributeUnitData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.LPStr)] public string m_pcName;
        public uint m_uiBasicUnitSize;
        public IntPtr m_ppBasicUnits;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DCopyAndAdaptBrepModelData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bUseSameParam;
        public double m_dTol;
        [MarshalAs(UnmanagedType.I1)] public bool m_bDeleteCrossingUV;
        [MarshalAs(UnmanagedType.I1)] public bool m_bSplitFaces;
        [MarshalAs(UnmanagedType.I1)] public bool m_bSplitClosedFaces;
        [MarshalAs(UnmanagedType.I1)] public bool m_bForceComputeUV;
        [MarshalAs(UnmanagedType.I1)] public bool m_bAllowUVCrossingSeams;
        [MarshalAs(UnmanagedType.I1)] public bool m_bForceCompute3D;
        public uint m_uiAcceptableSurfacesSize;
        public IntPtr m_puiAcceptableSurfaces;
        public uint m_uiAcceptableCurvesSize;
        public IntPtr m_puiAcceptableCurves;
        [MarshalAs(UnmanagedType.I1)] public bool m_bContinueOnError;
        [MarshalAs(UnmanagedType.I1)] public bool m_bClampTolerantUVCurvesInsideUVDomain;
        [MarshalAs(UnmanagedType.I1)] public bool m_bForceDuplicateGeometries;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DCopyAndAdaptBrepModelErrorData
    {
        public IntPtr m_pEntity;
        public uint m_uiNbError;
        public IntPtr m_paiErrors;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DTopoItemOwner
    {
        public IntPtr m_pTopoItem;
        public IntPtr m_pNext;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DPhysicalPropertiesData
    {
        public ushort m_usStructSize;
        public A3DVector3dData m_sGravityCenter;
        public double m_dSurface;
        [MarshalAs(UnmanagedType.I1)] public bool m_bVolumeComputed;
        public double m_dVolume;
        public A3DVector3dData m_sSurfacicGravityCenter;
        public fixed double m_adAreaMatrixOfInertia[9];
        public fixed double m_adVolumeMatrixOfInertia[9];
        [MarshalAs(UnmanagedType.I1)] public bool m_bUseGeometryOnRiBRep;
        public double m_dAccuracyLevel;
        [MarshalAs(UnmanagedType.I1)] public bool m_bIncludeHiddenRIs;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DTopoBodyData
    {
        public ushort m_usStructSize;
        public byte m_ucBehaviour;
        public IntPtr m_pContext;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DTopoContextData
    {
        public ushort m_usStructSize;
        public byte m_ucBehaviour;
        public double m_dGranularity;
        public double m_dTolerance;
        [MarshalAs(UnmanagedType.I1)] public bool m_bHaveSmallestFaceThickness;
        public double m_dSmallestThickness;
        [MarshalAs(UnmanagedType.I1)] public bool m_bHaveScale;
        public double m_dScale;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DTopoSingleWireBodyData
    {
        public ushort m_usStructSize;
        public IntPtr m_pWireEdge;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DTopoBrepDataData
    {
        public ushort m_usStructSize;
        public uint m_uiConnexSize;
        public IntPtr m_ppConnexes;
        public A3DBoundingBoxData m_sBoundingBox;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DTopoConnexData
    {
        public ushort m_usStructSize;
        public uint m_uiShellSize;
        public IntPtr m_ppShells;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DTopoShellData
    {
        public ushort m_usStructSize;
        [MarshalAs(UnmanagedType.I1)] public bool m_bClosed;
        public uint m_uiFaceSize;
        public IntPtr m_ppFaces;
        public IntPtr m_pucOrientationWithShell;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DTopoFaceData
    {
        public ushort m_usStructSize;
        public IntPtr m_pSurface;
        [MarshalAs(UnmanagedType.I1)] public bool m_bHasTrimDomain;
        public A3DDomainData m_sSurfaceDomain;
        public uint m_uiLoopSize;
        public IntPtr m_ppLoops;
        public uint m_uiOuterLoopIndex;
        public double m_dTolerance;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DTopoLoopData
    {
        public ushort m_usStructSize;
        public byte m_ucOrientationWithSurface;
        public uint m_uiCoEdgeSize;
        public IntPtr m_ppCoEdges;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DTopoCoEdgeData
    {
        public ushort m_usStructSize;
        public byte m_ucOrientationWithLoop;
        public byte m_ucOrientationUVWithLoop;
        public IntPtr m_pEdge;
        public IntPtr m_pUVCurve;
        public IntPtr m_pNeighbor;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DTopoEdgeData
    {
        public ushort m_usStructSize;
        public IntPtr m_pStartVertex;
        public IntPtr m_pEndVertex;
        public IntPtr m_p3dCurve;
        [MarshalAs(UnmanagedType.I1)] public bool m_bHasTrimDomain;
        public A3DIntervalData m_sInterval;
        public double m_dTolerance;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DTopoWireEdgeData
    {
        public ushort m_usStructSize;
        public IntPtr m_p3dCurve;
        [MarshalAs(UnmanagedType.I1)] public bool m_bHasTrimDomain;
        public A3DIntervalData m_sInterval;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DTopoUniqueVertexData
    {
        public ushort m_usStructSize;
        public double m_dTolerance;
        public A3DVector3dData m_sPoint;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct A3DTopoMultipleVertexData
    {
        public ushort m_usStructSize;
        public uint m_uiSize;
        public IntPtr m_pPts;
    }

}

