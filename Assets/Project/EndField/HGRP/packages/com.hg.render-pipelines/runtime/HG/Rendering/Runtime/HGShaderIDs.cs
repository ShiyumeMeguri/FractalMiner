using System;

namespace HG.Rendering.Runtime
{
	public static class HGShaderIDs
	{
		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static readonly int _CB0;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x04")]
		public static readonly int _UnityInstancing_ECSPerDraw;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		public static readonly int _Output0;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x0C")]
		public static readonly int _Output1;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		public static readonly int _Output2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x14")]
		public static readonly int _Output3;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x18")]
		public static readonly int _Input0;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1C")]
		public static readonly int _Input1;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x20")]
		public static readonly int _Input2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x24")]
		public static readonly int _Input3;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x28")]
		public static readonly int _Param0;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2C")]
		public static readonly int _Param1;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x30")]
		public static readonly int _Param2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x34")]
		public static readonly int _Param3;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x38")]
		public static readonly int _RTSize;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x3C")]
		public static readonly int _TextureSize;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x40")]
		public static readonly int _TerrainDeformResultTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x44")]
		public static readonly int _TerrainDeformDensityTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x48")]
		public static readonly int _TerrainDeformConstDataBuffer;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x4C")]
		public static readonly int _TerrainDeformSplatData;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x50")]
		public static readonly int _TerrainDeformSplatCtrlAtlas;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x54")]
		public static readonly int _TerrainDeformSplatIndex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x58")]
		public static readonly int _TerrainDeformHeightmapAtlas;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x5C")]
		public static readonly int _TerrainDeformHolemapAtlas;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x60")]
		public static readonly int _TerrainDeformNormalmapAtlas;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x64")]
		public static readonly int _TerrainDeformTintColorAtlas;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x68")]
		public static readonly int _TerrainDeformAlbedoAtlas;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x6C")]
		public static readonly int _TerrainDeformWetnessAtlas;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x70")]
		public static readonly int _TerrainDeformSplatDiffuseArray;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x74")]
		public static readonly int _TerrainDeformSplatNormalROArray;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x78")]
		public static readonly int _TerrainDeformDepthTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x7C")]
		public static readonly int _TerrainGroundDistanceTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x80")]
		public static readonly int _TerrainDeformHistoryFillRateTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x84")]
		public static readonly int _TerrainDeformCurFillRateTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x88")]
		public static readonly int _TerrainDeformComputeResultTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x8C")]
		public static readonly int _TerrainDeformDensityMip4Tex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x90")]
		public static readonly int _TerrainGroundLayerBaseRT;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x94")]
		public static readonly int _TerrainGroundLayerNormalRT;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x98")]
		public static readonly int _TerrainGroundLayerWetRT;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x9C")]
		public static readonly int _TerrainGroundLayerHeightRT;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA0")]
		public static readonly int _RWTerrainGroundLayerBaseRT;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA4")]
		public static readonly int _RWTerrainGroundLayerNormalRT;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA8")]
		public static readonly int _RWTerrainGroundLayerWetRT;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xAC")]
		public static readonly int _RWTerrainGroundLayerHeightRT;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB0")]
		public static readonly int _TerrainGroundLayerConstants;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB4")]
		public static readonly int _TerrainSplatLayerDeformConstants;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB8")]
		public static readonly int _PerlinNoiseTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xBC")]
		public static readonly int _SnowDetailNormalTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC0")]
		public static readonly int ShadowData;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC4")]
		public static readonly int ShadowVertexBuffer;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC8")]
		public static readonly int _CSMShadowmapTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xCC")]
		public static readonly int _CharacterShadowmapTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xD0")]
		public static readonly int _PunctualShadowmapTexArray;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xD4")]
		public static readonly int _CSMShadowRampTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xD8")]
		public static readonly int _CloudShadowTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xDC")]
		public static readonly int _LowResDirectionalShadow;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xE0")]
		public static readonly int _ScreenSpaceShadowMask;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xE4")]
		public static readonly int _ShadowpassVP;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xE8")]
		public static readonly int _ASMIndirectTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xEC")]
		public static readonly int _ASMShadowmapTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xF0")]
		public static readonly int _CachedShadowmapAtlas;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xF4")]
		public static readonly int _PunctualLightShadowTexV2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xF8")]
		public static readonly int LightCookieCB;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xFC")]
		public static readonly int _LightCookie;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x100")]
		public static readonly int _LightDataBuffer;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x104")]
		public static readonly int _LightBinningConstants;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x108")]
		public static readonly int _GPULightBinningConstants;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10C")]
		public static readonly int _BinningBuffer;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x110")]
		public static readonly int _GlobalBinningBuffer;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x114")]
		public static readonly int _DrawTileArgsBuffer;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x118")]
		public static readonly int _DrawTileArgsBufferNextFrame;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x11C")]
		public static readonly int _TileInstanceIndicesBuffer;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x120")]
		public static readonly int _PunctualLights;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x124")]
		public static readonly int _PunctualLightCount;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x128")]
		public static readonly int _NearPlaneParams;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x12C")]
		public static readonly int _NearPlaneDist;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x130")]
		public static readonly int _ZBinSlice;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x134")]
		public static readonly int _NumZBinSlices;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x138")]
		public static readonly int _OutLightBinningXYMasks;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x13C")]
		public static readonly int _OutLightBinningZMasks;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x140")]
		public static readonly int _PerLightIndex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x144")]
		public static readonly int _TileSize;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x148")]
		public static readonly int _NumTiles;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x14C")]
		public static readonly int _NumTilesX;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x150")]
		public static readonly int _NumTilesY;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x154")]
		public static readonly int _StencilMask;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x158")]
		public static readonly int _StencilRef;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x15C")]
		public static readonly int _StencilCmp;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x160")]
		public static readonly int _InputDepth;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x164")]
		public static readonly int _ClearColor;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x168")]
		public static readonly int _SrcBlend;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x16C")]
		public static readonly int _DstBlend;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x170")]
		public static readonly int _MultiscatteringLUT;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x174")]
		public static readonly int _DecalWorldToObject;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x178")]
		public static readonly int _DecalPackedData;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x17C")]
		public static readonly int _DrawOrder;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x180")]
		public static readonly int _WorldSpaceCameraPos;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x184")]
		public static readonly int _PrevCamPosRWS;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x188")]
		public static readonly int _ViewMatrix;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x18C")]
		public static readonly int _CameraViewMatrix;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x190")]
		public static readonly int _InvViewMatrix;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x194")]
		public static readonly int _ProjMatrix;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x198")]
		public static readonly int _InvProjMatrix;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x19C")]
		public static readonly int _NonJitteredViewProjMatrix;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1A0")]
		public static readonly int _ViewProjMatrix;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1A4")]
		public static readonly int _CameraViewProjMatrix;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1A8")]
		public static readonly int _InvViewProjMatrix;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1AC")]
		public static readonly int _ZBufferParams;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1B0")]
		public static readonly int _ProjectionParams;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1B4")]
		public static readonly int unity_OrthoParams;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1B8")]
		public static readonly int _InvProjParam;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1BC")]
		public static readonly int _ScreenSize;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1C0")]
		public static readonly int _HalfScreenSize;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1C4")]
		public static readonly int _ScreenParams;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1C8")]
		public static readonly int _PrevNonJitteredViewProjMatrix;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1CC")]
		public static readonly int _PrevNonJitteredInvViewProjMatrix;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1D0")]
		public static readonly int _FrustumPlanes;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1D4")]
		public static readonly int _PreviousSceneColorTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1D8")]
		public static readonly int _SceneColorTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1DC")]
		public static readonly int _SceneDepthTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1E0")]
		public static readonly int _LowSceneDepthTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1E4")]
		public static readonly int _LowResColorTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1E8")]
		public static readonly int _LowResMVTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1EC")]
		public static readonly int _DepthTextureWithWater;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1F0")]
		public static readonly int _UIColorTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1F4")]
		public static readonly int _ReflectionProbeTextureArray;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1F8")]
		public static readonly int _IndirectAmbientOcclusionTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1FC")]
		public static readonly int _CharMaxCubemap;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x200")]
		public static readonly int _CharacterEnvColorTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x204")]
		public static readonly int _CharacterRainEffectTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x208")]
		public static readonly int _CharacterRainStreakTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x20C")]
		public static readonly int _CharacterRainFaceDripTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x210")]
		public static readonly int _CharacterRainFaceDropletTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x214")]
		public static readonly int _CharacterSnowEffectTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x218")]
		public static readonly int _DotDitherTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x220")]
		public static readonly int[] _GBufferTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x228")]
		public static readonly int _CurrPyramidTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x22C")]
		public static readonly int _CurrPyramidTexture0;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x230")]
		public static readonly int _CurrPyramidTexture1;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x234")]
		public static readonly int _CurrPyramidTexture2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x238")]
		public static readonly int _CurrPyramidTexture3;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x23C")]
		public static readonly int _CurrPyramidTexture4;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x240")]
		public static readonly int _CurrPyramidTexture5;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x244")]
		public static readonly int _CurrPyramidTexture6;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x248")]
		public static readonly int _GlobalAtomicBuffer;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x24C")]
		public static readonly int _DepthPyramidData;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x250")]
		public static readonly int _CopyDepthPyramidData;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x254")]
		public static readonly int _HZBTexture0;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x258")]
		public static readonly int _HZBTexture1;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x25C")]
		public static readonly int _HZBTexture2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x260")]
		public static readonly int _HZBTexture3;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x264")]
		public static readonly int _HZBBuildData;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x268")]
		public static readonly int _HGTerrainChunkTransform;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x26C")]
		public static readonly int _HGTerrainChunkParam0;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x270")]
		public static readonly int _HGTerrainUVTransform;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x274")]
		public static readonly int _HGTerrainRTOffset;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x278")]
		public static readonly int _HGTerrainDecalInstanceInfos;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x27C")]
		public static readonly int _HGTerrainDecalInstanceData;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x280")]
		public static readonly int _HGTerrainFeedbackViewProj;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x284")]
		public static readonly int _HGTerrainCompressCacheParam0;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x288")]
		public static readonly int _HGTerrainPerTerrain;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x28C")]
		public static readonly int _HGTerrainPerTerrainFrame;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x290")]
		public static readonly int _HGTerrainLightmap;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x294")]
		public static readonly int _HGTerrainLightmapInd;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x298")]
		public static readonly int _HGTerrainControlMap;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x29C")]
		public static readonly int _HGTerrainSplatIndexMap;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2A0")]
		public static readonly int _HGTerrainSplats;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2A4")]
		public static readonly int _HGTerrainNormals;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2A8")]
		public static readonly int _HGTerrainTerrainNormalmapTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2AC")]
		public static readonly int _HGTerrainPhysicalBase;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2B0")]
		public static readonly int _HGTerrainPhysicalNormal;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2B4")]
		public static readonly int _HGTerrainIndirectTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2B8")]
		public static readonly int _HGTerrainColorVariationTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2BC")]
		public static readonly int _HGTerrainDecalDiffuseTexArray;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2C0")]
		public static readonly int _HGTerrainDecalNormalMROTexArray;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2C4")]
		public static readonly int _HGTerrainHeightmap;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2C8")]
		public static readonly int _HGTerrainDeformableControlMap;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2CC")]
		public static readonly int _HGTerrainReflectionProbeTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2D0")]
		public static readonly int _HGTerrainCommonInput;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2D4")]
		public static readonly int _HGTerrainCommonOutput;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2D8")]
		public static readonly int _HGTerrainDepthBuffer;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2DC")]
		public static readonly int _HGTerrainRT0;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2E0")]
		public static readonly int _HGTerrainRT1;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2E4")]
		public static readonly int _HGTerrainRT2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2E8")]
		public static readonly int _HZBTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2EC")]
		public static readonly int _HGHiZInput;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2F0")]
		public static readonly int _HGHiZOutput0;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2F4")]
		public static readonly int _HGHiZOutput1;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2F8")]
		public static readonly int _HGHiZOutput2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2FC")]
		public static readonly int _HGHiZOutput3;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x300")]
		public static readonly int _HGHiZMipChain;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x304")]
		public static readonly int _HGHiZRTSize;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x308")]
		public static readonly int _PerPassConstants;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x30C")]
		public static readonly int _PerPassConstantsToBe;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x310")]
		public static readonly int _ShaderVariablesGlobal;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x314")]
		public static readonly int _UIRenderingConstants;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x318")]
		public static readonly int _ShaderVariablesDebugDisplay;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x31C")]
		public static readonly int _GeneralGPUParticleSystemAttributes;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x320")]
		public static readonly int _GPUParticleSystemAttributes;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x324")]
		public static readonly int _PerFrameVariables;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x328")]
		public static readonly int _PerInstanceBuffer;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x32C")]
		public static readonly int _MergePassConstants;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x330")]
		public static readonly int _ParticleAttributes;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x334")]
		public static readonly int _DeadCount;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x338")]
		public static readonly int _DataForEmitter;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x33C")]
		public static readonly int _LiveCount;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x340")]
		public static readonly int _DeadList;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x344")]
		public static readonly int _LiveList;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x348")]
		public static readonly int _InputLiveList;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x34C")]
		public static readonly int _SortedLiveList;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x350")]
		public static readonly int _DrawIndirectArg;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x354")]
		public static readonly int _SceneNormal;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x358")]
		public static readonly int _DispatchSize;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x35C")]
		public static readonly int _InstanceCount;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x360")]
		public static readonly int _CleanupOffset;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x364")]
		public static readonly int _DepthOnlyRT;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x368")]
		public static readonly int _GPUEventSentCount;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x36C")]
		public static readonly int _GPUEventConsumedCount;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x370")]
		public static readonly int _GPUEventBuffer;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x374")]
		public static readonly int _BlitTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x378")]
		public static readonly int _BlitScaleBias;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x37C")]
		public static readonly int _BlitMipLevel;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x380")]
		public static readonly int _BlitTexArraySlice;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x384")]
		public static readonly int _BlurData;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x388")]
		public static readonly int _GaussianBlurTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x38C")]
		public static readonly int _CameraDepthTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x390")]
		public static readonly int _FoliageOccluderStateArray;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x394")]
		public static readonly int _FoliageOccluderScaleParam;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x398")]
		public static readonly int _FoliageOcclusionMask;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x39C")]
		public static readonly int _FoliageOccluderRenderMask;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x3A0")]
		public static readonly int _FoliageOccluderFinalMask;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x3A4")]
		public static readonly int _PrevFoliageOccluderTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x3A8")]
		public static readonly int _FoliageLODFadeValue;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x3AC")]
		public static readonly int _FoliageOccluderCameraPosParam;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x3B0")]
		public static readonly int _ClothDataClearCB;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x3B4")]
		public static readonly int _ClothDataUploadCB;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x3B8")]
		public static readonly int _ClothGroupUploadDataMapBuffer;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x3BC")]
		public static readonly int _InputClothMetaDataBuffer;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x3C0")]
		public static readonly int _InputClothNodeDataBuffer1;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x3C4")]
		public static readonly int _InputClothNodeDataBuffer2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x3C8")]
		public static readonly int _InputClothBatchMetaDataBuffer;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x3CC")]
		public static readonly int _InputClothBatchCacheMapBuffer;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x3D0")]
		public static readonly int _OutputClothNodeDataBuffer;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x3D4")]
		public static readonly int _OutputClothMetaDataBuffer;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x3D8")]
		public static readonly int _OutputClothBatchMetaDataBuffer;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x3DC")]
		public static readonly int _OutputClothBatchCacheMapBuffer;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x3E0")]
		public static readonly int _OutputClothSkeletonDataBuffer;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x3E4")]
		public static readonly int _ClothConstDataBuffer;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x3E8")]
		public static readonly int _ClothNodeDataBuffer;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x3EC")]
		public static readonly int _ClothMetaDataBuffer;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x3F0")]
		public static readonly int _ClothBatchMetaDataBuffer;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x3F4")]
		public static readonly int _ClothBatchCacheMapBuffer;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x3F8")]
		public static readonly int _ClothSkeletonDataBuffer;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x3FC")]
		public static readonly int _AtmosphereLutConstants;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x400")]
		public static readonly int _TransmittanceLut;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x404")]
		public static readonly int _TransmittanceLutUAV;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x408")]
		public static readonly int _MultiScatteredLuminanceLut;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x40C")]
		public static readonly int _MultiScatteredLuminanceLutUAV;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x410")]
		public static readonly int _SkyViewLut;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x414")]
		public static readonly int _SkyViewLutUAV;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x418")]
		public static readonly int _VolumetricFogVBufferA;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x41C")]
		public static readonly int _VolumetricFogVBufferB;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x420")]
		public static readonly int _LightScattering;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x424")]
		public static readonly int _LightScatteringHistory;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x428")]
		public static readonly int _RWIntegratedLightScattering;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x42C")]
		public static readonly int _IntegratedLightScattering;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x430")]
		public static readonly int _VolumetricLight3DNoise;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x434")]
		public static readonly int _VolumetricFogGridInjectionConstants;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x438")]
		public static readonly int _VolumetricFogLightScatteringConstants;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x43C")]
		public static readonly int _VoxelizationPassIndex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x440")]
		public static readonly int _VoxelizationClosestSliceIndex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x444")]
		public static readonly int _VoxelizationClipRatio;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x448")]
		public static readonly int _VoxelizationVolumePos;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x44C")]
		public static readonly int _VoxelizationVolumeRadius;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x450")]
		public static readonly int _VoxelizationViewSpacePos;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x454")]
		public static readonly int _VoxelizationWorldToObject;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x458")]
		public static readonly int _VoxelizationFrameJitterOffset;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x45C")]
		public static readonly int _VoxelizationViewToVolumeClip;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x460")]
		public static readonly int _Tint;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x464")]
		public static readonly int _Exposure;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x468")]
		public static readonly int _Rotation;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x46C")]
		public static readonly int _Tex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x470")]
		public static readonly int _SunDiscParam0;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x474")]
		public static readonly int _SunDiscParam1;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x478")]
		public static readonly int _SunDiscParam2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x47C")]
		public static readonly int _SkyBoxStarParam0;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x480")]
		public static readonly int _SkyBoxStarParam1;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x484")]
		public static readonly int _SkyBoxStarParam2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x488")]
		public static readonly int _SkyBoxStarParam3;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x48C")]
		public static readonly int _SkyBoxStarParam4;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x490")]
		public static readonly int _SkyBoxStarParam5;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x494")]
		public static readonly int _SkyBoxStarParam6;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x498")]
		public static readonly int _SkyBoxStarParam7;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x49C")]
		public static readonly int _SkyBoxStarTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x4A0")]
		public static readonly int _SkyBoxStarDensityTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x4A4")]
		public static readonly int _SkyBoxNebulaTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x4A8")]
		public static readonly int _CloudTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x4AC")]
		public static readonly int _CloudFlowMap;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x4B0")]
		public static readonly int _CloudParam;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x4B4")]
		public static readonly int _CloudFlowParam;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x4B8")]
		public static readonly int _CloudOpacities;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x4BC")]
		public static readonly int _CloudTint;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x4C0")]
		public static readonly int _Size;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x4C4")]
		public static readonly int _Source;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x4C8")]
		public static readonly int _SourceMip;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x4CC")]
		public static readonly int _SrcOffsetAndLimit;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x4D0")]
		public static readonly int _SrcScaleBias;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x4D4")]
		public static readonly int _SrcUvLimits;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x4D8")]
		public static readonly int _DstOffset;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x4DC")]
		public static readonly int _DepthMipChain;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x4E0")]
		public static readonly int _RingParams;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x4E4")]
		public static readonly int _RingUpWithBelow;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x4E8")]
		public static readonly int _RingFoward;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x4EC")]
		public static readonly int _RingRight;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x4F0")]
		public static readonly int _RingColor;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x4F4")]
		public static readonly int _RingAlbedoTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x4F8")]
		public static readonly int _PlanetCenterViewDir;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x4FC")]
		public static readonly int _IncidentLightDir;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x500")]
		public static readonly int _PlanetParams;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x504")]
		public static readonly int _RingTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x508")]
		public static readonly int _RingColorAlpha;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x50C")]
		public static readonly int _PlanetAtmosphereParams;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x510")]
		public static readonly int _PlanetAtmosphereParams2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x514")]
		public static readonly int _PlanetAtmosphereParams3;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x518")]
		public static readonly int _AtmosphereRTTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x51C")]
		public static readonly int _PlanetUpWs;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x520")]
		public static readonly int _PlanetForwardWs;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x524")]
		public static readonly int _PlanetRightWs;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x528")]
		public static readonly int[] _PlanetsInView;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x530")]
		public static readonly int[] _PlanetCenterPos01;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x538")]
		public static readonly int[] _PlanetCenterViewDir01;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x540")]
		public static readonly int[] _IncidentLightDir01;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x548")]
		public static readonly int[] _PlanetParams01;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x550")]
		public static readonly int[] _PlanetUpWs01;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x558")]
		public static readonly int[] _PlanetForwardWs01;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x560")]
		public static readonly int[] _PlanetRightWs01;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x568")]
		public static readonly int[] _PlanetColor01;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x570")]
		public static readonly int[] _RingShadowSoftness01;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x578")]
		public static readonly int[] _RingColorAlpha01;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x580")]
		public static readonly int[] _PlanetEmissive01;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x588")]
		public static readonly int[] _StarNdlSharp01;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x590")]
		public static readonly int[] _StarBackFaceAlpha01;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x598")]
		public static readonly int[] _PlanetBaseMap01;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x5A0")]
		public static readonly int[] _PlanetEmiMap01;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x5A8")]
		public static readonly int[] _PlanetRingTex01;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x5B0")]
		public static readonly int _PlanetBillBoardConstants;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x5B4")]
		public static readonly int _RealPlanetRadius;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x5B8")]
		public static readonly int _AtmosphereRatios;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x5BC")]
		public static readonly int _GlobalRadiusOffset;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x5C0")]
		public static readonly int _Density_Multiplier;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x5C4")]
		public static readonly int _g;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x5C8")]
		public static readonly int _StepsI;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x5CC")]
		public static readonly int _StepsL;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x5D0")]
		public static readonly int _Mie_Height_Scale;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x5D4")]
		public static readonly int _Pitch;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x5D8")]
		public static readonly int _Roll;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x5DC")]
		public static readonly int _Phi2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x5E0")]
		public static readonly int _Theta2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x5E4")]
		public static readonly int _Dist;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x5E8")]
		public static readonly int _CapThreshold;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x5EC")]
		public static readonly int _Roughness;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x5F0")]
		public static readonly int _BBRadius;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x5F4")]
		public static readonly int _Erosion;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x5F8")]
		public static readonly int _ErosionThreshold;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x5FC")]
		public static readonly int _CloudsAlphaMain;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x600")]
		public static readonly int _CloudsSpeedMain;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x604")]
		public static readonly int _IndirectIntensity;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x608")]
		public static readonly int _DirectLightIntensityBillboard;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x60C")]
		public static readonly int _Light_Intensity_Multiplier;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x610")]
		public static readonly int _Light_Intensity_Clouds_Multiplier;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x614")]
		public static readonly int _PlanetRotateStart;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x618")]
		public static readonly int _PlanetRotateSpeed;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x61C")]
		public static readonly int _CapTransition;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x620")]
		public static readonly int _CloudsFlowStrength;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x624")]
		public static readonly int _CloudsHeight;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x628")]
		public static readonly int _CloudsFlowSpeed;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x62C")]
		public static readonly int _Use_Lut;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x630")]
		public static readonly int _CustomLightColorPla;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x634")]
		public static readonly int _CustomLightDirection;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x638")]
		public static readonly int _UseRoughnessMap;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x63C")]
		public static readonly int _EnablePolarCap;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x640")]
		public static readonly int _UseErosionMap;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x644")]
		public static readonly int _Ray;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x648")]
		public static readonly int _Mie;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x64C")]
		public static readonly int _Ambient;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x650")]
		public static readonly int _PlanetWSBase;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x654")]
		public static readonly int _BBWSBase;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x658")]
		public static readonly int _PlanetScale;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x65C")]
		public static readonly int _FresnelColor;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x660")]
		public static readonly int _TintColor;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x664")]
		public static readonly int _SeaDeep;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x668")]
		public static readonly int _SeaShallow;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x66C")]
		public static readonly int _IndirectColor;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x670")]
		public static readonly int _CustomLightDir;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x674")]
		public static readonly int _CustomLightColPla;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x678")]
		public static readonly int _CloudsShadowColor;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x67C")]
		public static readonly int _BaseColorMap_ST;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x680")]
		public static readonly int _ErosionMap_ST;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x684")]
		public static readonly int _TransmittanceLLUT;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x688")]
		public static readonly int _BaseColorMap;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x68C")]
		public static readonly int _RSM;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x690")]
		public static readonly int _CloudsTexMain;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x694")]
		public static readonly int _CloudsCap;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x698")]
		public static readonly int _CloudsFlowMap;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x69C")]
		public static readonly int _ErosionMap;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x6A0")]
		public static readonly int[] _PlanetAtmosphereParamsPack;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x6A8")]
		public static readonly int[] _PlanetAtmosphereParams2Pack;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x6B0")]
		public static readonly int[] _PlanetAtmosphereParams3Pack;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x6B8")]
		public static readonly int _HGAutoExposureHistogramBuffer;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x6BC")]
		public static readonly int _AE_inputTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x6C0")]
		public static readonly int _AE_histogramBuffer;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x6C4")]
		public static readonly int _Variants;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x6C8")]
		public static readonly int _InputTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x6CC")]
		public static readonly int _OutputTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x6D0")]
		public static readonly int _Params;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x6D4")]
		public static readonly int _Params0;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x6D8")]
		public static readonly int _Params1;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x6DC")]
		public static readonly int _Params2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x6E0")]
		public static readonly int _Params3;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x6E4")]
		public static readonly int _TexelSize;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x6E8")]
		public static readonly int _FrostedGlassTexLight;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x6EC")]
		public static readonly int _FrostedGlassTexMedium;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x6F0")]
		public static readonly int _FrostedGlassTexHeavy;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x6F4")]
		public static readonly int _FrostedGlassTexLightScene;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x6F8")]
		public static readonly int _FrostedGlassTexMediumScene;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x6FC")]
		public static readonly int _FrostedGlassTexHeavyScene;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x700")]
		public static readonly int _ColorThreshold;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x704")]
		public static readonly int _LightShaftSceneColor;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x708")]
		public static readonly int _LightShaftSceneDepth;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x70C")]
		public static readonly int _LightShaftBlurSrc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x710")]
		public static readonly int _LightShaftBlurResult;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x714")]
		public static readonly int _LightShaftBlurPassIndex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x718")]
		public static readonly int _LightShaftCloudMask;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x71C")]
		public static readonly int _LightShaftParams0;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x720")]
		public static readonly int _LightShaftParams1;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x724")]
		public static readonly int _LightShaftParams2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x728")]
		public static readonly int _LightShaftParams3;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x72C")]
		public static readonly int _LightShaftCloudMaskParams;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x730")]
		public static readonly int _BloomParams;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x734")]
		public static readonly int _BloomTint;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x738")]
		public static readonly int _BloomTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x73C")]
		public static readonly int _BloomDirtTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x740")]
		public static readonly int _BloomDirtScaleOffset;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x744")]
		public static readonly int _InputLowTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x748")]
		public static readonly int _InputHighTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x74C")]
		public static readonly int _BloomBicubicParams;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x750")]
		public static readonly int _BloomThreshold;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x754")]
		public static readonly int _BloomCharacterThreshold;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x758")]
		public static readonly int _BloomCharacterParams;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x75C")]
		public static readonly int _BloomBuffer;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x760")]
		public static readonly int _RadialBlurParams;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x764")]
		public static readonly int _RadialBlurParams2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x768")]
		public static readonly int _BWFlashThreshold;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x76C")]
		public static readonly int _BWFlashParams;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x770")]
		public static readonly int _BWFlashParams2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x774")]
		public static readonly int _BWFlashParams3;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x778")]
		public static readonly int _BWFlashParams4;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x77C")]
		public static readonly int _BWFlashTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x780")]
		public static readonly int _BWMaskTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x784")]
		public static readonly int _BWFlashColor;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x788")]
		public static readonly int _BWBackGroundColor;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x78C")]
		public static readonly int _FisheyeEffectParams1;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x790")]
		public static readonly int _ScanLineTint;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x794")]
		public static readonly int _ScanLineMask;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x798")]
		public static readonly int _ScanLineCenterPos;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x79C")]
		public static readonly int _ScanLineParams1;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x7A0")]
		public static readonly int _ScanLineParams2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x7A4")]
		public static readonly int _ScanLineParams3;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x7A8")]
		public static readonly int _ScanLineParams4;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x7AC")]
		public static readonly int _ScanLineParams5;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x7B0")]
		public static readonly int _ScanLineParams6;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x7B4")]
		public static readonly int _ScanLineParams7;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x7B8")]
		public static readonly int _ScanLineParams8;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x7BC")]
		public static readonly int _ScanLineParams9;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x7C0")]
		public static readonly int _ScanLineParams10;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x7C4")]
		public static readonly int _ScanLineHighlightHeight;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x7C8")]
		public static readonly int _BoxPosWS;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x7CC")]
		public static readonly int _ScanLineHighlightTint;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x7D0")]
		public static readonly int _ScanLineHighlightBeamTint;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x7D4")]
		public static readonly int _BoxPosition1;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x7D8")]
		public static readonly int _BoxPosition2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x7DC")]
		public static readonly int _BoxPosition3;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x7E0")]
		public static readonly int _BoxVec1;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x7E4")]
		public static readonly int _BoxVec2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x7E8")]
		public static readonly int _BoxVec3;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x7EC")]
		public static readonly int _CountPerArray;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x7F0")]
		public static readonly int _MeshHeight;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x7F4")]
		public static readonly int _BlackBoxBackGroundTint;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x7F8")]
		public static readonly int _BlackBoxContourColor;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x7FC")]
		public static readonly int _BlackBoxCenterPos;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x800")]
		public static readonly int _BlackBoxParams1;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x804")]
		public static readonly int _BlackBoxParams2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x808")]
		public static readonly int _BlackBoxParams3;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x80C")]
		public static readonly int _BlackBoxParams4;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x810")]
		public static readonly int _BlackBoxParams5;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x814")]
		public static readonly int _BlackBoxContourTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x818")]
		public static readonly int _SharpenParams;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x81C")]
		public static readonly int _PPSharpen;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x820")]
		public static readonly int _PostProcessMask;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x824")]
		public static readonly int _FrostedGlassTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x828")]
		public static readonly int _FrostedGlassBuffer;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x82C")]
		public static readonly int _VignetteParams1;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x830")]
		public static readonly int _VignetteParams2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x834")]
		public static readonly int _VignetteColor;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x838")]
		public static readonly int _VignetteMask;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x83C")]
		public static readonly int _DirtyTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x840")]
		public static readonly int _DirtyLensParams1;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x844")]
		public static readonly int _LogLut3D;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x848")]
		public static readonly int _LogLut3D_Params;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x84C")]
		public static readonly int _LogLut2D;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x850")]
		public static readonly int _Lut_Params;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x854")]
		public static readonly int _UserLut;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x858")]
		public static readonly int _UserLut_Params;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x85C")]
		public static readonly int _ColorBalance;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x860")]
		public static readonly int _ColorFilter;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x864")]
		public static readonly int _ChannelMixerRed;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x868")]
		public static readonly int _ChannelMixerGreen;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x86C")]
		public static readonly int _ChannelMixerBlue;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x870")]
		public static readonly int _HueSatCon;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x874")]
		public static readonly int _Lift;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x878")]
		public static readonly int _Gamma;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x87C")]
		public static readonly int _Gain;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x880")]
		public static readonly int _Shadows;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x884")]
		public static readonly int _Midtones;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x888")]
		public static readonly int _Highlights;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x88C")]
		public static readonly int _ShaHiLimits;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x890")]
		public static readonly int _SplitShadows;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x894")]
		public static readonly int _SplitHighlights;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x898")]
		public static readonly int _CurveMaster;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x89C")]
		public static readonly int _CurveRed;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x8A0")]
		public static readonly int _CurveGreen;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x8A4")]
		public static readonly int _CurveBlue;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x8A8")]
		public static readonly int _CurveHueVsHue;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x8AC")]
		public static readonly int _CurveHueVsSat;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x8B0")]
		public static readonly int _CurveSatVsSat;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x8B4")]
		public static readonly int _CurveLumVsSat;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x8B8")]
		public static readonly int _CustomToneCurve;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x8BC")]
		public static readonly int _ToeSegmentA;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x8C0")]
		public static readonly int _ToeSegmentB;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x8C4")]
		public static readonly int _MidSegmentA;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x8C8")]
		public static readonly int _MidSegmentB;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x8CC")]
		public static readonly int _ShoSegmentA;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x8D0")]
		public static readonly int _ShoSegmentB;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x8D4")]
		public static readonly int _OwenScrambledTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x8D8")]
		public static readonly int _ScramblingTileXSPP;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x8DC")]
		public static readonly int _RankingTileXSPP;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x8E0")]
		public static readonly int _ScramblingTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x8E4")]
		public static readonly int _AfterPostProcessTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x8E8")]
		public static readonly int _UVTransform;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x8EC")]
		public static readonly int _InputTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x8F0")]
		public static readonly int _LoD;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x8F4")]
		public static readonly int _FaceIndex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x8F8")]
		public static readonly int _ViewPortSize;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x8FC")]
		public static readonly int _Dst3DTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x900")]
		public static readonly int _Src3DTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x904")]
		public static readonly int _AlphaOnlyTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x908")]
		public static readonly int _SrcSize;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x90C")]
		public static readonly int _SrcMip;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x910")]
		public static readonly int _SrcScale;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x914")]
		public static readonly int _SrcOffset;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x918")]
		public static readonly int _UseLighting;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x91C")]
		public static readonly int _UseBright;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x920")]
		public static readonly int _UseSoftBlend;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x924")]
		public static readonly int _UseEdgeColor;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x928")]
		public static readonly int _UseFresnel;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x92C")]
		public static readonly int _UseFog;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x930")]
		public static readonly int _UseVertexOffset;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x934")]
		public static readonly int _UsedForUI;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x938")]
		public static readonly int _UseTrail;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x93C")]
		public static readonly int _UseSafeZoneMap;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x940")]
		public static readonly int _UseAlphaTest;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x944")]
		public static readonly int _UseNearCameraFade;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x948")]
		public static readonly int _UseVFXPortal;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x94C")]
		public static readonly int _DisableZTest;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x950")]
		public static readonly int _DisableVertColor;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x954")]
		public static readonly int _IsUI;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x958")]
		public static readonly int _InParticle;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x95C")]
		public static readonly int _IgnorePostExposure;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x960")]
		public static readonly int _EnableHoudiniVAT;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x964")]
		public static readonly int _SceneDepth;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x968")]
		public static readonly int _MotionVector;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x96C")]
		public static readonly int _CurrDilatedDepth;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x970")]
		public static readonly int _PrevDilatedDepth;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x974")]
		public static readonly int _CurrDilatedMV;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x978")]
		public static readonly int _PrevDilatedMV;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x97C")]
		public static readonly int _CurrDilatedMask;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x980")]
		public static readonly int _HistorySceneColor;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x984")]
		public static readonly int _TAAUConstants;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x988")]
		public static readonly int _CapsuleShadowData1;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x98C")]
		public static readonly int _CapsuleShadowData2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x990")]
		public static readonly int _CapsuleShadowData3;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x994")]
		public static readonly int _CapsuleShadowData4;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x998")]
		public static readonly int _FlareOcclusionTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x99C")]
		public static readonly int _FlareOcclusionIndex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x9A0")]
		public static readonly int _FlareTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x9A4")]
		public static readonly int _FlareColorValue;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x9A8")]
		public static readonly int _FlareData0;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x9AC")]
		public static readonly int _FlareData1;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x9B0")]
		public static readonly int _FlareData2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x9B4")]
		public static readonly int _FlareData3;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x9B8")]
		public static readonly int _FlareData4;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x9BC")]
		public static readonly int _FlareData5;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x9C0")]
		public static readonly int _LowDoFParams;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x9C4")]
		public static readonly int _LowDoFCoCRT;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x9C8")]
		public static readonly int _CompositeRT;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x9CC")]
		public static readonly int _SSRData;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x9D0")]
		public static readonly int _SSRParams0;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x9D4")]
		public static readonly int _SSRParams1;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x9D8")]
		public static readonly int _SSRParams2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x9DC")]
		public static readonly int _SSRParams3;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x9E0")]
		public static readonly int _SSRParams4;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x9E4")]
		public static readonly int _SSRRTSize;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x9E8")]
		public static readonly int _SSRLRSize;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x9EC")]
		public static readonly int _SSRHRSize;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x9F0")]
		public static readonly int _SSRProjMatrix;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x9F4")]
		public static readonly int _SSRInvProjMatrix;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x9F8")]
		public static readonly int _SSRInvViewProjMatrix;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x9FC")]
		public static readonly int _SSRWorldToViewMatrix;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA00")]
		public static readonly int _SSRCurrSceneColor;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA04")]
		public static readonly int _SSRPrevSceneColor;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA08")]
		public static readonly int _SSRSceneDepth;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA0C")]
		public static readonly int _SSRSceneStencil;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA10")]
		public static readonly int _SSRSceneDepthPyramid;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA14")]
		public static readonly int _SSRGBuffer;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA18")]
		public static readonly int _SSRMotionVector;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA1C")]
		public static readonly int _SSRRT0;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA20")]
		public static readonly int _SSRRT1;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA24")]
		public static readonly int _SSRRT2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA28")]
		public static readonly int _SSRRT_Mobile0;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA2C")]
		public static readonly int _SSRRT_Mobile1;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA30")]
		public static readonly int _SSRRT_Mobile2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA34")]
		public static readonly int _SSRHitUVZRT;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA38")]
		public static readonly int _SSRHitColorRT;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA3C")]
		public static readonly int _SSRLastColorRT;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA40")]
		public static readonly int _SSRCurrColorRT;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA44")]
		public static readonly int _TemporalFilterOutRT0;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA48")]
		public static readonly int _TemporalFilterOutRT1;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA4C")]
		public static readonly int _SSRRayTracingMaskRT;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA50")]
		public static readonly int _SSRLightingTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA54")]
		public static readonly int _SSRFadenessTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA58")]
		public static readonly int _ISSRParam0;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA5C")]
		public static readonly int _ISSRParam1;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA60")]
		public static readonly int _ISSRParam2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA64")]
		public static readonly int _ISSRParam3;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA68")]
		public static readonly int _ISSRScreenSize;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA6C")]
		public static readonly int _ISSRHalfScreenSize;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA70")]
		public static readonly int _ISSRCurrSceneDepthTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA74")]
		public static readonly int _ISSRGBufferMVTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA78")]
		public static readonly int _ISSRRayMarchingPackDataTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA7C")]
		public static readonly int _ISSRPrevSceneColorTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA80")]
		public static readonly int _ISSRUnpackTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA84")]
		public static readonly int _ISSRPrevTemporalTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA88")]
		public static readonly int _ISSRCurrTemporalTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA8C")]
		public static readonly int _ISSRPrevMipRTSize;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA90")]
		public static readonly int _ISSRCurrMipRTSize;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA94")]
		public static readonly int _ISSRPrevMipSceneColorTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA98")]
		public static readonly int _ISSRCurrMipSceneColorTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA9C")]
		public static readonly int _ISSRReflectionMipChainTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xAA0")]
		public static readonly int _ISSRResolveTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xAA4")]
		public static readonly int _ISSRReflectionTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xAA8")]
		public static readonly int _ISSRUpsamplingTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xAAC")]
		public static readonly int _FakePlanarReflectionTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xAB0")]
		public static readonly int _RayTracingDataParams;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xAB4")]
		public static readonly int _ContactShadowDataParams;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xAB8")]
		public static readonly int _ContactShadowWorkgroupOffset;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xABC")]
		public static readonly int _ContactShadowDepthBuffer;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xAC0")]
		public static readonly int _ContactShadowStencilBuffer;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xAC4")]
		public static readonly int _ContactShadowContactShadow;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xAC8")]
		public static readonly int _ContactShadowContactShadowTemp;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xACC")]
		public static readonly int _GTAOData;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xAD0")]
		public static readonly int _GTAOParam0;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xAD4")]
		public static readonly int _GTAOParam1;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xAD8")]
		public static readonly int _GTAOParam2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xADC")]
		public static readonly int _GTAOParam3;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xAE0")]
		public static readonly int _GTAOHalfScreenSize;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xAE4")]
		public static readonly int _GTAODepthMIPs;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xAE8")]
		public static readonly int _GTAOOutAOTerm;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xAEC")]
		public static readonly int _GTAOOutEdges;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xAF0")]
		public static readonly int _GTAODepthMip0;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xAF4")]
		public static readonly int _GTAODepthMip1;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xAF8")]
		public static readonly int _GTAODepthMip2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xAFC")]
		public static readonly int _GTAODepthMip3;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB00")]
		public static readonly int _GTAODepthMip4;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB04")]
		public static readonly int _GTAOInAOTerm;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB08")]
		public static readonly int _GTAOInEdges;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB0C")]
		public static readonly int _GTAOOutRT;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB10")]
		public static readonly int _GTAOMainAOTermRT;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB14")]
		public static readonly int _GTAOMotionVectorRT;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB18")]
		public static readonly int _GTAOPreviousAOTermRT;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB1C")]
		public static readonly int _GTAOCurrentAOTermRT;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB20")]
		public static readonly int _GTAOBlurAOTermInRT;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB24")]
		public static readonly int _GTAOBlurAOTermOutRT;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB28")]
		public static readonly int _GTAOBlurAOTermRT;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB2C")]
		public static readonly int _GTAOUpsampleAOTermRT;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB30")]
		public static readonly int _WaterData;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB34")]
		public static readonly int _WaterOcclusionData;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB38")]
		public static readonly int _WaterOcclusionTilePassCB;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB3C")]
		public static readonly int _WaterTesellationDrawIndirectArgsCB;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB40")]
		public static readonly int _WaterInteractiveCB;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB44")]
		public static readonly int _WaterProxy;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB48")]
		public static readonly int _WaterDecal;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB4C")]
		public static readonly int _WaterInteractiveTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB50")]
		public static readonly int _WaterPrepassDataTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB54")]
		public static readonly int _WaterPrepassNormalTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB58")]
		public static readonly int _WaterPrepassDisplacementTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB5C")]
		public static readonly int _WaterPrepassDepthTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB60")]
		public static readonly int _WaterPrepassDataGlobalTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB64")]
		public static readonly int _WaterPrepassNormalGlobalTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB68")]
		public static readonly int _WaterPrepassDepthGlobalTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB6C")]
		public static readonly int _NormalRoughnessTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB70")]
		public static readonly int _WaterLocalFlowmapTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB74")]
		public static readonly int _WaterRippleTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB78")]
		public static readonly int _WaterGlobalFlowmapTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB7C")]
		public static readonly int _WaterGlobalSmallWaveNormalTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB80")]
		public static readonly int _WaterGlobalLargeWaveNormalTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB84")]
		public static readonly int _WaterGlobalNormalTextureArray;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB88")]
		public static readonly int _WaterGlobalCausticTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB8C")]
		public static readonly int _WaterGlobalRainTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB90")]
		public static readonly int _WaterReflectLightingTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB94")]
		public static readonly int _WaterReflectFadenessTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB98")]
		public static readonly int _WaterWetnessMaskTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB9C")]
		public static readonly int _WaterWetnessMask3dNoiseTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xBA0")]
		public static readonly int _FoliageInteractiveTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xBA4")]
		public static readonly int _PrevFoliageInteractiveTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xBA8")]
		public static readonly int _DynamicSludgeTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xBAC")]
		public static readonly int _PrevDynamicSludgeTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xBB0")]
		public static readonly int _SludgeThicknessTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xBB4")]
		public static readonly int _PrevSludgeThicknessTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xBB8")]
		public static readonly int _PrevSludgeMinHeightTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xBBC")]
		public static readonly int _WindGlobalNoiseTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xBC0")]
		public static readonly int _HeightFogNoise3DTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xBC4")]
		public static readonly int _FogBakeLutTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xBC8")]
		public static readonly int _DepthOfFieldData;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xBD0")]
		public static readonly int[] _MotionBlurHistoryTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xBD8")]
		public static readonly int _UIImageBlurTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xBDC")]
		public static readonly int _ColorBuffer;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xBE0")]
		public static readonly int _PPColor;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xBE4")]
		public static readonly int _RWDebugFullScreenBuffer;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xBE8")]
		public static readonly int _HistogramDebugBuffer;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xBEC")]
		public static readonly int _HistogramSize;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xBF0")]
		public static readonly int _HistogramMin;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xBF4")]
		public static readonly int _HistogramMax;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xBF8")]
		public static readonly int _FlipY;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xBFC")]
		public static readonly int _IrradianceVolumeAtlas0;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC00")]
		public static readonly int _IrradianceVolumeAtlas1;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC04")]
		public static readonly int _IrradianceVolumeAtlas;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC08")]
		public static readonly int _FlattenIndexBuffer;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC0C")]
		public static readonly int _IrradianceDataBuffer;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC10")]
		public static readonly int _EnableIV;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC14")]
		public static readonly int _IVNormalOffset;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC18")]
		public static readonly int _ChunkNumPerDim;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC1C")]
		public static readonly int _GlobalHashTable;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC20")]
		public static readonly int _HashTableCenterCoord;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC24")]
		public static readonly int _IrradianceVolumeIndirectTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC28")]
		public static readonly int _IrradianceVolumeChunkStartPos;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC2C")]
		public static readonly int _IndirectCenterPos;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC30")]
		public static readonly int _IndirectPreCenterPos;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC34")]
		public static readonly int _CameraUpdateCnt;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC38")]
		public static readonly int _ChunkUpdateCnt;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC3C")]
		public static readonly int _IrradianceVolumeClipmapTextureALod0;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC40")]
		public static readonly int _IrradianceVolumeClipmapTextureBLod0;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC44")]
		public static readonly int _IrradianceVolumeClipmapTextureALod1;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC48")]
		public static readonly int _IrradianceVolumeClipmapTextureBLod1;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC4C")]
		public static readonly int _IrradianceVolumeClipmapTextureALod3;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC50")]
		public static readonly int _IrradianceVolumeClipmapTextureBLod3;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC54")]
		public static readonly int _RainTex0;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC58")]
		public static readonly int _RainTex0_ST;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC5C")]
		public static readonly int _RainTex1;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC60")]
		public static readonly int _RainTex1_ST;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC64")]
		public static readonly int _RainParams;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC68")]
		public static readonly int _RainMaskParams;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC6C")]
		public static readonly int _RainDirectionParams;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC70")]
		public static readonly int _RainColor;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC74")]
		public static readonly int _ScreenDropFXNoiseTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC78")]
		public static readonly int _ScreenDropFXNoiseTex_ST;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC7C")]
		public static readonly int _ScreenDropRenderDatas;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC80")]
		public static readonly int _RainOcclusionSampleNoise;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC84")]
		public static readonly int _VerticalFlowTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC88")]
		public static readonly int _RippleTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC8C")]
		public static readonly int _VerticalOcclusionMap;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC90")]
		public static readonly int _VerticalOcclusionMapTransformCB;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC94")]
		public static readonly int _CameraHeightRefreshDataCB;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC98")]
		public static readonly int _CustomDepthOnlyRT;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC9C")]
		public static readonly int _GlintPatternTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xCA0")]
		public static readonly int _GlintTopBlendSmoothness;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xCA4")]
		public static readonly int _GlintTopBlendThreshold;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xCA8")]
		public static readonly int _GlintStrength;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xCAC")]
		public static readonly int _GlintScale;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xCB0")]
		public static readonly int _GlintThreshold;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xCB4")]
		public static readonly int _GlintFadeDistance;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xCB8")]
		public static readonly int _GlintColor;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xCBC")]
		public static readonly int _UseSubsurfaceProfile;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xCC0")]
		public static readonly int _SurfaceAlbedo;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xCC4")]
		public static readonly int _MeanFreePathColor;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xCC8")]
		public static readonly int _MeanFreePathDistance;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xCCC")]
		public static readonly int _DiffuseMeanFreePath;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xCD0")]
		public static readonly int _LutMaxRadius;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xCD4")]
		public static readonly int _LutMaxPenumbra;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xCD8")]
		public static readonly int _SubsurfaceOriginNormalTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xCDC")]
		public static readonly int _SubsurfaceNormalWorldRange;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xCE0")]
		public static readonly int _SubsurfaceCurvatureTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xCE4")]
		public static readonly int _SubsurfaceNormalCurvatureTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xCE8")]
		public static readonly int _OutScatterLut;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xCEC")]
		public static readonly int _OutPenumbraLut;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xCF0")]
		public static readonly int _OutIndirectLut;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xCF4")]
		public static readonly int _CurvatureScale;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xCF8")]
		public static readonly int _PenumbraScale;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xCFC")]
		public static readonly int _SubsurfaceProfileInt;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xD00")]
		public static readonly int _TerrainSubsurfaceProfileInt;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xD04")]
		public static readonly int _SubsurfaceScatterLutArray;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xD08")]
		public static readonly int _SubsurfacePenumbraLutArray;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xD0C")]
		public static readonly int _SubsurfaceIndirectLutArray;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xD10")]
		public static readonly int _SubsurfaceProfileConstants;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xD14")]
		public static readonly int _SubsurfaceCurvatureScale;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xD18")]
		public static readonly int _SubsurfaceCurvatureOffset;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xD1C")]
		public static readonly int _TerrainStencilRef;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xD20")]
		public static readonly int _SeparateTerrainStencilRef;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xD24")]
		public static readonly int _TerrainSubsurfaceConstants;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xD28")]
		public static readonly int _EnableSubsurface;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xD2C")]
		public static readonly int _SubsurfaceColor;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xD30")]
		public static readonly int _SubsurfaceValue;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xD34")]
		public static readonly int _SubsurfaceHue;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xD38")]
		public static readonly int _SubsurfaceSaturation;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xD3C")]
		public static readonly int _SubsurfaceIndirect;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xD40")]
		public static readonly int _SubsurfaceInt;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xD44")]
		public static readonly int _SubsurfaceConstants;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xD48")]
		public static readonly int _VisibilitySHConstData;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xD4C")]
		public static readonly int _VisibilityCapsuleData;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xD50")]
		public static readonly int _LogSHLutTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xD54")]
		public static readonly int _ABLutTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xD58")]
		public static readonly int _VisibilitySHRT;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xD5C")]
		public static readonly int _VisibilitySHDebugRT;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xD60")]
		public static readonly int _FakeVolumeIoR;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xD64")]
		public static readonly int _FakeVolumeFresnelStrength;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xD68")]
		public static readonly int _FakeVolumeOpacityMask;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xD6C")]
		public static readonly int _FakeVolumeOpacityTiling;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xD70")]
		public static readonly int _FakeVolumeMask;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xD74")]
		public static readonly int _FakeCrackLayerTiling;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xD78")]
		public static readonly int _FakeCrackTint;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xD7C")]
		public static readonly int _FakeCrackHeightScale;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xD80")]
		public static readonly int _FakeCrackDepth;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xD84")]
		public static readonly int _FakeCrackMarchSteps;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xD88")]
		public static readonly int _FakeRefractionTint;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xD8C")]
		public static readonly int _FakeRefractionLayerTiling;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xD90")]
		public static readonly int _FakeVolumeScatterExtinction;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xD94")]
		public static readonly int _FakeVolumeScatterAlbedo;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xD98")]
		public static readonly int _FakeRefractionHeightScale;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xD9C")]
		public static readonly int _FakeRefractionDepth;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xDA0")]
		public static readonly int _FakeRefractionMarchSteps;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xDA4")]
		public static readonly int _FakeDustLayerTiling;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xDA8")]
		public static readonly int _FakeDustDepth;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xDAC")]
		public static readonly int _FakeDustFlowSpeed;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xDB0")]
		public static readonly int _FakeDustTint;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xDB4")]
		public static readonly int _FakeShadowPenumbra;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xDB8")]
		public static readonly int _FakeShadowStrength;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xDBC")]
		public static readonly int _FakeShadowMarchSteps;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xDC0")]
		public static readonly int _FakeShadowDistanceLerp;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xDC4")]
		public static readonly int _InteractionDataCB;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xDC8")]
		public static readonly int _GroundHeight;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xDCC")]
		public static readonly int _InteractRadius;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xDD0")]
		public static readonly int _InteractLength;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xDD4")]
		public static readonly int _InteractHeight;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xDD8")]
		public static readonly int _InteractHeightScale;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xDDC")]
		public static readonly int _InteractMaskTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xDE0")]
		public static readonly int _InteractWorldToLocal;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xDE4")]
		public static readonly int _PrevInteractLocalToWorld;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xDE8")]
		public static readonly int _CapsuleLocalHeight;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xDEC")]
		public static readonly int _DecalInteractionDataCB;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xDF0")]
		public static readonly int _DecalInteractionSettingDataCB;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xDF4")]
		public static readonly int _EdgeFadeRatio;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xDF8")]
		public static readonly int _GPUDrivenHZB;
	}
}
