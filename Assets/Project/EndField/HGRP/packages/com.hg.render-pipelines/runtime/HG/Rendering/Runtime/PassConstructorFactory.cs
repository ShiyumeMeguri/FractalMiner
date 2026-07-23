using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class PassConstructorFactory // TypeDefIndex: 38512
	{
		// Constructors
		public PassConstructorFactory() {} // 0x00000001841E1670-0x00000001841E1680
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
		
	
		// Methods
		internal static IPassConstructor Create(HGRenderPipelineMaterialCollector materialCollector, PassConstructorID e, HGRenderPathBase.HGRenderPathResources resources) => default; // 0x0000000183B94D60-0x0000000183B95960
		// IPassConstructor Create(HGRenderPipelineMaterialCollector, PassConstructorID, HGRenderPathBase+HGRenderPathResources)
		IPassConstructor *HG::Rendering::Runtime::PassConstructorFactory::Create(
		        HGRenderPipelineMaterialCollector *materialCollector,
		        PassConstructorID__Enum e,
		        HGRenderPathBase_HGRenderPathResources *resources,
		        MethodInfo *method)
		{
		  IPassConstructor *result; // rax
		  __int64 v8; // rdx
		  HGRenderPipelineRuntimeResources *defaultResources; // rcx
		  __int64 v10; // rbx
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
		  Shader *uiImageBlurPS; // rdx
		  HGRuntimeGrassQuery_Node *v13; // rdx
		  HGRuntimeGrassQuery_Node *v14; // r8
		  Int32__Array **v15; // r9
		  UIPassConstructor *v16; // rax
		  __int64 v17; // rbx
		  HGRenderPathBase_HGRenderPathResources v18; // xmm0
		  bool v19; // zf
		  BinningPass *v20; // rax
		  IPassConstructor *v21; // rbx
		  ReflectionProbeBinningPassConstructor *v22; // rax
		  IPassConstructor *v23; // rbx
		  FoliageOccluderPassConstructor *v24; // rax
		  IPassConstructor *v25; // rbx
		  FoliageInteractivePassConstructor *v26; // rax
		  IPassConstructor *v27; // rbx
		  SludgePassConstructor *v28; // rax
		  IPassConstructor *v29; // rbx
		  GpuClothSimulationPassConstructor *v30; // rax
		  IPassConstructor *v31; // rbx
		  LightClusteringPassConstructor *v32; // rax
		  IPassConstructor *v33; // rbx
		  GPUParticleSimulationPassConstructor *v34; // rax
		  IPassConstructor *v35; // rbx
		  ParticleLightingPassConstructor *v36; // rax
		  IPassConstructor *v37; // rbx
		  DepthOnlyPassConstructor *v38; // rax
		  IPassConstructor *v39; // rbx
		  ShadowMapPassConstructor *v40; // rax
		  IPassConstructor *v41; // rbx
		  SkyAtmospherePassConstructor *v42; // rax
		  IPassConstructor *v43; // rbx
		  VolumetricFogPassConstructor *v44; // rax
		  IPassConstructor *v45; // rbx
		  VolumetricCloudPassConstructor *v46; // rax
		  TerrainDeformPassConstructor *v47; // rax
		  DecalPassConstructor *v48; // rax
		  WaterSectorRenderingPass *v49; // rax
		  WaterInteractionRenderingPass *v50; // rax
		  WaterDefaultDeferredRenderingPass *v51; // rax
		  BuildHZBPass *v52; // rax
		  DepthPyramidRenderingPass *v53; // rax
		  GTAOPassConstructor *v54; // rax
		  FakePlanarReflectionPass *v55; // rax
		  HyperScreenSpaceReflectionRenderingPass *v56; // rax
		  ContactShadowPassConstructor *v57; // rax
		  CapsuleShadowPassConstructor *v58; // rax
		  ScreenSpaceShadowMaskPassConstructor *v59; // rax
		  DeferredLightingPassConstructor *v60; // rax
		  Shader *v61; // rdi
		  ParafinPassConstructor *v62; // rax
		  DepthOfFieldPassConstructor *v63; // rax
		  MotionBlurPassConstructor *v64; // rax
		  TAAUPassConstructor *v65; // rax
		  LensFlarePassConstructor *v66; // rax
		  PostProcessPassConstructor *v67; // rax
		  UIPostProcessConstructor *v68; // rax
		  WaterOnePassDeferredRenderingPass *v69; // rax
		  OnePassDeferredPassConstructor *v70; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v72; // [rsp+20h] [rbp-20h]
		  HGRenderPathBase_HGRenderPathResources v73; // [rsp+30h] [rbp-10h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3550, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3550, 0LL);
		    if ( !Patch )
		LABEL_4:
		      sub_1800D8260(defaultResources, v8);
		    v73 = *resources;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1264(Patch, (Object *)materialCollector, e, &v73, 0LL);
		  }
		  else
		  {
		    switch ( e )
		    {
		      case PassConstructorID__Enum_UIImageBlur:
		        v10 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::UIImageBlurPassConstructor);
		        if ( !v10 )
		          goto LABEL_4;
		        if ( !resources->defaultResources )
		          goto LABEL_4;
		        shaders = resources->defaultResources->fields.shaders;
		        if ( !shaders || !materialCollector )
		          goto LABEL_4;
		        uiImageBlurPS = shaders->fields.uiImageBlurPS;
		        goto LABEL_10;
		      case PassConstructorID__Enum_BinningPass:
		        v20 = (BinningPass *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::BinningPass);
		        v21 = (IPassConstructor *)v20;
		        if ( !v20 )
		          goto LABEL_4;
		        HG::Rendering::Runtime::BinningPass::BinningPass(v20, 0LL);
		        return v21;
		      case PassConstructorID__Enum_ReflectionProbeBinning:
		        v22 = (ReflectionProbeBinningPassConstructor *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor);
		        v23 = (IPassConstructor *)v22;
		        if ( !v22 )
		          goto LABEL_4;
		        HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::ReflectionProbeBinningPassConstructor(v22, 0LL);
		        return v23;
		      case PassConstructorID__Enum_FoliageOccluder:
		        v24 = (FoliageOccluderPassConstructor *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor);
		        v25 = (IPassConstructor *)v24;
		        if ( !v24 )
		          goto LABEL_4;
		        v73 = *resources;
		        HG::Rendering::Runtime::FoliageOccluderPassConstructor::FoliageOccluderPassConstructor(
		          v24,
		          materialCollector,
		          &v73,
		          0LL);
		        return v25;
		      case PassConstructorID__Enum_FoliageInteractive:
		        v26 = (FoliageInteractivePassConstructor *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::FoliageInteractivePassConstructor);
		        v27 = (IPassConstructor *)v26;
		        if ( !v26 )
		          goto LABEL_4;
		        v73 = *resources;
		        HG::Rendering::Runtime::FoliageInteractivePassConstructor::FoliageInteractivePassConstructor(
		          v26,
		          materialCollector,
		          &v73,
		          0LL);
		        return v27;
		      case PassConstructorID__Enum_Sludge:
		        v28 = (SludgePassConstructor *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::SludgePassConstructor);
		        v29 = (IPassConstructor *)v28;
		        if ( !v28 )
		          goto LABEL_4;
		        v73 = *resources;
		        HG::Rendering::Runtime::SludgePassConstructor::SludgePassConstructor(v28, &v73, 0LL);
		        return v29;
		      case PassConstructorID__Enum_GpuClothSimulation:
		        v30 = (GpuClothSimulationPassConstructor *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor);
		        v31 = (IPassConstructor *)v30;
		        if ( !v30 )
		          goto LABEL_4;
		        v73 = *resources;
		        HG::Rendering::Runtime::GpuClothSimulationPassConstructor::GpuClothSimulationPassConstructor(v30, &v73, 0LL);
		        return v31;
		      case PassConstructorID__Enum_LightClustering:
		        v32 = (LightClusteringPassConstructor *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::LightClusteringPassConstructor);
		        v33 = (IPassConstructor *)v32;
		        if ( !v32 )
		          goto LABEL_4;
		        HG::Rendering::Runtime::LightClusteringPassConstructor::LightClusteringPassConstructor(v32, 0LL);
		        return v33;
		      case PassConstructorID__Enum_GPUDrivenCulling:
		        result = (IPassConstructor *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::GPUDrivenCullingPassConstructor);
		        if ( result )
		          return result;
		        goto LABEL_4;
		      case PassConstructorID__Enum_GPUParticleSimulation:
		        v34 = (GPUParticleSimulationPassConstructor *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::GPUParticleSimulationPassConstructor);
		        v35 = (IPassConstructor *)v34;
		        if ( !v34 )
		          goto LABEL_4;
		        v73 = *resources;
		        HG::Rendering::Runtime::GPUParticleSimulationPassConstructor::GPUParticleSimulationPassConstructor(
		          v34,
		          &v73,
		          0LL);
		        return v35;
		      case PassConstructorID__Enum_ParticleLighting:
		        v36 = (ParticleLightingPassConstructor *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::ParticleLightingPassConstructor);
		        v37 = (IPassConstructor *)v36;
		        if ( !v36 )
		          goto LABEL_4;
		        v73 = *resources;
		        HG::Rendering::Runtime::ParticleLightingPassConstructor::ParticleLightingPassConstructor(v36, &v73, 0LL);
		        return v37;
		      case PassConstructorID__Enum_CustomDepthOnly:
		        v38 = (DepthOnlyPassConstructor *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::DepthOnlyPassConstructor);
		        v39 = (IPassConstructor *)v38;
		        if ( !v38 )
		          goto LABEL_4;
		        v73 = *resources;
		        HG::Rendering::Runtime::DepthOnlyPassConstructor::DepthOnlyPassConstructor(v38, materialCollector, &v73, 0LL);
		        return v39;
		      case PassConstructorID__Enum_ShadowMap:
		        v40 = (ShadowMapPassConstructor *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::ShadowMapPassConstructor);
		        v41 = (IPassConstructor *)v40;
		        if ( !v40 )
		          goto LABEL_4;
		        HG::Rendering::Runtime::ShadowMapPassConstructor::ShadowMapPassConstructor(v40, 0LL);
		        return v41;
		      case PassConstructorID__Enum_Atmosphere:
		        v42 = (SkyAtmospherePassConstructor *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::SkyAtmospherePassConstructor);
		        v43 = (IPassConstructor *)v42;
		        if ( !v42 )
		          goto LABEL_4;
		        v73 = *resources;
		        HG::Rendering::Runtime::SkyAtmospherePassConstructor::SkyAtmospherePassConstructor(
		          v42,
		          materialCollector,
		          &v73,
		          0LL);
		        return v43;
		      case PassConstructorID__Enum_VolumetricFog:
		        v44 = (VolumetricFogPassConstructor *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::VolumetricFogPassConstructor);
		        v45 = (IPassConstructor *)v44;
		        if ( !v44 )
		          goto LABEL_4;
		        v73 = *resources;
		        HG::Rendering::Runtime::VolumetricFogPassConstructor::VolumetricFogPassConstructor(v44, &v73, 0LL);
		        return v45;
		      case PassConstructorID__Enum_BakeFogLut:
		        v10 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::BakeFogLutPassConstructor);
		        if ( !v10 )
		          goto LABEL_4;
		        defaultResources = resources->defaultResources;
		        if ( !resources->defaultResources )
		          goto LABEL_4;
		        defaultResources = (HGRenderPipelineRuntimeResources *)defaultResources->fields.shaders;
		        if ( !defaultResources || !materialCollector )
		          goto LABEL_4;
		        uiImageBlurPS = *(Shader **)&defaultResources[8].fields.m_Version;
		        goto LABEL_10;
		      case PassConstructorID__Enum_VolumetricCloud:
		        v46 = (VolumetricCloudPassConstructor *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::VolumetricCloudPassConstructor);
		        v10 = (__int64)v46;
		        if ( !v46 )
		          goto LABEL_4;
		        v73 = *resources;
		        HG::Rendering::Runtime::VolumetricCloudPassConstructor::VolumetricCloudPassConstructor(
		          v46,
		          materialCollector,
		          &v73,
		          0LL);
		        goto LABEL_11;
		      case PassConstructorID__Enum_TerrainDeform:
		        v47 = (TerrainDeformPassConstructor *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::TerrainDeformPassConstructor);
		        v10 = (__int64)v47;
		        if ( !v47 )
		          goto LABEL_4;
		        v73 = *resources;
		        HG::Rendering::Runtime::TerrainDeformPassConstructor::TerrainDeformPassConstructor(
		          v47,
		          materialCollector,
		          &v73,
		          0LL);
		        goto LABEL_11;
		      case PassConstructorID__Enum_TerrainVTBake:
		        result = (IPassConstructor *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::TerrainVTBakePassConstructor);
		        if ( result )
		          return result;
		        goto LABEL_4;
		      case PassConstructorID__Enum_InkSimulation:
		        result = (IPassConstructor *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::InkSimulationPassConstructor);
		        if ( result )
		          return result;
		        goto LABEL_4;
		      case PassConstructorID__Enum_TerrainDepthPrepass:
		        result = (IPassConstructor *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::TerrainDepthPrepassConstructor);
		        if ( result )
		          return result;
		        goto LABEL_4;
		      case PassConstructorID__Enum_DepthPrepass:
		        result = (IPassConstructor *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::DepthPrepassConstructor);
		        if ( result )
		          return result;
		        goto LABEL_4;
		      case PassConstructorID__Enum_Forward:
		        result = (IPassConstructor *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::ForwardPassConstructor);
		        if ( result )
		          return result;
		        goto LABEL_4;
		      case PassConstructorID__Enum_ForwardOpaque:
		        result = (IPassConstructor *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::ForwardOpaquePassConstructor);
		        if ( result )
		          return result;
		        goto LABEL_4;
		      case PassConstructorID__Enum_GBuffer:
		        result = (IPassConstructor *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::GBufferPassConstructor);
		        if ( result )
		          return result;
		        goto LABEL_4;
		      case PassConstructorID__Enum_Decal:
		        v48 = (DecalPassConstructor *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::DecalPassConstructor);
		        v10 = (__int64)v48;
		        if ( !v48 )
		          goto LABEL_4;
		        v73 = *resources;
		        HG::Rendering::Runtime::DecalPassConstructor::DecalPassConstructor(v48, materialCollector, &v73, 0LL);
		        goto LABEL_11;
		      case PassConstructorID__Enum_WaterSector:
		        v49 = (WaterSectorRenderingPass *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::WaterSectorRenderingPass);
		        v10 = (__int64)v49;
		        if ( !v49 )
		          goto LABEL_4;
		        HG::Rendering::Runtime::WaterSectorRenderingPass::WaterSectorRenderingPass(v49, 0LL);
		        goto LABEL_11;
		      case PassConstructorID__Enum_WaterInteraction:
		        v50 = (WaterInteractionRenderingPass *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::WaterInteractionRenderingPass);
		        v10 = (__int64)v50;
		        if ( !v50 )
		          goto LABEL_4;
		        v73 = *resources;
		        HG::Rendering::Runtime::WaterInteractionRenderingPass::WaterInteractionRenderingPass(
		          v50,
		          materialCollector,
		          &v73,
		          0LL);
		        goto LABEL_11;
		      case PassConstructorID__Enum_WaterDefaultDeferred:
		        v51 = (WaterDefaultDeferredRenderingPass *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass);
		        v10 = (__int64)v51;
		        if ( !v51 )
		          goto LABEL_4;
		        v73 = *resources;
		        HG::Rendering::Runtime::WaterDefaultDeferredRenderingPass::WaterDefaultDeferredRenderingPass(
		          v51,
		          materialCollector,
		          &v73,
		          0LL);
		        goto LABEL_11;
		      case PassConstructorID__Enum_WaterOnePassDeferred:
		        v69 = (WaterOnePassDeferredRenderingPass *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass);
		        v10 = (__int64)v69;
		        if ( !v69 )
		          goto LABEL_4;
		        v73 = *resources;
		        HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::WaterOnePassDeferredRenderingPass(
		          v69,
		          materialCollector,
		          &v73,
		          0LL);
		        goto LABEL_11;
		      case PassConstructorID__Enum_HZB:
		        v52 = (BuildHZBPass *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::BuildHZBPass);
		        v10 = (__int64)v52;
		        if ( !v52 )
		          goto LABEL_4;
		        v73 = *resources;
		        HG::Rendering::Runtime::BuildHZBPass::BuildHZBPass(v52, &v73, 0LL);
		        goto LABEL_11;
		      case PassConstructorID__Enum_DepthPyramid:
		        v53 = (DepthPyramidRenderingPass *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::DepthPyramidRenderingPass);
		        v10 = (__int64)v53;
		        if ( !v53 )
		          goto LABEL_4;
		        v73 = *resources;
		        HG::Rendering::Runtime::DepthPyramidRenderingPass::DepthPyramidRenderingPass(v53, &v73, 0LL);
		        goto LABEL_11;
		      case PassConstructorID__Enum_GTAO:
		        v54 = (GTAOPassConstructor *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::GTAOPassConstructor);
		        v10 = (__int64)v54;
		        if ( !v54 )
		          goto LABEL_4;
		        v73 = *resources;
		        HG::Rendering::Runtime::GTAOPassConstructor::GTAOPassConstructor(v54, &v73, 0LL);
		        goto LABEL_11;
		      case PassConstructorID__Enum_FakePlanarReflection:
		        v55 = (FakePlanarReflectionPass *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::FakePlanarReflectionPass);
		        v10 = (__int64)v55;
		        if ( !v55 )
		          goto LABEL_4;
		        v73 = *resources;
		        HG::Rendering::Runtime::FakePlanarReflectionPass::FakePlanarReflectionPass(v55, materialCollector, &v73, 0LL);
		        goto LABEL_11;
		      case PassConstructorID__Enum_HyperScreenSpaceReflection:
		        v56 = (HyperScreenSpaceReflectionRenderingPass *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass);
		        v10 = (__int64)v56;
		        if ( !v56 )
		          goto LABEL_4;
		        v73 = *resources;
		        HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::HyperScreenSpaceReflectionRenderingPass(
		          v56,
		          materialCollector,
		          &v73,
		          0LL);
		        goto LABEL_11;
		      case PassConstructorID__Enum_ContactShadow:
		        v57 = (ContactShadowPassConstructor *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::ContactShadowPassConstructor);
		        v10 = (__int64)v57;
		        if ( !v57 )
		          goto LABEL_4;
		        v73 = *resources;
		        HG::Rendering::Runtime::ContactShadowPassConstructor::ContactShadowPassConstructor(v57, &v73, 0LL);
		        goto LABEL_11;
		      case PassConstructorID__Enum_CapsuleShadow:
		        v58 = (CapsuleShadowPassConstructor *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::CapsuleShadowPassConstructor);
		        v10 = (__int64)v58;
		        if ( !v58 )
		          goto LABEL_4;
		        v73 = *resources;
		        HG::Rendering::Runtime::CapsuleShadowPassConstructor::CapsuleShadowPassConstructor(
		          v58,
		          materialCollector,
		          &v73,
		          0LL);
		        goto LABEL_11;
		      case PassConstructorID__Enum_ScreenSpaceShadowMask:
		        v59 = (ScreenSpaceShadowMaskPassConstructor *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor);
		        v10 = (__int64)v59;
		        if ( !v59 )
		          goto LABEL_4;
		        v73 = *resources;
		        HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor::ScreenSpaceShadowMaskPassConstructor(
		          v59,
		          materialCollector,
		          &v73,
		          0LL);
		        goto LABEL_11;
		      case PassConstructorID__Enum_DeferredLighting:
		        v60 = (DeferredLightingPassConstructor *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::DeferredLightingPassConstructor);
		        v10 = (__int64)v60;
		        if ( !v60 )
		          goto LABEL_4;
		        v73 = *resources;
		        HG::Rendering::Runtime::DeferredLightingPassConstructor::DeferredLightingPassConstructor(
		          v60,
		          materialCollector,
		          &v73,
		          0LL);
		        goto LABEL_11;
		      case PassConstructorID__Enum_Transparent:
		        v10 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::TransparentPassConstructor);
		        if ( !v10 )
		          goto LABEL_4;
		        defaultResources = resources->defaultResources;
		        if ( !resources->defaultResources )
		          goto LABEL_4;
		        defaultResources = (HGRenderPipelineRuntimeResources *)defaultResources->fields.shaders;
		        if ( !defaultResources )
		          goto LABEL_4;
		        v61 = *(Shader **)&defaultResources[12].fields.m_Version;
		        if ( !TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
		        HG::Rendering::Runtime::VFXPPScanLinePass::PrepareScanLineMaterial(v61, 0LL);
		        goto LABEL_11;
		      case PassConstructorID__Enum_OnePassDeferred:
		        v70 = (OnePassDeferredPassConstructor *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::OnePassDeferredPassConstructor);
		        v10 = (__int64)v70;
		        if ( !v70 )
		          goto LABEL_4;
		        v73 = *resources;
		        HG::Rendering::Runtime::OnePassDeferredPassConstructor::OnePassDeferredPassConstructor(
		          v70,
		          materialCollector,
		          &v73,
		          0LL);
		        goto LABEL_11;
		      case PassConstructorID__Enum_Distortion:
		        result = (IPassConstructor *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::DistortionPassConstructor);
		        if ( result )
		          return result;
		        goto LABEL_4;
		      case PassConstructorID__Enum_LightShaft:
		        v10 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::LightShaftPassConstructor);
		        if ( !v10 )
		          goto LABEL_4;
		        defaultResources = resources->defaultResources;
		        if ( !resources->defaultResources )
		          goto LABEL_4;
		        defaultResources = (HGRenderPipelineRuntimeResources *)defaultResources->fields.shaders;
		        if ( !defaultResources || !materialCollector )
		          goto LABEL_4;
		        uiImageBlurPS = (Shader *)defaultResources[13].fields.assets;
		        goto LABEL_10;
		      case PassConstructorID__Enum_LightShaftApply:
		        v10 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::LightShaftApplyPassConstructor);
		        if ( !v10 )
		          goto LABEL_4;
		        defaultResources = resources->defaultResources;
		        if ( !resources->defaultResources )
		          goto LABEL_4;
		        defaultResources = (HGRenderPipelineRuntimeResources *)defaultResources->fields.shaders;
		        if ( !defaultResources || !materialCollector )
		          goto LABEL_4;
		        uiImageBlurPS = (Shader *)defaultResources[13].fields.assets;
		        goto LABEL_10;
		      case PassConstructorID__Enum_Parafin:
		        v62 = (ParafinPassConstructor *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::ParafinPassConstructor);
		        v10 = (__int64)v62;
		        if ( !v62 )
		          goto LABEL_4;
		        v73 = *resources;
		        HG::Rendering::Runtime::ParafinPassConstructor::ParafinPassConstructor(v62, &v73, 0LL);
		        goto LABEL_11;
		      case PassConstructorID__Enum_DepthOfField:
		        v63 = (DepthOfFieldPassConstructor *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor);
		        v10 = (__int64)v63;
		        if ( !v63 )
		          goto LABEL_4;
		        v73 = *resources;
		        HG::Rendering::Runtime::DepthOfFieldPassConstructor::DepthOfFieldPassConstructor(
		          v63,
		          materialCollector,
		          &v73,
		          0LL);
		        goto LABEL_11;
		      case PassConstructorID__Enum_MotionBlur:
		        v64 = (MotionBlurPassConstructor *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::MotionBlurPassConstructor);
		        v10 = (__int64)v64;
		        if ( !v64 )
		          goto LABEL_4;
		        v73 = *resources;
		        HG::Rendering::Runtime::MotionBlurPassConstructor::MotionBlurPassConstructor(v64, &v73, 0LL);
		        goto LABEL_11;
		      case PassConstructorID__Enum_TransparentAfterDOF:
		        result = (IPassConstructor *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::TransparentAfterDOFPassConstructor);
		        if ( result )
		          return result;
		        goto LABEL_4;
		      case PassConstructorID__Enum_TAAU:
		        v65 = (TAAUPassConstructor *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::TAAUPassConstructor);
		        v10 = (__int64)v65;
		        if ( !v65 )
		          goto LABEL_4;
		        v73 = *resources;
		        HG::Rendering::Runtime::TAAUPassConstructor::TAAUPassConstructor(v65, materialCollector, &v73, 0LL);
		        goto LABEL_11;
		      case PassConstructorID__Enum_MetalFXTemporal:
		        result = (IPassConstructor *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::MetalFXTemporalPassConstructor);
		        if ( result )
		          return result;
		        goto LABEL_4;
		      case PassConstructorID__Enum_LensFlare:
		        v66 = (LensFlarePassConstructor *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::LensFlarePassConstructor);
		        v10 = (__int64)v66;
		        if ( !v66 )
		          goto LABEL_4;
		        v73 = *resources;
		        HG::Rendering::Runtime::LensFlarePassConstructor::LensFlarePassConstructor(v66, materialCollector, &v73, 0LL);
		        goto LABEL_11;
		      case PassConstructorID__Enum_UberPost:
		        v67 = (PostProcessPassConstructor *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::PostProcessPassConstructor);
		        v10 = (__int64)v67;
		        if ( !v67 )
		          goto LABEL_4;
		        v73 = *resources;
		        HG::Rendering::Runtime::PostProcessPassConstructor::PostProcessPassConstructor(
		          v67,
		          materialCollector,
		          &v73,
		          0LL);
		        goto LABEL_11;
		      case PassConstructorID__Enum_MetalFXSpatial:
		        result = (IPassConstructor *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::MetalFXSpatialPassConstructor);
		        if ( result )
		          return result;
		        goto LABEL_4;
		      case PassConstructorID__Enum_UIPP:
		        v68 = (UIPostProcessConstructor *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::UIPostProcessConstructor);
		        v10 = (__int64)v68;
		        if ( !v68 )
		          goto LABEL_4;
		        v73 = *resources;
		        HG::Rendering::Runtime::UIPostProcessConstructor::UIPostProcessConstructor(v68, materialCollector, &v73, 0LL);
		        goto LABEL_11;
		      case PassConstructorID__Enum_UI:
		        v16 = (UIPassConstructor *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::UIPassConstructor);
		        v10 = (__int64)v16;
		        if ( !v16 )
		          goto LABEL_4;
		        HG::Rendering::Runtime::UIPassConstructor::UIPassConstructor(v16, 0LL);
		        goto LABEL_11;
		      case PassConstructorID__Enum_Multiblur:
		        v17 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::MultiblurPassConstructor);
		        if ( !v17 )
		          goto LABEL_4;
		        v18 = *resources;
		        v19 = TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->_1.cctor_finished_or_no_cctor == 0;
		        v73 = *resources;
		        if ( v19 )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		          v18.defaultResources = v73.defaultResources;
		        }
		        HG::Rendering::Runtime::UberPostPassUtils::PrepareFrostedGlassPSMaterials(
		          materialCollector,
		          (UberPostPassUtils_FrostedGlassPSMaterials *)(v17 + 16),
		          v18.defaultResources,
		          0LL);
		        return (IPassConstructor *)v17;
		      case PassConstructorID__Enum_ScreenSpaceOverlay:
		        result = (IPassConstructor *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor);
		        if ( !result )
		          goto LABEL_4;
		        return result;
		      case PassConstructorID__Enum_SetFinalTarget:
		        v10 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::SetFinalTargetPassConstructor);
		        if ( !v10 )
		          goto LABEL_4;
		        defaultResources = resources->defaultResources;
		        if ( !resources->defaultResources )
		          goto LABEL_4;
		        defaultResources = (HGRenderPipelineRuntimeResources *)defaultResources->fields.shaders;
		        if ( !defaultResources || !materialCollector )
		          goto LABEL_4;
		        uiImageBlurPS = (Shader *)defaultResources[4].fields.assets;
		LABEL_10:
		        *(_QWORD *)(v10 + 16) = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
		                                  materialCollector,
		                                  uiImageBlurPS,
		                                  0,
		                                  0LL);
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)(v10 + 16), v13, v14, v15, v72);
		LABEL_11:
		        result = (IPassConstructor *)v10;
		        break;
		      default:
		        return 0LL;
		    }
		  }
		  return result;
		}
		
	}
}
