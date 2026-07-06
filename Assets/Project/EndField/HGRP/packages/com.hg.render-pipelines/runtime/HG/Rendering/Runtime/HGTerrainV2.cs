using System;
using System.Runtime.CompilerServices;
using HG.Rendering.Runtime.TerrainV2;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.HyperGryph;

namespace HG.Rendering.Runtime
{
	[ExecuteInEditMode]
	public class HGTerrainV2 : MonoBehaviour
	{
		// (get) Token: 0x0600164D RID: 5709 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x0600164E RID: 5710 RVA: 0x000025D0 File Offset: 0x000007D0
		public static TerrainLayerTypeData LayerTypeData
		{
			[CompilerGenerated]
			get
			{
				// // TerrainLayerTypeData get_LayerTypeData()
				// TerrainLayerTypeData *HG::Rendering::Runtime::HGTerrainV2::get_LayerTypeData(
				//         TerrainLayerTypeData *__return_ptr retstr,
				//         MethodInfo *method)
				// {
				//   __int64 v3; // rcx
				//   HGTerrainV2__StaticFields *static_fields; // rdx
				//   TerrainLayerTypeData *v5; // rax
				//   __int128 v6; // xmm1
				//   __int128 v7; // xmm0
				//   __int128 v8; // xmm1
				//   __int128 v9; // xmm0
				//   __int128 v10; // xmm1
				//   Color FakeCrackTint; // xmm0
				//   __int128 v12; // xmm1
				// 
				//   if ( !byte_18D919741 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGTerrainV2);
				//     byte_18D919741 = 1;
				//   }
				//   v3 = 2LL;
				//   static_fields = TypeInfo::HG::Rendering::Runtime::HGTerrainV2.static_fields;
				//   v5 = retstr;
				//   do
				//   {
				//     v6 = *(_OWORD *)&static_fields._LayerTypeData_k__BackingField._glintData._GlintScale;
				//     *(_OWORD *)&v5._glintData._EnableFakeGlint = *(_OWORD *)&static_fields._LayerTypeData_k__BackingField._glintData._EnableFakeGlint;
				//     v7 = *(_OWORD *)&static_fields._LayerTypeData_k__BackingField._glintData._GlintColor.g;
				//     *(_OWORD *)&v5._glintData._GlintScale = v6;
				//     v8 = *(_OWORD *)&static_fields._LayerTypeData_k__BackingField._subsurfaceData._Params._UseSubsurfaceProfile;
				//     *(_OWORD *)&v5._glintData._GlintColor.g = v7;
				//     v9 = *(_OWORD *)&static_fields._LayerTypeData_k__BackingField._subsurfaceData._SubsurfaceProfile;
				//     *(_OWORD *)&v5._subsurfaceData._Params._UseSubsurfaceProfile = v8;
				//     v10 = *(_OWORD *)&static_fields._LayerTypeData_k__BackingField._fakeVolumeData._Params._FakeVolumeFresnelStrength;
				//     *(_OWORD *)&v5._subsurfaceData._SubsurfaceProfile = v9;
				//     FakeCrackTint = static_fields._LayerTypeData_k__BackingField._fakeVolumeData._Params._FakeCrackTint;
				//     *(_OWORD *)&v5._fakeVolumeData._Params._FakeVolumeFresnelStrength = v10;
				//     v12 = *(_OWORD *)&static_fields._LayerTypeData_k__BackingField._fakeVolumeData._Params._FakeCrackHeightScale;
				//     static_fields = (HGTerrainV2__StaticFields *)((char *)static_fields + 128);
				//     v5._fakeVolumeData._Params._FakeCrackTint = FakeCrackTint;
				//     v5 = (TerrainLayerTypeData *)((char *)v5 + 128);
				//     *(_OWORD *)&v5[-1]._fakeShadowData._FakeShadowStrength = v12;
				//     --v3;
				//   }
				//   while ( v3 );
				//   *(_OWORD *)&v5._glintData._EnableFakeGlint = *(_OWORD *)&static_fields._LayerTypeData_k__BackingField._glintData._EnableFakeGlint;
				//   return retstr;
				// }
				// 
				return null;
			}
			[CompilerGenerated]
			private set
			{
				// // Void set_LayerTypeData(TerrainLayerTypeData)
				// void HG::Rendering::Runtime::HGTerrainV2::set_LayerTypeData(TerrainLayerTypeData *value, MethodInfo *method)
				// {
				//   PassConstructorID__Enum__Array *v2; // r8
				//   HGCamera *v3; // r9
				//   HGTerrainV2__StaticFields *static_fields; // rcx
				//   __int64 v6; // rax
				//   __int128 v7; // xmm1
				//   __int128 v8; // xmm0
				//   __int128 v9; // xmm1
				//   __int128 v10; // xmm0
				//   __int128 v11; // xmm1
				//   Color FakeCrackTint; // xmm0
				//   __int128 v13; // xmm1
				//   MethodInfo *v14; // [rsp+50h] [rbp+28h]
				//   MethodInfo *v15; // [rsp+58h] [rbp+30h]
				// 
				//   if ( !byte_18D919742 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGTerrainV2);
				//     byte_18D919742 = 1;
				//   }
				//   static_fields = TypeInfo::HG::Rendering::Runtime::HGTerrainV2.static_fields;
				//   v6 = 2LL;
				//   do
				//   {
				//     v7 = *(_OWORD *)&value._glintData._GlintScale;
				//     *(_OWORD *)&static_fields._LayerTypeData_k__BackingField._glintData._EnableFakeGlint = *(_OWORD *)&value._glintData._EnableFakeGlint;
				//     v8 = *(_OWORD *)&value._glintData._GlintColor.g;
				//     *(_OWORD *)&static_fields._LayerTypeData_k__BackingField._glintData._GlintScale = v7;
				//     v9 = *(_OWORD *)&value._subsurfaceData._Params._UseSubsurfaceProfile;
				//     *(_OWORD *)&static_fields._LayerTypeData_k__BackingField._glintData._GlintColor.g = v8;
				//     v10 = *(_OWORD *)&value._subsurfaceData._SubsurfaceProfile;
				//     *(_OWORD *)&static_fields._LayerTypeData_k__BackingField._subsurfaceData._Params._UseSubsurfaceProfile = v9;
				//     v11 = *(_OWORD *)&value._fakeVolumeData._Params._FakeVolumeFresnelStrength;
				//     *(_OWORD *)&static_fields._LayerTypeData_k__BackingField._subsurfaceData._SubsurfaceProfile = v10;
				//     FakeCrackTint = value._fakeVolumeData._Params._FakeCrackTint;
				//     *(_OWORD *)&static_fields._LayerTypeData_k__BackingField._fakeVolumeData._Params._FakeVolumeFresnelStrength = v11;
				//     v13 = *(_OWORD *)&value._fakeVolumeData._Params._FakeCrackHeightScale;
				//     value = (TerrainLayerTypeData *)((char *)value + 128);
				//     static_fields._LayerTypeData_k__BackingField._fakeVolumeData._Params._FakeCrackTint = FakeCrackTint;
				//     static_fields = (HGTerrainV2__StaticFields *)((char *)static_fields + 128);
				//     *(_OWORD *)&static_fields[-1]._LayerTypeData_k__BackingField._fakeShadowData._FakeShadowStrength = v13;
				//     --v6;
				//   }
				//   while ( v6 );
				//   *(_OWORD *)&static_fields._LayerTypeData_k__BackingField._glintData._EnableFakeGlint = *(_OWORD *)&value._glintData._EnableFakeGlint;
				//   sub_1800054D0(
				//     (HGRenderPathScene *)&TypeInfo::HG::Rendering::Runtime::HGTerrainV2.static_fields._LayerTypeData_k__BackingField._subsurfaceData._SubsurfaceProfile,
				//     (HGRenderPathBase_HGRenderPathResources *)0x80,
				//     v2,
				//     v3,
				//     v14,
				//     v15);
				// }
				// 
			}
		}

