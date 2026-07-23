using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class UberPostPassUtils // TypeDefIndex: 38138
	{
		// Fields
		private const GraphicsFormat k_PostProcessColorFormat = GraphicsFormat.B10G11R11_UFloatPack32; // Metadata: 0x02303A47
		internal const int k_RTGuardBandSize = 4; // Metadata: 0x02303A49
		internal static ComputeBuffer autoExposure_histogramBuffer; // 0x00
		private static float[] m_autoExposure_histogramRes; // 0x08
		private const int AUTO_EXPOSURE_HISTOGRAM_SIZE = 16; // Metadata: 0x02303A4A
		private const int AUTO_EXPOSURE_THREAD_GROUP_SIZE_X = 8; // Metadata: 0x02303A4B
		private const int AUTO_EXPOSURE_THREAD_GROUP_SIZE_Y = 8; // Metadata: 0x02303A4C
		private const int AUTO_EXPOSURE_TILE_SIZE = 16; // Metadata: 0x02303A4D
		private static float m_currentExposure; // 0x10
		private static float m_targetExposure; // 0x14
		private static double m_autoExposure_timeThisFrame; // 0x18
		private static float m_autoExposure_deltaTime; // 0x20
		private static bool m_autoExposureReadyForNextFetch; // 0x24
		private NativeArray<float> m_autoExposure_readbackData; // 0x10
		private static readonly RenderFunc<HGAutoExposurePassData> s_autoExposureCSRenderFunc; // 0x28
		private static HGAutoExposureData s_cachedAutoExposureData; // 0x30
		internal const int k_MaxBloomMipCount = 16; // Metadata: 0x02303A4E
		private static readonly RenderFunc<BloomPassData> s_bloomCSRenderFunc; // 0x38
		private static readonly RenderFunc<BloomPassData> s_bloomPSRenderFunc; // 0x40
		private static readonly RenderFunc<ColorGradingPassData> s_colorGradingRenderFunc; // 0x48
		private static readonly RenderFunc<ColorGradingPassData> s_skipColorGradingPass; // 0x50
		private static ColorGradingData s_colorGradingData; // 0x58
		private static Material[] s_cutSceneEffectMaterials; // 0x60
		private static Vector3[] s_cutsceneEffectMeshVertices; // 0x68
		private static Mesh s_cutsceneEffectMesh; // 0x70
		private static readonly RenderFunc<CutsceneEffectData> m_cutsceneEffectFunc; // 0x78
		private static readonly RenderFunc<FisheyeEffectData> m_fisheyeEffectFunc; // 0x80
		internal const float k_frostedGlassDownsampleScale = 0.25f; // Metadata: 0x02303A4F
		internal const int k_frostedGlassDownsampleNum = 3; // Metadata: 0x02303A53
		internal const float k_frostedGlassColorThreshold = 2.5f; // Metadata: 0x02303A54
		internal const GraphicsFormat k_frostedGlassFormat = GraphicsFormat.B10G11R11_UFloatPack32; // Metadata: 0x02303A58
		private static readonly RenderFunc<FrostedGlassSkipPassData> s_frostedGlassSkipRenderFunc; // 0x88
		private static readonly RenderFunc<FrostedGlassPassData> s_frostedGlassCSRenderFunc; // 0x90
		private static readonly RenderFunc<FrostedGlassPassData> s_frostedGlassPSRenderFunc; // 0x98
		private static FrostedGlassData s_frostedGlassData; // 0xA0
		private static long[] s_mipDownsCpp; // 0xA8
		private static readonly RenderFunc<SharpenData> s_sharpenRenderFunc; // 0xB0
	
		// Nested types
		internal class HGAutoExposureData // TypeDefIndex: 38119
		{
			// Fields
			public TextureHandle inputTexture; // 0x10
			public ComputeShader autoExposureHistogramCS; // 0x20
			public int histogramKernel; // 0x28
			public ComputeBuffer histogramBuffer; // 0x30
			public bool autoExposureActive; // 0x38
			public AutoExposureMode autoExposureMode; // 0x3C
			public Vector2 exposureEv100Range; // 0x40
			public Vector2 exposureEv100HistogramRange; // 0x48
			public Vector2 pixelLuminanceRange; // 0x50
			public float centerPixelWeight; // 0x58
			public float evCompensationManual; // 0x5C
			public float evCompensationAuto; // 0x60
			public Vector2 evClampRange; // 0x64
			public float lerpDownSpeed; // 0x6C
			public float lerpUpSpeed; // 0x70
			public bool curveEditModeEnabled; // 0x74
			public AutoExposureMeteringMode meteringMode; // 0x78
			public int textureSizeX; // 0x7C
			public int textureSizeY; // 0x80
			public int threadGroupsX; // 0x84
			public int threadGroupsY; // 0x88
			public float deltaTime; // 0x8C
			public HGCamera hgCamera; // 0x90
	
			// Constructors
			public HGAutoExposureData() {} // 0x00000001841E1670-0x00000001841E1680
			// Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
			void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
			        HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
			        HGWindConfig *cSrc,
			        HGWindConfig *cDst,
			        float t,
			        MethodInfo *method)
			{
			  ;
			}
			
		}
	
		internal class HGAutoExposurePassData // TypeDefIndex: 38120
		{
			// Fields
			public TextureHandle inputTexture; // 0x10
			public ComputeShader autoExposureHistogramCS; // 0x20
			public int histogramKernel; // 0x28
			public ComputeBuffer histogramBuffer; // 0x30
			public int textureSizeX; // 0x38
			public int textureSizeY; // 0x3C
			public int threadGroupsX; // 0x40
			public int threadGroupsY; // 0x44
			public Vector2 exposureEv100Range; // 0x48
			public float centerPixelWeight; // 0x50
	
			// Constructors
			public HGAutoExposurePassData() {} // 0x00000001841E1670-0x00000001841E1680
			// Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
			void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
			        HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
			        HGWindConfig *cSrc,
			        HGWindConfig *cDst,
			        float t,
			        MethodInfo *method)
			{
			  ;
			}
			
		}
	
		internal class BloomPassData // TypeDefIndex: 38121
		{
			// Fields
			public Material bloomPrefilterMat; // 0x10
			public Material[] bloomBlurMat1stPass; // 0x18
			public Material[] bloomBlurMat2ndPass; // 0x20
			public Material[] bloomUpsampleMat; // 0x28
			public ComputeShader bloomPrefilterCS; // 0x30
			public ComputeShader bloomBlurCS; // 0x38
			public ComputeShader bloomBlurNonOptCS; // 0x40
			public ComputeShader bloomUpsampleCS; // 0x48
			public int bloomPrefilterKernel; // 0x50
			public int bloomBlurKernel; // 0x54
			public int bloomDownsampleKernel; // 0x58
			public int bloomUpsampleKernel; // 0x5C
			public int viewCount; // 0x60
			public int bloomMipCount; // 0x64
			public Vector4[] bloomMipInfo; // 0x68
			public float bloomScatterParam; // 0x70
			public Vector4 thresholdParams; // 0x74
			public Vector4 characterThresholdParams; // 0x84
			public Vector4 characterParams; // 0x94
			public bool enableAlpha; // 0xA4
			public BloomQuality bloomQuality; // 0xA8
			public bool enableCharacterMask; // 0xAC
			public TextureHandle source; // 0xB0
			public TextureHandle motionVector; // 0xC0
			public TextureHandle mips0Temp; // 0xD0
			public TextureHandle[] mipsDown; // 0xE0
			public TextureHandle[] mipsUp; // 0xE8
	
			// Constructors
			public BloomPassData() {} // 0x0000000189B75390-0x0000000189B7545C
			// UberPostPassUtils+BloomPassData()
			void HG::Rendering::Runtime::UberPostPassUtils::BloomPassData::BloomPassData(
			        UberPostPassUtils_BloomPassData *this,
			        MethodInfo *method)
			{
			  HGRuntimeGrassQuery_Node *v3; // rdx
			  HGRuntimeGrassQuery_Node *v4; // r8
			  Int32__Array **v5; // r9
			  HGRuntimeGrassQuery_Node *v6; // rdx
			  HGRuntimeGrassQuery_Node *v7; // r8
			  Int32__Array **v8; // r9
			  HGRuntimeGrassQuery_Node *v9; // rdx
			  HGRuntimeGrassQuery_Node *v10; // r8
			  Int32__Array **v11; // r9
			  HGRuntimeGrassQuery_Node *v12; // rdx
			  HGRuntimeGrassQuery_Node *v13; // r8
			  Int32__Array **v14; // r9
			  HGRuntimeGrassQuery_Node *v15; // rdx
			  HGRuntimeGrassQuery_Node *v16; // r8
			  Int32__Array **v17; // r9
			  HGRuntimeGrassQuery_Node *v18; // rdx
			  HGRuntimeGrassQuery_Node *v19; // r8
			  Int32__Array **v20; // r9
			  MethodInfo *v21; // [rsp+20h] [rbp-8h]
			  MethodInfo *v22; // [rsp+20h] [rbp-8h]
			  MethodInfo *v23; // [rsp+20h] [rbp-8h]
			  MethodInfo *v24; // [rsp+20h] [rbp-8h]
			  MethodInfo *v25; // [rsp+20h] [rbp-8h]
			  MethodInfo *v26; // [rsp+50h] [rbp+28h]
			
			  this->fields.bloomBlurMat1stPass = (Material__Array *)il2cpp_array_new_specific_1(
			                                                          TypeInfo::UnityEngine::Material,
			                                                          17LL);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.bloomBlurMat1stPass, v3, v4, v5, v21);
			  this->fields.bloomBlurMat2ndPass = (Material__Array *)il2cpp_array_new_specific_1(
			                                                          TypeInfo::UnityEngine::Material,
			                                                          17LL);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.bloomBlurMat2ndPass, v6, v7, v8, v22);
			  this->fields.bloomUpsampleMat = (Material__Array *)il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Material, 17LL);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.bloomUpsampleMat, v9, v10, v11, v23);
			  this->fields.bloomMipInfo = (Vector4__Array *)il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector4, 17LL);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.bloomMipInfo, v12, v13, v14, v24);
			  this->fields.mipsDown = (TextureHandle__Array *)il2cpp_array_new_specific_1(
			                                                    TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle,
			                                                    17LL);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.mipsDown, v15, v16, v17, v25);
			  this->fields.mipsUp = (TextureHandle__Array *)il2cpp_array_new_specific_1(
			                                                  TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle,
			                                                  17LL);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.mipsUp, v18, v19, v20, v26);
			}
			
		}
	
		internal struct BloomPSMaterials // TypeDefIndex: 38122
		{
			// Fields
			public Material prefilterMaterial; // 0x00
			public Material[] blur1stPassMaterials; // 0x08
			public Material[] blur2ndPassMaterials; // 0x10
			public Material[] bloomUpsampleMaterials; // 0x18
		}
	
		internal struct CachedColorGradingData // TypeDefIndex: 38123
		{
			// Fields
			internal int lutSize; // 0x00
			private bool tonemappingActive; // 0x04
			private TonemappingMode tonemappingMode; // 0x08
			private Texture externalLuT; // 0x10
			private Texture2D colorCurve_masterCurve; // 0x18
			private Texture2D colorCurve_redCurve; // 0x20
			private Texture2D colorCurve_greenCurve; // 0x28
			private Texture2D colorCurve_blueCurve; // 0x30
			private Texture2D colorCurve_hueVsHueCurve; // 0x38
			private Texture2D colorCurve_hueVsSatCurve; // 0x40
			private Texture2D colorCurve_satVsSatCurve; // 0x48
			private Texture2D colorCurve_lumVsSatCurve; // 0x50
			private Vector4 colorFilter; // 0x58
			private Vector3 lmsColorBalance; // 0x68
			private Vector4 hueSatCon; // 0x74
			private Vector4 channelMixerR; // 0x84
			private Vector4 channelMixerG; // 0x94
			private Vector4 channelMixerB; // 0xA4
			private Vector4 shadows; // 0xB4
			private Vector4 midtones; // 0xC4
			private Vector4 highlights; // 0xD4
			private Vector4 shadowsHighlightsLimits; // 0xE4
			private Vector4 lift; // 0xF4
			private Vector4 gamma; // 0x104
			private Vector4 gain; // 0x114
			private Vector4 splitShadows; // 0x124
			private Vector4 splitHighlights; // 0x134
			private Vector4 miscParams; // 0x144
			private float tonemapping_toeStrength; // 0x154
			private float tonemapping_toeLength; // 0x158
			private float tonemapping_shoulderStrength; // 0x15C
			private float tonemapping_shoulderLength; // 0x160
			private float tonemapping_shoulderAngle; // 0x164
			private float tonemapping_gamma; // 0x168
			private float lutContribution; // 0x16C
	
			// Constructors
			public CachedColorGradingData(ColorGradingData colorGradingPassData) {
				lutSize = default;
				tonemappingActive = default;
				tonemappingMode = default;
				externalLuT = default;
				colorCurve_masterCurve = default;
				colorCurve_redCurve = default;
				colorCurve_greenCurve = default;
				colorCurve_blueCurve = default;
				colorCurve_hueVsHueCurve = default;
				colorCurve_hueVsSatCurve = default;
				colorCurve_satVsSatCurve = default;
				colorCurve_lumVsSatCurve = default;
				colorFilter = default;
				lmsColorBalance = default;
				hueSatCon = default;
				channelMixerR = default;
				channelMixerG = default;
				channelMixerB = default;
				shadows = default;
				midtones = default;
				highlights = default;
				shadowsHighlightsLimits = default;
				lift = default;
				gamma = default;
				gain = default;
				splitShadows = default;
				splitHighlights = default;
				miscParams = default;
				tonemapping_toeStrength = default;
				tonemapping_toeLength = default;
				tonemapping_shoulderStrength = default;
				tonemapping_shoulderLength = default;
				tonemapping_shoulderAngle = default;
				tonemapping_gamma = default;
				lutContribution = default;
			} // 0x0000000189B75DE0-0x0000000189B76070
			// UberPostPassUtils+CachedColorGradingData(UberPostPassUtils+ColorGradingData)
			void HG::Rendering::Runtime::UberPostPassUtils::CachedColorGradingData::CachedColorGradingData(
			        UberPostPassUtils_CachedColorGradingData *this,
			        UberPostPassUtils_ColorGradingData *colorGradingPassData,
			        MethodInfo *method)
			{
			  Int32__Array **v3; // r9
			  UberPostPassUtils_CachedColorGradingData *v5; // rbx
			  HGRuntimeGrassQuery_Node *v6; // rdx
			  HGRuntimeGrassQuery_Node *v7; // r8
			  Int32__Array **v8; // r9
			  HGRuntimeGrassQuery_Node *v9; // rdx
			  HGRuntimeGrassQuery_Node *v10; // r8
			  Int32__Array **v11; // r9
			  HGRuntimeGrassQuery_Node *v12; // rdx
			  HGRuntimeGrassQuery_Node *v13; // r8
			  Int32__Array **v14; // r9
			  HGRuntimeGrassQuery_Node *v15; // rdx
			  HGRuntimeGrassQuery_Node *v16; // r8
			  Int32__Array **v17; // r9
			  HGRuntimeGrassQuery_Node *v18; // rdx
			  HGRuntimeGrassQuery_Node *v19; // r8
			  Int32__Array **v20; // r9
			  HGRuntimeGrassQuery_Node *v21; // rdx
			  HGRuntimeGrassQuery_Node *v22; // r8
			  Int32__Array **v23; // r9
			  HGRuntimeGrassQuery_Node *v24; // rdx
			  HGRuntimeGrassQuery_Node *v25; // r8
			  Int32__Array **v26; // r9
			  HGRuntimeGrassQuery_Node *v27; // rdx
			  HGRuntimeGrassQuery_Node *v28; // r8
			  Int32__Array **v29; // r9
			  float z; // eax
			  __m128i v31; // xmm1
			  MethodInfo *v32; // [rsp+20h] [rbp-8h]
			  MethodInfo *v33; // [rsp+20h] [rbp-8h]
			  MethodInfo *v34; // [rsp+20h] [rbp-8h]
			  MethodInfo *v35; // [rsp+20h] [rbp-8h]
			  MethodInfo *v36; // [rsp+20h] [rbp-8h]
			  MethodInfo *v37; // [rsp+20h] [rbp-8h]
			  MethodInfo *v38; // [rsp+20h] [rbp-8h]
			  MethodInfo *v39; // [rsp+20h] [rbp-8h]
			  MethodInfo *v40; // [rsp+20h] [rbp-8h]
			
			  this->tonemappingActive = 1;
			  v5 = this;
			  if ( !colorGradingPassData )
			    goto LABEL_11;
			  this->lutSize = colorGradingPassData->fields.lutSize;
			  this->tonemappingMode = colorGradingPassData->fields.tonemappingMode;
			  this->externalLuT = colorGradingPassData->fields.externalLuT;
			  sub_18002D1B0(
			    (HGRuntimeGrassQuery_Node *)&this->externalLuT,
			    (HGRuntimeGrassQuery_Node *)colorGradingPassData,
			    (HGRuntimeGrassQuery_Node *)method,
			    v3,
			    v32);
			  this = (UberPostPassUtils_CachedColorGradingData *)colorGradingPassData->fields.masterCurve;
			  if ( !this )
			    goto LABEL_11;
			  v5->colorCurve_masterCurve = UnityEngine::Rendering::TextureCurve::GetTexture((TextureCurve *)this, 0LL);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v5->colorCurve_masterCurve, v6, v7, v8, v33);
			  this = (UberPostPassUtils_CachedColorGradingData *)colorGradingPassData->fields.redCurve;
			  if ( !this )
			    goto LABEL_11;
			  v5->colorCurve_redCurve = UnityEngine::Rendering::TextureCurve::GetTexture((TextureCurve *)this, 0LL);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v5->colorCurve_redCurve, v9, v10, v11, v34);
			  this = (UberPostPassUtils_CachedColorGradingData *)colorGradingPassData->fields.greenCurve;
			  if ( !this )
			    goto LABEL_11;
			  v5->colorCurve_greenCurve = UnityEngine::Rendering::TextureCurve::GetTexture((TextureCurve *)this, 0LL);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v5->colorCurve_greenCurve, v12, v13, v14, v35);
			  this = (UberPostPassUtils_CachedColorGradingData *)colorGradingPassData->fields.blueCurve;
			  if ( !this )
			    goto LABEL_11;
			  v5->colorCurve_blueCurve = UnityEngine::Rendering::TextureCurve::GetTexture((TextureCurve *)this, 0LL);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v5->colorCurve_blueCurve, v15, v16, v17, v36);
			  this = (UberPostPassUtils_CachedColorGradingData *)colorGradingPassData->fields.hueVsHueCurve;
			  if ( !this )
			    goto LABEL_11;
			  v5->colorCurve_hueVsHueCurve = UnityEngine::Rendering::TextureCurve::GetTexture((TextureCurve *)this, 0LL);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v5->colorCurve_hueVsHueCurve, v18, v19, v20, v37);
			  this = (UberPostPassUtils_CachedColorGradingData *)colorGradingPassData->fields.hueVsSatCurve;
			  if ( !this
			    || (v5->colorCurve_hueVsSatCurve = UnityEngine::Rendering::TextureCurve::GetTexture((TextureCurve *)this, 0LL),
			        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v5->colorCurve_hueVsSatCurve, v21, v22, v23, v38),
			        (this = (UberPostPassUtils_CachedColorGradingData *)colorGradingPassData->fields.satVsSatCurve) == 0LL)
			    || (v5->colorCurve_satVsSatCurve = UnityEngine::Rendering::TextureCurve::GetTexture((TextureCurve *)this, 0LL),
			        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v5->colorCurve_satVsSatCurve, v24, v25, v26, v39),
			        (this = (UberPostPassUtils_CachedColorGradingData *)colorGradingPassData->fields.lumVsSatCurve) == 0LL) )
			  {
			LABEL_11:
			    sub_1800D8260(this, colorGradingPassData);
			  }
			  v5->colorCurve_lumVsSatCurve = UnityEngine::Rendering::TextureCurve::GetTexture((TextureCurve *)this, 0LL);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v5->colorCurve_lumVsSatCurve, v27, v28, v29, v40);
			  v5->colorFilter = (Vector4)_mm_loadu_si128((const __m128i *)&colorGradingPassData->fields.colorFilter);
			  z = colorGradingPassData->fields.lmsColorBalance.z;
			  *(_QWORD *)&v5->lmsColorBalance.x = *(_QWORD *)&colorGradingPassData->fields.lmsColorBalance.x;
			  v5->lmsColorBalance.z = z;
			  v5->hueSatCon = (Vector4)_mm_loadu_si128((const __m128i *)&colorGradingPassData->fields.hueSatCon);
			  v5->channelMixerR = (Vector4)_mm_loadu_si128((const __m128i *)&colorGradingPassData->fields.channelMixerR);
			  v5->channelMixerG = (Vector4)_mm_loadu_si128((const __m128i *)&colorGradingPassData->fields.channelMixerG);
			  v5->channelMixerB = (Vector4)_mm_loadu_si128((const __m128i *)&colorGradingPassData->fields.channelMixerB);
			  v5->shadows = (Vector4)_mm_loadu_si128((const __m128i *)&colorGradingPassData->fields.shadows);
			  v5->midtones = (Vector4)_mm_loadu_si128((const __m128i *)&colorGradingPassData->fields.midtones);
			  v5->highlights = (Vector4)_mm_loadu_si128((const __m128i *)&colorGradingPassData->fields.highlights);
			  v5->shadowsHighlightsLimits = (Vector4)_mm_loadu_si128((const __m128i *)&colorGradingPassData->fields.shadowsHighlightsLimits);
			  v5->lift = (Vector4)_mm_loadu_si128((const __m128i *)&colorGradingPassData->fields.lift);
			  v5->gamma = (Vector4)_mm_loadu_si128((const __m128i *)&colorGradingPassData->fields.gamma);
			  v5->gain = (Vector4)_mm_loadu_si128((const __m128i *)&colorGradingPassData->fields.gain);
			  v5->splitShadows = (Vector4)_mm_loadu_si128((const __m128i *)&colorGradingPassData->fields.splitShadows);
			  v5->splitHighlights = (Vector4)_mm_loadu_si128((const __m128i *)&colorGradingPassData->fields.splitHighlights);
			  v31 = _mm_loadu_si128((const __m128i *)&colorGradingPassData->fields.miscParams);
			  v5->tonemapping_toeStrength = 0.0;
			  v5->tonemapping_toeLength = 0.0;
			  v5->tonemapping_shoulderStrength = 0.0;
			  v5->tonemapping_shoulderLength = 0.0;
			  v5->tonemapping_shoulderAngle = 0.0;
			  v5->tonemapping_gamma = 0.0;
			  v5->miscParams = (Vector4)v31;
			  v5->lutContribution = colorGradingPassData->fields.lutContribution;
			}
			
	
			// Methods
			public bool Equals([IsReadOnly] in CachedColorGradingData otherData) => default; // 0x0000000189B7545C-0x0000000189B75DE0
			// Boolean Equals(UberPostPassUtils+CachedColorGradingData ByRef)
			bool HG::Rendering::Runtime::UberPostPassUtils::CachedColorGradingData::Equals(
			        UberPostPassUtils_CachedColorGradingData *this,
			        UberPostPassUtils_CachedColorGradingData *otherData,
			        MethodInfo *method)
			{
			  Object_1 *externalLuT; // rdi
			  Object_1 *v6; // rbx
			  Object_1 *colorCurve_masterCurve; // rdi
			  Object_1 *v8; // rbx
			  Object_1 *colorCurve_redCurve; // rdi
			  Object_1 *v10; // rbx
			  Object_1 *colorCurve_greenCurve; // rdi
			  Object_1 *v12; // rbx
			  Object_1 *colorCurve_blueCurve; // rdi
			  Object_1 *v14; // rbx
			  Object_1 *colorCurve_hueVsHueCurve; // rdi
			  Object_1 *v16; // rbx
			  Object_1 *colorCurve_hueVsSatCurve; // rdi
			  Object_1 *v18; // rbx
			  Object_1 *colorCurve_satVsSatCurve; // rdi
			  Object_1 *v20; // rbx
			  Object_1 *colorCurve_lumVsSatCurve; // rdi
			  Object_1 *v22; // rbx
			  __m128 v23; // xmm2
			  __m128 v24; // xmm5
			  float v25; // xmm4_4
			  float v26; // xmm1_4
			  float v27; // xmm3_4
			  float v28; // xmm0_4
			  float v29; // xmm1_4
			  __m128 v30; // xmm2
			  __m128 v31; // xmm5
			  float v32; // xmm4_4
			  float v33; // xmm1_4
			  float v34; // xmm3_4
			  float v35; // xmm0_4
			  __m128 v36; // xmm2
			  __m128 v37; // xmm5
			  float v38; // xmm4_4
			  float v39; // xmm1_4
			  float v40; // xmm3_4
			  float v41; // xmm0_4
			  __m128 v42; // xmm2
			  __m128 v43; // xmm5
			  float v44; // xmm4_4
			  float v45; // xmm1_4
			  float v46; // xmm3_4
			  float v47; // xmm0_4
			  __m128 v48; // xmm2
			  __m128 v49; // xmm5
			  float v50; // xmm4_4
			  float v51; // xmm1_4
			  float v52; // xmm3_4
			  float v53; // xmm0_4
			  __m128 v54; // xmm2
			  __m128 v55; // xmm5
			  float v56; // xmm4_4
			  float v57; // xmm1_4
			  float v58; // xmm3_4
			  float v59; // xmm0_4
			  __m128 v60; // xmm2
			  __m128 v61; // xmm5
			  float v62; // xmm4_4
			  float v63; // xmm1_4
			  float v64; // xmm3_4
			  float v65; // xmm0_4
			  __m128 v66; // xmm2
			  __m128 v67; // xmm5
			  float v68; // xmm4_4
			  float v69; // xmm1_4
			  float v70; // xmm3_4
			  float v71; // xmm0_4
			  __m128 v72; // xmm2
			  __m128 v73; // xmm5
			  float v74; // xmm4_4
			  float v75; // xmm1_4
			  float v76; // xmm3_4
			  float v77; // xmm0_4
			  __m128 v78; // xmm2
			  __m128 v79; // xmm5
			  float v80; // xmm4_4
			  float v81; // xmm1_4
			  float v82; // xmm3_4
			  float v83; // xmm0_4
			  __m128 v84; // xmm2
			  __m128 v85; // xmm5
			  float v86; // xmm4_4
			  float v87; // xmm1_4
			  float v88; // xmm3_4
			  float v89; // xmm0_4
			  __m128 v90; // xmm2
			  __m128 v91; // xmm5
			  float v92; // xmm4_4
			  float v93; // xmm1_4
			  float v94; // xmm3_4
			  float v95; // xmm0_4
			  __m128 v96; // xmm2
			  __m128 v97; // xmm5
			  float v98; // xmm4_4
			  float v99; // xmm1_4
			  float v100; // xmm3_4
			  float v101; // xmm0_4
			  __m128 v102; // xmm2
			  __m128 v103; // xmm5
			  float v104; // xmm4_4
			  float v105; // xmm1_4
			  float v106; // xmm3_4
			  float v107; // xmm0_4
			  __m128 v108; // xmm2
			  __m128 v109; // xmm5
			  float v110; // xmm4_4
			  float v111; // xmm1_4
			  float v112; // xmm3_4
			  float v113; // xmm0_4
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v116; // rdx
			  __int64 v117; // rcx
			  float v118[4]; // [rsp+30h] [rbp-28h]
			
			  if ( IFix::WrappersManagerImpl::IsPatched(2915, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(2915, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v117, v116);
			    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1071(Patch, this, otherData, 0LL);
			  }
			  else
			  {
			    if ( this->tonemappingActive != otherData->tonemappingActive )
			      return 0;
			    if ( this->lutSize != otherData->lutSize )
			      return 0;
			    if ( this->tonemappingMode != otherData->tonemappingMode )
			      return 0;
			    externalLuT = (Object_1 *)this->externalLuT;
			    v6 = (Object_1 *)otherData->externalLuT;
			    sub_1800036A0(TypeInfo::UnityEngine::Object);
			    if ( !UnityEngine::Object::op_Equality(externalLuT, v6, 0LL) )
			      return 0;
			    colorCurve_masterCurve = (Object_1 *)this->colorCurve_masterCurve;
			    v8 = (Object_1 *)otherData->colorCurve_masterCurve;
			    sub_1800036A0(TypeInfo::UnityEngine::Object);
			    if ( !UnityEngine::Object::op_Equality(colorCurve_masterCurve, v8, 0LL) )
			      return 0;
			    colorCurve_redCurve = (Object_1 *)this->colorCurve_redCurve;
			    v10 = (Object_1 *)otherData->colorCurve_redCurve;
			    sub_1800036A0(TypeInfo::UnityEngine::Object);
			    if ( !UnityEngine::Object::op_Equality(colorCurve_redCurve, v10, 0LL) )
			      return 0;
			    colorCurve_greenCurve = (Object_1 *)this->colorCurve_greenCurve;
			    v12 = (Object_1 *)otherData->colorCurve_greenCurve;
			    sub_1800036A0(TypeInfo::UnityEngine::Object);
			    if ( !UnityEngine::Object::op_Equality(colorCurve_greenCurve, v12, 0LL) )
			      return 0;
			    colorCurve_blueCurve = (Object_1 *)this->colorCurve_blueCurve;
			    v14 = (Object_1 *)otherData->colorCurve_blueCurve;
			    sub_1800036A0(TypeInfo::UnityEngine::Object);
			    if ( !UnityEngine::Object::op_Equality(colorCurve_blueCurve, v14, 0LL) )
			      return 0;
			    colorCurve_hueVsHueCurve = (Object_1 *)this->colorCurve_hueVsHueCurve;
			    v16 = (Object_1 *)otherData->colorCurve_hueVsHueCurve;
			    sub_1800036A0(TypeInfo::UnityEngine::Object);
			    if ( !UnityEngine::Object::op_Equality(colorCurve_hueVsHueCurve, v16, 0LL) )
			      return 0;
			    colorCurve_hueVsSatCurve = (Object_1 *)this->colorCurve_hueVsSatCurve;
			    v18 = (Object_1 *)otherData->colorCurve_hueVsSatCurve;
			    sub_1800036A0(TypeInfo::UnityEngine::Object);
			    if ( !UnityEngine::Object::op_Equality(colorCurve_hueVsSatCurve, v18, 0LL) )
			      return 0;
			    colorCurve_satVsSatCurve = (Object_1 *)this->colorCurve_satVsSatCurve;
			    v20 = (Object_1 *)otherData->colorCurve_satVsSatCurve;
			    sub_1800036A0(TypeInfo::UnityEngine::Object);
			    if ( !UnityEngine::Object::op_Equality(colorCurve_satVsSatCurve, v20, 0LL) )
			      return 0;
			    colorCurve_lumVsSatCurve = (Object_1 *)this->colorCurve_lumVsSatCurve;
			    v22 = (Object_1 *)otherData->colorCurve_lumVsSatCurve;
			    sub_1800036A0(TypeInfo::UnityEngine::Object);
			    if ( !UnityEngine::Object::op_Equality(colorCurve_lumVsSatCurve, v22, 0LL) )
			      return 0;
			    v23 = (__m128)_mm_loadu_si128((const __m128i *)&otherData->colorFilter);
			    v24 = (__m128)_mm_loadu_si128((const __m128i *)&this->colorFilter);
			    v25 = _mm_shuffle_ps(v24, v24, 85).m128_f32[0] - _mm_shuffle_ps(v23, v23, 85).m128_f32[0];
			    v26 = _mm_shuffle_ps(v24, v24, 170).m128_f32[0];
			    v27 = v24.m128_f32[0] - v23.m128_f32[0];
			    v24.m128_f32[0] = _mm_shuffle_ps(v24, v24, 255).m128_f32[0];
			    v28 = _mm_shuffle_ps(v23, v23, 170).m128_f32[0];
			    v23.m128_f32[0] = _mm_shuffle_ps(v23, v23, 255).m128_f32[0];
			    if ( (float)((float)((float)((float)(v25 * v25) + (float)(v27 * v27))
			                       + (float)((float)(v26 - v28) * (float)(v26 - v28)))
			               + (float)((float)(v24.m128_f32[0] - v23.m128_f32[0]) * (float)(v24.m128_f32[0] - v23.m128_f32[0]))) >= 9.9999994e-11 )
			      return 0;
			    v29 = this->lmsColorBalance.z - otherData->lmsColorBalance.z;
			    *(_QWORD *)v118 = *(_QWORD *)&otherData->lmsColorBalance.x;
			    if ( (float)((float)((float)((float)(COERCE_FLOAT(HIDWORD(*(_QWORD *)&this->lmsColorBalance.x)) - v118[1])
			                               * (float)(COERCE_FLOAT(HIDWORD(*(_QWORD *)&this->lmsColorBalance.x)) - v118[1]))
			                       + (float)((float)(COERCE_FLOAT(*(_QWORD *)&this->lmsColorBalance.x) - v118[0])
			                               * (float)(COERCE_FLOAT(*(_QWORD *)&this->lmsColorBalance.x) - v118[0])))
			               + (float)(v29 * v29)) >= 9.9999994e-11 )
			      return 0;
			    v30 = (__m128)_mm_loadu_si128((const __m128i *)&otherData->hueSatCon);
			    v31 = (__m128)_mm_loadu_si128((const __m128i *)&this->hueSatCon);
			    v32 = _mm_shuffle_ps(v31, v31, 85).m128_f32[0] - _mm_shuffle_ps(v30, v30, 85).m128_f32[0];
			    v33 = _mm_shuffle_ps(v31, v31, 170).m128_f32[0];
			    v34 = v31.m128_f32[0] - v30.m128_f32[0];
			    v31.m128_f32[0] = _mm_shuffle_ps(v31, v31, 255).m128_f32[0];
			    v35 = _mm_shuffle_ps(v30, v30, 170).m128_f32[0];
			    v30.m128_f32[0] = _mm_shuffle_ps(v30, v30, 255).m128_f32[0];
			    if ( (float)((float)((float)((float)(v32 * v32) + (float)(v34 * v34))
			                       + (float)((float)(v33 - v35) * (float)(v33 - v35)))
			               + (float)((float)(v31.m128_f32[0] - v30.m128_f32[0]) * (float)(v31.m128_f32[0] - v30.m128_f32[0]))) >= 9.9999994e-11 )
			      return 0;
			    v36 = (__m128)_mm_loadu_si128((const __m128i *)&otherData->channelMixerR);
			    v37 = (__m128)_mm_loadu_si128((const __m128i *)&this->channelMixerR);
			    v38 = _mm_shuffle_ps(v37, v37, 85).m128_f32[0] - _mm_shuffle_ps(v36, v36, 85).m128_f32[0];
			    v39 = _mm_shuffle_ps(v37, v37, 170).m128_f32[0];
			    v40 = v37.m128_f32[0] - v36.m128_f32[0];
			    v37.m128_f32[0] = _mm_shuffle_ps(v37, v37, 255).m128_f32[0];
			    v41 = _mm_shuffle_ps(v36, v36, 170).m128_f32[0];
			    v36.m128_f32[0] = _mm_shuffle_ps(v36, v36, 255).m128_f32[0];
			    if ( (float)((float)((float)((float)(v38 * v38) + (float)(v40 * v40))
			                       + (float)((float)(v39 - v41) * (float)(v39 - v41)))
			               + (float)((float)(v37.m128_f32[0] - v36.m128_f32[0]) * (float)(v37.m128_f32[0] - v36.m128_f32[0]))) >= 9.9999994e-11 )
			      return 0;
			    v42 = (__m128)_mm_loadu_si128((const __m128i *)&otherData->channelMixerG);
			    v43 = (__m128)_mm_loadu_si128((const __m128i *)&this->channelMixerG);
			    v44 = _mm_shuffle_ps(v43, v43, 85).m128_f32[0] - _mm_shuffle_ps(v42, v42, 85).m128_f32[0];
			    v45 = _mm_shuffle_ps(v43, v43, 170).m128_f32[0];
			    v46 = v43.m128_f32[0] - v42.m128_f32[0];
			    v43.m128_f32[0] = _mm_shuffle_ps(v43, v43, 255).m128_f32[0];
			    v47 = _mm_shuffle_ps(v42, v42, 170).m128_f32[0];
			    v42.m128_f32[0] = _mm_shuffle_ps(v42, v42, 255).m128_f32[0];
			    if ( (float)((float)((float)((float)(v44 * v44) + (float)(v46 * v46))
			                       + (float)((float)(v45 - v47) * (float)(v45 - v47)))
			               + (float)((float)(v43.m128_f32[0] - v42.m128_f32[0]) * (float)(v43.m128_f32[0] - v42.m128_f32[0]))) >= 9.9999994e-11 )
			      return 0;
			    v48 = (__m128)_mm_loadu_si128((const __m128i *)&otherData->channelMixerB);
			    v49 = (__m128)_mm_loadu_si128((const __m128i *)&this->channelMixerB);
			    v50 = _mm_shuffle_ps(v49, v49, 85).m128_f32[0] - _mm_shuffle_ps(v48, v48, 85).m128_f32[0];
			    v51 = _mm_shuffle_ps(v49, v49, 170).m128_f32[0];
			    v52 = v49.m128_f32[0] - v48.m128_f32[0];
			    v49.m128_f32[0] = _mm_shuffle_ps(v49, v49, 255).m128_f32[0];
			    v53 = _mm_shuffle_ps(v48, v48, 170).m128_f32[0];
			    v48.m128_f32[0] = _mm_shuffle_ps(v48, v48, 255).m128_f32[0];
			    if ( (float)((float)((float)((float)(v50 * v50) + (float)(v52 * v52))
			                       + (float)((float)(v51 - v53) * (float)(v51 - v53)))
			               + (float)((float)(v49.m128_f32[0] - v48.m128_f32[0]) * (float)(v49.m128_f32[0] - v48.m128_f32[0]))) >= 9.9999994e-11 )
			      return 0;
			    v54 = (__m128)_mm_loadu_si128((const __m128i *)&otherData->shadows);
			    v55 = (__m128)_mm_loadu_si128((const __m128i *)&this->shadows);
			    v56 = _mm_shuffle_ps(v55, v55, 85).m128_f32[0] - _mm_shuffle_ps(v54, v54, 85).m128_f32[0];
			    v57 = _mm_shuffle_ps(v55, v55, 170).m128_f32[0];
			    v58 = v55.m128_f32[0] - v54.m128_f32[0];
			    v55.m128_f32[0] = _mm_shuffle_ps(v55, v55, 255).m128_f32[0];
			    v59 = _mm_shuffle_ps(v54, v54, 170).m128_f32[0];
			    v54.m128_f32[0] = _mm_shuffle_ps(v54, v54, 255).m128_f32[0];
			    if ( (float)((float)((float)((float)(v56 * v56) + (float)(v58 * v58))
			                       + (float)((float)(v57 - v59) * (float)(v57 - v59)))
			               + (float)((float)(v55.m128_f32[0] - v54.m128_f32[0]) * (float)(v55.m128_f32[0] - v54.m128_f32[0]))) >= 9.9999994e-11 )
			      return 0;
			    v60 = (__m128)_mm_loadu_si128((const __m128i *)&otherData->midtones);
			    v61 = (__m128)_mm_loadu_si128((const __m128i *)&this->midtones);
			    v62 = _mm_shuffle_ps(v61, v61, 85).m128_f32[0] - _mm_shuffle_ps(v60, v60, 85).m128_f32[0];
			    v63 = _mm_shuffle_ps(v61, v61, 170).m128_f32[0];
			    v64 = v61.m128_f32[0] - v60.m128_f32[0];
			    v61.m128_f32[0] = _mm_shuffle_ps(v61, v61, 255).m128_f32[0];
			    v65 = _mm_shuffle_ps(v60, v60, 170).m128_f32[0];
			    v60.m128_f32[0] = _mm_shuffle_ps(v60, v60, 255).m128_f32[0];
			    if ( (float)((float)((float)((float)(v62 * v62) + (float)(v64 * v64))
			                       + (float)((float)(v63 - v65) * (float)(v63 - v65)))
			               + (float)((float)(v61.m128_f32[0] - v60.m128_f32[0]) * (float)(v61.m128_f32[0] - v60.m128_f32[0]))) >= 9.9999994e-11 )
			      return 0;
			    v66 = (__m128)_mm_loadu_si128((const __m128i *)&otherData->highlights);
			    v67 = (__m128)_mm_loadu_si128((const __m128i *)&this->highlights);
			    v68 = _mm_shuffle_ps(v67, v67, 85).m128_f32[0] - _mm_shuffle_ps(v66, v66, 85).m128_f32[0];
			    v69 = _mm_shuffle_ps(v67, v67, 170).m128_f32[0];
			    v70 = v67.m128_f32[0] - v66.m128_f32[0];
			    v67.m128_f32[0] = _mm_shuffle_ps(v67, v67, 255).m128_f32[0];
			    v71 = _mm_shuffle_ps(v66, v66, 170).m128_f32[0];
			    v66.m128_f32[0] = _mm_shuffle_ps(v66, v66, 255).m128_f32[0];
			    if ( (float)((float)((float)((float)(v68 * v68) + (float)(v70 * v70))
			                       + (float)((float)(v69 - v71) * (float)(v69 - v71)))
			               + (float)((float)(v67.m128_f32[0] - v66.m128_f32[0]) * (float)(v67.m128_f32[0] - v66.m128_f32[0]))) >= 9.9999994e-11 )
			      return 0;
			    v72 = (__m128)_mm_loadu_si128((const __m128i *)&otherData->shadowsHighlightsLimits);
			    v73 = (__m128)_mm_loadu_si128((const __m128i *)&this->shadowsHighlightsLimits);
			    v74 = _mm_shuffle_ps(v73, v73, 85).m128_f32[0] - _mm_shuffle_ps(v72, v72, 85).m128_f32[0];
			    v75 = _mm_shuffle_ps(v73, v73, 170).m128_f32[0];
			    v76 = v73.m128_f32[0] - v72.m128_f32[0];
			    v73.m128_f32[0] = _mm_shuffle_ps(v73, v73, 255).m128_f32[0];
			    v77 = _mm_shuffle_ps(v72, v72, 170).m128_f32[0];
			    v72.m128_f32[0] = _mm_shuffle_ps(v72, v72, 255).m128_f32[0];
			    if ( (float)((float)((float)((float)(v74 * v74) + (float)(v76 * v76))
			                       + (float)((float)(v75 - v77) * (float)(v75 - v77)))
			               + (float)((float)(v73.m128_f32[0] - v72.m128_f32[0]) * (float)(v73.m128_f32[0] - v72.m128_f32[0]))) >= 9.9999994e-11 )
			      return 0;
			    v78 = (__m128)_mm_loadu_si128((const __m128i *)&otherData->lift);
			    v79 = (__m128)_mm_loadu_si128((const __m128i *)&this->lift);
			    v80 = _mm_shuffle_ps(v79, v79, 85).m128_f32[0] - _mm_shuffle_ps(v78, v78, 85).m128_f32[0];
			    v81 = _mm_shuffle_ps(v79, v79, 170).m128_f32[0];
			    v82 = v79.m128_f32[0] - v78.m128_f32[0];
			    v79.m128_f32[0] = _mm_shuffle_ps(v79, v79, 255).m128_f32[0];
			    v83 = _mm_shuffle_ps(v78, v78, 170).m128_f32[0];
			    v78.m128_f32[0] = _mm_shuffle_ps(v78, v78, 255).m128_f32[0];
			    if ( (float)((float)((float)((float)(v80 * v80) + (float)(v82 * v82))
			                       + (float)((float)(v81 - v83) * (float)(v81 - v83)))
			               + (float)((float)(v79.m128_f32[0] - v78.m128_f32[0]) * (float)(v79.m128_f32[0] - v78.m128_f32[0]))) >= 9.9999994e-11 )
			      return 0;
			    v84 = (__m128)_mm_loadu_si128((const __m128i *)&otherData->gamma);
			    v85 = (__m128)_mm_loadu_si128((const __m128i *)&this->gamma);
			    v86 = _mm_shuffle_ps(v85, v85, 85).m128_f32[0] - _mm_shuffle_ps(v84, v84, 85).m128_f32[0];
			    v87 = _mm_shuffle_ps(v85, v85, 170).m128_f32[0];
			    v88 = v85.m128_f32[0] - v84.m128_f32[0];
			    v85.m128_f32[0] = _mm_shuffle_ps(v85, v85, 255).m128_f32[0];
			    v89 = _mm_shuffle_ps(v84, v84, 170).m128_f32[0];
			    v84.m128_f32[0] = _mm_shuffle_ps(v84, v84, 255).m128_f32[0];
			    if ( (float)((float)((float)((float)(v86 * v86) + (float)(v88 * v88))
			                       + (float)((float)(v87 - v89) * (float)(v87 - v89)))
			               + (float)((float)(v85.m128_f32[0] - v84.m128_f32[0]) * (float)(v85.m128_f32[0] - v84.m128_f32[0]))) >= 9.9999994e-11 )
			      return 0;
			    v90 = (__m128)_mm_loadu_si128((const __m128i *)&otherData->gain);
			    v91 = (__m128)_mm_loadu_si128((const __m128i *)&this->gain);
			    v92 = _mm_shuffle_ps(v91, v91, 85).m128_f32[0] - _mm_shuffle_ps(v90, v90, 85).m128_f32[0];
			    v93 = _mm_shuffle_ps(v91, v91, 170).m128_f32[0];
			    v94 = v91.m128_f32[0] - v90.m128_f32[0];
			    v91.m128_f32[0] = _mm_shuffle_ps(v91, v91, 255).m128_f32[0];
			    v95 = _mm_shuffle_ps(v90, v90, 170).m128_f32[0];
			    v90.m128_f32[0] = _mm_shuffle_ps(v90, v90, 255).m128_f32[0];
			    if ( (float)((float)((float)((float)(v92 * v92) + (float)(v94 * v94))
			                       + (float)((float)(v93 - v95) * (float)(v93 - v95)))
			               + (float)((float)(v91.m128_f32[0] - v90.m128_f32[0]) * (float)(v91.m128_f32[0] - v90.m128_f32[0]))) >= 9.9999994e-11 )
			      return 0;
			    v96 = (__m128)_mm_loadu_si128((const __m128i *)&otherData->splitShadows);
			    v97 = (__m128)_mm_loadu_si128((const __m128i *)&this->splitShadows);
			    v98 = _mm_shuffle_ps(v97, v97, 85).m128_f32[0] - _mm_shuffle_ps(v96, v96, 85).m128_f32[0];
			    v99 = _mm_shuffle_ps(v97, v97, 170).m128_f32[0];
			    v100 = v97.m128_f32[0] - v96.m128_f32[0];
			    v97.m128_f32[0] = _mm_shuffle_ps(v97, v97, 255).m128_f32[0];
			    v101 = _mm_shuffle_ps(v96, v96, 170).m128_f32[0];
			    v96.m128_f32[0] = _mm_shuffle_ps(v96, v96, 255).m128_f32[0];
			    if ( (float)((float)((float)((float)(v98 * v98) + (float)(v100 * v100))
			                       + (float)((float)(v99 - v101) * (float)(v99 - v101)))
			               + (float)((float)(v97.m128_f32[0] - v96.m128_f32[0]) * (float)(v97.m128_f32[0] - v96.m128_f32[0]))) >= 9.9999994e-11 )
			      return 0;
			    v102 = (__m128)_mm_loadu_si128((const __m128i *)&otherData->splitHighlights);
			    v103 = (__m128)_mm_loadu_si128((const __m128i *)&this->splitHighlights);
			    v104 = _mm_shuffle_ps(v103, v103, 85).m128_f32[0] - _mm_shuffle_ps(v102, v102, 85).m128_f32[0];
			    v105 = _mm_shuffle_ps(v103, v103, 170).m128_f32[0];
			    v106 = v103.m128_f32[0] - v102.m128_f32[0];
			    v103.m128_f32[0] = _mm_shuffle_ps(v103, v103, 255).m128_f32[0];
			    v107 = _mm_shuffle_ps(v102, v102, 170).m128_f32[0];
			    v102.m128_f32[0] = _mm_shuffle_ps(v102, v102, 255).m128_f32[0];
			    if ( (float)((float)((float)((float)(v104 * v104) + (float)(v106 * v106))
			                       + (float)((float)(v105 - v107) * (float)(v105 - v107)))
			               + (float)((float)(v103.m128_f32[0] - v102.m128_f32[0]) * (float)(v103.m128_f32[0] - v102.m128_f32[0]))) >= 9.9999994e-11 )
			      return 0;
			    v108 = (__m128)_mm_loadu_si128((const __m128i *)&otherData->miscParams);
			    v109 = (__m128)_mm_loadu_si128((const __m128i *)&this->miscParams);
			    v110 = _mm_shuffle_ps(v109, v109, 85).m128_f32[0] - _mm_shuffle_ps(v108, v108, 85).m128_f32[0];
			    v111 = _mm_shuffle_ps(v109, v109, 170).m128_f32[0];
			    v112 = v109.m128_f32[0] - v108.m128_f32[0];
			    v109.m128_f32[0] = _mm_shuffle_ps(v109, v109, 255).m128_f32[0];
			    v113 = _mm_shuffle_ps(v108, v108, 170).m128_f32[0];
			    v108.m128_f32[0] = _mm_shuffle_ps(v108, v108, 255).m128_f32[0];
			    if ( (float)((float)((float)((float)(v110 * v110) + (float)(v112 * v112))
			                       + (float)((float)(v111 - v113) * (float)(v111 - v113)))
			               + (float)((float)(v109.m128_f32[0] - v108.m128_f32[0]) * (float)(v109.m128_f32[0] - v108.m128_f32[0]))) >= 9.9999994e-11 )
			      return 0;
			    return System::Single::Equals((Single *)&this->tonemapping_toeStrength, otherData->tonemapping_toeStrength, 0LL)
			        && System::Single::Equals((Single *)&this->tonemapping_toeLength, otherData->tonemapping_toeLength, 0LL)
			        && System::Single::Equals(
			             (Single *)&this->tonemapping_shoulderStrength,
			             otherData->tonemapping_shoulderStrength,
			             0LL)
			        && System::Single::Equals(
			             (Single *)&this->tonemapping_shoulderLength,
			             otherData->tonemapping_shoulderLength,
			             0LL)
			        && System::Single::Equals((Single *)&this->tonemapping_shoulderAngle, otherData->tonemapping_shoulderAngle, 0LL)
			        && System::Single::Equals((Single *)&this->tonemapping_gamma, otherData->tonemapping_gamma, 0LL)
			        && System::Single::Equals((Single *)&this->lutContribution, otherData->lutContribution, 0LL);
			  }
			}
			
		}
	
		internal class ColorGradingData // TypeDefIndex: 38124
		{
			// Fields
			public Material lutBuilder2DMaterial; // 0x10
			public int lutSize; // 0x18
			public Vector4 colorFilter; // 0x1C
			public Vector3 lmsColorBalance; // 0x2C
			public Vector4 hueSatCon; // 0x38
			public Vector4 channelMixerR; // 0x48
			public Vector4 channelMixerG; // 0x58
			public Vector4 channelMixerB; // 0x68
			public Vector4 shadows; // 0x78
			public Vector4 midtones; // 0x88
			public Vector4 highlights; // 0x98
			public Vector4 shadowsHighlightsLimits; // 0xA8
			public Vector4 lift; // 0xB8
			public Vector4 gamma; // 0xC8
			public Vector4 gain; // 0xD8
			public Vector4 splitShadows; // 0xE8
			public Vector4 splitHighlights; // 0xF8
			public bool curvesEnabled; // 0x108
			public TextureCurve masterCurve; // 0x110
			public TextureCurve redCurve; // 0x118
			public TextureCurve greenCurve; // 0x120
			public TextureCurve blueCurve; // 0x128
			public TextureCurve hueVsHueCurve; // 0x130
			public TextureCurve hueVsSatCurve; // 0x138
			public TextureCurve lumVsSatCurve; // 0x140
			public TextureCurve satVsSatCurve; // 0x148
			public Vector4 miscParams; // 0x150
			public Texture externalLuT; // 0x160
			public float lutContribution; // 0x168
			public TonemappingMode tonemappingMode; // 0x16C
			public TextureHandle logLut; // 0x170
	
			// Constructors
			public ColorGradingData() {} // 0x00000001841E1670-0x00000001841E1680
			// Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
			void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
			        HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
			        HGWindConfig *cSrc,
			        HGWindConfig *cDst,
			        float t,
			        MethodInfo *method)
			{
			  ;
			}
			
		}
	
		internal class ColorGradingPassData // TypeDefIndex: 38125
		{
			// Fields
			public Material lutBuilder2DMaterial; // 0x10
			public TextureHandle logLut; // 0x18
	
			// Constructors
			public ColorGradingPassData() {} // 0x00000001841E1670-0x00000001841E1680
			// Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
			void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
			        HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
			        HGWindConfig *cSrc,
			        HGWindConfig *cDst,
			        float t,
			        MethodInfo *method)
			{
			  ;
			}
			
		}
	
		private class CutsceneEffectData // TypeDefIndex: 38126
		{
			// Fields
			public TextureHandle sceneColor; // 0x10
			public TextureHandle depthRT; // 0x20
			public Mesh cutsceneEffectMesh; // 0x30
			public Material blitMaterial; // 0x38
			public Material[] cutSceneEffectMaterials; // 0x40
			public int cutSceneEffectMaterialCount; // 0x48
	
			// Constructors
			public CutsceneEffectData() {} // 0x00000001841E1670-0x00000001841E1680
			// Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
			void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
			        HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
			        HGWindConfig *cSrc,
			        HGWindConfig *cDst,
			        float t,
			        MethodInfo *method)
			{
			  ;
			}
			
		}
	
		private class FisheyeEffectData // TypeDefIndex: 38127
		{
			// Fields
			public TextureHandle source; // 0x10
			public TextureHandle sceneDepth; // 0x20
			public bool isFisheyeEffectEnabled; // 0x30
			public Vector4 fisheyeEffectParams1; // 0x34
			public Material fisheyeEffectMaterial; // 0x48
			public Material fisheyeEffectDepthMaterial; // 0x50
	
			// Constructors
			public FisheyeEffectData() {} // 0x00000001841E1670-0x00000001841E1680
			// Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
			void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
			        HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
			        HGWindConfig *cSrc,
			        HGWindConfig *cDst,
			        float t,
			        MethodInfo *method)
			{
			  ;
			}
			
		}
	
		internal struct FrostedGlassPSMaterials // TypeDefIndex: 38128
		{
			// Fields
			public Material[] frostedGlass1stPassMaterials; // 0x00
			public Material[] frostedGlass2ndPassMaterials; // 0x08
		}
	
		internal class FrostedGlassData // TypeDefIndex: 38129
		{
			// Fields
			public ComputeShader frostedGlassBlurCS; // 0x10
			public int kernelKMain; // 0x18
			public int kernelKMainWithLut; // 0x1C
			public Material[] frostedGlass1stPassMat; // 0x20
			public Material[] frostedGlass2ndPassMat; // 0x28
			public int downsampleNum; // 0x30
			public Vector2Int[] mipsDownSize; // 0x38
			public TextureHandle source; // 0x40
			public TextureHandle[] mipsDown; // 0x50
			public TextureHandle[] mipsDownTemp; // 0x58
			public bool enableUserLut; // 0x60
			public float colorThreshold; // 0x64
			public Texture2D userLut; // 0x68
			public Vector4 userLogLutSettings; // 0x70
			public TextureHandle logLut; // 0x80
			public Vector4 logLutSettings; // 0x90
	
			// Constructors
			public FrostedGlassData() {} // 0x0000000184728A90-0x0000000184728B40
			// UberPostPassUtils+FrostedGlassData()
			void HG::Rendering::Runtime::UberPostPassUtils::FrostedGlassData::FrostedGlassData(
			        UberPostPassUtils_FrostedGlassData *this,
			        MethodInfo *method)
			{
			  HGRuntimeGrassQuery_Node *v3; // rdx
			  HGRuntimeGrassQuery_Node *v4; // r8
			  Int32__Array **v5; // r9
			  HGRuntimeGrassQuery_Node *v6; // rdx
			  HGRuntimeGrassQuery_Node *v7; // r8
			  Int32__Array **v8; // r9
			  HGRuntimeGrassQuery_Node *v9; // rdx
			  HGRuntimeGrassQuery_Node *v10; // r8
			  Int32__Array **v11; // r9
			  HGRuntimeGrassQuery_Node *v12; // rdx
			  HGRuntimeGrassQuery_Node *v13; // r8
			  Int32__Array **v14; // r9
			  HGRuntimeGrassQuery_Node *v15; // rdx
			  HGRuntimeGrassQuery_Node *v16; // r8
			  Int32__Array **v17; // r9
			  MethodInfo *v18; // [rsp+20h] [rbp-8h]
			  MethodInfo *v19; // [rsp+20h] [rbp-8h]
			  MethodInfo *v20; // [rsp+20h] [rbp-8h]
			  MethodInfo *v21; // [rsp+20h] [rbp-8h]
			  MethodInfo *v22; // [rsp+50h] [rbp+28h]
			
			  this->fields.frostedGlass1stPassMat = (Material__Array *)il2cpp_array_new_specific_1(
			                                                             TypeInfo::UnityEngine::Material,
			                                                             4LL);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.frostedGlass1stPassMat, v3, v4, v5, v18);
			  this->fields.frostedGlass2ndPassMat = (Material__Array *)il2cpp_array_new_specific_1(
			                                                             TypeInfo::UnityEngine::Material,
			                                                             4LL);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.frostedGlass2ndPassMat, v6, v7, v8, v19);
			  this->fields.mipsDownSize = (Vector2Int__Array *)il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector2Int, 4LL);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.mipsDownSize, v9, v10, v11, v20);
			  this->fields.mipsDown = (TextureHandle__Array *)il2cpp_array_new_specific_1(
			                                                    TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle,
			                                                    4LL);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.mipsDown, v12, v13, v14, v21);
			  this->fields.mipsDownTemp = (TextureHandle__Array *)il2cpp_array_new_specific_1(
			                                                        TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle,
			                                                        4LL);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.mipsDownTemp, v15, v16, v17, v22);
			}
			
		}
	
		internal class FrostedGlassPassData // TypeDefIndex: 38130
		{
			// Fields
			public ComputeShader frostedGlassBlurCS; // 0x10
			public int kernelKMain; // 0x18
			public int kernelKMainWithLut; // 0x1C
			public bool sceneFrostedGlass; // 0x20
			public Material[] frostedGlass1stPassMat; // 0x28
			public Material[] frostedGlass2ndPassMat; // 0x30
			public int downsampleNum; // 0x38
			public Vector2Int[] mipsDownSize; // 0x40
			public TextureHandle source; // 0x48
			public TextureHandle[] mipsDown; // 0x58
			public TextureHandle[] mipsDownTemp; // 0x60
			public bool enableUserLut; // 0x68
			public float colorThreshold; // 0x6C
			public Texture2D userLut; // 0x70
			public Vector4 userLogLutSettings; // 0x78
			public TextureHandle logLut; // 0x88
			public Vector4 logLutSettings; // 0x98
	
			// Constructors
			public FrostedGlassPassData() {} // 0x0000000189B76174-0x0000000189B76218
			// UberPostPassUtils+FrostedGlassPassData()
			void HG::Rendering::Runtime::UberPostPassUtils::FrostedGlassPassData::FrostedGlassPassData(
			        UberPostPassUtils_FrostedGlassPassData *this,
			        MethodInfo *method)
			{
			  HGRuntimeGrassQuery_Node *v3; // rdx
			  HGRuntimeGrassQuery_Node *v4; // r8
			  Int32__Array **v5; // r9
			  HGRuntimeGrassQuery_Node *v6; // rdx
			  HGRuntimeGrassQuery_Node *v7; // r8
			  Int32__Array **v8; // r9
			  HGRuntimeGrassQuery_Node *v9; // rdx
			  HGRuntimeGrassQuery_Node *v10; // r8
			  Int32__Array **v11; // r9
			  HGRuntimeGrassQuery_Node *v12; // rdx
			  HGRuntimeGrassQuery_Node *v13; // r8
			  Int32__Array **v14; // r9
			  HGRuntimeGrassQuery_Node *v15; // rdx
			  HGRuntimeGrassQuery_Node *v16; // r8
			  Int32__Array **v17; // r9
			  MethodInfo *v18; // [rsp+20h] [rbp-8h]
			  MethodInfo *v19; // [rsp+20h] [rbp-8h]
			  MethodInfo *v20; // [rsp+20h] [rbp-8h]
			  MethodInfo *v21; // [rsp+20h] [rbp-8h]
			  MethodInfo *v22; // [rsp+50h] [rbp+28h]
			
			  this->fields.frostedGlass1stPassMat = (Material__Array *)il2cpp_array_new_specific_1(
			                                                             TypeInfo::UnityEngine::Material,
			                                                             4LL);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.frostedGlass1stPassMat, v3, v4, v5, v18);
			  this->fields.frostedGlass2ndPassMat = (Material__Array *)il2cpp_array_new_specific_1(
			                                                             TypeInfo::UnityEngine::Material,
			                                                             4LL);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.frostedGlass2ndPassMat, v6, v7, v8, v19);
			  this->fields.mipsDownSize = (Vector2Int__Array *)il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector2Int, 4LL);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.mipsDownSize, v9, v10, v11, v20);
			  this->fields.mipsDown = (TextureHandle__Array *)il2cpp_array_new_specific_1(
			                                                    TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle,
			                                                    4LL);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.mipsDown, v12, v13, v14, v21);
			  this->fields.mipsDownTemp = (TextureHandle__Array *)il2cpp_array_new_specific_1(
			                                                        TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle,
			                                                        4LL);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.mipsDownTemp, v15, v16, v17, v22);
			}
			
		}
	
		internal class FrostedGlassSkipPassData // TypeDefIndex: 38131
		{
			// Fields
			public Texture cachedFrostedGlassTexHeavy; // 0x10
			public Texture cachedFrostedGlassTexMedium; // 0x18
			public Texture cachedFrostedGlassTexLight; // 0x20
	
			// Constructors
			public FrostedGlassSkipPassData() {} // 0x00000001841E1670-0x00000001841E1680
			// Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
			void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
			        HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
			        HGWindConfig *cSrc,
			        HGWindConfig *cDst,
			        float t,
			        MethodInfo *method)
			{
			  ;
			}
			
		}
	
		internal class SharpenData // TypeDefIndex: 38132
		{
			// Fields
			public Material sharpenMaterial; // 0x10
			public TextureHandle source; // 0x18
			public TextureHandle sharpenTexture; // 0x28
	
			// Constructors
			public SharpenData() {} // 0x00000001841E1670-0x00000001841E1680
			// Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
			void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
			        HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
			        HGWindConfig *cSrc,
			        HGWindConfig *cDst,
			        float t,
			        MethodInfo *method)
			{
			  ;
			}
			
		}
	
		internal class UberPostPassData // TypeDefIndex: 38133
		{
			// Fields
			public Material uberPostMaterial; // 0x10
			public Vector4 logLutSettings; // 0x18
			public Vector4 userLogLutSettings; // 0x28
			public Vector4 dirtyLensParams1; // 0x38
			public Texture dirtyTex; // 0x48
			public Vector4 radialBlurParams; // 0x50
			public Vector4 radialBlurParams2; // 0x60
			public bool isBwFlashEnabled; // 0x70
			public Vector4 bwFlashThreshold; // 0x74
			public Vector4 bwFlashParams; // 0x84
			public Vector4 bwFlashParams2; // 0x94
			public Vector4 bwFlashParams3; // 0xA4
			public Vector4 bwFlashParams4; // 0xB4
			public Texture bwFlashTexture; // 0xC8
			public Texture bwMaskTexture; // 0xD0
			public UnityEngine.Color bwFlashColor; // 0xD8
			public UnityEngine.Color bwBackGroundColor; // 0xE8
			public Vector4 fisheyeEffectParams1; // 0xF8
			public Texture userLut; // 0x108
			public TextureHandle source; // 0x110
			public TextureHandle destination; // 0x120
			public TextureHandle logLut; // 0x130
			public TextureHandle sceneDepthBuffer; // 0x140
			public RendererListHandle worldUIRenderList; // 0x150
			public uint worldUIECSRenderList; // 0x158
			public uint hgUIRenderList; // 0x15C
			public PPVignetteData vignetteData; // 0x160
			public PPBloomData bloomData; // 0x168
	
			// Constructors
			public UberPostPassData() {} // 0x0000000184A43490-0x0000000184A434F0
			// UberPostPassUtils+UberPostPassData()
			void HG::Rendering::Runtime::UberPostPassUtils::UberPostPassData::UberPostPassData(
			        UberPostPassUtils_UberPostPassData *this,
			        MethodInfo *method)
			{
			  UberPostPassUtils_PPVignetteData *v3; // rax
			  HGRuntimeGrassQuery_Node *v4; // rdx
			  __int64 v5; // rcx
			  HGRuntimeGrassQuery_Node *v6; // r8
			  Int32__Array **v7; // r9
			  UberPostPassUtils_PPBloomData *v8; // rax
			  HGRuntimeGrassQuery_Node *v9; // r8
			  Int32__Array **v10; // r9
			  MethodInfo *v11; // [rsp+20h] [rbp-8h]
			  MethodInfo *v12; // [rsp+50h] [rbp+28h]
			
			  v3 = (UberPostPassUtils_PPVignetteData *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils::PPVignetteData);
			  if ( !v3
			    || (this->fields.vignetteData = v3,
			        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.vignetteData, v4, v6, v7, v11),
			        (v8 = (UberPostPassUtils_PPBloomData *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils::PPBloomData)) == 0LL) )
			  {
			    sub_1800D8260(v5, v4);
			  }
			  this->fields.bloomData = v8;
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.bloomData, v4, v9, v10, v12);
			}
			
		}
	
		internal class PPBloomData // TypeDefIndex: 38134
		{
			// Fields
			public TextureHandle bloomTexture; // 0x10
			public Texture bloomDirtTexture; // 0x20
			public Vector4 bloomParams; // 0x28
			public Vector4 bloomTint; // 0x38
			public Vector4 bloomBicubicParams; // 0x48
			public Vector4 bloomDirtTileOffset; // 0x58
			public Vector4 bloomThreshold; // 0x68
	
			// Constructors
			public PPBloomData() {} // 0x00000001841E1670-0x00000001841E1680
			// Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
			void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
			        HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
			        HGWindConfig *cSrc,
			        HGWindConfig *cDst,
			        float t,
			        MethodInfo *method)
			{
			  ;
			}
			
		}
	
		internal class PPVignetteData // TypeDefIndex: 38135
		{
			// Fields
			public Vector4 vignetteParams1; // 0x10
			public Vector4 vignetteParams2; // 0x20
			public Vector4 vignetteColor; // 0x30
			public Texture vignetteMask; // 0x40
	
			// Constructors
			public PPVignetteData() {} // 0x00000001841E1670-0x00000001841E1680
			// Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
			void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
			        HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
			        HGWindConfig *cSrc,
			        HGWindConfig *cDst,
			        float t,
			        MethodInfo *method)
			{
			  ;
			}
			
		}
	
		// Constructors
		public UberPostPassUtils() {} // 0x00000001841E1670-0x00000001841E1680
		// Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
		void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
		        HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
		        HGWindConfig *cSrc,
		        HGWindConfig *cDst,
		        float t,
		        MethodInfo *method)
		{
		  ;
		}
		
		static UberPostPassUtils() {} // 0x0000000184728420-0x0000000184728A90
		// UberPostPassUtils()
		void HG::Rendering::Runtime::UberPostPassUtils::cctor(MethodInfo *method)
		{
		  struct UberPostPassUtils_c__Class *v1; // rax
		  Object *v2; // rdi
		  RenderFunc_1_System_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  HGRuntimeGrassQuery_Node *v6; // rbx
		  HGRuntimeGrassQuery_Node *static_fields; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  __int64 v10; // rax
		  HGRuntimeGrassQuery_Node *v11; // r8
		  Int32__Array **v12; // r9
		  HGRuntimeGrassQuery_Node *v13; // rdx
		  Object *v14; // rdi
		  RenderFunc_1_System_Object_ *v15; // rax
		  HGRuntimeGrassQuery_Node *v16; // rbx
		  HGRuntimeGrassQuery_Node *v17; // rdx
		  HGRuntimeGrassQuery_Node *v18; // r8
		  Int32__Array **v19; // r9
		  Object *v20; // rdi
		  RenderFunc_1_System_Object_ *v21; // rax
		  Bounds__Array *v22; // rbx
		  HGRuntimeGrassQuery_Node *v23; // rdx
		  HGRuntimeGrassQuery_Node *v24; // r8
		  Int32__Array **v25; // r9
		  Object *v26; // rdi
		  RenderFunc_1_System_Object_ *v27; // rax
		  HGRuntimeGrassQuery_Node__Class *v28; // rbx
		  HGRuntimeGrassQuery_Node *v29; // rdx
		  HGRuntimeGrassQuery_Node *v30; // r8
		  Int32__Array **v31; // r9
		  Object *v32; // rdi
		  RenderFunc_1_System_Object_ *v33; // rax
		  MonitorData *v34; // rbx
		  HGRuntimeGrassQuery_Node *v35; // rdx
		  HGRuntimeGrassQuery_Node *v36; // r8
		  Int32__Array **v37; // r9
		  __int64 v38; // rax
		  HGRuntimeGrassQuery_Node *v39; // r8
		  Int32__Array **v40; // r9
		  UberPostPassUtils__StaticFields *v41; // rdx
		  __int64 v42; // rax
		  UberPostPassUtils__StaticFields *v43; // rdx
		  HGRuntimeGrassQuery_Node *v44; // r8
		  Int32__Array **v45; // r9
		  Int32__Array **v46; // r9
		  HGRuntimeGrassQuery_Node *v47; // rdx
		  HGRuntimeGrassQuery_Node *v48; // r8
		  Object *v49; // rdi
		  RenderFunc_1_System_Object_ *v50; // rax
		  HGRuntimeGrassQuery_Node *v51; // rbx
		  HGRuntimeGrassQuery_Node *v52; // rdx
		  HGRuntimeGrassQuery_Node *v53; // r8
		  Int32__Array **v54; // r9
		  Object *v55; // rdi
		  RenderFunc_1_System_Object_ *v56; // rax
		  HGRuntimeGrassQuery_Node *v57; // rbx
		  HGRuntimeGrassQuery_Node *v58; // rdx
		  HGRuntimeGrassQuery_Node *v59; // r8
		  Int32__Array **v60; // r9
		  Object *v61; // rdi
		  RenderFunc_1_System_Object_ *v62; // rax
		  Bounds__Array *v63; // rbx
		  HGRuntimeGrassQuery_Node *v64; // rdx
		  HGRuntimeGrassQuery_Node *v65; // r8
		  Int32__Array **v66; // r9
		  Object *v67; // rdi
		  RenderFunc_1_System_Object_ *v68; // rax
		  HGRuntimeGrassQuery_Node__Class *v69; // rbx
		  HGRuntimeGrassQuery_Node *v70; // rdx
		  HGRuntimeGrassQuery_Node *v71; // r8
		  Int32__Array **v72; // r9
		  Object *v73; // rdi
		  RenderFunc_1_System_Object_ *v74; // rax
		  MonitorData *v75; // rbx
		  HGRuntimeGrassQuery_Node *v76; // rdx
		  HGRuntimeGrassQuery_Node *v77; // r8
		  Int32__Array **v78; // r9
		  UberPostPassUtils_FrostedGlassData *v79; // rax
		  UberPostPassUtils_FrostedGlassData *v80; // rbx
		  UberPostPassUtils__StaticFields *v81; // rdx
		  HGRuntimeGrassQuery_Node *v82; // r8
		  Int32__Array **v83; // r9
		  __int64 v84; // rax
		  UberPostPassUtils__StaticFields *v85; // rdx
		  HGRuntimeGrassQuery_Node *v86; // r8
		  Int32__Array **v87; // r9
		  Object *v88; // rdi
		  RenderFunc_1_System_Object_ *v89; // rax
		  RenderFunc_1_HG_Rendering_Runtime_UberPostPassUtils_SharpenData_ *v90; // rbx
		  UberPostPassUtils__StaticFields *v91; // rdx
		  HGRuntimeGrassQuery_Node *v92; // r8
		  Int32__Array **v93; // r9
		  MethodInfo *v94; // [rsp+20h] [rbp-8h]
		  MethodInfo *v95; // [rsp+20h] [rbp-8h]
		  MethodInfo *v96; // [rsp+20h] [rbp-8h]
		  MethodInfo *v97; // [rsp+20h] [rbp-8h]
		  MethodInfo *v98; // [rsp+20h] [rbp-8h]
		  MethodInfo *v99; // [rsp+20h] [rbp-8h]
		  MethodInfo *v100; // [rsp+20h] [rbp-8h]
		  MethodInfo *v101; // [rsp+20h] [rbp-8h]
		  MethodInfo *v102; // [rsp+20h] [rbp-8h]
		  MethodInfo *v103; // [rsp+20h] [rbp-8h]
		  MethodInfo *v104; // [rsp+20h] [rbp-8h]
		  MethodInfo *v105; // [rsp+20h] [rbp-8h]
		  MethodInfo *v106; // [rsp+20h] [rbp-8h]
		  MethodInfo *v107; // [rsp+20h] [rbp-8h]
		  MethodInfo *v108; // [rsp+20h] [rbp-8h]
		  MethodInfo *v109; // [rsp+20h] [rbp-8h]
		  MethodInfo *v110; // [rsp+50h] [rbp+28h]
		
		  TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->m_currentExposure = 1.0;
		  TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->m_targetExposure = 1.0;
		  TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->m_autoExposureReadyForNextFetch = 1;
		  v1 = TypeInfo::HG::Rendering::Runtime::UberPostPassUtils::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::UberPostPassUtils::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils::__c);
		    v1 = TypeInfo::HG::Rendering::Runtime::UberPostPassUtils::__c;
		  }
		  v2 = (Object *)v1->static_fields->__9;
		  v3 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::UberPostPassUtils::HGAutoExposurePassData>);
		  v6 = (HGRuntimeGrassQuery_Node *)v3;
		  if ( !v3 )
		    goto LABEL_4;
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v3,
		    v2,
		    MethodInfo::HG::Rendering::Runtime::UberPostPassUtils::__c::__cctor_b__104_0,
		    0LL);
		  static_fields = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields;
		  static_fields->fields.parent = v6;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->s_autoExposureCSRenderFunc,
		    static_fields,
		    v8,
		    v9,
		    v94);
		  v10 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils::HGAutoExposureData);
		  if ( !v10 )
		    goto LABEL_4;
		  v13 = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields;
		  v13->fields.left = (HGRuntimeGrassQuery_Node *)v10;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->s_cachedAutoExposureData,
		    v13,
		    v11,
		    v12,
		    v95);
		  v14 = (Object *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils::__c->static_fields->__9;
		  v15 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::UberPostPassUtils::BloomPassData>);
		  v16 = (HGRuntimeGrassQuery_Node *)v15;
		  if ( !v15 )
		    goto LABEL_4;
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v15,
		    v14,
		    MethodInfo::HG::Rendering::Runtime::UberPostPassUtils::__c::__cctor_b__104_1,
		    0LL);
		  v17 = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields;
		  v17->fields.right = v16;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->s_bloomCSRenderFunc,
		    v17,
		    v18,
		    v19,
		    v96);
		  v20 = (Object *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils::__c->static_fields->__9;
		  v21 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::UberPostPassUtils::BloomPassData>);
		  v22 = (Bounds__Array *)v21;
		  if ( !v21 )
		    goto LABEL_4;
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v21,
		    v20,
		    MethodInfo::HG::Rendering::Runtime::UberPostPassUtils::__c::__cctor_b__104_2,
		    0LL);
		  v23 = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields;
		  v23->fields.grassInstanceBounds = v22;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->s_bloomPSRenderFunc,
		    v23,
		    v24,
		    v25,
		    v97);
		  v26 = (Object *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils::__c->static_fields->__9;
		  v27 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::UberPostPassUtils::ColorGradingPassData>);
		  v28 = (HGRuntimeGrassQuery_Node__Class *)v27;
		  if ( !v27 )
		    goto LABEL_4;
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v27,
		    v26,
		    MethodInfo::HG::Rendering::Runtime::UberPostPassUtils::__c::__cctor_b__104_3,
		    0LL);
		  v29 = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields;
		  v29[1].klass = v28;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->s_colorGradingRenderFunc,
		    v29,
		    v30,
		    v31,
		    v98);
		  v32 = (Object *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils::__c->static_fields->__9;
		  v33 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::UberPostPassUtils::ColorGradingPassData>);
		  v34 = (MonitorData *)v33;
		  if ( !v33 )
		    goto LABEL_4;
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v33,
		    v32,
		    MethodInfo::HG::Rendering::Runtime::UberPostPassUtils::__c::__cctor_b__104_4,
		    0LL);
		  v35 = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields;
		  v35[1].monitor = v34;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->s_skipColorGradingPass,
		    v35,
		    v36,
		    v37,
		    v99);
		  v38 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils::ColorGradingData);
		  if ( !v38 )
		    goto LABEL_4;
		  v41 = TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields;
		  v41->s_colorGradingData = (UberPostPassUtils_ColorGradingData *)v38;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->s_colorGradingData,
		    (HGRuntimeGrassQuery_Node *)v41,
		    v39,
		    v40,
		    v100);
		  v42 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Material, 32LL);
		  v43 = TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields;
		  v43->s_cutSceneEffectMaterials = (Material__Array *)v42;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->s_cutSceneEffectMaterials,
		    (HGRuntimeGrassQuery_Node *)v43,
		    v44,
		    v45,
		    v101);
		  v46 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils;
		  TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->s_cutsceneEffectMesh = 0LL;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->s_cutsceneEffectMesh,
		    v47,
		    v48,
		    v46,
		    v102);
		  v49 = (Object *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils::__c->static_fields->__9;
		  v50 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::UberPostPassUtils::CutsceneEffectData>);
		  v51 = (HGRuntimeGrassQuery_Node *)v50;
		  if ( !v50 )
		    goto LABEL_4;
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v50,
		    v49,
		    MethodInfo::HG::Rendering::Runtime::UberPostPassUtils::__c::__cctor_b__104_5,
		    0LL);
		  v52 = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields;
		  v52[1].fields.left = v51;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->m_cutsceneEffectFunc,
		    v52,
		    v53,
		    v54,
		    v103);
		  v55 = (Object *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils::__c->static_fields->__9;
		  v56 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::UberPostPassUtils::FisheyeEffectData>);
		  v57 = (HGRuntimeGrassQuery_Node *)v56;
		  if ( !v56 )
		    goto LABEL_4;
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v56,
		    v55,
		    MethodInfo::HG::Rendering::Runtime::UberPostPassUtils::__c::__cctor_b__104_6,
		    0LL);
		  v58 = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields;
		  v58[1].fields.right = v57;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->m_fisheyeEffectFunc,
		    v58,
		    v59,
		    v60,
		    v104);
		  v61 = (Object *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils::__c->static_fields->__9;
		  v62 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::UberPostPassUtils::FrostedGlassSkipPassData>);
		  v63 = (Bounds__Array *)v62;
		  if ( !v62 )
		    goto LABEL_4;
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v62,
		    v61,
		    MethodInfo::HG::Rendering::Runtime::UberPostPassUtils::__c::__cctor_b__104_7,
		    0LL);
		  v64 = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields;
		  v64[1].fields.grassInstanceBounds = v63;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->s_frostedGlassSkipRenderFunc,
		    v64,
		    v65,
		    v66,
		    v105);
		  v67 = (Object *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils::__c->static_fields->__9;
		  v68 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::UberPostPassUtils::FrostedGlassPassData>);
		  v69 = (HGRuntimeGrassQuery_Node__Class *)v68;
		  if ( !v68 )
		    goto LABEL_4;
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v68,
		    v67,
		    MethodInfo::HG::Rendering::Runtime::UberPostPassUtils::__c::__cctor_b__104_8,
		    0LL);
		  v70 = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields;
		  v70[2].klass = v69;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->s_frostedGlassCSRenderFunc,
		    v70,
		    v71,
		    v72,
		    v106);
		  v73 = (Object *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils::__c->static_fields->__9;
		  v74 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::UberPostPassUtils::FrostedGlassPassData>);
		  v75 = (MonitorData *)v74;
		  if ( !v74 )
		    goto LABEL_4;
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v74,
		    v73,
		    MethodInfo::HG::Rendering::Runtime::UberPostPassUtils::__c::__cctor_b__104_9,
		    0LL);
		  v76 = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields;
		  v76[2].monitor = v75;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->s_frostedGlassPSRenderFunc,
		    v76,
		    v77,
		    v78,
		    v107);
		  v79 = (UberPostPassUtils_FrostedGlassData *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils::FrostedGlassData);
		  v80 = v79;
		  if ( !v79 )
		    goto LABEL_4;
		  HG::Rendering::Runtime::UberPostPassUtils::FrostedGlassData::FrostedGlassData(v79, 0LL);
		  v81 = TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields;
		  v81->s_frostedGlassData = v80;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->s_frostedGlassData,
		    (HGRuntimeGrassQuery_Node *)v81,
		    v82,
		    v83,
		    v108);
		  v84 = il2cpp_array_new_specific_1(TypeInfo::System::Int64, 4LL);
		  v85 = TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields;
		  v85->s_mipDownsCpp = (Int64__Array *)v84;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->s_mipDownsCpp,
		    (HGRuntimeGrassQuery_Node *)v85,
		    v86,
		    v87,
		    v109);
		  v88 = (Object *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils::__c->static_fields->__9;
		  v89 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::UberPostPassUtils::SharpenData>);
		  v90 = (RenderFunc_1_HG_Rendering_Runtime_UberPostPassUtils_SharpenData_ *)v89;
		  if ( !v89 )
		LABEL_4:
		    sub_1800D8260(v5, v4);
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v89,
		    v88,
		    MethodInfo::HG::Rendering::Runtime::UberPostPassUtils::__c::__cctor_b__104_10,
		    0LL);
		  v91 = TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields;
		  v91->s_sharpenRenderFunc = v90;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->s_sharpenRenderFunc,
		    (HGRuntimeGrassQuery_Node *)v91,
		    v92,
		    v93,
		    v110);
		}
		
	
		// Methods
		internal static float GetPostExposureLinear(HGCamera camera) => default; // 0x0000000183C94B40-0x0000000183C94C50
		// Single GetPostExposureLinear(HGCamera)
		float HG::Rendering::Runtime::UberPostPassUtils::GetPostExposureLinear(HGCamera *camera, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  HGEnvironmentPhase *InterpolatedPhase; // rax
		  HGColorGradingConfig *p_colorGradingConfig; // rbx
		  double v7; // xmm0_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ILFixDynamicMethodWrapper_2 *v9; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_15;
		  if ( wrapperArray->max_length.size > 1146 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v3->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_15;
		    if ( wrapperArray->max_length.size <= 0x47Au )
		      goto LABEL_30;
		    if ( wrapperArray[31].vector[30] )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(1146, 0LL);
		      if ( Patch )
		      {
		        *(float *)&v7 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46(
		                          (ILFixDynamicMethodWrapper_15 *)Patch,
		                          (Object *)camera,
		                          0LL);
		        return *(float *)&v7;
		      }
		      goto LABEL_15;
		    }
		  }
		  if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		  InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(camera, 0LL);
		  if ( !InterpolatedPhase )
		    goto LABEL_15;
		  p_colorGradingConfig = &InterpolatedPhase->fields.colorGradingConfig;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_15;
		  if ( wrapperArray->max_length.size > 1147 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( !v3 )
		      goto LABEL_15;
		    if ( LODWORD(v3->_0.namespaze) > 0x47B )
		    {
		      if ( !v3[24].static_fields )
		        goto LABEL_14;
		      v9 = IFix::WrappersManagerImpl::GetPatch(1147, 0LL);
		      if ( v9 )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_383(v9, p_colorGradingConfig, 0LL);
		        goto LABEL_14;
		      }
		LABEL_15:
		      sub_1800D8260(v3, wrapperArray);
		    }
		LABEL_30:
		    sub_1800D2AB0(v3, wrapperArray);
		  }
		LABEL_14:
		  v7 = sub_1803369A0();
		  return *(float *)&v7;
		}
		
		internal static GraphicsFormat GetPostprocessTextureFormat(bool enableAlpha, GraphicsFormat ppFormat) => default; // 0x0000000189B82918-0x0000000189B82978
		// GraphicsFormat GetPostprocessTextureFormat(Boolean, GraphicsFormat)
		GraphicsFormat__Enum HG::Rendering::Runtime::UberPostPassUtils::GetPostprocessTextureFormat(
		        bool enableAlpha,
		        GraphicsFormat__Enum ppFormat,
		        MethodInfo *method)
		{
		  GraphicsFormat__Enum result; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2869, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2869, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1050(Patch, enableAlpha, ppFormat, 0LL);
		  }
		  else
		  {
		    result = GraphicsFormat__Enum_R16G16B16A16_SFloat;
		    if ( !enableAlpha )
		      return ppFormat;
		  }
		  return result;
		}
		
		internal static GraphicsFormat GetPostprocessComputeTextureFormat(bool enableAlpha) => default; // 0x0000000189B828BC-0x0000000189B82918
		// GraphicsFormat GetPostprocessComputeTextureFormat(Boolean)
		GraphicsFormat__Enum HG::Rendering::Runtime::UberPostPassUtils::GetPostprocessComputeTextureFormat(
		        bool enableAlpha,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2870, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2870, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1051(Patch, enableAlpha, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		    return HG::Rendering::Runtime::HGUtils::GetDeviceSupportedRWTextureFormat(enableAlpha, 0LL);
		  }
		}
		
		internal static bool ShouldRenderPostProcess(HGCamera camera) => default; // 0x000000018344FC20-0x000000018344FD50
		// Boolean ShouldRenderPostProcess(HGCamera)
		bool HG::Rendering::Runtime::UberPostPassUtils::ShouldRenderPostProcess(HGCamera *camera, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  Camera *v5; // rdi
		  unsigned int (__fastcall *v6)(Camera *); // rax
		  BitArray128 bitDatas; // xmm1
		  __int64 v8; // xmm0_8
		  bool v9; // zf
		  bool v10; // al
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v13; // rax
		  ILFixDynamicMethodWrapper_2 *v14; // rax
		  FrameSettings P0; // [rsp+30h] [rbp-28h] BYREF
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_18;
		  if ( wrapperArray->max_length.size > 952 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v3->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_18;
		    if ( wrapperArray->max_length.size <= 0x3B8u )
		      goto LABEL_37;
		    if ( wrapperArray[26].vector[16] )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(952, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14(
		                 (ILFixDynamicMethodWrapper_20 *)Patch,
		                 (Object *)camera,
		                 0LL);
		      goto LABEL_18;
		    }
		  }
		  if ( !camera )
		    goto LABEL_18;
		  v5 = camera->fields.camera;
		  if ( !v5 )
		    goto LABEL_18;
		  v6 = (unsigned int (__fastcall *)(Camera *))qword_18F36F138;
		  if ( !qword_18F36F138 )
		  {
		    v6 = (unsigned int (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Camera::get_cameraType()");
		    if ( !v6 )
		    {
		      v13 = sub_1802EE1B8("UnityEngine.Camera::get_cameraType()");
		      sub_18007E1B0(v13, 0LL);
		    }
		    qword_18F36F138 = (__int64)v6;
		  }
		  if ( v6(v5) == 4 )
		    return 1;
		  bitDatas = camera->fields._frameSettings_k__BackingField.bitDatas;
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v8 = *(_QWORD *)&camera->fields._frameSettings_k__BackingField.materialQuality;
		  v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor == 0;
		  P0.bitDatas = bitDatas;
		  *(_QWORD *)&P0.materialQuality = v8;
		  if ( v9 )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_18;
		  if ( wrapperArray->max_length.size > 734 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( !v3 )
		      goto LABEL_18;
		    if ( LODWORD(v3->_0.namespaze) > 0x2DE )
		    {
		      if ( !*(_QWORD *)&v3[15]._1.static_fields_size )
		        goto LABEL_13;
		      v14 = IFix::WrappersManagerImpl::GetPatch(734, 0LL);
		      if ( v14 )
		      {
		        v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_292(v14, &P0, FrameSettingsField__Enum_Postprocess, 0LL);
		        goto LABEL_14;
		      }
		LABEL_18:
		      sub_1800D8260(v3, wrapperArray);
		    }
		LABEL_37:
		    sub_1800D2AB0(v3, wrapperArray);
		  }
		LABEL_13:
		  v10 = (bitDatas.data1 & 0x8000) != 0LL;
		LABEL_14:
		  if ( v10 )
		  {
		    if ( !TypeInfo::UnityEngine::Rendering::CoreUtils->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::CoreUtils);
		    return 1;
		  }
		  return 0;
		}
		
		private static float GetEV100AtSlot(Vector2 exposureEv100Range, int slot) => default; // 0x0000000189B82680-0x0000000189B82704
		// Single GetEV100AtSlot(Vector2, Int32)
		float HG::Rendering::Runtime::UberPostPassUtils::GetEV100AtSlot(
		        Vector2 exposureEv100Range,
		        int32_t slot,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2872, 0LL) )
		    return (float)((float)((float)(exposureEv100Range.y - exposureEv100Range.x) * 0.0625) * (float)slot)
		         + exposureEv100Range.x;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2872, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v8, v7);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1052(Patch, exposureEv100Range, slot, 0LL);
		}
		
		private static float CalculateAverageLogLuminance(Vector2 exposureEv100Range, Vector2 exposureEv100HistogramRange, Vector2 pixelLuminanceRange, int threadGroupsX, int threadGroupsY) => default; // 0x0000000189B7ED7C-0x0000000189B7F024
		// Single CalculateAverageLogLuminance(Vector2, Vector2, Vector2, Int32, Int32)
		float HG::Rendering::Runtime::UberPostPassUtils::CalculateAverageLogLuminance(
		        Vector2 exposureEv100Range,
		        Vector2 exposureEv100HistogramRange,
		        Vector2 pixelLuminanceRange,
		        int32_t threadGroupsX,
		        int32_t threadGroupsY,
		        MethodInfo *method)
		{
		  struct UberPostPassUtils__Class *v10; // rdx
		  int v11; // esi
		  int v12; // r14d
		  int v13; // ebx
		  float v14; // xmm9_4
		  float v15; // xmm6_4
		  int v16; // edi
		  float i; // xmm7_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  int v19; // eax
		  int32_t v20; // edi
		  int v21; // esi
		  int v22; // ebp
		  float v23; // xmm7_4
		  float v24; // xmm11_4
		  float v25; // xmm12_4
		  float EV100AtSlot; // xmm0_4
		  float y; // xmm10_4
		  int v28; // ebx
		  float v29; // xmm6_4
		  int v30; // eax
		  float v31; // xmm0_4
		  float v32; // xmm1_4
		  float v33; // xmm0_4
		  float v34; // xmm0_4
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2873, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2873, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1053(
		               Patch,
		               exposureEv100Range,
		               exposureEv100HistogramRange,
		               pixelLuminanceRange,
		               threadGroupsX,
		               threadGroupsY,
		               0LL);
		LABEL_32:
		    sub_1800D8260(Patch, v10);
		  }
		  v10 = TypeInfo::HG::Rendering::Runtime::UberPostPassUtils;
		  v11 = 0;
		  v12 = 0;
		  v13 = threadGroupsY * threadGroupsX;
		  v14 = 0.0;
		  v15 = 0.0;
		  do
		  {
		    v16 = 0;
		    for ( i = 0.0; v16 < v13; i = i + *((float *)&Patch->fields.anonObj + v19) )
		    {
		      sub_1800036A0(v10);
		      v10 = TypeInfo::HG::Rendering::Runtime::UberPostPassUtils;
		      Patch = (ILFixDynamicMethodWrapper_2 *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->m_autoExposure_histogramRes;
		      if ( !Patch )
		        goto LABEL_32;
		      v19 = v12 + v16;
		      if ( (unsigned int)(v12 + v16) >= Patch->fields.methodId )
		LABEL_30:
		        sub_1800D2AB0(Patch, v10);
		      ++v16;
		    }
		    ++v11;
		    v15 = v15 + i;
		    v12 += v13;
		  }
		  while ( v11 < 16 );
		  v20 = 0;
		  v21 = 0;
		  v22 = threadGroupsY * threadGroupsX;
		  v23 = 0.0;
		  v24 = pixelLuminanceRange.x * v15;
		  v25 = pixelLuminanceRange.y * v15;
		  do
		  {
		    sub_1800036A0(v10);
		    EV100AtSlot = HG::Rendering::Runtime::UberPostPassUtils::GetEV100AtSlot(exposureEv100Range, v20, 0LL);
		    y = EV100AtSlot;
		    if ( exposureEv100HistogramRange.x <= EV100AtSlot )
		    {
		      if ( EV100AtSlot > exposureEv100HistogramRange.y )
		        y = exposureEv100HistogramRange.y;
		    }
		    else
		    {
		      y = exposureEv100HistogramRange.x;
		    }
		    v10 = TypeInfo::HG::Rendering::Runtime::UberPostPassUtils;
		    v28 = 0;
		    v29 = 0.0;
		    if ( v22 > 0 )
		    {
		      do
		      {
		        sub_1800036A0(v10);
		        v10 = TypeInfo::HG::Rendering::Runtime::UberPostPassUtils;
		        Patch = (ILFixDynamicMethodWrapper_2 *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->m_autoExposure_histogramRes;
		        if ( !Patch )
		          goto LABEL_32;
		        v30 = v21 + v28;
		        if ( (unsigned int)(v21 + v28) >= Patch->fields.methodId )
		          goto LABEL_30;
		        ++v28;
		        v29 = v29 + *((float *)&Patch->fields.anonObj + v30);
		      }
		      while ( v28 < v22 );
		      if ( v29 != 0.0 )
		      {
		        v31 = v29 + v23;
		        if ( v23 <= v24 )
		          v32 = v24;
		        else
		          v32 = v23;
		        if ( v25 <= v31 )
		          v31 = v25;
		        v33 = v31 - v32;
		        if ( v33 < 0.0 )
		          v33 = 0.0;
		        v23 = v23 + v29;
		        v14 = v14 + (float)((float)(v33 / v29) * (float)(y * v29));
		      }
		    }
		    ++v20;
		    v21 += v22;
		  }
		  while ( v20 < 16 );
		  v34 = 1.0;
		  if ( v23 >= 1.0 )
		    v34 = v23;
		  return v14 / v34;
		}
		
		internal static void PrepareAutoExposureDataFromEnvVolume(HGCamera hgCamera, HGAutoExposureConfig aeConfig, ref HGAutoExposureData data) {} // 0x0000000189B82AF8-0x0000000189B831B4
		// Void PrepareAutoExposureDataFromEnvVolume(HGCamera, HGAutoExposureConfig, UberPostPassUtils+HGAutoExposureData ByRef)
		void HG::Rendering::Runtime::UberPostPassUtils::PrepareAutoExposureDataFromEnvVolume(
		        HGCamera *hgCamera,
		        HGAutoExposureConfig *aeConfig,
		        UberPostPassUtils_HGAutoExposureData **data,
		        MethodInfo *method)
		{
		  float deltaTime; // xmm6_4
		  void *v8; // rdx
		  HGRuntimeGrassQuery_Node *v9; // r8
		  Int32__Array **v10; // r9
		  HGRuntimeGrassQuery_Node *static_fields; // rcx
		  Int32__Array **v12; // r9
		  HGRuntimeGrassQuery_Node *v13; // rdx
		  HGRuntimeGrassQuery_Node *v14; // r8
		  bool v15; // zf
		  UberPostPassUtils_HGAutoExposureData *v16; // rsi
		  HGRenderPipeline *currentPipeline; // rax
		  HGRenderPipelineRuntimeResources *defaultResources; // rax
		  HGRuntimeGrassQuery_Node *v19; // r8
		  Int32__Array **v20; // r9
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
		  UberPostPassUtils_HGAutoExposureData *v22; // rsi
		  int32_t Kernel; // eax
		  __int64 v24; // xmm0_8
		  ComputeShader *v25; // rsi
		  ComputeShader *v26; // rsi
		  UberPostPassUtils_HGAutoExposureData *v27; // rsi
		  UberPostPassUtils_HGAutoExposureData *v28; // rsi
		  struct UberPostPassUtils__Class *v29; // rcx
		  int32_t count; // eax
		  UberPostPassUtils_HGAutoExposureData *v31; // rax
		  int32_t threadGroupsX; // r12d
		  int32_t threadGroupsY; // esi
		  ComputeBuffer *v34; // rax
		  ComputeBuffer *v35; // r15
		  HGRuntimeGrassQuery_Node *v36; // rdx
		  HGRuntimeGrassQuery_Node *v37; // r8
		  Int32__Array **v38; // r9
		  __int64 v39; // rax
		  HGRuntimeGrassQuery_Node *v40; // rdx
		  HGRuntimeGrassQuery_Node *v41; // r8
		  Int32__Array **v42; // r9
		  UberPostPassUtils_HGAutoExposureData *v43; // rsi
		  HGRuntimeGrassQuery_Node *v44; // r8
		  Int32__Array **v45; // r9
		  UberPostPassUtils_HGAutoExposureData *v46; // rsi
		  bool IsActive; // al
		  HGRuntimeGrassQuery_Node *v48; // r8
		  Int32__Array **v49; // r9
		  __int64 v50; // xmm0_8
		  __m128i v51; // xmm2
		  __m128 v52; // xmm2
		  __int64 v53; // xmm1_8
		  __m128 v54; // xmm2
		  unsigned __int32 v55; // xmm0_4
		  __m128 v56; // xmm2
		  float y; // xmm0_4
		  __m128i v58; // xmm2
		  UberPostPassUtils_HGAutoExposureData *v59; // rbx
		  int v60; // eax
		  __int128 v61; // xmm1
		  __int128 v62; // xmm0
		  MethodInfo *v63; // [rsp+28h] [rbp-29h]
		  MethodInfo *v64; // [rsp+28h] [rbp-29h]
		  MethodInfo *v65; // [rsp+28h] [rbp-29h]
		  MethodInfo *v66; // [rsp+28h] [rbp-29h]
		  MethodInfo *v67; // [rsp+28h] [rbp-29h]
		  HGAutoExposureConfig v68; // [rsp+48h] [rbp-9h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2874, 0LL) )
		  {
		    deltaTime = UnityEngine::Time::get_deltaTime(0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		    static_fields = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields;
		    static_fields->fields.bounds.m_Extents.y = deltaTime;
		    if ( !hgCamera )
		      goto LABEL_53;
		    TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->m_currentExposure = hgCamera->fields.exposureAdaptation;
		    TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->m_targetExposure = hgCamera->fields.exposureTargetAdaptation;
		    TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->autoExposure_histogramBuffer = hgCamera->fields.autoExposureHistogramBuffer;
		    sub_18002D1B0(
		      (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields,
		      (HGRuntimeGrassQuery_Node *)v8,
		      v9,
		      v10,
		      v63);
		    v12 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils;
		    TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->m_autoExposure_histogramRes = hgCamera->fields.autoExposureHistogramRes;
		    sub_18002D1B0(
		      (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->m_autoExposure_histogramRes,
		      v13,
		      v14,
		      v12,
		      v64);
		    v15 = aeConfig->autoExposureMode == 0;
		    *(_QWORD *)&v68.autoExposureEvClampRange.y = *(_QWORD *)&aeConfig->autoExposureEvClampRange.y;
		    if ( !v15 )
		    {
		LABEL_36:
		      v46 = *data;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGAutoExposureConfig);
		      IsActive = HG::Rendering::Runtime::HGAutoExposureConfig::IsActive(aeConfig, 0LL);
		      if ( v46 )
		      {
		        v50 = *(_QWORD *)&aeConfig->autoExposureEvClampRange.y;
		        v51 = *(__m128i *)&aeConfig->autoExposureMode;
		        v46->fields.autoExposureActive = IsActive;
		        static_fields = (HGRuntimeGrassQuery_Node *)*data;
		        *(_QWORD *)&v68.autoExposureEvClampRange.y = v50;
		        if ( static_fields )
		        {
		          HIDWORD(static_fields->fields.right) = _mm_cvtsi128_si32(v51);
		          static_fields = (HGRuntimeGrassQuery_Node *)*data;
		          *(_QWORD *)&v68.autoExposureEvClampRange.y = v50;
		          v52 = *(__m128 *)&aeConfig->autoExposureEv100Range.x;
		          if ( static_fields )
		          {
		            LODWORD(static_fields->fields.grassInstanceBounds) = v52.m128_i32[0];
		            v53 = v50;
		            HIDWORD(static_fields->fields.grassInstanceBounds) = _mm_shuffle_ps(v52, v52, 85).m128_u32[0];
		            static_fields = (HGRuntimeGrassQuery_Node *)*data;
		            *(_QWORD *)&v68.autoExposureEvClampRange.y = v50;
		            v54 = *(__m128 *)&aeConfig->autoExposureEv100Range.x;
		            if ( static_fields )
		            {
		              *(_QWORD *)&v68.autoExposureEvClampRange.y = v50;
		              v55 = _mm_shuffle_ps(v54, v54, 170).m128_u32[0];
		              HIDWORD(static_fields[1].klass) = _mm_shuffle_ps(v54, v54, 255).m128_u32[0];
		              v56 = *(__m128 *)&aeConfig->autoExposureMeteringMode;
		              LODWORD(static_fields[1].klass) = v55;
		              static_fields = (HGRuntimeGrassQuery_Node *)*data;
		              if ( *data )
		              {
		                HIDWORD(static_fields[1].monitor) = _mm_shuffle_ps(v56, v56, 170).m128_u32[0];
		                LODWORD(static_fields[1].monitor) = _mm_shuffle_ps(v56, v56, 85).m128_u32[0];
		                if ( *data )
		                {
		                  (*data)->fields.centerPixelWeight = 0.75;
		                  static_fields = (HGRuntimeGrassQuery_Node *)*data;
		                  *(_QWORD *)&v68.autoExposureEvClampRange.y = v53;
		                  if ( static_fields )
		                  {
		                    static_fields[1].fields.bounds.m_Center.y = v68.autoExposureManualEvCompensationManual;
		                    static_fields = (HGRuntimeGrassQuery_Node *)*data;
		                    *(_QWORD *)&v68.autoExposureEvClampRange.y = v53;
		                    if ( static_fields )
		                    {
		                      static_fields[1].fields.bounds.m_Center.z = aeConfig->autoExposureManualEvCompensationAuto;
		                      static_fields = (HGRuntimeGrassQuery_Node *)*data;
		                      *(_QWORD *)&v68.autoExposureEvClampRange.y = v53;
		                      if ( static_fields )
		                      {
		                        y = v68.autoExposureEvClampRange.y;
		                        static_fields[1].fields.bounds.m_Extents.x = aeConfig->autoExposureEvClampRange.x;
		                        static_fields[1].fields.bounds.m_Extents.y = y;
		                        static_fields = (HGRuntimeGrassQuery_Node *)*data;
		                        if ( *data )
		                        {
		                          static_fields[1].fields.bounds.m_Extents.z = aeConfig->autoExposureLerpDownSpeed;
		                          static_fields = (HGRuntimeGrassQuery_Node *)*data;
		                          if ( *data )
		                          {
		                            *(float *)&static_fields[1].fields.parent = aeConfig->autoExposureLerpUpSpeed;
		                            if ( *data )
		                            {
		                              v58 = *(__m128i *)&aeConfig->autoExposureMeteringMode;
		                              (*data)->fields.curveEditModeEnabled = 0;
		                              static_fields = (HGRuntimeGrassQuery_Node *)*data;
		                              if ( *data )
		                              {
		                                LODWORD(static_fields[1].fields.left) = _mm_cvtsi128_si32(v58);
		                                static_fields = (HGRuntimeGrassQuery_Node *)*data;
		                                if ( *data )
		                                {
		                                  static_fields[2].klass = (HGRuntimeGrassQuery_Node__Class *)hgCamera;
		                                  sub_18002D1B0(static_fields + 2, (HGRuntimeGrassQuery_Node *)v8, v48, v49, v65);
		                                  v59 = *data;
		                                  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		                                  static_fields = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields;
		                                  if ( v59 )
		                                  {
		                                    v59->fields.deltaTime = static_fields->fields.bounds.m_Extents.y;
		                                    return;
		                                  }
		                                }
		                              }
		                            }
		                          }
		                        }
		                      }
		                    }
		                  }
		                }
		              }
		            }
		          }
		        }
		      }
		LABEL_53:
		      sub_1800D8260(static_fields, v8);
		    }
		    v16 = *data;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		    currentPipeline = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
		    if ( !currentPipeline )
		      goto LABEL_53;
		    defaultResources = HG::Rendering::Runtime::HGRenderPipeline::get_defaultResources(currentPipeline, 0LL);
		    if ( !defaultResources )
		      goto LABEL_53;
		    shaders = defaultResources->fields.shaders;
		    if ( !shaders )
		      goto LABEL_53;
		    static_fields = (HGRuntimeGrassQuery_Node *)shaders->fields.hgAutoExposureHistogramCS;
		    if ( !v16 )
		      goto LABEL_53;
		    v16->fields.autoExposureHistogramCS = (ComputeShader *)static_fields;
		    sub_18002D1B0(
		      (HGRuntimeGrassQuery_Node *)&v16->fields.autoExposureHistogramCS,
		      (HGRuntimeGrassQuery_Node *)v8,
		      v19,
		      v20,
		      v65);
		    v22 = *data;
		    if ( !*data )
		      goto LABEL_53;
		    static_fields = (HGRuntimeGrassQuery_Node *)v22->fields.autoExposureHistogramCS;
		    if ( !static_fields )
		      goto LABEL_53;
		    Kernel = UnityEngine::ComputeShader::FindKernel(
		               (ComputeShader *)static_fields,
		               (String *)"HGLuminanceHistogramCS",
		               0LL);
		    v15 = aeConfig->autoExposureMeteringMode == 1;
		    v24 = *(_QWORD *)&aeConfig->autoExposureEvClampRange.y;
		    v22->fields.histogramKernel = Kernel;
		    static_fields = (HGRuntimeGrassQuery_Node *)*data;
		    *(_QWORD *)&v68.autoExposureEvClampRange.y = v24;
		    if ( v15 )
		    {
		      if ( !static_fields )
		        goto LABEL_53;
		      v26 = *(ComputeShader **)&static_fields->fields.bounds.m_Extents.y;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		      v8 = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields;
		      if ( !v26 )
		        goto LABEL_53;
		      UnityEngine::ComputeShader::EnableKeyword(v26, *((String **)v8 + 45), 0LL);
		    }
		    else
		    {
		      if ( !static_fields )
		        goto LABEL_53;
		      v25 = *(ComputeShader **)&static_fields->fields.bounds.m_Extents.y;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		      v8 = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields;
		      if ( !v25 )
		        goto LABEL_53;
		      UnityEngine::ComputeShader::DisableKeyword(v25, *((String **)v8 + 45), 0LL);
		    }
		    static_fields = (HGRuntimeGrassQuery_Node *)*data;
		    if ( !*data )
		      goto LABEL_53;
		    HIDWORD(static_fields[1].fields.left) = hgCamera->fields._taauRTSize_k__BackingField;
		    static_fields = (HGRuntimeGrassQuery_Node *)*data;
		    if ( !*data )
		      goto LABEL_53;
		    LODWORD(static_fields[1].fields.right) = HIDWORD(*(_QWORD *)&hgCamera->fields._taauRTSize_k__BackingField);
		    if ( !*data )
		      goto LABEL_53;
		    v27 = *data;
		    v27->fields.threadGroupsX = sub_1832DBD50();
		    if ( !*data )
		      goto LABEL_53;
		    v28 = *data;
		    v28->fields.threadGroupsY = sub_1832DBD50();
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		    v29 = TypeInfo::HG::Rendering::Runtime::UberPostPassUtils;
		    if ( TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->autoExposure_histogramBuffer )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		      static_fields = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->autoExposure_histogramBuffer;
		      if ( !static_fields )
		        goto LABEL_53;
		      if ( UnityEngine::ComputeBuffer::IsValid((ComputeBuffer *)static_fields, 0LL) )
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		        static_fields = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->autoExposure_histogramBuffer;
		        if ( !static_fields )
		          goto LABEL_53;
		        count = UnityEngine::ComputeBuffer::get_count((ComputeBuffer *)static_fields, 0LL);
		        v8 = *data;
		        if ( !*data )
		          goto LABEL_53;
		        if ( count == 16 * (*data)->fields.threadGroupsY * *((_DWORD *)v8 + 33) )
		        {
		LABEL_34:
		          v43 = *data;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		          static_fields = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields;
		          if ( !v43 )
		            goto LABEL_53;
		          v43->fields.histogramBuffer = (ComputeBuffer *)static_fields->klass;
		          sub_18002D1B0(
		            (HGRuntimeGrassQuery_Node *)&v43->fields.histogramBuffer,
		            (HGRuntimeGrassQuery_Node *)v8,
		            v44,
		            v45,
		            v66);
		          goto LABEL_36;
		        }
		      }
		      v29 = TypeInfo::HG::Rendering::Runtime::UberPostPassUtils;
		    }
		    sub_1800036A0(v29);
		    static_fields = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->autoExposure_histogramBuffer;
		    if ( static_fields )
		      UnityEngine::ComputeBuffer::Dispose((ComputeBuffer *)static_fields, 0LL);
		    v31 = *data;
		    if ( !*data )
		      goto LABEL_53;
		    threadGroupsX = v31->fields.threadGroupsX;
		    threadGroupsY = v31->fields.threadGroupsY;
		    v34 = (ComputeBuffer *)sub_18002C620(TypeInfo::UnityEngine::ComputeBuffer);
		    v35 = v34;
		    if ( !v34 )
		      goto LABEL_53;
		    UnityEngine::ComputeBuffer::ComputeBuffer(v34, 16 * threadGroupsX * threadGroupsY, 4, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		    TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->autoExposure_histogramBuffer = v35;
		    sub_18002D1B0(
		      (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields,
		      v36,
		      v37,
		      v38,
		      v66);
		    static_fields = (HGRuntimeGrassQuery_Node *)*data;
		    if ( !*data )
		      goto LABEL_53;
		    v39 = il2cpp_array_new_specific_1(
		            TypeInfo::System::Single,
		            (unsigned int)(16
		                         * LODWORD(static_fields[1].fields.grassInstanceBounds)
		                         * HIDWORD(static_fields[1].fields.right)));
		    v40 = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields;
		    v40->monitor = (MonitorData *)v39;
		    sub_18002D1B0(
		      (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->m_autoExposure_histogramRes,
		      v40,
		      v41,
		      v42,
		      v67);
		    goto LABEL_34;
		  }
		  static_fields = (HGRuntimeGrassQuery_Node *)IFix::WrappersManagerImpl::GetPatch(2874, 0LL);
		  if ( !static_fields )
		    goto LABEL_53;
		  v60 = *(_DWORD *)&aeConfig->m_active;
		  v61 = *(_OWORD *)&aeConfig->autoExposureEv100Range.x;
		  *(_OWORD *)&v68.autoExposureMode = *(_OWORD *)&aeConfig->autoExposureMode;
		  v62 = *(_OWORD *)&aeConfig->autoExposureMeteringMode;
		  *(_DWORD *)&v68.m_active = v60;
		  *(_OWORD *)&v68.autoExposureEv100Range.x = v61;
		  *(_QWORD *)&v61 = *(_QWORD *)&aeConfig->autoExposureEvClampRange.y;
		  *(_OWORD *)&v68.autoExposureMeteringMode = v62;
		  *(_QWORD *)&v68.autoExposureEvClampRange.y = v61;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1054(
		    (ILFixDynamicMethodWrapper_2 *)static_fields,
		    (Object *)hgCamera,
		    &v68,
		    data,
		    0LL);
		}
		
		internal static void AutoExposureUpdateData(ref HGAutoExposureData data) {} // 0x0000000189B7E3F8-0x0000000189B7E8B0
		// Void AutoExposureUpdateData(UberPostPassUtils+HGAutoExposureData ByRef)
		void HG::Rendering::Runtime::UberPostPassUtils::AutoExposureUpdateData(
		        UberPostPassUtils_HGAutoExposureData **data,
		        MethodInfo *method)
		{
		  float v2; // xmm3_4
		  char *v4; // rdx
		  float *v5; // rcx
		  UberPostPassUtils_HGAutoExposureData *v6; // rax
		  UberPostPassUtils__StaticFields *static_fields; // rax
		  float v8; // xmm6_4
		  double v9; // xmm0_8
		  float v10; // xmm6_4
		  struct UberPostPassUtils__Class *v11; // rcx
		  ComputeBuffer *histogramBuffer; // rsi
		  Action_1_UnityEngine_Rendering_AsyncGPUReadbackRequest_ *_9__23_0; // rbx
		  Object *v14; // rbp
		  GenericDelegateCallerGen_FStructSize56_voidDelegate_1_Unity_Collections_NativeArray_1_System_Int32_ *v15; // rax
		  HGRuntimeGrassQuery_Node *v16; // rdx
		  HGRuntimeGrassQuery_Node *v17; // r8
		  Int32__Array **v18; // r9
		  unsigned int *v19; // rax
		  __m128 v20; // xmm6
		  __m128 v21; // xmm7
		  __m128 v22; // xmm9
		  __m128 v23; // xmm10
		  __m128 v24; // xmm11
		  __m128 v25; // xmm12
		  float v26; // xmm13_4
		  int32_t v27; // esi
		  int32_t threadGroupsY; // ebx
		  struct UberPostPassUtils__Class *v29; // rbx
		  float m_targetExposure; // xmm6_4
		  double v31; // xmm0_8
		  float v32; // xmm7_4
		  double v33; // xmm0_8
		  UberPostPassUtils_HGAutoExposureData *v34; // rax
		  UberPostPassUtils__StaticFields *v35; // rax
		  float m_currentExposure; // xmm0_4
		  Beyond::JobMathf *v37; // rcx
		  HGCamera *hgCamera; // rbx
		  HGRuntimeGrassQuery_Node *v39; // r8
		  Int32__Array **v40; // r9
		  HGRuntimeGrassQuery_Node *v41; // r8
		  Int32__Array **v42; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *threadGroupsX; // [rsp+20h] [rbp-A8h]
		  MethodInfo *threadGroupsXa; // [rsp+20h] [rbp-A8h]
		  AsyncGPUReadbackRequest v46; // [rsp+40h] [rbp-88h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2875, 0LL) )
		  {
		    v6 = *data;
		    if ( !*data )
		      goto LABEL_36;
		    if ( !v6->fields.autoExposureActive )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		      TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->m_targetExposure = 1.0;
		      v5 = (float *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils;
		      static_fields = TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields;
		      v8 = static_fields->m_autoExposure_deltaTime * 0.60000002;
		      if ( static_fields->m_targetExposure > static_fields->m_currentExposure )
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		        v5 = (float *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils;
		        v8 = TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->m_autoExposure_deltaTime * 0.40000001;
		      }
		LABEL_26:
		      sub_1800036A0(v5);
		      v35 = TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields;
		      m_currentExposure = v35->m_currentExposure;
		      *(float *)(Beyond::JobMathf::ClampedLerp(v37, v35->m_targetExposure, v8, v2) + 16) = m_currentExposure;
		      if ( *data )
		      {
		        hgCamera = (*data)->fields.hgCamera;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		        v5 = (float *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields;
		        if ( hgCamera )
		        {
		          hgCamera->fields.exposureTargetAdaptation = v5[5];
		          if ( *data )
		          {
		            v4 = (char *)(*data)->fields.hgCamera;
		            v5 = (float *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields;
		            if ( v4 )
		            {
		              *((float *)v4 + 434) = v5[4];
		              v4 = (char *)*data;
		              if ( *data )
		              {
		                v4 = (char *)*((_QWORD *)v4 + 18);
		                v5 = (float *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields;
		                if ( v4 )
		                {
		                  *((_QWORD *)v4 + 214) = *(_QWORD *)v5;
		                  sub_18002D1B0(
		                    (HGRuntimeGrassQuery_Node *)(v4 + 1712),
		                    (HGRuntimeGrassQuery_Node *)v4,
		                    v39,
		                    v40,
		                    threadGroupsX);
		                  v4 = (char *)*data;
		                  if ( *data )
		                  {
		                    v4 = (char *)*((_QWORD *)v4 + 18);
		                    v5 = (float *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields;
		                    if ( v4 )
		                    {
		                      *((_QWORD *)v4 + 215) = *((_QWORD *)v5 + 1);
		                      sub_18002D1B0(
		                        (HGRuntimeGrassQuery_Node *)(v4 + 1720),
		                        (HGRuntimeGrassQuery_Node *)v4,
		                        v41,
		                        v42,
		                        threadGroupsXa);
		                      return;
		                    }
		                  }
		                }
		              }
		            }
		          }
		        }
		      }
		      goto LABEL_36;
		    }
		    if ( !v6 )
		      goto LABEL_36;
		    if ( v6->fields.autoExposureMode )
		    {
		      v9 = sub_1803369A0();
		      v10 = *(float *)&v9;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		      TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->m_targetExposure = v10;
		    }
		    else
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		      v11 = TypeInfo::HG::Rendering::Runtime::UberPostPassUtils;
		      if ( !TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->m_autoExposureReadyForNextFetch )
		        goto LABEL_17;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		      v5 = (float *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields;
		      *((_BYTE *)v5 + 36) = 0;
		      if ( !*data )
		        goto LABEL_36;
		      histogramBuffer = (*data)->fields.histogramBuffer;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils::__c);
		      _9__23_0 = TypeInfo::HG::Rendering::Runtime::UberPostPassUtils::__c->static_fields->__9__23_0;
		      if ( !_9__23_0 )
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils::__c);
		        v14 = (Object *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils::__c->static_fields->__9;
		        v15 = (GenericDelegateCallerGen_FStructSize56_voidDelegate_1_Unity_Collections_NativeArray_1_System_Int32_ *)sub_18002C620(TypeInfo::System::Action<UnityEngine::Rendering::AsyncGPUReadbackRequest>);
		        _9__23_0 = (Action_1_UnityEngine_Rendering_AsyncGPUReadbackRequest_ *)v15;
		        if ( !v15 )
		          goto LABEL_36;
		        Beyond::Reflection::GenericDelegateCallerGen::FStructSize56_voidDelegate<Unity::Collections::NativeArray<int>>::FStructSize56_voidDelegate(
		          v15,
		          v14,
		          MethodInfo::HG::Rendering::Runtime::UberPostPassUtils::__c::_AutoExposureUpdateData_b__23_0,
		          0LL);
		        TypeInfo::HG::Rendering::Runtime::UberPostPassUtils::__c->static_fields->__9__23_0 = _9__23_0;
		        sub_18002D1B0(
		          (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::UberPostPassUtils::__c->static_fields->__9__23_0,
		          v16,
		          v17,
		          v18,
		          threadGroupsX);
		      }
		      UnityEngine::Rendering::AsyncGPUReadback::Request(&v46, histogramBuffer, _9__23_0, 0LL);
		      v19 = (unsigned int *)*data;
		      if ( !*data )
		LABEL_36:
		        sub_1800D8260(v5, v4);
		      v20 = (__m128)v19[16];
		      v21 = (__m128)v19[17];
		      v22 = (__m128)v19[18];
		      v23 = (__m128)v19[19];
		      v24 = (__m128)v19[20];
		      v25 = (__m128)v19[21];
		      v26 = *((float *)v19 + 24);
		      v27 = v19[33];
		      threadGroupsY = v19[34];
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		      v2 = v26;
		      HG::Rendering::Runtime::UberPostPassUtils::CalculateTargetExposure(
		        (Vector2)*(_OWORD *)&_mm_unpacklo_ps(v20, v21),
		        (Vector2)*(_OWORD *)&_mm_unpacklo_ps(v22, v23),
		        (Vector2)*(_OWORD *)&_mm_unpacklo_ps(v24, v25),
		        v26,
		        v27,
		        threadGroupsY,
		        0LL);
		    }
		    v11 = TypeInfo::HG::Rendering::Runtime::UberPostPassUtils;
		LABEL_17:
		    sub_1800036A0(v11);
		    v29 = TypeInfo::HG::Rendering::Runtime::UberPostPassUtils;
		    m_targetExposure = TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->m_targetExposure;
		    if ( !*data )
		      goto LABEL_36;
		    v31 = sub_1803369A0();
		    v32 = *(float *)&v31;
		    v33 = sub_1803369A0();
		    if ( v32 > m_targetExposure )
		    {
		      m_targetExposure = v32;
		    }
		    else if ( m_targetExposure > *(float *)&v33 )
		    {
		      m_targetExposure = *(float *)&v33;
		    }
		    v29->static_fields->m_targetExposure = m_targetExposure;
		    v34 = *data;
		    if ( !*data )
		      goto LABEL_36;
		    v5 = (float *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils;
		    v8 = v34->fields.lerpDownSpeed * v34->fields.deltaTime;
		    v4 = (char *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields;
		    if ( *((float *)v4 + 5) > *((float *)v4 + 4) )
		    {
		      if ( !v34 )
		        goto LABEL_36;
		      v8 = v34->fields.lerpUpSpeed * v34->fields.deltaTime;
		    }
		    goto LABEL_26;
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2875, 0LL);
		  if ( !Patch )
		    goto LABEL_36;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1057(Patch, data, 0LL);
		}
		
		internal static void ExecuteAutoExposure(HGRenderGraph renderGraph, TextureHandle inputTex, HGCamera hgCamera) {} // 0x0000000189B80628-0x0000000189B80C10
		// Void ExecuteAutoExposure(HGRenderGraph, TextureHandle, HGCamera)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::UberPostPassUtils::ExecuteAutoExposure(
		        HGRenderGraph *renderGraph,
		        TextureHandle *inputTex,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  HGEnvironmentPhase *InterpolatedPhase; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  __int128 v10; // xmm7
		  __int128 v11; // xmm8
		  __int128 v12; // xmm9
		  __int64 v13; // xmm6_8
		  int v14; // ebx
		  __int64 v15; // rdx
		  UberPostPassUtils__StaticFields *static_fields; // rcx
		  UberPostPassUtils_HGAutoExposureData *s_cachedAutoExposureData; // rbx
		  __int64 v18; // rdx
		  UberPostPassUtils__StaticFields *v19; // rcx
		  UberPostPassUtils_HGAutoExposureData *v20; // rbx
		  ProfilingSampler *v21; // rax
		  __int64 v22; // rdx
		  __int64 v23; // rcx
		  Object *v24; // rbx
		  __int64 v25; // rdx
		  UberPostPassUtils__StaticFields *v26; // rcx
		  UberPostPassUtils_HGAutoExposureData *v27; // rax
		  Object__Class *autoExposureHistogramCS; // rcx
		  int v29; // r8d
		  unsigned __int64 v30; // r9
		  signed __int64 v31; // rtt
		  Object *v32; // r9
		  UberPostPassUtils__StaticFields *v33; // rcx
		  UberPostPassUtils_HGAutoExposureData *v34; // rax
		  Object__Class *histogramBuffer; // rcx
		  char v36; // r8
		  unsigned __int64 v37; // r9
		  char v38; // r8
		  signed __int64 v39; // rtt
		  UberPostPassUtils__StaticFields *v40; // rcx
		  UberPostPassUtils_HGAutoExposureData *v41; // rax
		  __int64 histogramKernel; // rcx
		  UberPostPassUtils__StaticFields *v43; // rcx
		  UberPostPassUtils_HGAutoExposureData *v44; // rax
		  __int64 textureSizeX; // rcx
		  UberPostPassUtils__StaticFields *v46; // rcx
		  UberPostPassUtils_HGAutoExposureData *v47; // rax
		  __int64 textureSizeY; // rcx
		  UberPostPassUtils__StaticFields *v49; // rcx
		  UberPostPassUtils_HGAutoExposureData *v50; // rax
		  __int64 threadGroupsX; // rcx
		  UberPostPassUtils__StaticFields *v52; // rcx
		  UberPostPassUtils_HGAutoExposureData *v53; // rax
		  __int64 threadGroupsY; // rcx
		  UberPostPassUtils__StaticFields *v55; // rcx
		  UberPostPassUtils_HGAutoExposureData *v56; // rax
		  float x; // xmm0_4
		  float y; // xmm1_4
		  Object *v59; // rax
		  UberPostPassUtils__StaticFields *v60; // rcx
		  UberPostPassUtils_HGAutoExposureData *v61; // rax
		  Object *v62; // rbx
		  __int64 v63; // rdx
		  __int64 v64; // rcx
		  TextureHandle v65; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v67; // rdx
		  __int64 v68; // rcx
		  Object *v69; // [rsp+40h] [rbp-D8h] BYREF
		  HGAutoExposureConfig v70; // [rsp+50h] [rbp-C8h] BYREF
		  HGRenderGraphBuilder v71; // [rsp+90h] [rbp-88h] BYREF
		  TextureHandle v72; // [rsp+B0h] [rbp-68h] BYREF
		  Il2CppExceptionWrapper *v73; // [rsp+C0h] [rbp-58h] BYREF
		
		  memset(&v71, 0, sizeof(v71));
		  v69 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(2892, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2892, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v68, v67);
		    *(TextureHandle *)&v70.autoExposureMode = *inputTex;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_472(
		      Patch,
		      (Object *)renderGraph,
		      (TextureHandle *)&v70,
		      (Object *)hgCamera,
		      0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		    InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(hgCamera, 0LL);
		    if ( !InterpolatedPhase )
		      sub_1800D8260(v9, v8);
		    v10 = *(_OWORD *)&InterpolatedPhase->fields.autoExposureConfig.autoExposureMode;
		    v11 = *(_OWORD *)&InterpolatedPhase->fields.autoExposureConfig.autoExposureEv100Range.x;
		    v12 = *(_OWORD *)&InterpolatedPhase->fields.autoExposureConfig.autoExposureMeteringMode;
		    v13 = *(_QWORD *)&InterpolatedPhase->fields.autoExposureConfig.autoExposureEvClampRange.y;
		    v14 = *(_DWORD *)&InterpolatedPhase->fields.autoExposureConfig.m_active;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		    *(_OWORD *)&v70.autoExposureMode = v10;
		    *(_OWORD *)&v70.autoExposureEv100Range.x = v11;
		    *(_OWORD *)&v70.autoExposureMeteringMode = v12;
		    *(_QWORD *)&v70.autoExposureEvClampRange.y = v13;
		    *(_DWORD *)&v70.m_active = v14;
		    HG::Rendering::Runtime::UberPostPassUtils::PrepareAutoExposureDataFromEnvVolume(
		      hgCamera,
		      &v70,
		      &TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->s_cachedAutoExposureData,
		      0LL);
		    static_fields = TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields;
		    s_cachedAutoExposureData = static_fields->s_cachedAutoExposureData;
		    if ( !s_cachedAutoExposureData )
		      sub_1800D8260(static_fields, v15);
		    if ( s_cachedAutoExposureData->fields.autoExposureActive )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		      v19 = TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields;
		      v20 = v19->s_cachedAutoExposureData;
		      if ( !v20 )
		        sub_1800D8260(v19, v18);
		      if ( !v20->fields.autoExposureMode )
		      {
		        v21 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		                (Int32Enum__Enum)0x98u,
		                MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		        if ( !renderGraph )
		          sub_1800D8260(v23, v22);
		        HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		          (HGRenderGraphBuilder *)&v70,
		          renderGraph,
		          (String *)"Auto Exposure",
		          &v69,
		          v21,
		          1,
		          ProfilingHGPass__Enum_None,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::UberPostPassUtils::HGAutoExposurePassData>);
		        *(_OWORD *)&v71.m_RenderPass = *(_OWORD *)&v70.autoExposureMode;
		        *(_OWORD *)&v71.m_RenderGraph = *(_OWORD *)&v70.autoExposureEv100Range.x;
		        *(_QWORD *)&v70.autoExposureMode = 0LL;
		        *(_QWORD *)&v70.autoExposureLerpUpSpeed = &v71;
		        try
		        {
		          v24 = v69;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		          v26 = TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields;
		          v27 = v26->s_cachedAutoExposureData;
		          if ( !v27 )
		            sub_1800D8250(v26, v25);
		          autoExposureHistogramCS = (Object__Class *)v27->fields.autoExposureHistogramCS;
		          if ( !v24 )
		            sub_1800D8250(autoExposureHistogramCS, v25);
		          v24[2].klass = autoExposureHistogramCS;
		          v29 = dword_18F35FD08;
		          if ( dword_18F35FD08 )
		          {
		            v30 = (((unsigned __int64)&v24[2] >> 12) & 0x1FFFFF) >> 6;
		            _m_prefetchw(&qword_18F0BCBA0[v30 + 36190]);
		            do
		              v31 = qword_18F0BCBA0[v30 + 36190];
		            while ( v31 != _InterlockedCompareExchange64(
		                             &qword_18F0BCBA0[v30 + 36190],
		                             v31 | (1LL << (((unsigned __int64)&v24[2] >> 12) & 0x3F)),
		                             v31) );
		            v29 = dword_18F35FD08;
		          }
		          v32 = v69;
		          v33 = TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields;
		          v34 = v33->s_cachedAutoExposureData;
		          if ( !v34 )
		            sub_1800D8250(v33, qword_18F0BCBA0);
		          histogramBuffer = (Object__Class *)v34->fields.histogramBuffer;
		          if ( !v69 )
		            sub_1800D8250(histogramBuffer, qword_18F0BCBA0);
		          v69[3].klass = histogramBuffer;
		          if ( v29 )
		          {
		            v36 = (unsigned __int64)&v32[3] >> 12;
		            v37 = (((unsigned __int64)&v32[3] >> 12) & 0x1FFFFF) >> 6;
		            v38 = v36 & 0x3F;
		            _m_prefetchw(&qword_18F0BCBA0[v37 + 36190]);
		            do
		              v39 = qword_18F0BCBA0[v37 + 36190];
		            while ( v39 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v37 + 36190], v39 | (1LL << v38), v39) );
		          }
		          v40 = TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields;
		          v41 = v40->s_cachedAutoExposureData;
		          if ( !v41 )
		            sub_1800D8250(v40, qword_18F0BCBA0);
		          histogramKernel = (unsigned int)v41->fields.histogramKernel;
		          if ( !v69 )
		            sub_1800D8250(histogramKernel, qword_18F0BCBA0);
		          LODWORD(v69[2].monitor) = histogramKernel;
		          v43 = TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields;
		          v44 = v43->s_cachedAutoExposureData;
		          if ( !v44 )
		            sub_1800D8250(v43, qword_18F0BCBA0);
		          textureSizeX = (unsigned int)v44->fields.textureSizeX;
		          if ( !v69 )
		            sub_1800D8250(textureSizeX, qword_18F0BCBA0);
		          LODWORD(v69[3].monitor) = textureSizeX;
		          v46 = TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields;
		          v47 = v46->s_cachedAutoExposureData;
		          if ( !v47 )
		            sub_1800D8250(v46, qword_18F0BCBA0);
		          textureSizeY = (unsigned int)v47->fields.textureSizeY;
		          if ( !v69 )
		            sub_1800D8250(textureSizeY, qword_18F0BCBA0);
		          HIDWORD(v69[3].monitor) = textureSizeY;
		          v49 = TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields;
		          v50 = v49->s_cachedAutoExposureData;
		          if ( !v50 )
		            sub_1800D8250(v49, qword_18F0BCBA0);
		          threadGroupsX = (unsigned int)v50->fields.threadGroupsX;
		          if ( !v69 )
		            sub_1800D8250(threadGroupsX, qword_18F0BCBA0);
		          LODWORD(v69[4].klass) = threadGroupsX;
		          v52 = TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields;
		          v53 = v52->s_cachedAutoExposureData;
		          if ( !v53 )
		            sub_1800D8250(v52, qword_18F0BCBA0);
		          threadGroupsY = (unsigned int)v53->fields.threadGroupsY;
		          if ( !v69 )
		            sub_1800D8250(threadGroupsY, qword_18F0BCBA0);
		          HIDWORD(v69[4].klass) = threadGroupsY;
		          v55 = TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields;
		          v56 = v55->s_cachedAutoExposureData;
		          if ( !v56 )
		            sub_1800D8250(v55, qword_18F0BCBA0);
		          x = v56->fields.exposureEv100Range.x;
		          y = v56->fields.exposureEv100Range.y;
		          v59 = v69;
		          if ( !v69 )
		            sub_1800D8250(v55, qword_18F0BCBA0);
		          *(float *)&v69[4].monitor = x;
		          *((float *)&v59[4].monitor + 1) = y;
		          v60 = TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields;
		          v61 = v60->s_cachedAutoExposureData;
		          if ( !v61 )
		            sub_1800D8250(v60, qword_18F0BCBA0);
		          if ( !v69 )
		            sub_1800D8250(v60, qword_18F0BCBA0);
		          *(float *)&v69[5].klass = v61->fields.centerPixelWeight;
		          v62 = v69;
		          v65 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v72, &v71, inputTex, 0LL);
		          if ( !v62 )
		            sub_1800D8250(v64, v63);
		          v62[1] = (Object)v65;
		          HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		            &v71,
		            (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->s_autoExposureCSRenderFunc,
		            0LL,
		            0,
		            MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::UberPostPassUtils::HGAutoExposurePassData>);
		        }
		        catch ( Il2CppExceptionWrapper *v73 )
		        {
		          *(Il2CppExceptionWrapper *)&v70.autoExposureMode = (Il2CppExceptionWrapper)v73->ex;
		        }
		        sub_180268AE0(&v70);
		      }
		    }
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		    HG::Rendering::Runtime::UberPostPassUtils::AutoExposureUpdateData(
		      &TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->s_cachedAutoExposureData,
		      0LL);
		  }
		}
		
		private static void CalculateTargetExposure(Vector2 exposureEv100Range, Vector2 exposureEv100HistogramRange, Vector2 pixelLuminanceRange, float evCompensationAuto, int threadGroupsX, int threadGroupsY) {} // 0x0000000189B7F024-0x0000000189B7F19C
		// Void CalculateTargetExposure(Vector2, Vector2, Vector2, Single, Int32, Int32)
		void HG::Rendering::Runtime::UberPostPassUtils::CalculateTargetExposure(
		        Vector2 exposureEv100Range,
		        Vector2 exposureEv100HistogramRange,
		        Vector2 pixelLuminanceRange,
		        float evCompensationAuto,
		        int32_t threadGroupsX,
		        int32_t threadGroupsY,
		        MethodInfo *method)
		{
		  double v10; // xmm0_8
		  float v11; // xmm6_4
		  int v12; // xmm0_4
		  double v13; // xmm0_8
		  __int64 v14; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2891, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2891, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v14);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1056(
		      Patch,
		      exposureEv100Range,
		      exposureEv100HistogramRange,
		      pixelLuminanceRange,
		      evCompensationAuto,
		      threadGroupsX,
		      threadGroupsY,
		      0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		    HG::Rendering::Runtime::UberPostPassUtils::CalculateAverageLogLuminance(
		      exposureEv100Range,
		      exposureEv100HistogramRange,
		      pixelLuminanceRange,
		      threadGroupsX,
		      threadGroupsY,
		      0LL);
		    v10 = sub_1803369A0();
		    v11 = *(float *)&v10;
		    v12 = 1008981770;
		    if ( v11 < 0.0099999998 || (v12 = 1090519040, v11 > 8.0) )
		      v11 = *(float *)&v12;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		    v13 = sub_1803369A0();
		    TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->m_targetExposure = *(float *)&v13
		                                                                                         * (float)(0.18000001 / v11);
		  }
		}
		
		internal static Vector4 GetBloomThresholdParams(Bloom bloom) => default; // 0x0000000189B82480-0x0000000189B82534
		// Vector4 GetBloomThresholdParams(Bloom)
		Vector4 *HG::Rendering::Runtime::UberPostPassUtils::GetBloomThresholdParams(
		        Vector4 *__return_ptr retstr,
		        Bloom *bloom,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  float threshold; // xmm0_4
		  float v8; // xmm0_4
		  float v9; // xmm2_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 v12; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2893, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2893, 0LL);
		    if ( Patch )
		    {
		      *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_350(&v12, Patch, (Object *)bloom, 0LL);
		      return retstr;
		    }
		LABEL_5:
		    sub_1800D8260(v6, v5);
		  }
		  if ( !bloom )
		    goto LABEL_5;
		  threshold = HG::Rendering::Runtime::Bloom::get_threshold(bloom, 0LL);
		  v8 = UnityEngine::Mathf::GammaToLinearSpace(threshold, 0LL);
		  retstr->x = v8;
		  v9 = (float)(v8 * 0.5) + 0.0000099999997;
		  retstr->y = v8 - v9;
		  retstr->w = 0.25 / v9;
		  retstr->z = v9 + v9;
		  return retstr;
		}
		
		internal static Vector4 GetBloomCharacterThresholdParams(Bloom bloom) => default; // 0x0000000189B82328-0x0000000189B82404
		// Vector4 GetBloomCharacterThresholdParams(Bloom)
		Vector4 *HG::Rendering::Runtime::UberPostPassUtils::GetBloomCharacterThresholdParams(
		        Vector4 *__return_ptr retstr,
		        Bloom *bloom,
		        MethodInfo *method)
		{
		  void *characterThreshold; // rdx
		  __int64 v6; // rcx
		  double v7; // xmm0_8
		  float v8; // xmm6_4
		  double v9; // xmm0_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 v12; // [rsp+20h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2894, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2894, 0LL);
		    if ( Patch )
		    {
		      *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_350(&v12, Patch, (Object *)bloom, 0LL);
		      return retstr;
		    }
		LABEL_7:
		    sub_1800D8260(v6, characterThreshold);
		  }
		  if ( !bloom )
		    goto LABEL_7;
		  characterThreshold = bloom->fields.characterThreshold;
		  if ( !characterThreshold )
		    goto LABEL_7;
		  v7 = sub_1800057D0(10LL, characterThreshold);
		  *(float *)&v7 = UnityEngine::Mathf::GammaToLinearSpace(*(float *)&v7, 0LL);
		  characterThreshold = bloom->fields.characterSoftness;
		  v8 = *(float *)&v7;
		  if ( !characterThreshold )
		    goto LABEL_7;
		  v9 = sub_1800057D0(10LL, characterThreshold);
		  retstr->x = v8;
		  *(float *)&v9 = (float)(*(float *)&v9 * v8) + 0.0000099999997;
		  retstr->w = 0.25 / *(float *)&v9;
		  retstr->y = v8 - *(float *)&v9;
		  retstr->z = *(float *)&v9 + *(float *)&v9;
		  return retstr;
		}
		
		internal static void PrepareUberBloomParameters(HGSettingParameters settingParams, PPBloomData data, Bloom bloom, Vector4 bloomBicubicParams, HGCamera camera, Material ppMaterial) {} // 0x0000000189B86940-0x0000000189B86D80
		// Void PrepareUberBloomParameters(HGSettingParameters, UberPostPassUtils+PPBloomData, Bloom, Vector4, HGCamera, Material)
		void HG::Rendering::Runtime::UberPostPassUtils::PrepareUberBloomParameters(
		        HGSettingParameters *settingParams,
		        UberPostPassUtils_PPBloomData *data,
		        Bloom *bloom,
		        Vector4 *bloomBicubicParams,
		        HGCamera *camera,
		        Material *ppMaterial,
		        MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *dirtTexture; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  double v13; // xmm0_8
		  ColorParameter *tint; // r8
		  float v15; // xmm8_4
		  float v16; // xmm9_4
		  __m128 v17; // xmm6
		  MethodInfo *v18; // rdx
		  MethodInfo *v19; // r9
		  float v20; // xmm3_4
		  Vector4 *one; // rax
		  __m128i v22; // xmm11
		  Object_1 *v23; // rbx
		  Texture2D *blackTexture; // rax
		  Texture *v25; // rbx
		  bool dirtEnabled; // r14
		  float v27; // xmm7_4
		  float v28; // xmm7_4
		  float m_X; // xmm6_4
		  float v30; // xmm0_4
		  float v31; // xmm6_4
		  HGRuntimeGrassQuery_Node *v32; // r8
		  Int32__Array **v33; // r9
		  double v34; // xmm0_8
		  MethodInfo *v35; // r8
		  float v36; // xmm1_4
		  Vector4 v37; // xmm0
		  Vector4 v38; // xmm1
		  Vector4 v39; // xmm0
		  HGShaderKeyWords__StaticFields *static_fields; // rcx
		  MethodInfo *v41; // [rsp+28h] [rbp-81h]
		  Vector4 si128; // [rsp+48h] [rbp-61h] BYREF
		  Vector4 v43; // [rsp+58h] [rbp-51h] BYREF
		  Vector4 v44[7]; // [rsp+68h] [rbp-41h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2895, 0LL) )
		  {
		    if ( bloom )
		    {
		      if ( !HG::Rendering::Runtime::Bloom::IsActive(bloom, 0LL) )
		        return;
		      if ( settingParams )
		      {
		        if ( !HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                settingParams->fields._bloomEnabled_k__BackingField,
		                MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
		          return;
		        HG::Rendering::Runtime::Bloom::get_intensity(bloom, 0LL);
		        v13 = sub_1803369A0();
		        tint = bloom->fields.tint;
		        v15 = 1.0;
		        v16 = *(float *)&v13 - 1.0;
		        if ( tint )
		        {
		          v43 = *(Vector4 *)sub_180032E40(&v43, 10LL, tint);
		          v17 = (__m128)_mm_loadu_si128((const __m128i *)sub_183C6CBA0(&si128, &v43));
		          sub_1800036A0(TypeInfo::UnityEngine::Rendering::ColorUtils);
		          v20 = (float)((float)(v17.m128_f32[0] * 0.2126729)
		                      + (float)(_mm_shuffle_ps(v17, v17, 85).m128_f32[0] * 0.7151522))
		              + (float)(_mm_shuffle_ps(v17, v17, 170).m128_f32[0] * 0.072175004);
		          if ( v20 <= 0.0 )
		          {
		            one = UnityEngine::Vector4::get_one(&v43, v18);
		          }
		          else
		          {
		            v43 = (Vector4)v17;
		            one = UnityEngine::Vector4::op_Multiply(&si128, &v43, 1.0 / v20, v19);
		          }
		          v22 = _mm_loadu_si128((const __m128i *)one);
		          dirtTexture = (HGRuntimeGrassQuery_Node *)bloom->fields.dirtTexture;
		          if ( dirtTexture )
		          {
		            v23 = (Object_1 *)sub_1800460A0(10LL, dirtTexture);
		            sub_1800036A0(TypeInfo::UnityEngine::Object);
		            if ( UnityEngine::Object::op_Equality(v23, 0LL, 0LL) )
		            {
		              blackTexture = UnityEngine::Texture2D::get_blackTexture(0LL);
		            }
		            else
		            {
		              dirtTexture = (HGRuntimeGrassQuery_Node *)bloom->fields.dirtTexture;
		              if ( !dirtTexture )
		                goto LABEL_35;
		              blackTexture = (Texture2D *)sub_1800460A0(10LL, dirtTexture);
		            }
		            v25 = (Texture *)blackTexture;
		            dirtEnabled = HG::Rendering::Runtime::Bloom::get_dirtEnabled(bloom, 0LL);
		            if ( v25 )
		            {
		              v27 = (float)(int)sub_180002F70(5LL, v25);
		              v28 = v27 / (float)(int)sub_180002F70(7LL, v25);
		              if ( camera )
		              {
		                dirtTexture = (HGRuntimeGrassQuery_Node *)bloom->fields.dirtIntensity;
		                m_X = (float)camera->fields._taauRTSize_k__BackingField.m_X;
		                v30 = (float)(int)HIDWORD(*(_QWORD *)&camera->fields._taauRTSize_k__BackingField);
		                si128 = (Vector4)_mm_load_si128((const __m128i *)&xmmword_18B959740);
		                v31 = m_X / v30;
		                if ( dirtTexture )
		                {
		                  v34 = sub_1800057D0(10LL, dirtTexture);
		                  if ( v28 > v31 )
		                  {
		                    si128.x = v31 / v28;
		                    si128.z = (float)(1.0 - (float)(v31 / v28)) * 0.5;
		                  }
		                  else if ( v31 > v28 )
		                  {
		                    si128.y = v28 / v31;
		                    si128.w = (float)(1.0 - (float)(v28 / v31)) * 0.5;
		                  }
		                  if ( data )
		                  {
		                    data->fields.bloomDirtTexture = v25;
		                    sub_18002D1B0(
		                      (HGRuntimeGrassQuery_Node *)&data->fields.bloomDirtTexture,
		                      dirtTexture,
		                      v32,
		                      v33,
		                      v41);
		                    dirtTexture = (HGRuntimeGrassQuery_Node *)bloom->fields.blendMode;
		                    if ( dirtTexture )
		                    {
		                      if ( (unsigned int)sub_180002F70(10LL, dirtTexture) )
		                        v36 = 1.0;
		                      else
		                        v36 = 0.0;
		                      if ( !dirtEnabled )
		                        v15 = 0.0;
		                      v43.x = v16;
		                      v43.z = v36;
		                      v43.y = v16 * *(float *)&v34;
		                      v43.w = v15;
		                      v37 = v43;
		                      v43 = (Vector4)v22;
		                      data->fields.bloomParams = v37;
		                      v38 = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Color::op_Implicit(
		                                                                        (Color *)v44,
		                                                                        &v43,
		                                                                        v35));
		                      data->fields.bloomDirtTileOffset = si128;
		                      data->fields.bloomTint = v38;
		                      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		                      v39 = (Vector4)_mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::UberPostPassUtils::GetBloomThresholdParams(
		                                                                        v44,
		                                                                        bloom,
		                                                                        0LL));
		                      data->fields.bloomBicubicParams = *bloomBicubicParams;
		                      data->fields.bloomThreshold = v39;
		                      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		                      static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields;
		                      dirtTexture = (HGRuntimeGrassQuery_Node *)(dirtEnabled
		                                                               ? static_fields->s_BloomDirt
		                                                               : static_fields->s_Bloom);
		                      Patch = (ILFixDynamicMethodWrapper_2 *)ppMaterial;
		                      if ( ppMaterial )
		                      {
		                        UnityEngine::Material::EnableKeyword(ppMaterial, (String *)dirtTexture, 0LL);
		                        return;
		                      }
		                    }
		                  }
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_35:
		    sub_1800D8260(Patch, dirtTexture);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2895, 0LL);
		  if ( !Patch )
		    goto LABEL_35;
		  v43 = *bloomBicubicParams;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1058(
		    Patch,
		    (Object *)settingParams,
		    (Object *)data,
		    (Object *)bloom,
		    &v43,
		    (Object *)camera,
		    (Object *)ppMaterial,
		    0LL);
		}
		
		internal static void PrepareBloomPSMaterials(HGRenderPipelineMaterialCollector materialCollector, ref BloomPSMaterials bloomPSMaterials, HGRenderPipelineRuntimeResources defaultResources) {} // 0x00000001835208B0-0x0000000183520AC0
		// Void PrepareBloomPSMaterials(HGRenderPipelineMaterialCollector, UberPostPassUtils+BloomPSMaterials ByRef, HGRenderPipelineRuntimeResources)
		void HG::Rendering::Runtime::UberPostPassUtils::PrepareBloomPSMaterials(
		        HGRenderPipelineMaterialCollector *materialCollector,
		        UberPostPassUtils_BloomPSMaterials *bloomPSMaterials,
		        HGRenderPipelineRuntimeResources *defaultResources,
		        MethodInfo *method)
		{
		  int v7; // ebx
		  HGRuntimeGrassQuery_Node *v8; // rdx
		  HGRuntimeGrassQuery_Node *v9; // r8
		  Int32__Array **v10; // r9
		  HGRuntimeGrassQuery_Node *v11; // rdx
		  HGRuntimeGrassQuery_Node *v12; // r8
		  Int32__Array **v13; // r9
		  HGRuntimeGrassQuery_Node *v14; // rdx
		  HGRuntimeGrassQuery_Node *v15; // r8
		  Int32__Array **v16; // r9
		  __int128 v17; // xmm1
		  HGRuntimeGrassQuery_Node *v18; // rdx
		  HGRuntimeGrassQuery_Node *v19; // r8
		  Int32__Array **v20; // r9
		  HGRenderPipelineRuntimeResources_ShaderResources *v21; // rdx
		  __int64 v22; // rcx
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
		  HGRuntimeGrassQuery_Node *v24; // rdx
		  HGRuntimeGrassQuery_Node *v25; // r8
		  Int32__Array **v26; // r9
		  Material__Array *blur1stPassMaterials; // rdi
		  Material *Material; // rax
		  Material *v29; // rsi
		  Material__Array *blur2ndPassMaterials; // rdi
		  Material *v31; // rax
		  Material *v32; // rsi
		  Material__Array *bloomUpsampleMaterials; // rdi
		  Material *v34; // rax
		  Material *v35; // rsi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *methoda; // [rsp+20h] [rbp-48h]
		  MethodInfo *methodc; // [rsp+20h] [rbp-48h]
		  MethodInfo *methodd; // [rsp+20h] [rbp-48h]
		  MethodInfo *methode; // [rsp+20h] [rbp-48h]
		  MethodInfo *methodb; // [rsp+20h] [rbp-48h]
		  __m256i v42; // [rsp+30h] [rbp-38h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2897, 0LL) )
		  {
		    v7 = 0;
		    memset(&v42, 0, 24);
		    v42.m256i_i64[3] = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Material, 17LL);
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v42.m256i_u64[3], v8, v9, v10, methoda);
		    v42.m256i_i64[1] = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Material, 17LL);
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v42.m256i_u64[1], v11, v12, v13, methodc);
		    v42.m256i_i64[2] = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Material, 17LL);
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v42.m256i_u64[2], v14, v15, v16, methodd);
		    v17 = *(_OWORD *)&v42.m256i_u64[2];
		    *(_OWORD *)&bloomPSMaterials->prefilterMaterial = *(_OWORD *)v42.m256i_i8;
		    *(_OWORD *)&bloomPSMaterials->blur2ndPassMaterials = v17;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)bloomPSMaterials, v18, v19, v20, methode);
		    if ( defaultResources )
		    {
		      shaders = defaultResources->fields.shaders;
		      if ( shaders )
		      {
		        if ( materialCollector )
		        {
		          bloomPSMaterials->prefilterMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
		                                                  materialCollector,
		                                                  shaders->fields.bloomPS,
		                                                  0,
		                                                  0LL);
		          sub_18002D1B0((HGRuntimeGrassQuery_Node *)bloomPSMaterials, v24, v25, v26, methodb);
		          while ( 1 )
		          {
		            v21 = defaultResources->fields.shaders;
		            blur1stPassMaterials = bloomPSMaterials->blur1stPassMaterials;
		            if ( !v21 )
		              break;
		            Material = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
		                         materialCollector,
		                         v21->fields.bloomPS,
		                         0,
		                         0LL);
		            v29 = Material;
		            if ( !blur1stPassMaterials )
		              break;
		            sub_180031B10(blur1stPassMaterials, Material);
		            sub_1800020D0(blur1stPassMaterials, v7, v29);
		            v21 = defaultResources->fields.shaders;
		            blur2ndPassMaterials = bloomPSMaterials->blur2ndPassMaterials;
		            if ( !v21 )
		              break;
		            v31 = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
		                    materialCollector,
		                    v21->fields.bloomPS,
		                    0,
		                    0LL);
		            v32 = v31;
		            if ( !blur2ndPassMaterials )
		              break;
		            sub_180031B10(blur2ndPassMaterials, v31);
		            sub_1800020D0(blur2ndPassMaterials, v7, v32);
		            v21 = defaultResources->fields.shaders;
		            bloomUpsampleMaterials = bloomPSMaterials->bloomUpsampleMaterials;
		            if ( !v21 )
		              break;
		            v34 = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
		                    materialCollector,
		                    v21->fields.bloomPS,
		                    0,
		                    0LL);
		            v35 = v34;
		            if ( !bloomUpsampleMaterials )
		              break;
		            sub_180031B10(bloomUpsampleMaterials, v34);
		            sub_1800020D0(bloomUpsampleMaterials, v7++, v35);
		            if ( v7 >= 17 )
		              return;
		          }
		        }
		      }
		    }
		LABEL_14:
		    sub_1800D8260(v22, v21);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2897, 0LL);
		  if ( !Patch )
		    goto LABEL_14;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1060(
		    Patch,
		    (Object *)materialCollector,
		    bloomPSMaterials,
		    (Object *)defaultResources,
		    0LL);
		}
		
		internal static void DisposeBloomPSMaterials(ref BloomPSMaterials bloomPSMaterials) {} // 0x00000001837DCC60-0x00000001837DCDB0
		// Void DisposeBloomPSMaterials(UberPostPassUtils+BloomPSMaterials ByRef)
		void HG::Rendering::Runtime::UberPostPassUtils::DisposeBloomPSMaterials(
		        UberPostPassUtils_BloomPSMaterials *bloomPSMaterials,
		        MethodInfo *method)
		{
		  Object_1 *prefilterMaterial; // rbx
		  int v4; // ebx
		  HGRuntimeGrassQuery_Node *v5; // rdx
		  HGRuntimeGrassQuery_Node *v6; // r8
		  Int32__Array **v7; // r9
		  __int64 v8; // rdx
		  Material__Array *blur1stPassMaterials; // rcx
		  Object_1 *v10; // rsi
		  Material__Array *blur2ndPassMaterials; // rax
		  Material__Array *bloomUpsampleMaterials; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v14; // [rsp+20h] [rbp-8h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2899, 0LL) )
		  {
		    prefilterMaterial = (Object_1 *)bloomPSMaterials->prefilterMaterial;
		    if ( !TypeInfo::UnityEngine::Rendering::CoreUtils->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::CoreUtils);
		    UnityEngine::Rendering::CoreUtils::Destroy(prefilterMaterial, 0LL);
		    v4 = 0;
		    bloomPSMaterials->prefilterMaterial = 0LL;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)bloomPSMaterials, v5, v6, v7, v14);
		    while ( 1 )
		    {
		      blur1stPassMaterials = bloomPSMaterials->blur1stPassMaterials;
		      if ( !blur1stPassMaterials )
		        break;
		      if ( (unsigned int)v4 >= blur1stPassMaterials->max_length.size )
		        goto LABEL_19;
		      v10 = (Object_1 *)blur1stPassMaterials->vector[v4];
		      if ( !TypeInfo::UnityEngine::Rendering::CoreUtils->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::CoreUtils);
		      UnityEngine::Rendering::CoreUtils::Destroy(v10, 0LL);
		      blur2ndPassMaterials = bloomPSMaterials->blur2ndPassMaterials;
		      if ( !blur2ndPassMaterials )
		        break;
		      if ( (unsigned int)v4 >= blur2ndPassMaterials->max_length.size )
		        goto LABEL_19;
		      UnityEngine::Rendering::CoreUtils::Destroy((Object_1 *)blur2ndPassMaterials->vector[v4], 0LL);
		      bloomUpsampleMaterials = bloomPSMaterials->bloomUpsampleMaterials;
		      if ( !bloomUpsampleMaterials )
		        break;
		      if ( (unsigned int)v4 >= bloomUpsampleMaterials->max_length.size )
		LABEL_19:
		        sub_1800D2AB0(blur1stPassMaterials, v8);
		      UnityEngine::Rendering::CoreUtils::Destroy((Object_1 *)bloomUpsampleMaterials->vector[v4], 0LL);
		      blur1stPassMaterials = bloomPSMaterials->blur1stPassMaterials;
		      if ( !blur1stPassMaterials )
		        break;
		      sub_1800020D0(blur1stPassMaterials, v4, 0LL);
		      blur1stPassMaterials = bloomPSMaterials->blur2ndPassMaterials;
		      if ( !blur1stPassMaterials )
		        break;
		      sub_1800020D0(blur1stPassMaterials, v4, 0LL);
		      blur1stPassMaterials = bloomPSMaterials->bloomUpsampleMaterials;
		      if ( !blur1stPassMaterials )
		        break;
		      sub_1800020D0(blur1stPassMaterials, v4++, 0LL);
		      if ( v4 >= 17 )
		        return;
		    }
		LABEL_18:
		    sub_1800D8260(blur1stPassMaterials, v8);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2899, 0LL);
		  if ( !Patch )
		    goto LABEL_18;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1061(Patch, bloomPSMaterials, 0LL);
		}
		
		internal static GraphicsFormat GetBloomTextureFormat(bool useComputeShader, bool enableAlpha) => default; // 0x0000000189B82404-0x0000000189B82480
		// GraphicsFormat GetBloomTextureFormat(Boolean, Boolean)
		GraphicsFormat__Enum HG::Rendering::Runtime::UberPostPassUtils::GetBloomTextureFormat(
		        bool useComputeShader,
		        bool enableAlpha,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2900, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2900, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1062(Patch, useComputeShader, enableAlpha, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		    if ( useComputeShader )
		      return HG::Rendering::Runtime::UberPostPassUtils::GetPostprocessComputeTextureFormat(enableAlpha, 0LL);
		    else
		      return HG::Rendering::Runtime::UberPostPassUtils::GetPostprocessTextureFormat(
		               enableAlpha,
		               GraphicsFormat__Enum_B10G11R11_UFloatPack32,
		               0LL);
		  }
		}
		
		internal static void PrepareBloomData(bool useComputeShader, HGRenderGraph renderGraph, HGRenderGraphBuilder builder, BloomPassData passData, Bloom bloom, HGCamera camera, bool enableAlpha, TextureHandle source, TextureHandle motionVector, HGRenderPathInternal renderPath, TAAUQuality taauQuality, BloomQuality bloomQuality, ref BloomPSMaterials bloomPSMaterials, out Vector4 bloomBicubicParam) {
			bloomBicubicParam = default;
		} // 0x0000000189B83710-0x0000000189B845AC
		// Void PrepareBloomData(Boolean, HGRenderGraph, HGRenderGraphBuilder, UberPostPassUtils+BloomPassData, Bloom, HGCamera, Boolean, TextureHandle, TextureHandle, HGRenderPathInternal, TAAUQuality, BloomQuality, UberPostPassUtils+BloomPSMaterials ByRef, Vector4 ByRef)
		void HG::Rendering::Runtime::UberPostPassUtils::PrepareBloomData(
		        bool useComputeShader,
		        HGRenderGraph *renderGraph,
		        HGRenderGraphBuilder *builder,
		        UberPostPassUtils_BloomPassData *passData,
		        Bloom *bloom,
		        HGCamera *camera,
		        bool enableAlpha,
		        TextureHandle *source,
		        TextureHandle *motionVector,
		        HGRenderPathInternal__Enum renderPath,
		        TAAUQuality__Enum taauQuality,
		        BloomQuality__Enum bloomQuality,
		        UberPostPassUtils_BloomPSMaterials *bloomPSMaterials,
		        Vector4 *bloomBicubicParam,
		        MethodInfo *method)
		{
		  float v15; // xmm3_4
		  __int64 characterBloomControl; // rdx
		  void *bloomPrefilterCS; // rcx
		  TextureHandle *nullHandle; // rax
		  HGRuntimeGrassQuery_Node *v23; // rdx
		  HGRuntimeGrassQuery_Node *v24; // r8
		  Int32__Array **v25; // r9
		  bool IsValid; // al
		  __int64 v27; // r10
		  Material__Array *v28; // r9
		  HGRuntimeGrassQuery_Node *v29; // rdx
		  HGRuntimeGrassQuery_Node *v30; // r8
		  __int64 v31; // r10
		  Material__Array *v32; // r9
		  HGRuntimeGrassQuery_Node *v33; // rdx
		  HGRuntimeGrassQuery_Node *v34; // r8
		  __int64 v35; // r10
		  Material__Array *v36; // r9
		  HGRuntimeGrassQuery_Node *v37; // rdx
		  HGRuntimeGrassQuery_Node *v38; // r8
		  Material *bloomPrefilterMat; // rdi
		  String *v40; // rdx
		  int i; // edi
		  int v42; // eax
		  Material *v43; // rsi
		  String *s_HighQuality; // rdx
		  Material *v45; // rdi
		  Material *v46; // rdi
		  HGRenderPipeline *currentPipeline; // rax
		  HGRenderPipelineRuntimeResources *defaultResources; // rax
		  HGRuntimeGrassQuery_Node *v49; // r8
		  Int32__Array **v50; // r9
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
		  int32_t Kernel; // eax
		  HGRenderPipeline *v53; // rax
		  HGRenderPipelineRuntimeResources *v54; // rax
		  HGRuntimeGrassQuery_Node *v55; // r8
		  Int32__Array **v56; // r9
		  HGRenderPipelineRuntimeResources_ShaderResources *v57; // rax
		  HGRenderPipeline *v58; // rax
		  HGRenderPipelineRuntimeResources *v59; // rax
		  HGRuntimeGrassQuery_Node *v60; // r8
		  Int32__Array **v61; // r9
		  HGRenderPipelineRuntimeResources_ShaderResources *v62; // rax
		  int32_t v63; // eax
		  HGRenderPipeline *v64; // rax
		  HGRenderPipelineRuntimeResources *v65; // rax
		  HGRuntimeGrassQuery_Node *v66; // r8
		  Int32__Array **v67; // r9
		  HGRenderPipelineRuntimeResources_ShaderResources *v68; // rax
		  float scatter; // xmm2_4
		  Beyond::JobMathf *v70; // rcx
		  double v71; // xmm0_8
		  float v72; // xmm7_4
		  float v73; // xmm10_4
		  HGRenderPipelineSettingHub *instance; // rax
		  __int64 v75; // rdx
		  __int64 v76; // r8
		  __int128 v77; // xmm0
		  __int128 v78; // xmm1
		  float v79; // xmm0_4
		  float v80; // xmm1_4
		  float v81; // xmm1_4
		  char v82; // dl
		  __int64 v83; // rcx
		  int v84; // r8d
		  int32_t v85; // eax
		  int32_t j; // edi
		  __int64 v87; // rdx
		  __int64 v88; // rcx
		  double v89; // xmm0_8
		  __int64 v90; // rdx
		  int32_t v91; // r14d
		  int32_t v92; // eax
		  HGRuntimeGrassQuery_Node *v93; // rdx
		  HGRuntimeGrassQuery_Node *v94; // r8
		  Int32__Array **v95; // r9
		  TextureHandle__Array *mipsDown; // r14
		  TextureHandle *v97; // rax
		  TextureHandle *v98; // rax
		  TextureHandle *v99; // rax
		  HGRuntimeGrassQuery_Node *v100; // rdx
		  HGRuntimeGrassQuery_Node *v101; // r8
		  Int32__Array **v102; // r9
		  TextureHandle__Array *mipsUp; // r14
		  TextureHandle *v104; // rax
		  TextureHandle *v105; // rax
		  TextureHandle *v106; // rax
		  uint32_t *v107; // rax
		  uint32_t v108; // xmm8_4
		  __int64 v109; // rax
		  int32_t v110; // xmm7_4
		  float *v111; // rax
		  uint32_t v112; // xmm0_4
		  __int64 v113; // rdx
		  __int64 v114; // rcx
		  int32_t v115; // eax
		  __int64 v116; // rcx
		  __int64 v117; // rdx
		  HGRuntimeGrassQuery_Node *v118; // rdx
		  HGRuntimeGrassQuery_Node *v119; // r8
		  Int32__Array **v120; // r9
		  GraphicsFormat__Enum BloomTextureFormat; // eax
		  TextureHandle__Array *v122; // rdi
		  TextureHandle *v123; // rax
		  __int128 v124; // xmm0
		  __int128 v125; // xmm1
		  MethodInfo *v126; // [rsp+28h] [rbp-E0h]
		  MethodInfo *v127; // [rsp+28h] [rbp-E0h]
		  MethodInfo *v128; // [rsp+28h] [rbp-E0h]
		  MethodInfo *v129; // [rsp+28h] [rbp-E0h]
		  MethodInfo *v130; // [rsp+28h] [rbp-E0h]
		  MethodInfo *v131; // [rsp+28h] [rbp-E0h]
		  MethodInfo *v132; // [rsp+28h] [rbp-E0h]
		  MethodInfo *v133; // [rsp+28h] [rbp-E0h]
		  TextureHandle v134; // [rsp+88h] [rbp-80h] BYREF
		  unsigned __int128 v135; // [rsp+98h] [rbp-70h] BYREF
		  Vector2Int size; // [rsp+A8h] [rbp-60h]
		  TextureDesc v137; // [rsp+B8h] [rbp-50h] BYREF
		  HGPhysicalCamera v138; // [rsp+118h] [rbp+10h] BYREF
		  TextureDesc v139; // [rsp+148h] [rbp+40h] BYREF
		  TextureHandle v140; // [rsp+1A8h] [rbp+A0h] BYREF
		  TextureHandle v141; // [rsp+1B8h] [rbp+B0h] BYREF
		  TextureHandle v142; // [rsp+1C8h] [rbp+C0h] BYREF
		  TextureHandle v143; // [rsp+1D8h] [rbp+D0h] BYREF
		  TextureHandle v144; // [rsp+1E8h] [rbp+E0h] BYREF
		
		  sub_18033B9D0(&v139, 0LL, 96LL);
		  size = 0LL;
		  sub_18033B9D0(&v137, 0LL, 96LL);
		  if ( !IFix::WrappersManagerImpl::IsPatched(2901, 0LL) )
		  {
		    if ( !passData )
		      goto LABEL_127;
		    passData->fields.enableAlpha = enableAlpha;
		    passData->fields.viewCount = 1;
		    passData->fields.bloomQuality = bloomQuality;
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		    if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(motionVector, 0LL) )
		    {
		      nullHandle = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                     &v134,
		                     builder,
		                     motionVector,
		                     0LL);
		    }
		    else
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		      nullHandle = HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v134, 0LL);
		    }
		    passData->fields.motionVector = *nullHandle;
		    if ( !bloom )
		      goto LABEL_127;
		    characterBloomControl = (__int64)bloom->fields.characterBloomControl;
		    if ( !characterBloomControl )
		      goto LABEL_127;
		    if ( !(unsigned __int8)sub_180006280(10LL, characterBloomControl) || taauQuality )
		    {
		      IsValid = 0;
		    }
		    else
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		      IsValid = HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&passData->fields.motionVector, 0LL);
		    }
		    passData->fields.enableCharacterMask = IsValid;
		    if ( useComputeShader )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		      currentPipeline = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
		      if ( !currentPipeline )
		        goto LABEL_127;
		      defaultResources = HG::Rendering::Runtime::HGRenderPipeline::get_defaultResources(currentPipeline, 0LL);
		      if ( !defaultResources )
		        goto LABEL_127;
		      shaders = defaultResources->fields.shaders;
		      if ( !shaders )
		        goto LABEL_127;
		      passData->fields.bloomPrefilterCS = shaders->fields.bloomPrefilterCS;
		      sub_18002D1B0(
		        (HGRuntimeGrassQuery_Node *)&passData->fields.bloomPrefilterCS,
		        (HGRuntimeGrassQuery_Node *)characterBloomControl,
		        v49,
		        v50,
		        v126);
		      bloomPrefilterCS = passData->fields.bloomPrefilterCS;
		      if ( !bloomPrefilterCS )
		        goto LABEL_127;
		      Kernel = UnityEngine::ComputeShader::FindKernel((ComputeShader *)bloomPrefilterCS, (String *)"KMain", 0LL);
		      bloomPrefilterCS = passData->fields.bloomPrefilterCS;
		      passData->fields.bloomPrefilterKernel = Kernel;
		      if ( !bloomPrefilterCS )
		        goto LABEL_127;
		      UnityEngine::ComputeShader::SetShaderKeywords((ComputeShader *)bloomPrefilterCS, 0LL, 0LL);
		      v53 = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
		      if ( !v53 )
		        goto LABEL_127;
		      v54 = HG::Rendering::Runtime::HGRenderPipeline::get_defaultResources(v53, 0LL);
		      if ( !v54 )
		        goto LABEL_127;
		      v57 = v54->fields.shaders;
		      if ( !v57 )
		        goto LABEL_127;
		      passData->fields.bloomBlurCS = v57->fields.bloomBlurCS;
		      sub_18002D1B0(
		        (HGRuntimeGrassQuery_Node *)&passData->fields.bloomBlurCS,
		        (HGRuntimeGrassQuery_Node *)characterBloomControl,
		        v55,
		        v56,
		        v131);
		      v58 = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
		      if ( !v58 )
		        goto LABEL_127;
		      v59 = HG::Rendering::Runtime::HGRenderPipeline::get_defaultResources(v58, 0LL);
		      if ( !v59 )
		        goto LABEL_127;
		      v62 = v59->fields.shaders;
		      if ( !v62 )
		        goto LABEL_127;
		      passData->fields.bloomBlurNonOptCS = v62->fields.bloomBlurNonOptCS;
		      sub_18002D1B0(
		        (HGRuntimeGrassQuery_Node *)&passData->fields.bloomBlurNonOptCS,
		        (HGRuntimeGrassQuery_Node *)characterBloomControl,
		        v60,
		        v61,
		        v132);
		      bloomPrefilterCS = passData->fields.bloomBlurCS;
		      if ( !bloomPrefilterCS )
		        goto LABEL_127;
		      v63 = UnityEngine::ComputeShader::FindKernel((ComputeShader *)bloomPrefilterCS, (String *)"KMain", 0LL);
		      bloomPrefilterCS = passData->fields.bloomBlurCS;
		      passData->fields.bloomBlurKernel = v63;
		      if ( !bloomPrefilterCS )
		        goto LABEL_127;
		      passData->fields.bloomDownsampleKernel = UnityEngine::ComputeShader::FindKernel(
		                                                 (ComputeShader *)bloomPrefilterCS,
		                                                 (String *)"KDownsample",
		                                                 0LL);
		      v64 = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
		      if ( !v64 )
		        goto LABEL_127;
		      v65 = HG::Rendering::Runtime::HGRenderPipeline::get_defaultResources(v64, 0LL);
		      if ( !v65 )
		        goto LABEL_127;
		      v68 = v65->fields.shaders;
		      if ( !v68 )
		        goto LABEL_127;
		      passData->fields.bloomUpsampleCS = v68->fields.bloomUpsampleCS;
		      sub_18002D1B0(
		        (HGRuntimeGrassQuery_Node *)&passData->fields.bloomUpsampleCS,
		        (HGRuntimeGrassQuery_Node *)characterBloomControl,
		        v66,
		        v67,
		        v133);
		      bloomPrefilterCS = passData->fields.bloomUpsampleCS;
		      if ( !bloomPrefilterCS )
		        goto LABEL_127;
		      UnityEngine::ComputeShader::SetShaderKeywords((ComputeShader *)bloomPrefilterCS, 0LL, 0LL);
		      bloomPrefilterCS = passData->fields.bloomUpsampleCS;
		      if ( !bloomPrefilterCS )
		        goto LABEL_127;
		      passData->fields.bloomUpsampleKernel = UnityEngine::ComputeShader::FindKernel(
		                                               (ComputeShader *)bloomPrefilterCS,
		                                               (String *)"KMain",
		                                               0LL);
		      goto LABEL_66;
		    }
		    passData->fields.bloomPrefilterMat = bloomPSMaterials->prefilterMaterial;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&passData->fields, v23, v24, v25, v126);
		    v28 = *(Material__Array **)(v27 + 8);
		    passData->fields.bloomBlurMat1stPass = v28;
		    sub_18002D1B0(
		      (HGRuntimeGrassQuery_Node *)&passData->fields.bloomBlurMat1stPass,
		      v29,
		      v30,
		      (Int32__Array **)v28,
		      v127);
		    v32 = *(Material__Array **)(v31 + 16);
		    passData->fields.bloomBlurMat2ndPass = v32;
		    sub_18002D1B0(
		      (HGRuntimeGrassQuery_Node *)&passData->fields.bloomBlurMat2ndPass,
		      v33,
		      v34,
		      (Int32__Array **)v32,
		      v128);
		    v36 = *(Material__Array **)(v35 + 24);
		    passData->fields.bloomUpsampleMat = v36;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&passData->fields.bloomUpsampleMat, v37, v38, (Int32__Array **)v36, v129);
		    bloomPrefilterCS = passData->fields.bloomPrefilterMat;
		    if ( !bloomPrefilterCS )
		      goto LABEL_127;
		    UnityEngine::Material::SetShaderKeywords((Material *)bloomPrefilterCS, 0LL, 0LL);
		    if ( bloomQuality )
		    {
		      if ( bloomQuality == BloomQuality__Enum_Medium )
		      {
		        bloomPrefilterMat = passData->fields.bloomPrefilterMat;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		        characterBloomControl = (__int64)TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields;
		        if ( !bloomPrefilterMat )
		          goto LABEL_127;
		        v40 = *(String **)(characterBloomControl + 136);
		      }
		      else
		      {
		        if ( bloomQuality != BloomQuality__Enum_High )
		        {
		LABEL_24:
		          for ( i = 0; i <= 16; ++i )
		          {
		            characterBloomControl = (__int64)bloom->fields.quality;
		            if ( !characterBloomControl )
		              goto LABEL_127;
		            v42 = sub_180002F70(10LL, characterBloomControl);
		            bloomPrefilterCS = passData->fields.bloomUpsampleMat;
		            if ( v42 )
		            {
		              if ( !bloomPrefilterCS )
		                goto LABEL_127;
		              if ( (unsigned int)i >= *((_DWORD *)bloomPrefilterCS + 6) )
		                goto LABEL_46;
		              v43 = (Material *)*((_QWORD *)bloomPrefilterCS + i + 4);
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		              if ( !v43 )
		                goto LABEL_127;
		              s_HighQuality = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_HighQuality;
		            }
		            else
		            {
		              if ( !bloomPrefilterCS )
		                goto LABEL_127;
		              if ( (unsigned int)i >= *((_DWORD *)bloomPrefilterCS + 6) )
		LABEL_46:
		                sub_1800D2AB0(bloomPrefilterCS, characterBloomControl);
		              v43 = (Material *)*((_QWORD *)bloomPrefilterCS + i + 4);
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		              if ( !v43 )
		                goto LABEL_127;
		              s_HighQuality = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_LowQuality;
		            }
		            UnityEngine::Material::EnableKeyword(v43, s_HighQuality, 0LL);
		          }
		          v45 = passData->fields.bloomPrefilterMat;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		          if ( enableAlpha )
		          {
		            characterBloomControl = (__int64)TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields;
		            if ( !v45 )
		              goto LABEL_127;
		            UnityEngine::Material::EnableKeyword(v45, *(String **)(characterBloomControl + 152), 0LL);
		          }
		          else
		          {
		            bloomPrefilterCS = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields;
		            if ( !v45 )
		              goto LABEL_127;
		            UnityEngine::Material::DisableKeyword(v45, *((String **)bloomPrefilterCS + 19), 0LL);
		          }
		          v46 = passData->fields.bloomPrefilterMat;
		          if ( passData->fields.enableCharacterMask )
		          {
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		            characterBloomControl = (__int64)TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields;
		            if ( !v46 )
		              goto LABEL_127;
		            UnityEngine::Material::EnableKeyword(v46, *(String **)(characterBloomControl + 160), 0LL);
		          }
		          else
		          {
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		            bloomPrefilterCS = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields;
		            if ( !v46 )
		              goto LABEL_127;
		            UnityEngine::Material::DisableKeyword(v46, *((String **)bloomPrefilterCS + 20), 0LL);
		          }
		LABEL_66:
		          scatter = HG::Rendering::Runtime::Bloom::get_scatter(bloom, 0LL);
		          Beyond::JobMathf::ClampedLerp(v70, 0.94999999, scatter, v15);
		          passData->fields.bloomScatterParam = 0.050000001;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		          passData->fields.thresholdParams = (Vector4)_mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::UberPostPassUtils::GetBloomThresholdParams(
		                                                                                         (Vector4 *)&v134,
		                                                                                         bloom,
		                                                                                         0LL));
		          passData->fields.characterThresholdParams = (Vector4)_mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::UberPostPassUtils::GetBloomCharacterThresholdParams(
		                                                                                                  (Vector4 *)&v134,
		                                                                                                  bloom,
		                                                                                                  0LL));
		          characterBloomControl = (__int64)bloom->fields.characterIntensity;
		          if ( characterBloomControl )
		          {
		            v71 = sub_1800057D0(10LL, characterBloomControl);
		            v135 = LODWORD(v71);
		            passData->fields.characterParams = (Vector4)LODWORD(v71);
		            HG::Rendering::Runtime::Bloom::get_resolution(bloom, 0LL);
		            if ( camera )
		            {
		              if ( (int)HIDWORD(*(_QWORD *)&camera->fields._taauRTSize_k__BackingField) > 1080 )
		              {
		                v72 = 1080.0 / (float)(int)HIDWORD(*(_QWORD *)&camera->fields._taauRTSize_k__BackingField);
		                v73 = v72;
		              }
		              else
		              {
		                v72 = 1.0;
		                v73 = 1.0;
		              }
		              instance = HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_instance(0LL);
		              if ( instance )
		              {
		                if ( HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_currentDeviceType(instance, 0LL) == HGDeviceType__Enum_Cinematic )
		                {
		                  v72 = 1.0;
		                  v73 = 1.0;
		                }
		                characterBloomControl = (__int64)bloom->fields.anamorphic;
		                if ( characterBloomControl )
		                {
		                  if ( (unsigned __int8)sub_180006280(10LL, characterBloomControl) )
		                  {
		                    v77 = *(_OWORD *)&camera->fields._physicalParameters_k__BackingField.m_Iso;
		                    v78 = *(_OWORD *)&camera->fields._physicalParameters_k__BackingField.m_BladeCount;
		                    v138.m_Anamorphism = camera->fields._physicalParameters_k__BackingField.m_Anamorphism;
		                    *(_OWORD *)&v138.m_Iso = v77;
		                    *(_OWORD *)&v138.m_BladeCount = v78;
		                    v79 = HG::Rendering::Runtime::HGPhysicalCamera::get_anamorphism(&v138, 0LL) * 0.5;
		                    if ( v79 >= 0.0 )
		                      v80 = 1.0;
		                    else
		                      v80 = v79 + 1.0;
		                    v73 = v73 * v80;
		                    v81 = 1.0;
		                    if ( v79 > 0.0 )
		                      v81 = 1.0 - v79;
		                    v72 = v72 * v81;
		                  }
		                  sub_182F114D0(
		                    (unsigned int)(int)(float)((float)(int)HIDWORD(*(_QWORD *)&camera->fields._taauRTSize_k__BackingField)
		                                             * v72),
		                    v75,
		                    v76);
		                  v85 = sub_1834464B0(v83, v82, v84);
		                  if ( v85 < 1 )
		                  {
		                    v85 = 1;
		                  }
		                  else if ( v85 > 16 )
		                  {
		                    v85 = 16;
		                  }
		                  passData->fields.bloomMipCount = v85;
		                  for ( j = 0; j < passData->fields.bloomMipCount; ++j )
		                  {
		                    v89 = sub_1803369A0();
		                    if ( camera->fields._DynResRequest_k__BackingField.hardwareEnabled )
		                    {
		                      v91 = sub_1832DBD50();
		                      if ( v91 < 1 )
		                        v91 = 1;
		                      v92 = sub_1832DBD50();
		                      if ( v92 < 1 )
		                        v92 = 1;
		                    }
		                    else
		                    {
		                      v91 = sub_182F3EA70(v88, v87);
		                      if ( v91 < 1 )
		                        v91 = 1;
		                      v92 = sub_182F3EA70(HIDWORD(*(_QWORD *)&camera->fields._taauRTSize_k__BackingField), v90);
		                      characterBloomControl = 1LL;
		                      if ( v92 < 1 )
		                        v92 = 1;
		                    }
		                    bloomPrefilterCS = passData->fields.bloomMipInfo;
		                    *((float *)&v135 + 2) = (float)(1.0 / *(float *)&v89) * v73;
		                    *((float *)&v135 + 3) = (float)(1.0 / *(float *)&v89) * v72;
		                    size.m_X = v91;
		                    size.m_Y = v92;
		                    *(float *)&v135 = (float)v91;
		                    *((float *)&v135 + 1) = (float)v92;
		                    if ( !bloomPrefilterCS )
		                      goto LABEL_127;
		                    v134 = (TextureHandle)v135;
		                    sub_18003FEF0(bloomPrefilterCS, j, &v134);
		                    HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v137, size, 0LL);
		                    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		                    v137.colorFormat = HG::Rendering::Runtime::UberPostPassUtils::GetBloomTextureFormat(
		                                         useComputeShader,
		                                         enableAlpha,
		                                         0LL);
		                    v137.name = (String *)"BloomMipDown";
		                    v137.enableRandomWrite = useComputeShader;
		                    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v137.name, v93, v94, v95, v130);
		                    mipsDown = passData->fields.mipsDown;
		                    v137.wrapMode = 1;
		                    v137.filterMode = 1;
		                    v139 = v137;
		                    if ( useComputeShader )
		                    {
		                      v99 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(
		                              &v142,
		                              builder,
		                              &v139,
		                              0LL);
		                      if ( !mipsDown )
		                        goto LABEL_127;
		                      v134 = *v99;
		                      sub_180430AC4(mipsDown, j, &v134);
		                    }
		                    else
		                    {
		                      if ( !renderGraph )
		                        goto LABEL_127;
		                      v97 = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                              &v140,
		                              renderGraph,
		                              &v139,
		                              0LL);
		                      if ( !mipsDown )
		                        goto LABEL_127;
		                      v134 = *v97;
		                      sub_180430AC4(mipsDown, j, &v134);
		                      bloomPrefilterCS = passData->fields.mipsDown;
		                      if ( !bloomPrefilterCS )
		                        goto LABEL_127;
		                      v98 = (TextureHandle *)sub_1803C0774(bloomPrefilterCS, j);
		                      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadWriteTexture(&v141, builder, v98, 0LL);
		                    }
		                    if ( j && (!useComputeShader || j != passData->fields.bloomMipCount - 1) )
		                    {
		                      HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v137, size, 0LL);
		                      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		                      v137.colorFormat = HG::Rendering::Runtime::UberPostPassUtils::GetBloomTextureFormat(
		                                           useComputeShader,
		                                           enableAlpha,
		                                           0LL);
		                      v137.name = (String *)"BloomMipUp";
		                      v137.enableRandomWrite = useComputeShader;
		                      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v137.name, v100, v101, v102, v130);
		                      v137.wrapMode = 1;
		                      v137.filterMode = 1;
		                      mipsUp = passData->fields.mipsUp;
		                      v139 = v137;
		                      if ( useComputeShader )
		                      {
		                        v106 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(
		                                 (TextureHandle *)&v138,
		                                 builder,
		                                 &v139,
		                                 0LL);
		                        if ( !mipsUp )
		                          goto LABEL_127;
		                        v134 = *v106;
		                        sub_180430AC4(mipsUp, j, &v134);
		                      }
		                      else
		                      {
		                        if ( !renderGraph )
		                          goto LABEL_127;
		                        v104 = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                                 &v143,
		                                 renderGraph,
		                                 &v139,
		                                 0LL);
		                        if ( !mipsUp )
		                          goto LABEL_127;
		                        v134 = *v104;
		                        sub_180430AC4(mipsUp, j, &v134);
		                        bloomPrefilterCS = passData->fields.mipsUp;
		                        if ( !bloomPrefilterCS )
		                          goto LABEL_127;
		                        v105 = (TextureHandle *)sub_1803C0774(bloomPrefilterCS, j);
		                        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadWriteTexture(
		                          &v144,
		                          builder,
		                          v105,
		                          0LL);
		                      }
		                    }
		                  }
		                  bloomPrefilterCS = passData->fields.bloomMipInfo;
		                  if ( bloomPrefilterCS )
		                  {
		                    v107 = (uint32_t *)sub_180002100(bloomPrefilterCS, 0LL);
		                    bloomPrefilterCS = passData->fields.bloomMipInfo;
		                    v108 = *v107;
		                    if ( bloomPrefilterCS )
		                    {
		                      v109 = sub_180002100(bloomPrefilterCS, 0LL);
		                      bloomPrefilterCS = passData->fields.bloomMipInfo;
		                      v110 = *(_DWORD *)(v109 + 4);
		                      if ( bloomPrefilterCS )
		                      {
		                        v111 = (float *)sub_180002100(bloomPrefilterCS, 0LL);
		                        bloomPrefilterCS = passData->fields.bloomMipInfo;
		                        if ( bloomPrefilterCS )
		                        {
		                          LODWORD(v135) = v108;
		                          *(float *)&v112 = 1.0 / *v111;
		                          DWORD1(v135) = v110;
		                          DWORD2(v135) = v112;
		                          *((float *)&v135 + 3) = 1.0 / *(float *)(sub_180002100(bloomPrefilterCS, 0LL) + 4);
		                          *bloomBicubicParam = (Vector4)v135;
		                          bloomPrefilterCS = passData->fields.bloomMipInfo;
		                          if ( bloomPrefilterCS )
		                          {
		                            sub_180002100(bloomPrefilterCS, 0LL);
		                            bloomPrefilterCS = passData->fields.bloomMipInfo;
		                            if ( bloomPrefilterCS )
		                            {
		                              sub_180002100(bloomPrefilterCS, 0LL);
		                              v115 = sub_182F3EA70(v114, v113);
		                              v116 = HIDWORD(*(_QWORD *)&camera->fields._taauRTSize_k__BackingField);
		                              size.m_X = v115;
		                              size.m_Y = sub_182F3EA70(v116, v117);
		                              HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v137, size, 0LL);
		                              v137.name = (String *)"Bloom final mip up";
		                              sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v137.name, v118, v119, v120, v130);
		                              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		                              BloomTextureFormat = HG::Rendering::Runtime::UberPostPassUtils::GetBloomTextureFormat(
		                                                     useComputeShader,
		                                                     enableAlpha,
		                                                     0LL);
		                              v122 = passData->fields.mipsUp;
		                              v137.colorFormat = BloomTextureFormat;
		                              v137.wrapMode = 1;
		                              v137.filterMode = 1;
		                              v139 = v137;
		                              v137.useMipMap = 0;
		                              v137.enableRandomWrite = useComputeShader;
		                              if ( renderGraph )
		                              {
		                                v134 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                                          (TextureHandle *)&v138,
		                                          renderGraph,
		                                          &v139,
		                                          0LL);
		                                v123 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
		                                         (TextureHandle *)&v138,
		                                         builder,
		                                         &v134,
		                                         0LL);
		                                if ( v122 )
		                                {
		                                  v134 = *v123;
		                                  sub_180430AC4(v122, 0LL, &v134);
		                                  passData->fields.source = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                                                               (TextureHandle *)&v138,
		                                                               builder,
		                                                               source,
		                                                               0LL);
		                                  return;
		                                }
		                              }
		                            }
		                          }
		                        }
		                      }
		                    }
		                  }
		                }
		              }
		            }
		          }
		LABEL_127:
		          sub_1800D8260(bloomPrefilterCS, characterBloomControl);
		        }
		        bloomPrefilterMat = passData->fields.bloomPrefilterMat;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		        characterBloomControl = (__int64)TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields;
		        if ( !bloomPrefilterMat )
		          goto LABEL_127;
		        v40 = *(String **)(characterBloomControl + 128);
		      }
		    }
		    else
		    {
		      bloomPrefilterMat = passData->fields.bloomPrefilterMat;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		      characterBloomControl = (__int64)TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields;
		      if ( !bloomPrefilterMat )
		        goto LABEL_127;
		      v40 = *(String **)(characterBloomControl + 144);
		    }
		    UnityEngine::Material::EnableKeyword(bloomPrefilterMat, v40, 0LL);
		    goto LABEL_24;
		  }
		  bloomPrefilterCS = IFix::WrappersManagerImpl::GetPatch(2901, 0LL);
		  if ( !bloomPrefilterCS )
		    goto LABEL_127;
		  v134 = *motionVector;
		  v124 = *(_OWORD *)&builder->m_RenderPass;
		  v135 = (unsigned __int128)*source;
		  v125 = *(_OWORD *)&builder->m_RenderGraph;
		  *(_OWORD *)&v138.m_Iso = v124;
		  *(_OWORD *)&v138.m_BladeCount = v125;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1063(
		    (ILFixDynamicMethodWrapper_2 *)bloomPrefilterCS,
		    useComputeShader,
		    (Object *)renderGraph,
		    (HGRenderGraphBuilder *)&v138,
		    (Object *)passData,
		    (Object *)bloom,
		    (Object *)camera,
		    enableAlpha,
		    (TextureHandle *)&v135,
		    &v134,
		    renderPath,
		    taauQuality,
		    bloomQuality,
		    bloomPSMaterials,
		    bloomBicubicParam,
		    0LL);
		}
		
		private static Vector2Int GetMipsUp0SizeTempForCPP(Bloom bloom, HGCamera camera) => default; // 0x0000000189B82704-0x0000000189B828BC
		// Vector2Int GetMipsUp0SizeTempForCPP(Bloom, HGCamera)
		Vector2Int HG::Rendering::Runtime::UberPostPassUtils::GetMipsUp0SizeTempForCPP(
		        Bloom *bloom,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  BoolParameter *anamorphic; // rdx
		  __int64 v6; // rcx
		  __int128 v7; // xmm0
		  __int128 v8; // xmm1
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  __int64 v11; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  HGPhysicalCamera v14; // [rsp+20h] [rbp-68h] BYREF
		  Vector2Int v15; // [rsp+A8h] [rbp+20h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2903, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2903, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1064(Patch, (Object *)bloom, (Object *)camera, 0LL);
		LABEL_9:
		    sub_1800D8260(v6, anamorphic);
		  }
		  if ( !bloom )
		    goto LABEL_9;
		  HG::Rendering::Runtime::Bloom::get_resolution(bloom, 0LL);
		  if ( !camera )
		    goto LABEL_9;
		  anamorphic = bloom->fields.anamorphic;
		  if ( !anamorphic )
		    goto LABEL_9;
		  if ( (unsigned __int8)sub_180006280(10LL, anamorphic) )
		  {
		    v7 = *(_OWORD *)&camera->fields._physicalParameters_k__BackingField.m_Iso;
		    v8 = *(_OWORD *)&camera->fields._physicalParameters_k__BackingField.m_BladeCount;
		    v14.m_Anamorphism = camera->fields._physicalParameters_k__BackingField.m_Anamorphism;
		    *(_OWORD *)&v14.m_Iso = v7;
		    *(_OWORD *)&v14.m_BladeCount = v8;
		    HG::Rendering::Runtime::HGPhysicalCamera::get_anamorphism(&v14, 0LL);
		  }
		  sub_1803369A0();
		  v15.m_X = sub_182F3EA70(v10, v9);
		  v15.m_Y = sub_182F3EA70(HIDWORD(*(_QWORD *)&camera->fields._taauRTSize_k__BackingField), v11);
		  return v15;
		}
		
		internal static TextureHandle BloomPass(HGRenderGraph renderGraph, HGCamera camera, HGSettingParameters settingParameters, Bloom bloom, bool enableAlpha, TextureHandle source, TextureHandle motionVector, TAAUQuality taauQuality, HGRenderPathInternal renderPath, ref BloomPSMaterials bloomPSMaterials, out Vector4 bloomBicubicParam) {
			bloomBicubicParam = default;
			return default;
		} // 0x0000000189B7E8B0-0x0000000189B7ED7C
		// TextureHandle BloomPass(HGRenderGraph, HGCamera, HGSettingParameters, Bloom, Boolean, TextureHandle, TextureHandle, TAAUQuality, HGRenderPathInternal, UberPostPassUtils+BloomPSMaterials ByRef, Vector4 ByRef)
		// Hidden C++ exception states: #wind=1
		TextureHandle *HG::Rendering::Runtime::UberPostPassUtils::BloomPass(
		        TextureHandle *__return_ptr retstr,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        HGSettingParameters *settingParameters,
		        Bloom *bloom,
		        bool enableAlpha,
		        TextureHandle *source,
		        TextureHandle *motionVector,
		        TAAUQuality__Enum taauQuality,
		        HGRenderPathInternal__Enum renderPath,
		        UberPostPassUtils_BloomPSMaterials *bloomPSMaterials,
		        Vector4 *bloomBicubicParam,
		        MethodInfo *method)
		{
		  TextureHandle *v16; // rdi
		  __int64 v17; // rdx
		  __int64 v18; // rcx
		  __int64 v19; // rdx
		  __int64 v20; // rcx
		  BOOL v21; // r15d
		  bool v22; // r12
		  __int64 v23; // rdx
		  __int64 v24; // rcx
		  Int32Enum__Enum v25; // r13d
		  HGRenderGraphDefaultResources *defaultResources; // rax
		  __int64 v27; // rdx
		  __int64 v28; // rcx
		  TextureHandle blackTexture_k__BackingField; // xmm6
		  ProfilingSampler *v30; // rax
		  __int128 v31; // xmm6
		  __int128 v32; // xmm7
		  UberPostPassUtils_BloomPassData *v33; // r15
		  __int64 v34; // rdx
		  __int64 v35; // rcx
		  __int64 v36; // r9
		  MonitorData *mipsUp; // rcx
		  __int64 v38; // rdx
		  __int64 v39; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // r14
		  UberPostPassUtils_BloomPassData *v42; // [rsp+80h] [rbp-F8h] BYREF
		  _QWORD v43[3]; // [rsp+88h] [rbp-F0h] BYREF
		  HGRenderGraphBuilder v44; // [rsp+A0h] [rbp-D8h] BYREF
		  TextureHandle v45; // [rsp+C0h] [rbp-B8h] BYREF
		  TextureHandle v46; // [rsp+D0h] [rbp-A8h] BYREF
		  HGRenderGraphBuilder v47; // [rsp+E0h] [rbp-98h] BYREF
		  Il2CppExceptionWrapper *v48; // [rsp+100h] [rbp-78h] BYREF
		  HGRenderGraphBuilder v49; // [rsp+110h] [rbp-68h] BYREF
		
		  v16 = retstr;
		  v42 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(2904, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2904, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v39, v38);
		    *(TextureHandle *)&v44.m_RenderPass = *motionVector;
		    v46 = *source;
		    *v16 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1065(
		              &v45,
		              Patch,
		              (Object *)renderGraph,
		              (Object *)camera,
		              (Object *)settingParameters,
		              (Object *)bloom,
		              enableAlpha,
		              &v46,
		              (TextureHandle *)&v44,
		              taauQuality,
		              renderPath,
		              bloomPSMaterials,
		              bloomBicubicParam,
		              0LL);
		  }
		  else
		  {
		    if ( !bloom )
		      sub_1800D8260(v18, v17);
		    if ( HG::Rendering::Runtime::Bloom::IsActive(bloom, 0LL) )
		    {
		      if ( !settingParameters )
		        sub_1800D8260(v20, v19);
		      v21 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		              settingParameters->fields._bloomEnabled_k__BackingField,
		              MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		    }
		    else
		    {
		      v21 = 0;
		    }
		    if ( !settingParameters )
		      sub_1800D8260(v20, v19);
		    v22 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		            settingParameters->fields._bloomUseComputeShader_k__BackingField,
		            MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		    v25 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		            (SettingParameter_1_System_Int32Enum_ *)settingParameters->fields._bloomQuality_k__BackingField,
		            MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::HyperGryphEngineCode::BloomQuality>::op_Implicit);
		    if ( !renderGraph )
		      sub_1800D8260(v24, v23);
		    defaultResources = HG::Rendering::RenderGraphModule::HGRenderGraph::get_defaultResources(renderGraph, 0LL);
		    if ( !defaultResources )
		      sub_1800D8260(v28, v27);
		    blackTexture_k__BackingField = defaultResources->fields._blackTexture_k__BackingField;
		    v45 = blackTexture_k__BackingField;
		    *bloomBicubicParam = 0LL;
		    if ( v21 )
		    {
		      v30 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		              (Int32Enum__Enum)0x99u,
		              MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		      HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		        &v44,
		        renderGraph,
		        (String *)"Bloom",
		        (Object **)&v42,
		        v30,
		        1,
		        ProfilingHGPass__Enum_None,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::UberPostPassUtils::BloomPassData>);
		      v47 = v44;
		      v43[0] = 0LL;
		      v43[1] = &v47;
		      try
		      {
		        v31 = *(_OWORD *)&v47.m_RenderPass;
		        v32 = *(_OWORD *)&v47.m_RenderGraph;
		        v33 = v42;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		        v46 = *motionVector;
		        *(TextureHandle *)&v44.m_RenderPass = *source;
		        *(_OWORD *)&v49.m_RenderPass = v31;
		        *(_OWORD *)&v49.m_RenderGraph = v32;
		        HG::Rendering::Runtime::UberPostPassUtils::PrepareBloomData(
		          v22,
		          renderGraph,
		          &v49,
		          v33,
		          bloom,
		          camera,
		          enableAlpha,
		          (TextureHandle *)&v44,
		          &v46,
		          renderPath,
		          taauQuality,
		          (BloomQuality__Enum)v25,
		          bloomPSMaterials,
		          bloomBicubicParam,
		          0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		        if ( v22 )
		          HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		            &v47,
		            (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->s_bloomCSRenderFunc,
		            0LL,
		            0,
		            MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::UberPostPassUtils::BloomPassData>);
		        else
		          HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		            &v47,
		            (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->s_bloomPSRenderFunc,
		            0LL,
		            0,
		            MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::UberPostPassUtils::BloomPassData>);
		        if ( !v42 )
		          sub_1800D8250(v35, v34);
		        mipsUp = (MonitorData *)v42->fields.mipsUp;
		        if ( !mipsUp )
		          sub_1800D8250(0LL, v34);
		        sub_1803C0830(mipsUp, &v44, 0LL, v36);
		        blackTexture_k__BackingField = *(TextureHandle *)&v44.m_RenderPass;
		        v45 = *(TextureHandle *)&v44.m_RenderPass;
		      }
		      catch ( Il2CppExceptionWrapper *v48 )
		      {
		        v43[0] = v48->ex;
		        sub_180268AE0(v43);
		        v16 = retstr;
		        blackTexture_k__BackingField = v45;
		        goto LABEL_19;
		      }
		      sub_180268AE0(v43);
		    }
		LABEL_19:
		    *v16 = blackTexture_k__BackingField;
		  }
		  return v16;
		}
		
		public static void PrepareColorGradingParametersFromEnvVolume(ref ColorGradingData data, HGCamera camera, int lutSize, Material lutBuilder2DMaterial) {} // 0x0000000189B845AC-0x0000000189B84CCC
		// Void PrepareColorGradingParametersFromEnvVolume(UberPostPassUtils+ColorGradingData ByRef, HGCamera, Int32, Material)
		void HG::Rendering::Runtime::UberPostPassUtils::PrepareColorGradingParametersFromEnvVolume(
		        UberPostPassUtils_ColorGradingData **data,
		        HGCamera *camera,
		        int32_t lutSize,
		        Material *lutBuilder2DMaterial,
		        MethodInfo *method)
		{
		  HGEnvironmentPhase *InterpolatedPhase; // rax
		  char *s_TonemappingACESmodified; // rdx
		  int *static_fields; // rcx
		  __int64 v12; // r8
		  HGColorGradingConfig *p_colorGradingConfig; // rdx
		  HGColorGradingConfig *v14; // rax
		  __int64 v15; // r9
		  HGColorGradingConfig *v16; // rcx
		  Vector4 shadows; // xmm1
		  __int128 v18; // xmm0
		  __int128 v19; // xmm1
		  __int128 v20; // xmm0
		  __int128 v21; // xmm1
		  __int128 v22; // xmm0
		  __int128 v23; // xmm1
		  __int128 v24; // xmm0
		  Vector4 v25; // xmm1
		  __int128 v26; // xmm1
		  __int128 v27; // xmm0
		  __int128 v28; // xmm1
		  __int128 v29; // xmm0
		  __int128 v30; // xmm1
		  __int128 v31; // xmm0
		  bool IsToneMappingActive; // al
		  Material *v33; // rdi
		  UberPostPassUtils_ColorGradingData *v34; // rdi
		  float WhiteBalanceTemperature; // xmm7_4
		  float WhiteBalanceTint; // xmm6_4
		  Vector3 *ColorBalanceCoeffs; // rax
		  UberPostPassUtils_ColorGradingData *v38; // rdi
		  float ColorAdjustmentsContrast; // xmm0_4
		  UberPostPassUtils_ColorGradingData *v40; // rdi
		  float ChannelMixerRedOutBlueIn; // xmm0_4
		  UberPostPassUtils_ColorGradingData *v42; // rdi
		  float ChannelMixerGreenOutBlueIn; // xmm0_4
		  UberPostPassUtils_ColorGradingData *v44; // rdi
		  float ChannelMixerBlueOutBlueIn; // xmm0_4
		  HGColorCurve *ColorCurves; // rax
		  HGRuntimeGrassQuery_Node *v47; // r8
		  Int32__Array **v48; // r9
		  __m128i v49; // xmm3
		  __m128i v50; // xmm2
		  HGRuntimeGrassQuery_Node *v51; // r8
		  Int32__Array **v52; // r9
		  __m128i v53; // xmm4
		  HGRuntimeGrassQuery_Node *v54; // r8
		  Int32__Array **v55; // r9
		  HGRuntimeGrassQuery_Node *v56; // r8
		  Int32__Array **v57; // r9
		  HGRuntimeGrassQuery_Node *v58; // r8
		  Int32__Array **v59; // r9
		  HGRuntimeGrassQuery_Node *v60; // r8
		  Int32__Array **v61; // r9
		  HGRuntimeGrassQuery_Node *v62; // r8
		  Int32__Array **v63; // r9
		  __m128i v64; // xmm5
		  HGRuntimeGrassQuery_Node *v65; // r8
		  Int32__Array **v66; // r9
		  __int64 v67; // xmm5_8
		  UberPostPassUtils_ColorGradingData *v68; // rdi
		  MethodInfo *v69; // r8
		  __m128i v70; // xmm1
		  Vector4 si128; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *limits; // [rsp+28h] [rbp-E0h]
		  MethodInfo *limitsa; // [rsp+28h] [rbp-E0h]
		  MethodInfo *limitsb; // [rsp+28h] [rbp-E0h]
		  MethodInfo *limitsc; // [rsp+28h] [rbp-E0h]
		  MethodInfo *limitsd; // [rsp+28h] [rbp-E0h]
		  MethodInfo *limitse; // [rsp+28h] [rbp-E0h]
		  MethodInfo *limitsf; // [rsp+28h] [rbp-E0h]
		  MethodInfo *limitsg; // [rsp+28h] [rbp-E0h]
		  MethodInfo *limitsh; // [rsp+28h] [rbp-E0h]
		  Color v82; // [rsp+38h] [rbp-D0h] BYREF
		  Color v83[6]; // [rsp+48h] [rbp-C0h] BYREF
		  HGColorGradingConfig colorGradingConfig; // [rsp+A8h] [rbp-60h] BYREF
		  HGColorCurve v85; // [rsp+218h] [rbp+110h] BYREF
		  int v86; // [rsp+268h] [rbp+160h] BYREF
		
		  sub_18033B9D0(&colorGradingConfig, 0LL, 368LL);
		  if ( !IFix::WrappersManagerImpl::IsPatched(2907, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		    InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(camera, 0LL);
		    if ( InterpolatedPhase )
		    {
		      v12 = 2LL;
		      p_colorGradingConfig = &colorGradingConfig;
		      v14 = &InterpolatedPhase->fields.colorGradingConfig;
		      v15 = 2LL;
		      v16 = v14;
		      do
		      {
		        *(_OWORD *)&p_colorGradingConfig->tonemappingMode = *(_OWORD *)&v16->tonemappingMode;
		        *(_OWORD *)&p_colorGradingConfig->colorLookupContribution = *(_OWORD *)&v16->colorLookupContribution;
		        *(_OWORD *)&p_colorGradingConfig->colorAdjustmentsEnabled = *(_OWORD *)&v16->colorAdjustmentsEnabled;
		        *(_OWORD *)&p_colorGradingConfig->colorAdjustmentsColorFilter.g = *(_OWORD *)&v16->colorAdjustmentsColorFilter.g;
		        *(_OWORD *)&p_colorGradingConfig->colorAdjustmentsSaturation = *(_OWORD *)&v16->colorAdjustmentsSaturation;
		        *(_OWORD *)&p_colorGradingConfig->channelMixerRedOutBlueIn = *(_OWORD *)&v16->channelMixerRedOutBlueIn;
		        *(_OWORD *)&p_colorGradingConfig->channelMixerBlueOutRedIn = *(_OWORD *)&v16->channelMixerBlueOutRedIn;
		        p_colorGradingConfig = (HGColorGradingConfig *)((char *)p_colorGradingConfig + 128);
		        shadows = v16->shadowsMidtonesHighlights.shadows;
		        v16 = (HGColorGradingConfig *)((char *)v16 + 128);
		        *(Vector4 *)&p_colorGradingConfig[-1].colorCurves.masterOverriding = shadows;
		        --v15;
		      }
		      while ( v15 );
		      *(_OWORD *)&p_colorGradingConfig->tonemappingMode = *(_OWORD *)&v16->tonemappingMode;
		      *(_OWORD *)&p_colorGradingConfig->colorLookupContribution = *(_OWORD *)&v16->colorLookupContribution;
		      *(_OWORD *)&p_colorGradingConfig->colorAdjustmentsEnabled = *(_OWORD *)&v16->colorAdjustmentsEnabled;
		      *(_OWORD *)&p_colorGradingConfig->colorAdjustmentsColorFilter.g = *(_OWORD *)&v16->colorAdjustmentsColorFilter.g;
		      *(_OWORD *)&p_colorGradingConfig->colorAdjustmentsSaturation = *(_OWORD *)&v16->colorAdjustmentsSaturation;
		      *(_OWORD *)&p_colorGradingConfig->channelMixerRedOutBlueIn = *(_OWORD *)&v16->channelMixerRedOutBlueIn;
		      v18 = *(_OWORD *)&v16->channelMixerBlueOutRedIn;
		      static_fields = &v86;
		      *(_OWORD *)&p_colorGradingConfig->channelMixerBlueOutRedIn = v18;
		      s_TonemappingACESmodified = (char *)*data;
		      do
		      {
		        v19 = *(_OWORD *)&v14->colorLookupContribution;
		        *(_OWORD *)static_fields = *(_OWORD *)&v14->tonemappingMode;
		        v20 = *(_OWORD *)&v14->colorAdjustmentsEnabled;
		        *((_OWORD *)static_fields + 1) = v19;
		        v21 = *(_OWORD *)&v14->colorAdjustmentsColorFilter.g;
		        *((_OWORD *)static_fields + 2) = v20;
		        v22 = *(_OWORD *)&v14->colorAdjustmentsSaturation;
		        *((_OWORD *)static_fields + 3) = v21;
		        v23 = *(_OWORD *)&v14->channelMixerRedOutBlueIn;
		        *((_OWORD *)static_fields + 4) = v22;
		        v24 = *(_OWORD *)&v14->channelMixerBlueOutRedIn;
		        *((_OWORD *)static_fields + 5) = v23;
		        v25 = v14->shadowsMidtonesHighlights.shadows;
		        v14 = (HGColorGradingConfig *)((char *)v14 + 128);
		        *((_OWORD *)static_fields + 6) = v24;
		        static_fields += 32;
		        *((Vector4 *)static_fields - 1) = v25;
		        --v12;
		      }
		      while ( v12 );
		      v26 = *(_OWORD *)&v14->colorLookupContribution;
		      *(_OWORD *)static_fields = *(_OWORD *)&v14->tonemappingMode;
		      v27 = *(_OWORD *)&v14->colorAdjustmentsEnabled;
		      *((_OWORD *)static_fields + 1) = v26;
		      v28 = *(_OWORD *)&v14->colorAdjustmentsColorFilter.g;
		      *((_OWORD *)static_fields + 2) = v27;
		      v29 = *(_OWORD *)&v14->colorAdjustmentsSaturation;
		      *((_OWORD *)static_fields + 3) = v28;
		      v30 = *(_OWORD *)&v14->channelMixerRedOutBlueIn;
		      *((_OWORD *)static_fields + 4) = v29;
		      v31 = *(_OWORD *)&v14->channelMixerBlueOutRedIn;
		      *((_OWORD *)static_fields + 5) = v30;
		      *((_OWORD *)static_fields + 6) = v31;
		      if ( s_TonemappingACESmodified )
		      {
		        *((_DWORD *)s_TonemappingACESmodified + 91) = v86;
		        static_fields = (int *)*data;
		        if ( *data )
		        {
		          *((_QWORD *)static_fields + 2) = lutBuilder2DMaterial;
		          sub_18002D1B0(
		            (HGRuntimeGrassQuery_Node *)(static_fields + 4),
		            (HGRuntimeGrassQuery_Node *)s_TonemappingACESmodified,
		            0LL,
		            0LL,
		            limits);
		          if ( *data )
		          {
		            static_fields = (int *)(*data)->fields.lutBuilder2DMaterial;
		            if ( static_fields )
		            {
		              UnityEngine::Material::SetShaderKeywords((Material *)static_fields, 0LL, 0LL);
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
		              IsToneMappingActive = HG::Rendering::Runtime::HGColorGradingConfig::IsToneMappingActive(
		                                      &colorGradingConfig,
		                                      0LL);
		              static_fields = (int *)*data;
		              if ( !IsToneMappingActive )
		                goto LABEL_12;
		              if ( !static_fields )
		                goto LABEL_39;
		              if ( static_fields[91] == 5 )
		              {
		                v33 = (Material *)*((_QWORD *)static_fields + 2);
		                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		                s_TonemappingACESmodified = (char *)TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_TonemappingACESmodified;
		              }
		              else
		              {
		LABEL_12:
		                if ( !static_fields )
		                  goto LABEL_39;
		                v33 = (Material *)*((_QWORD *)static_fields + 2);
		                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		                static_fields = (int *)TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields;
		                s_TonemappingACESmodified = (char *)*((_QWORD *)static_fields + 25);
		              }
		              if ( v33 )
		              {
		                UnityEngine::Material::EnableKeyword(v33, (String *)s_TonemappingACESmodified, 0LL);
		                if ( *data )
		                {
		                  (*data)->fields.lutSize = lutSize;
		                  v34 = *data;
		                  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
		                  WhiteBalanceTemperature = HG::Rendering::Runtime::HGColorGradingConfig::GetWhiteBalanceTemperature(
		                                              &colorGradingConfig,
		                                              0LL);
		                  WhiteBalanceTint = HG::Rendering::Runtime::HGColorGradingConfig::GetWhiteBalanceTint(
		                                       &colorGradingConfig,
		                                       0LL);
		                  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		                  ColorBalanceCoeffs = HG::Rendering::Runtime::UberPostPassUtils::GetColorBalanceCoeffs(
		                                         (Vector3 *)&v82,
		                                         WhiteBalanceTemperature,
		                                         WhiteBalanceTint,
		                                         0LL);
		                  static_fields = (int *)LODWORD(ColorBalanceCoeffs->z);
		                  if ( v34 )
		                  {
		                    *(_QWORD *)&v34->fields.lmsColorBalance.x = *(_QWORD *)&ColorBalanceCoeffs->x;
		                    LODWORD(v34->fields.lmsColorBalance.z) = (_DWORD)static_fields;
		                    v38 = *data;
		                    v82.r = HG::Rendering::Runtime::HGColorGradingConfig::GetColorAdjustmentsHueShift(
		                              &colorGradingConfig,
		                              0LL)
		                          / 360.0;
		                    v82.g = (float)(HG::Rendering::Runtime::HGColorGradingConfig::GetColorAdjustmentsSaturation(
		                                      &colorGradingConfig,
		                                      0LL)
		                                  / 100.0)
		                          + 1.0;
		                    ColorAdjustmentsContrast = HG::Rendering::Runtime::HGColorGradingConfig::GetColorAdjustmentsContrast(
		                                                 &colorGradingConfig,
		                                                 0LL);
		                    v82.a = 0.0;
		                    v82.b = (float)(ColorAdjustmentsContrast / 100.0) + 1.0;
		                    if ( v38 )
		                    {
		                      v38->fields.hueSatCon = (Vector4)v82;
		                      v40 = *data;
		                      v82.r = HG::Rendering::Runtime::HGColorGradingConfig::GetChannelMixerRedOutRedIn(
		                                &colorGradingConfig,
		                                0LL)
		                            / 100.0;
		                      v82.g = HG::Rendering::Runtime::HGColorGradingConfig::GetChannelMixerRedOutGreenIn(
		                                &colorGradingConfig,
		                                0LL)
		                            / 100.0;
		                      ChannelMixerRedOutBlueIn = HG::Rendering::Runtime::HGColorGradingConfig::GetChannelMixerRedOutBlueIn(
		                                                   &colorGradingConfig,
		                                                   0LL);
		                      v82.a = 0.0;
		                      v82.b = ChannelMixerRedOutBlueIn / 100.0;
		                      if ( v40 )
		                      {
		                        v40->fields.channelMixerR = (Vector4)v82;
		                        v42 = *data;
		                        v82.r = HG::Rendering::Runtime::HGColorGradingConfig::GetChannelMixerGreenOutRedIn(
		                                  &colorGradingConfig,
		                                  0LL)
		                              / 100.0;
		                        v82.g = HG::Rendering::Runtime::HGColorGradingConfig::GetChannelMixerGreenOutGreenIn(
		                                  &colorGradingConfig,
		                                  0LL)
		                              / 100.0;
		                        ChannelMixerGreenOutBlueIn = HG::Rendering::Runtime::HGColorGradingConfig::GetChannelMixerGreenOutBlueIn(
		                                                       &colorGradingConfig,
		                                                       0LL);
		                        v82.a = 0.0;
		                        v82.b = ChannelMixerGreenOutBlueIn / 100.0;
		                        if ( v42 )
		                        {
		                          v42->fields.channelMixerG = (Vector4)v82;
		                          v44 = *data;
		                          v82.r = HG::Rendering::Runtime::HGColorGradingConfig::GetChannelMixerBlueOutRedIn(
		                                    &colorGradingConfig,
		                                    0LL)
		                                / 100.0;
		                          v82.g = HG::Rendering::Runtime::HGColorGradingConfig::GetChannelMixerBlueOutGreenIn(
		                                    &colorGradingConfig,
		                                    0LL)
		                                / 100.0;
		                          ChannelMixerBlueOutBlueIn = HG::Rendering::Runtime::HGColorGradingConfig::GetChannelMixerBlueOutBlueIn(
		                                                        &colorGradingConfig,
		                                                        0LL);
		                          v82.a = 0.0;
		                          v82.b = ChannelMixerBlueOutBlueIn / 100.0;
		                          if ( v44 )
		                          {
		                            v44->fields.channelMixerB = (Vector4)v82;
		                            s_TonemappingACESmodified = (char *)*data;
		                            if ( *data )
		                            {
		                              HG::Rendering::Runtime::UberPostPassUtils::ComputeShadowsMidtonesHighlightsFromEnvVolume(
		                                &colorGradingConfig,
		                                (Vector4 *)(s_TonemappingACESmodified + 120),
		                                (Vector4 *)(s_TonemappingACESmodified + 136),
		                                (Vector4 *)(s_TonemappingACESmodified + 152),
		                                (Vector4 *)(s_TonemappingACESmodified + 168),
		                                0LL);
		                              s_TonemappingACESmodified = (char *)*data;
		                              if ( *data )
		                              {
		                                HG::Rendering::Runtime::UberPostPassUtils::ComputeLiftGammaGainFromEnvVolume(
		                                  &colorGradingConfig,
		                                  (Vector4 *)(s_TonemappingACESmodified + 184),
		                                  (Vector4 *)(s_TonemappingACESmodified + 200),
		                                  (Vector4 *)(s_TonemappingACESmodified + 216),
		                                  0LL);
		                                s_TonemappingACESmodified = (char *)*data;
		                                if ( *data )
		                                {
		                                  HG::Rendering::Runtime::UberPostPassUtils::ComputeSplitToningFromEnvVolume(
		                                    &colorGradingConfig,
		                                    (Vector4 *)(s_TonemappingACESmodified + 232),
		                                    (Vector4 *)(s_TonemappingACESmodified + 248),
		                                    0LL);
		                                  ColorCurves = HG::Rendering::Runtime::HGColorGradingConfig::GetColorCurves(
		                                                  &v85,
		                                                  &colorGradingConfig,
		                                                  0LL);
		                                  static_fields = (int *)*data;
		                                  v49 = *(__m128i *)&ColorCurves->green;
		                                  v50 = *(__m128i *)&ColorCurves->hueVsHue;
		                                  if ( *data )
		                                  {
		                                    *((_QWORD *)static_fields + 34) = ColorCurves->master;
		                                    sub_18002D1B0(
		                                      (HGRuntimeGrassQuery_Node *)(static_fields + 68),
		                                      (HGRuntimeGrassQuery_Node *)s_TonemappingACESmodified,
		                                      v47,
		                                      v48,
		                                      limitsa);
		                                    static_fields = (int *)*data;
		                                    if ( *data )
		                                    {
		                                      *((_QWORD *)static_fields + 35) = _mm_srli_si128(v53, 8).m128i_u64[0];
		                                      sub_18002D1B0(
		                                        (HGRuntimeGrassQuery_Node *)(static_fields + 70),
		                                        (HGRuntimeGrassQuery_Node *)s_TonemappingACESmodified,
		                                        v51,
		                                        v52,
		                                        limitsb);
		                                      static_fields = (int *)*data;
		                                      if ( *data )
		                                      {
		                                        *((_QWORD *)static_fields + 36) = v49.m128i_i64[0];
		                                        sub_18002D1B0(
		                                          (HGRuntimeGrassQuery_Node *)static_fields + 4,
		                                          (HGRuntimeGrassQuery_Node *)s_TonemappingACESmodified,
		                                          v54,
		                                          v55,
		                                          limitsc);
		                                        static_fields = (int *)*data;
		                                        if ( *data )
		                                        {
		                                          *((_QWORD *)static_fields + 37) = _mm_srli_si128(v49, 8).m128i_u64[0];
		                                          sub_18002D1B0(
		                                            (HGRuntimeGrassQuery_Node *)(static_fields + 74),
		                                            (HGRuntimeGrassQuery_Node *)s_TonemappingACESmodified,
		                                            v56,
		                                            v57,
		                                            limitsd);
		                                          static_fields = (int *)*data;
		                                          if ( *data )
		                                          {
		                                            *((_QWORD *)static_fields + 38) = v50.m128i_i64[0];
		                                            sub_18002D1B0(
		                                              (HGRuntimeGrassQuery_Node *)(static_fields + 76),
		                                              (HGRuntimeGrassQuery_Node *)s_TonemappingACESmodified,
		                                              v58,
		                                              v59,
		                                              limitse);
		                                            static_fields = (int *)*data;
		                                            if ( *data )
		                                            {
		                                              *((_QWORD *)static_fields + 39) = _mm_srli_si128(v50, 8).m128i_u64[0];
		                                              sub_18002D1B0(
		                                                (HGRuntimeGrassQuery_Node *)(static_fields + 78),
		                                                (HGRuntimeGrassQuery_Node *)s_TonemappingACESmodified,
		                                                v60,
		                                                v61,
		                                                limitsf);
		                                              static_fields = (int *)*data;
		                                              if ( *data )
		                                              {
		                                                *((_QWORD *)static_fields + 40) = _mm_srli_si128(v64, 8).m128i_u64[0];
		                                                sub_18002D1B0(
		                                                  (HGRuntimeGrassQuery_Node *)(static_fields + 80),
		                                                  (HGRuntimeGrassQuery_Node *)s_TonemappingACESmodified,
		                                                  v62,
		                                                  v63,
		                                                  limitsg);
		                                                static_fields = (int *)*data;
		                                                if ( *data )
		                                                {
		                                                  *((_QWORD *)static_fields + 41) = v67;
		                                                  sub_18002D1B0(
		                                                    (HGRuntimeGrassQuery_Node *)(static_fields + 82),
		                                                    (HGRuntimeGrassQuery_Node *)s_TonemappingACESmodified,
		                                                    v65,
		                                                    v66,
		                                                    limitsh);
		                                                  v68 = *data;
		                                                  v82 = *HG::Rendering::Runtime::HGColorGradingConfig::GetColorAdjustmentsColorFilter(
		                                                           &v82,
		                                                           &colorGradingConfig,
		                                                           0LL);
		                                                  v82 = *(Color *)sub_183C6CBA0(v83, &v82);
		                                                  v70 = _mm_loadu_si128((const __m128i *)UnityEngine::Color::op_Implicit(
		                                                                                           v83,
		                                                                                           (Vector4 *)&v82,
		                                                                                           v69));
		                                                  if ( v68 )
		                                                  {
		                                                    si128 = (Vector4)_mm_load_si128((const __m128i *)&xmmword_18B9593A0);
		                                                    v68->fields.colorFilter = (Vector4)v70;
		                                                    if ( *data )
		                                                    {
		                                                      (*data)->fields.miscParams = si128;
		                                                      return;
		                                                    }
		                                                  }
		                                                }
		                                              }
		                                            }
		                                          }
		                                        }
		                                      }
		                                    }
		                                  }
		                                }
		                              }
		                            }
		                          }
		                        }
		                      }
		                    }
		                  }
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_39:
		    sub_1800D8260(static_fields, s_TonemappingACESmodified);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2907, 0LL);
		  if ( !Patch )
		    goto LABEL_39;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1069(
		    Patch,
		    data,
		    (Object *)camera,
		    lutSize,
		    (Object *)lutBuilder2DMaterial,
		    0LL);
		}
		
		private static bool IsAnyColorCurveDirty(ref ColorGradingData passData) => default; // 0x0000000189B82978-0x0000000189B82AF8
		// Boolean IsAnyColorCurveDirty(UberPostPassUtils+ColorGradingData ByRef)
		bool HG::Rendering::Runtime::UberPostPassUtils::IsAnyColorCurveDirty(
		        UberPostPassUtils_ColorGradingData **passData,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  TextureCurve *masterCurve; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2912, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2912, 0LL);
		    if ( !Patch )
		      goto LABEL_28;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1070(Patch, passData, 0LL);
		  }
		  else
		  {
		    if ( !*passData )
		      goto LABEL_28;
		    masterCurve = (*passData)->fields.masterCurve;
		    if ( !masterCurve )
		      goto LABEL_28;
		    if ( !UnityEngine::Rendering::TextureCurve::IsTextureCurveDirty(masterCurve, 0LL) )
		    {
		      if ( !*passData )
		        goto LABEL_28;
		      masterCurve = (*passData)->fields.redCurve;
		      if ( !masterCurve )
		        goto LABEL_28;
		      if ( !UnityEngine::Rendering::TextureCurve::IsTextureCurveDirty(masterCurve, 0LL) )
		      {
		        if ( !*passData )
		          goto LABEL_28;
		        masterCurve = (*passData)->fields.greenCurve;
		        if ( !masterCurve )
		          goto LABEL_28;
		        if ( !UnityEngine::Rendering::TextureCurve::IsTextureCurveDirty(masterCurve, 0LL) )
		        {
		          if ( !*passData )
		            goto LABEL_28;
		          masterCurve = (*passData)->fields.blueCurve;
		          if ( !masterCurve )
		            goto LABEL_28;
		          if ( !UnityEngine::Rendering::TextureCurve::IsTextureCurveDirty(masterCurve, 0LL) )
		          {
		            if ( !*passData )
		              goto LABEL_28;
		            masterCurve = (*passData)->fields.hueVsHueCurve;
		            if ( !masterCurve )
		              goto LABEL_28;
		            if ( !UnityEngine::Rendering::TextureCurve::IsTextureCurveDirty(masterCurve, 0LL) )
		            {
		              if ( !*passData )
		                goto LABEL_28;
		              masterCurve = (*passData)->fields.hueVsSatCurve;
		              if ( !masterCurve )
		                goto LABEL_28;
		              if ( !UnityEngine::Rendering::TextureCurve::IsTextureCurveDirty(masterCurve, 0LL) )
		              {
		                if ( !*passData )
		                  goto LABEL_28;
		                masterCurve = (*passData)->fields.satVsSatCurve;
		                if ( !masterCurve )
		                  goto LABEL_28;
		                if ( !UnityEngine::Rendering::TextureCurve::IsTextureCurveDirty(masterCurve, 0LL) )
		                {
		                  if ( *passData )
		                  {
		                    masterCurve = (*passData)->fields.lumVsSatCurve;
		                    if ( masterCurve )
		                      return UnityEngine::Rendering::TextureCurve::IsTextureCurveDirty(masterCurve, 0LL);
		                  }
		LABEL_28:
		                  sub_1800D8260(masterCurve, v3);
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		    return 1;
		  }
		}
		
		private static Vector3 GetColorBalanceCoeffs(float temperature, float tint) => default; // 0x0000000189B82534-0x0000000189B82680
		// Vector3 GetColorBalanceCoeffs(Single, Single)
		Vector3 *HG::Rendering::Runtime::UberPostPassUtils::GetColorBalanceCoeffs(
		        Vector3 *__return_ptr retstr,
		        float temperature,
		        float tint,
		        MethodInfo *method)
		{
		  float v5; // xmm0_4
		  float v6; // xmm6_4
		  Vector3 *v7; // rax
		  float v8; // xmm2_4
		  float v9; // xmm1_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  Vector3 *v13; // rax
		  __int64 v14; // xmm0_8
		  Vector3 v16; // [rsp+40h] [rbp-38h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2908, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2908, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v12, v11);
		    v13 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_690(&v16, Patch, temperature, tint, 0LL);
		    v14 = *(_QWORD *)&v13->x;
		    *(float *)&v13 = v13->z;
		    *(_QWORD *)&retstr->x = v14;
		    LODWORD(retstr->z) = (_DWORD)v13;
		  }
		  else
		  {
		    if ( (float)(temperature / 65.0) >= 0.0 )
		      v5 = 0.050000001;
		    else
		      v5 = 0.1;
		    v6 = 0.31270999 - (float)(v5 * (float)(temperature / 65.0));
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::ColorUtils);
		    v7 = UnityEngine::Rendering::ColorUtils::CIExyToLMS(
		           &v16,
		           v6,
		           (float)((float)((float)(v6 * 2.8699999) - (float)((float)(v6 * 3.0) * v6)) - 0.27509508)
		         + (float)((float)(tint / 65.0) * 0.050000001),
		           0LL);
		    v8 = 1.08728 / v7->z;
		    v9 = 1.0354199 / COERCE_FLOAT(HIDWORD(*(_QWORD *)&v7->x));
		    retstr->x = 0.94923699 / COERCE_FLOAT(*(_QWORD *)&v7->x);
		    retstr->y = v9;
		    retstr->z = v8;
		  }
		  return retstr;
		}
		
		private static void ComputeShadowsMidtonesHighlightsFromEnvVolume(ref HGColorGradingConfig colorGradingConfig, out Vector4 shadows, out Vector4 midtones, out Vector4 highlights, out Vector4 limits) {
			shadows = default;
			midtones = default;
			highlights = default;
			limits = default;
		} // 0x0000000189B7FB30-0x0000000189B7FE04
		// Void ComputeShadowsMidtonesHighlightsFromEnvVolume(HGColorGradingConfig ByRef, Vector4 ByRef, Vector4 ByRef, Vector4 ByRef, Vector4 ByRef)
		void HG::Rendering::Runtime::UberPostPassUtils::ComputeShadowsMidtonesHighlightsFromEnvVolume(
		        HGColorGradingConfig *colorGradingConfig,
		        Vector4 *shadows,
		        Vector4 *midtones,
		        Vector4 *highlights,
		        Vector4 *limits,
		        MethodInfo *method)
		{
		  HGShadowsMidtonesHighlights *ShadowsMidtonesHighlights; // rax
		  Vector4 v11; // xmm10
		  Vector4 v12; // xmm11
		  __m128 v13; // xmm7
		  float v14; // xmm2_4
		  MethodInfo *v15; // rdx
		  float v16; // xmm6_4
		  float v17; // xmm1_4
		  float v18; // xmm1_4
		  float v19; // xmm2_4
		  MethodInfo *v20; // rdx
		  float v21; // xmm1_4
		  float v22; // xmm1_4
		  float v23; // xmm2_4
		  MethodInfo *v24; // rdx
		  float v25; // xmm6_4
		  __int64 v26; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  Vector4 v28; // [rsp+40h] [rbp-108h]
		  HGShadowsMidtonesHighlights v29[2]; // [rsp+A0h] [rbp-A8h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2909, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2909, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v26);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1066(
		      Patch,
		      colorGradingConfig,
		      shadows,
		      midtones,
		      highlights,
		      limits,
		      0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
		    ShadowsMidtonesHighlights = HG::Rendering::Runtime::HGColorGradingConfig::GetShadowsMidtonesHighlights(
		                                  v29,
		                                  colorGradingConfig,
		                                  0LL);
		    v11 = ShadowsMidtonesHighlights->midtones;
		    v12 = ShadowsMidtonesHighlights->highlights;
		    v13 = *(__m128 *)&ShadowsMidtonesHighlights->shadowsStart;
		    *shadows = ShadowsMidtonesHighlights->shadows;
		    shadows->x = UnityEngine::Mathf::GammaToLinearSpace(shadows->x, 0LL);
		    shadows->y = UnityEngine::Mathf::GammaToLinearSpace(shadows->y, 0LL);
		    v14 = UnityEngine::Mathf::GammaToLinearSpace(shadows->z, 0LL);
		    v16 = 1.0;
		    if ( UnityEngine::Mathf::Sign(shadows->w, v15) >= 0.0 )
		      v17 = 4.0;
		    else
		      v17 = 1.0;
		    v18 = v17 * shadows->w;
		    shadows->x = fmaxf(v18 + shadows->x, 0.0);
		    shadows->y = fmaxf(v18 + shadows->y, 0.0);
		    shadows->w = 0.0;
		    shadows->z = fmaxf(v14 + v18, 0.0);
		    *midtones = v11;
		    midtones->x = UnityEngine::Mathf::GammaToLinearSpace(midtones->x, 0LL);
		    midtones->y = UnityEngine::Mathf::GammaToLinearSpace(midtones->y, 0LL);
		    v19 = UnityEngine::Mathf::GammaToLinearSpace(midtones->z, 0LL);
		    if ( UnityEngine::Mathf::Sign(midtones->w, v20) >= 0.0 )
		      v21 = 4.0;
		    else
		      v21 = 1.0;
		    v22 = v21 * midtones->w;
		    midtones->x = fmaxf(v22 + midtones->x, 0.0);
		    midtones->y = fmaxf(v22 + midtones->y, 0.0);
		    midtones->w = 0.0;
		    midtones->z = fmaxf(v19 + v22, 0.0);
		    *highlights = v12;
		    highlights->x = UnityEngine::Mathf::GammaToLinearSpace(highlights->x, 0LL);
		    highlights->y = UnityEngine::Mathf::GammaToLinearSpace(highlights->y, 0LL);
		    v23 = UnityEngine::Mathf::GammaToLinearSpace(highlights->z, 0LL);
		    if ( UnityEngine::Mathf::Sign(highlights->w, v24) >= 0.0 )
		      v16 = 4.0;
		    v25 = v16 * highlights->w;
		    highlights->x = fmaxf(v25 + highlights->x, 0.0);
		    highlights->y = fmaxf(v25 + highlights->y, 0.0);
		    highlights->w = 0.0;
		    LODWORD(v28.x) = v13.m128_i32[0];
		    LODWORD(v28.y) = _mm_shuffle_ps(v13, v13, 85).m128_u32[0];
		    LODWORD(v28.z) = _mm_shuffle_ps(v13, v13, 170).m128_u32[0];
		    LODWORD(v28.w) = _mm_shuffle_ps(v13, v13, 255).m128_u32[0];
		    highlights->z = fmaxf(v23 + v25, 0.0);
		    *limits = v28;
		  }
		}
		
		private static void ComputeLiftGammaGainFromEnvVolume(ref HGColorGradingConfig colorGradingConfig, out Vector4 lift, out Vector4 gamma, out Vector4 gain) {
			lift = default;
			gamma = default;
			gain = default;
		} // 0x0000000189B7F7AC-0x0000000189B7FB30
		// Void ComputeLiftGammaGainFromEnvVolume(HGColorGradingConfig ByRef, Vector4 ByRef, Vector4 ByRef, Vector4 ByRef)
		void HG::Rendering::Runtime::UberPostPassUtils::ComputeLiftGammaGainFromEnvVolume(
		        HGColorGradingConfig *colorGradingConfig,
		        Vector4 *lift,
		        Vector4 *gamma,
		        Vector4 *gain,
		        MethodInfo *method)
		{
		  HGLiftGammaGain *LiftGammaGain; // rax
		  Vector4 v10; // xmm7
		  Vector4 v11; // xmm11
		  MethodInfo *v12; // r8
		  __m128 v13; // xmm6
		  float v14; // xmm2_4
		  float v15; // xmm1_4
		  float v16; // xmm0_4
		  float v17; // xmm0_4
		  MethodInfo *v18; // r8
		  __m128 v19; // xmm3
		  float v20; // xmm0_4
		  float v21; // xmm1_4
		  MethodInfo *v22; // r8
		  __m128 v23; // xmm2
		  float v24; // xmm0_4
		  float x; // xmm1_4
		  float v26; // xmm1_4
		  float y; // xmm0_4
		  float v28; // xmm0_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v30; // rdx
		  __int64 v31; // rcx
		  Vector4 v32; // [rsp+38h] [rbp-71h] BYREF
		  Color v33[4]; // [rsp+48h] [rbp-61h] BYREF
		  HGLiftGammaGain v34[2]; // [rsp+90h] [rbp-19h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2910, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2910, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v31, v30);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1067(Patch, colorGradingConfig, lift, gamma, gain, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
		    LiftGammaGain = HG::Rendering::Runtime::HGColorGradingConfig::GetLiftGammaGain(v34, colorGradingConfig, 0LL);
		    v10 = LiftGammaGain->gamma;
		    v11 = LiftGammaGain->gain;
		    *lift = LiftGammaGain->lift;
		    lift->x = UnityEngine::Mathf::GammaToLinearSpace(lift->x, 0LL) * 0.15000001;
		    lift->y = UnityEngine::Mathf::GammaToLinearSpace(lift->y, 0LL) * 0.15000001;
		    lift->z = UnityEngine::Mathf::GammaToLinearSpace(lift->z, 0LL) * 0.15000001;
		    v32 = *lift;
		    v13 = (__m128)_mm_loadu_si128((const __m128i *)UnityEngine::Color::op_Implicit(v33, &v32, v12));
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::ColorUtils);
		    v14 = (float)((float)(v13.m128_f32[0] * 0.2126729) + (float)(_mm_shuffle_ps(v13, v13, 85).m128_f32[0] * 0.7151522))
		        + (float)(_mm_shuffle_ps(v13, v13, 170).m128_f32[0] * 0.072175004);
		    v15 = (float)(lift->y - v14) + lift->w;
		    lift->x = (float)(lift->x - v14) + lift->w;
		    v16 = lift->z - v14;
		    lift->y = v15;
		    v17 = v16 + lift->w;
		    lift->w = 0.0;
		    lift->z = v17;
		    *gamma = v10;
		    gamma->x = UnityEngine::Mathf::GammaToLinearSpace(gamma->x, 0LL) * 0.80000001;
		    gamma->y = UnityEngine::Mathf::GammaToLinearSpace(gamma->y, 0LL) * 0.80000001;
		    gamma->z = UnityEngine::Mathf::GammaToLinearSpace(gamma->z, 0LL) * 0.80000001;
		    v32 = *gamma;
		    v19 = (__m128)_mm_loadu_si128((const __m128i *)UnityEngine::Color::op_Implicit(v33, &v32, v18));
		    v20 = gamma->w + 1.0;
		    v19.m128_f32[0] = (float)((float)(v19.m128_f32[0] * 0.2126729)
		                            + (float)(_mm_shuffle_ps(v19, v19, 85).m128_f32[0] * 0.7151522))
		                    + (float)(_mm_shuffle_ps(v19, v19, 170).m128_f32[0] * 0.072175004);
		    gamma->w = v20;
		    gamma->x = 1.0 / fmaxf((float)(gamma->x - v19.m128_f32[0]) + v20, 0.001);
		    gamma->y = 1.0 / fmaxf((float)(gamma->y - v19.m128_f32[0]) + gamma->w, 0.001);
		    v21 = (float)(gamma->z - v19.m128_f32[0]) + gamma->w;
		    gamma->w = 0.0;
		    gamma->z = 1.0 / fmaxf(v21, 0.001);
		    *gain = v11;
		    gain->x = UnityEngine::Mathf::GammaToLinearSpace(gain->x, 0LL) * 0.80000001;
		    gain->y = UnityEngine::Mathf::GammaToLinearSpace(gain->y, 0LL) * 0.80000001;
		    v19.m128_f32[0] = UnityEngine::Mathf::GammaToLinearSpace(gain->z, 0LL) * 0.80000001;
		    gain->z = v19.m128_f32[0];
		    v32 = *gain;
		    v23 = (__m128)_mm_loadu_si128((const __m128i *)UnityEngine::Color::op_Implicit(v33, &v32, v22));
		    v24 = gain->w + 1.0;
		    v23.m128_f32[0] = (float)((float)(v23.m128_f32[0] * 0.2126729)
		                            + (float)(_mm_shuffle_ps(v23, v23, 85).m128_f32[0] * 0.7151522))
		                    + (float)(_mm_shuffle_ps(v23, v23, 170).m128_f32[0] * 0.072175004);
		    x = gain->x;
		    gain->w = v24;
		    v26 = (float)(x - v23.m128_f32[0]) + v24;
		    y = gain->y;
		    v19.m128_f32[0] = (float)(v19.m128_f32[0] - v23.m128_f32[0]) + gain->w;
		    gain->x = v26;
		    LODWORD(gain->z) = v19.m128_i32[0];
		    v28 = (float)(y - v23.m128_f32[0]) + gain->w;
		    gain->w = 0.0;
		    gain->y = v28;
		  }
		}
		
		private static void ComputeSplitToningFromEnvVolume(ref HGColorGradingConfig colorGradingCfg, out Vector4 shadows, out Vector4 highlights) {
			shadows = default;
			highlights = default;
		} // 0x0000000189B7FE04-0x0000000189B7FEF8
		// Void ComputeSplitToningFromEnvVolume(HGColorGradingConfig ByRef, Vector4 ByRef, Vector4 ByRef)
		void HG::Rendering::Runtime::UberPostPassUtils::ComputeSplitToningFromEnvVolume(
		        HGColorGradingConfig *colorGradingCfg,
		        Vector4 *shadows,
		        Vector4 *highlights,
		        MethodInfo *method)
		{
		  MethodInfo *v7; // r8
		  MethodInfo *v8; // r8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  Color v12; // [rsp+30h] [rbp-28h] BYREF
		  Color v13; // [rsp+40h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2911, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2911, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1068(Patch, colorGradingCfg, shadows, highlights, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
		    v12 = *HG::Rendering::Runtime::HGColorGradingConfig::GetSplitToningShadows(&v12, colorGradingCfg, 0LL);
		    *(__m128i *)shadows = _mm_loadu_si128((const __m128i *)UnityEngine::Color::op_Implicit(&v13, (Vector4 *)&v12, v7));
		    v12 = *HG::Rendering::Runtime::HGColorGradingConfig::GetSplitToningHighlights(&v13, colorGradingCfg, 0LL);
		    *(__m128i *)highlights = _mm_loadu_si128((const __m128i *)UnityEngine::Color::op_Implicit(&v13, (Vector4 *)&v12, v8));
		    shadows->w = HG::Rendering::Runtime::HGColorGradingConfig::GetSplitToningBalance(colorGradingCfg, 0LL) / 100.0;
		    highlights->w = 0.0;
		  }
		}
		
		public static void PrepareLutBuilderMaterial(ColorGradingData data, Material lutBuilderMaterial) {} // 0x0000000189B85A68-0x0000000189B860F0
		// Void PrepareLutBuilderMaterial(UberPostPassUtils+ColorGradingData, Material)
		void HG::Rendering::Runtime::UberPostPassUtils::PrepareLutBuilderMaterial(
		        UberPostPassUtils_ColorGradingData *data,
		        Material *lutBuilderMaterial,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  TextureCurve *masterCurve; // rcx
		  int32_t lutSize; // esi
		  TextureHandle logLut; // xmm6
		  int32_t OutputTexture; // r14d
		  Texture *v10; // rax
		  __m128i v11; // xmm1
		  int32_t Size; // edx
		  int32_t Lut_Params; // edx
		  MethodInfo *v14; // r8
		  int32_t v15; // r10d
		  HGShaderIDs__StaticFields *static_fields; // rcx
		  HGShaderIDs__StaticFields *v17; // rcx
		  HGShaderIDs__StaticFields *v18; // rcx
		  HGShaderIDs__StaticFields *v19; // rcx
		  HGShaderIDs__StaticFields *v20; // rcx
		  HGShaderIDs__StaticFields *v21; // rcx
		  HGShaderIDs__StaticFields *v22; // rcx
		  HGShaderIDs__StaticFields *v23; // rcx
		  HGShaderIDs__StaticFields *v24; // rcx
		  HGShaderIDs__StaticFields *v25; // rcx
		  HGShaderIDs__StaticFields *v26; // rcx
		  HGShaderIDs__StaticFields *v27; // rcx
		  HGShaderIDs__StaticFields *v28; // rcx
		  HGShaderIDs__StaticFields *v29; // rcx
		  int32_t CurveMaster; // esi
		  Texture *Texture; // rax
		  int32_t CurveRed; // esi
		  Texture *v33; // rax
		  int32_t CurveGreen; // esi
		  Texture *v35; // rax
		  int32_t CurveBlue; // esi
		  Texture *v37; // rax
		  int32_t CurveHueVsHue; // esi
		  Texture *v39; // rax
		  int32_t CurveHueVsSat; // esi
		  Texture *v41; // rax
		  int32_t CurveLumVsSat; // esi
		  Texture *v43; // rax
		  int32_t CurveSatVsSat; // esi
		  Texture *v45; // rax
		  HGShaderIDs__StaticFields *v46; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 colorFilter; // [rsp+20h] [rbp-30h] BYREF
		  Vector4 v49; // [rsp+30h] [rbp-20h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2913, 0LL) )
		  {
		    if ( data )
		    {
		      lutSize = data->fields.lutSize;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		      logLut = data->fields.logLut;
		      OutputTexture = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_OutputTexture;
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		      colorFilter = (Vector4)logLut;
		      v10 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit((TextureHandle *)&colorFilter, 0LL);
		      if ( lutBuilderMaterial )
		      {
		        UnityEngine::Material::SetTextureImpl(lutBuilderMaterial, OutputTexture, v10, 0LL);
		        v11 = _mm_cvtsi32_si128(data->fields.lutSize);
		        *(_QWORD *)&colorFilter.z = 0LL;
		        Size = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_Size;
		        LODWORD(colorFilter.x) = _mm_cvtepi32_ps(v11).m128_u32[0];
		        colorFilter.y = 1.0 / (float)(colorFilter.x - 1.0);
		        UnityEngine::Material::SetVector(lutBuilderMaterial, Size, &colorFilter, 0LL);
		        Lut_Params = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_Lut_Params;
		        colorFilter.x = (float)lutSize;
		        colorFilter.z = 0.5 / (float)lutSize;
		        colorFilter.y = 0.5 / (float)(lutSize * lutSize);
		        colorFilter.w = colorFilter.x / (float)(colorFilter.x - 1.0);
		        UnityEngine::Material::SetVector(lutBuilderMaterial, Lut_Params, &colorFilter, 0LL);
		        *(_QWORD *)&colorFilter.x = *(_QWORD *)&data->fields.lmsColorBalance.x;
		        colorFilter.z = data->fields.lmsColorBalance.z;
		        colorFilter = *UnityEngine::Vector4::op_Implicit(&v49, (Vector3 *)&colorFilter, v14);
		        UnityEngine::Material::SetVector(lutBuilderMaterial, v15, &colorFilter, 0LL);
		        static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		        colorFilter = data->fields.colorFilter;
		        UnityEngine::Material::SetVector(lutBuilderMaterial, static_fields->_ColorFilter, &colorFilter, 0LL);
		        v17 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		        colorFilter = data->fields.channelMixerR;
		        UnityEngine::Material::SetVector(lutBuilderMaterial, v17->_ChannelMixerRed, &colorFilter, 0LL);
		        v18 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		        colorFilter = data->fields.channelMixerG;
		        UnityEngine::Material::SetVector(lutBuilderMaterial, v18->_ChannelMixerGreen, &colorFilter, 0LL);
		        v19 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		        colorFilter = data->fields.channelMixerB;
		        UnityEngine::Material::SetVector(lutBuilderMaterial, v19->_ChannelMixerBlue, &colorFilter, 0LL);
		        v20 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		        colorFilter = data->fields.hueSatCon;
		        UnityEngine::Material::SetVector(lutBuilderMaterial, v20->_HueSatCon, &colorFilter, 0LL);
		        v21 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		        colorFilter = data->fields.lift;
		        UnityEngine::Material::SetVector(lutBuilderMaterial, v21->_Lift, &colorFilter, 0LL);
		        v22 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		        colorFilter = data->fields.gamma;
		        UnityEngine::Material::SetVector(lutBuilderMaterial, v22->_Gamma, &colorFilter, 0LL);
		        v23 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		        colorFilter = data->fields.gain;
		        UnityEngine::Material::SetVector(lutBuilderMaterial, v23->_Gain, &colorFilter, 0LL);
		        v24 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		        colorFilter = data->fields.shadows;
		        UnityEngine::Material::SetVector(lutBuilderMaterial, v24->_Shadows, &colorFilter, 0LL);
		        v25 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		        colorFilter = data->fields.midtones;
		        UnityEngine::Material::SetVector(lutBuilderMaterial, v25->_Midtones, &colorFilter, 0LL);
		        v26 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		        colorFilter = data->fields.highlights;
		        UnityEngine::Material::SetVector(lutBuilderMaterial, v26->_Highlights, &colorFilter, 0LL);
		        v27 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		        colorFilter = data->fields.shadowsHighlightsLimits;
		        UnityEngine::Material::SetVector(lutBuilderMaterial, v27->_ShaHiLimits, &colorFilter, 0LL);
		        v28 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		        colorFilter = data->fields.splitShadows;
		        UnityEngine::Material::SetVector(lutBuilderMaterial, v28->_SplitShadows, &colorFilter, 0LL);
		        v29 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		        colorFilter = data->fields.splitHighlights;
		        UnityEngine::Material::SetVector(lutBuilderMaterial, v29->_SplitHighlights, &colorFilter, 0LL);
		        CurveMaster = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CurveMaster;
		        masterCurve = data->fields.masterCurve;
		        if ( masterCurve )
		        {
		          Texture = (Texture *)UnityEngine::Rendering::TextureCurve::GetTexture(masterCurve, 0LL);
		          UnityEngine::Material::SetTextureImpl(lutBuilderMaterial, CurveMaster, Texture, 0LL);
		          CurveRed = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CurveRed;
		          masterCurve = data->fields.redCurve;
		          if ( masterCurve )
		          {
		            v33 = (Texture *)UnityEngine::Rendering::TextureCurve::GetTexture(masterCurve, 0LL);
		            UnityEngine::Material::SetTextureImpl(lutBuilderMaterial, CurveRed, v33, 0LL);
		            CurveGreen = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CurveGreen;
		            masterCurve = data->fields.greenCurve;
		            if ( masterCurve )
		            {
		              v35 = (Texture *)UnityEngine::Rendering::TextureCurve::GetTexture(masterCurve, 0LL);
		              UnityEngine::Material::SetTextureImpl(lutBuilderMaterial, CurveGreen, v35, 0LL);
		              CurveBlue = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CurveBlue;
		              masterCurve = data->fields.blueCurve;
		              if ( masterCurve )
		              {
		                v37 = (Texture *)UnityEngine::Rendering::TextureCurve::GetTexture(masterCurve, 0LL);
		                UnityEngine::Material::SetTextureImpl(lutBuilderMaterial, CurveBlue, v37, 0LL);
		                CurveHueVsHue = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CurveHueVsHue;
		                masterCurve = data->fields.hueVsHueCurve;
		                if ( masterCurve )
		                {
		                  v39 = (Texture *)UnityEngine::Rendering::TextureCurve::GetTexture(masterCurve, 0LL);
		                  UnityEngine::Material::SetTextureImpl(lutBuilderMaterial, CurveHueVsHue, v39, 0LL);
		                  CurveHueVsSat = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CurveHueVsSat;
		                  masterCurve = data->fields.hueVsSatCurve;
		                  if ( masterCurve )
		                  {
		                    v41 = (Texture *)UnityEngine::Rendering::TextureCurve::GetTexture(masterCurve, 0LL);
		                    UnityEngine::Material::SetTextureImpl(lutBuilderMaterial, CurveHueVsSat, v41, 0LL);
		                    CurveLumVsSat = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CurveLumVsSat;
		                    masterCurve = data->fields.lumVsSatCurve;
		                    if ( masterCurve )
		                    {
		                      v43 = (Texture *)UnityEngine::Rendering::TextureCurve::GetTexture(masterCurve, 0LL);
		                      UnityEngine::Material::SetTextureImpl(lutBuilderMaterial, CurveLumVsSat, v43, 0LL);
		                      CurveSatVsSat = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CurveSatVsSat;
		                      masterCurve = data->fields.satVsSatCurve;
		                      if ( masterCurve )
		                      {
		                        v45 = (Texture *)UnityEngine::Rendering::TextureCurve::GetTexture(masterCurve, 0LL);
		                        UnityEngine::Material::SetTextureImpl(lutBuilderMaterial, CurveSatVsSat, v45, 0LL);
		                        v46 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                        colorFilter = data->fields.miscParams;
		                        UnityEngine::Material::SetVector(lutBuilderMaterial, v46->_Params, &colorFilter, 0LL);
		                        return;
		                      }
		                    }
		                  }
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_14:
		    sub_1800D8260(masterCurve, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2913, 0LL);
		  if ( !Patch )
		    goto LABEL_14;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)data,
		    (Object *)lutBuilderMaterial,
		    0LL);
		}
		
		internal static TextureHandle ColorGradingPass(HGRenderGraph renderGraph, HGCamera hgCamera, int lutSize, GraphicsFormat lutFormat, Material lutBuilder2DMaterial, ref CachedColorGradingData cachedColorGradingData, ref RTHandle cachedColorLut) => default; // 0x0000000189B7F19C-0x0000000189B7F7AC
		// TextureHandle ColorGradingPass(HGRenderGraph, HGCamera, Int32, GraphicsFormat, Material, UberPostPassUtils+CachedColorGradingData ByRef, RTHandle ByRef)
		// Hidden C++ exception states: #wind=1
		TextureHandle *HG::Rendering::Runtime::UberPostPassUtils::ColorGradingPass(
		        TextureHandle *__return_ptr retstr,
		        HGRenderGraph *renderGraph,
		        HGCamera *hgCamera,
		        int32_t lutSize,
		        GraphicsFormat__Enum lutFormat,
		        Material *lutBuilder2DMaterial,
		        UberPostPassUtils_CachedColorGradingData *cachedColorGradingData,
		        RTHandle **cachedColorLut,
		        MethodInfo *method)
		{
		  Object *v11; // rdi
		  TextureHandle *v12; // rsi
		  UberPostPassUtils_CachedColorGradingData *v13; // r14
		  __int64 v14; // rdx
		  __int64 v15; // rcx
		  HGRuntimeGrassQuery_Node *v16; // rdx
		  HGRuntimeGrassQuery_Node *v17; // r8
		  Int32__Array **v18; // r9
		  __int64 v19; // rdx
		  __int64 v20; // rcx
		  ProfilingSampler *v21; // rax
		  __int64 v22; // rcx
		  Object *v23; // rdx
		  unsigned int v24; // edx
		  unsigned __int64 v25; // r8
		  char v26; // dl
		  signed __int64 v27; // rtt
		  Object *v28; // r15
		  __int64 v29; // rdx
		  __int64 v30; // rcx
		  TextureHandle v31; // xmm0
		  TextureHandle v32; // xmm2
		  __int64 v33; // rdx
		  UberPostPassUtils_CachedColorGradingData *v34; // rax
		  UberPostPassUtils_CachedColorGradingData *v35; // rcx
		  unsigned __int64 v36; // r8
		  signed __int64 v37; // rtt
		  __int64 v38; // rdx
		  __int64 v39; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // r14
		  MethodInfo *methoda; // [rsp+20h] [rbp-288h]
		  Object *v43; // [rsp+A0h] [rbp-208h] BYREF
		  TextureHandle v44; // [rsp+A8h] [rbp-200h] BYREF
		  HGRenderGraphBuilder v45; // [rsp+B8h] [rbp-1F0h] BYREF
		  HGRenderGraphBuilder v46; // [rsp+D8h] [rbp-1D0h] BYREF
		  TextureHandle v47; // [rsp+F8h] [rbp-1B0h] BYREF
		  Il2CppExceptionWrapper *v48; // [rsp+108h] [rbp-1A0h] BYREF
		  UberPostPassUtils_CachedColorGradingData v49; // [rsp+110h] [rbp-198h] BYREF
		
		  v11 = (Object *)renderGraph;
		  v12 = retstr;
		  sub_18033B9D0(&v49, 0LL, 368LL);
		  memset(&v46, 0, sizeof(v46));
		  v43 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(2914, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2914, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v39, v38);
		    *v12 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1072(
		              &v44,
		              Patch,
		              v11,
		              (Object *)hgCamera,
		              lutSize,
		              lutFormat,
		              (Object *)lutBuilder2DMaterial,
		              cachedColorGradingData,
		              cachedColorLut,
		              0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		    HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v44, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		    HG::Rendering::Runtime::UberPostPassUtils::PrepareColorGradingParametersFromEnvVolume(
		      &TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->s_colorGradingData,
		      hgCamera,
		      lutSize,
		      lutBuilder2DMaterial,
		      0LL);
		    HG::Rendering::Runtime::UberPostPassUtils::CachedColorGradingData::CachedColorGradingData(
		      &v49,
		      TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->s_colorGradingData,
		      0LL);
		    v13 = cachedColorGradingData;
		    if ( HG::Rendering::Runtime::UberPostPassUtils::CachedColorGradingData::Equals(&v49, cachedColorGradingData, 0LL) )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		      if ( !HG::Rendering::Runtime::UberPostPassUtils::IsAnyColorCurveDirty(
		              &TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->s_colorGradingData,
		              0LL)
		        && cachedColorGradingData->lutSize >= 0 )
		      {
		        goto LABEL_16;
		      }
		    }
		    if ( *cachedColorLut )
		      UnityEngine::Rendering::RTHandle::Release(*cachedColorLut, 0LL);
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::RTHandles);
		    *cachedColorLut = UnityEngine::Rendering::RTHandles::Alloc(
		                        lutSize * lutSize,
		                        lutSize,
		                        1,
		                        DepthBits__Enum_None,
		                        lutFormat,
		                        FilterMode__Enum_Bilinear,
		                        TextureWrapMode__Enum_Clamp,
		                        TextureDimension__Enum_Tex2D,
		                        0,
		                        0,
		                        1,
		                        0,
		                        0,
		                        0.0,
		                        MSAASamples__Enum_None,
		                        0,
		                        RenderTextureMemoryless__Enum_None,
		                        (String *)"Color Grading Log Lut",
		                        0LL);
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)cachedColorLut, v16, v17, v18, methoda);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		    HG::Rendering::Runtime::UberPostPassUtils::PrepareLutBuilderMaterial(
		      TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->s_colorGradingData,
		      lutBuilder2DMaterial,
		      0LL);
		    if ( !v11 )
		      sub_1800D8260(v20, v19);
		    v44 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
		             &v44,
		             (HGRenderGraph *)v11,
		             *cachedColorLut,
		             0LL);
		    v21 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		            (Int32Enum__Enum)0x9Bu,
		            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		      &v45,
		      (HGRenderGraph *)v11,
		      (String *)"Color Grading",
		      &v43,
		      v21,
		      1,
		      ProfilingHGPass__Enum_None,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::UberPostPassUtils::ColorGradingPassData>);
		    v46 = v45;
		    v45.m_RenderPass = 0LL;
		    v45.m_Resources = (HGRenderGraphResourceRegistry *)&v46;
		    try
		    {
		      v23 = v43;
		      if ( !v43 )
		        sub_1800D8250(v22, 0LL);
		      v43[1].klass = (Object__Class *)lutBuilder2DMaterial;
		      if ( dword_18F35FD08 )
		      {
		        v24 = ((unsigned __int64)&v23[1] >> 12) & 0x1FFFFF;
		        v25 = (unsigned __int64)v24 >> 6;
		        v26 = v24 & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v25 + 36190]);
		        do
		          v27 = qword_18F0BCBA0[v25 + 36190];
		        while ( v27 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v25 + 36190], v27 | (1LL << v26), v27) );
		      }
		      v28 = v43;
		      v31 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(&v47, &v46, &v44, 0LL);
		      if ( !v28 )
		        sub_1800D8250(v30, v29);
		      *(TextureHandle *)&v28[1].monitor = v31;
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(&v47, &v46, &v44, 0, 0, 0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v46,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->s_colorGradingRenderFunc,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::UberPostPassUtils::ColorGradingPassData>);
		    }
		    catch ( Il2CppExceptionWrapper *v48 )
		    {
		      v45.m_RenderPass = (HGRenderGraphPass *)v48->ex;
		      sub_180268AE0(&v45);
		      v13 = cachedColorGradingData;
		      v11 = (Object *)renderGraph;
		      v12 = retstr;
		LABEL_16:
		      if ( v11 )
		      {
		        v32 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
		                 &v44,
		                 (HGRenderGraph *)v11,
		                 *cachedColorLut,
		                 0LL);
		        v33 = 2LL;
		        goto LABEL_18;
		      }
		      sub_1800D8250(v15, v14);
		    }
		    sub_180268AE0(&v45);
		    v32 = v44;
		    v33 = 2LL;
		LABEL_18:
		    v34 = v13;
		    v35 = &v49;
		    do
		    {
		      *(_OWORD *)&v34->lutSize = *(_OWORD *)&v35->lutSize;
		      *(_OWORD *)&v34->externalLuT = *(_OWORD *)&v35->externalLuT;
		      *(_OWORD *)&v34->colorCurve_redCurve = *(_OWORD *)&v35->colorCurve_redCurve;
		      *(_OWORD *)&v34->colorCurve_blueCurve = *(_OWORD *)&v35->colorCurve_blueCurve;
		      *(_OWORD *)&v34->colorCurve_hueVsSatCurve = *(_OWORD *)&v35->colorCurve_hueVsSatCurve;
		      *(_OWORD *)&v34->colorCurve_lumVsSatCurve = *(_OWORD *)&v35->colorCurve_lumVsSatCurve;
		      *(_OWORD *)&v34->colorFilter.z = *(_OWORD *)&v35->colorFilter.z;
		      v34 = (UberPostPassUtils_CachedColorGradingData *)((char *)v34 + 128);
		      *(_OWORD *)&v34[-1].tonemapping_shoulderLength = *(_OWORD *)&v35->lmsColorBalance.z;
		      v35 = (UberPostPassUtils_CachedColorGradingData *)((char *)v35 + 128);
		      --v33;
		    }
		    while ( v33 );
		    *(_OWORD *)&v34->lutSize = *(_OWORD *)&v35->lutSize;
		    *(_OWORD *)&v34->externalLuT = *(_OWORD *)&v35->externalLuT;
		    *(_OWORD *)&v34->colorCurve_redCurve = *(_OWORD *)&v35->colorCurve_redCurve;
		    *(_OWORD *)&v34->colorCurve_blueCurve = *(_OWORD *)&v35->colorCurve_blueCurve;
		    *(_OWORD *)&v34->colorCurve_hueVsSatCurve = *(_OWORD *)&v35->colorCurve_hueVsSatCurve;
		    *(_OWORD *)&v34->colorCurve_lumVsSatCurve = *(_OWORD *)&v35->colorCurve_lumVsSatCurve;
		    *(_OWORD *)&v34->colorFilter.z = *(_OWORD *)&v35->colorFilter.z;
		    if ( dword_18F35FD08 )
		    {
		      v36 = (((unsigned __int64)&v13->externalLuT >> 12) & 0x1FFFFF) >> 6;
		      _m_prefetchw(&qword_18F0BCBA0[v36 + 36190]);
		      do
		        v37 = qword_18F0BCBA0[v36 + 36190];
		      while ( v37 != _InterlockedCompareExchange64(
		                       &qword_18F0BCBA0[v36 + 36190],
		                       v37 | (1LL << (((unsigned __int64)&v13->externalLuT >> 12) & 0x3F)),
		                       v37) );
		    }
		    *v12 = v32;
		  }
		  return v12;
		}
		
		private static Vector3[] GetCutsceneEffectTriangleVertexPosition(float zOffset) => default; // 0x0000000183D43620-0x0000000183D436E0
		// Vector3[] GetCutsceneEffectTriangleVertexPosition(Single)
		Vector3__Array *HG::Rendering::Runtime::UberPostPassUtils::GetCutsceneEffectTriangleVertexPosition(
		        float zOffset,
		        MethodInfo *method)
		{
		  Vector3__Array *result; // rax
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1149, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1149, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_431(Patch, zOffset, 0LL);
		LABEL_8:
		    sub_1800D8260(v4, v3);
		  }
		  result = (Vector3__Array *)il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector3, 4LL);
		  if ( !result )
		    goto LABEL_8;
		  if ( !result->max_length.size
		    || (*(_QWORD *)&result->vector[0].x = _mm_unpacklo_ps((__m128)0xBF800000, (__m128)0x3F800000u).m128_u64[0],
		        result->vector[0].z = zOffset,
		        result->max_length.size <= 1u)
		    || (*(_QWORD *)&result->vector[1].x = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0],
		        result->vector[1].z = zOffset,
		        result->max_length.size <= 2u)
		    || (*(_QWORD *)&result->vector[2].x = _mm_unpacklo_ps((__m128)0xBF800000, (__m128)0xBF800000).m128_u64[0],
		        result->vector[2].z = zOffset,
		        result->max_length.size <= 3u) )
		  {
		    sub_1800D2AB0(v4, v3);
		  }
		  *(_QWORD *)&result->vector[3].x = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0xBF800000).m128_u64[0];
		  result->vector[3].z = zOffset;
		  return result;
		}
		
		private static Mesh CreateCutsceneEffectTriangleMesh() => default; // 0x0000000183D436E0-0x0000000183D438B0
		// Mesh CreateCutsceneEffectTriangleMesh()
		Mesh *HG::Rendering::Runtime::UberPostPassUtils::CreateCutsceneEffectTriangleMesh(MethodInfo *method)
		{
		  Mesh *v1; // rax
		  __int64 v2; // rdx
		  __int64 v3; // rcx
		  Mesh *v4; // rbp
		  __int64 v5; // rax
		  Vector3__Array *v6; // rsi
		  __int64 v7; // rax
		  Vector2__Array *v8; // rdi
		  Array *v9; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1150, 0LL) )
		  {
		    v1 = (Mesh *)sub_1800368D0(TypeInfo::UnityEngine::Mesh);
		    v4 = v1;
		    if ( v1 )
		    {
		      UnityEngine::Mesh::Mesh(v1, 0LL);
		      v5 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector3, 4LL);
		      v6 = (Vector3__Array *)v5;
		      if ( v5 )
		      {
		        if ( !*(_DWORD *)(v5 + 24) )
		          goto LABEL_15;
		        *(_QWORD *)(v5 + 32) = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		        *(_DWORD *)(v5 + 40) = 0;
		        if ( *(_DWORD *)(v5 + 24) <= 1u )
		          goto LABEL_15;
		        *(_QWORD *)(v5 + 44) = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0LL).m128_u64[0];
		        *(_DWORD *)(v5 + 52) = 0;
		        if ( *(_DWORD *)(v5 + 24) <= 2u )
		          goto LABEL_15;
		        *(_QWORD *)(v5 + 56) = _mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
		        *(_DWORD *)(v5 + 64) = 0;
		        if ( *(_DWORD *)(v5 + 24) <= 3u )
		          goto LABEL_15;
		        *(_QWORD *)(v5 + 68) = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0];
		        *(_DWORD *)(v5 + 76) = 0;
		        v7 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector2, 4LL);
		        v8 = (Vector2__Array *)v7;
		        if ( v7 )
		        {
		          if ( *(_DWORD *)(v7 + 24) )
		          {
		            *(_QWORD *)(v7 + 32) = 0LL;
		            if ( *(_DWORD *)(v7 + 24) > 1u )
		            {
		              *(_QWORD *)(v7 + 40) = 1065353216LL;
		              if ( *(_DWORD *)(v7 + 24) > 2u )
		              {
		                *(_DWORD *)(v7 + 48) = 0;
		                *(_DWORD *)(v7 + 52) = 1065353216;
		                if ( *(_DWORD *)(v7 + 24) > 3u )
		                {
		                  *(_DWORD *)(v7 + 56) = 1065353216;
		                  *(_DWORD *)(v7 + 60) = 1065353216;
		                  v9 = (Array *)il2cpp_array_new_specific_1(TypeInfo::System::Int32, 6LL);
		                  System::Runtime::CompilerServices::RuntimeHelpers::InitializeArray(
		                    v9,
		                    B2CF02C10F1F309AC8FB52A3CCE888191E73C7E1C5A0D699CA4CBBE2C76F2C0F_Field,
		                    0LL);
		                  UnityEngine::Mesh::set_vertices(v4, v6, 0LL);
		                  UnityEngine::Mesh::set_triangles(v4, (Int32__Array *)v9, 0LL);
		                  UnityEngine::Object::set_name((Object_1 *)v4, (String *)"CutsceneEffectTriangle", 0LL);
		                  UnityEngine::Mesh::set_uv(v4, v8, 0LL);
		                  UnityEngine::Mesh::RecalculateBounds(v4, MeshUpdateFlags__Enum_Default, 0LL);
		                  return v4;
		                }
		              }
		            }
		          }
		LABEL_15:
		          sub_1800D2AB0(v3, v2);
		        }
		      }
		    }
		LABEL_3:
		    sub_1800D8260(v3, v2);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1150, 0LL);
		  if ( !Patch )
		    goto LABEL_3;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(Patch, 0LL);
		}
		
		internal static Mesh GetCutsceneEffectMesh() => default; // 0x0000000183D43430-0x0000000183D43620
		// Mesh GetCutsceneEffectMesh()
		Mesh *HG::Rendering::Runtime::UberPostPassUtils::GetCutsceneEffectMesh(MethodInfo *method)
		{
		  MethodInfo *v1; // rbx
		  struct ILFixDynamicMethodWrapper_2__Class *v2; // rdx
		  Mesh *wrapperArray; // rcx
		  Mesh *s_cutsceneEffectMesh; // rbx
		  struct Object_1__Class *v5; // rcx
		  Vector3__Array *CutsceneEffectTriangleVertexPosition; // rax
		  UberPostPassUtils__StaticFields *static_fields; // rdx
		  HGRuntimeGrassQuery_Node *v9; // r8
		  Int32__Array **v10; // r9
		  Mesh *CutsceneEffectTriangleMesh; // rax
		  HGRuntimeGrassQuery_Node *v12; // rdx
		  HGRuntimeGrassQuery_Node *v13; // r8
		  Int32__Array **v14; // r9
		  UberPostPassUtils__StaticFields *v15; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v17; // [rsp+20h] [rbp-8h]
		  MethodInfo *v18; // [rsp+20h] [rbp-8h]
		
		  v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v17 = v1;
		  wrapperArray = (Mesh *)v2->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_18;
		  if ( SLODWORD(wrapperArray[1].klass) > 1148 )
		  {
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = (Mesh *)v2->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_18;
		    if ( LODWORD(wrapperArray[1].klass) <= 0x47C )
		      sub_1800D2AB0(wrapperArray, v2);
		    if ( wrapperArray[384].klass )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(1148, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(Patch, 0LL);
		      goto LABEL_18;
		    }
		  }
		  if ( !TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		  s_cutsceneEffectMesh = TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->s_cutsceneEffectMesh;
		  v5 = TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v5 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v5 = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( s_cutsceneEffectMesh )
		  {
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(v5);
		    if ( s_cutsceneEffectMesh->fields._.m_CachedPtr )
		      goto LABEL_12;
		  }
		  if ( !TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		  CutsceneEffectTriangleVertexPosition = HG::Rendering::Runtime::UberPostPassUtils::GetCutsceneEffectTriangleVertexPosition(
		                                           0.001,
		                                           0LL);
		  static_fields = TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields;
		  static_fields->s_cutsceneEffectMeshVertices = CutsceneEffectTriangleVertexPosition;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->s_cutsceneEffectMeshVertices,
		    (HGRuntimeGrassQuery_Node *)static_fields,
		    v9,
		    v10,
		    v17);
		  CutsceneEffectTriangleMesh = HG::Rendering::Runtime::UberPostPassUtils::CreateCutsceneEffectTriangleMesh(0LL);
		  v12 = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields;
		  v12[1].fields.parent = (HGRuntimeGrassQuery_Node *)CutsceneEffectTriangleMesh;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->s_cutsceneEffectMesh,
		    v12,
		    v13,
		    v14,
		    v18);
		  v15 = TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields;
		  wrapperArray = v15->s_cutsceneEffectMesh;
		  if ( !wrapperArray
		    || (UnityEngine::Mesh::set_vertices(wrapperArray, v15->s_cutsceneEffectMeshVertices, 0LL),
		        (wrapperArray = TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->s_cutsceneEffectMesh) == 0LL) )
		  {
		LABEL_18:
		    sub_1800D8260(wrapperArray, v2);
		  }
		  UnityEngine::Mesh::UploadMeshData(wrapperArray, 1, 0LL);
		LABEL_12:
		  if ( !TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		  return TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->s_cutsceneEffectMesh;
		}
		
		internal static TextureHandle CutsceneEffectPass(HGSettingParameters settingParameters, HGRenderGraph renderGraph, HGCamera hgCamera, TextureHandle finalRT, TextureHandle depthRT, TextureHandle source) => default; // 0x0000000189B7FEF8-0x0000000189B80628
		// TextureHandle CutsceneEffectPass(HGSettingParameters, HGRenderGraph, HGCamera, TextureHandle, TextureHandle, TextureHandle)
		// Hidden C++ exception states: #wind=1
		TextureHandle *HG::Rendering::Runtime::UberPostPassUtils::CutsceneEffectPass(
		        TextureHandle *__return_ptr retstr,
		        HGSettingParameters *settingParameters,
		        HGRenderGraph *renderGraph,
		        HGCamera *hgCamera,
		        TextureHandle *finalRT,
		        TextureHandle *depthRT,
		        TextureHandle *source,
		        MethodInfo *method)
		{
		  TextureHandle *v11; // rdi
		  __int64 v12; // rdx
		  VFXPPCutsceneEffect__StaticFields *static_fields; // rcx
		  _BOOL8 v14; // r14
		  Object_1 *s_cutsceneEffectMesh; // rbx
		  __int64 v16; // rdx
		  __int64 v17; // rcx
		  Vector3__Array *CutsceneEffectTriangleVertexPosition; // rax
		  UberPostPassUtils__StaticFields *v19; // rdx
		  HGRuntimeGrassQuery_Node *v20; // r8
		  Int32__Array **v21; // r9
		  Mesh *CutsceneEffectTriangleMesh; // rax
		  HGRuntimeGrassQuery_Node *v23; // rdx
		  HGRuntimeGrassQuery_Node *v24; // r8
		  Int32__Array **v25; // r9
		  __int64 v26; // rdx
		  __int64 v27; // rcx
		  UberPostPassUtils__StaticFields *v28; // rax
		  TextureHandle *v29; // rax
		  TextureDesc *TextureDescRef; // rax
		  int32_t effectListCount; // ebx
		  __int64 v32; // r15
		  int32_t v33; // r14d
		  __int64 v34; // rdi
		  __int64 v35; // rdx
		  VFXPPCutsceneEffect__StaticFields *v36; // rcx
		  Material__Array *runtimeMaterial; // r12
		  __int64 v38; // r13
		  MonitorData *BlitMaterial; // r15
		  ProfilingSampler *v40; // rax
		  Object *v41; // rsi
		  __int64 v42; // rdx
		  signed __int64 v43; // rcx
		  int v44; // r8d
		  unsigned __int64 v45; // r9
		  signed __int64 v46; // rtt
		  Object *v47; // rax
		  unsigned __int64 v48; // r9
		  signed __int64 v49; // rtt
		  Object *v50; // r9
		  signed __int64 v51; // rcx
		  unsigned __int64 v52; // r9
		  unsigned __int64 v53; // r10
		  char v54; // r9
		  signed __int64 v55; // rtt
		  Object *v56; // rbx
		  __int64 v57; // rdx
		  __int64 v58; // rcx
		  TextureHandle v59; // xmm0
		  Object *v60; // rbx
		  __int64 v61; // rdx
		  __int64 v62; // rcx
		  TextureHandle v63; // xmm0
		  TextureHandle v64; // xmm0
		  __int64 v65; // rdx
		  __int64 v66; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // r14
		  MethodInfo *methoda; // [rsp+20h] [rbp-E8h]
		  MethodInfo *methodb; // [rsp+20h] [rbp-E8h]
		  Object *v71; // [rsp+50h] [rbp-B8h] BYREF
		  TextureHandle si128; // [rsp+60h] [rbp-A8h] BYREF
		  TextureHandle v73; // [rsp+70h] [rbp-98h] BYREF
		  TextureHandle v74; // [rsp+80h] [rbp-88h] BYREF
		  HGRenderGraphBuilder v75; // [rsp+90h] [rbp-78h] BYREF
		  HGRenderGraphBuilder v76; // [rsp+B0h] [rbp-58h] BYREF
		  Il2CppExceptionWrapper *v77; // [rsp+D0h] [rbp-38h] BYREF
		
		  v11 = retstr;
		  v71 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(2916, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2916, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v66, v65);
		    v74 = *source;
		    v73 = *depthRT;
		    si128 = *finalRT;
		    v29 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1073(
		            (TextureHandle *)&v76,
		            Patch,
		            (Object *)settingParameters,
		            (Object *)renderGraph,
		            (Object *)hgCamera,
		            &si128,
		            &v73,
		            &v74,
		            0LL);
		    goto LABEL_46;
		  }
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
		  static_fields = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect->static_fields;
		  if ( !static_fields->m_useCutsceneEffsectShader )
		    goto LABEL_6;
		  if ( !settingParameters )
		    sub_1800D8260(static_fields, v12);
		  if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		         settingParameters->fields._cutsceneEffectEnabled_k__BackingField,
		         MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
		    v14 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect->static_fields->runtimeMaterial != 0LL;
		  }
		  else
		  {
		LABEL_6:
		    LODWORD(v14) = 0;
		  }
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		  s_cutsceneEffectMesh = (Object_1 *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->s_cutsceneEffectMesh;
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  if ( UnityEngine::Object::op_Equality(s_cutsceneEffectMesh, 0LL, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		    CutsceneEffectTriangleVertexPosition = HG::Rendering::Runtime::UberPostPassUtils::GetCutsceneEffectTriangleVertexPosition(
		                                             0.001,
		                                             0LL);
		    v19 = TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields;
		    v19->s_cutsceneEffectMeshVertices = CutsceneEffectTriangleVertexPosition;
		    sub_18002D1B0(
		      (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->s_cutsceneEffectMeshVertices,
		      (HGRuntimeGrassQuery_Node *)v19,
		      v20,
		      v21,
		      methoda);
		    CutsceneEffectTriangleMesh = HG::Rendering::Runtime::UberPostPassUtils::CreateCutsceneEffectTriangleMesh(0LL);
		    v23 = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields;
		    v23[1].fields.parent = (HGRuntimeGrassQuery_Node *)CutsceneEffectTriangleMesh;
		    sub_18002D1B0(
		      (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->s_cutsceneEffectMesh,
		      v23,
		      v24,
		      v25,
		      methodb);
		    v28 = TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields;
		    if ( !v28->s_cutsceneEffectMesh )
		      sub_1800D8260(v27, v26);
		    UnityEngine::Mesh::set_vertices(v28->s_cutsceneEffectMesh, v28->s_cutsceneEffectMeshVertices, 0LL);
		  }
		  if ( !v14 )
		  {
		    v29 = source;
		LABEL_46:
		    v64 = *v29;
		    goto LABEL_47;
		  }
		  if ( !renderGraph )
		    sub_1800D8260(v17, v16);
		  TextureDescRef = HG::Rendering::RenderGraphModule::HGRenderGraph::GetTextureDescRef(renderGraph, source, 0LL);
		  v74 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(&v74, renderGraph, TextureDescRef, 0LL);
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
		  effectListCount = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect->static_fields->effectListCount;
		  v32 = 32LL;
		  v33 = 0;
		  if ( effectListCount >= 32 )
		  {
		    effectListCount = 32;
		LABEL_17:
		    v34 = 0LL;
		    do
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		      si128.handle = (ResourceHandle)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->s_cutSceneEffectMaterials;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
		      v36 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect->static_fields;
		      runtimeMaterial = v36->runtimeMaterial;
		      if ( !runtimeMaterial )
		        sub_1800D8260(v36, v35);
		      if ( (unsigned int)v33 >= runtimeMaterial->max_length.size )
		        sub_1800D2AB0(v36, v35);
		      v38 = *(__int64 *)((char *)&runtimeMaterial->klass + v32);
		      if ( !*(_QWORD *)&si128.handle )
		        sub_1800D8260(v36, v35);
		      sub_180031B10(*(_QWORD *)&si128.handle, v38);
		      sub_1800020D0(*(_QWORD *)&si128.handle, v34, v38);
		      ++v33;
		      ++v34;
		      v32 += 8LL;
		    }
		    while ( v33 < effectListCount );
		    v11 = retstr;
		    goto LABEL_23;
		  }
		  if ( effectListCount > 0 )
		    goto LABEL_17;
		LABEL_23:
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		  BlitMaterial = (MonitorData *)HG::Rendering::Runtime::HGUtils::GetBlitMaterial(
		                                  0,
		                                  TextureDimension__Enum_Tex2D,
		                                  0,
		                                  0LL);
		  v40 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		          (Int32Enum__Enum)0x9Eu,
		          MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		  HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		    &v76,
		    renderGraph,
		    (String *)"CutsceneEffect",
		    &v71,
		    v40,
		    1,
		    ProfilingHGPass__Enum_None,
		    MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::UberPostPassUtils::CutsceneEffectData>);
		  v75 = v76;
		  v73.handle = 0LL;
		  v73.fallBackResource = (ResourceHandle)&v75;
		  try
		  {
		    v41 = v71;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		    v43 = (signed __int64)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields;
		    if ( !v41 )
		      sub_1800D8250(v43, v42);
		    v41[3].klass = *(Object__Class **)(v43 + 112);
		    v44 = dword_18F35FD08;
		    if ( dword_18F35FD08 )
		    {
		      v45 = (((unsigned __int64)&v41[3] >> 12) & 0x1FFFFF) >> 6;
		      _m_prefetchw(&qword_18F0BCBA0[v45 + 36190]);
		      do
		      {
		        v43 = qword_18F0BCBA0[v45 + 36190] | (1LL << (((unsigned __int64)&v41[3] >> 12) & 0x3F));
		        v46 = qword_18F0BCBA0[v45 + 36190];
		      }
		      while ( v46 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v45 + 36190], v43, v46) );
		      v44 = dword_18F35FD08;
		    }
		    v47 = v71;
		    if ( !v71 )
		      sub_1800D8250(v43, qword_18F0BCBA0);
		    v71[3].monitor = BlitMaterial;
		    if ( v44 )
		    {
		      v48 = (((unsigned __int64)&v47[3].monitor >> 12) & 0x1FFFFF) >> 6;
		      _m_prefetchw(&qword_18F0BCBA0[v48 + 36190]);
		      do
		        v49 = qword_18F0BCBA0[v48 + 36190];
		      while ( v49 != _InterlockedCompareExchange64(
		                       &qword_18F0BCBA0[v48 + 36190],
		                       v49 | (1LL << (((unsigned __int64)&v47[3].monitor >> 12) & 0x3F)),
		                       v49) );
		      v44 = dword_18F35FD08;
		    }
		    v50 = v71;
		    v51 = (signed __int64)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields;
		    if ( !v71 )
		      sub_1800D8250(v51, qword_18F0BCBA0);
		    v71[4].klass = *(Object__Class **)(v51 + 96);
		    if ( v44 )
		    {
		      v52 = ((unsigned __int64)&v50[4] >> 12) & 0x1FFFFF;
		      v53 = v52 >> 6;
		      v54 = v52 & 0x3F;
		      _m_prefetchw(&qword_18F0BCBA0[v53 + 36190]);
		      do
		      {
		        v51 = qword_18F0BCBA0[v53 + 36190] | (1LL << v54);
		        v55 = qword_18F0BCBA0[v53 + 36190];
		      }
		      while ( v55 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v53 + 36190], v51, v55) );
		    }
		    if ( !v71 )
		      sub_1800D8250(v51, qword_18F0BCBA0);
		    LODWORD(v71[4].monitor) = effectListCount;
		    v56 = v71;
		    v59 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&si128, &v75, source, 0LL);
		    if ( !v56 )
		      sub_1800D8250(v58, v57);
		    v56[1] = (Object)v59;
		    v60 = v71;
		    v63 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&si128, &v75, depthRT, 0LL);
		    if ( !v60 )
		      sub_1800D8250(v62, v61);
		    v60[2] = (Object)v63;
		    si128 = (TextureHandle)_mm_load_si128((const __m128i *)&xmmword_18B959540);
		    HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		      (TextureHandle *)&v76,
		      &v75,
		      &v74,
		      0,
		      RenderBufferLoadAction__Enum_Load,
		      RenderBufferStoreAction__Enum_Store,
		      (Color *)&si128,
		      0,
		      0LL);
		    HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture((TextureHandle *)&v76, &v75, &v74, 0LL);
		    HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		      &v75,
		      (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->m_cutsceneEffectFunc,
		      0LL,
		      0,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::UberPostPassUtils::CutsceneEffectData>);
		  }
		  catch ( Il2CppExceptionWrapper *v77 )
		  {
		    v73.handle = (ResourceHandle)v77->ex;
		    sub_180268AE0(&v73);
		    v11 = retstr;
		    goto LABEL_43;
		  }
		  sub_180268AE0(&v73);
		LABEL_43:
		  v64 = v74;
		LABEL_47:
		  *v11 = v64;
		  return v11;
		}
		
		internal static TextureHandle FisheyeEffectPass(HGSettingParameters settingParameters, HGRenderGraph renderGraph, HGCamera hgCamera, HGFisheyeEffect fisheyeEffect, Material fishEyeEffectMaterial, Material fisheyeEffectDepthMaterial, TextureHandle source, TextureHandle sceneDepth, out TextureHandle fisheyeDepthRT) {
			fisheyeDepthRT = default;
			return default;
		} // 0x0000000189B80C10-0x0000000189B81424
		// TextureHandle FisheyeEffectPass(HGSettingParameters, HGRenderGraph, HGCamera, HGFisheyeEffect, Material, Material, TextureHandle, TextureHandle, TextureHandle ByRef)
		// Hidden C++ exception states: #wind=1
		TextureHandle *HG::Rendering::Runtime::UberPostPassUtils::FisheyeEffectPass(
		        TextureHandle *__return_ptr retstr,
		        HGSettingParameters *settingParameters,
		        HGRenderGraph *renderGraph,
		        HGCamera *hgCamera,
		        HGFisheyeEffect *fisheyeEffect,
		        Material *fishEyeEffectMaterial,
		        Material *fisheyeEffectDepthMaterial,
		        TextureHandle *source,
		        TextureHandle *sceneDepth,
		        TextureHandle *fisheyeDepthRT,
		        MethodInfo *method)
		{
		  TextureHandle *v14; // r14
		  __int64 v15; // rdx
		  __int64 v16; // rcx
		  __int64 v17; // rdx
		  __int64 v18; // rcx
		  __int64 v19; // rdx
		  __int64 v20; // rcx
		  Vector2Int sceneRTSize_k__BackingField; // rbx
		  __int64 v22; // rdx
		  __int64 v23; // rcx
		  HGRuntimeGrassQuery_Node *v24; // rdx
		  HGRuntimeGrassQuery_Node *v25; // r8
		  Int32__Array **v26; // r9
		  HGRuntimeGrassQuery_Node *v27; // rdx
		  HGRuntimeGrassQuery_Node *v28; // r8
		  Int32__Array **v29; // r9
		  __int64 v30; // rdx
		  __int64 v31; // rcx
		  double v32; // xmm0_8
		  __int64 v33; // rdx
		  HGShaderIDs__StaticFields *static_fields; // rcx
		  int32_t FisheyeEffectParams1; // esi
		  __int64 v36; // rdx
		  HGShaderIDs__StaticFields *v37; // rcx
		  int32_t v38; // r15d
		  ProfilingSampler *v39; // rax
		  __int64 v40; // rdx
		  signed __int64 v41; // rcx
		  Object *v42; // r8
		  int v43; // eax
		  unsigned int v44; // r8d
		  unsigned __int64 v45; // r9
		  char v46; // r8
		  signed __int64 v47; // rtt
		  Object *v48; // r9
		  unsigned int v49; // r9d
		  unsigned __int64 v50; // r10
		  char v51; // r9
		  signed __int64 v52; // rtt
		  Object *v53; // rbx
		  __int64 v54; // rdx
		  __int64 v55; // rcx
		  TextureHandle v56; // xmm0
		  Object *v57; // rbx
		  __int64 v58; // rdx
		  __int64 v59; // rcx
		  TextureHandle v60; // xmm0
		  TextureHandle v61; // xmm0
		  TextureHandle *v62; // rax
		  __int64 v63; // rdx
		  __int64 v64; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rsi
		  MethodInfo *methoda; // [rsp+20h] [rbp-218h]
		  MethodInfo *methodb; // [rsp+20h] [rbp-218h]
		  int32_t height[4]; // [rsp+60h] [rbp-1D8h] BYREF
		  Object *v70; // [rsp+70h] [rbp-1C8h] BYREF
		  TextureHandle v71; // [rsp+80h] [rbp-1B8h] BYREF
		  TextureHandle v72; // [rsp+90h] [rbp-1A8h] BYREF
		  HGRenderGraphBuilder v73; // [rsp+A0h] [rbp-198h] BYREF
		  TextureDesc v74; // [rsp+C0h] [rbp-178h] BYREF
		  HGRenderGraphBuilder v75; // [rsp+120h] [rbp-118h] BYREF
		  Il2CppExceptionWrapper *v76; // [rsp+140h] [rbp-F8h] BYREF
		  TextureDesc v77; // [rsp+150h] [rbp-E8h] BYREF
		  TextureDesc v78; // [rsp+1B0h] [rbp-88h] BYREF
		
		  v14 = retstr;
		  sub_18033B9D0(&v74, 0LL, 96LL);
		  v70 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(2917, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2917, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v64, v63);
		    v72 = *sceneDepth;
		    v71 = *source;
		    v62 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1074(
		            (TextureHandle *)&v75,
		            Patch,
		            (Object *)settingParameters,
		            (Object *)renderGraph,
		            (Object *)hgCamera,
		            (Object *)fisheyeEffect,
		            (Object *)fishEyeEffectMaterial,
		            (Object *)fisheyeEffectDepthMaterial,
		            &v71,
		            &v72,
		            fisheyeDepthRT,
		            0LL);
		    goto LABEL_29;
		  }
		  if ( !fisheyeEffect )
		    sub_1800D8260(v16, v15);
		  if ( !HG::Rendering::Runtime::HGFisheyeEffect::IsActive(fisheyeEffect, 0LL) )
		    goto LABEL_26;
		  if ( !settingParameters )
		    sub_1800D8260(v18, v17);
		  if ( !HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		          settingParameters->fields._fisheyeEffectEnabled_k__BackingField,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
		  {
		LABEL_26:
		    *fisheyeDepthRT = *sceneDepth;
		    v62 = source;
		LABEL_29:
		    v61 = *v62;
		    goto LABEL_30;
		  }
		  if ( !hgCamera )
		    sub_1800D8260(v20, v19);
		  sceneRTSize_k__BackingField = hgCamera->fields._sceneRTSize_k__BackingField;
		  *(Vector2Int *)height = sceneRTSize_k__BackingField;
		  HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
		    &v74,
		    sceneRTSize_k__BackingField.m_X,
		    sceneRTSize_k__BackingField.m_Y,
		    0LL);
		  if ( !renderGraph )
		    sub_1800D8260(v23, v22);
		  v74.colorFormat = HG::Rendering::RenderGraphModule::HGRenderGraph::GetTextureDescRef(renderGraph, source, 0LL)->colorFormat;
		  v74.name = (String *)"Fisheye Color RT";
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v74.name, v24, v25, v26, methoda);
		  v77 = v74;
		  HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v74, sceneRTSize_k__BackingField.m_X, height[1], 0LL);
		  v74.colorFormat = HG::Rendering::RenderGraphModule::HGRenderGraph::GetTextureDescRef(renderGraph, sceneDepth, 0LL)->colorFormat;
		  v74.depthBufferBits = HG::Rendering::RenderGraphModule::HGRenderGraph::GetTextureDescRef(renderGraph, sceneDepth, 0LL)->depthBufferBits;
		  v74.name = (String *)"Fisheye Depth";
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v74.name, v27, v28, v29, methodb);
		  v78 = v74;
		  v72 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(&v72, renderGraph, &v77, 0LL);
		  *fisheyeDepthRT = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(&v71, renderGraph, &v78, 0LL);
		  if ( !fisheyeEffect->fields.distortion )
		    sub_1800D8260(v31, v30);
		  v32 = sub_1800057D0(10LL, fisheyeEffect->fields.distortion);
		  height[0] = LODWORD(v32);
		  height[1] = 0;
		  height[2] = 0;
		  height[3] = 0;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		  static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		  FisheyeEffectParams1 = static_fields->_FisheyeEffectParams1;
		  if ( !fishEyeEffectMaterial )
		    sub_1800D8260(static_fields, v33);
		  v71 = *(TextureHandle *)height;
		  UnityEngine::Material::SetVector(fishEyeEffectMaterial, FisheyeEffectParams1, (Vector4 *)&v71, 0LL);
		  v37 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		  v38 = v37->_FisheyeEffectParams1;
		  if ( !fisheyeEffectDepthMaterial )
		    sub_1800D8260(v37, v36);
		  v71 = (TextureHandle)(unsigned int)height[0];
		  UnityEngine::Material::SetVector(fisheyeEffectDepthMaterial, v38, (Vector4 *)&v71, 0LL);
		  v39 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		          (Int32Enum__Enum)0xA1u,
		          MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		  HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		    &v75,
		    renderGraph,
		    (String *)"FisheyeEffect",
		    &v70,
		    v39,
		    1,
		    ProfilingHGPass__Enum_None,
		    MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::UberPostPassUtils::FisheyeEffectData>);
		  v73 = v75;
		  v71.handle = 0LL;
		  v71.fallBackResource = (ResourceHandle)&v73;
		  try
		  {
		    v42 = v70;
		    if ( !v70 )
		      sub_1800D8250(v41, v40);
		    v70[4].monitor = (MonitorData *)fishEyeEffectMaterial;
		    v43 = dword_18F35FD08;
		    if ( dword_18F35FD08 )
		    {
		      v44 = ((unsigned __int64)&v42[4].monitor >> 12) & 0x1FFFFF;
		      v45 = (unsigned __int64)v44 >> 6;
		      v46 = v44 & 0x3F;
		      _m_prefetchw(&qword_18F0BCBA0[v45 + 36190]);
		      do
		      {
		        v41 = qword_18F0BCBA0[v45 + 36190] | (1LL << v46);
		        v47 = qword_18F0BCBA0[v45 + 36190];
		      }
		      while ( v47 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v45 + 36190], v41, v47) );
		      v43 = dword_18F35FD08;
		    }
		    v48 = v70;
		    if ( !v70 )
		      sub_1800D8250(v41, qword_18F0BCBA0);
		    v70[5].klass = (Object__Class *)fisheyeEffectDepthMaterial;
		    if ( v43 )
		    {
		      v49 = ((unsigned __int64)&v48[5] >> 12) & 0x1FFFFF;
		      v50 = (unsigned __int64)v49 >> 6;
		      v51 = v49 & 0x3F;
		      _m_prefetchw(&qword_18F0BCBA0[v50 + 36190]);
		      do
		        v52 = qword_18F0BCBA0[v50 + 36190];
		      while ( v52 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v50 + 36190], v52 | (1LL << v51), v52) );
		    }
		    v53 = v70;
		    v56 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		             (TextureHandle *)height,
		             &v73,
		             source,
		             0LL);
		    if ( !v53 )
		      sub_1800D8250(v55, v54);
		    v53[1] = (Object)v56;
		    v57 = v70;
		    v60 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		             (TextureHandle *)height,
		             &v73,
		             sceneDepth,
		             0LL);
		    if ( !v57 )
		      sub_1800D8250(v59, v58);
		    v57[2] = (Object)v60;
		    HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture((TextureHandle *)height, &v73, &v72, 0LL);
		    *(__m128i *)height = _mm_load_si128((const __m128i *)&xmmword_18B959540);
		    HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		      (TextureHandle *)&v75,
		      &v73,
		      &v72,
		      0,
		      RenderBufferLoadAction__Enum_DontCare,
		      RenderBufferStoreAction__Enum_Store,
		      (Color *)height,
		      0,
		      0LL);
		    HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
		      (TextureHandle *)&v75,
		      &v73,
		      fisheyeDepthRT,
		      0LL);
		    HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
		      (TextureHandle *)&v75,
		      &v73,
		      fisheyeDepthRT,
		      DepthAccess__Enum_Write,
		      RenderBufferLoadAction__Enum_Clear,
		      RenderBufferStoreAction__Enum_Store,
		      1.0,
		      0,
		      0,
		      0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		    HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		      &v73,
		      (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->m_fisheyeEffectFunc,
		      0LL,
		      0,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::UberPostPassUtils::FisheyeEffectData>);
		  }
		  catch ( Il2CppExceptionWrapper *v76 )
		  {
		    v71.handle = (ResourceHandle)v76->ex;
		    sub_180268AE0(&v71);
		    v14 = retstr;
		    goto LABEL_25;
		  }
		  sub_180268AE0(&v71);
		LABEL_25:
		  v61 = v72;
		LABEL_30:
		  *v14 = v61;
		  return v14;
		}
		
		internal static void PrepareFrostedGlassPSMaterials(HGRenderPipelineMaterialCollector materialCollector, ref FrostedGlassPSMaterials frostedGlassPSMaterials, HGRenderPipelineRuntimeResources defaultResources) {} // 0x0000000183520AC0-0x0000000183520C20
		// Void PrepareFrostedGlassPSMaterials(HGRenderPipelineMaterialCollector, UberPostPassUtils+FrostedGlassPSMaterials ByRef, HGRenderPipelineRuntimeResources)
		void HG::Rendering::Runtime::UberPostPassUtils::PrepareFrostedGlassPSMaterials(
		        HGRenderPipelineMaterialCollector *materialCollector,
		        UberPostPassUtils_FrostedGlassPSMaterials *frostedGlassPSMaterials,
		        HGRenderPipelineRuntimeResources *defaultResources,
		        MethodInfo *method)
		{
		  int v7; // ebx
		  HGRuntimeGrassQuery_Node *v8; // rdx
		  HGRuntimeGrassQuery_Node *v9; // r8
		  Int32__Array **v10; // r9
		  HGRuntimeGrassQuery_Node *v11; // rdx
		  HGRuntimeGrassQuery_Node *v12; // r8
		  Int32__Array **v13; // r9
		  HGRuntimeGrassQuery_Node *v14; // rdx
		  HGRuntimeGrassQuery_Node *v15; // r8
		  Int32__Array **v16; // r9
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rdx
		  __int64 v18; // rcx
		  Material__Array *frostedGlass1stPassMaterials; // rdi
		  Material *Material; // rax
		  Material *v21; // r14
		  Material__Array *frostedGlass2ndPassMaterials; // rdi
		  Material *v23; // rax
		  Material *v24; // r14
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *methoda; // [rsp+20h] [rbp-38h]
		  MethodInfo *methodb; // [rsp+20h] [rbp-38h]
		  MethodInfo *methodc; // [rsp+20h] [rbp-38h]
		  _BYTE v29[40]; // [rsp+30h] [rbp-28h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2919, 0LL) )
		  {
		    v7 = 0;
		    *(_OWORD *)v29 = (unsigned __int64)il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Material, 4LL);
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)v29, v8, v9, v10, methoda);
		    *(_QWORD *)&v29[8] = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Material, 4LL);
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v29[8], v11, v12, v13, methodb);
		    *frostedGlassPSMaterials = *(UberPostPassUtils_FrostedGlassPSMaterials *)v29;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)frostedGlassPSMaterials, v14, v15, v16, methodc);
		    while ( 1 )
		    {
		      frostedGlass1stPassMaterials = frostedGlassPSMaterials->frostedGlass1stPassMaterials;
		      if ( !defaultResources )
		        break;
		      shaders = defaultResources->fields.shaders;
		      if ( !shaders )
		        break;
		      if ( !materialCollector )
		        break;
		      Material = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
		                   materialCollector,
		                   shaders->fields.frostedGlassBlurPS,
		                   0,
		                   0LL);
		      v21 = Material;
		      if ( !frostedGlass1stPassMaterials )
		        break;
		      sub_180031B10(frostedGlass1stPassMaterials, Material);
		      sub_1800020D0(frostedGlass1stPassMaterials, v7, v21);
		      shaders = defaultResources->fields.shaders;
		      frostedGlass2ndPassMaterials = frostedGlassPSMaterials->frostedGlass2ndPassMaterials;
		      if ( !shaders )
		        break;
		      v23 = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
		              materialCollector,
		              shaders->fields.frostedGlassBlurPS,
		              0,
		              0LL);
		      v24 = v23;
		      if ( !frostedGlass2ndPassMaterials )
		        break;
		      sub_180031B10(frostedGlass2ndPassMaterials, v23);
		      sub_1800020D0(frostedGlass2ndPassMaterials, v7++, v24);
		      if ( v7 >= 4 )
		        return;
		    }
		LABEL_11:
		    sub_1800D8260(v18, shaders);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2919, 0LL);
		  if ( !Patch )
		    goto LABEL_11;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1075(
		    Patch,
		    (Object *)materialCollector,
		    frostedGlassPSMaterials,
		    (Object *)defaultResources,
		    0LL);
		}
		
		internal static void DisposeFrostedGlassPSMaterials(ref FrostedGlassPSMaterials frostedGlassPSMaterials) {} // 0x00000001837DCA60-0x00000001837DCB40
		// Void DisposeFrostedGlassPSMaterials(UberPostPassUtils+FrostedGlassPSMaterials ByRef)
		void HG::Rendering::Runtime::UberPostPassUtils::DisposeFrostedGlassPSMaterials(
		        UberPostPassUtils_FrostedGlassPSMaterials *frostedGlassPSMaterials,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  int v4; // ebx
		  Material__Array *frostedGlass1stPassMaterials; // rcx
		  Object_1 *v6; // rsi
		  Material__Array *frostedGlass2ndPassMaterials; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2920, 0LL) )
		  {
		    v4 = 0;
		    while ( 1 )
		    {
		      frostedGlass1stPassMaterials = frostedGlassPSMaterials->frostedGlass1stPassMaterials;
		      if ( !frostedGlassPSMaterials->frostedGlass1stPassMaterials )
		        break;
		      if ( (unsigned int)v4 >= frostedGlass1stPassMaterials->max_length.size )
		        goto LABEL_14;
		      v6 = (Object_1 *)frostedGlass1stPassMaterials->vector[v4];
		      if ( !TypeInfo::UnityEngine::Rendering::CoreUtils->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::CoreUtils);
		      UnityEngine::Rendering::CoreUtils::Destroy(v6, 0LL);
		      frostedGlass2ndPassMaterials = frostedGlassPSMaterials->frostedGlass2ndPassMaterials;
		      if ( !frostedGlass2ndPassMaterials )
		        break;
		      if ( (unsigned int)v4 >= frostedGlass2ndPassMaterials->max_length.size )
		LABEL_14:
		        sub_1800D2AB0(frostedGlass1stPassMaterials, v3);
		      UnityEngine::Rendering::CoreUtils::Destroy((Object_1 *)frostedGlass2ndPassMaterials->vector[v4], 0LL);
		      frostedGlass1stPassMaterials = frostedGlassPSMaterials->frostedGlass1stPassMaterials;
		      if ( !frostedGlassPSMaterials->frostedGlass1stPassMaterials )
		        break;
		      sub_1800020D0(frostedGlass1stPassMaterials, v4, 0LL);
		      frostedGlass1stPassMaterials = frostedGlassPSMaterials->frostedGlass2ndPassMaterials;
		      if ( !frostedGlass1stPassMaterials )
		        break;
		      sub_1800020D0(frostedGlass1stPassMaterials, v4++, 0LL);
		      if ( v4 >= 4 )
		        return;
		    }
		LABEL_13:
		    sub_1800D8260(frostedGlass1stPassMaterials, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2920, 0LL);
		  if ( !Patch )
		    goto LABEL_13;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1076(Patch, frostedGlassPSMaterials, 0LL);
		}
		
		internal static void PrepareFrostedGlassData(bool useComputeShader, HGRenderGraph renderGraph, FrostedGlassData data, HGCamera camera, TextureHandle source, ref FrostedGlassPSMaterials frostedGlassPSMaterials) {} // 0x0000000189B84E28-0x0000000189B850C0
		// Void PrepareFrostedGlassData(Boolean, HGRenderGraph, UberPostPassUtils+FrostedGlassData, HGCamera, TextureHandle, UberPostPassUtils+FrostedGlassPSMaterials ByRef)
		void HG::Rendering::Runtime::UberPostPassUtils::PrepareFrostedGlassData(
		        bool useComputeShader,
		        HGRenderGraph *renderGraph,
		        UberPostPassUtils_FrostedGlassData *data,
		        HGCamera *camera,
		        TextureHandle *source,
		        UberPostPassUtils_FrostedGlassPSMaterials *frostedGlassPSMaterials,
		        MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v11; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  int v13; // esi
		  Material__Array *frostedGlass1stPassMaterials; // rbx
		  Material__Array *frostedGlass1stPassMat; // rbp
		  Material *v16; // rbx
		  Material__Array *frostedGlass2ndPassMaterials; // rbx
		  Material__Array *frostedGlass2ndPassMat; // rbp
		  Material *v19; // rbx
		  HGRenderPipeline *currentPipeline; // rax
		  HGRenderPipelineRuntimeResources *defaultResources; // rax
		  HGRuntimeGrassQuery_Node *v22; // r8
		  Int32__Array **v23; // r9
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
		  int32_t Kernel; // eax
		  int32_t v26; // esi
		  float v27; // xmm6_4
		  Vector2Int__Array *mipsDownSize; // rbp
		  __int64 v29; // rcx
		  MethodInfo *v30; // [rsp+20h] [rbp-68h]
		  Vector2Int v31; // [rsp+40h] [rbp-48h]
		  TextureHandle v32; // [rsp+50h] [rbp-38h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2921, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2921, 0LL);
		    if ( !Patch )
		      goto LABEL_27;
		    v32 = *source;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1077(
		      Patch,
		      useComputeShader,
		      (Object *)renderGraph,
		      (Object *)data,
		      (Object *)camera,
		      &v32,
		      frostedGlassPSMaterials,
		      0LL);
		  }
		  else
		  {
		    if ( !useComputeShader )
		    {
		      v13 = 0;
		      if ( data )
		      {
		        while ( 1 )
		        {
		          frostedGlass1stPassMaterials = frostedGlassPSMaterials->frostedGlass1stPassMaterials;
		          if ( !frostedGlassPSMaterials->frostedGlass1stPassMaterials )
		            break;
		          if ( (unsigned int)v13 >= frostedGlass1stPassMaterials->max_length.size )
		            goto LABEL_25;
		          frostedGlass1stPassMat = data->fields.frostedGlass1stPassMat;
		          if ( !frostedGlass1stPassMat )
		            break;
		          v16 = frostedGlass1stPassMaterials->vector[v13];
		          sub_180031B10(data->fields.frostedGlass1stPassMat, v16);
		          sub_1800020D0(frostedGlass1stPassMat, v13, v16);
		          frostedGlass2ndPassMaterials = frostedGlassPSMaterials->frostedGlass2ndPassMaterials;
		          if ( !frostedGlass2ndPassMaterials )
		            break;
		          if ( (unsigned int)v13 >= frostedGlass2ndPassMaterials->max_length.size )
		LABEL_25:
		            sub_1800D2AB0(Patch, v11);
		          frostedGlass2ndPassMat = data->fields.frostedGlass2ndPassMat;
		          if ( !frostedGlass2ndPassMat )
		            break;
		          v19 = frostedGlass2ndPassMaterials->vector[v13];
		          sub_180031B10(data->fields.frostedGlass2ndPassMat, v19);
		          sub_1800020D0(frostedGlass2ndPassMat, v13++, v19);
		          if ( v13 >= 3 )
		            goto LABEL_19;
		        }
		      }
		LABEL_27:
		      sub_1800D8260(Patch, v11);
		    }
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		    currentPipeline = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
		    if ( !currentPipeline )
		      goto LABEL_27;
		    defaultResources = HG::Rendering::Runtime::HGRenderPipeline::get_defaultResources(currentPipeline, 0LL);
		    if ( !defaultResources )
		      goto LABEL_27;
		    shaders = defaultResources->fields.shaders;
		    if ( !shaders )
		      goto LABEL_27;
		    Patch = (ILFixDynamicMethodWrapper_2 *)shaders->fields.frostedGlassBlurCS;
		    if ( !data )
		      goto LABEL_27;
		    data->fields.frostedGlassBlurCS = (ComputeShader *)Patch;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&data->fields, v11, v22, v23, v30);
		    Patch = (ILFixDynamicMethodWrapper_2 *)data->fields.frostedGlassBlurCS;
		    if ( !Patch )
		      goto LABEL_27;
		    Kernel = UnityEngine::ComputeShader::FindKernel((ComputeShader *)Patch, (String *)"KMain", 0LL);
		    Patch = (ILFixDynamicMethodWrapper_2 *)data->fields.frostedGlassBlurCS;
		    data->fields.kernelKMain = Kernel;
		    if ( !Patch )
		      goto LABEL_27;
		    data->fields.kernelKMainWithLut = UnityEngine::ComputeShader::FindKernel(
		                                        (ComputeShader *)Patch,
		                                        (String *)"KMainWithLut",
		                                        0LL);
		LABEL_19:
		    data->fields.source = *source;
		    if ( !camera )
		      goto LABEL_27;
		    v26 = 0;
		    v27 = 0.25;
		    v32.handle = (ResourceHandle)camera->fields._taauRTSize_k__BackingField;
		    data->fields.downsampleNum = 3;
		    data->fields.colorThreshold = 2.5;
		    while ( v26 < data->fields.downsampleNum )
		    {
		      mipsDownSize = data->fields.mipsDownSize;
		      v31.m_X = sub_1832DBD50();
		      v31.m_Y = sub_1832DBD50();
		      if ( !mipsDownSize )
		        goto LABEL_27;
		      if ( (unsigned int)v26 >= mipsDownSize->max_length.size )
		        goto LABEL_25;
		      v27 = v27 * 0.5;
		      v29 = v26++;
		      mipsDownSize->vector[v29] = v31;
		    }
		  }
		}
		
		internal static void PrepareFrostedGlassLutData(bool useComputeShader, FrostedGlassData data, HGCamera camera, TextureHandle logLut, int lutSize) {} // 0x0000000189B850C0-0x0000000189B85468
		// Void PrepareFrostedGlassLutData(Boolean, UberPostPassUtils+FrostedGlassData, HGCamera, TextureHandle, Int32)
		void HG::Rendering::Runtime::UberPostPassUtils::PrepareFrostedGlassLutData(
		        bool useComputeShader,
		        UberPostPassUtils_FrostedGlassData *data,
		        HGCamera *camera,
		        TextureHandle *logLut,
		        int32_t lutSize,
		        MethodInfo *method)
		{
		  String **p_m_Name; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  float PostExposureLinear; // xmm0_4
		  TextureHandle v13; // xmm1
		  Material__Array *frostedGlass1stPassMat; // rax
		  Material *v15; // rdi
		  HGEnvironmentPhase *InterpolatedPhase; // rax
		  __int64 v17; // rdx
		  HGColorGradingConfig *v18; // rcx
		  HGColorGradingConfig *p_colorGradingConfig; // rax
		  Vector4 shadows; // xmm1
		  HGRuntimeGrassQuery_Node *v21; // r8
		  Int32__Array **v22; // r9
		  HGRuntimeGrassQuery_Node *v23; // rdx
		  HGRuntimeGrassQuery_Node *v24; // r8
		  Int32__Array **v25; // r9
		  TileBase *v26; // rdx
		  Vector3Int *v27; // r8
		  ITilemap *v28; // r9
		  Vector4 v29; // xmm1
		  Material__Array *v30; // rax
		  Material *v31; // rdi
		  int v32; // eax
		  int v33; // edi
		  int v34; // eax
		  int v35; // esi
		  int v36; // eax
		  MethodInfo *v37; // [rsp+28h] [rbp-E0h]
		  MethodInfo *v38; // [rsp+28h] [rbp-E0h]
		  Vector4 v39; // [rsp+48h] [rbp-C0h] BYREF
		  HGColorGradingConfig v40; // [rsp+58h] [rbp-B0h] BYREF
		
		  sub_18033B9D0(&v40, 0LL, 368LL);
		  if ( !IFix::WrappersManagerImpl::IsPatched(2922, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		    PostExposureLinear = HG::Rendering::Runtime::UberPostPassUtils::GetPostExposureLinear(camera, 0LL);
		    if ( !data )
		      goto LABEL_25;
		    Patch = (ILFixDynamicMethodWrapper_2 *)(unsigned int)lutSize;
		    v13 = *logLut;
		    v39.w = PostExposureLinear;
		    data->fields.logLut = v13;
		    v39.x = 1.0 / (float)(lutSize * lutSize);
		    v39.y = 1.0 / (float)lutSize;
		    v39.z = (float)lutSize - 1.0;
		    data->fields.logLutSettings = v39;
		    if ( !useComputeShader )
		    {
		      frostedGlass1stPassMat = data->fields.frostedGlass1stPassMat;
		      if ( !frostedGlass1stPassMat )
		        goto LABEL_25;
		      if ( !frostedGlass1stPassMat->max_length.size )
		        goto LABEL_16;
		      v15 = frostedGlass1stPassMat->vector[0];
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		      p_m_Name = &TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_EnableScreenSpaceShadowMask.m_Name;
		      if ( !v15 )
		        goto LABEL_25;
		      UnityEngine::Material::EnableKeyword(v15, p_m_Name[43], 0LL);
		    }
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		    InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(camera, 0LL);
		    if ( !InterpolatedPhase )
		      goto LABEL_25;
		    v17 = 2LL;
		    v18 = &v40;
		    p_colorGradingConfig = &InterpolatedPhase->fields.colorGradingConfig;
		    do
		    {
		      *(_OWORD *)&v18->tonemappingMode = *(_OWORD *)&p_colorGradingConfig->tonemappingMode;
		      *(_OWORD *)&v18->colorLookupContribution = *(_OWORD *)&p_colorGradingConfig->colorLookupContribution;
		      *(_OWORD *)&v18->colorAdjustmentsEnabled = *(_OWORD *)&p_colorGradingConfig->colorAdjustmentsEnabled;
		      *(_OWORD *)&v18->colorAdjustmentsColorFilter.g = *(_OWORD *)&p_colorGradingConfig->colorAdjustmentsColorFilter.g;
		      *(_OWORD *)&v18->colorAdjustmentsSaturation = *(_OWORD *)&p_colorGradingConfig->colorAdjustmentsSaturation;
		      *(_OWORD *)&v18->channelMixerRedOutBlueIn = *(_OWORD *)&p_colorGradingConfig->channelMixerRedOutBlueIn;
		      *(_OWORD *)&v18->channelMixerBlueOutRedIn = *(_OWORD *)&p_colorGradingConfig->channelMixerBlueOutRedIn;
		      v18 = (HGColorGradingConfig *)((char *)v18 + 128);
		      shadows = p_colorGradingConfig->shadowsMidtonesHighlights.shadows;
		      p_colorGradingConfig = (HGColorGradingConfig *)((char *)p_colorGradingConfig + 128);
		      *(Vector4 *)&v18[-1].colorCurves.masterOverriding = shadows;
		      --v17;
		    }
		    while ( v17 );
		    *(_OWORD *)&v18->tonemappingMode = *(_OWORD *)&p_colorGradingConfig->tonemappingMode;
		    *(_OWORD *)&v18->colorLookupContribution = *(_OWORD *)&p_colorGradingConfig->colorLookupContribution;
		    *(_OWORD *)&v18->colorAdjustmentsEnabled = *(_OWORD *)&p_colorGradingConfig->colorAdjustmentsEnabled;
		    *(_OWORD *)&v18->colorAdjustmentsColorFilter.g = *(_OWORD *)&p_colorGradingConfig->colorAdjustmentsColorFilter.g;
		    *(_OWORD *)&v18->colorAdjustmentsSaturation = *(_OWORD *)&p_colorGradingConfig->colorAdjustmentsSaturation;
		    *(_OWORD *)&v18->channelMixerRedOutBlueIn = *(_OWORD *)&p_colorGradingConfig->channelMixerRedOutBlueIn;
		    *(_OWORD *)&v18->channelMixerBlueOutRedIn = *(_OWORD *)&p_colorGradingConfig->channelMixerBlueOutRedIn;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
		    if ( !HG::Rendering::Runtime::HGColorGradingConfig::IsColorLookupEnabled(&v40, 0LL) )
		    {
		      data->fields.enableUserLut = 0;
		      data->fields.userLut = UnityEngine::Texture2D::get_blackTexture(0LL);
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&data->fields.userLut, v23, v24, v25, v37);
		      v29 = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		                                                        (TileAnimationData *)&v39,
		                                                        v26,
		                                                        v27,
		                                                        v28,
		                                                        v38));
		LABEL_23:
		      data->fields.userLogLutSettings = v29;
		      return;
		    }
		    data->fields.enableUserLut = 1;
		    if ( useComputeShader )
		      goto LABEL_19;
		    v30 = data->fields.frostedGlass1stPassMat;
		    if ( v30 )
		    {
		      if ( !v30->max_length.size )
		LABEL_16:
		        sub_1800D2AB0(Patch, p_m_Name);
		      v31 = v30->vector[0];
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		      p_m_Name = &TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_EnableScreenSpaceShadowMask.m_Name;
		      if ( v31 )
		      {
		        UnityEngine::Material::EnableKeyword(v31, p_m_Name[44], 0LL);
		LABEL_19:
		        data->fields.userLut = v40.colorLookupTexture;
		        sub_18002D1B0(
		          (HGRuntimeGrassQuery_Node *)&data->fields.userLut,
		          (HGRuntimeGrassQuery_Node *)p_m_Name,
		          v21,
		          v22,
		          v37);
		        p_m_Name = (String **)v40.colorLookupTexture;
		        if ( v40.colorLookupTexture )
		        {
		          v32 = sub_180002F70(5LL, v40.colorLookupTexture);
		          p_m_Name = (String **)v40.colorLookupTexture;
		          v33 = v32;
		          if ( v40.colorLookupTexture )
		          {
		            v34 = sub_180002F70(7LL, v40.colorLookupTexture);
		            p_m_Name = (String **)v40.colorLookupTexture;
		            v35 = v34;
		            if ( v40.colorLookupTexture )
		            {
		              v36 = sub_180002F70(7LL, v40.colorLookupTexture);
		              v39.x = 1.0 / (float)v33;
		              v39.y = 1.0 / (float)v35;
		              v39.w = v40.colorLookupContribution;
		              v39.z = (float)v36 - 1.0;
		              v29 = v39;
		              goto LABEL_23;
		            }
		          }
		        }
		      }
		    }
		LABEL_25:
		    sub_1800D8260(Patch, p_m_Name);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2922, 0LL);
		  if ( !Patch )
		    goto LABEL_25;
		  v39 = (Vector4)*logLut;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1078(
		    Patch,
		    useComputeShader,
		    (Object *)data,
		    (Object *)camera,
		    (TextureHandle *)&v39,
		    lutSize,
		    0LL);
		}
		
		internal static void PrepareFrostedGlassSceneRTs(bool useComputeShader, HGRenderGraph renderGraph, FrostedGlassData data, ref RTHandle[] sceneFrostedGlassRTs, ref Vector2Int[] sceneFrostedGlassRTSizes) {} // 0x0000000189B85468-0x0000000189B85804
		// Void PrepareFrostedGlassSceneRTs(Boolean, HGRenderGraph, UberPostPassUtils+FrostedGlassData, RTHandle[] ByRef, Vector2Int[] ByRef)
		void HG::Rendering::Runtime::UberPostPassUtils::PrepareFrostedGlassSceneRTs(
		        bool useComputeShader,
		        HGRenderGraph *renderGraph,
		        UberPostPassUtils_FrostedGlassData *data,
		        RTHandle__Array **sceneFrostedGlassRTs,
		        Vector2Int__Array **sceneFrostedGlassRTSizes,
		        MethodInfo *method)
		{
		  __int64 v10; // rdx
		  ILFixDynamicMethodWrapper_2 *mipsDownSize; // rcx
		  int v12; // edi
		  Vector2Int__Array **v13; // r12
		  Vector2Int v14; // rbx
		  RTHandle *v15; // rcx
		  RTHandle__Array *v16; // r15
		  RTHandle *v17; // rax
		  RTHandle *v18; // r12
		  TextureHandle__Array *mipsDown; // r15
		  RTHandle__Array *v20; // r8
		  TextureHandle *v21; // rax
		  HGRuntimeGrassQuery_Node *v22; // rdx
		  HGRuntimeGrassQuery_Node *v23; // r8
		  Int32__Array **v24; // r9
		  TextureHandle__Array *mipsDownTemp; // rbx
		  TextureHandle *v26; // rax
		  TextureHandle__Array *v27; // rcx
		  MethodInfo *colorFormat; // [rsp+28h] [rbp-100h]
		  int32_t width[2]; // [rsp+A8h] [rbp-80h] BYREF
		  TextureHandle v30; // [rsp+B8h] [rbp-70h] BYREF
		  _DWORD v31[4]; // [rsp+C8h] [rbp-60h] BYREF
		  TextureDesc v32; // [rsp+D8h] [rbp-50h] BYREF
		  TextureDesc v33; // [rsp+138h] [rbp+10h] BYREF
		  TextureHandle v34; // [rsp+198h] [rbp+70h] BYREF
		  TextureHandle v35; // [rsp+1A8h] [rbp+80h] BYREF
		  TextureHandle v36; // [rsp+1B8h] [rbp+90h] BYREF
		
		  sub_18033B9D0(&v33, 0LL, 96LL);
		  sub_18033B9D0(&v32, 0LL, 96LL);
		  if ( !IFix::WrappersManagerImpl::IsPatched(2923, 0LL) )
		  {
		    v12 = 0;
		    if ( data )
		    {
		      v13 = sceneFrostedGlassRTSizes;
		      while ( 1 )
		      {
		        mipsDownSize = (ILFixDynamicMethodWrapper_2 *)data->fields.mipsDownSize;
		        if ( !mipsDownSize )
		          break;
		        sub_180036DD0(mipsDownSize, width, v12);
		        mipsDownSize = (ILFixDynamicMethodWrapper_2 *)*sceneFrostedGlassRTs;
		        if ( !*sceneFrostedGlassRTs )
		          break;
		        if ( (unsigned int)v12 >= mipsDownSize->fields.methodId )
		          goto LABEL_33;
		        v14 = *(Vector2Int *)width;
		        if ( !*((_QWORD *)&mipsDownSize->fields.anonObj + v12) )
		          goto LABEL_11;
		        mipsDownSize = (ILFixDynamicMethodWrapper_2 *)*v13;
		        if ( !*v13 )
		          break;
		        sub_180036DD0(mipsDownSize, v31, v12);
		        if ( v31[0] != v14.m_X
		          || (mipsDownSize = (ILFixDynamicMethodWrapper_2 *)HIDWORD(*(unsigned __int64 *)&v14), v31[1] != v14.m_Y) )
		        {
		LABEL_11:
		          mipsDownSize = (ILFixDynamicMethodWrapper_2 *)*sceneFrostedGlassRTs;
		          if ( !*sceneFrostedGlassRTs )
		            break;
		          if ( (unsigned int)v12 >= mipsDownSize->fields.methodId )
		            goto LABEL_33;
		          v15 = (RTHandle *)*((_QWORD *)&mipsDownSize->fields.anonObj + v12);
		          if ( v15 )
		            UnityEngine::Rendering::RTHandle::Release(v15, 0LL);
		          v16 = *sceneFrostedGlassRTs;
		          sub_1800036A0(TypeInfo::UnityEngine::Rendering::RTHandles);
		          v17 = UnityEngine::Rendering::RTHandles::Alloc(
		                  v14.m_X,
		                  width[1],
		                  1,
		                  DepthBits__Enum_None,
		                  GraphicsFormat__Enum_B10G11R11_UFloatPack32,
		                  FilterMode__Enum_Bilinear,
		                  TextureWrapMode__Enum_Clamp,
		                  TextureDimension__Enum_Tex2D,
		                  1,
		                  0,
		                  0,
		                  0,
		                  1,
		                  0.0,
		                  MSAASamples__Enum_None,
		                  0,
		                  RenderTextureMemoryless__Enum_None,
		                  (String *)"FrostedGlassMipDown",
		                  0LL);
		          v18 = v17;
		          if ( !v16 )
		            break;
		          sub_180031B10(v16, v17);
		          sub_180378FEC(v16, v12, v18);
		          mipsDownSize = (ILFixDynamicMethodWrapper_2 *)*sceneFrostedGlassRTSizes;
		          if ( !*sceneFrostedGlassRTSizes )
		            break;
		          if ( (unsigned int)v12 >= mipsDownSize->fields.methodId )
		            goto LABEL_33;
		          v13 = sceneFrostedGlassRTSizes;
		          *((Vector2Int *)&mipsDownSize->fields.anonObj + v12) = v14;
		        }
		        mipsDown = data->fields.mipsDown;
		        v20 = *sceneFrostedGlassRTs;
		        if ( useComputeShader )
		        {
		          if ( !v20 )
		            break;
		          if ( (unsigned int)v12 >= v20->max_length.size )
		LABEL_33:
		            sub_1800D2AB0(mipsDownSize, v10);
		          if ( !renderGraph )
		            break;
		          v26 = HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(&v36, renderGraph, v20->vector[v12], 0LL);
		          if ( !mipsDown )
		            break;
		          v27 = mipsDown;
		        }
		        else
		        {
		          if ( !v20 )
		            break;
		          if ( (unsigned int)v12 >= v20->max_length.size )
		            goto LABEL_33;
		          if ( !renderGraph )
		            break;
		          v21 = HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(&v34, renderGraph, v20->vector[v12], 0LL);
		          if ( !mipsDown )
		            break;
		          v30 = *v21;
		          sub_180430AC4(mipsDown, v12, &v30);
		          HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v32, v14, 0LL);
		          v32.name = (String *)"FrostedGlassMipDownTemp";
		          v32.colorFormat = 74;
		          v32.enableRandomWrite = 0;
		          sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v32.name, v22, v23, v24, colorFormat);
		          mipsDownTemp = data->fields.mipsDownTemp;
		          v32.wrapMode = 1;
		          v32.filterMode = 1;
		          v33 = v32;
		          v26 = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(&v35, renderGraph, &v33, 0LL);
		          if ( !mipsDownTemp )
		            break;
		          v27 = mipsDownTemp;
		        }
		        v30 = *v26;
		        sub_180430AC4(v27, v12++, &v30);
		        if ( v12 >= 3 )
		          return;
		      }
		    }
		LABEL_35:
		    sub_1800D8260(mipsDownSize, v10);
		  }
		  mipsDownSize = IFix::WrappersManagerImpl::GetPatch(2923, 0LL);
		  if ( !mipsDownSize )
		    goto LABEL_35;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1079(
		    mipsDownSize,
		    useComputeShader,
		    (Object *)renderGraph,
		    (Object *)data,
		    sceneFrostedGlassRTs,
		    sceneFrostedGlassRTSizes,
		    0LL);
		}
		
		internal static void PrepareFrostedGlassUIRTs(bool useComputeShader, HGRenderGraph renderGraph, FrostedGlassData data) {} // 0x0000000189B85804-0x0000000189B85A68
		// Void PrepareFrostedGlassUIRTs(Boolean, HGRenderGraph, UberPostPassUtils+FrostedGlassData)
		void HG::Rendering::Runtime::UberPostPassUtils::PrepareFrostedGlassUIRTs(
		        bool useComputeShader,
		        HGRenderGraph *renderGraph,
		        UberPostPassUtils_FrostedGlassData *data,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  Vector2Int__Array *mipsDownSize; // rcx
		  int32_t v9; // ebx
		  HGRuntimeGrassQuery_Node *v10; // rdx
		  HGRuntimeGrassQuery_Node *v11; // r8
		  Int32__Array **v12; // r9
		  TextureHandle__Array *mipsDown; // r14
		  TextureHandle *v14; // rax
		  HGRuntimeGrassQuery_Node *v15; // rdx
		  HGRuntimeGrassQuery_Node *v16; // r8
		  Int32__Array **v17; // r9
		  TextureHandle__Array *mipsDownTemp; // r14
		  TextureHandle *v19; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v21; // [rsp+28h] [rbp-E0h]
		  _BYTE v22[104]; // [rsp+30h] [rbp-D8h] BYREF
		  Vector2Int size; // [rsp+98h] [rbp-70h] BYREF
		  Vector2Int v24; // [rsp+A0h] [rbp-68h] BYREF
		  TextureHandle v25; // [rsp+A8h] [rbp-60h] BYREF
		  TextureDesc v26; // [rsp+B8h] [rbp-50h] BYREF
		  TextureHandle v27; // [rsp+118h] [rbp+10h] BYREF
		  TextureHandle v28; // [rsp+128h] [rbp+20h] BYREF
		
		  sub_18033B9D0(&v26, 0LL, 96LL);
		  sub_18033B9D0(&v22[8], 0LL, 96LL);
		  if ( IFix::WrappersManagerImpl::IsPatched(2924, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2924, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_38(
		        (ILFixDynamicMethodWrapper_18 *)Patch,
		        useComputeShader,
		        (String *)renderGraph,
		        (String *)data,
		        0LL);
		      return;
		    }
		LABEL_13:
		    sub_1800D8260(mipsDownSize, v7);
		  }
		  v9 = 0;
		  if ( !data )
		    goto LABEL_13;
		  while ( v9 < data->fields.downsampleNum )
		  {
		    mipsDownSize = data->fields.mipsDownSize;
		    if ( !mipsDownSize )
		      goto LABEL_13;
		    sub_180036DD0(mipsDownSize, &size, v9);
		    HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc((TextureDesc *)&v22[8], size, 0LL);
		    *(_QWORD *)&v22[64] = "FrostedGlassMipDown";
		    *(_DWORD *)&v22[24] = 74;
		    v22[40] = useComputeShader;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v22[64], v10, v11, v12, v21);
		    *(_DWORD *)&v22[32] = 1;
		    *(_DWORD *)&v22[28] = 1;
		    v26 = *(TextureDesc *)&v22[8];
		    if ( !useComputeShader )
		    {
		      mipsDown = data->fields.mipsDown;
		      if ( !renderGraph )
		        goto LABEL_13;
		      v14 = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(&v27, renderGraph, &v26, 0LL);
		      if ( !mipsDown )
		        goto LABEL_13;
		      v25 = *v14;
		      sub_180430AC4(mipsDown, v9, &v25);
		      mipsDownSize = data->fields.mipsDownSize;
		      if ( !mipsDownSize )
		        goto LABEL_13;
		      sub_180036DD0(mipsDownSize, &v24, v9);
		      HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc((TextureDesc *)&v22[8], v24, 0LL);
		      *(_QWORD *)&v22[64] = "FrostedGlassMipDownTemp";
		      *(_DWORD *)&v22[24] = 74;
		      v22[40] = 0;
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v22[64], v15, v16, v17, v21);
		      mipsDownTemp = data->fields.mipsDownTemp;
		      *(_DWORD *)&v22[32] = 1;
		      *(_DWORD *)&v22[28] = 1;
		      v26 = *(TextureDesc *)&v22[8];
		      v19 = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(&v28, renderGraph, &v26, 0LL);
		      if ( !mipsDownTemp )
		        goto LABEL_13;
		      v25 = *v19;
		      sub_180430AC4(mipsDownTemp, v9, &v25);
		    }
		    ++v9;
		  }
		}
		
		private static TextureHandle FrostedGlassAddPass(FrostedGlassData data, HGRenderGraph renderGraph, bool useComputeShader) => default; // 0x0000000189B81424-0x0000000189B81AA4
		// TextureHandle FrostedGlassAddPass(UberPostPassUtils+FrostedGlassData, HGRenderGraph, Boolean)
		// Hidden C++ exception states: #wind=1 #try_helpers=1
		TextureHandle *HG::Rendering::Runtime::UberPostPassUtils::FrostedGlassAddPass(
		        TextureHandle *__return_ptr retstr,
		        UberPostPassUtils_FrostedGlassData *data,
		        HGRenderGraph *renderGraph,
		        bool useComputeShader,
		        MethodInfo *method)
		{
		  ProfilingSampler *v9; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  unsigned __int64 v12; // rdx
		  __int64 v13; // rcx
		  __int64 downsampleNum; // rcx
		  __int64 v15; // rax
		  signed __int64 userLut; // rcx
		  unsigned __int64 v17; // r8
		  signed __int64 v18; // rtt
		  __m128i v19; // xmm0
		  __m128i v20; // xmm0
		  Vector2Int__Array *mipsDownSize; // r8
		  __int64 v22; // rdx
		  __int64 v23; // rcx
		  TextureHandle__Array *mipsDown; // r8
		  unsigned __int64 v25; // rdx
		  __int64 v26; // rcx
		  Material__Array *frostedGlass1stPassMat; // r8
		  __int64 v28; // rdx
		  __int64 v29; // rcx
		  Material__Array *frostedGlass2ndPassMat; // r8
		  __int64 v31; // rdx
		  __int64 v32; // rcx
		  TextureHandle__Array *mipsDownTemp; // r8
		  __int64 v34; // rdx
		  __int64 v35; // rcx
		  int j; // esi
		  __int64 v37; // rcx
		  TextureHandle *v38; // rax
		  __int64 v39; // rdx
		  __int64 v40; // rcx
		  __int64 v41; // rcx
		  TextureHandle *v42; // rax
		  __int64 v43; // rdx
		  __int64 v44; // r9
		  __int64 v45; // r8
		  unsigned int v46; // r8d
		  char v47; // r8
		  signed __int64 v48; // rtt
		  __int64 kernelKMain; // rcx
		  __int64 kernelKMainWithLut; // rcx
		  int i; // esi
		  __int64 v52; // rcx
		  TextureHandle *v53; // rax
		  TextureHandle__Array *v54; // rcx
		  TextureHandle v55; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v57; // rdx
		  __int64 v58; // rcx
		  TextureHandle *result; // rax
		  __int64 v60; // [rsp+40h] [rbp-88h] BYREF
		  TextureHandle v61; // [rsp+48h] [rbp-80h] BYREF
		  HGRenderGraphBuilder v62; // [rsp+58h] [rbp-70h] BYREF
		  TextureHandle v63[2]; // [rsp+78h] [rbp-50h] BYREF
		  TextureHandle v64; // [rsp+98h] [rbp-30h] BYREF
		
		  memset(&v62, 0, sizeof(v62));
		  v60 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(2925, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2925, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v58, v57);
		    v55 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1081(
		             v63,
		             Patch,
		             (Object *)data,
		             (Object *)renderGraph,
		             useComputeShader,
		             0LL);
		  }
		  else
		  {
		    v9 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		           (Int32Enum__Enum)0x9Cu,
		           MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    if ( !renderGraph )
		      sub_1800D8260(v11, v10);
		    v62 = *(HGRenderGraphBuilder *)sub_1808AF064(
		                                     (unsigned int)v63,
		                                     (_DWORD)renderGraph,
		                                     (unsigned int)"Frosted Glass",
		                                     (unsigned int)&v60,
		                                     (__int64)v9);
		    v61.handle = 0LL;
		    v61.fallBackResource = (ResourceHandle)&v62;
		    if ( !data )
		      sub_1800D8250(v13, v12);
		    downsampleNum = (unsigned int)data->fields.downsampleNum;
		    if ( !v60 )
		      sub_1800D8250(downsampleNum, v12);
		    *(_DWORD *)(v60 + 56) = downsampleNum;
		    if ( !v60 )
		      sub_1800D8250(downsampleNum, v12);
		    *(TextureHandle *)(v60 + 72) = data->fields.source;
		    LOBYTE(downsampleNum) = data->fields.enableUserLut;
		    if ( !v60 )
		      sub_1800D8250(downsampleNum, v12);
		    *(_BYTE *)(v60 + 104) = downsampleNum;
		    if ( !v60 )
		      sub_1800D8250(downsampleNum, v12);
		    *(float *)(v60 + 108) = data->fields.colorThreshold;
		    v15 = v60;
		    userLut = (signed __int64)data->fields.userLut;
		    if ( !v60 )
		      sub_1800D8250(userLut, v12);
		    *(_QWORD *)(v60 + 112) = userLut;
		    if ( dword_18F35FD08 )
		    {
		      v17 = (((unsigned __int64)(v15 + 112) >> 12) & 0x1FFFFF) >> 6;
		      v12 = ((unsigned __int64)(v15 + 112) >> 12) & 0x3F;
		      _m_prefetchw(&qword_18F0BCBA0[v17 + 36190]);
		      do
		      {
		        userLut = qword_18F0BCBA0[v17 + 36190] | (1LL << v12);
		        v18 = qword_18F0BCBA0[v17 + 36190];
		      }
		      while ( v18 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v17 + 36190], userLut, v18) );
		    }
		    v19 = _mm_loadu_si128((const __m128i *)&data->fields.userLogLutSettings);
		    if ( !v60 )
		      sub_1800D8250(userLut, v12);
		    *(__m128i *)(v60 + 120) = v19;
		    if ( !v60 )
		      sub_1800D8250(userLut, v12);
		    *(TextureHandle *)(v60 + 136) = data->fields.logLut;
		    v20 = _mm_loadu_si128((const __m128i *)&data->fields.logLutSettings);
		    if ( !v60 )
		      sub_1800D8250(userLut, v12);
		    *(__m128i *)(v60 + 152) = v20;
		    if ( !v60 )
		      sub_1800D8250(userLut, v12);
		    *(_BYTE *)(v60 + 32) = 1;
		    if ( !v60 )
		      sub_1800D8250(userLut, v12);
		    mipsDownSize = data->fields.mipsDownSize;
		    if ( !mipsDownSize )
		      sub_1800D8250(userLut, v12);
		    System::Array::Copy((Array *)data->fields.mipsDownSize, *(Array **)(v60 + 64), mipsDownSize->max_length.size, 0LL);
		    if ( !v60 )
		      sub_1800D8250(v23, v22);
		    mipsDown = data->fields.mipsDown;
		    if ( !mipsDown )
		      sub_1800D8250(v23, v22);
		    System::Array::Copy((Array *)data->fields.mipsDown, *(Array **)(v60 + 88), mipsDown->max_length.size, 0LL);
		    if ( useComputeShader )
		    {
		      v45 = v60;
		      if ( !v60 )
		        sub_1800D8250(v26, v25);
		      *(_QWORD *)(v60 + 16) = data->fields.frostedGlassBlurCS;
		      if ( dword_18F35FD08 )
		      {
		        v46 = ((unsigned __int64)(v45 + 16) >> 12) & 0x1FFFFF;
		        v25 = (unsigned __int64)v46 >> 6;
		        v47 = v46 & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v25 + 36190]);
		        do
		          v48 = qword_18F0BCBA0[v25 + 36190];
		        while ( v48 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v25 + 36190], v48 | (1LL << v47), v48) );
		      }
		      kernelKMain = (unsigned int)data->fields.kernelKMain;
		      if ( !v60 )
		        sub_1800D8250(kernelKMain, v25);
		      *(_DWORD *)(v60 + 24) = kernelKMain;
		      kernelKMainWithLut = (unsigned int)data->fields.kernelKMainWithLut;
		      if ( !v60 )
		        sub_1800D8250(kernelKMainWithLut, v25);
		      *(_DWORD *)(v60 + 28) = kernelKMainWithLut;
		      for ( i = 0; i < 3; ++i )
		      {
		        if ( !v60 )
		          sub_1800D8250(kernelKMainWithLut, v25);
		        v52 = *(_QWORD *)(v60 + 88);
		        if ( !v52 )
		          sub_1800D8250(0LL, v25);
		        v53 = (TextureHandle *)sub_1803C0774(v52, i);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(v63, &v62, v53, 0LL);
		      }
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(v63, &v62, &data->fields.source, 0LL);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(v63, &v62, &data->fields.logLut, 0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v62,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->s_frostedGlassCSRenderFunc,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::UberPostPassUtils::FrostedGlassPassData>);
		      sub_180268AE0(&v61);
		    }
		    else
		    {
		      if ( !v60 )
		        sub_1800D8250(v26, v25);
		      frostedGlass1stPassMat = data->fields.frostedGlass1stPassMat;
		      if ( !frostedGlass1stPassMat )
		        sub_1800D8250(v26, v25);
		      System::Array::Copy(
		        (Array *)data->fields.frostedGlass1stPassMat,
		        *(Array **)(v60 + 40),
		        frostedGlass1stPassMat->max_length.size,
		        0LL);
		      if ( !v60 )
		        sub_1800D8250(v29, v28);
		      frostedGlass2ndPassMat = data->fields.frostedGlass2ndPassMat;
		      if ( !frostedGlass2ndPassMat )
		        sub_1800D8250(v29, v28);
		      System::Array::Copy(
		        (Array *)data->fields.frostedGlass2ndPassMat,
		        *(Array **)(v60 + 48),
		        frostedGlass2ndPassMat->max_length.size,
		        0LL);
		      if ( !v60 )
		        sub_1800D8250(v32, v31);
		      mipsDownTemp = data->fields.mipsDownTemp;
		      if ( !mipsDownTemp )
		        sub_1800D8250(v32, v31);
		      System::Array::Copy((Array *)data->fields.mipsDownTemp, *(Array **)(v60 + 96), mipsDownTemp->max_length.size, 0LL);
		      for ( j = 0; j < 3; ++j )
		      {
		        if ( !v60 )
		          sub_1800D8250(v35, v34);
		        v37 = *(_QWORD *)(v60 + 88);
		        if ( !v37 )
		          sub_1800D8250(0LL, v34);
		        v38 = (TextureHandle *)sub_1803C0774(v37, j);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadWriteTexture(&v64, &v62, v38, 0LL);
		        if ( !v60 )
		          sub_1800D8250(v40, v39);
		        v41 = *(_QWORD *)(v60 + 96);
		        if ( !v41 )
		          sub_1800D8250(0LL, v39);
		        v42 = (TextureHandle *)sub_1803C0774(v41, j);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadWriteTexture(v63, &v62, v42, 0LL);
		      }
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(v63, &v62, &data->fields.source, 0LL);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(v63, &v62, &data->fields.logLut, 0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v62,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->s_frostedGlassPSRenderFunc,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::UberPostPassUtils::FrostedGlassPassData>);
		      sub_180268AE0(&v61);
		    }
		    v54 = data->fields.mipsDown;
		    if ( !v54 )
		      sub_1800D8250(0LL, v43);
		    sub_1803C0830(v54, &v61, data->fields.downsampleNum - 1, v44);
		    v55 = v61;
		  }
		  result = retstr;
		  *retstr = v55;
		  return result;
		}
		
		private static void FrostedGlassAddSkipPass(bool isSceneViewCam, bool enablePermanentSceneFrostedGlass, HGRenderGraph renderGraph, ref RTHandle[] sceneFrostedGlassRTs) {} // 0x0000000189B81AA4-0x0000000189B82068
		// Void FrostedGlassAddSkipPass(Boolean, Boolean, HGRenderGraph, RTHandle[] ByRef)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::UberPostPassUtils::FrostedGlassAddSkipPass(
		        bool isSceneViewCam,
		        bool enablePermanentSceneFrostedGlass,
		        HGRenderGraph *renderGraph,
		        RTHandle__Array **sceneFrostedGlassRTs,
		        MethodInfo *method)
		{
		  ProfilingSampler *v9; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  __int64 v12; // rdx
		  __int64 v13; // r8
		  Object *v14; // rbx
		  RTHandle__Array *v15; // rcx
		  Texture *v16; // rax
		  unsigned __int64 v17; // rdx
		  __int64 v18; // rcx
		  unsigned __int64 v19; // r8
		  signed __int64 v20; // rtt
		  Object *v21; // rsi
		  RTHandle__Array *v22; // rcx
		  Texture *v23; // rax
		  unsigned __int64 v24; // rdx
		  __int64 v25; // rcx
		  unsigned __int64 v26; // r8
		  signed __int64 v27; // rtt
		  Object *v28; // rsi
		  RTHandle__Array *v29; // rcx
		  Texture *v30; // rax
		  __int64 v31; // rdx
		  __int64 v32; // rcx
		  unsigned __int64 v33; // r8
		  signed __int64 v34; // rtt
		  Texture2D *grayTexture; // rax
		  __int64 v36; // rdx
		  __int64 v37; // rcx
		  unsigned __int64 v38; // r8
		  signed __int64 v39; // rtt
		  Object *v40; // rsi
		  Texture2D *v41; // rax
		  __int64 v42; // rdx
		  __int64 v43; // rcx
		  unsigned __int64 v44; // r8
		  signed __int64 v45; // rtt
		  Object *v46; // rsi
		  Texture2D *v47; // rax
		  __int64 v48; // rdx
		  __int64 v49; // rcx
		  unsigned __int64 v50; // r8
		  signed __int64 v51; // rtt
		  Texture2D *blackTexture; // rax
		  __int64 v53; // rdx
		  __int64 v54; // rcx
		  unsigned __int64 v55; // r8
		  signed __int64 v56; // rtt
		  Object *v57; // rsi
		  Texture2D *v58; // rax
		  __int64 v59; // rdx
		  __int64 v60; // rcx
		  unsigned __int64 v61; // r8
		  signed __int64 v62; // rtt
		  Object *v63; // rsi
		  Texture2D *v64; // rax
		  __int64 v65; // rdx
		  __int64 v66; // rcx
		  unsigned __int64 v67; // r8
		  signed __int64 v68; // rtt
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v70; // rdx
		  __int64 v71; // rcx
		  Object *v72; // [rsp+40h] [rbp-78h] BYREF
		  Il2CppExceptionWrapper *v73; // [rsp+50h] [rbp-68h] BYREF
		  HGRenderGraphBuilder v74; // [rsp+58h] [rbp-60h] BYREF
		  HGRenderGraphBuilder v75; // [rsp+78h] [rbp-40h] BYREF
		
		  v72 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(2926, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2926, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v71, v70);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1082(
		      Patch,
		      isSceneViewCam,
		      enablePermanentSceneFrostedGlass,
		      (Object *)renderGraph,
		      sceneFrostedGlassRTs,
		      0LL);
		  }
		  else
		  {
		    v9 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		           (Int32Enum__Enum)0x9Cu,
		           MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    if ( !renderGraph )
		      sub_1800D8260(v11, v10);
		    HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		      &v74,
		      renderGraph,
		      (String *)"Frosted Glass",
		      &v72,
		      v9,
		      1,
		      ProfilingHGPass__Enum_None,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::UberPostPassUtils::FrostedGlassSkipPassData>);
		    v75 = v74;
		    v74.m_RenderPass = 0LL;
		    v74.m_Resources = (HGRenderGraphResourceRegistry *)&v75;
		    try
		    {
		      v14 = v72;
		      if ( isSceneViewCam )
		      {
		        blackTexture = UnityEngine::Texture2D::get_blackTexture(0LL);
		        if ( !v14 )
		          sub_1800D8250(v54, v53);
		        v14[1].klass = (Object__Class *)blackTexture;
		        if ( dword_18F35FD08 )
		        {
		          v55 = (((unsigned __int64)&v14[1] >> 12) & 0x1FFFFF) >> 6;
		          _m_prefetchw(&qword_18F0BCBA0[v55 + 36190]);
		          do
		            v56 = qword_18F0BCBA0[v55 + 36190];
		          while ( v56 != _InterlockedCompareExchange64(
		                           &qword_18F0BCBA0[v55 + 36190],
		                           v56 | (1LL << (((unsigned __int64)&v14[1] >> 12) & 0x3F)),
		                           v56) );
		        }
		        v57 = v72;
		        v58 = UnityEngine::Texture2D::get_blackTexture(0LL);
		        if ( !v57 )
		          sub_1800D8250(v60, v59);
		        v57[1].monitor = (MonitorData *)v58;
		        if ( dword_18F35FD08 )
		        {
		          v61 = (((unsigned __int64)&v57[1].monitor >> 12) & 0x1FFFFF) >> 6;
		          _m_prefetchw(&qword_18F0BCBA0[v61 + 36190]);
		          do
		            v62 = qword_18F0BCBA0[v61 + 36190];
		          while ( v62 != _InterlockedCompareExchange64(
		                           &qword_18F0BCBA0[v61 + 36190],
		                           v62 | (1LL << (((unsigned __int64)&v57[1].monitor >> 12) & 0x3F)),
		                           v62) );
		        }
		        v63 = v72;
		        v64 = UnityEngine::Texture2D::get_blackTexture(0LL);
		        if ( !v63 )
		          sub_1800D8250(v66, v65);
		        v63[2].klass = (Object__Class *)v64;
		        if ( dword_18F35FD08 )
		        {
		          v67 = (((unsigned __int64)&v63[2] >> 12) & 0x1FFFFF) >> 6;
		          _m_prefetchw(&qword_18F0BCBA0[v67 + 36190]);
		          do
		            v68 = qword_18F0BCBA0[v67 + 36190];
		          while ( v68 != _InterlockedCompareExchange64(
		                           &qword_18F0BCBA0[v67 + 36190],
		                           v68 | (1LL << (((unsigned __int64)&v63[2] >> 12) & 0x3F)),
		                           v68) );
		        }
		      }
		      else if ( enablePermanentSceneFrostedGlass )
		      {
		        v15 = *sceneFrostedGlassRTs;
		        if ( !*sceneFrostedGlassRTs )
		          sub_1800D8250(0LL, v12);
		        if ( !v15->max_length.size )
		          sub_1800D2AA0(v15, v12, v13);
		        v16 = UnityEngine::Rendering::RTHandle::op_Implicit(v15->vector[0], 0LL);
		        if ( !v14 )
		          sub_1800D8250(v18, v17);
		        v14[2].klass = (Object__Class *)v16;
		        if ( dword_18F35FD08 )
		        {
		          v19 = (((unsigned __int64)&v14[2] >> 12) & 0x1FFFFF) >> 6;
		          v17 = ((unsigned __int64)&v14[2] >> 12) & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v19 + 36190]);
		          do
		            v20 = qword_18F0BCBA0[v19 + 36190];
		          while ( v20 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v19 + 36190], v20 | (1LL << v17), v20) );
		        }
		        v21 = v72;
		        v22 = *sceneFrostedGlassRTs;
		        if ( !*sceneFrostedGlassRTs )
		          sub_1800D8250(0LL, v17);
		        if ( v22->max_length.size <= 1u )
		          sub_1800D2AA0(v22, v17, v19);
		        v23 = UnityEngine::Rendering::RTHandle::op_Implicit(v22->vector[1], 0LL);
		        if ( !v21 )
		          sub_1800D8250(v25, v24);
		        v21[1].monitor = (MonitorData *)v23;
		        if ( dword_18F35FD08 )
		        {
		          v26 = (((unsigned __int64)&v21[1].monitor >> 12) & 0x1FFFFF) >> 6;
		          v24 = ((unsigned __int64)&v21[1].monitor >> 12) & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v26 + 36190]);
		          do
		            v27 = qword_18F0BCBA0[v26 + 36190];
		          while ( v27 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v26 + 36190], v27 | (1LL << v24), v27) );
		        }
		        v28 = v72;
		        v29 = *sceneFrostedGlassRTs;
		        if ( !*sceneFrostedGlassRTs )
		          sub_1800D8250(0LL, v24);
		        if ( v29->max_length.size <= 2u )
		          sub_1800D2AA0(v29, v24, v26);
		        v30 = UnityEngine::Rendering::RTHandle::op_Implicit(v29->vector[2], 0LL);
		        if ( !v28 )
		          sub_1800D8250(v32, v31);
		        v28[1].klass = (Object__Class *)v30;
		        if ( dword_18F35FD08 )
		        {
		          v33 = (((unsigned __int64)&v28[1] >> 12) & 0x1FFFFF) >> 6;
		          _m_prefetchw(&qword_18F0BCBA0[v33 + 36190]);
		          do
		            v34 = qword_18F0BCBA0[v33 + 36190];
		          while ( v34 != _InterlockedCompareExchange64(
		                           &qword_18F0BCBA0[v33 + 36190],
		                           v34 | (1LL << (((unsigned __int64)&v28[1] >> 12) & 0x3F)),
		                           v34) );
		        }
		      }
		      else
		      {
		        grayTexture = UnityEngine::Texture2D::get_grayTexture(0LL);
		        if ( !v14 )
		          sub_1800D8250(v37, v36);
		        v14[1].klass = (Object__Class *)grayTexture;
		        if ( dword_18F35FD08 )
		        {
		          v38 = (((unsigned __int64)&v14[1] >> 12) & 0x1FFFFF) >> 6;
		          _m_prefetchw(&qword_18F0BCBA0[v38 + 36190]);
		          do
		            v39 = qword_18F0BCBA0[v38 + 36190];
		          while ( v39 != _InterlockedCompareExchange64(
		                           &qword_18F0BCBA0[v38 + 36190],
		                           v39 | (1LL << (((unsigned __int64)&v14[1] >> 12) & 0x3F)),
		                           v39) );
		        }
		        v40 = v72;
		        v41 = UnityEngine::Texture2D::get_grayTexture(0LL);
		        if ( !v40 )
		          sub_1800D8250(v43, v42);
		        v40[1].monitor = (MonitorData *)v41;
		        if ( dword_18F35FD08 )
		        {
		          v44 = (((unsigned __int64)&v40[1].monitor >> 12) & 0x1FFFFF) >> 6;
		          _m_prefetchw(&qword_18F0BCBA0[v44 + 36190]);
		          do
		            v45 = qword_18F0BCBA0[v44 + 36190];
		          while ( v45 != _InterlockedCompareExchange64(
		                           &qword_18F0BCBA0[v44 + 36190],
		                           v45 | (1LL << (((unsigned __int64)&v40[1].monitor >> 12) & 0x3F)),
		                           v45) );
		        }
		        v46 = v72;
		        v47 = UnityEngine::Texture2D::get_grayTexture(0LL);
		        if ( !v46 )
		          sub_1800D8250(v49, v48);
		        v46[2].klass = (Object__Class *)v47;
		        if ( dword_18F35FD08 )
		        {
		          v50 = (((unsigned __int64)&v46[2] >> 12) & 0x1FFFFF) >> 6;
		          _m_prefetchw(&qword_18F0BCBA0[v50 + 36190]);
		          do
		            v51 = qword_18F0BCBA0[v50 + 36190];
		          while ( v51 != _InterlockedCompareExchange64(
		                           &qword_18F0BCBA0[v50 + 36190],
		                           v51 | (1LL << (((unsigned __int64)&v46[2] >> 12) & 0x3F)),
		                           v51) );
		        }
		      }
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v75,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->s_frostedGlassSkipRenderFunc,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::UberPostPassUtils::FrostedGlassSkipPassData>);
		    }
		    catch ( Il2CppExceptionWrapper *v73 )
		    {
		      v74.m_RenderPass = (HGRenderGraphPass *)v73->ex;
		    }
		    sub_180268AE0(&v74);
		  }
		}
		
		private static void UIFrostedGlassAddPass(FrostedGlassData data, HGRenderGraph renderGraph, bool useComputeShader, HGCamera camera) {} // 0x0000000189B879D8-0x0000000189B880E4
		// Void UIFrostedGlassAddPass(UberPostPassUtils+FrostedGlassData, HGRenderGraph, Boolean, HGCamera)
		// Hidden C++ exception states: #wind=1 #try_helpers=1
		void HG::Rendering::Runtime::UberPostPassUtils::UIFrostedGlassAddPass(
		        UberPostPassUtils_FrostedGlassData *data,
		        HGRenderGraph *renderGraph,
		        bool useComputeShader,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  ProfilingSampler *v9; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  __int64 downsampleNum; // rcx
		  Vector2Int__Array *mipsDownSize; // r8
		  __int64 v16; // rdx
		  __int64 v17; // rcx
		  TextureHandle__Array *mipsDown; // r8
		  __int64 v19; // rdx
		  __int64 v20; // rcx
		  Material__Array *frostedGlass1stPassMat; // r8
		  __int64 v22; // rdx
		  __int64 v23; // rcx
		  Material__Array *frostedGlass2ndPassMat; // r8
		  __int64 v25; // rdx
		  __int64 v26; // rcx
		  TextureHandle__Array *mipsDownTemp; // r8
		  __int64 v28; // rdx
		  __int64 v29; // rcx
		  int j; // ebx
		  __int64 v31; // rcx
		  TextureHandle *v32; // rax
		  __int64 v33; // rdx
		  __int64 v34; // rcx
		  __int64 v35; // rcx
		  TextureHandle *v36; // rax
		  __int64 v37; // rdx
		  unsigned int v38; // edx
		  unsigned __int64 v39; // r8
		  signed __int64 v40; // rtt
		  __int64 kernelKMain; // rcx
		  __int64 kernelKMainWithLut; // rcx
		  int i; // esi
		  __int64 v44; // rcx
		  unsigned __int64 v45; // rdx
		  signed __int64 v46; // rcx
		  __int128 v47; // xmm2
		  __int128 v48; // xmm3
		  Color clearColor; // xmm4
		  unsigned __int64 v50; // r8
		  signed __int64 v51; // rtt
		  __int64 v52; // r14
		  TextureHandle *v53; // rax
		  __int64 v54; // rdx
		  __int64 v55; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v57; // rdx
		  __int64 v58; // rcx
		  __int64 v59; // [rsp+40h] [rbp-1C8h] BYREF
		  _QWORD v60[2]; // [rsp+48h] [rbp-1C0h] BYREF
		  HGRenderGraphBuilder v61; // [rsp+58h] [rbp-1B0h] BYREF
		  TextureHandle size; // [rsp+78h] [rbp-190h] BYREF
		  TextureHandle v63; // [rsp+90h] [rbp-178h] BYREF
		  __int128 v64; // [rsp+A0h] [rbp-168h] BYREF
		  __int128 v65; // [rsp+B0h] [rbp-158h]
		  __int128 v66; // [rsp+C0h] [rbp-148h]
		  __int128 v67; // [rsp+D0h] [rbp-138h] BYREF
		  __int128 v68; // [rsp+E0h] [rbp-128h]
		  Color v69; // [rsp+F0h] [rbp-118h]
		  TextureHandle v70[2]; // [rsp+108h] [rbp-100h] BYREF
		  TextureDesc v71; // [rsp+130h] [rbp-D8h] BYREF
		  TextureDesc v72; // [rsp+190h] [rbp-78h] BYREF
		
		  memset(&v61, 0, sizeof(v61));
		  v59 = 0LL;
		  sub_18033B9D0(&v72, 0LL, 96LL);
		  sub_18033B9D0(&v64, 0LL, 96LL);
		  if ( IFix::WrappersManagerImpl::IsPatched(2927, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2927, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v58, v57);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_174(
		      (ILFixDynamicMethodWrapper_6 *)Patch,
		      (Object *)data,
		      (Object *)renderGraph,
		      useComputeShader,
		      (Object *)camera,
		      0LL);
		  }
		  else
		  {
		    v9 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		           (Int32Enum__Enum)0x9Cu,
		           MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    if ( !renderGraph )
		      sub_1800D8260(v11, v10);
		    v61 = *(HGRenderGraphBuilder *)sub_1808AF064(
		                                     (unsigned int)v70,
		                                     (_DWORD)renderGraph,
		                                     (unsigned int)"UI Frosted Glass",
		                                     (unsigned int)&v59,
		                                     (__int64)v9);
		    v60[0] = 0LL;
		    v60[1] = &v61;
		    if ( !data )
		      sub_1800D8250(v13, v12);
		    downsampleNum = (unsigned int)data->fields.downsampleNum;
		    if ( !v59 )
		      sub_1800D8250(downsampleNum, v12);
		    *(_DWORD *)(v59 + 56) = downsampleNum;
		    if ( !v59 )
		      sub_1800D8250(downsampleNum, v12);
		    *(TextureHandle *)(v59 + 72) = data->fields.source;
		    if ( !v59 )
		      sub_1800D8250(downsampleNum, v12);
		    *(_BYTE *)(v59 + 32) = 0;
		    if ( !v59 )
		      sub_1800D8250(downsampleNum, v12);
		    *(float *)(v59 + 108) = data->fields.colorThreshold;
		    if ( !v59 )
		      sub_1800D8250(downsampleNum, v12);
		    mipsDownSize = data->fields.mipsDownSize;
		    if ( !mipsDownSize )
		      sub_1800D8250(downsampleNum, v12);
		    System::Array::Copy((Array *)data->fields.mipsDownSize, *(Array **)(v59 + 64), mipsDownSize->max_length.size, 0LL);
		    if ( !v59 )
		      sub_1800D8250(v17, v16);
		    mipsDown = data->fields.mipsDown;
		    if ( !mipsDown )
		      sub_1800D8250(v17, v16);
		    System::Array::Copy((Array *)data->fields.mipsDown, *(Array **)(v59 + 88), mipsDown->max_length.size, 0LL);
		    HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v61, 0, 0LL);
		    if ( useComputeShader )
		    {
		      v37 = v59;
		      if ( !v59 )
		        sub_1800D8250(v20, 0LL);
		      *(_QWORD *)(v59 + 16) = data->fields.frostedGlassBlurCS;
		      if ( dword_18F35FD08 )
		      {
		        v38 = ((unsigned __int64)(v37 + 16) >> 12) & 0x1FFFFF;
		        v39 = (unsigned __int64)v38 >> 6;
		        v37 = v38 & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v39 + 36190]);
		        do
		          v40 = qword_18F0BCBA0[v39 + 36190];
		        while ( v40 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v39 + 36190], v40 | (1LL << v37), v40) );
		      }
		      kernelKMain = (unsigned int)data->fields.kernelKMain;
		      if ( !v59 )
		        sub_1800D8250(kernelKMain, v37);
		      *(_DWORD *)(v59 + 24) = kernelKMain;
		      kernelKMainWithLut = (unsigned int)data->fields.kernelKMainWithLut;
		      if ( !v59 )
		        sub_1800D8250(kernelKMainWithLut, v37);
		      *(_DWORD *)(v59 + 28) = kernelKMainWithLut;
		      for ( i = 0; i < 3; ++i )
		      {
		        if ( !v59 )
		          sub_1800D8250(kernelKMainWithLut, v37);
		        v44 = *(_QWORD *)(v59 + 64);
		        if ( !v44 )
		          sub_1800D8250(0LL, v37);
		        sub_180036DD0(v44, &size, i);
		        sub_18033B9D0(&v71, 0LL, 96LL);
		        HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v71, (Vector2Int)size.handle, 0LL);
		        v47 = *(_OWORD *)&v71.width;
		        v64 = *(_OWORD *)&v71.width;
		        v65 = *(_OWORD *)&v71.colorFormat;
		        v66 = *(_OWORD *)&v71.enableRandomWrite;
		        *(_QWORD *)&v67 = *(_QWORD *)&v71.bindTextureMS;
		        v48 = *(_OWORD *)&v71.fastMemoryDesc.inFastMemory;
		        v68 = *(_OWORD *)&v71.fastMemoryDesc.inFastMemory;
		        clearColor = v71.clearColor;
		        v69 = v71.clearColor;
		        LODWORD(v65) = 74;
		        LOBYTE(v66) = useComputeShader;
		        *((_QWORD *)&v67 + 1) = "FrostedGlassMipDown";
		        if ( dword_18F35FD08 )
		        {
		          v50 = ((((unsigned __int64)&v67 + 8) >> 12) & 0x1FFFFF) >> 6;
		          v45 = (((unsigned __int64)&v67 + 8) >> 12) & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v50 + 36190]);
		          do
		          {
		            v46 = qword_18F0BCBA0[v50 + 36190] | (1LL << v45);
		            v51 = qword_18F0BCBA0[v50 + 36190];
		          }
		          while ( v51 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v50 + 36190], v46, v51) );
		          clearColor = v69;
		          v48 = v68;
		          v47 = v64;
		        }
		        *(_QWORD *)((char *)&v65 + 4) = 0x100000001LL;
		        *(_OWORD *)&v72.width = v47;
		        *(_OWORD *)&v72.colorFormat = v65;
		        *(_OWORD *)&v72.enableRandomWrite = v66;
		        *(_OWORD *)&v72.bindTextureMS = v67;
		        *(_OWORD *)&v72.fastMemoryDesc.inFastMemory = v48;
		        v72.clearColor = clearColor;
		        if ( !v59 )
		          sub_1800D8250(v46, v45);
		        v52 = *(_QWORD *)(v59 + 88);
		        v53 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(v70, &v61, &v72, 0LL);
		        if ( !v52 )
		          sub_1800D8250(v55, v54);
		        v63 = *v53;
		        sub_180430AC4(v52, i, &v63);
		      }
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(v70, &v61, &data->fields.source, 0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v61,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->s_frostedGlassCSRenderFunc,
		        (Object *)camera,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::UberPostPassUtils::FrostedGlassPassData>);
		      sub_180268AE0(v60);
		    }
		    else
		    {
		      if ( !v59 )
		        sub_1800D8250(v20, v19);
		      frostedGlass1stPassMat = data->fields.frostedGlass1stPassMat;
		      if ( !frostedGlass1stPassMat )
		        sub_1800D8250(v20, v19);
		      System::Array::Copy(
		        (Array *)data->fields.frostedGlass1stPassMat,
		        *(Array **)(v59 + 40),
		        frostedGlass1stPassMat->max_length.size,
		        0LL);
		      if ( !v59 )
		        sub_1800D8250(v23, v22);
		      frostedGlass2ndPassMat = data->fields.frostedGlass2ndPassMat;
		      if ( !frostedGlass2ndPassMat )
		        sub_1800D8250(v23, v22);
		      System::Array::Copy(
		        (Array *)data->fields.frostedGlass2ndPassMat,
		        *(Array **)(v59 + 48),
		        frostedGlass2ndPassMat->max_length.size,
		        0LL);
		      if ( !v59 )
		        sub_1800D8250(v26, v25);
		      mipsDownTemp = data->fields.mipsDownTemp;
		      if ( !mipsDownTemp )
		        sub_1800D8250(v26, v25);
		      System::Array::Copy((Array *)data->fields.mipsDownTemp, *(Array **)(v59 + 96), mipsDownTemp->max_length.size, 0LL);
		      for ( j = 0; j < 3; ++j )
		      {
		        if ( !v59 )
		          sub_1800D8250(v29, v28);
		        v31 = *(_QWORD *)(v59 + 88);
		        if ( !v31 )
		          sub_1800D8250(0LL, v28);
		        v32 = (TextureHandle *)sub_1803C0774(v31, j);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadWriteTexture(&v63, &v61, v32, 0LL);
		        if ( !v59 )
		          sub_1800D8250(v34, v33);
		        v35 = *(_QWORD *)(v59 + 96);
		        if ( !v35 )
		          sub_1800D8250(0LL, v33);
		        v36 = (TextureHandle *)sub_1803C0774(v35, j);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadWriteTexture(&size, &v61, v36, 0LL);
		      }
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v61,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->s_frostedGlassPSRenderFunc,
		        (Object *)camera,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::UberPostPassUtils::FrostedGlassPassData>);
		      sub_180268AE0(v60);
		    }
		  }
		}
		
		internal static TextureHandle FrostedGlassPass(HGRenderGraph renderGraph, HGCamera hgCamera, HGSettingParameters settingParameters, TextureHandle source, TextureHandle logLut, int lutSize, ref FrostedGlassPSMaterials frostedGlassPSMaterials, ref RTHandle[] sceneFrostedGlassRTs, ref Vector2Int[] sceneFrostedGlassRTSizes) => default; // 0x0000000189B82068-0x0000000189B82328
		// TextureHandle FrostedGlassPass(HGRenderGraph, HGCamera, HGSettingParameters, TextureHandle, TextureHandle, Int32, UberPostPassUtils+FrostedGlassPSMaterials ByRef, RTHandle[] ByRef, Vector2Int[] ByRef)
		TextureHandle *HG::Rendering::Runtime::UberPostPassUtils::FrostedGlassPass(
		        TextureHandle *__return_ptr retstr,
		        HGRenderGraph *renderGraph,
		        HGCamera *hgCamera,
		        HGSettingParameters *settingParameters,
		        TextureHandle *source,
		        TextureHandle *logLut,
		        int32_t lutSize,
		        UberPostPassUtils_FrostedGlassPSMaterials *frostedGlassPSMaterials,
		        RTHandle__Array **sceneFrostedGlassRTs,
		        Vector2Int__Array **sceneFrostedGlassRTSizes,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  Camera *camera; // rcx
		  HGRenderGraphDefaultResources *defaultResources; // rax
		  TextureHandle blackTexture_k__BackingField; // xmm6
		  CameraType__Enum cameraType; // r12d
		  bool enableUpdatingSceneFrostedGlass; // bl
		  int v21; // edx
		  int v22; // eax
		  bool v23; // bl
		  TextureHandle v25; // [rsp+68h] [rbp-39h] BYREF
		  TextureHandle v26; // [rsp+78h] [rbp-29h] BYREF
		  TextureHandle v27; // [rsp+88h] [rbp-19h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2928, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2928, 0LL);
		    if ( Patch )
		    {
		      v25 = *logLut;
		      v26 = *source;
		      *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1084(
		                   &v27,
		                   Patch,
		                   (Object *)renderGraph,
		                   (Object *)hgCamera,
		                   (Object *)settingParameters,
		                   &v26,
		                   &v25,
		                   lutSize,
		                   frostedGlassPSMaterials,
		                   sceneFrostedGlassRTs,
		                   sceneFrostedGlassRTSizes,
		                   0LL);
		      return retstr;
		    }
		LABEL_16:
		    sub_1800D8260(camera, Patch);
		  }
		  if ( !renderGraph )
		    goto LABEL_16;
		  defaultResources = HG::Rendering::RenderGraphModule::HGRenderGraph::get_defaultResources(renderGraph, 0LL);
		  if ( !defaultResources )
		    goto LABEL_16;
		  blackTexture_k__BackingField = defaultResources->fields._blackTexture_k__BackingField;
		  if ( !hgCamera )
		    goto LABEL_16;
		  camera = hgCamera->fields.camera;
		  if ( !camera )
		    goto LABEL_16;
		  cameraType = UnityEngine::Camera::get_cameraType(camera, 0LL);
		  if ( !settingParameters )
		    goto LABEL_16;
		  enableUpdatingSceneFrostedGlass = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                                      settingParameters->fields._enablePermenantSceneFrostedGlass_k__BackingField,
		                                      MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		  if ( !enableUpdatingSceneFrostedGlass )
		    enableUpdatingSceneFrostedGlass = hgCamera->fields.enableUpdatingSceneFrostedGlass;
		  v21 = enableUpdatingSceneFrostedGlass & HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                                            settingParameters->fields._frostedGlassEnabled_k__BackingField,
		                                            MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		  v22 = 0;
		  if ( cameraType != CameraType__Enum_SceneView )
		    v22 = v21;
		  if ( v22 )
		  {
		    v23 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		            settingParameters->fields._frostedGlassUseComputeShader_k__BackingField,
		            MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		    v25 = *source;
		    HG::Rendering::Runtime::UberPostPassUtils::PrepareFrostedGlassData(
		      v23,
		      renderGraph,
		      TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->s_frostedGlassData,
		      hgCamera,
		      &v25,
		      frostedGlassPSMaterials,
		      0LL);
		    v25 = *logLut;
		    HG::Rendering::Runtime::UberPostPassUtils::PrepareFrostedGlassLutData(
		      v23,
		      TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->s_frostedGlassData,
		      hgCamera,
		      &v25,
		      lutSize,
		      0LL);
		    HG::Rendering::Runtime::UberPostPassUtils::PrepareFrostedGlassSceneRTs(
		      v23,
		      renderGraph,
		      TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->s_frostedGlassData,
		      sceneFrostedGlassRTs,
		      sceneFrostedGlassRTSizes,
		      0LL);
		    blackTexture_k__BackingField = *HG::Rendering::Runtime::UberPostPassUtils::FrostedGlassAddPass(
		                                      &v26,
		                                      TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->s_frostedGlassData,
		                                      renderGraph,
		                                      v23,
		                                      0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		    HG::Rendering::Runtime::UberPostPassUtils::FrostedGlassAddSkipPass(
		      cameraType == CameraType__Enum_SceneView,
		      enableUpdatingSceneFrostedGlass,
		      renderGraph,
		      sceneFrostedGlassRTs,
		      0LL);
		  }
		  *retstr = blackTexture_k__BackingField;
		  return retstr;
		}
		
		internal static void RenderUIFrostedGlass(TextureHandle source, HGRenderGraph renderGraph, HGCamera camera, HGSettingParameters settingParameters, ref FrostedGlassPSMaterials frostedGlassPSMaterials) {} // 0x0000000189B872B4-0x0000000189B8740C
		// Void RenderUIFrostedGlass(TextureHandle, HGRenderGraph, HGCamera, HGSettingParameters, UberPostPassUtils+FrostedGlassPSMaterials ByRef)
		void HG::Rendering::Runtime::UberPostPassUtils::RenderUIFrostedGlass(
		        TextureHandle *source,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        HGSettingParameters *settingParameters,
		        UberPostPassUtils_FrostedGlassPSMaterials *frostedGlassPSMaterials,
		        MethodInfo *method)
		{
		  __int64 v10; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  bool v12; // bl
		  UberPostPassUtils__StaticFields *static_fields; // r8
		  TextureHandle v14; // [rsp+40h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2930, 0LL) )
		  {
		    if ( settingParameters )
		    {
		      v12 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		              settingParameters->fields._frostedGlassUseComputeShader_k__BackingField,
		              MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		      static_fields = TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields;
		      v14 = *source;
		      HG::Rendering::Runtime::UberPostPassUtils::PrepareFrostedGlassData(
		        v12,
		        renderGraph,
		        static_fields->s_frostedGlassData,
		        camera,
		        &v14,
		        frostedGlassPSMaterials,
		        0LL);
		      HG::Rendering::Runtime::UberPostPassUtils::PrepareFrostedGlassUIRTs(
		        v12,
		        renderGraph,
		        TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->s_frostedGlassData,
		        0LL);
		      HG::Rendering::Runtime::UberPostPassUtils::UIFrostedGlassAddPass(
		        TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->s_frostedGlassData,
		        renderGraph,
		        v12,
		        camera,
		        0LL);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(Patch, v10);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2930, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  v14 = *source;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1085(
		    Patch,
		    &v14,
		    (Object *)renderGraph,
		    (Object *)camera,
		    (Object *)settingParameters,
		    frostedGlassPSMaterials,
		    0LL);
		}
		
		internal static void PrepareSharpenData(HGCamera hgCamera, HGSharpen sharpen, Material sharpenMaterial) {} // 0x0000000189B86648-0x0000000189B86940
		// Void PrepareSharpenData(HGCamera, HGSharpen, Material)
		void HG::Rendering::Runtime::UberPostPassUtils::PrepareSharpenData(
		        HGCamera *hgCamera,
		        HGSharpen *sharpen,
		        Material *sharpenMaterial,
		        MethodInfo *method)
		{
		  void *sharpenMode; // rdx
		  unsigned __int64 static_fields; // rcx
		  int v9; // eax
		  int v10; // edi
		  double v11; // xmm0_8
		  float v12; // xmm6_4
		  double v13; // xmm0_8
		  float v14; // xmm8_4
		  double v15; // xmm0_8
		  unsigned int v16; // xmm7_4
		  int32_t m_X; // edi
		  __int64 v18; // rbx
		  float v19; // xmm6_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 v21; // [rsp+30h] [rbp-48h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2931, 0LL) )
		  {
		    if ( !sharpen )
		      goto LABEL_23;
		    sharpenMode = sharpen->fields.sharpenMode;
		    if ( !sharpenMode )
		      goto LABEL_23;
		    v9 = sub_180002F70(10LL, sharpenMode);
		    sharpenMode = sharpen->fields.sharpenRange;
		    v10 = v9;
		    if ( !sharpenMode )
		      goto LABEL_23;
		    v11 = sub_1800057D0(10LL, sharpenMode);
		    sharpenMode = sharpen->fields.sharpenIntensity;
		    v12 = *(float *)&v11;
		    if ( !sharpenMode )
		      goto LABEL_23;
		    v13 = sub_1800057D0(10LL, sharpenMode);
		    sharpenMode = sharpen->fields.sharpenThreshold;
		    v14 = *(float *)&v13;
		    if ( !sharpenMode )
		      goto LABEL_23;
		    v15 = sub_1800057D0(10LL, sharpenMode);
		    v16 = LODWORD(v15);
		    if ( v10 == 1 )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		      static_fields = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields;
		      if ( !sharpenMaterial )
		        goto LABEL_23;
		      UnityEngine::Material::EnableKeyword(sharpenMaterial, *(String **)(static_fields + 216), 0LL);
		      UnityEngine::Material::DisableKeyword(
		        sharpenMaterial,
		        TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_SharpenFilter2,
		        0LL);
		    }
		    else
		    {
		      static_fields = (unsigned int)(v10 - 2);
		      if ( v10 != 2 )
		      {
		        if ( v10 == 3 )
		        {
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		          static_fields = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields;
		          if ( !sharpenMaterial )
		            goto LABEL_23;
		          UnityEngine::Material::DisableKeyword(sharpenMaterial, *(String **)(static_fields + 216), 0LL);
		          UnityEngine::Material::DisableKeyword(
		            sharpenMaterial,
		            TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_SharpenFilter2,
		            0LL);
		          UnityEngine::Material::EnableKeyword(
		            sharpenMaterial,
		            TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_SharpenFilter4,
		            0LL);
		        }
		        goto LABEL_17;
		      }
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		      static_fields = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields;
		      if ( !sharpenMaterial )
		        goto LABEL_23;
		      UnityEngine::Material::DisableKeyword(sharpenMaterial, *(String **)(static_fields + 216), 0LL);
		      UnityEngine::Material::EnableKeyword(
		        sharpenMaterial,
		        TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_SharpenFilter2,
		        0LL);
		    }
		    UnityEngine::Material::DisableKeyword(
		      sharpenMaterial,
		      TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_SharpenFilter4,
		      0LL);
		LABEL_17:
		    if ( hgCamera )
		    {
		      m_X = hgCamera->fields._taauRTSize_k__BackingField.m_X;
		      v18 = HIDWORD(*(_QWORD *)&hgCamera->fields._taauRTSize_k__BackingField);
		      sub_1800036A0(TypeInfo::System::Math);
		      v19 = v12 / 1080.0;
		      if ( m_X > (int)v18 )
		        m_X = v18;
		      v21.x = v14;
		      *(_QWORD *)&v21.z = v16;
		      v21.y = (float)m_X * v19;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		      static_fields = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		      if ( sharpenMaterial )
		      {
		        UnityEngine::Material::SetVector(sharpenMaterial, *(_DWORD *)(static_fields + 2104), &v21, 0LL);
		        return;
		      }
		    }
		LABEL_23:
		    sub_1800D8260(static_fields, sharpenMode);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2931, 0LL);
		  if ( !Patch )
		    goto LABEL_23;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
		    (ILFixDynamicMethodWrapper_30 *)Patch,
		    (Object *)hgCamera,
		    (Object *)sharpen,
		    (Object *)sharpenMaterial,
		    0LL);
		}
		
		internal static TextureHandle SharpenPass(HGRenderGraph renderGraph, HGCamera hgCamera, TextureHandle source, HGSharpen sharpen, Material sharpenMaterial) => default; // 0x0000000189B8740C-0x0000000189B87840
		// TextureHandle SharpenPass(HGRenderGraph, HGCamera, TextureHandle, HGSharpen, Material)
		// Hidden C++ exception states: #wind=1
		TextureHandle *HG::Rendering::Runtime::UberPostPassUtils::SharpenPass(
		        TextureHandle *__return_ptr retstr,
		        HGRenderGraph *renderGraph,
		        HGCamera *hgCamera,
		        TextureHandle *source,
		        HGSharpen *sharpen,
		        Material *sharpenMaterial,
		        MethodInfo *method)
		{
		  TextureHandle *v10; // rbx
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  HGRuntimeGrassQuery_Node *v13; // rdx
		  HGRuntimeGrassQuery_Node *v14; // r8
		  Int32__Array **v15; // r9
		  HGRenderPipeline *currentPipeline; // rax
		  __int64 v17; // rdx
		  __int64 v18; // rcx
		  __int64 v19; // rdx
		  __int64 v20; // rcx
		  ProfilingSampler *v21; // rax
		  __int64 v22; // rcx
		  Object *v23; // rdx
		  unsigned int v24; // edx
		  unsigned __int64 v25; // r8
		  char v26; // dl
		  signed __int64 v27; // rtt
		  Object *v28; // rdi
		  __int64 v29; // rdx
		  __int64 v30; // rcx
		  TextureHandle v31; // xmm0
		  Object *v32; // rdi
		  __int64 v33; // rdx
		  __int64 v34; // rcx
		  TextureHandle v35; // xmm0
		  TextureHandle v36; // xmm0
		  __int64 v37; // rdx
		  __int64 v38; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rsi
		  TextureHandle *result; // rax
		  MethodInfo *methoda; // [rsp+20h] [rbp-178h]
		  Object *v42; // [rsp+40h] [rbp-158h] BYREF
		  TextureHandle v43; // [rsp+50h] [rbp-148h] BYREF
		  HGRenderGraphBuilder v44; // [rsp+60h] [rbp-138h] BYREF
		  TextureHandle v45; // [rsp+80h] [rbp-118h] BYREF
		  HGRenderGraphBuilder v46; // [rsp+90h] [rbp-108h] BYREF
		  Il2CppExceptionWrapper *v47; // [rsp+B0h] [rbp-E8h] BYREF
		  TextureDesc v48; // [rsp+C0h] [rbp-D8h] BYREF
		  TextureDesc v49; // [rsp+120h] [rbp-78h] BYREF
		
		  v10 = retstr;
		  sub_18033B9D0(&v48, 0LL, 96LL);
		  v42 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(2932, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2932, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v38, v37);
		    v43 = *source;
		    v36 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1086(
		             (TextureHandle *)&v44,
		             Patch,
		             (Object *)renderGraph,
		             (Object *)hgCamera,
		             &v43,
		             (Object *)sharpen,
		             (Object *)sharpenMaterial,
		             0LL);
		  }
		  else
		  {
		    if ( !hgCamera )
		      sub_1800D8260(v12, v11);
		    HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v48, hgCamera->fields._taauRTSize_k__BackingField, 0LL);
		    v48.name = (String *)"Sharpen Texture";
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v48.name, v13, v14, v15, methoda);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		    currentPipeline = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
		    if ( !currentPipeline )
		      sub_1800D8260(v18, v17);
		    v48.colorFormat = HG::Rendering::Runtime::HGRenderPipeline::GetColorBufferFormat(currentPipeline, hgCamera, 0LL);
		    v48.useMipMap = 0;
		    v49 = v48;
		    if ( !renderGraph )
		      sub_1800D8260(v20, v19);
		    v43 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(&v43, renderGraph, &v49, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		    HG::Rendering::Runtime::UberPostPassUtils::PrepareSharpenData(hgCamera, sharpen, sharpenMaterial, 0LL);
		    v21 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		            (Int32Enum__Enum)0x9Au,
		            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		      &v44,
		      renderGraph,
		      (String *)"Sharpen",
		      &v42,
		      v21,
		      1,
		      ProfilingHGPass__Enum_None,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::UberPostPassUtils::SharpenData>);
		    v46 = v44;
		    v44.m_RenderPass = 0LL;
		    v44.m_Resources = (HGRenderGraphResourceRegistry *)&v46;
		    try
		    {
		      v23 = v42;
		      if ( !v42 )
		        sub_1800D8250(v22, 0LL);
		      v42[1].klass = (Object__Class *)sharpenMaterial;
		      if ( dword_18F35FD08 )
		      {
		        v24 = ((unsigned __int64)&v23[1] >> 12) & 0x1FFFFF;
		        v25 = (unsigned __int64)v24 >> 6;
		        v26 = v24 & 0x3F;
		        _m_prefetchw(&qword_18F103690[v25]);
		        do
		          v27 = qword_18F103690[v25];
		        while ( v27 != _InterlockedCompareExchange64(&qword_18F103690[v25], v27 | (1LL << v26), v27) );
		      }
		      v28 = v42;
		      v31 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v45, &v46, source, 0LL);
		      if ( !v28 )
		        sub_1800D8250(v30, v29);
		      *(TextureHandle *)&v28[1].monitor = v31;
		      v32 = v42;
		      v35 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(&v45, &v46, &v43, 0LL);
		      if ( !v32 )
		        sub_1800D8250(v34, v33);
		      *(TextureHandle *)&v32[2].monitor = v35;
		      if ( !v42 )
		        sub_1800D8250(v34, v33);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		        &v45,
		        &v46,
		        (TextureHandle *)&v42[2].monitor,
		        0,
		        0,
		        0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v46,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->static_fields->s_sharpenRenderFunc,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::UberPostPassUtils::SharpenData>);
		    }
		    catch ( Il2CppExceptionWrapper *v47 )
		    {
		      v44.m_RenderPass = (HGRenderGraphPass *)v47->ex;
		      sub_180268AE0(&v44);
		      v10 = retstr;
		      goto LABEL_15;
		    }
		    sub_180268AE0(&v44);
		LABEL_15:
		    v36 = v43;
		  }
		  result = v10;
		  *v10 = v36;
		  return result;
		}
		
		internal static void PrepareVignetteParameters(HGSettingParameters settingParams, PPVignetteData data, Vignette vignette, HGVignette hgVignette, Material ppMaterial) {} // 0x0000000189B86D80-0x0000000189B872B4
		// Void PrepareVignetteParameters(HGSettingParameters, UberPostPassUtils+PPVignetteData, Vignette, HGVignette, Material)
		void HG::Rendering::Runtime::UberPostPassUtils::PrepareVignetteParameters(
		        HGSettingParameters *settingParams,
		        UberPostPassUtils_PPVignetteData *data,
		        Vignette *vignette,
		        HGVignette *hgVignette,
		        Material *ppMaterial,
		        MethodInfo *method)
		{
		  float v6; // xmm1_4
		  String *mode; // rdx
		  ILFixDynamicMethodWrapper_19 *Patch; // rcx
		  bool IsActive; // r15
		  bool v14; // r12
		  int v15; // eax
		  int v16; // r15d
		  double v17; // xmm0_8
		  float v18; // xmm13_4
		  __int64 v19; // rax
		  float v20; // xmm11_4
		  unsigned int v21; // xmm12_4
		  double v22; // xmm0_8
		  float v23; // xmm7_4
		  double v24; // xmm0_8
		  float v25; // xmm9_4
		  char v26; // al
		  ColorParameter *color; // r8
		  char v28; // r13
		  const __m128i *v29; // rax
		  __m128 v30; // xmm6
		  __int64 v31; // rax
		  Texture *v32; // rsi
		  double v33; // xmm0_8
		  float v34; // xmm10_4
		  float v35; // xmm8_4
		  char v36; // al
		  char v37; // al
		  ColorParameter *v38; // r8
		  char v39; // bl
		  __m128 v40; // xmm2
		  float v41; // xmm1_4
		  float v42; // xmm0_4
		  float v43; // xmm0_4
		  float v44; // xmm2_4
		  double v45; // xmm0_8
		  double v46; // xmm0_8
		  MethodInfo *v47; // r8
		  float v48; // xmm0_4
		  double v49; // xmm0_8
		  Beyond::JobMathf *v50; // rcx
		  MethodInfo *v51; // r8
		  Vector4 si128; // xmm2
		  Color *v53; // rax
		  HGRuntimeGrassQuery_Node *v54; // rdx
		  HGRuntimeGrassQuery_Node *v55; // r8
		  Int32__Array **v56; // r9
		  Texture **p_vignetteMask; // rcx
		  Vector4 v58; // xmm1
		  Vector4 v59; // xmm0
		  Texture *blackTexture; // rax
		  MethodInfo *P3; // [rsp+28h] [rbp-99h]
		  __m128 v62; // [rsp+48h] [rbp-79h] BYREF
		  Color v63; // [rsp+58h] [rbp-69h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2933, 0LL) )
		  {
		    Patch = (ILFixDynamicMethodWrapper_19 *)IFix::WrappersManagerImpl::GetPatch(2933, 0LL);
		    if ( !Patch )
		      goto LABEL_56;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_19(
		      Patch,
		      (Object *)settingParams,
		      (Object *)data,
		      (Object *)vignette,
		      (Object *)hgVignette,
		      (Object *)ppMaterial,
		      0LL);
		  }
		  else
		  {
		    if ( !vignette )
		      goto LABEL_56;
		    IsActive = HG::Rendering::Runtime::Vignette::IsActive(vignette, 0LL);
		    if ( !hgVignette )
		      goto LABEL_56;
		    v14 = HG::Rendering::Runtime::HGVignette::IsActive(hgVignette, 0LL);
		    if ( !settingParams )
		      goto LABEL_56;
		    if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		           settingParams->fields._vignetteEnabled_k__BackingField,
		           MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit)
		      && (IsActive || v14) )
		    {
		      mode = (String *)vignette->fields.mode;
		      if ( !mode )
		        goto LABEL_56;
		      v15 = sub_180002F70(10LL, mode);
		      mode = (String *)vignette->fields.roundness;
		      v16 = v15;
		      if ( !mode )
		        goto LABEL_56;
		      v17 = sub_1800057D0(10LL, mode);
		      mode = (String *)vignette->fields.center;
		      v18 = *(float *)&v17;
		      if ( !mode )
		        goto LABEL_56;
		      v19 = sub_180041350(10LL);
		      mode = (String *)vignette->fields.intensity;
		      v62.m128_u64[0] = v19;
		      v20 = *(float *)&v19;
		      v21 = HIDWORD(v19);
		      if ( !mode )
		        goto LABEL_56;
		      v22 = sub_1800057D0(10LL, mode);
		      mode = (String *)vignette->fields.smoothness;
		      v23 = *(float *)&v22;
		      if ( !mode )
		        goto LABEL_56;
		      v24 = sub_1800057D0(10LL, mode);
		      mode = (String *)vignette->fields.rounded;
		      v25 = *(float *)&v24;
		      if ( !mode )
		        goto LABEL_56;
		      v26 = sub_180006280(10LL, mode);
		      color = vignette->fields.color;
		      v28 = v26;
		      if ( !color )
		        goto LABEL_56;
		      v29 = (const __m128i *)sub_180032E40(&v62, 10LL, color);
		      mode = (String *)vignette->fields.mask;
		      v30 = (__m128)_mm_loadu_si128(v29);
		      v62 = v30;
		      if ( !mode )
		        goto LABEL_56;
		      v31 = sub_1800460A0(10LL, mode);
		      mode = (String *)vignette->fields.opacity;
		      v32 = (Texture *)v31;
		      if ( !mode )
		        goto LABEL_56;
		      v33 = sub_1800057D0(10LL, mode);
		      v34 = 1.0;
		      v35 = *(float *)&v33;
		      if ( !v14 )
		      {
		        v39 = 0;
		        if ( v16 )
		        {
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		          mode = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_VignetteMask;
		          Patch = (ILFixDynamicMethodWrapper_19 *)ppMaterial;
		          if ( ppMaterial )
		          {
		            UnityEngine::Material::EnableKeyword(ppMaterial, mode, 0LL);
		            v62.m128_i32[0] = v30.m128_i32[0];
		            v62.m128_i32[1] = _mm_shuffle_ps(v30, v30, 85).m128_u32[0];
		            v62.m128_i32[2] = _mm_shuffle_ps(v30, v30, 170).m128_u32[0];
		            Beyond::JobMathf::Clamp01(v50, v6);
		            si128 = (Vector4)_mm_load_si128((const __m128i *)&xmmword_18B959550);
		            v62.m128_f32[3] = v35;
		            if ( data )
		            {
		              data->fields.vignetteParams1 = si128;
		              v53 = UnityEngine::Color::op_Implicit(&v63, (Vector4 *)&v62, v51);
		              p_vignetteMask = &data->fields.vignetteMask;
		              v58 = (Vector4)_mm_loadu_si128((const __m128i *)v53);
		              data->fields.vignetteMask = v32;
		              data->fields.vignetteColor = v58;
		LABEL_54:
		              sub_18002D1B0((HGRuntimeGrassQuery_Node *)p_vignetteMask, v54, v55, v56, P3);
		              return;
		            }
		          }
		LABEL_56:
		          sub_1800D8260(Patch, mode);
		        }
		LABEL_36:
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		        mode = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_Vignette;
		        Patch = (ILFixDynamicMethodWrapper_19 *)ppMaterial;
		        if ( ppMaterial )
		        {
		          UnityEngine::Material::EnableKeyword(ppMaterial, mode, 0LL);
		          v48 = v39 ? 1.0 : 0.0;
		          v62.m128_f32[0] = v20;
		          *(unsigned __int64 *)((char *)v62.m128_u64 + 4) = v21;
		          v62.m128_f32[3] = v48;
		          if ( data )
		          {
		            data->fields.vignetteParams1 = (Vector4)v62;
		            if ( !v28 )
		              v34 = 0.0;
		            v62.m128_f32[0] = v23 * 3.0;
		            v62.m128_f32[2] = (float)((float)(1.0 - v18) * 6.0) + v18;
		            v62.m128_f32[1] = v25 * 5.0;
		            v62.m128_f32[3] = v34;
		            v59 = (Vector4)v62;
		            v62 = v30;
		            data->fields.vignetteParams2 = v59;
		            data->fields.vignetteColor = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Color::op_Implicit(
		                                                                                     &v63,
		                                                                                     (Vector4 *)&v62,
		                                                                                     v47));
		            blackTexture = (Texture *)UnityEngine::Texture2D::get_blackTexture(0LL);
		            p_vignetteMask = &data->fields.vignetteMask;
		            data->fields.vignetteMask = blackTexture;
		            goto LABEL_54;
		          }
		        }
		        goto LABEL_56;
		      }
		      mode = (String *)hgVignette->fields.rounded;
		      if ( !mode )
		        goto LABEL_56;
		      v36 = sub_180006280(10LL, mode);
		      mode = (String *)hgVignette->fields.blink;
		      v28 = v36;
		      v18 = 1.0;
		      if ( !mode )
		        goto LABEL_56;
		      v37 = sub_180006280(10LL, mode);
		      v38 = hgVignette->fields.color;
		      v39 = v37;
		      v20 = 0.5;
		      v21 = 1056964608;
		      if ( !v38 )
		        goto LABEL_56;
		      v40 = (__m128)_mm_loadu_si128((const __m128i *)sub_180032E40(&v63, 10LL, v38));
		      if ( v23 > 0.0 )
		      {
		        if ( v40.m128_f32[0] <= v30.m128_f32[0] )
		          v30.m128_i32[0] = v40.m128_i32[0];
		        v41 = v62.m128_f32[1];
		        v42 = _mm_shuffle_ps(v40, v40, 85).m128_f32[0];
		        v62.m128_i32[0] = v30.m128_i32[0];
		        if ( v42 <= v62.m128_f32[1] )
		          v41 = v42;
		        v43 = v62.m128_f32[2];
		        v44 = _mm_shuffle_ps(v40, v40, 170).m128_f32[0];
		        v62.m128_f32[1] = v41;
		        if ( v44 <= v62.m128_f32[2] )
		          v43 = v44;
		        v62.m128_f32[2] = v43;
		      }
		      else
		      {
		        v62.m128_i32[0] = v40.m128_i32[0];
		        v62.m128_i32[3] = _mm_shuffle_ps(v40, v40, 255).m128_u32[0];
		        v62.m128_i32[1] = _mm_shuffle_ps(v40, v40, 85).m128_u32[0];
		        v62.m128_i32[2] = _mm_shuffle_ps(v40, v40, 170).m128_u32[0];
		      }
		      mode = (String *)hgVignette->fields.intensity;
		      if ( v39 )
		      {
		        if ( !mode )
		          goto LABEL_56;
		        v45 = sub_1800057D0(10LL, mode);
		        mode = (String *)hgVignette->fields.smoothness;
		        v23 = *(float *)&v45;
		        if ( !mode )
		          goto LABEL_56;
		        v46 = sub_1800057D0(10LL, mode);
		      }
		      else
		      {
		        if ( !mode )
		          goto LABEL_56;
		        v49 = sub_1800057D0(10LL, mode);
		        if ( v23 <= *(float *)&v49 )
		          v23 = *(float *)&v49;
		        mode = (String *)hgVignette->fields.smoothness;
		        if ( !mode )
		          goto LABEL_56;
		        v46 = sub_1800057D0(10LL, mode);
		        if ( v25 > *(float *)&v46 )
		          goto LABEL_35;
		      }
		      v25 = *(float *)&v46;
		LABEL_35:
		      v30 = v62;
		      goto LABEL_36;
		    }
		  }
		}
		
		internal static void PrepareDirtyLensParameters(HGSettingParameters settingParameters, UberPostPassData data, HGDirtyLens hgDirtyLens) {} // 0x0000000189B84CCC-0x0000000189B84E28
		// Void PrepareDirtyLensParameters(HGSettingParameters, UberPostPassUtils+UberPostPassData, HGDirtyLens)
		void HG::Rendering::Runtime::UberPostPassUtils::PrepareDirtyLensParameters(
		        HGSettingParameters *settingParameters,
		        UberPostPassUtils_UberPostPassData *data,
		        HGDirtyLens *hgDirtyLens,
		        MethodInfo *method)
		{
		  String **dirtyTex; // rdx
		  __int64 v8; // rcx
		  BOOL v9; // esi
		  __int64 v10; // rax
		  Texture *v11; // rbp
		  double v12; // xmm0_8
		  unsigned int v13; // xmm6_4
		  Material *uberPostMaterial; // rbx
		  HGRuntimeGrassQuery_Node *v15; // rdx
		  HGRuntimeGrassQuery_Node *v16; // r8
		  Int32__Array **v17; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v19; // [rsp+20h] [rbp-38h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2935, 0LL) )
		  {
		    if ( !hgDirtyLens )
		      goto LABEL_14;
		    if ( HG::Rendering::Runtime::HGDirtyLens::IsActive(hgDirtyLens, 0LL) )
		    {
		      if ( !settingParameters )
		        goto LABEL_14;
		      v9 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		             settingParameters->fields._dirtyLensEnabled_k__BackingField,
		             MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		    }
		    else
		    {
		      v9 = 0;
		    }
		    dirtyTex = (String **)hgDirtyLens->fields.dirtyTex;
		    if ( dirtyTex )
		    {
		      v10 = sub_1800460A0(10LL, dirtyTex);
		      dirtyTex = (String **)hgDirtyLens->fields.intensity;
		      v11 = (Texture *)v10;
		      if ( dirtyTex )
		      {
		        v12 = sub_1800057D0(10LL, dirtyTex);
		        v13 = LODWORD(v12);
		        if ( !v9 )
		          return;
		        if ( data )
		        {
		          uberPostMaterial = data->fields.uberPostMaterial;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		          dirtyTex = &TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_EnableScreenSpaceShadowMask.m_Name;
		          if ( uberPostMaterial )
		          {
		            UnityEngine::Material::EnableKeyword(uberPostMaterial, dirtyTex[32], 0LL);
		            data->fields.dirtyTex = v11;
		            sub_18002D1B0((HGRuntimeGrassQuery_Node *)&data->fields.dirtyTex, v15, v16, v17, v19);
		            data->fields.dirtyLensParams1 = (Vector4)v13;
		            return;
		          }
		        }
		      }
		    }
		LABEL_14:
		    sub_1800D8260(v8, dirtyTex);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2935, 0LL);
		  if ( !Patch )
		    goto LABEL_14;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
		    (ILFixDynamicMethodWrapper_30 *)Patch,
		    (Object *)settingParameters,
		    (Object *)data,
		    (Object *)hgDirtyLens,
		    0LL);
		}
		
		internal static void PrepareRadialBlurAndChromaticAberrationParameters(HGSettingParameters settingParameters, UberPostPassData data, HGCamera camera, HGRadialBlur radialBlur, HGChromaticAbberation chromaticAbberation) {} // 0x0000000189B860F0-0x0000000189B86648
		// Void PrepareRadialBlurAndChromaticAberrationParameters(HGSettingParameters, UberPostPassUtils+UberPostPassData, HGCamera, HGRadialBlur, HGChromaticAbberation)
		void HG::Rendering::Runtime::UberPostPassUtils::PrepareRadialBlurAndChromaticAberrationParameters(
		        HGSettingParameters *settingParameters,
		        UberPostPassUtils_UberPostPassData *data,
		        HGCamera *camera,
		        HGRadialBlur *radialBlur,
		        HGChromaticAbberation *chromaticAbberation,
		        MethodInfo *method)
		{
		  float v6; // xmm3_4
		  String *s_RadialBlurWithChromaticAberration; // rdx
		  __int64 static_fields; // rcx
		  bool v13; // r12
		  bool v14; // r15
		  Material *uberPostMaterial; // rsi
		  Vector2 v16; // r8
		  int32_t v17; // r9d
		  __m128 x_low; // xmm6
		  __m128 y_low; // xmm7
		  Vector2Parameter *center; // rax
		  Vector2 v21; // rax
		  Vector3Parameter *globalCenter; // r8
		  Vector2Parameter *v23; // rax
		  Camera *v24; // rsi
		  __int64 v25; // rax
		  __int64 v26; // xmm0_8
		  float v27; // eax
		  Vector3 *v28; // rax
		  __int64 v29; // xmm0_8
		  MethodInfo *v30; // rdx
		  Vector2 v31; // rax
		  Beyond::JobMathf *v32; // rcx
		  double v33; // xmm0_8
		  double v34; // xmm1_8
		  Vector2 v35; // rax
		  Vector2 v36; // r8
		  Vector2 v37; // r9
		  __int32 v38; // xmm12_4
		  __int32 v39; // xmm0_4
		  Beyond::JobMathf *v40; // rcx
		  float v41; // xmm7_4
		  __int32 v42; // xmm13_4
		  unsigned int v43; // xmm6_4
		  float v44; // xmm9_4
		  float v45; // xmm10_4
		  float v46; // xmm8_4
		  double v47; // xmm0_8
		  float v48; // xmm6_4
		  double v49; // xmm0_8
		  Beyond::JobMathf *v50; // rcx
		  double v51; // xmm0_8
		  double v52; // xmm0_8
		  double v53; // xmm0_8
		  unsigned int v54; // eax
		  double v55; // xmm0_8
		  Vector4 v56; // [rsp+48h] [rbp-79h] BYREF
		  Vector4 v57; // [rsp+58h] [rbp-69h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2937, 0LL) )
		  {
		    if ( !radialBlur )
		      goto LABEL_69;
		    if ( HG::Rendering::Runtime::HGRadialBlur::IsActive(radialBlur, 0LL) )
		    {
		      if ( !settingParameters )
		        goto LABEL_69;
		      v13 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		              settingParameters->fields._radialBlurEnabled_k__BackingField,
		              MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		    }
		    else
		    {
		      v13 = 0;
		    }
		    if ( !chromaticAbberation )
		      goto LABEL_69;
		    if ( HG::Rendering::Runtime::HGChromaticAbberation::IsActive(chromaticAbberation, 0LL) )
		    {
		      if ( !settingParameters )
		        goto LABEL_69;
		      v14 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		              settingParameters->fields._chromaticAberrationEnabled_k__BackingField,
		              MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		    }
		    else
		    {
		      v14 = 0;
		    }
		    LOBYTE(static_fields) = v14 || v13;
		    if ( !v14 && !v13 )
		      return;
		    if ( !data
		      || ((uberPostMaterial = data->fields.uberPostMaterial,
		           sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords),
		           v14)
		        ? (s_RadialBlurWithChromaticAberration = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_RadialBlurWithChromaticAberration)
		        : (static_fields = (__int64)TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields,
		           s_RadialBlurWithChromaticAberration = *(String **)(static_fields + 288)),
		          !uberPostMaterial) )
		    {
		LABEL_69:
		      sub_1800D8260(static_fields, s_RadialBlurWithChromaticAberration);
		    }
		    UnityEngine::Material::EnableKeyword(uberPostMaterial, s_RadialBlurWithChromaticAberration, 0LL);
		    x_low = (__m128)0x3F000000u;
		    y_low = (__m128)0x3F000000u;
		    if ( !v14 )
		      goto LABEL_73;
		    center = chromaticAbberation->fields.center;
		    if ( !center )
		      goto LABEL_69;
		    if ( center->fields._._.overrideState )
		      goto LABEL_23;
		    s_RadialBlurWithChromaticAberration = (String *)chromaticAbberation->fields.enableGlobalCenter;
		    if ( !s_RadialBlurWithChromaticAberration )
		      goto LABEL_69;
		    if ( (unsigned __int8)sub_180006280(10LL, s_RadialBlurWithChromaticAberration) )
		    {
		LABEL_23:
		      s_RadialBlurWithChromaticAberration = (String *)chromaticAbberation->fields.enableGlobalCenter;
		      if ( !s_RadialBlurWithChromaticAberration )
		        goto LABEL_69;
		      if ( !(unsigned __int8)sub_180006280(10LL, s_RadialBlurWithChromaticAberration) )
		      {
		        s_RadialBlurWithChromaticAberration = (String *)chromaticAbberation->fields.center;
		LABEL_26:
		        if ( !s_RadialBlurWithChromaticAberration )
		          goto LABEL_69;
		        v21 = (Vector2)sub_180041350(10LL);
		LABEL_43:
		        *(Vector2 *)&v56.x = v21;
		        y_low = (__m128)LODWORD(v21.y);
		        x_low = (__m128)LODWORD(v21.x);
		        goto LABEL_44;
		      }
		      if ( !camera )
		        goto LABEL_69;
		      globalCenter = chromaticAbberation->fields.globalCenter;
		    }
		    else
		    {
		LABEL_73:
		      if ( !v13 )
		        goto LABEL_44;
		      v23 = radialBlur->fields.center;
		      if ( !v23 )
		        goto LABEL_69;
		      if ( !v23->fields._._.overrideState )
		      {
		        s_RadialBlurWithChromaticAberration = (String *)radialBlur->fields.enableGlobalCenter;
		        if ( !s_RadialBlurWithChromaticAberration )
		          goto LABEL_69;
		        if ( !(unsigned __int8)sub_180006280(10LL, s_RadialBlurWithChromaticAberration) )
		        {
		LABEL_44:
		          v31 = sub_1858CACF0(
		                  _mm_unpacklo_ps(x_low, y_low).m128_u64[0],
		                  (Vector2)s_RadialBlurWithChromaticAberration,
		                  v16,
		                  v17);
		          *(_QWORD *)&v56.x = ((__int64 (__fastcall *)(_QWORD, _QWORD))sub_1858CAD18)(
		                                v31,
		                                _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0]);
		          v33 = sub_182FA2AF0(&v56);
		          v34 = *(float *)&v33;
		          if ( *(float *)&v33 > 1.414 )
		          {
		            v35 = (Vector2)sub_182FA2990(&v56);
		            *(Vector2 *)&v56.x = sub_1853DF234(
		                                   (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u),
		                                   v35,
		                                   v36,
		                                   v37);
		            x_low.m128_f32[0] = v56.x * 0.5;
		            y_low.m128_f32[0] = v56.y * 0.5;
		          }
		          Beyond::JobMathf::Clamp01(v32, *(float *)&v34);
		          v38 = x_low.m128_i32[0];
		          v39 = y_low.m128_i32[0];
		          Beyond::JobMathf::Clamp01(v40, *(float *)&v34);
		          v41 = 1.2;
		          v42 = v39;
		          v43 = 0;
		          v44 = 0.0;
		          v45 = 0.0;
		          if ( v14 )
		          {
		            if ( !v13 )
		            {
		              v46 = 0.0;
		              goto LABEL_58;
		            }
		            s_RadialBlurWithChromaticAberration = (String *)radialBlur->fields.intensity;
		            if ( !s_RadialBlurWithChromaticAberration )
		              goto LABEL_69;
		            v47 = sub_1800057D0(10LL, s_RadialBlurWithChromaticAberration);
		            s_RadialBlurWithChromaticAberration = (String *)chromaticAbberation->fields.intensity;
		            v48 = *(float *)&v47;
		            if ( !s_RadialBlurWithChromaticAberration )
		              goto LABEL_69;
		            v49 = sub_1800057D0(10LL, s_RadialBlurWithChromaticAberration);
		            Beyond::JobMathf::Clamp01(v50, *(float *)&v34);
		            v46 = v48 / *(float *)&v49;
		          }
		          else
		          {
		            v46 = 0.0;
		            if ( !v13 )
		              goto LABEL_61;
		          }
		          s_RadialBlurWithChromaticAberration = (String *)radialBlur->fields.power;
		          if ( !s_RadialBlurWithChromaticAberration )
		            goto LABEL_69;
		          v51 = sub_1800057D0(10LL, s_RadialBlurWithChromaticAberration);
		          s_RadialBlurWithChromaticAberration = (String *)radialBlur->fields.intensity;
		          v41 = *(float *)&v51;
		          if ( !s_RadialBlurWithChromaticAberration )
		            goto LABEL_69;
		          v52 = sub_1800057D0(10LL, s_RadialBlurWithChromaticAberration);
		          s_RadialBlurWithChromaticAberration = (String *)radialBlur->fields.averageSteps;
		          v43 = LODWORD(v52);
		          if ( !s_RadialBlurWithChromaticAberration )
		            goto LABEL_69;
		          v44 = (float)(unsigned __int8)sub_180006280(10LL, s_RadialBlurWithChromaticAberration);
		          if ( !v14 )
		          {
		LABEL_60:
		            if ( v13 && v14 )
		            {
		              s_RadialBlurWithChromaticAberration = (String *)radialBlur->fields.intensity;
		              if ( !s_RadialBlurWithChromaticAberration )
		                goto LABEL_69;
		              v53 = sub_1800057D0(10LL, s_RadialBlurWithChromaticAberration);
		              v54 = 6;
		              if ( *(float *)&v53 <= 0.01 )
		                v54 = 3;
		              static_fields = v54;
		              goto LABEL_66;
		            }
		LABEL_61:
		            static_fields = 3LL;
		LABEL_66:
		            *(_QWORD *)&v57.x = __PAIR64__(v42, v38);
		            *(_QWORD *)&v57.z = __PAIR64__(LODWORD(v41), v43);
		            data->fields.radialBlurParams = v57;
		            s_RadialBlurWithChromaticAberration = (String *)chromaticAbberation->fields.intensity;
		            if ( s_RadialBlurWithChromaticAberration )
		            {
		              v57.x = (float)(int)static_fields;
		              v55 = sub_1800057D0(10LL, s_RadialBlurWithChromaticAberration);
		              *(_QWORD *)&v57.y = __PAIR64__(LODWORD(v44), LODWORD(v55));
		              v57.w = v45;
		              data->fields.radialBlurParams2 = v57;
		              return;
		            }
		            goto LABEL_69;
		          }
		LABEL_58:
		          Beyond::JobMathf::ClampedLerp((Beyond::JobMathf *)static_fields, v41, v46, v6);
		          s_RadialBlurWithChromaticAberration = (String *)chromaticAbberation->fields.averageStep;
		          v41 = 1.0;
		          if ( !s_RadialBlurWithChromaticAberration )
		            goto LABEL_69;
		          v45 = (float)(unsigned __int8)sub_180006280(10LL, s_RadialBlurWithChromaticAberration);
		          goto LABEL_60;
		        }
		      }
		      s_RadialBlurWithChromaticAberration = (String *)radialBlur->fields.enableGlobalCenter;
		      if ( !s_RadialBlurWithChromaticAberration )
		        goto LABEL_69;
		      if ( !(unsigned __int8)sub_180006280(10LL, s_RadialBlurWithChromaticAberration) )
		      {
		        s_RadialBlurWithChromaticAberration = (String *)radialBlur->fields.center;
		        goto LABEL_26;
		      }
		      if ( !camera )
		        goto LABEL_69;
		      globalCenter = radialBlur->fields.globalCenter;
		    }
		    v24 = camera->fields.camera;
		    if ( !globalCenter )
		      goto LABEL_69;
		    v25 = sub_180049560(&v57, 10LL, globalCenter);
		    if ( !v24 )
		      goto LABEL_69;
		    v26 = *(_QWORD *)v25;
		    v27 = *(float *)(v25 + 8);
		    *(_QWORD *)&v56.x = v26;
		    v56.z = v27;
		    v28 = UnityEngine::Camera::WorldToViewportPoint((Vector3 *)&v57, v24, (Vector3 *)&v56, 0LL);
		    v29 = *(_QWORD *)&v28->x;
		    *(float *)&v28 = v28->z;
		    *(_QWORD *)&v56.x = v29;
		    LODWORD(v56.z) = (_DWORD)v28;
		    v21 = UnityEngine::Vector4::op_Implicit(&v56, v30);
		    goto LABEL_43;
		  }
		  static_fields = (__int64)IFix::WrappersManagerImpl::GetPatch(2937, 0LL);
		  if ( !static_fields )
		    goto LABEL_69;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_19(
		    (ILFixDynamicMethodWrapper_19 *)static_fields,
		    (Object *)settingParameters,
		    (Object *)data,
		    (Object *)camera,
		    (Object *)radialBlur,
		    (Object *)chromaticAbberation,
		    0LL);
		}
		
		internal static void PrepareBWFlashParameters(UberPostPassData data, HGCamera camera, HGBWFlash bwFlash) {} // 0x0000000189B831B4-0x0000000189B83710
		// Void PrepareBWFlashParameters(UberPostPassUtils+UberPostPassData, HGCamera, HGBWFlash)
		void HG::Rendering::Runtime::UberPostPassUtils::PrepareBWFlashParameters(
		        UberPostPassUtils_UberPostPassData *data,
		        HGCamera *camera,
		        HGBWFlash *bwFlash,
		        MethodInfo *method)
		{
		  void *bwThreshold; // rdx
		  __int64 v8; // rcx
		  bool IsActive; // al
		  double v10; // xmm0_8
		  unsigned int v11; // xmm7_4
		  double v12; // xmm0_8
		  unsigned int v13; // xmm6_4
		  int v14; // ebx
		  char v15; // al
		  char v16; // bl
		  char v17; // bp
		  Material *uberPostMaterial; // rbx
		  float v19; // eax
		  __int64 v20; // rax
		  int v21; // eax
		  __int64 v22; // rax
		  __int64 v23; // rax
		  unsigned int v24; // eax
		  HGRuntimeGrassQuery_Node *v25; // rdx
		  HGRuntimeGrassQuery_Node *v26; // r8
		  Int32__Array **v27; // r9
		  Material *v28; // rbx
		  __int64 v29; // rax
		  __int64 v30; // rax
		  unsigned int v31; // eax
		  double v32; // xmm0_8
		  HGRuntimeGrassQuery_Node *v33; // rdx
		  HGRuntimeGrassQuery_Node *v34; // r8
		  Int32__Array **v35; // r9
		  int v36; // ebx
		  double v37; // xmm0_8
		  ColorParameter *flashColor; // r8
		  ColorParameter *backGroundColor; // r8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v41; // [rsp+20h] [rbp-68h]
		  Vector4 v42; // [rsp+30h] [rbp-58h]
		  __int64 v43; // [rsp+44h] [rbp-44h]
		  unsigned int v44; // [rsp+4Ch] [rbp-3Ch]
		  unsigned int v45; // [rsp+4Ch] [rbp-3Ch]
		  __int128 v46; // [rsp+50h] [rbp-38h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2940, 0LL) )
		  {
		    if ( bwFlash )
		    {
		      IsActive = HG::Rendering::Runtime::HGBWFlash::IsActive(bwFlash, 0LL);
		      if ( data )
		      {
		        data->fields.isBwFlashEnabled = IsActive;
		        if ( !IsActive )
		          return;
		        bwThreshold = bwFlash->fields.bwThreshold;
		        if ( bwThreshold )
		        {
		          v10 = sub_1800057D0(10LL, bwThreshold);
		          bwThreshold = bwFlash->fields.colorBias;
		          v11 = LODWORD(v10);
		          if ( bwThreshold )
		          {
		            v12 = sub_1800057D0(10LL, bwThreshold);
		            bwThreshold = bwFlash->fields.inverse;
		            v13 = LODWORD(v12);
		            if ( bwThreshold )
		            {
		              v14 = (unsigned __int8)sub_180006280(10LL, bwThreshold);
		              sub_1800036A0(TypeInfo::System::Convert);
		              *(_QWORD *)&v46 = __PAIR64__(v13, v11);
		              *((_QWORD *)&v46 + 1) = COERCE_UNSIGNED_INT((float)v14);
		              data->fields.bwFlashThreshold = (Vector4)v46;
		              bwThreshold = bwFlash->fields.useFlashTex;
		              if ( bwThreshold )
		              {
		                v15 = sub_180006280(10LL, bwThreshold);
		                bwThreshold = bwFlash->fields.useMaskTex;
		                v16 = v15;
		                if ( bwThreshold )
		                {
		                  v17 = sub_180006280(10LL, bwThreshold);
		                  if ( v16 )
		                  {
		                    uberPostMaterial = data->fields.uberPostMaterial;
		                    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		                    bwThreshold = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_BWFlashTex;
		                    if ( !uberPostMaterial )
		                      goto LABEL_39;
		                    UnityEngine::Material::EnableKeyword(uberPostMaterial, (String *)bwThreshold, 0LL);
		                    bwThreshold = bwFlash->fields.centerPosition;
		                    if ( !bwThreshold )
		                      goto LABEL_39;
		                    LODWORD(v19) = sub_180041350(10LL);
		                    bwThreshold = bwFlash->fields.centerPosition;
		                    v42.x = v19;
		                    if ( !bwThreshold )
		                      goto LABEL_39;
		                    v20 = sub_180041350(10LL);
		                    bwThreshold = bwFlash->fields.flashTexSpeed;
		                    LODWORD(v43) = HIDWORD(v20);
		                    if ( !bwThreshold )
		                      goto LABEL_39;
		                    v21 = sub_180041350(10LL);
		                    bwThreshold = bwFlash->fields.flashTexSpeed;
		                    HIDWORD(v43) = v21;
		                    if ( !bwThreshold )
		                      goto LABEL_39;
		                    *(_QWORD *)&v42.y = v43;
		                    *(_QWORD *)&v46 = sub_180041350(10LL);
		                    v42.w = *((float *)&v46 + 1);
		                    data->fields.bwFlashParams = v42;
		                    bwThreshold = bwFlash->fields.flashTexTiling;
		                    if ( !bwThreshold )
		                      goto LABEL_39;
		                    v22 = sub_180041350(10LL);
		                    bwThreshold = bwFlash->fields.flashTexTiling;
		                    *(_QWORD *)&v46 = v22;
		                    if ( !bwThreshold )
		                      goto LABEL_39;
		                    v23 = sub_180041350(10LL);
		                    bwThreshold = bwFlash->fields.flashTexOffset;
		                    v44 = HIDWORD(v23);
		                    if ( !bwThreshold )
		                      goto LABEL_39;
		                    v24 = sub_180041350(10LL);
		                    bwThreshold = bwFlash->fields.flashTexOffset;
		                    if ( !bwThreshold )
		                      goto LABEL_39;
		                    *(_QWORD *)((char *)&v46 + 4) = __PAIR64__(v24, v44);
		                    HIDWORD(v46) = (unsigned __int64)sub_180041350(10LL) >> 32;
		                    data->fields.bwFlashParams2 = (Vector4)v46;
		                    bwThreshold = bwFlash->fields.flashIntensity;
		                    if ( !bwThreshold )
		                      goto LABEL_39;
		                    *(_QWORD *)&v46 = sub_180041350(10LL);
		                    LODWORD(data->fields.bwFlashParams4.x) = v46;
		                    bwThreshold = bwFlash->fields.flashIntensity;
		                    if ( !bwThreshold )
		                      goto LABEL_39;
		                    *(_QWORD *)&v46 = sub_180041350(10LL);
		                    data->fields.bwFlashParams4.y = *((float *)&v46 + 1);
		                    bwThreshold = bwFlash->fields.flashTexture;
		                    if ( !bwThreshold )
		                      goto LABEL_39;
		                    data->fields.bwFlashTexture = (Texture *)sub_1800460A0(10LL, bwThreshold);
		                    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&data->fields.bwFlashTexture, v25, v26, v27, v41);
		                  }
		                  if ( v17 )
		                  {
		                    v28 = data->fields.uberPostMaterial;
		                    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		                    bwThreshold = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields;
		                    if ( !v28 )
		                      goto LABEL_39;
		                    UnityEngine::Material::EnableKeyword(v28, *((String **)bwThreshold + 41), 0LL);
		                    bwThreshold = bwFlash->fields.maskTexTiling;
		                    if ( !bwThreshold )
		                      goto LABEL_39;
		                    v29 = sub_180041350(10LL);
		                    bwThreshold = bwFlash->fields.maskTexTiling;
		                    *(_QWORD *)&v46 = v29;
		                    if ( !bwThreshold )
		                      goto LABEL_39;
		                    v30 = sub_180041350(10LL);
		                    bwThreshold = bwFlash->fields.maskTexOffset;
		                    v45 = HIDWORD(v30);
		                    if ( !bwThreshold )
		                      goto LABEL_39;
		                    v31 = sub_180041350(10LL);
		                    bwThreshold = bwFlash->fields.maskTexOffset;
		                    if ( !bwThreshold )
		                      goto LABEL_39;
		                    *(_QWORD *)((char *)&v46 + 4) = __PAIR64__(v31, v45);
		                    HIDWORD(v46) = (unsigned __int64)sub_180041350(10LL) >> 32;
		                    data->fields.bwFlashParams3 = (Vector4)v46;
		                    bwThreshold = bwFlash->fields.maskIntensity;
		                    if ( !bwThreshold )
		                      goto LABEL_39;
		                    v32 = sub_1800057D0(10LL, bwThreshold);
		                    data->fields.bwFlashParams4.z = *(float *)&v32;
		                    bwThreshold = bwFlash->fields.maskTexture;
		                    if ( !bwThreshold )
		                      goto LABEL_39;
		                    data->fields.bwMaskTexture = (Texture *)sub_1800460A0(10LL, bwThreshold);
		                    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&data->fields.bwMaskTexture, v33, v34, v35, v41);
		                    bwThreshold = bwFlash->fields.maskUsePolarUV;
		                    if ( !bwThreshold )
		                      goto LABEL_39;
		                    v36 = (unsigned __int8)sub_180006280(10LL, bwThreshold);
		                    sub_1800036A0(TypeInfo::System::Convert);
		                    data->fields.bwFlashThreshold.w = (float)v36;
		                  }
		                  bwThreshold = bwFlash->fields.bwSceneLerp;
		                  if ( bwThreshold )
		                  {
		                    v37 = sub_1800057D0(10LL, bwThreshold);
		                    data->fields.bwFlashParams4.w = *(float *)&v37;
		                    flashColor = bwFlash->fields.flashColor;
		                    if ( flashColor )
		                    {
		                      data->fields.bwFlashColor = (Color)_mm_loadu_si128((const __m128i *)sub_180032E40(
		                                                                                            &v46,
		                                                                                            10LL,
		                                                                                            flashColor));
		                      backGroundColor = bwFlash->fields.backGroundColor;
		                      if ( backGroundColor )
		                      {
		                        data->fields.bwBackGroundColor = (Color)_mm_loadu_si128((const __m128i *)sub_180032E40(
		                                                                                                   &v46,
		                                                                                                   10LL,
		                                                                                                   backGroundColor));
		                        return;
		                      }
		                    }
		                  }
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_39:
		    sub_1800D8260(v8, bwThreshold);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2940, 0LL);
		  if ( !Patch )
		    goto LABEL_39;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
		    (ILFixDynamicMethodWrapper_30 *)Patch,
		    (Object *)data,
		    (Object *)camera,
		    (Object *)bwFlash,
		    0LL);
		}
		
	}
}
