using System;
using UnityEngine.HyperGryphEngineCode;

namespace HG.Rendering.Runtime
{
	public class HGUtilsCpp
	{
		public HGUtilsCpp()
		{
			// // Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
			// void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
			//         HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
			//         HGWindConfig *cSrc,
			//         HGWindConfig *cDst,
			//         float t,
			//         MethodInfo *method)
			// {
			//   ;
			// }
			// 
		}

		public unsafe static HGSettingParametersCpp* ConvertSettingParamsToCpp(HGSettingParameters settingParameters)
		{
			// // HGSettingParametersCpp* ConvertSettingParamsToCpp(HGSettingParameters)
			// HGSettingParametersCpp *HG::Rendering::Runtime::HGUtilsCpp::ConvertSettingParamsToCpp(
			//         HGSettingParameters *settingParameters,
			//         MethodInfo *method)
			// {
			//   Void *TempFromCSharp; // rbx
			//   __int64 v4; // rdx
			//   unsigned __int64 s_settingParameters; // rcx
			//   SettingParameter_1_System_Single_ *cullingViewScreenSizeMin_k__BackingField; // rbp
			//   struct MethodInfo *v7; // rsi
			//   Il2CppClass *klass; // rax
			//   __int64 v9; // rax
			//   SettingParameter_1_System_Single_ *ocScreenSizeMin_k__BackingField; // rbp
			//   struct MethodInfo *v11; // rsi
			//   Il2CppClass *v12; // rax
			//   __int64 v13; // rax
			//   SettingParameter_1_System_Boolean_ *taauEnable_k__BackingField; // rbp
			//   struct MethodInfo *v15; // rsi
			//   Il2CppClass *v16; // rax
			//   __int64 v17; // rax
			//   SettingParameter_1_TAAUQuality_ *taauQuality_k__BackingField; // rax
			//   SettingParameter_1_System_Single_ *historyWeight_k__BackingField; // rbp
			//   struct MethodInfo *v20; // rsi
			//   Il2CppClass *v21; // rax
			//   __int64 v22; // rax
			//   SettingParameter_1_System_Single_ *historyWeightInMotion_k__BackingField; // rbp
			//   struct MethodInfo *v24; // rsi
			//   Il2CppClass *v25; // rax
			//   __int64 v26; // rax
			//   SettingParameter_1_System_Single_ *fastConvergeHistoryWeight_k__BackingField; // rbp
			//   struct MethodInfo *v28; // rsi
			//   Il2CppClass *v29; // rax
			//   __int64 v30; // rax
			//   SettingParameter_1_System_Single_ *responsiveAAWeight_k__BackingField; // rbp
			//   struct MethodInfo *v32; // rsi
			//   Il2CppClass *v33; // rax
			//   __int64 v34; // rax
			//   SettingParameter_1_System_Single_ *minMotion_k__BackingField; // rbp
			//   struct MethodInfo *v36; // rsi
			//   Il2CppClass *v37; // rax
			//   __int64 v38; // rax
			//   SettingParameter_1_System_Single_ *maxMotion_k__BackingField; // rbp
			//   struct MethodInfo *v40; // rsi
			//   Il2CppClass *v41; // rax
			//   __int64 v42; // rax
			//   SettingParameter_1_System_Single_ *characterMotionSensitivity_k__BackingField; // rbp
			//   struct MethodInfo *v44; // rsi
			//   Il2CppClass *v45; // rax
			//   __int64 v46; // rax
			//   SettingParameter_1_System_Single_ *occlusionDepthDiff_k__BackingField; // rbp
			//   struct MethodInfo *v48; // rsi
			//   Il2CppClass *v49; // rax
			//   __int64 v50; // rax
			//   SettingParameter_1_System_Single_ *inputLumaWeight_k__BackingField; // rbp
			//   struct MethodInfo *v52; // rsi
			//   Il2CppClass *v53; // rax
			//   __int64 v54; // rax
			//   SettingParameter_1_System_Single_ *sharpenStrength1K_k__BackingField; // rbp
			//   struct MethodInfo *v56; // rsi
			//   Il2CppClass *v57; // rax
			//   __int64 v58; // rax
			//   SettingParameter_1_System_Single_ *sharpenStrength2K_k__BackingField; // rbp
			//   struct MethodInfo *v60; // rsi
			//   Il2CppClass *v61; // rax
			//   __int64 v62; // rax
			//   SettingParameter_1_System_Single_ *sharpenStrength4K_k__BackingField; // rbp
			//   struct MethodInfo *v64; // rsi
			//   Il2CppClass *v65; // rax
			//   __int64 v66; // rax
			//   SettingParameter_1_System_Boolean_ *pssrEnable_k__BackingField; // rbp
			//   struct MethodInfo *v68; // rsi
			//   Il2CppClass *v69; // rax
			//   __int64 v70; // rax
			//   SettingParameter_1_System_Boolean_ *pssrPassThrough_k__BackingField; // rbp
			//   struct MethodInfo *v72; // rsi
			//   Il2CppClass *v73; // rax
			//   __int64 v74; // rax
			//   SettingParameter_1_System_Boolean_ *dlssEnable_k__BackingField; // rbp
			//   struct MethodInfo *v76; // rsi
			//   __int64 v77; // rax
			//   SettingParameter_1_System_Boolean_ *dlssUseAutoExposure_k__BackingField; // rbp
			//   struct MethodInfo *v79; // rsi
			//   __int64 v80; // rax
			//   SettingParameter_1_System_Int32_ *dlssGGenFrames_k__BackingField; // rax
			//   SettingParameter_1_System_Boolean_ *dlssPCLEnable_k__BackingField; // rbp
			//   struct MethodInfo *v83; // rsi
			//   __int64 v84; // rax
			//   __int64 v85; // rdx
			//   double v86; // xmm0_8
			//   __int64 v87; // rdx
			//   __int64 v88; // rdx
			//   double v89; // xmm0_8
			//   __int64 v90; // rdx
			//   __int64 v91; // rdx
			//   __int64 v92; // rdx
			//   double v93; // xmm0_8
			//   __int64 v94; // rdx
			//   __int64 v95; // rdx
			//   __int64 v96; // rdx
			//   __int64 v97; // rdx
			//   SettingParameter_1_UnityEngine_HyperGryphEngineCode_BloomQuality_ *bloomQuality_k__BackingField; // rax
			//   __int64 v99; // rdx
			//   __int64 v100; // rdx
			//   __int64 v101; // rdx
			//   __int64 v102; // rdx
			//   __int64 v103; // rdx
			//   SettingParameter_1_HGDepthOfFieldQuality_ *depthOfFieldQuality_k__BackingField; // rax
			//   SettingParameter_1_System_Single_ *depthOfFieldMaxRadius_k__BackingField; // rbp
			//   struct MethodInfo *v106; // rsi
			//   Il2CppClass *v107; // rax
			//   Il2CppClass *v108; // rax
			//   SettingParameter_1_System_Boolean_ *depthOfFieldScaleAdjust_k__BackingField; // rbp
			//   struct MethodInfo *v110; // rsi
			//   Il2CppClass *v111; // rax
			//   Il2CppClass *v112; // rax
			//   SettingParameter_1_System_Single_ *depthOfFieldScaleAdjustThreshold_k__BackingField; // rbp
			//   struct MethodInfo *v114; // rsi
			//   Il2CppClass *v115; // rax
			//   Il2CppClass *v116; // rax
			//   SettingParameter_1_System_Boolean_ *motionBlurEnable_k__BackingField; // rbp
			//   struct MethodInfo *v118; // rsi
			//   Il2CppClass *v119; // rax
			//   Il2CppClass *v120; // rax
			//   SettingParameter_1_System_Boolean_ *bloomEnabled_k__BackingField; // rbp
			//   struct MethodInfo *v122; // rsi
			//   Il2CppClass *v123; // rax
			//   Il2CppClass *v124; // rax
			//   SettingParameter_1_System_Boolean_ *vignetteEnabled_k__BackingField; // rbp
			//   struct MethodInfo *v126; // rsi
			//   Il2CppClass *v127; // rax
			//   Il2CppClass *v128; // rax
			//   SettingParameter_1_System_Boolean_ *radialBlurEnabled_k__BackingField; // rbp
			//   struct MethodInfo *v130; // rsi
			//   Il2CppClass *v131; // rax
			//   Il2CppClass *v132; // rax
			//   SettingParameter_1_System_Boolean_ *chromaticAberrationEnabled_k__BackingField; // rbp
			//   struct MethodInfo *v134; // rsi
			//   Il2CppClass *v135; // rax
			//   Il2CppClass *v136; // rax
			//   SettingParameter_1_System_Boolean_ *dirtyLensEnabled_k__BackingField; // rbp
			//   struct MethodInfo *v138; // rsi
			//   Il2CppClass *v139; // rax
			//   Il2CppClass *v140; // rax
			//   SettingParameter_1_System_Boolean_ *sharpenEnabled_k__BackingField; // rbp
			//   struct MethodInfo *v142; // rsi
			//   Il2CppClass *v143; // rax
			//   Il2CppClass *v144; // rax
			//   SettingParameter_1_System_Boolean_ *frostedGlassEnabled_k__BackingField; // rbp
			//   struct MethodInfo *v146; // rsi
			//   Il2CppClass *v147; // rax
			//   Il2CppClass *v148; // rax
			//   SettingParameter_1_System_Boolean_ *cutsceneEffectEnabled_k__BackingField; // rbp
			//   struct MethodInfo *v150; // rsi
			//   Il2CppClass *v151; // rax
			//   Il2CppClass *v152; // rax
			//   SettingParameter_1_System_Boolean_ *fisheyeEffectEnabled_k__BackingField; // rbp
			//   struct MethodInfo *v154; // rsi
			//   Il2CppClass *v155; // rax
			//   Il2CppClass *v156; // rax
			//   SettingParameter_1_System_Boolean_ *lensFlareEnabled_k__BackingField; // rbp
			//   struct MethodInfo *v158; // rsi
			//   Il2CppClass *v159; // rax
			//   Il2CppClass *v160; // rax
			//   SettingParameter_1_System_Int32_ *punctualLightMaxCount_k__BackingField; // rbp
			//   struct MethodInfo *v162; // rsi
			//   Il2CppClass *v163; // rax
			//   Il2CppClass *v164; // rax
			//   SettingParameter_1_System_Boolean_ *enableShadowProxy_k__BackingField; // rbp
			//   struct MethodInfo *v166; // rsi
			//   Il2CppClass *v167; // rax
			//   Il2CppClass *v168; // rax
			//   SettingParameter_1_UnityEngine_Rendering_DepthBits_ *shadowDepthBits_k__BackingField; // rax
			//   SettingParameter_1_System_Boolean_ *enableScreenSpaceShadowMask_k__BackingField; // rbp
			//   struct MethodInfo *v171; // rsi
			//   Il2CppClass *v172; // rax
			//   Il2CppClass *v173; // rax
			//   SettingParameter_1_System_Boolean_ *csmEnabled_k__BackingField; // rbp
			//   struct MethodInfo *v175; // rsi
			//   Il2CppClass *v176; // rax
			//   Il2CppClass *v177; // rax
			//   SettingParameter_1_System_Int32_ *csmShadowMapTileResolution_k__BackingField; // rbp
			//   struct MethodInfo *v179; // rsi
			//   Il2CppClass *v180; // rax
			//   Il2CppClass *v181; // rax
			//   SettingParameter_1_System_Single_ *csmMaxDistance_k__BackingField; // rbp
			//   struct MethodInfo *v183; // rsi
			//   Il2CppClass *v184; // rax
			//   Il2CppClass *v185; // rax
			//   SettingParameter_1_System_Single_ *csmFadeInnerDistance_k__BackingField; // rbp
			//   struct MethodInfo *v187; // rsi
			//   Il2CppClass *v188; // rax
			//   Il2CppClass *v189; // rax
			//   SettingParameter_1_System_Int32_ *csmSplitCount_k__BackingField; // rbp
			//   struct MethodInfo *v191; // rsi
			//   Il2CppClass *v192; // rax
			//   Il2CppClass *v193; // rax
			//   SettingParameter_1_System_Single_ *csmSplit0_k__BackingField; // rbp
			//   struct MethodInfo *v195; // rsi
			//   Il2CppClass *v196; // rax
			//   Il2CppClass *v197; // rax
			//   SettingParameter_1_System_Single_ *csmSplit1_k__BackingField; // rbp
			//   struct MethodInfo *v199; // rsi
			//   Il2CppClass *v200; // rax
			//   Il2CppClass *v201; // rax
			//   SettingParameter_1_System_Single_ *csmSplit2_k__BackingField; // rbp
			//   struct MethodInfo *v203; // rsi
			//   Il2CppClass *v204; // rax
			//   Il2CppClass *v205; // rax
			//   SettingParameter_1_System_Single_ *csmSplit3_k__BackingField; // rbp
			//   struct MethodInfo *v207; // rsi
			//   Il2CppClass *v208; // rax
			//   Il2CppClass *v209; // rax
			//   SettingParameter_1_System_Boolean_ *csmUseShadowmapCache_k__BackingField; // rbp
			//   struct MethodInfo *v211; // rsi
			//   Il2CppClass *v212; // rax
			//   Il2CppClass *v213; // rax
			//   SettingParameter_1_System_Int32_ *csmCachedFrame0_k__BackingField; // rbp
			//   struct MethodInfo *v215; // rsi
			//   Il2CppClass *v216; // rax
			//   Il2CppClass *v217; // rax
			//   SettingParameter_1_System_Int32_ *csmCachedFrame1_k__BackingField; // rbp
			//   struct MethodInfo *v219; // rsi
			//   Il2CppClass *v220; // rax
			//   Il2CppClass *v221; // rax
			//   SettingParameter_1_System_Int32_ *csmCachedFrame2_k__BackingField; // rbp
			//   struct MethodInfo *v223; // rsi
			//   Il2CppClass *v224; // rax
			//   Il2CppClass *v225; // rax
			//   SettingParameter_1_System_Int32_ *csmCachedFrame3_k__BackingField; // rbp
			//   struct MethodInfo *v227; // rsi
			//   Il2CppClass *v228; // rax
			//   Il2CppClass *v229; // rax
			//   SettingParameter_1_System_Single_ *csmScreenSizeMin0_k__BackingField; // rbp
			//   struct MethodInfo *v231; // rsi
			//   Il2CppClass *v232; // rax
			//   Il2CppClass *v233; // rax
			//   SettingParameter_1_System_Single_ *csmScreenSizeMin1_k__BackingField; // rbp
			//   struct MethodInfo *v235; // rsi
			//   Il2CppClass *v236; // rax
			//   Il2CppClass *v237; // rax
			//   SettingParameter_1_System_Single_ *csmScreenSizeMin2_k__BackingField; // rbp
			//   struct MethodInfo *v239; // rsi
			//   Il2CppClass *v240; // rax
			//   Il2CppClass *v241; // rax
			//   SettingParameter_1_System_Single_ *csmScreenSizeMin3_k__BackingField; // rbp
			//   struct MethodInfo *v243; // rsi
			//   Il2CppClass *v244; // rax
			//   Il2CppClass *v245; // rax
			//   SettingParameter_1_System_Boolean_ *csmEnableOcclusionCulling0_k__BackingField; // rbp
			//   struct MethodInfo *v247; // rsi
			//   Il2CppClass *v248; // rax
			//   Il2CppClass *v249; // rax
			//   SettingParameter_1_System_Boolean_ *csmEnableOcclusionCulling1_k__BackingField; // rbp
			//   struct MethodInfo *v251; // rsi
			//   Il2CppClass *v252; // rax
			//   Il2CppClass *v253; // rax
			//   SettingParameter_1_System_Boolean_ *csmEnableOcclusionCulling2_k__BackingField; // rbp
			//   struct MethodInfo *v255; // rsi
			//   Il2CppClass *v256; // rax
			//   Il2CppClass *v257; // rax
			//   SettingParameter_1_System_Boolean_ *csmEnableOcclusionCulling3_k__BackingField; // rbp
			//   struct MethodInfo *v259; // rsi
			//   Il2CppClass *v260; // rax
			//   Il2CppClass *v261; // rax
			//   SettingParameter_1_System_Int32_ *csmOcclusionDepthSize_k__BackingField; // rbp
			//   struct MethodInfo *v263; // rsi
			//   Il2CppClass *v264; // rax
			//   Il2CppClass *v265; // rax
			//   SettingParameter_1_System_Int32_ *csmStopRenderCharacterCascade_k__BackingField; // rbp
			//   struct MethodInfo *v267; // rsi
			//   Il2CppClass *v268; // rax
			//   Il2CppClass *v269; // rax
			//   SettingParameter_1_System_Single_ *csmNearPlaneOffset_k__BackingField; // rbp
			//   struct MethodInfo *v271; // rsi
			//   Il2CppClass *v272; // rax
			//   Il2CppClass *v273; // rax
			//   SettingParameter_1_System_Single_ *csmHardwareBias_k__BackingField; // rbp
			//   struct MethodInfo *v275; // rsi
			//   Il2CppClass *v276; // rax
			//   Il2CppClass *v277; // rax
			//   SettingParameter_1_System_Single_ *csmHardwareNormalBias_k__BackingField; // rbp
			//   struct MethodInfo *v279; // rsi
			//   Il2CppClass *v280; // rax
			//   Il2CppClass *v281; // rax
			//   SettingParameter_1_System_Boolean_ *characterShadowEnabled_k__BackingField; // rbp
			//   struct MethodInfo *v283; // rsi
			//   Il2CppClass *v284; // rax
			//   Il2CppClass *v285; // rax
			//   SettingParameter_1_System_Int32_ *characterShadowMapResolution_k__BackingField; // rbp
			//   struct MethodInfo *v287; // rsi
			//   Il2CppClass *v288; // rax
			//   Il2CppClass *v289; // rax
			//   SettingParameter_1_System_Single_ *characterShadowHardwareBias_k__BackingField; // rbp
			//   struct MethodInfo *v291; // rsi
			//   Il2CppClass *v292; // rax
			//   Il2CppClass *v293; // rax
			//   SettingParameter_1_System_Single_ *characterShadowHardwareNormalBias_k__BackingField; // rbp
			//   struct MethodInfo *v295; // rsi
			//   Il2CppClass *v296; // rax
			//   Il2CppClass *v297; // rax
			//   SettingParameter_1_System_Single_ *characterShadowShaderBias_k__BackingField; // rbp
			//   struct MethodInfo *v299; // rsi
			//   Il2CppClass *v300; // rax
			//   Il2CppClass *v301; // rax
			//   SettingParameter_1_System_Single_ *characterShadowShaderNormalBias_k__BackingField; // rbp
			//   struct MethodInfo *v303; // rsi
			//   Il2CppClass *v304; // rax
			//   Il2CppClass *v305; // rax
			//   SettingParameter_1_System_Boolean_ *punctualLightShadowEnabled_k__BackingField; // rbp
			//   struct MethodInfo *v307; // rsi
			//   Il2CppClass *v308; // rax
			//   Il2CppClass *v309; // rax
			//   SettingParameter_1_System_Int32_ *punctualLightTileMaxSize_k__BackingField; // rbp
			//   struct MethodInfo *v311; // rsi
			//   Il2CppClass *v312; // rax
			//   Il2CppClass *v313; // rax
			//   SettingParameter_1_System_Single_ *punctualLightForceCullDistance_k__BackingField; // rbp
			//   struct MethodInfo *v315; // rsi
			//   Il2CppClass *v316; // rax
			//   Il2CppClass *v317; // rax
			//   SettingParameter_1_System_Int32_ *punctualLightEnvDynamicCasterCount_k__BackingField; // rbp
			//   struct MethodInfo *v319; // rsi
			//   Il2CppClass *v320; // rax
			//   Il2CppClass *v321; // rax
			//   SettingParameter_1_System_Int32_ *punctualLightMovableDynamicCasterCount_k__BackingField; // rbp
			//   struct MethodInfo *v323; // rsi
			//   Il2CppClass *v324; // rax
			//   Il2CppClass *v325; // rax
			//   SettingParameter_1_System_Single_ *punctualLightShadowScreenSizeMin_k__BackingField; // rbp
			//   struct MethodInfo *v327; // rsi
			//   Il2CppClass *v328; // rax
			//   Il2CppClass *v329; // rax
			//   SettingParameter_1_System_Boolean_ *asmEnabled_k__BackingField; // rbp
			//   struct MethodInfo *v331; // rsi
			//   Il2CppClass *v332; // rax
			//   Il2CppClass *v333; // rax
			//   SettingParameter_1_System_Int32_ *asmShadowMapTileResolution_k__BackingField; // rbp
			//   struct MethodInfo *v335; // rsi
			//   Il2CppClass *v336; // rax
			//   Il2CppClass *v337; // rax
			//   SettingParameter_1_System_Single_ *asmMaxDistance_k__BackingField; // rbp
			//   struct MethodInfo *v339; // rsi
			//   Il2CppClass *v340; // rax
			//   Il2CppClass *v341; // rax
			//   SettingParameter_1_System_Int32_ *asmMaxTileRenderCountPerFrame_k__BackingField; // rbp
			//   struct MethodInfo *v343; // rsi
			//   Il2CppClass *v344; // rax
			//   Il2CppClass *v345; // rax
			//   SettingParameter_1_System_Single_ *asmDepthBias_k__BackingField; // rbp
			//   struct MethodInfo *v347; // rsi
			//   Il2CppClass *v348; // rax
			//   Il2CppClass *v349; // rax
			//   SettingParameter_1_System_Single_ *asmNormalBias_k__BackingField; // rbp
			//   struct MethodInfo *v351; // rsi
			//   Il2CppClass *v352; // rax
			//   Il2CppClass *v353; // rax
			//   SettingParameter_1_System_Single_ *asmScreenSizeMin_k__BackingField; // rbp
			//   struct MethodInfo *v355; // rsi
			//   Il2CppClass *v356; // rax
			//   Il2CppClass *v357; // rax
			//   SettingParameter_1_System_Boolean_ *transientGBuffer_k__BackingField; // rbp
			//   struct MethodInfo *v359; // rsi
			//   Il2CppClass *v360; // rax
			//   Il2CppClass *v361; // rax
			//   SettingParameter_1_UnityEngine_Rendering_DepthBits_ *depthBitsGBuffer_k__BackingField; // rax
			//   SettingParameter_1_System_Boolean_ *depthCombinedWithStencil_k__BackingField; // rbp
			//   struct MethodInfo *v364; // rsi
			//   Il2CppClass *v365; // rax
			//   Il2CppClass *v366; // rax
			//   SettingParameter_1_System_Single_ *copySceneRTScale_k__BackingField; // rbp
			//   struct MethodInfo *v368; // rsi
			//   Il2CppClass *v369; // rax
			//   Il2CppClass *v370; // rax
			//   SettingParameter_1_System_Int32_ *taauResolveResolutionHeight_k__BackingField; // rbp
			//   struct MethodInfo *v372; // rsi
			//   Il2CppClass *v373; // rax
			//   Il2CppClass *v374; // rax
			//   Il2CppClass *v375; // rcx
			//   SettingParameter_1_System_Int32_ *backBufferResolutionHeight_k__BackingField; // rbp
			//   struct MethodInfo *v377; // rsi
			//   Il2CppClass *v378; // rax
			//   Il2CppClass *v379; // rax
			//   SettingParameter_1_System_Boolean_ *textureStreamingEnable_k__BackingField; // rbp
			//   struct MethodInfo *v381; // rsi
			//   Il2CppClass *v382; // rax
			//   Il2CppClass *v383; // rax
			//   SettingParameter_1_System_Int32_ *textureStreamingBudget_k__BackingField; // rbp
			//   struct MethodInfo *v385; // rsi
			//   Il2CppClass *v386; // rax
			//   Il2CppClass *v387; // rax
			//   SettingParameter_1_System_Int32_ *textureStreamingMaxBudget_k__BackingField; // rbp
			//   struct MethodInfo *v389; // rsi
			//   Il2CppClass *v390; // rax
			//   Il2CppClass *v391; // rax
			//   SettingParameter_1_System_Int32_ *reservedMemoryForNonTextureStreaming_k__BackingField; // rbp
			//   struct MethodInfo *v393; // rsi
			//   Il2CppClass *v394; // rax
			//   Il2CppClass *v395; // rax
			//   SettingParameter_1_System_Single_ *textureStreamingMobileBudgetPercent_k__BackingField; // rbp
			//   struct MethodInfo *v397; // rsi
			//   Il2CppClass *v398; // rax
			//   Il2CppClass *v399; // rax
			//   SettingParameter_1_System_Int32_ *textureStreamingRendererPerFrame_k__BackingField; // rbp
			//   struct MethodInfo *v401; // rsi
			//   Il2CppClass *v402; // rax
			//   Il2CppClass *v403; // rax
			//   SettingParameter_1_System_Int32_ *textureStreamingMaxFileIORequests_k__BackingField; // rbp
			//   struct MethodInfo *v405; // rsi
			//   Il2CppClass *v406; // rax
			//   Il2CppClass *v407; // rax
			//   SettingParameter_1_System_Boolean_ *contactShadowEnableParam_k__BackingField; // rbp
			//   struct MethodInfo *v409; // rsi
			//   Il2CppClass *v410; // rax
			//   Il2CppClass *v411; // rax
			//   SettingParameter_1_System_Boolean_ *gtaoEnable_k__BackingField; // rbp
			//   struct MethodInfo *v413; // rsi
			//   Il2CppClass *v414; // rax
			//   Il2CppClass *v415; // rax
			//   SettingParameter_1_System_Int32_ *gtaoQualityLevel_k__BackingField; // rbp
			//   struct MethodInfo *v417; // rsi
			//   Il2CppClass *v418; // rax
			//   Il2CppClass *v419; // rax
			//   SettingParameter_1_System_Boolean_ *ssrEnable_k__BackingField; // rbp
			//   struct MethodInfo *v421; // rsi
			//   Il2CppClass *v422; // rax
			//   Il2CppClass *v423; // rax
			//   SettingParameter_1_System_Int32_ *ssrRayMarchingSampleCount_k__BackingField; // rbp
			//   struct MethodInfo *v425; // rsi
			//   Il2CppClass *v426; // rax
			//   Il2CppClass *v427; // rax
			//   SettingParameter_1_System_Boolean_ *ssrImportanceSample_k__BackingField; // rbp
			//   struct MethodInfo *v429; // rsi
			//   Il2CppClass *v430; // rax
			//   Il2CppClass *v431; // rax
			//   SettingParameter_1_System_Boolean_ *ssrV2_k__BackingField; // rbp
			//   struct MethodInfo *v433; // rsi
			//   Il2CppClass *v434; // rax
			//   Il2CppClass *v435; // rax
			//   SettingParameter_1_System_Boolean_ *ssrV2Upsample_k__BackingField; // rbp
			//   struct MethodInfo *v437; // rsi
			//   Il2CppClass *v438; // rax
			//   Il2CppClass *v439; // rax
			//   SettingParameter_1_System_Boolean_ *terrainFallbackGBuffer_k__BackingField; // rbp
			//   struct MethodInfo *v441; // rsi
			//   Il2CppClass *v442; // rax
			//   Il2CppClass *v443; // rax
			//   SettingParameter_1_System_Int32_ *terrainLODFactor_k__BackingField; // rbp
			//   struct MethodInfo *v445; // rsi
			//   Il2CppClass *v446; // rax
			//   Il2CppClass *v447; // rax
			//   HGTerrainDeformSettingParameters *terrainDeform_k__BackingField; // rax
			//   SettingParameter_1_System_Boolean_ *Enable_k__BackingField; // rbp
			//   struct MethodInfo *v450; // rsi
			//   Il2CppClass *v451; // rax
			//   Il2CppClass *v452; // rax
			//   HGTerrainDeformSettingParameters *v453; // rax
			//   SettingParameter_1_System_Int32_ *SubdMode_k__BackingField; // rbp
			//   struct MethodInfo *v455; // rsi
			//   Il2CppClass *v456; // rax
			//   Il2CppClass *v457; // rax
			//   HGTerrainDeformSettingParameters *v458; // rax
			//   SettingParameter_1_System_Int32_ *SubdModeV2_k__BackingField; // rbp
			//   struct MethodInfo *v460; // rsi
			//   Il2CppClass *v461; // rax
			//   Il2CppClass *v462; // rax
			//   HGTerrainDeformSettingParameters *v463; // rax
			//   SettingParameter_1_System_Int32_ *GpuSubd_k__BackingField; // rbp
			//   struct MethodInfo *v465; // rsi
			//   Il2CppClass *v466; // rax
			//   Il2CppClass *v467; // rax
			//   HGTerrainDeformSettingParameters *v468; // rax
			//   SettingParameter_1_System_Int32_ *PrimitivePixelLengthTargetLog2_k__BackingField; // rbp
			//   struct MethodInfo *v470; // rsi
			//   Il2CppClass *v471; // rax
			//   Il2CppClass *v472; // rax
			//   HGErosionBlendSettingParameters *erosionBlend_k__BackingField; // rax
			//   SettingParameter_1_System_Boolean_ *v474; // rbp
			//   struct MethodInfo *v475; // rsi
			//   Il2CppClass *v476; // rax
			//   Il2CppClass *v477; // rax
			//   HGLightShaftSettingParameters *lightShaft_k__BackingField; // rax
			//   SettingParameter_1_System_Boolean_ *enableLightShaft; // rbp
			//   struct MethodInfo *v480; // rsi
			//   Il2CppClass *v481; // rax
			//   Il2CppClass *v482; // rax
			//   HGLightShaftSettingParameters *v483; // rax
			//   SettingParameter_1_System_Int32_ *lightShaftSampleNum; // rbp
			//   struct MethodInfo *v485; // rsi
			//   Il2CppClass *v486; // rax
			//   Il2CppClass *v487; // rax
			//   HGLightShaftSettingParameters *v488; // rax
			//   SettingParameter_1_System_Single_ *lightShaftDownSampleFactor; // rbp
			//   struct MethodInfo *v490; // rsi
			//   Il2CppClass *v491; // rax
			//   Il2CppClass *v492; // rax
			//   HGLightShaftSettingParameters *v493; // rax
			//   SettingParameter_1_System_Int32_ *lightShaftBlurPassCount; // rbp
			//   struct MethodInfo *v495; // rsi
			//   Il2CppClass *v496; // rax
			//   Il2CppClass *v497; // rax
			//   SettingParameter_1_System_Boolean_ *enableAnamorphicStreaks_k__BackingField; // rbp
			//   struct MethodInfo *v499; // rsi
			//   Il2CppClass *v500; // rax
			//   Il2CppClass *v501; // rax
			//   SettingParameter_1_System_Single_ *anamorphicStreaksDownSampleFactor_k__BackingField; // rbp
			//   struct MethodInfo *v503; // rsi
			//   Il2CppClass *v504; // rax
			//   Il2CppClass *v505; // rax
			//   HGRainAndWetnessSettingParameters *rainAndWetness_k__BackingField; // rax
			//   SettingParameter_1_System_Boolean_ *EnableRainWetnessHighQuality_k__BackingField; // rbp
			//   struct MethodInfo *v508; // rsi
			//   Il2CppClass *v509; // rax
			//   Il2CppClass *v510; // rax
			//   HGRainAndWetnessSettingParameters *v511; // rax
			//   SettingParameter_1_System_Int32_ *RainOcclusionMapSize_k__BackingField; // rbp
			//   struct MethodInfo *v513; // rsi
			//   Il2CppClass *v514; // rax
			//   Il2CppClass *v515; // rax
			//   HGRainAndWetnessSettingParameters *v516; // rax
			//   SettingParameter_1_System_Int32_ *RainOcclusionMapOverrideRange_k__BackingField; // rbp
			//   struct MethodInfo *v518; // rsi
			//   Il2CppClass *v519; // rax
			//   Il2CppClass *v520; // rax
			//   HGRainAndWetnessSettingParameters *v521; // rax
			//   SettingParameter_1_System_Boolean_ *RainSplashEnabled_k__BackingField; // rbp
			//   struct MethodInfo *v523; // rsi
			//   Il2CppClass *v524; // rax
			//   Il2CppClass *v525; // rax
			//   HGRainAndWetnessSettingParameters *v526; // rax
			//   SettingParameter_1_System_Int32_ *RainSplashMaxCount_k__BackingField; // rbp
			//   struct MethodInfo *v528; // rsi
			//   Il2CppClass *v529; // rax
			//   Il2CppClass *v530; // rax
			//   HGRainAndWetnessSettingParameters *v531; // rax
			//   SettingParameter_1_System_Single_ *ScreenRainDropPercent_k__BackingField; // rbp
			//   struct MethodInfo *v533; // rsi
			//   Il2CppClass *v534; // rax
			//   Il2CppClass *v535; // rax
			//   HGRainAndWetnessSettingParameters *v536; // rax
			//   SettingParameter_1_System_Boolean_ *EnableMiddleDistRain_k__BackingField; // rbp
			//   struct MethodInfo *v538; // rsi
			//   Il2CppClass *v539; // rax
			//   Il2CppClass *v540; // rax
			//   HGRainAndWetnessSettingParameters *v541; // rax
			//   SettingParameter_1_System_Boolean_ *EnableRainWave_k__BackingField; // rbp
			//   struct MethodInfo *v543; // rsi
			//   Il2CppClass *v544; // rax
			//   Il2CppClass *v545; // rax
			//   HGVerticalOcclusionMapSettingParameters *verticalOcclusionMap_k__BackingField; // rax
			//   SettingParameter_1_System_Int32_ *DepthOcclusionMapSize_k__BackingField; // rbp
			//   struct MethodInfo *v548; // rsi
			//   Il2CppClass *v549; // rax
			//   Il2CppClass *v550; // rax
			//   HGVerticalOcclusionMapSettingParameters *v551; // rax
			//   SettingParameter_1_System_Int32_ *DepthOcclusionMapRange_k__BackingField; // rbp
			//   struct MethodInfo *v553; // rsi
			//   Il2CppClass *v554; // rax
			//   Il2CppClass *v555; // rax
			//   HGAtmosphereSettingParameters *atmosphereParams_k__BackingField; // rax
			//   SettingParameter_1_System_Single_ *transmittanceLutSampleCount; // rbp
			//   struct MethodInfo *v558; // rsi
			//   Il2CppClass *v559; // rax
			//   Il2CppClass *v560; // rax
			//   HGAtmosphereSettingParameters *v561; // rax
			//   SettingParameter_1_System_Int32_ *transmittanceLutWidth; // rbp
			//   struct MethodInfo *v563; // rsi
			//   Il2CppClass *v564; // rax
			//   Il2CppClass *v565; // rax
			//   HGAtmosphereSettingParameters *v566; // rax
			//   SettingParameter_1_System_Int32_ *transmittanceLutHeight; // rbp
			//   struct MethodInfo *v568; // rsi
			//   Il2CppClass *v569; // rax
			//   Il2CppClass *v570; // rax
			//   HGAtmosphereSettingParameters *v571; // rax
			//   SettingParameter_1_System_Single_ *multiScatteredLuminanceLutSampleCount; // rbp
			//   struct MethodInfo *v573; // rsi
			//   Il2CppClass *v574; // rax
			//   Il2CppClass *v575; // rax
			//   HGAtmosphereSettingParameters *v576; // rax
			//   SettingParameter_1_System_Boolean_ *multiScatteredLuminanceLutHighQuality; // rbp
			//   struct MethodInfo *v578; // rsi
			//   Il2CppClass *v579; // rax
			//   Il2CppClass *v580; // rax
			//   HGAtmosphereSettingParameters *v581; // rax
			//   SettingParameter_1_System_Int32_ *multiScatteredLuminanceLutWidth; // rbp
			//   struct MethodInfo *v583; // rsi
			//   Il2CppClass *v584; // rax
			//   Il2CppClass *v585; // rax
			//   HGAtmosphereSettingParameters *v586; // rax
			//   SettingParameter_1_System_Int32_ *multiScatteredLuminanceLutHeight; // rbp
			//   struct MethodInfo *v588; // rsi
			//   Il2CppClass *v589; // rax
			//   Il2CppClass *v590; // rax
			//   HGAtmosphereSettingParameters *v591; // rax
			//   SettingParameter_1_System_Single_ *skyViewLutSampleCountMin; // rbp
			//   struct MethodInfo *v593; // rsi
			//   Il2CppClass *v594; // rax
			//   Il2CppClass *v595; // rax
			//   HGAtmosphereSettingParameters *v596; // rax
			//   SettingParameter_1_System_Single_ *skyViewLutSampleCountMax; // rbp
			//   struct MethodInfo *v598; // rsi
			//   Il2CppClass *v599; // rax
			//   Il2CppClass *v600; // rax
			//   HGAtmosphereSettingParameters *v601; // rax
			//   SettingParameter_1_System_Single_ *skyViewLutDistanceToSampleCountMax; // rbp
			//   struct MethodInfo *v603; // rsi
			//   Il2CppClass *v604; // rax
			//   Il2CppClass *v605; // rax
			//   Il2CppClass *v606; // rcx
			//   __int64 v607; // r8
			//   __int64 v608; // r9
			//   HGAtmosphereSettingParameters *v609; // rax
			//   SettingParameter_1_System_Int32_ *skyViewLutHeight; // rbp
			//   struct MethodInfo *v611; // rsi
			//   Il2CppClass *v612; // rax
			//   Il2CppClass *v613; // rax
			//   SettingParameter_1_System_Single_ *waterPrepassTextureSize_k__BackingField; // rbp
			//   struct MethodInfo *v615; // rsi
			//   Il2CppClass *v616; // rax
			//   Il2CppClass *v617; // rax
			//   SettingParameter_1_System_Boolean_ *waterInteractiveEnable_k__BackingField; // rbp
			//   struct MethodInfo *v619; // rsi
			//   Il2CppClass *v620; // rax
			//   __int64 v621; // rax
			//   SettingParameter_1_System_Boolean_ *waterIndirectEnable_k__BackingField; // rbp
			//   struct MethodInfo *v623; // rsi
			//   Il2CppClass *v624; // rax
			//   __int64 v625; // rax
			//   SettingParameter_1_System_Int32_ *waterVRRx_k__BackingField; // rbp
			//   struct MethodInfo *v627; // rsi
			//   Il2CppClass *v628; // rax
			//   __int64 v629; // rax
			//   SettingParameter_1_System_Int32_ *waterVRRy_k__BackingField; // rbp
			//   struct MethodInfo *v631; // rsi
			//   Il2CppClass *v632; // rax
			//   __int64 v633; // rax
			//   SettingParameter_1_System_Single_ *waterDisplacementWeight_k__BackingField; // rbp
			//   struct MethodInfo *v635; // rsi
			//   Il2CppClass *v636; // rax
			//   __int64 v637; // rax
			//   SettingParameter_1_System_Single_ *waterDisplacementDistance_k__BackingField; // rbp
			//   struct MethodInfo *v639; // rsi
			//   Il2CppClass *v640; // rax
			//   __int64 v641; // rax
			//   SettingParameter_1_System_Int32_ *waterHeightTextureSize_k__BackingField; // rbp
			//   struct MethodInfo *v643; // rsi
			//   Il2CppClass *v644; // rax
			//   __int64 v645; // rax
			//   SettingParameter_1_System_Single_ *artTagLODBiasAll_k__BackingField; // rbp
			//   struct MethodInfo *v647; // rsi
			//   Il2CppClass *v648; // rax
			//   __int64 v649; // rax
			//   Il2CppClass *v650; // rcx
			//   unsigned int v651; // esi
			//   List_1_HG_Rendering_Runtime_SettingParameter_1_System_Single_ *artTagLODBias_k__BackingField; // rax
			//   SettingParameter_1_System_Single___Array *items; // rax
			//   SettingParameter_1_System_Single_ *v654; // r14
			//   struct MethodInfo *v655; // rbp
			//   Il2CppClass *v656; // rax
			//   Il2CppClass *v657; // rax
			//   Il2CppClass *v658; // rcx
			//   __int64 v659; // rcx
			//   SettingParameter_1_System_Boolean_ *shouldSplitOnePass_k__BackingField; // rbp
			//   struct MethodInfo *v661; // rsi
			//   Il2CppClass *v662; // rax
			//   Il2CppClass *v663; // rax
			//   Il2CppClass *v664; // rcx
			//   struct HGVolumetricFogRenderer__Class *v665; // rax
			//   Void *v666; // rbp
			//   struct MethodInfo *v667; // rsi
			//   Il2CppClass *v668; // rax
			//   Il2CppClass *v669; // rax
			//   Il2CppClass *v670; // rcx
			//   __int64 v671; // rbp
			//   struct MethodInfo *v672; // rsi
			//   Il2CppClass *v673; // rax
			//   Il2CppClass *v674; // rax
			//   Il2CppClass *v675; // rcx
			//   __int64 v676; // rbp
			//   struct MethodInfo *v677; // rsi
			//   Il2CppClass *v678; // rax
			//   Il2CppClass *v679; // rax
			//   Il2CppClass *v680; // rcx
			//   __int64 v681; // rbp
			//   struct MethodInfo *v682; // rsi
			//   Il2CppClass *v683; // rax
			//   Il2CppClass *v684; // rax
			//   Il2CppClass *v685; // rcx
			//   __int64 v686; // rbp
			//   struct MethodInfo *v687; // rsi
			//   Il2CppClass *v688; // rax
			//   Il2CppClass *v689; // rax
			//   Il2CppClass *v690; // rcx
			//   __int64 v691; // rbp
			//   struct MethodInfo *v692; // rsi
			//   Il2CppClass *v693; // rax
			//   Il2CppClass *v694; // rax
			//   Il2CppClass *v695; // rcx
			//   __int64 v696; // rbp
			//   struct MethodInfo *v697; // rsi
			//   Il2CppClass *v698; // rax
			//   Il2CppClass *v699; // rax
			//   Il2CppClass *v700; // rcx
			//   __int64 v701; // rbp
			//   struct MethodInfo *v702; // rsi
			//   Il2CppClass *v703; // rax
			//   Il2CppClass *v704; // rax
			//   Il2CppClass *v705; // rcx
			//   __int64 v706; // rbp
			//   struct MethodInfo *v707; // rsi
			//   Il2CppClass *v708; // rax
			//   Il2CppClass *v709; // rax
			//   Il2CppClass *v710; // rcx
			//   __int64 v711; // rbp
			//   struct MethodInfo *v712; // rsi
			//   Il2CppClass *v713; // rax
			//   Il2CppClass *v714; // rax
			//   Il2CppClass *v715; // rcx
			//   Void *v716; // rbp
			//   struct MethodInfo *v717; // rsi
			//   Il2CppClass *v718; // rax
			//   Il2CppClass *v719; // rax
			//   Il2CppClass *v720; // rcx
			//   Void *v721; // rbp
			//   struct MethodInfo *v722; // rsi
			//   Il2CppClass *v723; // rax
			//   Il2CppClass *v724; // rax
			//   Il2CppClass *v725; // rcx
			//   Void *v726; // rbp
			//   struct MethodInfo *v727; // rsi
			//   Il2CppClass *v728; // rax
			//   Il2CppClass *v729; // rax
			//   Il2CppClass *v730; // rcx
			//   Void *v731; // rbp
			//   struct MethodInfo *v732; // rsi
			//   Il2CppClass *v733; // rax
			//   Il2CppClass *v734; // rax
			//   SettingParameter_1_System_Boolean_ *reflectionProbeUseRGBAHalf_k__BackingField; // rbp
			//   struct MethodInfo *v736; // rsi
			//   Il2CppClass *v737; // rax
			//   Il2CppClass *v738; // rax
			//   SettingParameter_1_System_Int32_ *reflectionProbeOctTextureSize_k__BackingField; // rbp
			//   struct MethodInfo *v740; // rsi
			//   Il2CppClass *v741; // rax
			//   Il2CppClass *v742; // rax
			//   SettingParameter_1_System_Int32_ *reflectionProbeMaxSampleMip_k__BackingField; // rbp
			//   struct MethodInfo *v744; // rsi
			//   Il2CppClass *v745; // rax
			//   Il2CppClass *v746; // rax
			//   SettingParameter_1_System_Int32_ *reflectionProbeMaxBlitCountPerFrame_k__BackingField; // rbp
			//   struct MethodInfo *v748; // rsi
			//   Il2CppClass *v749; // rax
			//   Il2CppClass *v750; // rax
			//   SettingParameter_1_System_Boolean_ *transparentLowResOffscreenEnable_k__BackingField; // rbp
			//   struct MethodInfo *v752; // rsi
			//   Il2CppClass *v753; // rax
			//   Il2CppClass *v754; // rax
			//   SettingParameter_1_System_Boolean_ *transparentLowResVRSEnable_k__BackingField; // rbp
			//   struct MethodInfo *v756; // rsi
			//   Il2CppClass *v757; // rax
			//   Il2CppClass *v758; // rax
			//   SettingParameter_1_System_Int32_ *transparentVRRx_k__BackingField; // rbp
			//   struct MethodInfo *v760; // rsi
			//   Il2CppClass *v761; // rax
			//   Il2CppClass *v762; // rax
			//   SettingParameter_1_System_Int32_ *transparentVRRy_k__BackingField; // rbp
			//   struct MethodInfo *v764; // rsi
			//   Il2CppClass *v765; // rax
			//   Il2CppClass *v766; // rax
			//   SettingParameter_1_System_Boolean_ *rayTracingReflectionEnable_k__BackingField; // rbp
			//   struct MethodInfo *v768; // rsi
			//   Il2CppClass *v769; // rax
			//   Il2CppClass *v770; // rax
			//   SettingParameter_1_System_Int32_ *rayTracingReflectionMode_k__BackingField; // rbp
			//   struct MethodInfo *v772; // rsi
			//   Il2CppClass *v773; // rax
			//   Il2CppClass *v774; // rax
			//   SettingParameter_1_System_Single_ *rayTracingReflectionSSQuality0_k__BackingField; // rbp
			//   struct MethodInfo *v776; // rsi
			//   Il2CppClass *v777; // rax
			//   Il2CppClass *v778; // rax
			//   SettingParameter_1_System_Single_ *rayTracingReflectionSSQuality1_k__BackingField; // rbp
			//   struct MethodInfo *v780; // rsi
			//   Il2CppClass *v781; // rax
			//   Il2CppClass *v782; // rax
			//   SettingParameter_1_System_Single_ *rayTracingReflectionSSQuality2_k__BackingField; // rbp
			//   struct MethodInfo *v784; // rsi
			//   Il2CppClass *v785; // rax
			//   Il2CppClass *v786; // rax
			//   SettingParameter_1_System_Single_ *rayTracingReflectionSSQuality3_k__BackingField; // rbp
			//   struct MethodInfo *v788; // rsi
			//   Il2CppClass *v789; // rax
			//   Il2CppClass *v790; // rax
			//   SettingParameter_1_System_Single_ *rayTracingReflectionRTQuality0_k__BackingField; // rbp
			//   struct MethodInfo *v792; // rsi
			//   Il2CppClass *v793; // rax
			//   Il2CppClass *v794; // rax
			//   SettingParameter_1_System_Single_ *rayTracingReflectionRTQuality1_k__BackingField; // rbp
			//   struct MethodInfo *v796; // rsi
			//   Il2CppClass *v797; // rax
			//   Il2CppClass *v798; // rax
			//   SettingParameter_1_System_Single_ *rayTracingReflectionRTQuality2_k__BackingField; // rbp
			//   struct MethodInfo *v800; // rsi
			//   Il2CppClass *v801; // rax
			//   Il2CppClass *v802; // rax
			//   SettingParameter_1_System_Single_ *rayTracingReflectionRTQuality3_k__BackingField; // rbp
			//   struct MethodInfo *v804; // rsi
			//   Il2CppClass *v805; // rax
			//   Il2CppClass *v806; // rax
			//   SettingParameter_1_System_Boolean_ *frameInterpolationEnable_k__BackingField; // rbp
			//   struct MethodInfo *v808; // rsi
			//   Il2CppClass *v809; // rax
			//   Il2CppClass *v810; // rax
			//   SettingParameter_1_System_Boolean_ *frameInterpolationPause_k__BackingField; // rbp
			//   struct MethodInfo *v812; // rsi
			//   Il2CppClass *v813; // rax
			//   Il2CppClass *v814; // rax
			//   Il2CppClass *v815; // rcx
			//   SettingParameter_1_System_Boolean_ *hasWorldUIAfterFrameInterpolation_k__BackingField; // rbp
			//   struct MethodInfo *v817; // rsi
			//   Il2CppClass *v818; // rax
			//   Il2CppClass *v819; // rax
			//   SettingParameter_1_System_Single_ *afmeCameraRotationCosFallbackThreshold_k__BackingField; // rbp
			//   struct MethodInfo *v821; // rsi
			//   Il2CppClass *v822; // rax
			//   Il2CppClass *v823; // rax
			//   SettingParameter_1_System_Single_ *afmeCameraMoveDistanceSqrFallbackThreshold_k__BackingField; // rbp
			//   struct MethodInfo *v825; // rsi
			//   Il2CppClass *v826; // rax
			//   Il2CppClass *v827; // rax
			//   SettingParameter_1_System_Single_ *mfrcCameraRotationCosFallbackThreshold_k__BackingField; // rbp
			//   struct MethodInfo *v829; // rsi
			//   Il2CppClass *v830; // rax
			//   Il2CppClass *v831; // rax
			//   SettingParameter_1_System_Single_ *mfrcCameraMoveDistanceSqrFallbackThreshold_k__BackingField; // rbp
			//   struct MethodInfo *v833; // rsi
			//   Il2CppClass *v834; // rax
			//   Il2CppClass *v835; // rax
			//   SettingParameter_1_System_Single_ *mfrcGeneralFallbackThreshold_k__BackingField; // rbp
			//   struct MethodInfo *v837; // rsi
			//   Il2CppClass *v838; // rax
			//   Il2CppClass *v839; // rax
			//   SettingParameter_1_System_Single_ *mfrcBrightnessDiffFallbackThreshold_k__BackingField; // rbp
			//   struct MethodInfo *v841; // rsi
			//   Il2CppClass *v842; // rax
			//   Il2CppClass *v843; // rax
			//   SettingParameter_1_System_Single_ *mfrcRepeatedPatternFallbackThreshold_k__BackingField; // rbp
			//   struct MethodInfo *v845; // rsi
			//   Il2CppClass *v846; // rax
			//   Il2CppClass *v847; // rax
			//   SettingParameter_1_System_Int32_ *inkSimulationResolution_k__BackingField; // rbp
			//   struct MethodInfo *v849; // rsi
			//   Il2CppClass *v850; // rax
			//   Il2CppClass *v851; // rax
			//   SettingParameter_1_System_Int32_ *inkDensityResolution_k__BackingField; // rbp
			//   struct MethodInfo *v853; // rsi
			//   Il2CppClass *v854; // rax
			//   Il2CppClass *v855; // rax
			//   SettingParameter_1_System_Boolean_ *inkSimulationEnable_k__BackingField; // rdi
			//   struct MethodInfo *v857; // rsi
			//   Il2CppClass *v858; // rax
			//   Il2CppClass *v859; // rax
			//   Il2CppClass *v860; // rcx
			// 
			//   if ( !byte_18D8EDB36 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::SettingParameter<float>>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::SettingParameter<float>>::get_Item);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::get_paramValue);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<HG::Rendering::Runtime::HGDepthOfFieldQuality>::get_paramValue);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::Rendering::DepthBits>::get_paramValue);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::HyperGryphEngineCode::BloomQuality>::get_paramValue);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<HG::Rendering::Runtime::TAAUQuality>::get_paramValue);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::HyperGryphEngineCode::StreamlineDLSSFGMode>::op_Implicit);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::HyperGryphEngineCode::FrameInterpolationAlgo>::op_Implicit);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::HyperGryphEngineCode::FSR3Quality>::op_Implicit);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::HyperGryphEngineCode::StreamlineReflexMode>::op_Implicit);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::HyperGryphEngineCode::DLSSQuality>::op_Implicit);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::Experimental::Rendering::GraphicsFormat>::op_Implicit);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//     byte_18D8EDB36 = 1;
			//   }
			//   TempFromCSharp = (Void *)UnityEngine::HyperGryphEngineCode::HGRenderGraphCPP::AllocateTempFromCSharp(1028LL, 0LL);
			//   Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemSet(TempFromCSharp, 0, 1028LL, 0LL);
			//   if ( !settingParameters )
			//     goto LABEL_1747;
			//   cullingViewScreenSizeMin_k__BackingField = settingParameters.fields._cullingViewScreenSizeMin_k__BackingField;
			//   v7 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !cullingViewScreenSizeMin_k__BackingField )
			//     goto LABEL_1747;
			//   klass = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)klass.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)klass.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v9 = sub_18010B520(v7.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v9 + 192) + 48LL))();
			//   }
			//   s_settingParameters = (unsigned __int64)v7.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   if ( !TempFromCSharp )
			//     goto LABEL_1747;
			//   *(float *)TempFromCSharp = cullingViewScreenSizeMin_k__BackingField.fields._paramValue_k__BackingField;
			//   ocScreenSizeMin_k__BackingField = settingParameters.fields._ocScreenSizeMin_k__BackingField;
			//   v11 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !ocScreenSizeMin_k__BackingField )
			//     goto LABEL_1747;
			//   v12 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v12.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v12.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v13 = sub_18010B520(v11.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v13 + 192) + 48LL))();
			//   }
			//   s_settingParameters = (unsigned __int64)v11.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[4] = ocScreenSizeMin_k__BackingField.fields._paramValue_k__BackingField;
			//   taauEnable_k__BackingField = settingParameters.fields._taauEnable_k__BackingField;
			//   v15 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !taauEnable_k__BackingField )
			//     goto LABEL_1747;
			//   v16 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v16.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v16.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v17 = sub_18010B520(v15.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v17 + 192) + 48LL))();
			//   }
			//   s_settingParameters = (unsigned __int64)v15.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   TempFromCSharp[8] = (Void)taauEnable_k__BackingField.fields._paramValue_k__BackingField;
			//   taauQuality_k__BackingField = settingParameters.fields._taauQuality_k__BackingField;
			//   if ( !taauQuality_k__BackingField )
			//     goto LABEL_1747;
			//   *(_DWORD *)&TempFromCSharp[12] = taauQuality_k__BackingField.fields._paramValue_k__BackingField;
			//   historyWeight_k__BackingField = settingParameters.fields._historyWeight_k__BackingField;
			//   v20 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !historyWeight_k__BackingField )
			//     goto LABEL_1747;
			//   v21 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v21.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v21.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v22 = sub_18010B520(v20.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v22 + 192) + 48LL))();
			//   }
			//   s_settingParameters = (unsigned __int64)v20.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[16] = historyWeight_k__BackingField.fields._paramValue_k__BackingField;
			//   historyWeightInMotion_k__BackingField = settingParameters.fields._historyWeightInMotion_k__BackingField;
			//   v24 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !historyWeightInMotion_k__BackingField )
			//     goto LABEL_1747;
			//   v25 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v25.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v25.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v26 = sub_18010B520(v24.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v26 + 192) + 48LL))();
			//   }
			//   s_settingParameters = (unsigned __int64)v24.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[20] = historyWeightInMotion_k__BackingField.fields._paramValue_k__BackingField;
			//   fastConvergeHistoryWeight_k__BackingField = settingParameters.fields._fastConvergeHistoryWeight_k__BackingField;
			//   v28 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !fastConvergeHistoryWeight_k__BackingField )
			//     goto LABEL_1747;
			//   v29 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v29.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v29.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v30 = sub_18010B520(v28.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v30 + 192) + 48LL))();
			//   }
			//   s_settingParameters = (unsigned __int64)v28.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[24] = fastConvergeHistoryWeight_k__BackingField.fields._paramValue_k__BackingField;
			//   responsiveAAWeight_k__BackingField = settingParameters.fields._responsiveAAWeight_k__BackingField;
			//   v32 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !responsiveAAWeight_k__BackingField )
			//     goto LABEL_1747;
			//   v33 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v33.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v33.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v34 = sub_18010B520(v32.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v34 + 192) + 48LL))();
			//   }
			//   s_settingParameters = (unsigned __int64)v32.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[28] = responsiveAAWeight_k__BackingField.fields._paramValue_k__BackingField;
			//   minMotion_k__BackingField = settingParameters.fields._minMotion_k__BackingField;
			//   v36 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !minMotion_k__BackingField )
			//     goto LABEL_1747;
			//   v37 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v37.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v37.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v38 = sub_18010B520(v36.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v38 + 192) + 48LL))();
			//   }
			//   s_settingParameters = (unsigned __int64)v36.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[32] = minMotion_k__BackingField.fields._paramValue_k__BackingField;
			//   maxMotion_k__BackingField = settingParameters.fields._maxMotion_k__BackingField;
			//   v40 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !maxMotion_k__BackingField )
			//     goto LABEL_1747;
			//   v41 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v41.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v41.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v42 = sub_18010B520(v40.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v42 + 192) + 48LL))();
			//   }
			//   s_settingParameters = (unsigned __int64)v40.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[36] = maxMotion_k__BackingField.fields._paramValue_k__BackingField;
			//   characterMotionSensitivity_k__BackingField = settingParameters.fields._characterMotionSensitivity_k__BackingField;
			//   v44 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !characterMotionSensitivity_k__BackingField )
			//     goto LABEL_1747;
			//   v45 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v45.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v45.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v46 = sub_18010B520(v44.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v46 + 192) + 48LL))();
			//   }
			//   s_settingParameters = (unsigned __int64)v44.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[40] = characterMotionSensitivity_k__BackingField.fields._paramValue_k__BackingField;
			//   occlusionDepthDiff_k__BackingField = settingParameters.fields._occlusionDepthDiff_k__BackingField;
			//   v48 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !occlusionDepthDiff_k__BackingField )
			//     goto LABEL_1747;
			//   v49 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v49.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v49.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v50 = sub_18010B520(v48.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v50 + 192) + 48LL))();
			//   }
			//   s_settingParameters = (unsigned __int64)v48.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[44] = occlusionDepthDiff_k__BackingField.fields._paramValue_k__BackingField;
			//   inputLumaWeight_k__BackingField = settingParameters.fields._inputLumaWeight_k__BackingField;
			//   v52 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !inputLumaWeight_k__BackingField )
			//     goto LABEL_1747;
			//   v53 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v53.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v53.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v54 = sub_18010B520(v52.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v54 + 192) + 48LL))();
			//   }
			//   s_settingParameters = (unsigned __int64)v52.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[48] = inputLumaWeight_k__BackingField.fields._paramValue_k__BackingField;
			//   sharpenStrength1K_k__BackingField = settingParameters.fields._sharpenStrength1K_k__BackingField;
			//   v56 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !sharpenStrength1K_k__BackingField )
			//     goto LABEL_1747;
			//   v57 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v57.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v57.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v58 = sub_18010B520(v56.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v58 + 192) + 48LL))();
			//   }
			//   s_settingParameters = (unsigned __int64)v56.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[52] = sharpenStrength1K_k__BackingField.fields._paramValue_k__BackingField;
			//   sharpenStrength2K_k__BackingField = settingParameters.fields._sharpenStrength2K_k__BackingField;
			//   v60 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !sharpenStrength2K_k__BackingField )
			//     goto LABEL_1747;
			//   v61 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v61.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v61.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v62 = sub_18010B520(v60.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v62 + 192) + 48LL))();
			//   }
			//   s_settingParameters = (unsigned __int64)v60.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[56] = sharpenStrength2K_k__BackingField.fields._paramValue_k__BackingField;
			//   sharpenStrength4K_k__BackingField = settingParameters.fields._sharpenStrength4K_k__BackingField;
			//   v64 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !sharpenStrength4K_k__BackingField )
			//     goto LABEL_1747;
			//   v65 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v65.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v65.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v66 = sub_18010B520(v64.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v66 + 192) + 48LL))();
			//   }
			//   s_settingParameters = (unsigned __int64)v64.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[60] = sharpenStrength4K_k__BackingField.fields._paramValue_k__BackingField;
			//   pssrEnable_k__BackingField = settingParameters.fields._pssrEnable_k__BackingField;
			//   v68 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !pssrEnable_k__BackingField )
			//     goto LABEL_1747;
			//   v69 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v69.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v69.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v70 = sub_18010B520(v68.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v70 + 192) + 48LL))();
			//   }
			//   s_settingParameters = (unsigned __int64)v68.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   TempFromCSharp[64] = (Void)pssrEnable_k__BackingField.fields._paramValue_k__BackingField;
			//   pssrPassThrough_k__BackingField = settingParameters.fields._pssrPassThrough_k__BackingField;
			//   v72 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !pssrPassThrough_k__BackingField )
			//     goto LABEL_1747;
			//   v73 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v73.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v73.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v74 = sub_18010B520(v72.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v74 + 192) + 48LL))();
			//   }
			//   s_settingParameters = (unsigned __int64)v72.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   TempFromCSharp[65] = (Void)pssrPassThrough_k__BackingField.fields._paramValue_k__BackingField;
			//   dlssEnable_k__BackingField = settingParameters.fields._dlssEnable_k__BackingField;
			//   v76 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !dlssEnable_k__BackingField )
			//     goto LABEL_1747;
			//   if ( !*(_QWORD *)(*(_QWORD *)(*(_QWORD *)(sub_18010B520(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass)
			//                                           + 192)
			//                               + 48LL)
			//                   + 32LL) )
			//   {
			//     v77 = sub_18010B520(v76.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v77 + 192) + 48LL))();
			//   }
			//   sub_18010B520(v76.klass);
			//   TempFromCSharp[66] = (Void)dlssEnable_k__BackingField.fields._paramValue_k__BackingField;
			//   *(_DWORD *)&TempFromCSharp[68] = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//                                      (SettingParameter_1_System_Int32Enum_ *)settingParameters.fields._dlssQuality_k__BackingField,
			//                                      MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::HyperGryphEngineCode::DLSSQuality>::op_Implicit);
			//   dlssUseAutoExposure_k__BackingField = settingParameters.fields._dlssUseAutoExposure_k__BackingField;
			//   v79 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !dlssUseAutoExposure_k__BackingField )
			//     goto LABEL_1747;
			//   if ( !*(_QWORD *)(*(_QWORD *)(*(_QWORD *)(sub_18010B520(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass)
			//                                           + 192)
			//                               + 48LL)
			//                   + 32LL) )
			//   {
			//     v80 = sub_18010B520(v79.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v80 + 192) + 48LL))();
			//   }
			//   sub_18010B520(v79.klass);
			//   TempFromCSharp[72] = (Void)dlssUseAutoExposure_k__BackingField.fields._paramValue_k__BackingField;
			//   *(_DWORD *)&TempFromCSharp[76] = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//                                      (SettingParameter_1_System_Int32Enum_ *)settingParameters.fields._dlssGMode_k__BackingField,
			//                                      MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::HyperGryphEngineCode::StreamlineDLSSFGMode>::op_Implicit);
			//   dlssGGenFrames_k__BackingField = settingParameters.fields._dlssGGenFrames_k__BackingField;
			//   if ( !dlssGGenFrames_k__BackingField )
			//     goto LABEL_1747;
			//   *(_DWORD *)&TempFromCSharp[80] = dlssGGenFrames_k__BackingField.fields._paramValue_k__BackingField;
			//   *(_DWORD *)&TempFromCSharp[84] = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//                                      (SettingParameter_1_System_Int32Enum_ *)settingParameters.fields._dlssReflexMode_k__BackingField,
			//                                      MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::HyperGryphEngineCode::StreamlineReflexMode>::op_Implicit);
			//   dlssPCLEnable_k__BackingField = settingParameters.fields._dlssPCLEnable_k__BackingField;
			//   v83 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !dlssPCLEnable_k__BackingField )
			//     goto LABEL_1747;
			//   if ( !*(_QWORD *)(*(_QWORD *)(*(_QWORD *)(sub_18010B520(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass)
			//                                           + 192)
			//                               + 48LL)
			//                   + 32LL) )
			//   {
			//     v84 = sub_18010B520(v83.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v84 + 192) + 48LL))();
			//   }
			//   sub_18010B520(v83.klass);
			//   TempFromCSharp[88] = (Void)dlssPCLEnable_k__BackingField.fields._paramValue_k__BackingField;
			//   v86 = sub_180316568(settingParameters.fields._dlssSharpenStrength_k__BackingField, v85);
			//   *(_DWORD *)&TempFromCSharp[92] = LODWORD(v86);
			//   TempFromCSharp[96] = (Void)sub_18031655C(settingParameters.fields._dlssUseUIHint_k__BackingField, v87);
			//   v89 = sub_180316568(settingParameters.fields._dlssUIHintAlphaThreshold_k__BackingField, v88);
			//   *(_DWORD *)&TempFromCSharp[100] = LODWORD(v89);
			//   TempFromCSharp[104] = (Void)sub_18031655C(settingParameters.fields._fsr3Enable_k__BackingField, v90);
			//   TempFromCSharp[105] = (Void)sub_18031655C(settingParameters.fields._fsr3UseReaciveAndTCMask_k__BackingField, v91);
			//   *(_DWORD *)&TempFromCSharp[108] = sub_1808319B8(settingParameters.fields._fsr3Quality_k__BackingField);
			//   v93 = sub_180316568(settingParameters.fields._fsr3SharpenStrength_k__BackingField, v92);
			//   *(_DWORD *)&TempFromCSharp[112] = LODWORD(v93);
			//   TempFromCSharp[116] = (Void)sub_18031655C(settingParameters.fields._fsr3UseFP16_k__BackingField, v94);
			//   TempFromCSharp[117] = (Void)sub_18031655C(settingParameters.fields._fsr3UseWave_k__BackingField, v95);
			//   TempFromCSharp[118] = (Void)sub_18031655C(settingParameters.fields._fsr3UseWave64_k__BackingField, v96);
			//   TempFromCSharp[119] = (Void)sub_18031655C(settingParameters.fields._fsr3UseLanczosLut_k__BackingField, v97);
			//   bloomQuality_k__BackingField = settingParameters.fields._bloomQuality_k__BackingField;
			//   if ( !bloomQuality_k__BackingField )
			//     goto LABEL_1747;
			//   *(_DWORD *)&TempFromCSharp[120] = bloomQuality_k__BackingField.fields._paramValue_k__BackingField;
			//   TempFromCSharp[124] = (Void)sub_18031655C(settingParameters.fields._bloomUseComputeShader_k__BackingField, v4);
			//   *(_DWORD *)&TempFromCSharp[128] = sub_180316550(settingParameters.fields._lutSize_k__BackingField, v99);
			//   *(_DWORD *)&TempFromCSharp[132] = sub_180316544(settingParameters.fields._lutFormat_k__BackingField, v100);
			//   *(_DWORD *)&TempFromCSharp[136] = sub_180316544(settingParameters.fields._ppBufferFormat_k__BackingField, v101);
			//   *(_DWORD *)&TempFromCSharp[140] = sub_180316544(settingParameters.fields._uiPPBufferFormat_k__BackingField, v102);
			//   TempFromCSharp[144] = (Void)sub_18031655C(
			//                                 settingParameters.fields._frostedGlassUseComputeShader_k__BackingField,
			//                                 v103);
			//   depthOfFieldQuality_k__BackingField = settingParameters.fields._depthOfFieldQuality_k__BackingField;
			//   if ( !depthOfFieldQuality_k__BackingField )
			//     goto LABEL_1747;
			//   *(_DWORD *)&TempFromCSharp[148] = depthOfFieldQuality_k__BackingField.fields._paramValue_k__BackingField;
			//   depthOfFieldMaxRadius_k__BackingField = settingParameters.fields._depthOfFieldMaxRadius_k__BackingField;
			//   v106 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !depthOfFieldMaxRadius_k__BackingField )
			//     goto LABEL_1747;
			//   v107 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v107.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v107.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v108 = v106.klass;
			//     if ( ((__int64)v108.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v106.klass);
			//     (*(void (**)(void))v108.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v106.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[152] = depthOfFieldMaxRadius_k__BackingField.fields._paramValue_k__BackingField;
			//   depthOfFieldScaleAdjust_k__BackingField = settingParameters.fields._depthOfFieldScaleAdjust_k__BackingField;
			//   v110 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !depthOfFieldScaleAdjust_k__BackingField )
			//     goto LABEL_1747;
			//   v111 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v111.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v111.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v112 = v110.klass;
			//     if ( ((__int64)v112.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v110.klass);
			//     (*(void (**)(void))v112.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v110.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   TempFromCSharp[156] = (Void)depthOfFieldScaleAdjust_k__BackingField.fields._paramValue_k__BackingField;
			//   depthOfFieldScaleAdjustThreshold_k__BackingField = settingParameters.fields._depthOfFieldScaleAdjustThreshold_k__BackingField;
			//   v114 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !depthOfFieldScaleAdjustThreshold_k__BackingField )
			//     goto LABEL_1747;
			//   v115 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v115.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v115.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v116 = v114.klass;
			//     if ( ((__int64)v116.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v114.klass);
			//     (*(void (**)(void))v116.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v114.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[160] = depthOfFieldScaleAdjustThreshold_k__BackingField.fields._paramValue_k__BackingField;
			//   motionBlurEnable_k__BackingField = settingParameters.fields._motionBlurEnable_k__BackingField;
			//   v118 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !motionBlurEnable_k__BackingField )
			//     goto LABEL_1747;
			//   v119 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v119.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v119.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v120 = v118.klass;
			//     if ( ((__int64)v120.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v118.klass);
			//     (*(void (**)(void))v120.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v118.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   TempFromCSharp[164] = (Void)motionBlurEnable_k__BackingField.fields._paramValue_k__BackingField;
			//   bloomEnabled_k__BackingField = settingParameters.fields._bloomEnabled_k__BackingField;
			//   v122 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !bloomEnabled_k__BackingField )
			//     goto LABEL_1747;
			//   v123 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v123.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v123.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v124 = v122.klass;
			//     if ( ((__int64)v124.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v122.klass);
			//     (*(void (**)(void))v124.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v122.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   TempFromCSharp[165] = (Void)bloomEnabled_k__BackingField.fields._paramValue_k__BackingField;
			//   vignetteEnabled_k__BackingField = settingParameters.fields._vignetteEnabled_k__BackingField;
			//   v126 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !vignetteEnabled_k__BackingField )
			//     goto LABEL_1747;
			//   v127 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v127.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v127.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v128 = v126.klass;
			//     if ( ((__int64)v128.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v126.klass);
			//     (*(void (**)(void))v128.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v126.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   TempFromCSharp[166] = (Void)vignetteEnabled_k__BackingField.fields._paramValue_k__BackingField;
			//   radialBlurEnabled_k__BackingField = settingParameters.fields._radialBlurEnabled_k__BackingField;
			//   v130 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !radialBlurEnabled_k__BackingField )
			//     goto LABEL_1747;
			//   v131 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v131.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v131.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v132 = v130.klass;
			//     if ( ((__int64)v132.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v130.klass);
			//     (*(void (**)(void))v132.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v130.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   TempFromCSharp[167] = (Void)radialBlurEnabled_k__BackingField.fields._paramValue_k__BackingField;
			//   chromaticAberrationEnabled_k__BackingField = settingParameters.fields._chromaticAberrationEnabled_k__BackingField;
			//   v134 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !chromaticAberrationEnabled_k__BackingField )
			//     goto LABEL_1747;
			//   v135 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v135.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v135.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v136 = v134.klass;
			//     if ( ((__int64)v136.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v134.klass);
			//     (*(void (**)(void))v136.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v134.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   TempFromCSharp[168] = (Void)chromaticAberrationEnabled_k__BackingField.fields._paramValue_k__BackingField;
			//   dirtyLensEnabled_k__BackingField = settingParameters.fields._dirtyLensEnabled_k__BackingField;
			//   v138 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !dirtyLensEnabled_k__BackingField )
			//     goto LABEL_1747;
			//   v139 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v139.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v139.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v140 = v138.klass;
			//     if ( ((__int64)v140.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v138.klass);
			//     (*(void (**)(void))v140.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v138.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   TempFromCSharp[169] = (Void)dirtyLensEnabled_k__BackingField.fields._paramValue_k__BackingField;
			//   sharpenEnabled_k__BackingField = settingParameters.fields._sharpenEnabled_k__BackingField;
			//   v142 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !sharpenEnabled_k__BackingField )
			//     goto LABEL_1747;
			//   v143 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v143.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v143.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v144 = v142.klass;
			//     if ( ((__int64)v144.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v142.klass);
			//     (*(void (**)(void))v144.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v142.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   TempFromCSharp[170] = (Void)sharpenEnabled_k__BackingField.fields._paramValue_k__BackingField;
			//   frostedGlassEnabled_k__BackingField = settingParameters.fields._frostedGlassEnabled_k__BackingField;
			//   v146 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !frostedGlassEnabled_k__BackingField )
			//     goto LABEL_1747;
			//   v147 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v147.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v147.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v148 = v146.klass;
			//     if ( ((__int64)v148.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v146.klass);
			//     (*(void (**)(void))v148.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v146.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   TempFromCSharp[171] = (Void)frostedGlassEnabled_k__BackingField.fields._paramValue_k__BackingField;
			//   cutsceneEffectEnabled_k__BackingField = settingParameters.fields._cutsceneEffectEnabled_k__BackingField;
			//   v150 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !cutsceneEffectEnabled_k__BackingField )
			//     goto LABEL_1747;
			//   v151 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v151.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v151.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v152 = v150.klass;
			//     if ( ((__int64)v152.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v150.klass);
			//     (*(void (**)(void))v152.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v150.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   TempFromCSharp[172] = (Void)cutsceneEffectEnabled_k__BackingField.fields._paramValue_k__BackingField;
			//   fisheyeEffectEnabled_k__BackingField = settingParameters.fields._fisheyeEffectEnabled_k__BackingField;
			//   v154 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !fisheyeEffectEnabled_k__BackingField )
			//     goto LABEL_1747;
			//   v155 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v155.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v155.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v156 = v154.klass;
			//     if ( ((__int64)v156.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v154.klass);
			//     (*(void (**)(void))v156.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v154.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   TempFromCSharp[173] = (Void)fisheyeEffectEnabled_k__BackingField.fields._paramValue_k__BackingField;
			//   lensFlareEnabled_k__BackingField = settingParameters.fields._lensFlareEnabled_k__BackingField;
			//   v158 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !lensFlareEnabled_k__BackingField )
			//     goto LABEL_1747;
			//   v159 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v159.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v159.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v160 = v158.klass;
			//     if ( ((__int64)v160.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v158.klass);
			//     (*(void (**)(void))v160.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v158.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   TempFromCSharp[174] = (Void)lensFlareEnabled_k__BackingField.fields._paramValue_k__BackingField;
			//   punctualLightMaxCount_k__BackingField = settingParameters.fields._punctualLightMaxCount_k__BackingField;
			//   v162 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !punctualLightMaxCount_k__BackingField )
			//     goto LABEL_1747;
			//   v163 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v163.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v163.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v164 = v162.klass;
			//     if ( ((__int64)v164.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v162.klass);
			//     (*(void (**)(void))v164.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v162.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(_DWORD *)&TempFromCSharp[176] = punctualLightMaxCount_k__BackingField.fields._paramValue_k__BackingField;
			//   enableShadowProxy_k__BackingField = settingParameters.fields._enableShadowProxy_k__BackingField;
			//   v166 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !enableShadowProxy_k__BackingField )
			//     goto LABEL_1747;
			//   v167 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v167.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v167.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v168 = v166.klass;
			//     if ( ((__int64)v168.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v166.klass);
			//     (*(void (**)(void))v168.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v166.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   TempFromCSharp[180] = (Void)enableShadowProxy_k__BackingField.fields._paramValue_k__BackingField;
			//   shadowDepthBits_k__BackingField = settingParameters.fields._shadowDepthBits_k__BackingField;
			//   if ( !shadowDepthBits_k__BackingField )
			//     goto LABEL_1747;
			//   *(_DWORD *)&TempFromCSharp[184] = shadowDepthBits_k__BackingField.fields._paramValue_k__BackingField;
			//   enableScreenSpaceShadowMask_k__BackingField = settingParameters.fields._enableScreenSpaceShadowMask_k__BackingField;
			//   v171 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !enableScreenSpaceShadowMask_k__BackingField )
			//     goto LABEL_1747;
			//   v172 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v172.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v172.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v173 = v171.klass;
			//     if ( ((__int64)v173.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v171.klass);
			//     (*(void (**)(void))v173.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v171.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   TempFromCSharp[188] = (Void)enableScreenSpaceShadowMask_k__BackingField.fields._paramValue_k__BackingField;
			//   csmEnabled_k__BackingField = settingParameters.fields._csmEnabled_k__BackingField;
			//   v175 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !csmEnabled_k__BackingField )
			//     goto LABEL_1747;
			//   v176 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v176.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v176.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v177 = v175.klass;
			//     if ( ((__int64)v177.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v175.klass);
			//     (*(void (**)(void))v177.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v175.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   TempFromCSharp[189] = (Void)csmEnabled_k__BackingField.fields._paramValue_k__BackingField;
			//   csmShadowMapTileResolution_k__BackingField = settingParameters.fields._csmShadowMapTileResolution_k__BackingField;
			//   v179 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !csmShadowMapTileResolution_k__BackingField )
			//     goto LABEL_1747;
			//   v180 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v180.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v180.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v181 = v179.klass;
			//     if ( ((__int64)v181.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v179.klass);
			//     (*(void (**)(void))v181.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v179.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(_DWORD *)&TempFromCSharp[192] = csmShadowMapTileResolution_k__BackingField.fields._paramValue_k__BackingField;
			//   csmMaxDistance_k__BackingField = settingParameters.fields._csmMaxDistance_k__BackingField;
			//   v183 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !csmMaxDistance_k__BackingField )
			//     goto LABEL_1747;
			//   v184 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v184.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v184.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v185 = v183.klass;
			//     if ( ((__int64)v185.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v183.klass);
			//     (*(void (**)(void))v185.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v183.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[196] = csmMaxDistance_k__BackingField.fields._paramValue_k__BackingField;
			//   csmFadeInnerDistance_k__BackingField = settingParameters.fields._csmFadeInnerDistance_k__BackingField;
			//   v187 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !csmFadeInnerDistance_k__BackingField )
			//     goto LABEL_1747;
			//   v188 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v188.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v188.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v189 = v187.klass;
			//     if ( ((__int64)v189.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v187.klass);
			//     (*(void (**)(void))v189.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v187.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[200] = csmFadeInnerDistance_k__BackingField.fields._paramValue_k__BackingField;
			//   csmSplitCount_k__BackingField = settingParameters.fields._csmSplitCount_k__BackingField;
			//   v191 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !csmSplitCount_k__BackingField )
			//     goto LABEL_1747;
			//   v192 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v192.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v192.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v193 = v191.klass;
			//     if ( ((__int64)v193.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v191.klass);
			//     (*(void (**)(void))v193.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v191.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(_DWORD *)&TempFromCSharp[204] = csmSplitCount_k__BackingField.fields._paramValue_k__BackingField;
			//   csmSplit0_k__BackingField = settingParameters.fields._csmSplit0_k__BackingField;
			//   v195 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !csmSplit0_k__BackingField )
			//     goto LABEL_1747;
			//   v196 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v196.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v196.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v197 = v195.klass;
			//     if ( ((__int64)v197.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v195.klass);
			//     (*(void (**)(void))v197.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v195.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[208] = csmSplit0_k__BackingField.fields._paramValue_k__BackingField;
			//   csmSplit1_k__BackingField = settingParameters.fields._csmSplit1_k__BackingField;
			//   v199 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !csmSplit1_k__BackingField )
			//     goto LABEL_1747;
			//   v200 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v200.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v200.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v201 = v199.klass;
			//     if ( ((__int64)v201.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v199.klass);
			//     (*(void (**)(void))v201.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v199.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[212] = csmSplit1_k__BackingField.fields._paramValue_k__BackingField;
			//   csmSplit2_k__BackingField = settingParameters.fields._csmSplit2_k__BackingField;
			//   v203 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !csmSplit2_k__BackingField )
			//     goto LABEL_1747;
			//   v204 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v204.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v204.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v205 = v203.klass;
			//     if ( ((__int64)v205.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v203.klass);
			//     (*(void (**)(void))v205.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v203.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[216] = csmSplit2_k__BackingField.fields._paramValue_k__BackingField;
			//   csmSplit3_k__BackingField = settingParameters.fields._csmSplit3_k__BackingField;
			//   v207 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !csmSplit3_k__BackingField )
			//     goto LABEL_1747;
			//   v208 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v208.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v208.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v209 = v207.klass;
			//     if ( ((__int64)v209.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v207.klass);
			//     (*(void (**)(void))v209.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v207.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[220] = csmSplit3_k__BackingField.fields._paramValue_k__BackingField;
			//   csmUseShadowmapCache_k__BackingField = settingParameters.fields._csmUseShadowmapCache_k__BackingField;
			//   v211 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !csmUseShadowmapCache_k__BackingField )
			//     goto LABEL_1747;
			//   v212 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v212.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v212.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v213 = v211.klass;
			//     if ( ((__int64)v213.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v211.klass);
			//     (*(void (**)(void))v213.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v211.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   TempFromCSharp[224] = (Void)csmUseShadowmapCache_k__BackingField.fields._paramValue_k__BackingField;
			//   csmCachedFrame0_k__BackingField = settingParameters.fields._csmCachedFrame0_k__BackingField;
			//   v215 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !csmCachedFrame0_k__BackingField )
			//     goto LABEL_1747;
			//   v216 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v216.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v216.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v217 = v215.klass;
			//     if ( ((__int64)v217.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v215.klass);
			//     (*(void (**)(void))v217.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v215.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(_DWORD *)&TempFromCSharp[228] = csmCachedFrame0_k__BackingField.fields._paramValue_k__BackingField;
			//   csmCachedFrame1_k__BackingField = settingParameters.fields._csmCachedFrame1_k__BackingField;
			//   v219 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !csmCachedFrame1_k__BackingField )
			//     goto LABEL_1747;
			//   v220 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v220.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v220.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v221 = v219.klass;
			//     if ( ((__int64)v221.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v219.klass);
			//     (*(void (**)(void))v221.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v219.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(_DWORD *)&TempFromCSharp[232] = csmCachedFrame1_k__BackingField.fields._paramValue_k__BackingField;
			//   csmCachedFrame2_k__BackingField = settingParameters.fields._csmCachedFrame2_k__BackingField;
			//   v223 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !csmCachedFrame2_k__BackingField )
			//     goto LABEL_1747;
			//   v224 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v224.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v224.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v225 = v223.klass;
			//     if ( ((__int64)v225.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v223.klass);
			//     (*(void (**)(void))v225.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v223.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(_DWORD *)&TempFromCSharp[236] = csmCachedFrame2_k__BackingField.fields._paramValue_k__BackingField;
			//   csmCachedFrame3_k__BackingField = settingParameters.fields._csmCachedFrame3_k__BackingField;
			//   v227 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !csmCachedFrame3_k__BackingField )
			//     goto LABEL_1747;
			//   v228 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v228.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v228.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v229 = v227.klass;
			//     if ( ((__int64)v229.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v227.klass);
			//     (*(void (**)(void))v229.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v227.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(_DWORD *)&TempFromCSharp[240] = csmCachedFrame3_k__BackingField.fields._paramValue_k__BackingField;
			//   csmScreenSizeMin0_k__BackingField = settingParameters.fields._csmScreenSizeMin0_k__BackingField;
			//   v231 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !csmScreenSizeMin0_k__BackingField )
			//     goto LABEL_1747;
			//   v232 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v232.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v232.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v233 = v231.klass;
			//     if ( ((__int64)v233.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v231.klass);
			//     (*(void (**)(void))v233.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v231.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[244] = csmScreenSizeMin0_k__BackingField.fields._paramValue_k__BackingField;
			//   csmScreenSizeMin1_k__BackingField = settingParameters.fields._csmScreenSizeMin1_k__BackingField;
			//   v235 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !csmScreenSizeMin1_k__BackingField )
			//     goto LABEL_1747;
			//   v236 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v236.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v236.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v237 = v235.klass;
			//     if ( ((__int64)v237.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v235.klass);
			//     (*(void (**)(void))v237.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v235.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[248] = csmScreenSizeMin1_k__BackingField.fields._paramValue_k__BackingField;
			//   csmScreenSizeMin2_k__BackingField = settingParameters.fields._csmScreenSizeMin2_k__BackingField;
			//   v239 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !csmScreenSizeMin2_k__BackingField )
			//     goto LABEL_1747;
			//   v240 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v240.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v240.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v241 = v239.klass;
			//     if ( ((__int64)v241.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v239.klass);
			//     (*(void (**)(void))v241.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v239.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[252] = csmScreenSizeMin2_k__BackingField.fields._paramValue_k__BackingField;
			//   csmScreenSizeMin3_k__BackingField = settingParameters.fields._csmScreenSizeMin3_k__BackingField;
			//   v243 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !csmScreenSizeMin3_k__BackingField )
			//     goto LABEL_1747;
			//   v244 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v244.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v244.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v245 = v243.klass;
			//     if ( ((__int64)v245.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v243.klass);
			//     (*(void (**)(void))v245.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v243.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[256] = csmScreenSizeMin3_k__BackingField.fields._paramValue_k__BackingField;
			//   csmEnableOcclusionCulling0_k__BackingField = settingParameters.fields._csmEnableOcclusionCulling0_k__BackingField;
			//   v247 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !csmEnableOcclusionCulling0_k__BackingField )
			//     goto LABEL_1747;
			//   v248 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v248.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v248.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v249 = v247.klass;
			//     if ( ((__int64)v249.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v247.klass);
			//     (*(void (**)(void))v249.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v247.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   TempFromCSharp[260] = (Void)csmEnableOcclusionCulling0_k__BackingField.fields._paramValue_k__BackingField;
			//   csmEnableOcclusionCulling1_k__BackingField = settingParameters.fields._csmEnableOcclusionCulling1_k__BackingField;
			//   v251 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !csmEnableOcclusionCulling1_k__BackingField )
			//     goto LABEL_1747;
			//   v252 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v252.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v252.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v253 = v251.klass;
			//     if ( ((__int64)v253.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v251.klass);
			//     (*(void (**)(void))v253.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v251.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   TempFromCSharp[261] = (Void)csmEnableOcclusionCulling1_k__BackingField.fields._paramValue_k__BackingField;
			//   csmEnableOcclusionCulling2_k__BackingField = settingParameters.fields._csmEnableOcclusionCulling2_k__BackingField;
			//   v255 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !csmEnableOcclusionCulling2_k__BackingField )
			//     goto LABEL_1747;
			//   v256 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v256.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v256.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v257 = v255.klass;
			//     if ( ((__int64)v257.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v255.klass);
			//     (*(void (**)(void))v257.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v255.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   TempFromCSharp[262] = (Void)csmEnableOcclusionCulling2_k__BackingField.fields._paramValue_k__BackingField;
			//   csmEnableOcclusionCulling3_k__BackingField = settingParameters.fields._csmEnableOcclusionCulling3_k__BackingField;
			//   v259 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !csmEnableOcclusionCulling3_k__BackingField )
			//     goto LABEL_1747;
			//   v260 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v260.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v260.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v261 = v259.klass;
			//     if ( ((__int64)v261.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v259.klass);
			//     (*(void (**)(void))v261.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v259.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   TempFromCSharp[263] = (Void)csmEnableOcclusionCulling3_k__BackingField.fields._paramValue_k__BackingField;
			//   csmOcclusionDepthSize_k__BackingField = settingParameters.fields._csmOcclusionDepthSize_k__BackingField;
			//   v263 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !csmOcclusionDepthSize_k__BackingField )
			//     goto LABEL_1747;
			//   v264 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v264.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v264.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v265 = v263.klass;
			//     if ( ((__int64)v265.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v263.klass);
			//     (*(void (**)(void))v265.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v263.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(_DWORD *)&TempFromCSharp[264] = csmOcclusionDepthSize_k__BackingField.fields._paramValue_k__BackingField;
			//   csmStopRenderCharacterCascade_k__BackingField = settingParameters.fields._csmStopRenderCharacterCascade_k__BackingField;
			//   v267 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !csmStopRenderCharacterCascade_k__BackingField )
			//     goto LABEL_1747;
			//   v268 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v268.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v268.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v269 = v267.klass;
			//     if ( ((__int64)v269.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v267.klass);
			//     (*(void (**)(void))v269.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v267.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(_DWORD *)&TempFromCSharp[268] = csmStopRenderCharacterCascade_k__BackingField.fields._paramValue_k__BackingField;
			//   csmNearPlaneOffset_k__BackingField = settingParameters.fields._csmNearPlaneOffset_k__BackingField;
			//   v271 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !csmNearPlaneOffset_k__BackingField )
			//     goto LABEL_1747;
			//   v272 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v272.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v272.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v273 = v271.klass;
			//     if ( ((__int64)v273.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v271.klass);
			//     (*(void (**)(void))v273.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v271.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[272] = csmNearPlaneOffset_k__BackingField.fields._paramValue_k__BackingField;
			//   csmHardwareBias_k__BackingField = settingParameters.fields._csmHardwareBias_k__BackingField;
			//   v275 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !csmHardwareBias_k__BackingField )
			//     goto LABEL_1747;
			//   v276 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v276.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v276.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v277 = v275.klass;
			//     if ( ((__int64)v277.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v275.klass);
			//     (*(void (**)(void))v277.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v275.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[276] = csmHardwareBias_k__BackingField.fields._paramValue_k__BackingField;
			//   csmHardwareNormalBias_k__BackingField = settingParameters.fields._csmHardwareNormalBias_k__BackingField;
			//   v279 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !csmHardwareNormalBias_k__BackingField )
			//     goto LABEL_1747;
			//   v280 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v280.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v280.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v281 = v279.klass;
			//     if ( ((__int64)v281.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v279.klass);
			//     (*(void (**)(void))v281.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v279.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[280] = csmHardwareNormalBias_k__BackingField.fields._paramValue_k__BackingField;
			//   characterShadowEnabled_k__BackingField = settingParameters.fields._characterShadowEnabled_k__BackingField;
			//   v283 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !characterShadowEnabled_k__BackingField )
			//     goto LABEL_1747;
			//   v284 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v284.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v284.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v285 = v283.klass;
			//     if ( ((__int64)v285.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v283.klass);
			//     (*(void (**)(void))v285.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v283.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   TempFromCSharp[284] = (Void)characterShadowEnabled_k__BackingField.fields._paramValue_k__BackingField;
			//   characterShadowMapResolution_k__BackingField = settingParameters.fields._characterShadowMapResolution_k__BackingField;
			//   v287 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !characterShadowMapResolution_k__BackingField )
			//     goto LABEL_1747;
			//   v288 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v288.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v288.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v289 = v287.klass;
			//     if ( ((__int64)v289.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v287.klass);
			//     (*(void (**)(void))v289.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v287.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(_DWORD *)&TempFromCSharp[288] = characterShadowMapResolution_k__BackingField.fields._paramValue_k__BackingField;
			//   characterShadowHardwareBias_k__BackingField = settingParameters.fields._characterShadowHardwareBias_k__BackingField;
			//   v291 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !characterShadowHardwareBias_k__BackingField )
			//     goto LABEL_1747;
			//   v292 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v292.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v292.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v293 = v291.klass;
			//     if ( ((__int64)v293.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v291.klass);
			//     (*(void (**)(void))v293.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v291.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[292] = characterShadowHardwareBias_k__BackingField.fields._paramValue_k__BackingField;
			//   characterShadowHardwareNormalBias_k__BackingField = settingParameters.fields._characterShadowHardwareNormalBias_k__BackingField;
			//   v295 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !characterShadowHardwareNormalBias_k__BackingField )
			//     goto LABEL_1747;
			//   v296 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v296.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v296.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v297 = v295.klass;
			//     if ( ((__int64)v297.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v295.klass);
			//     (*(void (**)(void))v297.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v295.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[296] = characterShadowHardwareNormalBias_k__BackingField.fields._paramValue_k__BackingField;
			//   characterShadowShaderBias_k__BackingField = settingParameters.fields._characterShadowShaderBias_k__BackingField;
			//   v299 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !characterShadowShaderBias_k__BackingField )
			//     goto LABEL_1747;
			//   v300 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v300.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v300.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v301 = v299.klass;
			//     if ( ((__int64)v301.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v299.klass);
			//     (*(void (**)(void))v301.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v299.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[300] = characterShadowShaderBias_k__BackingField.fields._paramValue_k__BackingField;
			//   characterShadowShaderNormalBias_k__BackingField = settingParameters.fields._characterShadowShaderNormalBias_k__BackingField;
			//   v303 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !characterShadowShaderNormalBias_k__BackingField )
			//     goto LABEL_1747;
			//   v304 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v304.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v304.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v305 = v303.klass;
			//     if ( ((__int64)v305.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v303.klass);
			//     (*(void (**)(void))v305.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v303.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[304] = characterShadowShaderNormalBias_k__BackingField.fields._paramValue_k__BackingField;
			//   punctualLightShadowEnabled_k__BackingField = settingParameters.fields._punctualLightShadowEnabled_k__BackingField;
			//   v307 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !punctualLightShadowEnabled_k__BackingField )
			//     goto LABEL_1747;
			//   v308 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v308.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v308.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v309 = v307.klass;
			//     if ( ((__int64)v309.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v307.klass);
			//     (*(void (**)(void))v309.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v307.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   TempFromCSharp[308] = (Void)punctualLightShadowEnabled_k__BackingField.fields._paramValue_k__BackingField;
			//   punctualLightTileMaxSize_k__BackingField = settingParameters.fields._punctualLightTileMaxSize_k__BackingField;
			//   v311 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !punctualLightTileMaxSize_k__BackingField )
			//     goto LABEL_1747;
			//   v312 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v312.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v312.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v313 = v311.klass;
			//     if ( ((__int64)v313.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v311.klass);
			//     (*(void (**)(void))v313.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v311.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(_DWORD *)&TempFromCSharp[312] = punctualLightTileMaxSize_k__BackingField.fields._paramValue_k__BackingField;
			//   punctualLightForceCullDistance_k__BackingField = settingParameters.fields._punctualLightForceCullDistance_k__BackingField;
			//   v315 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !punctualLightForceCullDistance_k__BackingField )
			//     goto LABEL_1747;
			//   v316 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v316.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v316.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v317 = v315.klass;
			//     if ( ((__int64)v317.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v315.klass);
			//     (*(void (**)(void))v317.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v315.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[316] = punctualLightForceCullDistance_k__BackingField.fields._paramValue_k__BackingField;
			//   punctualLightEnvDynamicCasterCount_k__BackingField = settingParameters.fields._punctualLightEnvDynamicCasterCount_k__BackingField;
			//   v319 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !punctualLightEnvDynamicCasterCount_k__BackingField )
			//     goto LABEL_1747;
			//   v320 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v320.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v320.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v321 = v319.klass;
			//     if ( ((__int64)v321.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v319.klass);
			//     (*(void (**)(void))v321.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v319.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(_DWORD *)&TempFromCSharp[320] = punctualLightEnvDynamicCasterCount_k__BackingField.fields._paramValue_k__BackingField;
			//   punctualLightMovableDynamicCasterCount_k__BackingField = settingParameters.fields._punctualLightMovableDynamicCasterCount_k__BackingField;
			//   v323 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !punctualLightMovableDynamicCasterCount_k__BackingField )
			//     goto LABEL_1747;
			//   v324 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v324.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v324.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v325 = v323.klass;
			//     if ( ((__int64)v325.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v323.klass);
			//     (*(void (**)(void))v325.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v323.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(_DWORD *)&TempFromCSharp[324] = punctualLightMovableDynamicCasterCount_k__BackingField.fields._paramValue_k__BackingField;
			//   punctualLightShadowScreenSizeMin_k__BackingField = settingParameters.fields._punctualLightShadowScreenSizeMin_k__BackingField;
			//   v327 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !punctualLightShadowScreenSizeMin_k__BackingField )
			//     goto LABEL_1747;
			//   v328 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v328.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v328.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v329 = v327.klass;
			//     if ( ((__int64)v329.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v327.klass);
			//     (*(void (**)(void))v329.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v327.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[328] = punctualLightShadowScreenSizeMin_k__BackingField.fields._paramValue_k__BackingField;
			//   asmEnabled_k__BackingField = settingParameters.fields._asmEnabled_k__BackingField;
			//   v331 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !asmEnabled_k__BackingField )
			//     goto LABEL_1747;
			//   v332 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v332.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v332.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v333 = v331.klass;
			//     if ( ((__int64)v333.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v331.klass);
			//     (*(void (**)(void))v333.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v331.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   TempFromCSharp[332] = (Void)asmEnabled_k__BackingField.fields._paramValue_k__BackingField;
			//   asmShadowMapTileResolution_k__BackingField = settingParameters.fields._asmShadowMapTileResolution_k__BackingField;
			//   v335 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !asmShadowMapTileResolution_k__BackingField )
			//     goto LABEL_1747;
			//   v336 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v336.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v336.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v337 = v335.klass;
			//     if ( ((__int64)v337.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v335.klass);
			//     (*(void (**)(void))v337.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v335.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(_DWORD *)&TempFromCSharp[336] = asmShadowMapTileResolution_k__BackingField.fields._paramValue_k__BackingField;
			//   asmMaxDistance_k__BackingField = settingParameters.fields._asmMaxDistance_k__BackingField;
			//   v339 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !asmMaxDistance_k__BackingField )
			//     goto LABEL_1747;
			//   v340 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v340.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v340.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v341 = v339.klass;
			//     if ( ((__int64)v341.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v339.klass);
			//     (*(void (**)(void))v341.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v339.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[340] = asmMaxDistance_k__BackingField.fields._paramValue_k__BackingField;
			//   asmMaxTileRenderCountPerFrame_k__BackingField = settingParameters.fields._asmMaxTileRenderCountPerFrame_k__BackingField;
			//   v343 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !asmMaxTileRenderCountPerFrame_k__BackingField )
			//     goto LABEL_1747;
			//   v344 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v344.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v344.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v345 = v343.klass;
			//     if ( ((__int64)v345.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v343.klass);
			//     (*(void (**)(void))v345.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v343.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(_DWORD *)&TempFromCSharp[344] = asmMaxTileRenderCountPerFrame_k__BackingField.fields._paramValue_k__BackingField;
			//   asmDepthBias_k__BackingField = settingParameters.fields._asmDepthBias_k__BackingField;
			//   v347 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !asmDepthBias_k__BackingField )
			//     goto LABEL_1747;
			//   v348 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v348.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v348.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v349 = v347.klass;
			//     if ( ((__int64)v349.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v347.klass);
			//     (*(void (**)(void))v349.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v347.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[348] = asmDepthBias_k__BackingField.fields._paramValue_k__BackingField;
			//   asmNormalBias_k__BackingField = settingParameters.fields._asmNormalBias_k__BackingField;
			//   v351 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !asmNormalBias_k__BackingField )
			//     goto LABEL_1747;
			//   v352 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v352.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v352.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v353 = v351.klass;
			//     if ( ((__int64)v353.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v351.klass);
			//     (*(void (**)(void))v353.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v351.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[352] = asmNormalBias_k__BackingField.fields._paramValue_k__BackingField;
			//   asmScreenSizeMin_k__BackingField = settingParameters.fields._asmScreenSizeMin_k__BackingField;
			//   v355 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !asmScreenSizeMin_k__BackingField )
			//     goto LABEL_1747;
			//   v356 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v356.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v356.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v357 = v355.klass;
			//     if ( ((__int64)v357.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v355.klass);
			//     (*(void (**)(void))v357.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v355.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[356] = asmScreenSizeMin_k__BackingField.fields._paramValue_k__BackingField;
			//   transientGBuffer_k__BackingField = settingParameters.fields._transientGBuffer_k__BackingField;
			//   v359 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !transientGBuffer_k__BackingField )
			//     goto LABEL_1747;
			//   v360 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v360.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v360.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v361 = v359.klass;
			//     if ( ((__int64)v361.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v359.klass);
			//     (*(void (**)(void))v361.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v359.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   TempFromCSharp[360] = (Void)transientGBuffer_k__BackingField.fields._paramValue_k__BackingField;
			//   depthBitsGBuffer_k__BackingField = settingParameters.fields._depthBitsGBuffer_k__BackingField;
			//   if ( !depthBitsGBuffer_k__BackingField )
			//     goto LABEL_1747;
			//   *(_DWORD *)&TempFromCSharp[364] = depthBitsGBuffer_k__BackingField.fields._paramValue_k__BackingField;
			//   depthCombinedWithStencil_k__BackingField = settingParameters.fields._depthCombinedWithStencil_k__BackingField;
			//   v364 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !depthCombinedWithStencil_k__BackingField )
			//     goto LABEL_1747;
			//   v365 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v365.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v365.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v366 = v364.klass;
			//     if ( ((__int64)v366.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v364.klass);
			//     (*(void (**)(void))v366.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v364.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   TempFromCSharp[368] = (Void)depthCombinedWithStencil_k__BackingField.fields._paramValue_k__BackingField;
			//   copySceneRTScale_k__BackingField = settingParameters.fields._copySceneRTScale_k__BackingField;
			//   v368 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !copySceneRTScale_k__BackingField )
			//     goto LABEL_1747;
			//   v369 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v369.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v369.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v370 = v368.klass;
			//     if ( ((__int64)v370.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v368.klass);
			//     (*(void (**)(void))v370.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v368.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[372] = copySceneRTScale_k__BackingField.fields._paramValue_k__BackingField;
			//   taauResolveResolutionHeight_k__BackingField = settingParameters.fields._taauResolveResolutionHeight_k__BackingField;
			//   v372 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !taauResolveResolutionHeight_k__BackingField )
			//     goto LABEL_1747;
			//   v373 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v373.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v373.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v374 = v372.klass;
			//     if ( ((__int64)v374.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v372.klass);
			//     (*(void (**)(void))v374.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   v375 = v372.klass;
			//   if ( ((__int64)v375.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(v375);
			//   *(_DWORD *)&TempFromCSharp[376] = taauResolveResolutionHeight_k__BackingField.fields._paramValue_k__BackingField;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGUtils._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGUtils, v4);
			//   *(float *)&TempFromCSharp[380] = HG::Rendering::Runtime::HGUtils::GetRenderingScale(settingParameters, 0LL);
			//   backBufferResolutionHeight_k__BackingField = settingParameters.fields._backBufferResolutionHeight_k__BackingField;
			//   v377 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !backBufferResolutionHeight_k__BackingField )
			//     goto LABEL_1747;
			//   v378 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v378.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v378.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v379 = v377.klass;
			//     if ( ((__int64)v379.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v377.klass);
			//     (*(void (**)(void))v379.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v377.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(_DWORD *)&TempFromCSharp[384] = backBufferResolutionHeight_k__BackingField.fields._paramValue_k__BackingField;
			//   textureStreamingEnable_k__BackingField = settingParameters.fields._textureStreamingEnable_k__BackingField;
			//   v381 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !textureStreamingEnable_k__BackingField )
			//     goto LABEL_1747;
			//   v382 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v382.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v382.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v383 = v381.klass;
			//     if ( ((__int64)v383.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v381.klass);
			//     (*(void (**)(void))v383.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v381.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   TempFromCSharp[388] = (Void)textureStreamingEnable_k__BackingField.fields._paramValue_k__BackingField;
			//   textureStreamingBudget_k__BackingField = settingParameters.fields._textureStreamingBudget_k__BackingField;
			//   v385 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !textureStreamingBudget_k__BackingField )
			//     goto LABEL_1747;
			//   v386 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v386.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v386.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v387 = v385.klass;
			//     if ( ((__int64)v387.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v385.klass);
			//     (*(void (**)(void))v387.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v385.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(_DWORD *)&TempFromCSharp[392] = textureStreamingBudget_k__BackingField.fields._paramValue_k__BackingField;
			//   textureStreamingMaxBudget_k__BackingField = settingParameters.fields._textureStreamingMaxBudget_k__BackingField;
			//   v389 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !textureStreamingMaxBudget_k__BackingField )
			//     goto LABEL_1747;
			//   v390 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v390.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v390.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v391 = v389.klass;
			//     if ( ((__int64)v391.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v389.klass);
			//     (*(void (**)(void))v391.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v389.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(_DWORD *)&TempFromCSharp[396] = textureStreamingMaxBudget_k__BackingField.fields._paramValue_k__BackingField;
			//   reservedMemoryForNonTextureStreaming_k__BackingField = settingParameters.fields._reservedMemoryForNonTextureStreaming_k__BackingField;
			//   v393 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !reservedMemoryForNonTextureStreaming_k__BackingField )
			//     goto LABEL_1747;
			//   v394 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v394.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v394.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v395 = v393.klass;
			//     if ( ((__int64)v395.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v393.klass);
			//     (*(void (**)(void))v395.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v393.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(_DWORD *)&TempFromCSharp[400] = reservedMemoryForNonTextureStreaming_k__BackingField.fields._paramValue_k__BackingField;
			//   textureStreamingMobileBudgetPercent_k__BackingField = settingParameters.fields._textureStreamingMobileBudgetPercent_k__BackingField;
			//   v397 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !textureStreamingMobileBudgetPercent_k__BackingField )
			//     goto LABEL_1747;
			//   v398 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v398.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v398.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v399 = v397.klass;
			//     if ( ((__int64)v399.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v397.klass);
			//     (*(void (**)(void))v399.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v397.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[404] = textureStreamingMobileBudgetPercent_k__BackingField.fields._paramValue_k__BackingField;
			//   textureStreamingRendererPerFrame_k__BackingField = settingParameters.fields._textureStreamingRendererPerFrame_k__BackingField;
			//   v401 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !textureStreamingRendererPerFrame_k__BackingField )
			//     goto LABEL_1747;
			//   v402 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v402.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v402.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v403 = v401.klass;
			//     if ( ((__int64)v403.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v401.klass);
			//     (*(void (**)(void))v403.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v401.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(_DWORD *)&TempFromCSharp[408] = textureStreamingRendererPerFrame_k__BackingField.fields._paramValue_k__BackingField;
			//   textureStreamingMaxFileIORequests_k__BackingField = settingParameters.fields._textureStreamingMaxFileIORequests_k__BackingField;
			//   v405 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !textureStreamingMaxFileIORequests_k__BackingField )
			//     goto LABEL_1747;
			//   v406 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v406.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v406.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v407 = v405.klass;
			//     if ( ((__int64)v407.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v405.klass);
			//     (*(void (**)(void))v407.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v405.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(_DWORD *)&TempFromCSharp[412] = textureStreamingMaxFileIORequests_k__BackingField.fields._paramValue_k__BackingField;
			//   contactShadowEnableParam_k__BackingField = settingParameters.fields._contactShadowEnableParam_k__BackingField;
			//   v409 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !contactShadowEnableParam_k__BackingField )
			//     goto LABEL_1747;
			//   v410 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v410.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v410.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v411 = v409.klass;
			//     if ( ((__int64)v411.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v409.klass);
			//     (*(void (**)(void))v411.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v409.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   TempFromCSharp[416] = (Void)contactShadowEnableParam_k__BackingField.fields._paramValue_k__BackingField;
			//   gtaoEnable_k__BackingField = settingParameters.fields._gtaoEnable_k__BackingField;
			//   v413 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !gtaoEnable_k__BackingField )
			//     goto LABEL_1747;
			//   v414 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v414.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v414.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v415 = v413.klass;
			//     if ( ((__int64)v415.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v413.klass);
			//     (*(void (**)(void))v415.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v413.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   TempFromCSharp[417] = (Void)gtaoEnable_k__BackingField.fields._paramValue_k__BackingField;
			//   gtaoQualityLevel_k__BackingField = settingParameters.fields._gtaoQualityLevel_k__BackingField;
			//   v417 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !gtaoQualityLevel_k__BackingField )
			//     goto LABEL_1747;
			//   v418 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v418.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v418.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v419 = v417.klass;
			//     if ( ((__int64)v419.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v417.klass);
			//     (*(void (**)(void))v419.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v417.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(_DWORD *)&TempFromCSharp[420] = gtaoQualityLevel_k__BackingField.fields._paramValue_k__BackingField;
			//   ssrEnable_k__BackingField = settingParameters.fields._ssrEnable_k__BackingField;
			//   v421 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !ssrEnable_k__BackingField )
			//     goto LABEL_1747;
			//   v422 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v422.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v422.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v423 = v421.klass;
			//     if ( ((__int64)v423.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v421.klass);
			//     (*(void (**)(void))v423.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v421.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   TempFromCSharp[424] = (Void)ssrEnable_k__BackingField.fields._paramValue_k__BackingField;
			//   ssrRayMarchingSampleCount_k__BackingField = settingParameters.fields._ssrRayMarchingSampleCount_k__BackingField;
			//   v425 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !ssrRayMarchingSampleCount_k__BackingField )
			//     goto LABEL_1747;
			//   v426 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v426.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v426.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v427 = v425.klass;
			//     if ( ((__int64)v427.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v425.klass);
			//     (*(void (**)(void))v427.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v425.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(_DWORD *)&TempFromCSharp[428] = ssrRayMarchingSampleCount_k__BackingField.fields._paramValue_k__BackingField;
			//   ssrImportanceSample_k__BackingField = settingParameters.fields._ssrImportanceSample_k__BackingField;
			//   v429 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !ssrImportanceSample_k__BackingField )
			//     goto LABEL_1747;
			//   v430 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v430.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v430.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v431 = v429.klass;
			//     if ( ((__int64)v431.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v429.klass);
			//     (*(void (**)(void))v431.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v429.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   TempFromCSharp[432] = (Void)ssrImportanceSample_k__BackingField.fields._paramValue_k__BackingField;
			//   ssrV2_k__BackingField = settingParameters.fields._ssrV2_k__BackingField;
			//   v433 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !ssrV2_k__BackingField )
			//     goto LABEL_1747;
			//   v434 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v434.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v434.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v435 = v433.klass;
			//     if ( ((__int64)v435.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v433.klass);
			//     (*(void (**)(void))v435.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v433.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   TempFromCSharp[433] = (Void)ssrV2_k__BackingField.fields._paramValue_k__BackingField;
			//   ssrV2Upsample_k__BackingField = settingParameters.fields._ssrV2Upsample_k__BackingField;
			//   v437 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !ssrV2Upsample_k__BackingField )
			//     goto LABEL_1747;
			//   v438 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v438.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v438.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v439 = v437.klass;
			//     if ( ((__int64)v439.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v437.klass);
			//     (*(void (**)(void))v439.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v437.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   TempFromCSharp[434] = (Void)ssrV2Upsample_k__BackingField.fields._paramValue_k__BackingField;
			//   terrainFallbackGBuffer_k__BackingField = settingParameters.fields._terrainFallbackGBuffer_k__BackingField;
			//   v441 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !terrainFallbackGBuffer_k__BackingField )
			//     goto LABEL_1747;
			//   v442 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v442.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v442.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v443 = v441.klass;
			//     if ( ((__int64)v443.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v441.klass);
			//     (*(void (**)(void))v443.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v441.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   TempFromCSharp[435] = (Void)terrainFallbackGBuffer_k__BackingField.fields._paramValue_k__BackingField;
			//   terrainLODFactor_k__BackingField = settingParameters.fields._terrainLODFactor_k__BackingField;
			//   v445 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !terrainLODFactor_k__BackingField )
			//     goto LABEL_1747;
			//   v446 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v446.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v446.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v447 = v445.klass;
			//     if ( ((__int64)v447.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v445.klass);
			//     (*(void (**)(void))v447.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v445.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(_DWORD *)&TempFromCSharp[436] = terrainLODFactor_k__BackingField.fields._paramValue_k__BackingField;
			//   terrainDeform_k__BackingField = settingParameters.fields._terrainDeform_k__BackingField;
			//   if ( !terrainDeform_k__BackingField )
			//     goto LABEL_1747;
			//   Enable_k__BackingField = terrainDeform_k__BackingField.fields._Enable_k__BackingField;
			//   v450 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !Enable_k__BackingField )
			//     goto LABEL_1747;
			//   v451 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v451.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v451.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v452 = v450.klass;
			//     if ( ((__int64)v452.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v450.klass);
			//     (*(void (**)(void))v452.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v450.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   TempFromCSharp[440] = (Void)Enable_k__BackingField.fields._paramValue_k__BackingField;
			//   v453 = settingParameters.fields._terrainDeform_k__BackingField;
			//   if ( !v453 )
			//     goto LABEL_1747;
			//   SubdMode_k__BackingField = v453.fields._SubdMode_k__BackingField;
			//   v455 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !SubdMode_k__BackingField )
			//     goto LABEL_1747;
			//   v456 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v456.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v456.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v457 = v455.klass;
			//     if ( ((__int64)v457.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v455.klass);
			//     (*(void (**)(void))v457.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v455.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(_DWORD *)&TempFromCSharp[444] = SubdMode_k__BackingField.fields._paramValue_k__BackingField;
			//   v458 = settingParameters.fields._terrainDeform_k__BackingField;
			//   if ( !v458 )
			//     goto LABEL_1747;
			//   SubdModeV2_k__BackingField = v458.fields._SubdModeV2_k__BackingField;
			//   v460 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !SubdModeV2_k__BackingField )
			//     goto LABEL_1747;
			//   v461 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v461.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v461.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v462 = v460.klass;
			//     if ( ((__int64)v462.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v460.klass);
			//     (*(void (**)(void))v462.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v460.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(_DWORD *)&TempFromCSharp[448] = SubdModeV2_k__BackingField.fields._paramValue_k__BackingField;
			//   v463 = settingParameters.fields._terrainDeform_k__BackingField;
			//   if ( !v463 )
			//     goto LABEL_1747;
			//   GpuSubd_k__BackingField = v463.fields._GpuSubd_k__BackingField;
			//   v465 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !GpuSubd_k__BackingField )
			//     goto LABEL_1747;
			//   v466 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v466.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v466.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v467 = v465.klass;
			//     if ( ((__int64)v467.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v465.klass);
			//     (*(void (**)(void))v467.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v465.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(_DWORD *)&TempFromCSharp[452] = GpuSubd_k__BackingField.fields._paramValue_k__BackingField;
			//   v468 = settingParameters.fields._terrainDeform_k__BackingField;
			//   if ( !v468 )
			//     goto LABEL_1747;
			//   PrimitivePixelLengthTargetLog2_k__BackingField = v468.fields._PrimitivePixelLengthTargetLog2_k__BackingField;
			//   v470 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !PrimitivePixelLengthTargetLog2_k__BackingField )
			//     goto LABEL_1747;
			//   v471 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v471.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v471.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v472 = v470.klass;
			//     if ( ((__int64)v472.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v470.klass);
			//     (*(void (**)(void))v472.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v470.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(_DWORD *)&TempFromCSharp[456] = PrimitivePixelLengthTargetLog2_k__BackingField.fields._paramValue_k__BackingField;
			//   erosionBlend_k__BackingField = settingParameters.fields._erosionBlend_k__BackingField;
			//   if ( !erosionBlend_k__BackingField )
			//     goto LABEL_1747;
			//   v474 = erosionBlend_k__BackingField.fields._Enable_k__BackingField;
			//   v475 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !v474 )
			//     goto LABEL_1747;
			//   v476 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v476.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v476.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v477 = v475.klass;
			//     if ( ((__int64)v477.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v475.klass);
			//     (*(void (**)(void))v477.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v475.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   TempFromCSharp[460] = (Void)v474.fields._paramValue_k__BackingField;
			//   lightShaft_k__BackingField = settingParameters.fields._lightShaft_k__BackingField;
			//   if ( !lightShaft_k__BackingField )
			//     goto LABEL_1747;
			//   enableLightShaft = lightShaft_k__BackingField.fields.enableLightShaft;
			//   v480 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !enableLightShaft )
			//     goto LABEL_1747;
			//   v481 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v481.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v481.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v482 = v480.klass;
			//     if ( ((__int64)v482.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v480.klass);
			//     (*(void (**)(void))v482.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v480.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   TempFromCSharp[461] = (Void)enableLightShaft.fields._paramValue_k__BackingField;
			//   v483 = settingParameters.fields._lightShaft_k__BackingField;
			//   if ( !v483 )
			//     goto LABEL_1747;
			//   lightShaftSampleNum = v483.fields.lightShaftSampleNum;
			//   v485 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !lightShaftSampleNum )
			//     goto LABEL_1747;
			//   v486 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v486.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v486.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v487 = v485.klass;
			//     if ( ((__int64)v487.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v485.klass);
			//     (*(void (**)(void))v487.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v485.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(_DWORD *)&TempFromCSharp[464] = lightShaftSampleNum.fields._paramValue_k__BackingField;
			//   v488 = settingParameters.fields._lightShaft_k__BackingField;
			//   if ( !v488 )
			//     goto LABEL_1747;
			//   lightShaftDownSampleFactor = v488.fields.lightShaftDownSampleFactor;
			//   v490 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !lightShaftDownSampleFactor )
			//     goto LABEL_1747;
			//   v491 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v491.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v491.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v492 = v490.klass;
			//     if ( ((__int64)v492.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v490.klass);
			//     (*(void (**)(void))v492.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v490.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[468] = lightShaftDownSampleFactor.fields._paramValue_k__BackingField;
			//   v493 = settingParameters.fields._lightShaft_k__BackingField;
			//   if ( !v493 )
			//     goto LABEL_1747;
			//   lightShaftBlurPassCount = v493.fields.lightShaftBlurPassCount;
			//   v495 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !lightShaftBlurPassCount )
			//     goto LABEL_1747;
			//   v496 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v496.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v496.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v497 = v495.klass;
			//     if ( ((__int64)v497.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v495.klass);
			//     (*(void (**)(void))v497.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v495.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(_DWORD *)&TempFromCSharp[472] = lightShaftBlurPassCount.fields._paramValue_k__BackingField;
			//   enableAnamorphicStreaks_k__BackingField = settingParameters.fields._enableAnamorphicStreaks_k__BackingField;
			//   v499 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !enableAnamorphicStreaks_k__BackingField )
			//     goto LABEL_1747;
			//   v500 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v500.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v500.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v501 = v499.klass;
			//     if ( ((__int64)v501.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v499.klass);
			//     (*(void (**)(void))v501.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v499.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   TempFromCSharp[476] = (Void)enableAnamorphicStreaks_k__BackingField.fields._paramValue_k__BackingField;
			//   anamorphicStreaksDownSampleFactor_k__BackingField = settingParameters.fields._anamorphicStreaksDownSampleFactor_k__BackingField;
			//   v503 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !anamorphicStreaksDownSampleFactor_k__BackingField )
			//     goto LABEL_1747;
			//   v504 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v504.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v504.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v505 = v503.klass;
			//     if ( ((__int64)v505.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v503.klass);
			//     (*(void (**)(void))v505.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v503.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[480] = anamorphicStreaksDownSampleFactor_k__BackingField.fields._paramValue_k__BackingField;
			//   TempFromCSharp[484] = (Void)1;
			//   rainAndWetness_k__BackingField = settingParameters.fields._rainAndWetness_k__BackingField;
			//   if ( !rainAndWetness_k__BackingField )
			//     goto LABEL_1747;
			//   EnableRainWetnessHighQuality_k__BackingField = rainAndWetness_k__BackingField.fields._EnableRainWetnessHighQuality_k__BackingField;
			//   v508 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !EnableRainWetnessHighQuality_k__BackingField )
			//     goto LABEL_1747;
			//   v509 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v509.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v509.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v510 = v508.klass;
			//     if ( ((__int64)v510.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v508.klass);
			//     (*(void (**)(void))v510.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v508.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   TempFromCSharp[485] = (Void)EnableRainWetnessHighQuality_k__BackingField.fields._paramValue_k__BackingField;
			//   v511 = settingParameters.fields._rainAndWetness_k__BackingField;
			//   if ( !v511 )
			//     goto LABEL_1747;
			//   RainOcclusionMapSize_k__BackingField = v511.fields._RainOcclusionMapSize_k__BackingField;
			//   v513 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !RainOcclusionMapSize_k__BackingField )
			//     goto LABEL_1747;
			//   v514 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v514.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v514.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v515 = v513.klass;
			//     if ( ((__int64)v515.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v513.klass);
			//     (*(void (**)(void))v515.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v513.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(_DWORD *)&TempFromCSharp[488] = RainOcclusionMapSize_k__BackingField.fields._paramValue_k__BackingField;
			//   v516 = settingParameters.fields._rainAndWetness_k__BackingField;
			//   if ( !v516 )
			//     goto LABEL_1747;
			//   RainOcclusionMapOverrideRange_k__BackingField = v516.fields._RainOcclusionMapOverrideRange_k__BackingField;
			//   v518 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !RainOcclusionMapOverrideRange_k__BackingField )
			//     goto LABEL_1747;
			//   v519 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v519.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v519.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v520 = v518.klass;
			//     if ( ((__int64)v520.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v518.klass);
			//     (*(void (**)(void))v520.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v518.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(_DWORD *)&TempFromCSharp[492] = RainOcclusionMapOverrideRange_k__BackingField.fields._paramValue_k__BackingField;
			//   v521 = settingParameters.fields._rainAndWetness_k__BackingField;
			//   if ( !v521 )
			//     goto LABEL_1747;
			//   RainSplashEnabled_k__BackingField = v521.fields._RainSplashEnabled_k__BackingField;
			//   v523 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !RainSplashEnabled_k__BackingField )
			//     goto LABEL_1747;
			//   v524 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v524.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v524.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v525 = v523.klass;
			//     if ( ((__int64)v525.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v523.klass);
			//     (*(void (**)(void))v525.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v523.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   TempFromCSharp[496] = (Void)RainSplashEnabled_k__BackingField.fields._paramValue_k__BackingField;
			//   v526 = settingParameters.fields._rainAndWetness_k__BackingField;
			//   if ( !v526 )
			//     goto LABEL_1747;
			//   RainSplashMaxCount_k__BackingField = v526.fields._RainSplashMaxCount_k__BackingField;
			//   v528 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !RainSplashMaxCount_k__BackingField )
			//     goto LABEL_1747;
			//   v529 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v529.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v529.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v530 = v528.klass;
			//     if ( ((__int64)v530.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v528.klass);
			//     (*(void (**)(void))v530.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v528.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(_DWORD *)&TempFromCSharp[500] = RainSplashMaxCount_k__BackingField.fields._paramValue_k__BackingField;
			//   v531 = settingParameters.fields._rainAndWetness_k__BackingField;
			//   if ( !v531 )
			//     goto LABEL_1747;
			//   ScreenRainDropPercent_k__BackingField = v531.fields._ScreenRainDropPercent_k__BackingField;
			//   v533 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !ScreenRainDropPercent_k__BackingField )
			//     goto LABEL_1747;
			//   v534 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v534.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v534.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v535 = v533.klass;
			//     if ( ((__int64)v535.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v533.klass);
			//     (*(void (**)(void))v535.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v533.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[504] = ScreenRainDropPercent_k__BackingField.fields._paramValue_k__BackingField;
			//   v536 = settingParameters.fields._rainAndWetness_k__BackingField;
			//   if ( !v536 )
			//     goto LABEL_1747;
			//   EnableMiddleDistRain_k__BackingField = v536.fields._EnableMiddleDistRain_k__BackingField;
			//   v538 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !EnableMiddleDistRain_k__BackingField )
			//     goto LABEL_1747;
			//   v539 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v539.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v539.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v540 = v538.klass;
			//     if ( ((__int64)v540.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v538.klass);
			//     (*(void (**)(void))v540.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v538.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   TempFromCSharp[508] = (Void)EnableMiddleDistRain_k__BackingField.fields._paramValue_k__BackingField;
			//   v541 = settingParameters.fields._rainAndWetness_k__BackingField;
			//   if ( !v541 )
			//     goto LABEL_1747;
			//   EnableRainWave_k__BackingField = v541.fields._EnableRainWave_k__BackingField;
			//   v543 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !EnableRainWave_k__BackingField )
			//     goto LABEL_1747;
			//   v544 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v544.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v544.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v545 = v543.klass;
			//     if ( ((__int64)v545.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v543.klass);
			//     (*(void (**)(void))v545.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v543.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   TempFromCSharp[509] = (Void)EnableRainWave_k__BackingField.fields._paramValue_k__BackingField;
			//   verticalOcclusionMap_k__BackingField = settingParameters.fields._verticalOcclusionMap_k__BackingField;
			//   if ( !verticalOcclusionMap_k__BackingField )
			//     goto LABEL_1747;
			//   DepthOcclusionMapSize_k__BackingField = verticalOcclusionMap_k__BackingField.fields._DepthOcclusionMapSize_k__BackingField;
			//   v548 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !DepthOcclusionMapSize_k__BackingField )
			//     goto LABEL_1747;
			//   v549 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v549.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v549.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v550 = v548.klass;
			//     if ( ((__int64)v550.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v548.klass);
			//     (*(void (**)(void))v550.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v548.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(_DWORD *)&TempFromCSharp[512] = DepthOcclusionMapSize_k__BackingField.fields._paramValue_k__BackingField;
			//   v551 = settingParameters.fields._verticalOcclusionMap_k__BackingField;
			//   if ( !v551 )
			//     goto LABEL_1747;
			//   DepthOcclusionMapRange_k__BackingField = v551.fields._DepthOcclusionMapRange_k__BackingField;
			//   v553 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !DepthOcclusionMapRange_k__BackingField )
			//     goto LABEL_1747;
			//   v554 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v554.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v554.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v555 = v553.klass;
			//     if ( ((__int64)v555.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v553.klass);
			//     (*(void (**)(void))v555.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v553.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(_DWORD *)&TempFromCSharp[516] = DepthOcclusionMapRange_k__BackingField.fields._paramValue_k__BackingField;
			//   atmosphereParams_k__BackingField = settingParameters.fields._atmosphereParams_k__BackingField;
			//   if ( !atmosphereParams_k__BackingField )
			//     goto LABEL_1747;
			//   transmittanceLutSampleCount = atmosphereParams_k__BackingField.fields.transmittanceLutSampleCount;
			//   v558 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !transmittanceLutSampleCount )
			//     goto LABEL_1747;
			//   v559 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v559.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v559.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v560 = v558.klass;
			//     if ( ((__int64)v560.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v558.klass);
			//     (*(void (**)(void))v560.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v558.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[520] = transmittanceLutSampleCount.fields._paramValue_k__BackingField;
			//   v561 = settingParameters.fields._atmosphereParams_k__BackingField;
			//   if ( !v561 )
			//     goto LABEL_1747;
			//   transmittanceLutWidth = v561.fields.transmittanceLutWidth;
			//   v563 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !transmittanceLutWidth )
			//     goto LABEL_1747;
			//   v564 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v564.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v564.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v565 = v563.klass;
			//     if ( ((__int64)v565.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v563.klass);
			//     (*(void (**)(void))v565.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v563.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(_DWORD *)&TempFromCSharp[524] = transmittanceLutWidth.fields._paramValue_k__BackingField;
			//   v566 = settingParameters.fields._atmosphereParams_k__BackingField;
			//   if ( !v566 )
			//     goto LABEL_1747;
			//   transmittanceLutHeight = v566.fields.transmittanceLutHeight;
			//   v568 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !transmittanceLutHeight )
			//     goto LABEL_1747;
			//   v569 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v569.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v569.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v570 = v568.klass;
			//     if ( ((__int64)v570.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v568.klass);
			//     (*(void (**)(void))v570.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v568.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(_DWORD *)&TempFromCSharp[528] = transmittanceLutHeight.fields._paramValue_k__BackingField;
			//   v571 = settingParameters.fields._atmosphereParams_k__BackingField;
			//   if ( !v571 )
			//     goto LABEL_1747;
			//   multiScatteredLuminanceLutSampleCount = v571.fields.multiScatteredLuminanceLutSampleCount;
			//   v573 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !multiScatteredLuminanceLutSampleCount )
			//     goto LABEL_1747;
			//   v574 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v574.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v574.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v575 = v573.klass;
			//     if ( ((__int64)v575.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v573.klass);
			//     (*(void (**)(void))v575.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v573.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[532] = multiScatteredLuminanceLutSampleCount.fields._paramValue_k__BackingField;
			//   v576 = settingParameters.fields._atmosphereParams_k__BackingField;
			//   if ( !v576 )
			//     goto LABEL_1747;
			//   multiScatteredLuminanceLutHighQuality = v576.fields.multiScatteredLuminanceLutHighQuality;
			//   v578 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !multiScatteredLuminanceLutHighQuality )
			//     goto LABEL_1747;
			//   v579 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v579.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v579.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v580 = v578.klass;
			//     if ( ((__int64)v580.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v578.klass);
			//     (*(void (**)(void))v580.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v578.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   TempFromCSharp[536] = (Void)multiScatteredLuminanceLutHighQuality.fields._paramValue_k__BackingField;
			//   v581 = settingParameters.fields._atmosphereParams_k__BackingField;
			//   if ( !v581 )
			//     goto LABEL_1747;
			//   multiScatteredLuminanceLutWidth = v581.fields.multiScatteredLuminanceLutWidth;
			//   v583 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !multiScatteredLuminanceLutWidth )
			//     goto LABEL_1747;
			//   v584 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v584.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v584.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v585 = v583.klass;
			//     if ( ((__int64)v585.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v583.klass);
			//     (*(void (**)(void))v585.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v583.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(_DWORD *)&TempFromCSharp[540] = multiScatteredLuminanceLutWidth.fields._paramValue_k__BackingField;
			//   v586 = settingParameters.fields._atmosphereParams_k__BackingField;
			//   if ( !v586 )
			//     goto LABEL_1747;
			//   multiScatteredLuminanceLutHeight = v586.fields.multiScatteredLuminanceLutHeight;
			//   v588 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !multiScatteredLuminanceLutHeight )
			//     goto LABEL_1747;
			//   v589 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v589.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v589.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v590 = v588.klass;
			//     if ( ((__int64)v590.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v588.klass);
			//     (*(void (**)(void))v590.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v588.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(_DWORD *)&TempFromCSharp[544] = multiScatteredLuminanceLutHeight.fields._paramValue_k__BackingField;
			//   v591 = settingParameters.fields._atmosphereParams_k__BackingField;
			//   if ( !v591 )
			//     goto LABEL_1747;
			//   skyViewLutSampleCountMin = v591.fields.skyViewLutSampleCountMin;
			//   v593 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !skyViewLutSampleCountMin )
			//     goto LABEL_1747;
			//   v594 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v594.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v594.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v595 = v593.klass;
			//     if ( ((__int64)v595.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v593.klass);
			//     (*(void (**)(void))v595.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v593.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[548] = skyViewLutSampleCountMin.fields._paramValue_k__BackingField;
			//   v596 = settingParameters.fields._atmosphereParams_k__BackingField;
			//   if ( !v596 )
			//     goto LABEL_1747;
			//   skyViewLutSampleCountMax = v596.fields.skyViewLutSampleCountMax;
			//   v598 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !skyViewLutSampleCountMax )
			//     goto LABEL_1747;
			//   v599 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v599.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v599.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v600 = v598.klass;
			//     if ( ((__int64)v600.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v598.klass);
			//     (*(void (**)(void))v600.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v598.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[552] = skyViewLutSampleCountMax.fields._paramValue_k__BackingField;
			//   v601 = settingParameters.fields._atmosphereParams_k__BackingField;
			//   if ( !v601 )
			//     goto LABEL_1747;
			//   skyViewLutDistanceToSampleCountMax = v601.fields.skyViewLutDistanceToSampleCountMax;
			//   v603 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !skyViewLutDistanceToSampleCountMax )
			//     goto LABEL_1747;
			//   v604 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v604.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v604.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v605 = v603.klass;
			//     if ( ((__int64)v605.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v603.klass);
			//     (*(void (**)(void))v605.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   v606 = v603.klass;
			//   if ( ((__int64)v606.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(v606);
			//   *(float *)&TempFromCSharp[556] = skyViewLutDistanceToSampleCountMax.fields._paramValue_k__BackingField;
			//   s_settingParameters = (unsigned __int64)settingParameters.fields._atmosphereParams_k__BackingField;
			//   if ( !s_settingParameters )
			//     goto LABEL_1747;
			//   *(_DWORD *)&TempFromCSharp[560] = sub_180316550(*(_QWORD *)(s_settingParameters + 96), v4);
			//   v609 = settingParameters.fields._atmosphereParams_k__BackingField;
			//   if ( !v609 )
			//     goto LABEL_1747;
			//   skyViewLutHeight = v609.fields.skyViewLutHeight;
			//   v611 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !skyViewLutHeight )
			//     goto LABEL_1747;
			//   v612 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v612.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v612.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v613 = v611.klass;
			//     if ( ((__int64)v613.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v611.klass);
			//     (*(void (**)(void))v613.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v611.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(_DWORD *)&TempFromCSharp[564] = skyViewLutHeight.fields._paramValue_k__BackingField;
			//   TempFromCSharp[568] = (Void)1;
			//   waterPrepassTextureSize_k__BackingField = settingParameters.fields._waterPrepassTextureSize_k__BackingField;
			//   v615 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !waterPrepassTextureSize_k__BackingField )
			//     goto LABEL_1747;
			//   v616 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v616.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v616.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v617 = v615.klass;
			//     if ( ((__int64)v617.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v615.klass);
			//     (*(void (**)(void))v617.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v615.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[572] = waterPrepassTextureSize_k__BackingField.fields._paramValue_k__BackingField;
			//   waterInteractiveEnable_k__BackingField = settingParameters.fields._waterInteractiveEnable_k__BackingField;
			//   v619 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !waterInteractiveEnable_k__BackingField )
			//     goto LABEL_1747;
			//   v620 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v620.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v620.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v621 = sub_18010B520(v619.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v621 + 192) + 48LL))();
			//   }
			//   s_settingParameters = (unsigned __int64)v619.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   TempFromCSharp[576] = (Void)waterInteractiveEnable_k__BackingField.fields._paramValue_k__BackingField;
			//   waterIndirectEnable_k__BackingField = settingParameters.fields._waterIndirectEnable_k__BackingField;
			//   v623 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !waterIndirectEnable_k__BackingField )
			//     goto LABEL_1747;
			//   v624 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v624.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v624.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v625 = sub_18010B520(v623.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v625 + 192) + 48LL))();
			//   }
			//   s_settingParameters = (unsigned __int64)v623.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   TempFromCSharp[577] = (Void)waterIndirectEnable_k__BackingField.fields._paramValue_k__BackingField;
			//   waterVRRx_k__BackingField = settingParameters.fields._waterVRRx_k__BackingField;
			//   v627 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !waterVRRx_k__BackingField )
			//     goto LABEL_1747;
			//   v628 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v628.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v628.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v629 = sub_18010B520(v627.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v629 + 192) + 48LL))();
			//   }
			//   s_settingParameters = (unsigned __int64)v627.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(_DWORD *)&TempFromCSharp[580] = waterVRRx_k__BackingField.fields._paramValue_k__BackingField;
			//   waterVRRy_k__BackingField = settingParameters.fields._waterVRRy_k__BackingField;
			//   v631 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !waterVRRy_k__BackingField )
			//     goto LABEL_1747;
			//   v632 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v632.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v632.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v633 = sub_18010B520(v631.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v633 + 192) + 48LL))();
			//   }
			//   s_settingParameters = (unsigned __int64)v631.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(_DWORD *)&TempFromCSharp[584] = waterVRRy_k__BackingField.fields._paramValue_k__BackingField;
			//   waterDisplacementWeight_k__BackingField = settingParameters.fields._waterDisplacementWeight_k__BackingField;
			//   v635 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !waterDisplacementWeight_k__BackingField )
			//     goto LABEL_1747;
			//   v636 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v636.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v636.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v637 = sub_18010B520(v635.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v637 + 192) + 48LL))();
			//   }
			//   s_settingParameters = (unsigned __int64)v635.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[588] = waterDisplacementWeight_k__BackingField.fields._paramValue_k__BackingField;
			//   waterDisplacementDistance_k__BackingField = settingParameters.fields._waterDisplacementDistance_k__BackingField;
			//   v639 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !waterDisplacementDistance_k__BackingField )
			//     goto LABEL_1747;
			//   v640 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v640.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v640.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v641 = sub_18010B520(v639.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v641 + 192) + 48LL))();
			//   }
			//   s_settingParameters = (unsigned __int64)v639.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[592] = waterDisplacementDistance_k__BackingField.fields._paramValue_k__BackingField;
			//   waterHeightTextureSize_k__BackingField = settingParameters.fields._waterHeightTextureSize_k__BackingField;
			//   v643 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !waterHeightTextureSize_k__BackingField )
			//     goto LABEL_1747;
			//   v644 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v644.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v644.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v645 = sub_18010B520(v643.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v645 + 192) + 48LL))();
			//   }
			//   s_settingParameters = (unsigned __int64)v643.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(_DWORD *)&TempFromCSharp[596] = waterHeightTextureSize_k__BackingField.fields._paramValue_k__BackingField;
			//   artTagLODBiasAll_k__BackingField = settingParameters.fields._artTagLODBiasAll_k__BackingField;
			//   v647 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !artTagLODBiasAll_k__BackingField )
			//     goto LABEL_1747;
			//   v648 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v648.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v648.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v649 = sub_18010B520(v647.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v649 + 192) + 48LL))();
			//   }
			//   v650 = v647.klass;
			//   if ( ((__int64)v650.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(v650);
			//   v651 = 0;
			//   *(float *)&TempFromCSharp[600] = artTagLODBiasAll_k__BackingField.fields._paramValue_k__BackingField;
			//   while ( 1 )
			//   {
			//     s_settingParameters = v651;
			//     artTagLODBias_k__BackingField = settingParameters.fields._artTagLODBias_k__BackingField;
			//     if ( !artTagLODBias_k__BackingField )
			//       goto LABEL_1747;
			//     if ( (signed int)v651 >= artTagLODBias_k__BackingField.fields._size )
			//       break;
			//     if ( v651 >= artTagLODBias_k__BackingField.fields._size )
			//       System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
			//     items = artTagLODBias_k__BackingField.fields._items;
			//     if ( !items )
			//       goto LABEL_1747;
			//     if ( v651 >= items.max_length.size )
			//       sub_180070260(v651, v4, v607, v608);
			//     v654 = items.vector[v651];
			//     v655 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//     if ( !v654 )
			//       goto LABEL_1747;
			//     v656 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//     if ( ((__int64)v656.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//     if ( !*((_QWORD *)v656.rgctx_data[6].rgctxDataDummy + 4) )
			//     {
			//       v657 = v655.klass;
			//       if ( ((__int64)v657.vtable[0].methodPtr & 1) == 0 )
			//         sub_18003C700(v655.klass);
			//       (*(void (**)(void))v657.rgctx_data[6].rgctxDataDummy)();
			//     }
			//     v658 = v655.klass;
			//     if ( ((__int64)v658.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v658);
			//     v659 = (int)v651++;
			//     *(float *)&TempFromCSharp[4 * v659 + 604] = v654.fields._paramValue_k__BackingField;
			//   }
			//   shouldSplitOnePass_k__BackingField = settingParameters.fields._shouldSplitOnePass_k__BackingField;
			//   v661 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !shouldSplitOnePass_k__BackingField )
			//     goto LABEL_1747;
			//   v662 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v662.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v662.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v663 = v661.klass;
			//     if ( ((__int64)v663.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v661.klass);
			//     (*(void (**)(void))v663.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   v664 = v661.klass;
			//   if ( ((__int64)v664.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(v664);
			//   TempFromCSharp[860] = (Void)shouldSplitOnePass_k__BackingField.fields._paramValue_k__BackingField;
			//   v665 = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer, v4);
			//     v665 = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer;
			//   }
			//   s_settingParameters = (unsigned __int64)v665.static_fields.s_settingParameters;
			//   if ( !s_settingParameters )
			//     goto LABEL_1747;
			//   v666 = *(Void **)(s_settingParameters + 16);
			//   v667 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !v666 )
			//     goto LABEL_1747;
			//   v668 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v668.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v668.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v669 = v667.klass;
			//     if ( ((__int64)v669.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v667.klass);
			//     (*(void (**)(void))v669.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   v670 = v667.klass;
			//   if ( ((__int64)v670.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(v670);
			//   TempFromCSharp[864] = v666[40];
			//   s_settingParameters = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer.static_fields;
			//   if ( !*(_QWORD *)s_settingParameters )
			//     goto LABEL_1747;
			//   v671 = *(_QWORD *)(*(_QWORD *)s_settingParameters + 24LL);
			//   v672 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !v671 )
			//     goto LABEL_1747;
			//   v673 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v673.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v673.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v674 = v672.klass;
			//     if ( ((__int64)v674.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v672.klass);
			//     (*(void (**)(void))v674.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   v675 = v672.klass;
			//   if ( ((__int64)v675.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(v675);
			//   *(_DWORD *)&TempFromCSharp[868] = *(_DWORD *)(v671 + 40);
			//   s_settingParameters = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer.static_fields;
			//   if ( !*(_QWORD *)s_settingParameters )
			//     goto LABEL_1747;
			//   v676 = *(_QWORD *)(*(_QWORD *)s_settingParameters + 32LL);
			//   v677 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !v676 )
			//     goto LABEL_1747;
			//   v678 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v678.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v678.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v679 = v677.klass;
			//     if ( ((__int64)v679.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v677.klass);
			//     (*(void (**)(void))v679.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   v680 = v677.klass;
			//   if ( ((__int64)v680.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(v680);
			//   *(_DWORD *)&TempFromCSharp[872] = *(_DWORD *)(v676 + 40);
			//   s_settingParameters = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer.static_fields;
			//   if ( !*(_QWORD *)s_settingParameters )
			//     goto LABEL_1747;
			//   v681 = *(_QWORD *)(*(_QWORD *)s_settingParameters + 40LL);
			//   v682 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !v681 )
			//     goto LABEL_1747;
			//   v683 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v683.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v683.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v684 = v682.klass;
			//     if ( ((__int64)v684.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v682.klass);
			//     (*(void (**)(void))v684.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   v685 = v682.klass;
			//   if ( ((__int64)v685.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(v685);
			//   *(_DWORD *)&TempFromCSharp[876] = *(_DWORD *)(v681 + 40);
			//   s_settingParameters = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer.static_fields;
			//   if ( !*(_QWORD *)s_settingParameters )
			//     goto LABEL_1747;
			//   v686 = *(_QWORD *)(*(_QWORD *)s_settingParameters + 48LL);
			//   v687 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !v686 )
			//     goto LABEL_1747;
			//   v688 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v688.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v688.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v689 = v687.klass;
			//     if ( ((__int64)v689.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v687.klass);
			//     (*(void (**)(void))v689.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   v690 = v687.klass;
			//   if ( ((__int64)v690.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(v690);
			//   *(_DWORD *)&TempFromCSharp[880] = *(_DWORD *)(v686 + 40);
			//   s_settingParameters = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer.static_fields;
			//   if ( !*(_QWORD *)s_settingParameters )
			//     goto LABEL_1747;
			//   v691 = *(_QWORD *)(*(_QWORD *)s_settingParameters + 56LL);
			//   v692 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !v691 )
			//     goto LABEL_1747;
			//   v693 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v693.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v693.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v694 = v692.klass;
			//     if ( ((__int64)v694.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v692.klass);
			//     (*(void (**)(void))v694.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   v695 = v692.klass;
			//   if ( ((__int64)v695.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(v695);
			//   *(_DWORD *)&TempFromCSharp[884] = *(_DWORD *)(v691 + 40);
			//   s_settingParameters = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer.static_fields;
			//   if ( !*(_QWORD *)s_settingParameters )
			//     goto LABEL_1747;
			//   v696 = *(_QWORD *)(*(_QWORD *)s_settingParameters + 64LL);
			//   v697 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !v696 )
			//     goto LABEL_1747;
			//   v698 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v698.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v698.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v699 = v697.klass;
			//     if ( ((__int64)v699.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v697.klass);
			//     (*(void (**)(void))v699.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   v700 = v697.klass;
			//   if ( ((__int64)v700.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(v700);
			//   *(_DWORD *)&TempFromCSharp[888] = *(_DWORD *)(v696 + 40);
			//   s_settingParameters = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer.static_fields;
			//   if ( !*(_QWORD *)s_settingParameters )
			//     goto LABEL_1747;
			//   v701 = *(_QWORD *)(*(_QWORD *)s_settingParameters + 72LL);
			//   v702 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !v701 )
			//     goto LABEL_1747;
			//   v703 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v703.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v703.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v704 = v702.klass;
			//     if ( ((__int64)v704.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v702.klass);
			//     (*(void (**)(void))v704.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   v705 = v702.klass;
			//   if ( ((__int64)v705.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(v705);
			//   *(_DWORD *)&TempFromCSharp[892] = *(_DWORD *)(v701 + 40);
			//   s_settingParameters = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer.static_fields;
			//   if ( !*(_QWORD *)s_settingParameters )
			//     goto LABEL_1747;
			//   v706 = *(_QWORD *)(*(_QWORD *)s_settingParameters + 80LL);
			//   v707 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !v706 )
			//     goto LABEL_1747;
			//   v708 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v708.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v708.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v709 = v707.klass;
			//     if ( ((__int64)v709.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v707.klass);
			//     (*(void (**)(void))v709.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   v710 = v707.klass;
			//   if ( ((__int64)v710.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(v710);
			//   *(_DWORD *)&TempFromCSharp[896] = *(_DWORD *)(v706 + 40);
			//   s_settingParameters = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer.static_fields;
			//   if ( !*(_QWORD *)s_settingParameters )
			//     goto LABEL_1747;
			//   v711 = *(_QWORD *)(*(_QWORD *)s_settingParameters + 88LL);
			//   v712 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !v711 )
			//     goto LABEL_1747;
			//   v713 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v713.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v713.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v714 = v712.klass;
			//     if ( ((__int64)v714.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v712.klass);
			//     (*(void (**)(void))v714.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   v715 = v712.klass;
			//   if ( ((__int64)v715.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(v715);
			//   *(_DWORD *)&TempFromCSharp[900] = *(_DWORD *)(v711 + 40);
			//   s_settingParameters = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer.static_fields;
			//   if ( !*(_QWORD *)s_settingParameters )
			//     goto LABEL_1747;
			//   v716 = *(Void **)(*(_QWORD *)s_settingParameters + 96LL);
			//   v717 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !v716 )
			//     goto LABEL_1747;
			//   v718 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v718.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v718.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v719 = v717.klass;
			//     if ( ((__int64)v719.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v717.klass);
			//     (*(void (**)(void))v719.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   v720 = v717.klass;
			//   if ( ((__int64)v720.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(v720);
			//   TempFromCSharp[904] = v716[40];
			//   s_settingParameters = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer.static_fields;
			//   if ( !*(_QWORD *)s_settingParameters )
			//     goto LABEL_1747;
			//   v721 = *(Void **)(*(_QWORD *)s_settingParameters + 104LL);
			//   v722 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !v721 )
			//     goto LABEL_1747;
			//   v723 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v723.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v723.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v724 = v722.klass;
			//     if ( ((__int64)v724.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v722.klass);
			//     (*(void (**)(void))v724.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   v725 = v722.klass;
			//   if ( ((__int64)v725.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(v725);
			//   TempFromCSharp[905] = v721[40];
			//   s_settingParameters = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer.static_fields;
			//   if ( !*(_QWORD *)s_settingParameters )
			//     goto LABEL_1747;
			//   v726 = *(Void **)(*(_QWORD *)s_settingParameters + 112LL);
			//   v727 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !v726 )
			//     goto LABEL_1747;
			//   v728 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v728.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v728.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v729 = v727.klass;
			//     if ( ((__int64)v729.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v727.klass);
			//     (*(void (**)(void))v729.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   v730 = v727.klass;
			//   if ( ((__int64)v730.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(v730);
			//   TempFromCSharp[906] = v726[40];
			//   s_settingParameters = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer.static_fields;
			//   if ( !*(_QWORD *)s_settingParameters )
			//     goto LABEL_1747;
			//   v731 = *(Void **)(*(_QWORD *)s_settingParameters + 120LL);
			//   v732 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !v731 )
			//     goto LABEL_1747;
			//   v733 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v733.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v733.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v734 = v732.klass;
			//     if ( ((__int64)v734.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v732.klass);
			//     (*(void (**)(void))v734.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v732.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   TempFromCSharp[907] = v731[40];
			//   reflectionProbeUseRGBAHalf_k__BackingField = settingParameters.fields._reflectionProbeUseRGBAHalf_k__BackingField;
			//   v736 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !reflectionProbeUseRGBAHalf_k__BackingField )
			//     goto LABEL_1747;
			//   v737 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v737.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v737.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v738 = v736.klass;
			//     if ( ((__int64)v738.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v736.klass);
			//     (*(void (**)(void))v738.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v736.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   TempFromCSharp[908] = (Void)reflectionProbeUseRGBAHalf_k__BackingField.fields._paramValue_k__BackingField;
			//   reflectionProbeOctTextureSize_k__BackingField = settingParameters.fields._reflectionProbeOctTextureSize_k__BackingField;
			//   v740 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !reflectionProbeOctTextureSize_k__BackingField )
			//     goto LABEL_1747;
			//   v741 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v741.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v741.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v742 = v740.klass;
			//     if ( ((__int64)v742.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v740.klass);
			//     (*(void (**)(void))v742.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v740.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(_DWORD *)&TempFromCSharp[912] = reflectionProbeOctTextureSize_k__BackingField.fields._paramValue_k__BackingField;
			//   reflectionProbeMaxSampleMip_k__BackingField = settingParameters.fields._reflectionProbeMaxSampleMip_k__BackingField;
			//   v744 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !reflectionProbeMaxSampleMip_k__BackingField )
			//     goto LABEL_1747;
			//   v745 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v745.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v745.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v746 = v744.klass;
			//     if ( ((__int64)v746.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v744.klass);
			//     (*(void (**)(void))v746.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v744.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(_DWORD *)&TempFromCSharp[916] = reflectionProbeMaxSampleMip_k__BackingField.fields._paramValue_k__BackingField;
			//   reflectionProbeMaxBlitCountPerFrame_k__BackingField = settingParameters.fields._reflectionProbeMaxBlitCountPerFrame_k__BackingField;
			//   v748 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !reflectionProbeMaxBlitCountPerFrame_k__BackingField )
			//     goto LABEL_1747;
			//   v749 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v749.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v749.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v750 = v748.klass;
			//     if ( ((__int64)v750.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v748.klass);
			//     (*(void (**)(void))v750.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v748.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(_DWORD *)&TempFromCSharp[920] = reflectionProbeMaxBlitCountPerFrame_k__BackingField.fields._paramValue_k__BackingField;
			//   transparentLowResOffscreenEnable_k__BackingField = settingParameters.fields._transparentLowResOffscreenEnable_k__BackingField;
			//   v752 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !transparentLowResOffscreenEnable_k__BackingField )
			//     goto LABEL_1747;
			//   v753 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v753.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v753.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v754 = v752.klass;
			//     if ( ((__int64)v754.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v752.klass);
			//     (*(void (**)(void))v754.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v752.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   TempFromCSharp[924] = (Void)transparentLowResOffscreenEnable_k__BackingField.fields._paramValue_k__BackingField;
			//   transparentLowResVRSEnable_k__BackingField = settingParameters.fields._transparentLowResVRSEnable_k__BackingField;
			//   v756 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !transparentLowResVRSEnable_k__BackingField )
			//     goto LABEL_1747;
			//   v757 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v757.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v757.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v758 = v756.klass;
			//     if ( ((__int64)v758.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v756.klass);
			//     (*(void (**)(void))v758.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v756.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   TempFromCSharp[925] = (Void)transparentLowResVRSEnable_k__BackingField.fields._paramValue_k__BackingField;
			//   transparentVRRx_k__BackingField = settingParameters.fields._transparentVRRx_k__BackingField;
			//   v760 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !transparentVRRx_k__BackingField )
			//     goto LABEL_1747;
			//   v761 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v761.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v761.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v762 = v760.klass;
			//     if ( ((__int64)v762.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v760.klass);
			//     (*(void (**)(void))v762.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v760.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(_DWORD *)&TempFromCSharp[928] = transparentVRRx_k__BackingField.fields._paramValue_k__BackingField;
			//   transparentVRRy_k__BackingField = settingParameters.fields._transparentVRRy_k__BackingField;
			//   v764 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !transparentVRRy_k__BackingField )
			//     goto LABEL_1747;
			//   v765 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v765.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v765.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v766 = v764.klass;
			//     if ( ((__int64)v766.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v764.klass);
			//     (*(void (**)(void))v766.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v764.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(_DWORD *)&TempFromCSharp[932] = transparentVRRy_k__BackingField.fields._paramValue_k__BackingField;
			//   rayTracingReflectionEnable_k__BackingField = settingParameters.fields._rayTracingReflectionEnable_k__BackingField;
			//   v768 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !rayTracingReflectionEnable_k__BackingField )
			//     goto LABEL_1747;
			//   v769 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v769.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v769.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v770 = v768.klass;
			//     if ( ((__int64)v770.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v768.klass);
			//     (*(void (**)(void))v770.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v768.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   TempFromCSharp[936] = (Void)rayTracingReflectionEnable_k__BackingField.fields._paramValue_k__BackingField;
			//   rayTracingReflectionMode_k__BackingField = settingParameters.fields._rayTracingReflectionMode_k__BackingField;
			//   v772 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !rayTracingReflectionMode_k__BackingField )
			//     goto LABEL_1747;
			//   v773 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v773.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v773.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v774 = v772.klass;
			//     if ( ((__int64)v774.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v772.klass);
			//     (*(void (**)(void))v774.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v772.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(_DWORD *)&TempFromCSharp[940] = rayTracingReflectionMode_k__BackingField.fields._paramValue_k__BackingField;
			//   rayTracingReflectionSSQuality0_k__BackingField = settingParameters.fields._rayTracingReflectionSSQuality0_k__BackingField;
			//   v776 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !rayTracingReflectionSSQuality0_k__BackingField )
			//     goto LABEL_1747;
			//   v777 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v777.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v777.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v778 = v776.klass;
			//     if ( ((__int64)v778.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v776.klass);
			//     (*(void (**)(void))v778.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v776.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[944] = rayTracingReflectionSSQuality0_k__BackingField.fields._paramValue_k__BackingField;
			//   rayTracingReflectionSSQuality1_k__BackingField = settingParameters.fields._rayTracingReflectionSSQuality1_k__BackingField;
			//   v780 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !rayTracingReflectionSSQuality1_k__BackingField )
			//     goto LABEL_1747;
			//   v781 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v781.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v781.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v782 = v780.klass;
			//     if ( ((__int64)v782.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v780.klass);
			//     (*(void (**)(void))v782.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v780.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[948] = rayTracingReflectionSSQuality1_k__BackingField.fields._paramValue_k__BackingField;
			//   rayTracingReflectionSSQuality2_k__BackingField = settingParameters.fields._rayTracingReflectionSSQuality2_k__BackingField;
			//   v784 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !rayTracingReflectionSSQuality2_k__BackingField )
			//     goto LABEL_1747;
			//   v785 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v785.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v785.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v786 = v784.klass;
			//     if ( ((__int64)v786.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v784.klass);
			//     (*(void (**)(void))v786.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v784.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[952] = rayTracingReflectionSSQuality2_k__BackingField.fields._paramValue_k__BackingField;
			//   rayTracingReflectionSSQuality3_k__BackingField = settingParameters.fields._rayTracingReflectionSSQuality3_k__BackingField;
			//   v788 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !rayTracingReflectionSSQuality3_k__BackingField )
			//     goto LABEL_1747;
			//   v789 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v789.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v789.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v790 = v788.klass;
			//     if ( ((__int64)v790.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v788.klass);
			//     (*(void (**)(void))v790.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v788.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[956] = rayTracingReflectionSSQuality3_k__BackingField.fields._paramValue_k__BackingField;
			//   rayTracingReflectionRTQuality0_k__BackingField = settingParameters.fields._rayTracingReflectionRTQuality0_k__BackingField;
			//   v792 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !rayTracingReflectionRTQuality0_k__BackingField )
			//     goto LABEL_1747;
			//   v793 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v793.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v793.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v794 = v792.klass;
			//     if ( ((__int64)v794.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v792.klass);
			//     (*(void (**)(void))v794.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v792.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[960] = rayTracingReflectionRTQuality0_k__BackingField.fields._paramValue_k__BackingField;
			//   rayTracingReflectionRTQuality1_k__BackingField = settingParameters.fields._rayTracingReflectionRTQuality1_k__BackingField;
			//   v796 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !rayTracingReflectionRTQuality1_k__BackingField )
			//     goto LABEL_1747;
			//   v797 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v797.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v797.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v798 = v796.klass;
			//     if ( ((__int64)v798.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v796.klass);
			//     (*(void (**)(void))v798.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v796.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[964] = rayTracingReflectionRTQuality1_k__BackingField.fields._paramValue_k__BackingField;
			//   rayTracingReflectionRTQuality2_k__BackingField = settingParameters.fields._rayTracingReflectionRTQuality2_k__BackingField;
			//   v800 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !rayTracingReflectionRTQuality2_k__BackingField )
			//     goto LABEL_1747;
			//   v801 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v801.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v801.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v802 = v800.klass;
			//     if ( ((__int64)v802.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v800.klass);
			//     (*(void (**)(void))v802.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v800.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[968] = rayTracingReflectionRTQuality2_k__BackingField.fields._paramValue_k__BackingField;
			//   rayTracingReflectionRTQuality3_k__BackingField = settingParameters.fields._rayTracingReflectionRTQuality3_k__BackingField;
			//   v804 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !rayTracingReflectionRTQuality3_k__BackingField )
			//     goto LABEL_1747;
			//   v805 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v805.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v805.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v806 = v804.klass;
			//     if ( ((__int64)v806.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v804.klass);
			//     (*(void (**)(void))v806.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v804.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[972] = rayTracingReflectionRTQuality3_k__BackingField.fields._paramValue_k__BackingField;
			//   frameInterpolationEnable_k__BackingField = settingParameters.fields._frameInterpolationEnable_k__BackingField;
			//   v808 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !frameInterpolationEnable_k__BackingField )
			//     goto LABEL_1747;
			//   v809 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v809.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v809.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v810 = v808.klass;
			//     if ( ((__int64)v810.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v808.klass);
			//     (*(void (**)(void))v810.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v808.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   TempFromCSharp[976] = (Void)frameInterpolationEnable_k__BackingField.fields._paramValue_k__BackingField;
			//   frameInterpolationPause_k__BackingField = settingParameters.fields._frameInterpolationPause_k__BackingField;
			//   v812 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !frameInterpolationPause_k__BackingField )
			//     goto LABEL_1747;
			//   v813 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v813.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v813.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v814 = v812.klass;
			//     if ( ((__int64)v814.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v812.klass);
			//     (*(void (**)(void))v814.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   v815 = v812.klass;
			//   if ( ((__int64)v815.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(v815);
			//   TempFromCSharp[977] = (Void)frameInterpolationPause_k__BackingField.fields._paramValue_k__BackingField;
			//   *(_DWORD *)&TempFromCSharp[980] = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//                                       (SettingParameter_1_System_Int32Enum_ *)settingParameters.fields._frameInterpolationAlgo_k__BackingField,
			//                                       MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::HyperGryphEngineCode::FrameInterpolationAlgo>::op_Implicit);
			//   hasWorldUIAfterFrameInterpolation_k__BackingField = settingParameters.fields._hasWorldUIAfterFrameInterpolation_k__BackingField;
			//   v817 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !hasWorldUIAfterFrameInterpolation_k__BackingField )
			//     goto LABEL_1747;
			//   v818 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v818.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v818.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v819 = v817.klass;
			//     if ( ((__int64)v819.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v817.klass);
			//     (*(void (**)(void))v819.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v817.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   TempFromCSharp[984] = (Void)hasWorldUIAfterFrameInterpolation_k__BackingField.fields._paramValue_k__BackingField;
			//   afmeCameraRotationCosFallbackThreshold_k__BackingField = settingParameters.fields._afmeCameraRotationCosFallbackThreshold_k__BackingField;
			//   v821 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !afmeCameraRotationCosFallbackThreshold_k__BackingField )
			//     goto LABEL_1747;
			//   v822 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v822.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v822.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v823 = v821.klass;
			//     if ( ((__int64)v823.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v821.klass);
			//     (*(void (**)(void))v823.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v821.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[988] = afmeCameraRotationCosFallbackThreshold_k__BackingField.fields._paramValue_k__BackingField;
			//   afmeCameraMoveDistanceSqrFallbackThreshold_k__BackingField = settingParameters.fields._afmeCameraMoveDistanceSqrFallbackThreshold_k__BackingField;
			//   v825 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !afmeCameraMoveDistanceSqrFallbackThreshold_k__BackingField )
			//     goto LABEL_1747;
			//   v826 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v826.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v826.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v827 = v825.klass;
			//     if ( ((__int64)v827.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v825.klass);
			//     (*(void (**)(void))v827.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v825.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[992] = afmeCameraMoveDistanceSqrFallbackThreshold_k__BackingField.fields._paramValue_k__BackingField;
			//   mfrcCameraRotationCosFallbackThreshold_k__BackingField = settingParameters.fields._mfrcCameraRotationCosFallbackThreshold_k__BackingField;
			//   v829 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !mfrcCameraRotationCosFallbackThreshold_k__BackingField )
			//     goto LABEL_1747;
			//   v830 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v830.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v830.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v831 = v829.klass;
			//     if ( ((__int64)v831.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v829.klass);
			//     (*(void (**)(void))v831.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v829.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[996] = mfrcCameraRotationCosFallbackThreshold_k__BackingField.fields._paramValue_k__BackingField;
			//   mfrcCameraMoveDistanceSqrFallbackThreshold_k__BackingField = settingParameters.fields._mfrcCameraMoveDistanceSqrFallbackThreshold_k__BackingField;
			//   v833 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !mfrcCameraMoveDistanceSqrFallbackThreshold_k__BackingField )
			//     goto LABEL_1747;
			//   v834 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v834.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v834.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v835 = v833.klass;
			//     if ( ((__int64)v835.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v833.klass);
			//     (*(void (**)(void))v835.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v833.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[1000] = mfrcCameraMoveDistanceSqrFallbackThreshold_k__BackingField.fields._paramValue_k__BackingField;
			//   mfrcGeneralFallbackThreshold_k__BackingField = settingParameters.fields._mfrcGeneralFallbackThreshold_k__BackingField;
			//   v837 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !mfrcGeneralFallbackThreshold_k__BackingField )
			//     goto LABEL_1747;
			//   v838 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v838.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v838.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v839 = v837.klass;
			//     if ( ((__int64)v839.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v837.klass);
			//     (*(void (**)(void))v839.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v837.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[1004] = mfrcGeneralFallbackThreshold_k__BackingField.fields._paramValue_k__BackingField;
			//   mfrcBrightnessDiffFallbackThreshold_k__BackingField = settingParameters.fields._mfrcBrightnessDiffFallbackThreshold_k__BackingField;
			//   v841 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !mfrcBrightnessDiffFallbackThreshold_k__BackingField )
			//     goto LABEL_1747;
			//   v842 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v842.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v842.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v843 = v841.klass;
			//     if ( ((__int64)v843.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v841.klass);
			//     (*(void (**)(void))v843.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v841.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[1008] = mfrcBrightnessDiffFallbackThreshold_k__BackingField.fields._paramValue_k__BackingField;
			//   mfrcRepeatedPatternFallbackThreshold_k__BackingField = settingParameters.fields._mfrcRepeatedPatternFallbackThreshold_k__BackingField;
			//   v845 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   if ( !mfrcRepeatedPatternFallbackThreshold_k__BackingField )
			//     goto LABEL_1747;
			//   v846 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v846.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v846.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v847 = v845.klass;
			//     if ( ((__int64)v847.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v845.klass);
			//     (*(void (**)(void))v847.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v845.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(float *)&TempFromCSharp[1012] = mfrcRepeatedPatternFallbackThreshold_k__BackingField.fields._paramValue_k__BackingField;
			//   inkSimulationResolution_k__BackingField = settingParameters.fields._inkSimulationResolution_k__BackingField;
			//   v849 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !inkSimulationResolution_k__BackingField )
			//     goto LABEL_1747;
			//   v850 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v850.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v850.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v851 = v849.klass;
			//     if ( ((__int64)v851.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v849.klass);
			//     (*(void (**)(void))v851.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v849.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(_DWORD *)&TempFromCSharp[1016] = inkSimulationResolution_k__BackingField.fields._paramValue_k__BackingField;
			//   inkDensityResolution_k__BackingField = settingParameters.fields._inkDensityResolution_k__BackingField;
			//   v853 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !inkDensityResolution_k__BackingField )
			//     goto LABEL_1747;
			//   v854 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v854.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v854.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v855 = v853.klass;
			//     if ( ((__int64)v855.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v853.klass);
			//     (*(void (**)(void))v855.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   s_settingParameters = (unsigned __int64)v853.klass;
			//   if ( (*(_BYTE *)(s_settingParameters + 312) & 1) == 0 )
			//     sub_18003C700(s_settingParameters);
			//   *(_DWORD *)&TempFromCSharp[1020] = inkDensityResolution_k__BackingField.fields._paramValue_k__BackingField;
			//   inkSimulationEnable_k__BackingField = settingParameters.fields._inkSimulationEnable_k__BackingField;
			//   v857 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !inkSimulationEnable_k__BackingField )
			// LABEL_1747:
			//     sub_1802DC2C8(s_settingParameters, v4);
			//   v858 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v858.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v858.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v859 = v857.klass;
			//     if ( ((__int64)v859.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v857.klass);
			//     (*(void (**)(void))v859.rgctx_data[6].rgctxDataDummy)();
			//   }
			//   v860 = v857.klass;
			//   if ( ((__int64)v860.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(v860);
			//   TempFromCSharp[1024] = (Void)inkSimulationEnable_k__BackingField.fields._paramValue_k__BackingField;
			//   return (HGSettingParametersCpp *)TempFromCSharp;
			// }
			// 
			return null;
		}