		// (get) Token: 0x0600164F RID: 5711 RVA: 0x000025D8 File Offset: 0x000007D8
		public static bool NewEditorTerrainRendering
		{
			get
			{
				// // Boolean get_ring()
				// bool Beyond::Gameplay::Factory::WireRendererInfoCollection<Beyond::Gameplay::Factory::WireRendererInfo>::get_ring(
				//         WireRendererInfoCollection_1_WireRendererInfo_ *this,
				//         MethodInfo *method)
				// {
				//   return 0;
				// }
				// 
				return default(bool);
			}
		}

		public HGTerrainV2()
		{
			// // Singleton`1[System.Object]()
			// void RootMotion::Singleton<System::Object>::Singleton(Singleton_1_System_Object__1 *this, MethodInfo *method)
			// {
			//   UnityEngine::Component::Component((Component *)this, 0LL);
			// }
			// 
		}

		public void SetupFromParams_Phase0(ref TerrainInfo terrainInfo, NativeArray<SplatLayerData> layerDataArray, NativeArray<TerrainNodeData> nodeDataArray, NativeArray<ulong> sectorSplatInfoArray, string atlasPageRootPath)
		{
			// // Void SetupFromParams_Phase0(TerrainInfo ByRef, NativeArray`1[UnityEngine.HyperGryph.SplatLayerData], NativeArray`1[UnityEngine.HyperGryph.TerrainNodeData], NativeArray`1[System.UInt64], String)
			// void HG::Rendering::Runtime::HGTerrainV2::SetupFromParams_Phase0(
			//         HGTerrainV2 *this,
			//         TerrainInfo *terrainInfo,
			//         NativeArray_1_UnityEngine_HyperGryph_SplatLayerData_ *layerDataArray,
			//         NativeArray_1_UnityEngine_HyperGryph_TerrainNodeData_ *nodeDataArray,
			//         NativeArray_1_System_UInt64_ *sectorSplatInfoArray,
			//         String *atlasPageRootPath,
			//         MethodInfo *method)
			// {
			//   HGRenderPathBase_HGRenderPathResources *v11; // rdx
			//   PassConstructorID__Enum__Array *v12; // r8
			//   HGCamera *v13; // r9
			//   __int128 v14; // xmm1
			//   NativeArray_1_UnityEngine_HyperGryph_SplatLayerData_ v15; // xmm0
			//   __int64 v16; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   NativeArray_1_UnityEngine_HyperGryph_TerrainNodeData_ v18; // xmm1
			//   NativeArray_1_UnityEngine_HyperGryph_SplatLayerData_ v19; // xmm0
			//   MethodInfo *v20; // [rsp+20h] [rbp-58h]
			//   MethodInfo *v21; // [rsp+28h] [rbp-50h]
			//   NativeArray_1_System_UInt64_ v22; // [rsp+40h] [rbp-38h] BYREF
			//   NativeArray_1_UnityEngine_HyperGryph_TerrainNodeData_ v23; // [rsp+50h] [rbp-28h] BYREF
			//   NativeArray_1_UnityEngine_HyperGryph_SplatLayerData_ v24; // [rsp+60h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D8EDB77 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGTerrainV2::_SetupFromParams_Phase0_g__CopyNativeArray_16_0<UnityEngine::HyperGryph::SplatLayerData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGTerrainV2::_SetupFromParams_Phase0_g__CopyNativeArray_16_0<UnityEngine::HyperGryph::TerrainNodeData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGTerrainV2::_SetupFromParams_Phase0_g__CopyNativeArray_16_0<unsigned long>);
			//     byte_18D8EDB77 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3427, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3427, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v16);
			//     v18 = *nodeDataArray;
			//     v22 = *sectorSplatInfoArray;
			//     v19 = *layerDataArray;
			//     v23 = v18;
			//     v24 = v19;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1219(
			//       Patch,
			//       (Object *)this,
			//       terrainInfo,
			//       &v24,
			//       &v23,
			//       &v22,
			//       (Object *)atlasPageRootPath,
			//       0LL);
			//   }
			//   else
			//   {
			//     this.fields.atlasPageRootPathField = atlasPageRootPath;
			//     sub_1800054D0((HGRenderPathScene *)&this.fields.atlasPageRootPathField, v11, v12, v13, v20, v21);
			//     v14 = *(_OWORD *)&terrainInfo.terrainSize;
			//     *(_OWORD *)&this.fields.m_terrainInfo.terrainPosition.x = *(_OWORD *)&terrainInfo.terrainPosition.x;
			//     v15 = *layerDataArray;
			//     *(_OWORD *)&this.fields.m_terrainInfo.terrainSize = v14;
			//     v22 = (NativeArray_1_System_UInt64_)v15;
			//     HG::Rendering::Runtime::HGTerrainV2::_SetupFromParams_Phase0_g__CopyNativeArray_16_0<UnityEngine::HyperGryph::SplatLayerData>(
			//       (NativeArray_1_UnityEngine_HyperGryph_SplatLayerData_ *)&v22,
			//       &this.fields.m_layerDataArray,
			//       MethodInfo::HG::Rendering::Runtime::HGTerrainV2::_SetupFromParams_Phase0_g__CopyNativeArray_16_0<UnityEngine::HyperGryph::SplatLayerData>);
			//     v22 = (NativeArray_1_System_UInt64_)*nodeDataArray;
			//     HG::Rendering::Runtime::HGTerrainV2::_SetupFromParams_Phase0_g__CopyNativeArray_16_0<UnityEngine::HyperGryph::TerrainNodeData>(
			//       (NativeArray_1_UnityEngine_HyperGryph_TerrainNodeData_ *)&v22,
			//       &this.fields.m_nodeDataArray,
			//       MethodInfo::HG::Rendering::Runtime::HGTerrainV2::_SetupFromParams_Phase0_g__CopyNativeArray_16_0<UnityEngine::HyperGryph::TerrainNodeData>);
			//     v22 = *sectorSplatInfoArray;
			//     HG::Rendering::Runtime::HGTerrainV2::_SetupFromParams_Phase0_g__CopyNativeArray_16_0<unsigned long>(
			//       &v22,
			//       &this.fields.m_sectorSplatInfoArray,
			//       MethodInfo::HG::Rendering::Runtime::HGTerrainV2::_SetupFromParams_Phase0_g__CopyNativeArray_16_0<unsigned long>);
			//     this.fields.m_phase0HasSetup = 1;
			//   }
			// }
			// 
		}

