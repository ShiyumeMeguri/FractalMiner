using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Beyond.Resource;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	public class WaterSectorRenderingPass : IPassConstructor
	{
		internal WaterSectorRenderingPass()
		{
		}

		private bool ShouldRender(bool waterSectorRendering)
		{
			// // Boolean ShouldRender(Boolean)
			// bool HG::Rendering::Runtime::WaterSectorRenderingPass::ShouldRender(
			//         WaterSectorRenderingPass *this,
			//         bool waterSectorRendering,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2885, 0LL) )
			//     return waterSectorRendering;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2885, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v8, v7);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_84(
			//            (ILFixDynamicMethodWrapper_8 *)Patch,
			//            (Object *)this,
			//            waterSectorRendering,
			//            0LL);
			// }
			// 
			return default(bool);
		}

		private void Initialize(HGWaterGlobalConfig globalConfig)
		{
		}

		private void Release()
		{
			// // Void Release()
			// void HG::Rendering::Runtime::WaterSectorRenderingPass::Release(WaterSectorRenderingPass *this, MethodInfo *method)
			// {
			//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v3; // rdx
			//   WaterSectorRenderingPass_SectorNode__Array *v4; // rcx
			//   VolumetricRenderer_VolumetricBounds *v5; // r8
			//   Material *v6; // r9
			//   Queue_1_HG_Rendering_Runtime_WaterSectorRenderingPass_SectorLoadingNode_ *m_pendingLoadedQueue; // rax
			//   Queue_1_System_Int32_ *m_pendingCopyQueue; // rax
			//   Queue_1_System_Int32_ *m_pendingUnloadQueue; // rax
			//   unsigned int i; // edi
			//   WaterSectorRenderingPass_SectorNode__Array *m_waterSectors; // rax
			//   WaterSectorRenderingPass_SectorNode *v12; // rax
			//   _BYTE *v13; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   WaterSectorRenderingPass_SectorLoadingNode v15; // [rsp+20h] [rbp-58h] BYREF
			//   WaterSectorRenderingPass_SectorLoadingNode v16; // [rsp+48h] [rbp-30h] BYREF
			// 
			//   if ( !byte_18D8EDADA )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Queue<HG::Rendering::Runtime::WaterSectorRenderingPass::SectorLoadingNode>::Dequeue);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Queue<int>::Dequeue);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Queue<HG::Rendering::Runtime::WaterSectorRenderingPass::SectorLoadingNode>::Peek);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Queue<HG::Rendering::Runtime::WaterSectorRenderingPass::SectorLoadingNode>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Queue<int>::get_Count);
			//     byte_18D8EDADA = 1;
			//   }
			//   memset(&v15, 0, sizeof(v15));
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2891, 0LL) )
			//   {
			//     if ( this.fields.m_waterSectors )
			//     {
			//       for ( i = 0; ; ++i )
			//       {
			//         m_waterSectors = this.fields.m_waterSectors;
			//         if ( !m_waterSectors )
			//           break;
			//         if ( i >= (__int64)m_waterSectors.max_length.size )
			//           goto LABEL_5;
			//         v12 = (WaterSectorRenderingPass_SectorNode *)sub_180444080(this.fields.m_waterSectors, i);
			//         HG::Rendering::Runtime::WaterSectorRenderingPass::SectorNode::Release(v12, 0LL);
			//         v4 = this.fields.m_waterSectors;
			//         if ( !v4 )
			//           break;
			//         v13 = (_BYTE *)sub_180444080(v4, i);
			//         *v13 = 0;
			//       }
			//     }
			//     else
			//     {
			// LABEL_5:
			//       this.fields.m_waterSectors = 0LL;
			//       sub_1800054D0(
			//         (VolumetricRenderer_VolumetricRenderItem *)&this.fields.m_waterSectors,
			//         v3,
			//         v5,
			//         v6,
			//         *(MethodInfo **)&v15.sectorIndex,
			//         (MethodInfo *)v15.texturePath,
			//         v15.assetHandle.m_untrackedHandle.m_handleObjectID,
			//         v15.assetHandle.m_untrackedHandle.m_assetProxyObj.m_handleID,
			//         *(float *)&v15.assetHandle.m_untrackedHandle.m_mainVersion,
			//         v16.sectorIndex,
			//         (bool)v16.texturePath,
			//         v16.assetHandle.m_untrackedHandle.m_handleObjectID,
			//         *(MethodInfo **)&v16.assetHandle.m_untrackedHandle.m_assetProxyObj.m_handleID);
			//       while ( 1 )
			//       {
			//         m_pendingLoadedQueue = this.fields.m_pendingLoadedQueue;
			//         if ( !m_pendingLoadedQueue )
			//           goto LABEL_7;
			//         if ( !m_pendingLoadedQueue.fields._size )
			//           break;
			//         System::Collections::Generic::Queue<HG::Rendering::Runtime::WaterSectorRenderingPass::SectorLoadingNode>::Peek(
			//           &v16,
			//           this.fields.m_pendingLoadedQueue,
			//           MethodInfo::System::Collections::Generic::Queue<HG::Rendering::Runtime::WaterSectorRenderingPass::SectorLoadingNode>::Peek);
			//         v15 = v16;
			//         HG::Rendering::Runtime::WaterSectorRenderingPass::SectorLoadingNode::Release(&v15, 0LL);
			//         v3 = (Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *)this.fields.m_pendingLoadedQueue;
			//         if ( !v3 )
			//           goto LABEL_7;
			//         System::Collections::Generic::Queue<HG::Rendering::Runtime::WaterSectorRenderingPass::SectorLoadingNode>::Dequeue(
			//           &v16,
			//           (Queue_1_HG_Rendering_Runtime_WaterSectorRenderingPass_SectorLoadingNode_ *)v3,
			//           MethodInfo::System::Collections::Generic::Queue<HG::Rendering::Runtime::WaterSectorRenderingPass::SectorLoadingNode>::Dequeue);
			//       }
			//       while ( 1 )
			//       {
			//         m_pendingCopyQueue = this.fields.m_pendingCopyQueue;
			//         if ( !m_pendingCopyQueue )
			//           goto LABEL_7;
			//         if ( !m_pendingCopyQueue.fields._size )
			//           break;
			//         System::Collections::Generic::Queue<System::Int32Enum>::Dequeue(
			//           (Queue_1_System_Int32Enum_ *)this.fields.m_pendingCopyQueue,
			//           MethodInfo::System::Collections::Generic::Queue<int>::Dequeue);
			//       }
			//       while ( 1 )
			//       {
			//         m_pendingUnloadQueue = this.fields.m_pendingUnloadQueue;
			//         if ( !m_pendingUnloadQueue )
			//           break;
			//         if ( !m_pendingUnloadQueue.fields._size )
			//           return;
			//         System::Collections::Generic::Queue<System::Int32Enum>::Dequeue(
			//           (Queue_1_System_Int32Enum_ *)this.fields.m_pendingUnloadQueue,
			//           MethodInfo::System::Collections::Generic::Queue<int>::Dequeue);
			//       }
			//     }
			// LABEL_7:
			//     sub_180B536AC(v4, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2891, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		private void ResizeTextures()
		{
		}

		private void ReleaseTextures()
		{
			// // Void ReleaseTextures()
			// void HG::Rendering::Runtime::WaterSectorRenderingPass::ReleaseTextures(
			//         WaterSectorRenderingPass *this,
			//         MethodInfo *method)
			// {
			//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v3; // rdx
			//   VolumetricRenderer_VolumetricBounds *v4; // r8
			//   Material *v5; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   MethodInfo *v9; // [rsp+50h] [rbp+28h]
			//   MethodInfo *v10; // [rsp+58h] [rbp+30h]
			//   int32_t v11; // [rsp+60h] [rbp+38h]
			//   int32_t v12; // [rsp+68h] [rbp+40h]
			//   float v13; // [rsp+70h] [rbp+48h]
			//   int32_t v14; // [rsp+78h] [rbp+50h]
			//   bool v15; // [rsp+80h] [rbp+58h]
			//   bool v16; // [rsp+88h] [rbp+60h]
			//   MethodInfo *v17; // [rsp+90h] [rbp+68h]
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2887, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2887, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else if ( this.fields.m_sectorTexture3x3 )
			//   {
			//     UnityEngine::Rendering::RTHandle::Release(this.fields.m_sectorTexture3x3, 0LL);
			//     this.fields.m_sectorTexture3x3 = 0LL;
			//     sub_1800054D0(
			//       (VolumetricRenderer_VolumetricRenderItem *)&this.fields.m_sectorTexture3x3,
			//       v3,
			//       v4,
			//       v5,
			//       v9,
			//       v10,
			//       v11,
			//       v12,
			//       v13,
			//       v14,
			//       v15,
			//       v16,
			//       v17);
			//   }
			// }
			// 
		}

		public void Render(HGRenderGraph renderGraph, HGCamera hgCamera, HGSettingParameters settingParameter)
		{
			// // Void Render(HGRenderGraph, HGCamera, HGSettingParameters)
			// void HG::Rendering::Runtime::WaterSectorRenderingPass::Render(
			//         WaterSectorRenderingPass *this,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *hgCamera,
			//         HGSettingParameters *settingParameter,
			//         MethodInfo *method)
			// {
			//   __int64 v9; // rdx
			//   Component *camera; // rcx
			//   Transform *transform; // rax
			//   Vector3 *position; // rax
			//   ResourceHandle v13; // xmm6_8
			//   uint32_t z_low; // r15d
			//   bool v15; // al
			//   HGManagerContext *currentManagerContext; // rax
			//   HGWaterGlobalConfig *globalConfig; // rax
			//   HGWaterGlobalConfig *v18; // rsi
			//   String *m_scenePath; // rbx
			//   String *scenePath; // rax
			//   int32_t m_sectorTextureSize; // ebx
			//   RTHandle *m_sectorTexture3x3; // r8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   TextureHandle v24; // [rsp+30h] [rbp-20h] BYREF
			// 
			//   if ( !byte_18D9195F2 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     byte_18D9195F2 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2894, 0LL) )
			//   {
			//     if ( hgCamera )
			//     {
			//       camera = (Component *)hgCamera.fields.camera;
			//       if ( camera )
			//       {
			//         transform = UnityEngine::Component::get_transform(camera, 0LL);
			//         if ( transform )
			//         {
			//           position = UnityEngine::Transform::get_position((Vector3 *)&v24, transform, 0LL);
			//           v13 = *(ResourceHandle *)&position.x;
			//           z_low = LODWORD(position.z);
			//           if ( renderGraph )
			//           {
			//             this.fields.sectorTexture3x3 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
			//                                                &v24,
			//                                                renderGraph,
			//                                                this.fields.m_sectorTexture3x3,
			//                                                0LL);
			//             if ( settingParameter )
			//             {
			//               v15 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                       settingParameter.fields._waterSectorRendering_k__BackingField,
			//                       MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//               if ( !HG::Rendering::Runtime::WaterSectorRenderingPass::ShouldRender(this, v15, 0LL) )
			//                 return;
			//               currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//               if ( currentManagerContext )
			//               {
			//                 camera = (Component *)currentManagerContext.fields._waterManager_k__BackingField;
			//                 if ( camera )
			//                 {
			//                   globalConfig = HG::Rendering::Runtime::HGWaterManager::get_globalConfig((HGWaterManager *)camera, 0LL);
			//                   v18 = globalConfig;
			//                   if ( !this.fields.m_waterSectors )
			//                   {
			// LABEL_16:
			//                     HG::Rendering::Runtime::WaterSectorRenderingPass::Release(this, 0LL);
			//                     HG::Rendering::Runtime::WaterSectorRenderingPass::Initialize(this, v18, 0LL);
			//                     m_sectorTexture3x3 = this.fields.m_sectorTexture3x3;
			//                     this.fields.m_needClear = 1;
			//                     this.fields.sectorTexture3x3 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
			//                                                        &v24,
			//                                                        renderGraph,
			//                                                        m_sectorTexture3x3,
			//                                                        0LL);
			// LABEL_17:
			//                     HG::Rendering::Runtime::WaterSectorRenderingPass::SectorUnloadUpdate(this, 0LL);
			//                     v24.handle = v13;
			//                     v24.fallBackResource.m_Value = z_low;
			//                     HG::Rendering::Runtime::WaterSectorRenderingPass::SectorLoadingUpdate(
			//                       this,
			//                       v18,
			//                       (Vector3 *)&v24,
			//                       0LL);
			//                     HG::Rendering::Runtime::WaterSectorRenderingPass::SectorLoadedUpdate(this, 0LL);
			//                     v24.handle = v13;
			//                     v24.fallBackResource.m_Value = z_low;
			//                     HG::Rendering::Runtime::WaterSectorRenderingPass::SectorTextureCopyUpdate(
			//                       this,
			//                       v18,
			//                       (Vector3 *)&v24,
			//                       0LL);
			//                     v24.handle = v13;
			//                     v24.fallBackResource.m_Value = z_low;
			//                     HG::Rendering::Runtime::WaterSectorRenderingPass::SectorTextureCopyPass(
			//                       this,
			//                       renderGraph,
			//                       v18,
			//                       (Vector3 *)&v24,
			//                       0LL);
			//                     return;
			//                   }
			//                   m_scenePath = this.fields.m_scenePath;
			//                   if ( globalConfig )
			//                   {
			//                     scenePath = HG::Rendering::Runtime::HGWaterGlobalConfig::get_scenePath(globalConfig, 0LL);
			//                     if ( !System::String::op_Inequality(m_scenePath, scenePath, 0LL) )
			//                     {
			//                       m_sectorTextureSize = this.fields.m_sectorTextureSize;
			//                       if ( m_sectorTextureSize == HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorTextureSize(
			//                                                     v18,
			//                                                     0LL) )
			//                         goto LABEL_17;
			//                     }
			//                     goto LABEL_16;
			//                   }
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_19:
			//     sub_180B536AC(camera, v9);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2894, 0LL);
			//   if ( !Patch )
			//     goto LABEL_19;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_7(
			//     (ILFixDynamicMethodWrapper_20 *)Patch,
			//     (Object *)this,
			//     (Object *)renderGraph,
			//     (Object *)hgCamera,
			//     (Object *)settingParameter,
			//     0LL);
			// }
			// 
		}

		private void SectorUnloadUpdate()
		{
			// // Void SectorUnloadUpdate()
			// void HG::Rendering::Runtime::WaterSectorRenderingPass::SectorUnloadUpdate(
			//         WaterSectorRenderingPass *this,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   Queue_1_System_Int32Enum_ *m_waterSectors; // rcx
			//   Queue_1_System_Int32_ *m_pendingUnloadQueue; // rax
			//   signed int v6; // eax
			//   __int64 v7; // rdi
			//   WaterSectorRenderingPass_SectorNode *v8; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D9195F3 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Queue<int>::Dequeue);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Queue<int>::Peek);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Queue<int>::get_Count);
			//     byte_18D9195F3 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2895, 0LL) )
			//   {
			//     while ( 1 )
			//     {
			//       m_pendingUnloadQueue = this.fields.m_pendingUnloadQueue;
			//       if ( !m_pendingUnloadQueue )
			//         break;
			//       if ( !m_pendingUnloadQueue.fields._size )
			//         return;
			//       v6 = System::Collections::Generic::Queue<unsigned int>::Peek(
			//              (Queue_1_System_UInt32_ *)this.fields.m_pendingUnloadQueue,
			//              MethodInfo::System::Collections::Generic::Queue<int>::Peek);
			//       m_waterSectors = (Queue_1_System_Int32Enum_ *)this.fields.m_pendingUnloadQueue;
			//       v7 = v6;
			//       if ( !m_waterSectors )
			//         break;
			//       System::Collections::Generic::Queue<System::Int32Enum>::Dequeue(
			//         m_waterSectors,
			//         MethodInfo::System::Collections::Generic::Queue<int>::Dequeue);
			//       m_waterSectors = (Queue_1_System_Int32Enum_ *)this.fields.m_waterSectors;
			//       if ( !m_waterSectors )
			//         break;
			//       if ( *(_DWORD *)(sub_180444080(m_waterSectors, v7) + 20) == 2 )
			//       {
			//         m_waterSectors = (Queue_1_System_Int32Enum_ *)this.fields.m_waterSectors;
			//         if ( !m_waterSectors )
			//           break;
			//         v8 = (WaterSectorRenderingPass_SectorNode *)sub_180444080(m_waterSectors, v7);
			//         HG::Rendering::Runtime::WaterSectorRenderingPass::SectorNode::Release(v8, 0LL);
			//       }
			//     }
			// LABEL_12:
			//     sub_180B536AC(m_waterSectors, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2895, 0LL);
			//   if ( !Patch )
			//     goto LABEL_12;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		private void SectorLoadingUpdate(HGWaterGlobalConfig globalConfig, Vector3 pos)
		{
			// // Void SectorLoadingUpdate(HGWaterGlobalConfig, Vector3)
			// void HG::Rendering::Runtime::WaterSectorRenderingPass::SectorLoadingUpdate(
			//         WaterSectorRenderingPass *this,
			//         HGWaterGlobalConfig *globalConfig,
			//         Vector3 *pos,
			//         MethodInfo *method)
			// {
			//   WaterSectorRenderingPass_SectorNode__Array *m_waterSectors; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   float v9; // eax
			//   unsigned __int64 SectorCoords; // rax
			//   int32_t v11; // edi
			//   unsigned __int64 v12; // rax
			//   int v13; // r12d
			//   int v14; // r15d
			//   int32_t SectorIndex; // eax
			//   __int64 v16; // rsi
			//   __int128 v17; // xmm2
			//   String *texurePath; // xmm1_8
			//   __int128 v19; // xmm0
			//   bool v20; // zf
			//   Boolean__Array *sectorDataExists; // rax
			//   String__Array *sectorDataPaths; // rax
			//   Object *v23; // rbx
			//   StringPathHash v24; // rbx
			//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v25; // rdx
			//   VolumetricRenderer_VolumetricBounds *v26; // r8
			//   Material *v27; // r9
			//   float z; // eax
			//   MethodInfo *v29; // [rsp+28h] [rbp-79h]
			//   MethodInfo *v30; // [rsp+30h] [rbp-71h]
			//   Vector3 v31; // [rsp+38h] [rbp-69h] BYREF
			//   Object *param1; // [rsp+48h] [rbp-59h]
			//   __int128 v33; // [rsp+50h] [rbp-51h] BYREF
			//   __int128 v34; // [rsp+60h] [rbp-41h]
			//   __int64 m_mainVersion; // [rsp+70h] [rbp-31h]
			//   FAssetProxyHandle v36; // [rsp+78h] [rbp-29h] BYREF
			//   __int128 v37; // [rsp+98h] [rbp-9h] BYREF
			//   __int128 v38; // [rsp+A8h] [rbp+7h]
			//   __int128 v39; // [rsp+B8h] [rbp+17h]
			//   String *v40; // [rsp+C8h] [rbp+27h]
			// 
			//   if ( !byte_18D9195F4 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::HGRPLogger::LogCritical<System::String>);
			//     sub_18003C530(&TypeInfo::Beyond::Resource::HashStringPathProcessor);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Queue<HG::Rendering::Runtime::WaterSectorRenderingPass::SectorLoadingNode>::Enqueue);
			//     sub_18003C530(&MethodInfo::Beyond::Resource::ResourceManager::LoadAsync<HG::Rendering::Runtime::HGWaterSectorData>);
			//     sub_18003C530(&TypeInfo::Beyond::Resource::ResourceManager);
			//     sub_18003C530(&off_18D502D88);
			//     byte_18D9195F4 = 1;
			//   }
			//   m_mainVersion = 0LL;
			//   v33 = 0LL;
			//   v34 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2896, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2896, 0LL);
			//     if ( Patch )
			//     {
			//       z = pos.z;
			//       *(_QWORD *)&v31.x = *(_QWORD *)&pos.x;
			//       v31.z = z;
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_679(Patch, (Object *)this, (Object *)globalConfig, &v31, 0LL);
			//       return;
			//     }
			// LABEL_27:
			//     sub_180B536AC(Patch, m_waterSectors);
			//   }
			//   if ( !globalConfig )
			//     goto LABEL_27;
			//   v9 = pos.z;
			//   *(_QWORD *)&v31.x = *(_QWORD *)&pos.x;
			//   v31.z = v9;
			//   SectorCoords = (unsigned __int64)HG::Rendering::Runtime::HGWaterGlobalConfig::GetSectorCoords(globalConfig, &v31, 0LL);
			//   v11 = SectorCoords;
			//   v12 = HIDWORD(SectorCoords);
			//   *(_QWORD *)&v31.x = v12;
			//   v13 = -1;
			//   do
			//   {
			//     v14 = -1;
			//     do
			//     {
			//       SectorIndex = HG::Rendering::Runtime::HGWaterGlobalConfig::GetSectorIndex(globalConfig, v11 + v13, v14 + v12, 0LL);
			//       v16 = SectorIndex;
			//       if ( SectorIndex != -1 )
			//       {
			//         m_waterSectors = this.fields.m_waterSectors;
			//         if ( !m_waterSectors )
			//           goto LABEL_27;
			//         if ( (unsigned int)SectorIndex >= m_waterSectors.max_length.size )
			//           goto LABEL_25;
			//         v17 = *(_OWORD *)&m_waterSectors.vector[SectorIndex].coordsMod3.Item2;
			//         texurePath = m_waterSectors.vector[SectorIndex].texurePath;
			//         v37 = *(_OWORD *)&m_waterSectors.vector[SectorIndex].isInTexture;
			//         v19 = *(_OWORD *)&m_waterSectors.vector[SectorIndex].assetHandle.m_untrackedHandle.m_assetProxyObj.m_handleID;
			//         v40 = texurePath;
			//         v39 = v19;
			//         if ( DWORD1(v17) == 3 )
			//         {
			//           v20 = !m_waterSectors.vector[SectorIndex].isInTexture;
			//           v39 = v19;
			//           v40 = texurePath;
			//           v38 = v17;
			//           if ( v20 )
			//           {
			//             sectorDataExists = HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorDataExists(globalConfig, 0LL);
			//             if ( !sectorDataExists )
			//               goto LABEL_27;
			//             if ( (unsigned int)v16 >= sectorDataExists.max_length.size )
			//               goto LABEL_25;
			//             if ( sectorDataExists.vector[v16] )
			//             {
			//               sectorDataPaths = HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorDataPaths(globalConfig, 0LL);
			//               if ( !sectorDataPaths )
			//                 goto LABEL_27;
			//               if ( (unsigned int)v16 >= sectorDataPaths.max_length.size )
			// LABEL_25:
			//                 sub_180070270(Patch, m_waterSectors);
			//               param1 = (Object *)sectorDataPaths.vector[v16];
			//               v23 = param1;
			//               sub_180002C70(TypeInfo::Beyond::Resource::HashStringPathProcessor);
			//               v24.hash = sub_1824C2970((Beyond::Resource::HashStringPathProcessor *)v23);
			//               sub_180002C70(TypeInfo::Beyond::Resource::ResourceManager);
			//               Beyond::Resource::ResourceManager::LoadAsync<System::Object>(
			//                 (FAssetProxyHandle *)&v37,
			//                 v24,
			//                 RootCategory__Enum_Main,
			//                 EResourceRequestPriority__Enum_Default,
			//                 MethodInfo::Beyond::Resource::ResourceManager::LoadAsync<HG::Rendering::Runtime::HGWaterSectorData>);
			//               v36.m_untrackedHandle.m_mainVersion = v38;
			//               *(_OWORD *)&v36.m_untrackedHandle.m_handleObjectID = v37;
			//               if ( Beyond::Resource::FAssetProxyHandle::IsValid(&v36, 0LL) )
			//               {
			//                 m_mainVersion = (unsigned int)v36.m_untrackedHandle.m_mainVersion;
			//                 v34 = *(_OWORD *)&v36.m_untrackedHandle.m_handleObjectID;
			//                 *((_QWORD *)&v33 + 1) = param1;
			//                 ((void (__stdcall *)(VolumetricRenderer_VolumetricRenderItem *, Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *, VolumetricRenderer_VolumetricBounds *, Material *, MethodInfo *, MethodInfo *, int32_t, int32_t, float, int32_t))sub_1800054D0)(
			//                   (VolumetricRenderer_VolumetricRenderItem *)((char *)&v33 + 8),
			//                   v25,
			//                   v26,
			//                   v27,
			//                   v29,
			//                   v30,
			//                   SLODWORD(v31.x),
			//                   SLODWORD(v31.z),
			//                   *(float *)&param1,
			//                   v16);
			//                 Patch = (ILFixDynamicMethodWrapper_2 *)this.fields.m_pendingLoadedQueue;
			//                 if ( !Patch )
			//                   goto LABEL_27;
			//                 v37 = v33;
			//                 *(_QWORD *)&v39 = m_mainVersion;
			//                 v38 = v34;
			//                 System::Collections::Generic::Queue<HG::Rendering::Runtime::WaterSectorRenderingPass::SectorLoadingNode>::Enqueue(
			//                   (Queue_1_HG_Rendering_Runtime_WaterSectorRenderingPass_SectorLoadingNode_ *)Patch,
			//                   (WaterSectorRenderingPass_SectorLoadingNode *)&v37,
			//                   MethodInfo::System::Collections::Generic::Queue<HG::Rendering::Runtime::WaterSectorRenderingPass::SectorLoadingNode>::Enqueue);
			//                 Patch = (ILFixDynamicMethodWrapper_2 *)this.fields.m_waterSectors;
			//                 if ( !Patch )
			//                   goto LABEL_27;
			//                 *(_DWORD *)(sub_180444080(Patch, v16) + 20) = 0;
			//               }
			//               else
			//               {
			//                 HG::Rendering::HGRPLogger::LogCritical<System::Object>(
			//                   (String *)"Fail to load water sector asset: assetPath({0})",
			//                   param1,
			//                   MethodInfo::HG::Rendering::HGRPLogger::LogCritical<System::String>);
			//               }
			//             }
			//           }
			//         }
			//       }
			//       *(float *)&v12 = v31.x;
			//       ++v14;
			//     }
			//     while ( v14 <= 1 );
			//     ++v13;
			//   }
			//   while ( v13 <= 1 );
			// }
			// 
		}

		private void SectorLoadedUpdate()
		{
			// // Void SectorLoadedUpdate()
			// void HG::Rendering::Runtime::WaterSectorRenderingPass::SectorLoadedUpdate(
			//         WaterSectorRenderingPass *this,
			//         MethodInfo *method)
			// {
			//   Queue_1_HG_Rendering_Runtime_WaterSectorRenderingPass_SectorLoadingNode_ *v3; // rdx
			//   WaterSectorRenderingPass_SectorNode__Array *m_waterSectors; // rcx
			//   Queue_1_HG_Rendering_Runtime_WaterSectorRenderingPass_SectorLoadingNode_ *m_pendingLoadedQueue; // rax
			//   int32_t m_mainVersion; // ebx
			//   __int64 v7; // rax
			//   WaterSectorRenderingPass_SectorNode__Array *v8; // rbx
			//   __int64 sectorIndex; // rsi
			//   WaterSectorRenderingPass_SectorNode__Array *v10; // rcx
			//   __int64 v11; // rax
			//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v12; // rdx
			//   VolumetricRenderer_VolumetricBounds *v13; // r8
			//   Material *v14; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int128 v16; // [rsp+20h] [rbp-60h]
			//   __int128 v17; // [rsp+20h] [rbp-60h]
			//   WaterSectorRenderingPass_SectorLoadingNode v18; // [rsp+30h] [rbp-50h] BYREF
			//   WaterSectorRenderingPass_SectorLoadingNode v19; // [rsp+58h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D9195F5 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Queue<HG::Rendering::Runtime::WaterSectorRenderingPass::SectorLoadingNode>::Dequeue);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Queue<HG::Rendering::Runtime::WaterSectorRenderingPass::SectorLoadingNode>::Peek);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Queue<HG::Rendering::Runtime::WaterSectorRenderingPass::SectorLoadingNode>::get_Count);
			//     byte_18D9195F5 = 1;
			//   }
			//   memset(&v18, 0, sizeof(v18));
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2898, 0LL) )
			//   {
			//     while ( 1 )
			//     {
			//       m_pendingLoadedQueue = this.fields.m_pendingLoadedQueue;
			//       if ( !m_pendingLoadedQueue )
			//         break;
			//       if ( !m_pendingLoadedQueue.fields._size )
			//         return;
			//       System::Collections::Generic::Queue<HG::Rendering::Runtime::WaterSectorRenderingPass::SectorLoadingNode>::Peek(
			//         &v19,
			//         this.fields.m_pendingLoadedQueue,
			//         MethodInfo::System::Collections::Generic::Queue<HG::Rendering::Runtime::WaterSectorRenderingPass::SectorLoadingNode>::Peek);
			//       v18 = v19;
			//       if ( !HG::Rendering::Runtime::WaterSectorRenderingPass::SectorLoadingNode::Ready(&v18, 0LL) )
			//         return;
			//       m_waterSectors = this.fields.m_waterSectors;
			//       if ( !m_waterSectors )
			//         break;
			//       if ( !*(_DWORD *)(sub_180444080(m_waterSectors, v18.sectorIndex) + 20)
			//         && Beyond::Resource::FAssetProxyHandle::IsValid(&v18.assetHandle, 0LL) )
			//       {
			//         m_waterSectors = this.fields.m_waterSectors;
			//         if ( !m_waterSectors )
			//           break;
			//         m_mainVersion = v18.assetHandle.m_untrackedHandle.m_mainVersion;
			//         v16 = *(_OWORD *)&v18.assetHandle.m_untrackedHandle.m_handleObjectID;
			//         v7 = sub_180444080(m_waterSectors, v18.sectorIndex);
			//         *(_OWORD *)(v7 + 24) = v16;
			//         *(_DWORD *)(v7 + 40) = m_mainVersion;
			//         m_waterSectors = this.fields.m_waterSectors;
			//         if ( !m_waterSectors )
			//           break;
			//         *(_DWORD *)(sub_180444080(m_waterSectors, v18.sectorIndex) + 20) = 1;
			//         v8 = this.fields.m_waterSectors;
			//         sectorIndex = v18.sectorIndex;
			//         if ( !v8 )
			//           break;
			//         v10 = this.fields.m_waterSectors;
			//         v17 = *(_OWORD *)&v18.sectorIndex;
			//         *(_QWORD *)&v19.assetHandle.m_untrackedHandle.m_mainVersion = *(_QWORD *)&v18.assetHandle.m_untrackedHandle.m_mainVersion;
			//         *(_OWORD *)&v19.assetHandle.m_untrackedHandle.m_handleObjectID = *(_OWORD *)&v18.assetHandle.m_untrackedHandle.m_handleObjectID;
			//         *(_QWORD *)(sub_180444080(v10, v18.sectorIndex) + 48) = _mm_srli_si128(*(__m128i *)&v18.sectorIndex, 8).m128i_u64[0];
			//         v11 = sub_180444080(v8, sectorIndex);
			//         sub_1800054D0(
			//           (VolumetricRenderer_VolumetricRenderItem *)(v11 + 48),
			//           v12,
			//           v13,
			//           v14,
			//           (MethodInfo *)v17,
			//           *((MethodInfo **)&v17 + 1),
			//           v18.sectorIndex,
			//           (int32_t)v18.texturePath,
			//           *(float *)&v18.assetHandle.m_untrackedHandle.m_handleObjectID,
			//           v18.assetHandle.m_untrackedHandle.m_assetProxyObj.m_handleID,
			//           v18.assetHandle.m_untrackedHandle.m_mainVersion,
			//           v19.sectorIndex,
			//           (MethodInfo *)v19.texturePath);
			//       }
			//       v3 = this.fields.m_pendingLoadedQueue;
			//       if ( !v3 )
			//         break;
			//       System::Collections::Generic::Queue<HG::Rendering::Runtime::WaterSectorRenderingPass::SectorLoadingNode>::Dequeue(
			//         &v19,
			//         v3,
			//         MethodInfo::System::Collections::Generic::Queue<HG::Rendering::Runtime::WaterSectorRenderingPass::SectorLoadingNode>::Dequeue);
			//     }
			// LABEL_17:
			//     sub_180B536AC(m_waterSectors, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2898, 0LL);
			//   if ( !Patch )
			//     goto LABEL_17;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		private void SectorTextureCopyUpdate(HGWaterGlobalConfig globalConfig, Vector3 pos)
		{
			// // Void SectorTextureCopyUpdate(HGWaterGlobalConfig, Vector3)
			// void HG::Rendering::Runtime::WaterSectorRenderingPass::SectorTextureCopyUpdate(
			//         WaterSectorRenderingPass *this,
			//         HGWaterGlobalConfig *globalConfig,
			//         Vector3 *pos,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   float v9; // eax
			//   unsigned __int64 SectorCoords; // rax
			//   unsigned __int64 v11; // r13
			//   int32_t v12; // ebx
			//   int v13; // r12d
			//   int v14; // r15d
			//   int32_t SectorIndex; // eax
			//   __int64 v16; // rbp
			//   Boolean__Array *sectorDataExists; // rax
			//   WaterSectorRenderingPass_SectorNode *v18; // rax
			//   Object_1 *Data; // rdi
			//   Object_1 *klass; // rdi
			//   float z; // eax
			//   Vector3 v22; // [rsp+30h] [rbp-38h] BYREF
			// 
			//   if ( !byte_18D9195F6 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Queue<int>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Queue<int>::Enqueue);
			//     byte_18D9195F6 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2900, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2900, 0LL);
			//     if ( !Patch )
			//       goto LABEL_33;
			//     z = pos.z;
			//     *(_QWORD *)&v22.x = *(_QWORD *)&pos.x;
			//     v22.z = z;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_679(Patch, (Object *)this, (Object *)globalConfig, &v22, 0LL);
			//   }
			//   else
			//   {
			//     if ( !globalConfig )
			//       goto LABEL_33;
			//     v9 = pos.z;
			//     *(_QWORD *)&v22.x = *(_QWORD *)&pos.x;
			//     v22.z = v9;
			//     SectorCoords = (unsigned __int64)HG::Rendering::Runtime::HGWaterGlobalConfig::GetSectorCoords(
			//                                        globalConfig,
			//                                        &v22,
			//                                        0LL);
			//     Patch = (ILFixDynamicMethodWrapper_2 *)this.fields.m_pendingCopyQueue;
			//     v11 = HIDWORD(SectorCoords);
			//     v12 = SectorCoords;
			//     if ( !Patch )
			//       goto LABEL_33;
			//     System::Collections::Generic::Queue<HG::Rendering::Runtime::HGTerrainStreamingManager::TerrainLoadingSplat>::Clear(
			//       (Queue_1_HG_Rendering_Runtime_HGTerrainStreamingManager_TerrainLoadingSplat_ *)Patch,
			//       MethodInfo::System::Collections::Generic::Queue<int>::Clear);
			//     v13 = -1;
			//     do
			//     {
			//       v14 = -1;
			//       do
			//       {
			//         SectorIndex = HG::Rendering::Runtime::HGWaterGlobalConfig::GetSectorIndex(
			//                         globalConfig,
			//                         v12 + v13,
			//                         v14 + v11,
			//                         0LL);
			//         v16 = SectorIndex;
			//         if ( SectorIndex != -1 )
			//         {
			//           sectorDataExists = HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorDataExists(globalConfig, 0LL);
			//           if ( !sectorDataExists )
			//             goto LABEL_33;
			//           if ( (unsigned int)v16 >= sectorDataExists.max_length.size )
			//             sub_180070270(Patch, v7);
			//           if ( sectorDataExists.vector[v16] )
			//           {
			//             Patch = (ILFixDynamicMethodWrapper_2 *)this.fields.m_waterSectors;
			//             if ( !Patch )
			//               goto LABEL_33;
			//             if ( !*(_BYTE *)sub_180444080(Patch, v16) )
			//             {
			//               Patch = (ILFixDynamicMethodWrapper_2 *)this.fields.m_waterSectors;
			//               if ( !Patch )
			//                 goto LABEL_33;
			//               if ( *(_DWORD *)(sub_180444080(Patch, v16) + 20) == 2 )
			//               {
			//                 Patch = (ILFixDynamicMethodWrapper_2 *)this.fields.m_waterSectors;
			//                 if ( !Patch )
			//                   goto LABEL_33;
			//                 *(_DWORD *)(sub_180444080(Patch, v16) + 20) = 1;
			//               }
			//               Patch = (ILFixDynamicMethodWrapper_2 *)this.fields.m_waterSectors;
			//               if ( !Patch )
			//                 goto LABEL_33;
			//               if ( *(_DWORD *)(sub_180444080(Patch, v16) + 20) != 1 )
			//               {
			//                 Patch = (ILFixDynamicMethodWrapper_2 *)this.fields.m_pendingCopyQueue;
			//                 if ( Patch )
			//                 {
			//                   System::Collections::Generic::Queue<HG::Rendering::Runtime::HGTerrainStreamingManager::TerrainLoadingSplat>::Clear(
			//                     (Queue_1_HG_Rendering_Runtime_HGTerrainStreamingManager_TerrainLoadingSplat_ *)Patch,
			//                     MethodInfo::System::Collections::Generic::Queue<int>::Clear);
			//                   return;
			//                 }
			// LABEL_33:
			//                 sub_180B536AC(Patch, v7);
			//               }
			//               Patch = (ILFixDynamicMethodWrapper_2 *)this.fields.m_waterSectors;
			//               if ( !Patch )
			//                 goto LABEL_33;
			//               v18 = (WaterSectorRenderingPass_SectorNode *)sub_180444080(Patch, v16);
			//               Data = (Object_1 *)HG::Rendering::Runtime::WaterSectorRenderingPass::SectorNode::GetData(v18, 0LL);
			//               sub_180002C70(TypeInfo::UnityEngine::Object);
			//               if ( !UnityEngine::Object::op_Equality(Data, 0LL, 0LL) )
			//               {
			//                 if ( !Data )
			//                   goto LABEL_33;
			//                 klass = (Object_1 *)Data[1].klass;
			//                 sub_180002C70(TypeInfo::UnityEngine::Object);
			//                 if ( !UnityEngine::Object::op_Equality(klass, 0LL, 0LL) )
			//                 {
			//                   Patch = (ILFixDynamicMethodWrapper_2 *)this.fields.m_pendingCopyQueue;
			//                   if ( !Patch )
			//                     goto LABEL_33;
			//                   System::Collections::Generic::Queue<System::Int32Enum>::Enqueue(
			//                     (Queue_1_System_Int32Enum_ *)Patch,
			//                     (Int32Enum__Enum)v16,
			//                     MethodInfo::System::Collections::Generic::Queue<int>::Enqueue);
			//                 }
			//               }
			//             }
			//           }
			//         }
			//         ++v14;
			//       }
			//       while ( v14 <= 1 );
			//       ++v13;
			//     }
			//     while ( v13 <= 1 );
			//   }
			// }
			// 
		}

		private void SectorTextureCopyPass(HGRenderGraph renderGraph, HGWaterGlobalConfig globalConfig, Vector3 pos)
		{
			// // Void SectorTextureCopyPass(HGRenderGraph, HGWaterGlobalConfig, Vector3)
			// // Hidden C++ exception states: #wind=4
			// void HG::Rendering::Runtime::WaterSectorRenderingPass::SectorTextureCopyPass(
			//         WaterSectorRenderingPass *this,
			//         HGRenderGraph *renderGraph,
			//         HGWaterGlobalConfig *globalConfig,
			//         Vector3 *pos,
			//         MethodInfo *method)
			// {
			//   HGRenderGraph *v7; // r15
			//   WaterSectorRenderingPass *v8; // r13
			//   __int64 v9; // rdx
			//   Queue_1_System_Int32Enum_ *m_pendingUnloadQueue; // rcx
			//   Queue_1_System_Int32_ *m_pendingCopyQueue; // r14
			//   unsigned __int64 SectorCoords; // rax
			//   int32_t v13; // ebx
			//   unsigned __int64 v14; // r12
			//   int32_t sectorCoordsMin; // r15d
			//   int v16; // ebx
			//   int32_t i; // r14d
			//   __int64 v18; // rdx
			//   __int64 v19; // rcx
			//   ProfilingSampler *v20; // rax
			//   __int64 v21; // rdx
			//   __int64 v22; // rcx
			//   int v23; // r8d
			//   __m128i si128; // xmm6
			//   RenderFunc_1_HG_Rendering_Runtime_WaterSectorRenderingPass_SectorCopyPassData_ *_9__28_0; // rbx
			//   Object *v26; // rsi
			//   RenderFunc_1_System_Object_ *v27; // rax
			//   __int64 v28; // rdx
			//   __int64 v29; // rcx
			//   unsigned __int64 v30; // r8
			//   unsigned __int64 v31; // rdx
			//   signed __int64 v32; // rtt
			//   __m128i v33; // xmm8
			//   Queue_1_System_Int32_ *v34; // rax
			//   Int32Enum__Enum v35; // eax
			//   __int64 v36; // r12
			//   ProfilingSampler *v37; // rax
			//   __int64 v38; // rdx
			//   WaterSectorRenderingPass_SectorNode__Array *m_waterSectors; // rcx
			//   __int64 v40; // rdx
			//   HGRenderGraphPass *v41; // rbx
			//   WaterSectorRenderingPass_SectorNode__Array *v42; // rcx
			//   WaterSectorRenderingPass_SectorNode *v43; // rax
			//   HGWaterSectorData *Data; // rax
			//   __int64 v45; // rdx
			//   Object *v46; // rcx
			//   Object *v47; // rdx
			//   Object__Class *waterSectorTexture0; // rcx
			//   unsigned int v49; // edx
			//   unsigned __int64 v50; // r8
			//   char v51; // dl
			//   signed __int64 v52; // rtt
			//   RenderFunc_1_HG_Rendering_Runtime_WaterSectorRenderingPass_SectorCopyPassData_ *_9__28_1; // rsi
			//   Object *v54; // r15
			//   struct RenderFunc_1_HG_Rendering_Runtime_WaterSectorRenderingPass_SectorCopyPassData___Class *element_class; // rbx
			//   __int64 v56; // rdx
			//   __int64 instance_size; // rcx
			//   __int64 v58; // rdx
			//   __int64 v59; // rcx
			//   unsigned __int64 v60; // r8
			//   unsigned __int64 v61; // rdx
			//   signed __int64 v62; // rtt
			//   __int64 v63; // rdx
			//   __int64 v64; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // r14
			//   int32_t SectorIndex; // [rsp+50h] [rbp-148h]
			//   Int32Enum__Enum v67; // [rsp+50h] [rbp-148h]
			//   Il2CppException *ex; // [rsp+60h] [rbp-138h] BYREF
			//   HGRenderGraphBuilder *v69; // [rsp+68h] [rbp-130h]
			//   Object *v70; // [rsp+70h] [rbp-128h] BYREF
			//   HGRenderGraphBuilder v71; // [rsp+80h] [rbp-118h] BYREF
			//   __m128i v72; // [rsp+A0h] [rbp-F8h] BYREF
			//   Object v73; // [rsp+B0h] [rbp-E8h] BYREF
			//   __int64 v74; // [rsp+C0h] [rbp-D8h] BYREF
			//   HGRenderGraphBuilder v75; // [rsp+C8h] [rbp-D0h] BYREF
			//   HGRenderGraphBuilder v76; // [rsp+E8h] [rbp-B0h] BYREF
			//   Il2CppExceptionWrapper *v77; // [rsp+108h] [rbp-90h] BYREF
			//   _BYTE v78[8]; // [rsp+110h] [rbp-88h] BYREF
			//   Il2CppExceptionWrapper *v79; // [rsp+118h] [rbp-80h] BYREF
			//   TextureHandle v80[5]; // [rsp+120h] [rbp-78h] BYREF
			// 
			//   v7 = renderGraph;
			//   v8 = this;
			//   if ( !byte_18D9195F7 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::WaterSectorRenderingPass::SectorCopyPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::WaterSectorRenderingPass::SectorCopyPassData>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Queue<int>::Dequeue);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Queue<int>::Enqueue);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Queue<int>::get_Count);
			//     sub_18003C530(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::WaterSectorRenderingPass::SectorCopyPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::WaterSectorRenderingPass::__c::_SectorTextureCopyPass_b__28_0);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::WaterSectorRenderingPass::__c::_SectorTextureCopyPass_b__28_1);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::WaterSectorRenderingPass::__c);
			//     sub_18003C530(&off_18D502E10);
			//     byte_18D9195F7 = 1;
			//   }
			//   memset(&v75, 0, sizeof(v75));
			//   v74 = 0LL;
			//   memset(&v76, 0, sizeof(v76));
			//   v70 = 0LL;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2902, 0LL) )
			//   {
			//     m_pendingCopyQueue = v8.fields.m_pendingCopyQueue;
			//     if ( !m_pendingCopyQueue )
			//       sub_180B536AC(m_pendingUnloadQueue, v9);
			//     if ( m_pendingCopyQueue.fields._size > 0 )
			//     {
			//       if ( !globalConfig )
			//         sub_180B536AC(m_pendingUnloadQueue, v9);
			//       ex = *(Il2CppException **)&pos.x;
			//       *(float *)&v69 = pos.z;
			//       SectorCoords = (unsigned __int64)HG::Rendering::Runtime::HGWaterGlobalConfig::GetSectorCoords(
			//                                          globalConfig,
			//                                          (Vector3 *)&ex,
			//                                          0LL);
			//       v13 = SectorCoords;
			//       v14 = HIDWORD(SectorCoords);
			//       v71.m_RenderPass = (HGRenderGraphPass *)HIDWORD(SectorCoords);
			//       sectorCoordsMin = HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorCoordsMin(globalConfig, 0LL);
			//       v16 = -v13;
			//       while ( sectorCoordsMin <= HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorCoordsMax(globalConfig, 0LL) )
			//       {
			//         for ( i = HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorCoordsMin(globalConfig, 0LL);
			//               i <= HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorCoordsMax(globalConfig, 0LL);
			//               ++i )
			//         {
			//           SectorIndex = HG::Rendering::Runtime::HGWaterGlobalConfig::GetSectorIndex(
			//                           globalConfig,
			//                           sectorCoordsMin,
			//                           i,
			//                           0LL);
			//           if ( (int)sub_1824AD5C0((unsigned int)(v16 + sectorCoordsMin)) > 1
			//             || (int)sub_1824AD5C0((unsigned int)(i - v14)) > 1 )
			//           {
			//             if ( !v8.fields.m_waterSectors )
			//               sub_180B536AC(v19, v18);
			//             *(_BYTE *)sub_180444080(v8.fields.m_waterSectors, SectorIndex) = 0;
			//             LODWORD(v14) = v71.m_RenderPass;
			//           }
			//         }
			//         ++sectorCoordsMin;
			//       }
			//       v7 = renderGraph;
			//     }
			//     if ( v8.fields.m_needClear )
			//     {
			//       v20 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//               (Int32Enum__Enum)0x31u,
			//               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//       if ( !v7 )
			//         sub_180B536AC(v22, v21);
			//       v75 = *(HGRenderGraphBuilder *)sub_180830C94((unsigned int)v80, (_DWORD)v7, v23, (unsigned int)&v74, (__int64)v20);
			//       ex = 0LL;
			//       v69 = &v75;
			//       try
			//       {
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v75, 0, 0LL);
			//         si128 = _mm_load_si128((const __m128i *)&xmmword_18A3576D0);
			//         v72 = si128;
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//           (TextureHandle *)&v73,
			//           &v75,
			//           &v8.fields.sectorTexture3x3,
			//           0,
			//           RenderBufferLoadAction__Enum_Clear,
			//           RenderBufferStoreAction__Enum_Store,
			//           (Color *)&v72,
			//           0,
			//           0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::WaterSectorRenderingPass::__c);
			//         _9__28_0 = TypeInfo::HG::Rendering::Runtime::WaterSectorRenderingPass::__c.static_fields.__9__28_0;
			//         if ( !_9__28_0 )
			//         {
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::WaterSectorRenderingPass::__c);
			//           v26 = (Object *)TypeInfo::HG::Rendering::Runtime::WaterSectorRenderingPass::__c.static_fields.__9;
			//           v27 = (RenderFunc_1_System_Object_ *)sub_180004920(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::WaterSectorRenderingPass::SectorCopyPassData>[0]);
			//           _9__28_0 = (RenderFunc_1_HG_Rendering_Runtime_WaterSectorRenderingPass_SectorCopyPassData_ *)v27;
			//           if ( !v27 )
			//             sub_1802DC2C8(v29, v28);
			//           HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
			//             v27,
			//             v26,
			//             MethodInfo::HG::Rendering::Runtime::WaterSectorRenderingPass::__c::_SectorTextureCopyPass_b__28_0,
			//             0LL);
			//           TypeInfo::HG::Rendering::Runtime::WaterSectorRenderingPass::__c.static_fields.__9__28_0 = _9__28_0;
			//           if ( dword_18D8E43F8 )
			//           {
			//             v30 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::WaterSectorRenderingPass::__c.static_fields.__9__28_0 >> 12) & 0x1FFFFF) >> 6;
			//             v31 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::WaterSectorRenderingPass::__c.static_fields.__9__28_0 >> 12) & 0x3F;
			//             _m_prefetchw(&qword_18D6405E0[v30 + 36190]);
			//             do
			//               v32 = qword_18D6405E0[v30 + 36190];
			//             while ( v32 != _InterlockedCompareExchange64(&qword_18D6405E0[v30 + 36190], v32 | (1LL << v31), v32) );
			//           }
			//         }
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//           &v75,
			//           (RenderFunc_1_System_Object_ *)_9__28_0,
			//           0LL,
			//           0,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::WaterSectorRenderingPass::SectorCopyPassData>);
			//       }
			//       catch ( Il2CppExceptionWrapper *v77 )
			//       {
			//         ex = v77.ex;
			//         sub_180222690(&ex);
			//         v8 = this;
			//         si128 = _mm_load_si128((const __m128i *)&xmmword_18A3576D0);
			//         v7 = renderGraph;
			//         goto LABEL_28;
			//       }
			//       sub_180222690(&ex);
			// LABEL_28:
			//       v8.fields.m_needClear = 0;
			//     }
			//     else
			//     {
			//       si128 = _mm_load_si128((const __m128i *)&xmmword_18A3576D0);
			//     }
			//     v33 = _mm_load_si128((const __m128i *)&xmmword_18A357570);
			//     while ( 1 )
			//     {
			//       v34 = v8.fields.m_pendingCopyQueue;
			//       if ( !v34 )
			//         break;
			//       if ( v34.fields._size <= 0 )
			//         return;
			//       v35 = System::Collections::Generic::Queue<System::Int32Enum>::Dequeue(
			//               (Queue_1_System_Int32Enum_ *)v8.fields.m_pendingCopyQueue,
			//               MethodInfo::System::Collections::Generic::Queue<int>::Dequeue);
			//       v36 = (int)v35;
			//       v67 = v35;
			//       v37 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//               (Int32Enum__Enum)0x31u,
			//               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//       if ( !v7 )
			//         break;
			//       HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//         &v71,
			//         v7,
			//         (String *)"Water Sector Copy",
			//         &v70,
			//         v37,
			//         1,
			//         ProfilingHGPass__Enum_None,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::WaterSectorRenderingPass::SectorCopyPassData>);
			//       v76 = v71;
			//       v72.m128i_i64[0] = 0LL;
			//       v72.m128i_i64[1] = (__int64)&v76;
			//       try
			//       {
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v76, 0, 0LL);
			//         m_waterSectors = v8.fields.m_waterSectors;
			//         if ( !m_waterSectors )
			//           sub_1802DC2C8(0LL, v38);
			//         v41 = *(HGRenderGraphPass **)(sub_180444080(m_waterSectors, v36) + 12);
			//         v71.m_RenderPass = v41;
			//         v42 = v8.fields.m_waterSectors;
			//         if ( !v42 )
			//           sub_1802DC2C8(0LL, v40);
			//         v43 = (WaterSectorRenderingPass_SectorNode *)sub_180444080(v42, v36);
			//         Data = HG::Rendering::Runtime::WaterSectorRenderingPass::SectorNode::GetData(v43, 0LL);
			//         if ( !v70 )
			//           sub_1802DC2C8(0LL, v45);
			//         v70[1] = (Object)v33;
			//         v73.klass = (Object__Class *)0x3EAAAAAB3EAAAAABLL;
			//         *(float *)&v73.monitor = (float)(int)v41 / 3.0;
			//         *((float *)&v73.monitor + 1) = (float)SHIDWORD(v71.m_RenderPass) / 3.0;
			//         v46 = v70;
			//         if ( !v70 )
			//           sub_1802DC2C8(0LL, v45);
			//         v70[2] = v73;
			//         v47 = v70;
			//         if ( !Data )
			//           sub_1802DC2C8(v46, v70);
			//         waterSectorTexture0 = (Object__Class *)Data.fields.waterSectorTexture0;
			//         if ( !v70 )
			//           sub_1802DC2C8(waterSectorTexture0, 0LL);
			//         v70[3].klass = waterSectorTexture0;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v49 = ((unsigned __int64)&v47[3] >> 12) & 0x1FFFFF;
			//           v50 = (unsigned __int64)v49 >> 6;
			//           v51 = v49 & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v50 + 36190]);
			//           do
			//             v52 = qword_18D6405E0[v50 + 36190];
			//           while ( v52 != _InterlockedCompareExchange64(&qword_18D6405E0[v50 + 36190], v52 | (1LL << v51), v52) );
			//         }
			//         *(__m128i *)&v71.m_RenderPass = si128;
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//           v80,
			//           &v76,
			//           &v8.fields.sectorTexture3x3,
			//           0,
			//           RenderBufferLoadAction__Enum_Load,
			//           RenderBufferStoreAction__Enum_Store,
			//           (Color *)&v71,
			//           0,
			//           0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::WaterSectorRenderingPass::__c);
			//         _9__28_1 = TypeInfo::HG::Rendering::Runtime::WaterSectorRenderingPass::__c.static_fields.__9__28_1;
			//         if ( !_9__28_1 )
			//         {
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::WaterSectorRenderingPass::__c);
			//           v54 = (Object *)TypeInfo::HG::Rendering::Runtime::WaterSectorRenderingPass::__c.static_fields.__9;
			//           element_class = TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::WaterSectorRenderingPass::SectorCopyPassData>[0];
			//           if ( ((__int64)TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::WaterSectorRenderingPass::SectorCopyPassData>[0].vtable.Equals.methodPtr & 2) == 0 )
			//           {
			//             v71.m_RenderPass = (HGRenderGraphPass *)&qword_18CDB0B30;
			//             sub_1802924D0(&qword_18CDB0B30);
			//             sub_180060090(element_class, &v71);
			//             sub_180292530(v71.m_RenderPass);
			//           }
			//           if ( element_class._0.generic_class && ((__int64)element_class.vtable.Equals.methodPtr & 8) != 0 )
			//             element_class = (struct RenderFunc_1_HG_Rendering_Runtime_WaterSectorRenderingPass_SectorCopyPassData___Class *)element_class._0.element_class;
			//           if ( ((__int64)element_class.vtable.Equals.methodPtr & 0x20) != 0 )
			//           {
			//             instance_size = element_class._1.instance_size;
			//             if ( element_class._0.gc_desc )
			//             {
			//               _9__28_1 = (RenderFunc_1_HG_Rendering_Runtime_WaterSectorRenderingPass_SectorCopyPassData_ *)sub_180005220(instance_size, element_class);
			//               _InterlockedIncrement64(&qword_18D8E51F8);
			//             }
			//             else
			//             {
			//               _9__28_1 = (RenderFunc_1_HG_Rendering_Runtime_WaterSectorRenderingPass_SectorCopyPassData_ *)sub_180005D40(instance_size, element_class);
			//             }
			//           }
			//           else
			//           {
			//             _9__28_1 = (RenderFunc_1_HG_Rendering_Runtime_WaterSectorRenderingPass_SectorCopyPassData_ *)sub_180005FB0(element_class);
			//           }
			//           if ( (BYTE1(element_class.vtable.Equals.methodPtr) & 2) != 0 )
			//             sub_18002E8C0((_DWORD)_9__28_1, (unsigned int)sub_18007DC30, 0, (unsigned int)&ex, (__int64)v78);
			//           if ( (dword_18D8F6F50 & 0x80u) != 0 )
			//             sub_1802DAEC4(_9__28_1, element_class);
			//           il2cpp_runtime_class_init_0(element_class, v56);
			//           if ( !_9__28_1 )
			//             sub_1802DC2C8(v59, v58);
			//           HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
			//             (RenderFunc_1_System_Object_ *)_9__28_1,
			//             v54,
			//             MethodInfo::HG::Rendering::Runtime::WaterSectorRenderingPass::__c::_SectorTextureCopyPass_b__28_1,
			//             0LL);
			//           TypeInfo::HG::Rendering::Runtime::WaterSectorRenderingPass::__c.static_fields.__9__28_1 = _9__28_1;
			//           if ( dword_18D8E43F8 )
			//           {
			//             v60 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::WaterSectorRenderingPass::__c.static_fields.__9__28_1 >> 12) & 0x1FFFFF) >> 6;
			//             v61 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::WaterSectorRenderingPass::__c.static_fields.__9__28_1 >> 12) & 0x3F;
			//             _m_prefetchw(&qword_18D6405E0[v60 + 36190]);
			//             do
			//               v62 = qword_18D6405E0[v60 + 36190];
			//             while ( v62 != _InterlockedCompareExchange64(&qword_18D6405E0[v60 + 36190], v62 | (1LL << v61), v62) );
			//           }
			//         }
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//           &v76,
			//           (RenderFunc_1_System_Object_ *)_9__28_1,
			//           0LL,
			//           0,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::WaterSectorRenderingPass::SectorCopyPassData>);
			//       }
			//       catch ( Il2CppExceptionWrapper *v79 )
			//       {
			//         *(Il2CppExceptionWrapper *)v72.m128i_i8 = (Il2CppExceptionWrapper)v79.ex;
			//         sub_180222690(&v72);
			//         v8 = this;
			//         LODWORD(v36) = v67;
			//         si128 = _mm_load_si128((const __m128i *)&xmmword_18A3576D0);
			//         v33 = _mm_load_si128((const __m128i *)&xmmword_18A357570);
			//         goto LABEL_65;
			//       }
			//       sub_180222690(&v72);
			// LABEL_65:
			//       m_pendingUnloadQueue = (Queue_1_System_Int32Enum_ *)v8.fields.m_pendingUnloadQueue;
			//       if ( !m_pendingUnloadQueue )
			//         break;
			//       System::Collections::Generic::Queue<System::Int32Enum>::Enqueue(
			//         m_pendingUnloadQueue,
			//         (Int32Enum__Enum)v36,
			//         MethodInfo::System::Collections::Generic::Queue<int>::Enqueue);
			//       m_pendingUnloadQueue = (Queue_1_System_Int32Enum_ *)v8.fields.m_waterSectors;
			//       if ( !m_pendingUnloadQueue )
			//         break;
			//       *(_BYTE *)sub_180444080(m_pendingUnloadQueue, (int)v36) = 1;
			//       m_pendingUnloadQueue = (Queue_1_System_Int32Enum_ *)v8.fields.m_waterSectors;
			//       if ( !m_pendingUnloadQueue )
			//         break;
			//       *(_DWORD *)(sub_180444080(m_pendingUnloadQueue, (int)v36) + 20) = 2;
			//       v7 = renderGraph;
			//     }
			//     sub_1802DC2C8(m_pendingUnloadQueue, v9);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2902, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v64, v63);
			//   ex = *(Il2CppException **)&pos.x;
			//   *(float *)&v69 = pos.z;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1052(
			//     Patch,
			//     (Object *)v8,
			//     (Object *)v7,
			//     (Object *)globalConfig,
			//     (Vector3 *)&ex,
			//     0LL);
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::WaterSectorRenderingPass::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         WaterSectorRenderingPass *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2907, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2907, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_340(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::WaterSectorRenderingPass::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         WaterSectorRenderingPass *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2908, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2908, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::WaterSectorRenderingPass::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         WaterSectorRenderingPass *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2909, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2909, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph renderGraph)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
			// void HG::Rendering::Runtime::WaterSectorRenderingPass::HG_Rendering_Runtime_IPassConstructor_Dispose(
			//         WaterSectorRenderingPass *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2910, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2910, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)renderGraph,
			//       0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::WaterSectorRenderingPass::Release(this, 0LL);
			//     HG::Rendering::Runtime::WaterSectorRenderingPass::ReleaseTextures(this, 0LL);
			//   }
			// }
			// 
		}

		private const int TEXTURE_SIZE = 256;

		private const string TEXTURE_NAME = "WaterSectorTexture3x3";

		private const string TEXTURE_NAME_DEBUG_NOMOD = "WaterSectorTexture3x3_Debug_NoMod";

		private const string TEXTURE_NAME_DEBUG_MOD3 = "WaterSectorTexture3x3_Debug_Mod3";

		private int m_sectorTextureSize;

		private RTHandle m_sectorTexture3x3;

		public TextureHandle sectorTexture3x3;

		private bool m_needClear;

		private string m_scenePath;

		private WaterSectorRenderingPass.SectorNode[] m_waterSectors;

		private Queue<int> m_pendingUnloadQueue;

		private Queue<int> m_pendingCopyQueue;

		private Queue<WaterSectorRenderingPass.SectorLoadingNode> m_pendingLoadedQueue;

		private enum SectorState
		{
			Loading,
			Loaded,
			ToUnload,
			Unload
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		private struct SectorNode
		{
			public HGWaterSectorData GetData()
			{
				// // HGWaterSectorData GetData()
				// HGWaterSectorData *HG::Rendering::Runtime::WaterSectorRenderingPass::SectorNode::GetData(
				//         WaterSectorRenderingPass_SectorNode *this,
				//         MethodInfo *method)
				// {
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v5; // rdx
				//   __int64 v6; // rcx
				// 
				//   if ( !byte_18D9195F8 )
				//   {
				//     sub_18003C530(&MethodInfo::Beyond::Resource::FAssetProxyHandle::Get<HG::Rendering::Runtime::HGWaterSectorData>);
				//     byte_18D9195F8 = 1;
				//   }
				//   if ( !IFix::WrappersManagerImpl::IsPatched(2901, 0LL) )
				//     return (HGWaterSectorData *)Beyond::Resource::FAssetProxyHandle::Get<System::Object>(
				//                                   &this.assetHandle,
				//                                   MethodInfo::Beyond::Resource::FAssetProxyHandle::Get<HG::Rendering::Runtime::HGWaterSectorData>);
				//   Patch = IFix::WrappersManagerImpl::GetPatch(2901, 0LL);
				//   if ( !Patch )
				//     sub_180B536AC(v6, v5);
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1050(Patch, this, 0LL);
				// }
				// 
				return null;
			}

			public void Release()
			{
				// // Void Release()
				// void HG::Rendering::Runtime::WaterSectorRenderingPass::SectorNode::Release(
				//         WaterSectorRenderingPass_SectorNode *this,
				//         MethodInfo *method)
				// {
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v4; // rdx
				//   __int64 v5; // rcx
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(2892, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(2892, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v5, v4);
				//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1047(Patch, this, 0LL);
				//   }
				//   else
				//   {
				//     if ( Beyond::Resource::FAssetProxyHandle::IsValid(&this.assetHandle, 0LL) )
				//     {
				//       Beyond::Resource::FAssetProxyHandle::Dispose(&this.assetHandle, 0LL);
				//       *(_OWORD *)&this.assetHandle.m_untrackedHandle.m_handleObjectID = 0LL;
				//       this.assetHandle.m_untrackedHandle.m_mainVersion = 0;
				//     }
				//     this.state = 3;
				//   }
				// }
				// 
			}

			public bool isInTexture;

			public ValueTuple<int, int> coords;

			public ValueTuple<int, int> coordsMod3;

			public WaterSectorRenderingPass.SectorState state;

			public FAssetProxyHandle assetHandle;

			public string texurePath;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 40)]
		private struct SectorLoadingNode
		{
			public bool Ready()
			{
				// // Boolean Ready()
				// bool HG::Rendering::Runtime::WaterSectorRenderingPass::SectorLoadingNode::Ready(
				//         WaterSectorRenderingPass_SectorLoadingNode *this,
				//         MethodInfo *method)
				// {
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v5; // rdx
				//   __int64 v6; // rcx
				// 
				//   if ( !IFix::WrappersManagerImpl::IsPatched(2899, 0LL) )
				//     return Beyond::Resource::FAssetProxyHandle::IsInvalid(&this.assetHandle, 0LL)
				//         || Beyond::Resource::FAssetProxyUntrackedHandle::get_isDone(&this.assetHandle.m_untrackedHandle, 0LL);
				//   Patch = IFix::WrappersManagerImpl::GetPatch(2899, 0LL);
				//   if ( !Patch )
				//     sub_180B536AC(v6, v5);
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1049(Patch, this, 0LL);
				// }
				// 
				return default(bool);
			}

			public void Release()
			{
				// // Void Release()
				// void HG::Rendering::Runtime::WaterSectorRenderingPass::SectorLoadingNode::Release(
				//         WaterSectorRenderingPass_SectorLoadingNode *this,
				//         MethodInfo *method)
				// {
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v4; // rdx
				//   __int64 v5; // rcx
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(2893, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(2893, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v5, v4);
				//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1048(Patch, this, 0LL);
				//   }
				//   else if ( Beyond::Resource::FAssetProxyHandle::IsValid(&this.assetHandle, 0LL) )
				//   {
				//     Beyond::Resource::FAssetProxyHandle::Dispose(&this.assetHandle, 0LL);
				//     *(_OWORD *)&this.assetHandle.m_untrackedHandle.m_handleObjectID = 0LL;
				//     this.assetHandle.m_untrackedHandle.m_mainVersion = 0;
				//   }
				// }
				// 
			}

			public int sectorIndex;

			public string texturePath;

			public FAssetProxyHandle assetHandle;
		}

		private class SectorCopyPassData
		{
			public SectorCopyPassData()
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

			public Vector4 scaleBiasTex;

			public Vector4 scaleBiasRT;

			public Texture2D copyTexture;
		}
	}
}
