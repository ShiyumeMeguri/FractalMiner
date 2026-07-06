using System;

namespace HG.Rendering.Runtime
{
	internal class PassConstructorFactory
	{
		public PassConstructorFactory()
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

		internal static IPassConstructor Create(HGRenderPipelineMaterialCollector materialCollector, PassConstructorID e, HGRenderPathBase.HGRenderPathResources resources)
		{
			// // IPassConstructor Create(HGRenderPipelineMaterialCollector, PassConstructorID, HGRenderPathBase+HGRenderPathResources)
			// IPassConstructor *HG::Rendering::Runtime::PassConstructorFactory::Create(
			//         HGRenderPipelineMaterialCollector *materialCollector,
			//         PassConstructorID__Enum e,
			//         HGRenderPathBase_HGRenderPathResources *resources,
			//         MethodInfo *method)
			// {
			//   IPassConstructor *result; // rax
			//   __int64 v8; // rdx
			//   HGRenderPipelineRuntimeResources *defaultResources; // rcx
			//   __int64 v10; // rbx
			//   HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
			//   Shader *uiImageBlurPS; // rdx
			//   HGRenderPathBase_HGRenderPathResources *v13; // rdx
			//   PassConstructorID__Enum__Array *v14; // r8
			//   HGCamera *v15; // r9
			//   UIPassConstructor *v16; // rax
			//   MultiblurPassConstructor *v17; // rax
			//   BinningPass *v18; // rax
			//   IPassConstructor *v19; // rbx
			//   ReflectionProbeBinningPassConstructor *v20; // rax
			//   IPassConstructor *v21; // rbx
			//   FoliageOccluderPassConstructor *v22; // rax
			//   IPassConstructor *v23; // rbx
			//   FoliageInteractivePassConstructor *v24; // rax
			//   IPassConstructor *v25; // rbx
			//   SludgePassConstructor *v26; // rax
			//   IPassConstructor *v27; // rbx
			//   GpuClothSimulationPassConstructor *v28; // rax
			//   IPassConstructor *v29; // rbx
			//   LightClusteringPassConstructor *v30; // rax
			//   IPassConstructor *v31; // rbx
			//   GPUParticleSimulationPassConstructor *v32; // rax
			//   IPassConstructor *v33; // rbx
			//   ParticleLightingPassConstructor *v34; // rax
			//   IPassConstructor *v35; // rbx
			//   DepthOnlyPassConstructor *v36; // rax
			//   IPassConstructor *v37; // rbx
			//   ShadowMapPassConstructor *v38; // rax
			//   IPassConstructor *v39; // rbx
			//   SkyAtmospherePassConstructor *v40; // rax
			//   IPassConstructor *v41; // rbx
			//   VolumetricFogPassConstructor *v42; // rax
			//   IPassConstructor *v43; // rbx
			//   VolumetricCloudPassConstructor *v44; // rax
			//   TerrainDeformPassConstructor *v45; // rax
			//   DecalPassConstructor *v46; // rax
			//   WaterSectorRenderingPass *v47; // rax
			//   WaterInteractionRenderingPass *v48; // rax
			//   WaterDefaultDeferredRenderingPass *v49; // rax
			//   BuildHZBPass *v50; // rax
			//   DepthPyramidRenderingPass *v51; // rax
			//   GTAOPassConstructor *v52; // rax
			//   FakePlanarReflectionPass *v53; // rax
			//   HyperScreenSpaceReflectionRenderingPass *v54; // rax
			//   ContactShadowPassConstructor *v55; // rax
			//   CapsuleShadowPassConstructor *v56; // rax
			//   ScreenSpaceShadowMaskPassConstructor *v57; // rax
			//   DeferredLightingPassConstructor *v58; // rax
			//   TransparentPassConstructor *v59; // rax
			//   ParafinPassConstructor *v60; // rax
			//   DepthOfFieldPassConstructor *v61; // rax
			//   MotionBlurPassConstructor *v62; // rax
			//   TAAUPassConstructor *v63; // rax
			//   LensFlarePassConstructor *v64; // rax
			//   PostProcessPassConstructor *v65; // rax
			//   UIPostProcessConstructor *v66; // rax
			//   WaterOnePassDeferredRenderingPass *v67; // rax
			//   OnePassDeferredPassConstructor *v68; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *v70; // [rsp+20h] [rbp-20h]
			//   MethodInfo *v71; // [rsp+28h] [rbp-18h]
			//   HGRenderPathBase_HGRenderPathResources v72; // [rsp+30h] [rbp-10h] BYREF
			// 
			//   if ( !byte_18D8EDB07 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::BakeFogLutPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::BinningPass);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::BuildHZBPass);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CapsuleShadowPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ContactShadowPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::DecalPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::DeferredLightingPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::DepthOnlyPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::DepthPrepassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::DepthPyramidRenderingPass);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::DistortionPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::FakePlanarReflectionPass);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::FoliageInteractivePassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ForwardOpaquePassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ForwardPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::GBufferPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::GPUDrivenCullingPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::GPUParticleSimulationPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::GTAOPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::InkSimulationPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::LensFlarePassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::LightClusteringPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::LightShaftApplyPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::LightShaftPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::MetalFXSpatialPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::MetalFXTemporalPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::MotionBlurPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::MultiblurPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ParafinPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ParticleLightingPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::PostProcessPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::SetFinalTargetPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ShadowMapPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::SkyAtmospherePassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::SludgePassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::TAAUPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::TerrainDeformPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::TerrainDepthPrepassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::TerrainVTBakePassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::TransparentAfterDOFPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::TransparentPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::UIImageBlurPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::UIPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::UIPostProcessConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricCloudPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricFogPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::WaterInteractionRenderingPass);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::WaterSectorRenderingPass);
			//     byte_18D8EDB07 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2954, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2954, 0LL);
			//     if ( !Patch )
			// LABEL_6:
			//       sub_180B536AC(defaultResources, v8);
			//     v72 = *resources;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1061(Patch, (Object *)materialCollector, e, &v72, 0LL);
			//   }
			//   else
			//   {
			//     switch ( e )
			//     {
			//       case PassConstructorID__Enum_UIImageBlur:
			//         v10 = sub_180004920(TypeInfo::HG::Rendering::Runtime::UIImageBlurPassConstructor);
			//         if ( !v10 )
			//           goto LABEL_6;
			//         if ( !resources.defaultResources )
			//           goto LABEL_6;
			//         shaders = resources.defaultResources.fields.shaders;
			//         if ( !shaders || !materialCollector )
			//           goto LABEL_6;
			//         uiImageBlurPS = shaders.fields.uiImageBlurPS;
			//         goto LABEL_12;
			//       case PassConstructorID__Enum_BinningPass:
			//         v18 = (BinningPass *)sub_180004920(TypeInfo::HG::Rendering::Runtime::BinningPass);
			//         v19 = (IPassConstructor *)v18;
			//         if ( !v18 )
			//           goto LABEL_6;
			//         HG::Rendering::Runtime::BinningPass::BinningPass(v18, 0LL);
			//         return v19;
			//       case PassConstructorID__Enum_ReflectionProbeBinning:
			//         v20 = (ReflectionProbeBinningPassConstructor *)sub_180004920(TypeInfo::HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor);
			//         v21 = (IPassConstructor *)v20;
			//         if ( !v20 )
			//           goto LABEL_6;
			//         HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::ReflectionProbeBinningPassConstructor(v20, 0LL);
			//         return v21;
			//       case PassConstructorID__Enum_FoliageOccluder:
			//         v22 = (FoliageOccluderPassConstructor *)sub_180004920(TypeInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor);
			//         v23 = (IPassConstructor *)v22;
			//         if ( !v22 )
			//           goto LABEL_6;
			//         v72 = *resources;
			//         HG::Rendering::Runtime::FoliageOccluderPassConstructor::FoliageOccluderPassConstructor(
			//           v22,
			//           materialCollector,
			//           &v72,
			//           0LL);
			//         return v23;
			//       case PassConstructorID__Enum_FoliageInteractive:
			//         v24 = (FoliageInteractivePassConstructor *)sub_180004920(TypeInfo::HG::Rendering::Runtime::FoliageInteractivePassConstructor);
			//         v25 = (IPassConstructor *)v24;
			//         if ( !v24 )
			//           goto LABEL_6;
			//         v72 = *resources;
			//         HG::Rendering::Runtime::FoliageInteractivePassConstructor::FoliageInteractivePassConstructor(
			//           v24,
			//           materialCollector,
			//           &v72,
			//           0LL);
			//         return v25;
			//       case PassConstructorID__Enum_Sludge:
			//         v26 = (SludgePassConstructor *)sub_180004920(TypeInfo::HG::Rendering::Runtime::SludgePassConstructor);
			//         v27 = (IPassConstructor *)v26;
			//         if ( !v26 )
			//           goto LABEL_6;
			//         v72 = *resources;
			//         HG::Rendering::Runtime::SludgePassConstructor::SludgePassConstructor(v26, &v72, 0LL);
			//         return v27;
			//       case PassConstructorID__Enum_GpuClothSimulation:
			//         v28 = (GpuClothSimulationPassConstructor *)sub_180004920(TypeInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor);
			//         v29 = (IPassConstructor *)v28;
			//         if ( !v28 )
			//           goto LABEL_6;
			//         v72 = *resources;
			//         HG::Rendering::Runtime::GpuClothSimulationPassConstructor::GpuClothSimulationPassConstructor(v28, &v72, 0LL);
			//         return v29;
			//       case PassConstructorID__Enum_LightClustering:
			//         v30 = (LightClusteringPassConstructor *)sub_180004920(TypeInfo::HG::Rendering::Runtime::LightClusteringPassConstructor);
			//         v31 = (IPassConstructor *)v30;
			//         if ( !v30 )
			//           goto LABEL_6;
			//         HG::Rendering::Runtime::LightClusteringPassConstructor::LightClusteringPassConstructor(v30, 0LL);
			//         return v31;
			//       case PassConstructorID__Enum_GPUDrivenCulling:
			//         result = (IPassConstructor *)sub_180004920(TypeInfo::HG::Rendering::Runtime::GPUDrivenCullingPassConstructor);
			//         if ( !result )
			//           goto LABEL_6;
			//         return result;
			//       case PassConstructorID__Enum_GPUParticleSimulation:
			//         v32 = (GPUParticleSimulationPassConstructor *)sub_180004920(TypeInfo::HG::Rendering::Runtime::GPUParticleSimulationPassConstructor);
			//         v33 = (IPassConstructor *)v32;
			//         if ( !v32 )
			//           goto LABEL_6;
			//         v72 = *resources;
			//         HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::GPUParticleSimulationPassConstructor(
			//           v32,
			//           &v72,
			//           0LL);
			//         return v33;
			//       case PassConstructorID__Enum_ParticleLighting:
			//         v34 = (ParticleLightingPassConstructor *)sub_180004920(TypeInfo::HG::Rendering::Runtime::ParticleLightingPassConstructor);
			//         v35 = (IPassConstructor *)v34;
			//         if ( !v34 )
			//           goto LABEL_6;
			//         v72 = *resources;
			//         HG::Rendering::Runtime::ParticleLightingPassConstructor::ParticleLightingPassConstructor(v34, &v72, 0LL);
			//         return v35;
			//       case PassConstructorID__Enum_CustomDepthOnly:
			//         v36 = (DepthOnlyPassConstructor *)sub_180004920(TypeInfo::HG::Rendering::Runtime::DepthOnlyPassConstructor);
			//         v37 = (IPassConstructor *)v36;
			//         if ( !v36 )
			//           goto LABEL_6;
			//         v72 = *resources;
			//         HG::Rendering::Runtime::DepthOnlyPassConstructor::DepthOnlyPassConstructor(v36, materialCollector, &v72, 0LL);
			//         return v37;
			//       case PassConstructorID__Enum_ShadowMap:
			//         v38 = (ShadowMapPassConstructor *)sub_180004920(TypeInfo::HG::Rendering::Runtime::ShadowMapPassConstructor);
			//         v39 = (IPassConstructor *)v38;
			//         if ( !v38 )
			//           goto LABEL_6;
			//         HG::Rendering::Runtime::ShadowMapPassConstructor::ShadowMapPassConstructor(v38, 0LL);
			//         return v39;
			//       case PassConstructorID__Enum_Atmosphere:
			//         v40 = (SkyAtmospherePassConstructor *)sub_180004920(TypeInfo::HG::Rendering::Runtime::SkyAtmospherePassConstructor);
			//         v41 = (IPassConstructor *)v40;
			//         if ( !v40 )
			//           goto LABEL_6;
			//         v72 = *resources;
			//         HG::Rendering::Runtime::SkyAtmospherePassConstructor::SkyAtmospherePassConstructor(
			//           v40,
			//           materialCollector,
			//           &v72,
			//           0LL);
			//         return v41;
			//       case PassConstructorID__Enum_VolumetricFog:
			//         v42 = (VolumetricFogPassConstructor *)sub_180004920(TypeInfo::HG::Rendering::Runtime::VolumetricFogPassConstructor);
			//         v43 = (IPassConstructor *)v42;
			//         if ( !v42 )
			//           goto LABEL_6;
			//         v72 = *resources;
			//         HG::Rendering::Runtime::VolumetricFogPassConstructor::VolumetricFogPassConstructor(v42, &v72, 0LL);
			//         return v43;
			//       case PassConstructorID__Enum_BakeFogLut:
			//         v10 = sub_180004920(TypeInfo::HG::Rendering::Runtime::BakeFogLutPassConstructor);
			//         if ( !v10 )
			//           goto LABEL_6;
			//         defaultResources = resources.defaultResources;
			//         if ( !resources.defaultResources )
			//           goto LABEL_6;
			//         defaultResources = (HGRenderPipelineRuntimeResources *)defaultResources.fields.shaders;
			//         if ( !defaultResources || !materialCollector )
			//           goto LABEL_6;
			//         uiImageBlurPS = (Shader *)defaultResources[8].fields.materials;
			//         goto LABEL_12;
			//       case PassConstructorID__Enum_VolumetricCloud:
			//         v44 = (VolumetricCloudPassConstructor *)sub_180004920(TypeInfo::HG::Rendering::Runtime::VolumetricCloudPassConstructor);
			//         v10 = (__int64)v44;
			//         if ( !v44 )
			//           goto LABEL_6;
			//         v72 = *resources;
			//         HG::Rendering::Runtime::VolumetricCloudPassConstructor::VolumetricCloudPassConstructor(
			//           v44,
			//           materialCollector,
			//           &v72,
			//           0LL);
			//         goto LABEL_13;
			//       case PassConstructorID__Enum_TerrainDeform:
			//         v45 = (TerrainDeformPassConstructor *)sub_180004920(TypeInfo::HG::Rendering::Runtime::TerrainDeformPassConstructor);
			//         v10 = (__int64)v45;
			//         if ( !v45 )
			//           goto LABEL_6;
			//         v72 = *resources;
			//         HG::Rendering::Runtime::TerrainDeformPassConstructor::TerrainDeformPassConstructor(
			//           v45,
			//           materialCollector,
			//           &v72,
			//           0LL);
			//         goto LABEL_13;
			//       case PassConstructorID__Enum_TerrainVTBake:
			//         result = (IPassConstructor *)sub_180004920(TypeInfo::HG::Rendering::Runtime::TerrainVTBakePassConstructor);
			//         if ( !result )
			//           goto LABEL_6;
			//         return result;
			//       case PassConstructorID__Enum_InkSimulation:
			//         result = (IPassConstructor *)sub_180004920(TypeInfo::HG::Rendering::Runtime::InkSimulationPassConstructor);
			//         if ( !result )
			//           goto LABEL_6;
			//         return result;
			//       case PassConstructorID__Enum_TerrainDepthPrepass:
			//         result = (IPassConstructor *)sub_180004920(TypeInfo::HG::Rendering::Runtime::TerrainDepthPrepassConstructor);
			//         if ( !result )
			//           goto LABEL_6;
			//         return result;
			//       case PassConstructorID__Enum_DepthPrepass:
			//         result = (IPassConstructor *)sub_180004920(TypeInfo::HG::Rendering::Runtime::DepthPrepassConstructor);
			//         if ( !result )
			//           goto LABEL_6;
			//         return result;
			//       case PassConstructorID__Enum_Forward:
			//         result = (IPassConstructor *)sub_180004920(TypeInfo::HG::Rendering::Runtime::ForwardPassConstructor);
			//         if ( result )
			//           return result;
			//         goto LABEL_6;
			//       case PassConstructorID__Enum_ForwardOpaque:
			//         result = (IPassConstructor *)sub_180004920(TypeInfo::HG::Rendering::Runtime::ForwardOpaquePassConstructor);
			//         if ( !result )
			//           goto LABEL_6;
			//         return result;
			//       case PassConstructorID__Enum_GBuffer:
			//         result = (IPassConstructor *)sub_180004920(TypeInfo::HG::Rendering::Runtime::GBufferPassConstructor);
			//         if ( !result )
			//           goto LABEL_6;
			//         return result;
			//       case PassConstructorID__Enum_Decal:
			//         v46 = (DecalPassConstructor *)sub_180004920(TypeInfo::HG::Rendering::Runtime::DecalPassConstructor);
			//         v10 = (__int64)v46;
			//         if ( !v46 )
			//           goto LABEL_6;
			//         v72 = *resources;
			//         HG::Rendering::Runtime::DecalPassConstructor::DecalPassConstructor(v46, materialCollector, &v72, 0LL);
			//         goto LABEL_13;
			//       case PassConstructorID__Enum_WaterSector:
			//         v47 = (WaterSectorRenderingPass *)sub_180004920(TypeInfo::HG::Rendering::Runtime::WaterSectorRenderingPass);
			//         v10 = (__int64)v47;
			//         if ( !v47 )
			//           goto LABEL_6;
			//         HG::Rendering::Runtime::WaterSectorRenderingPass::WaterSectorRenderingPass(v47, 0LL);
			//         goto LABEL_13;
			//       case PassConstructorID__Enum_WaterInteraction:
			//         v48 = (WaterInteractionRenderingPass *)sub_180004920(TypeInfo::HG::Rendering::Runtime::WaterInteractionRenderingPass);
			//         v10 = (__int64)v48;
			//         if ( !v48 )
			//           goto LABEL_6;
			//         v72 = *resources;
			//         HG::Rendering::Runtime::WaterInteractionRenderingPass::WaterInteractionRenderingPass(
			//           v48,
			//           materialCollector,
			//           &v72,
			//           0LL);
			//         goto LABEL_13;
			//       case PassConstructorID__Enum_WaterDefaultDeferred:
			//         v49 = (WaterDefaultDeferredRenderingPass *)sub_180004920(TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass);
			//         v10 = (__int64)v49;
			//         if ( !v49 )
			//           goto LABEL_6;
			//         v72 = *resources;
			//         HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::WaterDefaultDeferredRenderingPass(
			//           v49,
			//           materialCollector,
			//           &v72,
			//           0LL);
			//         goto LABEL_13;
			//       case PassConstructorID__Enum_WaterOnePassDeferred:
			//         v67 = (WaterOnePassDeferredRenderingPass *)sub_180004920(TypeInfo::HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass);
			//         v10 = (__int64)v67;
			//         if ( !v67 )
			//           goto LABEL_6;
			//         v72 = *resources;
			//         HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::WaterOnePassDeferredRenderingPass(
			//           v67,
			//           materialCollector,
			//           &v72,
			//           0LL);
			//         goto LABEL_13;
			//       case PassConstructorID__Enum_HZB:
			//         v50 = (BuildHZBPass *)sub_180004920(TypeInfo::HG::Rendering::Runtime::BuildHZBPass);
			//         v10 = (__int64)v50;
			//         if ( !v50 )
			//           goto LABEL_6;
			//         v72 = *resources;
			//         HG::Rendering::Runtime::BuildHZBPass::BuildHZBPass(v50, &v72, 0LL);
			//         goto LABEL_13;
			//       case PassConstructorID__Enum_DepthPyramid:
			//         v51 = (DepthPyramidRenderingPass *)sub_180004920(TypeInfo::HG::Rendering::Runtime::DepthPyramidRenderingPass);
			//         v10 = (__int64)v51;
			//         if ( !v51 )
			//           goto LABEL_6;
			//         v72 = *resources;
			//         HG::Rendering::Runtime::DepthPyramidRenderingPass::DepthPyramidRenderingPass(v51, &v72, 0LL);
			//         goto LABEL_13;
			//       case PassConstructorID__Enum_GTAO:
			//         v52 = (GTAOPassConstructor *)sub_180004920(TypeInfo::HG::Rendering::Runtime::GTAOPassConstructor);
			//         v10 = (__int64)v52;
			//         if ( !v52 )
			//           goto LABEL_6;
			//         v72 = *resources;
			//         HG::Rendering::Runtime::GTAOPassConstructor::GTAOPassConstructor(v52, &v72, 0LL);
			//         goto LABEL_13;
			//       case PassConstructorID__Enum_FakePlanarReflection:
			//         v53 = (FakePlanarReflectionPass *)sub_180004920(TypeInfo::HG::Rendering::Runtime::FakePlanarReflectionPass);
			//         v10 = (__int64)v53;
			//         if ( !v53 )
			//           goto LABEL_6;
			//         v72 = *resources;
			//         HG::Rendering::Runtime::FakePlanarReflectionPass::FakePlanarReflectionPass(v53, materialCollector, &v72, 0LL);
			//         goto LABEL_13;
			//       case PassConstructorID__Enum_HyperScreenSpaceReflection:
			//         v54 = (HyperScreenSpaceReflectionRenderingPass *)sub_180004920(TypeInfo::HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass);
			//         v10 = (__int64)v54;
			//         if ( !v54 )
			//           goto LABEL_6;
			//         v72 = *resources;
			//         HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::HyperScreenSpaceReflectionRenderingPass(
			//           v54,
			//           materialCollector,
			//           &v72,
			//           0LL);
			//         goto LABEL_13;
			//       case PassConstructorID__Enum_ContactShadow:
			//         v55 = (ContactShadowPassConstructor *)sub_180004920(TypeInfo::HG::Rendering::Runtime::ContactShadowPassConstructor);
			//         v10 = (__int64)v55;
			//         if ( !v55 )
			//           goto LABEL_6;
			//         v72 = *resources;
			//         HG::Rendering::Runtime::ContactShadowPassConstructor::ContactShadowPassConstructor(v55, &v72, 0LL);
			//         goto LABEL_13;
			//       case PassConstructorID__Enum_CapsuleShadow:
			//         v56 = (CapsuleShadowPassConstructor *)sub_180004920(TypeInfo::HG::Rendering::Runtime::CapsuleShadowPassConstructor);
			//         v10 = (__int64)v56;
			//         if ( !v56 )
			//           goto LABEL_6;
			//         v72 = *resources;
			//         HG::Rendering::Runtime::CapsuleShadowPassConstructor::CapsuleShadowPassConstructor(
			//           v56,
			//           materialCollector,
			//           &v72,
			//           0LL);
			//         goto LABEL_13;
			//       case PassConstructorID__Enum_ScreenSpaceShadowMask:
			//         v57 = (ScreenSpaceShadowMaskPassConstructor *)sub_180004920(TypeInfo::HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor);
			//         v10 = (__int64)v57;
			//         if ( !v57 )
			//           goto LABEL_6;
			//         v72 = *resources;
			//         HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor::ScreenSpaceShadowMaskPassConstructor(
			//           v57,
			//           materialCollector,
			//           &v72,
			//           0LL);
			//         goto LABEL_13;
			//       case PassConstructorID__Enum_DeferredLighting:
			//         v58 = (DeferredLightingPassConstructor *)sub_180004920(TypeInfo::HG::Rendering::Runtime::DeferredLightingPassConstructor);
			//         v10 = (__int64)v58;
			//         if ( !v58 )
			//           goto LABEL_6;
			//         v72 = *resources;
			//         HG::Rendering::Runtime::DeferredLightingPassConstructor::DeferredLightingPassConstructor(
			//           v58,
			//           materialCollector,
			//           &v72,
			//           0LL);
			//         goto LABEL_13;
			//       case PassConstructorID__Enum_Transparent:
			//         v59 = (TransparentPassConstructor *)sub_180004920(TypeInfo::HG::Rendering::Runtime::TransparentPassConstructor);
			//         v10 = (__int64)v59;
			//         if ( !v59 )
			//           goto LABEL_6;
			//         v72 = *resources;
			//         HG::Rendering::Runtime::TransparentPassConstructor::TransparentPassConstructor(
			//           v59,
			//           materialCollector,
			//           &v72,
			//           0LL);
			//         goto LABEL_13;
			//       case PassConstructorID__Enum_OnePassDeferred:
			//         v68 = (OnePassDeferredPassConstructor *)sub_180004920(TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor);
			//         v10 = (__int64)v68;
			//         if ( !v68 )
			//           goto LABEL_6;
			//         v72 = *resources;
			//         HG::Rendering::Runtime::OnePassDeferredPassConstructor::OnePassDeferredPassConstructor(
			//           v68,
			//           materialCollector,
			//           &v72,
			//           0LL);
			//         goto LABEL_13;
			//       case PassConstructorID__Enum_Distortion:
			//         result = (IPassConstructor *)sub_180004920(TypeInfo::HG::Rendering::Runtime::DistortionPassConstructor);
			//         if ( !result )
			//           goto LABEL_6;
			//         return result;
			//       case PassConstructorID__Enum_LightShaft:
			//         v10 = sub_180004920(TypeInfo::HG::Rendering::Runtime::LightShaftPassConstructor);
			//         if ( !v10 )
			//           goto LABEL_6;
			//         defaultResources = resources.defaultResources;
			//         if ( !resources.defaultResources )
			//           goto LABEL_6;
			//         defaultResources = (HGRenderPipelineRuntimeResources *)defaultResources.fields.shaders;
			//         if ( !defaultResources || !materialCollector )
			//           goto LABEL_6;
			//         uiImageBlurPS = *(Shader **)&defaultResources[12].fields.m_Version;
			//         goto LABEL_12;
			//       case PassConstructorID__Enum_LightShaftApply:
			//         v10 = sub_180004920(TypeInfo::HG::Rendering::Runtime::LightShaftApplyPassConstructor);
			//         if ( !v10 )
			//           goto LABEL_6;
			//         defaultResources = resources.defaultResources;
			//         if ( !resources.defaultResources )
			//           goto LABEL_6;
			//         defaultResources = (HGRenderPipelineRuntimeResources *)defaultResources.fields.shaders;
			//         if ( !defaultResources || !materialCollector )
			//           goto LABEL_6;
			//         uiImageBlurPS = *(Shader **)&defaultResources[12].fields.m_Version;
			//         goto LABEL_12;
			//       case PassConstructorID__Enum_Parafin:
			//         v60 = (ParafinPassConstructor *)sub_180004920(TypeInfo::HG::Rendering::Runtime::ParafinPassConstructor);
			//         v10 = (__int64)v60;
			//         if ( !v60 )
			//           goto LABEL_6;
			//         v72 = *resources;
			//         HG::Rendering::Runtime::ParafinPassConstructor::ParafinPassConstructor(v60, &v72, 0LL);
			//         goto LABEL_13;
			//       case PassConstructorID__Enum_DepthOfField:
			//         v61 = (DepthOfFieldPassConstructor *)sub_180004920(TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor);
			//         v10 = (__int64)v61;
			//         if ( !v61 )
			//           goto LABEL_6;
			//         v72 = *resources;
			//         HG::Rendering::Runtime::DepthOfFieldPassConstructor::DepthOfFieldPassConstructor(
			//           v61,
			//           materialCollector,
			//           &v72,
			//           0LL);
			//         goto LABEL_13;
			//       case PassConstructorID__Enum_MotionBlur:
			//         v62 = (MotionBlurPassConstructor *)sub_180004920(TypeInfo::HG::Rendering::Runtime::MotionBlurPassConstructor);
			//         v10 = (__int64)v62;
			//         if ( !v62 )
			//           goto LABEL_6;
			//         v72 = *resources;
			//         HG::Rendering::Runtime::MotionBlurPassConstructor::MotionBlurPassConstructor(v62, &v72, 0LL);
			//         goto LABEL_13;
			//       case PassConstructorID__Enum_TransparentAfterDOF:
			//         result = (IPassConstructor *)sub_180004920(TypeInfo::HG::Rendering::Runtime::TransparentAfterDOFPassConstructor);
			//         if ( !result )
			//           goto LABEL_6;
			//         return result;
			//       case PassConstructorID__Enum_TAAU:
			//         v63 = (TAAUPassConstructor *)sub_180004920(TypeInfo::HG::Rendering::Runtime::TAAUPassConstructor);
			//         v10 = (__int64)v63;
			//         if ( !v63 )
			//           goto LABEL_6;
			//         v72 = *resources;
			//         HG::Rendering::Runtime::TAAUPassConstructor::TAAUPassConstructor(v63, materialCollector, &v72, 0LL);
			//         goto LABEL_13;
			//       case PassConstructorID__Enum_MetalFXTemporal:
			//         result = (IPassConstructor *)sub_180004920(TypeInfo::HG::Rendering::Runtime::MetalFXTemporalPassConstructor);
			//         if ( !result )
			//           goto LABEL_6;
			//         return result;
			//       case PassConstructorID__Enum_LensFlare:
			//         v64 = (LensFlarePassConstructor *)sub_180004920(TypeInfo::HG::Rendering::Runtime::LensFlarePassConstructor);
			//         v10 = (__int64)v64;
			//         if ( !v64 )
			//           goto LABEL_6;
			//         v72 = *resources;
			//         HG::Rendering::Runtime::LensFlarePassConstructor::LensFlarePassConstructor(v64, materialCollector, &v72, 0LL);
			//         goto LABEL_13;
			//       case PassConstructorID__Enum_UberPost:
			//         v65 = (PostProcessPassConstructor *)sub_180004920(TypeInfo::HG::Rendering::Runtime::PostProcessPassConstructor);
			//         v10 = (__int64)v65;
			//         if ( !v65 )
			//           goto LABEL_6;
			//         v72 = *resources;
			//         HG::Rendering::Runtime::PostProcessPassConstructor::PostProcessPassConstructor(
			//           v65,
			//           materialCollector,
			//           &v72,
			//           0LL);
			//         goto LABEL_13;
			//       case PassConstructorID__Enum_MetalFXSpatial:
			//         result = (IPassConstructor *)sub_180004920(TypeInfo::HG::Rendering::Runtime::MetalFXSpatialPassConstructor);
			//         if ( !result )
			//           goto LABEL_6;
			//         return result;
			//       case PassConstructorID__Enum_UIPP:
			//         v66 = (UIPostProcessConstructor *)sub_180004920(TypeInfo::HG::Rendering::Runtime::UIPostProcessConstructor);
			//         v10 = (__int64)v66;
			//         if ( !v66 )
			//           goto LABEL_6;
			//         v72 = *resources;
			//         HG::Rendering::Runtime::UIPostProcessConstructor::UIPostProcessConstructor(v66, materialCollector, &v72, 0LL);
			//         goto LABEL_13;
			//       case PassConstructorID__Enum_UI:
			//         v16 = (UIPassConstructor *)sub_180004920(TypeInfo::HG::Rendering::Runtime::UIPassConstructor);
			//         v10 = (__int64)v16;
			//         if ( !v16 )
			//           goto LABEL_6;
			//         HG::Rendering::Runtime::UIPassConstructor::UIPassConstructor(v16, 0LL);
			//         goto LABEL_13;
			//       case PassConstructorID__Enum_Multiblur:
			//         v17 = (MultiblurPassConstructor *)sub_180004920(TypeInfo::HG::Rendering::Runtime::MultiblurPassConstructor);
			//         v10 = (__int64)v17;
			//         if ( !v17 )
			//           goto LABEL_6;
			//         v72 = *resources;
			//         HG::Rendering::Runtime::MultiblurPassConstructor::MultiblurPassConstructor(v17, materialCollector, &v72, 0LL);
			//         goto LABEL_13;
			//       case PassConstructorID__Enum_ScreenSpaceOverlay:
			//         result = (IPassConstructor *)sub_180004920(TypeInfo::HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor);
			//         if ( !result )
			//           goto LABEL_6;
			//         return result;
			//       case PassConstructorID__Enum_SetFinalTarget:
			//         v10 = sub_180004920(TypeInfo::HG::Rendering::Runtime::SetFinalTargetPassConstructor);
			//         if ( !v10 )
			//           goto LABEL_6;
			//         defaultResources = resources.defaultResources;
			//         if ( !resources.defaultResources )
			//           goto LABEL_6;
			//         defaultResources = (HGRenderPipelineRuntimeResources *)defaultResources.fields.shaders;
			//         if ( !defaultResources || !materialCollector )
			//           goto LABEL_6;
			//         uiImageBlurPS = (Shader *)defaultResources[4].fields.textures;
			// LABEL_12:
			//         *(_QWORD *)(v10 + 16) = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
			//                                   materialCollector,
			//                                   uiImageBlurPS,
			//                                   0,
			//                                   0LL);
			//         sub_1800054D0((HGRenderPathScene *)(v10 + 16), v13, v14, v15, v70, v71);
			// LABEL_13:
			//         result = (IPassConstructor *)v10;
			//         break;
			//       default:
			//         return 0LL;
			//     }
			//   }
			//   return result;
			// }
			// 
			return null;
		}
	}
}
