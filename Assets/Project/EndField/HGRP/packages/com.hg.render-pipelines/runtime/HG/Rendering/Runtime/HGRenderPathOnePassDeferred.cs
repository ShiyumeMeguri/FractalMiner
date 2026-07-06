using System;

namespace HG.Rendering.Runtime
{
	internal class HGRenderPathOnePassDeferred : HGRenderPathDeferred
	{
		internal HGRenderPathOnePassDeferred(HGRenderPathBase.HGRenderPathResources resources, HGCamera camera, HGRenderPathInternal renderPath)
		{
			// // HGRenderPathOnePassDeferred(HGRenderPathBase+HGRenderPathResources, HGCamera, HGRenderPathInternal)
			// void HG::Rendering::Runtime::HGRenderPathOnePassDeferred::HGRenderPathOnePassDeferred(
			//         HGRenderPathOnePassDeferred *this,
			//         HGRenderPathBase_HGRenderPathResources *resources,
			//         HGCamera *camera,
			//         HGRenderPathInternal__Enum renderPath,
			//         MethodInfo *method)
			// {
			//   PassConstructorID__Enum__Array *v9; // rax
			//   IPassConstructor *PassConstructor; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v11; // rdx
			//   HGCamera *v12; // r8
			//   HGCamera *v13; // r9
			//   IPassConstructor *v14; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v15; // rdx
			//   HGCamera *v16; // r8
			//   HGCamera *v17; // r9
			//   IPassConstructor *v18; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v19; // rdx
			//   HGCamera *v20; // r8
			//   HGCamera *v21; // r9
			//   IPassConstructor *v22; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v23; // rdx
			//   HGCamera *v24; // r8
			//   HGCamera *v25; // r9
			//   IPassConstructor *v26; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v27; // rdx
			//   HGCamera *v28; // r8
			//   HGCamera *v29; // r9
			//   IPassConstructor *v30; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v31; // rdx
			//   HGCamera *v32; // r8
			//   HGCamera *v33; // r9
			//   IPassConstructor *v34; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v35; // rdx
			//   HGCamera *v36; // r8
			//   HGCamera *v37; // r9
			//   IPassConstructor *v38; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v39; // rdx
			//   HGCamera *v40; // r8
			//   HGCamera *v41; // r9
			//   IPassConstructor *v42; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v43; // rdx
			//   HGCamera *v44; // r8
			//   HGCamera *v45; // r9
			//   IPassConstructor *v46; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v47; // rdx
			//   HGCamera *v48; // r8
			//   HGCamera *v49; // r9
			//   IPassConstructor *v50; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v51; // rdx
			//   HGCamera *v52; // r8
			//   HGCamera *v53; // r9
			//   IPassConstructor *v54; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v55; // rdx
			//   HGCamera *v56; // r8
			//   HGCamera *v57; // r9
			//   IPassConstructor *v58; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v59; // rdx
			//   HGCamera *v60; // r8
			//   HGCamera *v61; // r9
			//   IPassConstructor *v62; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v63; // rdx
			//   HGCamera *v64; // r8
			//   HGCamera *v65; // r9
			//   IPassConstructor *v66; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v67; // rdx
			//   HGCamera *v68; // r8
			//   HGCamera *v69; // r9
			//   IPassConstructor *v70; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v71; // rdx
			//   HGCamera *v72; // r8
			//   HGCamera *v73; // r9
			//   IPassConstructor *v74; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v75; // rdx
			//   HGCamera *v76; // r8
			//   HGCamera *v77; // r9
			//   IPassConstructor *v78; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v79; // rdx
			//   HGCamera *v80; // r8
			//   HGCamera *v81; // r9
			//   IPassConstructor *v82; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v83; // rdx
			//   HGCamera *v84; // r8
			//   HGCamera *v85; // r9
			//   IPassConstructor *v86; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v87; // rdx
			//   HGCamera *v88; // r8
			//   HGCamera *v89; // r9
			//   IPassConstructor *v90; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v91; // rdx
			//   HGCamera *v92; // r8
			//   HGCamera *v93; // r9
			//   IPassConstructor *v94; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v95; // rdx
			//   HGCamera *v96; // r8
			//   HGCamera *v97; // r9
			//   IPassConstructor *v98; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v99; // rdx
			//   HGCamera *v100; // r8
			//   HGCamera *v101; // r9
			//   IPassConstructor *v102; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v103; // rdx
			//   HGCamera *v104; // r8
			//   HGCamera *v105; // r9
			//   MethodInfo *v106; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v107; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v108; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v109; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v110; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v111; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v112; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v113; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v114; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v115; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v116; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v117; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v118; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v119; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v120; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v121; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v122; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v123; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v124; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v125; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v126; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v127; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v128; // [rsp+20h] [rbp-28h]
			//   HGRenderPathBase_HGRenderPathResources v129; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D919655 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::BakeFogLutPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::BinningPass);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::DepthOnlyPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::DistortionPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::FakePlanarReflectionPass);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::LightClusteringPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::LightShaftPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ParticleLightingPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ShadowMapPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::SkyAtmospherePassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::SludgePassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::TerrainDeformPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::TerrainDepthPrepassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::TerrainVTBakePassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::TransparentPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricCloudPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::WaterInteractionRenderingPass);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::WaterSectorRenderingPass);
			//     byte_18D919655 = 1;
			//   }
			//   v9 = HG::Rendering::Runtime::HGRenderPathOnePassDeferred::PopulatePassConstructorIds(0LL);
			//   v129 = *resources;
			//   HG::Rendering::Runtime::HGRenderPathDeferred::HGRenderPathDeferred(
			//     (HGRenderPathDeferred *)this,
			//     &v129,
			//     v9,
			//     camera,
			//     renderPath,
			//     0LL);
			//   PassConstructor = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//                       (HGRenderPathBase *)this,
			//                       PassConstructorID__Enum_BinningPass,
			//                       0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m21 = sub_18003F5A0(
			//                                                                                                   PassConstructor,
			//                                                                                                   TypeInfo::HG::Rendering::Runtime::BinningPass);
			//   sub_18003F5A0(PassConstructor, TypeInfo::HG::Rendering::Runtime::BinningPass);
			//   sub_1800054D0((HGRenderPathOnePassDeferred *)((char *)this + 5072), v11, v12, v13, v106);
			//   v14 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_ReflectionProbeBinning,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m02 = sub_18003F5A0(
			//                                                                                                   v14,
			//                                                                                                   TypeInfo::HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor);
			//   sub_18003F5A0(v14, TypeInfo::HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor);
			//   sub_1800054D0((HGRenderPathOnePassDeferred *)((char *)this + 5080), v15, v16, v17, v107);
			//   v18 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_FoliageOccluder,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m22 = sub_18003F5A0(
			//                                                                                                   v18,
			//                                                                                                   TypeInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor);
			//   sub_18003F5A0(v18, TypeInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor);
			//   sub_1800054D0((HGRenderPathOnePassDeferred *)((char *)this + 5088), v19, v20, v21, v108);
			//   v22 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_Sludge,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m03 = sub_18003F5A0(
			//                                                                                                   v22,
			//                                                                                                   TypeInfo::HG::Rendering::Runtime::SludgePassConstructor);
			//   sub_18003F5A0(v22, TypeInfo::HG::Rendering::Runtime::SludgePassConstructor);
			//   sub_1800054D0((HGRenderPathOnePassDeferred *)((char *)this + 5096), v23, v24, v25, v109);
			//   v26 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_GpuClothSimulation,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m23 = sub_18003F5A0(
			//                                                                                                   v26,
			//                                                                                                   TypeInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor);
			//   sub_18003F5A0(v26, TypeInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor);
			//   sub_1800054D0((HGRenderPathOnePassDeferred *)((char *)this + 5104), v27, v28, v29, v110);
			//   v30 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_ParticleLighting,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m00 = sub_18003F5A0(v30, TypeInfo::HG::Rendering::Runtime::ParticleLightingPassConstructor);
			//   sub_18003F5A0(v30, TypeInfo::HG::Rendering::Runtime::ParticleLightingPassConstructor);
			//   sub_1800054D0((HGRenderPathOnePassDeferred *)((char *)this + 5112), v31, v32, v33, v111);
			//   v34 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_LightClustering,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m20 = sub_18003F5A0(v34, TypeInfo::HG::Rendering::Runtime::LightClusteringPassConstructor);
			//   sub_18003F5A0(v34, TypeInfo::HG::Rendering::Runtime::LightClusteringPassConstructor);
			//   sub_1800054D0((HGRenderPathOnePassDeferred *)((char *)this + 5120), v35, v36, v37, v112);
			//   v38 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_CustomDepthOnly,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m01 = sub_18003F5A0(v38, TypeInfo::HG::Rendering::Runtime::DepthOnlyPassConstructor);
			//   sub_18003F5A0(v38, TypeInfo::HG::Rendering::Runtime::DepthOnlyPassConstructor);
			//   sub_1800054D0((HGRenderPathOnePassDeferred *)((char *)this + 5128), v39, v40, v41, v113);
			//   v42 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_ShadowMap,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m21 = sub_18003F5A0(v42, TypeInfo::HG::Rendering::Runtime::ShadowMapPassConstructor);
			//   sub_18003F5A0(v42, TypeInfo::HG::Rendering::Runtime::ShadowMapPassConstructor);
			//   sub_1800054D0((HGRenderPathOnePassDeferred *)((char *)this + 5136), v43, v44, v45, v114);
			//   v46 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_Atmosphere,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m02 = sub_18003F5A0(v46, TypeInfo::HG::Rendering::Runtime::SkyAtmospherePassConstructor);
			//   sub_18003F5A0(v46, TypeInfo::HG::Rendering::Runtime::SkyAtmospherePassConstructor);
			//   sub_1800054D0((HGRenderPathOnePassDeferred *)((char *)this + 5144), v47, v48, v49, v115);
			//   v50 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_BakeFogLut,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m22 = sub_18003F5A0(v50, TypeInfo::HG::Rendering::Runtime::BakeFogLutPassConstructor);
			//   sub_18003F5A0(v50, TypeInfo::HG::Rendering::Runtime::BakeFogLutPassConstructor);
			//   sub_1800054D0((HGRenderPathOnePassDeferred *)((char *)this + 5152), v51, v52, v53, v116);
			//   v54 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_TerrainDeform,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m03 = sub_18003F5A0(v54, TypeInfo::HG::Rendering::Runtime::TerrainDeformPassConstructor);
			//   sub_18003F5A0(v54, TypeInfo::HG::Rendering::Runtime::TerrainDeformPassConstructor);
			//   sub_1800054D0((HGRenderPathOnePassDeferred *)((char *)this + 5160), v55, v56, v57, v117);
			//   v58 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_TerrainVTBake,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m23 = sub_18003F5A0(v58, TypeInfo::HG::Rendering::Runtime::TerrainVTBakePassConstructor);
			//   sub_18003F5A0(v58, TypeInfo::HG::Rendering::Runtime::TerrainVTBakePassConstructor);
			//   sub_1800054D0((HGRenderPathOnePassDeferred *)((char *)this + 5168), v59, v60, v61, v118);
			//   v62 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_TerrainDepthPrepass,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m00 = sub_18003F5A0(
			//                                                                                           v62,
			//                                                                                           TypeInfo::HG::Rendering::Runtime::TerrainDepthPrepassConstructor);
			//   sub_18003F5A0(v62, TypeInfo::HG::Rendering::Runtime::TerrainDepthPrepassConstructor);
			//   sub_1800054D0((HGRenderPathOnePassDeferred *)((char *)this + 5176), v63, v64, v65, v119);
			//   v66 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_WaterSector,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m20 = sub_18003F5A0(
			//                                                                                           v66,
			//                                                                                           TypeInfo::HG::Rendering::Runtime::WaterSectorRenderingPass);
			//   sub_18003F5A0(v66, TypeInfo::HG::Rendering::Runtime::WaterSectorRenderingPass);
			//   sub_1800054D0((HGRenderPathOnePassDeferred *)((char *)this + 5184), v67, v68, v69, v120);
			//   v70 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_WaterInteraction,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m01 = sub_18003F5A0(
			//                                                                                           v70,
			//                                                                                           TypeInfo::HG::Rendering::Runtime::WaterInteractionRenderingPass);
			//   sub_18003F5A0(v70, TypeInfo::HG::Rendering::Runtime::WaterInteractionRenderingPass);
			//   sub_1800054D0((HGRenderPathOnePassDeferred *)((char *)this + 5192), v71, v72, v73, v121);
			//   v74 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_WaterOnePassDeferred,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m21 = sub_18003F5A0(
			//                                                                                           v74,
			//                                                                                           TypeInfo::HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass);
			//   sub_18003F5A0(v74, TypeInfo::HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass);
			//   sub_1800054D0((HGRenderPathOnePassDeferred *)((char *)this + 5200), v75, v76, v77, v122);
			//   v78 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_FakePlanarReflection,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m02 = sub_18003F5A0(
			//                                                                                           v78,
			//                                                                                           TypeInfo::HG::Rendering::Runtime::FakePlanarReflectionPass);
			//   sub_18003F5A0(v78, TypeInfo::HG::Rendering::Runtime::FakePlanarReflectionPass);
			//   sub_1800054D0((HGRenderPathOnePassDeferred *)((char *)this + 5208), v79, v80, v81, v123);
			//   v82 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_OnePassDeferred,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m22 = sub_18003F5A0(
			//                                                                                           v82,
			//                                                                                           TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor);
			//   sub_18003F5A0(v82, TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor);
			//   sub_1800054D0((HGRenderPathOnePassDeferred *)((char *)this + 5216), v83, v84, v85, v124);
			//   v86 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_VolumetricCloud,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m03 = sub_18003F5A0(
			//                                                                                           v86,
			//                                                                                           TypeInfo::HG::Rendering::Runtime::VolumetricCloudPassConstructor);
			//   sub_18003F5A0(v86, TypeInfo::HG::Rendering::Runtime::VolumetricCloudPassConstructor);
			//   sub_1800054D0((HGRenderPathOnePassDeferred *)((char *)this + 5224), v87, v88, v89, v125);
			//   v90 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_Transparent,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m23 = sub_18003F5A0(
			//                                                                                           v90,
			//                                                                                           TypeInfo::HG::Rendering::Runtime::TransparentPassConstructor);
			//   sub_18003F5A0(v90, TypeInfo::HG::Rendering::Runtime::TransparentPassConstructor);
			//   sub_1800054D0((HGRenderPathOnePassDeferred *)((char *)this + 5232), v91, v92, v93, v126);
			//   v94 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_LightShaft,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m00 = sub_18003F5A0(
			//                                                                                                      v94,
			//                                                                                                      TypeInfo::HG::Rendering::Runtime::LightShaftPassConstructor);
			//   sub_18003F5A0(v94, TypeInfo::HG::Rendering::Runtime::LightShaftPassConstructor);
			//   sub_1800054D0((HGRenderPathOnePassDeferred *)((char *)this + 5240), v95, v96, v97, v127);
			//   v98 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_Distortion,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m20 = sub_18003F5A0(
			//                                                                                                      v98,
			//                                                                                                      TypeInfo::HG::Rendering::Runtime::DistortionPassConstructor);
			//   sub_18003F5A0(v98, TypeInfo::HG::Rendering::Runtime::DistortionPassConstructor);
			//   sub_1800054D0((HGRenderPathOnePassDeferred *)((char *)this + 5248), v99, v100, v101, v128);
			//   v102 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//            (HGRenderPathBase *)this,
			//            PassConstructorID__Enum_HyperScreenSpaceReflection,
			//            0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m01 = sub_18003F5A0(
			//                                                                                                      v102,
			//                                                                                                      TypeInfo::HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass);
			//   sub_18003F5A0(v102, TypeInfo::HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass);
			//   sub_1800054D0((HGRenderPathOnePassDeferred *)((char *)this + 5256), v103, v104, v105, method);
			// }
			// 
		}

