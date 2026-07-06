using System;
using HG.Rendering.RenderGraphModule;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	public class HGLowResDirectionalShadowPass
	{
		internal HGLowResDirectionalShadowPass(HGRenderPipelineMaterialCollector materialCollector, HGRenderPipelineRuntimeResources defaultResources)
		{
		}

		internal TextureHandle Render(HGRenderGraph renderGraph, HGCamera hgCamera, float renderingScale, TextureHandle depthRT)
		{
			// // TextureHandle Render(HGRenderGraph, HGCamera, Single, TextureHandle)
			// // Hidden C++ exception states: #wind=4
			// TextureHandle *HG::Rendering::Runtime::HGLowResDirectionalShadowPass::Render(
			//         TextureHandle *__return_ptr retstr,
			//         HGLowResDirectionalShadowPass *this,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *hgCamera,
			//         float renderingScale,
			//         TextureHandle *depthRT,
			//         MethodInfo *method)
			// {
			//   Object *v8; // r14
			//   HGLowResDirectionalShadowPass *v9; // r13
			//   TextureHandle *v10; // r12
			//   ProfilingSampler *v11; // rax
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   Object__Class *v14; // rbx
			//   __int64 v15; // rdx
			//   __int64 v16; // rcx
			//   TextureHandle v17; // xmm6
			//   TextureHandle v18; // xmm7
			//   ProfilingSampler *v19; // rax
			//   __int64 v20; // rcx
			//   Object *v21; // rdx
			//   unsigned int v22; // edx
			//   unsigned __int64 v23; // r8
			//   char v24; // dl
			//   signed __int64 v25; // rtt
			//   Object *v26; // r15
			//   __int64 v27; // rdx
			//   __int64 v28; // rcx
			//   TextureHandle v29; // xmm0
			//   __int64 v30; // rdx
			//   __int64 v31; // rcx
			//   ProfilingSampler *v32; // rax
			//   __int64 v33; // rdx
			//   __int64 v34; // rcx
			//   unsigned __int64 v35; // rdx
			//   Object *v36; // rax
			//   Object__Class *m_lowResShadowBlurMaterial; // rcx
			//   unsigned __int64 v38; // r8
			//   signed __int64 v39; // rtt
			//   __int64 v40; // rdx
			//   __int64 v41; // rcx
			//   __int64 v42; // rdx
			//   __int64 v43; // rcx
			//   ProfilingSampler *v44; // rax
			//   __int64 v45; // rdx
			//   __int64 v46; // rcx
			//   signed __int64 v47; // rcx
			//   Object *v48; // rdx
			//   unsigned int v49; // edx
			//   unsigned __int64 v50; // r8
			//   signed __int64 v51; // rtt
			//   __int64 v52; // rdx
			//   __int64 v53; // rcx
			//   __int64 v54; // rdx
			//   __int64 v55; // rcx
			//   TextureHandle v56; // xmm6
			//   __int64 v57; // rdx
			//   __int64 v58; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rsi
			//   Object *v61; // [rsp+50h] [rbp-2C8h] BYREF
			//   Object *v62; // [rsp+58h] [rbp-2C0h] BYREF
			//   Il2CppException *ex; // [rsp+60h] [rbp-2B8h] BYREF
			//   HGRenderGraphBuilder *v64; // [rsp+68h] [rbp-2B0h]
			//   Object *v65; // [rsp+70h] [rbp-2A8h] BYREF
			//   Vector2Int size; // [rsp+78h] [rbp-2A0h]
			//   HGRenderGraphBuilder v67; // [rsp+80h] [rbp-298h] BYREF
			//   Color v68; // [rsp+A0h] [rbp-278h] BYREF
			//   TextureHandle v69; // [rsp+B0h] [rbp-268h] BYREF
			//   TextureHandle v70; // [rsp+C0h] [rbp-258h] BYREF
			//   _QWORD v71[2]; // [rsp+D0h] [rbp-248h] BYREF
			//   TextureHandle v72; // [rsp+E0h] [rbp-238h] BYREF
			//   HGRenderGraphBuilder v73; // [rsp+F0h] [rbp-228h] BYREF
			//   HGRenderGraphBuilder v74; // [rsp+110h] [rbp-208h] BYREF
			//   HGRenderGraphBuilder v75; // [rsp+130h] [rbp-1E8h] BYREF
			//   TextureHandle v76; // [rsp+150h] [rbp-1C8h] BYREF
			//   HGRenderGraphProfilingScope v77; // [rsp+160h] [rbp-1B8h] BYREF
			//   Il2CppExceptionWrapper *v78; // [rsp+178h] [rbp-1A0h] BYREF
			//   Il2CppExceptionWrapper *v79; // [rsp+180h] [rbp-198h] BYREF
			//   Il2CppExceptionWrapper *v80; // [rsp+188h] [rbp-190h] BYREF
			//   Il2CppExceptionWrapper *v81; // [rsp+190h] [rbp-188h] BYREF
			//   TextureDesc v82; // [rsp+1A0h] [rbp-178h] BYREF
			//   TextureDesc v83; // [rsp+200h] [rbp-118h] BYREF
			//   __int128 v84; // [rsp+270h] [rbp-A8h]
			//   __int128 v85; // [rsp+280h] [rbp-98h]
			// 
			//   v8 = (Object *)renderGraph;
			//   v9 = this;
			//   v10 = retstr;
			//   if ( !byte_18D919E8A )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGLowResDirectionalShadowPass);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGLowResDirectionalShadowPass::HGLowResDirectionalShadowPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGLowResDirectionalShadowPass::HGLowResShadowBlurPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::HGLowResDirectionalShadowPass::HGLowResDirectionalShadowPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::HGLowResDirectionalShadowPass::HGLowResShadowBlurPassData>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&off_18D5F3268);
			//     sub_18003C530(&off_18D5F32A0);
			//     sub_18003C530(&off_18D5F3298);
			//     byte_18D919E8A = 1;
			//   }
			//   memset(&v77, 0, sizeof(v77));
			//   sub_1802F01E0(&v82, 0LL, 96LL);
			//   memset(&v73, 0, sizeof(v73));
			//   v65 = 0LL;
			//   memset(&v74, 0, sizeof(v74));
			//   v61 = 0LL;
			//   memset(&v75, 0, sizeof(v75));
			//   v62 = 0LL;
			//   v72 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1839, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1839, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v58, v57);
			//     v72 = *depthRT;
			//     *v10 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_708(
			//               (TextureHandle *)&v67,
			//               Patch,
			//               (Object *)v9,
			//               v8,
			//               (Object *)hgCamera,
			//               renderingScale,
			//               &v72,
			//               0LL);
			//   }
			//   else
			//   {
			//     v11 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//             (Int32Enum__Enum)0x80u,
			//             MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     HG::Rendering::RenderGraphModule::HGRenderGraphProfilingScope::HGRenderGraphProfilingScope(
			//       &v77,
			//       (HGRenderGraph *)v8,
			//       v11,
			//       0LL);
			//     v71[0] = 0LL;
			//     v71[1] = &v77;
			//     try
			//     {
			//       if ( !hgCamera )
			//         sub_1802DC2C8(v13, v12);
			//       size.m_X = sub_1826E82D0();
			//       size.m_Y = sub_1826E82D0();
			//       sub_1802F01E0(&v83, 0LL, 96LL);
			//       v14 = (Object__Class *)size;
			//       HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v83, size, 0LL);
			//       HIDWORD(v84) = v83.dimension;
			//       v85 = *(_OWORD *)&v83.enableRandomWrite;
			//       LODWORD(v84) = 5;
			//       BYTE1(v85) = 0;
			//       *(_QWORD *)((char *)&v84 + 4) = 0x100000001LL;
			//       *(_OWORD *)&v82.width = *(_OWORD *)&v83.width;
			//       *(_OWORD *)&v82.colorFormat = v84;
			//       *(_OWORD *)&v82.enableRandomWrite = v85;
			//       *(_OWORD *)&v82.bindTextureMS = *(_OWORD *)&v83.bindTextureMS;
			//       *(_OWORD *)&v82.fastMemoryDesc.inFastMemory = *(_OWORD *)&v83.fastMemoryDesc.inFastMemory;
			//       v82.clearColor = v83.clearColor;
			//       if ( !v8 )
			//         sub_1802DC2C8(v16, v15);
			//       v17 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(&v70, (HGRenderGraph *)v8, &v82, 0LL);
			//       v69 = v17;
			//       v18 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(&v70, (HGRenderGraph *)v8, &v82, 0LL);
			//       v76 = v18;
			//       v70 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(&v70, (HGRenderGraph *)v8, &v82, 0LL);
			//       v19 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//               (Int32Enum__Enum)0x81u,
			//               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//       HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//         &v67,
			//         (HGRenderGraph *)v8,
			//         (String *)"Low Res Directional Shadow",
			//         &v65,
			//         v19,
			//         1,
			//         ProfilingHGPass__Enum_None,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::HGLowResDirectionalShadowPass::HGLowResDirectionalShadowPassData>);
			//       v73 = v67;
			//       ex = 0LL;
			//       v64 = &v73;
			//       try
			//       {
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v73, 0, 0LL);
			//         v21 = v65;
			//         if ( !v65 )
			//           sub_1802DC2C8(v20, 0LL);
			//         v65[1].monitor = (MonitorData *)v9.fields.m_lowResDirectionalShadowMaterial;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v22 = ((unsigned __int64)&v21[1].monitor >> 12) & 0x1FFFFF;
			//           v23 = (unsigned __int64)v22 >> 6;
			//           v24 = v22 & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v23 + 36190]);
			//           do
			//             v25 = qword_18D6405E0[v23 + 36190];
			//           while ( v25 != _InterlockedCompareExchange64(&qword_18D6405E0[v23 + 36190], v25 | (1LL << v24), v25) );
			//         }
			//         v26 = v65;
			//         v29 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                  (TextureHandle *)&v68,
			//                  &v73,
			//                  depthRT,
			//                  0LL);
			//         if ( !v26 )
			//           sub_1802DC2C8(v28, v27);
			//         v26[2] = (Object)v29;
			//         if ( !v65 )
			//           sub_1802DC2C8(v28, v27);
			//         v65[3] = (Object)v17;
			//         if ( !v65 )
			//           sub_1802DC2C8(v28, v27);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
			//           (TextureHandle *)&v68,
			//           &v73,
			//           (TextureHandle *)&v65[3],
			//           0LL);
			//         if ( !v65 )
			//           sub_1802DC2C8(v31, v30);
			//         v68 = 0LL;
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//           (TextureHandle *)&v67,
			//           &v73,
			//           (TextureHandle *)&v65[3],
			//           0,
			//           RenderBufferLoadAction__Enum_DontCare,
			//           RenderBufferStoreAction__Enum_DontCare,
			//           &v68,
			//           0,
			//           0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGLowResDirectionalShadowPass);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//           &v73,
			//           (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGLowResDirectionalShadowPass.static_fields.s_lowResDirectionalShadowPassRenderFunc,
			//           0LL,
			//           0,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGLowResDirectionalShadowPass::HGLowResDirectionalShadowPassData>);
			//       }
			//       catch ( Il2CppExceptionWrapper *v78 )
			//       {
			//         ex = v78.ex;
			//         sub_180222690(&ex);
			//         v8 = (Object *)renderGraph;
			//         v9 = this;
			//         v10 = retstr;
			//         v17 = v69;
			//         v18 = v76;
			//         v14 = (Object__Class *)size;
			//         goto LABEL_18;
			//       }
			//       sub_180222690(&ex);
			// LABEL_18:
			//       v32 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//               (Int32Enum__Enum)0x82u,
			//               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//       HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//         &v67,
			//         (HGRenderGraph *)v8,
			//         (String *)"Low Res Directional Shadow Blur Horizontal",
			//         &v61,
			//         v32,
			//         1,
			//         ProfilingHGPass__Enum_None,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::HGLowResDirectionalShadowPass::HGLowResShadowBlurPassData>);
			//       v74 = v67;
			//       ex = 0LL;
			//       v64 = &v74;
			//       try
			//       {
			//         if ( !v61 )
			//           sub_1802DC2C8(v34, v33);
			//         LOBYTE(v61[1].klass) = 1;
			//         if ( !v61 )
			//           sub_1802DC2C8(v34, v33);
			//         *(Object__Class **)((char *)&v61[1].klass + 4) = v14;
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v74, 0, 0LL);
			//         v36 = v61;
			//         m_lowResShadowBlurMaterial = (Object__Class *)v9.fields.m_lowResShadowBlurMaterial;
			//         if ( !v61 )
			//           sub_1802DC2C8(m_lowResShadowBlurMaterial, v35);
			//         v61[2].klass = m_lowResShadowBlurMaterial;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v38 = (((unsigned __int64)&v36[2] >> 12) & 0x1FFFFF) >> 6;
			//           v35 = ((unsigned __int64)&v36[2] >> 12) & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v38 + 36190]);
			//           do
			//           {
			//             m_lowResShadowBlurMaterial = (Object__Class *)(qword_18D6405E0[v38 + 36190] | (1LL << v35));
			//             v39 = qword_18D6405E0[v38 + 36190];
			//           }
			//           while ( v39 != _InterlockedCompareExchange64(
			//                            &qword_18D6405E0[v38 + 36190],
			//                            (signed __int64)m_lowResShadowBlurMaterial,
			//                            v39) );
			//         }
			//         if ( !v61 )
			//           sub_1802DC2C8(m_lowResShadowBlurMaterial, v35);
			//         *(TextureHandle *)&v61[2].monitor = v17;
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture((TextureHandle *)&v67, &v74, &v69, 0LL);
			//         if ( !v61 )
			//           sub_1802DC2C8(v41, v40);
			//         *(TextureHandle *)&v61[3].monitor = v18;
			//         if ( !v61 )
			//           sub_1802DC2C8(v41, v40);
			//         v69 = 0LL;
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//           (TextureHandle *)&v67,
			//           &v74,
			//           (TextureHandle *)&v61[3].monitor,
			//           0,
			//           RenderBufferLoadAction__Enum_DontCare,
			//           RenderBufferStoreAction__Enum_DontCare,
			//           (Color *)&v69,
			//           0,
			//           0LL);
			//         if ( !v61 )
			//           sub_1802DC2C8(v43, v42);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
			//           (TextureHandle *)&v67,
			//           &v74,
			//           (TextureHandle *)&v61[3].monitor,
			//           0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGLowResDirectionalShadowPass);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//           &v74,
			//           (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGLowResDirectionalShadowPass.static_fields.s_lowResShadowBlurPassRenderFunc,
			//           0LL,
			//           0,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGLowResDirectionalShadowPass::HGLowResShadowBlurPassData>);
			//       }
			//       catch ( Il2CppExceptionWrapper *v79 )
			//       {
			//         ex = v79.ex;
			//         sub_180222690(&ex);
			//         v8 = (Object *)renderGraph;
			//         v9 = this;
			//         v10 = retstr;
			//         v18 = v76;
			//         v14 = (Object__Class *)size;
			//         goto LABEL_31;
			//       }
			//       sub_180222690(&ex);
			// LABEL_31:
			//       v44 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//               (Int32Enum__Enum)0x83u,
			//               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//       HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//         &v67,
			//         (HGRenderGraph *)v8,
			//         (String *)"Low Res Directional Shadow Blur Vertical",
			//         &v62,
			//         v44,
			//         1,
			//         ProfilingHGPass__Enum_None,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::HGLowResDirectionalShadowPass::HGLowResShadowBlurPassData>);
			//       v75 = v67;
			//       ex = 0LL;
			//       v64 = &v75;
			//       try
			//       {
			//         if ( !v62 )
			//           sub_1802DC2C8(v46, v45);
			//         LOBYTE(v62[1].klass) = 0;
			//         if ( !v62 )
			//           sub_1802DC2C8(v46, v45);
			//         *(Object__Class **)((char *)&v62[1].klass + 4) = v14;
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v75, 0, 0LL);
			//         v48 = v62;
			//         if ( !v62 )
			//           sub_1802DC2C8(v47, 0LL);
			//         v62[2].klass = (Object__Class *)v9.fields.m_lowResShadowBlurMaterial;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v49 = ((unsigned __int64)&v48[2] >> 12) & 0x1FFFFF;
			//           v50 = (unsigned __int64)v49 >> 6;
			//           v48 = (Object *)(v49 & 0x3F);
			//           _m_prefetchw(&qword_18D6405E0[v50 + 36190]);
			//           do
			//           {
			//             v47 = qword_18D6405E0[v50 + 36190] | (1LL << (char)v48);
			//             v51 = qword_18D6405E0[v50 + 36190];
			//           }
			//           while ( v51 != _InterlockedCompareExchange64(&qword_18D6405E0[v50 + 36190], v47, v51) );
			//         }
			//         if ( !v62 )
			//           sub_1802DC2C8(v47, v48);
			//         *(TextureHandle *)&v62[2].monitor = v18;
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture((TextureHandle *)&v67, &v75, &v76, 0LL);
			//         if ( !v62 )
			//           sub_1802DC2C8(v53, v52);
			//         *(TextureHandle *)&v62[3].monitor = v70;
			//         if ( !v62 )
			//           sub_1802DC2C8(v53, v52);
			//         v69 = 0LL;
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//           (TextureHandle *)&v67,
			//           &v75,
			//           (TextureHandle *)&v62[3].monitor,
			//           0,
			//           RenderBufferLoadAction__Enum_DontCare,
			//           RenderBufferStoreAction__Enum_DontCare,
			//           (Color *)&v69,
			//           0,
			//           0LL);
			//         if ( !v62 )
			//           sub_1802DC2C8(v55, v54);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
			//           (TextureHandle *)&v67,
			//           &v75,
			//           (TextureHandle *)&v62[3].monitor,
			//           0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGLowResDirectionalShadowPass);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//           &v75,
			//           (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGLowResDirectionalShadowPass.static_fields.s_lowResShadowBlurPassRenderFunc,
			//           0LL,
			//           0,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGLowResDirectionalShadowPass::HGLowResShadowBlurPassData>);
			//       }
			//       catch ( Il2CppExceptionWrapper *v80 )
			//       {
			//         ex = v80.ex;
			//         sub_180222690(&ex);
			//         v10 = retstr;
			//         goto LABEL_44;
			//       }
			//       sub_180222690(&ex);
			// LABEL_44:
			//       v56 = v70;
			//       v72 = v70;
			//     }
			//     catch ( Il2CppExceptionWrapper *v81 )
			//     {
			//       v71[0] = v81.ex;
			//       sub_180224750(v71);
			//       v10 = retstr;
			//       v56 = v72;
			//       goto LABEL_46;
			//     }
			//     sub_180224750(v71);
			// LABEL_46:
			//     *v10 = v56;
			//   }
			//   return v10;
			// }
			// 
			return null;
		}

		internal const int LOW_RES_SHADOW_DOWNSAMPLE_SCALE = 4;

		internal const float LOW_RES_SHADOW_INV_DOWNSAMPLE_SCALE = 0.25f;

		private Material m_lowResDirectionalShadowMaterial;

		private Material m_lowResShadowBlurMaterial;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly RenderFunc<HGLowResDirectionalShadowPass.HGLowResDirectionalShadowPassData> s_lowResDirectionalShadowPassRenderFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		private static readonly RenderFunc<HGLowResDirectionalShadowPass.HGLowResShadowBlurPassData> s_lowResShadowBlurPassRenderFunc;

		internal class HGLowResDirectionalShadowPassData
		{
			public HGLowResDirectionalShadowPassData()
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

			public float downSampleScale;

			public Material lowResDirectionalShadowMat;

			public TextureHandle depthBuffer;

			public TextureHandle lowResShadowTexture;
		}

		internal class HGLowResShadowBlurPassData
		{
			public HGLowResShadowBlurPassData()
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

			public bool horizontalPass;

			public Vector2Int rtResolution;

			public Material lowResShadowBlurMat;

			public TextureHandle lowResShadowTexture;

			public TextureHandle lowResBlurredShadow;
		}
	}
}
