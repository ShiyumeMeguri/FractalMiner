using System;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	internal class DistortionPassConstructor : IPassConstructor
	{
		public DistortionPassConstructor()
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

		private static Vector3[] GetFullScreenTriangleVertexPosition(float z)
		{
			// // Vector3[] GetFullScreenTriangleVertexPosition(Single)
			// Vector3__Array *HG::Rendering::Runtime::DistortionPassConstructor::GetFullScreenTriangleVertexPosition(
			//         float z,
			//         MethodInfo *method)
			// {
			//   __int64 v2; // r8
			//   __int64 v3; // r9
			//   __int64 v4; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Vector3__Array *v7; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   unsigned __int64 v10; // [rsp+20h] [rbp-48h] BYREF
			//   float v11; // [rsp+28h] [rbp-40h]
			// 
			//   if ( !byte_18D91953C )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Vector3);
			//     byte_18D91953C = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2585, 0LL) )
			//   {
			//     v4 = il2cpp_array_new_specific_0(TypeInfo::UnityEngine::Vector3, 3LL, v2, v3);
			//     v7 = (Vector3__Array *)v4;
			//     if ( v4 )
			//     {
			//       v11 = z;
			//       v10 = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			//       sub_180040FA0(v4, 0LL, &v10);
			//       v11 = z;
			//       v10 = _mm_unpacklo_ps((__m128)0x40000000u, (__m128)0LL).m128_u64[0];
			//       sub_180040FA0(v7, 1LL, &v10);
			//       v11 = z;
			//       v10 = _mm_unpacklo_ps((__m128)0LL, (__m128)0x40000000u).m128_u64[0];
			//       sub_180040FA0(v7, 2LL, &v10);
			//       return v7;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2585, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_368(Patch, z, 0LL);
			// }
			// 
			return null;
		}

		private void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::DistortionPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         DistortionPassConstructor *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2586, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2586, 0LL);
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
			// void HG::Rendering::Runtime::DistortionPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         DistortionPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2587, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2587, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		internal void ConstructPass(ref DistortionPassConstructor.PassInput input, ref DistortionPassConstructor.PassOutput output, HGRenderGraph renderGraph, HGCamera camera)
		{
			// // Void ConstructPass(DistortionPassConstructor+PassInput ByRef, DistortionPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
			// // Hidden C++ exception states: #wind=1 #try_helpers=1
			// void HG::Rendering::Runtime::DistortionPassConstructor::ConstructPass(
			//         DistortionPassConstructor *this,
			//         DistortionPassConstructor_PassInput *input,
			//         DistortionPassConstructor_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   ProfilingSampler *v10; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   HGGraphicsFeatureSwitch *distortionOpaque; // rdx
			//   HGGraphicsFeatureSwitch *distortionTransparent; // rcx
			//   MonitorData *monitor; // rdi
			//   bool fullScreenMaterialValid; // al
			//   __int64 v17; // rdx
			//   __int64 v18; // rcx
			//   HGRainRenderer *s_rainRenderer; // rax
			//   __int64 v20; // rdx
			//   __int64 v21; // rcx
			//   HGSnowRenderer *s_snowRenderer; // rax
			//   __int64 v23; // rdx
			//   __int64 v24; // rcx
			//   __int64 v25; // rdx
			//   __int64 v26; // rcx
			//   MonitorData *v27; // rcx
			//   int v28; // eax
			//   PerObjectData__Enum v29; // r12d
			//   __int64 v30; // rdx
			//   __int64 v31; // rcx
			//   PerObjectData__Enum v32; // r13d
			//   CullingResults cullingResults; // xmm8
			//   HGShaderPassNames__StaticFields *static_fields; // rbx
			//   float screenCullingRatio; // xmm7_4
			//   float screenCullingRatioDistance; // xmm6_4
			//   uint32_t screenCullingLayerMask; // edi
			//   RendererListDesc *v38; // rax
			//   RendererListHandle InvalidHandle; // rax
			//   RendererListHandle v40; // rdx
			//   RendererListHandle v41; // rcx
			//   CullingResults v42; // xmm8
			//   HGShaderPassNames__StaticFields *v43; // rbx
			//   float v44; // xmm7_4
			//   float v45; // xmm6_4
			//   uint32_t v46; // edi
			//   RendererListDesc *v47; // rax
			//   RendererListHandle v48; // rax
			//   __int64 v49; // rdx
			//   __int64 v50; // rcx
			//   uint32_t cullingViewHandle; // edi
			//   HGRenderGraphContext *m_RenderGraphContext; // rbx
			//   void *context; // rdx
			//   uint32_t v54; // ebx
			//   uint32_t RendererList; // r13d
			//   uint32_t v56; // r12d
			//   HGRenderGraphContext *v57; // rdi
			//   Object *v58; // rdi
			//   __int64 v59; // rdx
			//   __int64 v60; // rcx
			//   TextureHandle v61; // xmm0
			//   TextureDesc *TextureDescRef; // rax
			//   DistortionPassConstructor_PassOutput *Texture; // rax
			//   TextureHandle sceneColor; // xmm0
			//   __int64 v65; // rdx
			//   __int64 v66; // rcx
			//   __int64 v67; // rdx
			//   __int64 v68; // rcx
			//   __int128 v69; // xmm6
			//   __int128 v70; // xmm7
			//   Object__Class *v71; // xmm1_8
			//   Object *v72; // rax
			//   Object *v73; // rdi
			//   Object_1 *v74; // rcx
			//   int32_t InstanceID; // eax
			//   __int64 v76; // rdx
			//   __int64 v77; // rcx
			//   Object *v78; // rdi
			//   Camera *v79; // rcx
			//   int32_t cullingMask; // eax
			//   __int64 v81; // rdx
			//   __int64 v82; // rcx
			//   Object *v83; // rdx
			//   unsigned int v84; // edx
			//   unsigned __int64 v85; // r8
			//   signed __int64 v86; // rtt
			//   Object *v87; // rcx
			//   __int64 transparentAfterDistortionECSList; // rcx
			//   MonitorData *v89; // rax
			//   Camera *v90; // rcx
			//   __int64 v91; // rdx
			//   __int64 v92; // rcx
			//   float v93; // xmm0_4
			//   float v94; // xmm1_4
			//   float v95; // xmm1_4
			//   MonitorData *v96; // r8
			//   __int64 v97; // rdx
			//   __int64 v98; // rcx
			//   MonitorData *v99; // rcx
			//   __int64 v100; // rdx
			//   Mesh *fullScreenMesh; // rcx
			//   MonitorData *v102; // rdx
			//   __int64 v103; // rdx
			//   __int64 v104; // rcx
			//   MonitorData *v105; // rcx
			//   Mesh *v106; // rax
			//   __int64 v107; // rdx
			//   __int64 v108; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v110; // rdx
			//   __int64 v111; // rcx
			//   HGRenderKeyword__Enum globalKeywords; // [rsp+20h] [rbp-388h]
			//   bool m_defaultValue; // [rsp+70h] [rbp-338h]
			//   bool v114; // [rsp+71h] [rbp-337h]
			//   char v115; // [rsp+72h] [rbp-336h]
			//   Object *v116; // [rsp+78h] [rbp-330h] BYREF
			//   RendererListHandle v117; // [rsp+80h] [rbp-328h] BYREF
			//   void *outPtr; // [rsp+88h] [rbp-320h] BYREF
			//   TextureHandle v119; // [rsp+90h] [rbp-318h] BYREF
			//   __m128i si128; // [rsp+A0h] [rbp-308h] BYREF
			//   Nullable_1_UnityEngine_Rendering_RenderQueueRange_ inputa; // [rsp+B0h] [rbp-2F8h] BYREF
			//   HGRenderGraphBuilder v122; // [rsp+C0h] [rbp-2E8h] BYREF
			//   HGRenderGraphBuilder v123; // [rsp+E0h] [rbp-2C8h] BYREF
			//   _QWORD v124[4]; // [rsp+100h] [rbp-2A8h] BYREF
			//   Nullable_1_UnityEngine_Rendering_RenderStateBlock_ v125; // [rsp+120h] [rbp-288h] BYREF
			//   RendererListDesc desc; // [rsp+190h] [rbp-218h] BYREF
			//   RendererListDesc v127; // [rsp+270h] [rbp-138h] BYREF
			// 
			//   if ( !byte_18D91953D )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::DistortionPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::DistortionPassConstructor::DistortionPasssData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::DistortionPassConstructor::DistortionPasssData>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderPassNames);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&off_18D4FA3C0);
			//     byte_18D91953D = 1;
			//   }
			//   v116 = 0LL;
			//   outPtr = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2588, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2588, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v111, v110);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_946(
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
			//     v10 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//             (Int32Enum__Enum)9u,
			//             MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     if ( !renderGraph )
			//       sub_180B536AC(v12, v11);
			//     HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//       &v122,
			//       renderGraph,
			//       (String *)"Distortion Pass",
			//       &v116,
			//       v10,
			//       1,
			//       ProfilingHGPass__Enum_Distortion,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::DistortionPassConstructor::DistortionPasssData>);
			//     v123 = v122;
			//     v124[0] = 0LL;
			//     v124[1] = &v123;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//     distortionOpaque = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields.distortionOpaque;
			//     if ( !distortionOpaque )
			//       sub_1802DC2C8(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager, 0LL);
			//     m_defaultValue = distortionOpaque.fields.m_defaultValue;
			//     distortionTransparent = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields.distortionTransparent;
			//     if ( !distortionTransparent )
			//       sub_1802DC2C8(0LL, distortionOpaque);
			//     v114 = distortionTransparent.fields.m_defaultValue;
			//     if ( !v116 )
			//       sub_1802DC2C8(distortionTransparent, distortionOpaque);
			//     monitor = v116[6].monitor;
			//     fullScreenMaterialValid = HG::Rendering::Runtime::VFXPPScreenMaterial::get_fullScreenMaterialValid(0LL);
			//     if ( !monitor )
			//       sub_1802DC2C8(v18, v17);
			//     *((_BYTE *)monitor + 16) = fullScreenMaterialValid;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     s_rainRenderer = HG::Rendering::Runtime::HGEnvironmentManager::get_s_rainRenderer(0LL);
			//     if ( !s_rainRenderer )
			//       sub_1802DC2C8(v21, v20);
			//     if ( HG::Rendering::Runtime::HGRainRenderer::IsRainRenderingEnabled(s_rainRenderer, camera, 0LL) )
			//       goto LABEL_16;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     s_snowRenderer = HG::Rendering::Runtime::HGEnvironmentManager::get_s_snowRenderer(0LL);
			//     if ( !s_snowRenderer )
			//       sub_1802DC2C8(v24, v23);
			//     if ( HG::Rendering::Runtime::HGSnowRenderer::IsSnowRenderingEnabled(s_snowRenderer, camera, 0LL) )
			//     {
			// LABEL_16:
			//       v28 = 1;
			//     }
			//     else
			//     {
			//       if ( !v116 )
			//         sub_1802DC2C8(v26, v25);
			//       v27 = v116[6].monitor;
			//       if ( !v27 )
			//         sub_1802DC2C8(0LL, v25);
			//       v28 = *((unsigned __int8 *)v27 + 16);
			//     }
			//     v115 = v28 != 0;
			//     if ( this.fields.m_feedbackID )
			//       v115 = (v28 != 0) | UnityEngine::HyperGryph::HGGraphicsUtils::IsCompoundRendererListDrawable(
			//                             this.fields.m_feedbackID,
			//                             0LL);
			//     this.fields.m_feedbackID = UnityEngine::HyperGryph::HGGraphicsUtils::AllocateTempCompoundRendererListFromScript(
			//                                   &outPtr,
			//                                   0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//     v29 = input.bakedLightConfig | HG::Rendering::Runtime::HGRenderPipeline::GetPerObjectDataConfig(camera, 0LL);
			//     v32 = input.bakedLightConfig | HG::Rendering::Runtime::HGRenderPipeline::GetPerObjectDataConfig(camera, 0LL);
			//     if ( m_defaultValue )
			//     {
			//       cullingResults = input.cullingResults;
			//       if ( !camera )
			//         sub_1802DC2C8(v31, v30);
			//       v117 = (RendererListHandle)camera.fields.camera;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderPassNames);
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderPassNames.static_fields;
			//       screenCullingRatio = input.screenCullingRatio;
			//       screenCullingRatioDistance = input.screenCullingRatioDistance;
			//       screenCullingLayerMask = input.screenCullingLayerMask;
			//       v119.handle = 0LL;
			//       sub_1802F01E0(&v125, 0LL, 112LL);
			//       *(ResourceHandle *)&inputa.hasValue = v119.handle;
			//       inputa.value.m_UpperBound = v119.handle.m_Value;
			//       si128 = (__m128i)cullingResults;
			//       v38 = HG::Rendering::Runtime::HGRendererListUtils::CreateOpaqueRendererListDesc(
			//               &v127,
			//               (CullingResults *)&si128,
			//               *(Camera **)&v117,
			//               static_fields.s_DistortionName,
			//               screenCullingRatio,
			//               screenCullingRatioDistance,
			//               screenCullingLayerMask,
			//               v29,
			//               &inputa,
			//               &v125,
			//               0LL,
			//               0,
			//               outPtr,
			//               0LL);
			//       *(_OWORD *)&desc.sortingCriteria = *(_OWORD *)&v38.sortingCriteria;
			//       desc.stateBlock = v38.stateBlock;
			//       v38 = (RendererListDesc *)((char *)v38 + 128);
			//       *(_OWORD *)&desc.overrideMaterial = *(_OWORD *)&v38.sortingCriteria;
			//       *(_OWORD *)&desc.overrideMaterialPassIndex = *(_OWORD *)&v38.stateBlock.hasValue;
			//       *(_OWORD *)&desc.sortingLayerMin = *(_OWORD *)&v38.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//       *(_OWORD *)&desc.drawableFeedbackPtr = *(_OWORD *)&v38.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//       *(_OWORD *)&desc._cullingResult_k__BackingField.m_AllocationInfo = *(_OWORD *)&v38.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//       *(_OWORD *)&desc._passName_k__BackingField.m_Id = *(_OWORD *)&v38.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//       InvalidHandle = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererList(renderGraph, &desc, 0LL);
			//     }
			//     else
			//     {
			//       InvalidHandle = HG::Rendering::RenderGraphModule::RendererListHandle::get_InvalidHandle(0LL);
			//     }
			//     *(RendererListHandle *)&inputa.hasValue = InvalidHandle;
			//     if ( v114 )
			//     {
			//       v42 = input.cullingResults;
			//       if ( !camera )
			//         sub_1802DC2C8(v41, v40);
			//       v117 = (RendererListHandle)camera.fields.camera;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderPassNames);
			//       v43 = TypeInfo::HG::Rendering::Runtime::HGShaderPassNames.static_fields;
			//       v44 = input.screenCullingRatio;
			//       v45 = input.screenCullingRatioDistance;
			//       v46 = input.screenCullingLayerMask;
			//       v119.handle = 0LL;
			//       sub_1802F01E0(&v125, 0LL, 112LL);
			//       si128.m128i_i64[0] = (__int64)v119.handle;
			//       si128.m128i_i32[2] = v119.handle.m_Value;
			//       v119 = (TextureHandle)v42;
			//       v47 = HG::Rendering::Runtime::HGRendererListUtils::CreateTransparentRendererListDesc(
			//               &v127,
			//               (CullingResults *)&v119,
			//               *(Camera **)&v117,
			//               v43.s_DistortionName,
			//               v44,
			//               v45,
			//               v46,
			//               v32,
			//               (Nullable_1_UnityEngine_Rendering_RenderQueueRange_ *)&si128,
			//               &v125,
			//               0LL,
			//               0,
			//               outPtr,
			//               0LL);
			//       *(_OWORD *)&desc.sortingCriteria = *(_OWORD *)&v47.sortingCriteria;
			//       desc.stateBlock = v47.stateBlock;
			//       v47 = (RendererListDesc *)((char *)v47 + 128);
			//       *(_OWORD *)&desc.overrideMaterial = *(_OWORD *)&v47.sortingCriteria;
			//       *(_OWORD *)&desc.overrideMaterialPassIndex = *(_OWORD *)&v47.stateBlock.hasValue;
			//       *(_OWORD *)&desc.sortingLayerMin = *(_OWORD *)&v47.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//       *(_OWORD *)&desc.drawableFeedbackPtr = *(_OWORD *)&v47.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//       *(_OWORD *)&desc._cullingResult_k__BackingField.m_AllocationInfo = *(_OWORD *)&v47.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//       *(_OWORD *)&desc._passName_k__BackingField.m_Id = *(_OWORD *)&v47.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//       v48 = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererList(renderGraph, &desc, 0LL);
			//     }
			//     else
			//     {
			//       v48 = HG::Rendering::RenderGraphModule::RendererListHandle::get_InvalidHandle(0LL);
			//     }
			//     v117 = v48;
			//     HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::UseRendererList(&v123, (RendererListHandle *)&inputa, 0LL);
			//     HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::UseRendererList(&v123, &v117, 0LL);
			//     if ( m_defaultValue )
			//     {
			//       if ( !camera )
			//         sub_1802DC2C8(v50, v49);
			//       cullingViewHandle = camera.fields.cullingViewHandle;
			//       m_RenderGraphContext = renderGraph.fields.m_RenderGraphContext;
			//       if ( !m_RenderGraphContext )
			//         sub_1802DC2C8(v50, v49);
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//       context = m_RenderGraphContext.fields.renderContext.m_Ptr;
			//       v54 = -1;
			//       LOWORD(globalKeywords) = 0;
			//       RendererList = UnityEngine::HyperGryph::HGMeshRender::CreateRendererList(
			//                        cullingViewHandle,
			//                        HGRenderFlags__Enum_ShadowOnly|HGRenderFlags__Enum_Opaque,
			//                        HGRenderFlags__Enum_Opaque,
			//                        HGShaderLightMode__Enum_Distortion,
			//                        globalKeywords,
			//                        context,
			//                        outPtr,
			//                        0,
			//                        0,
			//                        0xFFFFFFFF,
			//                        0,
			//                        0,
			//                        0LL);
			//     }
			//     else
			//     {
			//       v54 = -1;
			//       RendererList = -1;
			//     }
			//     if ( v114 )
			//     {
			//       if ( !camera )
			//         sub_1802DC2C8(v50, v49);
			//       v56 = camera.fields.cullingViewHandle;
			//       v57 = renderGraph.fields.m_RenderGraphContext;
			//       if ( !v57 )
			//         sub_1802DC2C8(v50, v49);
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//       LOWORD(globalKeywords) = 0;
			//       v54 = UnityEngine::HyperGryph::HGMeshRender::CreateRendererList(
			//               v56,
			//               HGRenderFlags__Enum_ShadowOnly|HGRenderFlags__Enum_Transparent,
			//               HGRenderFlags__Enum_Transparent,
			//               HGShaderLightMode__Enum_Distortion,
			//               globalKeywords,
			//               v57.fields.renderContext.m_Ptr,
			//               outPtr,
			//               0,
			//               0,
			//               0xFFFFFFFF,
			//               0,
			//               0,
			//               0LL);
			//     }
			//     if ( v115 )
			//     {
			//       v58 = v116;
			//       v61 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                (TextureHandle *)&si128,
			//                &v123,
			//                &input.sceneColor,
			//                0LL);
			//       if ( !v58 )
			//         sub_1802DC2C8(v60, v59);
			//       *(TextureHandle *)&v58[3].monitor = v61;
			//       TextureDescRef = HG::Rendering::RenderGraphModule::HGRenderGraph::GetTextureDescRef(
			//                          renderGraph,
			//                          &input.sceneColor,
			//                          0LL);
			//       Texture = (DistortionPassConstructor_PassOutput *)HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                                                           (TextureHandle *)&si128,
			//                                                           renderGraph,
			//                                                           TextureDescRef,
			//                                                           0LL);
			//       sceneColor = Texture.sceneColor;
			//       *output = *Texture;
			//       v119 = sceneColor;
			//       si128 = _mm_load_si128((const __m128i *)&xmmword_18A3576D0);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//         (TextureHandle *)&v122,
			//         &v123,
			//         &v119,
			//         0,
			//         RenderBufferLoadAction__Enum_DontCare,
			//         RenderBufferStoreAction__Enum_Store,
			//         (Color *)&si128,
			//         0,
			//         0LL);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
			//         (TextureHandle *)&v122,
			//         &v123,
			//         &input.sceneDepth,
			//         DepthAccess__Enum_ReadWrite,
			//         0,
			//         0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//       if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&input.sceneMV, 0LL) )
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//           (TextureHandle *)&v122,
			//           &v123,
			//           &input.sceneMV,
			//           1,
			//           0,
			//           0LL);
			//       if ( !camera )
			//         sub_1802DC2C8(v66, v65);
			//       *(BitArray128 *)&v122.m_RenderPass = camera.fields._frameSettings_k__BackingField.bitDatas;
			//       v122.m_RenderGraph = *(HGRenderGraph **)&camera.fields._frameSettings_k__BackingField.materialQuality;
			//       if ( HG::Rendering::Runtime::FrameSettings::IsEnabled(
			//              (FrameSettings *)&v122,
			//              FrameSettingsField__Enum_ShadowMaps,
			//              0LL)
			//         || (*(BitArray128 *)&v122.m_RenderPass = camera.fields._frameSettings_k__BackingField.bitDatas,
			//             v122.m_RenderGraph = *(HGRenderGraph **)&camera.fields._frameSettings_k__BackingField.materialQuality,
			//             HG::Rendering::Runtime::FrameSettings::IsEnabled(
			//               (FrameSettings *)&v122,
			//               FrameSettingsField__Enum_CharacterShadowMaps,
			//               0LL)) )
			//       {
			//         v69 = *(_OWORD *)&v123.m_RenderPass;
			//         v70 = *(_OWORD *)&v123.m_RenderGraph;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//         *(_OWORD *)&v122.m_RenderPass = v69;
			//         *(_OWORD *)&v122.m_RenderGraph = v70;
			//         HG::Rendering::Runtime::HGShadowManager::ReadShadowResult(
			//           (ShadowResult *)&v125,
			//           &input.shadowResult,
			//           &v122,
			//           0LL);
			//       }
			//       v71 = *(Object__Class **)&camera.fields._frameSettings_k__BackingField.materialQuality;
			//       v72 = v116;
			//       if ( !v116 )
			//         sub_1802DC2C8(v68, v67);
			//       v116[1] = (Object)camera.fields._frameSettings_k__BackingField.bitDatas;
			//       v72[2].klass = v71;
			//       v73 = v116;
			//       v74 = (Object_1 *)camera.fields.camera;
			//       if ( !v74 )
			//         sub_1802DC2C8(0LL, v67);
			//       InstanceID = UnityEngine::Object::GetInstanceID(v74, 0LL);
			//       if ( !v73 )
			//         sub_1802DC2C8(v77, v76);
			//       LODWORD(v73[3].klass) = InstanceID;
			//       v78 = v116;
			//       v79 = camera.fields.camera;
			//       if ( !v79 )
			//         sub_1802DC2C8(0LL, v76);
			//       cullingMask = UnityEngine::Camera::get_cullingMask(v79, 0LL);
			//       if ( !v78 )
			//         sub_1802DC2C8(v82, v81);
			//       HIDWORD(v78[3].klass) = cullingMask;
			//       v83 = v116;
			//       if ( !v116 )
			//         sub_1802DC2C8(v82, 0LL);
			//       v116[2].monitor = (MonitorData *)camera;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v84 = ((unsigned __int64)&v83[2].monitor >> 12) & 0x1FFFFF;
			//         v85 = (unsigned __int64)v84 >> 6;
			//         v83 = (Object *)(v84 & 0x3F);
			//         _m_prefetchw(&qword_18D6870D0[v85]);
			//         do
			//           v86 = qword_18D6870D0[v85];
			//         while ( v86 != _InterlockedCompareExchange64(&qword_18D6870D0[v85], v86 | (1LL << (char)v83), v86) );
			//       }
			//       if ( !v116 )
			//         sub_1802DC2C8(0LL, v83);
			//       v116[4].monitor = *(MonitorData **)&inputa.hasValue;
			//       v87 = v116;
			//       if ( !v116 )
			//         sub_1802DC2C8(0LL, v83);
			//       v116[5].klass = (Object__Class *)v117;
			//       if ( !v116 )
			//         sub_1802DC2C8(v87, v83);
			//       LODWORD(v116[5].monitor) = RendererList;
			//       if ( !v116 )
			//         sub_1802DC2C8(v87, v83);
			//       HIDWORD(v116[5].monitor) = v54;
			//       transparentAfterDistortionECSList = input.transparentAfterDistortionECSList;
			//       if ( !v116 )
			//         sub_1802DC2C8(transparentAfterDistortionECSList, v83);
			//       LODWORD(v116[6].klass) = transparentAfterDistortionECSList;
			//       if ( !v116 )
			//         sub_1802DC2C8(transparentAfterDistortionECSList, v83);
			//       v89 = v116[6].monitor;
			//       if ( !v89 )
			//         sub_1802DC2C8(transparentAfterDistortionECSList, v83);
			//       if ( *((_BYTE *)v89 + 16) )
			//       {
			//         v90 = camera.fields.camera;
			//         if ( !v90 )
			//           sub_1802DC2C8(0LL, v83);
			//         v93 = UnityEngine::Camera::get_nearClipPlane(v90, 0LL);
			//         v94 = 0.1;
			//         if ( v93 >= 0.1 )
			//           v94 = v93;
			//         v95 = v94 + 0.001;
			//         if ( !v116 )
			//           sub_1802DC2C8(v92, v91);
			//         v96 = v116[6].monitor;
			//         if ( !v96 )
			//           sub_1802DC2C8(v92, v91);
			//         HG::Rendering::Runtime::HGVFXManager::CalculateScreenMaterialMeshVertex(
			//           camera.fields.camera,
			//           v95,
			//           *((Vector3__Array **)v96 + 4),
			//           0LL);
			//         if ( !v116 )
			//           sub_1802DC2C8(v98, v97);
			//         v99 = v116[6].monitor;
			//         if ( !v99 )
			//           sub_1802DC2C8(0LL, v97);
			//         fullScreenMesh = HG::Rendering::Runtime::FullScreenVFXData::get_fullScreenMesh((FullScreenVFXData *)v99, 0LL);
			//         if ( !v116 )
			//           sub_1802DC2C8(fullScreenMesh, v100);
			//         v102 = v116[6].monitor;
			//         if ( !v102 )
			//           sub_1802DC2C8(fullScreenMesh, 0LL);
			//         if ( !fullScreenMesh )
			//           sub_1802DC2C8(0LL, v102);
			//         UnityEngine::Mesh::set_vertices(fullScreenMesh, *((Vector3__Array **)v102 + 4), 0LL);
			//         if ( !v116 )
			//           sub_1802DC2C8(v104, v103);
			//         v105 = v116[6].monitor;
			//         if ( !v105 )
			//           sub_1802DC2C8(0LL, v103);
			//         v106 = HG::Rendering::Runtime::FullScreenVFXData::get_fullScreenMesh((FullScreenVFXData *)v105, 0LL);
			//         if ( !v106 )
			//           sub_1802DC2C8(v108, v107);
			//         UnityEngine::Mesh::UploadMeshData(v106, 0, 0LL);
			//       }
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowRendererListCulling(&v123, 0, 0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::DistortionPassConstructor);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//         &v123,
			//         (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::DistortionPassConstructor.static_fields.s_distortionObjectsRenderFunc,
			//         0LL,
			//         0,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::DistortionPassConstructor::DistortionPasssData>);
			//       sub_180222690(v124);
			//     }
			//     else
			//     {
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v123, 0, 0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::DistortionPassConstructor);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//         &v123,
			//         (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::DistortionPassConstructor.static_fields.s_distortionUselessRenderFunc,
			//         0LL,
			//         0,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::DistortionPassConstructor::DistortionPasssData>);
			//       *output = (DistortionPassConstructor_PassOutput)input.sceneColor;
			//       sub_180222690(v124);
			//     }
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::DistortionPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         DistortionPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2590, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2590, 0LL);
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
			// void HG::Rendering::Runtime::DistortionPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
			//         DistortionPassConstructor *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2591, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2591, 0LL);
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

		private uint m_feedbackID;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly RenderFunc<DistortionPassConstructor.DistortionPasssData> s_distortionUselessRenderFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		private static readonly RenderFunc<DistortionPassConstructor.DistortionPasssData> s_distortionObjectsRenderFunc;

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 152)]
		internal struct PassInput
		{
			internal TextureHandle sceneColor;

			internal TextureHandle sceneDepth;

			internal TextureHandle sceneMV;

			internal ShadowResult shadowResult;

			internal CullingResults cullingResults;

			internal PerObjectData bakedLightConfig;

			internal float screenCullingRatio;

			internal float screenCullingRatioDistance;

			internal uint screenCullingLayerMask;

			internal uint transparentAfterDistortionECSList;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 16)]
		internal struct PassOutput
		{
			internal TextureHandle sceneColor;
		}

		private class DistortionPasssData
		{
			public DistortionPasssData()
			{
				// // DistortionPassConstructor+DistortionPasssData()
				// void HG::Rendering::Runtime::DistortionPassConstructor::DistortionPasssData::DistortionPasssData(
				//         DistortionPassConstructor_DistortionPasssData *this,
				//         MethodInfo *method)
				// {
				//   FullScreenVFXData *v3; // rax
				//   __int64 v4; // rdx
				//   __int64 v5; // rcx
				//   FullScreenVFXData *v6; // rbx
				//   OneofDescriptorProto *v7; // rdx
				//   FileDescriptor *v8; // r8
				//   MessageDescriptor *v9; // r9
				//   String__Array *v10; // [rsp+50h] [rbp+28h]
				//   String *v11; // [rsp+58h] [rbp+30h]
				//   MethodInfo *v12; // [rsp+60h] [rbp+38h]
				// 
				//   if ( !byte_18D91953E )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::FullScreenVFXData);
				//     byte_18D91953E = 1;
				//   }
				//   v3 = (FullScreenVFXData *)sub_180004920(TypeInfo::HG::Rendering::Runtime::FullScreenVFXData);
				//   v6 = v3;
				//   if ( !v3 )
				//     sub_180B536AC(v5, v4);
				//   HG::Rendering::Runtime::FullScreenVFXData::FullScreenVFXData(v3, 0LL);
				//   this.fields.fullScreenVFXData = v6;
				//   sub_1800054D0((OneofDescriptor *)&this.fields.fullScreenVFXData, v7, v8, v9, v10, v11, v12);
				// }
				// 
			}

			internal FrameSettings frameSettings;

			internal HGCamera camera;

			internal int cameraGuid;

			internal int cameraCullingMask;

			internal TextureHandle sceneColorToSample;

			internal RendererListHandle distortionOpaqueRendererList;

			internal RendererListHandle distortionTransparentRendererList;

			internal uint distortionOpaqueECSList;

			internal uint distortionTransparentECSList;

			internal uint transparentAfterDistortionECSList;

			internal FullScreenVFXData fullScreenVFXData;
		}
	}
}
