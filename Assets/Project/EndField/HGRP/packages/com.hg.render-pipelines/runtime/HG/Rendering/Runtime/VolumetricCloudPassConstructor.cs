using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;

namespace HG.Rendering.Runtime
{
	public class VolumetricCloudPassConstructor : IPassConstructor
	{
		internal VolumetricCloudPassConstructor(HGRenderPipelineMaterialCollector materialCollector, HGRenderPathBase.HGRenderPathResources resources)
		{
			// // VolumetricCloudPassConstructor(HGRenderPipelineMaterialCollector, HGRenderPathBase+HGRenderPathResources)
			// void HG::Rendering::Runtime::VolumetricCloudPassConstructor::VolumetricCloudPassConstructor(
			//         VolumetricCloudPassConstructor *this,
			//         HGRenderPipelineMaterialCollector *materialCollector,
			//         HGRenderPathBase_HGRenderPathResources *resources,
			//         MethodInfo *method)
			// {
			//   LowLevelList_1_System_Object_ *v7; // rax
			//   HGRenderPathBase_HGRenderPathResources *v8; // rdx
			//   __int64 v9; // rcx
			//   List_1_UnityEngine_HyperGryphEngineCode_HGVolumetricRenderItem_ *v10; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v11; // rdx
			//   PassConstructorID__Enum__Array *v12; // r8
			//   HGCamera *v13; // r9
			//   PassConstructorID__Enum__Array *v14; // r8
			//   HGRenderPipelineRuntimeResources *defaultResources; // r9
			//   HGRenderPipelineRuntimeResources_MaterialResources *materials; // rax
			//   Material *m_volumetricMaterial; // rbp
			//   VolumetricRenderer *v18; // rax
			//   VolumetricRenderer *v19; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v20; // rdx
			//   PassConstructorID__Enum__Array *v21; // r8
			//   HGCamera *v22; // r9
			//   HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
			//   HGRenderPathBase_HGRenderPathResources *v24; // rdx
			//   PassConstructorID__Enum__Array *v25; // r8
			//   HGCamera *v26; // r9
			//   MethodInfo *v27; // [rsp+20h] [rbp-18h] BYREF
			//   MethodInfo *v28; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v29; // [rsp+60h] [rbp+28h]
			//   MethodInfo *v30; // [rsp+68h] [rbp+30h]
			// 
			//   if ( !byte_18D8EDAD2 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::HyperGryphEngineCode::HGVolumetricRenderItem>::List);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<UnityEngine::HyperGryphEngineCode::HGVolumetricRenderItem>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricRenderer);
			//     byte_18D8EDAD2 = 1;
			//   }
			//   if ( !TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle, materialCollector);
			//   this.fields.m_currentSceneDepth = *(TextureHandle *)sub_182E7CCD0(&v27);
			//   this.fields.m_historySceneDepth = *(TextureHandle *)sub_182E7CCD0(&v27);
			//   v7 = (LowLevelList_1_System_Object_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<UnityEngine::HyperGryphEngineCode::HGVolumetricRenderItem>);
			//   v10 = (List_1_UnityEngine_HyperGryphEngineCode_HGVolumetricRenderItem_ *)v7;
			//   if ( !v7 )
			//     goto LABEL_13;
			//   System::Collections::Generic::LowLevelList<System::Object>::LowLevelList(
			//     v7,
			//     MethodInfo::System::Collections::Generic::List<UnityEngine::HyperGryphEngineCode::HGVolumetricRenderItem>::List);
			//   this.fields.m_renderItems = v10;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.m_renderItems, v11, v12, v13, v27, v28);
			//   defaultResources = resources.defaultResources;
			//   if ( !resources.defaultResources )
			//     goto LABEL_13;
			//   materials = defaultResources.fields.materials;
			//   if ( !materials )
			//     goto LABEL_13;
			//   this.fields.m_volumetricMaterial = materials.fields.volumetricMaterial;
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&this.fields.m_volumetricMaterial,
			//     v8,
			//     v14,
			//     (HGCamera *)defaultResources,
			//     v27,
			//     v28);
			//   m_volumetricMaterial = this.fields.m_volumetricMaterial;
			//   v18 = (VolumetricRenderer *)sub_180004920(TypeInfo::HG::Rendering::Runtime::VolumetricRenderer);
			//   v19 = v18;
			//   if ( !v18
			//     || (HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderer(v18, m_volumetricMaterial, 0LL),
			//         this.fields.m_renderer = v19,
			//         sub_1800054D0((HGRenderPathScene *)&this.fields.m_renderer, v20, v21, v22, v27, v28),
			//         !resources.defaultResources)
			//     || (shaders = resources.defaultResources.fields.shaders) == 0LL
			//     || !materialCollector )
			//   {
			// LABEL_13:
			//     sub_180B536AC(v9, v8);
			//   }
			//   this.fields.m_volumetricComposeMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
			//                                                materialCollector,
			//                                                shaders.fields.volumetricComposePS,
			//                                                0,
			//                                                0LL);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.m_volumetricComposeMaterial, v24, v25, v26, v29, v30);
			// }
			// 
		}

