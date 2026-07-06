using System;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	internal class UIImageBlurPassConstructor : IPassConstructor
	{
		internal UIImageBlurPassConstructor(HGRenderPipelineMaterialCollector materialCollector, HGRenderPathBase.HGRenderPathResources resources)
		{
			// // UIImageBlurPassConstructor(HGRenderPipelineMaterialCollector, HGRenderPathBase+HGRenderPathResources)
			// void HG::Rendering::Runtime::UIImageBlurPassConstructor::UIImageBlurPassConstructor(
			//         UIImageBlurPassConstructor *this,
			//         HGRenderPipelineMaterialCollector *materialCollector,
			//         HGRenderPathBase_HGRenderPathResources *resources,
			//         MethodInfo *method)
			// {
			//   HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
			//   HGRenderPathBase_HGRenderPathResources *v6; // rdx
			//   PassConstructorID__Enum__Array *v7; // r8
			//   HGCamera *v8; // r9
			//   MethodInfo *v9; // [rsp+50h] [rbp+28h]
			//   MethodInfo *v10; // [rsp+58h] [rbp+30h]
			// 
			//   if ( !resources.defaultResources
			//     || (shaders = resources.defaultResources.fields.shaders) == 0LL
			//     || !materialCollector )
			//   {
			//     sub_180B536AC(this, materialCollector);
			//   }
			//   this.fields.m_uiImageBlurMat = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
			//                                     materialCollector,
			//                                     shaders.fields.uiImageBlurPS,
			//                                     0,
			//                                     0LL);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields, v6, v7, v8, v9, v10);
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::UIImageBlurPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         UIImageBlurPassConstructor *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2854, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2854, 0LL);
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
			// void HG::Rendering::Runtime::UIImageBlurPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         UIImageBlurPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2855, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2855, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		internal void ConstructPass(ref UIImageBlurPassConstructor.PassInput input, ref UIImageBlurPassConstructor.PassOutput output, HGRenderGraph renderGraph, HGCamera camera)
		{
			// // Void ConstructPass(UIImageBlurPassConstructor+PassInput ByRef, UIImageBlurPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::UIImageBlurPassConstructor::ConstructPass(
			//         UIImageBlurPassConstructor *this,
			//         UIImageBlurPassConstructor_PassInput *input,
			//         UIImageBlurPassConstructor_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   UIImageBlurPassConstructor_PassInput *v8; // r12
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   ProfilingSampler *v12; // rax
			//   __int64 v13; // rdx
			//   __int64 v14; // rcx
			//   int v15; // r8d
			//   __int64 v16; // rdx
			//   UIImageBlurManager *instance; // rcx
			//   __int64 v18; // rdx
			//   Texture *Source; // rsi
			//   UIImageBlurManager *v20; // rcx
			//   RenderTexture *Target; // r13
			//   UIImageBlurManager__StaticFields *static_fields; // rcx
			//   UIImageBlurManager *v23; // rdx
			//   __int64 v24; // rdx
			//   __int64 v25; // rcx
			//   __m128 v26; // xmm6
			//   float v27; // xmm7_4
			//   float v28; // xmm8_4
			//   Rect *v29; // rdi
			//   UIImageBlurManager *v30; // rcx
			//   __int64 v31; // rdx
			//   __int64 v32; // rcx
			//   Rect *v33; // rdi
			//   int v34; // r14d
			//   int v35; // eax
			//   __int64 v36; // rdx
			//   __int64 v37; // rcx
			//   __int64 v38; // rdx
			//   unsigned __int64 v39; // rdx
			//   unsigned __int64 v40; // r8
			//   char v41; // dl
			//   signed __int64 v42; // rtt
			//   __int64 v43; // r14
			//   RTHandle *v44; // rax
			//   __int64 v45; // rdx
			//   __int64 v46; // rcx
			//   unsigned __int64 v47; // r8
			//   signed __int64 v48; // rtt
			//   __int64 v49; // rsi
			//   RTHandle *v50; // rax
			//   __int64 v51; // rdx
			//   __int64 v52; // rcx
			//   unsigned __int64 v53; // r9
			//   signed __int64 v54; // rtt
			//   __int64 v55; // rdx
			//   __int64 v56; // rcx
			//   unsigned __int64 v57; // r8
			//   signed __int64 v58; // rtt
			//   TextureHandle *v59; // rdi
			//   __int64 v60; // rdx
			//   __int64 v61; // rcx
			//   TextureHandle v62; // xmm0
			//   __int64 v63; // rdx
			//   __int64 v64; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v66; // rdx
			//   __int64 v67; // rcx
			//   unsigned __int128 v68; // [rsp+40h] [rbp-1D8h] BYREF
			//   __int64 v69; // [rsp+50h] [rbp-1C8h] BYREF
			//   int v70; // [rsp+58h] [rbp-1C0h]
			//   HGRenderGraphBuilder v71; // [rsp+60h] [rbp-1B8h] BYREF
			//   TextureDesc v72; // [rsp+80h] [rbp-198h] BYREF
			//   _QWORD v73[4]; // [rsp+E0h] [rbp-138h] BYREF
			//   Il2CppExceptionWrapper *v74; // [rsp+100h] [rbp-118h] BYREF
			//   TextureDesc v75; // [rsp+110h] [rbp-108h] BYREF
			//   TextureDesc v76; // [rsp+170h] [rbp-A8h] BYREF
			// 
			//   v8 = input;
			//   if ( !byte_18D9195DD )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::UIImageBlurPassConstructor::UIImageBlurPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::UIImageBlurPassConstructor::UIImageBlurPassData>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::RTHandles);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::UIImageBlurManager);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::UIImageBlurPassConstructor);
			//     sub_18003C530(&off_18D502EF8);
			//     sub_18003C530(&off_18D502F10);
			//     byte_18D9195DD = 1;
			//   }
			//   memset(&v71, 0, sizeof(v71));
			//   v69 = 0LL;
			//   sub_1802F01E0(&v76, 0LL, 96LL);
			//   sub_1802F01E0(&v72, 0LL, 96LL);
			//   if ( IFix::WrappersManagerImpl::IsPatched(2856, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2856, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v67, v66);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1037(
			//       Patch,
			//       (Object *)this,
			//       v8,
			//       output,
			//       (Object *)renderGraph,
			//       (Object *)camera,
			//       0LL);
			//   }
			//   else
			//   {
			//     if ( !v8.uiImageBlurMgr )
			//       sub_180B536AC(v11, v10);
			//     if ( HG::Rendering::Runtime::UIImageBlurManager::ShouldRenderUIImageBlur(v8.uiImageBlurMgr, 0LL) )
			//     {
			//       v12 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//               (Int32Enum__Enum)0x1Eu,
			//               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//       if ( !renderGraph )
			//         sub_180B536AC(v14, v13);
			//       v71 = *(HGRenderGraphBuilder *)sub_180830D7C(
			//                                        (unsigned int)v73,
			//                                        (_DWORD)renderGraph,
			//                                        v15,
			//                                        (unsigned int)&v69,
			//                                        (__int64)v12);
			//       v73[0] = 0LL;
			//       v73[1] = &v71;
			//       try
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::UIImageBlurManager);
			//         instance = TypeInfo::HG::Rendering::Runtime::UIImageBlurManager.static_fields.instance;
			//         if ( !instance )
			//           sub_1802DC2C8(0LL, v16);
			//         Source = HG::Rendering::Runtime::UIImageBlurManager::GetSource(instance, 0LL);
			//         v20 = TypeInfo::HG::Rendering::Runtime::UIImageBlurManager.static_fields.instance;
			//         if ( !v20 )
			//           sub_1802DC2C8(0LL, v18);
			//         Target = HG::Rendering::Runtime::UIImageBlurManager::GetTarget(v20, 0LL);
			//         static_fields = TypeInfo::HG::Rendering::Runtime::UIImageBlurManager.static_fields;
			//         v23 = static_fields.instance;
			//         if ( !v23 )
			//           sub_1802DC2C8(static_fields, 0LL);
			//         v26 = (__m128)_mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::UIImageBlurManager::GetRect(
			//                                                          (Rect *)&v68,
			//                                                          v23,
			//                                                          0LL));
			//         v27 = _mm_shuffle_ps(v26, v26, 255).m128_f32[0];
			//         v28 = _mm_shuffle_ps(v26, v26, 170).m128_f32[0];
			//         *(float *)&v68 = v28;
			//         *((float *)&v68 + 1) = v27;
			//         *((float *)&v68 + 2) = 1.0 / v28;
			//         *((float *)&v68 + 3) = 1.0 / v27;
			//         if ( !v69 )
			//           sub_1802DC2C8(v25, v24);
			//         *(_OWORD *)(v69 + 16) = v68;
			//         v29 = (Rect *)v69;
			//         v30 = TypeInfo::HG::Rendering::Runtime::UIImageBlurManager.static_fields.instance;
			//         if ( !v30 )
			//           sub_1802DC2C8(0LL, v24);
			//         v68 = COERCE_UNSIGNED_INT(HG::Rendering::Runtime::UIImageBlurManager::GetScale(v30, 0LL));
			//         if ( !v29 )
			//           sub_1802DC2C8(v32, v31);
			//         v29[2] = (Rect)v68;
			//         v33 = (Rect *)v69;
			//         if ( !Source )
			//           sub_1802DC2C8(v32, v31);
			//         LODWORD(v68) = sub_18003ED00(5LL);
			//         v70 = sub_18003ED00(7LL);
			//         v34 = sub_18003ED00(5LL);
			//         v35 = sub_18003ED00(7LL);
			//         *(float *)&v68 = v26.m128_f32[0] / (float)(int)v68;
			//         *((float *)&v68 + 1) = _mm_shuffle_ps(v26, v26, 85).m128_f32[0] / (float)v70;
			//         *((float *)&v68 + 2) = v28 / (float)v34;
			//         *((float *)&v68 + 3) = v27 / (float)v35;
			//         if ( !v33 )
			//           sub_1802DC2C8(v37, v36);
			//         v33[3] = (Rect)v68;
			//         v38 = v69;
			//         if ( !v69 )
			//           sub_1802DC2C8(v37, 0LL);
			//         *(_QWORD *)(v69 + 96) = this.fields.m_uiImageBlurMat;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v39 = ((unsigned __int64)(v38 + 96) >> 12) & 0x1FFFFF;
			//           v40 = v39 >> 6;
			//           v41 = v39 & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v40 + 36190]);
			//           do
			//             v42 = qword_18D6405E0[v40 + 36190];
			//           while ( v42 != _InterlockedCompareExchange64(&qword_18D6405E0[v40 + 36190], v42 | (1LL << v41), v42) );
			//         }
			//         v43 = v69;
			//         sub_180002C70(TypeInfo::UnityEngine::Rendering::RTHandles);
			//         v44 = UnityEngine::Rendering::RTHandleSystem::Alloc(Source, 0LL);
			//         if ( !v43 )
			//           sub_1802DC2C8(v46, v45);
			//         *(_QWORD *)(v43 + 64) = v44;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v47 = (((unsigned __int64)(v43 + 64) >> 12) & 0x1FFFFF) >> 6;
			//           _m_prefetchw(&qword_18D6405E0[v47 + 36190]);
			//           do
			//             v48 = qword_18D6405E0[v47 + 36190];
			//           while ( v48 != _InterlockedCompareExchange64(
			//                            &qword_18D6405E0[v47 + 36190],
			//                            v48 | (1LL << (((unsigned __int64)(v43 + 64) >> 12) & 0x3F)),
			//                            v48) );
			//         }
			//         v49 = v69;
			//         v50 = UnityEngine::Rendering::RTHandleSystem::Alloc(Target, 0LL);
			//         if ( !v49 )
			//           sub_1802DC2C8(v52, v51);
			//         *(_QWORD *)(v49 + 72) = v50;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v53 = (((unsigned __int64)(v49 + 72) >> 12) & 0x1FFFFF) >> 6;
			//           _m_prefetchw(&qword_18D6405E0[v53 + 36190]);
			//           do
			//             v54 = qword_18D6405E0[v53 + 36190];
			//           while ( v54 != _InterlockedCompareExchange64(
			//                            &qword_18D6405E0[v53 + 36190],
			//                            v54 | (1LL << (((unsigned __int64)(v49 + 72) >> 12) & 0x3F)),
			//                            v54) );
			//         }
			//         sub_1802F01E0(&v75, 0LL, 96LL);
			//         HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v75, (int)v28, (int)v27, 0LL);
			//         v72 = v75;
			//         if ( !Target )
			//           sub_1802DC2C8(v56, v55);
			//         v72.colorFormat = UnityEngine::RenderTexture::get_graphicsFormat(Target, 0LL);
			//         v72.enableRandomWrite = 0;
			//         v72.name = (String *)"UI Image Blur Temp";
			//         if ( dword_18D8E43F8 )
			//         {
			//           v57 = (((unsigned __int64)&v72.name >> 12) & 0x1FFFFF) >> 6;
			//           _m_prefetchw(&qword_18D6405E0[v57 + 36190]);
			//           do
			//             v58 = qword_18D6405E0[v57 + 36190];
			//           while ( v58 != _InterlockedCompareExchange64(
			//                            &qword_18D6405E0[v57 + 36190],
			//                            v58 | (1LL << (((unsigned __int64)&v72.name >> 12) & 0x3F)),
			//                            v58) );
			//         }
			//         *(_QWORD *)&v72.filterMode = 0x100000001LL;
			//         v76 = v72;
			//         v59 = (TextureHandle *)v69;
			//         v62 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(
			//                  (TextureHandle *)&v68,
			//                  &v71,
			//                  &v76,
			//                  0LL);
			//         if ( !v59 )
			//           sub_1802DC2C8(v61, v60);
			//         v59[5] = v62;
			//         if ( !v69 )
			//           sub_1802DC2C8(v61, v60);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//           (TextureHandle *)&v68,
			//           &v71,
			//           (TextureHandle *)(v69 + 80),
			//           0,
			//           0,
			//           0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::UIImageBlurPassConstructor);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//           &v71,
			//           (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::UIImageBlurPassConstructor.static_fields.s_UIImageBlurRenderFunc,
			//           0LL,
			//           0,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::UIImageBlurPassConstructor::UIImageBlurPassData>);
			//       }
			//       catch ( Il2CppExceptionWrapper *v74 )
			//       {
			//         v73[0] = v74.ex;
			//         sub_180222690(v73);
			//         v8 = input;
			//         goto LABEL_36;
			//       }
			//       sub_180222690(v73);
			// LABEL_36:
			//       if ( !v8.uiImageBlurMgr )
			//         sub_1802DC2C8(v64, v63);
			//       HG::Rendering::Runtime::UIImageBlurManager::CloseUIBlurPass(v8.uiImageBlurMgr, 0LL);
			//     }
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::UIImageBlurPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         UIImageBlurPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2857, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2857, 0LL);
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
			// void HG::Rendering::Runtime::UIImageBlurPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
			//         UIImageBlurPassConstructor *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2858, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2858, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)renderGraph,
			//       0LL);
			//   }
			// }
			// 
		}

		internal void ConstructRenderPass(ref UIImageBlurPassConstructor.PassInput input, ref UIImageBlurPassConstructor.PassOutput output, HGRenderGraph renderGraph)
		{
			// // Void ConstructRenderPass(UIImageBlurPassConstructor+PassInput ByRef, UIImageBlurPassConstructor+PassOutput ByRef, HGRenderGraph)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::UIImageBlurPassConstructor::ConstructRenderPass(
			//         UIImageBlurPassConstructor *this,
			//         UIImageBlurPassConstructor_PassInput *input,
			//         UIImageBlurPassConstructor_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   __int64 v9; // rdx
			//   UIImageBlurManager__StaticFields *static_fields; // rcx
			//   ProfilingSampler *v11; // rax
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   int v14; // r8d
			//   __int64 v15; // rdx
			//   UIImageBlurManager *instance; // rcx
			//   __int64 v17; // rdx
			//   Texture *Source; // rsi
			//   UIImageBlurManager *v19; // rcx
			//   RenderTexture *Target; // r12
			//   UIImageBlurManager__StaticFields *v21; // rcx
			//   UIImageBlurManager *v22; // rdx
			//   __int64 v23; // rdx
			//   __int64 v24; // rcx
			//   __m128 v25; // xmm6
			//   float v26; // xmm7_4
			//   float v27; // xmm8_4
			//   Rect *v28; // rdi
			//   UIImageBlurManager *v29; // rcx
			//   __int64 v30; // rdx
			//   __int64 v31; // rcx
			//   Rect *v32; // rdi
			//   int v33; // r15d
			//   int v34; // r14d
			//   int v35; // eax
			//   __int64 v36; // rdx
			//   __int64 v37; // rcx
			//   __int64 v38; // rdx
			//   unsigned __int64 v39; // rdx
			//   unsigned __int64 v40; // r8
			//   char v41; // dl
			//   signed __int64 v42; // rtt
			//   __int64 v43; // r14
			//   RTHandle *v44; // rax
			//   __int64 v45; // rdx
			//   __int64 v46; // rcx
			//   unsigned __int64 v47; // r8
			//   signed __int64 v48; // rtt
			//   __int64 v49; // rsi
			//   RTHandle *v50; // rax
			//   __int64 v51; // rdx
			//   __int64 v52; // rcx
			//   unsigned __int64 v53; // r9
			//   signed __int64 v54; // rtt
			//   __int64 v55; // rdx
			//   __int64 v56; // rcx
			//   unsigned __int64 v57; // r8
			//   signed __int64 v58; // rtt
			//   TextureHandle *v59; // rdi
			//   __int64 v60; // rdx
			//   __int64 v61; // rcx
			//   TextureHandle v62; // xmm0
			//   __int64 v63; // rdx
			//   UIImageBlurManager *v64; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v66; // rdx
			//   __int64 v67; // rcx
			//   unsigned __int128 v68; // [rsp+40h] [rbp-1D8h] BYREF
			//   __int64 v69; // [rsp+50h] [rbp-1C8h] BYREF
			//   HGRenderGraphBuilder v70; // [rsp+58h] [rbp-1C0h] BYREF
			//   TextureDesc v71; // [rsp+80h] [rbp-198h] BYREF
			//   _QWORD v72[4]; // [rsp+E0h] [rbp-138h] BYREF
			//   Il2CppExceptionWrapper *v73; // [rsp+100h] [rbp-118h] BYREF
			//   TextureDesc v74; // [rsp+110h] [rbp-108h] BYREF
			//   TextureDesc v75; // [rsp+170h] [rbp-A8h] BYREF
			// 
			//   if ( !byte_18D9195DE )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::UIImageBlurPassConstructor::UIImageBlurPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::UIImageBlurPassConstructor::UIImageBlurPassData>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::RTHandles);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::UIImageBlurManager);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::UIImageBlurPassConstructor);
			//     sub_18003C530(&off_18D502EF8);
			//     sub_18003C530(&off_18D502F10);
			//     byte_18D9195DE = 1;
			//   }
			//   memset(&v70, 0, sizeof(v70));
			//   v69 = 0LL;
			//   sub_1802F01E0(&v75, 0LL, 96LL);
			//   sub_1802F01E0(&v71, 0LL, 96LL);
			//   if ( IFix::WrappersManagerImpl::IsPatched(2859, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2859, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v67, v66);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1038(Patch, (Object *)this, input, output, (Object *)renderGraph, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::UIImageBlurManager);
			//     static_fields = TypeInfo::HG::Rendering::Runtime::UIImageBlurManager.static_fields;
			//     if ( !static_fields.instance )
			//       sub_180B536AC(static_fields, v9);
			//     if ( HG::Rendering::Runtime::UIImageBlurManager::ShouldRenderUIImageBlur(static_fields.instance, 0LL) )
			//     {
			//       v11 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//               (Int32Enum__Enum)0x1Eu,
			//               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//       if ( !renderGraph )
			//         sub_180B536AC(v13, v12);
			//       v70 = *(HGRenderGraphBuilder *)sub_180830D7C(
			//                                        (unsigned int)v72,
			//                                        (_DWORD)renderGraph,
			//                                        v14,
			//                                        (unsigned int)&v69,
			//                                        (__int64)v11);
			//       v72[0] = 0LL;
			//       v72[1] = &v70;
			//       try
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::UIImageBlurManager);
			//         instance = TypeInfo::HG::Rendering::Runtime::UIImageBlurManager.static_fields.instance;
			//         if ( !instance )
			//           sub_1802DC2C8(0LL, v15);
			//         Source = HG::Rendering::Runtime::UIImageBlurManager::GetSource(instance, 0LL);
			//         v19 = TypeInfo::HG::Rendering::Runtime::UIImageBlurManager.static_fields.instance;
			//         if ( !v19 )
			//           sub_1802DC2C8(0LL, v17);
			//         Target = HG::Rendering::Runtime::UIImageBlurManager::GetTarget(v19, 0LL);
			//         v21 = TypeInfo::HG::Rendering::Runtime::UIImageBlurManager.static_fields;
			//         v22 = v21.instance;
			//         if ( !v22 )
			//           sub_1802DC2C8(v21, 0LL);
			//         v25 = (__m128)_mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::UIImageBlurManager::GetRect(
			//                                                          (Rect *)&v68,
			//                                                          v22,
			//                                                          0LL));
			//         v26 = _mm_shuffle_ps(v25, v25, 255).m128_f32[0];
			//         v27 = _mm_shuffle_ps(v25, v25, 170).m128_f32[0];
			//         *(float *)&v68 = v27;
			//         *((float *)&v68 + 1) = v26;
			//         *((float *)&v68 + 2) = 1.0 / v27;
			//         *((float *)&v68 + 3) = 1.0 / v26;
			//         if ( !v69 )
			//           sub_1802DC2C8(v24, v23);
			//         *(_OWORD *)(v69 + 16) = v68;
			//         v28 = (Rect *)v69;
			//         v29 = TypeInfo::HG::Rendering::Runtime::UIImageBlurManager.static_fields.instance;
			//         if ( !v29 )
			//           sub_1802DC2C8(0LL, v23);
			//         v68 = COERCE_UNSIGNED_INT(HG::Rendering::Runtime::UIImageBlurManager::GetScale(v29, 0LL));
			//         if ( !v28 )
			//           sub_1802DC2C8(v31, v30);
			//         v28[2] = (Rect)v68;
			//         v32 = (Rect *)v69;
			//         if ( !Source )
			//           sub_1802DC2C8(v31, v30);
			//         LODWORD(v68) = sub_18003ED00(5LL);
			//         v33 = sub_18003ED00(7LL);
			//         v34 = sub_18003ED00(5LL);
			//         v35 = sub_18003ED00(7LL);
			//         *(float *)&v68 = v25.m128_f32[0] / (float)(int)v68;
			//         *((float *)&v68 + 1) = _mm_shuffle_ps(v25, v25, 85).m128_f32[0] / (float)v33;
			//         *((float *)&v68 + 2) = v27 / (float)v34;
			//         *((float *)&v68 + 3) = v26 / (float)v35;
			//         if ( !v32 )
			//           sub_1802DC2C8(v37, v36);
			//         v32[3] = (Rect)v68;
			//         v38 = v69;
			//         if ( !v69 )
			//           sub_1802DC2C8(v37, 0LL);
			//         *(_QWORD *)(v69 + 96) = this.fields.m_uiImageBlurMat;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v39 = ((unsigned __int64)(v38 + 96) >> 12) & 0x1FFFFF;
			//           v40 = v39 >> 6;
			//           v41 = v39 & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v40 + 36190]);
			//           do
			//             v42 = qword_18D6405E0[v40 + 36190];
			//           while ( v42 != _InterlockedCompareExchange64(&qword_18D6405E0[v40 + 36190], v42 | (1LL << v41), v42) );
			//         }
			//         v43 = v69;
			//         sub_180002C70(TypeInfo::UnityEngine::Rendering::RTHandles);
			//         v44 = UnityEngine::Rendering::RTHandleSystem::Alloc(Source, 0LL);
			//         if ( !v43 )
			//           sub_1802DC2C8(v46, v45);
			//         *(_QWORD *)(v43 + 64) = v44;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v47 = (((unsigned __int64)(v43 + 64) >> 12) & 0x1FFFFF) >> 6;
			//           _m_prefetchw(&qword_18D6405E0[v47 + 36190]);
			//           do
			//             v48 = qword_18D6405E0[v47 + 36190];
			//           while ( v48 != _InterlockedCompareExchange64(
			//                            &qword_18D6405E0[v47 + 36190],
			//                            v48 | (1LL << (((unsigned __int64)(v43 + 64) >> 12) & 0x3F)),
			//                            v48) );
			//         }
			//         v49 = v69;
			//         v50 = UnityEngine::Rendering::RTHandleSystem::Alloc(Target, 0LL);
			//         if ( !v49 )
			//           sub_1802DC2C8(v52, v51);
			//         *(_QWORD *)(v49 + 72) = v50;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v53 = (((unsigned __int64)(v49 + 72) >> 12) & 0x1FFFFF) >> 6;
			//           _m_prefetchw(&qword_18D6405E0[v53 + 36190]);
			//           do
			//             v54 = qword_18D6405E0[v53 + 36190];
			//           while ( v54 != _InterlockedCompareExchange64(
			//                            &qword_18D6405E0[v53 + 36190],
			//                            v54 | (1LL << (((unsigned __int64)(v49 + 72) >> 12) & 0x3F)),
			//                            v54) );
			//         }
			//         sub_1802F01E0(&v74, 0LL, 96LL);
			//         HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v74, (int)v27, (int)v26, 0LL);
			//         v71 = v74;
			//         if ( !Target )
			//           sub_1802DC2C8(v56, v55);
			//         v71.colorFormat = UnityEngine::RenderTexture::get_graphicsFormat(Target, 0LL);
			//         v71.enableRandomWrite = 0;
			//         v71.name = (String *)"UI Image Blur Temp";
			//         if ( dword_18D8E43F8 )
			//         {
			//           v57 = (((unsigned __int64)&v71.name >> 12) & 0x1FFFFF) >> 6;
			//           _m_prefetchw(&qword_18D6405E0[v57 + 36190]);
			//           do
			//             v58 = qword_18D6405E0[v57 + 36190];
			//           while ( v58 != _InterlockedCompareExchange64(
			//                            &qword_18D6405E0[v57 + 36190],
			//                            v58 | (1LL << (((unsigned __int64)&v71.name >> 12) & 0x3F)),
			//                            v58) );
			//         }
			//         *(_QWORD *)&v71.filterMode = 0x100000001LL;
			//         v75 = v71;
			//         v59 = (TextureHandle *)v69;
			//         v62 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(
			//                  (TextureHandle *)&v68,
			//                  &v70,
			//                  &v75,
			//                  0LL);
			//         if ( !v59 )
			//           sub_1802DC2C8(v61, v60);
			//         v59[5] = v62;
			//         if ( !v69 )
			//           sub_1802DC2C8(v61, v60);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//           (TextureHandle *)&v68,
			//           &v70,
			//           (TextureHandle *)(v69 + 80),
			//           0,
			//           0,
			//           0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::UIImageBlurPassConstructor);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//           &v70,
			//           (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::UIImageBlurPassConstructor.static_fields.s_UIImageBlurRenderFunc,
			//           0LL,
			//           0,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::UIImageBlurPassConstructor::UIImageBlurPassData>);
			//       }
			//       catch ( Il2CppExceptionWrapper *v73 )
			//       {
			//         v72[0] = v73.ex;
			//       }
			//       sub_180222690(v72);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::UIImageBlurManager);
			//       v64 = TypeInfo::HG::Rendering::Runtime::UIImageBlurManager.static_fields.instance;
			//       if ( !v64 )
			//         sub_1802DC2C8(0LL, v63);
			//       HG::Rendering::Runtime::UIImageBlurManager::CloseUIBlurPass(v64, 0LL);
			//     }
			//   }
			// }
			// 
		}

		private Material m_uiImageBlurMat;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly RenderFunc<UIImageBlurPassConstructor.UIImageBlurPassData> s_UIImageBlurRenderFunc;

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct PassInput
		{
			internal UIImageBlurManager uiImageBlurMgr;
		}

		internal struct PassOutput
		{
		}

		private class UIImageBlurPassData
		{
			public UIImageBlurPassData()
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

			public Vector4 param0;

			public Vector4 param1;

			public Vector4 paramAtlas;

			public RTHandle source;

			public RTHandle target;

			public TextureHandle tempRT;

			public Material blurMat;
		}
	}
}
