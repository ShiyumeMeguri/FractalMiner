using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[CreateAssetMenu(fileName = "Env_", menuName = "\u2605 Beyond/Env Phase")]
	public class HGEnvironmentPhase : ScriptableObject // TypeDefIndex: 37635
	{
		// Fields
		public HGLightConfig lightConfig; // 0x18
		public HGSkyConfig skyConfig; // 0x190
		public HGAtmosphereConfig atmosphereConfig; // 0x2E8
		public HGFogConfig fogConfig; // 0x380
		public HGHeightFogConfig heightFogConfig; // 0x3D4
		public HGVolumetricFogConfig volumetricFogConfig; // 0x4B0
		public HGVolumetricCloudConfig volumetricCloudConfig; // 0x620
		public HGCloudConfig cloudConfig; // 0x628
		public HGCelestialConfig celestialConfig; // 0x6D8
		public HGWindConfig windConfig; // 0x840
		public HGLightShaftConfig lightShaftConfig; // 0x85C
		public HGTerrainDeformConfig terrainDeformConfig; // 0x890
		public HGInkSimulationConfig inkSimulationConfig; // 0x8A0
		public HGRainConfig rainConfig; // 0x918
		public HGSnowConfig snowConfig; // 0xA48
		public HGStarConfig starConfig; // 0xAA0
		public HGLensFlareConfig lensFlareConfig; // 0xB38
		public HGColorGradingConfig colorGradingConfig; // 0xB68
		public HGAutoExposureConfig autoExposureConfig; // 0xCD8
		public HGShadowConfig shadowConfig; // 0xD18
		public HGAnamorphicStreaksConfig anamorphicStreaksConfig; // 0xD98
		public HGWaterEnvConfig waterEnvConfig; // 0xDC8
		public HGInkWashConfig inkWashConfig; // 0xDD8
	
		// Constructors
		public HGEnvironmentPhase() {} // 0x0000000184065730-0x00000001840668C0
		// HGEnvironmentPhase()
		void HG::Rendering::Runtime::HGEnvironmentPhase::HGEnvironmentPhase(HGEnvironmentPhase *this, MethodInfo *method)
		{
		  PropertyInfo_1 *v2; // r8
		  Int32__Array **v3; // r9
		  struct HGLightConfig__Class *v5; // rax
		  HGLightConfig__StaticFields *static_fields; // rax
		  Color *v7; // rcx
		  __int64 v8; // rdi
		  __int64 v9; // rdx
		  Color directColor; // xmm0
		  Color v11; // xmm1
		  Color v12; // xmm0
		  Color v13; // xmm1
		  Color v14; // xmm0
		  Color v15; // xmm1
		  Color v16; // xmm0
		  Color v17; // xmm1
		  __int64 v18; // rdx
		  Color v19; // xmm1
		  Color v20; // xmm0
		  Color v21; // xmm1
		  Color v22; // xmm0
		  Color v23; // xmm1
		  Color v24; // xmm0
		  int32_t sunDiscPitchYawMode; // eax
		  HGLightConfig *p_lightConfig; // rcx
		  Color *v27; // rax
		  Color v28; // xmm0
		  Color v29; // xmm1
		  Color v30; // xmm0
		  Color v31; // xmm1
		  Color v32; // xmm0
		  Color v33; // xmm1
		  Color v34; // xmm0
		  Color v35; // xmm1
		  Color v36; // xmm1
		  Color v37; // xmm0
		  Color v38; // xmm1
		  Color v39; // xmm0
		  Color v40; // xmm1
		  Color v41; // xmm0
		  int32_t r_low; // eax
		  struct HGSkyConfig__Class *v43; // rax
		  HGSkyConfig__StaticFields *v44; // rax
		  __int128 *v45; // rcx
		  __int64 v46; // rdx
		  __int128 v47; // xmm0
		  __int128 v48; // xmm1
		  __int128 v49; // xmm0
		  __int128 v50; // xmm1
		  __int128 v51; // xmm0
		  __int128 v52; // xmm1
		  __int128 v53; // xmm0
		  __int128 v54; // xmm1
		  __int64 v55; // rdx
		  __int128 v56; // xmm1
		  __int128 v57; // xmm0
		  __int128 v58; // xmm1
		  __int128 v59; // xmm0
		  __int64 v60; // rax
		  HGSkyConfig *p_skyConfig; // rcx
		  __int128 *v62; // rax
		  __int128 v63; // xmm0
		  __int128 v64; // xmm1
		  __int128 v65; // xmm0
		  __int128 v66; // xmm1
		  __int128 v67; // xmm0
		  __int128 v68; // xmm1
		  __int128 v69; // xmm0
		  __int128 v70; // xmm1
		  __int128 v71; // xmm1
		  __int128 v72; // xmm0
		  __int128 v73; // xmm1
		  __int128 v74; // xmm0
		  __int64 v75; // rax
		  PropertyInfo_1 *v76; // r8
		  Int32__Array **v77; // r9
		  struct HGAtmosphereConfig__Class *v78; // rax
		  HGAtmosphereConfig__StaticFields *v79; // rax
		  __int128 v80; // xmm2
		  __int128 v81; // xmm3
		  Color rayleighScattering; // xmm4
		  __int128 v83; // xmm5
		  __int128 v84; // xmm6
		  __int128 v85; // xmm7
		  __int128 v86; // xmm8
		  __int128 v87; // xmm9
		  __int64 v88; // xmm0_8
		  struct HGFogConfig__Class *v89; // rax
		  HGFogConfig__StaticFields *v90; // rax
		  int v91; // ecx
		  __int128 v92; // xmm1
		  __int128 v93; // xmm2
		  __int128 v94; // xmm3
		  Color inscatterAmbientColor; // xmm4
		  struct HGHeightFogConfig__Class *v96; // rcx
		  HGHeightFogConfig__StaticFields *v97; // rcx
		  Color v98; // xmm1
		  __int128 v99; // xmm0
		  __int128 v100; // xmm1
		  __int128 v101; // xmm0
		  __int128 v102; // xmm1
		  Color heightFogDirectionalInscatteringMobile; // xmm0
		  __int128 v104; // xmm1
		  __int64 v105; // rax
		  __int128 v106; // xmm1
		  __int128 v107; // xmm0
		  __int128 v108; // xmm1
		  __int128 v109; // xmm0
		  Color v110; // xmm1
		  __int128 v111; // xmm0
		  __int128 v112; // xmm1
		  __int128 v113; // xmm0
		  __int128 v114; // xmm1
		  Color v115; // xmm0
		  __int128 v116; // xmm1
		  __int128 v117; // xmm0
		  __int128 v118; // xmm1
		  __int128 v119; // xmm0
		  __int128 v120; // xmm1
		  __int128 v121; // xmm0
		  struct HGVolumetricFogConfig__Class *v122; // rax
		  HGVolumetricFogConfig__StaticFields *v123; // rax
		  __int128 *v124; // rcx
		  __int64 v125; // rdx
		  __int128 v126; // xmm0
		  __int128 v127; // xmm1
		  __int128 v128; // xmm0
		  __int128 v129; // xmm1
		  __int128 v130; // xmm0
		  __int128 v131; // xmm1
		  __int128 v132; // xmm0
		  __int128 v133; // xmm1
		  __int64 v134; // rdx
		  __int128 v135; // xmm1
		  __int128 v136; // xmm0
		  __int128 v137; // xmm1
		  __int128 v138; // xmm0
		  __int128 v139; // xmm1
		  __int128 v140; // xmm0
		  HGVolumetricFogConfig *p_volumetricFogConfig; // rax
		  __int128 *v142; // rcx
		  __int128 v143; // xmm0
		  __int128 v144; // xmm1
		  __int128 v145; // xmm0
		  __int128 v146; // xmm1
		  __int128 v147; // xmm0
		  __int128 v148; // xmm1
		  __int128 v149; // xmm0
		  __int128 v150; // xmm1
		  __int128 v151; // xmm1
		  __int128 v152; // xmm0
		  __int128 v153; // xmm1
		  __int128 v154; // xmm0
		  __int128 v155; // xmm1
		  __int128 v156; // xmm0
		  PropertyInfo_1 *v157; // r8
		  Int32__Array **v158; // r9
		  struct HGVolumetricCloudConfig__Class *v159; // rax
		  HGVolumetricCloudConfig__StaticFields *v160; // rax
		  Type *m_active; // rdx
		  struct HGCloudConfig__Class *v162; // rax
		  HGCloudConfig__StaticFields *v163; // rax
		  Color cloudTint; // xmm1
		  __int128 v165; // xmm0
		  __int128 v166; // xmm1
		  __int128 v167; // xmm0
		  __int128 v168; // xmm1
		  Color v169; // xmm0
		  __int128 v170; // xmm1
		  __int128 v171; // xmm0
		  __int128 v172; // xmm1
		  __int128 v173; // xmm0
		  Color v174; // xmm1
		  __int128 v175; // xmm0
		  __int128 v176; // xmm1
		  __int128 v177; // xmm0
		  __int128 v178; // xmm1
		  Color v179; // xmm0
		  __int128 v180; // xmm1
		  __int128 v181; // xmm0
		  __int128 v182; // xmm1
		  __int128 v183; // xmm0
		  PropertyInfo_1 *v184; // r8
		  Int32__Array **v185; // r9
		  struct HGCelestialConfig__Class *v186; // rax
		  HGCelestialConfig__StaticFields *v187; // rax
		  __int128 *v188; // rcx
		  __int64 v189; // rdx
		  __int128 v190; // xmm0
		  __int128 v191; // xmm1
		  __int128 v192; // xmm0
		  __int128 v193; // xmm1
		  __int128 v194; // xmm0
		  __int128 v195; // xmm1
		  __int128 v196; // xmm0
		  __int128 v197; // xmm1
		  __int64 v198; // rdx
		  __int128 v199; // xmm1
		  __int128 v200; // xmm0
		  __int128 v201; // xmm1
		  __int128 v202; // xmm0
		  __int128 v203; // xmm1
		  Material *drawMaterial; // rax
		  HGCelestialConfig *p_celestialConfig; // rcx
		  __int128 *v206; // rax
		  __int128 v207; // xmm0
		  __int128 v208; // xmm1
		  __int128 v209; // xmm0
		  __int128 v210; // xmm1
		  __int128 v211; // xmm0
		  __int128 v212; // xmm1
		  __int128 v213; // xmm0
		  __int128 v214; // xmm1
		  __int128 v215; // xmm1
		  __int128 v216; // xmm0
		  __int128 v217; // xmm1
		  __int128 v218; // xmm0
		  __int128 v219; // xmm1
		  Material *v220; // rax
		  Type *v221; // rdx
		  PropertyInfo_1 *v222; // r8
		  Int32__Array **v223; // r9
		  struct HGWindConfig__Class *v224; // rax
		  HGWindConfig__StaticFields *v225; // rax
		  int v226; // ecx
		  __int64 v227; // xmm0_8
		  struct HGLightShaftConfig__Class *v228; // rax
		  HGLightShaftConfig__StaticFields *v229; // rax
		  int v230; // ecx
		  Color bloomTint; // xmm1
		  __int128 v232; // xmm2
		  struct HGTerrainDeformConfig__Class *v233; // rax
		  HGTerrainDeformConfig__StaticFields *v234; // rax
		  int v235; // ecx
		  struct HGInkSimulationConfig__Class *v236; // rax
		  HGInkSimulationConfig__StaticFields *v237; // rax
		  __int128 v238; // xmm2
		  __int128 v239; // xmm3
		  __int128 v240; // xmm4
		  __int128 v241; // xmm5
		  __int128 v242; // xmm6
		  __int128 v243; // xmm7
		  __int64 v244; // xmm0_8
		  PropertyInfo_1 *v245; // r8
		  Int32__Array **v246; // r9
		  struct HGRainConfig__Class *v247; // rax
		  HGRainConfig__StaticFields *v248; // rax
		  __int128 *v249; // rcx
		  __int64 v250; // rdx
		  __int128 v251; // xmm0
		  __int128 v252; // xmm1
		  __int128 v253; // xmm0
		  __int128 v254; // xmm1
		  __int128 v255; // xmm0
		  __int128 v256; // xmm1
		  __int128 v257; // xmm0
		  __int128 v258; // xmm1
		  __int64 v259; // rdx
		  __int128 v260; // xmm1
		  __int128 v261; // xmm0
		  HGRainConfig *p_rainConfig; // rax
		  __int128 *v263; // rcx
		  __int128 v264; // xmm0
		  __int128 v265; // xmm1
		  __int128 v266; // xmm0
		  __int128 v267; // xmm1
		  __int128 v268; // xmm0
		  __int128 v269; // xmm1
		  __int128 v270; // xmm0
		  __int128 v271; // xmm1
		  __int128 v272; // xmm1
		  __int128 v273; // xmm0
		  struct HGSnowConfig__Class *v274; // rax
		  HGSnowConfig__StaticFields *v275; // rax
		  Color color; // xmm2
		  __int128 v277; // xmm3
		  __int128 v278; // xmm4
		  __int128 v279; // xmm5
		  __int64 v280; // xmm0_8
		  struct HGStarConfig__Class *v281; // rax
		  HGStarConfig__StaticFields *v282; // rax
		  __int128 v283; // xmm2
		  __int128 v284; // xmm3
		  __int128 v285; // xmm4
		  __int128 v286; // xmm5
		  __int128 v287; // xmm6
		  __int128 v288; // xmm7
		  __int128 v289; // xmm8
		  __int128 v290; // xmm9
		  __int64 v291; // xmm0_8
		  Type *v292; // rdx
		  PropertyInfo_1 *v293; // r8
		  Int32__Array **v294; // r9
		  struct HGLensFlareConfig__Class *v295; // rax
		  HGLensFlareConfig__StaticFields *v296; // rax
		  __int128 v297; // xmm1
		  __int128 v298; // xmm2
		  PropertyInfo_1 *v299; // r8
		  Int32__Array **v300; // r9
		  struct HGColorGradingConfig__Class *v301; // rax
		  __int128 *v302; // rcx
		  HGColorGradingConfig *p_defaultConfig; // rax
		  __int64 v304; // rdx
		  __int128 v305; // xmm0
		  __int128 v306; // xmm1
		  __int128 v307; // xmm0
		  __int128 v308; // xmm1
		  __int128 v309; // xmm0
		  __int128 v310; // xmm1
		  __int128 v311; // xmm0
		  __int128 v312; // xmm1
		  __int128 v313; // xmm1
		  __int128 v314; // xmm0
		  __int128 v315; // xmm1
		  __int128 v316; // xmm0
		  __int128 v317; // xmm1
		  __int128 v318; // xmm0
		  HGColorGradingConfig *p_colorGradingConfig; // rax
		  __int128 *v320; // rcx
		  __int128 v321; // xmm0
		  __int128 v322; // xmm1
		  __int128 v323; // xmm0
		  __int128 v324; // xmm1
		  __int128 v325; // xmm0
		  __int128 v326; // xmm1
		  __int128 v327; // xmm0
		  __int128 v328; // xmm1
		  __int128 v329; // xmm1
		  __int128 v330; // xmm0
		  __int128 v331; // xmm1
		  __int128 v332; // xmm0
		  __int128 v333; // xmm1
		  __int128 v334; // xmm0
		  Type *v335; // rdx
		  PropertyInfo_1 *v336; // r8
		  Int32__Array **v337; // r9
		  struct HGAutoExposureConfig__Class *v338; // rax
		  HGAutoExposureConfig__StaticFields *v339; // rax
		  int v340; // ecx
		  __int128 v341; // xmm2
		  __int128 v342; // xmm3
		  __int64 v343; // xmm0_8
		  struct HGShadowConfig__Class *v344; // rax
		  _OWORD *p_r; // rax
		  __int128 v346; // xmm1
		  __int128 v347; // xmm2
		  __int128 v348; // xmm3
		  __int128 v349; // xmm4
		  __int128 v350; // xmm5
		  __int128 v351; // xmm6
		  __int128 v352; // xmm7
		  Type *v353; // rdx
		  PropertyInfo_1 *v354; // r8
		  Int32__Array **v355; // r9
		  struct HGAnamorphicStreaksConfig__Class *v356; // rax
		  HGAnamorphicStreaksConfig__StaticFields *v357; // rax
		  Color v358; // xmm1
		  __int128 v359; // xmm2
		  struct HGWaterEnvConfig__Class *v360; // rax
		  HGWaterEnvConfig__StaticFields *v361; // rax
		  int v362; // ecx
		  struct HGInkWashConfig__Class *v363; // rax
		  HGInkWashConfig__StaticFields *v364; // rax
		  Color v365; // xmm1
		  __int128 v366; // xmm0
		  __int128 v367; // xmm1
		  __int128 v368; // xmm0
		  __int128 v369; // xmm1
		  Color v370; // xmm0
		  __int128 v371; // xmm1
		  __int128 v372; // xmm0
		  __int128 v373; // xmm1
		  Color v374; // xmm1
		  __int128 v375; // xmm0
		  __int128 v376; // xmm1
		  __int128 v377; // xmm0
		  __int128 v378; // xmm1
		  Color v379; // xmm0
		  __int128 v380; // xmm1
		  __int128 v381; // xmm0
		  __int128 v382; // xmm1
		  __int128 v383; // [rsp+20h] [rbp-1C8h] BYREF
		  Color v384; // [rsp+30h] [rbp-1B8h]
		  __int128 v385; // [rsp+40h] [rbp-1A8h]
		  __int128 v386; // [rsp+50h] [rbp-198h]
		  __int128 v387; // [rsp+60h] [rbp-188h]
		  __int128 v388; // [rsp+70h] [rbp-178h]
		  Color v389; // [rsp+80h] [rbp-168h]
		  __int128 v390; // [rsp+90h] [rbp-158h]
		  __int128 v391; // [rsp+A0h] [rbp-148h]
		  __int128 v392; // [rsp+B0h] [rbp-138h]
		  __int128 v393; // [rsp+C0h] [rbp-128h]
		  __int128 v394; // [rsp+D0h] [rbp-118h]
		  __int128 v395; // [rsp+E0h] [rbp-108h]
		  __int64 v396; // [rsp+F0h] [rbp-F8h]
		  float a; // [rsp+F8h] [rbp-F0h]
		
		  v5 = TypeInfo::HG::Rendering::Runtime::HGLightConfig;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGLightConfig->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGLightConfig);
		    v5 = TypeInfo::HG::Rendering::Runtime::HGLightConfig;
		  }
		  static_fields = v5->static_fields;
		  v7 = (Color *)&v383;
		  v8 = 2LL;
		  v9 = 2LL;
		  do
		  {
		    v7 += 8;
		    directColor = static_fields->defaultConfig.directColor;
		    v11 = *(Color *)&static_fields->defaultConfig.directColorMode;
		    static_fields = (HGLightConfig__StaticFields *)((char *)static_fields + 128);
		    v7[-8] = directColor;
		    v12 = *(Color *)&static_fields[-1].defaultConfig.rotationAtmosphere.y;
		    v7[-7] = v11;
		    v13 = *(Color *)&static_fields[-1].defaultConfig.rotationLightShaft.y;
		    v7[-6] = v12;
		    v14 = *(Color *)&static_fields[-1].defaultConfig.rotationSunDisc.y;
		    v7[-5] = v13;
		    v15 = *(Color *)&static_fields[-1].defaultConfig.rotationLensFlare.y;
		    v7[-4] = v14;
		    v16 = *(Color *)&static_fields[-1].defaultConfig.rotationCloudShadow.y;
		    v7[-3] = v15;
		    v17 = *(Color *)&static_fields[-1].defaultConfig.rotationHeightFogDirectionalInscattering.y;
		    v7[-2] = v16;
		    v7[-1] = v17;
		    --v9;
		  }
		  while ( v9 );
		  v18 = 2LL;
		  v19 = *(Color *)&static_fields->defaultConfig.directColorMode;
		  *v7 = static_fields->defaultConfig.directColor;
		  v20 = *(Color *)&static_fields->defaultConfig.directCustomColor.a;
		  v7[1] = v19;
		  v21 = *(Color *)&static_fields->defaultConfig.directSpecularIntensity;
		  v7[2] = v20;
		  v22 = *(Color *)&static_fields->defaultConfig.directPitchYaw.y;
		  v7[3] = v21;
		  v23 = *(Color *)&static_fields->defaultConfig.indirectSpecularFactor;
		  v7[4] = v22;
		  v24 = *(Color *)&static_fields->defaultConfig.atmospherePitchYaw.y;
		  sunDiscPitchYawMode = static_fields->defaultConfig.sunDiscPitchYawMode;
		  v7[5] = v23;
		  v7[6] = v24;
		  LODWORD(v7[7].r) = sunDiscPitchYawMode;
		  p_lightConfig = &this->fields.lightConfig;
		  v27 = (Color *)&v383;
		  do
		  {
		    p_lightConfig = (HGLightConfig *)((char *)p_lightConfig + 128);
		    v28 = *v27;
		    v29 = v27[1];
		    v27 += 8;
		    *(Color *)&p_lightConfig[-1].localToWorld.m12 = v28;
		    v30 = v27[-6];
		    *(Color *)&p_lightConfig[-1].localToWorld.m13 = v29;
		    v31 = v27[-5];
		    *(Color *)&p_lightConfig[-1].rotationAtmosphere.y = v30;
		    v32 = v27[-4];
		    *(Color *)&p_lightConfig[-1].rotationLightShaft.y = v31;
		    v33 = v27[-3];
		    *(Color *)&p_lightConfig[-1].rotationSunDisc.y = v32;
		    v34 = v27[-2];
		    *(Color *)&p_lightConfig[-1].rotationLensFlare.y = v33;
		    v35 = v27[-1];
		    *(Color *)&p_lightConfig[-1].rotationCloudShadow.y = v34;
		    *(Color *)&p_lightConfig[-1].rotationHeightFogDirectionalInscattering.y = v35;
		    --v18;
		  }
		  while ( v18 );
		  v36 = v27[1];
		  p_lightConfig->directColor = *v27;
		  v37 = v27[2];
		  *(Color *)&p_lightConfig->directColorMode = v36;
		  v38 = v27[3];
		  *(Color *)&p_lightConfig->directCustomColor.a = v37;
		  v39 = v27[4];
		  *(Color *)&p_lightConfig->directSpecularIntensity = v38;
		  v40 = v27[5];
		  *(Color *)&p_lightConfig->directPitchYaw.y = v39;
		  v41 = v27[6];
		  r_low = LODWORD(v27[7].r);
		  *(Color *)&p_lightConfig->indirectSpecularFactor = v40;
		  *(Color *)&p_lightConfig->atmospherePitchYaw.y = v41;
		  p_lightConfig->sunDiscPitchYawMode = r_low;
		  v43 = TypeInfo::HG::Rendering::Runtime::HGSkyConfig;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGSkyConfig->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGSkyConfig);
		    v43 = TypeInfo::HG::Rendering::Runtime::HGSkyConfig;
		  }
		  v44 = v43->static_fields;
		  v45 = &v383;
		  v46 = 2LL;
		  do
		  {
		    v45 += 8;
		    v47 = *(_OWORD *)&v44->defaultConfig.parentEnvPhaseGuid;
		    v48 = *(_OWORD *)&v44->defaultConfig.skyDirectIntensity;
		    v44 = (HGSkyConfig__StaticFields *)((char *)v44 + 128);
		    *(v45 - 8) = v47;
		    v49 = *(_OWORD *)&v44[-1].defaultConfig.skyAmbientSH.shr7;
		    *(v45 - 7) = v48;
		    v50 = *(_OWORD *)&v44[-1].defaultConfig.skyAmbientSH.shg2;
		    *(v45 - 6) = v49;
		    v51 = *(_OWORD *)&v44[-1].defaultConfig.skyAmbientSH.shg6;
		    *(v45 - 5) = v50;
		    v52 = *(_OWORD *)&v44[-1].defaultConfig.skyAmbientSH.shb1;
		    *(v45 - 4) = v51;
		    v53 = *(_OWORD *)&v44[-1].defaultConfig.skyAmbientSH.shb5;
		    *(v45 - 3) = v52;
		    v54 = *(_OWORD *)&v44[-1].defaultConfig.skyboxCubeMap;
		    *(v45 - 2) = v53;
		    *(v45 - 1) = v54;
		    --v46;
		  }
		  while ( v46 );
		  v55 = 2LL;
		  v56 = *(_OWORD *)&v44->defaultConfig.skyDirectIntensity;
		  *v45 = *(_OWORD *)&v44->defaultConfig.parentEnvPhaseGuid;
		  v57 = *(_OWORD *)&v44->defaultConfig.customIVDefaultSH.shr2;
		  v45[1] = v56;
		  v58 = *(_OWORD *)&v44->defaultConfig.customIVDefaultSH.shr6;
		  v45[2] = v57;
		  v59 = *(_OWORD *)&v44->defaultConfig.customIVDefaultSH.shg1;
		  v60 = *(_QWORD *)&v44->defaultConfig.customIVDefaultSH.shg5;
		  v45[3] = v58;
		  v45[4] = v59;
		  *((_QWORD *)v45 + 10) = v60;
		  p_skyConfig = &this->fields.skyConfig;
		  v62 = &v383;
		  do
		  {
		    p_skyConfig = (HGSkyConfig *)((char *)p_skyConfig + 128);
		    v63 = *v62;
		    v64 = v62[1];
		    v62 += 8;
		    *(_OWORD *)&p_skyConfig[-1].culloff = v63;
		    v65 = *(v62 - 6);
		    *(_OWORD *)&p_skyConfig[-1].skyAmbientSH.shr3 = v64;
		    v66 = *(v62 - 5);
		    *(_OWORD *)&p_skyConfig[-1].skyAmbientSH.shr7 = v65;
		    v67 = *(v62 - 4);
		    *(_OWORD *)&p_skyConfig[-1].skyAmbientSH.shg2 = v66;
		    v68 = *(v62 - 3);
		    *(_OWORD *)&p_skyConfig[-1].skyAmbientSH.shg6 = v67;
		    v69 = *(v62 - 2);
		    *(_OWORD *)&p_skyConfig[-1].skyAmbientSH.shb1 = v68;
		    v70 = *(v62 - 1);
		    *(_OWORD *)&p_skyConfig[-1].skyAmbientSH.shb5 = v69;
		    *(_OWORD *)&p_skyConfig[-1].skyboxCubeMap = v70;
		    --v55;
		  }
		  while ( v55 );
		  v71 = v62[1];
		  *(_OWORD *)&p_skyConfig->parentEnvPhaseGuid = *v62;
		  v72 = v62[2];
		  *(_OWORD *)&p_skyConfig->skyDirectIntensity = v71;
		  v73 = v62[3];
		  *(_OWORD *)&p_skyConfig->customIVDefaultSH.shr2 = v72;
		  v74 = v62[4];
		  v75 = *((_QWORD *)v62 + 10);
		  *(_OWORD *)&p_skyConfig->customIVDefaultSH.shr6 = v73;
		  *(_OWORD *)&p_skyConfig->customIVDefaultSH.shg1 = v74;
		  *(_QWORD *)&p_skyConfig->customIVDefaultSH.shg5 = v75;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.skyConfig, 0LL, v2, v3, (MethodInfo *)v383);
		  v78 = TypeInfo::HG::Rendering::Runtime::HGAtmosphereConfig;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGAtmosphereConfig->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGAtmosphereConfig);
		    v78 = TypeInfo::HG::Rendering::Runtime::HGAtmosphereConfig;
		  }
		  v79 = v78->static_fields;
		  v80 = *(_OWORD *)&v79->defaultConfig.groundAlbedo.a;
		  v81 = *(_OWORD *)&v79->defaultConfig.outerSunIrradianceColor.a;
		  rayleighScattering = v79->defaultConfig.rayleighScattering;
		  v83 = *(_OWORD *)&v79->defaultConfig.rayleighExponentialDistribution;
		  v84 = *(_OWORD *)&v79->defaultConfig.mieScattering.b;
		  v85 = *(_OWORD *)&v79->defaultConfig.mieAbsorption.g;
		  v86 = *(_OWORD *)&v79->defaultConfig.mieExponentialDistribution;
		  v87 = *(_OWORD *)&v79->defaultConfig.ozoneAbsorption.b;
		  v88 = *(_QWORD *)&v79->defaultConfig.tentWidth;
		  *(_OWORD *)&this->fields.atmosphereConfig.groundRadius = *(_OWORD *)&v79->defaultConfig.groundRadius;
		  *(_OWORD *)&this->fields.atmosphereConfig.groundAlbedo.a = v80;
		  *(_OWORD *)&this->fields.atmosphereConfig.outerSunIrradianceColor.a = v81;
		  this->fields.atmosphereConfig.rayleighScattering = rayleighScattering;
		  *(_OWORD *)&this->fields.atmosphereConfig.rayleighExponentialDistribution = v83;
		  *(_OWORD *)&this->fields.atmosphereConfig.mieScattering.b = v84;
		  *(_OWORD *)&this->fields.atmosphereConfig.mieAbsorption.g = v85;
		  *(_OWORD *)&this->fields.atmosphereConfig.mieExponentialDistribution = v86;
		  *(_OWORD *)&this->fields.atmosphereConfig.ozoneAbsorption.b = v87;
		  *(_QWORD *)&this->fields.atmosphereConfig.tentWidth = v88;
		  v89 = TypeInfo::HG::Rendering::Runtime::HGFogConfig;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGFogConfig->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGFogConfig);
		    v89 = TypeInfo::HG::Rendering::Runtime::HGFogConfig;
		  }
		  v90 = v89->static_fields;
		  v91 = *(_DWORD *)&v90->defaultConfig.m_active;
		  v92 = *(_OWORD *)&v90->defaultConfig.fallOffDistance;
		  v93 = *(_OWORD *)&v90->defaultConfig.mieScattering.a;
		  v94 = *(_OWORD *)&v90->defaultConfig.rayleighScattering.g;
		  inscatterAmbientColor = v90->defaultConfig.inscatterAmbientColor;
		  *(_OWORD *)&this->fields.fogConfig.enable = *(_OWORD *)&v90->defaultConfig.enable;
		  *(_OWORD *)&this->fields.fogConfig.fallOffDistance = v92;
		  *(_OWORD *)&this->fields.fogConfig.mieScattering.a = v93;
		  *(_OWORD *)&this->fields.fogConfig.rayleighScattering.g = v94;
		  this->fields.fogConfig.inscatterAmbientColor = inscatterAmbientColor;
		  *(_DWORD *)&this->fields.fogConfig.m_active = v91;
		  v96 = TypeInfo::HG::Rendering::Runtime::HGHeightFogConfig;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGHeightFogConfig->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGHeightFogConfig);
		    v96 = TypeInfo::HG::Rendering::Runtime::HGHeightFogConfig;
		  }
		  v97 = v96->static_fields;
		  v98 = *(Color *)&v97->defaultConfig.heightFogStartHeightSecond;
		  v383 = *(_OWORD *)&v97->defaultConfig.enable;
		  v99 = *(_OWORD *)&v97->defaultConfig.heightFogInscatter.g;
		  v384 = v98;
		  v100 = *(_OWORD *)&v97->defaultConfig.heightFogStartDistance;
		  v385 = v99;
		  v101 = *(_OWORD *)&v97->defaultConfig.heightFogCullingFarClipPlane;
		  v386 = v100;
		  v102 = *(_OWORD *)&v97->defaultConfig.heightFogDirectionalInscattering.g;
		  v387 = v101;
		  heightFogDirectionalInscatteringMobile = v97->defaultConfig.heightFogDirectionalInscatteringMobile;
		  v388 = v102;
		  v104 = *(_OWORD *)&v97->defaultConfig.enableVolumetricFog;
		  v97 = (HGHeightFogConfig__StaticFields *)((char *)v97 + 128);
		  v389 = heightFogDirectionalInscatteringMobile;
		  v390 = v104;
		  v105 = *(_QWORD *)&v97->defaultConfig.heightFogDirectionalInscattering.g;
		  v106 = *(_OWORD *)&v97->defaultConfig.heightFogStartHeightSecond;
		  v391 = *(_OWORD *)&v97->defaultConfig.enable;
		  v107 = *(_OWORD *)&v97->defaultConfig.heightFogInscatter.g;
		  v392 = v106;
		  v108 = *(_OWORD *)&v97->defaultConfig.heightFogStartDistance;
		  v393 = v107;
		  v109 = *(_OWORD *)&v97->defaultConfig.heightFogCullingFarClipPlane;
		  v394 = v108;
		  v395 = v109;
		  v396 = v105;
		  a = v97->defaultConfig.heightFogDirectionalInscattering.a;
		  v110 = v384;
		  *(_OWORD *)&this->fields.heightFogConfig.enable = v383;
		  v111 = v385;
		  *(Color *)&this->fields.heightFogConfig.heightFogStartHeightSecond = v110;
		  v112 = v386;
		  *(_OWORD *)&this->fields.heightFogConfig.heightFogInscatter.g = v111;
		  v113 = v387;
		  *(_OWORD *)&this->fields.heightFogConfig.heightFogStartDistance = v112;
		  v114 = v388;
		  *(_OWORD *)&this->fields.heightFogConfig.heightFogCullingFarClipPlane = v113;
		  v115 = v389;
		  *(_OWORD *)&this->fields.heightFogConfig.heightFogDirectionalInscattering.g = v114;
		  v116 = v390;
		  this->fields.heightFogConfig.heightFogDirectionalInscatteringMobile = v115;
		  v117 = v391;
		  *(_OWORD *)&this->fields.heightFogConfig.enableVolumetricFog = v116;
		  v118 = v392;
		  *(_OWORD *)&this->fields.heightFogConfig.volumetricFogAlbedo.b = v117;
		  v119 = v393;
		  *(_OWORD *)&this->fields.heightFogConfig.volumetricFogEmissive.b = v118;
		  v120 = v394;
		  *(_OWORD *)&this->fields.heightFogConfig.volumetricFogStartDistance = v119;
		  v121 = v395;
		  *(_OWORD *)&this->fields.heightFogConfig.enableFlowNoise = v120;
		  *(_OWORD *)&this->fields.heightFogConfig.flowNoiseHorizontalDirAngle = v121;
		  *(_QWORD *)&this->fields.heightFogConfig.flowNoiseDir.z = v105;
		  *(float *)&this->fields.heightFogConfig.m_active = a;
		  v122 = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig);
		    v122 = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig;
		  }
		  v123 = v122->static_fields;
		  v124 = &v383;
		  v125 = 2LL;
		  do
		  {
		    v124 += 8;
		    v126 = *(_OWORD *)&v123->defaultConfig.enable;
		    v127 = *(_OWORD *)&v123->defaultConfig.heightFogStartHeightSecond;
		    v123 = (HGVolumetricFogConfig__StaticFields *)((char *)v123 + 128);
		    *(v124 - 8) = v126;
		    v128 = *(_OWORD *)&v123[-1].defaultConfig.flowVLNoiseDir.y;
		    *(v124 - 7) = v127;
		    v129 = *(_OWORD *)&v123[-1].defaultConfig.flowVLNoisePerturb3DTexture;
		    *(v124 - 6) = v128;
		    v130 = *(_OWORD *)&v123[-1].defaultConfig.flowVLNoisePerturbSpeed.x;
		    *(v124 - 5) = v129;
		    v131 = *(_OWORD *)&v123[-1].defaultConfig.m_backupVLNoiseDistance;
		    *(v124 - 4) = v130;
		    v132 = *(_OWORD *)&v123[-1].defaultConfig.m_backupVLNoiseTillingScale.z;
		    *(v124 - 3) = v131;
		    v133 = *(_OWORD *)&v123[-1].defaultConfig.m_backupFlowVLNoiseRemapRange.x;
		    *(v124 - 2) = v132;
		    *(v124 - 1) = v133;
		    --v125;
		  }
		  while ( v125 );
		  v134 = 2LL;
		  v135 = *(_OWORD *)&v123->defaultConfig.heightFogStartHeightSecond;
		  *v124 = *(_OWORD *)&v123->defaultConfig.enable;
		  v136 = *(_OWORD *)&v123->defaultConfig.heightFogInscatter.g;
		  v124[1] = v135;
		  v137 = *(_OWORD *)&v123->defaultConfig.heightFogStartDistance;
		  v124[2] = v136;
		  v138 = *(_OWORD *)&v123->defaultConfig.heightFogDirectionalInscatteringExponent;
		  v124[3] = v137;
		  v139 = *(_OWORD *)&v123->defaultConfig.heightFogDirectionalInscattering.b;
		  v124[4] = v138;
		  v140 = *(_OWORD *)&v123->defaultConfig.heightFogDirectionalInscatteringMobile.g;
		  p_volumetricFogConfig = &this->fields.volumetricFogConfig;
		  v124[5] = v139;
		  v124[6] = v140;
		  v142 = &v383;
		  do
		  {
		    p_volumetricFogConfig = (HGVolumetricFogConfig *)((char *)p_volumetricFogConfig + 128);
		    v143 = *v142;
		    v144 = v142[1];
		    v142 += 8;
		    *(_OWORD *)&p_volumetricFogConfig[-1].flowVLNoiseDistance = v143;
		    v145 = *(v142 - 6);
		    *(_OWORD *)&p_volumetricFogConfig[-1].flowVLNoiseTillingScale.z = v144;
		    v146 = *(v142 - 5);
		    *(_OWORD *)&p_volumetricFogConfig[-1].flowVLNoiseDir.y = v145;
		    v147 = *(v142 - 4);
		    *(_OWORD *)&p_volumetricFogConfig[-1].flowVLNoisePerturb3DTexture = v146;
		    v148 = *(v142 - 3);
		    *(_OWORD *)&p_volumetricFogConfig[-1].flowVLNoisePerturbSpeed.x = v147;
		    v149 = *(v142 - 2);
		    *(_OWORD *)&p_volumetricFogConfig[-1].m_backupVLNoiseDistance = v148;
		    v150 = *(v142 - 1);
		    *(_OWORD *)&p_volumetricFogConfig[-1].m_backupVLNoiseTillingScale.z = v149;
		    *(_OWORD *)&p_volumetricFogConfig[-1].m_backupFlowVLNoiseRemapRange.x = v150;
		    --v134;
		  }
		  while ( v134 );
		  v151 = v142[1];
		  *(_OWORD *)&p_volumetricFogConfig->enable = *v142;
		  v152 = v142[2];
		  *(_OWORD *)&p_volumetricFogConfig->heightFogStartHeightSecond = v151;
		  v153 = v142[3];
		  *(_OWORD *)&p_volumetricFogConfig->heightFogInscatter.g = v152;
		  v154 = v142[4];
		  *(_OWORD *)&p_volumetricFogConfig->heightFogStartDistance = v153;
		  v155 = v142[5];
		  *(_OWORD *)&p_volumetricFogConfig->heightFogDirectionalInscatteringExponent = v154;
		  v156 = v142[6];
		  *(_OWORD *)&p_volumetricFogConfig->heightFogDirectionalInscattering.b = v155;
		  *(_OWORD *)&p_volumetricFogConfig->heightFogDirectionalInscatteringMobile.g = v156;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields.volumetricFogConfig.flowVLNoise3DTexture,
		    0LL,
		    v76,
		    v77,
		    (MethodInfo *)v383);
		  v159 = TypeInfo::HG::Rendering::Runtime::HGVolumetricCloudConfig;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGVolumetricCloudConfig->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGVolumetricCloudConfig);
		    v159 = TypeInfo::HG::Rendering::Runtime::HGVolumetricCloudConfig;
		  }
		  v160 = v159->static_fields;
		  m_active = (Type *)v160->defaultConfig.m_active;
		  *(_WORD *)&this->fields.volumetricCloudConfig.enabled = *(_WORD *)&v160->defaultConfig.enabled;
		  this->fields.volumetricCloudConfig.m_active = (char)m_active;
		  v162 = TypeInfo::HG::Rendering::Runtime::HGCloudConfig;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGCloudConfig->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCloudConfig);
		    v162 = TypeInfo::HG::Rendering::Runtime::HGCloudConfig;
		  }
		  v163 = v162->static_fields;
		  cloudTint = v163->defaultConfig.cloudTint;
		  v383 = *(_OWORD *)&v163->defaultConfig.enable;
		  v165 = *(_OWORD *)&v163->defaultConfig.cloudContrast;
		  v384 = cloudTint;
		  v166 = *(_OWORD *)&v163->defaultConfig.brightnessAffectCloudAlpha;
		  v385 = v165;
		  v167 = *(_OWORD *)&v163->defaultConfig.cloudFlowType;
		  v386 = v166;
		  v168 = *(_OWORD *)&v163->defaultConfig.flowSpeed;
		  v387 = v167;
		  v169 = *(Color *)&v163->defaultConfig.lightShaftCloudMaskTexture;
		  v388 = v168;
		  v170 = *(_OWORD *)&v163->defaultConfig.cloudShadowConfig.cloudShadowTexture;
		  v389 = v169;
		  v171 = *(_OWORD *)&v163->defaultConfig.cloudShadowConfig.cloudShadowEnvCenter.z;
		  v390 = v170;
		  v172 = *(_OWORD *)&v163->defaultConfig.cloudShadowConfig.cloudShadowFlowDirection.y;
		  v391 = v171;
		  v173 = *(_OWORD *)&v163->defaultConfig.cloudShadowConfig.cloudShadowScaleEndDistance;
		  v392 = v172;
		  v393 = v173;
		  v174 = v384;
		  *(_OWORD *)&this->fields.cloudConfig.enable = v383;
		  v175 = v385;
		  this->fields.cloudConfig.cloudTint = v174;
		  v176 = v386;
		  *(_OWORD *)&this->fields.cloudConfig.cloudContrast = v175;
		  v177 = v387;
		  *(_OWORD *)&this->fields.cloudConfig.brightnessAffectCloudAlpha = v176;
		  v178 = v388;
		  *(_OWORD *)&this->fields.cloudConfig.cloudFlowType = v177;
		  v179 = v389;
		  *(_OWORD *)&this->fields.cloudConfig.flowSpeed = v178;
		  v180 = v390;
		  *(Color *)&this->fields.cloudConfig.lightShaftCloudMaskTexture = v179;
		  v181 = v391;
		  *(_OWORD *)&this->fields.cloudConfig.cloudShadowConfig.cloudShadowTexture = v180;
		  v182 = v392;
		  *(_OWORD *)&this->fields.cloudConfig.cloudShadowConfig.cloudShadowEnvCenter.z = v181;
		  v183 = v393;
		  *(_OWORD *)&this->fields.cloudConfig.cloudShadowConfig.cloudShadowFlowDirection.y = v182;
		  *(_OWORD *)&this->fields.cloudConfig.cloudShadowConfig.cloudShadowScaleEndDistance = v183;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.cloudConfig.cloudTexture, m_active, v157, v158, (MethodInfo *)v383);
		  v186 = TypeInfo::HG::Rendering::Runtime::HGCelestialConfig;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGCelestialConfig->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCelestialConfig);
		    v186 = TypeInfo::HG::Rendering::Runtime::HGCelestialConfig;
		  }
		  v187 = v186->static_fields;
		  v188 = &v383;
		  v189 = 2LL;
		  do
		  {
		    v188 += 8;
		    v190 = *(_OWORD *)&v187->defaultConfig.moonConfig.radius;
		    v191 = *(_OWORD *)&v187->defaultConfig.moonConfig.worldLongitude;
		    v187 = (HGCelestialConfig__StaticFields *)((char *)v187 + 128);
		    *(v188 - 8) = v190;
		    v192 = *(_OWORD *)&v187[-1].defaultConfig.planetConfig.ring.outerRadius;
		    *(v188 - 7) = v191;
		    v193 = *(_OWORD *)&v187[-1].defaultConfig.planetConfig.ring.ringColor.b;
		    *(v188 - 6) = v192;
		    v194 = *(_OWORD *)&v187[-1].defaultConfig.planetConfig.enableAtmosphere;
		    *(v188 - 5) = v193;
		    v195 = *(_OWORD *)&v187[-1].defaultConfig.planetConfig.atmosphere.numOpticalDepthSamplePoints;
		    *(v188 - 4) = v194;
		    v196 = *(_OWORD *)&v187[-1].defaultConfig.planetConfig.atmosphere.atmosphereHueshift;
		    *(v188 - 3) = v195;
		    v197 = *(_OWORD *)&v187[-1].defaultConfig.advancedPlanetConfig.advancedPlanetMat;
		    *(v188 - 2) = v196;
		    *(v188 - 1) = v197;
		    --v189;
		  }
		  while ( v189 );
		  v198 = 2LL;
		  v199 = *(_OWORD *)&v187->defaultConfig.moonConfig.worldLongitude;
		  *v188 = *(_OWORD *)&v187->defaultConfig.moonConfig.radius;
		  v200 = *(_OWORD *)&v187->defaultConfig.moonConfig.ring.outerRadius;
		  v188[1] = v199;
		  v201 = *(_OWORD *)&v187->defaultConfig.moonConfig.ring.ringColor.b;
		  v188[2] = v200;
		  v202 = *(_OWORD *)&v187->defaultConfig.talosAlphaConfig.drawPlanetInSkydome;
		  v188[3] = v201;
		  v203 = *(_OWORD *)&v187->defaultConfig.talosAlphaConfig.objectProperty.selfTiltZ;
		  drawMaterial = v187->defaultConfig.talosAlphaConfig.skydomeDrawer.drawMaterial;
		  v188[4] = v202;
		  v188[5] = v203;
		  *((_QWORD *)v188 + 12) = drawMaterial;
		  p_celestialConfig = &this->fields.celestialConfig;
		  v206 = &v383;
		  do
		  {
		    p_celestialConfig = (HGCelestialConfig *)((char *)p_celestialConfig + 128);
		    v207 = *v206;
		    v208 = v206[1];
		    v206 += 8;
		    *(_OWORD *)&p_celestialConfig[-1].planetConfig.skydomeDrawer.drawMaterial = v207;
		    v209 = *(v206 - 6);
		    *(_OWORD *)&p_celestialConfig[-1].planetConfig.skydomeDrawer.incidentLightingPitchYaw.x = v208;
		    v210 = *(v206 - 5);
		    *(_OWORD *)&p_celestialConfig[-1].planetConfig.ring.outerRadius = v209;
		    v211 = *(v206 - 4);
		    *(_OWORD *)&p_celestialConfig[-1].planetConfig.ring.ringColor.b = v210;
		    v212 = *(v206 - 3);
		    *(_OWORD *)&p_celestialConfig[-1].planetConfig.enableAtmosphere = v211;
		    v213 = *(v206 - 2);
		    *(_OWORD *)&p_celestialConfig[-1].planetConfig.atmosphere.numOpticalDepthSamplePoints = v212;
		    v214 = *(v206 - 1);
		    *(_OWORD *)&p_celestialConfig[-1].planetConfig.atmosphere.atmosphereHueshift = v213;
		    *(_OWORD *)&p_celestialConfig[-1].advancedPlanetConfig.advancedPlanetMat = v214;
		    --v198;
		  }
		  while ( v198 );
		  v215 = v206[1];
		  *(_OWORD *)&p_celestialConfig->moonConfig.radius = *v206;
		  v216 = v206[2];
		  *(_OWORD *)&p_celestialConfig->moonConfig.worldLongitude = v215;
		  v217 = v206[3];
		  *(_OWORD *)&p_celestialConfig->moonConfig.ring.outerRadius = v216;
		  v218 = v206[4];
		  *(_OWORD *)&p_celestialConfig->moonConfig.ring.ringColor.b = v217;
		  v219 = v206[5];
		  v220 = (Material *)*((_QWORD *)v206 + 12);
		  *(_OWORD *)&p_celestialConfig->talosAlphaConfig.drawPlanetInSkydome = v218;
		  *(_OWORD *)&p_celestialConfig->talosAlphaConfig.objectProperty.selfTiltZ = v219;
		  p_celestialConfig->talosAlphaConfig.skydomeDrawer.drawMaterial = v220;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields.celestialConfig.moonConfig.ring.planetRingMap,
		    0LL,
		    v184,
		    v185,
		    (MethodInfo *)v383);
		  v224 = TypeInfo::HG::Rendering::Runtime::HGWindConfig;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGWindConfig->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGWindConfig);
		    v224 = TypeInfo::HG::Rendering::Runtime::HGWindConfig;
		  }
		  v225 = v224->static_fields;
		  v226 = *(_DWORD *)&v225->defaultConfig.m_active;
		  v227 = *(_QWORD *)&v225->defaultConfig.direction.y;
		  *(_OWORD *)&this->fields.windConfig.speed = *(_OWORD *)&v225->defaultConfig.speed;
		  *(_QWORD *)&this->fields.windConfig.direction.y = v227;
		  *(_DWORD *)&this->fields.windConfig.m_active = v226;
		  v228 = TypeInfo::HG::Rendering::Runtime::HGLightShaftConfig;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGLightShaftConfig->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGLightShaftConfig);
		    v228 = TypeInfo::HG::Rendering::Runtime::HGLightShaftConfig;
		  }
		  v229 = v228->static_fields;
		  v230 = *(_DWORD *)&v229->defaultConfig.m_active;
		  bloomTint = v229->defaultConfig.bloomTint;
		  v232 = *(_OWORD *)&v229->defaultConfig.blurIntensity;
		  *(_OWORD *)&this->fields.lightShaftConfig.enable = *(_OWORD *)&v229->defaultConfig.enable;
		  this->fields.lightShaftConfig.bloomTint = bloomTint;
		  *(_OWORD *)&this->fields.lightShaftConfig.blurIntensity = v232;
		  *(_DWORD *)&this->fields.lightShaftConfig.m_active = v230;
		  v233 = TypeInfo::HG::Rendering::Runtime::HGTerrainDeformConfig;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGTerrainDeformConfig->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGTerrainDeformConfig);
		    v233 = TypeInfo::HG::Rendering::Runtime::HGTerrainDeformConfig;
		  }
		  v234 = v233->static_fields;
		  v235 = *(_DWORD *)&v234->defaultConfig.m_active;
		  *(_QWORD *)&this->fields.terrainDeformConfig.deformGlobalStrength = *(_QWORD *)&v234->defaultConfig.deformGlobalStrength;
		  *(_DWORD *)&this->fields.terrainDeformConfig.m_active = v235;
		  v236 = TypeInfo::HG::Rendering::Runtime::HGInkSimulationConfig;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGInkSimulationConfig->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGInkSimulationConfig);
		    v236 = TypeInfo::HG::Rendering::Runtime::HGInkSimulationConfig;
		  }
		  v237 = v236->static_fields;
		  v238 = *(_OWORD *)&v237->defaultConfig.inkRippleDensity;
		  v239 = *(_OWORD *)&v237->defaultConfig.inkDebugJacobi;
		  v240 = *(_OWORD *)&v237->defaultConfig.resolvedShaderParams.speedFactor;
		  v241 = *(_OWORD *)&v237->defaultConfig.resolvedShaderParams.forceAngleRandom;
		  v242 = *(_OWORD *)&v237->defaultConfig.resolvedShaderParams.landingInkSize;
		  v243 = *(_OWORD *)&v237->defaultConfig.resolvedShaderParams.viscosity;
		  v244 = *(_QWORD *)&v237->defaultConfig.resolvedShaderParams.idleForceChangeSpeed;
		  *(_OWORD *)&this->fields.inkSimulationConfig.influence = *(_OWORD *)&v237->defaultConfig.influence;
		  *(_OWORD *)&this->fields.inkSimulationConfig.inkRippleDensity = v238;
		  *(_OWORD *)&this->fields.inkSimulationConfig.inkDebugJacobi = v239;
		  *(_OWORD *)&this->fields.inkSimulationConfig.resolvedShaderParams.speedFactor = v240;
		  *(_OWORD *)&this->fields.inkSimulationConfig.resolvedShaderParams.forceAngleRandom = v241;
		  *(_OWORD *)&this->fields.inkSimulationConfig.resolvedShaderParams.landingInkSize = v242;
		  *(_OWORD *)&this->fields.inkSimulationConfig.resolvedShaderParams.viscosity = v243;
		  *(_QWORD *)&this->fields.inkSimulationConfig.resolvedShaderParams.idleForceChangeSpeed = v244;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields.inkSimulationConfig.shaderParams,
		    v221,
		    v222,
		    v223,
		    (MethodInfo *)v383);
		  v247 = TypeInfo::HG::Rendering::Runtime::HGRainConfig;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGRainConfig->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRainConfig);
		    v247 = TypeInfo::HG::Rendering::Runtime::HGRainConfig;
		  }
		  v248 = v247->static_fields;
		  v249 = &v383;
		  v250 = 2LL;
		  do
		  {
		    v249 += 8;
		    v251 = *(_OWORD *)&v248->defaultConfig.enable;
		    v252 = *(_OWORD *)&v248->defaultConfig.color.g;
		    v248 = (HGRainConfig__StaticFields *)((char *)v248 + 128);
		    *(v249 - 8) = v251;
		    v253 = *(_OWORD *)&v248[-1].defaultConfig.baseWetnessLevel;
		    *(v249 - 7) = v252;
		    v254 = *(_OWORD *)&v248[-1].defaultConfig.verticalFlowSurfaceThreshold;
		    *(v249 - 6) = v253;
		    v255 = *(_OWORD *)&v248[-1].defaultConfig.rippleWaveSpeed;
		    *(v249 - 5) = v254;
		    v256 = *(_OWORD *)&v248[-1].defaultConfig.farSceneWetnessValue;
		    *(v249 - 4) = v255;
		    v257 = *(_OWORD *)&v248[-1].defaultConfig.rainDirection.z;
		    *(v249 - 3) = v256;
		    v258 = *(_OWORD *)&v248[-1].defaultConfig.farRainDirection.x;
		    *(v249 - 2) = v257;
		    *(v249 - 1) = v258;
		    --v250;
		  }
		  while ( v250 );
		  v259 = 2LL;
		  v260 = *(_OWORD *)&v248->defaultConfig.color.g;
		  *v249 = *(_OWORD *)&v248->defaultConfig.enable;
		  v261 = *(_OWORD *)&v248->defaultConfig.horizontalRainAngle;
		  p_rainConfig = &this->fields.rainConfig;
		  v249[1] = v260;
		  v249[2] = v261;
		  v263 = &v383;
		  do
		  {
		    p_rainConfig = (HGRainConfig *)((char *)p_rainConfig + 128);
		    v264 = *v263;
		    v265 = v263[1];
		    v263 += 8;
		    *(_OWORD *)&p_rainConfig[-1].rainSplashAlpha = v264;
		    v266 = *(v263 - 6);
		    *(_OWORD *)&p_rainConfig[-1].enableWetness = v265;
		    v267 = *(v263 - 5);
		    *(_OWORD *)&p_rainConfig[-1].baseWetnessLevel = v266;
		    v268 = *(v263 - 4);
		    *(_OWORD *)&p_rainConfig[-1].verticalFlowSurfaceThreshold = v267;
		    v269 = *(v263 - 3);
		    *(_OWORD *)&p_rainConfig[-1].rippleWaveSpeed = v268;
		    v270 = *(v263 - 2);
		    *(_OWORD *)&p_rainConfig[-1].farSceneWetnessValue = v269;
		    v271 = *(v263 - 1);
		    *(_OWORD *)&p_rainConfig[-1].rainDirection.z = v270;
		    *(_OWORD *)&p_rainConfig[-1].farRainDirection.x = v271;
		    --v259;
		  }
		  while ( v259 );
		  v272 = v263[1];
		  *(_OWORD *)&p_rainConfig->enable = *v263;
		  v273 = v263[2];
		  *(_OWORD *)&p_rainConfig->color.g = v272;
		  *(_OWORD *)&p_rainConfig->horizontalRainAngle = v273;
		  v274 = TypeInfo::HG::Rendering::Runtime::HGSnowConfig;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGSnowConfig->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGSnowConfig);
		    v274 = TypeInfo::HG::Rendering::Runtime::HGSnowConfig;
		  }
		  v275 = v274->static_fields;
		  color = v275->defaultConfig.color;
		  v277 = *(_OWORD *)&v275->defaultConfig.snowSizeRange.x;
		  v278 = *(_OWORD *)&v275->defaultConfig.snowTrailLength;
		  v279 = *(_OWORD *)&v275->defaultConfig.snowLightingPercent;
		  v280 = *(_QWORD *)&v275->defaultConfig.snowDirection.z;
		  *(_OWORD *)&this->fields.snowConfig.enable = *(_OWORD *)&v275->defaultConfig.enable;
		  this->fields.snowConfig.color = color;
		  *(_OWORD *)&this->fields.snowConfig.snowSizeRange.x = v277;
		  *(_OWORD *)&this->fields.snowConfig.snowTrailLength = v278;
		  *(_OWORD *)&this->fields.snowConfig.snowLightingPercent = v279;
		  *(_QWORD *)&this->fields.snowConfig.snowDirection.z = v280;
		  v281 = TypeInfo::HG::Rendering::Runtime::HGStarConfig;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGStarConfig->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGStarConfig);
		    v281 = TypeInfo::HG::Rendering::Runtime::HGStarConfig;
		  }
		  v282 = v281->static_fields;
		  v283 = *(_OWORD *)&v282->defaultConfig.minMaxRange.y;
		  v284 = *(_OWORD *)&v282->defaultConfig.starsTint.a;
		  v285 = *(_OWORD *)&v282->defaultConfig.starsTint1.a;
		  v286 = *(_OWORD *)&v282->defaultConfig.brightnessRandomSeed;
		  v287 = *(_OWORD *)&v282->defaultConfig.skyBoxStarRangeMap;
		  v288 = *(_OWORD *)&v282->defaultConfig.cloudRingStarCoverage;
		  v289 = *(_OWORD *)&v282->defaultConfig.nebulaMap;
		  v290 = *(_OWORD *)&v282->defaultConfig.nebulaTint.b;
		  v291 = *(_QWORD *)&v282->defaultConfig.m_active;
		  *(_OWORD *)&this->fields.starConfig.enableStars = *(_OWORD *)&v282->defaultConfig.enableStars;
		  *(_OWORD *)&this->fields.starConfig.minMaxRange.y = v283;
		  *(_OWORD *)&this->fields.starConfig.starsTint.a = v284;
		  *(_OWORD *)&this->fields.starConfig.starsTint1.a = v285;
		  *(_OWORD *)&this->fields.starConfig.brightnessRandomSeed = v286;
		  *(_OWORD *)&this->fields.starConfig.skyBoxStarRangeMap = v287;
		  *(_OWORD *)&this->fields.starConfig.cloudRingStarCoverage = v288;
		  *(_OWORD *)&this->fields.starConfig.nebulaMap = v289;
		  *(_OWORD *)&this->fields.starConfig.nebulaTint.b = v290;
		  *(_QWORD *)&this->fields.starConfig.m_active = v291;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields.starConfig.skyBoxStarRangeMap,
		    (Type *)v259,
		    v245,
		    v246,
		    (MethodInfo *)v383);
		  v295 = TypeInfo::HG::Rendering::Runtime::HGLensFlareConfig;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGLensFlareConfig->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGLensFlareConfig);
		    v295 = TypeInfo::HG::Rendering::Runtime::HGLensFlareConfig;
		  }
		  v296 = v295->static_fields;
		  v297 = *(_OWORD *)&v296->defaultConfig.intensity;
		  v298 = *(_OWORD *)&v296->defaultConfig.sampleCount;
		  *(_OWORD *)&this->fields.lensFlareConfig.enable = *(_OWORD *)&v296->defaultConfig.enable;
		  *(_OWORD *)&this->fields.lensFlareConfig.intensity = v297;
		  *(_OWORD *)&this->fields.lensFlareConfig.sampleCount = v298;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields.lensFlareConfig.lensFlareData,
		    v292,
		    v293,
		    v294,
		    (MethodInfo *)v383);
		  v301 = TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
		    v301 = TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig;
		  }
		  v302 = &v383;
		  p_defaultConfig = &v301->static_fields->defaultConfig;
		  v304 = 2LL;
		  do
		  {
		    v302 += 8;
		    v305 = *(_OWORD *)&p_defaultConfig->tonemappingMode;
		    v306 = *(_OWORD *)&p_defaultConfig->colorLookupContribution;
		    p_defaultConfig = (HGColorGradingConfig *)((char *)p_defaultConfig + 128);
		    *(v302 - 8) = v305;
		    v307 = *(_OWORD *)&p_defaultConfig[-1].splitToningHighlights.a;
		    *(v302 - 7) = v306;
		    v308 = *(_OWORD *)&p_defaultConfig[-1].colorCurves.master;
		    *(v302 - 6) = v307;
		    v309 = *(_OWORD *)&p_defaultConfig[-1].colorCurves.green;
		    *(v302 - 5) = v308;
		    v310 = *(_OWORD *)&p_defaultConfig[-1].colorCurves.hueVsHue;
		    *(v302 - 4) = v309;
		    v311 = *(_OWORD *)&p_defaultConfig[-1].colorCurves.satVsSat;
		    *(v302 - 3) = v310;
		    v312 = *(_OWORD *)&p_defaultConfig[-1].colorCurves.masterOverriding;
		    *(v302 - 2) = v311;
		    *(v302 - 1) = v312;
		    --v304;
		  }
		  while ( v304 );
		  v313 = *(_OWORD *)&p_defaultConfig->colorLookupContribution;
		  *v302 = *(_OWORD *)&p_defaultConfig->tonemappingMode;
		  v314 = *(_OWORD *)&p_defaultConfig->colorAdjustmentsEnabled;
		  v302[1] = v313;
		  v315 = *(_OWORD *)&p_defaultConfig->colorAdjustmentsColorFilter.g;
		  v302[2] = v314;
		  v316 = *(_OWORD *)&p_defaultConfig->colorAdjustmentsSaturation;
		  v302[3] = v315;
		  v317 = *(_OWORD *)&p_defaultConfig->channelMixerRedOutBlueIn;
		  v302[4] = v316;
		  v318 = *(_OWORD *)&p_defaultConfig->channelMixerBlueOutRedIn;
		  p_colorGradingConfig = &this->fields.colorGradingConfig;
		  v302[5] = v317;
		  v302[6] = v318;
		  v320 = &v383;
		  do
		  {
		    p_colorGradingConfig = (HGColorGradingConfig *)((char *)p_colorGradingConfig + 128);
		    v321 = *v320;
		    v322 = v320[1];
		    v320 += 8;
		    *(_OWORD *)&p_colorGradingConfig[-1].splitToningEnabled = v321;
		    v323 = *(v320 - 6);
		    *(_OWORD *)&p_colorGradingConfig[-1].splitToningShadows.a = v322;
		    v324 = *(v320 - 5);
		    *(_OWORD *)&p_colorGradingConfig[-1].splitToningHighlights.a = v323;
		    v325 = *(v320 - 4);
		    *(_OWORD *)&p_colorGradingConfig[-1].colorCurves.master = v324;
		    v326 = *(v320 - 3);
		    *(_OWORD *)&p_colorGradingConfig[-1].colorCurves.green = v325;
		    v327 = *(v320 - 2);
		    *(_OWORD *)&p_colorGradingConfig[-1].colorCurves.hueVsHue = v326;
		    v328 = *(v320 - 1);
		    *(_OWORD *)&p_colorGradingConfig[-1].colorCurves.satVsSat = v327;
		    *(_OWORD *)&p_colorGradingConfig[-1].colorCurves.masterOverriding = v328;
		    --v8;
		  }
		  while ( v8 );
		  v329 = v320[1];
		  *(_OWORD *)&p_colorGradingConfig->tonemappingMode = *v320;
		  v330 = v320[2];
		  *(_OWORD *)&p_colorGradingConfig->colorLookupContribution = v329;
		  v331 = v320[3];
		  *(_OWORD *)&p_colorGradingConfig->colorAdjustmentsEnabled = v330;
		  v332 = v320[4];
		  *(_OWORD *)&p_colorGradingConfig->colorAdjustmentsColorFilter.g = v331;
		  v333 = v320[5];
		  *(_OWORD *)&p_colorGradingConfig->colorAdjustmentsSaturation = v332;
		  v334 = v320[6];
		  *(_OWORD *)&p_colorGradingConfig->channelMixerRedOutBlueIn = v333;
		  *(_OWORD *)&p_colorGradingConfig->channelMixerBlueOutRedIn = v334;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields.colorGradingConfig.colorLookupTexture,
		    0LL,
		    v299,
		    v300,
		    (MethodInfo *)v383);
		  v338 = TypeInfo::HG::Rendering::Runtime::HGAutoExposureConfig;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGAutoExposureConfig->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGAutoExposureConfig);
		    v338 = TypeInfo::HG::Rendering::Runtime::HGAutoExposureConfig;
		  }
		  v339 = v338->static_fields;
		  v340 = *(_DWORD *)&v339->defaultConfig.m_active;
		  v341 = *(_OWORD *)&v339->defaultConfig.autoExposureEv100Range.x;
		  v342 = *(_OWORD *)&v339->defaultConfig.autoExposureMeteringMode;
		  v343 = *(_QWORD *)&v339->defaultConfig.autoExposureEvClampRange.y;
		  *(_OWORD *)&this->fields.autoExposureConfig.autoExposureMode = *(_OWORD *)&v339->defaultConfig.autoExposureMode;
		  *(_OWORD *)&this->fields.autoExposureConfig.autoExposureEv100Range.x = v341;
		  *(_OWORD *)&this->fields.autoExposureConfig.autoExposureMeteringMode = v342;
		  *(_QWORD *)&this->fields.autoExposureConfig.autoExposureEvClampRange.y = v343;
		  *(_DWORD *)&this->fields.autoExposureConfig.m_active = v340;
		  v344 = TypeInfo::HG::Rendering::Runtime::HGShadowConfig;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGShadowConfig->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGShadowConfig);
		    v344 = TypeInfo::HG::Rendering::Runtime::HGShadowConfig;
		  }
		  p_r = (_OWORD *)&v344->static_fields->_enabledColor.r;
		  v346 = p_r[3];
		  v347 = p_r[4];
		  v348 = p_r[5];
		  v349 = p_r[6];
		  v350 = p_r[7];
		  v351 = p_r[8];
		  v352 = p_r[9];
		  *(_OWORD *)&this->fields.shadowConfig.csmDepthBias = p_r[2];
		  *(_OWORD *)&this->fields.shadowConfig.csmIntensity = v346;
		  *(_OWORD *)&this->fields.shadowConfig.csmShadowSoftness = v347;
		  *(_OWORD *)&this->fields.shadowConfig.contactShadowSurfaceThickness = v348;
		  *(_OWORD *)&this->fields.shadowConfig.overrideCsmFarDistance = v349;
		  *(_OWORD *)&this->fields.shadowConfig.overrideCsmSpherePosition.z = v350;
		  *(_OWORD *)&this->fields.shadowConfig.csmSimulatedAttenuation = v351;
		  *(_OWORD *)&this->fields.shadowConfig.rhodesShipCenter.z = v352;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.shadowConfig.csmRampTexture, v335, v336, v337, (MethodInfo *)v383);
		  v356 = TypeInfo::HG::Rendering::Runtime::HGAnamorphicStreaksConfig;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGAnamorphicStreaksConfig->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGAnamorphicStreaksConfig);
		    v356 = TypeInfo::HG::Rendering::Runtime::HGAnamorphicStreaksConfig;
		  }
		  v357 = v356->static_fields;
		  v358 = v357->defaultConfig.bloomTint;
		  v359 = *(_OWORD *)&v357->defaultConfig.blurIntensity;
		  *(_OWORD *)&this->fields.anamorphicStreaksConfig.enable = *(_OWORD *)&v357->defaultConfig.enable;
		  this->fields.anamorphicStreaksConfig.bloomTint = v358;
		  *(_OWORD *)&this->fields.anamorphicStreaksConfig.blurIntensity = v359;
		  v360 = TypeInfo::HG::Rendering::Runtime::HGWaterEnvConfig;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGWaterEnvConfig->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGWaterEnvConfig);
		    v360 = TypeInfo::HG::Rendering::Runtime::HGWaterEnvConfig;
		  }
		  v361 = v360->static_fields;
		  v362 = *(_DWORD *)&v361->defaultConfig.m_active;
		  *(_QWORD *)&this->fields.waterEnvConfig.enableWaterInteractionAdjust = *(_QWORD *)&v361->defaultConfig.enableWaterInteractionAdjust;
		  *(_DWORD *)&this->fields.waterEnvConfig.m_active = v362;
		  v363 = TypeInfo::HG::Rendering::Runtime::HGInkWashConfig;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGInkWashConfig->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGInkWashConfig);
		    v363 = TypeInfo::HG::Rendering::Runtime::HGInkWashConfig;
		  }
		  v364 = v363->static_fields;
		  v365 = *(Color *)&v364->defaultConfig.baseConfig.baseMat;
		  v383 = *(_OWORD *)&v364->defaultConfig.enable;
		  v366 = *(_OWORD *)&v364->defaultConfig.baseConfig.verticalFadeAffectDist;
		  v384 = v365;
		  v367 = *(_OWORD *)&v364->defaultConfig.overlayConfig.overlayMat;
		  v385 = v366;
		  v368 = *(_OWORD *)&v364->defaultConfig.overlayConfig.verticalFadeAffectDist;
		  v386 = v367;
		  v369 = *(_OWORD *)&v364->defaultConfig.maskConfig.addNewInkDrop;
		  v387 = v368;
		  v370 = *(Color *)&v364->defaultConfig.maskConfig.inkDropSize;
		  v388 = v369;
		  v371 = *(_OWORD *)&v364->defaultConfig.maskConfig.currInkPointPos.y;
		  v389 = v370;
		  v372 = *(_OWORD *)&v364->defaultConfig.maskConfig.currInkPointDir.z;
		  v390 = v371;
		  v373 = *(_OWORD *)&v364->defaultConfig.maskConfig.edgeFade;
		  v391 = v372;
		  v392 = v373;
		  v374 = v384;
		  *(_OWORD *)&this->fields.inkWashConfig.enable = v383;
		  v375 = v385;
		  *(Color *)&this->fields.inkWashConfig.baseConfig.baseMat = v374;
		  v376 = v386;
		  *(_OWORD *)&this->fields.inkWashConfig.baseConfig.verticalFadeAffectDist = v375;
		  v377 = v387;
		  *(_OWORD *)&this->fields.inkWashConfig.overlayConfig.overlayMat = v376;
		  v378 = v388;
		  *(_OWORD *)&this->fields.inkWashConfig.overlayConfig.verticalFadeAffectDist = v377;
		  v379 = v389;
		  *(_OWORD *)&this->fields.inkWashConfig.maskConfig.addNewInkDrop = v378;
		  v380 = v390;
		  *(Color *)&this->fields.inkWashConfig.maskConfig.inkDropSize = v379;
		  v381 = v391;
		  *(_OWORD *)&this->fields.inkWashConfig.maskConfig.currInkPointPos.y = v380;
		  v382 = v392;
		  *(_OWORD *)&this->fields.inkWashConfig.maskConfig.currInkPointDir.z = v381;
		  *(_OWORD *)&this->fields.inkWashConfig.maskConfig.edgeFade = v382;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.inkWashConfig.baseConfig, v353, v354, v355, (MethodInfo *)v383);
		  UnityEngine::ScriptableObject::ScriptableObject((ScriptableObject *)this, 0LL);
		}
		
	
		// Methods
		public void Initialize() {} // 0x0000000189CE1AD4-0x0000000189CE2A88
		// Void Initialize()
		void HG::Rendering::Runtime::HGEnvironmentPhase::Initialize(HGEnvironmentPhase *this, MethodInfo *method)
		{
		  Color *v3; // rcx
		  __int64 v4; // rdi
		  __int64 v5; // rdx
		  HGLightConfig__StaticFields *static_fields; // rax
		  Color v7; // xmm1
		  Color v8; // xmm0
		  Color v9; // xmm1
		  Color v10; // xmm0
		  Color v11; // xmm1
		  Color v12; // xmm0
		  Color v13; // xmm1
		  __int64 v14; // rdx
		  Color v15; // xmm1
		  Color v16; // xmm0
		  Color v17; // xmm1
		  Color v18; // xmm0
		  Color v19; // xmm1
		  Color v20; // xmm0
		  int32_t sunDiscPitchYawMode; // eax
		  HGLightConfig *p_lightConfig; // rcx
		  Color *v23; // rax
		  Color v24; // xmm1
		  Color v25; // xmm0
		  Color v26; // xmm1
		  Color v27; // xmm0
		  Color v28; // xmm1
		  Color v29; // xmm0
		  Color v30; // xmm1
		  Color v31; // xmm1
		  Color v32; // xmm0
		  Color v33; // xmm1
		  Color v34; // xmm0
		  Color v35; // xmm1
		  Color v36; // xmm0
		  int32_t r_low; // eax
		  PropertyInfo_1 *v38; // r8
		  Int32__Array **v39; // r9
		  __int128 *v40; // rcx
		  __int64 v41; // rdx
		  HGSkyConfig__StaticFields *v42; // rax
		  __int128 v43; // xmm1
		  __int128 v44; // xmm0
		  __int128 v45; // xmm1
		  __int128 v46; // xmm0
		  __int128 v47; // xmm1
		  __int128 v48; // xmm0
		  __int128 v49; // xmm1
		  __int64 v50; // rdx
		  __int128 v51; // xmm1
		  __int128 v52; // xmm0
		  __int128 v53; // xmm1
		  __int128 v54; // xmm0
		  __int64 v55; // rax
		  HGSkyConfig *p_skyConfig; // rcx
		  __int128 *v57; // rax
		  __int128 v58; // xmm1
		  __int128 v59; // xmm0
		  __int128 v60; // xmm1
		  __int128 v61; // xmm0
		  __int128 v62; // xmm1
		  __int128 v63; // xmm0
		  __int128 v64; // xmm1
		  __int128 v65; // xmm1
		  __int128 v66; // xmm0
		  __int128 v67; // xmm1
		  __int128 v68; // xmm0
		  __int64 v69; // rax
		  HGAtmosphereConfig__StaticFields *v70; // rax
		  Color v71; // xmm1
		  __int128 v72; // xmm0
		  Color rayleighScattering; // xmm1
		  __int128 v74; // xmm0
		  __int128 v75; // xmm1
		  Color v76; // xmm0
		  __int128 v77; // xmm1
		  __int128 v78; // xmm0
		  __int64 v79; // rax
		  Color v80; // xmm1
		  __int128 v81; // xmm0
		  Color v82; // xmm1
		  __int128 v83; // xmm0
		  __int128 v84; // xmm1
		  Color v85; // xmm0
		  __int128 v86; // xmm1
		  __int128 v87; // xmm0
		  __int64 v88; // rax
		  HGFogConfig__StaticFields *v89; // rcx
		  int v90; // eax
		  __int128 v91; // xmm1
		  __int128 v92; // xmm2
		  __int128 v93; // xmm3
		  Color inscatterAmbientColor; // xmm4
		  HGHeightFogConfig__StaticFields *v95; // rcx
		  Color v96; // xmm1
		  __int128 v97; // xmm0
		  Color v98; // xmm1
		  __int128 v99; // xmm0
		  __int128 v100; // xmm1
		  Color heightFogDirectionalInscatteringMobile; // xmm0
		  __int128 v102; // xmm1
		  __int64 v103; // rax
		  __int128 v104; // xmm0
		  __int128 v105; // xmm1
		  __int128 v106; // xmm0
		  __int128 v107; // xmm1
		  __int128 v108; // xmm0
		  Color v109; // xmm1
		  __int128 v110; // xmm0
		  Color v111; // xmm1
		  __int128 v112; // xmm0
		  __int128 v113; // xmm1
		  Color v114; // xmm0
		  __int128 v115; // xmm1
		  __int128 v116; // xmm0
		  __int64 v117; // rax
		  __int128 v118; // xmm1
		  __int128 v119; // xmm0
		  __int128 v120; // xmm1
		  __int128 v121; // xmm0
		  PropertyInfo_1 *v122; // r8
		  Int32__Array **v123; // r9
		  __int64 v124; // rdx
		  HGVolumetricFogConfig__StaticFields *v125; // rcx
		  __int128 *v126; // rax
		  __int128 v127; // xmm1
		  __int128 v128; // xmm0
		  __int128 v129; // xmm1
		  __int128 v130; // xmm0
		  __int128 v131; // xmm1
		  __int128 v132; // xmm0
		  Color volumetricFogAlbedo; // xmm1
		  __int64 v134; // rdx
		  __int128 v135; // xmm1
		  __int128 v136; // xmm0
		  __int128 v137; // xmm1
		  __int128 v138; // xmm0
		  __int128 v139; // xmm1
		  __int128 v140; // xmm0
		  __int128 *v141; // rcx
		  HGVolumetricFogConfig *p_volumetricFogConfig; // rax
		  __int128 v143; // xmm1
		  __int128 v144; // xmm0
		  __int128 v145; // xmm1
		  __int128 v146; // xmm0
		  __int128 v147; // xmm1
		  __int128 v148; // xmm0
		  __int128 v149; // xmm1
		  __int128 v150; // xmm1
		  __int128 v151; // xmm0
		  __int128 v152; // xmm1
		  __int128 v153; // xmm0
		  __int128 v154; // xmm1
		  __int128 v155; // xmm0
		  HGVolumetricCloudConfig__StaticFields *v156; // rcx
		  bool m_active; // dl
		  HGCloudConfig__StaticFields *v158; // rcx
		  Color cloudTint; // xmm1
		  __int128 v160; // xmm0
		  Color v161; // xmm1
		  __int128 v162; // xmm0
		  __int128 v163; // xmm1
		  Color v164; // xmm0
		  __int128 v165; // xmm1
		  __int128 v166; // xmm0
		  __int128 v167; // xmm1
		  __int128 v168; // xmm0
		  Color v169; // xmm1
		  __int128 v170; // xmm0
		  Color v171; // xmm1
		  __int128 v172; // xmm0
		  __int128 v173; // xmm1
		  Color v174; // xmm0
		  __int128 v175; // xmm1
		  __int128 v176; // xmm0
		  __int128 v177; // xmm1
		  __int128 v178; // xmm0
		  Type *v179; // rdx
		  PropertyInfo_1 *v180; // r8
		  Int32__Array **v181; // r9
		  PropertyInfo_1 *v182; // r8
		  Int32__Array **v183; // r9
		  __int128 *v184; // rcx
		  __int64 v185; // rdx
		  HGCelestialConfig__StaticFields *v186; // rax
		  __int128 v187; // xmm1
		  __int128 v188; // xmm0
		  __int128 v189; // xmm1
		  __int128 v190; // xmm0
		  __int128 v191; // xmm1
		  __int128 v192; // xmm0
		  __int128 v193; // xmm1
		  __int64 v194; // rdx
		  __int128 v195; // xmm1
		  __int128 v196; // xmm0
		  __int128 v197; // xmm1
		  __int128 v198; // xmm0
		  __int128 v199; // xmm1
		  Material *drawMaterial; // rax
		  HGCelestialConfig *p_celestialConfig; // rcx
		  __int128 *v202; // rax
		  __int128 v203; // xmm1
		  __int128 v204; // xmm0
		  __int128 v205; // xmm1
		  __int128 v206; // xmm0
		  __int128 v207; // xmm1
		  __int128 v208; // xmm0
		  __int128 v209; // xmm1
		  __int128 v210; // xmm1
		  __int128 v211; // xmm0
		  __int128 v212; // xmm1
		  __int128 v213; // xmm0
		  __int128 v214; // xmm1
		  Material *v215; // rax
		  HGWindConfig__StaticFields *v216; // rcx
		  int v217; // eax
		  HGLightShaftConfig__StaticFields *v218; // rcx
		  int v219; // eax
		  Color bloomTint; // xmm1
		  __int128 v221; // xmm2
		  HGTerrainDeformConfig__StaticFields *v222; // rcx
		  int v223; // eax
		  HGInkSimulationConfig__StaticFields *v224; // rcx
		  __int128 v225; // xmm2
		  __int128 v226; // xmm3
		  __int128 v227; // xmm4
		  __int128 v228; // xmm5
		  __int128 v229; // xmm6
		  __int128 v230; // xmm7
		  Type *v231; // rdx
		  PropertyInfo_1 *v232; // r8
		  Int32__Array **v233; // r9
		  __int64 v234; // rdx
		  HGRainConfig__StaticFields *v235; // rcx
		  __int128 *v236; // rax
		  __int128 v237; // xmm1
		  __int128 v238; // xmm0
		  __int128 v239; // xmm1
		  __int128 v240; // xmm0
		  __int128 v241; // xmm1
		  __int128 v242; // xmm0
		  __int128 v243; // xmm1
		  __int64 v244; // rdx
		  __int128 v245; // xmm1
		  __int128 v246; // xmm0
		  __int128 *v247; // rcx
		  HGRainConfig *p_rainConfig; // rax
		  __int128 v249; // xmm1
		  __int128 v250; // xmm0
		  __int128 v251; // xmm1
		  __int128 v252; // xmm0
		  __int128 v253; // xmm1
		  __int128 v254; // xmm0
		  __int128 v255; // xmm1
		  __int128 v256; // xmm1
		  __int128 v257; // xmm0
		  HGSnowConfig__StaticFields *v258; // rcx
		  Color color; // xmm2
		  __int128 v260; // xmm3
		  __int128 v261; // xmm4
		  __int128 v262; // xmm5
		  HGStarConfig__StaticFields *v263; // rax
		  Color v264; // xmm1
		  __int128 v265; // xmm0
		  Color v266; // xmm1
		  __int128 v267; // xmm0
		  __int128 v268; // xmm1
		  Color v269; // xmm0
		  __int128 v270; // xmm1
		  __int128 v271; // xmm0
		  __int64 v272; // rax
		  Color v273; // xmm1
		  __int128 v274; // xmm0
		  Color v275; // xmm1
		  __int128 v276; // xmm0
		  __int128 v277; // xmm1
		  Color v278; // xmm0
		  __int128 v279; // xmm1
		  __int128 v280; // xmm0
		  __int64 v281; // rax
		  Type *v282; // rdx
		  PropertyInfo_1 *v283; // r8
		  Int32__Array **v284; // r9
		  HGLensFlareConfig__StaticFields *v285; // rcx
		  __int128 v286; // xmm1
		  __int128 v287; // xmm2
		  Type *v288; // rdx
		  PropertyInfo_1 *v289; // r8
		  Int32__Array **v290; // r9
		  PropertyInfo_1 *v291; // r8
		  Int32__Array **v292; // r9
		  __int64 v293; // rdx
		  __int128 *v294; // rax
		  HGColorGradingConfig *p_defaultConfig; // rcx
		  __int128 v296; // xmm1
		  __int128 v297; // xmm0
		  __int128 v298; // xmm1
		  __int128 v299; // xmm0
		  __int128 v300; // xmm1
		  __int128 v301; // xmm0
		  Vector4 shadows; // xmm1
		  __int128 v303; // xmm1
		  __int128 v304; // xmm0
		  __int128 v305; // xmm1
		  __int128 v306; // xmm0
		  __int128 v307; // xmm1
		  __int128 v308; // xmm0
		  __int128 *v309; // rcx
		  HGColorGradingConfig *p_colorGradingConfig; // rax
		  __int128 v311; // xmm1
		  __int128 v312; // xmm0
		  __int128 v313; // xmm1
		  __int128 v314; // xmm0
		  __int128 v315; // xmm1
		  __int128 v316; // xmm0
		  __int128 v317; // xmm1
		  __int128 v318; // xmm1
		  __int128 v319; // xmm0
		  __int128 v320; // xmm1
		  __int128 v321; // xmm0
		  __int128 v322; // xmm1
		  __int128 v323; // xmm0
		  HGAutoExposureConfig__StaticFields *v324; // rcx
		  int v325; // eax
		  __int128 v326; // xmm2
		  __int128 v327; // xmm3
		  HGShadowConfig__StaticFields *v328; // rcx
		  __int128 v329; // xmm1
		  __int128 v330; // xmm2
		  __int128 v331; // xmm3
		  __int128 v332; // xmm4
		  __int128 v333; // xmm5
		  __int128 v334; // xmm6
		  __int128 v335; // xmm7
		  Type *v336; // rdx
		  PropertyInfo_1 *v337; // r8
		  Int32__Array **v338; // r9
		  HGAnamorphicStreaksConfig__StaticFields *v339; // rcx
		  Color v340; // xmm1
		  __int128 v341; // xmm2
		  HGWaterEnvConfig__StaticFields *v342; // rcx
		  int v343; // eax
		  HGInkWashConfig__StaticFields *v344; // rcx
		  Color v345; // xmm1
		  __int128 v346; // xmm0
		  __int128 v347; // xmm0
		  __int128 v348; // xmm1
		  Color v349; // xmm0
		  __int128 v350; // xmm1
		  __int128 v351; // xmm0
		  __int128 v352; // xmm1
		  Color v353; // xmm1
		  __int128 v354; // xmm0
		  Color v355; // xmm1
		  __int128 v356; // xmm0
		  __int128 v357; // xmm1
		  Color v358; // xmm0
		  __int128 v359; // xmm1
		  __int128 v360; // xmm0
		  __int128 v361; // xmm1
		  Type *v362; // rdx
		  PropertyInfo_1 *v363; // r8
		  Int32__Array **v364; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v366; // rdx
		  __int64 v367; // rcx
		  __int128 v368; // [rsp+28h] [rbp-E0h] BYREF
		  Color v369; // [rsp+38h] [rbp-D0h]
		  __int128 v370; // [rsp+48h] [rbp-C0h]
		  Color v371; // [rsp+58h] [rbp-B0h]
		  __int128 v372; // [rsp+68h] [rbp-A0h]
		  __int128 v373; // [rsp+78h] [rbp-90h]
		  Color v374; // [rsp+88h] [rbp-80h]
		  __int128 v375; // [rsp+98h] [rbp-70h]
		  __int128 v376; // [rsp+A8h] [rbp-60h]
		  __int128 v377; // [rsp+B8h] [rbp-50h]
		  __int128 v378; // [rsp+C8h] [rbp-40h]
		  __int128 v379; // [rsp+D8h] [rbp-30h]
		  __int128 v380; // [rsp+E8h] [rbp-20h]
		  __int64 v381; // [rsp+F8h] [rbp-10h]
		  float a; // [rsp+100h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1444, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1444, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v367, v366);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGLightConfig);
		    v3 = (Color *)&v368;
		    v4 = 2LL;
		    v5 = 2LL;
		    static_fields = TypeInfo::HG::Rendering::Runtime::HGLightConfig->static_fields;
		    do
		    {
		      v7 = *(Color *)&static_fields->defaultConfig.directColorMode;
		      *v3 = static_fields->defaultConfig.directColor;
		      v8 = *(Color *)&static_fields->defaultConfig.directCustomColor.a;
		      v3[1] = v7;
		      v9 = *(Color *)&static_fields->defaultConfig.directSpecularIntensity;
		      v3[2] = v8;
		      v10 = *(Color *)&static_fields->defaultConfig.directPitchYaw.y;
		      v3[3] = v9;
		      v11 = *(Color *)&static_fields->defaultConfig.indirectSpecularFactor;
		      v3[4] = v10;
		      v12 = *(Color *)&static_fields->defaultConfig.atmospherePitchYaw.y;
		      v3[5] = v11;
		      v13 = *(Color *)&static_fields->defaultConfig.sunDiscPitchYawMode;
		      static_fields = (HGLightConfig__StaticFields *)((char *)static_fields + 128);
		      v3[6] = v12;
		      v3 += 8;
		      v3[-1] = v13;
		      --v5;
		    }
		    while ( v5 );
		    v14 = 2LL;
		    v15 = *(Color *)&static_fields->defaultConfig.directColorMode;
		    *v3 = static_fields->defaultConfig.directColor;
		    v16 = *(Color *)&static_fields->defaultConfig.directCustomColor.a;
		    v3[1] = v15;
		    v17 = *(Color *)&static_fields->defaultConfig.directSpecularIntensity;
		    v3[2] = v16;
		    v18 = *(Color *)&static_fields->defaultConfig.directPitchYaw.y;
		    v3[3] = v17;
		    v19 = *(Color *)&static_fields->defaultConfig.indirectSpecularFactor;
		    v3[4] = v18;
		    v20 = *(Color *)&static_fields->defaultConfig.atmospherePitchYaw.y;
		    sunDiscPitchYawMode = static_fields->defaultConfig.sunDiscPitchYawMode;
		    v3[5] = v19;
		    v3[6] = v20;
		    LODWORD(v3[7].r) = sunDiscPitchYawMode;
		    p_lightConfig = &this->fields.lightConfig;
		    v23 = (Color *)&v368;
		    do
		    {
		      v24 = v23[1];
		      p_lightConfig->directColor = *v23;
		      v25 = v23[2];
		      *(Color *)&p_lightConfig->directColorMode = v24;
		      v26 = v23[3];
		      *(Color *)&p_lightConfig->directCustomColor.a = v25;
		      v27 = v23[4];
		      *(Color *)&p_lightConfig->directSpecularIntensity = v26;
		      v28 = v23[5];
		      *(Color *)&p_lightConfig->directPitchYaw.y = v27;
		      v29 = v23[6];
		      *(Color *)&p_lightConfig->indirectSpecularFactor = v28;
		      v30 = v23[7];
		      v23 += 8;
		      *(Color *)&p_lightConfig->atmospherePitchYaw.y = v29;
		      p_lightConfig = (HGLightConfig *)((char *)p_lightConfig + 128);
		      *(Color *)&p_lightConfig[-1].rotationHeightFogDirectionalInscattering.y = v30;
		      --v14;
		    }
		    while ( v14 );
		    v31 = v23[1];
		    p_lightConfig->directColor = *v23;
		    v32 = v23[2];
		    *(Color *)&p_lightConfig->directColorMode = v31;
		    v33 = v23[3];
		    *(Color *)&p_lightConfig->directCustomColor.a = v32;
		    v34 = v23[4];
		    *(Color *)&p_lightConfig->directSpecularIntensity = v33;
		    v35 = v23[5];
		    *(Color *)&p_lightConfig->directPitchYaw.y = v34;
		    v36 = v23[6];
		    r_low = LODWORD(v23[7].r);
		    *(Color *)&p_lightConfig->indirectSpecularFactor = v35;
		    *(Color *)&p_lightConfig->atmospherePitchYaw.y = v36;
		    p_lightConfig->sunDiscPitchYawMode = r_low;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGSkyConfig);
		    v40 = &v368;
		    v41 = 2LL;
		    v42 = TypeInfo::HG::Rendering::Runtime::HGSkyConfig->static_fields;
		    do
		    {
		      v43 = *(_OWORD *)&v42->defaultConfig.skyDirectIntensity;
		      *v40 = *(_OWORD *)&v42->defaultConfig.parentEnvPhaseGuid;
		      v44 = *(_OWORD *)&v42->defaultConfig.customIVDefaultSH.shr2;
		      v40[1] = v43;
		      v45 = *(_OWORD *)&v42->defaultConfig.customIVDefaultSH.shr6;
		      v40[2] = v44;
		      v46 = *(_OWORD *)&v42->defaultConfig.customIVDefaultSH.shg1;
		      v40[3] = v45;
		      v47 = *(_OWORD *)&v42->defaultConfig.customIVDefaultSH.shg5;
		      v40[4] = v46;
		      v48 = *(_OWORD *)&v42->defaultConfig.customIVDefaultSH.shb0;
		      v40[5] = v47;
		      v49 = *(_OWORD *)&v42->defaultConfig.customIVDefaultSH.shb4;
		      v42 = (HGSkyConfig__StaticFields *)((char *)v42 + 128);
		      v40[6] = v48;
		      v40 += 8;
		      *(v40 - 1) = v49;
		      --v41;
		    }
		    while ( v41 );
		    v50 = 2LL;
		    v51 = *(_OWORD *)&v42->defaultConfig.skyDirectIntensity;
		    *v40 = *(_OWORD *)&v42->defaultConfig.parentEnvPhaseGuid;
		    v52 = *(_OWORD *)&v42->defaultConfig.customIVDefaultSH.shr2;
		    v40[1] = v51;
		    v53 = *(_OWORD *)&v42->defaultConfig.customIVDefaultSH.shr6;
		    v40[2] = v52;
		    v54 = *(_OWORD *)&v42->defaultConfig.customIVDefaultSH.shg1;
		    v55 = *(_QWORD *)&v42->defaultConfig.customIVDefaultSH.shg5;
		    v40[3] = v53;
		    v40[4] = v54;
		    *((_QWORD *)v40 + 10) = v55;
		    p_skyConfig = &this->fields.skyConfig;
		    v57 = &v368;
		    do
		    {
		      v58 = v57[1];
		      *(_OWORD *)&p_skyConfig->parentEnvPhaseGuid = *v57;
		      v59 = v57[2];
		      *(_OWORD *)&p_skyConfig->skyDirectIntensity = v58;
		      v60 = v57[3];
		      *(_OWORD *)&p_skyConfig->customIVDefaultSH.shr2 = v59;
		      v61 = v57[4];
		      *(_OWORD *)&p_skyConfig->customIVDefaultSH.shr6 = v60;
		      v62 = v57[5];
		      *(_OWORD *)&p_skyConfig->customIVDefaultSH.shg1 = v61;
		      v63 = v57[6];
		      *(_OWORD *)&p_skyConfig->customIVDefaultSH.shg5 = v62;
		      v64 = v57[7];
		      v57 += 8;
		      *(_OWORD *)&p_skyConfig->customIVDefaultSH.shb0 = v63;
		      p_skyConfig = (HGSkyConfig *)((char *)p_skyConfig + 128);
		      *(_OWORD *)&p_skyConfig[-1].skyboxCubeMap = v64;
		      --v50;
		    }
		    while ( v50 );
		    v65 = v57[1];
		    *(_OWORD *)&p_skyConfig->parentEnvPhaseGuid = *v57;
		    v66 = v57[2];
		    *(_OWORD *)&p_skyConfig->skyDirectIntensity = v65;
		    v67 = v57[3];
		    *(_OWORD *)&p_skyConfig->customIVDefaultSH.shr2 = v66;
		    v68 = v57[4];
		    v69 = *((_QWORD *)v57 + 10);
		    *(_OWORD *)&p_skyConfig->customIVDefaultSH.shr6 = v67;
		    *(_OWORD *)&p_skyConfig->customIVDefaultSH.shg1 = v68;
		    *(_QWORD *)&p_skyConfig->customIVDefaultSH.shg5 = v69;
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields.skyConfig, 0LL, v38, v39, (MethodInfo *)v368);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGAtmosphereConfig);
		    v70 = TypeInfo::HG::Rendering::Runtime::HGAtmosphereConfig->static_fields;
		    v71 = *(Color *)&v70->defaultConfig.groundAlbedo.a;
		    v368 = *(_OWORD *)&v70->defaultConfig.groundRadius;
		    v72 = *(_OWORD *)&v70->defaultConfig.outerSunIrradianceColor.a;
		    v369 = v71;
		    rayleighScattering = v70->defaultConfig.rayleighScattering;
		    v370 = v72;
		    v74 = *(_OWORD *)&v70->defaultConfig.rayleighExponentialDistribution;
		    v371 = rayleighScattering;
		    v75 = *(_OWORD *)&v70->defaultConfig.mieScattering.b;
		    v372 = v74;
		    v76 = *(Color *)&v70->defaultConfig.mieAbsorption.g;
		    v373 = v75;
		    v77 = *(_OWORD *)&v70->defaultConfig.mieExponentialDistribution;
		    v374 = v76;
		    v78 = *(_OWORD *)&v70->defaultConfig.ozoneAbsorption.b;
		    v79 = *(_QWORD *)&v70->defaultConfig.tentWidth;
		    v375 = v77;
		    v376 = v78;
		    *(_QWORD *)&v377 = v79;
		    v80 = v369;
		    *(_OWORD *)&this->fields.atmosphereConfig.groundRadius = v368;
		    v81 = v370;
		    *(Color *)&this->fields.atmosphereConfig.groundAlbedo.a = v80;
		    v82 = v371;
		    *(_OWORD *)&this->fields.atmosphereConfig.outerSunIrradianceColor.a = v81;
		    v83 = v372;
		    this->fields.atmosphereConfig.rayleighScattering = v82;
		    v84 = v373;
		    *(_OWORD *)&this->fields.atmosphereConfig.rayleighExponentialDistribution = v83;
		    v85 = v374;
		    *(_OWORD *)&this->fields.atmosphereConfig.mieScattering.b = v84;
		    v86 = v375;
		    *(Color *)&this->fields.atmosphereConfig.mieAbsorption.g = v85;
		    v87 = v376;
		    v88 = v377;
		    *(_OWORD *)&this->fields.atmosphereConfig.mieExponentialDistribution = v86;
		    *(_OWORD *)&this->fields.atmosphereConfig.ozoneAbsorption.b = v87;
		    *(_QWORD *)&this->fields.atmosphereConfig.tentWidth = v88;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGFogConfig);
		    v89 = TypeInfo::HG::Rendering::Runtime::HGFogConfig->static_fields;
		    v90 = *(_DWORD *)&v89->defaultConfig.m_active;
		    v91 = *(_OWORD *)&v89->defaultConfig.fallOffDistance;
		    v92 = *(_OWORD *)&v89->defaultConfig.mieScattering.a;
		    v93 = *(_OWORD *)&v89->defaultConfig.rayleighScattering.g;
		    inscatterAmbientColor = v89->defaultConfig.inscatterAmbientColor;
		    *(_OWORD *)&this->fields.fogConfig.enable = *(_OWORD *)&v89->defaultConfig.enable;
		    *(_OWORD *)&this->fields.fogConfig.fallOffDistance = v91;
		    *(_OWORD *)&this->fields.fogConfig.mieScattering.a = v92;
		    *(_OWORD *)&this->fields.fogConfig.rayleighScattering.g = v93;
		    this->fields.fogConfig.inscatterAmbientColor = inscatterAmbientColor;
		    *(_DWORD *)&this->fields.fogConfig.m_active = v90;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGHeightFogConfig);
		    v95 = TypeInfo::HG::Rendering::Runtime::HGHeightFogConfig->static_fields;
		    v96 = *(Color *)&v95->defaultConfig.heightFogStartHeightSecond;
		    v368 = *(_OWORD *)&v95->defaultConfig.enable;
		    v97 = *(_OWORD *)&v95->defaultConfig.heightFogInscatter.g;
		    v369 = v96;
		    v98 = *(Color *)&v95->defaultConfig.heightFogStartDistance;
		    v370 = v97;
		    v99 = *(_OWORD *)&v95->defaultConfig.heightFogCullingFarClipPlane;
		    v371 = v98;
		    v100 = *(_OWORD *)&v95->defaultConfig.heightFogDirectionalInscattering.g;
		    v372 = v99;
		    heightFogDirectionalInscatteringMobile = v95->defaultConfig.heightFogDirectionalInscatteringMobile;
		    v373 = v100;
		    v102 = *(_OWORD *)&v95->defaultConfig.enableVolumetricFog;
		    v95 = (HGHeightFogConfig__StaticFields *)((char *)v95 + 128);
		    v374 = heightFogDirectionalInscatteringMobile;
		    v103 = *(_QWORD *)&v95->defaultConfig.heightFogDirectionalInscattering.g;
		    v104 = *(_OWORD *)&v95->defaultConfig.enable;
		    v375 = v102;
		    v105 = *(_OWORD *)&v95->defaultConfig.heightFogStartHeightSecond;
		    v376 = v104;
		    v106 = *(_OWORD *)&v95->defaultConfig.heightFogInscatter.g;
		    v377 = v105;
		    v107 = *(_OWORD *)&v95->defaultConfig.heightFogStartDistance;
		    v378 = v106;
		    v108 = *(_OWORD *)&v95->defaultConfig.heightFogCullingFarClipPlane;
		    v379 = v107;
		    v380 = v108;
		    v381 = v103;
		    a = v95->defaultConfig.heightFogDirectionalInscattering.a;
		    v109 = v369;
		    *(_OWORD *)&this->fields.heightFogConfig.enable = v368;
		    v110 = v370;
		    *(Color *)&this->fields.heightFogConfig.heightFogStartHeightSecond = v109;
		    v111 = v371;
		    *(_OWORD *)&this->fields.heightFogConfig.heightFogInscatter.g = v110;
		    v112 = v372;
		    *(Color *)&this->fields.heightFogConfig.heightFogStartDistance = v111;
		    v113 = v373;
		    *(_OWORD *)&this->fields.heightFogConfig.heightFogCullingFarClipPlane = v112;
		    v114 = v374;
		    *(_OWORD *)&this->fields.heightFogConfig.heightFogDirectionalInscattering.g = v113;
		    v115 = v375;
		    this->fields.heightFogConfig.heightFogDirectionalInscatteringMobile = v114;
		    v116 = v376;
		    v117 = v381;
		    *(_OWORD *)&this->fields.heightFogConfig.enableVolumetricFog = v115;
		    v118 = v377;
		    *(_OWORD *)&this->fields.heightFogConfig.volumetricFogAlbedo.b = v116;
		    v119 = v378;
		    *(_OWORD *)&this->fields.heightFogConfig.volumetricFogEmissive.b = v118;
		    v120 = v379;
		    *(_OWORD *)&this->fields.heightFogConfig.volumetricFogStartDistance = v119;
		    v121 = v380;
		    *(_OWORD *)&this->fields.heightFogConfig.enableFlowNoise = v120;
		    *(_OWORD *)&this->fields.heightFogConfig.flowNoiseHorizontalDirAngle = v121;
		    *(_QWORD *)&this->fields.heightFogConfig.flowNoiseDir.z = v117;
		    *(float *)&this->fields.heightFogConfig.m_active = a;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig);
		    v124 = 2LL;
		    v125 = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig->static_fields;
		    v126 = &v368;
		    do
		    {
		      v127 = *(_OWORD *)&v125->defaultConfig.heightFogStartHeightSecond;
		      *v126 = *(_OWORD *)&v125->defaultConfig.enable;
		      v128 = *(_OWORD *)&v125->defaultConfig.heightFogInscatter.g;
		      v126[1] = v127;
		      v129 = *(_OWORD *)&v125->defaultConfig.heightFogStartDistance;
		      v126[2] = v128;
		      v130 = *(_OWORD *)&v125->defaultConfig.heightFogDirectionalInscatteringExponent;
		      v126[3] = v129;
		      v131 = *(_OWORD *)&v125->defaultConfig.heightFogDirectionalInscattering.b;
		      v126[4] = v130;
		      v132 = *(_OWORD *)&v125->defaultConfig.heightFogDirectionalInscatteringMobile.g;
		      v126[5] = v131;
		      volumetricFogAlbedo = v125->defaultConfig.volumetricFogAlbedo;
		      v125 = (HGVolumetricFogConfig__StaticFields *)((char *)v125 + 128);
		      v126[6] = v132;
		      v126 += 8;
		      *(v126 - 1) = (__int128)volumetricFogAlbedo;
		      --v124;
		    }
		    while ( v124 );
		    v134 = 2LL;
		    v135 = *(_OWORD *)&v125->defaultConfig.heightFogStartHeightSecond;
		    *v126 = *(_OWORD *)&v125->defaultConfig.enable;
		    v136 = *(_OWORD *)&v125->defaultConfig.heightFogInscatter.g;
		    v126[1] = v135;
		    v137 = *(_OWORD *)&v125->defaultConfig.heightFogStartDistance;
		    v126[2] = v136;
		    v138 = *(_OWORD *)&v125->defaultConfig.heightFogDirectionalInscatteringExponent;
		    v126[3] = v137;
		    v139 = *(_OWORD *)&v125->defaultConfig.heightFogDirectionalInscattering.b;
		    v126[4] = v138;
		    v140 = *(_OWORD *)&v125->defaultConfig.heightFogDirectionalInscatteringMobile.g;
		    v141 = &v368;
		    v126[5] = v139;
		    v126[6] = v140;
		    p_volumetricFogConfig = &this->fields.volumetricFogConfig;
		    do
		    {
		      v143 = v141[1];
		      *(_OWORD *)&p_volumetricFogConfig->enable = *v141;
		      v144 = v141[2];
		      *(_OWORD *)&p_volumetricFogConfig->heightFogStartHeightSecond = v143;
		      v145 = v141[3];
		      *(_OWORD *)&p_volumetricFogConfig->heightFogInscatter.g = v144;
		      v146 = v141[4];
		      *(_OWORD *)&p_volumetricFogConfig->heightFogStartDistance = v145;
		      v147 = v141[5];
		      *(_OWORD *)&p_volumetricFogConfig->heightFogDirectionalInscatteringExponent = v146;
		      v148 = v141[6];
		      *(_OWORD *)&p_volumetricFogConfig->heightFogDirectionalInscattering.b = v147;
		      v149 = v141[7];
		      v141 += 8;
		      *(_OWORD *)&p_volumetricFogConfig->heightFogDirectionalInscatteringMobile.g = v148;
		      p_volumetricFogConfig = (HGVolumetricFogConfig *)((char *)p_volumetricFogConfig + 128);
		      *(_OWORD *)&p_volumetricFogConfig[-1].m_backupFlowVLNoiseRemapRange.x = v149;
		      --v134;
		    }
		    while ( v134 );
		    v150 = v141[1];
		    *(_OWORD *)&p_volumetricFogConfig->enable = *v141;
		    v151 = v141[2];
		    *(_OWORD *)&p_volumetricFogConfig->heightFogStartHeightSecond = v150;
		    v152 = v141[3];
		    *(_OWORD *)&p_volumetricFogConfig->heightFogInscatter.g = v151;
		    v153 = v141[4];
		    *(_OWORD *)&p_volumetricFogConfig->heightFogStartDistance = v152;
		    v154 = v141[5];
		    *(_OWORD *)&p_volumetricFogConfig->heightFogDirectionalInscatteringExponent = v153;
		    v155 = v141[6];
		    *(_OWORD *)&p_volumetricFogConfig->heightFogDirectionalInscattering.b = v154;
		    *(_OWORD *)&p_volumetricFogConfig->heightFogDirectionalInscatteringMobile.g = v155;
		    sub_18002D1B0(
		      (SingleFieldAccessor *)&this->fields.volumetricFogConfig.flowVLNoise3DTexture,
		      0LL,
		      v122,
		      v123,
		      (MethodInfo *)v368);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVolumetricCloudConfig);
		    v156 = TypeInfo::HG::Rendering::Runtime::HGVolumetricCloudConfig->static_fields;
		    m_active = v156->defaultConfig.m_active;
		    *(_WORD *)&this->fields.volumetricCloudConfig.enabled = *(_WORD *)&v156->defaultConfig.enabled;
		    this->fields.volumetricCloudConfig.m_active = m_active;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGCloudConfig);
		    v158 = TypeInfo::HG::Rendering::Runtime::HGCloudConfig->static_fields;
		    cloudTint = v158->defaultConfig.cloudTint;
		    v368 = *(_OWORD *)&v158->defaultConfig.enable;
		    v160 = *(_OWORD *)&v158->defaultConfig.cloudContrast;
		    v369 = cloudTint;
		    v161 = *(Color *)&v158->defaultConfig.brightnessAffectCloudAlpha;
		    v370 = v160;
		    v162 = *(_OWORD *)&v158->defaultConfig.cloudFlowType;
		    v371 = v161;
		    v163 = *(_OWORD *)&v158->defaultConfig.flowSpeed;
		    v372 = v162;
		    v164 = *(Color *)&v158->defaultConfig.lightShaftCloudMaskTexture;
		    v373 = v163;
		    v165 = *(_OWORD *)&v158->defaultConfig.cloudShadowConfig.cloudShadowTexture;
		    v374 = v164;
		    v166 = *(_OWORD *)&v158->defaultConfig.cloudShadowConfig.cloudShadowEnvCenter.z;
		    v375 = v165;
		    v167 = *(_OWORD *)&v158->defaultConfig.cloudShadowConfig.cloudShadowFlowDirection.y;
		    v376 = v166;
		    v168 = *(_OWORD *)&v158->defaultConfig.cloudShadowConfig.cloudShadowScaleEndDistance;
		    v377 = v167;
		    v378 = v168;
		    v169 = v369;
		    *(_OWORD *)&this->fields.cloudConfig.enable = v368;
		    v170 = v370;
		    this->fields.cloudConfig.cloudTint = v169;
		    v171 = v371;
		    *(_OWORD *)&this->fields.cloudConfig.cloudContrast = v170;
		    v172 = v372;
		    *(Color *)&this->fields.cloudConfig.brightnessAffectCloudAlpha = v171;
		    v173 = v373;
		    *(_OWORD *)&this->fields.cloudConfig.cloudFlowType = v172;
		    v174 = v374;
		    *(_OWORD *)&this->fields.cloudConfig.flowSpeed = v173;
		    v175 = v375;
		    *(Color *)&this->fields.cloudConfig.lightShaftCloudMaskTexture = v174;
		    v176 = v376;
		    *(_OWORD *)&this->fields.cloudConfig.cloudShadowConfig.cloudShadowTexture = v175;
		    v177 = v377;
		    *(_OWORD *)&this->fields.cloudConfig.cloudShadowConfig.cloudShadowEnvCenter.z = v176;
		    v178 = v378;
		    *(_OWORD *)&this->fields.cloudConfig.cloudShadowConfig.cloudShadowFlowDirection.y = v177;
		    *(_OWORD *)&this->fields.cloudConfig.cloudShadowConfig.cloudShadowScaleEndDistance = v178;
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields.cloudConfig.cloudTexture, v179, v180, v181, (MethodInfo *)v368);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGCelestialConfig);
		    v184 = &v368;
		    v185 = 2LL;
		    v186 = TypeInfo::HG::Rendering::Runtime::HGCelestialConfig->static_fields;
		    do
		    {
		      v187 = *(_OWORD *)&v186->defaultConfig.moonConfig.worldLongitude;
		      *v184 = *(_OWORD *)&v186->defaultConfig.moonConfig.radius;
		      v188 = *(_OWORD *)&v186->defaultConfig.moonConfig.ring.outerRadius;
		      v184[1] = v187;
		      v189 = *(_OWORD *)&v186->defaultConfig.moonConfig.ring.ringColor.b;
		      v184[2] = v188;
		      v190 = *(_OWORD *)&v186->defaultConfig.talosAlphaConfig.drawPlanetInSkydome;
		      v184[3] = v189;
		      v191 = *(_OWORD *)&v186->defaultConfig.talosAlphaConfig.objectProperty.selfTiltZ;
		      v184[4] = v190;
		      v192 = *(_OWORD *)&v186->defaultConfig.talosAlphaConfig.skydomeDrawer.drawMaterial;
		      v184[5] = v191;
		      v193 = *(_OWORD *)&v186->defaultConfig.talosAlphaConfig.skydomeDrawer.incidentLightingPitchYaw.x;
		      v186 = (HGCelestialConfig__StaticFields *)((char *)v186 + 128);
		      v184[6] = v192;
		      v184 += 8;
		      *(v184 - 1) = v193;
		      --v185;
		    }
		    while ( v185 );
		    v194 = 2LL;
		    v195 = *(_OWORD *)&v186->defaultConfig.moonConfig.worldLongitude;
		    *v184 = *(_OWORD *)&v186->defaultConfig.moonConfig.radius;
		    v196 = *(_OWORD *)&v186->defaultConfig.moonConfig.ring.outerRadius;
		    v184[1] = v195;
		    v197 = *(_OWORD *)&v186->defaultConfig.moonConfig.ring.ringColor.b;
		    v184[2] = v196;
		    v198 = *(_OWORD *)&v186->defaultConfig.talosAlphaConfig.drawPlanetInSkydome;
		    v184[3] = v197;
		    v199 = *(_OWORD *)&v186->defaultConfig.talosAlphaConfig.objectProperty.selfTiltZ;
		    drawMaterial = v186->defaultConfig.talosAlphaConfig.skydomeDrawer.drawMaterial;
		    v184[4] = v198;
		    v184[5] = v199;
		    *((_QWORD *)v184 + 12) = drawMaterial;
		    p_celestialConfig = &this->fields.celestialConfig;
		    v202 = &v368;
		    do
		    {
		      v203 = v202[1];
		      *(_OWORD *)&p_celestialConfig->moonConfig.radius = *v202;
		      v204 = v202[2];
		      *(_OWORD *)&p_celestialConfig->moonConfig.worldLongitude = v203;
		      v205 = v202[3];
		      *(_OWORD *)&p_celestialConfig->moonConfig.ring.outerRadius = v204;
		      v206 = v202[4];
		      *(_OWORD *)&p_celestialConfig->moonConfig.ring.ringColor.b = v205;
		      v207 = v202[5];
		      *(_OWORD *)&p_celestialConfig->talosAlphaConfig.drawPlanetInSkydome = v206;
		      v208 = v202[6];
		      *(_OWORD *)&p_celestialConfig->talosAlphaConfig.objectProperty.selfTiltZ = v207;
		      v209 = v202[7];
		      v202 += 8;
		      *(_OWORD *)&p_celestialConfig->talosAlphaConfig.skydomeDrawer.drawMaterial = v208;
		      p_celestialConfig = (HGCelestialConfig *)((char *)p_celestialConfig + 128);
		      *(_OWORD *)&p_celestialConfig[-1].advancedPlanetConfig.advancedPlanetMat = v209;
		      --v194;
		    }
		    while ( v194 );
		    v210 = v202[1];
		    *(_OWORD *)&p_celestialConfig->moonConfig.radius = *v202;
		    v211 = v202[2];
		    *(_OWORD *)&p_celestialConfig->moonConfig.worldLongitude = v210;
		    v212 = v202[3];
		    *(_OWORD *)&p_celestialConfig->moonConfig.ring.outerRadius = v211;
		    v213 = v202[4];
		    *(_OWORD *)&p_celestialConfig->moonConfig.ring.ringColor.b = v212;
		    v214 = v202[5];
		    v215 = (Material *)*((_QWORD *)v202 + 12);
		    *(_OWORD *)&p_celestialConfig->talosAlphaConfig.drawPlanetInSkydome = v213;
		    *(_OWORD *)&p_celestialConfig->talosAlphaConfig.objectProperty.selfTiltZ = v214;
		    p_celestialConfig->talosAlphaConfig.skydomeDrawer.drawMaterial = v215;
		    sub_18002D1B0(
		      (SingleFieldAccessor *)&this->fields.celestialConfig.moonConfig.ring.planetRingMap,
		      0LL,
		      v182,
		      v183,
		      (MethodInfo *)v368);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGWindConfig);
		    v216 = TypeInfo::HG::Rendering::Runtime::HGWindConfig->static_fields;
		    v217 = *(_DWORD *)&v216->defaultConfig.m_active;
		    *(_QWORD *)&v213 = *(_QWORD *)&v216->defaultConfig.direction.y;
		    *(_OWORD *)&this->fields.windConfig.speed = *(_OWORD *)&v216->defaultConfig.speed;
		    *(_QWORD *)&this->fields.windConfig.direction.y = v213;
		    *(_DWORD *)&this->fields.windConfig.m_active = v217;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGLightShaftConfig);
		    v218 = TypeInfo::HG::Rendering::Runtime::HGLightShaftConfig->static_fields;
		    v219 = *(_DWORD *)&v218->defaultConfig.m_active;
		    bloomTint = v218->defaultConfig.bloomTint;
		    v221 = *(_OWORD *)&v218->defaultConfig.blurIntensity;
		    *(_OWORD *)&this->fields.lightShaftConfig.enable = *(_OWORD *)&v218->defaultConfig.enable;
		    this->fields.lightShaftConfig.bloomTint = bloomTint;
		    *(_OWORD *)&this->fields.lightShaftConfig.blurIntensity = v221;
		    *(_DWORD *)&this->fields.lightShaftConfig.m_active = v219;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGTerrainDeformConfig);
		    v222 = TypeInfo::HG::Rendering::Runtime::HGTerrainDeformConfig->static_fields;
		    v223 = *(_DWORD *)&v222->defaultConfig.m_active;
		    *(_QWORD *)&this->fields.terrainDeformConfig.deformGlobalStrength = *(_QWORD *)&v222->defaultConfig.deformGlobalStrength;
		    *(_DWORD *)&this->fields.terrainDeformConfig.m_active = v223;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGInkSimulationConfig);
		    v224 = TypeInfo::HG::Rendering::Runtime::HGInkSimulationConfig->static_fields;
		    v225 = *(_OWORD *)&v224->defaultConfig.inkRippleDensity;
		    v226 = *(_OWORD *)&v224->defaultConfig.inkDebugJacobi;
		    v227 = *(_OWORD *)&v224->defaultConfig.resolvedShaderParams.speedFactor;
		    v228 = *(_OWORD *)&v224->defaultConfig.resolvedShaderParams.forceAngleRandom;
		    v229 = *(_OWORD *)&v224->defaultConfig.resolvedShaderParams.landingInkSize;
		    v230 = *(_OWORD *)&v224->defaultConfig.resolvedShaderParams.viscosity;
		    *(_QWORD *)&v213 = *(_QWORD *)&v224->defaultConfig.resolvedShaderParams.idleForceChangeSpeed;
		    *(_OWORD *)&this->fields.inkSimulationConfig.influence = *(_OWORD *)&v224->defaultConfig.influence;
		    *(_OWORD *)&this->fields.inkSimulationConfig.inkRippleDensity = v225;
		    *(_OWORD *)&this->fields.inkSimulationConfig.inkDebugJacobi = v226;
		    *(_OWORD *)&this->fields.inkSimulationConfig.resolvedShaderParams.speedFactor = v227;
		    *(_OWORD *)&this->fields.inkSimulationConfig.resolvedShaderParams.forceAngleRandom = v228;
		    *(_OWORD *)&this->fields.inkSimulationConfig.resolvedShaderParams.landingInkSize = v229;
		    *(_OWORD *)&this->fields.inkSimulationConfig.resolvedShaderParams.viscosity = v230;
		    *(_QWORD *)&this->fields.inkSimulationConfig.resolvedShaderParams.idleForceChangeSpeed = v213;
		    sub_18002D1B0(
		      (SingleFieldAccessor *)&this->fields.inkSimulationConfig.shaderParams,
		      v231,
		      v232,
		      v233,
		      (MethodInfo *)v368);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRainConfig);
		    v234 = 2LL;
		    v235 = TypeInfo::HG::Rendering::Runtime::HGRainConfig->static_fields;
		    v236 = &v368;
		    do
		    {
		      v237 = *(_OWORD *)&v235->defaultConfig.color.g;
		      *v236 = *(_OWORD *)&v235->defaultConfig.enable;
		      v238 = *(_OWORD *)&v235->defaultConfig.horizontalRainAngle;
		      v236[1] = v237;
		      v239 = *(_OWORD *)&v235->defaultConfig.sceneEffectRainLightingPercent;
		      v236[2] = v238;
		      v240 = *(_OWORD *)&v235->defaultConfig.middleHorizontalRainAngle;
		      v236[3] = v239;
		      v241 = *(_OWORD *)&v235->defaultConfig.farRainAlphaMultiplier;
		      v236[4] = v240;
		      v242 = *(_OWORD *)&v235->defaultConfig.rainWaveHorizontalSpeed;
		      v236[5] = v241;
		      v243 = *(_OWORD *)&v235->defaultConfig.screenDropColor.g;
		      v235 = (HGRainConfig__StaticFields *)((char *)v235 + 128);
		      v236[6] = v242;
		      v236 += 8;
		      *(v236 - 1) = v243;
		      --v234;
		    }
		    while ( v234 );
		    v244 = 2LL;
		    v245 = *(_OWORD *)&v235->defaultConfig.color.g;
		    *v236 = *(_OWORD *)&v235->defaultConfig.enable;
		    v246 = *(_OWORD *)&v235->defaultConfig.horizontalRainAngle;
		    v247 = &v368;
		    v236[1] = v245;
		    v236[2] = v246;
		    p_rainConfig = &this->fields.rainConfig;
		    do
		    {
		      v249 = v247[1];
		      *(_OWORD *)&p_rainConfig->enable = *v247;
		      v250 = v247[2];
		      *(_OWORD *)&p_rainConfig->color.g = v249;
		      v251 = v247[3];
		      *(_OWORD *)&p_rainConfig->horizontalRainAngle = v250;
		      v252 = v247[4];
		      *(_OWORD *)&p_rainConfig->sceneEffectRainLightingPercent = v251;
		      v253 = v247[5];
		      *(_OWORD *)&p_rainConfig->middleHorizontalRainAngle = v252;
		      v254 = v247[6];
		      *(_OWORD *)&p_rainConfig->farRainAlphaMultiplier = v253;
		      v255 = v247[7];
		      v247 += 8;
		      *(_OWORD *)&p_rainConfig->rainWaveHorizontalSpeed = v254;
		      p_rainConfig = (HGRainConfig *)((char *)p_rainConfig + 128);
		      *(_OWORD *)&p_rainConfig[-1].farRainDirection.x = v255;
		      --v244;
		    }
		    while ( v244 );
		    v256 = v247[1];
		    *(_OWORD *)&p_rainConfig->enable = *v247;
		    v257 = v247[2];
		    *(_OWORD *)&p_rainConfig->color.g = v256;
		    *(_OWORD *)&p_rainConfig->horizontalRainAngle = v257;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGSnowConfig);
		    v258 = TypeInfo::HG::Rendering::Runtime::HGSnowConfig->static_fields;
		    color = v258->defaultConfig.color;
		    v260 = *(_OWORD *)&v258->defaultConfig.snowSizeRange.x;
		    v261 = *(_OWORD *)&v258->defaultConfig.snowTrailLength;
		    v262 = *(_OWORD *)&v258->defaultConfig.snowLightingPercent;
		    *(_QWORD *)&v257 = *(_QWORD *)&v258->defaultConfig.snowDirection.z;
		    *(_OWORD *)&this->fields.snowConfig.enable = *(_OWORD *)&v258->defaultConfig.enable;
		    this->fields.snowConfig.color = color;
		    *(_OWORD *)&this->fields.snowConfig.snowSizeRange.x = v260;
		    *(_OWORD *)&this->fields.snowConfig.snowTrailLength = v261;
		    *(_OWORD *)&this->fields.snowConfig.snowLightingPercent = v262;
		    *(_QWORD *)&this->fields.snowConfig.snowDirection.z = v257;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGStarConfig);
		    v263 = TypeInfo::HG::Rendering::Runtime::HGStarConfig->static_fields;
		    v264 = *(Color *)&v263->defaultConfig.minMaxRange.y;
		    v368 = *(_OWORD *)&v263->defaultConfig.enableStars;
		    v265 = *(_OWORD *)&v263->defaultConfig.starsTint.a;
		    v369 = v264;
		    v266 = *(Color *)&v263->defaultConfig.starsTint1.a;
		    v370 = v265;
		    v267 = *(_OWORD *)&v263->defaultConfig.brightnessRandomSeed;
		    v371 = v266;
		    v268 = *(_OWORD *)&v263->defaultConfig.skyBoxStarRangeMap;
		    v372 = v267;
		    v269 = *(Color *)&v263->defaultConfig.cloudRingStarCoverage;
		    v373 = v268;
		    v270 = *(_OWORD *)&v263->defaultConfig.nebulaMap;
		    v374 = v269;
		    v271 = *(_OWORD *)&v263->defaultConfig.nebulaTint.b;
		    v272 = *(_QWORD *)&v263->defaultConfig.m_active;
		    v375 = v270;
		    v376 = v271;
		    *(_QWORD *)&v377 = v272;
		    v273 = v369;
		    *(_OWORD *)&this->fields.starConfig.enableStars = v368;
		    v274 = v370;
		    *(Color *)&this->fields.starConfig.minMaxRange.y = v273;
		    v275 = v371;
		    *(_OWORD *)&this->fields.starConfig.starsTint.a = v274;
		    v276 = v372;
		    *(Color *)&this->fields.starConfig.starsTint1.a = v275;
		    v277 = v373;
		    *(_OWORD *)&this->fields.starConfig.brightnessRandomSeed = v276;
		    v278 = v374;
		    *(_OWORD *)&this->fields.starConfig.skyBoxStarRangeMap = v277;
		    v279 = v375;
		    *(Color *)&this->fields.starConfig.cloudRingStarCoverage = v278;
		    v280 = v376;
		    v281 = v377;
		    *(_OWORD *)&this->fields.starConfig.nebulaMap = v279;
		    *(_OWORD *)&this->fields.starConfig.nebulaTint.b = v280;
		    *(_QWORD *)&this->fields.starConfig.m_active = v281;
		    sub_18002D1B0(
		      (SingleFieldAccessor *)&this->fields.starConfig.skyBoxStarRangeMap,
		      v282,
		      v283,
		      v284,
		      (MethodInfo *)v368);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGLensFlareConfig);
		    v285 = TypeInfo::HG::Rendering::Runtime::HGLensFlareConfig->static_fields;
		    v286 = *(_OWORD *)&v285->defaultConfig.intensity;
		    v287 = *(_OWORD *)&v285->defaultConfig.sampleCount;
		    *(_OWORD *)&this->fields.lensFlareConfig.enable = *(_OWORD *)&v285->defaultConfig.enable;
		    *(_OWORD *)&this->fields.lensFlareConfig.intensity = v286;
		    *(_OWORD *)&this->fields.lensFlareConfig.sampleCount = v287;
		    sub_18002D1B0(
		      (SingleFieldAccessor *)&this->fields.lensFlareConfig.lensFlareData,
		      v288,
		      v289,
		      v290,
		      (MethodInfo *)v368);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
		    v293 = 2LL;
		    v294 = &v368;
		    p_defaultConfig = &TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig->static_fields->defaultConfig;
		    do
		    {
		      v296 = *(_OWORD *)&p_defaultConfig->colorLookupContribution;
		      *v294 = *(_OWORD *)&p_defaultConfig->tonemappingMode;
		      v297 = *(_OWORD *)&p_defaultConfig->colorAdjustmentsEnabled;
		      v294[1] = v296;
		      v298 = *(_OWORD *)&p_defaultConfig->colorAdjustmentsColorFilter.g;
		      v294[2] = v297;
		      v299 = *(_OWORD *)&p_defaultConfig->colorAdjustmentsSaturation;
		      v294[3] = v298;
		      v300 = *(_OWORD *)&p_defaultConfig->channelMixerRedOutBlueIn;
		      v294[4] = v299;
		      v301 = *(_OWORD *)&p_defaultConfig->channelMixerBlueOutRedIn;
		      v294[5] = v300;
		      shadows = p_defaultConfig->shadowsMidtonesHighlights.shadows;
		      p_defaultConfig = (HGColorGradingConfig *)((char *)p_defaultConfig + 128);
		      v294[6] = v301;
		      v294 += 8;
		      *(v294 - 1) = (__int128)shadows;
		      --v293;
		    }
		    while ( v293 );
		    v303 = *(_OWORD *)&p_defaultConfig->colorLookupContribution;
		    *v294 = *(_OWORD *)&p_defaultConfig->tonemappingMode;
		    v304 = *(_OWORD *)&p_defaultConfig->colorAdjustmentsEnabled;
		    v294[1] = v303;
		    v305 = *(_OWORD *)&p_defaultConfig->colorAdjustmentsColorFilter.g;
		    v294[2] = v304;
		    v306 = *(_OWORD *)&p_defaultConfig->colorAdjustmentsSaturation;
		    v294[3] = v305;
		    v307 = *(_OWORD *)&p_defaultConfig->channelMixerRedOutBlueIn;
		    v294[4] = v306;
		    v308 = *(_OWORD *)&p_defaultConfig->channelMixerBlueOutRedIn;
		    v309 = &v368;
		    v294[5] = v307;
		    v294[6] = v308;
		    p_colorGradingConfig = &this->fields.colorGradingConfig;
		    do
		    {
		      v311 = v309[1];
		      *(_OWORD *)&p_colorGradingConfig->tonemappingMode = *v309;
		      v312 = v309[2];
		      *(_OWORD *)&p_colorGradingConfig->colorLookupContribution = v311;
		      v313 = v309[3];
		      *(_OWORD *)&p_colorGradingConfig->colorAdjustmentsEnabled = v312;
		      v314 = v309[4];
		      *(_OWORD *)&p_colorGradingConfig->colorAdjustmentsColorFilter.g = v313;
		      v315 = v309[5];
		      *(_OWORD *)&p_colorGradingConfig->colorAdjustmentsSaturation = v314;
		      v316 = v309[6];
		      *(_OWORD *)&p_colorGradingConfig->channelMixerRedOutBlueIn = v315;
		      v317 = v309[7];
		      v309 += 8;
		      *(_OWORD *)&p_colorGradingConfig->channelMixerBlueOutRedIn = v316;
		      p_colorGradingConfig = (HGColorGradingConfig *)((char *)p_colorGradingConfig + 128);
		      *(_OWORD *)&p_colorGradingConfig[-1].colorCurves.masterOverriding = v317;
		      --v4;
		    }
		    while ( v4 );
		    v318 = v309[1];
		    *(_OWORD *)&p_colorGradingConfig->tonemappingMode = *v309;
		    v319 = v309[2];
		    *(_OWORD *)&p_colorGradingConfig->colorLookupContribution = v318;
		    v320 = v309[3];
		    *(_OWORD *)&p_colorGradingConfig->colorAdjustmentsEnabled = v319;
		    v321 = v309[4];
		    *(_OWORD *)&p_colorGradingConfig->colorAdjustmentsColorFilter.g = v320;
		    v322 = v309[5];
		    *(_OWORD *)&p_colorGradingConfig->colorAdjustmentsSaturation = v321;
		    v323 = v309[6];
		    *(_OWORD *)&p_colorGradingConfig->channelMixerRedOutBlueIn = v322;
		    *(_OWORD *)&p_colorGradingConfig->channelMixerBlueOutRedIn = v323;
		    sub_18002D1B0(
		      (SingleFieldAccessor *)&this->fields.colorGradingConfig.colorLookupTexture,
		      0LL,
		      v291,
		      v292,
		      (MethodInfo *)v368);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGAutoExposureConfig);
		    v324 = TypeInfo::HG::Rendering::Runtime::HGAutoExposureConfig->static_fields;
		    v325 = *(_DWORD *)&v324->defaultConfig.m_active;
		    v326 = *(_OWORD *)&v324->defaultConfig.autoExposureEv100Range.x;
		    v327 = *(_OWORD *)&v324->defaultConfig.autoExposureMeteringMode;
		    *(_QWORD *)&v323 = *(_QWORD *)&v324->defaultConfig.autoExposureEvClampRange.y;
		    *(_OWORD *)&this->fields.autoExposureConfig.autoExposureMode = *(_OWORD *)&v324->defaultConfig.autoExposureMode;
		    *(_OWORD *)&this->fields.autoExposureConfig.autoExposureEv100Range.x = v326;
		    *(_OWORD *)&this->fields.autoExposureConfig.autoExposureMeteringMode = v327;
		    *(_QWORD *)&this->fields.autoExposureConfig.autoExposureEvClampRange.y = v323;
		    *(_DWORD *)&this->fields.autoExposureConfig.m_active = v325;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowConfig);
		    v328 = TypeInfo::HG::Rendering::Runtime::HGShadowConfig->static_fields;
		    v329 = *(_OWORD *)&v328->defaultConfig.csmIntensity;
		    v330 = *(_OWORD *)&v328->defaultConfig.csmShadowSoftness;
		    v331 = *(_OWORD *)&v328->defaultConfig.contactShadowSurfaceThickness;
		    v332 = *(_OWORD *)&v328->defaultConfig.overrideCsmFarDistance;
		    v333 = *(_OWORD *)&v328->defaultConfig.overrideCsmSpherePosition.z;
		    v334 = *(_OWORD *)&v328->defaultConfig.csmSimulatedAttenuation;
		    v335 = *(_OWORD *)&v328->defaultConfig.rhodesShipCenter.z;
		    *(_OWORD *)&this->fields.shadowConfig.csmDepthBias = *(_OWORD *)&v328->defaultConfig.csmDepthBias;
		    *(_OWORD *)&this->fields.shadowConfig.csmIntensity = v329;
		    *(_OWORD *)&this->fields.shadowConfig.csmShadowSoftness = v330;
		    *(_OWORD *)&this->fields.shadowConfig.contactShadowSurfaceThickness = v331;
		    *(_OWORD *)&this->fields.shadowConfig.overrideCsmFarDistance = v332;
		    *(_OWORD *)&this->fields.shadowConfig.overrideCsmSpherePosition.z = v333;
		    *(_OWORD *)&this->fields.shadowConfig.csmSimulatedAttenuation = v334;
		    *(_OWORD *)&this->fields.shadowConfig.rhodesShipCenter.z = v335;
		    sub_18002D1B0(
		      (SingleFieldAccessor *)&this->fields.shadowConfig.csmRampTexture,
		      v336,
		      v337,
		      v338,
		      (MethodInfo *)v368);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGAnamorphicStreaksConfig);
		    v339 = TypeInfo::HG::Rendering::Runtime::HGAnamorphicStreaksConfig->static_fields;
		    v340 = v339->defaultConfig.bloomTint;
		    v341 = *(_OWORD *)&v339->defaultConfig.blurIntensity;
		    *(_OWORD *)&this->fields.anamorphicStreaksConfig.enable = *(_OWORD *)&v339->defaultConfig.enable;
		    this->fields.anamorphicStreaksConfig.bloomTint = v340;
		    *(_OWORD *)&this->fields.anamorphicStreaksConfig.blurIntensity = v341;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGWaterEnvConfig);
		    v342 = TypeInfo::HG::Rendering::Runtime::HGWaterEnvConfig->static_fields;
		    v343 = *(_DWORD *)&v342->defaultConfig.m_active;
		    *(_QWORD *)&this->fields.waterEnvConfig.enableWaterInteractionAdjust = *(_QWORD *)&v342->defaultConfig.enableWaterInteractionAdjust;
		    *(_DWORD *)&this->fields.waterEnvConfig.m_active = v343;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGInkWashConfig);
		    v344 = TypeInfo::HG::Rendering::Runtime::HGInkWashConfig->static_fields;
		    v345 = *(Color *)&v344->defaultConfig.baseConfig.baseMat;
		    v368 = *(_OWORD *)&v344->defaultConfig.enable;
		    v346 = *(_OWORD *)&v344->defaultConfig.baseConfig.verticalFadeAffectDist;
		    v369 = v345;
		    v370 = v346;
		    v347 = *(_OWORD *)&v344->defaultConfig.overlayConfig.verticalFadeAffectDist;
		    v371 = *(Color *)&v344->defaultConfig.overlayConfig.overlayMat;
		    v348 = *(_OWORD *)&v344->defaultConfig.maskConfig.addNewInkDrop;
		    v372 = v347;
		    v349 = *(Color *)&v344->defaultConfig.maskConfig.inkDropSize;
		    v373 = v348;
		    v350 = *(_OWORD *)&v344->defaultConfig.maskConfig.currInkPointPos.y;
		    v374 = v349;
		    v351 = *(_OWORD *)&v344->defaultConfig.maskConfig.currInkPointDir.z;
		    v375 = v350;
		    v352 = *(_OWORD *)&v344->defaultConfig.maskConfig.edgeFade;
		    v376 = v351;
		    v377 = v352;
		    v353 = v369;
		    *(_OWORD *)&this->fields.inkWashConfig.enable = v368;
		    v354 = v370;
		    *(Color *)&this->fields.inkWashConfig.baseConfig.baseMat = v353;
		    v355 = v371;
		    *(_OWORD *)&this->fields.inkWashConfig.baseConfig.verticalFadeAffectDist = v354;
		    v356 = v372;
		    *(Color *)&this->fields.inkWashConfig.overlayConfig.overlayMat = v355;
		    v357 = v373;
		    *(_OWORD *)&this->fields.inkWashConfig.overlayConfig.verticalFadeAffectDist = v356;
		    v358 = v374;
		    *(_OWORD *)&this->fields.inkWashConfig.maskConfig.addNewInkDrop = v357;
		    v359 = v375;
		    *(Color *)&this->fields.inkWashConfig.maskConfig.inkDropSize = v358;
		    v360 = v376;
		    *(_OWORD *)&this->fields.inkWashConfig.maskConfig.currInkPointPos.y = v359;
		    v361 = v377;
		    *(_OWORD *)&this->fields.inkWashConfig.maskConfig.currInkPointDir.z = v360;
		    *(_OWORD *)&this->fields.inkWashConfig.maskConfig.edgeFade = v361;
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields.inkWashConfig.baseConfig, v362, v363, v364, (MethodInfo *)v368);
		  }
		}
		
		public void CopyFrom(HGEnvironmentPhase src) {} // 0x00000001839BF590-0x00000001839C0F60
		// Void CopyFrom(HGEnvironmentPhase)
		void HG::Rendering::Runtime::HGEnvironmentPhase::CopyFrom(
		        HGEnvironmentPhase *this,
		        HGEnvironmentPhase *src,
		        MethodInfo *method)
		{
		  Int32__Array **v3; // r9
		  __int64 *static_fields; // rcx
		  int *wrapperArray; // rdx
		  HGLightConfig *p_lightConfig; // rbp
		  HGLightConfig *v9; // rsi
		  bool m_active; // al
		  __int64 v11; // r14
		  HGSkyConfig *p_skyConfig; // rsi
		  bool v13; // al
		  bool v14; // al
		  bool v15; // al
		  bool v16; // al
		  HGVolumetricFogConfig *p_volumetricFogConfig; // rsi
		  bool v18; // al
		  bool v19; // al
		  bool v20; // al
		  HGCelestialConfig *p_celestialConfig; // rsi
		  bool v22; // al
		  bool v23; // al
		  bool v24; // al
		  bool v25; // al
		  bool v26; // al
		  HGRainConfig *p_rainConfig; // rbp
		  HGRainConfig *v28; // rsi
		  bool v29; // al
		  bool v30; // al
		  bool v31; // al
		  bool v32; // al
		  HGColorGradingConfig *p_colorGradingConfig; // rsi
		  bool v34; // al
		  bool v35; // al
		  bool v36; // al
		  bool v37; // al
		  bool v38; // al
		  HGInkWashConfig *p_inkWashConfig; // rdi
		  HGInkWashConfig *v40; // rbx
		  bool v41; // al
		  __int128 *v42; // rax
		  __int64 v43; // rcx
		  __int128 v44; // xmm0
		  __int128 v45; // xmm1
		  __int128 v46; // xmm0
		  __int128 v47; // xmm1
		  __int128 v48; // xmm0
		  __int128 v49; // xmm1
		  __int128 v50; // xmm0
		  __int128 v51; // xmm1
		  __int128 *v52; // rcx
		  __int128 v53; // xmm1
		  __int128 v54; // xmm0
		  __int128 v55; // xmm1
		  __int128 v56; // xmm0
		  __int128 v57; // xmm1
		  __int128 v58; // xmm0
		  HGColorGradingConfig *v59; // rax
		  __int128 v60; // xmm0
		  __int128 v61; // xmm1
		  __int128 v62; // xmm0
		  __int128 v63; // xmm1
		  __int128 v64; // xmm0
		  __int128 v65; // xmm1
		  __int128 v66; // xmm0
		  __int128 v67; // xmm1
		  __int128 v68; // xmm1
		  __int128 v69; // xmm0
		  __int128 v70; // xmm1
		  __int128 v71; // xmm0
		  __int128 v72; // xmm1
		  __int128 v73; // xmm0
		  int v74; // eax
		  __int128 v75; // xmm2
		  __int128 v76; // xmm3
		  __int64 v77; // xmm0_8
		  Color *v78; // rcx
		  __int64 v79; // rax
		  Color directColor; // xmm0
		  Color v81; // xmm1
		  Color v82; // xmm0
		  Color v83; // xmm1
		  Color v84; // xmm0
		  Color v85; // xmm1
		  Color v86; // xmm0
		  Color v87; // xmm1
		  int32_t sunDiscPitchYawMode; // eax
		  Color v89; // xmm1
		  Color v90; // xmm0
		  Color v91; // xmm1
		  Color v92; // xmm0
		  Color v93; // xmm1
		  Color v94; // xmm0
		  Color *v95; // rax
		  __int64 v96; // rcx
		  Color v97; // xmm0
		  Color v98; // xmm1
		  Color v99; // xmm0
		  Color v100; // xmm1
		  Color v101; // xmm0
		  Color v102; // xmm1
		  Color v103; // xmm0
		  Color v104; // xmm1
		  Color v105; // xmm1
		  Color v106; // xmm0
		  Color v107; // xmm1
		  Color v108; // xmm0
		  Color v109; // xmm1
		  Color v110; // xmm0
		  int32_t r_low; // eax
		  __int128 *v112; // rcx
		  __int64 v113; // rax
		  __int128 v114; // xmm0
		  __int128 v115; // xmm1
		  __int128 v116; // xmm0
		  __int128 v117; // xmm1
		  __int128 v118; // xmm0
		  __int128 v119; // xmm1
		  __int128 v120; // xmm0
		  __int128 v121; // xmm1
		  __int64 v122; // rax
		  HGSkyConfig *v123; // rdx
		  __int128 v124; // xmm1
		  __int128 v125; // xmm0
		  __int128 v126; // xmm1
		  __int128 v127; // xmm0
		  __int128 *v128; // rax
		  __int64 v129; // rcx
		  __int128 v130; // xmm0
		  __int128 v131; // xmm1
		  __int128 v132; // xmm0
		  __int128 v133; // xmm1
		  __int128 v134; // xmm0
		  __int128 v135; // xmm1
		  __int128 v136; // xmm0
		  __int128 v137; // xmm1
		  __int128 v138; // xmm1
		  __int128 v139; // xmm0
		  __int128 v140; // xmm1
		  __int128 v141; // xmm0
		  __int64 v142; // rax
		  __int128 v143; // xmm2
		  __int128 v144; // xmm3
		  Color rayleighScattering; // xmm4
		  __int128 v146; // xmm5
		  __int128 v147; // xmm6
		  __int128 v148; // xmm7
		  __int128 v149; // xmm8
		  __int128 v150; // xmm9
		  __int64 v151; // xmm0_8
		  int v152; // eax
		  __int128 v153; // xmm1
		  __int128 v154; // xmm2
		  __int128 v155; // xmm3
		  Color inscatterAmbientColor; // xmm4
		  Color v157; // xmm1
		  __int128 v158; // xmm0
		  __int128 v159; // xmm1
		  __int128 v160; // xmm0
		  __int128 v161; // xmm1
		  Color heightFogDirectionalInscatteringMobile; // xmm0
		  __int128 v163; // xmm1
		  __int64 v164; // rax
		  __int128 v165; // xmm1
		  __int128 v166; // xmm0
		  __int128 v167; // xmm1
		  __int128 v168; // xmm0
		  Color v169; // xmm1
		  __int128 v170; // xmm0
		  __int128 v171; // xmm1
		  __int128 v172; // xmm0
		  __int128 v173; // xmm1
		  Color v174; // xmm0
		  __int128 v175; // xmm1
		  __int128 v176; // xmm0
		  __int128 v177; // xmm1
		  __int128 v178; // xmm0
		  __int128 v179; // xmm1
		  __int128 v180; // xmm0
		  __int128 *v181; // rax
		  __int64 v182; // rcx
		  __int128 v183; // xmm0
		  __int128 v184; // xmm1
		  __int128 v185; // xmm0
		  __int128 v186; // xmm1
		  __int128 v187; // xmm0
		  __int128 v188; // xmm1
		  __int128 v189; // xmm0
		  __int128 v190; // xmm1
		  __int128 *v191; // rcx
		  __int64 v192; // rdx
		  __int128 v193; // xmm1
		  __int128 v194; // xmm0
		  __int128 v195; // xmm1
		  __int128 v196; // xmm0
		  __int128 v197; // xmm1
		  __int128 v198; // xmm0
		  HGVolumetricFogConfig *v199; // rax
		  __int128 v200; // xmm0
		  __int128 v201; // xmm1
		  __int128 v202; // xmm0
		  __int128 v203; // xmm1
		  __int128 v204; // xmm0
		  __int128 v205; // xmm1
		  __int128 v206; // xmm0
		  __int128 v207; // xmm1
		  __int128 v208; // xmm1
		  __int128 v209; // xmm0
		  __int128 v210; // xmm1
		  __int128 v211; // xmm0
		  __int128 v212; // xmm1
		  __int128 v213; // xmm0
		  Color cloudTint; // xmm1
		  __int128 v215; // xmm0
		  __int128 v216; // xmm1
		  __int128 v217; // xmm0
		  __int128 v218; // xmm1
		  Color v219; // xmm0
		  __int128 v220; // xmm1
		  __int128 v221; // xmm0
		  __int128 v222; // xmm1
		  __int128 v223; // xmm0
		  Color v224; // xmm1
		  __int128 v225; // xmm0
		  __int128 v226; // xmm1
		  __int128 v227; // xmm0
		  __int128 v228; // xmm1
		  Color v229; // xmm0
		  __int128 v230; // xmm1
		  __int128 v231; // xmm0
		  __int128 v232; // xmm1
		  __int128 v233; // xmm0
		  __int128 *v234; // rcx
		  __int64 v235; // rax
		  __int128 v236; // xmm0
		  __int128 v237; // xmm1
		  __int128 v238; // xmm0
		  __int128 v239; // xmm1
		  __int128 v240; // xmm0
		  __int128 v241; // xmm1
		  __int128 v242; // xmm0
		  __int128 v243; // xmm1
		  Material *drawMaterial; // rax
		  __int64 v245; // rdx
		  __int128 v246; // xmm1
		  __int128 v247; // xmm0
		  __int128 v248; // xmm1
		  __int128 v249; // xmm0
		  __int128 v250; // xmm1
		  HGCelestialConfig *v251; // rcx
		  __int128 *v252; // rax
		  __int128 v253; // xmm0
		  __int128 v254; // xmm1
		  __int128 v255; // xmm0
		  __int128 v256; // xmm1
		  __int128 v257; // xmm0
		  __int128 v258; // xmm1
		  __int128 v259; // xmm0
		  __int128 v260; // xmm1
		  __int128 v261; // xmm1
		  __int128 v262; // xmm0
		  __int128 v263; // xmm1
		  __int128 v264; // xmm0
		  __int128 v265; // xmm1
		  Material *v266; // rax
		  int v267; // eax
		  __int64 v268; // xmm0_8
		  int v269; // eax
		  Color bloomTint; // xmm1
		  __int128 v271; // xmm2
		  __int128 *v272; // rax
		  __int64 v273; // rcx
		  __int128 v274; // xmm0
		  __int128 v275; // xmm1
		  __int128 v276; // xmm0
		  __int128 v277; // xmm1
		  __int128 v278; // xmm0
		  __int128 v279; // xmm1
		  __int128 v280; // xmm0
		  __int128 v281; // xmm1
		  __int64 v282; // rcx
		  __int128 v283; // xmm1
		  __int128 v284; // xmm0
		  __int128 *v285; // rax
		  __int128 v286; // xmm0
		  __int128 v287; // xmm1
		  __int128 v288; // xmm0
		  __int128 v289; // xmm1
		  __int128 v290; // xmm0
		  __int128 v291; // xmm1
		  __int128 v292; // xmm0
		  __int128 v293; // xmm1
		  __int128 v294; // xmm1
		  __int128 v295; // xmm0
		  __int128 v296; // xmm1
		  __int128 v297; // xmm2
		  int v298; // eax
		  __int128 v299; // xmm1
		  __int128 v300; // xmm2
		  __int128 v301; // xmm3
		  __int128 v302; // xmm4
		  __int128 v303; // xmm5
		  __int128 v304; // xmm6
		  __int128 v305; // xmm7
		  __int128 v306; // xmm2
		  __int128 v307; // xmm3
		  __int128 v308; // xmm4
		  __int128 v309; // xmm5
		  __int128 v310; // xmm6
		  __int128 v311; // xmm7
		  __int128 v312; // xmm8
		  __int128 v313; // xmm9
		  __int64 v314; // xmm0_8
		  __int64 v315; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v317; // rax
		  ILFixDynamicMethodWrapper_2 *v318; // rax
		  __int64 v319; // rax
		  ILFixDynamicMethodWrapper_2 *v320; // rax
		  __int64 v321; // rax
		  ILFixDynamicMethodWrapper_2 *v322; // rax
		  __int64 v323; // rax
		  ILFixDynamicMethodWrapper_2 *v324; // rax
		  __int64 v325; // rax
		  ILFixDynamicMethodWrapper_2 *v326; // rax
		  __int64 v327; // rax
		  ILFixDynamicMethodWrapper_2 *v328; // rax
		  __int64 v329; // rax
		  ILFixDynamicMethodWrapper_2 *v330; // rax
		  bool v331; // cl
		  __int64 v332; // rax
		  ILFixDynamicMethodWrapper_2 *v333; // rax
		  __int64 v334; // rax
		  ILFixDynamicMethodWrapper_2 *v335; // rax
		  __int64 v336; // rax
		  ILFixDynamicMethodWrapper_2 *v337; // rax
		  __int64 v338; // rax
		  ILFixDynamicMethodWrapper_2 *v339; // rax
		  __int64 v340; // rax
		  ILFixDynamicMethodWrapper_2 *v341; // rax
		  __int64 v342; // rax
		  ILFixDynamicMethodWrapper_2 *v343; // rax
		  __int128 v344; // xmm2
		  __int128 v345; // xmm3
		  __int128 v346; // xmm4
		  __int128 v347; // xmm5
		  __int128 v348; // xmm6
		  __int128 v349; // xmm7
		  __int64 v350; // xmm0_8
		  __int64 v351; // rax
		  ILFixDynamicMethodWrapper_2 *v352; // rax
		  __int64 v353; // rax
		  ILFixDynamicMethodWrapper_2 *v354; // rax
		  Color color; // xmm2
		  __int128 v356; // xmm3
		  __int128 v357; // xmm4
		  __int128 v358; // xmm5
		  __int64 v359; // xmm0_8
		  __int64 v360; // rax
		  ILFixDynamicMethodWrapper_2 *v361; // rax
		  __int64 v362; // rax
		  ILFixDynamicMethodWrapper_2 *v363; // rax
		  __int64 v364; // rax
		  ILFixDynamicMethodWrapper_2 *v365; // rax
		  __int64 v366; // rax
		  ILFixDynamicMethodWrapper_2 *v367; // rax
		  __int64 v368; // rax
		  ILFixDynamicMethodWrapper_2 *v369; // rax
		  __int64 v370; // rax
		  ILFixDynamicMethodWrapper_2 *v371; // rax
		  Color v372; // xmm1
		  __int128 v373; // xmm2
		  __int64 v374; // rax
		  ILFixDynamicMethodWrapper_2 *v375; // rax
		  int v376; // eax
		  __int64 v377; // rax
		  ILFixDynamicMethodWrapper_2 *v378; // rax
		  Color v379; // xmm1
		  __int128 v380; // xmm0
		  __int128 v381; // xmm1
		  __int128 v382; // xmm0
		  __int128 v383; // xmm1
		  Color v384; // xmm0
		  __int128 v385; // xmm1
		  __int128 v386; // xmm0
		  __int128 v387; // xmm1
		  Color v388; // xmm1
		  __int128 v389; // xmm0
		  __int128 v390; // xmm1
		  __int128 v391; // xmm0
		  __int128 v392; // xmm1
		  Color v393; // xmm0
		  __int128 v394; // xmm1
		  __int128 v395; // xmm0
		  __int128 v396; // xmm1
		  __int128 v397; // [rsp+20h] [rbp-1C8h] BYREF
		  Color v398; // [rsp+30h] [rbp-1B8h]
		  __int128 v399; // [rsp+40h] [rbp-1A8h]
		  __int128 v400; // [rsp+50h] [rbp-198h]
		  __int128 v401; // [rsp+60h] [rbp-188h]
		  __int128 v402; // [rsp+70h] [rbp-178h]
		  Color v403; // [rsp+80h] [rbp-168h]
		  __int128 v404; // [rsp+90h] [rbp-158h]
		  __int128 v405; // [rsp+A0h] [rbp-148h]
		  __int128 v406; // [rsp+B0h] [rbp-138h]
		  __int128 v407; // [rsp+C0h] [rbp-128h]
		  __int128 v408; // [rsp+D0h] [rbp-118h]
		  __int128 v409; // [rsp+E0h] [rbp-108h]
		  __int64 v410; // [rsp+F0h] [rbp-F8h]
		  int v411; // [rsp+F8h] [rbp-F0h]
		
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  static_fields = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_284;
		  if ( wrapperArray[6] > 633 )
		  {
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		    v315 = *(_QWORD *)wrapperArray;
		    if ( !*(_QWORD *)wrapperArray )
		      goto LABEL_284;
		    if ( *(_DWORD *)(v315 + 24) <= 0x279u )
		      goto LABEL_453;
		    if ( *(_QWORD *)(v315 + 5096) )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(633, 0LL);
		      if ( Patch )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		          (ILFixDynamicMethodWrapper_39 *)Patch,
		          (Object *)this,
		          (Object *)src,
		          0LL);
		        return;
		      }
		      goto LABEL_284;
		    }
		  }
		  p_lightConfig = &this->fields.lightConfig;
		  if ( !src )
		    goto LABEL_284;
		  v9 = &src->fields.lightConfig;
		  if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGLightConfig>->rgctx_data )
		    sub_1800430B0(MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGLightConfig>);
		  if ( !TypeInfo::HG::Rendering::Runtime::HGLightConfig->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGLightConfig);
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  static_fields = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_284;
		  if ( wrapperArray[6] <= 1385 )
		    goto LABEL_14;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		  v317 = *(_QWORD *)wrapperArray;
		  if ( !*(_QWORD *)wrapperArray )
		    goto LABEL_284;
		  if ( *(_DWORD *)(v317 + 24) <= 0x569u )
		    goto LABEL_453;
		  if ( *(_QWORD *)(v317 + 11112) )
		  {
		    v318 = IFix::WrappersManagerImpl::GetPatch(1385, 0LL);
		    if ( !v318 )
		      goto LABEL_284;
		    m_active = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_559(v318, &src->fields.lightConfig, 0LL);
		  }
		  else
		  {
		LABEL_14:
		    m_active = src->fields.lightConfig.m_active;
		  }
		  v11 = 2LL;
		  if ( m_active )
		  {
		    v78 = (Color *)&v397;
		    v79 = 2LL;
		    do
		    {
		      v78 += 8;
		      directColor = v9->directColor;
		      v81 = *(Color *)&v9->directColorMode;
		      v9 = (HGLightConfig *)((char *)v9 + 128);
		      v78[-8] = directColor;
		      v82 = *(Color *)&v9[-1].rotationAtmosphere.y;
		      v78[-7] = v81;
		      v83 = *(Color *)&v9[-1].rotationLightShaft.y;
		      v78[-6] = v82;
		      v84 = *(Color *)&v9[-1].rotationSunDisc.y;
		      v78[-5] = v83;
		      v85 = *(Color *)&v9[-1].rotationLensFlare.y;
		      v78[-4] = v84;
		      v86 = *(Color *)&v9[-1].rotationCloudShadow.y;
		      v78[-3] = v85;
		      v87 = *(Color *)&v9[-1].rotationHeightFogDirectionalInscattering.y;
		      v78[-2] = v86;
		      v78[-1] = v87;
		      --v79;
		    }
		    while ( v79 );
		    sunDiscPitchYawMode = v9->sunDiscPitchYawMode;
		    v89 = *(Color *)&v9->directColorMode;
		    *v78 = v9->directColor;
		    v90 = *(Color *)&v9->directCustomColor.a;
		    v78[1] = v89;
		    v91 = *(Color *)&v9->directSpecularIntensity;
		    v78[2] = v90;
		    v92 = *(Color *)&v9->directPitchYaw.y;
		    v78[3] = v91;
		    v93 = *(Color *)&v9->indirectSpecularFactor;
		    v78[4] = v92;
		    v94 = *(Color *)&v9->atmospherePitchYaw.y;
		    v78[5] = v93;
		    v78[6] = v94;
		    LODWORD(v78[7].r) = sunDiscPitchYawMode;
		    v95 = (Color *)&v397;
		    v96 = 2LL;
		    do
		    {
		      p_lightConfig = (HGLightConfig *)((char *)p_lightConfig + 128);
		      v97 = *v95;
		      v98 = v95[1];
		      v95 += 8;
		      *(Color *)&p_lightConfig[-1].localToWorld.m12 = v97;
		      v99 = v95[-6];
		      *(Color *)&p_lightConfig[-1].localToWorld.m13 = v98;
		      v100 = v95[-5];
		      *(Color *)&p_lightConfig[-1].rotationAtmosphere.y = v99;
		      v101 = v95[-4];
		      *(Color *)&p_lightConfig[-1].rotationLightShaft.y = v100;
		      v102 = v95[-3];
		      *(Color *)&p_lightConfig[-1].rotationSunDisc.y = v101;
		      v103 = v95[-2];
		      *(Color *)&p_lightConfig[-1].rotationLensFlare.y = v102;
		      v104 = v95[-1];
		      *(Color *)&p_lightConfig[-1].rotationCloudShadow.y = v103;
		      *(Color *)&p_lightConfig[-1].rotationHeightFogDirectionalInscattering.y = v104;
		      --v96;
		    }
		    while ( v96 );
		    v105 = v95[1];
		    p_lightConfig->directColor = *v95;
		    v106 = v95[2];
		    *(Color *)&p_lightConfig->directColorMode = v105;
		    v107 = v95[3];
		    *(Color *)&p_lightConfig->directCustomColor.a = v106;
		    v108 = v95[4];
		    *(Color *)&p_lightConfig->directSpecularIntensity = v107;
		    v109 = v95[5];
		    *(Color *)&p_lightConfig->directPitchYaw.y = v108;
		    v110 = v95[6];
		    r_low = LODWORD(v95[7].r);
		    *(Color *)&p_lightConfig->indirectSpecularFactor = v109;
		    *(Color *)&p_lightConfig->atmospherePitchYaw.y = v110;
		    p_lightConfig->sunDiscPitchYawMode = r_low;
		  }
		  p_skyConfig = &src->fields.skyConfig;
		  if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGSkyConfig>->rgctx_data )
		    sub_1800430B0(MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGSkyConfig>);
		  if ( !TypeInfo::HG::Rendering::Runtime::HGSkyConfig->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGSkyConfig);
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  static_fields = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_284;
		  if ( wrapperArray[6] <= 1090 )
		    goto LABEL_24;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		  v319 = *(_QWORD *)wrapperArray;
		  if ( !*(_QWORD *)wrapperArray )
		    goto LABEL_284;
		  if ( *(_DWORD *)(v319 + 24) <= 0x442u )
		    goto LABEL_453;
		  if ( *(_QWORD *)(v319 + 8752) )
		  {
		    v320 = IFix::WrappersManagerImpl::GetPatch(1090, 0LL);
		    if ( !v320 )
		      goto LABEL_284;
		    v13 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_420(v320, &src->fields.skyConfig, 0LL);
		  }
		  else
		  {
		LABEL_24:
		    v13 = src->fields.skyConfig.m_active;
		  }
		  if ( v13 )
		  {
		    v112 = &v397;
		    v113 = 2LL;
		    do
		    {
		      v112 += 8;
		      v114 = *(_OWORD *)&p_skyConfig->parentEnvPhaseGuid;
		      v115 = *(_OWORD *)&p_skyConfig->skyDirectIntensity;
		      p_skyConfig = (HGSkyConfig *)((char *)p_skyConfig + 128);
		      *(v112 - 8) = v114;
		      v116 = *(_OWORD *)&p_skyConfig[-1].skyAmbientSH.shr7;
		      *(v112 - 7) = v115;
		      v117 = *(_OWORD *)&p_skyConfig[-1].skyAmbientSH.shg2;
		      *(v112 - 6) = v116;
		      v118 = *(_OWORD *)&p_skyConfig[-1].skyAmbientSH.shg6;
		      *(v112 - 5) = v117;
		      v119 = *(_OWORD *)&p_skyConfig[-1].skyAmbientSH.shb1;
		      *(v112 - 4) = v118;
		      v120 = *(_OWORD *)&p_skyConfig[-1].skyAmbientSH.shb5;
		      *(v112 - 3) = v119;
		      v121 = *(_OWORD *)&p_skyConfig[-1].skyboxCubeMap;
		      *(v112 - 2) = v120;
		      *(v112 - 1) = v121;
		      --v113;
		    }
		    while ( v113 );
		    v122 = *(_QWORD *)&p_skyConfig->customIVDefaultSH.shg5;
		    v123 = &this->fields.skyConfig;
		    v124 = *(_OWORD *)&p_skyConfig->skyDirectIntensity;
		    *v112 = *(_OWORD *)&p_skyConfig->parentEnvPhaseGuid;
		    v125 = *(_OWORD *)&p_skyConfig->customIVDefaultSH.shr2;
		    v112[1] = v124;
		    v126 = *(_OWORD *)&p_skyConfig->customIVDefaultSH.shr6;
		    v112[2] = v125;
		    v127 = *(_OWORD *)&p_skyConfig->customIVDefaultSH.shg1;
		    v112[3] = v126;
		    v112[4] = v127;
		    *((_QWORD *)v112 + 10) = v122;
		    v128 = &v397;
		    v129 = 2LL;
		    do
		    {
		      v123 = (HGSkyConfig *)((char *)v123 + 128);
		      v130 = *v128;
		      v131 = v128[1];
		      v128 += 8;
		      *(_OWORD *)&v123[-1].culloff = v130;
		      v132 = *(v128 - 6);
		      *(_OWORD *)&v123[-1].skyAmbientSH.shr3 = v131;
		      v133 = *(v128 - 5);
		      *(_OWORD *)&v123[-1].skyAmbientSH.shr7 = v132;
		      v134 = *(v128 - 4);
		      *(_OWORD *)&v123[-1].skyAmbientSH.shg2 = v133;
		      v135 = *(v128 - 3);
		      *(_OWORD *)&v123[-1].skyAmbientSH.shg6 = v134;
		      v136 = *(v128 - 2);
		      *(_OWORD *)&v123[-1].skyAmbientSH.shb1 = v135;
		      v137 = *(v128 - 1);
		      *(_OWORD *)&v123[-1].skyAmbientSH.shb5 = v136;
		      *(_OWORD *)&v123[-1].skyboxCubeMap = v137;
		      --v129;
		    }
		    while ( v129 );
		    v138 = v128[1];
		    *(_OWORD *)&v123->parentEnvPhaseGuid = *v128;
		    v139 = v128[2];
		    *(_OWORD *)&v123->skyDirectIntensity = v138;
		    v140 = v128[3];
		    *(_OWORD *)&v123->customIVDefaultSH.shr2 = v139;
		    v141 = v128[4];
		    v142 = *((_QWORD *)v128 + 10);
		    *(_OWORD *)&v123->customIVDefaultSH.shr6 = v140;
		    *(_OWORD *)&v123->customIVDefaultSH.shg1 = v141;
		    *(_QWORD *)&v123->customIVDefaultSH.shg5 = v142;
		    sub_18002D1B0(
		      (SingleFieldAccessor *)&this->fields.skyConfig,
		      (Type *)v123,
		      (PropertyInfo_1 *)method,
		      v3,
		      (MethodInfo *)v397);
		  }
		  if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGAtmosphereConfig>->rgctx_data )
		    sub_1800430B0(MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGAtmosphereConfig>);
		  if ( !TypeInfo::HG::Rendering::Runtime::HGAtmosphereConfig->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGAtmosphereConfig);
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  static_fields = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_284;
		  if ( wrapperArray[6] <= 1323 )
		    goto LABEL_34;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		  v321 = *(_QWORD *)wrapperArray;
		  if ( !*(_QWORD *)wrapperArray )
		    goto LABEL_284;
		  if ( *(_DWORD *)(v321 + 24) <= 0x52Bu )
		    goto LABEL_453;
		  if ( *(_QWORD *)(v321 + 10616) )
		  {
		    v322 = IFix::WrappersManagerImpl::GetPatch(1323, 0LL);
		    if ( !v322 )
		      goto LABEL_284;
		    v14 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_511(v322, &src->fields.atmosphereConfig, 0LL);
		  }
		  else
		  {
		LABEL_34:
		    v14 = src->fields.atmosphereConfig.m_active;
		  }
		  if ( v14 )
		  {
		    v143 = *(_OWORD *)&src->fields.atmosphereConfig.groundAlbedo.a;
		    v144 = *(_OWORD *)&src->fields.atmosphereConfig.outerSunIrradianceColor.a;
		    rayleighScattering = src->fields.atmosphereConfig.rayleighScattering;
		    v146 = *(_OWORD *)&src->fields.atmosphereConfig.rayleighExponentialDistribution;
		    v147 = *(_OWORD *)&src->fields.atmosphereConfig.mieScattering.b;
		    v148 = *(_OWORD *)&src->fields.atmosphereConfig.mieAbsorption.g;
		    v149 = *(_OWORD *)&src->fields.atmosphereConfig.mieExponentialDistribution;
		    v150 = *(_OWORD *)&src->fields.atmosphereConfig.ozoneAbsorption.b;
		    v151 = *(_QWORD *)&src->fields.atmosphereConfig.tentWidth;
		    *(_OWORD *)&this->fields.atmosphereConfig.groundRadius = *(_OWORD *)&src->fields.atmosphereConfig.groundRadius;
		    *(_OWORD *)&this->fields.atmosphereConfig.groundAlbedo.a = v143;
		    *(_OWORD *)&this->fields.atmosphereConfig.outerSunIrradianceColor.a = v144;
		    this->fields.atmosphereConfig.rayleighScattering = rayleighScattering;
		    *(_OWORD *)&this->fields.atmosphereConfig.rayleighExponentialDistribution = v146;
		    *(_OWORD *)&this->fields.atmosphereConfig.mieScattering.b = v147;
		    *(_OWORD *)&this->fields.atmosphereConfig.mieAbsorption.g = v148;
		    *(_OWORD *)&this->fields.atmosphereConfig.mieExponentialDistribution = v149;
		    *(_OWORD *)&this->fields.atmosphereConfig.ozoneAbsorption.b = v150;
		    *(_QWORD *)&this->fields.atmosphereConfig.tentWidth = v151;
		  }
		  if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGFogConfig>->rgctx_data )
		    sub_1800430B0(MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGFogConfig>);
		  if ( !TypeInfo::HG::Rendering::Runtime::HGFogConfig->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGFogConfig);
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  static_fields = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_284;
		  if ( wrapperArray[6] <= 1364 )
		    goto LABEL_45;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		  v323 = *(_QWORD *)wrapperArray;
		  if ( !*(_QWORD *)wrapperArray )
		    goto LABEL_284;
		  if ( *(_DWORD *)(v323 + 24) <= 0x554u )
		    goto LABEL_453;
		  if ( *(_QWORD *)(v323 + 10944) )
		  {
		    v324 = IFix::WrappersManagerImpl::GetPatch(1364, 0LL);
		    if ( !v324 )
		      goto LABEL_284;
		    v15 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_540(v324, &src->fields.fogConfig, 0LL);
		  }
		  else
		  {
		LABEL_45:
		    v15 = src->fields.fogConfig.m_active;
		  }
		  if ( v15 )
		  {
		    v152 = *(_DWORD *)&src->fields.fogConfig.m_active;
		    v153 = *(_OWORD *)&src->fields.fogConfig.fallOffDistance;
		    v154 = *(_OWORD *)&src->fields.fogConfig.mieScattering.a;
		    v155 = *(_OWORD *)&src->fields.fogConfig.rayleighScattering.g;
		    inscatterAmbientColor = src->fields.fogConfig.inscatterAmbientColor;
		    *(_OWORD *)&this->fields.fogConfig.enable = *(_OWORD *)&src->fields.fogConfig.enable;
		    *(_OWORD *)&this->fields.fogConfig.fallOffDistance = v153;
		    *(_OWORD *)&this->fields.fogConfig.mieScattering.a = v154;
		    *(_OWORD *)&this->fields.fogConfig.rayleighScattering.g = v155;
		    this->fields.fogConfig.inscatterAmbientColor = inscatterAmbientColor;
		    *(_DWORD *)&this->fields.fogConfig.m_active = v152;
		  }
		  if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGHeightFogConfig>->rgctx_data )
		    sub_1800430B0(MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGHeightFogConfig>);
		  if ( !TypeInfo::HG::Rendering::Runtime::HGHeightFogConfig->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGHeightFogConfig);
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  static_fields = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_284;
		  if ( wrapperArray[6] <= 1366 )
		    goto LABEL_56;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		  v325 = *(_QWORD *)wrapperArray;
		  if ( !*(_QWORD *)wrapperArray )
		    goto LABEL_284;
		  if ( *(_DWORD *)(v325 + 24) <= 0x556u )
		    goto LABEL_453;
		  if ( *(_QWORD *)(v325 + 10960) )
		  {
		    v326 = IFix::WrappersManagerImpl::GetPatch(1366, 0LL);
		    if ( !v326 )
		      goto LABEL_284;
		    v16 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_422(v326, &src->fields.heightFogConfig, 0LL);
		  }
		  else
		  {
		LABEL_56:
		    v16 = src->fields.heightFogConfig.m_active;
		  }
		  if ( v16 )
		  {
		    v157 = *(Color *)&src->fields.heightFogConfig.heightFogStartHeightSecond;
		    v397 = *(_OWORD *)&src->fields.heightFogConfig.enable;
		    v158 = *(_OWORD *)&src->fields.heightFogConfig.heightFogInscatter.g;
		    v398 = v157;
		    v159 = *(_OWORD *)&src->fields.heightFogConfig.heightFogStartDistance;
		    v399 = v158;
		    v160 = *(_OWORD *)&src->fields.heightFogConfig.heightFogCullingFarClipPlane;
		    v400 = v159;
		    v161 = *(_OWORD *)&src->fields.heightFogConfig.heightFogDirectionalInscattering.g;
		    v401 = v160;
		    heightFogDirectionalInscatteringMobile = src->fields.heightFogConfig.heightFogDirectionalInscatteringMobile;
		    v402 = v161;
		    v163 = *(_OWORD *)&src->fields.heightFogConfig.enableVolumetricFog;
		    v403 = heightFogDirectionalInscatteringMobile;
		    v404 = v163;
		    v164 = *(_QWORD *)&src->fields.heightFogConfig.flowNoiseDir.z;
		    v165 = *(_OWORD *)&src->fields.heightFogConfig.volumetricFogEmissive.b;
		    v405 = *(_OWORD *)&src->fields.heightFogConfig.volumetricFogAlbedo.b;
		    v166 = *(_OWORD *)&src->fields.heightFogConfig.volumetricFogStartDistance;
		    v406 = v165;
		    v167 = *(_OWORD *)&src->fields.heightFogConfig.enableFlowNoise;
		    v407 = v166;
		    v168 = *(_OWORD *)&src->fields.heightFogConfig.flowNoiseHorizontalDirAngle;
		    v408 = v167;
		    v409 = v168;
		    v410 = v164;
		    v411 = *(_DWORD *)&src->fields.heightFogConfig.m_active;
		    v169 = v398;
		    *(_OWORD *)&this->fields.heightFogConfig.enable = v397;
		    v170 = v399;
		    *(Color *)&this->fields.heightFogConfig.heightFogStartHeightSecond = v169;
		    v171 = v400;
		    *(_OWORD *)&this->fields.heightFogConfig.heightFogInscatter.g = v170;
		    v172 = v401;
		    *(_OWORD *)&this->fields.heightFogConfig.heightFogStartDistance = v171;
		    v173 = v402;
		    *(_OWORD *)&this->fields.heightFogConfig.heightFogCullingFarClipPlane = v172;
		    v174 = v403;
		    *(_OWORD *)&this->fields.heightFogConfig.heightFogDirectionalInscattering.g = v173;
		    v175 = v404;
		    this->fields.heightFogConfig.heightFogDirectionalInscatteringMobile = v174;
		    v176 = v405;
		    *(_OWORD *)&this->fields.heightFogConfig.enableVolumetricFog = v175;
		    v177 = v406;
		    *(_OWORD *)&this->fields.heightFogConfig.volumetricFogAlbedo.b = v176;
		    v178 = v407;
		    *(_OWORD *)&this->fields.heightFogConfig.volumetricFogEmissive.b = v177;
		    v179 = v408;
		    *(_OWORD *)&this->fields.heightFogConfig.volumetricFogStartDistance = v178;
		    v180 = v409;
		    *(_OWORD *)&this->fields.heightFogConfig.enableFlowNoise = v179;
		    *(_OWORD *)&this->fields.heightFogConfig.flowNoiseHorizontalDirAngle = v180;
		    *(_QWORD *)&this->fields.heightFogConfig.flowNoiseDir.z = v164;
		    *(_DWORD *)&this->fields.heightFogConfig.m_active = v411;
		  }
		  p_volumetricFogConfig = &src->fields.volumetricFogConfig;
		  if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGVolumetricFogConfig>->rgctx_data )
		    sub_1800430B0(MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGVolumetricFogConfig>);
		  if ( !TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig);
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  static_fields = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_284;
		  if ( wrapperArray[6] <= 1410 )
		    goto LABEL_67;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		  v327 = *(_QWORD *)wrapperArray;
		  if ( !*(_QWORD *)wrapperArray )
		    goto LABEL_284;
		  if ( *(_DWORD *)(v327 + 24) <= 0x582u )
		    goto LABEL_453;
		  if ( *(_QWORD *)(v327 + 11312) )
		  {
		    v328 = IFix::WrappersManagerImpl::GetPatch(1410, 0LL);
		    if ( !v328 )
		      goto LABEL_284;
		    v18 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_379(v328, &src->fields.volumetricFogConfig, 0LL);
		  }
		  else
		  {
		LABEL_67:
		    v18 = src->fields.volumetricFogConfig.m_active;
		  }
		  if ( v18 )
		  {
		    v181 = &v397;
		    v182 = 2LL;
		    do
		    {
		      v181 += 8;
		      v183 = *(_OWORD *)&p_volumetricFogConfig->enable;
		      v184 = *(_OWORD *)&p_volumetricFogConfig->heightFogStartHeightSecond;
		      p_volumetricFogConfig = (HGVolumetricFogConfig *)((char *)p_volumetricFogConfig + 128);
		      *(v181 - 8) = v183;
		      v185 = *(_OWORD *)&p_volumetricFogConfig[-1].flowVLNoiseDir.y;
		      *(v181 - 7) = v184;
		      v186 = *(_OWORD *)&p_volumetricFogConfig[-1].flowVLNoisePerturb3DTexture;
		      *(v181 - 6) = v185;
		      v187 = *(_OWORD *)&p_volumetricFogConfig[-1].flowVLNoisePerturbSpeed.x;
		      *(v181 - 5) = v186;
		      v188 = *(_OWORD *)&p_volumetricFogConfig[-1].m_backupVLNoiseDistance;
		      *(v181 - 4) = v187;
		      v189 = *(_OWORD *)&p_volumetricFogConfig[-1].m_backupVLNoiseTillingScale.z;
		      *(v181 - 3) = v188;
		      v190 = *(_OWORD *)&p_volumetricFogConfig[-1].m_backupFlowVLNoiseRemapRange.x;
		      *(v181 - 2) = v189;
		      *(v181 - 1) = v190;
		      --v182;
		    }
		    while ( v182 );
		    v191 = &v397;
		    v192 = 2LL;
		    v193 = *(_OWORD *)&p_volumetricFogConfig->heightFogStartHeightSecond;
		    *v181 = *(_OWORD *)&p_volumetricFogConfig->enable;
		    v194 = *(_OWORD *)&p_volumetricFogConfig->heightFogInscatter.g;
		    v181[1] = v193;
		    v195 = *(_OWORD *)&p_volumetricFogConfig->heightFogStartDistance;
		    v181[2] = v194;
		    v196 = *(_OWORD *)&p_volumetricFogConfig->heightFogDirectionalInscatteringExponent;
		    v181[3] = v195;
		    v197 = *(_OWORD *)&p_volumetricFogConfig->heightFogDirectionalInscattering.b;
		    v181[4] = v196;
		    v198 = *(_OWORD *)&p_volumetricFogConfig->heightFogDirectionalInscatteringMobile.g;
		    v181[5] = v197;
		    v181[6] = v198;
		    v199 = &this->fields.volumetricFogConfig;
		    do
		    {
		      v199 = (HGVolumetricFogConfig *)((char *)v199 + 128);
		      v200 = *v191;
		      v201 = v191[1];
		      v191 += 8;
		      *(_OWORD *)&v199[-1].flowVLNoiseDistance = v200;
		      v202 = *(v191 - 6);
		      *(_OWORD *)&v199[-1].flowVLNoiseTillingScale.z = v201;
		      v203 = *(v191 - 5);
		      *(_OWORD *)&v199[-1].flowVLNoiseDir.y = v202;
		      v204 = *(v191 - 4);
		      *(_OWORD *)&v199[-1].flowVLNoisePerturb3DTexture = v203;
		      v205 = *(v191 - 3);
		      *(_OWORD *)&v199[-1].flowVLNoisePerturbSpeed.x = v204;
		      v206 = *(v191 - 2);
		      *(_OWORD *)&v199[-1].m_backupVLNoiseDistance = v205;
		      v207 = *(v191 - 1);
		      *(_OWORD *)&v199[-1].m_backupVLNoiseTillingScale.z = v206;
		      *(_OWORD *)&v199[-1].m_backupFlowVLNoiseRemapRange.x = v207;
		      --v192;
		    }
		    while ( v192 );
		    v208 = v191[1];
		    *(_OWORD *)&v199->enable = *v191;
		    v209 = v191[2];
		    *(_OWORD *)&v199->heightFogStartHeightSecond = v208;
		    v210 = v191[3];
		    *(_OWORD *)&v199->heightFogInscatter.g = v209;
		    v211 = v191[4];
		    *(_OWORD *)&v199->heightFogStartDistance = v210;
		    v212 = v191[5];
		    *(_OWORD *)&v199->heightFogDirectionalInscatteringExponent = v211;
		    v213 = v191[6];
		    *(_OWORD *)&v199->heightFogDirectionalInscattering.b = v212;
		    *(_OWORD *)&v199->heightFogDirectionalInscatteringMobile.g = v213;
		    sub_18002D1B0(
		      (SingleFieldAccessor *)&this->fields.volumetricFogConfig.flowVLNoise3DTexture,
		      0LL,
		      (PropertyInfo_1 *)method,
		      v3,
		      (MethodInfo *)v397);
		  }
		  if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGVolumetricCloudConfig>->rgctx_data )
		    sub_1800430B0(MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGVolumetricCloudConfig>);
		  if ( !TypeInfo::HG::Rendering::Runtime::HGVolumetricCloudConfig->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGVolumetricCloudConfig);
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  static_fields = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_284;
		  if ( wrapperArray[6] <= 1407 )
		    goto LABEL_77;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		  v329 = *(_QWORD *)wrapperArray;
		  if ( !*(_QWORD *)wrapperArray )
		    goto LABEL_284;
		  if ( *(_DWORD *)(v329 + 24) <= 0x57Fu )
		    goto LABEL_453;
		  if ( *(_QWORD *)(v329 + 11288) )
		  {
		    v330 = IFix::WrappersManagerImpl::GetPatch(1407, 0LL);
		    if ( !v330 )
		      goto LABEL_284;
		    v19 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_576(v330, &src->fields.volumetricCloudConfig, 0LL);
		  }
		  else
		  {
		LABEL_77:
		    v19 = src->fields.volumetricCloudConfig.m_active;
		  }
		  if ( v19 )
		  {
		    v331 = src->fields.volumetricCloudConfig.m_active;
		    *(_WORD *)&this->fields.volumetricCloudConfig.enabled = *(_WORD *)&src->fields.volumetricCloudConfig.enabled;
		    this->fields.volumetricCloudConfig.m_active = v331;
		  }
		  if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGCloudConfig>->rgctx_data )
		    sub_1800430B0(MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGCloudConfig>);
		  if ( !TypeInfo::HG::Rendering::Runtime::HGCloudConfig->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCloudConfig);
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  static_fields = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_284;
		  if ( wrapperArray[6] <= 1347 )
		    goto LABEL_88;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		  v332 = *(_QWORD *)wrapperArray;
		  if ( !*(_QWORD *)wrapperArray )
		    goto LABEL_284;
		  if ( *(_DWORD *)(v332 + 24) <= 0x543u )
		    goto LABEL_453;
		  if ( *(_QWORD *)(v332 + 10808) )
		  {
		    v333 = IFix::WrappersManagerImpl::GetPatch(1347, 0LL);
		    if ( !v333 )
		      goto LABEL_284;
		    v20 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_534(v333, &src->fields.cloudConfig, 0LL);
		  }
		  else
		  {
		LABEL_88:
		    v20 = src->fields.cloudConfig.m_active;
		  }
		  if ( v20 )
		  {
		    cloudTint = src->fields.cloudConfig.cloudTint;
		    v397 = *(_OWORD *)&src->fields.cloudConfig.enable;
		    v215 = *(_OWORD *)&src->fields.cloudConfig.cloudContrast;
		    v398 = cloudTint;
		    v216 = *(_OWORD *)&src->fields.cloudConfig.brightnessAffectCloudAlpha;
		    v399 = v215;
		    v217 = *(_OWORD *)&src->fields.cloudConfig.cloudFlowType;
		    v400 = v216;
		    v218 = *(_OWORD *)&src->fields.cloudConfig.flowSpeed;
		    v401 = v217;
		    v219 = *(Color *)&src->fields.cloudConfig.lightShaftCloudMaskTexture;
		    v402 = v218;
		    v220 = *(_OWORD *)&src->fields.cloudConfig.cloudShadowConfig.cloudShadowTexture;
		    v403 = v219;
		    v221 = *(_OWORD *)&src->fields.cloudConfig.cloudShadowConfig.cloudShadowEnvCenter.z;
		    v404 = v220;
		    v222 = *(_OWORD *)&src->fields.cloudConfig.cloudShadowConfig.cloudShadowFlowDirection.y;
		    v405 = v221;
		    v223 = *(_OWORD *)&src->fields.cloudConfig.cloudShadowConfig.cloudShadowScaleEndDistance;
		    v406 = v222;
		    v407 = v223;
		    v224 = v398;
		    *(_OWORD *)&this->fields.cloudConfig.enable = v397;
		    v225 = v399;
		    this->fields.cloudConfig.cloudTint = v224;
		    v226 = v400;
		    *(_OWORD *)&this->fields.cloudConfig.cloudContrast = v225;
		    v227 = v401;
		    *(_OWORD *)&this->fields.cloudConfig.brightnessAffectCloudAlpha = v226;
		    v228 = v402;
		    *(_OWORD *)&this->fields.cloudConfig.cloudFlowType = v227;
		    v229 = v403;
		    *(_OWORD *)&this->fields.cloudConfig.flowSpeed = v228;
		    v230 = v404;
		    *(Color *)&this->fields.cloudConfig.lightShaftCloudMaskTexture = v229;
		    v231 = v405;
		    *(_OWORD *)&this->fields.cloudConfig.cloudShadowConfig.cloudShadowTexture = v230;
		    v232 = v406;
		    *(_OWORD *)&this->fields.cloudConfig.cloudShadowConfig.cloudShadowEnvCenter.z = v231;
		    v233 = v407;
		    *(_OWORD *)&this->fields.cloudConfig.cloudShadowConfig.cloudShadowFlowDirection.y = v232;
		    *(_OWORD *)&this->fields.cloudConfig.cloudShadowConfig.cloudShadowScaleEndDistance = v233;
		    sub_18002D1B0(
		      (SingleFieldAccessor *)&this->fields.cloudConfig.cloudTexture,
		      (Type *)wrapperArray,
		      (PropertyInfo_1 *)method,
		      v3,
		      (MethodInfo *)v397);
		  }
		  p_celestialConfig = &src->fields.celestialConfig;
		  if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGCelestialConfig>->rgctx_data )
		    sub_1800430B0(MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGCelestialConfig>);
		  if ( !TypeInfo::HG::Rendering::Runtime::HGCelestialConfig->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCelestialConfig);
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  static_fields = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_284;
		  if ( wrapperArray[6] <= 1327 )
		    goto LABEL_99;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		  v334 = *(_QWORD *)wrapperArray;
		  if ( !*(_QWORD *)wrapperArray )
		    goto LABEL_284;
		  if ( *(_DWORD *)(v334 + 24) <= 0x52Fu )
		    goto LABEL_453;
		  if ( *(_QWORD *)(v334 + 10648) )
		  {
		    v335 = IFix::WrappersManagerImpl::GetPatch(1327, 0LL);
		    if ( !v335 )
		      goto LABEL_284;
		    v22 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_514(v335, &src->fields.celestialConfig, 0LL);
		  }
		  else
		  {
		LABEL_99:
		    v22 = src->fields.celestialConfig.m_active;
		  }
		  if ( v22 )
		  {
		    v234 = &v397;
		    v235 = 2LL;
		    do
		    {
		      v234 += 8;
		      v236 = *(_OWORD *)&p_celestialConfig->moonConfig.radius;
		      v237 = *(_OWORD *)&p_celestialConfig->moonConfig.worldLongitude;
		      p_celestialConfig = (HGCelestialConfig *)((char *)p_celestialConfig + 128);
		      *(v234 - 8) = v236;
		      v238 = *(_OWORD *)&p_celestialConfig[-1].planetConfig.ring.outerRadius;
		      *(v234 - 7) = v237;
		      v239 = *(_OWORD *)&p_celestialConfig[-1].planetConfig.ring.ringColor.b;
		      *(v234 - 6) = v238;
		      v240 = *(_OWORD *)&p_celestialConfig[-1].planetConfig.enableAtmosphere;
		      *(v234 - 5) = v239;
		      v241 = *(_OWORD *)&p_celestialConfig[-1].planetConfig.atmosphere.numOpticalDepthSamplePoints;
		      *(v234 - 4) = v240;
		      v242 = *(_OWORD *)&p_celestialConfig[-1].planetConfig.atmosphere.atmosphereHueshift;
		      *(v234 - 3) = v241;
		      v243 = *(_OWORD *)&p_celestialConfig[-1].advancedPlanetConfig.advancedPlanetMat;
		      *(v234 - 2) = v242;
		      *(v234 - 1) = v243;
		      --v235;
		    }
		    while ( v235 );
		    drawMaterial = p_celestialConfig->talosAlphaConfig.skydomeDrawer.drawMaterial;
		    v245 = 2LL;
		    v246 = *(_OWORD *)&p_celestialConfig->moonConfig.worldLongitude;
		    *v234 = *(_OWORD *)&p_celestialConfig->moonConfig.radius;
		    v247 = *(_OWORD *)&p_celestialConfig->moonConfig.ring.outerRadius;
		    v234[1] = v246;
		    v248 = *(_OWORD *)&p_celestialConfig->moonConfig.ring.ringColor.b;
		    v234[2] = v247;
		    v249 = *(_OWORD *)&p_celestialConfig->talosAlphaConfig.drawPlanetInSkydome;
		    v234[3] = v248;
		    v250 = *(_OWORD *)&p_celestialConfig->talosAlphaConfig.objectProperty.selfTiltZ;
		    v234[4] = v249;
		    v234[5] = v250;
		    *((_QWORD *)v234 + 12) = drawMaterial;
		    v251 = &this->fields.celestialConfig;
		    v252 = &v397;
		    do
		    {
		      v251 = (HGCelestialConfig *)((char *)v251 + 128);
		      v253 = *v252;
		      v254 = v252[1];
		      v252 += 8;
		      *(_OWORD *)&v251[-1].planetConfig.skydomeDrawer.drawMaterial = v253;
		      v255 = *(v252 - 6);
		      *(_OWORD *)&v251[-1].planetConfig.skydomeDrawer.incidentLightingPitchYaw.x = v254;
		      v256 = *(v252 - 5);
		      *(_OWORD *)&v251[-1].planetConfig.ring.outerRadius = v255;
		      v257 = *(v252 - 4);
		      *(_OWORD *)&v251[-1].planetConfig.ring.ringColor.b = v256;
		      v258 = *(v252 - 3);
		      *(_OWORD *)&v251[-1].planetConfig.enableAtmosphere = v257;
		      v259 = *(v252 - 2);
		      *(_OWORD *)&v251[-1].planetConfig.atmosphere.numOpticalDepthSamplePoints = v258;
		      v260 = *(v252 - 1);
		      *(_OWORD *)&v251[-1].planetConfig.atmosphere.atmosphereHueshift = v259;
		      *(_OWORD *)&v251[-1].advancedPlanetConfig.advancedPlanetMat = v260;
		      --v245;
		    }
		    while ( v245 );
		    v261 = v252[1];
		    *(_OWORD *)&v251->moonConfig.radius = *v252;
		    v262 = v252[2];
		    *(_OWORD *)&v251->moonConfig.worldLongitude = v261;
		    v263 = v252[3];
		    *(_OWORD *)&v251->moonConfig.ring.outerRadius = v262;
		    v264 = v252[4];
		    *(_OWORD *)&v251->moonConfig.ring.ringColor.b = v263;
		    v265 = v252[5];
		    v266 = (Material *)*((_QWORD *)v252 + 12);
		    *(_OWORD *)&v251->talosAlphaConfig.drawPlanetInSkydome = v264;
		    *(_OWORD *)&v251->talosAlphaConfig.objectProperty.selfTiltZ = v265;
		    v251->talosAlphaConfig.skydomeDrawer.drawMaterial = v266;
		    sub_18002D1B0(
		      (SingleFieldAccessor *)&this->fields.celestialConfig.moonConfig.ring.planetRingMap,
		      0LL,
		      (PropertyInfo_1 *)method,
		      v3,
		      (MethodInfo *)v397);
		  }
		  if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGWindConfig>->rgctx_data )
		    sub_1800430B0(MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGWindConfig>);
		  if ( !TypeInfo::HG::Rendering::Runtime::HGWindConfig->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGWindConfig);
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  static_fields = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_284;
		  if ( wrapperArray[6] <= 1414 )
		    goto LABEL_109;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		  v336 = *(_QWORD *)wrapperArray;
		  if ( !*(_QWORD *)wrapperArray )
		    goto LABEL_284;
		  if ( *(_DWORD *)(v336 + 24) <= 0x586u )
		    goto LABEL_453;
		  if ( *(_QWORD *)(v336 + 11344) )
		  {
		    v337 = IFix::WrappersManagerImpl::GetPatch(1414, 0LL);
		    if ( !v337 )
		      goto LABEL_284;
		    v23 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_581(v337, &src->fields.windConfig, 0LL);
		  }
		  else
		  {
		LABEL_109:
		    v23 = src->fields.windConfig.m_active;
		  }
		  if ( v23 )
		  {
		    v267 = *(_DWORD *)&src->fields.windConfig.m_active;
		    v268 = *(_QWORD *)&src->fields.windConfig.direction.y;
		    *(_OWORD *)&this->fields.windConfig.speed = *(_OWORD *)&src->fields.windConfig.speed;
		    *(_QWORD *)&this->fields.windConfig.direction.y = v268;
		    *(_DWORD *)&this->fields.windConfig.m_active = v267;
		  }
		  if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGLightShaftConfig>->rgctx_data )
		    sub_1800430B0(MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGLightShaftConfig>);
		  if ( !TypeInfo::HG::Rendering::Runtime::HGLightShaftConfig->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGLightShaftConfig);
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  static_fields = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_284;
		  if ( wrapperArray[6] <= 1389 )
		    goto LABEL_120;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		  v338 = *(_QWORD *)wrapperArray;
		  if ( !*(_QWORD *)wrapperArray )
		    goto LABEL_284;
		  if ( *(_DWORD *)(v338 + 24) <= 0x56Du )
		    goto LABEL_453;
		  if ( *(_QWORD *)(v338 + 11144) )
		  {
		    v339 = IFix::WrappersManagerImpl::GetPatch(1389, 0LL);
		    if ( !v339 )
		      goto LABEL_284;
		    v24 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_562(v339, &src->fields.lightShaftConfig, 0LL);
		  }
		  else
		  {
		LABEL_120:
		    v24 = src->fields.lightShaftConfig.m_active;
		  }
		  if ( v24 )
		  {
		    v269 = *(_DWORD *)&src->fields.lightShaftConfig.m_active;
		    bloomTint = src->fields.lightShaftConfig.bloomTint;
		    v271 = *(_OWORD *)&src->fields.lightShaftConfig.blurIntensity;
		    *(_OWORD *)&this->fields.lightShaftConfig.enable = *(_OWORD *)&src->fields.lightShaftConfig.enable;
		    this->fields.lightShaftConfig.bloomTint = bloomTint;
		    *(_OWORD *)&this->fields.lightShaftConfig.blurIntensity = v271;
		    *(_DWORD *)&this->fields.lightShaftConfig.m_active = v269;
		  }
		  if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGTerrainDeformConfig>->rgctx_data )
		    sub_1800430B0(MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGTerrainDeformConfig>);
		  if ( !TypeInfo::HG::Rendering::Runtime::HGTerrainDeformConfig->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGTerrainDeformConfig);
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  static_fields = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_284;
		  if ( wrapperArray[6] <= 1405 )
		    goto LABEL_131;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		  v340 = *(_QWORD *)wrapperArray;
		  if ( !*(_QWORD *)wrapperArray )
		    goto LABEL_284;
		  if ( *(_DWORD *)(v340 + 24) <= 0x57Du )
		    goto LABEL_453;
		  if ( *(_QWORD *)(v340 + 11272) )
		  {
		    v341 = IFix::WrappersManagerImpl::GetPatch(1405, 0LL);
		    if ( !v341 )
		      goto LABEL_284;
		    v25 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_574(v341, &src->fields.terrainDeformConfig, 0LL);
		  }
		  else
		  {
		LABEL_131:
		    v25 = src->fields.terrainDeformConfig.m_active;
		  }
		  if ( v25 )
		  {
		    v298 = *(_DWORD *)&src->fields.terrainDeformConfig.m_active;
		    *(_QWORD *)&this->fields.terrainDeformConfig.deformGlobalStrength = *(_QWORD *)&src->fields.terrainDeformConfig.deformGlobalStrength;
		    *(_DWORD *)&this->fields.terrainDeformConfig.m_active = v298;
		  }
		  if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGInkSimulationConfig>->rgctx_data )
		    sub_1800430B0(MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGInkSimulationConfig>);
		  if ( !TypeInfo::HG::Rendering::Runtime::HGInkSimulationConfig->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGInkSimulationConfig);
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  static_fields = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_284;
		  if ( wrapperArray[6] <= 1368 )
		    goto LABEL_142;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		  v342 = *(_QWORD *)wrapperArray;
		  if ( !*(_QWORD *)wrapperArray )
		    goto LABEL_284;
		  if ( *(_DWORD *)(v342 + 24) <= 0x558u )
		    goto LABEL_453;
		  if ( *(_QWORD *)(v342 + 10976) )
		  {
		    v343 = IFix::WrappersManagerImpl::GetPatch(1368, 0LL);
		    if ( !v343 )
		      goto LABEL_284;
		    v26 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_543(v343, &src->fields.inkSimulationConfig, 0LL);
		  }
		  else
		  {
		LABEL_142:
		    v26 = src->fields.inkSimulationConfig.m_active;
		  }
		  if ( v26 )
		  {
		    v344 = *(_OWORD *)&src->fields.inkSimulationConfig.inkRippleDensity;
		    v345 = *(_OWORD *)&src->fields.inkSimulationConfig.inkDebugJacobi;
		    v346 = *(_OWORD *)&src->fields.inkSimulationConfig.resolvedShaderParams.speedFactor;
		    v347 = *(_OWORD *)&src->fields.inkSimulationConfig.resolvedShaderParams.forceAngleRandom;
		    v348 = *(_OWORD *)&src->fields.inkSimulationConfig.resolvedShaderParams.landingInkSize;
		    v349 = *(_OWORD *)&src->fields.inkSimulationConfig.resolvedShaderParams.viscosity;
		    v350 = *(_QWORD *)&src->fields.inkSimulationConfig.resolvedShaderParams.idleForceChangeSpeed;
		    *(_OWORD *)&this->fields.inkSimulationConfig.influence = *(_OWORD *)&src->fields.inkSimulationConfig.influence;
		    *(_OWORD *)&this->fields.inkSimulationConfig.inkRippleDensity = v344;
		    *(_OWORD *)&this->fields.inkSimulationConfig.inkDebugJacobi = v345;
		    *(_OWORD *)&this->fields.inkSimulationConfig.resolvedShaderParams.speedFactor = v346;
		    *(_OWORD *)&this->fields.inkSimulationConfig.resolvedShaderParams.forceAngleRandom = v347;
		    *(_OWORD *)&this->fields.inkSimulationConfig.resolvedShaderParams.landingInkSize = v348;
		    *(_OWORD *)&this->fields.inkSimulationConfig.resolvedShaderParams.viscosity = v349;
		    *(_QWORD *)&this->fields.inkSimulationConfig.resolvedShaderParams.idleForceChangeSpeed = v350;
		    sub_18002D1B0(
		      (SingleFieldAccessor *)&this->fields.inkSimulationConfig.shaderParams,
		      (Type *)wrapperArray,
		      (PropertyInfo_1 *)method,
		      v3,
		      (MethodInfo *)v397);
		  }
		  p_rainConfig = &this->fields.rainConfig;
		  v28 = &src->fields.rainConfig;
		  if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGRainConfig>->rgctx_data )
		    sub_1800430B0(MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGRainConfig>);
		  if ( !TypeInfo::HG::Rendering::Runtime::HGRainConfig->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRainConfig);
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  static_fields = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_284;
		  if ( wrapperArray[6] <= 1391 )
		    goto LABEL_153;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		  v351 = *(_QWORD *)wrapperArray;
		  if ( !*(_QWORD *)wrapperArray )
		    goto LABEL_284;
		  if ( *(_DWORD *)(v351 + 24) <= 0x56Fu )
		    goto LABEL_453;
		  if ( *(_QWORD *)(v351 + 11160) )
		  {
		    v352 = IFix::WrappersManagerImpl::GetPatch(1391, 0LL);
		    if ( !v352 )
		      goto LABEL_284;
		    v29 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_564(v352, &src->fields.rainConfig, 0LL);
		  }
		  else
		  {
		LABEL_153:
		    v29 = src->fields.rainConfig.m_active;
		  }
		  if ( v29 )
		  {
		    v272 = &v397;
		    v273 = 2LL;
		    do
		    {
		      v272 += 8;
		      v274 = *(_OWORD *)&v28->enable;
		      v275 = *(_OWORD *)&v28->color.g;
		      v28 = (HGRainConfig *)((char *)v28 + 128);
		      *(v272 - 8) = v274;
		      v276 = *(_OWORD *)&v28[-1].baseWetnessLevel;
		      *(v272 - 7) = v275;
		      v277 = *(_OWORD *)&v28[-1].verticalFlowSurfaceThreshold;
		      *(v272 - 6) = v276;
		      v278 = *(_OWORD *)&v28[-1].rippleWaveSpeed;
		      *(v272 - 5) = v277;
		      v279 = *(_OWORD *)&v28[-1].farSceneWetnessValue;
		      *(v272 - 4) = v278;
		      v280 = *(_OWORD *)&v28[-1].rainDirection.z;
		      *(v272 - 3) = v279;
		      v281 = *(_OWORD *)&v28[-1].farRainDirection.x;
		      *(v272 - 2) = v280;
		      *(v272 - 1) = v281;
		      --v273;
		    }
		    while ( v273 );
		    v282 = 2LL;
		    v283 = *(_OWORD *)&v28->color.g;
		    *v272 = *(_OWORD *)&v28->enable;
		    v284 = *(_OWORD *)&v28->horizontalRainAngle;
		    v272[1] = v283;
		    v272[2] = v284;
		    v285 = &v397;
		    do
		    {
		      p_rainConfig = (HGRainConfig *)((char *)p_rainConfig + 128);
		      v286 = *v285;
		      v287 = v285[1];
		      v285 += 8;
		      *(_OWORD *)&p_rainConfig[-1].rainSplashAlpha = v286;
		      v288 = *(v285 - 6);
		      *(_OWORD *)&p_rainConfig[-1].enableWetness = v287;
		      v289 = *(v285 - 5);
		      *(_OWORD *)&p_rainConfig[-1].baseWetnessLevel = v288;
		      v290 = *(v285 - 4);
		      *(_OWORD *)&p_rainConfig[-1].verticalFlowSurfaceThreshold = v289;
		      v291 = *(v285 - 3);
		      *(_OWORD *)&p_rainConfig[-1].rippleWaveSpeed = v290;
		      v292 = *(v285 - 2);
		      *(_OWORD *)&p_rainConfig[-1].farSceneWetnessValue = v291;
		      v293 = *(v285 - 1);
		      *(_OWORD *)&p_rainConfig[-1].rainDirection.z = v292;
		      *(_OWORD *)&p_rainConfig[-1].farRainDirection.x = v293;
		      --v282;
		    }
		    while ( v282 );
		    v294 = v285[1];
		    *(_OWORD *)&p_rainConfig->enable = *v285;
		    v295 = v285[2];
		    *(_OWORD *)&p_rainConfig->color.g = v294;
		    *(_OWORD *)&p_rainConfig->horizontalRainAngle = v295;
		  }
		  if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGSnowConfig>->rgctx_data )
		    sub_1800430B0(MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGSnowConfig>);
		  if ( !TypeInfo::HG::Rendering::Runtime::HGSnowConfig->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGSnowConfig);
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  static_fields = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_284;
		  if ( wrapperArray[6] <= 1401 )
		    goto LABEL_163;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		  v353 = *(_QWORD *)wrapperArray;
		  if ( !*(_QWORD *)wrapperArray )
		    goto LABEL_284;
		  if ( *(_DWORD *)(v353 + 24) <= 0x579u )
		    goto LABEL_453;
		  if ( *(_QWORD *)(v353 + 11240) )
		  {
		    v354 = IFix::WrappersManagerImpl::GetPatch(1401, 0LL);
		    if ( !v354 )
		      goto LABEL_284;
		    v30 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_570(v354, &src->fields.snowConfig, 0LL);
		  }
		  else
		  {
		LABEL_163:
		    v30 = src->fields.snowConfig.m_active;
		  }
		  if ( v30 )
		  {
		    color = src->fields.snowConfig.color;
		    v356 = *(_OWORD *)&src->fields.snowConfig.snowSizeRange.x;
		    v357 = *(_OWORD *)&src->fields.snowConfig.snowTrailLength;
		    v358 = *(_OWORD *)&src->fields.snowConfig.snowLightingPercent;
		    v359 = *(_QWORD *)&src->fields.snowConfig.snowDirection.z;
		    *(_OWORD *)&this->fields.snowConfig.enable = *(_OWORD *)&src->fields.snowConfig.enable;
		    this->fields.snowConfig.color = color;
		    *(_OWORD *)&this->fields.snowConfig.snowSizeRange.x = v356;
		    *(_OWORD *)&this->fields.snowConfig.snowTrailLength = v357;
		    *(_OWORD *)&this->fields.snowConfig.snowLightingPercent = v358;
		    *(_QWORD *)&this->fields.snowConfig.snowDirection.z = v359;
		  }
		  if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGStarConfig>->rgctx_data )
		    sub_1800430B0(MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGStarConfig>);
		  if ( !TypeInfo::HG::Rendering::Runtime::HGStarConfig->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGStarConfig);
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  static_fields = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_284;
		  if ( wrapperArray[6] <= 1403 )
		    goto LABEL_174;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		  v360 = *(_QWORD *)wrapperArray;
		  if ( !*(_QWORD *)wrapperArray )
		    goto LABEL_284;
		  if ( *(_DWORD *)(v360 + 24) <= 0x57Bu )
		    goto LABEL_453;
		  if ( *(_QWORD *)(v360 + 11256) )
		  {
		    v361 = IFix::WrappersManagerImpl::GetPatch(1403, 0LL);
		    if ( !v361 )
		      goto LABEL_284;
		    v31 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_572(v361, &src->fields.starConfig, 0LL);
		  }
		  else
		  {
		LABEL_174:
		    v31 = src->fields.starConfig.m_active;
		  }
		  if ( v31 )
		  {
		    v306 = *(_OWORD *)&src->fields.starConfig.minMaxRange.y;
		    v307 = *(_OWORD *)&src->fields.starConfig.starsTint.a;
		    v308 = *(_OWORD *)&src->fields.starConfig.starsTint1.a;
		    v309 = *(_OWORD *)&src->fields.starConfig.brightnessRandomSeed;
		    v310 = *(_OWORD *)&src->fields.starConfig.skyBoxStarRangeMap;
		    v311 = *(_OWORD *)&src->fields.starConfig.cloudRingStarCoverage;
		    v312 = *(_OWORD *)&src->fields.starConfig.nebulaMap;
		    v313 = *(_OWORD *)&src->fields.starConfig.nebulaTint.b;
		    v314 = *(_QWORD *)&src->fields.starConfig.m_active;
		    *(_OWORD *)&this->fields.starConfig.enableStars = *(_OWORD *)&src->fields.starConfig.enableStars;
		    *(_OWORD *)&this->fields.starConfig.minMaxRange.y = v306;
		    *(_OWORD *)&this->fields.starConfig.starsTint.a = v307;
		    *(_OWORD *)&this->fields.starConfig.starsTint1.a = v308;
		    *(_OWORD *)&this->fields.starConfig.brightnessRandomSeed = v309;
		    *(_OWORD *)&this->fields.starConfig.skyBoxStarRangeMap = v310;
		    *(_OWORD *)&this->fields.starConfig.cloudRingStarCoverage = v311;
		    *(_OWORD *)&this->fields.starConfig.nebulaMap = v312;
		    *(_OWORD *)&this->fields.starConfig.nebulaTint.b = v313;
		    *(_QWORD *)&this->fields.starConfig.m_active = v314;
		    sub_18002D1B0(
		      (SingleFieldAccessor *)&this->fields.starConfig.skyBoxStarRangeMap,
		      (Type *)wrapperArray,
		      (PropertyInfo_1 *)method,
		      v3,
		      (MethodInfo *)v397);
		  }
		  if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGLensFlareConfig>->rgctx_data )
		    sub_1800430B0(MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGLensFlareConfig>);
		  if ( !TypeInfo::HG::Rendering::Runtime::HGLensFlareConfig->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGLensFlareConfig);
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  static_fields = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_284;
		  if ( wrapperArray[6] <= 1382 )
		    goto LABEL_185;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		  v362 = *(_QWORD *)wrapperArray;
		  if ( !*(_QWORD *)wrapperArray )
		    goto LABEL_284;
		  if ( *(_DWORD *)(v362 + 24) <= 0x566u )
		    goto LABEL_453;
		  if ( *(_QWORD *)(v362 + 11088) )
		  {
		    v363 = IFix::WrappersManagerImpl::GetPatch(1382, 0LL);
		    if ( !v363 )
		      goto LABEL_284;
		    v32 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_556(v363, &src->fields.lensFlareConfig, 0LL);
		  }
		  else
		  {
		LABEL_185:
		    v32 = src->fields.lensFlareConfig.m_active;
		  }
		  if ( v32 )
		  {
		    v296 = *(_OWORD *)&src->fields.lensFlareConfig.intensity;
		    v297 = *(_OWORD *)&src->fields.lensFlareConfig.sampleCount;
		    *(_OWORD *)&this->fields.lensFlareConfig.enable = *(_OWORD *)&src->fields.lensFlareConfig.enable;
		    *(_OWORD *)&this->fields.lensFlareConfig.intensity = v296;
		    *(_OWORD *)&this->fields.lensFlareConfig.sampleCount = v297;
		    sub_18002D1B0(
		      (SingleFieldAccessor *)&this->fields.lensFlareConfig.lensFlareData,
		      (Type *)wrapperArray,
		      (PropertyInfo_1 *)method,
		      v3,
		      (MethodInfo *)v397);
		  }
		  p_colorGradingConfig = &src->fields.colorGradingConfig;
		  if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGColorGradingConfig>->rgctx_data )
		    sub_1800430B0(MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGColorGradingConfig>);
		  if ( !TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  static_fields = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_284;
		  if ( wrapperArray[6] <= 969 )
		    goto LABEL_196;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		  v364 = *(_QWORD *)wrapperArray;
		  if ( !*(_QWORD *)wrapperArray )
		    goto LABEL_284;
		  if ( *(_DWORD *)(v364 + 24) <= 0x3C9u )
		    goto LABEL_453;
		  if ( *(_QWORD *)(v364 + 7784) )
		  {
		    v365 = IFix::WrappersManagerImpl::GetPatch(969, 0LL);
		    if ( !v365 )
		      goto LABEL_284;
		    v34 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_382(v365, &src->fields.colorGradingConfig, 0LL);
		  }
		  else
		  {
		LABEL_196:
		    v34 = src->fields.colorGradingConfig.m_active;
		  }
		  if ( v34 )
		  {
		    v42 = &v397;
		    v43 = 2LL;
		    do
		    {
		      v42 += 8;
		      v44 = *(_OWORD *)&p_colorGradingConfig->tonemappingMode;
		      v45 = *(_OWORD *)&p_colorGradingConfig->colorLookupContribution;
		      p_colorGradingConfig = (HGColorGradingConfig *)((char *)p_colorGradingConfig + 128);
		      *(v42 - 8) = v44;
		      v46 = *(_OWORD *)&p_colorGradingConfig[-1].splitToningHighlights.a;
		      *(v42 - 7) = v45;
		      v47 = *(_OWORD *)&p_colorGradingConfig[-1].colorCurves.master;
		      *(v42 - 6) = v46;
		      v48 = *(_OWORD *)&p_colorGradingConfig[-1].colorCurves.green;
		      *(v42 - 5) = v47;
		      v49 = *(_OWORD *)&p_colorGradingConfig[-1].colorCurves.hueVsHue;
		      *(v42 - 4) = v48;
		      v50 = *(_OWORD *)&p_colorGradingConfig[-1].colorCurves.satVsSat;
		      *(v42 - 3) = v49;
		      v51 = *(_OWORD *)&p_colorGradingConfig[-1].colorCurves.masterOverriding;
		      *(v42 - 2) = v50;
		      *(v42 - 1) = v51;
		      --v43;
		    }
		    while ( v43 );
		    v52 = &v397;
		    v53 = *(_OWORD *)&p_colorGradingConfig->colorLookupContribution;
		    *v42 = *(_OWORD *)&p_colorGradingConfig->tonemappingMode;
		    v54 = *(_OWORD *)&p_colorGradingConfig->colorAdjustmentsEnabled;
		    v42[1] = v53;
		    v55 = *(_OWORD *)&p_colorGradingConfig->colorAdjustmentsColorFilter.g;
		    v42[2] = v54;
		    v56 = *(_OWORD *)&p_colorGradingConfig->colorAdjustmentsSaturation;
		    v42[3] = v55;
		    v57 = *(_OWORD *)&p_colorGradingConfig->channelMixerRedOutBlueIn;
		    v42[4] = v56;
		    v58 = *(_OWORD *)&p_colorGradingConfig->channelMixerBlueOutRedIn;
		    v42[5] = v57;
		    v42[6] = v58;
		    v59 = &this->fields.colorGradingConfig;
		    do
		    {
		      v59 = (HGColorGradingConfig *)((char *)v59 + 128);
		      v60 = *v52;
		      v61 = v52[1];
		      v52 += 8;
		      *(_OWORD *)&v59[-1].splitToningEnabled = v60;
		      v62 = *(v52 - 6);
		      *(_OWORD *)&v59[-1].splitToningShadows.a = v61;
		      v63 = *(v52 - 5);
		      *(_OWORD *)&v59[-1].splitToningHighlights.a = v62;
		      v64 = *(v52 - 4);
		      *(_OWORD *)&v59[-1].colorCurves.master = v63;
		      v65 = *(v52 - 3);
		      *(_OWORD *)&v59[-1].colorCurves.green = v64;
		      v66 = *(v52 - 2);
		      *(_OWORD *)&v59[-1].colorCurves.hueVsHue = v65;
		      v67 = *(v52 - 1);
		      *(_OWORD *)&v59[-1].colorCurves.satVsSat = v66;
		      *(_OWORD *)&v59[-1].colorCurves.masterOverriding = v67;
		      --v11;
		    }
		    while ( v11 );
		    v68 = v52[1];
		    *(_OWORD *)&v59->tonemappingMode = *v52;
		    v69 = v52[2];
		    *(_OWORD *)&v59->colorLookupContribution = v68;
		    v70 = v52[3];
		    *(_OWORD *)&v59->colorAdjustmentsEnabled = v69;
		    v71 = v52[4];
		    *(_OWORD *)&v59->colorAdjustmentsColorFilter.g = v70;
		    v72 = v52[5];
		    *(_OWORD *)&v59->colorAdjustmentsSaturation = v71;
		    v73 = v52[6];
		    *(_OWORD *)&v59->channelMixerRedOutBlueIn = v72;
		    *(_OWORD *)&v59->channelMixerBlueOutRedIn = v73;
		    sub_18002D1B0(
		      (SingleFieldAccessor *)&this->fields.colorGradingConfig.colorLookupTexture,
		      (Type *)wrapperArray,
		      (PropertyInfo_1 *)method,
		      v3,
		      (MethodInfo *)v397);
		  }
		  if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGAutoExposureConfig>->rgctx_data )
		    sub_1800430B0(MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGAutoExposureConfig>);
		  if ( !TypeInfo::HG::Rendering::Runtime::HGAutoExposureConfig->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGAutoExposureConfig);
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  static_fields = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_284;
		  if ( wrapperArray[6] <= 1325 )
		    goto LABEL_206;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		  v366 = *(_QWORD *)wrapperArray;
		  if ( !*(_QWORD *)wrapperArray )
		    goto LABEL_284;
		  if ( *(_DWORD *)(v366 + 24) <= 0x52Du )
		    goto LABEL_453;
		  if ( *(_QWORD *)(v366 + 10632) )
		  {
		    v367 = IFix::WrappersManagerImpl::GetPatch(1325, 0LL);
		    if ( !v367 )
		      goto LABEL_284;
		    v35 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_381(v367, &src->fields.autoExposureConfig, 0LL);
		  }
		  else
		  {
		LABEL_206:
		    v35 = src->fields.autoExposureConfig.m_active;
		  }
		  if ( v35 )
		  {
		    v74 = *(_DWORD *)&src->fields.autoExposureConfig.m_active;
		    v75 = *(_OWORD *)&src->fields.autoExposureConfig.autoExposureEv100Range.x;
		    v76 = *(_OWORD *)&src->fields.autoExposureConfig.autoExposureMeteringMode;
		    v77 = *(_QWORD *)&src->fields.autoExposureConfig.autoExposureEvClampRange.y;
		    *(_OWORD *)&this->fields.autoExposureConfig.autoExposureMode = *(_OWORD *)&src->fields.autoExposureConfig.autoExposureMode;
		    *(_OWORD *)&this->fields.autoExposureConfig.autoExposureEv100Range.x = v75;
		    *(_OWORD *)&this->fields.autoExposureConfig.autoExposureMeteringMode = v76;
		    *(_QWORD *)&this->fields.autoExposureConfig.autoExposureEvClampRange.y = v77;
		    *(_DWORD *)&this->fields.autoExposureConfig.m_active = v74;
		  }
		  if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGShadowConfig>->rgctx_data )
		    sub_1800430B0(MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGShadowConfig>);
		  if ( !TypeInfo::HG::Rendering::Runtime::HGShadowConfig->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGShadowConfig);
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  static_fields = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_284;
		  if ( wrapperArray[6] <= 1397 )
		    goto LABEL_217;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		  v368 = *(_QWORD *)wrapperArray;
		  if ( !*(_QWORD *)wrapperArray )
		    goto LABEL_284;
		  if ( *(_DWORD *)(v368 + 24) <= 0x575u )
		    goto LABEL_453;
		  if ( *(_QWORD *)(v368 + 11208) )
		  {
		    v369 = IFix::WrappersManagerImpl::GetPatch(1397, 0LL);
		    if ( !v369 )
		      goto LABEL_284;
		    v36 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_567(v369, &src->fields.shadowConfig, 0LL);
		  }
		  else
		  {
		LABEL_217:
		    v36 = src->fields.shadowConfig.m_active;
		  }
		  if ( v36 )
		  {
		    v299 = *(_OWORD *)&src->fields.shadowConfig.csmIntensity;
		    v300 = *(_OWORD *)&src->fields.shadowConfig.csmShadowSoftness;
		    v301 = *(_OWORD *)&src->fields.shadowConfig.contactShadowSurfaceThickness;
		    v302 = *(_OWORD *)&src->fields.shadowConfig.overrideCsmFarDistance;
		    v303 = *(_OWORD *)&src->fields.shadowConfig.overrideCsmSpherePosition.z;
		    v304 = *(_OWORD *)&src->fields.shadowConfig.csmSimulatedAttenuation;
		    v305 = *(_OWORD *)&src->fields.shadowConfig.rhodesShipCenter.z;
		    *(_OWORD *)&this->fields.shadowConfig.csmDepthBias = *(_OWORD *)&src->fields.shadowConfig.csmDepthBias;
		    *(_OWORD *)&this->fields.shadowConfig.csmIntensity = v299;
		    *(_OWORD *)&this->fields.shadowConfig.csmShadowSoftness = v300;
		    *(_OWORD *)&this->fields.shadowConfig.contactShadowSurfaceThickness = v301;
		    *(_OWORD *)&this->fields.shadowConfig.overrideCsmFarDistance = v302;
		    *(_OWORD *)&this->fields.shadowConfig.overrideCsmSpherePosition.z = v303;
		    *(_OWORD *)&this->fields.shadowConfig.csmSimulatedAttenuation = v304;
		    *(_OWORD *)&this->fields.shadowConfig.rhodesShipCenter.z = v305;
		    sub_18002D1B0(
		      (SingleFieldAccessor *)&this->fields.shadowConfig.csmRampTexture,
		      (Type *)wrapperArray,
		      (PropertyInfo_1 *)method,
		      v3,
		      (MethodInfo *)v397);
		  }
		  if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGAnamorphicStreaksConfig>->rgctx_data )
		    sub_1800430B0(MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGAnamorphicStreaksConfig>);
		  if ( !TypeInfo::HG::Rendering::Runtime::HGAnamorphicStreaksConfig->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGAnamorphicStreaksConfig);
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  static_fields = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_284;
		  if ( wrapperArray[6] <= 1320 )
		    goto LABEL_228;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		  v370 = *(_QWORD *)wrapperArray;
		  if ( !*(_QWORD *)wrapperArray )
		    goto LABEL_284;
		  if ( *(_DWORD *)(v370 + 24) <= 0x528u )
		    goto LABEL_453;
		  if ( *(_QWORD *)(v370 + 10592) )
		  {
		    v371 = IFix::WrappersManagerImpl::GetPatch(1320, 0LL);
		    if ( !v371 )
		      goto LABEL_284;
		    v37 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_508(v371, &src->fields.anamorphicStreaksConfig, 0LL);
		  }
		  else
		  {
		LABEL_228:
		    v37 = src->fields.anamorphicStreaksConfig.m_active;
		  }
		  if ( v37 )
		  {
		    v372 = src->fields.anamorphicStreaksConfig.bloomTint;
		    v373 = *(_OWORD *)&src->fields.anamorphicStreaksConfig.blurIntensity;
		    *(_OWORD *)&this->fields.anamorphicStreaksConfig.enable = *(_OWORD *)&src->fields.anamorphicStreaksConfig.enable;
		    this->fields.anamorphicStreaksConfig.bloomTint = v372;
		    *(_OWORD *)&this->fields.anamorphicStreaksConfig.blurIntensity = v373;
		  }
		  if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGWaterEnvConfig>->rgctx_data )
		    sub_1800430B0(MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGWaterEnvConfig>);
		  if ( !TypeInfo::HG::Rendering::Runtime::HGWaterEnvConfig->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGWaterEnvConfig);
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  static_fields = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_284;
		  if ( wrapperArray[6] <= 1412 )
		    goto LABEL_239;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		  v374 = *(_QWORD *)wrapperArray;
		  if ( !*(_QWORD *)wrapperArray )
		    goto LABEL_284;
		  if ( *(_DWORD *)(v374 + 24) <= 0x584u )
		    goto LABEL_453;
		  if ( *(_QWORD *)(v374 + 11328) )
		  {
		    v375 = IFix::WrappersManagerImpl::GetPatch(1412, 0LL);
		    if ( !v375 )
		      goto LABEL_284;
		    v38 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_579(v375, &src->fields.waterEnvConfig, 0LL);
		  }
		  else
		  {
		LABEL_239:
		    v38 = src->fields.waterEnvConfig.m_active;
		  }
		  if ( v38 )
		  {
		    v376 = *(_DWORD *)&src->fields.waterEnvConfig.m_active;
		    *(_QWORD *)&this->fields.waterEnvConfig.enableWaterInteractionAdjust = *(_QWORD *)&src->fields.waterEnvConfig.enableWaterInteractionAdjust;
		    *(_DWORD *)&this->fields.waterEnvConfig.m_active = v376;
		  }
		  p_inkWashConfig = &this->fields.inkWashConfig;
		  v40 = &src->fields.inkWashConfig;
		  if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGInkWashConfig>->rgctx_data )
		    sub_1800430B0(MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::CopyConfig<HG::Rendering::Runtime::HGInkWashConfig>);
		  if ( !TypeInfo::HG::Rendering::Runtime::HGInkWashConfig->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGInkWashConfig);
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  static_fields = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_284;
		  if ( wrapperArray[6] <= 1374 )
		  {
		LABEL_250:
		    v41 = v40->m_active;
		    goto LABEL_251;
		  }
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  static_fields = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		  v377 = *static_fields;
		  if ( !*static_fields )
		LABEL_284:
		    sub_1800D8260(static_fields, wrapperArray);
		  if ( *(_DWORD *)(v377 + 24) <= 0x55Eu )
		LABEL_453:
		    sub_1800D2AB0(static_fields, wrapperArray);
		  if ( !*(_QWORD *)(v377 + 11024) )
		    goto LABEL_250;
		  v378 = IFix::WrappersManagerImpl::GetPatch(1374, 0LL);
		  if ( !v378 )
		    goto LABEL_284;
		  v41 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_548(v378, v40, 0LL);
		LABEL_251:
		  if ( v41 )
		  {
		    v379 = *(Color *)&v40->baseConfig.baseMat;
		    v397 = *(_OWORD *)&v40->enable;
		    v380 = *(_OWORD *)&v40->baseConfig.verticalFadeAffectDist;
		    v398 = v379;
		    v381 = *(_OWORD *)&v40->overlayConfig.overlayMat;
		    v399 = v380;
		    v382 = *(_OWORD *)&v40->overlayConfig.verticalFadeAffectDist;
		    v400 = v381;
		    v383 = *(_OWORD *)&v40->maskConfig.addNewInkDrop;
		    v401 = v382;
		    v384 = *(Color *)&v40->maskConfig.inkDropSize;
		    v402 = v383;
		    v385 = *(_OWORD *)&v40->maskConfig.currInkPointPos.y;
		    v403 = v384;
		    v386 = *(_OWORD *)&v40->maskConfig.currInkPointDir.z;
		    v404 = v385;
		    v387 = *(_OWORD *)&v40->maskConfig.edgeFade;
		    v405 = v386;
		    v406 = v387;
		    v388 = v398;
		    *(_OWORD *)&p_inkWashConfig->enable = v397;
		    v389 = v399;
		    *(Color *)&p_inkWashConfig->baseConfig.baseMat = v388;
		    v390 = v400;
		    *(_OWORD *)&p_inkWashConfig->baseConfig.verticalFadeAffectDist = v389;
		    v391 = v401;
		    *(_OWORD *)&p_inkWashConfig->overlayConfig.overlayMat = v390;
		    v392 = v402;
		    *(_OWORD *)&p_inkWashConfig->overlayConfig.verticalFadeAffectDist = v391;
		    v393 = v403;
		    *(_OWORD *)&p_inkWashConfig->maskConfig.addNewInkDrop = v392;
		    v394 = v404;
		    *(Color *)&p_inkWashConfig->maskConfig.inkDropSize = v393;
		    v395 = v405;
		    *(_OWORD *)&p_inkWashConfig->maskConfig.currInkPointPos.y = v394;
		    v396 = v406;
		    *(_OWORD *)&p_inkWashConfig->maskConfig.currInkPointDir.z = v395;
		    *(_OWORD *)&p_inkWashConfig->maskConfig.edgeFade = v396;
		    sub_18002D1B0(
		      (SingleFieldAccessor *)&p_inkWashConfig->baseConfig,
		      (Type *)wrapperArray,
		      (PropertyInfo_1 *)method,
		      v3,
		      (MethodInfo *)v397);
		  }
		}
		
		public void AssignFrom(HGEnvironmentPhase src) {} // 0x0000000183636A20-0x0000000183637C80
		// Void AssignFrom(HGEnvironmentPhase)
		void HG::Rendering::Runtime::HGEnvironmentPhase::AssignFrom(
		        HGEnvironmentPhase *this,
		        HGEnvironmentPhase *src,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rsi
		  ILFixDynamicMethodWrapper_2__Array *v7; // rsi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  HGLightConfig *p_lightConfig; // rcx
		  Color *v12; // rax
		  __int64 v13; // r9
		  __int64 v14; // rdx
		  Color directColor; // xmm0
		  Color v16; // xmm1
		  Color v17; // xmm0
		  Color v18; // xmm1
		  Color v19; // xmm0
		  Color v20; // xmm1
		  Color v21; // xmm0
		  Color v22; // xmm1
		  __int64 v23; // rdx
		  Color v24; // xmm1
		  Color v25; // xmm0
		  Color v26; // xmm1
		  Color v27; // xmm0
		  Color v28; // xmm1
		  Color v29; // xmm0
		  int32_t sunDiscPitchYawMode; // ecx
		  HGLightConfig *v31; // rcx
		  Color *v32; // rax
		  Color v33; // xmm0
		  Color v34; // xmm1
		  Color v35; // xmm0
		  Color v36; // xmm1
		  Color v37; // xmm0
		  Color v38; // xmm1
		  Color v39; // xmm0
		  Color v40; // xmm1
		  __int64 v41; // rdx
		  Color v42; // xmm1
		  Color v43; // xmm0
		  Color v44; // xmm1
		  Color v45; // xmm0
		  Color v46; // xmm1
		  Color v47; // xmm0
		  int32_t r_low; // eax
		  HGSkyConfig *p_skyConfig; // rax
		  __int128 *v50; // rcx
		  __int128 v51; // xmm0
		  __int128 v52; // xmm1
		  __int128 v53; // xmm0
		  __int128 v54; // xmm1
		  __int128 v55; // xmm0
		  __int128 v56; // xmm1
		  __int128 v57; // xmm0
		  __int128 v58; // xmm1
		  __int64 v59; // rdx
		  __int128 v60; // xmm1
		  __int128 v61; // xmm0
		  __int128 v62; // xmm1
		  __int128 v63; // xmm0
		  __int64 v64; // rax
		  HGSkyConfig *v65; // rcx
		  __int128 *v66; // rax
		  __int128 v67; // xmm0
		  __int128 v68; // xmm1
		  __int128 v69; // xmm0
		  __int128 v70; // xmm1
		  __int128 v71; // xmm0
		  __int128 v72; // xmm1
		  __int128 v73; // xmm0
		  __int128 v74; // xmm1
		  int v75; // r8d
		  __int128 v76; // xmm1
		  __int128 v77; // xmm0
		  __int128 v78; // xmm1
		  __int128 v79; // xmm0
		  __int64 v80; // rax
		  __int64 *v81; // rdx
		  signed __int64 v82; // rtt
		  __int128 v83; // xmm2
		  __int128 v84; // xmm3
		  Color rayleighScattering; // xmm4
		  __int64 v86; // xmm0_8
		  __int128 v87; // xmm5
		  __int128 v88; // xmm6
		  __int128 v89; // xmm7
		  __int128 v90; // xmm8
		  __int128 v91; // xmm9
		  int v92; // eax
		  __int128 v93; // xmm0
		  __int128 v94; // xmm2
		  __int128 v95; // xmm3
		  Color inscatterAmbientColor; // xmm4
		  __int64 v97; // rax
		  Color v98; // xmm1
		  __int128 v99; // xmm0
		  __int128 v100; // xmm1
		  __int128 v101; // xmm0
		  __int128 v102; // xmm1
		  Color heightFogDirectionalInscatteringMobile; // xmm0
		  __int128 v104; // xmm1
		  __int128 v105; // xmm0
		  __int128 v106; // xmm1
		  __int128 v107; // xmm0
		  __int128 v108; // xmm1
		  __int128 v109; // xmm0
		  Color v110; // xmm1
		  __int128 v111; // xmm0
		  __int128 v112; // xmm1
		  __int128 v113; // xmm0
		  __int128 v114; // xmm1
		  Color v115; // xmm0
		  __int128 v116; // xmm1
		  __int64 v117; // rax
		  __int128 v118; // xmm0
		  __int128 v119; // xmm1
		  __int128 v120; // xmm0
		  __int128 v121; // xmm1
		  __int128 v122; // xmm0
		  __int128 *v123; // rcx
		  HGVolumetricFogConfig *p_volumetricFogConfig; // rax
		  __int64 v125; // rdx
		  __int128 v126; // xmm0
		  __int128 v127; // xmm1
		  __int128 v128; // xmm0
		  __int128 v129; // xmm1
		  __int128 v130; // xmm0
		  __int128 v131; // xmm1
		  __int128 v132; // xmm0
		  __int128 v133; // xmm1
		  __int64 v134; // rdx
		  __int128 v135; // xmm1
		  __int128 v136; // xmm0
		  __int128 v137; // xmm1
		  __int128 v138; // xmm0
		  __int128 v139; // xmm1
		  __int128 v140; // xmm0
		  HGVolumetricFogConfig *v141; // rax
		  __int128 *v142; // rcx
		  __int128 v143; // xmm0
		  __int128 v144; // xmm1
		  __int128 v145; // xmm0
		  __int128 v146; // xmm1
		  __int128 v147; // xmm0
		  __int128 v148; // xmm1
		  __int128 v149; // xmm0
		  __int128 v150; // xmm1
		  __int128 v151; // xmm1
		  __int128 v152; // xmm0
		  __int128 v153; // xmm1
		  __int128 v154; // xmm0
		  __int128 v155; // xmm1
		  __int128 v156; // xmm0
		  __int64 *v157; // rdx
		  signed __int64 v158; // rtt
		  bool m_active; // cl
		  Color cloudTint; // xmm1
		  __int128 v161; // xmm0
		  __int128 v162; // xmm1
		  __int128 v163; // xmm0
		  __int128 v164; // xmm1
		  Color v165; // xmm0
		  __int128 v166; // xmm1
		  __int128 v167; // xmm0
		  __int128 v168; // xmm1
		  __int128 v169; // xmm0
		  Color v170; // xmm1
		  __int128 v171; // xmm0
		  __int128 v172; // xmm1
		  __int128 v173; // xmm0
		  __int128 v174; // xmm1
		  Color v175; // xmm0
		  __int128 v176; // xmm1
		  __int128 v177; // xmm0
		  __int128 v178; // xmm1
		  __int128 v179; // xmm0
		  __int64 *v180; // rdx
		  signed __int64 v181; // rtt
		  HGCelestialConfig *p_celestialConfig; // rax
		  __int64 v183; // rdx
		  __int128 *v184; // rcx
		  __int128 v185; // xmm0
		  __int128 v186; // xmm1
		  __int128 v187; // xmm0
		  __int128 v188; // xmm1
		  __int128 v189; // xmm0
		  __int128 v190; // xmm1
		  __int128 v191; // xmm0
		  __int128 v192; // xmm1
		  __int64 v193; // rdx
		  __int128 v194; // xmm1
		  __int128 v195; // xmm0
		  __int128 v196; // xmm1
		  __int128 v197; // xmm0
		  __int128 v198; // xmm1
		  Material *drawMaterial; // rax
		  HGCelestialConfig *v200; // rcx
		  __int128 *v201; // rax
		  __int128 v202; // xmm0
		  __int128 v203; // xmm1
		  __int128 v204; // xmm0
		  __int128 v205; // xmm1
		  __int128 v206; // xmm0
		  __int128 v207; // xmm1
		  __int128 v208; // xmm0
		  __int128 v209; // xmm1
		  __int128 v210; // xmm1
		  __int128 v211; // xmm0
		  __int128 v212; // xmm1
		  __int128 v213; // xmm0
		  __int128 v214; // xmm1
		  Material *v215; // rax
		  __int64 *v216; // rdx
		  signed __int64 v217; // rtt
		  __int64 v218; // xmm0_8
		  int v219; // eax
		  int v220; // eax
		  Color bloomTint; // xmm1
		  __int128 v222; // xmm2
		  int v223; // eax
		  __int64 v224; // xmm0_8
		  __int128 v225; // xmm2
		  __int128 v226; // xmm3
		  __int128 v227; // xmm4
		  __int128 v228; // xmm5
		  __int128 v229; // xmm6
		  __int128 v230; // xmm7
		  __int64 *v231; // rdx
		  signed __int64 v232; // rtt
		  HGRainConfig *p_rainConfig; // rax
		  __int64 v234; // rdx
		  __int128 *v235; // rcx
		  __int128 v236; // xmm0
		  __int128 v237; // xmm1
		  __int128 v238; // xmm0
		  __int128 v239; // xmm1
		  __int128 v240; // xmm0
		  __int128 v241; // xmm1
		  __int128 v242; // xmm0
		  __int128 v243; // xmm1
		  __int64 v244; // rdx
		  __int128 v245; // xmm1
		  __int128 v246; // xmm0
		  HGRainConfig *v247; // rax
		  __int128 *v248; // rcx
		  __int128 v249; // xmm0
		  __int128 v250; // xmm1
		  __int128 v251; // xmm0
		  __int128 v252; // xmm1
		  __int128 v253; // xmm0
		  __int128 v254; // xmm1
		  __int128 v255; // xmm0
		  __int128 v256; // xmm1
		  __int128 v257; // xmm1
		  __int128 v258; // xmm0
		  Color color; // xmm2
		  __int128 v260; // xmm3
		  __int128 v261; // xmm4
		  __int128 v262; // xmm5
		  __int128 v263; // xmm8
		  __int128 v264; // xmm9
		  __int128 v265; // xmm2
		  __int128 v266; // xmm3
		  __int128 v267; // xmm4
		  __int128 v268; // xmm5
		  __int128 v269; // xmm6
		  __int128 v270; // xmm7
		  __int64 *v271; // rdx
		  signed __int64 v272; // rtt
		  __int128 v273; // xmm1
		  __int128 v274; // xmm2
		  __int64 *v275; // rdx
		  signed __int64 v276; // rtt
		  HGColorGradingConfig *p_colorGradingConfig; // rax
		  __int64 v278; // rdx
		  __int128 *v279; // rcx
		  __int128 v280; // xmm0
		  __int128 v281; // xmm1
		  __int128 v282; // xmm0
		  __int128 v283; // xmm1
		  __int128 v284; // xmm0
		  __int128 v285; // xmm1
		  __int128 v286; // xmm0
		  __int128 v287; // xmm1
		  __int128 v288; // xmm1
		  __int128 v289; // xmm0
		  __int128 v290; // xmm1
		  __int128 v291; // xmm0
		  __int128 v292; // xmm1
		  __int128 v293; // xmm0
		  HGColorGradingConfig *v294; // rax
		  __int128 *v295; // rcx
		  __int128 v296; // xmm0
		  __int128 v297; // xmm1
		  __int128 v298; // xmm0
		  __int128 v299; // xmm1
		  __int128 v300; // xmm0
		  __int128 v301; // xmm1
		  __int128 v302; // xmm0
		  __int128 v303; // xmm1
		  __int128 v304; // xmm1
		  __int128 v305; // xmm0
		  __int128 v306; // xmm1
		  __int128 v307; // xmm0
		  __int128 v308; // xmm1
		  __int128 v309; // xmm0
		  __int64 *v310; // rdx
		  signed __int64 v311; // rtt
		  __int64 v312; // xmm0_8
		  int v313; // eax
		  __int128 v314; // xmm2
		  __int128 v315; // xmm3
		  __int128 v316; // xmm6
		  __int128 v317; // xmm7
		  __int128 v318; // xmm1
		  __int128 v319; // xmm2
		  __int128 v320; // xmm3
		  __int128 v321; // xmm4
		  __int128 v322; // xmm5
		  __int64 *v323; // rdx
		  signed __int64 v324; // rtt
		  Color v325; // xmm1
		  __int128 v326; // xmm2
		  int v327; // eax
		  Color v328; // xmm1
		  __int128 v329; // xmm0
		  __int128 v330; // xmm1
		  __int128 v331; // xmm0
		  __int128 v332; // xmm1
		  Color v333; // xmm0
		  __int128 v334; // xmm1
		  __int128 v335; // xmm0
		  __int128 v336; // xmm1
		  Color v337; // xmm1
		  __int128 v338; // xmm0
		  __int128 v339; // xmm1
		  __int128 v340; // xmm0
		  __int128 v341; // xmm1
		  Color v342; // xmm0
		  __int128 v343; // xmm1
		  __int128 v344; // xmm0
		  __int128 v345; // xmm1
		  unsigned int v346; // ebx
		  unsigned __int64 v347; // rax
		  char v348; // bl
		  __int64 *v349; // rdx
		  signed __int64 v350; // rtt
		  __int128 v351; // [rsp+20h] [rbp-1C8h] BYREF
		  Color v352; // [rsp+30h] [rbp-1B8h]
		  __int128 v353; // [rsp+40h] [rbp-1A8h]
		  __int128 v354; // [rsp+50h] [rbp-198h]
		  __int128 v355; // [rsp+60h] [rbp-188h]
		  __int128 v356; // [rsp+70h] [rbp-178h]
		  Color v357; // [rsp+80h] [rbp-168h]
		  __int128 v358; // [rsp+90h] [rbp-158h]
		  __int128 v359; // [rsp+A0h] [rbp-148h]
		  __int128 v360; // [rsp+B0h] [rbp-138h]
		  __int128 v361; // [rsp+C0h] [rbp-128h]
		  __int128 v362; // [rsp+D0h] [rbp-118h]
		  __int128 v363; // [rsp+E0h] [rbp-108h]
		  __int64 v364; // [rsp+F0h] [rbp-F8h]
		  int v365; // [rsp+F8h] [rbp-F0h]
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    sub_1800D8260(v5, src);
		  if ( wrapperArray->max_length.size <= 619 )
		    goto LABEL_12;
		  if ( !v5->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v5);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v7 = v5->static_fields->wrapperArray;
		  if ( !v7 )
		    sub_1800D8260(v5, src);
		  if ( v7->max_length.size <= 0x26Bu )
		    sub_1800D2AB0(v5, src);
		  if ( v7[17].vector[7] )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(619, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)src,
		      0LL);
		  }
		  else
		  {
		LABEL_12:
		    if ( !src )
		      sub_1800D8260(v5, src);
		    p_lightConfig = &src->fields.lightConfig;
		    v12 = (Color *)&v351;
		    v13 = 2LL;
		    v14 = 2LL;
		    do
		    {
		      v12 += 8;
		      directColor = p_lightConfig->directColor;
		      v16 = *(Color *)&p_lightConfig->directColorMode;
		      p_lightConfig = (HGLightConfig *)((char *)p_lightConfig + 128);
		      v12[-8] = directColor;
		      v17 = *(Color *)&p_lightConfig[-1].rotationAtmosphere.y;
		      v12[-7] = v16;
		      v18 = *(Color *)&p_lightConfig[-1].rotationLightShaft.y;
		      v12[-6] = v17;
		      v19 = *(Color *)&p_lightConfig[-1].rotationSunDisc.y;
		      v12[-5] = v18;
		      v20 = *(Color *)&p_lightConfig[-1].rotationLensFlare.y;
		      v12[-4] = v19;
		      v21 = *(Color *)&p_lightConfig[-1].rotationCloudShadow.y;
		      v12[-3] = v20;
		      v22 = *(Color *)&p_lightConfig[-1].rotationHeightFogDirectionalInscattering.y;
		      v12[-2] = v21;
		      v12[-1] = v22;
		      --v14;
		    }
		    while ( v14 );
		    v23 = 2LL;
		    v24 = *(Color *)&p_lightConfig->directColorMode;
		    *v12 = p_lightConfig->directColor;
		    v25 = *(Color *)&p_lightConfig->directCustomColor.a;
		    v12[1] = v24;
		    v26 = *(Color *)&p_lightConfig->directSpecularIntensity;
		    v12[2] = v25;
		    v27 = *(Color *)&p_lightConfig->directPitchYaw.y;
		    v12[3] = v26;
		    v28 = *(Color *)&p_lightConfig->indirectSpecularFactor;
		    v12[4] = v27;
		    v29 = *(Color *)&p_lightConfig->atmospherePitchYaw.y;
		    sunDiscPitchYawMode = p_lightConfig->sunDiscPitchYawMode;
		    v12[5] = v28;
		    v12[6] = v29;
		    LODWORD(v12[7].r) = sunDiscPitchYawMode;
		    v31 = &this->fields.lightConfig;
		    v32 = (Color *)&v351;
		    do
		    {
		      v31 = (HGLightConfig *)((char *)v31 + 128);
		      v33 = *v32;
		      v34 = v32[1];
		      v32 += 8;
		      *(Color *)&v31[-1].localToWorld.m12 = v33;
		      v35 = v32[-6];
		      *(Color *)&v31[-1].localToWorld.m13 = v34;
		      v36 = v32[-5];
		      *(Color *)&v31[-1].rotationAtmosphere.y = v35;
		      v37 = v32[-4];
		      *(Color *)&v31[-1].rotationLightShaft.y = v36;
		      v38 = v32[-3];
		      *(Color *)&v31[-1].rotationSunDisc.y = v37;
		      v39 = v32[-2];
		      *(Color *)&v31[-1].rotationLensFlare.y = v38;
		      v40 = v32[-1];
		      *(Color *)&v31[-1].rotationCloudShadow.y = v39;
		      *(Color *)&v31[-1].rotationHeightFogDirectionalInscattering.y = v40;
		      --v23;
		    }
		    while ( v23 );
		    v41 = 2LL;
		    v42 = v32[1];
		    v31->directColor = *v32;
		    v43 = v32[2];
		    *(Color *)&v31->directColorMode = v42;
		    v44 = v32[3];
		    *(Color *)&v31->directCustomColor.a = v43;
		    v45 = v32[4];
		    *(Color *)&v31->directSpecularIntensity = v44;
		    v46 = v32[5];
		    *(Color *)&v31->directPitchYaw.y = v45;
		    v47 = v32[6];
		    r_low = LODWORD(v32[7].r);
		    *(Color *)&v31->indirectSpecularFactor = v46;
		    *(Color *)&v31->atmospherePitchYaw.y = v47;
		    v31->sunDiscPitchYawMode = r_low;
		    p_skyConfig = &src->fields.skyConfig;
		    v50 = &v351;
		    do
		    {
		      v50 += 8;
		      v51 = *(_OWORD *)&p_skyConfig->parentEnvPhaseGuid;
		      v52 = *(_OWORD *)&p_skyConfig->skyDirectIntensity;
		      p_skyConfig = (HGSkyConfig *)((char *)p_skyConfig + 128);
		      *(v50 - 8) = v51;
		      v53 = *(_OWORD *)&p_skyConfig[-1].skyAmbientSH.shr7;
		      *(v50 - 7) = v52;
		      v54 = *(_OWORD *)&p_skyConfig[-1].skyAmbientSH.shg2;
		      *(v50 - 6) = v53;
		      v55 = *(_OWORD *)&p_skyConfig[-1].skyAmbientSH.shg6;
		      *(v50 - 5) = v54;
		      v56 = *(_OWORD *)&p_skyConfig[-1].skyAmbientSH.shb1;
		      *(v50 - 4) = v55;
		      v57 = *(_OWORD *)&p_skyConfig[-1].skyAmbientSH.shb5;
		      *(v50 - 3) = v56;
		      v58 = *(_OWORD *)&p_skyConfig[-1].skyboxCubeMap;
		      *(v50 - 2) = v57;
		      *(v50 - 1) = v58;
		      --v41;
		    }
		    while ( v41 );
		    v59 = 2LL;
		    v60 = *(_OWORD *)&p_skyConfig->skyDirectIntensity;
		    *v50 = *(_OWORD *)&p_skyConfig->parentEnvPhaseGuid;
		    v61 = *(_OWORD *)&p_skyConfig->customIVDefaultSH.shr2;
		    v50[1] = v60;
		    v62 = *(_OWORD *)&p_skyConfig->customIVDefaultSH.shr6;
		    v50[2] = v61;
		    v63 = *(_OWORD *)&p_skyConfig->customIVDefaultSH.shg1;
		    v64 = *(_QWORD *)&p_skyConfig->customIVDefaultSH.shg5;
		    v50[3] = v62;
		    v50[4] = v63;
		    *((_QWORD *)v50 + 10) = v64;
		    v65 = &this->fields.skyConfig;
		    v66 = &v351;
		    do
		    {
		      v65 = (HGSkyConfig *)((char *)v65 + 128);
		      v67 = *v66;
		      v68 = v66[1];
		      v66 += 8;
		      *(_OWORD *)&v65[-1].culloff = v67;
		      v69 = *(v66 - 6);
		      *(_OWORD *)&v65[-1].skyAmbientSH.shr3 = v68;
		      v70 = *(v66 - 5);
		      *(_OWORD *)&v65[-1].skyAmbientSH.shr7 = v69;
		      v71 = *(v66 - 4);
		      *(_OWORD *)&v65[-1].skyAmbientSH.shg2 = v70;
		      v72 = *(v66 - 3);
		      *(_OWORD *)&v65[-1].skyAmbientSH.shg6 = v71;
		      v73 = *(v66 - 2);
		      *(_OWORD *)&v65[-1].skyAmbientSH.shb1 = v72;
		      v74 = *(v66 - 1);
		      *(_OWORD *)&v65[-1].skyAmbientSH.shb5 = v73;
		      *(_OWORD *)&v65[-1].skyboxCubeMap = v74;
		      --v59;
		    }
		    while ( v59 );
		    v75 = dword_18F35FD08;
		    v76 = v66[1];
		    *(_OWORD *)&v65->parentEnvPhaseGuid = *v66;
		    v77 = v66[2];
		    *(_OWORD *)&v65->skyDirectIntensity = v76;
		    v78 = v66[3];
		    *(_OWORD *)&v65->customIVDefaultSH.shr2 = v77;
		    v79 = v66[4];
		    v80 = *((_QWORD *)v66 + 10);
		    *(_OWORD *)&v65->customIVDefaultSH.shr6 = v78;
		    *(_OWORD *)&v65->customIVDefaultSH.shg1 = v79;
		    *(_QWORD *)&v65->customIVDefaultSH.shg5 = v80;
		    if ( v75 )
		    {
		      v81 = &qword_18F0BCBA0[(((unsigned __int64)&this->fields.skyConfig >> 12) & 0x1FFFFF) >> 6];
		      _m_prefetchw(v81 + 36190);
		      do
		        v82 = v81[36190];
		      while ( v82 != _InterlockedCompareExchange64(
		                       v81 + 36190,
		                       v82 | (1LL << (((unsigned __int64)&this->fields.skyConfig >> 12) & 0x3F)),
		                       v82) );
		      v75 = dword_18F35FD08;
		    }
		    v83 = *(_OWORD *)&src->fields.atmosphereConfig.groundAlbedo.a;
		    v84 = *(_OWORD *)&src->fields.atmosphereConfig.outerSunIrradianceColor.a;
		    rayleighScattering = src->fields.atmosphereConfig.rayleighScattering;
		    v86 = *(_QWORD *)&src->fields.atmosphereConfig.tentWidth;
		    v87 = *(_OWORD *)&src->fields.atmosphereConfig.rayleighExponentialDistribution;
		    v88 = *(_OWORD *)&src->fields.atmosphereConfig.mieScattering.b;
		    v89 = *(_OWORD *)&src->fields.atmosphereConfig.mieAbsorption.g;
		    v90 = *(_OWORD *)&src->fields.atmosphereConfig.mieExponentialDistribution;
		    v91 = *(_OWORD *)&src->fields.atmosphereConfig.ozoneAbsorption.b;
		    *(_OWORD *)&this->fields.atmosphereConfig.groundRadius = *(_OWORD *)&src->fields.atmosphereConfig.groundRadius;
		    *(_OWORD *)&this->fields.atmosphereConfig.groundAlbedo.a = v83;
		    *(_OWORD *)&this->fields.atmosphereConfig.outerSunIrradianceColor.a = v84;
		    this->fields.atmosphereConfig.rayleighScattering = rayleighScattering;
		    *(_OWORD *)&this->fields.atmosphereConfig.rayleighExponentialDistribution = v87;
		    *(_OWORD *)&this->fields.atmosphereConfig.mieScattering.b = v88;
		    *(_OWORD *)&this->fields.atmosphereConfig.mieAbsorption.g = v89;
		    *(_OWORD *)&this->fields.atmosphereConfig.mieExponentialDistribution = v90;
		    *(_OWORD *)&this->fields.atmosphereConfig.ozoneAbsorption.b = v91;
		    *(_QWORD *)&this->fields.atmosphereConfig.tentWidth = v86;
		    v92 = *(_DWORD *)&src->fields.fogConfig.m_active;
		    v93 = *(_OWORD *)&src->fields.fogConfig.fallOffDistance;
		    v94 = *(_OWORD *)&src->fields.fogConfig.mieScattering.a;
		    v95 = *(_OWORD *)&src->fields.fogConfig.rayleighScattering.g;
		    inscatterAmbientColor = src->fields.fogConfig.inscatterAmbientColor;
		    *(_OWORD *)&this->fields.fogConfig.enable = *(_OWORD *)&src->fields.fogConfig.enable;
		    *(_OWORD *)&this->fields.fogConfig.fallOffDistance = v93;
		    *(_OWORD *)&this->fields.fogConfig.mieScattering.a = v94;
		    *(_OWORD *)&this->fields.fogConfig.rayleighScattering.g = v95;
		    this->fields.fogConfig.inscatterAmbientColor = inscatterAmbientColor;
		    *(_DWORD *)&this->fields.fogConfig.m_active = v92;
		    v97 = *(_QWORD *)&src->fields.heightFogConfig.flowNoiseDir.z;
		    v98 = *(Color *)&src->fields.heightFogConfig.heightFogStartHeightSecond;
		    v351 = *(_OWORD *)&src->fields.heightFogConfig.enable;
		    v99 = *(_OWORD *)&src->fields.heightFogConfig.heightFogInscatter.g;
		    v352 = v98;
		    v100 = *(_OWORD *)&src->fields.heightFogConfig.heightFogStartDistance;
		    v353 = v99;
		    v101 = *(_OWORD *)&src->fields.heightFogConfig.heightFogCullingFarClipPlane;
		    v354 = v100;
		    v102 = *(_OWORD *)&src->fields.heightFogConfig.heightFogDirectionalInscattering.g;
		    v355 = v101;
		    heightFogDirectionalInscatteringMobile = src->fields.heightFogConfig.heightFogDirectionalInscatteringMobile;
		    v356 = v102;
		    v104 = *(_OWORD *)&src->fields.heightFogConfig.enableVolumetricFog;
		    v357 = heightFogDirectionalInscatteringMobile;
		    v105 = *(_OWORD *)&src->fields.heightFogConfig.volumetricFogAlbedo.b;
		    v358 = v104;
		    v106 = *(_OWORD *)&src->fields.heightFogConfig.volumetricFogEmissive.b;
		    v359 = v105;
		    v107 = *(_OWORD *)&src->fields.heightFogConfig.volumetricFogStartDistance;
		    v360 = v106;
		    v108 = *(_OWORD *)&src->fields.heightFogConfig.enableFlowNoise;
		    v361 = v107;
		    v109 = *(_OWORD *)&src->fields.heightFogConfig.flowNoiseHorizontalDirAngle;
		    v362 = v108;
		    v363 = v109;
		    v364 = v97;
		    v365 = *(_DWORD *)&src->fields.heightFogConfig.m_active;
		    v110 = v352;
		    *(_OWORD *)&this->fields.heightFogConfig.enable = v351;
		    v111 = v353;
		    *(Color *)&this->fields.heightFogConfig.heightFogStartHeightSecond = v110;
		    v112 = v354;
		    *(_OWORD *)&this->fields.heightFogConfig.heightFogInscatter.g = v111;
		    v113 = v355;
		    *(_OWORD *)&this->fields.heightFogConfig.heightFogStartDistance = v112;
		    v114 = v356;
		    *(_OWORD *)&this->fields.heightFogConfig.heightFogCullingFarClipPlane = v113;
		    v115 = v357;
		    *(_OWORD *)&this->fields.heightFogConfig.heightFogDirectionalInscattering.g = v114;
		    v116 = v358;
		    v117 = v364;
		    this->fields.heightFogConfig.heightFogDirectionalInscatteringMobile = v115;
		    v118 = v359;
		    *(_OWORD *)&this->fields.heightFogConfig.enableVolumetricFog = v116;
		    v119 = v360;
		    *(_OWORD *)&this->fields.heightFogConfig.volumetricFogAlbedo.b = v118;
		    v120 = v361;
		    *(_OWORD *)&this->fields.heightFogConfig.volumetricFogEmissive.b = v119;
		    v121 = v362;
		    *(_OWORD *)&this->fields.heightFogConfig.volumetricFogStartDistance = v120;
		    v122 = v363;
		    *(_OWORD *)&this->fields.heightFogConfig.enableFlowNoise = v121;
		    *(_OWORD *)&this->fields.heightFogConfig.flowNoiseHorizontalDirAngle = v122;
		    *(_QWORD *)&this->fields.heightFogConfig.flowNoiseDir.z = v117;
		    v123 = &v351;
		    *(_DWORD *)&this->fields.heightFogConfig.m_active = v365;
		    p_volumetricFogConfig = &src->fields.volumetricFogConfig;
		    v125 = 2LL;
		    do
		    {
		      v123 += 8;
		      v126 = *(_OWORD *)&p_volumetricFogConfig->enable;
		      v127 = *(_OWORD *)&p_volumetricFogConfig->heightFogStartHeightSecond;
		      p_volumetricFogConfig = (HGVolumetricFogConfig *)((char *)p_volumetricFogConfig + 128);
		      *(v123 - 8) = v126;
		      v128 = *(_OWORD *)&p_volumetricFogConfig[-1].flowVLNoiseDir.y;
		      *(v123 - 7) = v127;
		      v129 = *(_OWORD *)&p_volumetricFogConfig[-1].flowVLNoisePerturb3DTexture;
		      *(v123 - 6) = v128;
		      v130 = *(_OWORD *)&p_volumetricFogConfig[-1].flowVLNoisePerturbSpeed.x;
		      *(v123 - 5) = v129;
		      v131 = *(_OWORD *)&p_volumetricFogConfig[-1].m_backupVLNoiseDistance;
		      *(v123 - 4) = v130;
		      v132 = *(_OWORD *)&p_volumetricFogConfig[-1].m_backupVLNoiseTillingScale.z;
		      *(v123 - 3) = v131;
		      v133 = *(_OWORD *)&p_volumetricFogConfig[-1].m_backupFlowVLNoiseRemapRange.x;
		      *(v123 - 2) = v132;
		      *(v123 - 1) = v133;
		      --v125;
		    }
		    while ( v125 );
		    v134 = 2LL;
		    v135 = *(_OWORD *)&p_volumetricFogConfig->heightFogStartHeightSecond;
		    *v123 = *(_OWORD *)&p_volumetricFogConfig->enable;
		    v136 = *(_OWORD *)&p_volumetricFogConfig->heightFogInscatter.g;
		    v123[1] = v135;
		    v137 = *(_OWORD *)&p_volumetricFogConfig->heightFogStartDistance;
		    v123[2] = v136;
		    v138 = *(_OWORD *)&p_volumetricFogConfig->heightFogDirectionalInscatteringExponent;
		    v123[3] = v137;
		    v139 = *(_OWORD *)&p_volumetricFogConfig->heightFogDirectionalInscattering.b;
		    v123[4] = v138;
		    v140 = *(_OWORD *)&p_volumetricFogConfig->heightFogDirectionalInscatteringMobile.g;
		    v141 = &this->fields.volumetricFogConfig;
		    v123[5] = v139;
		    v123[6] = v140;
		    v142 = &v351;
		    do
		    {
		      v141 = (HGVolumetricFogConfig *)((char *)v141 + 128);
		      v143 = *v142;
		      v144 = v142[1];
		      v142 += 8;
		      *(_OWORD *)&v141[-1].flowVLNoiseDistance = v143;
		      v145 = *(v142 - 6);
		      *(_OWORD *)&v141[-1].flowVLNoiseTillingScale.z = v144;
		      v146 = *(v142 - 5);
		      *(_OWORD *)&v141[-1].flowVLNoiseDir.y = v145;
		      v147 = *(v142 - 4);
		      *(_OWORD *)&v141[-1].flowVLNoisePerturb3DTexture = v146;
		      v148 = *(v142 - 3);
		      *(_OWORD *)&v141[-1].flowVLNoisePerturbSpeed.x = v147;
		      v149 = *(v142 - 2);
		      *(_OWORD *)&v141[-1].m_backupVLNoiseDistance = v148;
		      v150 = *(v142 - 1);
		      *(_OWORD *)&v141[-1].m_backupVLNoiseTillingScale.z = v149;
		      *(_OWORD *)&v141[-1].m_backupFlowVLNoiseRemapRange.x = v150;
		      --v134;
		    }
		    while ( v134 );
		    v151 = v142[1];
		    *(_OWORD *)&v141->enable = *v142;
		    v152 = v142[2];
		    *(_OWORD *)&v141->heightFogStartHeightSecond = v151;
		    v153 = v142[3];
		    *(_OWORD *)&v141->heightFogInscatter.g = v152;
		    v154 = v142[4];
		    *(_OWORD *)&v141->heightFogStartDistance = v153;
		    v155 = v142[5];
		    *(_OWORD *)&v141->heightFogDirectionalInscatteringExponent = v154;
		    v156 = v142[6];
		    *(_OWORD *)&v141->heightFogDirectionalInscattering.b = v155;
		    *(_OWORD *)&v141->heightFogDirectionalInscatteringMobile.g = v156;
		    if ( v75 )
		    {
		      v157 = &qword_18F0BCBA0[(((unsigned __int64)&this->fields.volumetricFogConfig.flowVLNoise3DTexture >> 12) & 0x1FFFFF) >> 6];
		      _m_prefetchw(v157 + 36190);
		      do
		        v158 = v157[36190];
		      while ( v158 != _InterlockedCompareExchange64(
		                        v157 + 36190,
		                        v158 | (1LL << (((unsigned __int64)&this->fields.volumetricFogConfig.flowVLNoise3DTexture >> 12) & 0x3F)),
		                        v158) );
		      v75 = dword_18F35FD08;
		    }
		    m_active = src->fields.volumetricCloudConfig.m_active;
		    *(_WORD *)&this->fields.volumetricCloudConfig.enabled = *(_WORD *)&src->fields.volumetricCloudConfig.enabled;
		    this->fields.volumetricCloudConfig.m_active = m_active;
		    cloudTint = src->fields.cloudConfig.cloudTint;
		    v351 = *(_OWORD *)&src->fields.cloudConfig.enable;
		    v161 = *(_OWORD *)&src->fields.cloudConfig.cloudContrast;
		    v352 = cloudTint;
		    v162 = *(_OWORD *)&src->fields.cloudConfig.brightnessAffectCloudAlpha;
		    v353 = v161;
		    v163 = *(_OWORD *)&src->fields.cloudConfig.cloudFlowType;
		    v354 = v162;
		    v164 = *(_OWORD *)&src->fields.cloudConfig.flowSpeed;
		    v355 = v163;
		    v165 = *(Color *)&src->fields.cloudConfig.lightShaftCloudMaskTexture;
		    v356 = v164;
		    v166 = *(_OWORD *)&src->fields.cloudConfig.cloudShadowConfig.cloudShadowTexture;
		    v357 = v165;
		    v167 = *(_OWORD *)&src->fields.cloudConfig.cloudShadowConfig.cloudShadowEnvCenter.z;
		    v358 = v166;
		    v168 = *(_OWORD *)&src->fields.cloudConfig.cloudShadowConfig.cloudShadowFlowDirection.y;
		    v359 = v167;
		    v169 = *(_OWORD *)&src->fields.cloudConfig.cloudShadowConfig.cloudShadowScaleEndDistance;
		    v360 = v168;
		    v361 = v169;
		    v170 = v352;
		    *(_OWORD *)&this->fields.cloudConfig.enable = v351;
		    v171 = v353;
		    this->fields.cloudConfig.cloudTint = v170;
		    v172 = v354;
		    *(_OWORD *)&this->fields.cloudConfig.cloudContrast = v171;
		    v173 = v355;
		    *(_OWORD *)&this->fields.cloudConfig.brightnessAffectCloudAlpha = v172;
		    v174 = v356;
		    *(_OWORD *)&this->fields.cloudConfig.cloudFlowType = v173;
		    v175 = v357;
		    *(_OWORD *)&this->fields.cloudConfig.flowSpeed = v174;
		    v176 = v358;
		    *(Color *)&this->fields.cloudConfig.lightShaftCloudMaskTexture = v175;
		    v177 = v359;
		    *(_OWORD *)&this->fields.cloudConfig.cloudShadowConfig.cloudShadowTexture = v176;
		    v178 = v360;
		    *(_OWORD *)&this->fields.cloudConfig.cloudShadowConfig.cloudShadowEnvCenter.z = v177;
		    v179 = v361;
		    *(_OWORD *)&this->fields.cloudConfig.cloudShadowConfig.cloudShadowFlowDirection.y = v178;
		    *(_OWORD *)&this->fields.cloudConfig.cloudShadowConfig.cloudShadowScaleEndDistance = v179;
		    if ( v75 )
		    {
		      v180 = &qword_18F0BCBA0[(((unsigned __int64)&this->fields.cloudConfig.cloudTexture >> 12) & 0x1FFFFF) >> 6];
		      _m_prefetchw(v180 + 36190);
		      do
		        v181 = v180[36190];
		      while ( v181 != _InterlockedCompareExchange64(
		                        v180 + 36190,
		                        v181 | (1LL << (((unsigned __int64)&this->fields.cloudConfig.cloudTexture >> 12) & 0x3F)),
		                        v181) );
		      v75 = dword_18F35FD08;
		    }
		    p_celestialConfig = &src->fields.celestialConfig;
		    v183 = 2LL;
		    v184 = &v351;
		    do
		    {
		      v184 += 8;
		      v185 = *(_OWORD *)&p_celestialConfig->moonConfig.radius;
		      v186 = *(_OWORD *)&p_celestialConfig->moonConfig.worldLongitude;
		      p_celestialConfig = (HGCelestialConfig *)((char *)p_celestialConfig + 128);
		      *(v184 - 8) = v185;
		      v187 = *(_OWORD *)&p_celestialConfig[-1].planetConfig.ring.outerRadius;
		      *(v184 - 7) = v186;
		      v188 = *(_OWORD *)&p_celestialConfig[-1].planetConfig.ring.ringColor.b;
		      *(v184 - 6) = v187;
		      v189 = *(_OWORD *)&p_celestialConfig[-1].planetConfig.enableAtmosphere;
		      *(v184 - 5) = v188;
		      v190 = *(_OWORD *)&p_celestialConfig[-1].planetConfig.atmosphere.numOpticalDepthSamplePoints;
		      *(v184 - 4) = v189;
		      v191 = *(_OWORD *)&p_celestialConfig[-1].planetConfig.atmosphere.atmosphereHueshift;
		      *(v184 - 3) = v190;
		      v192 = *(_OWORD *)&p_celestialConfig[-1].advancedPlanetConfig.advancedPlanetMat;
		      *(v184 - 2) = v191;
		      *(v184 - 1) = v192;
		      --v183;
		    }
		    while ( v183 );
		    v193 = 2LL;
		    v194 = *(_OWORD *)&p_celestialConfig->moonConfig.worldLongitude;
		    *v184 = *(_OWORD *)&p_celestialConfig->moonConfig.radius;
		    v195 = *(_OWORD *)&p_celestialConfig->moonConfig.ring.outerRadius;
		    v184[1] = v194;
		    v196 = *(_OWORD *)&p_celestialConfig->moonConfig.ring.ringColor.b;
		    v184[2] = v195;
		    v197 = *(_OWORD *)&p_celestialConfig->talosAlphaConfig.drawPlanetInSkydome;
		    v184[3] = v196;
		    v198 = *(_OWORD *)&p_celestialConfig->talosAlphaConfig.objectProperty.selfTiltZ;
		    drawMaterial = p_celestialConfig->talosAlphaConfig.skydomeDrawer.drawMaterial;
		    v184[4] = v197;
		    v184[5] = v198;
		    *((_QWORD *)v184 + 12) = drawMaterial;
		    v200 = &this->fields.celestialConfig;
		    v201 = &v351;
		    do
		    {
		      v200 = (HGCelestialConfig *)((char *)v200 + 128);
		      v202 = *v201;
		      v203 = v201[1];
		      v201 += 8;
		      *(_OWORD *)&v200[-1].planetConfig.skydomeDrawer.drawMaterial = v202;
		      v204 = *(v201 - 6);
		      *(_OWORD *)&v200[-1].planetConfig.skydomeDrawer.incidentLightingPitchYaw.x = v203;
		      v205 = *(v201 - 5);
		      *(_OWORD *)&v200[-1].planetConfig.ring.outerRadius = v204;
		      v206 = *(v201 - 4);
		      *(_OWORD *)&v200[-1].planetConfig.ring.ringColor.b = v205;
		      v207 = *(v201 - 3);
		      *(_OWORD *)&v200[-1].planetConfig.enableAtmosphere = v206;
		      v208 = *(v201 - 2);
		      *(_OWORD *)&v200[-1].planetConfig.atmosphere.numOpticalDepthSamplePoints = v207;
		      v209 = *(v201 - 1);
		      *(_OWORD *)&v200[-1].planetConfig.atmosphere.atmosphereHueshift = v208;
		      *(_OWORD *)&v200[-1].advancedPlanetConfig.advancedPlanetMat = v209;
		      --v193;
		    }
		    while ( v193 );
		    v210 = v201[1];
		    *(_OWORD *)&v200->moonConfig.radius = *v201;
		    v211 = v201[2];
		    *(_OWORD *)&v200->moonConfig.worldLongitude = v210;
		    v212 = v201[3];
		    *(_OWORD *)&v200->moonConfig.ring.outerRadius = v211;
		    v213 = v201[4];
		    *(_OWORD *)&v200->moonConfig.ring.ringColor.b = v212;
		    v214 = v201[5];
		    v215 = (Material *)*((_QWORD *)v201 + 12);
		    *(_OWORD *)&v200->talosAlphaConfig.drawPlanetInSkydome = v213;
		    *(_OWORD *)&v200->talosAlphaConfig.objectProperty.selfTiltZ = v214;
		    v200->talosAlphaConfig.skydomeDrawer.drawMaterial = v215;
		    if ( v75 )
		    {
		      v216 = &qword_18F0BCBA0[(((unsigned __int64)&this->fields.celestialConfig.moonConfig.ring.planetRingMap >> 12) & 0x1FFFFF) >> 6];
		      _m_prefetchw(v216 + 36190);
		      do
		        v217 = v216[36190];
		      while ( v217 != _InterlockedCompareExchange64(
		                        v216 + 36190,
		                        v217 | (1LL << (((unsigned __int64)&this->fields.celestialConfig.moonConfig.ring.planetRingMap >> 12) & 0x3F)),
		                        v217) );
		      v75 = dword_18F35FD08;
		    }
		    v218 = *(_QWORD *)&src->fields.windConfig.direction.y;
		    v219 = *(_DWORD *)&src->fields.windConfig.m_active;
		    *(_OWORD *)&this->fields.windConfig.speed = *(_OWORD *)&src->fields.windConfig.speed;
		    *(_QWORD *)&this->fields.windConfig.direction.y = v218;
		    *(_DWORD *)&this->fields.windConfig.m_active = v219;
		    v220 = *(_DWORD *)&src->fields.lightShaftConfig.m_active;
		    bloomTint = src->fields.lightShaftConfig.bloomTint;
		    v222 = *(_OWORD *)&src->fields.lightShaftConfig.blurIntensity;
		    *(_OWORD *)&this->fields.lightShaftConfig.enable = *(_OWORD *)&src->fields.lightShaftConfig.enable;
		    this->fields.lightShaftConfig.bloomTint = bloomTint;
		    *(_OWORD *)&this->fields.lightShaftConfig.blurIntensity = v222;
		    *(_DWORD *)&this->fields.lightShaftConfig.m_active = v220;
		    v223 = *(_DWORD *)&src->fields.terrainDeformConfig.m_active;
		    *(_QWORD *)&this->fields.terrainDeformConfig.deformGlobalStrength = *(_QWORD *)&src->fields.terrainDeformConfig.deformGlobalStrength;
		    *(_DWORD *)&this->fields.terrainDeformConfig.m_active = v223;
		    v224 = *(_QWORD *)&src->fields.inkSimulationConfig.resolvedShaderParams.idleForceChangeSpeed;
		    v225 = *(_OWORD *)&src->fields.inkSimulationConfig.inkRippleDensity;
		    v226 = *(_OWORD *)&src->fields.inkSimulationConfig.inkDebugJacobi;
		    v227 = *(_OWORD *)&src->fields.inkSimulationConfig.resolvedShaderParams.speedFactor;
		    v228 = *(_OWORD *)&src->fields.inkSimulationConfig.resolvedShaderParams.forceAngleRandom;
		    v229 = *(_OWORD *)&src->fields.inkSimulationConfig.resolvedShaderParams.landingInkSize;
		    v230 = *(_OWORD *)&src->fields.inkSimulationConfig.resolvedShaderParams.viscosity;
		    *(_OWORD *)&this->fields.inkSimulationConfig.influence = *(_OWORD *)&src->fields.inkSimulationConfig.influence;
		    *(_OWORD *)&this->fields.inkSimulationConfig.inkRippleDensity = v225;
		    *(_OWORD *)&this->fields.inkSimulationConfig.inkDebugJacobi = v226;
		    *(_OWORD *)&this->fields.inkSimulationConfig.resolvedShaderParams.speedFactor = v227;
		    *(_OWORD *)&this->fields.inkSimulationConfig.resolvedShaderParams.forceAngleRandom = v228;
		    *(_OWORD *)&this->fields.inkSimulationConfig.resolvedShaderParams.landingInkSize = v229;
		    *(_OWORD *)&this->fields.inkSimulationConfig.resolvedShaderParams.viscosity = v230;
		    *(_QWORD *)&this->fields.inkSimulationConfig.resolvedShaderParams.idleForceChangeSpeed = v224;
		    if ( v75 )
		    {
		      v231 = &qword_18F0BCBA0[(((unsigned __int64)&this->fields.inkSimulationConfig.shaderParams >> 12) & 0x1FFFFF) >> 6];
		      _m_prefetchw(v231 + 36190);
		      do
		        v232 = v231[36190];
		      while ( v232 != _InterlockedCompareExchange64(
		                        v231 + 36190,
		                        v232 | (1LL << (((unsigned __int64)&this->fields.inkSimulationConfig.shaderParams >> 12) & 0x3F)),
		                        v232) );
		      v75 = dword_18F35FD08;
		    }
		    p_rainConfig = &src->fields.rainConfig;
		    v234 = 2LL;
		    v235 = &v351;
		    do
		    {
		      v235 += 8;
		      v236 = *(_OWORD *)&p_rainConfig->enable;
		      v237 = *(_OWORD *)&p_rainConfig->color.g;
		      p_rainConfig = (HGRainConfig *)((char *)p_rainConfig + 128);
		      *(v235 - 8) = v236;
		      v238 = *(_OWORD *)&p_rainConfig[-1].baseWetnessLevel;
		      *(v235 - 7) = v237;
		      v239 = *(_OWORD *)&p_rainConfig[-1].verticalFlowSurfaceThreshold;
		      *(v235 - 6) = v238;
		      v240 = *(_OWORD *)&p_rainConfig[-1].rippleWaveSpeed;
		      *(v235 - 5) = v239;
		      v241 = *(_OWORD *)&p_rainConfig[-1].farSceneWetnessValue;
		      *(v235 - 4) = v240;
		      v242 = *(_OWORD *)&p_rainConfig[-1].rainDirection.z;
		      *(v235 - 3) = v241;
		      v243 = *(_OWORD *)&p_rainConfig[-1].farRainDirection.x;
		      *(v235 - 2) = v242;
		      *(v235 - 1) = v243;
		      --v234;
		    }
		    while ( v234 );
		    v244 = 2LL;
		    v245 = *(_OWORD *)&p_rainConfig->color.g;
		    *v235 = *(_OWORD *)&p_rainConfig->enable;
		    v246 = *(_OWORD *)&p_rainConfig->horizontalRainAngle;
		    v247 = &this->fields.rainConfig;
		    v235[1] = v245;
		    v235[2] = v246;
		    v248 = &v351;
		    do
		    {
		      v247 = (HGRainConfig *)((char *)v247 + 128);
		      v249 = *v248;
		      v250 = v248[1];
		      v248 += 8;
		      *(_OWORD *)&v247[-1].rainSplashAlpha = v249;
		      v251 = *(v248 - 6);
		      *(_OWORD *)&v247[-1].enableWetness = v250;
		      v252 = *(v248 - 5);
		      *(_OWORD *)&v247[-1].baseWetnessLevel = v251;
		      v253 = *(v248 - 4);
		      *(_OWORD *)&v247[-1].verticalFlowSurfaceThreshold = v252;
		      v254 = *(v248 - 3);
		      *(_OWORD *)&v247[-1].rippleWaveSpeed = v253;
		      v255 = *(v248 - 2);
		      *(_OWORD *)&v247[-1].farSceneWetnessValue = v254;
		      v256 = *(v248 - 1);
		      *(_OWORD *)&v247[-1].rainDirection.z = v255;
		      *(_OWORD *)&v247[-1].farRainDirection.x = v256;
		      --v244;
		    }
		    while ( v244 );
		    v257 = v248[1];
		    *(_OWORD *)&v247->enable = *v248;
		    v258 = v248[2];
		    *(_OWORD *)&v247->color.g = v257;
		    *(_OWORD *)&v247->horizontalRainAngle = v258;
		    *(_QWORD *)&v258 = *(_QWORD *)&src->fields.snowConfig.snowDirection.z;
		    color = src->fields.snowConfig.color;
		    v260 = *(_OWORD *)&src->fields.snowConfig.snowSizeRange.x;
		    v261 = *(_OWORD *)&src->fields.snowConfig.snowTrailLength;
		    v262 = *(_OWORD *)&src->fields.snowConfig.snowLightingPercent;
		    *(_OWORD *)&this->fields.snowConfig.enable = *(_OWORD *)&src->fields.snowConfig.enable;
		    this->fields.snowConfig.color = color;
		    *(_OWORD *)&this->fields.snowConfig.snowSizeRange.x = v260;
		    *(_OWORD *)&this->fields.snowConfig.snowTrailLength = v261;
		    *(_OWORD *)&this->fields.snowConfig.snowLightingPercent = v262;
		    *(_QWORD *)&this->fields.snowConfig.snowDirection.z = v258;
		    *(_QWORD *)&v258 = *(_QWORD *)&src->fields.starConfig.m_active;
		    v263 = *(_OWORD *)&src->fields.starConfig.nebulaMap;
		    v264 = *(_OWORD *)&src->fields.starConfig.nebulaTint.b;
		    v265 = *(_OWORD *)&src->fields.starConfig.minMaxRange.y;
		    v266 = *(_OWORD *)&src->fields.starConfig.starsTint.a;
		    v267 = *(_OWORD *)&src->fields.starConfig.starsTint1.a;
		    v268 = *(_OWORD *)&src->fields.starConfig.brightnessRandomSeed;
		    v269 = *(_OWORD *)&src->fields.starConfig.skyBoxStarRangeMap;
		    v270 = *(_OWORD *)&src->fields.starConfig.cloudRingStarCoverage;
		    *(_OWORD *)&this->fields.starConfig.enableStars = *(_OWORD *)&src->fields.starConfig.enableStars;
		    *(_OWORD *)&this->fields.starConfig.minMaxRange.y = v265;
		    *(_OWORD *)&this->fields.starConfig.starsTint.a = v266;
		    *(_OWORD *)&this->fields.starConfig.starsTint1.a = v267;
		    *(_OWORD *)&this->fields.starConfig.brightnessRandomSeed = v268;
		    *(_OWORD *)&this->fields.starConfig.skyBoxStarRangeMap = v269;
		    *(_OWORD *)&this->fields.starConfig.cloudRingStarCoverage = v270;
		    *(_OWORD *)&this->fields.starConfig.nebulaMap = v263;
		    *(_OWORD *)&this->fields.starConfig.nebulaTint.b = v264;
		    *(_QWORD *)&this->fields.starConfig.m_active = v258;
		    if ( v75 )
		    {
		      v271 = &qword_18F0BCBA0[(((unsigned __int64)&this->fields.starConfig.skyBoxStarRangeMap >> 12) & 0x1FFFFF) >> 6];
		      _m_prefetchw(v271 + 36190);
		      do
		        v272 = v271[36190];
		      while ( v272 != _InterlockedCompareExchange64(
		                        v271 + 36190,
		                        v272 | (1LL << (((unsigned __int64)&this->fields.starConfig.skyBoxStarRangeMap >> 12) & 0x3F)),
		                        v272) );
		      v75 = dword_18F35FD08;
		    }
		    v273 = *(_OWORD *)&src->fields.lensFlareConfig.intensity;
		    v274 = *(_OWORD *)&src->fields.lensFlareConfig.sampleCount;
		    *(_OWORD *)&this->fields.lensFlareConfig.enable = *(_OWORD *)&src->fields.lensFlareConfig.enable;
		    *(_OWORD *)&this->fields.lensFlareConfig.intensity = v273;
		    *(_OWORD *)&this->fields.lensFlareConfig.sampleCount = v274;
		    if ( v75 )
		    {
		      v275 = &qword_18F0BCBA0[(((unsigned __int64)&this->fields.lensFlareConfig.lensFlareData >> 12) & 0x1FFFFF) >> 6];
		      _m_prefetchw(v275 + 36190);
		      do
		        v276 = v275[36190];
		      while ( v276 != _InterlockedCompareExchange64(
		                        v275 + 36190,
		                        v276 | (1LL << (((unsigned __int64)&this->fields.lensFlareConfig.lensFlareData >> 12) & 0x3F)),
		                        v276) );
		      v75 = dword_18F35FD08;
		    }
		    p_colorGradingConfig = &src->fields.colorGradingConfig;
		    v278 = 2LL;
		    v279 = &v351;
		    do
		    {
		      v279 += 8;
		      v280 = *(_OWORD *)&p_colorGradingConfig->tonemappingMode;
		      v281 = *(_OWORD *)&p_colorGradingConfig->colorLookupContribution;
		      p_colorGradingConfig = (HGColorGradingConfig *)((char *)p_colorGradingConfig + 128);
		      *(v279 - 8) = v280;
		      v282 = *(_OWORD *)&p_colorGradingConfig[-1].splitToningHighlights.a;
		      *(v279 - 7) = v281;
		      v283 = *(_OWORD *)&p_colorGradingConfig[-1].colorCurves.master;
		      *(v279 - 6) = v282;
		      v284 = *(_OWORD *)&p_colorGradingConfig[-1].colorCurves.green;
		      *(v279 - 5) = v283;
		      v285 = *(_OWORD *)&p_colorGradingConfig[-1].colorCurves.hueVsHue;
		      *(v279 - 4) = v284;
		      v286 = *(_OWORD *)&p_colorGradingConfig[-1].colorCurves.satVsSat;
		      *(v279 - 3) = v285;
		      v287 = *(_OWORD *)&p_colorGradingConfig[-1].colorCurves.masterOverriding;
		      *(v279 - 2) = v286;
		      *(v279 - 1) = v287;
		      --v278;
		    }
		    while ( v278 );
		    v288 = *(_OWORD *)&p_colorGradingConfig->colorLookupContribution;
		    *v279 = *(_OWORD *)&p_colorGradingConfig->tonemappingMode;
		    v289 = *(_OWORD *)&p_colorGradingConfig->colorAdjustmentsEnabled;
		    v279[1] = v288;
		    v290 = *(_OWORD *)&p_colorGradingConfig->colorAdjustmentsColorFilter.g;
		    v279[2] = v289;
		    v291 = *(_OWORD *)&p_colorGradingConfig->colorAdjustmentsSaturation;
		    v279[3] = v290;
		    v292 = *(_OWORD *)&p_colorGradingConfig->channelMixerRedOutBlueIn;
		    v279[4] = v291;
		    v293 = *(_OWORD *)&p_colorGradingConfig->channelMixerBlueOutRedIn;
		    v294 = &this->fields.colorGradingConfig;
		    v279[5] = v292;
		    v279[6] = v293;
		    v295 = &v351;
		    do
		    {
		      v294 = (HGColorGradingConfig *)((char *)v294 + 128);
		      v296 = *v295;
		      v297 = v295[1];
		      v295 += 8;
		      *(_OWORD *)&v294[-1].splitToningEnabled = v296;
		      v298 = *(v295 - 6);
		      *(_OWORD *)&v294[-1].splitToningShadows.a = v297;
		      v299 = *(v295 - 5);
		      *(_OWORD *)&v294[-1].splitToningHighlights.a = v298;
		      v300 = *(v295 - 4);
		      *(_OWORD *)&v294[-1].colorCurves.master = v299;
		      v301 = *(v295 - 3);
		      *(_OWORD *)&v294[-1].colorCurves.green = v300;
		      v302 = *(v295 - 2);
		      *(_OWORD *)&v294[-1].colorCurves.hueVsHue = v301;
		      v303 = *(v295 - 1);
		      *(_OWORD *)&v294[-1].colorCurves.satVsSat = v302;
		      *(_OWORD *)&v294[-1].colorCurves.masterOverriding = v303;
		      --v13;
		    }
		    while ( v13 );
		    v304 = v295[1];
		    *(_OWORD *)&v294->tonemappingMode = *v295;
		    v305 = v295[2];
		    *(_OWORD *)&v294->colorLookupContribution = v304;
		    v306 = v295[3];
		    *(_OWORD *)&v294->colorAdjustmentsEnabled = v305;
		    v307 = v295[4];
		    *(_OWORD *)&v294->colorAdjustmentsColorFilter.g = v306;
		    v308 = v295[5];
		    *(_OWORD *)&v294->colorAdjustmentsSaturation = v307;
		    v309 = v295[6];
		    *(_OWORD *)&v294->channelMixerRedOutBlueIn = v308;
		    *(_OWORD *)&v294->channelMixerBlueOutRedIn = v309;
		    if ( v75 )
		    {
		      v310 = &qword_18F0BCBA0[(((unsigned __int64)&this->fields.colorGradingConfig.colorLookupTexture >> 12) & 0x1FFFFF) >> 6];
		      _m_prefetchw(v310 + 36190);
		      do
		        v311 = v310[36190];
		      while ( v311 != _InterlockedCompareExchange64(
		                        v310 + 36190,
		                        v311 | (1LL << (((unsigned __int64)&this->fields.colorGradingConfig.colorLookupTexture >> 12) & 0x3F)),
		                        v311) );
		      v75 = dword_18F35FD08;
		    }
		    v312 = *(_QWORD *)&src->fields.autoExposureConfig.autoExposureEvClampRange.y;
		    v313 = *(_DWORD *)&src->fields.autoExposureConfig.m_active;
		    v314 = *(_OWORD *)&src->fields.autoExposureConfig.autoExposureEv100Range.x;
		    v315 = *(_OWORD *)&src->fields.autoExposureConfig.autoExposureMeteringMode;
		    *(_OWORD *)&this->fields.autoExposureConfig.autoExposureMode = *(_OWORD *)&src->fields.autoExposureConfig.autoExposureMode;
		    *(_OWORD *)&this->fields.autoExposureConfig.autoExposureEv100Range.x = v314;
		    *(_OWORD *)&this->fields.autoExposureConfig.autoExposureMeteringMode = v315;
		    *(_QWORD *)&this->fields.autoExposureConfig.autoExposureEvClampRange.y = v312;
		    *(_DWORD *)&this->fields.autoExposureConfig.m_active = v313;
		    v316 = *(_OWORD *)&src->fields.shadowConfig.csmSimulatedAttenuation;
		    v317 = *(_OWORD *)&src->fields.shadowConfig.rhodesShipCenter.z;
		    v318 = *(_OWORD *)&src->fields.shadowConfig.csmIntensity;
		    v319 = *(_OWORD *)&src->fields.shadowConfig.csmShadowSoftness;
		    v320 = *(_OWORD *)&src->fields.shadowConfig.contactShadowSurfaceThickness;
		    v321 = *(_OWORD *)&src->fields.shadowConfig.overrideCsmFarDistance;
		    v322 = *(_OWORD *)&src->fields.shadowConfig.overrideCsmSpherePosition.z;
		    *(_OWORD *)&this->fields.shadowConfig.csmDepthBias = *(_OWORD *)&src->fields.shadowConfig.csmDepthBias;
		    *(_OWORD *)&this->fields.shadowConfig.csmIntensity = v318;
		    *(_OWORD *)&this->fields.shadowConfig.csmShadowSoftness = v319;
		    *(_OWORD *)&this->fields.shadowConfig.contactShadowSurfaceThickness = v320;
		    *(_OWORD *)&this->fields.shadowConfig.overrideCsmFarDistance = v321;
		    *(_OWORD *)&this->fields.shadowConfig.overrideCsmSpherePosition.z = v322;
		    *(_OWORD *)&this->fields.shadowConfig.csmSimulatedAttenuation = v316;
		    *(_OWORD *)&this->fields.shadowConfig.rhodesShipCenter.z = v317;
		    if ( v75 )
		    {
		      v323 = &qword_18F0BCBA0[(((unsigned __int64)&this->fields.shadowConfig.csmRampTexture >> 12) & 0x1FFFFF) >> 6];
		      _m_prefetchw(v323 + 36190);
		      do
		        v324 = v323[36190];
		      while ( v324 != _InterlockedCompareExchange64(
		                        v323 + 36190,
		                        v324 | (1LL << (((unsigned __int64)&this->fields.shadowConfig.csmRampTexture >> 12) & 0x3F)),
		                        v324) );
		      v75 = dword_18F35FD08;
		    }
		    v325 = src->fields.anamorphicStreaksConfig.bloomTint;
		    v326 = *(_OWORD *)&src->fields.anamorphicStreaksConfig.blurIntensity;
		    *(_OWORD *)&this->fields.anamorphicStreaksConfig.enable = *(_OWORD *)&src->fields.anamorphicStreaksConfig.enable;
		    this->fields.anamorphicStreaksConfig.bloomTint = v325;
		    *(_OWORD *)&this->fields.anamorphicStreaksConfig.blurIntensity = v326;
		    v327 = *(_DWORD *)&src->fields.waterEnvConfig.m_active;
		    *(_QWORD *)&this->fields.waterEnvConfig.enableWaterInteractionAdjust = *(_QWORD *)&src->fields.waterEnvConfig.enableWaterInteractionAdjust;
		    *(_DWORD *)&this->fields.waterEnvConfig.m_active = v327;
		    v328 = *(Color *)&src->fields.inkWashConfig.baseConfig.baseMat;
		    v351 = *(_OWORD *)&src->fields.inkWashConfig.enable;
		    v329 = *(_OWORD *)&src->fields.inkWashConfig.baseConfig.verticalFadeAffectDist;
		    v352 = v328;
		    v330 = *(_OWORD *)&src->fields.inkWashConfig.overlayConfig.overlayMat;
		    v353 = v329;
		    v331 = *(_OWORD *)&src->fields.inkWashConfig.overlayConfig.verticalFadeAffectDist;
		    v354 = v330;
		    v332 = *(_OWORD *)&src->fields.inkWashConfig.maskConfig.addNewInkDrop;
		    v355 = v331;
		    v333 = *(Color *)&src->fields.inkWashConfig.maskConfig.inkDropSize;
		    v356 = v332;
		    v334 = *(_OWORD *)&src->fields.inkWashConfig.maskConfig.currInkPointPos.y;
		    v357 = v333;
		    v335 = *(_OWORD *)&src->fields.inkWashConfig.maskConfig.currInkPointDir.z;
		    v358 = v334;
		    v336 = *(_OWORD *)&src->fields.inkWashConfig.maskConfig.edgeFade;
		    v359 = v335;
		    v360 = v336;
		    v337 = v352;
		    *(_OWORD *)&this->fields.inkWashConfig.enable = v351;
		    v338 = v353;
		    *(Color *)&this->fields.inkWashConfig.baseConfig.baseMat = v337;
		    v339 = v354;
		    *(_OWORD *)&this->fields.inkWashConfig.baseConfig.verticalFadeAffectDist = v338;
		    v340 = v355;
		    *(_OWORD *)&this->fields.inkWashConfig.overlayConfig.overlayMat = v339;
		    v341 = v356;
		    *(_OWORD *)&this->fields.inkWashConfig.overlayConfig.verticalFadeAffectDist = v340;
		    v342 = v357;
		    *(_OWORD *)&this->fields.inkWashConfig.maskConfig.addNewInkDrop = v341;
		    v343 = v358;
		    *(Color *)&this->fields.inkWashConfig.maskConfig.inkDropSize = v342;
		    v344 = v359;
		    *(_OWORD *)&this->fields.inkWashConfig.maskConfig.currInkPointPos.y = v343;
		    v345 = v360;
		    *(_OWORD *)&this->fields.inkWashConfig.maskConfig.currInkPointDir.z = v344;
		    *(_OWORD *)&this->fields.inkWashConfig.maskConfig.edgeFade = v345;
		    if ( v75 )
		    {
		      v346 = ((unsigned __int64)&this->fields.inkWashConfig.baseConfig >> 12) & 0x1FFFFF;
		      v347 = (unsigned __int64)v346 >> 6;
		      v348 = v346 & 0x3F;
		      v349 = &qword_18F0BCBA0[v347];
		      _m_prefetchw(v349 + 36190);
		      do
		        v350 = v349[36190];
		      while ( v350 != _InterlockedCompareExchange64(v349 + 36190, v350 | (1LL << v348), v350) );
		    }
		  }
		}
		
		public void Lerp(HGEnvironmentPhase a, HGEnvironmentPhase b, float t) {} // 0x0000000183A493B0-0x0000000183A4A690
		// Void Lerp(HGEnvironmentPhase, HGEnvironmentPhase, Single)
		void HG::Rendering::Runtime::HGEnvironmentPhase::Lerp(
		        HGEnvironmentPhase *this,
		        HGEnvironmentPhase *a,
		        HGEnvironmentPhase *b,
		        float t,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  struct MethodInfo *v11; // r13
		  bool m_active; // al
		  bool v13; // al
		  __int128 v14; // xmm0
		  int v15; // eax
		  __int128 v16; // xmm1
		  __int128 v17; // xmm2
		  __int128 v18; // xmm3
		  Color inscatterAmbientColor; // xmm4
		  struct MethodInfo *v20; // r13
		  bool v21; // al
		  bool v22; // al
		  __int16 v23; // ax
		  bool v24; // cl
		  PropertyInfo_1 *v25; // r8
		  Int32__Array **v26; // r9
		  struct MethodInfo *v27; // r13
		  bool v28; // al
		  bool v29; // al
		  __int128 v30; // xmm1
		  int v31; // eax
		  __int64 v32; // xmm0_8
		  struct MethodInfo *v33; // r15
		  bool v34; // al
		  bool v35; // al
		  __int128 v36; // xmm0
		  int v37; // eax
		  Color bloomTint; // xmm1
		  __int128 v39; // xmm2
		  struct MethodInfo *v40; // r15
		  bool v41; // al
		  bool v42; // al
		  int v43; // eax
		  __int64 v44; // xmm0_8
		  struct MethodInfo *v45; // r13
		  bool v46; // al
		  bool v47; // al
		  __int128 v48; // xmm1
		  __int128 v49; // xmm2
		  __int128 v50; // xmm3
		  __int128 v51; // xmm4
		  __int128 v52; // xmm5
		  __int128 v53; // xmm6
		  __int128 v54; // xmm7
		  __int64 v55; // xmm0_8
		  struct MethodInfo *v56; // r13
		  bool v57; // al
		  bool v58; // al
		  __int128 v59; // xmm1
		  Color color; // xmm2
		  __int128 v61; // xmm3
		  __int128 v62; // xmm4
		  __int128 v63; // xmm5
		  __int64 v64; // xmm0_8
		  PropertyInfo_1 *v65; // r8
		  Int32__Array **v66; // r9
		  struct MethodInfo *v67; // r13
		  bool v68; // al
		  bool v69; // al
		  __int128 v70; // xmm0
		  __int128 v71; // xmm1
		  __int128 v72; // xmm2
		  struct MethodInfo *v73; // r13
		  bool v74; // al
		  bool v75; // al
		  __int128 v76; // xmm1
		  int v77; // eax
		  __int128 v78; // xmm2
		  __int128 v79; // xmm3
		  __int64 v80; // xmm0_8
		  struct MethodInfo *v81; // r13
		  bool v82; // al
		  bool v83; // al
		  __int128 v84; // xmm0
		  Color v85; // xmm1
		  __int128 v86; // xmm2
		  struct MethodInfo *v87; // r13
		  bool v88; // al
		  bool v89; // al
		  int v90; // eax
		  __int64 v91; // xmm0_8
		  ILFixDynamicMethodWrapper_2 *v92; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ILFixDynamicMethodWrapper_2 *v94; // rax
		  ILFixDynamicMethodWrapper_2 *v95; // rax
		  ILFixDynamicMethodWrapper_2 *v96; // rax
		  ILFixDynamicMethodWrapper_2 *v97; // rax
		  ILFixDynamicMethodWrapper_2 *v98; // rax
		  ILFixDynamicMethodWrapper_2 *v99; // rax
		  ILFixDynamicMethodWrapper_2 *v100; // rax
		  ILFixDynamicMethodWrapper_2 *v101; // rax
		  ILFixDynamicMethodWrapper_2 *v102; // rax
		  ILFixDynamicMethodWrapper_2 *v103; // rax
		  ILFixDynamicMethodWrapper_2 *v104; // rax
		  ILFixDynamicMethodWrapper_2 *v105; // rax
		  ILFixDynamicMethodWrapper_2 *v106; // rax
		  ILFixDynamicMethodWrapper_2 *v107; // rax
		  ILFixDynamicMethodWrapper_2 *v108; // rax
		  ILFixDynamicMethodWrapper_2 *v109; // rax
		  ILFixDynamicMethodWrapper_2 *v110; // rax
		  ILFixDynamicMethodWrapper_2 *v111; // rax
		  ILFixDynamicMethodWrapper_2 *v112; // rax
		  ILFixDynamicMethodWrapper_2 *v113; // rax
		  ILFixDynamicMethodWrapper_2 *v114; // rax
		  MethodInfo *P3; // [rsp+20h] [rbp-78h]
		  MethodInfo *P3a; // [rsp+20h] [rbp-78h]
		
		  v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v6->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_246;
		  if ( wrapperArray->max_length.size <= 635 )
		    goto LABEL_536;
		  if ( !v6->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v6);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v6->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_246;
		  if ( wrapperArray->max_length.size <= 0x27Bu )
		    goto LABEL_525;
		  if ( !wrapperArray[17].vector[23] )
		  {
		LABEL_536:
		    if ( !a || !b )
		      goto LABEL_246;
		    sub_183A6E310(
		      &this->fields.lightConfig,
		      (HGWindConfig *)&a->fields.lightConfig,
		      (HGWindConfig *)&b->fields.lightConfig,
		      (__int64)MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGLightConfig>);
		    sub_183A567D0(
		      &this->fields.skyConfig,
		      (HGWindConfig *)&a->fields.skyConfig,
		      (HGWindConfig *)&b->fields.skyConfig,
		      (__int64)MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGSkyConfig>);
		    sub_183B5A2C0(
		      &this->fields.atmosphereConfig,
		      (HGWindConfig *)&a->fields.atmosphereConfig,
		      (HGWindConfig *)&b->fields.atmosphereConfig,
		      (__int64)MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGAtmosphereConfig>);
		    v11 = MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGFogConfig>;
		    if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGFogConfig>->rgctx_data )
		      sub_1800430B0(MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGFogConfig>);
		    if ( !TypeInfo::HG::Rendering::Runtime::HGFogConfig->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGFogConfig);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v6->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_246;
		    if ( wrapperArray->max_length.size <= 1364 )
		      goto LABEL_15;
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v6->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_246;
		    if ( wrapperArray->max_length.size <= 0x554u )
		      goto LABEL_525;
		    if ( wrapperArray[38].klass )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(1364, 0LL);
		      if ( !Patch )
		        goto LABEL_246;
		      m_active = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_540(Patch, &a->fields.fogConfig, 0LL);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    else
		    {
		LABEL_15:
		      m_active = a->fields.fogConfig.m_active;
		    }
		    if ( !m_active )
		    {
		      if ( !TypeInfo::HG::Rendering::Runtime::HGFogConfig->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGFogConfig);
		      if ( !HG::Rendering::Runtime::HGFogConfig::get_active(
		              &b->fields.fogConfig,
		              (MethodInfo *)v11->rgctx_data[1].rgctxDataDummy) )
		        goto LABEL_29;
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    if ( t == 0.0 )
		      goto LABEL_278;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGFogConfig->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGFogConfig);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v6->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_246;
		    if ( wrapperArray->max_length.size <= 1364 )
		      goto LABEL_24;
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v6->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_246;
		    if ( wrapperArray->max_length.size <= 0x554u )
		      goto LABEL_525;
		    if ( wrapperArray[38].klass )
		    {
		      v94 = IFix::WrappersManagerImpl::GetPatch(1364, 0LL);
		      if ( !v94 )
		        goto LABEL_246;
		      v13 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_540(v94, &b->fields.fogConfig, 0LL);
		    }
		    else
		    {
		LABEL_24:
		      v13 = b->fields.fogConfig.m_active;
		    }
		    if ( !v13 )
		    {
		LABEL_278:
		      v14 = *(_OWORD *)&a->fields.fogConfig.enable;
		      v15 = *(_DWORD *)&a->fields.fogConfig.m_active;
		      v16 = *(_OWORD *)&a->fields.fogConfig.fallOffDistance;
		      v17 = *(_OWORD *)&a->fields.fogConfig.mieScattering.a;
		      v18 = *(_OWORD *)&a->fields.fogConfig.rayleighScattering.g;
		      inscatterAmbientColor = a->fields.fogConfig.inscatterAmbientColor;
		    }
		    else
		    {
		      if ( t < (float)(1.0 - TypeInfo::UnityEngine::Mathf->static_fields->Epsilon) )
		      {
		        if ( !TypeInfo::HG::Rendering::Runtime::HGFogConfig->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGFogConfig);
		        if ( HG::Rendering::Runtime::HGFogConfig::get_active(
		               &a->fields.fogConfig,
		               (MethodInfo *)v11->rgctx_data[1].rgctxDataDummy) )
		        {
		          if ( !TypeInfo::HG::Rendering::Runtime::HGFogConfig->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGFogConfig);
		          HG::Rendering::Runtime::HGFogConfig::set_active(
		            &this->fields.fogConfig,
		            1,
		            (MethodInfo *)v11->rgctx_data[2].rgctxDataDummy);
		          HG::Rendering::Runtime::HGFogConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
		            &this->fields.fogConfig,
		            (HGWindConfig *)&a->fields.fogConfig,
		            (HGWindConfig *)&b->fields.fogConfig,
		            t,
		            (MethodInfo *)v11->rgctx_data[3].rgctxDataDummy);
		          goto LABEL_29;
		        }
		      }
		      v14 = *(_OWORD *)&b->fields.fogConfig.enable;
		      v15 = *(_DWORD *)&b->fields.fogConfig.m_active;
		      v16 = *(_OWORD *)&b->fields.fogConfig.fallOffDistance;
		      v17 = *(_OWORD *)&b->fields.fogConfig.mieScattering.a;
		      v18 = *(_OWORD *)&b->fields.fogConfig.rayleighScattering.g;
		      inscatterAmbientColor = b->fields.fogConfig.inscatterAmbientColor;
		    }
		    *(_OWORD *)&this->fields.fogConfig.enable = v14;
		    *(_OWORD *)&this->fields.fogConfig.fallOffDistance = v16;
		    *(_OWORD *)&this->fields.fogConfig.mieScattering.a = v17;
		    *(_OWORD *)&this->fields.fogConfig.rayleighScattering.g = v18;
		    this->fields.fogConfig.inscatterAmbientColor = inscatterAmbientColor;
		    *(_DWORD *)&this->fields.fogConfig.m_active = v15;
		LABEL_29:
		    sub_183AAD700(
		      &this->fields.heightFogConfig,
		      (HGWindConfig *)&a->fields.heightFogConfig,
		      (HGWindConfig *)&b->fields.heightFogConfig,
		      (__int64)MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGHeightFogConfig>);
		    sub_183A6E7C0(
		      &this->fields.volumetricFogConfig,
		      (HGWindConfig *)&a->fields.volumetricFogConfig,
		      (HGWindConfig *)&b->fields.volumetricFogConfig,
		      (__int64)MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGVolumetricFogConfig>);
		    v20 = MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGVolumetricCloudConfig>;
		    if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGVolumetricCloudConfig>->rgctx_data )
		      sub_1800430B0(MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGVolumetricCloudConfig>);
		    if ( !TypeInfo::HG::Rendering::Runtime::HGVolumetricCloudConfig->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGVolumetricCloudConfig);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v6->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_246;
		    if ( wrapperArray->max_length.size <= 1407 )
		      goto LABEL_37;
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v6->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_246;
		    if ( wrapperArray->max_length.size <= 0x57Fu )
		      goto LABEL_525;
		    if ( wrapperArray[39].vector[3] )
		    {
		      v95 = IFix::WrappersManagerImpl::GetPatch(1407, 0LL);
		      if ( !v95 )
		        goto LABEL_246;
		      v21 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_576(v95, &a->fields.volumetricCloudConfig, 0LL);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    else
		    {
		LABEL_37:
		      v21 = a->fields.volumetricCloudConfig.m_active;
		    }
		    if ( !v21 )
		    {
		      if ( !TypeInfo::HG::Rendering::Runtime::HGVolumetricCloudConfig->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGVolumetricCloudConfig);
		      if ( !HG::Rendering::Runtime::HGVolumetricCloudConfig::get_active(
		              &b->fields.volumetricCloudConfig,
		              (MethodInfo *)v20->rgctx_data[1].rgctxDataDummy) )
		        goto LABEL_50;
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    if ( t == 0.0 )
		      goto LABEL_48;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGVolumetricCloudConfig->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGVolumetricCloudConfig);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v6->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_246;
		    if ( wrapperArray->max_length.size <= 1407 )
		      goto LABEL_46;
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v6->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_246;
		    if ( wrapperArray->max_length.size <= 0x57Fu )
		      goto LABEL_525;
		    if ( wrapperArray[39].vector[3] )
		    {
		      v96 = IFix::WrappersManagerImpl::GetPatch(1407, 0LL);
		      if ( !v96 )
		        goto LABEL_246;
		      v22 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_576(v96, &b->fields.volumetricCloudConfig, 0LL);
		    }
		    else
		    {
		LABEL_46:
		      v22 = b->fields.volumetricCloudConfig.m_active;
		    }
		    if ( v22 )
		    {
		      if ( t < (float)(1.0 - TypeInfo::UnityEngine::Mathf->static_fields->Epsilon) )
		      {
		        if ( !TypeInfo::HG::Rendering::Runtime::HGVolumetricCloudConfig->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGVolumetricCloudConfig);
		        if ( HG::Rendering::Runtime::HGVolumetricCloudConfig::get_active(
		               &a->fields.volumetricCloudConfig,
		               (MethodInfo *)v20->rgctx_data[1].rgctxDataDummy) )
		        {
		          if ( !TypeInfo::HG::Rendering::Runtime::HGVolumetricCloudConfig->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGVolumetricCloudConfig);
		          HG::Rendering::Runtime::HGVolumetricCloudConfig::set_active(
		            &this->fields.volumetricCloudConfig,
		            1,
		            (MethodInfo *)v20->rgctx_data[2].rgctxDataDummy);
		          HG::Rendering::Runtime::HGVolumetricCloudConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
		            &this->fields.volumetricCloudConfig,
		            (HGWindConfig *)&a->fields.volumetricCloudConfig,
		            (HGWindConfig *)&b->fields.volumetricCloudConfig,
		            t,
		            (MethodInfo *)v20->rgctx_data[3].rgctxDataDummy);
		          goto LABEL_50;
		        }
		      }
		      v23 = *(_WORD *)&b->fields.volumetricCloudConfig.enabled;
		      v24 = b->fields.volumetricCloudConfig.m_active;
		    }
		    else
		    {
		LABEL_48:
		      v23 = *(_WORD *)&a->fields.volumetricCloudConfig.enabled;
		      v24 = a->fields.volumetricCloudConfig.m_active;
		    }
		    *(_WORD *)&this->fields.volumetricCloudConfig.enabled = v23;
		    this->fields.volumetricCloudConfig.m_active = v24;
		LABEL_50:
		    sub_183ADDD40(
		      &this->fields.cloudConfig,
		      (HGWindConfig *)&a->fields.cloudConfig,
		      (HGWindConfig *)&b->fields.cloudConfig,
		      (__int64)MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGCloudConfig>);
		    sub_183A6EAE0(
		      &this->fields.celestialConfig,
		      (HGWindConfig *)&a->fields.celestialConfig,
		      (HGWindConfig *)&b->fields.celestialConfig,
		      (__int64)MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGCelestialConfig>);
		    v27 = MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGWindConfig>;
		    if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGWindConfig>->rgctx_data )
		      sub_1800430B0(MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGWindConfig>);
		    if ( !TypeInfo::HG::Rendering::Runtime::HGWindConfig->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGWindConfig);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v6->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_246;
		    if ( wrapperArray->max_length.size <= 1414 )
		      goto LABEL_58;
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v6->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_246;
		    if ( wrapperArray->max_length.size <= 0x586u )
		      goto LABEL_525;
		    if ( wrapperArray[39].vector[10] )
		    {
		      v97 = IFix::WrappersManagerImpl::GetPatch(1414, 0LL);
		      if ( !v97 )
		        goto LABEL_246;
		      v28 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_581(v97, &a->fields.windConfig, 0LL);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    else
		    {
		LABEL_58:
		      v28 = a->fields.windConfig.m_active;
		    }
		    if ( !v28 )
		    {
		      if ( !TypeInfo::HG::Rendering::Runtime::HGWindConfig->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGWindConfig);
		      if ( !HG::Rendering::Runtime::HGWindConfig::get_active(
		              &b->fields.windConfig,
		              (MethodInfo *)v27->rgctx_data[1].rgctxDataDummy) )
		        goto LABEL_72;
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    if ( t == 0.0 )
		      goto LABEL_329;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGWindConfig->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGWindConfig);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v6->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_246;
		    if ( wrapperArray->max_length.size <= 1414 )
		      goto LABEL_67;
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v6->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_246;
		    if ( wrapperArray->max_length.size <= 0x586u )
		      goto LABEL_525;
		    if ( wrapperArray[39].vector[10] )
		    {
		      v98 = IFix::WrappersManagerImpl::GetPatch(1414, 0LL);
		      if ( !v98 )
		        goto LABEL_246;
		      v29 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_581(v98, &b->fields.windConfig, 0LL);
		    }
		    else
		    {
		LABEL_67:
		      v29 = b->fields.windConfig.m_active;
		    }
		    if ( !v29 )
		    {
		LABEL_329:
		      v30 = *(_OWORD *)&a->fields.windConfig.speed;
		      v31 = *(_DWORD *)&a->fields.windConfig.m_active;
		      v32 = *(_QWORD *)&a->fields.windConfig.direction.y;
		    }
		    else
		    {
		      if ( t < (float)(1.0 - TypeInfo::UnityEngine::Mathf->static_fields->Epsilon) )
		      {
		        if ( !TypeInfo::HG::Rendering::Runtime::HGWindConfig->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGWindConfig);
		        if ( HG::Rendering::Runtime::HGWindConfig::get_active(
		               &a->fields.windConfig,
		               (MethodInfo *)v27->rgctx_data[1].rgctxDataDummy) )
		        {
		          if ( !TypeInfo::HG::Rendering::Runtime::HGWindConfig->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGWindConfig);
		          HG::Rendering::Runtime::HGWindConfig::set_active(
		            &this->fields.windConfig,
		            1,
		            (MethodInfo *)v27->rgctx_data[2].rgctxDataDummy);
		          HG::Rendering::Runtime::HGWindConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
		            &this->fields.windConfig,
		            &a->fields.windConfig,
		            &b->fields.windConfig,
		            t,
		            (MethodInfo *)v27->rgctx_data[3].rgctxDataDummy);
		          goto LABEL_72;
		        }
		      }
		      v30 = *(_OWORD *)&b->fields.windConfig.speed;
		      v31 = *(_DWORD *)&b->fields.windConfig.m_active;
		      v32 = *(_QWORD *)&b->fields.windConfig.direction.y;
		    }
		    *(_OWORD *)&this->fields.windConfig.speed = v30;
		    *(_QWORD *)&this->fields.windConfig.direction.y = v32;
		    *(_DWORD *)&this->fields.windConfig.m_active = v31;
		LABEL_72:
		    v33 = MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGLightShaftConfig>;
		    if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGLightShaftConfig>->rgctx_data )
		      sub_1800430B0(MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGLightShaftConfig>);
		    if ( !TypeInfo::HG::Rendering::Runtime::HGLightShaftConfig->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGLightShaftConfig);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v6->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_246;
		    if ( wrapperArray->max_length.size <= 1389 )
		      goto LABEL_80;
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v6->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_246;
		    if ( wrapperArray->max_length.size <= 0x56Du )
		      goto LABEL_525;
		    if ( wrapperArray[38].vector[21] )
		    {
		      v99 = IFix::WrappersManagerImpl::GetPatch(1389, 0LL);
		      if ( !v99 )
		        goto LABEL_246;
		      v34 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_562(v99, &a->fields.lightShaftConfig, 0LL);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    else
		    {
		LABEL_80:
		      v34 = a->fields.lightShaftConfig.m_active;
		    }
		    if ( !v34 )
		    {
		      if ( !TypeInfo::HG::Rendering::Runtime::HGLightShaftConfig->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGLightShaftConfig);
		      if ( !HG::Rendering::Runtime::HGLightShaftConfig::get_active(
		              &b->fields.lightShaftConfig,
		              (MethodInfo *)v33->rgctx_data[1].rgctxDataDummy) )
		        goto LABEL_94;
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    if ( t == 0.0 )
		      goto LABEL_354;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGLightShaftConfig->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGLightShaftConfig);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v6->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_246;
		    if ( wrapperArray->max_length.size <= 1389 )
		      goto LABEL_89;
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v6->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_246;
		    if ( wrapperArray->max_length.size <= 0x56Du )
		      goto LABEL_525;
		    if ( wrapperArray[38].vector[21] )
		    {
		      v100 = IFix::WrappersManagerImpl::GetPatch(1389, 0LL);
		      if ( !v100 )
		        goto LABEL_246;
		      v35 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_562(v100, &b->fields.lightShaftConfig, 0LL);
		    }
		    else
		    {
		LABEL_89:
		      v35 = b->fields.lightShaftConfig.m_active;
		    }
		    if ( !v35 )
		    {
		LABEL_354:
		      v36 = *(_OWORD *)&a->fields.lightShaftConfig.enable;
		      v37 = *(_DWORD *)&a->fields.lightShaftConfig.m_active;
		      bloomTint = a->fields.lightShaftConfig.bloomTint;
		      v39 = *(_OWORD *)&a->fields.lightShaftConfig.blurIntensity;
		    }
		    else
		    {
		      if ( t < (float)(1.0 - TypeInfo::UnityEngine::Mathf->static_fields->Epsilon) )
		      {
		        if ( !TypeInfo::HG::Rendering::Runtime::HGLightShaftConfig->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGLightShaftConfig);
		        if ( HG::Rendering::Runtime::HGLightShaftConfig::get_active(
		               &a->fields.lightShaftConfig,
		               (MethodInfo *)v33->rgctx_data[1].rgctxDataDummy) )
		        {
		          if ( !TypeInfo::HG::Rendering::Runtime::HGLightShaftConfig->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGLightShaftConfig);
		          HG::Rendering::Runtime::HGLightShaftConfig::set_active(
		            &this->fields.lightShaftConfig,
		            1,
		            (MethodInfo *)v33->rgctx_data[2].rgctxDataDummy);
		          HG::Rendering::Runtime::HGLightShaftConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
		            &this->fields.lightShaftConfig,
		            (HGWindConfig *)&a->fields.lightShaftConfig,
		            (HGWindConfig *)&b->fields.lightShaftConfig,
		            t,
		            (MethodInfo *)v33->rgctx_data[3].rgctxDataDummy);
		          goto LABEL_94;
		        }
		      }
		      v36 = *(_OWORD *)&b->fields.lightShaftConfig.enable;
		      v37 = *(_DWORD *)&b->fields.lightShaftConfig.m_active;
		      bloomTint = b->fields.lightShaftConfig.bloomTint;
		      v39 = *(_OWORD *)&b->fields.lightShaftConfig.blurIntensity;
		    }
		    *(_OWORD *)&this->fields.lightShaftConfig.enable = v36;
		    this->fields.lightShaftConfig.bloomTint = bloomTint;
		    *(_OWORD *)&this->fields.lightShaftConfig.blurIntensity = v39;
		    *(_DWORD *)&this->fields.lightShaftConfig.m_active = v37;
		LABEL_94:
		    v40 = MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGTerrainDeformConfig>;
		    if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGTerrainDeformConfig>->rgctx_data )
		      sub_1800430B0(MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGTerrainDeformConfig>);
		    if ( !TypeInfo::HG::Rendering::Runtime::HGTerrainDeformConfig->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGTerrainDeformConfig);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v6->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_246;
		    if ( wrapperArray->max_length.size <= 1405 )
		      goto LABEL_102;
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v6->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_246;
		    if ( wrapperArray->max_length.size <= 0x57Du )
		      goto LABEL_525;
		    if ( wrapperArray[39].vector[1] )
		    {
		      v101 = IFix::WrappersManagerImpl::GetPatch(1405, 0LL);
		      if ( !v101 )
		        goto LABEL_246;
		      v41 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_574(v101, &a->fields.terrainDeformConfig, 0LL);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    else
		    {
		LABEL_102:
		      v41 = a->fields.terrainDeformConfig.m_active;
		    }
		    if ( !v41 )
		    {
		      if ( !TypeInfo::HG::Rendering::Runtime::HGTerrainDeformConfig->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGTerrainDeformConfig);
		      if ( !HG::Rendering::Runtime::HGTerrainDeformConfig::get_active(
		              &b->fields.terrainDeformConfig,
		              (MethodInfo *)v40->rgctx_data[1].rgctxDataDummy) )
		        goto LABEL_116;
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    if ( t == 0.0 )
		      goto LABEL_379;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGTerrainDeformConfig->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGTerrainDeformConfig);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v6->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_246;
		    if ( wrapperArray->max_length.size <= 1405 )
		      goto LABEL_111;
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v6->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_246;
		    if ( wrapperArray->max_length.size <= 0x57Du )
		      goto LABEL_525;
		    if ( wrapperArray[39].vector[1] )
		    {
		      v102 = IFix::WrappersManagerImpl::GetPatch(1405, 0LL);
		      if ( !v102 )
		        goto LABEL_246;
		      v42 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_574(v102, &b->fields.terrainDeformConfig, 0LL);
		    }
		    else
		    {
		LABEL_111:
		      v42 = b->fields.terrainDeformConfig.m_active;
		    }
		    if ( !v42 )
		    {
		LABEL_379:
		      v43 = *(_DWORD *)&a->fields.terrainDeformConfig.m_active;
		      v44 = *(_QWORD *)&a->fields.terrainDeformConfig.deformGlobalStrength;
		    }
		    else
		    {
		      if ( t < (float)(1.0 - TypeInfo::UnityEngine::Mathf->static_fields->Epsilon) )
		      {
		        if ( !TypeInfo::HG::Rendering::Runtime::HGTerrainDeformConfig->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGTerrainDeformConfig);
		        if ( HG::Rendering::Runtime::HGTerrainDeformConfig::get_active(
		               &a->fields.terrainDeformConfig,
		               (MethodInfo *)v40->rgctx_data[1].rgctxDataDummy) )
		        {
		          if ( !TypeInfo::HG::Rendering::Runtime::HGTerrainDeformConfig->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGTerrainDeformConfig);
		          HG::Rendering::Runtime::HGTerrainDeformConfig::set_active(
		            &this->fields.terrainDeformConfig,
		            1,
		            (MethodInfo *)v40->rgctx_data[2].rgctxDataDummy);
		          HG::Rendering::Runtime::HGTerrainDeformConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
		            &this->fields.terrainDeformConfig,
		            (HGWindConfig *)&a->fields.terrainDeformConfig,
		            (HGWindConfig *)&b->fields.terrainDeformConfig,
		            t,
		            (MethodInfo *)v40->rgctx_data[3].rgctxDataDummy);
		          goto LABEL_116;
		        }
		      }
		      v43 = *(_DWORD *)&b->fields.terrainDeformConfig.m_active;
		      v44 = *(_QWORD *)&b->fields.terrainDeformConfig.deformGlobalStrength;
		    }
		    *(_QWORD *)&this->fields.terrainDeformConfig.deformGlobalStrength = v44;
		    *(_DWORD *)&this->fields.terrainDeformConfig.m_active = v43;
		LABEL_116:
		    v45 = MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGInkSimulationConfig>;
		    if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGInkSimulationConfig>->rgctx_data )
		      sub_1800430B0(MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGInkSimulationConfig>);
		    if ( !TypeInfo::HG::Rendering::Runtime::HGInkSimulationConfig->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGInkSimulationConfig);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v6->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_246;
		    if ( wrapperArray->max_length.size <= 1368 )
		      goto LABEL_124;
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v6->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_246;
		    if ( wrapperArray->max_length.size <= 0x558u )
		      goto LABEL_525;
		    if ( wrapperArray[38].vector[0] )
		    {
		      v103 = IFix::WrappersManagerImpl::GetPatch(1368, 0LL);
		      if ( !v103 )
		        goto LABEL_246;
		      v46 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_543(v103, &a->fields.inkSimulationConfig, 0LL);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    else
		    {
		LABEL_124:
		      v46 = a->fields.inkSimulationConfig.m_active;
		    }
		    if ( !v46 )
		    {
		      if ( !TypeInfo::HG::Rendering::Runtime::HGInkSimulationConfig->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGInkSimulationConfig);
		      if ( !HG::Rendering::Runtime::HGInkSimulationConfig::get_active(
		              &b->fields.inkSimulationConfig,
		              (MethodInfo *)v45->rgctx_data[1].rgctxDataDummy) )
		        goto LABEL_137;
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    if ( t == 0.0 )
		      goto LABEL_135;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGInkSimulationConfig->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGInkSimulationConfig);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v6->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_246;
		    if ( wrapperArray->max_length.size <= 1368 )
		      goto LABEL_133;
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v6->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_246;
		    if ( wrapperArray->max_length.size <= 0x558u )
		      goto LABEL_525;
		    if ( wrapperArray[38].vector[0] )
		    {
		      v104 = IFix::WrappersManagerImpl::GetPatch(1368, 0LL);
		      if ( !v104 )
		        goto LABEL_246;
		      v47 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_543(v104, &b->fields.inkSimulationConfig, 0LL);
		    }
		    else
		    {
		LABEL_133:
		      v47 = b->fields.inkSimulationConfig.m_active;
		    }
		    if ( v47 )
		    {
		      if ( t < (float)(1.0 - TypeInfo::UnityEngine::Mathf->static_fields->Epsilon) )
		      {
		        if ( !TypeInfo::HG::Rendering::Runtime::HGInkSimulationConfig->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGInkSimulationConfig);
		        if ( HG::Rendering::Runtime::HGInkSimulationConfig::get_active(
		               &a->fields.inkSimulationConfig,
		               (MethodInfo *)v45->rgctx_data[1].rgctxDataDummy) )
		        {
		          if ( !TypeInfo::HG::Rendering::Runtime::HGInkSimulationConfig->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGInkSimulationConfig);
		          HG::Rendering::Runtime::HGInkSimulationConfig::set_active(
		            &this->fields.inkSimulationConfig,
		            1,
		            (MethodInfo *)v45->rgctx_data[2].rgctxDataDummy);
		          HG::Rendering::Runtime::HGInkSimulationConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
		            &this->fields.inkSimulationConfig,
		            (HGWindConfig *)&a->fields.inkSimulationConfig,
		            (HGWindConfig *)&b->fields.inkSimulationConfig,
		            t,
		            (MethodInfo *)v45->rgctx_data[3].rgctxDataDummy);
		          goto LABEL_137;
		        }
		      }
		      v48 = *(_OWORD *)&b->fields.inkSimulationConfig.influence;
		      v49 = *(_OWORD *)&b->fields.inkSimulationConfig.inkRippleDensity;
		      v50 = *(_OWORD *)&b->fields.inkSimulationConfig.inkDebugJacobi;
		      v51 = *(_OWORD *)&b->fields.inkSimulationConfig.resolvedShaderParams.speedFactor;
		      v52 = *(_OWORD *)&b->fields.inkSimulationConfig.resolvedShaderParams.forceAngleRandom;
		      v53 = *(_OWORD *)&b->fields.inkSimulationConfig.resolvedShaderParams.landingInkSize;
		      v54 = *(_OWORD *)&b->fields.inkSimulationConfig.resolvedShaderParams.viscosity;
		      v55 = *(_QWORD *)&b->fields.inkSimulationConfig.resolvedShaderParams.idleForceChangeSpeed;
		    }
		    else
		    {
		LABEL_135:
		      v48 = *(_OWORD *)&a->fields.inkSimulationConfig.influence;
		      v49 = *(_OWORD *)&a->fields.inkSimulationConfig.inkRippleDensity;
		      v50 = *(_OWORD *)&a->fields.inkSimulationConfig.inkDebugJacobi;
		      v51 = *(_OWORD *)&a->fields.inkSimulationConfig.resolvedShaderParams.speedFactor;
		      v52 = *(_OWORD *)&a->fields.inkSimulationConfig.resolvedShaderParams.forceAngleRandom;
		      v53 = *(_OWORD *)&a->fields.inkSimulationConfig.resolvedShaderParams.landingInkSize;
		      v54 = *(_OWORD *)&a->fields.inkSimulationConfig.resolvedShaderParams.viscosity;
		      v55 = *(_QWORD *)&a->fields.inkSimulationConfig.resolvedShaderParams.idleForceChangeSpeed;
		    }
		    *(_OWORD *)&this->fields.inkSimulationConfig.influence = v48;
		    *(_OWORD *)&this->fields.inkSimulationConfig.inkRippleDensity = v49;
		    *(_OWORD *)&this->fields.inkSimulationConfig.inkDebugJacobi = v50;
		    *(_OWORD *)&this->fields.inkSimulationConfig.resolvedShaderParams.speedFactor = v51;
		    *(_OWORD *)&this->fields.inkSimulationConfig.resolvedShaderParams.forceAngleRandom = v52;
		    *(_OWORD *)&this->fields.inkSimulationConfig.resolvedShaderParams.landingInkSize = v53;
		    *(_OWORD *)&this->fields.inkSimulationConfig.resolvedShaderParams.viscosity = v54;
		    *(_QWORD *)&this->fields.inkSimulationConfig.resolvedShaderParams.idleForceChangeSpeed = v55;
		    sub_18002D1B0(
		      (SingleFieldAccessor *)&this->fields.inkSimulationConfig.shaderParams,
		      (Type *)wrapperArray,
		      v25,
		      v26,
		      P3);
		LABEL_137:
		    sub_183AB74D0(
		      &this->fields.rainConfig,
		      (HGWindConfig *)&a->fields.rainConfig,
		      (HGWindConfig *)&b->fields.rainConfig,
		      (__int64)MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGRainConfig>);
		    v56 = MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGSnowConfig>;
		    if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGSnowConfig>->rgctx_data )
		      sub_1800430B0(MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGSnowConfig>);
		    if ( !TypeInfo::HG::Rendering::Runtime::HGSnowConfig->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGSnowConfig);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v6->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_246;
		    if ( wrapperArray->max_length.size <= 1401 )
		      goto LABEL_145;
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v6->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_246;
		    if ( wrapperArray->max_length.size <= 0x579u )
		      goto LABEL_525;
		    if ( wrapperArray[39].monitor )
		    {
		      v105 = IFix::WrappersManagerImpl::GetPatch(1401, 0LL);
		      if ( !v105 )
		        goto LABEL_246;
		      v57 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_570(v105, &a->fields.snowConfig, 0LL);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    else
		    {
		LABEL_145:
		      v57 = a->fields.snowConfig.m_active;
		    }
		    if ( !v57 )
		    {
		      if ( !TypeInfo::HG::Rendering::Runtime::HGSnowConfig->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGSnowConfig);
		      if ( !HG::Rendering::Runtime::HGSnowConfig::get_active(
		              &b->fields.snowConfig,
		              (MethodInfo *)v56->rgctx_data[1].rgctxDataDummy) )
		        goto LABEL_158;
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    if ( t == 0.0 )
		      goto LABEL_156;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGSnowConfig->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGSnowConfig);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v6->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_246;
		    if ( wrapperArray->max_length.size <= 1401 )
		      goto LABEL_154;
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v6->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_246;
		    if ( wrapperArray->max_length.size <= 0x579u )
		      goto LABEL_525;
		    if ( wrapperArray[39].monitor )
		    {
		      v106 = IFix::WrappersManagerImpl::GetPatch(1401, 0LL);
		      if ( !v106 )
		        goto LABEL_246;
		      v58 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_570(v106, &b->fields.snowConfig, 0LL);
		    }
		    else
		    {
		LABEL_154:
		      v58 = b->fields.snowConfig.m_active;
		    }
		    if ( v58 )
		    {
		      if ( t < (float)(1.0 - TypeInfo::UnityEngine::Mathf->static_fields->Epsilon) )
		      {
		        if ( !TypeInfo::HG::Rendering::Runtime::HGSnowConfig->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGSnowConfig);
		        if ( HG::Rendering::Runtime::HGSnowConfig::get_active(
		               &a->fields.snowConfig,
		               (MethodInfo *)v56->rgctx_data[1].rgctxDataDummy) )
		        {
		          if ( !TypeInfo::HG::Rendering::Runtime::HGSnowConfig->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGSnowConfig);
		          HG::Rendering::Runtime::HGSnowConfig::set_active(
		            &this->fields.snowConfig,
		            1,
		            (MethodInfo *)v56->rgctx_data[2].rgctxDataDummy);
		          HG::Rendering::Runtime::HGSnowConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
		            &this->fields.snowConfig,
		            (HGWindConfig *)&a->fields.snowConfig,
		            (HGWindConfig *)&b->fields.snowConfig,
		            t,
		            (MethodInfo *)v56->rgctx_data[3].rgctxDataDummy);
		          goto LABEL_158;
		        }
		      }
		      v59 = *(_OWORD *)&b->fields.snowConfig.enable;
		      color = b->fields.snowConfig.color;
		      v61 = *(_OWORD *)&b->fields.snowConfig.snowSizeRange.x;
		      v62 = *(_OWORD *)&b->fields.snowConfig.snowTrailLength;
		      v63 = *(_OWORD *)&b->fields.snowConfig.snowLightingPercent;
		      v64 = *(_QWORD *)&b->fields.snowConfig.snowDirection.z;
		    }
		    else
		    {
		LABEL_156:
		      v59 = *(_OWORD *)&a->fields.snowConfig.enable;
		      color = a->fields.snowConfig.color;
		      v61 = *(_OWORD *)&a->fields.snowConfig.snowSizeRange.x;
		      v62 = *(_OWORD *)&a->fields.snowConfig.snowTrailLength;
		      v63 = *(_OWORD *)&a->fields.snowConfig.snowLightingPercent;
		      v64 = *(_QWORD *)&a->fields.snowConfig.snowDirection.z;
		    }
		    *(_OWORD *)&this->fields.snowConfig.enable = v59;
		    this->fields.snowConfig.color = color;
		    *(_OWORD *)&this->fields.snowConfig.snowSizeRange.x = v61;
		    *(_OWORD *)&this->fields.snowConfig.snowTrailLength = v62;
		    *(_OWORD *)&this->fields.snowConfig.snowLightingPercent = v63;
		    *(_QWORD *)&this->fields.snowConfig.snowDirection.z = v64;
		LABEL_158:
		    sub_183B72560(
		      &this->fields.starConfig,
		      (HGWindConfig *)&a->fields.starConfig,
		      (HGWindConfig *)&b->fields.starConfig,
		      (__int64)MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGStarConfig>);
		    v67 = MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGLensFlareConfig>;
		    if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGLensFlareConfig>->rgctx_data )
		      sub_1800430B0(MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGLensFlareConfig>);
		    if ( !TypeInfo::HG::Rendering::Runtime::HGLensFlareConfig->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGLensFlareConfig);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v6->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_246;
		    if ( wrapperArray->max_length.size <= 1382 )
		      goto LABEL_166;
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v6->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_246;
		    if ( wrapperArray->max_length.size <= 0x566u )
		      goto LABEL_525;
		    if ( wrapperArray[38].vector[14] )
		    {
		      v107 = IFix::WrappersManagerImpl::GetPatch(1382, 0LL);
		      if ( !v107 )
		        goto LABEL_246;
		      v68 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_556(v107, &a->fields.lensFlareConfig, 0LL);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    else
		    {
		LABEL_166:
		      v68 = a->fields.lensFlareConfig.m_active;
		    }
		    if ( !v68 )
		    {
		      if ( !TypeInfo::HG::Rendering::Runtime::HGLensFlareConfig->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGLensFlareConfig);
		      if ( !HG::Rendering::Runtime::HGLensFlareConfig::get_active(
		              &b->fields.lensFlareConfig,
		              (MethodInfo *)v67->rgctx_data[1].rgctxDataDummy) )
		        goto LABEL_180;
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    if ( t == 0.0 )
		      goto LABEL_456;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGLensFlareConfig->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGLensFlareConfig);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v6->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_246;
		    if ( wrapperArray->max_length.size <= 1382 )
		      goto LABEL_175;
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v6->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_246;
		    if ( wrapperArray->max_length.size <= 0x566u )
		      goto LABEL_525;
		    if ( wrapperArray[38].vector[14] )
		    {
		      v108 = IFix::WrappersManagerImpl::GetPatch(1382, 0LL);
		      if ( !v108 )
		        goto LABEL_246;
		      v69 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_556(v108, &b->fields.lensFlareConfig, 0LL);
		    }
		    else
		    {
		LABEL_175:
		      v69 = b->fields.lensFlareConfig.m_active;
		    }
		    if ( !v69 )
		    {
		LABEL_456:
		      v70 = *(_OWORD *)&a->fields.lensFlareConfig.enable;
		      v71 = *(_OWORD *)&a->fields.lensFlareConfig.intensity;
		      v72 = *(_OWORD *)&a->fields.lensFlareConfig.sampleCount;
		    }
		    else
		    {
		      if ( t < (float)(1.0 - TypeInfo::UnityEngine::Mathf->static_fields->Epsilon) )
		      {
		        if ( !TypeInfo::HG::Rendering::Runtime::HGLensFlareConfig->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGLensFlareConfig);
		        if ( HG::Rendering::Runtime::HGLensFlareConfig::get_active(
		               &a->fields.lensFlareConfig,
		               (MethodInfo *)v67->rgctx_data[1].rgctxDataDummy) )
		        {
		          if ( !TypeInfo::HG::Rendering::Runtime::HGLensFlareConfig->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGLensFlareConfig);
		          HG::Rendering::Runtime::HGLensFlareConfig::set_active(
		            &this->fields.lensFlareConfig,
		            1,
		            (MethodInfo *)v67->rgctx_data[2].rgctxDataDummy);
		          HG::Rendering::Runtime::HGLensFlareConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
		            &this->fields.lensFlareConfig,
		            (HGWindConfig *)&a->fields.lensFlareConfig,
		            (HGWindConfig *)&b->fields.lensFlareConfig,
		            t,
		            (MethodInfo *)v67->rgctx_data[3].rgctxDataDummy);
		          goto LABEL_180;
		        }
		      }
		      v70 = *(_OWORD *)&b->fields.lensFlareConfig.enable;
		      v71 = *(_OWORD *)&b->fields.lensFlareConfig.intensity;
		      v72 = *(_OWORD *)&b->fields.lensFlareConfig.sampleCount;
		    }
		    *(_OWORD *)&this->fields.lensFlareConfig.enable = v70;
		    *(_OWORD *)&this->fields.lensFlareConfig.intensity = v71;
		    *(_OWORD *)&this->fields.lensFlareConfig.sampleCount = v72;
		    sub_18002D1B0(
		      (SingleFieldAccessor *)&this->fields.lensFlareConfig.lensFlareData,
		      (Type *)wrapperArray,
		      v65,
		      v66,
		      P3a);
		LABEL_180:
		    sub_183A3F6D0(
		      &this->fields.colorGradingConfig,
		      (HGWindConfig *)&a->fields.colorGradingConfig,
		      (HGWindConfig *)&b->fields.colorGradingConfig,
		      (__int64)MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGColorGradingConfig>);
		    v73 = MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGAutoExposureConfig>;
		    if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGAutoExposureConfig>->rgctx_data )
		      sub_1800430B0(MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGAutoExposureConfig>);
		    if ( !TypeInfo::HG::Rendering::Runtime::HGAutoExposureConfig->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGAutoExposureConfig);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v6->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_246;
		    if ( wrapperArray->max_length.size <= 1325 )
		      goto LABEL_188;
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v6->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_246;
		    if ( wrapperArray->max_length.size <= 0x52Du )
		      goto LABEL_525;
		    if ( wrapperArray[36].vector[29] )
		    {
		      v109 = IFix::WrappersManagerImpl::GetPatch(1325, 0LL);
		      if ( !v109 )
		        goto LABEL_246;
		      v74 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_381(v109, &a->fields.autoExposureConfig, 0LL);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    else
		    {
		LABEL_188:
		      v74 = a->fields.autoExposureConfig.m_active;
		    }
		    if ( !v74 )
		    {
		      if ( !TypeInfo::HG::Rendering::Runtime::HGAutoExposureConfig->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGAutoExposureConfig);
		      if ( !HG::Rendering::Runtime::HGAutoExposureConfig::get_active(
		              &b->fields.autoExposureConfig,
		              (MethodInfo *)v73->rgctx_data[1].rgctxDataDummy) )
		        goto LABEL_202;
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    if ( t == 0.0 )
		      goto LABEL_245;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGAutoExposureConfig->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGAutoExposureConfig);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v6->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_246;
		    if ( wrapperArray->max_length.size <= 1325 )
		      goto LABEL_197;
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v6->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_246;
		    if ( wrapperArray->max_length.size <= 0x52Du )
		      goto LABEL_525;
		    if ( wrapperArray[36].vector[29] )
		    {
		      v110 = IFix::WrappersManagerImpl::GetPatch(1325, 0LL);
		      if ( !v110 )
		        goto LABEL_246;
		      v75 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_381(v110, &b->fields.autoExposureConfig, 0LL);
		    }
		    else
		    {
		LABEL_197:
		      v75 = b->fields.autoExposureConfig.m_active;
		    }
		    if ( !v75 )
		    {
		LABEL_245:
		      v76 = *(_OWORD *)&a->fields.autoExposureConfig.autoExposureMode;
		      v77 = *(_DWORD *)&a->fields.autoExposureConfig.m_active;
		      v78 = *(_OWORD *)&a->fields.autoExposureConfig.autoExposureEv100Range.x;
		      v79 = *(_OWORD *)&a->fields.autoExposureConfig.autoExposureMeteringMode;
		      v80 = *(_QWORD *)&a->fields.autoExposureConfig.autoExposureEvClampRange.y;
		    }
		    else
		    {
		      if ( t < (float)(1.0 - TypeInfo::UnityEngine::Mathf->static_fields->Epsilon) )
		      {
		        if ( !TypeInfo::HG::Rendering::Runtime::HGAutoExposureConfig->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGAutoExposureConfig);
		        if ( HG::Rendering::Runtime::HGAutoExposureConfig::get_active(
		               &a->fields.autoExposureConfig,
		               (MethodInfo *)v73->rgctx_data[1].rgctxDataDummy) )
		        {
		          if ( !TypeInfo::HG::Rendering::Runtime::HGAutoExposureConfig->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGAutoExposureConfig);
		          HG::Rendering::Runtime::HGAutoExposureConfig::set_active(
		            &this->fields.autoExposureConfig,
		            1,
		            (MethodInfo *)v73->rgctx_data[2].rgctxDataDummy);
		          HG::Rendering::Runtime::HGAutoExposureConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
		            &this->fields.autoExposureConfig,
		            (HGWindConfig *)&a->fields.autoExposureConfig,
		            (HGWindConfig *)&b->fields.autoExposureConfig,
		            t,
		            (MethodInfo *)v73->rgctx_data[3].rgctxDataDummy);
		          goto LABEL_202;
		        }
		      }
		      v76 = *(_OWORD *)&b->fields.autoExposureConfig.autoExposureMode;
		      v77 = *(_DWORD *)&b->fields.autoExposureConfig.m_active;
		      v78 = *(_OWORD *)&b->fields.autoExposureConfig.autoExposureEv100Range.x;
		      v79 = *(_OWORD *)&b->fields.autoExposureConfig.autoExposureMeteringMode;
		      v80 = *(_QWORD *)&b->fields.autoExposureConfig.autoExposureEvClampRange.y;
		    }
		    *(_OWORD *)&this->fields.autoExposureConfig.autoExposureMode = v76;
		    *(_OWORD *)&this->fields.autoExposureConfig.autoExposureEv100Range.x = v78;
		    *(_OWORD *)&this->fields.autoExposureConfig.autoExposureMeteringMode = v79;
		    *(_QWORD *)&this->fields.autoExposureConfig.autoExposureEvClampRange.y = v80;
		    *(_DWORD *)&this->fields.autoExposureConfig.m_active = v77;
		LABEL_202:
		    sub_183B5B000(
		      &this->fields.shadowConfig,
		      (HGWindConfig *)&a->fields.shadowConfig,
		      (HGWindConfig *)&b->fields.shadowConfig,
		      (__int64)MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGShadowConfig>);
		    v81 = MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGAnamorphicStreaksConfig>;
		    if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGAnamorphicStreaksConfig>->rgctx_data )
		      sub_1800430B0(MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGAnamorphicStreaksConfig>);
		    if ( !TypeInfo::HG::Rendering::Runtime::HGAnamorphicStreaksConfig->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGAnamorphicStreaksConfig);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v6->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_246;
		    if ( wrapperArray->max_length.size <= 1320 )
		      goto LABEL_210;
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v6->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_246;
		    if ( wrapperArray->max_length.size <= 0x528u )
		      goto LABEL_525;
		    if ( wrapperArray[36].vector[24] )
		    {
		      v111 = IFix::WrappersManagerImpl::GetPatch(1320, 0LL);
		      if ( !v111 )
		        goto LABEL_246;
		      v82 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_508(v111, &a->fields.anamorphicStreaksConfig, 0LL);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    else
		    {
		LABEL_210:
		      v82 = a->fields.anamorphicStreaksConfig.m_active;
		    }
		    if ( !v82 )
		    {
		      if ( !TypeInfo::HG::Rendering::Runtime::HGAnamorphicStreaksConfig->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGAnamorphicStreaksConfig);
		      if ( !HG::Rendering::Runtime::HGAnamorphicStreaksConfig::get_active(
		              &b->fields.anamorphicStreaksConfig,
		              (MethodInfo *)v81->rgctx_data[1].rgctxDataDummy) )
		        goto LABEL_223;
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    if ( t == 0.0 )
		      goto LABEL_221;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGAnamorphicStreaksConfig->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGAnamorphicStreaksConfig);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v6->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_246;
		    if ( wrapperArray->max_length.size <= 1320 )
		      goto LABEL_219;
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v6->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_246;
		    if ( wrapperArray->max_length.size <= 0x528u )
		      goto LABEL_525;
		    if ( wrapperArray[36].vector[24] )
		    {
		      v112 = IFix::WrappersManagerImpl::GetPatch(1320, 0LL);
		      if ( !v112 )
		        goto LABEL_246;
		      v83 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_508(v112, &b->fields.anamorphicStreaksConfig, 0LL);
		    }
		    else
		    {
		LABEL_219:
		      v83 = b->fields.anamorphicStreaksConfig.m_active;
		    }
		    if ( !v83 )
		    {
		LABEL_221:
		      v84 = *(_OWORD *)&a->fields.anamorphicStreaksConfig.enable;
		      v85 = a->fields.anamorphicStreaksConfig.bloomTint;
		      v86 = *(_OWORD *)&a->fields.anamorphicStreaksConfig.blurIntensity;
		LABEL_222:
		      *(_OWORD *)&this->fields.anamorphicStreaksConfig.enable = v84;
		      this->fields.anamorphicStreaksConfig.bloomTint = v85;
		      *(_OWORD *)&this->fields.anamorphicStreaksConfig.blurIntensity = v86;
		      goto LABEL_223;
		    }
		    if ( t >= (float)(1.0 - TypeInfo::UnityEngine::Mathf->static_fields->Epsilon) )
		      goto LABEL_506;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGAnamorphicStreaksConfig->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGAnamorphicStreaksConfig);
		    if ( !HG::Rendering::Runtime::HGAnamorphicStreaksConfig::get_active(
		            &a->fields.anamorphicStreaksConfig,
		            (MethodInfo *)v81->rgctx_data[1].rgctxDataDummy) )
		    {
		LABEL_506:
		      v84 = *(_OWORD *)&b->fields.anamorphicStreaksConfig.enable;
		      v85 = b->fields.anamorphicStreaksConfig.bloomTint;
		      v86 = *(_OWORD *)&b->fields.anamorphicStreaksConfig.blurIntensity;
		      goto LABEL_222;
		    }
		    if ( !TypeInfo::HG::Rendering::Runtime::HGAnamorphicStreaksConfig->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGAnamorphicStreaksConfig);
		    HG::Rendering::Runtime::HGAnamorphicStreaksConfig::set_active(
		      &this->fields.anamorphicStreaksConfig,
		      1,
		      (MethodInfo *)v81->rgctx_data[2].rgctxDataDummy);
		    HG::Rendering::Runtime::HGAnamorphicStreaksConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
		      &this->fields.anamorphicStreaksConfig,
		      (HGWindConfig *)&a->fields.anamorphicStreaksConfig,
		      (HGWindConfig *)&b->fields.anamorphicStreaksConfig,
		      t,
		      (MethodInfo *)v81->rgctx_data[3].rgctxDataDummy);
		LABEL_223:
		    v87 = MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGWaterEnvConfig>;
		    if ( !MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGWaterEnvConfig>->rgctx_data )
		      sub_1800430B0(MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGWaterEnvConfig>);
		    if ( !TypeInfo::HG::Rendering::Runtime::HGWaterEnvConfig->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGWaterEnvConfig);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v6->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_246;
		    if ( wrapperArray->max_length.size <= 1412 )
		      goto LABEL_231;
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v6->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_246;
		    if ( wrapperArray->max_length.size <= 0x584u )
		      goto LABEL_525;
		    if ( wrapperArray[39].vector[8] )
		    {
		      v113 = IFix::WrappersManagerImpl::GetPatch(1412, 0LL);
		      if ( !v113 )
		        goto LABEL_246;
		      v88 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_579(v113, &a->fields.waterEnvConfig, 0LL);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    else
		    {
		LABEL_231:
		      v88 = a->fields.waterEnvConfig.m_active;
		    }
		    if ( !v88 )
		    {
		      if ( !TypeInfo::HG::Rendering::Runtime::HGWaterEnvConfig->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGWaterEnvConfig);
		      if ( !HG::Rendering::Runtime::HGWaterEnvConfig::get_active(
		              &b->fields.waterEnvConfig,
		              (MethodInfo *)v87->rgctx_data[1].rgctxDataDummy) )
		        goto LABEL_244;
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    if ( t == 0.0 )
		      goto LABEL_242;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGWaterEnvConfig->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGWaterEnvConfig);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v6->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_246;
		    if ( wrapperArray->max_length.size <= 1412 )
		    {
		LABEL_240:
		      v89 = b->fields.waterEnvConfig.m_active;
		      goto LABEL_241;
		    }
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v6 = (struct ILFixDynamicMethodWrapper_2__Class *)v6->static_fields->wrapperArray;
		    if ( !v6 )
		LABEL_246:
		      sub_1800D8260(v6, wrapperArray);
		    if ( LODWORD(v6->_0.namespaze) > 0x584 )
		    {
		      if ( !v6[30]._0.this_arg.data.dummy )
		        goto LABEL_240;
		      v114 = IFix::WrappersManagerImpl::GetPatch(1412, 0LL);
		      if ( v114 )
		      {
		        v89 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_579(v114, &b->fields.waterEnvConfig, 0LL);
		LABEL_241:
		        if ( v89 )
		        {
		          if ( t < (float)(1.0 - TypeInfo::UnityEngine::Mathf->static_fields->Epsilon) )
		          {
		            if ( !TypeInfo::HG::Rendering::Runtime::HGWaterEnvConfig->_1.cctor_finished_or_no_cctor )
		              il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGWaterEnvConfig);
		            if ( HG::Rendering::Runtime::HGWaterEnvConfig::get_active(
		                   &a->fields.waterEnvConfig,
		                   (MethodInfo *)v87->rgctx_data[1].rgctxDataDummy) )
		            {
		              if ( !TypeInfo::HG::Rendering::Runtime::HGWaterEnvConfig->_1.cctor_finished_or_no_cctor )
		                il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGWaterEnvConfig);
		              HG::Rendering::Runtime::HGWaterEnvConfig::set_active(
		                &this->fields.waterEnvConfig,
		                1,
		                (MethodInfo *)v87->rgctx_data[2].rgctxDataDummy);
		              HG::Rendering::Runtime::HGWaterEnvConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
		                &this->fields.waterEnvConfig,
		                (HGWindConfig *)&a->fields.waterEnvConfig,
		                (HGWindConfig *)&b->fields.waterEnvConfig,
		                t,
		                (MethodInfo *)v87->rgctx_data[3].rgctxDataDummy);
		              goto LABEL_244;
		            }
		          }
		          v90 = *(_DWORD *)&b->fields.waterEnvConfig.m_active;
		          v91 = *(_QWORD *)&b->fields.waterEnvConfig.enableWaterInteractionAdjust;
		LABEL_243:
		          *(_QWORD *)&this->fields.waterEnvConfig.enableWaterInteractionAdjust = v91;
		          *(_DWORD *)&this->fields.waterEnvConfig.m_active = v90;
		LABEL_244:
		          sub_183B4F7D0(
		            &this->fields.inkWashConfig,
		            (HGWindConfig *)&a->fields.inkWashConfig,
		            (HGWindConfig *)&b->fields.inkWashConfig,
		            (__int64)MethodInfo::HG::Rendering::Runtime::HGEnvironmentPhaseExtensions::LerpConfig<HG::Rendering::Runtime::HGInkWashConfig>);
		          return;
		        }
		LABEL_242:
		        v90 = *(_DWORD *)&a->fields.waterEnvConfig.m_active;
		        v91 = *(_QWORD *)&a->fields.waterEnvConfig.enableWaterInteractionAdjust;
		        goto LABEL_243;
		      }
		      goto LABEL_246;
		    }
		LABEL_525:
		    sub_1800D2AB0(v6, wrapperArray);
		  }
		  v92 = IFix::WrappersManagerImpl::GetPatch(635, 0LL);
		  if ( !v92 )
		    goto LABEL_246;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_258(v92, (Object *)this, (Object *)a, (Object *)b, t, 0LL);
		}
		
		public void ActivateAllEnvConfig(bool value) {} // 0x00000001831D4A60-0x00000001831D4E30
		// Void ActivateAllEnvConfig(Boolean)
		void HG::Rendering::Runtime::HGEnvironmentPhase::ActivateAllEnvConfig(
		        HGEnvironmentPhase *this,
		        bool value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1445, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1445, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, value, 0LL);
		  }
		  else
		  {
		    if ( !TypeInfo::HG::Rendering::Runtime::HGLightConfig->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGLightConfig);
		    HG::Rendering::Runtime::HGLightConfig::set_active(&this->fields.lightConfig, value, 0LL);
		    if ( !TypeInfo::HG::Rendering::Runtime::HGSkyConfig->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGSkyConfig);
		    HG::Rendering::Runtime::HGSkyConfig::set_active(&this->fields.skyConfig, value, 0LL);
		    if ( !TypeInfo::HG::Rendering::Runtime::HGAtmosphereConfig->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGAtmosphereConfig);
		    HG::Rendering::Runtime::HGAtmosphereConfig::set_active(&this->fields.atmosphereConfig, value, 0LL);
		    if ( !TypeInfo::HG::Rendering::Runtime::HGFogConfig->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGFogConfig);
		    HG::Rendering::Runtime::HGFogConfig::set_active(&this->fields.fogConfig, value, 0LL);
		    if ( !TypeInfo::HG::Rendering::Runtime::HGHeightFogConfig->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGHeightFogConfig);
		    HG::Rendering::Runtime::HGHeightFogConfig::set_active(&this->fields.heightFogConfig, value, 0LL);
		    if ( !TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig);
		    HG::Rendering::Runtime::HGVolumetricFogConfig::set_active(&this->fields.volumetricFogConfig, value, 0LL);
		    if ( !TypeInfo::HG::Rendering::Runtime::HGVolumetricCloudConfig->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGVolumetricCloudConfig);
		    HG::Rendering::Runtime::HGVolumetricCloudConfig::set_active(&this->fields.volumetricCloudConfig, value, 0LL);
		    if ( !TypeInfo::HG::Rendering::Runtime::HGCloudConfig->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCloudConfig);
		    HG::Rendering::Runtime::HGCloudConfig::set_active(&this->fields.cloudConfig, value, 0LL);
		    if ( !TypeInfo::HG::Rendering::Runtime::HGCelestialConfig->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCelestialConfig);
		    HG::Rendering::Runtime::HGCelestialConfig::set_active(&this->fields.celestialConfig, value, 0LL);
		    if ( !TypeInfo::HG::Rendering::Runtime::HGWindConfig->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGWindConfig);
		    HG::Rendering::Runtime::HGWindConfig::set_active(&this->fields.windConfig, value, 0LL);
		    if ( !TypeInfo::HG::Rendering::Runtime::HGLightShaftConfig->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGLightShaftConfig);
		    HG::Rendering::Runtime::HGLightShaftConfig::set_active(&this->fields.lightShaftConfig, value, 0LL);
		    if ( !TypeInfo::HG::Rendering::Runtime::HGTerrainDeformConfig->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGTerrainDeformConfig);
		    HG::Rendering::Runtime::HGTerrainDeformConfig::set_active(&this->fields.terrainDeformConfig, value, 0LL);
		    if ( !TypeInfo::HG::Rendering::Runtime::HGInkSimulationConfig->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGInkSimulationConfig);
		    HG::Rendering::Runtime::HGInkSimulationConfig::set_active(&this->fields.inkSimulationConfig, value, 0LL);
		    if ( !TypeInfo::HG::Rendering::Runtime::HGRainConfig->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRainConfig);
		    HG::Rendering::Runtime::HGRainConfig::set_active(&this->fields.rainConfig, value, 0LL);
		    if ( !TypeInfo::HG::Rendering::Runtime::HGSnowConfig->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGSnowConfig);
		    HG::Rendering::Runtime::HGSnowConfig::set_active(&this->fields.snowConfig, value, 0LL);
		    if ( !TypeInfo::HG::Rendering::Runtime::HGStarConfig->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGStarConfig);
		    HG::Rendering::Runtime::HGStarConfig::set_active(&this->fields.starConfig, value, 0LL);
		    if ( !TypeInfo::HG::Rendering::Runtime::HGLensFlareConfig->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGLensFlareConfig);
		    HG::Rendering::Runtime::HGLensFlareConfig::set_active(&this->fields.lensFlareConfig, value, 0LL);
		    if ( !TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
		    HG::Rendering::Runtime::HGColorGradingConfig::set_active(&this->fields.colorGradingConfig, value, 0LL);
		    if ( !TypeInfo::HG::Rendering::Runtime::HGAutoExposureConfig->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGAutoExposureConfig);
		    HG::Rendering::Runtime::HGAutoExposureConfig::set_active(&this->fields.autoExposureConfig, value, 0LL);
		    if ( !TypeInfo::HG::Rendering::Runtime::HGShadowConfig->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGShadowConfig);
		    HG::Rendering::Runtime::HGShadowConfig::set_active(&this->fields.shadowConfig, value, 0LL);
		    if ( !TypeInfo::HG::Rendering::Runtime::HGAnamorphicStreaksConfig->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGAnamorphicStreaksConfig);
		    HG::Rendering::Runtime::HGAnamorphicStreaksConfig::set_active(&this->fields.anamorphicStreaksConfig, value, 0LL);
		    if ( !TypeInfo::HG::Rendering::Runtime::HGWaterEnvConfig->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGWaterEnvConfig);
		    HG::Rendering::Runtime::HGWaterEnvConfig::set_active(&this->fields.waterEnvConfig, value, 0LL);
		    if ( !TypeInfo::HG::Rendering::Runtime::HGInkWashConfig->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGInkWashConfig);
		    HG::Rendering::Runtime::HGInkWashConfig::set_active(&this->fields.inkWashConfig, value, 0LL);
		  }
		}
		
	}
}
