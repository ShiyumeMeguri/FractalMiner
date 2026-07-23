using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public static class VolumetricShaderIDs // TypeDefIndex: 38765
	{
		// Fields
		internal static readonly int _InvPartialVPMatrix; // 0x00
		internal static readonly int _MainTex; // 0x04
		internal static readonly int _Cull; // 0x08
		internal static readonly int _ZTest; // 0x0C
		internal static readonly int _GlobalScale; // 0x10
		internal static readonly int _InvGlobalScale; // 0x14
		internal static readonly int _InvResolution; // 0x18
		internal static readonly int _SdfStepScale; // 0x1C
		internal static readonly int _SdfOffset; // 0x20
		internal static readonly int _SdfChannel; // 0x24
		internal static readonly int _SdfFlipZY; // 0x28
		internal static readonly int _LocalRayOrigin; // 0x2C
		internal static readonly int _BoxWorldToLocal; // 0x30
		internal static readonly int _BoxLocalToWorld; // 0x34
		internal static readonly int _BoxCenter; // 0x38
		internal static readonly int _VoxelSize; // 0x3C
		internal static readonly int _InvScale; // 0x40
		internal static readonly int _SdfDensityRange; // 0x44
		internal static readonly int _Cubic; // 0x48
		internal static readonly int _ShapeTex; // 0x4C
		internal static readonly int _ShapeOffset; // 0x50
		internal static readonly int _ShapeTiling; // 0x54
		internal static readonly int _ShapePow; // 0x58
		internal static readonly int _ShapeStrength; // 0x5C
		internal static readonly int _NoiseTex; // 0x60
		internal static readonly int _NoiseTiling; // 0x64
		internal static readonly int _NoiseMipFalloff; // 0x68
		internal static readonly int _NoiseMipFalloffRemap; // 0x6C
		internal static readonly int _NoiseMipFalloff2; // 0x70
		internal static readonly int _NoiseMipFalloffRemap2; // 0x74
		internal static readonly int _NoiseType; // 0x78
		internal static readonly int _NoisePow; // 0x7C
		internal static readonly int _NoiseStrength; // 0x80
		internal static readonly int _DensityLerpDistance; // 0x84
		internal static readonly int _DensityLerpDistanceRemap; // 0x88
		internal static readonly int _DensityPow; // 0x8C
		internal static readonly int _DensityPowNear; // 0x90
		internal static readonly int _Extinction; // 0x94
		internal static readonly int _ExtinctionNear; // 0x98
		internal static readonly int _Albedo; // 0x9C
		internal static readonly int _AOFalloffRange; // 0xA0
		internal static readonly int _MarchRange; // 0xA4
		internal static readonly int _MarchRangeLocal; // 0xA8
		internal static readonly int _MarchStepNum; // 0xAC
		internal static readonly int _InvMarchStepNum; // 0xB0
		internal static readonly int _MarchStepNumEdit; // 0xB4
		internal static readonly int _PreviewMarchStepNum; // 0xB8
		internal static readonly int _BlueNoiseTex; // 0xBC
		internal static readonly int _StepNoiseScale; // 0xC0
		internal static readonly int _StepNoiseScaleRemap; // 0xC4
		internal static readonly int _DynamicStepRange; // 0xC8
		internal static readonly int _DynamicStepScale; // 0xCC
		internal static readonly int _ShadowDistance; // 0xD0
		internal static readonly int _ShadowStepNum; // 0xD4
		internal static readonly int _ShadowIntensity; // 0xD8
		internal static readonly int _ShadowNearScale; // 0xDC
		internal static readonly int _ShadowLerpDistance; // 0xE0
		internal static readonly int _ShadowLerpDistanceRemap; // 0xE4
		internal static readonly int _SceneShadowOpticalDepthScale; // 0xE8
		internal static readonly int _UseSunDirection; // 0xEC
		internal static readonly int _YawOffset; // 0xF0
		internal static readonly int _PitchOffset; // 0xF4
		internal static readonly int _MainLightDirection; // 0xF8
		internal static readonly int _MainLighting; // 0xFC
		internal static readonly int _MainLightColor; // 0x100
		internal static readonly int _MainLightIntensity; // 0x104
		internal static readonly int _SkyLighting; // 0x108
		internal static readonly int _SkyLightColor; // 0x10C
		internal static readonly int _SkyLightIntensity; // 0x110
		internal static readonly int _PhaseG; // 0x114
		internal static readonly int _PhaseG2; // 0x118
		internal static readonly int _PhaseK; // 0x11C
		internal static readonly int _PhaseK2; // 0x120
		internal static readonly int _PhaseBlend; // 0x124
		internal static readonly int _MSTex; // 0x128
		internal static readonly int _MsOctaveCount; // 0x12C
		internal static readonly int _MsScatteringFactor; // 0x130
		internal static readonly int _MsExtinctionFactor; // 0x134
		internal static readonly int _MsPhaseFactor; // 0x138
		internal static readonly int _MsFalloffRange; // 0x13C
		internal static readonly int _MsFalloffRangeRemap; // 0x140
		internal static readonly int _MsFade; // 0x144
		internal static readonly int _OpticalDepthScale; // 0x148
		internal static readonly int _InvOpticalDepthScale; // 0x14C
		internal static readonly int _MsEncodeParams; // 0x150
		internal static readonly int _GodRayStepNum; // 0x154
		internal static readonly int _InvGodRayStepNum; // 0x158
		internal static readonly int _GodRayStepNumEdit; // 0x15C
		internal static readonly int _GodRayPreviewStepNum; // 0x160
		internal static readonly int _GodRayDensityBias; // 0x164
		internal static readonly int _GodRayPow; // 0x168
		internal static readonly int _GodRayIntensity; // 0x16C
		internal static readonly int _GodRayDepthSmooth; // 0x170
		internal static readonly int _InvGodRayDepthSmooth; // 0x174
		internal static readonly int _GodRayBlurCount; // 0x178
		internal static readonly int _GodRayBlurWidth; // 0x17C
		internal static readonly int _GodrayCubic; // 0x180
		internal static readonly int _FogBaseHeight; // 0x184
		internal static readonly int _FogHeightFalloff; // 0x188
		internal static readonly int _FogColor; // 0x18C
		internal static readonly int _EmissiveLighting1; // 0x190
		internal static readonly int _EmissiveColor1; // 0x194
		internal static readonly int _EmissiveIntensity1; // 0x198
		internal static readonly int _EmissiveFalloff1; // 0x19C
		internal static readonly int _EmissiveLighting2; // 0x1A0
		internal static readonly int _EmissiveColor2; // 0x1A4
		internal static readonly int _EmissiveIntensity2; // 0x1A8
		internal static readonly int _EmissiveFalloff2; // 0x1AC
		internal static readonly int _DensityRemap; // 0x1B0
		internal static readonly int _DensityRemapOpt1; // 0x1B4
		internal static readonly int _DensityRemapOpt2; // 0x1B8
		internal static readonly int _BaseColorScale; // 0x1BC
		internal static readonly int _ColorNoiseTex; // 0x1C0
		internal static readonly int _NoiseColor; // 0x1C4
		internal static readonly int _ColorNoiseSpeed; // 0x1C8
		internal static readonly int _ColorNoiseTiling; // 0x1CC
		internal static readonly int _ColorNoisePow; // 0x1D0
		internal static readonly int _BackgroundCloud; // 0x1D4
		internal static readonly int _BackgroundCloudSize; // 0x1D8
		internal static readonly int _HeightOffset; // 0x1DC
		internal static readonly int _StartDistance; // 0x1E0
		internal static readonly int _HeightRange; // 0x1E4
		internal static readonly int _HeightRangeRemap; // 0x1E8
		internal static readonly int _EmptySkipRTScale; // 0x1EC
		internal static readonly int _EmptySkipUVScale; // 0x1F0
		internal static readonly int _MainCameraPos; // 0x1F4
		internal static readonly int _MainCameraPosLocal; // 0x1F8
		internal static readonly int _MainCameraFovTan; // 0x1FC
		internal static readonly int _EmptySkipRTSize; // 0x200
		internal static readonly int _EmptySkipRT; // 0x204
		internal static readonly int _EmptySkipRange; // 0x208
		internal static readonly int _EnableEmptySkipSample; // 0x20C
		internal static readonly int _EmptySkipStepNum; // 0x210
		internal static readonly int _EmptySkipSdfScale; // 0x214
		internal static readonly int _DensityTex; // 0x218
		internal static readonly int _AdvancedTex; // 0x21C
		internal static readonly int _SHTex; // 0x220
		internal static readonly int _WindSpeed; // 0x224
		internal static readonly int _WindSpeed2; // 0x228
		internal static readonly int _WindSpeed3; // 0x22C
		internal static readonly int _WindPhase; // 0x230
		internal static readonly int _WindPhase2; // 0x234
		internal static readonly int _WindPhase3; // 0x238
		internal static readonly int _WindOffset; // 0x23C
		internal static readonly int _WindOffset2; // 0x240
		internal static readonly int _WindOffset3; // 0x244
		internal static readonly int _WindLerpDistance; // 0x248
		internal static readonly int _WindFieldNum; // 0x24C
		internal static readonly int _WindFieldDataCB; // 0x250
		internal static readonly int _WindFieldTex; // 0x254
		internal static readonly int _WindOffsetScale; // 0x258
		internal static readonly int _InvWindOffsetScale; // 0x25C
		internal static readonly int _PanoramicUpdateDistance; // 0x260
		internal static readonly int _FarCubic; // 0x264
		internal static readonly int _FarCloudMarchRangeLocal; // 0x268
		internal static readonly int _FarCloudCenter; // 0x26C
		internal static readonly int _FarCloudCenterLocal; // 0x270
		internal static readonly int _FarCloudLastCenter; // 0x274
		internal static readonly int _FarCloudSize; // 0x278
		internal static readonly int _PanoramicMarchStepNum; // 0x27C
		internal static readonly int _PanoramicMarchStepNumEdit; // 0x280
		internal static readonly int _OctahedronBorderPadding; // 0x284
		internal static readonly int _OctahedronHeightScale; // 0x288
		internal static readonly int _OctahedronUVRescale; // 0x28C
		internal static readonly int _OctahedronUVInvRescale; // 0x290
		internal static readonly int _SemicircularZScale; // 0x294
		internal static readonly int _SemicircularForward; // 0x298
		internal static readonly int _SemicircularRight; // 0x29C
		internal static readonly int _SemicircularUp; // 0x2A0
		internal static readonly int _SemicircularPrevForward; // 0x2A4
		internal static readonly int _SemicircularPrevRight; // 0x2A8
		internal static readonly int _SemicircularPrevUp; // 0x2AC
		internal static readonly int _FarCloudReconstructCubicSample; // 0x2B0
		internal static readonly int _FarCloudTAACubicSample; // 0x2B4
		internal static readonly int _FarCloudMarchStepNum; // 0x2B8
		internal static readonly int _FarCloudMarchStepNumEdit; // 0x2BC
		internal static readonly int _FarCloudSSTAA; // 0x2C0
		internal static readonly int _FarCloudHistoryColor; // 0x2C4
		internal static readonly int _FarCloudHistoryDepth; // 0x2C8
		internal static readonly int _FarCloudTAACurrentColor; // 0x2CC
		internal static readonly int _FarCloudTAACurrentDepth; // 0x2D0
		internal static readonly int _FarCloudTAAHistoryColor; // 0x2D4
		internal static readonly int _FarCloudTAAHistoryDepth; // 0x2D8
		internal static readonly int _FarCloudFrameCountMod8; // 0x2DC
		internal static readonly int _FarCloudFrameCountMod16; // 0x2E0
		internal static readonly int _FarCloudFrameCountMod32; // 0x2E4
		internal static readonly int _FarCloudFrameCountMod64; // 0x2E8
		internal static readonly int _FarCloudFrameCountMod128; // 0x2EC
		internal static readonly int _FarCloudPixelSubOffset; // 0x2F0
		internal static readonly int _FarCloudEnableEmptySkip; // 0x2F4
		internal static readonly int _FarCloudEmptySkipRTScale; // 0x2F8
		internal static readonly int _FarCloudEmptySkipUVScale; // 0x2FC
		internal static readonly int _FarCloudEmptySkipStepNum; // 0x300
		internal static readonly int _FarCloudEmptySkipSdfScale; // 0x304
		internal static readonly int _FarCloudEmptySkipRange; // 0x308
		internal static readonly int _FarCloudEmptySkipRTSize; // 0x30C
		internal static readonly int _FarCloudEmptySkipRT; // 0x310
		internal static readonly int _FarCloudEnableEmptySkipSample; // 0x314
		internal static readonly int _FarCloudReconstructComposeRatio; // 0x318
		internal static readonly int _FarCloudSlicingUVRescale; // 0x31C
		internal static readonly int _FarCloudTAABlendRatio; // 0x320
		internal static readonly int _FarCloudCurrentColor; // 0x324
		internal static readonly int _FarCloudCurrentDepth; // 0x328
		internal static readonly int _FarCloudColor; // 0x32C
		internal static readonly int _FarCloudDepth; // 0x330
		internal static readonly int _FarCloudColor2; // 0x334
		internal static readonly int _FarCloudDepth2; // 0x338
		internal static readonly int _FarCloudSlicingPrevCenter; // 0x33C
		internal static readonly int _FarCloudSlicingPrev2Center; // 0x340
		internal static readonly int _FarCloudReprojectLerpRatio; // 0x344
		internal static readonly int _FarCloudDeltaTimeScale; // 0x348
		internal static readonly int _FarCloudReprojectDeltaTimeScale; // 0x34C
		internal static readonly int _FarCloudReprojectDeltaTimeScale2; // 0x350
		internal static readonly int _BezierSDFTex1; // 0x354
		internal static readonly int _BezierSDFTex2; // 0x358
		internal static readonly int _FlowSpeedScale; // 0x35C
		internal static readonly int _FlowSpeed; // 0x360
		internal static readonly int _FlowTimeScale; // 0x364
		internal static readonly int _FlowTime; // 0x368
		internal static readonly int _InTexture; // 0x36C
		internal static readonly int _OutDistanceMap; // 0x370
		internal static readonly int _Offset; // 0x374
		internal static readonly int _Tileable; // 0x378
		internal static readonly int _Beta; // 0x37C
		internal static readonly int _InDistanceMap; // 0x380
		internal static readonly int _OutTexture; // 0x384
		internal static readonly int _Channel; // 0x388
		internal static readonly int _BakeCameraPos; // 0x38C
		internal static readonly int _BakeCenterPos; // 0x390
		internal static readonly int _BakeAxisX; // 0x394
		internal static readonly int _BakeAxisY; // 0x398
		internal static readonly int _BakedCloudTex; // 0x39C
		internal static readonly int _BakedLocalLightTex; // 0x3A0
		internal static readonly int _ReconstructComposeRatio; // 0x3A4
		internal static readonly int _ReconstructCubicSample; // 0x3A8
		internal static readonly int _ReconstructCurrentColor; // 0x3AC
		internal static readonly int _ReconstructCurrentDepth; // 0x3B0
		internal static readonly int _ReconstructHistoryColor; // 0x3B4
		internal static readonly int _ReconstructHistoryDepth; // 0x3B8
		internal static readonly int _ReconstructColor; // 0x3BC
		internal static readonly int _ReconstructDepth; // 0x3C0
		internal static readonly int _TAACubicSample; // 0x3C4
		internal static readonly int _TAACurrentColor; // 0x3C8
		internal static readonly int _TAACurrentDepth; // 0x3CC
		internal static readonly int _TAAHistoryColor; // 0x3D0
		internal static readonly int _TAAHistoryDepth; // 0x3D4
		internal static readonly int _VolumetricTAAPrevWorldSpaceCameraPos; // 0x3D8
		internal static readonly int _VolumetricTAAPrevWorldSpaceCameraForward; // 0x3DC
		internal static readonly int _TAAColor; // 0x3E0
		internal static readonly int _TAADepth; // 0x3E4
		internal static readonly int _VolumetricComposeColor; // 0x3E8
		internal static readonly int _VolumetricComposeDepth; // 0x3EC
		internal static readonly int _VolumetricComposeEnabled; // 0x3F0
		internal static readonly int _VolumetricColor; // 0x3F4
		internal static readonly int _VolumetricDepth; // 0x3F8
		internal static readonly int _CloudFadeRatio; // 0x3FC
		internal static readonly int _CloudFadeSpeedPow; // 0x400
		internal static readonly int _VolumetricComposeCB; // 0x404
		internal static readonly int _VolumeMatVP; // 0x408
		internal static readonly int _VolumetricZEncodeParam; // 0x40C
		internal static readonly int _VolumetricZBufferParam; // 0x410
		internal static readonly int _WorldDepthTex; // 0x414
		internal static readonly int _HistoryWorldDepthTex; // 0x418
		internal static readonly int _FrameCountMod8; // 0x41C
		internal static readonly int _FrameCountMod16; // 0x420
		internal static readonly int _FrameCountMod32; // 0x424
		internal static readonly int _PixelSubOffset; // 0x428
		internal static readonly int _DebugPixelOffset; // 0x42C
		internal static readonly int _PixelOffsetTest; // 0x430
		internal static readonly int _DownscaleRatio; // 0x434
		internal static readonly int _DownscaleScreenParams; // 0x438
		internal static readonly int _NDCRescaleRatio; // 0x43C
		internal static readonly int _RTRes; // 0x440
		internal static readonly int _FramingRes; // 0x444
		internal static readonly int _DepthFadeDistance; // 0x448
		internal static readonly int _InvDepthFadeDistance; // 0x44C
		internal static readonly int _ComposeDepthFadeOffset; // 0x450
		internal static readonly int _ComposeDepthFadeDistance; // 0x454
		internal static readonly int _InvComposeDepthFadeDistance; // 0x458
		internal static readonly int _ComposeOverride; // 0x45C
		internal static readonly int _TAABlendRatio; // 0x460
		internal static readonly int _TAAInvalidDepthBlendRatio; // 0x464
		internal static readonly int _CubicCatmullRom; // 0x468
		internal static readonly int _CubicZeroTangentCardinal; // 0x46C
		internal static readonly int _CubicBSpline; // 0x470
		internal static readonly int _CubicMitchellNetravali; // 0x474
		internal static readonly int _NoiseUVSpeedA; // 0x478
		internal static readonly int _NoiseUVPhaseA; // 0x47C
		internal static readonly int _NoiseUVSpeedB; // 0x480
		internal static readonly int _NoiseUVPhaseB; // 0x484
		internal static readonly int _DistortionRange; // 0x488
		internal static readonly int _OutDensityTex; // 0x48C
		internal static readonly int _InSceneShadowTex; // 0x490
		internal static readonly int _OutSceneShadowTex; // 0x494
		internal static readonly int _InSdfTex; // 0x498
		internal static readonly int _OutAdvancedTex; // 0x49C
		internal static readonly int _OutSHTex; // 0x4A0
		internal static readonly int _LocalLightNum; // 0x4A4
		internal static readonly int _LocalLightList; // 0x4A8
		internal static readonly int _ModifierNum; // 0x4AC
		internal static readonly int _ModifierList; // 0x4B0
		internal static readonly int _SHSampleNum; // 0x4B4
		internal static readonly int _SHSampleBuffer; // 0x4B8
		internal static readonly int _BezierSdfRange; // 0x4BC
		internal static readonly int _MaxSpeed; // 0x4C0
		internal static readonly int _InvMaxSpeed; // 0x4C4
		internal static readonly int _NumBezierPoints; // 0x4C8
		internal static readonly int _BezierPoints; // 0x4CC
		internal static readonly int _OutBezierSDFTex1; // 0x4D0
		internal static readonly int _OutBezierSDFTex2; // 0x4D4
	
		// Constructors
		static VolumetricShaderIDs() {} // 0x0000000184467D10-0x000000018446A5F0
		// VolumetricShaderIDs()
		void HG::Rendering::Runtime::VolumetricShaderIDs::cctor(MethodInfo *method)
		{
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_InvPartialVPMatrix = UnityEngine::Shader::PropertyToID(
		                                                                                                (String *)"_InvPartialVPMatrix",
		                                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_MainTex = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_MainTex",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_Cull = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_Cull",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_ZTest = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_ZTest",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_GlobalScale = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_GlobalScale",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_InvGlobalScale = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_InvGlobalScale",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_InvResolution = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_InvResolution",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_SdfStepScale = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_SdfStepScale",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_SdfOffset = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_SdfOffset",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_SdfChannel = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_SdfChannel",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_SdfFlipZY = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_SdfFlipZY",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_LocalRayOrigin = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_LocalRayOrigin",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_BoxWorldToLocal = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_BoxWorldToLocal",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_BoxLocalToWorld = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_BoxLocalToWorld",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_BoxCenter = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_BoxCenter",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_VoxelSize = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_VoxelSize",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_InvScale = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_InvScale",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_SdfDensityRange = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_SdfDensityRange",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_Cubic = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_CUBIC",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_ShapeTex = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_ShapeTex",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_ShapeOffset = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_ShapeOffset",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_ShapeTiling = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_ShapeTiling",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_ShapePow = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_ShapePow",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_ShapeStrength = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_ShapeStrength",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_NoiseTex = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_NoiseTex",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_NoiseTiling = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_NoiseTiling",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_NoiseMipFalloff = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_NoiseMipFalloff",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_NoiseMipFalloffRemap = UnityEngine::Shader::PropertyToID(
		                                                                                                  (String *)"_NoiseMipFalloffRemap",
		                                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_NoiseMipFalloff2 = UnityEngine::Shader::PropertyToID(
		                                                                                              (String *)"_NoiseMipFalloff2",
		                                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_NoiseMipFalloffRemap2 = UnityEngine::Shader::PropertyToID(
		                                                                                                   (String *)"_NoiseMipFalloffRemap2",
		                                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_NoiseType = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_NoiseType",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_NoisePow = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_NoisePow",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_NoiseStrength = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_NoiseStrength",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_DensityLerpDistance = UnityEngine::Shader::PropertyToID(
		                                                                                                 (String *)"_DensityLerpDistance",
		                                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_DensityLerpDistanceRemap = UnityEngine::Shader::PropertyToID((String *)"_DensityLerpDistanceRemap", 0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_DensityPow = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_DensityPow",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_DensityPowNear = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_DensityPowNear",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_Extinction = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_Extinction",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_ExtinctionNear = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_ExtinctionNear",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_Albedo = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_Albedo",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_AOFalloffRange = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_AOFalloffRange",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_MarchRange = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_MarchRange",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_MarchRangeLocal = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_MarchRangeLocal",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_MarchStepNum = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_MarchStepNum",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_InvMarchStepNum = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_InvMarchStepNum",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_MarchStepNumEdit = UnityEngine::Shader::PropertyToID(
		                                                                                              (String *)"_MarchStepNumEdit",
		                                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_PreviewMarchStepNum = UnityEngine::Shader::PropertyToID(
		                                                                                                 (String *)"_PreviewMarchStepNum",
		                                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_BlueNoiseTex = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_BlueNoiseTex",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_StepNoiseScale = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_StepNoiseScale",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_StepNoiseScaleRemap = UnityEngine::Shader::PropertyToID(
		                                                                                                 (String *)"_StepNoiseScaleRemap",
		                                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_DynamicStepRange = UnityEngine::Shader::PropertyToID(
		                                                                                              (String *)"_DynamicStepRange",
		                                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_DynamicStepScale = UnityEngine::Shader::PropertyToID(
		                                                                                              (String *)"_DynamicStepScale",
		                                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_ShadowDistance = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_ShadowDistance",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_ShadowStepNum = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_ShadowStepNum",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_ShadowIntensity = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_ShadowIntensity",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_ShadowNearScale = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_ShadowNearScale",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_ShadowLerpDistance = UnityEngine::Shader::PropertyToID(
		                                                                                                (String *)"_ShadowLerpDistance",
		                                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_ShadowLerpDistanceRemap = UnityEngine::Shader::PropertyToID(
		                                                                                                     (String *)"_ShadowLerpDistanceRemap",
		                                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_SceneShadowOpticalDepthScale = UnityEngine::Shader::PropertyToID((String *)"_SceneShadowOpticalDepthScale", 0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_UseSunDirection = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_UseSunDirection",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_YawOffset = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_YawOffset",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_PitchOffset = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_PitchOffset",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_MainLightDirection = UnityEngine::Shader::PropertyToID(
		                                                                                                (String *)"_MainLightDirection",
		                                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_MainLighting = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_MainLighting",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_MainLightColor = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_MainLightColor",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_MainLightIntensity = UnityEngine::Shader::PropertyToID(
		                                                                                                (String *)"_MainLightIntensity",
		                                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_SkyLighting = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_SkyLighting",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_SkyLightColor = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_SkyLightColor",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_SkyLightIntensity = UnityEngine::Shader::PropertyToID(
		                                                                                               (String *)"_SkyLightIntensity",
		                                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_PhaseG = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_PhaseG",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_PhaseG2 = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_PhaseG2",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_PhaseK = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_PhaseK",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_PhaseK2 = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_PhaseK2",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_PhaseBlend = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_PhaseBlend",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_MSTex = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_MSTex",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_MsOctaveCount = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_MsOctaveCount",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_MsScatteringFactor = UnityEngine::Shader::PropertyToID(
		                                                                                                (String *)"_MsScatteringFactor",
		                                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_MsExtinctionFactor = UnityEngine::Shader::PropertyToID(
		                                                                                                (String *)"_MsExtinctionFactor",
		                                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_MsPhaseFactor = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_MsPhaseFactor",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_MsFalloffRange = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_MsFalloffRange",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_MsFalloffRangeRemap = UnityEngine::Shader::PropertyToID(
		                                                                                                 (String *)"_MsFalloffRangeRemap",
		                                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_MsFade = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_MsFade",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_OpticalDepthScale = UnityEngine::Shader::PropertyToID(
		                                                                                               (String *)"_OpticalDepthScale",
		                                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_InvOpticalDepthScale = UnityEngine::Shader::PropertyToID(
		                                                                                                  (String *)"_InvOpticalDepthScale",
		                                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_MsEncodeParams = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_MsEncodeParams",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_GodRayStepNum = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_GodRayStepNum",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_InvGodRayStepNum = UnityEngine::Shader::PropertyToID(
		                                                                                              (String *)"_InvGodRayStepNum",
		                                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_GodRayStepNumEdit = UnityEngine::Shader::PropertyToID(
		                                                                                               (String *)"_GodRayStepNumEdit",
		                                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_GodRayPreviewStepNum = UnityEngine::Shader::PropertyToID(
		                                                                                                  (String *)"_GodRayPreviewStepNum",
		                                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_GodRayDensityBias = UnityEngine::Shader::PropertyToID(
		                                                                                               (String *)"_GodRayDensityBias",
		                                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_GodRayPow = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_GodRayPow",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_GodRayIntensity = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_GodRayIntensity",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_GodRayDepthSmooth = UnityEngine::Shader::PropertyToID(
		                                                                                               (String *)"_GodRayDepthSmooth",
		                                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_InvGodRayDepthSmooth = UnityEngine::Shader::PropertyToID(
		                                                                                                  (String *)"_InvGodRayDepthSmooth",
		                                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_GodRayBlurCount = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_GodRayBlurCount",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_GodRayBlurWidth = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_GodRayBlurWidth",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_GodrayCubic = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_GODRAY_CUBIC",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FogBaseHeight = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_FogBaseHeight",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FogHeightFalloff = UnityEngine::Shader::PropertyToID(
		                                                                                              (String *)"_FogHeightFalloff",
		                                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FogColor = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_FogColor",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_EmissiveLighting1 = UnityEngine::Shader::PropertyToID(
		                                                                                               (String *)"_EmissiveLighting1",
		                                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_EmissiveColor1 = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_EmissiveColor1",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_EmissiveIntensity1 = UnityEngine::Shader::PropertyToID(
		                                                                                                (String *)"_EmissiveIntensity1",
		                                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_EmissiveFalloff1 = UnityEngine::Shader::PropertyToID(
		                                                                                              (String *)"_EmissiveFalloff1",
		                                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_EmissiveLighting2 = UnityEngine::Shader::PropertyToID(
		                                                                                               (String *)"_EmissiveLighting2",
		                                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_EmissiveColor2 = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_EmissiveColor2",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_EmissiveIntensity2 = UnityEngine::Shader::PropertyToID(
		                                                                                                (String *)"_EmissiveIntensity2",
		                                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_EmissiveFalloff2 = UnityEngine::Shader::PropertyToID(
		                                                                                              (String *)"_EmissiveFalloff2",
		                                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_DensityRemap = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_DensityRemap",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_DensityRemapOpt1 = UnityEngine::Shader::PropertyToID(
		                                                                                              (String *)"_DensityRemapOpt1",
		                                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_DensityRemapOpt2 = UnityEngine::Shader::PropertyToID(
		                                                                                              (String *)"_DensityRemapOpt2",
		                                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_BaseColorScale = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_BaseColorScale",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_ColorNoiseTex = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_ColorNoiseTex",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_NoiseColor = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_NoiseColor",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_ColorNoiseSpeed = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_ColorNoiseSpeed",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_ColorNoiseTiling = UnityEngine::Shader::PropertyToID(
		                                                                                              (String *)"_ColorNoiseTiling",
		                                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_ColorNoisePow = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_ColorNoisePow",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_BackgroundCloud = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_BackgroundCloud",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_BackgroundCloudSize = UnityEngine::Shader::PropertyToID(
		                                                                                                 (String *)"_BackgroundCloudSize",
		                                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_HeightOffset = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_HeightOffset",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_StartDistance = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_StartDistance",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_HeightRange = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_HeightRange",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_HeightRangeRemap = UnityEngine::Shader::PropertyToID(
		                                                                                              (String *)"_HeightRangeRemap",
		                                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_EmptySkipRTScale = UnityEngine::Shader::PropertyToID(
		                                                                                              (String *)"_EmptySkipRTScale",
		                                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_EmptySkipUVScale = UnityEngine::Shader::PropertyToID(
		                                                                                              (String *)"_EmptySkipUVScale",
		                                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_MainCameraPos = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_MainCameraPos",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_MainCameraPosLocal = UnityEngine::Shader::PropertyToID(
		                                                                                                (String *)"_MainCameraPosLocal",
		                                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_MainCameraFovTan = UnityEngine::Shader::PropertyToID(
		                                                                                              (String *)"_MainCameraFovTan",
		                                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_EmptySkipRTSize = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_EmptySkipRTSize",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_EmptySkipRT = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_EmptySkipRT",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_EmptySkipRange = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_EmptySkipRange",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_EnableEmptySkipSample = UnityEngine::Shader::PropertyToID(
		                                                                                                   (String *)"_EnableEmptySkipSample",
		                                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_EmptySkipStepNum = UnityEngine::Shader::PropertyToID(
		                                                                                              (String *)"_EmptySkipStepNum",
		                                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_EmptySkipSdfScale = UnityEngine::Shader::PropertyToID(
		                                                                                               (String *)"_EmptySkipSdfScale",
		                                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_DensityTex = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_DensityTex",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_AdvancedTex = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_AdvancedTex",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_SHTex = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_SHTex",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_WindSpeed = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_WindSpeed",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_WindSpeed2 = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_WindSpeed2",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_WindSpeed3 = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_WindSpeed3",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_WindPhase = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_WindPhase",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_WindPhase2 = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_WindPhase2",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_WindPhase3 = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_WindPhase3",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_WindOffset = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_WindOffset",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_WindOffset2 = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_WindOffset2",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_WindOffset3 = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_WindOffset3",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_WindLerpDistance = UnityEngine::Shader::PropertyToID(
		                                                                                              (String *)"_WindLerpDistance",
		                                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_WindFieldNum = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_WindFieldNum",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_WindFieldDataCB = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_WindFieldDataCB",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_WindFieldTex = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_WindFieldTex",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_WindOffsetScale = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_WindOffsetScale",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_InvWindOffsetScale = UnityEngine::Shader::PropertyToID(
		                                                                                                (String *)"_InvWindOffsetScale",
		                                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_PanoramicUpdateDistance = UnityEngine::Shader::PropertyToID(
		                                                                                                     (String *)"_PanoramicUpdateDistance",
		                                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCubic = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_FAR_CUBIC",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudMarchRangeLocal = UnityEngine::Shader::PropertyToID(
		                                                                                                     (String *)"_FarCloudMarchRangeLocal",
		                                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudCenter = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_FarCloudCenter",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudCenterLocal = UnityEngine::Shader::PropertyToID(
		                                                                                                 (String *)"_FarCloudCenterLocal",
		                                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudLastCenter = UnityEngine::Shader::PropertyToID(
		                                                                                                (String *)"_FarCloudLastCenter",
		                                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudSize = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_FarCloudSize",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_PanoramicMarchStepNum = UnityEngine::Shader::PropertyToID(
		                                                                                                   (String *)"_PanoramicMarchStepNum",
		                                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_PanoramicMarchStepNumEdit = UnityEngine::Shader::PropertyToID((String *)"_PanoramicMarchStepNumEdit", 0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_OctahedronBorderPadding = UnityEngine::Shader::PropertyToID(
		                                                                                                     (String *)"_OctahedronBorderPadding",
		                                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_OctahedronHeightScale = UnityEngine::Shader::PropertyToID(
		                                                                                                   (String *)"_OctahedronHeightScale",
		                                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_OctahedronUVRescale = UnityEngine::Shader::PropertyToID(
		                                                                                                 (String *)"_OctahedronUVRescale",
		                                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_OctahedronUVInvRescale = UnityEngine::Shader::PropertyToID(
		                                                                                                    (String *)"_OctahedronUVInvRescale",
		                                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_SemicircularZScale = UnityEngine::Shader::PropertyToID(
		                                                                                                (String *)"_SemicircularZScale",
		                                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_SemicircularForward = UnityEngine::Shader::PropertyToID(
		                                                                                                 (String *)"_SemicircularForward",
		                                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_SemicircularRight = UnityEngine::Shader::PropertyToID(
		                                                                                               (String *)"_SemicircularRight",
		                                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_SemicircularUp = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_SemicircularUp",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_SemicircularPrevForward = UnityEngine::Shader::PropertyToID(
		                                                                                                     (String *)"_SemicircularPrevForward",
		                                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_SemicircularPrevRight = UnityEngine::Shader::PropertyToID(
		                                                                                                   (String *)"_SemicircularPrevRight",
		                                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_SemicircularPrevUp = UnityEngine::Shader::PropertyToID(
		                                                                                                (String *)"_SemicircularPrevUp",
		                                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudReconstructCubicSample = UnityEngine::Shader::PropertyToID((String *)"_FarCloudReconstructCubicSample", 0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudTAACubicSample = UnityEngine::Shader::PropertyToID(
		                                                                                                    (String *)"_FarCloudTAACubicSample",
		                                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudMarchStepNum = UnityEngine::Shader::PropertyToID(
		                                                                                                  (String *)"_FarCloudMarchStepNum",
		                                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudMarchStepNumEdit = UnityEngine::Shader::PropertyToID((String *)"_FarCloudMarchStepNumEdit", 0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudSSTAA = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_FarCloudSSTAA",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudHistoryColor = UnityEngine::Shader::PropertyToID(
		                                                                                                  (String *)"_FarCloudHistoryColor",
		                                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudHistoryDepth = UnityEngine::Shader::PropertyToID(
		                                                                                                  (String *)"_FarCloudHistoryDepth",
		                                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudTAACurrentColor = UnityEngine::Shader::PropertyToID(
		                                                                                                     (String *)"_FarCloudTAACurrentColor",
		                                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudTAACurrentDepth = UnityEngine::Shader::PropertyToID(
		                                                                                                     (String *)"_FarCloudTAACurrentDepth",
		                                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudTAAHistoryColor = UnityEngine::Shader::PropertyToID(
		                                                                                                     (String *)"_FarCloudTAAHistoryColor",
		                                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudTAAHistoryDepth = UnityEngine::Shader::PropertyToID(
		                                                                                                     (String *)"_FarCloudTAAHistoryDepth",
		                                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudFrameCountMod8 = UnityEngine::Shader::PropertyToID(
		                                                                                                    (String *)"_FarCloudFrameCountMod8",
		                                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudFrameCountMod16 = UnityEngine::Shader::PropertyToID(
		                                                                                                     (String *)"_FarCloudFrameCountMod16",
		                                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudFrameCountMod32 = UnityEngine::Shader::PropertyToID(
		                                                                                                     (String *)"_FarCloudFrameCountMod32",
		                                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudFrameCountMod64 = UnityEngine::Shader::PropertyToID(
		                                                                                                     (String *)"_FarCloudFrameCountMod64",
		                                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudFrameCountMod128 = UnityEngine::Shader::PropertyToID((String *)"_FarCloudFrameCountMod128", 0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudPixelSubOffset = UnityEngine::Shader::PropertyToID(
		                                                                                                    (String *)"_FarCloudPixelSubOffset",
		                                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudEnableEmptySkip = UnityEngine::Shader::PropertyToID(
		                                                                                                     (String *)"_FarCloudEnableEmptySkip",
		                                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudEmptySkipRTScale = UnityEngine::Shader::PropertyToID((String *)"_FarCloudEmptySkipRTScale", 0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudEmptySkipUVScale = UnityEngine::Shader::PropertyToID((String *)"_FarCloudEmptySkipUVScale", 0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudEmptySkipStepNum = UnityEngine::Shader::PropertyToID((String *)"_FarCloudEmptySkipStepNum", 0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudEmptySkipSdfScale = UnityEngine::Shader::PropertyToID((String *)"_FarCloudEmptySkipSdfScale", 0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudEmptySkipRange = UnityEngine::Shader::PropertyToID(
		                                                                                                    (String *)"_FarCloudEmptySkipRange",
		                                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudEmptySkipRTSize = UnityEngine::Shader::PropertyToID(
		                                                                                                     (String *)"_FarCloudEmptySkipRTSize",
		                                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudEmptySkipRT = UnityEngine::Shader::PropertyToID(
		                                                                                                 (String *)"_FarCloudEmptySkipRT",
		                                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudEnableEmptySkipSample = UnityEngine::Shader::PropertyToID((String *)"_FarCloudEnableEmptySkipSample", 0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudReconstructComposeRatio = UnityEngine::Shader::PropertyToID((String *)"_FarCloudReconstructComposeRatio", 0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudSlicingUVRescale = UnityEngine::Shader::PropertyToID((String *)"_FarCloudSlicingUVRescale", 0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudTAABlendRatio = UnityEngine::Shader::PropertyToID(
		                                                                                                   (String *)"_FarCloudTAABlendRatio",
		                                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudCurrentColor = UnityEngine::Shader::PropertyToID(
		                                                                                                  (String *)"_FarCloudCurrentColor",
		                                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudCurrentDepth = UnityEngine::Shader::PropertyToID(
		                                                                                                  (String *)"_FarCloudCurrentDepth",
		                                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudColor = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_FarCloudColor",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudDepth = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_FarCloudDepth",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudColor2 = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_FarCloudColor2",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudDepth2 = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_FarCloudDepth2",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudSlicingPrevCenter = UnityEngine::Shader::PropertyToID((String *)"_FarCloudSlicingPrevCenter", 0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudSlicingPrev2Center = UnityEngine::Shader::PropertyToID((String *)"_FarCloudSlicingPrev2Center", 0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudReprojectLerpRatio = UnityEngine::Shader::PropertyToID((String *)"_FarCloudReprojectLerpRatio", 0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudDeltaTimeScale = UnityEngine::Shader::PropertyToID(
		                                                                                                    (String *)"_FarCloudDeltaTimeScale",
		                                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudReprojectDeltaTimeScale = UnityEngine::Shader::PropertyToID((String *)"_FarCloudReprojectDeltaTimeScale", 0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudReprojectDeltaTimeScale2 = UnityEngine::Shader::PropertyToID((String *)"_FarCloudReprojectDeltaTimeScale2", 0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_BezierSDFTex1 = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_BezierSDFTex1",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_BezierSDFTex2 = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_BezierSDFTex2",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FlowSpeedScale = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_FlowSpeedScale",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FlowSpeed = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_FlowSpeed",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FlowTimeScale = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_FlowTimeScale",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FlowTime = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_FlowTime",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_InTexture = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_InTexture",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_OutDistanceMap = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_OutDistanceMap",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_Offset = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_Offset",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_Tileable = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_Tileable",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_Beta = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_Beta",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_InDistanceMap = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_InDistanceMap",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_OutTexture = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_OutTexture",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_Channel = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_Channel",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_BakeCameraPos = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_BakeCameraPos",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_BakeCenterPos = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_BakeCenterPos",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_BakeAxisX = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_BakeAxisX",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_BakeAxisY = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_BakeAxisY",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_BakedCloudTex = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_BakedCloudTex",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_BakedLocalLightTex = UnityEngine::Shader::PropertyToID(
		                                                                                                (String *)"_BakedLocalLightTex",
		                                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_ReconstructComposeRatio = UnityEngine::Shader::PropertyToID(
		                                                                                                     (String *)"_ReconstructComposeRatio",
		                                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_ReconstructCubicSample = UnityEngine::Shader::PropertyToID(
		                                                                                                    (String *)"_ReconstructCubicSample",
		                                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_ReconstructCurrentColor = UnityEngine::Shader::PropertyToID(
		                                                                                                     (String *)"_ReconstructCurrentColor",
		                                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_ReconstructCurrentDepth = UnityEngine::Shader::PropertyToID(
		                                                                                                     (String *)"_ReconstructCurrentDepth",
		                                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_ReconstructHistoryColor = UnityEngine::Shader::PropertyToID(
		                                                                                                     (String *)"_ReconstructHistoryColor",
		                                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_ReconstructHistoryDepth = UnityEngine::Shader::PropertyToID(
		                                                                                                     (String *)"_ReconstructHistoryDepth",
		                                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_ReconstructColor = UnityEngine::Shader::PropertyToID(
		                                                                                              (String *)"_ReconstructColor",
		                                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_ReconstructDepth = UnityEngine::Shader::PropertyToID(
		                                                                                              (String *)"_ReconstructDepth",
		                                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_TAACubicSample = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_TAACubicSample",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_TAACurrentColor = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_TAACurrentColor",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_TAACurrentDepth = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_TAACurrentDepth",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_TAAHistoryColor = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_TAAHistoryColor",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_TAAHistoryDepth = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_TAAHistoryDepth",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_VolumetricTAAPrevWorldSpaceCameraPos = UnityEngine::Shader::PropertyToID((String *)"_VolumetricTAAPrevWorldSpaceCameraPos", 0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_VolumetricTAAPrevWorldSpaceCameraForward = UnityEngine::Shader::PropertyToID((String *)"_VolumetricTAAPrevWorldSpaceCameraForward", 0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_TAAColor = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_TAAColor",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_TAADepth = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_TAADepth",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_VolumetricComposeColor = UnityEngine::Shader::PropertyToID(
		                                                                                                    (String *)"_VolumetricComposeColor",
		                                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_VolumetricComposeDepth = UnityEngine::Shader::PropertyToID(
		                                                                                                    (String *)"_VolumetricComposeDepth",
		                                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_VolumetricComposeEnabled = UnityEngine::Shader::PropertyToID((String *)"_VolumetricComposeEnabled", 0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_VolumetricColor = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_VolumetricColor",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_VolumetricDepth = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_VolumetricDepth",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_CloudFadeRatio = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_CloudFadeRatio",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_CloudFadeSpeedPow = UnityEngine::Shader::PropertyToID(
		                                                                                               (String *)"_CloudFadeSpeedPow",
		                                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_VolumetricComposeCB = UnityEngine::Shader::PropertyToID(
		                                                                                                 (String *)"_VolumetricComposeCB",
		                                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_VolumeMatVP = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_VolumeMatVP",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_VolumetricZEncodeParam = UnityEngine::Shader::PropertyToID(
		                                                                                                    (String *)"_VolumetricZEncodeParam",
		                                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_VolumetricZBufferParam = UnityEngine::Shader::PropertyToID(
		                                                                                                    (String *)"_VolumetricZBufferParam",
		                                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_WorldDepthTex = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_WorldDepthTex",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_HistoryWorldDepthTex = UnityEngine::Shader::PropertyToID(
		                                                                                                  (String *)"_HistoryWorldDepthTex",
		                                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FrameCountMod8 = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_FrameCountMod8",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FrameCountMod16 = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_FrameCountMod16",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FrameCountMod32 = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_FrameCountMod32",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_PixelSubOffset = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_PixelSubOffset",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_DebugPixelOffset = UnityEngine::Shader::PropertyToID(
		                                                                                              (String *)"_DebugPixelOffset",
		                                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_PixelOffsetTest = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_PixelOffsetTest",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_DownscaleRatio = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_DownscaleRatio",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_DownscaleScreenParams = UnityEngine::Shader::PropertyToID(
		                                                                                                   (String *)"_DownscaleScreenParams",
		                                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_NDCRescaleRatio = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_NDCRescaleRatio",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_RTRes = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_RTRes",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FramingRes = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_FramingRes",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_DepthFadeDistance = UnityEngine::Shader::PropertyToID(
		                                                                                               (String *)"_DepthFadeDistance",
		                                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_InvDepthFadeDistance = UnityEngine::Shader::PropertyToID(
		                                                                                                  (String *)"_InvDepthFadeDistance",
		                                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_ComposeDepthFadeOffset = UnityEngine::Shader::PropertyToID(
		                                                                                                    (String *)"_ComposeDepthFadeOffset",
		                                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_ComposeDepthFadeDistance = UnityEngine::Shader::PropertyToID((String *)"_ComposeDepthFadeDistance", 0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_InvComposeDepthFadeDistance = UnityEngine::Shader::PropertyToID((String *)"_InvComposeDepthFadeDistance", 0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_ComposeOverride = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_ComposeOverride",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_TAABlendRatio = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_TAABlendRatio",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_TAAInvalidDepthBlendRatio = UnityEngine::Shader::PropertyToID((String *)"_TAAInvalidDepthBlendRatio", 0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_CubicCatmullRom = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_CubicCatmullRom",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_CubicZeroTangentCardinal = UnityEngine::Shader::PropertyToID((String *)"_CubicZeroTangentCardinal", 0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_CubicBSpline = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_CubicBSpline",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_CubicMitchellNetravali = UnityEngine::Shader::PropertyToID(
		                                                                                                    (String *)"_CubicMitchellNetravali",
		                                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_NoiseUVSpeedA = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_NoiseUVSpeedA",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_NoiseUVPhaseA = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_NoiseUVPhaseA",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_NoiseUVSpeedB = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_NoiseUVSpeedB",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_NoiseUVPhaseB = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_NoiseUVPhaseB",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_DistortionRange = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_DistortionRange",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_OutDensityTex = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_OutDensityTex",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_InSceneShadowTex = UnityEngine::Shader::PropertyToID(
		                                                                                              (String *)"_InSceneShadowTex",
		                                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_OutSceneShadowTex = UnityEngine::Shader::PropertyToID(
		                                                                                               (String *)"_OutSceneShadowTex",
		                                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_InSdfTex = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_InSdfTex",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_OutAdvancedTex = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_OutAdvancedTex",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_OutSHTex = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_OutSHTex",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_LocalLightNum = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_LocalLightNum",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_LocalLightList = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_LocalLightList",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_ModifierNum = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_ModifierNum",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_ModifierList = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_ModifierList",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_SHSampleNum = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_SHSampleNum",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_SHSampleBuffer = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_SHSampleBuffer",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_BezierSdfRange = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_BezierSdfRange",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_MaxSpeed = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_MaxSpeed",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_InvMaxSpeed = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_InvMaxSpeed",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_NumBezierPoints = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_NumBezierPoints",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_BezierPoints = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_BezierPoints",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_OutBezierSDFTex1 = UnityEngine::Shader::PropertyToID(
		                                                                                              (String *)"_OutBezierSDFTex1",
		                                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_OutBezierSDFTex2 = UnityEngine::Shader::PropertyToID(
		                                                                                              (String *)"_OutBezierSDFTex2",
		                                                                                              0LL);
		}
		
	}
}