		public void SetupFromParams_Phase1(ref TerrainLayerTypeData layerTypeData, ComputeShader terrainCS, ComputeShader terrainRTCS, Shader terrainPS, Texture2D splatIndexMap, Texture2D[] diffuseTextures, Texture2D[] normalTextures, Texture2D[] coneMapTextures, int splatTier, bool enableHalfVTSize, bool enableHalfAtlasSize, GraphicsFormat mobileSplatControlFormat)
		{
			// // Void SetupFromParams_Phase1(TerrainLayerTypeData ByRef, ComputeShader, ComputeShader, Shader, Texture2D, Texture2D[], Texture2D[], Texture2D[], Int32, Boolean, Boolean, GraphicsFormat)
			// void HG::Rendering::Runtime::HGTerrainV2::SetupFromParams_Phase1(
			//         HGTerrainV2 *this,
			//         TerrainLayerTypeData *layerTypeData,
			//         ComputeShader *terrainCS,
			//         ComputeShader *terrainRTCS,
			//         Shader *terrainPS,
			//         Texture2D *splatIndexMap,
			//         Texture2D__Array *diffuseTextures,
			//         Texture2D__Array *normalTextures,
			//         Texture2D__Array *coneMapTextures,
			//         int32_t splatTier,
			//         bool enableHalfVTSize,
			//         bool enableHalfAtlasSize,
			//         GraphicsFormat__Enum mobileSplatControlFormat,
			//         MethodInfo *method)
			// {
			//   HGManagerContext *currentManagerContext; // rax
			//   HGRenderPathBase_HGRenderPathResources *v19; // rdx
			//   HGManagerContext *v20; // rbx
			//   ILFixDynamicMethodWrapper_2 *terrainStreamingManager_k__BackingField; // rcx
			//   bool v22; // si
			//   __int64 v23; // rdx
			//   HGRenderPipeline *currentPipeline; // rax
			//   NativeArray_1_UnityEngine_HyperGryph_TerrainNodeData_ m_nodeDataArray; // xmm1
			//   NativeArray_1_UnityEngine_HyperGryph_SplatLayerData_ m_layerDataArray; // xmm0
			//   PassConstructorID__Enum__Array *v27; // r8
			//   HGCamera *v28; // r9
			//   MethodInfo *P3; // [rsp+20h] [rbp-A8h]
			//   MethodInfo *P4; // [rsp+28h] [rbp-A0h]
			//   NativeArray_1_System_UInt64_ m_sectorSplatInfoArray; // [rsp+90h] [rbp-38h] BYREF
			//   NativeArray_1_UnityEngine_HyperGryph_TerrainNodeData_ v32; // [rsp+A0h] [rbp-28h] BYREF
			//   NativeArray_1_UnityEngine_HyperGryph_SplatLayerData_ v33; // [rsp+B0h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D8EDB78 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGTerrainV2::_SetupFromParams_Phase1_g__CleanupNativeArrays_17_0<UnityEngine::HyperGryph::SplatLayerData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGTerrainV2::_SetupFromParams_Phase1_g__CleanupNativeArrays_17_0<UnityEngine::HyperGryph::TerrainNodeData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGTerrainV2::_SetupFromParams_Phase1_g__CleanupNativeArrays_17_0<unsigned long>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     byte_18D8EDB78 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3428, 0LL) )
			//   {
			//     HG::Rendering::Runtime::HGTerrainV2::UpdateLayerTypeData(layerTypeData, 0LL);
			//     currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//     v20 = currentManagerContext;
			//     if ( currentManagerContext )
			//     {
			//       terrainStreamingManager_k__BackingField = (ILFixDynamicMethodWrapper_2 *)currentManagerContext.fields._terrainStreamingManager_k__BackingField;
			//       if ( !terrainStreamingManager_k__BackingField )
			//         goto LABEL_6;
			//       HG::Rendering::Runtime::HGTerrainStreamingManager::Dispose(
			//         (HGTerrainStreamingManager *)terrainStreamingManager_k__BackingField,
			//         0LL);
			//     }
			//     v22 = 0;
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipeline._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline, v19);
			//     if ( HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL) )
			//     {
			//       if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipeline._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline, v23);
			//       currentPipeline = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
			//       if ( !currentPipeline )
			//         goto LABEL_6;
			//       terrainStreamingManager_k__BackingField = (ILFixDynamicMethodWrapper_2 *)currentPipeline.fields._settingParameters_k__BackingField;
			//       if ( !terrainStreamingManager_k__BackingField )
			//         goto LABEL_6;
			//       v22 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//               (SettingParameter_1_System_Boolean_ *)terrainStreamingManager_k__BackingField[30].klass,
			//               MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     }
			//     m_nodeDataArray = this.fields.m_nodeDataArray;
			//     m_sectorSplatInfoArray = this.fields.m_sectorSplatInfoArray;
			//     m_layerDataArray = this.fields.m_layerDataArray;
			//     v32 = m_nodeDataArray;
			//     v33 = m_layerDataArray;
			//     UnityEngine::HyperGryph::HGTerrainManager::SetupTerrainManager(
			//       &this.fields.m_terrainInfo,
			//       terrainCS,
			//       terrainRTCS,
			//       terrainPS,
			//       splatIndexMap,
			//       &v33,
			//       diffuseTextures,
			//       normalTextures,
			//       coneMapTextures,
			//       splatTier,
			//       &v32,
			//       &m_sectorSplatInfoArray,
			//       enableHalfVTSize,
			//       enableHalfAtlasSize,
			//       mobileSplatControlFormat,
			//       v22,
			//       0LL);
			//     if ( !v20 )
			//     {
			// LABEL_19:
			//       HG::Rendering::Runtime::HGTerrainV2::_SetupFromParams_Phase1_g__CleanupNativeArrays_17_0<unsigned long>(
			//         (NativeArray_1_System_UInt64_ *)&this.fields.m_layerDataArray,
			//         MethodInfo::HG::Rendering::Runtime::HGTerrainV2::_SetupFromParams_Phase1_g__CleanupNativeArrays_17_0<UnityEngine::HyperGryph::SplatLayerData>);
			//       HG::Rendering::Runtime::HGTerrainV2::_SetupFromParams_Phase1_g__CleanupNativeArrays_17_0<unsigned long>(
			//         (NativeArray_1_System_UInt64_ *)&this.fields.m_nodeDataArray,
			//         MethodInfo::HG::Rendering::Runtime::HGTerrainV2::_SetupFromParams_Phase1_g__CleanupNativeArrays_17_0<UnityEngine::HyperGryph::TerrainNodeData>);
			//       HG::Rendering::Runtime::HGTerrainV2::_SetupFromParams_Phase1_g__CleanupNativeArrays_17_0<unsigned long>(
			//         &this.fields.m_sectorSplatInfoArray,
			//         MethodInfo::HG::Rendering::Runtime::HGTerrainV2::_SetupFromParams_Phase1_g__CleanupNativeArrays_17_0<unsigned long>);
			//       this.fields.m_phase0HasSetup = 0;
			//       return;
			//     }
			//     terrainStreamingManager_k__BackingField = (ILFixDynamicMethodWrapper_2 *)v20.fields._terrainStreamingManager_k__BackingField;
			//     if ( terrainStreamingManager_k__BackingField )
			//     {
			//       terrainStreamingManager_k__BackingField[1].monitor = (MonitorData *)this.fields.atlasPageRootPathField;
			//       sub_1800054D0((HGRenderPathScene *)&terrainStreamingManager_k__BackingField[1].monitor, v19, v27, v28, P3, P4);
			//       goto LABEL_19;
			//     }
			// LABEL_6:
			//     sub_180B536AC(terrainStreamingManager_k__BackingField, v19);
			//   }
			//   terrainStreamingManager_k__BackingField = IFix::WrappersManagerImpl::GetPatch(3428, 0LL);
			//   if ( !terrainStreamingManager_k__BackingField )
			//     goto LABEL_6;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1220(
			//     terrainStreamingManager_k__BackingField,
			//     (Object *)this,
			//     layerTypeData,
			//     (Object *)terrainCS,
			//     (Object *)terrainRTCS,
			//     (Object *)terrainPS,
			//     (Object *)splatIndexMap,
			//     (Object *)diffuseTextures,
			//     (Object *)normalTextures,
			//     (Object *)coneMapTextures,
			//     splatTier,
			//     enableHalfVTSize,
			//     enableHalfAtlasSize,
			//     mobileSplatControlFormat,
			//     0LL);
			// }
			// 
		}

