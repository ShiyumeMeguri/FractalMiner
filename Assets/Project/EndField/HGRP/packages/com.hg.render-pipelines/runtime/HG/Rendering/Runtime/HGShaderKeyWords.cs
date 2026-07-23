using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public static class HGShaderKeyWords // TypeDefIndex: 38168
	{
		// Fields
		public static readonly GlobalKeyword s_EnableScreenSpaceShadowMask; // 0x00
		public static readonly GlobalKeyword s_MVKeyword; // 0x10
		public static readonly GlobalKeyword s_PerObjectMVKeyword; // 0x20
		public static readonly GlobalKeyword s_DisableDynamicLightLoop; // 0x30
		public static readonly GlobalKeyword s_EnableWetness; // 0x40
		public static readonly GlobalKeyword s_RainWetnessHighQuality; // 0x50
		public static readonly GlobalKeyword s_EnableIrradianceVolumeV2; // 0x60
		public static readonly GlobalKeyword s_EnableSubpassInputUnderOnePassDeferred; // 0x70
		public static readonly string s_HighQuality; // 0x80
		public static readonly string s_MediumQuality; // 0x88
		public static readonly string s_LowQuality; // 0x90
		public static readonly string s_EnableAlpha; // 0x98
		public static readonly string s_CharacterMask; // 0xA0
		public static readonly string s_TonemappingNeutral; // 0xA8
		public static readonly string s_TonemappingACES; // 0xB0
		public static readonly string s_TonemappingCustom; // 0xB8
		public static readonly string s_TonemappingExternal; // 0xC0
		public static readonly string s_TonemappingNone; // 0xC8
		public static readonly string s_TonemappingACESmodified; // 0xD0
		public static readonly string s_SharpenFilter1; // 0xD8
		public static readonly string s_SharpenFilter2; // 0xE0
		public static readonly string s_SharpenFilter4; // 0xE8
		public static readonly string s_Vignette; // 0xF0
		public static readonly string s_VignetteMask; // 0xF8
		public static readonly string s_DirtyLens; // 0x100
		public static readonly string s_Bloom; // 0x108
		public static readonly string s_BloomDirt; // 0x110
		public static readonly string s_LightShaftCloudMask; // 0x118
		public static readonly string s_RadialBlur; // 0x120
		public static readonly string s_RadialBlurWithChromaticAberration; // 0x128
		public static readonly string s_UseScanLine; // 0x130
		public static readonly string s_UseBlackBox; // 0x138
		public static readonly string s_ScanLineUseMask; // 0x140
		public static readonly string s_BWMaskTex; // 0x148
		public static readonly string s_BWFlashTex; // 0x150
		public static readonly string s_ApplyLUT; // 0x158
		public static readonly string s_UserLUT; // 0x160
		public static readonly string s_MeteringCenter; // 0x168
		public static readonly string s_PerformSharpen; // 0x170
		public static readonly string s_TaauPerformanceMode; // 0x178
		public static readonly string s_TaauNextgenMode; // 0x180
		public static readonly string s_EnableHierarchicalZOcclusionCulling; // 0x188
		public static readonly string s_WorldUIKeyword; // 0x190
		public static readonly string[] s_DoFKernelRadiusKeywords; // 0x198
		public static readonly string s_DebugFullScreen; // 0x1A0
		public static readonly string s_DebugFullScreenPreDepth; // 0x1A8
		public static readonly string s_DebugRegular; // 0x1B0
		public static readonly string s_UseAutoExposureHistogram; // 0x1B8
		public static readonly string s_EnableFoliageOccluderMask; // 0x1C0
		public static readonly string s_HighQualityMultiScatteringApproxEnabled; // 0x1C8
		public static readonly string SUNDISC_HQ; // 0x1D0
		public static readonly string HG_SKYBOX_STAR; // 0x1D8
		public static readonly string HG_SKYBOX_NEBULA; // 0x1E0
		public static readonly string s_Ring; // 0x1E8
		public static readonly string[] s_DrawPlanetsRing; // 0x1F0
		public static readonly string[] s_DrawPlanetsAtmosphere; // 0x1F8
		public static readonly string CLOUDS_FLOWMAP; // 0x200
		public static readonly string ENABLE_CLOUDS_SHADOW; // 0x208
		public static readonly string DRAW_ADVANCED_PLANET; // 0x210
		public static readonly string DRAW_ADVANCED_PLANET_CLOUDS_FLOWMAP; // 0x218
		public static readonly string DRAW_ADVANCED_PLANET_CLOUDS_SHADOW; // 0x220
		public static readonly string s_Cloud; // 0x228
		public static readonly string s_CloudFlowMap; // 0x230
		public static readonly string s_CloudProceduralFlow; // 0x238
		public static readonly string s_GTAOUseFP32Depths; // 0x240
		public static readonly string s_GTAOBentNormals; // 0x248
		public static readonly string s_GTAOGenerateNormalsInplace; // 0x250
		public static readonly string s_SSRImportanceSample; // 0x258
		public static readonly string s_SceneColorAdjustMentEnableSaturation; // 0x260
		public static readonly string s_FakeGlint; // 0x268
		public static readonly string s_SubsurfaceProfile; // 0x270
		public static readonly string s_FakeVolume; // 0x278
		public static readonly string s_FakeCrackCSM; // 0x280
		public static readonly string s_FakeShadow; // 0x288
		public static readonly string s_DisableTerrainContactShadow; // 0x290
		public static readonly string s_HasTerrainLayerTypeData; // 0x298
		public static readonly string s_InteractionUseCCD; // 0x2A0
		public static readonly string s_SubsurfaceProfileSimple; // 0x2A8
		public static readonly string s_MipLevelCount1; // 0x2B0
		public static readonly string s_MipLevelCount2; // 0x2B8
		public static readonly string s_MipLevelCount3; // 0x2C0
		public static readonly string s_MipLevelCount4; // 0x2C8
		public static readonly string s_FetchFromLastMip; // 0x2D0
		public static readonly string s_GPUDrivenDebugNoCulling; // 0x2D8
		public static readonly string s_GPUDrivenDisableHZBCulling; // 0x2E0
		public static readonly string s_GPUDrivenV1; // 0x2E8
		public static readonly string s_GPUDrivenV2; // 0x2F0
	
		// Constructors
		static HGShaderKeyWords() {} // 0x0000000189B89F7C-0x0000000189B8C5F4
		// HGShaderKeyWords()
		void HG::Rendering::Runtime::HGShaderKeyWords::cctor(MethodInfo *method)
		{
		  unsigned __int64 v1; // r8
		  unsigned __int64 v2; // rdx
		  signed __int64 v3; // rtt
		  unsigned __int64 v4; // r8
		  unsigned __int64 v5; // rdx
		  signed __int64 v6; // rtt
		  unsigned __int64 v7; // r8
		  unsigned __int64 v8; // rdx
		  signed __int64 v9; // rtt
		  unsigned __int64 v10; // r8
		  unsigned __int64 v11; // rdx
		  signed __int64 v12; // rtt
		  unsigned __int64 v13; // r8
		  unsigned __int64 v14; // rdx
		  signed __int64 v15; // rtt
		  unsigned __int64 v16; // r8
		  unsigned __int64 v17; // rdx
		  signed __int64 v18; // rtt
		  unsigned __int64 v19; // r8
		  unsigned __int64 v20; // rdx
		  signed __int64 v21; // rtt
		  unsigned __int64 v22; // r8
		  unsigned __int64 v23; // rdx
		  signed __int64 v24; // rtt
		  unsigned __int64 v25; // r8
		  unsigned __int64 v26; // rdx
		  signed __int64 v27; // rtt
		  unsigned __int64 v28; // r8
		  unsigned __int64 v29; // rdx
		  signed __int64 v30; // rtt
		  unsigned __int64 v31; // r8
		  unsigned __int64 v32; // rdx
		  signed __int64 v33; // rtt
		  unsigned __int64 v34; // r8
		  unsigned __int64 v35; // rdx
		  signed __int64 v36; // rtt
		  unsigned __int64 v37; // r8
		  unsigned __int64 v38; // rdx
		  signed __int64 v39; // rtt
		  unsigned __int64 v40; // r8
		  unsigned __int64 v41; // rdx
		  signed __int64 v42; // rtt
		  unsigned __int64 v43; // r8
		  unsigned __int64 v44; // rdx
		  signed __int64 v45; // rtt
		  unsigned __int64 v46; // r8
		  unsigned __int64 v47; // rdx
		  signed __int64 v48; // rtt
		  unsigned __int64 v49; // r8
		  unsigned __int64 v50; // rdx
		  signed __int64 v51; // rtt
		  unsigned __int64 v52; // r8
		  unsigned __int64 v53; // rdx
		  signed __int64 v54; // rtt
		  unsigned __int64 v55; // r8
		  unsigned __int64 v56; // rdx
		  signed __int64 v57; // rtt
		  unsigned __int64 v58; // r8
		  unsigned __int64 v59; // rdx
		  signed __int64 v60; // rtt
		  unsigned __int64 v61; // r8
		  unsigned __int64 v62; // rdx
		  signed __int64 v63; // rtt
		  unsigned __int64 v64; // r8
		  unsigned __int64 v65; // rdx
		  signed __int64 v66; // rtt
		  unsigned __int64 v67; // r8
		  unsigned __int64 v68; // rdx
		  signed __int64 v69; // rtt
		  unsigned __int64 v70; // r8
		  unsigned __int64 v71; // rdx
		  signed __int64 v72; // rtt
		  unsigned __int64 v73; // r8
		  unsigned __int64 v74; // rdx
		  signed __int64 v75; // rtt
		  unsigned __int64 v76; // r8
		  unsigned __int64 v77; // rdx
		  signed __int64 v78; // rtt
		  unsigned __int64 v79; // r8
		  unsigned __int64 v80; // rdx
		  signed __int64 v81; // rtt
		  unsigned __int64 v82; // r8
		  unsigned __int64 v83; // rdx
		  signed __int64 v84; // rtt
		  unsigned __int64 v85; // r8
		  unsigned __int64 v86; // rdx
		  signed __int64 v87; // rtt
		  unsigned __int64 v88; // r8
		  unsigned __int64 v89; // rdx
		  signed __int64 v90; // rtt
		  unsigned __int64 v91; // r8
		  unsigned __int64 v92; // rdx
		  signed __int64 v93; // rtt
		  unsigned __int64 v94; // r8
		  unsigned __int64 v95; // rdx
		  signed __int64 v96; // rtt
		  unsigned __int64 v97; // r8
		  unsigned __int64 v98; // rdx
		  signed __int64 v99; // rtt
		  unsigned __int64 v100; // r8
		  unsigned __int64 v101; // rdx
		  signed __int64 v102; // rtt
		  unsigned __int64 v103; // r8
		  unsigned __int64 v104; // rdx
		  signed __int64 v105; // rtt
		  unsigned __int64 v106; // r8
		  unsigned __int64 v107; // rdx
		  signed __int64 v108; // rtt
		  unsigned __int64 v109; // r8
		  unsigned __int64 v110; // rdx
		  signed __int64 v111; // rtt
		  unsigned __int64 v112; // r8
		  unsigned __int64 v113; // rdx
		  signed __int64 v114; // rtt
		  unsigned __int64 v115; // r8
		  unsigned __int64 v116; // rdx
		  signed __int64 v117; // rtt
		  unsigned __int64 v118; // r8
		  unsigned __int64 v119; // rdx
		  signed __int64 v120; // rtt
		  unsigned __int64 v121; // r8
		  unsigned __int64 v122; // rdx
		  signed __int64 v123; // rtt
		  unsigned __int64 v124; // r8
		  unsigned __int64 v125; // rdx
		  signed __int64 v126; // rtt
		  unsigned __int64 v127; // r8
		  unsigned __int64 v128; // rdx
		  signed __int64 v129; // rtt
		  __int64 v130; // rax
		  __int64 v131; // rdx
		  __int64 v132; // rcx
		  String__Array *v133; // rbx
		  bool v134; // zf
		  unsigned __int64 v135; // r8
		  unsigned __int64 v136; // rdx
		  signed __int64 v137; // rtt
		  unsigned __int64 v138; // r8
		  unsigned __int64 v139; // rdx
		  signed __int64 v140; // rtt
		  unsigned __int64 v141; // r8
		  unsigned __int64 v142; // rdx
		  signed __int64 v143; // rtt
		  unsigned __int64 v144; // r8
		  unsigned __int64 v145; // rdx
		  signed __int64 v146; // rtt
		  unsigned __int64 v147; // r8
		  unsigned __int64 v148; // rdx
		  signed __int64 v149; // rtt
		  unsigned __int64 v150; // r8
		  unsigned __int64 v151; // rdx
		  signed __int64 v152; // rtt
		  unsigned __int64 v153; // r8
		  unsigned __int64 v154; // rdx
		  signed __int64 v155; // rtt
		  unsigned __int64 v156; // r8
		  unsigned __int64 v157; // rdx
		  signed __int64 v158; // rtt
		  unsigned __int64 v159; // r8
		  unsigned __int64 v160; // rdx
		  signed __int64 v161; // rtt
		  unsigned __int64 v162; // r8
		  unsigned __int64 v163; // rdx
		  signed __int64 v164; // rtt
		  unsigned __int64 v165; // r8
		  unsigned __int64 v166; // rdx
		  signed __int64 v167; // rtt
		  __int64 v168; // rax
		  String__Array *v169; // rbx
		  unsigned __int64 v170; // r8
		  unsigned __int64 v171; // rdx
		  signed __int64 v172; // rtt
		  __int64 v173; // rax
		  __int64 v174; // rbx
		  unsigned __int64 v175; // r8
		  Int32__Array **v176; // r9
		  unsigned __int64 static_fields; // rdx
		  signed __int64 v178; // rtt
		  signed __int64 v179; // rtt
		  signed __int64 v180; // rtt
		  signed __int64 v181; // rtt
		  signed __int64 v182; // rtt
		  signed __int64 v183; // rtt
		  signed __int64 v184; // rtt
		  signed __int64 v185; // rtt
		  signed __int64 v186; // rtt
		  signed __int64 v187; // rtt
		  signed __int64 v188; // rtt
		  signed __int64 v189; // rtt
		  signed __int64 v190; // rtt
		  signed __int64 v191; // rtt
		  signed __int64 v192; // rtt
		  signed __int64 v193; // rtt
		  signed __int64 v194; // rtt
		  signed __int64 v195; // rtt
		  signed __int64 v196; // rtt
		  signed __int64 v197; // rtt
		  signed __int64 v198; // rtt
		  signed __int64 v199; // rtt
		  signed __int64 v200; // rtt
		  signed __int64 v201; // rtt
		  signed __int64 v202; // rtt
		  signed __int64 v203; // rtt
		  signed __int64 v204; // rtt
		  signed __int64 v205; // rtt
		  signed __int64 v206; // rtt
		  signed __int64 v207; // rtt
		  Int32__Array **v208; // r9
		  HGRuntimeGrassQuery_Node *v209; // rdx
		  HGRuntimeGrassQuery_Node *v210; // r8
		  GlobalKeyword v211; // [rsp+20h] [rbp-10h] BYREF
		  MethodInfo *v212; // [rsp+80h] [rbp+50h]
		
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_EnableScreenSpaceShadowMask = *UnityEngine::Rendering::GlobalKeyword::Create(&v211, (String *)"HG_ENABLE_SCREEN_SPACE_SHADOW_MASK", 0LL);
		  if ( dword_18F35FD08 )
		  {
		    v1 = (((unsigned __int64)TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields >> 12) & 0x1FFFFF) >> 6;
		    v2 = ((unsigned __int64)TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v1 + 36190]);
		    do
		      v3 = qword_18F0BCBA0[v1 + 36190];
		    while ( v3 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v1 + 36190], v3 | (1LL << v2), v3) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_MVKeyword = *UnityEngine::Rendering::GlobalKeyword::Create(
		                                                                                      &v211,
		                                                                                      (String *)"HG_ENABLE_MV",
		                                                                                      0LL);
		  if ( dword_18F35FD08 )
		  {
		    v4 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_MVKeyword >> 12) & 0x1FFFFF) >> 6;
		    v5 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_MVKeyword >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v4 + 36190]);
		    do
		      v6 = qword_18F0BCBA0[v4 + 36190];
		    while ( v6 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v4 + 36190], v6 | (1LL << v5), v6) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_PerObjectMVKeyword = *UnityEngine::Rendering::GlobalKeyword::Create(
		                                                                                               &v211,
		                                                                                               (String *)"HG_ENABLE_PER_OBJECT_MV",
		                                                                                               0LL);
		  if ( dword_18F35FD08 )
		  {
		    v7 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_PerObjectMVKeyword >> 12) & 0x1FFFFF) >> 6;
		    v8 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_PerObjectMVKeyword >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v7 + 36190]);
		    do
		      v9 = qword_18F0BCBA0[v7 + 36190];
		    while ( v9 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v7 + 36190], v9 | (1LL << v8), v9) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_DisableDynamicLightLoop = *UnityEngine::Rendering::GlobalKeyword::Create(
		                                                                                                    &v211,
		                                                                                                    (String *)"HG_DISABLE_DYNAMIC_LIGHTLOOP",
		                                                                                                    0LL);
		  if ( dword_18F35FD08 )
		  {
		    v10 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_DisableDynamicLightLoop >> 12) & 0x1FFFFF) >> 6;
		    v11 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_DisableDynamicLightLoop >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v10 + 36190]);
		    do
		      v12 = qword_18F0BCBA0[v10 + 36190];
		    while ( v12 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v10 + 36190], v12 | (1LL << v11), v12) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_EnableWetness = *UnityEngine::Rendering::GlobalKeyword::Create(
		                                                                                          &v211,
		                                                                                          (String *)"HG_ENABLE_WETNESS",
		                                                                                          0LL);
		  if ( dword_18F35FD08 )
		  {
		    v13 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_EnableWetness >> 12) & 0x1FFFFF) >> 6;
		    v14 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_EnableWetness >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v13 + 36190]);
		    do
		      v15 = qword_18F0BCBA0[v13 + 36190];
		    while ( v15 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v13 + 36190], v15 | (1LL << v14), v15) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_RainWetnessHighQuality = *UnityEngine::Rendering::GlobalKeyword::Create(
		                                                                                                   &v211,
		                                                                                                   (String *)"HG_RAIN_WETNESS_HIGH_QUALITY",
		                                                                                                   0LL);
		  if ( dword_18F35FD08 )
		  {
		    v16 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_RainWetnessHighQuality >> 12) & 0x1FFFFF) >> 6;
		    v17 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_RainWetnessHighQuality >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v16 + 36190]);
		    do
		      v18 = qword_18F0BCBA0[v16 + 36190];
		    while ( v18 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v16 + 36190], v18 | (1LL << v17), v18) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_EnableIrradianceVolumeV2 = *UnityEngine::Rendering::GlobalKeyword::Create(
		                                                                                                     &v211,
		                                                                                                     (String *)"HG_ENABLE_IRRADIANCE_VOLUME_V2",
		                                                                                                     0LL);
		  if ( dword_18F35FD08 )
		  {
		    v19 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_EnableIrradianceVolumeV2 >> 12) & 0x1FFFFF) >> 6;
		    v20 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_EnableIrradianceVolumeV2 >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v19 + 36190]);
		    do
		      v21 = qword_18F0BCBA0[v19 + 36190];
		    while ( v21 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v19 + 36190], v21 | (1LL << v20), v21) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_EnableSubpassInputUnderOnePassDeferred = *UnityEngine::Rendering::GlobalKeyword::Create(&v211, (String *)"HG_USE_SUBPASS_INPUT_UNDER_ONE_PASS_DEFERRED", 0LL);
		  if ( dword_18F35FD08 )
		  {
		    v22 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_EnableSubpassInputUnderOnePassDeferred >> 12) & 0x1FFFFF) >> 6;
		    v23 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_EnableSubpassInputUnderOnePassDeferred >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v22 + 36190]);
		    do
		      v24 = qword_18F0BCBA0[v22 + 36190];
		    while ( v24 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v22 + 36190], v24 | (1LL << v23), v24) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_HighQuality = (String *)"HIGH_QUALITY";
		  if ( dword_18F35FD08 )
		  {
		    v25 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_HighQuality >> 12) & 0x1FFFFF) >> 6;
		    v26 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_HighQuality >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v25 + 36190]);
		    do
		      v27 = qword_18F0BCBA0[v25 + 36190];
		    while ( v27 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v25 + 36190], v27 | (1LL << v26), v27) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_MediumQuality = (String *)"MEDIUM_QUALITY";
		  if ( dword_18F35FD08 )
		  {
		    v28 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_MediumQuality >> 12) & 0x1FFFFF) >> 6;
		    v29 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_MediumQuality >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v28 + 36190]);
		    do
		      v30 = qword_18F0BCBA0[v28 + 36190];
		    while ( v30 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v28 + 36190], v30 | (1LL << v29), v30) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_LowQuality = (String *)"LOW_QUALITY";
		  if ( dword_18F35FD08 )
		  {
		    v31 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_LowQuality >> 12) & 0x1FFFFF) >> 6;
		    v32 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_LowQuality >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v31 + 36190]);
		    do
		      v33 = qword_18F0BCBA0[v31 + 36190];
		    while ( v33 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v31 + 36190], v33 | (1LL << v32), v33) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_EnableAlpha = (String *)"ENABLE_ALPHA";
		  if ( dword_18F35FD08 )
		  {
		    v34 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_EnableAlpha >> 12) & 0x1FFFFF) >> 6;
		    v35 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_EnableAlpha >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v34 + 36190]);
		    do
		      v36 = qword_18F0BCBA0[v34 + 36190];
		    while ( v36 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v34 + 36190], v36 | (1LL << v35), v36) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_CharacterMask = (String *)"CHARACTER_MASK";
		  if ( dword_18F35FD08 )
		  {
		    v37 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_CharacterMask >> 12) & 0x1FFFFF) >> 6;
		    v38 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_CharacterMask >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v37 + 36190]);
		    do
		      v39 = qword_18F0BCBA0[v37 + 36190];
		    while ( v39 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v37 + 36190], v39 | (1LL << v38), v39) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_TonemappingNeutral = (String *)"TONEMAPPING_NEUTRAL";
		  if ( dword_18F35FD08 )
		  {
		    v40 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_TonemappingNeutral >> 12) & 0x1FFFFF) >> 6;
		    v41 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_TonemappingNeutral >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v40 + 36190]);
		    do
		      v42 = qword_18F0BCBA0[v40 + 36190];
		    while ( v42 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v40 + 36190], v42 | (1LL << v41), v42) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_TonemappingACES = (String *)"TONEMAPPING_ACES";
		  if ( dword_18F35FD08 )
		  {
		    v43 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_TonemappingACES >> 12) & 0x1FFFFF) >> 6;
		    v44 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_TonemappingACES >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v43 + 36190]);
		    do
		      v45 = qword_18F0BCBA0[v43 + 36190];
		    while ( v45 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v43 + 36190], v45 | (1LL << v44), v45) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_TonemappingCustom = (String *)"TONEMAPPING_CUSTOM";
		  if ( dword_18F35FD08 )
		  {
		    v46 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_TonemappingCustom >> 12) & 0x1FFFFF) >> 6;
		    v47 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_TonemappingCustom >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v46 + 36190]);
		    do
		      v48 = qword_18F0BCBA0[v46 + 36190];
		    while ( v48 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v46 + 36190], v48 | (1LL << v47), v48) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_TonemappingExternal = (String *)"TONEMAPPING_EXTERNAL";
		  if ( dword_18F35FD08 )
		  {
		    v49 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_TonemappingExternal >> 12) & 0x1FFFFF) >> 6;
		    v50 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_TonemappingExternal >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v49 + 36190]);
		    do
		      v51 = qword_18F0BCBA0[v49 + 36190];
		    while ( v51 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v49 + 36190], v51 | (1LL << v50), v51) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_TonemappingNone = (String *)"TONEMAPPING_NONE";
		  if ( dword_18F35FD08 )
		  {
		    v52 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_TonemappingNone >> 12) & 0x1FFFFF) >> 6;
		    v53 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_TonemappingNone >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v52 + 36190]);
		    do
		      v54 = qword_18F0BCBA0[v52 + 36190];
		    while ( v54 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v52 + 36190], v54 | (1LL << v53), v54) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_TonemappingACESmodified = (String *)"TONEMAPPING_ACES_MODIFIED";
		  if ( dword_18F35FD08 )
		  {
		    v55 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_TonemappingACESmodified >> 12) & 0x1FFFFF) >> 6;
		    v56 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_TonemappingACESmodified >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v55 + 36190]);
		    do
		      v57 = qword_18F0BCBA0[v55 + 36190];
		    while ( v57 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v55 + 36190], v57 | (1LL << v56), v57) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_SharpenFilter1 = (String *)"_SHAPEN_FILTER_1";
		  if ( dword_18F35FD08 )
		  {
		    v58 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_SharpenFilter1 >> 12) & 0x1FFFFF) >> 6;
		    v59 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_SharpenFilter1 >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v58 + 36190]);
		    do
		      v60 = qword_18F0BCBA0[v58 + 36190];
		    while ( v60 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v58 + 36190], v60 | (1LL << v59), v60) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_SharpenFilter2 = (String *)"_SHAPEN_FILTER_2";
		  if ( dword_18F35FD08 )
		  {
		    v61 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_SharpenFilter2 >> 12) & 0x1FFFFF) >> 6;
		    v62 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_SharpenFilter2 >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v61 + 36190]);
		    do
		      v63 = qword_18F0BCBA0[v61 + 36190];
		    while ( v63 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v61 + 36190], v63 | (1LL << v62), v63) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_SharpenFilter4 = (String *)"_SHAPEN_FILTER_4";
		  if ( dword_18F35FD08 )
		  {
		    v64 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_SharpenFilter4 >> 12) & 0x1FFFFF) >> 6;
		    v65 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_SharpenFilter4 >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v64 + 36190]);
		    do
		      v66 = qword_18F0BCBA0[v64 + 36190];
		    while ( v66 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v64 + 36190], v66 | (1LL << v65), v66) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_Vignette = (String *)"VIGNETTE";
		  if ( dword_18F35FD08 )
		  {
		    v67 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_Vignette >> 12) & 0x1FFFFF) >> 6;
		    v68 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_Vignette >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v67 + 36190]);
		    do
		      v69 = qword_18F0BCBA0[v67 + 36190];
		    while ( v69 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v67 + 36190], v69 | (1LL << v68), v69) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_VignetteMask = (String *)"VIGNETTE_MASK";
		  if ( dword_18F35FD08 )
		  {
		    v70 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_VignetteMask >> 12) & 0x1FFFFF) >> 6;
		    v71 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_VignetteMask >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v70 + 36190]);
		    do
		      v72 = qword_18F0BCBA0[v70 + 36190];
		    while ( v72 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v70 + 36190], v72 | (1LL << v71), v72) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_DirtyLens = (String *)"DIRTY_LENS";
		  if ( dword_18F35FD08 )
		  {
		    v73 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_DirtyLens >> 12) & 0x1FFFFF) >> 6;
		    v74 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_DirtyLens >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v73 + 36190]);
		    do
		      v75 = qword_18F0BCBA0[v73 + 36190];
		    while ( v75 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v73 + 36190], v75 | (1LL << v74), v75) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_Bloom = (String *)"BLOOM";
		  if ( dword_18F35FD08 )
		  {
		    v76 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_Bloom >> 12) & 0x1FFFFF) >> 6;
		    v77 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_Bloom >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v76 + 36190]);
		    do
		      v78 = qword_18F0BCBA0[v76 + 36190];
		    while ( v78 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v76 + 36190], v78 | (1LL << v77), v78) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_BloomDirt = (String *)"BLOOM_DIRT";
		  if ( dword_18F35FD08 )
		  {
		    v79 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_BloomDirt >> 12) & 0x1FFFFF) >> 6;
		    v80 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_BloomDirt >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v79 + 36190]);
		    do
		      v81 = qword_18F0BCBA0[v79 + 36190];
		    while ( v81 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v79 + 36190], v81 | (1LL << v80), v81) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_LightShaftCloudMask = (String *)"LIGHT_SHAFT_CLOUD_MASK";
		  if ( dword_18F35FD08 )
		  {
		    v82 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_LightShaftCloudMask >> 12) & 0x1FFFFF) >> 6;
		    v83 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_LightShaftCloudMask >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v82 + 36190]);
		    do
		      v84 = qword_18F0BCBA0[v82 + 36190];
		    while ( v84 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v82 + 36190], v84 | (1LL << v83), v84) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_RadialBlur = (String *)"RADIAL_BLUR";
		  if ( dword_18F35FD08 )
		  {
		    v85 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_RadialBlur >> 12) & 0x1FFFFF) >> 6;
		    v86 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_RadialBlur >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v85 + 36190]);
		    do
		      v87 = qword_18F0BCBA0[v85 + 36190];
		    while ( v87 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v85 + 36190], v87 | (1LL << v86), v87) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_RadialBlurWithChromaticAberration = (String *)"RADIAL_BLUR_CHROMATIC_ABERRATION";
		  if ( dword_18F35FD08 )
		  {
		    v88 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_RadialBlurWithChromaticAberration >> 12) & 0x1FFFFF) >> 6;
		    v89 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_RadialBlurWithChromaticAberration >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v88 + 36190]);
		    do
		      v90 = qword_18F0BCBA0[v88 + 36190];
		    while ( v90 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v88 + 36190], v90 | (1LL << v89), v90) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_UseScanLine = (String *)"VFX_SCANLINE";
		  if ( dword_18F35FD08 )
		  {
		    v91 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_UseScanLine >> 12) & 0x1FFFFF) >> 6;
		    v92 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_UseScanLine >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v91 + 36190]);
		    do
		      v93 = qword_18F0BCBA0[v91 + 36190];
		    while ( v93 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v91 + 36190], v93 | (1LL << v92), v93) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_UseBlackBox = (String *)"BLACK_BOX";
		  if ( dword_18F35FD08 )
		  {
		    v94 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_UseBlackBox >> 12) & 0x1FFFFF) >> 6;
		    v95 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_UseBlackBox >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v94 + 36190]);
		    do
		      v96 = qword_18F0BCBA0[v94 + 36190];
		    while ( v96 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v94 + 36190], v96 | (1LL << v95), v96) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_ScanLineUseMask = (String *)"SCANLINE_USE_MASK";
		  if ( dword_18F35FD08 )
		  {
		    v97 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_ScanLineUseMask >> 12) & 0x1FFFFF) >> 6;
		    v98 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_ScanLineUseMask >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v97 + 36190]);
		    do
		      v99 = qword_18F0BCBA0[v97 + 36190];
		    while ( v99 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v97 + 36190], v99 | (1LL << v98), v99) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_BWMaskTex = (String *)"BWMASKTEX";
		  if ( dword_18F35FD08 )
		  {
		    v100 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_BWMaskTex >> 12) & 0x1FFFFF) >> 6;
		    v101 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_BWMaskTex >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v100 + 36190]);
		    do
		      v102 = qword_18F0BCBA0[v100 + 36190];
		    while ( v102 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v100 + 36190], v102 | (1LL << v101), v102) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_BWFlashTex = (String *)"BWFLASHTEX";
		  if ( dword_18F35FD08 )
		  {
		    v103 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_BWFlashTex >> 12) & 0x1FFFFF) >> 6;
		    v104 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_BWFlashTex >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v103 + 36190]);
		    do
		      v105 = qword_18F0BCBA0[v103 + 36190];
		    while ( v105 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v103 + 36190], v105 | (1LL << v104), v105) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_ApplyLUT = (String *)"APPLY_LUT";
		  if ( dword_18F35FD08 )
		  {
		    v106 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_ApplyLUT >> 12) & 0x1FFFFF) >> 6;
		    v107 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_ApplyLUT >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v106 + 36190]);
		    do
		      v108 = qword_18F0BCBA0[v106 + 36190];
		    while ( v108 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v106 + 36190], v108 | (1LL << v107), v108) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_UserLUT = (String *)"USER_LUT";
		  if ( dword_18F35FD08 )
		  {
		    v109 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_UserLUT >> 12) & 0x1FFFFF) >> 6;
		    v110 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_UserLUT >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v109 + 36190]);
		    do
		      v111 = qword_18F0BCBA0[v109 + 36190];
		    while ( v111 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v109 + 36190], v111 | (1LL << v110), v111) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_MeteringCenter = (String *)"METERING_CENTER";
		  if ( dword_18F35FD08 )
		  {
		    v112 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_MeteringCenter >> 12) & 0x1FFFFF) >> 6;
		    v113 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_MeteringCenter >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v112 + 36190]);
		    do
		      v114 = qword_18F0BCBA0[v112 + 36190];
		    while ( v114 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v112 + 36190], v114 | (1LL << v113), v114) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_PerformSharpen = (String *)"PERFORM_SHARPEN";
		  if ( dword_18F35FD08 )
		  {
		    v115 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_PerformSharpen >> 12) & 0x1FFFFF) >> 6;
		    v116 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_PerformSharpen >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v115 + 36190]);
		    do
		      v117 = qword_18F0BCBA0[v115 + 36190];
		    while ( v117 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v115 + 36190], v117 | (1LL << v116), v117) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_TaauPerformanceMode = (String *)"HG_TAAU_PERFORMANCE_MODE";
		  if ( dword_18F35FD08 )
		  {
		    v118 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_TaauPerformanceMode >> 12) & 0x1FFFFF) >> 6;
		    v119 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_TaauPerformanceMode >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v118 + 36190]);
		    do
		      v120 = qword_18F0BCBA0[v118 + 36190];
		    while ( v120 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v118 + 36190], v120 | (1LL << v119), v120) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_TaauNextgenMode = (String *)"HG_TAAU_NEXTGEN_MODE";
		  if ( dword_18F35FD08 )
		  {
		    v121 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_TaauNextgenMode >> 12) & 0x1FFFFF) >> 6;
		    v122 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_TaauNextgenMode >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v121 + 36190]);
		    do
		      v123 = qword_18F0BCBA0[v121 + 36190];
		    while ( v123 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v121 + 36190], v123 | (1LL << v122), v123) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_EnableHierarchicalZOcclusionCulling = (String *)"ENABLE_HIZ_CULLING";
		  if ( dword_18F35FD08 )
		  {
		    v124 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_EnableHierarchicalZOcclusionCulling >> 12) & 0x1FFFFF) >> 6;
		    v125 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_EnableHierarchicalZOcclusionCulling >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v124 + 36190]);
		    do
		      v126 = qword_18F0BCBA0[v124 + 36190];
		    while ( v126 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v124 + 36190], v126 | (1LL << v125), v126) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_WorldUIKeyword = (String *)"HG_WORLD_UI";
		  if ( dword_18F35FD08 )
		  {
		    v127 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_WorldUIKeyword >> 12) & 0x1FFFFF) >> 6;
		    v128 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_WorldUIKeyword >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v127 + 36190]);
		    do
		      v129 = qword_18F0BCBA0[v127 + 36190];
		    while ( v129 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v127 + 36190], v129 | (1LL << v128), v129) );
		  }
		  v130 = il2cpp_array_new_specific_1(TypeInfo::System::String, 5LL);
		  v133 = (String__Array *)v130;
		  if ( !v130 )
		    goto LABEL_260;
		  sub_180005370(v130, 0LL, "DOF_KERNEL_RADIUS_4");
		  sub_180005370(v133, 1LL, "DOF_KERNEL_RADIUS_6");
		  sub_180005370(v133, 2LL, "DOF_KERNEL_RADIUS_8");
		  sub_180005370(v133, 3LL, "DOF_KERNEL_RADIUS_12");
		  sub_180005370(v133, 4LL, "DOF_KERNEL_RADIUS_16");
		  v134 = dword_18F35FD08 == 0;
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_DoFKernelRadiusKeywords = v133;
		  if ( !v134 )
		  {
		    v135 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_DoFKernelRadiusKeywords >> 12) & 0x1FFFFF) >> 6;
		    v136 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_DoFKernelRadiusKeywords >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v135 + 36190]);
		    do
		      v137 = qword_18F0BCBA0[v135 + 36190];
		    while ( v137 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v135 + 36190], v137 | (1LL << v136), v137) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_DebugFullScreen = (String *)"DEBUG_FULLSCREEN";
		  if ( dword_18F35FD08 )
		  {
		    v138 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_DebugFullScreen >> 12) & 0x1FFFFF) >> 6;
		    v139 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_DebugFullScreen >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v138 + 36190]);
		    do
		      v140 = qword_18F0BCBA0[v138 + 36190];
		    while ( v140 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v138 + 36190], v140 | (1LL << v139), v140) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_DebugFullScreenPreDepth = (String *)"DEBUG_FULLSCREEN_PRE_DEPTH";
		  if ( dword_18F35FD08 )
		  {
		    v141 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_DebugFullScreenPreDepth >> 12) & 0x1FFFFF) >> 6;
		    v142 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_DebugFullScreenPreDepth >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v141 + 36190]);
		    do
		      v143 = qword_18F0BCBA0[v141 + 36190];
		    while ( v143 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v141 + 36190], v143 | (1LL << v142), v143) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_DebugRegular = (String *)"DEBUG_REGULAR";
		  if ( dword_18F35FD08 )
		  {
		    v144 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_DebugRegular >> 12) & 0x1FFFFF) >> 6;
		    v145 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_DebugRegular >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v144 + 36190]);
		    do
		      v146 = qword_18F0BCBA0[v144 + 36190];
		    while ( v146 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v144 + 36190], v146 | (1LL << v145), v146) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_UseAutoExposureHistogram = (String *)"USE_AUTO_EXPOSURE_HISTOGRAM";
		  if ( dword_18F35FD08 )
		  {
		    v147 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_UseAutoExposureHistogram >> 12) & 0x1FFFFF) >> 6;
		    v148 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_UseAutoExposureHistogram >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v147 + 36190]);
		    do
		      v149 = qword_18F0BCBA0[v147 + 36190];
		    while ( v149 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v147 + 36190], v149 | (1LL << v148), v149) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_EnableFoliageOccluderMask = (String *)"ENABLE_FOLIAGE_OCCLUDER_MASK";
		  if ( dword_18F35FD08 )
		  {
		    v150 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_EnableFoliageOccluderMask >> 12) & 0x1FFFFF) >> 6;
		    v151 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_EnableFoliageOccluderMask >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v150 + 36190]);
		    do
		      v152 = qword_18F0BCBA0[v150 + 36190];
		    while ( v152 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v150 + 36190], v152 | (1LL << v151), v152) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_HighQualityMultiScatteringApproxEnabled = (String *)"HIGHQUALITY_MULTISCATTERING_APPROX_ENABLED";
		  if ( dword_18F35FD08 )
		  {
		    v153 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_HighQualityMultiScatteringApproxEnabled >> 12) & 0x1FFFFF) >> 6;
		    v154 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_HighQualityMultiScatteringApproxEnabled >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v153 + 36190]);
		    do
		      v155 = qword_18F0BCBA0[v153 + 36190];
		    while ( v155 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v153 + 36190], v155 | (1LL << v154), v155) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->SUNDISC_HQ = (String *)"SKYBOX_SUNDISK_HQ";
		  if ( dword_18F35FD08 )
		  {
		    v156 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->SUNDISC_HQ >> 12) & 0x1FFFFF) >> 6;
		    v157 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->SUNDISC_HQ >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v156 + 36190]);
		    do
		      v158 = qword_18F0BCBA0[v156 + 36190];
		    while ( v158 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v156 + 36190], v158 | (1LL << v157), v158) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->HG_SKYBOX_STAR = (String *)"HG_SKYBOX_STAR";
		  if ( dword_18F35FD08 )
		  {
		    v159 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->HG_SKYBOX_STAR >> 12) & 0x1FFFFF) >> 6;
		    v160 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->HG_SKYBOX_STAR >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v159 + 36190]);
		    do
		      v161 = qword_18F0BCBA0[v159 + 36190];
		    while ( v161 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v159 + 36190], v161 | (1LL << v160), v161) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->HG_SKYBOX_NEBULA = (String *)"HG_SKYBOX_NEBULA";
		  if ( dword_18F35FD08 )
		  {
		    v162 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->HG_SKYBOX_NEBULA >> 12) & 0x1FFFFF) >> 6;
		    v163 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->HG_SKYBOX_NEBULA >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v162 + 36190]);
		    do
		      v164 = qword_18F0BCBA0[v162 + 36190];
		    while ( v164 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v162 + 36190], v164 | (1LL << v163), v164) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_Ring = (String *)"HG_RING";
		  if ( dword_18F35FD08 )
		  {
		    v165 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_Ring >> 12) & 0x1FFFFF) >> 6;
		    v166 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_Ring >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v165 + 36190]);
		    do
		      v167 = qword_18F0BCBA0[v165 + 36190];
		    while ( v167 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v165 + 36190], v167 | (1LL << v166), v167) );
		  }
		  v168 = il2cpp_array_new_specific_1(TypeInfo::System::String, 2LL);
		  v169 = (String__Array *)v168;
		  if ( !v168 )
		    goto LABEL_260;
		  sub_180005370(v168, 0LL, "DRAW_PLANET_RING");
		  sub_180005370(v169, 1LL, "DRAW_TALOS_RING");
		  v134 = dword_18F35FD08 == 0;
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_DrawPlanetsRing = v169;
		  if ( !v134 )
		  {
		    v170 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_DrawPlanetsRing >> 12) & 0x1FFFFF) >> 6;
		    v171 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_DrawPlanetsRing >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v170 + 36190]);
		    do
		      v172 = qword_18F0BCBA0[v170 + 36190];
		    while ( v172 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v170 + 36190], v172 | (1LL << v171), v172) );
		  }
		  v173 = il2cpp_array_new_specific_1(TypeInfo::System::String, 2LL);
		  v174 = v173;
		  if ( !v173 )
		LABEL_260:
		    sub_1800D8250(v132, v131);
		  sub_180005370(v173, 0LL, "DRAW_PLANET_ATMOSPHERE");
		  sub_180005370(v174, 1LL, "DRAW_TALOS_ATMOSPHERE");
		  v134 = dword_18F35FD08 == 0;
		  static_fields = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields;
		  *(_QWORD *)(static_fields + 504) = v174;
		  if ( !v134 )
		  {
		    v175 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_DrawPlanetsAtmosphere >> 12) & 0x1FFFFF) >> 6;
		    static_fields = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_DrawPlanetsAtmosphere >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v175 + 36190]);
		    do
		      v178 = qword_18F0BCBA0[v175 + 36190];
		    while ( v178 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v175 + 36190], v178 | (1LL << static_fields), v178) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->CLOUDS_FLOWMAP = (String *)"_CLOUDS_FLOWMAP";
		  if ( dword_18F35FD08 )
		  {
		    v175 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->CLOUDS_FLOWMAP >> 12) & 0x1FFFFF) >> 6;
		    static_fields = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->CLOUDS_FLOWMAP >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v175 + 36190]);
		    do
		      v179 = qword_18F0BCBA0[v175 + 36190];
		    while ( v179 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v175 + 36190], v179 | (1LL << static_fields), v179) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->ENABLE_CLOUDS_SHADOW = (String *)"_ENABLE_CLOUDS_SHADOW";
		  if ( dword_18F35FD08 )
		  {
		    v175 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->ENABLE_CLOUDS_SHADOW >> 12) & 0x1FFFFF) >> 6;
		    static_fields = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->ENABLE_CLOUDS_SHADOW >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v175 + 36190]);
		    do
		      v180 = qword_18F0BCBA0[v175 + 36190];
		    while ( v180 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v175 + 36190], v180 | (1LL << static_fields), v180) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->DRAW_ADVANCED_PLANET = (String *)"DRAW_ADVANCED_PLANET";
		  if ( dword_18F35FD08 )
		  {
		    v175 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->DRAW_ADVANCED_PLANET >> 12) & 0x1FFFFF) >> 6;
		    static_fields = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->DRAW_ADVANCED_PLANET >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v175 + 36190]);
		    do
		      v181 = qword_18F0BCBA0[v175 + 36190];
		    while ( v181 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v175 + 36190], v181 | (1LL << static_fields), v181) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->DRAW_ADVANCED_PLANET_CLOUDS_FLOWMAP = (String *)"DRAW_ADVANCED_PLANET_CLOUDS_FLOWMAP";
		  if ( dword_18F35FD08 )
		  {
		    v175 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->DRAW_ADVANCED_PLANET_CLOUDS_FLOWMAP >> 12) & 0x1FFFFF) >> 6;
		    static_fields = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->DRAW_ADVANCED_PLANET_CLOUDS_FLOWMAP >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v175 + 36190]);
		    do
		      v182 = qword_18F0BCBA0[v175 + 36190];
		    while ( v182 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v175 + 36190], v182 | (1LL << static_fields), v182) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->DRAW_ADVANCED_PLANET_CLOUDS_SHADOW = (String *)"DRAW_ADVANCED_PLANET_CLOUDS_SHADOW";
		  if ( dword_18F35FD08 )
		  {
		    v175 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->DRAW_ADVANCED_PLANET_CLOUDS_SHADOW >> 12) & 0x1FFFFF) >> 6;
		    static_fields = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->DRAW_ADVANCED_PLANET_CLOUDS_SHADOW >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v175 + 36190]);
		    do
		      v183 = qword_18F0BCBA0[v175 + 36190];
		    while ( v183 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v175 + 36190], v183 | (1LL << static_fields), v183) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_Cloud = (String *)"HG_CLOUD";
		  if ( dword_18F35FD08 )
		  {
		    v175 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_Cloud >> 12) & 0x1FFFFF) >> 6;
		    static_fields = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_Cloud >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v175 + 36190]);
		    do
		      v184 = qword_18F0BCBA0[v175 + 36190];
		    while ( v184 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v175 + 36190], v184 | (1LL << static_fields), v184) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_CloudFlowMap = (String *)"HG_CLOUD_FLOWMAP";
		  if ( dword_18F35FD08 )
		  {
		    v175 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_CloudFlowMap >> 12) & 0x1FFFFF) >> 6;
		    static_fields = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_CloudFlowMap >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v175 + 36190]);
		    do
		      v185 = qword_18F0BCBA0[v175 + 36190];
		    while ( v185 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v175 + 36190], v185 | (1LL << static_fields), v185) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_CloudProceduralFlow = (String *)"HG_CLOUD_PROCEDRURALFLOW";
		  if ( dword_18F35FD08 )
		  {
		    v175 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_CloudProceduralFlow >> 12) & 0x1FFFFF) >> 6;
		    static_fields = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_CloudProceduralFlow >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v175 + 36190]);
		    do
		      v186 = qword_18F0BCBA0[v175 + 36190];
		    while ( v186 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v175 + 36190], v186 | (1LL << static_fields), v186) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_GTAOUseFP32Depths = (String *)"GTAO_USE_FP32_DEPTHS";
		  if ( dword_18F35FD08 )
		  {
		    v175 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_GTAOUseFP32Depths >> 12) & 0x1FFFFF) >> 6;
		    static_fields = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_GTAOUseFP32Depths >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v175 + 36190]);
		    do
		      v187 = qword_18F0BCBA0[v175 + 36190];
		    while ( v187 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v175 + 36190], v187 | (1LL << static_fields), v187) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_GTAOBentNormals = (String *)"GTAO_BENT_NORMALS";
		  if ( dword_18F35FD08 )
		  {
		    v175 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_GTAOBentNormals >> 12) & 0x1FFFFF) >> 6;
		    static_fields = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_GTAOBentNormals >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v175 + 36190]);
		    do
		      v188 = qword_18F0BCBA0[v175 + 36190];
		    while ( v188 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v175 + 36190], v188 | (1LL << static_fields), v188) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_GTAOGenerateNormalsInplace = (String *)"GTAO_GENERATE_NORMALS_INPLACE";
		  if ( dword_18F35FD08 )
		  {
		    v175 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_GTAOGenerateNormalsInplace >> 12) & 0x1FFFFF) >> 6;
		    static_fields = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_GTAOGenerateNormalsInplace >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v175 + 36190]);
		    do
		      v189 = qword_18F0BCBA0[v175 + 36190];
		    while ( v189 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v175 + 36190], v189 | (1LL << static_fields), v189) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_SSRImportanceSample = (String *)"SSR_IMPORTANCE_SAMPLE";
		  if ( dword_18F35FD08 )
		  {
		    v175 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_SSRImportanceSample >> 12) & 0x1FFFFF) >> 6;
		    static_fields = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_SSRImportanceSample >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v175 + 36190]);
		    do
		      v190 = qword_18F0BCBA0[v175 + 36190];
		    while ( v190 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v175 + 36190], v190 | (1LL << static_fields), v190) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_SceneColorAdjustMentEnableSaturation = (String *)"ENABLE_SATURATION";
		  if ( dword_18F35FD08 )
		  {
		    v175 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_SceneColorAdjustMentEnableSaturation >> 12) & 0x1FFFFF) >> 6;
		    static_fields = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_SceneColorAdjustMentEnableSaturation >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v175 + 36190]);
		    do
		      v191 = qword_18F0BCBA0[v175 + 36190];
		    while ( v191 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v175 + 36190], v191 | (1LL << static_fields), v191) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_FakeGlint = (String *)"_FAKEGLINT";
		  if ( dword_18F35FD08 )
		  {
		    v175 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_FakeGlint >> 12) & 0x1FFFFF) >> 6;
		    static_fields = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_FakeGlint >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v175 + 36190]);
		    do
		      v192 = qword_18F0BCBA0[v175 + 36190];
		    while ( v192 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v175 + 36190], v192 | (1LL << static_fields), v192) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_SubsurfaceProfile = (String *)"_SUBSURFACE_PROFILE";
		  if ( dword_18F35FD08 )
		  {
		    v175 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_SubsurfaceProfile >> 12) & 0x1FFFFF) >> 6;
		    static_fields = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_SubsurfaceProfile >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v175 + 36190]);
		    do
		      v193 = qword_18F0BCBA0[v175 + 36190];
		    while ( v193 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v175 + 36190], v193 | (1LL << static_fields), v193) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_FakeVolume = (String *)"_FAKE_VOLUME";
		  if ( dword_18F35FD08 )
		  {
		    v175 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_FakeVolume >> 12) & 0x1FFFFF) >> 6;
		    static_fields = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_FakeVolume >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v175 + 36190]);
		    do
		      v194 = qword_18F0BCBA0[v175 + 36190];
		    while ( v194 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v175 + 36190], v194 | (1LL << static_fields), v194) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_FakeCrackCSM = (String *)"_FAKE_CRACK_CSM";
		  if ( dword_18F35FD08 )
		  {
		    v175 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_FakeCrackCSM >> 12) & 0x1FFFFF) >> 6;
		    static_fields = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_FakeCrackCSM >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v175 + 36190]);
		    do
		      v195 = qword_18F0BCBA0[v175 + 36190];
		    while ( v195 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v175 + 36190], v195 | (1LL << static_fields), v195) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_FakeShadow = (String *)"_FAKE_SHADOW";
		  if ( dword_18F35FD08 )
		  {
		    v175 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_FakeShadow >> 12) & 0x1FFFFF) >> 6;
		    static_fields = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_FakeShadow >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v175 + 36190]);
		    do
		      v196 = qword_18F0BCBA0[v175 + 36190];
		    while ( v196 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v175 + 36190], v196 | (1LL << static_fields), v196) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_DisableTerrainContactShadow = (String *)"_DISABLE_TERRAIN_CONTACT_SHADOW";
		  if ( dword_18F35FD08 )
		  {
		    v175 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_DisableTerrainContactShadow >> 12) & 0x1FFFFF) >> 6;
		    static_fields = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_DisableTerrainContactShadow >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v175 + 36190]);
		    do
		      v197 = qword_18F0BCBA0[v175 + 36190];
		    while ( v197 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v175 + 36190], v197 | (1LL << static_fields), v197) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_HasTerrainLayerTypeData = (String *)"_HAS_TERRAIN_LAYER_TYPE_DATA";
		  if ( dword_18F35FD08 )
		  {
		    v175 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_HasTerrainLayerTypeData >> 12) & 0x1FFFFF) >> 6;
		    static_fields = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_HasTerrainLayerTypeData >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v175 + 36190]);
		    do
		      v198 = qword_18F0BCBA0[v175 + 36190];
		    while ( v198 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v175 + 36190], v198 | (1LL << static_fields), v198) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_InteractionUseCCD = (String *)"_INTERACTION_USE_CCD";
		  if ( dword_18F35FD08 )
		  {
		    v175 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_InteractionUseCCD >> 12) & 0x1FFFFF) >> 6;
		    static_fields = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_InteractionUseCCD >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v175 + 36190]);
		    do
		      v199 = qword_18F0BCBA0[v175 + 36190];
		    while ( v199 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v175 + 36190], v199 | (1LL << static_fields), v199) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_SubsurfaceProfileSimple = (String *)"_SUBSURFACE_PROFILE_SIMPLE";
		  if ( dword_18F35FD08 )
		  {
		    v175 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_SubsurfaceProfileSimple >> 12) & 0x1FFFFF) >> 6;
		    static_fields = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_SubsurfaceProfileSimple >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v175 + 36190]);
		    do
		      v200 = qword_18F0BCBA0[v175 + 36190];
		    while ( v200 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v175 + 36190], v200 | (1LL << static_fields), v200) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_MipLevelCount1 = (String *)"_MIP_LEVEL_COUNT_1";
		  if ( dword_18F35FD08 )
		  {
		    v175 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_MipLevelCount1 >> 12) & 0x1FFFFF) >> 6;
		    static_fields = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_MipLevelCount1 >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v175 + 36190]);
		    do
		      v201 = qword_18F0BCBA0[v175 + 36190];
		    while ( v201 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v175 + 36190], v201 | (1LL << static_fields), v201) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_MipLevelCount2 = (String *)"_MIP_LEVEL_COUNT_2";
		  if ( dword_18F35FD08 )
		  {
		    v175 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_MipLevelCount2 >> 12) & 0x1FFFFF) >> 6;
		    static_fields = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_MipLevelCount2 >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v175 + 36190]);
		    do
		      v202 = qword_18F0BCBA0[v175 + 36190];
		    while ( v202 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v175 + 36190], v202 | (1LL << static_fields), v202) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_MipLevelCount3 = (String *)"_MIP_LEVEL_COUNT_3";
		  if ( dword_18F35FD08 )
		  {
		    v175 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_MipLevelCount3 >> 12) & 0x1FFFFF) >> 6;
		    static_fields = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_MipLevelCount3 >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v175 + 36190]);
		    do
		      v203 = qword_18F0BCBA0[v175 + 36190];
		    while ( v203 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v175 + 36190], v203 | (1LL << static_fields), v203) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_MipLevelCount4 = (String *)"_MIP_LEVEL_COUNT_4";
		  if ( dword_18F35FD08 )
		  {
		    v175 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_MipLevelCount4 >> 12) & 0x1FFFFF) >> 6;
		    static_fields = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_MipLevelCount4 >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v175 + 36190]);
		    do
		      v204 = qword_18F0BCBA0[v175 + 36190];
		    while ( v204 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v175 + 36190], v204 | (1LL << static_fields), v204) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_FetchFromLastMip = (String *)"_FETCH_FROM_LAST_MIP";
		  if ( dword_18F35FD08 )
		  {
		    v175 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_FetchFromLastMip >> 12) & 0x1FFFFF) >> 6;
		    static_fields = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_FetchFromLastMip >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v175 + 36190]);
		    do
		      v205 = qword_18F0BCBA0[v175 + 36190];
		    while ( v205 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v175 + 36190], v205 | (1LL << static_fields), v205) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_GPUDrivenDebugNoCulling = (String *)"GPUDRIVEN_DEBUG_NO_CULLING";
		  if ( dword_18F35FD08 )
		  {
		    v175 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_GPUDrivenDebugNoCulling >> 12) & 0x1FFFFF) >> 6;
		    static_fields = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_GPUDrivenDebugNoCulling >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v175 + 36190]);
		    do
		      v206 = qword_18F0BCBA0[v175 + 36190];
		    while ( v206 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v175 + 36190], v206 | (1LL << static_fields), v206) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_GPUDrivenDisableHZBCulling = (String *)"GPUDRIVEN_DISABLE_HZB_CULLING";
		  if ( dword_18F35FD08 )
		  {
		    v175 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_GPUDrivenDisableHZBCulling >> 12) & 0x1FFFFF) >> 6;
		    static_fields = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_GPUDrivenDisableHZBCulling >> 12) & 0x3F;
		    _m_prefetchw(&qword_18F0BCBA0[v175 + 36190]);
		    do
		      v207 = qword_18F0BCBA0[v175 + 36190];
		    while ( v207 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v175 + 36190], v207 | (1LL << static_fields), v207) );
		  }
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_GPUDrivenV1 = (String *)"GPUDRIVEN_V1";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_GPUDrivenV1,
		    (HGRuntimeGrassQuery_Node *)static_fields,
		    (HGRuntimeGrassQuery_Node *)v175,
		    v176,
		    (MethodInfo *)v211.m_Name);
		  v208 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords;
		  TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_GPUDrivenV2 = (String *)"GPUDRIVEN_V2";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_GPUDrivenV2,
		    v209,
		    v210,
		    v208,
		    v212);
		}
		
	}
}