		public unsafe static HGDebugRenderManagerCPP* ConvertHGDebugRenderManagerToCPP()
		{
			// // Object GetBuiltinExtraResource[Object](String)
			// Object *HoudiniEngineUnity::HEU_AssetDatabase::GetBuiltinExtraResource<System::Object>(
			//         String *resourceName,
			//         MethodInfo *method)
			// {
			//   return 0LL;
			// }
			// 
			return null;
		}

		public unsafe static HGDebugFeaturesManagerCPP* ConvertHGDebugFeatureManagerToCPP()
		{
			// // Object GetBuiltinExtraResource[Object](String)
			// Object *HoudiniEngineUnity::HEU_AssetDatabase::GetBuiltinExtraResource<System::Object>(
			//         String *resourceName,
			//         MethodInfo *method)
			// {
			//   return 0LL;
			// }
			// 
			return null;
		}

		public unsafe static HGLightConfigCPP* ConvertLightConfigToCpp(HGLightConfig src)
		{
			// // HGLightConfigCPP* ConvertLightConfigToCpp(HGLightConfig)
			// HGLightConfigCPP *HG::Rendering::Runtime::HGUtilsCpp::ConvertLightConfigToCpp(HGLightConfig *src, MethodInfo *method)
			// {
			//   __int64 (__fastcall *v2)(__int64, MethodInfo *); // rax
			//   __int64 v4; // rax
			//   __int64 v5; // r9
			//   Color *v6; // rdx
			//   __int64 v7; // r8
			//   HGLightConfig *v8; // rcx
			//   __int64 v9; // rax
			//   Color directColor; // xmm0
			//   Color v11; // xmm1
			//   Color v12; // xmm0
			//   Color v13; // xmm1
			//   Color v14; // xmm0
			//   Color v15; // xmm1
			//   Color v16; // xmm0
			//   Color v17; // xmm1
			//   Color v18; // xmm1
			//   Color v19; // xmm0
			//   Color v20; // xmm1
			//   Color v21; // xmm0
			//   Color v22; // xmm1
			//   Color *v23; // rcx
			//   HGLightConfig *v24; // rax
			//   __int64 v25; // rdx
			//   Color v26; // xmm0
			//   Color v27; // xmm1
			//   Color v28; // xmm0
			//   Color v29; // xmm1
			//   Color v30; // xmm0
			//   Color v31; // xmm1
			//   Color v32; // xmm0
			//   Color v33; // xmm1
			//   __int64 v34; // rdx
			//   Color v35; // xmm1
			//   Color v36; // xmm0
			//   Color v37; // xmm1
			//   Color v38; // xmm0
			//   Color v39; // xmm1
			//   HGLightConfig *v40; // rax
			//   Color *v41; // rcx
			//   Color v42; // xmm0
			//   Color v43; // xmm1
			//   Color v44; // xmm0
			//   Color v45; // xmm1
			//   Color v46; // xmm0
			//   Color v47; // xmm1
			//   Color v48; // xmm0
			//   Color v49; // xmm1
			//   __int64 v50; // rdx
			//   Color v51; // xmm1
			//   Color v52; // xmm0
			//   Color v53; // xmm1
			//   Color v54; // xmm0
			//   Color v55; // xmm1
			//   HGLightConfig *v56; // rax
			//   Color *v57; // rcx
			//   Color v58; // xmm0
			//   Color v59; // xmm1
			//   Color v60; // xmm0
			//   Color v61; // xmm1
			//   Color v62; // xmm0
			//   Color v63; // xmm1
			//   Color v64; // xmm0
			//   Color v65; // xmm1
			//   __int64 v66; // rdx
			//   Color v67; // xmm1
			//   Color v68; // xmm0
			//   Color v69; // xmm1
			//   Color v70; // xmm0
			//   Color v71; // xmm1
			//   HGLightConfig *v72; // rax
			//   Color *v73; // rcx
			//   Color v74; // xmm0
			//   Color v75; // xmm1
			//   Color v76; // xmm0
			//   Color v77; // xmm1
			//   Color v78; // xmm0
			//   Color v79; // xmm1
			//   Color v80; // xmm0
			//   Color v81; // xmm1
			//   __int64 v82; // rdx
			//   Color v83; // xmm1
			//   Color v84; // xmm0
			//   Color v85; // xmm1
			//   Color v86; // xmm0
			//   Color v87; // xmm1
			//   HGLightConfig *v88; // rax
			//   Color *v89; // rcx
			//   Color v90; // xmm0
			//   Color v91; // xmm1
			//   Color v92; // xmm0
			//   Color v93; // xmm1
			//   Color v94; // xmm0
			//   Color v95; // xmm1
			//   Color v96; // xmm0
			//   Color v97; // xmm1
			//   __int64 v98; // rdx
			//   Color v99; // xmm1
			//   Color v100; // xmm0
			//   Color v101; // xmm1
			//   Color v102; // xmm0
			//   Color v103; // xmm1
			//   HGLightConfig *v104; // rax
			//   Color *v105; // rcx
			//   Color v106; // xmm0
			//   Color v107; // xmm1
			//   Color v108; // xmm0
			//   Color v109; // xmm1
			//   Color v110; // xmm0
			//   Color v111; // xmm1
			//   Color v112; // xmm0
			//   Color v113; // xmm1
			//   __int64 v114; // rdx
			//   Color v115; // xmm1
			//   Color v116; // xmm0
			//   Color v117; // xmm1
			//   Color v118; // xmm0
			//   Color v119; // xmm1
			//   HGLightConfig *v120; // rax
			//   Color *v121; // rcx
			//   Color v122; // xmm0
			//   Color v123; // xmm1
			//   Color v124; // xmm0
			//   Color v125; // xmm1
			//   Color v126; // xmm0
			//   Color v127; // xmm1
			//   Color v128; // xmm0
			//   Color v129; // xmm1
			//   __int64 v130; // rdx
			//   Color v131; // xmm1
			//   Color v132; // xmm0
			//   Color v133; // xmm1
			//   Color v134; // xmm0
			//   Color v135; // xmm1
			//   int v136; // eax
			//   Color *v137; // rcx
			//   HGLightConfig *v138; // rax
			//   Color v139; // xmm0
			//   Color v140; // xmm1
			//   Color v141; // xmm0
			//   Color v142; // xmm1
			//   Color v143; // xmm0
			//   Color v144; // xmm1
			//   Color v145; // xmm0
			//   Color v146; // xmm1
			//   __int64 v147; // rdx
			//   Color v148; // xmm1
			//   Color v149; // xmm0
			//   Color v150; // xmm1
			//   Color v151; // xmm0
			//   Color v152; // xmm1
			//   HGLightConfig *v153; // rax
			//   Color *v154; // rcx
			//   __int128 v155; // xmm1
			//   __int128 v156; // xmm0
			//   __int128 v157; // xmm1
			//   Color v158; // xmm0
			//   Color v159; // xmm1
			//   Color v160; // xmm0
			//   Color v161; // xmm1
			//   Color v162; // xmm0
			//   Color v163; // xmm1
			//   Color v164; // xmm0
			//   Color v165; // xmm1
			//   __int64 v166; // rdx
			//   Color v167; // xmm1
			//   Color v168; // xmm0
			//   Color v169; // xmm1
			//   Color v170; // xmm0
			//   Color v171; // xmm1
			//   HGLightConfig *v172; // rax
			//   Color *v173; // rcx
			//   Color v174; // xmm0
			//   Color v175; // xmm1
			//   Color v176; // xmm0
			//   Color v177; // xmm1
			//   Color v178; // xmm0
			//   Color v179; // xmm1
			//   Color v180; // xmm0
			//   Color v181; // xmm1
			//   __int64 v182; // rdx
			//   Color v183; // xmm1
			//   Color v184; // xmm0
			//   Color v185; // xmm1
			//   Color v186; // xmm0
			//   Color v187; // xmm1
			//   HGLightConfig *v188; // rax
			//   Color *v189; // rcx
			//   Color v190; // xmm0
			//   Color v191; // xmm1
			//   Color v192; // xmm0
			//   Color v193; // xmm1
			//   Color v194; // xmm0
			//   Color v195; // xmm1
			//   Color v196; // xmm0
			//   Color v197; // xmm1
			//   __int64 v198; // rdx
			//   Color v199; // xmm1
			//   Color v200; // xmm0
			//   Color v201; // xmm1
			//   Color v202; // xmm0
			//   Color v203; // xmm1
			//   HGLightConfig *v204; // rax
			//   Color *v205; // rcx
			//   Color v206; // xmm0
			//   Color v207; // xmm1
			//   Color v208; // xmm0
			//   Color v209; // xmm1
			//   Color v210; // xmm0
			//   Color v211; // xmm1
			//   Color v212; // xmm0
			//   Color v213; // xmm1
			//   __int64 v214; // rdx
			//   Color v215; // xmm1
			//   Color v216; // xmm0
			//   Color v217; // xmm1
			//   Color v218; // xmm0
			//   Color v219; // xmm1
			//   HGLightConfig *v220; // rax
			//   Color *v221; // rcx
			//   Color v222; // xmm0
			//   Color v223; // xmm1
			//   Color v224; // xmm0
			//   Color v225; // xmm1
			//   Color v226; // xmm0
			//   Color v227; // xmm1
			//   Color v228; // xmm0
			//   Color v229; // xmm1
			//   __int64 v230; // rdx
			//   Color v231; // xmm1
			//   Color v232; // xmm0
			//   Color v233; // xmm1
			//   Color v234; // xmm0
			//   Color v235; // xmm1
			//   HGLightConfig *v236; // rax
			//   Color *v237; // rcx
			//   Color v238; // xmm0
			//   Color v239; // xmm1
			//   Color v240; // xmm0
			//   Color v241; // xmm1
			//   Color v242; // xmm0
			//   Color v243; // xmm1
			//   Color v244; // xmm0
			//   Color v245; // xmm1
			//   __int64 v246; // rdx
			//   Color v247; // xmm1
			//   Color v248; // xmm0
			//   Color v249; // xmm1
			//   Color v250; // xmm0
			//   Color v251; // xmm1
			//   HGLightConfig *v252; // rax
			//   Color *v253; // rcx
			//   Color v254; // xmm0
			//   Color v255; // xmm1
			//   Color v256; // xmm0
			//   Color v257; // xmm1
			//   Color v258; // xmm0
			//   Color v259; // xmm1
			//   Color v260; // xmm0
			//   Color v261; // xmm1
			//   __int64 v262; // rdx
			//   Color v263; // xmm1
			//   Color v264; // xmm0
			//   Color v265; // xmm1
			//   Color v266; // xmm0
			//   Color v267; // xmm1
			//   Color *v268; // rcx
			//   HGLightConfig *v269; // rax
			//   Color v270; // xmm0
			//   Color v271; // xmm1
			//   Color v272; // xmm0
			//   Color v273; // xmm1
			//   Color v274; // xmm0
			//   Color v275; // xmm1
			//   Color v276; // xmm0
			//   Color v277; // xmm1
			//   __int64 v278; // rdx
			//   Color v279; // xmm1
			//   Color v280; // xmm0
			//   Color v281; // xmm1
			//   Color v282; // xmm0
			//   Color v283; // xmm1
			//   HGLightConfig *v284; // rax
			//   Color *v285; // rcx
			//   Color v286; // xmm0
			//   Color v287; // xmm1
			//   Color v288; // xmm0
			//   Color v289; // xmm1
			//   Color v290; // xmm0
			//   Color v291; // xmm1
			//   Color v292; // xmm0
			//   Color v293; // xmm1
			//   Color v294; // xmm1
			//   Color v295; // xmm0
			//   Color v296; // xmm1
			//   Color v297; // xmm0
			//   Color v298; // xmm1
			//   Color *v299; // rax
			//   Color v300; // xmm0
			//   Color v301; // xmm1
			//   Color v302; // xmm0
			//   Color v303; // xmm1
			//   Color v304; // xmm0
			//   Color v305; // xmm1
			//   Color v306; // xmm0
			//   Color v307; // xmm1
			//   Color v308; // xmm1
			//   Color v309; // xmm0
			//   Color v310; // xmm1
			//   Color v311; // xmm0
			//   Color v312; // xmm1
			//   HGLightConfigCPP *result; // rax
			//   __int64 v314; // rax
			//   _OWORD v315[3]; // [rsp+20h] [rbp-E0h] BYREF
			//   int v316; // [rsp+50h] [rbp-B0h]
			//   int v317; // [rsp+54h] [rbp-ACh]
			//   int v318; // [rsp+58h] [rbp-A8h]
			//   float v319; // [rsp+5Ch] [rbp-A4h]
			//   int v320; // [rsp+60h] [rbp-A0h]
			//   int v321; // [rsp+64h] [rbp-9Ch]
			//   int v322; // [rsp+9Ch] [rbp-64h]
			//   int v323; // [rsp+A0h] [rbp-60h]
			//   float v324; // [rsp+A4h] [rbp-5Ch]
			//   int v325; // [rsp+B4h] [rbp-4Ch]
			//   int v326; // [rsp+B8h] [rbp-48h]
			//   __int128 v327; // [rsp+C0h] [rbp-40h]
			//   __int64 v328; // [rsp+D0h] [rbp-30h]
			//   int v329; // [rsp+D8h] [rbp-28h]
			//   __int128 v330; // [rsp+DCh] [rbp-24h]
			//   __int128 v331; // [rsp+ECh] [rbp-14h]
			//   __int128 v332; // [rsp+FCh] [rbp-4h]
			//   __int128 v333; // [rsp+10Ch] [rbp+Ch]
			//   __int128 v334; // [rsp+11Ch] [rbp+1Ch]
			//   __int128 v335; // [rsp+12Ch] [rbp+2Ch]
			//   __int128 v336; // [rsp+13Ch] [rbp+3Ch]
			//   __int128 v337; // [rsp+14Ch] [rbp+4Ch]
			//   __int128 v338; // [rsp+15Ch] [rbp+5Ch]
			//   __int128 v339; // [rsp+16Ch] [rbp+6Ch]
			// 
			//   v2 = (__int64 (__fastcall *)(__int64, MethodInfo *))qword_18D8F57F8;
			//   if ( !qword_18D8F57F8 )
			//   {
			//     v2 = (__int64 (__fastcall *)(__int64, MethodInfo *))il2cpp_resolve_icall_0(
			//                                                           "UnityEngine.HyperGryphEngineCode.HGRenderGraphCPP::AllocateTem"
			//                                                           "pFromCSharp(System.Int64)");
			//     if ( !v2 )
			//     {
			//       v314 = sub_1802DBBE8("UnityEngine.HyperGryphEngineCode.HGRenderGraphCPP::AllocateTempFromCSharp(System.Int64)");
			//       sub_18000F750(v314, 0LL);
			//     }
			//     qword_18D8F57F8 = (__int64)v2;
			//   }
			//   v4 = v2(248LL, method);
			//   v5 = 2LL;
			//   v6 = (Color *)v315;
			//   v7 = v4;
			//   v8 = src;
			//   v9 = 2LL;
			//   do
			//   {
			//     v6 += 8;
			//     directColor = v8.directColor;
			//     v11 = *(Color *)&v8.directColorMode;
			//     v8 = (HGLightConfig *)((char *)v8 + 128);
			//     v6[-8] = directColor;
			//     v12 = *(Color *)&v8[-1].rotationAtmosphere.y;
			//     v6[-7] = v11;
			//     v13 = *(Color *)&v8[-1].rotationLightShaft.y;
			//     v6[-6] = v12;
			//     v14 = *(Color *)&v8[-1].rotationSunDisc.y;
			//     v6[-5] = v13;
			//     v15 = *(Color *)&v8[-1].rotationLensFlare.y;
			//     v6[-4] = v14;
			//     v16 = *(Color *)&v8[-1].rotationCloudShadow.y;
			//     v6[-3] = v15;
			//     v17 = *(Color *)&v8[-1].rotationHeightFogDirectionalInscattering.y;
			//     v6[-2] = v16;
			//     v6[-1] = v17;
			//     --v9;
			//   }
			//   while ( v9 );
			//   v18 = *(Color *)&v8.directColorMode;
			//   *v6 = v8.directColor;
			//   v19 = *(Color *)&v8.directCustomColor.a;
			//   v6[1] = v18;
			//   v20 = *(Color *)&v8.directSpecularIntensity;
			//   v6[2] = v19;
			//   v21 = *(Color *)&v8.indirectDiffuseFactor;
			//   v6[3] = v20;
			//   v22 = *(Color *)&v8.atmospherePitchYaw.x;
			//   v6[4] = v21;
			//   v6[5] = v22;
			//   if ( !v7 )
			//     sub_180B536AC(v8, v6);
			//   v23 = (Color *)v315;
			//   *(_DWORD *)v7 = v325;
			//   v24 = src;
			//   v25 = 2LL;
			//   do
			//   {
			//     v23 += 8;
			//     v26 = v24.directColor;
			//     v27 = *(Color *)&v24.directColorMode;
			//     v24 = (HGLightConfig *)((char *)v24 + 128);
			//     v23[-8] = v26;
			//     v28 = *(Color *)&v24[-1].rotationAtmosphere.y;
			//     v23[-7] = v27;
			//     v29 = *(Color *)&v24[-1].rotationLightShaft.y;
			//     v23[-6] = v28;
			//     v30 = *(Color *)&v24[-1].rotationSunDisc.y;
			//     v23[-5] = v29;
			//     v31 = *(Color *)&v24[-1].rotationLensFlare.y;
			//     v23[-4] = v30;
			//     v32 = *(Color *)&v24[-1].rotationCloudShadow.y;
			//     v23[-3] = v31;
			//     v33 = *(Color *)&v24[-1].rotationHeightFogDirectionalInscattering.y;
			//     v23[-2] = v32;
			//     v23[-1] = v33;
			//     --v25;
			//   }
			//   while ( v25 );
			//   v34 = 2LL;
			//   v35 = *(Color *)&v24.directColorMode;
			//   *v23 = v24.directColor;
			//   v36 = *(Color *)&v24.directCustomColor.a;
			//   v23[1] = v35;
			//   v37 = *(Color *)&v24.directSpecularIntensity;
			//   v23[2] = v36;
			//   v38 = *(Color *)&v24.indirectDiffuseFactor;
			//   v23[3] = v37;
			//   v39 = *(Color *)&v24.atmospherePitchYaw.x;
			//   v40 = src;
			//   v23[4] = v38;
			//   v23[5] = v39;
			//   v41 = (Color *)v315;
			//   *(_OWORD *)(v7 + 4) = v315[0];
			//   do
			//   {
			//     v41 += 8;
			//     v42 = v40.directColor;
			//     v43 = *(Color *)&v40.directColorMode;
			//     v40 = (HGLightConfig *)((char *)v40 + 128);
			//     v41[-8] = v42;
			//     v44 = *(Color *)&v40[-1].rotationAtmosphere.y;
			//     v41[-7] = v43;
			//     v45 = *(Color *)&v40[-1].rotationLightShaft.y;
			//     v41[-6] = v44;
			//     v46 = *(Color *)&v40[-1].rotationSunDisc.y;
			//     v41[-5] = v45;
			//     v47 = *(Color *)&v40[-1].rotationLensFlare.y;
			//     v41[-4] = v46;
			//     v48 = *(Color *)&v40[-1].rotationCloudShadow.y;
			//     v41[-3] = v47;
			//     v49 = *(Color *)&v40[-1].rotationHeightFogDirectionalInscattering.y;
			//     v41[-2] = v48;
			//     v41[-1] = v49;
			//     --v34;
			//   }
			//   while ( v34 );
			//   v50 = 2LL;
			//   v51 = *(Color *)&v40.directColorMode;
			//   *v41 = v40.directColor;
			//   v52 = *(Color *)&v40.directCustomColor.a;
			//   v41[1] = v51;
			//   v53 = *(Color *)&v40.directSpecularIntensity;
			//   v41[2] = v52;
			//   v54 = *(Color *)&v40.indirectDiffuseFactor;
			//   v41[3] = v53;
			//   v55 = *(Color *)&v40.atmospherePitchYaw.x;
			//   v56 = src;
			//   v41[4] = v54;
			//   v41[5] = v55;
			//   v57 = (Color *)v315;
			//   *(_DWORD *)(v7 + 20) = v326;
			//   do
			//   {
			//     v57 += 8;
			//     v58 = v56.directColor;
			//     v59 = *(Color *)&v56.directColorMode;
			//     v56 = (HGLightConfig *)((char *)v56 + 128);
			//     v57[-8] = v58;
			//     v60 = *(Color *)&v56[-1].rotationAtmosphere.y;
			//     v57[-7] = v59;
			//     v61 = *(Color *)&v56[-1].rotationLightShaft.y;
			//     v57[-6] = v60;
			//     v62 = *(Color *)&v56[-1].rotationSunDisc.y;
			//     v57[-5] = v61;
			//     v63 = *(Color *)&v56[-1].rotationLensFlare.y;
			//     v57[-4] = v62;
			//     v64 = *(Color *)&v56[-1].rotationCloudShadow.y;
			//     v57[-3] = v63;
			//     v65 = *(Color *)&v56[-1].rotationHeightFogDirectionalInscattering.y;
			//     v57[-2] = v64;
			//     v57[-1] = v65;
			//     --v50;
			//   }
			//   while ( v50 );
			//   v66 = 2LL;
			//   v67 = *(Color *)&v56.directColorMode;
			//   *v57 = v56.directColor;
			//   v68 = *(Color *)&v56.directCustomColor.a;
			//   v57[1] = v67;
			//   v69 = *(Color *)&v56.directSpecularIntensity;
			//   v57[2] = v68;
			//   v70 = *(Color *)&v56.indirectDiffuseFactor;
			//   v57[3] = v69;
			//   v71 = *(Color *)&v56.atmospherePitchYaw.x;
			//   v72 = src;
			//   v57[4] = v70;
			//   v57[5] = v71;
			//   v73 = (Color *)v315;
			//   v71.r = v319;
			//   *(_DWORD *)(v7 + 32) = v318;
			//   *(float *)(v7 + 36) = v71.r;
			//   do
			//   {
			//     v73 += 8;
			//     v74 = v72.directColor;
			//     v75 = *(Color *)&v72.directColorMode;
			//     v72 = (HGLightConfig *)((char *)v72 + 128);
			//     v73[-8] = v74;
			//     v76 = *(Color *)&v72[-1].rotationAtmosphere.y;
			//     v73[-7] = v75;
			//     v77 = *(Color *)&v72[-1].rotationLightShaft.y;
			//     v73[-6] = v76;
			//     v78 = *(Color *)&v72[-1].rotationSunDisc.y;
			//     v73[-5] = v77;
			//     v79 = *(Color *)&v72[-1].rotationLensFlare.y;
			//     v73[-4] = v78;
			//     v80 = *(Color *)&v72[-1].rotationCloudShadow.y;
			//     v73[-3] = v79;
			//     v81 = *(Color *)&v72[-1].rotationHeightFogDirectionalInscattering.y;
			//     v73[-2] = v80;
			//     v73[-1] = v81;
			//     --v66;
			//   }
			//   while ( v66 );
			//   v82 = 2LL;
			//   v83 = *(Color *)&v72.directColorMode;
			//   *v73 = v72.directColor;
			//   v84 = *(Color *)&v72.directCustomColor.a;
			//   v73[1] = v83;
			//   v85 = *(Color *)&v72.directSpecularIntensity;
			//   v73[2] = v84;
			//   v86 = *(Color *)&v72.indirectDiffuseFactor;
			//   v73[3] = v85;
			//   v87 = *(Color *)&v72.atmospherePitchYaw.x;
			//   v88 = src;
			//   v73[4] = v86;
			//   v73[5] = v87;
			//   v89 = (Color *)v315;
			//   *(_DWORD *)(v7 + 40) = v320;
			//   do
			//   {
			//     v89 += 8;
			//     v90 = v88.directColor;
			//     v91 = *(Color *)&v88.directColorMode;
			//     v88 = (HGLightConfig *)((char *)v88 + 128);
			//     v89[-8] = v90;
			//     v92 = *(Color *)&v88[-1].rotationAtmosphere.y;
			//     v89[-7] = v91;
			//     v93 = *(Color *)&v88[-1].rotationLightShaft.y;
			//     v89[-6] = v92;
			//     v94 = *(Color *)&v88[-1].rotationSunDisc.y;
			//     v89[-5] = v93;
			//     v95 = *(Color *)&v88[-1].rotationLensFlare.y;
			//     v89[-4] = v94;
			//     v96 = *(Color *)&v88[-1].rotationCloudShadow.y;
			//     v89[-3] = v95;
			//     v97 = *(Color *)&v88[-1].rotationHeightFogDirectionalInscattering.y;
			//     v89[-2] = v96;
			//     v89[-1] = v97;
			//     --v82;
			//   }
			//   while ( v82 );
			//   v98 = 2LL;
			//   v99 = *(Color *)&v88.directColorMode;
			//   *v89 = v88.directColor;
			//   v100 = *(Color *)&v88.directCustomColor.a;
			//   v89[1] = v99;
			//   v101 = *(Color *)&v88.directSpecularIntensity;
			//   v89[2] = v100;
			//   v102 = *(Color *)&v88.indirectDiffuseFactor;
			//   v89[3] = v101;
			//   v103 = *(Color *)&v88.atmospherePitchYaw.x;
			//   v104 = src;
			//   v89[4] = v102;
			//   v89[5] = v103;
			//   v105 = (Color *)v315;
			//   *(_DWORD *)(v7 + 44) = v321;
			//   do
			//   {
			//     v105 += 8;
			//     v106 = v104.directColor;
			//     v107 = *(Color *)&v104.directColorMode;
			//     v104 = (HGLightConfig *)((char *)v104 + 128);
			//     v105[-8] = v106;
			//     v108 = *(Color *)&v104[-1].rotationAtmosphere.y;
			//     v105[-7] = v107;
			//     v109 = *(Color *)&v104[-1].rotationLightShaft.y;
			//     v105[-6] = v108;
			//     v110 = *(Color *)&v104[-1].rotationSunDisc.y;
			//     v105[-5] = v109;
			//     v111 = *(Color *)&v104[-1].rotationLensFlare.y;
			//     v105[-4] = v110;
			//     v112 = *(Color *)&v104[-1].rotationCloudShadow.y;
			//     v105[-3] = v111;
			//     v113 = *(Color *)&v104[-1].rotationHeightFogDirectionalInscattering.y;
			//     v105[-2] = v112;
			//     v105[-1] = v113;
			//     --v98;
			//   }
			//   while ( v98 );
			//   v114 = 2LL;
			//   v115 = *(Color *)&v104.directColorMode;
			//   *v105 = v104.directColor;
			//   v116 = *(Color *)&v104.directCustomColor.a;
			//   v105[1] = v115;
			//   v117 = *(Color *)&v104.directSpecularIntensity;
			//   v105[2] = v116;
			//   v118 = *(Color *)&v104.indirectDiffuseFactor;
			//   v105[3] = v117;
			//   v119 = *(Color *)&v104.atmospherePitchYaw.x;
			//   v120 = src;
			//   v105[4] = v118;
			//   v105[5] = v119;
			//   v121 = (Color *)v315;
			//   *(_OWORD *)(v7 + 48) = v327;
			//   do
			//   {
			//     v121 += 8;
			//     v122 = v120.directColor;
			//     v123 = *(Color *)&v120.directColorMode;
			//     v120 = (HGLightConfig *)((char *)v120 + 128);
			//     v121[-8] = v122;
			//     v124 = *(Color *)&v120[-1].rotationAtmosphere.y;
			//     v121[-7] = v123;
			//     v125 = *(Color *)&v120[-1].rotationLightShaft.y;
			//     v121[-6] = v124;
			//     v126 = *(Color *)&v120[-1].rotationSunDisc.y;
			//     v121[-5] = v125;
			//     v127 = *(Color *)&v120[-1].rotationLensFlare.y;
			//     v121[-4] = v126;
			//     v128 = *(Color *)&v120[-1].rotationCloudShadow.y;
			//     v121[-3] = v127;
			//     v129 = *(Color *)&v120[-1].rotationHeightFogDirectionalInscattering.y;
			//     v121[-2] = v128;
			//     v121[-1] = v129;
			//     --v114;
			//   }
			//   while ( v114 );
			//   v130 = 2LL;
			//   v131 = *(Color *)&v120.directColorMode;
			//   *v121 = v120.directColor;
			//   v132 = *(Color *)&v120.directCustomColor.a;
			//   v121[1] = v131;
			//   v133 = *(Color *)&v120.directSpecularIntensity;
			//   v121[2] = v132;
			//   v134 = *(Color *)&v120.indirectDiffuseFactor;
			//   v121[3] = v133;
			//   v135 = *(Color *)&v120.atmospherePitchYaw.x;
			//   v121[4] = v134;
			//   v121[5] = v135;
			//   v136 = v329;
			//   v137 = (Color *)v315;
			//   *(_QWORD *)(v7 + 64) = v328;
			//   *(_DWORD *)(v7 + 72) = v136;
			//   v138 = src;
			//   do
			//   {
			//     v137 += 8;
			//     v139 = v138.directColor;
			//     v140 = *(Color *)&v138.directColorMode;
			//     v138 = (HGLightConfig *)((char *)v138 + 128);
			//     v137[-8] = v139;
			//     v141 = *(Color *)&v138[-1].rotationAtmosphere.y;
			//     v137[-7] = v140;
			//     v142 = *(Color *)&v138[-1].rotationLightShaft.y;
			//     v137[-6] = v141;
			//     v143 = *(Color *)&v138[-1].rotationSunDisc.y;
			//     v137[-5] = v142;
			//     v144 = *(Color *)&v138[-1].rotationLensFlare.y;
			//     v137[-4] = v143;
			//     v145 = *(Color *)&v138[-1].rotationCloudShadow.y;
			//     v137[-3] = v144;
			//     v146 = *(Color *)&v138[-1].rotationHeightFogDirectionalInscattering.y;
			//     v137[-2] = v145;
			//     v137[-1] = v146;
			//     --v130;
			//   }
			//   while ( v130 );
			//   v147 = 2LL;
			//   v148 = *(Color *)&v138.directColorMode;
			//   *v137 = v138.directColor;
			//   v149 = *(Color *)&v138.directCustomColor.a;
			//   v137[1] = v148;
			//   v150 = *(Color *)&v138.directSpecularIntensity;
			//   v137[2] = v149;
			//   v151 = *(Color *)&v138.indirectDiffuseFactor;
			//   v137[3] = v150;
			//   v152 = *(Color *)&v138.atmospherePitchYaw.x;
			//   v153 = src;
			//   v137[4] = v151;
			//   v137[5] = v152;
			//   v154 = (Color *)v315;
			//   v155 = v331;
			//   *(_OWORD *)(v7 + 76) = v330;
			//   v156 = v332;
			//   *(_OWORD *)(v7 + 92) = v155;
			//   v157 = v333;
			//   *(_OWORD *)(v7 + 108) = v156;
			//   *(_OWORD *)(v7 + 124) = v157;
			//   do
			//   {
			//     v154 += 8;
			//     v158 = v153.directColor;
			//     v159 = *(Color *)&v153.directColorMode;
			//     v153 = (HGLightConfig *)((char *)v153 + 128);
			//     v154[-8] = v158;
			//     v160 = *(Color *)&v153[-1].rotationAtmosphere.y;
			//     v154[-7] = v159;
			//     v161 = *(Color *)&v153[-1].rotationLightShaft.y;
			//     v154[-6] = v160;
			//     v162 = *(Color *)&v153[-1].rotationSunDisc.y;
			//     v154[-5] = v161;
			//     v163 = *(Color *)&v153[-1].rotationLensFlare.y;
			//     v154[-4] = v162;
			//     v164 = *(Color *)&v153[-1].rotationCloudShadow.y;
			//     v154[-3] = v163;
			//     v165 = *(Color *)&v153[-1].rotationHeightFogDirectionalInscattering.y;
			//     v154[-2] = v164;
			//     v154[-1] = v165;
			//     --v147;
			//   }
			//   while ( v147 );
			//   v166 = 2LL;
			//   v167 = *(Color *)&v153.directColorMode;
			//   *v154 = v153.directColor;
			//   v168 = *(Color *)&v153.directCustomColor.a;
			//   v154[1] = v167;
			//   v169 = *(Color *)&v153.directSpecularIntensity;
			//   v154[2] = v168;
			//   v170 = *(Color *)&v153.indirectDiffuseFactor;
			//   v154[3] = v169;
			//   v171 = *(Color *)&v153.atmospherePitchYaw.x;
			//   v172 = src;
			//   v154[4] = v170;
			//   v154[5] = v171;
			//   v173 = (Color *)v315;
			//   *(_OWORD *)(v7 + 140) = v334;
			//   do
			//   {
			//     v173 += 8;
			//     v174 = v172.directColor;
			//     v175 = *(Color *)&v172.directColorMode;
			//     v172 = (HGLightConfig *)((char *)v172 + 128);
			//     v173[-8] = v174;
			//     v176 = *(Color *)&v172[-1].rotationAtmosphere.y;
			//     v173[-7] = v175;
			//     v177 = *(Color *)&v172[-1].rotationLightShaft.y;
			//     v173[-6] = v176;
			//     v178 = *(Color *)&v172[-1].rotationSunDisc.y;
			//     v173[-5] = v177;
			//     v179 = *(Color *)&v172[-1].rotationLensFlare.y;
			//     v173[-4] = v178;
			//     v180 = *(Color *)&v172[-1].rotationCloudShadow.y;
			//     v173[-3] = v179;
			//     v181 = *(Color *)&v172[-1].rotationHeightFogDirectionalInscattering.y;
			//     v173[-2] = v180;
			//     v173[-1] = v181;
			//     --v166;
			//   }
			//   while ( v166 );
			//   v182 = 2LL;
			//   v183 = *(Color *)&v172.directColorMode;
			//   *v173 = v172.directColor;
			//   v184 = *(Color *)&v172.directCustomColor.a;
			//   v173[1] = v183;
			//   v185 = *(Color *)&v172.directSpecularIntensity;
			//   v173[2] = v184;
			//   v186 = *(Color *)&v172.indirectDiffuseFactor;
			//   v173[3] = v185;
			//   v187 = *(Color *)&v172.atmospherePitchYaw.x;
			//   v188 = src;
			//   v173[4] = v186;
			//   v173[5] = v187;
			//   v189 = (Color *)v315;
			//   *(_OWORD *)(v7 + 156) = v335;
			//   do
			//   {
			//     v189 += 8;
			//     v190 = v188.directColor;
			//     v191 = *(Color *)&v188.directColorMode;
			//     v188 = (HGLightConfig *)((char *)v188 + 128);
			//     v189[-8] = v190;
			//     v192 = *(Color *)&v188[-1].rotationAtmosphere.y;
			//     v189[-7] = v191;
			//     v193 = *(Color *)&v188[-1].rotationLightShaft.y;
			//     v189[-6] = v192;
			//     v194 = *(Color *)&v188[-1].rotationSunDisc.y;
			//     v189[-5] = v193;
			//     v195 = *(Color *)&v188[-1].rotationLensFlare.y;
			//     v189[-4] = v194;
			//     v196 = *(Color *)&v188[-1].rotationCloudShadow.y;
			//     v189[-3] = v195;
			//     v197 = *(Color *)&v188[-1].rotationHeightFogDirectionalInscattering.y;
			//     v189[-2] = v196;
			//     v189[-1] = v197;
			//     --v182;
			//   }
			//   while ( v182 );
			//   v198 = 2LL;
			//   v199 = *(Color *)&v188.directColorMode;
			//   *v189 = v188.directColor;
			//   v200 = *(Color *)&v188.directCustomColor.a;
			//   v189[1] = v199;
			//   v201 = *(Color *)&v188.directSpecularIntensity;
			//   v189[2] = v200;
			//   v202 = *(Color *)&v188.indirectDiffuseFactor;
			//   v189[3] = v201;
			//   v203 = *(Color *)&v188.atmospherePitchYaw.x;
			//   v204 = src;
			//   v189[4] = v202;
			//   v189[5] = v203;
			//   v205 = (Color *)v315;
			//   *(_OWORD *)(v7 + 172) = v336;
			//   do
			//   {
			//     v205 += 8;
			//     v206 = v204.directColor;
			//     v207 = *(Color *)&v204.directColorMode;
			//     v204 = (HGLightConfig *)((char *)v204 + 128);
			//     v205[-8] = v206;
			//     v208 = *(Color *)&v204[-1].rotationAtmosphere.y;
			//     v205[-7] = v207;
			//     v209 = *(Color *)&v204[-1].rotationLightShaft.y;
			//     v205[-6] = v208;
			//     v210 = *(Color *)&v204[-1].rotationSunDisc.y;
			//     v205[-5] = v209;
			//     v211 = *(Color *)&v204[-1].rotationLensFlare.y;
			//     v205[-4] = v210;
			//     v212 = *(Color *)&v204[-1].rotationCloudShadow.y;
			//     v205[-3] = v211;
			//     v213 = *(Color *)&v204[-1].rotationHeightFogDirectionalInscattering.y;
			//     v205[-2] = v212;
			//     v205[-1] = v213;
			//     --v198;
			//   }
			//   while ( v198 );
			//   v214 = 2LL;
			//   v215 = *(Color *)&v204.directColorMode;
			//   *v205 = v204.directColor;
			//   v216 = *(Color *)&v204.directCustomColor.a;
			//   v205[1] = v215;
			//   v217 = *(Color *)&v204.directSpecularIntensity;
			//   v205[2] = v216;
			//   v218 = *(Color *)&v204.indirectDiffuseFactor;
			//   v205[3] = v217;
			//   v219 = *(Color *)&v204.atmospherePitchYaw.x;
			//   v220 = src;
			//   v205[4] = v218;
			//   v205[5] = v219;
			//   v221 = (Color *)v315;
			//   *(_OWORD *)(v7 + 188) = v337;
			//   do
			//   {
			//     v221 += 8;
			//     v222 = v220.directColor;
			//     v223 = *(Color *)&v220.directColorMode;
			//     v220 = (HGLightConfig *)((char *)v220 + 128);
			//     v221[-8] = v222;
			//     v224 = *(Color *)&v220[-1].rotationAtmosphere.y;
			//     v221[-7] = v223;
			//     v225 = *(Color *)&v220[-1].rotationLightShaft.y;
			//     v221[-6] = v224;
			//     v226 = *(Color *)&v220[-1].rotationSunDisc.y;
			//     v221[-5] = v225;
			//     v227 = *(Color *)&v220[-1].rotationLensFlare.y;
			//     v221[-4] = v226;
			//     v228 = *(Color *)&v220[-1].rotationCloudShadow.y;
			//     v221[-3] = v227;
			//     v229 = *(Color *)&v220[-1].rotationHeightFogDirectionalInscattering.y;
			//     v221[-2] = v228;
			//     v221[-1] = v229;
			//     --v214;
			//   }
			//   while ( v214 );
			//   v230 = 2LL;
			//   v231 = *(Color *)&v220.directColorMode;
			//   *v221 = v220.directColor;
			//   v232 = *(Color *)&v220.directCustomColor.a;
			//   v221[1] = v231;
			//   v233 = *(Color *)&v220.directSpecularIntensity;
			//   v221[2] = v232;
			//   v234 = *(Color *)&v220.indirectDiffuseFactor;
			//   v221[3] = v233;
			//   v235 = *(Color *)&v220.atmospherePitchYaw.x;
			//   v236 = src;
			//   v221[4] = v234;
			//   v221[5] = v235;
			//   v237 = (Color *)v315;
			//   *(_OWORD *)(v7 + 204) = v338;
			//   do
			//   {
			//     v237 += 8;
			//     v238 = v236.directColor;
			//     v239 = *(Color *)&v236.directColorMode;
			//     v236 = (HGLightConfig *)((char *)v236 + 128);
			//     v237[-8] = v238;
			//     v240 = *(Color *)&v236[-1].rotationAtmosphere.y;
			//     v237[-7] = v239;
			//     v241 = *(Color *)&v236[-1].rotationLightShaft.y;
			//     v237[-6] = v240;
			//     v242 = *(Color *)&v236[-1].rotationSunDisc.y;
			//     v237[-5] = v241;
			//     v243 = *(Color *)&v236[-1].rotationLensFlare.y;
			//     v237[-4] = v242;
			//     v244 = *(Color *)&v236[-1].rotationCloudShadow.y;
			//     v237[-3] = v243;
			//     v245 = *(Color *)&v236[-1].rotationHeightFogDirectionalInscattering.y;
			//     v237[-2] = v244;
			//     v237[-1] = v245;
			//     --v230;
			//   }
			//   while ( v230 );
			//   v246 = 2LL;
			//   v247 = *(Color *)&v236.directColorMode;
			//   *v237 = v236.directColor;
			//   v248 = *(Color *)&v236.directCustomColor.a;
			//   v237[1] = v247;
			//   v249 = *(Color *)&v236.directSpecularIntensity;
			//   v237[2] = v248;
			//   v250 = *(Color *)&v236.indirectDiffuseFactor;
			//   v237[3] = v249;
			//   v251 = *(Color *)&v236.atmospherePitchYaw.x;
			//   v252 = src;
			//   v237[4] = v250;
			//   v237[5] = v251;
			//   v253 = (Color *)v315;
			//   *(_OWORD *)(v7 + 220) = v339;
			//   do
			//   {
			//     v253 += 8;
			//     v254 = v252.directColor;
			//     v255 = *(Color *)&v252.directColorMode;
			//     v252 = (HGLightConfig *)((char *)v252 + 128);
			//     v253[-8] = v254;
			//     v256 = *(Color *)&v252[-1].rotationAtmosphere.y;
			//     v253[-7] = v255;
			//     v257 = *(Color *)&v252[-1].rotationLightShaft.y;
			//     v253[-6] = v256;
			//     v258 = *(Color *)&v252[-1].rotationSunDisc.y;
			//     v253[-5] = v257;
			//     v259 = *(Color *)&v252[-1].rotationLensFlare.y;
			//     v253[-4] = v258;
			//     v260 = *(Color *)&v252[-1].rotationCloudShadow.y;
			//     v253[-3] = v259;
			//     v261 = *(Color *)&v252[-1].rotationHeightFogDirectionalInscattering.y;
			//     v253[-2] = v260;
			//     v253[-1] = v261;
			//     --v246;
			//   }
			//   while ( v246 );
			//   v262 = 2LL;
			//   v263 = *(Color *)&v252.directColorMode;
			//   *v253 = v252.directColor;
			//   v264 = *(Color *)&v252.directCustomColor.a;
			//   v253[1] = v263;
			//   v265 = *(Color *)&v252.directSpecularIntensity;
			//   v253[2] = v264;
			//   v266 = *(Color *)&v252.indirectDiffuseFactor;
			//   v253[3] = v265;
			//   v267 = *(Color *)&v252.atmospherePitchYaw.x;
			//   v253[4] = v266;
			//   v253[5] = v267;
			//   v268 = (Color *)v315;
			//   *(_DWORD *)(v7 + 236) = v322;
			//   v269 = src;
			//   do
			//   {
			//     v268 += 8;
			//     v270 = v269.directColor;
			//     v271 = *(Color *)&v269.directColorMode;
			//     v269 = (HGLightConfig *)((char *)v269 + 128);
			//     v268[-8] = v270;
			//     v272 = *(Color *)&v269[-1].rotationAtmosphere.y;
			//     v268[-7] = v271;
			//     v273 = *(Color *)&v269[-1].rotationLightShaft.y;
			//     v268[-6] = v272;
			//     v274 = *(Color *)&v269[-1].rotationSunDisc.y;
			//     v268[-5] = v273;
			//     v275 = *(Color *)&v269[-1].rotationLensFlare.y;
			//     v268[-4] = v274;
			//     v276 = *(Color *)&v269[-1].rotationCloudShadow.y;
			//     v268[-3] = v275;
			//     v277 = *(Color *)&v269[-1].rotationHeightFogDirectionalInscattering.y;
			//     v268[-2] = v276;
			//     v268[-1] = v277;
			//     --v262;
			//   }
			//   while ( v262 );
			//   v278 = 2LL;
			//   v279 = *(Color *)&v269.directColorMode;
			//   *v268 = v269.directColor;
			//   v280 = *(Color *)&v269.directCustomColor.a;
			//   v268[1] = v279;
			//   v281 = *(Color *)&v269.directSpecularIntensity;
			//   v268[2] = v280;
			//   v282 = *(Color *)&v269.indirectDiffuseFactor;
			//   v268[3] = v281;
			//   v283 = *(Color *)&v269.atmospherePitchYaw.x;
			//   v284 = src;
			//   v268[4] = v282;
			//   v268[5] = v283;
			//   v285 = (Color *)v315;
			//   v283.r = v324;
			//   *(_DWORD *)(v7 + 240) = v323;
			//   *(float *)(v7 + 244) = v283.r;
			//   do
			//   {
			//     v285 += 8;
			//     v286 = v284.directColor;
			//     v287 = *(Color *)&v284.directColorMode;
			//     v284 = (HGLightConfig *)((char *)v284 + 128);
			//     v285[-8] = v286;
			//     v288 = *(Color *)&v284[-1].rotationAtmosphere.y;
			//     v285[-7] = v287;
			//     v289 = *(Color *)&v284[-1].rotationLightShaft.y;
			//     v285[-6] = v288;
			//     v290 = *(Color *)&v284[-1].rotationSunDisc.y;
			//     v285[-5] = v289;
			//     v291 = *(Color *)&v284[-1].rotationLensFlare.y;
			//     v285[-4] = v290;
			//     v292 = *(Color *)&v284[-1].rotationCloudShadow.y;
			//     v285[-3] = v291;
			//     v293 = *(Color *)&v284[-1].rotationHeightFogDirectionalInscattering.y;
			//     v285[-2] = v292;
			//     v285[-1] = v293;
			//     --v278;
			//   }
			//   while ( v278 );
			//   v294 = *(Color *)&v284.directColorMode;
			//   *v285 = v284.directColor;
			//   v295 = *(Color *)&v284.directCustomColor.a;
			//   v285[1] = v294;
			//   v296 = *(Color *)&v284.directSpecularIntensity;
			//   v285[2] = v295;
			//   v297 = *(Color *)&v284.indirectDiffuseFactor;
			//   v285[3] = v296;
			//   v298 = *(Color *)&v284.atmospherePitchYaw.x;
			//   v299 = (Color *)v315;
			//   v285[4] = v297;
			//   v285[5] = v298;
			//   *(_DWORD *)(v7 + 24) = v316;
			//   do
			//   {
			//     v299 += 8;
			//     v300 = src.directColor;
			//     v301 = *(Color *)&src.directColorMode;
			//     src = (HGLightConfig *)((char *)src + 128);
			//     v299[-8] = v300;
			//     v302 = *(Color *)&src[-1].rotationAtmosphere.y;
			//     v299[-7] = v301;
			//     v303 = *(Color *)&src[-1].rotationLightShaft.y;
			//     v299[-6] = v302;
			//     v304 = *(Color *)&src[-1].rotationSunDisc.y;
			//     v299[-5] = v303;
			//     v305 = *(Color *)&src[-1].rotationLensFlare.y;
			//     v299[-4] = v304;
			//     v306 = *(Color *)&src[-1].rotationCloudShadow.y;
			//     v299[-3] = v305;
			//     v307 = *(Color *)&src[-1].rotationHeightFogDirectionalInscattering.y;
			//     v299[-2] = v306;
			//     v299[-1] = v307;
			//     --v5;
			//   }
			//   while ( v5 );
			//   v308 = *(Color *)&src.directColorMode;
			//   *v299 = src.directColor;
			//   v309 = *(Color *)&src.directCustomColor.a;
			//   v299[1] = v308;
			//   v310 = *(Color *)&src.directSpecularIntensity;
			//   v299[2] = v309;
			//   v311 = *(Color *)&src.indirectDiffuseFactor;
			//   v299[3] = v310;
			//   v312 = *(Color *)&src.atmospherePitchYaw.x;
			//   v299[4] = v311;
			//   v299[5] = v312;
			//   result = (HGLightConfigCPP *)v7;
			//   *(_DWORD *)(v7 + 28) = v317;
			//   return result;
			// }
			// 
			return null;
		}

