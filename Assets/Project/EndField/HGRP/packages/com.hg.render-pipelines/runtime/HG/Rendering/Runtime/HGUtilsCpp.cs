using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.HyperGryphEngineCode;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGUtilsCpp // TypeDefIndex: 38573
	{
		// Constructors
		public HGUtilsCpp() {} // 0x00000001841E1670-0x00000001841E1680
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
		
	
		// Methods
		public static unsafe HGSettingParametersCpp* ConvertSettingParamsToCpp(HGSettingParameters settingParameters) => default; // 0x000000018350F810-0x0000000183516280
		// HGSettingParametersCpp* ConvertSettingParamsToCpp(HGSettingParameters)
		HGSettingParametersCpp *HG::Rendering::Runtime::HGUtilsCpp::ConvertSettingParamsToCpp(
		        HGSettingParameters *settingParameters,
		        MethodInfo *method)
		{
		  __int64 (__fastcall *v2)(__int64, MethodInfo *); // rax
		  __int64 v4; // rsi
		  void (__fastcall *v5)(__int64, _QWORD, __int64); // rax
		  __int64 v6; // rdx
		  HGVolumetricFogRenderer__StaticFields *s_settingParameters; // rcx
		  SettingParameter_1_System_Single_ *cullingViewScreenSizeMin_k__BackingField; // rbx
		  struct MethodInfo *v9; // rbp
		  Il2CppClass *klass; // rax
		  SettingParameter_1_System_Single_ *ocScreenSizeMin_k__BackingField; // rbp
		  struct MethodInfo *v12; // rbx
		  Il2CppClass *v13; // rax
		  SettingParameter_1_System_Boolean_ *taauEnable_k__BackingField; // rbp
		  struct MethodInfo *v15; // rbx
		  Il2CppClass *v16; // rax
		  SettingParameter_1_TAAUQuality_ *taauQuality_k__BackingField; // rax
		  SettingParameter_1_System_Single_ *historyWeight_k__BackingField; // rbp
		  struct MethodInfo *v19; // rbx
		  Il2CppClass *v20; // rax
		  SettingParameter_1_System_Single_ *historyWeightInMotion_k__BackingField; // rbp
		  struct MethodInfo *v22; // rbx
		  Il2CppClass *v23; // rax
		  SettingParameter_1_System_Single_ *fastConvergeHistoryWeight_k__BackingField; // rbp
		  struct MethodInfo *v25; // rbx
		  Il2CppClass *v26; // rax
		  SettingParameter_1_System_Single_ *responsiveAAWeight_k__BackingField; // rbp
		  struct MethodInfo *v28; // rbx
		  Il2CppClass *v29; // rax
		  SettingParameter_1_System_Single_ *minMotion_k__BackingField; // rbp
		  struct MethodInfo *v31; // rbx
		  Il2CppClass *v32; // rax
		  SettingParameter_1_System_Single_ *maxMotion_k__BackingField; // rbp
		  struct MethodInfo *v34; // rbx
		  Il2CppClass *v35; // rax
		  SettingParameter_1_System_Single_ *characterMotionSensitivity_k__BackingField; // rbp
		  struct MethodInfo *v37; // rbx
		  Il2CppClass *v38; // rax
		  SettingParameter_1_System_Single_ *occlusionDepthDiff_k__BackingField; // rbp
		  struct MethodInfo *v40; // rbx
		  Il2CppClass *v41; // rax
		  SettingParameter_1_System_Single_ *inputLumaWeight_k__BackingField; // rbp
		  struct MethodInfo *v43; // rbx
		  Il2CppClass *v44; // rax
		  SettingParameter_1_System_Single_ *sharpenStrength1K_k__BackingField; // rbp
		  struct MethodInfo *v46; // rbx
		  Il2CppClass *v47; // rax
		  SettingParameter_1_System_Single_ *sharpenStrength2K_k__BackingField; // rbp
		  struct MethodInfo *v49; // rbx
		  Il2CppClass *v50; // rax
		  SettingParameter_1_System_Single_ *sharpenStrength4K_k__BackingField; // rbp
		  struct MethodInfo *v52; // rbx
		  Il2CppClass *v53; // rax
		  SettingParameter_1_System_Boolean_ *pssrEnable_k__BackingField; // rbp
		  struct MethodInfo *v55; // rbx
		  Il2CppClass *v56; // rax
		  SettingParameter_1_System_Single_ *pssrSharpness_k__BackingField; // rbp
		  struct MethodInfo *v58; // rbx
		  Il2CppClass *v59; // rax
		  SettingParameter_1_System_Boolean_ *dlssEnable_k__BackingField; // rbp
		  struct MethodInfo *v61; // rbx
		  Il2CppClass *v62; // rax
		  SettingParameter_1_UnityEngine_HyperGryphEngineCode_DLSSQuality_ *dlssQuality_k__BackingField; // rbp
		  struct MethodInfo *v64; // rbx
		  Il2CppClass *v65; // rax
		  SettingParameter_1_System_Boolean_ *dlssUseAutoExposure_k__BackingField; // rbp
		  struct MethodInfo *v67; // rbx
		  Il2CppClass *v68; // rax
		  SettingParameter_1_UnityEngine_HyperGryphEngineCode_StreamlineDLSSFGMode_ *dlssGMode_k__BackingField; // rbp
		  struct MethodInfo *v70; // rbx
		  Il2CppClass *v71; // rax
		  SettingParameter_1_System_Int32_ *dlssGGenFrames_k__BackingField; // rax
		  SettingParameter_1_UnityEngine_HyperGryphEngineCode_StreamlineReflexMode_ *dlssReflexMode_k__BackingField; // rbp
		  struct MethodInfo *v74; // rbx
		  Il2CppClass *v75; // rax
		  SettingParameter_1_System_Boolean_ *dlssPCLEnable_k__BackingField; // rbp
		  struct MethodInfo *v77; // rbx
		  Il2CppClass *v78; // rax
		  SettingParameter_1_System_Single_ *dlssSharpenStrength_k__BackingField; // rbp
		  struct MethodInfo *v80; // rbx
		  Il2CppClass *v81; // rax
		  SettingParameter_1_System_Boolean_ *dlssUseUIHint_k__BackingField; // rbp
		  struct MethodInfo *v83; // rbx
		  Il2CppClass *v84; // rax
		  SettingParameter_1_System_Single_ *dlssUIHintAlphaThreshold_k__BackingField; // rbp
		  struct MethodInfo *v86; // rbx
		  Il2CppClass *v87; // rax
		  SettingParameter_1_UnityEngine_HyperGryphEngineCode_DLSSModel_ *dlssModel_k__BackingField; // rbp
		  struct MethodInfo *v89; // rbx
		  Il2CppClass *v90; // rax
		  SettingParameter_1_System_Boolean_ *fsr3Enable_k__BackingField; // rbp
		  struct MethodInfo *v92; // rbx
		  Il2CppClass *v93; // rax
		  SettingParameter_1_System_Boolean_ *fsr3UseReaciveAndTCMask_k__BackingField; // rbp
		  struct MethodInfo *v95; // rbx
		  Il2CppClass *v96; // rax
		  SettingParameter_1_UnityEngine_HyperGryphEngineCode_FSR3Quality_ *fsr3Quality_k__BackingField; // rbp
		  struct MethodInfo *v98; // rbx
		  Il2CppClass *v99; // rax
		  SettingParameter_1_System_Single_ *fsr3SharpenStrength_k__BackingField; // rbp
		  struct MethodInfo *v101; // rbx
		  Il2CppClass *v102; // rax
		  SettingParameter_1_System_Boolean_ *fsr3UseFP16_k__BackingField; // rbp
		  struct MethodInfo *v104; // rbx
		  Il2CppClass *v105; // rax
		  SettingParameter_1_System_Boolean_ *fsr3UseWave_k__BackingField; // rbp
		  struct MethodInfo *v107; // rbx
		  Il2CppClass *v108; // rax
		  SettingParameter_1_System_Boolean_ *fsr3UseWave64_k__BackingField; // rbp
		  struct MethodInfo *v110; // rbx
		  Il2CppClass *v111; // rax
		  SettingParameter_1_System_Boolean_ *fsr3UseLanczosLut_k__BackingField; // rbp
		  struct MethodInfo *v113; // rbx
		  Il2CppClass *v114; // rax
		  SettingParameter_1_System_Boolean_ *fsr3FIEnable_k__BackingField; // rbp
		  struct MethodInfo *v116; // rbx
		  Il2CppClass *v117; // rax
		  SettingParameter_1_UnityEngine_HyperGryphEngineCode_BloomQuality_ *bloomQuality_k__BackingField; // rax
		  SettingParameter_1_System_Boolean_ *bloomUseComputeShader_k__BackingField; // rbp
		  struct MethodInfo *v120; // rbx
		  Il2CppClass *v121; // rax
		  SettingParameter_1_System_Int32_ *lutSize_k__BackingField; // rbp
		  struct MethodInfo *v123; // rbx
		  Il2CppClass *v124; // rax
		  SettingParameter_1_UnityEngine_Experimental_Rendering_GraphicsFormat_ *lutFormat_k__BackingField; // rbp
		  struct MethodInfo *v126; // rbx
		  Il2CppClass *v127; // rax
		  SettingParameter_1_UnityEngine_Experimental_Rendering_GraphicsFormat_ *ppBufferFormat_k__BackingField; // rbp
		  struct MethodInfo *v129; // rbx
		  Il2CppClass *v130; // rax
		  SettingParameter_1_UnityEngine_Experimental_Rendering_GraphicsFormat_ *uiPPBufferFormat_k__BackingField; // rbp
		  struct MethodInfo *v132; // rbx
		  Il2CppClass *v133; // rax
		  SettingParameter_1_System_Boolean_ *frostedGlassUseComputeShader_k__BackingField; // rbp
		  struct MethodInfo *v135; // rbx
		  Il2CppClass *v136; // rax
		  SettingParameter_1_HGDepthOfFieldQuality_ *depthOfFieldQuality_k__BackingField; // rax
		  SettingParameter_1_System_Single_ *depthOfFieldMaxRadius_k__BackingField; // rbp
		  struct MethodInfo *v139; // rbx
		  Il2CppClass *v140; // rax
		  SettingParameter_1_System_Boolean_ *depthOfFieldScaleAdjust_k__BackingField; // rbp
		  struct MethodInfo *v142; // rbx
		  Il2CppClass *v143; // rax
		  SettingParameter_1_System_Single_ *depthOfFieldScaleAdjustThreshold_k__BackingField; // rbp
		  struct MethodInfo *v145; // rbx
		  Il2CppClass *v146; // rax
		  SettingParameter_1_System_Boolean_ *motionBlurEnable_k__BackingField; // rbp
		  struct MethodInfo *v148; // rbx
		  Il2CppClass *v149; // rax
		  SettingParameter_1_System_Boolean_ *bloomEnabled_k__BackingField; // rbp
		  struct MethodInfo *v151; // rbx
		  Il2CppClass *v152; // rax
		  SettingParameter_1_System_Boolean_ *vignetteEnabled_k__BackingField; // rbp
		  struct MethodInfo *v154; // rbx
		  Il2CppClass *v155; // rax
		  SettingParameter_1_System_Boolean_ *radialBlurEnabled_k__BackingField; // rbp
		  struct MethodInfo *v157; // rbx
		  Il2CppClass *v158; // rax
		  SettingParameter_1_System_Boolean_ *chromaticAberrationEnabled_k__BackingField; // rbp
		  struct MethodInfo *v160; // rbx
		  Il2CppClass *v161; // rax
		  SettingParameter_1_System_Boolean_ *dirtyLensEnabled_k__BackingField; // rbp
		  struct MethodInfo *v163; // rbx
		  Il2CppClass *v164; // rax
		  SettingParameter_1_System_Boolean_ *sharpenEnabled_k__BackingField; // rbp
		  struct MethodInfo *v166; // rbx
		  Il2CppClass *v167; // rax
		  SettingParameter_1_System_Boolean_ *frostedGlassEnabled_k__BackingField; // rbp
		  struct MethodInfo *v169; // rbx
		  Il2CppClass *v170; // rax
		  SettingParameter_1_System_Boolean_ *cutsceneEffectEnabled_k__BackingField; // rbp
		  struct MethodInfo *v172; // rbx
		  Il2CppClass *v173; // rax
		  SettingParameter_1_System_Boolean_ *fisheyeEffectEnabled_k__BackingField; // rbp
		  struct MethodInfo *v175; // rbx
		  Il2CppClass *v176; // rax
		  SettingParameter_1_System_Boolean_ *lensFlareEnabled_k__BackingField; // rbp
		  struct MethodInfo *v178; // rbx
		  Il2CppClass *v179; // rax
		  SettingParameter_1_System_Int32_ *punctualLightMaxCount_k__BackingField; // rbp
		  struct MethodInfo *v181; // rbx
		  Il2CppClass *v182; // rax
		  SettingParameter_1_System_Boolean_ *enableShadowProxy_k__BackingField; // rbp
		  struct MethodInfo *v184; // rbx
		  Il2CppClass *v185; // rax
		  SettingParameter_1_UnityEngine_Rendering_DepthBits_ *shadowDepthBits_k__BackingField; // rax
		  SettingParameter_1_System_Boolean_ *enableScreenSpaceShadowMask_k__BackingField; // rbp
		  struct MethodInfo *v188; // rbx
		  Il2CppClass *v189; // rax
		  SettingParameter_1_System_Boolean_ *csmEnabled_k__BackingField; // rbp
		  struct MethodInfo *v191; // rbx
		  Il2CppClass *v192; // rax
		  SettingParameter_1_System_Int32_ *csmShadowMapTileResolution_k__BackingField; // rbp
		  struct MethodInfo *v194; // rbx
		  Il2CppClass *v195; // rax
		  SettingParameter_1_System_Single_ *csmMaxDistance_k__BackingField; // rbp
		  struct MethodInfo *v197; // rbx
		  Il2CppClass *v198; // rax
		  SettingParameter_1_System_Single_ *csmFadeInnerDistance_k__BackingField; // rbp
		  struct MethodInfo *v200; // rbx
		  Il2CppClass *v201; // rax
		  SettingParameter_1_System_Int32_ *csmSplitCount_k__BackingField; // rbp
		  struct MethodInfo *v203; // rbx
		  Il2CppClass *v204; // rax
		  SettingParameter_1_System_Single_ *csmSplit0_k__BackingField; // rbp
		  struct MethodInfo *v206; // rbx
		  Il2CppClass *v207; // rax
		  SettingParameter_1_System_Single_ *csmSplit1_k__BackingField; // rbp
		  struct MethodInfo *v209; // rbx
		  Il2CppClass *v210; // rax
		  SettingParameter_1_System_Single_ *csmSplit2_k__BackingField; // rbp
		  struct MethodInfo *v212; // rbx
		  Il2CppClass *v213; // rax
		  SettingParameter_1_System_Single_ *csmSplit3_k__BackingField; // rbp
		  struct MethodInfo *v215; // rbx
		  Il2CppClass *v216; // rax
		  SettingParameter_1_System_Boolean_ *csmUseShadowmapCache_k__BackingField; // rbp
		  struct MethodInfo *v218; // rbx
		  Il2CppClass *v219; // rax
		  SettingParameter_1_System_Int32_ *csmCachedFrame0_k__BackingField; // rbp
		  struct MethodInfo *v221; // rbx
		  Il2CppClass *v222; // rax
		  SettingParameter_1_System_Int32_ *csmCachedFrame1_k__BackingField; // rbp
		  struct MethodInfo *v224; // rbx
		  Il2CppClass *v225; // rax
		  SettingParameter_1_System_Int32_ *csmCachedFrame2_k__BackingField; // rbp
		  struct MethodInfo *v227; // rbx
		  Il2CppClass *v228; // rax
		  SettingParameter_1_System_Int32_ *csmCachedFrame3_k__BackingField; // rbp
		  struct MethodInfo *v230; // rbx
		  Il2CppClass *v231; // rax
		  SettingParameter_1_System_Single_ *csmScreenSizeMin0_k__BackingField; // rbp
		  struct MethodInfo *v233; // rbx
		  Il2CppClass *v234; // rax
		  SettingParameter_1_System_Single_ *csmScreenSizeMin1_k__BackingField; // rbp
		  struct MethodInfo *v236; // rbx
		  Il2CppClass *v237; // rax
		  SettingParameter_1_System_Single_ *csmScreenSizeMin2_k__BackingField; // rbp
		  struct MethodInfo *v239; // rbx
		  Il2CppClass *v240; // rax
		  SettingParameter_1_System_Single_ *csmScreenSizeMin3_k__BackingField; // rbp
		  struct MethodInfo *v242; // rbx
		  Il2CppClass *v243; // rax
		  SettingParameter_1_System_Boolean_ *csmEnableOcclusionCulling0_k__BackingField; // rbp
		  struct MethodInfo *v245; // rbx
		  Il2CppClass *v246; // rax
		  SettingParameter_1_System_Boolean_ *csmEnableOcclusionCulling1_k__BackingField; // rbp
		  struct MethodInfo *v248; // rbx
		  Il2CppClass *v249; // rax
		  SettingParameter_1_System_Boolean_ *csmEnableOcclusionCulling2_k__BackingField; // rbp
		  struct MethodInfo *v251; // rbx
		  Il2CppClass *v252; // rax
		  SettingParameter_1_System_Boolean_ *csmEnableOcclusionCulling3_k__BackingField; // rbp
		  struct MethodInfo *v254; // rbx
		  Il2CppClass *v255; // rax
		  SettingParameter_1_System_Int32_ *csmOcclusionDepthSize_k__BackingField; // rbp
		  struct MethodInfo *v257; // rbx
		  Il2CppClass *v258; // rax
		  SettingParameter_1_System_Int32_ *csmStopRenderCharacterCascade_k__BackingField; // rbp
		  struct MethodInfo *v260; // rbx
		  Il2CppClass *v261; // rax
		  SettingParameter_1_System_Single_ *csmNearPlaneOffset_k__BackingField; // rbp
		  struct MethodInfo *v263; // rbx
		  Il2CppClass *v264; // rax
		  SettingParameter_1_System_Single_ *csmHardwareBias_k__BackingField; // rbp
		  struct MethodInfo *v266; // rbx
		  Il2CppClass *v267; // rax
		  SettingParameter_1_System_Single_ *csmHardwareNormalBias_k__BackingField; // rbp
		  struct MethodInfo *v269; // rbx
		  Il2CppClass *v270; // rax
		  SettingParameter_1_System_Boolean_ *characterShadowEnabled_k__BackingField; // rbp
		  struct MethodInfo *v272; // rbx
		  Il2CppClass *v273; // rax
		  SettingParameter_1_System_Int32_ *characterShadowMapResolution_k__BackingField; // rbp
		  struct MethodInfo *v275; // rbx
		  Il2CppClass *v276; // rax
		  SettingParameter_1_System_Single_ *characterShadowHardwareBias_k__BackingField; // rbp
		  struct MethodInfo *v278; // rbx
		  Il2CppClass *v279; // rax
		  SettingParameter_1_System_Single_ *characterShadowHardwareNormalBias_k__BackingField; // rbp
		  struct MethodInfo *v281; // rbx
		  Il2CppClass *v282; // rax
		  SettingParameter_1_System_Single_ *characterShadowShaderBias_k__BackingField; // rbp
		  struct MethodInfo *v284; // rbx
		  Il2CppClass *v285; // rax
		  SettingParameter_1_System_Single_ *characterShadowShaderNormalBias_k__BackingField; // rbp
		  struct MethodInfo *v287; // rbx
		  Il2CppClass *v288; // rax
		  SettingParameter_1_System_Boolean_ *punctualLightShadowEnabled_k__BackingField; // rbp
		  struct MethodInfo *v290; // rbx
		  Il2CppClass *v291; // rax
		  SettingParameter_1_System_Int32_ *punctualLightTileMaxSize_k__BackingField; // rbp
		  struct MethodInfo *v293; // rbx
		  Il2CppClass *v294; // rax
		  SettingParameter_1_System_Single_ *punctualLightForceCullDistance_k__BackingField; // rbp
		  struct MethodInfo *v296; // rbx
		  Il2CppClass *v297; // rax
		  SettingParameter_1_System_Int32_ *punctualLightEnvDynamicCasterCount_k__BackingField; // rbp
		  struct MethodInfo *v299; // rbx
		  Il2CppClass *v300; // rax
		  SettingParameter_1_System_Int32_ *punctualLightMovableDynamicCasterCount_k__BackingField; // rbp
		  struct MethodInfo *v302; // rbx
		  Il2CppClass *v303; // rax
		  SettingParameter_1_System_Single_ *punctualLightShadowScreenSizeMin_k__BackingField; // rbp
		  struct MethodInfo *v305; // rbx
		  Il2CppClass *v306; // rax
		  SettingParameter_1_System_Boolean_ *hdplsCharacterShadowEnabled_k__BackingField; // rbp
		  struct MethodInfo *v308; // rbx
		  Il2CppClass *v309; // rax
		  SettingParameter_1_System_Int32_ *hdplsAtlasHeight_k__BackingField; // rbp
		  struct MethodInfo *v311; // rbx
		  Il2CppClass *v312; // rax
		  SettingParameter_1_System_Boolean_ *hdplsScreenSpaceReduceResolution_k__BackingField; // rbp
		  struct MethodInfo *v314; // rbx
		  Il2CppClass *v315; // rax
		  SettingParameter_1_System_Single_ *hdplsDepthBias_k__BackingField; // rbp
		  struct MethodInfo *v317; // rbx
		  Il2CppClass *v318; // rax
		  SettingParameter_1_System_Single_ *hdplsNormalBias_k__BackingField; // rbp
		  struct MethodInfo *v320; // rbx
		  Il2CppClass *v321; // rax
		  SettingParameter_1_System_Single_ *hdplsSoftness_k__BackingField; // rbp
		  struct MethodInfo *v323; // rbx
		  Il2CppClass *v324; // rax
		  SettingParameter_1_System_Boolean_ *asmEnabled_k__BackingField; // rbp
		  struct MethodInfo *v326; // rbx
		  Il2CppClass *v327; // rax
		  SettingParameter_1_System_Int32_ *asmShadowMapTileResolution_k__BackingField; // rbp
		  struct MethodInfo *v329; // rbx
		  Il2CppClass *v330; // rax
		  SettingParameter_1_System_Single_ *asmMaxDistance_k__BackingField; // rbp
		  struct MethodInfo *v332; // rbx
		  Il2CppClass *v333; // rax
		  SettingParameter_1_System_Int32_ *asmMaxTileRenderCountPerFrame_k__BackingField; // rbp
		  struct MethodInfo *v335; // rbx
		  Il2CppClass *v336; // rax
		  SettingParameter_1_System_Single_ *asmDepthBias_k__BackingField; // rbp
		  struct MethodInfo *v338; // rbx
		  Il2CppClass *v339; // rax
		  SettingParameter_1_System_Single_ *asmNormalBias_k__BackingField; // rbp
		  struct MethodInfo *v341; // rbx
		  Il2CppClass *v342; // rax
		  SettingParameter_1_System_Single_ *asmScreenSizeMin_k__BackingField; // rbp
		  struct MethodInfo *v344; // rbx
		  Il2CppClass *v345; // rax
		  SettingParameter_1_System_Boolean_ *shadowDecalProjectorEnabled_k__BackingField; // rbp
		  struct MethodInfo *v347; // rbx
		  Il2CppClass *v348; // rax
		  SettingParameter_1_System_Int32_ *shadowDecalProjectorMaxCount_k__BackingField; // rbp
		  struct MethodInfo *v350; // rbx
		  Il2CppClass *v351; // rax
		  SettingParameter_1_System_Boolean_ *transientGBuffer_k__BackingField; // rbp
		  struct MethodInfo *v353; // rbx
		  Il2CppClass *v354; // rax
		  SettingParameter_1_UnityEngine_Rendering_DepthBits_ *depthBitsGBuffer_k__BackingField; // rax
		  SettingParameter_1_System_Boolean_ *depthCombinedWithStencil_k__BackingField; // rbp
		  struct MethodInfo *v357; // rbx
		  Il2CppClass *v358; // rax
		  SettingParameter_1_System_Single_ *copySceneRTScale_k__BackingField; // rbp
		  struct MethodInfo *v360; // rbx
		  Il2CppClass *v361; // rax
		  SettingParameter_1_System_Int32_ *taauResolveResolutionHeight_k__BackingField; // rbp
		  struct MethodInfo *v363; // rbx
		  Il2CppClass *v364; // rax
		  Il2CppClass *v365; // rcx
		  SettingParameter_1_System_Int32_ *backBufferResolutionHeight_k__BackingField; // rbp
		  struct MethodInfo *v367; // rbx
		  Il2CppClass *v368; // rax
		  SettingParameter_1_System_Boolean_ *textureStreamingEnable_k__BackingField; // rbp
		  struct MethodInfo *v370; // rbx
		  Il2CppClass *v371; // rax
		  SettingParameter_1_System_Int32_ *textureStreamingBudget_k__BackingField; // rbp
		  struct MethodInfo *v373; // rbx
		  Il2CppClass *v374; // rax
		  SettingParameter_1_System_Int32_ *textureStreamingMaxBudget_k__BackingField; // rbp
		  struct MethodInfo *v376; // rbx
		  Il2CppClass *v377; // rax
		  SettingParameter_1_System_Int32_ *reservedMemoryForNonTextureStreaming_k__BackingField; // rbp
		  struct MethodInfo *v379; // rbx
		  Il2CppClass *v380; // rax
		  SettingParameter_1_System_Single_ *textureStreamingMobileBudgetPercent_k__BackingField; // rbp
		  struct MethodInfo *v382; // rbx
		  Il2CppClass *v383; // rax
		  SettingParameter_1_System_Int32_ *textureStreamingRendererPerFrame_k__BackingField; // rbp
		  struct MethodInfo *v385; // rbx
		  Il2CppClass *v386; // rax
		  SettingParameter_1_System_Int32_ *textureStreamingMaxFileIORequests_k__BackingField; // rbp
		  struct MethodInfo *v388; // rbx
		  Il2CppClass *v389; // rax
		  SettingParameter_1_System_Boolean_ *contactShadowEnableParam_k__BackingField; // rbp
		  struct MethodInfo *v391; // rbx
		  Il2CppClass *v392; // rax
		  SettingParameter_1_System_Boolean_ *gtaoEnable_k__BackingField; // rbp
		  struct MethodInfo *v394; // rbx
		  Il2CppClass *v395; // rax
		  SettingParameter_1_System_Int32_ *gtaoQualityLevel_k__BackingField; // rbp
		  struct MethodInfo *v397; // rbx
		  Il2CppClass *v398; // rax
		  SettingParameter_1_System_Boolean_ *ssrEnable_k__BackingField; // rbp
		  struct MethodInfo *v400; // rbx
		  Il2CppClass *v401; // rax
		  SettingParameter_1_System_Int32_ *ssrRayMarchingSampleCount_k__BackingField; // rbp
		  struct MethodInfo *v403; // rbx
		  Il2CppClass *v404; // rax
		  SettingParameter_1_System_Boolean_ *ssrImportanceSample_k__BackingField; // rbp
		  struct MethodInfo *v406; // rbx
		  Il2CppClass *v407; // rax
		  SettingParameter_1_System_Boolean_ *ssrV2_k__BackingField; // rbp
		  struct MethodInfo *v409; // rbx
		  Il2CppClass *v410; // rax
		  SettingParameter_1_System_Boolean_ *ssrV2Upsample_k__BackingField; // rbp
		  struct MethodInfo *v412; // rbx
		  Il2CppClass *v413; // rax
		  SettingParameter_1_System_Boolean_ *terrainFallbackGBuffer_k__BackingField; // rbp
		  struct MethodInfo *v415; // rbx
		  Il2CppClass *v416; // rax
		  SettingParameter_1_System_Int32_ *terrainLODFactor_k__BackingField; // rbp
		  struct MethodInfo *v418; // rbx
		  Il2CppClass *v419; // rax
		  SettingParameter_1_System_Boolean_ *terrainPOM_k__BackingField; // rbp
		  struct MethodInfo *v421; // rbx
		  Il2CppClass *v422; // rax
		  HGTerrainDeformSettingParameters *terrainDeform_k__BackingField; // rax
		  SettingParameter_1_System_Boolean_ *Enable_k__BackingField; // rbx
		  struct MethodInfo *v425; // rbp
		  Il2CppClass *v426; // rax
		  HGTerrainDeformSettingParameters *v427; // rax
		  SettingParameter_1_System_Int32_ *SubdMode_k__BackingField; // rbx
		  struct MethodInfo *v429; // rbp
		  Il2CppClass *v430; // rax
		  HGTerrainDeformSettingParameters *v431; // rax
		  SettingParameter_1_System_Int32_ *SubdModeV2_k__BackingField; // rbx
		  struct MethodInfo *v433; // rbp
		  Il2CppClass *v434; // rax
		  HGTerrainDeformSettingParameters *v435; // rax
		  SettingParameter_1_System_Int32_ *GpuSubd_k__BackingField; // rbx
		  struct MethodInfo *v437; // rbp
		  Il2CppClass *v438; // rax
		  HGTerrainDeformSettingParameters *v439; // rax
		  SettingParameter_1_System_Int32_ *PrimitivePixelLengthTargetLog2_k__BackingField; // rbx
		  struct MethodInfo *v441; // rbp
		  Il2CppClass *v442; // rax
		  HGErosionBlendSettingParameters *erosionBlend_k__BackingField; // rax
		  SettingParameter_1_System_Boolean_ *v444; // rbx
		  struct MethodInfo *v445; // rbp
		  Il2CppClass *v446; // rax
		  HGLightShaftSettingParameters *lightShaft_k__BackingField; // rax
		  SettingParameter_1_System_Boolean_ *enableLightShaft; // rbx
		  struct MethodInfo *v449; // rbp
		  Il2CppClass *v450; // rax
		  HGLightShaftSettingParameters *v451; // rax
		  SettingParameter_1_System_Int32_ *lightShaftSampleNum; // rbx
		  struct MethodInfo *v453; // rbp
		  Il2CppClass *v454; // rax
		  HGLightShaftSettingParameters *v455; // rax
		  SettingParameter_1_System_Single_ *lightShaftDownSampleFactor; // rbx
		  struct MethodInfo *v457; // rbp
		  Il2CppClass *v458; // rax
		  HGLightShaftSettingParameters *v459; // rax
		  SettingParameter_1_System_Int32_ *lightShaftBlurPassCount; // rbp
		  struct MethodInfo *v461; // rbx
		  Il2CppClass *v462; // rax
		  SettingParameter_1_System_Boolean_ *enableAnamorphicStreaks_k__BackingField; // rbp
		  struct MethodInfo *v464; // rbx
		  Il2CppClass *v465; // rax
		  SettingParameter_1_System_Single_ *anamorphicStreaksDownSampleFactor_k__BackingField; // rbp
		  struct MethodInfo *v467; // rbx
		  Il2CppClass *v468; // rax
		  HGRainAndWetnessSettingParameters *rainAndWetness_k__BackingField; // rax
		  SettingParameter_1_System_Boolean_ *EnableRainWetnessHighQuality_k__BackingField; // rbx
		  struct MethodInfo *v471; // rbp
		  Il2CppClass *v472; // rax
		  HGRainAndWetnessSettingParameters *v473; // rax
		  SettingParameter_1_System_Int32_ *RainOcclusionMapSize_k__BackingField; // rbx
		  struct MethodInfo *v475; // rbp
		  Il2CppClass *v476; // rax
		  HGRainAndWetnessSettingParameters *v477; // rax
		  SettingParameter_1_System_Int32_ *RainOcclusionMapOverrideRange_k__BackingField; // rbx
		  struct MethodInfo *v479; // rbp
		  Il2CppClass *v480; // rax
		  HGRainAndWetnessSettingParameters *v481; // rax
		  SettingParameter_1_System_Boolean_ *RainSplashEnabled_k__BackingField; // rbx
		  struct MethodInfo *v483; // rbp
		  Il2CppClass *v484; // rax
		  HGRainAndWetnessSettingParameters *v485; // rax
		  SettingParameter_1_System_Int32_ *RainSplashMaxCount_k__BackingField; // rbx
		  struct MethodInfo *v487; // rbp
		  Il2CppClass *v488; // rax
		  HGRainAndWetnessSettingParameters *v489; // rax
		  SettingParameter_1_System_Single_ *ScreenRainDropPercent_k__BackingField; // rbx
		  struct MethodInfo *v491; // rbp
		  Il2CppClass *v492; // rax
		  HGRainAndWetnessSettingParameters *v493; // rax
		  SettingParameter_1_System_Boolean_ *EnableMiddleDistRain_k__BackingField; // rbx
		  struct MethodInfo *v495; // rbp
		  Il2CppClass *v496; // rax
		  HGRainAndWetnessSettingParameters *v497; // rax
		  SettingParameter_1_System_Boolean_ *EnableRainWave_k__BackingField; // rbx
		  struct MethodInfo *v499; // rbp
		  Il2CppClass *v500; // rax
		  HGRainAndWetnessSettingParameters *v501; // rax
		  SettingParameter_1_System_Boolean_ *EnableRainLighting_k__BackingField; // rbx
		  struct MethodInfo *v503; // rbp
		  Il2CppClass *v504; // rax
		  HGRainAndWetnessSettingParameters *v505; // rax
		  SettingParameter_1_System_Int32_ *SceneEffectRainLayerCount_k__BackingField; // rbx
		  struct MethodInfo *v507; // rbp
		  Il2CppClass *v508; // rax
		  HGSnowSettingParameters *snow_k__BackingField; // rax
		  SettingParameter_1_System_Boolean_ *EnableSnowLighting_k__BackingField; // rbx
		  struct MethodInfo *v511; // rbp
		  Il2CppClass *v512; // rax
		  HGSnowSettingParameters *v513; // rax
		  SettingParameter_1_System_Int32_ *SnowLayerCount_k__BackingField; // rbx
		  struct MethodInfo *v515; // rbp
		  Il2CppClass *v516; // rax
		  HGSnowSettingParameters *v517; // rax
		  SettingParameter_1_System_Boolean_ *EnableSnowCollision_k__BackingField; // rbx
		  struct MethodInfo *v519; // rbp
		  Il2CppClass *v520; // rax
		  HGVerticalOcclusionMapSettingParameters *verticalOcclusionMap_k__BackingField; // rax
		  SettingParameter_1_System_Int32_ *DepthOcclusionMapSize_k__BackingField; // rbx
		  struct MethodInfo *v523; // rbp
		  Il2CppClass *v524; // rax
		  HGVerticalOcclusionMapSettingParameters *v525; // rax
		  SettingParameter_1_System_Int32_ *DepthOcclusionMapRange_k__BackingField; // rbp
		  struct MethodInfo *v527; // rbx
		  Il2CppClass *v528; // rax
		  HGAtmosphereSettingParameters *atmosphereParams_k__BackingField; // rax
		  SettingParameter_1_System_Single_ *transmittanceLutSampleCount; // rbp
		  struct MethodInfo *v531; // rbx
		  Il2CppClass *v532; // rax
		  HGAtmosphereSettingParameters *v533; // rax
		  SettingParameter_1_System_Int32_ *transmittanceLutWidth; // rbx
		  struct MethodInfo *v535; // rbp
		  Il2CppClass *v536; // rax
		  HGAtmosphereSettingParameters *v537; // rax
		  SettingParameter_1_System_Int32_ *transmittanceLutHeight; // rbx
		  struct MethodInfo *v539; // rbp
		  Il2CppClass *v540; // rax
		  HGAtmosphereSettingParameters *v541; // rax
		  SettingParameter_1_System_Single_ *multiScatteredLuminanceLutSampleCount; // rbx
		  struct MethodInfo *v543; // rbp
		  Il2CppClass *v544; // rax
		  HGAtmosphereSettingParameters *v545; // rax
		  SettingParameter_1_System_Boolean_ *multiScatteredLuminanceLutHighQuality; // rbx
		  struct MethodInfo *v547; // rbp
		  Il2CppClass *v548; // rax
		  HGAtmosphereSettingParameters *v549; // rax
		  SettingParameter_1_System_Int32_ *multiScatteredLuminanceLutWidth; // rbx
		  struct MethodInfo *v551; // rbp
		  Il2CppClass *v552; // rax
		  HGAtmosphereSettingParameters *v553; // rax
		  SettingParameter_1_System_Int32_ *multiScatteredLuminanceLutHeight; // rbx
		  struct MethodInfo *v555; // rbp
		  Il2CppClass *v556; // rax
		  HGAtmosphereSettingParameters *v557; // rax
		  SettingParameter_1_System_Single_ *skyViewLutSampleCountMin; // rbx
		  struct MethodInfo *v559; // rbp
		  Il2CppClass *v560; // rax
		  HGAtmosphereSettingParameters *v561; // rax
		  SettingParameter_1_System_Single_ *skyViewLutSampleCountMax; // rbx
		  struct MethodInfo *v563; // rbp
		  Il2CppClass *v564; // rax
		  HGAtmosphereSettingParameters *v565; // rax
		  SettingParameter_1_System_Single_ *skyViewLutDistanceToSampleCountMax; // rbx
		  struct MethodInfo *v567; // rbp
		  Il2CppClass *v568; // rax
		  HGAtmosphereSettingParameters *v569; // rax
		  SettingParameter_1_System_Int32_ *skyViewLutWidth; // rbx
		  struct MethodInfo *v571; // rbp
		  Il2CppClass *v572; // rax
		  HGAtmosphereSettingParameters *v573; // rax
		  SettingParameter_1_System_Int32_ *skyViewLutHeight; // rbp
		  struct MethodInfo *v575; // rbx
		  Il2CppClass *v576; // rax
		  SettingParameter_1_System_Single_ *waterPrepassTextureSize_k__BackingField; // rbp
		  struct MethodInfo *v578; // rbx
		  Il2CppClass *v579; // rax
		  SettingParameter_1_System_Boolean_ *waterInteractiveEnable_k__BackingField; // rbp
		  struct MethodInfo *v581; // rbx
		  Il2CppClass *v582; // rax
		  SettingParameter_1_System_Boolean_ *waterIndirectEnable_k__BackingField; // rbp
		  struct MethodInfo *v584; // rbx
		  Il2CppClass *v585; // rax
		  SettingParameter_1_System_Int32_ *waterVRRx_k__BackingField; // rbp
		  struct MethodInfo *v587; // rbx
		  Il2CppClass *v588; // rax
		  SettingParameter_1_System_Int32_ *waterVRRy_k__BackingField; // rbp
		  struct MethodInfo *v590; // rbx
		  Il2CppClass *v591; // rax
		  SettingParameter_1_System_Single_ *waterDisplacementWeight_k__BackingField; // rbp
		  struct MethodInfo *v593; // rbx
		  Il2CppClass *v594; // rax
		  SettingParameter_1_System_Single_ *waterDisplacementDistance_k__BackingField; // rbp
		  struct MethodInfo *v596; // rbx
		  Il2CppClass *v597; // rax
		  SettingParameter_1_System_Int32_ *waterHeightTextureSize_k__BackingField; // rbp
		  struct MethodInfo *v599; // rbx
		  Il2CppClass *v600; // rax
		  SettingParameter_1_System_Single_ *artTagLODBiasAll_k__BackingField; // rbp
		  struct MethodInfo *v602; // rbx
		  Il2CppClass *v603; // rax
		  int32_t v604; // ebx
		  List_1_HG_Rendering_Runtime_SettingParameter_1_System_Single_ *artTagLODBias_k__BackingField; // rax
		  SettingParameter_1_System_Single___Array *items; // rax
		  SettingParameter_1_System_Single_ *v607; // r14
		  struct MethodInfo *v608; // rbp
		  Il2CppClass *v609; // rax
		  Il2CppClass *v610; // rcx
		  SettingParameter_1_System_Boolean_ *shouldSplitOnePass_k__BackingField; // rbp
		  struct MethodInfo *v612; // rbx
		  Il2CppClass *v613; // rax
		  Il2CppClass *v614; // rcx
		  struct HGVolumetricFogRenderer__Class *v615; // rax
		  HGVolumetricFogRenderer_HGVolumetricFogSettingParameters *v616; // rbp
		  struct MethodInfo *v617; // rbx
		  Il2CppClass *v618; // rax
		  Il2CppClass *v619; // rcx
		  SettingParameter_1_System_Int32_ *gridPixelSize; // rbp
		  struct MethodInfo *v621; // rbx
		  Il2CppClass *v622; // rax
		  Il2CppClass *v623; // rcx
		  SettingParameter_1_System_Int32_ *gridSizeZ; // rbp
		  struct MethodInfo *v625; // rbx
		  Il2CppClass *v626; // rax
		  Il2CppClass *v627; // rcx
		  SettingParameter_1_System_Int32_ *maxSourceRTWidth; // rbp
		  struct MethodInfo *v629; // rbx
		  Il2CppClass *v630; // rax
		  Il2CppClass *v631; // rcx
		  SettingParameter_1_System_Int32_ *maxSourceRTHeight; // rbp
		  struct MethodInfo *v633; // rbx
		  Il2CppClass *v634; // rax
		  Il2CppClass *v635; // rcx
		  SettingParameter_1_System_Int32_ *depthDistributionScale; // rbp
		  struct MethodInfo *v637; // rbx
		  Il2CppClass *v638; // rax
		  Il2CppClass *v639; // rcx
		  SettingParameter_1_System_Int32_ *historyMissSuperSampleCount; // rbp
		  struct MethodInfo *v641; // rbx
		  Il2CppClass *v642; // rax
		  Il2CppClass *v643; // rcx
		  SettingParameter_1_System_Single_ *fogHistoryWeight; // rbp
		  struct MethodInfo *v645; // rbx
		  Il2CppClass *v646; // rax
		  Il2CppClass *v647; // rcx
		  SettingParameter_1_System_Single_ *lightScatteringSampleJitterMultiplier; // rbp
		  struct MethodInfo *v649; // rbx
		  Il2CppClass *v650; // rax
		  Il2CppClass *v651; // rcx
		  SettingParameter_1_System_Single_ *upsampleJitterMultiplier; // rbp
		  struct MethodInfo *v653; // rbx
		  Il2CppClass *v654; // rax
		  Il2CppClass *v655; // rcx
		  SettingParameter_1_System_Boolean_ *enableTemporalReprojection; // rbp
		  struct MethodInfo *v657; // rbx
		  Il2CppClass *v658; // rax
		  Il2CppClass *v659; // rcx
		  SettingParameter_1_System_Boolean_ *enablePunctualLightShadow; // rbp
		  struct MethodInfo *v661; // rbx
		  Il2CppClass *v662; // rax
		  Il2CppClass *v663; // rcx
		  SettingParameter_1_System_Boolean_ *enableEmissiveVBufferB; // rbp
		  struct MethodInfo *v665; // rbx
		  Il2CppClass *v666; // rax
		  Il2CppClass *v667; // rcx
		  SettingParameter_1_System_Boolean_ *enableScalarizeDynamicLightLoop; // rbp
		  struct MethodInfo *v669; // rbx
		  Il2CppClass *v670; // rax
		  SettingParameter_1_System_Boolean_ *reflectionProbeUseRGBAHalf_k__BackingField; // rbp
		  struct MethodInfo *v672; // rbx
		  Il2CppClass *v673; // rax
		  SettingParameter_1_System_Int32_ *reflectionProbeOctTextureSize_k__BackingField; // rbp
		  struct MethodInfo *v675; // rbx
		  Il2CppClass *v676; // rax
		  SettingParameter_1_System_Int32_ *reflectionProbeMaxSampleMip_k__BackingField; // rbp
		  struct MethodInfo *v678; // rbx
		  Il2CppClass *v679; // rax
		  SettingParameter_1_System_Int32_ *reflectionProbeMaxBlitCountPerFrame_k__BackingField; // rbp
		  struct MethodInfo *v681; // rbx
		  Il2CppClass *v682; // rax
		  SettingParameter_1_System_Boolean_ *transparentLowResOffscreenEnable_k__BackingField; // rbp
		  struct MethodInfo *v684; // rbx
		  Il2CppClass *v685; // rax
		  SettingParameter_1_System_Boolean_ *transparentLowResVRSEnable_k__BackingField; // rbp
		  struct MethodInfo *v687; // rbx
		  Il2CppClass *v688; // rax
		  SettingParameter_1_System_Int32_ *transparentVRRx_k__BackingField; // rbp
		  struct MethodInfo *v690; // rbx
		  Il2CppClass *v691; // rax
		  SettingParameter_1_System_Int32_ *transparentVRRy_k__BackingField; // rbp
		  struct MethodInfo *v693; // rbx
		  Il2CppClass *v694; // rax
		  SettingParameter_1_System_Boolean_ *rayTracingReflectionEnable_k__BackingField; // rbp
		  struct MethodInfo *v696; // rbx
		  Il2CppClass *v697; // rax
		  SettingParameter_1_System_Int32_ *rayTracingReflectionMode_k__BackingField; // rbp
		  struct MethodInfo *v699; // rbx
		  Il2CppClass *v700; // rax
		  SettingParameter_1_System_Single_ *rayTracingReflectionSSQuality0_k__BackingField; // rbp
		  struct MethodInfo *v702; // rbx
		  Il2CppClass *v703; // rax
		  SettingParameter_1_System_Single_ *rayTracingReflectionSSQuality1_k__BackingField; // rbp
		  struct MethodInfo *v705; // rbx
		  Il2CppClass *v706; // rax
		  SettingParameter_1_System_Single_ *rayTracingReflectionSSQuality2_k__BackingField; // rbp
		  struct MethodInfo *v708; // rbx
		  Il2CppClass *v709; // rax
		  SettingParameter_1_System_Single_ *rayTracingReflectionSSQuality3_k__BackingField; // rbp
		  struct MethodInfo *v711; // rbx
		  Il2CppClass *v712; // rax
		  SettingParameter_1_System_Single_ *rayTracingReflectionRTQuality0_k__BackingField; // rbp
		  struct MethodInfo *v714; // rbx
		  Il2CppClass *v715; // rax
		  SettingParameter_1_System_Single_ *rayTracingReflectionRTQuality1_k__BackingField; // rbp
		  struct MethodInfo *v717; // rbx
		  Il2CppClass *v718; // rax
		  SettingParameter_1_System_Single_ *rayTracingReflectionRTQuality2_k__BackingField; // rbp
		  struct MethodInfo *v720; // rbx
		  Il2CppClass *v721; // rax
		  SettingParameter_1_System_Single_ *rayTracingReflectionRTQuality3_k__BackingField; // rbp
		  struct MethodInfo *v723; // rbx
		  Il2CppClass *v724; // rax
		  SettingParameter_1_System_Boolean_ *frameInterpolationEnable_k__BackingField; // rbp
		  struct MethodInfo *v726; // rbx
		  Il2CppClass *v727; // rax
		  SettingParameter_1_System_Boolean_ *frameInterpolationPause_k__BackingField; // rbp
		  struct MethodInfo *v729; // rbx
		  Il2CppClass *v730; // rax
		  SettingParameter_1_UnityEngine_HyperGryphEngineCode_FrameInterpolationAlgo_ *frameInterpolationAlgo_k__BackingField; // rbp
		  struct MethodInfo *v732; // rbx
		  Il2CppClass *v733; // rax
		  SettingParameter_1_System_Boolean_ *hasWorldUIAfterFrameInterpolation_k__BackingField; // rbp
		  struct MethodInfo *v735; // rbx
		  Il2CppClass *v736; // rax
		  SettingParameter_1_System_Single_ *afmeCameraRotationCosFallbackThreshold_k__BackingField; // rbp
		  struct MethodInfo *v738; // rbx
		  Il2CppClass *v739; // rax
		  SettingParameter_1_System_Single_ *afmeCameraMoveDistanceSqrFallbackThreshold_k__BackingField; // rbp
		  struct MethodInfo *v741; // rbx
		  Il2CppClass *v742; // rax
		  SettingParameter_1_System_Single_ *mfrcCameraRotationCosFallbackThreshold_k__BackingField; // rbp
		  struct MethodInfo *v744; // rbx
		  Il2CppClass *v745; // rax
		  SettingParameter_1_System_Single_ *mfrcCameraMoveDistanceSqrFallbackThreshold_k__BackingField; // rbp
		  struct MethodInfo *v747; // rbx
		  Il2CppClass *v748; // rax
		  SettingParameter_1_System_Single_ *mfrcGeneralFallbackThreshold_k__BackingField; // rbp
		  struct MethodInfo *v750; // rbx
		  Il2CppClass *v751; // rax
		  SettingParameter_1_System_Single_ *mfrcBrightnessDiffFallbackThreshold_k__BackingField; // rbp
		  struct MethodInfo *v753; // rbx
		  Il2CppClass *v754; // rax
		  SettingParameter_1_System_Single_ *mfrcRepeatedPatternFallbackThreshold_k__BackingField; // rbp
		  struct MethodInfo *v756; // rbx
		  Il2CppClass *v757; // rax
		  SettingParameter_1_System_Int32_ *inkSimulationResolution_k__BackingField; // rbp
		  struct MethodInfo *v759; // rbx
		  Il2CppClass *v760; // rax
		  SettingParameter_1_System_Int32_ *inkDensityResolution_k__BackingField; // rbp
		  struct MethodInfo *v762; // rbx
		  Il2CppClass *v763; // rax
		  SettingParameter_1_System_Boolean_ *inkSimulationEnable_k__BackingField; // rdi
		  struct MethodInfo *v765; // rbx
		  Il2CppClass *v766; // rax
		  Il2CppClass *v767; // rcx
		  __int64 v769; // rax
		  __int64 v770; // rax
		  __int64 v771; // rax
		  __int64 v772; // rax
		  __int64 v773; // rax
		  __int64 v774; // rax
		  __int64 v775; // rax
		  __int64 v776; // rax
		  __int64 v777; // rax
		  __int64 v778; // rax
		  __int64 v779; // rax
		  __int64 v780; // rax
		  __int64 v781; // rax
		  __int64 v782; // rax
		  __int64 v783; // rax
		  __int64 v784; // rax
		  __int64 v785; // rax
		  __int64 v786; // rax
		  __int64 v787; // rax
		  __int64 v788; // rax
		  __int64 v789; // rax
		  __int64 v790; // rax
		  __int64 v791; // rax
		  __int64 v792; // rax
		  __int64 v793; // rax
		  __int64 v794; // rax
		  __int64 v795; // rax
		  __int64 v796; // rax
		  __int64 v797; // rax
		  __int64 v798; // rax
		  __int64 v799; // rax
		  __int64 v800; // rax
		  __int64 v801; // rax
		  __int64 v802; // rax
		  __int64 v803; // rax
		  __int64 v804; // rax
		  __int64 v805; // rax
		  __int64 v806; // rax
		  __int64 v807; // rax
		  __int64 v808; // rax
		  __int64 v809; // rax
		  __int64 v810; // rax
		  __int64 v811; // rax
		  __int64 v812; // rax
		  __int64 v813; // rax
		  __int64 v814; // rax
		  __int64 v815; // rax
		  __int64 v816; // rax
		  __int64 v817; // rax
		  __int64 v818; // rax
		  __int64 v819; // rax
		  __int64 v820; // rax
		  __int64 v821; // rax
		  __int64 v822; // rax
		  __int64 v823; // rax
		  __int64 v824; // rax
		  __int64 v825; // rax
		  __int64 v826; // rax
		  __int64 v827; // rax
		  __int64 v828; // rax
		  __int64 v829; // rax
		  __int64 v830; // rax
		  __int64 v831; // rax
		  __int64 v832; // rax
		  __int64 v833; // rax
		  __int64 v834; // rax
		  __int64 v835; // rax
		  __int64 v836; // rax
		  __int64 v837; // rax
		  __int64 v838; // rax
		  __int64 v839; // rax
		  __int64 v840; // rax
		  __int64 v841; // rax
		  __int64 v842; // rax
		  __int64 v843; // rax
		  __int64 v844; // rax
		  __int64 v845; // rax
		  __int64 v846; // rax
		  __int64 v847; // rax
		  __int64 v848; // rax
		  __int64 v849; // rax
		  __int64 v850; // rax
		  __int64 v851; // rax
		  __int64 v852; // rax
		  __int64 v853; // rax
		  __int64 v854; // rax
		  __int64 v855; // rax
		  __int64 v856; // rax
		  __int64 v857; // rax
		  __int64 v858; // rax
		  __int64 v859; // rax
		  __int64 v860; // rax
		  __int64 v861; // rax
		  __int64 v862; // rax
		  __int64 v863; // rax
		  __int64 v864; // rax
		  __int64 v865; // rax
		  __int64 v866; // rax
		  __int64 v867; // rax
		  __int64 v868; // rax
		  __int64 v869; // rax
		  __int64 v870; // rax
		  __int64 v871; // rax
		  __int64 v872; // rax
		  __int64 v873; // rax
		  __int64 v874; // rax
		  __int64 v875; // rax
		  __int64 v876; // rax
		  __int64 v877; // rax
		  __int64 v878; // rax
		  __int64 v879; // rax
		  __int64 v880; // rax
		  __int64 v881; // rax
		  __int64 v882; // rax
		  __int64 v883; // rax
		  __int64 v884; // rax
		  __int64 v885; // rax
		  __int64 v886; // rax
		  __int64 v887; // rax
		  __int64 v888; // rax
		  __int64 v889; // rax
		  __int64 v890; // rax
		  __int64 v891; // rax
		  __int64 v892; // rax
		  __int64 v893; // rax
		  __int64 v894; // rax
		  __int64 v895; // rax
		  __int64 v896; // rax
		  __int64 v897; // rax
		  __int64 v898; // rax
		  __int64 v899; // rax
		  __int64 v900; // rax
		  __int64 v901; // rax
		  __int64 v902; // rax
		  __int64 v903; // rax
		  __int64 v904; // rax
		  __int64 v905; // rax
		  __int64 v906; // rax
		  __int64 v907; // rax
		  __int64 v908; // rax
		  __int64 v909; // rax
		  __int64 v910; // rax
		  __int64 v911; // rax
		  __int64 v912; // rax
		  __int64 v913; // rax
		  __int64 v914; // rax
		  __int64 v915; // rax
		  __int64 v916; // rax
		  __int64 v917; // rax
		  __int64 v918; // rax
		  __int64 v919; // rax
		  __int64 v920; // rax
		  __int64 v921; // rax
		  __int64 v922; // rax
		  __int64 v923; // rax
		  __int64 v924; // rax
		  __int64 v925; // rax
		  __int64 v926; // rax
		  __int64 v927; // rax
		  __int64 v928; // rax
		  __int64 v929; // rax
		  __int64 v930; // rax
		  __int64 v931; // rax
		  __int64 v932; // rax
		  __int64 v933; // rax
		  __int64 v934; // rax
		  __int64 v935; // rax
		  __int64 v936; // rax
		  __int64 v937; // rax
		  __int64 v938; // rax
		  __int64 v939; // rax
		  __int64 v940; // rax
		  __int64 v941; // rax
		  __int64 v942; // rax
		  __int64 v943; // rax
		  __int64 v944; // rax
		  __int64 v945; // rax
		  __int64 v946; // rax
		  __int64 v947; // rax
		  __int64 v948; // rax
		  __int64 v949; // rax
		  __int64 v950; // rax
		  __int64 v951; // rax
		  __int64 v952; // rax
		  __int64 v953; // rax
		  __int64 v954; // rax
		  __int64 v955; // rax
		  __int64 v956; // rax
		  __int64 v957; // rax
		  __int64 v958; // rax
		  __int64 v959; // rax
		  __int64 v960; // rax
		  __int64 v961; // rax
		  __int64 v962; // rax
		  __int64 v963; // rax
		  __int64 v964; // rax
		  __int64 v965; // rax
		  __int64 v966; // rax
		  __int64 v967; // rax
		  __int64 v968; // rax
		  __int64 v969; // rax
		  __int64 v970; // rax
		  __int64 v971; // rax
		  __int64 v972; // rax
		  __int64 v973; // rax
		  __int64 v974; // rax
		  __int64 v975; // rax
		  __int64 v976; // rax
		  __int64 v977; // rax
		  __int64 v978; // rax
		  __int64 v979; // rax
		  __int64 v980; // rax
		  __int64 v981; // rax
		  __int64 v982; // rax
		  __int64 v983; // rax
		  __int64 v984; // rax
		  __int64 v985; // rax
		  __int64 v986; // rax
		  __int64 v987; // rax
		  __int64 v988; // rax
		  __int64 v989; // rax
		  __int64 v990; // rax
		  __int64 v991; // rax
		  __int64 v992; // rax
		  __int64 v993; // rax
		  __int64 v994; // rax
		  __int64 v995; // rax
		  __int64 v996; // rax
		  __int64 v997; // rax
		  __int64 v998; // rax
		  __int64 v999; // rax
		  __int64 v1000; // rax
		  __int64 v1001; // rax
		  __int64 v1002; // rax
		
		  v2 = (__int64 (__fastcall *)(__int64, MethodInfo *))qword_18F370618;
		  if ( !qword_18F370618 )
		  {
		    v2 = (__int64 (__fastcall *)(__int64, MethodInfo *))il2cpp_resolve_icall_1(
		                                                          "UnityEngine.HyperGryphEngineCode.HGRenderGraphCPP::AllocateTem"
		                                                          "pFromCSharp(System.Int64)");
		    if ( !v2 )
		    {
		      v769 = sub_1802EE1B8("UnityEngine.HyperGryphEngineCode.HGRenderGraphCPP::AllocateTempFromCSharp(System.Int64)");
		      sub_18007E1B0(v769, 0LL);
		    }
		    qword_18F370618 = (__int64)v2;
		  }
		  v4 = v2(1092LL, method);
		  v5 = (void (__fastcall *)(__int64, _QWORD, __int64))qword_18F36EF38;
		  if ( !qword_18F36EF38 )
		  {
		    v5 = (void (__fastcall *)(__int64, _QWORD, __int64))il2cpp_resolve_icall_1(
		                                                          "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemSet(System"
		                                                          ".Void*,System.Byte,System.Int64)");
		    if ( !v5 )
		    {
		      v770 = sub_1802EE1B8("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemSet(System.Void*,System.Byte,System.Int64)");
		      sub_18007E1B0(v770, 0LL);
		    }
		    qword_18F36EF38 = (__int64)v5;
		  }
		  v5(v4, 0LL, 1092LL);
		  if ( !settingParameters )
		    goto LABEL_1698;
		  cullingViewScreenSizeMin_k__BackingField = settingParameters->fields._cullingViewScreenSizeMin_k__BackingField;
		  v9 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !cullingViewScreenSizeMin_k__BackingField )
		    goto LABEL_1698;
		  klass = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)klass->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)klass->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v771 = sub_18011C4C0(v9->klass);
		    (**(void (***)(void))(*(_QWORD *)(v771 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v9->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  if ( !v4 )
		    goto LABEL_1698;
		  *(float *)v4 = cullingViewScreenSizeMin_k__BackingField->fields._paramValue_k__BackingField;
		  ocScreenSizeMin_k__BackingField = settingParameters->fields._ocScreenSizeMin_k__BackingField;
		  v12 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !ocScreenSizeMin_k__BackingField )
		    goto LABEL_1698;
		  v13 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v13->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v13->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v772 = sub_18011C4C0(v12->klass);
		    (**(void (***)(void))(*(_QWORD *)(v772 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v12->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 4) = ocScreenSizeMin_k__BackingField->fields._paramValue_k__BackingField;
		  taauEnable_k__BackingField = settingParameters->fields._taauEnable_k__BackingField;
		  v15 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !taauEnable_k__BackingField )
		    goto LABEL_1698;
		  v16 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v16->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v16->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v773 = sub_18011C4C0(v15->klass);
		    (**(void (***)(void))(*(_QWORD *)(v773 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v15->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 8) = taauEnable_k__BackingField->fields._paramValue_k__BackingField;
		  taauQuality_k__BackingField = settingParameters->fields._taauQuality_k__BackingField;
		  if ( !taauQuality_k__BackingField )
		    goto LABEL_1698;
		  *(_DWORD *)(v4 + 12) = taauQuality_k__BackingField->fields._paramValue_k__BackingField;
		  historyWeight_k__BackingField = settingParameters->fields._historyWeight_k__BackingField;
		  v19 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !historyWeight_k__BackingField )
		    goto LABEL_1698;
		  v20 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v20->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v20->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v774 = sub_18011C4C0(v19->klass);
		    (**(void (***)(void))(*(_QWORD *)(v774 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v19->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 16) = historyWeight_k__BackingField->fields._paramValue_k__BackingField;
		  historyWeightInMotion_k__BackingField = settingParameters->fields._historyWeightInMotion_k__BackingField;
		  v22 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !historyWeightInMotion_k__BackingField )
		    goto LABEL_1698;
		  v23 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v23->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v23->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v775 = sub_18011C4C0(v22->klass);
		    (**(void (***)(void))(*(_QWORD *)(v775 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v22->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 20) = historyWeightInMotion_k__BackingField->fields._paramValue_k__BackingField;
		  fastConvergeHistoryWeight_k__BackingField = settingParameters->fields._fastConvergeHistoryWeight_k__BackingField;
		  v25 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !fastConvergeHistoryWeight_k__BackingField )
		    goto LABEL_1698;
		  v26 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v26->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v26->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v776 = sub_18011C4C0(v25->klass);
		    (**(void (***)(void))(*(_QWORD *)(v776 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v25->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 24) = fastConvergeHistoryWeight_k__BackingField->fields._paramValue_k__BackingField;
		  responsiveAAWeight_k__BackingField = settingParameters->fields._responsiveAAWeight_k__BackingField;
		  v28 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !responsiveAAWeight_k__BackingField )
		    goto LABEL_1698;
		  v29 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v29->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v29->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v777 = sub_18011C4C0(v28->klass);
		    (**(void (***)(void))(*(_QWORD *)(v777 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v28->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 28) = responsiveAAWeight_k__BackingField->fields._paramValue_k__BackingField;
		  minMotion_k__BackingField = settingParameters->fields._minMotion_k__BackingField;
		  v31 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !minMotion_k__BackingField )
		    goto LABEL_1698;
		  v32 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v32->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v32->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v778 = sub_18011C4C0(v31->klass);
		    (**(void (***)(void))(*(_QWORD *)(v778 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v31->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 32) = minMotion_k__BackingField->fields._paramValue_k__BackingField;
		  maxMotion_k__BackingField = settingParameters->fields._maxMotion_k__BackingField;
		  v34 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !maxMotion_k__BackingField )
		    goto LABEL_1698;
		  v35 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v35->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v35->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v779 = sub_18011C4C0(v34->klass);
		    (**(void (***)(void))(*(_QWORD *)(v779 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v34->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 36) = maxMotion_k__BackingField->fields._paramValue_k__BackingField;
		  characterMotionSensitivity_k__BackingField = settingParameters->fields._characterMotionSensitivity_k__BackingField;
		  v37 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !characterMotionSensitivity_k__BackingField )
		    goto LABEL_1698;
		  v38 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v38->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v38->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v780 = sub_18011C4C0(v37->klass);
		    (**(void (***)(void))(*(_QWORD *)(v780 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v37->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 40) = characterMotionSensitivity_k__BackingField->fields._paramValue_k__BackingField;
		  occlusionDepthDiff_k__BackingField = settingParameters->fields._occlusionDepthDiff_k__BackingField;
		  v40 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !occlusionDepthDiff_k__BackingField )
		    goto LABEL_1698;
		  v41 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v41->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v41->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v781 = sub_18011C4C0(v40->klass);
		    (**(void (***)(void))(*(_QWORD *)(v781 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v40->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 44) = occlusionDepthDiff_k__BackingField->fields._paramValue_k__BackingField;
		  inputLumaWeight_k__BackingField = settingParameters->fields._inputLumaWeight_k__BackingField;
		  v43 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !inputLumaWeight_k__BackingField )
		    goto LABEL_1698;
		  v44 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v44->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v44->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v782 = sub_18011C4C0(v43->klass);
		    (**(void (***)(void))(*(_QWORD *)(v782 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v43->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 48) = inputLumaWeight_k__BackingField->fields._paramValue_k__BackingField;
		  sharpenStrength1K_k__BackingField = settingParameters->fields._sharpenStrength1K_k__BackingField;
		  v46 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !sharpenStrength1K_k__BackingField )
		    goto LABEL_1698;
		  v47 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v47->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v47->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v783 = sub_18011C4C0(v46->klass);
		    (**(void (***)(void))(*(_QWORD *)(v783 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v46->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 52) = sharpenStrength1K_k__BackingField->fields._paramValue_k__BackingField;
		  sharpenStrength2K_k__BackingField = settingParameters->fields._sharpenStrength2K_k__BackingField;
		  v49 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !sharpenStrength2K_k__BackingField )
		    goto LABEL_1698;
		  v50 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v50->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v50->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v784 = sub_18011C4C0(v49->klass);
		    (**(void (***)(void))(*(_QWORD *)(v784 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v49->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 56) = sharpenStrength2K_k__BackingField->fields._paramValue_k__BackingField;
		  sharpenStrength4K_k__BackingField = settingParameters->fields._sharpenStrength4K_k__BackingField;
		  v52 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !sharpenStrength4K_k__BackingField )
		    goto LABEL_1698;
		  v53 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v53->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v53->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v785 = sub_18011C4C0(v52->klass);
		    (**(void (***)(void))(*(_QWORD *)(v785 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v52->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 60) = sharpenStrength4K_k__BackingField->fields._paramValue_k__BackingField;
		  pssrEnable_k__BackingField = settingParameters->fields._pssrEnable_k__BackingField;
		  v55 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !pssrEnable_k__BackingField )
		    goto LABEL_1698;
		  v56 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v56->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v56->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v786 = sub_18011C4C0(v55->klass);
		    (**(void (***)(void))(*(_QWORD *)(v786 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v55->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 64) = pssrEnable_k__BackingField->fields._paramValue_k__BackingField;
		  pssrSharpness_k__BackingField = settingParameters->fields._pssrSharpness_k__BackingField;
		  v58 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !pssrSharpness_k__BackingField )
		    goto LABEL_1698;
		  v59 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v59->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v59->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v787 = sub_18011C4C0(v58->klass);
		    (**(void (***)(void))(*(_QWORD *)(v787 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v58->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 68) = pssrSharpness_k__BackingField->fields._paramValue_k__BackingField;
		  dlssEnable_k__BackingField = settingParameters->fields._dlssEnable_k__BackingField;
		  v61 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !dlssEnable_k__BackingField )
		    goto LABEL_1698;
		  v62 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v62->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v62->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v788 = sub_18011C4C0(v61->klass);
		    (**(void (***)(void))(*(_QWORD *)(v788 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v61->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 72) = dlssEnable_k__BackingField->fields._paramValue_k__BackingField;
		  dlssQuality_k__BackingField = settingParameters->fields._dlssQuality_k__BackingField;
		  v64 = MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::HyperGryphEngineCode::DLSSQuality>::op_Implicit;
		  if ( !dlssQuality_k__BackingField )
		    goto LABEL_1698;
		  v65 = MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::HyperGryphEngineCode::DLSSQuality>::op_Implicit->klass;
		  if ( ((__int64)v65->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(
		      MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::HyperGryphEngineCode::DLSSQuality>::op_Implicit->klass,
		      v6);
		  if ( !*((_QWORD *)v65->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v789 = sub_18011C4C0(v64->klass);
		    (**(void (***)(void))(*(_QWORD *)(v789 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v64->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 76) = dlssQuality_k__BackingField->fields._paramValue_k__BackingField;
		  dlssUseAutoExposure_k__BackingField = settingParameters->fields._dlssUseAutoExposure_k__BackingField;
		  v67 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !dlssUseAutoExposure_k__BackingField )
		    goto LABEL_1698;
		  v68 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v68->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v68->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v790 = sub_18011C4C0(v67->klass);
		    (**(void (***)(void))(*(_QWORD *)(v790 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v67->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 80) = dlssUseAutoExposure_k__BackingField->fields._paramValue_k__BackingField;
		  dlssGMode_k__BackingField = settingParameters->fields._dlssGMode_k__BackingField;
		  v70 = MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::HyperGryphEngineCode::StreamlineDLSSFGMode>::op_Implicit;
		  if ( !dlssGMode_k__BackingField )
		    goto LABEL_1698;
		  v71 = MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::HyperGryphEngineCode::StreamlineDLSSFGMode>::op_Implicit->klass;
		  if ( ((__int64)v71->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(
		      MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::HyperGryphEngineCode::StreamlineDLSSFGMode>::op_Implicit->klass,
		      v6);
		  if ( !*((_QWORD *)v71->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v791 = sub_18011C4C0(v70->klass);
		    (**(void (***)(void))(*(_QWORD *)(v791 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v70->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 84) = dlssGMode_k__BackingField->fields._paramValue_k__BackingField;
		  dlssGGenFrames_k__BackingField = settingParameters->fields._dlssGGenFrames_k__BackingField;
		  if ( !dlssGGenFrames_k__BackingField )
		    goto LABEL_1698;
		  *(_DWORD *)(v4 + 88) = dlssGGenFrames_k__BackingField->fields._paramValue_k__BackingField;
		  dlssReflexMode_k__BackingField = settingParameters->fields._dlssReflexMode_k__BackingField;
		  v74 = MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::HyperGryphEngineCode::StreamlineReflexMode>::op_Implicit;
		  if ( !dlssReflexMode_k__BackingField )
		    goto LABEL_1698;
		  v75 = MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::HyperGryphEngineCode::StreamlineReflexMode>::op_Implicit->klass;
		  if ( ((__int64)v75->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(
		      MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::HyperGryphEngineCode::StreamlineReflexMode>::op_Implicit->klass,
		      v6);
		  if ( !*((_QWORD *)v75->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v792 = sub_18011C4C0(v74->klass);
		    (**(void (***)(void))(*(_QWORD *)(v792 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v74->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 92) = dlssReflexMode_k__BackingField->fields._paramValue_k__BackingField;
		  dlssPCLEnable_k__BackingField = settingParameters->fields._dlssPCLEnable_k__BackingField;
		  v77 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !dlssPCLEnable_k__BackingField )
		    goto LABEL_1698;
		  v78 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v78->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v78->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v793 = sub_18011C4C0(v77->klass);
		    (**(void (***)(void))(*(_QWORD *)(v793 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v77->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 96) = dlssPCLEnable_k__BackingField->fields._paramValue_k__BackingField;
		  dlssSharpenStrength_k__BackingField = settingParameters->fields._dlssSharpenStrength_k__BackingField;
		  v80 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !dlssSharpenStrength_k__BackingField )
		    goto LABEL_1698;
		  v81 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v81->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v81->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v794 = sub_18011C4C0(v80->klass);
		    (**(void (***)(void))(*(_QWORD *)(v794 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v80->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 100) = dlssSharpenStrength_k__BackingField->fields._paramValue_k__BackingField;
		  dlssUseUIHint_k__BackingField = settingParameters->fields._dlssUseUIHint_k__BackingField;
		  v83 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !dlssUseUIHint_k__BackingField )
		    goto LABEL_1698;
		  v84 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v84->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v84->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v795 = sub_18011C4C0(v83->klass);
		    (**(void (***)(void))(*(_QWORD *)(v795 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v83->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 104) = dlssUseUIHint_k__BackingField->fields._paramValue_k__BackingField;
		  dlssUIHintAlphaThreshold_k__BackingField = settingParameters->fields._dlssUIHintAlphaThreshold_k__BackingField;
		  v86 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !dlssUIHintAlphaThreshold_k__BackingField )
		    goto LABEL_1698;
		  v87 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v87->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v87->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v796 = sub_18011C4C0(v86->klass);
		    (**(void (***)(void))(*(_QWORD *)(v796 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v86->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 108) = dlssUIHintAlphaThreshold_k__BackingField->fields._paramValue_k__BackingField;
		  dlssModel_k__BackingField = settingParameters->fields._dlssModel_k__BackingField;
		  v89 = MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::HyperGryphEngineCode::DLSSModel>::op_Implicit;
		  if ( !dlssModel_k__BackingField )
		    goto LABEL_1698;
		  v90 = MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::HyperGryphEngineCode::DLSSModel>::op_Implicit->klass;
		  if ( ((__int64)v90->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(
		      MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::HyperGryphEngineCode::DLSSModel>::op_Implicit->klass,
		      v6);
		  if ( !*((_QWORD *)v90->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v797 = sub_18011C4C0(v89->klass);
		    (**(void (***)(void))(*(_QWORD *)(v797 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v89->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 112) = dlssModel_k__BackingField->fields._paramValue_k__BackingField;
		  fsr3Enable_k__BackingField = settingParameters->fields._fsr3Enable_k__BackingField;
		  v92 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !fsr3Enable_k__BackingField )
		    goto LABEL_1698;
		  v93 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v93->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v93->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v798 = sub_18011C4C0(v92->klass);
		    (**(void (***)(void))(*(_QWORD *)(v798 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v92->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 116) = fsr3Enable_k__BackingField->fields._paramValue_k__BackingField;
		  fsr3UseReaciveAndTCMask_k__BackingField = settingParameters->fields._fsr3UseReaciveAndTCMask_k__BackingField;
		  v95 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !fsr3UseReaciveAndTCMask_k__BackingField )
		    goto LABEL_1698;
		  v96 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v96->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v96->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v799 = sub_18011C4C0(v95->klass);
		    (**(void (***)(void))(*(_QWORD *)(v799 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v95->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 117) = fsr3UseReaciveAndTCMask_k__BackingField->fields._paramValue_k__BackingField;
		  fsr3Quality_k__BackingField = settingParameters->fields._fsr3Quality_k__BackingField;
		  v98 = MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::HyperGryphEngineCode::FSR3Quality>::op_Implicit;
		  if ( !fsr3Quality_k__BackingField )
		    goto LABEL_1698;
		  v99 = MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::HyperGryphEngineCode::FSR3Quality>::op_Implicit->klass;
		  if ( ((__int64)v99->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(
		      MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::HyperGryphEngineCode::FSR3Quality>::op_Implicit->klass,
		      v6);
		  if ( !*((_QWORD *)v99->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v800 = sub_18011C4C0(v98->klass);
		    (**(void (***)(void))(*(_QWORD *)(v800 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v98->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 120) = fsr3Quality_k__BackingField->fields._paramValue_k__BackingField;
		  fsr3SharpenStrength_k__BackingField = settingParameters->fields._fsr3SharpenStrength_k__BackingField;
		  v101 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !fsr3SharpenStrength_k__BackingField )
		    goto LABEL_1698;
		  v102 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v102->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v102->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v801 = sub_18011C4C0(v101->klass);
		    (**(void (***)(void))(*(_QWORD *)(v801 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v101->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 124) = fsr3SharpenStrength_k__BackingField->fields._paramValue_k__BackingField;
		  fsr3UseFP16_k__BackingField = settingParameters->fields._fsr3UseFP16_k__BackingField;
		  v104 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !fsr3UseFP16_k__BackingField )
		    goto LABEL_1698;
		  v105 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v105->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v105->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v802 = sub_18011C4C0(v104->klass);
		    (**(void (***)(void))(*(_QWORD *)(v802 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v104->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 128) = fsr3UseFP16_k__BackingField->fields._paramValue_k__BackingField;
		  fsr3UseWave_k__BackingField = settingParameters->fields._fsr3UseWave_k__BackingField;
		  v107 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !fsr3UseWave_k__BackingField )
		    goto LABEL_1698;
		  v108 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v108->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v108->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v803 = sub_18011C4C0(v107->klass);
		    (**(void (***)(void))(*(_QWORD *)(v803 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v107->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 129) = fsr3UseWave_k__BackingField->fields._paramValue_k__BackingField;
		  fsr3UseWave64_k__BackingField = settingParameters->fields._fsr3UseWave64_k__BackingField;
		  v110 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !fsr3UseWave64_k__BackingField )
		    goto LABEL_1698;
		  v111 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v111->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v111->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v804 = sub_18011C4C0(v110->klass);
		    (**(void (***)(void))(*(_QWORD *)(v804 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v110->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 130) = fsr3UseWave64_k__BackingField->fields._paramValue_k__BackingField;
		  fsr3UseLanczosLut_k__BackingField = settingParameters->fields._fsr3UseLanczosLut_k__BackingField;
		  v113 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !fsr3UseLanczosLut_k__BackingField )
		    goto LABEL_1698;
		  v114 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v114->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v114->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v805 = sub_18011C4C0(v113->klass);
		    (**(void (***)(void))(*(_QWORD *)(v805 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v113->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 131) = fsr3UseLanczosLut_k__BackingField->fields._paramValue_k__BackingField;
		  fsr3FIEnable_k__BackingField = settingParameters->fields._fsr3FIEnable_k__BackingField;
		  v116 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !fsr3FIEnable_k__BackingField )
		    goto LABEL_1698;
		  v117 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v117->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v117->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v806 = sub_18011C4C0(v116->klass);
		    (**(void (***)(void))(*(_QWORD *)(v806 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v116->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 132) = fsr3FIEnable_k__BackingField->fields._paramValue_k__BackingField;
		  bloomQuality_k__BackingField = settingParameters->fields._bloomQuality_k__BackingField;
		  if ( !bloomQuality_k__BackingField )
		    goto LABEL_1698;
		  *(_DWORD *)(v4 + 136) = bloomQuality_k__BackingField->fields._paramValue_k__BackingField;
		  bloomUseComputeShader_k__BackingField = settingParameters->fields._bloomUseComputeShader_k__BackingField;
		  v120 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !bloomUseComputeShader_k__BackingField )
		    goto LABEL_1698;
		  v121 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v121->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v121->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v807 = sub_18011C4C0(v120->klass);
		    (**(void (***)(void))(*(_QWORD *)(v807 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v120->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 140) = bloomUseComputeShader_k__BackingField->fields._paramValue_k__BackingField;
		  lutSize_k__BackingField = settingParameters->fields._lutSize_k__BackingField;
		  v123 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !lutSize_k__BackingField )
		    goto LABEL_1698;
		  v124 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v124->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v124->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v808 = sub_18011C4C0(v123->klass);
		    (**(void (***)(void))(*(_QWORD *)(v808 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v123->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 144) = lutSize_k__BackingField->fields._paramValue_k__BackingField;
		  lutFormat_k__BackingField = settingParameters->fields._lutFormat_k__BackingField;
		  v126 = MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::Experimental::Rendering::GraphicsFormat>::op_Implicit;
		  if ( !lutFormat_k__BackingField )
		    goto LABEL_1698;
		  v127 = MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::Experimental::Rendering::GraphicsFormat>::op_Implicit->klass;
		  if ( ((__int64)v127->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(
		      MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::Experimental::Rendering::GraphicsFormat>::op_Implicit->klass,
		      v6);
		  if ( !*((_QWORD *)v127->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v809 = sub_18011C4C0(v126->klass);
		    (**(void (***)(void))(*(_QWORD *)(v809 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v126->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 148) = lutFormat_k__BackingField->fields._paramValue_k__BackingField;
		  ppBufferFormat_k__BackingField = settingParameters->fields._ppBufferFormat_k__BackingField;
		  v129 = MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::Experimental::Rendering::GraphicsFormat>::op_Implicit;
		  if ( !ppBufferFormat_k__BackingField )
		    goto LABEL_1698;
		  v130 = MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::Experimental::Rendering::GraphicsFormat>::op_Implicit->klass;
		  if ( ((__int64)v130->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(
		      MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::Experimental::Rendering::GraphicsFormat>::op_Implicit->klass,
		      v6);
		  if ( !*((_QWORD *)v130->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v810 = sub_18011C4C0(v129->klass);
		    (**(void (***)(void))(*(_QWORD *)(v810 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v129->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 152) = ppBufferFormat_k__BackingField->fields._paramValue_k__BackingField;
		  uiPPBufferFormat_k__BackingField = settingParameters->fields._uiPPBufferFormat_k__BackingField;
		  v132 = MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::Experimental::Rendering::GraphicsFormat>::op_Implicit;
		  if ( !uiPPBufferFormat_k__BackingField )
		    goto LABEL_1698;
		  v133 = MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::Experimental::Rendering::GraphicsFormat>::op_Implicit->klass;
		  if ( ((__int64)v133->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(
		      MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::Experimental::Rendering::GraphicsFormat>::op_Implicit->klass,
		      v6);
		  if ( !*((_QWORD *)v133->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v811 = sub_18011C4C0(v132->klass);
		    (**(void (***)(void))(*(_QWORD *)(v811 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v132->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 156) = uiPPBufferFormat_k__BackingField->fields._paramValue_k__BackingField;
		  frostedGlassUseComputeShader_k__BackingField = settingParameters->fields._frostedGlassUseComputeShader_k__BackingField;
		  v135 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !frostedGlassUseComputeShader_k__BackingField )
		    goto LABEL_1698;
		  v136 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v136->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v136->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v812 = sub_18011C4C0(v135->klass);
		    (**(void (***)(void))(*(_QWORD *)(v812 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v135->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 160) = frostedGlassUseComputeShader_k__BackingField->fields._paramValue_k__BackingField;
		  depthOfFieldQuality_k__BackingField = settingParameters->fields._depthOfFieldQuality_k__BackingField;
		  if ( !depthOfFieldQuality_k__BackingField )
		    goto LABEL_1698;
		  *(_DWORD *)(v4 + 164) = depthOfFieldQuality_k__BackingField->fields._paramValue_k__BackingField;
		  depthOfFieldMaxRadius_k__BackingField = settingParameters->fields._depthOfFieldMaxRadius_k__BackingField;
		  v139 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !depthOfFieldMaxRadius_k__BackingField )
		    goto LABEL_1698;
		  v140 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v140->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v140->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v813 = sub_18011C4C0(v139->klass);
		    (**(void (***)(void))(*(_QWORD *)(v813 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v139->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 168) = depthOfFieldMaxRadius_k__BackingField->fields._paramValue_k__BackingField;
		  depthOfFieldScaleAdjust_k__BackingField = settingParameters->fields._depthOfFieldScaleAdjust_k__BackingField;
		  v142 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !depthOfFieldScaleAdjust_k__BackingField )
		    goto LABEL_1698;
		  v143 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v143->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v143->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v814 = sub_18011C4C0(v142->klass);
		    (**(void (***)(void))(*(_QWORD *)(v814 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v142->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 172) = depthOfFieldScaleAdjust_k__BackingField->fields._paramValue_k__BackingField;
		  depthOfFieldScaleAdjustThreshold_k__BackingField = settingParameters->fields._depthOfFieldScaleAdjustThreshold_k__BackingField;
		  v145 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !depthOfFieldScaleAdjustThreshold_k__BackingField )
		    goto LABEL_1698;
		  v146 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v146->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v146->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v815 = sub_18011C4C0(v145->klass);
		    (**(void (***)(void))(*(_QWORD *)(v815 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v145->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 176) = depthOfFieldScaleAdjustThreshold_k__BackingField->fields._paramValue_k__BackingField;
		  motionBlurEnable_k__BackingField = settingParameters->fields._motionBlurEnable_k__BackingField;
		  v148 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !motionBlurEnable_k__BackingField )
		    goto LABEL_1698;
		  v149 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v149->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v149->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v816 = sub_18011C4C0(v148->klass);
		    (**(void (***)(void))(*(_QWORD *)(v816 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v148->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 180) = motionBlurEnable_k__BackingField->fields._paramValue_k__BackingField;
		  bloomEnabled_k__BackingField = settingParameters->fields._bloomEnabled_k__BackingField;
		  v151 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !bloomEnabled_k__BackingField )
		    goto LABEL_1698;
		  v152 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v152->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v152->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v817 = sub_18011C4C0(v151->klass);
		    (**(void (***)(void))(*(_QWORD *)(v817 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v151->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 181) = bloomEnabled_k__BackingField->fields._paramValue_k__BackingField;
		  vignetteEnabled_k__BackingField = settingParameters->fields._vignetteEnabled_k__BackingField;
		  v154 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !vignetteEnabled_k__BackingField )
		    goto LABEL_1698;
		  v155 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v155->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v155->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v818 = sub_18011C4C0(v154->klass);
		    (**(void (***)(void))(*(_QWORD *)(v818 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v154->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 182) = vignetteEnabled_k__BackingField->fields._paramValue_k__BackingField;
		  radialBlurEnabled_k__BackingField = settingParameters->fields._radialBlurEnabled_k__BackingField;
		  v157 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !radialBlurEnabled_k__BackingField )
		    goto LABEL_1698;
		  v158 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v158->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v158->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v819 = sub_18011C4C0(v157->klass);
		    (**(void (***)(void))(*(_QWORD *)(v819 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v157->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 183) = radialBlurEnabled_k__BackingField->fields._paramValue_k__BackingField;
		  chromaticAberrationEnabled_k__BackingField = settingParameters->fields._chromaticAberrationEnabled_k__BackingField;
		  v160 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !chromaticAberrationEnabled_k__BackingField )
		    goto LABEL_1698;
		  v161 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v161->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v161->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v820 = sub_18011C4C0(v160->klass);
		    (**(void (***)(void))(*(_QWORD *)(v820 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v160->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 184) = chromaticAberrationEnabled_k__BackingField->fields._paramValue_k__BackingField;
		  dirtyLensEnabled_k__BackingField = settingParameters->fields._dirtyLensEnabled_k__BackingField;
		  v163 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !dirtyLensEnabled_k__BackingField )
		    goto LABEL_1698;
		  v164 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v164->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v164->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v821 = sub_18011C4C0(v163->klass);
		    (**(void (***)(void))(*(_QWORD *)(v821 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v163->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 185) = dirtyLensEnabled_k__BackingField->fields._paramValue_k__BackingField;
		  sharpenEnabled_k__BackingField = settingParameters->fields._sharpenEnabled_k__BackingField;
		  v166 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !sharpenEnabled_k__BackingField )
		    goto LABEL_1698;
		  v167 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v167->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v167->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v822 = sub_18011C4C0(v166->klass);
		    (**(void (***)(void))(*(_QWORD *)(v822 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v166->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 186) = sharpenEnabled_k__BackingField->fields._paramValue_k__BackingField;
		  frostedGlassEnabled_k__BackingField = settingParameters->fields._frostedGlassEnabled_k__BackingField;
		  v169 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !frostedGlassEnabled_k__BackingField )
		    goto LABEL_1698;
		  v170 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v170->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v170->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v823 = sub_18011C4C0(v169->klass);
		    (**(void (***)(void))(*(_QWORD *)(v823 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v169->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 187) = frostedGlassEnabled_k__BackingField->fields._paramValue_k__BackingField;
		  cutsceneEffectEnabled_k__BackingField = settingParameters->fields._cutsceneEffectEnabled_k__BackingField;
		  v172 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !cutsceneEffectEnabled_k__BackingField )
		    goto LABEL_1698;
		  v173 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v173->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v173->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v824 = sub_18011C4C0(v172->klass);
		    (**(void (***)(void))(*(_QWORD *)(v824 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v172->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 188) = cutsceneEffectEnabled_k__BackingField->fields._paramValue_k__BackingField;
		  fisheyeEffectEnabled_k__BackingField = settingParameters->fields._fisheyeEffectEnabled_k__BackingField;
		  v175 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !fisheyeEffectEnabled_k__BackingField )
		    goto LABEL_1698;
		  v176 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v176->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v176->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v825 = sub_18011C4C0(v175->klass);
		    (**(void (***)(void))(*(_QWORD *)(v825 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v175->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 189) = fisheyeEffectEnabled_k__BackingField->fields._paramValue_k__BackingField;
		  lensFlareEnabled_k__BackingField = settingParameters->fields._lensFlareEnabled_k__BackingField;
		  v178 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !lensFlareEnabled_k__BackingField )
		    goto LABEL_1698;
		  v179 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v179->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v179->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v826 = sub_18011C4C0(v178->klass);
		    (**(void (***)(void))(*(_QWORD *)(v826 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v178->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 190) = lensFlareEnabled_k__BackingField->fields._paramValue_k__BackingField;
		  punctualLightMaxCount_k__BackingField = settingParameters->fields._punctualLightMaxCount_k__BackingField;
		  v181 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !punctualLightMaxCount_k__BackingField )
		    goto LABEL_1698;
		  v182 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v182->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v182->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v827 = sub_18011C4C0(v181->klass);
		    (**(void (***)(void))(*(_QWORD *)(v827 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v181->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 192) = punctualLightMaxCount_k__BackingField->fields._paramValue_k__BackingField;
		  enableShadowProxy_k__BackingField = settingParameters->fields._enableShadowProxy_k__BackingField;
		  v184 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !enableShadowProxy_k__BackingField )
		    goto LABEL_1698;
		  v185 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v185->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v185->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v828 = sub_18011C4C0(v184->klass);
		    (**(void (***)(void))(*(_QWORD *)(v828 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v184->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 196) = enableShadowProxy_k__BackingField->fields._paramValue_k__BackingField;
		  shadowDepthBits_k__BackingField = settingParameters->fields._shadowDepthBits_k__BackingField;
		  if ( !shadowDepthBits_k__BackingField )
		    goto LABEL_1698;
		  *(_DWORD *)(v4 + 200) = shadowDepthBits_k__BackingField->fields._paramValue_k__BackingField;
		  enableScreenSpaceShadowMask_k__BackingField = settingParameters->fields._enableScreenSpaceShadowMask_k__BackingField;
		  v188 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !enableScreenSpaceShadowMask_k__BackingField )
		    goto LABEL_1698;
		  v189 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v189->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v189->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v829 = sub_18011C4C0(v188->klass);
		    (**(void (***)(void))(*(_QWORD *)(v829 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v188->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 204) = enableScreenSpaceShadowMask_k__BackingField->fields._paramValue_k__BackingField;
		  csmEnabled_k__BackingField = settingParameters->fields._csmEnabled_k__BackingField;
		  v191 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !csmEnabled_k__BackingField )
		    goto LABEL_1698;
		  v192 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v192->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v192->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v830 = sub_18011C4C0(v191->klass);
		    (**(void (***)(void))(*(_QWORD *)(v830 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v191->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 205) = csmEnabled_k__BackingField->fields._paramValue_k__BackingField;
		  csmShadowMapTileResolution_k__BackingField = settingParameters->fields._csmShadowMapTileResolution_k__BackingField;
		  v194 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !csmShadowMapTileResolution_k__BackingField )
		    goto LABEL_1698;
		  v195 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v195->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v195->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v831 = sub_18011C4C0(v194->klass);
		    (**(void (***)(void))(*(_QWORD *)(v831 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v194->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 208) = csmShadowMapTileResolution_k__BackingField->fields._paramValue_k__BackingField;
		  csmMaxDistance_k__BackingField = settingParameters->fields._csmMaxDistance_k__BackingField;
		  v197 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !csmMaxDistance_k__BackingField )
		    goto LABEL_1698;
		  v198 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v198->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v198->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v832 = sub_18011C4C0(v197->klass);
		    (**(void (***)(void))(*(_QWORD *)(v832 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v197->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 212) = csmMaxDistance_k__BackingField->fields._paramValue_k__BackingField;
		  csmFadeInnerDistance_k__BackingField = settingParameters->fields._csmFadeInnerDistance_k__BackingField;
		  v200 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !csmFadeInnerDistance_k__BackingField )
		    goto LABEL_1698;
		  v201 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v201->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v201->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v833 = sub_18011C4C0(v200->klass);
		    (**(void (***)(void))(*(_QWORD *)(v833 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v200->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 216) = csmFadeInnerDistance_k__BackingField->fields._paramValue_k__BackingField;
		  csmSplitCount_k__BackingField = settingParameters->fields._csmSplitCount_k__BackingField;
		  v203 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !csmSplitCount_k__BackingField )
		    goto LABEL_1698;
		  v204 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v204->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v204->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v834 = sub_18011C4C0(v203->klass);
		    (**(void (***)(void))(*(_QWORD *)(v834 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v203->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 220) = csmSplitCount_k__BackingField->fields._paramValue_k__BackingField;
		  csmSplit0_k__BackingField = settingParameters->fields._csmSplit0_k__BackingField;
		  v206 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !csmSplit0_k__BackingField )
		    goto LABEL_1698;
		  v207 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v207->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v207->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v835 = sub_18011C4C0(v206->klass);
		    (**(void (***)(void))(*(_QWORD *)(v835 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v206->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 224) = csmSplit0_k__BackingField->fields._paramValue_k__BackingField;
		  csmSplit1_k__BackingField = settingParameters->fields._csmSplit1_k__BackingField;
		  v209 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !csmSplit1_k__BackingField )
		    goto LABEL_1698;
		  v210 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v210->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v210->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v836 = sub_18011C4C0(v209->klass);
		    (**(void (***)(void))(*(_QWORD *)(v836 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v209->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 228) = csmSplit1_k__BackingField->fields._paramValue_k__BackingField;
		  csmSplit2_k__BackingField = settingParameters->fields._csmSplit2_k__BackingField;
		  v212 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !csmSplit2_k__BackingField )
		    goto LABEL_1698;
		  v213 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v213->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v213->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v837 = sub_18011C4C0(v212->klass);
		    (**(void (***)(void))(*(_QWORD *)(v837 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v212->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 232) = csmSplit2_k__BackingField->fields._paramValue_k__BackingField;
		  csmSplit3_k__BackingField = settingParameters->fields._csmSplit3_k__BackingField;
		  v215 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !csmSplit3_k__BackingField )
		    goto LABEL_1698;
		  v216 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v216->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v216->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v838 = sub_18011C4C0(v215->klass);
		    (**(void (***)(void))(*(_QWORD *)(v838 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v215->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 236) = csmSplit3_k__BackingField->fields._paramValue_k__BackingField;
		  csmUseShadowmapCache_k__BackingField = settingParameters->fields._csmUseShadowmapCache_k__BackingField;
		  v218 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !csmUseShadowmapCache_k__BackingField )
		    goto LABEL_1698;
		  v219 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v219->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v219->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v839 = sub_18011C4C0(v218->klass);
		    (**(void (***)(void))(*(_QWORD *)(v839 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v218->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 240) = csmUseShadowmapCache_k__BackingField->fields._paramValue_k__BackingField;
		  csmCachedFrame0_k__BackingField = settingParameters->fields._csmCachedFrame0_k__BackingField;
		  v221 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !csmCachedFrame0_k__BackingField )
		    goto LABEL_1698;
		  v222 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v222->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v222->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v840 = sub_18011C4C0(v221->klass);
		    (**(void (***)(void))(*(_QWORD *)(v840 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v221->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 244) = csmCachedFrame0_k__BackingField->fields._paramValue_k__BackingField;
		  csmCachedFrame1_k__BackingField = settingParameters->fields._csmCachedFrame1_k__BackingField;
		  v224 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !csmCachedFrame1_k__BackingField )
		    goto LABEL_1698;
		  v225 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v225->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v225->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v841 = sub_18011C4C0(v224->klass);
		    (**(void (***)(void))(*(_QWORD *)(v841 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v224->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 248) = csmCachedFrame1_k__BackingField->fields._paramValue_k__BackingField;
		  csmCachedFrame2_k__BackingField = settingParameters->fields._csmCachedFrame2_k__BackingField;
		  v227 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !csmCachedFrame2_k__BackingField )
		    goto LABEL_1698;
		  v228 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v228->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v228->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v842 = sub_18011C4C0(v227->klass);
		    (**(void (***)(void))(*(_QWORD *)(v842 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v227->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 252) = csmCachedFrame2_k__BackingField->fields._paramValue_k__BackingField;
		  csmCachedFrame3_k__BackingField = settingParameters->fields._csmCachedFrame3_k__BackingField;
		  v230 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !csmCachedFrame3_k__BackingField )
		    goto LABEL_1698;
		  v231 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v231->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v231->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v843 = sub_18011C4C0(v230->klass);
		    (**(void (***)(void))(*(_QWORD *)(v843 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v230->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 256) = csmCachedFrame3_k__BackingField->fields._paramValue_k__BackingField;
		  csmScreenSizeMin0_k__BackingField = settingParameters->fields._csmScreenSizeMin0_k__BackingField;
		  v233 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !csmScreenSizeMin0_k__BackingField )
		    goto LABEL_1698;
		  v234 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v234->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v234->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v844 = sub_18011C4C0(v233->klass);
		    (**(void (***)(void))(*(_QWORD *)(v844 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v233->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 260) = csmScreenSizeMin0_k__BackingField->fields._paramValue_k__BackingField;
		  csmScreenSizeMin1_k__BackingField = settingParameters->fields._csmScreenSizeMin1_k__BackingField;
		  v236 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !csmScreenSizeMin1_k__BackingField )
		    goto LABEL_1698;
		  v237 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v237->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v237->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v845 = sub_18011C4C0(v236->klass);
		    (**(void (***)(void))(*(_QWORD *)(v845 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v236->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 264) = csmScreenSizeMin1_k__BackingField->fields._paramValue_k__BackingField;
		  csmScreenSizeMin2_k__BackingField = settingParameters->fields._csmScreenSizeMin2_k__BackingField;
		  v239 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !csmScreenSizeMin2_k__BackingField )
		    goto LABEL_1698;
		  v240 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v240->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v240->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v846 = sub_18011C4C0(v239->klass);
		    (**(void (***)(void))(*(_QWORD *)(v846 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v239->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 268) = csmScreenSizeMin2_k__BackingField->fields._paramValue_k__BackingField;
		  csmScreenSizeMin3_k__BackingField = settingParameters->fields._csmScreenSizeMin3_k__BackingField;
		  v242 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !csmScreenSizeMin3_k__BackingField )
		    goto LABEL_1698;
		  v243 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v243->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v243->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v847 = sub_18011C4C0(v242->klass);
		    (**(void (***)(void))(*(_QWORD *)(v847 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v242->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 272) = csmScreenSizeMin3_k__BackingField->fields._paramValue_k__BackingField;
		  csmEnableOcclusionCulling0_k__BackingField = settingParameters->fields._csmEnableOcclusionCulling0_k__BackingField;
		  v245 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !csmEnableOcclusionCulling0_k__BackingField )
		    goto LABEL_1698;
		  v246 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v246->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v246->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v848 = sub_18011C4C0(v245->klass);
		    (**(void (***)(void))(*(_QWORD *)(v848 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v245->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 276) = csmEnableOcclusionCulling0_k__BackingField->fields._paramValue_k__BackingField;
		  csmEnableOcclusionCulling1_k__BackingField = settingParameters->fields._csmEnableOcclusionCulling1_k__BackingField;
		  v248 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !csmEnableOcclusionCulling1_k__BackingField )
		    goto LABEL_1698;
		  v249 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v249->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v249->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v849 = sub_18011C4C0(v248->klass);
		    (**(void (***)(void))(*(_QWORD *)(v849 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v248->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 277) = csmEnableOcclusionCulling1_k__BackingField->fields._paramValue_k__BackingField;
		  csmEnableOcclusionCulling2_k__BackingField = settingParameters->fields._csmEnableOcclusionCulling2_k__BackingField;
		  v251 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !csmEnableOcclusionCulling2_k__BackingField )
		    goto LABEL_1698;
		  v252 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v252->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v252->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v850 = sub_18011C4C0(v251->klass);
		    (**(void (***)(void))(*(_QWORD *)(v850 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v251->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 278) = csmEnableOcclusionCulling2_k__BackingField->fields._paramValue_k__BackingField;
		  csmEnableOcclusionCulling3_k__BackingField = settingParameters->fields._csmEnableOcclusionCulling3_k__BackingField;
		  v254 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !csmEnableOcclusionCulling3_k__BackingField )
		    goto LABEL_1698;
		  v255 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v255->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v255->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v851 = sub_18011C4C0(v254->klass);
		    (**(void (***)(void))(*(_QWORD *)(v851 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v254->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 279) = csmEnableOcclusionCulling3_k__BackingField->fields._paramValue_k__BackingField;
		  csmOcclusionDepthSize_k__BackingField = settingParameters->fields._csmOcclusionDepthSize_k__BackingField;
		  v257 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !csmOcclusionDepthSize_k__BackingField )
		    goto LABEL_1698;
		  v258 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v258->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v258->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v852 = sub_18011C4C0(v257->klass);
		    (**(void (***)(void))(*(_QWORD *)(v852 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v257->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 280) = csmOcclusionDepthSize_k__BackingField->fields._paramValue_k__BackingField;
		  csmStopRenderCharacterCascade_k__BackingField = settingParameters->fields._csmStopRenderCharacterCascade_k__BackingField;
		  v260 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !csmStopRenderCharacterCascade_k__BackingField )
		    goto LABEL_1698;
		  v261 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v261->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v261->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v853 = sub_18011C4C0(v260->klass);
		    (**(void (***)(void))(*(_QWORD *)(v853 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v260->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 284) = csmStopRenderCharacterCascade_k__BackingField->fields._paramValue_k__BackingField;
		  csmNearPlaneOffset_k__BackingField = settingParameters->fields._csmNearPlaneOffset_k__BackingField;
		  v263 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !csmNearPlaneOffset_k__BackingField )
		    goto LABEL_1698;
		  v264 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v264->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v264->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v854 = sub_18011C4C0(v263->klass);
		    (**(void (***)(void))(*(_QWORD *)(v854 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v263->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 288) = csmNearPlaneOffset_k__BackingField->fields._paramValue_k__BackingField;
		  csmHardwareBias_k__BackingField = settingParameters->fields._csmHardwareBias_k__BackingField;
		  v266 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !csmHardwareBias_k__BackingField )
		    goto LABEL_1698;
		  v267 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v267->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v267->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v855 = sub_18011C4C0(v266->klass);
		    (**(void (***)(void))(*(_QWORD *)(v855 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v266->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 292) = csmHardwareBias_k__BackingField->fields._paramValue_k__BackingField;
		  csmHardwareNormalBias_k__BackingField = settingParameters->fields._csmHardwareNormalBias_k__BackingField;
		  v269 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !csmHardwareNormalBias_k__BackingField )
		    goto LABEL_1698;
		  v270 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v270->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v270->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v856 = sub_18011C4C0(v269->klass);
		    (**(void (***)(void))(*(_QWORD *)(v856 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v269->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 296) = csmHardwareNormalBias_k__BackingField->fields._paramValue_k__BackingField;
		  characterShadowEnabled_k__BackingField = settingParameters->fields._characterShadowEnabled_k__BackingField;
		  v272 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !characterShadowEnabled_k__BackingField )
		    goto LABEL_1698;
		  v273 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v273->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v273->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v857 = sub_18011C4C0(v272->klass);
		    (**(void (***)(void))(*(_QWORD *)(v857 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v272->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 300) = characterShadowEnabled_k__BackingField->fields._paramValue_k__BackingField;
		  characterShadowMapResolution_k__BackingField = settingParameters->fields._characterShadowMapResolution_k__BackingField;
		  v275 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !characterShadowMapResolution_k__BackingField )
		    goto LABEL_1698;
		  v276 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v276->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v276->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v858 = sub_18011C4C0(v275->klass);
		    (**(void (***)(void))(*(_QWORD *)(v858 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v275->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 304) = characterShadowMapResolution_k__BackingField->fields._paramValue_k__BackingField;
		  characterShadowHardwareBias_k__BackingField = settingParameters->fields._characterShadowHardwareBias_k__BackingField;
		  v278 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !characterShadowHardwareBias_k__BackingField )
		    goto LABEL_1698;
		  v279 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v279->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v279->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v859 = sub_18011C4C0(v278->klass);
		    (**(void (***)(void))(*(_QWORD *)(v859 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v278->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 308) = characterShadowHardwareBias_k__BackingField->fields._paramValue_k__BackingField;
		  characterShadowHardwareNormalBias_k__BackingField = settingParameters->fields._characterShadowHardwareNormalBias_k__BackingField;
		  v281 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !characterShadowHardwareNormalBias_k__BackingField )
		    goto LABEL_1698;
		  v282 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v282->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v282->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v860 = sub_18011C4C0(v281->klass);
		    (**(void (***)(void))(*(_QWORD *)(v860 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v281->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 312) = characterShadowHardwareNormalBias_k__BackingField->fields._paramValue_k__BackingField;
		  characterShadowShaderBias_k__BackingField = settingParameters->fields._characterShadowShaderBias_k__BackingField;
		  v284 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !characterShadowShaderBias_k__BackingField )
		    goto LABEL_1698;
		  v285 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v285->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v285->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v861 = sub_18011C4C0(v284->klass);
		    (**(void (***)(void))(*(_QWORD *)(v861 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v284->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 316) = characterShadowShaderBias_k__BackingField->fields._paramValue_k__BackingField;
		  characterShadowShaderNormalBias_k__BackingField = settingParameters->fields._characterShadowShaderNormalBias_k__BackingField;
		  v287 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !characterShadowShaderNormalBias_k__BackingField )
		    goto LABEL_1698;
		  v288 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v288->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v288->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v862 = sub_18011C4C0(v287->klass);
		    (**(void (***)(void))(*(_QWORD *)(v862 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v287->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 320) = characterShadowShaderNormalBias_k__BackingField->fields._paramValue_k__BackingField;
		  punctualLightShadowEnabled_k__BackingField = settingParameters->fields._punctualLightShadowEnabled_k__BackingField;
		  v290 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !punctualLightShadowEnabled_k__BackingField )
		    goto LABEL_1698;
		  v291 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v291->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v291->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v863 = sub_18011C4C0(v290->klass);
		    (**(void (***)(void))(*(_QWORD *)(v863 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v290->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 324) = punctualLightShadowEnabled_k__BackingField->fields._paramValue_k__BackingField;
		  punctualLightTileMaxSize_k__BackingField = settingParameters->fields._punctualLightTileMaxSize_k__BackingField;
		  v293 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !punctualLightTileMaxSize_k__BackingField )
		    goto LABEL_1698;
		  v294 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v294->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v294->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v864 = sub_18011C4C0(v293->klass);
		    (**(void (***)(void))(*(_QWORD *)(v864 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v293->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 328) = punctualLightTileMaxSize_k__BackingField->fields._paramValue_k__BackingField;
		  punctualLightForceCullDistance_k__BackingField = settingParameters->fields._punctualLightForceCullDistance_k__BackingField;
		  v296 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !punctualLightForceCullDistance_k__BackingField )
		    goto LABEL_1698;
		  v297 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v297->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v297->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v865 = sub_18011C4C0(v296->klass);
		    (**(void (***)(void))(*(_QWORD *)(v865 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v296->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 332) = punctualLightForceCullDistance_k__BackingField->fields._paramValue_k__BackingField;
		  punctualLightEnvDynamicCasterCount_k__BackingField = settingParameters->fields._punctualLightEnvDynamicCasterCount_k__BackingField;
		  v299 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !punctualLightEnvDynamicCasterCount_k__BackingField )
		    goto LABEL_1698;
		  v300 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v300->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v300->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v866 = sub_18011C4C0(v299->klass);
		    (**(void (***)(void))(*(_QWORD *)(v866 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v299->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 336) = punctualLightEnvDynamicCasterCount_k__BackingField->fields._paramValue_k__BackingField;
		  punctualLightMovableDynamicCasterCount_k__BackingField = settingParameters->fields._punctualLightMovableDynamicCasterCount_k__BackingField;
		  v302 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !punctualLightMovableDynamicCasterCount_k__BackingField )
		    goto LABEL_1698;
		  v303 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v303->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v303->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v867 = sub_18011C4C0(v302->klass);
		    (**(void (***)(void))(*(_QWORD *)(v867 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v302->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 340) = punctualLightMovableDynamicCasterCount_k__BackingField->fields._paramValue_k__BackingField;
		  punctualLightShadowScreenSizeMin_k__BackingField = settingParameters->fields._punctualLightShadowScreenSizeMin_k__BackingField;
		  v305 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !punctualLightShadowScreenSizeMin_k__BackingField )
		    goto LABEL_1698;
		  v306 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v306->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v306->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v868 = sub_18011C4C0(v305->klass);
		    (**(void (***)(void))(*(_QWORD *)(v868 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v305->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 344) = punctualLightShadowScreenSizeMin_k__BackingField->fields._paramValue_k__BackingField;
		  hdplsCharacterShadowEnabled_k__BackingField = settingParameters->fields._hdplsCharacterShadowEnabled_k__BackingField;
		  v308 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !hdplsCharacterShadowEnabled_k__BackingField )
		    goto LABEL_1698;
		  v309 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v309->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v309->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v869 = sub_18011C4C0(v308->klass);
		    (**(void (***)(void))(*(_QWORD *)(v869 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v308->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 348) = hdplsCharacterShadowEnabled_k__BackingField->fields._paramValue_k__BackingField;
		  hdplsAtlasHeight_k__BackingField = settingParameters->fields._hdplsAtlasHeight_k__BackingField;
		  v311 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !hdplsAtlasHeight_k__BackingField )
		    goto LABEL_1698;
		  v312 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v312->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v312->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v870 = sub_18011C4C0(v311->klass);
		    (**(void (***)(void))(*(_QWORD *)(v870 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v311->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 352) = hdplsAtlasHeight_k__BackingField->fields._paramValue_k__BackingField;
		  hdplsScreenSpaceReduceResolution_k__BackingField = settingParameters->fields._hdplsScreenSpaceReduceResolution_k__BackingField;
		  v314 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !hdplsScreenSpaceReduceResolution_k__BackingField )
		    goto LABEL_1698;
		  v315 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v315->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v315->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v871 = sub_18011C4C0(v314->klass);
		    (**(void (***)(void))(*(_QWORD *)(v871 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v314->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 356) = hdplsScreenSpaceReduceResolution_k__BackingField->fields._paramValue_k__BackingField;
		  hdplsDepthBias_k__BackingField = settingParameters->fields._hdplsDepthBias_k__BackingField;
		  v317 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !hdplsDepthBias_k__BackingField )
		    goto LABEL_1698;
		  v318 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v318->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v318->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v872 = sub_18011C4C0(v317->klass);
		    (**(void (***)(void))(*(_QWORD *)(v872 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v317->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 360) = hdplsDepthBias_k__BackingField->fields._paramValue_k__BackingField;
		  hdplsNormalBias_k__BackingField = settingParameters->fields._hdplsNormalBias_k__BackingField;
		  v320 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !hdplsNormalBias_k__BackingField )
		    goto LABEL_1698;
		  v321 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v321->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v321->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v873 = sub_18011C4C0(v320->klass);
		    (**(void (***)(void))(*(_QWORD *)(v873 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v320->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 364) = hdplsNormalBias_k__BackingField->fields._paramValue_k__BackingField;
		  hdplsSoftness_k__BackingField = settingParameters->fields._hdplsSoftness_k__BackingField;
		  v323 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !hdplsSoftness_k__BackingField )
		    goto LABEL_1698;
		  v324 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v324->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v324->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v874 = sub_18011C4C0(v323->klass);
		    (**(void (***)(void))(*(_QWORD *)(v874 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v323->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 368) = hdplsSoftness_k__BackingField->fields._paramValue_k__BackingField;
		  asmEnabled_k__BackingField = settingParameters->fields._asmEnabled_k__BackingField;
		  v326 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !asmEnabled_k__BackingField )
		    goto LABEL_1698;
		  v327 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v327->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v327->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v875 = sub_18011C4C0(v326->klass);
		    (**(void (***)(void))(*(_QWORD *)(v875 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v326->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 372) = asmEnabled_k__BackingField->fields._paramValue_k__BackingField;
		  asmShadowMapTileResolution_k__BackingField = settingParameters->fields._asmShadowMapTileResolution_k__BackingField;
		  v329 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !asmShadowMapTileResolution_k__BackingField )
		    goto LABEL_1698;
		  v330 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v330->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v330->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v876 = sub_18011C4C0(v329->klass);
		    (**(void (***)(void))(*(_QWORD *)(v876 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v329->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 376) = asmShadowMapTileResolution_k__BackingField->fields._paramValue_k__BackingField;
		  asmMaxDistance_k__BackingField = settingParameters->fields._asmMaxDistance_k__BackingField;
		  v332 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !asmMaxDistance_k__BackingField )
		    goto LABEL_1698;
		  v333 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v333->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v333->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v877 = sub_18011C4C0(v332->klass);
		    (**(void (***)(void))(*(_QWORD *)(v877 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v332->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 380) = asmMaxDistance_k__BackingField->fields._paramValue_k__BackingField;
		  asmMaxTileRenderCountPerFrame_k__BackingField = settingParameters->fields._asmMaxTileRenderCountPerFrame_k__BackingField;
		  v335 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !asmMaxTileRenderCountPerFrame_k__BackingField )
		    goto LABEL_1698;
		  v336 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v336->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v336->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v878 = sub_18011C4C0(v335->klass);
		    (**(void (***)(void))(*(_QWORD *)(v878 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v335->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 384) = asmMaxTileRenderCountPerFrame_k__BackingField->fields._paramValue_k__BackingField;
		  asmDepthBias_k__BackingField = settingParameters->fields._asmDepthBias_k__BackingField;
		  v338 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !asmDepthBias_k__BackingField )
		    goto LABEL_1698;
		  v339 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v339->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v339->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v879 = sub_18011C4C0(v338->klass);
		    (**(void (***)(void))(*(_QWORD *)(v879 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v338->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 388) = asmDepthBias_k__BackingField->fields._paramValue_k__BackingField;
		  asmNormalBias_k__BackingField = settingParameters->fields._asmNormalBias_k__BackingField;
		  v341 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !asmNormalBias_k__BackingField )
		    goto LABEL_1698;
		  v342 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v342->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v342->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v880 = sub_18011C4C0(v341->klass);
		    (**(void (***)(void))(*(_QWORD *)(v880 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v341->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 392) = asmNormalBias_k__BackingField->fields._paramValue_k__BackingField;
		  asmScreenSizeMin_k__BackingField = settingParameters->fields._asmScreenSizeMin_k__BackingField;
		  v344 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !asmScreenSizeMin_k__BackingField )
		    goto LABEL_1698;
		  v345 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v345->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v345->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v881 = sub_18011C4C0(v344->klass);
		    (**(void (***)(void))(*(_QWORD *)(v881 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v344->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 396) = asmScreenSizeMin_k__BackingField->fields._paramValue_k__BackingField;
		  shadowDecalProjectorEnabled_k__BackingField = settingParameters->fields._shadowDecalProjectorEnabled_k__BackingField;
		  v347 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !shadowDecalProjectorEnabled_k__BackingField )
		    goto LABEL_1698;
		  v348 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v348->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v348->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v882 = sub_18011C4C0(v347->klass);
		    (**(void (***)(void))(*(_QWORD *)(v882 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v347->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 400) = shadowDecalProjectorEnabled_k__BackingField->fields._paramValue_k__BackingField;
		  shadowDecalProjectorMaxCount_k__BackingField = settingParameters->fields._shadowDecalProjectorMaxCount_k__BackingField;
		  v350 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !shadowDecalProjectorMaxCount_k__BackingField )
		    goto LABEL_1698;
		  v351 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v351->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v351->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v883 = sub_18011C4C0(v350->klass);
		    (**(void (***)(void))(*(_QWORD *)(v883 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v350->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 404) = shadowDecalProjectorMaxCount_k__BackingField->fields._paramValue_k__BackingField;
		  transientGBuffer_k__BackingField = settingParameters->fields._transientGBuffer_k__BackingField;
		  v353 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !transientGBuffer_k__BackingField )
		    goto LABEL_1698;
		  v354 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v354->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v354->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v884 = sub_18011C4C0(v353->klass);
		    (**(void (***)(void))(*(_QWORD *)(v884 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v353->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 408) = transientGBuffer_k__BackingField->fields._paramValue_k__BackingField;
		  depthBitsGBuffer_k__BackingField = settingParameters->fields._depthBitsGBuffer_k__BackingField;
		  if ( !depthBitsGBuffer_k__BackingField )
		    goto LABEL_1698;
		  *(_DWORD *)(v4 + 412) = depthBitsGBuffer_k__BackingField->fields._paramValue_k__BackingField;
		  depthCombinedWithStencil_k__BackingField = settingParameters->fields._depthCombinedWithStencil_k__BackingField;
		  v357 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !depthCombinedWithStencil_k__BackingField )
		    goto LABEL_1698;
		  v358 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v358->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v358->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v885 = sub_18011C4C0(v357->klass);
		    (**(void (***)(void))(*(_QWORD *)(v885 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v357->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 416) = depthCombinedWithStencil_k__BackingField->fields._paramValue_k__BackingField;
		  copySceneRTScale_k__BackingField = settingParameters->fields._copySceneRTScale_k__BackingField;
		  v360 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !copySceneRTScale_k__BackingField )
		    goto LABEL_1698;
		  v361 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v361->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v361->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v886 = sub_18011C4C0(v360->klass);
		    (**(void (***)(void))(*(_QWORD *)(v886 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v360->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 420) = copySceneRTScale_k__BackingField->fields._paramValue_k__BackingField;
		  taauResolveResolutionHeight_k__BackingField = settingParameters->fields._taauResolveResolutionHeight_k__BackingField;
		  v363 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !taauResolveResolutionHeight_k__BackingField )
		    goto LABEL_1698;
		  v364 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v364->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v364->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v887 = sub_18011C4C0(v363->klass);
		    (**(void (***)(void))(*(_QWORD *)(v887 + 192) + 48LL))();
		  }
		  v365 = v363->klass;
		  if ( ((__int64)v365->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(v365, v6);
		  *(_DWORD *)(v4 + 424) = taauResolveResolutionHeight_k__BackingField->fields._paramValue_k__BackingField;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGUtils->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGUtils);
		  *(float *)(v4 + 428) = HG::Rendering::Runtime::HGUtils::GetRenderingScale(settingParameters, 0LL);
		  backBufferResolutionHeight_k__BackingField = settingParameters->fields._backBufferResolutionHeight_k__BackingField;
		  v367 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !backBufferResolutionHeight_k__BackingField )
		    goto LABEL_1698;
		  v368 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v368->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v368->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v888 = sub_18011C4C0(v367->klass);
		    (**(void (***)(void))(*(_QWORD *)(v888 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v367->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 432) = backBufferResolutionHeight_k__BackingField->fields._paramValue_k__BackingField;
		  textureStreamingEnable_k__BackingField = settingParameters->fields._textureStreamingEnable_k__BackingField;
		  v370 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !textureStreamingEnable_k__BackingField )
		    goto LABEL_1698;
		  v371 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v371->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v371->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v889 = sub_18011C4C0(v370->klass);
		    (**(void (***)(void))(*(_QWORD *)(v889 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v370->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 436) = textureStreamingEnable_k__BackingField->fields._paramValue_k__BackingField;
		  textureStreamingBudget_k__BackingField = settingParameters->fields._textureStreamingBudget_k__BackingField;
		  v373 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !textureStreamingBudget_k__BackingField )
		    goto LABEL_1698;
		  v374 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v374->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v374->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v890 = sub_18011C4C0(v373->klass);
		    (**(void (***)(void))(*(_QWORD *)(v890 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v373->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 440) = textureStreamingBudget_k__BackingField->fields._paramValue_k__BackingField;
		  textureStreamingMaxBudget_k__BackingField = settingParameters->fields._textureStreamingMaxBudget_k__BackingField;
		  v376 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !textureStreamingMaxBudget_k__BackingField )
		    goto LABEL_1698;
		  v377 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v377->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v377->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v891 = sub_18011C4C0(v376->klass);
		    (**(void (***)(void))(*(_QWORD *)(v891 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v376->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 444) = textureStreamingMaxBudget_k__BackingField->fields._paramValue_k__BackingField;
		  reservedMemoryForNonTextureStreaming_k__BackingField = settingParameters->fields._reservedMemoryForNonTextureStreaming_k__BackingField;
		  v379 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !reservedMemoryForNonTextureStreaming_k__BackingField )
		    goto LABEL_1698;
		  v380 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v380->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v380->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v892 = sub_18011C4C0(v379->klass);
		    (**(void (***)(void))(*(_QWORD *)(v892 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v379->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 448) = reservedMemoryForNonTextureStreaming_k__BackingField->fields._paramValue_k__BackingField;
		  textureStreamingMobileBudgetPercent_k__BackingField = settingParameters->fields._textureStreamingMobileBudgetPercent_k__BackingField;
		  v382 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !textureStreamingMobileBudgetPercent_k__BackingField )
		    goto LABEL_1698;
		  v383 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v383->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v383->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v893 = sub_18011C4C0(v382->klass);
		    (**(void (***)(void))(*(_QWORD *)(v893 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v382->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 452) = textureStreamingMobileBudgetPercent_k__BackingField->fields._paramValue_k__BackingField;
		  textureStreamingRendererPerFrame_k__BackingField = settingParameters->fields._textureStreamingRendererPerFrame_k__BackingField;
		  v385 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !textureStreamingRendererPerFrame_k__BackingField )
		    goto LABEL_1698;
		  v386 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v386->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v386->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v894 = sub_18011C4C0(v385->klass);
		    (**(void (***)(void))(*(_QWORD *)(v894 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v385->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 456) = textureStreamingRendererPerFrame_k__BackingField->fields._paramValue_k__BackingField;
		  textureStreamingMaxFileIORequests_k__BackingField = settingParameters->fields._textureStreamingMaxFileIORequests_k__BackingField;
		  v388 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !textureStreamingMaxFileIORequests_k__BackingField )
		    goto LABEL_1698;
		  v389 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v389->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v389->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v895 = sub_18011C4C0(v388->klass);
		    (**(void (***)(void))(*(_QWORD *)(v895 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v388->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 460) = textureStreamingMaxFileIORequests_k__BackingField->fields._paramValue_k__BackingField;
		  contactShadowEnableParam_k__BackingField = settingParameters->fields._contactShadowEnableParam_k__BackingField;
		  v391 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !contactShadowEnableParam_k__BackingField )
		    goto LABEL_1698;
		  v392 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v392->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v392->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v896 = sub_18011C4C0(v391->klass);
		    (**(void (***)(void))(*(_QWORD *)(v896 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v391->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 464) = contactShadowEnableParam_k__BackingField->fields._paramValue_k__BackingField;
		  gtaoEnable_k__BackingField = settingParameters->fields._gtaoEnable_k__BackingField;
		  v394 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !gtaoEnable_k__BackingField )
		    goto LABEL_1698;
		  v395 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v395->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v395->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v897 = sub_18011C4C0(v394->klass);
		    (**(void (***)(void))(*(_QWORD *)(v897 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v394->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 465) = gtaoEnable_k__BackingField->fields._paramValue_k__BackingField;
		  gtaoQualityLevel_k__BackingField = settingParameters->fields._gtaoQualityLevel_k__BackingField;
		  v397 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !gtaoQualityLevel_k__BackingField )
		    goto LABEL_1698;
		  v398 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v398->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v398->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v898 = sub_18011C4C0(v397->klass);
		    (**(void (***)(void))(*(_QWORD *)(v898 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v397->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 468) = gtaoQualityLevel_k__BackingField->fields._paramValue_k__BackingField;
		  ssrEnable_k__BackingField = settingParameters->fields._ssrEnable_k__BackingField;
		  v400 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !ssrEnable_k__BackingField )
		    goto LABEL_1698;
		  v401 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v401->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v401->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v899 = sub_18011C4C0(v400->klass);
		    (**(void (***)(void))(*(_QWORD *)(v899 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v400->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 472) = ssrEnable_k__BackingField->fields._paramValue_k__BackingField;
		  ssrRayMarchingSampleCount_k__BackingField = settingParameters->fields._ssrRayMarchingSampleCount_k__BackingField;
		  v403 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !ssrRayMarchingSampleCount_k__BackingField )
		    goto LABEL_1698;
		  v404 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v404->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v404->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v900 = sub_18011C4C0(v403->klass);
		    (**(void (***)(void))(*(_QWORD *)(v900 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v403->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 476) = ssrRayMarchingSampleCount_k__BackingField->fields._paramValue_k__BackingField;
		  ssrImportanceSample_k__BackingField = settingParameters->fields._ssrImportanceSample_k__BackingField;
		  v406 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !ssrImportanceSample_k__BackingField )
		    goto LABEL_1698;
		  v407 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v407->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v407->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v901 = sub_18011C4C0(v406->klass);
		    (**(void (***)(void))(*(_QWORD *)(v901 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v406->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 480) = ssrImportanceSample_k__BackingField->fields._paramValue_k__BackingField;
		  ssrV2_k__BackingField = settingParameters->fields._ssrV2_k__BackingField;
		  v409 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !ssrV2_k__BackingField )
		    goto LABEL_1698;
		  v410 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v410->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v410->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v902 = sub_18011C4C0(v409->klass);
		    (**(void (***)(void))(*(_QWORD *)(v902 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v409->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 481) = ssrV2_k__BackingField->fields._paramValue_k__BackingField;
		  ssrV2Upsample_k__BackingField = settingParameters->fields._ssrV2Upsample_k__BackingField;
		  v412 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !ssrV2Upsample_k__BackingField )
		    goto LABEL_1698;
		  v413 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v413->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v413->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v903 = sub_18011C4C0(v412->klass);
		    (**(void (***)(void))(*(_QWORD *)(v903 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v412->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 482) = ssrV2Upsample_k__BackingField->fields._paramValue_k__BackingField;
		  terrainFallbackGBuffer_k__BackingField = settingParameters->fields._terrainFallbackGBuffer_k__BackingField;
		  v415 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !terrainFallbackGBuffer_k__BackingField )
		    goto LABEL_1698;
		  v416 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v416->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v416->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v904 = sub_18011C4C0(v415->klass);
		    (**(void (***)(void))(*(_QWORD *)(v904 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v415->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 483) = terrainFallbackGBuffer_k__BackingField->fields._paramValue_k__BackingField;
		  terrainLODFactor_k__BackingField = settingParameters->fields._terrainLODFactor_k__BackingField;
		  v418 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !terrainLODFactor_k__BackingField )
		    goto LABEL_1698;
		  v419 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v419->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v419->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v905 = sub_18011C4C0(v418->klass);
		    (**(void (***)(void))(*(_QWORD *)(v905 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v418->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 484) = terrainLODFactor_k__BackingField->fields._paramValue_k__BackingField;
		  terrainPOM_k__BackingField = settingParameters->fields._terrainPOM_k__BackingField;
		  v421 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !terrainPOM_k__BackingField )
		    goto LABEL_1698;
		  v422 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v422->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v422->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v906 = sub_18011C4C0(v421->klass);
		    (**(void (***)(void))(*(_QWORD *)(v906 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v421->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 488) = terrainPOM_k__BackingField->fields._paramValue_k__BackingField;
		  terrainDeform_k__BackingField = settingParameters->fields._terrainDeform_k__BackingField;
		  if ( !terrainDeform_k__BackingField )
		    goto LABEL_1698;
		  Enable_k__BackingField = terrainDeform_k__BackingField->fields._Enable_k__BackingField;
		  v425 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !Enable_k__BackingField )
		    goto LABEL_1698;
		  v426 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v426->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v426->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v907 = sub_18011C4C0(v425->klass);
		    (**(void (***)(void))(*(_QWORD *)(v907 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v425->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 489) = Enable_k__BackingField->fields._paramValue_k__BackingField;
		  v427 = settingParameters->fields._terrainDeform_k__BackingField;
		  if ( !v427 )
		    goto LABEL_1698;
		  SubdMode_k__BackingField = v427->fields._SubdMode_k__BackingField;
		  v429 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !SubdMode_k__BackingField )
		    goto LABEL_1698;
		  v430 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v430->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v430->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v908 = sub_18011C4C0(v429->klass);
		    (**(void (***)(void))(*(_QWORD *)(v908 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v429->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 492) = SubdMode_k__BackingField->fields._paramValue_k__BackingField;
		  v431 = settingParameters->fields._terrainDeform_k__BackingField;
		  if ( !v431 )
		    goto LABEL_1698;
		  SubdModeV2_k__BackingField = v431->fields._SubdModeV2_k__BackingField;
		  v433 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !SubdModeV2_k__BackingField )
		    goto LABEL_1698;
		  v434 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v434->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v434->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v909 = sub_18011C4C0(v433->klass);
		    (**(void (***)(void))(*(_QWORD *)(v909 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v433->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 496) = SubdModeV2_k__BackingField->fields._paramValue_k__BackingField;
		  v435 = settingParameters->fields._terrainDeform_k__BackingField;
		  if ( !v435 )
		    goto LABEL_1698;
		  GpuSubd_k__BackingField = v435->fields._GpuSubd_k__BackingField;
		  v437 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !GpuSubd_k__BackingField )
		    goto LABEL_1698;
		  v438 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v438->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v438->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v910 = sub_18011C4C0(v437->klass);
		    (**(void (***)(void))(*(_QWORD *)(v910 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v437->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 500) = GpuSubd_k__BackingField->fields._paramValue_k__BackingField;
		  v439 = settingParameters->fields._terrainDeform_k__BackingField;
		  if ( !v439 )
		    goto LABEL_1698;
		  PrimitivePixelLengthTargetLog2_k__BackingField = v439->fields._PrimitivePixelLengthTargetLog2_k__BackingField;
		  v441 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !PrimitivePixelLengthTargetLog2_k__BackingField )
		    goto LABEL_1698;
		  v442 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v442->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v442->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v911 = sub_18011C4C0(v441->klass);
		    (**(void (***)(void))(*(_QWORD *)(v911 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v441->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 504) = PrimitivePixelLengthTargetLog2_k__BackingField->fields._paramValue_k__BackingField;
		  erosionBlend_k__BackingField = settingParameters->fields._erosionBlend_k__BackingField;
		  if ( !erosionBlend_k__BackingField )
		    goto LABEL_1698;
		  v444 = erosionBlend_k__BackingField->fields._Enable_k__BackingField;
		  v445 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !v444 )
		    goto LABEL_1698;
		  v446 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v446->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v446->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v912 = sub_18011C4C0(v445->klass);
		    (**(void (***)(void))(*(_QWORD *)(v912 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v445->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 508) = v444->fields._paramValue_k__BackingField;
		  lightShaft_k__BackingField = settingParameters->fields._lightShaft_k__BackingField;
		  if ( !lightShaft_k__BackingField )
		    goto LABEL_1698;
		  enableLightShaft = lightShaft_k__BackingField->fields.enableLightShaft;
		  v449 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !enableLightShaft )
		    goto LABEL_1698;
		  v450 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v450->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v450->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v913 = sub_18011C4C0(v449->klass);
		    (**(void (***)(void))(*(_QWORD *)(v913 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v449->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 509) = enableLightShaft->fields._paramValue_k__BackingField;
		  v451 = settingParameters->fields._lightShaft_k__BackingField;
		  if ( !v451 )
		    goto LABEL_1698;
		  lightShaftSampleNum = v451->fields.lightShaftSampleNum;
		  v453 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !lightShaftSampleNum )
		    goto LABEL_1698;
		  v454 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v454->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v454->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v914 = sub_18011C4C0(v453->klass);
		    (**(void (***)(void))(*(_QWORD *)(v914 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v453->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 512) = lightShaftSampleNum->fields._paramValue_k__BackingField;
		  v455 = settingParameters->fields._lightShaft_k__BackingField;
		  if ( !v455 )
		    goto LABEL_1698;
		  lightShaftDownSampleFactor = v455->fields.lightShaftDownSampleFactor;
		  v457 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !lightShaftDownSampleFactor )
		    goto LABEL_1698;
		  v458 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v458->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v458->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v915 = sub_18011C4C0(v457->klass);
		    (**(void (***)(void))(*(_QWORD *)(v915 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v457->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 516) = lightShaftDownSampleFactor->fields._paramValue_k__BackingField;
		  v459 = settingParameters->fields._lightShaft_k__BackingField;
		  if ( !v459 )
		    goto LABEL_1698;
		  lightShaftBlurPassCount = v459->fields.lightShaftBlurPassCount;
		  v461 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !lightShaftBlurPassCount )
		    goto LABEL_1698;
		  v462 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v462->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v462->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v916 = sub_18011C4C0(v461->klass);
		    (**(void (***)(void))(*(_QWORD *)(v916 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v461->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 520) = lightShaftBlurPassCount->fields._paramValue_k__BackingField;
		  enableAnamorphicStreaks_k__BackingField = settingParameters->fields._enableAnamorphicStreaks_k__BackingField;
		  v464 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !enableAnamorphicStreaks_k__BackingField )
		    goto LABEL_1698;
		  v465 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v465->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v465->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v917 = sub_18011C4C0(v464->klass);
		    (**(void (***)(void))(*(_QWORD *)(v917 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v464->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 524) = enableAnamorphicStreaks_k__BackingField->fields._paramValue_k__BackingField;
		  anamorphicStreaksDownSampleFactor_k__BackingField = settingParameters->fields._anamorphicStreaksDownSampleFactor_k__BackingField;
		  v467 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !anamorphicStreaksDownSampleFactor_k__BackingField )
		    goto LABEL_1698;
		  v468 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v468->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v468->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v918 = sub_18011C4C0(v467->klass);
		    (**(void (***)(void))(*(_QWORD *)(v918 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v467->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 528) = anamorphicStreaksDownSampleFactor_k__BackingField->fields._paramValue_k__BackingField;
		  *(_BYTE *)(v4 + 532) = 1;
		  rainAndWetness_k__BackingField = settingParameters->fields._rainAndWetness_k__BackingField;
		  if ( !rainAndWetness_k__BackingField )
		    goto LABEL_1698;
		  EnableRainWetnessHighQuality_k__BackingField = rainAndWetness_k__BackingField->fields._EnableRainWetnessHighQuality_k__BackingField;
		  v471 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !EnableRainWetnessHighQuality_k__BackingField )
		    goto LABEL_1698;
		  v472 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v472->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v472->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v919 = sub_18011C4C0(v471->klass);
		    (**(void (***)(void))(*(_QWORD *)(v919 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v471->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 533) = EnableRainWetnessHighQuality_k__BackingField->fields._paramValue_k__BackingField;
		  v473 = settingParameters->fields._rainAndWetness_k__BackingField;
		  if ( !v473 )
		    goto LABEL_1698;
		  RainOcclusionMapSize_k__BackingField = v473->fields._RainOcclusionMapSize_k__BackingField;
		  v475 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !RainOcclusionMapSize_k__BackingField )
		    goto LABEL_1698;
		  v476 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v476->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v476->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v920 = sub_18011C4C0(v475->klass);
		    (**(void (***)(void))(*(_QWORD *)(v920 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v475->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 536) = RainOcclusionMapSize_k__BackingField->fields._paramValue_k__BackingField;
		  v477 = settingParameters->fields._rainAndWetness_k__BackingField;
		  if ( !v477 )
		    goto LABEL_1698;
		  RainOcclusionMapOverrideRange_k__BackingField = v477->fields._RainOcclusionMapOverrideRange_k__BackingField;
		  v479 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !RainOcclusionMapOverrideRange_k__BackingField )
		    goto LABEL_1698;
		  v480 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v480->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v480->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v921 = sub_18011C4C0(v479->klass);
		    (**(void (***)(void))(*(_QWORD *)(v921 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v479->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 540) = RainOcclusionMapOverrideRange_k__BackingField->fields._paramValue_k__BackingField;
		  v481 = settingParameters->fields._rainAndWetness_k__BackingField;
		  if ( !v481 )
		    goto LABEL_1698;
		  RainSplashEnabled_k__BackingField = v481->fields._RainSplashEnabled_k__BackingField;
		  v483 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !RainSplashEnabled_k__BackingField )
		    goto LABEL_1698;
		  v484 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v484->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v484->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v922 = sub_18011C4C0(v483->klass);
		    (**(void (***)(void))(*(_QWORD *)(v922 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v483->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 544) = RainSplashEnabled_k__BackingField->fields._paramValue_k__BackingField;
		  v485 = settingParameters->fields._rainAndWetness_k__BackingField;
		  if ( !v485 )
		    goto LABEL_1698;
		  RainSplashMaxCount_k__BackingField = v485->fields._RainSplashMaxCount_k__BackingField;
		  v487 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !RainSplashMaxCount_k__BackingField )
		    goto LABEL_1698;
		  v488 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v488->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v488->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v923 = sub_18011C4C0(v487->klass);
		    (**(void (***)(void))(*(_QWORD *)(v923 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v487->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 548) = RainSplashMaxCount_k__BackingField->fields._paramValue_k__BackingField;
		  v489 = settingParameters->fields._rainAndWetness_k__BackingField;
		  if ( !v489 )
		    goto LABEL_1698;
		  ScreenRainDropPercent_k__BackingField = v489->fields._ScreenRainDropPercent_k__BackingField;
		  v491 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !ScreenRainDropPercent_k__BackingField )
		    goto LABEL_1698;
		  v492 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v492->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v492->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v924 = sub_18011C4C0(v491->klass);
		    (**(void (***)(void))(*(_QWORD *)(v924 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v491->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 552) = ScreenRainDropPercent_k__BackingField->fields._paramValue_k__BackingField;
		  v493 = settingParameters->fields._rainAndWetness_k__BackingField;
		  if ( !v493 )
		    goto LABEL_1698;
		  EnableMiddleDistRain_k__BackingField = v493->fields._EnableMiddleDistRain_k__BackingField;
		  v495 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !EnableMiddleDistRain_k__BackingField )
		    goto LABEL_1698;
		  v496 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v496->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v496->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v925 = sub_18011C4C0(v495->klass);
		    (**(void (***)(void))(*(_QWORD *)(v925 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v495->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 556) = EnableMiddleDistRain_k__BackingField->fields._paramValue_k__BackingField;
		  v497 = settingParameters->fields._rainAndWetness_k__BackingField;
		  if ( !v497 )
		    goto LABEL_1698;
		  EnableRainWave_k__BackingField = v497->fields._EnableRainWave_k__BackingField;
		  v499 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !EnableRainWave_k__BackingField )
		    goto LABEL_1698;
		  v500 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v500->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v500->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v926 = sub_18011C4C0(v499->klass);
		    (**(void (***)(void))(*(_QWORD *)(v926 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v499->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 557) = EnableRainWave_k__BackingField->fields._paramValue_k__BackingField;
		  v501 = settingParameters->fields._rainAndWetness_k__BackingField;
		  if ( !v501 )
		    goto LABEL_1698;
		  EnableRainLighting_k__BackingField = v501->fields._EnableRainLighting_k__BackingField;
		  v503 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !EnableRainLighting_k__BackingField )
		    goto LABEL_1698;
		  v504 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v504->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v504->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v927 = sub_18011C4C0(v503->klass);
		    (**(void (***)(void))(*(_QWORD *)(v927 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v503->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 558) = EnableRainLighting_k__BackingField->fields._paramValue_k__BackingField;
		  v505 = settingParameters->fields._rainAndWetness_k__BackingField;
		  if ( !v505 )
		    goto LABEL_1698;
		  SceneEffectRainLayerCount_k__BackingField = v505->fields._SceneEffectRainLayerCount_k__BackingField;
		  v507 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !SceneEffectRainLayerCount_k__BackingField )
		    goto LABEL_1698;
		  v508 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v508->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v508->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v928 = sub_18011C4C0(v507->klass);
		    (**(void (***)(void))(*(_QWORD *)(v928 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v507->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 560) = SceneEffectRainLayerCount_k__BackingField->fields._paramValue_k__BackingField;
		  snow_k__BackingField = settingParameters->fields._snow_k__BackingField;
		  if ( !snow_k__BackingField )
		    goto LABEL_1698;
		  EnableSnowLighting_k__BackingField = snow_k__BackingField->fields._EnableSnowLighting_k__BackingField;
		  v511 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !EnableSnowLighting_k__BackingField )
		    goto LABEL_1698;
		  v512 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v512->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v512->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v929 = sub_18011C4C0(v511->klass);
		    (**(void (***)(void))(*(_QWORD *)(v929 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v511->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 564) = EnableSnowLighting_k__BackingField->fields._paramValue_k__BackingField;
		  v513 = settingParameters->fields._snow_k__BackingField;
		  if ( !v513 )
		    goto LABEL_1698;
		  SnowLayerCount_k__BackingField = v513->fields._SnowLayerCount_k__BackingField;
		  v515 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !SnowLayerCount_k__BackingField )
		    goto LABEL_1698;
		  v516 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v516->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v516->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v930 = sub_18011C4C0(v515->klass);
		    (**(void (***)(void))(*(_QWORD *)(v930 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v515->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 568) = SnowLayerCount_k__BackingField->fields._paramValue_k__BackingField;
		  v517 = settingParameters->fields._snow_k__BackingField;
		  if ( !v517 )
		    goto LABEL_1698;
		  EnableSnowCollision_k__BackingField = v517->fields._EnableSnowCollision_k__BackingField;
		  v519 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !EnableSnowCollision_k__BackingField )
		    goto LABEL_1698;
		  v520 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v520->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v520->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v931 = sub_18011C4C0(v519->klass);
		    (**(void (***)(void))(*(_QWORD *)(v931 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v519->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 572) = EnableSnowCollision_k__BackingField->fields._paramValue_k__BackingField;
		  verticalOcclusionMap_k__BackingField = settingParameters->fields._verticalOcclusionMap_k__BackingField;
		  if ( !verticalOcclusionMap_k__BackingField )
		    goto LABEL_1698;
		  DepthOcclusionMapSize_k__BackingField = verticalOcclusionMap_k__BackingField->fields._DepthOcclusionMapSize_k__BackingField;
		  v523 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !DepthOcclusionMapSize_k__BackingField )
		    goto LABEL_1698;
		  v524 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v524->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v524->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v932 = sub_18011C4C0(v523->klass);
		    (**(void (***)(void))(*(_QWORD *)(v932 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v523->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 576) = DepthOcclusionMapSize_k__BackingField->fields._paramValue_k__BackingField;
		  v525 = settingParameters->fields._verticalOcclusionMap_k__BackingField;
		  if ( !v525 )
		    goto LABEL_1698;
		  DepthOcclusionMapRange_k__BackingField = v525->fields._DepthOcclusionMapRange_k__BackingField;
		  v527 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !DepthOcclusionMapRange_k__BackingField )
		    goto LABEL_1698;
		  v528 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v528->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v528->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v933 = sub_18011C4C0(v527->klass);
		    (**(void (***)(void))(*(_QWORD *)(v933 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v527->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 580) = DepthOcclusionMapRange_k__BackingField->fields._paramValue_k__BackingField;
		  atmosphereParams_k__BackingField = settingParameters->fields._atmosphereParams_k__BackingField;
		  if ( !atmosphereParams_k__BackingField )
		    goto LABEL_1698;
		  transmittanceLutSampleCount = atmosphereParams_k__BackingField->fields.transmittanceLutSampleCount;
		  v531 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !transmittanceLutSampleCount )
		    goto LABEL_1698;
		  v532 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v532->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v532->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v934 = sub_18011C4C0(v531->klass);
		    (**(void (***)(void))(*(_QWORD *)(v934 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v531->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 584) = transmittanceLutSampleCount->fields._paramValue_k__BackingField;
		  v533 = settingParameters->fields._atmosphereParams_k__BackingField;
		  if ( !v533 )
		    goto LABEL_1698;
		  transmittanceLutWidth = v533->fields.transmittanceLutWidth;
		  v535 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !transmittanceLutWidth )
		    goto LABEL_1698;
		  v536 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v536->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v536->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v935 = sub_18011C4C0(v535->klass);
		    (**(void (***)(void))(*(_QWORD *)(v935 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v535->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 588) = transmittanceLutWidth->fields._paramValue_k__BackingField;
		  v537 = settingParameters->fields._atmosphereParams_k__BackingField;
		  if ( !v537 )
		    goto LABEL_1698;
		  transmittanceLutHeight = v537->fields.transmittanceLutHeight;
		  v539 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !transmittanceLutHeight )
		    goto LABEL_1698;
		  v540 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v540->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v540->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v936 = sub_18011C4C0(v539->klass);
		    (**(void (***)(void))(*(_QWORD *)(v936 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v539->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 592) = transmittanceLutHeight->fields._paramValue_k__BackingField;
		  v541 = settingParameters->fields._atmosphereParams_k__BackingField;
		  if ( !v541 )
		    goto LABEL_1698;
		  multiScatteredLuminanceLutSampleCount = v541->fields.multiScatteredLuminanceLutSampleCount;
		  v543 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !multiScatteredLuminanceLutSampleCount )
		    goto LABEL_1698;
		  v544 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v544->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v544->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v937 = sub_18011C4C0(v543->klass);
		    (**(void (***)(void))(*(_QWORD *)(v937 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v543->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 596) = multiScatteredLuminanceLutSampleCount->fields._paramValue_k__BackingField;
		  v545 = settingParameters->fields._atmosphereParams_k__BackingField;
		  if ( !v545 )
		    goto LABEL_1698;
		  multiScatteredLuminanceLutHighQuality = v545->fields.multiScatteredLuminanceLutHighQuality;
		  v547 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !multiScatteredLuminanceLutHighQuality )
		    goto LABEL_1698;
		  v548 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v548->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v548->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v938 = sub_18011C4C0(v547->klass);
		    (**(void (***)(void))(*(_QWORD *)(v938 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v547->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 600) = multiScatteredLuminanceLutHighQuality->fields._paramValue_k__BackingField;
		  v549 = settingParameters->fields._atmosphereParams_k__BackingField;
		  if ( !v549 )
		    goto LABEL_1698;
		  multiScatteredLuminanceLutWidth = v549->fields.multiScatteredLuminanceLutWidth;
		  v551 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !multiScatteredLuminanceLutWidth )
		    goto LABEL_1698;
		  v552 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v552->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v552->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v939 = sub_18011C4C0(v551->klass);
		    (**(void (***)(void))(*(_QWORD *)(v939 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v551->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 604) = multiScatteredLuminanceLutWidth->fields._paramValue_k__BackingField;
		  v553 = settingParameters->fields._atmosphereParams_k__BackingField;
		  if ( !v553 )
		    goto LABEL_1698;
		  multiScatteredLuminanceLutHeight = v553->fields.multiScatteredLuminanceLutHeight;
		  v555 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !multiScatteredLuminanceLutHeight )
		    goto LABEL_1698;
		  v556 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v556->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v556->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v940 = sub_18011C4C0(v555->klass);
		    (**(void (***)(void))(*(_QWORD *)(v940 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v555->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 608) = multiScatteredLuminanceLutHeight->fields._paramValue_k__BackingField;
		  v557 = settingParameters->fields._atmosphereParams_k__BackingField;
		  if ( !v557 )
		    goto LABEL_1698;
		  skyViewLutSampleCountMin = v557->fields.skyViewLutSampleCountMin;
		  v559 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !skyViewLutSampleCountMin )
		    goto LABEL_1698;
		  v560 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v560->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v560->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v941 = sub_18011C4C0(v559->klass);
		    (**(void (***)(void))(*(_QWORD *)(v941 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v559->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 612) = skyViewLutSampleCountMin->fields._paramValue_k__BackingField;
		  v561 = settingParameters->fields._atmosphereParams_k__BackingField;
		  if ( !v561 )
		    goto LABEL_1698;
		  skyViewLutSampleCountMax = v561->fields.skyViewLutSampleCountMax;
		  v563 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !skyViewLutSampleCountMax )
		    goto LABEL_1698;
		  v564 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v564->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v564->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v942 = sub_18011C4C0(v563->klass);
		    (**(void (***)(void))(*(_QWORD *)(v942 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v563->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 616) = skyViewLutSampleCountMax->fields._paramValue_k__BackingField;
		  v565 = settingParameters->fields._atmosphereParams_k__BackingField;
		  if ( !v565 )
		    goto LABEL_1698;
		  skyViewLutDistanceToSampleCountMax = v565->fields.skyViewLutDistanceToSampleCountMax;
		  v567 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !skyViewLutDistanceToSampleCountMax )
		    goto LABEL_1698;
		  v568 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v568->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v568->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v943 = sub_18011C4C0(v567->klass);
		    (**(void (***)(void))(*(_QWORD *)(v943 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v567->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 620) = skyViewLutDistanceToSampleCountMax->fields._paramValue_k__BackingField;
		  v569 = settingParameters->fields._atmosphereParams_k__BackingField;
		  if ( !v569 )
		    goto LABEL_1698;
		  skyViewLutWidth = v569->fields.skyViewLutWidth;
		  v571 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !skyViewLutWidth )
		    goto LABEL_1698;
		  v572 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v572->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v572->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v944 = sub_18011C4C0(v571->klass);
		    (**(void (***)(void))(*(_QWORD *)(v944 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v571->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 624) = skyViewLutWidth->fields._paramValue_k__BackingField;
		  v573 = settingParameters->fields._atmosphereParams_k__BackingField;
		  if ( !v573 )
		    goto LABEL_1698;
		  skyViewLutHeight = v573->fields.skyViewLutHeight;
		  v575 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !skyViewLutHeight )
		    goto LABEL_1698;
		  v576 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v576->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v576->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v945 = sub_18011C4C0(v575->klass);
		    (**(void (***)(void))(*(_QWORD *)(v945 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v575->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 628) = skyViewLutHeight->fields._paramValue_k__BackingField;
		  *(_BYTE *)(v4 + 632) = 1;
		  waterPrepassTextureSize_k__BackingField = settingParameters->fields._waterPrepassTextureSize_k__BackingField;
		  v578 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !waterPrepassTextureSize_k__BackingField )
		    goto LABEL_1698;
		  v579 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v579->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v579->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v946 = sub_18011C4C0(v578->klass);
		    (**(void (***)(void))(*(_QWORD *)(v946 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v578->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 636) = waterPrepassTextureSize_k__BackingField->fields._paramValue_k__BackingField;
		  waterInteractiveEnable_k__BackingField = settingParameters->fields._waterInteractiveEnable_k__BackingField;
		  v581 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !waterInteractiveEnable_k__BackingField )
		    goto LABEL_1698;
		  v582 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v582->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v582->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v947 = sub_18011C4C0(v581->klass);
		    (**(void (***)(void))(*(_QWORD *)(v947 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v581->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 640) = waterInteractiveEnable_k__BackingField->fields._paramValue_k__BackingField;
		  waterIndirectEnable_k__BackingField = settingParameters->fields._waterIndirectEnable_k__BackingField;
		  v584 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !waterIndirectEnable_k__BackingField )
		    goto LABEL_1698;
		  v585 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v585->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v585->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v948 = sub_18011C4C0(v584->klass);
		    (**(void (***)(void))(*(_QWORD *)(v948 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v584->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 641) = waterIndirectEnable_k__BackingField->fields._paramValue_k__BackingField;
		  waterVRRx_k__BackingField = settingParameters->fields._waterVRRx_k__BackingField;
		  v587 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !waterVRRx_k__BackingField )
		    goto LABEL_1698;
		  v588 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v588->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v588->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v949 = sub_18011C4C0(v587->klass);
		    (**(void (***)(void))(*(_QWORD *)(v949 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v587->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 644) = waterVRRx_k__BackingField->fields._paramValue_k__BackingField;
		  waterVRRy_k__BackingField = settingParameters->fields._waterVRRy_k__BackingField;
		  v590 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !waterVRRy_k__BackingField )
		    goto LABEL_1698;
		  v591 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v591->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v591->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v950 = sub_18011C4C0(v590->klass);
		    (**(void (***)(void))(*(_QWORD *)(v950 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v590->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 648) = waterVRRy_k__BackingField->fields._paramValue_k__BackingField;
		  waterDisplacementWeight_k__BackingField = settingParameters->fields._waterDisplacementWeight_k__BackingField;
		  v593 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !waterDisplacementWeight_k__BackingField )
		    goto LABEL_1698;
		  v594 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v594->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v594->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v951 = sub_18011C4C0(v593->klass);
		    (**(void (***)(void))(*(_QWORD *)(v951 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v593->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 652) = waterDisplacementWeight_k__BackingField->fields._paramValue_k__BackingField;
		  waterDisplacementDistance_k__BackingField = settingParameters->fields._waterDisplacementDistance_k__BackingField;
		  v596 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !waterDisplacementDistance_k__BackingField )
		    goto LABEL_1698;
		  v597 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v597->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v597->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v952 = sub_18011C4C0(v596->klass);
		    (**(void (***)(void))(*(_QWORD *)(v952 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v596->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 656) = waterDisplacementDistance_k__BackingField->fields._paramValue_k__BackingField;
		  waterHeightTextureSize_k__BackingField = settingParameters->fields._waterHeightTextureSize_k__BackingField;
		  v599 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !waterHeightTextureSize_k__BackingField )
		    goto LABEL_1698;
		  v600 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v600->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v600->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v953 = sub_18011C4C0(v599->klass);
		    (**(void (***)(void))(*(_QWORD *)(v953 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v599->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 660) = waterHeightTextureSize_k__BackingField->fields._paramValue_k__BackingField;
		  artTagLODBiasAll_k__BackingField = settingParameters->fields._artTagLODBiasAll_k__BackingField;
		  v602 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !artTagLODBiasAll_k__BackingField )
		    goto LABEL_1698;
		  v603 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v603->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v603->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v954 = sub_18011C4C0(v602->klass);
		    (**(void (***)(void))(*(_QWORD *)(v954 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v602->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  v604 = 0;
		  *(float *)(v4 + 664) = artTagLODBiasAll_k__BackingField->fields._paramValue_k__BackingField;
		  while ( 1 )
		  {
		    artTagLODBias_k__BackingField = settingParameters->fields._artTagLODBias_k__BackingField;
		    if ( !artTagLODBias_k__BackingField )
		      goto LABEL_1698;
		    if ( v604 >= artTagLODBias_k__BackingField->fields._size )
		      break;
		    if ( (unsigned int)v604 >= artTagLODBias_k__BackingField->fields._size )
		      System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		    items = artTagLODBias_k__BackingField->fields._items;
		    if ( !items )
		      goto LABEL_1698;
		    if ( (unsigned int)v604 >= items->max_length.size )
		      sub_1800D2AB0(s_settingParameters, v6);
		    v607 = items->vector[v604];
		    v608 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		    if ( !v607 )
		      goto LABEL_1698;
		    v609 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		    if ( ((__int64)v609->vtable[0].methodPtr & 1) == 0 )
		      sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		    if ( !*((_QWORD *)v609->rgctx_data[6].rgctxDataDummy + 4) )
		    {
		      v955 = sub_18011C4C0(v608->klass);
		      (**(void (***)(void))(*(_QWORD *)(v955 + 192) + 48LL))();
		    }
		    v610 = v608->klass;
		    if ( ((__int64)v610->vtable[0].methodPtr & 1) == 0 )
		      sub_1800360B0(v610, v6);
		    s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v604++;
		    *(float *)(v4 + 4LL * (_QWORD)s_settingParameters + 668) = v607->fields._paramValue_k__BackingField;
		  }
		  shouldSplitOnePass_k__BackingField = settingParameters->fields._shouldSplitOnePass_k__BackingField;
		  v612 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !shouldSplitOnePass_k__BackingField )
		    goto LABEL_1698;
		  v613 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v613->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v613->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v956 = sub_18011C4C0(v612->klass);
		    (**(void (***)(void))(*(_QWORD *)(v956 + 192) + 48LL))();
		  }
		  v614 = v612->klass;
		  if ( ((__int64)v614->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(v614, v6);
		  *(_BYTE *)(v4 + 924) = shouldSplitOnePass_k__BackingField->fields._paramValue_k__BackingField;
		  v615 = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
		    v615 = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer;
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v615->static_fields->s_settingParameters;
		  if ( !s_settingParameters )
		    goto LABEL_1698;
		  v616 = s_settingParameters[1].s_settingParameters;
		  v617 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !v616 )
		    goto LABEL_1698;
		  v618 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v618->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v618->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v957 = sub_18011C4C0(v617->klass);
		    (**(void (***)(void))(*(_QWORD *)(v957 + 192) + 48LL))();
		  }
		  v619 = v617->klass;
		  if ( ((__int64)v619->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(v619, v6);
		  *(_BYTE *)(v4 + 928) = v616->fields.maxSourceRTWidth;
		  s_settingParameters = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->static_fields;
		  if ( !s_settingParameters->s_settingParameters )
		    goto LABEL_1698;
		  gridPixelSize = s_settingParameters->s_settingParameters->fields.gridPixelSize;
		  v621 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !gridPixelSize )
		    goto LABEL_1698;
		  v622 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v622->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v622->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v958 = sub_18011C4C0(v621->klass);
		    (**(void (***)(void))(*(_QWORD *)(v958 + 192) + 48LL))();
		  }
		  v623 = v621->klass;
		  if ( ((__int64)v623->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(v623, v6);
		  *(_DWORD *)(v4 + 932) = gridPixelSize->fields._paramValue_k__BackingField;
		  s_settingParameters = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->static_fields;
		  if ( !s_settingParameters->s_settingParameters )
		    goto LABEL_1698;
		  gridSizeZ = s_settingParameters->s_settingParameters->fields.gridSizeZ;
		  v625 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !gridSizeZ )
		    goto LABEL_1698;
		  v626 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v626->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v626->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v959 = sub_18011C4C0(v625->klass);
		    (**(void (***)(void))(*(_QWORD *)(v959 + 192) + 48LL))();
		  }
		  v627 = v625->klass;
		  if ( ((__int64)v627->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(v627, v6);
		  *(_DWORD *)(v4 + 936) = gridSizeZ->fields._paramValue_k__BackingField;
		  s_settingParameters = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->static_fields;
		  if ( !s_settingParameters->s_settingParameters )
		    goto LABEL_1698;
		  maxSourceRTWidth = s_settingParameters->s_settingParameters->fields.maxSourceRTWidth;
		  v629 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !maxSourceRTWidth )
		    goto LABEL_1698;
		  v630 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v630->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v630->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v960 = sub_18011C4C0(v629->klass);
		    (**(void (***)(void))(*(_QWORD *)(v960 + 192) + 48LL))();
		  }
		  v631 = v629->klass;
		  if ( ((__int64)v631->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(v631, v6);
		  *(_DWORD *)(v4 + 940) = maxSourceRTWidth->fields._paramValue_k__BackingField;
		  s_settingParameters = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->static_fields;
		  if ( !s_settingParameters->s_settingParameters )
		    goto LABEL_1698;
		  maxSourceRTHeight = s_settingParameters->s_settingParameters->fields.maxSourceRTHeight;
		  v633 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !maxSourceRTHeight )
		    goto LABEL_1698;
		  v634 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v634->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v634->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v961 = sub_18011C4C0(v633->klass);
		    (**(void (***)(void))(*(_QWORD *)(v961 + 192) + 48LL))();
		  }
		  v635 = v633->klass;
		  if ( ((__int64)v635->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(v635, v6);
		  *(_DWORD *)(v4 + 944) = maxSourceRTHeight->fields._paramValue_k__BackingField;
		  s_settingParameters = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->static_fields;
		  if ( !s_settingParameters->s_settingParameters )
		    goto LABEL_1698;
		  depthDistributionScale = s_settingParameters->s_settingParameters->fields.depthDistributionScale;
		  v637 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !depthDistributionScale )
		    goto LABEL_1698;
		  v638 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v638->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v638->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v962 = sub_18011C4C0(v637->klass);
		    (**(void (***)(void))(*(_QWORD *)(v962 + 192) + 48LL))();
		  }
		  v639 = v637->klass;
		  if ( ((__int64)v639->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(v639, v6);
		  *(_DWORD *)(v4 + 948) = depthDistributionScale->fields._paramValue_k__BackingField;
		  s_settingParameters = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->static_fields;
		  if ( !s_settingParameters->s_settingParameters )
		    goto LABEL_1698;
		  historyMissSuperSampleCount = s_settingParameters->s_settingParameters->fields.historyMissSuperSampleCount;
		  v641 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !historyMissSuperSampleCount )
		    goto LABEL_1698;
		  v642 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v642->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v642->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v963 = sub_18011C4C0(v641->klass);
		    (**(void (***)(void))(*(_QWORD *)(v963 + 192) + 48LL))();
		  }
		  v643 = v641->klass;
		  if ( ((__int64)v643->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(v643, v6);
		  *(_DWORD *)(v4 + 952) = historyMissSuperSampleCount->fields._paramValue_k__BackingField;
		  s_settingParameters = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->static_fields;
		  if ( !s_settingParameters->s_settingParameters )
		    goto LABEL_1698;
		  fogHistoryWeight = s_settingParameters->s_settingParameters->fields.fogHistoryWeight;
		  v645 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !fogHistoryWeight )
		    goto LABEL_1698;
		  v646 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v646->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v646->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v964 = sub_18011C4C0(v645->klass);
		    (**(void (***)(void))(*(_QWORD *)(v964 + 192) + 48LL))();
		  }
		  v647 = v645->klass;
		  if ( ((__int64)v647->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(v647, v6);
		  *(float *)(v4 + 956) = fogHistoryWeight->fields._paramValue_k__BackingField;
		  s_settingParameters = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->static_fields;
		  if ( !s_settingParameters->s_settingParameters )
		    goto LABEL_1698;
		  lightScatteringSampleJitterMultiplier = s_settingParameters->s_settingParameters->fields.lightScatteringSampleJitterMultiplier;
		  v649 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !lightScatteringSampleJitterMultiplier )
		    goto LABEL_1698;
		  v650 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v650->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v650->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v965 = sub_18011C4C0(v649->klass);
		    (**(void (***)(void))(*(_QWORD *)(v965 + 192) + 48LL))();
		  }
		  v651 = v649->klass;
		  if ( ((__int64)v651->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(v651, v6);
		  *(float *)(v4 + 960) = lightScatteringSampleJitterMultiplier->fields._paramValue_k__BackingField;
		  s_settingParameters = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->static_fields;
		  if ( !s_settingParameters->s_settingParameters )
		    goto LABEL_1698;
		  upsampleJitterMultiplier = s_settingParameters->s_settingParameters->fields.upsampleJitterMultiplier;
		  v653 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !upsampleJitterMultiplier )
		    goto LABEL_1698;
		  v654 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v654->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v654->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v966 = sub_18011C4C0(v653->klass);
		    (**(void (***)(void))(*(_QWORD *)(v966 + 192) + 48LL))();
		  }
		  v655 = v653->klass;
		  if ( ((__int64)v655->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(v655, v6);
		  *(float *)(v4 + 964) = upsampleJitterMultiplier->fields._paramValue_k__BackingField;
		  s_settingParameters = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->static_fields;
		  if ( !s_settingParameters->s_settingParameters )
		    goto LABEL_1698;
		  enableTemporalReprojection = s_settingParameters->s_settingParameters->fields.enableTemporalReprojection;
		  v657 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !enableTemporalReprojection )
		    goto LABEL_1698;
		  v658 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v658->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v658->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v967 = sub_18011C4C0(v657->klass);
		    (**(void (***)(void))(*(_QWORD *)(v967 + 192) + 48LL))();
		  }
		  v659 = v657->klass;
		  if ( ((__int64)v659->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(v659, v6);
		  *(_BYTE *)(v4 + 968) = enableTemporalReprojection->fields._paramValue_k__BackingField;
		  s_settingParameters = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->static_fields;
		  if ( !s_settingParameters->s_settingParameters )
		    goto LABEL_1698;
		  enablePunctualLightShadow = s_settingParameters->s_settingParameters->fields.enablePunctualLightShadow;
		  v661 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !enablePunctualLightShadow )
		    goto LABEL_1698;
		  v662 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v662->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v662->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v968 = sub_18011C4C0(v661->klass);
		    (**(void (***)(void))(*(_QWORD *)(v968 + 192) + 48LL))();
		  }
		  v663 = v661->klass;
		  if ( ((__int64)v663->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(v663, v6);
		  *(_BYTE *)(v4 + 969) = enablePunctualLightShadow->fields._paramValue_k__BackingField;
		  s_settingParameters = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->static_fields;
		  if ( !s_settingParameters->s_settingParameters )
		    goto LABEL_1698;
		  enableEmissiveVBufferB = s_settingParameters->s_settingParameters->fields.enableEmissiveVBufferB;
		  v665 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !enableEmissiveVBufferB )
		    goto LABEL_1698;
		  v666 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v666->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v666->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v969 = sub_18011C4C0(v665->klass);
		    (**(void (***)(void))(*(_QWORD *)(v969 + 192) + 48LL))();
		  }
		  v667 = v665->klass;
		  if ( ((__int64)v667->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(v667, v6);
		  *(_BYTE *)(v4 + 970) = enableEmissiveVBufferB->fields._paramValue_k__BackingField;
		  s_settingParameters = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->static_fields;
		  if ( !s_settingParameters->s_settingParameters )
		    goto LABEL_1698;
		  enableScalarizeDynamicLightLoop = s_settingParameters->s_settingParameters->fields.enableScalarizeDynamicLightLoop;
		  v669 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !enableScalarizeDynamicLightLoop )
		    goto LABEL_1698;
		  v670 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v670->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v670->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v970 = sub_18011C4C0(v669->klass);
		    (**(void (***)(void))(*(_QWORD *)(v970 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v669->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 971) = enableScalarizeDynamicLightLoop->fields._paramValue_k__BackingField;
		  reflectionProbeUseRGBAHalf_k__BackingField = settingParameters->fields._reflectionProbeUseRGBAHalf_k__BackingField;
		  v672 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !reflectionProbeUseRGBAHalf_k__BackingField )
		    goto LABEL_1698;
		  v673 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v673->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v673->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v971 = sub_18011C4C0(v672->klass);
		    (**(void (***)(void))(*(_QWORD *)(v971 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v672->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 972) = reflectionProbeUseRGBAHalf_k__BackingField->fields._paramValue_k__BackingField;
		  reflectionProbeOctTextureSize_k__BackingField = settingParameters->fields._reflectionProbeOctTextureSize_k__BackingField;
		  v675 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !reflectionProbeOctTextureSize_k__BackingField )
		    goto LABEL_1698;
		  v676 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v676->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v676->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v972 = sub_18011C4C0(v675->klass);
		    (**(void (***)(void))(*(_QWORD *)(v972 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v675->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 976) = reflectionProbeOctTextureSize_k__BackingField->fields._paramValue_k__BackingField;
		  reflectionProbeMaxSampleMip_k__BackingField = settingParameters->fields._reflectionProbeMaxSampleMip_k__BackingField;
		  v678 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !reflectionProbeMaxSampleMip_k__BackingField )
		    goto LABEL_1698;
		  v679 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v679->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v679->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v973 = sub_18011C4C0(v678->klass);
		    (**(void (***)(void))(*(_QWORD *)(v973 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v678->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 980) = reflectionProbeMaxSampleMip_k__BackingField->fields._paramValue_k__BackingField;
		  reflectionProbeMaxBlitCountPerFrame_k__BackingField = settingParameters->fields._reflectionProbeMaxBlitCountPerFrame_k__BackingField;
		  v681 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !reflectionProbeMaxBlitCountPerFrame_k__BackingField )
		    goto LABEL_1698;
		  v682 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v682->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v682->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v974 = sub_18011C4C0(v681->klass);
		    (**(void (***)(void))(*(_QWORD *)(v974 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v681->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 984) = reflectionProbeMaxBlitCountPerFrame_k__BackingField->fields._paramValue_k__BackingField;
		  transparentLowResOffscreenEnable_k__BackingField = settingParameters->fields._transparentLowResOffscreenEnable_k__BackingField;
		  v684 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !transparentLowResOffscreenEnable_k__BackingField )
		    goto LABEL_1698;
		  v685 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v685->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v685->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v975 = sub_18011C4C0(v684->klass);
		    (**(void (***)(void))(*(_QWORD *)(v975 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v684->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 988) = transparentLowResOffscreenEnable_k__BackingField->fields._paramValue_k__BackingField;
		  transparentLowResVRSEnable_k__BackingField = settingParameters->fields._transparentLowResVRSEnable_k__BackingField;
		  v687 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !transparentLowResVRSEnable_k__BackingField )
		    goto LABEL_1698;
		  v688 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v688->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v688->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v976 = sub_18011C4C0(v687->klass);
		    (**(void (***)(void))(*(_QWORD *)(v976 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v687->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 989) = transparentLowResVRSEnable_k__BackingField->fields._paramValue_k__BackingField;
		  transparentVRRx_k__BackingField = settingParameters->fields._transparentVRRx_k__BackingField;
		  v690 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !transparentVRRx_k__BackingField )
		    goto LABEL_1698;
		  v691 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v691->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v691->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v977 = sub_18011C4C0(v690->klass);
		    (**(void (***)(void))(*(_QWORD *)(v977 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v690->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 992) = transparentVRRx_k__BackingField->fields._paramValue_k__BackingField;
		  transparentVRRy_k__BackingField = settingParameters->fields._transparentVRRy_k__BackingField;
		  v693 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !transparentVRRy_k__BackingField )
		    goto LABEL_1698;
		  v694 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v694->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v694->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v978 = sub_18011C4C0(v693->klass);
		    (**(void (***)(void))(*(_QWORD *)(v978 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v693->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 996) = transparentVRRy_k__BackingField->fields._paramValue_k__BackingField;
		  rayTracingReflectionEnable_k__BackingField = settingParameters->fields._rayTracingReflectionEnable_k__BackingField;
		  v696 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !rayTracingReflectionEnable_k__BackingField )
		    goto LABEL_1698;
		  v697 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v697->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v697->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v979 = sub_18011C4C0(v696->klass);
		    (**(void (***)(void))(*(_QWORD *)(v979 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v696->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 1000) = rayTracingReflectionEnable_k__BackingField->fields._paramValue_k__BackingField;
		  rayTracingReflectionMode_k__BackingField = settingParameters->fields._rayTracingReflectionMode_k__BackingField;
		  v699 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !rayTracingReflectionMode_k__BackingField )
		    goto LABEL_1698;
		  v700 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v700->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v700->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v980 = sub_18011C4C0(v699->klass);
		    (**(void (***)(void))(*(_QWORD *)(v980 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v699->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 1004) = rayTracingReflectionMode_k__BackingField->fields._paramValue_k__BackingField;
		  rayTracingReflectionSSQuality0_k__BackingField = settingParameters->fields._rayTracingReflectionSSQuality0_k__BackingField;
		  v702 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !rayTracingReflectionSSQuality0_k__BackingField )
		    goto LABEL_1698;
		  v703 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v703->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v703->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v981 = sub_18011C4C0(v702->klass);
		    (**(void (***)(void))(*(_QWORD *)(v981 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v702->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 1008) = rayTracingReflectionSSQuality0_k__BackingField->fields._paramValue_k__BackingField;
		  rayTracingReflectionSSQuality1_k__BackingField = settingParameters->fields._rayTracingReflectionSSQuality1_k__BackingField;
		  v705 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !rayTracingReflectionSSQuality1_k__BackingField )
		    goto LABEL_1698;
		  v706 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v706->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v706->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v982 = sub_18011C4C0(v705->klass);
		    (**(void (***)(void))(*(_QWORD *)(v982 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v705->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 1012) = rayTracingReflectionSSQuality1_k__BackingField->fields._paramValue_k__BackingField;
		  rayTracingReflectionSSQuality2_k__BackingField = settingParameters->fields._rayTracingReflectionSSQuality2_k__BackingField;
		  v708 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !rayTracingReflectionSSQuality2_k__BackingField )
		    goto LABEL_1698;
		  v709 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v709->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v709->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v983 = sub_18011C4C0(v708->klass);
		    (**(void (***)(void))(*(_QWORD *)(v983 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v708->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 1016) = rayTracingReflectionSSQuality2_k__BackingField->fields._paramValue_k__BackingField;
		  rayTracingReflectionSSQuality3_k__BackingField = settingParameters->fields._rayTracingReflectionSSQuality3_k__BackingField;
		  v711 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !rayTracingReflectionSSQuality3_k__BackingField )
		    goto LABEL_1698;
		  v712 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v712->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v712->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v984 = sub_18011C4C0(v711->klass);
		    (**(void (***)(void))(*(_QWORD *)(v984 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v711->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 1020) = rayTracingReflectionSSQuality3_k__BackingField->fields._paramValue_k__BackingField;
		  rayTracingReflectionRTQuality0_k__BackingField = settingParameters->fields._rayTracingReflectionRTQuality0_k__BackingField;
		  v714 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !rayTracingReflectionRTQuality0_k__BackingField )
		    goto LABEL_1698;
		  v715 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v715->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v715->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v985 = sub_18011C4C0(v714->klass);
		    (**(void (***)(void))(*(_QWORD *)(v985 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v714->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 1024) = rayTracingReflectionRTQuality0_k__BackingField->fields._paramValue_k__BackingField;
		  rayTracingReflectionRTQuality1_k__BackingField = settingParameters->fields._rayTracingReflectionRTQuality1_k__BackingField;
		  v717 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !rayTracingReflectionRTQuality1_k__BackingField )
		    goto LABEL_1698;
		  v718 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v718->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v718->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v986 = sub_18011C4C0(v717->klass);
		    (**(void (***)(void))(*(_QWORD *)(v986 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v717->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 1028) = rayTracingReflectionRTQuality1_k__BackingField->fields._paramValue_k__BackingField;
		  rayTracingReflectionRTQuality2_k__BackingField = settingParameters->fields._rayTracingReflectionRTQuality2_k__BackingField;
		  v720 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !rayTracingReflectionRTQuality2_k__BackingField )
		    goto LABEL_1698;
		  v721 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v721->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v721->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v987 = sub_18011C4C0(v720->klass);
		    (**(void (***)(void))(*(_QWORD *)(v987 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v720->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 1032) = rayTracingReflectionRTQuality2_k__BackingField->fields._paramValue_k__BackingField;
		  rayTracingReflectionRTQuality3_k__BackingField = settingParameters->fields._rayTracingReflectionRTQuality3_k__BackingField;
		  v723 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !rayTracingReflectionRTQuality3_k__BackingField )
		    goto LABEL_1698;
		  v724 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v724->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v724->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v988 = sub_18011C4C0(v723->klass);
		    (**(void (***)(void))(*(_QWORD *)(v988 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v723->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 1036) = rayTracingReflectionRTQuality3_k__BackingField->fields._paramValue_k__BackingField;
		  frameInterpolationEnable_k__BackingField = settingParameters->fields._frameInterpolationEnable_k__BackingField;
		  v726 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !frameInterpolationEnable_k__BackingField )
		    goto LABEL_1698;
		  v727 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v727->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v727->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v989 = sub_18011C4C0(v726->klass);
		    (**(void (***)(void))(*(_QWORD *)(v989 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v726->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 1040) = frameInterpolationEnable_k__BackingField->fields._paramValue_k__BackingField;
		  frameInterpolationPause_k__BackingField = settingParameters->fields._frameInterpolationPause_k__BackingField;
		  v729 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !frameInterpolationPause_k__BackingField )
		    goto LABEL_1698;
		  v730 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v730->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v730->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v990 = sub_18011C4C0(v729->klass);
		    (**(void (***)(void))(*(_QWORD *)(v990 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v729->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 1041) = frameInterpolationPause_k__BackingField->fields._paramValue_k__BackingField;
		  frameInterpolationAlgo_k__BackingField = settingParameters->fields._frameInterpolationAlgo_k__BackingField;
		  v732 = MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::HyperGryphEngineCode::FrameInterpolationAlgo>::op_Implicit;
		  if ( !frameInterpolationAlgo_k__BackingField )
		    goto LABEL_1698;
		  v733 = MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::HyperGryphEngineCode::FrameInterpolationAlgo>::op_Implicit->klass;
		  if ( ((__int64)v733->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(
		      MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::HyperGryphEngineCode::FrameInterpolationAlgo>::op_Implicit->klass,
		      v6);
		  if ( !*((_QWORD *)v733->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v991 = sub_18011C4C0(v732->klass);
		    (**(void (***)(void))(*(_QWORD *)(v991 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v732->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 1044) = frameInterpolationAlgo_k__BackingField->fields._paramValue_k__BackingField;
		  hasWorldUIAfterFrameInterpolation_k__BackingField = settingParameters->fields._hasWorldUIAfterFrameInterpolation_k__BackingField;
		  v735 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !hasWorldUIAfterFrameInterpolation_k__BackingField )
		    goto LABEL_1698;
		  v736 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v736->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v736->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v992 = sub_18011C4C0(v735->klass);
		    (**(void (***)(void))(*(_QWORD *)(v992 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v735->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_BYTE *)(v4 + 1048) = hasWorldUIAfterFrameInterpolation_k__BackingField->fields._paramValue_k__BackingField;
		  afmeCameraRotationCosFallbackThreshold_k__BackingField = settingParameters->fields._afmeCameraRotationCosFallbackThreshold_k__BackingField;
		  v738 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !afmeCameraRotationCosFallbackThreshold_k__BackingField )
		    goto LABEL_1698;
		  v739 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v739->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v739->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v993 = sub_18011C4C0(v738->klass);
		    (**(void (***)(void))(*(_QWORD *)(v993 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v738->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 1052) = afmeCameraRotationCosFallbackThreshold_k__BackingField->fields._paramValue_k__BackingField;
		  afmeCameraMoveDistanceSqrFallbackThreshold_k__BackingField = settingParameters->fields._afmeCameraMoveDistanceSqrFallbackThreshold_k__BackingField;
		  v741 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !afmeCameraMoveDistanceSqrFallbackThreshold_k__BackingField )
		    goto LABEL_1698;
		  v742 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v742->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v742->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v994 = sub_18011C4C0(v741->klass);
		    (**(void (***)(void))(*(_QWORD *)(v994 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v741->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 1056) = afmeCameraMoveDistanceSqrFallbackThreshold_k__BackingField->fields._paramValue_k__BackingField;
		  mfrcCameraRotationCosFallbackThreshold_k__BackingField = settingParameters->fields._mfrcCameraRotationCosFallbackThreshold_k__BackingField;
		  v744 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !mfrcCameraRotationCosFallbackThreshold_k__BackingField )
		    goto LABEL_1698;
		  v745 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v745->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v745->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v995 = sub_18011C4C0(v744->klass);
		    (**(void (***)(void))(*(_QWORD *)(v995 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v744->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 1060) = mfrcCameraRotationCosFallbackThreshold_k__BackingField->fields._paramValue_k__BackingField;
		  mfrcCameraMoveDistanceSqrFallbackThreshold_k__BackingField = settingParameters->fields._mfrcCameraMoveDistanceSqrFallbackThreshold_k__BackingField;
		  v747 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !mfrcCameraMoveDistanceSqrFallbackThreshold_k__BackingField )
		    goto LABEL_1698;
		  v748 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v748->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v748->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v996 = sub_18011C4C0(v747->klass);
		    (**(void (***)(void))(*(_QWORD *)(v996 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v747->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 1064) = mfrcCameraMoveDistanceSqrFallbackThreshold_k__BackingField->fields._paramValue_k__BackingField;
		  mfrcGeneralFallbackThreshold_k__BackingField = settingParameters->fields._mfrcGeneralFallbackThreshold_k__BackingField;
		  v750 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !mfrcGeneralFallbackThreshold_k__BackingField )
		    goto LABEL_1698;
		  v751 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v751->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v751->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v997 = sub_18011C4C0(v750->klass);
		    (**(void (***)(void))(*(_QWORD *)(v997 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v750->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 1068) = mfrcGeneralFallbackThreshold_k__BackingField->fields._paramValue_k__BackingField;
		  mfrcBrightnessDiffFallbackThreshold_k__BackingField = settingParameters->fields._mfrcBrightnessDiffFallbackThreshold_k__BackingField;
		  v753 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !mfrcBrightnessDiffFallbackThreshold_k__BackingField )
		    goto LABEL_1698;
		  v754 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v754->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v754->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v998 = sub_18011C4C0(v753->klass);
		    (**(void (***)(void))(*(_QWORD *)(v998 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v753->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 1072) = mfrcBrightnessDiffFallbackThreshold_k__BackingField->fields._paramValue_k__BackingField;
		  mfrcRepeatedPatternFallbackThreshold_k__BackingField = settingParameters->fields._mfrcRepeatedPatternFallbackThreshold_k__BackingField;
		  v756 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !mfrcRepeatedPatternFallbackThreshold_k__BackingField )
		    goto LABEL_1698;
		  v757 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v757->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v757->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v999 = sub_18011C4C0(v756->klass);
		    (**(void (***)(void))(*(_QWORD *)(v999 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v756->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(float *)(v4 + 1076) = mfrcRepeatedPatternFallbackThreshold_k__BackingField->fields._paramValue_k__BackingField;
		  inkSimulationResolution_k__BackingField = settingParameters->fields._inkSimulationResolution_k__BackingField;
		  v759 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !inkSimulationResolution_k__BackingField )
		    goto LABEL_1698;
		  v760 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v760->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v760->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v1000 = sub_18011C4C0(v759->klass);
		    (**(void (***)(void))(*(_QWORD *)(v1000 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v759->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 1080) = inkSimulationResolution_k__BackingField->fields._paramValue_k__BackingField;
		  inkDensityResolution_k__BackingField = settingParameters->fields._inkDensityResolution_k__BackingField;
		  v762 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  if ( !inkDensityResolution_k__BackingField )
		    goto LABEL_1698;
		  v763 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v763->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v763->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v1001 = sub_18011C4C0(v762->klass);
		    (**(void (***)(void))(*(_QWORD *)(v1001 + 192) + 48LL))();
		  }
		  s_settingParameters = (HGVolumetricFogRenderer__StaticFields *)v762->klass;
		  if ( ((__int64)s_settingParameters[19].s_voxelizationMaterialPropertyBlock & 1) == 0 )
		    sub_1800360B0(s_settingParameters, v6);
		  *(_DWORD *)(v4 + 1084) = inkDensityResolution_k__BackingField->fields._paramValue_k__BackingField;
		  inkSimulationEnable_k__BackingField = settingParameters->fields._inkSimulationEnable_k__BackingField;
		  v765 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !inkSimulationEnable_k__BackingField )
		LABEL_1698:
		    sub_1800D8260(s_settingParameters, v6);
		  v766 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v766->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, v6);
		  if ( !*((_QWORD *)v766->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v1002 = sub_18011C4C0(v765->klass);
		    (**(void (***)(void))(*(_QWORD *)(v1002 + 192) + 48LL))();
		  }
		  v767 = v765->klass;
		  if ( ((__int64)v767->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(v767, v6);
		  *(_BYTE *)(v4 + 1088) = inkSimulationEnable_k__BackingField->fields._paramValue_k__BackingField;
		  return (HGSettingParametersCpp *)v4;
		}
		
		public static unsafe HGDebugRenderManagerCPP* ConvertHGDebugRenderManagerToCPP() => default; // 0x00000001811EC580-0x00000001811EC590
		// RuntimePhysicGroupData& NullRef[RuntimePhysicGroupData]()
		RuntimePhysicGroupData *System::Runtime::CompilerServices::Unsafe::NullRef<Beyond::Gameplay::Core::DynamicScene::RuntimePhysicGroupData>(
		        MethodInfo *method)
		{
		  return 0LL;
		}
		
		public static unsafe HGDebugFeaturesManagerCPP* ConvertHGDebugFeatureManagerToCPP() => default; // 0x00000001811EC580-0x00000001811EC590
		// RuntimePhysicGroupData& NullRef[RuntimePhysicGroupData]()
		RuntimePhysicGroupData *System::Runtime::CompilerServices::Unsafe::NullRef<Beyond::Gameplay::Core::DynamicScene::RuntimePhysicGroupData>(
		        MethodInfo *method)
		{
		  return 0LL;
		}
		
		public static unsafe HGLightConfigCPP* ConvertLightConfigToCpp([IsReadOnly] in HGLightConfig src) => default; // 0x0000000183B5A850-0x0000000183B5A9C0
		// HGLightConfigCPP* ConvertLightConfigToCpp(HGLightConfig ByRef)
		HGLightConfigCPP *HG::Rendering::Runtime::HGUtilsCpp::ConvertLightConfigToCpp(HGLightConfig *src, MethodInfo *method)
		{
		  __int64 (__fastcall *v2)(__int64, MethodInfo *); // rax
		  __int64 v4; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  float y; // xmm0_4
		  float z; // eax
		  __int128 v9; // xmm1
		  __int128 v10; // xmm2
		  __int128 v11; // xmm3
		  HGLightConfigCPP *result; // rax
		  __int64 v13; // rax
		
		  v2 = (__int64 (__fastcall *)(__int64, MethodInfo *))qword_18F370618;
		  if ( !qword_18F370618 )
		  {
		    v2 = (__int64 (__fastcall *)(__int64, MethodInfo *))il2cpp_resolve_icall_1(
		                                                          "UnityEngine.HyperGryphEngineCode.HGRenderGraphCPP::AllocateTem"
		                                                          "pFromCSharp(System.Int64)");
		    if ( !v2 )
		    {
		      v13 = sub_1802EE1B8("UnityEngine.HyperGryphEngineCode.HGRenderGraphCPP::AllocateTempFromCSharp(System.Int64)");
		      sub_18007E1B0(v13, 0LL);
		    }
		    qword_18F370618 = (__int64)v2;
		  }
		  v4 = v2(248LL, method);
		  v6 = v4;
		  if ( !v4 )
		    sub_1800D8260(0LL, v5);
		  *(float *)v4 = src->preExposure;
		  *(Color *)(v4 + 4) = src->directColor;
		  *(float *)(v4 + 20) = src->directIntensity;
		  y = src->directPitchYawRuntime.y;
		  *(float *)(v4 + 32) = src->directPitchYawRuntime.x;
		  *(float *)(v4 + 36) = y;
		  *(float *)(v4 + 40) = src->indirectDiffuseFactor;
		  *(float *)(v4 + 44) = src->indirectSpecularFactor;
		  *(Quaternion *)(v4 + 48) = src->rotationDirect;
		  z = src->forwardDirect.z;
		  *(_QWORD *)(v6 + 64) = *(_QWORD *)&src->forwardDirect.x;
		  *(float *)(v6 + 72) = z;
		  v9 = *(_OWORD *)&src->localToWorld.m01;
		  v10 = *(_OWORD *)&src->localToWorld.m02;
		  v11 = *(_OWORD *)&src->localToWorld.m03;
		  *(_OWORD *)(v6 + 76) = *(_OWORD *)&src->localToWorld.m00;
		  *(_OWORD *)(v6 + 92) = v9;
		  *(_OWORD *)(v6 + 108) = v10;
		  *(_OWORD *)(v6 + 124) = v11;
		  *(Quaternion *)(v6 + 140) = src->rotationAtmosphere;
		  *(Quaternion *)(v6 + 156) = src->rotationLightShaft;
		  *(Quaternion *)(v6 + 172) = src->rotationSunDisc;
		  *(Quaternion *)(v6 + 188) = src->rotationLensFlare;
		  *(Quaternion *)(v6 + 204) = src->rotationCloudShadow;
		  *(Quaternion *)(v6 + 220) = src->rotationHeightFogDirectionalInscattering;
		  *(_DWORD *)(v6 + 236) = src->cloudShadowPitchYawMode;
		  result = (HGLightConfigCPP *)v6;
		  *(float *)&v9 = src->cloudShadowPitchYaw.y;
		  *(float *)(v6 + 240) = src->cloudShadowPitchYaw.x;
		  *(_DWORD *)(v6 + 244) = v9;
		  *(float *)(v6 + 24) = src->directSpecularIntensity;
		  *(float *)(v6 + 28) = src->directSoftSourceRadius;
		  return result;
		}
		
		public static unsafe HGShadowConfigCPP* ConvertShadowConfigToCpp(HGShadowConfig src) => default; // 0x0000000182EDC8F0-0x0000000182EDCAF0
		// HGShadowConfigCPP* ConvertShadowConfigToCpp(HGShadowConfig)
		HGShadowConfigCPP *HG::Rendering::Runtime::HGUtilsCpp::ConvertShadowConfigToCpp(
		        HGShadowConfig *src,
		        MethodInfo *method)
		{
		  HGSnowRendererInputCPP *v3; // rax
		  __int64 v4; // rdx
		  struct Object_1__Class *v5; // rcx
		  HGSnowRendererInputCPP *v6; // rdi
		  __m128i v7; // xmm2
		  unsigned __int64 v8; // rsi
		  Texture2D *csmRampTexture; // rax
		  __int128 v10; // xmm2
		  __m128i v11; // xmm0
		  __m128i v12; // xmm3
		  float rhodesShipRadius; // xmm1_4
		  __m128i v14; // xmm2
		  char v15; // al
		  __m128i v16; // xmm2
		  char v17; // al
		  __m128i v18; // xmm2
		  char v19; // al
		  __m128i v20; // xmm2
		  int v21; // eax
		  __m128i v22; // xmm2
		  __m128i v23; // xmm2
		  HGShadowConfigCPP *result; // rax
		
		  v3 = UnityEngine::HyperGryphEngineCode::HGRenderGraphCPP::AllocateTempFromCSharp<UnityEngine::HyperGryphEngineCode::HGSnowRendererInputCPP>(MethodInfo::UnityEngine::HyperGryphEngineCode::HGRenderGraphCPP::AllocateTempFromCSharp<UnityEngine::HyperGryphEngineCode::HGShadowConfigCPP>);
		  v6 = v3;
		  if ( !v3 )
		    goto LABEL_9;
		  v3->enable = LODWORD(src->csmDepthBiasV2);
		  v3->intensity = src->csmNormalBiasV2;
		  v7 = *(__m128i *)&src->csmIntensity;
		  LODWORD(v3->speed.x) = v7.m128i_i32[0];
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
		  v8 = _mm_srli_si128(v7, 8).m128i_u64[0];
		  if ( v8 )
		  {
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(v5);
		    if ( *(_QWORD *)(v8 + 16) )
		    {
		      csmRampTexture = src->csmRampTexture;
		      if ( csmRampTexture )
		        goto LABEL_8;
		LABEL_9:
		      sub_1800D8260(v5, v4);
		    }
		  }
		  csmRampTexture = UnityEngine::Texture2D::get_blackTexture(0LL);
		  if ( !csmRampTexture )
		    goto LABEL_9;
		LABEL_8:
		  v10 = *(_OWORD *)&src->csmShadowSoftness;
		  *(_QWORD *)&v6->color.x = csmRampTexture->fields._._.m_CachedPtr;
		  v11 = _mm_cvtsi32_si128(src->contactShadowContract);
		  v12 = *(__m128i *)&src->overrideCsmSpherePosition.z;
		  rhodesShipRadius = src->rhodesShipRadius;
		  LODWORD(v6->color.z) = v10;
		  v6->color.w = src->asmCasterMinY;
		  v6->snowDirection.x = src->asmCasterMaxY;
		  v6->snowDirection.y = src->contactShadowIntensity;
		  LODWORD(v6->snowDirection.z) = *(_OWORD *)&src->contactShadowSurfaceThickness;
		  v6->snowJitterLevel = src->contactShadowBilinearThreshold;
		  v14 = *(__m128i *)&src->contactShadowSurfaceThickness;
		  LODWORD(v6->snowSpeedNoiseLevel) = _mm_cvtepi32_ps(v11).m128_u32[0];
		  v11.m128i_i64[0] = *(_QWORD *)&src->rhodesShipCenter.x;
		  v15 = _mm_cvtsi128_si32(_mm_srli_si128(v14, 12));
		  v16 = *(__m128i *)&src->contactShadowSurfaceThickness;
		  LOBYTE(v6->snowSpeedNoiseFreq) = v15;
		  v17 = _mm_cvtsi128_si32(_mm_srli_si128(v16, 13));
		  v18 = *(__m128i *)&src->overrideCsmFarDistance;
		  BYTE1(v6->snowSpeedNoiseFreq) = v17;
		  LODWORD(v6->snowTrailLength) = v18.m128i_i32[0];
		  v19 = _mm_cvtsi128_si32(_mm_srli_si128(v18, 4));
		  *(_QWORD *)&v6->snowSizeRange.y = *(_QWORD *)&src->overrideCsmSpherePosition.x;
		  v6->maxSnowHeight = src->overrideCsmSphereRadius;
		  v6->snowRange = src->disableCsmBlendFactor;
		  v20 = *(__m128i *)&src->csmSimulatedAttenuation;
		  LOBYTE(v6->snowSizeRange.x) = v19;
		  v21 = *(_DWORD *)&src->disableCsm;
		  LODWORD(v6->maxMoveDirectionLength) = v20.m128i_i32[0];
		  LOBYTE(v6->snowMaxUVFlowSpeed) = v21;
		  LOBYTE(v21) = _mm_cvtsi128_si32(_mm_srli_si128(v20, 4));
		  v22 = *(__m128i *)&src->csmSimulatedAttenuation;
		  LOBYTE(v6->snowTemporalTimeThreshold) = v21;
		  LOBYTE(v21) = _mm_cvtsi128_si32(_mm_srli_si128(v22, 5));
		  v23 = *(__m128i *)&src->rhodesShipCenter.z;
		  BYTE1(v6->snowTemporalTimeThreshold) = v21;
		  result = (HGShadowConfigCPP *)v6;
		  *(_QWORD *)&v6->snowflakeTex_ST.x = v11.m128i_i64[0];
		  LODWORD(v6->snowflakeTex_ST.z) = _mm_cvtsi128_si32(v23);
		  v6->snowflakeTex_ST.w = rhodesShipRadius;
		  LODWORD(v6->snowCollisionFadeTimeScale) = _mm_cvtsi128_si32(v12);
		  return result;
		}
		
		public static unsafe HGHeightFogConfigCPP* ConvertHeightFogConfigToCpp([IsReadOnly] in HGHeightFogConfig src) => default; // 0x0000000182CB8C70-0x0000000182CB8E40
		// HGHeightFogConfigCPP* ConvertHeightFogConfigToCpp(HGHeightFogConfig ByRef)
		HGHeightFogConfigCPP *HG::Rendering::Runtime::HGUtilsCpp::ConvertHeightFogConfigToCpp(
		        HGHeightFogConfig *src,
		        MethodInfo *method)
		{
		  __int64 (__fastcall *v2)(__int64, MethodInfo *); // rax
		  __int64 v4; // rax
		  __int64 v5; // rcx
		  __int64 v6; // rdx
		  float z; // eax
		  __int64 v9; // rax
		
		  v2 = (__int64 (__fastcall *)(__int64, MethodInfo *))qword_18F370618;
		  if ( !qword_18F370618 )
		  {
		    v2 = (__int64 (__fastcall *)(__int64, MethodInfo *))il2cpp_resolve_icall_1(
		                                                          "UnityEngine.HyperGryphEngineCode.HGRenderGraphCPP::AllocateTem"
		                                                          "pFromCSharp(System.Int64)");
		    if ( !v2 )
		    {
		      v9 = sub_1802EE1B8("UnityEngine.HyperGryphEngineCode.HGRenderGraphCPP::AllocateTempFromCSharp(System.Int64)");
		      sub_18007E1B0(v9, 0LL);
		    }
		    qword_18F370618 = (__int64)v2;
		  }
		  v4 = v2(216LL, method);
		  v6 = v4;
		  if ( !v4 )
		    sub_1800D8250(v5, 0LL);
		  *(_BYTE *)v4 = src->enable;
		  *(float *)(v4 + 4) = src->heightFogStartHeight;
		  *(float *)(v4 + 8) = src->heightFogDensity;
		  *(float *)(v4 + 12) = src->heightFogFalloff;
		  *(float *)(v4 + 16) = src->heightFogStartHeightSecond;
		  *(float *)(v4 + 20) = src->heightFogDensitySecond;
		  *(float *)(v4 + 24) = src->heightFogFalloffSecond;
		  *(Color *)(v4 + 28) = src->heightFogInscatter;
		  *(float *)(v4 + 44) = src->heightFogMaxOpacity;
		  *(float *)(v4 + 48) = src->heightFogStartDistance;
		  *(float *)(v4 + 52) = src->heightFogStartTransition;
		  *(float *)(v4 + 56) = src->heightFogCutoffDistance;
		  *(float *)(v4 + 60) = src->heightFogCutoffTransition;
		  *(float *)(v4 + 64) = src->heightFogCullingFarClipPlane;
		  *(float *)(v4 + 68) = src->heightFogDirectionalInscatteringExponent;
		  *(float *)(v4 + 72) = src->heightFogDirectionalInscatteringStartDistance;
		  *(Color *)(v4 + 76) = src->heightFogDirectionalInscattering;
		  *(float *)(v4 + 92) = src->heightFogDirectionalInscatteringExponentMobile * 0.2;
		  *(Color *)(v4 + 96) = src->heightFogDirectionalInscatteringMobile;
		  *(_BYTE *)(v4 + 112) = src->enableVolumetricFog;
		  *(float *)(v4 + 116) = src->volumetricFogScatteringDistribution;
		  *(Color *)(v4 + 120) = src->volumetricFogAlbedo;
		  *(Color *)(v4 + 136) = src->volumetricFogEmissive;
		  *(float *)(v4 + 152) = src->volumetricFogExtinctionScale;
		  *(float *)(v4 + 156) = src->volumetricFogDistance;
		  *(float *)(v4 + 160) = src->volumetricFogStartDistance;
		  *(float *)(v4 + 164) = src->volumetricFogNearFadeInDistance;
		  *(float *)(v4 + 168) = src->volumetricFogDirectLightingScatteringIntensity;
		  *(float *)(v4 + 172) = src->volumetricFogSkyLightingScatteringIntensity;
		  *(_BYTE *)(v4 + 176) = src->enableFlowNoise;
		  *(float *)(v4 + 180) = src->flowNoiseIntensity;
		  *(float *)(v4 + 184) = src->flowNoiseDistance;
		  *(float *)(v4 + 188) = src->flowNoiseTilling;
		  *(float *)(v4 + 192) = src->flowNoiseHorizontalDirAngle;
		  *(float *)(v4 + 196) = src->flowNoiseVerticalDirAngle;
		  z = src->flowNoiseDir.z;
		  *(_QWORD *)(v6 + 200) = *(_QWORD *)&src->flowNoiseDir.x;
		  *(float *)(v6 + 208) = z;
		  *(float *)(v6 + 212) = src->flowNoiseSpeed;
		  return (HGHeightFogConfigCPP *)v6;
		}
		
		public static unsafe void ConvertVignetteToCPP(VignetteCPP* dst, Vignette src) {} // 0x00000001831B9F30-0x00000001831BAAC0
		// Void ConvertVignetteToCPP(VignetteCPP*, Vignette)
		void HG::Rendering::Runtime::HGUtilsCpp::ConvertVignetteToCPP(VignetteCPP *dst, Vignette *src, MethodInfo *method)
		{
		  Vignette *v3; // rdi
		  VignetteCPP *v4; // rbx
		  int32_t v5; // eax
		  ColorParameter *color; // rsi
		  Vector2Parameter *center; // rsi
		  float v8; // xmm6_4
		  const MethodInfo *v9; // r8
		  Vector2 v10; // rax
		  __m128 v11; // xmm1
		  ClampedFloatParameter *intensity; // rsi
		  const MethodInfo *v13; // r8
		  float a; // xmm0_4
		  ClampedFloatParameter *smoothness; // rsi
		  const MethodInfo *v16; // r8
		  float v17; // xmm0_4
		  ClampedFloatParameter *roundness; // rsi
		  const MethodInfo *v19; // r8
		  float v20; // xmm0_4
		  VignetteCPP **rounded; // rsi
		  bool (*v22)(RuntimeType *, MethodInfo *); // r8
		  char v23; // al
		  VignetteCPP **blink; // rsi
		  bool (*v25)(RuntimeType *, MethodInfo *); // r8
		  __int64 v26; // rdx
		  char v27; // al
		  __int64 v28; // rax
		  __int64 v29; // rsi
		  void *v30; // rax
		  ClampedFloatParameter *opacity; // rdi
		  float (*v32)(AbilitySystem *, MethodInfo *); // r8
		  double v33; // xmm0_8
		  VignetteCPP *v34; // rax
		  char v35; // al
		  VignetteCPP *v36; // rax
		  char v37; // al
		  __int64 v38; // rax
		  __int64 v39; // rax
		  VignetteCPP *v40; // rax
		  VignetteCPP *v41; // rax
		  __int64 v42; // rax
		  __int64 v43; // rax
		  __int64 v44; // rax
		  __int64 v45; // rax
		  __m128 x_low; // xmm0
		  __m128 y_low; // xmm1
		  ILFixDynamicMethodWrapper *Patch; // rax
		  ILFixDynamicMethodWrapper *v49; // rax
		  ILFixDynamicMethodWrapper *v50; // rax
		  ILFixDynamicMethodWrapper_3 *v51; // rax
		  ILFixDynamicMethodWrapper *v52; // rax
		  ILFixDynamicMethodWrapper_3 *v53; // rax
		  ILFixDynamicMethodWrapper *v54; // rax
		  ILFixDynamicMethodWrapper_3 *v55; // rax
		  __int64 v56; // rax
		  ILFixDynamicMethodWrapper *v57; // rax
		  ILFixDynamicMethodWrapper_3 *v58; // rax
		  char v59[16]; // [rsp+20h] [rbp-48h] BYREF
		  Vector2 v60; // [rsp+70h] [rbp+8h]
		
		  v3 = src;
		  v4 = dst;
		  if ( !src )
		    goto LABEL_107;
		  src = (Vignette *)src->fields.mode;
		  if ( !src )
		    goto LABEL_107;
		  v5 = sub_180002F70(10LL, src);
		  if ( !v4 )
		    goto LABEL_107;
		  v4->mode = v5;
		  color = v3->fields.color;
		  if ( !color )
		    goto LABEL_107;
		  sub_1800049A0(color->klass);
		  v4->color = *(Color *)((__int64 (__fastcall *)(char *, ColorParameter *, Il2CppMethodPointer))color->klass->vtable.get_value.method)(
		                          v59,
		                          color,
		                          color->klass->vtable.set_value.methodPtr);
		  center = v3->fields.center;
		  if ( !center )
		    goto LABEL_107;
		  sub_1800049A0(center->klass);
		  v8 = 0.0;
		  v9 = center->klass->vtable.get_value.method;
		  if ( v9 == (const MethodInfo *)Beyond::Gameplay::Core::PQSFilter::get_factorRange )
		  {
		    if ( IFix::WrappersManagerImpl::IsPatched(3547, 0LL) )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(3547, 0LL);
		      if ( !Patch )
		        goto LABEL_107;
		      v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_876(Patch, (Object *)center, 0LL);
		      goto LABEL_9;
		    }
		    v11 = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL);
		  }
		  else
		  {
		    if ( v9 != (const MethodInfo *)Beyond::Gameplay::Core::PQSEvaluator::get_factorRange )
		    {
		      v10 = (Vector2)((__int64 (__fastcall *)(Vector2Parameter *, Il2CppMethodPointer))v9)(
		                       center,
		                       center->klass->vtable.set_value.methodPtr);
		LABEL_9:
		      v11 = (__m128)(unsigned __int64)v10;
		      goto LABEL_10;
		    }
		    if ( IFix::WrappersManagerImpl::IsPatched(58313, 0LL) )
		    {
		      v49 = IFix::WrappersManagerImpl::GetPatch(58313, 0LL);
		      if ( !v49 )
		        goto LABEL_107;
		      v60 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_876(v49, (Object *)center, 0LL);
		      x_low = (__m128)LODWORD(v60.x);
		      y_low = (__m128)LODWORD(v60.y);
		    }
		    else
		    {
		      x_low = (__m128)HIDWORD(center[3].monitor);
		      y_low = (__m128)*(unsigned int *)&center[3].fields._._.overrideState;
		    }
		    v11 = _mm_unpacklo_ps(x_low, y_low);
		  }
		LABEL_10:
		  LODWORD(v4->center.x) = v11.m128_i32[0];
		  LODWORD(v4->center.y) = _mm_shuffle_ps(v11, v11, 85).m128_u32[0];
		  intensity = v3->fields.intensity;
		  if ( !intensity )
		    goto LABEL_107;
		  sub_1800049A0(intensity->klass);
		  v13 = intensity->klass->vtable.get_value.method;
		  if ( v13 == (const MethodInfo *)Beyond::Gameplay::Core::AbilitySystem::get_detectedRadius )
		  {
		    dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    src = **(Vignette ***)&dst[2].opacity;
		    if ( !src )
		      goto LABEL_107;
		    if ( *(int *)&src->fields._.active > 3314 )
		    {
		      if ( !LODWORD(dst[3].smoothness) )
		      {
		        il2cpp_runtime_class_init_1(dst);
		        dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      dst = **(VignetteCPP ***)&dst[2].opacity;
		      if ( !dst )
		        goto LABEL_107;
		      if ( LODWORD(dst->center.y) <= 0xCF2 )
		        goto LABEL_323;
		      if ( dst[414].mask )
		      {
		        v50 = IFix::WrappersManagerImpl::GetPatch(3314, 0LL);
		        if ( !v50 )
		          goto LABEL_107;
		        goto LABEL_238;
		      }
		    }
		    v42 = *(_QWORD *)&intensity[11].fields.sliderExponent;
		    if ( !v42 )
		      goto LABEL_107;
		    dst = *(VignetteCPP **)(v42 + 16);
		    if ( !dst )
		      goto LABEL_107;
		    a = dst->color.a;
		  }
		  else
		  {
		    if ( v13 != (const MethodInfo *)Beyond::TickableMono::get_tickInterval )
		    {
		      if ( v13 != (const MethodInfo *)Beyond::NPC::Animation::AnimatorClothCalculator::AnimatorLookAtControllerHolder::get_weightBase )
		      {
		        a = ((float (__fastcall *)(ClampedFloatParameter *, Il2CppMethodPointer))v13)(
		              intensity,
		              intensity->klass->vtable.set_value.methodPtr);
		        goto LABEL_15;
		      }
		      dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		        dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      src = **(Vignette ***)&dst[2].opacity;
		      if ( !src )
		        goto LABEL_107;
		      if ( *(int *)&src->fields._.active > 2201 )
		      {
		        if ( !LODWORD(dst[3].smoothness) )
		        {
		          il2cpp_runtime_class_init_1(dst);
		          dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        }
		        src = **(Vignette ***)&dst[2].opacity;
		        if ( !src )
		          goto LABEL_107;
		        if ( *(_DWORD *)&src->fields._.active <= 0x899u )
		          goto LABEL_323;
		        if ( src[137].fields.blink )
		        {
		          v50 = IFix::WrappersManagerImpl::GetPatch(2201, 0LL);
		          if ( !v50 )
		            goto LABEL_107;
		LABEL_238:
		          a = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46(
		                (ILFixDynamicMethodWrapper_15 *)v50,
		                (Object *)intensity,
		                0LL);
		          goto LABEL_15;
		        }
		      }
		      if ( *(_QWORD *)&intensity->fields.min )
		      {
		        intensity = *(ClampedFloatParameter **)&intensity->fields.min;
		        if ( !LODWORD(dst[3].smoothness) )
		        {
		          il2cpp_runtime_class_init_1(dst);
		          dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        }
		        src = **(Vignette ***)&dst[2].opacity;
		        if ( !src )
		          goto LABEL_107;
		        if ( *(int *)&src->fields._.active <= 2202 )
		          goto LABEL_140;
		        if ( !LODWORD(dst[3].smoothness) )
		        {
		          il2cpp_runtime_class_init_1(dst);
		          dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        }
		        dst = **(VignetteCPP ***)&dst[2].opacity;
		        if ( !dst )
		          goto LABEL_107;
		        if ( LODWORD(dst->center.y) <= 0x89A )
		          goto LABEL_323;
		        if ( !dst[275].mask )
		        {
		LABEL_140:
		          a = *((float *)&intensity[4].monitor + 1);
		          goto LABEL_15;
		        }
		        v50 = IFix::WrappersManagerImpl::GetPatch(2202, 0LL);
		        if ( !v50 )
		          goto LABEL_107;
		        goto LABEL_238;
		      }
		LABEL_115:
		      a = 0.0;
		      goto LABEL_15;
		    }
		    dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    src = **(Vignette ***)&dst[2].opacity;
		    if ( !src )
		      goto LABEL_107;
		    if ( *(int *)&src->fields._.active <= 927 )
		      goto LABEL_115;
		    if ( !LODWORD(dst[3].smoothness) )
		    {
		      il2cpp_runtime_class_init_1(dst);
		      dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    dst = **(VignetteCPP ***)&dst[2].opacity;
		    if ( !dst )
		      goto LABEL_107;
		    if ( LODWORD(dst->center.y) <= 0x39F )
		      goto LABEL_323;
		    if ( !*(_QWORD *)&dst[116].center.y )
		      goto LABEL_115;
		    v51 = IFix::WrappersManagerImpl::GetPatch(927, 0LL);
		    if ( !v51 )
		      goto LABEL_107;
		    a = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_84(v51, (Object *)intensity, 0LL);
		  }
		LABEL_15:
		  v4->intensity = a;
		  smoothness = v3->fields.smoothness;
		  if ( !smoothness )
		    goto LABEL_107;
		  sub_1800049A0(smoothness->klass);
		  v16 = smoothness->klass->vtable.get_value.method;
		  if ( v16 == (const MethodInfo *)Beyond::Gameplay::Core::AbilitySystem::get_detectedRadius )
		  {
		    dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    src = **(Vignette ***)&dst[2].opacity;
		    if ( !src )
		      goto LABEL_107;
		    if ( *(int *)&src->fields._.active > 3314 )
		    {
		      if ( !LODWORD(dst[3].smoothness) )
		      {
		        il2cpp_runtime_class_init_1(dst);
		        dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      dst = **(VignetteCPP ***)&dst[2].opacity;
		      if ( !dst )
		        goto LABEL_107;
		      if ( LODWORD(dst->center.y) <= 0xCF2 )
		        goto LABEL_323;
		      if ( dst[414].mask )
		      {
		        v52 = IFix::WrappersManagerImpl::GetPatch(3314, 0LL);
		        if ( !v52 )
		          goto LABEL_107;
		        goto LABEL_266;
		      }
		    }
		    v43 = *(_QWORD *)&smoothness[11].fields.sliderExponent;
		    if ( !v43 )
		      goto LABEL_107;
		    dst = *(VignetteCPP **)(v43 + 16);
		    if ( !dst )
		      goto LABEL_107;
		    v17 = dst->color.a;
		  }
		  else
		  {
		    if ( v16 != (const MethodInfo *)Beyond::TickableMono::get_tickInterval )
		    {
		      if ( v16 != (const MethodInfo *)Beyond::NPC::Animation::AnimatorClothCalculator::AnimatorLookAtControllerHolder::get_weightBase )
		      {
		        v17 = ((float (__fastcall *)(ClampedFloatParameter *, Il2CppMethodPointer))v16)(
		                smoothness,
		                smoothness->klass->vtable.set_value.methodPtr);
		        goto LABEL_20;
		      }
		      dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		        dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      src = **(Vignette ***)&dst[2].opacity;
		      if ( !src )
		        goto LABEL_107;
		      if ( *(int *)&src->fields._.active > 2201 )
		      {
		        if ( !LODWORD(dst[3].smoothness) )
		        {
		          il2cpp_runtime_class_init_1(dst);
		          dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        }
		        src = **(Vignette ***)&dst[2].opacity;
		        if ( !src )
		          goto LABEL_107;
		        if ( *(_DWORD *)&src->fields._.active <= 0x899u )
		          goto LABEL_323;
		        if ( src[137].fields.blink )
		        {
		          v52 = IFix::WrappersManagerImpl::GetPatch(2201, 0LL);
		          if ( !v52 )
		            goto LABEL_107;
		LABEL_266:
		          v17 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46(
		                  (ILFixDynamicMethodWrapper_15 *)v52,
		                  (Object *)smoothness,
		                  0LL);
		          goto LABEL_20;
		        }
		      }
		      if ( *(_QWORD *)&smoothness->fields.min )
		      {
		        smoothness = *(ClampedFloatParameter **)&smoothness->fields.min;
		        if ( !LODWORD(dst[3].smoothness) )
		        {
		          il2cpp_runtime_class_init_1(dst);
		          dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        }
		        src = **(Vignette ***)&dst[2].opacity;
		        if ( !src )
		          goto LABEL_107;
		        if ( *(int *)&src->fields._.active <= 2202 )
		          goto LABEL_150;
		        if ( !LODWORD(dst[3].smoothness) )
		        {
		          il2cpp_runtime_class_init_1(dst);
		          dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        }
		        dst = **(VignetteCPP ***)&dst[2].opacity;
		        if ( !dst )
		          goto LABEL_107;
		        if ( LODWORD(dst->center.y) <= 0x89A )
		          goto LABEL_323;
		        if ( !dst[275].mask )
		        {
		LABEL_150:
		          v17 = *((float *)&smoothness[4].monitor + 1);
		          goto LABEL_20;
		        }
		        v52 = IFix::WrappersManagerImpl::GetPatch(2202, 0LL);
		        if ( !v52 )
		          goto LABEL_107;
		        goto LABEL_266;
		      }
		LABEL_120:
		      v17 = 0.0;
		      goto LABEL_20;
		    }
		    dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    src = **(Vignette ***)&dst[2].opacity;
		    if ( !src )
		      goto LABEL_107;
		    if ( *(int *)&src->fields._.active <= 927 )
		      goto LABEL_120;
		    if ( !LODWORD(dst[3].smoothness) )
		    {
		      il2cpp_runtime_class_init_1(dst);
		      dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    dst = **(VignetteCPP ***)&dst[2].opacity;
		    if ( !dst )
		      goto LABEL_107;
		    if ( LODWORD(dst->center.y) <= 0x39F )
		      goto LABEL_323;
		    if ( !*(_QWORD *)&dst[116].center.y )
		      goto LABEL_120;
		    v53 = IFix::WrappersManagerImpl::GetPatch(927, 0LL);
		    if ( !v53 )
		      goto LABEL_107;
		    v17 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_84(v53, (Object *)smoothness, 0LL);
		  }
		LABEL_20:
		  v4->smoothness = v17;
		  roundness = v3->fields.roundness;
		  if ( !roundness )
		    goto LABEL_107;
		  sub_1800049A0(roundness->klass);
		  v19 = roundness->klass->vtable.get_value.method;
		  if ( v19 == (const MethodInfo *)Beyond::Gameplay::Core::AbilitySystem::get_detectedRadius )
		  {
		    dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    src = **(Vignette ***)&dst[2].opacity;
		    if ( !src )
		      goto LABEL_107;
		    if ( *(int *)&src->fields._.active > 3314 )
		    {
		      if ( !LODWORD(dst[3].smoothness) )
		      {
		        il2cpp_runtime_class_init_1(dst);
		        dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      dst = **(VignetteCPP ***)&dst[2].opacity;
		      if ( !dst )
		        goto LABEL_107;
		      if ( LODWORD(dst->center.y) <= 0xCF2 )
		        goto LABEL_323;
		      if ( dst[414].mask )
		      {
		        v54 = IFix::WrappersManagerImpl::GetPatch(3314, 0LL);
		        if ( !v54 )
		          goto LABEL_107;
		        goto LABEL_294;
		      }
		    }
		    v44 = *(_QWORD *)&roundness[11].fields.sliderExponent;
		    if ( !v44 )
		      goto LABEL_107;
		    dst = *(VignetteCPP **)(v44 + 16);
		    if ( !dst )
		      goto LABEL_107;
		    v20 = dst->color.a;
		  }
		  else
		  {
		    if ( v19 != (const MethodInfo *)Beyond::TickableMono::get_tickInterval )
		    {
		      if ( v19 != (const MethodInfo *)Beyond::NPC::Animation::AnimatorClothCalculator::AnimatorLookAtControllerHolder::get_weightBase )
		      {
		        v20 = ((float (__fastcall *)(ClampedFloatParameter *, Il2CppMethodPointer))v19)(
		                roundness,
		                roundness->klass->vtable.set_value.methodPtr);
		        goto LABEL_25;
		      }
		      dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		        dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      src = **(Vignette ***)&dst[2].opacity;
		      if ( !src )
		        goto LABEL_107;
		      if ( *(int *)&src->fields._.active > 2201 )
		      {
		        if ( !LODWORD(dst[3].smoothness) )
		        {
		          il2cpp_runtime_class_init_1(dst);
		          dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        }
		        src = **(Vignette ***)&dst[2].opacity;
		        if ( !src )
		          goto LABEL_107;
		        if ( *(_DWORD *)&src->fields._.active <= 0x899u )
		          goto LABEL_323;
		        if ( src[137].fields.blink )
		        {
		          v54 = IFix::WrappersManagerImpl::GetPatch(2201, 0LL);
		          if ( !v54 )
		            goto LABEL_107;
		LABEL_294:
		          v20 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46(
		                  (ILFixDynamicMethodWrapper_15 *)v54,
		                  (Object *)roundness,
		                  0LL);
		          goto LABEL_25;
		        }
		      }
		      if ( *(_QWORD *)&roundness->fields.min )
		      {
		        roundness = *(ClampedFloatParameter **)&roundness->fields.min;
		        if ( !LODWORD(dst[3].smoothness) )
		        {
		          il2cpp_runtime_class_init_1(dst);
		          dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        }
		        src = **(Vignette ***)&dst[2].opacity;
		        if ( !src )
		          goto LABEL_107;
		        if ( *(int *)&src->fields._.active <= 2202 )
		          goto LABEL_160;
		        if ( !LODWORD(dst[3].smoothness) )
		        {
		          il2cpp_runtime_class_init_1(dst);
		          dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        }
		        dst = **(VignetteCPP ***)&dst[2].opacity;
		        if ( !dst )
		          goto LABEL_107;
		        if ( LODWORD(dst->center.y) <= 0x89A )
		          goto LABEL_323;
		        if ( !dst[275].mask )
		        {
		LABEL_160:
		          v20 = *((float *)&roundness[4].monitor + 1);
		          goto LABEL_25;
		        }
		        v54 = IFix::WrappersManagerImpl::GetPatch(2202, 0LL);
		        if ( !v54 )
		          goto LABEL_107;
		        goto LABEL_294;
		      }
		LABEL_125:
		      v20 = 0.0;
		      goto LABEL_25;
		    }
		    dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    src = **(Vignette ***)&dst[2].opacity;
		    if ( !src )
		      goto LABEL_107;
		    if ( *(int *)&src->fields._.active <= 927 )
		      goto LABEL_125;
		    if ( !LODWORD(dst[3].smoothness) )
		    {
		      il2cpp_runtime_class_init_1(dst);
		      dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    dst = **(VignetteCPP ***)&dst[2].opacity;
		    if ( !dst )
		      goto LABEL_107;
		    if ( LODWORD(dst->center.y) <= 0x39F )
		      goto LABEL_323;
		    if ( !*(_QWORD *)&dst[116].center.y )
		      goto LABEL_125;
		    v55 = IFix::WrappersManagerImpl::GetPatch(927, 0LL);
		    if ( !v55 )
		      goto LABEL_107;
		    v20 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_84(v55, (Object *)roundness, 0LL);
		  }
		LABEL_25:
		  v4->roundness = v20;
		  rounded = (VignetteCPP **)v3->fields.rounded;
		  if ( !rounded )
		    goto LABEL_107;
		  sub_1800049A0(*rounded);
		  v22 = *(bool (**)(RuntimeType *, MethodInfo *))&(*rounded)[7].smoothness;
		  src = *(Vignette **)&(*rounded)[7].rounded;
		  if ( v22 == System::RuntimeType::HasElementTypeImpl )
		  {
		    v34 = rounded[2];
		    if ( (LODWORD(v34->color.g) & 0x20000000) != 0
		      || (v35 = BYTE2(v34->color.g), v35 == 29)
		      || v35 == 16
		      || v35 == 20
		      || v35 == 15 )
		    {
		LABEL_72:
		      v23 = 1;
		      goto LABEL_30;
		    }
		LABEL_54:
		    v23 = 0;
		    goto LABEL_30;
		  }
		  if ( v22 != System::RuntimeType::get_IsGenericType )
		  {
		    if ( v22 != System::RuntimeType::get_IsGenericParameter )
		    {
		      v23 = ((__int64 (__fastcall *)(VignetteCPP **, Vignette *))v22)(rounded, src);
		      goto LABEL_30;
		    }
		    v40 = rounded[2];
		    if ( (LODWORD(v40->color.g) & 0x20000000) == 0 && (BYTE2(v40->color.g) == 19 || BYTE2(v40->color.g) == 30) )
		      goto LABEL_72;
		    goto LABEL_54;
		  }
		  dst = rounded[2];
		  if ( (LODWORD(dst->color.g) & 0x20000000) == 0 )
		  {
		    LOBYTE(src) = 1;
		    v38 = sub_180028750(dst, src);
		    if ( (*(_BYTE *)(v38 + 312) & 0x10) == 0 && !*(_QWORD *)(v38 + 96) )
		    {
		      v23 = 0;
		      goto LABEL_30;
		    }
		    goto LABEL_72;
		  }
		  v23 = 0;
		LABEL_30:
		  v4->rounded = v23;
		  blink = (VignetteCPP **)v3->fields.blink;
		  if ( !blink )
		    goto LABEL_107;
		  sub_1800049A0(*blink);
		  v25 = *(bool (**)(RuntimeType *, MethodInfo *))&(*blink)[7].smoothness;
		  v26 = *(_QWORD *)&(*blink)[7].rounded;
		  if ( v25 == System::RuntimeType::HasElementTypeImpl )
		  {
		    v36 = blink[2];
		    if ( (LODWORD(v36->color.g) & 0x20000000) != 0
		      || (v37 = BYTE2(v36->color.g), v37 == 29)
		      || v37 == 16
		      || v37 == 20
		      || v37 == 15 )
		    {
		LABEL_76:
		      v27 = 1;
		      goto LABEL_35;
		    }
		LABEL_60:
		    v27 = 0;
		    goto LABEL_35;
		  }
		  if ( v25 != System::RuntimeType::get_IsGenericType )
		  {
		    if ( v25 != System::RuntimeType::get_IsGenericParameter )
		    {
		      v27 = ((__int64 (__fastcall *)(VignetteCPP **, __int64))v25)(blink, v26);
		      goto LABEL_35;
		    }
		    v41 = blink[2];
		    if ( (LODWORD(v41->color.g) & 0x20000000) == 0 && (BYTE2(v41->color.g) == 19 || BYTE2(v41->color.g) == 30) )
		      goto LABEL_76;
		    goto LABEL_60;
		  }
		  dst = blink[2];
		  if ( (LODWORD(dst->color.g) & 0x20000000) == 0 )
		  {
		    LOBYTE(v26) = 1;
		    v39 = sub_180028750(dst, v26);
		    if ( (*(_BYTE *)(v39 + 312) & 0x10) == 0 && !*(_QWORD *)(v39 + 96) )
		    {
		      v27 = 0;
		      goto LABEL_35;
		    }
		    goto LABEL_76;
		  }
		  v27 = 0;
		LABEL_35:
		  v4->blink = v27;
		  src = (Vignette *)v3->fields.mask;
		  if ( !src )
		    goto LABEL_107;
		  v28 = sub_1800460A0(10LL, src);
		  dst = (VignetteCPP *)TypeInfo::UnityEngine::Object;
		  v29 = v28;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    dst = (VignetteCPP *)TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      dst = (VignetteCPP *)TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( !v29 )
		    goto LABEL_41;
		  if ( !LODWORD(dst[3].smoothness) )
		    il2cpp_runtime_class_init_1(dst);
		  if ( *(_QWORD *)(v29 + 16) )
		  {
		    src = (Vignette *)v3->fields.mask;
		    if ( !src )
		      goto LABEL_107;
		    v56 = sub_1800460A0(10LL, src);
		    if ( !v56 )
		      goto LABEL_107;
		    v30 = *(void **)(v56 + 16);
		  }
		  else
		  {
		LABEL_41:
		    v30 = 0LL;
		  }
		  v4->mask = v30;
		  opacity = v3->fields.opacity;
		  if ( !opacity )
		    goto LABEL_107;
		  sub_1800049A0(opacity->klass);
		  v32 = (float (*)(AbilitySystem *, MethodInfo *))opacity->klass->vtable.get_value.method;
		  if ( v32 == Beyond::Gameplay::Core::AbilitySystem::get_detectedRadius )
		  {
		    dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    src = **(Vignette ***)&dst[2].opacity;
		    if ( src )
		    {
		      if ( *(int *)&src->fields._.active <= 3314 )
		        goto LABEL_104;
		      if ( !LODWORD(dst[3].smoothness) )
		      {
		        il2cpp_runtime_class_init_1(dst);
		        dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      src = **(Vignette ***)&dst[2].opacity;
		      if ( !src )
		        goto LABEL_107;
		      if ( *(_DWORD *)&src->fields._.active <= 0xCF2u )
		        goto LABEL_323;
		      if ( src[207].fields.mode )
		      {
		        v57 = IFix::WrappersManagerImpl::GetPatch(3314, 0LL);
		        if ( v57 )
		          goto LABEL_325;
		      }
		      else
		      {
		LABEL_104:
		        v45 = *(_QWORD *)&opacity[11].fields.sliderExponent;
		        if ( v45 )
		        {
		          dst = *(VignetteCPP **)(v45 + 16);
		          if ( dst )
		          {
		            v8 = dst->color.a;
		            goto LABEL_48;
		          }
		        }
		      }
		    }
		LABEL_107:
		    sub_1800D8260(dst, src);
		  }
		  if ( (char *)v32 == (char *)Beyond::TickableMono::get_tickInterval )
		  {
		    dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    src = **(Vignette ***)&dst[2].opacity;
		    if ( src )
		    {
		      if ( *(int *)&src->fields._.active <= 927 )
		        goto LABEL_48;
		      if ( !LODWORD(dst[3].smoothness) )
		      {
		        il2cpp_runtime_class_init_1(dst);
		        dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      src = **(Vignette ***)&dst[2].opacity;
		      if ( src )
		      {
		        if ( *(_DWORD *)&src->fields._.active <= 0x39Fu )
		          goto LABEL_323;
		        if ( !*(_QWORD *)&src[58].fields._.active )
		          goto LABEL_48;
		        v58 = IFix::WrappersManagerImpl::GetPatch(927, 0LL);
		        if ( v58 )
		        {
		          *(float *)&v33 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_84(v58, (Object *)opacity, 0LL);
		          goto LABEL_47;
		        }
		      }
		    }
		    goto LABEL_107;
		  }
		  if ( (char *)v32 == (char *)Beyond::NPC::Animation::AnimatorClothCalculator::AnimatorLookAtControllerHolder::get_weightBase )
		  {
		    dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    src = **(Vignette ***)&dst[2].opacity;
		    if ( src )
		    {
		      if ( *(int *)&src->fields._.active <= 2201 )
		        goto LABEL_165;
		      if ( !LODWORD(dst[3].smoothness) )
		      {
		        il2cpp_runtime_class_init_1(dst);
		        dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      src = **(Vignette ***)&dst[2].opacity;
		      if ( !src )
		        goto LABEL_107;
		      if ( *(_DWORD *)&src->fields._.active <= 0x899u )
		        goto LABEL_323;
		      if ( src[137].fields.blink )
		      {
		        v57 = IFix::WrappersManagerImpl::GetPatch(2201, 0LL);
		        if ( v57 )
		          goto LABEL_325;
		      }
		      else
		      {
		LABEL_165:
		        if ( !*(_QWORD *)&opacity->fields.min )
		          goto LABEL_48;
		        opacity = *(ClampedFloatParameter **)&opacity->fields.min;
		        if ( !LODWORD(dst[3].smoothness) )
		        {
		          il2cpp_runtime_class_init_1(dst);
		          dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        }
		        src = **(Vignette ***)&dst[2].opacity;
		        if ( src )
		        {
		          if ( *(int *)&src->fields._.active <= 2202 )
		          {
		LABEL_170:
		            v8 = *((float *)&opacity[4].monitor + 1);
		            goto LABEL_48;
		          }
		          if ( !LODWORD(dst[3].smoothness) )
		          {
		            il2cpp_runtime_class_init_1(dst);
		            dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		          }
		          dst = **(VignetteCPP ***)&dst[2].opacity;
		          if ( dst )
		          {
		            if ( LODWORD(dst->center.y) <= 0x89A )
		LABEL_323:
		              sub_1800D2AB0(dst, src);
		            if ( !dst[275].mask )
		              goto LABEL_170;
		            v57 = IFix::WrappersManagerImpl::GetPatch(2202, 0LL);
		            if ( v57 )
		            {
		LABEL_325:
		              *(float *)&v33 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46(
		                                 (ILFixDynamicMethodWrapper_15 *)v57,
		                                 (Object *)opacity,
		                                 0LL);
		              goto LABEL_47;
		            }
		          }
		        }
		      }
		    }
		    goto LABEL_107;
		  }
		  v33 = ((double (__fastcall *)(ClampedFloatParameter *, Il2CppMethodPointer))v32)(
		          opacity,
		          opacity->klass->vtable.set_value.methodPtr);
		LABEL_47:
		  v8 = *(float *)&v33;
		LABEL_48:
		  v4->opacity = v8;
		}
		
		public static unsafe void ConvertHGVignetteToCPP(HGVignetteCPP* dst, HGVignette src) {} // 0x00000001831BAC50-0x00000001831BB290
		// Void ConvertHGVignetteToCPP(HGVignetteCPP*, HGVignette)
		void HG::Rendering::Runtime::HGUtilsCpp::ConvertHGVignetteToCPP(
		        HGVignetteCPP *dst,
		        HGVignette *src,
		        MethodInfo *method)
		{
		  HGVignette *v3; // rbx
		  HGVignetteCPP *v4; // rdi
		  ColorParameter *color; // rsi
		  Color v6; // xmm0
		  ClampedFloatParameter *intensity; // rsi
		  float v8; // xmm6_4
		  const MethodInfo *v9; // r8
		  float v10; // xmm0_4
		  Object *smoothness; // rsi
		  float (*typeMetadataHandle)(AbilitySystem *, MethodInfo *); // r8
		  double v13; // xmm0_8
		  HGVignetteCPP **rounded; // rsi
		  bool (*v15)(RuntimeType *, MethodInfo *); // r8
		  char v16; // al
		  BoolParameter *blink; // rbx
		  bool (*v18)(RuntimeType *, MethodInfo *); // r8
		  Il2CppMethodPointer methodPtr; // rdx
		  char v20; // al
		  VolumeParameter__Fields v21; // rax
		  char v22; // al
		  HGVignetteCPP *v23; // rax
		  char v24; // al
		  __int64 v25; // rax
		  VolumeParameter__Fields v26; // rcx
		  __int64 v27; // rax
		  HGVignetteCPP *v28; // rax
		  VolumeParameter__Fields v29; // rax
		  __int64 v30; // rax
		  MonitorData *monitor; // rax
		  ILFixDynamicMethodWrapper *Patch; // rax
		  ILFixDynamicMethodWrapper_3 *v33; // rax
		  ILFixDynamicMethodWrapper *v34; // rax
		  ILFixDynamicMethodWrapper_3 *v35; // rax
		  char v36[16]; // [rsp+20h] [rbp-38h] BYREF
		
		  v3 = src;
		  v4 = dst;
		  if ( !src )
		    goto LABEL_98;
		  color = src->fields.color;
		  if ( !color )
		    goto LABEL_98;
		  sub_1800049A0(color->klass);
		  v6 = *(Color *)((__int64 (__fastcall *)(char *, ColorParameter *, Il2CppMethodPointer))color->klass->vtable.get_value.method)(
		                   v36,
		                   color,
		                   color->klass->vtable.set_value.methodPtr);
		  if ( !v4 )
		    goto LABEL_98;
		  v4->color = v6;
		  intensity = v3->fields.intensity;
		  if ( !intensity )
		    goto LABEL_98;
		  sub_1800049A0(intensity->klass);
		  v8 = 0.0;
		  v9 = intensity->klass->vtable.get_value.method;
		  if ( v9 == (const MethodInfo *)Beyond::Gameplay::Core::AbilitySystem::get_detectedRadius )
		  {
		    dst = (HGVignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      dst = (HGVignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    src = **(HGVignette ***)&dst[6].intensity;
		    if ( !src )
		      goto LABEL_98;
		    if ( *(int *)&src->fields._.active > 3314 )
		    {
		      if ( !LODWORD(dst[8].color.r) )
		      {
		        il2cpp_runtime_class_init_1(dst);
		        dst = (HGVignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      dst = **(HGVignetteCPP ***)&dst[6].intensity;
		      if ( !dst )
		        goto LABEL_98;
		      if ( *(_DWORD *)&dst->rounded <= 0xCF2u )
		        goto LABEL_169;
		      if ( *(_QWORD *)&dst[948].color.r )
		      {
		        Patch = IFix::WrappersManagerImpl::GetPatch(3314, 0LL);
		        if ( !Patch )
		          goto LABEL_98;
		        goto LABEL_143;
		      }
		    }
		    v30 = *(_QWORD *)&intensity[11].fields.sliderExponent;
		    if ( !v30 )
		      goto LABEL_98;
		    dst = *(HGVignetteCPP **)(v30 + 16);
		    if ( !dst )
		      goto LABEL_98;
		    v10 = dst->intensity;
		  }
		  else
		  {
		    if ( v9 != (const MethodInfo *)Beyond::TickableMono::get_tickInterval )
		    {
		      if ( v9 != (const MethodInfo *)Beyond::NPC::Animation::AnimatorClothCalculator::AnimatorLookAtControllerHolder::get_weightBase )
		      {
		        v10 = ((float (__fastcall *)(ClampedFloatParameter *, Il2CppMethodPointer))v9)(
		                intensity,
		                intensity->klass->vtable.set_value.methodPtr);
		        goto LABEL_9;
		      }
		      dst = (HGVignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		        dst = (HGVignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      src = **(HGVignette ***)&dst[6].intensity;
		      if ( !src )
		        goto LABEL_98;
		      if ( *(int *)&src->fields._.active > 2201 )
		      {
		        if ( !LODWORD(dst[8].color.r) )
		        {
		          il2cpp_runtime_class_init_1(dst);
		          dst = (HGVignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        }
		        src = **(HGVignette ***)&dst[6].intensity;
		        if ( !src )
		          goto LABEL_98;
		        if ( *(_DWORD *)&src->fields._.active <= 0x899u )
		          goto LABEL_169;
		        if ( src[200].fields._._parameters_k__BackingField )
		        {
		          Patch = IFix::WrappersManagerImpl::GetPatch(2201, 0LL);
		          if ( !Patch )
		            goto LABEL_98;
		LABEL_143:
		          v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46(
		                  (ILFixDynamicMethodWrapper_15 *)Patch,
		                  (Object *)intensity,
		                  0LL);
		          goto LABEL_9;
		        }
		      }
		      if ( *(_QWORD *)&intensity->fields.min )
		      {
		        intensity = *(ClampedFloatParameter **)&intensity->fields.min;
		        if ( !LODWORD(dst[8].color.r) )
		        {
		          il2cpp_runtime_class_init_1(dst);
		          dst = (HGVignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        }
		        src = **(HGVignette ***)&dst[6].intensity;
		        if ( !src )
		          goto LABEL_98;
		        if ( *(int *)&src->fields._.active <= 2202 )
		          goto LABEL_87;
		        if ( !LODWORD(dst[8].color.r) )
		        {
		          il2cpp_runtime_class_init_1(dst);
		          dst = (HGVignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        }
		        dst = **(HGVignetteCPP ***)&dst[6].intensity;
		        if ( !dst )
		          goto LABEL_98;
		        if ( *(_DWORD *)&dst->rounded <= 0x89Au )
		          goto LABEL_169;
		        if ( !*(_QWORD *)&dst[630].color.b )
		        {
		LABEL_87:
		          v10 = *((float *)&intensity[4].monitor + 1);
		          goto LABEL_9;
		        }
		        Patch = IFix::WrappersManagerImpl::GetPatch(2202, 0LL);
		        if ( !Patch )
		          goto LABEL_98;
		        goto LABEL_143;
		      }
		LABEL_72:
		      v10 = 0.0;
		      goto LABEL_9;
		    }
		    dst = (HGVignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      dst = (HGVignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    src = **(HGVignette ***)&dst[6].intensity;
		    if ( !src )
		      goto LABEL_98;
		    if ( *(int *)&src->fields._.active <= 927 )
		      goto LABEL_72;
		    if ( !LODWORD(dst[8].color.r) )
		    {
		      il2cpp_runtime_class_init_1(dst);
		      dst = (HGVignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    dst = **(HGVignetteCPP ***)&dst[6].intensity;
		    if ( !dst )
		      goto LABEL_98;
		    if ( *(_DWORD *)&dst->rounded <= 0x39Fu )
		      goto LABEL_169;
		    if ( !*(_QWORD *)&dst[266].color.r )
		      goto LABEL_72;
		    v33 = IFix::WrappersManagerImpl::GetPatch(927, 0LL);
		    if ( !v33 )
		      goto LABEL_98;
		    v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_84(v33, (Object *)intensity, 0LL);
		  }
		LABEL_9:
		  v4->intensity = v10;
		  smoothness = (Object *)v3->fields.smoothness;
		  if ( !smoothness )
		    goto LABEL_98;
		  sub_1800049A0(smoothness->klass);
		  typeMetadataHandle = (float (*)(AbilitySystem *, MethodInfo *))smoothness->klass[1]._0.typeMetadataHandle;
		  if ( typeMetadataHandle == Beyond::Gameplay::Core::AbilitySystem::get_detectedRadius )
		  {
		    dst = (HGVignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      dst = (HGVignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    src = **(HGVignette ***)&dst[6].intensity;
		    if ( src )
		    {
		      if ( *(int *)&src->fields._.active <= 3314 )
		        goto LABEL_65;
		      if ( !LODWORD(dst[8].color.r) )
		      {
		        il2cpp_runtime_class_init_1(dst);
		        dst = (HGVignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      src = **(HGVignette ***)&dst[6].intensity;
		      if ( !src )
		        goto LABEL_98;
		      if ( *(_DWORD *)&src->fields._.active <= 0xCF2u )
		        goto LABEL_169;
		      if ( src[301].fields.intensity )
		      {
		        v34 = IFix::WrappersManagerImpl::GetPatch(3314, 0LL);
		        if ( v34 )
		          goto LABEL_171;
		      }
		      else
		      {
		LABEL_65:
		        monitor = smoothness[35].monitor;
		        if ( monitor )
		        {
		          dst = (HGVignetteCPP *)*((_QWORD *)monitor + 2);
		          if ( dst )
		          {
		            v8 = dst->intensity;
		            goto LABEL_15;
		          }
		        }
		      }
		    }
		LABEL_98:
		    sub_1800D8260(dst, src);
		  }
		  if ( (char *)typeMetadataHandle != (char *)Beyond::TickableMono::get_tickInterval )
		  {
		    if ( (char *)typeMetadataHandle != (char *)Beyond::NPC::Animation::AnimatorClothCalculator::AnimatorLookAtControllerHolder::get_weightBase )
		    {
		      v13 = ((double (__fastcall *)(Object *, const Il2CppInteropData *))typeMetadataHandle)(
		              smoothness,
		              smoothness->klass[1]._0.interopData);
		LABEL_14:
		      v8 = *(float *)&v13;
		      goto LABEL_15;
		    }
		    dst = (HGVignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      dst = (HGVignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    src = **(HGVignette ***)&dst[6].intensity;
		    if ( src )
		    {
		      if ( *(int *)&src->fields._.active <= 2201 )
		        goto LABEL_92;
		      if ( !LODWORD(dst[8].color.r) )
		      {
		        il2cpp_runtime_class_init_1(dst);
		        dst = (HGVignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      src = **(HGVignette ***)&dst[6].intensity;
		      if ( !src )
		        goto LABEL_98;
		      if ( *(_DWORD *)&src->fields._.active <= 0x899u )
		        goto LABEL_169;
		      if ( src[200].fields._._parameters_k__BackingField )
		      {
		        v34 = IFix::WrappersManagerImpl::GetPatch(2201, 0LL);
		        if ( v34 )
		          goto LABEL_171;
		      }
		      else
		      {
		LABEL_92:
		        if ( !smoothness[2].klass )
		          goto LABEL_15;
		        smoothness = (Object *)smoothness[2].klass;
		        if ( !LODWORD(dst[8].color.r) )
		        {
		          il2cpp_runtime_class_init_1(dst);
		          dst = (HGVignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        }
		        src = **(HGVignette ***)&dst[6].intensity;
		        if ( src )
		        {
		          if ( *(int *)&src->fields._.active <= 2202 )
		          {
		LABEL_97:
		            v8 = *((float *)&smoothness[12].monitor + 1);
		            goto LABEL_15;
		          }
		          if ( !LODWORD(dst[8].color.r) )
		          {
		            il2cpp_runtime_class_init_1(dst);
		            dst = (HGVignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		          }
		          dst = **(HGVignetteCPP ***)&dst[6].intensity;
		          if ( dst )
		          {
		            if ( *(_DWORD *)&dst->rounded <= 0x89Au )
		LABEL_169:
		              sub_1800D2AB0(dst, src);
		            if ( !*(_QWORD *)&dst[630].color.b )
		              goto LABEL_97;
		            v34 = IFix::WrappersManagerImpl::GetPatch(2202, 0LL);
		            if ( v34 )
		            {
		LABEL_171:
		              *(float *)&v13 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46(
		                                 (ILFixDynamicMethodWrapper_15 *)v34,
		                                 smoothness,
		                                 0LL);
		              goto LABEL_14;
		            }
		          }
		        }
		      }
		    }
		    goto LABEL_98;
		  }
		  dst = (HGVignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    dst = (HGVignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  src = **(HGVignette ***)&dst[6].intensity;
		  if ( !src )
		    goto LABEL_98;
		  if ( *(int *)&src->fields._.active <= 927 )
		    goto LABEL_15;
		  if ( !LODWORD(dst[8].color.r) )
		  {
		    il2cpp_runtime_class_init_1(dst);
		    dst = (HGVignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  src = **(HGVignette ***)&dst[6].intensity;
		  if ( !src )
		    goto LABEL_98;
		  if ( *(_DWORD *)&src->fields._.active <= 0x39Fu )
		    goto LABEL_169;
		  if ( src[84].fields.intensity )
		  {
		    v35 = IFix::WrappersManagerImpl::GetPatch(927, 0LL);
		    if ( v35 )
		    {
		      *(float *)&v13 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_84(v35, smoothness, 0LL);
		      goto LABEL_14;
		    }
		    goto LABEL_98;
		  }
		LABEL_15:
		  v4->smoothness = v8;
		  rounded = (HGVignetteCPP **)v3->fields.rounded;
		  if ( !rounded )
		    goto LABEL_98;
		  sub_1800049A0(*rounded);
		  v15 = *(bool (**)(RuntimeType *, MethodInfo *))&(*rounded)[17].color.g;
		  src = *(HGVignette **)&(*rounded)[17].color.a;
		  if ( v15 == System::RuntimeType::HasElementTypeImpl )
		  {
		    v23 = rounded[2];
		    if ( (LODWORD(v23->color.b) & 0x20000000) != 0
		      || (v24 = BYTE2(v23->color.b), v24 == 29)
		      || v24 == 16
		      || v24 == 20
		      || v24 == 15 )
		    {
		LABEL_49:
		      v16 = 1;
		      goto LABEL_20;
		    }
		LABEL_37:
		    v16 = 0;
		    goto LABEL_20;
		  }
		  if ( v15 != System::RuntimeType::get_IsGenericType )
		  {
		    if ( v15 != System::RuntimeType::get_IsGenericParameter )
		    {
		      v16 = ((__int64 (__fastcall *)(HGVignetteCPP **, HGVignette *))v15)(rounded, src);
		      goto LABEL_20;
		    }
		    v28 = rounded[2];
		    if ( (LODWORD(v28->color.b) & 0x20000000) == 0 && (BYTE2(v28->color.b) == 19 || BYTE2(v28->color.b) == 30) )
		      goto LABEL_49;
		    goto LABEL_37;
		  }
		  dst = rounded[2];
		  if ( (LODWORD(dst->color.b) & 0x20000000) == 0 )
		  {
		    LOBYTE(src) = 1;
		    v25 = sub_180028750(dst, src);
		    if ( (*(_BYTE *)(v25 + 312) & 0x10) == 0 && !*(_QWORD *)(v25 + 96) )
		    {
		      v16 = 0;
		      goto LABEL_20;
		    }
		    goto LABEL_49;
		  }
		  v16 = 0;
		LABEL_20:
		  v4->rounded = v16;
		  blink = v3->fields.blink;
		  if ( !blink )
		    goto LABEL_98;
		  sub_1800049A0(blink->klass);
		  v18 = (bool (*)(RuntimeType *, MethodInfo *))blink->klass->vtable.get_value.method;
		  methodPtr = blink->klass->vtable.set_value.methodPtr;
		  if ( v18 == System::RuntimeType::HasElementTypeImpl )
		  {
		    v21 = blink->fields._._;
		    if ( (*(_DWORD *)(*(_QWORD *)&v21 + 8LL) & 0x20000000) != 0 )
		      goto LABEL_53;
		    v22 = *(_BYTE *)(*(_QWORD *)&v21 + 10LL);
		    if ( v22 == 29 || v22 == 16 || v22 == 20 || v22 == 15 )
		      goto LABEL_53;
		    goto LABEL_31;
		  }
		  if ( v18 == System::RuntimeType::get_IsGenericType )
		  {
		    v26 = blink->fields._._;
		    if ( (*(_DWORD *)(*(_QWORD *)&v26 + 8LL) & 0x20000000) == 0 )
		    {
		      LOBYTE(methodPtr) = 1;
		      v27 = ((__int64 (__fastcall *)(_QWORD, _QWORD))sub_180028750)(v26, methodPtr);
		      if ( (*(_BYTE *)(v27 + 312) & 0x10) != 0 || *(_QWORD *)(v27 + 96) )
		        goto LABEL_53;
		    }
		    goto LABEL_31;
		  }
		  if ( v18 == System::RuntimeType::get_IsGenericParameter )
		  {
		    v29 = blink->fields._._;
		    if ( (*(_DWORD *)(*(_QWORD *)&v29 + 8LL) & 0x20000000) == 0
		      && (*(_BYTE *)(*(_QWORD *)&v29 + 10LL) == 19 || *(_BYTE *)(*(_QWORD *)&v29 + 10LL) == 30) )
		    {
		LABEL_53:
		      v20 = 1;
		      goto LABEL_25;
		    }
		LABEL_31:
		    v20 = 0;
		    goto LABEL_25;
		  }
		  v20 = ((__int64 (__fastcall *)(BoolParameter *, Il2CppMethodPointer))v18)(blink, methodPtr);
		LABEL_25:
		  v4->blink = v20;
		}
		
		public static unsafe void ConvertBloomToCPP(BloomVolumeCPP* dst, Bloom src, float anamorphism) {} // 0x00000001831B8C70-0x00000001831B9F30
		// Void ConvertBloomToCPP(BloomVolumeCPP*, Bloom, Single)
		void HG::Rendering::Runtime::HGUtilsCpp::ConvertBloomToCPP(
		        BloomVolumeCPP *dst,
		        Bloom *src,
		        float anamorphism,
		        MethodInfo *method)
		{
		  Bloom *v4; // rbx
		  BloomVolumeCPP *v5; // rdi
		  Object *intensityHighQuality; // rsi
		  double v7; // xmm0_8
		  void (__fastcall *typeMetadataHandle)(Object *, const Il2CppInteropData *); // r8
		  ColorParameter *tint; // rsi
		  __int64 v10; // rax
		  __int64 v11; // rsi
		  void *v12; // rax
		  MinFloatParameter *dirtIntensity; // rsi
		  float (*v14)(AbilitySystem *, MethodInfo *); // r8
		  float a; // xmm0_4
		  ClampedFloatParameter *scatterHighQuality; // rsi
		  float (*v17)(AbilitySystem *, MethodInfo *); // r8
		  float v18; // xmm0_4
		  MinFloatParameter *thresholdHighQuality; // rsi
		  const MethodInfo *v20; // r8
		  float v21; // xmm0_4
		  MinFloatParameter *characterThreshold; // rsi
		  const MethodInfo *v23; // r8
		  float v24; // xmm0_4
		  ClampedFloatParameter *characterSoftness; // rsi
		  const MethodInfo *v26; // r8
		  float v27; // xmm0_4
		  ClampedFloatParameter *characterIntensity; // rsi
		  float (*v29)(AbilitySystem *, MethodInfo *); // r8
		  float v30; // xmm0_4
		  int v31; // eax
		  int32_t v32; // eax
		  __int64 v33; // rax
		  __int64 v34; // rsi
		  bool v35; // al
		  BloomVolumeCPP **characterBloomControl; // rsi
		  bool (*v37)(RuntimeType *, MethodInfo *); // r8
		  char v38; // al
		  BoolParameter *anamorphic; // rbx
		  bool (*v40)(RuntimeType *, MethodInfo *); // r8
		  Il2CppMethodPointer methodPtr; // rdx
		  char v42; // al
		  VolumeParameter__Fields v43; // rax
		  char v44; // al
		  BloomVolumeCPP *v45; // rax
		  char v46; // al
		  __int64 v47; // rax
		  VolumeParameter__Fields v48; // rcx
		  __int64 v49; // rax
		  BloomVolumeCPP *v50; // rax
		  VolumeParameter__Fields v51; // rax
		  MonitorData *monitor; // rax
		  MonitorData *v53; // rax
		  __int64 v54; // rax
		  MonitorData *v55; // rax
		  MonitorData *v56; // rax
		  __int64 v57; // rax
		  __int64 v58; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ILFixDynamicMethodWrapper *v60; // rax
		  ILFixDynamicMethodWrapper_3 *v61; // rax
		  __int64 v62; // rax
		  ILFixDynamicMethodWrapper *v63; // rax
		  ILFixDynamicMethodWrapper_3 *v64; // rax
		  ILFixDynamicMethodWrapper_2 *v65; // rax
		  ILFixDynamicMethodWrapper *v66; // rax
		  ILFixDynamicMethodWrapper_3 *v67; // rax
		  ILFixDynamicMethodWrapper_2 *v68; // rax
		  ILFixDynamicMethodWrapper *v69; // rax
		  ILFixDynamicMethodWrapper_3 *v70; // rax
		  ILFixDynamicMethodWrapper *v71; // rax
		  ILFixDynamicMethodWrapper_3 *v72; // rax
		  ILFixDynamicMethodWrapper *v73; // rax
		  ILFixDynamicMethodWrapper_3 *v74; // rax
		  ILFixDynamicMethodWrapper *v75; // rax
		  ILFixDynamicMethodWrapper_3 *v76; // rax
		  ILFixDynamicMethodWrapper_2 *v77; // rax
		  ILFixDynamicMethodWrapper_2 *v78; // rax
		  double v79; // xmm0_8
		  char v80[16]; // [rsp+20h] [rbp-38h] BYREF
		
		  v4 = src;
		  v5 = dst;
		  if ( !src )
		    goto LABEL_131;
		  dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  src = **(Bloom ***)&dst[2].anamorphic;
		  if ( !src )
		    goto LABEL_131;
		  if ( *(int *)&src->fields._.active > 2666 )
		  {
		    if ( !LODWORD(dst[3].tint.g) )
		    {
		      il2cpp_runtime_class_init_1(dst);
		      dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    src = **(Bloom ***)&dst[2].anamorphic;
		    if ( !src )
		      goto LABEL_131;
		    if ( *(_DWORD *)&src->fields._.active <= 0xA6Au )
		      goto LABEL_344;
		    if ( src[95].fields.thresholdHighQuality )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(2666, 0LL);
		      if ( !Patch )
		        goto LABEL_131;
		      *(float *)&v7 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46(
		                        (ILFixDynamicMethodWrapper_15 *)Patch,
		                        (Object *)v4,
		                        0LL);
		      goto LABEL_11;
		    }
		  }
		  intensityHighQuality = (Object *)v4->fields.intensityHighQuality;
		  if ( !intensityHighQuality )
		    goto LABEL_131;
		  v7 = sub_1800049A0(intensityHighQuality->klass);
		  typeMetadataHandle = (void (__fastcall *)(Object *, const Il2CppInteropData *))intensityHighQuality->klass[1]._0.typeMetadataHandle;
		  if ( (char *)typeMetadataHandle == (char *)Beyond::Gameplay::Core::AbilitySystem::get_detectedRadius )
		  {
		    dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    src = **(Bloom ***)&dst[2].anamorphic;
		    if ( !src )
		      goto LABEL_131;
		    if ( *(int *)&src->fields._.active > 3314 )
		    {
		      if ( !LODWORD(dst[3].tint.g) )
		      {
		        il2cpp_runtime_class_init_1(dst);
		        dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      dst = **(BloomVolumeCPP ***)&dst[2].anamorphic;
		      if ( !dst )
		        goto LABEL_131;
		      if ( LODWORD(dst->dirtTexture) <= 0xCF2 )
		        goto LABEL_344;
		      if ( *(_QWORD *)&dst[368].threshold )
		      {
		        v60 = IFix::WrappersManagerImpl::GetPatch(3314, 0LL);
		        if ( !v60 )
		          goto LABEL_131;
		        goto LABEL_367;
		      }
		    }
		    monitor = intensityHighQuality[35].monitor;
		    if ( !monitor )
		      goto LABEL_131;
		    dst = (BloomVolumeCPP *)*((_QWORD *)monitor + 2);
		    if ( !dst )
		      goto LABEL_131;
		    *(float *)&v7 = dst->tint.a;
		  }
		  else
		  {
		    if ( (char *)typeMetadataHandle != (char *)Beyond::TickableMono::get_tickInterval )
		    {
		      if ( (char *)typeMetadataHandle != (char *)Beyond::NPC::Animation::AnimatorClothCalculator::AnimatorLookAtControllerHolder::get_weightBase )
		      {
		        typeMetadataHandle(intensityHighQuality, intensityHighQuality->klass[1]._0.interopData);
		        goto LABEL_11;
		      }
		      dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		        dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      src = **(Bloom ***)&dst[2].anamorphic;
		      if ( !src )
		        goto LABEL_131;
		      if ( *(int *)&src->fields._.active > 2201 )
		      {
		        if ( !LODWORD(dst[3].tint.g) )
		        {
		          il2cpp_runtime_class_init_1(dst);
		          dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        }
		        src = **(Bloom ***)&dst[2].anamorphic;
		        if ( !src )
		          goto LABEL_131;
		        if ( *(_DWORD *)&src->fields._.active <= 0x899u )
		          goto LABEL_344;
		        if ( src[78].fields.characterBloomControl )
		        {
		          v60 = IFix::WrappersManagerImpl::GetPatch(2201, 0LL);
		          if ( !v60 )
		            goto LABEL_131;
		          goto LABEL_367;
		        }
		      }
		      if ( intensityHighQuality[2].klass )
		      {
		        intensityHighQuality = (Object *)intensityHighQuality[2].klass;
		        if ( !LODWORD(dst[3].tint.g) )
		        {
		          il2cpp_runtime_class_init_1(dst);
		          dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        }
		        src = **(Bloom ***)&dst[2].anamorphic;
		        if ( !src )
		          goto LABEL_131;
		        if ( *(int *)&src->fields._.active <= 2202 )
		          goto LABEL_211;
		        if ( !LODWORD(dst[3].tint.g) )
		        {
		          il2cpp_runtime_class_init_1(dst);
		          dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        }
		        dst = **(BloomVolumeCPP ***)&dst[2].anamorphic;
		        if ( !dst )
		          goto LABEL_131;
		        if ( LODWORD(dst->dirtTexture) <= 0x89A )
		          goto LABEL_344;
		        if ( !*(_QWORD *)&dst[245].tint.g )
		        {
		LABEL_211:
		          LODWORD(v7) = HIDWORD(intensityHighQuality[12].monitor);
		          goto LABEL_11;
		        }
		        v60 = IFix::WrappersManagerImpl::GetPatch(2202, 0LL);
		        if ( !v60 )
		          goto LABEL_131;
		LABEL_367:
		        *(float *)&v7 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46(
		                          (ILFixDynamicMethodWrapper_15 *)v60,
		                          intensityHighQuality,
		                          0LL);
		        goto LABEL_11;
		      }
		LABEL_171:
		      LODWORD(v7) = 0;
		      goto LABEL_11;
		    }
		    dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    src = **(Bloom ***)&dst[2].anamorphic;
		    if ( !src )
		      goto LABEL_131;
		    if ( *(int *)&src->fields._.active <= 927 )
		      goto LABEL_171;
		    if ( !LODWORD(dst[3].tint.g) )
		    {
		      il2cpp_runtime_class_init_1(dst);
		      dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    dst = **(BloomVolumeCPP ***)&dst[2].anamorphic;
		    if ( !dst )
		      goto LABEL_131;
		    if ( LODWORD(dst->dirtTexture) <= 0x39F )
		      goto LABEL_344;
		    if ( !*(_QWORD *)&dst[103].dirtIntensity )
		      goto LABEL_171;
		    v61 = IFix::WrappersManagerImpl::GetPatch(927, 0LL);
		    if ( !v61 )
		      goto LABEL_131;
		    *(float *)&v7 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_84(v61, intensityHighQuality, 0LL);
		  }
		LABEL_11:
		  if ( !v5 )
		    goto LABEL_131;
		  v5->intensity = *(float *)&v7;
		  tint = v4->fields.tint;
		  if ( !tint )
		    goto LABEL_131;
		  sub_1800049A0(tint->klass);
		  v5->tint = *(Color *)((__int64 (__fastcall *)(char *, ColorParameter *, Il2CppMethodPointer))tint->klass->vtable.get_value.method)(
		                         v80,
		                         tint,
		                         tint->klass->vtable.set_value.methodPtr);
		  src = (Bloom *)v4->fields.dirtTexture;
		  if ( !src )
		    goto LABEL_131;
		  v10 = sub_1800460A0(10LL, src);
		  dst = (BloomVolumeCPP *)TypeInfo::UnityEngine::Object;
		  v11 = v10;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    dst = (BloomVolumeCPP *)TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      dst = (BloomVolumeCPP *)TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( !v11 )
		    goto LABEL_19;
		  if ( !LODWORD(dst[3].tint.g) )
		    il2cpp_runtime_class_init_1(dst);
		  if ( *(_QWORD *)(v11 + 16) )
		  {
		    src = (Bloom *)v4->fields.dirtTexture;
		    if ( !src )
		      goto LABEL_131;
		    v62 = sub_1800460A0(10LL, src);
		    if ( !v62 )
		      goto LABEL_131;
		    v12 = *(void **)(v62 + 16);
		  }
		  else
		  {
		LABEL_19:
		    v12 = 0LL;
		  }
		  v5->dirtTexture = v12;
		  dirtIntensity = v4->fields.dirtIntensity;
		  if ( !dirtIntensity )
		    goto LABEL_131;
		  sub_1800049A0(dirtIntensity->klass);
		  v14 = (float (*)(AbilitySystem *, MethodInfo *))dirtIntensity->klass->vtable.get_value.method;
		  if ( v14 == Beyond::Gameplay::Core::AbilitySystem::get_detectedRadius )
		  {
		    dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    src = **(Bloom ***)&dst[2].anamorphic;
		    if ( !src )
		      goto LABEL_131;
		    if ( *(int *)&src->fields._.active <= 3314 )
		      goto LABEL_128;
		    if ( !LODWORD(dst[3].tint.g) )
		    {
		      il2cpp_runtime_class_init_1(dst);
		      dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    dst = **(BloomVolumeCPP ***)&dst[2].anamorphic;
		    if ( !dst )
		      goto LABEL_131;
		    if ( LODWORD(dst->dirtTexture) <= 0xCF2 )
		      goto LABEL_344;
		    if ( !*(_QWORD *)&dst[368].threshold )
		    {
		LABEL_128:
		      v53 = dirtIntensity[14].monitor;
		      if ( !v53 )
		        goto LABEL_131;
		      dst = (BloomVolumeCPP *)*((_QWORD *)v53 + 2);
		      if ( !dst )
		        goto LABEL_131;
		      a = dst->tint.a;
		      goto LABEL_25;
		    }
		    v63 = IFix::WrappersManagerImpl::GetPatch(3314, 0LL);
		    if ( !v63 )
		      goto LABEL_131;
		    goto LABEL_398;
		  }
		  if ( (char *)v14 == (char *)Beyond::TickableMono::get_tickInterval )
		  {
		    dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    src = **(Bloom ***)&dst[2].anamorphic;
		    if ( !src )
		      goto LABEL_131;
		    if ( *(int *)&src->fields._.active > 927 )
		    {
		      if ( !LODWORD(dst[3].tint.g) )
		      {
		        il2cpp_runtime_class_init_1(dst);
		        dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      dst = **(BloomVolumeCPP ***)&dst[2].anamorphic;
		      if ( !dst )
		        goto LABEL_131;
		      if ( LODWORD(dst->dirtTexture) <= 0x39F )
		        goto LABEL_344;
		      if ( *(_QWORD *)&dst[103].dirtIntensity )
		      {
		        v64 = IFix::WrappersManagerImpl::GetPatch(927, 0LL);
		        if ( !v64 )
		          goto LABEL_131;
		        a = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_84(v64, (Object *)dirtIntensity, 0LL);
		        goto LABEL_25;
		      }
		    }
		    goto LABEL_176;
		  }
		  if ( (char *)v14 != (char *)Beyond::NPC::Animation::AnimatorClothCalculator::AnimatorLookAtControllerHolder::get_weightBase )
		  {
		    a = ((float (__fastcall *)(MinFloatParameter *, Il2CppMethodPointer))v14)(
		          dirtIntensity,
		          dirtIntensity->klass->vtable.set_value.methodPtr);
		    goto LABEL_25;
		  }
		  dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  src = **(Bloom ***)&dst[2].anamorphic;
		  if ( !src )
		    goto LABEL_131;
		  if ( *(int *)&src->fields._.active > 2201 )
		  {
		    if ( !LODWORD(dst[3].tint.g) )
		    {
		      il2cpp_runtime_class_init_1(dst);
		      dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    src = **(Bloom ***)&dst[2].anamorphic;
		    if ( !src )
		      goto LABEL_131;
		    if ( *(_DWORD *)&src->fields._.active <= 0x899u )
		      goto LABEL_344;
		    if ( src[78].fields.characterBloomControl )
		    {
		      v63 = IFix::WrappersManagerImpl::GetPatch(2201, 0LL);
		      if ( !v63 )
		        goto LABEL_131;
		      goto LABEL_398;
		    }
		  }
		  if ( !*(_QWORD *)&dirtIntensity->fields.min )
		  {
		LABEL_176:
		    a = 0.0;
		    goto LABEL_25;
		  }
		  dirtIntensity = *(MinFloatParameter **)&dirtIntensity->fields.min;
		  if ( !LODWORD(dst[3].tint.g) )
		  {
		    il2cpp_runtime_class_init_1(dst);
		    dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  src = **(Bloom ***)&dst[2].anamorphic;
		  if ( !src )
		    goto LABEL_131;
		  if ( *(int *)&src->fields._.active <= 2202 )
		    goto LABEL_221;
		  if ( !LODWORD(dst[3].tint.g) )
		  {
		    il2cpp_runtime_class_init_1(dst);
		    dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  dst = **(BloomVolumeCPP ***)&dst[2].anamorphic;
		  if ( !dst )
		    goto LABEL_131;
		  if ( LODWORD(dst->dirtTexture) <= 0x89A )
		    goto LABEL_344;
		  if ( !*(_QWORD *)&dst[245].tint.g )
		  {
		LABEL_221:
		    a = *((float *)&dirtIntensity[5].klass + 1);
		    goto LABEL_25;
		  }
		  v63 = IFix::WrappersManagerImpl::GetPatch(2202, 0LL);
		  if ( !v63 )
		    goto LABEL_131;
		LABEL_398:
		  a = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)v63, (Object *)dirtIntensity, 0LL);
		LABEL_25:
		  v5->dirtIntensity = a;
		  src = (Bloom *)v4->fields.blendMode;
		  if ( !src )
		    goto LABEL_131;
		  v5->blendMode = sub_180002F70(10LL, src);
		  v5->anamorphic = anamorphism;
		  dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  src = **(Bloom ***)&dst[2].anamorphic;
		  if ( !src )
		    goto LABEL_131;
		  if ( *(int *)&src->fields._.active > 2667 )
		  {
		    if ( !LODWORD(dst[3].tint.g) )
		    {
		      il2cpp_runtime_class_init_1(dst);
		      dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    src = **(Bloom ***)&dst[2].anamorphic;
		    if ( !src )
		      goto LABEL_131;
		    if ( *(_DWORD *)&src->fields._.active <= 0xA6Bu )
		      goto LABEL_344;
		    if ( src[95].fields.thresholdMedQuality )
		    {
		      v65 = IFix::WrappersManagerImpl::GetPatch(2667, 0LL);
		      if ( !v65 )
		        goto LABEL_131;
		      v18 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)v65, (Object *)v4, 0LL);
		      goto LABEL_35;
		    }
		  }
		  scatterHighQuality = v4->fields.scatterHighQuality;
		  if ( !scatterHighQuality )
		    goto LABEL_131;
		  sub_1800049A0(scatterHighQuality->klass);
		  v17 = (float (*)(AbilitySystem *, MethodInfo *))scatterHighQuality->klass->vtable.get_value.method;
		  if ( v17 == Beyond::Gameplay::Core::AbilitySystem::get_detectedRadius )
		  {
		    dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    src = **(Bloom ***)&dst[2].anamorphic;
		    if ( !src )
		      goto LABEL_131;
		    if ( *(int *)&src->fields._.active <= 3314 )
		      goto LABEL_136;
		    if ( !LODWORD(dst[3].tint.g) )
		    {
		      il2cpp_runtime_class_init_1(dst);
		      dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    dst = **(BloomVolumeCPP ***)&dst[2].anamorphic;
		    if ( !dst )
		      goto LABEL_131;
		    if ( LODWORD(dst->dirtTexture) <= 0xCF2 )
		      goto LABEL_344;
		    if ( !*(_QWORD *)&dst[368].threshold )
		    {
		LABEL_136:
		      v54 = *(_QWORD *)&scatterHighQuality[11].fields.sliderExponent;
		      if ( !v54 )
		        goto LABEL_131;
		      dst = *(BloomVolumeCPP **)(v54 + 16);
		      if ( !dst )
		        goto LABEL_131;
		      v18 = dst->tint.a;
		      goto LABEL_35;
		    }
		    v66 = IFix::WrappersManagerImpl::GetPatch(3314, 0LL);
		    if ( !v66 )
		      goto LABEL_131;
		    goto LABEL_433;
		  }
		  if ( (char *)v17 == (char *)Beyond::TickableMono::get_tickInterval )
		  {
		    dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    src = **(Bloom ***)&dst[2].anamorphic;
		    if ( !src )
		      goto LABEL_131;
		    if ( *(int *)&src->fields._.active > 927 )
		    {
		      if ( !LODWORD(dst[3].tint.g) )
		      {
		        il2cpp_runtime_class_init_1(dst);
		        dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      dst = **(BloomVolumeCPP ***)&dst[2].anamorphic;
		      if ( !dst )
		        goto LABEL_131;
		      if ( LODWORD(dst->dirtTexture) <= 0x39F )
		        goto LABEL_344;
		      if ( *(_QWORD *)&dst[103].dirtIntensity )
		      {
		        v67 = IFix::WrappersManagerImpl::GetPatch(927, 0LL);
		        if ( !v67 )
		          goto LABEL_131;
		        v18 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_84(v67, (Object *)scatterHighQuality, 0LL);
		        goto LABEL_35;
		      }
		    }
		    goto LABEL_181;
		  }
		  if ( (char *)v17 == (char *)Beyond::NPC::Animation::AnimatorClothCalculator::AnimatorLookAtControllerHolder::get_weightBase )
		  {
		    dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    src = **(Bloom ***)&dst[2].anamorphic;
		    if ( !src )
		      goto LABEL_131;
		    if ( *(int *)&src->fields._.active > 2201 )
		    {
		      if ( !LODWORD(dst[3].tint.g) )
		      {
		        il2cpp_runtime_class_init_1(dst);
		        dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      src = **(Bloom ***)&dst[2].anamorphic;
		      if ( !src )
		        goto LABEL_131;
		      if ( *(_DWORD *)&src->fields._.active <= 0x899u )
		        goto LABEL_344;
		      if ( src[78].fields.characterBloomControl )
		      {
		        v66 = IFix::WrappersManagerImpl::GetPatch(2201, 0LL);
		        if ( !v66 )
		          goto LABEL_131;
		        goto LABEL_433;
		      }
		    }
		    if ( *(_QWORD *)&scatterHighQuality->fields.min )
		    {
		      scatterHighQuality = *(ClampedFloatParameter **)&scatterHighQuality->fields.min;
		      if ( !LODWORD(dst[3].tint.g) )
		      {
		        il2cpp_runtime_class_init_1(dst);
		        dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      src = **(Bloom ***)&dst[2].anamorphic;
		      if ( !src )
		        goto LABEL_131;
		      if ( *(int *)&src->fields._.active <= 2202 )
		        goto LABEL_231;
		      if ( !LODWORD(dst[3].tint.g) )
		      {
		        il2cpp_runtime_class_init_1(dst);
		        dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      dst = **(BloomVolumeCPP ***)&dst[2].anamorphic;
		      if ( !dst )
		        goto LABEL_131;
		      if ( LODWORD(dst->dirtTexture) <= 0x89A )
		        goto LABEL_344;
		      if ( !*(_QWORD *)&dst[245].tint.g )
		      {
		LABEL_231:
		        v18 = *((float *)&scatterHighQuality[4].monitor + 1);
		        goto LABEL_35;
		      }
		      v66 = IFix::WrappersManagerImpl::GetPatch(2202, 0LL);
		      if ( !v66 )
		        goto LABEL_131;
		LABEL_433:
		      v18 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46(
		              (ILFixDynamicMethodWrapper_15 *)v66,
		              (Object *)scatterHighQuality,
		              0LL);
		      goto LABEL_35;
		    }
		LABEL_181:
		    v18 = 0.0;
		    goto LABEL_35;
		  }
		  v18 = ((float (__fastcall *)(ClampedFloatParameter *, Il2CppMethodPointer))v17)(
		          scatterHighQuality,
		          scatterHighQuality->klass->vtable.set_value.methodPtr);
		LABEL_35:
		  v5->scatter = v18;
		  dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  src = **(Bloom ***)&dst[2].anamorphic;
		  if ( !src )
		    goto LABEL_131;
		  if ( *(int *)&src->fields._.active > 2665 )
		  {
		    if ( !LODWORD(dst[3].tint.g) )
		    {
		      il2cpp_runtime_class_init_1(dst);
		      dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    src = **(Bloom ***)&dst[2].anamorphic;
		    if ( !src )
		      goto LABEL_131;
		    if ( *(_DWORD *)&src->fields._.active <= 0xA69u )
		      goto LABEL_344;
		    if ( src[95].fields.resolutionLowQuality )
		    {
		      v68 = IFix::WrappersManagerImpl::GetPatch(2665, 0LL);
		      if ( !v68 )
		        goto LABEL_131;
		      v21 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)v68, (Object *)v4, 0LL);
		      goto LABEL_44;
		    }
		  }
		  thresholdHighQuality = v4->fields.thresholdHighQuality;
		  if ( !thresholdHighQuality )
		    goto LABEL_131;
		  sub_1800049A0(thresholdHighQuality->klass);
		  v20 = thresholdHighQuality->klass->vtable.get_value.method;
		  if ( v20 == (const MethodInfo *)Beyond::Gameplay::Core::AbilitySystem::get_detectedRadius )
		  {
		    dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    src = **(Bloom ***)&dst[2].anamorphic;
		    if ( !src )
		      goto LABEL_131;
		    if ( *(int *)&src->fields._.active > 3314 )
		    {
		      if ( !LODWORD(dst[3].tint.g) )
		      {
		        il2cpp_runtime_class_init_1(dst);
		        dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      dst = **(BloomVolumeCPP ***)&dst[2].anamorphic;
		      if ( !dst )
		        goto LABEL_131;
		      if ( LODWORD(dst->dirtTexture) <= 0xCF2 )
		        goto LABEL_344;
		      if ( *(_QWORD *)&dst[368].threshold )
		      {
		        v69 = IFix::WrappersManagerImpl::GetPatch(3314, 0LL);
		        if ( !v69 )
		          goto LABEL_131;
		        goto LABEL_468;
		      }
		    }
		    v55 = thresholdHighQuality[14].monitor;
		    if ( !v55 )
		      goto LABEL_131;
		    dst = (BloomVolumeCPP *)*((_QWORD *)v55 + 2);
		    if ( !dst )
		      goto LABEL_131;
		    v21 = dst->tint.a;
		  }
		  else
		  {
		    if ( v20 != (const MethodInfo *)Beyond::TickableMono::get_tickInterval )
		    {
		      if ( v20 != (const MethodInfo *)Beyond::NPC::Animation::AnimatorClothCalculator::AnimatorLookAtControllerHolder::get_weightBase )
		      {
		        v21 = ((float (__fastcall *)(MinFloatParameter *, Il2CppMethodPointer))v20)(
		                thresholdHighQuality,
		                thresholdHighQuality->klass->vtable.set_value.methodPtr);
		        goto LABEL_44;
		      }
		      dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		        dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      src = **(Bloom ***)&dst[2].anamorphic;
		      if ( !src )
		        goto LABEL_131;
		      if ( *(int *)&src->fields._.active > 2201 )
		      {
		        if ( !LODWORD(dst[3].tint.g) )
		        {
		          il2cpp_runtime_class_init_1(dst);
		          dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        }
		        src = **(Bloom ***)&dst[2].anamorphic;
		        if ( !src )
		          goto LABEL_131;
		        if ( *(_DWORD *)&src->fields._.active <= 0x899u )
		          goto LABEL_344;
		        if ( src[78].fields.characterBloomControl )
		        {
		          v69 = IFix::WrappersManagerImpl::GetPatch(2201, 0LL);
		          if ( !v69 )
		            goto LABEL_131;
		LABEL_468:
		          v21 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46(
		                  (ILFixDynamicMethodWrapper_15 *)v69,
		                  (Object *)thresholdHighQuality,
		                  0LL);
		          goto LABEL_44;
		        }
		      }
		      if ( *(_QWORD *)&thresholdHighQuality->fields.min )
		      {
		        thresholdHighQuality = *(MinFloatParameter **)&thresholdHighQuality->fields.min;
		        if ( !LODWORD(dst[3].tint.g) )
		        {
		          il2cpp_runtime_class_init_1(dst);
		          dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        }
		        src = **(Bloom ***)&dst[2].anamorphic;
		        if ( !src )
		          goto LABEL_131;
		        if ( *(int *)&src->fields._.active <= 2202 )
		          goto LABEL_241;
		        if ( !LODWORD(dst[3].tint.g) )
		        {
		          il2cpp_runtime_class_init_1(dst);
		          dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        }
		        dst = **(BloomVolumeCPP ***)&dst[2].anamorphic;
		        if ( !dst )
		          goto LABEL_131;
		        if ( LODWORD(dst->dirtTexture) <= 0x89A )
		          goto LABEL_344;
		        if ( !*(_QWORD *)&dst[245].tint.g )
		        {
		LABEL_241:
		          v21 = *((float *)&thresholdHighQuality[5].klass + 1);
		          goto LABEL_44;
		        }
		        v69 = IFix::WrappersManagerImpl::GetPatch(2202, 0LL);
		        if ( !v69 )
		          goto LABEL_131;
		        goto LABEL_468;
		      }
		LABEL_186:
		      v21 = 0.0;
		      goto LABEL_44;
		    }
		    dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    src = **(Bloom ***)&dst[2].anamorphic;
		    if ( !src )
		      goto LABEL_131;
		    if ( *(int *)&src->fields._.active <= 927 )
		      goto LABEL_186;
		    if ( !LODWORD(dst[3].tint.g) )
		    {
		      il2cpp_runtime_class_init_1(dst);
		      dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    dst = **(BloomVolumeCPP ***)&dst[2].anamorphic;
		    if ( !dst )
		      goto LABEL_131;
		    if ( LODWORD(dst->dirtTexture) <= 0x39F )
		      goto LABEL_344;
		    if ( !*(_QWORD *)&dst[103].dirtIntensity )
		      goto LABEL_186;
		    v70 = IFix::WrappersManagerImpl::GetPatch(927, 0LL);
		    if ( !v70 )
		      goto LABEL_131;
		    v21 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_84(v70, (Object *)thresholdHighQuality, 0LL);
		  }
		LABEL_44:
		  v5->threshold = v21;
		  characterThreshold = v4->fields.characterThreshold;
		  if ( !characterThreshold )
		    goto LABEL_131;
		  sub_1800049A0(characterThreshold->klass);
		  v23 = characterThreshold->klass->vtable.get_value.method;
		  if ( v23 == (const MethodInfo *)Beyond::Gameplay::Core::AbilitySystem::get_detectedRadius )
		  {
		    dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    src = **(Bloom ***)&dst[2].anamorphic;
		    if ( !src )
		      goto LABEL_131;
		    if ( *(int *)&src->fields._.active > 3314 )
		    {
		      if ( !LODWORD(dst[3].tint.g) )
		      {
		        il2cpp_runtime_class_init_1(dst);
		        dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      dst = **(BloomVolumeCPP ***)&dst[2].anamorphic;
		      if ( !dst )
		        goto LABEL_131;
		      if ( LODWORD(dst->dirtTexture) <= 0xCF2 )
		        goto LABEL_344;
		      if ( *(_QWORD *)&dst[368].threshold )
		      {
		        v71 = IFix::WrappersManagerImpl::GetPatch(3314, 0LL);
		        if ( !v71 )
		          goto LABEL_131;
		        goto LABEL_496;
		      }
		    }
		    v56 = characterThreshold[14].monitor;
		    if ( !v56 )
		      goto LABEL_131;
		    dst = (BloomVolumeCPP *)*((_QWORD *)v56 + 2);
		    if ( !dst )
		      goto LABEL_131;
		    v24 = dst->tint.a;
		  }
		  else
		  {
		    if ( v23 != (const MethodInfo *)Beyond::TickableMono::get_tickInterval )
		    {
		      if ( v23 != (const MethodInfo *)Beyond::NPC::Animation::AnimatorClothCalculator::AnimatorLookAtControllerHolder::get_weightBase )
		      {
		        v24 = ((float (__fastcall *)(MinFloatParameter *, Il2CppMethodPointer))v23)(
		                characterThreshold,
		                characterThreshold->klass->vtable.set_value.methodPtr);
		        goto LABEL_49;
		      }
		      dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		        dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      src = **(Bloom ***)&dst[2].anamorphic;
		      if ( !src )
		        goto LABEL_131;
		      if ( *(int *)&src->fields._.active > 2201 )
		      {
		        if ( !LODWORD(dst[3].tint.g) )
		        {
		          il2cpp_runtime_class_init_1(dst);
		          dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        }
		        src = **(Bloom ***)&dst[2].anamorphic;
		        if ( !src )
		          goto LABEL_131;
		        if ( *(_DWORD *)&src->fields._.active <= 0x899u )
		          goto LABEL_344;
		        if ( src[78].fields.characterBloomControl )
		        {
		          v71 = IFix::WrappersManagerImpl::GetPatch(2201, 0LL);
		          if ( !v71 )
		            goto LABEL_131;
		LABEL_496:
		          v24 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46(
		                  (ILFixDynamicMethodWrapper_15 *)v71,
		                  (Object *)characterThreshold,
		                  0LL);
		          goto LABEL_49;
		        }
		      }
		      if ( *(_QWORD *)&characterThreshold->fields.min )
		      {
		        characterThreshold = *(MinFloatParameter **)&characterThreshold->fields.min;
		        if ( !LODWORD(dst[3].tint.g) )
		        {
		          il2cpp_runtime_class_init_1(dst);
		          dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        }
		        src = **(Bloom ***)&dst[2].anamorphic;
		        if ( !src )
		          goto LABEL_131;
		        if ( *(int *)&src->fields._.active <= 2202 )
		          goto LABEL_251;
		        if ( !LODWORD(dst[3].tint.g) )
		        {
		          il2cpp_runtime_class_init_1(dst);
		          dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        }
		        dst = **(BloomVolumeCPP ***)&dst[2].anamorphic;
		        if ( !dst )
		          goto LABEL_131;
		        if ( LODWORD(dst->dirtTexture) <= 0x89A )
		          goto LABEL_344;
		        if ( !*(_QWORD *)&dst[245].tint.g )
		        {
		LABEL_251:
		          v24 = *((float *)&characterThreshold[5].klass + 1);
		          goto LABEL_49;
		        }
		        v71 = IFix::WrappersManagerImpl::GetPatch(2202, 0LL);
		        if ( !v71 )
		          goto LABEL_131;
		        goto LABEL_496;
		      }
		LABEL_191:
		      v24 = 0.0;
		      goto LABEL_49;
		    }
		    dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    src = **(Bloom ***)&dst[2].anamorphic;
		    if ( !src )
		      goto LABEL_131;
		    if ( *(int *)&src->fields._.active <= 927 )
		      goto LABEL_191;
		    if ( !LODWORD(dst[3].tint.g) )
		    {
		      il2cpp_runtime_class_init_1(dst);
		      dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    dst = **(BloomVolumeCPP ***)&dst[2].anamorphic;
		    if ( !dst )
		      goto LABEL_131;
		    if ( LODWORD(dst->dirtTexture) <= 0x39F )
		      goto LABEL_344;
		    if ( !*(_QWORD *)&dst[103].dirtIntensity )
		      goto LABEL_191;
		    v72 = IFix::WrappersManagerImpl::GetPatch(927, 0LL);
		    if ( !v72 )
		      goto LABEL_131;
		    v24 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_84(v72, (Object *)characterThreshold, 0LL);
		  }
		LABEL_49:
		  v5->characterThreshold = v24;
		  characterSoftness = v4->fields.characterSoftness;
		  if ( !characterSoftness )
		    goto LABEL_131;
		  sub_1800049A0(characterSoftness->klass);
		  v26 = characterSoftness->klass->vtable.get_value.method;
		  if ( v26 == (const MethodInfo *)Beyond::Gameplay::Core::AbilitySystem::get_detectedRadius )
		  {
		    dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    src = **(Bloom ***)&dst[2].anamorphic;
		    if ( !src )
		      goto LABEL_131;
		    if ( *(int *)&src->fields._.active > 3314 )
		    {
		      if ( !LODWORD(dst[3].tint.g) )
		      {
		        il2cpp_runtime_class_init_1(dst);
		        dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      dst = **(BloomVolumeCPP ***)&dst[2].anamorphic;
		      if ( !dst )
		        goto LABEL_131;
		      if ( LODWORD(dst->dirtTexture) <= 0xCF2 )
		        goto LABEL_344;
		      if ( *(_QWORD *)&dst[368].threshold )
		      {
		        v73 = IFix::WrappersManagerImpl::GetPatch(3314, 0LL);
		        if ( !v73 )
		          goto LABEL_131;
		        goto LABEL_524;
		      }
		    }
		    v57 = *(_QWORD *)&characterSoftness[11].fields.sliderExponent;
		    if ( !v57 )
		      goto LABEL_131;
		    dst = *(BloomVolumeCPP **)(v57 + 16);
		    if ( !dst )
		      goto LABEL_131;
		    v27 = dst->tint.a;
		  }
		  else
		  {
		    if ( v26 != (const MethodInfo *)Beyond::TickableMono::get_tickInterval )
		    {
		      if ( v26 != (const MethodInfo *)Beyond::NPC::Animation::AnimatorClothCalculator::AnimatorLookAtControllerHolder::get_weightBase )
		      {
		        v27 = ((float (__fastcall *)(ClampedFloatParameter *, Il2CppMethodPointer))v26)(
		                characterSoftness,
		                characterSoftness->klass->vtable.set_value.methodPtr);
		        goto LABEL_54;
		      }
		      dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		        dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      src = **(Bloom ***)&dst[2].anamorphic;
		      if ( !src )
		        goto LABEL_131;
		      if ( *(int *)&src->fields._.active > 2201 )
		      {
		        if ( !LODWORD(dst[3].tint.g) )
		        {
		          il2cpp_runtime_class_init_1(dst);
		          dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        }
		        src = **(Bloom ***)&dst[2].anamorphic;
		        if ( !src )
		          goto LABEL_131;
		        if ( *(_DWORD *)&src->fields._.active <= 0x899u )
		          goto LABEL_344;
		        if ( src[78].fields.characterBloomControl )
		        {
		          v73 = IFix::WrappersManagerImpl::GetPatch(2201, 0LL);
		          if ( !v73 )
		            goto LABEL_131;
		LABEL_524:
		          v27 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46(
		                  (ILFixDynamicMethodWrapper_15 *)v73,
		                  (Object *)characterSoftness,
		                  0LL);
		          goto LABEL_54;
		        }
		      }
		      if ( *(_QWORD *)&characterSoftness->fields.min )
		      {
		        characterSoftness = *(ClampedFloatParameter **)&characterSoftness->fields.min;
		        if ( !LODWORD(dst[3].tint.g) )
		        {
		          il2cpp_runtime_class_init_1(dst);
		          dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        }
		        src = **(Bloom ***)&dst[2].anamorphic;
		        if ( !src )
		          goto LABEL_131;
		        if ( *(int *)&src->fields._.active <= 2202 )
		          goto LABEL_261;
		        if ( !LODWORD(dst[3].tint.g) )
		        {
		          il2cpp_runtime_class_init_1(dst);
		          dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        }
		        dst = **(BloomVolumeCPP ***)&dst[2].anamorphic;
		        if ( !dst )
		          goto LABEL_131;
		        if ( LODWORD(dst->dirtTexture) <= 0x89A )
		          goto LABEL_344;
		        if ( !*(_QWORD *)&dst[245].tint.g )
		        {
		LABEL_261:
		          v27 = *((float *)&characterSoftness[4].monitor + 1);
		          goto LABEL_54;
		        }
		        v73 = IFix::WrappersManagerImpl::GetPatch(2202, 0LL);
		        if ( !v73 )
		          goto LABEL_131;
		        goto LABEL_524;
		      }
		LABEL_196:
		      v27 = 0.0;
		      goto LABEL_54;
		    }
		    dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    src = **(Bloom ***)&dst[2].anamorphic;
		    if ( !src )
		      goto LABEL_131;
		    if ( *(int *)&src->fields._.active <= 927 )
		      goto LABEL_196;
		    if ( !LODWORD(dst[3].tint.g) )
		    {
		      il2cpp_runtime_class_init_1(dst);
		      dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    dst = **(BloomVolumeCPP ***)&dst[2].anamorphic;
		    if ( !dst )
		      goto LABEL_131;
		    if ( LODWORD(dst->dirtTexture) <= 0x39F )
		      goto LABEL_344;
		    if ( !*(_QWORD *)&dst[103].dirtIntensity )
		      goto LABEL_196;
		    v74 = IFix::WrappersManagerImpl::GetPatch(927, 0LL);
		    if ( !v74 )
		      goto LABEL_131;
		    v27 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_84(v74, (Object *)characterSoftness, 0LL);
		  }
		LABEL_54:
		  v5->characterSoftness = v27;
		  characterIntensity = v4->fields.characterIntensity;
		  if ( !characterIntensity )
		    goto LABEL_131;
		  sub_1800049A0(characterIntensity->klass);
		  v29 = (float (*)(AbilitySystem *, MethodInfo *))characterIntensity->klass->vtable.get_value.method;
		  if ( v29 == Beyond::Gameplay::Core::AbilitySystem::get_detectedRadius )
		  {
		    dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    src = **(Bloom ***)&dst[2].anamorphic;
		    if ( !src )
		      goto LABEL_131;
		    if ( *(int *)&src->fields._.active <= 3314 )
		      goto LABEL_164;
		    if ( !LODWORD(dst[3].tint.g) )
		    {
		      il2cpp_runtime_class_init_1(dst);
		      dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    src = **(Bloom ***)&dst[2].anamorphic;
		    if ( !src )
		      goto LABEL_131;
		    if ( *(_DWORD *)&src->fields._.active <= 0xCF2u )
		      goto LABEL_344;
		    if ( !src[118].fields.intensityMedQuality )
		    {
		LABEL_164:
		      v58 = *(_QWORD *)&characterIntensity[11].fields.sliderExponent;
		      if ( !v58 )
		        goto LABEL_131;
		      dst = *(BloomVolumeCPP **)(v58 + 16);
		      if ( !dst )
		        goto LABEL_131;
		      v30 = dst->tint.a;
		      goto LABEL_59;
		    }
		    v75 = IFix::WrappersManagerImpl::GetPatch(3314, 0LL);
		    if ( !v75 )
		      goto LABEL_131;
		    goto LABEL_552;
		  }
		  if ( (char *)v29 == (char *)Beyond::TickableMono::get_tickInterval )
		  {
		    dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    src = **(Bloom ***)&dst[2].anamorphic;
		    if ( !src )
		      goto LABEL_131;
		    if ( *(int *)&src->fields._.active > 927 )
		    {
		      if ( !LODWORD(dst[3].tint.g) )
		      {
		        il2cpp_runtime_class_init_1(dst);
		        dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      src = **(Bloom ***)&dst[2].anamorphic;
		      if ( !src )
		        goto LABEL_131;
		      if ( *(_DWORD *)&src->fields._.active <= 0x39Fu )
		        goto LABEL_344;
		      if ( src[33].fields.resolutionHighQuality )
		      {
		        v76 = IFix::WrappersManagerImpl::GetPatch(927, 0LL);
		        if ( !v76 )
		          goto LABEL_131;
		        v30 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_84(v76, (Object *)characterIntensity, 0LL);
		        goto LABEL_59;
		      }
		    }
		    goto LABEL_201;
		  }
		  if ( (char *)v29 == (char *)Beyond::NPC::Animation::AnimatorClothCalculator::AnimatorLookAtControllerHolder::get_weightBase )
		  {
		    dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    src = **(Bloom ***)&dst[2].anamorphic;
		    if ( !src )
		      goto LABEL_131;
		    if ( *(int *)&src->fields._.active > 2201 )
		    {
		      if ( !LODWORD(dst[3].tint.g) )
		      {
		        il2cpp_runtime_class_init_1(dst);
		        dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      src = **(Bloom ***)&dst[2].anamorphic;
		      if ( !src )
		        goto LABEL_131;
		      if ( *(_DWORD *)&src->fields._.active <= 0x899u )
		        goto LABEL_344;
		      if ( src[78].fields.characterBloomControl )
		      {
		        v75 = IFix::WrappersManagerImpl::GetPatch(2201, 0LL);
		        if ( !v75 )
		          goto LABEL_131;
		        goto LABEL_552;
		      }
		    }
		    if ( *(_QWORD *)&characterIntensity->fields.min )
		    {
		      characterIntensity = *(ClampedFloatParameter **)&characterIntensity->fields.min;
		      if ( !LODWORD(dst[3].tint.g) )
		      {
		        il2cpp_runtime_class_init_1(dst);
		        dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      src = **(Bloom ***)&dst[2].anamorphic;
		      if ( !src )
		        goto LABEL_131;
		      if ( *(int *)&src->fields._.active <= 2202 )
		        goto LABEL_271;
		      if ( !LODWORD(dst[3].tint.g) )
		      {
		        il2cpp_runtime_class_init_1(dst);
		        dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      src = **(Bloom ***)&dst[2].anamorphic;
		      if ( !src )
		        goto LABEL_131;
		      if ( *(_DWORD *)&src->fields._.active <= 0x89Au )
		        goto LABEL_344;
		      if ( !src[78].fields.characterThreshold )
		      {
		LABEL_271:
		        v30 = *((float *)&characterIntensity[4].monitor + 1);
		        goto LABEL_59;
		      }
		      v75 = IFix::WrappersManagerImpl::GetPatch(2202, 0LL);
		      if ( !v75 )
		        goto LABEL_131;
		LABEL_552:
		      v30 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46(
		              (ILFixDynamicMethodWrapper_15 *)v75,
		              (Object *)characterIntensity,
		              0LL);
		      goto LABEL_59;
		    }
		LABEL_201:
		    v30 = 0.0;
		    goto LABEL_59;
		  }
		  v30 = ((float (__fastcall *)(ClampedFloatParameter *, Il2CppMethodPointer))v29)(
		          characterIntensity,
		          characterIntensity->klass->vtable.set_value.methodPtr);
		LABEL_59:
		  v5->characterIntensity = v30;
		  dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  src = **(Bloom ***)&dst[2].anamorphic;
		  if ( !src )
		    goto LABEL_131;
		  if ( *(int *)&src->fields._.active <= 2664 )
		    goto LABEL_63;
		  if ( !LODWORD(dst[3].tint.g) )
		  {
		    il2cpp_runtime_class_init_1(dst);
		    dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  src = **(Bloom ***)&dst[2].anamorphic;
		  if ( !src )
		    goto LABEL_131;
		  if ( *(_DWORD *)&src->fields._.active <= 0xA68u )
		    goto LABEL_344;
		  if ( !src[95].fields.resolutionMedQuality )
		  {
		LABEL_63:
		    src = (Bloom *)v4->fields.quality;
		    if ( !src )
		      goto LABEL_131;
		    v31 = sub_180002F70(10LL, src);
		    if ( v31 == 2 )
		    {
		      src = (Bloom *)v4->fields.resolutionHighQuality;
		      if ( !src )
		        goto LABEL_131;
		    }
		    else if ( v31 )
		    {
		      if ( v31 != 1 )
		      {
		        v32 = 2;
		        goto LABEL_67;
		      }
		      src = (Bloom *)v4->fields.resolutionMedQuality;
		      if ( !src )
		        goto LABEL_131;
		    }
		    else
		    {
		      src = (Bloom *)v4->fields.resolutionLowQuality;
		      if ( !src )
		        goto LABEL_131;
		    }
		    v32 = sub_180002F70(10LL, src);
		    goto LABEL_67;
		  }
		  v77 = IFix::WrappersManagerImpl::GetPatch(2664, 0LL);
		  if ( !v77 )
		    goto LABEL_131;
		  v32 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_7((ILFixDynamicMethodWrapper_26 *)v77, (Object *)v4, 0LL);
		LABEL_67:
		  v5->resolution = v32;
		  dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  src = **(Bloom ***)&dst[2].anamorphic;
		  if ( !src )
		    goto LABEL_131;
		  if ( *(int *)&src->fields._.active <= 2668 )
		    goto LABEL_71;
		  if ( !LODWORD(dst[3].tint.g) )
		  {
		    il2cpp_runtime_class_init_1(dst);
		    dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  dst = **(BloomVolumeCPP ***)&dst[2].anamorphic;
		  if ( !dst )
		    goto LABEL_131;
		  if ( LODWORD(dst->dirtTexture) <= 0xA6C )
		LABEL_344:
		    sub_1800D2AB0(dst, src);
		  if ( *(_QWORD *)&dst[296].resolution )
		  {
		    v78 = IFix::WrappersManagerImpl::GetPatch(2668, 0LL);
		    if ( v78 )
		    {
		      v35 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)v78, (Object *)v4, 0LL);
		      goto LABEL_78;
		    }
		LABEL_131:
		    sub_1800D8260(dst, src);
		  }
		LABEL_71:
		  src = (Bloom *)v4->fields.dirtTexture;
		  if ( !src )
		    goto LABEL_131;
		  v33 = sub_1800460A0(10LL, src);
		  dst = (BloomVolumeCPP *)TypeInfo::UnityEngine::Object;
		  v34 = v33;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    dst = (BloomVolumeCPP *)TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      dst = (BloomVolumeCPP *)TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( !v34 )
		    goto LABEL_77;
		  if ( !LODWORD(dst[3].tint.g) )
		    il2cpp_runtime_class_init_1(dst);
		  if ( !*(_QWORD *)(v34 + 16) )
		  {
		LABEL_77:
		    v35 = 0;
		    goto LABEL_78;
		  }
		  src = (Bloom *)v4->fields.dirtIntensity;
		  if ( !src )
		    goto LABEL_131;
		  LOWORD(dst) = 10;
		  v79 = sub_1800057D0(dst, src);
		  v35 = *(float *)&v79 > 0.0;
		LABEL_78:
		  v5->enableBloomDirt = v35;
		  characterBloomControl = (BloomVolumeCPP **)v4->fields.characterBloomControl;
		  if ( !characterBloomControl )
		    goto LABEL_131;
		  sub_1800049A0(*characterBloomControl);
		  v37 = *(bool (**)(RuntimeType *, MethodInfo *))&(*characterBloomControl)[6].threshold;
		  src = *(Bloom **)&(*characterBloomControl)[6].characterSoftness;
		  if ( v37 == System::RuntimeType::HasElementTypeImpl )
		  {
		    v45 = characterBloomControl[2];
		    if ( (LODWORD(v45->tint.g) & 0x20000000) != 0
		      || (v46 = BYTE2(v45->tint.g), v46 == 29)
		      || v46 == 16
		      || v46 == 20
		      || v46 == 15 )
		    {
		LABEL_112:
		      v38 = 1;
		      goto LABEL_83;
		    }
		LABEL_100:
		    v38 = 0;
		    goto LABEL_83;
		  }
		  if ( v37 != System::RuntimeType::get_IsGenericType )
		  {
		    if ( v37 != System::RuntimeType::get_IsGenericParameter )
		    {
		      v38 = ((__int64 (__fastcall *)(BloomVolumeCPP **, Bloom *))v37)(characterBloomControl, src);
		      goto LABEL_83;
		    }
		    v50 = characterBloomControl[2];
		    if ( (LODWORD(v50->tint.g) & 0x20000000) == 0 && (BYTE2(v50->tint.g) == 19 || BYTE2(v50->tint.g) == 30) )
		      goto LABEL_112;
		    goto LABEL_100;
		  }
		  dst = characterBloomControl[2];
		  if ( (LODWORD(dst->tint.g) & 0x20000000) == 0 )
		  {
		    LOBYTE(src) = 1;
		    v47 = sub_180028750(dst, src);
		    if ( (*(_BYTE *)(v47 + 312) & 0x10) == 0 && !*(_QWORD *)(v47 + 96) )
		    {
		      v38 = 0;
		      goto LABEL_83;
		    }
		    goto LABEL_112;
		  }
		  v38 = 0;
		LABEL_83:
		  v5->enableCharacterBloomControl = v38;
		  v5->enableAlpha = 0;
		  anamorphic = v4->fields.anamorphic;
		  if ( !anamorphic )
		    goto LABEL_131;
		  sub_1800049A0(anamorphic->klass);
		  v40 = (bool (*)(RuntimeType *, MethodInfo *))anamorphic->klass->vtable.get_value.method;
		  methodPtr = anamorphic->klass->vtable.set_value.methodPtr;
		  if ( v40 == System::RuntimeType::HasElementTypeImpl )
		  {
		    v43 = anamorphic->fields._._;
		    if ( (*(_DWORD *)(*(_QWORD *)&v43 + 8LL) & 0x20000000) != 0 )
		      goto LABEL_116;
		    v44 = *(_BYTE *)(*(_QWORD *)&v43 + 10LL);
		    if ( v44 == 29 || v44 == 16 || v44 == 20 || v44 == 15 )
		      goto LABEL_116;
		    goto LABEL_94;
		  }
		  if ( v40 == System::RuntimeType::get_IsGenericType )
		  {
		    v48 = anamorphic->fields._._;
		    if ( (*(_DWORD *)(*(_QWORD *)&v48 + 8LL) & 0x20000000) == 0 )
		    {
		      LOBYTE(methodPtr) = 1;
		      v49 = ((__int64 (__fastcall *)(_QWORD, _QWORD))sub_180028750)(v48, methodPtr);
		      if ( (*(_BYTE *)(v49 + 312) & 0x10) != 0 || *(_QWORD *)(v49 + 96) )
		        goto LABEL_116;
		    }
		    goto LABEL_94;
		  }
		  if ( v40 == System::RuntimeType::get_IsGenericParameter )
		  {
		    v51 = anamorphic->fields._._;
		    if ( (*(_DWORD *)(*(_QWORD *)&v51 + 8LL) & 0x20000000) == 0
		      && (*(_BYTE *)(*(_QWORD *)&v51 + 10LL) == 19 || *(_BYTE *)(*(_QWORD *)&v51 + 10LL) == 30) )
		    {
		LABEL_116:
		      v42 = 1;
		      goto LABEL_88;
		    }
		LABEL_94:
		    v42 = 0;
		    goto LABEL_88;
		  }
		  v42 = ((__int64 (__fastcall *)(BoolParameter *, Il2CppMethodPointer))v40)(anamorphic, methodPtr);
		LABEL_88:
		  v5->enableAnamorphic = v42;
		}
		
	}
}
