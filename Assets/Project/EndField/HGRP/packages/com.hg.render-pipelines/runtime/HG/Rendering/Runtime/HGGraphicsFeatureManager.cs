using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGGraphicsFeatureManager // TypeDefIndex: 37532
	{
		// Fields
		public static HGGraphicsFeatureSwitch csm; // 0x00
		public static HGGraphicsFeatureSwitch asm; // 0x08
		public static HGGraphicsFeatureSwitch cloudShadow; // 0x10
		public static HGGraphicsFeatureSwitch characterShadow; // 0x18
		public static HGGraphicsFeatureSwitch punctualLightShadow; // 0x20
		public static HGGraphicsFeatureSwitch hdplsCharacterShadow; // 0x28
		public static HGGraphicsFeatureSwitch contactShadow; // 0x30
		public static HGGraphicsFeatureSwitch preZ; // 0x38
		public static HGGraphicsFeatureSwitch deferred; // 0x40
		public static HGGraphicsFeatureSwitch characterPrePass; // 0x48
		public static HGGraphicsFeatureSwitch customDepthPass; // 0x50
		public static HGGraphicsFeatureSwitch deferredOpaque; // 0x58
		public static HGGraphicsFeatureSwitch deferredOpaquePreZ; // 0x60
		public static HGGraphicsFeatureSwitch deferredOpaqueEqual; // 0x68
		public static HGGraphicsFeatureSwitch deferredGrassPreZ; // 0x70
		public static HGGraphicsFeatureSwitch deferredGrass; // 0x78
		public static HGGraphicsFeatureSwitch deferredTreePreZ; // 0x80
		public static HGGraphicsFeatureSwitch deferredTree; // 0x88
		public static HGGraphicsFeatureSwitch deferredDecal; // 0x90
		public static HGGraphicsFeatureSwitch deferredErosion; // 0x98
		public static HGGraphicsFeatureSwitch deferredSludge; // 0xA0
		public static HGGraphicsFeatureSwitch forward; // 0xA8
		public static HGGraphicsFeatureSwitch forwardTransparent; // 0xB0
		public static HGGraphicsFeatureSwitch forwardOpaque; // 0xB8
		public static HGGraphicsFeatureSwitch forwardOpaquePreZ; // 0xC0
		public static HGGraphicsFeatureSwitch forwardOpaqueEqual; // 0xC8
		public static HGGraphicsFeatureSwitch forwardDecal; // 0xD0
		public static HGGraphicsFeatureSwitch forwardCharacter; // 0xD8
		public static HGGraphicsFeatureSwitch characterOutlineOpaque; // 0xE0
		public static HGGraphicsFeatureSwitch characterOutlineOpaquePreZ; // 0xE8
		public static HGGraphicsFeatureSwitch characterOutlineOpaqueEqual; // 0xF0
		public static HGGraphicsFeatureSwitch vfxDecal; // 0xF8
		public static HGGraphicsFeatureSwitch distortionOpaque; // 0x100
		public static HGGraphicsFeatureSwitch distortionTransparent; // 0x108
		public static HGGraphicsFeatureSwitch UI; // 0x110
		public static HGGraphicsFeatureSwitch UISprite; // 0x118
		public static HGGraphicsFeatureSwitch UIWorld; // 0x120
		public static HGGraphicsFeatureSwitch UIDistortion; // 0x128
		public static HGGraphicsFeatureSwitch UIFrostedGlass; // 0x130
		public static HGGraphicsFeatureSwitch deferredShading; // 0x138
		public static HGGraphicsFeatureSwitch deferredShadingDefaultLit; // 0x140
		public static HGGraphicsFeatureSwitch deferredShadingTwoSidedFoliage; // 0x148
		public static HGGraphicsFeatureSwitch deferredShadingSubsurface; // 0x150
		public static HGGraphicsFeatureSwitch splitDeferredShadingStage; // 0x158
		public static HGGraphicsFeatureSwitch usePerLightDynamicLighting; // 0x160
		public static HGGraphicsFeatureSwitch deferredShadingDirectionalLightStage; // 0x168
		public static HGGraphicsFeatureSwitch deferredShadingDynamicLightStage; // 0x170
		public static HGGraphicsFeatureSwitch deferredShadingIndirectStage; // 0x178
		public static HGGraphicsFeatureSwitch usePerTileDeferredLighting; // 0x180
		public static HGGraphicsFeatureSwitch terrain; // 0x188
		public static HGGraphicsFeatureSwitch terrainDeform; // 0x190
		public static HGGraphicsFeatureSwitch terrainPreDepth; // 0x198
		public static HGGraphicsFeatureSwitch terrainScreenSpace; // 0x1A0
		public static HGGraphicsFeatureSwitch terrainPostGBuffer; // 0x1A8
		public static HGGraphicsFeatureSwitch terrainVTBake; // 0x1B0
		public static HGGraphicsFeatureSwitch terrainIndirectionUpdate; // 0x1B8
		public static HGGraphicsFeatureSwitch terrainDepthPrepass; // 0x1C0
		public static HGGraphicsFeatureSwitch terrainSimpleSubsurface; // 0x1C8
		public static HGGraphicsFeatureSwitch terrainSubdivision; // 0x1D0
		public static HGGraphicsFeatureSwitch terrainSubdivisionV2; // 0x1D8
		public static HGGraphicsFeatureSwitch terrainSubdivisionHZBCulling; // 0x1E0
		public static HGGraphicsFeatureSwitch terrainNewEditorRendering; // 0x1E8
		public static HGGraphicsFeatureSwitch terrainDecalInteraction; // 0x1F0
		public static HGGraphicsFeatureSwitch irradianceVolumeV2; // 0x1F8
		public static HGGraphicsFeatureSwitch irradianceVolumeV3; // 0x200
	
		// Constructors
		public HGGraphicsFeatureManager() {} // 0x00000001841E1670-0x00000001841E1680
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
		
		static HGGraphicsFeatureManager() {} // 0x0000000184579410-0x000000018457A600
		// HGGraphicsFeatureManager()
		void HG::Rendering::Runtime::HGGraphicsFeatureManager::cctor(MethodInfo *method)
		{
		  __int64 v1; // rax
		  __int64 v2; // rdx
		  __int64 v3; // rcx
		  PropertyInfo_1 *v4; // r8
		  Int32__Array **v5; // r9
		  Type *static_fields; // rdx
		  __int64 v7; // rax
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  Type *v10; // rdx
		  __int64 v11; // rax
		  PropertyInfo_1 *v12; // r8
		  Int32__Array **v13; // r9
		  Type *v14; // rdx
		  __int64 v15; // rax
		  PropertyInfo_1 *v16; // r8
		  Int32__Array **v17; // r9
		  Type *v18; // rdx
		  __int64 v19; // rax
		  PropertyInfo_1 *v20; // r8
		  Int32__Array **v21; // r9
		  Type *v22; // rdx
		  __int64 v23; // rax
		  PropertyInfo_1 *v24; // r8
		  Int32__Array **v25; // r9
		  Type *v26; // rdx
		  __int64 v27; // rax
		  PropertyInfo_1 *v28; // r8
		  Int32__Array **v29; // r9
		  Type *v30; // rdx
		  __int64 v31; // rax
		  PropertyInfo_1 *v32; // r8
		  Int32__Array **v33; // r9
		  Type *v34; // rdx
		  __int64 v35; // rax
		  PropertyInfo_1 *v36; // r8
		  Int32__Array **v37; // r9
		  Type *v38; // rdx
		  __int64 v39; // rax
		  PropertyInfo_1 *v40; // r8
		  Int32__Array **v41; // r9
		  Type *v42; // rdx
		  __int64 v43; // rax
		  PropertyInfo_1 *v44; // r8
		  Int32__Array **v45; // r9
		  Type *v46; // rdx
		  __int64 v47; // rax
		  PropertyInfo_1 *v48; // r8
		  Int32__Array **v49; // r9
		  Type *v50; // rdx
		  __int64 v51; // rax
		  PropertyInfo_1 *v52; // r8
		  Int32__Array **v53; // r9
		  Type *v54; // rdx
		  __int64 v55; // rax
		  PropertyInfo_1 *v56; // r8
		  Int32__Array **v57; // r9
		  Type *v58; // rdx
		  __int64 v59; // rax
		  PropertyInfo_1 *v60; // r8
		  Int32__Array **v61; // r9
		  Type *v62; // rdx
		  __int64 v63; // rax
		  PropertyInfo_1 *v64; // r8
		  Int32__Array **v65; // r9
		  Type *v66; // rdx
		  __int64 v67; // rax
		  PropertyInfo_1 *v68; // r8
		  Int32__Array **v69; // r9
		  Type *v70; // rdx
		  __int64 v71; // rax
		  PropertyInfo_1 *v72; // r8
		  Int32__Array **v73; // r9
		  Type *v74; // rdx
		  __int64 v75; // rax
		  PropertyInfo_1 *v76; // r8
		  Int32__Array **v77; // r9
		  Type *v78; // rdx
		  __int64 v79; // rax
		  PropertyInfo_1 *v80; // r8
		  Int32__Array **v81; // r9
		  Type *v82; // rdx
		  __int64 v83; // rax
		  PropertyInfo_1 *v84; // r8
		  Int32__Array **v85; // r9
		  Type *v86; // rdx
		  __int64 v87; // rax
		  PropertyInfo_1 *v88; // r8
		  Int32__Array **v89; // r9
		  Type *v90; // rdx
		  __int64 v91; // rax
		  PropertyInfo_1 *v92; // r8
		  Int32__Array **v93; // r9
		  Type *v94; // rdx
		  __int64 v95; // rax
		  PropertyInfo_1 *v96; // r8
		  Int32__Array **v97; // r9
		  Type *v98; // rdx
		  __int64 v99; // rax
		  PropertyInfo_1 *v100; // r8
		  Int32__Array **v101; // r9
		  Type *v102; // rdx
		  __int64 v103; // rax
		  PropertyInfo_1 *v104; // r8
		  Int32__Array **v105; // r9
		  Type *v106; // rdx
		  __int64 v107; // rax
		  PropertyInfo_1 *v108; // r8
		  Int32__Array **v109; // r9
		  Type *v110; // rdx
		  __int64 v111; // rax
		  PropertyInfo_1 *v112; // r8
		  Int32__Array **v113; // r9
		  Type *v114; // rdx
		  __int64 v115; // rax
		  PropertyInfo_1 *v116; // r8
		  Int32__Array **v117; // r9
		  Type *v118; // rdx
		  __int64 v119; // rax
		  PropertyInfo_1 *v120; // r8
		  Int32__Array **v121; // r9
		  Type *v122; // rdx
		  __int64 v123; // rax
		  PropertyInfo_1 *v124; // r8
		  Int32__Array **v125; // r9
		  Type *v126; // rdx
		  __int64 v127; // rax
		  PropertyInfo_1 *v128; // r8
		  Int32__Array **v129; // r9
		  Type *v130; // rdx
		  __int64 v131; // rax
		  PropertyInfo_1 *v132; // r8
		  Int32__Array **v133; // r9
		  Type *v134; // rdx
		  __int64 v135; // rax
		  PropertyInfo_1 *v136; // r8
		  Int32__Array **v137; // r9
		  Type *v138; // rdx
		  __int64 v139; // rax
		  PropertyInfo_1 *v140; // r8
		  Int32__Array **v141; // r9
		  Type *v142; // rdx
		  __int64 v143; // rax
		  PropertyInfo_1 *v144; // r8
		  Int32__Array **v145; // r9
		  Type *v146; // rdx
		  __int64 v147; // rax
		  PropertyInfo_1 *v148; // r8
		  Int32__Array **v149; // r9
		  Type *v150; // rdx
		  __int64 v151; // rax
		  PropertyInfo_1 *v152; // r8
		  Int32__Array **v153; // r9
		  Type *v154; // rdx
		  __int64 v155; // rax
		  PropertyInfo_1 *v156; // r8
		  Int32__Array **v157; // r9
		  Type *v158; // rdx
		  __int64 v159; // rax
		  PropertyInfo_1 *v160; // r8
		  Int32__Array **v161; // r9
		  Type *v162; // rdx
		  __int64 v163; // rax
		  PropertyInfo_1 *v164; // r8
		  Int32__Array **v165; // r9
		  Type *v166; // rdx
		  __int64 v167; // rax
		  PropertyInfo_1 *v168; // r8
		  Int32__Array **v169; // r9
		  Type *v170; // rdx
		  __int64 v171; // rax
		  PropertyInfo_1 *v172; // r8
		  Int32__Array **v173; // r9
		  Type *v174; // rdx
		  __int64 v175; // rax
		  PropertyInfo_1 *v176; // r8
		  Int32__Array **v177; // r9
		  Type *v178; // rdx
		  __int64 v179; // rax
		  PropertyInfo_1 *v180; // r8
		  Int32__Array **v181; // r9
		  Type *v182; // rdx
		  __int64 v183; // rax
		  PropertyInfo_1 *v184; // r8
		  Int32__Array **v185; // r9
		  Type *v186; // rdx
		  __int64 v187; // rax
		  PropertyInfo_1 *v188; // r8
		  Int32__Array **v189; // r9
		  Type *v190; // rdx
		  __int64 v191; // rax
		  PropertyInfo_1 *v192; // r8
		  Int32__Array **v193; // r9
		  Type *v194; // rdx
		  __int64 v195; // rax
		  PropertyInfo_1 *v196; // r8
		  Int32__Array **v197; // r9
		  Type *v198; // rdx
		  __int64 v199; // rax
		  PropertyInfo_1 *v200; // r8
		  Int32__Array **v201; // r9
		  Type *v202; // rdx
		  __int64 v203; // rax
		  PropertyInfo_1 *v204; // r8
		  Int32__Array **v205; // r9
		  Type *v206; // rdx
		  __int64 v207; // rax
		  PropertyInfo_1 *v208; // r8
		  Int32__Array **v209; // r9
		  Type *v210; // rdx
		  __int64 v211; // rax
		  PropertyInfo_1 *v212; // r8
		  Int32__Array **v213; // r9
		  Type *v214; // rdx
		  __int64 v215; // rax
		  PropertyInfo_1 *v216; // r8
		  Int32__Array **v217; // r9
		  Type *v218; // rdx
		  __int64 v219; // rax
		  PropertyInfo_1 *v220; // r8
		  Int32__Array **v221; // r9
		  Type *v222; // rdx
		  __int64 v223; // rax
		  PropertyInfo_1 *v224; // r8
		  Int32__Array **v225; // r9
		  Type *v226; // rdx
		  __int64 v227; // rax
		  PropertyInfo_1 *v228; // r8
		  Int32__Array **v229; // r9
		  Type *v230; // rdx
		  __int64 v231; // rax
		  PropertyInfo_1 *v232; // r8
		  Int32__Array **v233; // r9
		  Type *v234; // rdx
		  __int64 v235; // rax
		  PropertyInfo_1 *v236; // r8
		  Int32__Array **v237; // r9
		  Type *v238; // rdx
		  __int64 v239; // rax
		  PropertyInfo_1 *v240; // r8
		  Int32__Array **v241; // r9
		  Type *v242; // rdx
		  __int64 v243; // rax
		  PropertyInfo_1 *v244; // r8
		  Int32__Array **v245; // r9
		  Type *v246; // rdx
		  __int64 v247; // rax
		  PropertyInfo_1 *v248; // r8
		  Int32__Array **v249; // r9
		  Type *v250; // rdx
		  __int64 v251; // rax
		  PropertyInfo_1 *v252; // r8
		  Int32__Array **v253; // r9
		  Type *v254; // rdx
		  __int64 v255; // rax
		  PropertyInfo_1 *v256; // r8
		  Int32__Array **v257; // r9
		  Type *v258; // rdx
		  __int64 v259; // rax
		  PropertyInfo_1 *v260; // r8
		  Int32__Array **v261; // r9
		  Type *v262; // rdx
		  MethodInfo *v263; // [rsp+20h] [rbp-8h]
		  MethodInfo *v264; // [rsp+20h] [rbp-8h]
		  MethodInfo *v265; // [rsp+20h] [rbp-8h]
		  MethodInfo *v266; // [rsp+20h] [rbp-8h]
		  MethodInfo *v267; // [rsp+20h] [rbp-8h]
		  MethodInfo *v268; // [rsp+20h] [rbp-8h]
		  MethodInfo *v269; // [rsp+20h] [rbp-8h]
		  MethodInfo *v270; // [rsp+20h] [rbp-8h]
		  MethodInfo *v271; // [rsp+20h] [rbp-8h]
		  MethodInfo *v272; // [rsp+20h] [rbp-8h]
		  MethodInfo *v273; // [rsp+20h] [rbp-8h]
		  MethodInfo *v274; // [rsp+20h] [rbp-8h]
		  MethodInfo *v275; // [rsp+20h] [rbp-8h]
		  MethodInfo *v276; // [rsp+20h] [rbp-8h]
		  MethodInfo *v277; // [rsp+20h] [rbp-8h]
		  MethodInfo *v278; // [rsp+20h] [rbp-8h]
		  MethodInfo *v279; // [rsp+20h] [rbp-8h]
		  MethodInfo *v280; // [rsp+20h] [rbp-8h]
		  MethodInfo *v281; // [rsp+20h] [rbp-8h]
		  MethodInfo *v282; // [rsp+20h] [rbp-8h]
		  MethodInfo *v283; // [rsp+20h] [rbp-8h]
		  MethodInfo *v284; // [rsp+20h] [rbp-8h]
		  MethodInfo *v285; // [rsp+20h] [rbp-8h]
		  MethodInfo *v286; // [rsp+20h] [rbp-8h]
		  MethodInfo *v287; // [rsp+20h] [rbp-8h]
		  MethodInfo *v288; // [rsp+20h] [rbp-8h]
		  MethodInfo *v289; // [rsp+20h] [rbp-8h]
		  MethodInfo *v290; // [rsp+20h] [rbp-8h]
		  MethodInfo *v291; // [rsp+20h] [rbp-8h]
		  MethodInfo *v292; // [rsp+20h] [rbp-8h]
		  MethodInfo *v293; // [rsp+20h] [rbp-8h]
		  MethodInfo *v294; // [rsp+20h] [rbp-8h]
		  MethodInfo *v295; // [rsp+20h] [rbp-8h]
		  MethodInfo *v296; // [rsp+20h] [rbp-8h]
		  MethodInfo *v297; // [rsp+20h] [rbp-8h]
		  MethodInfo *v298; // [rsp+20h] [rbp-8h]
		  MethodInfo *v299; // [rsp+20h] [rbp-8h]
		  MethodInfo *v300; // [rsp+20h] [rbp-8h]
		  MethodInfo *v301; // [rsp+20h] [rbp-8h]
		  MethodInfo *v302; // [rsp+20h] [rbp-8h]
		  MethodInfo *v303; // [rsp+20h] [rbp-8h]
		  MethodInfo *v304; // [rsp+20h] [rbp-8h]
		  MethodInfo *v305; // [rsp+20h] [rbp-8h]
		  MethodInfo *v306; // [rsp+20h] [rbp-8h]
		  MethodInfo *v307; // [rsp+20h] [rbp-8h]
		  MethodInfo *v308; // [rsp+20h] [rbp-8h]
		  MethodInfo *v309; // [rsp+20h] [rbp-8h]
		  MethodInfo *v310; // [rsp+20h] [rbp-8h]
		  MethodInfo *v311; // [rsp+20h] [rbp-8h]
		  MethodInfo *v312; // [rsp+20h] [rbp-8h]
		  MethodInfo *v313; // [rsp+20h] [rbp-8h]
		  MethodInfo *v314; // [rsp+20h] [rbp-8h]
		  MethodInfo *v315; // [rsp+20h] [rbp-8h]
		  MethodInfo *v316; // [rsp+20h] [rbp-8h]
		  MethodInfo *v317; // [rsp+20h] [rbp-8h]
		  MethodInfo *v318; // [rsp+20h] [rbp-8h]
		  MethodInfo *v319; // [rsp+20h] [rbp-8h]
		  MethodInfo *v320; // [rsp+20h] [rbp-8h]
		  MethodInfo *v321; // [rsp+20h] [rbp-8h]
		  MethodInfo *v322; // [rsp+20h] [rbp-8h]
		  MethodInfo *v323; // [rsp+20h] [rbp-8h]
		  MethodInfo *v324; // [rsp+20h] [rbp-8h]
		  MethodInfo *v325; // [rsp+20h] [rbp-8h]
		  MethodInfo *v326; // [rsp+20h] [rbp-8h]
		  MethodInfo *v327; // [rsp+50h] [rbp+28h]
		
		  v1 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v1 )
		    goto LABEL_2;
		  *(_BYTE *)(v1 + 16) = 1;
		  static_fields = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  static_fields->klass = (Type__Class *)v1;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields,
		    static_fields,
		    v4,
		    v5,
		    v263);
		  v7 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v7 )
		    goto LABEL_2;
		  *(_BYTE *)(v7 + 16) = 1;
		  v10 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v10->monitor = (MonitorData *)v7;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->asm_1,
		    v10,
		    v8,
		    v9,
		    v264);
		  v11 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v11 )
		    goto LABEL_2;
		  *(_BYTE *)(v11 + 16) = 1;
		  v14 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v14->fields._impl.value = (void *)v11;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->cloudShadow,
		    v14,
		    v12,
		    v13,
		    v265);
		  v15 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v15 )
		    goto LABEL_2;
		  *(_BYTE *)(v15 + 16) = 1;
		  v18 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v18[1].klass = (Type__Class *)v15;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->characterShadow,
		    v18,
		    v16,
		    v17,
		    v266);
		  v19 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v19 )
		    goto LABEL_2;
		  *(_BYTE *)(v19 + 16) = 1;
		  v22 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v22[1].monitor = (MonitorData *)v19;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->punctualLightShadow,
		    v22,
		    v20,
		    v21,
		    v267);
		  v23 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v23 )
		    goto LABEL_2;
		  *(_BYTE *)(v23 + 16) = 1;
		  v26 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v26[1].fields._impl.value = (void *)v23;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->hdplsCharacterShadow,
		    v26,
		    v24,
		    v25,
		    v268);
		  v27 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v27 )
		    goto LABEL_2;
		  *(_BYTE *)(v27 + 16) = 1;
		  v30 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v30[2].klass = (Type__Class *)v27;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->contactShadow,
		    v30,
		    v28,
		    v29,
		    v269);
		  v31 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v31 )
		    goto LABEL_2;
		  *(_BYTE *)(v31 + 16) = 1;
		  v34 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v34[2].monitor = (MonitorData *)v31;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->preZ,
		    v34,
		    v32,
		    v33,
		    v270);
		  v35 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v35 )
		    goto LABEL_2;
		  *(_BYTE *)(v35 + 16) = 1;
		  v38 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v38[2].fields._impl.value = (void *)v35;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->deferred,
		    v38,
		    v36,
		    v37,
		    v271);
		  v39 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v39 )
		    goto LABEL_2;
		  *(_BYTE *)(v39 + 16) = 1;
		  v42 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v42[3].klass = (Type__Class *)v39;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->characterPrePass,
		    v42,
		    v40,
		    v41,
		    v272);
		  v43 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v43 )
		    goto LABEL_2;
		  *(_BYTE *)(v43 + 16) = 1;
		  v46 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v46[3].monitor = (MonitorData *)v43;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->customDepthPass,
		    v46,
		    v44,
		    v45,
		    v273);
		  v47 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v47 )
		    goto LABEL_2;
		  *(_BYTE *)(v47 + 16) = 1;
		  v50 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v50[3].fields._impl.value = (void *)v47;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->deferredOpaque,
		    v50,
		    v48,
		    v49,
		    v274);
		  v51 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v51 )
		    goto LABEL_2;
		  *(_BYTE *)(v51 + 16) = 1;
		  v54 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v54[4].klass = (Type__Class *)v51;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->deferredOpaquePreZ,
		    v54,
		    v52,
		    v53,
		    v275);
		  v55 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v55 )
		    goto LABEL_2;
		  *(_BYTE *)(v55 + 16) = 1;
		  v58 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v58[4].monitor = (MonitorData *)v55;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->deferredOpaqueEqual,
		    v58,
		    v56,
		    v57,
		    v276);
		  v59 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v59 )
		    goto LABEL_2;
		  *(_BYTE *)(v59 + 16) = 1;
		  v62 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v62[4].fields._impl.value = (void *)v59;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->deferredGrassPreZ,
		    v62,
		    v60,
		    v61,
		    v277);
		  v63 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v63 )
		    goto LABEL_2;
		  *(_BYTE *)(v63 + 16) = 1;
		  v66 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v66[5].klass = (Type__Class *)v63;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->deferredGrass,
		    v66,
		    v64,
		    v65,
		    v278);
		  v67 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v67 )
		    goto LABEL_2;
		  *(_BYTE *)(v67 + 16) = 1;
		  v70 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v70[5].monitor = (MonitorData *)v67;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->deferredTreePreZ,
		    v70,
		    v68,
		    v69,
		    v279);
		  v71 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v71 )
		    goto LABEL_2;
		  *(_BYTE *)(v71 + 16) = 1;
		  v74 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v74[5].fields._impl.value = (void *)v71;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->deferredTree,
		    v74,
		    v72,
		    v73,
		    v280);
		  v75 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v75 )
		    goto LABEL_2;
		  *(_BYTE *)(v75 + 16) = 1;
		  v78 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v78[6].klass = (Type__Class *)v75;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->deferredDecal,
		    v78,
		    v76,
		    v77,
		    v281);
		  v79 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v79 )
		    goto LABEL_2;
		  *(_BYTE *)(v79 + 16) = 1;
		  v82 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v82[6].monitor = (MonitorData *)v79;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->deferredErosion,
		    v82,
		    v80,
		    v81,
		    v282);
		  v83 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v83 )
		    goto LABEL_2;
		  *(_BYTE *)(v83 + 16) = 1;
		  v86 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v86[6].fields._impl.value = (void *)v83;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->deferredSludge,
		    v86,
		    v84,
		    v85,
		    v283);
		  v87 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v87 )
		    goto LABEL_2;
		  *(_BYTE *)(v87 + 16) = 1;
		  v90 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v90[7].klass = (Type__Class *)v87;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->forward,
		    v90,
		    v88,
		    v89,
		    v284);
		  v91 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v91 )
		    goto LABEL_2;
		  *(_BYTE *)(v91 + 16) = 1;
		  v94 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v94[7].monitor = (MonitorData *)v91;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->forwardTransparent,
		    v94,
		    v92,
		    v93,
		    v285);
		  v95 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v95 )
		    goto LABEL_2;
		  *(_BYTE *)(v95 + 16) = 1;
		  v98 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v98[7].fields._impl.value = (void *)v95;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->forwardOpaque,
		    v98,
		    v96,
		    v97,
		    v286);
		  v99 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v99 )
		    goto LABEL_2;
		  *(_BYTE *)(v99 + 16) = 1;
		  v102 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v102[8].klass = (Type__Class *)v99;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->forwardOpaquePreZ,
		    v102,
		    v100,
		    v101,
		    v287);
		  v103 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v103 )
		    goto LABEL_2;
		  *(_BYTE *)(v103 + 16) = 1;
		  v106 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v106[8].monitor = (MonitorData *)v103;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->forwardOpaqueEqual,
		    v106,
		    v104,
		    v105,
		    v288);
		  v107 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v107 )
		    goto LABEL_2;
		  *(_BYTE *)(v107 + 16) = 1;
		  v110 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v110[8].fields._impl.value = (void *)v107;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->forwardDecal,
		    v110,
		    v108,
		    v109,
		    v289);
		  v111 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v111 )
		    goto LABEL_2;
		  *(_BYTE *)(v111 + 16) = 1;
		  v114 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v114[9].klass = (Type__Class *)v111;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->forwardCharacter,
		    v114,
		    v112,
		    v113,
		    v290);
		  v115 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v115 )
		    goto LABEL_2;
		  *(_BYTE *)(v115 + 16) = 1;
		  v118 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v118[9].monitor = (MonitorData *)v115;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->characterOutlineOpaque,
		    v118,
		    v116,
		    v117,
		    v291);
		  v119 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v119 )
		    goto LABEL_2;
		  *(_BYTE *)(v119 + 16) = 1;
		  v122 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v122[9].fields._impl.value = (void *)v119;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->characterOutlineOpaquePreZ,
		    v122,
		    v120,
		    v121,
		    v292);
		  v123 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v123 )
		    goto LABEL_2;
		  *(_BYTE *)(v123 + 16) = 1;
		  v126 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v126[10].klass = (Type__Class *)v123;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->characterOutlineOpaqueEqual,
		    v126,
		    v124,
		    v125,
		    v293);
		  v127 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v127 )
		    goto LABEL_2;
		  *(_BYTE *)(v127 + 16) = 1;
		  v130 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v130[10].monitor = (MonitorData *)v127;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->vfxDecal,
		    v130,
		    v128,
		    v129,
		    v294);
		  v131 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v131 )
		    goto LABEL_2;
		  *(_BYTE *)(v131 + 16) = 1;
		  v134 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v134[10].fields._impl.value = (void *)v131;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->distortionOpaque,
		    v134,
		    v132,
		    v133,
		    v295);
		  v135 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v135 )
		    goto LABEL_2;
		  *(_BYTE *)(v135 + 16) = 1;
		  v138 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v138[11].klass = (Type__Class *)v135;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->distortionTransparent,
		    v138,
		    v136,
		    v137,
		    v296);
		  v139 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v139 )
		    goto LABEL_2;
		  *(_BYTE *)(v139 + 16) = 1;
		  v142 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v142[11].monitor = (MonitorData *)v139;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->UI,
		    v142,
		    v140,
		    v141,
		    v297);
		  v143 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v143 )
		    goto LABEL_2;
		  *(_BYTE *)(v143 + 16) = 1;
		  v146 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v146[11].fields._impl.value = (void *)v143;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->UISprite,
		    v146,
		    v144,
		    v145,
		    v298);
		  v147 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v147 )
		    goto LABEL_2;
		  *(_BYTE *)(v147 + 16) = 1;
		  v150 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v150[12].klass = (Type__Class *)v147;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->UIWorld,
		    v150,
		    v148,
		    v149,
		    v299);
		  v151 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v151 )
		    goto LABEL_2;
		  *(_BYTE *)(v151 + 16) = 1;
		  v154 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v154[12].monitor = (MonitorData *)v151;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->UIDistortion,
		    v154,
		    v152,
		    v153,
		    v300);
		  v155 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v155 )
		    goto LABEL_2;
		  *(_BYTE *)(v155 + 16) = 1;
		  v158 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v158[12].fields._impl.value = (void *)v155;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->UIFrostedGlass,
		    v158,
		    v156,
		    v157,
		    v301);
		  v159 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v159 )
		    goto LABEL_2;
		  *(_BYTE *)(v159 + 16) = 1;
		  v162 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v162[13].klass = (Type__Class *)v159;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->deferredShading,
		    v162,
		    v160,
		    v161,
		    v302);
		  v163 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v163 )
		    goto LABEL_2;
		  *(_BYTE *)(v163 + 16) = 1;
		  v166 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v166[13].monitor = (MonitorData *)v163;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->deferredShadingDefaultLit,
		    v166,
		    v164,
		    v165,
		    v303);
		  v167 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v167 )
		    goto LABEL_2;
		  *(_BYTE *)(v167 + 16) = 1;
		  v170 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v170[13].fields._impl.value = (void *)v167;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->deferredShadingTwoSidedFoliage,
		    v170,
		    v168,
		    v169,
		    v304);
		  v171 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v171 )
		    goto LABEL_2;
		  *(_BYTE *)(v171 + 16) = 1;
		  v174 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v174[14].klass = (Type__Class *)v171;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->deferredShadingSubsurface,
		    v174,
		    v172,
		    v173,
		    v305);
		  v175 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v175 )
		    goto LABEL_2;
		  *(_BYTE *)(v175 + 16) = 0;
		  v178 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v178[14].monitor = (MonitorData *)v175;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->splitDeferredShadingStage,
		    v178,
		    v176,
		    v177,
		    v306);
		  v179 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v179 )
		    goto LABEL_2;
		  *(_BYTE *)(v179 + 16) = 0;
		  v182 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v182[14].fields._impl.value = (void *)v179;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->usePerLightDynamicLighting,
		    v182,
		    v180,
		    v181,
		    v307);
		  v183 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v183 )
		    goto LABEL_2;
		  *(_BYTE *)(v183 + 16) = 1;
		  v186 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v186[15].klass = (Type__Class *)v183;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->deferredShadingDirectionalLightStage,
		    v186,
		    v184,
		    v185,
		    v308);
		  v187 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v187 )
		    goto LABEL_2;
		  *(_BYTE *)(v187 + 16) = 1;
		  v190 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v190[15].monitor = (MonitorData *)v187;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->deferredShadingDynamicLightStage,
		    v190,
		    v188,
		    v189,
		    v309);
		  v191 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v191 )
		    goto LABEL_2;
		  *(_BYTE *)(v191 + 16) = 1;
		  v194 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v194[15].fields._impl.value = (void *)v191;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->deferredShadingIndirectStage,
		    v194,
		    v192,
		    v193,
		    v310);
		  v195 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v195 )
		    goto LABEL_2;
		  *(_BYTE *)(v195 + 16) = 1;
		  v198 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v198[16].klass = (Type__Class *)v195;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->usePerTileDeferredLighting,
		    v198,
		    v196,
		    v197,
		    v311);
		  v199 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v199 )
		    goto LABEL_2;
		  *(_BYTE *)(v199 + 16) = 1;
		  v202 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v202[16].monitor = (MonitorData *)v199;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->terrain,
		    v202,
		    v200,
		    v201,
		    v312);
		  v203 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v203 )
		    goto LABEL_2;
		  *(_BYTE *)(v203 + 16) = 1;
		  v206 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v206[16].fields._impl.value = (void *)v203;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->terrainDeform,
		    v206,
		    v204,
		    v205,
		    v313);
		  v207 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v207 )
		    goto LABEL_2;
		  *(_BYTE *)(v207 + 16) = 1;
		  v210 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v210[17].klass = (Type__Class *)v207;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->terrainPreDepth,
		    v210,
		    v208,
		    v209,
		    v314);
		  v211 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v211 )
		    goto LABEL_2;
		  *(_BYTE *)(v211 + 16) = 1;
		  v214 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v214[17].monitor = (MonitorData *)v211;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->terrainScreenSpace,
		    v214,
		    v212,
		    v213,
		    v315);
		  v215 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v215 )
		    goto LABEL_2;
		  *(_BYTE *)(v215 + 16) = 1;
		  v218 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v218[17].fields._impl.value = (void *)v215;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->terrainPostGBuffer,
		    v218,
		    v216,
		    v217,
		    v316);
		  v219 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v219 )
		    goto LABEL_2;
		  *(_BYTE *)(v219 + 16) = 1;
		  v222 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v222[18].klass = (Type__Class *)v219;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->terrainVTBake,
		    v222,
		    v220,
		    v221,
		    v317);
		  v223 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v223 )
		    goto LABEL_2;
		  *(_BYTE *)(v223 + 16) = 1;
		  v226 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v226[18].monitor = (MonitorData *)v223;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->terrainIndirectionUpdate,
		    v226,
		    v224,
		    v225,
		    v318);
		  v227 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v227 )
		    goto LABEL_2;
		  *(_BYTE *)(v227 + 16) = 0;
		  v230 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v230[18].fields._impl.value = (void *)v227;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->terrainDepthPrepass,
		    v230,
		    v228,
		    v229,
		    v319);
		  v231 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v231 )
		    goto LABEL_2;
		  *(_BYTE *)(v231 + 16) = 1;
		  v234 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v234[19].klass = (Type__Class *)v231;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->terrainSimpleSubsurface,
		    v234,
		    v232,
		    v233,
		    v320);
		  v235 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v235 )
		    goto LABEL_2;
		  *(_BYTE *)(v235 + 16) = 1;
		  v238 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v238[19].monitor = (MonitorData *)v235;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->terrainSubdivision,
		    v238,
		    v236,
		    v237,
		    v321);
		  v239 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v239 )
		    goto LABEL_2;
		  *(_BYTE *)(v239 + 16) = 1;
		  v242 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v242[19].fields._impl.value = (void *)v239;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->terrainSubdivisionV2,
		    v242,
		    v240,
		    v241,
		    v322);
		  v243 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v243 )
		    goto LABEL_2;
		  *(_BYTE *)(v243 + 16) = 0;
		  v246 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v246[20].klass = (Type__Class *)v243;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->terrainSubdivisionHZBCulling,
		    v246,
		    v244,
		    v245,
		    v323);
		  v247 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v247 )
		    goto LABEL_2;
		  *(_BYTE *)(v247 + 16) = 0;
		  v250 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v250[20].monitor = (MonitorData *)v247;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->terrainNewEditorRendering,
		    v250,
		    v248,
		    v249,
		    v324);
		  v251 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v251 )
		    goto LABEL_2;
		  *(_BYTE *)(v251 + 16) = 1;
		  v254 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v254[20].fields._impl.value = (void *)v251;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->terrainDecalInteraction,
		    v254,
		    v252,
		    v253,
		    v325);
		  v255 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch);
		  if ( !v255
		    || (*(_BYTE *)(v255 + 16) = 0,
		        v258 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields,
		        v258[21].klass = (Type__Class *)v255,
		        sub_18002D1B0(
		          (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->irradianceVolumeV2,
		          v258,
		          v256,
		          v257,
		          v326),
		        (v259 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureSwitch)) == 0) )
		  {
		LABEL_2:
		    sub_1800D8260(v3, v2);
		  }
		  *(_BYTE *)(v259 + 16) = 1;
		  v262 = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  v262[21].monitor = (MonitorData *)v259;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->irradianceVolumeV3,
		    v262,
		    v260,
		    v261,
		    v327);
		}
		
	}
}
