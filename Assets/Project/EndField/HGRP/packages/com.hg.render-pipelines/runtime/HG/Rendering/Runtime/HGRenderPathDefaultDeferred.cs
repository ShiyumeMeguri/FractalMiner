using System;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;

namespace HG.Rendering.Runtime
{
	internal class HGRenderPathDefaultDeferred : HGRenderPathDeferred
	{
		// (get) Token: 0x06001291 RID: 4753 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x06001292 RID: 4754 RVA: 0x000025D0 File Offset: 0x000007D0
		private protected TextureHandle sceneNormalCopied
		{
			[CompilerGenerated]
			protected get
			{
				// // TextureHandle get_sceneNormalCopied()
				// TextureHandle *HG::Rendering::Runtime::HGRenderPathDefaultDeferred::get_sceneNormalCopied(
				//         TextureHandle *__return_ptr retstr,
				//         HGRenderPathDefaultDeferred *this,
				//         MethodInfo *method)
				// {
				//   TextureHandle *result; // rax
				// 
				//   result = retstr;
				//   *retstr = *(TextureHandle *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m01;
				//   return result;
				// }
				// 
				return null;
			}
			[CompilerGenerated]
			private set
			{
				// // Void set_sceneNormalCopied(TextureHandle)
				// void HG::Rendering::Runtime::HGRenderPathDefaultDeferred::set_sceneNormalCopied(
				//         HGRenderPathDefaultDeferred *this,
				//         TextureHandle *value,
				//         MethodInfo *method)
				// {
				//   *(TextureHandle *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m01 = *value;
				// }
				// 
			}
		}

		internal HGRenderPathDefaultDeferred(HGRenderPathBase.HGRenderPathResources resources, HGCamera camera, HGRenderPathInternal renderPath)
		{
			// // HGRenderPathDefaultDeferred(HGRenderPathBase+HGRenderPathResources, HGCamera, HGRenderPathInternal)
			// void HG::Rendering::Runtime::HGRenderPathDefaultDeferred::HGRenderPathDefaultDeferred(
			//         HGRenderPathDefaultDeferred *this,
			//         HGRenderPathBase_HGRenderPathResources *resources,
			//         HGCamera *camera,
			//         HGRenderPathInternal__Enum renderPath,
			//         MethodInfo *method)
			// {
			//   PassConstructorID__Enum__Array *v9; // rax
			//   IPassConstructor *PassConstructor; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v11; // rdx
			//   HGCamera *v12; // r8
			//   MessageDescriptor *v13; // r9
			//   IPassConstructor *v14; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v15; // rdx
			//   HGCamera *v16; // r8
			//   MessageDescriptor *v17; // r9
			//   IPassConstructor *v18; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v19; // rdx
			//   HGCamera *v20; // r8
			//   MessageDescriptor *v21; // r9
			//   IPassConstructor *v22; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v23; // rdx
			//   HGCamera *v24; // r8
			//   MessageDescriptor *v25; // r9
			//   IPassConstructor *v26; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v27; // rdx
			//   HGCamera *v28; // r8
			//   MessageDescriptor *v29; // r9
			//   IPassConstructor *v30; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v31; // rdx
			//   HGCamera *v32; // r8
			//   MessageDescriptor *v33; // r9
			//   IPassConstructor *v34; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v35; // rdx
			//   HGCamera *v36; // r8
			//   MessageDescriptor *v37; // r9
			//   IPassConstructor *v38; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v39; // rdx
			//   HGCamera *v40; // r8
			//   MessageDescriptor *v41; // r9
			//   IPassConstructor *v42; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v43; // rdx
			//   HGCamera *v44; // r8
			//   MessageDescriptor *v45; // r9
			//   IPassConstructor *v46; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v47; // rdx
			//   HGCamera *v48; // r8
			//   MessageDescriptor *v49; // r9
			//   IPassConstructor *v50; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v51; // rdx
			//   HGCamera *v52; // r8
			//   MessageDescriptor *v53; // r9
			//   IPassConstructor *v54; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v55; // rdx
			//   HGCamera *v56; // r8
			//   MessageDescriptor *v57; // r9
			//   IPassConstructor *v58; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v59; // rdx
			//   HGCamera *v60; // r8
			//   MessageDescriptor *v61; // r9
			//   IPassConstructor *v62; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v63; // rdx
			//   HGCamera *v64; // r8
			//   MessageDescriptor *v65; // r9
			//   IPassConstructor *v66; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v67; // rdx
			//   HGCamera *v68; // r8
			//   MessageDescriptor *v69; // r9
			//   IPassConstructor *v70; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v71; // rdx
			//   HGCamera *v72; // r8
			//   MessageDescriptor *v73; // r9
			//   IPassConstructor *v74; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v75; // rdx
			//   HGCamera *v76; // r8
			//   MessageDescriptor *v77; // r9
			//   IPassConstructor *v78; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v79; // rdx
			//   HGCamera *v80; // r8
			//   MessageDescriptor *v81; // r9
			//   IPassConstructor *v82; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v83; // rdx
			//   HGCamera *v84; // r8
			//   MessageDescriptor *v85; // r9
			//   IPassConstructor *v86; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v87; // rdx
			//   HGCamera *v88; // r8
			//   MessageDescriptor *v89; // r9
			//   IPassConstructor *v90; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v91; // rdx
			//   HGCamera *v92; // r8
			//   MessageDescriptor *v93; // r9
			//   IPassConstructor *v94; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v95; // rdx
			//   HGCamera *v96; // r8
			//   MessageDescriptor *v97; // r9
			//   IPassConstructor *v98; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v99; // rdx
			//   HGCamera *v100; // r8
			//   MessageDescriptor *v101; // r9
			//   IPassConstructor *v102; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v103; // rdx
			//   HGCamera *v104; // r8
			//   MessageDescriptor *v105; // r9
			//   IPassConstructor *v106; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v107; // rdx
			//   HGCamera *v108; // r8
			//   MessageDescriptor *v109; // r9
			//   IPassConstructor *v110; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v111; // rdx
			//   HGCamera *v112; // r8
			//   MessageDescriptor *v113; // r9
			//   IPassConstructor *v114; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v115; // rdx
			//   HGCamera *v116; // r8
			//   MessageDescriptor *v117; // r9
			//   IPassConstructor *v118; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v119; // rdx
			//   HGCamera *v120; // r8
			//   MessageDescriptor *v121; // r9
			//   IPassConstructor *v122; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v123; // rdx
			//   HGCamera *v124; // r8
			//   MessageDescriptor *v125; // r9
			//   IPassConstructor *v126; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v127; // rdx
			//   HGCamera *v128; // r8
			//   MessageDescriptor *v129; // r9
			//   IPassConstructor *v130; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v131; // rdx
			//   HGCamera *v132; // r8
			//   MessageDescriptor *v133; // r9
			//   IPassConstructor *v134; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v135; // rdx
			//   HGCamera *v136; // r8
			//   MessageDescriptor *v137; // r9
			//   IPassConstructor *v138; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v139; // rdx
			//   HGCamera *v140; // r8
			//   MessageDescriptor *v141; // r9
			//   IPassConstructor *v142; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v143; // rdx
			//   HGCamera *v144; // r8
			//   MessageDescriptor *v145; // r9
			//   IPassConstructor *v146; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v147; // rdx
			//   HGCamera *v148; // r8
			//   MessageDescriptor *v149; // r9
			//   IPassConstructor *v150; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v151; // rdx
			//   HGCamera *v152; // r8
			//   MessageDescriptor *v153; // r9
			//   IPassConstructor *v154; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v155; // rdx
			//   HGCamera *v156; // r8
			//   MessageDescriptor *v157; // r9
			//   IPassConstructor *v158; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v159; // rdx
			//   HGCamera *v160; // r8
			//   MessageDescriptor *v161; // r9
			//   IPassConstructor *v162; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v163; // rdx
			//   HGCamera *v164; // r8
			//   MessageDescriptor *v165; // r9
			//   MethodInfo *v166; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v167; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v168; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v169; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v170; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v171; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v172; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v173; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v174; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v175; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v176; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v177; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v178; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v179; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v180; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v181; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v182; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v183; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v184; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v185; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v186; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v187; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v188; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v189; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v190; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v191; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v192; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v193; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v194; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v195; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v196; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v197; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v198; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v199; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v200; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v201; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v202; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v203; // [rsp+20h] [rbp-28h]
			//   HGRenderPathBase_HGRenderPathResources v204; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D8EDB10 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::BakeFogLutPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::BinningPass);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::BuildHZBPass);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CapsuleShadowPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ContactShadowPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::DecalPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::DeferredLightingPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::DepthOnlyPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::DepthPrepassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::DepthPyramidRenderingPass);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::DistortionPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::FakePlanarReflectionPass);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::FoliageInteractivePassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ForwardOpaquePassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::GBufferPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::GPUDrivenCullingPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::GPUParticleSimulationPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::GTAOPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::InkSimulationPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::LightClusteringPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::LightShaftPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ParticleLightingPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ShadowMapPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::SkyAtmospherePassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::SludgePassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::TerrainDeformPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::TerrainDepthPrepassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::TerrainVTBakePassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::TransparentPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricCloudPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricFogPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::WaterInteractionRenderingPass);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::WaterSectorRenderingPass);
			//     byte_18D8EDB10 = 1;
			//   }
			//   v9 = HG::Rendering::Runtime::HGRenderPathDefaultDeferred::PopulatePassConstructorIds(0LL);
			//   v204 = *resources;
			//   HG::Rendering::Runtime::HGRenderPathDeferred::HGRenderPathDeferred(
			//     (HGRenderPathDeferred *)this,
			//     &v204,
			//     v9,
			//     camera,
			//     renderPath,
			//     0LL);
			//   PassConstructor = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//                       (HGRenderPathBase *)this,
			//                       PassConstructorID__Enum_BinningPass,
			//                       0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevViewProjMatrix.m21 = sub_18003F5A0(
			//                                                                                        PassConstructor,
			//                                                                                        TypeInfo::HG::Rendering::Runtime::BinningPass);
			//   sub_18003F5A0(PassConstructor, TypeInfo::HG::Rendering::Runtime::BinningPass);
			//   sub_1800054D0((HGRenderPathDefaultDeferred *)((char *)this + 5072), v11, v12, v13, v166);
			//   v14 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_ReflectionProbeBinning,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevViewProjMatrix.m02 = sub_18003F5A0(
			//                                                                                        v14,
			//                                                                                        TypeInfo::HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor);
			//   sub_18003F5A0(v14, TypeInfo::HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor);
			//   sub_1800054D0((HGRenderPathDefaultDeferred *)((char *)this + 5080), v15, v16, v17, v167);
			//   v18 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_FoliageOccluder,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevViewProjMatrix.m22 = sub_18003F5A0(
			//                                                                                        v18,
			//                                                                                        TypeInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor);
			//   sub_18003F5A0(v18, TypeInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor);
			//   sub_1800054D0((HGRenderPathDefaultDeferred *)((char *)this + 5088), v19, v20, v21, v168);
			//   v22 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_FoliageInteractive,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevViewProjMatrix.m03 = sub_18003F5A0(
			//                                                                                        v22,
			//                                                                                        TypeInfo::HG::Rendering::Runtime::FoliageInteractivePassConstructor);
			//   sub_18003F5A0(v22, TypeInfo::HG::Rendering::Runtime::FoliageInteractivePassConstructor);
			//   sub_1800054D0((HGRenderPathDefaultDeferred *)((char *)this + 5096), v23, v24, v25, v169);
			//   v26 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_Sludge,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevViewProjMatrix.m23 = sub_18003F5A0(
			//                                                                                        v26,
			//                                                                                        TypeInfo::HG::Rendering::Runtime::SludgePassConstructor);
			//   sub_18003F5A0(v26, TypeInfo::HG::Rendering::Runtime::SludgePassConstructor);
			//   sub_1800054D0((HGRenderPathDefaultDeferred *)((char *)this + 5104), v27, v28, v29, v170);
			//   v30 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_GpuClothSimulation,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m00 = sub_18003F5A0(
			//                                                                                               v30,
			//                                                                                               TypeInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor);
			//   sub_18003F5A0(v30, TypeInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor);
			//   sub_1800054D0((HGRenderPathDefaultDeferred *)((char *)this + 5112), v31, v32, v33, v171);
			//   v34 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_LightClustering,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m01 = sub_18003F5A0(
			//                                                                                               v34,
			//                                                                                               TypeInfo::HG::Rendering::Runtime::LightClusteringPassConstructor);
			//   sub_18003F5A0(v34, TypeInfo::HG::Rendering::Runtime::LightClusteringPassConstructor);
			//   sub_1800054D0((HGRenderPathDefaultDeferred *)((char *)this + 5128), v35, v36, v37, v172);
			//   v38 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_GPUDrivenCulling,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m21 = sub_18003F5A0(
			//                                                                                               v38,
			//                                                                                               TypeInfo::HG::Rendering::Runtime::GPUDrivenCullingPassConstructor);
			//   sub_18003F5A0(v38, TypeInfo::HG::Rendering::Runtime::GPUDrivenCullingPassConstructor);
			//   sub_1800054D0((HGRenderPathDefaultDeferred *)((char *)this + 5136), v39, v40, v41, v173);
			//   v42 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_ParticleLighting,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m20 = sub_18003F5A0(
			//                                                                                               v42,
			//                                                                                               TypeInfo::HG::Rendering::Runtime::ParticleLightingPassConstructor);
			//   sub_18003F5A0(v42, TypeInfo::HG::Rendering::Runtime::ParticleLightingPassConstructor);
			//   sub_1800054D0((HGRenderPathDefaultDeferred *)((char *)this + 5120), v43, v44, v45, v174);
			//   v46 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_CustomDepthOnly,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m02 = sub_18003F5A0(
			//                                                                                               v46,
			//                                                                                               TypeInfo::HG::Rendering::Runtime::DepthOnlyPassConstructor);
			//   sub_18003F5A0(v46, TypeInfo::HG::Rendering::Runtime::DepthOnlyPassConstructor);
			//   sub_1800054D0((HGRenderPathDefaultDeferred *)((char *)this + 5144), v47, v48, v49, v175);
			//   v50 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_ShadowMap,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m22 = sub_18003F5A0(
			//                                                                                               v50,
			//                                                                                               TypeInfo::HG::Rendering::Runtime::ShadowMapPassConstructor);
			//   sub_18003F5A0(v50, TypeInfo::HG::Rendering::Runtime::ShadowMapPassConstructor);
			//   sub_1800054D0((HGRenderPathDefaultDeferred *)((char *)this + 5152), v51, v52, v53, v176);
			//   v54 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_Atmosphere,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m03 = sub_18003F5A0(
			//                                                                                               v54,
			//                                                                                               TypeInfo::HG::Rendering::Runtime::SkyAtmospherePassConstructor);
			//   sub_18003F5A0(v54, TypeInfo::HG::Rendering::Runtime::SkyAtmospherePassConstructor);
			//   sub_1800054D0((HGRenderPathDefaultDeferred *)((char *)this + 5160), v55, v56, v57, v177);
			//   v58 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_VolumetricFog,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m23 = sub_18003F5A0(
			//                                                                                               v58,
			//                                                                                               TypeInfo::HG::Rendering::Runtime::VolumetricFogPassConstructor);
			//   sub_18003F5A0(v58, TypeInfo::HG::Rendering::Runtime::VolumetricFogPassConstructor);
			//   sub_1800054D0((HGRenderPathDefaultDeferred *)((char *)this + 5168), v59, v60, v61, v178);
			//   v62 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_BakeFogLut,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m00 = sub_18003F5A0(
			//                                                                                                   v62,
			//                                                                                                   TypeInfo::HG::Rendering::Runtime::BakeFogLutPassConstructor);
			//   sub_18003F5A0(v62, TypeInfo::HG::Rendering::Runtime::BakeFogLutPassConstructor);
			//   sub_1800054D0((HGRenderPathDefaultDeferred *)((char *)this + 5176), v63, v64, v65, v179);
			//   v66 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_TerrainDeform,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m20 = sub_18003F5A0(
			//                                                                                                   v66,
			//                                                                                                   TypeInfo::HG::Rendering::Runtime::TerrainDeformPassConstructor);
			//   sub_18003F5A0(v66, TypeInfo::HG::Rendering::Runtime::TerrainDeformPassConstructor);
			//   sub_1800054D0((HGRenderPathDefaultDeferred *)((char *)this + 5184), v67, v68, v69, v180);
			//   v70 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_TerrainVTBake,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m01 = sub_18003F5A0(
			//                                                                                                   v70,
			//                                                                                                   TypeInfo::HG::Rendering::Runtime::TerrainVTBakePassConstructor);
			//   sub_18003F5A0(v70, TypeInfo::HG::Rendering::Runtime::TerrainVTBakePassConstructor);
			//   sub_1800054D0((HGRenderPathDefaultDeferred *)((char *)this + 5192), v71, v72, v73, v181);
			//   v74 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_InkSimulation,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m21 = sub_18003F5A0(
			//                                                                                                   v74,
			//                                                                                                   TypeInfo::HG::Rendering::Runtime::InkSimulationPassConstructor);
			//   sub_18003F5A0(v74, TypeInfo::HG::Rendering::Runtime::InkSimulationPassConstructor);
			//   sub_1800054D0((HGRenderPathDefaultDeferred *)((char *)this + 5200), v75, v76, v77, v182);
			//   v78 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_TerrainDepthPrepass,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m02 = sub_18003F5A0(
			//                                                                                                   v78,
			//                                                                                                   TypeInfo::HG::Rendering::Runtime::TerrainDepthPrepassConstructor);
			//   sub_18003F5A0(v78, TypeInfo::HG::Rendering::Runtime::TerrainDepthPrepassConstructor);
			//   sub_1800054D0((HGRenderPathDefaultDeferred *)((char *)this + 5208), v79, v80, v81, v183);
			//   v82 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_DepthPrepass,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m22 = sub_18003F5A0(
			//                                                                                                   v82,
			//                                                                                                   TypeInfo::HG::Rendering::Runtime::DepthPrepassConstructor);
			//   sub_18003F5A0(v82, TypeInfo::HG::Rendering::Runtime::DepthPrepassConstructor);
			//   sub_1800054D0((HGRenderPathDefaultDeferred *)((char *)this + 5216), v83, v84, v85, v184);
			//   v86 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_GBuffer,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m03 = sub_18003F5A0(
			//                                                                                                   v86,
			//                                                                                                   TypeInfo::HG::Rendering::Runtime::GBufferPassConstructor);
			//   sub_18003F5A0(v86, TypeInfo::HG::Rendering::Runtime::GBufferPassConstructor);
			//   sub_1800054D0((HGRenderPathDefaultDeferred *)((char *)this + 5224), v87, v88, v89, v185);
			//   v90 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_GPUParticleSimulation,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m23 = sub_18003F5A0(
			//                                                                                                   v90,
			//                                                                                                   TypeInfo::HG::Rendering::Runtime::GPUParticleSimulationPassConstructor);
			//   sub_18003F5A0(v90, TypeInfo::HG::Rendering::Runtime::GPUParticleSimulationPassConstructor);
			//   sub_1800054D0((HGRenderPathDefaultDeferred *)((char *)this + 5232), v91, v92, v93, v186);
			//   v94 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_Decal,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m00 = sub_18003F5A0(v94, TypeInfo::HG::Rendering::Runtime::DecalPassConstructor);
			//   sub_18003F5A0(v94, TypeInfo::HG::Rendering::Runtime::DecalPassConstructor);
			//   sub_1800054D0((HGRenderPathDefaultDeferred *)((char *)this + 5240), v95, v96, v97, v187);
			//   v98 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_WaterSector,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m20 = sub_18003F5A0(v98, TypeInfo::HG::Rendering::Runtime::WaterSectorRenderingPass);
			//   sub_18003F5A0(v98, TypeInfo::HG::Rendering::Runtime::WaterSectorRenderingPass);
			//   sub_1800054D0((HGRenderPathDefaultDeferred *)((char *)this + 5248), v99, v100, v101, v188);
			//   v102 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//            (HGRenderPathBase *)this,
			//            PassConstructorID__Enum_WaterInteraction,
			//            0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m01 = sub_18003F5A0(v102, TypeInfo::HG::Rendering::Runtime::WaterInteractionRenderingPass);
			//   sub_18003F5A0(v102, TypeInfo::HG::Rendering::Runtime::WaterInteractionRenderingPass);
			//   sub_1800054D0((HGRenderPathDefaultDeferred *)((char *)this + 5256), v103, v104, v105, v189);
			//   v106 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//            (HGRenderPathBase *)this,
			//            PassConstructorID__Enum_WaterDefaultDeferred,
			//            0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m21 = sub_18003F5A0(v106, TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass);
			//   sub_18003F5A0(v106, TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass);
			//   sub_1800054D0((HGRenderPathDefaultDeferred *)((char *)this + 5264), v107, v108, v109, v190);
			//   v110 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//            (HGRenderPathBase *)this,
			//            PassConstructorID__Enum_HZB,
			//            0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m02 = sub_18003F5A0(v110, TypeInfo::HG::Rendering::Runtime::BuildHZBPass);
			//   sub_18003F5A0(v110, TypeInfo::HG::Rendering::Runtime::BuildHZBPass);
			//   sub_1800054D0((HGRenderPathDefaultDeferred *)((char *)this + 5272), v111, v112, v113, v191);
			//   v114 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//            (HGRenderPathBase *)this,
			//            PassConstructorID__Enum_DepthPyramid,
			//            0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m22 = sub_18003F5A0(v114, TypeInfo::HG::Rendering::Runtime::DepthPyramidRenderingPass);
			//   sub_18003F5A0(v114, TypeInfo::HG::Rendering::Runtime::DepthPyramidRenderingPass);
			//   sub_1800054D0((HGRenderPathDefaultDeferred *)((char *)this + 5280), v115, v116, v117, v192);
			//   v118 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//            (HGRenderPathBase *)this,
			//            PassConstructorID__Enum_GTAO,
			//            0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m03 = sub_18003F5A0(v118, TypeInfo::HG::Rendering::Runtime::GTAOPassConstructor);
			//   sub_18003F5A0(v118, TypeInfo::HG::Rendering::Runtime::GTAOPassConstructor);
			//   sub_1800054D0((HGRenderPathDefaultDeferred *)((char *)this + 5288), v119, v120, v121, v193);
			//   v122 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//            (HGRenderPathBase *)this,
			//            PassConstructorID__Enum_FakePlanarReflection,
			//            0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m23 = sub_18003F5A0(v122, TypeInfo::HG::Rendering::Runtime::FakePlanarReflectionPass);
			//   sub_18003F5A0(v122, TypeInfo::HG::Rendering::Runtime::FakePlanarReflectionPass);
			//   sub_1800054D0((HGRenderPathDefaultDeferred *)((char *)this + 5296), v123, v124, v125, v194);
			//   v126 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//            (HGRenderPathBase *)this,
			//            PassConstructorID__Enum_HyperScreenSpaceReflection,
			//            0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m00 = sub_18003F5A0(
			//                                                                                           v126,
			//                                                                                           TypeInfo::HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass);
			//   sub_18003F5A0(v126, TypeInfo::HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass);
			//   sub_1800054D0((HGRenderPathDefaultDeferred *)((char *)this + 5304), v127, v128, v129, v195);
			//   v130 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//            (HGRenderPathBase *)this,
			//            PassConstructorID__Enum_ContactShadow,
			//            0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m20 = sub_18003F5A0(
			//                                                                                           v130,
			//                                                                                           TypeInfo::HG::Rendering::Runtime::ContactShadowPassConstructor);
			//   sub_18003F5A0(v130, TypeInfo::HG::Rendering::Runtime::ContactShadowPassConstructor);
			//   sub_1800054D0((HGRenderPathDefaultDeferred *)((char *)this + 5312), v131, v132, v133, v196);
			//   v134 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//            (HGRenderPathBase *)this,
			//            PassConstructorID__Enum_CapsuleShadow,
			//            0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m01 = sub_18003F5A0(
			//                                                                                           v134,
			//                                                                                           TypeInfo::HG::Rendering::Runtime::CapsuleShadowPassConstructor);
			//   sub_18003F5A0(v134, TypeInfo::HG::Rendering::Runtime::CapsuleShadowPassConstructor);
			//   sub_1800054D0((HGRenderPathDefaultDeferred *)((char *)this + 5320), v135, v136, v137, v197);
			//   v138 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//            (HGRenderPathBase *)this,
			//            PassConstructorID__Enum_ScreenSpaceShadowMask,
			//            0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m21 = sub_18003F5A0(
			//                                                                                           v138,
			//                                                                                           TypeInfo::HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor);
			//   sub_18003F5A0(v138, TypeInfo::HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor);
			//   sub_1800054D0((HGRenderPathDefaultDeferred *)((char *)this + 5328), v139, v140, v141, v198);
			//   v142 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//            (HGRenderPathBase *)this,
			//            PassConstructorID__Enum_DeferredLighting,
			//            0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m02 = sub_18003F5A0(
			//                                                                                           v142,
			//                                                                                           TypeInfo::HG::Rendering::Runtime::DeferredLightingPassConstructor);
			//   sub_18003F5A0(v142, TypeInfo::HG::Rendering::Runtime::DeferredLightingPassConstructor);
			//   sub_1800054D0((HGRenderPathDefaultDeferred *)((char *)this + 5336), v143, v144, v145, v199);
			//   v146 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//            (HGRenderPathBase *)this,
			//            PassConstructorID__Enum_ForwardOpaque,
			//            0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m22 = sub_18003F5A0(
			//                                                                                           v146,
			//                                                                                           TypeInfo::HG::Rendering::Runtime::ForwardOpaquePassConstructor);
			//   sub_18003F5A0(v146, TypeInfo::HG::Rendering::Runtime::ForwardOpaquePassConstructor);
			//   sub_1800054D0((HGRenderPathDefaultDeferred *)((char *)this + 5344), v147, v148, v149, v200);
			//   v150 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//            (HGRenderPathBase *)this,
			//            PassConstructorID__Enum_Transparent,
			//            0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m03 = sub_18003F5A0(
			//                                                                                           v150,
			//                                                                                           TypeInfo::HG::Rendering::Runtime::TransparentPassConstructor);
			//   sub_18003F5A0(v150, TypeInfo::HG::Rendering::Runtime::TransparentPassConstructor);
			//   sub_1800054D0((HGRenderPathDefaultDeferred *)((char *)this + 5352), v151, v152, v153, v201);
			//   v154 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//            (HGRenderPathBase *)this,
			//            PassConstructorID__Enum_VolumetricCloud,
			//            0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m23 = sub_18003F5A0(
			//                                                                                           v154,
			//                                                                                           TypeInfo::HG::Rendering::Runtime::VolumetricCloudPassConstructor);
			//   sub_18003F5A0(v154, TypeInfo::HG::Rendering::Runtime::VolumetricCloudPassConstructor);
			//   sub_1800054D0((HGRenderPathDefaultDeferred *)((char *)this + 5360), v155, v156, v157, v202);
			//   v158 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//            (HGRenderPathBase *)this,
			//            PassConstructorID__Enum_LightShaft,
			//            0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m00 = sub_18003F5A0(
			//                                                                                                      v158,
			//                                                                                                      TypeInfo::HG::Rendering::Runtime::LightShaftPassConstructor);
			//   sub_18003F5A0(v158, TypeInfo::HG::Rendering::Runtime::LightShaftPassConstructor);
			//   sub_1800054D0((HGRenderPathDefaultDeferred *)((char *)this + 5368), v159, v160, v161, v203);
			//   v162 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//            (HGRenderPathBase *)this,
			//            PassConstructorID__Enum_Distortion,
			//            0LL);
			//   *(_QWORD *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m20 = sub_18003F5A0(
			//                                                                                                      v162,
			//                                                                                                      TypeInfo::HG::Rendering::Runtime::DistortionPassConstructor);
			//   sub_18003F5A0(v162, TypeInfo::HG::Rendering::Runtime::DistortionPassConstructor);
			//   sub_1800054D0((HGRenderPathDefaultDeferred *)((char *)this + 5376), v163, v164, v165, method);
			// }
			// 
		}

