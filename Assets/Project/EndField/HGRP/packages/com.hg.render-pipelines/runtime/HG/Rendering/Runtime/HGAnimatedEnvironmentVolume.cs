using System;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[AddComponentMenu("Rendering/Animated Environment Volume")]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	public class HGAnimatedEnvironmentVolume : HGEnvironmentVolume
	{
		// (get) Token: 0x060005B2 RID: 1458 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x060005B3 RID: 1459 RVA: 0x000025D0 File Offset: 0x000007D0
		public override HGEnvironmentPhase envPhase
		{
			get
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
			set
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
		}

		public HGAnimatedEnvironmentVolume()
		{
			// // HGAnimatedEnvironmentVolume()
			// void HG::Rendering::Runtime::HGAnimatedEnvironmentVolume::HGAnimatedEnvironmentVolume(
			//         HGAnimatedEnvironmentVolume *this,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdi
			//   __int64 v4; // rdx
			//   HGLightConfig__StaticFields *static_fields; // rcx
			//   Color *v6; // rax
			//   Color v7; // xmm1
			//   Color v8; // xmm0
			//   Color v9; // xmm1
			//   Color v10; // xmm0
			//   Color v11; // xmm1
			//   Color v12; // xmm0
			//   Color v13; // xmm1
			//   __int64 v14; // rdx
			//   Color v15; // xmm1
			//   Color v16; // xmm0
			//   Color v17; // xmm1
			//   Color v18; // xmm0
			//   Color v19; // xmm1
			//   Color *v20; // rcx
			//   HGLightConfig *p_lightConfig; // rax
			//   Color v22; // xmm1
			//   Color v23; // xmm0
			//   Color v24; // xmm1
			//   Color v25; // xmm0
			//   Color v26; // xmm1
			//   Color v27; // xmm0
			//   Color v28; // xmm1
			//   Color v29; // xmm1
			//   Color v30; // xmm0
			//   Color v31; // xmm1
			//   Color v32; // xmm0
			//   Color v33; // xmm1
			//   FileDescriptor *v34; // r8
			//   MessageDescriptor *v35; // r9
			//   __int128 *v36; // rcx
			//   __int64 v37; // rdx
			//   HGSkyConfig__StaticFields *v38; // rax
			//   __int128 v39; // xmm1
			//   __int128 v40; // xmm0
			//   __int128 v41; // xmm1
			//   __int128 v42; // xmm0
			//   __int128 v43; // xmm1
			//   __int128 v44; // xmm0
			//   __int128 v45; // xmm1
			//   __int64 v46; // rdx
			//   __int128 v47; // xmm1
			//   __int128 v48; // xmm0
			//   __int128 v49; // xmm1
			//   __int128 v50; // xmm0
			//   __int64 v51; // rax
			//   HGSkyConfig *p_skyConfig; // rcx
			//   __int128 *v53; // rax
			//   __int128 v54; // xmm1
			//   __int128 v55; // xmm0
			//   __int128 v56; // xmm1
			//   __int128 v57; // xmm0
			//   __int128 v58; // xmm1
			//   __int128 v59; // xmm0
			//   __int128 v60; // xmm1
			//   __int128 v61; // xmm1
			//   __int128 v62; // xmm0
			//   __int128 v63; // xmm1
			//   __int128 v64; // xmm0
			//   __int64 v65; // rax
			//   HGAtmosphereConfig__StaticFields *v66; // rax
			//   Color v67; // xmm1
			//   __int128 v68; // xmm0
			//   Color rayleighScattering; // xmm1
			//   __int128 v70; // xmm0
			//   Color v71; // xmm1
			//   __int128 v72; // xmm0
			//   __int128 v73; // xmm1
			//   __int128 v74; // xmm0
			//   __int64 v75; // rax
			//   Color v76; // xmm1
			//   __int128 v77; // xmm0
			//   Color v78; // xmm1
			//   __int128 v79; // xmm0
			//   Color v80; // xmm1
			//   __int128 v81; // xmm0
			//   __int128 v82; // xmm1
			//   __int128 v83; // xmm0
			//   __int64 v84; // rax
			//   HGFogConfig__StaticFields *v85; // rcx
			//   int v86; // eax
			//   __int128 v87; // xmm1
			//   __int128 v88; // xmm2
			//   __int128 v89; // xmm3
			//   Color inscatterAmbientColor; // xmm4
			//   HGHeightFogConfig__StaticFields *v91; // rax
			//   Color v92; // xmm1
			//   __int128 v93; // xmm0
			//   Color v94; // xmm1
			//   __int128 v95; // xmm0
			//   Color v96; // xmm1
			//   __int128 v97; // xmm0
			//   __int128 v98; // xmm1
			//   __int128 v99; // xmm0
			//   Color v100; // xmm1
			//   Color v101; // xmm0
			//   Color v102; // xmm1
			//   __int64 v103; // rax
			//   Color v104; // xmm1
			//   __int128 v105; // xmm0
			//   Color v106; // xmm1
			//   __int128 v107; // xmm0
			//   Color v108; // xmm1
			//   __int128 v109; // xmm0
			//   __int128 v110; // xmm1
			//   __int128 v111; // xmm0
			//   Color v112; // xmm1
			//   Color v113; // xmm0
			//   Color v114; // xmm1
			//   __int64 v115; // rax
			//   __int64 v116; // rdx
			//   HGVolumetricFogConfig__StaticFields *v117; // rcx
			//   __int128 *v118; // rax
			//   __int128 v119; // xmm1
			//   __int128 v120; // xmm0
			//   __int128 v121; // xmm1
			//   __int128 v122; // xmm0
			//   __int128 v123; // xmm1
			//   __int128 v124; // xmm0
			//   __int128 v125; // xmm1
			//   HGVolumetricFogConfig *p_volumetricFogConfig; // rax
			//   __int64 v127; // rdx
			//   __int128 *v128; // rcx
			//   __int128 v129; // xmm1
			//   __int128 v130; // xmm0
			//   __int128 v131; // xmm1
			//   __int128 v132; // xmm0
			//   __int128 v133; // xmm1
			//   __int128 v134; // xmm0
			//   __int128 v135; // xmm1
			//   HGCloudConfig__StaticFields *v136; // rcx
			//   Color cloudTint; // xmm1
			//   __int128 v138; // xmm0
			//   Color v139; // xmm1
			//   __int128 v140; // xmm0
			//   Color v141; // xmm1
			//   __int128 v142; // xmm0
			//   __int128 v143; // xmm1
			//   __int128 v144; // xmm0
			//   Color v145; // xmm1
			//   Color v146; // xmm0
			//   Color v147; // xmm1
			//   __int128 v148; // xmm0
			//   Color v149; // xmm1
			//   __int128 v150; // xmm0
			//   Color v151; // xmm1
			//   __int128 v152; // xmm0
			//   __int128 v153; // xmm1
			//   __int128 v154; // xmm0
			//   Color v155; // xmm1
			//   Color v156; // xmm0
			//   OneofDescriptorProto *v157; // rdx
			//   FileDescriptor *v158; // r8
			//   MessageDescriptor *v159; // r9
			//   FileDescriptor *v160; // r8
			//   MessageDescriptor *v161; // r9
			//   __int128 *v162; // rcx
			//   __int64 v163; // rdx
			//   HGCelestialConfig__StaticFields *v164; // rax
			//   __int128 v165; // xmm1
			//   __int128 v166; // xmm0
			//   __int128 v167; // xmm1
			//   __int128 v168; // xmm0
			//   __int128 v169; // xmm1
			//   __int128 v170; // xmm0
			//   __int128 v171; // xmm1
			//   __int64 v172; // rdx
			//   __int128 v173; // xmm1
			//   __int128 v174; // xmm0
			//   __int128 v175; // xmm1
			//   __int128 v176; // xmm0
			//   __int128 v177; // xmm1
			//   Material *drawMaterial; // rax
			//   HGCelestialConfig *p_celestialConfig; // rcx
			//   __int128 *v180; // rax
			//   __int128 v181; // xmm1
			//   __int128 v182; // xmm0
			//   __int128 v183; // xmm1
			//   __int128 v184; // xmm0
			//   __int128 v185; // xmm1
			//   __int128 v186; // xmm0
			//   __int128 v187; // xmm1
			//   __int128 v188; // xmm1
			//   __int128 v189; // xmm0
			//   __int128 v190; // xmm1
			//   __int128 v191; // xmm0
			//   __int128 v192; // xmm1
			//   Material *v193; // rax
			//   HGWindConfig__StaticFields *v194; // rcx
			//   int v195; // eax
			//   HGLightShaftConfig__StaticFields *v196; // rcx
			//   int v197; // eax
			//   Color bloomTint; // xmm1
			//   __int128 v199; // xmm2
			//   HGTerrainDeformConfig__StaticFields *v200; // rcx
			//   int v201; // eax
			//   __int64 v202; // rdx
			//   HGRainConfig__StaticFields *v203; // rcx
			//   __int128 *v204; // rax
			//   __int128 v205; // xmm1
			//   __int128 v206; // xmm0
			//   __int128 v207; // xmm1
			//   __int128 v208; // xmm0
			//   __int128 v209; // xmm1
			//   __int128 v210; // xmm0
			//   __int128 v211; // xmm1
			//   __int64 v212; // rdx
			//   __int128 v213; // xmm1
			//   __int128 v214; // xmm0
			//   __int128 *v215; // rcx
			//   HGRainConfig *p_rainConfig; // rax
			//   __int128 v217; // xmm1
			//   __int128 v218; // xmm0
			//   __int128 v219; // xmm1
			//   __int128 v220; // xmm0
			//   __int128 v221; // xmm1
			//   __int128 v222; // xmm0
			//   __int128 v223; // xmm1
			//   __int128 v224; // xmm1
			//   __int128 v225; // xmm0
			//   HGSnowConfig__StaticFields *v226; // rcx
			//   __int128 v227; // xmm2
			//   __int128 v228; // xmm3
			//   __int128 v229; // xmm4
			//   HGStarConfig__StaticFields *v230; // rcx
			//   Color starsTint; // xmm1
			//   __int128 v232; // xmm0
			//   Color starsTint1; // xmm1
			//   __int128 v234; // xmm0
			//   Color starsTint2; // xmm1
			//   __int128 v236; // xmm0
			//   __int128 v237; // xmm1
			//   __int128 v238; // xmm0
			//   Color v239; // xmm1
			//   Color v240; // xmm0
			//   Color v241; // xmm1
			//   Color v242; // xmm1
			//   __int128 v243; // xmm0
			//   Color v244; // xmm1
			//   __int128 v245; // xmm0
			//   Color v246; // xmm1
			//   __int128 v247; // xmm0
			//   __int128 v248; // xmm1
			//   __int128 v249; // xmm0
			//   Color v250; // xmm1
			//   Color v251; // xmm0
			//   Color v252; // xmm1
			//   OneofDescriptorProto *v253; // rdx
			//   FileDescriptor *v254; // r8
			//   MessageDescriptor *v255; // r9
			//   HGLensFlareConfig__StaticFields *v256; // rcx
			//   __int128 v257; // xmm1
			//   __int128 v258; // xmm2
			//   OneofDescriptorProto *v259; // rdx
			//   FileDescriptor *v260; // r8
			//   MessageDescriptor *v261; // r9
			//   FileDescriptor *v262; // r8
			//   MessageDescriptor *v263; // r9
			//   __int64 v264; // rdx
			//   __int128 *v265; // rax
			//   HGColorGradingConfig *p_defaultConfig; // rcx
			//   __int128 v267; // xmm1
			//   __int128 v268; // xmm0
			//   __int128 v269; // xmm1
			//   __int128 v270; // xmm0
			//   __int128 v271; // xmm1
			//   __int128 v272; // xmm0
			//   Vector4 shadows; // xmm1
			//   __int128 v274; // xmm1
			//   __int128 v275; // xmm0
			//   __int128 v276; // xmm1
			//   __int128 v277; // xmm0
			//   __int128 v278; // xmm1
			//   __int128 v279; // xmm0
			//   __int128 *v280; // rcx
			//   HGColorGradingConfig *p_colorGradingConfig; // rax
			//   __int128 v282; // xmm1
			//   __int128 v283; // xmm0
			//   __int128 v284; // xmm1
			//   __int128 v285; // xmm0
			//   __int128 v286; // xmm1
			//   __int128 v287; // xmm0
			//   __int128 v288; // xmm1
			//   __int128 v289; // xmm1
			//   __int128 v290; // xmm0
			//   __int128 v291; // xmm1
			//   __int128 v292; // xmm0
			//   __int128 v293; // xmm1
			//   __int128 v294; // xmm0
			//   HGAutoExposureConfig__StaticFields *v295; // rcx
			//   int v296; // eax
			//   __int128 v297; // xmm2
			//   __int128 v298; // xmm3
			//   HGShadowConfig__StaticFields *v299; // rcx
			//   __int128 v300; // xmm2
			//   __int128 v301; // xmm3
			//   __int128 v302; // xmm4
			//   __int128 v303; // xmm5
			//   __int128 v304; // xmm6
			//   OneofDescriptorProto *v305; // rdx
			//   FileDescriptor *v306; // r8
			//   MessageDescriptor *v307; // r9
			//   HGAnamorphicStreaksConfig__StaticFields *v308; // rcx
			//   Color v309; // xmm1
			//   __int128 v310; // xmm2
			//   __int128 v311; // [rsp+28h] [rbp-E0h] BYREF
			//   Color v312; // [rsp+38h] [rbp-D0h]
			//   __int128 v313; // [rsp+48h] [rbp-C0h]
			//   Color v314; // [rsp+58h] [rbp-B0h]
			//   __int128 v315; // [rsp+68h] [rbp-A0h]
			//   Color v316; // [rsp+78h] [rbp-90h]
			//   __int128 v317; // [rsp+88h] [rbp-80h]
			//   __int128 v318; // [rsp+98h] [rbp-70h]
			//   __int128 v319; // [rsp+A8h] [rbp-60h]
			//   Color v320; // [rsp+B8h] [rbp-50h]
			//   Color v321; // [rsp+C8h] [rbp-40h]
			//   Color v322; // [rsp+D8h] [rbp-30h]
			//   __int64 v323; // [rsp+E8h] [rbp-20h]
			// 
			//   if ( !byte_18D919D5B )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGAnamorphicStreaksConfig);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGAtmosphereConfig);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGAutoExposureConfig);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCelestialConfig);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCloudConfig);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGFogConfig);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGHeightFogConfig);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGLensFlareConfig);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGLightConfig);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGLightShaftConfig);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRainConfig);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShadowConfig);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGSkyConfig);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGSnowConfig);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGStarConfig);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGTerrainDeformConfig);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGWindConfig);
			//     byte_18D919D5B = 1;
			//   }
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGLightConfig);
			//   v3 = 2LL;
			//   v4 = 2LL;
			//   static_fields = TypeInfo::HG::Rendering::Runtime::HGLightConfig.static_fields;
			//   v6 = (Color *)&v311;
			//   do
			//   {
			//     v7 = *(Color *)&static_fields.defaultConfig.directColorMode;
			//     *v6 = static_fields.defaultConfig.directColor;
			//     v8 = *(Color *)&static_fields.defaultConfig.directCustomColor.a;
			//     v6[1] = v7;
			//     v9 = *(Color *)&static_fields.defaultConfig.directSpecularIntensity;
			//     v6[2] = v8;
			//     v10 = *(Color *)&static_fields.defaultConfig.indirectDiffuseFactor;
			//     v6[3] = v9;
			//     v11 = *(Color *)&static_fields.defaultConfig.atmospherePitchYaw.x;
			//     v6[4] = v10;
			//     v12 = *(Color *)&static_fields.defaultConfig.lightShaftPitchYaw.y;
			//     v6[5] = v11;
			//     v13 = *(Color *)&static_fields.defaultConfig.lensFlarePitchYawMode;
			//     static_fields = (HGLightConfig__StaticFields *)((char *)static_fields + 128);
			//     v6[6] = v12;
			//     v6 += 8;
			//     v6[-1] = v13;
			//     --v4;
			//   }
			//   while ( v4 );
			//   v14 = 2LL;
			//   v15 = *(Color *)&static_fields.defaultConfig.directColorMode;
			//   *v6 = static_fields.defaultConfig.directColor;
			//   v16 = *(Color *)&static_fields.defaultConfig.directCustomColor.a;
			//   v6[1] = v15;
			//   v17 = *(Color *)&static_fields.defaultConfig.directSpecularIntensity;
			//   v6[2] = v16;
			//   v18 = *(Color *)&static_fields.defaultConfig.indirectDiffuseFactor;
			//   v6[3] = v17;
			//   v19 = *(Color *)&static_fields.defaultConfig.atmospherePitchYaw.x;
			//   v20 = (Color *)&v311;
			//   v6[4] = v18;
			//   v6[5] = v19;
			//   p_lightConfig = &this.fields.lightConfig;
			//   do
			//   {
			//     v22 = v20[1];
			//     p_lightConfig.directColor = *v20;
			//     v23 = v20[2];
			//     *(Color *)&p_lightConfig.directColorMode = v22;
			//     v24 = v20[3];
			//     *(Color *)&p_lightConfig.directCustomColor.a = v23;
			//     v25 = v20[4];
			//     *(Color *)&p_lightConfig.directSpecularIntensity = v24;
			//     v26 = v20[5];
			//     *(Color *)&p_lightConfig.indirectDiffuseFactor = v25;
			//     v27 = v20[6];
			//     *(Color *)&p_lightConfig.atmospherePitchYaw.x = v26;
			//     v28 = v20[7];
			//     v20 += 8;
			//     *(Color *)&p_lightConfig.lightShaftPitchYaw.y = v27;
			//     p_lightConfig = (HGLightConfig *)((char *)p_lightConfig + 128);
			//     *(Color *)&p_lightConfig[-1].rotationHeightFogDirectionalInscattering.y = v28;
			//     --v14;
			//   }
			//   while ( v14 );
			//   v29 = v20[1];
			//   p_lightConfig.directColor = *v20;
			//   v30 = v20[2];
			//   *(Color *)&p_lightConfig.directColorMode = v29;
			//   v31 = v20[3];
			//   *(Color *)&p_lightConfig.directCustomColor.a = v30;
			//   v32 = v20[4];
			//   *(Color *)&p_lightConfig.directSpecularIntensity = v31;
			//   v33 = v20[5];
			//   *(Color *)&p_lightConfig.indirectDiffuseFactor = v32;
			//   *(Color *)&p_lightConfig.atmospherePitchYaw.x = v33;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGSkyConfig);
			//   v36 = &v311;
			//   v37 = 2LL;
			//   v38 = TypeInfo::HG::Rendering::Runtime::HGSkyConfig.static_fields;
			//   do
			//   {
			//     v39 = *(_OWORD *)&v38.defaultConfig.skyDirectIntensity;
			//     *v36 = *(_OWORD *)&v38.defaultConfig.parentEnvPhaseGuid;
			//     v40 = *(_OWORD *)&v38.defaultConfig.customIVDefaultSH.shr2;
			//     v36[1] = v39;
			//     v41 = *(_OWORD *)&v38.defaultConfig.customIVDefaultSH.shr6;
			//     v36[2] = v40;
			//     v42 = *(_OWORD *)&v38.defaultConfig.customIVDefaultSH.shg1;
			//     v36[3] = v41;
			//     v43 = *(_OWORD *)&v38.defaultConfig.customIVDefaultSH.shg5;
			//     v36[4] = v42;
			//     v44 = *(_OWORD *)&v38.defaultConfig.customIVDefaultSH.shb0;
			//     v36[5] = v43;
			//     v45 = *(_OWORD *)&v38.defaultConfig.customIVDefaultSH.shb4;
			//     v38 = (HGSkyConfig__StaticFields *)((char *)v38 + 128);
			//     v36[6] = v44;
			//     v36 += 8;
			//     *(v36 - 1) = v45;
			//     --v37;
			//   }
			//   while ( v37 );
			//   v46 = 2LL;
			//   v47 = *(_OWORD *)&v38.defaultConfig.skyDirectIntensity;
			//   *v36 = *(_OWORD *)&v38.defaultConfig.parentEnvPhaseGuid;
			//   v48 = *(_OWORD *)&v38.defaultConfig.customIVDefaultSH.shr2;
			//   v36[1] = v47;
			//   v49 = *(_OWORD *)&v38.defaultConfig.customIVDefaultSH.shr6;
			//   v36[2] = v48;
			//   v50 = *(_OWORD *)&v38.defaultConfig.customIVDefaultSH.shg1;
			//   v51 = *(_QWORD *)&v38.defaultConfig.customIVDefaultSH.shg5;
			//   v36[3] = v49;
			//   v36[4] = v50;
			//   *((_QWORD *)v36 + 10) = v51;
			//   p_skyConfig = &this.fields.skyConfig;
			//   v53 = &v311;
			//   do
			//   {
			//     v54 = v53[1];
			//     *(_OWORD *)&p_skyConfig.parentEnvPhaseGuid = *v53;
			//     v55 = v53[2];
			//     *(_OWORD *)&p_skyConfig.skyDirectIntensity = v54;
			//     v56 = v53[3];
			//     *(_OWORD *)&p_skyConfig.customIVDefaultSH.shr2 = v55;
			//     v57 = v53[4];
			//     *(_OWORD *)&p_skyConfig.customIVDefaultSH.shr6 = v56;
			//     v58 = v53[5];
			//     *(_OWORD *)&p_skyConfig.customIVDefaultSH.shg1 = v57;
			//     v59 = v53[6];
			//     *(_OWORD *)&p_skyConfig.customIVDefaultSH.shg5 = v58;
			//     v60 = v53[7];
			//     v53 += 8;
			//     *(_OWORD *)&p_skyConfig.customIVDefaultSH.shb0 = v59;
			//     p_skyConfig = (HGSkyConfig *)((char *)p_skyConfig + 128);
			//     *(_OWORD *)&p_skyConfig[-1].skyboxCubeMap = v60;
			//     --v46;
			//   }
			//   while ( v46 );
			//   v61 = v53[1];
			//   *(_OWORD *)&p_skyConfig.parentEnvPhaseGuid = *v53;
			//   v62 = v53[2];
			//   *(_OWORD *)&p_skyConfig.skyDirectIntensity = v61;
			//   v63 = v53[3];
			//   *(_OWORD *)&p_skyConfig.customIVDefaultSH.shr2 = v62;
			//   v64 = v53[4];
			//   v65 = *((_QWORD *)v53 + 10);
			//   *(_OWORD *)&p_skyConfig.customIVDefaultSH.shr6 = v63;
			//   *(_OWORD *)&p_skyConfig.customIVDefaultSH.shg1 = v64;
			//   *(_QWORD *)&p_skyConfig.customIVDefaultSH.shg5 = v65;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.skyConfig,
			//     0LL,
			//     v34,
			//     v35,
			//     (String__Array *)v311,
			//     *((String **)&v311 + 1),
			//     *(MethodInfo **)&v312.r);
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGAtmosphereConfig);
			//   v66 = TypeInfo::HG::Rendering::Runtime::HGAtmosphereConfig.static_fields;
			//   v67 = *(Color *)&v66.defaultConfig.groundAlbedo.a;
			//   v311 = *(_OWORD *)&v66.defaultConfig.groundRadius;
			//   v68 = *(_OWORD *)&v66.defaultConfig.outerSunIrradianceColor.a;
			//   v312 = v67;
			//   rayleighScattering = v66.defaultConfig.rayleighScattering;
			//   v313 = v68;
			//   v70 = *(_OWORD *)&v66.defaultConfig.rayleighExponentialDistribution;
			//   v314 = rayleighScattering;
			//   v71 = *(Color *)&v66.defaultConfig.mieScattering.b;
			//   v315 = v70;
			//   v72 = *(_OWORD *)&v66.defaultConfig.mieAbsorption.g;
			//   v316 = v71;
			//   v73 = *(_OWORD *)&v66.defaultConfig.mieExponentialDistribution;
			//   v317 = v72;
			//   v74 = *(_OWORD *)&v66.defaultConfig.ozoneAbsorption.b;
			//   v75 = *(_QWORD *)&v66.defaultConfig.tentWidth;
			//   v318 = v73;
			//   v319 = v74;
			//   *(_QWORD *)&v320.r = v75;
			//   v76 = v312;
			//   *(_OWORD *)&this.fields.atmosphereConfig.groundRadius = v311;
			//   v77 = v313;
			//   *(Color *)&this.fields.atmosphereConfig.groundAlbedo.a = v76;
			//   v78 = v314;
			//   *(_OWORD *)&this.fields.atmosphereConfig.outerSunIrradianceColor.a = v77;
			//   v79 = v315;
			//   this.fields.atmosphereConfig.rayleighScattering = v78;
			//   v80 = v316;
			//   *(_OWORD *)&this.fields.atmosphereConfig.rayleighExponentialDistribution = v79;
			//   v81 = v317;
			//   *(Color *)&this.fields.atmosphereConfig.mieScattering.b = v80;
			//   v82 = v318;
			//   *(_OWORD *)&this.fields.atmosphereConfig.mieAbsorption.g = v81;
			//   v83 = v319;
			//   v84 = *(_QWORD *)&v320.r;
			//   *(_OWORD *)&this.fields.atmosphereConfig.mieExponentialDistribution = v82;
			//   *(_OWORD *)&this.fields.atmosphereConfig.ozoneAbsorption.b = v83;
			//   *(_QWORD *)&this.fields.atmosphereConfig.tentWidth = v84;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGFogConfig);
			//   v85 = TypeInfo::HG::Rendering::Runtime::HGFogConfig.static_fields;
			//   v86 = *(_DWORD *)&v85.defaultConfig.m_active;
			//   v87 = *(_OWORD *)&v85.defaultConfig.fallOffDistance;
			//   v88 = *(_OWORD *)&v85.defaultConfig.mieScattering.a;
			//   v89 = *(_OWORD *)&v85.defaultConfig.rayleighScattering.g;
			//   inscatterAmbientColor = v85.defaultConfig.inscatterAmbientColor;
			//   *(_OWORD *)&this.fields.fogConfig.enable = *(_OWORD *)&v85.defaultConfig.enable;
			//   *(_OWORD *)&this.fields.fogConfig.fallOffDistance = v87;
			//   *(_OWORD *)&this.fields.fogConfig.mieScattering.a = v88;
			//   *(_OWORD *)&this.fields.fogConfig.rayleighScattering.g = v89;
			//   this.fields.fogConfig.inscatterAmbientColor = inscatterAmbientColor;
			//   *(_DWORD *)&this.fields.fogConfig.m_active = v86;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGHeightFogConfig);
			//   v91 = TypeInfo::HG::Rendering::Runtime::HGHeightFogConfig.static_fields;
			//   v92 = *(Color *)&v91.defaultConfig.heightFogStartHeightSecond;
			//   v311 = *(_OWORD *)&v91.defaultConfig.enable;
			//   v93 = *(_OWORD *)&v91.defaultConfig.heightFogInscatter.g;
			//   v312 = v92;
			//   v94 = *(Color *)&v91.defaultConfig.heightFogStartDistance;
			//   v313 = v93;
			//   v95 = *(_OWORD *)&v91.defaultConfig.heightFogCullingFarClipPlane;
			//   v314 = v94;
			//   v96 = *(Color *)&v91.defaultConfig.heightFogDirectionalInscattering.g;
			//   v315 = v95;
			//   v97 = *(_OWORD *)&v91.defaultConfig.volumetricFogScatteringDistribution;
			//   v316 = v96;
			//   v98 = *(_OWORD *)&v91.defaultConfig.volumetricFogAlbedo.a;
			//   v91 = (HGHeightFogConfig__StaticFields *)((char *)v91 + 128);
			//   v317 = v97;
			//   v99 = *(_OWORD *)&v91.defaultConfig.enable;
			//   v318 = v98;
			//   v100 = *(Color *)&v91.defaultConfig.heightFogStartHeightSecond;
			//   v319 = v99;
			//   v101 = *(Color *)&v91.defaultConfig.heightFogInscatter.g;
			//   v320 = v100;
			//   v102 = *(Color *)&v91.defaultConfig.heightFogStartDistance;
			//   v103 = *(_QWORD *)&v91.defaultConfig.heightFogCullingFarClipPlane;
			//   v321 = v101;
			//   v322 = v102;
			//   v323 = v103;
			//   v104 = v312;
			//   *(_OWORD *)&this.fields.heightFogConfig.enable = v311;
			//   v105 = v313;
			//   *(Color *)&this.fields.heightFogConfig.heightFogStartHeightSecond = v104;
			//   v106 = v314;
			//   *(_OWORD *)&this.fields.heightFogConfig.heightFogInscatter.g = v105;
			//   v107 = v315;
			//   *(Color *)&this.fields.heightFogConfig.heightFogStartDistance = v106;
			//   v108 = v316;
			//   *(_OWORD *)&this.fields.heightFogConfig.heightFogCullingFarClipPlane = v107;
			//   v109 = v317;
			//   *(Color *)&this.fields.heightFogConfig.heightFogDirectionalInscattering.g = v108;
			//   v110 = v318;
			//   *(_OWORD *)&this.fields.heightFogConfig.volumetricFogScatteringDistribution = v109;
			//   v111 = v319;
			//   *(_OWORD *)&this.fields.heightFogConfig.volumetricFogAlbedo.a = v110;
			//   v112 = v320;
			//   *(_OWORD *)&this.fields.heightFogConfig.volumetricFogEmissive.a = v111;
			//   v113 = v321;
			//   *(Color *)&this.fields.heightFogConfig.volumetricFogNearFadeInDistance = v112;
			//   v114 = v322;
			//   v115 = v323;
			//   *(Color *)&this.fields.heightFogConfig.flowNoiseIntensity = v113;
			//   *(Color *)&this.fields.heightFogConfig.flowNoiseVerticalDirAngle = v114;
			//   *(_QWORD *)&this.fields.heightFogConfig.flowNoiseSpeed = v115;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig);
			//   v116 = 2LL;
			//   v117 = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig.static_fields;
			//   v118 = &v311;
			//   do
			//   {
			//     v119 = *(_OWORD *)&v117.defaultConfig.heightFogStartHeightSecond;
			//     *v118 = *(_OWORD *)&v117.defaultConfig.enable;
			//     v120 = *(_OWORD *)&v117.defaultConfig.heightFogInscatter.g;
			//     v118[1] = v119;
			//     v121 = *(_OWORD *)&v117.defaultConfig.heightFogStartDistance;
			//     v118[2] = v120;
			//     v122 = *(_OWORD *)&v117.defaultConfig.heightFogDirectionalInscatteringExponent;
			//     v118[3] = v121;
			//     v123 = *(_OWORD *)&v117.defaultConfig.heightFogDirectionalInscattering.b;
			//     v118[4] = v122;
			//     v124 = *(_OWORD *)&v117.defaultConfig.volumetricFogAlbedo.g;
			//     v118[5] = v123;
			//     v125 = *(_OWORD *)&v117.defaultConfig.volumetricFogEmissive.g;
			//     v117 = (HGVolumetricFogConfig__StaticFields *)((char *)v117 + 128);
			//     v118[6] = v124;
			//     v118 += 8;
			//     *(v118 - 1) = v125;
			//     --v116;
			//   }
			//   while ( v116 );
			//   p_volumetricFogConfig = &this.fields.volumetricFogConfig;
			//   v127 = 2LL;
			//   v128 = &v311;
			//   do
			//   {
			//     v129 = v128[1];
			//     *(_OWORD *)&p_volumetricFogConfig.enable = *v128;
			//     v130 = v128[2];
			//     *(_OWORD *)&p_volumetricFogConfig.heightFogStartHeightSecond = v129;
			//     v131 = v128[3];
			//     *(_OWORD *)&p_volumetricFogConfig.heightFogInscatter.g = v130;
			//     v132 = v128[4];
			//     *(_OWORD *)&p_volumetricFogConfig.heightFogStartDistance = v131;
			//     v133 = v128[5];
			//     *(_OWORD *)&p_volumetricFogConfig.heightFogDirectionalInscatteringExponent = v132;
			//     v134 = v128[6];
			//     *(_OWORD *)&p_volumetricFogConfig.heightFogDirectionalInscattering.b = v133;
			//     v135 = v128[7];
			//     v128 += 8;
			//     *(_OWORD *)&p_volumetricFogConfig.volumetricFogAlbedo.g = v134;
			//     p_volumetricFogConfig = (HGVolumetricFogConfig *)((char *)p_volumetricFogConfig + 128);
			//     *(_OWORD *)&p_volumetricFogConfig[-1].m_backupVLNoiseHorizontalDirAngle = v135;
			//     --v127;
			//   }
			//   while ( v127 );
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGCloudConfig);
			//   v136 = TypeInfo::HG::Rendering::Runtime::HGCloudConfig.static_fields;
			//   cloudTint = v136.defaultConfig.cloudTint;
			//   v311 = *(_OWORD *)&v136.defaultConfig.enable;
			//   v138 = *(_OWORD *)&v136.defaultConfig.cloudContrast;
			//   v312 = cloudTint;
			//   v139 = *(Color *)&v136.defaultConfig.brightnessAffectCloudAlpha;
			//   v313 = v138;
			//   v140 = *(_OWORD *)&v136.defaultConfig.cloudFlowType;
			//   v314 = v139;
			//   v141 = *(Color *)&v136.defaultConfig.flowSpeed;
			//   v315 = v140;
			//   v142 = *(_OWORD *)&v136.defaultConfig.lightShaftCloudMaskTexture;
			//   v316 = v141;
			//   v143 = *(_OWORD *)&v136.defaultConfig.cloudShadowConfig.cloudShadowTexture;
			//   v317 = v142;
			//   v144 = *(_OWORD *)&v136.defaultConfig.cloudShadowConfig.cloudShadowEnvCenter.z;
			//   v318 = v143;
			//   v145 = *(Color *)&v136.defaultConfig.cloudShadowConfig.cloudShadowFlowDirection.y;
			//   v319 = v144;
			//   v146 = *(Color *)&v136.defaultConfig.cloudShadowConfig.cloudShadowScaleEndDistance;
			//   v320 = v145;
			//   v321 = v146;
			//   v147 = v312;
			//   *(_OWORD *)&this.fields.cloudConfig.enable = v311;
			//   v148 = v313;
			//   this.fields.cloudConfig.cloudTint = v147;
			//   v149 = v314;
			//   *(_OWORD *)&this.fields.cloudConfig.cloudContrast = v148;
			//   v150 = v315;
			//   *(Color *)&this.fields.cloudConfig.brightnessAffectCloudAlpha = v149;
			//   v151 = v316;
			//   *(_OWORD *)&this.fields.cloudConfig.cloudFlowType = v150;
			//   v152 = v317;
			//   *(Color *)&this.fields.cloudConfig.flowSpeed = v151;
			//   v153 = v318;
			//   *(_OWORD *)&this.fields.cloudConfig.lightShaftCloudMaskTexture = v152;
			//   v154 = v319;
			//   *(_OWORD *)&this.fields.cloudConfig.cloudShadowConfig.cloudShadowTexture = v153;
			//   v155 = v320;
			//   *(_OWORD *)&this.fields.cloudConfig.cloudShadowConfig.cloudShadowEnvCenter.z = v154;
			//   v156 = v321;
			//   *(Color *)&this.fields.cloudConfig.cloudShadowConfig.cloudShadowFlowDirection.y = v155;
			//   *(Color *)&this.fields.cloudConfig.cloudShadowConfig.cloudShadowScaleEndDistance = v156;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.cloudConfig.cloudTexture,
			//     v157,
			//     v158,
			//     v159,
			//     (String__Array *)v311,
			//     *((String **)&v311 + 1),
			//     *(MethodInfo **)&v312.r);
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGCelestialConfig);
			//   v162 = &v311;
			//   v163 = 2LL;
			//   v164 = TypeInfo::HG::Rendering::Runtime::HGCelestialConfig.static_fields;
			//   do
			//   {
			//     v165 = *(_OWORD *)&v164.defaultConfig.moonConfig.worldLongitude;
			//     *v162 = *(_OWORD *)&v164.defaultConfig.moonConfig.radius;
			//     v166 = *(_OWORD *)&v164.defaultConfig.moonConfig.ring.outerRadius;
			//     v162[1] = v165;
			//     v167 = *(_OWORD *)&v164.defaultConfig.moonConfig.ring.ringColor.b;
			//     v162[2] = v166;
			//     v168 = *(_OWORD *)&v164.defaultConfig.talosAlphaConfig.drawPlanetInSkydome;
			//     v162[3] = v167;
			//     v169 = *(_OWORD *)&v164.defaultConfig.talosAlphaConfig.objectProperty.selfTiltZ;
			//     v162[4] = v168;
			//     v170 = *(_OWORD *)&v164.defaultConfig.talosAlphaConfig.skydomeDrawer.drawMaterial;
			//     v162[5] = v169;
			//     v171 = *(_OWORD *)&v164.defaultConfig.talosAlphaConfig.skydomeDrawer.incidentLightingPitchYaw.x;
			//     v164 = (HGCelestialConfig__StaticFields *)((char *)v164 + 128);
			//     v162[6] = v170;
			//     v162 += 8;
			//     *(v162 - 1) = v171;
			//     --v163;
			//   }
			//   while ( v163 );
			//   v172 = 2LL;
			//   v173 = *(_OWORD *)&v164.defaultConfig.moonConfig.worldLongitude;
			//   *v162 = *(_OWORD *)&v164.defaultConfig.moonConfig.radius;
			//   v174 = *(_OWORD *)&v164.defaultConfig.moonConfig.ring.outerRadius;
			//   v162[1] = v173;
			//   v175 = *(_OWORD *)&v164.defaultConfig.moonConfig.ring.ringColor.b;
			//   v162[2] = v174;
			//   v176 = *(_OWORD *)&v164.defaultConfig.talosAlphaConfig.drawPlanetInSkydome;
			//   v162[3] = v175;
			//   v177 = *(_OWORD *)&v164.defaultConfig.talosAlphaConfig.objectProperty.selfTiltZ;
			//   drawMaterial = v164.defaultConfig.talosAlphaConfig.skydomeDrawer.drawMaterial;
			//   v162[4] = v176;
			//   v162[5] = v177;
			//   *((_QWORD *)v162 + 12) = drawMaterial;
			//   p_celestialConfig = &this.fields.celestialConfig;
			//   v180 = &v311;
			//   do
			//   {
			//     v181 = v180[1];
			//     *(_OWORD *)&p_celestialConfig.moonConfig.radius = *v180;
			//     v182 = v180[2];
			//     *(_OWORD *)&p_celestialConfig.moonConfig.worldLongitude = v181;
			//     v183 = v180[3];
			//     *(_OWORD *)&p_celestialConfig.moonConfig.ring.outerRadius = v182;
			//     v184 = v180[4];
			//     *(_OWORD *)&p_celestialConfig.moonConfig.ring.ringColor.b = v183;
			//     v185 = v180[5];
			//     *(_OWORD *)&p_celestialConfig.talosAlphaConfig.drawPlanetInSkydome = v184;
			//     v186 = v180[6];
			//     *(_OWORD *)&p_celestialConfig.talosAlphaConfig.objectProperty.selfTiltZ = v185;
			//     v187 = v180[7];
			//     v180 += 8;
			//     *(_OWORD *)&p_celestialConfig.talosAlphaConfig.skydomeDrawer.drawMaterial = v186;
			//     p_celestialConfig = (HGCelestialConfig *)((char *)p_celestialConfig + 128);
			//     *(_OWORD *)&p_celestialConfig[-1].advancedPlanetConfig.advancedPlanetMat = v187;
			//     --v172;
			//   }
			//   while ( v172 );
			//   v188 = v180[1];
			//   *(_OWORD *)&p_celestialConfig.moonConfig.radius = *v180;
			//   v189 = v180[2];
			//   *(_OWORD *)&p_celestialConfig.moonConfig.worldLongitude = v188;
			//   v190 = v180[3];
			//   *(_OWORD *)&p_celestialConfig.moonConfig.ring.outerRadius = v189;
			//   v191 = v180[4];
			//   *(_OWORD *)&p_celestialConfig.moonConfig.ring.ringColor.b = v190;
			//   v192 = v180[5];
			//   v193 = (Material *)*((_QWORD *)v180 + 12);
			//   *(_OWORD *)&p_celestialConfig.talosAlphaConfig.drawPlanetInSkydome = v191;
			//   *(_OWORD *)&p_celestialConfig.talosAlphaConfig.objectProperty.selfTiltZ = v192;
			//   p_celestialConfig.talosAlphaConfig.skydomeDrawer.drawMaterial = v193;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.celestialConfig.moonConfig.ring.planetRingMap,
			//     0LL,
			//     v160,
			//     v161,
			//     (String__Array *)v311,
			//     *((String **)&v311 + 1),
			//     *(MethodInfo **)&v312.r);
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGWindConfig);
			//   v194 = TypeInfo::HG::Rendering::Runtime::HGWindConfig.static_fields;
			//   v195 = *(_DWORD *)&v194.defaultConfig.m_active;
			//   *(_QWORD *)&v191 = *(_QWORD *)&v194.defaultConfig.direction.y;
			//   *(_OWORD *)&this.fields.windConfig.speed = *(_OWORD *)&v194.defaultConfig.speed;
			//   *(_QWORD *)&this.fields.windConfig.direction.y = v191;
			//   *(_DWORD *)&this.fields.windConfig.m_active = v195;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGLightShaftConfig);
			//   v196 = TypeInfo::HG::Rendering::Runtime::HGLightShaftConfig.static_fields;
			//   v197 = *(_DWORD *)&v196.defaultConfig.m_active;
			//   bloomTint = v196.defaultConfig.bloomTint;
			//   v199 = *(_OWORD *)&v196.defaultConfig.blurIntensity;
			//   *(_OWORD *)&this.fields.lightShaftConfig.enable = *(_OWORD *)&v196.defaultConfig.enable;
			//   this.fields.lightShaftConfig.bloomTint = bloomTint;
			//   *(_OWORD *)&this.fields.lightShaftConfig.blurIntensity = v199;
			//   *(_DWORD *)&this.fields.lightShaftConfig.m_active = v197;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGTerrainDeformConfig);
			//   v200 = TypeInfo::HG::Rendering::Runtime::HGTerrainDeformConfig.static_fields;
			//   v201 = *(_DWORD *)&v200.defaultConfig.m_active;
			//   *(_QWORD *)&this.fields.terrainDeformConfig.deformGlobalStrength = *(_QWORD *)&v200.defaultConfig.deformGlobalStrength;
			//   *(_DWORD *)&this.fields.terrainDeformConfig.m_active = v201;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRainConfig);
			//   v202 = 2LL;
			//   v203 = TypeInfo::HG::Rendering::Runtime::HGRainConfig.static_fields;
			//   v204 = &v311;
			//   do
			//   {
			//     v205 = *(_OWORD *)&v203.defaultConfig.color.g;
			//     *v204 = *(_OWORD *)&v203.defaultConfig.enable;
			//     v206 = *(_OWORD *)&v203.defaultConfig.horizontalRainAngle;
			//     v204[1] = v205;
			//     v207 = *(_OWORD *)&v203.defaultConfig.sceneEffectRainLightingPercent;
			//     v204[2] = v206;
			//     v208 = *(_OWORD *)&v203.defaultConfig.middleHorizontalRainAngle;
			//     v204[3] = v207;
			//     v209 = *(_OWORD *)&v203.defaultConfig.farRainAlphaMultiplier;
			//     v204[4] = v208;
			//     v210 = *(_OWORD *)&v203.defaultConfig.rainWaveHorizontalSpeed;
			//     v204[5] = v209;
			//     v211 = *(_OWORD *)&v203.defaultConfig.screenDropColor.g;
			//     v203 = (HGRainConfig__StaticFields *)((char *)v203 + 128);
			//     v204[6] = v210;
			//     v204 += 8;
			//     *(v204 - 1) = v211;
			//     --v202;
			//   }
			//   while ( v202 );
			//   v212 = 2LL;
			//   v213 = *(_OWORD *)&v203.defaultConfig.color.g;
			//   *v204 = *(_OWORD *)&v203.defaultConfig.enable;
			//   v214 = *(_OWORD *)&v203.defaultConfig.horizontalRainAngle;
			//   v215 = &v311;
			//   v204[1] = v213;
			//   v204[2] = v214;
			//   p_rainConfig = &this.fields.rainConfig;
			//   do
			//   {
			//     v217 = v215[1];
			//     *(_OWORD *)&p_rainConfig.enable = *v215;
			//     v218 = v215[2];
			//     *(_OWORD *)&p_rainConfig.color.g = v217;
			//     v219 = v215[3];
			//     *(_OWORD *)&p_rainConfig.horizontalRainAngle = v218;
			//     v220 = v215[4];
			//     *(_OWORD *)&p_rainConfig.sceneEffectRainLightingPercent = v219;
			//     v221 = v215[5];
			//     *(_OWORD *)&p_rainConfig.middleHorizontalRainAngle = v220;
			//     v222 = v215[6];
			//     *(_OWORD *)&p_rainConfig.farRainAlphaMultiplier = v221;
			//     v223 = v215[7];
			//     v215 += 8;
			//     *(_OWORD *)&p_rainConfig.rainWaveHorizontalSpeed = v222;
			//     p_rainConfig = (HGRainConfig *)((char *)p_rainConfig + 128);
			//     *(_OWORD *)&p_rainConfig[-1].farRainDirection.x = v223;
			//     --v212;
			//   }
			//   while ( v212 );
			//   v224 = v215[1];
			//   *(_OWORD *)&p_rainConfig.enable = *v215;
			//   v225 = v215[2];
			//   *(_OWORD *)&p_rainConfig.color.g = v224;
			//   *(_OWORD *)&p_rainConfig.horizontalRainAngle = v225;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGSnowConfig);
			//   v226 = TypeInfo::HG::Rendering::Runtime::HGSnowConfig.static_fields;
			//   v227 = *(_OWORD *)&v226.defaultConfig.color.g;
			//   v228 = *(_OWORD *)&v226.defaultConfig.snowSizeRange.y;
			//   v229 = *(_OWORD *)&v226.defaultConfig.snowLightingPercent;
			//   *(_QWORD *)&v225 = *(_QWORD *)&v226.defaultConfig.snowDirection.z;
			//   *(_OWORD *)&this.fields.snowConfig.enable = *(_OWORD *)&v226.defaultConfig.enable;
			//   *(_OWORD *)&this.fields.snowConfig.color.g = v227;
			//   *(_OWORD *)&this.fields.snowConfig.snowSizeRange.y = v228;
			//   *(_OWORD *)&this.fields.snowConfig.snowLightingPercent = v229;
			//   *(_QWORD *)&this.fields.snowConfig.snowDirection.z = v225;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGStarConfig);
			//   v230 = TypeInfo::HG::Rendering::Runtime::HGStarConfig.static_fields;
			//   starsTint = v230.defaultConfig.starsTint;
			//   v311 = *(_OWORD *)&v230.defaultConfig.enableStars;
			//   v232 = *(_OWORD *)&v230.defaultConfig.starsOffset0;
			//   v312 = starsTint;
			//   starsTint1 = v230.defaultConfig.starsTint1;
			//   v313 = v232;
			//   v234 = *(_OWORD *)&v230.defaultConfig.starsOffset1;
			//   v314 = starsTint1;
			//   starsTint2 = v230.defaultConfig.starsTint2;
			//   v315 = v234;
			//   v236 = *(_OWORD *)&v230.defaultConfig.starsOffset2;
			//   v316 = starsTint2;
			//   v237 = *(_OWORD *)&v230.defaultConfig.starLayerViewMode;
			//   v230 = (HGStarConfig__StaticFields *)((char *)v230 + 128);
			//   v317 = v236;
			//   v238 = *(_OWORD *)&v230.defaultConfig.enableStars;
			//   v318 = v237;
			//   v239 = v230.defaultConfig.starsTint;
			//   v319 = v238;
			//   v240 = *(Color *)&v230.defaultConfig.starsOffset0;
			//   v320 = v239;
			//   v241 = v230.defaultConfig.starsTint1;
			//   v321 = v240;
			//   v322 = v241;
			//   v242 = v312;
			//   *(_OWORD *)&this.fields.starConfig.enableStars = v311;
			//   v243 = v313;
			//   this.fields.starConfig.starsTint = v242;
			//   v244 = v314;
			//   *(_OWORD *)&this.fields.starConfig.starsOffset0 = v243;
			//   v245 = v315;
			//   this.fields.starConfig.starsTint1 = v244;
			//   v246 = v316;
			//   *(_OWORD *)&this.fields.starConfig.starsOffset1 = v245;
			//   v247 = v317;
			//   this.fields.starConfig.starsTint2 = v246;
			//   v248 = v318;
			//   *(_OWORD *)&this.fields.starConfig.starsOffset2 = v247;
			//   v249 = v319;
			//   *(_OWORD *)&this.fields.starConfig.starLayerViewMode = v248;
			//   v250 = v320;
			//   *(_OWORD *)&this.fields.starConfig.skyBoxStarRangeMap = v249;
			//   v251 = v321;
			//   *(Color *)&this.fields.starConfig.enableNebula = v250;
			//   v252 = v322;
			//   this.fields.starConfig.nebulaTint = v251;
			//   *(Color *)&this.fields.starConfig.nebulaMapRotation = v252;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.starConfig.skyboxStarNoiseMap,
			//     v253,
			//     v254,
			//     v255,
			//     (String__Array *)v311,
			//     *((String **)&v311 + 1),
			//     *(MethodInfo **)&v312.r);
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGLensFlareConfig);
			//   v256 = TypeInfo::HG::Rendering::Runtime::HGLensFlareConfig.static_fields;
			//   v257 = *(_OWORD *)&v256.defaultConfig.intensity;
			//   v258 = *(_OWORD *)&v256.defaultConfig.sampleCount;
			//   *(_OWORD *)&this.fields.lensFlareConfig.enable = *(_OWORD *)&v256.defaultConfig.enable;
			//   *(_OWORD *)&this.fields.lensFlareConfig.intensity = v257;
			//   *(_OWORD *)&this.fields.lensFlareConfig.sampleCount = v258;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.lensFlareConfig.lensFlareData,
			//     v259,
			//     v260,
			//     v261,
			//     (String__Array *)v311,
			//     *((String **)&v311 + 1),
			//     *(MethodInfo **)&v312.r);
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
			//   v264 = 2LL;
			//   v265 = &v311;
			//   p_defaultConfig = &TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig.static_fields.defaultConfig;
			//   do
			//   {
			//     v267 = *(_OWORD *)&p_defaultConfig.colorLookupContribution;
			//     *v265 = *(_OWORD *)&p_defaultConfig.tonemappingMode;
			//     v268 = *(_OWORD *)&p_defaultConfig.colorAdjustmentsEnabled;
			//     v265[1] = v267;
			//     v269 = *(_OWORD *)&p_defaultConfig.colorAdjustmentsColorFilter.g;
			//     v265[2] = v268;
			//     v270 = *(_OWORD *)&p_defaultConfig.colorAdjustmentsSaturation;
			//     v265[3] = v269;
			//     v271 = *(_OWORD *)&p_defaultConfig.channelMixerRedOutBlueIn;
			//     v265[4] = v270;
			//     v272 = *(_OWORD *)&p_defaultConfig.channelMixerBlueOutRedIn;
			//     v265[5] = v271;
			//     shadows = p_defaultConfig.shadowsMidtonesHighlights.shadows;
			//     p_defaultConfig = (HGColorGradingConfig *)((char *)p_defaultConfig + 128);
			//     v265[6] = v272;
			//     v265 += 8;
			//     *(v265 - 1) = (__int128)shadows;
			//     --v264;
			//   }
			//   while ( v264 );
			//   v274 = *(_OWORD *)&p_defaultConfig.colorLookupContribution;
			//   *v265 = *(_OWORD *)&p_defaultConfig.tonemappingMode;
			//   v275 = *(_OWORD *)&p_defaultConfig.colorAdjustmentsEnabled;
			//   v265[1] = v274;
			//   v276 = *(_OWORD *)&p_defaultConfig.colorAdjustmentsColorFilter.g;
			//   v265[2] = v275;
			//   v277 = *(_OWORD *)&p_defaultConfig.colorAdjustmentsSaturation;
			//   v265[3] = v276;
			//   v278 = *(_OWORD *)&p_defaultConfig.channelMixerRedOutBlueIn;
			//   v265[4] = v277;
			//   v279 = *(_OWORD *)&p_defaultConfig.channelMixerBlueOutRedIn;
			//   v280 = &v311;
			//   v265[5] = v278;
			//   v265[6] = v279;
			//   p_colorGradingConfig = &this.fields.colorGradingConfig;
			//   do
			//   {
			//     v282 = v280[1];
			//     *(_OWORD *)&p_colorGradingConfig.tonemappingMode = *v280;
			//     v283 = v280[2];
			//     *(_OWORD *)&p_colorGradingConfig.colorLookupContribution = v282;
			//     v284 = v280[3];
			//     *(_OWORD *)&p_colorGradingConfig.colorAdjustmentsEnabled = v283;
			//     v285 = v280[4];
			//     *(_OWORD *)&p_colorGradingConfig.colorAdjustmentsColorFilter.g = v284;
			//     v286 = v280[5];
			//     *(_OWORD *)&p_colorGradingConfig.colorAdjustmentsSaturation = v285;
			//     v287 = v280[6];
			//     *(_OWORD *)&p_colorGradingConfig.channelMixerRedOutBlueIn = v286;
			//     v288 = v280[7];
			//     v280 += 8;
			//     *(_OWORD *)&p_colorGradingConfig.channelMixerBlueOutRedIn = v287;
			//     p_colorGradingConfig = (HGColorGradingConfig *)((char *)p_colorGradingConfig + 128);
			//     *(_OWORD *)&p_colorGradingConfig[-1].colorCurves.masterOverriding = v288;
			//     --v3;
			//   }
			//   while ( v3 );
			//   v289 = v280[1];
			//   *(_OWORD *)&p_colorGradingConfig.tonemappingMode = *v280;
			//   v290 = v280[2];
			//   *(_OWORD *)&p_colorGradingConfig.colorLookupContribution = v289;
			//   v291 = v280[3];
			//   *(_OWORD *)&p_colorGradingConfig.colorAdjustmentsEnabled = v290;
			//   v292 = v280[4];
			//   *(_OWORD *)&p_colorGradingConfig.colorAdjustmentsColorFilter.g = v291;
			//   v293 = v280[5];
			//   *(_OWORD *)&p_colorGradingConfig.colorAdjustmentsSaturation = v292;
			//   v294 = v280[6];
			//   *(_OWORD *)&p_colorGradingConfig.channelMixerRedOutBlueIn = v293;
			//   *(_OWORD *)&p_colorGradingConfig.channelMixerBlueOutRedIn = v294;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.colorGradingConfig.colorLookupTexture,
			//     0LL,
			//     v262,
			//     v263,
			//     (String__Array *)v311,
			//     *((String **)&v311 + 1),
			//     *(MethodInfo **)&v312.r);
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGAutoExposureConfig);
			//   v295 = TypeInfo::HG::Rendering::Runtime::HGAutoExposureConfig.static_fields;
			//   v296 = *(_DWORD *)&v295.defaultConfig.m_active;
			//   v297 = *(_OWORD *)&v295.defaultConfig.autoExposureEv100Range.x;
			//   v298 = *(_OWORD *)&v295.defaultConfig.autoExposureMeteringMode;
			//   *(_QWORD *)&v294 = *(_QWORD *)&v295.defaultConfig.autoExposureEvClampRange.y;
			//   *(_OWORD *)&this.fields.autoExposureConfig.autoExposureMode = *(_OWORD *)&v295.defaultConfig.autoExposureMode;
			//   *(_OWORD *)&this.fields.autoExposureConfig.autoExposureEv100Range.x = v297;
			//   *(_OWORD *)&this.fields.autoExposureConfig.autoExposureMeteringMode = v298;
			//   *(_QWORD *)&this.fields.autoExposureConfig.autoExposureEvClampRange.y = v294;
			//   *(_DWORD *)&this.fields.autoExposureConfig.m_active = v296;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowConfig);
			//   v299 = TypeInfo::HG::Rendering::Runtime::HGShadowConfig.static_fields;
			//   v300 = *(_OWORD *)&v299.defaultConfig.csmIntensity;
			//   v301 = *(_OWORD *)&v299.defaultConfig.csmShadowSoftness;
			//   v302 = *(_OWORD *)&v299.defaultConfig.contactShadowSurfaceThickness;
			//   v303 = *(_OWORD *)&v299.defaultConfig.overrideCsmFarDistance;
			//   v304 = *(_OWORD *)&v299.defaultConfig.overrideCsmSpherePosition.z;
			//   *(_QWORD *)&v294 = *(_QWORD *)&v299.defaultConfig.csmSimulatedAttenuation;
			//   *(_OWORD *)&this.fields.shadowConfig.csmDepthBias = *(_OWORD *)&v299.defaultConfig.csmDepthBias;
			//   *(_OWORD *)&this.fields.shadowConfig.csmIntensity = v300;
			//   *(_OWORD *)&this.fields.shadowConfig.csmShadowSoftness = v301;
			//   *(_OWORD *)&this.fields.shadowConfig.contactShadowSurfaceThickness = v302;
			//   *(_OWORD *)&this.fields.shadowConfig.overrideCsmFarDistance = v303;
			//   *(_OWORD *)&this.fields.shadowConfig.overrideCsmSpherePosition.z = v304;
			//   *(_QWORD *)&this.fields.shadowConfig.csmSimulatedAttenuation = v294;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.shadowConfig.csmRampTexture,
			//     v305,
			//     v306,
			//     v307,
			//     (String__Array *)v311,
			//     *((String **)&v311 + 1),
			//     *(MethodInfo **)&v312.r);
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGAnamorphicStreaksConfig);
			//   v308 = TypeInfo::HG::Rendering::Runtime::HGAnamorphicStreaksConfig.static_fields;
			//   v309 = v308.defaultConfig.bloomTint;
			//   v310 = *(_OWORD *)&v308.defaultConfig.blurIntensity;
			//   *(_OWORD *)&this.fields.anamorphicStreaksConfig.enable = *(_OWORD *)&v308.defaultConfig.enable;
			//   this.fields.anamorphicStreaksConfig.bloomTint = v309;
			//   *(_OWORD *)&this.fields.anamorphicStreaksConfig.blurIntensity = v310;
			//   HG::Rendering::Runtime::HGEnvironmentVolume::HGEnvironmentVolume((HGEnvironmentVolume *)this, 0LL);
			// }
			// 
		}

		public override bool HasEnvPhase()
		{
			// // Boolean HasEnvPhase()
			// bool HG::Rendering::Runtime::HGAnimatedEnvironmentVolume::HasEnvPhase(
			//         HGAnimatedEnvironmentVolume *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1190, 0LL) )
			//     return 1;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1190, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		public override HGEnvironmentPhase GetEnvPhaseForInterpolate()
		{
			// // HGEnvironmentPhase GetEnvPhaseForInterpolate()
			// HGEnvironmentPhase *HG::Rendering::Runtime::HGAnimatedEnvironmentVolume::GetEnvPhaseForInterpolate(
			//         HGAnimatedEnvironmentVolume *this,
			//         MethodInfo *method)
			// {
			//   Object_1 *s_animatedEnvPhase; // rbx
			//   MessageDescriptor *v4; // r9
			//   Object *v5; // rax
			//   OneofDescriptorProto *static_fields; // rdx
			//   FileDescriptor *v7; // r8
			//   MessageDescriptor *v8; // r9
			//   __int64 v9; // r8
			//   HGLightConfig *p_lightConfig; // rax
			//   HGEnvironmentPhase *v11; // rdx
			//   char *v12; // rcx
			//   __int128 v13; // xmm1
			//   __int128 v14; // xmm0
			//   __int128 v15; // xmm1
			//   __int128 v16; // xmm0
			//   __int128 v17; // xmm1
			//   __int128 v18; // xmm0
			//   __int128 v19; // xmm1
			//   __int128 v20; // xmm1
			//   __int128 v21; // xmm0
			//   __int128 v22; // xmm1
			//   __int128 v23; // xmm0
			//   __int128 v24; // xmm1
			//   __int128 *v25; // rax
			//   __int64 v26; // rdx
			//   __int128 *v27; // rcx
			//   __int128 v28; // xmm1
			//   __int128 v29; // xmm0
			//   __int128 v30; // xmm1
			//   __int128 v31; // xmm0
			//   __int128 v32; // xmm1
			//   __int128 v33; // xmm0
			//   __int128 v34; // xmm1
			//   __int64 v35; // r8
			//   __int128 v36; // xmm1
			//   __int128 v37; // xmm0
			//   __int128 v38; // xmm1
			//   __int128 v39; // xmm0
			//   __int128 v40; // xmm1
			//   HGSkyConfig *p_skyConfig; // rax
			//   __int128 v42; // xmm1
			//   __int128 v43; // xmm0
			//   __int128 v44; // xmm1
			//   __int128 v45; // xmm0
			//   __int128 v46; // xmm1
			//   __int128 v47; // xmm0
			//   __int128 v48; // xmm1
			//   __int128 v49; // xmm1
			//   __int128 v50; // xmm0
			//   __int128 v51; // xmm1
			//   __int128 v52; // xmm0
			//   __int64 v53; // rax
			//   HGSkyConfig *v54; // rcx
			//   __int64 v55; // r8
			//   __int128 *v56; // rax
			//   __int128 v57; // xmm1
			//   __int128 v58; // xmm0
			//   __int128 v59; // xmm1
			//   __int128 v60; // xmm0
			//   __int128 v61; // xmm1
			//   __int128 v62; // xmm0
			//   __int128 v63; // xmm1
			//   __int128 v64; // xmm1
			//   __int128 v65; // xmm0
			//   __int128 v66; // xmm1
			//   __int128 v67; // xmm0
			//   __int64 v68; // rax
			//   __int64 v69; // r10
			//   __int64 v70; // r11
			//   MessageDescriptor *v71; // r9
			//   Color v72; // xmm1
			//   __int128 v73; // xmm0
			//   Color rayleighScattering; // xmm1
			//   __int128 v75; // xmm0
			//   Color v76; // xmm1
			//   __int128 v77; // xmm0
			//   __int128 v78; // xmm1
			//   __int128 v79; // xmm0
			//   __int64 v80; // rax
			//   HGAtmosphereConfig *p_atmosphereConfig; // rcx
			//   Color v82; // xmm1
			//   __int128 v83; // xmm0
			//   Color v84; // xmm1
			//   __int128 v85; // xmm0
			//   Color v86; // xmm1
			//   __int128 v87; // xmm0
			//   __int128 v88; // xmm1
			//   __int128 v89; // xmm0
			//   __int64 v90; // rax
			//   __int128 v91; // xmm1
			//   __int128 v92; // xmm2
			//   __int128 v93; // xmm3
			//   HGEnvironmentPhase *v94; // rax
			//   Color inscatterAmbientColor; // xmm4
			//   Color v96; // xmm1
			//   __int128 v97; // xmm0
			//   Color v98; // xmm1
			//   __int128 v99; // xmm0
			//   Color v100; // xmm1
			//   __int128 v101; // xmm0
			//   __int128 v102; // xmm1
			//   bool *v103; // rax
			//   __int128 v104; // xmm0
			//   __int128 v105; // xmm1
			//   __int128 v106; // xmm0
			//   __int128 v107; // xmm1
			//   __int64 v108; // rax
			//   __int64 v109; // r8
			//   Color v110; // xmm1
			//   __int128 v111; // xmm0
			//   Color v112; // xmm1
			//   __int128 v113; // xmm0
			//   Color v114; // xmm1
			//   __int128 v115; // xmm0
			//   __int128 v116; // xmm1
			//   bool *v117; // rcx
			//   __int128 v118; // xmm1
			//   __int128 v119; // xmm0
			//   __int128 v120; // xmm1
			//   __int64 v121; // rax
			//   HGVolumetricFogConfig *p_volumetricFogConfig; // rax
			//   __int128 v123; // xmm1
			//   __int128 v124; // xmm0
			//   __int128 v125; // xmm1
			//   __int128 v126; // xmm0
			//   __int128 v127; // xmm1
			//   __int128 v128; // xmm0
			//   __int128 v129; // xmm1
			//   HGVolumetricFogConfig *v130; // rax
			//   __int64 v131; // rdx
			//   __int128 *v132; // rcx
			//   __int128 v133; // xmm1
			//   __int128 v134; // xmm0
			//   __int128 v135; // xmm1
			//   __int128 v136; // xmm0
			//   __int128 v137; // xmm1
			//   __int128 v138; // xmm0
			//   __int128 v139; // xmm1
			//   Color cloudTint; // xmm1
			//   __int128 v141; // xmm0
			//   Color v142; // xmm1
			//   __int128 v143; // xmm0
			//   Color v144; // xmm1
			//   __int128 v145; // xmm0
			//   __int128 v146; // xmm1
			//   __int128 v147; // xmm0
			//   __int128 v148; // xmm1
			//   __int128 v149; // xmm0
			//   Color v150; // xmm1
			//   __int128 v151; // xmm0
			//   Color v152; // xmm1
			//   __int128 v153; // xmm0
			//   Color v154; // xmm1
			//   __int128 v155; // xmm0
			//   __int128 v156; // xmm1
			//   bool *v157; // rcx
			//   __int128 v158; // xmm0
			//   __int128 v159; // xmm1
			//   __int128 v160; // xmm0
			//   __int64 v161; // r10
			//   __int64 v162; // r11
			//   MessageDescriptor *v163; // r9
			//   __int64 v164; // r8
			//   HGCelestialConfig *p_celestialConfig; // rax
			//   __int128 v166; // xmm1
			//   __int128 v167; // xmm0
			//   __int128 v168; // xmm1
			//   __int128 v169; // xmm0
			//   __int128 v170; // xmm1
			//   __int128 v171; // xmm0
			//   __int128 v172; // xmm1
			//   __int128 v173; // xmm1
			//   __int128 v174; // xmm0
			//   __int128 v175; // xmm1
			//   __int128 v176; // xmm0
			//   __int128 v177; // xmm1
			//   Material *drawMaterial; // rax
			//   __int128 *v179; // rcx
			//   __int64 v180; // r8
			//   __int128 *v181; // rax
			//   __int128 v182; // xmm1
			//   __int128 v183; // xmm0
			//   __int128 v184; // xmm1
			//   __int128 v185; // xmm0
			//   __int128 v186; // xmm1
			//   __int128 v187; // xmm0
			//   __int128 v188; // xmm1
			//   __int128 v189; // xmm1
			//   __int128 v190; // xmm0
			//   __int128 v191; // xmm1
			//   __int128 v192; // xmm0
			//   __int128 v193; // xmm1
			//   __int64 v194; // rax
			//   HGEnvironmentPhase *v195; // r10
			//   __int64 v196; // r11
			//   MessageDescriptor *v197; // r9
			//   __int64 v198; // xmm1_8
			//   int v199; // eax
			//   Color bloomTint; // xmm1
			//   __int128 v201; // xmm2
			//   HGEnvironmentPhase *v202; // rax
			//   HGEnvironmentPhase *v203; // rax
			//   HGEnvironmentPhase *v204; // r8
			//   HGRainConfig *p_rainConfig; // rax
			//   __int128 v206; // xmm1
			//   __int128 v207; // xmm0
			//   __int128 v208; // xmm1
			//   __int128 v209; // xmm0
			//   __int128 v210; // xmm1
			//   __int128 v211; // xmm0
			//   __int128 v212; // xmm1
			//   __int128 v213; // xmm1
			//   __int128 v214; // xmm0
			//   HGRainConfig *v215; // rax
			//   __int128 *v216; // rcx
			//   __int128 v217; // xmm1
			//   __int128 v218; // xmm0
			//   __int128 v219; // xmm1
			//   __int128 v220; // xmm0
			//   __int128 v221; // xmm1
			//   __int128 v222; // xmm0
			//   __int128 v223; // xmm1
			//   __int128 v224; // xmm1
			//   __int128 v225; // xmm0
			//   __int128 v226; // xmm1
			//   __int128 v227; // xmm2
			//   __int128 v228; // xmm3
			//   __int64 v229; // rax
			//   __int64 v230; // xmm4_8
			//   Color starsTint; // xmm1
			//   __int128 v232; // xmm0
			//   Color starsTint1; // xmm1
			//   __int128 v234; // xmm0
			//   Color starsTint2; // xmm1
			//   __int128 v236; // xmm0
			//   __int128 v237; // xmm1
			//   bool *v238; // rax
			//   __int128 v239; // xmm0
			//   __int128 v240; // xmm1
			//   __int128 v241; // xmm0
			//   __int128 v242; // xmm1
			//   Color v243; // xmm1
			//   __int128 v244; // xmm0
			//   Color v245; // xmm1
			//   __int128 v246; // xmm0
			//   Color v247; // xmm1
			//   __int128 v248; // xmm0
			//   __int128 v249; // xmm1
			//   bool *v250; // rcx
			//   __int128 v251; // xmm0
			//   __int128 v252; // xmm1
			//   __int128 v253; // xmm0
			//   __int128 v254; // xmm1
			//   FileDescriptor *v255; // r8
			//   MessageDescriptor *v256; // r9
			//   __int128 v257; // xmm1
			//   __int128 v258; // xmm2
			//   __int64 v259; // r10
			//   __int64 v260; // r11
			//   MessageDescriptor *v261; // r9
			//   __int64 v262; // r8
			//   HGColorGradingConfig *p_colorGradingConfig; // rax
			//   __int128 v264; // xmm1
			//   __int128 v265; // xmm0
			//   __int128 v266; // xmm1
			//   __int128 v267; // xmm0
			//   __int128 v268; // xmm1
			//   __int128 v269; // xmm0
			//   Vector4 shadows; // xmm1
			//   __int128 v271; // xmm1
			//   __int128 v272; // xmm0
			//   __int128 v273; // xmm1
			//   __int128 v274; // xmm0
			//   __int128 v275; // xmm1
			//   __int128 v276; // xmm0
			//   HGColorGradingConfig *v277; // rax
			//   __int128 *v278; // rcx
			//   __int128 v279; // xmm1
			//   __int128 v280; // xmm0
			//   __int128 v281; // xmm1
			//   __int128 v282; // xmm0
			//   __int128 v283; // xmm1
			//   __int128 v284; // xmm0
			//   __int128 v285; // xmm1
			//   __int128 v286; // xmm1
			//   __int128 v287; // xmm0
			//   __int128 v288; // xmm1
			//   __int128 v289; // xmm0
			//   __int128 v290; // xmm1
			//   __int128 v291; // xmm0
			//   FileDescriptor *v292; // r8
			//   MessageDescriptor *v293; // r9
			//   __int128 v294; // xmm1
			//   __int128 v295; // xmm2
			//   __int64 v296; // xmm3_8
			//   int v297; // eax
			//   __int128 v298; // xmm1
			//   __int128 v299; // xmm2
			//   __int128 v300; // xmm3
			//   __int64 v301; // xmm6_8
			//   __int128 v302; // xmm4
			//   __int128 v303; // xmm5
			//   Color v304; // xmm1
			//   __int128 v305; // xmm2
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int128 v308; // [rsp+28h] [rbp-E0h] BYREF
			//   Color v309; // [rsp+38h] [rbp-D0h]
			//   __int128 v310; // [rsp+48h] [rbp-C0h]
			//   Color v311; // [rsp+58h] [rbp-B0h]
			//   __int128 v312; // [rsp+68h] [rbp-A0h]
			//   Color v313; // [rsp+78h] [rbp-90h]
			//   __int128 v314; // [rsp+88h] [rbp-80h]
			//   __int128 v315; // [rsp+98h] [rbp-70h]
			// 
			//   if ( !byte_18D919D5A )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&MethodInfo::UnityEngine::ScriptableObject::CreateInstance<HG::Rendering::Runtime::HGEnvironmentPhase>);
			//     byte_18D919D5A = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1191, 0LL) )
			//   {
			//     s_animatedEnvPhase = (Object_1 *)TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume.static_fields.s_animatedEnvPhase;
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Equality(s_animatedEnvPhase, 0LL, 0LL) )
			//     {
			//       v5 = UnityEngine::ScriptableObject::CreateInstance<System::Object>(MethodInfo::UnityEngine::ScriptableObject::CreateInstance<HG::Rendering::Runtime::HGEnvironmentPhase>);
			//       static_fields = (OneofDescriptorProto *)TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume.static_fields;
			//       static_fields.klass = (OneofDescriptorProto__Class *)v5;
			//       sub_1800054D0(
			//         (OneofDescriptor *)TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume.static_fields,
			//         static_fields,
			//         v7,
			//         v8,
			//         (String__Array *)v308,
			//         *((String **)&v308 + 1),
			//         *(MethodInfo **)&v309.r);
			//     }
			//     v9 = 2LL;
			//     p_lightConfig = &this.fields.lightConfig;
			//     v11 = TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume.static_fields.s_animatedEnvPhase;
			//     v12 = (char *)&v308;
			//     do
			//     {
			//       v13 = *(_OWORD *)&p_lightConfig.directColorMode;
			//       *(Color *)v12 = p_lightConfig.directColor;
			//       v14 = *(_OWORD *)&p_lightConfig.directCustomColor.a;
			//       *((_OWORD *)v12 + 1) = v13;
			//       v15 = *(_OWORD *)&p_lightConfig.directSpecularIntensity;
			//       *((_OWORD *)v12 + 2) = v14;
			//       v16 = *(_OWORD *)&p_lightConfig.indirectDiffuseFactor;
			//       *((_OWORD *)v12 + 3) = v15;
			//       v17 = *(_OWORD *)&p_lightConfig.atmospherePitchYaw.x;
			//       *((_OWORD *)v12 + 4) = v16;
			//       v18 = *(_OWORD *)&p_lightConfig.lightShaftPitchYaw.y;
			//       *((_OWORD *)v12 + 5) = v17;
			//       v19 = *(_OWORD *)&p_lightConfig.lensFlarePitchYawMode;
			//       p_lightConfig = (HGLightConfig *)((char *)p_lightConfig + 128);
			//       *((_OWORD *)v12 + 6) = v18;
			//       v12 += 128;
			//       *((_OWORD *)v12 - 1) = v19;
			//       --v9;
			//     }
			//     while ( v9 );
			//     v20 = *(_OWORD *)&p_lightConfig.directColorMode;
			//     *(Color *)v12 = p_lightConfig.directColor;
			//     v21 = *(_OWORD *)&p_lightConfig.directCustomColor.a;
			//     *((_OWORD *)v12 + 1) = v20;
			//     v22 = *(_OWORD *)&p_lightConfig.directSpecularIntensity;
			//     *((_OWORD *)v12 + 2) = v21;
			//     v23 = *(_OWORD *)&p_lightConfig.indirectDiffuseFactor;
			//     *((_OWORD *)v12 + 3) = v22;
			//     v24 = *(_OWORD *)&p_lightConfig.atmospherePitchYaw.x;
			//     *((_OWORD *)v12 + 4) = v23;
			//     *((_OWORD *)v12 + 5) = v24;
			//     if ( v11 )
			//     {
			//       v25 = (__int128 *)&v11.fields.lightConfig;
			//       v26 = 2LL;
			//       v27 = &v308;
			//       do
			//       {
			//         v28 = v27[1];
			//         *v25 = *v27;
			//         v29 = v27[2];
			//         v25[1] = v28;
			//         v30 = v27[3];
			//         v25[2] = v29;
			//         v31 = v27[4];
			//         v25[3] = v30;
			//         v32 = v27[5];
			//         v25[4] = v31;
			//         v33 = v27[6];
			//         v25[5] = v32;
			//         v34 = v27[7];
			//         v27 += 8;
			//         v25[6] = v33;
			//         v25 += 8;
			//         *(v25 - 1) = v34;
			//         --v26;
			//       }
			//       while ( v26 );
			//       v35 = 2LL;
			//       v36 = v27[1];
			//       *v25 = *v27;
			//       v37 = v27[2];
			//       v25[1] = v36;
			//       v38 = v27[3];
			//       v25[2] = v37;
			//       v39 = v27[4];
			//       v25[3] = v38;
			//       v40 = v27[5];
			//       v25[4] = v39;
			//       v25[5] = v40;
			//       p_skyConfig = &this.fields.skyConfig;
			//       v11 = TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume.static_fields.s_animatedEnvPhase;
			//       v12 = (char *)&v308;
			//       do
			//       {
			//         v42 = *(_OWORD *)&p_skyConfig.skyDirectIntensity;
			//         *(_OWORD *)v12 = *(_OWORD *)&p_skyConfig.parentEnvPhaseGuid;
			//         v43 = *(_OWORD *)&p_skyConfig.customIVDefaultSH.shr2;
			//         *((_OWORD *)v12 + 1) = v42;
			//         v44 = *(_OWORD *)&p_skyConfig.customIVDefaultSH.shr6;
			//         *((_OWORD *)v12 + 2) = v43;
			//         v45 = *(_OWORD *)&p_skyConfig.customIVDefaultSH.shg1;
			//         *((_OWORD *)v12 + 3) = v44;
			//         v46 = *(_OWORD *)&p_skyConfig.customIVDefaultSH.shg5;
			//         *((_OWORD *)v12 + 4) = v45;
			//         v47 = *(_OWORD *)&p_skyConfig.customIVDefaultSH.shb0;
			//         *((_OWORD *)v12 + 5) = v46;
			//         v48 = *(_OWORD *)&p_skyConfig.customIVDefaultSH.shb4;
			//         p_skyConfig = (HGSkyConfig *)((char *)p_skyConfig + 128);
			//         *((_OWORD *)v12 + 6) = v47;
			//         v12 += 128;
			//         *((_OWORD *)v12 - 1) = v48;
			//         --v35;
			//       }
			//       while ( v35 );
			//       v49 = *(_OWORD *)&p_skyConfig.skyDirectIntensity;
			//       *(_OWORD *)v12 = *(_OWORD *)&p_skyConfig.parentEnvPhaseGuid;
			//       v50 = *(_OWORD *)&p_skyConfig.customIVDefaultSH.shr2;
			//       *((_OWORD *)v12 + 1) = v49;
			//       v51 = *(_OWORD *)&p_skyConfig.customIVDefaultSH.shr6;
			//       *((_OWORD *)v12 + 2) = v50;
			//       v52 = *(_OWORD *)&p_skyConfig.customIVDefaultSH.shg1;
			//       v53 = *(_QWORD *)&p_skyConfig.customIVDefaultSH.shg5;
			//       *((_OWORD *)v12 + 3) = v51;
			//       *((_OWORD *)v12 + 4) = v52;
			//       *((_QWORD *)v12 + 10) = v53;
			//       if ( v11 )
			//       {
			//         v54 = &v11.fields.skyConfig;
			//         v55 = 2LL;
			//         v56 = &v308;
			//         do
			//         {
			//           v57 = v56[1];
			//           *(_OWORD *)&v54.parentEnvPhaseGuid = *v56;
			//           v58 = v56[2];
			//           *(_OWORD *)&v54.skyDirectIntensity = v57;
			//           v59 = v56[3];
			//           *(_OWORD *)&v54.customIVDefaultSH.shr2 = v58;
			//           v60 = v56[4];
			//           *(_OWORD *)&v54.customIVDefaultSH.shr6 = v59;
			//           v61 = v56[5];
			//           *(_OWORD *)&v54.customIVDefaultSH.shg1 = v60;
			//           v62 = v56[6];
			//           *(_OWORD *)&v54.customIVDefaultSH.shg5 = v61;
			//           v63 = v56[7];
			//           v56 += 8;
			//           *(_OWORD *)&v54.customIVDefaultSH.shb0 = v62;
			//           v54 = (HGSkyConfig *)((char *)v54 + 128);
			//           *(_OWORD *)&v54[-1].skyboxCubeMap = v63;
			//           --v55;
			//         }
			//         while ( v55 );
			//         v64 = v56[1];
			//         *(_OWORD *)&v54.parentEnvPhaseGuid = *v56;
			//         v65 = v56[2];
			//         *(_OWORD *)&v54.skyDirectIntensity = v64;
			//         v66 = v56[3];
			//         *(_OWORD *)&v54.customIVDefaultSH.shr2 = v65;
			//         v67 = v56[4];
			//         v68 = *((_QWORD *)v56 + 10);
			//         *(_OWORD *)&v54.customIVDefaultSH.shr6 = v66;
			//         *(_OWORD *)&v54.customIVDefaultSH.shg1 = v67;
			//         *(_QWORD *)&v54.customIVDefaultSH.shg5 = v68;
			//         sub_1800054D0(
			//           (OneofDescriptor *)&v11.fields.skyConfig,
			//           (OneofDescriptorProto *)v11,
			//           0LL,
			//           v4,
			//           (String__Array *)v308,
			//           *((String **)&v308 + 1),
			//           *(MethodInfo **)&v309.r);
			//         v71 = (MessageDescriptor *)TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume;
			//         v12 = (char *)&v308;
			//         v11 = TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume.static_fields.s_animatedEnvPhase;
			//         v72 = *(Color *)&this.fields.atmosphereConfig.groundAlbedo.a;
			//         v308 = *(_OWORD *)&this.fields.atmosphereConfig.groundRadius;
			//         v73 = *(_OWORD *)&this.fields.atmosphereConfig.outerSunIrradianceColor.a;
			//         v309 = v72;
			//         rayleighScattering = this.fields.atmosphereConfig.rayleighScattering;
			//         v310 = v73;
			//         v75 = *(_OWORD *)&this.fields.atmosphereConfig.rayleighExponentialDistribution;
			//         v311 = rayleighScattering;
			//         v76 = *(Color *)&this.fields.atmosphereConfig.mieScattering.b;
			//         v312 = v75;
			//         v77 = *(_OWORD *)&this.fields.atmosphereConfig.mieAbsorption.g;
			//         v313 = v76;
			//         v78 = *(_OWORD *)&this.fields.atmosphereConfig.mieExponentialDistribution;
			//         v314 = v77;
			//         v79 = *(_OWORD *)((char *)&this.fields.atmosphereConfig.groundRadius + v70);
			//         v80 = *(_QWORD *)((char *)&this.fields.atmosphereConfig.groundAlbedo.a + v70);
			//         *(__int128 *)((char *)&v308 + v70 - 16) = v78;
			//         *(__int128 *)((char *)&v308 + v70) = v79;
			//         *(_QWORD *)((char *)&v308 + v70 + 16) = v80;
			//         if ( v11 )
			//         {
			//           p_atmosphereConfig = &v11.fields.atmosphereConfig;
			//           v82 = v309;
			//           *(_OWORD *)&v11.fields.atmosphereConfig.groundRadius = v308;
			//           v83 = v310;
			//           *(Color *)&v11.fields.atmosphereConfig.groundAlbedo.a = v82;
			//           v84 = v311;
			//           *(_OWORD *)&v11.fields.atmosphereConfig.outerSunIrradianceColor.a = v83;
			//           v85 = v312;
			//           v11.fields.atmosphereConfig.rayleighScattering = v84;
			//           v86 = v313;
			//           *(_OWORD *)&v11.fields.atmosphereConfig.rayleighExponentialDistribution = v85;
			//           v87 = v314;
			//           *(Color *)&v11.fields.atmosphereConfig.mieScattering.b = v86;
			//           v88 = v315;
			//           *(_OWORD *)&v11.fields.atmosphereConfig.mieAbsorption.g = v87;
			//           v89 = *(__int128 *)((char *)&v308 + v70);
			//           v90 = *(_QWORD *)((char *)&v308 + v70 + 16);
			//           *(_OWORD *)((char *)p_atmosphereConfig + v70 - 16) = v88;
			//           *(_OWORD *)((char *)&p_atmosphereConfig.groundRadius + v70) = v89;
			//           *(_QWORD *)((char *)&p_atmosphereConfig.groundAlbedo.a + v70) = v90;
			//           v91 = *(_OWORD *)&this.fields.fogConfig.fallOffDistance;
			//           v92 = *(_OWORD *)&this.fields.fogConfig.mieScattering.a;
			//           v93 = *(_OWORD *)&this.fields.fogConfig.rayleighScattering.g;
			//           v94 = TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume.static_fields.s_animatedEnvPhase;
			//           v12 = (char *)*(unsigned int *)&this.fields.fogConfig.m_active;
			//           inscatterAmbientColor = this.fields.fogConfig.inscatterAmbientColor;
			//           if ( v94 )
			//           {
			//             *(_OWORD *)&v94.fields.fogConfig.enable = *(_OWORD *)&this.fields.fogConfig.enable;
			//             *(_OWORD *)&v94.fields.fogConfig.fallOffDistance = v91;
			//             *(_OWORD *)&v94.fields.fogConfig.mieScattering.a = v92;
			//             *(_OWORD *)&v94.fields.fogConfig.rayleighScattering.g = v93;
			//             v94.fields.fogConfig.inscatterAmbientColor = inscatterAmbientColor;
			//             *(_DWORD *)&v94.fields.fogConfig.m_active = (_DWORD)v12;
			//             v96 = *(Color *)&this.fields.heightFogConfig.heightFogStartHeightSecond;
			//             v11 = TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume.static_fields.s_animatedEnvPhase;
			//             v308 = *(_OWORD *)&this.fields.heightFogConfig.enable;
			//             v97 = *(_OWORD *)&this.fields.heightFogConfig.heightFogInscatter.g;
			//             v309 = v96;
			//             v98 = *(Color *)&this.fields.heightFogConfig.heightFogStartDistance;
			//             v310 = v97;
			//             v99 = *(_OWORD *)&this.fields.heightFogConfig.heightFogCullingFarClipPlane;
			//             v311 = v98;
			//             v100 = *(Color *)&this.fields.heightFogConfig.heightFogDirectionalInscattering.g;
			//             v312 = v99;
			//             v101 = *(_OWORD *)&this.fields.heightFogConfig.volumetricFogScatteringDistribution;
			//             v313 = v100;
			//             v102 = *(_OWORD *)&this.fields.heightFogConfig.volumetricFogAlbedo.a;
			//             v103 = &this.fields.heightFogConfig.enable + v70;
			//             v314 = v101;
			//             v12 = (char *)&v308 + v70;
			//             v104 = *(_OWORD *)v103;
			//             *((_OWORD *)v12 - 1) = v102;
			//             v105 = *((_OWORD *)v103 + 1);
			//             *(_OWORD *)v12 = v104;
			//             v106 = *((_OWORD *)v103 + 2);
			//             *((_OWORD *)v12 + 1) = v105;
			//             v107 = *((_OWORD *)v103 + 3);
			//             v108 = *((_QWORD *)v103 + 8);
			//             *((_OWORD *)v12 + 2) = v106;
			//             *((_OWORD *)v12 + 3) = v107;
			//             *((_QWORD *)v12 + 8) = v108;
			//             if ( v11 )
			//             {
			//               v109 = v69;
			//               v110 = v309;
			//               *(_OWORD *)&v11.fields.heightFogConfig.enable = v308;
			//               v111 = v310;
			//               *(Color *)&v11.fields.heightFogConfig.heightFogStartHeightSecond = v110;
			//               v112 = v311;
			//               *(_OWORD *)&v11.fields.heightFogConfig.heightFogInscatter.g = v111;
			//               v113 = v312;
			//               *(Color *)&v11.fields.heightFogConfig.heightFogStartDistance = v112;
			//               v114 = v313;
			//               *(_OWORD *)&v11.fields.heightFogConfig.heightFogCullingFarClipPlane = v113;
			//               v115 = v314;
			//               *(Color *)&v11.fields.heightFogConfig.heightFogDirectionalInscattering.g = v114;
			//               v116 = v315;
			//               *(_OWORD *)&v11.fields.heightFogConfig.volumetricFogScatteringDistribution = v115;
			//               v117 = &v11.fields.heightFogConfig.enable + v70;
			//               *((_OWORD *)v117 - 1) = v116;
			//               v118 = *(__int128 *)((char *)&v308 + v70 + 16);
			//               *(_OWORD *)v117 = *(__int128 *)((char *)&v308 + v70);
			//               v119 = *(__int128 *)((char *)&v308 + v70 + 32);
			//               *((_OWORD *)v117 + 1) = v118;
			//               v120 = *(__int128 *)((char *)&v308 + v70 + 48);
			//               v121 = *(_QWORD *)((char *)&v308 + v70 + 64);
			//               *((_OWORD *)v117 + 2) = v119;
			//               *((_OWORD *)v117 + 3) = v120;
			//               *((_QWORD *)v117 + 8) = v121;
			//               p_volumetricFogConfig = &this.fields.volumetricFogConfig;
			//               v11 = TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume.static_fields.s_animatedEnvPhase;
			//               v12 = (char *)&v308;
			//               do
			//               {
			//                 v123 = *(_OWORD *)&p_volumetricFogConfig.heightFogStartHeightSecond;
			//                 *(_OWORD *)v12 = *(_OWORD *)&p_volumetricFogConfig.enable;
			//                 v124 = *(_OWORD *)&p_volumetricFogConfig.heightFogInscatter.g;
			//                 *((_OWORD *)v12 + 1) = v123;
			//                 v125 = *(_OWORD *)&p_volumetricFogConfig.heightFogStartDistance;
			//                 *((_OWORD *)v12 + 2) = v124;
			//                 v126 = *(_OWORD *)&p_volumetricFogConfig.heightFogDirectionalInscatteringExponent;
			//                 *((_OWORD *)v12 + 3) = v125;
			//                 v127 = *(_OWORD *)&p_volumetricFogConfig.heightFogDirectionalInscattering.b;
			//                 *((_OWORD *)v12 + 4) = v126;
			//                 v128 = *(_OWORD *)&p_volumetricFogConfig.volumetricFogAlbedo.g;
			//                 *((_OWORD *)v12 + 5) = v127;
			//                 v129 = *(_OWORD *)&p_volumetricFogConfig.volumetricFogEmissive.g;
			//                 p_volumetricFogConfig = (HGVolumetricFogConfig *)((char *)p_volumetricFogConfig + v70);
			//                 *((_OWORD *)v12 + 6) = v128;
			//                 v12 += v70;
			//                 *((_OWORD *)v12 - 1) = v129;
			//                 --v109;
			//               }
			//               while ( v109 );
			//               if ( v11 )
			//               {
			//                 v130 = &v11.fields.volumetricFogConfig;
			//                 v131 = v69;
			//                 v132 = &v308;
			//                 do
			//                 {
			//                   v133 = v132[1];
			//                   *(_OWORD *)&v130.enable = *v132;
			//                   v134 = v132[2];
			//                   *(_OWORD *)&v130.heightFogStartHeightSecond = v133;
			//                   v135 = v132[3];
			//                   *(_OWORD *)&v130.heightFogInscatter.g = v134;
			//                   v136 = v132[4];
			//                   *(_OWORD *)&v130.heightFogStartDistance = v135;
			//                   v137 = v132[5];
			//                   *(_OWORD *)&v130.heightFogDirectionalInscatteringExponent = v136;
			//                   v138 = v132[6];
			//                   *(_OWORD *)&v130.heightFogDirectionalInscattering.b = v137;
			//                   v139 = v132[7];
			//                   v132 = (__int128 *)((char *)v132 + v70);
			//                   *(_OWORD *)&v130.volumetricFogAlbedo.g = v138;
			//                   v130 = (HGVolumetricFogConfig *)((char *)v130 + v70);
			//                   *(_OWORD *)&v130[-1].m_backupVLNoiseHorizontalDirAngle = v139;
			//                   --v131;
			//                 }
			//                 while ( v131 );
			//                 cloudTint = this.fields.cloudConfig.cloudTint;
			//                 v11 = TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume.static_fields.s_animatedEnvPhase;
			//                 v308 = *(_OWORD *)&this.fields.cloudConfig.enable;
			//                 v141 = *(_OWORD *)&this.fields.cloudConfig.cloudContrast;
			//                 v309 = cloudTint;
			//                 v142 = *(Color *)&this.fields.cloudConfig.brightnessAffectCloudAlpha;
			//                 v310 = v141;
			//                 v143 = *(_OWORD *)&this.fields.cloudConfig.cloudFlowType;
			//                 v311 = v142;
			//                 v144 = *(Color *)&this.fields.cloudConfig.flowSpeed;
			//                 v312 = v143;
			//                 v145 = *(_OWORD *)&this.fields.cloudConfig.lightShaftCloudMaskTexture;
			//                 v313 = v144;
			//                 v146 = *(_OWORD *)&this.fields.cloudConfig.cloudShadowConfig.cloudShadowTexture;
			//                 v314 = v145;
			//                 v12 = (char *)&v308 + v70;
			//                 v147 = *(_OWORD *)(&this.fields.cloudConfig.enable + v70);
			//                 *((_OWORD *)v12 - 1) = v146;
			//                 v148 = *(__int128 *)((char *)&this.fields.cloudConfig.cloudTint + v70);
			//                 *(_OWORD *)v12 = v147;
			//                 v149 = *(_OWORD *)((char *)&this.fields.cloudConfig.cloudContrast + v70);
			//                 *((_OWORD *)v12 + 1) = v148;
			//                 *((_OWORD *)v12 + 2) = v149;
			//                 if ( v11 )
			//                 {
			//                   v150 = v309;
			//                   *(_OWORD *)&v11.fields.cloudConfig.enable = v308;
			//                   v151 = v310;
			//                   v11.fields.cloudConfig.cloudTint = v150;
			//                   v152 = v311;
			//                   *(_OWORD *)&v11.fields.cloudConfig.cloudContrast = v151;
			//                   v153 = v312;
			//                   *(Color *)&v11.fields.cloudConfig.brightnessAffectCloudAlpha = v152;
			//                   v154 = v313;
			//                   *(_OWORD *)&v11.fields.cloudConfig.cloudFlowType = v153;
			//                   v155 = v314;
			//                   *(Color *)&v11.fields.cloudConfig.flowSpeed = v154;
			//                   v156 = v315;
			//                   *(_OWORD *)&v11.fields.cloudConfig.lightShaftCloudMaskTexture = v155;
			//                   v157 = &v11.fields.cloudConfig.enable + v70;
			//                   v158 = *(__int128 *)((char *)&v308 + v70);
			//                   *((_OWORD *)v157 - 1) = v156;
			//                   v159 = *(__int128 *)((char *)&v308 + v70 + 16);
			//                   *(_OWORD *)v157 = v158;
			//                   v160 = *(__int128 *)((char *)&v310 + v70);
			//                   *((_OWORD *)v157 + 1) = v159;
			//                   *((_OWORD *)v157 + 2) = v160;
			//                   sub_1800054D0(
			//                     (OneofDescriptor *)&v11.fields.cloudConfig.cloudTexture,
			//                     (OneofDescriptorProto *)v11,
			//                     0LL,
			//                     v71,
			//                     (String__Array *)v308,
			//                     *((String **)&v308 + 1),
			//                     *(MethodInfo **)&v309.r);
			//                   v163 = (MessageDescriptor *)TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume;
			//                   v12 = (char *)&v308;
			//                   v164 = v161;
			//                   v11 = TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume.static_fields.s_animatedEnvPhase;
			//                   p_celestialConfig = &this.fields.celestialConfig;
			//                   do
			//                   {
			//                     v166 = *(_OWORD *)&p_celestialConfig.moonConfig.worldLongitude;
			//                     *(_OWORD *)v12 = *(_OWORD *)&p_celestialConfig.moonConfig.radius;
			//                     v167 = *(_OWORD *)&p_celestialConfig.moonConfig.ring.outerRadius;
			//                     *((_OWORD *)v12 + 1) = v166;
			//                     v168 = *(_OWORD *)&p_celestialConfig.moonConfig.ring.ringColor.b;
			//                     *((_OWORD *)v12 + 2) = v167;
			//                     v169 = *(_OWORD *)&p_celestialConfig.talosAlphaConfig.drawPlanetInSkydome;
			//                     *((_OWORD *)v12 + 3) = v168;
			//                     v170 = *(_OWORD *)&p_celestialConfig.talosAlphaConfig.objectProperty.selfTiltZ;
			//                     *((_OWORD *)v12 + 4) = v169;
			//                     v171 = *(_OWORD *)&p_celestialConfig.talosAlphaConfig.skydomeDrawer.drawMaterial;
			//                     *((_OWORD *)v12 + 5) = v170;
			//                     v172 = *(_OWORD *)&p_celestialConfig.talosAlphaConfig.skydomeDrawer.incidentLightingPitchYaw.x;
			//                     p_celestialConfig = (HGCelestialConfig *)((char *)p_celestialConfig + v162);
			//                     *((_OWORD *)v12 + 6) = v171;
			//                     v12 += v162;
			//                     *((_OWORD *)v12 - 1) = v172;
			//                     --v164;
			//                   }
			//                   while ( v164 );
			//                   v173 = *(_OWORD *)&p_celestialConfig.moonConfig.worldLongitude;
			//                   *(_OWORD *)v12 = *(_OWORD *)&p_celestialConfig.moonConfig.radius;
			//                   v174 = *(_OWORD *)&p_celestialConfig.moonConfig.ring.outerRadius;
			//                   *((_OWORD *)v12 + 1) = v173;
			//                   v175 = *(_OWORD *)&p_celestialConfig.moonConfig.ring.ringColor.b;
			//                   *((_OWORD *)v12 + 2) = v174;
			//                   v176 = *(_OWORD *)&p_celestialConfig.talosAlphaConfig.drawPlanetInSkydome;
			//                   *((_OWORD *)v12 + 3) = v175;
			//                   v177 = *(_OWORD *)&p_celestialConfig.talosAlphaConfig.objectProperty.selfTiltZ;
			//                   drawMaterial = p_celestialConfig.talosAlphaConfig.skydomeDrawer.drawMaterial;
			//                   *((_OWORD *)v12 + 4) = v176;
			//                   *((_OWORD *)v12 + 5) = v177;
			//                   *((_QWORD *)v12 + 12) = drawMaterial;
			//                   if ( v11 )
			//                   {
			//                     v179 = (__int128 *)&v11.fields.celestialConfig;
			//                     v180 = v161;
			//                     v181 = &v308;
			//                     do
			//                     {
			//                       v182 = v181[1];
			//                       *v179 = *v181;
			//                       v183 = v181[2];
			//                       v179[1] = v182;
			//                       v184 = v181[3];
			//                       v179[2] = v183;
			//                       v185 = v181[4];
			//                       v179[3] = v184;
			//                       v186 = v181[5];
			//                       v179[4] = v185;
			//                       v187 = v181[6];
			//                       v179[5] = v186;
			//                       v188 = v181[7];
			//                       v181 = (__int128 *)((char *)v181 + v162);
			//                       v179[6] = v187;
			//                       v179 = (__int128 *)((char *)v179 + v162);
			//                       *(v179 - 1) = v188;
			//                       --v180;
			//                     }
			//                     while ( v180 );
			//                     v189 = v181[1];
			//                     *v179 = *v181;
			//                     v190 = v181[2];
			//                     v179[1] = v189;
			//                     v191 = v181[3];
			//                     v179[2] = v190;
			//                     v192 = v181[4];
			//                     v179[3] = v191;
			//                     v193 = v181[5];
			//                     v194 = *((_QWORD *)v181 + 12);
			//                     v179[4] = v192;
			//                     v179[5] = v193;
			//                     *((_QWORD *)v179 + 12) = v194;
			//                     sub_1800054D0(
			//                       (OneofDescriptor *)&v11.fields.celestialConfig.moonConfig.ring.planetRingMap,
			//                       (OneofDescriptorProto *)v11,
			//                       0LL,
			//                       v163,
			//                       (String__Array *)v308,
			//                       *((String **)&v308 + 1),
			//                       *(MethodInfo **)&v309.r);
			//                     v197 = (MessageDescriptor *)TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume;
			//                     v198 = *(_QWORD *)&this.fields.windConfig.direction.y;
			//                     v12 = (char *)TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume.static_fields.s_animatedEnvPhase;
			//                     v199 = *(_DWORD *)&this.fields.windConfig.m_active;
			//                     if ( v12 )
			//                     {
			//                       *((_OWORD *)v12 + 122) = *(_OWORD *)&this.fields.windConfig.speed;
			//                       *((_QWORD *)v12 + 246) = v198;
			//                       *((_DWORD *)v12 + 494) = v199;
			//                       bloomTint = this.fields.lightShaftConfig.bloomTint;
			//                       v201 = *(_OWORD *)&this.fields.lightShaftConfig.blurIntensity;
			//                       v202 = TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume.static_fields.s_animatedEnvPhase;
			//                       v12 = (char *)*(unsigned int *)&this.fields.lightShaftConfig.m_active;
			//                       if ( v202 )
			//                       {
			//                         *(_OWORD *)&v202.fields.lightShaftConfig.enable = *(_OWORD *)&this.fields.lightShaftConfig.enable;
			//                         v202.fields.lightShaftConfig.bloomTint = bloomTint;
			//                         *(_OWORD *)&v202.fields.lightShaftConfig.blurIntensity = v201;
			//                         *(_DWORD *)&v202.fields.lightShaftConfig.m_active = (_DWORD)v12;
			//                         v203 = TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume.static_fields.s_animatedEnvPhase;
			//                         v12 = (char *)*(unsigned int *)&this.fields.terrainDeformConfig.m_active;
			//                         if ( v203 )
			//                         {
			//                           v204 = v195;
			//                           *(_QWORD *)&v203.fields.terrainDeformConfig.deformGlobalStrength = *(_QWORD *)&this.fields.terrainDeformConfig.deformGlobalStrength;
			//                           *(_DWORD *)&v203.fields.terrainDeformConfig.m_active = (_DWORD)v12;
			//                           p_rainConfig = &this.fields.rainConfig;
			//                           v11 = TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume.static_fields.s_animatedEnvPhase;
			//                           v12 = (char *)&v308;
			//                           do
			//                           {
			//                             v206 = *(_OWORD *)&p_rainConfig.color.g;
			//                             *(_OWORD *)v12 = *(_OWORD *)&p_rainConfig.enable;
			//                             v207 = *(_OWORD *)&p_rainConfig.horizontalRainAngle;
			//                             *((_OWORD *)v12 + 1) = v206;
			//                             v208 = *(_OWORD *)&p_rainConfig.sceneEffectRainLightingPercent;
			//                             *((_OWORD *)v12 + 2) = v207;
			//                             v209 = *(_OWORD *)&p_rainConfig.middleHorizontalRainAngle;
			//                             *((_OWORD *)v12 + 3) = v208;
			//                             v210 = *(_OWORD *)&p_rainConfig.farRainAlphaMultiplier;
			//                             *((_OWORD *)v12 + 4) = v209;
			//                             v211 = *(_OWORD *)&p_rainConfig.rainWaveHorizontalSpeed;
			//                             *((_OWORD *)v12 + 5) = v210;
			//                             v212 = *(_OWORD *)&p_rainConfig.screenDropColor.g;
			//                             p_rainConfig = (HGRainConfig *)((char *)p_rainConfig + v196);
			//                             *((_OWORD *)v12 + 6) = v211;
			//                             v12 += v196;
			//                             *((_OWORD *)v12 - 1) = v212;
			//                             v204 = (HGEnvironmentPhase *)((char *)v204 - 1);
			//                           }
			//                           while ( v204 );
			//                           v213 = *(_OWORD *)&p_rainConfig.color.g;
			//                           *(_OWORD *)v12 = *(_OWORD *)&p_rainConfig.enable;
			//                           v214 = *(_OWORD *)&p_rainConfig.horizontalRainAngle;
			//                           *((_OWORD *)v12 + 1) = v213;
			//                           *((_OWORD *)v12 + 2) = v214;
			//                           if ( v11 )
			//                           {
			//                             v215 = &v11.fields.rainConfig;
			//                             v11 = v195;
			//                             v216 = &v308;
			//                             do
			//                             {
			//                               v217 = v216[1];
			//                               *(_OWORD *)&v215.enable = *v216;
			//                               v218 = v216[2];
			//                               *(_OWORD *)&v215.color.g = v217;
			//                               v219 = v216[3];
			//                               *(_OWORD *)&v215.horizontalRainAngle = v218;
			//                               v220 = v216[4];
			//                               *(_OWORD *)&v215.sceneEffectRainLightingPercent = v219;
			//                               v221 = v216[5];
			//                               *(_OWORD *)&v215.middleHorizontalRainAngle = v220;
			//                               v222 = v216[6];
			//                               *(_OWORD *)&v215.farRainAlphaMultiplier = v221;
			//                               v223 = v216[7];
			//                               v216 = (__int128 *)((char *)v216 + v196);
			//                               *(_OWORD *)&v215.rainWaveHorizontalSpeed = v222;
			//                               v215 = (HGRainConfig *)((char *)v215 + v196);
			//                               *(_OWORD *)&v215[-1].farRainDirection.x = v223;
			//                               v11 = (HGEnvironmentPhase *)((char *)v11 - 1);
			//                             }
			//                             while ( v11 );
			//                             v224 = v216[1];
			//                             *(_OWORD *)&v215.enable = *v216;
			//                             v225 = v216[2];
			//                             *(_OWORD *)&v215.color.g = v224;
			//                             *(_OWORD *)&v215.horizontalRainAngle = v225;
			//                             v226 = *(_OWORD *)&this.fields.snowConfig.color.g;
			//                             v12 = (char *)TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume.static_fields;
			//                             v227 = *(_OWORD *)&this.fields.snowConfig.snowSizeRange.y;
			//                             v228 = *(_OWORD *)&this.fields.snowConfig.snowLightingPercent;
			//                             v229 = *(_QWORD *)v12;
			//                             v230 = *(_QWORD *)&this.fields.snowConfig.snowDirection.z;
			//                             if ( *(_QWORD *)v12 )
			//                             {
			//                               *(_OWORD *)(v229 + 2376) = *(_OWORD *)&this.fields.snowConfig.enable;
			//                               *(_OWORD *)(v229 + 2392) = v226;
			//                               *(_OWORD *)(v229 + 2408) = v227;
			//                               *(_OWORD *)(v229 + 2424) = v228;
			//                               *(_QWORD *)(v229 + 2440) = v230;
			//                               starsTint = this.fields.starConfig.starsTint;
			//                               v11 = TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume.static_fields.s_animatedEnvPhase;
			//                               v308 = *(_OWORD *)&this.fields.starConfig.enableStars;
			//                               v232 = *(_OWORD *)&this.fields.starConfig.starsOffset0;
			//                               v309 = starsTint;
			//                               starsTint1 = this.fields.starConfig.starsTint1;
			//                               v310 = v232;
			//                               v234 = *(_OWORD *)&this.fields.starConfig.starsOffset1;
			//                               v311 = starsTint1;
			//                               starsTint2 = this.fields.starConfig.starsTint2;
			//                               v312 = v234;
			//                               v236 = *(_OWORD *)&this.fields.starConfig.starsOffset2;
			//                               v313 = starsTint2;
			//                               v237 = *(_OWORD *)&this.fields.starConfig.starLayerViewMode;
			//                               v238 = &this.fields.starConfig.enableStars + v196;
			//                               v314 = v236;
			//                               v12 = (char *)&v308 + v196;
			//                               v239 = *(_OWORD *)v238;
			//                               *((_OWORD *)v12 - 1) = v237;
			//                               v240 = *((_OWORD *)v238 + 1);
			//                               *(_OWORD *)v12 = v239;
			//                               v241 = *((_OWORD *)v238 + 2);
			//                               *((_OWORD *)v12 + 1) = v240;
			//                               v242 = *((_OWORD *)v238 + 3);
			//                               *((_OWORD *)v12 + 2) = v241;
			//                               *((_OWORD *)v12 + 3) = v242;
			//                               if ( v11 )
			//                               {
			//                                 v243 = v309;
			//                                 *(_OWORD *)&v11.fields.starConfig.enableStars = v308;
			//                                 v244 = v310;
			//                                 v11.fields.starConfig.starsTint = v243;
			//                                 v245 = v311;
			//                                 *(_OWORD *)&v11.fields.starConfig.starsOffset0 = v244;
			//                                 v246 = v312;
			//                                 v11.fields.starConfig.starsTint1 = v245;
			//                                 v247 = v313;
			//                                 *(_OWORD *)&v11.fields.starConfig.starsOffset1 = v246;
			//                                 v248 = v314;
			//                                 v11.fields.starConfig.starsTint2 = v247;
			//                                 v249 = v315;
			//                                 *(_OWORD *)&v11.fields.starConfig.starsOffset2 = v248;
			//                                 v250 = &v11.fields.starConfig.enableStars + v196;
			//                                 v251 = *(__int128 *)((char *)&v308 + v196);
			//                                 *((_OWORD *)v250 - 1) = v249;
			//                                 v252 = *(__int128 *)((char *)&v308 + v196 + 16);
			//                                 *(_OWORD *)v250 = v251;
			//                                 v253 = *(__int128 *)((char *)&v308 + v196 + 32);
			//                                 *((_OWORD *)v250 + 1) = v252;
			//                                 v254 = *(__int128 *)((char *)&v308 + v196 + 48);
			//                                 *((_OWORD *)v250 + 2) = v253;
			//                                 *((_OWORD *)v250 + 3) = v254;
			//                                 sub_1800054D0(
			//                                   (OneofDescriptor *)&v11.fields.starConfig.skyboxStarNoiseMap,
			//                                   (OneofDescriptorProto *)v11,
			//                                   0LL,
			//                                   v197,
			//                                   (String__Array *)v308,
			//                                   *((String **)&v308 + 1),
			//                                   *(MethodInfo **)&v309.r);
			//                                 v256 = (MessageDescriptor *)TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume;
			//                                 v257 = *(_OWORD *)&this.fields.lensFlareConfig.intensity;
			//                                 v258 = *(_OWORD *)&this.fields.lensFlareConfig.sampleCount;
			//                                 v12 = (char *)TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume.static_fields.s_animatedEnvPhase;
			//                                 if ( v12 )
			//                                 {
			//                                   *((_OWORD *)v12 + 165) = *(_OWORD *)&this.fields.lensFlareConfig.enable;
			//                                   *((_OWORD *)v12 + 166) = v257;
			//                                   *((_OWORD *)v12 + 167) = v258;
			//                                   sub_1800054D0(
			//                                     (OneofDescriptor *)(v12 + 2648),
			//                                     (OneofDescriptorProto *)v11,
			//                                     v255,
			//                                     v256,
			//                                     (String__Array *)v308,
			//                                     *((String **)&v308 + 1),
			//                                     *(MethodInfo **)&v309.r);
			//                                   v261 = (MessageDescriptor *)TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume;
			//                                   v12 = (char *)&v308;
			//                                   v262 = v259;
			//                                   v11 = TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume.static_fields.s_animatedEnvPhase;
			//                                   p_colorGradingConfig = &this.fields.colorGradingConfig;
			//                                   do
			//                                   {
			//                                     v264 = *(_OWORD *)&p_colorGradingConfig.colorLookupContribution;
			//                                     *(_OWORD *)v12 = *(_OWORD *)&p_colorGradingConfig.tonemappingMode;
			//                                     v265 = *(_OWORD *)&p_colorGradingConfig.colorAdjustmentsEnabled;
			//                                     *((_OWORD *)v12 + 1) = v264;
			//                                     v266 = *(_OWORD *)&p_colorGradingConfig.colorAdjustmentsColorFilter.g;
			//                                     *((_OWORD *)v12 + 2) = v265;
			//                                     v267 = *(_OWORD *)&p_colorGradingConfig.colorAdjustmentsSaturation;
			//                                     *((_OWORD *)v12 + 3) = v266;
			//                                     v268 = *(_OWORD *)&p_colorGradingConfig.channelMixerRedOutBlueIn;
			//                                     *((_OWORD *)v12 + 4) = v267;
			//                                     v269 = *(_OWORD *)&p_colorGradingConfig.channelMixerBlueOutRedIn;
			//                                     *((_OWORD *)v12 + 5) = v268;
			//                                     shadows = p_colorGradingConfig.shadowsMidtonesHighlights.shadows;
			//                                     p_colorGradingConfig = (HGColorGradingConfig *)((char *)p_colorGradingConfig + v260);
			//                                     *((_OWORD *)v12 + 6) = v269;
			//                                     v12 += v260;
			//                                     *((Vector4 *)v12 - 1) = shadows;
			//                                     --v262;
			//                                   }
			//                                   while ( v262 );
			//                                   v271 = *(_OWORD *)&p_colorGradingConfig.colorLookupContribution;
			//                                   *(_OWORD *)v12 = *(_OWORD *)&p_colorGradingConfig.tonemappingMode;
			//                                   v272 = *(_OWORD *)&p_colorGradingConfig.colorAdjustmentsEnabled;
			//                                   *((_OWORD *)v12 + 1) = v271;
			//                                   v273 = *(_OWORD *)&p_colorGradingConfig.colorAdjustmentsColorFilter.g;
			//                                   *((_OWORD *)v12 + 2) = v272;
			//                                   v274 = *(_OWORD *)&p_colorGradingConfig.colorAdjustmentsSaturation;
			//                                   *((_OWORD *)v12 + 3) = v273;
			//                                   v275 = *(_OWORD *)&p_colorGradingConfig.channelMixerRedOutBlueIn;
			//                                   *((_OWORD *)v12 + 4) = v274;
			//                                   v276 = *(_OWORD *)&p_colorGradingConfig.channelMixerBlueOutRedIn;
			//                                   *((_OWORD *)v12 + 5) = v275;
			//                                   *((_OWORD *)v12 + 6) = v276;
			//                                   if ( v11 )
			//                                   {
			//                                     v277 = &v11.fields.colorGradingConfig;
			//                                     v278 = &v308;
			//                                     do
			//                                     {
			//                                       v279 = v278[1];
			//                                       *(_OWORD *)&v277.tonemappingMode = *v278;
			//                                       v280 = v278[2];
			//                                       *(_OWORD *)&v277.colorLookupContribution = v279;
			//                                       v281 = v278[3];
			//                                       *(_OWORD *)&v277.colorAdjustmentsEnabled = v280;
			//                                       v282 = v278[4];
			//                                       *(_OWORD *)&v277.colorAdjustmentsColorFilter.g = v281;
			//                                       v283 = v278[5];
			//                                       *(_OWORD *)&v277.colorAdjustmentsSaturation = v282;
			//                                       v284 = v278[6];
			//                                       *(_OWORD *)&v277.channelMixerRedOutBlueIn = v283;
			//                                       v285 = v278[7];
			//                                       v278 = (__int128 *)((char *)v278 + v260);
			//                                       *(_OWORD *)&v277.channelMixerBlueOutRedIn = v284;
			//                                       v277 = (HGColorGradingConfig *)((char *)v277 + v260);
			//                                       *(_OWORD *)&v277[-1].colorCurves.masterOverriding = v285;
			//                                       --v259;
			//                                     }
			//                                     while ( v259 );
			//                                     v286 = v278[1];
			//                                     *(_OWORD *)&v277.tonemappingMode = *v278;
			//                                     v287 = v278[2];
			//                                     *(_OWORD *)&v277.colorLookupContribution = v286;
			//                                     v288 = v278[3];
			//                                     *(_OWORD *)&v277.colorAdjustmentsEnabled = v287;
			//                                     v289 = v278[4];
			//                                     *(_OWORD *)&v277.colorAdjustmentsColorFilter.g = v288;
			//                                     v290 = v278[5];
			//                                     *(_OWORD *)&v277.colorAdjustmentsSaturation = v289;
			//                                     v291 = v278[6];
			//                                     *(_OWORD *)&v277.channelMixerRedOutBlueIn = v290;
			//                                     *(_OWORD *)&v277.channelMixerBlueOutRedIn = v291;
			//                                     sub_1800054D0(
			//                                       (OneofDescriptor *)&v11.fields.colorGradingConfig.colorLookupTexture,
			//                                       (OneofDescriptorProto *)v11,
			//                                       0LL,
			//                                       v261,
			//                                       (String__Array *)v308,
			//                                       *((String **)&v308 + 1),
			//                                       *(MethodInfo **)&v309.r);
			//                                     v293 = (MessageDescriptor *)TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume;
			//                                     v294 = *(_OWORD *)&this.fields.autoExposureConfig.autoExposureEv100Range.x;
			//                                     v295 = *(_OWORD *)&this.fields.autoExposureConfig.autoExposureMeteringMode;
			//                                     v296 = *(_QWORD *)&this.fields.autoExposureConfig.autoExposureEvClampRange.y;
			//                                     v12 = (char *)TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume.static_fields.s_animatedEnvPhase;
			//                                     v297 = *(_DWORD *)&this.fields.autoExposureConfig.m_active;
			//                                     if ( v12 )
			//                                     {
			//                                       *((_OWORD *)v12 + 191) = *(_OWORD *)&this.fields.autoExposureConfig.autoExposureMode;
			//                                       *((_OWORD *)v12 + 192) = v294;
			//                                       *((_OWORD *)v12 + 193) = v295;
			//                                       *((_QWORD *)v12 + 388) = v296;
			//                                       *((_DWORD *)v12 + 778) = v297;
			//                                       v298 = *(_OWORD *)&this.fields.shadowConfig.csmIntensity;
			//                                       v299 = *(_OWORD *)&this.fields.shadowConfig.csmShadowSoftness;
			//                                       v300 = *(_OWORD *)&this.fields.shadowConfig.contactShadowSurfaceThickness;
			//                                       v12 = (char *)TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume.static_fields.s_animatedEnvPhase;
			//                                       v301 = *(_QWORD *)&this.fields.shadowConfig.csmSimulatedAttenuation;
			//                                       v302 = *(_OWORD *)&this.fields.shadowConfig.overrideCsmFarDistance;
			//                                       v303 = *(_OWORD *)&this.fields.shadowConfig.overrideCsmSpherePosition.z;
			//                                       if ( v12 )
			//                                       {
			//                                         *((_OWORD *)v12 + 195) = *(_OWORD *)&this.fields.shadowConfig.csmDepthBias;
			//                                         *((_OWORD *)v12 + 196) = v298;
			//                                         *((_OWORD *)v12 + 197) = v299;
			//                                         *((_OWORD *)v12 + 198) = v300;
			//                                         *((_OWORD *)v12 + 199) = v302;
			//                                         *((_OWORD *)v12 + 200) = v303;
			//                                         *((_QWORD *)v12 + 402) = v301;
			//                                         sub_1800054D0(
			//                                           (OneofDescriptor *)(v12 + 3144),
			//                                           (OneofDescriptorProto *)v11,
			//                                           v292,
			//                                           v293,
			//                                           (String__Array *)v308,
			//                                           *((String **)&v308 + 1),
			//                                           *(MethodInfo **)&v309.r);
			//                                         v304 = this.fields.anamorphicStreaksConfig.bloomTint;
			//                                         v305 = *(_OWORD *)&this.fields.anamorphicStreaksConfig.blurIntensity;
			//                                         v12 = (char *)TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume.static_fields.s_animatedEnvPhase;
			//                                         if ( v12 )
			//                                         {
			//                                           *(_OWORD *)(v12 + 3224) = *(_OWORD *)&this.fields.anamorphicStreaksConfig.enable;
			//                                           *(Color *)(v12 + 3240) = v304;
			//                                           *(_OWORD *)(v12 + 3256) = v305;
			//                                           return TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume.static_fields.s_animatedEnvPhase;
			//                                         }
			//                                       }
			//                                     }
			//                                   }
			//                                 }
			//                               }
			//                             }
			//                           }
			//                         }
			//                       }
			//                     }
			//                   }
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_51:
			//     sub_180B536AC(v12, v11);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1191, 0LL);
			//   if ( !Patch )
			//     goto LABEL_51;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_199(Patch, (Object *)this, 0LL);
			// }
			// 
			return null;
		}

		public bool <>iFixBaseProxy_HasEnvPhase()
		{
			// // Boolean <>iFixBaseProxy_HasEnvPhase()
			// bool HG::Rendering::Runtime::HGAnimatedEnvironmentVolume::__iFixBaseProxy_HasEnvPhase(
			//         HGAnimatedEnvironmentVolume *this,
			//         MethodInfo *method)
			// {
			//   return HG::Rendering::Runtime::HGEnvironmentVolume::HasEnvPhase((HGEnvironmentVolume *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		public HGEnvironmentPhase <>iFixBaseProxy_GetEnvPhaseForInterpolate()
		{
			// // HGEnvironmentPhase <>iFixBaseProxy_GetEnvPhaseForInterpolate()
			// HGEnvironmentPhase *HG::Rendering::Runtime::HGAnimatedEnvironmentVolume::__iFixBaseProxy_GetEnvPhaseForInterpolate(
			//         HGAnimatedEnvironmentVolume *this,
			//         MethodInfo *method)
			// {
			//   return HG::Rendering::Runtime::HGEnvironmentVolume::GetEnvPhaseForInterpolate((HGEnvironmentVolume *)this, 0LL);
			// }
			// 
			return null;
		}

		public HGLightConfig lightConfig;

		public HGSkyConfig skyConfig;

		public HGAtmosphereConfig atmosphereConfig;

		public HGFogConfig fogConfig;

		public HGHeightFogConfig heightFogConfig;

		public HGVolumetricFogConfig volumetricFogConfig;

		public HGCloudConfig cloudConfig;

		public HGCelestialConfig celestialConfig;

		public HGWindConfig windConfig;

		public HGLightShaftConfig lightShaftConfig;

		public HGTerrainDeformConfig terrainDeformConfig;

		public HGRainConfig rainConfig;

		public HGSnowConfig snowConfig;

		public HGStarConfig starConfig;

		public HGLensFlareConfig lensFlareConfig;

		public HGColorGradingConfig colorGradingConfig;

		public HGAutoExposureConfig autoExposureConfig;

		public HGShadowConfig shadowConfig;

		public HGAnamorphicStreaksConfig anamorphicStreaksConfig;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static HGEnvironmentPhase s_animatedEnvPhase;
	}
}
