using System;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine.HyperGryphEngineCode;

namespace HG.Rendering.Runtime
{
	internal class ScreenSpaceOverlayPassConstructor : ComposablePass, IPassConstructor
	{
		public ScreenSpaceOverlayPassConstructor()
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

		protected override Nullable<HGRenderGraphBuilder> GetRenderGraphBuilder(HGRenderGraph renderGraph)
		{
			// // Nullable`1[HG.Rendering.RenderGraphModule.HGRenderGraphBuilder] GetRenderGraphBuilder(HGRenderGraph)
			// Nullable_1_HG_Rendering_RenderGraphModule_HGRenderGraphBuilder_ *HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor::GetRenderGraphBuilder(
			//         Nullable_1_HG_Rendering_RenderGraphModule_HGRenderGraphBuilder_ *__return_ptr retstr,
			//         ScreenSpaceOverlayPassConstructor *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   __int128 v7; // xmm2
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   Nullable_1_HG_Rendering_RenderGraphModule_HGRenderGraphBuilder_ v12; // [rsp+30h] [rbp-38h] BYREF
			// 
			//   if ( !byte_18D9195B1 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Nullable<HG::Rendering::RenderGraphModule::HGRenderGraphBuilder>::Nullable);
			//     byte_18D9195B1 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2776, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2776, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v10, v9);
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_900(&v12, Patch, (Object *)this, (Object *)renderGraph, 0LL);
			//   }
			//   else
			//   {
			//     v7 = *(_OWORD *)&this.fields.m_renderGraphBuilder.m_RenderGraph;
			//     *(_OWORD *)&v12.hasValue = *(_OWORD *)&this.fields.m_renderGraphBuilder.m_RenderPass;
			//     *(_OWORD *)&retstr.hasValue = 0LL;
			//     *(_OWORD *)&retstr.value.m_Resources = 0LL;
			//     *(_QWORD *)&retstr.value.m_Disposed = 0LL;
			//     *(_OWORD *)&v12.value.m_Resources = v7;
			//     sub_18040CC8C(retstr, &v12);
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		private void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         ScreenSpaceOverlayPassConstructor *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2777, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2777, 0LL);
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
			// void HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         ScreenSpaceOverlayPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2778, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2778, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			//   else
			//   {
			//     *(_OWORD *)&this.fields.m_renderGraphBuilder.m_RenderPass = 0LL;
			//     *(_OWORD *)&this.fields.m_renderGraphBuilder.m_RenderGraph = 0LL;
			//   }
			// }
			// 
		}

