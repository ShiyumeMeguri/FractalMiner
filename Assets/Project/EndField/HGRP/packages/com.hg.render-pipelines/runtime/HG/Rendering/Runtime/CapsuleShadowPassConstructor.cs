using System;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.HyperGryph;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	internal class CapsuleShadowPassConstructor : IPassConstructor
	{
		internal CapsuleShadowPassConstructor(HGRenderPipelineMaterialCollector materialCollector, HGRenderPathBase.HGRenderPathResources resources)
		{
		}

		private void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::CapsuleShadowPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         CapsuleShadowPassConstructor *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1773, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1773, 0LL);
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
			// void HG::Rendering::Runtime::CapsuleShadowPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         CapsuleShadowPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1774, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1774, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		internal void ConstructPass_VisibilitySH(ref CapsuleShadowPassConstructor.PassInput input, ref CapsuleShadowPassConstructor.PassOutput output, HGRenderGraph renderGraph, HGCamera camera)
		{
			// // Void ConstructPass_VisibilitySH(CapsuleShadowPassConstructor+PassInput ByRef, CapsuleShadowPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
			// // Hidden C++ exception states: #wind=2 #try_helpers=1
			// void HG::Rendering::Runtime::CapsuleShadowPassConstructor::ConstructPass_VisibilitySH(
			//         CapsuleShadowPassConstructor *this,
			//         CapsuleShadowPassConstructor_PassInput *input,
			//         CapsuleShadowPassConstructor_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   HGRenderGraph *v6; // r14
			//   CapsuleShadowPassConstructor_PassInput *v8; // rsi
			//   CapsuleShadowPassConstructor *v9; // r15
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   Vector2Int sceneRTSize_k__BackingField; // rcx
			//   int32_t m_X; // r12d
			//   unsigned __int64 v14; // rcx
			//   int32_t v15; // edi
			//   __int64 v16; // rdx
			//   __int64 v17; // rcx
			//   __int128 v18; // xmm2
			//   __int128 v19; // xmm3
			//   Color clearColor; // xmm4
			//   unsigned __int64 v21; // r8
			//   signed __int64 v22; // rtt
			//   Object *v23; // r13
			//   __int64 v24; // rdx
			//   __int64 v25; // rcx
			//   TextureHandle v26; // xmm0
			//   Object *v27; // rdx
			//   unsigned __int64 v28; // rdx
			//   unsigned __int64 v29; // r8
			//   char v30; // dl
			//   signed __int64 v31; // rtt
			//   ProfilingSampler *v32; // rax
			//   __int64 v33; // rdx
			//   __int64 v34; // rcx
			//   __int64 v35; // rcx
			//   Object *v36; // rdx
			//   unsigned __int64 v37; // rdx
			//   unsigned __int64 v38; // r8
			//   char v39; // dl
			//   signed __int64 v40; // rtt
			//   Object *v41; // r13
			//   __int64 v42; // rdx
			//   __int64 v43; // rcx
			//   TextureHandle v44; // xmm0
			//   Object *v45; // r13
			//   __int64 v46; // rdx
			//   __int64 v47; // rcx
			//   TextureHandle v48; // xmm0
			//   Object *v49; // rdx
			//   int v50; // eax
			//   unsigned __int64 v51; // rdx
			//   unsigned __int64 v52; // r8
			//   char v53; // dl
			//   signed __int64 v54; // rtt
			//   Object *v55; // rdx
			//   Object__Class *m_visibilityABLut; // rcx
			//   unsigned __int64 v57; // rdx
			//   unsigned __int64 v58; // r8
			//   char v59; // dl
			//   signed __int64 v60; // rtt
			//   Object *v61; // rdx
			//   MonitorData *m_visibilitySHLut; // rcx
			//   unsigned __int64 v63; // rdx
			//   unsigned __int64 v64; // r8
			//   char v65; // dl
			//   signed __int64 v66; // rtt
			//   __int64 v67; // rdx
			//   signed int RenderCapsuleNum; // r15d
			//   struct MethodInfo *v69; // rcx
			//   float v70; // xmm1_4
			//   uint32_t v71; // r15d
			//   HGRenderGraphContext *m_RenderGraphContext; // rax
			//   ScriptableRenderContext *p_renderContext; // r13
			//   CBHandle *v74; // rax
			//   __int128 v75; // xmm7
			//   Void *ptr; // xmm6_8
			//   signed int RenderCapsuleData; // r15d
			//   __int64 v78; // rdx
			//   __int64 v79; // rcx
			//   Object *v80; // rax
			//   float sphereIntervalScale; // xmm0_4
			//   int v82; // xmm8_4
			//   float sphereRangeScale; // xmm0_4
			//   int v84; // xmm7_4
			//   __int64 v85; // rdx
			//   __int64 v86; // rcx
			//   int32_t v87; // r12d
			//   int32_t v88; // r13d
			//   ScriptableRenderContext *v89; // rdi
			//   CBHandle *ConstantBuffer; // rax
			//   Object v91; // xmm7
			//   HGRenderGraph *v92; // xmm6_8
			//   __int64 v93; // rdx
			//   __int64 v94; // rcx
			//   Object *v95; // rax
			//   Object *v96; // rdi
			//   __int64 v97; // rdx
			//   __int64 v98; // rcx
			//   TextureHandle v99; // xmm0
			//   Object *v100; // rsi
			//   HGRenderGraphContext *v101; // rax
			//   ScriptableRenderContext *v102; // r14
			//   CBHandle *v103; // rax
			//   __int64 v104; // rdx
			//   __int64 v105; // rcx
			//   Object__Class *v106; // xmm1_8
			//   Object *v107; // rsi
			//   Object *v108; // rsi
			//   Texture2D *blackTexture; // rax
			//   __int64 v110; // rdx
			//   __int64 v111; // rcx
			//   unsigned __int64 v112; // r8
			//   signed __int64 v113; // rtt
			//   Object *v114; // rsi
			//   HGRenderGraphContext *v115; // rax
			//   ScriptableRenderContext *v116; // r14
			//   CBHandle *v117; // rax
			//   __int64 v118; // rdx
			//   __int64 v119; // rcx
			//   Object__Class *v120; // xmm1_8
			//   Object *v121; // rsi
			//   Object *v122; // rsi
			//   Texture2D *v123; // rax
			//   __int64 v124; // rdx
			//   __int64 v125; // rcx
			//   unsigned __int64 v126; // r8
			//   signed __int64 v127; // rtt
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v129; // rdx
			//   __int64 v130; // rcx
			//   Object *v131; // [rsp+50h] [rbp-3F8h] BYREF
			//   int32_t width; // [rsp+58h] [rbp-3F0h]
			//   int32_t height; // [rsp+5Ch] [rbp-3ECh]
			//   Il2CppException *ex; // [rsp+60h] [rbp-3E8h] BYREF
			//   HGRenderGraphBuilder *v135; // [rsp+68h] [rbp-3E0h]
			//   CBHandle v136; // [rsp+70h] [rbp-3D8h] BYREF
			//   HGRenderGraphBuilder v137; // [rsp+90h] [rbp-3B8h] BYREF
			//   int32_t v138; // [rsp+B0h] [rbp-398h]
			//   int32_t v139; // [rsp+B4h] [rbp-394h]
			//   Object *v140; // [rsp+B8h] [rbp-390h] BYREF
			//   TextureHandle v141; // [rsp+C0h] [rbp-388h] BYREF
			//   Void *destination; // [rsp+D0h] [rbp-378h]
			//   HGRenderGraphBuilder v143; // [rsp+D8h] [rbp-370h] BYREF
			//   Void source[16]; // [rsp+F8h] [rbp-350h] BYREF
			//   TextureDesc v145; // [rsp+110h] [rbp-338h] BYREF
			//   TextureHandle v146; // [rsp+170h] [rbp-2D8h] BYREF
			//   HGRenderGraphBuilder v147; // [rsp+180h] [rbp-2C8h] BYREF
			//   TextureDesc v148; // [rsp+1A0h] [rbp-2A8h] BYREF
			//   Il2CppExceptionWrapper *v149; // [rsp+200h] [rbp-248h] BYREF
			//   _BYTE v150[48]; // [rsp+210h] [rbp-238h] BYREF
			//   __int128 v151; // [rsp+240h] [rbp-208h]
			//   __int128 v152; // [rsp+250h] [rbp-1F8h]
			//   __int128 v153; // [rsp+260h] [rbp-1E8h]
			//   __int128 v154; // [rsp+270h] [rbp-1D8h]
			//   __int128 v155; // [rsp+280h] [rbp-1C8h]
			//   TextureDesc v156; // [rsp+290h] [rbp-1B8h] BYREF
			//   TextureDesc v157; // [rsp+2F0h] [rbp-158h] BYREF
			//   Void v158[16]; // [rsp+350h] [rbp-F8h] BYREF
			//   __m128i si128; // [rsp+360h] [rbp-E8h]
			//   __m128i v160; // [rsp+370h] [rbp-D8h]
			//   __int128 v161; // [rsp+380h] [rbp-C8h]
			//   __int128 v162; // [rsp+390h] [rbp-B8h]
			//   __int128 v163; // [rsp+3A0h] [rbp-A8h]
			//   __int128 v164; // [rsp+3B0h] [rbp-98h]
			//   __int128 v165; // [rsp+3C0h] [rbp-88h]
			// 
			//   v6 = renderGraph;
			//   v8 = input;
			//   v9 = this;
			//   if ( !byte_18D919E70 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CapsuleShadowPassConstructor);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::CapsuleShadowPassConstructor::CapsuleShadowPassDataV2>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::CapsuleShadowPassConstructor::DownSampleDepthPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::CapsuleShadowPassConstructor::CapsuleShadowPassDataV2>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::CapsuleShadowPassConstructor::DownSampleDepthPassData>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::HyperGryph::CapsuleData>);
			//     sub_18003C530(&MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>);
			//     sub_18003C530(&MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<HG::Rendering::Runtime::CapsuleShadowPassConstructor::VisibilitySHConstData>);
			//     sub_18003C530(&off_18D5EF7D8);
			//     sub_18003C530(&off_18D5EF7D0);
			//     sub_18003C530(&off_18D5EF7C0);
			//     byte_18D919E70 = 1;
			//   }
			//   memset(&v147, 0, sizeof(v147));
			//   v140 = 0LL;
			//   sub_1802F01E0(&v156, 0LL, 96LL);
			//   sub_1802F01E0(&v145, 0LL, 96LL);
			//   memset(&v143, 0, sizeof(v143));
			//   v131 = 0LL;
			//   sub_1802F01E0(v158, 0LL, 128LL);
			//   sub_1802F01E0(&v157, 0LL, 96LL);
			//   *(_OWORD *)source = 0LL;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1775, 0LL) )
			//   {
			//     if ( !camera )
			//       sub_180B536AC(v11, v10);
			//     sceneRTSize_k__BackingField = camera.fields._sceneRTSize_k__BackingField;
			//     m_X = sceneRTSize_k__BackingField.m_X / 2;
			//     if ( !v8.enableHalfRez )
			//       m_X = sceneRTSize_k__BackingField.m_X;
			//     width = m_X;
			//     v138 = m_X;
			//     v14 = HIDWORD(*(unsigned __int64 *)&sceneRTSize_k__BackingField);
			//     v15 = (int)v14 / 2;
			//     if ( !v8.enableHalfRez )
			//       v15 = v14;
			//     height = v15;
			//     v139 = v15;
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     v146 = *(TextureHandle *)sub_182E7CCD0(&v141);
			//     if ( v8.enableHalfRez )
			//     {
			//       if ( !v6 )
			//         sub_180B536AC(v17, v16);
			//       HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//         &v137,
			//         v6,
			//         (String *)"DownSampleDepth",
			//         &v140,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::CapsuleShadowPassConstructor::DownSampleDepthPassData>);
			//       v147 = v137;
			//       ex = 0LL;
			//       v135 = &v147;
			//       try
			//       {
			//         sub_1802F01E0(&v148, 0LL, 96LL);
			//         HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v148, m_X, v15, 0LL);
			//         v145 = v148;
			//         v18 = *(_OWORD *)&v148.enableRandomWrite;
			//         v19 = *(_OWORD *)&v148.fastMemoryDesc.inFastMemory;
			//         clearColor = v148.clearColor;
			//         v145.colorFormat = v8.depthFormat;
			//         v145.depthBufferBits = v8.depthBufferBits;
			//         v145.name = (String *)"LowRez Depth";
			//         if ( dword_18D8E43F8 )
			//         {
			//           v21 = (((unsigned __int64)&v145.name >> 12) & 0x1FFFFF) >> 6;
			//           _m_prefetchw(&qword_18D6405E0[v21 + 36190]);
			//           do
			//             v22 = qword_18D6405E0[v21 + 36190];
			//           while ( v22 != _InterlockedCompareExchange64(
			//                            &qword_18D6405E0[v21 + 36190],
			//                            v22 | (1LL << (((unsigned __int64)&v145.name >> 12) & 0x3F)),
			//                            v22) );
			//           clearColor = v145.clearColor;
			//           v19 = *(_OWORD *)&v145.fastMemoryDesc.inFastMemory;
			//           v18 = *(_OWORD *)&v145.enableRandomWrite;
			//         }
			//         *(_OWORD *)&v156.width = *(_OWORD *)&v145.width;
			//         *(_OWORD *)&v156.colorFormat = *(_OWORD *)&v145.colorFormat;
			//         *(_OWORD *)&v156.enableRandomWrite = v18;
			//         *(_OWORD *)&v156.bindTextureMS = *(_OWORD *)&v145.bindTextureMS;
			//         *(_OWORD *)&v156.fastMemoryDesc.inFastMemory = v19;
			//         v156.clearColor = clearColor;
			//         v146 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(&v141, v6, &v156, 0LL);
			//         v23 = v140;
			//         v26 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v141, &v147, &v8.sceneDepth, 0LL);
			//         if ( !v23 )
			//           sub_1802DC2C8(v25, v24);
			//         v23[1] = (Object)v26;
			//         v27 = v140;
			//         if ( !v140 )
			//           sub_1802DC2C8(v25, 0LL);
			//         v140[2].klass = (Object__Class *)v8.visibilitySHMaterial;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v28 = ((unsigned __int64)&v27[2] >> 12) & 0x1FFFFF;
			//           v29 = v28 >> 6;
			//           v30 = v28 & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v29 + 36190]);
			//           do
			//             v31 = qword_18D6405E0[v29 + 36190];
			//           while ( v31 != _InterlockedCompareExchange64(&qword_18D6405E0[v29 + 36190], v31 | (1LL << v30), v31) );
			//         }
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
			//           &v141,
			//           &v147,
			//           &v146,
			//           DepthAccess__Enum_Write,
			//           RenderBufferLoadAction__Enum_DontCare,
			//           RenderBufferStoreAction__Enum_Store,
			//           0.0,
			//           0,
			//           0,
			//           0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::CapsuleShadowPassConstructor);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//           &v147,
			//           (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::CapsuleShadowPassConstructor.static_fields.s_DonwSampleDepthRenderFunc,
			//           0LL,
			//           0,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::CapsuleShadowPassConstructor::DownSampleDepthPassData>);
			//       }
			//       catch ( Il2CppExceptionWrapper *v149 )
			//       {
			//         ex = v149.ex;
			//         sub_180222690(&ex);
			//         v6 = renderGraph;
			//         v8 = input;
			//         v9 = this;
			//         width = v138;
			//         height = v139;
			//         goto LABEL_23;
			//       }
			//       sub_180222690(&ex);
			//     }
			// LABEL_23:
			//     v32 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//             (Int32Enum__Enum)0x6Au,
			//             MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     if ( !v6 )
			//       sub_1802DC2C8(v34, v33);
			//     HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//       &v137,
			//       v6,
			//       (String *)"Capsule Shadow",
			//       &v131,
			//       v32,
			//       1,
			//       ProfilingHGPass__Enum_None,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::CapsuleShadowPassConstructor::CapsuleShadowPassDataV2>);
			//     v143 = v137;
			//     ex = 0LL;
			//     v135 = &v143;
			//     HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v143, 0, 0LL);
			//     v36 = v131;
			//     if ( !v131 )
			//       sub_1802DC2C8(v35, 0LL);
			//     v131[9].klass = (Object__Class *)v9.fields.m_sphereMesh;
			//     if ( dword_18D8E43F8 )
			//     {
			//       v37 = ((unsigned __int64)&v36[9] >> 12) & 0x1FFFFF;
			//       v38 = v37 >> 6;
			//       v39 = v37 & 0x3F;
			//       _m_prefetchw(&qword_18D6405E0[v38 + 36190]);
			//       do
			//         v40 = qword_18D6405E0[v38 + 36190];
			//       while ( v40 != _InterlockedCompareExchange64(&qword_18D6405E0[v38 + 36190], v40 | (1LL << v39), v40) );
			//     }
			//     v41 = v131;
			//     v44 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v141, &v143, &v8.sceneDepthCopied, 0LL);
			//     if ( !v41 )
			//       sub_1802DC2C8(v43, v42);
			//     *(TextureHandle *)&v41[7].monitor = v44;
			//     *(TextureHandle *)&v136.bufferId = *HG::Rendering::Runtime::GBufferOutput::GetGBufferAttachment(
			//                                           &v141,
			//                                           &v8.gBufferOutput,
			//                                           GBufferID__Enum_GBufferB,
			//                                           0LL);
			//     v45 = v131;
			//     v48 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//              &v141,
			//              &v143,
			//              (TextureHandle *)&v136,
			//              0LL);
			//     if ( !v45 )
			//       sub_1802DC2C8(v47, v46);
			//     *(TextureHandle *)&v45[6].monitor = v48;
			//     v49 = v131;
			//     if ( !v131 )
			//       sub_1802DC2C8(v47, 0LL);
			//     v131[8].monitor = (MonitorData *)v8.visibilitySHMaterial;
			//     v50 = dword_18D8E43F8;
			//     if ( dword_18D8E43F8 )
			//     {
			//       v51 = ((unsigned __int64)&v49[8].monitor >> 12) & 0x1FFFFF;
			//       v52 = v51 >> 6;
			//       v53 = v51 & 0x3F;
			//       _m_prefetchw(&qword_18D6405E0[v52 + 36190]);
			//       do
			//         v54 = qword_18D6405E0[v52 + 36190];
			//       while ( v54 != _InterlockedCompareExchange64(&qword_18D6405E0[v52 + 36190], v54 | (1LL << v53), v54) );
			//       v50 = dword_18D8E43F8;
			//     }
			//     v55 = v131;
			//     m_visibilityABLut = (Object__Class *)v9.fields.m_visibilityABLut;
			//     if ( !v131 )
			//       sub_1802DC2C8(m_visibilityABLut, 0LL);
			//     v131[6].klass = m_visibilityABLut;
			//     if ( v50 )
			//     {
			//       v57 = ((unsigned __int64)&v55[6] >> 12) & 0x1FFFFF;
			//       v58 = v57 >> 6;
			//       v59 = v57 & 0x3F;
			//       _m_prefetchw(&qword_18D6405E0[v58 + 36190]);
			//       do
			//         v60 = qword_18D6405E0[v58 + 36190];
			//       while ( v60 != _InterlockedCompareExchange64(&qword_18D6405E0[v58 + 36190], v60 | (1LL << v59), v60) );
			//       v50 = dword_18D8E43F8;
			//     }
			//     v61 = v131;
			//     m_visibilitySHLut = (MonitorData *)v9.fields.m_visibilitySHLut;
			//     if ( !v131 )
			//       sub_1802DC2C8(m_visibilitySHLut, 0LL);
			//     v131[5].monitor = m_visibilitySHLut;
			//     if ( v50 )
			//     {
			//       v63 = ((unsigned __int64)&v61[5].monitor >> 12) & 0x1FFFFF;
			//       v64 = v63 >> 6;
			//       v65 = v63 & 0x3F;
			//       _m_prefetchw(&qword_18D6405E0[v64 + 36190]);
			//       do
			//         v66 = qword_18D6405E0[v64 + 36190];
			//       while ( v66 != _InterlockedCompareExchange64(&qword_18D6405E0[v64 + 36190], v66 | (1LL << v65), v66) );
			//     }
			//     RenderCapsuleNum = UnityEngine::HyperGryph::HGCapsuleShadowManager::GetRenderCapsuleNum(0LL);
			//     if ( !MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>.rgctx_data )
			//       sub_180041F40(MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>);
			//     v69 = MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::HyperGryph::CapsuleData>;
			//     if ( !MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::HyperGryph::CapsuleData>.rgctx_data )
			//       sub_180041F40(MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::HyperGryph::CapsuleData>);
			//     v70 = (float)RenderCapsuleNum;
			//     if ( v70 >= 1365.0 )
			//       v70 = 1365.0;
			//     v71 = (int)v70;
			//     if ( v8.enabled && v71 )
			//     {
			//       m_RenderGraphContext = v6.fields.m_RenderGraphContext;
			//       if ( !m_RenderGraphContext )
			//         sub_1802DC2C8(v69, v67);
			//       p_renderContext = &m_RenderGraphContext.fields.renderContext;
			//       if ( !MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>.rgctx_data )
			//         sub_180041F40(MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>);
			//       if ( !MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::HyperGryph::CapsuleData>.rgctx_data )
			//         sub_180041F40(MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::HyperGryph::CapsuleData>);
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//       v74 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
			//               &v136,
			//               p_renderContext,
			//               48 * v71 + 16,
			//               0LL);
			//       v75 = *(_OWORD *)&v74.bufferId;
			//       ptr = (Void *)v74.ptr;
			//       destination = ptr;
			//       *(_OWORD *)&v137.m_RenderPass = v75;
			//       v137.m_RenderGraph = (HGRenderGraph *)ptr;
			//       if ( !MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>.rgctx_data )
			//         sub_180041F40(MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>);
			//       RenderCapsuleData = UnityEngine::HyperGryph::HGCapsuleShadowManager::CullAndGetRenderCapsuleData(
			//                             camera.fields.cullingViewHandle,
			//                             &v137.m_RenderGraph.fields,
			//                             v71,
			//                             0LL);
			//       *(float *)source = (float)RenderCapsuleData;
			//       *(_DWORD *)&source[4] = 0;
			//       *(_DWORD *)&source[8] = 0;
			//       *(_DWORD *)&source[12] = 0;
			//       if ( !MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>.rgctx_data )
			//         sub_180041F40(MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<UnityEngine::Vector4>);
			//       Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy(destination, source, 16LL, 0LL);
			//       v80 = v131;
			//       if ( !v131 )
			//         sub_1802DC2C8(v79, v78);
			//       *(_OWORD *)&v131[2].monitor = v75;
			//       v80[3].monitor = (MonitorData *)ptr;
			//       if ( RenderCapsuleData )
			//       {
			//         if ( !v131 )
			//           sub_1802DC2C8(v79, v78);
			//         LODWORD(v131[9].monitor) = RenderCapsuleData;
			//         sphereIntervalScale = 2.0;
			//         if ( v8.sphereIntervalScale <= 2.0 )
			//           sphereIntervalScale = v8.sphereIntervalScale;
			//         v82 = 1061997773;
			//         if ( sphereIntervalScale >= 0.80000001 )
			//           v82 = LODWORD(sphereIntervalScale);
			//         sphereRangeScale = 5.0;
			//         if ( v8.sphereRangeScale <= 5.0 )
			//           sphereRangeScale = v8.sphereRangeScale;
			//         v84 = 1008981770;
			//         if ( sphereRangeScale >= 0.0099999998 )
			//           v84 = LODWORD(sphereRangeScale);
			//         sub_1802F01E0(v150, 0LL, 128LL);
			//         v87 = width;
			//         v88 = height;
			//         *(_QWORD *)&v151 = 1046173638LL;
			//         *((float *)&v151 + 2) = (float)width;
			//         *((float *)&v151 + 3) = (float)height;
			//         *(_QWORD *)&v152 = __PAIR64__(v84, v82);
			//         *((float *)&v152 + 2) = 1.0 / (float)width;
			//         *((float *)&v152 + 3) = 1.0 / (float)height;
			//         *(__m128i *)v158 = _mm_load_si128((const __m128i *)&xmmword_18C3713B0);
			//         si128 = _mm_load_si128((const __m128i *)&xmmword_18C371400);
			//         v160 = _mm_load_si128((const __m128i *)&xmmword_18C371140);
			//         v161 = v151;
			//         v162 = v152;
			//         v163 = v153;
			//         v164 = v154;
			//         v165 = v155;
			//         v89 = (ScriptableRenderContext *)v6.fields.m_RenderGraphContext;
			//         if ( !v89 )
			//           sub_1802DC2C8(v86, v85);
			//         if ( !MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<HG::Rendering::Runtime::CapsuleShadowPassConstructor::VisibilitySHConstData>.rgctx_data )
			//           sub_180041F40(MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<HG::Rendering::Runtime::CapsuleShadowPassConstructor::VisibilitySHConstData>);
			//         sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//         ConstantBuffer = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
			//                            (CBHandle *)&v137,
			//                            v89 + 2,
			//                            128,
			//                            0LL);
			//         v91 = *(Object *)&ConstantBuffer.bufferId;
			//         v92 = (HGRenderGraph *)ConstantBuffer.ptr;
			//         v137.m_RenderGraph = v92;
			//         if ( !MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<HG::Rendering::Runtime::CapsuleShadowPassConstructor::VisibilitySHConstData>.rgctx_data )
			//           sub_180041F40(MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<HG::Rendering::Runtime::CapsuleShadowPassConstructor::VisibilitySHConstData>);
			//         Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy((Void *)v137.m_RenderGraph, v158, 128LL, 0LL);
			//         v95 = v131;
			//         if ( !v131 )
			//           sub_1802DC2C8(v94, v93);
			//         v131[1] = v91;
			//         v95[2].klass = (Object__Class *)v92;
			//         sub_1802F01E0(&v148, 0LL, 96LL);
			//         HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v148, v87, v88, 0LL);
			//         *(_OWORD *)&v145.width = *(_OWORD *)&v148.width;
			//         v145.dimension = v148.dimension;
			//         *(_OWORD *)&v145.enableRandomWrite = *(_OWORD *)&v148.enableRandomWrite;
			//         *(_OWORD *)&v145.bindTextureMS = *(_OWORD *)&v148.bindTextureMS;
			//         *(_OWORD *)&v145.fastMemoryDesc.inFastMemory = *(_OWORD *)&v148.fastMemoryDesc.inFastMemory;
			//         v145.clearColor = v148.clearColor;
			//         v145.colorFormat = 48;
			//         v145.useMipMap = 0;
			//         *(_QWORD *)&v145.filterMode = 0x100000001LL;
			//         *(_OWORD *)&v157.width = *(_OWORD *)&v148.width;
			//         *(_OWORD *)&v157.colorFormat = *(_OWORD *)&v145.colorFormat;
			//         *(_OWORD *)&v157.enableRandomWrite = *(_OWORD *)&v145.enableRandomWrite;
			//         *(_OWORD *)&v157.bindTextureMS = *(_OWORD *)&v148.bindTextureMS;
			//         *(_OWORD *)&v157.fastMemoryDesc.inFastMemory = *(_OWORD *)&v148.fastMemoryDesc.inFastMemory;
			//         v157.clearColor = v148.clearColor;
			//         v141 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(&v141, v6, &v157, 0LL);
			//         v96 = v131;
			//         *(_OWORD *)&v136.bufferId = 0LL;
			//         v99 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//                  (TextureHandle *)&v137,
			//                  &v143,
			//                  &v141,
			//                  0,
			//                  RenderBufferLoadAction__Enum_Clear,
			//                  RenderBufferStoreAction__Enum_Store,
			//                  (Color *)&v136,
			//                  0,
			//                  0LL);
			//         if ( !v96 )
			//           sub_1802DC2C8(v98, v97);
			//         v96[4] = (Object)v99;
			//         if ( v8.enableHalfRez )
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
			//             (TextureHandle *)&v137,
			//             &v143,
			//             &v146,
			//             DepthAccess__Enum_Read,
			//             RenderBufferLoadAction__Enum_Load,
			//             RenderBufferStoreAction__Enum_Store,
			//             0.0,
			//             0,
			//             0,
			//             0LL);
			//         else
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
			//             (TextureHandle *)&v137,
			//             &v143,
			//             &v8.sceneDepth,
			//             DepthAccess__Enum_Read,
			//             RenderBufferLoadAction__Enum_Load,
			//             RenderBufferStoreAction__Enum_Store,
			//             0.0,
			//             0,
			//             0,
			//             0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::CapsuleShadowPassConstructor);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//           &v143,
			//           (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::CapsuleShadowPassConstructor.static_fields.s_CapsuleShadowRenderFuncV2,
			//           0LL,
			//           0,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::CapsuleShadowPassConstructor::CapsuleShadowPassDataV2>);
			//         sub_180222690(&ex);
			//         return;
			//       }
			//       v100 = v131;
			//       v101 = v6.fields.m_RenderGraphContext;
			//       if ( !v101 )
			//         sub_1802DC2C8(v79, v78);
			//       v102 = &v101.fields.renderContext;
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//       v103 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer((CBHandle *)&v137, v102, 0, 0LL);
			//       v106 = (Object__Class *)v103.ptr;
			//       if ( !v100 )
			//         sub_1802DC2C8(v105, v104);
			//       v100[1] = *(Object *)&v103.bufferId;
			//       v100[2].klass = v106;
			//       v107 = v131;
			//       if ( !v131 )
			//         sub_1802DC2C8(v105, v104);
			//       if ( !MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<HG::Rendering::Runtime::CapsuleShadowPassConstructor::VisibilitySHConstData>.rgctx_data )
			//         sub_180041F40(MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<HG::Rendering::Runtime::CapsuleShadowPassConstructor::VisibilitySHConstData>);
			//       LODWORD(v107[1].monitor) = 128;
			//       v108 = v131;
			//       blackTexture = UnityEngine::Texture2D::get_blackTexture(0LL);
			//       if ( !v108 )
			//         sub_1802DC2C8(v111, v110);
			//       v108[5].klass = (Object__Class *)blackTexture;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v112 = (((unsigned __int64)&v108[5] >> 12) & 0x1FFFFF) >> 6;
			//         _m_prefetchw(&qword_18D6405E0[v112 + 36190]);
			//         do
			//           v113 = qword_18D6405E0[v112 + 36190];
			//         while ( v113 != _InterlockedCompareExchange64(
			//                           &qword_18D6405E0[v112 + 36190],
			//                           v113 | (1LL << (((unsigned __int64)&v108[5] >> 12) & 0x3F)),
			//                           v113) );
			//       }
			//     }
			//     else
			//     {
			//       v114 = v131;
			//       v115 = v6.fields.m_RenderGraphContext;
			//       if ( !v115 )
			//         sub_1802DC2C8(v69, v67);
			//       v116 = &v115.fields.renderContext;
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//       v117 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer((CBHandle *)&v137, v116, 0, 0LL);
			//       v120 = (Object__Class *)v117.ptr;
			//       if ( !v114 )
			//         sub_1802DC2C8(v119, v118);
			//       v114[1] = *(Object *)&v117.bufferId;
			//       v114[2].klass = v120;
			//       v121 = v131;
			//       if ( !v131 )
			//         sub_1802DC2C8(v119, v118);
			//       if ( !MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<HG::Rendering::Runtime::CapsuleShadowPassConstructor::VisibilitySHConstData>.rgctx_data )
			//         sub_180041F40(MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::SizeOf<HG::Rendering::Runtime::CapsuleShadowPassConstructor::VisibilitySHConstData>);
			//       LODWORD(v121[1].monitor) = 128;
			//       v122 = v131;
			//       v123 = UnityEngine::Texture2D::get_blackTexture(0LL);
			//       if ( !v122 )
			//         sub_1802DC2C8(v125, v124);
			//       v122[5].klass = (Object__Class *)v123;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v126 = (((unsigned __int64)&v122[5] >> 12) & 0x1FFFFF) >> 6;
			//         _m_prefetchw(&qword_18D6405E0[v126 + 36190]);
			//         do
			//           v127 = qword_18D6405E0[v126 + 36190];
			//         while ( v127 != _InterlockedCompareExchange64(
			//                           &qword_18D6405E0[v126 + 36190],
			//                           v127 | (1LL << (((unsigned __int64)&v122[5] >> 12) & 0x3F)),
			//                           v127) );
			//       }
			//     }
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::CapsuleShadowPassConstructor);
			//     HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//       &v143,
			//       (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::CapsuleShadowPassConstructor.static_fields.s_CapsuleShadowRenderFuncEmptyV2,
			//       0LL,
			//       0,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::CapsuleShadowPassConstructor::CapsuleShadowPassDataV2>);
			//     sub_180222690(&ex);
			//     return;
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1775, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v130, v129);
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_689(Patch, (Object *)v9, v8, output, (Object *)v6, (Object *)camera, 0LL);
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::CapsuleShadowPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         CapsuleShadowPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1778, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1778, 0LL);
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
			// void HG::Rendering::Runtime::CapsuleShadowPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
			//         CapsuleShadowPassConstructor *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1779, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1779, 0LL);
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

		private Shader m_visibilitySHShader;

		private Mesh m_sphereMesh;

		private Texture2D m_visibilityABLut;

		private Texture2D m_visibilitySHLut;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly RenderFunc<CapsuleShadowPassConstructor.CapsuleShadowPassDataV2> s_CapsuleShadowRenderFuncV2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		private static readonly RenderFunc<CapsuleShadowPassConstructor.CapsuleShadowPassDataV2> s_CapsuleShadowRenderFuncEmptyV2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		private static readonly RenderFunc<CapsuleShadowPassConstructor.DownSampleDepthPassData> s_DonwSampleDepthRenderFunc;

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct PassInput
		{
			internal TextureHandle sceneDepth;

			internal TextureHandle sceneDepthCopied;

			internal TextureHandle sceneMV;

			internal CullingResults cullingResults;

			internal LightCullResult lightCullResult;

			internal GBufferOutput gBufferOutput;

			internal int directionalLightIndex;

			internal float sphereIntervalScale;

			internal float sphereRangeScale;

			internal bool enabled;

			internal bool enableHalfRez;

			internal GraphicsFormat depthFormat;

			internal DepthBits depthBufferBits;

			internal Material visibilitySHMaterial;
		}

		internal struct PassOutput
		{
		}

		private class CapsuleShadowPassData
		{
			public CapsuleShadowPassData()
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

			public TextureHandle gbufferNormalTexture;
		}

		private class DownSampleDepthPassData
		{
			public DownSampleDepthPassData()
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

			public TextureHandle srcDepth;

			public Material visibilitySHMaterial;
		}

		private class CapsuleShadowPassDataV2
		{
			public CapsuleShadowPassDataV2()
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

			public CBHandle visibilitySHCB;

			public CBHandle capsuleCBHandle;

			public TextureHandle visibilitySHRT;

			public Texture2D visibilitySHRTDefault;

			public Texture2D visibilitySHLut;

			public Texture2D visibilityABLut;

			public TextureHandle gBufferB;

			public TextureHandle sceneDepthCopied;

			public Material visibilitySHMaterial;

			public Mesh sphereMesh;

			public int capsuleNum;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 128)]
		private struct VisibilitySHConstData
		{
			public Vector4 logSHParams;

			public Vector4 gStarParams;

			public Vector4 abParams;

			public Vector4 fHatParams;

			public Vector4 sphereParams;

			public Vector4Int tileParam0;

			public Vector4 tileParam1;

			public Vector4 tileParam2;
		}
	}
}