		public unsafe static HGShadowConfigCPP* ConvertShadowConfigToCpp(HGShadowConfig src)
		{
			// // HGShadowConfigCPP* ConvertShadowConfigToCpp(HGShadowConfig)
			// HGShadowConfigCPP *HG::Rendering::Runtime::HGUtilsCpp::ConvertShadowConfigToCpp(
			//         HGShadowConfig *src,
			//         MethodInfo *method)
			// {
			//   HGShadowConfigCPP *v3; // rax
			//   __int64 v4; // rdx
			//   struct Object_1__Class *v5; // rcx
			//   HGShadowConfigCPP *v6; // rdi
			//   __m128i v7; // xmm2
			//   unsigned __int64 v8; // rsi
			//   Texture2D *csmRampTexture; // rax
			//   __int64 v10; // xmm1_8
			//   __int128 v11; // xmm2
			//   __m128i v12; // xmm0
			//   __m128i v13; // xmm3
			//   __m128i v14; // xmm2
			//   char v15; // al
			//   __m128i v16; // xmm2
			//   char v17; // al
			//   HGShadowConfigCPP *result; // rax
			// 
			//   if ( !byte_18D8EDB37 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryphEngineCode::HGRenderGraphCPP::AllocateTempFromCSharp<UnityEngine::HyperGryphEngineCode::HGShadowConfigCPP>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDB37 = 1;
			//   }
			//   v3 = UnityEngine::HyperGryphEngineCode::HGRenderGraphCPP::AllocateTempFromCSharp<UnityEngine::HyperGryphEngineCode::HGShadowConfigCPP>(MethodInfo::UnityEngine::HyperGryphEngineCode::HGRenderGraphCPP::AllocateTempFromCSharp<UnityEngine::HyperGryphEngineCode::HGShadowConfigCPP>);
			//   v6 = v3;
			//   if ( !v3 )
			//     goto LABEL_18;
			//   v3.csmDepthBias = src.csmDepthBiasV2;
			//   v3.csmNormalBias = src.csmNormalBiasV2;
			//   v7 = *(__m128i *)&src.csmIntensity;
			//   LODWORD(v3.csmIntensity) = v7.m128i_i32[0];
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v4);
			//   if ( !byte_18D8F4EAE )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAE = 1;
			//   }
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v4);
			//   if ( !byte_18D8F4EAF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAF = 1;
			//   }
			//   v8 = _mm_srli_si128(v7, 8).m128i_u64[0];
			//   if ( v8 )
			//   {
			//     v5 = TypeInfo::UnityEngine::Object;
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v4);
			//     if ( *(_QWORD *)(v8 + 16) )
			//     {
			//       csmRampTexture = src.csmRampTexture;
			//       if ( csmRampTexture )
			//         goto LABEL_17;
			// LABEL_18:
			//       sub_180B536AC(v5, v4);
			//     }
			//   }
			//   csmRampTexture = UnityEngine::Texture2D::get_blackTexture(0LL);
			//   if ( !csmRampTexture )
			//     goto LABEL_18;
			// LABEL_17:
			//   v10 = *(_QWORD *)&src.csmSimulatedAttenuation;
			//   v11 = *(_OWORD *)&src.csmShadowSoftness;
			//   v12 = _mm_cvtsi32_si128(src.contactShadowContract);
			//   v13 = *(__m128i *)&src.overrideCsmSpherePosition.z;
			//   v6.csmRampTexture = csmRampTexture.fields._._.m_CachedPtr;
			//   LODWORD(v6.csmShadowSoftness) = v11;
			//   v6.asmCasterMinY = src.asmCasterMinY;
			//   v6.asmCasterMaxY = src.asmCasterMaxY;
			//   v6.contactShadowIntensity = src.contactShadowIntensity;
			//   LODWORD(v6.contactShadowSurfaceThickness) = *(_OWORD *)&src.contactShadowSurfaceThickness;
			//   v6.contactShadowBilinearThreshold = src.contactShadowBilinearThreshold;
			//   v14 = *(__m128i *)&src.contactShadowSurfaceThickness;
			//   v6.contactShadowIgnoreEdgePixels = _mm_cvtsi128_si32(_mm_srli_si128(v14, 12));
			//   v15 = _mm_cvtsi128_si32(_mm_srli_si128(v14, 13));
			//   v16 = *(__m128i *)&src.overrideCsmFarDistance;
			//   v6.overrideCsmFarDistanceEnabled = v15;
			//   LODWORD(v6.overrideCsmFarDistance) = v16.m128i_i32[0];
			//   LODWORD(v6.contactShadowContract) = _mm_cvtepi32_ps(v12).m128_u32[0];
			//   v17 = _mm_cvtsi128_si32(_mm_srli_si128(v16, 4));
			//   v16.m128i_i64[0] = *(_QWORD *)&src.overrideCsmSpherePosition.x;
			//   v12.m128i_i64[0] = v10;
			//   *(float *)&v10 = src.overrideCsmSphereRadius;
			//   v6.manualOverrideCsmRendering = v17;
			//   v6.disableCsm = *(_DWORD *)&src.disableCsm;
			//   LODWORD(v6.overrideCsmSphereRadius) = v10;
			//   *(float *)&v10 = src.disableCsmBlendFactor;
			//   *(_QWORD *)&v6.overrideCsmSpherePosition.x = v16.m128i_i64[0];
			//   v6.disableAsm = v12.m128i_i8[4];
			//   result = v6;
			//   LODWORD(v6.disableCsmBlendFactor) = v10;
			//   LODWORD(v6.csmSimulatedAttenuation) = v12.m128i_i32[0];
			//   LODWORD(v6.overrideCsmSpherePosition.z) = _mm_cvtsi128_si32(v13);
			//   return result;
			// }
			// 
			return null;
		}

		public unsafe static HGHeightFogConfigCPP* ConvertHeightFogConfigToCpp(HGHeightFogConfig src)
		{
			// // HGHeightFogConfigCPP* ConvertHeightFogConfigToCpp(HGHeightFogConfig)
			// HGHeightFogConfigCPP *HG::Rendering::Runtime::HGUtilsCpp::ConvertHeightFogConfigToCpp(
			//         HGHeightFogConfig *src,
			//         MethodInfo *method)
			// {
			//   __int64 (__fastcall *v2)(__int64, MethodInfo *); // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rax
			//   __int128 v6; // xmm0
			//   __int128 v7; // xmm1
			//   unsigned __int128 v8; // xmm0
			//   __int128 v9; // xmm0
			//   __int64 v10; // rax
			//   __int128 v11; // xmm1
			//   unsigned __int128 v12; // xmm1
			//   __int128 v13; // xmm1
			//   __int128 v14; // xmm0
			//   unsigned __int128 v15; // xmm1
			//   __int128 v16; // xmm0
			//   __int128 v17; // xmm1
			//   __int128 v18; // xmm1
			//   unsigned __int128 v19; // xmm1
			//   __int128 v20; // xmm1
			//   __int128 v21; // xmm1
			//   __int128 v22; // xmm0
			//   unsigned __int128 v23; // xmm1
			//   __int128 v24; // xmm1
			//   __int128 v25; // xmm0
			//   __int128 v26; // xmm1
			//   __int128 v27; // xmm1
			//   __int128 v28; // xmm0
			//   unsigned __int128 v29; // xmm1
			//   __int128 v30; // xmm1
			//   __int128 v31; // xmm0
			//   unsigned __int128 v32; // xmm1
			//   __int128 v33; // xmm1
			//   unsigned __int128 v34; // xmm1
			//   __int128 v35; // xmm1
			//   __int128 v36; // xmm0
			//   unsigned __int128 v37; // xmm1
			//   __int128 v38; // xmm1
			//   __int128 v39; // xmm0
			//   unsigned __int128 v40; // xmm1
			//   __int128 v41; // xmm0
			//   __int128 v42; // xmm1
			//   __int128 v43; // xmm0
			//   unsigned __int128 v44; // xmm1
			//   __int128 v45; // xmm1
			//   __int128 v46; // xmm0
			//   unsigned __int128 v47; // xmm1
			//   __int128 v48; // xmm1
			//   unsigned __int128 v49; // xmm1
			//   __int128 v50; // xmm1
			//   __int128 v51; // xmm0
			//   unsigned __int128 v52; // xmm1
			//   __int128 v53; // xmm0
			//   __int64 v54; // rax
			//   __int128 v55; // xmm0
			//   unsigned __int128 v56; // xmm1
			//   __int128 v57; // xmm1
			//   __int128 v58; // xmm0
			//   unsigned __int128 v59; // xmm1
			//   __int128 v60; // xmm1
			//   unsigned __int128 v61; // xmm1
			//   __int128 v62; // xmm1
			//   __int128 v63; // xmm0
			//   unsigned __int128 v64; // xmm1
			//   __int128 v65; // xmm1
			//   __int128 v66; // xmm0
			//   unsigned __int128 v67; // xmm1
			//   __int128 v68; // xmm0
			//   __int128 v69; // xmm1
			//   __int128 v70; // xmm0
			//   unsigned __int128 v71; // xmm1
			//   __int128 v72; // xmm1
			//   __int128 v73; // xmm0
			//   unsigned __int128 v74; // xmm1
			//   __int128 v75; // xmm1
			//   unsigned __int128 v76; // xmm1
			//   __int128 v77; // xmm1
			//   __int128 v78; // xmm0
			//   unsigned __int128 v79; // xmm1
			//   __int128 v80; // xmm1
			//   __int128 v81; // xmm0
			//   __int64 v82; // rax
			//   __int128 v83; // xmm1
			//   unsigned __int128 v84; // xmm1
			//   __int128 v85; // xmm1
			//   __int128 v86; // xmm0
			//   unsigned __int128 v87; // xmm1
			//   __int128 v88; // xmm0
			//   __int128 v89; // xmm1
			//   unsigned __int128 v90; // xmm1
			//   __int128 v91; // xmm1
			//   __int128 v92; // xmm0
			//   unsigned __int128 v93; // xmm1
			//   __int64 v94; // rax
			//   __int128 v95; // xmm1
			//   __int128 v96; // xmm0
			//   unsigned __int128 v97; // xmm1
			//   HGHeightFogConfigCPP *result; // rax
			//   __int64 v99; // rax
			//   __int128 v100; // [rsp+20h] [rbp-79h]
			//   __int128 v101; // [rsp+20h] [rbp-79h]
			//   __int128 v102; // [rsp+20h] [rbp-79h]
			//   int v103; // [rsp+30h] [rbp-69h]
			//   int v104; // [rsp+34h] [rbp-65h]
			//   int v105; // [rsp+38h] [rbp-61h]
			//   _BYTE v106[20]; // [rsp+3Ch] [rbp-5Dh]
			//   int v107; // [rsp+50h] [rbp-49h]
			//   __int128 v108; // [rsp+50h] [rbp-49h]
			//   int v109; // [rsp+54h] [rbp-45h]
			//   int v110; // [rsp+58h] [rbp-41h]
			//   int v111; // [rsp+60h] [rbp-39h]
			//   __m256i v112; // [rsp+60h] [rbp-39h]
			//   int v113; // [rsp+64h] [rbp-35h]
			//   _BYTE v114[48]; // [rsp+80h] [rbp-19h] BYREF
			//   __int128 v115; // [rsp+B0h] [rbp+17h]
			//   __int128 v116; // [rsp+C0h] [rbp+27h]
			//   unsigned __int128 v117; // [rsp+D0h] [rbp+37h]
			//   __int64 v118; // [rsp+E0h] [rbp+47h]
			// 
			//   v2 = (__int64 (__fastcall *)(__int64, MethodInfo *))qword_18D8F57F8;
			//   if ( !qword_18D8F57F8 )
			//   {
			//     v2 = (__int64 (__fastcall *)(__int64, MethodInfo *))il2cpp_resolve_icall_0(
			//                                                           "UnityEngine.HyperGryphEngineCode.HGRenderGraphCPP::AllocateTem"
			//                                                           "pFromCSharp(System.Int64)");
			//     if ( !v2 )
			//     {
			//       v99 = sub_1802DBBE8("UnityEngine.HyperGryphEngineCode.HGRenderGraphCPP::AllocateTempFromCSharp(System.Int64)");
			//       sub_18000F750(v99, 0LL);
			//     }
			//     qword_18D8F57F8 = (__int64)v2;
			//   }
			//   v4 = v2(196LL, method);
			//   v5 = *(_QWORD *)&src.flowNoiseSpeed;
			//   v100 = *(_OWORD *)&src.enable;
			//   v6 = *(_OWORD *)&src.volumetricFogNearFadeInDistance;
			//   *(_OWORD *)&v114[32] = *(_OWORD *)&src.volumetricFogEmissive.a;
			//   v7 = *(_OWORD *)&src.flowNoiseIntensity;
			//   v115 = v6;
			//   v8 = *(_OWORD *)&src.flowNoiseVerticalDirAngle;
			//   v116 = v7;
			//   v117 = v8;
			//   v118 = v5;
			//   if ( !v4 )
			//     sub_180B536AC(&v114[32], 0LL);
			//   v9 = *(_OWORD *)&src.enable;
			//   *(_BYTE *)v4 = v100;
			//   v10 = *(_QWORD *)&src.flowNoiseSpeed;
			//   v11 = *(_OWORD *)&src.volumetricFogNearFadeInDistance;
			//   *(_OWORD *)&v114[32] = *(_OWORD *)&src.volumetricFogEmissive.a;
			//   v115 = v11;
			//   v12 = *(_OWORD *)&src.flowNoiseVerticalDirAngle;
			//   v116 = *(_OWORD *)&src.flowNoiseIntensity;
			//   v117 = v12;
			//   v118 = v10;
			//   *(_DWORD *)(v4 + 4) = DWORD1(v9);
			//   v101 = *(_OWORD *)&src.enable;
			//   v13 = *(_OWORD *)&src.volumetricFogNearFadeInDistance;
			//   *(_OWORD *)&v114[32] = *(_OWORD *)&src.volumetricFogEmissive.a;
			//   v14 = *(_OWORD *)&src.flowNoiseIntensity;
			//   v115 = v13;
			//   v15 = *(_OWORD *)&src.flowNoiseVerticalDirAngle;
			//   v116 = v14;
			//   v117 = v15;
			//   v118 = v10;
			//   *(_DWORD *)(v4 + 8) = DWORD2(v101);
			//   v102 = *(_OWORD *)&src.enable;
			//   *(_OWORD *)&v114[32] = *(_OWORD *)&src.volumetricFogEmissive.a;
			//   v16 = *(_OWORD *)&src.flowNoiseIntensity;
			//   v115 = *(_OWORD *)&src.volumetricFogNearFadeInDistance;
			//   v116 = v16;
			//   v117 = *(_OWORD *)&src.flowNoiseVerticalDirAngle;
			//   v118 = v10;
			//   v17 = *(_OWORD *)&src.heightFogStartHeightSecond;
			//   *(_DWORD *)(v4 + 12) = HIDWORD(v102);
			//   v103 = v17;
			//   v18 = *(_OWORD *)&src.volumetricFogNearFadeInDistance;
			//   *(_OWORD *)&v114[32] = *(_OWORD *)&src.volumetricFogEmissive.a;
			//   v115 = v18;
			//   v19 = *(_OWORD *)&src.flowNoiseVerticalDirAngle;
			//   v116 = *(_OWORD *)&src.flowNoiseIntensity;
			//   v117 = v19;
			//   v118 = v10;
			//   v20 = *(_OWORD *)&src.heightFogStartHeightSecond;
			//   *(_DWORD *)(v4 + 16) = v103;
			//   v104 = DWORD1(v20);
			//   v21 = *(_OWORD *)&src.volumetricFogNearFadeInDistance;
			//   *(_OWORD *)&v114[32] = *(_OWORD *)&src.volumetricFogEmissive.a;
			//   v22 = *(_OWORD *)&src.flowNoiseIntensity;
			//   v115 = v21;
			//   v23 = *(_OWORD *)&src.flowNoiseVerticalDirAngle;
			//   v116 = v22;
			//   v117 = v23;
			//   v118 = v10;
			//   v24 = *(_OWORD *)&src.heightFogStartHeightSecond;
			//   *(_DWORD *)(v4 + 20) = v104;
			//   v105 = DWORD2(v24);
			//   *(_OWORD *)&v114[32] = *(_OWORD *)&src.volumetricFogEmissive.a;
			//   v25 = *(_OWORD *)&src.flowNoiseIntensity;
			//   v115 = *(_OWORD *)&src.volumetricFogNearFadeInDistance;
			//   v116 = v25;
			//   v117 = *(_OWORD *)&src.flowNoiseVerticalDirAngle;
			//   v118 = v10;
			//   v26 = *(_OWORD *)&src.heightFogStartHeightSecond;
			//   *(_DWORD *)(v4 + 24) = v105;
			//   *(_DWORD *)v106 = HIDWORD(v26);
			//   *(_OWORD *)&v106[4] = *(_OWORD *)&src.heightFogInscatter.g;
			//   v27 = *(_OWORD *)&src.volumetricFogNearFadeInDistance;
			//   *(_OWORD *)&v114[32] = *(_OWORD *)&src.volumetricFogEmissive.a;
			//   v28 = *(_OWORD *)&src.flowNoiseIntensity;
			//   v115 = v27;
			//   v29 = *(_OWORD *)&src.flowNoiseVerticalDirAngle;
			//   v116 = v28;
			//   v117 = v29;
			//   v118 = v10;
			//   *(_OWORD *)(v4 + 28) = *(_OWORD *)v106;
			//   *(_DWORD *)&v106[16] = HIDWORD(*(_OWORD *)&src.heightFogInscatter.g);
			//   v30 = *(_OWORD *)&src.volumetricFogNearFadeInDistance;
			//   *(_OWORD *)&v114[32] = *(_OWORD *)&src.volumetricFogEmissive.a;
			//   v31 = *(_OWORD *)&src.flowNoiseIntensity;
			//   v115 = v30;
			//   v32 = *(_OWORD *)&src.flowNoiseVerticalDirAngle;
			//   v116 = v31;
			//   v117 = v32;
			//   v118 = v10;
			//   *(_DWORD *)(v4 + 44) = *(_DWORD *)&v106[16];
			//   v107 = *(_OWORD *)&src.heightFogStartDistance;
			//   v33 = *(_OWORD *)&src.volumetricFogNearFadeInDistance;
			//   *(_OWORD *)&v114[32] = *(_OWORD *)&src.volumetricFogEmissive.a;
			//   v115 = v33;
			//   v34 = *(_OWORD *)&src.flowNoiseVerticalDirAngle;
			//   v116 = *(_OWORD *)&src.flowNoiseIntensity;
			//   v117 = v34;
			//   v118 = v10;
			//   *(_DWORD *)(v4 + 48) = v107;
			//   v109 = HIDWORD(*(_QWORD *)&src.heightFogStartDistance);
			//   v35 = *(_OWORD *)&src.volumetricFogNearFadeInDistance;
			//   *(_OWORD *)&v114[32] = *(_OWORD *)&src.volumetricFogEmissive.a;
			//   v36 = *(_OWORD *)&src.flowNoiseIntensity;
			//   v115 = v35;
			//   v37 = *(_OWORD *)&src.flowNoiseVerticalDirAngle;
			//   v116 = v36;
			//   v117 = v37;
			//   v118 = v10;
			//   *(_DWORD *)(v4 + 52) = v109;
			//   v110 = *(_QWORD *)&src.heightFogCutoffDistance;
			//   v38 = *(_OWORD *)&src.volumetricFogNearFadeInDistance;
			//   *(_OWORD *)&v114[32] = *(_OWORD *)&src.volumetricFogEmissive.a;
			//   v39 = *(_OWORD *)&src.flowNoiseIntensity;
			//   v115 = v38;
			//   v40 = *(_OWORD *)&src.flowNoiseVerticalDirAngle;
			//   v116 = v39;
			//   v117 = v40;
			//   v118 = v10;
			//   *(_DWORD *)(v4 + 56) = v110;
			//   v108 = *(_OWORD *)&src.heightFogStartDistance;
			//   *(_OWORD *)&v114[32] = *(_OWORD *)&src.volumetricFogEmissive.a;
			//   v41 = *(_OWORD *)&src.flowNoiseIntensity;
			//   v115 = *(_OWORD *)&src.volumetricFogNearFadeInDistance;
			//   v116 = v41;
			//   v117 = *(_OWORD *)&src.flowNoiseVerticalDirAngle;
			//   v118 = v10;
			//   *(_DWORD *)(v4 + 60) = HIDWORD(v108);
			//   v111 = *(_OWORD *)&src.heightFogCullingFarClipPlane;
			//   v42 = *(_OWORD *)&src.volumetricFogNearFadeInDistance;
			//   *(_OWORD *)&v114[32] = *(_OWORD *)&src.volumetricFogEmissive.a;
			//   v43 = *(_OWORD *)&src.flowNoiseIntensity;
			//   v115 = v42;
			//   v44 = *(_OWORD *)&src.flowNoiseVerticalDirAngle;
			//   v116 = v43;
			//   v117 = v44;
			//   v118 = v10;
			//   *(_DWORD *)(v4 + 64) = v111;
			//   v113 = HIDWORD(*(_QWORD *)&src.heightFogCullingFarClipPlane);
			//   v45 = *(_OWORD *)&src.volumetricFogNearFadeInDistance;
			//   *(_OWORD *)&v114[32] = *(_OWORD *)&src.volumetricFogEmissive.a;
			//   v46 = *(_OWORD *)&src.flowNoiseIntensity;
			//   v115 = v45;
			//   v47 = *(_OWORD *)&src.flowNoiseVerticalDirAngle;
			//   v116 = v46;
			//   v117 = v47;
			//   v118 = v10;
			//   *(_DWORD *)(v4 + 68) = v113;
			//   *(_OWORD *)v112.m256i_i8 = *(_OWORD *)&src.heightFogCullingFarClipPlane;
			//   v48 = *(_OWORD *)&src.volumetricFogNearFadeInDistance;
			//   *(_OWORD *)&v114[32] = *(_OWORD *)&src.volumetricFogEmissive.a;
			//   v115 = v48;
			//   v49 = *(_OWORD *)&src.flowNoiseVerticalDirAngle;
			//   v116 = *(_OWORD *)&src.flowNoiseIntensity;
			//   v117 = v49;
			//   v118 = v10;
			//   *(_DWORD *)(v4 + 72) = v112.m256i_i32[2];
			//   v112.m256i_i32[3] = HIDWORD(*(_OWORD *)&src.heightFogCullingFarClipPlane);
			//   *(_OWORD *)&v112.m256i_u64[2] = *(_OWORD *)&src.heightFogDirectionalInscattering.g;
			//   v50 = *(_OWORD *)&src.volumetricFogNearFadeInDistance;
			//   *(_OWORD *)&v114[32] = *(_OWORD *)&src.volumetricFogEmissive.a;
			//   v51 = *(_OWORD *)&src.flowNoiseIntensity;
			//   v115 = v50;
			//   v52 = *(_OWORD *)&src.flowNoiseVerticalDirAngle;
			//   v116 = v51;
			//   v117 = v52;
			//   v118 = v10;
			//   *(_OWORD *)(v4 + 76) = *(_OWORD *)((char *)&v112.m256i_u64[1] + 4);
			//   v112.m256i_i8[28] = BYTE12(*(_OWORD *)&src.heightFogDirectionalInscattering.g);
			//   *(_OWORD *)&v114[32] = *(_OWORD *)&src.volumetricFogEmissive.a;
			//   v53 = *(_OWORD *)&src.flowNoiseIntensity;
			//   v115 = *(_OWORD *)&src.volumetricFogNearFadeInDistance;
			//   v116 = v53;
			//   v117 = *(_OWORD *)&src.flowNoiseVerticalDirAngle;
			//   v118 = v10;
			//   *(_BYTE *)(v4 + 92) = v112.m256i_i8[28];
			//   v54 = *(_QWORD *)&src.flowNoiseSpeed;
			//   *(_DWORD *)v114 = *(_OWORD *)&src.volumetricFogScatteringDistribution;
			//   *(_OWORD *)&v114[32] = *(_OWORD *)&src.volumetricFogEmissive.a;
			//   v55 = *(_OWORD *)&src.flowNoiseIntensity;
			//   v115 = *(_OWORD *)&src.volumetricFogNearFadeInDistance;
			//   v56 = *(_OWORD *)&src.flowNoiseVerticalDirAngle;
			//   v116 = v55;
			//   v117 = v56;
			//   v118 = v54;
			//   *(_DWORD *)(v4 + 96) = *(_DWORD *)v114;
			//   *(_OWORD *)v114 = *(_OWORD *)&src.volumetricFogScatteringDistribution;
			//   *(_OWORD *)&v114[16] = *(_OWORD *)&src.volumetricFogAlbedo.a;
			//   v57 = *(_OWORD *)&src.volumetricFogNearFadeInDistance;
			//   *(_OWORD *)&v114[32] = *(_OWORD *)&src.volumetricFogEmissive.a;
			//   v58 = *(_OWORD *)&src.flowNoiseIntensity;
			//   v115 = v57;
			//   v59 = *(_OWORD *)&src.flowNoiseVerticalDirAngle;
			//   v116 = v58;
			//   v117 = v59;
			//   v118 = v54;
			//   *(_OWORD *)(v4 + 100) = *(_OWORD *)&v114[4];
			//   *(_OWORD *)&v114[16] = *(_OWORD *)&src.volumetricFogAlbedo.a;
			//   v60 = *(_OWORD *)&src.volumetricFogNearFadeInDistance;
			//   *(_OWORD *)&v114[32] = *(_OWORD *)&src.volumetricFogEmissive.a;
			//   v115 = v60;
			//   v61 = *(_OWORD *)&src.flowNoiseVerticalDirAngle;
			//   v116 = *(_OWORD *)&src.flowNoiseIntensity;
			//   v117 = v61;
			//   v118 = v54;
			//   *(_OWORD *)(v4 + 116) = *(_OWORD *)&v114[20];
			//   v62 = *(_OWORD *)&src.volumetricFogNearFadeInDistance;
			//   *(_OWORD *)&v114[32] = *(_OWORD *)&src.volumetricFogEmissive.a;
			//   v63 = *(_OWORD *)&src.flowNoiseIntensity;
			//   v115 = v62;
			//   v64 = *(_OWORD *)&src.flowNoiseVerticalDirAngle;
			//   v116 = v63;
			//   v117 = v64;
			//   v118 = v54;
			//   *(_DWORD *)(v4 + 132) = *(_DWORD *)&v114[36];
			//   v65 = *(_OWORD *)&src.volumetricFogNearFadeInDistance;
			//   *(_OWORD *)&v114[32] = *(_OWORD *)&src.volumetricFogEmissive.a;
			//   v66 = *(_OWORD *)&src.flowNoiseIntensity;
			//   v115 = v65;
			//   v67 = *(_OWORD *)&src.flowNoiseVerticalDirAngle;
			//   v116 = v66;
			//   v117 = v67;
			//   v118 = v54;
			//   *(_DWORD *)(v4 + 136) = *(_DWORD *)&v114[40];
			//   *(_OWORD *)&v114[32] = *(_OWORD *)&src.volumetricFogEmissive.a;
			//   v68 = *(_OWORD *)&src.flowNoiseIntensity;
			//   v115 = *(_OWORD *)&src.volumetricFogNearFadeInDistance;
			//   v116 = v68;
			//   v117 = *(_OWORD *)&src.flowNoiseVerticalDirAngle;
			//   v118 = v54;
			//   *(_DWORD *)(v4 + 140) = *(_DWORD *)&v114[44];
			//   v69 = *(_OWORD *)&src.volumetricFogNearFadeInDistance;
			//   *(_OWORD *)&v114[32] = *(_OWORD *)&src.volumetricFogEmissive.a;
			//   v70 = *(_OWORD *)&src.flowNoiseIntensity;
			//   v115 = v69;
			//   v71 = *(_OWORD *)&src.flowNoiseVerticalDirAngle;
			//   v116 = v70;
			//   v117 = v71;
			//   v118 = v54;
			//   *(_DWORD *)(v4 + 144) = v115;
			//   v72 = *(_OWORD *)&src.volumetricFogNearFadeInDistance;
			//   *(_OWORD *)&v114[32] = *(_OWORD *)&src.volumetricFogEmissive.a;
			//   v73 = *(_OWORD *)&src.flowNoiseIntensity;
			//   v115 = v72;
			//   v74 = *(_OWORD *)&src.flowNoiseVerticalDirAngle;
			//   v116 = v73;
			//   v117 = v74;
			//   v118 = v54;
			//   *(_DWORD *)(v4 + 148) = DWORD1(v115);
			//   v75 = *(_OWORD *)&src.volumetricFogNearFadeInDistance;
			//   *(_OWORD *)&v114[32] = *(_OWORD *)&src.volumetricFogEmissive.a;
			//   v115 = v75;
			//   v76 = *(_OWORD *)&src.flowNoiseVerticalDirAngle;
			//   v116 = *(_OWORD *)&src.flowNoiseIntensity;
			//   v117 = v76;
			//   v118 = v54;
			//   *(_DWORD *)(v4 + 152) = DWORD2(v115);
			//   v77 = *(_OWORD *)&src.volumetricFogNearFadeInDistance;
			//   *(_OWORD *)&v114[32] = *(_OWORD *)&src.volumetricFogEmissive.a;
			//   v78 = *(_OWORD *)&src.flowNoiseIntensity;
			//   v115 = v77;
			//   v79 = *(_OWORD *)&src.flowNoiseVerticalDirAngle;
			//   v116 = v78;
			//   v117 = v79;
			//   v118 = v54;
			//   *(_BYTE *)(v4 + 156) = BYTE12(v115);
			//   v80 = *(_OWORD *)&src.volumetricFogNearFadeInDistance;
			//   *(_OWORD *)&v114[32] = *(_OWORD *)&src.volumetricFogEmissive.a;
			//   v81 = *(_OWORD *)&src.flowNoiseIntensity;
			//   v115 = v80;
			//   v116 = v81;
			//   v82 = *(_QWORD *)&src.flowNoiseSpeed;
			//   v117 = *(_OWORD *)&src.flowNoiseVerticalDirAngle;
			//   v118 = v82;
			//   *(_DWORD *)(v4 + 160) = v81;
			//   v83 = *(_OWORD *)&src.volumetricFogNearFadeInDistance;
			//   *(_OWORD *)&v114[32] = *(_OWORD *)&src.volumetricFogEmissive.a;
			//   v115 = v83;
			//   v84 = *(_OWORD *)&src.flowNoiseVerticalDirAngle;
			//   v116 = *(_OWORD *)&src.flowNoiseIntensity;
			//   v117 = v84;
			//   v118 = v82;
			//   *(_DWORD *)(v4 + 164) = DWORD1(v116);
			//   v85 = *(_OWORD *)&src.volumetricFogNearFadeInDistance;
			//   *(_OWORD *)&v114[32] = *(_OWORD *)&src.volumetricFogEmissive.a;
			//   v86 = *(_OWORD *)&src.flowNoiseIntensity;
			//   v115 = v85;
			//   v87 = *(_OWORD *)&src.flowNoiseVerticalDirAngle;
			//   v116 = v86;
			//   v117 = v87;
			//   v118 = v82;
			//   *(_DWORD *)(v4 + 168) = DWORD2(v86);
			//   *(_OWORD *)&v114[32] = *(_OWORD *)&src.volumetricFogEmissive.a;
			//   v88 = *(_OWORD *)&src.flowNoiseIntensity;
			//   v115 = *(_OWORD *)&src.volumetricFogNearFadeInDistance;
			//   v116 = v88;
			//   v117 = *(_OWORD *)&src.flowNoiseVerticalDirAngle;
			//   v118 = v82;
			//   *(_DWORD *)(v4 + 172) = HIDWORD(v88);
			//   v89 = *(_OWORD *)&src.volumetricFogNearFadeInDistance;
			//   *(_OWORD *)&v114[32] = *(_OWORD *)&src.volumetricFogEmissive.a;
			//   v115 = v89;
			//   v90 = *(_OWORD *)&src.flowNoiseVerticalDirAngle;
			//   v116 = *(_OWORD *)&src.flowNoiseIntensity;
			//   v117 = v90;
			//   v118 = v82;
			//   *(_DWORD *)(v4 + 176) = v90;
			//   v91 = *(_OWORD *)&src.volumetricFogNearFadeInDistance;
			//   *(_OWORD *)&v114[32] = *(_OWORD *)&src.volumetricFogEmissive.a;
			//   v92 = *(_OWORD *)&src.flowNoiseIntensity;
			//   v115 = v91;
			//   v93 = *(_OWORD *)&src.flowNoiseVerticalDirAngle;
			//   v116 = v92;
			//   v117 = v93;
			//   v118 = v82;
			//   *(_QWORD *)(v4 + 180) = v93 >> 32;
			//   *(_DWORD *)(v4 + 188) = HIDWORD(v93);
			//   v94 = *(_QWORD *)&src.flowNoiseSpeed;
			//   v95 = *(_OWORD *)&src.volumetricFogNearFadeInDistance;
			//   *(_OWORD *)&v114[32] = *(_OWORD *)&src.volumetricFogEmissive.a;
			//   v96 = *(_OWORD *)&src.flowNoiseIntensity;
			//   v115 = v95;
			//   v97 = *(_OWORD *)&src.flowNoiseVerticalDirAngle;
			//   v116 = v96;
			//   v117 = v97;
			//   v118 = v94;
			//   result = (HGHeightFogConfigCPP *)v4;
			//   *(_DWORD *)(v4 + 192) = v118;
			//   return result;
			// }
			// 
			return null;
		}

		public unsafe static void ConvertVignetteToCPP(VignetteCPP* dst, Vignette src)
		{
			// // Void ConvertVignetteToCPP(VignetteCPP*, Vignette)
			// void HG::Rendering::Runtime::HGUtilsCpp::ConvertVignetteToCPP(VignetteCPP *dst, Vignette *src, MethodInfo *method)
			// {
			//   Vignette *v3; // rdi
			//   VignetteCPP *v4; // rbx
			//   int32_t v5; // eax
			//   ColorParameter *color; // rsi
			//   Vignette **center; // rsi
			//   float v8; // xmm6_4
			//   Vector2 (*rounded)(PQSFilter *, MethodInfo *); // rax
			//   __m128 v10; // xmm1
			//   ClampedFloatParameter *intensity; // rsi
			//   const MethodInfo *v12; // r8
			//   float a; // xmm0_4
			//   ClampedFloatParameter *smoothness; // rsi
			//   const MethodInfo *v15; // r8
			//   float stepDownOffset; // xmm0_4
			//   ClampedFloatParameter *roundness; // rsi
			//   const MethodInfo *v18; // r8
			//   float v19; // xmm0_4
			//   __int64 v20; // rsi
			//   void *v21; // rax
			//   Object *opacity; // rdi
			//   float (*typeMetadataHandle)(AbilitySystem *, MethodInfo *); // r8
			//   double v24; // xmm0_8
			//   ClampedFloatParameter__Class *klass; // rax
			//   ClampedFloatParameter__Class *v26; // rax
			//   ClampedFloatParameter__Class *v27; // rax
			//   Object__Class *v28; // rax
			//   ILFixDynamicMethodWrapper *Patch; // rax
			//   ILFixDynamicMethodWrapper *v30; // rax
			//   ILFixDynamicMethodWrapper *v31; // rax
			//   __int64 v32; // rax
			//   ILFixDynamicMethodWrapper *v33; // rax
			//   char v34[16]; // [rsp+20h] [rbp-38h] BYREF
			// 
			//   v3 = src;
			//   v4 = dst;
			//   if ( !byte_18D8EDB38 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDB38 = 1;
			//   }
			//   if ( !v3 )
			//     goto LABEL_85;
			//   src = (Vignette *)v3.fields.mode;
			//   if ( !src )
			//     goto LABEL_85;
			//   v5 = sub_18003ED00(10LL);
			//   if ( !v4 )
			//     goto LABEL_85;
			//   v4.mode = v5;
			//   color = v3.fields.color;
			//   if ( !color )
			//     goto LABEL_85;
			//   sub_180003EE0(color.klass);
			//   v4.color = *(Color *)((__int64 (__fastcall *)(char *, ColorParameter *, Il2CppMethodPointer))color.klass.vtable.get_value.method)(
			//                           v34,
			//                           color,
			//                           color.klass.vtable.set_value.methodPtr);
			//   center = (Vignette **)v3.fields.center;
			//   if ( !center )
			//     goto LABEL_85;
			//   sub_180003EE0(*center);
			//   src = *center;
			//   dst = (VignetteCPP *)Beyond::Gameplay::Core::PQSFilter::get_factorRange;
			//   v8 = 0.0;
			//   rounded = (Vector2 (*)(PQSFilter *, MethodInfo *))(*center)[3].fields.rounded;
			//   if ( rounded == Beyond::Gameplay::Core::PQSFilter::get_factorRange )
			//     v10 = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL);
			//   else
			//     v10 = (__m128)(unsigned __int64)((__int64 (__fastcall *)(Vignette **, BoolParameter *))rounded)(
			//                                       center,
			//                                       src[3].fields.blink);
			//   LODWORD(v4.center.x) = v10.m128_i32[0];
			//   LODWORD(v4.center.y) = _mm_shuffle_ps(v10, v10, 85).m128_u32[0];
			//   intensity = v3.fields.intensity;
			//   if ( !intensity )
			//     goto LABEL_85;
			//   sub_180003EE0(intensity.klass);
			//   v12 = intensity.klass.vtable.get_value.method;
			//   src = (Vignette *)intensity.klass.vtable.set_value.methodPtr;
			//   if ( v12 == (const MethodInfo *)Beyond::Gameplay::Core::AbilitySystem::get_detectedRadius )
			//   {
			//     klass = intensity[11].klass;
			//     if ( !klass )
			//       goto LABEL_85;
			//     dst = (VignetteCPP *)klass._0.name;
			//     if ( !dst )
			//       goto LABEL_85;
			//     a = dst.color.a;
			//   }
			//   else if ( v12 == (const MethodInfo *)Beyond::NPC::Animation::AnimatorClothCalculator::AnimatorLookAtControllerHolder::get_weightBase )
			//   {
			//     if ( !byte_18D8EB3CE )
			//     {
			//       sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//       byte_18D8EB3CE = 1;
			//     }
			//     dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, src);
			//       dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     src = **(Vignette ***)&dst[2].opacity;
			//     if ( !src )
			//       goto LABEL_85;
			//     if ( *(int *)&src.fields._.active <= 1833 )
			//       goto LABEL_139;
			//     if ( !LODWORD(dst[3].smoothness) )
			//     {
			//       il2cpp_runtime_class_init_0(dst, src);
			//       dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     dst = **(VignetteCPP ***)&dst[2].opacity;
			//     if ( !dst )
			//       goto LABEL_85;
			//     if ( LODWORD(dst.center.y) <= 0x729 )
			//       goto LABEL_136;
			//     if ( *(_QWORD *)&dst[229].rounded )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(1833, 0LL);
			//       if ( !Patch )
			//         goto LABEL_85;
			//       a = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_43(
			//             (ILFixDynamicMethodWrapper_16 *)Patch,
			//             (Object *)intensity,
			//             0LL);
			//     }
			//     else
			//     {
			// LABEL_139:
			//       if ( *(_QWORD *)&intensity.fields.min )
			//         a = *(float *)(*(_QWORD *)&intensity.fields.min + 204LL);
			//       else
			//         a = 0.0;
			//     }
			//   }
			//   else if ( v12 == (const MethodInfo *)Beyond::Gameplay::Core::MovePipelineGroundBase::get_stepDownOffset )
			//   {
			//     dst = (VignetteCPP *)intensity.fields._._._;
			//     if ( !dst )
			//       goto LABEL_85;
			//     a = Beyond::Gameplay::Core::MovementComponent::get_stepDownOffset((MovementComponent *)dst, 0LL);
			//   }
			//   else
			//   {
			//     a = ((float (__fastcall *)(ClampedFloatParameter *, Vignette *))v12)(intensity, src);
			//   }
			//   v4.intensity = a;
			//   smoothness = v3.fields.smoothness;
			//   if ( !smoothness )
			//     goto LABEL_85;
			//   sub_180003EE0(smoothness.klass);
			//   v15 = smoothness.klass.vtable.get_value.method;
			//   src = (Vignette *)smoothness.klass.vtable.set_value.methodPtr;
			//   if ( v15 == (const MethodInfo *)Beyond::Gameplay::Core::AbilitySystem::get_detectedRadius )
			//   {
			//     v26 = smoothness[11].klass;
			//     if ( !v26 )
			//       goto LABEL_85;
			//     dst = (VignetteCPP *)v26._0.name;
			//     if ( !dst )
			//       goto LABEL_85;
			//     stepDownOffset = dst.color.a;
			//   }
			//   else if ( v15 == (const MethodInfo *)Beyond::NPC::Animation::AnimatorClothCalculator::AnimatorLookAtControllerHolder::get_weightBase )
			//   {
			//     if ( !byte_18D8EB3CE )
			//     {
			//       sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//       byte_18D8EB3CE = 1;
			//     }
			//     dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, src);
			//       dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     src = **(Vignette ***)&dst[2].opacity;
			//     if ( !src )
			//       goto LABEL_85;
			//     if ( *(int *)&src.fields._.active <= 1833 )
			//       goto LABEL_140;
			//     if ( !LODWORD(dst[3].smoothness) )
			//     {
			//       il2cpp_runtime_class_init_0(dst, src);
			//       dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     dst = **(VignetteCPP ***)&dst[2].opacity;
			//     if ( !dst )
			//       goto LABEL_85;
			//     if ( LODWORD(dst.center.y) <= 0x729 )
			//       goto LABEL_136;
			//     if ( *(_QWORD *)&dst[229].rounded )
			//     {
			//       v30 = IFix::WrappersManagerImpl::GetPatch(1833, 0LL);
			//       if ( !v30 )
			//         goto LABEL_85;
			//       stepDownOffset = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_43(
			//                          (ILFixDynamicMethodWrapper_16 *)v30,
			//                          (Object *)smoothness,
			//                          0LL);
			//     }
			//     else
			//     {
			// LABEL_140:
			//       if ( *(_QWORD *)&smoothness.fields.min )
			//         stepDownOffset = *(float *)(*(_QWORD *)&smoothness.fields.min + 204LL);
			//       else
			//         stepDownOffset = 0.0;
			//     }
			//   }
			//   else if ( v15 == (const MethodInfo *)Beyond::Gameplay::Core::MovePipelineGroundBase::get_stepDownOffset )
			//   {
			//     dst = (VignetteCPP *)smoothness.fields._._._;
			//     if ( !dst )
			//       goto LABEL_85;
			//     stepDownOffset = Beyond::Gameplay::Core::MovementComponent::get_stepDownOffset((MovementComponent *)dst, 0LL);
			//   }
			//   else
			//   {
			//     stepDownOffset = ((float (__fastcall *)(ClampedFloatParameter *, Vignette *))v15)(smoothness, src);
			//   }
			//   v4.smoothness = stepDownOffset;
			//   roundness = v3.fields.roundness;
			//   if ( !roundness )
			//     goto LABEL_85;
			//   sub_180003EE0(roundness.klass);
			//   v18 = roundness.klass.vtable.get_value.method;
			//   src = (Vignette *)roundness.klass.vtable.set_value.methodPtr;
			//   if ( v18 == (const MethodInfo *)Beyond::Gameplay::Core::AbilitySystem::get_detectedRadius )
			//   {
			//     v27 = roundness[11].klass;
			//     if ( !v27 )
			//       goto LABEL_85;
			//     dst = (VignetteCPP *)v27._0.name;
			//     if ( !dst )
			//       goto LABEL_85;
			//     v19 = dst.color.a;
			//   }
			//   else if ( v18 == (const MethodInfo *)Beyond::NPC::Animation::AnimatorClothCalculator::AnimatorLookAtControllerHolder::get_weightBase )
			//   {
			//     if ( !byte_18D8EB3CE )
			//     {
			//       sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//       byte_18D8EB3CE = 1;
			//     }
			//     dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, src);
			//       dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     src = **(Vignette ***)&dst[2].opacity;
			//     if ( !src )
			//       goto LABEL_85;
			//     if ( *(int *)&src.fields._.active <= 1833 )
			//       goto LABEL_141;
			//     if ( !LODWORD(dst[3].smoothness) )
			//     {
			//       il2cpp_runtime_class_init_0(dst, src);
			//       dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     dst = **(VignetteCPP ***)&dst[2].opacity;
			//     if ( !dst )
			//       goto LABEL_85;
			//     if ( LODWORD(dst.center.y) <= 0x729 )
			//       goto LABEL_136;
			//     if ( *(_QWORD *)&dst[229].rounded )
			//     {
			//       v31 = IFix::WrappersManagerImpl::GetPatch(1833, 0LL);
			//       if ( !v31 )
			//         goto LABEL_85;
			//       v19 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_43(
			//               (ILFixDynamicMethodWrapper_16 *)v31,
			//               (Object *)roundness,
			//               0LL);
			//     }
			//     else
			//     {
			// LABEL_141:
			//       if ( *(_QWORD *)&roundness.fields.min )
			//         v19 = *(float *)(*(_QWORD *)&roundness.fields.min + 204LL);
			//       else
			//         v19 = 0.0;
			//     }
			//   }
			//   else if ( v18 == (const MethodInfo *)Beyond::Gameplay::Core::MovePipelineGroundBase::get_stepDownOffset )
			//   {
			//     dst = (VignetteCPP *)roundness.fields._._._;
			//     if ( !dst )
			//       goto LABEL_85;
			//     v19 = Beyond::Gameplay::Core::MovementComponent::get_stepDownOffset((MovementComponent *)dst, 0LL);
			//   }
			//   else
			//   {
			//     v19 = ((float (__fastcall *)(ClampedFloatParameter *, Vignette *))v18)(roundness, src);
			//   }
			//   v4.roundness = v19;
			//   src = (Vignette *)v3.fields.rounded;
			//   if ( !src )
			//     goto LABEL_85;
			//   v4.rounded = sub_1800023D0(10LL, src);
			//   src = (Vignette *)v3.fields.blink;
			//   if ( !src )
			//     goto LABEL_85;
			//   v4.blink = sub_1800023D0(10LL, src);
			//   src = (Vignette *)v3.fields.mask;
			//   if ( !src )
			//     goto LABEL_85;
			//   v20 = sub_18004EF00(10LL, src);
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, src);
			//   if ( !byte_18D8F4EFB )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EFB = 1;
			//   }
			//   dst = (VignetteCPP *)TypeInfo::UnityEngine::Object;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, src);
			//   if ( !byte_18D8F4EAF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAF = 1;
			//   }
			//   if ( !v20 )
			//     goto LABEL_40;
			//   dst = (VignetteCPP *)TypeInfo::UnityEngine::Object;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, src);
			//   if ( *(_QWORD *)(v20 + 16) )
			//   {
			//     src = (Vignette *)v3.fields.mask;
			//     if ( !src )
			//       goto LABEL_85;
			//     v32 = sub_18004EF00(10LL, src);
			//     if ( !v32 )
			//       goto LABEL_85;
			//     v21 = *(void **)(v32 + 16);
			//   }
			//   else
			//   {
			// LABEL_40:
			//     v21 = 0LL;
			//   }
			//   v4.mask = v21;
			//   opacity = (Object *)v3.fields.opacity;
			//   if ( !opacity )
			//     goto LABEL_85;
			//   sub_180003EE0(opacity.klass);
			//   typeMetadataHandle = (float (*)(AbilitySystem *, MethodInfo *))opacity.klass[1]._0.typeMetadataHandle;
			//   src = (Vignette *)opacity.klass[1]._0.interopData;
			//   if ( typeMetadataHandle == Beyond::Gameplay::Core::AbilitySystem::get_detectedRadius )
			//   {
			//     v28 = opacity[33].klass;
			//     if ( v28 )
			//     {
			//       dst = (VignetteCPP *)v28._0.name;
			//       if ( dst )
			//       {
			//         v8 = dst.color.a;
			//         goto LABEL_47;
			//       }
			//     }
			//     goto LABEL_85;
			//   }
			//   if ( (char *)typeMetadataHandle != (char *)Beyond::NPC::Animation::AnimatorClothCalculator::AnimatorLookAtControllerHolder::get_weightBase )
			//   {
			//     if ( (char *)typeMetadataHandle != (char *)Beyond::Gameplay::Core::MovePipelineGroundBase::get_stepDownOffset )
			//     {
			//       v24 = ((double (__fastcall *)(Object *, Vignette *))typeMetadataHandle)(opacity, src);
			// LABEL_46:
			//       v8 = *(float *)&v24;
			//       goto LABEL_47;
			//     }
			//     dst = (VignetteCPP *)opacity[1].klass;
			//     if ( dst )
			//     {
			//       *(float *)&v24 = Beyond::Gameplay::Core::MovementComponent::get_stepDownOffset((MovementComponent *)dst, 0LL);
			//       goto LABEL_46;
			//     }
			// LABEL_85:
			//     sub_180B536AC(dst, src);
			//   }
			//   if ( !byte_18D8EB3CE )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EB3CE = 1;
			//   }
			//   dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, src);
			//     dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   src = **(Vignette ***)&dst[2].opacity;
			//   if ( !src )
			//     goto LABEL_85;
			//   if ( *(int *)&src.fields._.active > 1833 )
			//   {
			//     if ( !LODWORD(dst[3].smoothness) )
			//     {
			//       il2cpp_runtime_class_init_0(dst, src);
			//       dst = (VignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     dst = **(VignetteCPP ***)&dst[2].opacity;
			//     if ( !dst )
			//       goto LABEL_85;
			//     if ( LODWORD(dst.center.y) > 0x729 )
			//     {
			//       if ( *(_QWORD *)&dst[229].rounded )
			//       {
			//         v33 = IFix::WrappersManagerImpl::GetPatch(1833, 0LL);
			//         if ( v33 )
			//         {
			//           *(float *)&v24 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_43(
			//                              (ILFixDynamicMethodWrapper_16 *)v33,
			//                              opacity,
			//                              0LL);
			//           goto LABEL_46;
			//         }
			//         goto LABEL_85;
			//       }
			//       goto LABEL_92;
			//     }
			// LABEL_136:
			//     sub_180070270(dst, src);
			//   }
			// LABEL_92:
			//   if ( opacity[2].klass )
			//     v8 = *((float *)&opacity[2].klass._1.typeHierarchy + 1);
			// LABEL_47:
			//   v4.opacity = v8;
			// }
			// 
		}

		public unsafe static void ConvertHGVignetteToCPP(HGVignetteCPP* dst, HGVignette src)
		{
			// // Void ConvertHGVignetteToCPP(HGVignetteCPP*, HGVignette)
			// void HG::Rendering::Runtime::HGUtilsCpp::ConvertHGVignetteToCPP(
			//         HGVignetteCPP *dst,
			//         HGVignette *src,
			//         MethodInfo *method)
			// {
			//   HGVignette *v3; // rbx
			//   HGVignetteCPP *v4; // rdi
			//   ColorParameter *color; // rsi
			//   Color v6; // xmm0
			//   ClampedFloatParameter *intensity; // rsi
			//   float v8; // xmm6_4
			//   const MethodInfo *v9; // r8
			//   float stepDownOffset; // xmm0_4
			//   Object *smoothness; // rsi
			//   float (*typeMetadataHandle)(AbilitySystem *, MethodInfo *); // r8
			//   double v13; // xmm0_8
			//   ClampedFloatParameter__Class *klass; // rax
			//   Object__Class *v15; // rax
			//   ILFixDynamicMethodWrapper *Patch; // rax
			//   ILFixDynamicMethodWrapper *v17; // rax
			//   char v18[16]; // [rsp+20h] [rbp-38h] BYREF
			// 
			//   v3 = src;
			//   v4 = dst;
			//   if ( !src )
			//     goto LABEL_44;
			//   color = src.fields.color;
			//   if ( !color )
			//     goto LABEL_44;
			//   sub_180003EE0(color.klass);
			//   v6 = *(Color *)((__int64 (__fastcall *)(char *, ColorParameter *, Il2CppMethodPointer))color.klass.vtable.get_value.method)(
			//                    v18,
			//                    color,
			//                    color.klass.vtable.set_value.methodPtr);
			//   if ( !v4 )
			//     goto LABEL_44;
			//   v4.color = v6;
			//   intensity = v3.fields.intensity;
			//   if ( !intensity )
			//     goto LABEL_44;
			//   sub_180003EE0(intensity.klass);
			//   v8 = 0.0;
			//   v9 = intensity.klass.vtable.get_value.method;
			//   src = (HGVignette *)intensity.klass.vtable.set_value.methodPtr;
			//   if ( v9 == (const MethodInfo *)Beyond::Gameplay::Core::AbilitySystem::get_detectedRadius )
			//   {
			//     klass = intensity[11].klass;
			//     if ( !klass )
			//       goto LABEL_44;
			//     dst = (HGVignetteCPP *)klass._0.name;
			//     if ( !dst )
			//       goto LABEL_44;
			//     stepDownOffset = dst.intensity;
			//   }
			//   else if ( v9 == (const MethodInfo *)Beyond::NPC::Animation::AnimatorClothCalculator::AnimatorLookAtControllerHolder::get_weightBase )
			//   {
			//     if ( !byte_18D8EB3CE )
			//     {
			//       sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//       byte_18D8EB3CE = 1;
			//     }
			//     dst = (HGVignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, src);
			//       dst = (HGVignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     src = **(HGVignette ***)&dst[6].intensity;
			//     if ( !src )
			//       goto LABEL_44;
			//     if ( *(int *)&src.fields._.active <= 1833 )
			//       goto LABEL_63;
			//     if ( !LODWORD(dst[8].color.r) )
			//     {
			//       il2cpp_runtime_class_init_0(dst, src);
			//       dst = (HGVignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     dst = **(HGVignetteCPP ***)&dst[6].intensity;
			//     if ( !dst )
			//       goto LABEL_44;
			//     if ( *(_DWORD *)&dst.rounded <= 0x729u )
			//       goto LABEL_60;
			//     if ( *(_QWORD *)&dst[524].rounded )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(1833, 0LL);
			//       if ( !Patch )
			//         goto LABEL_44;
			//       stepDownOffset = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_43(
			//                          (ILFixDynamicMethodWrapper_16 *)Patch,
			//                          (Object *)intensity,
			//                          0LL);
			//     }
			//     else
			//     {
			// LABEL_63:
			//       if ( *(_QWORD *)&intensity.fields.min )
			//         stepDownOffset = *(float *)(*(_QWORD *)&intensity.fields.min + 204LL);
			//       else
			//         stepDownOffset = 0.0;
			//     }
			//   }
			//   else if ( v9 == (const MethodInfo *)Beyond::Gameplay::Core::MovePipelineGroundBase::get_stepDownOffset )
			//   {
			//     dst = (HGVignetteCPP *)intensity.fields._._._;
			//     if ( !dst )
			//       goto LABEL_44;
			//     stepDownOffset = Beyond::Gameplay::Core::MovementComponent::get_stepDownOffset((MovementComponent *)dst, 0LL);
			//   }
			//   else
			//   {
			//     stepDownOffset = ((float (__fastcall *)(ClampedFloatParameter *, HGVignette *))v9)(intensity, src);
			//   }
			//   v4.intensity = stepDownOffset;
			//   smoothness = (Object *)v3.fields.smoothness;
			//   if ( !smoothness )
			//     goto LABEL_44;
			//   sub_180003EE0(smoothness.klass);
			//   typeMetadataHandle = (float (*)(AbilitySystem *, MethodInfo *))smoothness.klass[1]._0.typeMetadataHandle;
			//   src = (HGVignette *)smoothness.klass[1]._0.interopData;
			//   if ( typeMetadataHandle == Beyond::Gameplay::Core::AbilitySystem::get_detectedRadius )
			//   {
			//     v15 = smoothness[33].klass;
			//     if ( v15 )
			//     {
			//       dst = (HGVignetteCPP *)v15._0.name;
			//       if ( dst )
			//       {
			//         v8 = dst.intensity;
			//         goto LABEL_15;
			//       }
			//     }
			//     goto LABEL_44;
			//   }
			//   if ( (char *)typeMetadataHandle != (char *)Beyond::NPC::Animation::AnimatorClothCalculator::AnimatorLookAtControllerHolder::get_weightBase )
			//   {
			//     if ( (char *)typeMetadataHandle == (char *)Beyond::Gameplay::Core::MovePipelineGroundBase::get_stepDownOffset )
			//     {
			//       dst = (HGVignetteCPP *)smoothness[1].klass;
			//       if ( !dst )
			//         goto LABEL_44;
			//       *(float *)&v13 = Beyond::Gameplay::Core::MovementComponent::get_stepDownOffset((MovementComponent *)dst, 0LL);
			//     }
			//     else
			//     {
			//       v13 = ((double (__fastcall *)(Object *, HGVignette *))typeMetadataHandle)(smoothness, src);
			//     }
			// LABEL_14:
			//     v8 = *(float *)&v13;
			//     goto LABEL_15;
			//   }
			//   if ( !byte_18D8EB3CE )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EB3CE = 1;
			//   }
			//   dst = (HGVignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, src);
			//     dst = (HGVignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   src = **(HGVignette ***)&dst[6].intensity;
			//   if ( !src )
			//     goto LABEL_44;
			//   if ( *(int *)&src.fields._.active <= 1833 )
			//     goto LABEL_38;
			//   if ( !LODWORD(dst[8].color.r) )
			//   {
			//     il2cpp_runtime_class_init_0(dst, src);
			//     dst = (HGVignetteCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   dst = **(HGVignetteCPP ***)&dst[6].intensity;
			//   if ( !dst )
			// LABEL_44:
			//     sub_180B536AC(dst, src);
			//   if ( *(_DWORD *)&dst.rounded <= 0x729u )
			// LABEL_60:
			//     sub_180070270(dst, src);
			//   if ( *(_QWORD *)&dst[524].rounded )
			//   {
			//     v17 = IFix::WrappersManagerImpl::GetPatch(1833, 0LL);
			//     if ( !v17 )
			//       goto LABEL_44;
			//     *(float *)&v13 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_43(
			//                        (ILFixDynamicMethodWrapper_16 *)v17,
			//                        smoothness,
			//                        0LL);
			//     goto LABEL_14;
			//   }
			// LABEL_38:
			//   if ( smoothness[2].klass )
			//     v8 = *((float *)&smoothness[2].klass._1.typeHierarchy + 1);
			// LABEL_15:
			//   v4.smoothness = v8;
			//   src = (HGVignette *)v3.fields.rounded;
			//   if ( !src )
			//     goto LABEL_44;
			//   v4.rounded = sub_1800023D0(10LL, src);
			//   src = (HGVignette *)v3.fields.blink;
			//   if ( !src )
			//     goto LABEL_44;
			//   v4.blink = sub_1800023D0(10LL, src);
			// }
			// 
		}

		public unsafe static void ConvertBloomToCPP(BloomVolumeCPP* dst, Bloom src, float anamorphism)
		{
			// // Void ConvertBloomToCPP(BloomVolumeCPP*, Bloom, Single)
			// void HG::Rendering::Runtime::HGUtilsCpp::ConvertBloomToCPP(
			//         BloomVolumeCPP *dst,
			//         Bloom *src,
			//         float anamorphism,
			//         MethodInfo *method)
			// {
			//   Bloom *v4; // rbx
			//   BloomVolumeCPP *v5; // rdi
			//   ClampedFloatParameter *intensityHighQuality; // rsi
			//   double v7; // xmm0_8
			//   const MethodInfo *v8; // r8
			//   ColorParameter *tint; // rsi
			//   __int64 v10; // rsi
			//   void *v11; // rax
			//   MinFloatParameter *dirtIntensity; // rsi
			//   const MethodInfo *v13; // r8
			//   float a; // xmm0_4
			//   ClampedFloatParameter *scatterHighQuality; // rsi
			//   const MethodInfo *v16; // r8
			//   float stepDownOffset; // xmm0_4
			//   MinFloatParameter *thresholdHighQuality; // rsi
			//   const MethodInfo *v19; // r8
			//   float v20; // xmm0_4
			//   MinFloatParameter *characterThreshold; // rsi
			//   const MethodInfo *v22; // r8
			//   float v23; // xmm0_4
			//   ClampedFloatParameter *characterSoftness; // rsi
			//   const MethodInfo *v25; // r8
			//   float v26; // xmm0_4
			//   ClampedFloatParameter *characterIntensity; // rsi
			//   const MethodInfo *v28; // r8
			//   float v29; // xmm0_4
			//   bool v30; // zf
			//   int v31; // eax
			//   __int64 v32; // rdx
			//   int32_t v33; // eax
			//   __int64 v34; // rdx
			//   __int64 v35; // rsi
			//   bool v36; // al
			//   ClampedFloatParameter__Class *klass; // rax
			//   MonitorData *monitor; // rax
			//   ClampedFloatParameter__Class *v39; // rax
			//   MonitorData *v40; // rax
			//   MonitorData *v41; // rax
			//   ClampedFloatParameter__Class *v42; // rax
			//   ClampedFloatParameter__Class *v43; // rax
			//   ILFixDynamicMethodWrapper *Patch; // rax
			//   __int64 v45; // rax
			//   ILFixDynamicMethodWrapper *v46; // rax
			//   ILFixDynamicMethodWrapper *v47; // rax
			//   ILFixDynamicMethodWrapper *v48; // rax
			//   ILFixDynamicMethodWrapper *v49; // rax
			//   ILFixDynamicMethodWrapper *v50; // rax
			//   ILFixDynamicMethodWrapper *v51; // rax
			//   ILFixDynamicMethodWrapper_2 *v52; // rax
			//   ILFixDynamicMethodWrapper_2 *v53; // rax
			//   char v54[16]; // [rsp+20h] [rbp-38h] BYREF
			// 
			//   v4 = src;
			//   v5 = dst;
			//   if ( !byte_18D8EDB39 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDB39 = 1;
			//   }
			//   if ( !v4 )
			//     goto LABEL_112;
			//   intensityHighQuality = v4.fields.intensityHighQuality;
			//   if ( !intensityHighQuality )
			//     goto LABEL_112;
			//   v7 = sub_180003EE0(intensityHighQuality.klass);
			//   v8 = intensityHighQuality.klass.vtable.get_value.method;
			//   src = (Bloom *)intensityHighQuality.klass.vtable.set_value.methodPtr;
			//   if ( v8 == (const MethodInfo *)Beyond::Gameplay::Core::AbilitySystem::get_detectedRadius )
			//   {
			//     klass = intensityHighQuality[11].klass;
			//     if ( !klass )
			//       goto LABEL_112;
			//     dst = (BloomVolumeCPP *)klass._0.name;
			//     if ( !dst )
			//       goto LABEL_112;
			//     *(float *)&v7 = dst.tint.a;
			//   }
			//   else if ( v8 == (const MethodInfo *)Beyond::NPC::Animation::AnimatorClothCalculator::AnimatorLookAtControllerHolder::get_weightBase )
			//   {
			//     if ( !byte_18D8EB3CE )
			//     {
			//       sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//       byte_18D8EB3CE = 1;
			//     }
			//     dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, src);
			//       dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     src = **(Bloom ***)&dst[2].anamorphic;
			//     if ( !src )
			//       goto LABEL_112;
			//     if ( *(int *)&src.fields._.active <= 1833 )
			//       goto LABEL_268;
			//     if ( !LODWORD(dst[3].tint.g) )
			//     {
			//       il2cpp_runtime_class_init_0(dst, src);
			//       dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     dst = **(BloomVolumeCPP ***)&dst[2].anamorphic;
			//     if ( !dst )
			//       goto LABEL_112;
			//     if ( LODWORD(dst.dirtTexture) <= 0x729 )
			//       goto LABEL_263;
			//     if ( *(_QWORD *)&dst[204].tint.g )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(1833, 0LL);
			//       if ( !Patch )
			//         goto LABEL_112;
			//       *(float *)&v7 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_43(
			//                         (ILFixDynamicMethodWrapper_16 *)Patch,
			//                         (Object *)intensityHighQuality,
			//                         0LL);
			//     }
			//     else
			//     {
			// LABEL_268:
			//       if ( *(_QWORD *)&intensityHighQuality.fields.min )
			//         LODWORD(v7) = *(_DWORD *)(*(_QWORD *)&intensityHighQuality.fields.min + 204LL);
			//       else
			//         LODWORD(v7) = 0;
			//     }
			//   }
			//   else if ( v8 == (const MethodInfo *)Beyond::Gameplay::Core::MovePipelineGroundBase::get_stepDownOffset )
			//   {
			//     dst = (BloomVolumeCPP *)intensityHighQuality.fields._._._;
			//     if ( !dst )
			//       goto LABEL_112;
			//     *(float *)&v7 = Beyond::Gameplay::Core::MovementComponent::get_stepDownOffset((MovementComponent *)dst, 0LL);
			//   }
			//   else
			//   {
			//     ((void (__fastcall *)(ClampedFloatParameter *, Bloom *))v8)(intensityHighQuality, src);
			//   }
			//   if ( !v5 )
			//     goto LABEL_112;
			//   v5.intensity = *(float *)&v7;
			//   tint = v4.fields.tint;
			//   if ( !tint )
			//     goto LABEL_112;
			//   sub_180003EE0(tint.klass);
			//   v5.tint = *(Color *)((__int64 (__fastcall *)(char *, ColorParameter *, Il2CppMethodPointer))tint.klass.vtable.get_value.method)(
			//                          v54,
			//                          tint,
			//                          tint.klass.vtable.set_value.methodPtr);
			//   src = (Bloom *)v4.fields.dirtTexture;
			//   if ( !src )
			//     goto LABEL_112;
			//   v10 = sub_18004EF00(10LL, src);
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, src);
			//   if ( !byte_18D8F4EFB )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EFB = 1;
			//   }
			//   dst = (BloomVolumeCPP *)TypeInfo::UnityEngine::Object;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, src);
			//   if ( !byte_18D8F4EAF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAF = 1;
			//   }
			//   if ( !v10 )
			//     goto LABEL_24;
			//   dst = (BloomVolumeCPP *)TypeInfo::UnityEngine::Object;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, src);
			//   if ( *(_QWORD *)(v10 + 16) )
			//   {
			//     src = (Bloom *)v4.fields.dirtTexture;
			//     if ( !src )
			//       goto LABEL_112;
			//     v45 = sub_18004EF00(10LL, src);
			//     if ( !v45 )
			//       goto LABEL_112;
			//     v11 = *(void **)(v45 + 16);
			//   }
			//   else
			//   {
			// LABEL_24:
			//     v11 = 0LL;
			//   }
			//   v5.dirtTexture = v11;
			//   dirtIntensity = v4.fields.dirtIntensity;
			//   if ( !dirtIntensity )
			//     goto LABEL_112;
			//   sub_180003EE0(dirtIntensity.klass);
			//   v13 = dirtIntensity.klass.vtable.get_value.method;
			//   src = (Bloom *)dirtIntensity.klass.vtable.set_value.methodPtr;
			//   if ( v13 == (const MethodInfo *)Beyond::Gameplay::Core::AbilitySystem::get_detectedRadius )
			//   {
			//     monitor = dirtIntensity[13].monitor;
			//     if ( !monitor )
			//       goto LABEL_112;
			//     dst = (BloomVolumeCPP *)*((_QWORD *)monitor + 2);
			//     if ( !dst )
			//       goto LABEL_112;
			//     a = dst.tint.a;
			//   }
			//   else if ( v13 == (const MethodInfo *)Beyond::NPC::Animation::AnimatorClothCalculator::AnimatorLookAtControllerHolder::get_weightBase )
			//   {
			//     if ( !byte_18D8EB3CE )
			//     {
			//       sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//       byte_18D8EB3CE = 1;
			//     }
			//     dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, src);
			//       dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     src = **(Bloom ***)&dst[2].anamorphic;
			//     if ( !src )
			//       goto LABEL_112;
			//     if ( *(int *)&src.fields._.active <= 1833 )
			//       goto LABEL_269;
			//     if ( !LODWORD(dst[3].tint.g) )
			//     {
			//       il2cpp_runtime_class_init_0(dst, src);
			//       dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     dst = **(BloomVolumeCPP ***)&dst[2].anamorphic;
			//     if ( !dst )
			//       goto LABEL_112;
			//     if ( LODWORD(dst.dirtTexture) <= 0x729 )
			//       goto LABEL_263;
			//     if ( *(_QWORD *)&dst[204].tint.g )
			//     {
			//       v46 = IFix::WrappersManagerImpl::GetPatch(1833, 0LL);
			//       if ( !v46 )
			//         goto LABEL_112;
			//       a = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_43(
			//             (ILFixDynamicMethodWrapper_16 *)v46,
			//             (Object *)dirtIntensity,
			//             0LL);
			//     }
			//     else
			//     {
			// LABEL_269:
			//       if ( *(_QWORD *)&dirtIntensity.fields.min )
			//         a = *(float *)(*(_QWORD *)&dirtIntensity.fields.min + 204LL);
			//       else
			//         a = 0.0;
			//     }
			//   }
			//   else if ( v13 == (const MethodInfo *)Beyond::Gameplay::Core::MovePipelineGroundBase::get_stepDownOffset )
			//   {
			//     dst = (BloomVolumeCPP *)dirtIntensity.fields._._._;
			//     if ( !dst )
			//       goto LABEL_112;
			//     a = Beyond::Gameplay::Core::MovementComponent::get_stepDownOffset((MovementComponent *)dst, 0LL);
			//   }
			//   else
			//   {
			//     a = ((float (__fastcall *)(MinFloatParameter *, Bloom *))v13)(dirtIntensity, src);
			//   }
			//   v5.dirtIntensity = a;
			//   src = (Bloom *)v4.fields.blendMode;
			//   if ( !src )
			//     goto LABEL_112;
			//   v5.blendMode = sub_18003ED00(10LL);
			//   v5.anamorphic = anamorphism;
			//   scatterHighQuality = v4.fields.scatterHighQuality;
			//   if ( !scatterHighQuality )
			//     goto LABEL_112;
			//   sub_180003EE0(scatterHighQuality.klass);
			//   v16 = scatterHighQuality.klass.vtable.get_value.method;
			//   src = (Bloom *)scatterHighQuality.klass.vtable.set_value.methodPtr;
			//   if ( v16 == (const MethodInfo *)Beyond::Gameplay::Core::AbilitySystem::get_detectedRadius )
			//   {
			//     v39 = scatterHighQuality[11].klass;
			//     if ( !v39 )
			//       goto LABEL_112;
			//     dst = (BloomVolumeCPP *)v39._0.name;
			//     if ( !dst )
			//       goto LABEL_112;
			//     stepDownOffset = dst.tint.a;
			//   }
			//   else if ( v16 == (const MethodInfo *)Beyond::NPC::Animation::AnimatorClothCalculator::AnimatorLookAtControllerHolder::get_weightBase )
			//   {
			//     if ( !byte_18D8EB3CE )
			//     {
			//       sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//       byte_18D8EB3CE = 1;
			//     }
			//     dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, src);
			//       dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     src = **(Bloom ***)&dst[2].anamorphic;
			//     if ( !src )
			//       goto LABEL_112;
			//     if ( *(int *)&src.fields._.active <= 1833 )
			//       goto LABEL_270;
			//     if ( !LODWORD(dst[3].tint.g) )
			//     {
			//       il2cpp_runtime_class_init_0(dst, src);
			//       dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     dst = **(BloomVolumeCPP ***)&dst[2].anamorphic;
			//     if ( !dst )
			//       goto LABEL_112;
			//     if ( LODWORD(dst.dirtTexture) <= 0x729 )
			//       goto LABEL_263;
			//     if ( *(_QWORD *)&dst[204].tint.g )
			//     {
			//       v47 = IFix::WrappersManagerImpl::GetPatch(1833, 0LL);
			//       if ( !v47 )
			//         goto LABEL_112;
			//       stepDownOffset = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_43(
			//                          (ILFixDynamicMethodWrapper_16 *)v47,
			//                          (Object *)scatterHighQuality,
			//                          0LL);
			//     }
			//     else
			//     {
			// LABEL_270:
			//       if ( *(_QWORD *)&scatterHighQuality.fields.min )
			//         stepDownOffset = *(float *)(*(_QWORD *)&scatterHighQuality.fields.min + 204LL);
			//       else
			//         stepDownOffset = 0.0;
			//     }
			//   }
			//   else if ( v16 == (const MethodInfo *)Beyond::Gameplay::Core::MovePipelineGroundBase::get_stepDownOffset )
			//   {
			//     dst = (BloomVolumeCPP *)scatterHighQuality.fields._._._;
			//     if ( !dst )
			//       goto LABEL_112;
			//     stepDownOffset = Beyond::Gameplay::Core::MovementComponent::get_stepDownOffset((MovementComponent *)dst, 0LL);
			//   }
			//   else
			//   {
			//     stepDownOffset = ((float (__fastcall *)(ClampedFloatParameter *, Bloom *))v16)(scatterHighQuality, src);
			//   }
			//   v5.scatter = stepDownOffset;
			//   thresholdHighQuality = v4.fields.thresholdHighQuality;
			//   if ( !thresholdHighQuality )
			//     goto LABEL_112;
			//   sub_180003EE0(thresholdHighQuality.klass);
			//   v19 = thresholdHighQuality.klass.vtable.get_value.method;
			//   src = (Bloom *)thresholdHighQuality.klass.vtable.set_value.methodPtr;
			//   if ( v19 == (const MethodInfo *)Beyond::Gameplay::Core::AbilitySystem::get_detectedRadius )
			//   {
			//     v40 = thresholdHighQuality[13].monitor;
			//     if ( !v40 )
			//       goto LABEL_112;
			//     dst = (BloomVolumeCPP *)*((_QWORD *)v40 + 2);
			//     if ( !dst )
			//       goto LABEL_112;
			//     v20 = dst.tint.a;
			//   }
			//   else if ( v19 == (const MethodInfo *)Beyond::NPC::Animation::AnimatorClothCalculator::AnimatorLookAtControllerHolder::get_weightBase )
			//   {
			//     if ( !byte_18D8EB3CE )
			//     {
			//       sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//       byte_18D8EB3CE = 1;
			//     }
			//     dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, src);
			//       dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     src = **(Bloom ***)&dst[2].anamorphic;
			//     if ( !src )
			//       goto LABEL_112;
			//     if ( *(int *)&src.fields._.active <= 1833 )
			//       goto LABEL_271;
			//     if ( !LODWORD(dst[3].tint.g) )
			//     {
			//       il2cpp_runtime_class_init_0(dst, src);
			//       dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     dst = **(BloomVolumeCPP ***)&dst[2].anamorphic;
			//     if ( !dst )
			//       goto LABEL_112;
			//     if ( LODWORD(dst.dirtTexture) <= 0x729 )
			//       goto LABEL_263;
			//     if ( *(_QWORD *)&dst[204].tint.g )
			//     {
			//       v48 = IFix::WrappersManagerImpl::GetPatch(1833, 0LL);
			//       if ( !v48 )
			//         goto LABEL_112;
			//       v20 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_43(
			//               (ILFixDynamicMethodWrapper_16 *)v48,
			//               (Object *)thresholdHighQuality,
			//               0LL);
			//     }
			//     else
			//     {
			// LABEL_271:
			//       if ( *(_QWORD *)&thresholdHighQuality.fields.min )
			//         v20 = *(float *)(*(_QWORD *)&thresholdHighQuality.fields.min + 204LL);
			//       else
			//         v20 = 0.0;
			//     }
			//   }
			//   else if ( v19 == (const MethodInfo *)Beyond::Gameplay::Core::MovePipelineGroundBase::get_stepDownOffset )
			//   {
			//     dst = (BloomVolumeCPP *)thresholdHighQuality.fields._._._;
			//     if ( !dst )
			//       goto LABEL_112;
			//     v20 = Beyond::Gameplay::Core::MovementComponent::get_stepDownOffset((MovementComponent *)dst, 0LL);
			//   }
			//   else
			//   {
			//     v20 = ((float (__fastcall *)(MinFloatParameter *, Bloom *))v19)(thresholdHighQuality, src);
			//   }
			//   v5.threshold = v20;
			//   characterThreshold = v4.fields.characterThreshold;
			//   if ( !characterThreshold )
			//     goto LABEL_112;
			//   sub_180003EE0(characterThreshold.klass);
			//   v22 = characterThreshold.klass.vtable.get_value.method;
			//   src = (Bloom *)characterThreshold.klass.vtable.set_value.methodPtr;
			//   if ( v22 == (const MethodInfo *)Beyond::Gameplay::Core::AbilitySystem::get_detectedRadius )
			//   {
			//     v41 = characterThreshold[13].monitor;
			//     if ( !v41 )
			//       goto LABEL_112;
			//     dst = (BloomVolumeCPP *)*((_QWORD *)v41 + 2);
			//     if ( !dst )
			//       goto LABEL_112;
			//     v23 = dst.tint.a;
			//   }
			//   else if ( v22 == (const MethodInfo *)Beyond::NPC::Animation::AnimatorClothCalculator::AnimatorLookAtControllerHolder::get_weightBase )
			//   {
			//     if ( !byte_18D8EB3CE )
			//     {
			//       sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//       byte_18D8EB3CE = 1;
			//     }
			//     dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, src);
			//       dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     src = **(Bloom ***)&dst[2].anamorphic;
			//     if ( !src )
			//       goto LABEL_112;
			//     if ( *(int *)&src.fields._.active <= 1833 )
			//       goto LABEL_272;
			//     if ( !LODWORD(dst[3].tint.g) )
			//     {
			//       il2cpp_runtime_class_init_0(dst, src);
			//       dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     dst = **(BloomVolumeCPP ***)&dst[2].anamorphic;
			//     if ( !dst )
			//       goto LABEL_112;
			//     if ( LODWORD(dst.dirtTexture) <= 0x729 )
			//       goto LABEL_263;
			//     if ( *(_QWORD *)&dst[204].tint.g )
			//     {
			//       v49 = IFix::WrappersManagerImpl::GetPatch(1833, 0LL);
			//       if ( !v49 )
			//         goto LABEL_112;
			//       v23 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_43(
			//               (ILFixDynamicMethodWrapper_16 *)v49,
			//               (Object *)characterThreshold,
			//               0LL);
			//     }
			//     else
			//     {
			// LABEL_272:
			//       if ( *(_QWORD *)&characterThreshold.fields.min )
			//         v23 = *(float *)(*(_QWORD *)&characterThreshold.fields.min + 204LL);
			//       else
			//         v23 = 0.0;
			//     }
			//   }
			//   else if ( v22 == (const MethodInfo *)Beyond::Gameplay::Core::MovePipelineGroundBase::get_stepDownOffset )
			//   {
			//     dst = (BloomVolumeCPP *)characterThreshold.fields._._._;
			//     if ( !dst )
			//       goto LABEL_112;
			//     v23 = Beyond::Gameplay::Core::MovementComponent::get_stepDownOffset((MovementComponent *)dst, 0LL);
			//   }
			//   else
			//   {
			//     v23 = ((float (__fastcall *)(MinFloatParameter *, Bloom *))v22)(characterThreshold, src);
			//   }
			//   v5.characterThreshold = v23;
			//   characterSoftness = v4.fields.characterSoftness;
			//   if ( !characterSoftness )
			//     goto LABEL_112;
			//   sub_180003EE0(characterSoftness.klass);
			//   v25 = characterSoftness.klass.vtable.get_value.method;
			//   src = (Bloom *)characterSoftness.klass.vtable.set_value.methodPtr;
			//   if ( v25 == (const MethodInfo *)Beyond::Gameplay::Core::AbilitySystem::get_detectedRadius )
			//   {
			//     v42 = characterSoftness[11].klass;
			//     if ( !v42 )
			//       goto LABEL_112;
			//     dst = (BloomVolumeCPP *)v42._0.name;
			//     if ( !dst )
			//       goto LABEL_112;
			//     v26 = dst.tint.a;
			//   }
			//   else if ( v25 == (const MethodInfo *)Beyond::NPC::Animation::AnimatorClothCalculator::AnimatorLookAtControllerHolder::get_weightBase )
			//   {
			//     if ( !byte_18D8EB3CE )
			//     {
			//       sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//       byte_18D8EB3CE = 1;
			//     }
			//     dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, src);
			//       dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     src = **(Bloom ***)&dst[2].anamorphic;
			//     if ( !src )
			//       goto LABEL_112;
			//     if ( *(int *)&src.fields._.active <= 1833 )
			//       goto LABEL_273;
			//     if ( !LODWORD(dst[3].tint.g) )
			//     {
			//       il2cpp_runtime_class_init_0(dst, src);
			//       dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     dst = **(BloomVolumeCPP ***)&dst[2].anamorphic;
			//     if ( !dst )
			//       goto LABEL_112;
			//     if ( LODWORD(dst.dirtTexture) <= 0x729 )
			//       goto LABEL_263;
			//     if ( *(_QWORD *)&dst[204].tint.g )
			//     {
			//       v50 = IFix::WrappersManagerImpl::GetPatch(1833, 0LL);
			//       if ( !v50 )
			//         goto LABEL_112;
			//       v26 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_43(
			//               (ILFixDynamicMethodWrapper_16 *)v50,
			//               (Object *)characterSoftness,
			//               0LL);
			//     }
			//     else
			//     {
			// LABEL_273:
			//       if ( *(_QWORD *)&characterSoftness.fields.min )
			//         v26 = *(float *)(*(_QWORD *)&characterSoftness.fields.min + 204LL);
			//       else
			//         v26 = 0.0;
			//     }
			//   }
			//   else if ( v25 == (const MethodInfo *)Beyond::Gameplay::Core::MovePipelineGroundBase::get_stepDownOffset )
			//   {
			//     dst = (BloomVolumeCPP *)characterSoftness.fields._._._;
			//     if ( !dst )
			//       goto LABEL_112;
			//     v26 = Beyond::Gameplay::Core::MovementComponent::get_stepDownOffset((MovementComponent *)dst, 0LL);
			//   }
			//   else
			//   {
			//     v26 = ((float (__fastcall *)(ClampedFloatParameter *, Bloom *))v25)(characterSoftness, src);
			//   }
			//   v5.characterSoftness = v26;
			//   characterIntensity = v4.fields.characterIntensity;
			//   if ( !characterIntensity )
			//     goto LABEL_112;
			//   sub_180003EE0(characterIntensity.klass);
			//   v28 = characterIntensity.klass.vtable.get_value.method;
			//   src = (Bloom *)characterIntensity.klass.vtable.set_value.methodPtr;
			//   if ( v28 == (const MethodInfo *)Beyond::Gameplay::Core::AbilitySystem::get_detectedRadius )
			//   {
			//     v43 = characterIntensity[11].klass;
			//     if ( !v43 )
			//       goto LABEL_112;
			//     dst = (BloomVolumeCPP *)v43._0.name;
			//     if ( !dst )
			//       goto LABEL_112;
			//     v29 = dst.tint.a;
			//   }
			//   else if ( v28 == (const MethodInfo *)Beyond::NPC::Animation::AnimatorClothCalculator::AnimatorLookAtControllerHolder::get_weightBase )
			//   {
			//     if ( !byte_18D8EB3CE )
			//     {
			//       sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//       byte_18D8EB3CE = 1;
			//     }
			//     dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, src);
			//       dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     src = **(Bloom ***)&dst[2].anamorphic;
			//     if ( !src )
			//       goto LABEL_112;
			//     if ( *(int *)&src.fields._.active <= 1833 )
			//       goto LABEL_274;
			//     if ( !LODWORD(dst[3].tint.g) )
			//     {
			//       il2cpp_runtime_class_init_0(dst, src);
			//       dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     src = **(Bloom ***)&dst[2].anamorphic;
			//     if ( !src )
			//       goto LABEL_112;
			//     if ( *(_DWORD *)&src.fields._.active <= 0x729u )
			//       goto LABEL_263;
			//     if ( src[65].fields.scatterMedQuality )
			//     {
			//       v51 = IFix::WrappersManagerImpl::GetPatch(1833, 0LL);
			//       if ( !v51 )
			//         goto LABEL_112;
			//       v29 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_43(
			//               (ILFixDynamicMethodWrapper_16 *)v51,
			//               (Object *)characterIntensity,
			//               0LL);
			//     }
			//     else
			//     {
			// LABEL_274:
			//       if ( *(_QWORD *)&characterIntensity.fields.min )
			//         v29 = *(float *)(*(_QWORD *)&characterIntensity.fields.min + 204LL);
			//       else
			//         v29 = 0.0;
			//     }
			//   }
			//   else if ( v28 == (const MethodInfo *)Beyond::Gameplay::Core::MovePipelineGroundBase::get_stepDownOffset )
			//   {
			//     dst = (BloomVolumeCPP *)characterIntensity.fields._._._;
			//     if ( !dst )
			//       goto LABEL_112;
			//     v29 = Beyond::Gameplay::Core::MovementComponent::get_stepDownOffset((MovementComponent *)dst, 0LL);
			//   }
			//   else
			//   {
			//     v29 = ((float (__fastcall *)(ClampedFloatParameter *, Bloom *))v28)(characterIntensity, src);
			//   }
			//   v30 = byte_18D8EDC37 == 0;
			//   v5.characterIntensity = v29;
			//   if ( v30 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, src);
			//     dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   src = **(Bloom ***)&dst[2].anamorphic;
			//   if ( !src )
			//     goto LABEL_112;
			//   if ( *(int *)&src.fields._.active > 2210 )
			//   {
			//     if ( !LODWORD(dst[3].tint.g) )
			//     {
			//       il2cpp_runtime_class_init_0(dst, src);
			//       dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     src = **(Bloom ***)&dst[2].anamorphic;
			//     if ( !src )
			//       goto LABEL_112;
			//     if ( *(_DWORD *)&src.fields._.active <= 0x8A2u )
			//       goto LABEL_263;
			//     if ( src[79].fields._._._.m_CachedPtr )
			//     {
			//       v52 = IFix::WrappersManagerImpl::GetPatch(2210, 0LL);
			//       if ( !v52 )
			//         goto LABEL_112;
			//       v33 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_65((ILFixDynamicMethodWrapper_20 *)v52, (Object *)v4, 0LL);
			//       goto LABEL_66;
			//     }
			//   }
			//   src = (Bloom *)v4.fields.quality;
			//   if ( !src )
			//     goto LABEL_112;
			//   v31 = sub_18003ED00(10LL);
			//   if ( v31 == 2 )
			//   {
			//     src = (Bloom *)v4.fields.resolutionHighQuality;
			//     if ( !src )
			//       goto LABEL_112;
			//   }
			//   else if ( v31 )
			//   {
			//     if ( v31 != 1 )
			//     {
			//       v33 = 2;
			//       goto LABEL_66;
			//     }
			//     src = (Bloom *)v4.fields.resolutionMedQuality;
			//     if ( !src )
			//       goto LABEL_112;
			//   }
			//   else
			//   {
			//     src = (Bloom *)v4.fields.resolutionLowQuality;
			//     if ( !src )
			//       goto LABEL_112;
			//   }
			//   v33 = sub_18003ED00(10LL);
			// LABEL_66:
			//   v30 = byte_18D8ED9BD == 0;
			//   v5.resolution = v33;
			//   if ( v30 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8ED9BD = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v32);
			//     dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   src = **(Bloom ***)&dst[2].anamorphic;
			//   if ( !src )
			//     goto LABEL_112;
			//   if ( *(int *)&src.fields._.active <= 2211 )
			//     goto LABEL_74;
			//   if ( !LODWORD(dst[3].tint.g) )
			//   {
			//     il2cpp_runtime_class_init_0(dst, src);
			//     dst = (BloomVolumeCPP *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   dst = **(BloomVolumeCPP ***)&dst[2].anamorphic;
			//   if ( !dst )
			// LABEL_112:
			//     sub_180B536AC(dst, src);
			//   if ( LODWORD(dst.dirtTexture) <= 0x8A3 )
			// LABEL_263:
			//     sub_180070270(dst, src);
			//   if ( *(_QWORD *)&dst[246].tint.g )
			//   {
			//     v53 = IFix::WrappersManagerImpl::GetPatch(2211, 0LL);
			//     if ( !v53 )
			//       goto LABEL_112;
			//     v36 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)v53, (Object *)v4, 0LL);
			//     goto LABEL_88;
			//   }
			// LABEL_74:
			//   src = (Bloom *)v4.fields.dirtTexture;
			//   if ( !src )
			//     goto LABEL_112;
			//   v35 = sub_18004EF00(10LL, src);
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v34);
			//   if ( !byte_18D8F4EFB )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EFB = 1;
			//   }
			//   dst = (BloomVolumeCPP *)TypeInfo::UnityEngine::Object;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v34);
			//   if ( !byte_18D8F4EAF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAF = 1;
			//   }
			//   if ( !v35 )
			//     goto LABEL_87;
			//   dst = (BloomVolumeCPP *)TypeInfo::UnityEngine::Object;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v34);
			//   if ( *(_QWORD *)(v35 + 16) )
			//   {
			//     src = (Bloom *)v4.fields.dirtIntensity;
			//     if ( !src )
			//       goto LABEL_112;
			//     LOWORD(dst) = 10;
			//     v36 = sub_18003F9B0(dst, src) > 0.0;
			//   }
			//   else
			//   {
			// LABEL_87:
			//     v36 = 0;
			//   }
			// LABEL_88:
			//   v5.enableBloomDirt = v36;
			//   src = (Bloom *)v4.fields.characterBloomControl;
			//   if ( !src )
			//     goto LABEL_112;
			//   v5.enableCharacterBloomControl = sub_1800023D0(10LL, src);
			//   v5.enableAlpha = 0;
			//   src = (Bloom *)v4.fields.anamorphic;
			//   if ( !src )
			//     goto LABEL_112;
			//   v5.enableAnamorphic = sub_1800023D0(10LL, src);
			// }
			// 
		}
	}
}
