using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Serialization;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class HGRenderPipelineRuntimeResources : HGRenderPipelineResources, IVersionable<HG.Rendering.Runtime.HGRenderPipelineRuntimeResources.Version>, IMigratableAsset // TypeDefIndex: 38160
	{
		// Fields
		public ShaderResources shaders; // 0x18
		public MaterialResources materials; // 0x20
		public TextureResources textures; // 0x28
		public AssetResources assets; // 0x30
		[FormerlySerializedAs("version")]
		[HideInInspector]
		[SerializeField]
		private Version m_Version; // 0x38
	
		// Properties
		Version HG.Rendering.Runtime.IVersionable<HG.Rendering.Runtime.HGRenderPipelineRuntimeResources.Version>.version { get => default; set {} } // 0x0000000189B894FC-0x0000000189B89548 0x0000000189B89548-0x0000000189B895A0
		// HGRenderPipelineRuntimeResources+Version HG.Rendering.Runtime.IVersionable<HG.Rendering.Runtime.HGRenderPipelineRuntimeResources.Version>.get_version()
		HGRenderPipelineRuntimeResources_Version__Enum HG::Rendering::Runtime::HGRenderPipelineRuntimeResources::HG_Rendering_Runtime_IVersionable_HG_Rendering_Runtime_HGRenderPipelineRuntimeResources_Version__get_version(
		        HGRenderPipelineRuntimeResources *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2990, 0LL) )
		    return this->fields.m_Version;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2990, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_7((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, 0LL);
		}
		

		// Void HG.Rendering.Runtime.IVersionable<HG.Rendering.Runtime.HGRenderPipelineRuntimeResources.Version>.set_version(HGRenderPipelineRuntimeResources+Version)
		void HG::Rendering::Runtime::HGRenderPipelineRuntimeResources::HG_Rendering_Runtime_IVersionable_HG_Rendering_Runtime_HGRenderPipelineRuntimeResources_Version__set_version(
		        HGRenderPipelineRuntimeResources *this,
		        HGRenderPipelineRuntimeResources_Version__Enum value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2991, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2991, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_2((ILFixDynamicMethodWrapper_30 *)Patch, (Object *)this, value, 0LL);
		  }
		  else
		  {
		    this->fields.m_Version = value;
		  }
		}
		
	
		// Nested types
		[Serializable]
		[ReloadGroup]
		public sealed class ShaderResources // TypeDefIndex: 38155
		{
			// Fields
			[Reload("Runtime/Shaders/Materials/Lit/Lit.shader", ReloadAttribute.Package.Root)]
			public Shader defaultPS; // 0x10
			[Reload("Runtime/Shaders/Materials/Unlit/Unlit.shader", ReloadAttribute.Package.Root)]
			public Shader defaultUnlitPS; // 0x18
			[Reload("Runtime/Shaders/Interaction/HGInkSimulation.shader", ReloadAttribute.Package.Root)]
			public Shader inkSimulationPS; // 0x20
			[Reload("Runtime/Shaders/Materials/CharacterNPR/CharacterNPR.shader", ReloadAttribute.Package.Root)]
			public Shader characterLitPS; // 0x28
			[Reload("Runtime/Shaders/Materials/CharacterNPR/CharacterNPR_Hair.shader", ReloadAttribute.Package.Root)]
			public Shader characterLitHairPS; // 0x30
			[Reload("Runtime/Shaders/Materials/CharacterNPR/CharacterNPR_Skin.shader", ReloadAttribute.Package.Root)]
			public Shader characterLitSkinPS; // 0x38
			[Reload("Runtime/Shaders/Lighting/DeferredLighting.Shader", ReloadAttribute.Package.Root)]
			public Shader deferredPS; // 0x40
			[Reload("Runtime/Shaders/Lighting/DeferredLightingWriteAlpha.shader", ReloadAttribute.Package.Root)]
			public Shader deferredWriteAlphaPS; // 0x48
			[Reload("Runtime/Shaders/Lighting/DeferredLightingPerLight.shader", ReloadAttribute.Package.Root)]
			public Shader deferredPerLightPS; // 0x50
			[Reload("Runtime/Shaders/Utils/ColorPyramidPS.Shader", ReloadAttribute.Package.Root)]
			public Shader colorPyramidPS; // 0x58
			[Reload("Runtime/Shaders/Utils/DepthPyramidCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader depthPyramidCS; // 0x60
			[Reload("Runtime/Shaders/Utils/BuildHZB.compute", ReloadAttribute.Package.Root)]
			public ComputeShader buildHZBCS; // 0x68
			[Reload("Runtime/Shaders/Utils/GenerateMaxZCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader maxZCS; // 0x70
			[Reload("Runtime/Shaders/Lighting/LightBinningXYCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader lightBinningXYCS; // 0x78
			[Reload("Runtime/Shaders/Lighting/LightBinningZCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader lightBinningZCS; // 0x80
			[Reload("Runtime/Shaders/Utils/SingleColor.shader", ReloadAttribute.Package.Root)]
			public Shader singleColorPS; // 0x88
			[Reload("Runtime/Shaders/Common/GPUDrivenInitCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader GPUDrivenInitCS; // 0x90
			[Reload("Runtime/Shaders/Common/GPUDrivenCullingCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader GPUDrivenCullingCS; // 0x98
			[Reload("Runtime/Shaders/Common/GPUDrivenCullingWaveBasicCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader GPUDrivenCullingWaveBasicCS; // 0xA0
			[Reload("Runtime/Shaders/Particles/GPUParticleModule/ParticleCleanupCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader particleCleanupCS; // 0xA8
			[Reload("Runtime/Shaders/Particles/GPUParticleModule/ParticleInitCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader particleInitCS; // 0xB0
			[Reload("Runtime/Shaders/Particles/GPUParticleModule/ParticleCullCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader particleCullCS; // 0xB8
			[Reload("Runtime/Shaders/Particles/GPUParticleModule/ParticleSortCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader particleSortCS; // 0xC0
			[Reload("Runtime/Shaders/Particles/GPUParticleModule/ParticleIndirectArgsCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader particleIndirectArgsCS; // 0xC8
			[Reload("Runtime/Shaders/Particles/PhysicalParticleEmitCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader physicalParticleEmitCS; // 0xD0
			[Reload("Runtime/Shaders/Particles/SenderParticleEmitCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader senderParticleEmitCS; // 0xD8
			[Reload("Runtime/Shaders/Particles/RecieverParticleEmitCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader recieverParticleEmitCS; // 0xE0
			[Reload("Runtime/Shaders/Particles/PhysicalParticleSimulateCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader physicalParticleSimulateCS; // 0xE8
			[Reload("Runtime/Shaders/Particles/SenderParticleSimulateCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader senderParticleSimulateCS; // 0xF0
			[Reload("Runtime/Shaders/Particles/RecieverParticleSimulateCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader recieverParticleSimulateCS; // 0xF8
			[Reload("Runtime/Shaders/Particles/PhysicalParticleRender.shader", ReloadAttribute.Package.Root)]
			public Shader physicalParticleRenderPS; // 0x100
			[Reload("Runtime/Shaders/Lighting/Binning/ReflectionProbeBinningCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader reflectionProbeBinningCS; // 0x108
			[Reload("Runtime/Shaders/Lighting/AO/GTAmbientOcclusionCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader GTAmbientOcclusionCS; // 0x110
			[Reload("Runtime/Shaders/Utils/GPUCopyCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader copyChannelCS; // 0x118
			[Reload("Runtime/Shaders/Utils/ClearStencilBuffer.shader", ReloadAttribute.Package.Root)]
			public Shader clearStencilBufferPS; // 0x120
			[Reload("Runtime/Shaders/Utils/CopyStencilBuffer.shader", ReloadAttribute.Package.Root)]
			public Shader copyStencilBufferPS; // 0x128
			[Reload("Runtime/Shaders/Utils/CopyDepthBuffer.shader", ReloadAttribute.Package.Root)]
			public Shader copyDepthBufferPS; // 0x130
			[Reload("Runtime/Shaders/Utils/Blit.shader", ReloadAttribute.Package.Root)]
			public Shader blitPS; // 0x138
			[Reload("Runtime/Shaders/Utils/BlitColorAndDepth.shader", ReloadAttribute.Package.Root)]
			public Shader blitColorAndDepthPS; // 0x140
			[Reload("Runtime/Shaders/Utils/BlitMotionVector.shader", ReloadAttribute.Package.Root)]
			public Shader blitMotionVectorPS; // 0x148
			[Reload("Runtime/Shaders/Utils/VSMPass.shader", ReloadAttribute.Package.Root)]
			public Shader vsmPassPS; // 0x150
			[Reload("Runtime/Shaders/Utils/Blur.shader", ReloadAttribute.Package.Root)]
			public Shader blurPS; // 0x158
			[Reload("Runtime/Shaders/Utils/HorizontalBlur.shader", ReloadAttribute.Package.Root)]
			public Shader horizontalBlurPS; // 0x160
			[Reload("Runtime/Shaders/Utils/CopyBuffer.compute", ReloadAttribute.Package.Root)]
			public ComputeShader copyBufferCS; // 0x168
			[Reload("Runtime/Shaders/Utils/LowResBlit.shader", ReloadAttribute.Package.Root)]
			public Shader lowResBlitPS; // 0x170
			[Reload("Runtime/Shaders/PostProcessing/TAAU/TAAUDilation.shader", ReloadAttribute.Package.Root)]
			public Shader taauDilationPS; // 0x178
			[Reload("Runtime/Shaders/PostProcessing/TAAU/TAAUMaskDilation.shader", ReloadAttribute.Package.Root)]
			public Shader taauMaskDilationPS; // 0x180
			[Reload("Runtime/Shaders/PostProcessing/TAAU/TAAUResolve.Shader", ReloadAttribute.Package.Root)]
			public Shader taauResolvePS; // 0x188
			[Reload("Runtime/Shaders/Utils/EncodeBC6HCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader encodeBC6HCS; // 0x190
			[Reload("Runtime/Shaders/Utils/CubeToPano.shader", ReloadAttribute.Package.Root)]
			public Shader cubeToPanoPS; // 0x198
			[Reload("Runtime/Shaders/Utils/BlitCubeTextureFace.shader", ReloadAttribute.Package.Root)]
			public Shader blitCubeTextureFacePS; // 0x1A0
			[Reload("Runtime/Shaders/Utils/ClearUIntTextureArrayCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader clearUIntTextureCS; // 0x1A8
			[Reload("Runtime/Shaders/Utils/Texture3DAtlasCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader texture3DAtlasCS; // 0x1B0
			[Reload("Runtime/Shaders/Utils/TextureBlendCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader textureBlendCS; // 0x1B8
			[Reload("Runtime/Shaders/Lighting/Shadow/ShadowClear.shader", ReloadAttribute.Package.Root)]
			public Shader shadowClearPS; // 0x1C0
			[Reload("Runtime/Shaders/Lighting/Shadow/ShadowBlit.shader", ReloadAttribute.Package.Root)]
			public Shader shadowBlitPS; // 0x1C8
			[Reload("Runtime/Shaders/Lighting/ShadowBlur.shader", ReloadAttribute.Package.Root)]
			public Shader shadowBlurPS; // 0x1D0
			[Reload("Runtime/Shaders/Lighting/Shadow/LowResDirectionalShadow.shader", ReloadAttribute.Package.Root)]
			public Shader lowResDirectionalShadowPS; // 0x1D8
			[Reload("Runtime/Shaders/Lighting/Shadow/ScreenSpaceShadowResolve.shader", ReloadAttribute.Package.Root)]
			public Shader screenSpaceShadowResolvePS; // 0x1E0
			[Reload("Runtime/Shaders/Lighting/Shadow/ShadowDecalProjector/ShadowDecalProjector.shader", ReloadAttribute.Package.Root)]
			public Shader shadowDecalProjectorPS; // 0x1E8
			[Reload("Runtime/Shaders/Lighting/Shadow/CapsuleShadowCaster.shader", ReloadAttribute.Package.Root)]
			public Shader capsuleShadowCasterPS; // 0x1F0
			[Reload("Runtime/Shaders/Utils/HGHiZDownSampleCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader hizDownSampleCS; // 0x1F8
			[Reload("Runtime/Shaders/Environment/Atmosphere/RenderAtmosphereLut.shader", ReloadAttribute.Package.Root)]
			public Shader renderAtmosphereLutPS; // 0x200
			[Reload("Runtime/Shaders/Environment/Atmosphere/RenderAtmosphereLutCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader renderAtmosphereLutCS; // 0x208
			[Reload("Runtime/Shaders/Environment/Sky/ProceduralSky.shader", ReloadAttribute.Package.Root)]
			public Shader proceduralSkyPS; // 0x210
			[Reload("Runtime/Shaders/Environment/Sky/SkyBoxCubemap.shader", ReloadAttribute.Package.Root)]
			public Shader skyBoxCubemapPS; // 0x218
			[Reload("Runtime/Shaders/Environment/Atmosphere/VolumetricFogGridInjectionCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader volumetricFogGridInjectionCS; // 0x220
			[Reload("Runtime/Shaders/Environment/Atmosphere/VolumetricFogLightScatteringCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader volumetricFogLightScatteringCS; // 0x228
			[Reload("Runtime/Shaders/Environment/Atmosphere/VolumetricFogFinalIntegrationCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader volumetricFogFinalIntegrationCS; // 0x230
			[Reload("Runtime/Shaders/Environment/Atmosphere/BakeFogLut.shader", ReloadAttribute.Package.Root)]
			public Shader bakeFogLutPS; // 0x238
			[Reload("Runtime/Shaders/Cloth/ClothDataUploadCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader clothDataUploadCS; // 0x240
			[Reload("Runtime/Shaders/Cloth/ClothSingleDispatchCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader clothSingleDispatchCS; // 0x248
			[Reload("Runtime/Shaders/Materials/MaterialFeature/Interaction/HGDrawInteractionNode.shader", ReloadAttribute.Package.Root)]
			public Shader drawInteractionNodePS; // 0x250
			[Reload("Runtime/Shaders/Materials/Terrain/HGTerrainCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader terrainRenderCS; // 0x258
			[Reload("Runtime/Shaders/Materials/Terrain/HGEditorTerrainCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader editorTerrainCS; // 0x260
			[Reload("Runtime/Shaders/Materials/Terrain/HGTerrainPS.shader", ReloadAttribute.Package.Root)]
			public Shader terrainRenderPS; // 0x268
			[Reload("Runtime/Shaders/Materials/Terrain/V3/HGTerrainV3CS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader terrainCSV3; // 0x270
			[Reload("Runtime/Shaders/Materials/Terrain/V3/HGTerrainPSV3.shader", ReloadAttribute.Package.Root)]
			public Shader terrainPSV3; // 0x278
			[Reload("Runtime/Shaders/Materials/Terrain/V3/HGEditorTerrainV3CS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader editorTerrainCSV3; // 0x280
			[Reload("Runtime/Shaders/Materials/Terrain/V3/HGTerrainDeformGenerateV3CS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader terrainDeformGenerateCSV3; // 0x288
			[Reload("Runtime/Shaders/TerrainDeform/GenerateV2CS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader terrainDeformGenerateV2CS; // 0x290
			[Reload("Runtime/Shaders/TerrainDeform/GenerateCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader terrainDeformGenerateCS; // 0x298
			[Reload("Runtime/Shaders/TerrainDeform/ReprojectHistoryCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader terrainDeformReprojectHistoryCS; // 0x2A0
			[Reload("Runtime/Shaders/TerrainDeform/SpatialFilterCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader terrainDeformSpatialFilterCS; // 0x2A8
			[Reload("Runtime/Shaders/TerrainDeform/GenerateNormalCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader terrainDeformGenerateNormalCS; // 0x2B0
			[Reload("Runtime/Shaders/TerrainDeform/GenerateDensityCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader terrainDeformGenerateDensityCS; // 0x2B8
			[Reload("Runtime/Shaders/TerrainDeform/EdgeDetectionCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader terrainDeformEdgeDetectionCS; // 0x2C0
			[Reload("Runtime/Shaders/Materials/Terrain/HGTerrainClipmapCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader terrainGroundLayerClipmapCS; // 0x2C8
			[Reload("Runtime/Shaders/PostProcessing/LutBuilder3DCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader lutBuilder3DCS; // 0x2D0
			[Reload("Runtime/Shaders/PostProcessing/LutBuilder2D.shader", ReloadAttribute.Package.Root)]
			public Shader lutBuilder2DPS; // 0x2D8
			[Reload("Runtime/Shaders/PostProcessing/HGAutoExposureHistogramCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader hgAutoExposureHistogramCS; // 0x2E0
			[Reload("Runtime/Shaders/PostProcessing/UberPost.shader", ReloadAttribute.Package.Root)]
			public Shader uberPostPS; // 0x2E8
			[Reload("Runtime/Shaders/Materials/CutsceneEffect/CutsceneEffect.shader", ReloadAttribute.Package.Root)]
			public Shader CutsceneEffectPS; // 0x2F0
			[Reload("Runtime/Shaders/PostProcessing/Bloom/Bloom.shader", ReloadAttribute.Package.Root)]
			public Shader bloomPS; // 0x2F8
			[Reload("Runtime/Shaders/PostProcessing/Sharpen.shader", ReloadAttribute.Package.Root)]
			public Shader sharpenPS; // 0x300
			[Reload("Runtime/Shaders/PostProcessing/FinalPass.shader", ReloadAttribute.Package.Root)]
			public Shader finalPassPS; // 0x308
			[Reload("Runtime/Shaders/PostProcessing/BlitBackbuffer.shader", ReloadAttribute.Package.Root)]
			public Shader blitBackBufferPS; // 0x310
			[Reload("Runtime/Shaders/PostProcessing/Bloom/BloomPrefilterCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader bloomPrefilterCS; // 0x318
			[Reload("Runtime/Shaders/PostProcessing/Bloom/BloomBlurCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader bloomBlurCS; // 0x320
			[Reload("Runtime/Shaders/PostProcessing/Bloom/BloomBlur_NonOptimizedCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader bloomBlurNonOptCS; // 0x328
			[Reload("Runtime/Shaders/PostProcessing/Bloom/BloomUpsampleCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader bloomUpsampleCS; // 0x330
			[Reload("Runtime/Shaders/Materials/Effect/VFXSkillScanLine.shader", ReloadAttribute.Package.Root)]
			public Shader skillScanLinePS; // 0x338
			[Reload("Runtime/Shaders/Materials/Effect/VFXSceneColorAdjustment.shader", ReloadAttribute.Package.Root)]
			public Shader sceneColorAdjustmentPS; // 0x340
			[Reload("Runtime/Shaders/PostProcessing/FrostedGlassBlurCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader frostedGlassBlurCS; // 0x348
			[Reload("Runtime/Shaders/PostProcessing/FrostedGlassBlur.shader", ReloadAttribute.Package.Root)]
			public Shader frostedGlassBlurPS; // 0x350
			[Reload("Runtime/Shaders/PostProcessing/LensFlareDatadriven.shader", ReloadAttribute.Package.Root)]
			public Shader lensFlareDataDrivenPS; // 0x358
			[Reload("Runtime/Shaders/PostProcessing/UIImageBlur.shader", ReloadAttribute.Package.Root)]
			public Shader uiImageBlurPS; // 0x360
			[Reload("Runtime/Shaders/PostProcessing/SMAA/SMAA.shader", ReloadAttribute.Package.Root)]
			public Shader smaaPS; // 0x368
			[Reload("Runtime/Shaders/PostProcessing/LightShaft/HGLightShaft.shader", ReloadAttribute.Package.Root)]
			public Shader lightShaftPS; // 0x370
			[Reload("Runtime/Shaders/Materials/CutsceneEffect/CutsceneEffect.shader", ReloadAttribute.Package.Root)]
			public Shader parafinPS; // 0x378
			[Reload("Runtime/Shaders/PostProcessing/AnamorphicStreaks/AnamorphicStreaks.shader", ReloadAttribute.Package.Root)]
			public Shader anamorphicStreaksPS; // 0x380
			[Reload("Runtime/Shaders/PostProcessing/AnamorphicStreaks/AnamorphicStreaksPrefilter.compute", ReloadAttribute.Package.Root)]
			public ComputeShader anamorphicStreaksCS; // 0x388
			[Reload("Runtime/Shaders/PostProcessing/DOF/HGDepthOfField.shader", ReloadAttribute.Package.Root)]
			public Shader depthOfFieldPS; // 0x390
			[Reload("Runtime/Shaders/PostProcessing/DOF/HGDepthOfFieldMobile.shader", ReloadAttribute.Package.Root)]
			public Shader depthOfFieldMobilePS; // 0x398
			[Reload("Runtime/Shaders/PostProcessing/DOF/HGDepthOfFieldHexagonal.shader", ReloadAttribute.Package.Root)]
			public Shader depthOfFieldHexagonalPS; // 0x3A0
			[Reload("Runtime/Shaders/PostProcessing/DOF/CircleDepthOfFieldCS.Compute", ReloadAttribute.Package.Root)]
			public ComputeShader circleDepthOfFieldCS; // 0x3A8
			[Reload("Runtime/Shaders/PostProcessing/MotionBlur/MotionBlurCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader motionBlurCS; // 0x3B0
			[Reload("Runtime/Shaders/Lighting/SSR/ScreenSpaceReflectionCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader screenSpaceReflectionCS; // 0x3B8
			[Reload("Runtime/Shaders/Lighting/SSR/ScreenSpaceReflectionPS.shader", ReloadAttribute.Package.Root)]
			public Shader screenSpaceReflectionPS; // 0x3C0
			[Reload("Runtime/Shaders/Lighting/SSPR/ScreenSpacePlanarReflectionCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader ssprCS; // 0x3C8
			[Reload("Runtime/Shaders/Lighting/ContactShadow/ContactShadowCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader contactShadowCS; // 0x3D0
			[Reload("Runtime/Shaders/Materials/Foliage/FoliageOccluder.shader", ReloadAttribute.Package.Root)]
			public Shader foliageOccluderPS; // 0x3D8
			[Reload("Runtime/Shaders/Materials/Foliage/BlitFoliageOccluderMask.shader", ReloadAttribute.Package.Root)]
			public Shader foliageOccluderBlitPS; // 0x3E0
			[Reload("Runtime/Shaders/Materials/Foliage/FoliageInteractiveBlit.shader", ReloadAttribute.Package.Root)]
			public Shader foliageInteractiveBlitPS; // 0x3E8
			[Reload("Runtime/Shaders/Materials/Foliage/FoliageInteractiveCollider.shader", ReloadAttribute.Package.Root)]
			public Shader foliageInteractiveColliderPS; // 0x3F0
			[Reload("Runtime/Shaders/Materials/Effect/Sludge/DynamicSludgeBlit.shader", ReloadAttribute.Package.Root)]
			public Shader sludgeBlitPS; // 0x3F8
			[Reload("Runtime/Shaders/Materials/Effect/Sludge/SludgeV2.shader", ReloadAttribute.Package.Root)]
			public Shader sludgePS; // 0x400
			[Reload("Runtime/Shaders/Materials/Water/WaterRendering.shader", ReloadAttribute.Package.Root)]
			public Shader waterRenderingPS; // 0x408
			[Reload("Runtime/Shaders/Materials/Water/WaterOcclusionCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader waterOcclusionCS; // 0x410
			[Reload("Runtime/Shaders/Materials/Water/RippleRange.shader", ReloadAttribute.Package.Root)]
			public Shader rippleRangePS; // 0x418
			[Reload("Runtime/Shaders/Materials/Water/RippleSimulate.shader", ReloadAttribute.Package.Root)]
			public Shader rippleSimulationPS; // 0x420
			[Reload("Runtime/Shaders/Materials/Water/RippleHeightConvert.shader", ReloadAttribute.Package.Root)]
			public Shader rippleHeightConvertPS; // 0x428
			[Reload("Runtime/Shaders/Materials/Water/WaterProxy.shader", ReloadAttribute.Package.Root)]
			public Shader waterProxyPS; // 0x430
			[Reload("Runtime/Shaders/Materials/Water/WaterForwardRendering.shader", ReloadAttribute.Package.Root)]
			public Shader waterForwardRenderingPS; // 0x438
			[Reload("Runtime/Shaders/Materials/Water/WaterTextureProcessPS.shader", ReloadAttribute.Package.Root)]
			public Shader waterTextureProcessPS; // 0x440
			[Reload("Runtime/Shaders/Lighting/IrradianceVolume/IrradianceVolumeAtlasBakeV2CS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader ivBakeV2CS; // 0x448
			[Reload("Runtime/Shaders/Lighting/IrradianceVolume/IrradianceVolumeIndirectUpdateV2CS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader ivIndirectV2CS; // 0x450
			[Reload("Runtime/Shaders/Lighting/IrradianceVolume/IrradianceVolumeAtlasBakeV3CS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader ivBakeV3CS; // 0x458
			[Reload("Runtime/Shaders/Lighting/IrradianceVolume/IrradianceVolumeClipmapUpdateCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader ivClipmapUpdateCS; // 0x460
			[Reload("Runtime/Shaders/Lighting/IrradianceVolume/IrradianceVolumeUpdateV3CS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader ivUpdateV3CS; // 0x468
			[Reload("Runtime/Shaders/Lighting/IrradianceVolume/IrradianceVolumeCopyBufferCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader ivCopyBufferCS; // 0x470
			[Reload("Runtime/Shaders/Interaction/FallenLeavesCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader fallenLeavesCS; // 0x478
			[Reload("Runtime/Shaders/GPUParticle/GPUParticleBuildIndirect.compute", ReloadAttribute.Package.Root)]
			public ComputeShader gpuParticleBuildIndirectCS; // 0x480
			[Reload("Runtime/Shaders/Lighting/GI/WorldSpaceGridBuildCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader giGridBuildCS; // 0x488
			[Reload("Runtime/Shaders/Lighting/GI/ProbeVisibilityTraceCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader giProbeTraceCS; // 0x490
			[Reload("Runtime/Shaders/Lighting/GI/RadianceCachePrepareDispatchCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader giPrepareDispatchCS; // 0x498
			[Reload("Runtime/Shaders/Lighting/GI/ProbeBlendCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader giProbeBlendCS; // 0x4A0
			[Reload("Runtime/Shaders/Lighting/GI/FinalGatherCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader giFinalGatherCS; // 0x4A8
			[Reload("Runtime/Shaders/Lighting/GI/GIDenoiseV2CS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader giDenoiseV2CS; // 0x4B0
			[Reload("Runtime/Shaders/Lighting/GI/GeoNormalReconstructCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader geoNormalCS; // 0x4B8
			[Reload("Runtime/Shaders/Lighting/GI/GIProbeVisualization.shader", ReloadAttribute.Package.Root)]
			public Shader giProbeVisualizationPS; // 0x4C0
			[Reload("Runtime/Shaders/Lighting/GI/GIWRCDebugViewCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader giWRCDebugViewCS; // 0x4C8
			[Reload("Runtime/Shaders/Lighting/GI/RadianceCacheEvictionCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader giRadianceCacheEvictionCS; // 0x4D0
			[Reload("Runtime/Shaders/Lighting/GI/WorldSpaceGridDebugDraw.shader", ReloadAttribute.Package.Root)]
			public Shader wsgDebugDrawPS; // 0x4D8
			[Reload("Runtime/Shaders/Materials/Rain/FarRain.shader", ReloadAttribute.Package.Root)]
			public Shader farRainPS; // 0x4E0
			[Reload("Runtime/Shaders/Materials/Rain/SceneEffectRain.shader", ReloadAttribute.Package.Root)]
			public Shader sceneEffectRainPS; // 0x4E8
			[Reload("Runtime/Shaders/Materials/Rain/ScreenRainDropFX.shader", ReloadAttribute.Package.Root)]
			public Shader screenRainDropFXShader; // 0x4F0
			[Reload("Runtime/Shaders/Materials/Rain/RainSplash.shader", ReloadAttribute.Package.Root)]
			public Shader rainSplashShader; // 0x4F8
			[Reload("Runtime/Shaders/Materials/Effect/VFXSkillScanLineHighlight.shader", ReloadAttribute.Package.Root)]
			public Shader scanLineHighlightShader; // 0x500
			[Reload("Runtime/Shaders/Materials/Effect/FakeFog/VFXFakeVolumeFog.shader", ReloadAttribute.Package.Root)]
			public Shader fakeVolumeFogPS; // 0x508
			[Reload("Runtime/Shaders/Utils/ClearDepth.shader", ReloadAttribute.Package.Root)]
			public Shader clearDepth; // 0x510
			[Reload("Runtime/Shaders/Lighting/Particle/ParticleLightingCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader particleLightingCS; // 0x518
			[Reload("Runtime/Shaders/Utils/ShaderLOD.shader", ReloadAttribute.Package.Root)]
			public Shader shaderLODPS; // 0x520
			[Reload("Runtime/Shaders/Lighting/Shadow/VisibilitySH.shader", ReloadAttribute.Package.Root)]
			public Shader visibilitySHPS; // 0x528
			[Reload("Runtime/Shaders/Lighting/Shadow/VisibilitySHBuildCluster.compute", ReloadAttribute.Package.Root)]
			public ComputeShader visibilitySHCS; // 0x530
			[Reload("Runtime/Shaders/DLSS/DLSSVelocityCombineCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader dlssVelocityCombineCS; // 0x538
			[Reload("Runtime/Shaders/DLSS/DLSSGFlipBlitCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader dlssGFlipBlitCS; // 0x540
			[Reload("Runtime/Shaders/DLSS/DLSSGUIHintCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader dlssGUIHintCS; // 0x548
			[Reload("Runtime/Shaders/FSR3/hg_ffx_resolve_motion_vectorsCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader hgFSR3ResolvedMotionVectors; // 0x550
			[Reload("Runtime/Shaders/FSR3/ffx_fsr3upscaler_prepare_inputs_passCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader fsr3PrepareInputCS; // 0x558
			[Reload("Runtime/Shaders/FSR3/ffx_fsr3upscaler_luma_pyramid_passCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader fsr3ComputeLuminancePyramid; // 0x560
			[Reload("Runtime/Shaders/FSR3/ffx_fsr3upscaler_luma_instability_passCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader fsr3ComputeLuminanceInstability; // 0x568
			[Reload("Runtime/Shaders/FSR3/ffx_fsr3upscaler_shading_change_pyramid_passCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader fsr3ComputeShadingChangePyramid; // 0x570
			[Reload("Runtime/Shaders/FSR3/ffx_fsr3upscaler_shading_change_passCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader fsr3ComputeShadingChange; // 0x578
			[Reload("Runtime/Shaders/FSR3/ffx_fsr3upscaler_prepare_reactivity_passCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader fsr3PrepareReactivity; // 0x580
			[Reload("Runtime/Shaders/FSR3/ffx_fsr3upscaler_accumulate_passCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader fsr3Accumulate; // 0x588
			[Reload("Runtime/Shaders/FSR3/ffx_fsr3upscaler_rcas_passCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader fsr3RCAS; // 0x590
			[Reload("Runtime/Shaders/FSR3/ffx_opticalflow_prepare_luma_passCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader fsr3OpticalFlowPrepareLumaCS; // 0x598
			[Reload("Runtime/Shaders/FSR3/ffx_opticalflow_compute_scd_divergence_passCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader fsr3OpticalFlowComputeSCDDivergenceCS; // 0x5A0
			[Reload("Runtime/Shaders/FSR3/ffx_opticalflow_filter_optical_flow_pass_v5CS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader fsr3OpticalFlowFilterOpticalFlowCS; // 0x5A8
			[Reload("Runtime/Shaders/FSR3/ffx_opticalflow_generate_scd_histogram_passCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader fsr3OpticalFlowGenerateSCDHistogramCS; // 0x5B0
			[Reload("Runtime/Shaders/FSR3/ffx_opticalflow_compute_luminance_pyramid_passCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader fsr3OpticalFlowComputeLuminacePyramidCS; // 0x5B8
			[Reload("Runtime/Shaders/FSR3/ffx_opticalflow_scale_optical_flow_advanced_pass_v5CS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader fsr3OpticalFlowScaleOpticalFlowAdvancedCS; // 0x5C0
			[Reload("Runtime/Shaders/FSR3/ffx_opticalflow_compute_optical_flow_advanced_pass_v5CS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader fsr3OpticalFlowComputeOpticalFlowAdvancedCS; // 0x5C8
			[Reload("Runtime/Shaders/FSR3/ffx_frameinterpolation_passCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader fsr3FrameInterpolationCS; // 0x5D0
			[Reload("Runtime/Shaders/FSR3/ffx_frameinterpolation_setup_passCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader fsr3FrameInterpolationSetupCS; // 0x5D8
			[Reload("Runtime/Shaders/FSR3/ffx_frameinterpolation_inpainting_passCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader fsr3FrameInterpolationInpaintingCS; // 0x5E0
			[Reload("Runtime/Shaders/FSR3/ffx_frameinterpolation_disocclusion_mask_passCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader fsr3FrameInterpolationDisocclusionMaskCS; // 0x5E8
			[Reload("Runtime/Shaders/FSR3/ffx_frameinterpolation_reconstruct_and_dilate_passCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader fsr3FrameInterpolationReconstructAndDilateCS; // 0x5F0
			[Reload("Runtime/Shaders/FSR3/ffx_frameinterpolation_game_motion_vector_field_passCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader fsr3FrameInterpolationGameMotionVectorFiledCS; // 0x5F8
			[Reload("Runtime/Shaders/FSR3/ffx_frameinterpolation_optical_flow_vector_field_passCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader fsr3FrameInterpolationOpticalFlowVectorFiledCS; // 0x600
			[Reload("Runtime/Shaders/FSR3/ffx_frameinterpolation_compute_inpainting_pyramid_passCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader fsr3FrameInterpolationComputeInpaintingPyramidCS; // 0x608
			[Reload("Runtime/Shaders/FSR3/ffx_frameinterpolation_reconstruct_previous_depth_passCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader fsr3FrameInterpolationReconstructPreviousDepthCS; // 0x610
			[Reload("Runtime/Shaders/FSR3/ffx_frameinterpolation_compute_game_vector_field_inpainting_pyramid_passCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader fsr3FrameInterpolationComputeGameVectorFieldInpaintingPyramidCS; // 0x618
			[Reload("Runtime/Shaders/Volumetric/VolumetricCompose.shader", ReloadAttribute.Package.Root)]
			public Shader volumetricComposePS; // 0x620
			[Reload("Runtime/Shaders/RayTracing/RayTracingBinningCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader rayTracingBinningCS; // 0x628
			[Reload("Runtime/Shaders/RayTracing/HGFactoryVATSkinningCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader factoryVATSkinningCS; // 0x630
			[Reload("Runtime/Shaders/RayTracing/GpuSceneDirtyUpdateCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader gpuSceneDirtyUpdateCS; // 0x638
			[Reload("Runtime/Shaders/RayTracing/Reflection/Mobile/RayTracingReflectionPS.shader", ReloadAttribute.Package.Root)]
			public Shader rayTracingReflectionPS; // 0x640
			[Reload("Runtime/Shaders/RayTracing/Reflection/Mobile/RTRVariableRateCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader rtrVariableRateCS; // 0x648
			[Reload("Runtime/Shaders/RayTracing/Reflection/Mobile/RTRScreenSpaceReflectionCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader rtrScreenSpaceReflectionCS; // 0x650
			[Reload("Runtime/Shaders/RayTracing/Reflection/RTRRayTracingReflectionCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader rtrRayTracingReflectionCS; // 0x658
			[Reload("Runtime/Shaders/RayTracing/Reflection/Mobile/RTRRayTracingMobileCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader rtrRayTracingMobileCS; // 0x660
			[Reload("Runtime/Shaders/RayTracing/Reflection/Denoise/RTR_NRDenoise_CS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader rtrNRDenoiseCS; // 0x668
			[Reload("Runtime/Shaders/RayTracing/Reflection/Mobile/RTRDenoiseMobileCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader rtrDenoiseMobileCS; // 0x670
			[Reload("Runtime/Shaders/RayTracing/Reflection/RTRMaterialSortingCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader rtrMaterialSortingCS; // 0x678
			[Reload("Runtime/Shaders/RayTracing/Reflection/RTRMaterialSortingFallbackCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader rtrMaterialSortingFallbackCS; // 0x680
			[Reload("Runtime/Shaders/Utils/FontSDF.shader", ReloadAttribute.Package.Root)]
			public Shader fontSDFPS; // 0x688
			[Reload("Runtime/Shaders/Utils/FrameInterpolationInputConvert.shader", ReloadAttribute.Package.Root)]
			public Shader frameInterpolationInputConvertPS; // 0x690
			[Reload("Runtime/Shaders/TextureStreamingFeedback/TextureStreamingFeedbackProcessReadbackBufferCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader textureStreamingFeedbackProcessReadbackBufferCS; // 0x698
	
			// Constructors
			public ShaderResources() {} // 0x00000001841E1670-0x00000001841E1680
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
			
		}
	
		[Serializable]
		[ReloadGroup]
		public sealed class MaterialResources // TypeDefIndex: 38156
		{
			// Fields
			[Reload("Runtime/RenderPipelineResources/Volumetric/Materials/VolumetricRenderer.mat", ReloadAttribute.Package.Root)]
			public Material volumetricMaterial; // 0x10
	
			// Constructors
			public MaterialResources() {} // 0x00000001841E1670-0x00000001841E1680
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
			
		}
	
		[Serializable]
		[ReloadGroup]
		public sealed class TextureResources // TypeDefIndex: 38157
		{
			// Fields
			[Reload("Runtime/RenderPipelineResources/Texture/Dither/DotDither.png", ReloadAttribute.Package.Root)]
			public Texture2D dotDither; // 0x10
			[Reload("Runtime/RenderPipelineResources/Texture/SMAA/SearchTex.tga", ReloadAttribute.Package.Root)]
			public Texture2D SMAASearchTex; // 0x18
			[Reload("Runtime/RenderPipelineResources/Texture/SMAA/AreaTex.tga", ReloadAttribute.Package.Root)]
			public Texture2D SMAAAreaTex; // 0x20
			[Reload("Runtime/RenderPipelineResources/Texture/Wind/WindNoise.png", ReloadAttribute.Package.Root)]
			public Texture2D WindNoiseTex; // 0x28
			[Reload("Runtime/RenderPipelineResources/Texture/HeightFogFlowNoise.asset", ReloadAttribute.Package.Root)]
			public Texture3D HeightFogNoise3DTex; // 0x30
			[Reload("Runtime/RenderPipelineResources/Texture/HeightFogFlowPerturbNoise.asset", ReloadAttribute.Package.Root)]
			public Texture3D HeightFogNoisePerturb3DTex; // 0x38
			[Reload("Runtime/RenderPipelineResources/Texture/Glint/GlintCellNoise.tga", ReloadAttribute.Package.Root)]
			public Texture2D GlintCellNoiseTex; // 0x40
			[Reload("Runtime/RenderPipelineResources/Texture/PerlinNoise.tga", ReloadAttribute.Package.Root)]
			public Texture2D PerlinNoiseTex; // 0x48
			[Reload("Runtime/RenderPipelineResources/Texture/SnowDetailNormal.tga", ReloadAttribute.Package.Root)]
			public Texture2D SnowDetailNormal; // 0x50
			[Reload("Runtime/RenderPipelineResources/Texture/VisibilitySH/visibility_ab_lut.tga", ReloadAttribute.Package.Root)]
			public Texture2D VisibilityABLut; // 0x58
			[Reload("Runtime/RenderPipelineResources/Texture/VisibilitySH/visibility_sh_lut.tga", ReloadAttribute.Package.Root)]
			public Texture2D VisibilitySHLut; // 0x60
	
			// Constructors
			public TextureResources() {} // 0x00000001841E1670-0x00000001841E1680
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
			
		}
	
		[Serializable]
		[ReloadGroup]
		public sealed class AssetResources // TypeDefIndex: 38158
		{
			// Fields
			[Reload("Runtime/RenderPipelineResources/Mesh/SimpleSphere.fbx", ReloadAttribute.Package.Root)]
			public Mesh simpleSphereMesh; // 0x10
			[Reload("Runtime/RenderPipelineResources/Mesh/Capsule.fbx", ReloadAttribute.Package.Root)]
			public Mesh defaultCapsuleMesh; // 0x18
			[Reload("Runtime/RenderPipelineResources/Mesh/Cube.fbx", ReloadAttribute.Package.Root)]
			public Mesh defaultCubeMesh; // 0x20
			[Reload("Runtime/RenderPipelineResources/Mesh/Cone.mesh", ReloadAttribute.Package.Root)]
			public Mesh defaultConeMesh; // 0x28
			[Reload("Runtime/RenderPipelineResources/Mesh/Quad.fbx", ReloadAttribute.Package.Root)]
			public Mesh defaultQuadMesh; // 0x30
			[Reload("Runtime/RenderPipelineResources/Mesh/Rain/FarRainReceiver.mesh", ReloadAttribute.Package.Root)]
			public Mesh farRainSpindleMesh; // 0x38
			[Reload("Runtime/RenderPipelineResources/Mesh/Rain/SceneEffectRainMesh.mesh", ReloadAttribute.Package.Root)]
			public Mesh sceneEffectRainMesh; // 0x40
			[Reload("Runtime/RenderPipelineResources/Mesh/Rain/RainSplashMesh.mesh", ReloadAttribute.Package.Root)]
			public Mesh rainSplashMesh; // 0x48
			[Reload("Runtime/RenderPipelineResources/HGRainPresettingAsset.asset", ReloadAttribute.Package.Root)]
			public HGRainPresettingAsset rainPresettingAsset; // 0x50
			[Reload("Runtime/RenderPipelineResources/HGSnowPresettingAsset.asset", ReloadAttribute.Package.Root)]
			public HGSnowPresettingAsset snowPresettingAsset; // 0x58
			[Reload("Runtime/RenderPipelineResources/HGInteractionSettingAsset.asset", ReloadAttribute.Package.Root)]
			public HGInteractionSettingAsset interactionSettingAsset; // 0x60
			[Reload("Runtime/Water/Resources/WaterInteractiveConfig.asset", ReloadAttribute.Package.Root)]
			public HGWaterInteractiveSetting waterInteractiveSetting; // 0x68
	
			// Constructors
			public AssetResources() {} // 0x00000001841E1670-0x00000001841E1680
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
			
		}
	
		private enum Version // TypeDefIndex: 38159
		{
			None = 0,
			First = 1,
			RemovedEditorOnlyResources = 4
		}
	
		// Constructors
		public HGRenderPipelineRuntimeResources() {} // 0x0000000184D80260-0x0000000184D80290
		// HGRenderPipelineRuntimeResources()
		void HG::Rendering::Runtime::HGRenderPipelineRuntimeResources::HGRenderPipelineRuntimeResources(
		        HGRenderPipelineRuntimeResources *this,
		        MethodInfo *method)
		{
		  this->fields.m_Version = HG::Rendering::Runtime::MigrationDescription::LastVersion<System::Int32Enum>(MethodInfo::HG::Rendering::Runtime::MigrationDescription::LastVersion<HG::Rendering::Runtime::HGRenderPipelineRuntimeResources::Version>);
		  UnityEngine::ScriptableObject::ScriptableObject((ScriptableObject *)this, 0LL);
		}
		
	}
}
