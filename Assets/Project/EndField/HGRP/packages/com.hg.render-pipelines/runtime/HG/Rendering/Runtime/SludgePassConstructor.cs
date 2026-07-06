using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using HG.Rendering.Runtime.Sludge;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	internal class SludgePassConstructor : IPassConstructor
	{
		internal SludgePassConstructor(HGRenderPathBase.HGRenderPathResources resources)
		{
			// // SludgePassConstructor(HGRenderPathBase+HGRenderPathResources)
			// void HG::Rendering::Runtime::SludgePassConstructor::SludgePassConstructor(
			//         SludgePassConstructor *this,
			//         HGRenderPathBase_HGRenderPathResources *resources,
			//         MethodInfo *method)
			// {
			//   HGRenderPathBase_HGRenderPathResources *v5; // rdx
			//   __int64 v6; // rcx
			//   PassConstructorID__Enum__Array *v7; // r8
			//   HGCamera *v8; // r9
			//   TextureHandle v9; // xmm0
			//   HGRenderPipelineRuntimeResources *defaultResources; // rax
			//   HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
			//   PassConstructorID__Enum__Array *v12; // r8
			//   HGCamera *v13; // r9
			//   HGRenderPipelineRuntimeResources_ShaderResources *v14; // rax
			//   MethodInfo *v15[3]; // [rsp+20h] [rbp-18h] BYREF
			//   MethodInfo *v16; // [rsp+60h] [rbp+28h]
			//   MethodInfo *v17; // [rsp+68h] [rbp+30h]
			// 
			//   if ( !byte_18D8EDABE )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     byte_18D8EDABE = 1;
			//   }
			//   if ( !TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle, resources);
			//   this.fields.m_prevSludgeTexture = *(TextureHandle *)sub_182E7CCD0(v15);
			//   this.fields.m_prevSludgeThickness = *(TextureHandle *)sub_182E7CCD0(v15);
			//   v9 = *(TextureHandle *)sub_182E7CCD0(v15);
			//   defaultResources = resources.defaultResources;
			//   this.fields.m_prevSludgeMinHeight = v9;
			//   if ( !defaultResources
			//     || (shaders = defaultResources.fields.shaders) == 0LL
			//     || (this.fields.m_sludgeBlitShader = shaders.fields.sludgeBlitPS,
			//         sub_1800054D0((HGRenderPathScene *)&this.fields.m_sludgeBlitShader, v5, v7, v8, v15[0], v15[1]),
			//         !resources.defaultResources)
			//     || (v14 = resources.defaultResources.fields.shaders) == 0LL )
			//   {
			//     sub_180B536AC(v6, v5);
			//   }
			//   this.fields.m_sludgeBlitShaderV2 = v14.fields.sludgePS;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.m_sludgeBlitShaderV2, v5, v12, v13, v16, v17);
			// }
			// 
		}

		private void CreateSludgeResourceIfNotInted(HGRenderPipelineMaterialCollector materialCollector)
		{
			// // Void CreateSludgeResourceIfNotInted(HGRenderPipelineMaterialCollector)
			// void HG::Rendering::Runtime::SludgePassConstructor::CreateSludgeResourceIfNotInted(
			//         SludgePassConstructor *this,
			//         HGRenderPipelineMaterialCollector *materialCollector,
			//         MethodInfo *method)
			// {
			//   Object_1 *m_sludgeBlitMaterial; // rbx
			//   Byte__Array *v6; // rdx
			//   Texture2D *m_defaultThicknessMap; // rcx
			//   Object_1 *m_sludgeBlitMaterialV2; // rbx
			//   Object_1 *v9; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v10; // rdx
			//   PassConstructorID__Enum__Array *v11; // r8
			//   HGCamera *v12; // r9
			//   MaterialPropertyBlock *v13; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v14; // rdx
			//   PassConstructorID__Enum__Array *v15; // r8
			//   HGCamera *v16; // r9
			//   HGRenderPathBase_HGRenderPathResources *v17; // rdx
			//   PassConstructorID__Enum__Array *v18; // r8
			//   HGCamera *v19; // r9
			//   Texture2D *v20; // rax
			//   Texture2D *v21; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v22; // rdx
			//   PassConstructorID__Enum__Array *v23; // r8
			//   HGCamera *v24; // r9
			//   __int64 v25; // r8
			//   __int64 v26; // r9
			//   __int64 v27; // rax
			//   __int64 v28; // rax
			//   __int64 v29; // rax
			//   Texture2D *v30; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v31; // rdx
			//   PassConstructorID__Enum__Array *v32; // r8
			//   HGCamera *v33; // r9
			//   Texture2D *whiteTexture; // rax
			//   HGRenderPathBase_HGRenderPathResources *v35; // rdx
			//   PassConstructorID__Enum__Array *v36; // r8
			//   HGCamera *v37; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *mipCount; // [rsp+20h] [rbp-28h]
			//   MethodInfo *mipCounta; // [rsp+20h] [rbp-28h]
			//   MethodInfo *mipCountc; // [rsp+20h] [rbp-28h]
			//   MethodInfo *mipCountd; // [rsp+20h] [rbp-28h]
			//   MethodInfo *mipCountb; // [rsp+20h] [rbp-28h]
			//   MethodInfo *mipCounte; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v45; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v46; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v47; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v48; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v49; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v50; // [rsp+28h] [rbp-20h]
			// 
			//   if ( !byte_18D9195BF )
			//   {
			//     sub_18003C530(&TypeInfo::System::Byte);
			//     sub_18003C530(&TypeInfo::UnityEngine::MaterialPropertyBlock);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::RTHandles);
			//     sub_18003C530(&MethodInfo::UnityEngine::Texture2D::SetPixelData<unsigned char>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Texture2D);
			//     byte_18D9195BF = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2803, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2803, 0LL);
			//     if ( !Patch )
			//       goto LABEL_21;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)materialCollector,
			//       0LL);
			//   }
			//   else
			//   {
			//     m_sludgeBlitMaterial = (Object_1 *)this.fields.m_sludgeBlitMaterial;
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( !UnityEngine::Object::op_Implicit(m_sludgeBlitMaterial, 0LL)
			//       || (m_sludgeBlitMaterialV2 = (Object_1 *)this.fields.m_sludgeBlitMaterialV2,
			//           sub_180002C70(TypeInfo::UnityEngine::Object),
			//           !UnityEngine::Object::op_Implicit(m_sludgeBlitMaterialV2, 0LL))
			//       || (v9 = (Object_1 *)this.fields.m_defaultThicknessMap,
			//           sub_180002C70(TypeInfo::UnityEngine::Object),
			//           !UnityEngine::Object::op_Implicit(v9, 0LL)) )
			//     {
			//       if ( materialCollector )
			//       {
			//         this.fields.m_sludgeBlitMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
			//                                               materialCollector,
			//                                               this.fields.m_sludgeBlitShader,
			//                                               1,
			//                                               0LL);
			//         sub_1800054D0((HGRenderPathScene *)&this.fields.m_sludgeBlitMaterial, v10, v11, v12, mipCount, v45);
			//         v13 = (MaterialPropertyBlock *)sub_180004920(TypeInfo::UnityEngine::MaterialPropertyBlock);
			//         if ( v13 )
			//         {
			//           v13.fields.m_Ptr = UnityEngine::MaterialPropertyBlock::CreateImpl(0LL);
			//           this.fields.m_sludgeBlitPropertyBlock = v13;
			//           sub_1800054D0((HGRenderPathScene *)&this.fields.m_sludgeBlitPropertyBlock, v14, v15, v16, mipCounta, v46);
			//           this.fields.m_sludgeBlitMaterialV2 = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
			//                                                   materialCollector,
			//                                                   this.fields.m_sludgeBlitShaderV2,
			//                                                   1,
			//                                                   0LL);
			//           sub_1800054D0((HGRenderPathScene *)&this.fields.m_sludgeBlitMaterialV2, v17, v18, v19, mipCountc, v47);
			//           v20 = (Texture2D *)sub_180004920(TypeInfo::UnityEngine::Texture2D);
			//           v21 = v20;
			//           if ( v20 )
			//           {
			//             UnityEngine::Texture2D::Texture2D(
			//               v20,
			//               4,
			//               4,
			//               GraphicsFormat__Enum_R8G8B8A8_UNorm,
			//               1,
			//               TextureCreationFlags__Enum_None,
			//               0LL);
			//             this.fields.m_defaultThicknessMap = v21;
			//             sub_1800054D0((HGRenderPathScene *)&this.fields.m_defaultThicknessMap, v22, v23, v24, mipCountd, v48);
			//             v6 = (Byte__Array *)il2cpp_array_new_specific_0(TypeInfo::System::Byte, 64LL, v25, v26);
			//             m_defaultThicknessMap = 0LL;
			//             if ( v6 )
			//             {
			//               do
			//               {
			//                 if ( (unsigned int)m_defaultThicknessMap >= v6.max_length.size
			//                   || (v6.vector[(int)m_defaultThicknessMap] = 127,
			//                       v27 = (int)m_defaultThicknessMap + 1LL,
			//                       (unsigned int)v27 >= v6.max_length.size)
			//                   || (v6.vector[v27] = 127,
			//                       v28 = (int)m_defaultThicknessMap + 2LL,
			//                       (unsigned int)v28 >= v6.max_length.size)
			//                   || (v6.vector[v28] = -1,
			//                       v29 = (int)m_defaultThicknessMap + 3LL,
			//                       (unsigned int)v29 >= v6.max_length.size) )
			//                 {
			//                   sub_180070270(m_defaultThicknessMap, v6);
			//                 }
			//                 m_defaultThicknessMap = (Texture2D *)(unsigned int)((_DWORD)m_defaultThicknessMap + 4);
			//                 v6.vector[v29] = -1;
			//               }
			//               while ( (int)m_defaultThicknessMap < 64 );
			//               m_defaultThicknessMap = this.fields.m_defaultThicknessMap;
			//               if ( m_defaultThicknessMap )
			//               {
			//                 UnityEngine::Texture2D::SetPixelData<unsigned char>(
			//                   m_defaultThicknessMap,
			//                   v6,
			//                   0,
			//                   0,
			//                   MethodInfo::UnityEngine::Texture2D::SetPixelData<unsigned char>);
			//                 m_defaultThicknessMap = this.fields.m_defaultThicknessMap;
			//                 if ( m_defaultThicknessMap )
			//                 {
			//                   UnityEngine::Texture2D::Apply(m_defaultThicknessMap, 0LL);
			//                   v30 = this.fields.m_defaultThicknessMap;
			//                   sub_180002C70(TypeInfo::UnityEngine::Rendering::RTHandles);
			//                   this.fields.m_defaultThicknessMapRTHandle = UnityEngine::Rendering::RTHandleSystem::Alloc(
			//                                                                  (Texture *)v30,
			//                                                                  0LL);
			//                   sub_1800054D0(
			//                     (HGRenderPathScene *)&this.fields.m_defaultThicknessMapRTHandle,
			//                     v31,
			//                     v32,
			//                     v33,
			//                     mipCountb,
			//                     v49);
			//                   whiteTexture = UnityEngine::Texture2D::get_whiteTexture(0LL);
			//                   this.fields.m_defaultMinHeightRTHandle = UnityEngine::Rendering::RTHandleSystem::Alloc(
			//                                                               (Texture *)whiteTexture,
			//                                                               0LL);
			//                   sub_1800054D0(
			//                     (HGRenderPathScene *)&this.fields.m_defaultMinHeightRTHandle,
			//                     v35,
			//                     v36,
			//                     v37,
			//                     mipCounte,
			//                     v50);
			//                   return;
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			// LABEL_21:
			//       sub_180B536AC(m_defaultThicknessMap, v6);
			//     }
			//   }
			// }
			// 
		}

		public float GetCurrentTime()
		{
			// // Single GetCurrentTime()
			// float HG::Rendering::Runtime::SludgePassConstructor::GetCurrentTime(SludgePassConstructor *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !byte_18D9195C0 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRPTimeManager);
			//     byte_18D9195C0 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2804, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2804, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, v5);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_43((ILFixDynamicMethodWrapper_16 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRPTimeManager);
			//     return HG::Rendering::Runtime::HGRPTimeManager::get_gameplayTime(0LL);
			//   }
			// }
			// 
			return 0f;
		}

		private void PrepareSludgePassData(HGCamera hgCamera, ref SludgePassConstructor.SludgePassData passData)
		{
			// // Void PrepareSludgePassData(HGCamera, SludgePassConstructor+SludgePassData ByRef)
			// void HG::Rendering::Runtime::SludgePassConstructor::PrepareSludgePassData(
			//         SludgePassConstructor *this,
			//         HGCamera *hgCamera,
			//         SludgePassConstructor_SludgePassData **passData,
			//         MethodInfo *method)
			// {
			//   HGRenderPathBase_HGRenderPathResources *v7; // rdx
			//   SludgePassConstructor_SludgePassData *sludgeManager_k__BackingField; // rcx
			//   PassConstructorID__Enum__Array *v9; // r8
			//   HGCamera *v10; // r9
			//   SludgePassConstructor_SludgePassData *v11; // rsi
			//   HGManagerContext *currentManagerContext; // rax
			//   Mesh *PlaneMesh; // rax
			//   PassConstructorID__Enum__Array *v14; // r8
			//   HGCamera *v15; // r9
			//   PassConstructorID__Enum__Array *v16; // r8
			//   HGCamera *v17; // r9
			//   SludgePassConstructor_SludgePassData *v18; // rbp
			//   List_1_Cinemachine_TargetPositionCache_CacheEntry_RecordingItem_ *v19; // rax
			//   List_1_HG_Rendering_Runtime_Sludge_HGDynamicSludgePassData_ *v20; // rsi
			//   HGRenderPathBase_HGRenderPathResources *v21; // rdx
			//   PassConstructorID__Enum__Array *v22; // r8
			//   HGCamera *v23; // r9
			//   HGManagerContext *v24; // rax
			//   char v25; // dl
			//   __int64 v26; // rcx
			//   int v27; // r8d
			//   int v28; // eax
			//   float v29; // xmm0_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *v31; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v32; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v33; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v34; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v35; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v36; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v37; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v38; // [rsp+28h] [rbp-10h]
			// 
			//   if ( !byte_18D9195C1 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Sludge::HGDynamicSludgePassData>::List);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Sludge::HGDynamicSludgePassData>);
			//     byte_18D9195C1 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2805, 0LL) )
			//   {
			//     if ( *passData )
			//     {
			//       (*passData).fields.curSludgeTexture = this.fields.m_curSludgeTexture;
			//       if ( *passData )
			//       {
			//         (*passData).fields.prevSludgeTexture = this.fields.m_prevSludgeTexture;
			//         sludgeManager_k__BackingField = *passData;
			//         if ( *passData )
			//         {
			//           sludgeManager_k__BackingField.fields.sludgeBlitMaterial = this.fields.m_sludgeBlitMaterial;
			//           sub_1800054D0(
			//             (HGRenderPathScene *)&sludgeManager_k__BackingField.fields.sludgeBlitMaterial,
			//             v7,
			//             v9,
			//             v10,
			//             v31,
			//             v35);
			//           v11 = *passData;
			//           currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//           if ( currentManagerContext )
			//           {
			//             sludgeManager_k__BackingField = (SludgePassConstructor_SludgePassData *)currentManagerContext.fields._sludgeManager_k__BackingField;
			//             if ( sludgeManager_k__BackingField )
			//             {
			//               PlaneMesh = HG::Rendering::Runtime::HGSludgeManager::GetPlaneMesh(
			//                             (HGSludgeManager *)sludgeManager_k__BackingField,
			//                             0LL);
			//               if ( v11 )
			//               {
			//                 v11.fields.quadMesh = PlaneMesh;
			//                 sub_1800054D0((HGRenderPathScene *)&v11.fields.quadMesh, v7, v14, v15, v32, v36);
			//                 sludgeManager_k__BackingField = *passData;
			//                 if ( *passData )
			//                 {
			//                   sludgeManager_k__BackingField.fields.tempMaterialPropertyBlock = this.fields.m_sludgeBlitPropertyBlock;
			//                   sub_1800054D0(
			//                     (HGRenderPathScene *)&sludgeManager_k__BackingField.fields.tempMaterialPropertyBlock,
			//                     v7,
			//                     v16,
			//                     v17,
			//                     v33,
			//                     v37);
			//                   if ( this.fields.m_lastTime == 0.0 )
			//                     this.fields.m_lastTime = HG::Rendering::Runtime::SludgePassConstructor::GetCurrentTime(this, 0LL);
			//                   if ( *passData )
			//                   {
			//                     if ( !(*passData).fields.hgDynamicSludges )
			//                     {
			//                       v18 = *passData;
			//                       v19 = (List_1_Cinemachine_TargetPositionCache_CacheEntry_RecordingItem_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Sludge::HGDynamicSludgePassData>);
			//                       v20 = (List_1_HG_Rendering_Runtime_Sludge_HGDynamicSludgePassData_ *)v19;
			//                       if ( !v19 )
			//                         goto LABEL_24;
			//                       System::Collections::Generic::List<Cinemachine::TargetPositionCache_CacheEntry::RecordingItem>::List(
			//                         v19,
			//                         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Sludge::HGDynamicSludgePassData>::List);
			//                       v18.fields.hgDynamicSludges = v20;
			//                       sub_1800054D0((HGRenderPathScene *)&v18.fields.hgDynamicSludges, v21, v22, v23, v34, v38);
			//                     }
			//                     v24 = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//                     if ( v24 )
			//                     {
			//                       sludgeManager_k__BackingField = (SludgePassConstructor_SludgePassData *)v24.fields._sludgeManager_k__BackingField;
			//                       if ( *passData )
			//                       {
			//                         if ( sludgeManager_k__BackingField )
			//                         {
			//                           HG::Rendering::Runtime::HGSludgeManager::GetActiveDynamicSludgePassData(
			//                             (HGSludgeManager *)sludgeManager_k__BackingField,
			//                             (*passData).fields.hgDynamicSludges,
			//                             this.fields.m_lastTime,
			//                             0LL);
			//                           HG::Rendering::Runtime::SludgePassConstructor::GetCurrentTime(this, 0LL);
			//                           v28 = sub_182592070(v26, v25, v27);
			//                           sludgeManager_k__BackingField = *passData;
			//                           if ( *passData )
			//                           {
			//                             sludgeManager_k__BackingField.fields.lastTime = this.fields.m_lastTime;
			//                             v29 = (float)((float)v28 * 0.033) + this.fields.m_lastTime;
			//                             this.fields.m_lastTime = v29;
			//                             if ( *passData )
			//                             {
			//                               (*passData).fields.curTime = v29;
			//                               return;
			//                             }
			//                           }
			//                         }
			//                       }
			//                     }
			//                   }
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_24:
			//     sub_180B536AC(sludgeManager_k__BackingField, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2805, 0LL);
			//   if ( !Patch )
			//     goto LABEL_24;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1023(Patch, (Object *)this, (Object *)hgCamera, passData, 0LL);
			// }
			// 
		}

		private void PrepareSludgeTexture(HGRenderGraph renderGraph)
		{
			// // Void PrepareSludgeTexture(HGRenderGraph)
			// void HG::Rendering::Runtime::SludgePassConstructor::PrepareSludgeTexture(
			//         SludgePassConstructor *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   HGManagerContext *currentManagerContext; // rax
			//   HGSludgeManager *sludgeManager_k__BackingField; // rdx
			//   __int64 v7; // rcx
			//   HGSludgeConfig *Config; // rax
			//   int32_t graphicsFormat; // esi
			//   HGRenderGraphDefaultResources *m_DefaultResources; // rax
			//   HGRenderPathBase_HGRenderPathResources *v11; // rdx
			//   PassConstructorID__Enum__Array *v12; // r8
			//   HGCamera *v13; // r9
			//   MethodInfo *v14; // rdx
			//   Color v15; // xmm2
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *width; // [rsp+28h] [rbp-89h]
			//   MethodInfo *v18; // [rsp+30h] [rbp-81h]
			//   Vector4 v19; // [rsp+38h] [rbp-79h] BYREF
			//   TextureDesc v20; // [rsp+48h] [rbp-69h] BYREF
			//   TextureDesc v21; // [rsp+A8h] [rbp-9h] BYREF
			// 
			//   if ( !byte_18D9195C2 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&off_18D503D28);
			//     byte_18D9195C2 = 1;
			//   }
			//   sub_1802F01E0(&v20, 0LL, 96LL);
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2806, 0LL) )
			//   {
			//     currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//     if ( currentManagerContext )
			//     {
			//       sludgeManager_k__BackingField = currentManagerContext.fields._sludgeManager_k__BackingField;
			//       if ( sludgeManager_k__BackingField )
			//       {
			//         Config = HG::Rendering::Runtime::HGSludgeManager::GetConfig(
			//                    (HGSludgeConfig *)&v19,
			//                    sludgeManager_k__BackingField,
			//                    0LL);
			//         graphicsFormat = Config.graphicsFormat;
			//         width = (MethodInfo *)Config.textureSize;
			//         sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//         if ( !HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this.fields.m_prevSludgeTexture, 0LL) )
			//         {
			//           if ( !renderGraph )
			//             goto LABEL_13;
			//           m_DefaultResources = renderGraph.fields.m_DefaultResources;
			//           if ( !m_DefaultResources )
			//             goto LABEL_13;
			//           this.fields.m_prevSludgeTexture = m_DefaultResources.fields._whiteTexture_k__BackingField;
			//         }
			//         HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v20, (int32_t)width, SHIDWORD(width), 0LL);
			//         *(_WORD *)&v20.enableRandomWrite = 0;
			//         v20.name = (String *)"curSludgeTexture";
			//         v20.colorFormat = graphicsFormat;
			//         v20.autoGenerateMips = 0;
			//         sub_1800054D0((HGRenderPathScene *)&v20.name, v11, v12, v13, width, v18);
			//         v15 = (Color)_mm_loadu_si128((const __m128i *)UnityEngine::Vector4::get_one(&v19, v14));
			//         *(_OWORD *)&v21.width = *(_OWORD *)&v20.width;
			//         *(_OWORD *)&v21.enableRandomWrite = *(_OWORD *)&v20.enableRandomWrite;
			//         *(_OWORD *)&v21.colorFormat = *(_OWORD *)&v20.colorFormat;
			//         *(_OWORD *)&v21.fastMemoryDesc.inFastMemory = *(_OWORD *)&v20.fastMemoryDesc.inFastMemory;
			//         v20.clearColor = v15;
			//         *(_OWORD *)&v21.bindTextureMS = *(_OWORD *)&v20.bindTextureMS;
			//         v21.clearColor = v15;
			//         if ( renderGraph )
			//         {
			//           this.fields.m_curSludgeTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                                                (TextureHandle *)&v19,
			//                                                renderGraph,
			//                                                &v21,
			//                                                0LL);
			//           return;
			//         }
			//       }
			//     }
			// LABEL_13:
			//     sub_180B536AC(v7, sludgeManager_k__BackingField);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2806, 0LL);
			//   if ( !Patch )
			//     goto LABEL_13;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)renderGraph,
			//     0LL);
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::SludgePassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         SludgePassConstructor *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2808, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2808, 0LL);
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
			// void HG::Rendering::Runtime::SludgePassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         SludgePassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2809, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2809, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		internal void ConstructPass(ref SludgePassConstructor.PassInput input, ref SludgePassConstructor.PassOutput output, HGRenderGraph renderGraph, HGCamera camera)
		{
			// // Void ConstructPass(SludgePassConstructor+PassInput ByRef, SludgePassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
			// // Hidden C++ exception states: #wind=3
			// void HG::Rendering::Runtime::SludgePassConstructor::ConstructPass(
			//         SludgePassConstructor *this,
			//         SludgePassConstructor_PassInput *input,
			//         SludgePassConstructor_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   HGRenderGraph *v6; // rsi
			//   SludgePassConstructor *v9; // rdi
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   HGCamera *v12; // r15
			//   HGRenderPipelineMaterialCollector *MaterialCollector; // rax
			//   ProfilingSampler *v14; // rax
			//   __int64 v15; // rdx
			//   HGSludgeManager *sludgeManager_k__BackingField; // rcx
			//   Object *v17; // r14
			//   __int64 v18; // rdx
			//   __int64 v19; // rcx
			//   TextureHandle v20; // xmm0
			//   ProfilingSampler *v21; // rax
			//   __int64 v22; // rdx
			//   __int64 v23; // rcx
			//   __int64 v24; // r14
			//   __int64 v25; // rdx
			//   __int64 v26; // rcx
			//   TextureHandle v27; // xmm0
			//   __int64 v28; // r14
			//   __int64 v29; // rdx
			//   __int64 v30; // rcx
			//   TextureHandle v31; // xmm0
			//   float v32; // r12d
			//   __int128 v33; // xmm3
			//   __int128 v34; // xmm4
			//   unsigned __int64 v35; // r8
			//   signed __int64 v36; // rtt
			//   unsigned int depthBits; // r13d
			//   __int64 v38; // rdx
			//   __int64 v39; // rcx
			//   __int64 v40; // rdx
			//   unsigned int v41; // edx
			//   unsigned __int64 v42; // r8
			//   signed __int64 v43; // rtt
			//   __int64 v44; // r14
			//   Object_1 *v45; // rcx
			//   int32_t InstanceID; // eax
			//   __int64 v47; // rdx
			//   __int64 v48; // rcx
			//   TextureHandle *v49; // r8
			//   TextureHandle *p_m_curSludgeThickness; // r8
			//   HGManagerContext *currentManagerContext; // rax
			//   ProfilingSampler *v52; // rax
			//   __int64 v53; // rdx
			//   __int64 v54; // rcx
			//   __int64 v55; // rdx
			//   __int64 v56; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v58; // rdx
			//   __int64 v59; // rcx
			//   unsigned int depthFormat; // [rsp+50h] [rbp-248h]
			//   __int64 v61; // [rsp+58h] [rbp-240h] BYREF
			//   __m128i si128; // [rsp+60h] [rbp-238h] BYREF
			//   TextureHandle v63; // [rsp+70h] [rbp-228h] BYREF
			//   TextureHandle v64; // [rsp+80h] [rbp-218h] BYREF
			//   SludgePassConstructor_SludgePassData *passData; // [rsp+90h] [rbp-208h] BYREF
			//   HGRenderGraphBuilder v66; // [rsp+98h] [rbp-200h] BYREF
			//   Object *v67; // [rsp+B8h] [rbp-1E0h] BYREF
			//   HGRenderGraphBuilder v68; // [rsp+C0h] [rbp-1D8h] BYREF
			//   HGRenderGraphBuilder v69; // [rsp+E0h] [rbp-1B8h] BYREF
			//   HGRenderGraphBuilder v70; // [rsp+100h] [rbp-198h] BYREF
			//   __int128 v71; // [rsp+120h] [rbp-178h] BYREF
			//   __int128 v72; // [rsp+130h] [rbp-168h]
			//   __int128 v73; // [rsp+140h] [rbp-158h]
			//   __int128 v74; // [rsp+150h] [rbp-148h] BYREF
			//   __int128 v75; // [rsp+160h] [rbp-138h]
			//   __m128i clearColor; // [rsp+170h] [rbp-128h]
			//   Il2CppExceptionWrapper *v77; // [rsp+180h] [rbp-118h] BYREF
			//   Il2CppExceptionWrapper *v78; // [rsp+188h] [rbp-110h] BYREF
			//   Il2CppExceptionWrapper *v79; // [rsp+190h] [rbp-108h] BYREF
			//   TextureDesc v80; // [rsp+1A0h] [rbp-F8h] BYREF
			//   TextureDesc v81; // [rsp+200h] [rbp-98h] BYREF
			// 
			//   v6 = renderGraph;
			//   v9 = this;
			//   if ( !byte_18D9195C3 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::SludgePassConstructor::SludgePassDataV2>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::SludgePassConstructor::SludgePassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::SludgePassConstructor::SludgePassDataV2>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::SludgePassConstructor::SludgePassData>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::SludgePassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&off_18D503D40);
			//     sub_18003C530(&off_18D503D48);
			//     sub_18003C530(&off_18D503D28);
			//     sub_18003C530(&off_18D503D58);
			//     sub_18003C530(&off_18D503D70);
			//     sub_18003C530(&off_18D503B38);
			//     byte_18D9195C3 = 1;
			//   }
			//   memset(&v68, 0, sizeof(v68));
			//   v61 = 0LL;
			//   sub_1802F01E0(&v80, 0LL, 96LL);
			//   sub_1802F01E0(&v71, 0LL, 96LL);
			//   memset(&v70, 0, sizeof(v70));
			//   v67 = 0LL;
			//   memset(&v69, 0, sizeof(v69));
			//   passData = 0LL;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2810, 0LL) )
			//   {
			//     v12 = camera;
			//     if ( !camera )
			//       sub_180B536AC(v11, v10);
			//     MaterialCollector = HG::Rendering::Runtime::HGCamera::get_MaterialCollector(camera, 0LL);
			//     HG::Rendering::Runtime::SludgePassConstructor::CreateSludgeResourceIfNotInted(v9, MaterialCollector, 0LL);
			//     if ( !UnityEngine::HyperGryph::HGSludgeRender::ShouldDrawThicknessMap(0LL) )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//       v9.fields.m_prevSludgeThickness = *(TextureHandle *)sub_182E7CCD0(&v63);
			//       v9.fields.m_prevSludgeMinHeight = *(TextureHandle *)sub_182E7CCD0(&v63);
			//       v14 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//               (Int32Enum__Enum)0x76u,
			//               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//       if ( !v6 )
			//         goto LABEL_58;
			//       HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//         &v66,
			//         v6,
			//         (String *)"SludgeBlitSetDefault",
			//         &v67,
			//         v14,
			//         1,
			//         ProfilingHGPass__Enum_None,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::SludgePassConstructor::SludgePassDataV2>);
			//       v70 = v66;
			//       si128.m128i_i64[0] = 0LL;
			//       si128.m128i_i64[1] = (__int64)&v70;
			//       try
			//       {
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v70, 0, 0LL);
			//         v17 = v67;
			//         v64 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
			//                  &v63,
			//                  v6,
			//                  v9.fields.m_defaultThicknessMapRTHandle,
			//                  0LL);
			//         v20 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v63, &v70, &v64, 0LL);
			//         if ( !v17 )
			//           sub_1802DC2C8(v19, v18);
			//         *(TextureHandle *)((char *)&v17[3] + 4) = v20;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::SludgePassConstructor);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//           &v70,
			//           (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::SludgePassConstructor.static_fields.s_defaultBlitFunc,
			//           0LL,
			//           0,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::SludgePassConstructor::SludgePassDataV2>);
			//       }
			//       catch ( Il2CppExceptionWrapper *v77 )
			//       {
			//         *(Il2CppExceptionWrapper *)si128.m128i_i8 = (Il2CppExceptionWrapper)v77.ex;
			//         sub_180222690(&si128);
			//         v12 = camera;
			//         v6 = renderGraph;
			//         v9 = this;
			//         goto LABEL_34;
			//       }
			//       sub_180222690(&si128);
			//       goto LABEL_34;
			//     }
			//     v21 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//             (Int32Enum__Enum)0x76u,
			//             MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     if ( !v6 )
			//       sub_180B536AC(v23, v22);
			//     v68 = *(HGRenderGraphBuilder *)sub_180830D04(
			//                                      (unsigned int)&v66,
			//                                      (_DWORD)v6,
			//                                      (unsigned int)"RenderSludge",
			//                                      (unsigned int)&v61,
			//                                      (__int64)v21);
			//     v64.handle = 0LL;
			//     v64.fallBackResource = (ResourceHandle)&v68;
			//     try
			//     {
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v68, 0, 0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//       if ( !HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&v9.fields.m_prevSludgeThickness, 0LL) )
			//       {
			//         v9.fields.m_prevSludgeThickness = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
			//                                               &v63,
			//                                               v6,
			//                                               v9.fields.m_defaultThicknessMapRTHandle,
			//                                               0LL);
			//         v9.fields.m_prevSludgeMinHeight = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
			//                                               &v63,
			//                                               v6,
			//                                               v9.fields.m_defaultMinHeightRTHandle,
			//                                               0LL);
			//       }
			//       v24 = v61;
			//       v27 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                &v63,
			//                &v68,
			//                &v9.fields.m_prevSludgeThickness,
			//                0LL);
			//       if ( !v24 )
			//         sub_1802DC2C8(v26, v25);
			//       *(TextureHandle *)(v24 + 20) = v27;
			//       v28 = v61;
			//       v31 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                &v63,
			//                &v68,
			//                &v9.fields.m_prevSludgeMinHeight,
			//                0LL);
			//       if ( !v28 )
			//         sub_1802DC2C8(v30, v29);
			//       *(TextureHandle *)(v28 + 36) = v31;
			//       v32 = COERCE_FLOAT(UnityEngine::HyperGryph::HGSludgeRender::GetDynamicThicknessMapSize(0LL));
			//       sub_1802F01E0(&v81, 0LL, 96LL);
			//       HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v81, SLODWORD(v32), SLODWORD(v32), 0LL);
			//       v33 = *(_OWORD *)&v81.width;
			//       v71 = *(_OWORD *)&v81.width;
			//       v72 = *(_OWORD *)&v81.colorFormat;
			//       v73 = *(_OWORD *)&v81.enableRandomWrite;
			//       *(_QWORD *)&v74 = *(_QWORD *)&v81.bindTextureMS;
			//       v34 = *(_OWORD *)&v81.fastMemoryDesc.inFastMemory;
			//       v75 = *(_OWORD *)&v81.fastMemoryDesc.inFastMemory;
			//       clearColor = (__m128i)v81.clearColor;
			//       LODWORD(v72) = 8;
			//       LOWORD(v73) = 0;
			//       BYTE2(v73) = 0;
			//       *((_QWORD *)&v74 + 1) = "curSludgeTexture";
			//       if ( dword_18D8E43F8 )
			//       {
			//         v35 = ((((unsigned __int64)&v74 + 8) >> 12) & 0x1FFFFF) >> 6;
			//         _m_prefetchw(&qword_18D6405E0[v35 + 36190]);
			//         do
			//           v36 = qword_18D6405E0[v35 + 36190];
			//         while ( v36 != _InterlockedCompareExchange64(
			//                          &qword_18D6405E0[v35 + 36190],
			//                          v36 | (1LL << ((((unsigned __int64)&v74 + 8) >> 12) & 0x3F)),
			//                          v36) );
			//         v34 = v75;
			//         v33 = v71;
			//       }
			//       clearColor = _mm_load_si128((const __m128i *)&xmmword_18A357460);
			//       *(_OWORD *)&v80.width = v33;
			//       *(_OWORD *)&v80.colorFormat = v72;
			//       *(_OWORD *)&v80.enableRandomWrite = v73;
			//       *(_OWORD *)&v80.bindTextureMS = v74;
			//       *(_OWORD *)&v80.fastMemoryDesc.inFastMemory = v34;
			//       v80.clearColor = (Color)clearColor;
			//       v9.fields.m_curSludgeThickness = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                                            &v63,
			//                                            v6,
			//                                            &v80,
			//                                            0LL);
			//       v80.colorFormat = 5;
			//       v9.fields.m_curSludgeMinHeight = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                                            &v63,
			//                                            v6,
			//                                            &v80,
			//                                            0LL);
			//       depthBits = input.depthBits;
			//       depthFormat = input.depthFormat;
			//       *(float *)si128.m128i_i32 = v32;
			//       *(float *)&si128.m128i_i32[1] = v32;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//       v63 = *HG::Rendering::Runtime::HGRenderPipeline::CreateDepthBuffer(
			//                &v63,
			//                v6,
			//                0,
			//                MSAASamples__Enum_None,
			//                (DepthBits__Enum)depthBits,
			//                (GraphicsFormat__Enum)depthFormat,
			//                *(Vector2Int *)si128.m128i_i8,
			//                0LL);
			//       if ( !v61 )
			//         sub_1802DC2C8(v39, v38);
			//       *(TextureHandle *)(v61 + 52) = v9.fields.m_curSludgeThickness;
			//       if ( !v61 )
			//         sub_1802DC2C8(v39, v38);
			//       *(TextureHandle *)(v61 + 68) = v9.fields.m_curSludgeMinHeight;
			//       v40 = v61;
			//       if ( !v61 )
			//         sub_1802DC2C8(v39, 0LL);
			//       *(_QWORD *)(v61 + 88) = v9.fields.m_sludgeBlitMaterialV2;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v41 = ((unsigned __int64)(v40 + 88) >> 12) & 0x1FFFFF;
			//         v42 = (unsigned __int64)v41 >> 6;
			//         v40 = v41 & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v42 + 36190]);
			//         do
			//           v43 = qword_18D6405E0[v42 + 36190];
			//         while ( v43 != _InterlockedCompareExchange64(&qword_18D6405E0[v42 + 36190], v43 | (1LL << v40), v43) );
			//       }
			//       v44 = v61;
			//       v45 = (Object_1 *)camera.fields.camera;
			//       if ( !v45 )
			//         sub_1802DC2C8(0LL, v40);
			//       InstanceID = UnityEngine::Object::GetInstanceID(v45, 0LL);
			//       if ( !v44 )
			//         sub_1802DC2C8(v48, v47);
			//       *(_DWORD *)(v44 + 16) = InstanceID;
			//       si128 = *(__m128i *)sub_182562090(&si128, 4294934399LL);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//         (TextureHandle *)&v66,
			//         &v68,
			//         v49,
			//         0,
			//         RenderBufferLoadAction__Enum_DontCare,
			//         RenderBufferStoreAction__Enum_Store,
			//         (Color *)&si128,
			//         0,
			//         0LL);
			//       si128 = _mm_load_si128((const __m128i *)&xmmword_18A357460);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//         (TextureHandle *)&v66,
			//         &v68,
			//         &v9.fields.m_curSludgeMinHeight,
			//         1,
			//         RenderBufferLoadAction__Enum_DontCare,
			//         RenderBufferStoreAction__Enum_Store,
			//         (Color *)&si128,
			//         0,
			//         0LL);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
			//         (TextureHandle *)&v66,
			//         &v68,
			//         &v63,
			//         DepthAccess__Enum_Write,
			//         RenderBufferLoadAction__Enum_DontCare,
			//         RenderBufferStoreAction__Enum_DontCare,
			//         0.0,
			//         0,
			//         0,
			//         0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::SludgePassConstructor);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//         &v68,
			//         (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::SludgePassConstructor.static_fields.s_dynamicSludgeBlitFunc,
			//         0LL,
			//         0,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::SludgePassConstructor::SludgePassDataV2>);
			//     }
			//     catch ( Il2CppExceptionWrapper *v78 )
			//     {
			//       v64.handle = (ResourceHandle)v78.ex;
			//       sub_180222690(&v64);
			//       v9 = this;
			//       p_m_curSludgeThickness = &this.fields.m_curSludgeThickness;
			//       v6 = renderGraph;
			//       if ( !renderGraph )
			//         goto LABEL_58;
			//       v12 = camera;
			//       goto LABEL_33;
			//     }
			//     sub_180222690(&v64);
			//     p_m_curSludgeThickness = &v9.fields.m_curSludgeThickness;
			// LABEL_33:
			//     v9.fields.m_prevSludgeThickness = *HG::Rendering::RenderGraphModule::HGRenderGraph::PreserveTexture(
			//                                           (TextureHandle *)&v66,
			//                                           v6,
			//                                           p_m_curSludgeThickness,
			//                                           1,
			//                                           (String *)"prevSludgeThickness",
			//                                           0LL);
			//     v9.fields.m_prevSludgeMinHeight = *HG::Rendering::RenderGraphModule::HGRenderGraph::PreserveTexture(
			//                                           (TextureHandle *)&v66,
			//                                           v6,
			//                                           &v9.fields.m_curSludgeMinHeight,
			//                                           1,
			//                                           (String *)"prevSludgeMinHeight",
			//                                           0LL);
			// LABEL_34:
			//     currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//     if ( currentManagerContext )
			//     {
			//       sludgeManager_k__BackingField = currentManagerContext.fields._sludgeManager_k__BackingField;
			//       if ( sludgeManager_k__BackingField )
			//       {
			//         if ( HG::Rendering::Runtime::HGSludgeManager::HasActiveSludge(sludgeManager_k__BackingField, 0LL) )
			//         {
			//           HG::Rendering::Runtime::SludgePassConstructor::PrepareSludgeTexture(v9, v6, 0LL);
			//           v52 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//                   (Int32Enum__Enum)0x76u,
			//                   MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//           HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//             &v66,
			//             v6,
			//             (String *)"RenderSludge",
			//             (Object **)&passData,
			//             v52,
			//             1,
			//             ProfilingHGPass__Enum_None,
			//             MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::SludgePassConstructor::SludgePassData>);
			//           v69 = v66;
			//           v64.handle = 0LL;
			//           v64.fallBackResource = (ResourceHandle)&v69;
			//           try
			//           {
			//             HG::Rendering::Runtime::SludgePassConstructor::PrepareSludgePassData(v9, v12, &passData, 0LL);
			//             HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v69, 0, 0LL);
			//             if ( !passData )
			//               sub_1802DC2C8(v54, v53);
			//             HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//               (TextureHandle *)&v66,
			//               &v69,
			//               &passData.fields.prevSludgeTexture,
			//               0LL);
			//             if ( !passData )
			//               sub_1802DC2C8(v56, v55);
			//             v63 = (TextureHandle)_mm_load_si128((const __m128i *)&xmmword_18A357460);
			//             HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//               (TextureHandle *)&v66,
			//               &v69,
			//               &passData.fields.curSludgeTexture,
			//               0,
			//               RenderBufferLoadAction__Enum_Clear,
			//               RenderBufferStoreAction__Enum_Store,
			//               (Color *)&v63,
			//               0,
			//               0LL);
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::SludgePassConstructor);
			//             HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//               &v69,
			//               (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::SludgePassConstructor.static_fields.s_sludgeFunc,
			//               0LL,
			//               0,
			//               MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::SludgePassConstructor::SludgePassData>);
			//           }
			//           catch ( Il2CppExceptionWrapper *v79 )
			//           {
			//             v64.handle = (ResourceHandle)v79.ex;
			//             sub_180222690(&v64);
			//             v6 = renderGraph;
			//             v9 = this;
			//             goto LABEL_42;
			//           }
			//           sub_180222690(&v64);
			// LABEL_42:
			//           v9.fields.m_prevSludgeTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::PreserveTexture(
			//                                               (TextureHandle *)&v66,
			//                                               v6,
			//                                               &v9.fields.m_curSludgeTexture,
			//                                               1,
			//                                               (String *)"prevSludgeTexture",
			//                                               0LL);
			//         }
			//         return;
			//       }
			//     }
			// LABEL_58:
			//     sub_1802DC2C8(sludgeManager_k__BackingField, v15);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2810, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v59, v58);
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1024(
			//     Patch,
			//     (Object *)v9,
			//     input,
			//     output,
			//     (Object *)v6,
			//     (Object *)camera,
			//     0LL);
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::SludgePassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         SludgePassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2811, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2811, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph renderGraph)
		{
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		internal static readonly int _Hit;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x04")]
		internal static readonly int _HitRange;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		internal static readonly int _HitPosition;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x0C")]
		internal static readonly int _DeltaTime;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		internal static readonly int _TotalTime;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x14")]
		internal static readonly int _AtlasTillingOffset;

		private TextureHandle m_curSludgeTexture;

		private TextureHandle m_prevSludgeTexture;

		private TextureHandle m_prevSludgeThickness;

		private TextureHandle m_prevSludgeMinHeight;

		private TextureHandle m_curSludgeThickness;

		private TextureHandle m_curSludgeMinHeight;

		private MaterialPropertyBlock m_sludgeBlitPropertyBlock;

		private Material m_sludgeBlitMaterial;

		private Shader m_sludgeBlitShader;

		private Material m_sludgeBlitMaterialV2;

		private Shader m_sludgeBlitShaderV2;

		private Texture2D m_defaultThicknessMap;

		private RTHandle m_defaultThicknessMapRTHandle;

		private RTHandle m_defaultMinHeightRTHandle;

		private float m_lastTime;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x18")]
		private static readonly RenderFunc<SludgePassConstructor.SludgePassData> s_sludgeFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x20")]
		private static readonly RenderFunc<SludgePassConstructor.SludgePassDataV2> s_dynamicSludgeBlitFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x28")]
		private static readonly RenderFunc<SludgePassConstructor.SludgePassDataV2> s_defaultBlitFunc;

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 8)]
		internal struct PassInput
		{
			internal DepthBits depthBits;

			internal GraphicsFormat depthFormat;
		}

		internal struct PassOutput
		{
		}

		internal class SludgePassData
		{
			public SludgePassData()
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

			internal TextureHandle curSludgeTexture;

			internal TextureHandle prevSludgeTexture;

			internal Material sludgeBlitMaterial;

			internal Mesh quadMesh;

			internal MaterialPropertyBlock tempMaterialPropertyBlock;

			internal float lastTime;

			internal float curTime;

			internal List<HGDynamicSludgePassData> hgDynamicSludges;
		}

		internal class SludgePassDataV2
		{
			public SludgePassDataV2()
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

			internal int viewHandle;

			internal TextureHandle prevSludgeThicknessTexture;

			internal TextureHandle prevSludgeMinHeightTexture;

			internal TextureHandle curSludgeThicknessTexture;

			internal TextureHandle curSludgeMinHeightTexture;

			internal Material blitMaterial;
		}
	}
}