		internal bool ShouldRenderVolumetricCloud(ref VolumetricCloudPassConstructor.PassInput input)
		{
			// // Boolean ShouldRenderVolumetricCloud(VolumetricCloudPassConstructor+PassInput ByRef)
			// bool HG::Rendering::Runtime::VolumetricCloudPassConstructor::ShouldRenderVolumetricCloud(
			//         VolumetricCloudPassConstructor *this,
			//         VolumetricCloudPassConstructor_PassInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			// 
			//   if ( !byte_18D9195E9 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>::get_Count);
			//     byte_18D9195E9 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2868, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2868, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1042(Patch, (Object *)this, input, 0LL);
			//   }
			//   else
			//   {
			//     return input.volumetricRenderObjects && input.volumetricRenderObjects.fields._size != 0;
			//   }
			// }
			// 
			return default(bool);
		}

		internal void ConstructPass(ref VolumetricCloudPassConstructor.PassInput input, ref VolumetricCloudPassConstructor.PassOutput output, HGRenderGraph renderGraph, HGCamera camera)
		{
			// // Void ConstructPass(VolumetricCloudPassConstructor+PassInput ByRef, VolumetricCloudPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::VolumetricCloudPassConstructor::ConstructPass(
			//         VolumetricCloudPassConstructor *this,
			//         VolumetricCloudPassConstructor_PassInput *input,
			//         VolumetricCloudPassConstructor_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   bool ShouldRenderVolumetricCloud; // al
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   HGVolumetricCloudSettingParameters *volumetricParameters; // rbx
			//   ProfilingSampler *v14; // rax
			//   __int64 v15; // rdx
			//   __int64 v16; // rcx
			//   signed __int64 v17; // rcx
			//   Object *v18; // rdx
			//   unsigned __int64 v19; // rdx
			//   unsigned __int64 v20; // r8
			//   signed __int64 v21; // rtt
			//   Object *v22; // r14
			//   __int64 v23; // rdx
			//   __int64 v24; // rcx
			//   TextureHandle v25; // xmm0
			//   __int64 v26; // rdx
			//   __int64 v27; // rcx
			//   Object *v28; // r14
			//   __int64 v29; // rdx
			//   __int64 v30; // rcx
			//   TextureHandle v31; // xmm0
			//   Object *v32; // r14
			//   __int64 v33; // rdx
			//   __int64 v34; // rcx
			//   TextureHandle v35; // xmm0
			//   Object *v36; // r14
			//   __int64 v37; // rdx
			//   __int64 v38; // rcx
			//   TextureHandle v39; // xmm0
			//   __int64 v40; // rcx
			//   Object *v41; // rdx
			//   int v42; // eax
			//   unsigned __int64 v43; // rdx
			//   unsigned __int64 v44; // r8
			//   char v45; // dl
			//   signed __int64 v46; // rtt
			//   Object *v47; // rdx
			//   Object__Class *volumetricRenderObjects; // rcx
			//   unsigned __int64 v49; // rdx
			//   unsigned __int64 v50; // r8
			//   char v51; // dl
			//   signed __int64 v52; // rtt
			//   Object *v53; // rdx
			//   Object__Class *m_volumetricComposeMaterial; // rcx
			//   unsigned __int64 v55; // rdx
			//   unsigned __int64 v56; // r8
			//   char v57; // dl
			//   signed __int64 v58; // rtt
			//   Object *v59; // rdx
			//   MonitorData *v60; // rcx
			//   unsigned __int64 v61; // rdx
			//   unsigned __int64 v62; // r8
			//   char v63; // dl
			//   signed __int64 v64; // rtt
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v66; // rdx
			//   __int64 v67; // rcx
			//   Object *v68; // [rsp+50h] [rbp-88h] BYREF
			//   __m128i si128; // [rsp+60h] [rbp-78h] BYREF
			//   _QWORD v70[2]; // [rsp+70h] [rbp-68h] BYREF
			//   HGRenderGraphBuilder v71; // [rsp+80h] [rbp-58h] BYREF
			//   HGRenderGraphBuilder v72; // [rsp+A0h] [rbp-38h] BYREF
			//   Il2CppExceptionWrapper *v73; // [rsp+C0h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D9195EA )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::VolumetricCloudPassConstructor::VolumetricCloudPassPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::VolumetricCloudPassConstructor::VolumetricCloudPassPassData>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricCloudPassConstructor);
			//     sub_18003C530(&off_18D5031C8);
			//     byte_18D9195EA = 1;
			//   }
			//   v68 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2869, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2869, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v67, v66);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1043(
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
			//     ShouldRenderVolumetricCloud = HG::Rendering::Runtime::VolumetricCloudPassConstructor::ShouldRenderVolumetricCloud(
			//                                     this,
			//                                     input,
			//                                     0LL);
			//     this.fields.m_bHasCloud = ShouldRenderVolumetricCloud;
			//     if ( ShouldRenderVolumetricCloud )
			//     {
			//       volumetricParameters = input.volumetricParameters;
			//       if ( !volumetricParameters )
			//         sub_180B536AC(v12, v11);
			//       this.fields.m_bEnableDownRes = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                                         volumetricParameters.fields.enableDownRes,
			//                                         MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//       this.fields.m_currentSceneDepth = input.sceneDepthCopied;
			//       v14 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//               (Int32Enum__Enum)0x30u,
			//               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//       if ( !renderGraph )
			//         sub_180B536AC(v16, v15);
			//       HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//         &v72,
			//         renderGraph,
			//         (String *)"Volumetric Cloud",
			//         &v68,
			//         v14,
			//         1,
			//         ProfilingHGPass__Enum_None,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::VolumetricCloudPassConstructor::VolumetricCloudPassPassData>);
			//       v71 = v72;
			//       v70[0] = 0LL;
			//       v70[1] = &v71;
			//       try
			//       {
			//         v18 = v68;
			//         if ( !v68 )
			//           sub_1802DC2C8(v17, 0LL);
			//         v68[1].klass = (Object__Class *)camera;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v19 = ((unsigned __int64)&v18[1] >> 12) & 0x1FFFFF;
			//           v20 = v19 >> 6;
			//           v18 = (Object *)(v19 & 0x3F);
			//           _m_prefetchw(&qword_18D6405E0[v20 + 36190]);
			//           do
			//           {
			//             v17 = qword_18D6405E0[v20 + 36190] | (1LL << (char)v18);
			//             v21 = qword_18D6405E0[v20 + 36190];
			//           }
			//           while ( v21 != _InterlockedCompareExchange64(&qword_18D6405E0[v20 + 36190], v17, v21) );
			//         }
			//         if ( !v68 )
			//           sub_1802DC2C8(v17, v18);
			//         *(TextureHandle *)((char *)v68 + 56) = input.sceneDepthCopied;
			//         sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//         if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&input.sceneDepthCopied, 0LL) )
			//         {
			//           v22 = v68;
			//           v25 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                    (TextureHandle *)&si128,
			//                    &v71,
			//                    &input.sceneDepthCopied,
			//                    0LL);
			//           if ( !v22 )
			//             sub_1802DC2C8(v24, v23);
			//           *(TextureHandle *)&v22[3].monitor = v25;
			//         }
			//         sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//         if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this.fields.m_historySceneDepth, 0LL) )
			//         {
			//           v28 = v68;
			//           v31 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                    (TextureHandle *)&si128,
			//                    &v71,
			//                    &this.fields.m_historySceneDepth,
			//                    0LL);
			//           if ( !v28 )
			//             sub_1802DC2C8(v30, v29);
			//           *(TextureHandle *)&v28[4].monitor = v31;
			//         }
			//         else
			//         {
			//           if ( !v68 )
			//             sub_1802DC2C8(v27, v26);
			//           *(Object *)((char *)v68 + 72) = *(Object *)((char *)v68 + 56);
			//         }
			//         v32 = v68;
			//         v35 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
			//                  (TextureHandle *)&si128,
			//                  &v71,
			//                  &input.sceneColor,
			//                  0LL);
			//         if ( !v32 )
			//           sub_1802DC2C8(v34, v33);
			//         *(TextureHandle *)&v32[1].monitor = v35;
			//         v36 = v68;
			//         v39 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
			//                  (TextureHandle *)&si128,
			//                  &v71,
			//                  &input.sceneDepth,
			//                  0LL);
			//         if ( !v36 )
			//           sub_1802DC2C8(v38, v37);
			//         *(TextureHandle *)&v36[2].monitor = v39;
			//         si128 = _mm_load_si128((const __m128i *)&xmmword_18A3576D0);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//           (TextureHandle *)&v72,
			//           &v71,
			//           &input.sceneColor,
			//           0,
			//           RenderBufferLoadAction__Enum_DontCare,
			//           RenderBufferStoreAction__Enum_Store,
			//           (Color *)&si128,
			//           0,
			//           0LL);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
			//           (TextureHandle *)&v72,
			//           &v71,
			//           &input.sceneDepth,
			//           DepthAccess__Enum_Read,
			//           0,
			//           0LL);
			//         v41 = v68;
			//         if ( !v68 )
			//           sub_1802DC2C8(v40, 0LL);
			//         v68[5].monitor = (MonitorData *)this.fields.m_renderer;
			//         v42 = dword_18D8E43F8;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v43 = ((unsigned __int64)&v41[5].monitor >> 12) & 0x1FFFFF;
			//           v44 = v43 >> 6;
			//           v45 = v43 & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v44 + 36190]);
			//           do
			//             v46 = qword_18D6405E0[v44 + 36190];
			//           while ( v46 != _InterlockedCompareExchange64(&qword_18D6405E0[v44 + 36190], v46 | (1LL << v45), v46) );
			//           v42 = dword_18D8E43F8;
			//         }
			//         v47 = v68;
			//         volumetricRenderObjects = (Object__Class *)input.volumetricRenderObjects;
			//         if ( !v68 )
			//           sub_1802DC2C8(volumetricRenderObjects, 0LL);
			//         v68[7].klass = volumetricRenderObjects;
			//         if ( v42 )
			//         {
			//           v49 = ((unsigned __int64)&v47[7] >> 12) & 0x1FFFFF;
			//           v50 = v49 >> 6;
			//           v51 = v49 & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v50 + 36190]);
			//           do
			//             v52 = qword_18D6405E0[v50 + 36190];
			//           while ( v52 != _InterlockedCompareExchange64(&qword_18D6405E0[v50 + 36190], v52 | (1LL << v51), v52) );
			//           v42 = dword_18D8E43F8;
			//         }
			//         v53 = v68;
			//         m_volumetricComposeMaterial = (Object__Class *)this.fields.m_volumetricComposeMaterial;
			//         if ( !v68 )
			//           sub_1802DC2C8(m_volumetricComposeMaterial, 0LL);
			//         v68[6].klass = m_volumetricComposeMaterial;
			//         if ( v42 )
			//         {
			//           v55 = ((unsigned __int64)&v53[6] >> 12) & 0x1FFFFF;
			//           v56 = v55 >> 6;
			//           v57 = v55 & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v56 + 36190]);
			//           do
			//             v58 = qword_18D6405E0[v56 + 36190];
			//           while ( v58 != _InterlockedCompareExchange64(&qword_18D6405E0[v56 + 36190], v58 | (1LL << v57), v58) );
			//           v42 = dword_18D8E43F8;
			//         }
			//         v59 = v68;
			//         v60 = (MonitorData *)input.volumetricParameters;
			//         if ( !v68 )
			//           sub_1802DC2C8(v60, 0LL);
			//         v68[6].monitor = v60;
			//         if ( v42 )
			//         {
			//           v61 = ((unsigned __int64)&v59[6].monitor >> 12) & 0x1FFFFF;
			//           v62 = v61 >> 6;
			//           v63 = v61 & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v62 + 36190]);
			//           do
			//             v64 = qword_18D6405E0[v62 + 36190];
			//           while ( v64 != _InterlockedCompareExchange64(&qword_18D6405E0[v62 + 36190], v64 | (1LL << v63), v64) );
			//         }
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricCloudPassConstructor);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//           &v71,
			//           (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::VolumetricCloudPassConstructor.static_fields.s_volumetricCloudFunc,
			//           0LL,
			//           0,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::VolumetricCloudPassConstructor::VolumetricCloudPassPassData>);
			//       }
			//       catch ( Il2CppExceptionWrapper *v73 )
			//       {
			//         v70[0] = v73.ex;
			//       }
			//       sub_180222690(v70);
			//     }
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::VolumetricCloudPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         VolumetricCloudPassConstructor *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   Material *m_volumetricMaterial; // rsi
			//   Material *v6; // rcx
			//   VolumetricShaderIDs__StaticFields *static_fields; // rdx
			//   float FloatImpl; // xmm6_4
			//   float v9; // xmm0_4
			//   int v10; // xmm2_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector4 v12; // [rsp+20h] [rbp-28h]
			// 
			//   if ( !byte_18D9195EB )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//     byte_18D9195EB = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2870, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2870, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_340(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
			//       return;
			//     }
			// LABEL_11:
			//     sub_180B536AC(v6, static_fields);
			//   }
			//   m_volumetricMaterial = this.fields.m_volumetricMaterial;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//   static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//   if ( !m_volumetricMaterial )
			//     goto LABEL_11;
			//   FloatImpl = UnityEngine::Material::GetFloatImpl(m_volumetricMaterial, static_fields._ComposeDepthFadeOffset, 0LL);
			//   v6 = this.fields.m_volumetricMaterial;
			//   static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//   if ( !v6 )
			//     goto LABEL_11;
			//   v9 = UnityEngine::Material::GetFloatImpl(v6, static_fields._ComposeDepthFadeDistance, 0LL);
			//   if ( this.fields.m_bHasCloud )
			//     v10 = 1065353216;
			//   else
			//     v10 = 0;
			//   *(_QWORD *)&v12.x = __PAIR64__(LODWORD(v9), v10);
			//   v12.z = 1.0 / v9;
			//   v12.w = FloatImpl;
			//   shaderVariablesGlobal[1]._ProjectionParams = v12;
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::VolumetricCloudPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         VolumetricCloudPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2871, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2871, 0LL);
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
			// void HG::Rendering::Runtime::VolumetricCloudPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         VolumetricCloudPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rcx
			//   HGRenderGraph *renderGraph; // rdx
			//   TextureHandle *v7; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   TextureHandle v9; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D9195EC )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&off_18D502AF8);
			//     byte_18D9195EC = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2872, 0LL) )
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     if ( !HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this.fields.m_currentSceneDepth, 0LL)
			//       || this.fields.m_bEnableDownRes
			//       || !this.fields.m_bHasCloud )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//       v7 = (TextureHandle *)sub_182E7CCD0(&v9);
			//       goto LABEL_9;
			//     }
			//     renderGraph = input.renderGraph;
			//     if ( renderGraph )
			//     {
			//       v7 = HG::Rendering::RenderGraphModule::HGRenderGraph::PreserveTexture(
			//              &v9,
			//              renderGraph,
			//              &this.fields.m_currentSceneDepth,
			//              1,
			//              (String *)"VolumericCloudPass",
			//              0LL);
			// LABEL_9:
			//       this.fields.m_historySceneDepth = *v7;
			//       return;
			//     }
			// LABEL_12:
			//     sub_180B536AC(v5, renderGraph);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2872, 0LL);
			//   if ( !Patch )
			//     goto LABEL_12;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph renderGraph)
		{
		}

