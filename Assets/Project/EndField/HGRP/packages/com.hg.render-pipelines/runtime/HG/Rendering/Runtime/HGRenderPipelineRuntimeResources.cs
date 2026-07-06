using System;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Serialization;

namespace HG.Rendering.Runtime
{
	internal class HGRenderPipelineRuntimeResources : HGRenderPipelineResources, IVersionable<HGRenderPipelineRuntimeResources.Version>, IMigratableAsset
	{
		// (get) Token: 0x06000ECB RID: 3787 RVA: 0x00002B48 File Offset: 0x00000D48
		// (set) Token: 0x06000ECC RID: 3788 RVA: 0x000025D0 File Offset: 0x000007D0
		private HGRenderPipelineRuntimeResources.Version HG.Rendering.Runtime.IVersionable<HG.Rendering.Runtime.HGRenderPipelineRuntimeResources.Version>.version
		{
			get
			{
				// // Int32 get_countAll()
				// int32_t Beyond::PoolCore::ObjectPool<System::Object>::get_countAll(
				//         ObjectPool_1_System_Object__3 *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._countAll_k__BackingField;
				// }
				// 
				return HGRenderPipelineRuntimeResources.Version.None;
			}
			set
			{
				// // Void set_countAll(Int32)
				// void Beyond::PoolCore::ObjectPool<System::Object>::set_countAll(
				//         ObjectPool_1_System_Object__3 *this,
				//         int32_t value,
				//         MethodInfo *method)
				// {
				//   this.fields._countAll_k__BackingField = value;
				// }
				// 
			}
		}

		public HGRenderPipelineRuntimeResources()
		{
			// // HGRenderPipelineRuntimeResources()
			// void HG::Rendering::Runtime::HGRenderPipelineRuntimeResources::HGRenderPipelineRuntimeResources(
			//         HGRenderPipelineRuntimeResources *this,
			//         MethodInfo *method)
			// {
			//   if ( !byte_18D8EDA50 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::MigrationDescription::LastVersion<HG::Rendering::Runtime::HGRenderPipelineRuntimeResources::Version>);
			//     byte_18D8EDA50 = 1;
			//   }
			//   this.fields.m_Version = HG::Rendering::Runtime::MigrationDescription::LastVersion<System::Int32Enum>(MethodInfo::HG::Rendering::Runtime::MigrationDescription::LastVersion<HG::Rendering::Runtime::HGRenderPipelineRuntimeResources::Version>);
			//   UnityEngine::ScriptableObject::ScriptableObject((ScriptableObject *)this, 0LL);
			// }
			// 
		}

		public HGRenderPipelineRuntimeResources.ShaderResources shaders;

		public HGRenderPipelineRuntimeResources.MaterialResources materials;

		public HGRenderPipelineRuntimeResources.TextureResources textures;

		public HGRenderPipelineRuntimeResources.AssetResources assets;

		[FormerlySerializedAs("version")]
		[SerializeField]
		[HideInInspector]
		private HGRenderPipelineRuntimeResources.Version m_Version;

		[ReloadGroup]
		[Serializable]
		public sealed class ShaderResources
		{
			public ShaderResources()
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

			[Reload("Runtime/Shaders/Materials/Lit/Lit.shader", ReloadAttribute.Package.Root)]
			public Shader defaultPS;

			[Reload("Runtime/Shaders/Materials/Unlit/Unlit.shader", ReloadAttribute.Package.Root)]
			public Shader defaultUnlitPS;

			[Reload("Runtime/Shaders/Interaction/HGInkSimulation.shader", ReloadAttribute.Package.Root)]
			public Shader inkSimulationPS;

			[Reload("Runtime/Shaders/Materials/CharacterNPR/CharacterNPR.shader", ReloadAttribute.Package.Root)]
			public Shader characterLitPS;

			[Reload("Runtime/Shaders/Materials/CharacterNPR/CharacterNPR_Hair.shader", ReloadAttribute.Package.Root)]
			public Shader characterLitHairPS;

			[Reload("Runtime/Shaders/Materials/CharacterNPR/CharacterNPR_Skin.shader", ReloadAttribute.Package.Root)]
			public Shader characterLitSkinPS;

			[Reload("Runtime/Shaders/Lighting/DeferredLighting.Shader", ReloadAttribute.Package.Root)]
			public Shader deferredPS;

