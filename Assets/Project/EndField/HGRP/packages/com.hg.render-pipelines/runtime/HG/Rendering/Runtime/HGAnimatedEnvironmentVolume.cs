using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[AddComponentMenu("Rendering/Animated Environment Volume")]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	public class HGAnimatedEnvironmentVolume : HGEnvironmentVolumeBase // TypeDefIndex: 37632
	{
		// Fields
		public HGLightConfig lightConfig; // 0x58
		public HGSkyConfig skyConfig; // 0x1D0
		public HGAtmosphereConfig atmosphereConfig; // 0x328
		public HGFogConfig fogConfig; // 0x3C0
		public HGHeightFogConfig heightFogConfig; // 0x414
		public HGVolumetricFogConfig volumetricFogConfig; // 0x4F0
		public HGVolumetricCloudConfig volumetricCloudConfig; // 0x660
		public HGCloudConfig cloudConfig; // 0x668
		public HGCelestialConfig celestialConfig; // 0x718
		public HGWindConfig windConfig; // 0x880
		public HGLightShaftConfig lightShaftConfig; // 0x89C
		public HGTerrainDeformConfig terrainDeformConfig; // 0x8D0
		public HGInkSimulationConfig inkSimulationConfig; // 0x8E0
		public HGRainConfig rainConfig; // 0x958
		public HGSnowConfig snowConfig; // 0xA88
		public HGStarConfig starConfig; // 0xAE0
		public HGLensFlareConfig lensFlareConfig; // 0xB78
		public HGColorGradingConfig colorGradingConfig; // 0xBA8
		public HGAutoExposureConfig autoExposureConfig; // 0xD18
		public HGShadowConfig shadowConfig; // 0xD58
		public HGAnamorphicStreaksConfig anamorphicStreaksConfig; // 0xDD8
		public HGWaterEnvConfig waterEnvConfig; // 0xE08
		private static HGEnvironmentPhase s_animatedEnvPhase; // 0x00
	
		// Constructors
		public HGAnimatedEnvironmentVolume() {} // 0x0000000189CDD3F0-0x0000000189CDE29C
		// HGAnimatedEnvironmentVolume()
		void HG::Rendering::Runtime::HGAnimatedEnvironmentVolume::HGAnimatedEnvironmentVolume(
		        HGAnimatedEnvironmentVolume *this,
		        MethodInfo *method)
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
		  __int128 v344; // [rsp+28h] [rbp-E0h] BYREF
		  Color v345; // [rsp+38h] [rbp-D0h]
		  __int128 v346; // [rsp+48h] [rbp-C0h]
		  Color v347; // [rsp+58h] [rbp-B0h]
		  __int128 v348; // [rsp+68h] [rbp-A0h]
		  __int128 v349; // [rsp+78h] [rbp-90h]
		  Color v350; // [rsp+88h] [rbp-80h]
		  __int128 v351; // [rsp+98h] [rbp-70h]
		  __int128 v352; // [rsp+A8h] [rbp-60h]
		  __int128 v353; // [rsp+B8h] [rbp-50h]
		  __int128 v354; // [rsp+C8h] [rbp-40h]
		  __int128 v355; // [rsp+D8h] [rbp-30h]
		  __int128 v356; // [rsp+E8h] [rbp-20h]
		  __int64 v357; // [rsp+F8h] [rbp-10h]
		  float a; // [rsp+100h] [rbp-8h]
		
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGLightConfig);
		  v3 = (Color *)&v344;
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
		  v23 = (Color *)&v344;
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
		  v40 = &v344;
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
		  v57 = &v344;
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
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.skyConfig, 0LL, v38, v39, (MethodInfo *)v344);
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGAtmosphereConfig);
		  v70 = TypeInfo::HG::Rendering::Runtime::HGAtmosphereConfig->static_fields;
		  v71 = *(Color *)&v70->defaultConfig.groundAlbedo.a;
		  v344 = *(_OWORD *)&v70->defaultConfig.groundRadius;
		  v72 = *(_OWORD *)&v70->defaultConfig.outerSunIrradianceColor.a;
		  v345 = v71;
		  rayleighScattering = v70->defaultConfig.rayleighScattering;
		  v346 = v72;
		  v74 = *(_OWORD *)&v70->defaultConfig.rayleighExponentialDistribution;
		  v347 = rayleighScattering;
		  v75 = *(_OWORD *)&v70->defaultConfig.mieScattering.b;
		  v348 = v74;
		  v76 = *(Color *)&v70->defaultConfig.mieAbsorption.g;
		  v349 = v75;
		  v77 = *(_OWORD *)&v70->defaultConfig.mieExponentialDistribution;
		  v350 = v76;
		  v78 = *(_OWORD *)&v70->defaultConfig.ozoneAbsorption.b;
		  v79 = *(_QWORD *)&v70->defaultConfig.tentWidth;
		  v351 = v77;
		  v352 = v78;
		  *(_QWORD *)&v353 = v79;
		  v80 = v345;
		  *(_OWORD *)&this->fields.atmosphereConfig.groundRadius = v344;
		  v81 = v346;
		  *(Color *)&this->fields.atmosphereConfig.groundAlbedo.a = v80;
		  v82 = v347;
		  *(_OWORD *)&this->fields.atmosphereConfig.outerSunIrradianceColor.a = v81;
		  v83 = v348;
		  this->fields.atmosphereConfig.rayleighScattering = v82;
		  v84 = v349;
		  *(_OWORD *)&this->fields.atmosphereConfig.rayleighExponentialDistribution = v83;
		  v85 = v350;
		  *(_OWORD *)&this->fields.atmosphereConfig.mieScattering.b = v84;
		  v86 = v351;
		  *(Color *)&this->fields.atmosphereConfig.mieAbsorption.g = v85;
		  v87 = v352;
		  v88 = v353;
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
		  v344 = *(_OWORD *)&v95->defaultConfig.enable;
		  v97 = *(_OWORD *)&v95->defaultConfig.heightFogInscatter.g;
		  v345 = v96;
		  v98 = *(Color *)&v95->defaultConfig.heightFogStartDistance;
		  v346 = v97;
		  v99 = *(_OWORD *)&v95->defaultConfig.heightFogCullingFarClipPlane;
		  v347 = v98;
		  v100 = *(_OWORD *)&v95->defaultConfig.heightFogDirectionalInscattering.g;
		  v348 = v99;
		  heightFogDirectionalInscatteringMobile = v95->defaultConfig.heightFogDirectionalInscatteringMobile;
		  v349 = v100;
		  v102 = *(_OWORD *)&v95->defaultConfig.enableVolumetricFog;
		  v95 = (HGHeightFogConfig__StaticFields *)((char *)v95 + 128);
		  v350 = heightFogDirectionalInscatteringMobile;
		  v103 = *(_QWORD *)&v95->defaultConfig.heightFogDirectionalInscattering.g;
		  v104 = *(_OWORD *)&v95->defaultConfig.enable;
		  v351 = v102;
		  v105 = *(_OWORD *)&v95->defaultConfig.heightFogStartHeightSecond;
		  v352 = v104;
		  v106 = *(_OWORD *)&v95->defaultConfig.heightFogInscatter.g;
		  v353 = v105;
		  v107 = *(_OWORD *)&v95->defaultConfig.heightFogStartDistance;
		  v354 = v106;
		  v108 = *(_OWORD *)&v95->defaultConfig.heightFogCullingFarClipPlane;
		  v355 = v107;
		  v356 = v108;
		  v357 = v103;
		  a = v95->defaultConfig.heightFogDirectionalInscattering.a;
		  v109 = v345;
		  *(_OWORD *)&this->fields.heightFogConfig.enable = v344;
		  v110 = v346;
		  *(Color *)&this->fields.heightFogConfig.heightFogStartHeightSecond = v109;
		  v111 = v347;
		  *(_OWORD *)&this->fields.heightFogConfig.heightFogInscatter.g = v110;
		  v112 = v348;
		  *(Color *)&this->fields.heightFogConfig.heightFogStartDistance = v111;
		  v113 = v349;
		  *(_OWORD *)&this->fields.heightFogConfig.heightFogCullingFarClipPlane = v112;
		  v114 = v350;
		  *(_OWORD *)&this->fields.heightFogConfig.heightFogDirectionalInscattering.g = v113;
		  v115 = v351;
		  this->fields.heightFogConfig.heightFogDirectionalInscatteringMobile = v114;
		  v116 = v352;
		  v117 = v357;
		  *(_OWORD *)&this->fields.heightFogConfig.enableVolumetricFog = v115;
		  v118 = v353;
		  *(_OWORD *)&this->fields.heightFogConfig.volumetricFogAlbedo.b = v116;
		  v119 = v354;
		  *(_OWORD *)&this->fields.heightFogConfig.volumetricFogEmissive.b = v118;
		  v120 = v355;
		  *(_OWORD *)&this->fields.heightFogConfig.volumetricFogStartDistance = v119;
		  v121 = v356;
		  *(_OWORD *)&this->fields.heightFogConfig.enableFlowNoise = v120;
		  *(_OWORD *)&this->fields.heightFogConfig.flowNoiseHorizontalDirAngle = v121;
		  *(_QWORD *)&this->fields.heightFogConfig.flowNoiseDir.z = v117;
		  *(float *)&this->fields.heightFogConfig.m_active = a;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig);
		  v124 = 2LL;
		  v125 = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig->static_fields;
		  v126 = &v344;
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
		  v141 = &v344;
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
		    (MethodInfo *)v344);
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVolumetricCloudConfig);
		  v156 = TypeInfo::HG::Rendering::Runtime::HGVolumetricCloudConfig->static_fields;
		  m_active = v156->defaultConfig.m_active;
		  *(_WORD *)&this->fields.volumetricCloudConfig.enabled = *(_WORD *)&v156->defaultConfig.enabled;
		  this->fields.volumetricCloudConfig.m_active = m_active;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGCloudConfig);
		  v158 = TypeInfo::HG::Rendering::Runtime::HGCloudConfig->static_fields;
		  cloudTint = v158->defaultConfig.cloudTint;
		  v344 = *(_OWORD *)&v158->defaultConfig.enable;
		  v160 = *(_OWORD *)&v158->defaultConfig.cloudContrast;
		  v345 = cloudTint;
		  v161 = *(Color *)&v158->defaultConfig.brightnessAffectCloudAlpha;
		  v346 = v160;
		  v162 = *(_OWORD *)&v158->defaultConfig.cloudFlowType;
		  v347 = v161;
		  v163 = *(_OWORD *)&v158->defaultConfig.flowSpeed;
		  v348 = v162;
		  v164 = *(Color *)&v158->defaultConfig.lightShaftCloudMaskTexture;
		  v349 = v163;
		  v165 = *(_OWORD *)&v158->defaultConfig.cloudShadowConfig.cloudShadowTexture;
		  v350 = v164;
		  v166 = *(_OWORD *)&v158->defaultConfig.cloudShadowConfig.cloudShadowEnvCenter.z;
		  v351 = v165;
		  v167 = *(_OWORD *)&v158->defaultConfig.cloudShadowConfig.cloudShadowFlowDirection.y;
		  v352 = v166;
		  v168 = *(_OWORD *)&v158->defaultConfig.cloudShadowConfig.cloudShadowScaleEndDistance;
		  v353 = v167;
		  v354 = v168;
		  v169 = v345;
		  *(_OWORD *)&this->fields.cloudConfig.enable = v344;
		  v170 = v346;
		  this->fields.cloudConfig.cloudTint = v169;
		  v171 = v347;
		  *(_OWORD *)&this->fields.cloudConfig.cloudContrast = v170;
		  v172 = v348;
		  *(Color *)&this->fields.cloudConfig.brightnessAffectCloudAlpha = v171;
		  v173 = v349;
		  *(_OWORD *)&this->fields.cloudConfig.cloudFlowType = v172;
		  v174 = v350;
		  *(_OWORD *)&this->fields.cloudConfig.flowSpeed = v173;
		  v175 = v351;
		  *(Color *)&this->fields.cloudConfig.lightShaftCloudMaskTexture = v174;
		  v176 = v352;
		  *(_OWORD *)&this->fields.cloudConfig.cloudShadowConfig.cloudShadowTexture = v175;
		  v177 = v353;
		  *(_OWORD *)&this->fields.cloudConfig.cloudShadowConfig.cloudShadowEnvCenter.z = v176;
		  v178 = v354;
		  *(_OWORD *)&this->fields.cloudConfig.cloudShadowConfig.cloudShadowFlowDirection.y = v177;
		  *(_OWORD *)&this->fields.cloudConfig.cloudShadowConfig.cloudShadowScaleEndDistance = v178;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.cloudConfig.cloudTexture, v179, v180, v181, (MethodInfo *)v344);
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGCelestialConfig);
		  v184 = &v344;
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
		  v202 = &v344;
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
		    (MethodInfo *)v344);
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
		    (MethodInfo *)v344);
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRainConfig);
		  v234 = 2LL;
		  v235 = TypeInfo::HG::Rendering::Runtime::HGRainConfig->static_fields;
		  v236 = &v344;
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
		  v247 = &v344;
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
		  v344 = *(_OWORD *)&v263->defaultConfig.enableStars;
		  v265 = *(_OWORD *)&v263->defaultConfig.starsTint.a;
		  v345 = v264;
		  v266 = *(Color *)&v263->defaultConfig.starsTint1.a;
		  v346 = v265;
		  v267 = *(_OWORD *)&v263->defaultConfig.brightnessRandomSeed;
		  v347 = v266;
		  v268 = *(_OWORD *)&v263->defaultConfig.skyBoxStarRangeMap;
		  v348 = v267;
		  v269 = *(Color *)&v263->defaultConfig.cloudRingStarCoverage;
		  v349 = v268;
		  v270 = *(_OWORD *)&v263->defaultConfig.nebulaMap;
		  v350 = v269;
		  v271 = *(_OWORD *)&v263->defaultConfig.nebulaTint.b;
		  v272 = *(_QWORD *)&v263->defaultConfig.m_active;
		  v351 = v270;
		  v352 = v271;
		  *(_QWORD *)&v353 = v272;
		  v273 = v345;
		  *(_OWORD *)&this->fields.starConfig.enableStars = v344;
		  v274 = v346;
		  *(Color *)&this->fields.starConfig.minMaxRange.y = v273;
		  v275 = v347;
		  *(_OWORD *)&this->fields.starConfig.starsTint.a = v274;
		  v276 = v348;
		  *(Color *)&this->fields.starConfig.starsTint1.a = v275;
		  v277 = v349;
		  *(_OWORD *)&this->fields.starConfig.brightnessRandomSeed = v276;
		  v278 = v350;
		  *(_OWORD *)&this->fields.starConfig.skyBoxStarRangeMap = v277;
		  v279 = v351;
		  *(Color *)&this->fields.starConfig.cloudRingStarCoverage = v278;
		  v280 = v352;
		  v281 = v353;
		  *(_OWORD *)&this->fields.starConfig.nebulaMap = v279;
		  *(_OWORD *)&this->fields.starConfig.nebulaTint.b = v280;
		  *(_QWORD *)&this->fields.starConfig.m_active = v281;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields.starConfig.skyBoxStarRangeMap,
		    v282,
		    v283,
		    v284,
		    (MethodInfo *)v344);
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
		    (MethodInfo *)v344);
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
		  v293 = 2LL;
		  v294 = &v344;
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
		  v309 = &v344;
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
		    (MethodInfo *)v344);
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
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.shadowConfig.csmRampTexture, v336, v337, v338, (MethodInfo *)v344);
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
		  HG::Rendering::Runtime::HGEnvironmentVolumeBase::HGEnvironmentVolumeBase((HGEnvironmentVolumeBase *)this, 0LL);
		}
		
	
		// Methods
		public override bool IsValid() => default; // 0x0000000189CDD3A4-0x0000000189CDD3F0
		// Boolean IsValid()
		bool HG::Rendering::Runtime::HGAnimatedEnvironmentVolume::IsValid(
		        HGAnimatedEnvironmentVolume *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1416, 0LL) )
		    return 1;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1416, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		public override HGEnvironmentPhase GetEnvPhaseForInterpolate() => default; // 0x0000000189CDC374-0x0000000189CDD3A4
		// HGEnvironmentPhase GetEnvPhaseForInterpolate()
		HGEnvironmentPhase *HG::Rendering::Runtime::HGAnimatedEnvironmentVolume::GetEnvPhaseForInterpolate(
		        HGAnimatedEnvironmentVolume *this,
		        MethodInfo *method)
		{
		  Object_1 *s_animatedEnvPhase; // rbx
		  Int32__Array **v4; // r9
		  Object *v5; // rax
		  Type *static_fields; // rdx
		  PropertyInfo_1 *v7; // r8
		  Int32__Array **v8; // r9
		  __int64 v9; // r8
		  HGLightConfig *p_lightConfig; // rax
		  HGEnvironmentPhase *v11; // rdx
		  bool *v12; // rcx
		  __int128 v13; // xmm1
		  __int128 v14; // xmm0
		  __int128 v15; // xmm1
		  __int128 v16; // xmm0
		  __int128 v17; // xmm1
		  __int128 v18; // xmm0
		  __int128 v19; // xmm1
		  __int128 v20; // xmm1
		  __int128 v21; // xmm0
		  __int128 v22; // xmm1
		  __int128 v23; // xmm0
		  __int128 v24; // xmm1
		  __int128 v25; // xmm0
		  int32_t sunDiscPitchYawMode; // eax
		  HGLightConfig *v27; // rcx
		  __int64 v28; // rdx
		  Color *v29; // rax
		  Color v30; // xmm1
		  Color v31; // xmm0
		  Color v32; // xmm1
		  Color v33; // xmm0
		  Color v34; // xmm1
		  Color v35; // xmm0
		  Color v36; // xmm1
		  __int64 v37; // r8
		  Color v38; // xmm1
		  Color v39; // xmm0
		  Color v40; // xmm1
		  Color v41; // xmm0
		  Color v42; // xmm1
		  Color v43; // xmm0
		  int32_t r_low; // eax
		  HGSkyConfig *p_skyConfig; // rax
		  __int128 v46; // xmm1
		  __int128 v47; // xmm0
		  __int128 v48; // xmm1
		  __int128 v49; // xmm0
		  __int128 v50; // xmm1
		  __int128 v51; // xmm0
		  __int128 v52; // xmm1
		  __int128 v53; // xmm1
		  __int128 v54; // xmm0
		  __int128 v55; // xmm1
		  __int128 v56; // xmm0
		  __int64 v57; // rax
		  HGSkyConfig *v58; // rcx
		  __int64 v59; // r8
		  __int128 *v60; // rax
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
		  __int64 v72; // rax
		  __int64 v73; // r10
		  __int64 v74; // r11
		  Int32__Array **v75; // r9
		  Color v76; // xmm1
		  __int128 v77; // xmm0
		  Color rayleighScattering; // xmm1
		  __int128 v79; // xmm0
		  __int128 v80; // xmm1
		  Color v81; // xmm0
		  __int128 v82; // xmm1
		  __int128 v83; // xmm0
		  __int64 v84; // rax
		  HGAtmosphereConfig *p_atmosphereConfig; // rcx
		  Color v86; // xmm1
		  __int128 v87; // xmm0
		  Color v88; // xmm1
		  __int128 v89; // xmm0
		  __int128 v90; // xmm1
		  Color v91; // xmm0
		  __int128 v92; // xmm1
		  __int128 v93; // xmm0
		  __int64 v94; // rax
		  __int128 v95; // xmm1
		  __int128 v96; // xmm2
		  __int128 v97; // xmm3
		  HGEnvironmentPhase *v98; // rax
		  Color inscatterAmbientColor; // xmm4
		  HGEnvironmentPhase *v100; // r8
		  Color v101; // xmm1
		  __int128 v102; // xmm0
		  Color v103; // xmm1
		  __int128 v104; // xmm0
		  __int128 v105; // xmm1
		  Color heightFogDirectionalInscatteringMobile; // xmm0
		  __int128 v107; // xmm1
		  __int64 v108; // rax
		  __int128 v109; // xmm0
		  __int128 v110; // xmm1
		  __int128 v111; // xmm0
		  __int128 v112; // xmm1
		  __int128 v113; // xmm0
		  HGHeightFogConfig *p_heightFogConfig; // rdx
		  __int64 v115; // r8
		  Color v116; // xmm1
		  __int128 v117; // xmm0
		  Color v118; // xmm1
		  __int128 v119; // xmm0
		  __int128 v120; // xmm1
		  Color v121; // xmm0
		  __int128 v122; // xmm1
		  bool *v123; // rdx
		  __int64 v124; // rax
		  __int128 v125; // xmm1
		  __int128 v126; // xmm0
		  __int128 v127; // xmm1
		  __int128 v128; // xmm0
		  HGVolumetricFogConfig *p_volumetricFogConfig; // rax
		  __int128 v130; // xmm1
		  __int128 v131; // xmm0
		  __int128 v132; // xmm1
		  __int128 v133; // xmm0
		  __int128 v134; // xmm1
		  __int128 v135; // xmm0
		  Color volumetricFogAlbedo; // xmm1
		  __int128 v137; // xmm1
		  __int128 v138; // xmm0
		  __int128 v139; // xmm1
		  __int128 v140; // xmm0
		  __int128 v141; // xmm1
		  __int128 v142; // xmm0
		  HGVolumetricFogConfig *v143; // rax
		  __int64 v144; // r8
		  __int128 *v145; // rcx
		  __int128 v146; // xmm1
		  __int128 v147; // xmm0
		  __int128 v148; // xmm1
		  __int128 v149; // xmm0
		  __int128 v150; // xmm1
		  __int128 v151; // xmm0
		  __int128 v152; // xmm1
		  __int128 v153; // xmm1
		  __int128 v154; // xmm0
		  __int128 v155; // xmm1
		  __int128 v156; // xmm0
		  __int128 v157; // xmm1
		  __int128 v158; // xmm0
		  PropertyInfo_1 *v159; // r8
		  __int64 v160; // r11
		  Int32__Array **v161; // r9
		  Color cloudTint; // xmm1
		  __int128 v163; // xmm0
		  Color v164; // xmm1
		  __int128 v165; // xmm0
		  __int128 v166; // xmm1
		  Color v167; // xmm0
		  __int128 v168; // xmm1
		  __int128 v169; // xmm0
		  __int128 v170; // xmm1
		  __int128 v171; // xmm0
		  Color v172; // xmm1
		  __int128 v173; // xmm0
		  Color v174; // xmm1
		  __int128 v175; // xmm0
		  __int128 v176; // xmm1
		  Color v177; // xmm0
		  __int128 v178; // xmm1
		  bool *v179; // rcx
		  __int128 v180; // xmm0
		  __int128 v181; // xmm1
		  __int128 v182; // xmm0
		  __int64 v183; // r10
		  __int64 v184; // r11
		  Int32__Array **v185; // r9
		  __int64 v186; // r8
		  HGCelestialConfig *p_celestialConfig; // rax
		  __int128 v188; // xmm1
		  __int128 v189; // xmm0
		  __int128 v190; // xmm1
		  __int128 v191; // xmm0
		  __int128 v192; // xmm1
		  __int128 v193; // xmm0
		  __int128 v194; // xmm1
		  __int128 v195; // xmm1
		  __int128 v196; // xmm0
		  __int128 v197; // xmm1
		  __int128 v198; // xmm0
		  __int128 v199; // xmm1
		  Material *drawMaterial; // rax
		  __int128 *v201; // rcx
		  __int64 v202; // r8
		  __int128 *v203; // rax
		  __int128 v204; // xmm1
		  __int128 v205; // xmm0
		  __int128 v206; // xmm1
		  __int128 v207; // xmm0
		  __int128 v208; // xmm1
		  __int128 v209; // xmm0
		  __int128 v210; // xmm1
		  __int128 v211; // xmm1
		  __int128 v212; // xmm0
		  __int128 v213; // xmm1
		  __int128 v214; // xmm0
		  __int128 v215; // xmm1
		  __int64 v216; // rax
		  PropertyInfo_1 *v217; // r8
		  Int32__Array **v218; // r9
		  __int64 v219; // xmm1_8
		  int v220; // eax
		  Color bloomTint; // xmm1
		  __int128 v222; // xmm2
		  HGEnvironmentPhase *v223; // rax
		  HGEnvironmentPhase *v224; // rax
		  __int128 v225; // xmm1
		  __int128 v226; // xmm2
		  __int128 v227; // xmm3
		  __int64 v228; // xmm7_8
		  __int128 v229; // xmm4
		  __int128 v230; // xmm5
		  __int128 v231; // xmm6
		  HGEnvironmentPhase *v232; // r10
		  __int64 v233; // r11
		  Int32__Array **v234; // r9
		  HGEnvironmentPhase *v235; // r8
		  HGRainConfig *p_rainConfig; // rax
		  __int128 v237; // xmm1
		  __int128 v238; // xmm0
		  __int128 v239; // xmm1
		  __int128 v240; // xmm0
		  __int128 v241; // xmm1
		  __int128 v242; // xmm0
		  __int128 v243; // xmm1
		  __int128 v244; // xmm1
		  __int128 v245; // xmm0
		  HGRainConfig *v246; // rax
		  __int128 *v247; // rcx
		  __int128 v248; // xmm1
		  __int128 v249; // xmm0
		  __int128 v250; // xmm1
		  __int128 v251; // xmm0
		  __int128 v252; // xmm1
		  __int128 v253; // xmm0
		  __int128 v254; // xmm1
		  __int128 v255; // xmm1
		  __int128 v256; // xmm0
		  Color color; // xmm1
		  __int128 v258; // xmm2
		  __int128 v259; // xmm3
		  __int64 v260; // rax
		  __int64 v261; // xmm5_8
		  __int128 v262; // xmm4
		  Color v263; // xmm1
		  __int128 v264; // xmm0
		  Color v265; // xmm1
		  __int128 v266; // xmm0
		  __int128 v267; // xmm1
		  Color v268; // xmm0
		  __int128 v269; // xmm1
		  __int128 v270; // xmm0
		  __int64 v271; // rax
		  HGStarConfig *p_starConfig; // rcx
		  Color v273; // xmm1
		  __int128 v274; // xmm0
		  Color v275; // xmm1
		  __int128 v276; // xmm0
		  __int128 v277; // xmm1
		  Color v278; // xmm0
		  __int128 v279; // xmm1
		  __int128 v280; // xmm0
		  __int64 v281; // rax
		  PropertyInfo_1 *v282; // r8
		  Int32__Array **v283; // r9
		  __int128 v284; // xmm1
		  __int128 v285; // xmm2
		  __int64 v286; // r10
		  __int64 v287; // r11
		  Int32__Array **v288; // r9
		  __int64 v289; // r8
		  HGColorGradingConfig *p_colorGradingConfig; // rax
		  __int128 v291; // xmm1
		  __int128 v292; // xmm0
		  __int128 v293; // xmm1
		  __int128 v294; // xmm0
		  __int128 v295; // xmm1
		  __int128 v296; // xmm0
		  Vector4 shadows; // xmm1
		  __int128 v298; // xmm1
		  __int128 v299; // xmm0
		  __int128 v300; // xmm1
		  __int128 v301; // xmm0
		  __int128 v302; // xmm1
		  __int128 v303; // xmm0
		  HGColorGradingConfig *v304; // rax
		  __int128 *v305; // rcx
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
		  PropertyInfo_1 *v319; // r8
		  Int32__Array **v320; // r9
		  __int128 v321; // xmm1
		  __int128 v322; // xmm2
		  __int64 v323; // xmm3_8
		  int v324; // eax
		  __int128 v325; // xmm1
		  __int128 v326; // xmm2
		  __int128 v327; // xmm3
		  __int128 v328; // xmm4
		  __int128 v329; // xmm5
		  __int128 v330; // xmm6
		  __int128 v331; // xmm7
		  Color v332; // xmm1
		  __int128 v333; // xmm2
		  HGEnvironmentPhase *v334; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v337; // [rsp+28h] [rbp-E0h] BYREF
		  Color v338; // [rsp+38h] [rbp-D0h]
		  __int128 v339; // [rsp+48h] [rbp-C0h]
		  Color v340; // [rsp+58h] [rbp-B0h]
		  __int128 v341; // [rsp+68h] [rbp-A0h]
		  __int128 v342; // [rsp+78h] [rbp-90h]
		  Color v343; // [rsp+88h] [rbp-80h]
		  __int128 v344; // [rsp+98h] [rbp-70h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1417, 0LL) )
		  {
		    s_animatedEnvPhase = (Object_1 *)TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume->static_fields->s_animatedEnvPhase;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Equality(s_animatedEnvPhase, 0LL, 0LL) )
		    {
		      v5 = UnityEngine::ScriptableObject::CreateInstance<System::Object>(MethodInfo::UnityEngine::ScriptableObject::CreateInstance<HG::Rendering::Runtime::HGEnvironmentPhase>);
		      static_fields = (Type *)TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume->static_fields;
		      static_fields->klass = (Type__Class *)v5;
		      sub_18002D1B0(
		        (SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume->static_fields,
		        static_fields,
		        v7,
		        v8,
		        (MethodInfo *)v337);
		    }
		    v9 = 2LL;
		    p_lightConfig = &this->fields.lightConfig;
		    v11 = TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume->static_fields->s_animatedEnvPhase;
		    v12 = (bool *)&v337;
		    do
		    {
		      v13 = *(_OWORD *)&p_lightConfig->directColorMode;
		      *(Color *)v12 = p_lightConfig->directColor;
		      v14 = *(_OWORD *)&p_lightConfig->directCustomColor.a;
		      *((_OWORD *)v12 + 1) = v13;
		      v15 = *(_OWORD *)&p_lightConfig->directSpecularIntensity;
		      *((_OWORD *)v12 + 2) = v14;
		      v16 = *(_OWORD *)&p_lightConfig->directPitchYaw.y;
		      *((_OWORD *)v12 + 3) = v15;
		      v17 = *(_OWORD *)&p_lightConfig->indirectSpecularFactor;
		      *((_OWORD *)v12 + 4) = v16;
		      v18 = *(_OWORD *)&p_lightConfig->atmospherePitchYaw.y;
		      *((_OWORD *)v12 + 5) = v17;
		      v19 = *(_OWORD *)&p_lightConfig->sunDiscPitchYawMode;
		      p_lightConfig = (HGLightConfig *)((char *)p_lightConfig + 128);
		      *((_OWORD *)v12 + 6) = v18;
		      v12 += 128;
		      *((_OWORD *)v12 - 1) = v19;
		      --v9;
		    }
		    while ( v9 );
		    v20 = *(_OWORD *)&p_lightConfig->directColorMode;
		    *(Color *)v12 = p_lightConfig->directColor;
		    v21 = *(_OWORD *)&p_lightConfig->directCustomColor.a;
		    *((_OWORD *)v12 + 1) = v20;
		    v22 = *(_OWORD *)&p_lightConfig->directSpecularIntensity;
		    *((_OWORD *)v12 + 2) = v21;
		    v23 = *(_OWORD *)&p_lightConfig->directPitchYaw.y;
		    *((_OWORD *)v12 + 3) = v22;
		    v24 = *(_OWORD *)&p_lightConfig->indirectSpecularFactor;
		    *((_OWORD *)v12 + 4) = v23;
		    v25 = *(_OWORD *)&p_lightConfig->atmospherePitchYaw.y;
		    sunDiscPitchYawMode = p_lightConfig->sunDiscPitchYawMode;
		    *((_OWORD *)v12 + 5) = v24;
		    *((_OWORD *)v12 + 6) = v25;
		    *((_DWORD *)v12 + 28) = sunDiscPitchYawMode;
		    if ( v11 )
		    {
		      v27 = &v11->fields.lightConfig;
		      v28 = 2LL;
		      v29 = (Color *)&v337;
		      do
		      {
		        v30 = v29[1];
		        v27->directColor = *v29;
		        v31 = v29[2];
		        *(Color *)&v27->directColorMode = v30;
		        v32 = v29[3];
		        *(Color *)&v27->directCustomColor.a = v31;
		        v33 = v29[4];
		        *(Color *)&v27->directSpecularIntensity = v32;
		        v34 = v29[5];
		        *(Color *)&v27->directPitchYaw.y = v33;
		        v35 = v29[6];
		        *(Color *)&v27->indirectSpecularFactor = v34;
		        v36 = v29[7];
		        v29 += 8;
		        *(Color *)&v27->atmospherePitchYaw.y = v35;
		        v27 = (HGLightConfig *)((char *)v27 + 128);
		        *(Color *)&v27[-1].rotationHeightFogDirectionalInscattering.y = v36;
		        --v28;
		      }
		      while ( v28 );
		      v37 = 2LL;
		      v38 = v29[1];
		      v27->directColor = *v29;
		      v39 = v29[2];
		      *(Color *)&v27->directColorMode = v38;
		      v40 = v29[3];
		      *(Color *)&v27->directCustomColor.a = v39;
		      v41 = v29[4];
		      *(Color *)&v27->directSpecularIntensity = v40;
		      v42 = v29[5];
		      *(Color *)&v27->directPitchYaw.y = v41;
		      v43 = v29[6];
		      r_low = LODWORD(v29[7].r);
		      *(Color *)&v27->indirectSpecularFactor = v42;
		      *(Color *)&v27->atmospherePitchYaw.y = v43;
		      v27->sunDiscPitchYawMode = r_low;
		      p_skyConfig = &this->fields.skyConfig;
		      v11 = TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume->static_fields->s_animatedEnvPhase;
		      v12 = (bool *)&v337;
		      do
		      {
		        v46 = *(_OWORD *)&p_skyConfig->skyDirectIntensity;
		        *(_OWORD *)v12 = *(_OWORD *)&p_skyConfig->parentEnvPhaseGuid;
		        v47 = *(_OWORD *)&p_skyConfig->customIVDefaultSH.shr2;
		        *((_OWORD *)v12 + 1) = v46;
		        v48 = *(_OWORD *)&p_skyConfig->customIVDefaultSH.shr6;
		        *((_OWORD *)v12 + 2) = v47;
		        v49 = *(_OWORD *)&p_skyConfig->customIVDefaultSH.shg1;
		        *((_OWORD *)v12 + 3) = v48;
		        v50 = *(_OWORD *)&p_skyConfig->customIVDefaultSH.shg5;
		        *((_OWORD *)v12 + 4) = v49;
		        v51 = *(_OWORD *)&p_skyConfig->customIVDefaultSH.shb0;
		        *((_OWORD *)v12 + 5) = v50;
		        v52 = *(_OWORD *)&p_skyConfig->customIVDefaultSH.shb4;
		        p_skyConfig = (HGSkyConfig *)((char *)p_skyConfig + 128);
		        *((_OWORD *)v12 + 6) = v51;
		        v12 += 128;
		        *((_OWORD *)v12 - 1) = v52;
		        --v37;
		      }
		      while ( v37 );
		      v53 = *(_OWORD *)&p_skyConfig->skyDirectIntensity;
		      *(_OWORD *)v12 = *(_OWORD *)&p_skyConfig->parentEnvPhaseGuid;
		      v54 = *(_OWORD *)&p_skyConfig->customIVDefaultSH.shr2;
		      *((_OWORD *)v12 + 1) = v53;
		      v55 = *(_OWORD *)&p_skyConfig->customIVDefaultSH.shr6;
		      *((_OWORD *)v12 + 2) = v54;
		      v56 = *(_OWORD *)&p_skyConfig->customIVDefaultSH.shg1;
		      v57 = *(_QWORD *)&p_skyConfig->customIVDefaultSH.shg5;
		      *((_OWORD *)v12 + 3) = v55;
		      *((_OWORD *)v12 + 4) = v56;
		      *((_QWORD *)v12 + 10) = v57;
		      if ( v11 )
		      {
		        v58 = &v11->fields.skyConfig;
		        v59 = 2LL;
		        v60 = &v337;
		        do
		        {
		          v61 = v60[1];
		          *(_OWORD *)&v58->parentEnvPhaseGuid = *v60;
		          v62 = v60[2];
		          *(_OWORD *)&v58->skyDirectIntensity = v61;
		          v63 = v60[3];
		          *(_OWORD *)&v58->customIVDefaultSH.shr2 = v62;
		          v64 = v60[4];
		          *(_OWORD *)&v58->customIVDefaultSH.shr6 = v63;
		          v65 = v60[5];
		          *(_OWORD *)&v58->customIVDefaultSH.shg1 = v64;
		          v66 = v60[6];
		          *(_OWORD *)&v58->customIVDefaultSH.shg5 = v65;
		          v67 = v60[7];
		          v60 += 8;
		          *(_OWORD *)&v58->customIVDefaultSH.shb0 = v66;
		          v58 = (HGSkyConfig *)((char *)v58 + 128);
		          *(_OWORD *)&v58[-1].skyboxCubeMap = v67;
		          --v59;
		        }
		        while ( v59 );
		        v68 = v60[1];
		        *(_OWORD *)&v58->parentEnvPhaseGuid = *v60;
		        v69 = v60[2];
		        *(_OWORD *)&v58->skyDirectIntensity = v68;
		        v70 = v60[3];
		        *(_OWORD *)&v58->customIVDefaultSH.shr2 = v69;
		        v71 = v60[4];
		        v72 = *((_QWORD *)v60 + 10);
		        *(_OWORD *)&v58->customIVDefaultSH.shr6 = v70;
		        *(_OWORD *)&v58->customIVDefaultSH.shg1 = v71;
		        *(_QWORD *)&v58->customIVDefaultSH.shg5 = v72;
		        sub_18002D1B0((SingleFieldAccessor *)&v11->fields.skyConfig, (Type *)v11, 0LL, v4, (MethodInfo *)v337);
		        v75 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume;
		        v12 = (bool *)&v337;
		        v11 = TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume->static_fields->s_animatedEnvPhase;
		        v76 = *(Color *)&this->fields.atmosphereConfig.groundAlbedo.a;
		        v337 = *(_OWORD *)&this->fields.atmosphereConfig.groundRadius;
		        v77 = *(_OWORD *)&this->fields.atmosphereConfig.outerSunIrradianceColor.a;
		        v338 = v76;
		        rayleighScattering = this->fields.atmosphereConfig.rayleighScattering;
		        v339 = v77;
		        v79 = *(_OWORD *)&this->fields.atmosphereConfig.rayleighExponentialDistribution;
		        v340 = rayleighScattering;
		        v80 = *(_OWORD *)&this->fields.atmosphereConfig.mieScattering.b;
		        v341 = v79;
		        v81 = *(Color *)&this->fields.atmosphereConfig.mieAbsorption.g;
		        v342 = v80;
		        v82 = *(_OWORD *)&this->fields.atmosphereConfig.mieExponentialDistribution;
		        v343 = v81;
		        v83 = *(_OWORD *)((char *)&this->fields.atmosphereConfig.groundRadius + v74);
		        v84 = *(_QWORD *)((char *)&this->fields.atmosphereConfig.groundAlbedo.a + v74);
		        *(__int128 *)((char *)&v337 + v74 - 16) = v82;
		        *(__int128 *)((char *)&v337 + v74) = v83;
		        *(_QWORD *)((char *)&v337 + v74 + 16) = v84;
		        if ( v11 )
		        {
		          p_atmosphereConfig = &v11->fields.atmosphereConfig;
		          v86 = v338;
		          *(_OWORD *)&v11->fields.atmosphereConfig.groundRadius = v337;
		          v87 = v339;
		          *(Color *)&v11->fields.atmosphereConfig.groundAlbedo.a = v86;
		          v88 = v340;
		          *(_OWORD *)&v11->fields.atmosphereConfig.outerSunIrradianceColor.a = v87;
		          v89 = v341;
		          v11->fields.atmosphereConfig.rayleighScattering = v88;
		          v90 = v342;
		          *(_OWORD *)&v11->fields.atmosphereConfig.rayleighExponentialDistribution = v89;
		          v91 = v343;
		          *(_OWORD *)&v11->fields.atmosphereConfig.mieScattering.b = v90;
		          v92 = v344;
		          *(Color *)&v11->fields.atmosphereConfig.mieAbsorption.g = v91;
		          v93 = *(__int128 *)((char *)&v337 + v74);
		          v94 = *(_QWORD *)((char *)&v337 + v74 + 16);
		          *(_OWORD *)((char *)p_atmosphereConfig + v74 - 16) = v92;
		          *(_OWORD *)((char *)&p_atmosphereConfig->groundRadius + v74) = v93;
		          *(_QWORD *)((char *)&p_atmosphereConfig->groundAlbedo.a + v74) = v94;
		          v95 = *(_OWORD *)&this->fields.fogConfig.fallOffDistance;
		          v96 = *(_OWORD *)&this->fields.fogConfig.mieScattering.a;
		          v97 = *(_OWORD *)&this->fields.fogConfig.rayleighScattering.g;
		          v98 = TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume->static_fields->s_animatedEnvPhase;
		          v12 = (bool *)*(unsigned int *)&this->fields.fogConfig.m_active;
		          inscatterAmbientColor = this->fields.fogConfig.inscatterAmbientColor;
		          if ( v98 )
		          {
		            *(_OWORD *)&v98->fields.fogConfig.enable = *(_OWORD *)&this->fields.fogConfig.enable;
		            *(_OWORD *)&v98->fields.fogConfig.fallOffDistance = v95;
		            *(_OWORD *)&v98->fields.fogConfig.mieScattering.a = v96;
		            *(_OWORD *)&v98->fields.fogConfig.rayleighScattering.g = v97;
		            v98->fields.fogConfig.inscatterAmbientColor = inscatterAmbientColor;
		            *(_DWORD *)&v98->fields.fogConfig.m_active = (_DWORD)v12;
		            v100 = TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume->static_fields->s_animatedEnvPhase;
		            v101 = *(Color *)&this->fields.heightFogConfig.heightFogStartHeightSecond;
		            v337 = *(_OWORD *)&this->fields.heightFogConfig.enable;
		            v102 = *(_OWORD *)&this->fields.heightFogConfig.heightFogInscatter.g;
		            v338 = v101;
		            v103 = *(Color *)&this->fields.heightFogConfig.heightFogStartDistance;
		            v339 = v102;
		            v104 = *(_OWORD *)&this->fields.heightFogConfig.heightFogCullingFarClipPlane;
		            v340 = v103;
		            v105 = *(_OWORD *)&this->fields.heightFogConfig.heightFogDirectionalInscattering.g;
		            v341 = v104;
		            heightFogDirectionalInscatteringMobile = this->fields.heightFogConfig.heightFogDirectionalInscatteringMobile;
		            v342 = v105;
		            v107 = *(_OWORD *)&this->fields.heightFogConfig.enableVolumetricFog;
		            v12 = &this->fields.heightFogConfig.enable + v74;
		            v343 = heightFogDirectionalInscatteringMobile;
		            v11 = (HGEnvironmentPhase *)((char *)&v337 + v74);
		            v108 = *((_QWORD *)v12 + 10);
		            v109 = *(_OWORD *)v12;
		            *(_OWORD *)&v11[-1].fields.inkWashConfig.maskConfig.edgeFade = v107;
		            v110 = *((_OWORD *)v12 + 1);
		            *(_OWORD *)&v11->klass = v109;
		            v111 = *((_OWORD *)v12 + 2);
		            *(_OWORD *)&v11->fields._._.m_CachedPtr = v110;
		            v112 = *((_OWORD *)v12 + 3);
		            *(_OWORD *)&v11->fields.lightConfig.directColor.b = v111;
		            v113 = *((_OWORD *)v12 + 4);
		            *(_OWORD *)&v11->fields.lightConfig.directCustomColor.g = v112;
		            *(_OWORD *)&v11->fields.lightConfig.directLux = v113;
		            *(_QWORD *)&v11->fields.lightConfig.directDirectionMode = v108;
		            v11->fields.lightConfig.directPitchYaw.y = *((float *)v12 + 22);
		            if ( v100 )
		            {
		              p_heightFogConfig = &v100->fields.heightFogConfig;
		              v115 = v73;
		              v116 = v338;
		              *(_OWORD *)&p_heightFogConfig->enable = v337;
		              v117 = v339;
		              *(Color *)&p_heightFogConfig->heightFogStartHeightSecond = v116;
		              v118 = v340;
		              *(_OWORD *)&p_heightFogConfig->heightFogInscatter.g = v117;
		              v119 = v341;
		              *(Color *)&p_heightFogConfig->heightFogStartDistance = v118;
		              v120 = v342;
		              *(_OWORD *)&p_heightFogConfig->heightFogCullingFarClipPlane = v119;
		              v121 = v343;
		              *(_OWORD *)&p_heightFogConfig->heightFogDirectionalInscattering.g = v120;
		              v122 = v344;
		              p_heightFogConfig->heightFogDirectionalInscatteringMobile = v121;
		              v123 = &p_heightFogConfig->enable + v74;
		              *((_OWORD *)v123 - 1) = v122;
		              v124 = *(_QWORD *)((char *)&v337 + v74 + 80);
		              v125 = *(__int128 *)((char *)&v337 + v74 + 16);
		              *(_OWORD *)v123 = *(__int128 *)((char *)&v337 + v74);
		              v126 = *(__int128 *)((char *)&v337 + v74 + 32);
		              *((_OWORD *)v123 + 1) = v125;
		              v127 = *(__int128 *)((char *)&v337 + v74 + 48);
		              *((_OWORD *)v123 + 2) = v126;
		              v128 = *(__int128 *)((char *)&v337 + v74 + 64);
		              *((_OWORD *)v123 + 3) = v127;
		              *((_OWORD *)v123 + 4) = v128;
		              *((_QWORD *)v123 + 10) = v124;
		              *((_DWORD *)v123 + 22) = *(_DWORD *)((char *)&v337 + v74 + 88);
		              p_volumetricFogConfig = &this->fields.volumetricFogConfig;
		              v11 = TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume->static_fields->s_animatedEnvPhase;
		              v12 = (bool *)&v337;
		              do
		              {
		                v130 = *(_OWORD *)&p_volumetricFogConfig->heightFogStartHeightSecond;
		                *(_OWORD *)v12 = *(_OWORD *)&p_volumetricFogConfig->enable;
		                v131 = *(_OWORD *)&p_volumetricFogConfig->heightFogInscatter.g;
		                *((_OWORD *)v12 + 1) = v130;
		                v132 = *(_OWORD *)&p_volumetricFogConfig->heightFogStartDistance;
		                *((_OWORD *)v12 + 2) = v131;
		                v133 = *(_OWORD *)&p_volumetricFogConfig->heightFogDirectionalInscatteringExponent;
		                *((_OWORD *)v12 + 3) = v132;
		                v134 = *(_OWORD *)&p_volumetricFogConfig->heightFogDirectionalInscattering.b;
		                *((_OWORD *)v12 + 4) = v133;
		                v135 = *(_OWORD *)&p_volumetricFogConfig->heightFogDirectionalInscatteringMobile.g;
		                *((_OWORD *)v12 + 5) = v134;
		                volumetricFogAlbedo = p_volumetricFogConfig->volumetricFogAlbedo;
		                p_volumetricFogConfig = (HGVolumetricFogConfig *)((char *)p_volumetricFogConfig + v74);
		                *((_OWORD *)v12 + 6) = v135;
		                v12 += v74;
		                *((Color *)v12 - 1) = volumetricFogAlbedo;
		                --v115;
		              }
		              while ( v115 );
		              v137 = *(_OWORD *)&p_volumetricFogConfig->heightFogStartHeightSecond;
		              *(_OWORD *)v12 = *(_OWORD *)&p_volumetricFogConfig->enable;
		              v138 = *(_OWORD *)&p_volumetricFogConfig->heightFogInscatter.g;
		              *((_OWORD *)v12 + 1) = v137;
		              v139 = *(_OWORD *)&p_volumetricFogConfig->heightFogStartDistance;
		              *((_OWORD *)v12 + 2) = v138;
		              v140 = *(_OWORD *)&p_volumetricFogConfig->heightFogDirectionalInscatteringExponent;
		              *((_OWORD *)v12 + 3) = v139;
		              v141 = *(_OWORD *)&p_volumetricFogConfig->heightFogDirectionalInscattering.b;
		              *((_OWORD *)v12 + 4) = v140;
		              v142 = *(_OWORD *)&p_volumetricFogConfig->heightFogDirectionalInscatteringMobile.g;
		              *((_OWORD *)v12 + 5) = v141;
		              *((_OWORD *)v12 + 6) = v142;
		              if ( v11 )
		              {
		                v143 = &v11->fields.volumetricFogConfig;
		                v144 = v73;
		                v145 = &v337;
		                do
		                {
		                  v146 = v145[1];
		                  *(_OWORD *)&v143->enable = *v145;
		                  v147 = v145[2];
		                  *(_OWORD *)&v143->heightFogStartHeightSecond = v146;
		                  v148 = v145[3];
		                  *(_OWORD *)&v143->heightFogInscatter.g = v147;
		                  v149 = v145[4];
		                  *(_OWORD *)&v143->heightFogStartDistance = v148;
		                  v150 = v145[5];
		                  *(_OWORD *)&v143->heightFogDirectionalInscatteringExponent = v149;
		                  v151 = v145[6];
		                  *(_OWORD *)&v143->heightFogDirectionalInscattering.b = v150;
		                  v152 = v145[7];
		                  v145 = (__int128 *)((char *)v145 + v74);
		                  *(_OWORD *)&v143->heightFogDirectionalInscatteringMobile.g = v151;
		                  v143 = (HGVolumetricFogConfig *)((char *)v143 + v74);
		                  *(_OWORD *)&v143[-1].m_backupFlowVLNoiseRemapRange.x = v152;
		                  --v144;
		                }
		                while ( v144 );
		                v153 = v145[1];
		                *(_OWORD *)&v143->enable = *v145;
		                v154 = v145[2];
		                *(_OWORD *)&v143->heightFogStartHeightSecond = v153;
		                v155 = v145[3];
		                *(_OWORD *)&v143->heightFogInscatter.g = v154;
		                v156 = v145[4];
		                *(_OWORD *)&v143->heightFogStartDistance = v155;
		                v157 = v145[5];
		                *(_OWORD *)&v143->heightFogDirectionalInscatteringExponent = v156;
		                v158 = v145[6];
		                *(_OWORD *)&v143->heightFogDirectionalInscattering.b = v157;
		                *(_OWORD *)&v143->heightFogDirectionalInscatteringMobile.g = v158;
		                sub_18002D1B0(
		                  (SingleFieldAccessor *)&v11->fields.volumetricFogConfig.flowVLNoise3DTexture,
		                  (Type *)v11,
		                  0LL,
		                  v75,
		                  (MethodInfo *)v337);
		                v161 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume;
		                LOBYTE(v11) = this->fields.volumetricCloudConfig.m_active;
		                v12 = (bool *)TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume->static_fields->s_animatedEnvPhase;
		                if ( v12 )
		                {
		                  *((_WORD *)v12 + 784) = *(_WORD *)&this->fields.volumetricCloudConfig.enabled;
		                  v12[1570] = (char)v11;
		                  cloudTint = this->fields.cloudConfig.cloudTint;
		                  v11 = TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume->static_fields->s_animatedEnvPhase;
		                  v337 = *(_OWORD *)&this->fields.cloudConfig.enable;
		                  v163 = *(_OWORD *)&this->fields.cloudConfig.cloudContrast;
		                  v338 = cloudTint;
		                  v164 = *(Color *)&this->fields.cloudConfig.brightnessAffectCloudAlpha;
		                  v339 = v163;
		                  v165 = *(_OWORD *)&this->fields.cloudConfig.cloudFlowType;
		                  v340 = v164;
		                  v166 = *(_OWORD *)&this->fields.cloudConfig.flowSpeed;
		                  v341 = v165;
		                  v167 = *(Color *)&this->fields.cloudConfig.lightShaftCloudMaskTexture;
		                  v342 = v166;
		                  v168 = *(_OWORD *)&this->fields.cloudConfig.cloudShadowConfig.cloudShadowTexture;
		                  v343 = v167;
		                  v12 = (bool *)&v337 + v160;
		                  v169 = *(_OWORD *)(&this->fields.cloudConfig.enable + v160);
		                  *((_OWORD *)v12 - 1) = v168;
		                  v170 = *(__int128 *)((char *)&this->fields.cloudConfig.cloudTint + v160);
		                  *(_OWORD *)v12 = v169;
		                  v171 = *(_OWORD *)((char *)&this->fields.cloudConfig.cloudContrast + v160);
		                  *((_OWORD *)v12 + 1) = v170;
		                  *((_OWORD *)v12 + 2) = v171;
		                  if ( v11 )
		                  {
		                    v172 = v338;
		                    *(_OWORD *)&v11->fields.cloudConfig.enable = v337;
		                    v173 = v339;
		                    v11->fields.cloudConfig.cloudTint = v172;
		                    v174 = v340;
		                    *(_OWORD *)&v11->fields.cloudConfig.cloudContrast = v173;
		                    v175 = v341;
		                    *(Color *)&v11->fields.cloudConfig.brightnessAffectCloudAlpha = v174;
		                    v176 = v342;
		                    *(_OWORD *)&v11->fields.cloudConfig.cloudFlowType = v175;
		                    v177 = v343;
		                    *(_OWORD *)&v11->fields.cloudConfig.flowSpeed = v176;
		                    v178 = v344;
		                    *(Color *)&v11->fields.cloudConfig.lightShaftCloudMaskTexture = v177;
		                    v179 = &v11->fields.cloudConfig.enable + v160;
		                    v180 = *(__int128 *)((char *)&v337 + v160);
		                    *((_OWORD *)v179 - 1) = v178;
		                    v181 = *(__int128 *)((char *)&v337 + v160 + 16);
		                    *(_OWORD *)v179 = v180;
		                    v182 = *(__int128 *)((char *)&v339 + v160);
		                    *((_OWORD *)v179 + 1) = v181;
		                    *((_OWORD *)v179 + 2) = v182;
		                    sub_18002D1B0(
		                      (SingleFieldAccessor *)&v11->fields.cloudConfig.cloudTexture,
		                      (Type *)v11,
		                      v159,
		                      v161,
		                      (MethodInfo *)v337);
		                    v185 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume;
		                    v12 = (bool *)&v337;
		                    v186 = v183;
		                    v11 = TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume->static_fields->s_animatedEnvPhase;
		                    p_celestialConfig = &this->fields.celestialConfig;
		                    do
		                    {
		                      v188 = *(_OWORD *)&p_celestialConfig->moonConfig.worldLongitude;
		                      *(_OWORD *)v12 = *(_OWORD *)&p_celestialConfig->moonConfig.radius;
		                      v189 = *(_OWORD *)&p_celestialConfig->moonConfig.ring.outerRadius;
		                      *((_OWORD *)v12 + 1) = v188;
		                      v190 = *(_OWORD *)&p_celestialConfig->moonConfig.ring.ringColor.b;
		                      *((_OWORD *)v12 + 2) = v189;
		                      v191 = *(_OWORD *)&p_celestialConfig->talosAlphaConfig.drawPlanetInSkydome;
		                      *((_OWORD *)v12 + 3) = v190;
		                      v192 = *(_OWORD *)&p_celestialConfig->talosAlphaConfig.objectProperty.selfTiltZ;
		                      *((_OWORD *)v12 + 4) = v191;
		                      v193 = *(_OWORD *)&p_celestialConfig->talosAlphaConfig.skydomeDrawer.drawMaterial;
		                      *((_OWORD *)v12 + 5) = v192;
		                      v194 = *(_OWORD *)&p_celestialConfig->talosAlphaConfig.skydomeDrawer.incidentLightingPitchYaw.x;
		                      p_celestialConfig = (HGCelestialConfig *)((char *)p_celestialConfig + v184);
		                      *((_OWORD *)v12 + 6) = v193;
		                      v12 += v184;
		                      *((_OWORD *)v12 - 1) = v194;
		                      --v186;
		                    }
		                    while ( v186 );
		                    v195 = *(_OWORD *)&p_celestialConfig->moonConfig.worldLongitude;
		                    *(_OWORD *)v12 = *(_OWORD *)&p_celestialConfig->moonConfig.radius;
		                    v196 = *(_OWORD *)&p_celestialConfig->moonConfig.ring.outerRadius;
		                    *((_OWORD *)v12 + 1) = v195;
		                    v197 = *(_OWORD *)&p_celestialConfig->moonConfig.ring.ringColor.b;
		                    *((_OWORD *)v12 + 2) = v196;
		                    v198 = *(_OWORD *)&p_celestialConfig->talosAlphaConfig.drawPlanetInSkydome;
		                    *((_OWORD *)v12 + 3) = v197;
		                    v199 = *(_OWORD *)&p_celestialConfig->talosAlphaConfig.objectProperty.selfTiltZ;
		                    drawMaterial = p_celestialConfig->talosAlphaConfig.skydomeDrawer.drawMaterial;
		                    *((_OWORD *)v12 + 4) = v198;
		                    *((_OWORD *)v12 + 5) = v199;
		                    *((_QWORD *)v12 + 12) = drawMaterial;
		                    if ( v11 )
		                    {
		                      v201 = (__int128 *)&v11->fields.celestialConfig;
		                      v202 = v183;
		                      v203 = &v337;
		                      do
		                      {
		                        v204 = v203[1];
		                        *v201 = *v203;
		                        v205 = v203[2];
		                        v201[1] = v204;
		                        v206 = v203[3];
		                        v201[2] = v205;
		                        v207 = v203[4];
		                        v201[3] = v206;
		                        v208 = v203[5];
		                        v201[4] = v207;
		                        v209 = v203[6];
		                        v201[5] = v208;
		                        v210 = v203[7];
		                        v203 = (__int128 *)((char *)v203 + v184);
		                        v201[6] = v209;
		                        v201 = (__int128 *)((char *)v201 + v184);
		                        *(v201 - 1) = v210;
		                        --v202;
		                      }
		                      while ( v202 );
		                      v211 = v203[1];
		                      *v201 = *v203;
		                      v212 = v203[2];
		                      v201[1] = v211;
		                      v213 = v203[3];
		                      v201[2] = v212;
		                      v214 = v203[4];
		                      v201[3] = v213;
		                      v215 = v203[5];
		                      v216 = *((_QWORD *)v203 + 12);
		                      v201[4] = v214;
		                      v201[5] = v215;
		                      *((_QWORD *)v201 + 12) = v216;
		                      sub_18002D1B0(
		                        (SingleFieldAccessor *)&v11->fields.celestialConfig.moonConfig.ring.planetRingMap,
		                        (Type *)v11,
		                        0LL,
		                        v185,
		                        (MethodInfo *)v337);
		                      v218 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume;
		                      v219 = *(_QWORD *)&this->fields.windConfig.direction.y;
		                      v12 = (bool *)TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume->static_fields->s_animatedEnvPhase;
		                      v220 = *(_DWORD *)&this->fields.windConfig.m_active;
		                      if ( v12 )
		                      {
		                        *((_OWORD *)v12 + 132) = *(_OWORD *)&this->fields.windConfig.speed;
		                        *((_QWORD *)v12 + 266) = v219;
		                        *((_DWORD *)v12 + 534) = v220;
		                        bloomTint = this->fields.lightShaftConfig.bloomTint;
		                        v222 = *(_OWORD *)&this->fields.lightShaftConfig.blurIntensity;
		                        v223 = TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume->static_fields->s_animatedEnvPhase;
		                        v12 = (bool *)*(unsigned int *)&this->fields.lightShaftConfig.m_active;
		                        if ( v223 )
		                        {
		                          *(_OWORD *)&v223->fields.lightShaftConfig.enable = *(_OWORD *)&this->fields.lightShaftConfig.enable;
		                          v223->fields.lightShaftConfig.bloomTint = bloomTint;
		                          *(_OWORD *)&v223->fields.lightShaftConfig.blurIntensity = v222;
		                          *(_DWORD *)&v223->fields.lightShaftConfig.m_active = (_DWORD)v12;
		                          v224 = TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume->static_fields->s_animatedEnvPhase;
		                          v12 = (bool *)*(unsigned int *)&this->fields.terrainDeformConfig.m_active;
		                          if ( v224 )
		                          {
		                            *(_QWORD *)&v224->fields.terrainDeformConfig.deformGlobalStrength = *(_QWORD *)&this->fields.terrainDeformConfig.deformGlobalStrength;
		                            *(_DWORD *)&v224->fields.terrainDeformConfig.m_active = (_DWORD)v12;
		                            v225 = *(_OWORD *)&this->fields.inkSimulationConfig.inkRippleDensity;
		                            v226 = *(_OWORD *)&this->fields.inkSimulationConfig.inkDebugJacobi;
		                            v227 = *(_OWORD *)&this->fields.inkSimulationConfig.resolvedShaderParams.speedFactor;
		                            v12 = (bool *)TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume->static_fields->s_animatedEnvPhase;
		                            v228 = *(_QWORD *)&this->fields.inkSimulationConfig.resolvedShaderParams.idleForceChangeSpeed;
		                            v229 = *(_OWORD *)&this->fields.inkSimulationConfig.resolvedShaderParams.forceAngleRandom;
		                            v230 = *(_OWORD *)&this->fields.inkSimulationConfig.resolvedShaderParams.landingInkSize;
		                            v231 = *(_OWORD *)&this->fields.inkSimulationConfig.resolvedShaderParams.viscosity;
		                            if ( v12 )
		                            {
		                              *((_OWORD *)v12 + 138) = *(_OWORD *)&this->fields.inkSimulationConfig.influence;
		                              *((_OWORD *)v12 + 139) = v225;
		                              *((_OWORD *)v12 + 140) = v226;
		                              *((_OWORD *)v12 + 141) = v227;
		                              *((_OWORD *)v12 + 142) = v229;
		                              *((_OWORD *)v12 + 143) = v230;
		                              *((_OWORD *)v12 + 144) = v231;
		                              *((_QWORD *)v12 + 290) = v228;
		                              sub_18002D1B0(
		                                (SingleFieldAccessor *)(v12 + 2232),
		                                (Type *)v11,
		                                v217,
		                                v218,
		                                (MethodInfo *)v337);
		                              v234 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume;
		                              v12 = (bool *)&v337;
		                              v235 = v232;
		                              v11 = TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume->static_fields->s_animatedEnvPhase;
		                              p_rainConfig = &this->fields.rainConfig;
		                              do
		                              {
		                                v237 = *(_OWORD *)&p_rainConfig->color.g;
		                                *(_OWORD *)v12 = *(_OWORD *)&p_rainConfig->enable;
		                                v238 = *(_OWORD *)&p_rainConfig->horizontalRainAngle;
		                                *((_OWORD *)v12 + 1) = v237;
		                                v239 = *(_OWORD *)&p_rainConfig->sceneEffectRainLightingPercent;
		                                *((_OWORD *)v12 + 2) = v238;
		                                v240 = *(_OWORD *)&p_rainConfig->middleHorizontalRainAngle;
		                                *((_OWORD *)v12 + 3) = v239;
		                                v241 = *(_OWORD *)&p_rainConfig->farRainAlphaMultiplier;
		                                *((_OWORD *)v12 + 4) = v240;
		                                v242 = *(_OWORD *)&p_rainConfig->rainWaveHorizontalSpeed;
		                                *((_OWORD *)v12 + 5) = v241;
		                                v243 = *(_OWORD *)&p_rainConfig->screenDropColor.g;
		                                p_rainConfig = (HGRainConfig *)((char *)p_rainConfig + v233);
		                                *((_OWORD *)v12 + 6) = v242;
		                                v12 += v233;
		                                *((_OWORD *)v12 - 1) = v243;
		                                v235 = (HGEnvironmentPhase *)((char *)v235 - 1);
		                              }
		                              while ( v235 );
		                              v244 = *(_OWORD *)&p_rainConfig->color.g;
		                              *(_OWORD *)v12 = *(_OWORD *)&p_rainConfig->enable;
		                              v245 = *(_OWORD *)&p_rainConfig->horizontalRainAngle;
		                              *((_OWORD *)v12 + 1) = v244;
		                              *((_OWORD *)v12 + 2) = v245;
		                              if ( v11 )
		                              {
		                                v246 = &v11->fields.rainConfig;
		                                v11 = v232;
		                                v247 = &v337;
		                                do
		                                {
		                                  v248 = v247[1];
		                                  *(_OWORD *)&v246->enable = *v247;
		                                  v249 = v247[2];
		                                  *(_OWORD *)&v246->color.g = v248;
		                                  v250 = v247[3];
		                                  *(_OWORD *)&v246->horizontalRainAngle = v249;
		                                  v251 = v247[4];
		                                  *(_OWORD *)&v246->sceneEffectRainLightingPercent = v250;
		                                  v252 = v247[5];
		                                  *(_OWORD *)&v246->middleHorizontalRainAngle = v251;
		                                  v253 = v247[6];
		                                  *(_OWORD *)&v246->farRainAlphaMultiplier = v252;
		                                  v254 = v247[7];
		                                  v247 = (__int128 *)((char *)v247 + v233);
		                                  *(_OWORD *)&v246->rainWaveHorizontalSpeed = v253;
		                                  v246 = (HGRainConfig *)((char *)v246 + v233);
		                                  *(_OWORD *)&v246[-1].farRainDirection.x = v254;
		                                  v11 = (HGEnvironmentPhase *)((char *)v11 - 1);
		                                }
		                                while ( v11 );
		                                v255 = v247[1];
		                                *(_OWORD *)&v246->enable = *v247;
		                                v256 = v247[2];
		                                *(_OWORD *)&v246->color.g = v255;
		                                *(_OWORD *)&v246->horizontalRainAngle = v256;
		                                color = this->fields.snowConfig.color;
		                                v12 = (bool *)TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume->static_fields;
		                                v258 = *(_OWORD *)&this->fields.snowConfig.snowSizeRange.x;
		                                v259 = *(_OWORD *)&this->fields.snowConfig.snowTrailLength;
		                                v260 = *(_QWORD *)v12;
		                                v261 = *(_QWORD *)&this->fields.snowConfig.snowDirection.z;
		                                v262 = *(_OWORD *)&this->fields.snowConfig.snowLightingPercent;
		                                if ( *(_QWORD *)v12 )
		                                {
		                                  *(_OWORD *)(v260 + 2632) = *(_OWORD *)&this->fields.snowConfig.enable;
		                                  *(Color *)(v260 + 2648) = color;
		                                  *(_OWORD *)(v260 + 2664) = v258;
		                                  *(_OWORD *)(v260 + 2680) = v259;
		                                  *(_OWORD *)(v260 + 2696) = v262;
		                                  *(_QWORD *)(v260 + 2712) = v261;
		                                  v263 = *(Color *)&this->fields.starConfig.minMaxRange.y;
		                                  v11 = TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume->static_fields->s_animatedEnvPhase;
		                                  v12 = (bool *)&v337;
		                                  v337 = *(_OWORD *)&this->fields.starConfig.enableStars;
		                                  v264 = *(_OWORD *)&this->fields.starConfig.starsTint.a;
		                                  v338 = v263;
		                                  v265 = *(Color *)&this->fields.starConfig.starsTint1.a;
		                                  v339 = v264;
		                                  v266 = *(_OWORD *)&this->fields.starConfig.brightnessRandomSeed;
		                                  v340 = v265;
		                                  v267 = *(_OWORD *)&this->fields.starConfig.skyBoxStarRangeMap;
		                                  v341 = v266;
		                                  v268 = *(Color *)&this->fields.starConfig.cloudRingStarCoverage;
		                                  v342 = v267;
		                                  v269 = *(_OWORD *)&this->fields.starConfig.nebulaMap;
		                                  v343 = v268;
		                                  v270 = *(_OWORD *)(&this->fields.starConfig.enableStars + v233);
		                                  v271 = *(_QWORD *)((char *)&this->fields.starConfig.minMaxRange.y + v233);
		                                  *(__int128 *)((char *)&v337 + v233 - 16) = v269;
		                                  *(__int128 *)((char *)&v337 + v233) = v270;
		                                  *(_QWORD *)((char *)&v337 + v233 + 16) = v271;
		                                  if ( v11 )
		                                  {
		                                    p_starConfig = &v11->fields.starConfig;
		                                    v273 = v338;
		                                    *(_OWORD *)&v11->fields.starConfig.enableStars = v337;
		                                    v274 = v339;
		                                    *(Color *)&v11->fields.starConfig.minMaxRange.y = v273;
		                                    v275 = v340;
		                                    *(_OWORD *)&v11->fields.starConfig.starsTint.a = v274;
		                                    v276 = v341;
		                                    *(Color *)&v11->fields.starConfig.starsTint1.a = v275;
		                                    v277 = v342;
		                                    *(_OWORD *)&v11->fields.starConfig.brightnessRandomSeed = v276;
		                                    v278 = v343;
		                                    *(_OWORD *)&v11->fields.starConfig.skyBoxStarRangeMap = v277;
		                                    v279 = v344;
		                                    *(Color *)&v11->fields.starConfig.cloudRingStarCoverage = v278;
		                                    v280 = *(__int128 *)((char *)&v337 + v233);
		                                    v281 = *(_QWORD *)((char *)&v337 + v233 + 16);
		                                    *(_OWORD *)((char *)p_starConfig + v233 - 16) = v279;
		                                    *(_OWORD *)(&p_starConfig->enableStars + v233) = v280;
		                                    *(_QWORD *)((char *)&p_starConfig->minMaxRange.y + v233) = v281;
		                                    sub_18002D1B0(
		                                      (SingleFieldAccessor *)&v11->fields.starConfig.skyBoxStarRangeMap,
		                                      (Type *)v11,
		                                      0LL,
		                                      v234,
		                                      (MethodInfo *)v337);
		                                    v283 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume;
		                                    v284 = *(_OWORD *)&this->fields.lensFlareConfig.intensity;
		                                    v285 = *(_OWORD *)&this->fields.lensFlareConfig.sampleCount;
		                                    v12 = (bool *)TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume->static_fields->s_animatedEnvPhase;
		                                    if ( v12 )
		                                    {
		                                      *(_OWORD *)(v12 + 2872) = *(_OWORD *)&this->fields.lensFlareConfig.enable;
		                                      *(_OWORD *)(v12 + 2888) = v284;
		                                      *(_OWORD *)(v12 + 2904) = v285;
		                                      sub_18002D1B0(
		                                        (SingleFieldAccessor *)(v12 + 2880),
		                                        (Type *)v11,
		                                        v282,
		                                        v283,
		                                        (MethodInfo *)v337);
		                                      v288 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume;
		                                      v12 = (bool *)&v337;
		                                      v289 = v286;
		                                      v11 = TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume->static_fields->s_animatedEnvPhase;
		                                      p_colorGradingConfig = &this->fields.colorGradingConfig;
		                                      do
		                                      {
		                                        v291 = *(_OWORD *)&p_colorGradingConfig->colorLookupContribution;
		                                        *(_OWORD *)v12 = *(_OWORD *)&p_colorGradingConfig->tonemappingMode;
		                                        v292 = *(_OWORD *)&p_colorGradingConfig->colorAdjustmentsEnabled;
		                                        *((_OWORD *)v12 + 1) = v291;
		                                        v293 = *(_OWORD *)&p_colorGradingConfig->colorAdjustmentsColorFilter.g;
		                                        *((_OWORD *)v12 + 2) = v292;
		                                        v294 = *(_OWORD *)&p_colorGradingConfig->colorAdjustmentsSaturation;
		                                        *((_OWORD *)v12 + 3) = v293;
		                                        v295 = *(_OWORD *)&p_colorGradingConfig->channelMixerRedOutBlueIn;
		                                        *((_OWORD *)v12 + 4) = v294;
		                                        v296 = *(_OWORD *)&p_colorGradingConfig->channelMixerBlueOutRedIn;
		                                        *((_OWORD *)v12 + 5) = v295;
		                                        shadows = p_colorGradingConfig->shadowsMidtonesHighlights.shadows;
		                                        p_colorGradingConfig = (HGColorGradingConfig *)((char *)p_colorGradingConfig
		                                                                                      + v287);
		                                        *((_OWORD *)v12 + 6) = v296;
		                                        v12 += v287;
		                                        *((Vector4 *)v12 - 1) = shadows;
		                                        --v289;
		                                      }
		                                      while ( v289 );
		                                      v298 = *(_OWORD *)&p_colorGradingConfig->colorLookupContribution;
		                                      *(_OWORD *)v12 = *(_OWORD *)&p_colorGradingConfig->tonemappingMode;
		                                      v299 = *(_OWORD *)&p_colorGradingConfig->colorAdjustmentsEnabled;
		                                      *((_OWORD *)v12 + 1) = v298;
		                                      v300 = *(_OWORD *)&p_colorGradingConfig->colorAdjustmentsColorFilter.g;
		                                      *((_OWORD *)v12 + 2) = v299;
		                                      v301 = *(_OWORD *)&p_colorGradingConfig->colorAdjustmentsSaturation;
		                                      *((_OWORD *)v12 + 3) = v300;
		                                      v302 = *(_OWORD *)&p_colorGradingConfig->channelMixerRedOutBlueIn;
		                                      *((_OWORD *)v12 + 4) = v301;
		                                      v303 = *(_OWORD *)&p_colorGradingConfig->channelMixerBlueOutRedIn;
		                                      *((_OWORD *)v12 + 5) = v302;
		                                      *((_OWORD *)v12 + 6) = v303;
		                                      if ( v11 )
		                                      {
		                                        v304 = &v11->fields.colorGradingConfig;
		                                        v305 = &v337;
		                                        do
		                                        {
		                                          v306 = v305[1];
		                                          *(_OWORD *)&v304->tonemappingMode = *v305;
		                                          v307 = v305[2];
		                                          *(_OWORD *)&v304->colorLookupContribution = v306;
		                                          v308 = v305[3];
		                                          *(_OWORD *)&v304->colorAdjustmentsEnabled = v307;
		                                          v309 = v305[4];
		                                          *(_OWORD *)&v304->colorAdjustmentsColorFilter.g = v308;
		                                          v310 = v305[5];
		                                          *(_OWORD *)&v304->colorAdjustmentsSaturation = v309;
		                                          v311 = v305[6];
		                                          *(_OWORD *)&v304->channelMixerRedOutBlueIn = v310;
		                                          v312 = v305[7];
		                                          v305 = (__int128 *)((char *)v305 + v287);
		                                          *(_OWORD *)&v304->channelMixerBlueOutRedIn = v311;
		                                          v304 = (HGColorGradingConfig *)((char *)v304 + v287);
		                                          *(_OWORD *)&v304[-1].colorCurves.masterOverriding = v312;
		                                          --v286;
		                                        }
		                                        while ( v286 );
		                                        v313 = v305[1];
		                                        *(_OWORD *)&v304->tonemappingMode = *v305;
		                                        v314 = v305[2];
		                                        *(_OWORD *)&v304->colorLookupContribution = v313;
		                                        v315 = v305[3];
		                                        *(_OWORD *)&v304->colorAdjustmentsEnabled = v314;
		                                        v316 = v305[4];
		                                        *(_OWORD *)&v304->colorAdjustmentsColorFilter.g = v315;
		                                        v317 = v305[5];
		                                        *(_OWORD *)&v304->colorAdjustmentsSaturation = v316;
		                                        v318 = v305[6];
		                                        *(_OWORD *)&v304->channelMixerRedOutBlueIn = v317;
		                                        *(_OWORD *)&v304->channelMixerBlueOutRedIn = v318;
		                                        sub_18002D1B0(
		                                          (SingleFieldAccessor *)&v11->fields.colorGradingConfig.colorLookupTexture,
		                                          (Type *)v11,
		                                          0LL,
		                                          v288,
		                                          (MethodInfo *)v337);
		                                        v320 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume;
		                                        v321 = *(_OWORD *)&this->fields.autoExposureConfig.autoExposureEv100Range.x;
		                                        v322 = *(_OWORD *)&this->fields.autoExposureConfig.autoExposureMeteringMode;
		                                        v323 = *(_QWORD *)&this->fields.autoExposureConfig.autoExposureEvClampRange.y;
		                                        v12 = (bool *)TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume->static_fields->s_animatedEnvPhase;
		                                        v324 = *(_DWORD *)&this->fields.autoExposureConfig.m_active;
		                                        if ( v12 )
		                                        {
		                                          *(_OWORD *)(v12 + 3288) = *(_OWORD *)&this->fields.autoExposureConfig.autoExposureMode;
		                                          *(_OWORD *)(v12 + 3304) = v321;
		                                          *(_OWORD *)(v12 + 3320) = v322;
		                                          *((_QWORD *)v12 + 417) = v323;
		                                          *((_DWORD *)v12 + 836) = v324;
		                                          v325 = *(_OWORD *)&this->fields.shadowConfig.csmIntensity;
		                                          v326 = *(_OWORD *)&this->fields.shadowConfig.csmShadowSoftness;
		                                          v327 = *(_OWORD *)&this->fields.shadowConfig.contactShadowSurfaceThickness;
		                                          v12 = (bool *)TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume->static_fields->s_animatedEnvPhase;
		                                          v328 = *(_OWORD *)&this->fields.shadowConfig.overrideCsmFarDistance;
		                                          v329 = *(_OWORD *)&this->fields.shadowConfig.overrideCsmSpherePosition.z;
		                                          v330 = *(_OWORD *)&this->fields.shadowConfig.csmSimulatedAttenuation;
		                                          v331 = *(_OWORD *)&this->fields.shadowConfig.rhodesShipCenter.z;
		                                          if ( v12 )
		                                          {
		                                            *(_OWORD *)(v12 + 3352) = *(_OWORD *)&this->fields.shadowConfig.csmDepthBias;
		                                            *(_OWORD *)(v12 + 3368) = v325;
		                                            *(_OWORD *)(v12 + 3384) = v326;
		                                            *(_OWORD *)(v12 + 3400) = v327;
		                                            *(_OWORD *)(v12 + 3416) = v328;
		                                            *(_OWORD *)(v12 + 3432) = v329;
		                                            *(_OWORD *)(v12 + 3448) = v330;
		                                            *(_OWORD *)(v12 + 3464) = v331;
		                                            sub_18002D1B0(
		                                              (SingleFieldAccessor *)(v12 + 3376),
		                                              (Type *)v11,
		                                              v319,
		                                              v320,
		                                              (MethodInfo *)v337);
		                                            v332 = this->fields.anamorphicStreaksConfig.bloomTint;
		                                            v333 = *(_OWORD *)&this->fields.anamorphicStreaksConfig.blurIntensity;
		                                            v12 = (bool *)TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume->static_fields->s_animatedEnvPhase;
		                                            if ( v12 )
		                                            {
		                                              *(_OWORD *)(v12 + 3480) = *(_OWORD *)&this->fields.anamorphicStreaksConfig.enable;
		                                              *(Color *)(v12 + 3496) = v332;
		                                              *(_OWORD *)(v12 + 3512) = v333;
		                                              v334 = TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume->static_fields->s_animatedEnvPhase;
		                                              v12 = (bool *)*(unsigned int *)&this->fields.waterEnvConfig.m_active;
		                                              if ( v334 )
		                                              {
		                                                *(_QWORD *)&v334->fields.waterEnvConfig.enableWaterInteractionAdjust = *(_QWORD *)&this->fields.waterEnvConfig.enableWaterInteractionAdjust;
		                                                *(_DWORD *)&v334->fields.waterEnvConfig.m_active = (_DWORD)v12;
		                                                return TypeInfo::HG::Rendering::Runtime::HGAnimatedEnvironmentVolume->static_fields->s_animatedEnvPhase;
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
		LABEL_52:
		    sub_1800D8260(v12, v11);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1417, 0LL);
		  if ( !Patch )
		    goto LABEL_52;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_210(Patch, (Object *)this, 0LL);
		}
		
	}
}
