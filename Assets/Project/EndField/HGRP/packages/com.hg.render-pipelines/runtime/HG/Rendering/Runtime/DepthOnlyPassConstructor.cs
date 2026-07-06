using System;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	internal class DepthOnlyPassConstructor : IPassConstructor
	{
		internal DepthOnlyPassConstructor(HGRenderPipelineMaterialCollector materialCollector, HGRenderPathBase.HGRenderPathResources resources)
		{
		}

		private void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::DepthOnlyPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         DepthOnlyPassConstructor *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2560, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2560, 0LL);
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
			// void HG::Rendering::Runtime::DepthOnlyPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         DepthOnlyPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2561, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2561, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		internal void ConstructPass(ref DepthOnlyPassConstructor.PassInput input, ref DepthOnlyPassConstructor.PassOutput output, HGRenderGraph renderGraph, HGCamera camera)
		{
			// // Void ConstructPass(DepthOnlyPassConstructor+PassInput ByRef, DepthOnlyPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::DepthOnlyPassConstructor::ConstructPass(
			//         DepthOnlyPassConstructor *this,
			//         DepthOnlyPassConstructor_PassInput *input,
			//         DepthOnlyPassConstructor_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   Object *v6; // r14
			//   DepthOnlyPassConstructor_PassInput *v8; // r12
			//   Object *v9; // r15
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   int v12; // eax
			//   HGCamera *v13; // r13
			//   int v14; // ecx
			//   __int64 v15; // rdx
			//   _OWORD *v16; // rax
			//   Matrix4x4 *v17; // rcx
			//   __int64 v18; // rdx
			//   ProfilingSampler *v19; // rax
			//   __int64 v20; // rdx
			//   __int64 v21; // rcx
			//   __int64 v22; // rcx
			//   Object *v23; // rdx
			//   int v24; // eax
			//   unsigned __int64 v25; // rdx
			//   unsigned __int64 v26; // r8
			//   char v27; // dl
			//   signed __int64 v28; // rtt
			//   Object *v29; // rdx
			//   MonitorData *monitor; // rcx
			//   unsigned __int64 v31; // rdx
			//   unsigned __int64 v32; // r8
			//   char v33; // dl
			//   signed __int64 v34; // rtt
			//   Object *v35; // rdx
			//   Object__Class *klass; // rcx
			//   unsigned __int64 v37; // rdx
			//   unsigned __int64 v38; // r8
			//   signed __int64 v39; // rtt
			//   Object *v40; // rax
			//   DepthOnlyPassConstructor__StaticFields *static_fields; // rcx
			//   __int128 v42; // xmm7
			//   __int128 v43; // xmm8
			//   __int128 v44; // xmm9
			//   __int128 v45; // xmm10
			//   int v46; // ebx
			//   Void *m_Buffer; // r14
			//   __int64 v48; // rdx
			//   DepthOnlyPassConstructor__StaticFields *v49; // rcx
			//   __int64 v50; // rdx
			//   HGGraphicsFeatureManager__StaticFields *v51; // rcx
			//   HGGraphicsFeatureSwitch *customDepthPass; // rax
			//   bool m_defaultValue; // r15
			//   Object *v54; // rbx
			//   bool v55; // zf
			//   __int64 v56; // rdx
			//   __int64 v57; // rcx
			//   int v58; // eax
			//   Camera *v59; // rcx
			//   int32_t i; // ebx
			//   __m128i v61; // xmm6
			//   CullingResults v62; // xmm6
			//   int32_t v63; // ebx
			//   __int64 v64; // rdx
			//   HGRenderGraphPass *InvalidHandle; // rax
			//   RendererListHandle *v66; // rbx
			//   RendererListHandle v67; // rax
			//   RendererListHandle v68; // rdx
			//   RendererListHandle v69; // rcx
			//   Camera *v70; // rbx
			//   __int64 v71; // rdx
			//   uint64_t SceneCullingMaskFromCamera; // r14
			//   Camera *v73; // rcx
			//   int32_t cullingMask; // ebx
			//   uint32_t COMPOUND_CHARACTER_LAYER_MASK; // r9d
			//   uint32_t v76; // r14d
			//   __int64 v77; // rdx
			//   __int64 v78; // rcx
			//   Object *v79; // rbx
			//   uint32_t RendererList; // eax
			//   Object *v81; // r14
			//   Camera *v82; // r15
			//   HGRenderGraphPass *sceneRTSize_k__BackingField; // rbx
			//   void *m_Ptr; // rax
			//   uint32_t v85; // eax
			//   __int64 v86; // rdx
			//   __int64 v87; // rcx
			//   Object *v88; // rbx
			//   HGRenderGraphPass *v89; // rax
			//   void *v90; // rdx
			//   uint32_t v91; // eax
			//   __int64 v92; // rdx
			//   __int64 v93; // rcx
			//   __int64 v94; // rdx
			//   signed __int64 v95; // rcx
			//   Object *v96; // rdx
			//   unsigned int v97; // edx
			//   unsigned __int64 v98; // r8
			//   signed __int64 v99; // rtt
			//   Object *v100; // rax
			//   Object *v101; // rax
			//   Object *v102; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v104; // rdx
			//   __int64 v105; // rcx
			//   HGRenderKeyword__Enum globalKeywords; // [rsp+20h] [rbp-C08h]
			//   Object *v107; // [rsp+60h] [rbp-BC8h] BYREF
			//   __int32 v108; // [rsp+68h] [rbp-BC0h]
			//   int v109; // [rsp+6Ch] [rbp-BBCh]
			//   HGRenderGraphBuilder inputa; // [rsp+70h] [rbp-BB8h] BYREF
			//   __int64 v111; // [rsp+90h] [rbp-B98h]
			//   __int64 v112; // [rsp+98h] [rbp-B90h]
			//   _QWORD v113[2]; // [rsp+A8h] [rbp-B80h] BYREF
			//   HGRenderGraphBuilder v114; // [rsp+B8h] [rbp-B70h] BYREF
			//   Vector3 viewPosition; // [rsp+E0h] [rbp-B48h] BYREF
			//   NativeArray_1_UnityEngine_HyperGryph_ECS_EntityCommandBufferV2_VirtualEntityMap_ v116; // [rsp+F0h] [rbp-B38h] BYREF
			//   Void customPayload[16]; // [rsp+100h] [rbp-B28h] BYREF
			//   __m128i v118; // [rsp+110h] [rbp-B18h]
			//   NativeArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_RenderData_ v119; // [rsp+120h] [rbp-B08h] BYREF
			//   Matrix4x4 viewProj; // [rsp+130h] [rbp-AF8h] BYREF
			//   Il2CppExceptionWrapper *v121; // [rsp+170h] [rbp-AB8h] BYREF
			//   Matrix4x4 v122; // [rsp+180h] [rbp-AA8h] BYREF
			//   Object v123; // [rsp+1C0h] [rbp-A68h]
			//   Object v124; // [rsp+1D0h] [rbp-A58h]
			//   Object v125; // [rsp+1E0h] [rbp-A48h]
			//   Object v126; // [rsp+1F0h] [rbp-A38h]
			//   Object v127; // [rsp+200h] [rbp-A28h]
			//   TextureHandle v128[2]; // [rsp+210h] [rbp-A18h] BYREF
			//   Object__Class *v129; // [rsp+230h] [rbp-9F8h]
			//   __int128 v130; // [rsp+238h] [rbp-9F0h]
			//   MonitorData *v131; // [rsp+248h] [rbp-9E0h]
			//   Object v132; // [rsp+250h] [rbp-9D8h]
			//   Object v133; // [rsp+260h] [rbp-9C8h]
			//   Object v134; // [rsp+270h] [rbp-9B8h]
			//   Object v135; // [rsp+280h] [rbp-9A8h]
			//   Object v136; // [rsp+290h] [rbp-998h]
			//   Object v137; // [rsp+2A0h] [rbp-988h]
			//   int v138; // [rsp+2B0h] [rbp-978h]
			//   int v139; // [rsp+2B4h] [rbp-974h]
			//   unsigned __int8 v140; // [rsp+2B8h] [rbp-970h]
			//   bool value; // [rsp+2B9h] [rbp-96Fh]
			//   Matrix4x4 v142; // [rsp+2C0h] [rbp-968h] BYREF
			//   Matrix4x4 v143; // [rsp+300h] [rbp-928h] BYREF
			//   CullingResults v144; // [rsp+340h] [rbp-8E8h] BYREF
			//   TextureHandle v145; // [rsp+350h] [rbp-8D8h] BYREF
			//   TextureHandle v146; // [rsp+360h] [rbp-8C8h] BYREF
			//   RendererListDesc desc; // [rsp+370h] [rbp-8B8h] BYREF
			//   RendererListDesc v148; // [rsp+450h] [rbp-7D8h] BYREF
			//   ScriptableCullingParameters cullingParameters; // [rsp+530h] [rbp-6F8h] BYREF
			// 
			//   v6 = (Object *)renderGraph;
			//   v8 = input;
			//   v9 = (Object *)this;
			//   if ( !byte_18D91952B )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::DepthOnlyPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCamera);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::DepthOnlyPassConstructor::DepthOnlyPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::DepthOnlyPassConstructor::DepthOnlyPassData>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderPassNames);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<UnityEngine::Plane>::NativeArray);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableCullingParameters);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     sub_18003C530(&off_18D4FA838);
			//     byte_18D91952B = 1;
			//   }
			//   memset(&v114, 0, sizeof(v114));
			//   v107 = 0LL;
			//   v116 = 0LL;
			//   sub_1802F01E0(&cullingParameters, 0LL, 1592LL);
			//   v112 = 0LL;
			//   *(_OWORD *)customPayload = 0LL;
			//   *(_OWORD *)&inputa.m_RenderPass = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2562, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2562, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v105, v104);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_940(Patch, v9, v8, output, v6, (Object *)camera, 0LL);
			//   }
			//   else
			//   {
			//     if ( !v8.customDepthOnlyRequestManger )
			//       sub_180B536AC(v11, v10);
			//     v118 = *(__m128i *)HG::Rendering::Runtime::CustomDepthOnlyRequestManager::RetrieveAllSystemRenderData(
			//                          &v119,
			//                          v8.customDepthOnlyRequestManger,
			//                          (HGRenderGraph *)v6,
			//                          0LL);
			//     v12 = 0;
			//     v13 = camera;
			//     v14 = _mm_cvtsi128_si32(_mm_srli_si128(v118, 8));
			//     v108 = v14;
			//     v15 = v118.m128i_i64[0];
			//     v111 = v118.m128i_i64[0];
			//     while ( 1 )
			//     {
			//       v109 = v12;
			//       if ( v12 >= v14 )
			//         break;
			//       v16 = (_OWORD *)(v15 + 320LL * v12);
			//       v17 = &v122;
			//       v18 = 2LL;
			//       do
			//       {
			//         *(_OWORD *)&v17.m00 = *v16;
			//         *(_OWORD *)&v17.m01 = v16[1];
			//         *(_OWORD *)&v17.m02 = v16[2];
			//         *(_OWORD *)&v17.m03 = v16[3];
			//         *(_OWORD *)&v17[1].m00 = v16[4];
			//         *(_OWORD *)&v17[1].m01 = v16[5];
			//         *(_OWORD *)&v17[1].m02 = v16[6];
			//         v17 += 2;
			//         *(_OWORD *)&v17[-1].m03 = v16[7];
			//         v16 += 8;
			//         --v18;
			//       }
			//       while ( v18 );
			//       *(_OWORD *)&v17.m00 = *v16;
			//       *(_OWORD *)&v17.m01 = v16[1];
			//       *(_OWORD *)&v17.m02 = v16[2];
			//       *(_OWORD *)&v17.m03 = v16[3];
			//       v19 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//               (Int32Enum__Enum)0x90u,
			//               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//       if ( !v6 )
			//         sub_180B536AC(v21, v20);
			//       HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//         &inputa,
			//         (HGRenderGraph *)v6,
			//         (String *)"Custom Depth Only Pass",
			//         &v107,
			//         v19,
			//         1,
			//         ProfilingHGPass__Enum_None,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::DepthOnlyPassConstructor::DepthOnlyPassData>);
			//       v114 = inputa;
			//       v113[0] = 0LL;
			//       v113[1] = &v114;
			//       try
			//       {
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v114, 0, 0LL);
			//         v23 = v107;
			//         if ( !v107 )
			//           sub_1802DC2C8(v22, 0LL);
			//         v107[20].monitor = (MonitorData *)v13;
			//         v24 = dword_18D8E43F8;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v25 = ((unsigned __int64)&v23[20].monitor >> 12) & 0x1FFFFF;
			//           v26 = v25 >> 6;
			//           v27 = v25 & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v26 + 36190]);
			//           do
			//             v28 = qword_18D6405E0[v26 + 36190];
			//           while ( v28 != _InterlockedCompareExchange64(&qword_18D6405E0[v26 + 36190], v28 | (1LL << v27), v28) );
			//           v24 = dword_18D8E43F8;
			//         }
			//         v29 = v107;
			//         monitor = v9[1].monitor;
			//         if ( !v107 )
			//           sub_1802DC2C8(monitor, 0LL);
			//         v107[19].monitor = monitor;
			//         if ( v24 )
			//         {
			//           v31 = ((unsigned __int64)&v29[19].monitor >> 12) & 0x1FFFFF;
			//           v32 = v31 >> 6;
			//           v33 = v31 & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v32 + 36190]);
			//           do
			//             v34 = qword_18D6405E0[v32 + 36190];
			//           while ( v34 != _InterlockedCompareExchange64(&qword_18D6405E0[v32 + 36190], v34 | (1LL << v33), v34) );
			//           v24 = dword_18D8E43F8;
			//         }
			//         v35 = v107;
			//         klass = v9[2].klass;
			//         if ( !v107 )
			//           sub_1802DC2C8(klass, 0LL);
			//         v107[20].klass = klass;
			//         if ( v24 )
			//         {
			//           v37 = ((unsigned __int64)&v35[20] >> 12) & 0x1FFFFF;
			//           v38 = v37 >> 6;
			//           v35 = (Object *)(v37 & 0x3F);
			//           _m_prefetchw(&qword_18D6405E0[v38 + 36190]);
			//           do
			//           {
			//             klass = (Object__Class *)(qword_18D6405E0[v38 + 36190] | (1LL << (char)v35));
			//             v39 = qword_18D6405E0[v38 + 36190];
			//           }
			//           while ( v39 != _InterlockedCompareExchange64(&qword_18D6405E0[v38 + 36190], (signed __int64)klass, v39) );
			//         }
			//         v40 = v107;
			//         if ( !v107 )
			//           sub_1802DC2C8(klass, v35);
			//         v107[1] = v123;
			//         v40[2] = v124;
			//         v40[3] = v125;
			//         v40[4] = v126;
			//         Unity::Collections::NativeArray<UnityEngine::HyperGryph::ECS::EntityCommandBufferV2::VirtualEntityMap>::NativeArray(
			//           &v116,
			//           6,
			//           Allocator__Enum_Temp,
			//           NativeArrayOptions__Enum_ClearMemory,
			//           MethodInfo::Unity::Collections::NativeArray<UnityEngine::Plane>::NativeArray);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::DepthOnlyPassConstructor);
			//         static_fields = TypeInfo::HG::Rendering::Runtime::DepthOnlyPassConstructor.static_fields;
			//         v42 = *(_OWORD *)&v122.m00;
			//         viewProj = v122;
			//         v43 = *(_OWORD *)&v122.m01;
			//         v44 = *(_OWORD *)&v122.m02;
			//         v45 = *(_OWORD *)&v122.m03;
			//         UnityEngine::GeometryUtility::CalculateFrustumPlanes(&viewProj, static_fields.s_tempPlanes, 0LL);
			//         v46 = 0;
			//         m_Buffer = v116.m_Buffer;
			//         while ( v46 < 6 )
			//         {
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::DepthOnlyPassConstructor);
			//           v49 = TypeInfo::HG::Rendering::Runtime::DepthOnlyPassConstructor.static_fields;
			//           if ( !v49.s_tempPlanes )
			//             sub_1802DC2C8(v49, v48);
			//           sub_180037190(v49.s_tempPlanes, &v119, v46);
			//           *(NativeArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_RenderData_ *)&m_Buffer[16 * v46++] = v119;
			//         }
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//         v51 = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields;
			//         customDepthPass = v51.customDepthPass;
			//         if ( !customDepthPass )
			//           sub_1802DC2C8(v51, v50);
			//         m_defaultValue = customDepthPass.fields.m_defaultValue;
			//         v54 = v107;
			//         v55 = !UnityEngine::HyperGryph::HGGraphicsUtils::get_enableECSRenderer(0LL);
			//         v58 = 0;
			//         if ( v55 )
			//           v58 = v140;
			//         if ( !v54 )
			//           sub_1802DC2C8(v57, v56);
			//         LOBYTE(v54[18].monitor) = v58 != 0;
			//         if ( !v107 )
			//           sub_1802DC2C8(v57, v56);
			//         if ( LOBYTE(v107[18].monitor) )
			//         {
			//           if ( !v13 )
			//             sub_1802DC2C8(v57, v56);
			//           v59 = v13.fields.camera;
			//           if ( !v59 )
			//             sub_1802DC2C8(0LL, v56);
			//           UnityEngine::Camera::GetCullingParameters_Internal(v59, 0, &cullingParameters, 1592, 0LL);
			//           sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableCullingParameters);
			//           *(_OWORD *)&cullingParameters.m_CameraProperties.cameraClipToWorld.m20 = v42;
			//           *(_OWORD *)&cullingParameters.m_CameraProperties.cameraClipToWorld.m21 = v43;
			//           *(_OWORD *)&cullingParameters.m_CameraProperties.cameraClipToWorld.m22 = v44;
			//           *(_OWORD *)&cullingParameters.m_CameraProperties.cameraClipToWorld.m23 = v45;
			//           UnityEngine::Rendering::ScriptableCullingParameters::set_isOrthographic(&cullingParameters, value, 0LL);
			//           cullingParameters.m_CameraProperties.cameraWorldToClip.m31 = 0.0;
			//           for ( i = 0; i < 6; ++i )
			//           {
			//             v61 = _mm_loadu_si128((const __m128i *)&m_Buffer[16 * i]);
			//             sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableCullingParameters);
			//             *(__m128i *)&inputa.m_RenderPass = v61;
			//             UnityEngine::Rendering::ScriptableCullingParameters::SetCullingPlane(
			//               &cullingParameters,
			//               i,
			//               (Plane *)&inputa,
			//               0LL);
			//           }
			//           sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//           v62 = *UnityEngine::Rendering::ScriptableRenderContext::Cull(&v144, &v8.srpContext, &cullingParameters, 0LL);
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderPassNames);
			//           v63 = UnityEngine::Shader::TagToID(
			//                   TypeInfo::HG::Rendering::Runtime::HGShaderPassNames.static_fields.s_ShadowCasterStr,
			//                   0LL);
			//           if ( m_defaultValue )
			//           {
			//             sub_1802F01E0(&v148, 0LL, 224LL);
			//             *(CullingResults *)&inputa.m_RenderPass = v62;
			//             UnityEngine::Rendering::RendererUtils::RendererListDesc::RendererListDesc(
			//               &v148,
			//               (ShaderTagId)v63,
			//               (CullingResults *)&inputa,
			//               v13.fields.camera,
			//               0LL);
			//             desc = v148;
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
			//             desc.renderQueueRange = TypeInfo::HG::Rendering::Runtime::HGRenderQueue.static_fields.k_RenderQueue_AllOpaque;
			//             desc.sortingCriteria = 59;
			//             desc.rendererConfiguration = 6144;
			//             if ( !renderGraph )
			//               sub_1802DC2C8(0LL, v64);
			//             InvalidHandle = (HGRenderGraphPass *)HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererList(
			//                                                    renderGraph,
			//                                                    &desc,
			//                                                    0LL);
			//           }
			//           else
			//           {
			//             InvalidHandle = (HGRenderGraphPass *)HG::Rendering::RenderGraphModule::RendererListHandle::get_InvalidHandle(0LL);
			//           }
			//           inputa.m_RenderPass = InvalidHandle;
			//           v66 = (RendererListHandle *)v107;
			//           v67 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::UseRendererList(
			//                   &v114,
			//                   (RendererListHandle *)&inputa,
			//                   0LL);
			//           if ( !v66 )
			//             sub_1802DC2C8(v69, v68);
			//           v66[10] = v67;
			//         }
			//         else if ( !v13 )
			//         {
			//           sub_1802DC2C8(v57, v56);
			//         }
			//         v70 = v13.fields.camera;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//         SceneCullingMaskFromCamera = HG::Rendering::Runtime::HGUtils::GetSceneCullingMaskFromCamera(v70, 0LL);
			//         v73 = v13.fields.camera;
			//         if ( !v73 )
			//           sub_1802DC2C8(0LL, v71);
			//         cullingMask = UnityEngine::Camera::get_cullingMask(v73, 0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGCamera);
			//         COMPOUND_CHARACTER_LAYER_MASK = TypeInfo::HG::Rendering::Runtime::HGCamera.static_fields.COMPOUND_CHARACTER_LAYER_MASK;
			//         *(NativeArray_1_UnityEngine_HyperGryph_ECS_EntityCommandBufferV2_VirtualEntityMap_ *)&inputa.m_RenderPass = v116;
			//         v76 = UnityEngine::HyperGryph::HGCullingSystem::AddCullViewByPlanes(
			//                 (NativeArray_1_UnityEngine_Plane_ *)&inputa,
			//                 0,
			//                 SceneCullingMaskFromCamera,
			//                 cullingMask & ~COMPOUND_CHARACTER_LAYER_MASK,
			//                 0x4000002u,
			//                 0x4000002u,
			//                 &v13.fields.lodCrossFadeConfig,
			//                 0.0,
			//                 CameraType__Enum_Shadow,
			//                 0LL);
			//         UnityEngine::HyperGryph::HGCullingSystem::DispatchBatchCullingJobs(0LL);
			//         v79 = v107;
			//         if ( m_defaultValue )
			//         {
			//           sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//           LOWORD(globalKeywords) = 0;
			//           RendererList = UnityEngine::HyperGryph::HGMeshRender::CreateRendererList(
			//                            v76,
			//                            HGRenderFlags__Enum_StaticShadowCaster|HGRenderFlags__Enum_CastShadow,
			//                            HGRenderFlags__Enum_StaticShadowCaster|HGRenderFlags__Enum_CastShadow,
			//                            HGShaderLightMode__Enum_ShadowCaster,
			//                            globalKeywords,
			//                            v8.srpContext.m_Ptr,
			//                            0,
			//                            0,
			//                            0xFFFFFFFF,
			//                            0,
			//                            0,
			//                            0LL);
			//         }
			//         else
			//         {
			//           RendererList = -1;
			//         }
			//         if ( !v79 )
			//           sub_1802DC2C8(v78, v77);
			//         LODWORD(v79[5].monitor) = RendererList;
			//         v81 = v107;
			//         v82 = v13.fields.camera;
			//         sceneRTSize_k__BackingField = (HGRenderGraphPass *)v13.fields._sceneRTSize_k__BackingField;
			//         sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//         m_Ptr = v8.srpContext.m_Ptr;
			//         *(_OWORD *)&viewProj.m00 = v42;
			//         *(_OWORD *)&viewProj.m01 = v43;
			//         *(_OWORD *)&viewProj.m02 = v44;
			//         *(_OWORD *)&viewProj.m03 = v45;
			//         inputa.m_RenderPass = sceneRTSize_k__BackingField;
			//         v85 = UnityEngine::HyperGryph::HGTerrainManager::CullTerrain_Injected(
			//                 v82,
			//                 (Vector2Int *)&inputa,
			//                 &viewProj,
			//                 900.0,
			//                 0,
			//                 m_Ptr,
			//                 0LL);
			//         if ( !v81 )
			//           sub_1802DC2C8(v87, v86);
			//         HIDWORD(v81[5].monitor) = v85;
			//         v88 = v107;
			//         v89 = (HGRenderGraphPass *)v13.fields._sceneRTSize_k__BackingField;
			//         v90 = v8.srpContext.m_Ptr;
			//         *(_OWORD *)&v142.m00 = v42;
			//         *(_OWORD *)&v142.m01 = v43;
			//         *(_OWORD *)&v142.m02 = v44;
			//         *(_OWORD *)&v142.m03 = v45;
			//         inputa.m_RenderPass = v89;
			//         v91 = UnityEngine::HyperGryph::HGEditorTerrainManager::CullTerrain_Injected(
			//                 v13.fields.camera,
			//                 (Vector2Int *)&inputa,
			//                 &v142,
			//                 900.0,
			//                 0,
			//                 v90,
			//                 0LL);
			//         if ( !v88 )
			//           sub_1802DC2C8(v93, v92);
			//         LODWORD(v88[6].klass) = v91;
			//         if ( !v107 )
			//           sub_1802DC2C8(v93, v92);
			//         v112 = 0LL;
			//         *(_QWORD *)&viewPosition.x = 0LL;
			//         viewPosition.z = 0.0;
			//         *(_OWORD *)&v143.m00 = v42;
			//         *(_OWORD *)&v143.m01 = v43;
			//         *(_OWORD *)&v143.m02 = v44;
			//         *(_OWORD *)&v143.m03 = v45;
			//         UnityEngine::HyperGryph::HGWaterRender::CullWaterProxy_Injected(
			//           v13.fields.cullingViewHandle,
			//           &v143,
			//           3u,
			//           0,
			//           (uint32_t *)&v107[18].monitor + 1,
			//           (uint32_t *)&v107[19],
			//           0,
			//           &viewPosition,
			//           0LL);
			//         if ( !v107 )
			//           sub_1802DC2C8(v95, v94);
			//         *(TextureHandle *)((char *)v107 + 100) = v128[0];
			//         if ( !v107 )
			//           sub_1802DC2C8(v95, v94);
			//         *(Object *)((char *)v107 + 116) = v127;
			//         v96 = v107;
			//         v9 = (Object *)this;
			//         if ( !v107 )
			//           sub_1802DC2C8(v95, 0LL);
			//         v107[8].monitor = (MonitorData *)this.fields.m_clearDepth;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v97 = ((unsigned __int64)&v96[8].monitor >> 12) & 0x1FFFFF;
			//           v98 = (unsigned __int64)v97 >> 6;
			//           v96 = (Object *)(v97 & 0x3F);
			//           _m_prefetchw(&qword_18D6405E0[v98 + 36190]);
			//           do
			//           {
			//             v95 = qword_18D6405E0[v98 + 36190] | (1LL << (char)v96);
			//             v99 = qword_18D6405E0[v98 + 36190];
			//           }
			//           while ( v99 != _InterlockedCompareExchange64(&qword_18D6405E0[v98 + 36190], v95, v99) );
			//         }
			//         v100 = v107;
			//         if ( !v107 )
			//           sub_1802DC2C8(v95, v96);
			//         v107[9] = (Object)v128[1];
			//         v100[10].klass = v129;
			//         v101 = v107;
			//         if ( !v107 )
			//           sub_1802DC2C8(v95, v96);
			//         *(_OWORD *)&v107[10].monitor = v130;
			//         v101[11].monitor = v131;
			//         if ( !v107 )
			//           sub_1802DC2C8(0LL, v96);
			//         LODWORD(v107[18].klass) = v138;
			//         v102 = v107;
			//         if ( !v107 )
			//           sub_1802DC2C8(0LL, v96);
			//         HIDWORD(v107[18].klass) = v139;
			//         if ( !v107 )
			//           sub_1802DC2C8(v102, v96);
			//         v107[12] = v132;
			//         if ( !v107 )
			//           sub_1802DC2C8(v102, v96);
			//         v107[13] = v133;
			//         if ( !v107 )
			//           sub_1802DC2C8(v102, v96);
			//         v107[14] = v134;
			//         if ( !v107 )
			//           sub_1802DC2C8(v102, v96);
			//         v107[15] = v135;
			//         if ( !v107 )
			//           sub_1802DC2C8(v102, v96);
			//         v107[16] = v136;
			//         if ( !v107 )
			//           sub_1802DC2C8(v102, v96);
			//         v107[17] = v137;
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(&v145, &v114, v128, 0LL);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
			//           &v146,
			//           &v114,
			//           v128,
			//           DepthAccess__Enum_Write,
			//           RenderBufferLoadAction__Enum_Load,
			//           RenderBufferStoreAction__Enum_Store,
			//           1.0,
			//           0,
			//           0,
			//           0LL);
			//         *(_OWORD *)&inputa.m_RenderPass = 0LL;
			//         LODWORD(inputa.m_RenderPass) = 1065353216;
			//         LODWORD(inputa.m_Resources) = 1065353216;
			//         *(_OWORD *)customPayload = *(_OWORD *)&inputa.m_RenderPass;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::DepthOnlyPassConstructor);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//           &v114,
			//           (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::DepthOnlyPassConstructor.static_fields.s_depthOnlyPassFunc,
			//           0LL,
			//           customPayload,
			//           0,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::DepthOnlyPassConstructor::DepthOnlyPassData>);
			//       }
			//       catch ( Il2CppExceptionWrapper *v121 )
			//       {
			//         v113[0] = v121.ex;
			//         sub_180222690(v113);
			//         v13 = camera;
			//         v8 = input;
			//         v14 = v118.m128i_i32[2];
			//         v108 = v118.m128i_i32[2];
			//         v15 = v118.m128i_i64[0];
			//         v111 = v118.m128i_i64[0];
			//         v9 = (Object *)this;
			//         goto LABEL_74;
			//       }
			//       sub_180222690(v113);
			//       v14 = v108;
			//       v15 = v111;
			// LABEL_74:
			//       v12 = v109 + 1;
			//       v6 = (Object *)renderGraph;
			//     }
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::DepthOnlyPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         DepthOnlyPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2563, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2563, 0LL);
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
			// void HG::Rendering::Runtime::DepthOnlyPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
			//         DepthOnlyPassConstructor *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2564, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2564, 0LL);
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

		private Material m_clearDepth;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static Plane[] s_tempPlanes;

		private MaterialPropertyBlock m_waterMPB;

		private Material m_waterProxyMaterial;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		private static readonly RenderFunc<DepthOnlyPassConstructor.DepthOnlyPassData> s_depthOnlyPassFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		private static readonly RenderFunc<DepthOnlyPassConstructor.VSMPassData> s_vsmPassFunc;

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct PassInput
		{
			internal ScriptableRenderContext srpContext;

			internal CustomDepthOnlyRequestManager customDepthOnlyRequestManger;

			internal long customDepthOnlyRequestMangerCPP;
		}

		internal struct PassOutput
		{
		}

		private class DepthOnlyPassData
		{
			public DepthOnlyPassData()
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

			internal Matrix4x4 viewProj;

			internal RendererListHandle rendererList;

			internal uint ecsRendererList;

			internal uint terrainHandle;

			internal uint editorTerrainHandle;

			internal TextureHandle currDepthOnlyRT;

			internal TextureHandle prevDepthOnlyRT;

			internal Material clearDepthMat;

			internal CBHandle cameraHeightRefreshDataCB;

			internal CBHandle transformCB;

			internal Rect clearViewport0;

			internal Rect clearViewport1;

			internal Rect clearViewport2;

			internal Rect clearViewport3;

			internal Rect pageViewport;

			internal Rect wholeViewport;

			internal int depthRTShaderID;

			internal int transformCBShaderID;

			internal bool includeDynamicObjects;

			internal uint waterVisibleCount;

			internal uint waterCullHandle;

			internal MaterialPropertyBlock waterMPB;

			internal Material waterProxyMaterial;

			internal HGCamera hgCamera;
		}

		private class VSMPassData
		{
			public VSMPassData()
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

			internal int vsmRTID;

			internal TextureHandle vsmRTHandle;

			internal Material vsmMaterial;
		}
	}
}