		private static PassConstructorID[] PopulatePassConstructorIds()
		{
			// // PassConstructorID[] PopulatePassConstructorIds()
			// PassConstructorID__Enum__Array *HG::Rendering::Runtime::HGRenderPathOnePassDeferred::PopulatePassConstructorIds(
			//         MethodInfo *method)
			// {
			//   __int64 v1; // r8
			//   __int64 v2; // r9
			//   Array *v3; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( !byte_18D919654 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::PassConstructorID);
			//     sub_18003C530(&884DB65BF397FFF9967F825A6F0FB2E37A97334E93CD88D37A1EB2F22DC29222_Field);
			//     byte_18D919654 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3009, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3009, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1065(Patch, 0LL);
			//   }
			//   else
			//   {
			//     v3 = (Array *)il2cpp_array_new_specific_0(TypeInfo::HG::Rendering::Runtime::PassConstructorID, 40LL, v1, v2);
			//     System::Runtime::CompilerServices::RuntimeHelpers::InitializeArray(
			//       v3,
			//       884DB65BF397FFF9967F825A6F0FB2E37A97334E93CD88D37A1EB2F22DC29222_Field,
			//       0LL);
			//     return (PassConstructorID__Enum__Array *)v3;
			//   }
			// }
			// 
			return null;
		}

		protected override GBufferProfileManager.GBufferProfileConfig GetGBufferProfileConfig()
		{
			// // GBufferProfileManager+GBufferProfileConfig GetGBufferProfileConfig()
			// GBufferProfileManager_GBufferProfileConfig__Enum HG::Rendering::Runtime::HGRenderPathOnePassDeferred::GetGBufferProfileConfig(
			//         HGRenderPathOnePassDeferred *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3010, 0LL) )
			//     return 1;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3010, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_65((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return GBufferProfileManager.GBufferProfileConfig.HighEnd;
		}

		protected override void OnPreRendering(ref HGRenderPathBase.HGRenderPathParams renderPathParams)
		{
			// // Void OnPreRendering(HGRenderPathBase+HGRenderPathParams ByRef)
			// void HG::Rendering::Runtime::HGRenderPathOnePassDeferred::OnPreRendering(
			//         HGRenderPathOnePassDeferred *this,
			//         HGRenderPathBase_HGRenderPathParams *renderPathParams,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   HGCharacterVolume *static_fields; // rcx
			//   HGRenderPipeline *hgrp; // rax
			//   HGRenderGraph *m_RenderGraph; // rbp
			//   HGCamera *hgCamera; // rsi
			//   GBufferProfileManager *v10; // r14
			//   GBufferProfileManager_GBufferProfileConfig__Enum v11; // eax
			//   Vector2Parameter *charCustomMainLightDir; // rdi
			//   bool overrideState; // di
			//   HGCamera_VolumeComponentsData *m_volumeComponentsData; // rax
			//   uint32_t cullingViewHandle; // esi
			//   HGRenderGraphContext *m_RenderGraphContext; // rdi
			//   float v17; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   HGRenderKeyword__Enum globalKeywords; // [rsp+20h] [rbp-58h]
			// 
			//   if ( !byte_18D919656 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     byte_18D919656 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3011, 0LL) )
			//   {
			//     hgrp = renderPathParams.hgrp;
			//     if ( hgrp )
			//     {
			//       m_RenderGraph = hgrp.fields.m_RenderGraph;
			//       hgCamera = renderPathParams.renderRequest.hgCamera;
			//       LOBYTE(this[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m21) = 0;
			//       v10 = *(GBufferProfileManager **)&this[1].fields._._._.m_shaderVariablesGlobal._PrevViewProjMatrix.m23;
			//       v11 = (unsigned int)sub_18003ED00(18LL);
			//       if ( v10 )
			//       {
			//         HG::Rendering::Runtime::GBufferProfileManager::SetGBufferTextureMemoryless(
			//           v10,
			//           v11,
			//           RenderTextureMemoryless__Enum_Color,
			//           0LL);
			//         HG::Rendering::Runtime::HGRenderPathDeferred::OnPreRendering(
			//           (HGRenderPathDeferred *)this,
			//           renderPathParams,
			//           0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//         static_fields = (HGCharacterVolume *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields;
			//         charCustomMainLightDir = static_fields.fields.charCustomMainLightDir;
			//         if ( charCustomMainLightDir )
			//         {
			//           overrideState = charCustomMainLightDir.fields._._.overrideState;
			//           if ( hgCamera )
			//           {
			//             m_volumeComponentsData = hgCamera.fields.m_volumeComponentsData;
			//             if ( m_volumeComponentsData )
			//             {
			//               static_fields = m_volumeComponentsData.fields.m_hgCharacterVolume;
			//               if ( static_fields )
			//               {
			//                 if ( !HG::Rendering::Runtime::HGCharacterVolume::GetCharOutlinePassEnableState(static_fields, 0LL)
			//                   || !overrideState )
			//                 {
			//                   v17 = NAN;
			//                   goto LABEL_15;
			//                 }
			//                 cullingViewHandle = hgCamera.fields.cullingViewHandle;
			//                 if ( m_RenderGraph )
			//                 {
			//                   m_RenderGraphContext = m_RenderGraph.fields.m_RenderGraphContext;
			//                   if ( m_RenderGraphContext )
			//                   {
			//                     sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//                     LOWORD(globalKeywords) = 0;
			//                     v17 = COERCE_FLOAT(
			//                             UnityEngine::HyperGryph::HGMeshRender::CreateRendererList(
			//                               cullingViewHandle,
			//                               HGRenderFlags__Enum_EnableCharacterOutline|HGRenderFlags__Enum_ShadowOnly|HGRenderFlags__Enum_Opaque,
			//                               HGRenderFlags__Enum_EnableCharacterOutline|HGRenderFlags__Enum_Opaque,
			//                               HGShaderLightMode__Enum_CharacterOutline,
			//                               globalKeywords,
			//                               m_RenderGraphContext.fields.renderContext.m_Ptr,
			//                               0,
			//                               0,
			//                               0xFFFFFFFF,
			//                               0,
			//                               0,
			//                               0LL));
			// LABEL_15:
			//                     this[1].fields._._._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m32 = v17;
			//                     this[1].fields._._._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m20 = NAN;
			//                     this[1].fields._._._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m03 = NAN;
			//                     return;
			//                   }
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_17:
			//     sub_180B536AC(static_fields, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3011, 0LL);
			//   if ( !Patch )
			//     goto LABEL_17;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_389(Patch, (Object *)this, renderPathParams, 0LL);
			// }
			// 
		}