		internal HGRenderPathDefaultDeferred(HGRenderPathBase.HGRenderPathResources resources, HGCamera camera)
		{
			// // HGRenderPathDefaultDeferred(HGRenderPathBase+HGRenderPathResources, HGCamera)
			// void HG::Rendering::Runtime::HGRenderPathDefaultDeferred::HGRenderPathDefaultDeferred(
			//         HGRenderPathDefaultDeferred *this,
			//         HGRenderPathBase_HGRenderPathResources *resources,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   HGRenderPathBase_HGRenderPathResources v4; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   v4 = *resources;
			//   HG::Rendering::Runtime::HGRenderPathDefaultDeferred::HGRenderPathDefaultDeferred(
			//     this,
			//     &v4,
			//     camera,
			//     HGRenderPathInternal__Enum_DefaultDeferred,
			//     0LL);
			// }
			// 
		}

		private static PassConstructorID[] PopulatePassConstructorIds()
		{
			// // PassConstructorID[] PopulatePassConstructorIds()
			// PassConstructorID__Enum__Array *HG::Rendering::Runtime::HGRenderPathDefaultDeferred::PopulatePassConstructorIds(
			//         MethodInfo *method)
			// {
			//   __int64 v1; // r8
			//   __int64 v2; // r9
			//   Array *v3; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( !byte_18D8EDB0F )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::PassConstructorID);
			//     sub_18003C530(&AA287D705D7EED00C7E5BAE83524418D367A7974332AEB3D9C0FD5B96298B2A3_Field);
			//     byte_18D8EDB0F = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2975, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2975, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1065(Patch, 0LL);
			//   }
			//   else
			//   {
			//     v3 = (Array *)il2cpp_array_new_specific_0(TypeInfo::HG::Rendering::Runtime::PassConstructorID, 54LL, v1, v2);
			//     System::Runtime::CompilerServices::RuntimeHelpers::InitializeArray(
			//       v3,
			//       AA287D705D7EED00C7E5BAE83524418D367A7974332AEB3D9C0FD5B96298B2A3_Field,
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
			// GBufferProfileManager_GBufferProfileConfig__Enum HG::Rendering::Runtime::HGRenderPathDefaultDeferred::GetGBufferProfileConfig(
			//         HGRenderPathDefaultDeferred *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2976, 0LL) )
			//     return 0;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2976, 0LL);
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
			// void HG::Rendering::Runtime::HGRenderPathDefaultDeferred::OnPreRendering(
			//         HGRenderPathDefaultDeferred *this,
			//         HGRenderPathBase_HGRenderPathParams *renderPathParams,
			//         MethodInfo *method)
			// {
			//   HGGraphicsFeatureSwitch *characterOutlineOpaque; // rdx
			//   struct HGGraphicsFeatureManager__Class *characterOutlineOpaqueEqual; // rcx
			//   HGRenderPipeline *hgrp; // rax
			//   HGRenderGraph *m_RenderGraph; // rsi
			//   HGCamera *hgCamera; // rdi
			//   HGGraphicsFeatureManager__StaticFields *static_fields; // rax
			//   bool m_defaultValue; // r13
			//   bool v12; // r12
			//   char name; // r15
			//   HGCamera_VolumeComponentsData *m_volumeComponentsData; // rax
			//   float v15; // ecx
			//   __int64 v16; // rax
			//   uint32_t v17; // r14d
			//   HGRenderGraphContext *m_RenderGraphContext; // rbp
			//   float v19; // eax
			//   float v20; // eax
			//   GBufferProfileManager *v21; // rbp
			//   GBufferProfileManager_GBufferProfileConfig__Enum v22; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   uint32_t preZPart0List; // [rsp+50h] [rbp-48h] BYREF
			//   uint32_t preZPart1List; // [rsp+54h] [rbp-44h] BYREF
			//   TextureHandle v26; // [rsp+58h] [rbp-40h] BYREF
			//   uint32_t normalList; // [rsp+B8h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D91964C )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     byte_18D91964C = 1;
			//   }
			//   normalList = 0;
			//   preZPart0List = 0;
			//   preZPart1List = 0;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2977, 0LL) )
			//   {
			//     HG::Rendering::Runtime::HGRenderPathDeferred::OnPreRendering((HGRenderPathDeferred *)this, renderPathParams, 0LL);
			//     hgrp = renderPathParams.hgrp;
			//     if ( hgrp )
			//     {
			//       m_RenderGraph = hgrp.fields.m_RenderGraph;
			//       hgCamera = renderPathParams.renderRequest.hgCamera;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//       characterOutlineOpaqueEqual = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager;
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields;
			//       characterOutlineOpaque = static_fields.characterOutlineOpaque;
			//       if ( characterOutlineOpaque )
			//       {
			//         m_defaultValue = characterOutlineOpaque.fields.m_defaultValue;
			//         characterOutlineOpaque = static_fields.characterOutlineOpaquePreZ;
			//         if ( characterOutlineOpaque )
			//         {
			//           characterOutlineOpaqueEqual = (struct HGGraphicsFeatureManager__Class *)static_fields.characterOutlineOpaqueEqual;
			//           v12 = characterOutlineOpaque.fields.m_defaultValue;
			//           if ( characterOutlineOpaqueEqual )
			//           {
			//             name = (char)characterOutlineOpaqueEqual._0.name;
			//             if ( hgCamera )
			//             {
			//               m_volumeComponentsData = hgCamera.fields.m_volumeComponentsData;
			//               if ( m_volumeComponentsData )
			//               {
			//                 characterOutlineOpaqueEqual = (struct HGGraphicsFeatureManager__Class *)m_volumeComponentsData.fields.m_hgCharacterVolume;
			//                 if ( characterOutlineOpaqueEqual )
			//                 {
			//                   if ( HG::Rendering::Runtime::HGCharacterVolume::GetCharOutlinePassEnableState(
			//                          (HGCharacterVolume *)characterOutlineOpaqueEqual,
			//                          0LL) )
			//                   {
			//                     v16 = *(_QWORD *)&this[1].fields._._._.m_basicTransformConstants._ViewProjMatrix.m21;
			//                     if ( !v16 )
			//                       goto LABEL_25;
			//                     v17 = *(_DWORD *)(v16 + 2592);
			//                     if ( !m_RenderGraph )
			//                       goto LABEL_25;
			//                     m_RenderGraphContext = m_RenderGraph.fields.m_RenderGraphContext;
			//                     if ( !m_RenderGraphContext )
			//                       goto LABEL_25;
			//                     sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//                     UnityEngine::HyperGryph::HGMeshRender::CreateRendererListWithPreZ(
			//                       v17,
			//                       0x4000500u,
			//                       0x4000100u,
			//                       0x200u,
			//                       m_RenderGraphContext.fields.renderContext.m_Ptr,
			//                       &normalList,
			//                       &preZPart0List,
			//                       &preZPart1List,
			//                       0,
			//                       0LL);
			//                     v15 = NAN;
			//                     v19 = NAN;
			//                     if ( m_defaultValue )
			//                       v19 = *(float *)&normalList;
			//                     this[1].fields._._._.m_basicTransformConstants._InvPretransformMatrix.m33 = v19;
			//                     v20 = NAN;
			//                     if ( v12 )
			//                       v20 = *(float *)&preZPart0List;
			//                     this[1].fields._._._.m_basicTransformConstants._InvPretransformMatrix.m21 = v20;
			//                     if ( name )
			//                       v15 = *(float *)&preZPart1List;
			//                   }
			//                   else
			//                   {
			//                     v15 = NAN;
			//                     this[1].fields._._._.m_basicTransformConstants._InvPretransformMatrix.m33 = NAN;
			//                     this[1].fields._._._.m_basicTransformConstants._InvPretransformMatrix.m21 = NAN;
			//                   }
			//                   this[1].fields._._._.m_basicTransformConstants._WorldSpaceCameraPos_Internal.x = v15;
			//                   v21 = *(GBufferProfileManager **)&this[1].fields._._._.m_basicTransformConstants._InvPretransformMatrix.m20;
			//                   v22 = (unsigned int)sub_18003ED00(18LL);
			//                   if ( v21 )
			//                   {
			//                     *(TextureHandle *)&this[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m01 = *HG::Rendering::Runtime::GBufferProfileManager::CreateGBufferTexture(&v26, v21, v22, m_RenderGraph, GBufferID__Enum_GBufferB, hgCamera, 0LL);
			//                     return;
			//                   }
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_25:
			//     sub_180B536AC(characterOutlineOpaqueEqual, characterOutlineOpaque);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2977, 0LL);
			//   if ( !Patch )
			//     goto LABEL_25;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_389(Patch, (Object *)this, renderPathParams, 0LL);
			// }
			// 
		}

