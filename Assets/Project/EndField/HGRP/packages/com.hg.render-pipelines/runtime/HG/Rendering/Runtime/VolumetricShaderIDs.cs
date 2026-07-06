using System;

namespace HG.Rendering.Runtime
{
	public static class VolumetricShaderIDs
	{
		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		internal static readonly int _InvPartialVPMatrix;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x04")]
		internal static readonly int _MainTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		internal static readonly int _Cull;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x0C")]
		internal static readonly int _ZTest;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		internal static readonly int _GlobalScale;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x14")]
		internal static readonly int _InvGlobalScale;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x18")]
		internal static readonly int _InvResolution;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1C")]
		internal static readonly int _SdfStepScale;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x20")]
		internal static readonly int _SdfOffset;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x24")]
		internal static readonly int _SdfChannel;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x28")]
		internal static readonly int _SdfFlipZY;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2C")]
		internal static readonly int _LocalRayOrigin;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x30")]
		internal static readonly int _BoxWorldToLocal;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x34")]
		internal static readonly int _BoxLocalToWorld;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x38")]
		internal static readonly int _BoxCenter;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x3C")]
		internal static readonly int _VoxelSize;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x40")]
		internal static readonly int _InvScale;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x44")]
		internal static readonly int _SdfDensityRange;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x48")]
		internal static readonly int _Cubic;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x4C")]
		internal static readonly int _ShapeTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x50")]
		internal static readonly int _ShapeOffset;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x54")]
		internal static readonly int _ShapeTiling;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x58")]
		internal static readonly int _ShapePow;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x5C")]
		internal static readonly int _ShapeStrength;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x60")]
		internal static readonly int _NoiseTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x64")]
		internal static readonly int _NoiseTiling;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x68")]
		internal static readonly int _NoiseMipFalloff;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x6C")]
		internal static readonly int _NoiseMipFalloffRemap;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x70")]
		internal static readonly int _NoiseMipFalloff2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x74")]
		internal static readonly int _NoiseMipFalloffRemap2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x78")]
		internal static readonly int _NoiseType;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x7C")]
		internal static readonly int _NoisePow;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x80")]
		internal static readonly int _NoiseStrength;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x84")]
		internal static readonly int _DensityLerpDistance;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x88")]
		internal static readonly int _DensityLerpDistanceRemap;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x8C")]
		internal static readonly int _DensityPow;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x90")]
		internal static readonly int _DensityPowNear;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x94")]
		internal static readonly int _Extinction;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x98")]
		internal static readonly int _ExtinctionNear;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x9C")]
		internal static readonly int _Albedo;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA0")]
		internal static readonly int _AOFalloffRange;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA4")]
		internal static readonly int _MarchRange;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA8")]
		internal static readonly int _MarchRangeLocal;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xAC")]
		internal static readonly int _MarchStepNum;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB0")]
		internal static readonly int _InvMarchStepNum;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB4")]
		internal static readonly int _MarchStepNumEdit;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB8")]
		internal static readonly int _PreviewMarchStepNum;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xBC")]
		internal static readonly int _BlueNoiseTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC0")]
		internal static readonly int _StepNoiseScale;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC4")]
		internal static readonly int _StepNoiseScaleRemap;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC8")]
		internal static readonly int _DynamicStepRange;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xCC")]
		internal static readonly int _DynamicStepScale;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xD0")]
		internal static readonly int _ShadowDistance;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xD4")]
		internal static readonly int _ShadowStepNum;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xD8")]
		internal static readonly int _ShadowIntensity;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xDC")]
		internal static readonly int _ShadowNearScale;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xE0")]
		internal static readonly int _ShadowLerpDistance;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xE4")]
		internal static readonly int _ShadowLerpDistanceRemap;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xE8")]
		internal static readonly int _SceneShadowOpticalDepthScale;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xEC")]
		internal static readonly int _UseSunDirection;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xF0")]
		internal static readonly int _YawOffset;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xF4")]
		internal static readonly int _PitchOffset;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xF8")]
		internal static readonly int _MainLightDirection;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xFC")]
		internal static readonly int _MainLighting;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x100")]
		internal static readonly int _MainLightColor;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x104")]
		internal static readonly int _MainLightIntensity;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x108")]
		internal static readonly int _SkyLighting;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10C")]
		internal static readonly int _SkyLightColor;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x110")]
		internal static readonly int _SkyLightIntensity;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x114")]
		internal static readonly int _PhaseG;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x118")]
		internal static readonly int _PhaseG2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x11C")]
		internal static readonly int _PhaseK;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x120")]
		internal static readonly int _PhaseK2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x124")]
		internal static readonly int _PhaseBlend;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x128")]
		internal static readonly int _MSTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x12C")]
		internal static readonly int _MsOctaveCount;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x130")]
		internal static readonly int _MsScatteringFactor;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x134")]
		internal static readonly int _MsExtinctionFactor;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x138")]
		internal static readonly int _MsPhaseFactor;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x13C")]
		internal static readonly int _MsFalloffRange;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x140")]
		internal static readonly int _MsFalloffRangeRemap;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x144")]
		internal static readonly int _MsFade;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x148")]
		internal static readonly int _OpticalDepthScale;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x14C")]
		internal static readonly int _InvOpticalDepthScale;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x150")]
		internal static readonly int _MsEncodeParams;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x154")]
		internal static readonly int _GodRayStepNum;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x158")]
		internal static readonly int _InvGodRayStepNum;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x15C")]
		internal static readonly int _GodRayStepNumEdit;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x160")]
		internal static readonly int _GodRayPreviewStepNum;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x164")]
		internal static readonly int _GodRayDensityBias;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x168")]
		internal static readonly int _GodRayPow;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x16C")]
		internal static readonly int _GodRayIntensity;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x170")]
		internal static readonly int _GodRayDepthSmooth;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x174")]
		internal static readonly int _InvGodRayDepthSmooth;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x178")]
		internal static readonly int _GodRayBlurCount;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x17C")]
		internal static readonly int _GodRayBlurWidth;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x180")]
		internal static readonly int _GodrayCubic;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x184")]
		internal static readonly int _FogBaseHeight;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x188")]
		internal static readonly int _FogHeightFalloff;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x18C")]
		internal static readonly int _FogColor;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x190")]
		internal static readonly int _EmissiveLighting1;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x194")]
		internal static readonly int _EmissiveColor1;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x198")]
		internal static readonly int _EmissiveIntensity1;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x19C")]
		internal static readonly int _EmissiveFalloff1;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1A0")]
		internal static readonly int _EmissiveLighting2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1A4")]
		internal static readonly int _EmissiveColor2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1A8")]
		internal static readonly int _EmissiveIntensity2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1AC")]
		internal static readonly int _EmissiveFalloff2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1B0")]
		internal static readonly int _DensityRemap;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1B4")]
		internal static readonly int _DensityRemapOpt1;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1B8")]
		internal static readonly int _DensityRemapOpt2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1BC")]
		internal static readonly int _BaseColorScale;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1C0")]
		internal static readonly int _ColorNoiseTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1C4")]
		internal static readonly int _NoiseColor;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1C8")]
		internal static readonly int _ColorNoiseSpeed;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1CC")]
		internal static readonly int _ColorNoiseTiling;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1D0")]
		internal static readonly int _ColorNoisePow;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1D4")]
		internal static readonly int _BackgroundCloud;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1D8")]
		internal static readonly int _BackgroundCloudSize;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1DC")]
		internal static readonly int _HeightOffset;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1E0")]
		internal static readonly int _StartDistance;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1E4")]
		internal static readonly int _HeightRange;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1E8")]
		internal static readonly int _HeightRangeRemap;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1EC")]
		internal static readonly int _EmptySkipRTScale;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1F0")]
		internal static readonly int _EmptySkipUVScale;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1F4")]
		internal static readonly int _MainCameraPos;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1F8")]
		internal static readonly int _MainCameraPosLocal;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1FC")]
		internal static readonly int _MainCameraFovTan;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x200")]
		internal static readonly int _EmptySkipRTSize;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x204")]
		internal static readonly int _EmptySkipRT;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x208")]
		internal static readonly int _EmptySkipRange;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x20C")]
		internal static readonly int _EnableEmptySkipSample;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x210")]
		internal static readonly int _EmptySkipStepNum;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x214")]
		internal static readonly int _EmptySkipSdfScale;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x218")]
		internal static readonly int _DensityTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x21C")]
		internal static readonly int _AdvancedTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x220")]
		internal static readonly int _SHTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x224")]
		internal static readonly int _WindSpeed;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x228")]
		internal static readonly int _WindSpeed2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x22C")]
		internal static readonly int _WindSpeed3;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x230")]
		internal static readonly int _WindPhase;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x234")]
		internal static readonly int _WindPhase2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x238")]
		internal static readonly int _WindPhase3;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x23C")]
		internal static readonly int _WindOffset;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x240")]
		internal static readonly int _WindOffset2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x244")]
		internal static readonly int _WindOffset3;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x248")]
		internal static readonly int _WindLerpDistance;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x24C")]
		internal static readonly int _WindFieldNum;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x250")]
		internal static readonly int _WindFieldDataCB;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x254")]
		internal static readonly int _WindFieldTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x258")]
		internal static readonly int _WindOffsetScale;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x25C")]
		internal static readonly int _InvWindOffsetScale;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x260")]
		internal static readonly int _PanoramicUpdateDistance;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x264")]
		internal static readonly int _FarCubic;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x268")]
		internal static readonly int _FarCloudMarchRangeLocal;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x26C")]
		internal static readonly int _FarCloudCenter;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x270")]
		internal static readonly int _FarCloudCenterLocal;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x274")]
		internal static readonly int _FarCloudLastCenter;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x278")]
		internal static readonly int _FarCloudSize;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x27C")]
		internal static readonly int _PanoramicMarchStepNum;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x280")]
		internal static readonly int _PanoramicMarchStepNumEdit;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x284")]
		internal static readonly int _OctahedronBorderPadding;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x288")]
		internal static readonly int _OctahedronHeightScale;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x28C")]
		internal static readonly int _OctahedronUVRescale;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x290")]
		internal static readonly int _OctahedronUVInvRescale;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x294")]
		internal static readonly int _SemicircularZScale;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x298")]
		internal static readonly int _SemicircularForward;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x29C")]
		internal static readonly int _SemicircularRight;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2A0")]
		internal static readonly int _SemicircularUp;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2A4")]
		internal static readonly int _SemicircularPrevForward;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2A8")]
		internal static readonly int _SemicircularPrevRight;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2AC")]
		internal static readonly int _SemicircularPrevUp;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2B0")]
		internal static readonly int _FarCloudReconstructCubicSample;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2B4")]
		internal static readonly int _FarCloudTAACubicSample;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2B8")]
		internal static readonly int _FarCloudMarchStepNum;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2BC")]
		internal static readonly int _FarCloudMarchStepNumEdit;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2C0")]
		internal static readonly int _FarCloudSSTAA;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2C4")]
		internal static readonly int _FarCloudHistoryColor;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2C8")]
		internal static readonly int _FarCloudHistoryDepth;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2CC")]
		internal static readonly int _FarCloudTAACurrentColor;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2D0")]
		internal static readonly int _FarCloudTAACurrentDepth;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2D4")]
		internal static readonly int _FarCloudTAAHistoryColor;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2D8")]
		internal static readonly int _FarCloudTAAHistoryDepth;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2DC")]
		internal static readonly int _FarCloudFrameCountMod8;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2E0")]
		internal static readonly int _FarCloudFrameCountMod16;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2E4")]
		internal static readonly int _FarCloudFrameCountMod32;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2E8")]
		internal static readonly int _FarCloudFrameCountMod64;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2EC")]
		internal static readonly int _FarCloudFrameCountMod128;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2F0")]
		internal static readonly int _FarCloudPixelSubOffset;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2F4")]
		internal static readonly int _FarCloudEnableEmptySkip;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2F8")]
		internal static readonly int _FarCloudEmptySkipRTScale;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2FC")]
		internal static readonly int _FarCloudEmptySkipUVScale;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x300")]
		internal static readonly int _FarCloudEmptySkipStepNum;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x304")]
		internal static readonly int _FarCloudEmptySkipSdfScale;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x308")]
		internal static readonly int _FarCloudEmptySkipRange;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x30C")]
		internal static readonly int _FarCloudEmptySkipRTSize;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x310")]
		internal static readonly int _FarCloudEmptySkipRT;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x314")]
		internal static readonly int _FarCloudEnableEmptySkipSample;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x318")]
		internal static readonly int _FarCloudReconstructComposeRatio;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x31C")]
		internal static readonly int _FarCloudSlicingUVRescale;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x320")]
		internal static readonly int _FarCloudTAABlendRatio;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x324")]
		internal static readonly int _FarCloudCurrentColor;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x328")]
		internal static readonly int _FarCloudCurrentDepth;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x32C")]
		internal static readonly int _FarCloudColor;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x330")]
		internal static readonly int _FarCloudDepth;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x334")]
		internal static readonly int _FarCloudColor2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x338")]
		internal static readonly int _FarCloudDepth2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x33C")]
		internal static readonly int _FarCloudSlicingPrevCenter;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x340")]
		internal static readonly int _FarCloudSlicingPrev2Center;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x344")]
		internal static readonly int _FarCloudReprojectLerpRatio;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x348")]
		internal static readonly int _FarCloudDeltaTimeScale;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x34C")]
		internal static readonly int _FarCloudReprojectDeltaTimeScale;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x350")]
		internal static readonly int _FarCloudReprojectDeltaTimeScale2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x354")]
		internal static readonly int _BezierSDFTex1;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x358")]
		internal static readonly int _BezierSDFTex2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x35C")]
		internal static readonly int _FlowSpeedScale;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x360")]
		internal static readonly int _FlowSpeed;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x364")]
		internal static readonly int _FlowTimeScale;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x368")]
		internal static readonly int _FlowTime;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x36C")]
		internal static readonly int _InTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x370")]
		internal static readonly int _OutDistanceMap;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x374")]
		internal static readonly int _Offset;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x378")]
		internal static readonly int _Tileable;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x37C")]
		internal static readonly int _Beta;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x380")]
		internal static readonly int _InDistanceMap;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x384")]
		internal static readonly int _OutTexture;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x388")]
		internal static readonly int _Channel;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x38C")]
		internal static readonly int _BakeCameraPos;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x390")]
		internal static readonly int _BakeCenterPos;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x394")]
		internal static readonly int _BakeAxisX;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x398")]
		internal static readonly int _BakeAxisY;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x39C")]
		internal static readonly int _BakedCloudTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x3A0")]
		internal static readonly int _BakedLocalLightTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x3A4")]
		internal static readonly int _ReconstructComposeRatio;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x3A8")]
		internal static readonly int _ReconstructCubicSample;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x3AC")]
		internal static readonly int _ReconstructCurrentColor;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x3B0")]
		internal static readonly int _ReconstructCurrentDepth;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x3B4")]
		internal static readonly int _ReconstructHistoryColor;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x3B8")]
		internal static readonly int _ReconstructHistoryDepth;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x3BC")]
		internal static readonly int _ReconstructColor;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x3C0")]
		internal static readonly int _ReconstructDepth;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x3C4")]
		internal static readonly int _TAACubicSample;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x3C8")]
		internal static readonly int _TAACurrentColor;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x3CC")]
		internal static readonly int _TAACurrentDepth;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x3D0")]
		internal static readonly int _TAAHistoryColor;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x3D4")]
		internal static readonly int _TAAHistoryDepth;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x3D8")]
		internal static readonly int _VolumetricTAAPrevWorldSpaceCameraPos;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x3DC")]
		internal static readonly int _TAAColor;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x3E0")]
		internal static readonly int _TAADepth;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x3E4")]
		internal static readonly int _VolumetricComposeColor;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x3E8")]
		internal static readonly int _VolumetricComposeDepth;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x3EC")]
		internal static readonly int _VolumetricComposeEnabled;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x3F0")]
		internal static readonly int _VolumetricColor;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x3F4")]
		internal static readonly int _VolumetricDepth;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x3F8")]
		internal static readonly int _CloudFadeRatio;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x3FC")]
		internal static readonly int _CloudFadeSpeedPow;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x400")]
		internal static readonly int _VolumetricComposeCB;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x404")]
		internal static readonly int _VolumeMatVP;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x408")]
		internal static readonly int _VolumetricZEncodeParam;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x40C")]
		internal static readonly int _VolumetricZBufferParam;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x410")]
		internal static readonly int _WorldDepthTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x414")]
		internal static readonly int _HistoryWorldDepthTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x418")]
		internal static readonly int _FrameCountMod8;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x41C")]
		internal static readonly int _FrameCountMod16;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x420")]
		internal static readonly int _FrameCountMod32;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x424")]
		internal static readonly int _PixelSubOffset;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x428")]
		internal static readonly int _DebugPixelOffset;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x42C")]
		internal static readonly int _PixelOffsetTest;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x430")]
		internal static readonly int _DownscaleRatio;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x434")]
		internal static readonly int _DownscaleScreenParams;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x438")]
		internal static readonly int _NDCRescaleRatio;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x43C")]
		internal static readonly int _RTRes;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x440")]
		internal static readonly int _FramingRes;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x444")]
		internal static readonly int _DepthFadeDistance;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x448")]
		internal static readonly int _InvDepthFadeDistance;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x44C")]
		internal static readonly int _ComposeDepthFadeOffset;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x450")]
		internal static readonly int _ComposeDepthFadeDistance;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x454")]
		internal static readonly int _InvComposeDepthFadeDistance;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x458")]
		internal static readonly int _TAABlendRatio;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x45C")]
		internal static readonly int _TAAInvalidDepthBlendRatio;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x460")]
		internal static readonly int _CubicCatmullRom;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x464")]
		internal static readonly int _CubicZeroTangentCardinal;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x468")]
		internal static readonly int _CubicBSpline;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x46C")]
		internal static readonly int _CubicMitchellNetravali;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x470")]
		internal static readonly int _NoiseUVSpeedA;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x474")]
		internal static readonly int _NoiseUVPhaseA;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x478")]
		internal static readonly int _NoiseUVSpeedB;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x47C")]
		internal static readonly int _NoiseUVPhaseB;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x480")]
		internal static readonly int _DistortionRange;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x484")]
		internal static readonly int _OutDensityTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x488")]
		internal static readonly int _InSceneShadowTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x48C")]
		internal static readonly int _OutSceneShadowTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x490")]
		internal static readonly int _InSdfTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x494")]
		internal static readonly int _OutAdvancedTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x498")]
		internal static readonly int _OutSHTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x49C")]
		internal static readonly int _LocalLightNum;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x4A0")]
		internal static readonly int _LocalLightList;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x4A4")]
		internal static readonly int _ModifierNum;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x4A8")]
		internal static readonly int _ModifierList;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x4AC")]
		internal static readonly int _SHSampleNum;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x4B0")]
		internal static readonly int _SHSampleBuffer;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x4B4")]
		internal static readonly int _BezierSdfRange;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x4B8")]
		internal static readonly int _MaxSpeed;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x4BC")]
		internal static readonly int _InvMaxSpeed;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x4C0")]
		internal static readonly int _NumBezierPoints;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x4C4")]
		internal static readonly int _BezierPoints;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x4C8")]
		internal static readonly int _OutBezierSDFTex1;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x4CC")]
		internal static readonly int _OutBezierSDFTex2;
	}
}
