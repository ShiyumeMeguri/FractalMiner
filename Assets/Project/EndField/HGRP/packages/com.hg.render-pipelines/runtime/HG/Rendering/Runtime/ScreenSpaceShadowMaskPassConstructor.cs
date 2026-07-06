using System;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;

namespace HG.Rendering.Runtime
{
	internal class ScreenSpaceShadowMaskPassConstructor : IPassConstructor
	{
		internal ScreenSpaceShadowMaskPassConstructor(HGRenderPipelineMaterialCollector materialCollector, HGRenderPathBase.HGRenderPathResources resources)
		{
		}

		internal static bool IsScreenSpaceShadowMaskEnabled(bool screenSpaceShadowMaskEnabled)
		{
			// // Boolean IsScreenSpaceShadowMaskEnabled(Boolean)
			// bool HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor::IsScreenSpaceShadowMaskEnabled(
			//         bool screenSpaceShadowMaskEnabled,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   __int64 (*v5)(void); // rax
			//   unsigned int v6; // edi
			//   unsigned __int8 (__fastcall *v7)(_QWORD, __int64); // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // rax
			//   __int64 v11; // rax
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_16;
			//   if ( wrapperArray.max_length.size > 546 )
			//   {
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, wrapperArray);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//     if ( v3 )
			//     {
			//       if ( LODWORD(v3._0.namespaze) <= 0x222 )
			//         sub_180070270(v3, wrapperArray);
			//       if ( !*(_QWORD *)&v3[11]._1.static_fields_size )
			//         goto LABEL_7;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(546, 0LL);
			//       if ( Patch )
			//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_215(Patch, screenSpaceShadowMaskEnabled, 0LL);
			//     }
			// LABEL_16:
			//     sub_180B536AC(v3, wrapperArray);
			//   }
			// LABEL_7:
			//   if ( !byte_18D8F5550 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Graphics);
			//     byte_18D8F5550 = 1;
			//   }
			//   if ( !TypeInfo::UnityEngine::Graphics._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Graphics, wrapperArray);
			//   v5 = (__int64 (*)(void))qword_18D8F4460;
			//   if ( !qword_18D8F4460 )
			//   {
			//     v5 = (__int64 (*)(void))il2cpp_resolve_icall_0("UnityEngine.Graphics::get_activeTier()");
			//     if ( !v5 )
			//     {
			//       v10 = sub_1802DBBE8("UnityEngine.Graphics::get_activeTier()");
			//       sub_18000F750(v10, 0LL);
			//     }
			//     qword_18D8F4460 = (__int64)v5;
			//   }
			//   v6 = v5();
			//   v7 = (unsigned __int8 (__fastcall *)(_QWORD, __int64))qword_18D8F5548;
			//   if ( !qword_18D8F5548 )
			//   {
			//     v7 = (unsigned __int8 (__fastcall *)(_QWORD, __int64))il2cpp_resolve_icall_0(
			//                                                             "UnityEngine.Rendering.GraphicsSettings::HasShaderDefine(Unit"
			//                                                             "yEngine.Rendering.GraphicsTier,UnityEngine.Rendering.BuiltinShaderDefine)");
			//     if ( !v7 )
			//     {
			//       v11 = sub_1802DBBE8(
			//               "UnityEngine.Rendering.GraphicsSettings::HasShaderDefine(UnityEngine.Rendering.GraphicsTier,UnityEngine.Ren"
			//               "dering.BuiltinShaderDefine)");
			//       sub_18000F750(v11, 0LL);
			//     }
			//     qword_18D8F5548 = (__int64)v7;
			//   }
			//   if ( v7(v6, 33LL) )
			//     return 0;
			//   return screenSpaceShadowMaskEnabled;
			// }
			// 
			return default(bool);
		}