		protected override void RenderScene(ref HGRenderPathBase.HGRenderPathParams renderPathParams)
		{
			// // Void RenderScene(HGRenderPathBase+HGRenderPathParams ByRef)
			// // Hidden C++ exception states: #wind=22 #try_helpers=1
			// void HG::Rendering::Runtime::HGRenderPathOnePassDeferred::RenderScene(
			//         HGRenderPathOnePassDeferred *this,
			//         HGRenderPathBase_HGRenderPathParams *renderPathParams,
			//         MethodInfo *method)
			// {
			//   HGRenderPathOnePassDeferred *v3; // rsi
			//   __int64 v4; // rcx
			//   HGRenderPipeline *hgrp; // rdx
			//   HGRenderGraph *m_RenderGraph; // r15
			//   HGCamera *hgCamera; // r13
			//   HGRenderPipeline_RenderRequest *p_renderRequest; // rax
			//   _OWORD *v9; // rcx
			//   __int64 v10; // r12
			//   __int64 v11; // rdx
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   __int64 v14; // rbx
			//   __int64 v15; // rbx
			//   HGCharacterVolume *v16; // rbx
			//   __int64 v17; // rdx
			//   __int64 v18; // rcx
			//   __int64 v19; // rdx
			//   __int64 v20; // rcx
			//   WaterOnePassDeferredRenderingPass *v21; // rbx
			//   __int64 v22; // rdx
			//   __int64 v23; // rcx
			//   __int64 v24; // rax
			//   ComputeBufferHandle *v25; // rax
			//   unsigned __int64 v26; // r8
			//   signed __int64 v27; // rtt
			//   __int64 v28; // rdx
			//   HGGraphicsFeatureManager__StaticFields *static_fields; // rcx
			//   HGGraphicsFeatureSwitch *usePerTileDeferredLighting; // rax
			//   LightClusteringPassConstructor *v31; // rcx
			//   __int64 v32; // rbx
			//   unsigned __int64 v33; // rdx
			//   __int64 v34; // rcx
			//   __int64 v35; // rax
			//   __int64 v36; // rax
			//   unsigned __int64 v37; // r8
			//   signed __int64 v38; // rtt
			//   ReflectionProbeBinningPassConstructor *v39; // rcx
			//   __int64 v40; // rdx
			//   BinningPass *v41; // rcx
			//   __int64 v42; // rdx
			//   __int64 v43; // rcx
			//   __int64 v44; // rax
			//   __int64 v45; // rdx
			//   __int64 v46; // rcx
			//   ParticleLightingPassConstructor *v47; // rcx
			//   __int64 v48; // rdx
			//   WaterSectorRenderingPass *v49; // rcx
			//   __int64 v50; // rdx
			//   WaterInteractionRenderingPass *v51; // rcx
			//   __int64 v52; // rdx
			//   FoliageOccluderPassConstructor *v53; // rcx
			//   __int64 v54; // rdx
			//   SludgePassConstructor *v55; // rcx
			//   __int64 v56; // rdx
			//   GpuClothSimulationPassConstructor *v57; // rcx
			//   unsigned __int64 v58; // rdx
			//   unsigned __int64 v59; // r8
			//   signed __int64 v60; // rtt
			//   DepthOnlyPassConstructor *v61; // rcx
			//   unsigned __int64 v62; // rdx
			//   __int64 v63; // rcx
			//   __int64 v64; // rax
			//   int v65; // ecx
			//   unsigned __int64 v66; // r8
			//   signed __int64 v67; // rtt
			//   unsigned __int64 v68; // r8
			//   signed __int64 v69; // rtt
			//   ShadowMapPassConstructor *v70; // rcx
			//   unsigned __int64 v71; // rdx
			//   __int64 v72; // rcx
			//   HGSettingParameters *settingParameters_k__BackingField; // rax
			//   HGAtmosphereSettingParameters *atmosphereParams_k__BackingField; // rax
			//   unsigned __int64 v75; // r8
			//   signed __int64 v76; // rtt
			//   SkyAtmospherePassConstructor *v77; // rcx
			//   unsigned __int64 v78; // rdx
			//   __int64 v79; // rcx
			//   HGSettingParameters *v80; // rax
			//   HGAtmosphereSettingParameters *v81; // rax
			//   unsigned __int64 v82; // r8
			//   signed __int64 v83; // rtt
			//   BakeFogLutPassConstructor *v84; // rcx
			//   unsigned __int64 v85; // rdx
			//   __int64 v86; // rcx
			//   CullingResults v87; // xmm0
			//   HGRenderPipeline *v88; // rax
			//   unsigned __int64 v89; // r8
			//   signed __int64 v90; // rtt
			//   TerrainDeformPassConstructor *v91; // rcx
			//   __int64 v92; // rdx
			//   __int64 v93; // rcx
			//   unsigned __int64 v94; // r8
			//   signed __int64 v95; // rtt
			//   FakePlanarReflectionPass *v96; // rcx
			//   HGGraphicsFeatureManager__StaticFields *v97; // rax
			//   HGGraphicsFeatureSwitch *deferredDecal; // rdx
			//   ReflectionProbeBinningPassConstructor_PassOutput *deferredErosion; // rcx
			//   __int64 v100; // rax
			//   __int64 v101; // rax
			//   void *v102; // rax
			//   unsigned __int64 v103; // rdx
			//   signed __int64 v104; // rcx
			//   __int64 v105; // rax
			//   __int64 v106; // rax
			//   unsigned __int64 v107; // r8
			//   signed __int64 v108; // rtt
			//   unsigned __int64 v109; // r8
			//   signed __int64 v110; // rtt
			//   HGManagerContext *currentManagerContext; // rax
			//   __int64 v112; // rdx
			//   __int64 v113; // rcx
			//   HGWaterManager *waterManager_k__BackingField; // rcx
			//   OnePassDeferredPassConstructor_PassInput *v115; // rcx
			//   __int128 *v116; // rax
			//   __int64 v117; // rdx
			//   OnePassDeferredPassConstructor *v118; // rcx
			//   HGCamera *v119; // rax
			//   unsigned __int64 v120; // rdx
			//   signed __int64 handle; // rcx
			//   __int64 v122; // rdx
			//   __int64 v123; // rcx
			//   __int64 v124; // rax
			//   __int64 v125; // rax
			//   unsigned __int64 v126; // r8
			//   unsigned __int64 v127; // rdx
			//   signed __int64 v128; // rcx
			//   signed __int64 v129; // rtt
			//   __int64 v130; // rdx
			//   OnePassDeferredPassConstructor_PassInput *v131; // rcx
			//   __int128 *v132; // rax
			//   OnePassDeferredPassConstructor *v133; // rcx
			//   bool v134; // bl
			//   HGVFXManager *instance; // rax
			//   TextureHandle v136; // xmm6
			//   unsigned __int64 v137; // r8
			//   signed __int64 v138; // rtt
			//   TextureHandle *v139; // rax
			//   TextureHandle v140; // xmm7
			//   Rect v141; // xmm6
			//   int IsValid; // ebx
			//   TextureHandle *v143; // rax
			//   __int64 v144; // rdx
			//   __int64 v145; // rcx
			//   __int64 v146; // rax
			//   __int64 v147; // rax
			//   WaterOnePassDeferredRenderingPass *v148; // rcx
			//   __int64 v149; // rax
			//   HGSettingParameters *v150; // rax
			//   int v151; // ecx
			//   unsigned __int64 v152; // r8
			//   signed __int64 v153; // rtt
			//   unsigned __int64 v154; // r8
			//   signed __int64 v155; // rtt
			//   TextureHandle v156; // xmm8
			//   TextureHandle v157; // xmm7
			//   int32_t CameraDepthTexture; // ebx
			//   __int64 v159; // rdx
			//   VolumetricCloudPassConstructor *v160; // rcx
			//   TextureHandle *v161; // rax
			//   TextureHandle v162; // xmm9
			//   __int64 v163; // rdx
			//   TextureHandle v164; // xmm6
			//   TextureHandle v165; // xmm7
			//   HGSettingParameters *v166; // rbx
			//   HGLightShaftSettingParameters *lightShaft_k__BackingField; // rcx
			//   __int64 v168; // rdx
			//   HGLightShaftSettingParameters *v169; // rcx
			//   __int64 v170; // rdx
			//   HGLightShaftSettingParameters *v171; // rcx
			//   __int64 v172; // rdx
			//   HGLightShaftSettingParameters *v173; // rcx
			//   __int64 v174; // rdx
			//   LightShaftPassConstructor *v175; // rcx
			//   TextureHandle v176; // xmm6
			//   TextureHandle v177; // xmm7
			//   int32_t v178; // ebx
			//   __int128 v179; // xmm0
			//   TextureHandle v180; // xmm0
			//   unsigned __int64 v181; // r8
			//   signed __int64 v182; // rtt
			//   unsigned __int64 v183; // rdx
			//   unsigned __int64 v184; // r8
			//   signed __int64 v185; // rtt
			//   __int64 m_CurrentRendererConfigurationBakedLighting; // rcx
			//   HGSettingParameters *v187; // rbx
			//   GpuClothSimulationPassConstructor_PassInput v188; // bl
			//   _OWORD *p_m00; // rax
			//   char *v190; // rcx
			//   __int64 v191; // rdx
			//   TransparentPassConstructor *v192; // rcx
			//   TransparentPassConstructor_PassOutput v193; // xmm10
			//   TextureHandle v194; // xmm8
			//   Rect v195; // xmm7
			//   TextureHandle v196; // xmm6
			//   HGCamera *v197; // rbx
			//   __int64 v198; // rcx
			//   __int64 v199; // rdx
			//   __int64 v200; // rdx
			//   DistortionPassConstructor *v201; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v203; // rdx
			//   __int64 v204; // rcx
			//   __int64 v205; // [rsp+0h] [rbp-4CC8h] BYREF
			//   MethodInfo *methoda; // [rsp+20h] [rbp-4CA8h]
			//   ReflectionProbeBinningPassConstructor_PassOutput v207; // [rsp+60h] [rbp-4C68h] BYREF
			//   GpuClothSimulationPassConstructor_PassInput v208; // [rsp+61h] [rbp-4C67h] BYREF
			//   bool CharOutlinePassEnableState; // [rsp+62h] [rbp-4C66h]
			//   OnePassDeferredPassConstructor_PassOutput v210; // [rsp+63h] [rbp-4C65h] BYREF
			//   TextureHandle v211; // [rsp+70h] [rbp-4C58h] BYREF
			//   FoliageOccluderPassConstructor_PassOutput v212; // [rsp+80h] [rbp-4C48h] BYREF
			//   FoliageOccluderPassConstructor_PassInput v213; // [rsp+81h] [rbp-4C47h] BYREF
			//   DepthOnlyPassConstructor_PassOutput v214; // [rsp+82h] [rbp-4C46h] BYREF
			//   TerrainDeformPassConstructor_PassOutput v215; // [rsp+83h] [rbp-4C45h] BYREF
			//   FakePlanarReflectionPass_PassOutput v216; // [rsp+84h] [rbp-4C44h] BYREF
			//   OnePassDeferredPassConstructor_PassOutput v217; // [rsp+85h] [rbp-4C43h] BYREF
			//   SludgePassConstructor_PassOutput v218; // [rsp+86h] [rbp-4C42h] BYREF
			//   HGRenderGraph *v219; // [rsp+88h] [rbp-4C40h]
			//   HGCamera *v220; // [rsp+90h] [rbp-4C38h]
			//   uint32_t viewHandle[4]; // [rsp+A0h] [rbp-4C28h]
			//   TextureHandle lightCullResult; // [rsp+B0h] [rbp-4C18h] BYREF
			//   VolumetricCloudPassConstructor_PassOutput v223; // [rsp+C0h] [rbp-4C08h] BYREF
			//   HGRenderPipeline *v224; // [rsp+C8h] [rbp-4C00h]
			//   HGSettingParameters *settingParameters; // [rsp+D0h] [rbp-4BF8h]
			//   ScriptableRenderContext renderContext[2]; // [rsp+E0h] [rbp-4BE8h] BYREF
			//   uint32_t v227[4]; // [rsp+F0h] [rbp-4BD8h] BYREF
			//   TextureHandle v228; // [rsp+100h] [rbp-4BC8h] BYREF
			//   HGAtmosphereSettingParameters *v229; // [rsp+110h] [rbp-4BB8h] BYREF
			//   HGAtmosphereSettingParameters *v230; // [rsp+118h] [rbp-4BB0h] BYREF
			//   CullingResults cullingResults; // [rsp+120h] [rbp-4BA8h]
			//   Rect v232; // [rsp+130h] [rbp-4B98h] BYREF
			//   SludgePassConstructor_PassInput v233; // [rsp+140h] [rbp-4B88h] BYREF
			//   SkyAtmospherePassConstructor_PassInput v234; // [rsp+148h] [rbp-4B80h] BYREF
			//   BakeFogLutPassConstructor_PassInput v235; // [rsp+150h] [rbp-4B78h] BYREF
			//   CullingResults v236; // [rsp+158h] [rbp-4B70h]
			//   _BYTE v237[24]; // [rsp+168h] [rbp-4B60h] BYREF
			//   TextureDesc v238; // [rsp+180h] [rbp-4B48h] BYREF
			//   TextureHandle v239; // [rsp+1E0h] [rbp-4AE8h]
			//   CullingResults v240; // [rsp+1F0h] [rbp-4AD8h]
			//   TextureHandle v241; // [rsp+200h] [rbp-4AC8h]
			//   TextureHandle sceneColor_k__BackingField; // [rsp+210h] [rbp-4AB8h]
			//   LightShaftPassConstructor_PassOutput v243; // [rsp+220h] [rbp-4AA8h] BYREF
			//   _BYTE v244[80]; // [rsp+238h] [rbp-4A90h] BYREF
			//   TransparentPassConstructor_PassOutput v245; // [rsp+290h] [rbp-4A38h] BYREF
			//   DistortionPassConstructor_PassOutput v246; // [rsp+2A0h] [rbp-4A28h] BYREF
			//   ShadowMapPassConstructor_PassInput v247; // [rsp+2B0h] [rbp-4A18h] BYREF
			//   DepthOnlyPassConstructor_PassInput v248; // [rsp+300h] [rbp-49C8h] BYREF
			//   TextureDesc v249; // [rsp+320h] [rbp-49A8h] BYREF
			//   VolumetricCloudPassConstructor_PassInput v250; // [rsp+380h] [rbp-4948h] BYREF
			//   __int128 v251; // [rsp+3C0h] [rbp-4908h] BYREF
			//   __int128 v252; // [rsp+3D0h] [rbp-48F8h]
			//   __int128 v253; // [rsp+3E0h] [rbp-48E8h]
			//   __int128 v254; // [rsp+3F0h] [rbp-48D8h]
			//   __int128 v255; // [rsp+400h] [rbp-48C8h]
			//   __int128 v256; // [rsp+410h] [rbp-48B8h]
			//   __int128 v257; // [rsp+420h] [rbp-48A8h]
			//   CullingResults v258; // [rsp+430h] [rbp-4898h]
			//   __int128 v259; // [rsp+450h] [rbp-4878h]
			//   __int128 v260; // [rsp+460h] [rbp-4868h]
			//   __int128 v261; // [rsp+470h] [rbp-4858h]
			//   __int64 v262; // [rsp+480h] [rbp-4848h]
			//   float z; // [rsp+488h] [rbp-4840h]
			//   HGRenderPipeline *v264; // [rsp+490h] [rbp-4838h] BYREF
			//   __int128 v265; // [rsp+498h] [rbp-4830h]
			//   __int128 v266; // [rsp+4A8h] [rbp-4820h]
			//   bool v267; // [rsp+4B8h] [rbp-4810h]
			//   float screenCullingRatio; // [rsp+4BCh] [rbp-480Ch]
			//   float screenRatioCullingDistance; // [rsp+4C0h] [rbp-4808h]
			//   uint32_t screenCullingLayerMask; // [rsp+4C4h] [rbp-4804h]
			//   float m00; // [rsp+4C8h] [rbp-4800h]
			//   float m10; // [rsp+4CCh] [rbp-47FCh]
			//   float m30; // [rsp+4D0h] [rbp-47F8h]
			//   float m11; // [rsp+4D4h] [rbp-47F4h]
			//   float m21; // [rsp+4D8h] [rbp-47F0h]
			//   float m31; // [rsp+4DCh] [rbp-47ECh]
			//   float m02; // [rsp+4E0h] [rbp-47E8h]
			//   uint32_t v278; // [rsp+4E4h] [rbp-47E4h]
			//   uint32_t v279; // [rsp+4E8h] [rbp-47E0h]
			//   float m12; // [rsp+4ECh] [rbp-47DCh]
			//   float m22; // [rsp+4F0h] [rbp-47D8h]
			//   float m13; // [rsp+4F4h] [rbp-47D4h]
			//   float m01; // [rsp+4F8h] [rbp-47D0h]
			//   float m32; // [rsp+4FCh] [rbp-47CCh]
			//   float m03; // [rsp+500h] [rbp-47C8h]
			//   __int64 v286; // [rsp+504h] [rbp-47C4h]
			//   __int64 v287; // [rsp+50Ch] [rbp-47BCh]
			//   __int64 v288; // [rsp+518h] [rbp-47B0h] BYREF
			//   unsigned int v289; // [rsp+520h] [rbp-47A8h]
			//   LightClusteringPassConstructor_PassOutput_punctualLightIndices_e_FixedBuffer *p_punctualLightIndices; // [rsp+528h] [rbp-47A0h]
			//   char v291; // [rsp+530h] [rbp-4798h]
			//   bool v292; // [rsp+531h] [rbp-4797h]
			//   LightClusteringPassConstructor_PassInput v293; // [rsp+540h] [rbp-4788h] BYREF
			//   TerrainDeformPassConstructor_PassInput v294; // [rsp+5A0h] [rbp-4728h] BYREF
			//   ReflectionProbeBinningPassConstructor_PassInput v295; // [rsp+5C8h] [rbp-4700h] BYREF
			//   WaterOnePassDeferredRenderingPass_PassOutput v296; // [rsp+600h] [rbp-46C8h] BYREF
			//   LightShaftPassConstructor_PassInput v297; // [rsp+620h] [rbp-46A8h] BYREF
			//   FakePlanarReflectionPass_PassInput v298; // [rsp+650h] [rbp-4678h] BYREF
			//   Il2CppExceptionWrapper *v299; // [rsp+710h] [rbp-45B8h] BYREF
			//   Il2CppExceptionWrapper *v300; // [rsp+718h] [rbp-45B0h] BYREF
			//   Il2CppExceptionWrapper *v301; // [rsp+720h] [rbp-45A8h] BYREF
			//   Il2CppExceptionWrapper *v302; // [rsp+728h] [rbp-45A0h] BYREF
			//   Il2CppExceptionWrapper *v303; // [rsp+730h] [rbp-4598h] BYREF
			//   Il2CppExceptionWrapper *v304; // [rsp+738h] [rbp-4590h] BYREF
			//   Il2CppExceptionWrapper *v305; // [rsp+740h] [rbp-4588h] BYREF
			//   Il2CppExceptionWrapper *v306; // [rsp+748h] [rbp-4580h] BYREF
			//   Il2CppExceptionWrapper *v307; // [rsp+750h] [rbp-4578h] BYREF
			//   Il2CppExceptionWrapper *v308; // [rsp+758h] [rbp-4570h] BYREF
			//   Il2CppExceptionWrapper *v309; // [rsp+760h] [rbp-4568h] BYREF
			//   Il2CppExceptionWrapper *v310; // [rsp+768h] [rbp-4560h] BYREF
			//   Il2CppExceptionWrapper *v311; // [rsp+770h] [rbp-4558h] BYREF
			//   Il2CppExceptionWrapper *v312; // [rsp+778h] [rbp-4550h] BYREF
			//   Il2CppExceptionWrapper *v313; // [rsp+780h] [rbp-4548h] BYREF
			//   Il2CppExceptionWrapper *v314; // [rsp+790h] [rbp-4538h] BYREF
			//   Il2CppExceptionWrapper *v315; // [rsp+798h] [rbp-4530h] BYREF
			//   Il2CppExceptionWrapper *v316; // [rsp+7A0h] [rbp-4528h] BYREF
			//   Il2CppExceptionWrapper *v317; // [rsp+7A8h] [rbp-4520h] BYREF
			//   Il2CppExceptionWrapper *v318; // [rsp+7B0h] [rbp-4518h] BYREF
			//   Il2CppExceptionWrapper *v319; // [rsp+7B8h] [rbp-4510h] BYREF
			//   VolumetricCloudPassConstructor_PassInput v320; // [rsp+7C0h] [rbp-4508h] BYREF
			//   TextureDesc v321; // [rsp+800h] [rbp-44C8h] BYREF
			//   LightClusteringPassConstructor_PassInput input; // [rsp+860h] [rbp-4468h] BYREF
			//   ShadowMapPassConstructor_PassInput v323; // [rsp+8C0h] [rbp-4408h] BYREF
			//   TextureDesc v324; // [rsp+910h] [rbp-43B8h] BYREF
			//   TextureDesc v325; // [rsp+970h] [rbp-4358h] BYREF
			//   WaterOnePassDeferredRenderingPass_PassInput v326; // [rsp+9D0h] [rbp-42F8h] BYREF
			//   DistortionPassConstructor_PassInput v327; // [rsp+A70h] [rbp-4258h] BYREF
			//   _BYTE v328[168]; // [rsp+B10h] [rbp-41B8h]
			//   ParticleLightingPassConstructor_PassInput v329; // [rsp+BC0h] [rbp-4108h] BYREF
			//   FakePlanarReflectionPass_PassInput v330; // [rsp+C70h] [rbp-4058h] BYREF
			//   LightClusteringPassConstructor_PassOutput output; // [rsp+D30h] [rbp-3F98h] BYREF
			//   unsigned int v332; // [rsp+1140h] [rbp-3B88h]
			//   unsigned int v333; // [rsp+1144h] [rbp-3B84h]
			//   __int64 v334; // [rsp+1148h] [rbp-3B80h]
			//   __int64 v335; // [rsp+1150h] [rbp-3B78h]
			//   __int64 v336; // [rsp+1158h] [rbp-3B70h]
			//   OnePassDeferredPassConstructor_PassInput v337; // [rsp+1160h] [rbp-3B68h] BYREF
			//   OnePassDeferredPassConstructor_PassInput v338; // [rsp+12E0h] [rbp-39E8h] BYREF
			//   _OWORD v339[5]; // [rsp+1460h] [rbp-3868h] BYREF
			//   HGRenderPipeline *v340; // [rsp+14B0h] [rbp-3818h] BYREF
			//   int v341; // [rsp+14B8h] [rbp-3810h]
			//   __int128 v342; // [rsp+14C0h] [rbp-3808h]
			//   __int128 v343; // [rsp+14D0h] [rbp-37F8h]
			//   _QWORD v344[9]; // [rsp+14E0h] [rbp-37E8h] BYREF
			//   CullingResults v345; // [rsp+1528h] [rbp-37A0h]
			//   int32_t v346; // [rsp+1538h] [rbp-3790h]
			//   float m23; // [rsp+153Ch] [rbp-378Ch]
			//   bool v348; // [rsp+1540h] [rbp-3788h]
			//   float v349; // [rsp+1544h] [rbp-3784h]
			//   float v350; // [rsp+1548h] [rbp-3780h]
			//   uint32_t v351; // [rsp+154Ch] [rbp-377Ch]
			//   bool v352; // [rsp+1550h] [rbp-3778h]
			//   Int32Enum__Enum v353; // [rsp+1554h] [rbp-3774h]
			//   Int32Enum__Enum v354; // [rsp+1558h] [rbp-3770h]
			//   GpuClothSimulationPassConstructor_PassInput v355; // [rsp+155Ch] [rbp-376Ch]
			//   char v356; // [rsp+1560h] [rbp-3768h] BYREF
			//   char v357[3792]; // [rsp+1830h] [rbp-3498h] BYREF
			//   _BYTE v358[395]; // [rsp+2700h] [rbp-25C8h] BYREF
			//   char v359; // [rsp+288Bh] [rbp-243Dh]
			//   float deltaTime; // [rsp+28A0h] [rbp-2428h]
			//   List_1_HG_Rendering_Runtime_IVolumetricRenderObject_ *v361; // [rsp+29A0h] [rbp-2328h]
			//   TransparentPassConstructor_PassInput v362; // [rsp+39A0h] [rbp-1328h] BYREF
			//   char v365; // [rsp+4CE8h] [rbp+20h] BYREF
			// 
			//   v3 = this;
			//   if ( !byte_18D919657 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::LowResBlitPass);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGRenderPathScene::OtherPassScope>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&off_18D50D908);
			//     byte_18D919657 = 1;
			//   }
			//   v365 = 0;
			//   sub_1802F01E0(&input, 0LL, 88LL);
			//   memset(&v295, 0, sizeof(v295));
			//   memset(v244, 0, sizeof(v244));
			//   sub_1802F01E0(&v329, 0LL, 168LL);
			//   v213 = 0;
			//   v212 = 0;
			//   v233 = 0LL;
			//   v218 = 0;
			//   memset(&v248, 0, sizeof(v248));
			//   v214 = 0;
			//   sub_1802F01E0(&v323, 0LL, 80LL);
			//   sub_1802F01E0(&v247, 0LL, 80LL);
			//   v234.atmosphereParams = 0LL;
			//   v229 = 0LL;
			//   v235.atmosphereParams = 0LL;
			//   v230 = 0LL;
			//   memset(&v294, 0, sizeof(v294));
			//   v215 = 0;
			//   v236 = 0LL;
			//   memset(v237, 0, sizeof(v237));
			//   sub_1802F01E0(&v330, 0LL, 184LL);
			//   v216 = 0;
			//   sub_1802F01E0(&v298, 0LL, 184LL);
			//   sub_1802F01E0(&v337, 0LL, 376LL);
			//   v210 = 0;
			//   sub_1802F01E0(&v251, 0LL, 376LL);
			//   sub_1802F01E0(&v338, 0LL, 376LL);
			//   v217 = 0;
			//   sub_1802F01E0(&v324, 0LL, 96LL);
			//   sub_1802F01E0(&v249, 0LL, 96LL);
			//   sub_1802F01E0(&v325, 0LL, 96LL);
			//   sub_1802F01E0(&v326, 0LL, 152LL);
			//   memset(&v296, 0, sizeof(v296));
			//   sub_1802F01E0(&v320, 0LL, 64LL);
			//   sub_1802F01E0(&v250, 0LL, 64LL);
			//   sub_1802F01E0(&v321, 0LL, 96LL);
			//   memset(&v297, 0, sizeof(v297));
			//   memset(&v243, 0, sizeof(v243));
			//   sub_1802F01E0(&v362, 0LL, 4768LL);
			//   v245 = 0LL;
			//   sub_1802F01E0(v339, 0LL, 4768LL);
			//   sub_1802F01E0(&v327, 0LL, 152LL);
			//   v246 = 0LL;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3012, 0LL) )
			//   {
			//     hgrp = renderPathParams.hgrp;
			//     v224 = hgrp;
			//     if ( !hgrp )
			//       sub_180B536AC(v4, 0LL);
			//     m_RenderGraph = hgrp.fields.m_RenderGraph;
			//     v219 = m_RenderGraph;
			//     renderContext[0] = renderPathParams.renderGraphParams.scriptableRenderContext;
			//     cullingResults = renderPathParams.renderRequest.cullingResults.cullingResults;
			//     lightCullResult = (TextureHandle)renderPathParams.renderRequest.cullingResults.lightCullResult;
			//     hgCamera = renderPathParams.renderRequest.hgCamera;
			//     v220 = hgCamera;
			//     settingParameters = hgrp.fields._settingParameters_k__BackingField;
			//     p_renderRequest = &renderPathParams.renderRequest;
			//     v9 = v358;
			//     v10 = 5LL;
			//     v11 = 5LL;
			//     do
			//     {
			//       *v9 = *(_OWORD *)&p_renderRequest.hgCamera;
			//       v9[1] = *(_OWORD *)&p_renderRequest.clearCameraSettings;
			//       v9[2] = *(_OWORD *)&p_renderRequest.target.id.m_InstanceID;
			//       v9[3] = *(_OWORD *)&p_renderRequest.target.id.m_MipLevel;
			//       v9[4] = *(_OWORD *)&p_renderRequest.target.face;
			//       v9[5] = *(_OWORD *)&p_renderRequest.target.targetDepth;
			//       v9[6] = p_renderRequest.cullingResults.cullingResults;
			//       v9 += 8;
			//       *(v9 - 1) = *(_OWORD *)&p_renderRequest.cullingResults.customPassCullingResults.hasValue;
			//       p_renderRequest = (HGRenderPipeline_RenderRequest *)((char *)p_renderRequest + 128);
			//       --v11;
			//     }
			//     while ( v11 );
			//     *v9 = *(_OWORD *)&p_renderRequest.hgCamera;
			//     v9[1] = *(_OWORD *)&p_renderRequest.clearCameraSettings;
			//     *((_QWORD *)v9 + 4) = *(_QWORD *)&p_renderRequest.target.id.m_InstanceID;
			//     HG::Rendering::Runtime::HGRenderPipeline::GetColorBufferFormat(
			//       v224,
			//       *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._InvViewProjMatrix.m21,
			//       0LL);
			//     v14 = *(_QWORD *)&v3[1].fields._._._.m_basicTransformConstants._InvViewProjMatrix.m21;
			//     if ( !v14 )
			//       sub_180B536AC(v13, v12);
			//     v15 = *(_QWORD *)(v14 + 2504);
			//     if ( !v15 )
			//       sub_180B536AC(v13, v12);
			//     v16 = *(HGCharacterVolume **)(v15 + 104);
			//     if ( !v16 )
			//       sub_180B536AC(v13, v12);
			//     CharOutlinePassEnableState = HG::Rendering::Runtime::HGCharacterVolume::GetCharOutlinePassEnableState(v16, 0LL);
			//     if ( !*(_QWORD *)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m21 )
			//       sub_180B536AC(v18, v17);
			//     HG::Rendering::Runtime::BinningPass::Prepare(
			//       *(BinningPass **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m21,
			//       m_RenderGraph,
			//       0LL);
			//     v21 = *(WaterOnePassDeferredRenderingPass **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m21;
			//     if ( !v21 )
			//       sub_180B536AC(v20, v19);
			//     HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::Prepare(
			//       v21,
			//       hgCamera,
			//       settingParameters,
			//       renderContext[0],
			//       0LL);
			//     sub_1802F01E0(&output, 0LL, 1072LL);
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)7u,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     *(_QWORD *)viewHandle = 0LL;
			//     *(_QWORD *)&viewHandle[2] = &v365;
			//     try
			//     {
			//       sub_1802F01E0(&v293, 0LL, 88LL);
			//       v293.cullingResults = cullingResults;
			//       v293.lightCullResult = (LightCullResult)lightCullResult;
			//       v24 = *(_QWORD *)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m21;
			//       if ( !v24 )
			//         sub_1802DC2C8(v23, v22);
			//       v293.binningData = *(BinningPass_BinningData *)(v24 + 16);
			//       v25 = *(ComputeBufferHandle **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m21;
			//       if ( !v25 )
			//         sub_1802DC2C8(v23, v22);
			//       v293.binningBuffer = v25[9];
			//       v293.settingParams = v224.fields._settingParameters_k__BackingField;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v26 = (((unsigned __int64)&v293.settingParams >> 12) & 0x1FFFFF) >> 6;
			//         _m_prefetchw(&qword_18D6405E0[v26 + 36190]);
			//         do
			//           v27 = qword_18D6405E0[v26 + 36190];
			//         while ( v27 != _InterlockedCompareExchange64(
			//                          &qword_18D6405E0[v26 + 36190],
			//                          v27 | (1LL << (((unsigned __int64)&v293.settingParams >> 12) & 0x3F)),
			//                          v27) );
			//       }
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields;
			//       usePerTileDeferredLighting = static_fields.usePerTileDeferredLighting;
			//       if ( !usePerTileDeferredLighting )
			//         sub_1802DC2C8(static_fields, v28);
			//       v293.outputTileResult = usePerTileDeferredLighting.fields.m_defaultValue;
			//       input = v293;
			//       v31 = *(LightClusteringPassConstructor **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m20;
			//       if ( !v31 )
			//         sub_1802DC2C8(0LL, v28);
			//       HG::Rendering::Runtime::LightClusteringPassConstructor::ConstructPass(
			//         v31,
			//         &input,
			//         &output,
			//         m_RenderGraph,
			//         *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._InvViewProjMatrix.m21,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v299 )
			//     {
			//       *(Il2CppExceptionWrapper *)viewHandle = (Il2CppExceptionWrapper)v299.ex;
			//       if ( *(_QWORD *)viewHandle )
			//         sub_18000F780(*(_QWORD *)viewHandle);
			//       v10 = 5LL;
			//       v3 = this;
			//       m_RenderGraph = v219;
			//       hgCamera = v220;
			//     }
			//     v32 = 2LL;
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)2u,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     *(_QWORD *)viewHandle = 0LL;
			//     *(_QWORD *)&viewHandle[2] = &v365;
			//     try
			//     {
			//       memset(&v244[16], 0, 40);
			//       *(_OWORD *)v244 = (unsigned __int64)renderContext[0].m_Ptr;
			//       v35 = *(_QWORD *)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m21;
			//       if ( !v35 )
			//         sub_1802DC2C8(v34, v33);
			//       *(_OWORD *)&v244[8] = *(_OWORD *)(v35 + 44);
			//       *(_QWORD *)&v244[24] = *(_QWORD *)(v35 + 60);
			//       *(_DWORD *)&v244[32] = *(_DWORD *)(v35 + 68);
			//       v36 = *(_QWORD *)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m21;
			//       if ( !v36 )
			//         sub_1802DC2C8(v34, v33);
			//       *(_QWORD *)&v244[36] = *(_QWORD *)(v36 + 72);
			//       *(_QWORD *)&v244[48] = settingParameters;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v37 = (((unsigned __int64)&v244[48] >> 12) & 0x1FFFFF) >> 6;
			//         v33 = ((unsigned __int64)&v244[48] >> 12) & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v37 + 36190]);
			//         do
			//           v38 = qword_18D6405E0[v37 + 36190];
			//         while ( v38 != _InterlockedCompareExchange64(&qword_18D6405E0[v37 + 36190], v38 | (1LL << v33), v38) );
			//       }
			//       v295 = *(ReflectionProbeBinningPassConstructor_PassInput *)v244;
			//       v207 = 0;
			//       v39 = *(ReflectionProbeBinningPassConstructor **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m02;
			//       if ( !v39 )
			//         sub_1802DC2C8(0LL, v33);
			//       HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::ConstructPass(
			//         v39,
			//         &v295,
			//         &v207,
			//         m_RenderGraph,
			//         *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._InvViewProjMatrix.m21,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v300 )
			//     {
			//       *(Il2CppExceptionWrapper *)viewHandle = (Il2CppExceptionWrapper)v300.ex;
			//       if ( *(_QWORD *)viewHandle )
			//         sub_18000F780(*(_QWORD *)viewHandle);
			//       v10 = 5LL;
			//       v32 = 2LL;
			//       v3 = this;
			//       m_RenderGraph = v219;
			//       hgCamera = v220;
			//     }
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)1u,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     v211.handle = 0LL;
			//     v211.fallBackResource = (ResourceHandle)&v365;
			//     try
			//     {
			//       v41 = *(BinningPass **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m21;
			//       if ( !v41 )
			//         sub_1802DC2C8(0LL, v40);
			//       HG::Rendering::Runtime::BinningPass::ConstructPass(
			//         v41,
			//         m_RenderGraph,
			//         *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._InvViewProjMatrix.m21,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v301 )
			//     {
			//       v211.handle = (ResourceHandle)v301.ex;
			//       if ( v211.handle )
			//         sub_18000F780(*(_QWORD *)&v211.handle);
			//       v10 = 5LL;
			//       v32 = 2LL;
			//       v3 = this;
			//       m_RenderGraph = v219;
			//       hgCamera = v220;
			//     }
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)0xAu,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     v211.handle = 0LL;
			//     v211.fallBackResource = (ResourceHandle)&v365;
			//     try
			//     {
			//       v44 = *(_QWORD *)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m21;
			//       if ( !v44 )
			//         sub_1802DC2C8(v43, v42);
			//       *(_QWORD *)v328 = *(_QWORD *)(v44 + 72);
			//       sub_1802F01E0(&v238, 0LL, 160LL);
			//       if ( !hgCamera )
			//         sub_1802DC2C8(v46, v45);
			//       *(_OWORD *)&v238.width = *(_OWORD *)&hgCamera.fields.mainViewConstants.invViewMatrix.m00;
			//       *(_OWORD *)&v238.colorFormat = *(_OWORD *)&hgCamera.fields.mainViewConstants.invViewMatrix.m01;
			//       *(_OWORD *)&v238.enableRandomWrite = *(_OWORD *)&hgCamera.fields.mainViewConstants.invViewMatrix.m02;
			//       *(_OWORD *)&v238.bindTextureMS = *(_OWORD *)&hgCamera.fields.mainViewConstants.invViewMatrix.m03;
			//       *(_OWORD *)&v238.fastMemoryDesc.inFastMemory = *(_OWORD *)&v3.fields._._.m_tranparentAfterDOFPassConstructor;
			//       v238.clearColor = *(Color *)&v3.fields._._.m_metalFXTemporalPassConstructor;
			//       v239 = *(TextureHandle *)&v3.fields._._.m_postProcessPassConstructor;
			//       v240 = *(CullingResults *)&v3.fields._._.m_uiPassConstructor;
			//       v241 = *(TextureHandle *)&v3.fields._._.m_screenSpaceOverlayPassConstructor;
			//       sceneColor_k__BackingField = v3.fields._._._sceneColor_k__BackingField;
			//       *(TextureDesc *)&v328[8] = v238;
			//       *(TextureHandle *)&v328[104] = v239;
			//       *(CullingResults *)&v328[120] = v240;
			//       *(TextureHandle *)&v328[136] = v241;
			//       *(TextureHandle *)&v328[152] = sceneColor_k__BackingField;
			//       *(_OWORD *)&v329.binningBufferHandle.handle.m_Value = *(_OWORD *)v328;
			//       *(_OWORD *)&v329.ivInput.invViewMatrix.m20 = *(_OWORD *)&v238.slices;
			//       *(_OWORD *)&v329.ivInput.invViewMatrix.m21 = *(_OWORD *)&v238.wrapMode;
			//       *(_OWORD *)&v329.ivInput.invViewMatrix.m22 = *(_OWORD *)&v328[48];
			//       *(_OWORD *)&v329.ivInput.invViewMatrix.m23 = *(_OWORD *)&v328[64];
			//       *(_OWORD *)&v329.ivInput.IVParam0.z = *(_OWORD *)&v328[80];
			//       *(_OWORD *)&v329.ivInput.IVParam1.z = *(_OWORD *)&v328[96];
			//       *(_OWORD *)&v329.ivInput.IVParam2.z = *(_OWORD *)&v328[112];
			//       *(_OWORD *)&v329.ivInput.IVDefaultSHAr.z = *(_OWORD *)&v328[128];
			//       *(_OWORD *)&v329.ivInput.IVDefaultSHAg.z = *(_OWORD *)&v328[144];
			//       *(ResourceHandle *)&v329.ivInput.IVDefaultSHAb.z = sceneColor_k__BackingField.fallBackResource;
			//       v207 = 0;
			//       v47 = *(ParticleLightingPassConstructor **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m00;
			//       if ( !v47 )
			//         sub_1802DC2C8(0LL, v45);
			//       HG::Rendering::Runtime::ParticleLightingPassConstructor::ConstructPass(
			//         v47,
			//         &v329,
			//         (ParticleLightingPassConstructor_PassOutput *)&v207,
			//         m_RenderGraph,
			//         *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._InvViewProjMatrix.m21,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v302 )
			//     {
			//       v211.handle = (ResourceHandle)v302.ex;
			//       if ( v211.handle )
			//         sub_18000F780(*(_QWORD *)&v211.handle);
			//       v10 = 5LL;
			//       v32 = 2LL;
			//       v3 = this;
			//       m_RenderGraph = v219;
			//       hgCamera = v220;
			//     }
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)3u,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGRenderPathScene::OtherPassScope>);
			//     v211.handle = 0LL;
			//     v211.fallBackResource = (ResourceHandle)&v365;
			//     try
			//     {
			//       v49 = *(WaterSectorRenderingPass **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m20;
			//       if ( !v49 )
			//         sub_1802DC2C8(0LL, v48);
			//       HG::Rendering::Runtime::WaterSectorRenderingPass::Render(
			//         v49,
			//         m_RenderGraph,
			//         *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._InvViewProjMatrix.m21,
			//         settingParameters,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v303 )
			//     {
			//       v211.handle = (ResourceHandle)v303.ex;
			//       if ( v211.handle )
			//         sub_18000F780(*(_QWORD *)&v211.handle);
			//       v10 = 5LL;
			//       v32 = 2LL;
			//       v3 = this;
			//       m_RenderGraph = v219;
			//       hgCamera = v220;
			//     }
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)4u,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGRenderPathScene::OtherPassScope>);
			//     v211.handle = 0LL;
			//     v211.fallBackResource = (ResourceHandle)&v365;
			//     try
			//     {
			//       v51 = *(WaterInteractionRenderingPass **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m01;
			//       if ( !v51 )
			//         sub_1802DC2C8(0LL, v50);
			//       HG::Rendering::Runtime::WaterInteractionRenderingPass::Render(
			//         v51,
			//         m_RenderGraph,
			//         renderContext[0],
			//         settingParameters,
			//         deltaTime,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v304 )
			//     {
			//       v211.handle = (ResourceHandle)v304.ex;
			//       if ( v211.handle )
			//         sub_18000F780(*(_QWORD *)&v211.handle);
			//       v10 = 5LL;
			//       v32 = 2LL;
			//       v3 = this;
			//       m_RenderGraph = v219;
			//       hgCamera = v220;
			//     }
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)3u,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     v211.handle = 0LL;
			//     v211.fallBackResource = (ResourceHandle)&v365;
			//     try
			//     {
			//       v213 = 0;
			//       v212 = 0;
			//       v53 = *(FoliageOccluderPassConstructor **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m22;
			//       if ( !v53 )
			//         sub_1802DC2C8(0LL, v52);
			//       HG::Rendering::Runtime::FoliageOccluderPassConstructor::ConstructPass(
			//         v53,
			//         &v213,
			//         &v212,
			//         m_RenderGraph,
			//         *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._InvViewProjMatrix.m21,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v306 )
			//     {
			//       v211.handle = (ResourceHandle)v306.ex;
			//       if ( v211.handle )
			//         sub_18000F780(*(_QWORD *)&v211.handle);
			//       v10 = 5LL;
			//       v32 = 2LL;
			//       v3 = this;
			//       m_RenderGraph = v219;
			//       hgCamera = v220;
			//     }
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)5u,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     v211.handle = 0LL;
			//     v211.fallBackResource = (ResourceHandle)&v365;
			//     try
			//     {
			//       viewHandle[0] = renderPathParams.perFrameSetup.depthBits;
			//       viewHandle[1] = renderPathParams.perFrameSetup.depthGraphicsFormat;
			//       v233 = *(SludgePassConstructor_PassInput *)viewHandle;
			//       v218 = 0;
			//       v55 = *(SludgePassConstructor **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m03;
			//       if ( !v55 )
			//         sub_1802DC2C8(0LL, v54);
			//       HG::Rendering::Runtime::SludgePassConstructor::ConstructPass(
			//         v55,
			//         &v233,
			//         &v218,
			//         m_RenderGraph,
			//         *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._InvViewProjMatrix.m21,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v307 )
			//     {
			//       v211.handle = (ResourceHandle)v307.ex;
			//       if ( v211.handle )
			//         sub_18000F780(*(_QWORD *)&v211.handle);
			//       v10 = 5LL;
			//       v32 = 2LL;
			//       v3 = this;
			//       m_RenderGraph = v219;
			//       hgCamera = v220;
			//     }
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)6u,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     v211.handle = 0LL;
			//     v211.fallBackResource = (ResourceHandle)&v365;
			//     try
			//     {
			//       v208 = 0;
			//       v207 = 0;
			//       v57 = *(GpuClothSimulationPassConstructor **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m23;
			//       if ( !v57 )
			//         sub_1802DC2C8(0LL, v56);
			//       HG::Rendering::Runtime::GpuClothSimulationPassConstructor::ConstructPass(
			//         v57,
			//         &v208,
			//         (GpuClothSimulationPassConstructor_PassOutput *)&v207,
			//         m_RenderGraph,
			//         *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._InvViewProjMatrix.m21,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v316 )
			//     {
			//       v211.handle = (ResourceHandle)v316.ex;
			//       if ( v211.handle )
			//         sub_18000F780(*(_QWORD *)&v211.handle);
			//       v10 = 5LL;
			//       v32 = 2LL;
			//       v3 = this;
			//       m_RenderGraph = v219;
			//       hgCamera = v220;
			//     }
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)0xBu,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     *(_QWORD *)viewHandle = 0LL;
			//     *(_QWORD *)&viewHandle[2] = &v365;
			//     try
			//     {
			//       *(ScriptableRenderContext *)&v244[56] = renderContext[0];
			//       *(_QWORD *)&v244[72] = renderPathParams.renderRequest.customDepthOnlyRequestMgrCPP;
			//       *(_QWORD *)&v244[64] = renderPathParams.renderRequest.customDepthOnlyRequestMgr;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v59 = (((unsigned __int64)&v244[64] >> 12) & 0x1FFFFF) >> 6;
			//         v58 = ((unsigned __int64)&v244[64] >> 12) & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v59 + 36190]);
			//         do
			//           v60 = qword_18D6405E0[v59 + 36190];
			//         while ( v60 != _InterlockedCompareExchange64(&qword_18D6405E0[v59 + 36190], v60 | (1LL << v58), v60) );
			//       }
			//       v248 = *(DepthOnlyPassConstructor_PassInput *)&v244[56];
			//       v214 = 0;
			//       v61 = *(DepthOnlyPassConstructor **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m01;
			//       if ( !v61 )
			//         sub_1802DC2C8(0LL, v58);
			//       HG::Rendering::Runtime::DepthOnlyPassConstructor::ConstructPass(
			//         v61,
			//         &v248,
			//         &v214,
			//         m_RenderGraph,
			//         *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._InvViewProjMatrix.m21,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v308 )
			//     {
			//       *(Il2CppExceptionWrapper *)viewHandle = (Il2CppExceptionWrapper)v308.ex;
			//       if ( *(_QWORD *)viewHandle )
			//         sub_18000F780(*(_QWORD *)viewHandle);
			//       v10 = 5LL;
			//       v32 = 2LL;
			//       v3 = this;
			//       m_RenderGraph = v219;
			//       hgCamera = v220;
			//     }
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)0xCu,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     *(_QWORD *)viewHandle = 0LL;
			//     *(_QWORD *)&viewHandle[2] = &v365;
			//     try
			//     {
			//       sub_1802F01E0(&v247, 0LL, 80LL);
			//       v247.cullingResults = cullingResults;
			//       v247.lightCullResult = (LightCullResult)lightCullResult;
			//       v247.srpContext = renderContext[0];
			//       v64 = *(_QWORD *)&v3[1].fields._._._.m_basicTransformConstants._InvViewProjMatrix.m21;
			//       if ( !v64 )
			//         sub_1802DC2C8(v63, v62);
			//       v247.shadowManager = *(HGShadowManager **)(v64 + 1848);
			//       v65 = dword_18D8E43F8;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v66 = (((unsigned __int64)&v247 >> 12) & 0x1FFFFF) >> 6;
			//         v62 = ((unsigned __int64)&v247 >> 12) & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v66 + 36190]);
			//         do
			//           v67 = qword_18D6405E0[v66 + 36190];
			//         while ( v67 != _InterlockedCompareExchange64(&qword_18D6405E0[v66 + 36190], v67 | (1LL << v62), v67) );
			//         v65 = dword_18D8E43F8;
			//       }
			//       *(_QWORD *)&v247.directionalLightIndex = __PAIR64__(v332, v333);
			//       v247.punctualLightIndices = &output.punctualLightIndices.FixedElementField;
			//       v247.settingParams = settingParameters;
			//       if ( v65 )
			//       {
			//         v68 = (((unsigned __int64)&v247.settingParams >> 12) & 0x1FFFFF) >> 6;
			//         v62 = ((unsigned __int64)&v247.settingParams >> 12) & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v68 + 36190]);
			//         do
			//           v69 = qword_18D6405E0[v68 + 36190];
			//         while ( v69 != _InterlockedCompareExchange64(&qword_18D6405E0[v68 + 36190], v69 | (1LL << v62), v69) );
			//       }
			//       v247.settingParamsCpp = renderPathParams.perFrameSetup.settingParametersCpp;
			//       v323 = v247;
			//       memset(&v238, 0, 60);
			//       v70 = *(ShadowMapPassConstructor **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m21;
			//       if ( !v70 )
			//         sub_1802DC2C8(0LL, v62);
			//       HG::Rendering::Runtime::ShadowMapPassConstructor::ConstructPass(
			//         v70,
			//         &v323,
			//         (ShadowMapPassConstructor_PassOutput *)&v238,
			//         m_RenderGraph,
			//         *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._InvViewProjMatrix.m21,
			//         0LL);
			//       *(_OWORD *)&v3[1].fields._._._.m_basicTransformConstants._InvPretransformMatrix.m01 = *(_OWORD *)&v238.width;
			//       *(_OWORD *)&v3[1].fields._._._.m_basicTransformConstants._InvPretransformMatrix.m02 = *(_OWORD *)&v238.colorFormat;
			//       *(_OWORD *)&v3[1].fields._._._.m_basicTransformConstants._InvPretransformMatrix.m03 = *(_OWORD *)&v238.enableRandomWrite;
			//       *(_QWORD *)&v3[1].fields._._._.m_basicTransformConstants._WorldSpaceCameraPos_Internal.x = *(_QWORD *)&v238.bindTextureMS;
			//       v3[1].fields._._._.m_basicTransformConstants._WorldSpaceCameraPos_Internal.z = *(float *)&v238.name;
			//     }
			//     catch ( Il2CppExceptionWrapper *v309 )
			//     {
			//       *(Il2CppExceptionWrapper *)viewHandle = (Il2CppExceptionWrapper)v309.ex;
			//       if ( *(_QWORD *)viewHandle )
			//         sub_18000F780(*(_QWORD *)viewHandle);
			//       v10 = 5LL;
			//       v32 = 2LL;
			//       v3 = this;
			//       m_RenderGraph = v219;
			//       hgCamera = v220;
			//     }
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)0xDu,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     *(_QWORD *)viewHandle = 0LL;
			//     *(_QWORD *)&viewHandle[2] = &v365;
			//     try
			//     {
			//       v229 = 0LL;
			//       settingParameters_k__BackingField = v224.fields._settingParameters_k__BackingField;
			//       if ( !settingParameters_k__BackingField )
			//         sub_1802DC2C8(v72, v71);
			//       atmosphereParams_k__BackingField = settingParameters_k__BackingField.fields._atmosphereParams_k__BackingField;
			//       v229 = atmosphereParams_k__BackingField;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v75 = (((unsigned __int64)&v229 >> 12) & 0x1FFFFF) >> 6;
			//         v71 = ((unsigned __int64)&v229 >> 12) & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v75 + 36190]);
			//         do
			//           v76 = qword_18D6405E0[v75 + 36190];
			//         while ( v76 != _InterlockedCompareExchange64(&qword_18D6405E0[v75 + 36190], v76 | (1LL << v71), v76) );
			//         atmosphereParams_k__BackingField = v229;
			//       }
			//       v234.atmosphereParams = atmosphereParams_k__BackingField;
			//       v207 = 0;
			//       v77 = *(SkyAtmospherePassConstructor **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m02;
			//       if ( !v77 )
			//         sub_1802DC2C8(0LL, v71);
			//       HG::Rendering::Runtime::SkyAtmospherePassConstructor::ConstructPass(
			//         v77,
			//         &v234,
			//         (SkyAtmospherePassConstructor_PassOutput *)&v207,
			//         m_RenderGraph,
			//         *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._InvViewProjMatrix.m21,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v310 )
			//     {
			//       *(Il2CppExceptionWrapper *)viewHandle = (Il2CppExceptionWrapper)v310.ex;
			//       if ( *(_QWORD *)viewHandle )
			//         sub_18000F780(*(_QWORD *)viewHandle);
			//       v10 = 5LL;
			//       v32 = 2LL;
			//       v3 = this;
			//       m_RenderGraph = v219;
			//       hgCamera = v220;
			//     }
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)0xFu,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     *(_QWORD *)viewHandle = 0LL;
			//     *(_QWORD *)&viewHandle[2] = &v365;
			//     try
			//     {
			//       v230 = 0LL;
			//       v80 = v224.fields._settingParameters_k__BackingField;
			//       if ( !v80 )
			//         sub_1802DC2C8(v79, v78);
			//       v81 = v80.fields._atmosphereParams_k__BackingField;
			//       v230 = v81;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v82 = (((unsigned __int64)&v230 >> 12) & 0x1FFFFF) >> 6;
			//         v78 = ((unsigned __int64)&v230 >> 12) & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v82 + 36190]);
			//         do
			//           v83 = qword_18D6405E0[v82 + 36190];
			//         while ( v83 != _InterlockedCompareExchange64(&qword_18D6405E0[v82 + 36190], v83 | (1LL << v78), v83) );
			//         v81 = v230;
			//       }
			//       v235.atmosphereParams = v81;
			//       v207 = 0;
			//       v84 = *(BakeFogLutPassConstructor **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m22;
			//       if ( !v84 )
			//         sub_1802DC2C8(0LL, v78);
			//       HG::Rendering::Runtime::BakeFogLutPassConstructor::ConstructPass(
			//         v84,
			//         &v235,
			//         (BakeFogLutPassConstructor_PassOutput *)&v207,
			//         m_RenderGraph,
			//         *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._InvViewProjMatrix.m21,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v311 )
			//     {
			//       *(Il2CppExceptionWrapper *)viewHandle = (Il2CppExceptionWrapper)v311.ex;
			//       if ( *(_QWORD *)viewHandle )
			//         sub_18000F780(*(_QWORD *)viewHandle);
			//       v10 = 5LL;
			//       v32 = 2LL;
			//       v3 = this;
			//       m_RenderGraph = v219;
			//       hgCamera = v220;
			//     }
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)0x11u,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     *(_QWORD *)viewHandle = 0LL;
			//     *(_QWORD *)&viewHandle[2] = &v365;
			//     try
			//     {
			//       *(_QWORD *)&v237[9] = 0LL;
			//       *(_DWORD *)&v237[17] = 0;
			//       *(_WORD *)&v237[21] = 0;
			//       v237[23] = 0;
			//       v87 = cullingResults;
			//       v236 = cullingResults;
			//       *(ScriptableRenderContext *)v237 = renderContext[0];
			//       v237[8] = v358[392];
			//       v88 = renderPathParams.hgrp;
			//       if ( !v88 )
			//         sub_1802DC2C8(v86, v85);
			//       *(_QWORD *)&v237[16] = v88.fields.drawInteractionNodeMaterial;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v89 = (((unsigned __int64)&v237[16] >> 12) & 0x1FFFFF) >> 6;
			//         v85 = ((unsigned __int64)&v237[16] >> 12) & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v89 + 36190]);
			//         do
			//           v90 = qword_18D6405E0[v89 + 36190];
			//         while ( v90 != _InterlockedCompareExchange64(&qword_18D6405E0[v89 + 36190], v90 | (1LL << v85), v90) );
			//         v87 = v236;
			//       }
			//       v294.cullingResults = v87;
			//       *(_OWORD *)&v294.renderContext.m_Ptr = *(_OWORD *)v237;
			//       v294.drawInteractionNodeMaterial = *(Material **)&v237[16];
			//       v215 = 0;
			//       v91 = *(TerrainDeformPassConstructor **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m03;
			//       if ( !v91 )
			//         sub_1802DC2C8(0LL, v85);
			//       HG::Rendering::Runtime::TerrainDeformPassConstructor::ConstructPass(
			//         v91,
			//         &v294,
			//         &v215,
			//         m_RenderGraph,
			//         *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._InvViewProjMatrix.m21,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v312 )
			//     {
			//       *(Il2CppExceptionWrapper *)viewHandle = (Il2CppExceptionWrapper)v312.ex;
			//       if ( *(_QWORD *)viewHandle )
			//         sub_18000F780(*(_QWORD *)viewHandle);
			//       v10 = 5LL;
			//       v32 = 2LL;
			//       v3 = this;
			//       m_RenderGraph = v219;
			//       hgCamera = v220;
			//     }
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)0x21u,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     *(_QWORD *)viewHandle = 0LL;
			//     *(_QWORD *)&viewHandle[2] = &v365;
			//     try
			//     {
			//       sub_1802F01E0(&v298.characterOutlineEnable + 1, 0LL, 183LL);
			//       v298.characterOutlineEnable = CharOutlinePassEnableState;
			//       if ( !hgCamera )
			//         sub_1802DC2C8(v93, v92);
			//       v298.screenCullingLayerMask = HG::Rendering::Runtime::HGCamera::get_screenCullingLayerMask(hgCamera, 0LL);
			//       *(_QWORD *)&v298.screenCullingRatio = *(_QWORD *)&hgCamera.fields.screenCullingRatio;
			//       v298.bakedLightingConfig = v224.fields.m_CurrentRendererConfigurationBakedLighting;
			//       v298.cullingResults = cullingResults;
			//       v298.shadowResult = *(ShadowResult *)&v3[1].fields._._._.m_basicTransformConstants._InvPretransformMatrix.m01;
			//       v298.hgrp = v224;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v94 = (((unsigned __int64)&v298.hgrp >> 12) & 0x1FFFFF) >> 6;
			//         _m_prefetchw(&qword_18D6405E0[v94 + 36190]);
			//         do
			//           v95 = qword_18D6405E0[v94 + 36190];
			//         while ( v95 != _InterlockedCompareExchange64(
			//                          &qword_18D6405E0[v94 + 36190],
			//                          v95 | (1LL << (((unsigned __int64)&v298.hgrp >> 12) & 0x3F)),
			//                          v95) );
			//       }
			//       v298.renderContext = renderContext[0];
			//       v298.characterPrePassECSList = LODWORD(v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m01);
			//       v298.forwardOpaquePreZECSList = LODWORD(v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m10);
			//       *(_QWORD *)&v298.forwardOpaqueECSList = *(_QWORD *)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m12;
			//       v298.characterOpaqueECSList = LODWORD(v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m13);
			//       v298.characterOutlineOpaqueECSList = LODWORD(v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m32);
			//       v298.characterOutlineOpaqueEqualECSList = LODWORD(v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m03);
			//       v298.sceneColorTexture = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewNoTransProjMatrix.m23;
			//       v298.sceneDepthTexture = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m20;
			//       v330 = v298;
			//       v216 = 0;
			//       v96 = *(FakePlanarReflectionPass **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m02;
			//       if ( !v96 )
			//         sub_1802DC2C8(0LL, &v3.fields._._._.m_shaderVariablesGlobal);
			//       HG::Rendering::Runtime::FakePlanarReflectionPass::ConstructPass(
			//         v96,
			//         &v330,
			//         &v216,
			//         &v3.fields._._._.m_basicTransformConstants,
			//         &v3.fields._._._.m_shaderVariablesGlobal,
			//         m_RenderGraph,
			//         *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._InvViewProjMatrix.m21,
			//         settingParameters,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v313 )
			//     {
			//       *(Il2CppExceptionWrapper *)viewHandle = (Il2CppExceptionWrapper)v313.ex;
			//       if ( *(_QWORD *)viewHandle )
			//         sub_18000F780(*(_QWORD *)viewHandle);
			//       v10 = 5LL;
			//       v32 = 2LL;
			//       v3 = this;
			//       m_RenderGraph = v219;
			//       hgCamera = v220;
			//     }
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)0x29u,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     lightCullResult.handle = 0LL;
			//     lightCullResult.fallBackResource = (ResourceHandle)&v365;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//     v97 = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields;
			//     deferredDecal = v97.deferredDecal;
			//     if ( !deferredDecal )
			//       sub_1802DC2C8(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager, 0LL);
			//     deferredErosion = (ReflectionProbeBinningPassConstructor_PassOutput *)v97.deferredErosion;
			//     if ( !deferredErosion )
			//       sub_1802DC2C8(0LL, deferredDecal);
			//     v207 = deferredErosion[16];
			//     if ( deferredDecal.fields.m_defaultValue )
			//     {
			//       v100 = *(_QWORD *)&v3[1].fields._._._.m_basicTransformConstants._InvViewProjMatrix.m21;
			//       if ( !v100 )
			//         sub_1802DC2C8(deferredErosion, deferredDecal);
			//       viewHandle[0] = *(_DWORD *)(v100 + 2592);
			//       if ( !m_RenderGraph )
			//         sub_1802DC2C8(deferredErosion, deferredDecal);
			//       *(_QWORD *)v227 = m_RenderGraph.fields.m_RenderGraphContext;
			//       if ( !*(_QWORD *)v227 )
			//         sub_1802DC2C8(deferredErosion, deferredDecal);
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//       viewHandle[0] = UnityEngine::HyperGryph::HGDecalRender::CreateRendererList(
			//                         viewHandle[0],
			//                         2u,
			//                         *(void **)(*(_QWORD *)v227 + 16LL),
			//                         0LL,
			//                         0LL);
			//       v227[0] = -1;
			//     }
			//     else
			//     {
			//       v227[0] = -1;
			//       viewHandle[0] = -1;
			//     }
			//     if ( v207 )
			//     {
			//       v101 = *(_QWORD *)&v3[1].fields._._._.m_basicTransformConstants._InvViewProjMatrix.m21;
			//       if ( !v101 )
			//         sub_1802DC2C8(deferredErosion, deferredDecal);
			//       v227[0] = *(_DWORD *)(v101 + 2592);
			//       if ( !m_RenderGraph )
			//         sub_1802DC2C8(deferredErosion, deferredDecal);
			//       v211.handle = (ResourceHandle)m_RenderGraph.fields.m_RenderGraphContext;
			//       if ( !*(_QWORD *)&v211.handle )
			//         sub_1802DC2C8(deferredErosion, deferredDecal);
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//       v102 = *(void **)(*(_QWORD *)&v211.handle + 16LL);
			//       LOWORD(methoda) = 0;
			//       v227[0] = UnityEngine::HyperGryph::HGMeshRender::CreateRendererList(
			//                   v227[0],
			//                   HGRenderFlags__Enum_ShadowOnly|HGRenderFlags__Enum_Opaque,
			//                   HGRenderFlags__Enum_Opaque,
			//                   HGShaderLightMode__Enum_ErosionMobile,
			//                   (HGRenderKeyword__Enum)methoda,
			//                   v102,
			//                   0,
			//                   0,
			//                   0xFFFFFFFF,
			//                   0,
			//                   0,
			//                   0LL);
			//     }
			//     sub_1802F01E0(&v251, 0LL, 376LL);
			//     v251 = *(_OWORD *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewNoTransProjMatrix.m23;
			//     v252 = *(_OWORD *)&v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m20;
			//     v253 = *(_OWORD *)&v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m22;
			//     v254 = *(_OWORD *)&v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m21;
			//     v105 = *(_QWORD *)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m02;
			//     if ( !v105 )
			//       sub_1802DC2C8(v104, v103);
			//     v255 = *(_OWORD *)(v105 + 4536);
			//     v106 = *(_QWORD *)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m22;
			//     if ( !v106 )
			//       sub_1802DC2C8(v104, v103);
			//     v256 = *(_OWORD *)(v106 + 24);
			//     v258 = cullingResults;
			//     v259 = *(_OWORD *)&v3[1].fields._._._.m_basicTransformConstants._InvPretransformMatrix.m01;
			//     v260 = *(_OWORD *)&v3[1].fields._._._.m_basicTransformConstants._InvPretransformMatrix.m02;
			//     v261 = *(_OWORD *)&v3[1].fields._._._.m_basicTransformConstants._InvPretransformMatrix.m03;
			//     v262 = *(_QWORD *)&v3[1].fields._._._.m_basicTransformConstants._WorldSpaceCameraPos_Internal.x;
			//     z = v3[1].fields._._._.m_basicTransformConstants._WorldSpaceCameraPos_Internal.z;
			//     v264 = v224;
			//     if ( dword_18D8E43F8 )
			//     {
			//       v107 = (((unsigned __int64)&v264 >> 12) & 0x1FFFFF) >> 6;
			//       v103 = ((unsigned __int64)&v264 >> 12) & 0x3F;
			//       _m_prefetchw(&qword_18D6405E0[v107 + 36190]);
			//       do
			//       {
			//         v104 = qword_18D6405E0[v107 + 36190] | (1LL << v103);
			//         v108 = qword_18D6405E0[v107 + 36190];
			//       }
			//       while ( v108 != _InterlockedCompareExchange64(&qword_18D6405E0[v107 + 36190], v104, v108) );
			//     }
			//     v265 = *(_OWORD *)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewProjMatrix.m21;
			//     v266 = *(_OWORD *)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewProjMatrix.m22;
			//     v267 = CharOutlinePassEnableState;
			//     if ( !hgCamera )
			//       sub_1802DC2C8(v104, v103);
			//     screenCullingRatio = hgCamera.fields.screenCullingRatio;
			//     screenRatioCullingDistance = hgCamera.fields.screenRatioCullingDistance;
			//     screenCullingLayerMask = HG::Rendering::Runtime::HGCamera::get_screenCullingLayerMask(hgCamera, 0LL);
			//     m00 = v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m00;
			//     m10 = v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m10;
			//     m30 = v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m30;
			//     m11 = v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m11;
			//     m21 = v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m21;
			//     m31 = v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m31;
			//     m02 = v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m02;
			//     v278 = viewHandle[0];
			//     v279 = v227[0];
			//     m12 = v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m12;
			//     m22 = v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m22;
			//     m13 = v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m13;
			//     m01 = v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m01;
			//     m32 = v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m32;
			//     m03 = v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m03;
			//     v289 = v332;
			//     p_punctualLightIndices = &output.punctualLightIndices;
			//     v286 = v334;
			//     v287 = v335;
			//     v288 = v336;
			//     if ( dword_18D8E43F8 )
			//     {
			//       v109 = (((unsigned __int64)&v288 >> 12) & 0x1FFFFF) >> 6;
			//       _m_prefetchw(&qword_18D6405E0[v109 + 36190]);
			//       do
			//         v110 = qword_18D6405E0[v109 + 36190];
			//       while ( v110 != _InterlockedCompareExchange64(
			//                         &qword_18D6405E0[v109 + 36190],
			//                         v110 | (1LL << (((unsigned __int64)&v288 >> 12) & 0x3F)),
			//                         v110) );
			//     }
			//     v291 = v359;
			//     currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//     if ( !currentManagerContext )
			//       sub_1802DC2C8(v113, v112);
			//     waterManager_k__BackingField = currentManagerContext.fields._waterManager_k__BackingField;
			//     if ( !waterManager_k__BackingField )
			//       sub_1802DC2C8(0LL, v112);
			//     v292 = HG::Rendering::Runtime::HGWaterManager::GetTerrainRippleOpacity(waterManager_k__BackingField, 0LL) > 0.0;
			//     v115 = &v337;
			//     v116 = &v251;
			//     v117 = 2LL;
			//     do
			//     {
			//       v115.sceneColor = (TextureHandle)*v116;
			//       v115.sceneDepth = (TextureHandle)v116[1];
			//       v115.sceneDepthCopied = (TextureHandle)v116[2];
			//       v115.sceneMV = (TextureHandle)v116[3];
			//       v115.planarReflectionTexture = (TextureHandle)v116[4];
			//       v115.fogBakeLutTexture = (TextureHandle)v116[5];
			//       v115.ssrLightingTexture = (TextureHandle)v116[6];
			//       v115 = (OnePassDeferredPassConstructor_PassInput *)((char *)v115 + 128);
			//       *(_OWORD *)&v115[-1].punctualLightIndices = v116[7];
			//       v116 += 8;
			//       --v117;
			//     }
			//     while ( v117 );
			//     v115.sceneColor = (TextureHandle)*v116;
			//     v115.sceneDepth = (TextureHandle)v116[1];
			//     v115.sceneDepthCopied = (TextureHandle)v116[2];
			//     v115.sceneMV = (TextureHandle)v116[3];
			//     v115.planarReflectionTexture = (TextureHandle)v116[4];
			//     v115.fogBakeLutTexture = (TextureHandle)v116[5];
			//     v115.ssrLightingTexture = (TextureHandle)v116[6];
			//     v115.cullingResults.ptr = (void *)*((_QWORD *)v116 + 14);
			//     v210 = 0;
			//     v118 = *(OnePassDeferredPassConstructor **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m22;
			//     v119 = *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._InvViewProjMatrix.m21;
			//     if ( LOBYTE(v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m21) )
			//     {
			//       if ( !v118 )
			//         sub_1802DC2C8(0LL, 0LL);
			//       HG::Rendering::Runtime::OnePassDeferredPassConstructor::ConstructPassPhase0(
			//         v118,
			//         &v337,
			//         &v210,
			//         m_RenderGraph,
			//         v119,
			//         0LL);
			//     }
			//     else
			//     {
			//       if ( !v118 )
			//         sub_1802DC2C8(0LL, 0LL);
			//       HG::Rendering::Runtime::OnePassDeferredPassConstructor::ConstructPass(
			//         v118,
			//         &v337,
			//         &v210,
			//         m_RenderGraph,
			//         v119,
			//         0LL);
			//     }
			//     if ( LOBYTE(v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m21) )
			//     {
			//       UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//         (Int32Enum__Enum)0x27u,
			//         MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//       lightCullResult.handle = 0LL;
			//       lightCullResult.fallBackResource = (ResourceHandle)&v365;
			//       sub_1802F01E0(&v251, 0LL, 376LL);
			//       v251 = *(_OWORD *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewNoTransProjMatrix.m23;
			//       v252 = *(_OWORD *)&v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m20;
			//       v254 = *(_OWORD *)&v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m21;
			//       v124 = *(_QWORD *)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m02;
			//       if ( !v124 )
			//         sub_1802DC2C8(v123, v122);
			//       v255 = *(_OWORD *)(v124 + 4536);
			//       v125 = *(_QWORD *)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m01;
			//       if ( !v125 )
			//         sub_1802DC2C8(v123, v122);
			//       v257 = *(_OWORD *)(v125 + 128);
			//       v258 = cullingResults;
			//       v259 = *(_OWORD *)&v3[1].fields._._._.m_basicTransformConstants._InvPretransformMatrix.m01;
			//       v260 = *(_OWORD *)&v3[1].fields._._._.m_basicTransformConstants._InvPretransformMatrix.m02;
			//       v261 = *(_OWORD *)&v3[1].fields._._._.m_basicTransformConstants._InvPretransformMatrix.m03;
			//       v262 = *(_QWORD *)&v3[1].fields._._._.m_basicTransformConstants._WorldSpaceCameraPos_Internal.x;
			//       z = v3[1].fields._._._.m_basicTransformConstants._WorldSpaceCameraPos_Internal.z;
			//       v264 = v224;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v126 = (((unsigned __int64)&v264 >> 12) & 0x1FFFFF) >> 6;
			//         _m_prefetchw(&qword_18D6405E0[v126 + 36190]);
			//         do
			//         {
			//           v127 = ((unsigned __int64)&v264 >> 12) & 0x3F;
			//           v128 = qword_18D6405E0[v126 + 36190] | (1LL << v127);
			//           v129 = qword_18D6405E0[v126 + 36190];
			//         }
			//         while ( v129 != _InterlockedCompareExchange64(&qword_18D6405E0[v126 + 36190], v128, v129) );
			//       }
			//       v265 = *(_OWORD *)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewProjMatrix.m21;
			//       v266 = *(_OWORD *)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewProjMatrix.m22;
			//       v267 = CharOutlinePassEnableState;
			//       try
			//       {
			//         screenCullingRatio = hgCamera.fields.screenCullingRatio;
			//         screenRatioCullingDistance = hgCamera.fields.screenRatioCullingDistance;
			//         screenCullingLayerMask = HG::Rendering::Runtime::HGCamera::get_screenCullingLayerMask(hgCamera, 0LL);
			//         m12 = v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m12;
			//         m22 = v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m22;
			//         m13 = v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m13;
			//         m01 = v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m01;
			//         m32 = v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m32;
			//         m03 = v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m03;
			//         v289 = v332;
			//         p_punctualLightIndices = &output.punctualLightIndices;
			//         v291 = v359;
			//         v131 = &v338;
			//         v132 = &v251;
			//         do
			//         {
			//           v131.sceneColor = (TextureHandle)*v132;
			//           v131.sceneDepth = (TextureHandle)v132[1];
			//           v131.sceneDepthCopied = (TextureHandle)v132[2];
			//           v131.sceneMV = (TextureHandle)v132[3];
			//           v131.planarReflectionTexture = (TextureHandle)v132[4];
			//           v131.fogBakeLutTexture = (TextureHandle)v132[5];
			//           v131.ssrLightingTexture = (TextureHandle)v132[6];
			//           v131 = (OnePassDeferredPassConstructor_PassInput *)((char *)v131 + 128);
			//           *(_OWORD *)&v131[-1].punctualLightIndices = v132[7];
			//           v132 += 8;
			//           --v32;
			//         }
			//         while ( v32 );
			//         v131.sceneColor = (TextureHandle)*v132;
			//         v131.sceneDepth = (TextureHandle)v132[1];
			//         v131.sceneDepthCopied = (TextureHandle)v132[2];
			//         v131.sceneMV = (TextureHandle)v132[3];
			//         v131.planarReflectionTexture = (TextureHandle)v132[4];
			//         v131.fogBakeLutTexture = (TextureHandle)v132[5];
			//         v131.ssrLightingTexture = (TextureHandle)v132[6];
			//         v131.cullingResults.ptr = (void *)*((_QWORD *)v132 + 14);
			//         v217 = 0;
			//         v133 = *(OnePassDeferredPassConstructor **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m22;
			//         if ( !v133 )
			//           sub_1802DC2C8(0LL, v130);
			//         HG::Rendering::Runtime::OnePassDeferredPassConstructor::ConstructPassPhase1(
			//           v133,
			//           &v338,
			//           &v217,
			//           m_RenderGraph,
			//           *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._InvViewProjMatrix.m21,
			//           0LL);
			//       }
			//       catch ( Il2CppExceptionWrapper *v314 )
			//       {
			//         v120 = (unsigned __int64)&v205;
			//         lightCullResult.handle = (ResourceHandle)v314.ex;
			//         handle = (signed __int64)lightCullResult.handle;
			//         if ( lightCullResult.handle )
			//           sub_18000F780(*(_QWORD *)&lightCullResult.handle);
			//         v10 = 5LL;
			//         v3 = this;
			//         m_RenderGraph = v219;
			//         hgCamera = v220;
			//       }
			//     }
			//     if ( !settingParameters )
			//       goto LABEL_353;
			//     v134 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//              settingParameters.fields._transparentLowResOffscreenEnable_k__BackingField,
			//              MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     v208 = (GpuClothSimulationPassConstructor_PassInput)v134;
			//     if ( !HG::Rendering::Runtime::HGVFXManager::get_instance(0LL) )
			//       goto LABEL_178;
			//     instance = HG::Rendering::Runtime::HGVFXManager::get_instance(0LL);
			//     if ( !instance )
			//       goto LABEL_353;
			//     if ( HG::Rendering::Runtime::HGVFXManager::UseSceneSaturationColorAdjustment(instance, 0LL) )
			//     {
			//       v208 = 0;
			//     }
			//     else
			//     {
			// LABEL_178:
			//       if ( v134 )
			//       {
			//         if ( !hgCamera )
			//           goto LABEL_353;
			//         HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
			//           &v249,
			//           hgCamera.fields._sceneRTSize_k__BackingField.m_X / 2,
			//           (int)HIDWORD(*(_QWORD *)&hgCamera.fields._sceneRTSize_k__BackingField) / 2,
			//           0LL);
			//         handle = (signed __int64)renderPathParams;
			//         v249.colorFormat = renderPathParams.perFrameSetup.depthGraphicsFormat;
			//         v249.depthBufferBits = renderPathParams.perFrameSetup.depthBits;
			//         v249.name = (String *)"LowRes Depth";
			//         if ( dword_18D8E43F8 )
			//         {
			//           v137 = (((unsigned __int64)&v249.name >> 12) & 0x1FFFFF) >> 6;
			//           v120 = ((unsigned __int64)&v249.name >> 12) & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v137 + 36190]);
			//           do
			//           {
			//             handle = qword_18D6405E0[v137 + 36190] | (1LL << v120);
			//             v138 = qword_18D6405E0[v137 + 36190];
			//           }
			//           while ( v138 != _InterlockedCompareExchange64(&qword_18D6405E0[v137 + 36190], handle, v138) );
			//         }
			//         v324 = v249;
			//         if ( !m_RenderGraph )
			//           goto LABEL_353;
			//         *(TextureHandle *)viewHandle = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                                           &v228,
			//                                           m_RenderGraph,
			//                                           &v324,
			//                                           0LL);
			//         handle = *(_QWORD *)&v3[1].fields._._._.m_basicTransformConstants._InvViewProjMatrix.m21;
			//         if ( !handle )
			//           goto LABEL_353;
			//         if ( HG::Rendering::Runtime::HGCamera::ShouldRenderWater((HGCamera *)handle, 0LL) )
			//         {
			//           HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
			//             &v249,
			//             hgCamera.fields._sceneRTSize_k__BackingField.m_X / 2,
			//             (int)HIDWORD(*(_QWORD *)&hgCamera.fields._sceneRTSize_k__BackingField) / 2,
			//             0LL);
			//           v249.colorFormat = 49;
			//           v325 = v249;
			//           v139 = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(&v228, m_RenderGraph, &v325, 0LL);
			//         }
			//         else
			//         {
			//           sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//           v139 = (TextureHandle *)sub_182E7CCD0(&v228);
			//         }
			//         lightCullResult = *v139;
			//         v140 = lightCullResult;
			//         v141 = *(Rect *)&v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m20;
			//         sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//         IsValid = HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&lightCullResult, 0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::LowResBlitPass);
			//         v211 = v140;
			//         *(_OWORD *)v227 = *(_OWORD *)viewHandle;
			//         v232 = v141;
			//         HG::Rendering::Runtime::LowResBlitPass::DownsampleDepth(
			//           m_RenderGraph,
			//           (TextureHandle *)&v232,
			//           (TextureHandle *)v227,
			//           &v211,
			//           (DownsampleDepthOutput__Enum)++IsValid,
			//           0LL);
			//         v136 = lightCullResult;
			//         goto LABEL_190;
			//       }
			//     }
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     *(_OWORD *)viewHandle = *(_OWORD *)sub_182E7CCD0(&v228);
			//     v136 = *(TextureHandle *)sub_182E7CCD0(&v228);
			// LABEL_190:
			//     v143 = *(TextureHandle **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m01;
			//     if ( !v143 )
			//       goto LABEL_353;
			//     v211 = v143[8];
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&v211, 0LL) )
			//     {
			//       v149 = *(_QWORD *)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m21;
			//       handle = *(_QWORD *)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m01;
			//       if ( !handle || !v149 )
			//         goto LABEL_353;
			//       *(_OWORD *)(v149 + 120) = *(_OWORD *)(handle + 128);
			//     }
			//     else
			//     {
			//       UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//         (Int32Enum__Enum)5u,
			//         MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGRenderPathScene::OtherPassScope>);
			//       lightCullResult.handle = 0LL;
			//       lightCullResult.fallBackResource = (ResourceHandle)&v365;
			//       try
			//       {
			//         sub_1802F01E0(&v238, 0LL, 152LL);
			//         v146 = *(_QWORD *)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m20;
			//         if ( !v146 )
			//           sub_1802DC2C8(v145, v144);
			//         *(_OWORD *)&v238.width = *(_OWORD *)(v146 + 32);
			//         v147 = *(_QWORD *)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m01;
			//         if ( !v147 )
			//           sub_1802DC2C8(v145, v144);
			//         *(_OWORD *)&v238.colorFormat = *(_OWORD *)(v147 + 304);
			//         *(_OWORD *)&v238.enableRandomWrite = *(_OWORD *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewNoTransProjMatrix.m23;
			//         *(_OWORD *)&v238.fastMemoryDesc.inFastMemory = *(_OWORD *)&v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m20;
			//         v238.clearColor = *(Color *)&v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m22;
			//         v240 = *(CullingResults *)&v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m21;
			//         sceneColor_k__BackingField.handle = (ResourceHandle)renderContext[0];
			//         v239 = v136;
			//         v326.sectorTexture = *(TextureHandle *)&v238.width;
			//         v326.interactionTexture = *(TextureHandle *)&v238.colorFormat;
			//         v326.sceneColor = *(TextureHandle *)&v238.enableRandomWrite;
			//         v326.sceneColorCopied = *(TextureHandle *)&v238.bindTextureMS;
			//         v326.sceneDepth = *(TextureHandle *)&v238.fastMemoryDesc.inFastMemory;
			//         v326.sceneDepthCopied = (TextureHandle)v238.clearColor;
			//         v326.lowResSceneDepth = v136;
			//         v326.sceneMV = (TextureHandle)v240;
			//         v326.gBufferATexture = v241;
			//         v326.srpContext = renderContext[0];
			//         memset(&v296, 0, sizeof(v296));
			//         v148 = *(WaterOnePassDeferredRenderingPass **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m21;
			//         if ( !v148 )
			//           sub_1802DC2C8(0LL, v144);
			//         HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::RenderReflectPass(
			//           v148,
			//           &v326,
			//           &v296,
			//           m_RenderGraph,
			//           hgCamera,
			//           settingParameters,
			//           0LL);
			//       }
			//       catch ( Il2CppExceptionWrapper *v315 )
			//       {
			//         lightCullResult.handle = (ResourceHandle)v315.ex;
			//         if ( lightCullResult.handle )
			//           sub_18000F780(*(_QWORD *)&lightCullResult.handle);
			//         v10 = 5LL;
			//         v3 = this;
			//         m_RenderGraph = v219;
			//         hgCamera = v220;
			//       }
			//     }
			//     v207 = 0;
			//     sub_1802F01E0(&v250, 0LL, 64LL);
			//     v250.sceneColor = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewNoTransProjMatrix.m23;
			//     v250.sceneDepth = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m20;
			//     v250.sceneDepthCopied = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m22;
			//     v150 = v224.fields._settingParameters_k__BackingField;
			//     if ( v150 )
			//     {
			//       v250.volumetricParameters = v150.fields._volumetricCloud_k__BackingField;
			//       v151 = dword_18D8E43F8;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v152 = (((unsigned __int64)&v250.volumetricParameters >> 12) & 0x1FFFFF) >> 6;
			//         v120 = ((unsigned __int64)&v250.volumetricParameters >> 12) & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v152 + 36190]);
			//         do
			//           v153 = qword_18D6405E0[v152 + 36190];
			//         while ( v153 != _InterlockedCompareExchange64(&qword_18D6405E0[v152 + 36190], v153 | (1LL << v120), v153) );
			//         v151 = dword_18D8E43F8;
			//       }
			//       v250.volumetricRenderObjects = v361;
			//       if ( v151 )
			//       {
			//         v154 = (((unsigned __int64)&v250.volumetricRenderObjects >> 12) & 0x1FFFFF) >> 6;
			//         v120 = ((unsigned __int64)&v250.volumetricRenderObjects >> 12) & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v154 + 36190]);
			//         do
			//           v155 = qword_18D6405E0[v154 + 36190];
			//         while ( v155 != _InterlockedCompareExchange64(&qword_18D6405E0[v154 + 36190], v155 | (1LL << v120), v155) );
			//       }
			//       v320 = v250;
			//       handle = *(_QWORD *)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m03;
			//       if ( handle )
			//       {
			//         if ( HG::Rendering::Runtime::VolumetricCloudPassConstructor::ShouldRenderVolumetricCloud(
			//                (VolumetricCloudPassConstructor *)handle,
			//                &v320,
			//                0LL) )
			//         {
			//           v156 = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m20;
			//           v157 = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m22;
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//           CameraDepthTexture = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._CameraDepthTexture;
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
			//           v232 = 0LL;
			//           lightCullResult = v157;
			//           v211 = v156;
			//           HG::Rendering::Runtime::CopyTexturePass::BlitTexture(
			//             m_RenderGraph,
			//             &v211,
			//             &lightCullResult,
			//             0,
			//             CameraDepthTexture,
			//             0,
			//             &v232,
			//             0,
			//             0LL);
			//           v207 = (ReflectionProbeBinningPassConstructor_PassOutput)1;
			//         }
			//         UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//           (Int32Enum__Enum)0x10u,
			//           MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//         lightCullResult.handle = 0LL;
			//         lightCullResult.fallBackResource = (ResourceHandle)&v365;
			//         try
			//         {
			//           v223 = 0;
			//           v160 = *(VolumetricCloudPassConstructor **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m03;
			//           if ( !v160 )
			//             sub_1802DC2C8(0LL, v159);
			//           HG::Rendering::Runtime::VolumetricCloudPassConstructor::ConstructPass(
			//             v160,
			//             &v320,
			//             &v223,
			//             m_RenderGraph,
			//             *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._InvViewProjMatrix.m21,
			//             0LL);
			//         }
			//         catch ( Il2CppExceptionWrapper *v305 )
			//         {
			//           lightCullResult.handle = (ResourceHandle)v305.ex;
			//           if ( lightCullResult.handle )
			//             sub_18000F780(*(_QWORD *)&lightCullResult.handle);
			//           v10 = 5LL;
			//           v3 = this;
			//           m_RenderGraph = v219;
			//           hgCamera = v220;
			//         }
			//         if ( !*(_BYTE *)&v208
			//           || (v211 = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m21,
			//               sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle),
			//               !HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&v211, 0LL)) )
			//         {
			//           sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//           v161 = (TextureHandle *)sub_182E7CCD0(&v228);
			//           goto LABEL_224;
			//         }
			//         v211 = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m21;
			//         if ( m_RenderGraph )
			//         {
			//           v321 = *HG::Rendering::RenderGraphModule::HGRenderGraph::GetTextureDesc(&v238, m_RenderGraph, &v211, 0LL);
			//           if ( hgCamera )
			//           {
			//             v321.width = hgCamera.fields._sceneRTSize_k__BackingField.m_X / 2;
			//             v321.height = (int)HIDWORD(*(_QWORD *)&hgCamera.fields._sceneRTSize_k__BackingField) / 2;
			//             v161 = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(&v228, m_RenderGraph, &v321, 0LL);
			// LABEL_224:
			//             v162 = *v161;
			//             *(TextureHandle *)&renderContext[0].m_Ptr = *v161;
			//             sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//             *(_OWORD *)v227 = *(_OWORD *)sub_182E7CCD0(&v228);
			//             UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//               (Int32Enum__Enum)0x2Bu,
			//               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//             lightCullResult.handle = 0LL;
			//             lightCullResult.fallBackResource = (ResourceHandle)&v365;
			//             try
			//             {
			//               memset(&v238, 0, 48);
			//               v164 = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewNoTransProjMatrix.m23;
			//               v165 = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m20;
			//               v166 = settingParameters;
			//               lightShaft_k__BackingField = settingParameters.fields._lightShaft_k__BackingField;
			//               if ( !lightShaft_k__BackingField )
			//                 sub_1802DC2C8(0LL, v163);
			//               v238.enableRandomWrite = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                                          lightShaft_k__BackingField.fields.enableLightShaft,
			//                                          MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//               v169 = v166.fields._lightShaft_k__BackingField;
			//               if ( !v169 )
			//                 sub_1802DC2C8(0LL, v168);
			//               v238.anisoLevel = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                                   v169.fields.lightShaftDownSampleFactor,
			//                                   MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//               v171 = v166.fields._lightShaft_k__BackingField;
			//               if ( !v171 )
			//                 sub_1802DC2C8(0LL, v170);
			//               LODWORD(v238.mipMapBias) = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//                                            (SettingParameter_1_System_Int32Enum_ *)v171.fields.lightShaftSampleNum,
			//                                            MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//               v173 = v166.fields._lightShaft_k__BackingField;
			//               if ( !v173 )
			//                 sub_1802DC2C8(0LL, v172);
			//               v238.msaaSamples = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//                                    (SettingParameter_1_System_Int32Enum_ *)v173.fields.lightShaftBlurPassCount,
			//                                    MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//               v297.sceneColor = v164;
			//               v297.sceneDepth = v165;
			//               *(_OWORD *)&v297.enableLightShaft = *(_OWORD *)&v238.enableRandomWrite;
			//               memset(&v243, 0, sizeof(v243));
			//               v175 = *(LightShaftPassConstructor **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m00;
			//               if ( !v175 )
			//                 sub_1802DC2C8(0LL, v174);
			//               HG::Rendering::Runtime::LightShaftPassConstructor::ConstructPass(
			//                 v175,
			//                 &v297,
			//                 &v243,
			//                 m_RenderGraph,
			//                 *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._InvViewProjMatrix.m21,
			//                 0LL);
			//               *(LightShaftPassConstructor_PassOutput *)&v3[1].fields._._._.m_basicTransformConstants._WorldSpaceCameraPos_Internal.w = v243;
			//             }
			//             catch ( Il2CppExceptionWrapper *v317 )
			//             {
			//               lightCullResult.handle = (ResourceHandle)v317.ex;
			//               if ( lightCullResult.handle )
			//                 sub_18000F780(*(_QWORD *)&lightCullResult.handle);
			//               v10 = 5LL;
			//               v3 = this;
			//               m_RenderGraph = v219;
			//               hgCamera = v220;
			//               v162 = *(TextureHandle *)&renderContext[0].m_Ptr;
			//             }
			//             UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//               (Int32Enum__Enum)0x28u,
			//               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//             lightCullResult.handle = 0LL;
			//             lightCullResult.fallBackResource = (ResourceHandle)&v365;
			//             try
			//             {
			//               if ( !*(_BYTE *)&v207 )
			//               {
			//                 v176 = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m20;
			//                 v177 = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m22;
			//                 sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//                 v178 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._CameraDepthTexture;
			//                 sub_180002C70(TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
			//                 v232 = 0LL;
			//                 v211 = v177;
			//                 v228 = v176;
			//                 HG::Rendering::Runtime::CopyTexturePass::BlitTexture(
			//                   m_RenderGraph,
			//                   &v228,
			//                   &v211,
			//                   0,
			//                   v178,
			//                   0,
			//                   &v232,
			//                   0,
			//                   0LL);
			//               }
			//               sub_1802F01E0(v339, 0LL, 4768LL);
			//               v339[0] = *(_OWORD *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewNoTransProjMatrix.m23;
			//               if ( v208 )
			//                 v179 = *(_OWORD *)viewHandle;
			//               else
			//                 v179 = *(_OWORD *)&v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m20;
			//               v339[1] = v179;
			//               v339[4] = *(_OWORD *)&v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m22;
			//               if ( v208 )
			//                 v180 = v162;
			//               else
			//                 v180 = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m21;
			//               v339[2] = v180;
			//               v339[3] = *(_OWORD *)&v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m22;
			//               v340 = v224;
			//               if ( dword_18D8E43F8 )
			//               {
			//                 v181 = (((unsigned __int64)&v340 >> 12) & 0x1FFFFF) >> 6;
			//                 _m_prefetchw(&qword_18D6405E0[v181 + 36190]);
			//                 do
			//                   v182 = qword_18D6405E0[v181 + 36190];
			//                 while ( v182 != _InterlockedCompareExchange64(
			//                                   &qword_18D6405E0[v181 + 36190],
			//                                   v182 | (1LL << (((unsigned __int64)&v340 >> 12) & 0x3F)),
			//                                   v182) );
			//               }
			//               v341 = sub_18003ED00(18LL);
			//               v342 = *(_OWORD *)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewProjMatrix.m21;
			//               v343 = *(_OWORD *)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewProjMatrix.m22;
			//               v344[0] = *(_QWORD *)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m21;
			//               if ( dword_18D8E43F8 )
			//               {
			//                 v184 = (((unsigned __int64)v344 >> 12) & 0x1FFFFF) >> 6;
			//                 v183 = ((unsigned __int64)v344 >> 12) & 0x3F;
			//                 _m_prefetchw(&qword_18D6405E0[v184 + 36190]);
			//                 do
			//                   v185 = qword_18D6405E0[v184 + 36190];
			//                 while ( v185 != _InterlockedCompareExchange64(
			//                                   &qword_18D6405E0[v184 + 36190],
			//                                   v185 | (1LL << v183),
			//                                   v185) );
			//               }
			//               v345 = cullingResults;
			//               m_CurrentRendererConfigurationBakedLighting = (unsigned int)v224.fields.m_CurrentRendererConfigurationBakedLighting;
			//               v346 = v224.fields.m_CurrentRendererConfigurationBakedLighting;
			//               m23 = v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m23;
			//               v348 = CharOutlinePassEnableState;
			//               if ( !hgCamera )
			//                 sub_1802DC2C8(m_CurrentRendererConfigurationBakedLighting, v183);
			//               v349 = hgCamera.fields.screenCullingRatio;
			//               v350 = hgCamera.fields.screenRatioCullingDistance;
			//               v351 = HG::Rendering::Runtime::HGCamera::get_screenCullingLayerMask(hgCamera, 0LL);
			//               v187 = settingParameters;
			//               v352 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                        settingParameters.fields._transparentLowResVRSEnable_k__BackingField,
			//                        MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//               v353 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//                        (SettingParameter_1_System_Int32Enum_ *)v187.fields._transparentVRRx_k__BackingField,
			//                        MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//               v354 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//                        (SettingParameter_1_System_Int32Enum_ *)v187.fields._transparentVRRy_k__BackingField,
			//                        MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//               v188 = v208;
			//               v355 = v208;
			//               p_m00 = (_OWORD *)&v3.fields._._._.m_basicTransformConstants._ViewMatrix.m00;
			//               v190 = &v356;
			//               do
			//               {
			//                 *(_OWORD *)v190 = *p_m00;
			//                 *((_OWORD *)v190 + 1) = p_m00[1];
			//                 *((_OWORD *)v190 + 2) = p_m00[2];
			//                 *((_OWORD *)v190 + 3) = p_m00[3];
			//                 *((_OWORD *)v190 + 4) = p_m00[4];
			//                 *((_OWORD *)v190 + 5) = p_m00[5];
			//                 *((_OWORD *)v190 + 6) = p_m00[6];
			//                 v190 += 128;
			//                 *((_OWORD *)v190 - 1) = p_m00[7];
			//                 p_m00 += 8;
			//                 --v10;
			//               }
			//               while ( v10 );
			//               *(_OWORD *)v190 = *p_m00;
			//               *((_OWORD *)v190 + 1) = p_m00[1];
			//               *((_OWORD *)v190 + 2) = p_m00[2];
			//               *((_OWORD *)v190 + 3) = p_m00[3];
			//               *((_OWORD *)v190 + 4) = p_m00[4];
			//               sub_1802EFB40(v357, &v3.fields._._._.m_shaderVariablesGlobal, 3792LL);
			//               sub_1802EFB40(v358, v339, 4768LL);
			//               sub_1802EFB40(&v362, v358, 4768LL);
			//               v245 = 0LL;
			//               v192 = *(TransparentPassConstructor **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m23;
			//               if ( !v192 )
			//                 sub_1802DC2C8(0LL, v191);
			//               HG::Rendering::Runtime::TransparentPassConstructor::ConstructPass(
			//                 v192,
			//                 &v362,
			//                 &v245,
			//                 m_RenderGraph,
			//                 *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._InvViewProjMatrix.m21,
			//                 0LL);
			//             }
			//             catch ( Il2CppExceptionWrapper *v318 )
			//             {
			//               lightCullResult.handle = (ResourceHandle)v318.ex;
			//               if ( lightCullResult.handle )
			//                 sub_18000F780(*(_QWORD *)&lightCullResult.handle);
			//               v3 = this;
			//               m_RenderGraph = v219;
			//               hgCamera = v220;
			//               if ( !*(_BYTE *)&v208 )
			//                 goto LABEL_260;
			//               v162 = *(TextureHandle *)&renderContext[0].m_Ptr;
			//               v193 = *(TransparentPassConstructor_PassOutput *)v227;
			//               goto LABEL_259;
			//             }
			//             if ( !*(_BYTE *)&v188 )
			//             {
			//               *(TransparentPassConstructor_PassOutput *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewNoTransProjMatrix.m23 = v245;
			//               goto LABEL_260;
			//             }
			//             v193 = v245;
			//             *(TransparentPassConstructor_PassOutput *)v227 = v245;
			// LABEL_259:
			//             v194 = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewNoTransProjMatrix.m23;
			//             v195 = *(Rect *)&v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m21;
			//             v196 = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m20;
			//             v197 = *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._InvViewProjMatrix.m21;
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::LowResBlitPass);
			//             v228 = v196;
			//             v232 = v195;
			//             lightCullResult = v194;
			//             v211 = v162;
			//             *(TransparentPassConstructor_PassOutput *)&renderContext[0].m_Ptr = v193;
			//             HG::Rendering::Runtime::LowResBlitPass::UpsampleColorAndMV(
			//               m_RenderGraph,
			//               (TextureHandle *)renderContext,
			//               &v211,
			//               &lightCullResult,
			//               (TextureHandle *)&v232,
			//               &v228,
			//               v197,
			//               0LL);
			// LABEL_260:
			//             UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//               (Int32Enum__Enum)0x2Au,
			//               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//             lightCullResult.handle = 0LL;
			//             lightCullResult.fallBackResource = (ResourceHandle)&v365;
			//             try
			//             {
			//               sub_1802F01E0(&v238, 0LL, 152LL);
			//               *(_OWORD *)&v238.width = *(_OWORD *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewNoTransProjMatrix.m23;
			//               *(_OWORD *)&v238.colorFormat = *(_OWORD *)&v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m20;
			//               *(_OWORD *)&v238.enableRandomWrite = *(_OWORD *)&v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m21;
			//               *(_OWORD *)&v238.bindTextureMS = *(_OWORD *)&v3[1].fields._._._.m_basicTransformConstants._InvPretransformMatrix.m01;
			//               *(_OWORD *)&v238.fastMemoryDesc.inFastMemory = *(_OWORD *)&v3[1].fields._._._.m_basicTransformConstants._InvPretransformMatrix.m02;
			//               v238.clearColor = *(Color *)&v3[1].fields._._._.m_basicTransformConstants._InvPretransformMatrix.m03;
			//               v239.handle = *(ResourceHandle *)&v3[1].fields._._._.m_basicTransformConstants._WorldSpaceCameraPos_Internal.x;
			//               v239.fallBackResource.m_Value = LODWORD(v3[1].fields._._._.m_basicTransformConstants._WorldSpaceCameraPos_Internal.z);
			//               v240 = cullingResults;
			//               v199 = (unsigned int)v224.fields.m_CurrentRendererConfigurationBakedLighting;
			//               v241.handle.m_Value = v224.fields.m_CurrentRendererConfigurationBakedLighting;
			//               if ( !hgCamera )
			//                 sub_1802DC2C8(v198, v199);
			//               *(_QWORD *)&v241.handle._type_k__BackingField = *(_QWORD *)&hgCamera.fields.screenCullingRatio;
			//               v241.fallBackResource._type_k__BackingField = HG::Rendering::Runtime::HGCamera::get_screenCullingLayerMask(
			//                                                               hgCamera,
			//                                                               0LL);
			//               sceneColor_k__BackingField.handle.m_Value = LODWORD(v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m33);
			//               v327.sceneColor = *(TextureHandle *)&v238.width;
			//               v327.sceneDepth = *(TextureHandle *)&v238.colorFormat;
			//               v327.sceneMV = *(TextureHandle *)&v238.enableRandomWrite;
			//               *(_OWORD *)&v327.shadowResult.directionalShadowActive = *(_OWORD *)&v238.bindTextureMS;
			//               *(_OWORD *)&v327.shadowResult.directionalShadowResult.fallBackResource._type_k__BackingField = *(_OWORD *)&v238.fastMemoryDesc.inFastMemory;
			//               *(Color *)&v327.shadowResult.characterShadowResult.fallBackResource.m_Value = v238.clearColor;
			//               *(TextureHandle *)((char *)&v327.shadowResult.punctualLightShadowResult + 4) = v239;
			//               v327.cullingResults = v240;
			//               *(TextureHandle *)&v327.bakedLightConfig = v241;
			//               *(ResourceHandle *)&v327.transparentAfterDistortionECSList = sceneColor_k__BackingField.handle;
			//               v246 = 0LL;
			//               v201 = *(DistortionPassConstructor **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m20;
			//               if ( !v201 )
			//                 sub_1802DC2C8(0LL, v200);
			//               HG::Rendering::Runtime::DistortionPassConstructor::ConstructPass(
			//                 v201,
			//                 &v327,
			//                 &v246,
			//                 m_RenderGraph,
			//                 *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._InvViewProjMatrix.m21,
			//                 0LL);
			//               *(DistortionPassConstructor_PassOutput *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewNoTransProjMatrix.m23 = v246;
			//             }
			//             catch ( Il2CppExceptionWrapper *v319 )
			//             {
			//               lightCullResult.handle = (ResourceHandle)v319.ex;
			//               if ( lightCullResult.handle )
			//                 sub_18000F780(*(_QWORD *)&lightCullResult.handle);
			//             }
			//             return;
			//           }
			//         }
			//       }
			//     }
			// LABEL_353:
			//     sub_1802DC2C8(handle, v120);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3012, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v204, v203);
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_389(Patch, (Object *)v3, renderPathParams, 0LL);
			// }
			// 
		}

		public new void <>iFixBaseProxy_OnPreRendering(ref HGRenderPathBase.HGRenderPathParams P0)
		{
			// // Void <>iFixBaseProxy_OnPreRendering(HGRenderPathBase+HGRenderPathParams ByRef)
			// void HG::Rendering::Runtime::HGRenderPathOnePassDeferred::__iFixBaseProxy_OnPreRendering(
			//         HGRenderPathOnePassDeferred *this,
			//         HGRenderPathBase_HGRenderPathParams *P0,
			//         MethodInfo *method)
			// {
			//   HG::Rendering::Runtime::HGRenderPathDeferred::OnPreRendering((HGRenderPathDeferred *)this, P0, 0LL);
			// }
			// 
		}

		private BinningPass m_binningPassConstructor;

		private ReflectionProbeBinningPassConstructor m_reflectionProbeBinningPassConstructor;

		private FoliageOccluderPassConstructor m_foliageOccluderPassConstructor;

		private SludgePassConstructor m_sludgePassConstructor;

		private GpuClothSimulationPassConstructor m_gpuClothSimulationPassConstructor;

		private ParticleLightingPassConstructor m_particleLightingPassConstructor;

		private LightClusteringPassConstructor m_lightClusteringPassConstructor;

		private DepthOnlyPassConstructor m_depthOnlyPassConstructor;

		private ShadowMapPassConstructor m_shadowMapPassConstructor;

		private SkyAtmospherePassConstructor m_skyAtmospherePassConstructor;

		private BakeFogLutPassConstructor m_bakeFogLutPassConstructor;

		private TerrainDeformPassConstructor m_terrainDeformPassConstructor;

		private TerrainVTBakePassConstructor m_terrainVTBakePassConstructor;

		private TerrainDepthPrepassConstructor m_terrainDepthPrepassConstructor;

		private WaterSectorRenderingPass m_waterSectorRenderingPassConstructor;

		private WaterInteractionRenderingPass m_waterInteractionRenderingPassConstructor;

		private WaterOnePassDeferredRenderingPass m_waterOnePassDeferredRenderingPassConstructor;

		private FakePlanarReflectionPass m_fakePlanarReflectionPassConstructor;

		private OnePassDeferredPassConstructor m_onePassDeferredPassConstructor;

		private VolumetricCloudPassConstructor m_volumetricCloudPassConstructor;

		private TransparentPassConstructor m_transparentPassConstructor;

		private LightShaftPassConstructor m_lightShaftPassConstructor;

		private DistortionPassConstructor m_distortionPassConstructor;

		private HyperScreenSpaceReflectionRenderingPass m_hyperScreenSpaceReflectionRenderingPassConstructor;

		private bool m_shouldSplitOnePass;
	}
}