			[Reload("Runtime/Shaders/Lighting/DeferredLightingWriteAlpha.shader", ReloadAttribute.Package.Root)]
			public Shader deferredWriteAlphaPS;

			[Reload("Runtime/Shaders/Lighting/DeferredLightingPerLight.shader", ReloadAttribute.Package.Root)]
			public Shader deferredPerLightPS;

			[Reload("Runtime/Shaders/Utils/ColorPyramidPS.Shader", ReloadAttribute.Package.Root)]
			public Shader colorPyramidPS;

			[Reload("Runtime/Shaders/Utils/DepthPyramidCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader depthPyramidCS;

			[Reload("Runtime/Shaders/Utils/BuildHZB.compute", ReloadAttribute.Package.Root)]
			public ComputeShader buildHZBCS;

			[Reload("Runtime/Shaders/Utils/GenerateMaxZCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader maxZCS;

			[Reload("Runtime/Shaders/Lighting/LightBinningXYCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader lightBinningXYCS;

			[Reload("Runtime/Shaders/Lighting/LightBinningZCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader lightBinningZCS;

			[Reload("Runtime/Shaders/Utils/SingleColor.shader", ReloadAttribute.Package.Root)]
			public Shader singleColorPS;

			[Reload("Runtime/Shaders/Common/GPUDrivenInitCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader GPUDrivenInitCS;

			[Reload("Runtime/Shaders/Common/GPUDrivenCullingCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader GPUDrivenCullingCS;

			[Reload("Runtime/Shaders/Particles/GPUParticleModule/ParticleCleanupCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader particleCleanupCS;

			[Reload("Runtime/Shaders/Particles/GPUParticleModule/ParticleInitCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader particleInitCS;

			[Reload("Runtime/Shaders/Particles/GPUParticleModule/ParticleCullCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader particleCullCS;

			[Reload("Runtime/Shaders/Particles/GPUParticleModule/ParticleSortCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader particleSortCS;

			[Reload("Runtime/Shaders/Particles/GPUParticleModule/ParticleIndirectArgsCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader particleIndirectArgsCS;

			[Reload("Runtime/Shaders/Particles/PhysicalParticleEmitCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader physicalParticleEmitCS;

			[Reload("Runtime/Shaders/Particles/SenderParticleEmitCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader senderParticleEmitCS;

			[Reload("Runtime/Shaders/Particles/RecieverParticleEmitCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader recieverParticleEmitCS;

			[Reload("Runtime/Shaders/Particles/PhysicalParticleSimulateCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader physicalParticleSimulateCS;

			[Reload("Runtime/Shaders/Particles/SenderParticleSimulateCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader senderParticleSimulateCS;

			[Reload("Runtime/Shaders/Particles/RecieverParticleSimulateCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader recieverParticleSimulateCS;

			[Reload("Runtime/Shaders/Particles/PhysicalParticleRender.shader", ReloadAttribute.Package.Root)]
			public Shader physicalParticleRenderPS;

			[Reload("Runtime/Shaders/Lighting/Binning/ReflectionProbeBinningCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader reflectionProbeBinningCS;

			[Reload("Runtime/Shaders/Lighting/AO/GTAmbientOcclusionCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader GTAmbientOcclusionCS;

			[Reload("Runtime/Shaders/Utils/GPUCopyCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader copyChannelCS;

			[Reload("Runtime/Shaders/Utils/ClearStencilBuffer.shader", ReloadAttribute.Package.Root)]
			public Shader clearStencilBufferPS;

			[Reload("Runtime/Shaders/Utils/CopyStencilBuffer.shader", ReloadAttribute.Package.Root)]
			public Shader copyStencilBufferPS;

			[Reload("Runtime/Shaders/Utils/CopyDepthBuffer.shader", ReloadAttribute.Package.Root)]
			public Shader copyDepthBufferPS;

			[Reload("Runtime/Shaders/Utils/Blit.shader", ReloadAttribute.Package.Root)]
			public Shader blitPS;

			[Reload("Runtime/Shaders/Utils/BlitColorAndDepth.shader", ReloadAttribute.Package.Root)]
			public Shader blitColorAndDepthPS;

			[Reload("Runtime/Shaders/Utils/BlitMotionVector.shader", ReloadAttribute.Package.Root)]
			public Shader blitMotionVectorPS;

			[Reload("Runtime/Shaders/Utils/VSMPass.shader", ReloadAttribute.Package.Root)]
			public Shader vsmPassPS;

			[Reload("Runtime/Shaders/Utils/Blur.shader", ReloadAttribute.Package.Root)]
			public Shader blurPS;

			[Reload("Runtime/Shaders/Utils/CopyBuffer.compute", ReloadAttribute.Package.Root)]
			public ComputeShader copyBufferCS;

			[Reload("Runtime/Shaders/Utils/LowResBlit.shader", ReloadAttribute.Package.Root)]
			public Shader lowResBlitPS;

			[Reload("Runtime/Shaders/PostProcessing/TAAU/TAAUDilation.shader", ReloadAttribute.Package.Root)]
			public Shader taauDilationPS;

			[Reload("Runtime/Shaders/PostProcessing/TAAU/TAAUMaskDilation.shader", ReloadAttribute.Package.Root)]
			public Shader taauMaskDilationPS;

			[Reload("Runtime/Shaders/PostProcessing/TAAU/TAAUResolve.Shader", ReloadAttribute.Package.Root)]
			public Shader taauResolvePS;

			[Reload("Runtime/Shaders/Utils/EncodeBC6HCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader encodeBC6HCS;

			[Reload("Runtime/Shaders/Utils/CubeToPano.shader", ReloadAttribute.Package.Root)]
			public Shader cubeToPanoPS;

			[Reload("Runtime/Shaders/Utils/BlitCubeTextureFace.shader", ReloadAttribute.Package.Root)]
			public Shader blitCubeTextureFacePS;

			[Reload("Runtime/Shaders/Utils/ClearUIntTextureArrayCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader clearUIntTextureCS;

			[Reload("Runtime/Shaders/Utils/Texture3DAtlasCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader texture3DAtlasCS;

			[Reload("Runtime/Shaders/Utils/TextureBlendCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader textureBlendCS;

			[Reload("Runtime/Shaders/Lighting/Shadow/ShadowClear.shader", ReloadAttribute.Package.Root)]
			public Shader shadowClearPS;

			[Reload("Runtime/Shaders/Lighting/Shadow/ShadowBlit.shader", ReloadAttribute.Package.Root)]
			public Shader shadowBlitPS;

			[Reload("Runtime/Shaders/Lighting/ShadowBlur.shader", ReloadAttribute.Package.Root)]
			public Shader shadowBlurPS;

			[Reload("Runtime/Shaders/Lighting/Shadow/LowResDirectionalShadow.shader", ReloadAttribute.Package.Root)]
			public Shader lowResDirectionalShadowPS;

			[Reload("Runtime/Shaders/Lighting/Shadow/ScreenSpaceShadowResolve.shader", ReloadAttribute.Package.Root)]
			public Shader screenSpaceShadowResolvePS;

			[Reload("Runtime/Shaders/Lighting/Shadow/CapsuleShadowCaster.shader", ReloadAttribute.Package.Root)]
			public Shader capsuleShadowCasterPS;

			[Reload("Runtime/Shaders/Utils/HGHiZDownSampleCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader hizDownSampleCS;

			[Reload("Runtime/Shaders/Environment/Atmosphere/RenderAtmosphereLut.shader", ReloadAttribute.Package.Root)]
			public Shader renderAtmosphereLutPS;

			[Reload("Runtime/Shaders/Environment/Atmosphere/RenderAtmosphereLutCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader renderAtmosphereLutCS;

			[Reload("Runtime/Shaders/Environment/Sky/ProceduralSky.shader", ReloadAttribute.Package.Root)]
			public Shader proceduralSkyPS;

			[Reload("Runtime/Shaders/Environment/Sky/SkyBoxCubemap.shader", ReloadAttribute.Package.Root)]
			public Shader skyBoxCubemapPS;

			[Reload("Runtime/Shaders/Environment/Atmosphere/VolumetricFogGridInjectionCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader volumetricFogGridInjectionCS;

			[Reload("Runtime/Shaders/Environment/Atmosphere/VolumetricFogLightScatteringCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader volumetricFogLightScatteringCS;

			[Reload("Runtime/Shaders/Environment/Atmosphere/VolumetricFogFinalIntegrationCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader volumetricFogFinalIntegrationCS;

			[Reload("Runtime/Shaders/Environment/Atmosphere/BakeFogLut.shader", ReloadAttribute.Package.Root)]
			public Shader bakeFogLutPS;

			[Reload("Runtime/Shaders/Cloth/ClothDataUploadCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader clothDataUploadCS;

			[Reload("Runtime/Shaders/Cloth/ClothSingleDispatchCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader clothSingleDispatchCS;

			[Reload("Runtime/Shaders/Materials/MaterialFeature/Interaction/HGDrawInteractionNode.shader", ReloadAttribute.Package.Root)]
			public Shader drawInteractionNodePS;

			[Reload("Runtime/Shaders/Materials/Terrain/HGTerrainCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader terrainRenderCS;

			[Reload("Runtime/Shaders/Materials/Terrain/HGEditorTerrainCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader editorTerrainCS;

			[Reload("Runtime/Shaders/Materials/Terrain/HGTerrainPS.shader", ReloadAttribute.Package.Root)]
			public Shader terrainRenderPS;

			[Reload("Runtime/Shaders/TerrainDeform/GenerateV2CS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader terrainDeformGenerateV2CS;

			[Reload("Runtime/Shaders/TerrainDeform/GenerateCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader terrainDeformGenerateCS;

			[Reload("Runtime/Shaders/TerrainDeform/ReprojectHistoryCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader terrainDeformReprojectHistoryCS;

			[Reload("Runtime/Shaders/TerrainDeform/SpatialFilterCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader terrainDeformSpatialFilterCS;

			[Reload("Runtime/Shaders/TerrainDeform/GenerateNormalCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader terrainDeformGenerateNormalCS;

			[Reload("Runtime/Shaders/TerrainDeform/GenerateDensityCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader terrainDeformGenerateDensityCS;

			[Reload("Runtime/Shaders/TerrainDeform/EdgeDetectionCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader terrainDeformEdgeDetectionCS;

			[Reload("Runtime/Shaders/Materials/Terrain/HGTerrainClipmapCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader terrainGroundLayerClipmapCS;

			[Reload("Runtime/Shaders/PostProcessing/LutBuilder3DCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader lutBuilder3DCS;

			[Reload("Runtime/Shaders/PostProcessing/LutBuilder2D.shader", ReloadAttribute.Package.Root)]
			public Shader lutBuilder2DPS;

			[Reload("Runtime/Shaders/PostProcessing/HGAutoExposureHistogramCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader hgAutoExposureHistogramCS;

			[Reload("Runtime/Shaders/PostProcessing/UberPost.shader", ReloadAttribute.Package.Root)]
			public Shader uberPostPS;

			[Reload("Runtime/Shaders/Materials/CutsceneEffect/CutsceneEffect.shader", ReloadAttribute.Package.Root)]
			public Shader CutsceneEffectPS;

			[Reload("Runtime/Shaders/PostProcessing/Bloom/Bloom.shader", ReloadAttribute.Package.Root)]
			public Shader bloomPS;

			[Reload("Runtime/Shaders/PostProcessing/Sharpen.shader", ReloadAttribute.Package.Root)]
			public Shader sharpenPS;

			[Reload("Runtime/Shaders/PostProcessing/FinalPass.shader", ReloadAttribute.Package.Root)]
			public Shader finalPassPS;

			[Reload("Runtime/Shaders/PostProcessing/BlitBackbuffer.shader", ReloadAttribute.Package.Root)]
			public Shader blitBackBufferPS;

			[Reload("Runtime/Shaders/PostProcessing/Bloom/BloomPrefilterCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader bloomPrefilterCS;

			[Reload("Runtime/Shaders/PostProcessing/Bloom/BloomBlurCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader bloomBlurCS;

			[Reload("Runtime/Shaders/PostProcessing/Bloom/BloomBlur_NonOptimizedCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader bloomBlurNonOptCS;

			[Reload("Runtime/Shaders/PostProcessing/Bloom/BloomUpsampleCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader bloomUpsampleCS;

			[Reload("Runtime/Shaders/Materials/Effect/VFXSkillScanLine.shader", ReloadAttribute.Package.Root)]
			public Shader skillScanLinePS;

			[Reload("Runtime/Shaders/Materials/Effect/VFXSceneColorAdjustment.shader", ReloadAttribute.Package.Root)]
			public Shader sceneColorAdjustmentPS;

			[Reload("Runtime/Shaders/PostProcessing/FrostedGlassBlurCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader frostedGlassBlurCS;

			[Reload("Runtime/Shaders/PostProcessing/FrostedGlassBlur.shader", ReloadAttribute.Package.Root)]
			public Shader frostedGlassBlurPS;

			[Reload("Runtime/Shaders/PostProcessing/LensFlareDatadriven.shader", ReloadAttribute.Package.Root)]
			public Shader lensFlareDataDrivenPS;

			[Reload("Runtime/Shaders/PostProcessing/UIImageBlur.shader", ReloadAttribute.Package.Root)]
			public Shader uiImageBlurPS;

			[Reload("Runtime/Shaders/PostProcessing/SMAA/SMAA.shader", ReloadAttribute.Package.Root)]
			public Shader smaaPS;

			[Reload("Runtime/Shaders/PostProcessing/LightShaft/HGLightShaft.shader", ReloadAttribute.Package.Root)]
			public Shader lightShaftPS;

			[Reload("Runtime/Shaders/Materials/CutsceneEffect/CutsceneEffect.shader", ReloadAttribute.Package.Root)]
			public Shader parafinPS;

			[Reload("Runtime/Shaders/PostProcessing/AnamorphicStreaks/AnamorphicStreaks.shader", ReloadAttribute.Package.Root)]
			public Shader anamorphicStreaksPS;

			[Reload("Runtime/Shaders/PostProcessing/AnamorphicStreaks/AnamorphicStreaksPrefilter.compute", ReloadAttribute.Package.Root)]
			public ComputeShader anamorphicStreaksCS;

			[Reload("Runtime/Shaders/PostProcessing/DOF/HGDepthOfField.shader", ReloadAttribute.Package.Root)]
			public Shader depthOfFieldPS;

			[Reload("Runtime/Shaders/PostProcessing/DOF/HGDepthOfFieldMobile.shader", ReloadAttribute.Package.Root)]
			public Shader depthOfFieldMobilePS;

			[Reload("Runtime/Shaders/PostProcessing/DOF/HGDepthOfFieldHexagonal.shader", ReloadAttribute.Package.Root)]
			public Shader depthOfFieldHexagonalPS;

			[Reload("Runtime/Shaders/PostProcessing/DOF/CircleDepthOfFieldCS.Compute", ReloadAttribute.Package.Root)]
			public ComputeShader circleDepthOfFieldCS;

			[Reload("Runtime/Shaders/PostProcessing/MotionBlur/MotionBlurCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader motionBlurCS;

			[Reload("Runtime/Shaders/Lighting/SSR/ScreenSpaceReflectionCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader screenSpaceReflectionCS;

			[Reload("Runtime/Shaders/Lighting/SSR/ScreenSpaceReflectionPS.shader", ReloadAttribute.Package.Root)]
			public Shader screenSpaceReflectionPS;

			[Reload("Runtime/Shaders/Lighting/SSPR/ScreenSpacePlanarReflectionCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader ssprCS;

			[Reload("Runtime/Shaders/Lighting/ContactShadow/ContactShadowCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader contactShadowCS;

			[Reload("Runtime/Shaders/Materials/Foliage/FoliageOccluder.shader", ReloadAttribute.Package.Root)]
			public Shader foliageOccluderPS;

			[Reload("Runtime/Shaders/Materials/Foliage/BlitFoliageOccluderMask.shader", ReloadAttribute.Package.Root)]
			public Shader foliageOccluderBlitPS;

			[Reload("Runtime/Shaders/Materials/Foliage/FoliageInteractiveBlit.shader", ReloadAttribute.Package.Root)]
			public Shader foliageInteractiveBlitPS;

			[Reload("Runtime/Shaders/Materials/Foliage/FoliageInteractiveCollider.shader", ReloadAttribute.Package.Root)]
			public Shader foliageInteractiveColliderPS;

			[Reload("Runtime/Shaders/Materials/Effect/Sludge/DynamicSludgeBlit.shader", ReloadAttribute.Package.Root)]
			public Shader sludgeBlitPS;

			[Reload("Runtime/Shaders/Materials/Effect/Sludge/SludgeV2.shader", ReloadAttribute.Package.Root)]
			public Shader sludgePS;

			[Reload("Runtime/Shaders/Materials/Water/WaterRendering.shader", ReloadAttribute.Package.Root)]
			public Shader waterRenderingPS;

			[Reload("Runtime/Shaders/Materials/Water/WaterOcclusionCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader waterOcclusionCS;

			[Reload("Runtime/Shaders/Materials/Water/RippleRange.shader", ReloadAttribute.Package.Root)]
			public Shader rippleRangePS;

			[Reload("Runtime/Shaders/Materials/Water/RippleSimulate.shader", ReloadAttribute.Package.Root)]
			public Shader rippleSimulationPS;

			[Reload("Runtime/Shaders/Materials/Water/RippleHeightConvert.shader", ReloadAttribute.Package.Root)]
			public Shader rippleHeightConvertPS;

			[Reload("Runtime/Shaders/Materials/Water/WaterProxy.shader", ReloadAttribute.Package.Root)]
			public Shader waterProxyPS;

			[Reload("Runtime/Shaders/Materials/Water/WaterForwardRendering.shader", ReloadAttribute.Package.Root)]
			public Shader waterForwardRenderingPS;

			[Reload("Runtime/Shaders/Materials/Water/WaterTextureProcessPS.shader", ReloadAttribute.Package.Root)]
			public Shader waterTextureProcessPS;

			[Reload("Runtime/Shaders/Lighting/IrradianceVolume/IrradianceVolumeAtlasBakeV2CS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader ivBakeV2CS;

			[Reload("Runtime/Shaders/Lighting/IrradianceVolume/IrradianceVolumeIndirectUpdateV2CS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader ivIndirectV2CS;

			[Reload("Runtime/Shaders/Lighting/IrradianceVolume/IrradianceVolumeAtlasBakeV3CS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader ivBakeV3CS;

			[Reload("Runtime/Shaders/Lighting/IrradianceVolume/IrradianceVolumeClipmapUpdateCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader ivClipmapUpdateCS;

			[Reload("Runtime/Shaders/Lighting/IrradianceVolume/IrradianceVolumeUpdateV3CS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader ivUpdateV3CS;

			[Reload("Runtime/Shaders/Lighting/IrradianceVolume/IrradianceVolumeCopyBufferCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader ivCopyBufferCS;

			[Reload("Runtime/Shaders/Materials/Rain/FarRain.shader", ReloadAttribute.Package.Root)]
			public Shader farRainPS;

			[Reload("Runtime/Shaders/Materials/Rain/SceneEffectRain.shader", ReloadAttribute.Package.Root)]
			public Shader sceneEffectRainPS;

			[Reload("Runtime/Shaders/Materials/Rain/ScreenRainDropFX.shader", ReloadAttribute.Package.Root)]
			public Shader screenRainDropFXShader;

			[Reload("Runtime/Shaders/Materials/Rain/RainSplash.shader", ReloadAttribute.Package.Root)]
			public Shader rainSplashShader;

			[Reload("Runtime/Shaders/Materials/Effect/VFXSkillScanLineHighlight.shader", ReloadAttribute.Package.Root)]
			public Shader scanLineHighlightShader;

			[Reload("Runtime/Shaders/Materials/Effect/FakeFog/VFXFakeVolumeFog.shader", ReloadAttribute.Package.Root)]
			public Shader fakeVolumeFogPS;

			[Reload("Runtime/Shaders/Utils/ClearDepth.shader", ReloadAttribute.Package.Root)]
			public Shader clearDepth;

			[Reload("Runtime/Shaders/Lighting/Particle/ParticleLightingCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader particleLightingCS;

			[Reload("Runtime/Shaders/Utils/ShaderLOD.shader", ReloadAttribute.Package.Root)]
			public Shader shaderLODPS;

			[Reload("Runtime/Shaders/Lighting/Shadow/VisibilitySH.shader", ReloadAttribute.Package.Root)]
			public Shader visibilitySHPS;

			[Reload("Runtime/Shaders/Lighting/Shadow/VisibilitySHBuildCluster.compute", ReloadAttribute.Package.Root)]
			public ComputeShader visibilitySHCS;

			[Reload("Runtime/Shaders/DLSS/DLSSVelocityCombineCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader dlssVelocityCombineCS;

			[Reload("Runtime/Shaders/DLSS/DLSSGFlipBlit.compute", ReloadAttribute.Package.Root)]
			public ComputeShader dlssGFlipBlitCS;

			[Reload("Runtime/Shaders/DLSS/DLSSGUIHint.compute", ReloadAttribute.Package.Root)]
			public ComputeShader dlssGUIHintCS;

			[Reload("Runtime/Shaders/FSR3/hg_ffx_resolve_motion_vectors.compute", ReloadAttribute.Package.Root)]
			public ComputeShader hgFSR3ResolvedMotionVectors;

			[Reload("Runtime/Shaders/FSR3/ffx_fsr3upscaler_prepare_inputs_pass.compute", ReloadAttribute.Package.Root)]
			public ComputeShader fsr3PrepareInputCS;

			[Reload("Runtime/Shaders/FSR3/ffx_fsr3upscaler_luma_pyramid_pass.compute", ReloadAttribute.Package.Root)]
			public ComputeShader fsr3ComputeLuminancePyramid;

			[Reload("Runtime/Shaders/FSR3/ffx_fsr3upscaler_luma_instability_pass.compute", ReloadAttribute.Package.Root)]
			public ComputeShader fsr3ComputeLuminanceInstability;

			[Reload("Runtime/Shaders/FSR3/ffx_fsr3upscaler_shading_change_pyramid_pass.compute", ReloadAttribute.Package.Root)]
			public ComputeShader fsr3ComputeShadingChangePyramid;

			[Reload("Runtime/Shaders/FSR3/ffx_fsr3upscaler_shading_change_pass.compute", ReloadAttribute.Package.Root)]
			public ComputeShader fsr3ComputeShadingChange;

			[Reload("Runtime/Shaders/FSR3/ffx_fsr3upscaler_prepare_reactivity_pass.compute", ReloadAttribute.Package.Root)]
			public ComputeShader fsr3PrepareReactivity;

			[Reload("Runtime/Shaders/FSR3/ffx_fsr3upscaler_accumulate_pass.compute", ReloadAttribute.Package.Root)]
			public ComputeShader fsr3Accumulate;

			[Reload("Runtime/Shaders/FSR3/ffx_fsr3upscaler_rcas_pass.compute", ReloadAttribute.Package.Root)]
			public ComputeShader fsr3RCAS;

			[Reload("Runtime/Shaders/Volumetric/VolumetricCompose.shader", ReloadAttribute.Package.Root)]
			public Shader volumetricComposePS;

			[Reload("Runtime/Shaders/RayTracing/RayTracingBinningCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader rayTracingBinningCS;

			[Reload("Runtime/Shaders/RayTracing/Reflection/RayTracingReflectionPS.shader", ReloadAttribute.Package.Root)]
			public Shader rayTracingReflectionPS;

			[Reload("Runtime/Shaders/RayTracing/Reflection/RayTracingReflectionCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader rayTracingReflectionCS;

			[Reload("Runtime/Shaders/RayTracing/Reflection/RTRVariableRateCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader rtrVariableRateCS;

			[Reload("Runtime/Shaders/RayTracing/Reflection/RTRScreenSpaceReflectionCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader rtrScreenSpaceReflectionCS;

			[Reload("Runtime/Shaders/RayTracing/Reflection/RTRRayTracingReflectionCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader rtrRayTracingReflection;

			[Reload("Runtime/Shaders/RayTracing/Reflection/RTRTemporalCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader rtrTemporalCS;

			[Reload("Runtime/Shaders/RayTracing/Reflection/RTRSpatialCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader rtrSpatialCS;

			[Reload("Runtime/Shaders/RayTracing/Reflection/RTRDebugCS.compute", ReloadAttribute.Package.Root)]
			public ComputeShader rtrDebugCS;

			[Reload("Runtime/Shaders/Utils/FontSDF.shader", ReloadAttribute.Package.Root)]
			public Shader fontSDFPS;

			[Reload("Runtime/Shaders/Utils/FrameInterpolationInputConvert.shader", ReloadAttribute.Package.Root)]
			public Shader frameInterpolationInputConvertPS;
		}

		[ReloadGroup]
		[Serializable]
		public sealed class MaterialResources
		{
			public MaterialResources()
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

			[Reload("Runtime/RenderPipelineResources/Volumetric/Materials/VolumetricRenderer.mat", ReloadAttribute.Package.Root)]
			public Material volumetricMaterial;
		}

		[ReloadGroup]
		[Serializable]
		public sealed class TextureResources
		{
			public TextureResources()
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

			[Reload("Runtime/RenderPipelineResources/Texture/Dither/DotDither.png", ReloadAttribute.Package.Root)]
			public Texture2D dotDither;

			[Reload("Runtime/RenderPipelineResources/Texture/SMAA/SearchTex.tga", ReloadAttribute.Package.Root)]
			public Texture2D SMAASearchTex;

			[Reload("Runtime/RenderPipelineResources/Texture/SMAA/AreaTex.tga", ReloadAttribute.Package.Root)]
			public Texture2D SMAAAreaTex;

			[Reload("Runtime/RenderPipelineResources/Texture/Wind/WindNoise.png", ReloadAttribute.Package.Root)]
			public Texture2D WindNoiseTex;

			[Reload("Runtime/RenderPipelineResources/Texture/HeightFogFlowNoise.asset", ReloadAttribute.Package.Root)]
			public Texture3D HeightFogNoise3DTex;

			[Reload("Runtime/RenderPipelineResources/Texture/Glint/GlintCellNoise.tga", ReloadAttribute.Package.Root)]
			public Texture2D GlintCellNoiseTex;

			[Reload("Runtime/RenderPipelineResources/Texture/PerlinNoise.tga", ReloadAttribute.Package.Root)]
			public Texture2D PerlinNoiseTex;

			[Reload("Runtime/RenderPipelineResources/Texture/SnowDetailNormal.tga", ReloadAttribute.Package.Root)]
			public Texture2D SnowDetailNormal;

			[Reload("Runtime/RenderPipelineResources/Texture/VisibilitySH/visibility_ab_lut.tga", ReloadAttribute.Package.Root)]
			public Texture2D VisibilityABLut;

			[Reload("Runtime/RenderPipelineResources/Texture/VisibilitySH/visibility_sh_lut.tga", ReloadAttribute.Package.Root)]
			public Texture2D VisibilitySHLut;
		}

		[ReloadGroup]
		[Serializable]
		public sealed class AssetResources
		{
			public AssetResources()
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

			[Reload("Runtime/RenderPipelineResources/Mesh/SimpleSphere.fbx", ReloadAttribute.Package.Root)]
			public Mesh simpleSphereMesh;

			[Reload("Runtime/RenderPipelineResources/Mesh/Capsule.fbx", ReloadAttribute.Package.Root)]
			public Mesh defaultCapsuleMesh;

			[Reload("Runtime/RenderPipelineResources/Mesh/Cube.fbx", ReloadAttribute.Package.Root)]
			public Mesh defaultCubeMesh;

			[Reload("Runtime/RenderPipelineResources/Mesh/Cone.mesh", ReloadAttribute.Package.Root)]
			public Mesh defaultConeMesh;

			[Reload("Runtime/RenderPipelineResources/Mesh/Quad.fbx", ReloadAttribute.Package.Root)]
			public Mesh defaultQuadMesh;

			[Reload("Runtime/RenderPipelineResources/Mesh/Rain/FarRainReceiver.mesh", ReloadAttribute.Package.Root)]
			public Mesh farRainSpindleMesh;

			[Reload("Runtime/RenderPipelineResources/Mesh/Rain/SceneEffectRainMesh.mesh", ReloadAttribute.Package.Root)]
			public Mesh sceneEffectRainMesh;

			[Reload("Runtime/RenderPipelineResources/Mesh/Rain/RainSplashMesh.mesh", ReloadAttribute.Package.Root)]
			public Mesh rainSplashMesh;

			[Reload("Runtime/RenderPipelineResources/HGRainPresettingAsset.asset", ReloadAttribute.Package.Root)]
			public HGRainPresettingAsset rainPresettingAsset;

			[Reload("Runtime/RenderPipelineResources/HGSnowPresettingAsset.asset", ReloadAttribute.Package.Root)]
			public HGSnowPresettingAsset snowPresettingAsset;

			[Reload("Runtime/RenderPipelineResources/HGInteractionSettingAsset.asset", ReloadAttribute.Package.Root)]
			public HGInteractionSettingAsset interactionSettingAsset;

			[Reload("Runtime/Water/Resources/WaterInteractiveConfig.asset", ReloadAttribute.Package.Root)]
			public HGWaterInteractiveSetting waterInteractiveSetting;
		}

		private enum Version
		{
			None,
			First,
			RemovedEditorOnlyResources = 4
		}
	}
}
