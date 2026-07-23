using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public static class HGShaderIDs // TypeDefIndex: 38169
	{
		// Fields
		public static readonly int _CB0; // 0x00
		public static readonly int _UnityInstancing_ECSPerDraw; // 0x04
		public static readonly int _Output0; // 0x08
		public static readonly int _Output1; // 0x0C
		public static readonly int _Output2; // 0x10
		public static readonly int _Output3; // 0x14
		public static readonly int _Input0; // 0x18
		public static readonly int _Input1; // 0x1C
		public static readonly int _Input2; // 0x20
		public static readonly int _Input3; // 0x24
		public static readonly int _Param0; // 0x28
		public static readonly int _Param1; // 0x2C
		public static readonly int _Param2; // 0x30
		public static readonly int _Param3; // 0x34
		public static readonly int _RTSize; // 0x38
		public static readonly int _TextureSize; // 0x3C
		public static readonly int _TerrainDeformResultTex; // 0x40
		public static readonly int _TerrainDeformDensityTex; // 0x44
		public static readonly int _TerrainDeformConstDataBuffer; // 0x48
		public static readonly int _TerrainDeformSplatData; // 0x4C
		public static readonly int _TerrainDeformSplatCtrlAtlas; // 0x50
		public static readonly int _TerrainDeformSplatIndex; // 0x54
		public static readonly int _TerrainDeformHeightmapAtlas; // 0x58
		public static readonly int _TerrainDeformHolemapAtlas; // 0x5C
		public static readonly int _TerrainDeformNormalmapAtlas; // 0x60
		public static readonly int _TerrainDeformTintColorAtlas; // 0x64
		public static readonly int _TerrainDeformAlbedoAtlas; // 0x68
		public static readonly int _TerrainDeformWetnessAtlas; // 0x6C
		public static readonly int _TerrainDeformSplatDiffuseArray; // 0x70
		public static readonly int _TerrainDeformSplatNormalROArray; // 0x74
		public static readonly int _TerrainDeformDepthTex; // 0x78
		public static readonly int _TerrainGroundDistanceTex; // 0x7C
		public static readonly int _TerrainDeformHistoryFillRateTex; // 0x80
		public static readonly int _TerrainDeformCurFillRateTex; // 0x84
		public static readonly int _TerrainDeformComputeResultTex; // 0x88
		public static readonly int _TerrainDeformDensityMip4Tex; // 0x8C
		public static readonly int _TerrainGroundLayerBaseRT; // 0x90
		public static readonly int _TerrainGroundLayerNormalRT; // 0x94
		public static readonly int _TerrainGroundLayerWetRT; // 0x98
		public static readonly int _TerrainGroundLayerHeightRT; // 0x9C
		public static readonly int _RWTerrainGroundLayerBaseRT; // 0xA0
		public static readonly int _RWTerrainGroundLayerNormalRT; // 0xA4
		public static readonly int _RWTerrainGroundLayerWetRT; // 0xA8
		public static readonly int _RWTerrainGroundLayerHeightRT; // 0xAC
		public static readonly int _TerrainGroundLayerConstants; // 0xB0
		public static readonly int _TerrainSplatLayerDeformConstants; // 0xB4
		public static readonly int _PerlinNoiseTex; // 0xB8
		public static readonly int _SnowDetailNormalTex; // 0xBC
		public static readonly int ShadowData; // 0xC0
		public static readonly int ShadowVertexBuffer; // 0xC4
		public static readonly int _CSMShadowmapTex; // 0xC8
		public static readonly int _CharacterShadowmapTex; // 0xCC
		public static readonly int _PunctualShadowmapTexArray; // 0xD0
		public static readonly int _CSMShadowRampTex; // 0xD4
		public static readonly int _CloudShadowTex; // 0xD8
		public static readonly int _LowResDirectionalShadow; // 0xDC
		public static readonly int _ScreenSpaceShadowMask; // 0xE0
		public static readonly int _HDPLSScreenSpaceShadowMask; // 0xE4
		public static readonly int _HDPLSTex; // 0xE8
		public static readonly int HDPunctualLightCharacterShadowData; // 0xEC
		public static readonly int _ShadowpassVP; // 0xF0
		public static readonly int _ASMIndirectTex; // 0xF4
		public static readonly int _ASMShadowmapTex; // 0xF8
		public static readonly int _CachedShadowmapAtlas; // 0xFC
		public static readonly int _PunctualLightShadowTexV2; // 0x100
		public static readonly int LightCookieCB; // 0x104
		public static readonly int _LightCookie; // 0x108
		public static readonly int _LightDataBuffer; // 0x10C
		public static readonly int _VolumetricFogLightMask; // 0x110
		public static readonly int _LightBinningConstants; // 0x114
		public static readonly int _GPULightBinningConstants; // 0x118
		public static readonly int _BinningBuffer; // 0x11C
		public static readonly int _GlobalBinningBuffer; // 0x120
		public static readonly int _DrawTileArgsBuffer; // 0x124
		public static readonly int _DrawTileArgsBufferNextFrame; // 0x128
		public static readonly int _TileInstanceIndicesBuffer; // 0x12C
		public static readonly int _PunctualLights; // 0x130
		public static readonly int _PunctualLightCount; // 0x134
		public static readonly int _NearPlaneParams; // 0x138
		public static readonly int _NearPlaneDist; // 0x13C
		public static readonly int _ZBinSlice; // 0x140
		public static readonly int _NumZBinSlices; // 0x144
		public static readonly int _OutLightBinningXYMasks; // 0x148
		public static readonly int _OutLightBinningZMasks; // 0x14C
		public static readonly int _PerLightIndex; // 0x150
		public static readonly int _TileSize; // 0x154
		public static readonly int _NumTiles; // 0x158
		public static readonly int _NumTilesX; // 0x15C
		public static readonly int _NumTilesY; // 0x160
		public static readonly int _StencilMask; // 0x164
		public static readonly int _StencilRef; // 0x168
		public static readonly int _StencilCmp; // 0x16C
		public static readonly int _InputDepth; // 0x170
		public static readonly int _ClearColor; // 0x174
		public static readonly int _SrcBlend; // 0x178
		public static readonly int _DstBlend; // 0x17C
		public static readonly int _MultiscatteringLUT; // 0x180
		public static readonly int _DecalWorldToObject; // 0x184
		public static readonly int _DecalPackedData; // 0x188
		public static readonly int _DrawOrder; // 0x18C
		public static readonly int _WorldSpaceCameraPos; // 0x190
		public static readonly int _PrevCamPosRWS; // 0x194
		public static readonly int _ViewMatrix; // 0x198
		public static readonly int _CameraViewMatrix; // 0x19C
		public static readonly int _InvViewMatrix; // 0x1A0
		public static readonly int _ProjMatrix; // 0x1A4
		public static readonly int _InvProjMatrix; // 0x1A8
		public static readonly int _NonJitteredViewProjMatrix; // 0x1AC
		public static readonly int _ViewProjMatrix; // 0x1B0
		public static readonly int _CameraViewProjMatrix; // 0x1B4
		public static readonly int _InvViewProjMatrix; // 0x1B8
		public static readonly int _ZBufferParams; // 0x1BC
		public static readonly int _ProjectionParams; // 0x1C0
		public static readonly int unity_OrthoParams; // 0x1C4
		public static readonly int _InvProjParam; // 0x1C8
		public static readonly int _ScreenSize; // 0x1CC
		public static readonly int _HalfScreenSize; // 0x1D0
		public static readonly int _ScreenParams; // 0x1D4
		public static readonly int _PrevNonJitteredViewProjMatrix; // 0x1D8
		public static readonly int _PrevNonJitteredInvViewProjMatrix; // 0x1DC
		public static readonly int _FrustumPlanes; // 0x1E0
		public static readonly int _PreviousSceneColorTexture; // 0x1E4
		public static readonly int _SceneColorTexture; // 0x1E8
		public static readonly int _SceneDepthTexture; // 0x1EC
		public static readonly int _LowSceneDepthTexture; // 0x1F0
		public static readonly int _LowResColorTexture; // 0x1F4
		public static readonly int _LowResMVTexture; // 0x1F8
		public static readonly int _DepthTextureWithWater; // 0x1FC
		public static readonly int _UIColorTexture; // 0x200
		public static readonly int _ReflectionProbeTextureArray; // 0x204
		public static readonly int _IndirectAmbientOcclusionTexture; // 0x208
		public static readonly int _CharMaxCubemap; // 0x20C
		public static readonly int _CharacterEnvColorTexture; // 0x210
		public static readonly int _CharacterRainEffectTex; // 0x214
		public static readonly int _CharacterRainStreakTex; // 0x218
		public static readonly int _CharacterRainFaceDripTex; // 0x21C
		public static readonly int _CharacterRainFaceDropletTex; // 0x220
		public static readonly int _CharacterSnowEffectTex; // 0x224
		public static readonly int _DotDitherTexture; // 0x228
		public static readonly int[] _GBufferTexture; // 0x230
		public static readonly int _CurrPyramidTexture; // 0x238
		public static readonly int _CurrPyramidTexture0; // 0x23C
		public static readonly int _CurrPyramidTexture1; // 0x240
		public static readonly int _CurrPyramidTexture2; // 0x244
		public static readonly int _CurrPyramidTexture3; // 0x248
		public static readonly int _CurrPyramidTexture4; // 0x24C
		public static readonly int _CurrPyramidTexture5; // 0x250
		public static readonly int _CurrPyramidTexture6; // 0x254
		public static readonly int _GlobalAtomicBuffer; // 0x258
		public static readonly int _DepthPyramidData; // 0x25C
		public static readonly int _CopyDepthPyramidData; // 0x260
		public static readonly int _HZBTexture0; // 0x264
		public static readonly int _HZBTexture1; // 0x268
		public static readonly int _HZBTexture2; // 0x26C
		public static readonly int _HZBTexture3; // 0x270
		public static readonly int _HZBBuildData; // 0x274
		public static readonly int _HGTerrainChunkTransform; // 0x278
		public static readonly int _HGTerrainChunkParam0; // 0x27C
		public static readonly int _HGTerrainUVTransform; // 0x280
		public static readonly int _HGTerrainRTOffset; // 0x284
		public static readonly int _HGTerrainDecalInstanceInfos; // 0x288
		public static readonly int _HGTerrainDecalInstanceData; // 0x28C
		public static readonly int _HGTerrainFeedbackViewProj; // 0x290
		public static readonly int _HGTerrainCompressCacheParam0; // 0x294
		public static readonly int _HGTerrainPerTerrain; // 0x298
		public static readonly int _HGTerrainPerTerrainFrame; // 0x29C
		public static readonly int _HGTerrainLightmap; // 0x2A0
		public static readonly int _HGTerrainLightmapInd; // 0x2A4
		public static readonly int _HGTerrainControlMap; // 0x2A8
		public static readonly int _HGTerrainSplatIndexMap; // 0x2AC
		public static readonly int _HGTerrainSplats; // 0x2B0
		public static readonly int _HGTerrainNormals; // 0x2B4
		public static readonly int _HGTerrainTerrainNormalmapTexture; // 0x2B8
		public static readonly int _HGTerrainPhysicalBase; // 0x2BC
		public static readonly int _HGTerrainPhysicalNormal; // 0x2C0
		public static readonly int _HGTerrainIndirectTexture; // 0x2C4
		public static readonly int _HGTerrainColorVariationTex; // 0x2C8
		public static readonly int _HGTerrainDecalDiffuseTexArray; // 0x2CC
		public static readonly int _HGTerrainDecalNormalMROTexArray; // 0x2D0
		public static readonly int _HGTerrainHeightmap; // 0x2D4
		public static readonly int _HGTerrainDeformableControlMap; // 0x2D8
		public static readonly int _HGTerrainReflectionProbeTex; // 0x2DC
		public static readonly int _HGTerrainCommonInput; // 0x2E0
		public static readonly int _HGTerrainCommonOutput; // 0x2E4
		public static readonly int _HGTerrainDepthBuffer; // 0x2E8
		public static readonly int _HGTerrainRT0; // 0x2EC
		public static readonly int _HGTerrainRT1; // 0x2F0
		public static readonly int _HGTerrainRT2; // 0x2F4
		public static readonly int _HZBTexture; // 0x2F8
		public static readonly int _HGHiZInput; // 0x2FC
		public static readonly int _HGHiZOutput0; // 0x300
		public static readonly int _HGHiZOutput1; // 0x304
		public static readonly int _HGHiZOutput2; // 0x308
		public static readonly int _HGHiZOutput3; // 0x30C
		public static readonly int _HGHiZMipChain; // 0x310
		public static readonly int _HGHiZRTSize; // 0x314
		public static readonly int _PerPassConstants; // 0x318
		public static readonly int _PerPassConstantsToBe; // 0x31C
		public static readonly int _ShaderVariablesGlobal; // 0x320
		public static readonly int _TransformVariables; // 0x324
		public static readonly int _UIRenderingConstants; // 0x328
		public static readonly int _ShaderVariablesDebugDisplay; // 0x32C
		public static readonly int _GeneralGPUParticleSystemAttributes; // 0x330
		public static readonly int _GPUParticleSystemAttributes; // 0x334
		public static readonly int _PerFrameVariables; // 0x338
		public static readonly int _PerInstanceBuffer; // 0x33C
		public static readonly int _MergePassConstants; // 0x340
		public static readonly int _ParticleAttributes; // 0x344
		public static readonly int _DeadCount; // 0x348
		public static readonly int _DataForEmitter; // 0x34C
		public static readonly int _LiveCount; // 0x350
		public static readonly int _DeadList; // 0x354
		public static readonly int _LiveList; // 0x358
		public static readonly int _InputLiveList; // 0x35C
		public static readonly int _SortedLiveList; // 0x360
		public static readonly int _DrawIndirectArg; // 0x364
		public static readonly int _SceneNormal; // 0x368
		public static readonly int _DispatchSize; // 0x36C
		public static readonly int _InstanceCount; // 0x370
		public static readonly int _CleanupOffset; // 0x374
		public static readonly int _DepthOnlyRT; // 0x378
		public static readonly int _GPUEventSentCount; // 0x37C
		public static readonly int _GPUEventConsumedCount; // 0x380
		public static readonly int _GPUEventBuffer; // 0x384
		public static readonly int _BlitTexture; // 0x388
		public static readonly int _BlitScaleBias; // 0x38C
		public static readonly int _BlitMipLevel; // 0x390
		public static readonly int _BlitTexArraySlice; // 0x394
		public static readonly int _BlurData; // 0x398
		public static readonly int _GaussianBlurTexture; // 0x39C
		public static readonly int _CameraDepthTexture; // 0x3A0
		public static readonly int _FoliageOccluderStateArray; // 0x3A4
		public static readonly int _FoliageOccluderScaleParam; // 0x3A8
		public static readonly int _FoliageOcclusionMask; // 0x3AC
		public static readonly int _FoliageOccluderRenderMask; // 0x3B0
		public static readonly int _FoliageOccluderFinalMask; // 0x3B4
		public static readonly int _PrevFoliageOccluderTex; // 0x3B8
		public static readonly int _FoliageLODFadeValue; // 0x3BC
		public static readonly int _FoliageOccluderCameraPosParam; // 0x3C0
		public static readonly int _ClothDataClearCB; // 0x3C4
		public static readonly int _ClothDataUploadCB; // 0x3C8
		public static readonly int _ClothGroupUploadDataMapBuffer; // 0x3CC
		public static readonly int _InputClothMetaDataBuffer; // 0x3D0
		public static readonly int _InputClothNodeDataBuffer1; // 0x3D4
		public static readonly int _InputClothNodeDataBuffer2; // 0x3D8
		public static readonly int _InputClothBatchMetaDataBuffer; // 0x3DC
		public static readonly int _InputClothBatchCacheMapBuffer; // 0x3E0
		public static readonly int _OutputClothNodeDataBuffer; // 0x3E4
		public static readonly int _OutputClothMetaDataBuffer; // 0x3E8
		public static readonly int _OutputClothBatchMetaDataBuffer; // 0x3EC
		public static readonly int _OutputClothBatchCacheMapBuffer; // 0x3F0
		public static readonly int _OutputClothSkeletonDataBuffer; // 0x3F4
		public static readonly int _ClothConstDataBuffer; // 0x3F8
		public static readonly int _ClothNodeDataBuffer; // 0x3FC
		public static readonly int _ClothMetaDataBuffer; // 0x400
		public static readonly int _ClothBatchMetaDataBuffer; // 0x404
		public static readonly int _ClothBatchCacheMapBuffer; // 0x408
		public static readonly int _ClothSkeletonDataBuffer; // 0x40C
		public static readonly int _AtmosphereLutConstants; // 0x410
		public static readonly int _TransmittanceLut; // 0x414
		public static readonly int _TransmittanceLutUAV; // 0x418
		public static readonly int _MultiScatteredLuminanceLut; // 0x41C
		public static readonly int _MultiScatteredLuminanceLutUAV; // 0x420
		public static readonly int _SkyViewLut; // 0x424
		public static readonly int _SkyViewLutUAV; // 0x428
		public static readonly int _VolumetricFogVBufferA; // 0x42C
		public static readonly int _VolumetricFogVBufferB; // 0x430
		public static readonly int _LightScattering; // 0x434
		public static readonly int _LightScatteringHistory; // 0x438
		public static readonly int _RWIntegratedLightScattering; // 0x43C
		public static readonly int _IntegratedLightScattering; // 0x440
		public static readonly int _VolumetricLight3DNoise; // 0x444
		public static readonly int _VolumetricLight3DNoisePerturb; // 0x448
		public static readonly int _VolumetricFogGridInjectionConstants; // 0x44C
		public static readonly int _VolumetricFogLightScatteringConstants; // 0x450
		public static readonly int _VoxelizationPassIndex; // 0x454
		public static readonly int _VoxelizationClosestSliceIndex; // 0x458
		public static readonly int _VoxelizationClipRatio; // 0x45C
		public static readonly int _VoxelizationVolumePos; // 0x460
		public static readonly int _VoxelizationVolumeRadius; // 0x464
		public static readonly int _VoxelizationViewSpacePos; // 0x468
		public static readonly int _VoxelizationWorldToObject; // 0x46C
		public static readonly int _VoxelizationFrameJitterOffset; // 0x470
		public static readonly int _VoxelizationViewToVolumeClip; // 0x474
		public static readonly int _Tint; // 0x478
		public static readonly int _Exposure; // 0x47C
		public static readonly int _Rotation; // 0x480
		public static readonly int _Tex; // 0x484
		public static readonly int _SunDiscParam0; // 0x488
		public static readonly int _SunDiscParam1; // 0x48C
		public static readonly int _SunDiscParam2; // 0x490
		public static readonly int _SkyBoxStarParam0; // 0x494
		public static readonly int _SkyBoxStarParam1; // 0x498
		public static readonly int _SkyBoxStarParam2; // 0x49C
		public static readonly int _SkyBoxStarParam3; // 0x4A0
		public static readonly int _SkyBoxStarParam4; // 0x4A4
		public static readonly int _SkyBoxStarParam5; // 0x4A8
		public static readonly int _SkyBoxStarParam6; // 0x4AC
		public static readonly int _SkyBoxStarTexture; // 0x4B0
		public static readonly int _SkyBoxStarDensityTexture; // 0x4B4
		public static readonly int _SkyBoxNebulaTexture; // 0x4B8
		public static readonly int _CloudTexture; // 0x4BC
		public static readonly int _CloudFlowMap; // 0x4C0
		public static readonly int _CloudParam; // 0x4C4
		public static readonly int _CloudFlowParam; // 0x4C8
		public static readonly int _CloudOpacities; // 0x4CC
		public static readonly int _CloudTint; // 0x4D0
		public static readonly int _Size; // 0x4D4
		public static readonly int _Source; // 0x4D8
		public static readonly int _SourceMip; // 0x4DC
		public static readonly int _SrcOffsetAndLimit; // 0x4E0
		public static readonly int _SrcScaleBias; // 0x4E4
		public static readonly int _SrcUvLimits; // 0x4E8
		public static readonly int _DstOffset; // 0x4EC
		public static readonly int _DepthMipChain; // 0x4F0
		public static readonly int _RingParams; // 0x4F4
		public static readonly int _RingUpWithBelow; // 0x4F8
		public static readonly int _RingFoward; // 0x4FC
		public static readonly int _RingRight; // 0x500
		public static readonly int _RingColor; // 0x504
		public static readonly int _RingAlbedoTexture; // 0x508
		public static readonly int _PlanetCenterViewDir; // 0x50C
		public static readonly int _IncidentLightDir; // 0x510
		public static readonly int _PlanetParams; // 0x514
		public static readonly int _RingTex; // 0x518
		public static readonly int _RingColorAlpha; // 0x51C
		public static readonly int _PlanetAtmosphereParams; // 0x520
		public static readonly int _PlanetAtmosphereParams2; // 0x524
		public static readonly int _PlanetAtmosphereParams3; // 0x528
		public static readonly int _AtmosphereRTTex; // 0x52C
		public static readonly int _PlanetUpWs; // 0x530
		public static readonly int _PlanetForwardWs; // 0x534
		public static readonly int _PlanetRightWs; // 0x538
		public static readonly int[] _PlanetsInView; // 0x540
		public static readonly int[] _PlanetCenterPos01; // 0x548
		public static readonly int[] _PlanetCenterViewDir01; // 0x550
		public static readonly int[] _IncidentLightDir01; // 0x558
		public static readonly int[] _PlanetParams01; // 0x560
		public static readonly int[] _PlanetUpWs01; // 0x568
		public static readonly int[] _PlanetForwardWs01; // 0x570
		public static readonly int[] _PlanetRightWs01; // 0x578
		public static readonly int[] _PlanetColor01; // 0x580
		public static readonly int[] _RingShadowSoftness01; // 0x588
		public static readonly int[] _RingColorAlpha01; // 0x590
		public static readonly int[] _PlanetEmissive01; // 0x598
		public static readonly int[] _StarNdlSharp01; // 0x5A0
		public static readonly int[] _StarBackFaceAlpha01; // 0x5A8
		public static readonly int[] _PlanetBaseMap01; // 0x5B0
		public static readonly int[] _PlanetEmiMap01; // 0x5B8
		public static readonly int[] _PlanetRingTex01; // 0x5C0
		public static readonly int[] _PlanetBlendMode; // 0x5C8
		public static readonly int _PlanetBillBoardConstants; // 0x5D0
		public static readonly int _RealPlanetRadius; // 0x5D4
		public static readonly int _AtmosphereRatios; // 0x5D8
		public static readonly int _GlobalRadiusOffset; // 0x5DC
		public static readonly int _Density_Multiplier; // 0x5E0
		public static readonly int _g; // 0x5E4
		public static readonly int _StepsI; // 0x5E8
		public static readonly int _StepsL; // 0x5EC
		public static readonly int _Mie_Height_Scale; // 0x5F0
		public static readonly int _Pitch; // 0x5F4
		public static readonly int _Roll; // 0x5F8
		public static readonly int _Phi2; // 0x5FC
		public static readonly int _Theta2; // 0x600
		public static readonly int _Dist; // 0x604
		public static readonly int _CapThreshold; // 0x608
		public static readonly int _Roughness; // 0x60C
		public static readonly int _BBRadius; // 0x610
		public static readonly int _Erosion; // 0x614
		public static readonly int _ErosionThreshold; // 0x618
		public static readonly int _CloudsAlphaMain; // 0x61C
		public static readonly int _CloudsSpeedMain; // 0x620
		public static readonly int _IndirectIntensity; // 0x624
		public static readonly int _DirectLightIntensityBillboard; // 0x628
		public static readonly int _Light_Intensity_Multiplier; // 0x62C
		public static readonly int _Light_Intensity_Clouds_Multiplier; // 0x630
		public static readonly int _PlanetRotateStart; // 0x634
		public static readonly int _PlanetRotateSpeed; // 0x638
		public static readonly int _CapTransition; // 0x63C
		public static readonly int _CloudsFlowStrength; // 0x640
		public static readonly int _CloudsHeight; // 0x644
		public static readonly int _CloudsFlowSpeed; // 0x648
		public static readonly int _Use_Lut; // 0x64C
		public static readonly int _CustomLightColorPla; // 0x650
		public static readonly int _CustomLightDirection; // 0x654
		public static readonly int _UseRoughnessMap; // 0x658
		public static readonly int _EnablePolarCap; // 0x65C
		public static readonly int _UseErosionMap; // 0x660
		public static readonly int _Ray; // 0x664
		public static readonly int _Mie; // 0x668
		public static readonly int _Ambient; // 0x66C
		public static readonly int _PlanetWSBase; // 0x670
		public static readonly int _BBWSBase; // 0x674
		public static readonly int _PlanetScale; // 0x678
		public static readonly int _FresnelColor; // 0x67C
		public static readonly int _TintColor; // 0x680
		public static readonly int _SeaDeep; // 0x684
		public static readonly int _SeaShallow; // 0x688
		public static readonly int _IndirectColor; // 0x68C
		public static readonly int _CustomLightDir; // 0x690
		public static readonly int _CustomLightColPla; // 0x694
		public static readonly int _CloudsShadowColor; // 0x698
		public static readonly int _BaseColorMap_ST; // 0x69C
		public static readonly int _ErosionMap_ST; // 0x6A0
		public static readonly int _TransmittanceLLUT; // 0x6A4
		public static readonly int _BaseColorMap; // 0x6A8
		public static readonly int _RSM; // 0x6AC
		public static readonly int _CloudsTexMain; // 0x6B0
		public static readonly int _CloudsCap; // 0x6B4
		public static readonly int _CloudsFlowMap; // 0x6B8
		public static readonly int _ErosionMap; // 0x6BC
		public static readonly int[] _PlanetAtmosphereParamsPack; // 0x6C0
		public static readonly int[] _PlanetAtmosphereParams2Pack; // 0x6C8
		public static readonly int[] _PlanetAtmosphereParams3Pack; // 0x6D0
		public static readonly int _HGAutoExposureHistogramBuffer; // 0x6D8
		public static readonly int _AE_inputTexture; // 0x6DC
		public static readonly int _AE_histogramBuffer; // 0x6E0
		public static readonly int _Variants; // 0x6E4
		public static readonly int _InputTexture; // 0x6E8
		public static readonly int _OutputTexture; // 0x6EC
		public static readonly int _Params; // 0x6F0
		public static readonly int _Params0; // 0x6F4
		public static readonly int _Params1; // 0x6F8
		public static readonly int _Params2; // 0x6FC
		public static readonly int _Params3; // 0x700
		public static readonly int _TexelSize; // 0x704
		public static readonly int _FrostedGlassTexLight; // 0x708
		public static readonly int _FrostedGlassTexMedium; // 0x70C
		public static readonly int _FrostedGlassTexHeavy; // 0x710
		public static readonly int _FrostedGlassTexLightScene; // 0x714
		public static readonly int _FrostedGlassTexMediumScene; // 0x718
		public static readonly int _FrostedGlassTexHeavyScene; // 0x71C
		public static readonly int _ColorThreshold; // 0x720
		public static readonly int _LightShaftSceneColor; // 0x724
		public static readonly int _LightShaftSceneDepth; // 0x728
		public static readonly int _LightShaftBlurSrc; // 0x72C
		public static readonly int _LightShaftBlurResult; // 0x730
		public static readonly int _LightShaftBlurPassIndex; // 0x734
		public static readonly int _LightShaftCloudMask; // 0x738
		public static readonly int _LightShaftParams0; // 0x73C
		public static readonly int _LightShaftParams1; // 0x740
		public static readonly int _LightShaftParams2; // 0x744
		public static readonly int _LightShaftParams3; // 0x748
		public static readonly int _LightShaftCloudMaskParams; // 0x74C
		public static readonly int _BloomParams; // 0x750
		public static readonly int _BloomTint; // 0x754
		public static readonly int _BloomTexture; // 0x758
		public static readonly int _BloomDirtTexture; // 0x75C
		public static readonly int _BloomDirtScaleOffset; // 0x760
		public static readonly int _InputLowTexture; // 0x764
		public static readonly int _InputHighTexture; // 0x768
		public static readonly int _BloomBicubicParams; // 0x76C
		public static readonly int _BloomThreshold; // 0x770
		public static readonly int _BloomCharacterThreshold; // 0x774
		public static readonly int _BloomCharacterParams; // 0x778
		public static readonly int _BloomBuffer; // 0x77C
		public static readonly int _RadialBlurParams; // 0x780
		public static readonly int _RadialBlurParams2; // 0x784
		public static readonly int _BWFlashThreshold; // 0x788
		public static readonly int _BWFlashParams; // 0x78C
		public static readonly int _BWFlashParams2; // 0x790
		public static readonly int _BWFlashParams3; // 0x794
		public static readonly int _BWFlashParams4; // 0x798
		public static readonly int _BWFlashTexture; // 0x79C
		public static readonly int _BWMaskTexture; // 0x7A0
		public static readonly int _BWFlashColor; // 0x7A4
		public static readonly int _BWBackGroundColor; // 0x7A8
		public static readonly int _FisheyeEffectParams1; // 0x7AC
		public static readonly int _ScanLineTint; // 0x7B0
		public static readonly int _ScanLineMask; // 0x7B4
		public static readonly int _ScanLineCenterPos; // 0x7B8
		public static readonly int _ScanLineParams1; // 0x7BC
		public static readonly int _ScanLineParams2; // 0x7C0
		public static readonly int _ScanLineParams3; // 0x7C4
		public static readonly int _ScanLineParams4; // 0x7C8
		public static readonly int _ScanLineParams5; // 0x7CC
		public static readonly int _ScanLineParams6; // 0x7D0
		public static readonly int _ScanLineParams7; // 0x7D4
		public static readonly int _ScanLineParams8; // 0x7D8
		public static readonly int _ScanLineParams9; // 0x7DC
		public static readonly int _ScanLineParams10; // 0x7E0
		public static readonly int _ScanLineHighlightHeight; // 0x7E4
		public static readonly int _BoxPosWS; // 0x7E8
		public static readonly int _ScanLineHighlightTint; // 0x7EC
		public static readonly int _ScanLineHighlightBeamTint; // 0x7F0
		public static readonly int _BoxPosition1; // 0x7F4
		public static readonly int _BoxPosition2; // 0x7F8
		public static readonly int _BoxPosition3; // 0x7FC
		public static readonly int _BoxVec1; // 0x800
		public static readonly int _BoxVec2; // 0x804
		public static readonly int _BoxVec3; // 0x808
		public static readonly int _CountPerArray; // 0x80C
		public static readonly int _MeshHeight; // 0x810
		public static readonly int _BlackBoxBackGroundTint; // 0x814
		public static readonly int _BlackBoxContourColor; // 0x818
		public static readonly int _BlackBoxCenterPos; // 0x81C
		public static readonly int _BlackBoxParams1; // 0x820
		public static readonly int _BlackBoxParams2; // 0x824
		public static readonly int _BlackBoxParams3; // 0x828
		public static readonly int _BlackBoxParams4; // 0x82C
		public static readonly int _BlackBoxParams5; // 0x830
		public static readonly int _BlackBoxContourTexture; // 0x834
		public static readonly int _SharpenParams; // 0x838
		public static readonly int _PPSharpen; // 0x83C
		public static readonly int _PostProcessMask; // 0x840
		public static readonly int _FrostedGlassTexture; // 0x844
		public static readonly int _FrostedGlassBuffer; // 0x848
		public static readonly int _VignetteParams1; // 0x84C
		public static readonly int _VignetteParams2; // 0x850
		public static readonly int _VignetteColor; // 0x854
		public static readonly int _VignetteMask; // 0x858
		public static readonly int _DirtyTex; // 0x85C
		public static readonly int _DirtyLensParams1; // 0x860
		public static readonly int _LogLut3D; // 0x864
		public static readonly int _LogLut3D_Params; // 0x868
		public static readonly int _LogLut2D; // 0x86C
		public static readonly int _Lut_Params; // 0x870
		public static readonly int _UserLut; // 0x874
		public static readonly int _UserLut_Params; // 0x878
		public static readonly int _ColorBalance; // 0x87C
		public static readonly int _ColorFilter; // 0x880
		public static readonly int _ChannelMixerRed; // 0x884
		public static readonly int _ChannelMixerGreen; // 0x888
		public static readonly int _ChannelMixerBlue; // 0x88C
		public static readonly int _HueSatCon; // 0x890
		public static readonly int _Lift; // 0x894
		public static readonly int _Gamma; // 0x898
		public static readonly int _Gain; // 0x89C
		public static readonly int _Shadows; // 0x8A0
		public static readonly int _Midtones; // 0x8A4
		public static readonly int _Highlights; // 0x8A8
		public static readonly int _ShaHiLimits; // 0x8AC
		public static readonly int _SplitShadows; // 0x8B0
		public static readonly int _SplitHighlights; // 0x8B4
		public static readonly int _CurveMaster; // 0x8B8
		public static readonly int _CurveRed; // 0x8BC
		public static readonly int _CurveGreen; // 0x8C0
		public static readonly int _CurveBlue; // 0x8C4
		public static readonly int _CurveHueVsHue; // 0x8C8
		public static readonly int _CurveHueVsSat; // 0x8CC
		public static readonly int _CurveSatVsSat; // 0x8D0
		public static readonly int _CurveLumVsSat; // 0x8D4
		public static readonly int _CustomToneCurve; // 0x8D8
		public static readonly int _ToeSegmentA; // 0x8DC
		public static readonly int _ToeSegmentB; // 0x8E0
		public static readonly int _MidSegmentA; // 0x8E4
		public static readonly int _MidSegmentB; // 0x8E8
		public static readonly int _ShoSegmentA; // 0x8EC
		public static readonly int _ShoSegmentB; // 0x8F0
		public static readonly int _OwenScrambledTexture; // 0x8F4
		public static readonly int _ScramblingTileXSPP; // 0x8F8
		public static readonly int _RankingTileXSPP; // 0x8FC
		public static readonly int _ScramblingTexture; // 0x900
		public static readonly int _AfterPostProcessTexture; // 0x904
		public static readonly int _UVTransform; // 0x908
		public static readonly int _InputTex; // 0x90C
		public static readonly int _LoD; // 0x910
		public static readonly int _FaceIndex; // 0x914
		public static readonly int _ViewPortSize; // 0x918
		public static readonly int _Dst3DTexture; // 0x91C
		public static readonly int _Src3DTexture; // 0x920
		public static readonly int _AlphaOnlyTexture; // 0x924
		public static readonly int _SrcSize; // 0x928
		public static readonly int _SrcMip; // 0x92C
		public static readonly int _SrcScale; // 0x930
		public static readonly int _SrcOffset; // 0x934
		public static readonly int _UseLighting; // 0x938
		public static readonly int _UseBright; // 0x93C
		public static readonly int _UseSoftBlend; // 0x940
		public static readonly int _UseEdgeColor; // 0x944
		public static readonly int _UseFresnel; // 0x948
		public static readonly int _UseFog; // 0x94C
		public static readonly int _UseVertexOffset; // 0x950
		public static readonly int _UsedForUI; // 0x954
		public static readonly int _UseTrail; // 0x958
		public static readonly int _UseSafeZoneMap; // 0x95C
		public static readonly int _UseAlphaTest; // 0x960
		public static readonly int _UseNearCameraFade; // 0x964
		public static readonly int _UseVFXPortal; // 0x968
		public static readonly int _DisableZTest; // 0x96C
		public static readonly int _DisableVertColor; // 0x970
		public static readonly int _IsUI; // 0x974
		public static readonly int _InParticle; // 0x978
		public static readonly int _IgnorePostExposure; // 0x97C
		public static readonly int _EnableHoudiniVAT; // 0x980
		public static readonly int _SceneDepth; // 0x984
		public static readonly int _MotionVector; // 0x988
		public static readonly int _CurrDilatedDepth; // 0x98C
		public static readonly int _PrevDilatedDepth; // 0x990
		public static readonly int _CurrDilatedMV; // 0x994
		public static readonly int _PrevDilatedMV; // 0x998
		public static readonly int _CurrDilatedMask; // 0x99C
		public static readonly int _HistorySceneColor; // 0x9A0
		public static readonly int _TAAUConstants; // 0x9A4
		public static readonly int _CapsuleShadowData1; // 0x9A8
		public static readonly int _CapsuleShadowData2; // 0x9AC
		public static readonly int _CapsuleShadowData3; // 0x9B0
		public static readonly int _CapsuleShadowData4; // 0x9B4
		public static readonly int _FlareOcclusionTex; // 0x9B8
		public static readonly int _FlareOcclusionIndex; // 0x9BC
		public static readonly int _FlareTex; // 0x9C0
		public static readonly int _FlareColorValue; // 0x9C4
		public static readonly int _FlareData0; // 0x9C8
		public static readonly int _FlareData1; // 0x9CC
		public static readonly int _FlareData2; // 0x9D0
		public static readonly int _FlareData3; // 0x9D4
		public static readonly int _FlareData4; // 0x9D8
		public static readonly int _FlareData5; // 0x9DC
		public static readonly int _LowDoFParams; // 0x9E0
		public static readonly int _LowDoFCoCRT; // 0x9E4
		public static readonly int _CompositeRT; // 0x9E8
		public static readonly int _SSRData; // 0x9EC
		public static readonly int _SSRParams0; // 0x9F0
		public static readonly int _SSRParams1; // 0x9F4
		public static readonly int _SSRParams2; // 0x9F8
		public static readonly int _SSRParams3; // 0x9FC
		public static readonly int _SSRParams4; // 0xA00
		public static readonly int _SSRRTSize; // 0xA04
		public static readonly int _SSRLRSize; // 0xA08
		public static readonly int _SSRHRSize; // 0xA0C
		public static readonly int _SSRProjMatrix; // 0xA10
		public static readonly int _SSRInvProjMatrix; // 0xA14
		public static readonly int _SSRInvViewProjMatrix; // 0xA18
		public static readonly int _SSRWorldToViewMatrix; // 0xA1C
		public static readonly int _SSRCurrSceneColor; // 0xA20
		public static readonly int _SSRPrevSceneColor; // 0xA24
		public static readonly int _SSRSceneDepth; // 0xA28
		public static readonly int _SSRSceneStencil; // 0xA2C
		public static readonly int _SSRSceneDepthPyramid; // 0xA30
		public static readonly int _SSRGBuffer; // 0xA34
		public static readonly int _SSRMotionVector; // 0xA38
		public static readonly int _SSRRT0; // 0xA3C
		public static readonly int _SSRRT1; // 0xA40
		public static readonly int _SSRRT2; // 0xA44
		public static readonly int _SSRRT_Mobile0; // 0xA48
		public static readonly int _SSRRT_Mobile1; // 0xA4C
		public static readonly int _SSRRT_Mobile2; // 0xA50
		public static readonly int _SSRHitUVZRT; // 0xA54
		public static readonly int _SSRHitColorRT; // 0xA58
		public static readonly int _SSRLastColorRT; // 0xA5C
		public static readonly int _SSRCurrColorRT; // 0xA60
		public static readonly int _TemporalFilterOutRT0; // 0xA64
		public static readonly int _TemporalFilterOutRT1; // 0xA68
		public static readonly int _SSRRayTracingMaskRT; // 0xA6C
		public static readonly int _SSRLightingTexture; // 0xA70
		public static readonly int _SSRFadenessTexture; // 0xA74
		public static readonly int _ISSRParam0; // 0xA78
		public static readonly int _ISSRParam1; // 0xA7C
		public static readonly int _ISSRParam2; // 0xA80
		public static readonly int _ISSRParam3; // 0xA84
		public static readonly int _ISSRScreenSize; // 0xA88
		public static readonly int _ISSRHalfScreenSize; // 0xA8C
		public static readonly int _ISSRCurrSceneDepthTexture; // 0xA90
		public static readonly int _ISSRGBufferMVTexture; // 0xA94
		public static readonly int _ISSRRayMarchingPackDataTexture; // 0xA98
		public static readonly int _ISSRPrevSceneColorTexture; // 0xA9C
		public static readonly int _ISSRUnpackTexture; // 0xAA0
		public static readonly int _ISSRPrevTemporalTexture; // 0xAA4
		public static readonly int _ISSRCurrTemporalTexture; // 0xAA8
		public static readonly int _ISSRPrevMipRTSize; // 0xAAC
		public static readonly int _ISSRCurrMipRTSize; // 0xAB0
		public static readonly int _ISSRPrevMipSceneColorTexture; // 0xAB4
		public static readonly int _ISSRCurrMipSceneColorTexture; // 0xAB8
		public static readonly int _ISSRReflectionMipChainTexture; // 0xABC
		public static readonly int _ISSRResolveTexture; // 0xAC0
		public static readonly int _ISSRReflectionTexture; // 0xAC4
		public static readonly int _ISSRUpsamplingTexture; // 0xAC8
		public static readonly int _FakePlanarReflectionTexture; // 0xACC
		public static readonly int _RayTracingDataParams; // 0xAD0
		public static readonly int _ContactShadowDataParams; // 0xAD4
		public static readonly int _ContactShadowWorkgroupOffset; // 0xAD8
		public static readonly int _ContactShadowDepthBuffer; // 0xADC
		public static readonly int _ContactShadowStencilBuffer; // 0xAE0
		public static readonly int _ContactShadowContactShadow; // 0xAE4
		public static readonly int _ContactShadowContactShadowTemp; // 0xAE8
		public static readonly int _GTAOData; // 0xAEC
		public static readonly int _GTAOParam0; // 0xAF0
		public static readonly int _GTAOParam1; // 0xAF4
		public static readonly int _GTAOParam2; // 0xAF8
		public static readonly int _GTAOParam3; // 0xAFC
		public static readonly int _GTAOHalfScreenSize; // 0xB00
		public static readonly int _GTAODepthMIPs; // 0xB04
		public static readonly int _GTAOOutAOTerm; // 0xB08
		public static readonly int _GTAOOutEdges; // 0xB0C
		public static readonly int _GTAODepthMip0; // 0xB10
		public static readonly int _GTAODepthMip1; // 0xB14
		public static readonly int _GTAODepthMip2; // 0xB18
		public static readonly int _GTAODepthMip3; // 0xB1C
		public static readonly int _GTAODepthMip4; // 0xB20
		public static readonly int _GTAOInAOTerm; // 0xB24
		public static readonly int _GTAOInEdges; // 0xB28
		public static readonly int _GTAOOutRT; // 0xB2C
		public static readonly int _GTAOMainAOTermRT; // 0xB30
		public static readonly int _GTAOMotionVectorRT; // 0xB34
		public static readonly int _GTAOPreviousAOTermRT; // 0xB38
		public static readonly int _GTAOCurrentAOTermRT; // 0xB3C
		public static readonly int _GTAOBlurAOTermInRT; // 0xB40
		public static readonly int _GTAOBlurAOTermOutRT; // 0xB44
		public static readonly int _GTAOBlurAOTermRT; // 0xB48
		public static readonly int _GTAOUpsampleAOTermRT; // 0xB4C
		public static readonly int _WaterData; // 0xB50
		public static readonly int _WaterOcclusionData; // 0xB54
		public static readonly int _WaterOcclusionTilePassCB; // 0xB58
		public static readonly int _WaterTesellationDrawIndirectArgsCB; // 0xB5C
		public static readonly int _WaterInteractiveCB; // 0xB60
		public static readonly int _WaterProxy; // 0xB64
		public static readonly int _WaterDecal; // 0xB68
		public static readonly int _WaterInteractiveTexture; // 0xB6C
		public static readonly int _WaterPrepassDataTexture; // 0xB70
		public static readonly int _WaterPrepassNormalTexture; // 0xB74
		public static readonly int _WaterPrepassDisplacementTexture; // 0xB78
		public static readonly int _WaterPrepassDepthTexture; // 0xB7C
		public static readonly int _WaterPrepassDataGlobalTexture; // 0xB80
		public static readonly int _WaterPrepassNormalGlobalTexture; // 0xB84
		public static readonly int _WaterPrepassDepthGlobalTexture; // 0xB88
		public static readonly int _NormalRoughnessTexture; // 0xB8C
		public static readonly int _WaterLocalFlowmapTexture; // 0xB90
		public static readonly int _WaterRippleTexture; // 0xB94
		public static readonly int _WaterGlobalFlowmapTexture; // 0xB98
		public static readonly int _WaterGlobalSmallWaveNormalTexture; // 0xB9C
		public static readonly int _WaterGlobalLargeWaveNormalTexture; // 0xBA0
		public static readonly int _WaterGlobalNormalTextureArray; // 0xBA4
		public static readonly int _WaterGlobalCausticTexture; // 0xBA8
		public static readonly int _WaterGlobalRainTexture; // 0xBAC
		public static readonly int _WaterReflectLightingTexture; // 0xBB0
		public static readonly int _WaterReflectFadenessTexture; // 0xBB4
		public static readonly int _WaterWetnessMaskTexture; // 0xBB8
		public static readonly int _WaterWetnessMask3dNoiseTexture; // 0xBBC
		public static readonly int _FoliageInteractiveTex; // 0xBC0
		public static readonly int _PrevFoliageInteractiveTex; // 0xBC4
		public static readonly int _DynamicSludgeTex; // 0xBC8
		public static readonly int _PrevDynamicSludgeTex; // 0xBCC
		public static readonly int _SludgeThicknessTex; // 0xBD0
		public static readonly int _PrevSludgeThicknessTex; // 0xBD4
		public static readonly int _PrevSludgeMinHeightTex; // 0xBD8
		public static readonly int _WindGlobalNoiseTex; // 0xBDC
		public static readonly int _HeightFogNoise3DTex; // 0xBE0
		public static readonly int _FogBakeLutTex; // 0xBE4
		public static readonly int _DepthOfFieldData; // 0xBE8
		public static readonly int[] _MotionBlurHistoryTexture; // 0xBF0
		public static readonly int _VerticalFadeStart; // 0xBF8
		public static readonly int _VerticalFadeEnd; // 0xBFC
		public static readonly int _VerticalFadeAffectDist; // 0xC00
		public static readonly int _VerticalFadeDist; // 0xC04
		public static readonly int _GroundColorAdj; // 0xC08
		public static readonly int _InkWashIntensity; // 0xC0C
		public static readonly int _InkWashSceneColor; // 0xC10
		public static readonly int _InkWashSceneDepth; // 0xC14
		public static readonly int _InkWashSceneNormalRoughness; // 0xC18
		public static readonly int _InkMask; // 0xC1C
		public static readonly int _InkDropSize; // 0xC20
		public static readonly int _InkBleedingSpeed; // 0xC24
		public static readonly int _InkBleedingDeltaTime; // 0xC28
		public static readonly int _InkPointDir; // 0xC2C
		public static readonly int _InkMaskFaceBasis; // 0xC30
		public static readonly int _InkStrokeSeed; // 0xC34
		public static readonly int _AtlasSize; // 0xC38
		public static readonly int _EdgeFade; // 0xC3C
		public static readonly int _InkMaskParams; // 0xC40
		public static readonly int _InkWashParams; // 0xC44
		public static readonly int _UIImageBlurTex; // 0xC48
		public static readonly int _ColorBuffer; // 0xC4C
		public static readonly int _PPColor; // 0xC50
		public static readonly int _RWDebugFullScreenBuffer; // 0xC54
		public static readonly int _HistogramDebugBuffer; // 0xC58
		public static readonly int _HistogramSize; // 0xC5C
		public static readonly int _HistogramMin; // 0xC60
		public static readonly int _HistogramMax; // 0xC64
		public static readonly int _FlipY; // 0xC68
		public static readonly int _IrradianceVolumeAtlas0; // 0xC6C
		public static readonly int _IrradianceVolumeAtlas1; // 0xC70
		public static readonly int _IrradianceVolumeAtlas; // 0xC74
		public static readonly int _FlattenIndexBuffer; // 0xC78
		public static readonly int _IrradianceDataBuffer; // 0xC7C
		public static readonly int _EnableIV; // 0xC80
		public static readonly int _IVNormalOffset; // 0xC84
		public static readonly int _ChunkNumPerDim; // 0xC88
		public static readonly int _GlobalHashTable; // 0xC8C
		public static readonly int _HashTableCenterCoord; // 0xC90
		public static readonly int _IrradianceVolumeIndirectTexture; // 0xC94
		public static readonly int _IrradianceVolumeChunkStartPos; // 0xC98
		public static readonly int _IndirectCenterPos; // 0xC9C
		public static readonly int _IndirectPreCenterPos; // 0xCA0
		public static readonly int _CameraUpdateCnt; // 0xCA4
		public static readonly int _ChunkUpdateCnt; // 0xCA8
		public static readonly int _IrradianceVolumeClipmapTextureALod0; // 0xCAC
		public static readonly int _IrradianceVolumeClipmapTextureBLod0; // 0xCB0
		public static readonly int _IrradianceVolumeClipmapTextureALod1; // 0xCB4
		public static readonly int _IrradianceVolumeClipmapTextureBLod1; // 0xCB8
		public static readonly int _IrradianceVolumeClipmapTextureALod3; // 0xCBC
		public static readonly int _IrradianceVolumeClipmapTextureBLod3; // 0xCC0
		public static readonly int _RainTex0; // 0xCC4
		public static readonly int _RainTex0_ST; // 0xCC8
		public static readonly int _RainTex1; // 0xCCC
		public static readonly int _RainTex1_ST; // 0xCD0
		public static readonly int _RainParams; // 0xCD4
		public static readonly int _RainMaskParams; // 0xCD8
		public static readonly int _RainOffsetParams; // 0xCDC
		public static readonly int _RainDirectionParams; // 0xCE0
		public static readonly int _RainColor; // 0xCE4
		public static readonly int _ScreenDropFXNoiseTex; // 0xCE8
		public static readonly int _ScreenDropFXNoiseTex_ST; // 0xCEC
		public static readonly int _ScreenDropRenderDatas; // 0xCF0
		public static readonly int _RainOcclusionSampleNoise; // 0xCF4
		public static readonly int _VerticalFlowTexture; // 0xCF8
		public static readonly int _RippleTexture; // 0xCFC
		public static readonly int _VerticalOcclusionMap; // 0xD00
		public static readonly int _VerticalOcclusionMapTransformCB; // 0xD04
		public static readonly int _CameraHeightRefreshDataCB; // 0xD08
		public static readonly int _CustomDepthOnlyRT; // 0xD0C
		public static readonly int _GlintPatternTexture; // 0xD10
		public static readonly int _GlintTopBlendSmoothness; // 0xD14
		public static readonly int _GlintTopBlendThreshold; // 0xD18
		public static readonly int _GlintStrength; // 0xD1C
		public static readonly int _GlintScale; // 0xD20
		public static readonly int _GlintThreshold; // 0xD24
		public static readonly int _GlintFadeDistance; // 0xD28
		public static readonly int _GlintColor; // 0xD2C
		public static readonly int _UseSubsurfaceProfile; // 0xD30
		public static readonly int _SurfaceAlbedo; // 0xD34
		public static readonly int _MeanFreePathColor; // 0xD38
		public static readonly int _MeanFreePathDistance; // 0xD3C
		public static readonly int _DiffuseMeanFreePath; // 0xD40
		public static readonly int _LutMaxRadius; // 0xD44
		public static readonly int _LutMaxPenumbra; // 0xD48
		public static readonly int _SubsurfaceOriginNormalTex; // 0xD4C
		public static readonly int _SubsurfaceNormalWorldRange; // 0xD50
		public static readonly int _SubsurfaceCurvatureTex; // 0xD54
		public static readonly int _SubsurfaceNormalCurvatureTex; // 0xD58
		public static readonly int _OutScatterLut; // 0xD5C
		public static readonly int _OutPenumbraLut; // 0xD60
		public static readonly int _OutIndirectLut; // 0xD64
		public static readonly int _CurvatureScale; // 0xD68
		public static readonly int _PenumbraScale; // 0xD6C
		public static readonly int _SubsurfaceProfileInt; // 0xD70
		public static readonly int _TerrainSubsurfaceProfileInt; // 0xD74
		public static readonly int _SubsurfaceScatterLutArray; // 0xD78
		public static readonly int _SubsurfacePenumbraLutArray; // 0xD7C
		public static readonly int _SubsurfaceIndirectLutArray; // 0xD80
		public static readonly int _SubsurfaceProfileConstants; // 0xD84
		public static readonly int _SubsurfaceCurvatureScale; // 0xD88
		public static readonly int _SubsurfaceCurvatureOffset; // 0xD8C
		public static readonly int _TerrainStencilRef; // 0xD90
		public static readonly int _SeparateTerrainStencilRef; // 0xD94
		public static readonly int _TerrainSubsurfaceConstants; // 0xD98
		public static readonly int _EnableSubsurface; // 0xD9C
		public static readonly int _SubsurfaceColor; // 0xDA0
		public static readonly int _SubsurfaceValue; // 0xDA4
		public static readonly int _SubsurfaceHue; // 0xDA8
		public static readonly int _SubsurfaceSaturation; // 0xDAC
		public static readonly int _SubsurfaceIndirect; // 0xDB0
		public static readonly int _SubsurfaceInt; // 0xDB4
		public static readonly int _SubsurfaceConstants; // 0xDB8
		public static readonly int _VisibilitySHConstData; // 0xDBC
		public static readonly int _VisibilityCapsuleData; // 0xDC0
		public static readonly int _LogSHLutTex; // 0xDC4
		public static readonly int _ABLutTex; // 0xDC8
		public static readonly int _VisibilitySHRT; // 0xDCC
		public static readonly int _VisibilitySHDebugRT; // 0xDD0
		public static readonly int _FakeVolumeIoR; // 0xDD4
		public static readonly int _FakeVolumeFresnelStrength; // 0xDD8
		public static readonly int _FakeVolumeOpacityMask; // 0xDDC
		public static readonly int _FakeVolumeOpacityTiling; // 0xDE0
		public static readonly int _FakeVolumeMask; // 0xDE4
		public static readonly int _FakeCrackLayerTiling; // 0xDE8
		public static readonly int _FakeCrackTint; // 0xDEC
		public static readonly int _FakeCrackHeightScale; // 0xDF0
		public static readonly int _FakeCrackDepth; // 0xDF4
		public static readonly int _FakeCrackMarchSteps; // 0xDF8
		public static readonly int _FakeRefractionTint; // 0xDFC
		public static readonly int _FakeRefractionLayerTiling; // 0xE00
		public static readonly int _FakeVolumeScatterExtinction; // 0xE04
		public static readonly int _FakeVolumeScatterAlbedo; // 0xE08
		public static readonly int _FakeRefractionHeightScale; // 0xE0C
		public static readonly int _FakeRefractionDepth; // 0xE10
		public static readonly int _FakeRefractionMarchSteps; // 0xE14
		public static readonly int _FakeDustLayerTiling; // 0xE18
		public static readonly int _FakeDustDepth; // 0xE1C
		public static readonly int _FakeDustFlowSpeed; // 0xE20
		public static readonly int _FakeDustTint; // 0xE24
		public static readonly int _FakeShadowPenumbra; // 0xE28
		public static readonly int _FakeShadowStrength; // 0xE2C
		public static readonly int _FakeShadowMarchSteps; // 0xE30
		public static readonly int _FakeShadowDistanceLerp; // 0xE34
		public static readonly int _InteractionDataCB; // 0xE38
		public static readonly int _GroundHeight; // 0xE3C
		public static readonly int _InteractRadius; // 0xE40
		public static readonly int _InteractLength; // 0xE44
		public static readonly int _InteractHeight; // 0xE48
		public static readonly int _InteractHeightScale; // 0xE4C
		public static readonly int _InteractMaskTexture; // 0xE50
		public static readonly int _InteractWorldToLocal; // 0xE54
		public static readonly int _PrevInteractLocalToWorld; // 0xE58
		public static readonly int _CapsuleLocalHeight; // 0xE5C
		public static readonly int _DecalInteractionDataCB; // 0xE60
		public static readonly int _DecalInteractionSettingDataCB; // 0xE64
		public static readonly int _EdgeFadeRatio; // 0xE68
		public static readonly int _GPUDrivenHZB; // 0xE6C
	
		// Constructors
		static HGShaderIDs() {} // 0x00000001842BADF0-0x00000001842C3080
		// HGShaderIDs()
		void HG::Rendering::Runtime::HGShaderIDs::cctor(MethodInfo *method)
		{
		  Int32__Array *v1; // rdi
		  unsigned int v2; // ebx
		  unsigned int v3; // ebx
		  unsigned int v4; // ebx
		  unsigned int v5; // ebx
		  unsigned int v6; // ebx
		  unsigned int v7; // ebx
		  unsigned int v8; // ebx
		  unsigned int v9; // ebx
		  PlayerLoopSystem *v10; // r8
		  Object *v11; // r9
		  Int32__Array *v12; // rdi
		  unsigned int v13; // ebx
		  unsigned int v14; // ebx
		  PlayerLoopSystem *v15; // r8
		  Object *v16; // r9
		  Int32__Array *v17; // rdi
		  unsigned int v18; // ebx
		  unsigned int v19; // ebx
		  PlayerLoopSystem *v20; // r8
		  Object *v21; // r9
		  Int32__Array *v22; // rdi
		  unsigned int v23; // ebx
		  unsigned int v24; // ebx
		  PlayerLoopSystem *v25; // r8
		  Object *v26; // r9
		  Int32__Array *v27; // rdi
		  unsigned int v28; // ebx
		  unsigned int v29; // ebx
		  PlayerLoopSystem *v30; // r8
		  Object *v31; // r9
		  Int32__Array *v32; // rdi
		  unsigned int v33; // ebx
		  unsigned int v34; // ebx
		  PlayerLoopSystem *v35; // r8
		  Object *v36; // r9
		  Int32__Array *v37; // rdi
		  unsigned int v38; // ebx
		  unsigned int v39; // ebx
		  PlayerLoopSystem *v40; // r8
		  Object *v41; // r9
		  Int32__Array *v42; // rdi
		  unsigned int v43; // ebx
		  unsigned int v44; // ebx
		  PlayerLoopSystem *v45; // r8
		  Object *v46; // r9
		  Int32__Array *v47; // rdi
		  unsigned int v48; // ebx
		  unsigned int v49; // ebx
		  PlayerLoopSystem *v50; // r8
		  Object *v51; // r9
		  Int32__Array *v52; // rdi
		  unsigned int v53; // ebx
		  unsigned int v54; // ebx
		  PlayerLoopSystem *v55; // r8
		  Object *v56; // r9
		  Int32__Array *v57; // rdi
		  unsigned int v58; // ebx
		  unsigned int v59; // ebx
		  PlayerLoopSystem *v60; // r8
		  Object *v61; // r9
		  Int32__Array *v62; // rdi
		  unsigned int v63; // ebx
		  unsigned int v64; // ebx
		  PlayerLoopSystem *v65; // r8
		  Object *v66; // r9
		  Int32__Array *v67; // rdi
		  unsigned int v68; // ebx
		  unsigned int v69; // ebx
		  PlayerLoopSystem *v70; // r8
		  Object *v71; // r9
		  Int32__Array *v72; // rdi
		  unsigned int v73; // ebx
		  unsigned int v74; // ebx
		  PlayerLoopSystem *v75; // r8
		  Object *v76; // r9
		  Int32__Array *v77; // rdi
		  unsigned int v78; // ebx
		  unsigned int v79; // ebx
		  PlayerLoopSystem *v80; // r8
		  Object *v81; // r9
		  Int32__Array *v82; // rdi
		  unsigned int v83; // ebx
		  unsigned int v84; // ebx
		  PlayerLoopSystem *v85; // r8
		  Object *v86; // r9
		  Int32__Array *v87; // rdi
		  unsigned int v88; // ebx
		  unsigned int v89; // ebx
		  PlayerLoopSystem *v90; // r8
		  Object *v91; // r9
		  Int32__Array *v92; // rdi
		  unsigned int v93; // ebx
		  unsigned int v94; // ebx
		  PlayerLoopSystem *v95; // r8
		  Object *v96; // r9
		  Int32__Array *v97; // rdi
		  unsigned int v98; // ebx
		  unsigned int v99; // ebx
		  PlayerLoopSystem *v100; // r8
		  Object *v101; // r9
		  Int32__Array *v102; // rdi
		  unsigned int v103; // ebx
		  unsigned int v104; // ebx
		  PlayerLoopSystem *v105; // r8
		  Object *v106; // r9
		  Int32__Array *v107; // rdi
		  unsigned int v108; // ebx
		  unsigned int v109; // ebx
		  PlayerLoopSystem *v110; // r8
		  Object *v111; // r9
		  Int32__Array *v112; // rdi
		  unsigned int v113; // ebx
		  unsigned int v114; // ebx
		  PlayerLoopSystem *v115; // r8
		  Object *v116; // r9
		  Int32__Array *v117; // rdi
		  unsigned int v118; // ebx
		  unsigned int v119; // ebx
		  unsigned int v120; // ebx
		  unsigned int v121; // ebx
		  unsigned int v122; // ebx
		  PlayerLoopSystem *v123; // r8
		  Object *v124; // r9
		  MethodInfo *v125; // [rsp+20h] [rbp-8h]
		  MethodInfo *v126; // [rsp+20h] [rbp-8h]
		  MethodInfo *v127; // [rsp+20h] [rbp-8h]
		  MethodInfo *v128; // [rsp+20h] [rbp-8h]
		  MethodInfo *v129; // [rsp+20h] [rbp-8h]
		  MethodInfo *v130; // [rsp+20h] [rbp-8h]
		  MethodInfo *v131; // [rsp+20h] [rbp-8h]
		  MethodInfo *v132; // [rsp+20h] [rbp-8h]
		  MethodInfo *v133; // [rsp+20h] [rbp-8h]
		  MethodInfo *v134; // [rsp+20h] [rbp-8h]
		  MethodInfo *v135; // [rsp+20h] [rbp-8h]
		  MethodInfo *v136; // [rsp+20h] [rbp-8h]
		  MethodInfo *v137; // [rsp+20h] [rbp-8h]
		  MethodInfo *v138; // [rsp+20h] [rbp-8h]
		  MethodInfo *v139; // [rsp+20h] [rbp-8h]
		  MethodInfo *v140; // [rsp+20h] [rbp-8h]
		  MethodInfo *v141; // [rsp+20h] [rbp-8h]
		  MethodInfo *v142; // [rsp+20h] [rbp-8h]
		  MethodInfo *v143; // [rsp+20h] [rbp-8h]
		  MethodInfo *v144; // [rsp+20h] [rbp-8h]
		  MethodInfo *v145; // [rsp+20h] [rbp-8h]
		  MethodInfo *v146; // [rsp+20h] [rbp-8h]
		  MethodInfo *v147; // [rsp+20h] [rbp-8h]
		
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CB0 = UnityEngine::Shader::PropertyToID(
		                                                                         (String *)"cb0",
		                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_UnityInstancing_ECSPerDraw = UnityEngine::Shader::PropertyToID(
		                                                                                                (String *)"UnityInstancing_ECSPerDraw",
		                                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_Output0 = UnityEngine::Shader::PropertyToID(
		                                                                             (String *)"_Output0",
		                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_Output1 = UnityEngine::Shader::PropertyToID(
		                                                                             (String *)"_Output1",
		                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_Output2 = UnityEngine::Shader::PropertyToID(
		                                                                             (String *)"_Output2",
		                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_Output3 = UnityEngine::Shader::PropertyToID(
		                                                                             (String *)"_Output3",
		                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_Input0 = UnityEngine::Shader::PropertyToID(
		                                                                            (String *)"_Input0",
		                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_Input1 = UnityEngine::Shader::PropertyToID(
		                                                                            (String *)"_Input1",
		                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_Input2 = UnityEngine::Shader::PropertyToID(
		                                                                            (String *)"_Input2",
		                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_Input3 = UnityEngine::Shader::PropertyToID(
		                                                                            (String *)"_Input3",
		                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_Param0 = UnityEngine::Shader::PropertyToID(
		                                                                            (String *)"_Param0",
		                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_Param1 = UnityEngine::Shader::PropertyToID(
		                                                                            (String *)"_Param1",
		                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_Param2 = UnityEngine::Shader::PropertyToID(
		                                                                            (String *)"_Param2",
		                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_Param3 = UnityEngine::Shader::PropertyToID(
		                                                                            (String *)"_Param3",
		                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RTSize = UnityEngine::Shader::PropertyToID(
		                                                                            (String *)"_RTSize",
		                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_TextureSize = UnityEngine::Shader::PropertyToID(
		                                                                                 (String *)"_TextureSize",
		                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_TerrainDeformResultTex = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_TerrainDeformResultTex",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_TerrainDeformDensityTex = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_TerrainDeformDensityTex",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_TerrainDeformConstDataBuffer = UnityEngine::Shader::PropertyToID(
		                                                                                                  (String *)"TerrainDeformConstDataBuffer",
		                                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_TerrainDeformSplatData = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"SplatData",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_TerrainDeformSplatCtrlAtlas = UnityEngine::Shader::PropertyToID(
		                                                                                                 (String *)"_SplatCtrlAtlas",
		                                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_TerrainDeformSplatIndex = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_SplatIndex",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_TerrainDeformHeightmapAtlas = UnityEngine::Shader::PropertyToID(
		                                                                                                 (String *)"_HeightmapAtlas",
		                                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_TerrainDeformHolemapAtlas = UnityEngine::Shader::PropertyToID(
		                                                                                               (String *)"_HolemapAtlas",
		                                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_TerrainDeformNormalmapAtlas = UnityEngine::Shader::PropertyToID(
		                                                                                                 (String *)"_NormalmapAtlas",
		                                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_TerrainDeformTintColorAtlas = UnityEngine::Shader::PropertyToID(
		                                                                                                 (String *)"_TintColorAtlas",
		                                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_TerrainDeformAlbedoAtlas = UnityEngine::Shader::PropertyToID(
		                                                                                              (String *)"_AlbedoAtlas",
		                                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_TerrainDeformWetnessAtlas = UnityEngine::Shader::PropertyToID(
		                                                                                               (String *)"_WetnessAtlas",
		                                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_TerrainDeformSplatDiffuseArray = UnityEngine::Shader::PropertyToID(
		                                                                                                    (String *)"_Splats",
		                                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_TerrainDeformSplatNormalROArray = UnityEngine::Shader::PropertyToID(
		                                                                                                     (String *)"_Normals",
		                                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_TerrainDeformDepthTex = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_CharacterDepthTex",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_TerrainGroundDistanceTex = UnityEngine::Shader::PropertyToID(
		                                                                                              (String *)"_GroundDistanceTex",
		                                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_TerrainDeformHistoryFillRateTex = UnityEngine::Shader::PropertyToID(
		                                                                                                     (String *)"_HistoryFillRateTex",
		                                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_TerrainDeformCurFillRateTex = UnityEngine::Shader::PropertyToID(
		                                                                                                 (String *)"_CurFillRateTex",
		                                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_TerrainDeformComputeResultTex = UnityEngine::Shader::PropertyToID(
		                                                                                                   (String *)"_ResultTex",
		                                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_TerrainDeformDensityMip4Tex = UnityEngine::Shader::PropertyToID(
		                                                                                                 (String *)"_DensityMip4Tex",
		                                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_TerrainGroundLayerBaseRT = UnityEngine::Shader::PropertyToID(
		                                                                                              (String *)"_TerrainGroundLayerBaseRT",
		                                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_TerrainGroundLayerNormalRT = UnityEngine::Shader::PropertyToID(
		                                                                                                (String *)"_TerrainGroundLayerNormalRT",
		                                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_TerrainGroundLayerWetRT = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_TerrainGroundLayerWetRT",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_TerrainGroundLayerHeightRT = UnityEngine::Shader::PropertyToID(
		                                                                                                (String *)"_TerrainGroundLayerHeightRT",
		                                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RWTerrainGroundLayerBaseRT = UnityEngine::Shader::PropertyToID(
		                                                                                                (String *)"_RWTerrainGroundLayerBaseRT",
		                                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RWTerrainGroundLayerNormalRT = UnityEngine::Shader::PropertyToID(
		                                                                                                  (String *)"_RWTerrainGroundLayerNormalRT",
		                                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RWTerrainGroundLayerWetRT = UnityEngine::Shader::PropertyToID(
		                                                                                               (String *)"_RWTerrainGroundLayerWetRT",
		                                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RWTerrainGroundLayerHeightRT = UnityEngine::Shader::PropertyToID(
		                                                                                                  (String *)"_RWTerrainGroundLayerHeightRT",
		                                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_TerrainGroundLayerConstants = UnityEngine::Shader::PropertyToID(
		                                                                                                 (String *)"_TerrainGroundLayerConstants",
		                                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_TerrainSplatLayerDeformConstants = UnityEngine::Shader::PropertyToID((String *)"_TerrainSplatLayerDeformConstants", 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PerlinNoiseTex = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_PerlinNoiseTex",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SnowDetailNormalTex = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_SnowDetailNormalTex",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->ShadowData = UnityEngine::Shader::PropertyToID(
		                                                                               (String *)"ShadowData",
		                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->ShadowVertexBuffer = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"ShadowVertexBuffer",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CSMShadowmapTex = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_CSMShadowmapTex",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CharacterShadowmapTex = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_CharacterShadowmapTex",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PunctualShadowmapTexArray = UnityEngine::Shader::PropertyToID(
		                                                                                               (String *)"_PunctualShadowmapTexArray",
		                                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CSMShadowRampTex = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_CSMShadowRampTex",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CloudShadowTex = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_CloudShadowTex",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_LowResDirectionalShadow = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_LowResDirectionalShadow",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ScreenSpaceShadowMask = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_ScreenSpaceShadowMask",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HDPLSScreenSpaceShadowMask = UnityEngine::Shader::PropertyToID(
		                                                                                                (String *)"_HDPLSScreenSpaceShadowMask",
		                                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HDPLSTex = UnityEngine::Shader::PropertyToID(
		                                                                              (String *)"_HDPLSTex",
		                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->HDPunctualLightCharacterShadowData = UnityEngine::Shader::PropertyToID((String *)"HDPunctualLightCharacterShadowData", 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ShadowpassVP = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_ShadowpassVP",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ASMIndirectTex = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_ASMIndirectTex",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ASMShadowmapTex = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_ASMShadowmapTex",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CachedShadowmapAtlas = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_CachedShadowmapAtlas",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PunctualLightShadowTexV2 = UnityEngine::Shader::PropertyToID(
		                                                                                              (String *)"_PunctualLightShadowTexV2",
		                                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->LightCookieCB = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"LightCookieCB",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_LightCookie = UnityEngine::Shader::PropertyToID(
		                                                                                 (String *)"_LightCookie",
		                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_LightDataBuffer = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_LightDataBuffer",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_VolumetricFogLightMask = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_VolumetricFogLightMask",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_LightBinningConstants = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_LightBinningConstants",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GPULightBinningConstants = UnityEngine::Shader::PropertyToID(
		                                                                                              (String *)"_GPULightBinningConstants",
		                                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_BinningBuffer = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_BinningBuffer",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GlobalBinningBuffer = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_GlobalBinningBuffer",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_DrawTileArgsBuffer = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_DrawTileArgs",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_DrawTileArgsBufferNextFrame = UnityEngine::Shader::PropertyToID(
		                                                                                                 (String *)"_DrawTileArgsNextFrame",
		                                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_TileInstanceIndicesBuffer = UnityEngine::Shader::PropertyToID(
		                                                                                               (String *)"_TileInstanceIndices",
		                                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PunctualLights = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_PunctualLights",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PunctualLightCount = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_PunctualLightCount",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_NearPlaneParams = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_NearPlaneParams",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_NearPlaneDist = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_NearPlaneDist",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ZBinSlice = UnityEngine::Shader::PropertyToID(
		                                                                               (String *)"_ZBinSlice",
		                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_NumZBinSlices = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_NumZBinSlice",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_OutLightBinningXYMasks = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_OutLightBinningXYMasks",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_OutLightBinningZMasks = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_OutLightBinningZMasks",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PerLightIndex = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_PerLightIndex",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_TileSize = UnityEngine::Shader::PropertyToID(
		                                                                              (String *)"_TileSize",
		                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_NumTiles = UnityEngine::Shader::PropertyToID(
		                                                                              (String *)"_NumTiles",
		                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_NumTilesX = UnityEngine::Shader::PropertyToID(
		                                                                               (String *)"_NumTilesX",
		                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_NumTilesY = UnityEngine::Shader::PropertyToID(
		                                                                               (String *)"_NumTilesY",
		                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_StencilMask = UnityEngine::Shader::PropertyToID(
		                                                                                 (String *)"_StencilMask",
		                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_StencilRef = UnityEngine::Shader::PropertyToID(
		                                                                                (String *)"_StencilRef",
		                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_StencilCmp = UnityEngine::Shader::PropertyToID(
		                                                                                (String *)"_StencilCmp",
		                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_InputDepth = UnityEngine::Shader::PropertyToID(
		                                                                                (String *)"_InputDepthTexture",
		                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ClearColor = UnityEngine::Shader::PropertyToID(
		                                                                                (String *)"_ClearColor",
		                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SrcBlend = UnityEngine::Shader::PropertyToID(
		                                                                              (String *)"_SrcBlend",
		                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_DstBlend = UnityEngine::Shader::PropertyToID(
		                                                                              (String *)"_DstBlend",
		                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_MultiscatteringLUT = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_MultiscatteringLUT",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_DecalWorldToObject = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_DecalWorldToObject",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_DecalPackedData = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_DecalPackedData",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_DrawOrder = UnityEngine::Shader::PropertyToID(
		                                                                               (String *)"_DrawOrder",
		                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_WorldSpaceCameraPos = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_WorldSpaceCameraPos",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PrevCamPosRWS = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_PrevCamPosRWS",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ViewMatrix = UnityEngine::Shader::PropertyToID(
		                                                                                (String *)"_ViewMatrix",
		                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CameraViewMatrix = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_CameraViewMatrix",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_InvViewMatrix = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_InvViewMatrix",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ProjMatrix = UnityEngine::Shader::PropertyToID(
		                                                                                (String *)"_ProjMatrix",
		                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_InvProjMatrix = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_InvProjMatrix",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_NonJitteredViewProjMatrix = UnityEngine::Shader::PropertyToID(
		                                                                                               (String *)"_NonJitteredViewProjMatrix",
		                                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ViewProjMatrix = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_ViewProjMatrix",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CameraViewProjMatrix = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_CameraViewProjMatrix",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_InvViewProjMatrix = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_InvViewProjMatrix",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ZBufferParams = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_ZBufferParams",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ProjectionParams = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_ProjectionParams",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->unity_OrthoParams = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"unity_OrthoParams",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_InvProjParam = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_InvProjParam",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ScreenSize = UnityEngine::Shader::PropertyToID(
		                                                                                (String *)"_ScreenSize",
		                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HalfScreenSize = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_HalfScreenSize",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ScreenParams = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_ScreenParams",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PrevNonJitteredViewProjMatrix = UnityEngine::Shader::PropertyToID(
		                                                                                                   (String *)"_PrevNonJitteredViewProjMatrix",
		                                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PrevNonJitteredInvViewProjMatrix = UnityEngine::Shader::PropertyToID((String *)"_PrevNonJitteredInvViewProjMatrix", 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FrustumPlanes = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_FrustumPlanes",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PreviousSceneColorTexture = UnityEngine::Shader::PropertyToID(
		                                                                                               (String *)"_PreviousSceneColorTexture",
		                                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SceneColorTexture = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_SceneColorTexture",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SceneDepthTexture = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_SceneDepthTexture",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_LowSceneDepthTexture = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_LowSceneDepthTexture",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_LowResColorTexture = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_LowResColorTexture",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_LowResMVTexture = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_LowResMVTexture",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_DepthTextureWithWater = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_DepthTextureWithWater",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_UIColorTexture = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_UIColorTexture",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ReflectionProbeTextureArray = UnityEngine::Shader::PropertyToID(
		                                                                                                 (String *)"_ReflectionProbeTextureArray",
		                                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_IndirectAmbientOcclusionTexture = UnityEngine::Shader::PropertyToID(
		                                                                                                     (String *)"_IndirectAmbientOcclusionTexture",
		                                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CharMaxCubemap = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_CharMaxCubemap",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CharacterEnvColorTexture = UnityEngine::Shader::PropertyToID(
		                                                                                              (String *)"_CharacterEnvColorTexture",
		                                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CharacterRainEffectTex = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_CharacterRainEffectTex",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CharacterRainStreakTex = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_CharacterRainStreakTex",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CharacterRainFaceDripTex = UnityEngine::Shader::PropertyToID(
		                                                                                              (String *)"_CharacterRainFaceDripTex",
		                                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CharacterRainFaceDropletTex = UnityEngine::Shader::PropertyToID(
		                                                                                                 (String *)"_CharacterRainFaceDropletTex",
		                                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CharacterSnowEffectTex = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_CharacterSnowEffectTex",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_DotDitherTexture = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_DotDitherTexture",
		                                                                                      0LL);
		  v1 = (Int32__Array *)sub_18003B220(TypeInfo::System::Int32, 8LL);
		  v2 = UnityEngine::Shader::PropertyToID((String *)"_GBufferTexture0", 0LL);
		  sub_180003640(v1);
		  sub_180003660(v1, 0LL, v2);
		  v3 = UnityEngine::Shader::PropertyToID((String *)"_GBufferTexture1", 0LL);
		  sub_180003640(v1);
		  sub_180003660(v1, 1LL, v3);
		  v4 = UnityEngine::Shader::PropertyToID((String *)"_GBufferTexture2", 0LL);
		  sub_180003640(v1);
		  sub_180003660(v1, 2LL, v4);
		  v5 = UnityEngine::Shader::PropertyToID((String *)"_GBufferTexture3", 0LL);
		  sub_180003640(v1);
		  sub_180003660(v1, 3LL, v5);
		  v6 = UnityEngine::Shader::PropertyToID((String *)"_GBufferTexture4", 0LL);
		  sub_180003640(v1);
		  sub_180003660(v1, 4LL, v6);
		  v7 = UnityEngine::Shader::PropertyToID((String *)"_GBufferTexture5", 0LL);
		  sub_180003640(v1);
		  sub_180003660(v1, 5LL, v7);
		  v8 = UnityEngine::Shader::PropertyToID((String *)"_GBufferTexture6", 0LL);
		  sub_180003640(v1);
		  sub_180003660(v1, 6LL, v8);
		  v9 = UnityEngine::Shader::PropertyToID((String *)"_GBufferTexture7", 0LL);
		  sub_180003640(v1);
		  sub_180003660(v1, 7LL, v9);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GBufferTexture = v1;
		  sub_180004FC0(
		    (ILFixDynamicMethodWrapper_38 *)&TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GBufferTexture,
		    (VirtualMachine *)v1,
		    v10,
		    v11,
		    v125);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CurrPyramidTexture = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_CurrPyramidTexture",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CurrPyramidTexture0 = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_CurrPyramidTexture0",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CurrPyramidTexture1 = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_CurrPyramidTexture1",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CurrPyramidTexture2 = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_CurrPyramidTexture2",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CurrPyramidTexture3 = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_CurrPyramidTexture3",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CurrPyramidTexture4 = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_CurrPyramidTexture4",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CurrPyramidTexture5 = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_CurrPyramidTexture5",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CurrPyramidTexture6 = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_CurrPyramidTexture6",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GlobalAtomicBuffer = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_GlobalAtomicBuffer",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_DepthPyramidData = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_DepthPyramidData",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CopyDepthPyramidData = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_CopyDepthPyramidData",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HZBTexture0 = UnityEngine::Shader::PropertyToID(
		                                                                                 (String *)"_HZBTexture0",
		                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HZBTexture1 = UnityEngine::Shader::PropertyToID(
		                                                                                 (String *)"_HZBTexture1",
		                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HZBTexture2 = UnityEngine::Shader::PropertyToID(
		                                                                                 (String *)"_HZBTexture2",
		                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HZBTexture3 = UnityEngine::Shader::PropertyToID(
		                                                                                 (String *)"_HZBTexture3",
		                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HZBBuildData = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_HZBBuildData",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainChunkTransform = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_Transform",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainChunkParam0 = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_ChunkParam0",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainUVTransform = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_UVTransform",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainRTOffset = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_RTOffset",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainDecalInstanceInfos = UnityEngine::Shader::PropertyToID(
		                                                                                                 (String *)"_DecalInstanceInfos",
		                                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainDecalInstanceData = UnityEngine::Shader::PropertyToID(
		                                                                                                (String *)"_DecalPerInstanceData",
		                                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainFeedbackViewProj = UnityEngine::Shader::PropertyToID(
		                                                                                               (String *)"_FeedbackViewProj",
		                                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainCompressCacheParam0 = UnityEngine::Shader::PropertyToID(
		                                                                                                  (String *)"_CacheParams0",
		                                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainPerTerrain = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"PerTerrainData",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainPerTerrainFrame = UnityEngine::Shader::PropertyToID(
		                                                                                              (String *)"PerTerrainFrameData",
		                                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainLightmap = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_TerrainLightmap",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainLightmapInd = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_TerrainLightmapInd",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainControlMap = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_ControlMap",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainSplatIndexMap = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_SplatIndexMap",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainSplats = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_Splats",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainNormals = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_Normals",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainTerrainNormalmapTexture = UnityEngine::Shader::PropertyToID((String *)"_TerrainNormalmapTexture", 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainPhysicalBase = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_PhysicalBase",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainPhysicalNormal = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_PhysicalNormal",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainIndirectTexture = UnityEngine::Shader::PropertyToID(
		                                                                                              (String *)"_IndirectTex",
		                                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainColorVariationTex = UnityEngine::Shader::PropertyToID(
		                                                                                                (String *)"_ColorVariationTex",
		                                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainDecalDiffuseTexArray = UnityEngine::Shader::PropertyToID(
		                                                                                                   (String *)"_DecalDiffuse",
		                                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainDecalNormalMROTexArray = UnityEngine::Shader::PropertyToID(
		                                                                                                     (String *)"_DecalNormalMRO",
		                                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainHeightmap = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_Heightmap",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainDeformableControlMap = UnityEngine::Shader::PropertyToID(
		                                                                                                   (String *)"_DeformableControlMap",
		                                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainReflectionProbeTex = UnityEngine::Shader::PropertyToID(
		                                                                                                 (String *)"_TerrainSpecCube0",
		                                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainCommonInput = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_Input",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainCommonOutput = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_Output",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainDepthBuffer = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_TerrainDepthBuffer",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainRT0 = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_UnityTerrainRT0",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainRT1 = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_UnityTerrainRT1",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainRT2 = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_UnityTerrainRT2",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HZBTexture = UnityEngine::Shader::PropertyToID(
		                                                                                (String *)"_HZBTexture",
		                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGHiZInput = UnityEngine::Shader::PropertyToID(
		                                                                                (String *)"_Input",
		                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGHiZOutput0 = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_Output0",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGHiZOutput1 = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_Output1",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGHiZOutput2 = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_Output2",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGHiZOutput3 = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_Output3",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGHiZMipChain = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_HiZMipChain",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGHiZRTSize = UnityEngine::Shader::PropertyToID(
		                                                                                 (String *)"_HiZRTSize",
		                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PerPassConstants = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_PerPassConstants",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PerPassConstantsToBe = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_PerPassConstantsToBe",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ShaderVariablesGlobal = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"ShaderVariablesGlobal",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_TransformVariables = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_TransformVariables",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_UIRenderingConstants = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_UIRenderingConstants",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ShaderVariablesDebugDisplay = UnityEngine::Shader::PropertyToID(
		                                                                                                 (String *)"ShaderVariablesDebugDisplay",
		                                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GeneralGPUParticleSystemAttributes = UnityEngine::Shader::PropertyToID((String *)"_GeneralGPUParticleSystemAttributes", 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GPUParticleSystemAttributes = UnityEngine::Shader::PropertyToID(
		                                                                                                 (String *)"_GPUParticleSystemAttributes",
		                                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PerFrameVariables = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_PerFrameVariables",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PerInstanceBuffer = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_PerInstanceBuffer",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_MergePassConstants = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_MergePassConstants",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ParticleAttributes = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_ParticleAttributes",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_DeadCount = UnityEngine::Shader::PropertyToID(
		                                                                               (String *)"_DeadCount",
		                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_DataForEmitter = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_DataForEmitter",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_LiveCount = UnityEngine::Shader::PropertyToID(
		                                                                               (String *)"_LiveCount",
		                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_DeadList = UnityEngine::Shader::PropertyToID(
		                                                                              (String *)"_DeadList",
		                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_LiveList = UnityEngine::Shader::PropertyToID(
		                                                                              (String *)"_LiveList",
		                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_InputLiveList = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_InputLiveList",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SortedLiveList = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_SortedLiveList",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_DrawIndirectArg = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_DrawIndirectArg",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SceneNormal = UnityEngine::Shader::PropertyToID(
		                                                                                 (String *)"_SceneNormal",
		                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_DispatchSize = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_DispatchSize",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_InstanceCount = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_InstanceCount",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CleanupOffset = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_CleanupOffset",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_DepthOnlyRT = UnityEngine::Shader::PropertyToID(
		                                                                                 (String *)"_DepthOnlyRT",
		                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GPUEventSentCount = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_GPUEventSentCount",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GPUEventConsumedCount = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_GPUEventConsumedCount",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GPUEventBuffer = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_GPUEventBuffer",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_BlitTexture = UnityEngine::Shader::PropertyToID(
		                                                                                 (String *)"_BlitTexture",
		                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_BlitScaleBias = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_BlitScaleBias",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_BlitMipLevel = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_BlitMipLevel",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_BlitTexArraySlice = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_BlitTexArraySlice",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_BlurData = UnityEngine::Shader::PropertyToID(
		                                                                              (String *)"_BlurData",
		                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GaussianBlurTexture = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_GaussianBlurTexture",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CameraDepthTexture = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_CameraDepthTexture",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FoliageOccluderStateArray = UnityEngine::Shader::PropertyToID(
		                                                                                               (String *)"_FoliageOccluderStateArray",
		                                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FoliageOccluderScaleParam = UnityEngine::Shader::PropertyToID(
		                                                                                               (String *)"_FoliageOccluderScaleParam",
		                                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FoliageOcclusionMask = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_FoliageOcclusionMask",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FoliageOccluderRenderMask = UnityEngine::Shader::PropertyToID(
		                                                                                               (String *)"_FoliageOccluderRenderMask",
		                                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FoliageOccluderFinalMask = UnityEngine::Shader::PropertyToID(
		                                                                                              (String *)"_FoliageOccluderFinalMask",
		                                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PrevFoliageOccluderTex = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_PrevFoliageOccluderTex",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FoliageLODFadeValue = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_FoliageLODFadeValue",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FoliageOccluderCameraPosParam = UnityEngine::Shader::PropertyToID(
		                                                                                                   (String *)"_FoliageOccluderCameraPosParam",
		                                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ClothDataClearCB = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"ClothDataClearConstBuffer",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ClothDataUploadCB = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"ClothDataUploadConstBuffer",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ClothGroupUploadDataMapBuffer = UnityEngine::Shader::PropertyToID(
		                                                                                                   (String *)"ClothGroupUploadDataMapBuffer",
		                                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_InputClothMetaDataBuffer = UnityEngine::Shader::PropertyToID(
		                                                                                              (String *)"InputClothMetaDataBuffer",
		                                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_InputClothNodeDataBuffer1 = UnityEngine::Shader::PropertyToID(
		                                                                                               (String *)"InputClothNodeDataBuffer1",
		                                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_InputClothNodeDataBuffer2 = UnityEngine::Shader::PropertyToID(
		                                                                                               (String *)"InputClothNodeDataBuffer2",
		                                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_InputClothBatchMetaDataBuffer = UnityEngine::Shader::PropertyToID(
		                                                                                                   (String *)"InputClothBatchMetaDataBuffer",
		                                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_InputClothBatchCacheMapBuffer = UnityEngine::Shader::PropertyToID(
		                                                                                                   (String *)"InputClothBatchCacheMapBuffer",
		                                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_OutputClothNodeDataBuffer = UnityEngine::Shader::PropertyToID(
		                                                                                               (String *)"_OutputClothNodeDataBuffer",
		                                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_OutputClothMetaDataBuffer = UnityEngine::Shader::PropertyToID(
		                                                                                               (String *)"_OutputClothMetaDataBuffer",
		                                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_OutputClothBatchMetaDataBuffer = UnityEngine::Shader::PropertyToID(
		                                                                                                    (String *)"_OutputClothBatchMetaDataBuffer",
		                                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_OutputClothBatchCacheMapBuffer = UnityEngine::Shader::PropertyToID(
		                                                                                                    (String *)"_OutputClothBatchCacheMapBuffer",
		                                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_OutputClothSkeletonDataBuffer = UnityEngine::Shader::PropertyToID(
		                                                                                                   (String *)"_OutputClothSkeletonDataBuffer",
		                                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ClothConstDataBuffer = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"ClothConstDataBuffer",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ClothNodeDataBuffer = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_ClothNodeDataBuffer",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ClothMetaDataBuffer = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_ClothMetaDataBuffer",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ClothBatchMetaDataBuffer = UnityEngine::Shader::PropertyToID(
		                                                                                              (String *)"_ClothBatchMetaDataBuffer",
		                                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ClothBatchCacheMapBuffer = UnityEngine::Shader::PropertyToID(
		                                                                                              (String *)"_ClothBatchCacheMapBuffer",
		                                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ClothSkeletonDataBuffer = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_ClothSkeletonDataBuffer",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_AtmosphereLutConstants = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_AtmosphereLutConstants",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_TransmittanceLut = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_TransmittanceLut",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_TransmittanceLutUAV = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_TransmittanceLutUAV",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_MultiScatteredLuminanceLut = UnityEngine::Shader::PropertyToID(
		                                                                                                (String *)"_MultiScatteredLuminanceLut",
		                                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_MultiScatteredLuminanceLutUAV = UnityEngine::Shader::PropertyToID(
		                                                                                                   (String *)"_MultiScatteredLuminanceLutUAV",
		                                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SkyViewLut = UnityEngine::Shader::PropertyToID(
		                                                                                (String *)"_SkyViewLut",
		                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SkyViewLutUAV = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_SkyViewLutUAV",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_VolumetricFogVBufferA = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_VolumetricFogVBufferA",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_VolumetricFogVBufferB = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_VolumetricFogVBufferB",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_LightScattering = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_LightScattering",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_LightScatteringHistory = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_LightScatteringHistory",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RWIntegratedLightScattering = UnityEngine::Shader::PropertyToID(
		                                                                                                 (String *)"_RWIntegratedLightScattering",
		                                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_IntegratedLightScattering = UnityEngine::Shader::PropertyToID(
		                                                                                               (String *)"_IntegratedLightScattering",
		                                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_VolumetricLight3DNoise = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_VolumetricLight3DNoise",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_VolumetricLight3DNoisePerturb = UnityEngine::Shader::PropertyToID(
		                                                                                                   (String *)"_VolumetricLight3DNoisePerturb",
		                                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_VolumetricFogGridInjectionConstants = UnityEngine::Shader::PropertyToID((String *)"_VolumetricFogGridInjectionConstants", 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_VolumetricFogLightScatteringConstants = UnityEngine::Shader::PropertyToID((String *)"_VolumetricFogLightScatteringConstants", 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_VoxelizationPassIndex = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_VoxelizationPassIndex",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_VoxelizationClosestSliceIndex = UnityEngine::Shader::PropertyToID(
		                                                                                                   (String *)"_VoxelizationClosestSliceIndex",
		                                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_VoxelizationClipRatio = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_VoxelizationClipRatio",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_VoxelizationVolumePos = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_VoxelizationVolumePos",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_VoxelizationVolumeRadius = UnityEngine::Shader::PropertyToID(
		                                                                                              (String *)"_VoxelizationVolumeRadius",
		                                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_VoxelizationViewSpacePos = UnityEngine::Shader::PropertyToID(
		                                                                                              (String *)"_VoxelizationViewSpacePos",
		                                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_VoxelizationWorldToObject = UnityEngine::Shader::PropertyToID(
		                                                                                               (String *)"_VoxelizationWorldToObject",
		                                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_VoxelizationFrameJitterOffset = UnityEngine::Shader::PropertyToID(
		                                                                                                   (String *)"_VoxelizationFrameJitterOffset",
		                                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_VoxelizationViewToVolumeClip = UnityEngine::Shader::PropertyToID(
		                                                                                                  (String *)"_VoxelizationViewToVolumeClip",
		                                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_Tint = UnityEngine::Shader::PropertyToID(
		                                                                          (String *)"_Tint",
		                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_Exposure = UnityEngine::Shader::PropertyToID(
		                                                                              (String *)"_Exposure",
		                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_Rotation = UnityEngine::Shader::PropertyToID(
		                                                                              (String *)"_Rotation",
		                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_Tex = UnityEngine::Shader::PropertyToID(
		                                                                         (String *)"_Tex",
		                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SunDiscParam0 = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_SunDiscParam0",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SunDiscParam1 = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_SunDiscParam1",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SunDiscParam2 = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_SunDiscParam2",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SkyBoxStarParam0 = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_SkyBoxStarParam0",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SkyBoxStarParam1 = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_SkyBoxStarParam1",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SkyBoxStarParam2 = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_SkyBoxStarParam2",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SkyBoxStarParam3 = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_SkyBoxStarParam3",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SkyBoxStarParam4 = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_SkyBoxStarParam4",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SkyBoxStarParam5 = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_SkyBoxStarParam5",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SkyBoxStarParam6 = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_SkyBoxStarParam6",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SkyBoxStarTexture = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_SkyboxStarMap",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SkyBoxStarDensityTexture = UnityEngine::Shader::PropertyToID(
		                                                                                              (String *)"_SkyboxStarDensityMap",
		                                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SkyBoxNebulaTexture = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_SkyboxNebulaTexture",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CloudTexture = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_CloudTexture",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CloudFlowMap = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_CloudFlowMap",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CloudParam = UnityEngine::Shader::PropertyToID(
		                                                                                (String *)"_CloudParam",
		                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CloudFlowParam = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_CloudFlowParam",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CloudOpacities = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_CloudOpacities",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CloudTint = UnityEngine::Shader::PropertyToID(
		                                                                               (String *)"_CloudTint",
		                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_Size = UnityEngine::Shader::PropertyToID(
		                                                                          (String *)"_Size",
		                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_Source = UnityEngine::Shader::PropertyToID(
		                                                                            (String *)"_Source",
		                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SourceMip = UnityEngine::Shader::PropertyToID(
		                                                                               (String *)"_SourceMip",
		                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SrcOffsetAndLimit = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_SrcOffsetAndLimit",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SrcScaleBias = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_SrcScaleBias",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SrcUvLimits = UnityEngine::Shader::PropertyToID(
		                                                                                 (String *)"_SrcUvLimits",
		                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_DstOffset = UnityEngine::Shader::PropertyToID(
		                                                                               (String *)"_DstOffset",
		                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_DepthMipChain = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_DepthMipChain",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RingParams = UnityEngine::Shader::PropertyToID(
		                                                                                (String *)"_RingParams",
		                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RingUpWithBelow = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_RingUpWithBelow",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RingFoward = UnityEngine::Shader::PropertyToID(
		                                                                                (String *)"_RingFoward",
		                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RingRight = UnityEngine::Shader::PropertyToID(
		                                                                               (String *)"_RingRight",
		                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RingColor = UnityEngine::Shader::PropertyToID(
		                                                                               (String *)"_RingColor",
		                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RingAlbedoTexture = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_RingAlbedoTexture",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PlanetCenterViewDir = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_PlanetCenterViewDir",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_IncidentLightDir = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_IncidentLightDir",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PlanetParams = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_PlanetParams",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RingTex = UnityEngine::Shader::PropertyToID(
		                                                                             (String *)"_RingTex",
		                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RingColorAlpha = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_RingColorAlpha",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PlanetAtmosphereParams = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_PlanetAtmosphereParams",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PlanetAtmosphereParams2 = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_PlanetAtmosphereParams2",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PlanetAtmosphereParams3 = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_PlanetAtmosphereParams3",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_AtmosphereRTTex = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_AtmosphereRTTex",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PlanetUpWs = UnityEngine::Shader::PropertyToID(
		                                                                                (String *)"_PlanetUpWs",
		                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PlanetForwardWs = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_PlanetForwardWs",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PlanetRightWs = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_PlanetRightWs",
		                                                                                   0LL);
		  v12 = (Int32__Array *)sub_18003B220(TypeInfo::System::Int32, 2LL);
		  v13 = UnityEngine::Shader::PropertyToID((String *)"_PlanetInView", 0LL);
		  sub_180003640(v12);
		  sub_180003660(v12, 0LL, v13);
		  v14 = UnityEngine::Shader::PropertyToID((String *)"_TalosInView", 0LL);
		  sub_180003640(v12);
		  sub_180003660(v12, 1LL, v14);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PlanetsInView = v12;
		  sub_180004FC0(
		    (ILFixDynamicMethodWrapper_38 *)&TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PlanetsInView,
		    (VirtualMachine *)v12,
		    v15,
		    v16,
		    v126);
		  v17 = (Int32__Array *)sub_18003B220(TypeInfo::System::Int32, 2LL);
		  v18 = UnityEngine::Shader::PropertyToID((String *)"_PlanetCenterPos0", 0LL);
		  sub_180003640(v17);
		  sub_180003660(v17, 0LL, v18);
		  v19 = UnityEngine::Shader::PropertyToID((String *)"_PlanetCenterPos1", 0LL);
		  sub_180003640(v17);
		  sub_180003660(v17, 1LL, v19);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PlanetCenterPos01 = v17;
		  sub_180004FC0(
		    (ILFixDynamicMethodWrapper_38 *)&TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PlanetCenterPos01,
		    (VirtualMachine *)v17,
		    v20,
		    v21,
		    v127);
		  v22 = (Int32__Array *)sub_18003B220(TypeInfo::System::Int32, 2LL);
		  v23 = UnityEngine::Shader::PropertyToID((String *)"_PlanetCenterViewDir0", 0LL);
		  sub_180003640(v22);
		  sub_180003660(v22, 0LL, v23);
		  v24 = UnityEngine::Shader::PropertyToID((String *)"_PlanetCenterViewDir1", 0LL);
		  sub_180003640(v22);
		  sub_180003660(v22, 1LL, v24);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PlanetCenterViewDir01 = v22;
		  sub_180004FC0(
		    (ILFixDynamicMethodWrapper_38 *)&TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PlanetCenterViewDir01,
		    (VirtualMachine *)v22,
		    v25,
		    v26,
		    v128);
		  v27 = (Int32__Array *)sub_18003B220(TypeInfo::System::Int32, 2LL);
		  v28 = UnityEngine::Shader::PropertyToID((String *)"_IncidentLightDir0", 0LL);
		  sub_180003640(v27);
		  sub_180003660(v27, 0LL, v28);
		  v29 = UnityEngine::Shader::PropertyToID((String *)"_IncidentLightDir1", 0LL);
		  sub_180003640(v27);
		  sub_180003660(v27, 1LL, v29);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_IncidentLightDir01 = v27;
		  sub_180004FC0(
		    (ILFixDynamicMethodWrapper_38 *)&TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_IncidentLightDir01,
		    (VirtualMachine *)v27,
		    v30,
		    v31,
		    v129);
		  v32 = (Int32__Array *)sub_18003B220(TypeInfo::System::Int32, 2LL);
		  v33 = UnityEngine::Shader::PropertyToID((String *)"_PlanetParams0", 0LL);
		  sub_180003640(v32);
		  sub_180003660(v32, 0LL, v33);
		  v34 = UnityEngine::Shader::PropertyToID((String *)"_PlanetParams1", 0LL);
		  sub_180003640(v32);
		  sub_180003660(v32, 1LL, v34);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PlanetParams01 = v32;
		  sub_180004FC0(
		    (ILFixDynamicMethodWrapper_38 *)&TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PlanetParams01,
		    (VirtualMachine *)v32,
		    v35,
		    v36,
		    v130);
		  v37 = (Int32__Array *)sub_18003B220(TypeInfo::System::Int32, 2LL);
		  v38 = UnityEngine::Shader::PropertyToID((String *)"_PlanetUpWs0", 0LL);
		  sub_180003640(v37);
		  sub_180003660(v37, 0LL, v38);
		  v39 = UnityEngine::Shader::PropertyToID((String *)"_PlanetUpWs1", 0LL);
		  sub_180003640(v37);
		  sub_180003660(v37, 1LL, v39);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PlanetUpWs01 = v37;
		  sub_180004FC0(
		    (ILFixDynamicMethodWrapper_38 *)&TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PlanetUpWs01,
		    (VirtualMachine *)v37,
		    v40,
		    v41,
		    v131);
		  v42 = (Int32__Array *)sub_18003B220(TypeInfo::System::Int32, 2LL);
		  v43 = UnityEngine::Shader::PropertyToID((String *)"_PlanetForwardWs0", 0LL);
		  sub_180003640(v42);
		  sub_180003660(v42, 0LL, v43);
		  v44 = UnityEngine::Shader::PropertyToID((String *)"_PlanetForwardWs1", 0LL);
		  sub_180003640(v42);
		  sub_180003660(v42, 1LL, v44);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PlanetForwardWs01 = v42;
		  sub_180004FC0(
		    (ILFixDynamicMethodWrapper_38 *)&TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PlanetForwardWs01,
		    (VirtualMachine *)v42,
		    v45,
		    v46,
		    v132);
		  v47 = (Int32__Array *)sub_18003B220(TypeInfo::System::Int32, 2LL);
		  v48 = UnityEngine::Shader::PropertyToID((String *)"_PlanetRightWs0", 0LL);
		  sub_180003640(v47);
		  sub_180003660(v47, 0LL, v48);
		  v49 = UnityEngine::Shader::PropertyToID((String *)"_PlanetRightWs1", 0LL);
		  sub_180003640(v47);
		  sub_180003660(v47, 1LL, v49);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PlanetRightWs01 = v47;
		  sub_180004FC0(
		    (ILFixDynamicMethodWrapper_38 *)&TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PlanetRightWs01,
		    (VirtualMachine *)v47,
		    v50,
		    v51,
		    v133);
		  v52 = (Int32__Array *)sub_18003B220(TypeInfo::System::Int32, 2LL);
		  v53 = UnityEngine::Shader::PropertyToID((String *)"_PlanetColor0", 0LL);
		  sub_180003640(v52);
		  sub_180003660(v52, 0LL, v53);
		  v54 = UnityEngine::Shader::PropertyToID((String *)"_PlanetColor1", 0LL);
		  sub_180003640(v52);
		  sub_180003660(v52, 1LL, v54);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PlanetColor01 = v52;
		  sub_180004FC0(
		    (ILFixDynamicMethodWrapper_38 *)&TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PlanetColor01,
		    (VirtualMachine *)v52,
		    v55,
		    v56,
		    v134);
		  v57 = (Int32__Array *)sub_18003B220(TypeInfo::System::Int32, 2LL);
		  v58 = UnityEngine::Shader::PropertyToID((String *)"_RingShadowSoftness0", 0LL);
		  sub_180003640(v57);
		  sub_180003660(v57, 0LL, v58);
		  v59 = UnityEngine::Shader::PropertyToID((String *)"_RingShadowSoftness1", 0LL);
		  sub_180003640(v57);
		  sub_180003660(v57, 1LL, v59);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RingShadowSoftness01 = v57;
		  sub_180004FC0(
		    (ILFixDynamicMethodWrapper_38 *)&TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RingShadowSoftness01,
		    (VirtualMachine *)v57,
		    v60,
		    v61,
		    v135);
		  v62 = (Int32__Array *)sub_18003B220(TypeInfo::System::Int32, 2LL);
		  v63 = UnityEngine::Shader::PropertyToID((String *)"_RingColorAlpha0", 0LL);
		  sub_180003640(v62);
		  sub_180003660(v62, 0LL, v63);
		  v64 = UnityEngine::Shader::PropertyToID((String *)"_RingColorAlpha1", 0LL);
		  sub_180003640(v62);
		  sub_180003660(v62, 1LL, v64);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RingColorAlpha01 = v62;
		  sub_180004FC0(
		    (ILFixDynamicMethodWrapper_38 *)&TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RingColorAlpha01,
		    (VirtualMachine *)v62,
		    v65,
		    v66,
		    v136);
		  v67 = (Int32__Array *)sub_18003B220(TypeInfo::System::Int32, 2LL);
		  v68 = UnityEngine::Shader::PropertyToID((String *)"_PlanetEmissive0", 0LL);
		  sub_180003640(v67);
		  sub_180003660(v67, 0LL, v68);
		  v69 = UnityEngine::Shader::PropertyToID((String *)"_PlanetEmissive1", 0LL);
		  sub_180003640(v67);
		  sub_180003660(v67, 1LL, v69);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PlanetEmissive01 = v67;
		  sub_180004FC0(
		    (ILFixDynamicMethodWrapper_38 *)&TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PlanetEmissive01,
		    (VirtualMachine *)v67,
		    v70,
		    v71,
		    v137);
		  v72 = (Int32__Array *)sub_18003B220(TypeInfo::System::Int32, 2LL);
		  v73 = UnityEngine::Shader::PropertyToID((String *)"_StarNdlSharp0", 0LL);
		  sub_180003640(v72);
		  sub_180003660(v72, 0LL, v73);
		  v74 = UnityEngine::Shader::PropertyToID((String *)"_StarNdlSharp1", 0LL);
		  sub_180003640(v72);
		  sub_180003660(v72, 1LL, v74);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_StarNdlSharp01 = v72;
		  sub_180004FC0(
		    (ILFixDynamicMethodWrapper_38 *)&TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_StarNdlSharp01,
		    (VirtualMachine *)v72,
		    v75,
		    v76,
		    v138);
		  v77 = (Int32__Array *)sub_18003B220(TypeInfo::System::Int32, 2LL);
		  v78 = UnityEngine::Shader::PropertyToID((String *)"_StarBackFaceAlpha0", 0LL);
		  sub_180003640(v77);
		  sub_180003660(v77, 0LL, v78);
		  v79 = UnityEngine::Shader::PropertyToID((String *)"_StarBackFaceAlpha1", 0LL);
		  sub_180003640(v77);
		  sub_180003660(v77, 1LL, v79);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_StarBackFaceAlpha01 = v77;
		  sub_180004FC0(
		    (ILFixDynamicMethodWrapper_38 *)&TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_StarBackFaceAlpha01,
		    (VirtualMachine *)v77,
		    v80,
		    v81,
		    v139);
		  v82 = (Int32__Array *)sub_18003B220(TypeInfo::System::Int32, 2LL);
		  v83 = UnityEngine::Shader::PropertyToID((String *)"_PlanetBaseMap0", 0LL);
		  sub_180003640(v82);
		  sub_180003660(v82, 0LL, v83);
		  v84 = UnityEngine::Shader::PropertyToID((String *)"_PlanetBaseMap1", 0LL);
		  sub_180003640(v82);
		  sub_180003660(v82, 1LL, v84);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PlanetBaseMap01 = v82;
		  sub_180004FC0(
		    (ILFixDynamicMethodWrapper_38 *)&TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PlanetBaseMap01,
		    (VirtualMachine *)v82,
		    v85,
		    v86,
		    v140);
		  v87 = (Int32__Array *)sub_18003B220(TypeInfo::System::Int32, 2LL);
		  v88 = UnityEngine::Shader::PropertyToID((String *)"_PlanetEmiMap0", 0LL);
		  sub_180003640(v87);
		  sub_180003660(v87, 0LL, v88);
		  v89 = UnityEngine::Shader::PropertyToID((String *)"_PlanetEmiMap1", 0LL);
		  sub_180003640(v87);
		  sub_180003660(v87, 1LL, v89);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PlanetEmiMap01 = v87;
		  sub_180004FC0(
		    (ILFixDynamicMethodWrapper_38 *)&TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PlanetEmiMap01,
		    (VirtualMachine *)v87,
		    v90,
		    v91,
		    v141);
		  v92 = (Int32__Array *)sub_18003B220(TypeInfo::System::Int32, 2LL);
		  v93 = UnityEngine::Shader::PropertyToID((String *)"_PlanetRingTex0", 0LL);
		  sub_180003640(v92);
		  sub_180003660(v92, 0LL, v93);
		  v94 = UnityEngine::Shader::PropertyToID((String *)"_PlanetRingTex1", 0LL);
		  sub_180003640(v92);
		  sub_180003660(v92, 1LL, v94);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PlanetRingTex01 = v92;
		  sub_180004FC0(
		    (ILFixDynamicMethodWrapper_38 *)&TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PlanetRingTex01,
		    (VirtualMachine *)v92,
		    v95,
		    v96,
		    v142);
		  v97 = (Int32__Array *)sub_18003B220(TypeInfo::System::Int32, 2LL);
		  v98 = UnityEngine::Shader::PropertyToID((String *)"_PlanetBlendMode0", 0LL);
		  sub_180003640(v97);
		  sub_180003660(v97, 0LL, v98);
		  v99 = UnityEngine::Shader::PropertyToID((String *)"_PlanetBlendMode1", 0LL);
		  sub_180003640(v97);
		  sub_180003660(v97, 1LL, v99);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PlanetBlendMode = v97;
		  sub_180004FC0(
		    (ILFixDynamicMethodWrapper_38 *)&TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PlanetBlendMode,
		    (VirtualMachine *)v97,
		    v100,
		    v101,
		    v143);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PlanetBillBoardConstants = UnityEngine::Shader::PropertyToID(
		                                                                                              (String *)"_PlanetBillBoardConstants",
		                                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RealPlanetRadius = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_RealPlanetRadius",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_AtmosphereRatios = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_AtmosphereRatios",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GlobalRadiusOffset = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_GlobalRadiusOffset",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_Density_Multiplier = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_Density_Multiplier",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_g = UnityEngine::Shader::PropertyToID(
		                                                                       (String *)"_g",
		                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_StepsI = UnityEngine::Shader::PropertyToID(
		                                                                            (String *)"_StepsI",
		                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_StepsL = UnityEngine::Shader::PropertyToID(
		                                                                            (String *)"_StepsL",
		                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_Mie_Height_Scale = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_Mie_Height_Scale",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_Pitch = UnityEngine::Shader::PropertyToID(
		                                                                           (String *)"_Pitch",
		                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_Roll = UnityEngine::Shader::PropertyToID(
		                                                                          (String *)"_Roll",
		                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_Phi2 = UnityEngine::Shader::PropertyToID(
		                                                                          (String *)"_Phi2",
		                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_Theta2 = UnityEngine::Shader::PropertyToID(
		                                                                            (String *)"_Theta2",
		                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_Dist = UnityEngine::Shader::PropertyToID(
		                                                                          (String *)"_Dist",
		                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CapThreshold = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_CapThreshold",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_Roughness = UnityEngine::Shader::PropertyToID(
		                                                                               (String *)"_Roughness",
		                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_BBRadius = UnityEngine::Shader::PropertyToID(
		                                                                              (String *)"_BBRadius",
		                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_Erosion = UnityEngine::Shader::PropertyToID(
		                                                                             (String *)"_Erosion",
		                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ErosionThreshold = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_ErosionThreshold",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CloudsAlphaMain = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_CloudsAlphaMain",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CloudsSpeedMain = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_CloudsSpeedMain",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_IndirectIntensity = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_IndirectIntensity",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_DirectLightIntensityBillboard = UnityEngine::Shader::PropertyToID(
		                                                                                                   (String *)"_DirectLightIntensityBillboard",
		                                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_Light_Intensity_Multiplier = UnityEngine::Shader::PropertyToID(
		                                                                                                (String *)"_Light_Intensity_Multiplier",
		                                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_Light_Intensity_Clouds_Multiplier = UnityEngine::Shader::PropertyToID((String *)"_Light_Intensity_Clouds_Multiplier", 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PlanetRotateStart = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_PlanetRotateStart",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PlanetRotateSpeed = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_PlanetRotateSpeed",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CapTransition = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_CapTransition",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CloudsFlowStrength = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_CloudsFlowStrength",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CloudsHeight = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_CloudsHeight",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CloudsFlowSpeed = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_CloudsFlowSpeed",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_Use_Lut = UnityEngine::Shader::PropertyToID(
		                                                                             (String *)"_Use_Lut",
		                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CustomLightColorPla = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_CustomLightColorPla",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CustomLightDirection = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_CustomLightDirection",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_UseRoughnessMap = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_UseRoughnessMap",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_EnablePolarCap = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_EnablePolarCap",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_UseErosionMap = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_UseErosionMap",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_Ray = UnityEngine::Shader::PropertyToID(
		                                                                         (String *)"_Ray",
		                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_Mie = UnityEngine::Shader::PropertyToID(
		                                                                         (String *)"_Mie",
		                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_Ambient = UnityEngine::Shader::PropertyToID(
		                                                                             (String *)"_Ambient",
		                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PlanetWSBase = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_PlanetWSBase",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_BBWSBase = UnityEngine::Shader::PropertyToID(
		                                                                              (String *)"_BBWSBase",
		                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PlanetScale = UnityEngine::Shader::PropertyToID(
		                                                                                 (String *)"_PlanetScale",
		                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FresnelColor = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_FresnelColor",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_TintColor = UnityEngine::Shader::PropertyToID(
		                                                                               (String *)"_TintColor",
		                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SeaDeep = UnityEngine::Shader::PropertyToID(
		                                                                             (String *)"_SeaDeep",
		                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SeaShallow = UnityEngine::Shader::PropertyToID(
		                                                                                (String *)"_SeaShallow",
		                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_IndirectColor = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_IndirectColor",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CustomLightDir = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_CustomLightDir",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CustomLightColPla = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_CustomLightColPla",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CloudsShadowColor = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_CloudsShadowColor",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_BaseColorMap_ST = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_BaseColorMap_ST",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ErosionMap_ST = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_ErosionMap_ST",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_TransmittanceLLUT = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_TransmittanceLLUT",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_BaseColorMap = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_BaseColorMap",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RSM = UnityEngine::Shader::PropertyToID(
		                                                                         (String *)"_RSM",
		                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CloudsTexMain = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_CloudsTexMain",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CloudsCap = UnityEngine::Shader::PropertyToID(
		                                                                               (String *)"_CloudsCap",
		                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CloudsFlowMap = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_CloudsFlowMap",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ErosionMap = UnityEngine::Shader::PropertyToID(
		                                                                                (String *)"_ErosionMap",
		                                                                                0LL);
		  v102 = (Int32__Array *)sub_18003B220(TypeInfo::System::Int32, 2LL);
		  v103 = UnityEngine::Shader::PropertyToID((String *)"_PlanetAtmosphereParams10", 0LL);
		  sub_180003640(v102);
		  sub_180003660(v102, 0LL, v103);
		  v104 = UnityEngine::Shader::PropertyToID((String *)"_PlanetAtmosphereParams11", 0LL);
		  sub_180003640(v102);
		  sub_180003660(v102, 1LL, v104);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PlanetAtmosphereParamsPack = v102;
		  sub_180004FC0(
		    (ILFixDynamicMethodWrapper_38 *)&TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PlanetAtmosphereParamsPack,
		    (VirtualMachine *)v102,
		    v105,
		    v106,
		    v144);
		  v107 = (Int32__Array *)sub_18003B220(TypeInfo::System::Int32, 2LL);
		  v108 = UnityEngine::Shader::PropertyToID((String *)"_PlanetAtmosphereParams20", 0LL);
		  sub_180003640(v107);
		  sub_180003660(v107, 0LL, v108);
		  v109 = UnityEngine::Shader::PropertyToID((String *)"_PlanetAtmosphereParams21", 0LL);
		  sub_180003640(v107);
		  sub_180003660(v107, 1LL, v109);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PlanetAtmosphereParams2Pack = v107;
		  sub_180004FC0(
		    (ILFixDynamicMethodWrapper_38 *)&TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PlanetAtmosphereParams2Pack,
		    (VirtualMachine *)v107,
		    v110,
		    v111,
		    v145);
		  v112 = (Int32__Array *)sub_18003B220(TypeInfo::System::Int32, 2LL);
		  v113 = UnityEngine::Shader::PropertyToID((String *)"_PlanetAtmosphereParams30", 0LL);
		  sub_180003640(v112);
		  sub_180003660(v112, 0LL, v113);
		  v114 = UnityEngine::Shader::PropertyToID((String *)"_PlanetAtmosphereParams31", 0LL);
		  sub_180003640(v112);
		  sub_180003660(v112, 1LL, v114);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PlanetAtmosphereParams3Pack = v112;
		  sub_180004FC0(
		    (ILFixDynamicMethodWrapper_38 *)&TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PlanetAtmosphereParams3Pack,
		    (VirtualMachine *)v112,
		    v115,
		    v116,
		    v146);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGAutoExposureHistogramBuffer = UnityEngine::Shader::PropertyToID(
		                                                                                                   (String *)"_HGAutoExposureHistogramBuffer",
		                                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_AE_inputTexture = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_AE_InputTexture",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_AE_histogramBuffer = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_AE_HistogramBuffer",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_Variants = UnityEngine::Shader::PropertyToID(
		                                                                              (String *)"_Variants",
		                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_InputTexture = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_InputTexture",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_OutputTexture = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_OutputTexture",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_Params = UnityEngine::Shader::PropertyToID(
		                                                                            (String *)"_Params",
		                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_Params0 = UnityEngine::Shader::PropertyToID(
		                                                                             (String *)"_Params0",
		                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_Params1 = UnityEngine::Shader::PropertyToID(
		                                                                             (String *)"_Params1",
		                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_Params2 = UnityEngine::Shader::PropertyToID(
		                                                                             (String *)"_Params2",
		                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_Params3 = UnityEngine::Shader::PropertyToID(
		                                                                             (String *)"_Params3",
		                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_TexelSize = UnityEngine::Shader::PropertyToID(
		                                                                               (String *)"_TexelSize",
		                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FrostedGlassTexLight = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_FrostedGlassTexLight",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FrostedGlassTexMedium = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_FrostedGlassTexMedium",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FrostedGlassTexHeavy = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_FrostedGlassTexHeavy",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FrostedGlassTexLightScene = UnityEngine::Shader::PropertyToID(
		                                                                                               (String *)"_FrostedGlassTexLightScene",
		                                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FrostedGlassTexMediumScene = UnityEngine::Shader::PropertyToID(
		                                                                                                (String *)"_FrostedGlassTexMediumScene",
		                                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FrostedGlassTexHeavyScene = UnityEngine::Shader::PropertyToID(
		                                                                                               (String *)"_FrostedGlassTexHeavyScene",
		                                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ColorThreshold = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_ColorThreshold",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_LightShaftSceneColor = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_LightShaftSceneColor",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_LightShaftSceneDepth = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_LightShaftSceneDepth",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_LightShaftBlurSrc = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_LightShaftBlurSrc",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_LightShaftBlurResult = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_LightShaftBlurResult",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_LightShaftBlurPassIndex = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_LightShaftBlurPassIndex",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_LightShaftCloudMask = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_LightShaftCloudMask",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_LightShaftParams0 = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_LightShaftParams0",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_LightShaftParams1 = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_LightShaftParams1",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_LightShaftParams2 = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_LightShaftParams2",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_LightShaftParams3 = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_LightShaftParams3",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_LightShaftCloudMaskParams = UnityEngine::Shader::PropertyToID(
		                                                                                               (String *)"_LightShaftCloudMaskParams",
		                                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_BloomParams = UnityEngine::Shader::PropertyToID(
		                                                                                 (String *)"_BloomParams",
		                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_BloomTint = UnityEngine::Shader::PropertyToID(
		                                                                               (String *)"_BloomTint",
		                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_BloomTexture = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_BloomTexture",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_BloomDirtTexture = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_BloomDirtTexture",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_BloomDirtScaleOffset = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_BloomDirtScaleOffset",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_InputLowTexture = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_InputLowTexture",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_InputHighTexture = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_InputHighTexture",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_BloomBicubicParams = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_BloomBicubicParams",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_BloomThreshold = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_BloomThreshold",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_BloomCharacterThreshold = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_BloomCharacterThreshold",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_BloomCharacterParams = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_BloomCharacterParams",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_BloomBuffer = UnityEngine::Shader::PropertyToID(
		                                                                                 (String *)"_BloomBuffer",
		                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RadialBlurParams = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_RadialBlurParams",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RadialBlurParams2 = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_RadialBlurParams2",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_BWFlashThreshold = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_BWFlashThreshold",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_BWFlashParams = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_BWFlashParams",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_BWFlashParams2 = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_BWFlashParams2",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_BWFlashParams3 = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_BWFlashParams3",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_BWFlashParams4 = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_BWFlashParams4",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_BWFlashTexture = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_BWFlashTexture",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_BWMaskTexture = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_BWMaskTexture",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_BWFlashColor = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_BWFlashColor",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_BWBackGroundColor = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_BWBackGroundColor",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FisheyeEffectParams1 = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_FisheyeEffectParams1",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ScanLineTint = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_ScanLineTint",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ScanLineMask = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_ScanLineMask",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ScanLineCenterPos = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_ScanLineCenterPos",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ScanLineParams1 = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_ScanLineParams1",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ScanLineParams2 = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_ScanLineParams2",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ScanLineParams3 = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_ScanLineParams3",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ScanLineParams4 = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_ScanLineParams4",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ScanLineParams5 = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_ScanLineParams5",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ScanLineParams6 = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_ScanLineParams6",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ScanLineParams7 = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_ScanLineParams7",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ScanLineParams8 = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_ScanLineParams8",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ScanLineParams9 = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_ScanLineParams9",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ScanLineParams10 = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_ScanLineParams10",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ScanLineHighlightHeight = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_ScanLineHighlightHeight",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_BoxPosWS = UnityEngine::Shader::PropertyToID(
		                                                                              (String *)"_BoxPosWS",
		                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ScanLineHighlightTint = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_ScanLineHighlightTint",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ScanLineHighlightBeamTint = UnityEngine::Shader::PropertyToID(
		                                                                                               (String *)"_ScanLineHighlightBeamTint",
		                                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_BoxPosition1 = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_BoxPosition1",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_BoxPosition2 = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_BoxPosition2",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_BoxPosition3 = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_BoxPosition3",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_BoxVec1 = UnityEngine::Shader::PropertyToID(
		                                                                             (String *)"_BoxVec1",
		                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_BoxVec2 = UnityEngine::Shader::PropertyToID(
		                                                                             (String *)"_BoxVec2",
		                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_BoxVec3 = UnityEngine::Shader::PropertyToID(
		                                                                             (String *)"_BoxVec3",
		                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CountPerArray = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_CountPerArray",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_MeshHeight = UnityEngine::Shader::PropertyToID(
		                                                                                (String *)"_MeshHeight",
		                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_BlackBoxBackGroundTint = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_BlackBoxBackGroundTint",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_BlackBoxContourColor = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_BlackBoxContourColor",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_BlackBoxCenterPos = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_BlackBoxCenterPos",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_BlackBoxParams1 = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_BlackBoxParams1",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_BlackBoxParams2 = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_BlackBoxParams2",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_BlackBoxParams3 = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_BlackBoxParams3",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_BlackBoxParams4 = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_BlackBoxParams4",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_BlackBoxParams5 = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_BlackBoxParams5",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_BlackBoxContourTexture = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_BlackBoxContourTexture",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SharpenParams = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_SharpenParams",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PPSharpen = UnityEngine::Shader::PropertyToID(
		                                                                               (String *)"_PPSharpen",
		                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PostProcessMask = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_PPMask",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FrostedGlassTexture = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_FrostedGlassTexture",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FrostedGlassBuffer = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_FrostedGlassBuffer",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_VignetteParams1 = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_VignetteParams1",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_VignetteParams2 = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_VignetteParams2",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_VignetteColor = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_VignetteColor",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_VignetteMask = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_VignetteMask",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_DirtyTex = UnityEngine::Shader::PropertyToID(
		                                                                              (String *)"_DirtyTex",
		                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_DirtyLensParams1 = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_DirtyLensParams1",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_LogLut3D = UnityEngine::Shader::PropertyToID(
		                                                                              (String *)"_LogLut3D",
		                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_LogLut3D_Params = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_LogLut3D_Params",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_LogLut2D = UnityEngine::Shader::PropertyToID(
		                                                                              (String *)"_LogLut2D",
		                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_Lut_Params = UnityEngine::Shader::PropertyToID(
		                                                                                (String *)"_Lut_Params",
		                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_UserLut = UnityEngine::Shader::PropertyToID(
		                                                                             (String *)"_UserLut",
		                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_UserLut_Params = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_UserLut_Params",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ColorBalance = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_ColorBalance",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ColorFilter = UnityEngine::Shader::PropertyToID(
		                                                                                 (String *)"_ColorFilter",
		                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ChannelMixerRed = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_ChannelMixerRed",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ChannelMixerGreen = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_ChannelMixerGreen",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ChannelMixerBlue = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_ChannelMixerBlue",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HueSatCon = UnityEngine::Shader::PropertyToID(
		                                                                               (String *)"_HueSatCon",
		                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_Lift = UnityEngine::Shader::PropertyToID(
		                                                                          (String *)"_Lift",
		                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_Gamma = UnityEngine::Shader::PropertyToID(
		                                                                           (String *)"_Gamma",
		                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_Gain = UnityEngine::Shader::PropertyToID(
		                                                                          (String *)"_Gain",
		                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_Shadows = UnityEngine::Shader::PropertyToID(
		                                                                             (String *)"_Shadows",
		                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_Midtones = UnityEngine::Shader::PropertyToID(
		                                                                              (String *)"_Midtones",
		                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_Highlights = UnityEngine::Shader::PropertyToID(
		                                                                                (String *)"_Highlights",
		                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ShaHiLimits = UnityEngine::Shader::PropertyToID(
		                                                                                 (String *)"_ShaHiLimits",
		                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SplitShadows = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_SplitShadows",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SplitHighlights = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_SplitHighlights",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CurveMaster = UnityEngine::Shader::PropertyToID(
		                                                                                 (String *)"_CurveMaster",
		                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CurveRed = UnityEngine::Shader::PropertyToID(
		                                                                              (String *)"_CurveRed",
		                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CurveGreen = UnityEngine::Shader::PropertyToID(
		                                                                                (String *)"_CurveGreen",
		                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CurveBlue = UnityEngine::Shader::PropertyToID(
		                                                                               (String *)"_CurveBlue",
		                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CurveHueVsHue = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_CurveHueVsHue",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CurveHueVsSat = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_CurveHueVsSat",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CurveSatVsSat = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_CurveSatVsSat",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CurveLumVsSat = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_CurveLumVsSat",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CustomToneCurve = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_CustomToneCurve",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ToeSegmentA = UnityEngine::Shader::PropertyToID(
		                                                                                 (String *)"_ToeSegmentA",
		                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ToeSegmentB = UnityEngine::Shader::PropertyToID(
		                                                                                 (String *)"_ToeSegmentB",
		                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_MidSegmentA = UnityEngine::Shader::PropertyToID(
		                                                                                 (String *)"_MidSegmentA",
		                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_MidSegmentB = UnityEngine::Shader::PropertyToID(
		                                                                                 (String *)"_MidSegmentB",
		                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ShoSegmentA = UnityEngine::Shader::PropertyToID(
		                                                                                 (String *)"_ShoSegmentA",
		                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ShoSegmentB = UnityEngine::Shader::PropertyToID(
		                                                                                 (String *)"_ShoSegmentB",
		                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_OwenScrambledTexture = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_OwenScrambledTexture",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ScramblingTileXSPP = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_ScramblingTileXSPP",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RankingTileXSPP = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_RankingTileXSPP",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ScramblingTexture = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_ScramblingTexture",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_AfterPostProcessTexture = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_AfterPostProcessTexture",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_UVTransform = UnityEngine::Shader::PropertyToID(
		                                                                                 (String *)"_UVTransform",
		                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_InputTex = UnityEngine::Shader::PropertyToID(
		                                                                              (String *)"_InputTex",
		                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_LoD = UnityEngine::Shader::PropertyToID(
		                                                                         (String *)"_LoD",
		                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FaceIndex = UnityEngine::Shader::PropertyToID(
		                                                                               (String *)"_FaceIndex",
		                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ViewPortSize = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_ViewPortSize",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_Dst3DTexture = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_Dst3DTexture",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_Src3DTexture = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_Src3DTexture",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_AlphaOnlyTexture = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_AlphaOnlyTexture",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SrcSize = UnityEngine::Shader::PropertyToID(
		                                                                             (String *)"_SrcSize",
		                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SrcMip = UnityEngine::Shader::PropertyToID(
		                                                                            (String *)"_SrcMip",
		                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SrcScale = UnityEngine::Shader::PropertyToID(
		                                                                              (String *)"_SrcScale",
		                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SrcOffset = UnityEngine::Shader::PropertyToID(
		                                                                               (String *)"_SrcOffset",
		                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_UseLighting = UnityEngine::Shader::PropertyToID(
		                                                                                 (String *)"_UseLighting",
		                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_UseBright = UnityEngine::Shader::PropertyToID(
		                                                                               (String *)"_UseBright",
		                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_UseSoftBlend = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_UseSoftBlend",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_UseEdgeColor = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_UseEdgeColor",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_UseFresnel = UnityEngine::Shader::PropertyToID(
		                                                                                (String *)"_UseFresnel",
		                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_UseFog = UnityEngine::Shader::PropertyToID(
		                                                                            (String *)"_UseFog",
		                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_UseVertexOffset = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_UseVertexOffset",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_UsedForUI = UnityEngine::Shader::PropertyToID(
		                                                                               (String *)"_UsedForUI",
		                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_UseTrail = UnityEngine::Shader::PropertyToID(
		                                                                              (String *)"_UseTrail",
		                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_UseSafeZoneMap = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_UseSafeZoneMap",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_UseAlphaTest = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_UseAlphaTest",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_UseNearCameraFade = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_UseNearCameraFade",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_UseVFXPortal = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_UseVFXPortal",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_DisableZTest = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_DisableZTest",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_DisableVertColor = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_DisableVertColor",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_IsUI = UnityEngine::Shader::PropertyToID(
		                                                                          (String *)"_IsUI",
		                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_InParticle = UnityEngine::Shader::PropertyToID(
		                                                                                (String *)"_InParticle",
		                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_IgnorePostExposure = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_IgnorePostExposure",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_EnableHoudiniVAT = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_EnableHoudiniVAT",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SceneDepth = UnityEngine::Shader::PropertyToID(
		                                                                                (String *)"_SceneDepth",
		                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_MotionVector = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_MotionVector",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CurrDilatedDepth = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_CurrDilatedDepth",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PrevDilatedDepth = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_PrevDilatedDepth",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CurrDilatedMV = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_CurrDilatedMV",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PrevDilatedMV = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_PrevDilatedMV",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CurrDilatedMask = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_CurrDilatedMask",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HistorySceneColor = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_HistorySceneColor",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_TAAUConstants = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_TAAUConstants",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CapsuleShadowData1 = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_CapsuleShadowData1",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CapsuleShadowData2 = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_CapsuleShadowData2",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CapsuleShadowData3 = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_CapsuleShadowData3",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CapsuleShadowData4 = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_CapsuleShadowData4",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FlareOcclusionTex = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_FlareOcclusionTex",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FlareOcclusionIndex = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_FlareOcclusionIndex",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FlareTex = UnityEngine::Shader::PropertyToID(
		                                                                              (String *)"_FlareTex",
		                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FlareColorValue = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_FlareColorValue",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FlareData0 = UnityEngine::Shader::PropertyToID(
		                                                                                (String *)"_FlareData0",
		                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FlareData1 = UnityEngine::Shader::PropertyToID(
		                                                                                (String *)"_FlareData1",
		                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FlareData2 = UnityEngine::Shader::PropertyToID(
		                                                                                (String *)"_FlareData2",
		                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FlareData3 = UnityEngine::Shader::PropertyToID(
		                                                                                (String *)"_FlareData3",
		                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FlareData4 = UnityEngine::Shader::PropertyToID(
		                                                                                (String *)"_FlareData4",
		                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FlareData5 = UnityEngine::Shader::PropertyToID(
		                                                                                (String *)"_FlareData5",
		                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_LowDoFParams = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_LowDoFParams",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_LowDoFCoCRT = UnityEngine::Shader::PropertyToID(
		                                                                                 (String *)"_LowDoFCoCRT",
		                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CompositeRT = UnityEngine::Shader::PropertyToID(
		                                                                                 (String *)"_CompositeRT",
		                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SSRData = UnityEngine::Shader::PropertyToID(
		                                                                             (String *)"_SSRData",
		                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SSRParams0 = UnityEngine::Shader::PropertyToID(
		                                                                                (String *)"_SSRParams0",
		                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SSRParams1 = UnityEngine::Shader::PropertyToID(
		                                                                                (String *)"_SSRParams1",
		                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SSRParams2 = UnityEngine::Shader::PropertyToID(
		                                                                                (String *)"_SSRParams2",
		                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SSRParams3 = UnityEngine::Shader::PropertyToID(
		                                                                                (String *)"_SSRParams3",
		                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SSRParams4 = UnityEngine::Shader::PropertyToID(
		                                                                                (String *)"_SSRParams4",
		                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SSRRTSize = UnityEngine::Shader::PropertyToID(
		                                                                               (String *)"_SSRRTSize",
		                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SSRLRSize = UnityEngine::Shader::PropertyToID(
		                                                                               (String *)"_SSRLRSize",
		                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SSRHRSize = UnityEngine::Shader::PropertyToID(
		                                                                               (String *)"_SSRHRSize",
		                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SSRProjMatrix = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_SSRProjMatrix",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SSRInvProjMatrix = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_SSRInvProjMatrix",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SSRInvViewProjMatrix = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_SSRInvViewProjMatrix",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SSRWorldToViewMatrix = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_SSRWorldToViewMatrix",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SSRCurrSceneColor = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_SSRCurrSceneColor",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SSRPrevSceneColor = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_SSRPrevSceneColor",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SSRSceneDepth = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_SSRSceneDepth",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SSRSceneStencil = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_SSRSceneStencil",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SSRSceneDepthPyramid = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_SSRSceneDepthPyramid",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SSRGBuffer = UnityEngine::Shader::PropertyToID(
		                                                                                (String *)"_SSRGBuffer",
		                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SSRMotionVector = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_SSRMotionVector",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SSRRT0 = UnityEngine::Shader::PropertyToID(
		                                                                            (String *)"_SSRRT0",
		                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SSRRT1 = UnityEngine::Shader::PropertyToID(
		                                                                            (String *)"_SSRRT1",
		                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SSRRT2 = UnityEngine::Shader::PropertyToID(
		                                                                            (String *)"_SSRRT2",
		                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SSRRT_Mobile0 = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_SSRRT_Mobile0",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SSRRT_Mobile1 = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_SSRRT_Mobile1",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SSRRT_Mobile2 = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_SSRRT_Mobile2",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SSRHitUVZRT = UnityEngine::Shader::PropertyToID(
		                                                                                 (String *)"_SSRHitUVZRT",
		                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SSRHitColorRT = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_SSRHitColorRT",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SSRLastColorRT = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_SSRLastColorRT",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SSRCurrColorRT = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_SSRCurrColorRT",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_TemporalFilterOutRT0 = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_TemporalFilterOutRT0",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_TemporalFilterOutRT1 = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_TemporalFilterOutRT1",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SSRRayTracingMaskRT = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_SSRRayTracingMaskRT",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SSRLightingTexture = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_SSRLightingTexture",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SSRFadenessTexture = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_SSRFadenessTexture",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ISSRParam0 = UnityEngine::Shader::PropertyToID(
		                                                                                (String *)"_ISSR_Param0",
		                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ISSRParam1 = UnityEngine::Shader::PropertyToID(
		                                                                                (String *)"_ISSR_Param1",
		                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ISSRParam2 = UnityEngine::Shader::PropertyToID(
		                                                                                (String *)"_ISSR_Param2",
		                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ISSRParam3 = UnityEngine::Shader::PropertyToID(
		                                                                                (String *)"_ISSR_Param3",
		                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ISSRScreenSize = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_ISSR_ScreenSize",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ISSRHalfScreenSize = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_ISSR_HalfScreenSize",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ISSRCurrSceneDepthTexture = UnityEngine::Shader::PropertyToID(
		                                                                                               (String *)"_ISSR_CurrSceneDepthTexture",
		                                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ISSRGBufferMVTexture = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_ISSR_GBufferMVTexture",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ISSRRayMarchingPackDataTexture = UnityEngine::Shader::PropertyToID(
		                                                                                                    (String *)"_ISSR_RayMarchingPackDataTexture",
		                                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ISSRPrevSceneColorTexture = UnityEngine::Shader::PropertyToID(
		                                                                                               (String *)"_ISSR_PrevSceneColorTexture",
		                                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ISSRUnpackTexture = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_ISSR_UnpackTexture",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ISSRPrevTemporalTexture = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_ISSR_PrevTemporalTexture",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ISSRCurrTemporalTexture = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_ISSR_CurrTemporalTexture",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ISSRPrevMipRTSize = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_ISSR_PrevMipRTSize",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ISSRCurrMipRTSize = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_ISSR_CurrMipRTSize",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ISSRPrevMipSceneColorTexture = UnityEngine::Shader::PropertyToID(
		                                                                                                  (String *)"_ISSR_PrevMipSceneColorTexture",
		                                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ISSRCurrMipSceneColorTexture = UnityEngine::Shader::PropertyToID(
		                                                                                                  (String *)"_ISSR_CurrMipSceneColorTexture",
		                                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ISSRReflectionMipChainTexture = UnityEngine::Shader::PropertyToID(
		                                                                                                   (String *)"_ISSR_ReflectionMipChainTexture",
		                                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ISSRResolveTexture = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_ISSR_ResolveTexture",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ISSRReflectionTexture = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_ISSR_ReflectionTexture",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ISSRUpsamplingTexture = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_ISSR_UpsamplingTexture",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FakePlanarReflectionTexture = UnityEngine::Shader::PropertyToID(
		                                                                                                 (String *)"_FakePlanarReflectionTexture",
		                                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RayTracingDataParams = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"RayTracingData",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ContactShadowDataParams = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_DataParams",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ContactShadowWorkgroupOffset = UnityEngine::Shader::PropertyToID(
		                                                                                                  (String *)"_WorkgroupOffset",
		                                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ContactShadowDepthBuffer = UnityEngine::Shader::PropertyToID(
		                                                                                              (String *)"_DepthBuffer",
		                                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ContactShadowStencilBuffer = UnityEngine::Shader::PropertyToID(
		                                                                                                (String *)"_StencilBuffer",
		                                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ContactShadowContactShadow = UnityEngine::Shader::PropertyToID(
		                                                                                                (String *)"_ContactShadow",
		                                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ContactShadowContactShadowTemp = UnityEngine::Shader::PropertyToID(
		                                                                                                    (String *)"_ContactShadowTemp",
		                                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GTAOData = UnityEngine::Shader::PropertyToID(
		                                                                              (String *)"_GTAOData",
		                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GTAOParam0 = UnityEngine::Shader::PropertyToID(
		                                                                                (String *)"_GTAOParam0",
		                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GTAOParam1 = UnityEngine::Shader::PropertyToID(
		                                                                                (String *)"_GTAOParam1",
		                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GTAOParam2 = UnityEngine::Shader::PropertyToID(
		                                                                                (String *)"_GTAOParam2",
		                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GTAOParam3 = UnityEngine::Shader::PropertyToID(
		                                                                                (String *)"_GTAOParam3",
		                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GTAOHalfScreenSize = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_GTAOHalfScreenSize",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GTAODepthMIPs = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_GTAODepthMIPs",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GTAOOutAOTerm = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_GTAOOutAOTerm",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GTAOOutEdges = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_GTAOOutEdges",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GTAODepthMip0 = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_GTAODepthMip0",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GTAODepthMip1 = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_GTAODepthMip1",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GTAODepthMip2 = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_GTAODepthMip2",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GTAODepthMip3 = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_GTAODepthMip3",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GTAODepthMip4 = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_GTAODepthMip4",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GTAOInAOTerm = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_GTAOInAOTerm",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GTAOInEdges = UnityEngine::Shader::PropertyToID(
		                                                                                 (String *)"_GTAOInEdges",
		                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GTAOOutRT = UnityEngine::Shader::PropertyToID(
		                                                                               (String *)"_GTAOOutRT",
		                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GTAOMainAOTermRT = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_GTAOMainAOTermRT",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GTAOMotionVectorRT = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_GTAOMotionVectorRT",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GTAOPreviousAOTermRT = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_GTAOPreviousAOTermRT",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GTAOCurrentAOTermRT = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_GTAOCurrentAOTermRT",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GTAOBlurAOTermInRT = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_GTAOBlurAOTermInRT",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GTAOBlurAOTermOutRT = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_GTAOBlurAOTermOutRT",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GTAOBlurAOTermRT = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_GTAOBlurAOTermRT",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GTAOUpsampleAOTermRT = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_GTAOUpsampleAOTermRT",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_WaterData = UnityEngine::Shader::PropertyToID(
		                                                                               (String *)"_WaterData",
		                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_WaterOcclusionData = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_WaterOcclusionData",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_WaterOcclusionTilePassCB = UnityEngine::Shader::PropertyToID(
		                                                                                              (String *)"_WaterOcclusionTilePassCB",
		                                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_WaterTesellationDrawIndirectArgsCB = UnityEngine::Shader::PropertyToID((String *)"_WaterTesellationDrawIndirectArgsCB", 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_WaterInteractiveCB = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_WaterInteractiveCB",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_WaterProxy = UnityEngine::Shader::PropertyToID(
		                                                                                (String *)"_WaterProxy",
		                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_WaterDecal = UnityEngine::Shader::PropertyToID(
		                                                                                (String *)"_WaterDecal",
		                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_WaterInteractiveTexture = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_WaterInteractiveTexture",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_WaterPrepassDataTexture = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_WaterPrepassDataTexture",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_WaterPrepassNormalTexture = UnityEngine::Shader::PropertyToID(
		                                                                                               (String *)"_WaterPrepassNormalTexture",
		                                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_WaterPrepassDisplacementTexture = UnityEngine::Shader::PropertyToID(
		                                                                                                     (String *)"_WaterPrepassDisplacementTexture",
		                                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_WaterPrepassDepthTexture = UnityEngine::Shader::PropertyToID(
		                                                                                              (String *)"_WaterPrepassDepthTexture",
		                                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_WaterPrepassDataGlobalTexture = UnityEngine::Shader::PropertyToID(
		                                                                                                   (String *)"_WaterPrepassDataGlobalTexture",
		                                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_WaterPrepassNormalGlobalTexture = UnityEngine::Shader::PropertyToID(
		                                                                                                     (String *)"_WaterPrepassNormalGlobalTexture",
		                                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_WaterPrepassDepthGlobalTexture = UnityEngine::Shader::PropertyToID(
		                                                                                                    (String *)"_WaterPrepassDepthGlobalTexture",
		                                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_NormalRoughnessTexture = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_NormalRoughnessTexture",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_WaterLocalFlowmapTexture = UnityEngine::Shader::PropertyToID(
		                                                                                              (String *)"_WaterLocalFlowmapTexture",
		                                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_WaterRippleTexture = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_WaterRippleTexture",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_WaterGlobalFlowmapTexture = UnityEngine::Shader::PropertyToID(
		                                                                                               (String *)"_WaterGlobalFlowmapTexture",
		                                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_WaterGlobalSmallWaveNormalTexture = UnityEngine::Shader::PropertyToID((String *)"_WaterGlobalSmallWaveNormalTexture", 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_WaterGlobalLargeWaveNormalTexture = UnityEngine::Shader::PropertyToID((String *)"_WaterGlobalLargeWaveNormalTexture", 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_WaterGlobalNormalTextureArray = UnityEngine::Shader::PropertyToID(
		                                                                                                   (String *)"_WaterGlobalNormalTextureArray",
		                                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_WaterGlobalCausticTexture = UnityEngine::Shader::PropertyToID(
		                                                                                               (String *)"_WaterGlobalCausticTexture",
		                                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_WaterGlobalRainTexture = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_WaterGlobalRainTexture",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_WaterReflectLightingTexture = UnityEngine::Shader::PropertyToID(
		                                                                                                 (String *)"_WaterReflectLightingTexture",
		                                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_WaterReflectFadenessTexture = UnityEngine::Shader::PropertyToID(
		                                                                                                 (String *)"_WaterReflectFadenessTexture",
		                                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_WaterWetnessMaskTexture = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_WaterWetnessMaskTexture",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_WaterWetnessMask3dNoiseTexture = UnityEngine::Shader::PropertyToID(
		                                                                                                    (String *)"_WaterWetnessMask3dNoiseTexture",
		                                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FoliageInteractiveTex = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_FoliageInteractiveTex",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PrevFoliageInteractiveTex = UnityEngine::Shader::PropertyToID(
		                                                                                               (String *)"_PrevFoliageInteractiveTex",
		                                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_DynamicSludgeTex = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_DynamicSludgeTex",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PrevDynamicSludgeTex = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_PrevDynamicSludgeTex",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SludgeThicknessTex = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_SludgeThicknessTex",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PrevSludgeThicknessTex = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_PrevSludgeThicknessTex",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PrevSludgeMinHeightTex = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_PrevSludgeMinHeightTex",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_WindGlobalNoiseTex = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_WindGlobalNoiseTex",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HeightFogNoise3DTex = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_HeightFogNoise3DTex",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FogBakeLutTex = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_FogBakeLutTex",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_DepthOfFieldData = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_DepthOfFieldData",
		                                                                                      0LL);
		  v117 = (Int32__Array *)sub_18003B220(TypeInfo::System::Int32, 5LL);
		  v118 = UnityEngine::Shader::PropertyToID((String *)"_HistoryMotionBlurTexture0", 0LL);
		  sub_180003640(v117);
		  sub_180003660(v117, 0LL, v118);
		  v119 = UnityEngine::Shader::PropertyToID((String *)"_HistoryMotionBlurTexture1", 0LL);
		  sub_180003640(v117);
		  sub_180003660(v117, 1LL, v119);
		  v120 = UnityEngine::Shader::PropertyToID((String *)"_HistoryMotionBlurTexture2", 0LL);
		  sub_180003640(v117);
		  sub_180003660(v117, 2LL, v120);
		  v121 = UnityEngine::Shader::PropertyToID((String *)"_HistoryMotionBlurTexture3", 0LL);
		  sub_180003640(v117);
		  sub_180003660(v117, 3LL, v121);
		  v122 = UnityEngine::Shader::PropertyToID((String *)"_HistoryMotionBlurTexture4", 0LL);
		  sub_180003640(v117);
		  sub_180003660(v117, 4LL, v122);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_MotionBlurHistoryTexture = v117;
		  sub_180004FC0(
		    (ILFixDynamicMethodWrapper_38 *)&TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_MotionBlurHistoryTexture,
		    (VirtualMachine *)v117,
		    v123,
		    v124,
		    v147);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_VerticalFadeStart = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_VerticalFadeStart",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_VerticalFadeEnd = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_VerticalFadeEnd",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_VerticalFadeAffectDist = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_VerticalFadeAffectDist",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_VerticalFadeDist = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_VerticalFadeDist",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GroundColorAdj = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_GroundColorAdj",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_InkWashIntensity = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_InkWashIntensity",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_InkWashSceneColor = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_InkWashSceneColor",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_InkWashSceneDepth = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_InkWashSceneDepth",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_InkWashSceneNormalRoughness = UnityEngine::Shader::PropertyToID(
		                                                                                                 (String *)"_InkWashSceneNormalRoughness",
		                                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_InkMask = UnityEngine::Shader::PropertyToID(
		                                                                             (String *)"_InkMask",
		                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_InkDropSize = UnityEngine::Shader::PropertyToID(
		                                                                                 (String *)"_InkDropSize",
		                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_InkBleedingSpeed = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_InkBleedingSpeed",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_InkBleedingDeltaTime = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_InkBleedingDeltaTime",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_InkPointDir = UnityEngine::Shader::PropertyToID(
		                                                                                 (String *)"_InkPointDir",
		                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_InkMaskFaceBasis = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_InkMaskFaceBasis",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_InkStrokeSeed = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_InkStrokeSeed",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_AtlasSize = UnityEngine::Shader::PropertyToID(
		                                                                               (String *)"_AtlasSize",
		                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_EdgeFade = UnityEngine::Shader::PropertyToID(
		                                                                              (String *)"_EdgeFade",
		                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_InkMaskParams = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_InkMaskParams",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_InkWashParams = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_InkWashParams",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_UIImageBlurTex = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_UIImageBlurTex",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ColorBuffer = UnityEngine::Shader::PropertyToID(
		                                                                                 (String *)"_ColorBuffer",
		                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PPColor = UnityEngine::Shader::PropertyToID(
		                                                                             (String *)"_PPColor",
		                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RWDebugFullScreenBuffer = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"RWDebugFullScreenBuffer",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HistogramDebugBuffer = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_HistogramDebugBuffer",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HistogramSize = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_HistogramSize",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HistogramMin = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_HistogramMin",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HistogramMax = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_HistogramMax",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FlipY = UnityEngine::Shader::PropertyToID(
		                                                                           (String *)"_FlipY",
		                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_IrradianceVolumeAtlas0 = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_IrradianceVolumeAtlas0",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_IrradianceVolumeAtlas1 = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_IrradianceVolumeAtlas1",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_IrradianceVolumeAtlas = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_IrradianceVolumeAtlas",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FlattenIndexBuffer = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_FlattenIndexBuffer",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_IrradianceDataBuffer = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_IrradianceDataBuffer",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_EnableIV = UnityEngine::Shader::PropertyToID(
		                                                                              (String *)"_EnableIV",
		                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_IVNormalOffset = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_IVNormalOffset",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ChunkNumPerDim = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_ChunkNumPerDim",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GlobalHashTable = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_GlobalHashTable",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HashTableCenterCoord = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_HashTableCenterCoord",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_IrradianceVolumeIndirectTexture = UnityEngine::Shader::PropertyToID(
		                                                                                                     (String *)"_IrradianceVolumeIndirectTexture",
		                                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_IrradianceVolumeChunkStartPos = UnityEngine::Shader::PropertyToID(
		                                                                                                   (String *)"_IrradianceVolumeChunkStartPos",
		                                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_IndirectCenterPos = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_IndirectCenterPos",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_IndirectPreCenterPos = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_IndirectPreCenterPos",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CameraUpdateCnt = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_CameraUpdateCnt",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ChunkUpdateCnt = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_ChunkUpdateCnt",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_IrradianceVolumeClipmapTextureALod0 = UnityEngine::Shader::PropertyToID((String *)"_IrradianceVolumeClipmapTextureALod0", 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_IrradianceVolumeClipmapTextureBLod0 = UnityEngine::Shader::PropertyToID((String *)"_IrradianceVolumeClipmapTextureBLod0", 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_IrradianceVolumeClipmapTextureALod1 = UnityEngine::Shader::PropertyToID((String *)"_IrradianceVolumeClipmapTextureALod1", 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_IrradianceVolumeClipmapTextureBLod1 = UnityEngine::Shader::PropertyToID((String *)"_IrradianceVolumeClipmapTextureBLod1", 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_IrradianceVolumeClipmapTextureALod3 = UnityEngine::Shader::PropertyToID((String *)"_IrradianceVolumeClipmapTextureALod3", 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_IrradianceVolumeClipmapTextureBLod3 = UnityEngine::Shader::PropertyToID((String *)"_IrradianceVolumeClipmapTextureBLod3", 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RainTex0 = UnityEngine::Shader::PropertyToID(
		                                                                              (String *)"_RainTex0",
		                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RainTex0_ST = UnityEngine::Shader::PropertyToID(
		                                                                                 (String *)"_RainTex0_ST",
		                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RainTex1 = UnityEngine::Shader::PropertyToID(
		                                                                              (String *)"_RainTex1",
		                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RainTex1_ST = UnityEngine::Shader::PropertyToID(
		                                                                                 (String *)"_RainTex1_ST",
		                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RainParams = UnityEngine::Shader::PropertyToID(
		                                                                                (String *)"_RainParams",
		                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RainMaskParams = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_RainMaskParams",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RainOffsetParams = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_RainOffsetParams",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RainDirectionParams = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_RainDirectionParams",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RainColor = UnityEngine::Shader::PropertyToID(
		                                                                               (String *)"_RainColor",
		                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ScreenDropFXNoiseTex = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_ScreenDropFXNoiseTex",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ScreenDropFXNoiseTex_ST = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_ScreenDropFXNoiseTex_ST",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ScreenDropRenderDatas = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_ScreenDropRenderDatas",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RainOcclusionSampleNoise = UnityEngine::Shader::PropertyToID(
		                                                                                              (String *)"_RainOcclusionSampleNoise",
		                                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_VerticalFlowTexture = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_VerticalFlowTexture",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RippleTexture = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_RippleTexture",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_VerticalOcclusionMap = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_VerticalOcclusionMap",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_VerticalOcclusionMapTransformCB = UnityEngine::Shader::PropertyToID(
		                                                                                                     (String *)"_VerticalOcclusionMapTransformCB",
		                                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CameraHeightRefreshDataCB = UnityEngine::Shader::PropertyToID(
		                                                                                               (String *)"_CameraHeightRefreshDataCB",
		                                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CustomDepthOnlyRT = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_CustomDepthOnlyRT",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GlintPatternTexture = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_GlintPatternTexture",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GlintTopBlendSmoothness = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_GlintTopBlendSmoothness",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GlintTopBlendThreshold = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_GlintTopBlendThreshold",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GlintStrength = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_GlintStrength",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GlintScale = UnityEngine::Shader::PropertyToID(
		                                                                                (String *)"_GlintScale",
		                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GlintThreshold = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_GlintThreshold",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GlintFadeDistance = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_GlintFadeDistance",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GlintColor = UnityEngine::Shader::PropertyToID(
		                                                                                (String *)"_GlintColor",
		                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_UseSubsurfaceProfile = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_UseSubsurfaceProfile",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SurfaceAlbedo = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_SurfaceAlbedo",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_MeanFreePathColor = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_MeanFreePathColor",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_MeanFreePathDistance = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_MeanFreePathDistance",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_DiffuseMeanFreePath = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_DiffuseMeanFreePath",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_LutMaxRadius = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_LutMaxRadius",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_LutMaxPenumbra = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_LutMaxPenumbra",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SubsurfaceOriginNormalTex = UnityEngine::Shader::PropertyToID(
		                                                                                               (String *)"_SubsurfaceOriginNormalTex",
		                                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SubsurfaceNormalWorldRange = UnityEngine::Shader::PropertyToID(
		                                                                                                (String *)"_SubsurfaceNormalWorldRange",
		                                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SubsurfaceCurvatureTex = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_SubsurfaceCurvatureTex",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SubsurfaceNormalCurvatureTex = UnityEngine::Shader::PropertyToID(
		                                                                                                  (String *)"_SubsurfaceNormalCurvatureTex",
		                                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_OutScatterLut = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_OutScatterLut",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_OutPenumbraLut = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_OutPenumbraLut",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_OutIndirectLut = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_OutIndirectLut",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CurvatureScale = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_CurvatureScale",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PenumbraScale = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_PenumbraScale",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SubsurfaceProfileInt = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_SubsurfaceProfileInt",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_TerrainSubsurfaceProfileInt = UnityEngine::Shader::PropertyToID(
		                                                                                                 (String *)"_TerrainSubsurfaceProfileInt",
		                                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SubsurfaceScatterLutArray = UnityEngine::Shader::PropertyToID(
		                                                                                               (String *)"_SubsurfaceScatterLutArray",
		                                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SubsurfacePenumbraLutArray = UnityEngine::Shader::PropertyToID(
		                                                                                                (String *)"_SubsurfacePenumbraLutArray",
		                                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SubsurfaceIndirectLutArray = UnityEngine::Shader::PropertyToID(
		                                                                                                (String *)"_SubsurfaceIndirectLutArray",
		                                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SubsurfaceProfileConstants = UnityEngine::Shader::PropertyToID(
		                                                                                                (String *)"_SubsurfaceProfileConstants",
		                                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SubsurfaceCurvatureScale = UnityEngine::Shader::PropertyToID(
		                                                                                              (String *)"_SubsurfaceCurvatureScale",
		                                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SubsurfaceCurvatureOffset = UnityEngine::Shader::PropertyToID(
		                                                                                               (String *)"_SubsurfaceCurvatureOffset",
		                                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_TerrainStencilRef = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_TerrainStencilRef",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SeparateTerrainStencilRef = UnityEngine::Shader::PropertyToID(
		                                                                                               (String *)"_SeparateTerrainStencilRef",
		                                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_TerrainSubsurfaceConstants = UnityEngine::Shader::PropertyToID(
		                                                                                                (String *)"_TerrainSubsurfaceConstants",
		                                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_EnableSubsurface = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_EnableSubsurface",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SubsurfaceColor = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_SubsurfaceColor",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SubsurfaceValue = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_SubsurfaceValue",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SubsurfaceHue = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_SubsurfaceHue",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SubsurfaceSaturation = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_SubsurfaceSaturation",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SubsurfaceIndirect = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_SubsurfaceIndirect",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SubsurfaceInt = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_SubsurfaceInt",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SubsurfaceConstants = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_SubsurfaceConstants",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_VisibilitySHConstData = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"VisibilitySHConstData",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_VisibilityCapsuleData = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"VisibilityCapsuleData",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_LogSHLutTex = UnityEngine::Shader::PropertyToID(
		                                                                                 (String *)"_LogSHLutTex",
		                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_ABLutTex = UnityEngine::Shader::PropertyToID(
		                                                                              (String *)"_ABLutTex",
		                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_VisibilitySHRT = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_VisibilitySHRT",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_VisibilitySHDebugRT = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_VisibilitySHDebugRT",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FakeVolumeIoR = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_FakeVolumeIoR",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FakeVolumeFresnelStrength = UnityEngine::Shader::PropertyToID(
		                                                                                               (String *)"_FakeVolumeFresnelStrength",
		                                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FakeVolumeOpacityMask = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_FakeVolumeOpacityMask",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FakeVolumeOpacityTiling = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_FakeVolumeOpacityTiling",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FakeVolumeMask = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_FakeVolumeMask",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FakeCrackLayerTiling = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_FakeCrackLayerTiling",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FakeCrackTint = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_FakeCrackTint",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FakeCrackHeightScale = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_FakeCrackHeightScale",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FakeCrackDepth = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_FakeCrackDepth",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FakeCrackMarchSteps = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_FakeCrackMarchSteps",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FakeRefractionTint = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_FakeRefractionTint",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FakeRefractionLayerTiling = UnityEngine::Shader::PropertyToID(
		                                                                                               (String *)"_FakeRefractionLayerTiling",
		                                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FakeVolumeScatterExtinction = UnityEngine::Shader::PropertyToID(
		                                                                                                 (String *)"_FakeVolumeScatterExtinction",
		                                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FakeVolumeScatterAlbedo = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_FakeVolumeScatterAlbedo",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FakeRefractionHeightScale = UnityEngine::Shader::PropertyToID(
		                                                                                               (String *)"_FakeRefractionHeightScale",
		                                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FakeRefractionDepth = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_FakeRefractionDepth",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FakeRefractionMarchSteps = UnityEngine::Shader::PropertyToID(
		                                                                                              (String *)"_FakeRefractionMarchSteps",
		                                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FakeDustLayerTiling = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_FakeDustLayerTiling",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FakeDustDepth = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_FakeDustDepth",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FakeDustFlowSpeed = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_FakeDustFlowSpeed",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FakeDustTint = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_FakeDustTint",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FakeShadowPenumbra = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_FakeShadowPenumbra",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FakeShadowStrength = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_FakeShadowStrength",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FakeShadowMarchSteps = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_FakeShadowMarchSteps",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FakeShadowDistanceLerp = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_FakeShadowDistanceLerp",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_InteractionDataCB = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_InteractionDataCB",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GroundHeight = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_GroundHeight",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_InteractRadius = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_InteractRadius",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_InteractLength = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_InteractLength",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_InteractHeight = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_InteractHeight",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_InteractHeightScale = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_InteractHeightScale",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_InteractMaskTexture = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_InteractMaskTexture",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_InteractWorldToLocal = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_InteractWorldToLocal",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PrevInteractLocalToWorld = UnityEngine::Shader::PropertyToID(
		                                                                                              (String *)"_PrevInteractLocalToWorld",
		                                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CapsuleLocalHeight = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_CapsuleLocalHeight",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_DecalInteractionDataCB = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_DecalInteractionDataCB",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_DecalInteractionSettingDataCB = UnityEngine::Shader::PropertyToID(
		                                                                                                   (String *)"_DecalInteractionSettingDataCB",
		                                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_EdgeFadeRatio = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_EdgeFadeRatio",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GPUDrivenHZB = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_GPUDrivenHZB",
		                                                                                  0LL);
		}
		
	}
}