		protected override void RenderScene(ref HGRenderPathBase.HGRenderPathParams renderPathParams)
		{
			// // Void RenderScene(HGRenderPathBase+HGRenderPathParams ByRef)
			// // Hidden C++ exception states: #wind=42
			// void HG::Rendering::Runtime::HGRenderPathDefaultDeferred::RenderScene(
			//         HGRenderPathDefaultDeferred *this,
			//         HGRenderPathBase_HGRenderPathParams *renderPathParams,
			//         MethodInfo *method)
			// {
			//   HGRenderPathDefaultDeferred *v3; // rsi
			//   __int64 v4; // rcx
			//   HGRenderPipeline *hgrp; // rdx
			//   HGRenderGraph *m_RenderGraph; // r14
			//   HGRenderPipeline_RenderRequest *p_renderRequest; // rax
			//   _OWORD *v8; // rcx
			//   __int64 v9; // rdx
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   __int64 v12; // rbx
			//   __int64 v13; // rbx
			//   HGCharacterVolume *v14; // rbx
			//   __int64 v15; // rdx
			//   HGCamera *v16; // r13
			//   int32_t msaaSamples_k__BackingField; // r12d
			//   __int64 v18; // rdx
			//   __int64 v19; // rcx
			//   __int64 v20; // rdx
			//   __int64 v21; // rcx
			//   uint32_t v22; // r15d
			//   __int64 v23; // rdx
			//   __int64 v24; // rcx
			//   __int64 v25; // rdx
			//   __int64 v26; // rcx
			//   unsigned __int64 v27; // rdx
			//   __int64 v28; // rcx
			//   CullingResults v29; // xmm2
			//   LightCullResult v30; // xmm3
			//   __int64 v31; // rax
			//   __int128 v32; // xmm1
			//   __int64 v33; // rax
			//   unsigned __int64 v34; // r8
			//   signed __int64 v35; // rtt
			//   LightClusteringPassConstructor *v36; // rcx
			//   __int64 v37; // r12
			//   unsigned __int64 v38; // rdx
			//   __int64 v39; // rcx
			//   __int64 v40; // rax
			//   __int64 v41; // rax
			//   unsigned __int64 v42; // r8
			//   signed __int64 v43; // rtt
			//   ReflectionProbeBinningPassConstructor *v44; // rcx
			//   __int64 v45; // rdx
			//   BinningPass *v46; // rcx
			//   __int64 v47; // rdx
			//   __int64 v48; // rcx
			//   ResourceHandle *v49; // rax
			//   __int64 v50; // rdx
			//   __int64 v51; // rcx
			//   ParticleLightingPassConstructor *v52; // rcx
			//   __int64 v53; // rdx
			//   WaterSectorRenderingPass *v54; // rcx
			//   __int64 v55; // rdx
			//   WaterInteractionRenderingPass *v56; // rcx
			//   __int64 v57; // rdx
			//   FoliageOccluderPassConstructor *v58; // rcx
			//   unsigned __int64 v59; // rdx
			//   HGSettingParameters *v60; // rax
			//   unsigned __int64 v61; // r8
			//   signed __int64 v62; // rtt
			//   FoliageInteractivePassConstructor *v63; // rcx
			//   __int64 v64; // rdx
			//   SludgePassConstructor *v65; // rcx
			//   __int64 v66; // rdx
			//   GpuClothSimulationPassConstructor *v67; // rcx
			//   unsigned __int64 v68; // rdx
			//   unsigned __int64 v69; // r8
			//   signed __int64 v70; // rtt
			//   DepthOnlyPassConstructor *v71; // rcx
			//   unsigned __int64 v72; // rdx
			//   __int64 v73; // rcx
			//   __int64 v74; // rax
			//   int v75; // ecx
			//   unsigned __int64 v76; // r8
			//   signed __int64 v77; // rtt
			//   unsigned __int64 v78; // r8
			//   signed __int64 v79; // rtt
			//   ShadowMapPassConstructor *v80; // rcx
			//   unsigned __int64 v81; // rdx
			//   __int64 v82; // rcx
			//   HGSettingParameters *settingParameters_k__BackingField; // rax
			//   HGAtmosphereSettingParameters *atmosphereParams_k__BackingField; // rax
			//   unsigned __int64 v85; // r8
			//   signed __int64 v86; // rtt
			//   SkyAtmospherePassConstructor *v87; // rcx
			//   __int64 v88; // rdx
			//   VolumetricFogPassConstructor *v89; // rcx
			//   unsigned __int64 v90; // rdx
			//   __int64 v91; // rcx
			//   HGSettingParameters *v92; // rax
			//   HGAtmosphereSettingParameters *v93; // rax
			//   unsigned __int64 v94; // r8
			//   signed __int64 v95; // rtt
			//   BakeFogLutPassConstructor *v96; // rcx
			//   unsigned __int64 v97; // rdx
			//   __int64 v98; // rcx
			//   CullingResults v99; // xmm0
			//   char v100; // r15
			//   HGRenderPipeline *v101; // rax
			//   unsigned __int64 v102; // r8
			//   signed __int64 v103; // rtt
			//   TerrainDeformPassConstructor *v104; // rcx
			//   __int64 *v105; // rdx
			//   InkSimulationPassConstructor *v106; // rcx
			//   __int64 v107; // rdx
			//   TextureHandle v108; // xmm6
			//   CullingResults v109; // xmm7
			//   __int64 m_CurrentRendererConfigurationBakedLighting; // rcx
			//   __int64 v111; // rax
			//   __m128d v112; // xmm2
			//   TerrainDepthPrepassConstructor *v113; // rcx
			//   HGRenderPipelineRuntimeResources *defaultResources; // rax
			//   __int64 v115; // rdx
			//   __int64 v116; // rcx
			//   HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
			//   unsigned __int64 v118; // r8
			//   signed __int64 v119; // rtt
			//   HGRenderPipelineRuntimeResources *v120; // rax
			//   unsigned __int64 v121; // rdx
			//   signed __int64 v122; // rcx
			//   HGRenderPipelineRuntimeResources_ShaderResources *v123; // rax
			//   unsigned __int64 v124; // r8
			//   signed __int64 v125; // rtt
			//   __int64 v126; // rax
			//   GPUDrivenCullingPassConstructor *v127; // rcx
			//   unsigned __int64 v128; // rdx
			//   __int64 v129; // rcx
			//   unsigned __int64 v130; // r8
			//   signed __int64 v131; // rtt
			//   __int64 v132; // rdx
			//   __int64 v133; // rcx
			//   __int64 v134; // rax
			//   __int64 v135; // rdx
			//   __int64 v136; // rcx
			//   uint32_t RendererList; // r13d
			//   uint32_t m10_low; // eax
			//   __int64 v139; // rax
			//   __int64 v140; // rdx
			//   uint32_t m20_low; // eax
			//   DepthPrepassConstructor *v142; // rcx
			//   __int64 v143; // rdx
			//   TextureHandle v144; // xmm1
			//   BuildHZBPass *v145; // rcx
			//   TextureHandle v146; // xmm6
			//   HGRenderPipelineRuntimeResources *v147; // rax
			//   __int64 v148; // rdx
			//   __int64 v149; // rcx
			//   HGRenderPipelineRuntimeResources_ShaderResources *v150; // rax
			//   unsigned __int64 v151; // r8
			//   signed __int64 v152; // rtt
			//   HGRenderPipelineRuntimeResources *v153; // rax
			//   unsigned __int64 v154; // rdx
			//   __int64 v155; // rcx
			//   HGRenderPipelineRuntimeResources_ShaderResources *v156; // rax
			//   unsigned __int64 v157; // r8
			//   signed __int64 v158; // rtt
			//   GPUDrivenCullingPassConstructor *v159; // rcx
			//   HGManagerContext *currentManagerContext; // rax
			//   __int64 v161; // rdx
			//   __int64 v162; // rcx
			//   HGWaterManager *waterManager_k__BackingField; // rcx
			//   __int64 v164; // rdx
			//   __int64 v165; // rcx
			//   __int64 v166; // rdx
			//   GBufferPassConstructor *v167; // rcx
			//   __int64 v168; // rdx
			//   TextureHandle v169; // xmm1
			//   int m01_low; // eax
			//   BuildHZBPass *v171; // rcx
			//   TextureHandle v172; // xmm7
			//   TextureHandle v173; // xmm6
			//   TextureHandle v174; // xmm8
			//   TextureHandle *GBufferAttachment; // rax
			//   HGGraphicsFeatureManager__StaticFields *static_fields; // rax
			//   HGGraphicsFeatureSwitch *deferredDecal; // rdx
			//   HGGraphicsFeatureSwitch *deferredErosion; // rcx
			//   GpuClothSimulationPassConstructor_PassInput m_defaultValue; // al
			//   __int64 v180; // rax
			//   HGRenderGraphContext *m_RenderGraphContext; // r15
			//   __int64 v182; // rax
			//   HGRenderGraphContext *v183; // r15
			//   void *m_Ptr; // rax
			//   __int64 v185; // rdx
			//   __int64 v186; // rcx
			//   __int64 v187; // rdx
			//   DecalPassConstructor *v188; // rcx
			//   __int64 v189; // rdx
			//   WaterDefaultDeferredRenderingPass *v190; // rcx
			//   HGCamera *v191; // rax
			//   TextureHandle *v192; // rax
			//   __int64 v193; // rdx
			//   TextureHandle v194; // xmm0
			//   GPUParticleSimulationPassConstructor *v195; // rcx
			//   TextureHandle v196; // xmm7
			//   TextureHandle v197; // xmm6
			//   HGSettingParameters *v198; // r15
			//   __int64 v199; // rdx
			//   TextureHandle *v200; // rax
			//   TextureHandle *v201; // rax
			//   unsigned __int64 v202; // r8
			//   signed __int64 v203; // rtt
			//   WaterDefaultDeferredRenderingPass *v204; // rcx
			//   HGCamera *v205; // rdx
			//   TextureHandle v206; // xmm6
			//   TextureHandle v207; // xmm7
			//   __int64 v208; // rdx
			//   __int64 v209; // rcx
			//   __int64 v210; // rax
			//   __int64 v211; // rax
			//   __int64 v212; // rdx
			//   __int64 v213; // rcx
			//   HyperScreenSpaceReflectionRenderingPass *v214; // rcx
			//   __int64 v215; // rdx
			//   DepthPyramidRenderingPass *v216; // rcx
			//   TextureHandle v217; // xmm7
			//   TextureHandle v218; // xmm8
			//   NativeArray_1_HG_Rendering_RenderGraphModule_TextureHandle_ v219; // xmm9
			//   NativeArray_1_System_Int32_ v220; // xmm10
			//   __int64 v221; // rdx
			//   GTAOPassConstructor *v222; // rcx
			//   HGSettingParameters *v223; // r15
			//   __int64 v224; // rdx
			//   __int64 v225; // rcx
			//   __int64 v226; // rax
			//   __int64 v227; // rdx
			//   __int64 v228; // rcx
			//   TextureHandle *v229; // rax
			//   unsigned __int64 v230; // r8
			//   signed __int64 v231; // rtt
			//   HyperScreenSpaceReflectionRenderingPass *v232; // rcx
			//   HGCamera *v233; // rdx
			//   __int64 v234; // rdx
			//   __int64 v235; // rcx
			//   TextureHandle *v236; // rax
			//   TextureHandle v237; // xmm7
			//   Vector4 si128; // xmm6
			//   __int64 v239; // rdx
			//   ContactShadowPassConstructor *v240; // rcx
			//   HGSettingParameters *v241; // r15
			//   unsigned __int64 v242; // rdx
			//   HGRenderPipeline *v243; // rax
			//   unsigned __int64 v244; // r8
			//   signed __int64 v245; // rtt
			//   CapsuleShadowPassConstructor *v246; // rcx
			//   TextureHandle v247; // xmm8
			//   CullingResults v248; // xmm9
			//   TextureHandle v249; // xmm7
			//   TextureHandle v250; // xmm6
			//   __int64 v251; // rdx
			//   ScreenSpaceShadowMaskPassConstructor *v252; // rcx
			//   __int64 v253; // rdx
			//   __int64 v254; // rcx
			//   HGCamera *v255; // r15
			//   unsigned __int64 v256; // r8
			//   signed __int64 v257; // rtt
			//   FakePlanarReflectionPass *v258; // rcx
			//   __int64 v259; // rdx
			//   __int64 v260; // rcx
			//   __int64 v261; // rax
			//   __int64 v262; // rax
			//   __int64 v263; // rax
			//   unsigned __int64 v264; // r8
			//   signed __int64 v265; // rtt
			//   __int64 v266; // rdx
			//   DeferredLightingPassConstructor_PassInput *v267; // rcx
			//   TextureHandle *v268; // rax
			//   DeferredLightingPassConstructor *v269; // rcx
			//   unsigned __int64 v270; // rdx
			//   unsigned __int64 v271; // r8
			//   signed __int64 v272; // rtt
			//   __int64 v273; // rcx
			//   __int64 v274; // rdx
			//   ForwardOpaquePassConstructor *v275; // rcx
			//   TextureHandle v276; // xmm8
			//   int32_t SceneColorTexture; // r15d
			//   TextureHandle v278; // xmm7
			//   int32_t CameraDepthTexture; // eax
			//   __int64 v280; // rdx
			//   TextureHandle *v281; // rax
			//   TextureHandle *v282; // rax
			//   TextureHandle *v283; // rax
			//   WaterDefaultDeferredRenderingPass *v284; // rcx
			//   unsigned __int64 v285; // rdx
			//   __int64 v286; // rcx
			//   HGSettingParameters *v287; // rax
			//   int v288; // ecx
			//   unsigned __int64 v289; // r8
			//   signed __int64 v290; // rtt
			//   unsigned __int64 v291; // r8
			//   signed __int64 v292; // rtt
			//   VolumetricCloudPassConstructor *v293; // rcx
			//   __int64 v294; // rdx
			//   TextureHandle v295; // xmm6
			//   TextureHandle v296; // xmm7
			//   HGSettingParameters *v297; // r15
			//   HGLightShaftSettingParameters *lightShaft_k__BackingField; // rcx
			//   __int64 v299; // rdx
			//   HGLightShaftSettingParameters *v300; // rcx
			//   __int64 v301; // rdx
			//   HGLightShaftSettingParameters *v302; // rcx
			//   __int64 v303; // rdx
			//   HGLightShaftSettingParameters *v304; // rcx
			//   __int64 v305; // rdx
			//   LightShaftPassConstructor *v306; // rcx
			//   __int64 v307; // rdx
			//   __int64 v308; // rcx
			//   __int64 v309; // rax
			//   unsigned __int64 v310; // r8
			//   signed __int64 v311; // rtt
			//   unsigned __int64 v312; // rdx
			//   unsigned __int64 v313; // r8
			//   signed __int64 v314; // rtt
			//   __int64 v315; // rcx
			//   __int64 v316; // rdx
			//   TransparentPassConstructor *v317; // rcx
			//   __int64 v318; // rdx
			//   __int64 v319; // rcx
			//   __int64 v320; // rdx
			//   DistortionPassConstructor *v321; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v323; // rdx
			//   __int64 v324; // rcx
			//   __int64 v325; // [rsp+0h] [rbp-55D8h] BYREF
			//   HGCamera *camera; // [rsp+20h] [rbp-55B8h]
			//   GpuClothSimulationPassConstructor_PassInput v327; // [rsp+60h] [rbp-5578h] BYREF
			//   bool enableWetness; // [rsp+61h] [rbp-5577h] BYREF
			//   ReflectionProbeBinningPassConstructor_PassOutput v329; // [rsp+62h] [rbp-5576h] BYREF
			//   TextureHandle v330; // [rsp+70h] [rbp-5568h] BYREF
			//   HGRenderGraph *v331; // [rsp+80h] [rbp-5558h]
			//   TextureHandle v332; // [rsp+90h] [rbp-5548h] BYREF
			//   bool CharOutlinePassEnableState; // [rsp+A0h] [rbp-5538h]
			//   bool wetnessHighQualityEnabled; // [rsp+A1h] [rbp-5537h] BYREF
			//   HGRenderPipeline *v335; // [rsp+A8h] [rbp-5530h]
			//   FoliageOccluderPassConstructor_PassOutput v336; // [rsp+B0h] [rbp-5528h] BYREF
			//   FoliageOccluderPassConstructor_PassInput v337; // [rsp+B1h] [rbp-5527h] BYREF
			//   SludgePassConstructor_PassOutput v338; // [rsp+B2h] [rbp-5526h] BYREF
			//   DepthOnlyPassConstructor_PassOutput v339; // [rsp+B3h] [rbp-5525h] BYREF
			//   TerrainDeformPassConstructor_PassOutput v340; // [rsp+B4h] [rbp-5524h] BYREF
			//   GBufferPassConstructor_PassOutput v341; // [rsp+B5h] [rbp-5523h] BYREF
			//   GPUParticleSimulationPassConstructor_PassOutput v342; // [rsp+B6h] [rbp-5522h] BYREF
			//   HyperScreenSpaceReflectionRenderingPass_PassOutput v343; // [rsp+B7h] [rbp-5521h] BYREF
			//   CapsuleShadowPassConstructor_PassOutput v344; // [rsp+B8h] [rbp-5520h] BYREF
			//   FakePlanarReflectionPass_PassOutput v345; // [rsp+B9h] [rbp-551Fh] BYREF
			//   uint32_t v346[4]; // [rsp+C0h] [rbp-5518h] BYREF
			//   BuildHZBPass_PassInput v347; // [rsp+D0h] [rbp-5508h] BYREF
			//   uint32_t viewHandle; // [rsp+F0h] [rbp-54E8h]
			//   ScriptableRenderContext renderContext; // [rsp+F8h] [rbp-54E0h] BYREF
			//   char *v350; // [rsp+100h] [rbp-54D8h]
			//   LightCullResult lightCullResult; // [rsp+108h] [rbp-54D0h]
			//   HGSettingParameters *settingParameter[2]; // [rsp+118h] [rbp-54C0h] BYREF
			//   HGCamera *hgCamera; // [rsp+128h] [rbp-54B0h]
			//   GBufferOutput gbufferOutput; // [rsp+130h] [rbp-54A8h] BYREF
			//   _BYTE v355[72]; // [rsp+150h] [rbp-5488h] BYREF
			//   BuildHZBPass_PassInput v356; // [rsp+1A0h] [rbp-5438h] BYREF
			//   CullingResults cullingResults; // [rsp+1C0h] [rbp-5418h]
			//   HGAtmosphereSettingParameters *v358; // [rsp+1D0h] [rbp-5408h] BYREF
			//   HGAtmosphereSettingParameters *v359; // [rsp+1D8h] [rbp-5400h] BYREF
			//   GPUDrivenCullingPassConstructor_PassInput v360; // [rsp+1E0h] [rbp-53F8h] BYREF
			//   _QWORD v361[2]; // [rsp+210h] [rbp-53C8h] BYREF
			//   TextureHandle v362; // [rsp+220h] [rbp-53B8h] BYREF
			//   TerrainDepthPrepassConstructor_PassOutput v363; // [rsp+230h] [rbp-53A8h] BYREF
			//   BakeFogLutPassConstructor_PassInput v364; // [rsp+240h] [rbp-5398h] BYREF
			//   FoliageInteractivePassConstructor_PassInput v365; // [rsp+248h] [rbp-5390h] BYREF
			//   SludgePassConstructor_PassInput v366; // [rsp+250h] [rbp-5388h] BYREF
			//   CullingResults v367; // [rsp+258h] [rbp-5380h]
			//   _BYTE v368[24]; // [rsp+268h] [rbp-5370h] BYREF
			//   SkyAtmospherePassConstructor_PassInput v369; // [rsp+280h] [rbp-5358h] BYREF
			//   LightShaftPassConstructor_PassOutput v370; // [rsp+288h] [rbp-5350h] BYREF
			//   _BYTE v371[80]; // [rsp+2A0h] [rbp-5338h] BYREF
			//   Matrix4x4 invViewMatrix; // [rsp+2F0h] [rbp-52E8h] BYREF
			//   TextureHandle v373; // [rsp+330h] [rbp-52A8h]
			//   GBufferOutput v374; // [rsp+340h] [rbp-5298h]
			//   CullingResults v375; // [rsp+360h] [rbp-5278h]
			//   __int128 v376; // [rsp+370h] [rbp-5268h]
			//   TextureHandle sceneColor_k__BackingField; // [rsp+380h] [rbp-5258h]
			//   DistortionPassConstructor_PassOutput v378; // [rsp+390h] [rbp-5248h] BYREF
			//   TransparentPassConstructor_PassOutput v379; // [rsp+3A0h] [rbp-5238h] BYREF
			//   DepthPrepassConstructor_PassInput v380; // [rsp+3B0h] [rbp-5228h] BYREF
			//   ShadowMapPassConstructor_PassInput v381; // [rsp+410h] [rbp-51C8h] BYREF
			//   DepthOnlyPassConstructor_PassInput v382; // [rsp+460h] [rbp-5178h] BYREF
			//   VolumetricCloudPassConstructor_PassInput v383; // [rsp+480h] [rbp-5158h] BYREF
			//   WaterDefaultDeferredRenderingPass_PassInput v384; // [rsp+4C0h] [rbp-5118h] BYREF
			//   TerrainDeformPassConstructor_PassInput v385; // [rsp+590h] [rbp-5048h] BYREF
			//   ContactShadowPassConstructor_PassInput v386; // [rsp+5B8h] [rbp-5020h] BYREF
			//   CullingResults v387; // [rsp+5E0h] [rbp-4FF8h] BYREF
			//   LightCullResult v388; // [rsp+5F0h] [rbp-4FE8h]
			//   __int128 v389; // [rsp+600h] [rbp-4FD8h]
			//   __m256i v390; // [rsp+610h] [rbp-4FC8h] BYREF
			//   __int64 v391; // [rsp+630h] [rbp-4FA8h]
			//   TerrainDepthPrepassConstructor_PassInput v392; // [rsp+640h] [rbp-4F98h] BYREF
			//   ReflectionProbeBinningPassConstructor_PassInput v393; // [rsp+690h] [rbp-4F48h] BYREF
			//   WaterDefaultDeferredRenderingPass_PassOutput v394; // [rsp+6C8h] [rbp-4F10h] BYREF
			//   GPUParticleSimulationPassConstructor_PassInput v395; // [rsp+6E8h] [rbp-4EF0h] BYREF
			//   WaterDefaultDeferredRenderingPass_PassOutput v396; // [rsp+708h] [rbp-4ED0h] BYREF
			//   WaterDefaultDeferredRenderingPass_PassOutput v397; // [rsp+728h] [rbp-4EB0h] BYREF
			//   GBufferPassConstructor_PassInput v398; // [rsp+750h] [rbp-4E88h] BYREF
			//   GPUDrivenCullingPassConstructor_PassInput v399; // [rsp+810h] [rbp-4DC8h] BYREF
			//   GPUDrivenCullingPassConstructor_PassInput v400; // [rsp+840h] [rbp-4D98h] BYREF
			//   LightShaftPassConstructor_PassInput v401; // [rsp+870h] [rbp-4D68h] BYREF
			//   FakePlanarReflectionPass_PassInput v402; // [rsp+8A0h] [rbp-4D38h] BYREF
			//   CapsuleShadowPassConstructor_PassInput v403; // [rsp+960h] [rbp-4C78h] BYREF
			//   Il2CppExceptionWrapper *v404; // [rsp+9F0h] [rbp-4BE8h] BYREF
			//   Il2CppExceptionWrapper *v405; // [rsp+9F8h] [rbp-4BE0h] BYREF
			//   Il2CppExceptionWrapper *v406; // [rsp+A00h] [rbp-4BD8h] BYREF
			//   Il2CppExceptionWrapper *v407; // [rsp+A08h] [rbp-4BD0h] BYREF
			//   Il2CppExceptionWrapper *v408; // [rsp+A10h] [rbp-4BC8h] BYREF
			//   Il2CppExceptionWrapper *v409; // [rsp+A18h] [rbp-4BC0h] BYREF
			//   Il2CppExceptionWrapper *v410; // [rsp+A20h] [rbp-4BB8h] BYREF
			//   Il2CppExceptionWrapper *v411; // [rsp+A28h] [rbp-4BB0h] BYREF
			//   Il2CppExceptionWrapper *v412; // [rsp+A30h] [rbp-4BA8h] BYREF
			//   Il2CppExceptionWrapper *v413; // [rsp+A38h] [rbp-4BA0h] BYREF
			//   Il2CppExceptionWrapper *v414; // [rsp+A40h] [rbp-4B98h] BYREF
			//   Il2CppExceptionWrapper *v415; // [rsp+A48h] [rbp-4B90h] BYREF
			//   Il2CppExceptionWrapper *v416; // [rsp+A50h] [rbp-4B88h] BYREF
			//   Il2CppExceptionWrapper *v417; // [rsp+A58h] [rbp-4B80h] BYREF
			//   Il2CppExceptionWrapper *v418; // [rsp+A60h] [rbp-4B78h] BYREF
			//   Il2CppExceptionWrapper *v419; // [rsp+A68h] [rbp-4B70h] BYREF
			//   Il2CppExceptionWrapper *v420; // [rsp+A70h] [rbp-4B68h] BYREF
			//   Il2CppExceptionWrapper *v421; // [rsp+A78h] [rbp-4B60h] BYREF
			//   Il2CppExceptionWrapper *v422; // [rsp+A80h] [rbp-4B58h] BYREF
			//   Il2CppExceptionWrapper *v423; // [rsp+A88h] [rbp-4B50h] BYREF
			//   Il2CppExceptionWrapper *v424; // [rsp+A90h] [rbp-4B48h] BYREF
			//   Il2CppExceptionWrapper *v425; // [rsp+A98h] [rbp-4B40h] BYREF
			//   Il2CppExceptionWrapper *v426; // [rsp+AA0h] [rbp-4B38h] BYREF
			//   Il2CppExceptionWrapper *v427; // [rsp+AA8h] [rbp-4B30h] BYREF
			//   Il2CppExceptionWrapper *v428; // [rsp+AB0h] [rbp-4B28h] BYREF
			//   Il2CppExceptionWrapper *v429; // [rsp+AB8h] [rbp-4B20h] BYREF
			//   Il2CppExceptionWrapper *v430; // [rsp+AC0h] [rbp-4B18h] BYREF
			//   Il2CppExceptionWrapper *v431; // [rsp+AC8h] [rbp-4B10h] BYREF
			//   Il2CppExceptionWrapper *v432; // [rsp+AD0h] [rbp-4B08h] BYREF
			//   Il2CppExceptionWrapper *v433; // [rsp+AD8h] [rbp-4B00h] BYREF
			//   Il2CppExceptionWrapper *v434; // [rsp+AE0h] [rbp-4AF8h] BYREF
			//   Il2CppExceptionWrapper *v435; // [rsp+AE8h] [rbp-4AF0h] BYREF
			//   Il2CppExceptionWrapper *v436; // [rsp+AF0h] [rbp-4AE8h] BYREF
			//   Il2CppExceptionWrapper *v437; // [rsp+AF8h] [rbp-4AE0h] BYREF
			//   Il2CppExceptionWrapper *v438; // [rsp+B00h] [rbp-4AD8h] BYREF
			//   Il2CppExceptionWrapper *v439; // [rsp+B08h] [rbp-4AD0h] BYREF
			//   Il2CppExceptionWrapper *v440; // [rsp+B10h] [rbp-4AC8h] BYREF
			//   Il2CppExceptionWrapper *v441; // [rsp+B18h] [rbp-4AC0h] BYREF
			//   Il2CppExceptionWrapper *v442; // [rsp+B20h] [rbp-4AB8h] BYREF
			//   Il2CppExceptionWrapper *v443; // [rsp+B28h] [rbp-4AB0h] BYREF
			//   Il2CppExceptionWrapper *v444; // [rsp+B30h] [rbp-4AA8h] BYREF
			//   ForwardOpaquePassConstructor_PassInput v445; // [rsp+B40h] [rbp-4A98h] BYREF
			//   Il2CppExceptionWrapper *v446; // [rsp+C10h] [rbp-49C8h] BYREF
			//   GTAOPassConstructor_PassInput v447; // [rsp+C20h] [rbp-49B8h] BYREF
			//   _BYTE v448[64]; // [rsp+C70h] [rbp-4968h] BYREF
			//   ResourceHandle v449; // [rsp+CB0h] [rbp-4928h]
			//   VolumetricCloudPassConstructor_PassInput v450; // [rsp+CC0h] [rbp-4918h] BYREF
			//   HyperScreenSpaceReflectionRenderingPass_PassInput v451; // [rsp+D00h] [rbp-48D8h] BYREF
			//   LightClusteringPassConstructor_PassInput input; // [rsp+DD0h] [rbp-4808h] BYREF
			//   ShadowMapPassConstructor_PassInput v453; // [rsp+E30h] [rbp-47A8h] BYREF
			//   _OWORD v454[10]; // [rsp+E80h] [rbp-4758h] BYREF
			//   HGRenderPipeline *v455; // [rsp+F20h] [rbp-46B8h] BYREF
			//   __int128 v456; // [rsp+F28h] [rbp-46B0h]
			//   __int128 v457; // [rsp+F38h] [rbp-46A0h]
			//   __int128 v458; // [rsp+F48h] [rbp-4690h]
			//   __int128 v459; // [rsp+F58h] [rbp-4680h]
			//   __int128 v460; // [rsp+F68h] [rbp-4670h]
			//   __int64 v461; // [rsp+F78h] [rbp-4660h]
			//   float m20; // [rsp+F80h] [rbp-4658h]
			//   GraphicsFormat__Enum ColorBufferFormat; // [rsp+F84h] [rbp-4654h]
			//   DepthPrepassConstructor_PassInput v464; // [rsp+F90h] [rbp-4648h] BYREF
			//   HyperScreenSpaceReflectionRenderingPass_PassInput v465; // [rsp+FF0h] [rbp-45E8h] BYREF
			//   CapsuleShadowPassConstructor_PassInput v466; // [rsp+10C0h] [rbp-4518h] BYREF
			//   DistortionPassConstructor_PassInput v467; // [rsp+1150h] [rbp-4488h] BYREF
			//   ParticleLightingPassConstructor_PassInput v468; // [rsp+11F0h] [rbp-43E8h] BYREF
			//   GBufferPassConstructor_PassInput v469; // [rsp+12A0h] [rbp-4338h] BYREF
			//   FakePlanarReflectionPass_PassInput v470; // [rsp+1360h] [rbp-4278h] BYREF
			//   ForwardOpaquePassConstructor_PassInput v471; // [rsp+1420h] [rbp-41B8h] BYREF
			//   WaterDefaultDeferredRenderingPass_PassInput v472; // [rsp+14F0h] [rbp-40E8h] BYREF
			//   WaterDefaultDeferredRenderingPass_PassInput v473; // [rsp+15C0h] [rbp-4018h] BYREF
			//   HyperScreenSpaceReflectionRenderingPass_PassInput v474; // [rsp+1690h] [rbp-3F48h] BYREF
			//   WaterDefaultDeferredRenderingPass_PassInput v475; // [rsp+1760h] [rbp-3E78h] BYREF
			//   DeferredLightingPassConstructor_PassInput v476; // [rsp+1830h] [rbp-3DA8h] BYREF
			//   LightClusteringPassConstructor_PassOutput output; // [rsp+1940h] [rbp-3C98h] BYREF
			//   unsigned int v478; // [rsp+1D50h] [rbp-3888h]
			//   int32_t v479; // [rsp+1D54h] [rbp-3884h]
			//   _BYTE v480[392]; // [rsp+1D70h] [rbp-3868h] BYREF
			//   char v481; // [rsp+1EF8h] [rbp-36E0h]
			//   __int16 v482; // [rsp+1EF9h] [rbp-36DFh]
			//   __int64 v483; // [rsp+1EFCh] [rbp-36DCh]
			//   int v484; // [rsp+1F04h] [rbp-36D4h]
			//   int v485; // [rsp+1F08h] [rbp-36D0h]
			//   char v486; // [rsp+1F0Ch] [rbp-36CCh]
			//   float deltaTime; // [rsp+1F10h] [rbp-36C8h]
			//   Material *v488; // [rsp+1F18h] [rbp-36C0h]
			//   float v489; // [rsp+1F20h] [rbp-36B8h]
			//   __int64 v490; // [rsp+1F24h] [rbp-36B4h]
			//   uint32_t v491; // [rsp+1F2Ch] [rbp-36ACh]
			//   List_1_HG_Rendering_Runtime_IVolumetricRenderObject_ *v492; // [rsp+2010h] [rbp-35C8h]
			//   _OWORD v493[5]; // [rsp+3010h] [rbp-25C8h] BYREF
			//   HGRenderPipeline *v494; // [rsp+3060h] [rbp-2578h] BYREF
			//   int v495; // [rsp+3068h] [rbp-2570h]
			//   __int128 v496; // [rsp+3070h] [rbp-2568h]
			//   __int128 v497; // [rsp+3080h] [rbp-2558h]
			//   _QWORD v498[9]; // [rsp+3090h] [rbp-2548h] BYREF
			//   CullingResults v499; // [rsp+30D8h] [rbp-2500h]
			//   int32_t v500; // [rsp+30E8h] [rbp-24F0h]
			//   float z; // [rsp+30ECh] [rbp-24ECh]
			//   bool v502; // [rsp+30F0h] [rbp-24E8h]
			//   float screenCullingRatio; // [rsp+30F4h] [rbp-24E4h]
			//   float screenRatioCullingDistance; // [rsp+30F8h] [rbp-24E0h]
			//   uint32_t screenCullingLayerMask; // [rsp+30FCh] [rbp-24DCh]
			//   TransparentPassConstructor_PassInput v506; // [rsp+42B0h] [rbp-1328h] BYREF
			//   char v509; // [rsp+55F8h] [rbp+20h] BYREF
			// 
			//   v3 = this;
			//   if ( !byte_18D91964D )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGRenderPathScene::OtherPassScope>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     byte_18D91964D = 1;
			//   }
			//   v509 = 0;
			//   sub_1802F01E0(&input, 0LL, 88LL);
			//   memset(&v393, 0, sizeof(v393));
			//   memset(v371, 0, sizeof(v371));
			//   sub_1802F01E0(&v468, 0LL, 168LL);
			//   v337 = 0;
			//   v336 = 0;
			//   v365.settingParams = 0LL;
			//   v361[0] = 0LL;
			//   v366 = 0LL;
			//   v338 = 0;
			//   memset(&v382, 0, sizeof(v382));
			//   v339 = 0;
			//   sub_1802F01E0(&v453, 0LL, 80LL);
			//   sub_1802F01E0(&v381, 0LL, 80LL);
			//   v369.atmosphereParams = 0LL;
			//   v358 = 0LL;
			//   v364.atmosphereParams = 0LL;
			//   v359 = 0LL;
			//   memset(&v385, 0, sizeof(v385));
			//   v340 = 0;
			//   v367 = 0LL;
			//   memset(v368, 0, sizeof(v368));
			//   memset(&v399, 0, sizeof(v399));
			//   memset(&v360, 0, sizeof(v360));
			//   sub_1802F01E0(&v464, 0LL, 96LL);
			//   sub_1802F01E0(&v380, 0LL, 96LL);
			//   memset(&gbufferOutput, 0, sizeof(gbufferOutput));
			//   memset(&v400, 0, sizeof(v400));
			//   sub_1802F01E0(&v469, 0LL, 184LL);
			//   v341 = 0;
			//   sub_1802F01E0(&v472, 0LL, 208LL);
			//   memset(&v394, 0, sizeof(v394));
			//   sub_1802F01E0(&v384, 0LL, 208LL);
			//   memset(&v395, 0, sizeof(v395));
			//   v342 = 0;
			//   sub_1802F01E0(&v473, 0LL, 208LL);
			//   memset(&v396, 0, sizeof(v396));
			//   sub_1802F01E0(&v465, 0LL, 208LL);
			//   sub_1802F01E0(&v451, 0LL, 208LL);
			//   sub_1802F01E0(&v447, 0LL, 72LL);
			//   sub_1802F01E0(&v474, 0LL, 208LL);
			//   v343 = 0;
			//   memset(&v386, 0, sizeof(v386));
			//   sub_1802F01E0(&v466, 0LL, 144LL);
			//   v344 = 0;
			//   sub_1802F01E0(&v403, 0LL, 144LL);
			//   sub_1802F01E0(&v470, 0LL, 184LL);
			//   v345 = 0;
			//   sub_1802F01E0(&v402, 0LL, 184LL);
			//   sub_1802F01E0(&v476, 0LL, 264LL);
			//   sub_1802F01E0(v454, 0LL, 264LL);
			//   sub_1802F01E0(&v471, 0LL, 200LL);
			//   sub_1802F01E0(&v445, 0LL, 200LL);
			//   sub_1802F01E0(&v475, 0LL, 208LL);
			//   memset(&v397, 0, sizeof(v397));
			//   sub_1802F01E0(&v450, 0LL, 64LL);
			//   sub_1802F01E0(&v383, 0LL, 64LL);
			//   memset(&v401, 0, sizeof(v401));
			//   memset(&v370, 0, sizeof(v370));
			//   sub_1802F01E0(&v506, 0LL, 4768LL);
			//   v379 = 0LL;
			//   sub_1802F01E0(v493, 0LL, 4768LL);
			//   sub_1802F01E0(&v467, 0LL, 152LL);
			//   v378 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2992, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2992, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v324, v323);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_389(Patch, (Object *)v3, renderPathParams, 0LL);
			//   }
			//   else
			//   {
			//     hgrp = renderPathParams.hgrp;
			//     v335 = hgrp;
			//     if ( !hgrp )
			//       sub_180B536AC(v4, 0LL);
			//     m_RenderGraph = hgrp.fields.m_RenderGraph;
			//     v331 = m_RenderGraph;
			//     renderContext.m_Ptr = renderPathParams.renderGraphParams.scriptableRenderContext.m_Ptr;
			//     cullingResults = renderPathParams.renderRequest.cullingResults.cullingResults;
			//     lightCullResult = renderPathParams.renderRequest.cullingResults.lightCullResult;
			//     hgCamera = renderPathParams.renderRequest.hgCamera;
			//     settingParameter[0] = hgrp.fields._settingParameters_k__BackingField;
			//     p_renderRequest = &renderPathParams.renderRequest;
			//     v8 = v480;
			//     v9 = 5LL;
			//     do
			//     {
			//       *v8 = *(_OWORD *)&p_renderRequest.hgCamera;
			//       v8[1] = *(_OWORD *)&p_renderRequest.clearCameraSettings;
			//       v8[2] = *(_OWORD *)&p_renderRequest.target.id.m_InstanceID;
			//       v8[3] = *(_OWORD *)&p_renderRequest.target.id.m_MipLevel;
			//       v8[4] = *(_OWORD *)&p_renderRequest.target.face;
			//       v8[5] = *(_OWORD *)&p_renderRequest.target.targetDepth;
			//       v8[6] = p_renderRequest.cullingResults.cullingResults;
			//       v8 += 8;
			//       *(v8 - 1) = *(_OWORD *)&p_renderRequest.cullingResults.customPassCullingResults.hasValue;
			//       p_renderRequest = (HGRenderPipeline_RenderRequest *)((char *)p_renderRequest + 128);
			//       --v9;
			//     }
			//     while ( v9 );
			//     *v8 = *(_OWORD *)&p_renderRequest.hgCamera;
			//     v8[1] = *(_OWORD *)&p_renderRequest.clearCameraSettings;
			//     *((_QWORD *)v8 + 4) = *(_QWORD *)&p_renderRequest.target.id.m_InstanceID;
			//     viewHandle = HG::Rendering::Runtime::HGRenderPipeline::GetColorBufferFormat(
			//                    v335,
			//                    *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._ViewProjMatrix.m21,
			//                    0LL);
			//     v12 = *(_QWORD *)&v3[1].fields._._._.m_basicTransformConstants._ViewProjMatrix.m21;
			//     if ( !v12 )
			//       sub_180B536AC(v11, v10);
			//     v13 = *(_QWORD *)(v12 + 2504);
			//     if ( !v13 )
			//       sub_180B536AC(v11, v10);
			//     v14 = *(HGCharacterVolume **)(v13 + 104);
			//     if ( !v14 )
			//       sub_180B536AC(v11, v10);
			//     CharOutlinePassEnableState = HG::Rendering::Runtime::HGCharacterVolume::GetCharOutlinePassEnableState(v14, 0LL);
			//     enableWetness = renderPathParams.renderRequest.wetnessEnabled;
			//     wetnessHighQualityEnabled = renderPathParams.renderRequest.wetnessHighQualityEnabled;
			//     v16 = *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._ViewProjMatrix.m21;
			//     if ( !v16 )
			//       sub_180B536AC(renderPathParams, v15);
			//     msaaSamples_k__BackingField = v16.fields._msaaSamples_k__BackingField;
			//     if ( !settingParameter[0] )
			//       sub_180B536AC(renderPathParams, v15);
			//     HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//       settingParameter[0].fields._copySceneRTScale_k__BackingField,
			//       MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//     v22 = sub_1825C6750(v19, v18);
			//     if ( !*(_QWORD *)&v3[1].fields._._._.m_basicTransformConstants._ViewProjMatrix.m21 )
			//       sub_180B536AC(v21, v20);
			//     HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//       settingParameter[0].fields._copySceneRTScale_k__BackingField,
			//       MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//     v346[0] = v22;
			//     v346[1] = sub_1825C6750(v24, v23);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//     v362 = *HG::Rendering::Runtime::HGRenderPipeline::CreateColorBuffer(
			//               &v362,
			//               m_RenderGraph,
			//               v16,
			//               msaaSamples_k__BackingField != 1,
			//               (GraphicsFormat__Enum)viewHandle,
			//               *(Vector2Int *)v346,
			//               0LL);
			//     if ( !*(_QWORD *)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewProjMatrix.m21 )
			//       sub_180B536AC(v26, v25);
			//     HG::Rendering::Runtime::BinningPass::Prepare(
			//       *(BinningPass **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewProjMatrix.m21,
			//       m_RenderGraph,
			//       0LL);
			//     sub_1802F01E0(&output, 0LL, 1072LL);
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)7u,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     v330.handle = 0LL;
			//     v330.fallBackResource = (ResourceHandle)&v509;
			//     try
			//     {
			//       sub_1802F01E0(&v387, 0LL, 88LL);
			//       v29 = cullingResults;
			//       v387 = cullingResults;
			//       v30 = lightCullResult;
			//       v388 = lightCullResult;
			//       v31 = *(_QWORD *)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewProjMatrix.m21;
			//       if ( !v31 )
			//         sub_1802DC2C8(v28, v27);
			//       v32 = *(_OWORD *)(v31 + 16);
			//       v389 = v32;
			//       v390.m256i_i64[0] = *(_QWORD *)(v31 + 32);
			//       v390.m256i_i32[2] = *(_DWORD *)(v31 + 40);
			//       v33 = *(_QWORD *)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewProjMatrix.m21;
			//       if ( !v33 )
			//         sub_1802DC2C8(v28, v27);
			//       *(__int64 *)((char *)&v390.m256i_i64[1] + 4) = *(_QWORD *)(v33 + 72);
			//       v390.m256i_i64[3] = (__int64)v335.fields._settingParameters_k__BackingField;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v34 = (((unsigned __int64)&v390.m256i_u64[3] >> 12) & 0x1FFFFF) >> 6;
			//         v27 = ((unsigned __int64)&v390.m256i_u64[3] >> 12) & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v34 + 36190]);
			//         do
			//           v35 = qword_18D6405E0[v34 + 36190];
			//         while ( v35 != _InterlockedCompareExchange64(&qword_18D6405E0[v34 + 36190], v35 | (1LL << v27), v35) );
			//         v32 = v389;
			//         v30 = v388;
			//         v29 = v387;
			//       }
			//       input.cullingResults = v29;
			//       input.lightCullResult = v30;
			//       *(_OWORD *)&input.binningData.tileSize = v32;
			//       *(__m256i *)&input.binningData.xyOffset = v390;
			//       *(_QWORD *)&input.outputTileResult = v391;
			//       v36 = *(LightClusteringPassConstructor **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m01;
			//       if ( !v36 )
			//         sub_1802DC2C8(0LL, v27);
			//       HG::Rendering::Runtime::LightClusteringPassConstructor::ConstructPass(
			//         v36,
			//         &input,
			//         &output,
			//         m_RenderGraph,
			//         *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._ViewProjMatrix.m21,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v408 )
			//     {
			//       v330.handle = (ResourceHandle)v408.ex;
			//       if ( v330.handle )
			//         sub_18000F780(*(_QWORD *)&v330.handle);
			//       v3 = this;
			//       m_RenderGraph = v331;
			//     }
			//     v37 = 2LL;
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)2u,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     v330.handle = 0LL;
			//     v330.fallBackResource = (ResourceHandle)&v509;
			//     try
			//     {
			//       memset(&v371[16], 0, 40);
			//       *(_OWORD *)v371 = (unsigned __int64)renderContext.m_Ptr;
			//       v40 = *(_QWORD *)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewProjMatrix.m21;
			//       if ( !v40 )
			//         sub_1802DC2C8(v39, v38);
			//       *(_OWORD *)&v371[8] = *(_OWORD *)(v40 + 44);
			//       *(_QWORD *)&v371[24] = *(_QWORD *)(v40 + 60);
			//       *(_DWORD *)&v371[32] = *(_DWORD *)(v40 + 68);
			//       v41 = *(_QWORD *)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewProjMatrix.m21;
			//       if ( !v41 )
			//         sub_1802DC2C8(v39, v38);
			//       *(_QWORD *)&v371[36] = *(_QWORD *)(v41 + 72);
			//       *(HGSettingParameters **)&v371[48] = settingParameter[0];
			//       if ( dword_18D8E43F8 )
			//       {
			//         v42 = (((unsigned __int64)&v371[48] >> 12) & 0x1FFFFF) >> 6;
			//         v38 = ((unsigned __int64)&v371[48] >> 12) & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v42 + 36190]);
			//         do
			//           v43 = qword_18D6405E0[v42 + 36190];
			//         while ( v43 != _InterlockedCompareExchange64(&qword_18D6405E0[v42 + 36190], v43 | (1LL << v38), v43) );
			//       }
			//       v393 = *(ReflectionProbeBinningPassConstructor_PassInput *)v371;
			//       v329 = 0;
			//       v44 = *(ReflectionProbeBinningPassConstructor **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewProjMatrix.m02;
			//       if ( !v44 )
			//         sub_1802DC2C8(0LL, v38);
			//       HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::ConstructPass(
			//         v44,
			//         &v393,
			//         &v329,
			//         m_RenderGraph,
			//         *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._ViewProjMatrix.m21,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v409 )
			//     {
			//       v330.handle = (ResourceHandle)v409.ex;
			//       if ( v330.handle )
			//         sub_18000F780(*(_QWORD *)&v330.handle);
			//       v37 = 2LL;
			//       v3 = this;
			//       m_RenderGraph = v331;
			//     }
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)1u,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     v330.handle = 0LL;
			//     v330.fallBackResource = (ResourceHandle)&v509;
			//     try
			//     {
			//       v46 = *(BinningPass **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewProjMatrix.m21;
			//       if ( !v46 )
			//         sub_1802DC2C8(0LL, v45);
			//       HG::Rendering::Runtime::BinningPass::ConstructPass(
			//         v46,
			//         m_RenderGraph,
			//         *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._ViewProjMatrix.m21,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v410 )
			//     {
			//       v330.handle = (ResourceHandle)v410.ex;
			//       if ( v330.handle )
			//         sub_18000F780(*(_QWORD *)&v330.handle);
			//       v37 = 2LL;
			//       v3 = this;
			//       m_RenderGraph = v331;
			//     }
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)0xAu,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     v330.handle = 0LL;
			//     v330.fallBackResource = (ResourceHandle)&v509;
			//     try
			//     {
			//       v49 = *(ResourceHandle **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewProjMatrix.m21;
			//       if ( !v49 )
			//         sub_1802DC2C8(v48, v47);
			//       v398.sceneColor.handle = v49[9];
			//       sub_1802F01E0(&invViewMatrix, 0LL, 160LL);
			//       if ( !hgCamera )
			//         sub_1802DC2C8(v51, v50);
			//       invViewMatrix = hgCamera.fields.mainViewConstants.invViewMatrix;
			//       v373 = *(TextureHandle *)&v3.fields._._.m_tranparentAfterDOFPassConstructor;
			//       v374 = *(GBufferOutput *)&v3.fields._._.m_metalFXTemporalPassConstructor;
			//       v375 = *(CullingResults *)&v3.fields._._.m_uiPassConstructor;
			//       v376 = *(_OWORD *)&v3.fields._._.m_screenSpaceOverlayPassConstructor;
			//       sceneColor_k__BackingField = v3.fields._._._sceneColor_k__BackingField;
			//       *(_OWORD *)&v398.sceneColor.fallBackResource.m_Value = *(_OWORD *)&invViewMatrix.m00;
			//       *(_OWORD *)&v398.sceneDepth.fallBackResource.m_Value = *(_OWORD *)&invViewMatrix.m01;
			//       *(_OWORD *)&v398.sceneMV.fallBackResource.m_Value = *(_OWORD *)&invViewMatrix.m02;
			//       *(_OWORD *)&v398.sceneColorCopied.fallBackResource.m_Value = *(_OWORD *)&invViewMatrix.m03;
			//       *(TextureHandle *)&v398.sceneDepthCopied.fallBackResource.m_Value = v373;
			//       *(GBufferOutput *)((char *)&v398.gBufferOutput + 8) = v374;
			//       *(CullingResults *)&v398.cullingResults.m_AllocationInfo = v375;
			//       *(_OWORD *)&v398.screenCullingRatio = v376;
			//       *(TextureHandle *)&v398.deferredOpaqueEqualECSList = sceneColor_k__BackingField;
			//       *(TextureHandle *)&v468.binningBufferHandle.handle.m_Value = v398.sceneColor;
			//       *(TextureHandle *)&v468.ivInput.invViewMatrix.m20 = v398.sceneDepth;
			//       *(TextureHandle *)&v468.ivInput.invViewMatrix.m21 = v398.sceneMV;
			//       *(TextureHandle *)&v468.ivInput.invViewMatrix.m22 = v398.sceneColorCopied;
			//       *(TextureHandle *)&v468.ivInput.invViewMatrix.m23 = v398.sceneDepthCopied;
			//       *(GBufferOutput *)&v468.ivInput.IVParam0.z = v398.gBufferOutput;
			//       *(CullingResults *)&v468.ivInput.IVParam2.z = v398.cullingResults;
			//       *(_OWORD *)&v468.ivInput.IVDefaultSHAr.z = *(_OWORD *)&v398.bakedLightConfig;
			//       *(_OWORD *)&v468.ivInput.IVDefaultSHAg.z = *(_OWORD *)&v398.screenCullingLayerMask;
			//       *(ResourceHandle *)&v468.ivInput.IVDefaultSHAb.z = sceneColor_k__BackingField.fallBackResource;
			//       v329 = 0;
			//       v52 = *(ParticleLightingPassConstructor **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m20;
			//       if ( !v52 )
			//         sub_1802DC2C8(0LL, v50);
			//       HG::Rendering::Runtime::ParticleLightingPassConstructor::ConstructPass(
			//         v52,
			//         &v468,
			//         (ParticleLightingPassConstructor_PassOutput *)&v329,
			//         m_RenderGraph,
			//         *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._ViewProjMatrix.m21,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v411 )
			//     {
			//       v330.handle = (ResourceHandle)v411.ex;
			//       if ( v330.handle )
			//         sub_18000F780(*(_QWORD *)&v330.handle);
			//       v37 = 2LL;
			//       v3 = this;
			//       m_RenderGraph = v331;
			//     }
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)3u,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGRenderPathScene::OtherPassScope>);
			//     v330.handle = 0LL;
			//     v330.fallBackResource = (ResourceHandle)&v509;
			//     try
			//     {
			//       v54 = *(WaterSectorRenderingPass **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m20;
			//       if ( !v54 )
			//         sub_1802DC2C8(0LL, v53);
			//       HG::Rendering::Runtime::WaterSectorRenderingPass::Render(
			//         v54,
			//         m_RenderGraph,
			//         *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._ViewProjMatrix.m21,
			//         settingParameter[0],
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v412 )
			//     {
			//       v330.handle = (ResourceHandle)v412.ex;
			//       if ( v330.handle )
			//         sub_18000F780(*(_QWORD *)&v330.handle);
			//       v37 = 2LL;
			//       v3 = this;
			//       m_RenderGraph = v331;
			//     }
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)4u,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGRenderPathScene::OtherPassScope>);
			//     v330.handle = 0LL;
			//     v330.fallBackResource = (ResourceHandle)&v509;
			//     try
			//     {
			//       v56 = *(WaterInteractionRenderingPass **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m01;
			//       if ( !v56 )
			//         sub_1802DC2C8(0LL, v55);
			//       HG::Rendering::Runtime::WaterInteractionRenderingPass::Render(
			//         v56,
			//         m_RenderGraph,
			//         renderContext,
			//         settingParameter[0],
			//         deltaTime,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v413 )
			//     {
			//       v330.handle = (ResourceHandle)v413.ex;
			//       if ( v330.handle )
			//         sub_18000F780(*(_QWORD *)&v330.handle);
			//       v37 = 2LL;
			//       v3 = this;
			//       m_RenderGraph = v331;
			//     }
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)3u,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     v330.handle = 0LL;
			//     v330.fallBackResource = (ResourceHandle)&v509;
			//     try
			//     {
			//       v337 = 0;
			//       v336 = 0;
			//       v58 = *(FoliageOccluderPassConstructor **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewProjMatrix.m22;
			//       if ( !v58 )
			//         sub_1802DC2C8(0LL, v57);
			//       HG::Rendering::Runtime::FoliageOccluderPassConstructor::ConstructPass(
			//         v58,
			//         &v337,
			//         &v336,
			//         m_RenderGraph,
			//         *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._ViewProjMatrix.m21,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v414 )
			//     {
			//       v330.handle = (ResourceHandle)v414.ex;
			//       if ( v330.handle )
			//         sub_18000F780(*(_QWORD *)&v330.handle);
			//       v37 = 2LL;
			//       v3 = this;
			//       m_RenderGraph = v331;
			//     }
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)4u,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     v330.handle = 0LL;
			//     v330.fallBackResource = (ResourceHandle)&v509;
			//     try
			//     {
			//       v60 = settingParameter[0];
			//       v361[0] = settingParameter[0];
			//       if ( dword_18D8E43F8 )
			//       {
			//         v61 = (((unsigned __int64)v361 >> 12) & 0x1FFFFF) >> 6;
			//         v59 = ((unsigned __int64)v361 >> 12) & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v61 + 36190]);
			//         do
			//           v62 = qword_18D6405E0[v61 + 36190];
			//         while ( v62 != _InterlockedCompareExchange64(&qword_18D6405E0[v61 + 36190], v62 | (1LL << v59), v62) );
			//         v60 = (HGSettingParameters *)v361[0];
			//       }
			//       v365.settingParams = v60;
			//       v329 = 0;
			//       v63 = *(FoliageInteractivePassConstructor **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewProjMatrix.m03;
			//       if ( !v63 )
			//         sub_1802DC2C8(0LL, v59);
			//       HG::Rendering::Runtime::FoliageInteractivePassConstructor::ConstructPass(
			//         v63,
			//         &v365,
			//         (FoliageInteractivePassConstructor_PassOutput *)&v329,
			//         m_RenderGraph,
			//         *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._ViewProjMatrix.m21,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v415 )
			//     {
			//       v330.handle = (ResourceHandle)v415.ex;
			//       if ( v330.handle )
			//         sub_18000F780(*(_QWORD *)&v330.handle);
			//       v37 = 2LL;
			//       v3 = this;
			//       m_RenderGraph = v331;
			//     }
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)5u,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     v330.handle = 0LL;
			//     v330.fallBackResource = (ResourceHandle)&v509;
			//     try
			//     {
			//       v346[0] = renderPathParams.perFrameSetup.depthBits;
			//       v346[1] = renderPathParams.perFrameSetup.depthGraphicsFormat;
			//       v366 = *(SludgePassConstructor_PassInput *)v346;
			//       v338 = 0;
			//       v65 = *(SludgePassConstructor **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewProjMatrix.m23;
			//       if ( !v65 )
			//         sub_1802DC2C8(0LL, v64);
			//       HG::Rendering::Runtime::SludgePassConstructor::ConstructPass(
			//         v65,
			//         &v366,
			//         &v338,
			//         m_RenderGraph,
			//         *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._ViewProjMatrix.m21,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v416 )
			//     {
			//       v330.handle = (ResourceHandle)v416.ex;
			//       if ( v330.handle )
			//         sub_18000F780(*(_QWORD *)&v330.handle);
			//       v37 = 2LL;
			//       v3 = this;
			//       m_RenderGraph = v331;
			//     }
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)6u,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     v330.handle = 0LL;
			//     v330.fallBackResource = (ResourceHandle)&v509;
			//     try
			//     {
			//       v327 = 0;
			//       v329 = 0;
			//       v67 = *(GpuClothSimulationPassConstructor **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m00;
			//       if ( !v67 )
			//         sub_1802DC2C8(0LL, v66);
			//       HG::Rendering::Runtime::GpuClothSimulationPassConstructor::ConstructPass(
			//         v67,
			//         &v327,
			//         (GpuClothSimulationPassConstructor_PassOutput *)&v329,
			//         m_RenderGraph,
			//         *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._ViewProjMatrix.m21,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v417 )
			//     {
			//       v330.handle = (ResourceHandle)v417.ex;
			//       if ( v330.handle )
			//         sub_18000F780(*(_QWORD *)&v330.handle);
			//       v37 = 2LL;
			//       v3 = this;
			//       m_RenderGraph = v331;
			//     }
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)0xBu,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     v330.handle = 0LL;
			//     v330.fallBackResource = (ResourceHandle)&v509;
			//     try
			//     {
			//       *(ScriptableRenderContext *)&v371[56] = renderContext;
			//       *(_QWORD *)&v371[72] = renderPathParams.renderRequest.customDepthOnlyRequestMgrCPP;
			//       *(_QWORD *)&v371[64] = renderPathParams.renderRequest.customDepthOnlyRequestMgr;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v69 = (((unsigned __int64)&v371[64] >> 12) & 0x1FFFFF) >> 6;
			//         v68 = ((unsigned __int64)&v371[64] >> 12) & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v69 + 36190]);
			//         do
			//           v70 = qword_18D6405E0[v69 + 36190];
			//         while ( v70 != _InterlockedCompareExchange64(&qword_18D6405E0[v69 + 36190], v70 | (1LL << v68), v70) );
			//       }
			//       v382 = *(DepthOnlyPassConstructor_PassInput *)&v371[56];
			//       v339 = 0;
			//       v71 = *(DepthOnlyPassConstructor **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m02;
			//       if ( !v71 )
			//         sub_1802DC2C8(0LL, v68);
			//       HG::Rendering::Runtime::DepthOnlyPassConstructor::ConstructPass(
			//         v71,
			//         &v382,
			//         &v339,
			//         m_RenderGraph,
			//         *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._ViewProjMatrix.m21,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v418 )
			//     {
			//       v330.handle = (ResourceHandle)v418.ex;
			//       if ( v330.handle )
			//         sub_18000F780(*(_QWORD *)&v330.handle);
			//       v37 = 2LL;
			//       v3 = this;
			//       m_RenderGraph = v331;
			//     }
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)0xCu,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     v330.handle = 0LL;
			//     v330.fallBackResource = (ResourceHandle)&v509;
			//     try
			//     {
			//       sub_1802F01E0(&v381, 0LL, 80LL);
			//       v381.cullingResults = cullingResults;
			//       v381.lightCullResult = lightCullResult;
			//       v381.srpContext = renderContext;
			//       v74 = *(_QWORD *)&v3[1].fields._._._.m_basicTransformConstants._ViewProjMatrix.m21;
			//       if ( !v74 )
			//         sub_1802DC2C8(v73, v72);
			//       v381.shadowManager = *(HGShadowManager **)(v74 + 1848);
			//       v75 = dword_18D8E43F8;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v76 = (((unsigned __int64)&v381 >> 12) & 0x1FFFFF) >> 6;
			//         v72 = ((unsigned __int64)&v381 >> 12) & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v76 + 36190]);
			//         do
			//           v77 = qword_18D6405E0[v76 + 36190];
			//         while ( v77 != _InterlockedCompareExchange64(&qword_18D6405E0[v76 + 36190], v77 | (1LL << v72), v77) );
			//         v75 = dword_18D8E43F8;
			//       }
			//       *(_QWORD *)&v381.directionalLightIndex = __PAIR64__(v478, v479);
			//       v381.punctualLightIndices = &output.punctualLightIndices.FixedElementField;
			//       v381.settingParams = settingParameter[0];
			//       if ( v75 )
			//       {
			//         v78 = (((unsigned __int64)&v381.settingParams >> 12) & 0x1FFFFF) >> 6;
			//         v72 = ((unsigned __int64)&v381.settingParams >> 12) & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v78 + 36190]);
			//         do
			//           v79 = qword_18D6405E0[v78 + 36190];
			//         while ( v79 != _InterlockedCompareExchange64(&qword_18D6405E0[v78 + 36190], v79 | (1LL << v72), v79) );
			//       }
			//       v381.settingParamsCpp = renderPathParams.perFrameSetup.settingParametersCpp;
			//       v453 = v381;
			//       memset(v355, 0, 60);
			//       v80 = *(ShadowMapPassConstructor **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m22;
			//       if ( !v80 )
			//         sub_1802DC2C8(0LL, v72);
			//       HG::Rendering::Runtime::ShadowMapPassConstructor::ConstructPass(
			//         v80,
			//         &v453,
			//         (ShadowMapPassConstructor_PassOutput *)v355,
			//         m_RenderGraph,
			//         *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._ViewProjMatrix.m21,
			//         0LL);
			//       *(_OWORD *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewNoTransProjMatrix.m01 = *(_OWORD *)v355;
			//       *(_OWORD *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewNoTransProjMatrix.m02 = *(_OWORD *)&v355[16];
			//       *(_OWORD *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewNoTransProjMatrix.m03 = *(_OWORD *)&v355[32];
			//       *(_QWORD *)&v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m00 = *(_QWORD *)&v355[48];
			//       v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m20 = *(float *)&v355[56];
			//     }
			//     catch ( Il2CppExceptionWrapper *v419 )
			//     {
			//       v330.handle = (ResourceHandle)v419.ex;
			//       if ( v330.handle )
			//         sub_18000F780(*(_QWORD *)&v330.handle);
			//       v37 = 2LL;
			//       v3 = this;
			//       m_RenderGraph = v331;
			//     }
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)0xDu,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     v330.handle = 0LL;
			//     v330.fallBackResource = (ResourceHandle)&v509;
			//     try
			//     {
			//       v358 = 0LL;
			//       settingParameters_k__BackingField = v335.fields._settingParameters_k__BackingField;
			//       if ( !settingParameters_k__BackingField )
			//         sub_1802DC2C8(v82, v81);
			//       atmosphereParams_k__BackingField = settingParameters_k__BackingField.fields._atmosphereParams_k__BackingField;
			//       v358 = atmosphereParams_k__BackingField;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v85 = (((unsigned __int64)&v358 >> 12) & 0x1FFFFF) >> 6;
			//         v81 = ((unsigned __int64)&v358 >> 12) & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v85 + 36190]);
			//         do
			//           v86 = qword_18D6405E0[v85 + 36190];
			//         while ( v86 != _InterlockedCompareExchange64(&qword_18D6405E0[v85 + 36190], v86 | (1LL << v81), v86) );
			//         atmosphereParams_k__BackingField = v358;
			//       }
			//       v369.atmosphereParams = atmosphereParams_k__BackingField;
			//       v327 = 0;
			//       v87 = *(SkyAtmospherePassConstructor **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m03;
			//       if ( !v87 )
			//         sub_1802DC2C8(0LL, v81);
			//       HG::Rendering::Runtime::SkyAtmospherePassConstructor::ConstructPass(
			//         v87,
			//         &v369,
			//         (SkyAtmospherePassConstructor_PassOutput *)&v327,
			//         m_RenderGraph,
			//         *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._ViewProjMatrix.m21,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v421 )
			//     {
			//       v330.handle = (ResourceHandle)v421.ex;
			//       if ( v330.handle )
			//         sub_18000F780(*(_QWORD *)&v330.handle);
			//       v37 = 2LL;
			//       v3 = this;
			//       m_RenderGraph = v331;
			//     }
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)0xEu,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     v330.handle = 0LL;
			//     v330.fallBackResource = (ResourceHandle)&v509;
			//     try
			//     {
			//       *(_OWORD *)v355 = *(_OWORD *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewNoTransProjMatrix.m01;
			//       *(_OWORD *)&v355[16] = *(_OWORD *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewNoTransProjMatrix.m02;
			//       *(_OWORD *)&v355[32] = *(_OWORD *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewNoTransProjMatrix.m03;
			//       *(_QWORD *)&v355[48] = *(_QWORD *)&v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m00;
			//       *(float *)&v355[56] = v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m20;
			//       v327 = 0;
			//       v89 = *(VolumetricFogPassConstructor **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m23;
			//       if ( !v89 )
			//         sub_1802DC2C8(0LL, v88);
			//       HG::Rendering::Runtime::VolumetricFogPassConstructor::ConstructPass(
			//         v89,
			//         (VolumetricFogPassConstructor_PassInput *)v355,
			//         (VolumetricFogPassConstructor_PassOutput *)&v327,
			//         m_RenderGraph,
			//         *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._ViewProjMatrix.m21,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v422 )
			//     {
			//       v330.handle = (ResourceHandle)v422.ex;
			//       if ( v330.handle )
			//         sub_18000F780(*(_QWORD *)&v330.handle);
			//       v37 = 2LL;
			//       v3 = this;
			//       m_RenderGraph = v331;
			//     }
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)0xFu,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     v330.handle = 0LL;
			//     v330.fallBackResource = (ResourceHandle)&v509;
			//     try
			//     {
			//       v359 = 0LL;
			//       v92 = v335.fields._settingParameters_k__BackingField;
			//       if ( !v92 )
			//         sub_1802DC2C8(v91, v90);
			//       v93 = v92.fields._atmosphereParams_k__BackingField;
			//       v359 = v93;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v94 = (((unsigned __int64)&v359 >> 12) & 0x1FFFFF) >> 6;
			//         v90 = ((unsigned __int64)&v359 >> 12) & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v94 + 36190]);
			//         do
			//           v95 = qword_18D6405E0[v94 + 36190];
			//         while ( v95 != _InterlockedCompareExchange64(&qword_18D6405E0[v94 + 36190], v95 | (1LL << v90), v95) );
			//         v93 = v359;
			//       }
			//       v364.atmosphereParams = v93;
			//       v327 = 0;
			//       v96 = *(BakeFogLutPassConstructor **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m00;
			//       if ( !v96 )
			//         sub_1802DC2C8(0LL, v90);
			//       HG::Rendering::Runtime::BakeFogLutPassConstructor::ConstructPass(
			//         v96,
			//         &v364,
			//         (BakeFogLutPassConstructor_PassOutput *)&v327,
			//         m_RenderGraph,
			//         *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._ViewProjMatrix.m21,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v423 )
			//     {
			//       v330.handle = (ResourceHandle)v423.ex;
			//       if ( v330.handle )
			//         sub_18000F780(*(_QWORD *)&v330.handle);
			//       v37 = 2LL;
			//       v3 = this;
			//       m_RenderGraph = v331;
			//     }
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)0x11u,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     v330.handle = 0LL;
			//     v330.fallBackResource = (ResourceHandle)&v509;
			//     try
			//     {
			//       *(_QWORD *)&v368[9] = 0LL;
			//       *(_DWORD *)&v368[17] = 0;
			//       *(_WORD *)&v368[21] = 0;
			//       v368[23] = 0;
			//       v99 = cullingResults;
			//       v367 = cullingResults;
			//       *(ScriptableRenderContext *)v368 = renderContext;
			//       v100 = v481;
			//       v368[8] = v481;
			//       v101 = renderPathParams.hgrp;
			//       if ( !v101 )
			//         sub_1802DC2C8(v98, v97);
			//       *(_QWORD *)&v368[16] = v101.fields.drawInteractionNodeMaterial;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v102 = (((unsigned __int64)&v368[16] >> 12) & 0x1FFFFF) >> 6;
			//         v97 = ((unsigned __int64)&v368[16] >> 12) & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v102 + 36190]);
			//         do
			//           v103 = qword_18D6405E0[v102 + 36190];
			//         while ( v103 != _InterlockedCompareExchange64(&qword_18D6405E0[v102 + 36190], v103 | (1LL << v97), v103) );
			//         v99 = v367;
			//       }
			//       v385.cullingResults = v99;
			//       *(_OWORD *)&v385.renderContext.m_Ptr = *(_OWORD *)v368;
			//       v385.drawInteractionNodeMaterial = *(Material **)&v368[16];
			//       v340 = 0;
			//       v104 = *(TerrainDeformPassConstructor **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m20;
			//       if ( !v104 )
			//         sub_1802DC2C8(0LL, v97);
			//       HG::Rendering::Runtime::TerrainDeformPassConstructor::ConstructPass(
			//         v104,
			//         &v385,
			//         &v340,
			//         m_RenderGraph,
			//         *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._ViewProjMatrix.m21,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v424 )
			//     {
			//       v105 = &v325;
			//       v330.handle = (ResourceHandle)v424.ex;
			//       if ( v330.handle )
			//         sub_18000F780(*(_QWORD *)&v330.handle);
			//       v37 = 2LL;
			//       v3 = this;
			//       m_RenderGraph = v331;
			//       v100 = v481;
			//     }
			//     v106 = *(InkSimulationPassConstructor **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m21;
			//     if ( !v106 )
			//       goto LABEL_536;
			//     *(_QWORD *)v346 = v490;
			//     v346[2] = v491;
			//     HG::Rendering::Runtime::InkSimulationPassConstructor::ConstructPass(
			//       v106,
			//       m_RenderGraph,
			//       v488,
			//       v489,
			//       (Vector3 *)v346,
			//       deltaTime,
			//       0LL);
			//     v363 = 0LL;
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)0x14u,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     v330.handle = 0LL;
			//     v330.fallBackResource = (ResourceHandle)&v509;
			//     try
			//     {
			//       *(_QWORD *)v355 = 0LL;
			//       *(_QWORD *)&v355[8] = 0LL;
			//       v355[39] = 0;
			//       v108 = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewProjMatrix.m20;
			//       v109 = cullingResults;
			//       m_CurrentRendererConfigurationBakedLighting = (unsigned int)v335.fields.m_CurrentRendererConfigurationBakedLighting;
			//       *(_DWORD *)&v355[32] = v335.fields.m_CurrentRendererConfigurationBakedLighting;
			//       v355[36] = v100;
			//       *(_WORD *)&v355[37] = v482;
			//       *(_QWORD *)&v355[40] = v483;
			//       *(_DWORD *)&v355[48] = v484;
			//       *(_DWORD *)&v355[52] = v485;
			//       if ( v486 )
			//       {
			//         v111 = *(_QWORD *)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m02;
			//         if ( !v111 )
			//           sub_1802DC2C8(m_CurrentRendererConfigurationBakedLighting, v107);
			//         v112 = *(__m128d *)(v111 + 40);
			//       }
			//       else
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//         v112 = *(__m128d *)sub_182E7CCD0(&v347);
			//       }
			//       *(__m128d *)&v355[56] = v112;
			//       v392.sceneDepth = v108;
			//       v392.cullingResults = v109;
			//       *(_OWORD *)&v392.bakedLightingConfig = *(_OWORD *)&v355[32];
			//       *(_OWORD *)&v392.terrainGpuSubd = *(_OWORD *)&v355[48];
			//       v392.HZBTexture.fallBackResource = (ResourceHandle)*(_OWORD *)&_mm_unpackhi_pd(v112, v112);
			//       v113 = *(TerrainDepthPrepassConstructor **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m02;
			//       if ( !v113 )
			//         sub_1802DC2C8(0LL, v107);
			//       HG::Rendering::Runtime::TerrainDepthPrepassConstructor::ConstructPass(
			//         v113,
			//         &v392,
			//         &v363,
			//         m_RenderGraph,
			//         *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._ViewProjMatrix.m21,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v425 )
			//     {
			//       v330.handle = (ResourceHandle)v425.ex;
			//       if ( v330.handle )
			//         sub_18000F780(*(_QWORD *)&v330.handle);
			//       v37 = 2LL;
			//       v3 = this;
			//       m_RenderGraph = v331;
			//     }
			//     if ( LOBYTE(v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01) )
			//     {
			//       UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//         (Int32Enum__Enum)8u,
			//         MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//       v330.handle = 0LL;
			//       v330.fallBackResource = (ResourceHandle)&v509;
			//       try
			//       {
			//         memset(&v360, 0, sizeof(v360));
			//         defaultResources = HG::Rendering::Runtime::HGRenderPipeline::get_defaultResources(v335, 0LL);
			//         if ( !defaultResources )
			//           sub_1802DC2C8(v116, v115);
			//         shaders = defaultResources.fields.shaders;
			//         if ( !shaders )
			//           sub_1802DC2C8(v116, v115);
			//         v360.initShader = shaders.fields.GPUDrivenInitCS;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v118 = (((unsigned __int64)&v360 >> 12) & 0x1FFFFF) >> 6;
			//           _m_prefetchw(&qword_18D6405E0[v118 + 36190]);
			//           do
			//             v119 = qword_18D6405E0[v118 + 36190];
			//           while ( v119 != _InterlockedCompareExchange64(
			//                             &qword_18D6405E0[v118 + 36190],
			//                             v119 | (1LL << (((unsigned __int64)&v360 >> 12) & 0x3F)),
			//                             v119) );
			//         }
			//         v120 = HG::Rendering::Runtime::HGRenderPipeline::get_defaultResources(v335, 0LL);
			//         if ( !v120 )
			//           sub_1802DC2C8(v122, v121);
			//         v123 = v120.fields.shaders;
			//         if ( !v123 )
			//           sub_1802DC2C8(v122, v121);
			//         v360.cullingShader = v123.fields.GPUDrivenCullingCS;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v124 = (((unsigned __int64)&v360.cullingShader >> 12) & 0x1FFFFF) >> 6;
			//           v121 = ((unsigned __int64)&v360.cullingShader >> 12) & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v124 + 36190]);
			//           do
			//           {
			//             v122 = qword_18D6405E0[v124 + 36190] | (1LL << v121);
			//             v125 = qword_18D6405E0[v124 + 36190];
			//           }
			//           while ( v125 != _InterlockedCompareExchange64(&qword_18D6405E0[v124 + 36190], v122, v125) );
			//         }
			//         v126 = *(_QWORD *)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m02;
			//         if ( !v126 )
			//           sub_1802DC2C8(v122, v121);
			//         v360.hzb = *(TextureHandle *)(v126 + 40);
			//         v360.usePrevVP = BYTE1(v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01) == 0;
			//         v399 = v360;
			//         v327 = 0;
			//         v127 = *(GPUDrivenCullingPassConstructor **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m21;
			//         if ( !v127 )
			//           sub_1802DC2C8(0LL, v121);
			//         HG::Rendering::Runtime::GPUDrivenCullingPassConstructor::ConstructPass(
			//           v127,
			//           &v399,
			//           (GPUDrivenCullingPassConstructor_PassOutput *)&v327,
			//           m_RenderGraph,
			//           *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._ViewProjMatrix.m21,
			//           0LL);
			//       }
			//       catch ( Il2CppExceptionWrapper *v426 )
			//       {
			//         v330.handle = (ResourceHandle)v426.ex;
			//         if ( v330.handle )
			//           sub_18000F780(*(_QWORD *)&v330.handle);
			//         v37 = 2LL;
			//         v3 = this;
			//         m_RenderGraph = v331;
			//       }
			//     }
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)0x15u,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     v332.handle = 0LL;
			//     v332.fallBackResource = (ResourceHandle)&v509;
			//     try
			//     {
			//       sub_1802F01E0(&v380, 0LL, 96LL);
			//       v380.sceneDepth = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewProjMatrix.m20;
			//       gbufferOutput = *(GBufferOutput *)&v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m22;
			//       v380.gBufferDepth = *HG::Rendering::Runtime::GBufferOutput::GetGBufferAttachment(
			//                              &v347.depthTexture,
			//                              &gbufferOutput,
			//                              GBufferID__Enum_GBufferDepth,
			//                              0LL);
			//       v380.hgrp = v335;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v130 = (((unsigned __int64)&v380.hgrp >> 12) & 0x1FFFFF) >> 6;
			//         v128 = ((unsigned __int64)&v380.hgrp >> 12) & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v130 + 36190]);
			//         do
			//         {
			//           v129 = qword_18D6405E0[v130 + 36190] | (1LL << v128);
			//           v131 = qword_18D6405E0[v130 + 36190];
			//         }
			//         while ( v131 != _InterlockedCompareExchange64(&qword_18D6405E0[v130 + 36190], v129, v131) );
			//       }
			//       v380.cullingResults = cullingResults;
			//       LOBYTE(v129) = v335.fields.characterDepthOnlyEnable;
			//       v380.characterDepthOnlyEnable = v129;
			//       if ( !hgCamera )
			//         sub_1802DC2C8(v129, v128);
			//       v380.screenCullingRatio = hgCamera.fields.screenCullingRatio;
			//       v380.screenCullingRatioDistance = hgCamera.fields.screenRatioCullingDistance;
			//       v380.screenCullingLayerMask = HG::Rendering::Runtime::HGCamera::get_screenCullingLayerMask(hgCamera, 0LL);
			//       v134 = *(_QWORD *)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m02;
			//       if ( !v134 )
			//         sub_1802DC2C8(v133, v132);
			//       v330 = *(TextureHandle *)(v134 + 40);
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//       RendererList = -1;
			//       if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&v330, 0LL) )
			//         m10_low = LODWORD(v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewProjMatrix.m10);
			//       else
			//         m10_low = -1;
			//       v380.deferredOpaquePreZGPUDrivenList = m10_low;
			//       v139 = *(_QWORD *)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m02;
			//       if ( !v139 )
			//         sub_1802DC2C8(v136, v135);
			//       v330 = *(TextureHandle *)(v139 + 40);
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//       if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&v330, 0LL) )
			//         m20_low = LODWORD(v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewProjMatrix.m20);
			//       else
			//         m20_low = -1;
			//       v380.deferredOpaqueGPUDrivenList = m20_low;
			//       *(_QWORD *)&v380.deferredOpaquePreZECSList = *(_QWORD *)&v3[1].fields._._._.m_basicTransformConstants._InvPretransformMatrix.m01;
			//       v380.deferredGrassPreZECSList = LODWORD(v3[1].fields._._._.m_basicTransformConstants._InvPretransformMatrix.m31);
			//       v464 = v380;
			//       v327 = 0;
			//       v142 = *(DepthPrepassConstructor **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m22;
			//       if ( !v142 )
			//         sub_1802DC2C8(0LL, v140);
			//       HG::Rendering::Runtime::DepthPrepassConstructor::ConstructPass(
			//         v142,
			//         &v464,
			//         (DepthPrepassConstructor_PassOutput *)&v327,
			//         m_RenderGraph,
			//         *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._ViewProjMatrix.m21,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v427 )
			//     {
			//       v332.handle = (ResourceHandle)v427.ex;
			//       if ( v332.handle )
			//         sub_18000F780(*(_QWORD *)&v332.handle);
			//       v37 = 2LL;
			//       RendererList = -1;
			//       v3 = this;
			//       m_RenderGraph = v331;
			//     }
			//     if ( LOBYTE(v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01)
			//       && !BYTE1(v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01) )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//       *(_OWORD *)v346 = *(_OWORD *)sub_182E7CCD0(&v347);
			//       UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//         (Int32Enum__Enum)0x1Eu,
			//         MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//       v332.handle = 0LL;
			//       v332.fallBackResource = (ResourceHandle)&v509;
			//       try
			//       {
			//         memset(v355, 0, 20);
			//         v144 = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewProjMatrix.m20;
			//         v355[16] = 1;
			//         v347.depthTexture = v144;
			//         *(_DWORD *)&v347.buildHZB = 1;
			//         v330 = 0LL;
			//         v145 = *(BuildHZBPass **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m02;
			//         if ( !v145 )
			//           sub_1802DC2C8(0LL, v143);
			//         HG::Rendering::Runtime::BuildHZBPass::ConstructPass(
			//           v145,
			//           &v347,
			//           (BuildHZBPass_PassOutput *)&v330,
			//           m_RenderGraph,
			//           *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._ViewProjMatrix.m21,
			//           0LL);
			//         v146 = v330;
			//         *(TextureHandle *)v346 = v330;
			//       }
			//       catch ( Il2CppExceptionWrapper *v428 )
			//       {
			//         v332.handle = (ResourceHandle)v428.ex;
			//         if ( v332.handle )
			//           sub_18000F780(*(_QWORD *)&v332.handle);
			//         v37 = 2LL;
			//         RendererList = -1;
			//         v3 = this;
			//         m_RenderGraph = v331;
			//         v146 = *(TextureHandle *)v346;
			//       }
			//       UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//         (Int32Enum__Enum)8u,
			//         MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//       v332.handle = 0LL;
			//       v332.fallBackResource = (ResourceHandle)&v509;
			//       try
			//       {
			//         memset(&v360, 0, sizeof(v360));
			//         v147 = HG::Rendering::Runtime::HGRenderPipeline::get_defaultResources(v335, 0LL);
			//         if ( !v147 )
			//           sub_1802DC2C8(v149, v148);
			//         v150 = v147.fields.shaders;
			//         if ( !v150 )
			//           sub_1802DC2C8(v149, v148);
			//         v360.initShader = v150.fields.GPUDrivenInitCS;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v151 = (((unsigned __int64)&v360 >> 12) & 0x1FFFFF) >> 6;
			//           _m_prefetchw(&qword_18D6405E0[v151 + 36190]);
			//           do
			//             v152 = qword_18D6405E0[v151 + 36190];
			//           while ( v152 != _InterlockedCompareExchange64(
			//                             &qword_18D6405E0[v151 + 36190],
			//                             v152 | (1LL << (((unsigned __int64)&v360 >> 12) & 0x3F)),
			//                             v152) );
			//         }
			//         v153 = HG::Rendering::Runtime::HGRenderPipeline::get_defaultResources(v335, 0LL);
			//         if ( !v153 )
			//           sub_1802DC2C8(v155, v154);
			//         v156 = v153.fields.shaders;
			//         if ( !v156 )
			//           sub_1802DC2C8(v155, v154);
			//         v360.cullingShader = v156.fields.GPUDrivenCullingCS;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v157 = (((unsigned __int64)&v360.cullingShader >> 12) & 0x1FFFFF) >> 6;
			//           v154 = ((unsigned __int64)&v360.cullingShader >> 12) & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v157 + 36190]);
			//           do
			//             v158 = qword_18D6405E0[v157 + 36190];
			//           while ( v158 != _InterlockedCompareExchange64(&qword_18D6405E0[v157 + 36190], v158 | (1LL << v154), v158) );
			//         }
			//         v360.hzb = v146;
			//         v360.usePrevVP = 0;
			//         v400 = v360;
			//         v327 = 0;
			//         v159 = *(GPUDrivenCullingPassConstructor **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m21;
			//         if ( !v159 )
			//           sub_1802DC2C8(0LL, v154);
			//         HG::Rendering::Runtime::GPUDrivenCullingPassConstructor::ConstructPass(
			//           v159,
			//           &v400,
			//           (GPUDrivenCullingPassConstructor_PassOutput *)&v327,
			//           m_RenderGraph,
			//           *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._ViewProjMatrix.m21,
			//           0LL);
			//       }
			//       catch ( Il2CppExceptionWrapper *v429 )
			//       {
			//         v332.handle = (ResourceHandle)v429.ex;
			//         if ( v332.handle )
			//           sub_18000F780(*(_QWORD *)&v332.handle);
			//         v37 = 2LL;
			//         RendererList = -1;
			//         v3 = this;
			//         m_RenderGraph = v331;
			//       }
			//     }
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)0x18u,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     v332.handle = 0LL;
			//     v332.fallBackResource = (ResourceHandle)&v509;
			//     try
			//     {
			//       sub_1802F01E0(&v398, 0LL, 184LL);
			//       v398.sceneColor = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._InvViewProjMatrix.m23;
			//       v398.sceneDepth = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewProjMatrix.m20;
			//       v398.sceneMV = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewProjMatrix.m21;
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//       v398.sceneDepthCopied = *(TextureHandle *)sub_182E7CCD0(&v347);
			//       v398.gBufferOutput = *(GBufferOutput *)&v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m22;
			//       v398.cullingResults = cullingResults;
			//       v398.bakedLightConfig = v335.fields.m_CurrentRendererConfigurationBakedLighting;
			//       v398.enableTerrainTessellation = renderPathParams.renderRequest.enableTerrainTessellation;
			//       currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//       if ( !currentManagerContext )
			//         sub_1802DC2C8(v162, v161);
			//       waterManager_k__BackingField = currentManagerContext.fields._waterManager_k__BackingField;
			//       if ( !waterManager_k__BackingField )
			//         sub_1802DC2C8(0LL, v161);
			//       v398.enableTerrainWetRipple = HG::Rendering::Runtime::HGWaterManager::GetTerrainRippleOpacity(
			//                                       waterManager_k__BackingField,
			//                                       0LL) > 0.0;
			//       if ( !hgCamera )
			//         sub_1802DC2C8(v165, v164);
			//       v398.screenCullingRatio = hgCamera.fields.screenCullingRatio;
			//       v398.screenCullingRatioDistance = hgCamera.fields.screenRatioCullingDistance;
			//       v398.screenCullingLayerMask = HG::Rendering::Runtime::HGCamera::get_screenCullingLayerMask(hgCamera, 0LL);
			//       v398.deferredOpaqueECSList = LODWORD(v3[1].fields._._._.m_basicTransformConstants._InvPretransformMatrix.m12);
			//       v398.deferredOpaqueEqualECSList = LODWORD(v3[1].fields._._._.m_basicTransformConstants._InvPretransformMatrix.m22);
			//       v398.deferredGrassECSList = LODWORD(v3[1].fields._._._.m_basicTransformConstants._InvPretransformMatrix.m32);
			//       v398.deferredSludgeECSList = LODWORD(v3[1].fields._._._.m_basicTransformConstants._InvPretransformMatrix.m03);
			//       v398.characterPrePassECSList = LODWORD(v3[1].fields._._._.m_basicTransformConstants._InvPretransformMatrix.m02);
			//       v398.characterOutlinePrePassECSList = LODWORD(v3[1].fields._._._.m_basicTransformConstants._InvPretransformMatrix.m21);
			//       v398.deferredOpaqueGPUDrivenList = LODWORD(v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewProjMatrix.m20);
			//       v398.deferredOpaqueEqualGPUDrivenList = LODWORD(v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewProjMatrix.m30);
			//       v469 = v398;
			//       v341 = 0;
			//       v167 = *(GBufferPassConstructor **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m03;
			//       if ( !v167 )
			//         sub_1802DC2C8(0LL, v166);
			//       HG::Rendering::Runtime::GBufferPassConstructor::ConstructPass(
			//         v167,
			//         &v469,
			//         &v341,
			//         m_RenderGraph,
			//         *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._ViewProjMatrix.m21,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v430 )
			//     {
			//       v332.handle = (ResourceHandle)v430.ex;
			//       if ( v332.handle )
			//         sub_18000F780(*(_QWORD *)&v332.handle);
			//       v37 = 2LL;
			//       RendererList = -1;
			//       v3 = this;
			//       m_RenderGraph = v331;
			//     }
			//     if ( !BYTE1(v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01) )
			//     {
			//       UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//         (Int32Enum__Enum)0x1Eu,
			//         MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//       v332.handle = 0LL;
			//       v332.fallBackResource = (ResourceHandle)&v509;
			//       try
			//       {
			//         memset(v355, 0, 20);
			//         v169 = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewProjMatrix.m20;
			//         m01_low = 1;
			//         if ( !v486 )
			//           m01_low = LOBYTE(v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01);
			//         v355[16] = m01_low != 0;
			//         v356.depthTexture = v169;
			//         *(_DWORD *)&v356.buildHZB = *(_DWORD *)&v355[16];
			//         v347.depthTexture = 0LL;
			//         v171 = *(BuildHZBPass **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m02;
			//         if ( !v171 )
			//           sub_1802DC2C8(0LL, v168);
			//         HG::Rendering::Runtime::BuildHZBPass::ConstructPass(
			//           v171,
			//           &v356,
			//           (BuildHZBPass_PassOutput *)&v347,
			//           m_RenderGraph,
			//           *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._ViewProjMatrix.m21,
			//           0LL);
			//       }
			//       catch ( Il2CppExceptionWrapper *v404 )
			//       {
			//         v332.handle = (ResourceHandle)v404.ex;
			//         if ( v332.handle )
			//           sub_18000F780(*(_QWORD *)&v332.handle);
			//         v37 = 2LL;
			//         RendererList = -1;
			//         v3 = this;
			//         m_RenderGraph = v331;
			//       }
			//     }
			//     v172 = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewProjMatrix.m20;
			//     v173 = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewProjMatrix.m22;
			//     v174 = 0LL;
			//     v330 = 0LL;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
			//     v347.depthTexture = 0LL;
			//     v356.depthTexture = v173;
			//     v332 = v172;
			//     HG::Rendering::Runtime::CopyTexturePass::BlitTexture(
			//       m_RenderGraph,
			//       &v332,
			//       &v356.depthTexture,
			//       0,
			//       -1,
			//       0,
			//       (Rect *)&v347,
			//       0,
			//       0LL);
			//     gbufferOutput = *(GBufferOutput *)&v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m22;
			//     GBufferAttachment = HG::Rendering::Runtime::GBufferOutput::GetGBufferAttachment(
			//                           &v332,
			//                           &gbufferOutput,
			//                           GBufferID__Enum_GBufferB,
			//                           0LL);
			//     v347.depthTexture = 0LL;
			//     v356.depthTexture = *(TextureHandle *)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m01;
			//     v332 = *GBufferAttachment;
			//     HG::Rendering::Runtime::CopyTexturePass::BlitTexture(
			//       m_RenderGraph,
			//       &v332,
			//       &v356.depthTexture,
			//       0,
			//       -1,
			//       0,
			//       (Rect *)&v347,
			//       0,
			//       0LL);
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)0x19u,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     v332.handle = 0LL;
			//     v332.fallBackResource = (ResourceHandle)&v509;
			//     try
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields;
			//       deferredDecal = static_fields.deferredDecal;
			//       if ( !deferredDecal )
			//         sub_1802DC2C8(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager, 0LL);
			//       deferredErosion = static_fields.deferredErosion;
			//       if ( !deferredErosion )
			//         sub_1802DC2C8(0LL, deferredDecal);
			//       m_defaultValue = (GpuClothSimulationPassConstructor_PassInput)deferredErosion.fields.m_defaultValue;
			//       v327 = m_defaultValue;
			//       if ( deferredDecal.fields.m_defaultValue )
			//       {
			//         v180 = *(_QWORD *)&v3[1].fields._._._.m_basicTransformConstants._ViewProjMatrix.m21;
			//         if ( !v180 )
			//           sub_1802DC2C8(deferredErosion, deferredDecal);
			//         viewHandle = *(_DWORD *)(v180 + 2592);
			//         if ( !m_RenderGraph )
			//           sub_1802DC2C8(deferredErosion, deferredDecal);
			//         m_RenderGraphContext = m_RenderGraph.fields.m_RenderGraphContext;
			//         if ( !m_RenderGraphContext )
			//           sub_1802DC2C8(deferredErosion, deferredDecal);
			//         sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//         viewHandle = UnityEngine::HyperGryph::HGDecalRender::CreateRendererList(
			//                        viewHandle,
			//                        1u,
			//                        m_RenderGraphContext.fields.renderContext.m_Ptr,
			//                        0LL,
			//                        0LL);
			//         m_defaultValue = v327;
			//       }
			//       else
			//       {
			//         viewHandle = -1;
			//       }
			//       if ( m_defaultValue )
			//       {
			//         v182 = *(_QWORD *)&v3[1].fields._._._.m_basicTransformConstants._ViewProjMatrix.m21;
			//         if ( !v182 )
			//           sub_1802DC2C8(deferredErosion, deferredDecal);
			//         v346[0] = *(_DWORD *)(v182 + 2592);
			//         if ( !m_RenderGraph )
			//           sub_1802DC2C8(deferredErosion, deferredDecal);
			//         v183 = m_RenderGraph.fields.m_RenderGraphContext;
			//         if ( !v183 )
			//           sub_1802DC2C8(deferredErosion, deferredDecal);
			//         sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//         m_Ptr = v183.fields.renderContext.m_Ptr;
			//         LOWORD(camera) = 0;
			//         RendererList = UnityEngine::HyperGryph::HGMeshRender::CreateRendererList(
			//                          v346[0],
			//                          HGRenderFlags__Enum_ShadowOnly|HGRenderFlags__Enum_Opaque,
			//                          HGRenderFlags__Enum_Opaque,
			//                          HGShaderLightMode__Enum_Erosion,
			//                          (HGRenderKeyword__Enum)camera,
			//                          m_Ptr,
			//                          0,
			//                          0,
			//                          0xFFFFFFFF,
			//                          0,
			//                          0,
			//                          0LL);
			//       }
			//       sub_1802F01E0(&invViewMatrix, 0LL, 160LL);
			//       invViewMatrix = *(Matrix4x4 *)&v3[1].fields._._._.m_basicTransformConstants._InvViewProjMatrix.m23;
			//       v373 = *(TextureHandle *)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m01;
			//       v374 = *(GBufferOutput *)&v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m22;
			//       v375 = cullingResults;
			//       v186 = (unsigned int)v335.fields.m_CurrentRendererConfigurationBakedLighting;
			//       LODWORD(v376) = v335.fields.m_CurrentRendererConfigurationBakedLighting;
			//       if ( !hgCamera )
			//         sub_1802DC2C8(v186, v185);
			//       *(_QWORD *)((char *)&v376 + 4) = *(_QWORD *)&hgCamera.fields.screenCullingRatio;
			//       HIDWORD(v376) = HG::Rendering::Runtime::HGCamera::get_screenCullingLayerMask(hgCamera, 0LL);
			//       sceneColor_k__BackingField.handle = (ResourceHandle)__PAIR64__(RendererList, viewHandle);
			//       sceneColor_k__BackingField.fallBackResource.m_Value = LODWORD(v3[1].fields._._._.m_basicTransformConstants._InvPretransformMatrix.m03);
			//       v398.sceneColor = *(TextureHandle *)&invViewMatrix.m00;
			//       v398.sceneDepth = *(TextureHandle *)&invViewMatrix.m01;
			//       v398.sceneMV = *(TextureHandle *)&invViewMatrix.m02;
			//       v398.sceneColorCopied = *(TextureHandle *)&invViewMatrix.m03;
			//       v398.sceneDepthCopied = v373;
			//       v398.gBufferOutput = v374;
			//       v398.cullingResults = v375;
			//       *(_OWORD *)&v398.bakedLightConfig = v376;
			//       *(TextureHandle *)&v398.screenCullingLayerMask = sceneColor_k__BackingField;
			//       v327 = 0;
			//       v188 = *(DecalPassConstructor **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m00;
			//       if ( !v188 )
			//         sub_1802DC2C8(0LL, v187);
			//       HG::Rendering::Runtime::DecalPassConstructor::ConstructPass(
			//         v188,
			//         (DecalPassConstructor_PassInput *)&v398,
			//         (DecalPassConstructor_PassOutput *)&v327,
			//         m_RenderGraph,
			//         *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._ViewProjMatrix.m21,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v431 )
			//     {
			//       v332.handle = (ResourceHandle)v431.ex;
			//       if ( v332.handle )
			//         sub_18000F780(*(_QWORD *)&v332.handle);
			//       v37 = 2LL;
			//       v3 = this;
			//       m_RenderGraph = v331;
			//       v174 = v330;
			//     }
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)5u,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGRenderPathScene::OtherPassScope>);
			//     v332.handle = 0LL;
			//     v332.fallBackResource = (ResourceHandle)&v509;
			//     try
			//     {
			//       sub_1802F01E0(&v384, 0LL, 208LL);
			//       v384.srpContext = renderContext;
			//       v384.sceneDepth = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewProjMatrix.m20;
			//       v384.sceneDepthCopied = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewProjMatrix.m22;
			//       v472 = v384;
			//       memset(&v394, 0, sizeof(v394));
			//       v190 = *(WaterDefaultDeferredRenderingPass **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m21;
			//       v191 = *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._ViewProjMatrix.m21;
			//       gbufferOutput = *(GBufferOutput *)&v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m22;
			//       if ( !v190 )
			//         sub_1802DC2C8(0LL, v189);
			//       HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::RenderWaterWetnessMask(
			//         v190,
			//         &v472,
			//         &v394,
			//         m_RenderGraph,
			//         v191,
			//         &gbufferOutput,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v432 )
			//     {
			//       v332.handle = (ResourceHandle)v432.ex;
			//       if ( v332.handle )
			//         sub_18000F780(*(_QWORD *)&v332.handle);
			//       v37 = 2LL;
			//       v3 = this;
			//       m_RenderGraph = v331;
			//       v174 = v330;
			//     }
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)9u,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     v332.handle = 0LL;
			//     v332.fallBackResource = (ResourceHandle)&v509;
			//     try
			//     {
			//       gbufferOutput = *(GBufferOutput *)&v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m22;
			//       v192 = HG::Rendering::Runtime::GBufferOutput::GetGBufferAttachment(
			//                &v347.depthTexture,
			//                &gbufferOutput,
			//                GBufferID__Enum_GBufferB,
			//                0LL);
			//       memset(v355, 0, 32);
			//       v194 = *v192;
			//       v395.sceneDepth = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewProjMatrix.m20;
			//       v395.sceneNormal = v194;
			//       v342 = 0;
			//       v195 = *(GPUParticleSimulationPassConstructor **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m23;
			//       if ( !v195 )
			//         sub_1802DC2C8(0LL, v193);
			//       HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::ConstructPass(
			//         v195,
			//         &v395,
			//         &v342,
			//         m_RenderGraph,
			//         *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._ViewProjMatrix.m21,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v433 )
			//     {
			//       v332.handle = (ResourceHandle)v433.ex;
			//       if ( v332.handle )
			//         sub_18000F780(*(_QWORD *)&v332.handle);
			//       v37 = 2LL;
			//       v3 = this;
			//       m_RenderGraph = v331;
			//       v174 = v330;
			//     }
			//     v196 = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewProjMatrix.m20;
			//     v197 = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewProjMatrix.m22;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
			//     v347.depthTexture = v174;
			//     v356.depthTexture = v197;
			//     v332 = v196;
			//     HG::Rendering::Runtime::CopyTexturePass::BlitTexture(
			//       m_RenderGraph,
			//       &v332,
			//       &v356.depthTexture,
			//       0,
			//       -1,
			//       0,
			//       (Rect *)&v347,
			//       0,
			//       0LL);
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)5u,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGRenderPathScene::OtherPassScope>);
			//     v332.handle = 0LL;
			//     v332.fallBackResource = (ResourceHandle)&v509;
			//     try
			//     {
			//       sub_1802F01E0(&v384, 0LL, 208LL);
			//       v198 = settingParameter[0];
			//       v384.enableIndirect = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                               settingParameter[0].fields._waterIndirectEnable_k__BackingField,
			//                               MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//       v384.depthFormat = renderPathParams.perFrameSetup.depthGraphicsFormat;
			//       v384.depthBits = renderPathParams.perFrameSetup.depthBits;
			//       v200 = *(TextureHandle **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m20;
			//       if ( !v200 )
			//         sub_1802DC2C8(renderPathParams, v199);
			//       v384.sectorTexture = v200[2];
			//       v201 = *(TextureHandle **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m01;
			//       if ( !v201 )
			//         sub_1802DC2C8(renderPathParams, v199);
			//       v384.interactionTexture = v201[19];
			//       v384.sceneColor = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._InvViewProjMatrix.m23;
			//       v384.sceneColorCopied = v362;
			//       v384.sceneDepth = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewProjMatrix.m20;
			//       v384.sceneDepthCopied = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewProjMatrix.m22;
			//       v384.sceneMV = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewProjMatrix.m21;
			//       v384.srpContext = renderContext;
			//       v384.gBufferOutput = *(GBufferOutput *)&v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m22;
			//       v384.settingParameters = v198;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v202 = (((unsigned __int64)&v384.settingParameters >> 12) & 0x1FFFFF) >> 6;
			//         _m_prefetchw(&qword_18D6405E0[v202 + 36190]);
			//         do
			//           v203 = qword_18D6405E0[v202 + 36190];
			//         while ( v203 != _InterlockedCompareExchange64(
			//                           &qword_18D6405E0[v202 + 36190],
			//                           v203 | (1LL << (((unsigned __int64)&v384.settingParameters >> 12) & 0x3F)),
			//                           v203) );
			//       }
			//       v473 = v384;
			//       memset(&v396, 0, sizeof(v396));
			//       v204 = *(WaterDefaultDeferredRenderingPass **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m21;
			//       v205 = *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._ViewProjMatrix.m21;
			//       if ( !v204 )
			//         sub_1802DC2C8(0LL, v205);
			//       HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::RenderPrepassV2(
			//         v204,
			//         &v473,
			//         &v396,
			//         m_RenderGraph,
			//         v205,
			//         wetnessHighQualityEnabled,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v434 )
			//     {
			//       v332.handle = (ResourceHandle)v434.ex;
			//       if ( v332.handle )
			//         sub_18000F780(*(_QWORD *)&v332.handle);
			//       v37 = 2LL;
			//       v3 = this;
			//       m_RenderGraph = v331;
			//     }
			//     gbufferOutput = *(GBufferOutput *)&v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m22;
			//     v206 = *HG::Rendering::Runtime::GBufferOutput::GetGBufferAttachment(
			//               &v347.depthTexture,
			//               &gbufferOutput,
			//               GBufferID__Enum_GBufferB,
			//               0LL);
			//     *(TextureHandle *)v346 = v206;
			//     v207 = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewProjMatrix.m20;
			//     v330 = v207;
			//     v106 = *(InkSimulationPassConstructor **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m00;
			//     if ( !v106 )
			// LABEL_536:
			//       sub_1802DC2C8(v106, v105);
			//     if ( HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::ShouldRenderTBuffer(
			//            (HyperScreenSpaceReflectionRenderingPass *)v106,
			//            hgCamera,
			//            0LL) )
			//     {
			//       UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//         (Int32Enum__Enum)0x22u,
			//         MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//       v332.handle = 0LL;
			//       v332.fallBackResource = (ResourceHandle)&v509;
			//       try
			//       {
			//         sub_1802F01E0(&v451.needCopyGBufferAndDepth + 1, 0LL, 207LL);
			//         v210 = *(_QWORD *)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m21;
			//         if ( !v210 )
			//           sub_1802DC2C8(v209, v208);
			//         v451.needCopyGBufferAndDepth = *(_BYTE *)(v210 + 16) == 0;
			//         v451.forwardReflectionECSList = LODWORD(v3[1].fields._._._.m_shaderVariablesGlobal._PrevViewProjMatrix.m00);
			//         v465 = v451;
			//         wetnessHighQualityEnabled = 0;
			//         v211 = *(_QWORD *)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m21;
			//         if ( !v211 )
			//           sub_1802DC2C8(&v465.normalRoughnessTexture.handle._type_k__BackingField, v208);
			//         if ( *(_BYTE *)(v211 + 16) )
			//         {
			//           v206 = *(TextureHandle *)(v211 + 208);
			//           *(TextureHandle *)v346 = v206;
			//           v207 = *(TextureHandle *)(v211 + 224);
			//           v465.normalRoughnessTexture = v206;
			//           v465.currentSceneDepthTexture = v207;
			//         }
			//         else
			//         {
			//           gbufferOutput = *(GBufferOutput *)&v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m22;
			//           v356.depthTexture = *HG::Rendering::Runtime::GBufferOutput::GetGBufferAttachment(
			//                                  &v347.depthTexture,
			//                                  &gbufferOutput,
			//                                  GBufferID__Enum_GBufferB,
			//                                  0LL);
			//           v347.depthTexture = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewProjMatrix.m20;
			//           if ( !m_RenderGraph )
			//             sub_1802DC2C8(v213, v212);
			//           v206 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                     (TextureHandle *)v355,
			//                     m_RenderGraph,
			//                     &v356.depthTexture,
			//                     0LL);
			//           *(TextureHandle *)v346 = v206;
			//           v207 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                     (TextureHandle *)v355,
			//                     m_RenderGraph,
			//                     &v347.depthTexture,
			//                     0LL);
			//           v465.normalRoughnessTexture = v356.depthTexture;
			//           v465.currentSceneDepthTexture = v347.depthTexture;
			//           v465.normalRoughnessTextureCopy = v206;
			//           v465.currentSceneDepthTextureCopy = v207;
			//         }
			//         v330 = v207;
			//         v214 = *(HyperScreenSpaceReflectionRenderingPass **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m00;
			//         if ( !v214 )
			//           sub_1802DC2C8(0LL, v208);
			//         HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::RenderTBuffer(
			//           v214,
			//           &v465,
			//           (HyperScreenSpaceReflectionRenderingPass_PassOutput *)&wetnessHighQualityEnabled,
			//           m_RenderGraph,
			//           *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._ViewProjMatrix.m21,
			//           0LL);
			//       }
			//       catch ( Il2CppExceptionWrapper *v435 )
			//       {
			//         v332.handle = (ResourceHandle)v435.ex;
			//         if ( v332.handle )
			//           sub_18000F780(*(_QWORD *)&v332.handle);
			//         v37 = 2LL;
			//         v3 = this;
			//         m_RenderGraph = v331;
			//         v206 = *(TextureHandle *)v346;
			//         v207 = v330;
			//       }
			//     }
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)0x1Fu,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     v332.handle = 0LL;
			//     v332.fallBackResource = (ResourceHandle)&v509;
			//     try
			//     {
			//       v356.depthTexture = v207;
			//       v347.depthTexture = 0LL;
			//       v216 = *(DepthPyramidRenderingPass **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m22;
			//       if ( !v216 )
			//         sub_1802DC2C8(0LL, v215);
			//       HG::Rendering::Runtime::DepthPyramidRenderingPass::ConstructPass(
			//         v216,
			//         (DepthPyramidRenderingPass_PassInput *)&v356,
			//         (DepthPyramidRenderingPass_PassOutput *)&v347,
			//         m_RenderGraph,
			//         *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._ViewProjMatrix.m21,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v436 )
			//     {
			//       v332.handle = (ResourceHandle)v436.ex;
			//       if ( v332.handle )
			//         sub_18000F780(*(_QWORD *)&v332.handle);
			//       v37 = 2LL;
			//       v3 = this;
			//       m_RenderGraph = v331;
			//       v206 = *(TextureHandle *)v346;
			//     }
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     v356.depthTexture = *(TextureHandle *)sub_182E7CCD0(v355);
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)0x20u,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     v332.handle = 0LL;
			//     v332.fallBackResource = (ResourceHandle)&v509;
			//     try
			//     {
			//       sub_1802F01E0(v448, 0LL, 72LL);
			//       v217 = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewProjMatrix.m20;
			//       v218 = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewProjMatrix.m21;
			//       v219 = *(NativeArray_1_HG_Rendering_RenderGraphModule_TextureHandle_ *)&v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m22;
			//       v220 = *(NativeArray_1_System_Int32_ *)&v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m23;
			//       v449.m_Value = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//                        (SettingParameter_1_System_Int32Enum_ *)settingParameter[0].fields._gtaoQualityLevel_k__BackingField,
			//                        MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//       v447.sceneDepth = v217;
			//       v447.sceneMV = v218;
			//       v447.gBufferOutput.m_attachments = v219;
			//       v447.gBufferOutput.m_gbufferMapping = v220;
			//       *(ResourceHandle *)&v447.qualityLevel = v449;
			//       v347.depthTexture = 0LL;
			//       v222 = *(GTAOPassConstructor **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m03;
			//       if ( !v222 )
			//         sub_1802DC2C8(0LL, v221);
			//       HG::Rendering::Runtime::GTAOPassConstructor::ConstructPass(
			//         v222,
			//         &v447,
			//         (GTAOPassConstructor_PassOutput *)&v347,
			//         m_RenderGraph,
			//         *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._ViewProjMatrix.m21,
			//         0LL);
			//       v356.depthTexture = v347.depthTexture;
			//     }
			//     catch ( Il2CppExceptionWrapper *v437 )
			//     {
			//       v332.handle = (ResourceHandle)v437.ex;
			//       if ( v332.handle )
			//         sub_18000F780(*(_QWORD *)&v332.handle);
			//       v37 = 2LL;
			//       v3 = this;
			//       m_RenderGraph = v331;
			//       v206 = *(TextureHandle *)v346;
			//     }
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     v347.depthTexture = *(TextureHandle *)sub_182E7CCD0(v355);
			//     v330 = *(TextureHandle *)sub_182E7CCD0(v355);
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)0x22u,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     v332.handle = 0LL;
			//     v332.fallBackResource = (ResourceHandle)&v509;
			//     try
			//     {
			//       sub_1802F01E0(&v451, 0LL, 208LL);
			//       v223 = settingParameter[0];
			//       v451.ssrRayMarchingSampleCount = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//                                          (SettingParameter_1_System_Int32Enum_ *)settingParameter[0].fields._ssrRayMarchingSampleCount_k__BackingField,
			//                                          MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//       v451.previousSceneColorTexture = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewNoTransProjMatrix.m00;
			//       v226 = *(_QWORD *)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m22;
			//       if ( !v226 )
			//         sub_1802DC2C8(v225, v224);
			//       v451.previousSceneDepthPyramidTexture = *(TextureHandle *)(v226 + 56);
			//       v451.currentSceneDepthTexture = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewProjMatrix.m20;
			//       v451.currentSceneDepthPyramidTexture = *(TextureHandle *)(v226 + 40);
			//       gbufferOutput = *(GBufferOutput *)&v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m22;
			//       v451.gbufferNormalRoughenssTexture = *HG::Rendering::Runtime::GBufferOutput::GetGBufferAttachment(
			//                                               (TextureHandle *)v355,
			//                                               &gbufferOutput,
			//                                               GBufferID__Enum_GBufferB,
			//                                               0LL);
			//       v451.normalRoughnessTexture = v206;
			//       v451.motionVectorTexture = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewProjMatrix.m21;
			//       v229 = *(TextureHandle **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m21;
			//       if ( !v229 )
			//         sub_1802DC2C8(v228, v227);
			//       v451.waterWetnessMaskTexture = v229[16];
			//       v451.renderContext = renderContext;
			//       v451.settingParameters = v223;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v230 = (((unsigned __int64)&v451.settingParameters >> 12) & 0x1FFFFF) >> 6;
			//         _m_prefetchw(&qword_18D6405E0[v230 + 36190]);
			//         do
			//           v231 = qword_18D6405E0[v230 + 36190];
			//         while ( v231 != _InterlockedCompareExchange64(
			//                           &qword_18D6405E0[v230 + 36190],
			//                           v231 | (1LL << (((unsigned __int64)&v451.settingParameters >> 12) & 0x3F)),
			//                           v231) );
			//       }
			//       v474 = v451;
			//       v343 = 0;
			//       v232 = *(HyperScreenSpaceReflectionRenderingPass **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m00;
			//       v233 = *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._ViewProjMatrix.m21;
			//       if ( !v232 )
			//         sub_1802DC2C8(0LL, v233);
			//       HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::Render(
			//         v232,
			//         &v474,
			//         &v343,
			//         m_RenderGraph,
			//         v233,
			//         enableWetness,
			//         0LL);
			//       v236 = *(TextureHandle **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m00;
			//       if ( !v236 )
			//         sub_1802DC2C8(v235, v234);
			//       v347.depthTexture = v236[8];
			//       v330 = v236[9];
			//     }
			//     catch ( Il2CppExceptionWrapper *v438 )
			//     {
			//       v332.handle = (ResourceHandle)v438.ex;
			//       if ( v332.handle )
			//         sub_18000F780(*(_QWORD *)&v332.handle);
			//       v37 = 2LL;
			//       v3 = this;
			//       m_RenderGraph = v331;
			//     }
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)0x24u,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     v332.handle = 0LL;
			//     v332.fallBackResource = (ResourceHandle)&v509;
			//     try
			//     {
			//       *(_QWORD *)v355 = 0LL;
			//       *(_QWORD *)&v355[8] = 0LL;
			//       *(_WORD *)&v355[37] = 0;
			//       v355[39] = 0;
			//       v237 = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewProjMatrix.m20;
			//       *(_DWORD *)&v355[32] = HG::Rendering::Runtime::HGRenderPipeline::GetRemappedRenderingScale(v335, 0LL);
			//       si128 = (Vector4)_mm_load_si128((const __m128i *)&output);
			//       v355[36] = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                    settingParameter[0].fields._contactShadowEnableParam_k__BackingField,
			//                    MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//       v386.sceneDepth = v237;
			//       v386.lightDir = si128;
			//       *(_QWORD *)&v386.renderingScale = *(_QWORD *)&v355[32];
			//       enableWetness = 0;
			//       v240 = *(ContactShadowPassConstructor **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m20;
			//       if ( !v240 )
			//         sub_1802DC2C8(0LL, v239);
			//       HG::Rendering::Runtime::ContactShadowPassConstructor::ConstructPass(
			//         v240,
			//         &v386,
			//         (ContactShadowPassConstructor_PassOutput *)&enableWetness,
			//         m_RenderGraph,
			//         *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._ViewProjMatrix.m21,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v439 )
			//     {
			//       v332.handle = (ResourceHandle)v439.ex;
			//       if ( v332.handle )
			//         sub_18000F780(*(_QWORD *)&v332.handle);
			//       v37 = 2LL;
			//       v3 = this;
			//       m_RenderGraph = v331;
			//     }
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)0x25u,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     v332.handle = 0LL;
			//     v332.fallBackResource = (ResourceHandle)&v509;
			//     try
			//     {
			//       sub_1802F01E0(&v403, 0LL, 144LL);
			//       v403.sceneDepth = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewProjMatrix.m20;
			//       v403.sceneDepthCopied = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewProjMatrix.m22;
			//       v403.sceneMV = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewProjMatrix.m21;
			//       v403.cullingResults = cullingResults;
			//       v403.lightCullResult = lightCullResult;
			//       v403.gBufferOutput = *(GBufferOutput *)&v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m22;
			//       v403.directionalLightIndex = v479;
			//       v241 = settingParameter[0];
			//       v403.sphereIntervalScale = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                                    settingParameter[0].fields._visSHSphereIntervalScale_k__BackingField,
			//                                    MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//       v403.sphereRangeScale = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                                 v241.fields._visSHSphereRangeScale_k__BackingField,
			//                                 MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//       v403.enabled = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                        v241.fields._visSHEnabled_k__BackingField,
			//                        MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//       v403.enableHalfRez = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                              v241.fields._visSHHalfRez_k__BackingField,
			//                              MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//       *(_QWORD *)&v403.depthFormat = *(_QWORD *)&renderPathParams.perFrameSetup.depthGraphicsFormat;
			//       v243 = renderPathParams.hgrp;
			//       if ( !v243 )
			//         sub_1802DC2C8(renderPathParams, v242);
			//       v403.visibilitySHMaterial = v243.fields.visibilitySHMaterial;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v244 = (((unsigned __int64)&v403.visibilitySHMaterial >> 12) & 0x1FFFFF) >> 6;
			//         v242 = ((unsigned __int64)&v403.visibilitySHMaterial >> 12) & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v244 + 36190]);
			//         do
			//           v245 = qword_18D6405E0[v244 + 36190];
			//         while ( v245 != _InterlockedCompareExchange64(&qword_18D6405E0[v244 + 36190], v245 | (1LL << v242), v245) );
			//       }
			//       v466 = v403;
			//       v344 = 0;
			//       v246 = *(CapsuleShadowPassConstructor **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m01;
			//       if ( !v246 )
			//         sub_1802DC2C8(0LL, v242);
			//       HG::Rendering::Runtime::CapsuleShadowPassConstructor::ConstructPass_VisibilitySH(
			//         v246,
			//         &v466,
			//         &v344,
			//         m_RenderGraph,
			//         *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._ViewProjMatrix.m21,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v440 )
			//     {
			//       v332.handle = (ResourceHandle)v440.ex;
			//       if ( v332.handle )
			//         sub_18000F780(*(_QWORD *)&v332.handle);
			//       v37 = 2LL;
			//       v3 = this;
			//       m_RenderGraph = v331;
			//     }
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)0x26u,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     lightCullResult.visibleLightsPtr = 0LL;
			//     *(_QWORD *)&lightCullResult.visibleLightCount = &v509;
			//     try
			//     {
			//       sub_1802F01E0(v448, 0LL, 72LL);
			//       v247 = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewProjMatrix.m20;
			//       v248 = *(CullingResults *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewProjMatrix.m22;
			//       gbufferOutput = *(GBufferOutput *)&v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m22;
			//       v249 = *HG::Rendering::Runtime::GBufferOutput::GetGBufferAttachment((TextureHandle *)v355, &gbufferOutput, 0, 0LL);
			//       gbufferOutput = *(GBufferOutput *)&v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m22;
			//       v250 = *HG::Rendering::Runtime::GBufferOutput::GetGBufferAttachment((TextureHandle *)v355, &gbufferOutput, 1, 0LL);
			//       LOBYTE(v449.m_Value) = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                                settingParameter[0].fields._enableScreenSpaceShadowMask_k__BackingField,
			//                                MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//       v449._type_k__BackingField = HG::Rendering::Runtime::HGRenderPipeline::GetRemappedRenderingScale(v335, 0LL);
			//       v392.sceneDepth = v247;
			//       v392.cullingResults = v248;
			//       *(TextureHandle *)&v392.bakedLightingConfig = v249;
			//       *(TextureHandle *)&v392.terrainGpuSubd = v250;
			//       v392.HZBTexture.fallBackResource = v449;
			//       enableWetness = 0;
			//       v252 = *(ScreenSpaceShadowMaskPassConstructor **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m21;
			//       if ( !v252 )
			//         sub_1802DC2C8(0LL, v251);
			//       HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor::ConstructPass(
			//         v252,
			//         (ScreenSpaceShadowMaskPassConstructor_PassInput *)&v392,
			//         (ScreenSpaceShadowMaskPassConstructor_PassOutput *)&enableWetness,
			//         m_RenderGraph,
			//         *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._ViewProjMatrix.m21,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v441 )
			//     {
			//       lightCullResult.visibleLightsPtr = v441.ex;
			//       if ( lightCullResult.visibleLightsPtr )
			//         sub_18000F780(lightCullResult.visibleLightsPtr);
			//       v37 = 2LL;
			//       v3 = this;
			//       m_RenderGraph = v331;
			//     }
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)0x21u,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     lightCullResult.visibleLightsPtr = 0LL;
			//     *(_QWORD *)&lightCullResult.visibleLightCount = &v509;
			//     try
			//     {
			//       sub_1802F01E0(&v402.characterOutlineEnable + 1, 0LL, 183LL);
			//       v402.characterOutlineEnable = CharOutlinePassEnableState;
			//       v255 = hgCamera;
			//       if ( !hgCamera )
			//         sub_1802DC2C8(v254, v253);
			//       v402.screenCullingLayerMask = HG::Rendering::Runtime::HGCamera::get_screenCullingLayerMask(hgCamera, 0LL);
			//       *(_QWORD *)&v402.screenCullingRatio = *(_QWORD *)&v255.fields.screenCullingRatio;
			//       v402.bakedLightingConfig = v335.fields.m_CurrentRendererConfigurationBakedLighting;
			//       v402.cullingResults = cullingResults;
			//       v402.shadowResult = *(ShadowResult *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewNoTransProjMatrix.m01;
			//       v402.hgrp = v335;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v256 = (((unsigned __int64)&v402.hgrp >> 12) & 0x1FFFFF) >> 6;
			//         _m_prefetchw(&qword_18D6405E0[v256 + 36190]);
			//         do
			//           v257 = qword_18D6405E0[v256 + 36190];
			//         while ( v257 != _InterlockedCompareExchange64(
			//                           &qword_18D6405E0[v256 + 36190],
			//                           v257 | (1LL << (((unsigned __int64)&v402.hgrp >> 12) & 0x3F)),
			//                           v257) );
			//       }
			//       v402.renderContext = renderContext;
			//       v402.characterPrePassECSList = LODWORD(v3[1].fields._._._.m_basicTransformConstants._InvPretransformMatrix.m02);
			//       v402.forwardOpaquePreZECSList = LODWORD(v3[1].fields._._._.m_basicTransformConstants._InvPretransformMatrix.m11);
			//       *(_QWORD *)&v402.forwardOpaqueECSList = *(_QWORD *)&v3[1].fields._._._.m_basicTransformConstants._InvPretransformMatrix.m13;
			//       v402.characterOpaqueECSList = LODWORD(v3[1].fields._._._.m_basicTransformConstants._WorldSpaceCameraPos_Internal.y);
			//       v402.characterOutlineOpaqueECSList = LODWORD(v3[1].fields._._._.m_basicTransformConstants._InvPretransformMatrix.m33);
			//       v402.characterOutlineOpaqueEqualECSList = LODWORD(v3[1].fields._._._.m_basicTransformConstants._WorldSpaceCameraPos_Internal.x);
			//       v402.sceneColorTexture = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._InvViewProjMatrix.m23;
			//       v402.sceneDepthTexture = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewProjMatrix.m20;
			//       v470 = v402;
			//       v345 = 0;
			//       v258 = *(FakePlanarReflectionPass **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m23;
			//       if ( !v258 )
			//         sub_1802DC2C8(0LL, &v3.fields._._._.m_shaderVariablesGlobal);
			//       HG::Rendering::Runtime::FakePlanarReflectionPass::ConstructPass(
			//         v258,
			//         &v470,
			//         &v345,
			//         &v3.fields._._._.m_basicTransformConstants,
			//         &v3.fields._._._.m_shaderVariablesGlobal,
			//         m_RenderGraph,
			//         *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._ViewProjMatrix.m21,
			//         settingParameter[0],
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v442 )
			//     {
			//       lightCullResult.visibleLightsPtr = v442.ex;
			//       if ( lightCullResult.visibleLightsPtr )
			//         sub_18000F780(lightCullResult.visibleLightsPtr);
			//       v37 = 2LL;
			//       v3 = this;
			//       m_RenderGraph = v331;
			//     }
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)0x27u,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     lightCullResult.visibleLightsPtr = 0LL;
			//     *(_QWORD *)&lightCullResult.visibleLightCount = &v509;
			//     try
			//     {
			//       sub_1802F01E0(v454, 0LL, 264LL);
			//       v454[0] = *(_OWORD *)&v3[1].fields._._._.m_basicTransformConstants._InvViewProjMatrix.m23;
			//       v454[1] = *(_OWORD *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewProjMatrix.m20;
			//       v454[2] = *(_OWORD *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewProjMatrix.m22;
			//       v454[3] = *(_OWORD *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewNoTransProjMatrix.m00;
			//       v454[4] = v356.depthTexture;
			//       v454[5] = v347.depthTexture;
			//       v454[6] = v330;
			//       v261 = *(_QWORD *)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m23;
			//       if ( !v261 )
			//         sub_1802DC2C8(v260, v259);
			//       v454[7] = *(_OWORD *)(v261 + 4536);
			//       v262 = *(_QWORD *)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m00;
			//       if ( !v262 )
			//         sub_1802DC2C8(v260, v259);
			//       v454[8] = *(_OWORD *)(v262 + 24);
			//       v263 = *(_QWORD *)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m21;
			//       if ( !v263 )
			//         sub_1802DC2C8(v260, v259);
			//       v454[9] = *(_OWORD *)(v263 + 256);
			//       v455 = v335;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v264 = (((unsigned __int64)&v455 >> 12) & 0x1FFFFF) >> 6;
			//         _m_prefetchw(&qword_18D6405E0[v264 + 36190]);
			//         do
			//           v265 = qword_18D6405E0[v264 + 36190];
			//         while ( v265 != _InterlockedCompareExchange64(
			//                           &qword_18D6405E0[v264 + 36190],
			//                           v265 | (1LL << (((unsigned __int64)&v455 >> 12) & 0x3F)),
			//                           v265) );
			//       }
			//       v456 = *(_OWORD *)&v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m22;
			//       v457 = *(_OWORD *)&v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m23;
			//       v458 = *(_OWORD *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewNoTransProjMatrix.m01;
			//       v459 = *(_OWORD *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewNoTransProjMatrix.m02;
			//       v460 = *(_OWORD *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewNoTransProjMatrix.m03;
			//       v461 = *(_QWORD *)&v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m00;
			//       m20 = v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m20;
			//       ColorBufferFormat = HG::Rendering::Runtime::HGRenderPipeline::GetColorBufferFormat(
			//                             v335,
			//                             *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._ViewProjMatrix.m21,
			//                             0LL);
			//       v267 = &v476;
			//       v268 = (TextureHandle *)v454;
			//       do
			//       {
			//         v267.sceneColor = *v268;
			//         v267.sceneDepth = v268[1];
			//         v267.sceneDepthCopied = v268[2];
			//         v267.historySceneColor = v268[3];
			//         v267.indirectAmbientOcclusionTexture = v268[4];
			//         v267.ssrLightingTexture = v268[5];
			//         v267.ssrFadenessTexture = v268[6];
			//         v267 = (DeferredLightingPassConstructor_PassInput *)((char *)v267 + 128);
			//         *(TextureHandle *)((char *)&v267[-1].shadowResult.punctualLightShadowResult + 4) = v268[7];
			//         v268 += 8;
			//         --v37;
			//       }
			//       while ( v37 );
			//       v267.sceneColor.handle = v268.handle;
			//       v347.depthTexture = 0LL;
			//       v269 = *(DeferredLightingPassConstructor **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m02;
			//       if ( !v269 )
			//         sub_1802DC2C8(0LL, v266);
			//       HG::Rendering::Runtime::DeferredLightingPassConstructor::ConstructPass(
			//         v269,
			//         &v476,
			//         (DeferredLightingPassConstructor_PassOutput *)&v347,
			//         m_RenderGraph,
			//         *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._ViewProjMatrix.m21,
			//         0LL);
			//       *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._InvViewProjMatrix.m23 = v347.depthTexture;
			//     }
			//     catch ( Il2CppExceptionWrapper *v443 )
			//     {
			//       lightCullResult.visibleLightsPtr = v443.ex;
			//       if ( lightCullResult.visibleLightsPtr )
			//         sub_18000F780(lightCullResult.visibleLightsPtr);
			//       v3 = this;
			//       m_RenderGraph = v331;
			//     }
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)0x17u,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     lightCullResult.visibleLightsPtr = 0LL;
			//     *(_QWORD *)&lightCullResult.visibleLightCount = &v509;
			//     try
			//     {
			//       sub_1802F01E0(&v445, 0LL, 200LL);
			//       v445.sceneColor = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._InvViewProjMatrix.m23;
			//       v445.sceneDepth = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewProjMatrix.m20;
			//       v445.sceneMV = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewProjMatrix.m21;
			//       v445.terrainDepthBuffer = v363.terrainDepthBuffer;
			//       v445.hgrp = v335;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v271 = (((unsigned __int64)&v445.hgrp >> 12) & 0x1FFFFF) >> 6;
			//         v270 = ((unsigned __int64)&v445.hgrp >> 12) & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v271 + 36190]);
			//         do
			//           v272 = qword_18D6405E0[v271 + 36190];
			//         while ( v272 != _InterlockedCompareExchange64(&qword_18D6405E0[v271 + 36190], v272 | (1LL << v270), v272) );
			//       }
			//       *(_QWORD *)&v445.forwardOpaqueECSRendererList = *(_QWORD *)&v3[1].fields._._._.m_basicTransformConstants._InvPretransformMatrix.m13;
			//       v445.characterOpaqueECSRendererList = LODWORD(v3[1].fields._._._.m_basicTransformConstants._WorldSpaceCameraPos_Internal.y);
			//       *(_QWORD *)&v445.characterOutlineOpaqueECSRendererList = *(_QWORD *)&v3[1].fields._._._.m_basicTransformConstants._InvPretransformMatrix.m33;
			//       v445.shadowResult = *(ShadowResult *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewNoTransProjMatrix.m01;
			//       v445.cullingResults = cullingResults;
			//       v273 = (unsigned int)v335.fields.m_CurrentRendererConfigurationBakedLighting;
			//       v445.bakedLightingConfig = v335.fields.m_CurrentRendererConfigurationBakedLighting;
			//       if ( !hgCamera )
			//         sub_1802DC2C8(v273, v270);
			//       *(_QWORD *)&v445.screenCullingRatio = *(_QWORD *)&hgCamera.fields.screenCullingRatio;
			//       v445.screenCullingLayerMask = HG::Rendering::Runtime::HGCamera::get_screenCullingLayerMask(hgCamera, 0LL);
			//       v445.characterOutlineEnabled = CharOutlinePassEnableState;
			//       v471 = v445;
			//       enableWetness = 0;
			//       v275 = *(ForwardOpaquePassConstructor **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m22;
			//       if ( !v275 )
			//         sub_1802DC2C8(0LL, v274);
			//       HG::Rendering::Runtime::ForwardOpaquePassConstructor::ConstructPass(
			//         v275,
			//         &v471,
			//         (ForwardOpaquePassConstructor_PassOutput *)&enableWetness,
			//         m_RenderGraph,
			//         *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._ViewProjMatrix.m21,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v444 )
			//     {
			//       lightCullResult.visibleLightsPtr = v444.ex;
			//       if ( lightCullResult.visibleLightsPtr )
			//         sub_18000F780(lightCullResult.visibleLightsPtr);
			//       v3 = this;
			//       m_RenderGraph = v331;
			//     }
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)6u,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGRenderPathScene::OtherPassScope>);
			//     lightCullResult.visibleLightsPtr = 0LL;
			//     *(_QWORD *)&lightCullResult.visibleLightCount = &v509;
			//     try
			//     {
			//       v276 = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._InvViewProjMatrix.m23;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//       SceneColorTexture = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._SceneColorTexture;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
			//       v363 = 0LL;
			//       v278 = v362;
			//       v347.depthTexture = v276;
			//       HG::Rendering::Runtime::CopyTexturePass::BlitTexture(
			//         m_RenderGraph,
			//         &v347.depthTexture,
			//         &v362,
			//         0,
			//         SceneColorTexture,
			//         0,
			//         (Rect *)&v363,
			//         0,
			//         0LL);
			//       CameraDepthTexture = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._CameraDepthTexture;
			//       v362 = 0LL;
			//       v363 = *(TerrainDepthPrepassConstructor_PassOutput *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewProjMatrix.m22;
			//       v347.depthTexture = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewProjMatrix.m20;
			//       HG::Rendering::Runtime::CopyTexturePass::BlitTexture(
			//         m_RenderGraph,
			//         &v347.depthTexture,
			//         &v363.terrainDepthBuffer,
			//         0,
			//         CameraDepthTexture,
			//         0,
			//         (Rect *)&v362,
			//         0,
			//         0LL);
			//       sub_1802F01E0(&v384, 0LL, 208LL);
			//       v384.depthFormat = renderPathParams.perFrameSetup.depthGraphicsFormat;
			//       v384.depthBits = renderPathParams.perFrameSetup.depthBits;
			//       v281 = *(TextureHandle **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m20;
			//       if ( !v281 )
			//         sub_1802DC2C8(renderPathParams, v280);
			//       v384.sectorTexture = v281[2];
			//       v282 = *(TextureHandle **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m01;
			//       if ( !v282 )
			//         sub_1802DC2C8(renderPathParams, v280);
			//       v384.interactionTexture = v282[19];
			//       v384.sceneColor = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._InvViewProjMatrix.m23;
			//       v384.sceneColorCopied = v278;
			//       v384.sceneDepth = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewProjMatrix.m20;
			//       v384.sceneDepthCopied = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewProjMatrix.m22;
			//       v384.sceneMV = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewProjMatrix.m21;
			//       v283 = *(TextureHandle **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m00;
			//       if ( !v283 )
			//         sub_1802DC2C8(renderPathParams, v280);
			//       v384.deferredSSRLightingTexture = v283[8];
			//       v384.ssrFadenessTexture = v283[9];
			//       v384.srpContext = renderContext;
			//       v384.gBufferOutput = *(GBufferOutput *)&v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m22;
			//       v475 = v384;
			//       memset(&v397, 0, sizeof(v397));
			//       v284 = *(WaterDefaultDeferredRenderingPass **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m21;
			//       if ( !v284 )
			//         sub_1802DC2C8(0LL, v280);
			//       HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::RenderLighting(
			//         v284,
			//         &v475,
			//         &v397,
			//         m_RenderGraph,
			//         *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._ViewProjMatrix.m21,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v446 )
			//     {
			//       lightCullResult.visibleLightsPtr = v446.ex;
			//       if ( lightCullResult.visibleLightsPtr )
			//         sub_18000F780(lightCullResult.visibleLightsPtr);
			//       v3 = this;
			//       m_RenderGraph = v331;
			//     }
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)0x10u,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     *(_QWORD *)v346 = 0LL;
			//     *(_QWORD *)&v346[2] = &v509;
			//     try
			//     {
			//       sub_1802F01E0(&v383, 0LL, 64LL);
			//       v383.sceneColor = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._InvViewProjMatrix.m23;
			//       v383.sceneDepth = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewProjMatrix.m20;
			//       v383.sceneDepthCopied = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewProjMatrix.m22;
			//       v287 = v335.fields._settingParameters_k__BackingField;
			//       if ( !v287 )
			//         sub_1802DC2C8(v286, v285);
			//       v383.volumetricParameters = v287.fields._volumetricCloud_k__BackingField;
			//       v288 = dword_18D8E43F8;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v289 = (((unsigned __int64)&v383.volumetricParameters >> 12) & 0x1FFFFF) >> 6;
			//         v285 = ((unsigned __int64)&v383.volumetricParameters >> 12) & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v289 + 36190]);
			//         do
			//           v290 = qword_18D6405E0[v289 + 36190];
			//         while ( v290 != _InterlockedCompareExchange64(&qword_18D6405E0[v289 + 36190], v290 | (1LL << v285), v290) );
			//         v288 = dword_18D8E43F8;
			//       }
			//       v383.volumetricRenderObjects = v492;
			//       if ( v288 )
			//       {
			//         v291 = (((unsigned __int64)&v383.volumetricRenderObjects >> 12) & 0x1FFFFF) >> 6;
			//         v285 = ((unsigned __int64)&v383.volumetricRenderObjects >> 12) & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v291 + 36190]);
			//         do
			//           v292 = qword_18D6405E0[v291 + 36190];
			//         while ( v292 != _InterlockedCompareExchange64(&qword_18D6405E0[v291 + 36190], v292 | (1LL << v285), v292) );
			//       }
			//       v450 = v383;
			//       enableWetness = 0;
			//       v293 = *(VolumetricCloudPassConstructor **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m23;
			//       if ( !v293 )
			//         sub_1802DC2C8(0LL, v285);
			//       HG::Rendering::Runtime::VolumetricCloudPassConstructor::ConstructPass(
			//         v293,
			//         &v450,
			//         (VolumetricCloudPassConstructor_PassOutput *)&enableWetness,
			//         m_RenderGraph,
			//         *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._ViewProjMatrix.m21,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v420 )
			//     {
			//       *(Il2CppExceptionWrapper *)v346 = (Il2CppExceptionWrapper)v420.ex;
			//       sub_1801E36C0(v346);
			//       v3 = this;
			//       m_RenderGraph = v331;
			//       goto LABEL_362;
			//     }
			//     sub_1801E36C0(v346);
			// LABEL_362:
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)0x2Bu,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     renderContext.m_Ptr = 0LL;
			//     v350 = &v509;
			//     try
			//     {
			//       memset(v355, 0, 48);
			//       v295 = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._InvViewProjMatrix.m23;
			//       v296 = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewProjMatrix.m20;
			//       v297 = settingParameter[0];
			//       lightShaft_k__BackingField = settingParameter[0].fields._lightShaft_k__BackingField;
			//       if ( !lightShaft_k__BackingField )
			//         sub_1802DC2C8(0LL, v294);
			//       v355[32] = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                    lightShaft_k__BackingField.fields.enableLightShaft,
			//                    MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//       v300 = v297.fields._lightShaft_k__BackingField;
			//       if ( !v300 )
			//         sub_1802DC2C8(0LL, v299);
			//       *(_DWORD *)&v355[36] = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                                v300.fields.lightShaftDownSampleFactor,
			//                                MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//       v302 = v297.fields._lightShaft_k__BackingField;
			//       if ( !v302 )
			//         sub_1802DC2C8(0LL, v301);
			//       *(_DWORD *)&v355[40] = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//                                (SettingParameter_1_System_Int32Enum_ *)v302.fields.lightShaftSampleNum,
			//                                MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//       v304 = v297.fields._lightShaft_k__BackingField;
			//       if ( !v304 )
			//         sub_1802DC2C8(0LL, v303);
			//       *(_DWORD *)&v355[44] = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//                                (SettingParameter_1_System_Int32Enum_ *)v304.fields.lightShaftBlurPassCount,
			//                                MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//       v401.sceneColor = v295;
			//       v401.sceneDepth = v296;
			//       *(_OWORD *)&v401.enableLightShaft = *(_OWORD *)&v355[32];
			//       memset(&v370, 0, sizeof(v370));
			//       v306 = *(LightShaftPassConstructor **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m00;
			//       if ( !v306 )
			//         sub_1802DC2C8(0LL, v305);
			//       HG::Rendering::Runtime::LightShaftPassConstructor::ConstructPass(
			//         v306,
			//         &v401,
			//         &v370,
			//         m_RenderGraph,
			//         *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._ViewProjMatrix.m21,
			//         0LL);
			//       *(LightShaftPassConstructor_PassOutput *)&v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m30 = v370;
			//     }
			//     catch ( Il2CppExceptionWrapper *v405 )
			//     {
			//       renderContext.m_Ptr = v405.ex;
			//       sub_1801E36C0(&renderContext);
			//       v3 = this;
			//       m_RenderGraph = v331;
			//       goto LABEL_370;
			//     }
			//     sub_1801E36C0(&renderContext);
			// LABEL_370:
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)0x28u,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     settingParameter[0] = 0LL;
			//     settingParameter[1] = (HGSettingParameters *)&v509;
			//     try
			//     {
			//       sub_1802F01E0(v493, 0LL, 4768LL);
			//       v493[0] = *(_OWORD *)&v3[1].fields._._._.m_basicTransformConstants._InvViewProjMatrix.m23;
			//       v493[1] = *(_OWORD *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewProjMatrix.m20;
			//       v309 = *(_QWORD *)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m22;
			//       if ( !v309 )
			//         sub_1802DC2C8(v308, v307);
			//       v493[4] = *(_OWORD *)(v309 + 40);
			//       v493[2] = *(_OWORD *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewProjMatrix.m21;
			//       v493[3] = *(_OWORD *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewProjMatrix.m22;
			//       v494 = v335;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v310 = (((unsigned __int64)&v494 >> 12) & 0x1FFFFF) >> 6;
			//         _m_prefetchw(&qword_18D6405E0[v310 + 36190]);
			//         do
			//           v311 = qword_18D6405E0[v310 + 36190];
			//         while ( v311 != _InterlockedCompareExchange64(
			//                           &qword_18D6405E0[v310 + 36190],
			//                           v311 | (1LL << (((unsigned __int64)&v494 >> 12) & 0x3F)),
			//                           v311) );
			//       }
			//       v495 = sub_18003ED00(18LL);
			//       v496 = *(_OWORD *)&v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m22;
			//       v497 = *(_OWORD *)&v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m23;
			//       v498[0] = 0LL;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v313 = (((unsigned __int64)v498 >> 12) & 0x1FFFFF) >> 6;
			//         v312 = ((unsigned __int64)v498 >> 12) & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v313 + 36190]);
			//         do
			//           v314 = qword_18D6405E0[v313 + 36190];
			//         while ( v314 != _InterlockedCompareExchange64(&qword_18D6405E0[v313 + 36190], v314 | (1LL << v312), v314) );
			//       }
			//       v499 = cullingResults;
			//       v315 = (unsigned int)v335.fields.m_CurrentRendererConfigurationBakedLighting;
			//       v500 = v335.fields.m_CurrentRendererConfigurationBakedLighting;
			//       z = v3[1].fields._._._.m_basicTransformConstants._WorldSpaceCameraPos_Internal.z;
			//       v502 = CharOutlinePassEnableState;
			//       if ( !hgCamera )
			//         sub_1802DC2C8(v315, v312);
			//       screenCullingRatio = hgCamera.fields.screenCullingRatio;
			//       screenRatioCullingDistance = hgCamera.fields.screenRatioCullingDistance;
			//       screenCullingLayerMask = HG::Rendering::Runtime::HGCamera::get_screenCullingLayerMask(hgCamera, 0LL);
			//       sub_1802EFB40(v480, v493, 4768LL);
			//       sub_1802EFB40(&v506, v480, 4768LL);
			//       v379 = 0LL;
			//       v317 = *(TransparentPassConstructor **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m03;
			//       if ( !v317 )
			//         sub_1802DC2C8(0LL, v316);
			//       HG::Rendering::Runtime::TransparentPassConstructor::ConstructPass(
			//         v317,
			//         &v506,
			//         &v379,
			//         m_RenderGraph,
			//         *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._ViewProjMatrix.m21,
			//         0LL);
			//       *(TransparentPassConstructor_PassOutput *)&v3[1].fields._._._.m_basicTransformConstants._InvViewProjMatrix.m23 = v379;
			//     }
			//     catch ( Il2CppExceptionWrapper *v406 )
			//     {
			//       settingParameter[0] = (HGSettingParameters *)v406.ex;
			//       sub_1801E36C0(settingParameter);
			//       v3 = this;
			//       m_RenderGraph = v331;
			//       goto LABEL_382;
			//     }
			//     sub_1801E36C0(settingParameter);
			// LABEL_382:
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)0x2Au,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     renderContext.m_Ptr = 0LL;
			//     v350 = &v509;
			//     try
			//     {
			//       sub_1802F01E0(&invViewMatrix, 0LL, 152LL);
			//       *(_OWORD *)&invViewMatrix.m00 = *(_OWORD *)&v3[1].fields._._._.m_basicTransformConstants._InvViewProjMatrix.m23;
			//       *(_OWORD *)&invViewMatrix.m01 = *(_OWORD *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewProjMatrix.m20;
			//       *(_OWORD *)&invViewMatrix.m02 = *(_OWORD *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewProjMatrix.m21;
			//       *(_OWORD *)&invViewMatrix.m03 = *(_OWORD *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewNoTransProjMatrix.m01;
			//       v373 = *(TextureHandle *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewNoTransProjMatrix.m02;
			//       v374.m_attachments = *(NativeArray_1_HG_Rendering_RenderGraphModule_TextureHandle_ *)&v3[1].fields._._._.m_basicTransformConstants._NonJitteredViewNoTransProjMatrix.m03;
			//       v374.m_gbufferMapping.m_Buffer = *(Void **)&v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m00;
			//       v374.m_gbufferMapping.m_Length = LODWORD(v3[1].fields._._._.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m20);
			//       v375 = cullingResults;
			//       v319 = (unsigned int)v335.fields.m_CurrentRendererConfigurationBakedLighting;
			//       LODWORD(v376) = v335.fields.m_CurrentRendererConfigurationBakedLighting;
			//       if ( !hgCamera )
			//         sub_1802DC2C8(v319, v318);
			//       *(_QWORD *)((char *)&v376 + 4) = *(_QWORD *)&hgCamera.fields.screenCullingRatio;
			//       HIDWORD(v376) = HG::Rendering::Runtime::HGCamera::get_screenCullingLayerMask(hgCamera, 0LL);
			//       sceneColor_k__BackingField.handle.m_Value = LODWORD(v3[1].fields._._._.m_basicTransformConstants._WorldSpaceCameraPos_Internal.w);
			//       v467.sceneColor = *(TextureHandle *)&invViewMatrix.m00;
			//       v467.sceneDepth = *(TextureHandle *)&invViewMatrix.m01;
			//       v467.sceneMV = *(TextureHandle *)&invViewMatrix.m02;
			//       *(_OWORD *)&v467.shadowResult.directionalShadowActive = *(_OWORD *)&invViewMatrix.m03;
			//       *(TextureHandle *)&v467.shadowResult.directionalShadowResult.fallBackResource._type_k__BackingField = v373;
			//       *(NativeArray_1_HG_Rendering_RenderGraphModule_TextureHandle_ *)&v467.shadowResult.characterShadowResult.fallBackResource.m_Value = v374.m_attachments;
			//       *(TextureHandle *)((char *)&v467.shadowResult.punctualLightShadowResult + 4) = (TextureHandle)v374.m_gbufferMapping;
			//       v467.cullingResults = v375;
			//       *(_OWORD *)&v467.bakedLightConfig = v376;
			//       *(ResourceHandle *)&v467.transparentAfterDistortionECSList = sceneColor_k__BackingField.handle;
			//       v378 = 0LL;
			//       v321 = *(DistortionPassConstructor **)&v3[1].fields._._._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m20;
			//       if ( !v321 )
			//         sub_1802DC2C8(0LL, v320);
			//       HG::Rendering::Runtime::DistortionPassConstructor::ConstructPass(
			//         v321,
			//         &v467,
			//         &v378,
			//         m_RenderGraph,
			//         *(HGCamera **)&v3[1].fields._._._.m_basicTransformConstants._ViewProjMatrix.m21,
			//         0LL);
			//       *(DistortionPassConstructor_PassOutput *)&v3[1].fields._._._.m_basicTransformConstants._InvViewProjMatrix.m23 = v378;
			//     }
			//     catch ( Il2CppExceptionWrapper *v407 )
			//     {
			//       renderContext.m_Ptr = v407.ex;
			//     }
			//     sub_1801E36C0(&renderContext);
			//   }
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

		private FoliageInteractivePassConstructor m_foliageInteractivePassConstructor;

		private SludgePassConstructor m_sludgePassConstructor;

		private GpuClothSimulationPassConstructor m_gpuClothSimulationPassConstructor;

		private ParticleLightingPassConstructor m_particleLightingPassConstructor;

		private LightClusteringPassConstructor m_lightClusteringPassConstructor;

		private GPUDrivenCullingPassConstructor m_cullingPassConstructor;

		private DepthOnlyPassConstructor m_depthOnlyPassConstructor;

		private ShadowMapPassConstructor m_shadowMapPassConstructor;

		private SkyAtmospherePassConstructor m_skyAtmospherePassConstructor;

		private VolumetricFogPassConstructor m_volumetricFogPassConstructor;

		private BakeFogLutPassConstructor m_bakeFogLutPassConstructor;

		private TerrainDeformPassConstructor m_terrainDeformPassConstructor;

		private TerrainVTBakePassConstructor m_terrainVTBakePassConstructor;

		private InkSimulationPassConstructor m_InkSimulationPassConstructor;

		private TerrainDepthPrepassConstructor m_terrainDepthPrepassConstructor;

		private DepthPrepassConstructor m_depthPrepassConstructor;

		private GBufferPassConstructor m_gBufferPassConstructor;

		private GPUParticleSimulationPassConstructor m_gpuParticleSimulationPassConstructor;

		private DecalPassConstructor m_decalPassConstructor;

		private WaterSectorRenderingPass m_waterSectorRenderingPassConstructor;

		private WaterInteractionRenderingPass m_waterInteractionRenderingPassConstructor;

		private WaterDefaultDeferredRenderingPass m_waterDefaultDeferredRenderingPassConstructor;

		private BuildHZBPass m_buildHZBPassConstructor;

		private DepthPyramidRenderingPass m_depthPyramidRenderingPassConstructor;

		private GTAOPassConstructor m_GTAOPassConstructor;

		private FakePlanarReflectionPass m_fakePlanarReflectionPassConstructor;

		private HyperScreenSpaceReflectionRenderingPass m_hyperScreenSpaceReflectionRenderingPassConstructor;

		private ContactShadowPassConstructor m_contactShadowPassConstructor;

		private CapsuleShadowPassConstructor m_capsuleShadowPassConstructor;

		private ScreenSpaceShadowMaskPassConstructor m_screenSpaceShadowMaskPassConstructor;

		private DeferredLightingPassConstructor m_deferredLightingPassConstructor;

		private ForwardOpaquePassConstructor m_forwardOpaquePassConstructor;

		private TransparentPassConstructor m_transparentPassConstructor;

		private VolumetricCloudPassConstructor m_volumetricCloudPassConstructor;

		private LightShaftPassConstructor m_lightShaftPassConstructor;

		private DistortionPassConstructor m_distortionPassConstructor;
	}
}
