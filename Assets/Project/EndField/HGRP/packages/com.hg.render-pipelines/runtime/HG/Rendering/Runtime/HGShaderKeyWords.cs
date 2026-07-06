using System;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	public static class HGShaderKeyWords
	{
		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static readonly GlobalKeyword s_EnableScreenSpaceShadowMask;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		public static readonly GlobalKeyword s_MVKeyword;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x20")]
		public static readonly GlobalKeyword s_PerObjectMVKeyword;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x30")]
		public static readonly GlobalKeyword s_DisableDynamicLightLoop;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x40")]
		public static readonly GlobalKeyword s_EnableWetness;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x50")]
		public static readonly GlobalKeyword s_RainWetnessHighQuality;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x60")]
		public static readonly GlobalKeyword s_EnableIrradianceVolumeV2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x70")]
		public static readonly GlobalKeyword s_EnableSubpassInputUnderOnePassDeferred;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x80")]
		public static readonly string s_HighQuality;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x88")]
		public static readonly string s_MediumQuality;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x90")]
		public static readonly string s_LowQuality;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x98")]
		public static readonly string s_EnableAlpha;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA0")]
		public static readonly string s_CharacterMask;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA8")]
		public static readonly string s_TonemappingNeutral;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB0")]
		public static readonly string s_TonemappingACES;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB8")]
		public static readonly string s_TonemappingCustom;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC0")]
		public static readonly string s_TonemappingExternal;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC8")]
		public static readonly string s_TonemappingNone;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xD0")]
		public static readonly string s_TonemappingACESmodified;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xD8")]
		public static readonly string s_SharpenFilter1;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xE0")]
		public static readonly string s_SharpenFilter2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xE8")]
		public static readonly string s_SharpenFilter4;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xF0")]
		public static readonly string s_Vignette;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xF8")]
		public static readonly string s_VignetteMask;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x100")]
		public static readonly string s_DirtyLens;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x108")]
		public static readonly string s_Bloom;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x110")]
		public static readonly string s_BloomDirt;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x118")]
		public static readonly string s_LightShaftCloudMask;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x120")]
		public static readonly string s_RadialBlur;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x128")]
		public static readonly string s_RadialBlurWithChromaticAberration;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x130")]
		public static readonly string s_UseScanLine;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x138")]
		public static readonly string s_UseBlackBox;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x140")]
		public static readonly string s_ScanLineUseMask;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x148")]
		public static readonly string s_BWMaskTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x150")]
		public static readonly string s_BWFlashTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x158")]
		public static readonly string s_ApplyLUT;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x160")]
		public static readonly string s_UserLUT;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x168")]
		public static readonly string s_MeteringCenter;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x170")]
		public static readonly string s_PerformSharpen;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x178")]
		public static readonly string s_TaauPerformanceMode;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x180")]
		public static readonly string s_TaauNextgenMode;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x188")]
		public static readonly string s_EnableHierarchicalZOcclusionCulling;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x190")]
		public static readonly string s_WorldUIKeyword;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x198")]
		public static readonly string[] s_DoFKernelRadiusKeywords;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1A0")]
		public static readonly string s_DebugFullScreen;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1A8")]
		public static readonly string s_DebugFullScreenPreDepth;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1B0")]
		public static readonly string s_DebugRegular;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1B8")]
		public static readonly string s_UseAutoExposureHistogram;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1C0")]
		public static readonly string s_EnableFoliageOccluderMask;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1C8")]
		public static readonly string s_HighQualityMultiScatteringApproxEnabled;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1D0")]
		public static readonly string SUNDISC_HQ;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1D8")]
		public static readonly string HG_SKYBOX_STAR;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1E0")]
		public static readonly string HG_SKYBOX_NEBULA;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1E8")]
		public static readonly string s_Ring;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1F0")]
		public static readonly string[] s_DrawPlanetsRing;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1F8")]
		public static readonly string[] s_DrawPlanetsAtmosphere;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x200")]
		public static readonly string CLOUDS_FLOWMAP;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x208")]
		public static readonly string ENABLE_CLOUDS_SHADOW;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x210")]
		public static readonly string DRAW_ADVANCED_PLANET;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x218")]
		public static readonly string DRAW_ADVANCED_PLANET_CLOUDS_FLOWMAP;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x220")]
		public static readonly string DRAW_ADVANCED_PLANET_CLOUDS_SHADOW;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x228")]
		public static readonly string s_Cloud;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x230")]
		public static readonly string s_CloudFlowMap;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x238")]
		public static readonly string s_CloudProceduralFlow;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x240")]
		public static readonly string s_GTAOUseFP32Depths;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x248")]
		public static readonly string s_GTAOBentNormals;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x250")]
		public static readonly string s_SSRImportanceSample;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x258")]
		public static readonly string s_SceneColorAdjustMentEnableSaturation;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x260")]
		public static readonly string s_FakeGlint;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x268")]
		public static readonly string s_SubsurfaceProfile;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x270")]
		public static readonly string s_FakeVolume;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x278")]
		public static readonly string s_FakeCrackCSM;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x280")]
		public static readonly string s_FakeShadow;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x288")]
		public static readonly string s_DisableTerrainContactShadow;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x290")]
		public static readonly string s_HasTerrainLayerTypeData;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x298")]
		public static readonly string s_InteractionUseCCD;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2A0")]
		public static readonly string s_SubsurfaceProfileSimple;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2A8")]
		public static readonly string s_MipLevelCount1;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2B0")]
		public static readonly string s_MipLevelCount2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2B8")]
		public static readonly string s_MipLevelCount3;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2C0")]
		public static readonly string s_MipLevelCount4;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2C8")]
		public static readonly string s_FetchFromLastMip;
	}
}