		public void Cleanup()
		{
			// // Void Cleanup()
			// void HG::Rendering::Runtime::HGTerrainV2::Cleanup(HGTerrainV2 *this, MethodInfo *method)
			// {
			//   HGManagerContext *currentManagerContext; // rax
			//   __int64 v4; // rdx
			//   HGTerrainStreamingManager *terrainStreamingManager_k__BackingField; // rcx
			//   __int64 v6; // rdx
			//   _OWORD *v7; // rax
			//   _OWORD *v8; // rcx
			//   __int128 v9; // xmm1
			//   __int128 v10; // xmm0
			//   __int128 v11; // xmm1
			//   __int128 v12; // xmm0
			//   __int128 v13; // xmm1
			//   __int128 v14; // xmm0
			//   __int128 v15; // xmm1
			//   HGManagerContext *v16; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   _BYTE v18[272]; // [rsp+20h] [rbp-228h] BYREF
			//   _BYTE v19[280]; // [rsp+130h] [rbp-118h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3429, 0LL) )
			//   {
			//     currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//     if ( currentManagerContext )
			//     {
			//       terrainStreamingManager_k__BackingField = currentManagerContext.fields._terrainStreamingManager_k__BackingField;
			//       if ( !terrainStreamingManager_k__BackingField )
			//         goto LABEL_13;
			//       HG::Rendering::Runtime::HGTerrainStreamingManager::Dispose(terrainStreamingManager_k__BackingField, 0LL);
			//     }
			//     UnityEngine::HyperGryph::HGTerrainManager::CleanupTerrainManager(0LL);
			//     sub_1802F01E0(v18, 0LL, 272LL);
			//     v6 = 2LL;
			//     v7 = v19;
			//     v8 = v18;
			//     do
			//     {
			//       v9 = v8[1];
			//       *v7 = *v8;
			//       v10 = v8[2];
			//       v7[1] = v9;
			//       v11 = v8[3];
			//       v7[2] = v10;
			//       v12 = v8[4];
			//       v7[3] = v11;
			//       v13 = v8[5];
			//       v7[4] = v12;
			//       v14 = v8[6];
			//       v7[5] = v13;
			//       v15 = v8[7];
			//       v8 += 8;
			//       v7[6] = v14;
			//       v7 += 8;
			//       *(v7 - 1) = v15;
			//       --v6;
			//     }
			//     while ( v6 );
			//     *v7 = *v8;
			//     sub_182C51100(v19, 0LL, 128LL);
			//     if ( !HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL) )
			//       goto LABEL_11;
			//     v16 = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//     if ( v16 )
			//     {
			//       terrainStreamingManager_k__BackingField = (HGTerrainStreamingManager *)v16.fields._subsurfaceProfileManager_k__BackingField;
			//       if ( terrainStreamingManager_k__BackingField )
			//       {
			//         HG::Rendering::Runtime::SubsurfaceProfileManager::UnregisterFromTerrain(
			//           (SubsurfaceProfileManager *)terrainStreamingManager_k__BackingField,
			//           0LL);
			// LABEL_11:
			//         UnityEngine::HyperGryph::HGSubsurfaceProfileManager::UnregisterFromTerrain(0LL);
			//         this.fields.m_phase0HasSetup = 0;
			//         return;
			//       }
			//     }
			// LABEL_13:
			//     sub_180B536AC(terrainStreamingManager_k__BackingField, v4);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3429, 0LL);
			//   if ( !Patch )
			//     goto LABEL_13;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		private static void UpdateLayerTypeData(ref TerrainLayerTypeData data)
		{
			// // Void UpdateLayerTypeData(TerrainLayerTypeData ByRef)
			// void HG::Rendering::Runtime::HGTerrainV2::UpdateLayerTypeData(TerrainLayerTypeData *data, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   __int64 v4; // r8
			//   __int64 v5; // rdi
			//   _OWORD *v6; // rax
			//   __int64 v7; // rcx
			//   __int128 v8; // xmm0
			//   __int128 v9; // xmm1
			//   __int128 v10; // xmm0
			//   __int128 v11; // xmm1
			//   __int128 v12; // xmm0
			//   __int128 v13; // xmm1
			//   __int128 v14; // xmm0
			//   __int128 v15; // xmm1
			//   HGManagerContext *currentManagerContext; // rax
			//   __int128 *v17; // rdx
			//   __int64 v18; // rcx
			//   SubsurfaceProfileManager *subsurfaceProfileManager_k__BackingField; // rbx
			//   __int128 *v20; // rax
			//   __int128 v21; // xmm0
			//   __int128 v22; // xmm1
			//   __int128 v23; // xmm0
			//   __int128 v24; // xmm1
			//   __int128 v25; // xmm0
			//   __int128 v26; // xmm1
			//   __int128 v27; // xmm0
			//   __int128 v28; // xmm1
			//   __int128 *v29; // rax
			//   __int128 *v30; // rcx
			//   __int128 v31; // xmm0
			//   __int128 v32; // xmm1
			//   __int128 v33; // xmm0
			//   __int128 v34; // xmm1
			//   __int128 v35; // xmm0
			//   __int128 v36; // xmm1
			//   __int128 v37; // xmm0
			//   __int128 v38; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   _BYTE v40[64]; // [rsp+20h] [rbp-228h] BYREF
			//   HGSubsurfaceProfile *profile; // [rsp+60h] [rbp-1E8h]
			//   _BYTE v42[280]; // [rsp+130h] [rbp-118h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3431, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3431, 0LL);
			//     if ( !Patch )
			//       goto LABEL_9;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1221(Patch, data, 0LL);
			//   }
			//   else
			//   {
			//     v5 = 2LL;
			//     v6 = v40;
			//     v7 = 2LL;
			//     do
			//     {
			//       v6 += 8;
			//       v8 = *(_OWORD *)&data._glintData._EnableFakeGlint;
			//       v9 = *(_OWORD *)&data._glintData._GlintScale;
			//       data = (TerrainLayerTypeData *)((char *)data + 128);
			//       *(v6 - 8) = v8;
			//       v10 = *(_OWORD *)&data[-1]._fakeVolumeData._Params._FakeRefractionHeightScale;
			//       *(v6 - 7) = v9;
			//       v11 = *(_OWORD *)&data[-1]._fakeVolumeData._Params._FakeDustDepth;
			//       *(v6 - 6) = v10;
			//       v12 = *(_OWORD *)&data[-1]._fakeVolumeData._Params._FakeDustFlowSpeed.w;
			//       *(v6 - 5) = v11;
			//       v13 = *(_OWORD *)&data[-1]._fakeVolumeData._Params._FakeDustTint.a;
			//       *(v6 - 4) = v12;
			//       v14 = *(_OWORD *)&data[-1]._fakeVolumeData._FakeVolumeMask;
			//       *(v6 - 3) = v13;
			//       v15 = *(_OWORD *)&data[-1]._fakeShadowData._FakeShadowStrength;
			//       *(v6 - 2) = v14;
			//       *(v6 - 1) = v15;
			//       --v7;
			//     }
			//     while ( v7 );
			//     *v6 = *(_OWORD *)&data._glintData._EnableFakeGlint;
			//     sub_182C51100(v40, v3, v4);
			//     if ( HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL) )
			//     {
			//       currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//       if ( !currentManagerContext )
			//         goto LABEL_9;
			//       subsurfaceProfileManager_k__BackingField = currentManagerContext.fields._subsurfaceProfileManager_k__BackingField;
			//       v20 = (__int128 *)sub_182C50540(v42);
			//       v17 = (__int128 *)v40;
			//       v18 = 2LL;
			//       do
			//       {
			//         v17 += 8;
			//         v21 = *v20;
			//         v22 = v20[1];
			//         v20 += 8;
			//         *(v17 - 8) = v21;
			//         v23 = *(v20 - 6);
			//         *(v17 - 7) = v22;
			//         v24 = *(v20 - 5);
			//         *(v17 - 6) = v23;
			//         v25 = *(v20 - 4);
			//         *(v17 - 5) = v24;
			//         v26 = *(v20 - 3);
			//         *(v17 - 4) = v25;
			//         v27 = *(v20 - 2);
			//         *(v17 - 3) = v26;
			//         v28 = *(v20 - 1);
			//         *(v17 - 2) = v27;
			//         *(v17 - 1) = v28;
			//         --v18;
			//       }
			//       while ( v18 );
			//       *v17 = *v20;
			//       if ( !subsurfaceProfileManager_k__BackingField )
			// LABEL_9:
			//         sub_180B536AC(v18, v17);
			//       HG::Rendering::Runtime::SubsurfaceProfileManager::RegisterFromTerrain(
			//         subsurfaceProfileManager_k__BackingField,
			//         profile,
			//         0LL);
			//     }
			//     v29 = (__int128 *)sub_182C50540(v42);
			//     v30 = (__int128 *)v40;
			//     do
			//     {
			//       v30 += 8;
			//       v31 = *v29;
			//       v32 = v29[1];
			//       v29 += 8;
			//       *(v30 - 8) = v31;
			//       v33 = *(v29 - 6);
			//       *(v30 - 7) = v32;
			//       v34 = *(v29 - 5);
			//       *(v30 - 6) = v33;
			//       v35 = *(v29 - 4);
			//       *(v30 - 5) = v34;
			//       v36 = *(v29 - 3);
			//       *(v30 - 4) = v35;
			//       v37 = *(v29 - 2);
			//       *(v30 - 3) = v36;
			//       v38 = *(v29 - 1);
			//       *(v30 - 2) = v37;
			//       *(v30 - 1) = v38;
			//       --v5;
			//     }
			//     while ( v5 );
			//     *v30 = *v29;
			//     UnityEngine::HyperGryph::HGSubsurfaceProfileManager::RegisterFromTerrain(profile, 0LL);
			//   }
			// }
			// 
		}

		public static void GenerateConeMapMipmaps(ComputeShader cs, Texture2D[] coneMapTextures)
		{
			// // Void GenerateConeMapMipmaps(ComputeShader, Texture2D[])
			// void HG::Rendering::Runtime::HGTerrainV2::GenerateConeMapMipmaps(
			//         ComputeShader *cs,
			//         Texture2D__Array *coneMapTextures,
			//         MethodInfo *method)
			// {
			//   Texture2D__Array *v3; // rbx
			//   __int64 v5; // rdx
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   int32_t i; // esi
			//   Object_1 *v9; // rdi
			//   int v10; // r14d
			//   int v11; // esi
			//   int32_t anisoLevel; // ebp
			//   FilterMode__Enum filterMode; // edi
			//   Texture *v14; // rax
			//   RenderTexture *v15; // r12
			//   __int64 v16; // rdx
			//   CommandBuffer *v17; // rsi
			//   int32_t j; // r15d
			//   Object_1 *v19; // rbp
			//   int k; // edi
			//   int v21; // ebx
			//   RenderTargetIdentifier *v22; // rax
			//   __int64 v23; // rdx
			//   __int64 v24; // rcx
			//   __int128 v25; // xmm1
			//   __int64 v26; // xmm0_8
			//   RenderTargetIdentifier *v27; // rax
			//   __int128 v28; // xmm1
			//   unsigned int v29; // r12d
			//   void (__fastcall *v30)(CommandBuffer *, ComputeShader *, _QWORD, _QWORD, RenderTargetIdentifier *, _DWORD, int, int); // rax
			//   int32_t v31; // eax
			//   __m128 v32; // xmm0
			//   __m128 v33; // xmm0
			//   RenderTargetIdentifier *v34; // rax
			//   __int128 v35; // xmm7
			//   __int128 v36; // xmm8
			//   __int64 v37; // xmm6_8
			//   RenderTargetIdentifier *v38; // rax
			//   __int128 v39; // xmm1
			//   void (__fastcall *v40)(CommandBuffer *, RenderTargetIdentifier *, _QWORD, _QWORD, _DWORD, _DWORD, int, int, RenderTargetIdentifier *, _DWORD, int, _DWORD, _DWORD, int); // rax
			//   __int64 v41; // rdx
			//   Object *name; // rax
			//   __int64 v43; // rax
			//   __int64 v44; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   int v46; // [rsp+70h] [rbp-138h]
			//   Vector4 v47; // [rsp+80h] [rbp-128h]
			//   RenderTargetIdentifier v48; // [rsp+90h] [rbp-118h] BYREF
			//   Texture *v49; // [rsp+C0h] [rbp-E8h]
			//   RenderTargetIdentifier v50; // [rsp+D0h] [rbp-D8h] BYREF
			//   Vector4 val; // [rsp+100h] [rbp-A8h] BYREF
			//   RenderTargetIdentifier v52; // [rsp+110h] [rbp-98h] BYREF
			//   unsigned int kernelIndex; // [rsp+1C8h] [rbp+20h]
			// 
			//   v3 = coneMapTextures;
			//   if ( !byte_18D8EDB79 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::CommandBufferPool);
			//     sub_18003C530(&TypeInfo::UnityEngine::Graphics);
			//     sub_18003C530(&MethodInfo::HG::Rendering::HGRPLogger::LogError<System::String>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::UnityEngine::RenderTexture);
			//     sub_18003C530(&off_18C8F3558);
			//     sub_18003C530(&off_18C909C40);
			//     sub_18003C530(&off_18C909C48);
			//     sub_18003C530(&off_18C909C50);
			//     sub_18003C530(&off_18C909C58);
			//     sub_18003C530(&off_18C909C60);
			//     byte_18D8EDB79 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3432, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3432, 0LL);
			//     if ( !Patch )
			//       goto LABEL_16;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)cs,
			//       (Object *)v3,
			//       0LL);
			//   }
			//   else
			//   {
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v5);
			//     if ( !UnityEngine::Object::op_Equality((Object_1 *)cs, 0LL, 0LL) && v3 )
			//     {
			//       for ( i = 0; ; ++i )
			//       {
			//         if ( i >= v3.max_length.size )
			//           return;
			//         if ( (unsigned int)i >= v3.max_length.size )
			// LABEL_50:
			//           sub_180070270(v7, v6);
			//         v9 = (Object_1 *)v3.vector[i];
			//         if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//           il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v6);
			//         if ( UnityEngine::Object::op_Inequality(v9, 0LL, 0LL) )
			//           break;
			//       }
			//       if ( !v9 )
			// LABEL_16:
			//         sub_180B536AC(v7, v6);
			//       v46 = sub_18003ED00(5LL);
			//       v10 = v46;
			//       v11 = sub_18003ED00(7LL);
			//       anisoLevel = UnityEngine::Texture::get_anisoLevel((Texture *)v9, 0LL);
			//       filterMode = UnityEngine::Texture::get_filterMode((Texture *)v9, 0LL);
			//       if ( v46 )
			//       {
			//         if ( !cs )
			//           goto LABEL_16;
			//         kernelIndex = UnityEngine::ComputeShader::FindKernel(cs, (String *)"BuildSingleTextureMipmap", 0LL);
			//         v14 = (Texture *)sub_180004920(TypeInfo::UnityEngine::RenderTexture);
			//         v49 = v14;
			//         v15 = (RenderTexture *)v14;
			//         if ( !v14 )
			//           goto LABEL_16;
			//         UnityEngine::RenderTexture::RenderTexture(
			//           (RenderTexture *)v14,
			//           v46 >> 1,
			//           v11 >> 1,
			//           0,
			//           GraphicsFormat__Enum_R8_UNorm,
			//           0LL);
			//         sub_1800491C0(10LL, v15, 2LL);
			//         UnityEngine::RenderTexture::set_volumeDepth(v15, 1, 0LL);
			//         UnityEngine::Texture::set_anisoLevel((Texture *)v15, anisoLevel, 0LL);
			//         UnityEngine::Texture::set_filterMode((Texture *)v15, filterMode, 0LL);
			//         UnityEngine::Texture::set_wrapMode((Texture *)v15, TextureWrapMode__Enum_Repeat, 0LL);
			//         UnityEngine::RenderTexture::set_autoGenerateMips(v15, 0, 0LL);
			//         UnityEngine::RenderTexture::set_useMipMap(v15, 0, 0LL);
			//         UnityEngine::RenderTexture::set_enableRandomWrite(v15, 1, 0LL);
			//         UnityEngine::Object::set_name((Object_1 *)v15, (String *)"HGTerrainConvertFunc.coneMapMipmapHelper", 0LL);
			//         UnityEngine::RenderTexture::Create(v15, 0LL);
			//         if ( !TypeInfo::UnityEngine::Rendering::CommandBufferPool._1.cctor_finished_or_no_cctor )
			//           il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Rendering::CommandBufferPool, v16);
			//         v17 = UnityEngine::Rendering::CommandBufferPool::Get(0LL);
			//         for ( j = 0; j < v3.max_length.size; ++j )
			//         {
			//           if ( (unsigned int)j >= v3.max_length.size )
			//             goto LABEL_50;
			//           v19 = (Object_1 *)v3.vector[j];
			//           if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//             il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v6);
			//           if ( !UnityEngine::Object::op_Equality(v19, 0LL, 0LL) )
			//           {
			//             if ( !v19 )
			//               goto LABEL_16;
			//             if ( UnityEngine::Texture2D::get_format((Texture2D *)v19, 0LL) != TextureFormat__Enum_R8
			//               || UnityEngine::Texture::get_isDataSRGB((Texture *)v19, 0LL) )
			//             {
			//               name = (Object *)UnityEngine::Object::get_name(v19, 0LL);
			//               HG::Rendering::HGRPLogger::LogError<System::Object>(
			//                 (String *)"Terrain cone map {0} is SRGB or not R8 format, this should not happen",
			//                 name,
			//                 MethodInfo::HG::Rendering::HGRPLogger::LogError<System::String>);
			//             }
			//             else
			//             {
			//               for ( k = 0; k < UnityEngine::Texture::get_mipmapCount((Texture *)v19, 0LL) - 1; ++k )
			//               {
			//                 v21 = v10 >> 1;
			//                 v22 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v50, (Texture *)v19, 0LL);
			//                 if ( !v17 )
			//                   sub_180B536AC(v24, v23);
			//                 v25 = *(_OWORD *)&v22.m_BufferPointer;
			//                 *(_OWORD *)&v48.m_Type = *(_OWORD *)&v22.m_Type;
			//                 v26 = *(_QWORD *)&v22.m_DepthSlice;
			//                 *(_OWORD *)&v48.m_BufferPointer = v25;
			//                 *(_QWORD *)&v48.m_DepthSlice = v26;
			//                 UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(
			//                   v17,
			//                   cs,
			//                   kernelIndex,
			//                   (String *)"_SrcMip",
			//                   &v48,
			//                   0LL);
			//                 v27 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v50, (Texture *)v15, 0LL);
			//                 v28 = *(_OWORD *)&v27.m_BufferPointer;
			//                 *(_OWORD *)&v48.m_Type = *(_OWORD *)&v27.m_Type;
			//                 *(_QWORD *)&v48.m_DepthSlice = *(_QWORD *)&v27.m_DepthSlice;
			//                 *(_OWORD *)&v48.m_BufferPointer = v28;
			//                 v29 = UnityEngine::Shader::PropertyToID((String *)"_TempDstMip", 0LL);
			//                 v30 = (void (__fastcall *)(CommandBuffer *, ComputeShader *, _QWORD, _QWORD, RenderTargetIdentifier *, _DWORD, int, int))qword_18D8F55C0;
			//                 if ( !qword_18D8F55C0 )
			//                 {
			//                   v30 = (void (__fastcall *)(CommandBuffer *, ComputeShader *, _QWORD, _QWORD, RenderTargetIdentifier *, _DWORD, int, int))il2cpp_resolve_icall_0("UnityEngine.Rendering.CommandBuffer::Internal_SetComputeTextureParam(UnityEngine.ComputeShader,System.Int32,System.Int32,UnityEngine.Rendering.RenderTargetIdentifier&,System.Int32,UnityEngine.Rendering.RenderTextureSubElement,System.Int32)");
			//                   if ( !v30 )
			//                   {
			//                     v43 = sub_1802DBBE8(
			//                             "UnityEngine.Rendering.CommandBuffer::Internal_SetComputeTextureParam(UnityEngine.ComputeShad"
			//                             "er,System.Int32,System.Int32,UnityEngine.Rendering.RenderTargetIdentifier&,System.Int32,Unit"
			//                             "yEngine.Rendering.RenderTextureSubElement,System.Int32)");
			//                     sub_18000F750(v43, 0LL);
			//                   }
			//                   qword_18D8F55C0 = (__int64)v30;
			//                 }
			//                 v30(v17, cs, kernelIndex, v29, &v48, 0, 3, -1);
			//                 v31 = UnityEngine::Shader::PropertyToID((String *)"_DstMipSize", 0LL);
			//                 v32 = (__m128)*(unsigned __int64 *)&v47.x;
			//                 v32.m128_f32[0] = (float)v21;
			//                 v33 = _mm_shuffle_ps(v32, v32, 225);
			//                 v33.m128_f32[0] = (float)k;
			//                 v47 = (Vector4)_mm_shuffle_ps(v33, v33, 225);
			//                 val = v47;
			//                 UnityEngine::Rendering::CommandBuffer::SetComputeVectorParam_Injected(v17, cs, v31, &val, 0LL);
			//                 UnityEngine::Rendering::CommandBuffer::Internal_DispatchCompute(
			//                   v17,
			//                   cs,
			//                   kernelIndex,
			//                   (v21 + 7) / 8,
			//                   (v21 + 7) / 8,
			//                   1,
			//                   0LL);
			//                 v15 = (RenderTexture *)v49;
			//                 v34 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v50, v49, 0LL);
			//                 v35 = *(_OWORD *)&v34.m_Type;
			//                 v36 = *(_OWORD *)&v34.m_BufferPointer;
			//                 v37 = *(_QWORD *)&v34.m_DepthSlice;
			//                 v38 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v52, (Texture *)v19, 0LL);
			//                 *(_OWORD *)&v50.m_Type = v35;
			//                 *(_OWORD *)&v50.m_BufferPointer = v36;
			//                 *(_QWORD *)&v50.m_DepthSlice = v37;
			//                 v39 = *(_OWORD *)&v38.m_BufferPointer;
			//                 *(_OWORD *)&v48.m_Type = *(_OWORD *)&v38.m_Type;
			//                 v33.m128_u64[0] = *(_QWORD *)&v38.m_DepthSlice;
			//                 v40 = (void (__fastcall *)(CommandBuffer *, RenderTargetIdentifier *, _QWORD, _QWORD, _DWORD, _DWORD, int, int, RenderTargetIdentifier *, _DWORD, int, _DWORD, _DWORD, int))qword_18D8F55D8;
			//                 *(_OWORD *)&v48.m_BufferPointer = v39;
			//                 *(_QWORD *)&v48.m_DepthSlice = v33.m128_u64[0];
			//                 if ( !qword_18D8F55D8 )
			//                 {
			//                   v40 = (void (__fastcall *)(CommandBuffer *, RenderTargetIdentifier *, _QWORD, _QWORD, _DWORD, _DWORD, int, int, RenderTargetIdentifier *, _DWORD, int, _DWORD, _DWORD, int))il2cpp_resolve_icall_0("UnityEngine.Rendering.CommandBuffer::CopyTexture_Internal(UnityEngine.Rendering.RenderTargetIdentifier&,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,UnityEngine.Rendering.RenderTargetIdentifier&,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32)");
			//                   if ( !v40 )
			//                   {
			//                     v44 = sub_1802DBBE8(
			//                             "UnityEngine.Rendering.CommandBuffer::CopyTexture_Internal(UnityEngine.Rendering.RenderTarget"
			//                             "Identifier&,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,Un"
			//                             "ityEngine.Rendering.RenderTargetIdentifier&,System.Int32,System.Int32,System.Int32,System.In"
			//                             "t32,System.Int32)");
			//                     sub_18000F750(v44, 0LL);
			//                   }
			//                   qword_18D8F55D8 = (__int64)v40;
			//                 }
			//                 v40(v17, &v50, 0LL, 0LL, 0, 0, v10 >> 1, v10 >> 1, &v48, 0, k + 1, 0, 0, 4);
			//                 v10 >>= 1;
			//               }
			//               v3 = coneMapTextures;
			//               v10 = v46;
			//             }
			//           }
			//         }
			//         if ( !TypeInfo::UnityEngine::Graphics._1.cctor_finished_or_no_cctor )
			//           il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Graphics, v6);
			//         UnityEngine::Graphics::ExecuteCommandBuffer(v17, 0LL);
			//         if ( !TypeInfo::UnityEngine::Rendering::CommandBufferPool._1.cctor_finished_or_no_cctor )
			//           il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Rendering::CommandBufferPool, v41);
			//         UnityEngine::Rendering::CommandBufferPool::Release(v17, 0LL);
			//         UnityEngine::RenderTexture::Release(v15, 0LL);
			//       }
			//     }
			//   }
			// }
			// 
		}

		[CompilerGenerated]
		internal static void <SetupFromParams_Phase0>g__CopyNativeArray|16_0<T>(NativeArray<T> src, ref NativeArray<T> dst) where T : struct
		{
		}

		[CompilerGenerated]
		internal static void <SetupFromParams_Phase1>g__CleanupNativeArrays|17_0<T>(ref NativeArray<T> a) where T : struct
		{
		}

		public string atlasPageRootPathField;

		private TerrainInfo m_terrainInfo;

		private NativeArray<SplatLayerData> m_layerDataArray;

		private NativeArray<TerrainNodeData> m_nodeDataArray;

		private NativeArray<ulong> m_sectorSplatInfoArray;

		private bool m_phase0HasSetup;

		public NativeArray<AssetHandleIndex> splatDiffuseHandles;

		public NativeArray<AssetHandleIndex> splatNormalHandles;

		public NativeArray<AssetHandleIndex> splatConeMapHandles;

		[NonSerialized]
		public AssetHandleIndex buildConeMapCSHandle;
	}
}
