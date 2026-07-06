using System;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[CreateAssetMenu(fileName = "Env_", menuName = "Env Phase")]
	public class HGEnvironmentPhase : ScriptableObject
	{
		public HGEnvironmentPhase()
		{
			// // HGEnvironmentPhase()
			// void HG::Rendering::Runtime::HGEnvironmentPhase::HGEnvironmentPhase(HGEnvironmentPhase *this, MethodInfo *method)
			// {
			//   FileDescriptor *v2; // r8
			//   MessageDescriptor *v3; // r9
			//   struct HGLightConfig__Class *v5; // rax
			//   __int128 *static_fields; // rax
			//   __int128 *v7; // rcx
			//   __int64 v8; // rdi
			//   __int64 v9; // rdx
			//   __int128 v10; // xmm0
			//   __int128 v11; // xmm1
			//   __int128 v12; // xmm0
			//   __int128 v13; // xmm1
			//   __int128 v14; // xmm0
			//   __int128 v15; // xmm1
			//   __int128 v16; // xmm0
			//   __int128 v17; // xmm1
			//   __int64 v18; // rdx
			//   __int128 v19; // xmm1
			//   __int128 v20; // xmm0
			//   __int128 v21; // xmm1
			//   __int128 v22; // xmm0
			//   __int128 v23; // xmm1
			//   HGLightConfig *p_lightConfig; // rax
			//   Color *v25; // rcx
			//   Color v26; // xmm0
			//   Color v27; // xmm1
			//   Color v28; // xmm0
			//   Color v29; // xmm1
			//   Color v30; // xmm0
			//   Color v31; // xmm1
			//   Color v32; // xmm0
			//   Color v33; // xmm1
			//   Color v34; // xmm1
			//   Color v35; // xmm0
			//   Color v36; // xmm1
			//   Color v37; // xmm0
			//   Color v38; // xmm1
			//   struct HGSkyConfig__Class *v39; // rax
			//   HGSkyConfig__StaticFields *v40; // rax
			//   __int128 *v41; // rcx
			//   __int64 v42; // rdx
			//   __int128 v43; // xmm0
			//   __int128 v44; // xmm1
			//   __int128 v45; // xmm0
			//   __int128 v46; // xmm1
			//   __int128 v47; // xmm0
			//   __int128 v48; // xmm1
			//   __int128 v49; // xmm0
			//   __int128 v50; // xmm1
			//   __int64 v51; // rdx
			//   __int128 v52; // xmm1
			//   __int128 v53; // xmm0
			//   __int128 v54; // xmm1
			//   __int128 v55; // xmm0
			//   __int64 v56; // rax
			//   HGSkyConfig *p_skyConfig; // rcx
			//   __int128 *v58; // rax
			//   __int128 v59; // xmm0
			//   __int128 v60; // xmm1
			//   __int128 v61; // xmm0
			//   __int128 v62; // xmm1
			//   __int128 v63; // xmm0
			//   __int128 v64; // xmm1
			//   __int128 v65; // xmm0
			//   __int128 v66; // xmm1
			//   __int128 v67; // xmm1
			//   __int128 v68; // xmm0
			//   __int128 v69; // xmm1
			//   __int128 v70; // xmm0
			//   __int64 v71; // rax
			//   __int64 v72; // rdx
			//   FileDescriptor *v73; // r8
			//   MessageDescriptor *v74; // r9
			//   struct HGAtmosphereConfig__Class *v75; // rax
			//   HGAtmosphereConfig__StaticFields *v76; // rax
			//   __int128 v77; // xmm2
			//   __int128 v78; // xmm3
			//   Color rayleighScattering; // xmm4
			//   __int128 v80; // xmm5
			//   __int128 v81; // xmm6
			//   __int128 v82; // xmm7
			//   __int128 v83; // xmm8
			//   __int128 v84; // xmm9
			//   __int64 v85; // xmm0_8
			//   struct HGFogConfig__Class *v86; // rax
			//   HGFogConfig__StaticFields *v87; // rax
			//   int v88; // ecx
			//   __int128 v89; // xmm1
			//   __int128 v90; // xmm2
			//   __int128 v91; // xmm3
			//   Color inscatterAmbientColor; // xmm4
			//   struct HGHeightFogConfig__Class *v93; // rax
			//   HGHeightFogConfig__StaticFields *v94; // rax
			//   Color v95; // xmm1
			//   __int128 v96; // xmm0
			//   Color v97; // xmm1
			//   __int128 v98; // xmm0
			//   Color v99; // xmm1
			//   __int128 v100; // xmm0
			//   __int128 v101; // xmm1
			//   __int128 v102; // xmm0
			//   __int128 v103; // xmm1
			//   Color v104; // xmm0
			//   __int128 v105; // xmm1
			//   __int64 v106; // rax
			//   Color v107; // xmm1
			//   __int128 v108; // xmm0
			//   Color v109; // xmm1
			//   __int128 v110; // xmm0
			//   Color v111; // xmm1
			//   __int128 v112; // xmm0
			//   __int128 v113; // xmm1
			//   __int128 v114; // xmm0
			//   __int128 v115; // xmm1
			//   Color v116; // xmm0
			//   __int128 v117; // xmm1
			//   __int64 v118; // rax
			//   struct HGVolumetricFogConfig__Class *v119; // rax
			//   HGVolumetricFogConfig__StaticFields *v120; // rax
			//   __int128 *v121; // rcx
			//   __int64 v122; // rdx
			//   __int128 v123; // xmm0
			//   __int128 v124; // xmm1
			//   __int128 v125; // xmm0
			//   __int128 v126; // xmm1
			//   __int128 v127; // xmm0
			//   __int128 v128; // xmm1
			//   __int128 v129; // xmm0
			//   __int128 v130; // xmm1
			//   HGVolumetricFogConfig *p_volumetricFogConfig; // rax
			//   __int64 v132; // rdx
			//   __int128 *v133; // rcx
			//   __int128 v134; // xmm0
			//   __int128 v135; // xmm1
			//   __int128 v136; // xmm0
			//   __int128 v137; // xmm1
			//   __int128 v138; // xmm0
			//   __int128 v139; // xmm1
			//   __int128 v140; // xmm0
			//   __int128 v141; // xmm1
			//   struct HGCloudConfig__Class *v142; // rax
			//   HGCloudConfig__StaticFields *v143; // rax
			//   Color cloudTint; // xmm1
			//   __int128 v145; // xmm0
			//   Color v146; // xmm1
			//   __int128 v147; // xmm0
			//   Color v148; // xmm1
			//   __int128 v149; // xmm0
			//   __int128 v150; // xmm1
			//   __int128 v151; // xmm0
			//   __int128 v152; // xmm1
			//   Color v153; // xmm0
			//   Color v154; // xmm1
			//   __int128 v155; // xmm0
			//   Color v156; // xmm1
			//   __int128 v157; // xmm0
			//   Color v158; // xmm1
			//   __int128 v159; // xmm0
			//   __int128 v160; // xmm1
			//   __int128 v161; // xmm0
			//   __int128 v162; // xmm1
			//   Color v163; // xmm0
			//   __int64 v164; // rdx
			//   FileDescriptor *v165; // r8
			//   MessageDescriptor *v166; // r9
			//   struct HGCelestialConfig__Class *v167; // rax
			//   HGCelestialConfig__StaticFields *v168; // rax
			//   __int128 *v169; // rcx
			//   __int64 v170; // rdx
			//   __int128 v171; // xmm0
			//   __int128 v172; // xmm1
			//   __int128 v173; // xmm0
			//   __int128 v174; // xmm1
			//   __int128 v175; // xmm0
			//   __int128 v176; // xmm1
			//   __int128 v177; // xmm0
			//   __int128 v178; // xmm1
			//   __int64 v179; // rdx
			//   __int128 v180; // xmm1
			//   __int128 v181; // xmm0
			//   __int128 v182; // xmm1
			//   __int128 v183; // xmm0
			//   __int128 v184; // xmm1
			//   Material *drawMaterial; // rax
			//   HGCelestialConfig *p_celestialConfig; // rcx
			//   __int128 *v187; // rax
			//   __int128 v188; // xmm0
			//   __int128 v189; // xmm1
			//   __int128 v190; // xmm0
			//   __int128 v191; // xmm1
			//   __int128 v192; // xmm0
			//   __int128 v193; // xmm1
			//   __int128 v194; // xmm0
			//   __int128 v195; // xmm1
			//   __int128 v196; // xmm1
			//   __int128 v197; // xmm0
			//   __int128 v198; // xmm1
			//   __int128 v199; // xmm0
			//   __int128 v200; // xmm1
			//   Material *v201; // rax
			//   OneofDescriptorProto *v202; // rdx
			//   FileDescriptor *v203; // r8
			//   MessageDescriptor *v204; // r9
			//   struct HGWindConfig__Class *v205; // rax
			//   HGWindConfig__StaticFields *v206; // rax
			//   int v207; // ecx
			//   __int64 v208; // xmm0_8
			//   struct HGLightShaftConfig__Class *v209; // rax
			//   HGLightShaftConfig__StaticFields *v210; // rax
			//   int v211; // ecx
			//   Color bloomTint; // xmm1
			//   __int128 v213; // xmm2
			//   struct HGTerrainDeformConfig__Class *v214; // rax
			//   HGTerrainDeformConfig__StaticFields *v215; // rax
			//   int v216; // ecx
			//   struct HGInkSimulationConfig__Class *v217; // rax
			//   HGInkSimulationConfig__StaticFields *v218; // rax
			//   __int64 v219; // xmm0_8
			//   __int64 v220; // rdx
			//   FileDescriptor *v221; // r8
			//   MessageDescriptor *v222; // r9
			//   struct HGRainConfig__Class *v223; // rax
			//   HGRainConfig__StaticFields *v224; // rax
			//   __int128 *v225; // rcx
			//   __int64 v226; // rdx
			//   __int128 v227; // xmm0
			//   __int128 v228; // xmm1
			//   __int128 v229; // xmm0
			//   __int128 v230; // xmm1
			//   __int128 v231; // xmm0
			//   __int128 v232; // xmm1
			//   __int128 v233; // xmm0
			//   __int128 v234; // xmm1
			//   __int64 v235; // rdx
			//   __int128 v236; // xmm1
			//   __int128 v237; // xmm0
			//   HGRainConfig *p_rainConfig; // rax
			//   __int128 *v239; // rcx
			//   __int128 v240; // xmm0
			//   __int128 v241; // xmm1
			//   __int128 v242; // xmm0
			//   __int128 v243; // xmm1
			//   __int128 v244; // xmm0
			//   __int128 v245; // xmm1
			//   __int128 v246; // xmm0
			//   __int128 v247; // xmm1
			//   __int128 v248; // xmm1
			//   __int128 v249; // xmm0
			//   struct HGSnowConfig__Class *v250; // rax
			//   HGSnowConfig__StaticFields *v251; // rax
			//   __int128 v252; // xmm2
			//   __int128 v253; // xmm3
			//   __int128 v254; // xmm4
			//   __int64 v255; // xmm0_8
			//   struct HGStarConfig__Class *v256; // rax
			//   HGStarConfig__StaticFields *v257; // rax
			//   Color starsTint; // xmm1
			//   __int128 v259; // xmm0
			//   Color starsTint1; // xmm1
			//   __int128 v261; // xmm0
			//   Color starsTint2; // xmm1
			//   __int128 v263; // xmm0
			//   __int128 v264; // xmm1
			//   __int128 v265; // xmm0
			//   __int128 v266; // xmm1
			//   Color nebulaTint; // xmm0
			//   __int128 v268; // xmm1
			//   Color v269; // xmm1
			//   __int128 v270; // xmm0
			//   Color v271; // xmm1
			//   __int128 v272; // xmm0
			//   Color v273; // xmm1
			//   __int128 v274; // xmm0
			//   __int128 v275; // xmm1
			//   __int128 v276; // xmm0
			//   __int128 v277; // xmm1
			//   Color v278; // xmm0
			//   __int128 v279; // xmm1
			//   OneofDescriptorProto *v280; // rdx
			//   FileDescriptor *v281; // r8
			//   MessageDescriptor *v282; // r9
			//   struct HGLensFlareConfig__Class *v283; // rax
			//   HGLensFlareConfig__StaticFields *v284; // rax
			//   __int128 v285; // xmm1
			//   __int128 v286; // xmm2
			//   __int64 v287; // rdx
			//   FileDescriptor *v288; // r8
			//   MessageDescriptor *v289; // r9
			//   struct HGColorGradingConfig__Class *v290; // rax
			//   __int128 *v291; // rcx
			//   HGColorGradingConfig *p_defaultConfig; // rax
			//   __int64 v293; // rdx
			//   __int128 v294; // xmm0
			//   __int128 v295; // xmm1
			//   __int128 v296; // xmm0
			//   __int128 v297; // xmm1
			//   __int128 v298; // xmm0
			//   __int128 v299; // xmm1
			//   __int128 v300; // xmm0
			//   __int128 v301; // xmm1
			//   __int128 v302; // xmm1
			//   __int128 v303; // xmm0
			//   __int128 v304; // xmm1
			//   __int128 v305; // xmm0
			//   __int128 v306; // xmm1
			//   __int128 v307; // xmm0
			//   HGColorGradingConfig *p_colorGradingConfig; // rax
			//   __int128 *v309; // rcx
			//   __int128 v310; // xmm0
			//   __int128 v311; // xmm1
			//   __int128 v312; // xmm0
			//   __int128 v313; // xmm1
			//   __int128 v314; // xmm0
			//   __int128 v315; // xmm1
			//   __int128 v316; // xmm0
			//   __int128 v317; // xmm1
			//   __int128 v318; // xmm1
			//   __int128 v319; // xmm0
			//   __int128 v320; // xmm1
			//   __int128 v321; // xmm0
			//   __int128 v322; // xmm1
			//   __int128 v323; // xmm0
			//   OneofDescriptorProto *v324; // rdx
			//   FileDescriptor *v325; // r8
			//   MessageDescriptor *v326; // r9
			//   struct HGAutoExposureConfig__Class *v327; // rax
			//   HGAutoExposureConfig__StaticFields *v328; // rax
			//   int v329; // ecx
			//   __int128 v330; // xmm2
			//   __int128 v331; // xmm3
			//   __int64 v332; // xmm0_8
			//   struct HGShadowConfig__Class *v333; // rax
			//   HGShadowConfig__StaticFields *v334; // rax
			//   __int128 v335; // xmm2
			//   __int128 v336; // xmm3
			//   __int128 v337; // xmm4
			//   __int128 v338; // xmm5
			//   __int128 v339; // xmm6
			//   __int64 v340; // xmm0_8
			//   __int64 v341; // rdx
			//   struct HGAnamorphicStreaksConfig__Class *v342; // rax
			//   HGAnamorphicStreaksConfig__StaticFields *v343; // rax
			//   Color v344; // xmm1
			//   __int128 v345; // xmm2
			//   __int128 v346; // [rsp+20h] [rbp-1B8h] BYREF
			//   Color v347; // [rsp+30h] [rbp-1A8h]
			//   __int128 v348; // [rsp+40h] [rbp-198h]
			//   Color v349; // [rsp+50h] [rbp-188h]
			//   __int128 v350; // [rsp+60h] [rbp-178h]
			//   Color v351; // [rsp+70h] [rbp-168h]
			//   __int128 v352; // [rsp+80h] [rbp-158h]
			//   __int128 v353; // [rsp+90h] [rbp-148h]
			//   __int128 v354; // [rsp+A0h] [rbp-138h]
			//   __int128 v355; // [rsp+B0h] [rbp-128h]
			//   Color v356; // [rsp+C0h] [rbp-118h]
			//   __int128 v357; // [rsp+D0h] [rbp-108h]
			//   __int64 v358; // [rsp+E0h] [rbp-F8h]
			// 
			//   if ( !byte_18D8EDC48 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGAnamorphicStreaksConfig);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGAtmosphereConfig);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGAutoExposureConfig);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCelestialConfig);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCloudConfig);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGFogConfig);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGHeightFogConfig);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGInkSimulationConfig);
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
			//     byte_18D8EDC48 = 1;
			//   }
			//   v5 = TypeInfo::HG::Rendering::Runtime::HGLightConfig;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGLightConfig._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGLightConfig, method);
			//     v5 = TypeInfo::HG::Rendering::Runtime::HGLightConfig;
			//   }
			//   static_fields = (__int128 *)v5.static_fields;
			//   v7 = &v346;
			//   v8 = 2LL;
			//   v9 = 2LL;
			//   do
			//   {
			//     v7 += 8;
			//     v10 = *static_fields;
			//     v11 = static_fields[1];
			//     static_fields += 8;
			//     *(v7 - 8) = v10;
			//     v12 = *(static_fields - 6);
			//     *(v7 - 7) = v11;
			//     v13 = *(static_fields - 5);
			//     *(v7 - 6) = v12;
			//     v14 = *(static_fields - 4);
			//     *(v7 - 5) = v13;
			//     v15 = *(static_fields - 3);
			//     *(v7 - 4) = v14;
			//     v16 = *(static_fields - 2);
			//     *(v7 - 3) = v15;
			//     v17 = *(static_fields - 1);
			//     *(v7 - 2) = v16;
			//     *(v7 - 1) = v17;
			//     --v9;
			//   }
			//   while ( v9 );
			//   v18 = 2LL;
			//   v19 = static_fields[1];
			//   *v7 = *static_fields;
			//   v20 = static_fields[2];
			//   v7[1] = v19;
			//   v21 = static_fields[3];
			//   v7[2] = v20;
			//   v22 = static_fields[4];
			//   v7[3] = v21;
			//   v23 = static_fields[5];
			//   p_lightConfig = &this.fields.lightConfig;
			//   v7[4] = v22;
			//   v7[5] = v23;
			//   v25 = (Color *)&v346;
			//   do
			//   {
			//     p_lightConfig = (HGLightConfig *)((char *)p_lightConfig + 128);
			//     v26 = *v25;
			//     v27 = v25[1];
			//     v25 += 8;
			//     *(Color *)&p_lightConfig[-1].localToWorld.m12 = v26;
			//     v28 = v25[-6];
			//     *(Color *)&p_lightConfig[-1].localToWorld.m13 = v27;
			//     v29 = v25[-5];
			//     *(Color *)&p_lightConfig[-1].rotationAtmosphere.y = v28;
			//     v30 = v25[-4];
			//     *(Color *)&p_lightConfig[-1].rotationLightShaft.y = v29;
			//     v31 = v25[-3];
			//     *(Color *)&p_lightConfig[-1].rotationSunDisc.y = v30;
			//     v32 = v25[-2];
			//     *(Color *)&p_lightConfig[-1].rotationLensFlare.y = v31;
			//     v33 = v25[-1];
			//     *(Color *)&p_lightConfig[-1].rotationCloudShadow.y = v32;
			//     *(Color *)&p_lightConfig[-1].rotationHeightFogDirectionalInscattering.y = v33;
			//     --v18;
			//   }
			//   while ( v18 );
			//   v34 = v25[1];
			//   p_lightConfig.directColor = *v25;
			//   v35 = v25[2];
			//   *(Color *)&p_lightConfig.directColorMode = v34;
			//   v36 = v25[3];
			//   *(Color *)&p_lightConfig.directCustomColor.a = v35;
			//   v37 = v25[4];
			//   *(Color *)&p_lightConfig.directSpecularIntensity = v36;
			//   v38 = v25[5];
			//   *(Color *)&p_lightConfig.indirectDiffuseFactor = v37;
			//   *(Color *)&p_lightConfig.atmospherePitchYaw.x = v38;
			//   v39 = TypeInfo::HG::Rendering::Runtime::HGSkyConfig;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGSkyConfig._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGSkyConfig, 0LL);
			//     v39 = TypeInfo::HG::Rendering::Runtime::HGSkyConfig;
			//   }
			//   v40 = v39.static_fields;
			//   v41 = &v346;
			//   v42 = 2LL;
			//   do
			//   {
			//     v41 += 8;
			//     v43 = *(_OWORD *)&v40.defaultConfig.parentEnvPhaseGuid;
			//     v44 = *(_OWORD *)&v40.defaultConfig.skyDirectIntensity;
			//     v40 = (HGSkyConfig__StaticFields *)((char *)v40 + 128);
			//     *(v41 - 8) = v43;
			//     v45 = *(_OWORD *)&v40[-1].defaultConfig.skyAmbientSH.shr7;
			//     *(v41 - 7) = v44;
			//     v46 = *(_OWORD *)&v40[-1].defaultConfig.skyAmbientSH.shg2;
			//     *(v41 - 6) = v45;
			//     v47 = *(_OWORD *)&v40[-1].defaultConfig.skyAmbientSH.shg6;
			//     *(v41 - 5) = v46;
			//     v48 = *(_OWORD *)&v40[-1].defaultConfig.skyAmbientSH.shb1;
			//     *(v41 - 4) = v47;
			//     v49 = *(_OWORD *)&v40[-1].defaultConfig.skyAmbientSH.shb5;
			//     *(v41 - 3) = v48;
			//     v50 = *(_OWORD *)&v40[-1].defaultConfig.skyboxCubeMap;
			//     *(v41 - 2) = v49;
			//     *(v41 - 1) = v50;
			//     --v42;
			//   }
			//   while ( v42 );
			//   v51 = 2LL;
			//   v52 = *(_OWORD *)&v40.defaultConfig.skyDirectIntensity;
			//   *v41 = *(_OWORD *)&v40.defaultConfig.parentEnvPhaseGuid;
			//   v53 = *(_OWORD *)&v40.defaultConfig.customIVDefaultSH.shr2;
			//   v41[1] = v52;
			//   v54 = *(_OWORD *)&v40.defaultConfig.customIVDefaultSH.shr6;
			//   v41[2] = v53;
			//   v55 = *(_OWORD *)&v40.defaultConfig.customIVDefaultSH.shg1;
			//   v56 = *(_QWORD *)&v40.defaultConfig.customIVDefaultSH.shg5;
			//   v41[3] = v54;
			//   v41[4] = v55;
			//   *((_QWORD *)v41 + 10) = v56;
			//   p_skyConfig = &this.fields.skyConfig;
			//   v58 = &v346;
			//   do
			//   {
			//     p_skyConfig = (HGSkyConfig *)((char *)p_skyConfig + 128);
			//     v59 = *v58;
			//     v60 = v58[1];
			//     v58 += 8;
			//     *(_OWORD *)&p_skyConfig[-1].culloff = v59;
			//     v61 = *(v58 - 6);
			//     *(_OWORD *)&p_skyConfig[-1].skyAmbientSH.shr3 = v60;
			//     v62 = *(v58 - 5);
			//     *(_OWORD *)&p_skyConfig[-1].skyAmbientSH.shr7 = v61;
			//     v63 = *(v58 - 4);
			//     *(_OWORD *)&p_skyConfig[-1].skyAmbientSH.shg2 = v62;
			//     v64 = *(v58 - 3);
			//     *(_OWORD *)&p_skyConfig[-1].skyAmbientSH.shg6 = v63;
			//     v65 = *(v58 - 2);
			//     *(_OWORD *)&p_skyConfig[-1].skyAmbientSH.shb1 = v64;
			//     v66 = *(v58 - 1);
			//     *(_OWORD *)&p_skyConfig[-1].skyAmbientSH.shb5 = v65;
			//     *(_OWORD *)&p_skyConfig[-1].skyboxCubeMap = v66;
			//     --v51;
			//   }
			//   while ( v51 );
			//   v67 = v58[1];
			//   *(_OWORD *)&p_skyConfig.parentEnvPhaseGuid = *v58;
			//   v68 = v58[2];
			//   *(_OWORD *)&p_skyConfig.skyDirectIntensity = v67;
			//   v69 = v58[3];
			//   *(_OWORD *)&p_skyConfig.customIVDefaultSH.shr2 = v68;
			//   v70 = v58[4];
			//   v71 = *((_QWORD *)v58 + 10);
			//   *(_OWORD *)&p_skyConfig.customIVDefaultSH.shr6 = v69;
			//   *(_OWORD *)&p_skyConfig.customIVDefaultSH.shg1 = v70;
			//   *(_QWORD *)&p_skyConfig.customIVDefaultSH.shg5 = v71;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.skyConfig,
			//     0LL,
			//     v2,
			//     v3,
			//     (String__Array *)v346,
			//     *((String **)&v346 + 1),
			//     *(MethodInfo **)&v347.r);
			//   v75 = TypeInfo::HG::Rendering::Runtime::HGAtmosphereConfig;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGAtmosphereConfig._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGAtmosphereConfig, v72);
			//     v75 = TypeInfo::HG::Rendering::Runtime::HGAtmosphereConfig;
			//   }
			//   v76 = v75.static_fields;
			//   v77 = *(_OWORD *)&v76.defaultConfig.groundAlbedo.a;
			//   v78 = *(_OWORD *)&v76.defaultConfig.outerSunIrradianceColor.a;
			//   rayleighScattering = v76.defaultConfig.rayleighScattering;
			//   v80 = *(_OWORD *)&v76.defaultConfig.rayleighExponentialDistribution;
			//   v81 = *(_OWORD *)&v76.defaultConfig.mieScattering.b;
			//   v82 = *(_OWORD *)&v76.defaultConfig.mieAbsorption.g;
			//   v83 = *(_OWORD *)&v76.defaultConfig.mieExponentialDistribution;
			//   v84 = *(_OWORD *)&v76.defaultConfig.ozoneAbsorption.b;
			//   v85 = *(_QWORD *)&v76.defaultConfig.tentWidth;
			//   *(_OWORD *)&this.fields.atmosphereConfig.groundRadius = *(_OWORD *)&v76.defaultConfig.groundRadius;
			//   *(_OWORD *)&this.fields.atmosphereConfig.groundAlbedo.a = v77;
			//   *(_OWORD *)&this.fields.atmosphereConfig.outerSunIrradianceColor.a = v78;
			//   this.fields.atmosphereConfig.rayleighScattering = rayleighScattering;
			//   *(_OWORD *)&this.fields.atmosphereConfig.rayleighExponentialDistribution = v80;
			//   *(_OWORD *)&this.fields.atmosphereConfig.mieScattering.b = v81;
			//   *(_OWORD *)&this.fields.atmosphereConfig.mieAbsorption.g = v82;
			//   *(_OWORD *)&this.fields.atmosphereConfig.mieExponentialDistribution = v83;
			//   *(_OWORD *)&this.fields.atmosphereConfig.ozoneAbsorption.b = v84;
			//   *(_QWORD *)&this.fields.atmosphereConfig.tentWidth = v85;
			//   v86 = TypeInfo::HG::Rendering::Runtime::HGFogConfig;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGFogConfig._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGFogConfig, v72);
			//     v86 = TypeInfo::HG::Rendering::Runtime::HGFogConfig;
			//   }
			//   v87 = v86.static_fields;
			//   v88 = *(_DWORD *)&v87.defaultConfig.m_active;
			//   v89 = *(_OWORD *)&v87.defaultConfig.fallOffDistance;
			//   v90 = *(_OWORD *)&v87.defaultConfig.mieScattering.a;
			//   v91 = *(_OWORD *)&v87.defaultConfig.rayleighScattering.g;
			//   inscatterAmbientColor = v87.defaultConfig.inscatterAmbientColor;
			//   *(_OWORD *)&this.fields.fogConfig.enable = *(_OWORD *)&v87.defaultConfig.enable;
			//   *(_OWORD *)&this.fields.fogConfig.fallOffDistance = v89;
			//   *(_OWORD *)&this.fields.fogConfig.mieScattering.a = v90;
			//   *(_OWORD *)&this.fields.fogConfig.rayleighScattering.g = v91;
			//   this.fields.fogConfig.inscatterAmbientColor = inscatterAmbientColor;
			//   *(_DWORD *)&this.fields.fogConfig.m_active = v88;
			//   v93 = TypeInfo::HG::Rendering::Runtime::HGHeightFogConfig;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGHeightFogConfig._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGHeightFogConfig, v72);
			//     v93 = TypeInfo::HG::Rendering::Runtime::HGHeightFogConfig;
			//   }
			//   v94 = v93.static_fields;
			//   v95 = *(Color *)&v94.defaultConfig.heightFogStartHeightSecond;
			//   v346 = *(_OWORD *)&v94.defaultConfig.enable;
			//   v96 = *(_OWORD *)&v94.defaultConfig.heightFogInscatter.g;
			//   v347 = v95;
			//   v97 = *(Color *)&v94.defaultConfig.heightFogStartDistance;
			//   v348 = v96;
			//   v98 = *(_OWORD *)&v94.defaultConfig.heightFogCullingFarClipPlane;
			//   v349 = v97;
			//   v99 = *(Color *)&v94.defaultConfig.heightFogDirectionalInscattering.g;
			//   v350 = v98;
			//   v100 = *(_OWORD *)&v94.defaultConfig.volumetricFogScatteringDistribution;
			//   v351 = v99;
			//   v101 = *(_OWORD *)&v94.defaultConfig.volumetricFogAlbedo.a;
			//   v352 = v100;
			//   v102 = *(_OWORD *)&v94.defaultConfig.volumetricFogEmissive.a;
			//   v353 = v101;
			//   v103 = *(_OWORD *)&v94.defaultConfig.volumetricFogNearFadeInDistance;
			//   v354 = v102;
			//   v104 = *(Color *)&v94.defaultConfig.flowNoiseIntensity;
			//   v355 = v103;
			//   v105 = *(_OWORD *)&v94.defaultConfig.flowNoiseVerticalDirAngle;
			//   v106 = *(_QWORD *)&v94.defaultConfig.flowNoiseSpeed;
			//   v356 = v104;
			//   v357 = v105;
			//   v358 = v106;
			//   v107 = v347;
			//   *(_OWORD *)&this.fields.heightFogConfig.enable = v346;
			//   v108 = v348;
			//   *(Color *)&this.fields.heightFogConfig.heightFogStartHeightSecond = v107;
			//   v109 = v349;
			//   *(_OWORD *)&this.fields.heightFogConfig.heightFogInscatter.g = v108;
			//   v110 = v350;
			//   *(Color *)&this.fields.heightFogConfig.heightFogStartDistance = v109;
			//   v111 = v351;
			//   *(_OWORD *)&this.fields.heightFogConfig.heightFogCullingFarClipPlane = v110;
			//   v112 = v352;
			//   *(Color *)&this.fields.heightFogConfig.heightFogDirectionalInscattering.g = v111;
			//   v113 = v353;
			//   *(_OWORD *)&this.fields.heightFogConfig.volumetricFogScatteringDistribution = v112;
			//   v114 = v354;
			//   *(_OWORD *)&this.fields.heightFogConfig.volumetricFogAlbedo.a = v113;
			//   v115 = v355;
			//   *(_OWORD *)&this.fields.heightFogConfig.volumetricFogEmissive.a = v114;
			//   v116 = v356;
			//   *(_OWORD *)&this.fields.heightFogConfig.volumetricFogNearFadeInDistance = v115;
			//   v117 = v357;
			//   v118 = v358;
			//   *(Color *)&this.fields.heightFogConfig.flowNoiseIntensity = v116;
			//   *(_OWORD *)&this.fields.heightFogConfig.flowNoiseVerticalDirAngle = v117;
			//   *(_QWORD *)&this.fields.heightFogConfig.flowNoiseSpeed = v118;
			//   v119 = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig, v72);
			//     v119 = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig;
			//   }
			//   v120 = v119.static_fields;
			//   v121 = &v346;
			//   v122 = 2LL;
			//   do
			//   {
			//     v121 += 8;
			//     v123 = *(_OWORD *)&v120.defaultConfig.enable;
			//     v124 = *(_OWORD *)&v120.defaultConfig.heightFogStartHeightSecond;
			//     v120 = (HGVolumetricFogConfig__StaticFields *)((char *)v120 + 128);
			//     *(v121 - 8) = v123;
			//     v125 = *(_OWORD *)&v120[-1].defaultConfig.flowNoiseTilling;
			//     *(v121 - 7) = v124;
			//     v126 = *(_OWORD *)&v120[-1].defaultConfig.flowNoiseDir.y;
			//     *(v121 - 6) = v125;
			//     v127 = *(_OWORD *)&v120[-1].defaultConfig.flowVLNoiseIntensity;
			//     *(v121 - 5) = v126;
			//     v128 = *(_OWORD *)&v120[-1].defaultConfig.flowVLNoiseVerticalDirAngle;
			//     *(v121 - 4) = v127;
			//     v129 = *(_OWORD *)&v120[-1].defaultConfig.flowVLNoiseSpeed;
			//     *(v121 - 3) = v128;
			//     v130 = *(_OWORD *)&v120[-1].defaultConfig.m_backupVLNoiseHorizontalDirAngle;
			//     *(v121 - 2) = v129;
			//     *(v121 - 1) = v130;
			//     --v122;
			//   }
			//   while ( v122 );
			//   p_volumetricFogConfig = &this.fields.volumetricFogConfig;
			//   v132 = 2LL;
			//   v133 = &v346;
			//   do
			//   {
			//     p_volumetricFogConfig = (HGVolumetricFogConfig *)((char *)p_volumetricFogConfig + 128);
			//     v134 = *v133;
			//     v135 = v133[1];
			//     v133 += 8;
			//     *(_OWORD *)&p_volumetricFogConfig[-1].volumetricFogDistance = v134;
			//     v136 = *(v133 - 6);
			//     *(_OWORD *)&p_volumetricFogConfig[-1].volumetricFogSkyLightingScatteringIntensity = v135;
			//     v137 = *(v133 - 5);
			//     *(_OWORD *)&p_volumetricFogConfig[-1].flowNoiseTilling = v136;
			//     v138 = *(v133 - 4);
			//     *(_OWORD *)&p_volumetricFogConfig[-1].flowNoiseDir.y = v137;
			//     v139 = *(v133 - 3);
			//     *(_OWORD *)&p_volumetricFogConfig[-1].flowVLNoiseIntensity = v138;
			//     v140 = *(v133 - 2);
			//     *(_OWORD *)&p_volumetricFogConfig[-1].flowVLNoiseVerticalDirAngle = v139;
			//     v141 = *(v133 - 1);
			//     *(_OWORD *)&p_volumetricFogConfig[-1].flowVLNoiseSpeed = v140;
			//     *(_OWORD *)&p_volumetricFogConfig[-1].m_backupVLNoiseHorizontalDirAngle = v141;
			//     --v132;
			//   }
			//   while ( v132 );
			//   v142 = TypeInfo::HG::Rendering::Runtime::HGCloudConfig;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGCloudConfig._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCloudConfig, 0LL);
			//     v142 = TypeInfo::HG::Rendering::Runtime::HGCloudConfig;
			//   }
			//   v143 = v142.static_fields;
			//   cloudTint = v143.defaultConfig.cloudTint;
			//   v346 = *(_OWORD *)&v143.defaultConfig.enable;
			//   v145 = *(_OWORD *)&v143.defaultConfig.cloudContrast;
			//   v347 = cloudTint;
			//   v146 = *(Color *)&v143.defaultConfig.brightnessAffectCloudAlpha;
			//   v348 = v145;
			//   v147 = *(_OWORD *)&v143.defaultConfig.cloudFlowType;
			//   v349 = v146;
			//   v148 = *(Color *)&v143.defaultConfig.flowSpeed;
			//   v350 = v147;
			//   v149 = *(_OWORD *)&v143.defaultConfig.lightShaftCloudMaskTexture;
			//   v351 = v148;
			//   v150 = *(_OWORD *)&v143.defaultConfig.cloudShadowConfig.cloudShadowTexture;
			//   v352 = v149;
			//   v151 = *(_OWORD *)&v143.defaultConfig.cloudShadowConfig.cloudShadowEnvCenter.z;
			//   v353 = v150;
			//   v152 = *(_OWORD *)&v143.defaultConfig.cloudShadowConfig.cloudShadowFlowDirection.y;
			//   v354 = v151;
			//   v153 = *(Color *)&v143.defaultConfig.cloudShadowConfig.cloudShadowScaleEndDistance;
			//   v355 = v152;
			//   v356 = v153;
			//   v154 = v347;
			//   *(_OWORD *)&this.fields.cloudConfig.enable = v346;
			//   v155 = v348;
			//   this.fields.cloudConfig.cloudTint = v154;
			//   v156 = v349;
			//   *(_OWORD *)&this.fields.cloudConfig.cloudContrast = v155;
			//   v157 = v350;
			//   *(Color *)&this.fields.cloudConfig.brightnessAffectCloudAlpha = v156;
			//   v158 = v351;
			//   *(_OWORD *)&this.fields.cloudConfig.cloudFlowType = v157;
			//   v159 = v352;
			//   *(Color *)&this.fields.cloudConfig.flowSpeed = v158;
			//   v160 = v353;
			//   *(_OWORD *)&this.fields.cloudConfig.lightShaftCloudMaskTexture = v159;
			//   v161 = v354;
			//   *(_OWORD *)&this.fields.cloudConfig.cloudShadowConfig.cloudShadowTexture = v160;
			//   v162 = v355;
			//   *(_OWORD *)&this.fields.cloudConfig.cloudShadowConfig.cloudShadowEnvCenter.z = v161;
			//   v163 = v356;
			//   *(_OWORD *)&this.fields.cloudConfig.cloudShadowConfig.cloudShadowFlowDirection.y = v162;
			//   *(Color *)&this.fields.cloudConfig.cloudShadowConfig.cloudShadowScaleEndDistance = v163;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.cloudConfig.cloudTexture,
			//     (OneofDescriptorProto *)v132,
			//     v73,
			//     v74,
			//     (String__Array *)v346,
			//     *((String **)&v346 + 1),
			//     *(MethodInfo **)&v347.r);
			//   v167 = TypeInfo::HG::Rendering::Runtime::HGCelestialConfig;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGCelestialConfig._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCelestialConfig, v164);
			//     v167 = TypeInfo::HG::Rendering::Runtime::HGCelestialConfig;
			//   }
			//   v168 = v167.static_fields;
			//   v169 = &v346;
			//   v170 = 2LL;
			//   do
			//   {
			//     v169 += 8;
			//     v171 = *(_OWORD *)&v168.defaultConfig.moonConfig.radius;
			//     v172 = *(_OWORD *)&v168.defaultConfig.moonConfig.worldLongitude;
			//     v168 = (HGCelestialConfig__StaticFields *)((char *)v168 + 128);
			//     *(v169 - 8) = v171;
			//     v173 = *(_OWORD *)&v168[-1].defaultConfig.planetConfig.ring.outerRadius;
			//     *(v169 - 7) = v172;
			//     v174 = *(_OWORD *)&v168[-1].defaultConfig.planetConfig.ring.ringColor.b;
			//     *(v169 - 6) = v173;
			//     v175 = *(_OWORD *)&v168[-1].defaultConfig.planetConfig.enableAtmosphere;
			//     *(v169 - 5) = v174;
			//     v176 = *(_OWORD *)&v168[-1].defaultConfig.planetConfig.atmosphere.numOpticalDepthSamplePoints;
			//     *(v169 - 4) = v175;
			//     v177 = *(_OWORD *)&v168[-1].defaultConfig.planetConfig.atmosphere.atmosphereHueshift;
			//     *(v169 - 3) = v176;
			//     v178 = *(_OWORD *)&v168[-1].defaultConfig.advancedPlanetConfig.advancedPlanetMat;
			//     *(v169 - 2) = v177;
			//     *(v169 - 1) = v178;
			//     --v170;
			//   }
			//   while ( v170 );
			//   v179 = 2LL;
			//   v180 = *(_OWORD *)&v168.defaultConfig.moonConfig.worldLongitude;
			//   *v169 = *(_OWORD *)&v168.defaultConfig.moonConfig.radius;
			//   v181 = *(_OWORD *)&v168.defaultConfig.moonConfig.ring.outerRadius;
			//   v169[1] = v180;
			//   v182 = *(_OWORD *)&v168.defaultConfig.moonConfig.ring.ringColor.b;
			//   v169[2] = v181;
			//   v183 = *(_OWORD *)&v168.defaultConfig.talosAlphaConfig.drawPlanetInSkydome;
			//   v169[3] = v182;
			//   v184 = *(_OWORD *)&v168.defaultConfig.talosAlphaConfig.objectProperty.selfTiltZ;
			//   drawMaterial = v168.defaultConfig.talosAlphaConfig.skydomeDrawer.drawMaterial;
			//   v169[4] = v183;
			//   v169[5] = v184;
			//   *((_QWORD *)v169 + 12) = drawMaterial;
			//   p_celestialConfig = &this.fields.celestialConfig;
			//   v187 = &v346;
			//   do
			//   {
			//     p_celestialConfig = (HGCelestialConfig *)((char *)p_celestialConfig + 128);
			//     v188 = *v187;
			//     v189 = v187[1];
			//     v187 += 8;
			//     *(_OWORD *)&p_celestialConfig[-1].planetConfig.skydomeDrawer.drawMaterial = v188;
			//     v190 = *(v187 - 6);
			//     *(_OWORD *)&p_celestialConfig[-1].planetConfig.skydomeDrawer.incidentLightingPitchYaw.x = v189;
			//     v191 = *(v187 - 5);
			//     *(_OWORD *)&p_celestialConfig[-1].planetConfig.ring.outerRadius = v190;
			//     v192 = *(v187 - 4);
			//     *(_OWORD *)&p_celestialConfig[-1].planetConfig.ring.ringColor.b = v191;
			//     v193 = *(v187 - 3);
			//     *(_OWORD *)&p_celestialConfig[-1].planetConfig.enableAtmosphere = v192;
			//     v194 = *(v187 - 2);
			//     *(_OWORD *)&p_celestialConfig[-1].planetConfig.atmosphere.numOpticalDepthSamplePoints = v193;
			//     v195 = *(v187 - 1);
			//     *(_OWORD *)&p_celestialConfig[-1].planetConfig.atmosphere.atmosphereHueshift = v194;
			//     *(_OWORD *)&p_celestialConfig[-1].advancedPlanetConfig.advancedPlanetMat = v195;
			//     --v179;
			//   }
			//   while ( v179 );
			//   v196 = v187[1];
			//   *(_OWORD *)&p_celestialConfig.moonConfig.radius = *v187;
			//   v197 = v187[2];
			//   *(_OWORD *)&p_celestialConfig.moonConfig.worldLongitude = v196;
			//   v198 = v187[3];
			//   *(_OWORD *)&p_celestialConfig.moonConfig.ring.outerRadius = v197;
			//   v199 = v187[4];
			//   *(_OWORD *)&p_celestialConfig.moonConfig.ring.ringColor.b = v198;
			//   v200 = v187[5];
			//   v201 = (Material *)*((_QWORD *)v187 + 12);
			//   *(_OWORD *)&p_celestialConfig.talosAlphaConfig.drawPlanetInSkydome = v199;
			//   *(_OWORD *)&p_celestialConfig.talosAlphaConfig.objectProperty.selfTiltZ = v200;
			//   p_celestialConfig.talosAlphaConfig.skydomeDrawer.drawMaterial = v201;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.celestialConfig.moonConfig.ring.planetRingMap,
			//     0LL,
			//     v165,
			//     v166,
			//     (String__Array *)v346,
			//     *((String **)&v346 + 1),
			//     *(MethodInfo **)&v347.r);
			//   v205 = TypeInfo::HG::Rendering::Runtime::HGWindConfig;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGWindConfig._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGWindConfig, v202);
			//     v205 = TypeInfo::HG::Rendering::Runtime::HGWindConfig;
			//   }
			//   v206 = v205.static_fields;
			//   v207 = *(_DWORD *)&v206.defaultConfig.m_active;
			//   v208 = *(_QWORD *)&v206.defaultConfig.direction.y;
			//   *(_OWORD *)&this.fields.windConfig.speed = *(_OWORD *)&v206.defaultConfig.speed;
			//   *(_QWORD *)&this.fields.windConfig.direction.y = v208;
			//   *(_DWORD *)&this.fields.windConfig.m_active = v207;
			//   v209 = TypeInfo::HG::Rendering::Runtime::HGLightShaftConfig;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGLightShaftConfig._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGLightShaftConfig, v202);
			//     v209 = TypeInfo::HG::Rendering::Runtime::HGLightShaftConfig;
			//   }
			//   v210 = v209.static_fields;
			//   v211 = *(_DWORD *)&v210.defaultConfig.m_active;
			//   bloomTint = v210.defaultConfig.bloomTint;
			//   v213 = *(_OWORD *)&v210.defaultConfig.blurIntensity;
			//   *(_OWORD *)&this.fields.lightShaftConfig.enable = *(_OWORD *)&v210.defaultConfig.enable;
			//   this.fields.lightShaftConfig.bloomTint = bloomTint;
			//   *(_OWORD *)&this.fields.lightShaftConfig.blurIntensity = v213;
			//   *(_DWORD *)&this.fields.lightShaftConfig.m_active = v211;
			//   v214 = TypeInfo::HG::Rendering::Runtime::HGTerrainDeformConfig;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGTerrainDeformConfig._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGTerrainDeformConfig, v202);
			//     v214 = TypeInfo::HG::Rendering::Runtime::HGTerrainDeformConfig;
			//   }
			//   v215 = v214.static_fields;
			//   v216 = *(_DWORD *)&v215.defaultConfig.m_active;
			//   *(_QWORD *)&this.fields.terrainDeformConfig.deformGlobalStrength = *(_QWORD *)&v215.defaultConfig.deformGlobalStrength;
			//   *(_DWORD *)&this.fields.terrainDeformConfig.m_active = v216;
			//   v217 = TypeInfo::HG::Rendering::Runtime::HGInkSimulationConfig;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGInkSimulationConfig._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGInkSimulationConfig, v202);
			//     v217 = TypeInfo::HG::Rendering::Runtime::HGInkSimulationConfig;
			//   }
			//   v218 = v217.static_fields;
			//   v219 = *(_QWORD *)&v218.defaultConfig.m_active;
			//   *(_OWORD *)&this.fields.inkSimulationConfig.influence = *(_OWORD *)&v218.defaultConfig.influence;
			//   *(_QWORD *)&this.fields.inkSimulationConfig.m_active = v219;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.inkSimulationConfig.material,
			//     v202,
			//     v203,
			//     v204,
			//     (String__Array *)v346,
			//     *((String **)&v346 + 1),
			//     *(MethodInfo **)&v347.r);
			//   v223 = TypeInfo::HG::Rendering::Runtime::HGRainConfig;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGRainConfig._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRainConfig, v220);
			//     v223 = TypeInfo::HG::Rendering::Runtime::HGRainConfig;
			//   }
			//   v224 = v223.static_fields;
			//   v225 = &v346;
			//   v226 = 2LL;
			//   do
			//   {
			//     v225 += 8;
			//     v227 = *(_OWORD *)&v224.defaultConfig.enable;
			//     v228 = *(_OWORD *)&v224.defaultConfig.color.g;
			//     v224 = (HGRainConfig__StaticFields *)((char *)v224 + 128);
			//     *(v225 - 8) = v227;
			//     v229 = *(_OWORD *)&v224[-1].defaultConfig.baseWetnessLevel;
			//     *(v225 - 7) = v228;
			//     v230 = *(_OWORD *)&v224[-1].defaultConfig.verticalFlowSurfaceThreshold;
			//     *(v225 - 6) = v229;
			//     v231 = *(_OWORD *)&v224[-1].defaultConfig.rippleWaveSpeed;
			//     *(v225 - 5) = v230;
			//     v232 = *(_OWORD *)&v224[-1].defaultConfig.farSceneWetnessValue;
			//     *(v225 - 4) = v231;
			//     v233 = *(_OWORD *)&v224[-1].defaultConfig.rainDirection.z;
			//     *(v225 - 3) = v232;
			//     v234 = *(_OWORD *)&v224[-1].defaultConfig.farRainDirection.x;
			//     *(v225 - 2) = v233;
			//     *(v225 - 1) = v234;
			//     --v226;
			//   }
			//   while ( v226 );
			//   v235 = 2LL;
			//   v236 = *(_OWORD *)&v224.defaultConfig.color.g;
			//   *v225 = *(_OWORD *)&v224.defaultConfig.enable;
			//   v237 = *(_OWORD *)&v224.defaultConfig.horizontalRainAngle;
			//   p_rainConfig = &this.fields.rainConfig;
			//   v225[1] = v236;
			//   v225[2] = v237;
			//   v239 = &v346;
			//   do
			//   {
			//     p_rainConfig = (HGRainConfig *)((char *)p_rainConfig + 128);
			//     v240 = *v239;
			//     v241 = v239[1];
			//     v239 += 8;
			//     *(_OWORD *)&p_rainConfig[-1].rainSplashAlpha = v240;
			//     v242 = *(v239 - 6);
			//     *(_OWORD *)&p_rainConfig[-1].enableWetness = v241;
			//     v243 = *(v239 - 5);
			//     *(_OWORD *)&p_rainConfig[-1].baseWetnessLevel = v242;
			//     v244 = *(v239 - 4);
			//     *(_OWORD *)&p_rainConfig[-1].verticalFlowSurfaceThreshold = v243;
			//     v245 = *(v239 - 3);
			//     *(_OWORD *)&p_rainConfig[-1].rippleWaveSpeed = v244;
			//     v246 = *(v239 - 2);
			//     *(_OWORD *)&p_rainConfig[-1].farSceneWetnessValue = v245;
			//     v247 = *(v239 - 1);
			//     *(_OWORD *)&p_rainConfig[-1].rainDirection.z = v246;
			//     *(_OWORD *)&p_rainConfig[-1].farRainDirection.x = v247;
			//     --v235;
			//   }
			//   while ( v235 );
			//   v248 = v239[1];
			//   *(_OWORD *)&p_rainConfig.enable = *v239;
			//   v249 = v239[2];
			//   *(_OWORD *)&p_rainConfig.color.g = v248;
			//   *(_OWORD *)&p_rainConfig.horizontalRainAngle = v249;
			//   v250 = TypeInfo::HG::Rendering::Runtime::HGSnowConfig;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGSnowConfig._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGSnowConfig, 0LL);
			//     v250 = TypeInfo::HG::Rendering::Runtime::HGSnowConfig;
			//   }
			//   v251 = v250.static_fields;
			//   v252 = *(_OWORD *)&v251.defaultConfig.color.g;
			//   v253 = *(_OWORD *)&v251.defaultConfig.snowSizeRange.y;
			//   v254 = *(_OWORD *)&v251.defaultConfig.snowLightingPercent;
			//   v255 = *(_QWORD *)&v251.defaultConfig.snowDirection.z;
			//   *(_OWORD *)&this.fields.snowConfig.enable = *(_OWORD *)&v251.defaultConfig.enable;
			//   *(_OWORD *)&this.fields.snowConfig.color.g = v252;
			//   *(_OWORD *)&this.fields.snowConfig.snowSizeRange.y = v253;
			//   *(_OWORD *)&this.fields.snowConfig.snowLightingPercent = v254;
			//   *(_QWORD *)&this.fields.snowConfig.snowDirection.z = v255;
			//   v256 = TypeInfo::HG::Rendering::Runtime::HGStarConfig;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGStarConfig._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGStarConfig, v235);
			//     v256 = TypeInfo::HG::Rendering::Runtime::HGStarConfig;
			//   }
			//   v257 = v256.static_fields;
			//   starsTint = v257.defaultConfig.starsTint;
			//   v346 = *(_OWORD *)&v257.defaultConfig.enableStars;
			//   v259 = *(_OWORD *)&v257.defaultConfig.starsOffset0;
			//   v347 = starsTint;
			//   starsTint1 = v257.defaultConfig.starsTint1;
			//   v348 = v259;
			//   v261 = *(_OWORD *)&v257.defaultConfig.starsOffset1;
			//   v349 = starsTint1;
			//   starsTint2 = v257.defaultConfig.starsTint2;
			//   v350 = v261;
			//   v263 = *(_OWORD *)&v257.defaultConfig.starsOffset2;
			//   v351 = starsTint2;
			//   v264 = *(_OWORD *)&v257.defaultConfig.starLayerViewMode;
			//   v352 = v263;
			//   v265 = *(_OWORD *)&v257.defaultConfig.skyBoxStarRangeMap;
			//   v353 = v264;
			//   v266 = *(_OWORD *)&v257.defaultConfig.enableNebula;
			//   v354 = v265;
			//   nebulaTint = v257.defaultConfig.nebulaTint;
			//   v355 = v266;
			//   v268 = *(_OWORD *)&v257.defaultConfig.nebulaMapRotation;
			//   v356 = nebulaTint;
			//   v357 = v268;
			//   v269 = v347;
			//   *(_OWORD *)&this.fields.starConfig.enableStars = v346;
			//   v270 = v348;
			//   this.fields.starConfig.starsTint = v269;
			//   v271 = v349;
			//   *(_OWORD *)&this.fields.starConfig.starsOffset0 = v270;
			//   v272 = v350;
			//   this.fields.starConfig.starsTint1 = v271;
			//   v273 = v351;
			//   *(_OWORD *)&this.fields.starConfig.starsOffset1 = v272;
			//   v274 = v352;
			//   this.fields.starConfig.starsTint2 = v273;
			//   v275 = v353;
			//   *(_OWORD *)&this.fields.starConfig.starsOffset2 = v274;
			//   v276 = v354;
			//   *(_OWORD *)&this.fields.starConfig.starLayerViewMode = v275;
			//   v277 = v355;
			//   *(_OWORD *)&this.fields.starConfig.skyBoxStarRangeMap = v276;
			//   v278 = v356;
			//   *(_OWORD *)&this.fields.starConfig.enableNebula = v277;
			//   v279 = v357;
			//   this.fields.starConfig.nebulaTint = v278;
			//   *(_OWORD *)&this.fields.starConfig.nebulaMapRotation = v279;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.starConfig.skyboxStarNoiseMap,
			//     (OneofDescriptorProto *)v235,
			//     v221,
			//     v222,
			//     (String__Array *)v346,
			//     *((String **)&v346 + 1),
			//     *(MethodInfo **)&v347.r);
			//   v283 = TypeInfo::HG::Rendering::Runtime::HGLensFlareConfig;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGLensFlareConfig._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGLensFlareConfig, v280);
			//     v283 = TypeInfo::HG::Rendering::Runtime::HGLensFlareConfig;
			//   }
			//   v284 = v283.static_fields;
			//   v285 = *(_OWORD *)&v284.defaultConfig.intensity;
			//   v286 = *(_OWORD *)&v284.defaultConfig.sampleCount;
			//   *(_OWORD *)&this.fields.lensFlareConfig.enable = *(_OWORD *)&v284.defaultConfig.enable;
			//   *(_OWORD *)&this.fields.lensFlareConfig.intensity = v285;
			//   *(_OWORD *)&this.fields.lensFlareConfig.sampleCount = v286;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.lensFlareConfig.lensFlareData,
			//     v280,
			//     v281,
			//     v282,
			//     (String__Array *)v346,
			//     *((String **)&v346 + 1),
			//     *(MethodInfo **)&v347.r);
			//   v290 = TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig, v287);
			//     v290 = TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig;
			//   }
			//   v291 = &v346;
			//   p_defaultConfig = &v290.static_fields.defaultConfig;
			//   v293 = 2LL;
			//   do
			//   {
			//     v291 += 8;
			//     v294 = *(_OWORD *)&p_defaultConfig.tonemappingMode;
			//     v295 = *(_OWORD *)&p_defaultConfig.colorLookupContribution;
			//     p_defaultConfig = (HGColorGradingConfig *)((char *)p_defaultConfig + 128);
			//     *(v291 - 8) = v294;
			//     v296 = *(_OWORD *)&p_defaultConfig[-1].splitToningHighlights.a;
			//     *(v291 - 7) = v295;
			//     v297 = *(_OWORD *)&p_defaultConfig[-1].colorCurves.master;
			//     *(v291 - 6) = v296;
			//     v298 = *(_OWORD *)&p_defaultConfig[-1].colorCurves.green;
			//     *(v291 - 5) = v297;
			//     v299 = *(_OWORD *)&p_defaultConfig[-1].colorCurves.hueVsHue;
			//     *(v291 - 4) = v298;
			//     v300 = *(_OWORD *)&p_defaultConfig[-1].colorCurves.satVsSat;
			//     *(v291 - 3) = v299;
			//     v301 = *(_OWORD *)&p_defaultConfig[-1].colorCurves.masterOverriding;
			//     *(v291 - 2) = v300;
			//     *(v291 - 1) = v301;
			//     --v293;
			//   }
			//   while ( v293 );
			//   v302 = *(_OWORD *)&p_defaultConfig.colorLookupContribution;
			//   *v291 = *(_OWORD *)&p_defaultConfig.tonemappingMode;
			//   v303 = *(_OWORD *)&p_defaultConfig.colorAdjustmentsEnabled;
			//   v291[1] = v302;
			//   v304 = *(_OWORD *)&p_defaultConfig.colorAdjustmentsColorFilter.g;
			//   v291[2] = v303;
			//   v305 = *(_OWORD *)&p_defaultConfig.colorAdjustmentsSaturation;
			//   v291[3] = v304;
			//   v306 = *(_OWORD *)&p_defaultConfig.channelMixerRedOutBlueIn;
			//   v291[4] = v305;
			//   v307 = *(_OWORD *)&p_defaultConfig.channelMixerBlueOutRedIn;
			//   p_colorGradingConfig = &this.fields.colorGradingConfig;
			//   v291[5] = v306;
			//   v291[6] = v307;
			//   v309 = &v346;
			//   do
			//   {
			//     p_colorGradingConfig = (HGColorGradingConfig *)((char *)p_colorGradingConfig + 128);
			//     v310 = *v309;
			//     v311 = v309[1];
			//     v309 += 8;
			//     *(_OWORD *)&p_colorGradingConfig[-1].splitToningEnabled = v310;
			//     v312 = *(v309 - 6);
			//     *(_OWORD *)&p_colorGradingConfig[-1].splitToningShadows.a = v311;
			//     v313 = *(v309 - 5);
			//     *(_OWORD *)&p_colorGradingConfig[-1].splitToningHighlights.a = v312;
			//     v314 = *(v309 - 4);
			//     *(_OWORD *)&p_colorGradingConfig[-1].colorCurves.master = v313;
			//     v315 = *(v309 - 3);
			//     *(_OWORD *)&p_colorGradingConfig[-1].colorCurves.green = v314;
			//     v316 = *(v309 - 2);
			//     *(_OWORD *)&p_colorGradingConfig[-1].colorCurves.hueVsHue = v315;
			//     v317 = *(v309 - 1);
			//     *(_OWORD *)&p_colorGradingConfig[-1].colorCurves.satVsSat = v316;
			//     *(_OWORD *)&p_colorGradingConfig[-1].colorCurves.masterOverriding = v317;
			//     --v8;
			//   }
			//   while ( v8 );
			//   v318 = v309[1];
			//   *(_OWORD *)&p_colorGradingConfig.tonemappingMode = *v309;
			//   v319 = v309[2];
			//   *(_OWORD *)&p_colorGradingConfig.colorLookupContribution = v318;
			//   v320 = v309[3];
			//   *(_OWORD *)&p_colorGradingConfig.colorAdjustmentsEnabled = v319;
			//   v321 = v309[4];
			//   *(_OWORD *)&p_colorGradingConfig.colorAdjustmentsColorFilter.g = v320;
			//   v322 = v309[5];
			//   *(_OWORD *)&p_colorGradingConfig.colorAdjustmentsSaturation = v321;
			//   v323 = v309[6];
			//   *(_OWORD *)&p_colorGradingConfig.channelMixerRedOutBlueIn = v322;
			//   *(_OWORD *)&p_colorGradingConfig.channelMixerBlueOutRedIn = v323;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.colorGradingConfig.colorLookupTexture,
			//     0LL,
			//     v288,
			//     v289,
			//     (String__Array *)v346,
			//     *((String **)&v346 + 1),
			//     *(MethodInfo **)&v347.r);
			//   v327 = TypeInfo::HG::Rendering::Runtime::HGAutoExposureConfig;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGAutoExposureConfig._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGAutoExposureConfig, v324);
			//     v327 = TypeInfo::HG::Rendering::Runtime::HGAutoExposureConfig;
			//   }
			//   v328 = v327.static_fields;
			//   v329 = *(_DWORD *)&v328.defaultConfig.m_active;
			//   v330 = *(_OWORD *)&v328.defaultConfig.autoExposureEv100Range.x;
			//   v331 = *(_OWORD *)&v328.defaultConfig.autoExposureMeteringMode;
			//   v332 = *(_QWORD *)&v328.defaultConfig.autoExposureEvClampRange.y;
			//   *(_OWORD *)&this.fields.autoExposureConfig.autoExposureMode = *(_OWORD *)&v328.defaultConfig.autoExposureMode;
			//   *(_OWORD *)&this.fields.autoExposureConfig.autoExposureEv100Range.x = v330;
			//   *(_OWORD *)&this.fields.autoExposureConfig.autoExposureMeteringMode = v331;
			//   *(_QWORD *)&this.fields.autoExposureConfig.autoExposureEvClampRange.y = v332;
			//   *(_DWORD *)&this.fields.autoExposureConfig.m_active = v329;
			//   v333 = TypeInfo::HG::Rendering::Runtime::HGShadowConfig;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGShadowConfig._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGShadowConfig, v324);
			//     v333 = TypeInfo::HG::Rendering::Runtime::HGShadowConfig;
			//   }
			//   v334 = v333.static_fields;
			//   v335 = *(_OWORD *)&v334.defaultConfig.csmIntensity;
			//   v336 = *(_OWORD *)&v334.defaultConfig.csmShadowSoftness;
			//   v337 = *(_OWORD *)&v334.defaultConfig.contactShadowSurfaceThickness;
			//   v338 = *(_OWORD *)&v334.defaultConfig.overrideCsmFarDistance;
			//   v339 = *(_OWORD *)&v334.defaultConfig.overrideCsmSpherePosition.z;
			//   v340 = *(_QWORD *)&v334.defaultConfig.csmSimulatedAttenuation;
			//   *(_OWORD *)&this.fields.shadowConfig.csmDepthBias = *(_OWORD *)&v334.defaultConfig.csmDepthBias;
			//   *(_OWORD *)&this.fields.shadowConfig.csmIntensity = v335;
			//   *(_OWORD *)&this.fields.shadowConfig.csmShadowSoftness = v336;
			//   *(_OWORD *)&this.fields.shadowConfig.contactShadowSurfaceThickness = v337;
			//   *(_OWORD *)&this.fields.shadowConfig.overrideCsmFarDistance = v338;
			//   *(_OWORD *)&this.fields.shadowConfig.overrideCsmSpherePosition.z = v339;
			//   *(_QWORD *)&this.fields.shadowConfig.csmSimulatedAttenuation = v340;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.shadowConfig.csmRampTexture,
			//     v324,
			//     v325,
			//     v326,
			//     (String__Array *)v346,
			//     *((String **)&v346 + 1),
			//     *(MethodInfo **)&v347.r);
			//   v342 = TypeInfo::HG::Rendering::Runtime::HGAnamorphicStreaksConfig;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGAnamorphicStreaksConfig._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGAnamorphicStreaksConfig, v341);
			//     v342 = TypeInfo::HG::Rendering::Runtime::HGAnamorphicStreaksConfig;
			//   }
			//   v343 = v342.static_fields;
			//   v344 = v343.defaultConfig.bloomTint;
			//   v345 = *(_OWORD *)&v343.defaultConfig.blurIntensity;
			//   *(_OWORD *)&this.fields.anamorphicStreaksConfig.enable = *(_OWORD *)&v343.defaultConfig.enable;
			//   this.fields.anamorphicStreaksConfig.bloomTint = v344;
			//   *(_OWORD *)&this.fields.anamorphicStreaksConfig.blurIntensity = v345;
			//   UnityEngine::ScriptableObject::ScriptableObject((ScriptableObject *)this, 0LL);
			// }
			// 
		}

		public void Initialize()
		{
			// // Void Initialize()
			// void HG::Rendering::Runtime::HGEnvironmentPhase::Initialize(HGEnvironmentPhase *this, MethodInfo *method)
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
			//   HGInkSimulationConfig__StaticFields *v202; // rcx
			//   OneofDescriptorProto *v203; // rdx
			//   FileDescriptor *v204; // r8
			//   MessageDescriptor *v205; // r9
			//   __int64 v206; // rdx
			//   HGRainConfig__StaticFields *v207; // rcx
			//   __int128 *v208; // rax
			//   __int128 v209; // xmm1
			//   __int128 v210; // xmm0
			//   __int128 v211; // xmm1
			//   __int128 v212; // xmm0
			//   __int128 v213; // xmm1
			//   __int128 v214; // xmm0
			//   __int128 v215; // xmm1
			//   __int64 v216; // rdx
			//   __int128 v217; // xmm1
			//   __int128 v218; // xmm0
			//   __int128 *v219; // rcx
			//   HGRainConfig *p_rainConfig; // rax
			//   __int128 v221; // xmm1
			//   __int128 v222; // xmm0
			//   __int128 v223; // xmm1
			//   __int128 v224; // xmm0
			//   __int128 v225; // xmm1
			//   __int128 v226; // xmm0
			//   __int128 v227; // xmm1
			//   __int128 v228; // xmm1
			//   __int128 v229; // xmm0
			//   HGSnowConfig__StaticFields *v230; // rcx
			//   __int128 v231; // xmm2
			//   __int128 v232; // xmm3
			//   __int128 v233; // xmm4
			//   HGStarConfig__StaticFields *v234; // rcx
			//   Color starsTint; // xmm1
			//   __int128 v236; // xmm0
			//   Color starsTint1; // xmm1
			//   __int128 v238; // xmm0
			//   Color starsTint2; // xmm1
			//   __int128 v240; // xmm0
			//   __int128 v241; // xmm1
			//   __int128 v242; // xmm0
			//   Color v243; // xmm1
			//   Color v244; // xmm0
			//   Color v245; // xmm1
			//   Color v246; // xmm1
			//   __int128 v247; // xmm0
			//   Color v248; // xmm1
			//   __int128 v249; // xmm0
			//   Color v250; // xmm1
			//   __int128 v251; // xmm0
			//   __int128 v252; // xmm1
			//   __int128 v253; // xmm0
			//   Color v254; // xmm1
			//   Color v255; // xmm0
			//   Color v256; // xmm1
			//   OneofDescriptorProto *v257; // rdx
			//   FileDescriptor *v258; // r8
			//   MessageDescriptor *v259; // r9
			//   HGLensFlareConfig__StaticFields *v260; // rcx
			//   __int128 v261; // xmm1
			//   __int128 v262; // xmm2
			//   OneofDescriptorProto *v263; // rdx
			//   FileDescriptor *v264; // r8
			//   MessageDescriptor *v265; // r9
			//   FileDescriptor *v266; // r8
			//   MessageDescriptor *v267; // r9
			//   __int64 v268; // rdx
			//   __int128 *v269; // rax
			//   HGColorGradingConfig *p_defaultConfig; // rcx
			//   __int128 v271; // xmm1
			//   __int128 v272; // xmm0
			//   __int128 v273; // xmm1
			//   __int128 v274; // xmm0
			//   __int128 v275; // xmm1
			//   __int128 v276; // xmm0
			//   Vector4 shadows; // xmm1
			//   __int128 v278; // xmm1
			//   __int128 v279; // xmm0
			//   __int128 v280; // xmm1
			//   __int128 v281; // xmm0
			//   __int128 v282; // xmm1
			//   __int128 v283; // xmm0
			//   __int128 *v284; // rcx
			//   HGColorGradingConfig *p_colorGradingConfig; // rax
			//   __int128 v286; // xmm1
			//   __int128 v287; // xmm0
			//   __int128 v288; // xmm1
			//   __int128 v289; // xmm0
			//   __int128 v290; // xmm1
			//   __int128 v291; // xmm0
			//   __int128 v292; // xmm1
			//   __int128 v293; // xmm1
			//   __int128 v294; // xmm0
			//   __int128 v295; // xmm1
			//   __int128 v296; // xmm0
			//   __int128 v297; // xmm1
			//   __int128 v298; // xmm0
			//   HGAutoExposureConfig__StaticFields *v299; // rcx
			//   int v300; // eax
			//   __int128 v301; // xmm2
			//   __int128 v302; // xmm3
			//   HGShadowConfig__StaticFields *v303; // rcx
			//   __int128 v304; // xmm2
			//   __int128 v305; // xmm3
			//   __int128 v306; // xmm4
			//   __int128 v307; // xmm5
			//   __int128 v308; // xmm6
			//   OneofDescriptorProto *v309; // rdx
			//   FileDescriptor *v310; // r8
			//   MessageDescriptor *v311; // r9
			//   HGAnamorphicStreaksConfig__StaticFields *v312; // rcx
			//   Color v313; // xmm1
			//   __int128 v314; // xmm2
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v316; // rdx
			//   __int64 v317; // rcx
			//   __int128 v318; // [rsp+28h] [rbp-E0h] BYREF
			//   Color v319; // [rsp+38h] [rbp-D0h]
			//   __int128 v320; // [rsp+48h] [rbp-C0h]
			//   Color v321; // [rsp+58h] [rbp-B0h]
			//   __int128 v322; // [rsp+68h] [rbp-A0h]
			//   Color v323; // [rsp+78h] [rbp-90h]
			//   __int128 v324; // [rsp+88h] [rbp-80h]
			//   __int128 v325; // [rsp+98h] [rbp-70h]
			//   __int128 v326; // [rsp+A8h] [rbp-60h]
			//   Color v327; // [rsp+B8h] [rbp-50h]
			//   Color v328; // [rsp+C8h] [rbp-40h]
			//   Color v329; // [rsp+D8h] [rbp-30h]
			//   __int64 v330; // [rsp+E8h] [rbp-20h]
			// 
			//   if ( !byte_18D919D6E )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGAnamorphicStreaksConfig);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGAtmosphereConfig);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGAutoExposureConfig);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCelestialConfig);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCloudConfig);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGFogConfig);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGHeightFogConfig);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGInkSimulationConfig);
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
			//     byte_18D919D6E = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1217, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1217, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v317, v316);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGLightConfig);
			//     v3 = 2LL;
			//     v4 = 2LL;
			//     static_fields = TypeInfo::HG::Rendering::Runtime::HGLightConfig.static_fields;
			//     v6 = (Color *)&v318;
			//     do
			//     {
			//       v7 = *(Color *)&static_fields.defaultConfig.directColorMode;
			//       *v6 = static_fields.defaultConfig.directColor;
			//       v8 = *(Color *)&static_fields.defaultConfig.directCustomColor.a;
			//       v6[1] = v7;
			//       v9 = *(Color *)&static_fields.defaultConfig.directSpecularIntensity;
			//       v6[2] = v8;
			//       v10 = *(Color *)&static_fields.defaultConfig.indirectDiffuseFactor;
			//       v6[3] = v9;
			//       v11 = *(Color *)&static_fields.defaultConfig.atmospherePitchYaw.x;
			//       v6[4] = v10;
			//       v12 = *(Color *)&static_fields.defaultConfig.lightShaftPitchYaw.y;
			//       v6[5] = v11;
			//       v13 = *(Color *)&static_fields.defaultConfig.lensFlarePitchYawMode;
			//       static_fields = (HGLightConfig__StaticFields *)((char *)static_fields + 128);
			//       v6[6] = v12;
			//       v6 += 8;
			//       v6[-1] = v13;
			//       --v4;
			//     }
			//     while ( v4 );
			//     v14 = 2LL;
			//     v15 = *(Color *)&static_fields.defaultConfig.directColorMode;
			//     *v6 = static_fields.defaultConfig.directColor;
			//     v16 = *(Color *)&static_fields.defaultConfig.directCustomColor.a;
			//     v6[1] = v15;
			//     v17 = *(Color *)&static_fields.defaultConfig.directSpecularIntensity;
			//     v6[2] = v16;
			//     v18 = *(Color *)&static_fields.defaultConfig.indirectDiffuseFactor;
			//     v6[3] = v17;
			//     v19 = *(Color *)&static_fields.defaultConfig.atmospherePitchYaw.x;
			//     v20 = (Color *)&v318;
			//     v6[4] = v18;
			//     v6[5] = v19;
			//     p_lightConfig = &this.fields.lightConfig;
			//     do
			//     {
			//       v22 = v20[1];
			//       p_lightConfig.directColor = *v20;
			//       v23 = v20[2];
			//       *(Color *)&p_lightConfig.directColorMode = v22;
			//       v24 = v20[3];
			//       *(Color *)&p_lightConfig.directCustomColor.a = v23;
			//       v25 = v20[4];
			//       *(Color *)&p_lightConfig.directSpecularIntensity = v24;
			//       v26 = v20[5];
			//       *(Color *)&p_lightConfig.indirectDiffuseFactor = v25;
			//       v27 = v20[6];
			//       *(Color *)&p_lightConfig.atmospherePitchYaw.x = v26;
			//       v28 = v20[7];
			//       v20 += 8;
			//       *(Color *)&p_lightConfig.lightShaftPitchYaw.y = v27;
			//       p_lightConfig = (HGLightConfig *)((char *)p_lightConfig + 128);
			//       *(Color *)&p_lightConfig[-1].rotationHeightFogDirectionalInscattering.y = v28;
			//       --v14;
			//     }
			//     while ( v14 );
			//     v29 = v20[1];
			//     p_lightConfig.directColor = *v20;
			//     v30 = v20[2];
			//     *(Color *)&p_lightConfig.directColorMode = v29;
			//     v31 = v20[3];
			//     *(Color *)&p_lightConfig.directCustomColor.a = v30;
			//     v32 = v20[4];
			//     *(Color *)&p_lightConfig.directSpecularIntensity = v31;
			//     v33 = v20[5];
			//     *(Color *)&p_lightConfig.indirectDiffuseFactor = v32;
			//     *(Color *)&p_lightConfig.atmospherePitchYaw.x = v33;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGSkyConfig);
			//     v36 = &v318;
			//     v37 = 2LL;
			//     v38 = TypeInfo::HG::Rendering::Runtime::HGSkyConfig.static_fields;
			//     do
			//     {
			//       v39 = *(_OWORD *)&v38.defaultConfig.skyDirectIntensity;
			//       *v36 = *(_OWORD *)&v38.defaultConfig.parentEnvPhaseGuid;
			//       v40 = *(_OWORD *)&v38.defaultConfig.customIVDefaultSH.shr2;
			//       v36[1] = v39;
			//       v41 = *(_OWORD *)&v38.defaultConfig.customIVDefaultSH.shr6;
			//       v36[2] = v40;
			//       v42 = *(_OWORD *)&v38.defaultConfig.customIVDefaultSH.shg1;
			//       v36[3] = v41;
			//       v43 = *(_OWORD *)&v38.defaultConfig.customIVDefaultSH.shg5;
			//       v36[4] = v42;
			//       v44 = *(_OWORD *)&v38.defaultConfig.customIVDefaultSH.shb0;
			//       v36[5] = v43;
			//       v45 = *(_OWORD *)&v38.defaultConfig.customIVDefaultSH.shb4;
			//       v38 = (HGSkyConfig__StaticFields *)((char *)v38 + 128);
			//       v36[6] = v44;
			//       v36 += 8;
			//       *(v36 - 1) = v45;
			//       --v37;
			//     }
			//     while ( v37 );
			//     v46 = 2LL;
			//     v47 = *(_OWORD *)&v38.defaultConfig.skyDirectIntensity;
			//     *v36 = *(_OWORD *)&v38.defaultConfig.parentEnvPhaseGuid;
			//     v48 = *(_OWORD *)&v38.defaultConfig.customIVDefaultSH.shr2;
			//     v36[1] = v47;
			//     v49 = *(_OWORD *)&v38.defaultConfig.customIVDefaultSH.shr6;
			//     v36[2] = v48;
			//     v50 = *(_OWORD *)&v38.defaultConfig.customIVDefaultSH.shg1;
			//     v51 = *(_QWORD *)&v38.defaultConfig.customIVDefaultSH.shg5;
			//     v36[3] = v49;
			//     v36[4] = v50;
			//     *((_QWORD *)v36 + 10) = v51;
			//     p_skyConfig = &this.fields.skyConfig;
			//     v53 = &v318;
			//     do
			//     {
			//       v54 = v53[1];
			//       *(_OWORD *)&p_skyConfig.parentEnvPhaseGuid = *v53;
			//       v55 = v53[2];
			//       *(_OWORD *)&p_skyConfig.skyDirectIntensity = v54;
			//       v56 = v53[3];
			//       *(_OWORD *)&p_skyConfig.customIVDefaultSH.shr2 = v55;
			//       v57 = v53[4];
			//       *(_OWORD *)&p_skyConfig.customIVDefaultSH.shr6 = v56;
			//       v58 = v53[5];
			//       *(_OWORD *)&p_skyConfig.customIVDefaultSH.shg1 = v57;
			//       v59 = v53[6];
			//       *(_OWORD *)&p_skyConfig.customIVDefaultSH.shg5 = v58;
			//       v60 = v53[7];
			//       v53 += 8;
			//       *(_OWORD *)&p_skyConfig.customIVDefaultSH.shb0 = v59;
			//       p_skyConfig = (HGSkyConfig *)((char *)p_skyConfig + 128);
			//       *(_OWORD *)&p_skyConfig[-1].skyboxCubeMap = v60;
			//       --v46;
			//     }
			//     while ( v46 );
			//     v61 = v53[1];
			//     *(_OWORD *)&p_skyConfig.parentEnvPhaseGuid = *v53;
			//     v62 = v53[2];
			//     *(_OWORD *)&p_skyConfig.skyDirectIntensity = v61;
			//     v63 = v53[3];
			//     *(_OWORD *)&p_skyConfig.customIVDefaultSH.shr2 = v62;
			//     v64 = v53[4];
			//     v65 = *((_QWORD *)v53 + 10);
			//     *(_OWORD *)&p_skyConfig.customIVDefaultSH.shr6 = v63;
			//     *(_OWORD *)&p_skyConfig.customIVDefaultSH.shg1 = v64;
			//     *(_QWORD *)&p_skyConfig.customIVDefaultSH.shg5 = v65;
			//     sub_1800054D0(
			//       (OneofDescriptor *)&this.fields.skyConfig,
			//       0LL,
			//       v34,
			//       v35,
			//       (String__Array *)v318,
			//       *((String **)&v318 + 1),
			//       *(MethodInfo **)&v319.r);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGAtmosphereConfig);
			//     v66 = TypeInfo::HG::Rendering::Runtime::HGAtmosphereConfig.static_fields;
			//     v67 = *(Color *)&v66.defaultConfig.groundAlbedo.a;
			//     v318 = *(_OWORD *)&v66.defaultConfig.groundRadius;
			//     v68 = *(_OWORD *)&v66.defaultConfig.outerSunIrradianceColor.a;
			//     v319 = v67;
			//     rayleighScattering = v66.defaultConfig.rayleighScattering;
			//     v320 = v68;
			//     v70 = *(_OWORD *)&v66.defaultConfig.rayleighExponentialDistribution;
			//     v321 = rayleighScattering;
			//     v71 = *(Color *)&v66.defaultConfig.mieScattering.b;
			//     v322 = v70;
			//     v72 = *(_OWORD *)&v66.defaultConfig.mieAbsorption.g;
			//     v323 = v71;
			//     v73 = *(_OWORD *)&v66.defaultConfig.mieExponentialDistribution;
			//     v324 = v72;
			//     v74 = *(_OWORD *)&v66.defaultConfig.ozoneAbsorption.b;
			//     v75 = *(_QWORD *)&v66.defaultConfig.tentWidth;
			//     v325 = v73;
			//     v326 = v74;
			//     *(_QWORD *)&v327.r = v75;
			//     v76 = v319;
			//     *(_OWORD *)&this.fields.atmosphereConfig.groundRadius = v318;
			//     v77 = v320;
			//     *(Color *)&this.fields.atmosphereConfig.groundAlbedo.a = v76;
			//     v78 = v321;
			//     *(_OWORD *)&this.fields.atmosphereConfig.outerSunIrradianceColor.a = v77;
			//     v79 = v322;
			//     this.fields.atmosphereConfig.rayleighScattering = v78;
			//     v80 = v323;
			//     *(_OWORD *)&this.fields.atmosphereConfig.rayleighExponentialDistribution = v79;
			//     v81 = v324;
			//     *(Color *)&this.fields.atmosphereConfig.mieScattering.b = v80;
			//     v82 = v325;
			//     *(_OWORD *)&this.fields.atmosphereConfig.mieAbsorption.g = v81;
			//     v83 = v326;
			//     v84 = *(_QWORD *)&v327.r;
			//     *(_OWORD *)&this.fields.atmosphereConfig.mieExponentialDistribution = v82;
			//     *(_OWORD *)&this.fields.atmosphereConfig.ozoneAbsorption.b = v83;
			//     *(_QWORD *)&this.fields.atmosphereConfig.tentWidth = v84;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGFogConfig);
			//     v85 = TypeInfo::HG::Rendering::Runtime::HGFogConfig.static_fields;
			//     v86 = *(_DWORD *)&v85.defaultConfig.m_active;
			//     v87 = *(_OWORD *)&v85.defaultConfig.fallOffDistance;
			//     v88 = *(_OWORD *)&v85.defaultConfig.mieScattering.a;
			//     v89 = *(_OWORD *)&v85.defaultConfig.rayleighScattering.g;
			//     inscatterAmbientColor = v85.defaultConfig.inscatterAmbientColor;
			//     *(_OWORD *)&this.fields.fogConfig.enable = *(_OWORD *)&v85.defaultConfig.enable;
			//     *(_OWORD *)&this.fields.fogConfig.fallOffDistance = v87;
			//     *(_OWORD *)&this.fields.fogConfig.mieScattering.a = v88;
			//     *(_OWORD *)&this.fields.fogConfig.rayleighScattering.g = v89;
			//     this.fields.fogConfig.inscatterAmbientColor = inscatterAmbientColor;
			//     *(_DWORD *)&this.fields.fogConfig.m_active = v86;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGHeightFogConfig);
			//     v91 = TypeInfo::HG::Rendering::Runtime::HGHeightFogConfig.static_fields;
			//     v92 = *(Color *)&v91.defaultConfig.heightFogStartHeightSecond;
			//     v318 = *(_OWORD *)&v91.defaultConfig.enable;
			//     v93 = *(_OWORD *)&v91.defaultConfig.heightFogInscatter.g;
			//     v319 = v92;
			//     v94 = *(Color *)&v91.defaultConfig.heightFogStartDistance;
			//     v320 = v93;
			//     v95 = *(_OWORD *)&v91.defaultConfig.heightFogCullingFarClipPlane;
			//     v321 = v94;
			//     v96 = *(Color *)&v91.defaultConfig.heightFogDirectionalInscattering.g;
			//     v322 = v95;
			//     v97 = *(_OWORD *)&v91.defaultConfig.volumetricFogScatteringDistribution;
			//     v323 = v96;
			//     v98 = *(_OWORD *)&v91.defaultConfig.volumetricFogAlbedo.a;
			//     v91 = (HGHeightFogConfig__StaticFields *)((char *)v91 + 128);
			//     v324 = v97;
			//     v99 = *(_OWORD *)&v91.defaultConfig.enable;
			//     v325 = v98;
			//     v100 = *(Color *)&v91.defaultConfig.heightFogStartHeightSecond;
			//     v326 = v99;
			//     v101 = *(Color *)&v91.defaultConfig.heightFogInscatter.g;
			//     v327 = v100;
			//     v102 = *(Color *)&v91.defaultConfig.heightFogStartDistance;
			//     v103 = *(_QWORD *)&v91.defaultConfig.heightFogCullingFarClipPlane;
			//     v328 = v101;
			//     v329 = v102;
			//     v330 = v103;
			//     v104 = v319;
			//     *(_OWORD *)&this.fields.heightFogConfig.enable = v318;
			//     v105 = v320;
			//     *(Color *)&this.fields.heightFogConfig.heightFogStartHeightSecond = v104;
			//     v106 = v321;
			//     *(_OWORD *)&this.fields.heightFogConfig.heightFogInscatter.g = v105;
			//     v107 = v322;
			//     *(Color *)&this.fields.heightFogConfig.heightFogStartDistance = v106;
			//     v108 = v323;
			//     *(_OWORD *)&this.fields.heightFogConfig.heightFogCullingFarClipPlane = v107;
			//     v109 = v324;
			//     *(Color *)&this.fields.heightFogConfig.heightFogDirectionalInscattering.g = v108;
			//     v110 = v325;
			//     *(_OWORD *)&this.fields.heightFogConfig.volumetricFogScatteringDistribution = v109;
			//     v111 = v326;
			//     *(_OWORD *)&this.fields.heightFogConfig.volumetricFogAlbedo.a = v110;
			//     v112 = v327;
			//     *(_OWORD *)&this.fields.heightFogConfig.volumetricFogEmissive.a = v111;
			//     v113 = v328;
			//     *(Color *)&this.fields.heightFogConfig.volumetricFogNearFadeInDistance = v112;
			//     v114 = v329;
			//     v115 = v330;
			//     *(Color *)&this.fields.heightFogConfig.flowNoiseIntensity = v113;
			//     *(Color *)&this.fields.heightFogConfig.flowNoiseVerticalDirAngle = v114;
			//     *(_QWORD *)&this.fields.heightFogConfig.flowNoiseSpeed = v115;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig);
			//     v116 = 2LL;
			//     v117 = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig.static_fields;
			//     v118 = &v318;
			//     do
			//     {
			//       v119 = *(_OWORD *)&v117.defaultConfig.heightFogStartHeightSecond;
			//       *v118 = *(_OWORD *)&v117.defaultConfig.enable;
			//       v120 = *(_OWORD *)&v117.defaultConfig.heightFogInscatter.g;
			//       v118[1] = v119;
			//       v121 = *(_OWORD *)&v117.defaultConfig.heightFogStartDistance;
			//       v118[2] = v120;
			//       v122 = *(_OWORD *)&v117.defaultConfig.heightFogDirectionalInscatteringExponent;
			//       v118[3] = v121;
			//       v123 = *(_OWORD *)&v117.defaultConfig.heightFogDirectionalInscattering.b;
			//       v118[4] = v122;
			//       v124 = *(_OWORD *)&v117.defaultConfig.volumetricFogAlbedo.g;
			//       v118[5] = v123;
			//       v125 = *(_OWORD *)&v117.defaultConfig.volumetricFogEmissive.g;
			//       v117 = (HGVolumetricFogConfig__StaticFields *)((char *)v117 + 128);
			//       v118[6] = v124;
			//       v118 += 8;
			//       *(v118 - 1) = v125;
			//       --v116;
			//     }
			//     while ( v116 );
			//     p_volumetricFogConfig = &this.fields.volumetricFogConfig;
			//     v127 = 2LL;
			//     v128 = &v318;
			//     do
			//     {
			//       v129 = v128[1];
			//       *(_OWORD *)&p_volumetricFogConfig.enable = *v128;
			//       v130 = v128[2];
			//       *(_OWORD *)&p_volumetricFogConfig.heightFogStartHeightSecond = v129;
			//       v131 = v128[3];
			//       *(_OWORD *)&p_volumetricFogConfig.heightFogInscatter.g = v130;
			//       v132 = v128[4];
			//       *(_OWORD *)&p_volumetricFogConfig.heightFogStartDistance = v131;
			//       v133 = v128[5];
			//       *(_OWORD *)&p_volumetricFogConfig.heightFogDirectionalInscatteringExponent = v132;
			//       v134 = v128[6];
			//       *(_OWORD *)&p_volumetricFogConfig.heightFogDirectionalInscattering.b = v133;
			//       v135 = v128[7];
			//       v128 += 8;
			//       *(_OWORD *)&p_volumetricFogConfig.volumetricFogAlbedo.g = v134;
			//       p_volumetricFogConfig = (HGVolumetricFogConfig *)((char *)p_volumetricFogConfig + 128);
			//       *(_OWORD *)&p_volumetricFogConfig[-1].m_backupVLNoiseHorizontalDirAngle = v135;
			//       --v127;
			//     }
			//     while ( v127 );
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGCloudConfig);
			//     v136 = TypeInfo::HG::Rendering::Runtime::HGCloudConfig.static_fields;
			//     cloudTint = v136.defaultConfig.cloudTint;
			//     v318 = *(_OWORD *)&v136.defaultConfig.enable;
			//     v138 = *(_OWORD *)&v136.defaultConfig.cloudContrast;
			//     v319 = cloudTint;
			//     v139 = *(Color *)&v136.defaultConfig.brightnessAffectCloudAlpha;
			//     v320 = v138;
			//     v140 = *(_OWORD *)&v136.defaultConfig.cloudFlowType;
			//     v321 = v139;
			//     v141 = *(Color *)&v136.defaultConfig.flowSpeed;
			//     v322 = v140;
			//     v142 = *(_OWORD *)&v136.defaultConfig.lightShaftCloudMaskTexture;
			//     v323 = v141;
			//     v143 = *(_OWORD *)&v136.defaultConfig.cloudShadowConfig.cloudShadowTexture;
			//     v324 = v142;
			//     v144 = *(_OWORD *)&v136.defaultConfig.cloudShadowConfig.cloudShadowEnvCenter.z;
			//     v325 = v143;
			//     v145 = *(Color *)&v136.defaultConfig.cloudShadowConfig.cloudShadowFlowDirection.y;
			//     v326 = v144;
			//     v146 = *(Color *)&v136.defaultConfig.cloudShadowConfig.cloudShadowScaleEndDistance;
			//     v327 = v145;
			//     v328 = v146;
			//     v147 = v319;
			//     *(_OWORD *)&this.fields.cloudConfig.enable = v318;
			//     v148 = v320;
			//     this.fields.cloudConfig.cloudTint = v147;
			//     v149 = v321;
			//     *(_OWORD *)&this.fields.cloudConfig.cloudContrast = v148;
			//     v150 = v322;
			//     *(Color *)&this.fields.cloudConfig.brightnessAffectCloudAlpha = v149;
			//     v151 = v323;
			//     *(_OWORD *)&this.fields.cloudConfig.cloudFlowType = v150;
			//     v152 = v324;
			//     *(Color *)&this.fields.cloudConfig.flowSpeed = v151;
			//     v153 = v325;
			//     *(_OWORD *)&this.fields.cloudConfig.lightShaftCloudMaskTexture = v152;
			//     v154 = v326;
			//     *(_OWORD *)&this.fields.cloudConfig.cloudShadowConfig.cloudShadowTexture = v153;
			//     v155 = v327;
			//     *(_OWORD *)&this.fields.cloudConfig.cloudShadowConfig.cloudShadowEnvCenter.z = v154;
			//     v156 = v328;
			//     *(Color *)&this.fields.cloudConfig.cloudShadowConfig.cloudShadowFlowDirection.y = v155;
			//     *(Color *)&this.fields.cloudConfig.cloudShadowConfig.cloudShadowScaleEndDistance = v156;
			//     sub_1800054D0(
			//       (OneofDescriptor *)&this.fields.cloudConfig.cloudTexture,
			//       v157,
			//       v158,
			//       v159,
			//       (String__Array *)v318,
			//       *((String **)&v318 + 1),
			//       *(MethodInfo **)&v319.r);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGCelestialConfig);
			//     v162 = &v318;
			//     v163 = 2LL;
			//     v164 = TypeInfo::HG::Rendering::Runtime::HGCelestialConfig.static_fields;
			//     do
			//     {
			//       v165 = *(_OWORD *)&v164.defaultConfig.moonConfig.worldLongitude;
			//       *v162 = *(_OWORD *)&v164.defaultConfig.moonConfig.radius;
			//       v166 = *(_OWORD *)&v164.defaultConfig.moonConfig.ring.outerRadius;
			//       v162[1] = v165;
			//       v167 = *(_OWORD *)&v164.defaultConfig.moonConfig.ring.ringColor.b;
			//       v162[2] = v166;
			//       v168 = *(_OWORD *)&v164.defaultConfig.talosAlphaConfig.drawPlanetInSkydome;
			//       v162[3] = v167;
			//       v169 = *(_OWORD *)&v164.defaultConfig.talosAlphaConfig.objectProperty.selfTiltZ;
			//       v162[4] = v168;
			//       v170 = *(_OWORD *)&v164.defaultConfig.talosAlphaConfig.skydomeDrawer.drawMaterial;
			//       v162[5] = v169;
			//       v171 = *(_OWORD *)&v164.defaultConfig.talosAlphaConfig.skydomeDrawer.incidentLightingPitchYaw.x;
			//       v164 = (HGCelestialConfig__StaticFields *)((char *)v164 + 128);
			//       v162[6] = v170;
			//       v162 += 8;
			//       *(v162 - 1) = v171;
			//       --v163;
			//     }
			//     while ( v163 );
			//     v172 = 2LL;
			//     v173 = *(_OWORD *)&v164.defaultConfig.moonConfig.worldLongitude;
			//     *v162 = *(_OWORD *)&v164.defaultConfig.moonConfig.radius;
			//     v174 = *(_OWORD *)&v164.defaultConfig.moonConfig.ring.outerRadius;
			//     v162[1] = v173;
			//     v175 = *(_OWORD *)&v164.defaultConfig.moonConfig.ring.ringColor.b;
			//     v162[2] = v174;
			//     v176 = *(_OWORD *)&v164.defaultConfig.talosAlphaConfig.drawPlanetInSkydome;
			//     v162[3] = v175;
			//     v177 = *(_OWORD *)&v164.defaultConfig.talosAlphaConfig.objectProperty.selfTiltZ;
			//     drawMaterial = v164.defaultConfig.talosAlphaConfig.skydomeDrawer.drawMaterial;
			//     v162[4] = v176;
			//     v162[5] = v177;
			//     *((_QWORD *)v162 + 12) = drawMaterial;
			//     p_celestialConfig = &this.fields.celestialConfig;
			//     v180 = &v318;
			//     do
			//     {
			//       v181 = v180[1];
			//       *(_OWORD *)&p_celestialConfig.moonConfig.radius = *v180;
			//       v182 = v180[2];
			//       *(_OWORD *)&p_celestialConfig.moonConfig.worldLongitude = v181;
			//       v183 = v180[3];
			//       *(_OWORD *)&p_celestialConfig.moonConfig.ring.outerRadius = v182;
			//       v184 = v180[4];
			//       *(_OWORD *)&p_celestialConfig.moonConfig.ring.ringColor.b = v183;
			//       v185 = v180[5];
			//       *(_OWORD *)&p_celestialConfig.talosAlphaConfig.drawPlanetInSkydome = v184;
			//       v186 = v180[6];
			//       *(_OWORD *)&p_celestialConfig.talosAlphaConfig.objectProperty.selfTiltZ = v185;
			//       v187 = v180[7];
			//       v180 += 8;
			//       *(_OWORD *)&p_celestialConfig.talosAlphaConfig.skydomeDrawer.drawMaterial = v186;
			//       p_celestialConfig = (HGCelestialConfig *)((char *)p_celestialConfig + 128);
			//       *(_OWORD *)&p_celestialConfig[-1].advancedPlanetConfig.advancedPlanetMat = v187;
			//       --v172;
			//     }
			//     while ( v172 );
			//     v188 = v180[1];
			//     *(_OWORD *)&p_celestialConfig.moonConfig.radius = *v180;
			//     v189 = v180[2];
			//     *(_OWORD *)&p_celestialConfig.moonConfig.worldLongitude = v188;
			//     v190 = v180[3];
			//     *(_OWORD *)&p_celestialConfig.moonConfig.ring.outerRadius = v189;
			//     v191 = v180[4];
			//     *(_OWORD *)&p_celestialConfig.moonConfig.ring.ringColor.b = v190;
			//     v192 = v180[5];
			//     v193 = (Material *)*((_QWORD *)v180 + 12);
			//     *(_OWORD *)&p_celestialConfig.talosAlphaConfig.drawPlanetInSkydome = v191;
			//     *(_OWORD *)&p_celestialConfig.talosAlphaConfig.objectProperty.selfTiltZ = v192;
			//     p_celestialConfig.talosAlphaConfig.skydomeDrawer.drawMaterial = v193;
			//     sub_1800054D0(
			//       (OneofDescriptor *)&this.fields.celestialConfig.moonConfig.ring.planetRingMap,
			//       0LL,
			//       v160,
			//       v161,
			//       (String__Array *)v318,
			//       *((String **)&v318 + 1),
			//       *(MethodInfo **)&v319.r);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGWindConfig);
			//     v194 = TypeInfo::HG::Rendering::Runtime::HGWindConfig.static_fields;
			//     v195 = *(_DWORD *)&v194.defaultConfig.m_active;
			//     *(_QWORD *)&v191 = *(_QWORD *)&v194.defaultConfig.direction.y;
			//     *(_OWORD *)&this.fields.windConfig.speed = *(_OWORD *)&v194.defaultConfig.speed;
			//     *(_QWORD *)&this.fields.windConfig.direction.y = v191;
			//     *(_DWORD *)&this.fields.windConfig.m_active = v195;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGLightShaftConfig);
			//     v196 = TypeInfo::HG::Rendering::Runtime::HGLightShaftConfig.static_fields;
			//     v197 = *(_DWORD *)&v196.defaultConfig.m_active;
			//     bloomTint = v196.defaultConfig.bloomTint;
			//     v199 = *(_OWORD *)&v196.defaultConfig.blurIntensity;
			//     *(_OWORD *)&this.fields.lightShaftConfig.enable = *(_OWORD *)&v196.defaultConfig.enable;
			//     this.fields.lightShaftConfig.bloomTint = bloomTint;
			//     *(_OWORD *)&this.fields.lightShaftConfig.blurIntensity = v199;
			//     *(_DWORD *)&this.fields.lightShaftConfig.m_active = v197;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGTerrainDeformConfig);
			//     v200 = TypeInfo::HG::Rendering::Runtime::HGTerrainDeformConfig.static_fields;
			//     v201 = *(_DWORD *)&v200.defaultConfig.m_active;
			//     *(_QWORD *)&this.fields.terrainDeformConfig.deformGlobalStrength = *(_QWORD *)&v200.defaultConfig.deformGlobalStrength;
			//     *(_DWORD *)&this.fields.terrainDeformConfig.m_active = v201;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGInkSimulationConfig);
			//     v202 = TypeInfo::HG::Rendering::Runtime::HGInkSimulationConfig.static_fields;
			//     *(_QWORD *)&v191 = *(_QWORD *)&v202.defaultConfig.m_active;
			//     *(_OWORD *)&this.fields.inkSimulationConfig.influence = *(_OWORD *)&v202.defaultConfig.influence;
			//     *(_QWORD *)&this.fields.inkSimulationConfig.m_active = v191;
			//     sub_1800054D0(
			//       (OneofDescriptor *)&this.fields.inkSimulationConfig.material,
			//       v203,
			//       v204,
			//       v205,
			//       (String__Array *)v318,
			//       *((String **)&v318 + 1),
			//       *(MethodInfo **)&v319.r);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRainConfig);
			//     v206 = 2LL;
			//     v207 = TypeInfo::HG::Rendering::Runtime::HGRainConfig.static_fields;
			//     v208 = &v318;
			//     do
			//     {
			//       v209 = *(_OWORD *)&v207.defaultConfig.color.g;
			//       *v208 = *(_OWORD *)&v207.defaultConfig.enable;
			//       v210 = *(_OWORD *)&v207.defaultConfig.horizontalRainAngle;
			//       v208[1] = v209;
			//       v211 = *(_OWORD *)&v207.defaultConfig.sceneEffectRainLightingPercent;
			//       v208[2] = v210;
			//       v212 = *(_OWORD *)&v207.defaultConfig.middleHorizontalRainAngle;
			//       v208[3] = v211;
			//       v213 = *(_OWORD *)&v207.defaultConfig.farRainAlphaMultiplier;
			//       v208[4] = v212;
			//       v214 = *(_OWORD *)&v207.defaultConfig.rainWaveHorizontalSpeed;
			//       v208[5] = v213;
			//       v215 = *(_OWORD *)&v207.defaultConfig.screenDropColor.g;
			//       v207 = (HGRainConfig__StaticFields *)((char *)v207 + 128);
			//       v208[6] = v214;
			//       v208 += 8;
			//       *(v208 - 1) = v215;
			//       --v206;
			//     }
			//     while ( v206 );
			//     v216 = 2LL;
			//     v217 = *(_OWORD *)&v207.defaultConfig.color.g;
			//     *v208 = *(_OWORD *)&v207.defaultConfig.enable;
			//     v218 = *(_OWORD *)&v207.defaultConfig.horizontalRainAngle;
			//     v219 = &v318;
			//     v208[1] = v217;
			//     v208[2] = v218;
			//     p_rainConfig = &this.fields.rainConfig;
			//     do
			//     {
			//       v221 = v219[1];
			//       *(_OWORD *)&p_rainConfig.enable = *v219;
			//       v222 = v219[2];
			//       *(_OWORD *)&p_rainConfig.color.g = v221;
			//       v223 = v219[3];
			//       *(_OWORD *)&p_rainConfig.horizontalRainAngle = v222;
			//       v224 = v219[4];
			//       *(_OWORD *)&p_rainConfig.sceneEffectRainLightingPercent = v223;
			//       v225 = v219[5];
			//       *(_OWORD *)&p_rainConfig.middleHorizontalRainAngle = v224;
			//       v226 = v219[6];
			//       *(_OWORD *)&p_rainConfig.farRainAlphaMultiplier = v225;
			//       v227 = v219[7];
			//       v219 += 8;
			//       *(_OWORD *)&p_rainConfig.rainWaveHorizontalSpeed = v226;
			//       p_rainConfig = (HGRainConfig *)((char *)p_rainConfig + 128);
			//       *(_OWORD *)&p_rainConfig[-1].farRainDirection.x = v227;
			//       --v216;
			//     }
			//     while ( v216 );
			//     v228 = v219[1];
			//     *(_OWORD *)&p_rainConfig.enable = *v219;
			//     v229 = v219[2];
			//     *(_OWORD *)&p_rainConfig.color.g = v228;
			//     *(_OWORD *)&p_rainConfig.horizontalRainAngle = v229;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGSnowConfig);
			//     v230 = TypeInfo::HG::Rendering::Runtime::HGSnowConfig.static_fields;
			//     v231 = *(_OWORD *)&v230.defaultConfig.color.g;
			//     v232 = *(_OWORD *)&v230.defaultConfig.snowSizeRange.y;
			//     v233 = *(_OWORD *)&v230.defaultConfig.snowLightingPercent;
			//     *(_QWORD *)&v229 = *(_QWORD *)&v230.defaultConfig.snowDirection.z;
			//     *(_OWORD *)&this.fields.snowConfig.enable = *(_OWORD *)&v230.defaultConfig.enable;
			//     *(_OWORD *)&this.fields.snowConfig.color.g = v231;
			//     *(_OWORD *)&this.fields.snowConfig.snowSizeRange.y = v232;
			//     *(_OWORD *)&this.fields.snowConfig.snowLightingPercent = v233;
			//     *(_QWORD *)&this.fields.snowConfig.snowDirection.z = v229;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGStarConfig);
			//     v234 = TypeInfo::HG::Rendering::Runtime::HGStarConfig.static_fields;
			//     starsTint = v234.defaultConfig.starsTint;
			//     v318 = *(_OWORD *)&v234.defaultConfig.enableStars;
			//     v236 = *(_OWORD *)&v234.defaultConfig.starsOffset0;
			//     v319 = starsTint;
			//     starsTint1 = v234.defaultConfig.starsTint1;
			//     v320 = v236;
			//     v238 = *(_OWORD *)&v234.defaultConfig.starsOffset1;
			//     v321 = starsTint1;
			//     starsTint2 = v234.defaultConfig.starsTint2;
			//     v322 = v238;
			//     v240 = *(_OWORD *)&v234.defaultConfig.starsOffset2;
			//     v323 = starsTint2;
			//     v241 = *(_OWORD *)&v234.defaultConfig.starLayerViewMode;
			//     v234 = (HGStarConfig__StaticFields *)((char *)v234 + 128);
			//     v324 = v240;
			//     v242 = *(_OWORD *)&v234.defaultConfig.enableStars;
			//     v325 = v241;
			//     v243 = v234.defaultConfig.starsTint;
			//     v326 = v242;
			//     v244 = *(Color *)&v234.defaultConfig.starsOffset0;
			//     v327 = v243;
			//     v245 = v234.defaultConfig.starsTint1;
			//     v328 = v244;
			//     v329 = v245;
			//     v246 = v319;
			//     *(_OWORD *)&this.fields.starConfig.enableStars = v318;
			//     v247 = v320;
			//     this.fields.starConfig.starsTint = v246;
			//     v248 = v321;
			//     *(_OWORD *)&this.fields.starConfig.starsOffset0 = v247;
			//     v249 = v322;
			//     this.fields.starConfig.starsTint1 = v248;
			//     v250 = v323;
			//     *(_OWORD *)&this.fields.starConfig.starsOffset1 = v249;
			//     v251 = v324;
			//     this.fields.starConfig.starsTint2 = v250;
			//     v252 = v325;
			//     *(_OWORD *)&this.fields.starConfig.starsOffset2 = v251;
			//     v253 = v326;
			//     *(_OWORD *)&this.fields.starConfig.starLayerViewMode = v252;
			//     v254 = v327;
			//     *(_OWORD *)&this.fields.starConfig.skyBoxStarRangeMap = v253;
			//     v255 = v328;
			//     *(Color *)&this.fields.starConfig.enableNebula = v254;
			//     v256 = v329;
			//     this.fields.starConfig.nebulaTint = v255;
			//     *(Color *)&this.fields.starConfig.nebulaMapRotation = v256;
			//     sub_1800054D0(
			//       (OneofDescriptor *)&this.fields.starConfig.skyboxStarNoiseMap,
			//       v257,
			//       v258,
			//       v259,
			//       (String__Array *)v318,
			//       *((String **)&v318 + 1),
			//       *(MethodInfo **)&v319.r);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGLensFlareConfig);
			//     v260 = TypeInfo::HG::Rendering::Runtime::HGLensFlareConfig.static_fields;
			//     v261 = *(_OWORD *)&v260.defaultConfig.intensity;
			//     v262 = *(_OWORD *)&v260.defaultConfig.sampleCount;
			//     *(_OWORD *)&this.fields.lensFlareConfig.enable = *(_OWORD *)&v260.defaultConfig.enable;
			//     *(_OWORD *)&this.fields.lensFlareConfig.intensity = v261;
			//     *(_OWORD *)&this.fields.lensFlareConfig.sampleCount = v262;
			//     sub_1800054D0(
			//       (OneofDescriptor *)&this.fields.lensFlareConfig.lensFlareData,
			//       v263,
			//       v264,
			//       v265,
			//       (String__Array *)v318,
			//       *((String **)&v318 + 1),
			//       *(MethodInfo **)&v319.r);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
			//     v268 = 2LL;
			//     v269 = &v318;
			//     p_defaultConfig = &TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig.static_fields.defaultConfig;
			//     do
			//     {
			//       v271 = *(_OWORD *)&p_defaultConfig.colorLookupContribution;
			//       *v269 = *(_OWORD *)&p_defaultConfig.tonemappingMode;
			//       v272 = *(_OWORD *)&p_defaultConfig.colorAdjustmentsEnabled;
			//       v269[1] = v271;
			//       v273 = *(_OWORD *)&p_defaultConfig.colorAdjustmentsColorFilter.g;
			//       v269[2] = v272;
			//       v274 = *(_OWORD *)&p_defaultConfig.colorAdjustmentsSaturation;
			//       v269[3] = v273;
			//       v275 = *(_OWORD *)&p_defaultConfig.channelMixerRedOutBlueIn;
			//       v269[4] = v274;
			//       v276 = *(_OWORD *)&p_defaultConfig.channelMixerBlueOutRedIn;
			//       v269[5] = v275;
			//       shadows = p_defaultConfig.shadowsMidtonesHighlights.shadows;
			//       p_defaultConfig = (HGColorGradingConfig *)((char *)p_defaultConfig + 128);
			//       v269[6] = v276;
			//       v269 += 8;
			//       *(v269 - 1) = (__int128)shadows;
			//       --v268;
			//     }
			//     while ( v268 );
			//     v278 = *(_OWORD *)&p_defaultConfig.colorLookupContribution;
			//     *v269 = *(_OWORD *)&p_defaultConfig.tonemappingMode;
			//     v279 = *(_OWORD *)&p_defaultConfig.colorAdjustmentsEnabled;
			//     v269[1] = v278;
			//     v280 = *(_OWORD *)&p_defaultConfig.colorAdjustmentsColorFilter.g;
			//     v269[2] = v279;
			//     v281 = *(_OWORD *)&p_defaultConfig.colorAdjustmentsSaturation;
			//     v269[3] = v280;
			//     v282 = *(_OWORD *)&p_defaultConfig.channelMixerRedOutBlueIn;
			//     v269[4] = v281;
			//     v283 = *(_OWORD *)&p_defaultConfig.channelMixerBlueOutRedIn;
			//     v284 = &v318;
			//     v269[5] = v282;
			//     v269[6] = v283;
			//     p_colorGradingConfig = &this.fields.colorGradingConfig;
			//     do
			//     {
			//       v286 = v284[1];
			//       *(_OWORD *)&p_colorGradingConfig.tonemappingMode = *v284;
			//       v287 = v284[2];
			//       *(_OWORD *)&p_colorGradingConfig.colorLookupContribution = v286;
			//       v288 = v284[3];
			//       *(_OWORD *)&p_colorGradingConfig.colorAdjustmentsEnabled = v287;
			//       v289 = v284[4];
			//       *(_OWORD *)&p_colorGradingConfig.colorAdjustmentsColorFilter.g = v288;
			//       v290 = v284[5];
			//       *(_OWORD *)&p_colorGradingConfig.colorAdjustmentsSaturation = v289;
			//       v291 = v284[6];
			//       *(_OWORD *)&p_colorGradingConfig.channelMixerRedOutBlueIn = v290;
			//       v292 = v284[7];
			//       v284 += 8;
			//       *(_OWORD *)&p_colorGradingConfig.channelMixerBlueOutRedIn = v291;
			//       p_colorGradingConfig = (HGColorGradingConfig *)((char *)p_colorGradingConfig + 128);
			//       *(_OWORD *)&p_colorGradingConfig[-1].colorCurves.masterOverriding = v292;
			//       --v3;
			//     }
			//     while ( v3 );
			//     v293 = v284[1];
			//     *(_OWORD *)&p_colorGradingConfig.tonemappingMode = *v284;
			//     v294 = v284[2];
			//     *(_OWORD *)&p_colorGradingConfig.colorLookupContribution = v293;
			//     v295 = v284[3];
			//     *(_OWORD *)&p_colorGradingConfig.colorAdjustmentsEnabled = v294;
			//     v296 = v284[4];
			//     *(_OWORD *)&p_colorGradingConfig.colorAdjustmentsColorFilter.g = v295;
			//     v297 = v284[5];
			//     *(_OWORD *)&p_colorGradingConfig.colorAdjustmentsSaturation = v296;
			//     v298 = v284[6];
			//     *(_OWORD *)&p_colorGradingConfig.channelMixerRedOutBlueIn = v297;
			//     *(_OWORD *)&p_colorGradingConfig.channelMixerBlueOutRedIn = v298;
			//     sub_1800054D0(
			//       (OneofDescriptor *)&this.fields.colorGradingConfig.colorLookupTexture,
			//       0LL,
			//       v266,
			//       v267,
			//       (String__Array *)v318,
			//       *((String **)&v318 + 1),
			//       *(MethodInfo **)&v319.r);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGAutoExposureConfig);
			//     v299 = TypeInfo::HG::Rendering::Runtime::HGAutoExposureConfig.static_fields;
			//     v300 = *(_DWORD *)&v299.defaultConfig.m_active;
			//     v301 = *(_OWORD *)&v299.defaultConfig.autoExposureEv100Range.x;
			//     v302 = *(_OWORD *)&v299.defaultConfig.autoExposureMeteringMode;
			//     *(_QWORD *)&v298 = *(_QWORD *)&v299.defaultConfig.autoExposureEvClampRange.y;
			//     *(_OWORD *)&this.fields.autoExposureConfig.autoExposureMode = *(_OWORD *)&v299.defaultConfig.autoExposureMode;
			//     *(_OWORD *)&this.fields.autoExposureConfig.autoExposureEv100Range.x = v301;
			//     *(_OWORD *)&this.fields.autoExposureConfig.autoExposureMeteringMode = v302;
			//     *(_QWORD *)&this.fields.autoExposureConfig.autoExposureEvClampRange.y = v298;
			//     *(_DWORD *)&this.fields.autoExposureConfig.m_active = v300;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowConfig);
			//     v303 = TypeInfo::HG::Rendering::Runtime::HGShadowConfig.static_fields;
			//     v304 = *(_OWORD *)&v303.defaultConfig.csmIntensity;
			//     v305 = *(_OWORD *)&v303.defaultConfig.csmShadowSoftness;
			//     v306 = *(_OWORD *)&v303.defaultConfig.contactShadowSurfaceThickness;
			//     v307 = *(_OWORD *)&v303.defaultConfig.overrideCsmFarDistance;
			//     v308 = *(_OWORD *)&v303.defaultConfig.overrideCsmSpherePosition.z;
			//     *(_QWORD *)&v298 = *(_QWORD *)&v303.defaultConfig.csmSimulatedAttenuation;
			//     *(_OWORD *)&this.fields.shadowConfig.csmDepthBias = *(_OWORD *)&v303.defaultConfig.csmDepthBias;
			//     *(_OWORD *)&this.fields.shadowConfig.csmIntensity = v304;
			//     *(_OWORD *)&this.fields.shadowConfig.csmShadowSoftness = v305;
			//     *(_OWORD *)&this.fields.shadowConfig.contactShadowSurfaceThickness = v306;
			//     *(_OWORD *)&this.fields.shadowConfig.overrideCsmFarDistance = v307;
			//     *(_OWORD *)&this.fields.shadowConfig.overrideCsmSpherePosition.z = v308;
			//     *(_QWORD *)&this.fields.shadowConfig.csmSimulatedAttenuation = v298;
			//     sub_1800054D0(
			//       (OneofDescriptor *)&this.fields.shadowConfig.csmRampTexture,
			//       v309,
			//       v310,
			//       v311,
			//       (String__Array *)v318,
			//       *((String **)&v318 + 1),
			//       *(MethodInfo **)&v319.r);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGAnamorphicStreaksConfig);
			//     v312 = TypeInfo::HG::Rendering::Runtime::HGAnamorphicStreaksConfig.static_fields;
			//     v313 = v312.defaultConfig.bloomTint;
			//     v314 = *(_OWORD *)&v312.defaultConfig.blurIntensity;
			//     *(_OWORD *)&this.fields.anamorphicStreaksConfig.enable = *(_OWORD *)&v312.defaultConfig.enable;
			//     this.fields.anamorphicStreaksConfig.bloomTint = v313;
			//     *(_OWORD *)&this.fields.anamorphicStreaksConfig.blurIntensity = v314;
			//   }
			// }
			// 
		}

		public void CopyFrom(HGEnvironmentPhase src)
		{
			// // Void CopyFrom(HGEnvironmentPhase)
			// void HG::Rendering::Runtime::HGEnvironmentPhase::CopyFrom(
			//         HGEnvironmentPhase *this,
			//         HGEnvironmentPhase *src,
			//         MethodInfo *method)
			// {
			//   HGEnvironmentPhase *v3; // rsi
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rbx
			//   ILFixDynamicMethodWrapper_2__Array *v7; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   HGLightConfig *p_lightConfig; // rbx
			//   __int128 *v12; // rdi
			//   struct MethodInfo *v13; // r14
			//   __int128 *v14; // rax
			//   __int64 v15; // rcx
			//   __int128 v16; // xmm0
			//   __int128 v17; // xmm1
			//   __int128 v18; // xmm0
			//   __int128 v19; // xmm1
			//   __int128 v20; // xmm0
			//   __int128 v21; // xmm1
			//   __int128 v22; // xmm0
			//   __int128 v23; // xmm1
			//   __int64 v24; // rcx
			//   __int128 v25; // xmm1
			//   __int128 v26; // xmm0
			//   __int128 v27; // xmm1
			//   __int128 v28; // xmm0
			//   __int128 v29; // xmm1
			//   Color *v30; // rax
			//   Color v31; // xmm0
			//   Color v32; // xmm1
			//   Color v33; // xmm0
			//   Color v34; // xmm1
			//   Color v35; // xmm0
			//   Color v36; // xmm1
			//   Color v37; // xmm0
			//   Color v38; // xmm1
			//   Color v39; // xmm1
			//   Color v40; // xmm0
			//   Color v41; // xmm1
			//   Color v42; // xmm0
			//   Color v43; // xmm1
			//   struct MethodInfo *v44; // r14
			//   HGSkyConfig *p_skyConfig; // rbx
			//   __int128 *v46; // rcx
			//   __int64 v47; // rax
			//   __int128 v48; // xmm0
			//   __int128 v49; // xmm1
			//   __int128 v50; // xmm0
			//   __int128 v51; // xmm1
			//   __int128 v52; // xmm0
			//   __int128 v53; // xmm1
			//   __int128 v54; // xmm0
			//   __int128 v55; // xmm1
			//   __int64 v56; // rax
			//   __int128 v57; // xmm1
			//   __int128 v58; // xmm0
			//   __int128 v59; // xmm1
			//   __int128 v60; // xmm0
			//   HGSkyConfig *v61; // rcx
			//   __int128 *v62; // rax
			//   __int128 v63; // xmm0
			//   __int128 v64; // xmm1
			//   __int128 v65; // xmm0
			//   __int128 v66; // xmm1
			//   __int128 v67; // xmm0
			//   __int128 v68; // xmm1
			//   __int128 v69; // xmm0
			//   __int128 v70; // xmm1
			//   bool v71; // zf
			//   __int128 v72; // xmm1
			//   __int128 v73; // xmm0
			//   __int128 v74; // xmm1
			//   __int128 v75; // xmm0
			//   __int64 v76; // rax
			//   HGEnvironmentPhase__Class *klass; // rtt
			//   struct MethodInfo *v78; // r14
			//   void (__fastcall __noreturn **v79)(); // rbx
			//   unsigned int v80; // r8d
			//   __int64 v81; // rdi
			//   unsigned int v82; // eax
			//   unsigned int v83; // r8d
			//   unsigned int v84; // eax
			//   __int64 v85; // rax
			//   __int64 v86; // rcx
			//   HGEnvironmentPhase *v87; // r9
			//   unsigned __int64 v88; // r8
			//   __int64 *v89; // rdx
			//   __int64 v90; // rtt
			//   __int64 v91; // rdi
			//   __int64 v92; // rax
			//   __int64 v93; // rdi
			//   _QWORD **v94; // rcx
			//   __int64 v95; // r8
			//   __int64 v96; // rax
			//   __int64 v97; // rdx
			//   __int128 v98; // xmm7
			//   __int128 v99; // xmm8
			//   __int128 v100; // xmm9
			//   __int128 v101; // xmm2
			//   __int128 v102; // xmm3
			//   Color rayleighScattering; // xmm4
			//   __int128 v104; // xmm5
			//   __int128 v105; // xmm6
			//   __int64 v106; // xmm0_8
			//   struct MethodInfo *v107; // r14
			//   unsigned int v108; // r8d
			//   __int64 v109; // rdi
			//   unsigned int v110; // eax
			//   unsigned int v111; // r8d
			//   unsigned int v112; // eax
			//   __int64 v113; // rax
			//   __int64 v114; // r8
			//   HGEnvironmentPhase *v115; // r9
			//   unsigned __int64 v116; // r8
			//   __int64 *v117; // rdx
			//   __int64 v118; // rtt
			//   __int64 v119; // rdi
			//   __int64 v120; // rax
			//   __int64 v121; // rdi
			//   _QWORD **v122; // rcx
			//   __int64 v123; // r8
			//   __int64 v124; // rax
			//   __int64 v125; // rdx
			//   int v126; // eax
			//   __int128 v127; // xmm1
			//   __int128 v128; // xmm2
			//   __int128 v129; // xmm3
			//   Color inscatterAmbientColor; // xmm4
			//   struct MethodInfo *v131; // rcx
			//   unsigned int v132; // r8d
			//   __int64 v133; // rdi
			//   unsigned int v134; // eax
			//   unsigned int v135; // r8d
			//   unsigned int v136; // eax
			//   __int64 v137; // rax
			//   __int64 v138; // rax
			//   Color v139; // xmm1
			//   __int128 v140; // xmm0
			//   __int128 v141; // xmm1
			//   __int128 v142; // xmm0
			//   __int128 v143; // xmm1
			//   __int128 v144; // xmm0
			//   __int128 v145; // xmm1
			//   __int128 v146; // xmm0
			//   __int128 v147; // xmm1
			//   __int128 v148; // xmm0
			//   __int128 v149; // xmm1
			//   Color v150; // xmm1
			//   __int128 v151; // xmm0
			//   __int128 v152; // xmm1
			//   __int128 v153; // xmm0
			//   __int128 v154; // xmm1
			//   __int128 v155; // xmm0
			//   __int128 v156; // xmm1
			//   __int128 v157; // xmm0
			//   __int128 v158; // xmm1
			//   __int128 v159; // xmm0
			//   __int128 v160; // xmm1
			//   __int64 v161; // rax
			//   struct MethodInfo *v162; // r13
			//   HGVolumetricFogConfig *p_volumetricFogConfig; // rdi
			//   HGVolumetricFogConfig *v164; // rbx
			//   signed __int64 v165; // rcx
			//   __int64 v166; // r14
			//   __int64 v167; // r8
			//   signed __int64 v168; // r9
			//   unsigned __int64 v169; // r8
			//   HGEnvironmentPhase__Class *v170; // rtt
			//   __int64 v171; // rbx
			//   __int64 v172; // rax
			//   __int64 v173; // rbx
			//   _QWORD *v174; // rax
			//   __int64 v175; // kr00_8
			//   __int64 v176; // rax
			//   __int64 v177; // rax
			//   __int64 v178; // r8
			//   signed __int64 v179; // r9
			//   unsigned __int64 v180; // r8
			//   HGEnvironmentPhase__Class *v181; // rtt
			//   __int64 v182; // rax
			//   __int128 *v183; // rax
			//   __int64 v184; // rcx
			//   __int128 v185; // xmm0
			//   __int128 v186; // xmm1
			//   __int128 v187; // xmm0
			//   __int128 v188; // xmm1
			//   __int128 v189; // xmm0
			//   __int128 v190; // xmm1
			//   __int128 v191; // xmm0
			//   __int128 v192; // xmm1
			//   __int128 *v193; // rax
			//   __int64 v194; // rcx
			//   __int128 v195; // xmm0
			//   __int128 v196; // xmm1
			//   __int128 v197; // xmm0
			//   __int128 v198; // xmm1
			//   __int128 v199; // xmm0
			//   __int128 v200; // xmm1
			//   __int128 v201; // xmm0
			//   __int128 v202; // xmm1
			//   struct MethodInfo *v203; // r14
			//   signed __int64 v204; // rcx
			//   __int64 v205; // rbx
			//   __int64 v206; // rax
			//   __int64 v207; // r8
			//   signed __int64 v208; // r9
			//   unsigned __int64 v209; // r8
			//   HGEnvironmentPhase__Class *v210; // rtt
			//   __int64 v211; // rax
			//   signed __int64 v212; // r9
			//   Color cloudTint; // xmm1
			//   __int128 v214; // xmm0
			//   __int128 v215; // xmm1
			//   __int128 v216; // xmm0
			//   __int128 v217; // xmm1
			//   __int128 v218; // xmm0
			//   __int128 v219; // xmm1
			//   __int128 v220; // xmm0
			//   __int128 v221; // xmm1
			//   __int128 v222; // xmm0
			//   Color v223; // xmm1
			//   __int128 v224; // xmm0
			//   __int128 v225; // xmm1
			//   __int128 v226; // xmm0
			//   __int128 v227; // xmm1
			//   __int128 v228; // xmm0
			//   __int128 v229; // xmm1
			//   __int128 v230; // xmm0
			//   __int128 v231; // xmm1
			//   __int128 v232; // xmm0
			//   HGEnvironmentPhase__Class *v233; // rtt
			//   struct MethodInfo *v234; // r14
			//   HGCelestialConfig *p_celestialConfig; // rbx
			//   signed __int64 v236; // rcx
			//   __int64 v237; // rdi
			//   __int64 v238; // rax
			//   __int64 v239; // r8
			//   unsigned __int64 v240; // r8
			//   HGEnvironmentPhase__Class *v241; // rtt
			//   __int64 v242; // rax
			//   __int128 *v243; // rcx
			//   __int64 v244; // rax
			//   __int128 v245; // xmm0
			//   __int128 v246; // xmm1
			//   __int128 v247; // xmm0
			//   __int128 v248; // xmm1
			//   __int128 v249; // xmm0
			//   __int128 v250; // xmm1
			//   __int128 v251; // xmm0
			//   __int128 v252; // xmm1
			//   Material *drawMaterial; // rax
			//   __int128 v254; // xmm1
			//   __int128 v255; // xmm0
			//   __int128 v256; // xmm1
			//   __int128 v257; // xmm0
			//   __int128 v258; // xmm1
			//   HGCelestialConfig *v259; // rcx
			//   __int128 *v260; // rax
			//   __int128 v261; // xmm0
			//   __int128 v262; // xmm1
			//   __int128 v263; // xmm0
			//   __int128 v264; // xmm1
			//   __int128 v265; // xmm0
			//   __int128 v266; // xmm1
			//   __int128 v267; // xmm0
			//   __int128 v268; // xmm1
			//   __int128 v269; // xmm1
			//   __int128 v270; // xmm0
			//   __int128 v271; // xmm1
			//   __int128 v272; // xmm0
			//   __int128 v273; // xmm1
			//   Material *v274; // rax
			//   HGEnvironmentPhase__Class *v275; // rtt
			//   struct MethodInfo *v276; // rdi
			//   signed __int64 v277; // rcx
			//   __int64 v278; // rbx
			//   __int64 v279; // rax
			//   __int64 v280; // r8
			//   unsigned __int64 v281; // r8
			//   HGEnvironmentPhase__Class *v282; // rtt
			//   __int64 v283; // rax
			//   int v284; // eax
			//   __int64 v285; // xmm0_8
			//   struct MethodInfo *v286; // rdi
			//   signed __int64 v287; // rcx
			//   __int64 v288; // rbx
			//   __int64 v289; // rax
			//   unsigned __int64 v290; // r8
			//   HGEnvironmentPhase__Class *v291; // rtt
			//   __int64 v292; // rax
			//   int v293; // eax
			//   Color bloomTint; // xmm1
			//   __int128 v295; // xmm2
			//   struct MethodInfo *v296; // rdi
			//   signed __int64 v297; // rcx
			//   __int64 v298; // rbx
			//   __int64 v299; // rax
			//   __int64 v300; // r8
			//   unsigned __int64 v301; // r8
			//   HGEnvironmentPhase__Class *v302; // rtt
			//   __int64 v303; // rax
			//   int v304; // eax
			//   struct MethodInfo *v305; // rdi
			//   signed __int64 v306; // rcx
			//   __int64 v307; // rbx
			//   __int64 v308; // rax
			//   __int64 v309; // r8
			//   unsigned __int64 v310; // r8
			//   HGEnvironmentPhase__Class *v311; // rtt
			//   __int64 v312; // rax
			//   __int64 v313; // xmm0_8
			//   HGEnvironmentPhase__Class *v314; // rtt
			//   struct MethodInfo *v315; // r13
			//   HGRainConfig *p_rainConfig; // rbx
			//   HGRainConfig *v317; // rdi
			//   signed __int64 v318; // rcx
			//   __int64 v319; // r14
			//   __int64 v320; // rax
			//   __int64 v321; // r8
			//   unsigned __int64 v322; // r8
			//   HGEnvironmentPhase__Class *v323; // rtt
			//   __int64 v324; // rax
			//   __int128 *v325; // rax
			//   __int64 v326; // rcx
			//   __int128 v327; // xmm0
			//   __int128 v328; // xmm1
			//   __int128 v329; // xmm0
			//   __int128 v330; // xmm1
			//   __int128 v331; // xmm0
			//   __int128 v332; // xmm1
			//   __int128 v333; // xmm0
			//   __int128 v334; // xmm1
			//   __int128 v335; // xmm1
			//   __int128 v336; // xmm0
			//   __int128 *v337; // rax
			//   __int128 v338; // xmm0
			//   __int128 v339; // xmm1
			//   __int128 v340; // xmm0
			//   __int128 v341; // xmm1
			//   __int128 v342; // xmm0
			//   __int128 v343; // xmm1
			//   __int128 v344; // xmm0
			//   __int128 v345; // xmm1
			//   __int128 v346; // xmm1
			//   __int128 v347; // xmm0
			//   struct MethodInfo *v348; // rdi
			//   signed __int64 v349; // rcx
			//   __int64 v350; // rbx
			//   __int64 v351; // rax
			//   __int64 v352; // r8
			//   unsigned __int64 v353; // r8
			//   HGEnvironmentPhase__Class *v354; // rtt
			//   __int64 v355; // rax
			//   __int128 v356; // xmm2
			//   __int128 v357; // xmm3
			//   __int128 v358; // xmm4
			//   __int64 v359; // xmm0_8
			//   __int64 *v360; // rdx
			//   struct MethodInfo *v361; // rdi
			//   signed __int64 v362; // rcx
			//   __int64 v363; // rbx
			//   __int64 v364; // rax
			//   __int64 v365; // r8
			//   signed __int64 v366; // r9
			//   unsigned __int64 v367; // r8
			//   __int64 v368; // rtt
			//   __int64 v369; // rax
			//   __int128 v370; // xmm1
			//   __int128 v371; // xmm2
			//   __int64 *v372; // rdx
			//   __int64 v373; // rtt
			//   OneofDescriptorProto *v374; // rdx
			//   struct MethodInfo *v375; // rdi
			//   signed __int64 v376; // rcx
			//   __int64 v377; // rbx
			//   __int64 v378; // rax
			//   __int64 v379; // r8
			//   signed __int64 v380; // r9
			//   unsigned __int64 v381; // r8
			//   OneofDescriptorProto__Class *v382; // rtt
			//   __int64 v383; // rax
			//   int v384; // eax
			//   __int128 v385; // xmm2
			//   __int128 v386; // xmm3
			//   __int64 v387; // xmm0_8
			//   struct MethodInfo *v388; // rdi
			//   signed __int64 v389; // rcx
			//   __int64 v390; // rbx
			//   __int64 v391; // rax
			//   __int64 v392; // r8
			//   signed __int64 v393; // r9
			//   unsigned __int64 v394; // r8
			//   OneofDescriptorProto__Class *v395; // rtt
			//   __int64 v396; // rax
			//   __int128 v397; // xmm2
			//   __int128 v398; // xmm3
			//   __int128 v399; // xmm4
			//   __int128 v400; // xmm5
			//   __int128 v401; // xmm6
			//   __int64 v402; // xmm0_8
			//   OneofDescriptorProto__Class *v403; // rtt
			//   struct MethodInfo *v404; // rdi
			//   unsigned int v405; // r12d
			//   __int64 v406; // rbx
			//   __int64 v407; // rax
			//   __int64 v408; // r8
			//   FileDescriptor *v409; // r8
			//   MessageDescriptor *v410; // r9
			//   __int64 v411; // r9
			//   __int64 v412; // rax
			//   Color v413; // xmm1
			//   __int128 v414; // xmm2
			//   String__Array *v415; // [rsp+20h] [rbp-E0h]
			//   String *v416; // [rsp+28h] [rbp-D8h]
			//   MethodInfo *v417; // [rsp+30h] [rbp-D0h] BYREF
			//   int v418; // [rsp+40h] [rbp-C0h] BYREF
			//   int v419; // [rsp+50h] [rbp-B0h] BYREF
			//   __int128 v420; // [rsp+60h] [rbp-A0h] BYREF
			//   Color v421; // [rsp+70h] [rbp-90h]
			//   __int128 v422; // [rsp+80h] [rbp-80h]
			//   __int128 v423; // [rsp+90h] [rbp-70h]
			//   __int128 v424; // [rsp+A0h] [rbp-60h]
			//   __int128 v425; // [rsp+B0h] [rbp-50h]
			//   __int128 v426; // [rsp+C0h] [rbp-40h]
			//   __int128 v427; // [rsp+D0h] [rbp-30h]
			//   __int128 v428; // [rsp+E0h] [rbp-20h]
			//   __int128 v429; // [rsp+F0h] [rbp-10h]
			//   __int128 v430; // [rsp+100h] [rbp+0h]
			//   __int128 v431; // [rsp+110h] [rbp+10h]
			//   __int64 v432; // [rsp+120h] [rbp+20h]
			//   struct MethodInfo *v433; // [rsp+258h] [rbp+158h] BYREF
			// 
			//   v3 = src;
			//   if ( !byte_18D8EDC45 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGAnamorphicStreaksConfig>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGAtmosphereConfig>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGAutoExposureConfig>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGCelestialConfig>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGCloudConfig>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGColorGradingConfig>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGFogConfig>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGHeightFogConfig>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGInkSimulationConfig>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGLensFlareConfig>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGLightConfig>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGLightShaftConfig>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGRainConfig>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGShadowConfig>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGSkyConfig>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGSnowConfig>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGStarConfig>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGTerrainDeformConfig>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGVolumetricFogConfig>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGWindConfig>);
			//     byte_18D8EDC45 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, src);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v5.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     sub_180B536AC(v5, src);
			//   if ( wrapperArray.max_length.size <= 589 )
			//     goto LABEL_16;
			//   if ( !v5._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v5, src);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v7 = v5.static_fields.wrapperArray;
			//   if ( !v7 )
			//     sub_180B536AC(v5, src);
			//   if ( v7.max_length.size <= 0x24Du )
			//     sub_180070270(v5, src);
			//   if ( v7[16].vector[13] )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(589, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v10, v9);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)v3,
			//       0LL);
			//   }
			//   else
			//   {
			// LABEL_16:
			//     p_lightConfig = &this.fields.lightConfig;
			//     if ( !v3 )
			//       sub_180B536AC(v5, src);
			//     v12 = (__int128 *)&v3.fields.lightConfig;
			//     v13 = MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGLightConfig>;
			//     if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGLightConfig>.rgctx_data )
			//     {
			//       sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGLightConfig);
			//       if ( !v13.rgctx_data )
			//         sub_180041F40(v13);
			//     }
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGLightConfig._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGLightConfig, src);
			//     if ( v3.fields.lightConfig.m_active )
			//     {
			//       v14 = &v420;
			//       v15 = 2LL;
			//       do
			//       {
			//         v14 += 8;
			//         v16 = *v12;
			//         v17 = v12[1];
			//         v12 += 8;
			//         *(v14 - 8) = v16;
			//         v18 = *(v12 - 6);
			//         *(v14 - 7) = v17;
			//         v19 = *(v12 - 5);
			//         *(v14 - 6) = v18;
			//         v20 = *(v12 - 4);
			//         *(v14 - 5) = v19;
			//         v21 = *(v12 - 3);
			//         *(v14 - 4) = v20;
			//         v22 = *(v12 - 2);
			//         *(v14 - 3) = v21;
			//         v23 = *(v12 - 1);
			//         *(v14 - 2) = v22;
			//         *(v14 - 1) = v23;
			//         --v15;
			//       }
			//       while ( v15 );
			//       v24 = 2LL;
			//       v25 = v12[1];
			//       *v14 = *v12;
			//       v26 = v12[2];
			//       v14[1] = v25;
			//       v27 = v12[3];
			//       v14[2] = v26;
			//       v28 = v12[4];
			//       v14[3] = v27;
			//       v29 = v12[5];
			//       v14[4] = v28;
			//       v14[5] = v29;
			//       v30 = (Color *)&v420;
			//       do
			//       {
			//         p_lightConfig = (HGLightConfig *)((char *)p_lightConfig + 128);
			//         v31 = *v30;
			//         v32 = v30[1];
			//         v30 += 8;
			//         *(Color *)&p_lightConfig[-1].localToWorld.m12 = v31;
			//         v33 = v30[-6];
			//         *(Color *)&p_lightConfig[-1].localToWorld.m13 = v32;
			//         v34 = v30[-5];
			//         *(Color *)&p_lightConfig[-1].rotationAtmosphere.y = v33;
			//         v35 = v30[-4];
			//         *(Color *)&p_lightConfig[-1].rotationLightShaft.y = v34;
			//         v36 = v30[-3];
			//         *(Color *)&p_lightConfig[-1].rotationSunDisc.y = v35;
			//         v37 = v30[-2];
			//         *(Color *)&p_lightConfig[-1].rotationLensFlare.y = v36;
			//         v38 = v30[-1];
			//         *(Color *)&p_lightConfig[-1].rotationCloudShadow.y = v37;
			//         *(Color *)&p_lightConfig[-1].rotationHeightFogDirectionalInscattering.y = v38;
			//         --v24;
			//       }
			//       while ( v24 );
			//       v39 = v30[1];
			//       p_lightConfig.directColor = *v30;
			//       v40 = v30[2];
			//       *(Color *)&p_lightConfig.directColorMode = v39;
			//       v41 = v30[3];
			//       *(Color *)&p_lightConfig.directCustomColor.a = v40;
			//       v42 = v30[4];
			//       *(Color *)&p_lightConfig.directSpecularIntensity = v41;
			//       v43 = v30[5];
			//       *(Color *)&p_lightConfig.indirectDiffuseFactor = v42;
			//       *(Color *)&p_lightConfig.atmospherePitchYaw.x = v43;
			//     }
			//     v44 = MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGSkyConfig>;
			//     p_skyConfig = &v3.fields.skyConfig;
			//     if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGSkyConfig>.rgctx_data )
			//     {
			//       sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGSkyConfig);
			//       if ( !v44.rgctx_data )
			//         sub_180041F40(v44);
			//     }
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGSkyConfig._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGSkyConfig, src);
			//     if ( v3.fields.skyConfig.m_active )
			//     {
			//       v46 = &v420;
			//       v47 = 2LL;
			//       do
			//       {
			//         v46 += 8;
			//         v48 = *(_OWORD *)&p_skyConfig.parentEnvPhaseGuid;
			//         v49 = *(_OWORD *)&p_skyConfig.skyDirectIntensity;
			//         p_skyConfig = (HGSkyConfig *)((char *)p_skyConfig + 128);
			//         *(v46 - 8) = v48;
			//         v50 = *(_OWORD *)&p_skyConfig[-1].skyAmbientSH.shr7;
			//         *(v46 - 7) = v49;
			//         v51 = *(_OWORD *)&p_skyConfig[-1].skyAmbientSH.shg2;
			//         *(v46 - 6) = v50;
			//         v52 = *(_OWORD *)&p_skyConfig[-1].skyAmbientSH.shg6;
			//         *(v46 - 5) = v51;
			//         v53 = *(_OWORD *)&p_skyConfig[-1].skyAmbientSH.shb1;
			//         *(v46 - 4) = v52;
			//         v54 = *(_OWORD *)&p_skyConfig[-1].skyAmbientSH.shb5;
			//         *(v46 - 3) = v53;
			//         v55 = *(_OWORD *)&p_skyConfig[-1].skyboxCubeMap;
			//         *(v46 - 2) = v54;
			//         *(v46 - 1) = v55;
			//         --v47;
			//       }
			//       while ( v47 );
			//       v56 = *(_QWORD *)&p_skyConfig.customIVDefaultSH.shg5;
			//       src = (HGEnvironmentPhase *)2;
			//       v57 = *(_OWORD *)&p_skyConfig.skyDirectIntensity;
			//       *v46 = *(_OWORD *)&p_skyConfig.parentEnvPhaseGuid;
			//       v58 = *(_OWORD *)&p_skyConfig.customIVDefaultSH.shr2;
			//       v46[1] = v57;
			//       v59 = *(_OWORD *)&p_skyConfig.customIVDefaultSH.shr6;
			//       v46[2] = v58;
			//       v60 = *(_OWORD *)&p_skyConfig.customIVDefaultSH.shg1;
			//       v46[3] = v59;
			//       v46[4] = v60;
			//       *((_QWORD *)v46 + 10) = v56;
			//       v61 = &this.fields.skyConfig;
			//       v62 = &v420;
			//       do
			//       {
			//         v61 = (HGSkyConfig *)((char *)v61 + 128);
			//         v63 = *v62;
			//         v64 = v62[1];
			//         v62 += 8;
			//         *(_OWORD *)&v61[-1].culloff = v63;
			//         v65 = *(v62 - 6);
			//         *(_OWORD *)&v61[-1].skyAmbientSH.shr3 = v64;
			//         v66 = *(v62 - 5);
			//         *(_OWORD *)&v61[-1].skyAmbientSH.shr7 = v65;
			//         v67 = *(v62 - 4);
			//         *(_OWORD *)&v61[-1].skyAmbientSH.shg2 = v66;
			//         v68 = *(v62 - 3);
			//         *(_OWORD *)&v61[-1].skyAmbientSH.shg6 = v67;
			//         v69 = *(v62 - 2);
			//         *(_OWORD *)&v61[-1].skyAmbientSH.shb1 = v68;
			//         v70 = *(v62 - 1);
			//         *(_OWORD *)&v61[-1].skyAmbientSH.shb5 = v69;
			//         *(_OWORD *)&v61[-1].skyboxCubeMap = v70;
			//         src = (HGEnvironmentPhase *)((char *)src - 1);
			//       }
			//       while ( src );
			//       v71 = dword_18D8E43F8 == 0;
			//       v72 = v62[1];
			//       *(_OWORD *)&v61.parentEnvPhaseGuid = *v62;
			//       v73 = v62[2];
			//       *(_OWORD *)&v61.skyDirectIntensity = v72;
			//       v74 = v62[3];
			//       *(_OWORD *)&v61.customIVDefaultSH.shr2 = v73;
			//       v75 = v62[4];
			//       v76 = *((_QWORD *)v62 + 10);
			//       *(_OWORD *)&v61.customIVDefaultSH.shr6 = v74;
			//       *(_OWORD *)&v61.customIVDefaultSH.shg1 = v75;
			//       *(_QWORD *)&v61.customIVDefaultSH.shg5 = v76;
			//       if ( !v71 )
			//       {
			//         src = (HGEnvironmentPhase *)&qword_18D6870D0[(((unsigned __int64)&this.fields.skyConfig >> 12) & 0x1FFFFF) >> 6];
			//         _m_prefetchw(src);
			//         do
			//           klass = src.klass;
			//         while ( klass != (HGEnvironmentPhase__Class *)_InterlockedCompareExchange64(
			//                                                         (volatile signed __int64 *)src,
			//                                                         (__int64)src.klass | (1LL << (((unsigned __int64)&this.fields.skyConfig >> 12) & 0x3F)),
			//                                                         (signed __int64)src.klass) );
			//       }
			//     }
			//     v78 = MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGAtmosphereConfig>;
			//     v79 = off_18A2C5600;
			//     if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGAtmosphereConfig>.rgctx_data )
			//     {
			//       v80 = _InterlockedExchangeAdd64(
			//               (volatile signed __int64 *)&TypeInfo::HG::Rendering::Runtime::HGAtmosphereConfig,
			//               0LL);
			//       if ( (v80 & 1) != 0 )
			//       {
			//         v81 = (v80 >> 1) & 0xFFFFFFF;
			//         switch ( v80 >> 29 )
			//         {
			//           case 1u:
			//             src = (HGEnvironmentPhase *)sub_18003C670((unsigned int)v81);
			//             goto LABEL_69;
			//           case 2u:
			//             src = (HGEnvironmentPhase *)sub_18003C380((unsigned int)v81);
			//             goto LABEL_69;
			//           case 3u:
			//           case 6u:
			//             v82 = v80;
			//             v83 = v80 >> 29;
			//             v84 = (v82 >> 1) & 0xFFFFFFF;
			//             if ( v83 )
			//             {
			//               if ( v83 == 3 )
			//               {
			//                 src = (HGEnvironmentPhase *)sub_180039480(v84);
			//                 goto LABEL_69;
			//               }
			//               if ( v83 == 6 )
			//               {
			//                 v85 = sub_1802DF9C0(v84);
			//                 src = (HGEnvironmentPhase *)sub_18005F4B0(v85, 0LL);
			//                 goto LABEL_69;
			//               }
			//             }
			//             else if ( v84 == 1 )
			//             {
			//               src = (HGEnvironmentPhase *)off_18A2C5600;
			//               goto LABEL_69;
			//             }
			// LABEL_68:
			//             src = 0LL;
			// LABEL_69:
			//             if ( src )
			//               src = (HGEnvironmentPhase *)_InterlockedExchange64(
			//                                             (volatile __int64 *)&TypeInfo::HG::Rendering::Runtime::HGAtmosphereConfig,
			//                                             (__int64)src);
			//             break;
			//           case 4u:
			//             src = (HGEnvironmentPhase *)sub_1802DF920((unsigned int)v81);
			//             goto LABEL_69;
			//           case 5u:
			//             v86 = 8 * v81;
			//             if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v81) )
			//             {
			//               src = *(HGEnvironmentPhase **)(v86 + qword_18D8F6F98);
			//             }
			//             else
			//             {
			//               v87 = (HGEnvironmentPhase *)il2cpp_string_new_len(
			//                                             qword_18D8E5198
			//                                           + *(int *)(qword_18D8E51A0 + 16)
			//                                           + *(int *)(v86 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198 + 4),
			//                                             *(unsigned int *)(v86 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198));
			//               src = (HGEnvironmentPhase *)_InterlockedCompareExchange64(
			//                                             (volatile signed __int64 *)(qword_18D8F6F98 + 8 * v81),
			//                                             (signed __int64)v87,
			//                                             0LL);
			//               if ( !src )
			//               {
			//                 if ( dword_18D8E43F8 )
			//                 {
			//                   v88 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v81) >> 12) & 0x3F;
			//                   v89 = &qword_18D6870D0[(((unsigned __int64)(qword_18D8F6F98 + 8 * v81) >> 12) & 0x1FFFFF) >> 6];
			//                   _m_prefetchw(v89);
			//                   do
			//                     v90 = *v89;
			//                   while ( v90 != _InterlockedCompareExchange64(v89, *v89 | (1LL << v88), *v89) );
			//                 }
			//                 src = v87;
			//               }
			//             }
			//             goto LABEL_69;
			//           case 7u:
			//             v91 = sub_1802DF920((unsigned int)v81);
			//             v92 = *(_QWORD *)(v91 + 16);
			//             v93 = (v91 - *(_QWORD *)(v92 + 128)) >> 5;
			//             if ( *(_BYTE *)(v92 + 42) == 21 )
			//             {
			//               v94 = *(_QWORD ***)(v92 + 96);
			//               if ( *v94 )
			//               {
			//                 v95 = **v94 - *(int *)(qword_18D8E51A0 + 160) - qword_18D8E5198;
			//                 v92 = sub_180039550(v95 / 92 + v95);
			//               }
			//               else
			//               {
			//                 v92 = 0LL;
			//               }
			//             }
			//             v418 = v93 + *(_DWORD *)(*(_QWORD *)(v92 + 104) + 32LL);
			//             v96 = sub_1801B8ECC(
			//                     (unsigned int)&v418,
			//                     (int)qword_18D8E5198 + *(_DWORD *)(qword_18D8E51A0 + 64),
			//                     *(int *)(qword_18D8E51A0 + 68) / 0xCuLL,
			//                     12,
			//                     (__int64)sub_1802C7760);
			//             if ( !v96 )
			//               goto LABEL_68;
			//             v97 = *(unsigned int *)(v96 + 8);
			//             if ( (_DWORD)v97 == -1 )
			//               goto LABEL_68;
			//             src = (HGEnvironmentPhase *)(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 72) + v97);
			//             goto LABEL_69;
			//           default:
			//             break;
			//         }
			//       }
			//       if ( !v78.rgctx_data )
			//         sub_180041F40(v78);
			//     }
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGAtmosphereConfig._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGAtmosphereConfig, src);
			//     if ( v3.fields.atmosphereConfig.m_active )
			//     {
			//       v98 = *(_OWORD *)&v3.fields.atmosphereConfig.mieAbsorption.g;
			//       v99 = *(_OWORD *)&v3.fields.atmosphereConfig.mieExponentialDistribution;
			//       v100 = *(_OWORD *)&v3.fields.atmosphereConfig.ozoneAbsorption.b;
			//       v101 = *(_OWORD *)&v3.fields.atmosphereConfig.groundAlbedo.a;
			//       v102 = *(_OWORD *)&v3.fields.atmosphereConfig.outerSunIrradianceColor.a;
			//       rayleighScattering = v3.fields.atmosphereConfig.rayleighScattering;
			//       v104 = *(_OWORD *)&v3.fields.atmosphereConfig.rayleighExponentialDistribution;
			//       v105 = *(_OWORD *)&v3.fields.atmosphereConfig.mieScattering.b;
			//       v106 = *(_QWORD *)&v3.fields.atmosphereConfig.tentWidth;
			//       *(_OWORD *)&this.fields.atmosphereConfig.groundRadius = *(_OWORD *)&v3.fields.atmosphereConfig.groundRadius;
			//       *(_OWORD *)&this.fields.atmosphereConfig.groundAlbedo.a = v101;
			//       *(_OWORD *)&this.fields.atmosphereConfig.outerSunIrradianceColor.a = v102;
			//       this.fields.atmosphereConfig.rayleighScattering = rayleighScattering;
			//       *(_OWORD *)&this.fields.atmosphereConfig.rayleighExponentialDistribution = v104;
			//       *(_OWORD *)&this.fields.atmosphereConfig.mieScattering.b = v105;
			//       *(_OWORD *)&this.fields.atmosphereConfig.mieAbsorption.g = v98;
			//       *(_OWORD *)&this.fields.atmosphereConfig.mieExponentialDistribution = v99;
			//       *(_OWORD *)&this.fields.atmosphereConfig.ozoneAbsorption.b = v100;
			//       *(_QWORD *)&this.fields.atmosphereConfig.tentWidth = v106;
			//     }
			//     v107 = MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGFogConfig>;
			//     if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGFogConfig>.rgctx_data )
			//     {
			//       v108 = _InterlockedExchangeAdd64((volatile signed __int64 *)&TypeInfo::HG::Rendering::Runtime::HGFogConfig, 0LL);
			//       if ( (v108 & 1) != 0 )
			//       {
			//         v109 = (v108 >> 1) & 0xFFFFFFF;
			//         switch ( v108 >> 29 )
			//         {
			//           case 1u:
			//             src = (HGEnvironmentPhase *)sub_18003C670((unsigned int)v109);
			//             goto LABEL_105;
			//           case 2u:
			//             src = (HGEnvironmentPhase *)sub_18003C380((unsigned int)v109);
			//             goto LABEL_105;
			//           case 3u:
			//           case 6u:
			//             v110 = v108;
			//             v111 = v108 >> 29;
			//             v112 = (v110 >> 1) & 0xFFFFFFF;
			//             if ( v111 )
			//             {
			//               if ( v111 == 3 )
			//               {
			//                 src = (HGEnvironmentPhase *)sub_180039480(v112);
			//                 goto LABEL_105;
			//               }
			//               if ( v111 == 6 )
			//               {
			//                 v113 = sub_1802DF9C0(v112);
			//                 src = (HGEnvironmentPhase *)sub_18005F4B0(v113, 0LL);
			//                 goto LABEL_105;
			//               }
			//             }
			//             else if ( v112 == 1 )
			//             {
			//               src = (HGEnvironmentPhase *)off_18A2C5600;
			//               goto LABEL_105;
			//             }
			// LABEL_104:
			//             src = 0LL;
			// LABEL_105:
			//             if ( src )
			//               src = (HGEnvironmentPhase *)_InterlockedExchange64(
			//                                             (volatile __int64 *)&TypeInfo::HG::Rendering::Runtime::HGFogConfig,
			//                                             (__int64)src);
			//             break;
			//           case 4u:
			//             src = (HGEnvironmentPhase *)sub_1802DF920((unsigned int)v109);
			//             goto LABEL_105;
			//           case 5u:
			//             v114 = 8 * v109;
			//             if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v109) )
			//             {
			//               src = *(HGEnvironmentPhase **)(v114 + qword_18D8F6F98);
			//             }
			//             else
			//             {
			//               v115 = (HGEnvironmentPhase *)il2cpp_string_new_len(
			//                                              qword_18D8E5198
			//                                            + *(int *)(v114 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198 + 4)
			//                                            + *(int *)(qword_18D8E51A0 + 16),
			//                                              *(unsigned int *)(v114 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198));
			//               src = (HGEnvironmentPhase *)_InterlockedCompareExchange64(
			//                                             (volatile signed __int64 *)(qword_18D8F6F98 + 8 * v109),
			//                                             (signed __int64)v115,
			//                                             0LL);
			//               if ( !src )
			//               {
			//                 if ( dword_18D8E43F8 )
			//                 {
			//                   v116 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v109) >> 12) & 0x3F;
			//                   v117 = &qword_18D6870D0[(((unsigned __int64)(qword_18D8F6F98 + 8 * v109) >> 12) & 0x1FFFFF) >> 6];
			//                   _m_prefetchw(v117);
			//                   do
			//                     v118 = *v117;
			//                   while ( v118 != _InterlockedCompareExchange64(v117, *v117 | (1LL << v116), *v117) );
			//                 }
			//                 src = v115;
			//               }
			//             }
			//             goto LABEL_105;
			//           case 7u:
			//             v119 = sub_1802DF920((unsigned int)v109);
			//             v120 = *(_QWORD *)(v119 + 16);
			//             v121 = (v119 - *(_QWORD *)(v120 + 128)) >> 5;
			//             if ( *(_BYTE *)(v120 + 42) == 21 )
			//             {
			//               v122 = *(_QWORD ***)(v120 + 96);
			//               if ( *v122 )
			//               {
			//                 v123 = **v122 - *(int *)(qword_18D8E51A0 + 160) - qword_18D8E5198;
			//                 v120 = sub_180039550(v123 / 92 + v123);
			//               }
			//               else
			//               {
			//                 v120 = 0LL;
			//               }
			//             }
			//             v419 = v121 + *(_DWORD *)(*(_QWORD *)(v120 + 104) + 32LL);
			//             v124 = sub_1801B8ECC(
			//                      (unsigned int)&v419,
			//                      (int)qword_18D8E5198 + *(_DWORD *)(qword_18D8E51A0 + 64),
			//                      *(int *)(qword_18D8E51A0 + 68) / 0xCuLL,
			//                      12,
			//                      (__int64)sub_1802C7760);
			//             if ( !v124 )
			//               goto LABEL_104;
			//             v125 = *(unsigned int *)(v124 + 8);
			//             if ( (_DWORD)v125 == -1 )
			//               goto LABEL_104;
			//             src = (HGEnvironmentPhase *)(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 72) + v125);
			//             goto LABEL_105;
			//           default:
			//             break;
			//         }
			//       }
			//       if ( !v107.rgctx_data )
			//         sub_180041F40(v107);
			//     }
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGFogConfig._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGFogConfig, src);
			//     if ( v3.fields.fogConfig.m_active )
			//     {
			//       v126 = *(_DWORD *)&v3.fields.fogConfig.m_active;
			//       v127 = *(_OWORD *)&v3.fields.fogConfig.fallOffDistance;
			//       v128 = *(_OWORD *)&v3.fields.fogConfig.mieScattering.a;
			//       v129 = *(_OWORD *)&v3.fields.fogConfig.rayleighScattering.g;
			//       inscatterAmbientColor = v3.fields.fogConfig.inscatterAmbientColor;
			//       *(_OWORD *)&this.fields.fogConfig.enable = *(_OWORD *)&v3.fields.fogConfig.enable;
			//       *(_OWORD *)&this.fields.fogConfig.fallOffDistance = v127;
			//       *(_OWORD *)&this.fields.fogConfig.mieScattering.a = v128;
			//       *(_OWORD *)&this.fields.fogConfig.rayleighScattering.g = v129;
			//       this.fields.fogConfig.inscatterAmbientColor = inscatterAmbientColor;
			//       *(_DWORD *)&this.fields.fogConfig.m_active = v126;
			//     }
			//     v131 = MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGHeightFogConfig>;
			//     v433 = MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGHeightFogConfig>;
			//     if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGHeightFogConfig>.rgctx_data )
			//     {
			//       v132 = _InterlockedExchangeAdd64(
			//                (volatile signed __int64 *)&TypeInfo::HG::Rendering::Runtime::HGHeightFogConfig,
			//                0LL);
			//       if ( (v132 & 1) != 0 )
			//       {
			//         v133 = (v132 >> 1) & 0xFFFFFFF;
			//         switch ( v132 >> 29 )
			//         {
			//           case 1u:
			//             v79 = (void (__fastcall __noreturn **)())sub_18003C670((unsigned int)v133);
			//             goto LABEL_125;
			//           case 2u:
			//             v79 = (void (__fastcall __noreturn **)())sub_18003C380((unsigned int)v133);
			//             goto LABEL_125;
			//           case 3u:
			//           case 6u:
			//             v134 = v132;
			//             v135 = v132 >> 29;
			//             v136 = (v134 >> 1) & 0xFFFFFFF;
			//             if ( v135 )
			//             {
			//               if ( v135 == 3 )
			//               {
			//                 v79 = (void (__fastcall __noreturn **)())sub_180039480(v136);
			//                 goto LABEL_125;
			//               }
			//               if ( v135 == 6 )
			//               {
			//                 v137 = sub_1802DF9C0(v136);
			//                 v79 = (void (__fastcall __noreturn **)())sub_18005F4B0(v137, 0LL);
			//                 goto LABEL_125;
			//               }
			//             }
			//             else if ( v136 == 1 )
			//             {
			//               goto LABEL_125;
			//             }
			// LABEL_124:
			//             v79 = 0LL;
			// LABEL_125:
			//             v131 = v433;
			//             if ( v79 )
			//               _InterlockedExchange64(
			//                 (volatile __int64 *)&TypeInfo::HG::Rendering::Runtime::HGHeightFogConfig,
			//                 (__int64)v79);
			//             break;
			//           case 4u:
			//             v79 = (void (__fastcall __noreturn **)())sub_1802DF920((unsigned int)v133);
			//             goto LABEL_125;
			//           case 5u:
			//             v167 = 8 * v133;
			//             if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v133) )
			//             {
			//               v79 = *(void (__fastcall __noreturn ***)())(v167 + qword_18D8F6F98);
			//             }
			//             else
			//             {
			//               v168 = il2cpp_string_new_len(
			//                        qword_18D8E5198
			//                      + *(int *)(v167 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198 + 4)
			//                      + *(int *)(qword_18D8E51A0 + 16),
			//                        *(unsigned int *)(v167 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198));
			//               v79 = (void (__fastcall __noreturn **)())_InterlockedCompareExchange64(
			//                                                          (volatile signed __int64 *)(qword_18D8F6F98 + 8 * v133),
			//                                                          v168,
			//                                                          0LL);
			//               if ( !v79 )
			//               {
			//                 if ( dword_18D8E43F8 )
			//                 {
			//                   v169 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v133) >> 12) & 0x3F;
			//                   src = (HGEnvironmentPhase *)&qword_18D6870D0[(((unsigned __int64)(qword_18D8F6F98 + 8 * v133) >> 12) & 0x1FFFFF) >> 6];
			//                   _m_prefetchw(src);
			//                   do
			//                     v170 = src.klass;
			//                   while ( v170 != (HGEnvironmentPhase__Class *)_InterlockedCompareExchange64(
			//                                                                  (volatile signed __int64 *)src,
			//                                                                  (__int64)src.klass | (1LL << v169),
			//                                                                  (signed __int64)src.klass) );
			//                 }
			//                 v79 = (void (__fastcall __noreturn **)())v168;
			//               }
			//             }
			//             goto LABEL_125;
			//           case 7u:
			//             v171 = sub_1802DF920((unsigned int)v133);
			//             v172 = *(_QWORD *)(v171 + 16);
			//             v173 = (v171 - *(_QWORD *)(v172 + 128)) >> 5;
			//             if ( *(_BYTE *)(v172 + 42) == 21 )
			//             {
			//               v174 = **(_QWORD ***)(v172 + 96);
			//               if ( v174 )
			//               {
			//                 v175 = *v174 - *(int *)(qword_18D8E51A0 + 160) - qword_18D8E5198;
			//                 v172 = sub_180039550(
			//                          v175 / 92
			//                        + ((unsigned __int64)(v175
			//                                            + ((unsigned __int128)(v175 * (__int128)(__int64)0xB21642C8590B2165uLL) >> 64)) >> 63));
			//               }
			//               else
			//               {
			//                 v172 = 0LL;
			//               }
			//             }
			//             LODWORD(v417) = v173 + *(_DWORD *)(*(_QWORD *)(v172 + 104) + 32LL);
			//             v176 = sub_1801B8ECC(
			//                      (unsigned int)&v417,
			//                      (int)qword_18D8E5198 + *(_DWORD *)(qword_18D8E51A0 + 64),
			//                      *(int *)(qword_18D8E51A0 + 68) / 0xCuLL,
			//                      12,
			//                      (__int64)sub_1802C7760);
			//             if ( !v176 )
			//               goto LABEL_124;
			//             src = (HGEnvironmentPhase *)*(unsigned int *)(v176 + 8);
			//             if ( (_DWORD)src == -1 )
			//               goto LABEL_124;
			//             v79 = (void (__fastcall __noreturn **)())((char *)src + qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 72));
			//             goto LABEL_125;
			//           default:
			//             break;
			//         }
			//       }
			//       if ( !v131.rgctx_data )
			//         sub_180041F40(v131);
			//     }
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGHeightFogConfig._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGHeightFogConfig, src);
			//     if ( v3.fields.heightFogConfig.m_active )
			//     {
			//       v138 = *(_QWORD *)&v3.fields.heightFogConfig.flowNoiseSpeed;
			//       v139 = *(Color *)&v3.fields.heightFogConfig.heightFogStartHeightSecond;
			//       v420 = *(_OWORD *)&v3.fields.heightFogConfig.enable;
			//       v140 = *(_OWORD *)&v3.fields.heightFogConfig.heightFogInscatter.g;
			//       v421 = v139;
			//       v141 = *(_OWORD *)&v3.fields.heightFogConfig.heightFogStartDistance;
			//       v422 = v140;
			//       v142 = *(_OWORD *)&v3.fields.heightFogConfig.heightFogCullingFarClipPlane;
			//       v423 = v141;
			//       v143 = *(_OWORD *)&v3.fields.heightFogConfig.heightFogDirectionalInscattering.g;
			//       v424 = v142;
			//       v144 = *(_OWORD *)&v3.fields.heightFogConfig.volumetricFogScatteringDistribution;
			//       v425 = v143;
			//       v145 = *(_OWORD *)&v3.fields.heightFogConfig.volumetricFogAlbedo.a;
			//       v426 = v144;
			//       v146 = *(_OWORD *)&v3.fields.heightFogConfig.volumetricFogEmissive.a;
			//       v427 = v145;
			//       v147 = *(_OWORD *)&v3.fields.heightFogConfig.volumetricFogNearFadeInDistance;
			//       v428 = v146;
			//       v148 = *(_OWORD *)&v3.fields.heightFogConfig.flowNoiseIntensity;
			//       v429 = v147;
			//       v149 = *(_OWORD *)&v3.fields.heightFogConfig.flowNoiseVerticalDirAngle;
			//       v430 = v148;
			//       v431 = v149;
			//       v432 = v138;
			//       v150 = v421;
			//       *(_OWORD *)&this.fields.heightFogConfig.enable = v420;
			//       v151 = v422;
			//       *(Color *)&this.fields.heightFogConfig.heightFogStartHeightSecond = v150;
			//       v152 = v423;
			//       *(_OWORD *)&this.fields.heightFogConfig.heightFogInscatter.g = v151;
			//       v153 = v424;
			//       *(_OWORD *)&this.fields.heightFogConfig.heightFogStartDistance = v152;
			//       v154 = v425;
			//       *(_OWORD *)&this.fields.heightFogConfig.heightFogCullingFarClipPlane = v153;
			//       v155 = v426;
			//       *(_OWORD *)&this.fields.heightFogConfig.heightFogDirectionalInscattering.g = v154;
			//       v156 = v427;
			//       *(_OWORD *)&this.fields.heightFogConfig.volumetricFogScatteringDistribution = v155;
			//       v157 = v428;
			//       *(_OWORD *)&this.fields.heightFogConfig.volumetricFogAlbedo.a = v156;
			//       v158 = v429;
			//       *(_OWORD *)&this.fields.heightFogConfig.volumetricFogEmissive.a = v157;
			//       v159 = v430;
			//       *(_OWORD *)&this.fields.heightFogConfig.volumetricFogNearFadeInDistance = v158;
			//       v160 = v431;
			//       v161 = v432;
			//       *(_OWORD *)&this.fields.heightFogConfig.flowNoiseIntensity = v159;
			//       *(_OWORD *)&this.fields.heightFogConfig.flowNoiseVerticalDirAngle = v160;
			//       *(_QWORD *)&this.fields.heightFogConfig.flowNoiseSpeed = v161;
			//     }
			//     v162 = MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGVolumetricFogConfig>;
			//     p_volumetricFogConfig = &this.fields.volumetricFogConfig;
			//     v164 = &v3.fields.volumetricFogConfig;
			//     if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGVolumetricFogConfig>.rgctx_data )
			//     {
			//       v165 = _InterlockedExchangeAdd64(
			//                (volatile signed __int64 *)&TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig,
			//                0LL);
			//       if ( (v165 & 1) != 0 )
			//       {
			//         v166 = ((unsigned int)v165 >> 1) & 0xFFFFFFF;
			//         switch ( (unsigned int)v165 >> 29 )
			//         {
			//           case 1u:
			//             v177 = sub_18003C670((unsigned int)v166);
			//             goto LABEL_163;
			//           case 2u:
			//             v177 = sub_18003C380((unsigned int)v166);
			//             goto LABEL_163;
			//           case 3u:
			//           case 6u:
			//             v177 = sub_1802DFAE0(v165);
			//             goto LABEL_163;
			//           case 4u:
			//             v177 = sub_1802DF920((unsigned int)v166);
			//             goto LABEL_163;
			//           case 5u:
			//             v178 = 8 * v166;
			//             if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v166) )
			//             {
			//               v177 = *(_QWORD *)(v178 + qword_18D8F6F98);
			//             }
			//             else
			//             {
			//               v179 = il2cpp_string_new_len(
			//                        qword_18D8E5198
			//                      + *(int *)(v178 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198 + 4)
			//                      + *(int *)(qword_18D8E51A0 + 16),
			//                        *(unsigned int *)(v178 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198));
			//               v177 = _InterlockedCompareExchange64((volatile signed __int64 *)(qword_18D8F6F98 + 8 * v166), v179, 0LL);
			//               if ( !v177 )
			//               {
			//                 if ( dword_18D8E43F8 )
			//                 {
			//                   v180 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v166) >> 12) & 0x3F;
			//                   src = (HGEnvironmentPhase *)&qword_18D6870D0[(((unsigned __int64)(qword_18D8F6F98 + 8 * v166) >> 12) & 0x1FFFFF) >> 6];
			//                   _m_prefetchw(src);
			//                   do
			//                     v181 = src.klass;
			//                   while ( v181 != (HGEnvironmentPhase__Class *)_InterlockedCompareExchange64(
			//                                                                  (volatile signed __int64 *)src,
			//                                                                  (__int64)src.klass | (1LL << v180),
			//                                                                  (signed __int64)src.klass) );
			//                 }
			//                 v177 = v179;
			//               }
			//             }
			//             goto LABEL_163;
			//           case 7u:
			//             v182 = sub_1802DF920((unsigned int)v166);
			//             v177 = sub_18003D1A0(v182, &v433);
			// LABEL_163:
			//             if ( v177 )
			//               _InterlockedExchange64((volatile __int64 *)&TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig, v177);
			//             break;
			//           default:
			//             break;
			//         }
			//       }
			//       if ( !v162.rgctx_data )
			//         sub_180041F40(v162);
			//     }
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig, src);
			//     if ( v3.fields.volumetricFogConfig.m_active )
			//     {
			//       src = (HGEnvironmentPhase *)2;
			//       v183 = &v420;
			//       v184 = 2LL;
			//       do
			//       {
			//         v183 += 8;
			//         v185 = *(_OWORD *)&v164.enable;
			//         v186 = *(_OWORD *)&v164.heightFogStartHeightSecond;
			//         v164 = (HGVolumetricFogConfig *)((char *)v164 + 128);
			//         *(v183 - 8) = v185;
			//         v187 = *(_OWORD *)&v164[-1].flowNoiseTilling;
			//         *(v183 - 7) = v186;
			//         v188 = *(_OWORD *)&v164[-1].flowNoiseDir.y;
			//         *(v183 - 6) = v187;
			//         v189 = *(_OWORD *)&v164[-1].flowVLNoiseIntensity;
			//         *(v183 - 5) = v188;
			//         v190 = *(_OWORD *)&v164[-1].flowVLNoiseVerticalDirAngle;
			//         *(v183 - 4) = v189;
			//         v191 = *(_OWORD *)&v164[-1].flowVLNoiseSpeed;
			//         *(v183 - 3) = v190;
			//         v192 = *(_OWORD *)&v164[-1].m_backupVLNoiseHorizontalDirAngle;
			//         *(v183 - 2) = v191;
			//         *(v183 - 1) = v192;
			//         --v184;
			//       }
			//       while ( v184 );
			//       v193 = &v420;
			//       v194 = 2LL;
			//       do
			//       {
			//         p_volumetricFogConfig = (HGVolumetricFogConfig *)((char *)p_volumetricFogConfig + 128);
			//         v195 = *v193;
			//         v196 = v193[1];
			//         v193 += 8;
			//         *(_OWORD *)&p_volumetricFogConfig[-1].volumetricFogDistance = v195;
			//         v197 = *(v193 - 6);
			//         *(_OWORD *)&p_volumetricFogConfig[-1].volumetricFogSkyLightingScatteringIntensity = v196;
			//         v198 = *(v193 - 5);
			//         *(_OWORD *)&p_volumetricFogConfig[-1].flowNoiseTilling = v197;
			//         v199 = *(v193 - 4);
			//         *(_OWORD *)&p_volumetricFogConfig[-1].flowNoiseDir.y = v198;
			//         v200 = *(v193 - 3);
			//         *(_OWORD *)&p_volumetricFogConfig[-1].flowVLNoiseIntensity = v199;
			//         v201 = *(v193 - 2);
			//         *(_OWORD *)&p_volumetricFogConfig[-1].flowVLNoiseVerticalDirAngle = v200;
			//         v202 = *(v193 - 1);
			//         *(_OWORD *)&p_volumetricFogConfig[-1].flowVLNoiseSpeed = v201;
			//         *(_OWORD *)&p_volumetricFogConfig[-1].m_backupVLNoiseHorizontalDirAngle = v202;
			//         --v194;
			//       }
			//       while ( v194 );
			//     }
			//     v203 = MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGCloudConfig>;
			//     if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGCloudConfig>.rgctx_data )
			//     {
			//       v204 = _InterlockedExchangeAdd64((volatile signed __int64 *)&TypeInfo::HG::Rendering::Runtime::HGCloudConfig, 0LL);
			//       if ( (v204 & 1) != 0 )
			//       {
			//         v205 = ((unsigned int)v204 >> 1) & 0xFFFFFFF;
			//         switch ( (unsigned int)v204 >> 29 )
			//         {
			//           case 1u:
			//             v206 = sub_18003C670((unsigned int)v205);
			//             goto LABEL_189;
			//           case 2u:
			//             v206 = sub_18003C380((unsigned int)v205);
			//             goto LABEL_189;
			//           case 3u:
			//           case 6u:
			//             v206 = sub_1802DFAE0(v204);
			//             goto LABEL_189;
			//           case 4u:
			//             v206 = sub_1802DF920((unsigned int)v205);
			//             goto LABEL_189;
			//           case 5u:
			//             v207 = 8 * v205;
			//             if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v205) )
			//             {
			//               v206 = *(_QWORD *)(v207 + qword_18D8F6F98);
			//             }
			//             else
			//             {
			//               v208 = il2cpp_string_new_len(
			//                        qword_18D8E5198
			//                      + *(int *)(v207 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198 + 4)
			//                      + *(int *)(qword_18D8E51A0 + 16),
			//                        *(unsigned int *)(v207 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198));
			//               v206 = _InterlockedCompareExchange64((volatile signed __int64 *)(qword_18D8F6F98 + 8 * v205), v208, 0LL);
			//               if ( !v206 )
			//               {
			//                 if ( dword_18D8E43F8 )
			//                 {
			//                   v209 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v205) >> 12) & 0x3F;
			//                   src = (HGEnvironmentPhase *)&qword_18D6870D0[(((unsigned __int64)(qword_18D8F6F98 + 8 * v205) >> 12) & 0x1FFFFF) >> 6];
			//                   _m_prefetchw(src);
			//                   do
			//                     v210 = src.klass;
			//                   while ( v210 != (HGEnvironmentPhase__Class *)_InterlockedCompareExchange64(
			//                                                                  (volatile signed __int64 *)src,
			//                                                                  (__int64)src.klass | (1LL << v209),
			//                                                                  (signed __int64)src.klass) );
			//                 }
			//                 v206 = v208;
			//               }
			//             }
			//             goto LABEL_189;
			//           case 7u:
			//             v211 = sub_1802DF920((unsigned int)v205);
			//             v206 = sub_18003D1A0(v211, &v433);
			// LABEL_189:
			//             if ( v206 )
			//               _InterlockedExchange64((volatile __int64 *)&TypeInfo::HG::Rendering::Runtime::HGCloudConfig, v206);
			//             break;
			//           default:
			//             break;
			//         }
			//       }
			//       if ( !v203.rgctx_data )
			//         sub_180041F40(v203);
			//     }
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGCloudConfig._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCloudConfig, src);
			//     if ( v3.fields.cloudConfig.m_active )
			//     {
			//       v71 = dword_18D8E43F8 == 0;
			//       v212 = 0x180000000uLL;
			//       cloudTint = v3.fields.cloudConfig.cloudTint;
			//       v420 = *(_OWORD *)&v3.fields.cloudConfig.enable;
			//       v214 = *(_OWORD *)&v3.fields.cloudConfig.cloudContrast;
			//       v421 = cloudTint;
			//       v215 = *(_OWORD *)&v3.fields.cloudConfig.brightnessAffectCloudAlpha;
			//       v422 = v214;
			//       v216 = *(_OWORD *)&v3.fields.cloudConfig.cloudFlowType;
			//       v423 = v215;
			//       v217 = *(_OWORD *)&v3.fields.cloudConfig.flowSpeed;
			//       v424 = v216;
			//       v218 = *(_OWORD *)&v3.fields.cloudConfig.lightShaftCloudMaskTexture;
			//       v425 = v217;
			//       v219 = *(_OWORD *)&v3.fields.cloudConfig.cloudShadowConfig.cloudShadowTexture;
			//       v426 = v218;
			//       v220 = *(_OWORD *)&v3.fields.cloudConfig.cloudShadowConfig.cloudShadowEnvCenter.z;
			//       v427 = v219;
			//       v221 = *(_OWORD *)&v3.fields.cloudConfig.cloudShadowConfig.cloudShadowFlowDirection.y;
			//       v428 = v220;
			//       v222 = *(_OWORD *)&v3.fields.cloudConfig.cloudShadowConfig.cloudShadowScaleEndDistance;
			//       v429 = v221;
			//       v430 = v222;
			//       v223 = v421;
			//       *(_OWORD *)&this.fields.cloudConfig.enable = v420;
			//       v224 = v422;
			//       this.fields.cloudConfig.cloudTint = v223;
			//       v225 = v423;
			//       *(_OWORD *)&this.fields.cloudConfig.cloudContrast = v224;
			//       v226 = v424;
			//       *(_OWORD *)&this.fields.cloudConfig.brightnessAffectCloudAlpha = v225;
			//       v227 = v425;
			//       *(_OWORD *)&this.fields.cloudConfig.cloudFlowType = v226;
			//       v228 = v426;
			//       *(_OWORD *)&this.fields.cloudConfig.flowSpeed = v227;
			//       v229 = v427;
			//       *(_OWORD *)&this.fields.cloudConfig.lightShaftCloudMaskTexture = v228;
			//       v230 = v428;
			//       *(_OWORD *)&this.fields.cloudConfig.cloudShadowConfig.cloudShadowTexture = v229;
			//       v231 = v429;
			//       *(_OWORD *)&this.fields.cloudConfig.cloudShadowConfig.cloudShadowEnvCenter.z = v230;
			//       v232 = v430;
			//       *(_OWORD *)&this.fields.cloudConfig.cloudShadowConfig.cloudShadowFlowDirection.y = v231;
			//       *(_OWORD *)&this.fields.cloudConfig.cloudShadowConfig.cloudShadowScaleEndDistance = v232;
			//       if ( !v71 )
			//       {
			//         src = (HGEnvironmentPhase *)&qword_18D6870D0[(((unsigned __int64)&this.fields.cloudConfig.cloudTexture >> 12) & 0x1FFFFF) >> 6];
			//         _m_prefetchw(src);
			//         do
			//           v233 = src.klass;
			//         while ( v233 != (HGEnvironmentPhase__Class *)_InterlockedCompareExchange64(
			//                                                        (volatile signed __int64 *)src,
			//                                                        (__int64)src.klass | (1LL << (((unsigned __int64)&this.fields.cloudConfig.cloudTexture >> 12) & 0x3F)),
			//                                                        (signed __int64)src.klass) );
			//       }
			//     }
			//     else
			//     {
			//       v212 = 0x180000000uLL;
			//     }
			//     v234 = MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGCelestialConfig>;
			//     p_celestialConfig = &v3.fields.celestialConfig;
			//     if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGCelestialConfig>.rgctx_data )
			//     {
			//       v236 = _InterlockedExchangeAdd64(
			//                (volatile signed __int64 *)&TypeInfo::HG::Rendering::Runtime::HGCelestialConfig,
			//                0LL);
			//       if ( (v236 & 1) != 0 )
			//       {
			//         v237 = ((unsigned int)v236 >> 1) & 0xFFFFFFF;
			//         switch ( (unsigned int)v236 >> 29 )
			//         {
			//           case 1u:
			//             v238 = sub_18003C670((unsigned int)v237);
			//             goto LABEL_216;
			//           case 2u:
			//             v238 = sub_18003C380((unsigned int)v237);
			//             goto LABEL_216;
			//           case 3u:
			//           case 6u:
			//             v238 = sub_1802DFAE0(v236);
			//             goto LABEL_216;
			//           case 4u:
			//             v238 = sub_1802DF920((unsigned int)v237);
			//             goto LABEL_216;
			//           case 5u:
			//             v239 = 8 * v237;
			//             if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v237) )
			//             {
			//               v238 = *(_QWORD *)(v239 + qword_18D8F6F98);
			//             }
			//             else
			//             {
			//               v212 = il2cpp_string_new_len(
			//                        qword_18D8E5198
			//                      + *(int *)(v239 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198 + 4)
			//                      + *(int *)(qword_18D8E51A0 + 16),
			//                        *(unsigned int *)(v239 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198));
			//               v238 = _InterlockedCompareExchange64((volatile signed __int64 *)(qword_18D8F6F98 + 8 * v237), v212, 0LL);
			//               if ( !v238 )
			//               {
			//                 if ( dword_18D8E43F8 )
			//                 {
			//                   v240 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v237) >> 12) & 0x3F;
			//                   src = (HGEnvironmentPhase *)&qword_18D6870D0[(((unsigned __int64)(qword_18D8F6F98 + 8 * v237) >> 12) & 0x1FFFFF) >> 6];
			//                   _m_prefetchw(src);
			//                   do
			//                     v241 = src.klass;
			//                   while ( v241 != (HGEnvironmentPhase__Class *)_InterlockedCompareExchange64(
			//                                                                  (volatile signed __int64 *)src,
			//                                                                  (__int64)src.klass | (1LL << v240),
			//                                                                  (signed __int64)src.klass) );
			//                 }
			//                 v238 = v212;
			//               }
			//             }
			//             goto LABEL_216;
			//           case 7u:
			//             v242 = sub_1802DF920((unsigned int)v237);
			//             v238 = sub_18003D1A0(v242, &v433);
			// LABEL_216:
			//             if ( v238 )
			//               _InterlockedExchange64((volatile __int64 *)&TypeInfo::HG::Rendering::Runtime::HGCelestialConfig, v238);
			//             break;
			//           default:
			//             break;
			//         }
			//       }
			//       if ( !v234.rgctx_data )
			//         sub_180041F40(v234);
			//     }
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGCelestialConfig._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCelestialConfig, src);
			//     if ( v3.fields.celestialConfig.m_active )
			//     {
			//       src = (HGEnvironmentPhase *)2;
			//       v243 = &v420;
			//       v244 = 2LL;
			//       do
			//       {
			//         v243 += 8;
			//         v245 = *(_OWORD *)&p_celestialConfig.moonConfig.radius;
			//         v246 = *(_OWORD *)&p_celestialConfig.moonConfig.worldLongitude;
			//         p_celestialConfig = (HGCelestialConfig *)((char *)p_celestialConfig + 128);
			//         *(v243 - 8) = v245;
			//         v247 = *(_OWORD *)&p_celestialConfig[-1].planetConfig.ring.outerRadius;
			//         *(v243 - 7) = v246;
			//         v248 = *(_OWORD *)&p_celestialConfig[-1].planetConfig.ring.ringColor.b;
			//         *(v243 - 6) = v247;
			//         v249 = *(_OWORD *)&p_celestialConfig[-1].planetConfig.enableAtmosphere;
			//         *(v243 - 5) = v248;
			//         v250 = *(_OWORD *)&p_celestialConfig[-1].planetConfig.atmosphere.numOpticalDepthSamplePoints;
			//         *(v243 - 4) = v249;
			//         v251 = *(_OWORD *)&p_celestialConfig[-1].planetConfig.atmosphere.atmosphereHueshift;
			//         *(v243 - 3) = v250;
			//         v252 = *(_OWORD *)&p_celestialConfig[-1].advancedPlanetConfig.advancedPlanetMat;
			//         *(v243 - 2) = v251;
			//         *(v243 - 1) = v252;
			//         --v244;
			//       }
			//       while ( v244 );
			//       drawMaterial = p_celestialConfig.talosAlphaConfig.skydomeDrawer.drawMaterial;
			//       v254 = *(_OWORD *)&p_celestialConfig.moonConfig.worldLongitude;
			//       *v243 = *(_OWORD *)&p_celestialConfig.moonConfig.radius;
			//       v255 = *(_OWORD *)&p_celestialConfig.moonConfig.ring.outerRadius;
			//       v243[1] = v254;
			//       v256 = *(_OWORD *)&p_celestialConfig.moonConfig.ring.ringColor.b;
			//       v243[2] = v255;
			//       v257 = *(_OWORD *)&p_celestialConfig.talosAlphaConfig.drawPlanetInSkydome;
			//       v243[3] = v256;
			//       v258 = *(_OWORD *)&p_celestialConfig.talosAlphaConfig.objectProperty.selfTiltZ;
			//       v243[4] = v257;
			//       v243[5] = v258;
			//       *((_QWORD *)v243 + 12) = drawMaterial;
			//       v259 = &this.fields.celestialConfig;
			//       v260 = &v420;
			//       do
			//       {
			//         v259 = (HGCelestialConfig *)((char *)v259 + 128);
			//         v261 = *v260;
			//         v262 = v260[1];
			//         v260 += 8;
			//         *(_OWORD *)&v259[-1].planetConfig.skydomeDrawer.drawMaterial = v261;
			//         v263 = *(v260 - 6);
			//         *(_OWORD *)&v259[-1].planetConfig.skydomeDrawer.incidentLightingPitchYaw.x = v262;
			//         v264 = *(v260 - 5);
			//         *(_OWORD *)&v259[-1].planetConfig.ring.outerRadius = v263;
			//         v265 = *(v260 - 4);
			//         *(_OWORD *)&v259[-1].planetConfig.ring.ringColor.b = v264;
			//         v266 = *(v260 - 3);
			//         *(_OWORD *)&v259[-1].planetConfig.enableAtmosphere = v265;
			//         v267 = *(v260 - 2);
			//         *(_OWORD *)&v259[-1].planetConfig.atmosphere.numOpticalDepthSamplePoints = v266;
			//         v268 = *(v260 - 1);
			//         *(_OWORD *)&v259[-1].planetConfig.atmosphere.atmosphereHueshift = v267;
			//         *(_OWORD *)&v259[-1].advancedPlanetConfig.advancedPlanetMat = v268;
			//         src = (HGEnvironmentPhase *)((char *)src - 1);
			//       }
			//       while ( src );
			//       v71 = dword_18D8E43F8 == 0;
			//       v269 = v260[1];
			//       *(_OWORD *)&v259.moonConfig.radius = *v260;
			//       v270 = v260[2];
			//       *(_OWORD *)&v259.moonConfig.worldLongitude = v269;
			//       v271 = v260[3];
			//       *(_OWORD *)&v259.moonConfig.ring.outerRadius = v270;
			//       v272 = v260[4];
			//       *(_OWORD *)&v259.moonConfig.ring.ringColor.b = v271;
			//       v273 = v260[5];
			//       v274 = (Material *)*((_QWORD *)v260 + 12);
			//       *(_OWORD *)&v259.talosAlphaConfig.drawPlanetInSkydome = v272;
			//       *(_OWORD *)&v259.talosAlphaConfig.objectProperty.selfTiltZ = v273;
			//       v259.talosAlphaConfig.skydomeDrawer.drawMaterial = v274;
			//       if ( !v71 )
			//       {
			//         src = (HGEnvironmentPhase *)&qword_18D6870D0[(((unsigned __int64)&this.fields.celestialConfig.moonConfig.ring.planetRingMap >> 12) & 0x1FFFFF) >> 6];
			//         _m_prefetchw(src);
			//         do
			//           v275 = src.klass;
			//         while ( v275 != (HGEnvironmentPhase__Class *)_InterlockedCompareExchange64(
			//                                                        (volatile signed __int64 *)src,
			//                                                        (__int64)src.klass | (1LL << (((unsigned __int64)&this.fields.celestialConfig.moonConfig.ring.planetRingMap >> 12) & 0x3F)),
			//                                                        (signed __int64)src.klass) );
			//       }
			//     }
			//     v276 = MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGWindConfig>;
			//     if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGWindConfig>.rgctx_data )
			//     {
			//       v277 = _InterlockedExchangeAdd64((volatile signed __int64 *)&TypeInfo::HG::Rendering::Runtime::HGWindConfig, 0LL);
			//       if ( (v277 & 1) != 0 )
			//       {
			//         v278 = ((unsigned int)v277 >> 1) & 0xFFFFFFF;
			//         switch ( (unsigned int)v277 >> 29 )
			//         {
			//           case 1u:
			//             v279 = sub_18003C670((unsigned int)v278);
			//             goto LABEL_245;
			//           case 2u:
			//             v279 = sub_18003C380((unsigned int)v278);
			//             goto LABEL_245;
			//           case 3u:
			//           case 6u:
			//             v279 = sub_1802DFAE0(v277);
			//             goto LABEL_245;
			//           case 4u:
			//             v279 = sub_1802DF920((unsigned int)v278);
			//             goto LABEL_245;
			//           case 5u:
			//             v280 = 8 * v278;
			//             if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v278) )
			//             {
			//               v279 = *(_QWORD *)(v280 + qword_18D8F6F98);
			//             }
			//             else
			//             {
			//               v212 = il2cpp_string_new_len(
			//                        qword_18D8E5198
			//                      + *(int *)(v280 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198 + 4)
			//                      + *(int *)(qword_18D8E51A0 + 16),
			//                        *(unsigned int *)(v280 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198));
			//               v279 = _InterlockedCompareExchange64((volatile signed __int64 *)(qword_18D8F6F98 + 8 * v278), v212, 0LL);
			//               if ( !v279 )
			//               {
			//                 if ( dword_18D8E43F8 )
			//                 {
			//                   src = (HGEnvironmentPhase *)(0x180000000LL
			//                                              + 8
			//                                              * ((((unsigned __int64)(qword_18D8F6F98 + 8 * v278) >> 12) & 0x1FFFFF) >> 6)
			//                                              + 224948432);
			//                   v281 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v278) >> 12) & 0x3F;
			//                   _m_prefetchw(src);
			//                   do
			//                     v282 = src.klass;
			//                   while ( v282 != (HGEnvironmentPhase__Class *)_InterlockedCompareExchange64(
			//                                                                  (volatile signed __int64 *)src,
			//                                                                  (__int64)src.klass | (1LL << v281),
			//                                                                  (signed __int64)src.klass) );
			//                 }
			//                 v279 = v212;
			//               }
			//             }
			//             goto LABEL_245;
			//           case 7u:
			//             v283 = sub_1802DF920((unsigned int)v278);
			//             v279 = sub_18003D1A0(v283, &v433);
			// LABEL_245:
			//             if ( v279 )
			//               _InterlockedExchange64((volatile __int64 *)&TypeInfo::HG::Rendering::Runtime::HGWindConfig, v279);
			//             break;
			//           default:
			//             break;
			//         }
			//       }
			//       if ( !v276.rgctx_data )
			//         sub_180041F40(v276);
			//     }
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGWindConfig._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGWindConfig, src);
			//     if ( v3.fields.windConfig.m_active )
			//     {
			//       v284 = *(_DWORD *)&v3.fields.windConfig.m_active;
			//       v285 = *(_QWORD *)&v3.fields.windConfig.direction.y;
			//       *(_OWORD *)&this.fields.windConfig.speed = *(_OWORD *)&v3.fields.windConfig.speed;
			//       *(_QWORD *)&this.fields.windConfig.direction.y = v285;
			//       *(_DWORD *)&this.fields.windConfig.m_active = v284;
			//     }
			//     v286 = MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGLightShaftConfig>;
			//     if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGLightShaftConfig>.rgctx_data )
			//     {
			//       v287 = _InterlockedExchangeAdd64(
			//                (volatile signed __int64 *)&TypeInfo::HG::Rendering::Runtime::HGLightShaftConfig,
			//                0LL);
			//       if ( (v287 & 1) != 0 )
			//       {
			//         v288 = ((unsigned int)v287 >> 1) & 0xFFFFFFF;
			//         switch ( (unsigned int)v287 >> 29 )
			//         {
			//           case 1u:
			//             v289 = sub_18003C670((unsigned int)v288);
			//             goto LABEL_268;
			//           case 2u:
			//             v289 = sub_18003C380((unsigned int)v288);
			//             goto LABEL_268;
			//           case 3u:
			//           case 6u:
			//             v289 = sub_1802DFAE0(v287);
			//             goto LABEL_268;
			//           case 4u:
			//             v289 = sub_1802DF920((unsigned int)v288);
			//             goto LABEL_268;
			//           case 5u:
			//             v212 = 8 * v288;
			//             if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v288) )
			//             {
			//               v289 = *(_QWORD *)(qword_18D8F6F98 + 8 * v288);
			//             }
			//             else
			//             {
			//               v212 = il2cpp_string_new_len(
			//                        qword_18D8E5198
			//                      + *(int *)(qword_18D8E51A0 + 16)
			//                      + *(int *)(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 8) + 8 * v288 + 4),
			//                        *(unsigned int *)(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 8) + 8 * v288));
			//               v289 = _InterlockedCompareExchange64((volatile signed __int64 *)(qword_18D8F6F98 + 8 * v288), v212, 0LL);
			//               if ( !v289 )
			//               {
			//                 if ( dword_18D8E43F8 )
			//                 {
			//                   src = (HGEnvironmentPhase *)(0x180000000LL
			//                                              + 8
			//                                              * ((((unsigned __int64)(qword_18D8F6F98 + 8 * v288) >> 12) & 0x1FFFFF) >> 6)
			//                                              + 224948432);
			//                   v290 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v288) >> 12) & 0x3F;
			//                   _m_prefetchw(src);
			//                   do
			//                     v291 = src.klass;
			//                   while ( v291 != (HGEnvironmentPhase__Class *)_InterlockedCompareExchange64(
			//                                                                  (volatile signed __int64 *)src,
			//                                                                  (__int64)src.klass | (1LL << v290),
			//                                                                  (signed __int64)src.klass) );
			//                 }
			//                 v289 = v212;
			//               }
			//             }
			//             goto LABEL_268;
			//           case 7u:
			//             v292 = sub_1802DF920((unsigned int)v288);
			//             v289 = sub_18003D1A0(v292, &v433);
			// LABEL_268:
			//             if ( v289 )
			//               _InterlockedExchange64((volatile __int64 *)&TypeInfo::HG::Rendering::Runtime::HGLightShaftConfig, v289);
			//             break;
			//           default:
			//             break;
			//         }
			//       }
			//       if ( !v286.rgctx_data )
			//         sub_180041F40(v286);
			//     }
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGLightShaftConfig._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGLightShaftConfig, src);
			//     if ( v3.fields.lightShaftConfig.m_active )
			//     {
			//       v293 = *(_DWORD *)&v3.fields.lightShaftConfig.m_active;
			//       bloomTint = v3.fields.lightShaftConfig.bloomTint;
			//       v295 = *(_OWORD *)&v3.fields.lightShaftConfig.blurIntensity;
			//       *(_OWORD *)&this.fields.lightShaftConfig.enable = *(_OWORD *)&v3.fields.lightShaftConfig.enable;
			//       this.fields.lightShaftConfig.bloomTint = bloomTint;
			//       *(_OWORD *)&this.fields.lightShaftConfig.blurIntensity = v295;
			//       *(_DWORD *)&this.fields.lightShaftConfig.m_active = v293;
			//     }
			//     v296 = MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGTerrainDeformConfig>;
			//     if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGTerrainDeformConfig>.rgctx_data )
			//     {
			//       v297 = _InterlockedExchangeAdd64(
			//                (volatile signed __int64 *)&TypeInfo::HG::Rendering::Runtime::HGTerrainDeformConfig,
			//                0LL);
			//       if ( (v297 & 1) != 0 )
			//       {
			//         v298 = ((unsigned int)v297 >> 1) & 0xFFFFFFF;
			//         switch ( (unsigned int)v297 >> 29 )
			//         {
			//           case 1u:
			//             v299 = sub_18003C670((unsigned int)v298);
			//             goto LABEL_291;
			//           case 2u:
			//             v299 = sub_18003C380((unsigned int)v298);
			//             goto LABEL_291;
			//           case 3u:
			//           case 6u:
			//             v299 = sub_1802DFAE0(v297);
			//             goto LABEL_291;
			//           case 4u:
			//             v299 = sub_1802DF920((unsigned int)v298);
			//             goto LABEL_291;
			//           case 5u:
			//             v300 = 8 * v298;
			//             if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v298) )
			//             {
			//               v299 = *(_QWORD *)(v300 + qword_18D8F6F98);
			//             }
			//             else
			//             {
			//               v212 = il2cpp_string_new_len(
			//                        qword_18D8E5198
			//                      + *(int *)(qword_18D8E51A0 + 16)
			//                      + *(int *)(v300 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198 + 4),
			//                        *(unsigned int *)(v300 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198));
			//               v299 = _InterlockedCompareExchange64((volatile signed __int64 *)(qword_18D8F6F98 + 8 * v298), v212, 0LL);
			//               if ( !v299 )
			//               {
			//                 if ( dword_18D8E43F8 )
			//                 {
			//                   src = (HGEnvironmentPhase *)(0x180000000LL
			//                                              + 8
			//                                              * ((((unsigned __int64)(qword_18D8F6F98 + 8 * v298) >> 12) & 0x1FFFFF) >> 6)
			//                                              + 224948432);
			//                   v301 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v298) >> 12) & 0x3F;
			//                   _m_prefetchw(src);
			//                   do
			//                     v302 = src.klass;
			//                   while ( v302 != (HGEnvironmentPhase__Class *)_InterlockedCompareExchange64(
			//                                                                  (volatile signed __int64 *)src,
			//                                                                  (__int64)src.klass | (1LL << v301),
			//                                                                  (signed __int64)src.klass) );
			//                 }
			//                 v299 = v212;
			//               }
			//             }
			//             goto LABEL_291;
			//           case 7u:
			//             v303 = sub_1802DF920((unsigned int)v298);
			//             v299 = sub_18003D1A0(v303, &v433);
			// LABEL_291:
			//             if ( v299 )
			//               _InterlockedExchange64((volatile __int64 *)&TypeInfo::HG::Rendering::Runtime::HGTerrainDeformConfig, v299);
			//             break;
			//           default:
			//             break;
			//         }
			//       }
			//       if ( !v296.rgctx_data )
			//         sub_180041F40(v296);
			//     }
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGTerrainDeformConfig._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGTerrainDeformConfig, src);
			//     if ( v3.fields.terrainDeformConfig.m_active )
			//     {
			//       v304 = *(_DWORD *)&v3.fields.terrainDeformConfig.m_active;
			//       *(_QWORD *)&this.fields.terrainDeformConfig.deformGlobalStrength = *(_QWORD *)&v3.fields.terrainDeformConfig.deformGlobalStrength;
			//       *(_DWORD *)&this.fields.terrainDeformConfig.m_active = v304;
			//     }
			//     v305 = MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGInkSimulationConfig>;
			//     if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGInkSimulationConfig>.rgctx_data )
			//     {
			//       v306 = _InterlockedExchangeAdd64(
			//                (volatile signed __int64 *)&TypeInfo::HG::Rendering::Runtime::HGInkSimulationConfig,
			//                0LL);
			//       if ( (v306 & 1) != 0 )
			//       {
			//         v307 = ((unsigned int)v306 >> 1) & 0xFFFFFFF;
			//         switch ( (unsigned int)v306 >> 29 )
			//         {
			//           case 1u:
			//             v308 = sub_18003C670((unsigned int)v307);
			//             goto LABEL_314;
			//           case 2u:
			//             v308 = sub_18003C380((unsigned int)v307);
			//             goto LABEL_314;
			//           case 3u:
			//           case 6u:
			//             v308 = sub_1802DFAE0(v306);
			//             goto LABEL_314;
			//           case 4u:
			//             v308 = sub_1802DF920((unsigned int)v307);
			//             goto LABEL_314;
			//           case 5u:
			//             v309 = 8 * v307;
			//             if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v307) )
			//             {
			//               v308 = *(_QWORD *)(v309 + qword_18D8F6F98);
			//             }
			//             else
			//             {
			//               v212 = il2cpp_string_new_len(
			//                        qword_18D8E5198
			//                      + *(int *)(qword_18D8E51A0 + 16)
			//                      + *(int *)(v309 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198 + 4),
			//                        *(unsigned int *)(v309 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198));
			//               v308 = _InterlockedCompareExchange64((volatile signed __int64 *)(qword_18D8F6F98 + 8 * v307), v212, 0LL);
			//               if ( !v308 )
			//               {
			//                 if ( dword_18D8E43F8 )
			//                 {
			//                   src = (HGEnvironmentPhase *)(0x180000000LL
			//                                              + 8
			//                                              * ((((unsigned __int64)(qword_18D8F6F98 + 8 * v307) >> 12) & 0x1FFFFF) >> 6)
			//                                              + 224948432);
			//                   v310 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v307) >> 12) & 0x3F;
			//                   _m_prefetchw(src);
			//                   do
			//                     v311 = src.klass;
			//                   while ( v311 != (HGEnvironmentPhase__Class *)_InterlockedCompareExchange64(
			//                                                                  (volatile signed __int64 *)src,
			//                                                                  (__int64)src.klass | (1LL << v310),
			//                                                                  (signed __int64)src.klass) );
			//                 }
			//                 v308 = v212;
			//               }
			//             }
			//             goto LABEL_314;
			//           case 7u:
			//             v312 = sub_1802DF920((unsigned int)v307);
			//             v308 = sub_18003D1A0(v312, &v433);
			// LABEL_314:
			//             if ( v308 )
			//               _InterlockedExchange64((volatile __int64 *)&TypeInfo::HG::Rendering::Runtime::HGInkSimulationConfig, v308);
			//             break;
			//           default:
			//             break;
			//         }
			//       }
			//       if ( !v305.rgctx_data )
			//         sub_180041F40(v305);
			//     }
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGInkSimulationConfig._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGInkSimulationConfig, src);
			//     if ( v3.fields.inkSimulationConfig.m_active )
			//     {
			//       v71 = dword_18D8E43F8 == 0;
			//       v313 = *(_QWORD *)&v3.fields.inkSimulationConfig.m_active;
			//       *(_OWORD *)&this.fields.inkSimulationConfig.influence = *(_OWORD *)&v3.fields.inkSimulationConfig.influence;
			//       *(_QWORD *)&this.fields.inkSimulationConfig.m_active = v313;
			//       if ( !v71 )
			//       {
			//         src = (HGEnvironmentPhase *)(0x180000000LL
			//                                    + 8
			//                                    * ((((unsigned __int64)&this.fields.inkSimulationConfig.material >> 12) & 0x1FFFFF) >> 6)
			//                                    + 224948432);
			//         _m_prefetchw(src);
			//         do
			//           v314 = src.klass;
			//         while ( v314 != (HGEnvironmentPhase__Class *)_InterlockedCompareExchange64(
			//                                                        (volatile signed __int64 *)src,
			//                                                        (__int64)src.klass | (1LL << (((unsigned __int64)&this.fields.inkSimulationConfig.material >> 12) & 0x3F)),
			//                                                        (signed __int64)src.klass) );
			//       }
			//     }
			//     v315 = MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGRainConfig>;
			//     p_rainConfig = &this.fields.rainConfig;
			//     v317 = &v3.fields.rainConfig;
			//     if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGRainConfig>.rgctx_data )
			//     {
			//       v318 = _InterlockedExchangeAdd64((volatile signed __int64 *)&TypeInfo::HG::Rendering::Runtime::HGRainConfig, 0LL);
			//       if ( (v318 & 1) != 0 )
			//       {
			//         v319 = ((unsigned int)v318 >> 1) & 0xFFFFFFF;
			//         switch ( (unsigned int)v318 >> 29 )
			//         {
			//           case 1u:
			//             v320 = sub_18003C670((unsigned int)v319);
			//             goto LABEL_339;
			//           case 2u:
			//             v320 = sub_18003C380((unsigned int)v319);
			//             goto LABEL_339;
			//           case 3u:
			//           case 6u:
			//             v320 = sub_1802DFAE0(v318);
			//             goto LABEL_339;
			//           case 4u:
			//             v320 = sub_1802DF920((unsigned int)v319);
			//             goto LABEL_339;
			//           case 5u:
			//             v321 = 8 * v319;
			//             if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v319) )
			//             {
			//               v320 = *(_QWORD *)(v321 + qword_18D8F6F98);
			//             }
			//             else
			//             {
			//               v212 = il2cpp_string_new_len(
			//                        qword_18D8E5198
			//                      + *(int *)(qword_18D8E51A0 + 16)
			//                      + *(int *)(v321 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198 + 4),
			//                        *(unsigned int *)(v321 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198));
			//               v320 = _InterlockedCompareExchange64((volatile signed __int64 *)(qword_18D8F6F98 + 8 * v319), v212, 0LL);
			//               if ( !v320 )
			//               {
			//                 if ( dword_18D8E43F8 )
			//                 {
			//                   v322 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v319) >> 12) & 0x3F;
			//                   src = (HGEnvironmentPhase *)&qword_18D6870D0[(((unsigned __int64)(qword_18D8F6F98 + 8 * v319) >> 12) & 0x1FFFFF) >> 6];
			//                   _m_prefetchw(src);
			//                   do
			//                     v323 = src.klass;
			//                   while ( v323 != (HGEnvironmentPhase__Class *)_InterlockedCompareExchange64(
			//                                                                  (volatile signed __int64 *)src,
			//                                                                  (__int64)src.klass | (1LL << v322),
			//                                                                  (signed __int64)src.klass) );
			//                 }
			//                 v320 = v212;
			//               }
			//             }
			//             goto LABEL_339;
			//           case 7u:
			//             v324 = sub_1802DF920((unsigned int)v319);
			//             v320 = sub_18003D1A0(v324, &v433);
			// LABEL_339:
			//             if ( v320 )
			//               _InterlockedExchange64((volatile __int64 *)&TypeInfo::HG::Rendering::Runtime::HGRainConfig, v320);
			//             break;
			//           default:
			//             break;
			//         }
			//       }
			//       if ( !v315.rgctx_data )
			//         sub_180041F40(v315);
			//     }
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGRainConfig._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRainConfig, src);
			//     if ( v3.fields.rainConfig.m_active )
			//     {
			//       src = (HGEnvironmentPhase *)2;
			//       v325 = &v420;
			//       v326 = 2LL;
			//       do
			//       {
			//         v325 += 8;
			//         v327 = *(_OWORD *)&v317.enable;
			//         v328 = *(_OWORD *)&v317.color.g;
			//         v317 = (HGRainConfig *)((char *)v317 + 128);
			//         *(v325 - 8) = v327;
			//         v329 = *(_OWORD *)&v317[-1].baseWetnessLevel;
			//         *(v325 - 7) = v328;
			//         v330 = *(_OWORD *)&v317[-1].verticalFlowSurfaceThreshold;
			//         *(v325 - 6) = v329;
			//         v331 = *(_OWORD *)&v317[-1].rippleWaveSpeed;
			//         *(v325 - 5) = v330;
			//         v332 = *(_OWORD *)&v317[-1].farSceneWetnessValue;
			//         *(v325 - 4) = v331;
			//         v333 = *(_OWORD *)&v317[-1].rainDirection.z;
			//         *(v325 - 3) = v332;
			//         v334 = *(_OWORD *)&v317[-1].farRainDirection.x;
			//         *(v325 - 2) = v333;
			//         *(v325 - 1) = v334;
			//         --v326;
			//       }
			//       while ( v326 );
			//       v335 = *(_OWORD *)&v317.color.g;
			//       *v325 = *(_OWORD *)&v317.enable;
			//       v336 = *(_OWORD *)&v317.horizontalRainAngle;
			//       v325[1] = v335;
			//       v325[2] = v336;
			//       v337 = &v420;
			//       do
			//       {
			//         p_rainConfig = (HGRainConfig *)((char *)p_rainConfig + 128);
			//         v338 = *v337;
			//         v339 = v337[1];
			//         v337 += 8;
			//         *(_OWORD *)&p_rainConfig[-1].rainSplashAlpha = v338;
			//         v340 = *(v337 - 6);
			//         *(_OWORD *)&p_rainConfig[-1].enableWetness = v339;
			//         v341 = *(v337 - 5);
			//         *(_OWORD *)&p_rainConfig[-1].baseWetnessLevel = v340;
			//         v342 = *(v337 - 4);
			//         *(_OWORD *)&p_rainConfig[-1].verticalFlowSurfaceThreshold = v341;
			//         v343 = *(v337 - 3);
			//         *(_OWORD *)&p_rainConfig[-1].rippleWaveSpeed = v342;
			//         v344 = *(v337 - 2);
			//         *(_OWORD *)&p_rainConfig[-1].farSceneWetnessValue = v343;
			//         v345 = *(v337 - 1);
			//         *(_OWORD *)&p_rainConfig[-1].rainDirection.z = v344;
			//         *(_OWORD *)&p_rainConfig[-1].farRainDirection.x = v345;
			//         src = (HGEnvironmentPhase *)((char *)src - 1);
			//       }
			//       while ( src );
			//       v346 = v337[1];
			//       *(_OWORD *)&p_rainConfig.enable = *v337;
			//       v347 = v337[2];
			//       *(_OWORD *)&p_rainConfig.color.g = v346;
			//       *(_OWORD *)&p_rainConfig.horizontalRainAngle = v347;
			//     }
			//     v348 = MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGSnowConfig>;
			//     if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGSnowConfig>.rgctx_data )
			//     {
			//       v349 = _InterlockedExchangeAdd64((volatile signed __int64 *)&TypeInfo::HG::Rendering::Runtime::HGSnowConfig, 0LL);
			//       if ( (v349 & 1) != 0 )
			//       {
			//         v350 = ((unsigned int)v349 >> 1) & 0xFFFFFFF;
			//         switch ( (unsigned int)v349 >> 29 )
			//         {
			//           case 1u:
			//             v351 = sub_18003C670((unsigned int)v350);
			//             goto LABEL_366;
			//           case 2u:
			//             v351 = sub_18003C380((unsigned int)v350);
			//             goto LABEL_366;
			//           case 3u:
			//           case 6u:
			//             v351 = sub_1802DFAE0(v349);
			//             goto LABEL_366;
			//           case 4u:
			//             v351 = sub_1802DF920((unsigned int)v350);
			//             goto LABEL_366;
			//           case 5u:
			//             v352 = 8 * v350;
			//             if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v350) )
			//             {
			//               v351 = *(_QWORD *)(v352 + qword_18D8F6F98);
			//             }
			//             else
			//             {
			//               v212 = il2cpp_string_new_len(
			//                        qword_18D8E5198
			//                      + *(int *)(v352 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198 + 4)
			//                      + *(int *)(qword_18D8E51A0 + 16),
			//                        *(unsigned int *)(v352 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198));
			//               v351 = _InterlockedCompareExchange64((volatile signed __int64 *)(qword_18D8F6F98 + 8 * v350), v212, 0LL);
			//               if ( !v351 )
			//               {
			//                 if ( dword_18D8E43F8 )
			//                 {
			//                   v353 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v350) >> 12) & 0x3F;
			//                   src = (HGEnvironmentPhase *)&qword_18D6870D0[(((unsigned __int64)(qword_18D8F6F98 + 8 * v350) >> 12) & 0x1FFFFF) >> 6];
			//                   _m_prefetchw(src);
			//                   do
			//                     v354 = src.klass;
			//                   while ( v354 != (HGEnvironmentPhase__Class *)_InterlockedCompareExchange64(
			//                                                                  (volatile signed __int64 *)src,
			//                                                                  (__int64)src.klass | (1LL << v353),
			//                                                                  (signed __int64)src.klass) );
			//                 }
			//                 v351 = v212;
			//               }
			//             }
			//             goto LABEL_366;
			//           case 7u:
			//             v355 = sub_1802DF920((unsigned int)v350);
			//             v351 = sub_18003D1A0(v355, &v433);
			// LABEL_366:
			//             if ( v351 )
			//               _InterlockedExchange64((volatile __int64 *)&TypeInfo::HG::Rendering::Runtime::HGSnowConfig, v351);
			//             break;
			//           default:
			//             break;
			//         }
			//       }
			//       if ( !v348.rgctx_data )
			//         sub_180041F40(v348);
			//     }
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGSnowConfig._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGSnowConfig, src);
			//     if ( v3.fields.snowConfig.m_active )
			//     {
			//       v356 = *(_OWORD *)&v3.fields.snowConfig.color.g;
			//       v357 = *(_OWORD *)&v3.fields.snowConfig.snowSizeRange.y;
			//       v358 = *(_OWORD *)&v3.fields.snowConfig.snowLightingPercent;
			//       v359 = *(_QWORD *)&v3.fields.snowConfig.snowDirection.z;
			//       *(_OWORD *)&this.fields.snowConfig.enable = *(_OWORD *)&v3.fields.snowConfig.enable;
			//       *(_OWORD *)&this.fields.snowConfig.color.g = v356;
			//       *(_OWORD *)&this.fields.snowConfig.snowSizeRange.y = v357;
			//       *(_OWORD *)&this.fields.snowConfig.snowLightingPercent = v358;
			//       *(_QWORD *)&this.fields.snowConfig.snowDirection.z = v359;
			//     }
			//     sub_182D6CB50(
			//       &this.fields.starConfig,
			//       &v3.fields.starConfig,
			//       MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGStarConfig>,
			//       v212);
			//     v361 = MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGLensFlareConfig>;
			//     if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGLensFlareConfig>.rgctx_data )
			//     {
			//       v362 = _InterlockedExchangeAdd64(
			//                (volatile signed __int64 *)&TypeInfo::HG::Rendering::Runtime::HGLensFlareConfig,
			//                0LL);
			//       if ( (v362 & 1) != 0 )
			//       {
			//         v363 = ((unsigned int)v362 >> 1) & 0xFFFFFFF;
			//         switch ( (unsigned int)v362 >> 29 )
			//         {
			//           case 1u:
			//             v364 = sub_18003C670((unsigned int)v363);
			//             goto LABEL_389;
			//           case 2u:
			//             v364 = sub_18003C380((unsigned int)v363);
			//             goto LABEL_389;
			//           case 3u:
			//           case 6u:
			//             v364 = sub_1802DFAE0(v362);
			//             goto LABEL_389;
			//           case 4u:
			//             v364 = sub_1802DF920((unsigned int)v363);
			//             goto LABEL_389;
			//           case 5u:
			//             v365 = 8 * v363;
			//             if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v363) )
			//             {
			//               v364 = *(_QWORD *)(v365 + qword_18D8F6F98);
			//             }
			//             else
			//             {
			//               v366 = il2cpp_string_new_len(
			//                        qword_18D8E5198
			//                      + *(int *)(v365 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198 + 4)
			//                      + *(int *)(qword_18D8E51A0 + 16),
			//                        *(unsigned int *)(v365 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198));
			//               v364 = _InterlockedCompareExchange64((volatile signed __int64 *)(qword_18D8F6F98 + 8 * v363), v366, 0LL);
			//               if ( !v364 )
			//               {
			//                 if ( dword_18D8E43F8 )
			//                 {
			//                   v367 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v363) >> 12) & 0x3F;
			//                   v360 = &qword_18D6870D0[(((unsigned __int64)(qword_18D8F6F98 + 8 * v363) >> 12) & 0x1FFFFF) >> 6];
			//                   _m_prefetchw(v360);
			//                   do
			//                     v368 = *v360;
			//                   while ( v368 != _InterlockedCompareExchange64(v360, *v360 | (1LL << v367), *v360) );
			//                 }
			//                 v364 = v366;
			//               }
			//             }
			//             goto LABEL_389;
			//           case 7u:
			//             v369 = sub_1802DF920((unsigned int)v363);
			//             v364 = sub_18003D1A0(v369, &v433);
			// LABEL_389:
			//             if ( v364 )
			//               _InterlockedExchange64((volatile __int64 *)&TypeInfo::HG::Rendering::Runtime::HGLensFlareConfig, v364);
			//             break;
			//           default:
			//             break;
			//         }
			//       }
			//       if ( !v361.rgctx_data )
			//         sub_180041F40(v361);
			//     }
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGLensFlareConfig._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGLensFlareConfig, v360);
			//     if ( v3.fields.lensFlareConfig.m_active )
			//     {
			//       v71 = dword_18D8E43F8 == 0;
			//       v370 = *(_OWORD *)&v3.fields.lensFlareConfig.intensity;
			//       v371 = *(_OWORD *)&v3.fields.lensFlareConfig.sampleCount;
			//       *(_OWORD *)&this.fields.lensFlareConfig.enable = *(_OWORD *)&v3.fields.lensFlareConfig.enable;
			//       *(_OWORD *)&this.fields.lensFlareConfig.intensity = v370;
			//       *(_OWORD *)&this.fields.lensFlareConfig.sampleCount = v371;
			//       if ( !v71 )
			//       {
			//         v372 = &qword_18D6870D0[(((unsigned __int64)&this.fields.lensFlareConfig.lensFlareData >> 12) & 0x1FFFFF) >> 6];
			//         _m_prefetchw(v372);
			//         do
			//           v373 = *v372;
			//         while ( v373 != _InterlockedCompareExchange64(
			//                           v372,
			//                           *v372 | (1LL << (((unsigned __int64)&this.fields.lensFlareConfig.lensFlareData >> 12) & 0x3F)),
			//                           *v372) );
			//       }
			//     }
			//     sub_182CE7200(
			//       &this.fields.colorGradingConfig,
			//       &v3.fields.colorGradingConfig,
			//       MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGColorGradingConfig>);
			//     v375 = MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGAutoExposureConfig>;
			//     if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGAutoExposureConfig>.rgctx_data )
			//     {
			//       v376 = _InterlockedExchangeAdd64(
			//                (volatile signed __int64 *)&TypeInfo::HG::Rendering::Runtime::HGAutoExposureConfig,
			//                0LL);
			//       if ( (v376 & 1) != 0 )
			//       {
			//         v377 = ((unsigned int)v376 >> 1) & 0xFFFFFFF;
			//         switch ( (unsigned int)v376 >> 29 )
			//         {
			//           case 1u:
			//             v378 = sub_18003C670((unsigned int)v377);
			//             goto LABEL_414;
			//           case 2u:
			//             v378 = sub_18003C380((unsigned int)v377);
			//             goto LABEL_414;
			//           case 3u:
			//           case 6u:
			//             v378 = sub_1802DFAE0(v376);
			//             goto LABEL_414;
			//           case 4u:
			//             v378 = sub_1802DF920((unsigned int)v377);
			//             goto LABEL_414;
			//           case 5u:
			//             v379 = 8 * v377;
			//             if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v377) )
			//             {
			//               v378 = *(_QWORD *)(v379 + qword_18D8F6F98);
			//             }
			//             else
			//             {
			//               v380 = il2cpp_string_new_len(
			//                        qword_18D8E5198
			//                      + *(int *)(v379 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198 + 4)
			//                      + *(int *)(qword_18D8E51A0 + 16),
			//                        *(unsigned int *)(v379 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198));
			//               v378 = _InterlockedCompareExchange64((volatile signed __int64 *)(qword_18D8F6F98 + 8 * v377), v380, 0LL);
			//               if ( !v378 )
			//               {
			//                 if ( dword_18D8E43F8 )
			//                 {
			//                   v374 = (OneofDescriptorProto *)(0x180000000LL
			//                                                 + 8
			//                                                 * ((((unsigned __int64)(qword_18D8F6F98 + 8 * v377) >> 12) & 0x1FFFFF) >> 6)
			//                                                 + 224948432);
			//                   v381 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v377) >> 12) & 0x3F;
			//                   _m_prefetchw(v374);
			//                   do
			//                     v382 = v374.klass;
			//                   while ( v382 != (OneofDescriptorProto__Class *)_InterlockedCompareExchange64(
			//                                                                    (volatile signed __int64 *)v374,
			//                                                                    (__int64)v374.klass | (1LL << v381),
			//                                                                    (signed __int64)v374.klass) );
			//                 }
			//                 v378 = v380;
			//               }
			//             }
			//             goto LABEL_414;
			//           case 7u:
			//             v383 = sub_1802DF920((unsigned int)v377);
			//             v378 = sub_18003D1A0(v383, &v433);
			// LABEL_414:
			//             if ( v378 )
			//               _InterlockedExchange64((volatile __int64 *)&TypeInfo::HG::Rendering::Runtime::HGAutoExposureConfig, v378);
			//             break;
			//           default:
			//             break;
			//         }
			//       }
			//       if ( !v375.rgctx_data )
			//         sub_180041F40(v375);
			//     }
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGAutoExposureConfig._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGAutoExposureConfig, v374);
			//     if ( v3.fields.autoExposureConfig.m_active )
			//     {
			//       v384 = *(_DWORD *)&v3.fields.autoExposureConfig.m_active;
			//       v385 = *(_OWORD *)&v3.fields.autoExposureConfig.autoExposureEv100Range.x;
			//       v386 = *(_OWORD *)&v3.fields.autoExposureConfig.autoExposureMeteringMode;
			//       v387 = *(_QWORD *)&v3.fields.autoExposureConfig.autoExposureEvClampRange.y;
			//       *(_OWORD *)&this.fields.autoExposureConfig.autoExposureMode = *(_OWORD *)&v3.fields.autoExposureConfig.autoExposureMode;
			//       *(_OWORD *)&this.fields.autoExposureConfig.autoExposureEv100Range.x = v385;
			//       *(_OWORD *)&this.fields.autoExposureConfig.autoExposureMeteringMode = v386;
			//       *(_QWORD *)&this.fields.autoExposureConfig.autoExposureEvClampRange.y = v387;
			//       *(_DWORD *)&this.fields.autoExposureConfig.m_active = v384;
			//     }
			//     v388 = MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGShadowConfig>;
			//     if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGShadowConfig>.rgctx_data )
			//     {
			//       v389 = _InterlockedExchangeAdd64(
			//                (volatile signed __int64 *)&TypeInfo::HG::Rendering::Runtime::HGShadowConfig,
			//                0LL);
			//       if ( (v389 & 1) != 0 )
			//       {
			//         v390 = ((unsigned int)v389 >> 1) & 0xFFFFFFF;
			//         switch ( (unsigned int)v389 >> 29 )
			//         {
			//           case 1u:
			//             v391 = sub_18003C670((unsigned int)v390);
			//             goto LABEL_437;
			//           case 2u:
			//             v391 = sub_18003C380((unsigned int)v390);
			//             goto LABEL_437;
			//           case 3u:
			//           case 6u:
			//             v391 = sub_1802DFAE0(v389);
			//             goto LABEL_437;
			//           case 4u:
			//             v391 = sub_1802DF920((unsigned int)v390);
			//             goto LABEL_437;
			//           case 5u:
			//             v392 = 8 * v390;
			//             if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v390) )
			//             {
			//               v391 = *(_QWORD *)(v392 + qword_18D8F6F98);
			//             }
			//             else
			//             {
			//               v393 = il2cpp_string_new_len(
			//                        qword_18D8E5198
			//                      + *(int *)(v392 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198 + 4)
			//                      + *(int *)(qword_18D8E51A0 + 16),
			//                        *(unsigned int *)(v392 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198));
			//               v391 = _InterlockedCompareExchange64((volatile signed __int64 *)(qword_18D8F6F98 + 8 * v390), v393, 0LL);
			//               if ( !v391 )
			//               {
			//                 if ( dword_18D8E43F8 )
			//                 {
			//                   v374 = (OneofDescriptorProto *)(0x180000000LL
			//                                                 + 8
			//                                                 * ((((unsigned __int64)(qword_18D8F6F98 + 8 * v390) >> 12) & 0x1FFFFF) >> 6)
			//                                                 + 224948432);
			//                   v394 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v390) >> 12) & 0x3F;
			//                   _m_prefetchw(v374);
			//                   do
			//                     v395 = v374.klass;
			//                   while ( v395 != (OneofDescriptorProto__Class *)_InterlockedCompareExchange64(
			//                                                                    (volatile signed __int64 *)v374,
			//                                                                    (__int64)v374.klass | (1LL << v394),
			//                                                                    (signed __int64)v374.klass) );
			//                 }
			//                 v391 = v393;
			//               }
			//             }
			//             goto LABEL_437;
			//           case 7u:
			//             v396 = sub_1802DF920((unsigned int)v390);
			//             v391 = sub_18003D1A0(v396, &v433);
			// LABEL_437:
			//             if ( v391 )
			//               _InterlockedExchange64((volatile __int64 *)&TypeInfo::HG::Rendering::Runtime::HGShadowConfig, v391);
			//             break;
			//           default:
			//             break;
			//         }
			//       }
			//       if ( !v388.rgctx_data )
			//         sub_180041F40(v388);
			//     }
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGShadowConfig._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGShadowConfig, v374);
			//     if ( v3.fields.shadowConfig.m_active )
			//     {
			//       v71 = dword_18D8E43F8 == 0;
			//       v397 = *(_OWORD *)&v3.fields.shadowConfig.csmIntensity;
			//       v398 = *(_OWORD *)&v3.fields.shadowConfig.csmShadowSoftness;
			//       v399 = *(_OWORD *)&v3.fields.shadowConfig.contactShadowSurfaceThickness;
			//       v400 = *(_OWORD *)&v3.fields.shadowConfig.overrideCsmFarDistance;
			//       v401 = *(_OWORD *)&v3.fields.shadowConfig.overrideCsmSpherePosition.z;
			//       v402 = *(_QWORD *)&v3.fields.shadowConfig.csmSimulatedAttenuation;
			//       *(_OWORD *)&this.fields.shadowConfig.csmDepthBias = *(_OWORD *)&v3.fields.shadowConfig.csmDepthBias;
			//       *(_OWORD *)&this.fields.shadowConfig.csmIntensity = v397;
			//       *(_OWORD *)&this.fields.shadowConfig.csmShadowSoftness = v398;
			//       *(_OWORD *)&this.fields.shadowConfig.contactShadowSurfaceThickness = v399;
			//       *(_OWORD *)&this.fields.shadowConfig.overrideCsmFarDistance = v400;
			//       *(_OWORD *)&this.fields.shadowConfig.overrideCsmSpherePosition.z = v401;
			//       *(_QWORD *)&this.fields.shadowConfig.csmSimulatedAttenuation = v402;
			//       if ( !v71 )
			//       {
			//         v374 = (OneofDescriptorProto *)(0x180000000LL
			//                                       + 8
			//                                       * ((((unsigned __int64)&this.fields.shadowConfig.csmRampTexture >> 12) & 0x1FFFFF) >> 6)
			//                                       + 224948432);
			//         _m_prefetchw(v374);
			//         do
			//           v403 = v374.klass;
			//         while ( v403 != (OneofDescriptorProto__Class *)_InterlockedCompareExchange64(
			//                                                          (volatile signed __int64 *)v374,
			//                                                          (__int64)v374.klass | (1LL << (((unsigned __int64)&this.fields.shadowConfig.csmRampTexture >> 12) & 0x3F)),
			//                                                          (signed __int64)v374.klass) );
			//       }
			//     }
			//     v404 = MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGAnamorphicStreaksConfig>;
			//     if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGAnamorphicStreaksConfig>.rgctx_data )
			//     {
			//       v405 = _InterlockedExchangeAdd64(
			//                (volatile signed __int64 *)&TypeInfo::HG::Rendering::Runtime::HGAnamorphicStreaksConfig,
			//                0LL);
			//       if ( (v405 & 1) != 0 )
			//       {
			//         v406 = (v405 >> 1) & 0xFFFFFFF;
			//         switch ( v405 >> 29 )
			//         {
			//           case 1u:
			//             v407 = sub_18003C670((unsigned int)v406);
			//             goto LABEL_459;
			//           case 2u:
			//             v407 = sub_18003C380((unsigned int)v406);
			//             goto LABEL_459;
			//           case 3u:
			//           case 6u:
			//             v407 = sub_1802DFAE0(v405);
			//             goto LABEL_459;
			//           case 4u:
			//             v407 = sub_1802DF920((unsigned int)v406);
			//             goto LABEL_459;
			//           case 5u:
			//             v408 = 8 * v406;
			//             if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v406) )
			//             {
			//               v407 = *(_QWORD *)(v408 + qword_18D8F6F98);
			//             }
			//             else
			//             {
			//               v410 = (MessageDescriptor *)il2cpp_string_new_len(
			//                                             qword_18D8E5198
			//                                           + *(int *)(v408 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198 + 4)
			//                                           + *(int *)(qword_18D8E51A0 + 16),
			//                                             *(unsigned int *)(v408 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198));
			//               v407 = _InterlockedCompareExchange64(
			//                        (volatile signed __int64 *)(qword_18D8F6F98 + 8 * v406),
			//                        (signed __int64)v410,
			//                        0LL);
			//               if ( !v407 )
			//               {
			//                 sub_1800054D0((OneofDescriptor *)(qword_18D8F6F98 + 8 * v406), v374, v409, v410, v415, v416, v417);
			//                 v407 = v411;
			//               }
			//             }
			//             goto LABEL_459;
			//           case 7u:
			//             v412 = sub_1802DF920((unsigned int)v406);
			//             v407 = sub_18003D1A0(v412, &v433);
			// LABEL_459:
			//             if ( v407 )
			//               sub_180B3A6A0(&TypeInfo::HG::Rendering::Runtime::HGAnamorphicStreaksConfig, v407);
			//             break;
			//           default:
			//             break;
			//         }
			//       }
			//       if ( !v404.rgctx_data )
			//         sub_180041F40(v404);
			//     }
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGAnamorphicStreaksConfig._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGAnamorphicStreaksConfig, v374);
			//     if ( v3.fields.anamorphicStreaksConfig.m_active )
			//     {
			//       v413 = v3.fields.anamorphicStreaksConfig.bloomTint;
			//       v414 = *(_OWORD *)&v3.fields.anamorphicStreaksConfig.blurIntensity;
			//       *(_OWORD *)&this.fields.anamorphicStreaksConfig.enable = *(_OWORD *)&v3.fields.anamorphicStreaksConfig.enable;
			//       this.fields.anamorphicStreaksConfig.bloomTint = v413;
			//       *(_OWORD *)&this.fields.anamorphicStreaksConfig.blurIntensity = v414;
			//     }
			//   }
			// }
			// 
		}

		public void Lerp(HGEnvironmentPhase a, HGEnvironmentPhase b, float t)
		{
			// // Void Lerp(HGEnvironmentPhase, HGEnvironmentPhase, Single)
			// void HG::Rendering::Runtime::HGEnvironmentPhase::Lerp(
			//         HGEnvironmentPhase *this,
			//         HGEnvironmentPhase *a,
			//         HGEnvironmentPhase *b,
			//         float t,
			//         MethodInfo *method)
			// {
			//   MethodInfo *v5; // xmm12_8
			//   struct ILFixDynamicMethodWrapper_2__Class *v10; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   struct MethodInfo *v12; // r13
			//   struct HGAtmosphereConfig__Class *v13; // rdx
			//   __int128 v14; // xmm1
			//   __int128 v15; // xmm2
			//   __int128 v16; // xmm3
			//   Color rayleighScattering; // xmm4
			//   __int128 v18; // xmm5
			//   __int128 v19; // xmm6
			//   __int128 v20; // xmm7
			//   __int128 v21; // xmm8
			//   __int128 v22; // xmm9
			//   __int64 v23; // xmm0_8
			//   struct MethodInfo *v24; // r13
			//   struct HGFogConfig__Class *v25; // rdx
			//   __int128 v26; // xmm0
			//   int v27; // eax
			//   __int128 v28; // xmm1
			//   __int128 v29; // xmm2
			//   __int128 v30; // xmm3
			//   Color inscatterAmbientColor; // xmm4
			//   FileDescriptor *v32; // r8
			//   MessageDescriptor *v33; // r9
			//   struct MethodInfo *v34; // r13
			//   struct HGWindConfig__Class *v35; // rdx
			//   __int128 v36; // xmm1
			//   int v37; // eax
			//   __int64 v38; // xmm0_8
			//   struct MethodInfo *v39; // r13
			//   struct HGLightShaftConfig__Class *v40; // rdx
			//   __int128 v41; // xmm0
			//   int v42; // eax
			//   Color bloomTint; // xmm1
			//   __int128 v44; // xmm2
			//   struct MethodInfo *v45; // r13
			//   struct HGTerrainDeformConfig__Class *v46; // rdx
			//   int v47; // eax
			//   __int64 v48; // xmm0_8
			//   struct MethodInfo *v49; // r13
			//   struct HGInkSimulationConfig__Class *v50; // rdx
			//   __int128 v51; // xmm1
			//   __int64 v52; // xmm0_8
			//   struct MethodInfo *v53; // r13
			//   struct HGSnowConfig__Class *v54; // rdx
			//   __int128 v55; // xmm1
			//   __int128 v56; // xmm2
			//   __int128 v57; // xmm3
			//   __int128 v58; // xmm4
			//   __int64 v59; // xmm0_8
			//   FileDescriptor *v60; // r8
			//   MessageDescriptor *v61; // r9
			//   struct MethodInfo *v62; // r13
			//   struct HGLensFlareConfig__Class *v63; // rdx
			//   __int128 v64; // xmm0
			//   __int128 v65; // xmm1
			//   __int128 v66; // xmm2
			//   FileDescriptor *v67; // r8
			//   MessageDescriptor *v68; // r9
			//   struct MethodInfo *v69; // r13
			//   struct HGAutoExposureConfig__Class *v70; // rdx
			//   __int128 v71; // xmm1
			//   int v72; // eax
			//   __int128 v73; // xmm2
			//   __int128 v74; // xmm3
			//   __int64 v75; // xmm0_8
			//   struct MethodInfo *v76; // r13
			//   struct HGShadowConfig__Class *v77; // rdx
			//   __int128 v78; // xmm1
			//   __int128 v79; // xmm2
			//   __int128 v80; // xmm3
			//   __int128 v81; // xmm4
			//   __int128 v82; // xmm5
			//   __int128 v83; // xmm6
			//   __int64 v84; // xmm0_8
			//   struct MethodInfo *v85; // rbp
			//   HGAnamorphicStreaksConfig *p_anamorphicStreaksConfig; // rsi
			//   HGAnamorphicStreaksConfig *v87; // rdi
			//   HGAnamorphicStreaksConfig *v88; // rbx
			//   struct HGAnamorphicStreaksConfig__Class *v89; // rdx
			//   __int128 v90; // xmm0
			//   Color v91; // xmm1
			//   __int128 v92; // xmm2
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   String__Array *P3; // [rsp+20h] [rbp-98h]
			//   String__Array *P3a; // [rsp+20h] [rbp-98h]
			//   String__Array *P3b; // [rsp+20h] [rbp-98h]
			//   MethodInfo *v97; // [rsp+28h] [rbp-90h]
			//   MethodInfo *v98; // [rsp+30h] [rbp-88h]
			// 
			//   if ( !byte_18D8EDC46 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGAnamorphicStreaksConfig>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGAtmosphereConfig>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGAutoExposureConfig>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGCelestialConfig>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGCloudConfig>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGColorGradingConfig>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGFogConfig>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGHeightFogConfig>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGInkSimulationConfig>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGLensFlareConfig>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGLightConfig>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGLightShaftConfig>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGRainConfig>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGShadowConfig>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGSkyConfig>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGSnowConfig>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGStarConfig>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGTerrainDeformConfig>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGVolumetricFogConfig>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGWindConfig>);
			//     byte_18D8EDC46 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v10 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, a);
			//     v10 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v10.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_154;
			//   if ( wrapperArray.max_length.size <= 601 )
			//     goto LABEL_9;
			//   if ( !v10._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v10, wrapperArray);
			//     v10 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v10 = (struct ILFixDynamicMethodWrapper_2__Class *)v10.static_fields.wrapperArray;
			//   if ( !v10 )
			// LABEL_154:
			//     sub_180B536AC(v10, wrapperArray);
			//   if ( LODWORD(v10._0.namespaze) <= 0x259 )
			//     sub_180070270(v10, wrapperArray);
			//   if ( v10[12].vtable.Finalize.methodPtr )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(601, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_990(
			//         (ILFixDynamicMethodWrapper_3 *)Patch,
			//         (Object *)this,
			//         (Object *)a,
			//         (Object *)b,
			//         t,
			//         0LL);
			//       return;
			//     }
			//     goto LABEL_154;
			//   }
			// LABEL_9:
			//   if ( !a || !b )
			//     goto LABEL_154;
			//   v98 = v5;
			//   sub_182E86310(
			//     &this.fields.lightConfig,
			//     (HGWindConfig *)&a.fields.lightConfig,
			//     (HGWindConfig *)&b.fields.lightConfig,
			//     (__int64)MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGLightConfig>);
			//   sub_182E73D20(
			//     &this.fields.skyConfig,
			//     (HGWindConfig *)&a.fields.skyConfig,
			//     (HGWindConfig *)&b.fields.skyConfig,
			//     (__int64)MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGSkyConfig>);
			//   v12 = MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGAtmosphereConfig>;
			//   if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGAtmosphereConfig>.rgctx_data )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGAtmosphereConfig);
			//     sub_18003C530(&TypeInfo::UnityEngine::Mathf);
			//     if ( !v12.rgctx_data )
			//       sub_180041F40(v12);
			//   }
			//   v13 = TypeInfo::HG::Rendering::Runtime::HGAtmosphereConfig;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGAtmosphereConfig._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(
			//       TypeInfo::HG::Rendering::Runtime::HGAtmosphereConfig,
			//       TypeInfo::HG::Rendering::Runtime::HGAtmosphereConfig);
			//     v13 = TypeInfo::HG::Rendering::Runtime::HGAtmosphereConfig;
			//   }
			//   if ( a.fields.atmosphereConfig.m_active )
			//     goto LABEL_287;
			//   if ( !v13._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v13, v13);
			//     v13 = TypeInfo::HG::Rendering::Runtime::HGAtmosphereConfig;
			//   }
			//   if ( b.fields.atmosphereConfig.m_active )
			//   {
			// LABEL_287:
			//     if ( t == 0.0 )
			//       goto LABEL_173;
			//     if ( !v13._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v13, v13);
			//       v13 = TypeInfo::HG::Rendering::Runtime::HGAtmosphereConfig;
			//     }
			//     if ( !b.fields.atmosphereConfig.m_active )
			//     {
			// LABEL_173:
			//       v14 = *(_OWORD *)&a.fields.atmosphereConfig.groundRadius;
			//       v15 = *(_OWORD *)&a.fields.atmosphereConfig.groundAlbedo.a;
			//       v16 = *(_OWORD *)&a.fields.atmosphereConfig.outerSunIrradianceColor.a;
			//       rayleighScattering = a.fields.atmosphereConfig.rayleighScattering;
			//       v18 = *(_OWORD *)&a.fields.atmosphereConfig.rayleighExponentialDistribution;
			//       v19 = *(_OWORD *)&a.fields.atmosphereConfig.mieScattering.b;
			//       v20 = *(_OWORD *)&a.fields.atmosphereConfig.mieAbsorption.g;
			//       v21 = *(_OWORD *)&a.fields.atmosphereConfig.mieExponentialDistribution;
			//       v22 = *(_OWORD *)&a.fields.atmosphereConfig.ozoneAbsorption.b;
			//       v23 = *(_QWORD *)&a.fields.atmosphereConfig.tentWidth;
			//     }
			//     else
			//     {
			//       if ( t < (float)(1.0 - TypeInfo::UnityEngine::Mathf.static_fields.Epsilon) )
			//       {
			//         if ( !v13._1.cctor_finished_or_no_cctor )
			//         {
			//           il2cpp_runtime_class_init_0(v13, v13);
			//           v13 = TypeInfo::HG::Rendering::Runtime::HGAtmosphereConfig;
			//         }
			//         if ( a.fields.atmosphereConfig.m_active )
			//         {
			//           if ( !v13._1.cctor_finished_or_no_cctor )
			//             il2cpp_runtime_class_init_0(v13, v13);
			//           this.fields.atmosphereConfig.m_active = 1;
			//           HG::Rendering::Runtime::HGAtmosphereConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
			//             &this.fields.atmosphereConfig,
			//             (HGWindConfig *)&a.fields.atmosphereConfig,
			//             (HGWindConfig *)&b.fields.atmosphereConfig,
			//             t,
			//             (MethodInfo *)v12.rgctx_data[3].rgctxDataDummy);
			//           goto LABEL_22;
			//         }
			//       }
			//       v14 = *(_OWORD *)&b.fields.atmosphereConfig.groundRadius;
			//       v15 = *(_OWORD *)&b.fields.atmosphereConfig.groundAlbedo.a;
			//       v16 = *(_OWORD *)&b.fields.atmosphereConfig.outerSunIrradianceColor.a;
			//       rayleighScattering = b.fields.atmosphereConfig.rayleighScattering;
			//       v18 = *(_OWORD *)&b.fields.atmosphereConfig.rayleighExponentialDistribution;
			//       v19 = *(_OWORD *)&b.fields.atmosphereConfig.mieScattering.b;
			//       v20 = *(_OWORD *)&b.fields.atmosphereConfig.mieAbsorption.g;
			//       v21 = *(_OWORD *)&b.fields.atmosphereConfig.mieExponentialDistribution;
			//       v22 = *(_OWORD *)&b.fields.atmosphereConfig.ozoneAbsorption.b;
			//       v23 = *(_QWORD *)&b.fields.atmosphereConfig.tentWidth;
			//     }
			//     *(_OWORD *)&this.fields.atmosphereConfig.groundRadius = v14;
			//     *(_OWORD *)&this.fields.atmosphereConfig.groundAlbedo.a = v15;
			//     *(_OWORD *)&this.fields.atmosphereConfig.outerSunIrradianceColor.a = v16;
			//     this.fields.atmosphereConfig.rayleighScattering = rayleighScattering;
			//     *(_OWORD *)&this.fields.atmosphereConfig.rayleighExponentialDistribution = v18;
			//     *(_OWORD *)&this.fields.atmosphereConfig.mieScattering.b = v19;
			//     *(_OWORD *)&this.fields.atmosphereConfig.mieAbsorption.g = v20;
			//     *(_OWORD *)&this.fields.atmosphereConfig.mieExponentialDistribution = v21;
			//     *(_OWORD *)&this.fields.atmosphereConfig.ozoneAbsorption.b = v22;
			//     *(_QWORD *)&this.fields.atmosphereConfig.tentWidth = v23;
			//   }
			// LABEL_22:
			//   v24 = MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGFogConfig>;
			//   if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGFogConfig>.rgctx_data )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGFogConfig);
			//     sub_18003C530(&TypeInfo::UnityEngine::Mathf);
			//     if ( !v24.rgctx_data )
			//       sub_180041F40(v24);
			//   }
			//   v25 = TypeInfo::HG::Rendering::Runtime::HGFogConfig;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGFogConfig._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(
			//       TypeInfo::HG::Rendering::Runtime::HGFogConfig,
			//       TypeInfo::HG::Rendering::Runtime::HGFogConfig);
			//     v25 = TypeInfo::HG::Rendering::Runtime::HGFogConfig;
			//   }
			//   if ( a.fields.fogConfig.m_active )
			//     goto LABEL_288;
			//   if ( !v25._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v25, v25);
			//     v25 = TypeInfo::HG::Rendering::Runtime::HGFogConfig;
			//   }
			//   if ( b.fields.fogConfig.m_active )
			//   {
			// LABEL_288:
			//     if ( t == 0.0 )
			//       goto LABEL_184;
			//     if ( !v25._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v25, v25);
			//       v25 = TypeInfo::HG::Rendering::Runtime::HGFogConfig;
			//     }
			//     if ( !b.fields.fogConfig.m_active )
			//     {
			// LABEL_184:
			//       v26 = *(_OWORD *)&a.fields.fogConfig.enable;
			//       v27 = *(_DWORD *)&a.fields.fogConfig.m_active;
			//       v28 = *(_OWORD *)&a.fields.fogConfig.fallOffDistance;
			//       v29 = *(_OWORD *)&a.fields.fogConfig.mieScattering.a;
			//       v30 = *(_OWORD *)&a.fields.fogConfig.rayleighScattering.g;
			//       inscatterAmbientColor = a.fields.fogConfig.inscatterAmbientColor;
			//     }
			//     else
			//     {
			//       if ( t < (float)(1.0 - TypeInfo::UnityEngine::Mathf.static_fields.Epsilon) )
			//       {
			//         if ( !v25._1.cctor_finished_or_no_cctor )
			//         {
			//           il2cpp_runtime_class_init_0(v25, v25);
			//           v25 = TypeInfo::HG::Rendering::Runtime::HGFogConfig;
			//         }
			//         if ( a.fields.fogConfig.m_active )
			//         {
			//           if ( !v25._1.cctor_finished_or_no_cctor )
			//             il2cpp_runtime_class_init_0(v25, v25);
			//           this.fields.fogConfig.m_active = 1;
			//           HG::Rendering::Runtime::HGFogConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
			//             &this.fields.fogConfig,
			//             (HGWindConfig *)&a.fields.fogConfig,
			//             (HGWindConfig *)&b.fields.fogConfig,
			//             t,
			//             (MethodInfo *)v24.rgctx_data[3].rgctxDataDummy);
			//           goto LABEL_33;
			//         }
			//       }
			//       v26 = *(_OWORD *)&b.fields.fogConfig.enable;
			//       v27 = *(_DWORD *)&b.fields.fogConfig.m_active;
			//       v28 = *(_OWORD *)&b.fields.fogConfig.fallOffDistance;
			//       v29 = *(_OWORD *)&b.fields.fogConfig.mieScattering.a;
			//       v30 = *(_OWORD *)&b.fields.fogConfig.rayleighScattering.g;
			//       inscatterAmbientColor = b.fields.fogConfig.inscatterAmbientColor;
			//     }
			//     *(_OWORD *)&this.fields.fogConfig.enable = v26;
			//     *(_OWORD *)&this.fields.fogConfig.fallOffDistance = v28;
			//     *(_OWORD *)&this.fields.fogConfig.mieScattering.a = v29;
			//     *(_OWORD *)&this.fields.fogConfig.rayleighScattering.g = v30;
			//     this.fields.fogConfig.inscatterAmbientColor = inscatterAmbientColor;
			//     *(_DWORD *)&this.fields.fogConfig.m_active = v27;
			//   }
			// LABEL_33:
			//   sub_182EA7640(
			//     &this.fields.heightFogConfig,
			//     (HGWindConfig *)&a.fields.heightFogConfig,
			//     (HGWindConfig *)&b.fields.heightFogConfig,
			//     (__int64)MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGHeightFogConfig>);
			//   sub_182EDB030(
			//     &this.fields.volumetricFogConfig,
			//     (HGWindConfig *)&a.fields.volumetricFogConfig,
			//     (HGWindConfig *)&b.fields.volumetricFogConfig,
			//     (__int64)MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGVolumetricFogConfig>);
			//   sub_182EC9310(
			//     &this.fields.cloudConfig,
			//     (HGWindConfig *)&a.fields.cloudConfig,
			//     (HGWindConfig *)&b.fields.cloudConfig,
			//     (__int64)MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGCloudConfig>);
			//   sub_182E586D0(
			//     &this.fields.celestialConfig,
			//     (HGWindConfig *)&a.fields.celestialConfig,
			//     (HGWindConfig *)&b.fields.celestialConfig,
			//     (__int64)MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGCelestialConfig>);
			//   v34 = MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGWindConfig>;
			//   if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGWindConfig>.rgctx_data )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGWindConfig);
			//     sub_18003C530(&TypeInfo::UnityEngine::Mathf);
			//     if ( !v34.rgctx_data )
			//       sub_180041F40(v34);
			//   }
			//   v35 = TypeInfo::HG::Rendering::Runtime::HGWindConfig;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGWindConfig._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(
			//       TypeInfo::HG::Rendering::Runtime::HGWindConfig,
			//       TypeInfo::HG::Rendering::Runtime::HGWindConfig);
			//     v35 = TypeInfo::HG::Rendering::Runtime::HGWindConfig;
			//   }
			//   if ( a.fields.windConfig.m_active )
			//     goto LABEL_289;
			//   if ( !v35._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v35, v35);
			//     v35 = TypeInfo::HG::Rendering::Runtime::HGWindConfig;
			//   }
			//   if ( b.fields.windConfig.m_active )
			//   {
			// LABEL_289:
			//     if ( t == 0.0 )
			//       goto LABEL_195;
			//     if ( !v35._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v35, v35);
			//       v35 = TypeInfo::HG::Rendering::Runtime::HGWindConfig;
			//     }
			//     if ( !b.fields.windConfig.m_active )
			//     {
			// LABEL_195:
			//       v36 = *(_OWORD *)&a.fields.windConfig.speed;
			//       v37 = *(_DWORD *)&a.fields.windConfig.m_active;
			//       v38 = *(_QWORD *)&a.fields.windConfig.direction.y;
			//     }
			//     else
			//     {
			//       if ( t < (float)(1.0 - TypeInfo::UnityEngine::Mathf.static_fields.Epsilon) )
			//       {
			//         if ( !v35._1.cctor_finished_or_no_cctor )
			//         {
			//           il2cpp_runtime_class_init_0(v35, v35);
			//           v35 = TypeInfo::HG::Rendering::Runtime::HGWindConfig;
			//         }
			//         if ( a.fields.windConfig.m_active )
			//         {
			//           if ( !v35._1.cctor_finished_or_no_cctor )
			//             il2cpp_runtime_class_init_0(v35, v35);
			//           this.fields.windConfig.m_active = 1;
			//           HG::Rendering::Runtime::HGWindConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
			//             &this.fields.windConfig,
			//             &a.fields.windConfig,
			//             &b.fields.windConfig,
			//             t,
			//             (MethodInfo *)v34.rgctx_data[3].rgctxDataDummy);
			//           goto LABEL_44;
			//         }
			//       }
			//       v36 = *(_OWORD *)&b.fields.windConfig.speed;
			//       v37 = *(_DWORD *)&b.fields.windConfig.m_active;
			//       v38 = *(_QWORD *)&b.fields.windConfig.direction.y;
			//     }
			//     *(_OWORD *)&this.fields.windConfig.speed = v36;
			//     *(_QWORD *)&this.fields.windConfig.direction.y = v38;
			//     *(_DWORD *)&this.fields.windConfig.m_active = v37;
			//   }
			// LABEL_44:
			//   v39 = MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGLightShaftConfig>;
			//   if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGLightShaftConfig>.rgctx_data )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGLightShaftConfig);
			//     sub_18003C530(&TypeInfo::UnityEngine::Mathf);
			//     if ( !v39.rgctx_data )
			//       sub_180041F40(v39);
			//   }
			//   v40 = TypeInfo::HG::Rendering::Runtime::HGLightShaftConfig;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGLightShaftConfig._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(
			//       TypeInfo::HG::Rendering::Runtime::HGLightShaftConfig,
			//       TypeInfo::HG::Rendering::Runtime::HGLightShaftConfig);
			//     v40 = TypeInfo::HG::Rendering::Runtime::HGLightShaftConfig;
			//   }
			//   if ( a.fields.lightShaftConfig.m_active )
			//     goto LABEL_290;
			//   if ( !v40._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v40, v40);
			//     v40 = TypeInfo::HG::Rendering::Runtime::HGLightShaftConfig;
			//   }
			//   if ( b.fields.lightShaftConfig.m_active )
			//   {
			// LABEL_290:
			//     if ( t == 0.0 )
			//       goto LABEL_206;
			//     if ( !v40._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v40, v40);
			//       v40 = TypeInfo::HG::Rendering::Runtime::HGLightShaftConfig;
			//     }
			//     if ( !b.fields.lightShaftConfig.m_active )
			//     {
			// LABEL_206:
			//       v41 = *(_OWORD *)&a.fields.lightShaftConfig.enable;
			//       v42 = *(_DWORD *)&a.fields.lightShaftConfig.m_active;
			//       bloomTint = a.fields.lightShaftConfig.bloomTint;
			//       v44 = *(_OWORD *)&a.fields.lightShaftConfig.blurIntensity;
			//     }
			//     else
			//     {
			//       if ( t < (float)(1.0 - TypeInfo::UnityEngine::Mathf.static_fields.Epsilon) )
			//       {
			//         if ( !v40._1.cctor_finished_or_no_cctor )
			//         {
			//           il2cpp_runtime_class_init_0(v40, v40);
			//           v40 = TypeInfo::HG::Rendering::Runtime::HGLightShaftConfig;
			//         }
			//         if ( a.fields.lightShaftConfig.m_active )
			//         {
			//           if ( !v40._1.cctor_finished_or_no_cctor )
			//             il2cpp_runtime_class_init_0(v40, v40);
			//           this.fields.lightShaftConfig.m_active = 1;
			//           HG::Rendering::Runtime::HGLightShaftConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
			//             &this.fields.lightShaftConfig,
			//             (HGWindConfig *)&a.fields.lightShaftConfig,
			//             (HGWindConfig *)&b.fields.lightShaftConfig,
			//             t,
			//             (MethodInfo *)v39.rgctx_data[3].rgctxDataDummy);
			//           goto LABEL_55;
			//         }
			//       }
			//       v41 = *(_OWORD *)&b.fields.lightShaftConfig.enable;
			//       v42 = *(_DWORD *)&b.fields.lightShaftConfig.m_active;
			//       bloomTint = b.fields.lightShaftConfig.bloomTint;
			//       v44 = *(_OWORD *)&b.fields.lightShaftConfig.blurIntensity;
			//     }
			//     *(_OWORD *)&this.fields.lightShaftConfig.enable = v41;
			//     this.fields.lightShaftConfig.bloomTint = bloomTint;
			//     *(_OWORD *)&this.fields.lightShaftConfig.blurIntensity = v44;
			//     *(_DWORD *)&this.fields.lightShaftConfig.m_active = v42;
			//   }
			// LABEL_55:
			//   v45 = MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGTerrainDeformConfig>;
			//   if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGTerrainDeformConfig>.rgctx_data )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGTerrainDeformConfig);
			//     sub_18003C530(&TypeInfo::UnityEngine::Mathf);
			//     if ( !v45.rgctx_data )
			//       sub_180041F40(v45);
			//   }
			//   v46 = TypeInfo::HG::Rendering::Runtime::HGTerrainDeformConfig;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGTerrainDeformConfig._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(
			//       TypeInfo::HG::Rendering::Runtime::HGTerrainDeformConfig,
			//       TypeInfo::HG::Rendering::Runtime::HGTerrainDeformConfig);
			//     v46 = TypeInfo::HG::Rendering::Runtime::HGTerrainDeformConfig;
			//   }
			//   if ( a.fields.terrainDeformConfig.m_active )
			//     goto LABEL_291;
			//   if ( !v46._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v46, v46);
			//     v46 = TypeInfo::HG::Rendering::Runtime::HGTerrainDeformConfig;
			//   }
			//   if ( b.fields.terrainDeformConfig.m_active )
			//   {
			// LABEL_291:
			//     if ( t == 0.0 )
			//       goto LABEL_217;
			//     if ( !v46._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v46, v46);
			//       v46 = TypeInfo::HG::Rendering::Runtime::HGTerrainDeformConfig;
			//     }
			//     if ( !b.fields.terrainDeformConfig.m_active )
			//     {
			// LABEL_217:
			//       v47 = *(_DWORD *)&a.fields.terrainDeformConfig.m_active;
			//       v48 = *(_QWORD *)&a.fields.terrainDeformConfig.deformGlobalStrength;
			//     }
			//     else
			//     {
			//       if ( t < (float)(1.0 - TypeInfo::UnityEngine::Mathf.static_fields.Epsilon) )
			//       {
			//         if ( !v46._1.cctor_finished_or_no_cctor )
			//         {
			//           il2cpp_runtime_class_init_0(v46, v46);
			//           v46 = TypeInfo::HG::Rendering::Runtime::HGTerrainDeformConfig;
			//         }
			//         if ( a.fields.terrainDeformConfig.m_active )
			//         {
			//           if ( !v46._1.cctor_finished_or_no_cctor )
			//             il2cpp_runtime_class_init_0(v46, v46);
			//           this.fields.terrainDeformConfig.m_active = 1;
			//           HG::Rendering::Runtime::HGTerrainDeformConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
			//             &this.fields.terrainDeformConfig,
			//             (HGWindConfig *)&a.fields.terrainDeformConfig,
			//             (HGWindConfig *)&b.fields.terrainDeformConfig,
			//             t,
			//             (MethodInfo *)v45.rgctx_data[3].rgctxDataDummy);
			//           goto LABEL_66;
			//         }
			//       }
			//       v47 = *(_DWORD *)&b.fields.terrainDeformConfig.m_active;
			//       v48 = *(_QWORD *)&b.fields.terrainDeformConfig.deformGlobalStrength;
			//     }
			//     *(_QWORD *)&this.fields.terrainDeformConfig.deformGlobalStrength = v48;
			//     *(_DWORD *)&this.fields.terrainDeformConfig.m_active = v47;
			//   }
			// LABEL_66:
			//   v49 = MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGInkSimulationConfig>;
			//   if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGInkSimulationConfig>.rgctx_data )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGInkSimulationConfig);
			//     sub_18003C530(&TypeInfo::UnityEngine::Mathf);
			//     if ( !v49.rgctx_data )
			//       sub_180041F40(v49);
			//   }
			//   v50 = TypeInfo::HG::Rendering::Runtime::HGInkSimulationConfig;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGInkSimulationConfig._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(
			//       TypeInfo::HG::Rendering::Runtime::HGInkSimulationConfig,
			//       TypeInfo::HG::Rendering::Runtime::HGInkSimulationConfig);
			//     v50 = TypeInfo::HG::Rendering::Runtime::HGInkSimulationConfig;
			//   }
			//   if ( a.fields.inkSimulationConfig.m_active )
			//     goto LABEL_292;
			//   if ( !v50._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v50, v50);
			//     v50 = TypeInfo::HG::Rendering::Runtime::HGInkSimulationConfig;
			//   }
			//   if ( b.fields.inkSimulationConfig.m_active )
			//   {
			// LABEL_292:
			//     if ( t == 0.0 )
			//       goto LABEL_74;
			//     if ( !v50._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v50, v50);
			//       v50 = TypeInfo::HG::Rendering::Runtime::HGInkSimulationConfig;
			//     }
			//     if ( !b.fields.inkSimulationConfig.m_active )
			//     {
			// LABEL_74:
			//       v51 = *(_OWORD *)&a.fields.inkSimulationConfig.influence;
			//       v52 = *(_QWORD *)&a.fields.inkSimulationConfig.m_active;
			// LABEL_75:
			//       *(_OWORD *)&this.fields.inkSimulationConfig.influence = v51;
			//       *(_QWORD *)&this.fields.inkSimulationConfig.m_active = v52;
			//       sub_1800054D0(
			//         (OneofDescriptor *)&this.fields.inkSimulationConfig.material,
			//         (OneofDescriptorProto *)v50,
			//         v32,
			//         v33,
			//         P3,
			//         (String *)v97,
			//         v5);
			//       goto LABEL_76;
			//     }
			//     if ( t >= (float)(1.0 - TypeInfo::UnityEngine::Mathf.static_fields.Epsilon) )
			//       goto LABEL_229;
			//     if ( !v50._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v50, v50);
			//       v50 = TypeInfo::HG::Rendering::Runtime::HGInkSimulationConfig;
			//     }
			//     if ( !a.fields.inkSimulationConfig.m_active )
			//     {
			// LABEL_229:
			//       v51 = *(_OWORD *)&b.fields.inkSimulationConfig.influence;
			//       v52 = *(_QWORD *)&b.fields.inkSimulationConfig.m_active;
			//       goto LABEL_75;
			//     }
			//     if ( !v50._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(v50, v50);
			//     this.fields.inkSimulationConfig.m_active = 1;
			//     HG::Rendering::Runtime::HGInkSimulationConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
			//       &this.fields.inkSimulationConfig,
			//       (HGWindConfig *)&a.fields.inkSimulationConfig,
			//       (HGWindConfig *)&b.fields.inkSimulationConfig,
			//       t,
			//       (MethodInfo *)v49.rgctx_data[3].rgctxDataDummy);
			//   }
			// LABEL_76:
			//   sub_182EA7860(
			//     &this.fields.rainConfig,
			//     (HGWindConfig *)&a.fields.rainConfig,
			//     (HGWindConfig *)&b.fields.rainConfig,
			//     (__int64)MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGRainConfig>);
			//   v53 = MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGSnowConfig>;
			//   if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGSnowConfig>.rgctx_data )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGSnowConfig);
			//     sub_18003C530(&TypeInfo::UnityEngine::Mathf);
			//     if ( !v53.rgctx_data )
			//       sub_180041F40(v53);
			//   }
			//   v54 = TypeInfo::HG::Rendering::Runtime::HGSnowConfig;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGSnowConfig._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(
			//       TypeInfo::HG::Rendering::Runtime::HGSnowConfig,
			//       TypeInfo::HG::Rendering::Runtime::HGSnowConfig);
			//     v54 = TypeInfo::HG::Rendering::Runtime::HGSnowConfig;
			//   }
			//   if ( a.fields.snowConfig.m_active )
			//     goto LABEL_293;
			//   if ( !v54._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v54, v54);
			//     v54 = TypeInfo::HG::Rendering::Runtime::HGSnowConfig;
			//   }
			//   if ( b.fields.snowConfig.m_active )
			//   {
			// LABEL_293:
			//     if ( t == 0.0 )
			//       goto LABEL_84;
			//     if ( !v54._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v54, v54);
			//       v54 = TypeInfo::HG::Rendering::Runtime::HGSnowConfig;
			//     }
			//     if ( !b.fields.snowConfig.m_active )
			//     {
			// LABEL_84:
			//       v55 = *(_OWORD *)&a.fields.snowConfig.enable;
			//       v56 = *(_OWORD *)&a.fields.snowConfig.color.g;
			//       v57 = *(_OWORD *)&a.fields.snowConfig.snowSizeRange.y;
			//       v58 = *(_OWORD *)&a.fields.snowConfig.snowLightingPercent;
			//       v59 = *(_QWORD *)&a.fields.snowConfig.snowDirection.z;
			// LABEL_85:
			//       *(_OWORD *)&this.fields.snowConfig.enable = v55;
			//       *(_OWORD *)&this.fields.snowConfig.color.g = v56;
			//       *(_OWORD *)&this.fields.snowConfig.snowSizeRange.y = v57;
			//       *(_OWORD *)&this.fields.snowConfig.snowLightingPercent = v58;
			//       *(_QWORD *)&this.fields.snowConfig.snowDirection.z = v59;
			//       goto LABEL_86;
			//     }
			//     if ( t >= (float)(1.0 - TypeInfo::UnityEngine::Mathf.static_fields.Epsilon) )
			//       goto LABEL_241;
			//     if ( !v54._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v54, v54);
			//       v54 = TypeInfo::HG::Rendering::Runtime::HGSnowConfig;
			//     }
			//     if ( !a.fields.snowConfig.m_active )
			//     {
			// LABEL_241:
			//       v55 = *(_OWORD *)&b.fields.snowConfig.enable;
			//       v56 = *(_OWORD *)&b.fields.snowConfig.color.g;
			//       v57 = *(_OWORD *)&b.fields.snowConfig.snowSizeRange.y;
			//       v58 = *(_OWORD *)&b.fields.snowConfig.snowLightingPercent;
			//       v59 = *(_QWORD *)&b.fields.snowConfig.snowDirection.z;
			//       goto LABEL_85;
			//     }
			//     if ( !v54._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(v54, v54);
			//     this.fields.snowConfig.m_active = 1;
			//     HG::Rendering::Runtime::HGSnowConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
			//       &this.fields.snowConfig,
			//       (HGWindConfig *)&a.fields.snowConfig,
			//       (HGWindConfig *)&b.fields.snowConfig,
			//       t,
			//       (MethodInfo *)v53.rgctx_data[3].rgctxDataDummy);
			//   }
			// LABEL_86:
			//   sub_182ED3500(
			//     &this.fields.starConfig,
			//     (HGWindConfig *)&a.fields.starConfig,
			//     (HGWindConfig *)&b.fields.starConfig,
			//     (__int64)MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGStarConfig>);
			//   v62 = MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGLensFlareConfig>;
			//   if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGLensFlareConfig>.rgctx_data )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGLensFlareConfig);
			//     sub_18003C530(&TypeInfo::UnityEngine::Mathf);
			//     if ( !v62.rgctx_data )
			//       sub_180041F40(v62);
			//   }
			//   v63 = TypeInfo::HG::Rendering::Runtime::HGLensFlareConfig;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGLensFlareConfig._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(
			//       TypeInfo::HG::Rendering::Runtime::HGLensFlareConfig,
			//       TypeInfo::HG::Rendering::Runtime::HGLensFlareConfig);
			//     v63 = TypeInfo::HG::Rendering::Runtime::HGLensFlareConfig;
			//   }
			//   if ( a.fields.lensFlareConfig.m_active )
			//     goto LABEL_294;
			//   if ( !v63._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v63, v63);
			//     v63 = TypeInfo::HG::Rendering::Runtime::HGLensFlareConfig;
			//   }
			//   if ( b.fields.lensFlareConfig.m_active )
			//   {
			// LABEL_294:
			//     if ( t == 0.0 )
			//       goto LABEL_252;
			//     if ( !v63._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v63, v63);
			//       v63 = TypeInfo::HG::Rendering::Runtime::HGLensFlareConfig;
			//     }
			//     if ( !b.fields.lensFlareConfig.m_active )
			//     {
			// LABEL_252:
			//       v64 = *(_OWORD *)&a.fields.lensFlareConfig.enable;
			//       v65 = *(_OWORD *)&a.fields.lensFlareConfig.intensity;
			//       v66 = *(_OWORD *)&a.fields.lensFlareConfig.sampleCount;
			//     }
			//     else
			//     {
			//       if ( t < (float)(1.0 - TypeInfo::UnityEngine::Mathf.static_fields.Epsilon) )
			//       {
			//         if ( !v63._1.cctor_finished_or_no_cctor )
			//         {
			//           il2cpp_runtime_class_init_0(v63, v63);
			//           v63 = TypeInfo::HG::Rendering::Runtime::HGLensFlareConfig;
			//         }
			//         if ( a.fields.lensFlareConfig.m_active )
			//         {
			//           if ( !v63._1.cctor_finished_or_no_cctor )
			//             il2cpp_runtime_class_init_0(v63, v63);
			//           this.fields.lensFlareConfig.m_active = 1;
			//           HG::Rendering::Runtime::HGLensFlareConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
			//             &this.fields.lensFlareConfig,
			//             (HGWindConfig *)&a.fields.lensFlareConfig,
			//             (HGWindConfig *)&b.fields.lensFlareConfig,
			//             t,
			//             (MethodInfo *)v62.rgctx_data[3].rgctxDataDummy);
			//           goto LABEL_97;
			//         }
			//       }
			//       v64 = *(_OWORD *)&b.fields.lensFlareConfig.enable;
			//       v65 = *(_OWORD *)&b.fields.lensFlareConfig.intensity;
			//       v66 = *(_OWORD *)&b.fields.lensFlareConfig.sampleCount;
			//     }
			//     *(_OWORD *)&this.fields.lensFlareConfig.enable = v64;
			//     *(_OWORD *)&this.fields.lensFlareConfig.intensity = v65;
			//     *(_OWORD *)&this.fields.lensFlareConfig.sampleCount = v66;
			//     sub_1800054D0(
			//       (OneofDescriptor *)&this.fields.lensFlareConfig.lensFlareData,
			//       (OneofDescriptorProto *)v63,
			//       v60,
			//       v61,
			//       P3a,
			//       (String *)v97,
			//       v98);
			//   }
			// LABEL_97:
			//   sub_182E86540(
			//     &this.fields.colorGradingConfig,
			//     (HGWindConfig *)&a.fields.colorGradingConfig,
			//     (HGWindConfig *)&b.fields.colorGradingConfig,
			//     (__int64)MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGColorGradingConfig>);
			//   v69 = MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGAutoExposureConfig>;
			//   if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGAutoExposureConfig>.rgctx_data )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGAutoExposureConfig);
			//     sub_18003C530(&TypeInfo::UnityEngine::Mathf);
			//     if ( !v69.rgctx_data )
			//       sub_180041F40(v69);
			//   }
			//   v70 = TypeInfo::HG::Rendering::Runtime::HGAutoExposureConfig;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGAutoExposureConfig._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(
			//       TypeInfo::HG::Rendering::Runtime::HGAutoExposureConfig,
			//       TypeInfo::HG::Rendering::Runtime::HGAutoExposureConfig);
			//     v70 = TypeInfo::HG::Rendering::Runtime::HGAutoExposureConfig;
			//   }
			//   if ( a.fields.autoExposureConfig.m_active )
			//     goto LABEL_295;
			//   if ( !v70._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v70, v70);
			//     v70 = TypeInfo::HG::Rendering::Runtime::HGAutoExposureConfig;
			//   }
			//   if ( b.fields.autoExposureConfig.m_active )
			//   {
			// LABEL_295:
			//     if ( t == 0.0 )
			//       goto LABEL_131;
			//     if ( !v70._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v70, v70);
			//       v70 = TypeInfo::HG::Rendering::Runtime::HGAutoExposureConfig;
			//     }
			//     if ( !b.fields.autoExposureConfig.m_active )
			//     {
			// LABEL_131:
			//       v71 = *(_OWORD *)&a.fields.autoExposureConfig.autoExposureMode;
			//       v72 = *(_DWORD *)&a.fields.autoExposureConfig.m_active;
			//       v73 = *(_OWORD *)&a.fields.autoExposureConfig.autoExposureEv100Range.x;
			//       v74 = *(_OWORD *)&a.fields.autoExposureConfig.autoExposureMeteringMode;
			//       v75 = *(_QWORD *)&a.fields.autoExposureConfig.autoExposureEvClampRange.y;
			//     }
			//     else
			//     {
			//       if ( t < (float)(1.0 - TypeInfo::UnityEngine::Mathf.static_fields.Epsilon) )
			//       {
			//         if ( !v70._1.cctor_finished_or_no_cctor )
			//         {
			//           il2cpp_runtime_class_init_0(v70, v70);
			//           v70 = TypeInfo::HG::Rendering::Runtime::HGAutoExposureConfig;
			//         }
			//         if ( a.fields.autoExposureConfig.m_active )
			//         {
			//           if ( !v70._1.cctor_finished_or_no_cctor )
			//             il2cpp_runtime_class_init_0(v70, v70);
			//           this.fields.autoExposureConfig.m_active = 1;
			//           HG::Rendering::Runtime::HGAutoExposureConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
			//             &this.fields.autoExposureConfig,
			//             (HGWindConfig *)&a.fields.autoExposureConfig,
			//             (HGWindConfig *)&b.fields.autoExposureConfig,
			//             t,
			//             (MethodInfo *)v69.rgctx_data[3].rgctxDataDummy);
			//           goto LABEL_108;
			//         }
			//       }
			//       v71 = *(_OWORD *)&b.fields.autoExposureConfig.autoExposureMode;
			//       v72 = *(_DWORD *)&b.fields.autoExposureConfig.m_active;
			//       v73 = *(_OWORD *)&b.fields.autoExposureConfig.autoExposureEv100Range.x;
			//       v74 = *(_OWORD *)&b.fields.autoExposureConfig.autoExposureMeteringMode;
			//       v75 = *(_QWORD *)&b.fields.autoExposureConfig.autoExposureEvClampRange.y;
			//     }
			//     *(_OWORD *)&this.fields.autoExposureConfig.autoExposureMode = v71;
			//     *(_OWORD *)&this.fields.autoExposureConfig.autoExposureEv100Range.x = v73;
			//     *(_OWORD *)&this.fields.autoExposureConfig.autoExposureMeteringMode = v74;
			//     *(_QWORD *)&this.fields.autoExposureConfig.autoExposureEvClampRange.y = v75;
			//     *(_DWORD *)&this.fields.autoExposureConfig.m_active = v72;
			//   }
			// LABEL_108:
			//   v76 = MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGShadowConfig>;
			//   if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGShadowConfig>.rgctx_data )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShadowConfig);
			//     sub_18003C530(&TypeInfo::UnityEngine::Mathf);
			//     if ( !v76.rgctx_data )
			//       sub_180041F40(v76);
			//   }
			//   v77 = TypeInfo::HG::Rendering::Runtime::HGShadowConfig;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGShadowConfig._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(
			//       TypeInfo::HG::Rendering::Runtime::HGShadowConfig,
			//       TypeInfo::HG::Rendering::Runtime::HGShadowConfig);
			//     v77 = TypeInfo::HG::Rendering::Runtime::HGShadowConfig;
			//   }
			//   if ( a.fields.shadowConfig.m_active )
			//     goto LABEL_296;
			//   if ( !v77._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v77, v77);
			//     v77 = TypeInfo::HG::Rendering::Runtime::HGShadowConfig;
			//   }
			//   if ( b.fields.shadowConfig.m_active )
			//   {
			// LABEL_296:
			//     if ( t == 0.0 )
			//       goto LABEL_130;
			//     if ( !v77._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v77, v77);
			//       v77 = TypeInfo::HG::Rendering::Runtime::HGShadowConfig;
			//     }
			//     if ( !b.fields.shadowConfig.m_active )
			//     {
			// LABEL_130:
			//       v78 = *(_OWORD *)&a.fields.shadowConfig.csmDepthBias;
			//       v79 = *(_OWORD *)&a.fields.shadowConfig.csmIntensity;
			//       v80 = *(_OWORD *)&a.fields.shadowConfig.csmShadowSoftness;
			//       v81 = *(_OWORD *)&a.fields.shadowConfig.contactShadowSurfaceThickness;
			//       v82 = *(_OWORD *)&a.fields.shadowConfig.overrideCsmFarDistance;
			//       v83 = *(_OWORD *)&a.fields.shadowConfig.overrideCsmSpherePosition.z;
			//       v84 = *(_QWORD *)&a.fields.shadowConfig.csmSimulatedAttenuation;
			//     }
			//     else
			//     {
			//       if ( t < (float)(1.0 - TypeInfo::UnityEngine::Mathf.static_fields.Epsilon) )
			//       {
			//         if ( !v77._1.cctor_finished_or_no_cctor )
			//         {
			//           il2cpp_runtime_class_init_0(v77, v77);
			//           v77 = TypeInfo::HG::Rendering::Runtime::HGShadowConfig;
			//         }
			//         if ( a.fields.shadowConfig.m_active )
			//         {
			//           if ( !v77._1.cctor_finished_or_no_cctor )
			//             il2cpp_runtime_class_init_0(v77, v77);
			//           this.fields.shadowConfig.m_active = 1;
			//           HG::Rendering::Runtime::HGShadowConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
			//             &this.fields.shadowConfig,
			//             (HGWindConfig *)&a.fields.shadowConfig,
			//             (HGWindConfig *)&b.fields.shadowConfig,
			//             t,
			//             (MethodInfo *)v76.rgctx_data[3].rgctxDataDummy);
			//           goto LABEL_119;
			//         }
			//       }
			//       v78 = *(_OWORD *)&b.fields.shadowConfig.csmDepthBias;
			//       v79 = *(_OWORD *)&b.fields.shadowConfig.csmIntensity;
			//       v80 = *(_OWORD *)&b.fields.shadowConfig.csmShadowSoftness;
			//       v81 = *(_OWORD *)&b.fields.shadowConfig.contactShadowSurfaceThickness;
			//       v82 = *(_OWORD *)&b.fields.shadowConfig.overrideCsmFarDistance;
			//       v83 = *(_OWORD *)&b.fields.shadowConfig.overrideCsmSpherePosition.z;
			//       v84 = *(_QWORD *)&b.fields.shadowConfig.csmSimulatedAttenuation;
			//     }
			//     *(_OWORD *)&this.fields.shadowConfig.csmDepthBias = v78;
			//     *(_OWORD *)&this.fields.shadowConfig.csmIntensity = v79;
			//     *(_OWORD *)&this.fields.shadowConfig.csmShadowSoftness = v80;
			//     *(_OWORD *)&this.fields.shadowConfig.contactShadowSurfaceThickness = v81;
			//     *(_OWORD *)&this.fields.shadowConfig.overrideCsmFarDistance = v82;
			//     *(_OWORD *)&this.fields.shadowConfig.overrideCsmSpherePosition.z = v83;
			//     *(_QWORD *)&this.fields.shadowConfig.csmSimulatedAttenuation = v84;
			//     sub_1800054D0(
			//       (OneofDescriptor *)&this.fields.shadowConfig.csmRampTexture,
			//       (OneofDescriptorProto *)v77,
			//       v67,
			//       v68,
			//       P3b,
			//       (String *)v97,
			//       v98);
			//   }
			// LABEL_119:
			//   v85 = MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGAnamorphicStreaksConfig>;
			//   p_anamorphicStreaksConfig = &this.fields.anamorphicStreaksConfig;
			//   v87 = &a.fields.anamorphicStreaksConfig;
			//   v88 = &b.fields.anamorphicStreaksConfig;
			//   if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGAnamorphicStreaksConfig>.rgctx_data )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGAnamorphicStreaksConfig);
			//     sub_18003C530(&TypeInfo::UnityEngine::Mathf);
			//     if ( !v85.rgctx_data )
			//       sub_180041F40(v85);
			//   }
			//   v89 = TypeInfo::HG::Rendering::Runtime::HGAnamorphicStreaksConfig;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGAnamorphicStreaksConfig._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(
			//       TypeInfo::HG::Rendering::Runtime::HGAnamorphicStreaksConfig,
			//       TypeInfo::HG::Rendering::Runtime::HGAnamorphicStreaksConfig);
			//     v89 = TypeInfo::HG::Rendering::Runtime::HGAnamorphicStreaksConfig;
			//   }
			//   if ( v87.m_active )
			//     goto LABEL_297;
			//   if ( !v89._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v89, v89);
			//     v89 = TypeInfo::HG::Rendering::Runtime::HGAnamorphicStreaksConfig;
			//   }
			//   if ( v88.m_active )
			//   {
			// LABEL_297:
			//     if ( t == 0.0 )
			//       goto LABEL_127;
			//     if ( !v89._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v89, v89);
			//       v89 = TypeInfo::HG::Rendering::Runtime::HGAnamorphicStreaksConfig;
			//     }
			//     if ( !v88.m_active )
			//     {
			// LABEL_127:
			//       v90 = *(_OWORD *)&v87.enable;
			//       v91 = v87.bloomTint;
			//       v92 = *(_OWORD *)&v87.blurIntensity;
			// LABEL_128:
			//       *(_OWORD *)&p_anamorphicStreaksConfig.enable = v90;
			//       p_anamorphicStreaksConfig.bloomTint = v91;
			//       *(_OWORD *)&p_anamorphicStreaksConfig.blurIntensity = v92;
			//       return;
			//     }
			//     if ( t >= (float)(1.0 - TypeInfo::UnityEngine::Mathf.static_fields.Epsilon) )
			//       goto LABEL_284;
			//     if ( !v89._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v89, v89);
			//       v89 = TypeInfo::HG::Rendering::Runtime::HGAnamorphicStreaksConfig;
			//     }
			//     if ( !v87.m_active )
			//     {
			// LABEL_284:
			//       v90 = *(_OWORD *)&v88.enable;
			//       v91 = v88.bloomTint;
			//       v92 = *(_OWORD *)&v88.blurIntensity;
			//       goto LABEL_128;
			//     }
			//     if ( !v89._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(v89, v89);
			//     p_anamorphicStreaksConfig.m_active = 1;
			//     HG::Rendering::Runtime::HGAnamorphicStreaksConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
			//       p_anamorphicStreaksConfig,
			//       (HGWindConfig *)v87,
			//       (HGWindConfig *)v88,
			//       t,
			//       (MethodInfo *)v85.rgctx_data[3].rgctxDataDummy);
			//   }
			// }
			// 
		}

		public void ActivateAllEnvConfig(bool value)
		{
			// // Void ActivateAllEnvConfig(Boolean)
			// void HG::Rendering::Runtime::HGEnvironmentPhase::ActivateAllEnvConfig(
			//         HGEnvironmentPhase *this,
			//         bool value,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			// 
			//   if ( !byte_18D8EDC47 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGAnamorphicStreaksConfig);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGAtmosphereConfig);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGAutoExposureConfig);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCelestialConfig);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCloudConfig);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGFogConfig);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGHeightFogConfig);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGInkSimulationConfig);
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
			//     byte_18D8EDC47 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1218, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1218, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_13((ILFixDynamicMethodWrapper_28 *)Patch, (Object *)this, value, 0LL);
			//   }
			//   else
			//   {
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGLightConfig._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGLightConfig, v5);
			//     this.fields.lightConfig.m_active = value;
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGSkyConfig._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGSkyConfig, v5);
			//     this.fields.skyConfig.m_active = value;
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGAtmosphereConfig._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGAtmosphereConfig, v5);
			//     this.fields.atmosphereConfig.m_active = value;
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGFogConfig._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGFogConfig, v5);
			//     this.fields.fogConfig.m_active = value;
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGHeightFogConfig._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGHeightFogConfig, v5);
			//     this.fields.heightFogConfig.m_active = value;
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig, v5);
			//     this.fields.volumetricFogConfig.m_active = value;
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGCloudConfig._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCloudConfig, v5);
			//     this.fields.cloudConfig.m_active = value;
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGCelestialConfig._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCelestialConfig, v5);
			//     this.fields.celestialConfig.m_active = value;
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGWindConfig._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGWindConfig, v5);
			//     this.fields.windConfig.m_active = value;
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGLightShaftConfig._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGLightShaftConfig, v5);
			//     this.fields.lightShaftConfig.m_active = value;
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGTerrainDeformConfig._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGTerrainDeformConfig, v5);
			//     this.fields.terrainDeformConfig.m_active = value;
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGInkSimulationConfig._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGInkSimulationConfig, v5);
			//     this.fields.inkSimulationConfig.m_active = value;
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGRainConfig._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRainConfig, v5);
			//     this.fields.rainConfig.m_active = value;
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGSnowConfig._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGSnowConfig, v5);
			//     this.fields.snowConfig.m_active = value;
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGStarConfig._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGStarConfig, v5);
			//     this.fields.starConfig.m_active = value;
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGLensFlareConfig._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGLensFlareConfig, v5);
			//     this.fields.lensFlareConfig.m_active = value;
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig, v5);
			//     this.fields.colorGradingConfig.m_active = value;
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGAutoExposureConfig._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGAutoExposureConfig, v5);
			//     this.fields.autoExposureConfig.m_active = value;
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGShadowConfig._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGShadowConfig, v5);
			//     this.fields.shadowConfig.m_active = value;
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGAnamorphicStreaksConfig._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGAnamorphicStreaksConfig, v5);
			//     this.fields.anamorphicStreaksConfig.m_active = value;
			//   }
			// }
			// 
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

		public HGInkSimulationConfig inkSimulationConfig;

		public HGRainConfig rainConfig;

		public HGSnowConfig snowConfig;

		public HGStarConfig starConfig;

		public HGLensFlareConfig lensFlareConfig;

		public HGColorGradingConfig colorGradingConfig;

		public HGAutoExposureConfig autoExposureConfig;

		public HGShadowConfig shadowConfig;

		public HGAnamorphicStreaksConfig anamorphicStreaksConfig;
	}
}