		private void RenderScreenSpaceShadowResolve(HGRenderGraph renderGraph, HGCamera hgCamera, float renderingScale, TextureHandle depthRT, TextureHandle depthRTCopied, TextureHandle gbuffer0, TextureHandle gbuffer1, TextureHandle lowResShadowTexture)
		{
			// // Void RenderScreenSpaceShadowResolve(HGRenderGraph, HGCamera, Single, TextureHandle, TextureHandle, TextureHandle, TextureHandle, TextureHandle)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor::RenderScreenSpaceShadowResolve(
			//         ScreenSpaceShadowMaskPassConstructor *this,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *hgCamera,
			//         float renderingScale,
			//         TextureHandle *depthRT,
			//         TextureHandle *depthRTCopied,
			//         TextureHandle *gbuffer0,
			//         TextureHandle *gbuffer1,
			//         TextureHandle *lowResShadowTexture,
			//         MethodInfo *method)
			// {
			//   ProfilingSampler *v13; // rax
			//   __int64 v14; // rdx
			//   __int64 v15; // rcx
			//   __int64 v16; // rcx
			//   Object *v17; // rdx
			//   unsigned int v18; // edx
			//   unsigned __int64 v19; // r8
			//   char v20; // dl
			//   signed __int64 v21; // rtt
			//   Object *v22; // rbx
			//   __int64 v23; // rdx
			//   __int64 v24; // rcx
			//   TextureHandle v25; // xmm0
			//   Object *v26; // rbx
			//   __int64 v27; // rdx
			//   __int64 v28; // rcx
			//   TextureHandle v29; // xmm0
			//   Object *v30; // rbx
			//   __int64 v31; // rdx
			//   __int64 v32; // rcx
			//   TextureHandle v33; // xmm0
			//   Object *v34; // rbx
			//   __int64 v35; // rdx
			//   __int64 v36; // rcx
			//   TextureHandle v37; // xmm0
			//   Object *v38; // rbx
			//   __int64 v39; // rdx
			//   __int64 v40; // rcx
			//   TextureHandle v41; // xmm0
			//   __int64 v42; // rdx
			//   __int64 v43; // rcx
			//   TextureHandle v44; // xmm0
			//   __int64 v45; // rdx
			//   __int64 v46; // rcx
			//   __int64 v47; // rdx
			//   __int64 v48; // rcx
			//   __int64 v49; // rdx
			//   __int64 v50; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rbx
			//   Object *v52; // [rsp+60h] [rbp-1D8h] BYREF
			//   TextureHandle v53; // [rsp+70h] [rbp-1C8h] BYREF
			//   HGRenderGraphBuilder v54; // [rsp+80h] [rbp-1B8h] BYREF
			//   HGRenderGraphBuilder v55; // [rsp+A0h] [rbp-198h] BYREF
			//   TextureHandle v56; // [rsp+C0h] [rbp-178h] BYREF
			//   Il2CppExceptionWrapper *v57; // [rsp+D0h] [rbp-168h] BYREF
			//   TextureHandle v58; // [rsp+E0h] [rbp-158h] BYREF
			//   TextureHandle v59; // [rsp+F0h] [rbp-148h] BYREF
			//   TextureDesc v60; // [rsp+100h] [rbp-138h] BYREF
			//   __int128 v61; // [rsp+170h] [rbp-C8h]
			//   __int128 v62; // [rsp+180h] [rbp-B8h]
			//   TextureDesc v63; // [rsp+1C0h] [rbp-78h] BYREF
			// 
			//   if ( !byte_18D919EA7 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor::HGScreenSpaceShadowResolvePassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor::HGScreenSpaceShadowResolvePassData>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor);
			//     sub_18003C530(&off_18D5F2DC8);
			//     byte_18D919EA7 = 1;
			//   }
			//   v52 = 0LL;
			//   sub_1802F01E0(&v63, 0LL, 96LL);
			//   if ( IFix::WrappersManagerImpl::IsPatched(1856, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1856, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v50, v49);
			//     v53 = *lowResShadowTexture;
			//     v56 = *gbuffer1;
			//     v58 = *gbuffer0;
			//     v59 = *depthRTCopied;
			//     *(TextureHandle *)&v54.m_RenderPass = *depthRT;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_722(
			//       Patch,
			//       (Object *)this,
			//       (Object *)renderGraph,
			//       (Object *)hgCamera,
			//       renderingScale,
			//       (TextureHandle *)&v54,
			//       &v59,
			//       &v58,
			//       &v56,
			//       &v53,
			//       0LL);
			//   }
			//   else
			//   {
			//     v13 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//             (Int32Enum__Enum)0x85u,
			//             MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     if ( !renderGraph )
			//       sub_180B536AC(v15, v14);
			//     HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//       &v54,
			//       renderGraph,
			//       (String *)"Screen Space Shadow Resolve",
			//       &v52,
			//       v13,
			//       1,
			//       ProfilingHGPass__Enum_None,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor::HGScreenSpaceShadowResolvePassData>);
			//     v55 = v54;
			//     v53.handle = 0LL;
			//     v53.fallBackResource = (ResourceHandle)&v55;
			//     try
			//     {
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v55, 0, 0LL);
			//       v17 = v52;
			//       if ( !v52 )
			//         sub_1802DC2C8(v16, 0LL);
			//       v52[1].klass = (Object__Class *)this.fields.m_screenSpaceShadowResolveMaterial;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v18 = ((unsigned __int64)&v17[1] >> 12) & 0x1FFFFF;
			//         v19 = (unsigned __int64)v18 >> 6;
			//         v20 = v18 & 0x3F;
			//         _m_prefetchw(&qword_18D6870D0[v19]);
			//         do
			//           v21 = qword_18D6870D0[v19];
			//         while ( v21 != _InterlockedCompareExchange64(&qword_18D6870D0[v19], v21 | (1LL << v20), v21) );
			//       }
			//       v22 = v52;
			//       v25 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                (TextureHandle *)&v54,
			//                &v55,
			//                depthRT,
			//                0LL);
			//       if ( !v22 )
			//         sub_1802DC2C8(v24, v23);
			//       *(TextureHandle *)&v22[1].monitor = v25;
			//       v26 = v52;
			//       v29 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                (TextureHandle *)&v54,
			//                &v55,
			//                depthRTCopied,
			//                0LL);
			//       if ( !v26 )
			//         sub_1802DC2C8(v28, v27);
			//       *(TextureHandle *)&v26[2].monitor = v29;
			//       v30 = v52;
			//       v33 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                (TextureHandle *)&v54,
			//                &v55,
			//                gbuffer0,
			//                0LL);
			//       if ( !v30 )
			//         sub_1802DC2C8(v32, v31);
			//       *(TextureHandle *)&v30[3].monitor = v33;
			//       v34 = v52;
			//       v37 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                (TextureHandle *)&v54,
			//                &v55,
			//                gbuffer1,
			//                0LL);
			//       if ( !v34 )
			//         sub_1802DC2C8(v36, v35);
			//       *(TextureHandle *)&v34[4].monitor = v37;
			//       v38 = v52;
			//       v41 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                (TextureHandle *)&v54,
			//                &v55,
			//                lowResShadowTexture,
			//                0LL);
			//       if ( !v38 )
			//         sub_1802DC2C8(v40, v39);
			//       *(TextureHandle *)&v38[5].monitor = v41;
			//       if ( !hgCamera )
			//         sub_1802DC2C8(v40, v39);
			//       sub_1802F01E0(&v60, 0LL, 96LL);
			//       HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
			//         &v60,
			//         hgCamera.fields._sceneRTSize_k__BackingField,
			//         0LL);
			//       HIDWORD(v61) = v60.dimension;
			//       v62 = *(_OWORD *)&v60.enableRandomWrite;
			//       LODWORD(v61) = 6;
			//       BYTE1(v62) = 0;
			//       *(_QWORD *)((char *)&v61 + 4) = 0x100000001LL;
			//       *(_OWORD *)&v63.width = *(_OWORD *)&v60.width;
			//       *(_OWORD *)&v63.colorFormat = v61;
			//       *(_OWORD *)&v63.enableRandomWrite = v62;
			//       *(_OWORD *)&v63.bindTextureMS = *(_OWORD *)&v60.bindTextureMS;
			//       *(_OWORD *)&v63.fastMemoryDesc.inFastMemory = *(_OWORD *)&v60.fastMemoryDesc.inFastMemory;
			//       v63.clearColor = v60.clearColor;
			//       v44 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                (TextureHandle *)&v54,
			//                renderGraph,
			//                &v63,
			//                0LL);
			//       if ( !v52 )
			//         sub_1802DC2C8(v43, v42);
			//       *(TextureHandle *)&v52[6].monitor = v44;
			//       if ( !v52 )
			//         sub_1802DC2C8(v43, v42);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
			//         (TextureHandle *)&v54,
			//         &v55,
			//         (TextureHandle *)&v52[6].monitor,
			//         0LL);
			//       if ( !v52 )
			//         sub_1802DC2C8(v46, v45);
			//       v56 = 0LL;
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//         (TextureHandle *)&v54,
			//         &v55,
			//         (TextureHandle *)&v52[6].monitor,
			//         0,
			//         RenderBufferLoadAction__Enum_DontCare,
			//         RenderBufferStoreAction__Enum_DontCare,
			//         (Color *)&v56,
			//         0,
			//         0LL);
			//       if ( !v52 )
			//         sub_1802DC2C8(v48, v47);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
			//         (TextureHandle *)&v54,
			//         &v55,
			//         (TextureHandle *)&v52[1].monitor,
			//         DepthAccess__Enum_Read,
			//         0,
			//         0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//         &v55,
			//         (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor.static_fields.s_screenSpaceShadowResolvePassRenderFunc,
			//         0LL,
			//         0,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor::HGScreenSpaceShadowResolvePassData>);
			//     }
			//     catch ( Il2CppExceptionWrapper *v57 )
			//     {
			//       v53.handle = (ResourceHandle)v57.ex;
			//     }
			//     sub_180222690(&v53);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         ScreenSpaceShadowMaskPassConstructor *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1857, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1857, 0LL);
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
			// void HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         ScreenSpaceShadowMaskPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1858, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1858, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		internal void ConstructPass(ref ScreenSpaceShadowMaskPassConstructor.PassInput input, ref ScreenSpaceShadowMaskPassConstructor.PassOutput output, HGRenderGraph renderGraph, HGCamera camera)
		{
			// // Void ConstructPass(ScreenSpaceShadowMaskPassConstructor+PassInput ByRef, ScreenSpaceShadowMaskPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor::ConstructPass(
			//         ScreenSpaceShadowMaskPassConstructor *this,
			//         ScreenSpaceShadowMaskPassConstructor_PassInput *input,
			//         ScreenSpaceShadowMaskPassConstructor_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   bool screenSpaceShadowMaskEnabled; // bl
			//   ProfilingSampler *v11; // rax
			//   __int64 v12; // rcx
			//   HGLowResDirectionalShadowPass *m_lowResDirectionalShadowPass; // rdx
			//   float renderingScale; // xmm1_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v16; // rdx
			//   __int64 v17; // rcx
			//   _QWORD v18[2]; // [rsp+50h] [rbp-88h] BYREF
			//   TextureHandle sceneDepth; // [rsp+60h] [rbp-78h] BYREF
			//   TextureHandle v20; // [rsp+70h] [rbp-68h] BYREF
			//   HGRenderGraphProfilingScope v21; // [rsp+80h] [rbp-58h] BYREF
			//   Il2CppExceptionWrapper *v22; // [rsp+98h] [rbp-40h] BYREF
			//   TextureHandle gbuffer1; // [rsp+A0h] [rbp-38h] BYREF
			//   TextureHandle gbuffer0; // [rsp+B0h] [rbp-28h] BYREF
			//   TextureHandle sceneDepthCopied; // [rsp+C0h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D919EA8 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor);
			//     byte_18D919EA8 = 1;
			//   }
			//   memset(&v21, 0, sizeof(v21));
			//   if ( IFix::WrappersManagerImpl::IsPatched(1859, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1859, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v17, v16);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_723(
			//       Patch,
			//       (Object *)this,
			//       input,
			//       output,
			//       (Object *)renderGraph,
			//       (Object *)camera,
			//       0LL);
			//   }
			//   else
			//   {
			//     screenSpaceShadowMaskEnabled = input.screenSpaceShadowMaskEnabled;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor);
			//     if ( HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor::IsScreenSpaceShadowMaskEnabled(
			//            screenSpaceShadowMaskEnabled,
			//            0LL) )
			//     {
			//       v11 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//               (Int32Enum__Enum)0x86u,
			//               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphProfilingScope::HGRenderGraphProfilingScope(
			//         &v21,
			//         renderGraph,
			//         v11,
			//         0LL);
			//       v18[0] = 0LL;
			//       v18[1] = &v21;
			//       try
			//       {
			//         m_lowResDirectionalShadowPass = this.fields.m_lowResDirectionalShadowPass;
			//         renderingScale = input.renderingScale;
			//         if ( !m_lowResDirectionalShadowPass )
			//           sub_1802DC2C8(v12, 0LL);
			//         sceneDepth = input.sceneDepth;
			//         sceneDepth = *HG::Rendering::Runtime::HGLowResDirectionalShadowPass::Render(
			//                         &v20,
			//                         m_lowResDirectionalShadowPass,
			//                         renderGraph,
			//                         camera,
			//                         renderingScale,
			//                         &sceneDepth,
			//                         0LL);
			//         gbuffer1 = input.gbuffer1;
			//         gbuffer0 = input.gbuffer0;
			//         sceneDepthCopied = input.sceneDepthCopied;
			//         v20 = input.sceneDepth;
			//         HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor::RenderScreenSpaceShadowResolve(
			//           this,
			//           renderGraph,
			//           camera,
			//           input.renderingScale,
			//           &v20,
			//           &sceneDepthCopied,
			//           &gbuffer0,
			//           &gbuffer1,
			//           &sceneDepth,
			//           0LL);
			//       }
			//       catch ( Il2CppExceptionWrapper *v22 )
			//       {
			//         v18[0] = v22.ex;
			//       }
			//       sub_180224750(v18);
			//     }
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         ScreenSpaceShadowMaskPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1860, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1860, 0LL);
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
			// void HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
			//         ScreenSpaceShadowMaskPassConstructor *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1861, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1861, 0LL);
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

		private Material m_screenSpaceShadowResolveMaterial;

		private HGLowResDirectionalShadowPass m_lowResDirectionalShadowPass;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly RenderFunc<ScreenSpaceShadowMaskPassConstructor.HGScreenSpaceShadowResolvePassData> s_screenSpaceShadowResolvePassRenderFunc;

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 72)]
		internal struct PassInput
		{
			internal TextureHandle sceneDepth;

			internal TextureHandle sceneDepthCopied;

			internal TextureHandle gbuffer0;

			internal TextureHandle gbuffer1;

			internal bool screenSpaceShadowMaskEnabled;

			internal float renderingScale;
		}

		internal struct PassOutput
		{
		}

		internal class HGScreenSpaceShadowResolvePassData
		{
			public HGScreenSpaceShadowResolvePassData()
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

			public Material screenSpaceShadowResolveMat;

			public TextureHandle depthBuffer;

			public TextureHandle depthTexture;

			public TextureHandle gbuffer0;

			public TextureHandle gbuffer1;

			public TextureHandle lowResShadowTexture;

			public TextureHandle screenSpaceShadowResolveTexture;
		}
	}
}
