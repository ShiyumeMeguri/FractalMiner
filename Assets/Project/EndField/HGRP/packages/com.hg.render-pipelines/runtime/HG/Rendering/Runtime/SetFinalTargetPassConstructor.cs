using System;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;

namespace HG.Rendering.Runtime
{
	internal class SetFinalTargetPassConstructor : IPassConstructor
	{
		internal SetFinalTargetPassConstructor(HGRenderPipelineMaterialCollector materialCollector, HGRenderPathBase.HGRenderPathResources resources)
		{
			// // SetFinalTargetPassConstructor(HGRenderPipelineMaterialCollector, HGRenderPathBase+HGRenderPathResources)
			// void HG::Rendering::Runtime::SetFinalTargetPassConstructor::SetFinalTargetPassConstructor(
			//         SetFinalTargetPassConstructor *this,
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
			//   this.fields.m_CopyDepth = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
			//                                materialCollector,
			//                                shaders.fields.copyDepthBufferPS,
			//                                0,
			//                                0LL);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields, v6, v7, v8, v9, v10);
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::SetFinalTargetPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         SetFinalTargetPassConstructor *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2793, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2793, 0LL);
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
			// void HG::Rendering::Runtime::SetFinalTargetPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         SetFinalTargetPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2794, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2794, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		internal void ConstructPass(ref SetFinalTargetPassConstructor.PassInput input, ref SetFinalTargetPassConstructor.PassOutput output, HGRenderGraph renderGraph, HGCamera camera)
		{
			// // Void ConstructPass(SetFinalTargetPassConstructor+PassInput ByRef, SetFinalTargetPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
			// // Hidden C++ exception states: #wind=2
			// void HG::Rendering::Runtime::SetFinalTargetPassConstructor::ConstructPass(
			//         SetFinalTargetPassConstructor *this,
			//         SetFinalTargetPassConstructor_PassInput *input,
			//         SetFinalTargetPassConstructor_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   Object *v6; // r14
			//   SetFinalTargetPassConstructor_PassInput *v8; // rsi
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   Object_1 *targetTexture; // rbx
			//   __int64 v13; // rdx
			//   __int64 v14; // rcx
			//   RenderTexture *v15; // rax
			//   __int64 v16; // rdx
			//   __int64 v17; // rcx
			//   __int64 v18; // rdx
			//   __int64 v19; // rcx
			//   __int64 v20; // r8
			//   TextureHandle *v21; // rbx
			//   __int64 v22; // rdx
			//   __int64 v23; // rcx
			//   TextureHandle v24; // xmm0
			//   __int64 v25; // rbx
			//   bool isMainGameView; // al
			//   __int64 v27; // rdx
			//   __int64 v28; // rcx
			//   __int64 v29; // rdx
			//   unsigned int v30; // edx
			//   unsigned __int64 v31; // r8
			//   char v32; // dl
			//   signed __int64 v33; // rtt
			//   ResourceHandle handle; // rbx
			//   ResourceHandle *v35; // rax
			//   __int64 v36; // rdx
			//   __int64 v37; // rcx
			//   Object *v38; // rbx
			//   __int64 v39; // rdx
			//   __int64 v40; // rcx
			//   TextureHandle v41; // xmm0
			//   Object *v42; // rbx
			//   __int64 v43; // rdx
			//   __int64 v44; // rcx
			//   TextureHandle v45; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v47; // rdx
			//   __int64 v48; // rcx
			//   __int64 v49; // [rsp+50h] [rbp-B8h] BYREF
			//   Il2CppException *ex; // [rsp+58h] [rbp-B0h] BYREF
			//   HGRenderGraphBuilder *v51; // [rsp+60h] [rbp-A8h]
			//   Object *v52; // [rsp+68h] [rbp-A0h] BYREF
			//   HGRenderGraphBuilder v53; // [rsp+70h] [rbp-98h] BYREF
			//   HGRenderGraphBuilder v54; // [rsp+90h] [rbp-78h] BYREF
			//   HGRenderGraphBuilder v55; // [rsp+B0h] [rbp-58h] BYREF
			//   __m128i si128; // [rsp+D0h] [rbp-38h] BYREF
			//   Il2CppExceptionWrapper *v57; // [rsp+E0h] [rbp-28h] BYREF
			//   Il2CppExceptionWrapper *v58; // [rsp+E8h] [rbp-20h] BYREF
			// 
			//   v6 = (Object *)renderGraph;
			//   v8 = input;
			//   if ( !byte_18D9195BA )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::SetFinalTargetPassConstructor::SetFinalTargetPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::SetFinalTargetPassConstructor::SetFinalTargetPassData>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::SetFinalTargetPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&off_18D503AF8);
			//     byte_18D9195BA = 1;
			//   }
			//   memset(&v54, 0, sizeof(v54));
			//   v49 = 0LL;
			//   memset(&v55, 0, sizeof(v55));
			//   v52 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2795, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2795, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v48, v47);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1021(Patch, (Object *)this, v8, output, v6, (Object *)camera, 0LL);
			//   }
			//   else
			//   {
			//     if ( !camera )
			//       sub_180B536AC(v11, v10);
			//     if ( !camera.fields.camera )
			//       sub_180B536AC(v11, v10);
			//     targetTexture = (Object_1 *)UnityEngine::Camera::get_targetTexture(camera.fields.camera, 0LL);
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Inequality(targetTexture, 0LL, 0LL) )
			//     {
			//       if ( !camera.fields.camera )
			//         sub_180B536AC(v14, v13);
			//       v15 = UnityEngine::Camera::get_targetTexture(camera.fields.camera, 0LL);
			//       if ( !v15 )
			//         sub_180B536AC(v17, v16);
			//       if ( UnityEngine::RenderTexture::get_depth(v15, 0LL) )
			//       {
			//         if ( !v6 )
			//           sub_180B536AC(v19, v18);
			//         v54 = *(HGRenderGraphBuilder *)sub_180830CD8(&v53, v6, v20, &v49);
			//         ex = 0LL;
			//         v51 = &v54;
			//         try
			//         {
			//           si128 = _mm_load_si128((const __m128i *)&xmmword_18A3576D0);
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//             (TextureHandle *)&v53,
			//             &v54,
			//             &v8.backBufferColor,
			//             0,
			//             RenderBufferLoadAction__Enum_Load,
			//             RenderBufferStoreAction__Enum_Store,
			//             (Color *)&si128,
			//             0,
			//             0LL);
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
			//             (TextureHandle *)&v53,
			//             &v54,
			//             &v8.backBufferDepth,
			//             DepthAccess__Enum_Write,
			//             0,
			//             0LL);
			//           v21 = (TextureHandle *)v49;
			//           v24 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                    (TextureHandle *)&v53,
			//                    &v54,
			//                    &v8.sceneDepth,
			//                    0LL);
			//           if ( !v21 )
			//             sub_1802DC2C8(v23, v22);
			//           v21[3] = v24;
			//           v25 = v49;
			//           isMainGameView = HG::Rendering::Runtime::HGCamera::get_isMainGameView(camera, 0LL);
			//           if ( !v25 )
			//             sub_1802DC2C8(v28, v27);
			//           *(_BYTE *)(v25 + 64) = isMainGameView;
			//           v29 = v49;
			//           if ( !v49 )
			//             sub_1802DC2C8(v28, 0LL);
			//           *(_QWORD *)(v49 + 72) = this.fields.m_CopyDepth;
			//           if ( dword_18D8E43F8 )
			//           {
			//             v30 = ((unsigned __int64)(v29 + 72) >> 12) & 0x1FFFFF;
			//             v31 = (unsigned __int64)v30 >> 6;
			//             v32 = v30 & 0x3F;
			//             _m_prefetchw(&qword_18D6870D0[v31]);
			//             do
			//               v33 = qword_18D6870D0[v31];
			//             while ( v33 != _InterlockedCompareExchange64(&qword_18D6870D0[v31], v33 | (1LL << v32), v33) );
			//           }
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::SetFinalTargetPassConstructor);
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//             &v54,
			//             (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::SetFinalTargetPassConstructor.static_fields.s_setFinalTargetRenderFunc,
			//             0LL,
			//             0,
			//             MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::SetFinalTargetPassConstructor::SetFinalTargetPassData>);
			//         }
			//         catch ( Il2CppExceptionWrapper *v57 )
			//         {
			//           ex = v57.ex;
			//           sub_180222690(&ex);
			//           v6 = (Object *)renderGraph;
			//           v8 = input;
			//           goto LABEL_20;
			//         }
			//         sub_180222690(&ex);
			//       }
			//     }
			// LABEL_20:
			//     handle = v8.finalResult.handle;
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//     handle.m_Value = HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit(handle, 0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     v35 = (ResourceHandle *)sub_182E7CCD0(&v53);
			//     if ( handle.m_Value != HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit(*v35, 0LL) )
			//     {
			//       if ( !v6 )
			//         sub_1802DC2C8(v37, v36);
			//       HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//         &v53,
			//         (HGRenderGraph *)v6,
			//         (String *)"Set Final Target",
			//         &v52,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::SetFinalTargetPassConstructor::SetFinalTargetPassData>);
			//       v55 = v53;
			//       ex = 0LL;
			//       v51 = &v55;
			//       try
			//       {
			//         v38 = v52;
			//         v41 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                  (TextureHandle *)&v53,
			//                  &v55,
			//                  &v8.finalResult,
			//                  0LL);
			//         if ( !v38 )
			//           sub_1802DC2C8(v40, v39);
			//         v38[1] = (Object)v41;
			//         v42 = v52;
			//         v45 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
			//                  (TextureHandle *)&v53,
			//                  &v55,
			//                  &v8.backBufferColor,
			//                  0LL);
			//         if ( !v42 )
			//           sub_1802DC2C8(v44, v43);
			//         v42[2] = (Object)v45;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::SetFinalTargetPassConstructor);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//           &v55,
			//           (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::SetFinalTargetPassConstructor.static_fields.s_copyColorFunc,
			//           0LL,
			//           0,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::SetFinalTargetPassConstructor::SetFinalTargetPassData>);
			//       }
			//       catch ( Il2CppExceptionWrapper *v58 )
			//       {
			//         ex = v58.ex;
			//         sub_180222690(&ex);
			//         return;
			//       }
			//       sub_180222690(&ex);
			//     }
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::SetFinalTargetPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         SetFinalTargetPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2796, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2796, 0LL);
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
			// void HG::Rendering::Runtime::SetFinalTargetPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
			//         SetFinalTargetPassConstructor *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2797, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2797, 0LL);
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

		private Material m_CopyDepth;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly RenderFunc<SetFinalTargetPassConstructor.SetFinalTargetPassData> s_setFinalTargetRenderFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		private static readonly RenderFunc<SetFinalTargetPassConstructor.SetFinalTargetPassData> s_copyColorFunc;

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 64)]
		internal struct PassInput
		{
			internal TextureHandle finalResult;

			internal TextureHandle sceneDepth;

			internal TextureHandle backBufferColor;

			internal TextureHandle backBufferDepth;
		}

		internal struct PassOutput
		{
		}

		private class SetFinalTargetPassData
		{
			public SetFinalTargetPassData()
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

			public TextureHandle finalResult;

			public TextureHandle finalTarget;

			public TextureHandle depthBuffer;

			public bool flipY;

			public Material copyDepthMaterial;
		}
	}
}
