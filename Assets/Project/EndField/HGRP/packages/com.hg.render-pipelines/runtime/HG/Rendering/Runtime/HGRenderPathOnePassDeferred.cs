using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class HGRenderPathOnePassDeferred : HGRenderPathDeferred // TypeDefIndex: 38524
	{
		// Fields
		private BinningPass m_binningPassConstructor; // 0x1420
		private ReflectionProbeBinningPassConstructor m_reflectionProbeBinningPassConstructor; // 0x1428
		private FoliageOccluderPassConstructor m_foliageOccluderPassConstructor; // 0x1430
		private SludgePassConstructor m_sludgePassConstructor; // 0x1438
		private GpuClothSimulationPassConstructor m_gpuClothSimulationPassConstructor; // 0x1440
		private ParticleLightingPassConstructor m_particleLightingPassConstructor; // 0x1448
		private LightClusteringPassConstructor m_lightClusteringPassConstructor; // 0x1450
		private DepthOnlyPassConstructor m_depthOnlyPassConstructor; // 0x1458
		private ShadowMapPassConstructor m_shadowMapPassConstructor; // 0x1460
		private SkyAtmospherePassConstructor m_skyAtmospherePassConstructor; // 0x1468
		private BakeFogLutPassConstructor m_bakeFogLutPassConstructor; // 0x1470
		private TerrainDeformPassConstructor m_terrainDeformPassConstructor; // 0x1478
		private TerrainVTBakePassConstructor m_terrainVTBakePassConstructor; // 0x1480
		private TerrainDepthPrepassConstructor m_terrainDepthPrepassConstructor; // 0x1488
		private WaterSectorRenderingPass m_waterSectorRenderingPassConstructor; // 0x1490
		private WaterInteractionRenderingPass m_waterInteractionRenderingPassConstructor; // 0x1498
		private WaterOnePassDeferredRenderingPass m_waterOnePassDeferredRenderingPassConstructor; // 0x14A0
		private FakePlanarReflectionPass m_fakePlanarReflectionPassConstructor; // 0x14A8
		private OnePassDeferredPassConstructor m_onePassDeferredPassConstructor; // 0x14B0
		private VolumetricCloudPassConstructor m_volumetricCloudPassConstructor; // 0x14B8
		private TransparentPassConstructor m_transparentPassConstructor; // 0x14C0
		private LightShaftPassConstructor m_lightShaftPassConstructor; // 0x14C8
		private DistortionPassConstructor m_distortionPassConstructor; // 0x14D0
		private HyperScreenSpaceReflectionRenderingPass m_hyperScreenSpaceReflectionRenderingPassConstructor; // 0x14D8
		private bool m_shouldSplitOnePass; // 0x14E0
	
		// Constructors
		public HGRenderPathOnePassDeferred() {} // Dummy constructor
		internal HGRenderPathOnePassDeferred(HGRenderPathResources resources, HGCamera camera, HGRenderPathInternal renderPath) {} // 0x0000000189BFD71C-0x0000000189BFDDC8
		// HGRenderPathOnePassDeferred(HGRenderPathBase+HGRenderPathResources, HGCamera, HGRenderPathInternal)
		void HG::Rendering::Runtime::HGRenderPathOnePassDeferred::HGRenderPathOnePassDeferred(
		        HGRenderPathOnePassDeferred *this,
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
		  MethodInfo *v106; // [rsp+20h] [rbp-28h]
		  MethodInfo *v107; // [rsp+20h] [rbp-28h]
		  MethodInfo *v108; // [rsp+20h] [rbp-28h]
		  MethodInfo *v109; // [rsp+20h] [rbp-28h]
		  MethodInfo *v110; // [rsp+20h] [rbp-28h]
		  MethodInfo *v111; // [rsp+20h] [rbp-28h]
		  MethodInfo *v112; // [rsp+20h] [rbp-28h]
		  MethodInfo *v113; // [rsp+20h] [rbp-28h]
		  MethodInfo *v114; // [rsp+20h] [rbp-28h]
		  MethodInfo *v115; // [rsp+20h] [rbp-28h]
		  MethodInfo *v116; // [rsp+20h] [rbp-28h]
		  MethodInfo *v117; // [rsp+20h] [rbp-28h]
		  MethodInfo *v118; // [rsp+20h] [rbp-28h]
		  MethodInfo *v119; // [rsp+20h] [rbp-28h]
		  MethodInfo *v120; // [rsp+20h] [rbp-28h]
		  MethodInfo *v121; // [rsp+20h] [rbp-28h]
		  MethodInfo *v122; // [rsp+20h] [rbp-28h]
		  MethodInfo *v123; // [rsp+20h] [rbp-28h]
		  MethodInfo *v124; // [rsp+20h] [rbp-28h]
		  MethodInfo *v125; // [rsp+20h] [rbp-28h]
		  MethodInfo *v126; // [rsp+20h] [rbp-28h]
		  MethodInfo *v127; // [rsp+20h] [rbp-28h]
		  MethodInfo *v128; // [rsp+20h] [rbp-28h]
		  HGRenderPathBase_HGRenderPathResources v129; // [rsp+30h] [rbp-18h] BYREF
		
		  v9 = HG::Rendering::Runtime::HGRenderPathOnePassDeferred::PopulatePassConstructorIds(0LL);
		  v129 = *resources;
		  HG::Rendering::Runtime::HGRenderPathDeferred::HGRenderPathDeferred(
		    (HGRenderPathDeferred *)this,
		    &v129,
		    v9,
		    camera,
		    renderPath,
		    0LL);
		  PassConstructor = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		                      (HGRenderPathBase *)this,
		                      PassConstructorID__Enum_BinningPass,
		                      0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m21 = sub_180005050(
		                                                                                                    PassConstructor,
		                                                                                                    TypeInfo::HG::Rendering::Runtime::BinningPass);
		  sub_180005050(PassConstructor, TypeInfo::HG::Rendering::Runtime::BinningPass);
		  sub_18002D1B0((HGRenderPathOnePassDeferred *)((char *)this + 5152), v11, v12, v13, v106);
		  v14 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_ReflectionProbeBinning,
		          0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m02 = sub_180005050(
		                                                                                                    v14,
		                                                                                                    TypeInfo::HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor);
		  sub_180005050(v14, TypeInfo::HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor);
		  sub_18002D1B0((HGRenderPathOnePassDeferred *)((char *)this + 5160), v15, v16, v17, v107);
		  v18 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_FoliageOccluder,
		          0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m22 = sub_180005050(
		                                                                                                    v18,
		                                                                                                    TypeInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor);
		  sub_180005050(v18, TypeInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor);
		  sub_18002D1B0((HGRenderPathOnePassDeferred *)((char *)this + 5168), v19, v20, v21, v108);
		  v22 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_Sludge,
		          0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m03 = sub_180005050(
		                                                                                                    v22,
		                                                                                                    TypeInfo::HG::Rendering::Runtime::SludgePassConstructor);
		  sub_180005050(v22, TypeInfo::HG::Rendering::Runtime::SludgePassConstructor);
		  sub_18002D1B0((HGRenderPathOnePassDeferred *)((char *)this + 5176), v23, v24, v25, v109);
		  v26 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_GpuClothSimulation,
		          0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m23 = sub_180005050(
		                                                                                                    v26,
		                                                                                                    TypeInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor);
		  sub_180005050(v26, TypeInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor);
		  sub_18002D1B0((HGRenderPathOnePassDeferred *)((char *)this + 5184), v27, v28, v29, v110);
		  v30 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_ParticleLighting,
		          0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m00 = sub_180005050(v30, TypeInfo::HG::Rendering::Runtime::ParticleLightingPassConstructor);
		  sub_180005050(v30, TypeInfo::HG::Rendering::Runtime::ParticleLightingPassConstructor);
		  sub_18002D1B0((HGRenderPathOnePassDeferred *)((char *)this + 5192), v31, v32, v33, v111);
		  v34 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_LightClustering,
		          0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m20 = sub_180005050(v34, TypeInfo::HG::Rendering::Runtime::LightClusteringPassConstructor);
		  sub_180005050(v34, TypeInfo::HG::Rendering::Runtime::LightClusteringPassConstructor);
		  sub_18002D1B0((HGRenderPathOnePassDeferred *)((char *)this + 5200), v35, v36, v37, v112);
		  v38 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_CustomDepthOnly,
		          0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m01 = sub_180005050(v38, TypeInfo::HG::Rendering::Runtime::DepthOnlyPassConstructor);
		  sub_180005050(v38, TypeInfo::HG::Rendering::Runtime::DepthOnlyPassConstructor);
		  sub_18002D1B0((HGRenderPathOnePassDeferred *)((char *)this + 5208), v39, v40, v41, v113);
		  v42 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_ShadowMap,
		          0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m21 = sub_180005050(v42, TypeInfo::HG::Rendering::Runtime::ShadowMapPassConstructor);
		  sub_180005050(v42, TypeInfo::HG::Rendering::Runtime::ShadowMapPassConstructor);
		  sub_18002D1B0((HGRenderPathOnePassDeferred *)((char *)this + 5216), v43, v44, v45, v114);
		  v46 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_Atmosphere,
		          0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m02 = sub_180005050(v46, TypeInfo::HG::Rendering::Runtime::SkyAtmospherePassConstructor);
		  sub_180005050(v46, TypeInfo::HG::Rendering::Runtime::SkyAtmospherePassConstructor);
		  sub_18002D1B0((HGRenderPathOnePassDeferred *)((char *)this + 5224), v47, v48, v49, v115);
		  v50 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_BakeFogLut,
		          0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m22 = sub_180005050(v50, TypeInfo::HG::Rendering::Runtime::BakeFogLutPassConstructor);
		  sub_180005050(v50, TypeInfo::HG::Rendering::Runtime::BakeFogLutPassConstructor);
		  sub_18002D1B0((HGRenderPathOnePassDeferred *)((char *)this + 5232), v51, v52, v53, v116);
		  v54 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_TerrainDeform,
		          0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m03 = sub_180005050(v54, TypeInfo::HG::Rendering::Runtime::TerrainDeformPassConstructor);
		  sub_180005050(v54, TypeInfo::HG::Rendering::Runtime::TerrainDeformPassConstructor);
		  sub_18002D1B0((HGRenderPathOnePassDeferred *)((char *)this + 5240), v55, v56, v57, v117);
		  v58 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_TerrainVTBake,
		          0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m23 = sub_180005050(v58, TypeInfo::HG::Rendering::Runtime::TerrainVTBakePassConstructor);
		  sub_180005050(v58, TypeInfo::HG::Rendering::Runtime::TerrainVTBakePassConstructor);
		  sub_18002D1B0((HGRenderPathOnePassDeferred *)((char *)this + 5248), v59, v60, v61, v118);
		  v62 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_TerrainDepthPrepass,
		          0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevInvViewProjMatrix.m00 = sub_180005050(
		                                                                                            v62,
		                                                                                            TypeInfo::HG::Rendering::Runtime::TerrainDepthPrepassConstructor);
		  sub_180005050(v62, TypeInfo::HG::Rendering::Runtime::TerrainDepthPrepassConstructor);
		  sub_18002D1B0((HGRenderPathOnePassDeferred *)((char *)this + 5256), v63, v64, v65, v119);
		  v66 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_WaterSector,
		          0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevInvViewProjMatrix.m20 = sub_180005050(
		                                                                                            v66,
		                                                                                            TypeInfo::HG::Rendering::Runtime::WaterSectorRenderingPass);
		  sub_180005050(v66, TypeInfo::HG::Rendering::Runtime::WaterSectorRenderingPass);
		  sub_18002D1B0((HGRenderPathOnePassDeferred *)((char *)this + 5264), v67, v68, v69, v120);
		  v70 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_WaterInteraction,
		          0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevInvViewProjMatrix.m01 = sub_180005050(
		                                                                                            v70,
		                                                                                            TypeInfo::HG::Rendering::Runtime::WaterInteractionRenderingPass);
		  sub_180005050(v70, TypeInfo::HG::Rendering::Runtime::WaterInteractionRenderingPass);
		  sub_18002D1B0((HGRenderPathOnePassDeferred *)((char *)this + 5272), v71, v72, v73, v121);
		  v74 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_WaterOnePassDeferred,
		          0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevInvViewProjMatrix.m21 = sub_180005050(
		                                                                                            v74,
		                                                                                            TypeInfo::HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass);
		  sub_180005050(v74, TypeInfo::HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass);
		  sub_18002D1B0((HGRenderPathOnePassDeferred *)((char *)this + 5280), v75, v76, v77, v122);
		  v78 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_FakePlanarReflection,
		          0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevInvViewProjMatrix.m02 = sub_180005050(
		                                                                                            v78,
		                                                                                            TypeInfo::HG::Rendering::Runtime::FakePlanarReflectionPass);
		  sub_180005050(v78, TypeInfo::HG::Rendering::Runtime::FakePlanarReflectionPass);
		  sub_18002D1B0((HGRenderPathOnePassDeferred *)((char *)this + 5288), v79, v80, v81, v123);
		  v82 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_OnePassDeferred,
		          0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevInvViewProjMatrix.m22 = sub_180005050(
		                                                                                            v82,
		                                                                                            TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor);
		  sub_180005050(v82, TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor);
		  sub_18002D1B0((HGRenderPathOnePassDeferred *)((char *)this + 5296), v83, v84, v85, v124);
		  v86 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_VolumetricCloud,
		          0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevInvViewProjMatrix.m03 = sub_180005050(
		                                                                                            v86,
		                                                                                            TypeInfo::HG::Rendering::Runtime::VolumetricCloudPassConstructor);
		  sub_180005050(v86, TypeInfo::HG::Rendering::Runtime::VolumetricCloudPassConstructor);
		  sub_18002D1B0((HGRenderPathOnePassDeferred *)((char *)this + 5304), v87, v88, v89, v125);
		  v90 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_Transparent,
		          0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevInvViewProjMatrix.m23 = sub_180005050(
		                                                                                            v90,
		                                                                                            TypeInfo::HG::Rendering::Runtime::TransparentPassConstructor);
		  sub_180005050(v90, TypeInfo::HG::Rendering::Runtime::TransparentPassConstructor);
		  sub_18002D1B0((HGRenderPathOnePassDeferred *)((char *)this + 5312), v91, v92, v93, v126);
		  v94 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_LightShaft,
		          0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m00 = sub_180005050(v94, TypeInfo::HG::Rendering::Runtime::LightShaftPassConstructor);
		  sub_180005050(v94, TypeInfo::HG::Rendering::Runtime::LightShaftPassConstructor);
		  sub_18002D1B0((HGRenderPathOnePassDeferred *)((char *)this + 5320), v95, v96, v97, v127);
		  v98 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_Distortion,
		          0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m20 = sub_180005050(v98, TypeInfo::HG::Rendering::Runtime::DistortionPassConstructor);
		  sub_180005050(v98, TypeInfo::HG::Rendering::Runtime::DistortionPassConstructor);
		  sub_18002D1B0((HGRenderPathOnePassDeferred *)((char *)this + 5328), v99, v100, v101, v128);
		  v102 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		           (HGRenderPathBase *)this,
		           PassConstructorID__Enum_HyperScreenSpaceReflection,
		           0LL);
		  *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m01 = sub_180005050(v102, TypeInfo::HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass);
		  sub_180005050(v102, TypeInfo::HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass);
		  sub_18002D1B0((HGRenderPathOnePassDeferred *)((char *)this + 5336), v103, v104, v105, method);
		}
		
	
		// Methods
		private static PassConstructorID[] PopulatePassConstructorIds() => default; // 0x0000000189BF9944-0x0000000189BF99B0
		// PassConstructorID[] PopulatePassConstructorIds()
		PassConstructorID__Enum__Array *HG::Rendering::Runtime::HGRenderPathOnePassDeferred::PopulatePassConstructorIds(
		        MethodInfo *method)
		{
		  Array *v1; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3610, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3610, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1269(Patch, 0LL);
		  }
		  else
		  {
		    v1 = (Array *)il2cpp_array_new_specific_1(TypeInfo::HG::Rendering::Runtime::PassConstructorID, 40LL);
		    System::Runtime::CompilerServices::RuntimeHelpers::InitializeArray(
		      v1,
		      884DB65BF397FFF9967F825A6F0FB2E37A97334E93CD88D37A1EB2F22DC29222_Field,
		      0LL);
		    return (PassConstructorID__Enum__Array *)v1;
		  }
		}
		
		protected override GBufferProfileManager.GBufferProfileConfig GetGBufferProfileConfig() => default; // 0x0000000189BF9678-0x0000000189BF96C8
		// GBufferProfileManager+GBufferProfileConfig GetGBufferProfileConfig()
		GBufferProfileManager_GBufferProfileConfig__Enum HG::Rendering::Runtime::HGRenderPathOnePassDeferred::GetGBufferProfileConfig(
		        HGRenderPathOnePassDeferred *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3611, 0LL) )
		    return 1;
		  Patch = IFix::WrappersManagerImpl::GetPatch(3611, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_7((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, 0LL);
		}
		
		protected override void OnPreRendering(ref HGRenderPathParams renderPathParams) {} // 0x0000000189BF96C8-0x0000000189BF9944
		// Void OnPreRendering(HGRenderPathBase+HGRenderPathParams ByRef)
		void HG::Rendering::Runtime::HGRenderPathOnePassDeferred::OnPreRendering(
		        HGRenderPathOnePassDeferred *this,
		        HGRenderPathBase_HGRenderPathParams *renderPathParams,
		        MethodInfo *method)
		{
		  void *static_fields; // rdx
		  HGRenderPipeline *hgrp; // rcx
		  HGRenderGraph *renderGraph; // r14
		  HGCamera *hgCamera; // rsi
		  GBufferProfileManager *v9; // rbp
		  GBufferProfileManager_GBufferProfileConfig__Enum v10; // eax
		  bool enabledForCPUCommands; // r12
		  bool v12; // al
		  bool v13; // r15
		  bool v14; // bp
		  HGCamera_VolumeComponentsData *volumeComponentsData; // rax
		  float v16; // ecx
		  __int64 v17; // rax
		  uint32_t v18; // esi
		  HGRenderGraphContext *HGContext; // rdi
		  void *context; // rax
		  float v21; // eax
		  float v22; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  uint32_t preZPart0List; // [rsp+50h] [rbp-38h] BYREF
		  uint32_t preZPart1List[3]; // [rsp+54h] [rbp-34h] BYREF
		  uint32_t normalList; // [rsp+A8h] [rbp+20h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3612, 0LL) )
		  {
		    hgrp = renderPathParams->hgrp;
		    if ( hgrp )
		    {
		      renderGraph = HG::Rendering::Runtime::HGRenderPipeline::get_renderGraph(hgrp, 0LL);
		      hgCamera = renderPathParams->renderRequest.hgCamera;
		      if ( renderPathParams->hgrp )
		      {
		        LOBYTE(this[1].fields._._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m21) = 0;
		        v9 = *(GBufferProfileManager **)&this[1].fields._._._.m_basicTransformConstants._PrevViewProjMatrix.m22;
		        v10 = (unsigned int)sub_180002F70(18LL, this);
		        if ( v9 )
		        {
		          HG::Rendering::Runtime::GBufferProfileManager::SetGBufferTextureMemoryless(
		            v9,
		            v10,
		            RenderTextureMemoryless__Enum_Color,
		            0LL);
		          HG::Rendering::Runtime::HGRenderPathDeferred::OnPreRendering(
		            (HGRenderPathDeferred *)this,
		            renderPathParams,
		            0LL);
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
		          hgrp = (HGRenderPipeline *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->characterOutlineOpaque;
		          if ( hgrp )
		          {
		            enabledForCPUCommands = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabledForCPUCommands(
		                                      (HGGraphicsFeatureSwitch *)hgrp,
		                                      0LL);
		            static_fields = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		            hgrp = (HGRenderPipeline *)*((_QWORD *)static_fields + 29);
		            if ( hgrp )
		            {
		              v12 = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabledForCPUCommands(
		                      (HGGraphicsFeatureSwitch *)hgrp,
		                      0LL);
		              static_fields = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager;
		              v13 = v12;
		              hgrp = (HGRenderPipeline *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->characterOutlineOpaqueEqual;
		              if ( hgrp )
		              {
		                v14 = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabledForCPUCommands(
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
		                      if ( !HG::Rendering::Runtime::HGCharacterVolume::GetCharOutlinePassEnableState(
		                              (HGCharacterVolume *)hgrp,
		                              0LL) )
		                      {
		                        v16 = NAN;
		                        this[1].fields._._._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m32 = NAN;
		                        this[1].fields._._._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m00 = NAN;
		LABEL_22:
		                        this[1].fields._._._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m03 = v16;
		                        return;
		                      }
		                      v17 = *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m20;
		                      if ( v17 )
		                      {
		                        v18 = *(_DWORD *)(v17 + 2592);
		                        if ( renderGraph )
		                        {
		                          HGContext = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(renderGraph, 0LL);
		                          if ( HGContext )
		                          {
		                            sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		                            context = HGContext->fields.renderContext.m_Ptr;
		                            normalList = 0;
		                            preZPart0List = 0;
		                            preZPart1List[0] = 0;
		                            UnityEngine::HyperGryph::HGMeshRender::CreateRendererListWithPreZ(
		                              v18,
		                              0x4000500u,
		                              0x4000100u,
		                              0x200u,
		                              context,
		                              &normalList,
		                              &preZPart0List,
		                              preZPart1List,
		                              0,
		                              0LL);
		                            v16 = NAN;
		                            v21 = NAN;
		                            if ( enabledForCPUCommands )
		                              v21 = *(float *)&normalList;
		                            this[1].fields._._._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m32 = v21;
		                            v22 = NAN;
		                            if ( v13 )
		                              v22 = *(float *)&preZPart0List;
		                            this[1].fields._._._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m00 = v22;
		                            if ( v14 )
		                              v16 = *(float *)preZPart1List;
		                            goto LABEL_22;
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
		LABEL_24:
		    sub_1800D8260(hgrp, static_fields);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3612, 0LL);
		  if ( !Patch )
		    goto LABEL_24;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_457(Patch, (Object *)this, renderPathParams, 0LL);
		}
		
		protected override void RenderScene(ref HGRenderPathParams renderPathParams) {} // 0x0000000189BF99B0-0x0000000189BFD71C
		// Void RenderScene(HGRenderPathBase+HGRenderPathParams ByRef)
		// Hidden C++ exception states: #wind=22 #try_helpers=1
		void HG::Rendering::Runtime::HGRenderPathOnePassDeferred::RenderScene(
		        HGRenderPathOnePassDeferred *this,
		        HGRenderPathBase_HGRenderPathParams *renderPathParams,
		        MethodInfo *method)
		{
		  HGRenderPathOnePassDeferred *v4; // rsi
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  HGRenderPipeline *hgrp; // rax
		  HGRenderPipeline *v8; // r14
		  HGRenderGraph *renderGraph; // r15
		  HGCamera *hgCamera; // r13
		  HGRenderPipeline_RenderRequest *p_renderRequest; // rax
		  _OWORD *v12; // rcx
		  __int64 v13; // rdx
		  __int64 v14; // rdx
		  __int64 v15; // rcx
		  HGCamera_VolumeComponentsData *volumeComponentsData; // rax
		  __int64 v17; // rdx
		  __int64 v18; // rcx
		  __int64 v19; // rdx
		  __int64 v20; // rcx
		  __int64 v21; // rdx
		  __int64 v22; // rcx
		  WaterOnePassDeferredRenderingPass *v23; // rbx
		  __int64 v24; // rcx
		  BinningPass *v25; // rdx
		  __int64 v26; // rdx
		  BinningPass *v27; // rcx
		  unsigned __int64 v28; // r8
		  signed __int64 v29; // rtt
		  __int64 v30; // rdx
		  HGGraphicsFeatureSwitch *usePerTileDeferredLighting; // rcx
		  __int64 v32; // rdx
		  LightClusteringPassConstructor *v33; // rcx
		  __int64 v34; // rcx
		  BinningPass *v35; // rdx
		  __int64 v36; // rdx
		  BinningPass *v37; // rcx
		  unsigned __int64 v38; // rdx
		  unsigned __int64 v39; // r8
		  signed __int64 v40; // rtt
		  ReflectionProbeBinningPassConstructor *v41; // rcx
		  __int64 v42; // rdx
		  BinningPass *v43; // rcx
		  __int64 v44; // rdx
		  BinningPass *v45; // rcx
		  __int64 v46; // rdx
		  __int64 v47; // rcx
		  __int64 v48; // rdx
		  ParticleLightingPassConstructor *v49; // rcx
		  __int64 v50; // r12
		  __int64 v51; // rdx
		  WaterSectorRenderingPass *v52; // rcx
		  __int64 v53; // rdx
		  WaterInteractionRenderingPass *v54; // rcx
		  __int64 v55; // rdx
		  FoliageOccluderPassConstructor *v56; // rcx
		  __int64 v57; // rdx
		  SludgePassConstructor *v58; // rcx
		  __int64 v59; // rdx
		  GpuClothSimulationPassConstructor *v60; // rcx
		  unsigned __int64 v61; // rdx
		  unsigned __int64 v62; // r8
		  signed __int64 v63; // rtt
		  DepthOnlyPassConstructor *v64; // rcx
		  unsigned __int64 v65; // rdx
		  __int64 v66; // rcx
		  __int64 v67; // rax
		  int v68; // ecx
		  unsigned __int64 v69; // r8
		  signed __int64 v70; // rtt
		  unsigned __int64 v71; // r8
		  signed __int64 v72; // rtt
		  ShadowMapPassConstructor *v73; // rcx
		  unsigned __int64 v74; // rdx
		  __int64 v75; // rcx
		  HGSettingParameters *settingParameters_k__BackingField; // rax
		  HGAtmosphereSettingParameters *atmosphereParams_k__BackingField; // rax
		  unsigned __int64 v78; // r8
		  signed __int64 v79; // rtt
		  SkyAtmospherePassConstructor *v80; // rcx
		  unsigned __int64 v81; // rdx
		  __int64 v82; // rcx
		  HGSettingParameters *v83; // rax
		  HGAtmosphereSettingParameters *v84; // rax
		  unsigned __int64 v85; // r8
		  signed __int64 v86; // rtt
		  BakeFogLutPassConstructor *v87; // rcx
		  unsigned __int64 v88; // rdx
		  __int64 v89; // rcx
		  CullingResults v90; // xmm0
		  HGRenderPipeline *v91; // rax
		  unsigned __int64 v92; // r8
		  signed __int64 v93; // rtt
		  TerrainDeformPassConstructor *v94; // rcx
		  __int64 v95; // rdx
		  __int64 v96; // rcx
		  HGRenderPipeline *v97; // rbx
		  unsigned __int64 v98; // r8
		  signed __int64 v99; // rtt
		  FakePlanarReflectionPass *v100; // rbx
		  ShaderVariablesGlobal *shaderVariablesGlobal; // rax
		  __int64 v102; // rdx
		  HGCamera *v103; // rcx
		  __int64 v104; // rdx
		  HGGraphicsFeatureSwitch *deferredDecal; // rcx
		  bool enabledForCPUCommands; // bl
		  HGGraphicsFeatureManager__StaticFields *static_fields; // rdx
		  HGGraphicsFeatureSwitch *deferredErosion; // rcx
		  ReflectionProbeBinningPassConstructor_PassOutput v109; // al
		  __int64 v110; // rdx
		  __int64 v111; // rcx
		  __int64 v112; // rcx
		  __int64 v113; // rdx
		  __int64 v114; // rcx
		  HGRenderGraphContext *HGContext; // rbx
		  uint32_t RendererList; // ebx
		  __int64 v117; // rax
		  __int64 v118; // rdx
		  __int64 v119; // rcx
		  void *v120; // rax
		  __int64 v121; // rcx
		  FakePlanarReflectionPass *v122; // rdx
		  __int64 v123; // rcx
		  BakeFogLutPassConstructor *v124; // rdx
		  unsigned __int64 v125; // rdx
		  signed __int64 v126; // rcx
		  unsigned __int64 v127; // r8
		  signed __int64 v128; // rtt
		  unsigned __int64 v129; // r8
		  signed __int64 v130; // rtt
		  HGManagerContext *currentManagerContext; // rax
		  __int64 v132; // rdx
		  __int64 v133; // rcx
		  HGWaterManager *waterManager_k__BackingField; // rcx
		  __int64 v135; // rdx
		  __int64 v136; // rcx
		  OnePassDeferredPassConstructor_PassInput *v137; // rax
		  TextureHandle *v138; // rcx
		  __int64 v139; // rdx
		  OnePassDeferredPassConstructor *v140; // rcx
		  HGCamera *v141; // rax
		  unsigned __int64 v142; // rdx
		  HGCamera *handle; // rcx
		  __int64 v144; // rcx
		  FakePlanarReflectionPass *v145; // rdx
		  __int64 v146; // rcx
		  HyperScreenSpaceReflectionRenderingPass *v147; // rdx
		  unsigned __int64 v148; // r8
		  signed __int64 v149; // rtt
		  __int64 v150; // rdx
		  OnePassDeferredPassConstructor_PassInput *v151; // rax
		  TextureHandle *v152; // rcx
		  OnePassDeferredPassConstructor *v153; // rcx
		  GpuClothSimulationPassConstructor_PassInput v154; // r12
		  HGVFXManager *instance; // rax
		  TextureHandle v156; // xmm6
		  unsigned __int64 v157; // r8
		  signed __int64 v158; // rtt
		  TextureHandle *nullHandle; // rax
		  TextureHandle v160; // xmm7
		  Rect v161; // xmm6
		  BOOL IsValid; // ebx
		  __int64 v163; // rdx
		  __int64 v164; // rcx
		  TextureHandle *v165; // rax
		  WaterInteractionRenderingPass *v166; // rdx
		  __int64 v167; // rdx
		  WaterOnePassDeferredRenderingPass *v168; // rcx
		  WaterOnePassDeferredRenderingPass *v169; // rbx
		  TextureHandle *ssrLightingTexture; // rax
		  HGSettingParameters *v171; // rax
		  int v172; // ecx
		  unsigned __int64 v173; // r8
		  signed __int64 v174; // rtt
		  unsigned __int64 v175; // r8
		  signed __int64 v176; // rtt
		  TextureHandle v177; // xmm8
		  TextureHandle v178; // xmm7
		  int32_t CameraDepthTexture; // ebx
		  __int64 v180; // rdx
		  VolumetricCloudPassConstructor *v181; // rcx
		  TextureHandle *v182; // rax
		  TextureHandle v183; // xmm9
		  __int64 v184; // rdx
		  TextureHandle v185; // xmm6
		  TextureHandle v186; // xmm7
		  HGSettingParameters *v187; // rbx
		  HGLightShaftSettingParameters *lightShaft_k__BackingField; // rcx
		  __int64 v189; // rdx
		  HGLightShaftSettingParameters *v190; // rcx
		  __int64 v191; // rdx
		  HGLightShaftSettingParameters *v192; // rcx
		  __int64 v193; // rdx
		  HGLightShaftSettingParameters *v194; // rcx
		  __int64 v195; // rdx
		  LightShaftPassConstructor *v196; // rcx
		  __int128 v197; // xmm6
		  TextureHandle v198; // xmm7
		  int32_t v199; // ebx
		  __int128 v200; // xmm0
		  TextureHandle v201; // xmm0
		  unsigned __int64 v202; // r8
		  signed __int64 v203; // rtt
		  unsigned __int64 v204; // r8
		  signed __int64 v205; // rtt
		  __int64 v206; // rdx
		  __int64 v207; // rcx
		  HGSettingParameters *v208; // rbx
		  BasicTransformConstants *v209; // rax
		  ShaderVariablesGlobal *v210; // rax
		  __int64 v211; // rdx
		  TransparentPassConstructor *v212; // rcx
		  TextureHandle sceneColor; // xmm10
		  TextureHandle v214; // xmm8
		  Rect v215; // xmm7
		  __int128 v216; // xmm6
		  HGCamera *v217; // rbx
		  __int64 v218; // rdx
		  __int64 v219; // rcx
		  __int64 v220; // rdx
		  DistortionPassConstructor *v221; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v223; // rdx
		  __int64 v224; // rcx
		  __int64 v225; // [rsp+0h] [rbp-4CD8h] BYREF
		  MethodInfo *methoda; // [rsp+20h] [rbp-4CB8h]
		  ReflectionProbeBinningPassConstructor_PassOutput v227; // [rsp+60h] [rbp-4C78h] BYREF
		  GpuClothSimulationPassConstructor_PassInput v228; // [rsp+61h] [rbp-4C77h] BYREF
		  bool CharOutlinePassEnableState; // [rsp+62h] [rbp-4C76h]
		  OnePassDeferredPassConstructor_PassOutput v230; // [rsp+63h] [rbp-4C75h] BYREF
		  TextureHandle v231; // [rsp+70h] [rbp-4C68h] BYREF
		  FoliageOccluderPassConstructor_PassOutput v232; // [rsp+80h] [rbp-4C58h] BYREF
		  FoliageOccluderPassConstructor_PassInput v233; // [rsp+81h] [rbp-4C57h] BYREF
		  SludgePassConstructor_PassOutput v234; // [rsp+82h] [rbp-4C56h] BYREF
		  DepthOnlyPassConstructor_PassOutput v235; // [rsp+83h] [rbp-4C55h] BYREF
		  TerrainDeformPassConstructor_PassOutput v236; // [rsp+84h] [rbp-4C54h] BYREF
		  FakePlanarReflectionPass_PassOutput v237; // [rsp+85h] [rbp-4C53h] BYREF
		  OnePassDeferredPassConstructor_PassOutput v238; // [rsp+86h] [rbp-4C52h] BYREF
		  HGRenderGraph *v239; // [rsp+88h] [rbp-4C50h]
		  HGCamera *v240; // [rsp+90h] [rbp-4C48h]
		  TextureHandle lightCullResult; // [rsp+A0h] [rbp-4C38h] BYREF
		  BasicTransformConstants *basicTransformConstants[2]; // [rsp+B0h] [rbp-4C28h]
		  VolumetricCloudPassConstructor_PassOutput v243; // [rsp+C0h] [rbp-4C18h] BYREF
		  HGRenderPipeline *v244; // [rsp+C8h] [rbp-4C10h]
		  HGSettingParameters *settingParameters; // [rsp+D0h] [rbp-4C08h]
		  uint32_t viewHandle; // [rsp+D8h] [rbp-4C00h]
		  ScriptableRenderContext renderContext[2]; // [rsp+E0h] [rbp-4BF8h]
		  HGAtmosphereSettingParameters *v248; // [rsp+F0h] [rbp-4BE8h] BYREF
		  HGAtmosphereSettingParameters *v249; // [rsp+F8h] [rbp-4BE0h] BYREF
		  Rect v250; // [rsp+100h] [rbp-4BD8h] BYREF
		  TextureHandle v251; // [rsp+110h] [rbp-4BC8h] BYREF
		  CullingResults cullingResults; // [rsp+120h] [rbp-4BB8h]
		  SludgePassConstructor_PassInput v253; // [rsp+130h] [rbp-4BA8h] BYREF
		  SkyAtmospherePassConstructor_PassInput v254; // [rsp+138h] [rbp-4BA0h] BYREF
		  BakeFogLutPassConstructor_PassInput v255; // [rsp+140h] [rbp-4B98h] BYREF
		  CullingResults v256; // [rsp+148h] [rbp-4B90h]
		  _BYTE v257[24]; // [rsp+158h] [rbp-4B80h] BYREF
		  LightShaftPassConstructor_PassOutput v258; // [rsp+170h] [rbp-4B68h] BYREF
		  ReflectionProbeBinningPassConstructor_PassInput v259; // [rsp+188h] [rbp-4B50h] BYREF
		  DepthOnlyPassConstructor_PassInput v260; // [rsp+1C0h] [rbp-4B18h] BYREF
		  TransparentPassConstructor_PassOutput v261; // [rsp+1D0h] [rbp-4B08h] BYREF
		  _BYTE v262[168]; // [rsp+1E0h] [rbp-4AF8h] BYREF
		  ShadowMapPassConstructor_PassOutput v263; // [rsp+290h] [rbp-4A48h] BYREF
		  DistortionPassConstructor_PassOutput v264; // [rsp+2D0h] [rbp-4A08h] BYREF
		  ShadowMapPassConstructor_PassInput v265; // [rsp+2E0h] [rbp-49F8h] BYREF
		  __int128 v266; // [rsp+330h] [rbp-49A8h] BYREF
		  __int128 v267; // [rsp+340h] [rbp-4998h]
		  __int128 v268; // [rsp+350h] [rbp-4988h]
		  __int128 v269; // [rsp+360h] [rbp-4978h]
		  TextureHandle v270; // [rsp+370h] [rbp-4968h]
		  TextureHandle v271; // [rsp+380h] [rbp-4958h]
		  TextureHandle v272; // [rsp+390h] [rbp-4948h]
		  CullingResults v273; // [rsp+3A0h] [rbp-4938h]
		  __int128 v274; // [rsp+3C0h] [rbp-4918h]
		  __int128 v275; // [rsp+3D0h] [rbp-4908h]
		  __int128 v276; // [rsp+3E0h] [rbp-48F8h]
		  __int64 v277; // [rsp+3F0h] [rbp-48E8h]
		  float m23; // [rsp+3F8h] [rbp-48E0h]
		  HGRenderPipeline *v279; // [rsp+400h] [rbp-48D8h] BYREF
		  __int128 v280; // [rsp+408h] [rbp-48D0h]
		  __int128 v281; // [rsp+418h] [rbp-48C0h]
		  bool v282; // [rsp+428h] [rbp-48B0h]
		  float screenCullingRatio; // [rsp+42Ch] [rbp-48ACh]
		  float screenRatioCullingDistance; // [rsp+430h] [rbp-48A8h]
		  uint32_t screenCullingLayerMask; // [rsp+434h] [rbp-48A4h]
		  float v286; // [rsp+438h] [rbp-48A0h]
		  float m33; // [rsp+43Ch] [rbp-489Ch]
		  float m10; // [rsp+440h] [rbp-4898h]
		  float m20; // [rsp+444h] [rbp-4894h]
		  float m01; // [rsp+448h] [rbp-4890h]
		  float m11; // [rsp+44Ch] [rbp-488Ch]
		  float m21; // [rsp+450h] [rbp-4888h]
		  float m31; // [rsp+454h] [rbp-4884h]
		  float m02; // [rsp+458h] [rbp-4880h]
		  uint32_t v295; // [rsp+45Ch] [rbp-487Ch]
		  uint32_t v296; // [rsp+460h] [rbp-4878h]
		  float m12; // [rsp+464h] [rbp-4874h]
		  float m22; // [rsp+468h] [rbp-4870h]
		  float m13; // [rsp+46Ch] [rbp-486Ch]
		  float m30; // [rsp+470h] [rbp-4868h]
		  float m32; // [rsp+474h] [rbp-4864h]
		  float m00; // [rsp+478h] [rbp-4860h]
		  float m03; // [rsp+47Ch] [rbp-485Ch]
		  __int64 v304; // [rsp+480h] [rbp-4858h]
		  __int64 v305; // [rsp+488h] [rbp-4850h]
		  __int64 v306; // [rsp+490h] [rbp-4848h] BYREF
		  unsigned int v307; // [rsp+498h] [rbp-4840h]
		  LightClusteringPassConstructor_PassOutput_punctualLightIndices_e_FixedBuffer *p_punctualLightIndices; // [rsp+4A0h] [rbp-4838h]
		  char v309; // [rsp+4A8h] [rbp-4830h]
		  bool v310; // [rsp+4A9h] [rbp-482Fh]
		  bool v311; // [rsp+4AAh] [rbp-482Eh]
		  TextureDesc v312; // [rsp+4B0h] [rbp-4828h] BYREF
		  VolumetricCloudPassConstructor_PassInput v313; // [rsp+510h] [rbp-47C8h] BYREF
		  DepthOnlyPassConstructor_PassInput v314; // [rsp+550h] [rbp-4788h] BYREF
		  LightClusteringPassConstructor_PassInput v315; // [rsp+560h] [rbp-4778h] BYREF
		  TerrainDeformPassConstructor_PassInput v316; // [rsp+5C0h] [rbp-4718h] BYREF
		  ReflectionProbeBinningPassConstructor_PassInput v317; // [rsp+5E8h] [rbp-46F0h] BYREF
		  WaterOnePassDeferredRenderingPass_PassOutput v318; // [rsp+620h] [rbp-46B8h] BYREF
		  FakePlanarReflectionPass_PassInput v319; // [rsp+640h] [rbp-4698h] BYREF
		  LightShaftPassConstructor_PassInput v320; // [rsp+700h] [rbp-45D8h] BYREF
		  TextureHandle v321; // [rsp+730h] [rbp-45A8h] BYREF
		  TextureHandle v322; // [rsp+740h] [rbp-4598h]
		  TextureHandle v323; // [rsp+750h] [rbp-4588h]
		  TextureHandle v324; // [rsp+760h] [rbp-4578h]
		  Vector4 ScreenParams; // [rsp+770h] [rbp-4568h]
		  TextureHandle v326; // [rsp+780h] [rbp-4558h]
		  TextureHandle v327; // [rsp+790h] [rbp-4548h]
		  TextureHandle v328; // [rsp+7A0h] [rbp-4538h]
		  TextureHandle v329; // [rsp+7B0h] [rbp-4528h]
		  __int128 v330; // [rsp+7C0h] [rbp-4518h]
		  Il2CppExceptionWrapper *v331; // [rsp+7D0h] [rbp-4508h] BYREF
		  Il2CppExceptionWrapper *v332; // [rsp+7D8h] [rbp-4500h] BYREF
		  Il2CppExceptionWrapper *v333; // [rsp+7E0h] [rbp-44F8h] BYREF
		  Il2CppExceptionWrapper *v334; // [rsp+7E8h] [rbp-44F0h] BYREF
		  Il2CppExceptionWrapper *v335; // [rsp+7F0h] [rbp-44E8h] BYREF
		  Il2CppExceptionWrapper *v336; // [rsp+7F8h] [rbp-44E0h] BYREF
		  Il2CppExceptionWrapper *v337; // [rsp+800h] [rbp-44D8h] BYREF
		  Il2CppExceptionWrapper *v338; // [rsp+808h] [rbp-44D0h] BYREF
		  Il2CppExceptionWrapper *v339; // [rsp+810h] [rbp-44C8h] BYREF
		  Il2CppExceptionWrapper *v340; // [rsp+818h] [rbp-44C0h] BYREF
		  Il2CppExceptionWrapper *v341; // [rsp+820h] [rbp-44B8h] BYREF
		  Il2CppExceptionWrapper *v342; // [rsp+828h] [rbp-44B0h] BYREF
		  Il2CppExceptionWrapper *v343; // [rsp+830h] [rbp-44A8h] BYREF
		  Il2CppExceptionWrapper *v344; // [rsp+840h] [rbp-4498h] BYREF
		  Il2CppExceptionWrapper *v345; // [rsp+848h] [rbp-4490h] BYREF
		  Il2CppExceptionWrapper *v346; // [rsp+850h] [rbp-4488h] BYREF
		  Il2CppExceptionWrapper *v347; // [rsp+858h] [rbp-4480h] BYREF
		  Il2CppExceptionWrapper *v348; // [rsp+860h] [rbp-4478h] BYREF
		  Il2CppExceptionWrapper *v349; // [rsp+868h] [rbp-4470h] BYREF
		  Il2CppExceptionWrapper *v350; // [rsp+870h] [rbp-4468h] BYREF
		  Il2CppExceptionWrapper *v351; // [rsp+878h] [rbp-4460h] BYREF
		  VolumetricCloudPassConstructor_PassInput v352; // [rsp+880h] [rbp-4458h] BYREF
		  TextureDesc v353; // [rsp+8C0h] [rbp-4418h] BYREF
		  LightClusteringPassConstructor_PassInput input; // [rsp+920h] [rbp-43B8h] BYREF
		  ShadowMapPassConstructor_PassInput v355; // [rsp+980h] [rbp-4358h] BYREF
		  TextureDesc v356; // [rsp+9D0h] [rbp-4308h] BYREF
		  TextureDesc v357; // [rsp+A30h] [rbp-42A8h] BYREF
		  WaterOnePassDeferredRenderingPass_PassInput v358; // [rsp+A90h] [rbp-4248h] BYREF
		  DistortionPassConstructor_PassInput v359; // [rsp+B30h] [rbp-41A8h] BYREF
		  ParticleLightingPassConstructor_PassInput v360; // [rsp+BD0h] [rbp-4108h] BYREF
		  FakePlanarReflectionPass_PassInput v361; // [rsp+C80h] [rbp-4058h] BYREF
		  LightClusteringPassConstructor_PassOutput output; // [rsp+D40h] [rbp-3F98h] BYREF
		  unsigned int v363; // [rsp+1150h] [rbp-3B88h]
		  unsigned int v364; // [rsp+1154h] [rbp-3B84h]
		  __int64 v365; // [rsp+1158h] [rbp-3B80h]
		  __int64 v366; // [rsp+1160h] [rbp-3B78h]
		  __int64 v367; // [rsp+1168h] [rbp-3B70h]
		  OnePassDeferredPassConstructor_PassInput v368; // [rsp+1170h] [rbp-3B68h] BYREF
		  OnePassDeferredPassConstructor_PassInput v369; // [rsp+12F0h] [rbp-39E8h] BYREF
		  _OWORD v370[5]; // [rsp+1470h] [rbp-3868h] BYREF
		  HGRenderPipeline *v371; // [rsp+14C0h] [rbp-3818h] BYREF
		  int v372; // [rsp+14C8h] [rbp-3810h]
		  __int128 v373; // [rsp+14D0h] [rbp-3808h]
		  __int128 v374; // [rsp+14E0h] [rbp-37F8h]
		  _QWORD v375[9]; // [rsp+14F0h] [rbp-37E8h] BYREF
		  CullingResults v376; // [rsp+1538h] [rbp-37A0h]
		  PerObjectData__Enum bakedLightingConfig; // [rsp+1548h] [rbp-3790h]
		  float v378; // [rsp+154Ch] [rbp-378Ch]
		  bool v379; // [rsp+1550h] [rbp-3788h]
		  float v380; // [rsp+1554h] [rbp-3784h]
		  float v381; // [rsp+1558h] [rbp-3780h]
		  uint32_t v382; // [rsp+155Ch] [rbp-377Ch]
		  bool v383; // [rsp+1560h] [rbp-3778h]
		  Int32Enum__Enum v384; // [rsp+1564h] [rbp-3774h]
		  Int32Enum__Enum v385; // [rsp+1568h] [rbp-3770h]
		  GpuClothSimulationPassConstructor_PassInput v386; // [rsp+156Ch] [rbp-376Ch]
		  _BYTE v387[1312]; // [rsp+1570h] [rbp-3768h] BYREF
		  _BYTE v388[3200]; // [rsp+1A90h] [rbp-3248h] BYREF
		  _BYTE v389[395]; // [rsp+2710h] [rbp-25C8h] BYREF
		  char v390; // [rsp+289Bh] [rbp-243Dh]
		  float deltaTime; // [rsp+28B0h] [rbp-2428h]
		  List_1_HG_Rendering_Runtime_IVolumetricRenderObject_ *v392; // [rsp+2988h] [rbp-2350h]
		  TransparentPassConstructor_PassInput v393; // [rsp+39B0h] [rbp-1328h] BYREF
		  char v396; // [rsp+4CF8h] [rbp+20h] BYREF
		
		  v4 = this;
		  v396 = 0;
		  sub_18033B9D0(&input, 0LL, 88LL);
		  memset(&v317, 0, sizeof(v317));
		  memset(&v259, 0, sizeof(v259));
		  sub_18033B9D0(&v360, 0LL, 168LL);
		  v233 = 0;
		  v232 = 0;
		  v253 = 0LL;
		  v234 = 0;
		  v314 = 0LL;
		  v235 = 0;
		  v260 = 0LL;
		  sub_18033B9D0(&v355, 0LL, 80LL);
		  memset(&v263, 0, sizeof(v263));
		  sub_18033B9D0(&v265, 0LL, 80LL);
		  v254.atmosphereParams = 0LL;
		  v248 = 0LL;
		  v255.atmosphereParams = 0LL;
		  v249 = 0LL;
		  memset(&v316, 0, sizeof(v316));
		  v236 = 0;
		  v256 = 0LL;
		  memset(v257, 0, sizeof(v257));
		  sub_18033B9D0(&v361, 0LL, 184LL);
		  v237 = 0;
		  sub_18033B9D0(&v319, 0LL, 184LL);
		  sub_18033B9D0(&v368, 0LL, 384LL);
		  v230 = 0;
		  sub_18033B9D0(&v266, 0LL, 384LL);
		  sub_18033B9D0(&v369, 0LL, 384LL);
		  v238 = 0;
		  sub_18033B9D0(&v356, 0LL, 96LL);
		  sub_18033B9D0(&v312, 0LL, 96LL);
		  sub_18033B9D0(&v357, 0LL, 96LL);
		  sub_18033B9D0(&v358, 0LL, 152LL);
		  memset(&v318, 0, sizeof(v318));
		  sub_18033B9D0(&v352, 0LL, 64LL);
		  sub_18033B9D0(&v313, 0LL, 64LL);
		  sub_18033B9D0(&v353, 0LL, 96LL);
		  memset(&v320, 0, sizeof(v320));
		  memset(&v258, 0, sizeof(v258));
		  sub_18033B9D0(&v393, 0LL, 4768LL);
		  v261 = 0LL;
		  sub_18033B9D0(v370, 0LL, 4768LL);
		  sub_18033B9D0(&v359, 0LL, 152LL);
		  v264 = 0LL;
		  if ( !IFix::WrappersManagerImpl::IsPatched(3613, 0LL) )
		  {
		    hgrp = renderPathParams->hgrp;
		    v244 = hgrp;
		    if ( !hgrp )
		      sub_1800D8260(v6, v5);
		    v8 = hgrp;
		    renderGraph = HG::Rendering::Runtime::HGRenderPipeline::get_renderGraph(hgrp, 0LL);
		    v239 = renderGraph;
		    renderContext[0] = renderPathParams->renderGraphParams.scriptableRenderContext;
		    cullingResults = renderPathParams->renderRequest.cullingResults.cullingResults;
		    lightCullResult = (TextureHandle)renderPathParams->renderRequest.cullingResults.lightCullResult;
		    hgCamera = renderPathParams->renderRequest.hgCamera;
		    v240 = hgCamera;
		    settingParameters = v8->fields._settingParameters_k__BackingField;
		    p_renderRequest = &renderPathParams->renderRequest;
		    v12 = v389;
		    v13 = 5LL;
		    do
		    {
		      *v12 = *(_OWORD *)&p_renderRequest->hgCamera;
		      v12[1] = *(_OWORD *)&p_renderRequest->clearCameraSettings;
		      v12[2] = *(_OWORD *)&p_renderRequest->target.id.m_InstanceID;
		      v12[3] = *(_OWORD *)&p_renderRequest->target.id.m_MipLevel;
		      v12[4] = *(_OWORD *)&p_renderRequest->target.face;
		      v12[5] = *(_OWORD *)&p_renderRequest->target.targetDepth;
		      v12[6] = p_renderRequest->cullingResults.cullingResults;
		      v12 += 8;
		      *(v12 - 1) = *(_OWORD *)&p_renderRequest->cullingResults.customPassCullingResults.hasValue;
		      p_renderRequest = (HGRenderPipeline_RenderRequest *)((char *)p_renderRequest + 128);
		      --v13;
		    }
		    while ( v13 );
		    HG::Rendering::Runtime::HGRenderPipeline::GetColorBufferFormat(
		      v8,
		      *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m20,
		      0LL);
		    if ( !*(_QWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m20 )
		      sub_1800D8260(v15, v14);
		    volumeComponentsData = HG::Rendering::Runtime::HGCamera::get_volumeComponentsData(
		                             *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m20,
		                             0LL);
		    if ( !volumeComponentsData )
		      sub_1800D8260(v18, v17);
		    if ( !volumeComponentsData->fields.m_hgCharacterVolume )
		      sub_1800D8260(v18, v17);
		    CharOutlinePassEnableState = HG::Rendering::Runtime::HGCharacterVolume::GetCharOutlinePassEnableState(
		                                   volumeComponentsData->fields.m_hgCharacterVolume,
		                                   0LL);
		    if ( !*(_QWORD *)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m21 )
		      sub_1800D8260(v20, v19);
		    HG::Rendering::Runtime::BinningPass::Prepare(
		      *(BinningPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m21,
		      renderGraph,
		      0LL);
		    v23 = *(WaterOnePassDeferredRenderingPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevInvViewProjMatrix.m21;
		    if ( !v23 )
		      sub_1800D8260(v22, v21);
		    HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::Prepare(
		      v23,
		      hgCamera,
		      settingParameters,
		      renderContext[0],
		      0LL);
		    sub_18033B9D0(&output, 0LL, 1072LL);
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)7u,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		    basicTransformConstants[0] = 0LL;
		    basicTransformConstants[1] = (BasicTransformConstants *)&v396;
		    try
		    {
		      sub_18033B9D0(&v315, 0LL, 88LL);
		      v315.cullingResults = cullingResults;
		      v315.lightCullResult = (LightCullResult)lightCullResult;
		      v25 = *(BinningPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m21;
		      if ( !v25 )
		        sub_1800D8250(v24, 0LL);
		      v315.binningData = *HG::Rendering::Runtime::BinningPass::get_lightBinningData(
		                            (BinningPass_BinningData *)v262,
		                            v25,
		                            0LL);
		      v27 = *(BinningPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m21;
		      if ( !v27 )
		        sub_1800D8250(0LL, v26);
		      v315.binningBuffer = HG::Rendering::Runtime::BinningPass::get_binningBuffer(v27, 0LL);
		      v315.settingParams = v244->fields._settingParameters_k__BackingField;
		      if ( dword_18F35FD08 )
		      {
		        v28 = (((unsigned __int64)&v315.settingParams >> 12) & 0x1FFFFF) >> 6;
		        _m_prefetchw(&qword_18F0BCBA0[v28 + 36190]);
		        do
		          v29 = qword_18F0BCBA0[v28 + 36190];
		        while ( v29 != _InterlockedCompareExchange64(
		                         &qword_18F0BCBA0[v28 + 36190],
		                         v29 | (1LL << (((unsigned __int64)&v315.settingParams >> 12) & 0x3F)),
		                         v29) );
		      }
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
		      usePerTileDeferredLighting = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->usePerTileDeferredLighting;
		      if ( !usePerTileDeferredLighting )
		        sub_1800D8250(0LL, v30);
		      v315.outputTileResult = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabled(
		                                usePerTileDeferredLighting,
		                                0LL);
		      input = v315;
		      v33 = *(LightClusteringPassConstructor **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m20;
		      if ( !v33 )
		        sub_1800D8250(0LL, v32);
		      HG::Rendering::Runtime::LightClusteringPassConstructor::ConstructPass(
		        v33,
		        &input,
		        &output,
		        renderGraph,
		        *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m20,
		        0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v350 )
		    {
		      basicTransformConstants[0] = (BasicTransformConstants *)v350->ex;
		      if ( basicTransformConstants[0] )
		        sub_18007E1E0(basicTransformConstants[0]);
		      v4 = this;
		      renderGraph = v239;
		      hgCamera = v240;
		    }
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)2u,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		    basicTransformConstants[0] = 0LL;
		    basicTransformConstants[1] = (BasicTransformConstants *)&v396;
		    try
		    {
		      memset(&v259.binningData.tileY, 0, 40);
		      *(_OWORD *)&v259.srpContext.m_Ptr = (unsigned __int64)renderContext[0].m_Ptr;
		      v35 = *(BinningPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m21;
		      if ( !v35 )
		        sub_1800D8250(v34, 0LL);
		      v259.binningData = *HG::Rendering::Runtime::BinningPass::get_reflectionProbeBinningData(
		                            (BinningPass_BinningData *)v262,
		                            v35,
		                            0LL);
		      v37 = *(BinningPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m21;
		      if ( !v37 )
		        sub_1800D8250(0LL, v36);
		      v259.binningBuffer = HG::Rendering::Runtime::BinningPass::get_binningBuffer(v37, 0LL);
		      v259.settingParameters = settingParameters;
		      if ( dword_18F35FD08 )
		      {
		        v39 = (((unsigned __int64)&v259.settingParameters >> 12) & 0x1FFFFF) >> 6;
		        v38 = ((unsigned __int64)&v259.settingParameters >> 12) & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v39 + 36190]);
		        do
		          v40 = qword_18F0BCBA0[v39 + 36190];
		        while ( v40 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v39 + 36190], v40 | (1LL << v38), v40) );
		      }
		      v317 = v259;
		      v227 = 0;
		      v41 = *(ReflectionProbeBinningPassConstructor **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m02;
		      if ( !v41 )
		        sub_1800D8250(0LL, v38);
		      HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::ConstructPass(
		        v41,
		        &v317,
		        &v227,
		        renderGraph,
		        *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m20,
		        0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v351 )
		    {
		      basicTransformConstants[0] = (BasicTransformConstants *)v351->ex;
		      if ( basicTransformConstants[0] )
		        sub_18007E1E0(basicTransformConstants[0]);
		      v4 = this;
		      renderGraph = v239;
		      hgCamera = v240;
		    }
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)1u,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		    v231.handle = 0LL;
		    v231.fallBackResource = (ResourceHandle)&v396;
		    try
		    {
		      v43 = *(BinningPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m21;
		      if ( !v43 )
		        sub_1800D8250(0LL, v42);
		      HG::Rendering::Runtime::BinningPass::ConstructPass(
		        v43,
		        renderGraph,
		        *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m20,
		        0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v331 )
		    {
		      v231.handle = (ResourceHandle)v331->ex;
		      if ( v231.handle )
		        sub_18007E1E0(*(_QWORD *)&v231.handle);
		      v4 = this;
		      renderGraph = v239;
		      hgCamera = v240;
		    }
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)0xAu,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		    v231.handle = 0LL;
		    v231.fallBackResource = (ResourceHandle)&v396;
		    try
		    {
		      v45 = *(BinningPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m21;
		      if ( !v45 )
		        sub_1800D8250(0LL, v44);
		      *(ComputeBufferHandle *)v262 = HG::Rendering::Runtime::BinningPass::get_binningBuffer(v45, 0LL);
		      sub_18033B9D0(&v321, 0LL, 160LL);
		      if ( !hgCamera )
		        sub_1800D8250(v47, v46);
		      v321 = *(TextureHandle *)&hgCamera->fields.mainViewConstants.invViewMatrix.m00;
		      v322 = *(TextureHandle *)&hgCamera->fields.mainViewConstants.invViewMatrix.m01;
		      v323 = *(TextureHandle *)&hgCamera->fields.mainViewConstants.invViewMatrix.m02;
		      v324 = *(TextureHandle *)&hgCamera->fields.mainViewConstants.invViewMatrix.m03;
		      ScreenParams = HG::Rendering::Runtime::HGRenderPathBase::get_shaderVariablesGlobal((HGRenderPathBase *)v4, 0LL)[1]._ScreenParams;
		      v326 = *(TextureHandle *)&HG::Rendering::Runtime::HGRenderPathBase::get_shaderVariablesGlobal(
		                                  (HGRenderPathBase *)v4,
		                                  0LL)[1]._FrustumPlanes.FixedElementField;
		      v327 = *(TextureHandle *)&HG::Rendering::Runtime::HGRenderPathBase::get_shaderVariablesGlobal(
		                                  (HGRenderPathBase *)v4,
		                                  0LL)[1]._TaaFrameInfo.z;
		      v328 = *(TextureHandle *)&HG::Rendering::Runtime::HGRenderPathBase::get_shaderVariablesGlobal(
		                                  (HGRenderPathBase *)v4,
		                                  0LL)[1]._TaaJitterStrength.z;
		      v329 = *(TextureHandle *)&HG::Rendering::Runtime::HGRenderPathBase::get_shaderVariablesGlobal(
		                                  (HGRenderPathBase *)v4,
		                                  0LL)[1]._Time.z;
		      v330 = *(_OWORD *)&HG::Rendering::Runtime::HGRenderPathBase::get_shaderVariablesGlobal(
		                           (HGRenderPathBase *)v4,
		                           0LL)[1]._SinTime.z;
		      *(TextureHandle *)&v262[8] = v321;
		      *(TextureHandle *)&v262[24] = v322;
		      *(TextureHandle *)&v262[40] = v323;
		      *(TextureHandle *)&v262[56] = v324;
		      *(Vector4 *)&v262[72] = ScreenParams;
		      *(TextureHandle *)&v262[88] = v326;
		      *(TextureHandle *)&v262[104] = v327;
		      *(TextureHandle *)&v262[120] = v328;
		      *(TextureHandle *)&v262[136] = v329;
		      *(_OWORD *)&v262[152] = v330;
		      *(_OWORD *)&v360.binningBufferHandle.handle.m_Value = *(_OWORD *)v262;
		      *(_OWORD *)&v360.ivInput.invViewMatrix.m20 = *(_OWORD *)&v262[16];
		      *(_OWORD *)&v360.ivInput.invViewMatrix.m21 = *(_OWORD *)&v262[32];
		      *(_OWORD *)&v360.ivInput.invViewMatrix.m22 = *(_OWORD *)&v262[48];
		      *(_OWORD *)&v360.ivInput.invViewMatrix.m23 = *(_OWORD *)&v262[64];
		      *(_OWORD *)&v360.ivInput.IVParam0.z = *(_OWORD *)&v262[80];
		      *(_OWORD *)&v360.ivInput.IVParam1.z = *(_OWORD *)&v262[96];
		      *(_OWORD *)&v360.ivInput.IVParam2.z = *(_OWORD *)&v262[112];
		      *(_OWORD *)&v360.ivInput.IVDefaultSHAr.z = *(_OWORD *)&v262[128];
		      *(_OWORD *)&v360.ivInput.IVDefaultSHAg.z = *(_OWORD *)&v262[144];
		      *(_QWORD *)&v360.ivInput.IVDefaultSHAb.z = *((_QWORD *)&v330 + 1);
		      v227 = 0;
		      v49 = *(ParticleLightingPassConstructor **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m00;
		      if ( !v49 )
		        sub_1800D8250(0LL, v48);
		      HG::Rendering::Runtime::ParticleLightingPassConstructor::ConstructPass(
		        v49,
		        &v360,
		        (ParticleLightingPassConstructor_PassOutput *)&v227,
		        renderGraph,
		        *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m20,
		        0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v332 )
		    {
		      v231.handle = (ResourceHandle)v332->ex;
		      if ( v231.handle )
		        sub_18007E1E0(*(_QWORD *)&v231.handle);
		      v4 = this;
		      renderGraph = v239;
		      hgCamera = v240;
		    }
		    v50 = 3LL;
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)3u,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGRenderPathScene::OtherPassScope>);
		    v231.handle = 0LL;
		    v231.fallBackResource = (ResourceHandle)&v396;
		    try
		    {
		      v52 = *(WaterSectorRenderingPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevInvViewProjMatrix.m20;
		      if ( !v52 )
		        sub_1800D8250(0LL, v51);
		      HG::Rendering::Runtime::WaterSectorRenderingPass::Render(
		        v52,
		        renderGraph,
		        *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m20,
		        settingParameters,
		        0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v333 )
		    {
		      v231.handle = (ResourceHandle)v333->ex;
		      if ( v231.handle )
		        sub_18007E1E0(*(_QWORD *)&v231.handle);
		      v50 = 3LL;
		      v4 = this;
		      renderGraph = v239;
		      hgCamera = v240;
		    }
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)4u,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGRenderPathScene::OtherPassScope>);
		    v231.handle = 0LL;
		    v231.fallBackResource = (ResourceHandle)&v396;
		    try
		    {
		      v54 = *(WaterInteractionRenderingPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevInvViewProjMatrix.m01;
		      if ( !v54 )
		        sub_1800D8250(0LL, v53);
		      HG::Rendering::Runtime::WaterInteractionRenderingPass::Render(
		        v54,
		        renderGraph,
		        renderContext[0],
		        settingParameters,
		        deltaTime,
		        hgCamera,
		        0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v334 )
		    {
		      v231.handle = (ResourceHandle)v334->ex;
		      if ( v231.handle )
		        sub_18007E1E0(*(_QWORD *)&v231.handle);
		      v50 = 3LL;
		      v4 = this;
		      renderGraph = v239;
		      hgCamera = v240;
		    }
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)3u,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		    v231.handle = 0LL;
		    v231.fallBackResource = (ResourceHandle)&v396;
		    try
		    {
		      v233 = 0;
		      v232 = 0;
		      v56 = *(FoliageOccluderPassConstructor **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m22;
		      if ( !v56 )
		        sub_1800D8250(0LL, v55);
		      HG::Rendering::Runtime::FoliageOccluderPassConstructor::ConstructPass(
		        v56,
		        &v233,
		        &v232,
		        renderGraph,
		        *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m20,
		        0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v336 )
		    {
		      v231.handle = (ResourceHandle)v336->ex;
		      if ( v231.handle )
		        sub_18007E1E0(*(_QWORD *)&v231.handle);
		      v50 = 3LL;
		      v4 = this;
		      renderGraph = v239;
		      hgCamera = v240;
		    }
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)5u,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		    v231.handle = 0LL;
		    v231.fallBackResource = (ResourceHandle)&v396;
		    try
		    {
		      LODWORD(basicTransformConstants[0]) = renderPathParams->perFrameSetup.depthBits;
		      HIDWORD(basicTransformConstants[0]) = renderPathParams->perFrameSetup.depthGraphicsFormat;
		      v253 = (SludgePassConstructor_PassInput)basicTransformConstants[0];
		      v234 = 0;
		      v58 = *(SludgePassConstructor **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m03;
		      if ( !v58 )
		        sub_1800D8250(0LL, v57);
		      HG::Rendering::Runtime::SludgePassConstructor::ConstructPass(
		        v58,
		        &v253,
		        &v234,
		        renderGraph,
		        *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m20,
		        0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v337 )
		    {
		      v231.handle = (ResourceHandle)v337->ex;
		      if ( v231.handle )
		        sub_18007E1E0(*(_QWORD *)&v231.handle);
		      v50 = 3LL;
		      v4 = this;
		      renderGraph = v239;
		      hgCamera = v240;
		    }
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)6u,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		    v231.handle = 0LL;
		    v231.fallBackResource = (ResourceHandle)&v396;
		    try
		    {
		      v228 = 0;
		      v227 = 0;
		      v60 = *(GpuClothSimulationPassConstructor **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m23;
		      if ( !v60 )
		        sub_1800D8250(0LL, v59);
		      HG::Rendering::Runtime::GpuClothSimulationPassConstructor::ConstructPass(
		        v60,
		        &v228,
		        (GpuClothSimulationPassConstructor_PassOutput *)&v227,
		        renderGraph,
		        *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m20,
		        0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v346 )
		    {
		      v231.handle = (ResourceHandle)v346->ex;
		      if ( v231.handle )
		        sub_18007E1E0(*(_QWORD *)&v231.handle);
		      v50 = 3LL;
		      v4 = this;
		      renderGraph = v239;
		      hgCamera = v240;
		    }
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)0xBu,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		    basicTransformConstants[0] = 0LL;
		    basicTransformConstants[1] = (BasicTransformConstants *)&v396;
		    try
		    {
		      v260.srpContext = renderContext[0];
		      v260.customDepthOnlyRequestManger = *(CustomDepthOnlyRequestManager **)&v4[1].fields._._._.m_basicTransformConstants._PrevViewProjMatrix.m03;
		      if ( dword_18F35FD08 )
		      {
		        v62 = (((unsigned __int64)&v260.customDepthOnlyRequestManger >> 12) & 0x1FFFFF) >> 6;
		        v61 = ((unsigned __int64)&v260.customDepthOnlyRequestManger >> 12) & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v62 + 36190]);
		        do
		          v63 = qword_18F0BCBA0[v62 + 36190];
		        while ( v63 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v62 + 36190], v63 | (1LL << v61), v63) );
		      }
		      v314 = v260;
		      v235 = 0;
		      v64 = *(DepthOnlyPassConstructor **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m01;
		      if ( !v64 )
		        sub_1800D8250(0LL, v61);
		      HG::Rendering::Runtime::DepthOnlyPassConstructor::ConstructPass(
		        v64,
		        &v314,
		        &v235,
		        renderGraph,
		        *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m20,
		        0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v338 )
		    {
		      basicTransformConstants[0] = (BasicTransformConstants *)v338->ex;
		      if ( basicTransformConstants[0] )
		        sub_18007E1E0(basicTransformConstants[0]);
		      v50 = 3LL;
		      v4 = this;
		      renderGraph = v239;
		      hgCamera = v240;
		    }
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)0xCu,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		    basicTransformConstants[0] = 0LL;
		    basicTransformConstants[1] = (BasicTransformConstants *)&v396;
		    try
		    {
		      sub_18033B9D0(&v265, 0LL, 80LL);
		      v265.cullingResults = cullingResults;
		      v265.lightCullResult = (LightCullResult)lightCullResult;
		      v265.srpContext = renderContext[0];
		      v67 = *(_QWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m20;
		      if ( !v67 )
		        sub_1800D8250(v66, v65);
		      v265.shadowManager = *(HGShadowManager **)(v67 + 1848);
		      v68 = dword_18F35FD08;
		      if ( dword_18F35FD08 )
		      {
		        v69 = (((unsigned __int64)&v265 >> 12) & 0x1FFFFF) >> 6;
		        v65 = ((unsigned __int64)&v265 >> 12) & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v69 + 36190]);
		        do
		          v70 = qword_18F0BCBA0[v69 + 36190];
		        while ( v70 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v69 + 36190], v70 | (1LL << v65), v70) );
		        v68 = dword_18F35FD08;
		      }
		      *(_QWORD *)&v265.directionalLightIndex = __PAIR64__(v363, v364);
		      v265.punctualLightIndices = &output.punctualLightIndices.FixedElementField;
		      v265.settingParams = settingParameters;
		      if ( v68 )
		      {
		        v71 = (((unsigned __int64)&v265.settingParams >> 12) & 0x1FFFFF) >> 6;
		        v65 = ((unsigned __int64)&v265.settingParams >> 12) & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v71 + 36190]);
		        do
		          v72 = qword_18F0BCBA0[v71 + 36190];
		        while ( v72 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v71 + 36190], v72 | (1LL << v65), v72) );
		      }
		      v265.settingParamsCpp = renderPathParams->perFrameSetup.settingParametersCpp;
		      v355 = v265;
		      memset(&v263, 0, sizeof(v263));
		      v73 = *(ShadowMapPassConstructor **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m21;
		      if ( !v73 )
		        sub_1800D8250(0LL, v65);
		      HG::Rendering::Runtime::ShadowMapPassConstructor::ConstructPass(
		        v73,
		        &v355,
		        &v263,
		        renderGraph,
		        *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m20,
		        0LL);
		      *(ShadowMapPassConstructor_PassOutput *)&v4[1].fields._._._.m_basicTransformConstants.current._InvPretransformMatrix.m00 = v263;
		    }
		    catch ( Il2CppExceptionWrapper *v339 )
		    {
		      basicTransformConstants[0] = (BasicTransformConstants *)v339->ex;
		      if ( basicTransformConstants[0] )
		        sub_18007E1E0(basicTransformConstants[0]);
		      v50 = 3LL;
		      v4 = this;
		      renderGraph = v239;
		      hgCamera = v240;
		    }
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)0xDu,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		    basicTransformConstants[0] = 0LL;
		    basicTransformConstants[1] = (BasicTransformConstants *)&v396;
		    try
		    {
		      v248 = 0LL;
		      settingParameters_k__BackingField = v244->fields._settingParameters_k__BackingField;
		      if ( !settingParameters_k__BackingField )
		        sub_1800D8250(v75, v74);
		      atmosphereParams_k__BackingField = settingParameters_k__BackingField->fields._atmosphereParams_k__BackingField;
		      v248 = atmosphereParams_k__BackingField;
		      if ( dword_18F35FD08 )
		      {
		        v78 = (((unsigned __int64)&v248 >> 12) & 0x1FFFFF) >> 6;
		        v74 = ((unsigned __int64)&v248 >> 12) & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v78 + 36190]);
		        do
		          v79 = qword_18F0BCBA0[v78 + 36190];
		        while ( v79 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v78 + 36190], v79 | (1LL << v74), v79) );
		        atmosphereParams_k__BackingField = v248;
		      }
		      v254.atmosphereParams = atmosphereParams_k__BackingField;
		      v227 = 0;
		      v80 = *(SkyAtmospherePassConstructor **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m02;
		      if ( !v80 )
		        sub_1800D8250(0LL, v74);
		      HG::Rendering::Runtime::SkyAtmospherePassConstructor::ConstructPass(
		        v80,
		        &v254,
		        (SkyAtmospherePassConstructor_PassOutput *)&v227,
		        renderGraph,
		        *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m20,
		        0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v340 )
		    {
		      basicTransformConstants[0] = (BasicTransformConstants *)v340->ex;
		      if ( basicTransformConstants[0] )
		        sub_18007E1E0(basicTransformConstants[0]);
		      v50 = 3LL;
		      v4 = this;
		      renderGraph = v239;
		      hgCamera = v240;
		    }
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)0xFu,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		    basicTransformConstants[0] = 0LL;
		    basicTransformConstants[1] = (BasicTransformConstants *)&v396;
		    try
		    {
		      v249 = 0LL;
		      v83 = v244->fields._settingParameters_k__BackingField;
		      if ( !v83 )
		        sub_1800D8250(v82, v81);
		      v84 = v83->fields._atmosphereParams_k__BackingField;
		      v249 = v84;
		      if ( dword_18F35FD08 )
		      {
		        v85 = (((unsigned __int64)&v249 >> 12) & 0x1FFFFF) >> 6;
		        v81 = ((unsigned __int64)&v249 >> 12) & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v85 + 36190]);
		        do
		          v86 = qword_18F0BCBA0[v85 + 36190];
		        while ( v86 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v85 + 36190], v86 | (1LL << v81), v86) );
		        v84 = v249;
		      }
		      v255.atmosphereParams = v84;
		      v227 = 0;
		      v87 = *(BakeFogLutPassConstructor **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m22;
		      if ( !v87 )
		        sub_1800D8250(0LL, v81);
		      HG::Rendering::Runtime::BakeFogLutPassConstructor::ConstructPass(
		        v87,
		        &v255,
		        (BakeFogLutPassConstructor_PassOutput *)&v227,
		        renderGraph,
		        *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m20,
		        0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v341 )
		    {
		      basicTransformConstants[0] = (BasicTransformConstants *)v341->ex;
		      if ( basicTransformConstants[0] )
		        sub_18007E1E0(basicTransformConstants[0]);
		      v50 = 3LL;
		      v4 = this;
		      renderGraph = v239;
		      hgCamera = v240;
		    }
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)0x11u,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		    basicTransformConstants[0] = 0LL;
		    basicTransformConstants[1] = (BasicTransformConstants *)&v396;
		    try
		    {
		      *(_QWORD *)&v257[9] = 0LL;
		      *(_DWORD *)&v257[17] = 0;
		      *(_WORD *)&v257[21] = 0;
		      v257[23] = 0;
		      v90 = cullingResults;
		      v256 = cullingResults;
		      *(ScriptableRenderContext *)v257 = renderContext[0];
		      v257[8] = v389[392];
		      v91 = renderPathParams->hgrp;
		      if ( !v91 )
		        sub_1800D8250(v89, v88);
		      *(_QWORD *)&v257[16] = v91->fields.drawInteractionNodeMaterial;
		      if ( dword_18F35FD08 )
		      {
		        v92 = (((unsigned __int64)&v257[16] >> 12) & 0x1FFFFF) >> 6;
		        v88 = ((unsigned __int64)&v257[16] >> 12) & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v92 + 36190]);
		        do
		          v93 = qword_18F0BCBA0[v92 + 36190];
		        while ( v93 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v92 + 36190], v93 | (1LL << v88), v93) );
		        v90 = v256;
		      }
		      v316.cullingResults = v90;
		      *(_OWORD *)&v316.renderContext.m_Ptr = *(_OWORD *)v257;
		      v316.drawInteractionNodeMaterial = *(Material **)&v257[16];
		      v236 = 0;
		      v94 = *(TerrainDeformPassConstructor **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m03;
		      if ( !v94 )
		        sub_1800D8250(0LL, v88);
		      HG::Rendering::Runtime::TerrainDeformPassConstructor::ConstructPass(
		        v94,
		        &v316,
		        &v236,
		        renderGraph,
		        *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m20,
		        0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v342 )
		    {
		      basicTransformConstants[0] = (BasicTransformConstants *)v342->ex;
		      if ( basicTransformConstants[0] )
		        sub_18007E1E0(basicTransformConstants[0]);
		      v50 = 3LL;
		      v4 = this;
		      renderGraph = v239;
		      hgCamera = v240;
		    }
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)0x21u,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		    lightCullResult.handle = 0LL;
		    lightCullResult.fallBackResource = (ResourceHandle)&v396;
		    try
		    {
		      sub_18033B9D0(&v319.characterOutlineEnable + 1, 0LL, 183LL);
		      v319.characterOutlineEnable = CharOutlinePassEnableState;
		      if ( !hgCamera )
		        sub_1800D8250(v96, v95);
		      v319.screenCullingLayerMask = HG::Rendering::Runtime::HGCamera::get_screenCullingLayerMask(hgCamera, 0LL);
		      *(_QWORD *)&v319.screenCullingRatio = *(_QWORD *)&hgCamera->fields.screenCullingRatio;
		      v97 = v244;
		      v319.bakedLightingConfig = HG::Rendering::Runtime::HGRenderPipeline::get_bakedLightingConfig(v244, 0LL);
		      v319.cullingResults = cullingResults;
		      v319.shadowResult = *(ShadowResult *)&v4[1].fields._._._.m_basicTransformConstants.current._InvPretransformMatrix.m00;
		      v319.hgrp = v97;
		      if ( dword_18F35FD08 )
		      {
		        v98 = (((unsigned __int64)&v319.hgrp >> 12) & 0x1FFFFF) >> 6;
		        _m_prefetchw(&qword_18F0BCBA0[v98 + 36190]);
		        do
		          v99 = qword_18F0BCBA0[v98 + 36190];
		        while ( v99 != _InterlockedCompareExchange64(
		                         &qword_18F0BCBA0[v98 + 36190],
		                         v99 | (1LL << (((unsigned __int64)&v319.hgrp >> 12) & 0x3F)),
		                         v99) );
		      }
		      v319.renderContext = renderContext[0];
		      v319.characterPrePassECSList = LODWORD(v4[1].fields._._._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m30);
		      v319.forwardOpaquePreZECSList = LODWORD(v4[1].fields._._._.m_basicTransformConstants._PrevViewProjMatrix.m33);
		      *(_QWORD *)&v319.forwardOpaqueECSList = *(_QWORD *)&v4[1].fields._._._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m12;
		      v319.characterOpaqueECSList = LODWORD(v4[1].fields._._._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m13);
		      v319.characterOutlineOpaquePreZECSList = LODWORD(v4[1].fields._._._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m00);
		      v319.characterOutlineOpaqueECSList = LODWORD(v4[1].fields._._._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m32);
		      v319.characterOutlineOpaqueEqualECSList = LODWORD(v4[1].fields._._._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m03);
		      v319.sceneColorTexture = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewNoTransProjMatrix.m22;
		      v319.sceneDepthTexture = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewNoTransProjMatrix.m23;
		      v361 = v319;
		      v237 = 0;
		      v100 = *(FakePlanarReflectionPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevInvViewProjMatrix.m02;
		      basicTransformConstants[0] = HG::Rendering::Runtime::HGRenderPathBase::get_basicTransformConstants(
		                                     (HGRenderPathBase *)v4,
		                                     0LL);
		      shaderVariablesGlobal = HG::Rendering::Runtime::HGRenderPathBase::get_shaderVariablesGlobal(
		                                (HGRenderPathBase *)v4,
		                                0LL);
		      v103 = *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m20;
		      if ( !v100 )
		        sub_1800D8250(v103, v102);
		      HG::Rendering::Runtime::FakePlanarReflectionPass::ConstructPass(
		        v100,
		        &v361,
		        &v237,
		        basicTransformConstants[0],
		        shaderVariablesGlobal,
		        renderGraph,
		        v103,
		        settingParameters,
		        0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v343 )
		    {
		      lightCullResult.handle = (ResourceHandle)v343->ex;
		      if ( lightCullResult.handle )
		        sub_18007E1E0(*(_QWORD *)&lightCullResult.handle);
		      v50 = 3LL;
		      v4 = this;
		      renderGraph = v239;
		      hgCamera = v240;
		    }
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)0x29u,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		    lightCullResult.handle = 0LL;
		    lightCullResult.fallBackResource = (ResourceHandle)&v396;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
		    deferredDecal = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->deferredDecal;
		    if ( !deferredDecal )
		      sub_1800D8250(0LL, v104);
		    enabledForCPUCommands = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabledForCPUCommands(
		                              deferredDecal,
		                              0LL);
		    static_fields = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		    deferredErosion = static_fields->deferredErosion;
		    if ( !deferredErosion )
		      sub_1800D8250(0LL, static_fields);
		    v109 = (ReflectionProbeBinningPassConstructor_PassOutput)HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabledForCPUCommands(
		                                                               deferredErosion,
		                                                               0LL);
		    v227 = v109;
		    if ( enabledForCPUCommands )
		    {
		      v112 = *(_QWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m20;
		      if ( !v112 )
		        sub_1800D8250(0LL, v110);
		      viewHandle = *(_DWORD *)(v112 + 2592);
		      if ( !renderGraph )
		        sub_1800D8250(v112, v110);
		      HGContext = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(renderGraph, 0LL);
		      if ( !HGContext )
		        sub_1800D8250(v114, v113);
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		      viewHandle = UnityEngine::HyperGryph::HGDecalRender::CreateRendererList(
		                     viewHandle,
		                     2u,
		                     HGContext->fields.renderContext.m_Ptr,
		                     0LL,
		                     0LL);
		      RendererList = -1;
		      v109 = v227;
		    }
		    else
		    {
		      RendererList = -1;
		      viewHandle = -1;
		    }
		    if ( v109 )
		    {
		      v117 = *(_QWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m20;
		      if ( !v117 )
		        sub_1800D8250(v111, v110);
		      LODWORD(basicTransformConstants[0]) = *(_DWORD *)(v117 + 2592);
		      if ( !renderGraph )
		        sub_1800D8250(v111, v110);
		      v231.handle = (ResourceHandle)HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(renderGraph, 0LL);
		      if ( !*(_QWORD *)&v231.handle )
		        sub_1800D8250(v119, v118);
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		      v120 = *(void **)(*(_QWORD *)&v231.handle + 16LL);
		      LOWORD(methoda) = 0;
		      RendererList = UnityEngine::HyperGryph::HGMeshRender::CreateRendererList(
		                       (uint32_t)basicTransformConstants[0],
		                       HGRenderFlags__Enum_ShadowOnly|HGRenderFlags__Enum_Opaque,
		                       HGRenderFlags__Enum_Opaque,
		                       HGShaderLightMode__Enum_ErosionMobile,
		                       (HGRenderKeyword__Enum)methoda,
		                       v120,
		                       0,
		                       0,
		                       0xFFFFFFFF,
		                       0,
		                       0,
		                       0LL);
		    }
		    sub_18033B9D0(&v266, 0LL, 384LL);
		    v266 = *(_OWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewNoTransProjMatrix.m22;
		    v267 = *(_OWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewNoTransProjMatrix.m23;
		    v268 = *(_OWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._InvNonJitteredViewProjMatrix.m21;
		    v269 = *(_OWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._InvNonJitteredViewProjMatrix.m20;
		    v122 = *(FakePlanarReflectionPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevInvViewProjMatrix.m02;
		    if ( !v122 )
		      sub_1800D8250(v121, 0LL);
		    v270 = *HG::Rendering::Runtime::FakePlanarReflectionPass::get_planarReflectionTexture(
		              (TextureHandle *)v262,
		              v122,
		              0LL);
		    v124 = *(BakeFogLutPassConstructor **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m22;
		    if ( !v124 )
		      sub_1800D8250(v123, 0LL);
		    v271 = *HG::Rendering::Runtime::BakeFogLutPassConstructor::get_FogBakeLutTexture((TextureHandle *)v262, v124, 0LL);
		    v273 = cullingResults;
		    v274 = *(_OWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._InvPretransformMatrix.m00;
		    v275 = *(_OWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._InvPretransformMatrix.m01;
		    v276 = *(_OWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._InvPretransformMatrix.m02;
		    v277 = *(_QWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._InvPretransformMatrix.m03;
		    m23 = v4[1].fields._._._.m_basicTransformConstants.current._InvPretransformMatrix.m23;
		    v279 = v244;
		    if ( dword_18F35FD08 )
		    {
		      v127 = (((unsigned __int64)&v279 >> 12) & 0x1FFFFF) >> 6;
		      v125 = ((unsigned __int64)&v279 >> 12) & 0x3F;
		      _m_prefetchw(&qword_18F0BCBA0[v127 + 36190]);
		      do
		      {
		        v126 = qword_18F0BCBA0[v127 + 36190] | (1LL << v125);
		        v128 = qword_18F0BCBA0[v127 + 36190];
		      }
		      while ( v128 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v127 + 36190], v126, v128) );
		    }
		    v280 = *(_OWORD *)&v4[1].fields._._._.m_basicTransformConstants._PrevViewProjMatrix.m20;
		    v281 = *(_OWORD *)&v4[1].fields._._._.m_basicTransformConstants._PrevViewProjMatrix.m21;
		    v282 = CharOutlinePassEnableState;
		    if ( !hgCamera )
		      sub_1800D8250(v126, v125);
		    screenCullingRatio = hgCamera->fields.screenCullingRatio;
		    screenRatioCullingDistance = hgCamera->fields.screenRatioCullingDistance;
		    screenCullingLayerMask = HG::Rendering::Runtime::HGCamera::get_screenCullingLayerMask(hgCamera, 0LL);
		    v286 = v4[1].fields._._._.m_basicTransformConstants._PrevViewProjMatrix.m23;
		    m33 = v4[1].fields._._._.m_basicTransformConstants._PrevViewProjMatrix.m33;
		    m10 = v4[1].fields._._._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m10;
		    m20 = v4[1].fields._._._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m20;
		    m01 = v4[1].fields._._._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m01;
		    m11 = v4[1].fields._._._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m11;
		    m21 = v4[1].fields._._._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m21;
		    m31 = v4[1].fields._._._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m31;
		    m02 = v4[1].fields._._._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m02;
		    v295 = viewHandle;
		    v296 = RendererList;
		    m12 = v4[1].fields._._._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m12;
		    m22 = v4[1].fields._._._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m22;
		    m13 = v4[1].fields._._._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m13;
		    m30 = v4[1].fields._._._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m30;
		    m00 = v4[1].fields._._._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m00;
		    m32 = v4[1].fields._._._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m32;
		    m03 = v4[1].fields._._._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m03;
		    v307 = v363;
		    p_punctualLightIndices = &output.punctualLightIndices;
		    v304 = v365;
		    v305 = v366;
		    v306 = v367;
		    if ( dword_18F35FD08 )
		    {
		      v129 = (((unsigned __int64)&v306 >> 12) & 0x1FFFFF) >> 6;
		      _m_prefetchw(&qword_18F0BCBA0[v129 + 36190]);
		      do
		        v130 = qword_18F0BCBA0[v129 + 36190];
		      while ( v130 != _InterlockedCompareExchange64(
		                        &qword_18F0BCBA0[v129 + 36190],
		                        v130 | (1LL << (((unsigned __int64)&v306 >> 12) & 0x3F)),
		                        v130) );
		    }
		    v309 = v390;
		    currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		    if ( !currentManagerContext )
		      sub_1800D8250(v133, v132);
		    waterManager_k__BackingField = currentManagerContext->fields._waterManager_k__BackingField;
		    if ( !waterManager_k__BackingField )
		      sub_1800D8250(0LL, v132);
		    v310 = HG::Rendering::Runtime::HGWaterManager::GetTerrainRippleOpacity(waterManager_k__BackingField, 0LL) > 0.0;
		    if ( !settingParameters )
		      sub_1800D8250(v136, v135);
		    v311 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		             settingParameters->fields._terrainPOM_k__BackingField,
		             MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		    v137 = &v368;
		    v138 = (TextureHandle *)&v266;
		    v139 = 3LL;
		    do
		    {
		      v137->sceneColor = *v138;
		      v137->sceneDepth = v138[1];
		      v137->sceneDepthCopied = v138[2];
		      v137->sceneMV = v138[3];
		      v137->planarReflectionTexture = v138[4];
		      v137->fogBakeLutTexture = v138[5];
		      v137->ssrLightingTexture = v138[6];
		      v137 = (OnePassDeferredPassConstructor_PassInput *)((char *)v137 + 128);
		      *(TextureHandle *)&v137[-1].punctualLightIndices = v138[7];
		      v138 += 8;
		      --v139;
		    }
		    while ( v139 );
		    v230 = 0;
		    v140 = *(OnePassDeferredPassConstructor **)&v4[1].fields._._._.m_basicTransformConstants._PrevInvViewProjMatrix.m22;
		    v141 = *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m20;
		    if ( LOBYTE(v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m21) )
		    {
		      if ( !v140 )
		        sub_1800D8250(0LL, 0LL);
		      HG::Rendering::Runtime::OnePassDeferredPassConstructor::ConstructPassPhase0(
		        v140,
		        &v368,
		        &v230,
		        renderGraph,
		        v141,
		        0LL);
		    }
		    else
		    {
		      if ( !v140 )
		        sub_1800D8250(0LL, 0LL);
		      HG::Rendering::Runtime::OnePassDeferredPassConstructor::ConstructPass(v140, &v368, &v230, renderGraph, v141, 0LL);
		    }
		    if ( LOBYTE(v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m21) )
		    {
		      UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		        (Int32Enum__Enum)0x27u,
		        MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		      lightCullResult.handle = 0LL;
		      lightCullResult.fallBackResource = (ResourceHandle)&v396;
		      sub_18033B9D0(&v266, 0LL, 384LL);
		      try
		      {
		        v266 = *(_OWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewNoTransProjMatrix.m22;
		        v267 = *(_OWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewNoTransProjMatrix.m23;
		        v269 = *(_OWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._InvNonJitteredViewProjMatrix.m20;
		        v145 = *(FakePlanarReflectionPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevInvViewProjMatrix.m02;
		        if ( !v145 )
		          sub_1800D8250(v144, 0LL);
		        v270 = *HG::Rendering::Runtime::FakePlanarReflectionPass::get_planarReflectionTexture(
		                  (TextureHandle *)v262,
		                  v145,
		                  0LL);
		        v147 = *(HyperScreenSpaceReflectionRenderingPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m01;
		        if ( !v147 )
		          sub_1800D8250(v146, 0LL);
		        v272 = *HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::get_ssrLightingTexture(
		                  (TextureHandle *)v262,
		                  v147,
		                  0LL);
		        v273 = cullingResults;
		        v274 = *(_OWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._InvPretransformMatrix.m00;
		        v275 = *(_OWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._InvPretransformMatrix.m01;
		        v276 = *(_OWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._InvPretransformMatrix.m02;
		        v277 = *(_QWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._InvPretransformMatrix.m03;
		        m23 = v4[1].fields._._._.m_basicTransformConstants.current._InvPretransformMatrix.m23;
		        v279 = v244;
		        if ( dword_18F35FD08 )
		        {
		          v148 = (((unsigned __int64)&v279 >> 12) & 0x1FFFFF) >> 6;
		          _m_prefetchw(&qword_18F0BCBA0[v148 + 36190]);
		          do
		            v149 = qword_18F0BCBA0[v148 + 36190];
		          while ( v149 != _InterlockedCompareExchange64(
		                            &qword_18F0BCBA0[v148 + 36190],
		                            v149 | (1LL << (((unsigned __int64)&v279 >> 12) & 0x3F)),
		                            v149) );
		        }
		        v280 = *(_OWORD *)&v4[1].fields._._._.m_basicTransformConstants._PrevViewProjMatrix.m20;
		        v281 = *(_OWORD *)&v4[1].fields._._._.m_basicTransformConstants._PrevViewProjMatrix.m21;
		        v282 = CharOutlinePassEnableState;
		        screenCullingRatio = hgCamera->fields.screenCullingRatio;
		        screenRatioCullingDistance = hgCamera->fields.screenRatioCullingDistance;
		        screenCullingLayerMask = HG::Rendering::Runtime::HGCamera::get_screenCullingLayerMask(hgCamera, 0LL);
		        m12 = v4[1].fields._._._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m12;
		        m22 = v4[1].fields._._._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m22;
		        m13 = v4[1].fields._._._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m13;
		        m30 = v4[1].fields._._._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m30;
		        m00 = v4[1].fields._._._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m00;
		        m32 = v4[1].fields._._._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m32;
		        m03 = v4[1].fields._._._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m03;
		        v307 = v363;
		        p_punctualLightIndices = &output.punctualLightIndices;
		        v309 = v390;
		        v151 = &v369;
		        v152 = (TextureHandle *)&v266;
		        do
		        {
		          v151->sceneColor = *v152;
		          v151->sceneDepth = v152[1];
		          v151->sceneDepthCopied = v152[2];
		          v151->sceneMV = v152[3];
		          v151->planarReflectionTexture = v152[4];
		          v151->fogBakeLutTexture = v152[5];
		          v151->ssrLightingTexture = v152[6];
		          v151 = (OnePassDeferredPassConstructor_PassInput *)((char *)v151 + 128);
		          *(TextureHandle *)&v151[-1].punctualLightIndices = v152[7];
		          v152 += 8;
		          --v50;
		        }
		        while ( v50 );
		        v238 = 0;
		        v153 = *(OnePassDeferredPassConstructor **)&v4[1].fields._._._.m_basicTransformConstants._PrevInvViewProjMatrix.m22;
		        if ( !v153 )
		          sub_1800D8250(0LL, v150);
		        HG::Rendering::Runtime::OnePassDeferredPassConstructor::ConstructPassPhase1(
		          v153,
		          &v369,
		          &v238,
		          renderGraph,
		          *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m20,
		          0LL);
		      }
		      catch ( Il2CppExceptionWrapper *v344 )
		      {
		        v142 = (unsigned __int64)&v225;
		        lightCullResult.handle = (ResourceHandle)v344->ex;
		        handle = (HGCamera *)lightCullResult.handle;
		        if ( lightCullResult.handle )
		          sub_18007E1E0(*(_QWORD *)&lightCullResult.handle);
		        v4 = this;
		        renderGraph = v239;
		        hgCamera = v240;
		      }
		    }
		    if ( !settingParameters )
		      goto LABEL_352;
		    v154 = (GpuClothSimulationPassConstructor_PassInput)HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                                                          settingParameters->fields._transparentLowResOffscreenEnable_k__BackingField,
		                                                          MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		    v228 = v154;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVFXManager);
		    if ( !HG::Rendering::Runtime::HGVFXManager::get_instance(0LL) )
		      goto LABEL_178;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVFXManager);
		    instance = HG::Rendering::Runtime::HGVFXManager::get_instance(0LL);
		    if ( !instance )
		      goto LABEL_352;
		    if ( HG::Rendering::Runtime::HGVFXManager::UseSceneSaturationColorAdjustment(instance, 0LL) )
		    {
		      v154 = 0;
		      v228 = 0;
		    }
		    else
		    {
		LABEL_178:
		      if ( v154 )
		      {
		        if ( !hgCamera )
		          goto LABEL_352;
		        HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
		          &v312,
		          hgCamera->fields._sceneRTSize_k__BackingField.m_X / 2,
		          (int)HIDWORD(*(_QWORD *)&hgCamera->fields._sceneRTSize_k__BackingField) / 2,
		          0LL);
		        v312.colorFormat = renderPathParams->perFrameSetup.depthGraphicsFormat;
		        v312.depthBufferBits = renderPathParams->perFrameSetup.depthBits;
		        v312.name = (String *)"LowRes Depth";
		        if ( dword_18F35FD08 )
		        {
		          v157 = (((unsigned __int64)&v312.name >> 12) & 0x1FFFFF) >> 6;
		          v142 = ((unsigned __int64)&v312.name >> 12) & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v157 + 36190]);
		          do
		          {
		            handle = (HGCamera *)(qword_18F0BCBA0[v157 + 36190] | (1LL << v142));
		            v158 = qword_18F0BCBA0[v157 + 36190];
		          }
		          while ( v158 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v157 + 36190], (signed __int64)handle, v158) );
		        }
		        v356 = v312;
		        if ( !renderGraph )
		          goto LABEL_352;
		        *(TextureHandle *)basicTransformConstants = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                                                       (TextureHandle *)v262,
		                                                       renderGraph,
		                                                       &v356,
		                                                       0LL);
		        handle = *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m20;
		        if ( !handle )
		          goto LABEL_352;
		        if ( HG::Rendering::Runtime::HGCamera::ShouldRenderWater(handle, 0LL) )
		        {
		          HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
		            &v312,
		            hgCamera->fields._sceneRTSize_k__BackingField.m_X / 2,
		            (int)HIDWORD(*(_QWORD *)&hgCamera->fields._sceneRTSize_k__BackingField) / 2,
		            0LL);
		          v312.colorFormat = 49;
		          v357 = v312;
		          nullHandle = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                         (TextureHandle *)v262,
		                         renderGraph,
		                         &v357,
		                         0LL);
		        }
		        else
		        {
		          sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		          nullHandle = HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle((TextureHandle *)v262, 0LL);
		        }
		        lightCullResult = *nullHandle;
		        v160 = lightCullResult;
		        v161 = *(Rect *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewNoTransProjMatrix.m23;
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		        IsValid = HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&lightCullResult, 0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::LowResBlitPass);
		        v251 = v160;
		        v231 = *(TextureHandle *)basicTransformConstants;
		        v250 = v161;
		        HG::Rendering::Runtime::LowResBlitPass::DownsampleDepth(
		          renderGraph,
		          (TextureHandle *)&v250,
		          &v231,
		          &v251,
		          (DownsampleDepthOutput__Enum)(IsValid + 1),
		          0LL);
		        v156 = lightCullResult;
		        goto LABEL_190;
		      }
		    }
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		    *(TextureHandle *)basicTransformConstants = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(
		                                                   (TextureHandle *)v262,
		                                                   0LL);
		    v156 = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle((TextureHandle *)v262, 0LL);
		LABEL_190:
		    v142 = *(_QWORD *)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m01;
		    if ( !v142 )
		      goto LABEL_352;
		    v231 = *HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::get_ssrLightingTexture(
		              (TextureHandle *)v262,
		              (HyperScreenSpaceReflectionRenderingPass *)v142,
		              0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		    if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&v231, 0LL) )
		    {
		      v169 = *(WaterOnePassDeferredRenderingPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevInvViewProjMatrix.m21;
		      v142 = *(_QWORD *)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m01;
		      if ( !v142 )
		        goto LABEL_352;
		      ssrLightingTexture = HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::get_ssrLightingTexture(
		                             (TextureHandle *)v262,
		                             (HyperScreenSpaceReflectionRenderingPass *)v142,
		                             0LL);
		      if ( !v169 )
		        goto LABEL_352;
		      v250 = (Rect)*ssrLightingTexture;
		      HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::set_reflectionLightingTexture(
		        v169,
		        (TextureHandle *)&v250,
		        0LL);
		    }
		    else
		    {
		      UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		        (Int32Enum__Enum)5u,
		        MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGRenderPathScene::OtherPassScope>);
		      lightCullResult.handle = 0LL;
		      lightCullResult.fallBackResource = (ResourceHandle)&v396;
		      try
		      {
		        sub_18033B9D0(&v321, 0LL, 152LL);
		        v165 = *(TextureHandle **)&v4[1].fields._._._.m_basicTransformConstants._PrevInvViewProjMatrix.m20;
		        if ( !v165 )
		          sub_1800D8250(v164, v163);
		        v321 = v165[2];
		        v166 = *(WaterInteractionRenderingPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevInvViewProjMatrix.m01;
		        if ( !v166 )
		          sub_1800D8250(v164, 0LL);
		        v322 = *HG::Rendering::Runtime::WaterInteractionRenderingPass::get_interactionTexture(
		                  (TextureHandle *)v262,
		                  v166,
		                  0LL);
		        v323 = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewNoTransProjMatrix.m22;
		        ScreenParams = *(Vector4 *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewNoTransProjMatrix.m23;
		        v326 = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._InvNonJitteredViewProjMatrix.m21;
		        v328 = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._InvNonJitteredViewProjMatrix.m20;
		        *(ScriptableRenderContext *)&v330 = renderContext[0];
		        v327 = v156;
		        v358.sectorTexture = v321;
		        v358.interactionTexture = v322;
		        v358.sceneColor = v323;
		        v358.sceneColorCopied = v324;
		        v358.sceneDepth = (TextureHandle)ScreenParams;
		        v358.sceneDepthCopied = v326;
		        v358.lowResSceneDepth = v156;
		        v358.sceneMV = v328;
		        v358.gBufferATexture = v329;
		        v358.srpContext = renderContext[0];
		        memset(&v318, 0, sizeof(v318));
		        v168 = *(WaterOnePassDeferredRenderingPass **)&v4[1].fields._._._.m_basicTransformConstants._PrevInvViewProjMatrix.m21;
		        if ( !v168 )
		          sub_1800D8250(0LL, v167);
		        HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::RenderReflectPass(
		          v168,
		          &v358,
		          &v318,
		          renderGraph,
		          hgCamera,
		          settingParameters,
		          0LL);
		      }
		      catch ( Il2CppExceptionWrapper *v345 )
		      {
		        lightCullResult.handle = (ResourceHandle)v345->ex;
		        if ( lightCullResult.handle )
		          sub_18007E1E0(*(_QWORD *)&lightCullResult.handle);
		        v4 = this;
		        renderGraph = v239;
		        hgCamera = v240;
		        v154 = v228;
		      }
		    }
		    v227 = 0;
		    sub_18033B9D0(&v313, 0LL, 64LL);
		    v313.sceneColor = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewNoTransProjMatrix.m22;
		    v313.sceneDepth = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewNoTransProjMatrix.m23;
		    v313.sceneDepthCopied = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._InvNonJitteredViewProjMatrix.m21;
		    v171 = v244->fields._settingParameters_k__BackingField;
		    if ( v171 )
		    {
		      v313.volumetricParameters = v171->fields._volumetricCloud_k__BackingField;
		      v172 = dword_18F35FD08;
		      if ( dword_18F35FD08 )
		      {
		        v173 = (((unsigned __int64)&v313.volumetricParameters >> 12) & 0x1FFFFF) >> 6;
		        v142 = ((unsigned __int64)&v313.volumetricParameters >> 12) & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v173 + 36190]);
		        do
		          v174 = qword_18F0BCBA0[v173 + 36190];
		        while ( v174 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v173 + 36190], v174 | (1LL << v142), v174) );
		        v172 = dword_18F35FD08;
		      }
		      v313.volumetricRenderObjects = v392;
		      if ( v172 )
		      {
		        v175 = (((unsigned __int64)&v313.volumetricRenderObjects >> 12) & 0x1FFFFF) >> 6;
		        v142 = ((unsigned __int64)&v313.volumetricRenderObjects >> 12) & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v175 + 36190]);
		        do
		          v176 = qword_18F0BCBA0[v175 + 36190];
		        while ( v176 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v175 + 36190], v176 | (1LL << v142), v176) );
		      }
		      v352 = v313;
		      handle = *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants._PrevInvViewProjMatrix.m03;
		      if ( handle )
		      {
		        if ( HG::Rendering::Runtime::VolumetricCloudPassConstructor::ShouldRenderVolumetricCloud(
		               (VolumetricCloudPassConstructor *)handle,
		               &v352,
		               0LL) )
		        {
		          v177 = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewNoTransProjMatrix.m23;
		          v178 = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._InvNonJitteredViewProjMatrix.m21;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		          CameraDepthTexture = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CameraDepthTexture;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
		          v250 = 0LL;
		          v251 = v178;
		          lightCullResult = v177;
		          HG::Rendering::Runtime::CopyTexturePass::BlitTexture(
		            renderGraph,
		            &lightCullResult,
		            &v251,
		            0,
		            CameraDepthTexture,
		            0,
		            &v250,
		            0,
		            0LL);
		          v227 = (ReflectionProbeBinningPassConstructor_PassOutput)1;
		        }
		        UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		          (Int32Enum__Enum)0x10u,
		          MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		        lightCullResult.handle = 0LL;
		        lightCullResult.fallBackResource = (ResourceHandle)&v396;
		        try
		        {
		          v243 = 0;
		          v181 = *(VolumetricCloudPassConstructor **)&v4[1].fields._._._.m_basicTransformConstants._PrevInvViewProjMatrix.m03;
		          if ( !v181 )
		            sub_1800D8250(0LL, v180);
		          HG::Rendering::Runtime::VolumetricCloudPassConstructor::ConstructPass(
		            v181,
		            &v352,
		            &v243,
		            renderGraph,
		            *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m20,
		            0LL);
		        }
		        catch ( Il2CppExceptionWrapper *v335 )
		        {
		          lightCullResult.handle = (ResourceHandle)v335->ex;
		          if ( lightCullResult.handle )
		            sub_18007E1E0(*(_QWORD *)&lightCullResult.handle);
		          v4 = this;
		          renderGraph = v239;
		          hgCamera = v240;
		          v154 = v228;
		        }
		        if ( !*(_BYTE *)&v154
		          || (v231 = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._InvNonJitteredViewProjMatrix.m20,
		              sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle),
		              !HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&v231, 0LL)) )
		        {
		          sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		          v182 = HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle((TextureHandle *)v262, 0LL);
		          goto LABEL_224;
		        }
		        v231 = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._InvNonJitteredViewProjMatrix.m20;
		        if ( renderGraph )
		        {
		          v353 = *HG::Rendering::RenderGraphModule::HGRenderGraph::GetTextureDesc(
		                    (TextureDesc *)v262,
		                    renderGraph,
		                    &v231,
		                    0LL);
		          if ( hgCamera )
		          {
		            v353.width = hgCamera->fields._sceneRTSize_k__BackingField.m_X / 2;
		            v353.height = (int)HIDWORD(*(_QWORD *)&hgCamera->fields._sceneRTSize_k__BackingField) / 2;
		            v182 = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                     (TextureHandle *)v262,
		                     renderGraph,
		                     &v353,
		                     0LL);
		LABEL_224:
		            v183 = *v182;
		            *(TextureHandle *)&renderContext[0].m_Ptr = *v182;
		            sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		            v251 = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle((TextureHandle *)v262, 0LL);
		            UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		              (Int32Enum__Enum)0x2Bu,
		              MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		            lightCullResult.handle = 0LL;
		            lightCullResult.fallBackResource = (ResourceHandle)&v396;
		            try
		            {
		              memset(v262, 0, 48);
		              v185 = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewNoTransProjMatrix.m22;
		              v186 = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewNoTransProjMatrix.m23;
		              v187 = settingParameters;
		              lightShaft_k__BackingField = settingParameters->fields._lightShaft_k__BackingField;
		              if ( !lightShaft_k__BackingField )
		                sub_1800D8250(0LL, v184);
		              v262[32] = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                           lightShaft_k__BackingField->fields.enableLightShaft,
		                           MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		              v190 = v187->fields._lightShaft_k__BackingField;
		              if ( !v190 )
		                sub_1800D8250(0LL, v189);
		              *(_DWORD *)&v262[36] = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                                       v190->fields.lightShaftDownSampleFactor,
		                                       MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		              v192 = v187->fields._lightShaft_k__BackingField;
		              if ( !v192 )
		                sub_1800D8250(0LL, v191);
		              *(_DWORD *)&v262[40] = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		                                       (SettingParameter_1_System_Int32Enum_ *)v192->fields.lightShaftSampleNum,
		                                       MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		              v194 = v187->fields._lightShaft_k__BackingField;
		              if ( !v194 )
		                sub_1800D8250(0LL, v193);
		              *(_DWORD *)&v262[44] = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		                                       (SettingParameter_1_System_Int32Enum_ *)v194->fields.lightShaftBlurPassCount,
		                                       MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		              v320.sceneColor = v185;
		              v320.sceneDepth = v186;
		              *(_OWORD *)&v320.enableLightShaft = *(_OWORD *)&v262[32];
		              memset(&v258, 0, sizeof(v258));
		              v196 = *(LightShaftPassConstructor **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m00;
		              if ( !v196 )
		                sub_1800D8250(0LL, v195);
		              HG::Rendering::Runtime::LightShaftPassConstructor::ConstructPass(
		                v196,
		                &v320,
		                &v258,
		                renderGraph,
		                *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m20,
		                0LL);
		              *(LightShaftPassConstructor_PassOutput *)&v4[1].fields._._._.m_basicTransformConstants.current._InvPretransformMatrix.m33 = v258;
		            }
		            catch ( Il2CppExceptionWrapper *v347 )
		            {
		              lightCullResult.handle = (ResourceHandle)v347->ex;
		              if ( lightCullResult.handle )
		                sub_18007E1E0(*(_QWORD *)&lightCullResult.handle);
		              v4 = this;
		              renderGraph = v239;
		              hgCamera = v240;
		              v154 = v228;
		              v183 = *(TextureHandle *)&renderContext[0].m_Ptr;
		            }
		            UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		              (Int32Enum__Enum)0x28u,
		              MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		            lightCullResult.handle = 0LL;
		            lightCullResult.fallBackResource = (ResourceHandle)&v396;
		            try
		            {
		              if ( !*(_BYTE *)&v227 )
		              {
		                v197 = *(_OWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewNoTransProjMatrix.m23;
		                v198 = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._InvNonJitteredViewProjMatrix.m21;
		                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		                v199 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CameraDepthTexture;
		                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
		                v250 = 0LL;
		                v231 = v198;
		                *(_OWORD *)v262 = v197;
		                HG::Rendering::Runtime::CopyTexturePass::BlitTexture(
		                  renderGraph,
		                  (TextureHandle *)v262,
		                  &v231,
		                  0,
		                  v199,
		                  0,
		                  &v250,
		                  0,
		                  0LL);
		              }
		              sub_18033B9D0(v370, 0LL, 4768LL);
		              v370[0] = *(_OWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewNoTransProjMatrix.m22;
		              if ( v154 )
		                v200 = *(_OWORD *)basicTransformConstants;
		              else
		                v200 = *(_OWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewNoTransProjMatrix.m23;
		              v370[1] = v200;
		              v370[4] = *(_OWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._InvNonJitteredViewProjMatrix.m21;
		              if ( v154 )
		                v201 = v183;
		              else
		                v201 = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._InvNonJitteredViewProjMatrix.m20;
		              v370[2] = v201;
		              v370[3] = *(_OWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._InvNonJitteredViewProjMatrix.m21;
		              v371 = v244;
		              if ( dword_18F35FD08 )
		              {
		                v202 = (((unsigned __int64)&v371 >> 12) & 0x1FFFFF) >> 6;
		                _m_prefetchw(&qword_18F0BCBA0[v202 + 36190]);
		                do
		                  v203 = qword_18F0BCBA0[v202 + 36190];
		                while ( v203 != _InterlockedCompareExchange64(
		                                  &qword_18F0BCBA0[v202 + 36190],
		                                  v203 | (1LL << (((unsigned __int64)&v371 >> 12) & 0x3F)),
		                                  v203) );
		              }
		              v372 = sub_180002F70(18LL, v4);
		              v373 = *(_OWORD *)&v4[1].fields._._._.m_basicTransformConstants._PrevViewProjMatrix.m20;
		              v374 = *(_OWORD *)&v4[1].fields._._._.m_basicTransformConstants._PrevViewProjMatrix.m21;
		              v375[0] = *(_QWORD *)&v4[1].fields._._._.m_basicTransformConstants._PrevInvViewProjMatrix.m21;
		              if ( dword_18F35FD08 )
		              {
		                v204 = (((unsigned __int64)v375 >> 12) & 0x1FFFFF) >> 6;
		                _m_prefetchw(&qword_18F0BCBA0[v204 + 36190]);
		                do
		                  v205 = qword_18F0BCBA0[v204 + 36190];
		                while ( v205 != _InterlockedCompareExchange64(
		                                  &qword_18F0BCBA0[v204 + 36190],
		                                  v205 | (1LL << (((unsigned __int64)v375 >> 12) & 0x3F)),
		                                  v205) );
		              }
		              v376 = cullingResults;
		              bakedLightingConfig = HG::Rendering::Runtime::HGRenderPipeline::get_bakedLightingConfig(v244, 0LL);
		              v378 = v4[1].fields._._._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m23;
		              v379 = CharOutlinePassEnableState;
		              if ( !hgCamera )
		                sub_1800D8250(v207, v206);
		              v380 = hgCamera->fields.screenCullingRatio;
		              v381 = hgCamera->fields.screenRatioCullingDistance;
		              v382 = HG::Rendering::Runtime::HGCamera::get_screenCullingLayerMask(hgCamera, 0LL);
		              v208 = settingParameters;
		              v383 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                       settingParameters->fields._transparentLowResVRSEnable_k__BackingField,
		                       MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		              v384 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		                       (SettingParameter_1_System_Int32Enum_ *)v208->fields._transparentVRRx_k__BackingField,
		                       MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		              v385 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		                       (SettingParameter_1_System_Int32Enum_ *)v208->fields._transparentVRRy_k__BackingField,
		                       MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		              v386 = v154;
		              v209 = HG::Rendering::Runtime::HGRenderPathBase::get_basicTransformConstants((HGRenderPathBase *)v4, 0LL);
		              sub_18033B330(v387, v209, 1312LL);
		              v210 = HG::Rendering::Runtime::HGRenderPathBase::get_shaderVariablesGlobal((HGRenderPathBase *)v4, 0LL);
		              sub_18033B330(v388, v210, 3200LL);
		              sub_18033B330(v389, v370, 4768LL);
		              sub_18033B330(&v393, v389, 4768LL);
		              v261 = 0LL;
		              v212 = *(TransparentPassConstructor **)&v4[1].fields._._._.m_basicTransformConstants._PrevInvViewProjMatrix.m23;
		              if ( !v212 )
		                sub_1800D8250(0LL, v211);
		              HG::Rendering::Runtime::TransparentPassConstructor::ConstructPass(
		                v212,
		                &v393,
		                &v261,
		                renderGraph,
		                *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m20,
		                0LL);
		            }
		            catch ( Il2CppExceptionWrapper *v348 )
		            {
		              lightCullResult.handle = (ResourceHandle)v348->ex;
		              if ( lightCullResult.handle )
		                sub_18007E1E0(*(_QWORD *)&lightCullResult.handle);
		              v4 = this;
		              renderGraph = v239;
		              hgCamera = v240;
		              if ( !*(_BYTE *)&v228 )
		                goto LABEL_258;
		              v183 = *(TextureHandle *)&renderContext[0].m_Ptr;
		              sceneColor = v251;
		              goto LABEL_257;
		            }
		            if ( !*(_BYTE *)&v154 )
		            {
		              *(TransparentPassConstructor_PassOutput *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewNoTransProjMatrix.m22 = v261;
		              goto LABEL_258;
		            }
		            sceneColor = v261.sceneColor;
		            v251 = v261.sceneColor;
		LABEL_257:
		            v214 = *(TextureHandle *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewNoTransProjMatrix.m22;
		            v215 = *(Rect *)&v4[1].fields._._._.m_basicTransformConstants.current._InvNonJitteredViewProjMatrix.m20;
		            v216 = *(_OWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewNoTransProjMatrix.m23;
		            v217 = *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m20;
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::LowResBlitPass);
		            *(_OWORD *)v262 = v216;
		            v250 = v215;
		            v251 = v214;
		            lightCullResult = v183;
		            v231 = sceneColor;
		            HG::Rendering::Runtime::LowResBlitPass::UpsampleColorAndMV(
		              renderGraph,
		              &v231,
		              &lightCullResult,
		              &v251,
		              (TextureHandle *)&v250,
		              (TextureHandle *)v262,
		              v217,
		              0LL);
		LABEL_258:
		            UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		              (Int32Enum__Enum)0x2Au,
		              MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		            lightCullResult.handle = 0LL;
		            lightCullResult.fallBackResource = (ResourceHandle)&v396;
		            try
		            {
		              sub_18033B9D0(v262, 0LL, 152LL);
		              *(_OWORD *)v262 = *(_OWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewNoTransProjMatrix.m22;
		              *(_OWORD *)&v262[16] = *(_OWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewNoTransProjMatrix.m23;
		              *(_OWORD *)&v262[32] = *(_OWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._InvNonJitteredViewProjMatrix.m20;
		              *(_OWORD *)&v262[48] = *(_OWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._InvPretransformMatrix.m00;
		              *(_OWORD *)&v262[64] = *(_OWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._InvPretransformMatrix.m01;
		              *(_OWORD *)&v262[80] = *(_OWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._InvPretransformMatrix.m02;
		              *(_QWORD *)&v262[96] = *(_QWORD *)&v4[1].fields._._._.m_basicTransformConstants.current._InvPretransformMatrix.m03;
		              *(float *)&v262[104] = v4[1].fields._._._.m_basicTransformConstants.current._InvPretransformMatrix.m23;
		              *(CullingResults *)&v262[112] = cullingResults;
		              *(_DWORD *)&v262[128] = HG::Rendering::Runtime::HGRenderPipeline::get_bakedLightingConfig(v244, 0LL);
		              if ( !hgCamera )
		                sub_1800D8250(v219, v218);
		              *(float *)&v262[132] = hgCamera->fields.screenCullingRatio;
		              *(float *)&v262[136] = hgCamera->fields.screenRatioCullingDistance;
		              *(_DWORD *)&v262[140] = HG::Rendering::Runtime::HGCamera::get_screenCullingLayerMask(hgCamera, 0LL);
		              *(float *)&v262[144] = v4[1].fields._._._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m33;
		              v359 = *(DistortionPassConstructor_PassInput *)v262;
		              v264 = 0LL;
		              v221 = *(DistortionPassConstructor **)&v4[1].fields._._._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m20;
		              if ( !v221 )
		                sub_1800D8250(0LL, v220);
		              HG::Rendering::Runtime::DistortionPassConstructor::ConstructPass(
		                v221,
		                &v359,
		                &v264,
		                renderGraph,
		                *(HGCamera **)&v4[1].fields._._._.m_basicTransformConstants.current._InvViewProjMatrix.m20,
		                0LL);
		              *(DistortionPassConstructor_PassOutput *)&v4[1].fields._._._.m_basicTransformConstants.current._NonJitteredViewNoTransProjMatrix.m22 = v264;
		            }
		            catch ( Il2CppExceptionWrapper *v349 )
		            {
		              lightCullResult.handle = (ResourceHandle)v349->ex;
		              if ( lightCullResult.handle )
		                sub_18007E1E0(*(_QWORD *)&lightCullResult.handle);
		            }
		            return;
		          }
		        }
		      }
		    }
		LABEL_352:
		    sub_1800D8250(handle, v142);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3613, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v224, v223);
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
