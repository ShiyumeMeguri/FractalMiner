using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class HGRenderPathDefaultDeferred : HGRenderPathDeferred // TypeDefIndex: 38521
	{
		// Fields
		private BinningPass m_binningPassConstructor; // 0x1420
		private ReflectionProbeBinningPassConstructor m_reflectionProbeBinningPassConstructor; // 0x1428
		private FoliageOccluderPassConstructor m_foliageOccluderPassConstructor; // 0x1430
		private FoliageInteractivePassConstructor m_foliageInteractivePassConstructor; // 0x1438
		private SludgePassConstructor m_sludgePassConstructor; // 0x1440
		private GpuClothSimulationPassConstructor m_gpuClothSimulationPassConstructor; // 0x1448
		private ParticleLightingPassConstructor m_particleLightingPassConstructor; // 0x1450
		private LightClusteringPassConstructor m_lightClusteringPassConstructor; // 0x1458
		private GPUDrivenCullingPassConstructor m_cullingPassConstructor; // 0x1460
		private DepthOnlyPassConstructor m_depthOnlyPassConstructor; // 0x1468
		private ShadowMapPassConstructor m_shadowMapPassConstructor; // 0x1470
		private SkyAtmospherePassConstructor m_skyAtmospherePassConstructor; // 0x1478
		private VolumetricFogPassConstructor m_volumetricFogPassConstructor; // 0x1480
		private BakeFogLutPassConstructor m_bakeFogLutPassConstructor; // 0x1488
		private TerrainDeformPassConstructor m_terrainDeformPassConstructor; // 0x1490
		private TerrainVTBakePassConstructor m_terrainVTBakePassConstructor; // 0x1498
		private InkSimulationPassConstructor m_InkSimulationPassConstructor; // 0x14A0
		private TerrainDepthPrepassConstructor m_terrainDepthPrepassConstructor; // 0x14A8
		private DepthPrepassConstructor m_depthPrepassConstructor; // 0x14B0
		private GBufferPassConstructor m_gBufferPassConstructor; // 0x14B8
		private GPUParticleSimulationPassConstructor m_gpuParticleSimulationPassConstructor; // 0x14C0
		private DecalPassConstructor m_decalPassConstructor; // 0x14C8
		private WaterSectorRenderingPass m_waterSectorRenderingPassConstructor; // 0x14D0
		private WaterInteractionRenderingPass m_waterInteractionRenderingPassConstructor; // 0x14D8
		private WaterDefaultDeferredRenderingPass m_waterDefaultDeferredRenderingPassConstructor; // 0x14E0
		private BuildHZBPass m_buildHZBPassConstructor; // 0x14E8
		private DepthPyramidRenderingPass m_depthPyramidRenderingPassConstructor; // 0x14F0
		private GTAOPassConstructor m_GTAOPassConstructor; // 0x14F8
		private FakePlanarReflectionPass m_fakePlanarReflectionPassConstructor; // 0x1500
		private HyperScreenSpaceReflectionRenderingPass m_hyperScreenSpaceReflectionRenderingPassConstructor; // 0x1508
		private ContactShadowPassConstructor m_contactShadowPassConstructor; // 0x1510
		private CapsuleShadowPassConstructor m_capsuleShadowPassConstructor; // 0x1518
		private ScreenSpaceShadowMaskPassConstructor m_screenSpaceShadowMaskPassConstructor; // 0x1520
		private DeferredLightingPassConstructor m_deferredLightingPassConstructor; // 0x1528
		private ForwardOpaquePassConstructor m_forwardOpaquePassConstructor; // 0x1530
		private TransparentPassConstructor m_transparentPassConstructor; // 0x1538
		private VolumetricCloudPassConstructor m_volumetricCloudPassConstructor; // 0x1540
		private LightShaftPassConstructor m_lightShaftPassConstructor; // 0x1548
		private DistortionPassConstructor m_distortionPassConstructor; // 0x1550
	
		// Properties
		protected TextureHandle sceneNormalCopied { get; private set; } // 0x0000000184DA17F0-0x0000000184DA1800 0x0000000184DA1800-0x0000000184DA1810
		// TextureHandle get_sceneNormalCopied()
		TextureHandle *HG::Rendering::Runtime::HGRenderPathDefaultDeferred::get_sceneNormalCopied(
		        TextureHandle *__return_ptr retstr,
		        HGRenderPathDefaultDeferred *this,
		        MethodInfo *method)
		{
		  TextureHandle *result; // rax
		
		  result = retstr;
		  *retstr = *(TextureHandle *)&this[1].fields._._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m01;
		  return result;
		}
		

		// Void set_sceneNormalCopied(TextureHandle)
		void HG::Rendering::Runtime::HGRenderPathDefaultDeferred::set_sceneNormalCopied(
		        HGRenderPathDefaultDeferred *this,
		        TextureHandle *value,
		        MethodInfo *method)
		{
		  *(TextureHandle *)&this[1].fields._._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m01 = *value;
		}
		
	
		// Constructors
		public HGRenderPathDefaultDeferred() {} // Dummy constructor
		internal HGRenderPathDefaultDeferred(HGRenderPathResources resources, HGCamera camera, HGRenderPathInternal renderPath) {} // 0x0000000182ED9920-0x0000000182EDA3E0
		// HGRenderPathDefaultDeferred(HGRenderPathBase+HGRenderPathResources, HGCamera, HGRenderPathInternal)
		void HG::Rendering::Runtime::HGRenderPathDefaultDeferred::HGRenderPathDefaultDeferred(
		        HGRenderPathDefaultDeferred *this,
		        HGRenderPathBase_HGRenderPathResources *resources,
		        HGCamera *camera,
		        HGRenderPathInternal__Enum renderPath,
		        MethodInfo *method)
		{
		  PassConstructorID__Enum__Array *v9; // rax
		  IPassConstructor *PassConstructor; // rbx
		  HGRenderPathBase_HGRenderPathResources *v11; // rdx
		  HGCamera *v12; // r8
		  Int32__Array **v13; // r9
		  IPassConstructor *v14; // rbx
		  HGRenderPathBase_HGRenderPathResources *v15; // rdx
		  HGCamera *v16; // r8
		  Int32__Array **v17; // r9
		  IPassConstructor *v18; // rbx
		  HGRenderPathBase_HGRenderPathResources *v19; // rdx
		  HGCamera *v20; // r8
		  Int32__Array **v21; // r9
		  IPassConstructor *v22; // rbx
		  HGRenderPathBase_HGRenderPathResources *v23; // rdx
		  HGCamera *v24; // r8
		  Int32__Array **v25; // r9
		  IPassConstructor *v26; // rbx
		  HGRenderPathBase_HGRenderPathResources *v27; // rdx
		  HGCamera *v28; // r8
		  Int32__Array **v29; // r9
		  IPassConstructor *v30; // rbx
		  HGRenderPathBase_HGRenderPathResources *v31; // rdx
		  HGCamera *v32; // r8
		  Int32__Array **v33; // r9
		  IPassConstructor *v34; // rbx
		  HGRenderPathBase_HGRenderPathResources *v35; // rdx
		  HGCamera *v36; // r8
		  Int32__Array **v37; // r9
		  IPassConstructor *v38; // rbx
		  HGRenderPathBase_HGRenderPathResources *v39; // rdx
		  HGCamera *v40; // r8
		  Int32__Array **v41; // r9
		  IPassConstructor *v42; // rbx
		  HGRenderPathBase_HGRenderPathResources *v43; // rdx
		  HGCamera *v44; // r8
		  Int32__Array **v45; // r9
		  IPassConstructor *v46; // rbx
		  HGRenderPathBase_HGRenderPathResources *v47; // rdx
		  HGCamera *v48; // r8
		  Int32__Array **v49; // r9
		  IPassConstructor *v50; // rbx
		  HGRenderPathBase_HGRenderPathResources *v51; // rdx
		  HGCamera *v52; // r8
		  Int32__Array **v53; // r9
		  IPassConstructor *v54; // rbx
		  HGRenderPathBase_HGRenderPathResources *v55; // rdx
		  HGCamera *v56; // r8
		  Int32__Array **v57; // r9
		  IPassConstructor *v58; // rbx
		  HGRenderPathBase_HGRenderPathResources *v59; // rdx
		  HGCamera *v60; // r8
		  Int32__Array **v61; // r9
		  IPassConstructor *v62; // rbx
		  HGRenderPathBase_HGRenderPathResources *v63; // rdx
		  HGCamera *v64; // r8
		  Int32__Array **v65; // r9
		  IPassConstructor *v66; // rbx
		  HGRenderPathBase_HGRenderPathResources *v67; // rdx
		  HGCamera *v68; // r8
		  Int32__Array **v69; // r9
		  IPassConstructor *v70; // rbx
		  HGRenderPathBase_HGRenderPathResources *v71; // rdx
		  HGCamera *v72; // r8
		  Int32__Array **v73; // r9
		  IPassConstructor *v74; // rbx
		  HGRenderPathBase_HGRenderPathResources *v75; // rdx
		  HGCamera *v76; // r8
		  Int32__Array **v77; // r9
		  IPassConstructor *v78; // rbx
		  HGRenderPathBase_HGRenderPathResources *v79; // rdx
		  HGCamera *v80; // r8
		  Int32__Array **v81; // r9
		  IPassConstructor *v82; // rbx
		  HGRenderPathBase_HGRenderPathResources *v83; // rdx
		  HGCamera *v84; // r8
		  Int32__Array **v85; // r9
		  IPassConstructor *v86; // rbx
		  HGRenderPathBase_HGRenderPathResources *v87; // rdx
		  HGCamera *v88; // r8
		  Int32__Array **v89; // r9
		  IPassConstructor *v90; // rbx
		  HGRenderPathBase_HGRenderPathResources *v91; // rdx
		  HGCamera *v92; // r8
		  Int32__Array **v93; // r9
		  IPassConstructor *v94; // rbx
		  HGRenderPathBase_HGRenderPathResources *v95; // rdx
		  HGCamera *v96; // r8
		  Int32__Array **v97; // r9
		  IPassConstructor *v98; // rbx
		  HGRenderPathBase_HGRenderPathResources *v99; // rdx
		  HGCamera *v100; // r8
		  Int32__Array **v101; // r9
		  IPassConstructor *v102; // rbx
		  HGRenderPathBase_HGRenderPathResources *v103; // rdx
		  HGCamera *v104; // r8
		  Int32__Array **v105; // r9
		  IPassConstructor *v106; // rbx
		  HGRenderPathBase_HGRenderPathResources *v107; // rdx
		  HGCamera *v108; // r8
		  Int32__Array **v109; // r9
		  IPassConstructor *v110; // rbx
		  HGRenderPathBase_HGRenderPathResources *v111; // rdx
		  HGCamera *v112; // r8
		  Int32__Array **v113; // r9
		  IPassConstructor *v114; // rbx
		  HGRenderPathBase_HGRenderPathResources *v115; // rdx
		  HGCamera *v116; // r8
		  Int32__Array **v117; // r9
		  IPassConstructor *v118; // rbx
		  HGRenderPathBase_HGRenderPathResources *v119; // rdx
		  HGCamera *v120; // r8
		  Int32__Array **v121; // r9
		  IPassConstructor *v122; // rbx
		  HGRenderPathBase_HGRenderPathResources *v123; // rdx
		  HGCamera *v124; // r8
		  Int32__Array **v125; // r9
		  IPassConstructor *v126; // rbx
		  HGRenderPathBase_HGRenderPathResources *v127; // rdx
		  HGCamera *v128; // r8
		  Int32__Array **v129; // r9
		  IPassConstructor *v130; // rbx
		  HGRenderPathBase_HGRenderPathResources *v131; // rdx
		  HGCamera *v132; // r8
		  Int32__Array **v133; // r9
		  IPassConstructor *v134; // rbx
		  HGRenderPathBase_HGRenderPathResources *v135; // rdx
		  HGCamera *v136; // r8
		  Int32__Array **v137; // r9
		  IPassConstructor *v138; // rbx
		  HGRenderPathBase_HGRenderPathResources *v139; // rdx
		  HGCamera *v140; // r8
		  Int32__Array **v141; // r9
		  IPassConstructor *v142; // rbx
		  HGRenderPathBase_HGRenderPathResources *v143; // rdx
		  HGCamera *v144; // r8
		  Int32__Array **v145; // r9
		  IPassConstructor *v146; // rbx
		  HGRenderPathBase_HGRenderPathResources *v147; // rdx
		  HGCamera *v148; // r8
		  Int32__Array **v149; // r9
		  IPassConstructor *v150; // rbx
		  HGRenderPathBase_HGRenderPathResources *v151; // rdx
		  HGCamera *v152; // r8
		  Int32__Array **v153; // r9
		  IPassConstructor *v154; // rbx
		  HGRenderPathBase_HGRenderPathResources *v155; // rdx
		  HGCamera *v156; // r8
		  Int32__Array **v157; // r9
		  IPassConstructor *v158; // rbx
		  HGRenderPathBase_HGRenderPathResources *v159; // rdx
		  HGCamera *v160; // r8
		  Int32__Array **v161; // r9
		  IPassConstructor *v162; // rbx
		  HGRenderPathBase_HGRenderPathResources *v163; // rdx
		  HGCamera *v164; // r8
		  Int32__Array **v165; // r9
		  MethodInfo *v166; // [rsp+20h] [rbp-28h]
		  MethodInfo *v167; // [rsp+20h] [rbp-28h]
		  MethodInfo *v168; // [rsp+20h] [rbp-28h]
		  MethodInfo *v169; // [rsp+20h] [rbp-28h]
		  MethodInfo *v170; // [rsp+20h] [rbp-28h]
		  MethodInfo *v171; // [rsp+20h] [rbp-28h]
		  MethodInfo *v172; // [rsp+20h] [rbp-28h]
		  MethodInfo *v173; // [rsp+20h] [rbp-28h]
		  MethodInfo *v174; // [rsp+20h] [rbp-28h]
		  MethodInfo *v175; // [rsp+20h] [rbp-28h]
		  MethodInfo *v176; // [rsp+20h] [rbp-28h]
		  MethodInfo *v177; // [rsp+20h] [rbp-28h]
		  MethodInfo *v178; // [rsp+20h] [rbp-28h]
		  MethodInfo *v179; // [rsp+20h] [rbp-28h]
		  MethodInfo *v180; // [rsp+20h] [rbp-28h]
		  MethodInfo *v181; // [rsp+20h] [rbp-28h]
		  MethodInfo *v182; // [rsp+20h] [rbp-28h]
		  MethodInfo *v183; // [rsp+20h] [rbp-28h]
		  MethodInfo *v184; // [rsp+20h] [rbp-28h]
		  MethodInfo *v185; // [rsp+20h] [rbp-28h]
		  MethodInfo *v186; // [rsp+20h] [rbp-28h]
		  MethodInfo *v187; // [rsp+20h] [rbp-28h]
		  MethodInfo *v188; // [rsp+20h] [rbp-28h]
		  MethodInfo *v189; // [rsp+20h] [rbp-28h]
		  MethodInfo *v190; // [rsp+20h] [rbp-28h]
		  MethodInfo *v191; // [rsp+20h] [rbp-28h]
		  MethodInfo *v192; // [rsp+20h] [rbp-28h]
		  MethodInfo *v193; // [rsp+20h] [rbp-28h]
		  MethodInfo *v194; // [rsp+20h] [rbp-28h]
		  MethodInfo *v195; // [rsp+20h] [rbp-28h]
		  MethodInfo *v196; // [rsp+20h] [rbp-28h]
		  MethodInfo *v197; // [rsp+20h] [rbp-28h]
		  MethodInfo *v198; // [rsp+20h] [rbp-28h]
		  MethodInfo *v199; // [rsp+20h] [rbp-28h]
		  MethodInfo *v200; // [rsp+20h] [rbp-28h]
		  MethodInfo *v201; // [rsp+20h] [rbp-28h]
		  MethodInfo *v202; // [rsp+20h] [rbp-28h]
		  MethodInfo *v203; // [rsp+20h] [rbp-28h]
		  HGRenderPathBase_HGRenderPathResources v204; // [rsp+30h] [rbp-18h] BYREF
		
		  v9 = HG::Rendering::Runtime::HGRenderPathDefaultDeferred::PopulatePassConstructorIds(0LL);
		  v204 = *resources;
		  HG::Rendering::Runtime::HGRenderPathDeferred::HGRenderPathDeferred(
		    (HGRenderPathDeferred *)this,
		    &v204,
		    v9,
		    camera,
		    renderPath,
		    0LL);
		  PassConstructor = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		                      (HGRenderPathBase *)this,
		                      PassConstructorID__Enum_BinningPass,
		                      0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevViewProjMatrix.m21 = sub_180005050(
		                                                                                         PassConstructor,
		                                                                                         TypeInfo::HG::Rendering::Runtime::BinningPass);
		  sub_180005050(PassConstructor, TypeInfo::HG::Rendering::Runtime::BinningPass);
		  sub_18002D1B0((HGRenderPathDefaultDeferred *)((char *)this + 5152), v11, v12, v13, v166);
		  v14 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_ReflectionProbeBinning,
		          0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevViewProjMatrix.m02 = sub_180005050(
		                                                                                         v14,
		                                                                                         TypeInfo::HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor);
		  sub_180005050(v14, TypeInfo::HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor);
		  sub_18002D1B0((HGRenderPathDefaultDeferred *)((char *)this + 5160), v15, v16, v17, v167);
		  v18 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_FoliageOccluder,
		          0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevViewProjMatrix.m22 = sub_180005050(
		                                                                                         v18,
		                                                                                         TypeInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor);
		  sub_180005050(v18, TypeInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor);
		  sub_18002D1B0((HGRenderPathDefaultDeferred *)((char *)this + 5168), v19, v20, v21, v168);
		  v22 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_FoliageInteractive,
		          0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevViewProjMatrix.m03 = sub_180005050(
		                                                                                         v22,
		                                                                                         TypeInfo::HG::Rendering::Runtime::FoliageInteractivePassConstructor);
		  sub_180005050(v22, TypeInfo::HG::Rendering::Runtime::FoliageInteractivePassConstructor);
		  sub_18002D1B0((HGRenderPathDefaultDeferred *)((char *)this + 5176), v23, v24, v25, v169);
		  v26 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_Sludge,
		          0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevViewProjMatrix.m23 = sub_180005050(
		                                                                                         v26,
		                                                                                         TypeInfo::HG::Rendering::Runtime::SludgePassConstructor);
		  sub_180005050(v26, TypeInfo::HG::Rendering::Runtime::SludgePassConstructor);
		  sub_18002D1B0((HGRenderPathDefaultDeferred *)((char *)this + 5184), v27, v28, v29, v170);
		  v30 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_GpuClothSimulation,
		          0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m00 = sub_180005050(
		                                                                                                v30,
		                                                                                                TypeInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor);
		  sub_180005050(v30, TypeInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor);
		  sub_18002D1B0((HGRenderPathDefaultDeferred *)((char *)this + 5192), v31, v32, v33, v171);
		  v34 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_LightClustering,
		          0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m01 = sub_180005050(
		                                                                                                v34,
		                                                                                                TypeInfo::HG::Rendering::Runtime::LightClusteringPassConstructor);
		  sub_180005050(v34, TypeInfo::HG::Rendering::Runtime::LightClusteringPassConstructor);
		  sub_18002D1B0((HGRenderPathDefaultDeferred *)((char *)this + 5208), v35, v36, v37, v172);
		  v38 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_GPUDrivenCulling,
		          0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m21 = sub_180005050(
		                                                                                                v38,
		                                                                                                TypeInfo::HG::Rendering::Runtime::GPUDrivenCullingPassConstructor);
		  sub_180005050(v38, TypeInfo::HG::Rendering::Runtime::GPUDrivenCullingPassConstructor);
		  sub_18002D1B0((HGRenderPathDefaultDeferred *)((char *)this + 5216), v39, v40, v41, v173);
		  v42 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_ParticleLighting,
		          0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m20 = sub_180005050(
		                                                                                                v42,
		                                                                                                TypeInfo::HG::Rendering::Runtime::ParticleLightingPassConstructor);
		  sub_180005050(v42, TypeInfo::HG::Rendering::Runtime::ParticleLightingPassConstructor);
		  sub_18002D1B0((HGRenderPathDefaultDeferred *)((char *)this + 5200), v43, v44, v45, v174);
		  v46 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_CustomDepthOnly,
		          0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m02 = sub_180005050(
		                                                                                                v46,
		                                                                                                TypeInfo::HG::Rendering::Runtime::DepthOnlyPassConstructor);
		  sub_180005050(v46, TypeInfo::HG::Rendering::Runtime::DepthOnlyPassConstructor);
		  sub_18002D1B0((HGRenderPathDefaultDeferred *)((char *)this + 5224), v47, v48, v49, v175);
		  v50 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_ShadowMap,
		          0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m22 = sub_180005050(
		                                                                                                v50,
		                                                                                                TypeInfo::HG::Rendering::Runtime::ShadowMapPassConstructor);
		  sub_180005050(v50, TypeInfo::HG::Rendering::Runtime::ShadowMapPassConstructor);
		  sub_18002D1B0((HGRenderPathDefaultDeferred *)((char *)this + 5232), v51, v52, v53, v176);
		  v54 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_Atmosphere,
		          0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m03 = sub_180005050(
		                                                                                                v54,
		                                                                                                TypeInfo::HG::Rendering::Runtime::SkyAtmospherePassConstructor);
		  sub_180005050(v54, TypeInfo::HG::Rendering::Runtime::SkyAtmospherePassConstructor);
		  sub_18002D1B0((HGRenderPathDefaultDeferred *)((char *)this + 5240), v55, v56, v57, v177);
		  v58 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_VolumetricFog,
		          0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m23 = sub_180005050(
		                                                                                                v58,
		                                                                                                TypeInfo::HG::Rendering::Runtime::VolumetricFogPassConstructor);
		  sub_180005050(v58, TypeInfo::HG::Rendering::Runtime::VolumetricFogPassConstructor);
		  sub_18002D1B0((HGRenderPathDefaultDeferred *)((char *)this + 5248), v59, v60, v61, v178);
		  v62 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_BakeFogLut,
		          0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m00 = sub_180005050(
		                                                                                                    v62,
		                                                                                                    TypeInfo::HG::Rendering::Runtime::BakeFogLutPassConstructor);
		  sub_180005050(v62, TypeInfo::HG::Rendering::Runtime::BakeFogLutPassConstructor);
		  sub_18002D1B0((HGRenderPathDefaultDeferred *)((char *)this + 5256), v63, v64, v65, v179);
		  v66 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_TerrainDeform,
		          0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m20 = sub_180005050(
		                                                                                                    v66,
		                                                                                                    TypeInfo::HG::Rendering::Runtime::TerrainDeformPassConstructor);
		  sub_180005050(v66, TypeInfo::HG::Rendering::Runtime::TerrainDeformPassConstructor);
		  sub_18002D1B0((HGRenderPathDefaultDeferred *)((char *)this + 5264), v67, v68, v69, v180);
		  v70 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_TerrainVTBake,
		          0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m01 = sub_180005050(
		                                                                                                    v70,
		                                                                                                    TypeInfo::HG::Rendering::Runtime::TerrainVTBakePassConstructor);
		  sub_180005050(v70, TypeInfo::HG::Rendering::Runtime::TerrainVTBakePassConstructor);
		  sub_18002D1B0((HGRenderPathDefaultDeferred *)((char *)this + 5272), v71, v72, v73, v181);
		  v74 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_InkSimulation,
		          0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m21 = sub_180005050(
		                                                                                                    v74,
		                                                                                                    TypeInfo::HG::Rendering::Runtime::InkSimulationPassConstructor);
		  sub_180005050(v74, TypeInfo::HG::Rendering::Runtime::InkSimulationPassConstructor);
		  sub_18002D1B0((HGRenderPathDefaultDeferred *)((char *)this + 5280), v75, v76, v77, v182);
		  v78 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_TerrainDepthPrepass,
		          0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m02 = sub_180005050(
		                                                                                                    v78,
		                                                                                                    TypeInfo::HG::Rendering::Runtime::TerrainDepthPrepassConstructor);
		  sub_180005050(v78, TypeInfo::HG::Rendering::Runtime::TerrainDepthPrepassConstructor);
		  sub_18002D1B0((HGRenderPathDefaultDeferred *)((char *)this + 5288), v79, v80, v81, v183);
		  v82 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_DepthPrepass,
		          0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m22 = sub_180005050(
		                                                                                                    v82,
		                                                                                                    TypeInfo::HG::Rendering::Runtime::DepthPrepassConstructor);
		  sub_180005050(v82, TypeInfo::HG::Rendering::Runtime::DepthPrepassConstructor);
		  sub_18002D1B0((HGRenderPathDefaultDeferred *)((char *)this + 5296), v83, v84, v85, v184);
		  v86 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_GBuffer,
		          0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m03 = sub_180005050(
		                                                                                                    v86,
		                                                                                                    TypeInfo::HG::Rendering::Runtime::GBufferPassConstructor);
		  sub_180005050(v86, TypeInfo::HG::Rendering::Runtime::GBufferPassConstructor);
		  sub_18002D1B0((HGRenderPathDefaultDeferred *)((char *)this + 5304), v87, v88, v89, v185);
		  v90 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_GPUParticleSimulation,
		          0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m23 = sub_180005050(
		                                                                                                    v90,
		                                                                                                    TypeInfo::HG::Rendering::Runtime::GPUParticleSimulationPassConstructor);
		  sub_180005050(v90, TypeInfo::HG::Rendering::Runtime::GPUParticleSimulationPassConstructor);
		  sub_18002D1B0((HGRenderPathDefaultDeferred *)((char *)this + 5312), v91, v92, v93, v186);
		  v94 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_Decal,
		          0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m00 = sub_180005050(v94, TypeInfo::HG::Rendering::Runtime::DecalPassConstructor);
		  sub_180005050(v94, TypeInfo::HG::Rendering::Runtime::DecalPassConstructor);
		  sub_18002D1B0((HGRenderPathDefaultDeferred *)((char *)this + 5320), v95, v96, v97, v187);
		  v98 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_WaterSector,
		          0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m20 = sub_180005050(v98, TypeInfo::HG::Rendering::Runtime::WaterSectorRenderingPass);
		  sub_180005050(v98, TypeInfo::HG::Rendering::Runtime::WaterSectorRenderingPass);
		  sub_18002D1B0((HGRenderPathDefaultDeferred *)((char *)this + 5328), v99, v100, v101, v188);
		  v102 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		           (HGRenderPathBase *)this,
		           PassConstructorID__Enum_WaterInteraction,
		           0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m01 = sub_180005050(v102, TypeInfo::HG::Rendering::Runtime::WaterInteractionRenderingPass);
		  sub_180005050(v102, TypeInfo::HG::Rendering::Runtime::WaterInteractionRenderingPass);
		  sub_18002D1B0((HGRenderPathDefaultDeferred *)((char *)this + 5336), v103, v104, v105, v189);
		  v106 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		           (HGRenderPathBase *)this,
		           PassConstructorID__Enum_WaterDefaultDeferred,
		           0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m21 = sub_180005050(v106, TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass);
		  sub_180005050(v106, TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass);
		  sub_18002D1B0((HGRenderPathDefaultDeferred *)((char *)this + 5344), v107, v108, v109, v190);
		  v110 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		           (HGRenderPathBase *)this,
		           PassConstructorID__Enum_HZB,
		           0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m02 = sub_180005050(v110, TypeInfo::HG::Rendering::Runtime::BuildHZBPass);
		  sub_180005050(v110, TypeInfo::HG::Rendering::Runtime::BuildHZBPass);
		  sub_18002D1B0((HGRenderPathDefaultDeferred *)((char *)this + 5352), v111, v112, v113, v191);
		  v114 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		           (HGRenderPathBase *)this,
		           PassConstructorID__Enum_DepthPyramid,
		           0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m22 = sub_180005050(v114, TypeInfo::HG::Rendering::Runtime::DepthPyramidRenderingPass);
		  sub_180005050(v114, TypeInfo::HG::Rendering::Runtime::DepthPyramidRenderingPass);
		  sub_18002D1B0((HGRenderPathDefaultDeferred *)((char *)this + 5360), v115, v116, v117, v192);
		  v118 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		           (HGRenderPathBase *)this,
		           PassConstructorID__Enum_GTAO,
		           0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m03 = sub_180005050(v118, TypeInfo::HG::Rendering::Runtime::GTAOPassConstructor);
		  sub_180005050(v118, TypeInfo::HG::Rendering::Runtime::GTAOPassConstructor);
		  sub_18002D1B0((HGRenderPathDefaultDeferred *)((char *)this + 5368), v119, v120, v121, v193);
		  v122 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		           (HGRenderPathBase *)this,
		           PassConstructorID__Enum_FakePlanarReflection,
		           0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m23 = sub_180005050(v122, TypeInfo::HG::Rendering::Runtime::FakePlanarReflectionPass);
		  sub_180005050(v122, TypeInfo::HG::Rendering::Runtime::FakePlanarReflectionPass);
		  sub_18002D1B0((HGRenderPathDefaultDeferred *)((char *)this + 5376), v123, v124, v125, v194);
		  v126 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		           (HGRenderPathBase *)this,
		           PassConstructorID__Enum_HyperScreenSpaceReflection,
		           0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevInvViewProjMatrix.m00 = sub_180005050(
		                                                                                            v126,
		                                                                                            TypeInfo::HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass);
		  sub_180005050(v126, TypeInfo::HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass);
		  sub_18002D1B0((HGRenderPathDefaultDeferred *)((char *)this + 5384), v127, v128, v129, v195);
		  v130 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		           (HGRenderPathBase *)this,
		           PassConstructorID__Enum_ContactShadow,
		           0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevInvViewProjMatrix.m20 = sub_180005050(
		                                                                                            v130,
		                                                                                            TypeInfo::HG::Rendering::Runtime::ContactShadowPassConstructor);
		  sub_180005050(v130, TypeInfo::HG::Rendering::Runtime::ContactShadowPassConstructor);
		  sub_18002D1B0((HGRenderPathDefaultDeferred *)((char *)this + 5392), v131, v132, v133, v196);
		  v134 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		           (HGRenderPathBase *)this,
		           PassConstructorID__Enum_CapsuleShadow,
		           0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevInvViewProjMatrix.m01 = sub_180005050(
		                                                                                            v134,
		                                                                                            TypeInfo::HG::Rendering::Runtime::CapsuleShadowPassConstructor);
		  sub_180005050(v134, TypeInfo::HG::Rendering::Runtime::CapsuleShadowPassConstructor);
		  sub_18002D1B0((HGRenderPathDefaultDeferred *)((char *)this + 5400), v135, v136, v137, v197);
		  v138 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		           (HGRenderPathBase *)this,
		           PassConstructorID__Enum_ScreenSpaceShadowMask,
		           0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevInvViewProjMatrix.m21 = sub_180005050(
		                                                                                            v138,
		                                                                                            TypeInfo::HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor);
		  sub_180005050(v138, TypeInfo::HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor);
		  sub_18002D1B0((HGRenderPathDefaultDeferred *)((char *)this + 5408), v139, v140, v141, v198);
		  v142 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		           (HGRenderPathBase *)this,
		           PassConstructorID__Enum_DeferredLighting,
		           0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevInvViewProjMatrix.m02 = sub_180005050(
		                                                                                            v142,
		                                                                                            TypeInfo::HG::Rendering::Runtime::DeferredLightingPassConstructor);
		  sub_180005050(v142, TypeInfo::HG::Rendering::Runtime::DeferredLightingPassConstructor);
		  sub_18002D1B0((HGRenderPathDefaultDeferred *)((char *)this + 5416), v143, v144, v145, v199);
		  v146 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		           (HGRenderPathBase *)this,
		           PassConstructorID__Enum_ForwardOpaque,
		           0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevInvViewProjMatrix.m22 = sub_180005050(
		                                                                                            v146,
		                                                                                            TypeInfo::HG::Rendering::Runtime::ForwardOpaquePassConstructor);
		  sub_180005050(v146, TypeInfo::HG::Rendering::Runtime::ForwardOpaquePassConstructor);
		  sub_18002D1B0((HGRenderPathDefaultDeferred *)((char *)this + 5424), v147, v148, v149, v200);
		  v150 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		           (HGRenderPathBase *)this,
		           PassConstructorID__Enum_Transparent,
		           0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevInvViewProjMatrix.m03 = sub_180005050(
		                                                                                            v150,
		                                                                                            TypeInfo::HG::Rendering::Runtime::TransparentPassConstructor);
		  sub_180005050(v150, TypeInfo::HG::Rendering::Runtime::TransparentPassConstructor);
		  sub_18002D1B0((HGRenderPathDefaultDeferred *)((char *)this + 5432), v151, v152, v153, v201);
		  v154 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		           (HGRenderPathBase *)this,
		           PassConstructorID__Enum_VolumetricCloud,
		           0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevInvViewProjMatrix.m23 = sub_180005050(
		                                                                                            v154,
		                                                                                            TypeInfo::HG::Rendering::Runtime::VolumetricCloudPassConstructor);
		  sub_180005050(v154, TypeInfo::HG::Rendering::Runtime::VolumetricCloudPassConstructor);
		  sub_18002D1B0((HGRenderPathDefaultDeferred *)((char *)this + 5440), v155, v156, v157, v202);
		  v158 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		           (HGRenderPathBase *)this,
		           PassConstructorID__Enum_LightShaft,
		           0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m00 = sub_180005050(v158, TypeInfo::HG::Rendering::Runtime::LightShaftPassConstructor);
		  sub_180005050(v158, TypeInfo::HG::Rendering::Runtime::LightShaftPassConstructor);
		  sub_18002D1B0((HGRenderPathDefaultDeferred *)((char *)this + 5448), v159, v160, v161, v203);
		  v162 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		           (HGRenderPathBase *)this,
		           PassConstructorID__Enum_Distortion,
		           0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m20 = sub_180005050(v162, TypeInfo::HG::Rendering::Runtime::DistortionPassConstructor);
		  sub_180005050(v162, TypeInfo::HG::Rendering::Runtime::DistortionPassConstructor);
		  sub_18002D1B0((HGRenderPathDefaultDeferred *)((char *)this + 5456), v163, v164, v165, method);
		}
		
		internal HGRenderPathDefaultDeferred(HGRenderPathResources resources, HGCamera camera) {} // 0x0000000185390754-0x0000000185390780
		// HGRenderPathDefaultDeferred(HGRenderPathBase+HGRenderPathResources, HGCamera)
		void HG::Rendering::Runtime::HGRenderPathDefaultDeferred::HGRenderPathDefaultDeferred(
		        HGRenderPathDefaultDeferred *this,
		        HGRenderPathBase_HGRenderPathResources *resources,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  HGRenderPathBase_HGRenderPathResources v4; // [rsp+30h] [rbp-18h] BYREF
		
		  v4 = *resources;
		  HG::Rendering::Runtime::HGRenderPathDefaultDeferred::HGRenderPathDefaultDeferred(
		    this,
		    &v4,
		    camera,
		    HGRenderPathInternal__Enum_DefaultDeferred,
		    0LL);
		}
		
	
		// Methods
		private static PassConstructorID[] PopulatePassConstructorIds() => default; // 0x0000000182EDA450-0x0000000182EDA4A0
		// PassConstructorID[] PopulatePassConstructorIds()
		PassConstructorID__Enum__Array *HG::Rendering::Runtime::HGRenderPathDefaultDeferred::PopulatePassConstructorIds(
		        MethodInfo *method)
		{
		  Array *v1; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3571, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3571, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1269(Patch, 0LL);
		  }
		  else
		  {
		    v1 = (Array *)il2cpp_array_new_specific_1(TypeInfo::HG::Rendering::Runtime::PassConstructorID, 54LL);
		    System::Runtime::CompilerServices::RuntimeHelpers::InitializeArray(
		      v1,
		      AA287D705D7EED00C7E5BAE83524418D367A7974332AEB3D9C0FD5B96298B2A3_Field,
		      0LL);
		    return (PassConstructorID__Enum__Array *)v1;
		  }
		}
		
		protected override GBufferProfileManager.GBufferProfileConfig GetGBufferProfileConfig() => default; // 0x0000000189BF05B8-0x0000000189BF0604
		// GBufferProfileManager+GBufferProfileConfig GetGBufferProfileConfig()
		GBufferProfileManager_GBufferProfileConfig__Enum HG::Rendering::Runtime::HGRenderPathDefaultDeferred::GetGBufferProfileConfig(
		        HGRenderPathDefaultDeferred *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3572, 0LL) )
		    return 0;
		  Patch = IFix::WrappersManagerImpl::GetPatch(3572, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_7((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, 0LL);
		}
		
		protected override void OnPreRendering(ref HGRenderPathParams renderPathParams) {} // 0x0000000189BF0604-0x0000000189BF0890
		// Void OnPreRendering(HGRenderPathBase+HGRenderPathParams ByRef)
		void HG::Rendering::Runtime::HGRenderPathDefaultDeferred::OnPreRendering(
		        HGRenderPathDefaultDeferred *this,
		        HGRenderPathBase_HGRenderPathParams *renderPathParams,
		        MethodInfo *method)
		{
		  HGGraphicsFeatureManager__StaticFields *static_fields; // rdx
		  HGRenderPipeline *hgrp; // rcx
		  HGRenderGraph *renderGraph; // rsi
		  HGCamera *hgCamera; // rdi
		  bool enabledForCPUCommands; // r13
		  bool v10; // r12
		  bool v11; // r15
		  HGCamera_VolumeComponentsData *volumeComponentsData; // rax
		  float v13; // ecx
		  __int64 v14; // rax
		  uint32_t v15; // r14d
		  HGRenderGraphContext *HGContext; // rbp
		  float v17; // eax
		  float v18; // eax
		  GBufferProfileManager *v19; // rbp
		  GBufferProfileManager_GBufferProfileConfig__Enum v20; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  uint32_t preZPart0List; // [rsp+50h] [rbp-48h] BYREF
		  uint32_t preZPart1List; // [rsp+54h] [rbp-44h] BYREF
		  TextureHandle v24; // [rsp+58h] [rbp-40h] BYREF
		  uint32_t normalList; // [rsp+B8h] [rbp+20h] BYREF
		
		  normalList = 0;
		  preZPart0List = 0;
		  preZPart1List = 0;
		  if ( !IFix::WrappersManagerImpl::IsPatched(3573, 0LL) )
		  {
		    HG::Rendering::Runtime::HGRenderPathDeferred::OnPreRendering((HGRenderPathDeferred *)this, renderPathParams, 0LL);
		    hgrp = renderPathParams->hgrp;
		    if ( hgrp )
		    {
		      renderGraph = HG::Rendering::Runtime::HGRenderPipeline::get_renderGraph(hgrp, 0LL);
		      hgCamera = renderPathParams->renderRequest.hgCamera;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		      hgrp = (HGRenderPipeline *)static_fields->characterOutlineOpaque;
		      if ( hgrp )
		      {
		        enabledForCPUCommands = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabledForCPUCommands(
		                                  (HGGraphicsFeatureSwitch *)hgrp,
		                                  0LL);
		        static_fields = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		        hgrp = (HGRenderPipeline *)static_fields->characterOutlineOpaquePreZ;
		        if ( hgrp )
		        {
		          v10 = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabledForCPUCommands(
		                  (HGGraphicsFeatureSwitch *)hgrp,
		                  0LL);
		          static_fields = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		          hgrp = (HGRenderPipeline *)static_fields->characterOutlineOpaqueEqual;
		          if ( hgrp )
		          {
		            v11 = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabledForCPUCommands(
		                    (HGGraphicsFeatureSwitch *)hgrp,
		                    0LL);
		            if ( hgCamera )
		            {
		              volumeComponentsData = HG::Rendering::Runtime::HGCamera::get_volumeComponentsData(hgCamera, 0LL);
		              if ( volumeComponentsData )
		              {
		                hgrp = (HGRenderPipeline *)volumeComponentsData->fields.m_hgCharacterVolume;
		                if ( hgrp )
		                {
		                  if ( HG::Rendering::Runtime::HGCharacterVolume::GetCharOutlinePassEnableState(
		                         (HGCharacterVolume *)hgrp,
		                         0LL) )
		                  {
		                    v14 = *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants.current._ViewProjMatrix.m20;
		                    if ( !v14 )
		                      goto LABEL_23;
		                    v15 = *(_DWORD *)(v14 + 2592);
		                    if ( !renderGraph )
		                      goto LABEL_23;
		                    HGContext = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(renderGraph, 0LL);
		                    if ( !HGContext )
		                      goto LABEL_23;
		                    sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		                    UnityEngine::HyperGryph::HGMeshRender::CreateRendererListWithPreZ(
		                      v15,
		                      0x4000500u,
		                      0x4000100u,
		                      0x200u,
		                      HGContext->fields.renderContext.m_Ptr,
		                      &normalList,
		                      &preZPart0List,
		                      &preZPart1List,
		                      0,
		                      0LL);
		                    v13 = NAN;
		                    v17 = NAN;
		                    if ( enabledForCPUCommands )
		                      v17 = *(float *)&normalList;
		                    this[1].fields._._._.m_basicTransformConstants.current._InvPretransformMatrix.m33 = v17;
		                    v18 = NAN;
		                    if ( v10 )
		                      v18 = *(float *)&preZPart0List;
		                    this[1].fields._._._.m_basicTransformConstants.current._InvPretransformMatrix.m01 = v18;
		                    if ( v11 )
		                      v13 = *(float *)&preZPart1List;
		                  }
		                  else
		                  {
		                    v13 = NAN;
		                    this[1].fields._._._.m_basicTransformConstants.current._InvPretransformMatrix.m33 = NAN;
		                    this[1].fields._._._.m_basicTransformConstants.current._InvPretransformMatrix.m01 = NAN;
		                  }
		                  this[1].fields._._._.m_basicTransformConstants.current._WorldSpaceCameraPos_Internal.x = v13;
		                  v19 = *(GBufferProfileManager **)&this[1].fields._._._.m_basicTransformConstants.current._InvNonJitteredViewProjMatrix.m23;
		                  v20 = (unsigned int)sub_180002F70(18LL, this);
		                  if ( v19 )
		                  {
		                    *(TextureHandle *)&this[1].fields._._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m01 = *HG::Rendering::Runtime::GBufferProfileManager::CreateGBufferTexture(&v24, v19, v20, renderGraph, GBufferID__Enum_GBufferB, hgCamera, 0LL);
		                    return;
		                  }
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_23:
		    sub_1800D8260(hgrp, static_fields);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3573, 0LL);
		  if ( !Patch )
		    goto LABEL_23;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_457(Patch, (Object *)this, renderPathParams, 0LL);
		}
		
		protected override void RenderScene(ref HGRenderPathParams renderPathParams) {} // 0x0000000189BF0890-0x0000000189BF6CB4
		// Void RenderScene(HGRenderPathBase+HGRenderPathParams ByRef)
		// Hidden C++ exception states: #wind=42
		void HG::Rendering::Runtime::HGRenderPathDefaultDeferred::RenderScene(
		        HGRenderPathDefaultDeferred *this,
		        HGRenderPathBase_HGRenderPathParams *renderPathParams,
		        MethodInfo *method)
		{
		  HGRenderPathDefaultDeferred *v4; // rsi
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  HGRenderPipeline *hgrp; // r13
		  HGRenderGraph *renderGraph; // r15
		  HGRenderPipeline_RenderRequest *p_renderRequest; // rax
		  _OWORD *v10; // rcx
		  __int64 v11; // rdx
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  HGCamera_VolumeComponentsData *volumeComponentsData; // rax
		  __int64 v15; // rdx
		  __int64 v16; // rcx
		  __int64 v17; // rdx
		  __int64 v18; // rcx
		  HGCamera *v19; // r13
		  __int64 v20; // rdx
		  __int64 v21; // rcx
		  bool msaaEnabled; // r12
		  __int64 v23; // rdx
		  __int64 v24; // rcx
		  __int64 v25; // rdx
		  __int64 v26; // rcx
		  uint32_t v27; // r14d
		  __int64 v28; // rdx
		  __int64 v29; // rcx
		  __int64 v30; // rdx
		  __int64 v31; // rcx
		  __int64 v33; // rcx
		  BinningPass *v34; // rdx
		  __int64 v35; // rdx
		  BinningPass *v36; // rcx
		  unsigned __int64 v37; // rdx
		  unsigned __int64 v38; // r8
		  signed __int64 v39; // rtt
		  LightClusteringPassConstructor *v40; // rcx
		  __int64 v41; // r12
		  __int64 v42; // rcx
		  BinningPass *v43; // rdx
		  BinningPass_BinningData *reflectionProbeBinningData; // rax
		  __int64 v45; // rdx
		  BinningPass *v46; // rcx
		  unsigned __int64 v47; // rdx
		  unsigned __int64 v48; // r8
		  signed __int64 v49; // rtt
		  ReflectionProbeBinningPassConstructor *v50; // rcx
		  __int64 v51; // rdx
		  BinningPass *v52; // rcx
		  __int64 v53; // rdx
		  BinningPass *v54; // rcx
		  __int64 v55; // rdx
		  __int64 v56; // rcx
		  __int64 v57; // rdx
		  ParticleLightingPassConstructor *v58; // rcx
		  __int64 v59; // rdx
		  WaterSectorRenderingPass *v60; // rcx
		  __int64 v61; // rdx
		  WaterInteractionRenderingPass *v62; // rcx
		  __int64 v63; // rdx
		  FoliageOccluderPassConstructor *v64; // rcx
		  unsigned __int64 v65; // rdx
		  HGSettingParameters *v66; // rax
		  unsigned __int64 v67; // r8
		  signed __int64 v68; // rtt
		  FoliageInteractivePassConstructor *v69; // rcx
		  __int64 v70; // rdx
		  SludgePassConstructor *v71; // rcx
		  __int64 v72; // rdx
		  GpuClothSimulationPassConstructor *v73; // rcx
		  unsigned __int64 v74; // rdx
		  unsigned __int64 v75; // r8
		  signed __int64 v76; // rtt
		  DepthOnlyPassConstructor *v77; // rcx
		  unsigned __int64 v78; // rdx
		  __int64 v79; // rcx
		  __int64 v80; // rax
		  int v81; // ecx
		  unsigned __int64 v82; // r8
		  signed __int64 v83; // rtt
		  unsigned __int64 v84; // r8
		  signed __int64 v85; // rtt
		  ShadowMapPassConstructor *v86; // rcx
		  unsigned __int64 v87; // rdx
		  __int64 v88; // rcx
		  HGSettingParameters *settingParameters_k__BackingField; // rax
		  HGAtmosphereSettingParameters *atmosphereParams_k__BackingField; // rax
		  unsigned __int64 v91; // r8
		  signed __int64 v92; // rtt
		  SkyAtmospherePassConstructor *v93; // rcx
		  __int64 v94; // rdx
		  VolumetricFogPassConstructor *v95; // rcx
		  unsigned __int64 v96; // rdx
		  __int64 v97; // rcx
		  HGSettingParameters *v98; // rax
		  HGAtmosphereSettingParameters *v99; // rax
		  unsigned __int64 v100; // r8
		  signed __int64 v101; // rtt
		  BakeFogLutPassConstructor *v102; // rcx
		  unsigned __int64 v103; // rdx
		  __int64 v104; // rcx
		  CullingResults v105; // xmm0
		  char v106; // bl
		  HGRenderPipeline *v107; // rax
		  unsigned __int64 v108; // r8
		  signed __int64 v109; // rtt
		  TerrainDeformPassConstructor *v110; // rcx
		  BuildHZBPass *v111; // rdx
		  InkSimulationPassConstructor *v112; // rcx
		  TextureHandle v113; // xmm6
		  CullingResults v114; // xmm7
		  __int64 v115; // rcx
		  BuildHZBPass *v116; // rdx
		  TextureHandle *prevHZBTexture; // rax
		  __int64 v118; // rdx
		  TerrainDepthPrepassConstructor *v119; // rcx
		  HGRenderPipelineRuntimeResources *defaultResources; // rbx
		  HGRenderPipelineRuntimeResources *v121; // rax
		  __int64 v122; // rdx
		  __int64 v123; // rcx
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
		  signed __int64 v125; // rcx
		  unsigned __int64 v126; // r8
		  signed __int64 v127; // rtt
		  unsigned __int64 v128; // r8
		  signed __int64 v129; // rtt
		  BuildHZBPass *v130; // rdx
		  __int64 v131; // rdx
		  GPUDrivenCullingPassConstructor *v132; // rcx
		  unsigned __int64 v133; // rdx
		  __int64 v134; // rcx
		  unsigned __int64 v135; // r8
		  signed __int64 v136; // rtt
		  __int64 v137; // rcx
		  BuildHZBPass *v138; // rdx
		  __int64 v139; // rcx
		  uint32_t RendererList; // r13d
		  uint32_t m10_low; // eax
		  BuildHZBPass *v142; // rdx
		  __int64 v143; // rdx
		  uint32_t m20_low; // eax
		  DepthPrepassConstructor *v145; // rcx
		  __int64 v146; // rdx
		  TextureHandle v147; // xmm1
		  BuildHZBPass *v148; // rcx
		  TextureHandle depthTexture; // xmm6
		  HGRenderPipelineRuntimeResources *v150; // rax
		  unsigned __int64 v151; // rdx
		  __int64 v152; // rcx
		  HGRenderPipelineRuntimeResources_ShaderResources *v153; // rax
		  int v154; // ecx
		  unsigned __int64 v155; // r8
		  signed __int64 v156; // rtt
		  unsigned __int64 v157; // r8
		  signed __int64 v158; // rtt
		  GPUDrivenCullingPassConstructor *v159; // rcx
		  HGManagerContext *currentManagerContext; // rax
		  __int64 v161; // rdx
		  __int64 v162; // rcx
		  HGWaterManager *waterManager_k__BackingField; // rcx
		  __int64 v164; // rdx
		  __int64 v165; // rcx
		  __int64 v166; // rdx
		  GBufferPassConstructor *v167; // rcx
		  __int64 v168; // rdx
		  TextureHandle v169; // xmm1
		  int m01_low; // eax
		  BuildHZBPass *v171; // rcx
		  __int128 v172; // xmm7
		  DepthPyramidRenderingPass_PassInput v173; // xmm6
		  TextureHandle v174; // xmm8
		  TextureHandle *GBufferAttachment; // rax
		  __int64 v176; // rdx
		  HGGraphicsFeatureSwitch *deferredDecal; // rcx
		  bool enabledForCPUCommands; // bl
		  HGGraphicsFeatureManager__StaticFields *static_fields; // rdx
		  HGGraphicsFeatureSwitch *deferredErosion; // rcx
		  GpuClothSimulationPassConstructor_PassInput v181; // al
		  __int64 v182; // rdx
		  __int64 v183; // rcx
		  __int64 v184; // rcx
		  __int64 v185; // rdx
		  __int64 v186; // rcx
		  HGRenderGraphContext *HGContext; // rbx
		  __int64 v188; // rax
		  __int64 v189; // rdx
		  __int64 v190; // rcx
		  HGRenderGraphContext *v191; // rbx
		  void *m_Ptr; // rax
		  __int64 v193; // rdx
		  __int64 v194; // rcx
		  __int64 v195; // rdx
		  __int64 v196; // rcx
		  __int64 v197; // rax
		  HGManagerContext *v198; // rax
		  __int64 v199; // rdx
		  __int64 v200; // rcx
		  HGWaterManager *v201; // rcx
		  __int64 v202; // rdx
		  DecalPassConstructor *v203; // rcx
		  __int64 v204; // rdx
		  WaterDefaultDeferredRenderingPass *v205; // rcx
		  HGCamera *v206; // rax
		  TextureHandle *v207; // rax
		  __int64 v208; // rdx
		  TextureHandle v209; // xmm0
		  GPUParticleSimulationPassConstructor *v210; // rcx
		  DepthPyramidRenderingPass_PassInput v211; // xmm7
		  TextureHandle v212; // xmm6
		  HGSettingParameters *v213; // r13
		  __int64 v214; // rdx
		  __int64 v215; // rcx
		  TextureHandle *v216; // rax
		  WaterInteractionRenderingPass *v217; // rdx
		  unsigned __int64 v218; // r8
		  signed __int64 v219; // rtt
		  WaterDefaultDeferredRenderingPass *v220; // rcx
		  HGCamera *v221; // rdx
		  TextureHandle v222; // xmm6
		  DepthPyramidRenderingPass_PassInput v223; // xmm7
		  __int64 v224; // rdx
		  WaterDefaultDeferredRenderingPass *v225; // rcx
		  __int64 v226; // rdx
		  WaterDefaultDeferredRenderingPass *v227; // rcx
		  __int64 v228; // rcx
		  __int64 v229; // rdx
		  __int64 v230; // rcx
		  __int64 v231; // rdx
		  WaterDefaultDeferredRenderingPass *v232; // rdx
		  __int64 v233; // rcx
		  WaterDefaultDeferredRenderingPass *v234; // rdx
		  HyperScreenSpaceReflectionRenderingPass *v235; // rcx
		  __int64 v236; // rdx
		  DepthPyramidRenderingPass *v237; // rcx
		  TextureHandle v238; // xmm7
		  TextureHandle v239; // xmm8
		  NativeArray_1_HG_Rendering_RenderGraphModule_TextureHandle_ v240; // xmm9
		  NativeArray_1_System_Int32_ v241; // xmm10
		  __int64 v242; // rdx
		  GTAOPassConstructor *v243; // rcx
		  HGSettingParameters *v244; // r13
		  __int64 v245; // rcx
		  DepthPyramidRenderingPass *v246; // rdx
		  __int64 v247; // rcx
		  DepthPyramidRenderingPass *v248; // rdx
		  __int64 v249; // rcx
		  WaterDefaultDeferredRenderingPass *v250; // rdx
		  unsigned __int64 v251; // r8
		  signed __int64 v252; // rtt
		  HyperScreenSpaceReflectionRenderingPass *v253; // rcx
		  HGCamera *v254; // rdx
		  __int64 v255; // rcx
		  HyperScreenSpaceReflectionRenderingPass *v256; // rdx
		  __int64 v257; // rcx
		  HyperScreenSpaceReflectionRenderingPass *v258; // rdx
		  TextureHandle v259; // xmm7
		  Vector4 si128; // xmm6
		  __int64 v261; // rdx
		  ContactShadowPassConstructor *v262; // rcx
		  HGSettingParameters *v263; // r13
		  unsigned __int64 v264; // rdx
		  __int64 v265; // rcx
		  HGRenderPipeline *v266; // rax
		  unsigned __int64 v267; // r8
		  signed __int64 v268; // rtt
		  CapsuleShadowPassConstructor *v269; // rcx
		  TextureHandle v270; // xmm8
		  CullingResults v271; // xmm9
		  TextureHandle v272; // xmm7
		  TextureHandle v273; // xmm6
		  HGSettingParameters *v274; // r13
		  __int64 v275; // rdx
		  ScreenSpaceShadowMaskPassConstructor *v276; // rcx
		  __int64 v277; // rdx
		  __int64 v278; // rcx
		  HGCamera *v279; // rbx
		  HGRenderPipeline *v280; // r13
		  unsigned __int64 v281; // r8
		  signed __int64 v282; // rtt
		  FakePlanarReflectionPass *v283; // rbx
		  BasicTransformConstants *basicTransformConstants; // r13
		  ShaderVariablesGlobal *shaderVariablesGlobal; // rax
		  __int64 v286; // rdx
		  HGCamera *v287; // rcx
		  __int64 v288; // rcx
		  FakePlanarReflectionPass *v289; // rdx
		  __int64 v290; // rcx
		  BakeFogLutPassConstructor *v291; // rdx
		  __int64 v292; // rcx
		  WaterDefaultDeferredRenderingPass *v293; // rdx
		  unsigned __int64 v294; // r8
		  signed __int64 v295; // rtt
		  __int64 v296; // rdx
		  DeferredLightingPassConstructor_PassInput *v297; // rcx
		  TextureHandle *v298; // rax
		  DeferredLightingPassConstructor *v299; // rcx
		  unsigned __int64 v300; // r8
		  signed __int64 v301; // rtt
		  __int64 v302; // rdx
		  __int64 v303; // rcx
		  __int64 v304; // rdx
		  ForwardOpaquePassConstructor *v305; // rcx
		  TextureHandle v306; // xmm8
		  int32_t SceneColorTexture; // ebx
		  TextureHandle v308; // xmm7
		  int32_t CameraDepthTexture; // eax
		  __int64 v310; // rdx
		  __int64 v311; // rcx
		  TextureHandle *v312; // rax
		  WaterInteractionRenderingPass *v313; // rdx
		  __int64 v314; // rcx
		  HyperScreenSpaceReflectionRenderingPass *v315; // rdx
		  __int64 v316; // rcx
		  HyperScreenSpaceReflectionRenderingPass *v317; // rdx
		  __int64 v318; // rdx
		  WaterDefaultDeferredRenderingPass *v319; // rcx
		  unsigned __int64 v320; // rdx
		  __int64 v321; // rcx
		  HGSettingParameters *v322; // rax
		  int v323; // ecx
		  unsigned __int64 v324; // r8
		  signed __int64 v325; // rtt
		  unsigned __int64 v326; // r8
		  signed __int64 v327; // rtt
		  VolumetricCloudPassConstructor *v328; // rcx
		  __int64 v329; // rdx
		  TextureHandle v330; // xmm6
		  TextureHandle v331; // xmm7
		  HGSettingParameters *v332; // r13
		  HGLightShaftSettingParameters *lightShaft_k__BackingField; // rcx
		  __int64 v334; // rdx
		  HGLightShaftSettingParameters *v335; // rcx
		  __int64 v336; // rdx
		  HGLightShaftSettingParameters *v337; // rcx
		  __int64 v338; // rdx
		  HGLightShaftSettingParameters *v339; // rcx
		  __int64 v340; // rdx
		  LightShaftPassConstructor *v341; // rcx
		  __int64 v342; // rcx
		  DepthPyramidRenderingPass *v343; // rdx
		  unsigned __int64 v344; // r8
		  signed __int64 v345; // rtt
		  unsigned __int64 v346; // r8
		  signed __int64 v347; // rtt
		  __int64 v348; // rdx
		  __int64 v349; // rcx
		  __int64 v350; // rdx
		  TransparentPassConstructor *v351; // rcx
		  __int64 v352; // rdx
		  __int64 v353; // rcx
		  __int64 v354; // rdx
		  DistortionPassConstructor *v355; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v357; // rdx
		  __int64 v358; // rcx
		  __int64 v359; // [rsp+0h] [rbp-5618h] BYREF
		  HGCamera *camera; // [rsp+20h] [rbp-55F8h]
		  GpuClothSimulationPassConstructor_PassInput v361; // [rsp+60h] [rbp-55B8h] BYREF
		  ReflectionProbeBinningPassConstructor_PassOutput v362; // [rsp+61h] [rbp-55B7h] BYREF
		  bool enableWetness[6]; // [rsp+62h] [rbp-55B6h] BYREF
		  HGRenderGraph *v364; // [rsp+68h] [rbp-55B0h]
		  uint32_t viewHandle[4]; // [rsp+70h] [rbp-55A8h] BYREF
		  bool CharOutlinePassEnableState; // [rsp+80h] [rbp-5598h]
		  bool wetnessHighQualityEnabled; // [rsp+81h] [rbp-5597h] BYREF
		  TextureHandle v368; // [rsp+90h] [rbp-5588h] BYREF
		  HGRenderPipeline *v369; // [rsp+A0h] [rbp-5578h]
		  DepthPyramidRenderingPass_PassInput v370; // [rsp+B0h] [rbp-5568h] BYREF
		  FoliageOccluderPassConstructor_PassOutput v371; // [rsp+C0h] [rbp-5558h] BYREF
		  FoliageOccluderPassConstructor_PassInput v372; // [rsp+C1h] [rbp-5557h] BYREF
		  SludgePassConstructor_PassOutput v373; // [rsp+C2h] [rbp-5556h] BYREF
		  DepthOnlyPassConstructor_PassOutput v374; // [rsp+C3h] [rbp-5555h] BYREF
		  TerrainDeformPassConstructor_PassOutput v375; // [rsp+C4h] [rbp-5554h] BYREF
		  GBufferPassConstructor_PassOutput v376; // [rsp+C5h] [rbp-5553h] BYREF
		  HyperScreenSpaceReflectionRenderingPass_PassOutput v377; // [rsp+C6h] [rbp-5552h] BYREF
		  CapsuleShadowPassConstructor_PassOutput v378; // [rsp+C7h] [rbp-5551h] BYREF
		  FakePlanarReflectionPass_PassOutput v379; // [rsp+C8h] [rbp-5550h] BYREF
		  GPUParticleSimulationPassConstructor_PassOutput v380; // [rsp+C9h] [rbp-554Fh] BYREF
		  BuildHZBPass_PassInput v381; // [rsp+D0h] [rbp-5548h] BYREF
		  BuildHZBPass_PassInput v382; // [rsp+F0h] [rbp-5528h] BYREF
		  ScriptableRenderContext renderContext; // [rsp+110h] [rbp-5508h] BYREF
		  char *v384; // [rsp+118h] [rbp-5500h]
		  HGSettingParameters *settingParameter[2]; // [rsp+120h] [rbp-54F8h] BYREF
		  LightCullResult lightCullResult; // [rsp+130h] [rbp-54E8h]
		  HGCamera *hgCamera; // [rsp+140h] [rbp-54D8h]
		  _BYTE v388[72]; // [rsp+150h] [rbp-54C8h] BYREF
		  GBufferOutput gbufferOutput; // [rsp+1A0h] [rbp-5478h] BYREF
		  CullingResults cullingResults; // [rsp+1C0h] [rbp-5458h]
		  HGAtmosphereSettingParameters *v391; // [rsp+1D0h] [rbp-5448h] BYREF
		  HGAtmosphereSettingParameters *v392; // [rsp+1D8h] [rbp-5440h] BYREF
		  GPUDrivenCullingPassConstructor_PassInput v393; // [rsp+1E0h] [rbp-5438h] BYREF
		  _QWORD v394[2]; // [rsp+210h] [rbp-5408h] BYREF
		  TextureHandle v395; // [rsp+220h] [rbp-53F8h] BYREF
		  TerrainDepthPrepassConstructor_PassOutput v396; // [rsp+230h] [rbp-53E8h] BYREF
		  SludgePassConstructor_PassInput v397; // [rsp+240h] [rbp-53D8h] BYREF
		  SkyAtmospherePassConstructor_PassInput v398; // [rsp+248h] [rbp-53D0h] BYREF
		  BakeFogLutPassConstructor_PassInput v399; // [rsp+250h] [rbp-53C8h] BYREF
		  CullingResults v400; // [rsp+258h] [rbp-53C0h]
		  _BYTE v401[24]; // [rsp+268h] [rbp-53B0h] BYREF
		  FoliageInteractivePassConstructor_PassInput v402; // [rsp+280h] [rbp-5398h] BYREF
		  LightShaftPassConstructor_PassOutput v403; // [rsp+288h] [rbp-5390h] BYREF
		  _OWORD v404[2]; // [rsp+2A0h] [rbp-5378h] BYREF
		  __int128 v405; // [rsp+2C0h] [rbp-5358h]
		  _QWORD v406[2]; // [rsp+2D0h] [rbp-5348h] BYREF
		  DepthOnlyPassConstructor_PassInput v407; // [rsp+2E0h] [rbp-5338h] BYREF
		  Matrix4x4 invViewMatrix; // [rsp+2F0h] [rbp-5328h] BYREF
		  Vector4 ScreenParams; // [rsp+330h] [rbp-52E8h]
		  GBufferOutput v410; // [rsp+340h] [rbp-52D8h]
		  CullingResults v411; // [rsp+360h] [rbp-52B8h]
		  __int128 v412; // [rsp+370h] [rbp-52A8h]
		  __int128 v413; // [rsp+380h] [rbp-5298h]
		  __int64 v414; // [rsp+390h] [rbp-5288h]
		  ShadowMapPassConstructor_PassOutput v415; // [rsp+3A0h] [rbp-5278h] BYREF
		  TransparentPassConstructor_PassOutput v416; // [rsp+3E0h] [rbp-5238h] BYREF
		  DistortionPassConstructor_PassOutput v417; // [rsp+3F0h] [rbp-5228h] BYREF
		  DepthPrepassConstructor_PassInput v418; // [rsp+400h] [rbp-5218h] BYREF
		  ShadowMapPassConstructor_PassInput v419; // [rsp+460h] [rbp-51B8h] BYREF
		  VolumetricCloudPassConstructor_PassInput v420; // [rsp+4B0h] [rbp-5168h] BYREF
		  DepthOnlyPassConstructor_PassInput v421; // [rsp+4F0h] [rbp-5128h] BYREF
		  WaterDefaultDeferredRenderingPass_PassInput v422; // [rsp+500h] [rbp-5118h] BYREF
		  TerrainDeformPassConstructor_PassInput v423; // [rsp+5D0h] [rbp-5048h] BYREF
		  ContactShadowPassConstructor_PassInput v424; // [rsp+5F8h] [rbp-5020h] BYREF
		  LightClusteringPassConstructor_PassInput v425; // [rsp+620h] [rbp-4FF8h] BYREF
		  TerrainDepthPrepassConstructor_PassInput v426; // [rsp+680h] [rbp-4F98h] BYREF
		  GBufferPassConstructor_PassInput v427; // [rsp+6D0h] [rbp-4F48h] BYREF
		  ReflectionProbeBinningPassConstructor_PassInput v428; // [rsp+790h] [rbp-4E88h] BYREF
		  WaterDefaultDeferredRenderingPass_PassOutput v429; // [rsp+7C8h] [rbp-4E50h] BYREF
		  GPUParticleSimulationPassConstructor_PassInput v430; // [rsp+7E8h] [rbp-4E30h] BYREF
		  WaterDefaultDeferredRenderingPass_PassOutput v431; // [rsp+808h] [rbp-4E10h] BYREF
		  WaterDefaultDeferredRenderingPass_PassOutput v432; // [rsp+828h] [rbp-4DF0h] BYREF
		  GPUDrivenCullingPassConstructor_PassInput v433; // [rsp+848h] [rbp-4DD0h] BYREF
		  GPUDrivenCullingPassConstructor_PassInput v434; // [rsp+878h] [rbp-4DA0h] BYREF
		  LightShaftPassConstructor_PassInput v435; // [rsp+8A8h] [rbp-4D70h] BYREF
		  FakePlanarReflectionPass_PassInput v436; // [rsp+8E0h] [rbp-4D38h] BYREF
		  CapsuleShadowPassConstructor_PassInput v437; // [rsp+9A0h] [rbp-4C78h] BYREF
		  Il2CppExceptionWrapper *v438; // [rsp+A30h] [rbp-4BE8h] BYREF
		  Il2CppExceptionWrapper *v439; // [rsp+A38h] [rbp-4BE0h] BYREF
		  Il2CppExceptionWrapper *v440; // [rsp+A40h] [rbp-4BD8h] BYREF
		  Il2CppExceptionWrapper *v441; // [rsp+A48h] [rbp-4BD0h] BYREF
		  Il2CppExceptionWrapper *v442; // [rsp+A50h] [rbp-4BC8h] BYREF
		  Il2CppExceptionWrapper *v443; // [rsp+A58h] [rbp-4BC0h] BYREF
		  Il2CppExceptionWrapper *v444; // [rsp+A60h] [rbp-4BB8h] BYREF
		  Il2CppExceptionWrapper *v445; // [rsp+A68h] [rbp-4BB0h] BYREF
		  Il2CppExceptionWrapper *v446; // [rsp+A70h] [rbp-4BA8h] BYREF
		  Il2CppExceptionWrapper *v447; // [rsp+A78h] [rbp-4BA0h] BYREF
		  Il2CppExceptionWrapper *v448; // [rsp+A80h] [rbp-4B98h] BYREF
		  Il2CppExceptionWrapper *v449; // [rsp+A88h] [rbp-4B90h] BYREF
		  Il2CppExceptionWrapper *v450; // [rsp+A90h] [rbp-4B88h] BYREF
		  Il2CppExceptionWrapper *v451; // [rsp+A98h] [rbp-4B80h] BYREF
		  Il2CppExceptionWrapper *v452; // [rsp+AA0h] [rbp-4B78h] BYREF
		  Il2CppExceptionWrapper *v453; // [rsp+AA8h] [rbp-4B70h] BYREF
		  Il2CppExceptionWrapper *v454; // [rsp+AB0h] [rbp-4B68h] BYREF
		  Il2CppExceptionWrapper *v455; // [rsp+AB8h] [rbp-4B60h] BYREF
		  Il2CppExceptionWrapper *v456; // [rsp+AC0h] [rbp-4B58h] BYREF
		  Il2CppExceptionWrapper *v457; // [rsp+AC8h] [rbp-4B50h] BYREF
		  Il2CppExceptionWrapper *v458; // [rsp+AD0h] [rbp-4B48h] BYREF
		  Il2CppExceptionWrapper *v459; // [rsp+AD8h] [rbp-4B40h] BYREF
		  Il2CppExceptionWrapper *v460; // [rsp+AE0h] [rbp-4B38h] BYREF
		  Il2CppExceptionWrapper *v461; // [rsp+AE8h] [rbp-4B30h] BYREF
		  Il2CppExceptionWrapper *v462; // [rsp+AF0h] [rbp-4B28h] BYREF
		  Il2CppExceptionWrapper *v463; // [rsp+AF8h] [rbp-4B20h] BYREF
		  Il2CppExceptionWrapper *v464; // [rsp+B00h] [rbp-4B18h] BYREF
		  Il2CppExceptionWrapper *v465; // [rsp+B08h] [rbp-4B10h] BYREF
		  Il2CppExceptionWrapper *v466; // [rsp+B10h] [rbp-4B08h] BYREF
		  Il2CppExceptionWrapper *v467; // [rsp+B18h] [rbp-4B00h] BYREF
		  Il2CppExceptionWrapper *v468; // [rsp+B20h] [rbp-4AF8h] BYREF
		  Il2CppExceptionWrapper *v469; // [rsp+B28h] [rbp-4AF0h] BYREF
		  Il2CppExceptionWrapper *v470; // [rsp+B30h] [rbp-4AE8h] BYREF
		  Il2CppExceptionWrapper *v471; // [rsp+B38h] [rbp-4AE0h] BYREF
		  Il2CppExceptionWrapper *v472; // [rsp+B40h] [rbp-4AD8h] BYREF
		  Il2CppExceptionWrapper *v473; // [rsp+B48h] [rbp-4AD0h] BYREF
		  Il2CppExceptionWrapper *v474; // [rsp+B50h] [rbp-4AC8h] BYREF
		  Il2CppExceptionWrapper *v475; // [rsp+B58h] [rbp-4AC0h] BYREF
		  Il2CppExceptionWrapper *v476; // [rsp+B60h] [rbp-4AB8h] BYREF
		  Il2CppExceptionWrapper *v477; // [rsp+B68h] [rbp-4AB0h] BYREF
		  Il2CppExceptionWrapper *v478; // [rsp+B70h] [rbp-4AA8h] BYREF
		  ForwardOpaquePassConstructor_PassInput v479; // [rsp+B80h] [rbp-4A98h] BYREF
		  Il2CppExceptionWrapper *v480; // [rsp+C50h] [rbp-49C8h] BYREF
		  _BYTE v481[64]; // [rsp+C60h] [rbp-49B8h] BYREF
		  ResourceHandle v482; // [rsp+CA0h] [rbp-4978h]
		  GTAOPassConstructor_PassInput v483; // [rsp+CB0h] [rbp-4968h] BYREF
		  VolumetricCloudPassConstructor_PassInput v484; // [rsp+D00h] [rbp-4918h] BYREF
		  HyperScreenSpaceReflectionRenderingPass_PassInput v485; // [rsp+D40h] [rbp-48D8h] BYREF
		  LightClusteringPassConstructor_PassInput input; // [rsp+E10h] [rbp-4808h] BYREF
		  ShadowMapPassConstructor_PassInput v487; // [rsp+E70h] [rbp-47A8h] BYREF
		  _OWORD v488[10]; // [rsp+EC0h] [rbp-4758h] BYREF
		  HGRenderPipeline *v489; // [rsp+F60h] [rbp-46B8h] BYREF
		  __int128 v490; // [rsp+F68h] [rbp-46B0h]
		  __int128 v491; // [rsp+F78h] [rbp-46A0h]
		  __int128 v492; // [rsp+F88h] [rbp-4690h]
		  __int128 v493; // [rsp+F98h] [rbp-4680h]
		  __int128 v494; // [rsp+FA8h] [rbp-4670h]
		  __int64 v495; // [rsp+FB8h] [rbp-4660h]
		  float m23; // [rsp+FC0h] [rbp-4658h]
		  GraphicsFormat__Enum ColorBufferFormat; // [rsp+FC4h] [rbp-4654h]
		  DepthPrepassConstructor_PassInput v498; // [rsp+FD0h] [rbp-4648h] BYREF
		  HyperScreenSpaceReflectionRenderingPass_PassInput v499; // [rsp+1030h] [rbp-45E8h] BYREF
		  CapsuleShadowPassConstructor_PassInput v500; // [rsp+1100h] [rbp-4518h] BYREF
		  DistortionPassConstructor_PassInput v501; // [rsp+1190h] [rbp-4488h] BYREF
		  ParticleLightingPassConstructor_PassInput v502; // [rsp+1230h] [rbp-43E8h] BYREF
		  GBufferPassConstructor_PassInput v503; // [rsp+12E0h] [rbp-4338h] BYREF
		  FakePlanarReflectionPass_PassInput v504; // [rsp+13A0h] [rbp-4278h] BYREF
		  ForwardOpaquePassConstructor_PassInput v505; // [rsp+1460h] [rbp-41B8h] BYREF
		  WaterDefaultDeferredRenderingPass_PassInput v506; // [rsp+1530h] [rbp-40E8h] BYREF
		  WaterDefaultDeferredRenderingPass_PassInput v507; // [rsp+1600h] [rbp-4018h] BYREF
		  HyperScreenSpaceReflectionRenderingPass_PassInput v508; // [rsp+16D0h] [rbp-3F48h] BYREF
		  WaterDefaultDeferredRenderingPass_PassInput v509; // [rsp+17A0h] [rbp-3E78h] BYREF
		  DeferredLightingPassConstructor_PassInput v510; // [rsp+1870h] [rbp-3DA8h] BYREF
		  LightClusteringPassConstructor_PassOutput output; // [rsp+1980h] [rbp-3C98h] BYREF
		  unsigned int v512; // [rsp+1D90h] [rbp-3888h]
		  int32_t v513; // [rsp+1D94h] [rbp-3884h]
		  _OWORD v514[5]; // [rsp+1DB0h] [rbp-3868h] BYREF
		  HGRenderPipeline *v515; // [rsp+1E00h] [rbp-3818h] BYREF
		  int v516; // [rsp+1E08h] [rbp-3810h]
		  __int128 v517; // [rsp+1E10h] [rbp-3808h]
		  __int128 v518; // [rsp+1E20h] [rbp-37F8h]
		  _QWORD v519[9]; // [rsp+1E30h] [rbp-37E8h] BYREF
		  CullingResults v520; // [rsp+1E78h] [rbp-37A0h]
		  PerObjectData__Enum bakedLightingConfig; // [rsp+1E88h] [rbp-3790h]
		  float z; // [rsp+1E8Ch] [rbp-378Ch]
		  bool v523; // [rsp+1E90h] [rbp-3788h]
		  float screenCullingRatio; // [rsp+1E94h] [rbp-3784h]
		  float screenRatioCullingDistance; // [rsp+1E98h] [rbp-3780h]
		  uint32_t screenCullingLayerMask; // [rsp+1E9Ch] [rbp-377Ch]
		  _BYTE v527[392]; // [rsp+3050h] [rbp-25C8h] BYREF
		  char v528; // [rsp+31D8h] [rbp-2440h]
		  __int16 v529; // [rsp+31D9h] [rbp-243Fh]
		  __int64 v530; // [rsp+31DCh] [rbp-243Ch]
		  int v531; // [rsp+31E4h] [rbp-2434h]
		  int v532; // [rsp+31E8h] [rbp-2430h]
		  char v533; // [rsp+31ECh] [rbp-242Ch]
		  float deltaTime; // [rsp+31F0h] [rbp-2428h]
		  List_1_HG_Rendering_Runtime_IVolumetricRenderObject_ *v535; // [rsp+32C8h] [rbp-2350h]
		  TransparentPassConstructor_PassInput v536; // [rsp+42F0h] [rbp-1328h] BYREF
		  char v539; // [rsp+5638h] [rbp+20h] BYREF
		
		  v4 = this;
		  v539 = 0;
		  sub_18033B9D0(&input, 0LL, 88LL);
		  memset(&v428, 0, sizeof(v428));
		  memset(v404, 0, sizeof(v404));
		  v405 = 0LL;
		  v406[0] = 0LL;
		  sub_18033B9D0(&v502, 0LL, 168LL);
		  v372 = 0;
		  v371 = 0;
		  v402.settingParams = 0LL;
		  v394[0] = 0LL;
		  v397 = 0LL;
		  v373 = 0;
		  v421 = 0LL;
		  v374 = 0;
		  v407 = 0LL;
		  sub_18033B9D0(&v487, 0LL, 80LL);
		  memset(&v415, 0, sizeof(v415));
		  sub_18033B9D0(&v419, 0LL, 80LL);
		  v398.atmosphereParams = 0LL;
		  v391 = 0LL;
		  v399.atmosphereParams = 0LL;
		  v392 = 0LL;
		  memset(&v423, 0, sizeof(v423));
		  v375 = 0;
		  v400 = 0LL;
		  memset(v401, 0, sizeof(v401));
		  memset(&v433, 0, sizeof(v433));
		  memset(&v393, 0, sizeof(v393));
		  sub_18033B9D0(&v498, 0LL, 96LL);
		  sub_18033B9D0(&v418, 0LL, 96LL);
		  memset(&gbufferOutput, 0, sizeof(gbufferOutput));
		  memset(&v434, 0, sizeof(v434));
		  sub_18033B9D0(&v503, 0LL, 184LL);
		  v376 = 0;
		  sub_18033B9D0(&v506, 0LL, 208LL);
		  memset(&v429, 0, sizeof(v429));
		  sub_18033B9D0(&v422, 0LL, 208LL);
		  memset(&v430, 0, sizeof(v430));
		  v380 = 0;
		  sub_18033B9D0(&v507, 0LL, 208LL);
		  memset(&v431, 0, sizeof(v431));
		  sub_18033B9D0(&v499, 0LL, 208LL);
		  sub_18033B9D0(&v485, 0LL, 208LL);
		  sub_18033B9D0(&v483, 0LL, 72LL);
		  sub_18033B9D0(&v508, 0LL, 208LL);
		  v377 = 0;
		  memset(&v424, 0, sizeof(v424));
		  sub_18033B9D0(&v500, 0LL, 144LL);
		  v378 = 0;
		  sub_18033B9D0(&v437, 0LL, 144LL);
		  sub_18033B9D0(&v504, 0LL, 184LL);
		  v379 = 0;
		  sub_18033B9D0(&v436, 0LL, 184LL);
		  sub_18033B9D0(&v510, 0LL, 264LL);
		  sub_18033B9D0(v488, 0LL, 264LL);
		  sub_18033B9D0(&v505, 0LL, 200LL);
		  sub_18033B9D0(&v479, 0LL, 200LL);
		  sub_18033B9D0(&v509, 0LL, 208LL);
		  memset(&v432, 0, sizeof(v432));
		  sub_18033B9D0(&v484, 0LL, 64LL);
		  sub_18033B9D0(&v420, 0LL, 64LL);
		  memset(&v435, 0, sizeof(v435));
		  memset(&v403, 0, sizeof(v403));
		  sub_18033B9D0(&v536, 0LL, 4768LL);
		  v416 = 0LL;
		  sub_18033B9D0(v514, 0LL, 4768LL);
		  sub_18033B9D0(&v501, 0LL, 152LL);
		  v417 = 0LL;
		  if ( !IFix::WrappersManagerImpl::IsPatched(3588, 0LL) )
		  {
		    hgrp = renderPathParams->hgrp;
		    v369 = hgrp;
		    if ( !hgrp )
		      sub_1800D8260(v6, v5);
		    renderGraph = HG::Rendering::Runtime::HGRenderPipeline::get_renderGraph(hgrp, 0LL);
		    v364 = renderGraph;
		    renderContext.m_Ptr = renderPathParams->renderGraphParams.scriptableRenderContext.m_Ptr;
		    cullingResults = renderPathParams->renderRequest.cullingResults.cullingResults;
		    lightCullResult = renderPathParams->renderRequest.cullingResults.lightCullResult;
		    hgCamera = renderPathParams->renderRequest.hgCamera;
		    settingParameter[0] = hgrp->fields._settingParameters_k__BackingField;
		    p_renderRequest = &renderPathParams->renderRequest;
		    v10 = v527;
		    v11 = 5LL;
		    do
		    {
		      *v10 = *(_OWORD *)&p_renderRequest->hgCamera;
		      v10[1] = *(_OWORD *)&p_renderRequest->clearCameraSettings;
		      v10[2] = *(_OWORD *)&p_renderRequest->target.id.m_InstanceID;
		      v10[3] = *(_OWORD *)&p_renderRequest->target.id.m_MipLevel;
		      v10[4] = *(_OWORD *)&p_renderRequest->target.face;
		      v10[5] = *(_OWORD *)&p_renderRequest->target.targetDepth;
		      v10[6] = p_renderRequest->cullingResults.cullingResults;
		      v10 += 8;
		      *(v10 - 1) = *(_OWORD *)&p_renderRequest->cullingResults.customPassCullingResults.hasValue;
		      p_renderRequest = (HGRenderPipeline_RenderRequest *)((char *)p_renderRequest + 128);
		      --v11;
		    }
		    while ( v11 );
		    v368.handle.m_Value = HG::Rendering::Runtime::HGRenderPipeline::GetColorBufferFormat(
		                            hgrp,
		                            *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._ViewProjMatrix.m20,
		                            0LL);
		    if ( !*(_QWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._ViewProjMatrix.m20 )
		      sub_1800D8260(v13, v12);
		    volumeComponentsData = HG::Rendering::Runtime::HGCamera::get_volumeComponentsData(
		                             *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._ViewProjMatrix.m20,
		                             0LL);
		    if ( !volumeComponentsData )
		      sub_1800D8260(v16, v15);
		    if ( !volumeComponentsData->fields.m_hgCharacterVolume )
		      sub_1800D8260(v16, v15);
		    CharOutlinePassEnableState = HG::Rendering::Runtime::HGCharacterVolume::GetCharOutlinePassEnableState(
		                                   volumeComponentsData->fields.m_hgCharacterVolume,
		                                   0LL);
		    enableWetness[0] = renderPathParams->renderRequest.wetnessEnabled;
		    wetnessHighQualityEnabled = renderPathParams->renderRequest.wetnessHighQualityEnabled;
		    v19 = *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._ViewProjMatrix.m20;
		    if ( !v19 )
		      sub_1800D8260(v18, v17);
		    msaaEnabled = HG::Rendering::Runtime::HGCamera::get_msaaEnabled(
		                    *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._ViewProjMatrix.m20,
		                    0LL);
		    if ( !*(_QWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._ViewProjMatrix.m20 )
		      sub_1800D8260(v21, v20);
		    if ( !settingParameter[0] )
		      sub_1800D8260(v21, v20);
		    HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		      settingParameter[0]->fields._copySceneRTScale_k__BackingField,
		      MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		    v27 = sub_182F3EA70(v24, v23);
		    if ( !*(_QWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._ViewProjMatrix.m20 )
		      sub_1800D8260(v26, v25);
		    HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		      settingParameter[0]->fields._copySceneRTScale_k__BackingField,
		      MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		    viewHandle[0] = v27;
		    viewHandle[1] = sub_182F3EA70(v29, v28);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		    v395 = *HG::Rendering::Runtime::HGRenderPipeline::CreateColorBuffer(
		              &v395,
		              renderGraph,
		              v19,
		              msaaEnabled,
		              (GraphicsFormat__Enum)v368.handle.m_Value,
		              *(Vector2Int *)viewHandle,
		              0LL);
		    if ( !*(_QWORD *)&v4[1].fields._._._.m_basicTransformConstants._PrevViewProjMatrix.m21 )
		      sub_1800D8260(v31, v30);
		    HG::Rendering::Runtime::BinningPass::Prepare(
		      *(BinningPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevViewProjMatrix.m21,
		      renderGraph,
		      0LL);
		    sub_18033B9D0(&output, 0LL, 1072LL);
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)7u,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		    v368.handle = 0LL;
		    v368.fallBackResource = (ResourceHandle)&v539;
		    try
		    {
		      sub_18033B9D0(&v425, 0LL, 88LL);
		      v425.cullingResults = cullingResults;
		      v425.lightCullResult = lightCullResult;
		      v34 = *(BinningPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevViewProjMatrix.m21;
		      if ( !v34 )
		        sub_1800D8250(v33, 0LL);
		      v425.binningData = *HG::Rendering::Runtime::BinningPass::get_lightBinningData(
		                            (BinningPass_BinningData *)v388,
		                            v34,
		                            0LL);
		      v36 = *(BinningPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevViewProjMatrix.m21;
		      if ( !v36 )
		        sub_1800D8250(0LL, v35);
		      v425.binningBuffer = HG::Rendering::Runtime::BinningPass::get_binningBuffer(v36, 0LL);
		      v425.settingParams = v369->fields._settingParameters_k__BackingField;
		      if ( dword_18F35FD08 )
		      {
		        v38 = (((unsigned __int64)&v425.settingParams >> 12) & 0x1FFFFF) >> 6;
		        v37 = ((unsigned __int64)&v425.settingParams >> 12) & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v38 + 36190]);
		        do
		          v39 = qword_18F0BCBA0[v38 + 36190];
		        while ( v39 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v38 + 36190], v39 | (1LL << v37), v39) );
		      }
		      input = v425;
		      v40 = *(LightClusteringPassConstructor **)&v4[1].fields._._._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m01;
		      if ( !v40 )
		        sub_1800D8250(0LL, v37);
		      HG::Rendering::Runtime::LightClusteringPassConstructor::ConstructPass(
		        v40,
		        &input,
		        &output,
		        renderGraph,
		        *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._ViewProjMatrix.m20,
		        0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v442 )
		    {
		      v368.handle = (ResourceHandle)v442->ex;
		      if ( v368.handle )
		        sub_18007E1E0(*(_QWORD *)&v368.handle);
		      v4 = this;
		      renderGraph = v364;
		    }
		    v41 = 2LL;
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)2u,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		    v368.handle = 0LL;
		    v368.fallBackResource = (ResourceHandle)&v539;
		    try
		    {
		      v404[1] = 0LL;
		      v405 = 0LL;
		      v406[0] = 0LL;
		      v404[0] = (unsigned __int64)renderContext.m_Ptr;
		      v43 = *(BinningPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevViewProjMatrix.m21;
		      if ( !v43 )
		        sub_1800D8250(v42, 0LL);
		      reflectionProbeBinningData = HG::Rendering::Runtime::BinningPass::get_reflectionProbeBinningData(
		                                     (BinningPass_BinningData *)v388,
		                                     v43,
		                                     0LL);
		      *(_OWORD *)((char *)v404 + 8) = *(_OWORD *)&reflectionProbeBinningData->tileSize;
		      *((_QWORD *)&v404[1] + 1) = *(_QWORD *)&reflectionProbeBinningData->xyOffset;
		      LODWORD(v405) = reflectionProbeBinningData->uintCount;
		      v46 = *(BinningPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevViewProjMatrix.m21;
		      if ( !v46 )
		        sub_1800D8250(0LL, v45);
		      *(ComputeBufferHandle *)((char *)&v405 + 4) = HG::Rendering::Runtime::BinningPass::get_binningBuffer(v46, 0LL);
		      v406[0] = settingParameter[0];
		      if ( dword_18F35FD08 )
		      {
		        v48 = (((unsigned __int64)v406 >> 12) & 0x1FFFFF) >> 6;
		        v47 = ((unsigned __int64)v406 >> 12) & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v48 + 36190]);
		        do
		          v49 = qword_18F0BCBA0[v48 + 36190];
		        while ( v49 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v48 + 36190], v49 | (1LL << v47), v49) );
		      }
		      *(_OWORD *)&v428.srpContext.m_Ptr = v404[0];
		      *(_OWORD *)&v428.binningData.tileY = v404[1];
		      *(_OWORD *)&v428.binningData.uintCount = v405;
		      v428.settingParameters = (HGSettingParameters *)v406[0];
		      v362 = 0;
		      v50 = *(ReflectionProbeBinningPassConstructor **)&v4[1].fields._._._.m_basicTransformConstants._PrevViewProjMatrix.m02;
		      if ( !v50 )
		        sub_1800D8250(0LL, v47);
		      HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::ConstructPass(
		        v50,
		        &v428,
		        &v362,
		        renderGraph,
		        *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._ViewProjMatrix.m20,
		        0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v443 )
		    {
		      v368.handle = (ResourceHandle)v443->ex;
		      if ( v368.handle )
		        sub_18007E1E0(*(_QWORD *)&v368.handle);
		      v41 = 2LL;
		      v4 = this;
		      renderGraph = v364;
		    }
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)1u,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		    *(_QWORD *)viewHandle = 0LL;
		    *(_QWORD *)&viewHandle[2] = &v539;
		    try
		    {
		      v52 = *(BinningPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevViewProjMatrix.m21;
		      if ( !v52 )
		        sub_1800D8250(0LL, v51);
		      HG::Rendering::Runtime::BinningPass::ConstructPass(
		        v52,
		        renderGraph,
		        *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._ViewProjMatrix.m20,
		        0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v444 )
		    {
		      *(Il2CppExceptionWrapper *)viewHandle = (Il2CppExceptionWrapper)v444->ex;
		      if ( *(_QWORD *)viewHandle )
		        sub_18007E1E0(*(_QWORD *)viewHandle);
		      v41 = 2LL;
		      v4 = this;
		      renderGraph = v364;
		    }
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)0xAu,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		    *(_QWORD *)viewHandle = 0LL;
		    *(_QWORD *)&viewHandle[2] = &v539;
		    try
		    {
		      v54 = *(BinningPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevViewProjMatrix.m21;
		      if ( !v54 )
		        sub_1800D8250(0LL, v53);
		      v427.sceneColor.handle = HG::Rendering::Runtime::BinningPass::get_binningBuffer(v54, 0LL).handle;
		      sub_18033B9D0(&invViewMatrix, 0LL, 160LL);
		      if ( !hgCamera )
		        sub_1800D8250(v56, v55);
		      invViewMatrix = hgCamera->fields.mainViewConstants.invViewMatrix;
		      ScreenParams = HG::Rendering::Runtime::HGRenderPathBase::get_shaderVariablesGlobal((HGRenderPathBase *)v4, 0LL)[1]._ScreenParams;
		      v410.m_attachments = *(NativeArray_1_HG_Rendering_RenderGraphModule_TextureHandle_ *)&HG::Rendering::Runtime::HGRenderPathBase::get_shaderVariablesGlobal(
		                                                                                              (HGRenderPathBase *)v4,
		                                                                                              0LL)[1]._FrustumPlanes.FixedElementField;
		      v410.m_gbufferMapping = *(NativeArray_1_System_Int32_ *)&HG::Rendering::Runtime::HGRenderPathBase::get_shaderVariablesGlobal(
		                                                                 (HGRenderPathBase *)v4,
		                                                                 0LL)[1]._TaaFrameInfo.z;
		      v411 = *(CullingResults *)&HG::Rendering::Runtime::HGRenderPathBase::get_shaderVariablesGlobal(
		                                   (HGRenderPathBase *)v4,
		                                   0LL)[1]._TaaJitterStrength.z;
		      v412 = *(_OWORD *)&HG::Rendering::Runtime::HGRenderPathBase::get_shaderVariablesGlobal(
		                           (HGRenderPathBase *)v4,
		                           0LL)[1]._Time.z;
		      v413 = *(_OWORD *)&HG::Rendering::Runtime::HGRenderPathBase::get_shaderVariablesGlobal(
		                           (HGRenderPathBase *)v4,
		                           0LL)[1]._SinTime.z;
		      *(_OWORD *)&v427.sceneColor.fallBackResource.m_Value = *(_OWORD *)&invViewMatrix.m00;
		      *(_OWORD *)&v427.sceneDepth.fallBackResource.m_Value = *(_OWORD *)&invViewMatrix.m01;
		      *(_OWORD *)&v427.sceneMV.fallBackResource.m_Value = *(_OWORD *)&invViewMatrix.m02;
		      *(_OWORD *)&v427.sceneColorCopied.fallBackResource.m_Value = *(_OWORD *)&invViewMatrix.m03;
		      *(Vector4 *)&v427.sceneDepthCopied.fallBackResource.m_Value = ScreenParams;
		      *(GBufferOutput *)((char *)&v427.gBufferOutput + 8) = v410;
		      *(CullingResults *)&v427.cullingResults.m_AllocationInfo = v411;
		      *(_OWORD *)&v427.screenCullingRatio = v412;
		      *(_OWORD *)&v427.deferredOpaqueEqualECSList = v413;
		      *(TextureHandle *)&v502.binningBufferHandle.handle.m_Value = v427.sceneColor;
		      *(TextureHandle *)&v502.ivInput.invViewMatrix.m20 = v427.sceneDepth;
		      *(TextureHandle *)&v502.ivInput.invViewMatrix.m21 = v427.sceneMV;
		      *(TextureHandle *)&v502.ivInput.invViewMatrix.m22 = v427.sceneColorCopied;
		      *(TextureHandle *)&v502.ivInput.invViewMatrix.m23 = v427.sceneDepthCopied;
		      *(GBufferOutput *)&v502.ivInput.IVParam0.z = v427.gBufferOutput;
		      *(CullingResults *)&v502.ivInput.IVParam2.z = v427.cullingResults;
		      *(_OWORD *)&v502.ivInput.IVDefaultSHAr.z = *(_OWORD *)&v427.bakedLightConfig;
		      *(_OWORD *)&v502.ivInput.IVDefaultSHAg.z = *(_OWORD *)&v427.screenCullingLayerMask;
		      *(_QWORD *)&v502.ivInput.IVDefaultSHAb.z = *((_QWORD *)&v413 + 1);
		      v362 = 0;
		      v58 = *(ParticleLightingPassConstructor **)&v4[1].fields._._._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m20;
		      if ( !v58 )
		        sub_1800D8250(0LL, v57);
		      HG::Rendering::Runtime::ParticleLightingPassConstructor::ConstructPass(
		        v58,
		        &v502,
		        (ParticleLightingPassConstructor_PassOutput *)&v362,
		        renderGraph,
		        *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._ViewProjMatrix.m20,
		        0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v445 )
		    {
		      *(Il2CppExceptionWrapper *)viewHandle = (Il2CppExceptionWrapper)v445->ex;
		      if ( *(_QWORD *)viewHandle )
		        sub_18007E1E0(*(_QWORD *)viewHandle);
		      v41 = 2LL;
		      v4 = this;
		      renderGraph = v364;
		    }
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)3u,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGRenderPathScene::OtherPassScope>);
		    *(_QWORD *)viewHandle = 0LL;
		    *(_QWORD *)&viewHandle[2] = &v539;
		    try
		    {
		      v60 = *(WaterSectorRenderingPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m20;
		      if ( !v60 )
		        sub_1800D8250(0LL, v59);
		      HG::Rendering::Runtime::WaterSectorRenderingPass::Render(
		        v60,
		        renderGraph,
		        *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._ViewProjMatrix.m20,
		        settingParameter[0],
		        0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v446 )
		    {
		      *(Il2CppExceptionWrapper *)viewHandle = (Il2CppExceptionWrapper)v446->ex;
		      if ( *(_QWORD *)viewHandle )
		        sub_18007E1E0(*(_QWORD *)viewHandle);
		      v41 = 2LL;
		      v4 = this;
		      renderGraph = v364;
		    }
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)4u,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGRenderPathScene::OtherPassScope>);
		    *(_QWORD *)viewHandle = 0LL;
		    *(_QWORD *)&viewHandle[2] = &v539;
		    try
		    {
		      v62 = *(WaterInteractionRenderingPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m01;
		      if ( !v62 )
		        sub_1800D8250(0LL, v61);
		      HG::Rendering::Runtime::WaterInteractionRenderingPass::Render(
		        v62,
		        renderGraph,
		        renderContext,
		        settingParameter[0],
		        deltaTime,
		        hgCamera,
		        0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v447 )
		    {
		      *(Il2CppExceptionWrapper *)viewHandle = (Il2CppExceptionWrapper)v447->ex;
		      if ( *(_QWORD *)viewHandle )
		        sub_18007E1E0(*(_QWORD *)viewHandle);
		      v41 = 2LL;
		      v4 = this;
		      renderGraph = v364;
		    }
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)3u,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		    *(_QWORD *)viewHandle = 0LL;
		    *(_QWORD *)&viewHandle[2] = &v539;
		    try
		    {
		      v372 = 0;
		      v371 = 0;
		      v64 = *(FoliageOccluderPassConstructor **)&v4[1].fields._._._.m_basicTransformConstants._PrevViewProjMatrix.m22;
		      if ( !v64 )
		        sub_1800D8250(0LL, v63);
		      HG::Rendering::Runtime::FoliageOccluderPassConstructor::ConstructPass(
		        v64,
		        &v372,
		        &v371,
		        renderGraph,
		        *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._ViewProjMatrix.m20,
		        0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v448 )
		    {
		      *(Il2CppExceptionWrapper *)viewHandle = (Il2CppExceptionWrapper)v448->ex;
		      if ( *(_QWORD *)viewHandle )
		        sub_18007E1E0(*(_QWORD *)viewHandle);
		      v41 = 2LL;
		      v4 = this;
		      renderGraph = v364;
		    }
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)4u,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		    v368.handle = 0LL;
		    v368.fallBackResource = (ResourceHandle)&v539;
		    try
		    {
		      v66 = settingParameter[0];
		      v394[0] = settingParameter[0];
		      if ( dword_18F35FD08 )
		      {
		        v67 = (((unsigned __int64)v394 >> 12) & 0x1FFFFF) >> 6;
		        v65 = ((unsigned __int64)v394 >> 12) & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v67 + 36190]);
		        do
		          v68 = qword_18F0BCBA0[v67 + 36190];
		        while ( v68 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v67 + 36190], v68 | (1LL << v65), v68) );
		        v66 = (HGSettingParameters *)v394[0];
		      }
		      v402.settingParams = v66;
		      v362 = 0;
		      v69 = *(FoliageInteractivePassConstructor **)&v4[1].fields._._._.m_basicTransformConstants._PrevViewProjMatrix.m03;
		      if ( !v69 )
		        sub_1800D8250(0LL, v65);
		      HG::Rendering::Runtime::FoliageInteractivePassConstructor::ConstructPass(
		        v69,
		        &v402,
		        (FoliageInteractivePassConstructor_PassOutput *)&v362,
		        renderGraph,
		        *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._ViewProjMatrix.m20,
		        0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v449 )
		    {
		      v368.handle = (ResourceHandle)v449->ex;
		      if ( v368.handle )
		        sub_18007E1E0(*(_QWORD *)&v368.handle);
		      v41 = 2LL;
		      v4 = this;
		      renderGraph = v364;
		    }
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)5u,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		    v368.handle = 0LL;
		    v368.fallBackResource = (ResourceHandle)&v539;
		    try
		    {
		      viewHandle[0] = renderPathParams->perFrameSetup.depthBits;
		      viewHandle[1] = renderPathParams->perFrameSetup.depthGraphicsFormat;
		      v397 = *(SludgePassConstructor_PassInput *)viewHandle;
		      v373 = 0;
		      v71 = *(SludgePassConstructor **)&v4[1].fields._._._.m_basicTransformConstants._PrevViewProjMatrix.m23;
		      if ( !v71 )
		        sub_1800D8250(0LL, v70);
		      HG::Rendering::Runtime::SludgePassConstructor::ConstructPass(
		        v71,
		        &v397,
		        &v373,
		        renderGraph,
		        *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._ViewProjMatrix.m20,
		        0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v450 )
		    {
		      v368.handle = (ResourceHandle)v450->ex;
		      if ( v368.handle )
		        sub_18007E1E0(*(_QWORD *)&v368.handle);
		      v41 = 2LL;
		      v4 = this;
		      renderGraph = v364;
		    }
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)6u,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		    *(_QWORD *)viewHandle = 0LL;
		    *(_QWORD *)&viewHandle[2] = &v539;
		    try
		    {
		      v361 = 0;
		      v362 = 0;
		      v73 = *(GpuClothSimulationPassConstructor **)&v4[1].fields._._._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m00;
		      if ( !v73 )
		        sub_1800D8250(0LL, v72);
		      HG::Rendering::Runtime::GpuClothSimulationPassConstructor::ConstructPass(
		        v73,
		        &v361,
		        (GpuClothSimulationPassConstructor_PassOutput *)&v362,
		        renderGraph,
		        *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._ViewProjMatrix.m20,
		        0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v451 )
		    {
		      *(Il2CppExceptionWrapper *)viewHandle = (Il2CppExceptionWrapper)v451->ex;
		      if ( *(_QWORD *)viewHandle )
		        sub_18007E1E0(*(_QWORD *)viewHandle);
		      v41 = 2LL;
		      v4 = this;
		      renderGraph = v364;
		    }
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)0xBu,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		    v368.handle = 0LL;
		    v368.fallBackResource = (ResourceHandle)&v539;
		    try
		    {
		      v407.srpContext = renderContext;
		      v407.customDepthOnlyRequestManger = *(CustomDepthOnlyRequestManager **)&v4[1].fields._._._.m_basicTransformConstants.current._InvPretransformMatrix.m00;
		      if ( dword_18F35FD08 )
		      {
		        v75 = (((unsigned __int64)&v407.customDepthOnlyRequestManger >> 12) & 0x1FFFFF) >> 6;
		        v74 = ((unsigned __int64)&v407.customDepthOnlyRequestManger >> 12) & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v75 + 36190]);
		        do
		          v76 = qword_18F0BCBA0[v75 + 36190];
		        while ( v76 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v75 + 36190], v76 | (1LL << v74), v76) );
		      }
		      v421 = v407;
		      v374 = 0;
		      v77 = *(DepthOnlyPassConstructor **)&v4[1].fields._._._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m02;
		      if ( !v77 )
		        sub_1800D8250(0LL, v74);
		      HG::Rendering::Runtime::DepthOnlyPassConstructor::ConstructPass(
		        v77,
		        &v421,
		        &v374,
		        renderGraph,
		        *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._ViewProjMatrix.m20,
		        0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v452 )
		    {
		      v368.handle = (ResourceHandle)v452->ex;
		      if ( v368.handle )
		        sub_18007E1E0(*(_QWORD *)&v368.handle);
		      v41 = 2LL;
		      v4 = this;
		      renderGraph = v364;
		    }
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)0xCu,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		    v368.handle = 0LL;
		    v368.fallBackResource = (ResourceHandle)&v539;
		    try
		    {
		      sub_18033B9D0(&v419, 0LL, 80LL);
		      v419.cullingResults = cullingResults;
		      v419.lightCullResult = lightCullResult;
		      v419.srpContext = renderContext;
		      v80 = *(_QWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._ViewProjMatrix.m20;
		      if ( !v80 )
		        sub_1800D8250(v79, v78);
		      v419.shadowManager = *(HGShadowManager **)(v80 + 1848);
		      v81 = dword_18F35FD08;
		      if ( dword_18F35FD08 )
		      {
		        v82 = (((unsigned __int64)&v419 >> 12) & 0x1FFFFF) >> 6;
		        v78 = ((unsigned __int64)&v419 >> 12) & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v82 + 36190]);
		        do
		          v83 = qword_18F0BCBA0[v82 + 36190];
		        while ( v83 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v82 + 36190], v83 | (1LL << v78), v83) );
		        v81 = dword_18F35FD08;
		      }
		      *(_QWORD *)&v419.directionalLightIndex = __PAIR64__(v512, v513);
		      v419.punctualLightIndices = &output.punctualLightIndices.FixedElementField;
		      v419.settingParams = settingParameter[0];
		      if ( v81 )
		      {
		        v84 = (((unsigned __int64)&v419.settingParams >> 12) & 0x1FFFFF) >> 6;
		        v78 = ((unsigned __int64)&v419.settingParams >> 12) & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v84 + 36190]);
		        do
		          v85 = qword_18F0BCBA0[v84 + 36190];
		        while ( v85 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v84 + 36190], v85 | (1LL << v78), v85) );
		      }
		      v419.settingParamsCpp = renderPathParams->perFrameSetup.settingParametersCpp;
		      v487 = v419;
		      memset(&v415, 0, sizeof(v415));
		      v86 = *(ShadowMapPassConstructor **)&v4[1].fields._._._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m22;
		      if ( !v86 )
		        sub_1800D8250(0LL, v78);
		      HG::Rendering::Runtime::ShadowMapPassConstructor::ConstructPass(
		        v86,
		        &v487,
		        &v415,
		        renderGraph,
		        *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._ViewProjMatrix.m20,
		        0LL);
		      *(ShadowMapPassConstructor_PassOutput *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewNoTransProjMatrix.m00 = v415;
		    }
		    catch ( Il2CppExceptionWrapper *v453 )
		    {
		      v368.handle = (ResourceHandle)v453->ex;
		      if ( v368.handle )
		        sub_18007E1E0(*(_QWORD *)&v368.handle);
		      v41 = 2LL;
		      v4 = this;
		      renderGraph = v364;
		    }
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)0xDu,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		    v368.handle = 0LL;
		    v368.fallBackResource = (ResourceHandle)&v539;
		    try
		    {
		      v391 = 0LL;
		      settingParameters_k__BackingField = v369->fields._settingParameters_k__BackingField;
		      if ( !settingParameters_k__BackingField )
		        sub_1800D8250(v88, v87);
		      atmosphereParams_k__BackingField = settingParameters_k__BackingField->fields._atmosphereParams_k__BackingField;
		      v391 = atmosphereParams_k__BackingField;
		      if ( dword_18F35FD08 )
		      {
		        v91 = (((unsigned __int64)&v391 >> 12) & 0x1FFFFF) >> 6;
		        v87 = ((unsigned __int64)&v391 >> 12) & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v91 + 36190]);
		        do
		          v92 = qword_18F0BCBA0[v91 + 36190];
		        while ( v92 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v91 + 36190], v92 | (1LL << v87), v92) );
		        atmosphereParams_k__BackingField = v391;
		      }
		      v398.atmosphereParams = atmosphereParams_k__BackingField;
		      v361 = 0;
		      v93 = *(SkyAtmospherePassConstructor **)&v4[1].fields._._._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m03;
		      if ( !v93 )
		        sub_1800D8250(0LL, v87);
		      HG::Rendering::Runtime::SkyAtmospherePassConstructor::ConstructPass(
		        v93,
		        &v398,
		        (SkyAtmospherePassConstructor_PassOutput *)&v361,
		        renderGraph,
		        *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._ViewProjMatrix.m20,
		        0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v455 )
		    {
		      v368.handle = (ResourceHandle)v455->ex;
		      if ( v368.handle )
		        sub_18007E1E0(*(_QWORD *)&v368.handle);
		      v41 = 2LL;
		      v4 = this;
		      renderGraph = v364;
		    }
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)0xEu,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		    *(_QWORD *)viewHandle = 0LL;
		    *(_QWORD *)&viewHandle[2] = &v539;
		    try
		    {
		      *(_OWORD *)v388 = *(_OWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewNoTransProjMatrix.m00;
		      *(_OWORD *)&v388[16] = *(_OWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewNoTransProjMatrix.m01;
		      *(_OWORD *)&v388[32] = *(_OWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewNoTransProjMatrix.m02;
		      *(_QWORD *)&v388[48] = *(_QWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewNoTransProjMatrix.m03;
		      *(float *)&v388[56] = v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewNoTransProjMatrix.m23;
		      v361 = 0;
		      v95 = *(VolumetricFogPassConstructor **)&v4[1].fields._._._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m23;
		      if ( !v95 )
		        sub_1800D8250(0LL, v94);
		      HG::Rendering::Runtime::VolumetricFogPassConstructor::ConstructPass(
		        v95,
		        (VolumetricFogPassConstructor_PassInput *)v388,
		        (VolumetricFogPassConstructor_PassOutput *)&v361,
		        renderGraph,
		        *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._ViewProjMatrix.m20,
		        0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v456 )
		    {
		      *(Il2CppExceptionWrapper *)viewHandle = (Il2CppExceptionWrapper)v456->ex;
		      if ( *(_QWORD *)viewHandle )
		        sub_18007E1E0(*(_QWORD *)viewHandle);
		      v41 = 2LL;
		      v4 = this;
		      renderGraph = v364;
		    }
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)0xFu,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		    v368.handle = 0LL;
		    v368.fallBackResource = (ResourceHandle)&v539;
		    try
		    {
		      v392 = 0LL;
		      v98 = v369->fields._settingParameters_k__BackingField;
		      if ( !v98 )
		        sub_1800D8250(v97, v96);
		      v99 = v98->fields._atmosphereParams_k__BackingField;
		      v392 = v99;
		      if ( dword_18F35FD08 )
		      {
		        v100 = (((unsigned __int64)&v392 >> 12) & 0x1FFFFF) >> 6;
		        v96 = ((unsigned __int64)&v392 >> 12) & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v100 + 36190]);
		        do
		          v101 = qword_18F0BCBA0[v100 + 36190];
		        while ( v101 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v100 + 36190], v101 | (1LL << v96), v101) );
		        v99 = v392;
		      }
		      v399.atmosphereParams = v99;
		      v361 = 0;
		      v102 = *(BakeFogLutPassConstructor **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m00;
		      if ( !v102 )
		        sub_1800D8250(0LL, v96);
		      HG::Rendering::Runtime::BakeFogLutPassConstructor::ConstructPass(
		        v102,
		        &v399,
		        (BakeFogLutPassConstructor_PassOutput *)&v361,
		        renderGraph,
		        *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._ViewProjMatrix.m20,
		        0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v457 )
		    {
		      v368.handle = (ResourceHandle)v457->ex;
		      if ( v368.handle )
		        sub_18007E1E0(*(_QWORD *)&v368.handle);
		      v41 = 2LL;
		      v4 = this;
		      renderGraph = v364;
		    }
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)0x11u,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		    v368.handle = 0LL;
		    v368.fallBackResource = (ResourceHandle)&v539;
		    try
		    {
		      *(_QWORD *)&v401[9] = 0LL;
		      *(_DWORD *)&v401[17] = 0;
		      *(_WORD *)&v401[21] = 0;
		      v401[23] = 0;
		      v105 = cullingResults;
		      v400 = cullingResults;
		      *(ScriptableRenderContext *)v401 = renderContext;
		      v106 = v528;
		      v401[8] = v528;
		      v107 = renderPathParams->hgrp;
		      if ( !v107 )
		        sub_1800D8250(v104, v103);
		      *(_QWORD *)&v401[16] = v107->fields.drawInteractionNodeMaterial;
		      if ( dword_18F35FD08 )
		      {
		        v108 = (((unsigned __int64)&v401[16] >> 12) & 0x1FFFFF) >> 6;
		        v103 = ((unsigned __int64)&v401[16] >> 12) & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v108 + 36190]);
		        do
		          v109 = qword_18F0BCBA0[v108 + 36190];
		        while ( v109 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v108 + 36190], v109 | (1LL << v103), v109) );
		        v105 = v400;
		      }
		      v423.cullingResults = v105;
		      *(_OWORD *)&v423.renderContext.m_Ptr = *(_OWORD *)v401;
		      v423.drawInteractionNodeMaterial = *(Material **)&v401[16];
		      v375 = 0;
		      v110 = *(TerrainDeformPassConstructor **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m20;
		      if ( !v110 )
		        sub_1800D8250(0LL, v103);
		      HG::Rendering::Runtime::TerrainDeformPassConstructor::ConstructPass(
		        v110,
		        &v423,
		        &v375,
		        renderGraph,
		        *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._ViewProjMatrix.m20,
		        0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v458 )
		    {
		      v111 = (BuildHZBPass *)&v359;
		      v368.handle = (ResourceHandle)v458->ex;
		      if ( v368.handle )
		        sub_18007E1E0(*(_QWORD *)&v368.handle);
		      v41 = 2LL;
		      v4 = this;
		      renderGraph = v364;
		      v106 = v528;
		    }
		    v112 = *(InkSimulationPassConstructor **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m21;
		    if ( v112 )
		    {
		      HG::Rendering::Runtime::InkSimulationPassConstructor::ConstructPass(v112, renderGraph, 0LL);
		      v396 = 0LL;
		      UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		        (Int32Enum__Enum)0x14u,
		        MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		      *(_QWORD *)viewHandle = 0LL;
		      *(_QWORD *)&viewHandle[2] = &v539;
		      try
		      {
		        *(_QWORD *)v388 = 0LL;
		        *(_QWORD *)&v388[8] = 0LL;
		        v388[39] = 0;
		        v113 = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m23;
		        v114 = cullingResults;
		        *(_DWORD *)&v388[32] = HG::Rendering::Runtime::HGRenderPipeline::get_bakedLightingConfig(v369, 0LL);
		        v388[36] = v106;
		        *(_WORD *)&v388[37] = v529;
		        *(_QWORD *)&v388[40] = v530;
		        *(_DWORD *)&v388[48] = v531;
		        *(_DWORD *)&v388[52] = v532;
		        if ( v533 )
		        {
		          v116 = *(BuildHZBPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m02;
		          if ( !v116 )
		            sub_1800D8250(v115, 0LL);
		          prevHZBTexture = HG::Rendering::Runtime::BuildHZBPass::get_prevHZBTexture(&v381.depthTexture, v116, 0LL);
		        }
		        else
		        {
		          sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		          prevHZBTexture = HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v381.depthTexture, 0LL);
		        }
		        *(TextureHandle *)&v388[56] = *prevHZBTexture;
		        v426.sceneDepth = v113;
		        v426.cullingResults = v114;
		        *(_OWORD *)&v426.bakedLightingConfig = *(_OWORD *)&v388[32];
		        *(_OWORD *)&v426.terrainGpuSubd = *(_OWORD *)&v388[48];
		        v426.HZBTexture.fallBackResource = (ResourceHandle)*(_OWORD *)&_mm_unpackhi_pd(
		                                                                         *(__m128d *)&v388[56],
		                                                                         *(__m128d *)&v388[56]);
		        v119 = *(TerrainDepthPrepassConstructor **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m02;
		        if ( !v119 )
		          sub_1800D8250(0LL, v118);
		        HG::Rendering::Runtime::TerrainDepthPrepassConstructor::ConstructPass(
		          v119,
		          &v426,
		          &v396,
		          renderGraph,
		          *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._ViewProjMatrix.m20,
		          0LL);
		      }
		      catch ( Il2CppExceptionWrapper *v459 )
		      {
		        *(Il2CppExceptionWrapper *)viewHandle = (Il2CppExceptionWrapper)v459->ex;
		        v112 = *(InkSimulationPassConstructor **)viewHandle;
		        if ( *(_QWORD *)viewHandle )
		          sub_18007E1E0(*(_QWORD *)viewHandle);
		        v41 = 2LL;
		        v4 = this;
		        renderGraph = v364;
		      }
		      if ( LOBYTE(v4[1].fields._._._.m_basicTransformConstants._PrevViewProjMatrix.m01) )
		      {
		        defaultResources = HG::Rendering::Runtime::HGRenderPipeline::get_defaultResources(v369, 0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		        *(_QWORD *)viewHandle = HG::Rendering::Runtime::HGUtils::SelectGPUDrivenCullingShader(defaultResources, 0LL);
		      }
		      else
		      {
		        *(_QWORD *)viewHandle = 0LL;
		      }
		      if ( LOBYTE(v4[1].fields._._._.m_basicTransformConstants._PrevViewProjMatrix.m01) )
		      {
		        v111 = *(BuildHZBPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m02;
		        if ( !v111 )
		          goto LABEL_553;
		        v368 = *HG::Rendering::Runtime::BuildHZBPass::get_prevHZBTexture(&v381.depthTexture, v111, 0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		        v362 = (ReflectionProbeBinningPassConstructor_PassOutput)!HG::Rendering::RenderGraphModule::TextureHandle::IsValid(
		                                                                    &v368,
		                                                                    0LL);
		      }
		      else
		      {
		        v362 = 0;
		      }
		      if ( LOBYTE(v4[1].fields._._._.m_basicTransformConstants._PrevViewProjMatrix.m01) )
		      {
		        UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		          (Int32Enum__Enum)8u,
		          MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		        v370.depthTexture.handle = 0LL;
		        v370.depthTexture.fallBackResource = (ResourceHandle)&v539;
		        try
		        {
		          memset(&v393, 0, sizeof(v393));
		          v121 = HG::Rendering::Runtime::HGRenderPipeline::get_defaultResources(v369, 0LL);
		          if ( !v121 )
		            sub_1800D8250(v123, v122);
		          shaders = v121->fields.shaders;
		          if ( !shaders )
		            sub_1800D8250(v123, v122);
		          v393.initShader = shaders->fields.GPUDrivenInitCS;
		          v125 = (unsigned int)dword_18F35FD08;
		          if ( dword_18F35FD08 )
		          {
		            v126 = (((unsigned __int64)&v393 >> 12) & 0x1FFFFF) >> 6;
		            _m_prefetchw(&qword_18F0BCBA0[v126 + 36190]);
		            do
		              v127 = qword_18F0BCBA0[v126 + 36190];
		            while ( v127 != _InterlockedCompareExchange64(
		                              &qword_18F0BCBA0[v126 + 36190],
		                              v127 | (1LL << (((unsigned __int64)&v393 >> 12) & 0x3F)),
		                              v127) );
		            v125 = (unsigned int)dword_18F35FD08;
		          }
		          v393.cullingShader = *(ComputeShader **)viewHandle;
		          if ( (_DWORD)v125 )
		          {
		            v128 = (((unsigned __int64)&v393.cullingShader >> 12) & 0x1FFFFF) >> 6;
		            _m_prefetchw(&qword_18F0BCBA0[v128 + 36190]);
		            do
		            {
		              v125 = qword_18F0BCBA0[v128 + 36190] | (1LL << (((unsigned __int64)&v393.cullingShader >> 12) & 0x3F));
		              v129 = qword_18F0BCBA0[v128 + 36190];
		            }
		            while ( v129 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v128 + 36190], v125, v129) );
		          }
		          v130 = *(BuildHZBPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m02;
		          if ( !v130 )
		            sub_1800D8250(v125, 0LL);
		          v393.hzb = *HG::Rendering::Runtime::BuildHZBPass::get_prevHZBTexture(&v381.depthTexture, v130, 0LL);
		          v393.usePrevVP = BYTE1(v4[1].fields._._._.m_basicTransformConstants._PrevViewProjMatrix.m01) == 0;
		          v393.disableHZBCulling = (bool)v362;
		          v433 = v393;
		          v361 = 0;
		          v132 = *(GPUDrivenCullingPassConstructor **)&v4[1].fields._._._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m21;
		          if ( !v132 )
		            sub_1800D8250(0LL, v131);
		          HG::Rendering::Runtime::GPUDrivenCullingPassConstructor::ConstructPass(
		            v132,
		            &v433,
		            (GPUDrivenCullingPassConstructor_PassOutput *)&v361,
		            renderGraph,
		            *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._ViewProjMatrix.m20,
		            0LL);
		        }
		        catch ( Il2CppExceptionWrapper *v460 )
		        {
		          v370.depthTexture.handle = (ResourceHandle)v460->ex;
		          if ( v370.depthTexture.handle )
		            sub_18007E1E0(*(_QWORD *)&v370.depthTexture.handle);
		          v41 = 2LL;
		          v4 = this;
		          renderGraph = v364;
		        }
		      }
		      UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		        (Int32Enum__Enum)0x15u,
		        MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		      v370.depthTexture.handle = 0LL;
		      v370.depthTexture.fallBackResource = (ResourceHandle)&v539;
		      try
		      {
		        sub_18033B9D0(&v418, 0LL, 96LL);
		        v418.sceneDepth = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m23;
		        gbufferOutput = *(GBufferOutput *)&v4[1].fields._._._.m_basicTransformConstants.current._InvNonJitteredViewProjMatrix.m21;
		        v418.gBufferDepth = *HG::Rendering::Runtime::GBufferOutput::GetGBufferAttachment(
		                               &v381.depthTexture,
		                               &gbufferOutput,
		                               GBufferID__Enum_GBufferDepth,
		                               0LL);
		        v418.hgrp = v369;
		        if ( dword_18F35FD08 )
		        {
		          v135 = (((unsigned __int64)&v418.hgrp >> 12) & 0x1FFFFF) >> 6;
		          v133 = ((unsigned __int64)&v418.hgrp >> 12) & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v135 + 36190]);
		          do
		          {
		            v134 = qword_18F0BCBA0[v135 + 36190] | (1LL << v133);
		            v136 = qword_18F0BCBA0[v135 + 36190];
		          }
		          while ( v136 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v135 + 36190], v134, v136) );
		        }
		        v418.cullingResults = cullingResults;
		        LOBYTE(v134) = v369->fields.characterDepthOnlyEnable;
		        v418.characterDepthOnlyEnable = v134;
		        if ( !hgCamera )
		          sub_1800D8250(v134, v133);
		        v418.screenCullingRatio = hgCamera->fields.screenCullingRatio;
		        v418.screenCullingRatioDistance = hgCamera->fields.screenRatioCullingDistance;
		        v418.screenCullingLayerMask = HG::Rendering::Runtime::HGCamera::get_screenCullingLayerMask(hgCamera, 0LL);
		        v138 = *(BuildHZBPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m02;
		        if ( !v138 )
		          sub_1800D8250(v137, 0LL);
		        v368 = *HG::Rendering::Runtime::BuildHZBPass::get_prevHZBTexture(&v381.depthTexture, v138, 0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		        RendererList = -1;
		        if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&v368, 0LL) )
		          m10_low = LODWORD(v4[1].fields._._._.m_basicTransformConstants._PrevViewProjMatrix.m10);
		        else
		          m10_low = -1;
		        v418.deferredOpaquePreZGPUDrivenList = m10_low;
		        v142 = *(BuildHZBPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m02;
		        if ( !v142 )
		          sub_1800D8250(v139, 0LL);
		        v368 = *HG::Rendering::Runtime::BuildHZBPass::get_prevHZBTexture(&v381.depthTexture, v142, 0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		        if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&v368, 0LL) )
		          m20_low = LODWORD(v4[1].fields._._._.m_basicTransformConstants._PrevViewProjMatrix.m20);
		        else
		          m20_low = -1;
		        v418.deferredOpaqueGPUDrivenList = m20_low;
		        *(_QWORD *)&v418.deferredOpaquePreZECSList = *(_QWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._InvPretransformMatrix.m20;
		        *(_QWORD *)&v418.deferredGrassPreZECSList = *(_QWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._InvPretransformMatrix.m11;
		        v498 = v418;
		        v361 = 0;
		        v145 = *(DepthPrepassConstructor **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m22;
		        if ( !v145 )
		          sub_1800D8250(0LL, v143);
		        HG::Rendering::Runtime::DepthPrepassConstructor::ConstructPass(
		          v145,
		          &v498,
		          (DepthPrepassConstructor_PassOutput *)&v361,
		          renderGraph,
		          *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._ViewProjMatrix.m20,
		          0LL);
		      }
		      catch ( Il2CppExceptionWrapper *v461 )
		      {
		        v370.depthTexture.handle = (ResourceHandle)v461->ex;
		        if ( v370.depthTexture.handle )
		          sub_18007E1E0(*(_QWORD *)&v370.depthTexture.handle);
		        v41 = 2LL;
		        RendererList = -1;
		        v4 = this;
		        renderGraph = v364;
		      }
		      if ( LOBYTE(v4[1].fields._._._.m_basicTransformConstants._PrevViewProjMatrix.m01)
		        && !BYTE1(v4[1].fields._._._.m_basicTransformConstants._PrevViewProjMatrix.m01) )
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		        v368 = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v381.depthTexture, 0LL);
		        UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		          (Int32Enum__Enum)0x1Eu,
		          MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		        v370.depthTexture.handle = 0LL;
		        v370.depthTexture.fallBackResource = (ResourceHandle)&v539;
		        try
		        {
		          memset(v388, 0, 20);
		          v147 = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m23;
		          v388[16] = 1;
		          v381.depthTexture = v147;
		          *(_DWORD *)&v381.buildHZB = 1;
		          v382.depthTexture = 0LL;
		          v148 = *(BuildHZBPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m02;
		          if ( !v148 )
		            sub_1800D8250(0LL, v146);
		          HG::Rendering::Runtime::BuildHZBPass::ConstructPass(
		            v148,
		            &v381,
		            (BuildHZBPass_PassOutput *)&v382,
		            renderGraph,
		            *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._ViewProjMatrix.m20,
		            0LL);
		          depthTexture = v382.depthTexture;
		          v368 = v382.depthTexture;
		        }
		        catch ( Il2CppExceptionWrapper *v462 )
		        {
		          v370.depthTexture.handle = (ResourceHandle)v462->ex;
		          if ( v370.depthTexture.handle )
		            sub_18007E1E0(*(_QWORD *)&v370.depthTexture.handle);
		          v41 = 2LL;
		          RendererList = -1;
		          v4 = this;
		          renderGraph = v364;
		          depthTexture = v368;
		        }
		        UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		          (Int32Enum__Enum)8u,
		          MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		        v370.depthTexture.handle = 0LL;
		        v370.depthTexture.fallBackResource = (ResourceHandle)&v539;
		        try
		        {
		          memset(&v393, 0, sizeof(v393));
		          v150 = HG::Rendering::Runtime::HGRenderPipeline::get_defaultResources(v369, 0LL);
		          if ( !v150 )
		            sub_1800D8250(v152, v151);
		          v153 = v150->fields.shaders;
		          if ( !v153 )
		            sub_1800D8250(v152, v151);
		          v393.initShader = v153->fields.GPUDrivenInitCS;
		          v154 = dword_18F35FD08;
		          if ( dword_18F35FD08 )
		          {
		            v155 = (((unsigned __int64)&v393 >> 12) & 0x1FFFFF) >> 6;
		            v151 = ((unsigned __int64)&v393 >> 12) & 0x3F;
		            _m_prefetchw(&qword_18F0BCBA0[v155 + 36190]);
		            do
		              v156 = qword_18F0BCBA0[v155 + 36190];
		            while ( v156 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v155 + 36190], v156 | (1LL << v151), v156) );
		            v154 = dword_18F35FD08;
		          }
		          v393.cullingShader = *(ComputeShader **)viewHandle;
		          if ( v154 )
		          {
		            v157 = (((unsigned __int64)&v393.cullingShader >> 12) & 0x1FFFFF) >> 6;
		            v151 = ((unsigned __int64)&v393.cullingShader >> 12) & 0x3F;
		            _m_prefetchw(&qword_18F0BCBA0[v157 + 36190]);
		            do
		              v158 = qword_18F0BCBA0[v157 + 36190];
		            while ( v158 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v157 + 36190], v158 | (1LL << v151), v158) );
		          }
		          v393.hzb = depthTexture;
		          v393.usePrevVP = 0;
		          v393.disableHZBCulling = (bool)v362;
		          v434 = v393;
		          v361 = 0;
		          v159 = *(GPUDrivenCullingPassConstructor **)&v4[1].fields._._._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m21;
		          if ( !v159 )
		            sub_1800D8250(0LL, v151);
		          HG::Rendering::Runtime::GPUDrivenCullingPassConstructor::ConstructPass(
		            v159,
		            &v434,
		            (GPUDrivenCullingPassConstructor_PassOutput *)&v361,
		            renderGraph,
		            *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._ViewProjMatrix.m20,
		            0LL);
		        }
		        catch ( Il2CppExceptionWrapper *v463 )
		        {
		          v370.depthTexture.handle = (ResourceHandle)v463->ex;
		          if ( v370.depthTexture.handle )
		            sub_18007E1E0(*(_QWORD *)&v370.depthTexture.handle);
		          v41 = 2LL;
		          RendererList = -1;
		          v4 = this;
		          renderGraph = v364;
		        }
		      }
		      UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		        (Int32Enum__Enum)0x18u,
		        MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		      v370.depthTexture.handle = 0LL;
		      v370.depthTexture.fallBackResource = (ResourceHandle)&v539;
		      try
		      {
		        sub_18033B9D0(&v427, 0LL, 184LL);
		        v427.sceneColor = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m22;
		        v427.sceneDepth = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m23;
		        v427.sceneMV = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewProjMatrix.m20;
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		        v427.sceneDepthCopied = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(
		                                   &v381.depthTexture,
		                                   0LL);
		        v427.gBufferOutput = *(GBufferOutput *)&v4[1].fields._._._.m_basicTransformConstants.current._InvNonJitteredViewProjMatrix.m21;
		        v427.cullingResults = cullingResults;
		        v427.bakedLightConfig = HG::Rendering::Runtime::HGRenderPipeline::get_bakedLightingConfig(v369, 0LL);
		        v427.enableTerrainTessellation = renderPathParams->renderRequest.enableTerrainTessellation;
		        currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		        if ( !currentManagerContext )
		          sub_1800D8250(v162, v161);
		        waterManager_k__BackingField = currentManagerContext->fields._waterManager_k__BackingField;
		        if ( !waterManager_k__BackingField )
		          sub_1800D8250(0LL, v161);
		        v427.enableTerrainWetRipple = HG::Rendering::Runtime::HGWaterManager::GetTerrainRippleOpacity(
		                                        waterManager_k__BackingField,
		                                        0LL) > 0.0;
		        v427.enableTerrainPOM = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                                  settingParameter[0]->fields._terrainPOM_k__BackingField,
		                                  MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		        if ( !hgCamera )
		          sub_1800D8250(v165, v164);
		        v427.screenCullingRatio = hgCamera->fields.screenCullingRatio;
		        v427.screenCullingRatioDistance = hgCamera->fields.screenRatioCullingDistance;
		        v427.screenCullingLayerMask = HG::Rendering::Runtime::HGCamera::get_screenCullingLayerMask(hgCamera, 0LL);
		        v427.deferredOpaqueECSList = LODWORD(v4[1].fields._._._.m_basicTransformConstants.current._InvPretransformMatrix.m02);
		        v427.deferredOpaqueEqualECSList = LODWORD(v4[1].fields._._._.m_basicTransformConstants.current._InvPretransformMatrix.m12);
		        v427.deferredGrassECSList = LODWORD(v4[1].fields._._._.m_basicTransformConstants.current._InvPretransformMatrix.m22);
		        v427.deferredTreeECSList = LODWORD(v4[1].fields._._._.m_basicTransformConstants.current._InvPretransformMatrix.m32);
		        v427.deferredSludgeECSList = LODWORD(v4[1].fields._._._.m_basicTransformConstants.current._InvPretransformMatrix.m03);
		        v427.characterPrePassECSList = LODWORD(v4[1].fields._._._.m_basicTransformConstants.current._InvPretransformMatrix.m31);
		        v427.characterOutlinePrePassECSList = LODWORD(v4[1].fields._._._.m_basicTransformConstants.current._InvPretransformMatrix.m01);
		        *(_QWORD *)&v427.deferredOpaqueGPUDrivenList = *(_QWORD *)&v4[1].fields._._._.m_basicTransformConstants._PrevViewProjMatrix.m20;
		        v503 = v427;
		        v376 = 0;
		        v167 = *(GBufferPassConstructor **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m03;
		        if ( !v167 )
		          sub_1800D8250(0LL, v166);
		        HG::Rendering::Runtime::GBufferPassConstructor::ConstructPass(
		          v167,
		          &v503,
		          &v376,
		          renderGraph,
		          *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._ViewProjMatrix.m20,
		          0LL);
		      }
		      catch ( Il2CppExceptionWrapper *v464 )
		      {
		        v370.depthTexture.handle = (ResourceHandle)v464->ex;
		        if ( v370.depthTexture.handle )
		          sub_18007E1E0(*(_QWORD *)&v370.depthTexture.handle);
		        v41 = 2LL;
		        RendererList = -1;
		        v4 = this;
		        renderGraph = v364;
		      }
		      if ( !BYTE1(v4[1].fields._._._.m_basicTransformConstants._PrevViewProjMatrix.m01) )
		      {
		        UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		          (Int32Enum__Enum)0x1Eu,
		          MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		        v370.depthTexture.handle = 0LL;
		        v370.depthTexture.fallBackResource = (ResourceHandle)&v539;
		        try
		        {
		          memset(v388, 0, 20);
		          v169 = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m23;
		          m01_low = 1;
		          if ( !v533 )
		            m01_low = LOBYTE(v4[1].fields._._._.m_basicTransformConstants._PrevViewProjMatrix.m01);
		          v388[16] = m01_low != 0;
		          v382.depthTexture = v169;
		          *(_DWORD *)&v382.buildHZB = *(_DWORD *)&v388[16];
		          v381.depthTexture = 0LL;
		          v171 = *(BuildHZBPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m02;
		          if ( !v171 )
		            sub_1800D8250(0LL, v168);
		          HG::Rendering::Runtime::BuildHZBPass::ConstructPass(
		            v171,
		            &v382,
		            (BuildHZBPass_PassOutput *)&v381,
		            renderGraph,
		            *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._ViewProjMatrix.m20,
		            0LL);
		        }
		        catch ( Il2CppExceptionWrapper *v438 )
		        {
		          v370.depthTexture.handle = (ResourceHandle)v438->ex;
		          if ( v370.depthTexture.handle )
		            sub_18007E1E0(*(_QWORD *)&v370.depthTexture.handle);
		          v41 = 2LL;
		          RendererList = -1;
		          v4 = this;
		          renderGraph = v364;
		        }
		      }
		      v172 = *(_OWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m23;
		      v173 = *(DepthPyramidRenderingPass_PassInput *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewProjMatrix.m21;
		      v174 = 0LL;
		      v382.depthTexture = 0LL;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
		      v381.depthTexture = 0LL;
		      v370 = v173;
		      *(_OWORD *)viewHandle = v172;
		      HG::Rendering::Runtime::CopyTexturePass::BlitTexture(
		        renderGraph,
		        (TextureHandle *)viewHandle,
		        &v370.depthTexture,
		        0,
		        -1,
		        0,
		        (Rect *)&v381,
		        0,
		        0LL);
		      gbufferOutput = *(GBufferOutput *)&v4[1].fields._._._.m_basicTransformConstants.current._InvNonJitteredViewProjMatrix.m21;
		      GBufferAttachment = HG::Rendering::Runtime::GBufferOutput::GetGBufferAttachment(
		                            (TextureHandle *)viewHandle,
		                            &gbufferOutput,
		                            GBufferID__Enum_GBufferB,
		                            0LL);
		      v381.depthTexture = 0LL;
		      v370 = *(DepthPyramidRenderingPass_PassInput *)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m01;
		      *(TextureHandle *)viewHandle = *GBufferAttachment;
		      HG::Rendering::Runtime::CopyTexturePass::BlitTexture(
		        renderGraph,
		        (TextureHandle *)viewHandle,
		        &v370.depthTexture,
		        0,
		        -1,
		        0,
		        (Rect *)&v381,
		        0,
		        0LL);
		      UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		        (Int32Enum__Enum)0x19u,
		        MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		      v370.depthTexture.handle = 0LL;
		      v370.depthTexture.fallBackResource = (ResourceHandle)&v539;
		      try
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
		        deferredDecal = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->deferredDecal;
		        if ( !deferredDecal )
		          sub_1800D8250(0LL, v176);
		        enabledForCPUCommands = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabledForCPUCommands(
		                                  deferredDecal,
		                                  0LL);
		        static_fields = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		        deferredErosion = static_fields->deferredErosion;
		        if ( !deferredErosion )
		          sub_1800D8250(0LL, static_fields);
		        v181 = (GpuClothSimulationPassConstructor_PassInput)HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabledForCPUCommands(
		                                                              deferredErosion,
		                                                              0LL);
		        v361 = v181;
		        if ( enabledForCPUCommands )
		        {
		          v184 = *(_QWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._ViewProjMatrix.m20;
		          if ( !v184 )
		            sub_1800D8250(0LL, v182);
		          v368.handle.m_Value = *(_DWORD *)(v184 + 2592);
		          if ( !renderGraph )
		            sub_1800D8250(v184, v182);
		          HGContext = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(renderGraph, 0LL);
		          if ( !HGContext )
		            sub_1800D8250(v186, v185);
		          sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		          v368.handle.m_Value = UnityEngine::HyperGryph::HGDecalRender::CreateRendererList(
		                                  v368.handle.m_Value,
		                                  1u,
		                                  HGContext->fields.renderContext.m_Ptr,
		                                  0LL,
		                                  0LL);
		          v181 = v361;
		        }
		        else
		        {
		          v368.handle.m_Value = -1;
		        }
		        if ( v181 )
		        {
		          v188 = *(_QWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._ViewProjMatrix.m20;
		          if ( !v188 )
		            sub_1800D8250(v183, v182);
		          viewHandle[0] = *(_DWORD *)(v188 + 2592);
		          if ( !renderGraph )
		            sub_1800D8250(v183, v182);
		          v191 = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(renderGraph, 0LL);
		          if ( !v191 )
		            sub_1800D8250(v190, v189);
		          sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		          m_Ptr = v191->fields.renderContext.m_Ptr;
		          LOWORD(camera) = 0;
		          RendererList = UnityEngine::HyperGryph::HGMeshRender::CreateRendererList(
		                           viewHandle[0],
		                           HGRenderFlags__Enum_ShadowOnly|HGRenderFlags__Enum_Opaque,
		                           HGRenderFlags__Enum_Opaque,
		                           HGShaderLightMode__Enum_Erosion,
		                           (HGRenderKeyword__Enum)camera,
		                           m_Ptr,
		                           0,
		                           0,
		                           0xFFFFFFFF,
		                           0,
		                           0,
		                           0LL);
		        }
		        sub_18033B9D0(&invViewMatrix, 0LL, 168LL);
		        invViewMatrix = *(Matrix4x4 *)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m22;
		        ScreenParams = *(Vector4 *)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m01;
		        v410 = *(GBufferOutput *)&v4[1].fields._._._.m_basicTransformConstants.current._InvNonJitteredViewProjMatrix.m21;
		        v411 = cullingResults;
		        LODWORD(v412) = HG::Rendering::Runtime::HGRenderPipeline::get_bakedLightingConfig(v369, 0LL);
		        if ( !hgCamera )
		          sub_1800D8250(v194, v193);
		        *(_QWORD *)((char *)&v412 + 4) = *(_QWORD *)&hgCamera->fields.screenCullingRatio;
		        HIDWORD(v412) = HG::Rendering::Runtime::HGCamera::get_screenCullingLayerMask(hgCamera, 0LL);
		        *(_QWORD *)&v413 = __PAIR64__(RendererList, v368.handle.m_Value);
		        DWORD2(v413) = LODWORD(v4[1].fields._._._.m_basicTransformConstants.current._InvPretransformMatrix.m03);
		        v197 = *(_QWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._ViewProjMatrix.m20;
		        if ( !v197 )
		          sub_1800D8250(v196, v195);
		        HIDWORD(v413) = *(_DWORD *)(v197 + 2628);
		        LOBYTE(v414) = renderPathParams->renderRequest.enableTerrainTessellation;
		        v198 = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		        if ( !v198 )
		          sub_1800D8250(v200, v199);
		        v201 = v198->fields._waterManager_k__BackingField;
		        if ( !v201 )
		          sub_1800D8250(0LL, v199);
		        BYTE1(v414) = HG::Rendering::Runtime::HGWaterManager::GetTerrainRippleOpacity(v201, 0LL) > 0.0;
		        BYTE2(v414) = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                        settingParameter[0]->fields._terrainPOM_k__BackingField,
		                        MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		        v427.sceneColor = *(TextureHandle *)&invViewMatrix.m00;
		        v427.sceneDepth = *(TextureHandle *)&invViewMatrix.m01;
		        v427.sceneMV = *(TextureHandle *)&invViewMatrix.m02;
		        v427.sceneColorCopied = *(TextureHandle *)&invViewMatrix.m03;
		        v427.sceneDepthCopied = (TextureHandle)ScreenParams;
		        v427.gBufferOutput = v410;
		        v427.cullingResults = v411;
		        *(_OWORD *)&v427.bakedLightConfig = v412;
		        *(_OWORD *)&v427.screenCullingLayerMask = v413;
		        *(_QWORD *)&v427.deferredTreeECSList = v414;
		        v361 = 0;
		        v203 = *(DecalPassConstructor **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m00;
		        if ( !v203 )
		          sub_1800D8250(0LL, v202);
		        HG::Rendering::Runtime::DecalPassConstructor::ConstructPass(
		          v203,
		          (DecalPassConstructor_PassInput *)&v427,
		          (DecalPassConstructor_PassOutput *)&v361,
		          renderGraph,
		          *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._ViewProjMatrix.m20,
		          0LL);
		      }
		      catch ( Il2CppExceptionWrapper *v465 )
		      {
		        v370.depthTexture.handle = (ResourceHandle)v465->ex;
		        if ( v370.depthTexture.handle )
		          sub_18007E1E0(*(_QWORD *)&v370.depthTexture.handle);
		        v41 = 2LL;
		        v4 = this;
		        renderGraph = v364;
		        v174 = v382.depthTexture;
		      }
		      UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		        (Int32Enum__Enum)5u,
		        MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGRenderPathScene::OtherPassScope>);
		      v370.depthTexture.handle = 0LL;
		      v370.depthTexture.fallBackResource = (ResourceHandle)&v539;
		      try
		      {
		        sub_18033B9D0(&v422, 0LL, 208LL);
		        v422.srpContext = renderContext;
		        v422.sceneDepth = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m23;
		        v422.sceneDepthCopied = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewProjMatrix.m21;
		        v506 = v422;
		        memset(&v429, 0, sizeof(v429));
		        v205 = *(WaterDefaultDeferredRenderingPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m21;
		        v206 = *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._ViewProjMatrix.m20;
		        gbufferOutput = *(GBufferOutput *)&v4[1].fields._._._.m_basicTransformConstants.current._InvNonJitteredViewProjMatrix.m21;
		        if ( !v205 )
		          sub_1800D8250(0LL, v204);
		        HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::RenderWaterWetnessMask(
		          v205,
		          &v506,
		          &v429,
		          renderGraph,
		          v206,
		          &gbufferOutput,
		          0LL);
		      }
		      catch ( Il2CppExceptionWrapper *v466 )
		      {
		        v370.depthTexture.handle = (ResourceHandle)v466->ex;
		        if ( v370.depthTexture.handle )
		          sub_18007E1E0(*(_QWORD *)&v370.depthTexture.handle);
		        v41 = 2LL;
		        v4 = this;
		        renderGraph = v364;
		        v174 = v382.depthTexture;
		      }
		      UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		        (Int32Enum__Enum)9u,
		        MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		      v370.depthTexture.handle = 0LL;
		      v370.depthTexture.fallBackResource = (ResourceHandle)&v539;
		      try
		      {
		        gbufferOutput = *(GBufferOutput *)&v4[1].fields._._._.m_basicTransformConstants.current._InvNonJitteredViewProjMatrix.m21;
		        v207 = HG::Rendering::Runtime::GBufferOutput::GetGBufferAttachment(
		                 &v381.depthTexture,
		                 &gbufferOutput,
		                 GBufferID__Enum_GBufferB,
		                 0LL);
		        memset(v388, 0, 32);
		        v209 = *v207;
		        v430.sceneDepth = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m23;
		        v430.sceneNormal = v209;
		        v380 = 0;
		        v210 = *(GPUParticleSimulationPassConstructor **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m23;
		        if ( !v210 )
		          sub_1800D8250(0LL, v208);
		        HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::ConstructPass(
		          v210,
		          &v430,
		          &v380,
		          renderGraph,
		          *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._ViewProjMatrix.m20,
		          0LL);
		      }
		      catch ( Il2CppExceptionWrapper *v467 )
		      {
		        v370.depthTexture.handle = (ResourceHandle)v467->ex;
		        if ( v370.depthTexture.handle )
		          sub_18007E1E0(*(_QWORD *)&v370.depthTexture.handle);
		        v41 = 2LL;
		        v4 = this;
		        renderGraph = v364;
		        v174 = v382.depthTexture;
		      }
		      v211 = *(DepthPyramidRenderingPass_PassInput *)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m23;
		      v212 = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewProjMatrix.m21;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
		      v381.depthTexture = v174;
		      v382.depthTexture = v212;
		      v370 = v211;
		      HG::Rendering::Runtime::CopyTexturePass::BlitTexture(
		        renderGraph,
		        &v370.depthTexture,
		        &v382.depthTexture,
		        0,
		        -1,
		        0,
		        (Rect *)&v381,
		        0,
		        0LL);
		      UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		        (Int32Enum__Enum)5u,
		        MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGRenderPathScene::OtherPassScope>);
		      v382.depthTexture.handle = 0LL;
		      v382.depthTexture.fallBackResource = (ResourceHandle)&v539;
		      try
		      {
		        sub_18033B9D0(&v422, 0LL, 208LL);
		        v213 = settingParameter[0];
		        v422.enableIndirect = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                                settingParameter[0]->fields._waterIndirectEnable_k__BackingField,
		                                MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		        v422.depthFormat = renderPathParams->perFrameSetup.depthGraphicsFormat;
		        v422.depthBits = renderPathParams->perFrameSetup.depthBits;
		        v216 = *(TextureHandle **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m20;
		        if ( !v216 )
		          sub_1800D8250(v215, v214);
		        v422.sectorTexture = v216[2];
		        v217 = *(WaterInteractionRenderingPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m01;
		        if ( !v217 )
		          sub_1800D8250(v215, 0LL);
		        v422.interactionTexture = *HG::Rendering::Runtime::WaterInteractionRenderingPass::get_interactionTexture(
		                                     &v381.depthTexture,
		                                     v217,
		                                     0LL);
		        v422.sceneColor = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m22;
		        v422.sceneColorCopied = v395;
		        v422.sceneDepth = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m23;
		        v422.sceneDepthCopied = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewProjMatrix.m21;
		        v422.sceneMV = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewProjMatrix.m20;
		        v422.srpContext = renderContext;
		        v422.gBufferOutput = *(GBufferOutput *)&v4[1].fields._._._.m_basicTransformConstants.current._InvNonJitteredViewProjMatrix.m21;
		        v422.settingParameters = v213;
		        if ( dword_18F35FD08 )
		        {
		          v218 = (((unsigned __int64)&v422.settingParameters >> 12) & 0x1FFFFF) >> 6;
		          _m_prefetchw(&qword_18F0BCBA0[v218 + 36190]);
		          do
		            v219 = qword_18F0BCBA0[v218 + 36190];
		          while ( v219 != _InterlockedCompareExchange64(
		                            &qword_18F0BCBA0[v218 + 36190],
		                            v219 | (1LL << (((unsigned __int64)&v422.settingParameters >> 12) & 0x3F)),
		                            v219) );
		        }
		        v507 = v422;
		        memset(&v431, 0, sizeof(v431));
		        v220 = *(WaterDefaultDeferredRenderingPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m21;
		        v221 = *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._ViewProjMatrix.m20;
		        if ( !v220 )
		          sub_1800D8250(0LL, v221);
		        HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::RenderPrepassV2(
		          v220,
		          &v507,
		          &v431,
		          renderGraph,
		          v221,
		          wetnessHighQualityEnabled,
		          0LL);
		      }
		      catch ( Il2CppExceptionWrapper *v468 )
		      {
		        v382.depthTexture.handle = (ResourceHandle)v468->ex;
		        if ( v382.depthTexture.handle )
		          sub_18007E1E0(*(_QWORD *)&v382.depthTexture.handle);
		        v41 = 2LL;
		        v4 = this;
		        renderGraph = v364;
		      }
		      gbufferOutput = *(GBufferOutput *)&v4[1].fields._._._.m_basicTransformConstants.current._InvNonJitteredViewProjMatrix.m21;
		      v222 = *HG::Rendering::Runtime::GBufferOutput::GetGBufferAttachment(
		                &v381.depthTexture,
		                &gbufferOutput,
		                GBufferID__Enum_GBufferB,
		                0LL);
		      *(TextureHandle *)viewHandle = v222;
		      v223 = *(DepthPyramidRenderingPass_PassInput *)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m23;
		      v370 = v223;
		      v112 = *(InkSimulationPassConstructor **)&v4[1].fields._._._.m_basicTransformConstants._PrevInvViewProjMatrix.m00;
		      if ( v112 )
		      {
		        if ( HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::ShouldRenderTBuffer(
		               (HyperScreenSpaceReflectionRenderingPass *)v112,
		               hgCamera,
		               0LL) )
		        {
		          UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		            (Int32Enum__Enum)0x22u,
		            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		          v382.depthTexture.handle = 0LL;
		          v382.depthTexture.fallBackResource = (ResourceHandle)&v539;
		          try
		          {
		            sub_18033B9D0(&v485.needCopyGBufferAndDepth + 1, 0LL, 207LL);
		            v225 = *(WaterDefaultDeferredRenderingPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m21;
		            if ( !v225 )
		              sub_1800D8250(0LL, v224);
		            v485.needCopyGBufferAndDepth = !HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::get_isRendering(
		                                              v225,
		                                              0LL);
		            v485.forwardReflectionECSList = LODWORD(v4[1].fields._._._.m_basicTransformConstants._PrevViewProjMatrix.m00);
		            v499 = v485;
		            wetnessHighQualityEnabled = 0;
		            v227 = *(WaterDefaultDeferredRenderingPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m21;
		            if ( !v227 )
		              sub_1800D8250(0LL, v226);
		            if ( HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::get_isRendering(v227, 0LL) )
		            {
		              v232 = *(WaterDefaultDeferredRenderingPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m21;
		              if ( !v232 )
		                sub_1800D8250(v228, 0LL);
		              v222 = *HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::get_normalRoughnessWithWaterTexture(
		                        (TextureHandle *)v388,
		                        v232,
		                        0LL);
		              *(TextureHandle *)viewHandle = v222;
		              v234 = *(WaterDefaultDeferredRenderingPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m21;
		              if ( !v234 )
		                sub_1800D8250(v233, 0LL);
		              v223 = (DepthPyramidRenderingPass_PassInput)*HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::get_depthWithWaterTexture(
		                                                             (TextureHandle *)v388,
		                                                             v234,
		                                                             0LL);
		              v499.normalRoughnessTexture = v222;
		              v499.currentSceneDepthTexture = v223.depthTexture;
		            }
		            else
		            {
		              gbufferOutput = *(GBufferOutput *)&v4[1].fields._._._.m_basicTransformConstants.current._InvNonJitteredViewProjMatrix.m21;
		              v368 = *HG::Rendering::Runtime::GBufferOutput::GetGBufferAttachment(
		                        &v381.depthTexture,
		                        &gbufferOutput,
		                        GBufferID__Enum_GBufferB,
		                        0LL);
		              v381.depthTexture = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m23;
		              if ( !renderGraph )
		                sub_1800D8250(v230, v229);
		              v222 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                        (TextureHandle *)v388,
		                        renderGraph,
		                        &v368,
		                        0LL);
		              *(TextureHandle *)viewHandle = v222;
		              v223 = (DepthPyramidRenderingPass_PassInput)*HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                                                             (TextureHandle *)v388,
		                                                             renderGraph,
		                                                             &v381.depthTexture,
		                                                             0LL);
		              v499.normalRoughnessTexture = v368;
		              v499.currentSceneDepthTexture = v381.depthTexture;
		              v499.normalRoughnessTextureCopy = v222;
		              v499.currentSceneDepthTextureCopy = v223.depthTexture;
		            }
		            v370 = v223;
		            v235 = *(HyperScreenSpaceReflectionRenderingPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevInvViewProjMatrix.m00;
		            if ( !v235 )
		              sub_1800D8250(0LL, v231);
		            HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::RenderTBuffer(
		              v235,
		              &v499,
		              (HyperScreenSpaceReflectionRenderingPass_PassOutput *)&wetnessHighQualityEnabled,
		              renderGraph,
		              *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._ViewProjMatrix.m20,
		              0LL);
		          }
		          catch ( Il2CppExceptionWrapper *v469 )
		          {
		            v382.depthTexture.handle = (ResourceHandle)v469->ex;
		            if ( v382.depthTexture.handle )
		              sub_18007E1E0(*(_QWORD *)&v382.depthTexture.handle);
		            v41 = 2LL;
		            v4 = this;
		            renderGraph = v364;
		            v222 = *(TextureHandle *)viewHandle;
		            v223 = v370;
		          }
		        }
		        UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		          (Int32Enum__Enum)0x1Fu,
		          MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		        v382.depthTexture.handle = 0LL;
		        v382.depthTexture.fallBackResource = (ResourceHandle)&v539;
		        try
		        {
		          v370 = v223;
		          v381.depthTexture = 0LL;
		          v237 = *(DepthPyramidRenderingPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m22;
		          if ( !v237 )
		            sub_1800D8250(0LL, v236);
		          HG::Rendering::Runtime::DepthPyramidRenderingPass::ConstructPass(
		            v237,
		            &v370,
		            (DepthPyramidRenderingPass_PassOutput *)&v381,
		            renderGraph,
		            *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._ViewProjMatrix.m20,
		            0LL);
		        }
		        catch ( Il2CppExceptionWrapper *v470 )
		        {
		          v382.depthTexture.handle = (ResourceHandle)v470->ex;
		          if ( v382.depthTexture.handle )
		            sub_18007E1E0(*(_QWORD *)&v382.depthTexture.handle);
		          v41 = 2LL;
		          v4 = this;
		          renderGraph = v364;
		          v222 = *(TextureHandle *)viewHandle;
		        }
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		        v370 = (DepthPyramidRenderingPass_PassInput)*HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(
		                                                       (TextureHandle *)v388,
		                                                       0LL);
		        UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		          (Int32Enum__Enum)0x20u,
		          MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		        v382.depthTexture.handle = 0LL;
		        v382.depthTexture.fallBackResource = (ResourceHandle)&v539;
		        try
		        {
		          sub_18033B9D0(v481, 0LL, 72LL);
		          v238 = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m23;
		          v239 = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewProjMatrix.m20;
		          v240 = *(NativeArray_1_HG_Rendering_RenderGraphModule_TextureHandle_ *)&v4[1].fields._._._.m_basicTransformConstants.current._InvNonJitteredViewProjMatrix.m21;
		          v241 = *(NativeArray_1_System_Int32_ *)&v4[1].fields._._._.m_basicTransformConstants.current._InvNonJitteredViewProjMatrix.m22;
		          v482.m_Value = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		                           (SettingParameter_1_System_Int32Enum_ *)settingParameter[0]->fields._gtaoQualityLevel_k__BackingField,
		                           MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		          v483.sceneDepth = v238;
		          v483.sceneMV = v239;
		          v483.gBufferOutput.m_attachments = v240;
		          v483.gBufferOutput.m_gbufferMapping = v241;
		          *(ResourceHandle *)&v483.qualityLevel = v482;
		          v381.depthTexture = 0LL;
		          v243 = *(GTAOPassConstructor **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m03;
		          if ( !v243 )
		            sub_1800D8250(0LL, v242);
		          HG::Rendering::Runtime::GTAOPassConstructor::ConstructPass(
		            v243,
		            &v483,
		            (GTAOPassConstructor_PassOutput *)&v381,
		            renderGraph,
		            *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._ViewProjMatrix.m20,
		            0LL);
		          v370 = (DepthPyramidRenderingPass_PassInput)v381.depthTexture;
		        }
		        catch ( Il2CppExceptionWrapper *v471 )
		        {
		          v382.depthTexture.handle = (ResourceHandle)v471->ex;
		          if ( v382.depthTexture.handle )
		            sub_18007E1E0(*(_QWORD *)&v382.depthTexture.handle);
		          v41 = 2LL;
		          v4 = this;
		          renderGraph = v364;
		          v222 = *(TextureHandle *)viewHandle;
		        }
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		        v381.depthTexture = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle((TextureHandle *)v388, 0LL);
		        v368 = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v382.depthTexture, 0LL);
		        UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		          (Int32Enum__Enum)0x22u,
		          MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		        v382.depthTexture.handle = 0LL;
		        v382.depthTexture.fallBackResource = (ResourceHandle)&v539;
		        try
		        {
		          sub_18033B9D0(&v485, 0LL, 208LL);
		          v244 = settingParameter[0];
		          v485.ssrRayMarchingSampleCount = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		                                             (SettingParameter_1_System_Int32Enum_ *)settingParameter[0]->fields._ssrRayMarchingSampleCount_k__BackingField,
		                                             MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		          v485.previousSceneColorTexture = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewProjMatrix.m03;
		          v246 = *(DepthPyramidRenderingPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m22;
		          if ( !v246 )
		            sub_1800D8250(v245, 0LL);
		          v485.previousSceneDepthPyramidTexture = *HG::Rendering::Runtime::DepthPyramidRenderingPass::get_prevDepthPyramidTexture(
		                                                     (TextureHandle *)v388,
		                                                     v246,
		                                                     0LL);
		          v485.currentSceneDepthTexture = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m23;
		          v248 = *(DepthPyramidRenderingPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m22;
		          if ( !v248 )
		            sub_1800D8250(v247, 0LL);
		          v485.currentSceneDepthPyramidTexture = *HG::Rendering::Runtime::DepthPyramidRenderingPass::get_depthPyramidTexture(
		                                                    (TextureHandle *)v388,
		                                                    v248,
		                                                    0LL);
		          gbufferOutput = *(GBufferOutput *)&v4[1].fields._._._.m_basicTransformConstants.current._InvNonJitteredViewProjMatrix.m21;
		          v485.gbufferNormalRoughenssTexture = *HG::Rendering::Runtime::GBufferOutput::GetGBufferAttachment(
		                                                  (TextureHandle *)v388,
		                                                  &gbufferOutput,
		                                                  GBufferID__Enum_GBufferB,
		                                                  0LL);
		          v485.normalRoughnessTexture = v222;
		          v485.motionVectorTexture = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewProjMatrix.m20;
		          v250 = *(WaterDefaultDeferredRenderingPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m21;
		          if ( !v250 )
		            sub_1800D8250(v249, 0LL);
		          v485.waterWetnessMaskTexture = *HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::get_waterWetnessMaskTexture(
		                                            (TextureHandle *)v388,
		                                            v250,
		                                            0LL);
		          v485.renderContext = renderContext;
		          v485.settingParameters = v244;
		          if ( dword_18F35FD08 )
		          {
		            v251 = (((unsigned __int64)&v485.settingParameters >> 12) & 0x1FFFFF) >> 6;
		            _m_prefetchw(&qword_18F0BCBA0[v251 + 36190]);
		            do
		              v252 = qword_18F0BCBA0[v251 + 36190];
		            while ( v252 != _InterlockedCompareExchange64(
		                              &qword_18F0BCBA0[v251 + 36190],
		                              v252 | (1LL << (((unsigned __int64)&v485.settingParameters >> 12) & 0x3F)),
		                              v252) );
		          }
		          v508 = v485;
		          v377 = 0;
		          v253 = *(HyperScreenSpaceReflectionRenderingPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevInvViewProjMatrix.m00;
		          v254 = *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._ViewProjMatrix.m20;
		          if ( !v253 )
		            sub_1800D8250(0LL, v254);
		          HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::Render(
		            v253,
		            &v508,
		            &v377,
		            renderGraph,
		            v254,
		            enableWetness[0],
		            0LL);
		          v256 = *(HyperScreenSpaceReflectionRenderingPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevInvViewProjMatrix.m00;
		          if ( !v256 )
		            sub_1800D8250(v255, 0LL);
		          v381.depthTexture = *HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::get_ssrLightingTexture(
		                                 (TextureHandle *)v388,
		                                 v256,
		                                 0LL);
		          v258 = *(HyperScreenSpaceReflectionRenderingPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevInvViewProjMatrix.m00;
		          if ( !v258 )
		            sub_1800D8250(v257, 0LL);
		          v368 = *HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::get_ssrFadenessTexture(
		                    (TextureHandle *)v388,
		                    v258,
		                    0LL);
		        }
		        catch ( Il2CppExceptionWrapper *v472 )
		        {
		          v382.depthTexture.handle = (ResourceHandle)v472->ex;
		          if ( v382.depthTexture.handle )
		            sub_18007E1E0(*(_QWORD *)&v382.depthTexture.handle);
		          v41 = 2LL;
		          v4 = this;
		          renderGraph = v364;
		        }
		        UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		          (Int32Enum__Enum)0x24u,
		          MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		        v382.depthTexture.handle = 0LL;
		        v382.depthTexture.fallBackResource = (ResourceHandle)&v539;
		        try
		        {
		          *(_QWORD *)v388 = 0LL;
		          *(_QWORD *)&v388[8] = 0LL;
		          *(_WORD *)&v388[37] = 0;
		          v388[39] = 0;
		          v259 = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m23;
		          *(_DWORD *)&v388[32] = HG::Rendering::Runtime::HGRenderPipeline::GetRemappedRenderingScale(v369, 0LL);
		          si128 = (Vector4)_mm_load_si128((const __m128i *)&output);
		          v388[36] = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                       settingParameter[0]->fields._contactShadowEnableParam_k__BackingField,
		                       MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		          v424.sceneDepth = v259;
		          v424.lightDir = si128;
		          *(_QWORD *)&v424.renderingScale = *(_QWORD *)&v388[32];
		          enableWetness[0] = 0;
		          v262 = *(ContactShadowPassConstructor **)&v4[1].fields._._._.m_basicTransformConstants._PrevInvViewProjMatrix.m20;
		          if ( !v262 )
		            sub_1800D8250(0LL, v261);
		          HG::Rendering::Runtime::ContactShadowPassConstructor::ConstructPass(
		            v262,
		            &v424,
		            (ContactShadowPassConstructor_PassOutput *)enableWetness,
		            renderGraph,
		            *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._ViewProjMatrix.m20,
		            0LL);
		        }
		        catch ( Il2CppExceptionWrapper *v473 )
		        {
		          v382.depthTexture.handle = (ResourceHandle)v473->ex;
		          if ( v382.depthTexture.handle )
		            sub_18007E1E0(*(_QWORD *)&v382.depthTexture.handle);
		          v41 = 2LL;
		          v4 = this;
		          renderGraph = v364;
		        }
		        UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		          (Int32Enum__Enum)0x25u,
		          MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		        v382.depthTexture.handle = 0LL;
		        v382.depthTexture.fallBackResource = (ResourceHandle)&v539;
		        try
		        {
		          sub_18033B9D0(&v437, 0LL, 144LL);
		          v437.sceneDepth = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m23;
		          v437.sceneDepthCopied = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewProjMatrix.m21;
		          v437.sceneMV = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewProjMatrix.m20;
		          v437.cullingResults = cullingResults;
		          v437.lightCullResult = lightCullResult;
		          v437.gBufferOutput = *(GBufferOutput *)&v4[1].fields._._._.m_basicTransformConstants.current._InvNonJitteredViewProjMatrix.m21;
		          v437.directionalLightIndex = v513;
		          v263 = settingParameter[0];
		          v437.sphereIntervalScale = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                                       settingParameter[0]->fields._visSHSphereIntervalScale_k__BackingField,
		                                       MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		          v437.sphereRangeScale = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                                    v263->fields._visSHSphereRangeScale_k__BackingField,
		                                    MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		          v437.enabled = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                           v263->fields._visSHEnabled_k__BackingField,
		                           MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		          v437.enableHalfRez = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                                 v263->fields._visSHHalfRez_k__BackingField,
		                                 MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		          *(_QWORD *)&v437.depthFormat = *(_QWORD *)&renderPathParams->perFrameSetup.depthGraphicsFormat;
		          v266 = renderPathParams->hgrp;
		          if ( !v266 )
		            sub_1800D8250(v265, v264);
		          v437.visibilitySHMaterial = v266->fields.visibilitySHMaterial;
		          if ( dword_18F35FD08 )
		          {
		            v267 = (((unsigned __int64)&v437.visibilitySHMaterial >> 12) & 0x1FFFFF) >> 6;
		            v264 = ((unsigned __int64)&v437.visibilitySHMaterial >> 12) & 0x3F;
		            _m_prefetchw(&qword_18F0BCBA0[v267 + 36190]);
		            do
		              v268 = qword_18F0BCBA0[v267 + 36190];
		            while ( v268 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v267 + 36190], v268 | (1LL << v264), v268) );
		          }
		          v500 = v437;
		          v378 = 0;
		          v269 = *(CapsuleShadowPassConstructor **)&v4[1].fields._._._.m_basicTransformConstants._PrevInvViewProjMatrix.m01;
		          if ( !v269 )
		            sub_1800D8250(0LL, v264);
		          HG::Rendering::Runtime::CapsuleShadowPassConstructor::ConstructPass_VisibilitySH(
		            v269,
		            &v500,
		            &v378,
		            renderGraph,
		            *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._ViewProjMatrix.m20,
		            0LL);
		        }
		        catch ( Il2CppExceptionWrapper *v474 )
		        {
		          v382.depthTexture.handle = (ResourceHandle)v474->ex;
		          if ( v382.depthTexture.handle )
		            sub_18007E1E0(*(_QWORD *)&v382.depthTexture.handle);
		          v41 = 2LL;
		          v4 = this;
		          renderGraph = v364;
		        }
		        UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		          (Int32Enum__Enum)0x26u,
		          MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		        lightCullResult.visibleLightsPtr = 0LL;
		        *(_QWORD *)&lightCullResult.visibleLightCount = &v539;
		        try
		        {
		          sub_18033B9D0(v481, 0LL, 72LL);
		          v270 = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m23;
		          v271 = *(CullingResults *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewProjMatrix.m21;
		          gbufferOutput = *(GBufferOutput *)&v4[1].fields._._._.m_basicTransformConstants.current._InvNonJitteredViewProjMatrix.m21;
		          v272 = *HG::Rendering::Runtime::GBufferOutput::GetGBufferAttachment(
		                    (TextureHandle *)v388,
		                    &gbufferOutput,
		                    0,
		                    0LL);
		          gbufferOutput = *(GBufferOutput *)&v4[1].fields._._._.m_basicTransformConstants.current._InvNonJitteredViewProjMatrix.m21;
		          v273 = *HG::Rendering::Runtime::GBufferOutput::GetGBufferAttachment(
		                    (TextureHandle *)v388,
		                    &gbufferOutput,
		                    1,
		                    0LL);
		          v274 = settingParameter[0];
		          LOBYTE(v482.m_Value) = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                                   settingParameter[0]->fields._enableScreenSpaceShadowMask_k__BackingField,
		                                   MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		          BYTE1(v482.m_Value) = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                                  v274->fields._hdplsScreenSpaceReduceResolution_k__BackingField,
		                                  MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		          v482._type_k__BackingField = HG::Rendering::Runtime::HGRenderPipeline::GetRemappedRenderingScale(v369, 0LL);
		          v426.sceneDepth = v270;
		          v426.cullingResults = v271;
		          *(TextureHandle *)&v426.bakedLightingConfig = v272;
		          *(TextureHandle *)&v426.terrainGpuSubd = v273;
		          v426.HZBTexture.fallBackResource = v482;
		          enableWetness[0] = 0;
		          v276 = *(ScreenSpaceShadowMaskPassConstructor **)&v4[1].fields._._._.m_basicTransformConstants._PrevInvViewProjMatrix.m21;
		          if ( !v276 )
		            sub_1800D8250(0LL, v275);
		          HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor::ConstructPass(
		            v276,
		            (ScreenSpaceShadowMaskPassConstructor_PassInput *)&v426,
		            (ScreenSpaceShadowMaskPassConstructor_PassOutput *)enableWetness,
		            renderGraph,
		            *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._ViewProjMatrix.m20,
		            0LL);
		        }
		        catch ( Il2CppExceptionWrapper *v475 )
		        {
		          lightCullResult.visibleLightsPtr = v475->ex;
		          if ( lightCullResult.visibleLightsPtr )
		            sub_18007E1E0(lightCullResult.visibleLightsPtr);
		          v41 = 2LL;
		          v4 = this;
		          renderGraph = v364;
		        }
		        UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		          (Int32Enum__Enum)0x21u,
		          MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		        lightCullResult.visibleLightsPtr = 0LL;
		        *(_QWORD *)&lightCullResult.visibleLightCount = &v539;
		        try
		        {
		          sub_18033B9D0(&v436.characterOutlineEnable + 1, 0LL, 183LL);
		          v436.characterOutlineEnable = CharOutlinePassEnableState;
		          v279 = hgCamera;
		          if ( !hgCamera )
		            sub_1800D8250(v278, v277);
		          v436.screenCullingLayerMask = HG::Rendering::Runtime::HGCamera::get_screenCullingLayerMask(hgCamera, 0LL);
		          *(_QWORD *)&v436.screenCullingRatio = *(_QWORD *)&v279->fields.screenCullingRatio;
		          v280 = v369;
		          v436.bakedLightingConfig = HG::Rendering::Runtime::HGRenderPipeline::get_bakedLightingConfig(v369, 0LL);
		          v436.cullingResults = cullingResults;
		          v436.shadowResult = *(ShadowResult *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewNoTransProjMatrix.m00;
		          v436.hgrp = v280;
		          if ( dword_18F35FD08 )
		          {
		            v281 = (((unsigned __int64)&v436.hgrp >> 12) & 0x1FFFFF) >> 6;
		            _m_prefetchw(&qword_18F0BCBA0[v281 + 36190]);
		            do
		              v282 = qword_18F0BCBA0[v281 + 36190];
		            while ( v282 != _InterlockedCompareExchange64(
		                              &qword_18F0BCBA0[v281 + 36190],
		                              v282 | (1LL << (((unsigned __int64)&v436.hgrp >> 12) & 0x3F)),
		                              v282) );
		          }
		          v436.renderContext = renderContext;
		          v436.characterPrePassECSList = LODWORD(v4[1].fields._._._.m_basicTransformConstants.current._InvPretransformMatrix.m31);
		          v436.forwardOpaquePreZECSList = LODWORD(v4[1].fields._._._.m_basicTransformConstants.current._InvPretransformMatrix.m30);
		          *(_QWORD *)&v436.forwardOpaqueECSList = *(_QWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._InvPretransformMatrix.m13;
		          v436.characterOpaqueECSList = LODWORD(v4[1].fields._._._.m_basicTransformConstants.current._WorldSpaceCameraPos_Internal.y);
		          v436.characterOutlineOpaqueECSList = LODWORD(v4[1].fields._._._.m_basicTransformConstants.current._InvPretransformMatrix.m33);
		          v436.characterOutlineOpaqueEqualECSList = LODWORD(v4[1].fields._._._.m_basicTransformConstants.current._WorldSpaceCameraPos_Internal.x);
		          v436.sceneColorTexture = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m22;
		          v436.sceneDepthTexture = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m23;
		          v504 = v436;
		          v379 = 0;
		          v283 = *(FakePlanarReflectionPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m23;
		          basicTransformConstants = HG::Rendering::Runtime::HGRenderPathBase::get_basicTransformConstants(
		                                      (HGRenderPathBase *)v4,
		                                      0LL);
		          shaderVariablesGlobal = HG::Rendering::Runtime::HGRenderPathBase::get_shaderVariablesGlobal(
		                                    (HGRenderPathBase *)v4,
		                                    0LL);
		          v287 = *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._ViewProjMatrix.m20;
		          if ( !v283 )
		            sub_1800D8250(v287, v286);
		          HG::Rendering::Runtime::FakePlanarReflectionPass::ConstructPass(
		            v283,
		            &v504,
		            &v379,
		            basicTransformConstants,
		            shaderVariablesGlobal,
		            renderGraph,
		            v287,
		            settingParameter[0],
		            0LL);
		        }
		        catch ( Il2CppExceptionWrapper *v476 )
		        {
		          lightCullResult.visibleLightsPtr = v476->ex;
		          if ( lightCullResult.visibleLightsPtr )
		            sub_18007E1E0(lightCullResult.visibleLightsPtr);
		          v41 = 2LL;
		          v4 = this;
		          renderGraph = v364;
		        }
		        UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		          (Int32Enum__Enum)0x27u,
		          MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		        lightCullResult.visibleLightsPtr = 0LL;
		        *(_QWORD *)&lightCullResult.visibleLightCount = &v539;
		        try
		        {
		          sub_18033B9D0(v488, 0LL, 264LL);
		          v488[0] = *(_OWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m22;
		          v488[1] = *(_OWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m23;
		          v488[2] = *(_OWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewProjMatrix.m21;
		          v488[3] = *(_OWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewProjMatrix.m03;
		          v488[4] = v370;
		          v488[5] = v381.depthTexture;
		          v488[6] = v368;
		          v289 = *(FakePlanarReflectionPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m23;
		          if ( !v289 )
		            sub_1800D8250(v288, 0LL);
		          v488[7] = *HG::Rendering::Runtime::FakePlanarReflectionPass::get_planarReflectionTexture(
		                       (TextureHandle *)v388,
		                       v289,
		                       0LL);
		          v291 = *(BakeFogLutPassConstructor **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m00;
		          if ( !v291 )
		            sub_1800D8250(v290, 0LL);
		          v488[8] = *HG::Rendering::Runtime::BakeFogLutPassConstructor::get_FogBakeLutTexture(
		                       (TextureHandle *)v388,
		                       v291,
		                       0LL);
		          v293 = *(WaterDefaultDeferredRenderingPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m21;
		          if ( !v293 )
		            sub_1800D8250(v292, 0LL);
		          v488[9] = *HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::get_waterWetnessMaskTexture(
		                       (TextureHandle *)v388,
		                       v293,
		                       0LL);
		          v489 = v369;
		          if ( dword_18F35FD08 )
		          {
		            v294 = (((unsigned __int64)&v489 >> 12) & 0x1FFFFF) >> 6;
		            _m_prefetchw(&qword_18F0BCBA0[v294 + 36190]);
		            do
		              v295 = qword_18F0BCBA0[v294 + 36190];
		            while ( v295 != _InterlockedCompareExchange64(
		                              &qword_18F0BCBA0[v294 + 36190],
		                              v295 | (1LL << (((unsigned __int64)&v489 >> 12) & 0x3F)),
		                              v295) );
		          }
		          v490 = *(_OWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._InvNonJitteredViewProjMatrix.m21;
		          v491 = *(_OWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._InvNonJitteredViewProjMatrix.m22;
		          v492 = *(_OWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewNoTransProjMatrix.m00;
		          v493 = *(_OWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewNoTransProjMatrix.m01;
		          v494 = *(_OWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewNoTransProjMatrix.m02;
		          v495 = *(_QWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewNoTransProjMatrix.m03;
		          m23 = v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewNoTransProjMatrix.m23;
		          ColorBufferFormat = HG::Rendering::Runtime::HGRenderPipeline::GetColorBufferFormat(
		                                v369,
		                                *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._ViewProjMatrix.m20,
		                                0LL);
		          v297 = &v510;
		          v298 = (TextureHandle *)v488;
		          do
		          {
		            v297->sceneColor = *v298;
		            v297->sceneDepth = v298[1];
		            v297->sceneDepthCopied = v298[2];
		            v297->historySceneColor = v298[3];
		            v297->indirectAmbientOcclusionTexture = v298[4];
		            v297->ssrLightingTexture = v298[5];
		            v297->ssrFadenessTexture = v298[6];
		            v297 = (DeferredLightingPassConstructor_PassInput *)((char *)v297 + 128);
		            *(TextureHandle *)((char *)&v297[-1].shadowResult.punctualLightShadowResult + 4) = v298[7];
		            v298 += 8;
		            --v41;
		          }
		          while ( v41 );
		          v297->sceneColor.handle = v298->handle;
		          v381.depthTexture = 0LL;
		          v299 = *(DeferredLightingPassConstructor **)&v4[1].fields._._._.m_basicTransformConstants._PrevInvViewProjMatrix.m02;
		          if ( !v299 )
		            sub_1800D8250(0LL, v296);
		          HG::Rendering::Runtime::DeferredLightingPassConstructor::ConstructPass(
		            v299,
		            &v510,
		            (DeferredLightingPassConstructor_PassOutput *)&v381,
		            renderGraph,
		            *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._ViewProjMatrix.m20,
		            0LL);
		          *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m22 = v381.depthTexture;
		        }
		        catch ( Il2CppExceptionWrapper *v477 )
		        {
		          lightCullResult.visibleLightsPtr = v477->ex;
		          if ( lightCullResult.visibleLightsPtr )
		            sub_18007E1E0(lightCullResult.visibleLightsPtr);
		          v4 = this;
		          renderGraph = v364;
		        }
		        UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		          (Int32Enum__Enum)0x17u,
		          MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		        lightCullResult.visibleLightsPtr = 0LL;
		        *(_QWORD *)&lightCullResult.visibleLightCount = &v539;
		        try
		        {
		          sub_18033B9D0(&v479, 0LL, 200LL);
		          v479.sceneColor = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m22;
		          v479.sceneDepth = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m23;
		          v479.sceneMV = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewProjMatrix.m20;
		          v479.terrainDepthBuffer = v396.terrainDepthBuffer;
		          v479.hgrp = v369;
		          if ( dword_18F35FD08 )
		          {
		            v300 = (((unsigned __int64)&v479.hgrp >> 12) & 0x1FFFFF) >> 6;
		            _m_prefetchw(&qword_18F0BCBA0[v300 + 36190]);
		            do
		              v301 = qword_18F0BCBA0[v300 + 36190];
		            while ( v301 != _InterlockedCompareExchange64(
		                              &qword_18F0BCBA0[v300 + 36190],
		                              v301 | (1LL << (((unsigned __int64)&v479.hgrp >> 12) & 0x3F)),
		                              v301) );
		          }
		          *(_QWORD *)&v479.forwardOpaqueECSRendererList = *(_QWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._InvPretransformMatrix.m13;
		          v479.characterOpaqueECSRendererList = LODWORD(v4[1].fields._._._.m_basicTransformConstants.current._WorldSpaceCameraPos_Internal.y);
		          *(_QWORD *)&v479.characterOutlineOpaqueECSRendererList = *(_QWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._InvPretransformMatrix.m33;
		          v479.shadowResult = *(ShadowResult *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewNoTransProjMatrix.m00;
		          v479.cullingResults = cullingResults;
		          v479.bakedLightingConfig = HG::Rendering::Runtime::HGRenderPipeline::get_bakedLightingConfig(v369, 0LL);
		          if ( !hgCamera )
		            sub_1800D8250(v303, v302);
		          *(_QWORD *)&v479.screenCullingRatio = *(_QWORD *)&hgCamera->fields.screenCullingRatio;
		          v479.screenCullingLayerMask = HG::Rendering::Runtime::HGCamera::get_screenCullingLayerMask(hgCamera, 0LL);
		          v479.characterOutlineEnabled = CharOutlinePassEnableState;
		          v505 = v479;
		          enableWetness[0] = 0;
		          v305 = *(ForwardOpaquePassConstructor **)&v4[1].fields._._._.m_basicTransformConstants._PrevInvViewProjMatrix.m22;
		          if ( !v305 )
		            sub_1800D8250(0LL, v304);
		          HG::Rendering::Runtime::ForwardOpaquePassConstructor::ConstructPass(
		            v305,
		            &v505,
		            (ForwardOpaquePassConstructor_PassOutput *)enableWetness,
		            renderGraph,
		            *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._ViewProjMatrix.m20,
		            0LL);
		        }
		        catch ( Il2CppExceptionWrapper *v478 )
		        {
		          lightCullResult.visibleLightsPtr = v478->ex;
		          if ( lightCullResult.visibleLightsPtr )
		            sub_18007E1E0(lightCullResult.visibleLightsPtr);
		          v4 = this;
		          renderGraph = v364;
		        }
		        UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		          (Int32Enum__Enum)6u,
		          MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGRenderPathScene::OtherPassScope>);
		        lightCullResult.visibleLightsPtr = 0LL;
		        *(_QWORD *)&lightCullResult.visibleLightCount = &v539;
		        try
		        {
		          v306 = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m22;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		          SceneColorTexture = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SceneColorTexture;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
		          v396 = 0LL;
		          v308 = v395;
		          v381.depthTexture = v306;
		          HG::Rendering::Runtime::CopyTexturePass::BlitTexture(
		            renderGraph,
		            &v381.depthTexture,
		            &v395,
		            0,
		            SceneColorTexture,
		            0,
		            (Rect *)&v396,
		            0,
		            0LL);
		          CameraDepthTexture = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CameraDepthTexture;
		          v395 = 0LL;
		          v396 = *(TerrainDepthPrepassConstructor_PassOutput *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewProjMatrix.m21;
		          v381.depthTexture = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m23;
		          HG::Rendering::Runtime::CopyTexturePass::BlitTexture(
		            renderGraph,
		            &v381.depthTexture,
		            &v396.terrainDepthBuffer,
		            0,
		            CameraDepthTexture,
		            0,
		            (Rect *)&v395,
		            0,
		            0LL);
		          sub_18033B9D0(&v422, 0LL, 208LL);
		          v422.depthFormat = renderPathParams->perFrameSetup.depthGraphicsFormat;
		          v422.depthBits = renderPathParams->perFrameSetup.depthBits;
		          v312 = *(TextureHandle **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m20;
		          if ( !v312 )
		            sub_1800D8250(v311, v310);
		          v422.sectorTexture = v312[2];
		          v313 = *(WaterInteractionRenderingPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m01;
		          if ( !v313 )
		            sub_1800D8250(v311, 0LL);
		          v422.interactionTexture = *HG::Rendering::Runtime::WaterInteractionRenderingPass::get_interactionTexture(
		                                       (TextureHandle *)v388,
		                                       v313,
		                                       0LL);
		          v422.sceneColor = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m22;
		          v422.sceneColorCopied = v308;
		          v422.sceneDepth = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m23;
		          v422.sceneDepthCopied = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewProjMatrix.m21;
		          v422.sceneMV = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewProjMatrix.m20;
		          v315 = *(HyperScreenSpaceReflectionRenderingPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevInvViewProjMatrix.m00;
		          if ( !v315 )
		            sub_1800D8250(v314, 0LL);
		          v422.deferredSSRLightingTexture = *HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::get_ssrLightingTexture(
		                                               (TextureHandle *)v388,
		                                               v315,
		                                               0LL);
		          v317 = *(HyperScreenSpaceReflectionRenderingPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevInvViewProjMatrix.m00;
		          if ( !v317 )
		            sub_1800D8250(v316, 0LL);
		          v422.ssrFadenessTexture = *HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::get_ssrFadenessTexture(
		                                       (TextureHandle *)v388,
		                                       v317,
		                                       0LL);
		          v422.srpContext = renderContext;
		          v422.gBufferOutput = *(GBufferOutput *)&v4[1].fields._._._.m_basicTransformConstants.current._InvNonJitteredViewProjMatrix.m21;
		          v509 = v422;
		          memset(&v432, 0, sizeof(v432));
		          v319 = *(WaterDefaultDeferredRenderingPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m21;
		          if ( !v319 )
		            sub_1800D8250(0LL, v318);
		          HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::RenderLighting(
		            v319,
		            &v509,
		            &v432,
		            renderGraph,
		            *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._ViewProjMatrix.m20,
		            0LL);
		        }
		        catch ( Il2CppExceptionWrapper *v480 )
		        {
		          lightCullResult.visibleLightsPtr = v480->ex;
		          if ( lightCullResult.visibleLightsPtr )
		            sub_18007E1E0(lightCullResult.visibleLightsPtr);
		          v4 = this;
		          renderGraph = v364;
		        }
		        UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		          (Int32Enum__Enum)0x10u,
		          MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		        *(_QWORD *)viewHandle = 0LL;
		        *(_QWORD *)&viewHandle[2] = &v539;
		        try
		        {
		          sub_18033B9D0(&v420, 0LL, 64LL);
		          v420.sceneColor = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m22;
		          v420.sceneDepth = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m23;
		          v420.sceneDepthCopied = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewProjMatrix.m21;
		          v322 = v369->fields._settingParameters_k__BackingField;
		          if ( !v322 )
		            sub_1800D8250(v321, v320);
		          v420.volumetricParameters = v322->fields._volumetricCloud_k__BackingField;
		          v323 = dword_18F35FD08;
		          if ( dword_18F35FD08 )
		          {
		            v324 = (((unsigned __int64)&v420.volumetricParameters >> 12) & 0x1FFFFF) >> 6;
		            v320 = ((unsigned __int64)&v420.volumetricParameters >> 12) & 0x3F;
		            _m_prefetchw(&qword_18F0BCBA0[v324 + 36190]);
		            do
		              v325 = qword_18F0BCBA0[v324 + 36190];
		            while ( v325 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v324 + 36190], v325 | (1LL << v320), v325) );
		            v323 = dword_18F35FD08;
		          }
		          v420.volumetricRenderObjects = v535;
		          if ( v323 )
		          {
		            v326 = (((unsigned __int64)&v420.volumetricRenderObjects >> 12) & 0x1FFFFF) >> 6;
		            v320 = ((unsigned __int64)&v420.volumetricRenderObjects >> 12) & 0x3F;
		            _m_prefetchw(&qword_18F0BCBA0[v326 + 36190]);
		            do
		              v327 = qword_18F0BCBA0[v326 + 36190];
		            while ( v327 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v326 + 36190], v327 | (1LL << v320), v327) );
		          }
		          v484 = v420;
		          enableWetness[0] = 0;
		          v328 = *(VolumetricCloudPassConstructor **)&v4[1].fields._._._.m_basicTransformConstants._PrevInvViewProjMatrix.m23;
		          if ( !v328 )
		            sub_1800D8250(0LL, v320);
		          HG::Rendering::Runtime::VolumetricCloudPassConstructor::ConstructPass(
		            v328,
		            &v484,
		            (VolumetricCloudPassConstructor_PassOutput *)enableWetness,
		            renderGraph,
		            *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._ViewProjMatrix.m20,
		            0LL);
		        }
		        catch ( Il2CppExceptionWrapper *v454 )
		        {
		          *(Il2CppExceptionWrapper *)viewHandle = (Il2CppExceptionWrapper)v454->ex;
		          sub_1801F46F0(viewHandle);
		          v4 = this;
		          renderGraph = v364;
		          goto LABEL_373;
		        }
		        sub_1801F46F0(viewHandle);
		LABEL_373:
		        UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		          (Int32Enum__Enum)0x2Bu,
		          MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		        renderContext.m_Ptr = 0LL;
		        v384 = &v539;
		        try
		        {
		          memset(v388, 0, 48);
		          v330 = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m22;
		          v331 = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m23;
		          v332 = settingParameter[0];
		          lightShaft_k__BackingField = settingParameter[0]->fields._lightShaft_k__BackingField;
		          if ( !lightShaft_k__BackingField )
		            sub_1800D8250(0LL, v329);
		          v388[32] = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                       lightShaft_k__BackingField->fields.enableLightShaft,
		                       MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		          v335 = v332->fields._lightShaft_k__BackingField;
		          if ( !v335 )
		            sub_1800D8250(0LL, v334);
		          *(_DWORD *)&v388[36] = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                                   v335->fields.lightShaftDownSampleFactor,
		                                   MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		          v337 = v332->fields._lightShaft_k__BackingField;
		          if ( !v337 )
		            sub_1800D8250(0LL, v336);
		          *(_DWORD *)&v388[40] = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		                                   (SettingParameter_1_System_Int32Enum_ *)v337->fields.lightShaftSampleNum,
		                                   MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		          v339 = v332->fields._lightShaft_k__BackingField;
		          if ( !v339 )
		            sub_1800D8250(0LL, v338);
		          *(_DWORD *)&v388[44] = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		                                   (SettingParameter_1_System_Int32Enum_ *)v339->fields.lightShaftBlurPassCount,
		                                   MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		          v435.sceneColor = v330;
		          v435.sceneDepth = v331;
		          *(_OWORD *)&v435.enableLightShaft = *(_OWORD *)&v388[32];
		          memset(&v403, 0, sizeof(v403));
		          v341 = *(LightShaftPassConstructor **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m00;
		          if ( !v341 )
		            sub_1800D8250(0LL, v340);
		          HG::Rendering::Runtime::LightShaftPassConstructor::ConstructPass(
		            v341,
		            &v435,
		            &v403,
		            renderGraph,
		            *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._ViewProjMatrix.m20,
		            0LL);
		          *(LightShaftPassConstructor_PassOutput *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewNoTransProjMatrix.m33 = v403;
		        }
		        catch ( Il2CppExceptionWrapper *v439 )
		        {
		          renderContext.m_Ptr = v439->ex;
		          sub_1801F46F0(&renderContext);
		          v4 = this;
		          renderGraph = v364;
		          goto LABEL_381;
		        }
		        sub_1801F46F0(&renderContext);
		LABEL_381:
		        UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		          (Int32Enum__Enum)0x28u,
		          MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		        settingParameter[0] = 0LL;
		        settingParameter[1] = (HGSettingParameters *)&v539;
		        try
		        {
		          sub_18033B9D0(v514, 0LL, 4768LL);
		          v514[0] = *(_OWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m22;
		          v514[1] = *(_OWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m23;
		          v343 = *(DepthPyramidRenderingPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m22;
		          if ( !v343 )
		            sub_1800D8250(v342, 0LL);
		          v514[4] = *HG::Rendering::Runtime::DepthPyramidRenderingPass::get_depthPyramidTexture(
		                       (TextureHandle *)v388,
		                       v343,
		                       0LL);
		          v514[2] = *(_OWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewProjMatrix.m20;
		          v514[3] = *(_OWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewProjMatrix.m21;
		          v515 = v369;
		          if ( dword_18F35FD08 )
		          {
		            v344 = (((unsigned __int64)&v515 >> 12) & 0x1FFFFF) >> 6;
		            _m_prefetchw(&qword_18F0BCBA0[v344 + 36190]);
		            do
		              v345 = qword_18F0BCBA0[v344 + 36190];
		            while ( v345 != _InterlockedCompareExchange64(
		                              &qword_18F0BCBA0[v344 + 36190],
		                              v345 | (1LL << (((unsigned __int64)&v515 >> 12) & 0x3F)),
		                              v345) );
		          }
		          v516 = sub_180002F70(18LL, v4);
		          v517 = *(_OWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._InvNonJitteredViewProjMatrix.m21;
		          v518 = *(_OWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._InvNonJitteredViewProjMatrix.m22;
		          v519[0] = 0LL;
		          if ( dword_18F35FD08 )
		          {
		            v346 = (((unsigned __int64)v519 >> 12) & 0x1FFFFF) >> 6;
		            _m_prefetchw(&qword_18F0BCBA0[v346 + 36190]);
		            do
		              v347 = qword_18F0BCBA0[v346 + 36190];
		            while ( v347 != _InterlockedCompareExchange64(
		                              &qword_18F0BCBA0[v346 + 36190],
		                              v347 | (1LL << (((unsigned __int64)v519 >> 12) & 0x3F)),
		                              v347) );
		          }
		          v520 = cullingResults;
		          bakedLightingConfig = HG::Rendering::Runtime::HGRenderPipeline::get_bakedLightingConfig(v369, 0LL);
		          z = v4[1].fields._._._.m_basicTransformConstants.current._WorldSpaceCameraPos_Internal.z;
		          v523 = CharOutlinePassEnableState;
		          if ( !hgCamera )
		            sub_1800D8250(v349, v348);
		          screenCullingRatio = hgCamera->fields.screenCullingRatio;
		          screenRatioCullingDistance = hgCamera->fields.screenRatioCullingDistance;
		          screenCullingLayerMask = HG::Rendering::Runtime::HGCamera::get_screenCullingLayerMask(hgCamera, 0LL);
		          sub_18033B330(v527, v514, 4768LL);
		          sub_18033B330(&v536, v527, 4768LL);
		          v416 = 0LL;
		          v351 = *(TransparentPassConstructor **)&v4[1].fields._._._.m_basicTransformConstants._PrevInvViewProjMatrix.m03;
		          if ( !v351 )
		            sub_1800D8250(0LL, v350);
		          HG::Rendering::Runtime::TransparentPassConstructor::ConstructPass(
		            v351,
		            &v536,
		            &v416,
		            renderGraph,
		            *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._ViewProjMatrix.m20,
		            0LL);
		          *(TransparentPassConstructor_PassOutput *)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m22 = v416;
		        }
		        catch ( Il2CppExceptionWrapper *v440 )
		        {
		          settingParameter[0] = (HGSettingParameters *)v440->ex;
		          sub_1801F46F0(settingParameter);
		          v4 = this;
		          renderGraph = v364;
		          goto LABEL_393;
		        }
		        sub_1801F46F0(settingParameter);
		LABEL_393:
		        UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		          (Int32Enum__Enum)0x2Au,
		          MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		        renderContext.m_Ptr = 0LL;
		        v384 = &v539;
		        try
		        {
		          sub_18033B9D0(&invViewMatrix, 0LL, 152LL);
		          *(_OWORD *)&invViewMatrix.m00 = *(_OWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m22;
		          *(_OWORD *)&invViewMatrix.m01 = *(_OWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m23;
		          *(_OWORD *)&invViewMatrix.m02 = *(_OWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewProjMatrix.m20;
		          *(_OWORD *)&invViewMatrix.m03 = *(_OWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewNoTransProjMatrix.m00;
		          ScreenParams = *(Vector4 *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewNoTransProjMatrix.m01;
		          v410.m_attachments = *(NativeArray_1_HG_Rendering_RenderGraphModule_TextureHandle_ *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewNoTransProjMatrix.m02;
		          v410.m_gbufferMapping.m_Buffer = *(Void **)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewNoTransProjMatrix.m03;
		          v410.m_gbufferMapping.m_Length = LODWORD(v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewNoTransProjMatrix.m23);
		          v411 = cullingResults;
		          LODWORD(v412) = HG::Rendering::Runtime::HGRenderPipeline::get_bakedLightingConfig(v369, 0LL);
		          if ( !hgCamera )
		            sub_1800D8250(v353, v352);
		          *(_QWORD *)((char *)&v412 + 4) = *(_QWORD *)&hgCamera->fields.screenCullingRatio;
		          HIDWORD(v412) = HG::Rendering::Runtime::HGCamera::get_screenCullingLayerMask(hgCamera, 0LL);
		          *(float *)&v413 = v4[1].fields._._._.m_basicTransformConstants.current._WorldSpaceCameraPos_Internal.w;
		          v501.sceneColor = *(TextureHandle *)&invViewMatrix.m00;
		          v501.sceneDepth = *(TextureHandle *)&invViewMatrix.m01;
		          v501.sceneMV = *(TextureHandle *)&invViewMatrix.m02;
		          *(_OWORD *)&v501.shadowResult.directionalShadowActive = *(_OWORD *)&invViewMatrix.m03;
		          *(Vector4 *)&v501.shadowResult.directionalShadowResult.fallBackResource._type_k__BackingField = ScreenParams;
		          *(NativeArray_1_HG_Rendering_RenderGraphModule_TextureHandle_ *)&v501.shadowResult.characterShadowResult.fallBackResource.m_Value = v410.m_attachments;
		          *(TextureHandle *)((char *)&v501.shadowResult.punctualLightShadowResult + 4) = (TextureHandle)v410.m_gbufferMapping;
		          v501.cullingResults = v411;
		          *(_OWORD *)&v501.bakedLightConfig = v412;
		          *(_QWORD *)&v501.transparentAfterDistortionECSList = v413;
		          v417 = 0LL;
		          v355 = *(DistortionPassConstructor **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m20;
		          if ( !v355 )
		            sub_1800D8250(0LL, v354);
		          HG::Rendering::Runtime::DistortionPassConstructor::ConstructPass(
		            v355,
		            &v501,
		            &v417,
		            renderGraph,
		            *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._ViewProjMatrix.m20,
		            0LL);
		          *(DistortionPassConstructor_PassOutput *)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m22 = v417;
		        }
		        catch ( Il2CppExceptionWrapper *v441 )
		        {
		          renderContext.m_Ptr = v441->ex;
		          sub_1801F46F0(&renderContext);
		          return;
		        }
		        sub_1801F46F0(&renderContext);
		        return;
		      }
		    }
		LABEL_553:
		    sub_1800D8250(v112, v111);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3588, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v358, v357);
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_457(Patch, (Object *)v4, renderPathParams, 0LL);
		}
		
		public void __iFixBaseProxy_OnPreRendering(ref HGRenderPathParams P0) {} // 0x0000000189BF6CB4-0x0000000189BF6CBC
		// Void <>iFixBaseProxy_OnPreRendering(HGRenderPathBase+HGRenderPathParams ByRef)
		void HG::Rendering::Runtime::HGRenderPathOnePassDeferred::__iFixBaseProxy_OnPreRendering(
		        HGRenderPathOnePassDeferred *this,
		        HGRenderPathBase_HGRenderPathParams *P0,
		        MethodInfo *method)
		{
		  HG::Rendering::Runtime::HGRenderPathDeferred::OnPreRendering((HGRenderPathDeferred *)this, P0, 0LL);
		}
		
	}
}