		private TextureHandle m_currentSceneDepth;

		private TextureHandle m_historySceneDepth;

		private Material m_volumetricMaterial;

		private VolumetricRenderer m_renderer;

		private Material m_volumetricComposeMaterial;

		private bool m_bHasCloud;

		private bool m_bEnableDownRes;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly RenderFunc<VolumetricCloudPassConstructor.VolumetricCloudPassPassData> s_volumetricCloudFunc;

		private List<HGVolumetricRenderItem> m_renderItems;

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct PassInput
		{
			internal TextureHandle sceneColor;

			internal TextureHandle sceneDepth;

			internal TextureHandle sceneDepthCopied;

			internal HGVolumetricCloudSettingParameters volumetricParameters;

			internal List<IVolumetricRenderObject> volumetricRenderObjects;
		}

		internal struct PassOutput
		{
		}

		public class VolumetricCloudPassPassData
		{
			public VolumetricCloudPassPassData()
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

			public HGCamera hgCamera;

			public TextureHandle sceneColor;

			public TextureHandle sceneDepth;

			public TextureHandle sceneDepthToSample;

			public TextureHandle historySceneDepth;

			public VolumetricRenderer renderer;

			public Material volumetricComposeMaterial;

			public HGVolumetricCloudSettingParameters volumetricParameters;

			public List<IVolumetricRenderObject> volumetricRenderObjects;
		}
	}
}