		internal void ConstructPass(ref ScreenSpaceOverlayPassConstructor.PassInput input, ref ScreenSpaceOverlayPassConstructor.PassOutput output, HGRenderGraph renderGraph, HGCamera camera, HGSettingParameters settingParameters)
		{
			// // Void ConstructPass(ScreenSpaceOverlayPassConstructor+PassInput ByRef, ScreenSpaceOverlayPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera, HGSettingParameters)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor::ConstructPass(
			//         ScreenSpaceOverlayPassConstructor *this,
			//         ScreenSpaceOverlayPassConstructor_PassInput *input,
			//         ScreenSpaceOverlayPassConstructor_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         HGSettingParameters *settingParameters,
			//         MethodInfo *method)
			// {
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   int v13; // eax
			//   unsigned __int64 v14; // r9
			//   signed __int64 v15; // rtt
			//   Object *v16; // r9
			//   Object__Class *v17; // rcx
			//   unsigned int v18; // r9d
			//   unsigned __int64 v19; // r8
			//   char v20; // r9
			//   signed __int64 v21; // rtt
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v23; // rdx
			//   __int64 v24; // rcx
			//   Object *v25; // [rsp+40h] [rbp-78h] BYREF
			//   TextureHandle v26; // [rsp+48h] [rbp-70h] BYREF
			//   HGRenderGraphBuilder v27; // [rsp+58h] [rbp-60h] BYREF
			//   HGRenderGraphBuilder v28; // [rsp+78h] [rbp-40h] BYREF
			//   Void customPayload[16]; // [rsp+98h] [rbp-20h] BYREF
			//   Il2CppExceptionWrapper *v30; // [rsp+A8h] [rbp-10h] BYREF
			// 
			//   if ( !byte_18D9195B2 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor::UIPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor::UIPassData>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor);
			//     sub_18003C530(&off_18D500980);
			//     byte_18D9195B2 = 1;
			//   }
			//   v25 = 0LL;
			//   *(_OWORD *)customPayload = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2779, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2779, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v24, v23);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1016(
			//       Patch,
			//       (Object *)this,
			//       input,
			//       output,
			//       (Object *)renderGraph,
			//       (Object *)camera,
			//       (Object *)settingParameters,
			//       0LL);
			//   }
			//   else
			//   {
			//     if ( !renderGraph )
			//       sub_180B536AC(v12, v11);
			//     HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//       &v27,
			//       renderGraph,
			//       (String *)"ScreenSpaceOverlay",
			//       &v25,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor::UIPassData>);
			//     v28 = v27;
			//     v27.m_RenderPass = 0LL;
			//     v27.m_Resources = (HGRenderGraphResourceRegistry *)&v28;
			//     try
			//     {
			//       this.fields.m_renderGraphBuilder = v28;
			//       v13 = dword_18D8E43F8;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v14 = (((unsigned __int64)&this.fields >> 12) & 0x1FFFFF) >> 6;
			//         _m_prefetchw(&qword_18D6405E0[v14 + 36190]);
			//         do
			//           v15 = qword_18D6405E0[v14 + 36190];
			//         while ( v15 != _InterlockedCompareExchange64(
			//                          &qword_18D6405E0[v14 + 36190],
			//                          v15 | (1LL << (((unsigned __int64)&this.fields >> 12) & 0x3F)),
			//                          v15) );
			//         v13 = dword_18D8E43F8;
			//       }
			//       v16 = v25;
			//       v17 = (Object__Class *)input.camera;
			//       if ( !v25 )
			//         sub_1802DC2C8(v17, qword_18D6405E0);
			//       v25[1].klass = v17;
			//       if ( v13 )
			//       {
			//         v18 = ((unsigned __int64)&v16[1] >> 12) & 0x1FFFFF;
			//         v19 = (unsigned __int64)v18 >> 6;
			//         v20 = v18 & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v19 + 36190]);
			//         do
			//           v21 = qword_18D6405E0[v19 + 36190];
			//         while ( v21 != _InterlockedCompareExchange64(&qword_18D6405E0[v19 + 36190], v21 | (1LL << v20), v21) );
			//       }
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(&v26, &v28, &input.target, 0, 0, 0LL);
			//       v26 = 0LL;
			//       v26.handle._type_k__BackingField = 1065353216;
			//       *(TextureHandle *)customPayload = v26;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//         &v28,
			//         (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor.static_fields.s_UIRenderFunc,
			//         0LL,
			//         customPayload,
			//         0,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor::UIPassData>);
			//     }
			//     catch ( Il2CppExceptionWrapper *v30 )
			//     {
			//       v27.m_RenderPass = (HGRenderGraphPass *)v30.ex;
			//     }
			//     sub_180222690(&v27);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         ScreenSpaceOverlayPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2780, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2780, 0LL);
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
			// void HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
			//         ScreenSpaceOverlayPassConstructor *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2781, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2781, 0LL);
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

		public Nullable<HGRenderGraphBuilder> <>iFixBaseProxy_GetRenderGraphBuilder(HGRenderGraph P0)
		{
			// // Nullable`1[HG.Rendering.RenderGraphModule.HGRenderGraphBuilder] <>iFixBaseProxy_GetRenderGraphBuilder(HGRenderGraph)
			// Nullable_1_HG_Rendering_RenderGraphModule_HGRenderGraphBuilder_ *HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor::__iFixBaseProxy_GetRenderGraphBuilder(
			//         Nullable_1_HG_Rendering_RenderGraphModule_HGRenderGraphBuilder_ *__return_ptr retstr,
			//         ScreenSpaceOverlayPassConstructor *this,
			//         HGRenderGraph *P0,
			//         MethodInfo *method)
			// {
			//   Nullable_1_HG_Rendering_RenderGraphModule_HGRenderGraphBuilder_ *RenderGraphBuilder; // rax
			//   __int128 v6; // xmm1
			//   __int64 v7; // xmm0_8
			//   Nullable_1_HG_Rendering_RenderGraphModule_HGRenderGraphBuilder_ *result; // rax
			//   Nullable_1_HG_Rendering_RenderGraphModule_HGRenderGraphBuilder_ v9; // [rsp+20h] [rbp-38h] BYREF
			// 
			//   RenderGraphBuilder = HG::Rendering::Runtime::ComposablePass::GetRenderGraphBuilder(
			//                          &v9,
			//                          (ComposablePass *)this,
			//                          P0,
			//                          0LL);
			//   v6 = *(_OWORD *)&RenderGraphBuilder.value.m_Resources;
			//   *(_OWORD *)&retstr.hasValue = *(_OWORD *)&RenderGraphBuilder.hasValue;
			//   v7 = *(_QWORD *)&RenderGraphBuilder.value.m_Disposed;
			//   result = retstr;
			//   *(_OWORD *)&retstr.value.m_Resources = v6;
			//   *(_QWORD *)&retstr.value.m_Disposed = v7;
			//   return result;
			// }
			// 
			return null;
		}

		private HGRenderGraphBuilder m_renderGraphBuilder;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly RenderFunc<ScreenSpaceOverlayPassConstructor.UIPassData> s_UIRenderFunc;

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct PassInput
		{
			internal TextureHandle target;

			internal HGCamera camera;
		}

		internal struct PassOutput
		{
		}

		private class UIPassData
		{
			public UIPassData()
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

			public HGCamera camera;
		}
	}
}
