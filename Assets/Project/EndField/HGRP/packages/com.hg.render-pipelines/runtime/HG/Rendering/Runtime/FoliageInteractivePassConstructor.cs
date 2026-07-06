using System;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	internal class FoliageInteractivePassConstructor : IPassConstructor
	{
		internal FoliageInteractivePassConstructor(HGRenderPipelineMaterialCollector materialCollector, HGRenderPathBase.HGRenderPathResources resources)
		{
			// // FoliageInteractivePassConstructor(HGRenderPipelineMaterialCollector, HGRenderPathBase+HGRenderPathResources)
			// void HG::Rendering::Runtime::FoliageInteractivePassConstructor::FoliageInteractivePassConstructor(
			//         FoliageInteractivePassConstructor *this,
			//         HGRenderPipelineMaterialCollector *materialCollector,
			//         HGRenderPathBase_HGRenderPathResources *resources,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   Texture2D *blackTexture; // rbp
			//   OneofDescriptorProto *v9; // rdx
			//   FileDescriptor *v10; // r8
			//   MessageDescriptor *v11; // r9
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   HGRenderPipelineRuntimeResources_ShaderResources *shaders; // r8
			//   MethodInfo *methoda; // [rsp+20h] [rbp-28h]
			//   String *v16; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v17; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D8EDA77 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::RTHandles);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     byte_18D8EDA77 = 1;
			//   }
			//   if ( !TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle, materialCollector);
			//   this.fields.m_prevDualHeightTexture = *(TextureHandle *)sub_182E7CCD0(&v17);
			//   blackTexture = UnityEngine::Texture2D::get_blackTexture(0LL);
			//   if ( !TypeInfo::UnityEngine::Rendering::RTHandles._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Rendering::RTHandles, v7);
			//   this.fields.m_defaultDualHeightTexture = UnityEngine::Rendering::RTHandleSystem::Alloc((Texture *)blackTexture, 0LL);
			//   sub_1800054D0((OneofDescriptor *)&this.fields, v9, v10, v11, (String__Array *)methoda, v16, v17);
			//   if ( !resources.defaultResources || (shaders = resources.defaultResources.fields.shaders) == 0LL )
			//     sub_180B536AC(v13, v12);
			//   HG::Rendering::Runtime::FoliageInteractivePassConstructor::InitializeFoliageInteractiveResource(
			//     this,
			//     materialCollector,
			//     shaders.fields.foliageInteractiveBlitPS,
			//     resources.defaultResources.fields.shaders.fields.foliageInteractiveColliderPS,
			//     0LL);
			// }
			// 
		}

		private void InitializeFoliageInteractiveResource(HGRenderPipelineMaterialCollector materialCollector, Shader blitShader, Shader colliderShader)
		{
			// // Void InitializeFoliageInteractiveResource(HGRenderPipelineMaterialCollector, Shader, Shader)
			// void HG::Rendering::Runtime::FoliageInteractivePassConstructor::InitializeFoliageInteractiveResource(
			//         FoliageInteractivePassConstructor *this,
			//         HGRenderPipelineMaterialCollector *materialCollector,
			//         Shader *blitShader,
			//         Shader *colliderShader,
			//         MethodInfo *method)
			// {
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   OneofDescriptorProto *v11; // rdx
			//   FileDescriptor *v12; // r8
			//   MessageDescriptor *v13; // r9
			//   OneofDescriptorProto *v14; // rdx
			//   FileDescriptor *v15; // r8
			//   MessageDescriptor *v16; // r9
			//   MaterialPropertyBlock *v17; // rdi
			//   OneofDescriptorProto *v18; // rdx
			//   FileDescriptor *v19; // r8
			//   MessageDescriptor *v20; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Object *P3; // [rsp+20h] [rbp-18h]
			//   Object *P3b; // [rsp+20h] [rbp-18h]
			//   Object *P3a; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v25; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v26; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v27; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v28; // [rsp+30h] [rbp-8h]
			//   MethodInfo *v29; // [rsp+30h] [rbp-8h]
			//   MethodInfo *v30; // [rsp+30h] [rbp-8h]
			// 
			//   if ( !byte_18D8EDA78 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::MaterialPropertyBlock);
			//     byte_18D8EDA78 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2602, 0LL) )
			//   {
			//     if ( materialCollector )
			//     {
			//       this.fields.m_foliageInteriaveBlitMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
			//                                                       materialCollector,
			//                                                       blitShader,
			//                                                       1,
			//                                                       0LL);
			//       sub_1800054D0(
			//         (OneofDescriptor *)&this.fields.m_foliageInteriaveBlitMaterial,
			//         v11,
			//         v12,
			//         v13,
			//         (String__Array *)P3,
			//         (String *)v25,
			//         v28);
			//       this.fields.m_foliageInteriaveColliderMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
			//                                                           materialCollector,
			//                                                           colliderShader,
			//                                                           1,
			//                                                           0LL);
			//       sub_1800054D0(
			//         (OneofDescriptor *)&this.fields.m_foliageInteriaveColliderMaterial,
			//         v14,
			//         v15,
			//         v16,
			//         (String__Array *)P3b,
			//         (String *)v26,
			//         v29);
			//       v17 = (MaterialPropertyBlock *)sub_180004920(TypeInfo::UnityEngine::MaterialPropertyBlock);
			//       if ( v17 )
			//       {
			//         v17.fields.m_Ptr = UnityEngine::MaterialPropertyBlock::CreateImpl(0LL);
			//         this.fields.m_dualHeightBlitPropertyBlock = v17;
			//         sub_1800054D0(
			//           (OneofDescriptor *)&this.fields.m_dualHeightBlitPropertyBlock,
			//           v18,
			//           v19,
			//           v20,
			//           (String__Array *)P3a,
			//           (String *)v27,
			//           v30);
			//         return;
			//       }
			//     }
			// LABEL_7:
			//     sub_180B536AC(v10, v9);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2602, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_7(
			//     (ILFixDynamicMethodWrapper_20 *)Patch,
			//     (Object *)this,
			//     (Object *)materialCollector,
			//     (Object *)blitShader,
			//     (Object *)colliderShader,
			//     0LL);
			// }
			// 
		}

		private void PrepareFoliageInteractPassData(HGCamera hgCamera, ref FoliageInteractivePassConstructor.FoliageInteractivePassData passData)
		{
			// // Void PrepareFoliageInteractPassData(HGCamera, FoliageInteractivePassConstructor+FoliageInteractivePassData ByRef)
			// void HG::Rendering::Runtime::FoliageInteractivePassConstructor::PrepareFoliageInteractPassData(
			//         FoliageInteractivePassConstructor *this,
			//         HGCamera *hgCamera,
			//         FoliageInteractivePassConstructor_FoliageInteractivePassData **passData,
			//         MethodInfo *method)
			// {
			//   OneofDescriptorProto *v7; // rdx
			//   __int64 z_low; // rcx
			//   FileDescriptor *v9; // r8
			//   MessageDescriptor *v10; // r9
			//   FileDescriptor *v11; // r8
			//   MessageDescriptor *v12; // r9
			//   FileDescriptor *v13; // r8
			//   FoliageInteractivePassConstructor_FoliageInteractivePassData *v14; // r9
			//   float z; // eax
			//   FoliageInteractivePassConstructor_FoliageInteractivePassData *v16; // rax
			//   FoliageInteractivePassConstructor_FoliageInteractivePassData *v17; // rax
			//   FoliageInteractivePassConstructor_FoliageInteractivePassData *v18; // rax
			//   float v19; // eax
			//   __int64 v20; // xmm0_8
			//   float v21; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   String__Array *v23; // [rsp+20h] [rbp-18h]
			//   String__Array *v24; // [rsp+20h] [rbp-18h]
			//   String__Array *v25; // [rsp+20h] [rbp-18h]
			//   String *v26; // [rsp+28h] [rbp-10h]
			//   String *v27; // [rsp+28h] [rbp-10h]
			//   String *v28; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v29; // [rsp+30h] [rbp-8h]
			//   MethodInfo *v30; // [rsp+30h] [rbp-8h]
			//   MethodInfo *v31; // [rsp+30h] [rbp-8h]
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2603, 0LL) )
			//   {
			//     if ( *passData )
			//     {
			//       (*passData).fields.curDualHeightTexture = this.fields.m_curDualHeightTexture;
			//       if ( *passData )
			//       {
			//         (*passData).fields.prevDualHeightTexture = this.fields.m_prevDualHeightTexture;
			//         z_low = (__int64)*passData;
			//         if ( *passData )
			//         {
			//           *(_QWORD *)(z_low + 48) = this.fields.m_foliageInteriaveBlitMaterial;
			//           sub_1800054D0((OneofDescriptor *)(z_low + 48), v7, v9, v10, v23, v26, v29);
			//           z_low = (__int64)*passData;
			//           if ( *passData )
			//           {
			//             *(_QWORD *)(z_low + 56) = this.fields.m_foliageInteriaveColliderMaterial;
			//             sub_1800054D0((OneofDescriptor *)(z_low + 56), v7, v11, v12, v24, v27, v30);
			//             v14 = *passData;
			//             z = this.fields.m_curCenterPosition.z;
			//             if ( *passData )
			//             {
			//               *(_QWORD *)&v14.fields.curCenterPosition.x = *(_QWORD *)&this.fields.m_curCenterPosition.x;
			//               v14.fields.curCenterPosition.z = z;
			//               v16 = *passData;
			//               z_low = LODWORD(this.fields.m_curCenterSize.z);
			//               if ( *passData )
			//               {
			//                 *(_QWORD *)&v16.fields.curCenterSize.x = *(_QWORD *)&this.fields.m_curCenterSize.x;
			//                 LODWORD(v16.fields.curCenterSize.z) = z_low;
			//                 v17 = *passData;
			//                 z_low = LODWORD(this.fields.m_lastCenterPosition.z);
			//                 if ( *passData )
			//                 {
			//                   *(_QWORD *)&v17.fields.lastCenterPosition.x = *(_QWORD *)&this.fields.m_lastCenterPosition.x;
			//                   LODWORD(v17.fields.lastCenterPosition.z) = z_low;
			//                   v18 = *passData;
			//                   z_low = LODWORD(this.fields.m_lastCenterSize.z);
			//                   if ( *passData )
			//                   {
			//                     *(_QWORD *)&v18.fields.lastCenterSize.x = *(_QWORD *)&this.fields.m_lastCenterSize.x;
			//                     LODWORD(v18.fields.lastCenterSize.z) = z_low;
			//                     z_low = (__int64)*passData;
			//                     if ( *passData )
			//                     {
			//                       *(_QWORD *)(z_low + 64) = this.fields.m_dualHeightBlitPropertyBlock;
			//                       sub_1800054D0((OneofDescriptor *)(z_low + 64), v7, v13, (MessageDescriptor *)v14, v25, v28, v31);
			//                       v19 = this.fields.m_curCenterPosition.z;
			//                       *(_QWORD *)&this.fields.m_lastCenterPosition.x = *(_QWORD *)&this.fields.m_curCenterPosition.x;
			//                       v20 = *(_QWORD *)&this.fields.m_curCenterSize.x;
			//                       this.fields.m_lastCenterPosition.z = v19;
			//                       v21 = this.fields.m_curCenterSize.z;
			//                       *(_QWORD *)&this.fields.m_lastCenterSize.x = v20;
			//                       this.fields.m_lastCenterSize.z = v21;
			//                       return;
			//                     }
			//                   }
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_13:
			//     sub_180B536AC(z_low, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2603, 0LL);
			//   if ( !Patch )
			//     goto LABEL_13;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_953(Patch, (Object *)this, (Object *)hgCamera, passData, 0LL);
			// }
			// 
		}

		private void PrepareFoliageInteractTexture(HGRenderGraph renderGraph)
		{
			// // Void PrepareFoliageInteractTexture(HGRenderGraph)
			// void HG::Rendering::Runtime::FoliageInteractivePassConstructor::PrepareFoliageInteractTexture(
			//         FoliageInteractivePassConstructor *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   HGManagerContext *currentManagerContext; // rax
			//   HGFoliageInteractiveManager *foliageInteractiveManager_k__BackingField; // rdx
			//   __int64 v7; // rcx
			//   HGFoliageInteractiveConfig *Config; // rax
			//   __m128i v9; // xmm6
			//   int32_t graphicsFormat; // esi
			//   OneofDescriptorProto *v11; // rdx
			//   FileDescriptor *v12; // r8
			//   MessageDescriptor *v13; // r9
			//   MethodInfo *v14; // rdx
			//   Color v15; // xmm2
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Color v17; // [rsp+28h] [rbp-E0h] BYREF
			//   MethodInfo *v18; // [rsp+38h] [rbp-D0h]
			//   _BYTE v19[104]; // [rsp+40h] [rbp-C8h] BYREF
			//   TextureDesc v20; // [rsp+A8h] [rbp-60h] BYREF
			// 
			//   if ( !byte_18D919545 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&off_18D4FD8E0);
			//     byte_18D919545 = 1;
			//   }
			//   sub_1802F01E0(&v19[8], 0LL, 96LL);
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2604, 0LL) )
			//   {
			//     currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//     if ( currentManagerContext )
			//     {
			//       foliageInteractiveManager_k__BackingField = currentManagerContext.fields._foliageInteractiveManager_k__BackingField;
			//       if ( foliageInteractiveManager_k__BackingField )
			//       {
			//         Config = HG::Rendering::Runtime::HGFoliageInteractiveManager::GetConfig(
			//                    (HGFoliageInteractiveConfig *)&v17,
			//                    foliageInteractiveManager_k__BackingField,
			//                    0LL);
			//         v9 = *(__m128i *)&Config.textureSize.m_X;
			//         graphicsFormat = Config.graphicsFormat;
			//         sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//         if ( !HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this.fields.m_prevDualHeightTexture, 0LL) )
			//         {
			//           if ( !renderGraph )
			//             goto LABEL_12;
			//           this.fields.m_prevDualHeightTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
			//                                                     (TextureHandle *)&v17,
			//                                                     renderGraph,
			//                                                     this.fields.m_defaultDualHeightTexture,
			//                                                     0LL);
			//         }
			//         HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
			//           (TextureDesc *)&v19[8],
			//           _mm_cvtsi128_si32(v9),
			//           _mm_cvtsi128_si32(_mm_srli_si128(v9, 4)),
			//           0LL);
			//         *(_WORD *)&v19[40] = 0;
			//         *(_QWORD *)&v19[64] = "curDualHeightTexture";
			//         *(_DWORD *)&v19[24] = graphicsFormat;
			//         v19[42] = 0;
			//         sub_1800054D0((OneofDescriptor *)&v19[64], v11, v12, v13, *(String__Array **)&v17.r, *(String **)&v17.b, v18);
			//         v15 = (Color)_mm_loadu_si128((const __m128i *)UnityEngine::Color::get_yellow(&v17, v14));
			//         v19[85] = 1;
			//         *(_OWORD *)&v20.width = *(_OWORD *)&v19[8];
			//         *(_OWORD *)&v20.enableRandomWrite = *(_OWORD *)&v19[40];
			//         *(_OWORD *)&v20.colorFormat = *(_OWORD *)&v19[24];
			//         *(_OWORD *)&v20.fastMemoryDesc.inFastMemory = *(_OWORD *)&v19[72];
			//         *(Color *)&v19[88] = v15;
			//         *(_OWORD *)&v20.bindTextureMS = *(_OWORD *)&v19[56];
			//         v20.clearColor = v15;
			//         if ( renderGraph )
			//         {
			//           this.fields.m_curDualHeightTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                                                    (TextureHandle *)&v17,
			//                                                    renderGraph,
			//                                                    &v20,
			//                                                    0LL);
			//           return;
			//         }
			//       }
			//     }
			// LABEL_12:
			//     sub_180B536AC(v7, foliageInteractiveManager_k__BackingField);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2604, 0LL);
			//   if ( !Patch )
			//     goto LABEL_12;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)renderGraph,
			//     0LL);
			// }
			// 
		}

		private void PostPrepareFoliageInteractTexture(HGRenderGraph renderGraph)
		{
			// // Void PostPrepareFoliageInteractTexture(HGRenderGraph)
			// void HG::Rendering::Runtime::FoliageInteractivePassConstructor::PostPrepareFoliageInteractTexture(
			//         FoliageInteractivePassConstructor *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   TextureHandle v8; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D919546 )
			//   {
			//     sub_18003C530(&off_18D4FD930);
			//     byte_18D919546 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2605, 0LL) )
			//   {
			//     if ( renderGraph )
			//     {
			//       this.fields.m_prevDualHeightTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::PreserveTexture(
			//                                                 &v8,
			//                                                 renderGraph,
			//                                                 &this.fields.m_curDualHeightTexture,
			//                                                 1,
			//                                                 (String *)"FoliageInteractivePass",
			//                                                 0LL);
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2605, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
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
			// void HG::Rendering::Runtime::FoliageInteractivePassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         FoliageInteractivePassConstructor *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   HGManagerContext *currentManagerContext; // rax
			//   __int64 v6; // rdx
			//   HGFoliageInteractiveManager *foliageInteractiveManager_k__BackingField; // rcx
			//   float z; // eax
			//   __int64 v9; // xmm5_8
			//   MethodInfo *z_low; // r8
			//   __int64 v11; // xmm0_8
			//   float v12; // eax
			//   Vector4 *v13; // rax
			//   __int64 v14; // xmm5_8
			//   MethodInfo *v15; // r8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector4 centerPosition; // [rsp+20h] [rbp-20h] BYREF
			//   Vector3 centerSize; // [rsp+30h] [rbp-10h] BYREF
			// 
			//   *(_QWORD *)&centerPosition.x = 0LL;
			//   centerPosition.z = 0.0;
			//   *(_QWORD *)&centerSize.x = 0LL;
			//   centerSize.z = 0.0;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2606, 0LL) )
			//   {
			//     currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//     if ( currentManagerContext )
			//     {
			//       foliageInteractiveManager_k__BackingField = currentManagerContext.fields._foliageInteractiveManager_k__BackingField;
			//       if ( foliageInteractiveManager_k__BackingField )
			//       {
			//         HG::Rendering::Runtime::HGFoliageInteractiveManager::GetCenter(
			//           foliageInteractiveManager_k__BackingField,
			//           (Vector3 *)&centerPosition,
			//           &centerSize,
			//           0LL);
			//         z = centerSize.z;
			//         v9 = *(_QWORD *)&centerPosition.x;
			//         z_low = (MethodInfo *)LODWORD(centerPosition.z);
			//         *(_QWORD *)&this.fields.m_curCenterSize.x = *(_QWORD *)&centerSize.x;
			//         v11 = *(_QWORD *)&this.fields.m_lastCenterPosition.x;
			//         this.fields.m_curCenterSize.z = z;
			//         v12 = this.fields.m_lastCenterPosition.z;
			//         *(_QWORD *)&this.fields.m_curCenterPosition.x = v9;
			//         *(_QWORD *)&centerSize.x = v11;
			//         centerSize.z = v12;
			//         LODWORD(this.fields.m_curCenterPosition.z) = (_DWORD)z_low;
			//         v13 = UnityEngine::Vector4::op_Implicit(&centerPosition, &centerSize, z_low);
			//         *(_QWORD *)&centerSize.x = v14;
			//         LODWORD(centerSize.z) = (_DWORD)v15;
			//         *(__m128i *)&shaderVariablesGlobal._CharacterParams0.w = _mm_loadu_si128((const __m128i *)v13);
			//         *(__m128i *)&shaderVariablesGlobal._VFXParams3.w = _mm_loadu_si128((const __m128i *)UnityEngine::Vector4::op_Implicit(
			//                                                                                                &centerPosition,
			//                                                                                                &centerSize,
			//                                                                                                v15));
			//         return;
			//       }
			//     }
			// LABEL_6:
			//     sub_180B536AC(foliageInteractiveManager_k__BackingField, v6);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2606, 0LL);
			//   if ( !Patch )
			//     goto LABEL_6;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_340(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::FoliageInteractivePassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         FoliageInteractivePassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2607, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2607, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		internal void ConstructPass(ref FoliageInteractivePassConstructor.PassInput input, ref FoliageInteractivePassConstructor.PassOutput output, HGRenderGraph renderGraph, HGCamera camera)
		{
			// // Void ConstructPass(FoliageInteractivePassConstructor+PassInput ByRef, FoliageInteractivePassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::FoliageInteractivePassConstructor::ConstructPass(
			//         FoliageInteractivePassConstructor *this,
			//         FoliageInteractivePassConstructor_PassInput *input,
			//         FoliageInteractivePassConstructor_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   HGRenderGraph *v6; // rdi
			//   FoliageInteractivePassConstructor *v9; // rbx
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   HGSettingParameters *settingParams; // rsi
			//   __int64 v13; // rdx
			//   __int64 v14; // rcx
			//   char v15; // dl
			//   __int64 v16; // rcx
			//   int v17; // r8d
			//   float v18; // xmm7_4
			//   ProfilingSampler *v19; // rax
			//   __int64 v20; // rdx
			//   __int64 v21; // rcx
			//   __int64 v22; // rdx
			//   __int64 v23; // rcx
			//   __int64 v24; // rdx
			//   __int64 v25; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v27; // rdx
			//   __int64 v28; // rcx
			//   FoliageInteractivePassConstructor_FoliageInteractivePassData *passData; // [rsp+50h] [rbp-98h] BYREF
			//   Il2CppExceptionWrapper *v30; // [rsp+58h] [rbp-90h] BYREF
			//   _QWORD v31[2]; // [rsp+60h] [rbp-88h] BYREF
			//   __m128i si128; // [rsp+70h] [rbp-78h] BYREF
			//   HGRenderGraphBuilder v33; // [rsp+80h] [rbp-68h] BYREF
			//   HGRenderGraphBuilder v34; // [rsp+A0h] [rbp-48h] BYREF
			// 
			//   v6 = renderGraph;
			//   v9 = this;
			//   if ( !byte_18D919547 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::FoliageInteractivePassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRPTimeManager);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::FoliageInteractivePassConstructor::FoliageInteractivePassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::FoliageInteractivePassConstructor::FoliageInteractivePassData>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     sub_18003C530(&off_18D4FD950);
			//     byte_18D919547 = 1;
			//   }
			//   passData = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2608, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2608, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v28, v27);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_954(
			//       Patch,
			//       (Object *)v9,
			//       input,
			//       output,
			//       (Object *)v6,
			//       (Object *)camera,
			//       0LL);
			//   }
			//   else
			//   {
			//     settingParams = input.settingParams;
			//     if ( !settingParams )
			//       sub_180B536AC(v11, v10);
			//     if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//            settingParams.fields._foliageInteractiveEnable_k__BackingField,
			//            MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
			//     {
			//       if ( !v6 )
			//         sub_180B536AC(v14, v13);
			//       if ( !v6.fields._enableCppRenderPath_k__BackingField )
			//       {
			//         if ( v9.fields.m_lastTime == 0.0 )
			//         {
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRPTimeManager);
			//           v9.fields.m_lastTime = HG::Rendering::Runtime::HGRPTimeManager::get_gameplayTime(0LL);
			//         }
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRPTimeManager);
			//         HG::Rendering::Runtime::HGRPTimeManager::get_gameplayTime(0LL);
			//         v18 = (float)(int)sub_182592070(v16, v15, v17) * 0.033;
			//         v9.fields.m_lastTime = v9.fields.m_lastTime + v18;
			//         HG::Rendering::Runtime::FoliageInteractivePassConstructor::PrepareFoliageInteractTexture(v9, v6, 0LL);
			//         v19 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//                 (Int32Enum__Enum)0x75u,
			//                 MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//         HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//           &v33,
			//           v6,
			//           (String *)"Foliage Interactive",
			//           (Object **)&passData,
			//           v19,
			//           1,
			//           ProfilingHGPass__Enum_None,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::FoliageInteractivePassConstructor::FoliageInteractivePassData>);
			//         v34 = v33;
			//         v31[0] = 0LL;
			//         v31[1] = &v34;
			//         try
			//         {
			//           HG::Rendering::Runtime::FoliageInteractivePassConstructor::PrepareFoliageInteractPassData(
			//             v9,
			//             camera,
			//             &passData,
			//             0LL);
			//           if ( !passData )
			//             sub_1802DC2C8(v21, v20);
			//           passData.fields.deltaTime = v18;
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v34, 0, 0LL);
			//           if ( !passData )
			//             sub_1802DC2C8(v23, v22);
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//             (TextureHandle *)&si128,
			//             &v34,
			//             &passData.fields.prevDualHeightTexture,
			//             0LL);
			//           if ( !passData )
			//             sub_1802DC2C8(v25, v24);
			//           si128 = _mm_load_si128((const __m128i *)&xmmword_18C1756B0);
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//             (TextureHandle *)&v33,
			//             &v34,
			//             &passData.fields.curDualHeightTexture,
			//             0,
			//             RenderBufferLoadAction__Enum_DontCare,
			//             RenderBufferStoreAction__Enum_Store,
			//             (Color *)&si128,
			//             0,
			//             0LL);
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::FoliageInteractivePassConstructor);
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//             &v34,
			//             (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::FoliageInteractivePassConstructor.static_fields.s_foliageInteractiveFunc,
			//             0LL,
			//             0,
			//             MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::FoliageInteractivePassConstructor::FoliageInteractivePassData>);
			//         }
			//         catch ( Il2CppExceptionWrapper *v30 )
			//         {
			//           v31[0] = v30.ex;
			//           sub_180222690(v31);
			//           v6 = renderGraph;
			//           v9 = this;
			//           goto LABEL_16;
			//         }
			//         sub_180222690(v31);
			// LABEL_16:
			//         HG::Rendering::Runtime::FoliageInteractivePassConstructor::PostPrepareFoliageInteractTexture(v9, v6, 0LL);
			//       }
			//     }
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::FoliageInteractivePassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         FoliageInteractivePassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   HGRenderGraph *renderGraph; // rdi
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   TextureHandle v9; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D919548 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&off_18D4FD930);
			//     byte_18D919548 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2609, 0LL) )
			//   {
			//     renderGraph = input.renderGraph;
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     if ( !HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this.fields.m_prevDualHeightTexture, 0LL) )
			//       return;
			//     if ( renderGraph )
			//     {
			//       this.fields.m_prevDualHeightTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::PreserveTexture(
			//                                                 &v9,
			//                                                 renderGraph,
			//                                                 &this.fields.m_prevDualHeightTexture,
			//                                                 1,
			//                                                 (String *)"FoliageInteractivePass",
			//                                                 0LL);
			//       return;
			//     }
			// LABEL_8:
			//     sub_180B536AC(v7, v6);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2609, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph renderGraph)
		{
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		internal static readonly int _LastCenterPos;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x04")]
		internal static readonly int _LastCenterSize;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		internal static readonly int _CurCenterPos;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x0C")]
		internal static readonly int _CurCenterSize;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		internal static readonly int _DeltaTime;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x14")]
		internal static readonly int _RaiseSpeed;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x18")]
		internal static readonly int _PerInstanceData;

		private RTHandle m_defaultDualHeightTexture;

		private TextureHandle m_curDualHeightTexture;

		private TextureHandle m_prevDualHeightTexture;

		private MaterialPropertyBlock m_dualHeightBlitPropertyBlock;

		private Material m_foliageInteriaveBlitMaterial;

		private Material m_foliageInteriaveColliderMaterial;

		private Vector3 m_curCenterPosition;

		private Vector3 m_curCenterSize;

		private Vector3 m_lastCenterPosition;

		private Vector3 m_lastCenterSize;

		private float m_lastTime;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x20")]
		private static readonly RenderFunc<FoliageInteractivePassConstructor.FoliageInteractivePassData> s_foliageInteractiveFunc;

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct PassInput
		{
			internal HGSettingParameters settingParams;
		}

		internal struct PassOutput
		{
		}

		internal class FoliageInteractivePassData
		{
			public FoliageInteractivePassData()
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

			internal TextureHandle curDualHeightTexture;

			internal TextureHandle prevDualHeightTexture;

			internal Material foliageInteriaveBlitMaterial;

			internal Material foliageInteriaveColliderMaterial;

			internal MaterialPropertyBlock tempMaterialPropertyBlock;

			internal Vector3 curCenterPosition;

			internal Vector3 curCenterSize;

			internal Vector3 lastCenterPosition;

			internal Vector3 lastCenterSize;

			internal float deltaTime;
		}
	}
}
