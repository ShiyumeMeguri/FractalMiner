using System;
using HG.Rendering.RenderGraphModule;

namespace HG.Rendering.Runtime
{
	internal class ComposablePass
	{
		public ComposablePass()
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

		protected virtual Nullable<HGRenderGraphBuilder> GetRenderGraphBuilder(HGRenderGraph renderGraph)
		{
			// // Nullable`1[HG.Rendering.RenderGraphModule.HGRenderGraphBuilder] GetRenderGraphBuilder(HGRenderGraph)
			// Nullable_1_HG_Rendering_RenderGraphModule_HGRenderGraphBuilder_ *HG::Rendering::Runtime::ComposablePass::GetRenderGraphBuilder(
			//         Nullable_1_HG_Rendering_RenderGraphModule_HGRenderGraphBuilder_ *__return_ptr retstr,
			//         ComposablePass *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Nullable_1_HG_Rendering_RenderGraphModule_HGRenderGraphBuilder_ v11; // [rsp+30h] [rbp-38h] BYREF
			// 
			//   if ( !byte_18D91963E )
			//   {
			//     sub_18003C530(&MethodInfo::System::Nullable<HG::Rendering::RenderGraphModule::HGRenderGraphBuilder>::Nullable);
			//     byte_18D91963E = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2955, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2955, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_900(&v11, Patch, (Object *)this, (Object *)renderGraph, 0LL);
			//   }
			//   else
			//   {
			//     *(_OWORD *)&retstr.hasValue = 0LL;
			//     *(_OWORD *)&retstr.value.m_Resources = 0LL;
			//     *(_QWORD *)&retstr.value.m_Disposed = 0LL;
			//     memset(&v11, 0, 32);
			//     sub_18040CC8C(retstr, &v11);
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		internal void SetChildPass(HGRenderGraph renderGraph, ComposablePass pass)
		{
			// // Void SetChildPass(HGRenderGraph, ComposablePass)
			// void HG::Rendering::Runtime::ComposablePass::SetChildPass(
			//         ComposablePass *this,
			//         HGRenderGraph *renderGraph,
			//         ComposablePass *pass,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   __int64 v8; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   __int64 v11; // rax
			//   __m128i v12; // xmm2
			//   __int128 v13; // xmm0
			//   __int64 v14; // xmm1_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   HGRenderGraphBuilder v16; // [rsp+38h] [rbp-69h] BYREF
			//   Nullable_1_Beyond_Gameplay_Core_GameLevelLoader_SeamlessSetting_ v17; // [rsp+58h] [rbp-49h] BYREF
			//   Nullable_1_Beyond_Gameplay_Core_GameLevelLoader_SeamlessSetting_ v18; // [rsp+88h] [rbp-19h] BYREF
			//   HGRenderGraphBuilder v19; // [rsp+B0h] [rbp+Fh] BYREF
			//   _BYTE v20[40]; // [rsp+D0h] [rbp+2Fh] BYREF
			// 
			//   if ( !byte_18D91963F )
			//   {
			//     sub_18003C530(&MethodInfo::System::Nullable<HG::Rendering::RenderGraphModule::HGRenderGraphBuilder>::get_HasValue);
			//     sub_18003C530(&MethodInfo::System::Nullable<HG::Rendering::RenderGraphModule::HGRenderGraphBuilder>::get_Value);
			//     byte_18D91963F = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2956, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2956, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
			//         (ILFixDynamicMethodWrapper_28 *)Patch,
			//         (Object *)this,
			//         (Object *)renderGraph,
			//         (Object *)pass,
			//         0LL);
			//       return;
			//     }
			// LABEL_9:
			//     sub_180B536AC(v10, v9);
			//   }
			//   v8 = sub_1808313CC(&v18, v7, this, renderGraph);
			//   *(_QWORD *)&v17.value.keepCamera = *(_QWORD *)(v8 + 32);
			//   *(_OWORD *)&v16.m_RenderPass = *(_OWORD *)v8;
			//   *(_OWORD *)&v17.hasValue = *(_OWORD *)&v16.m_RenderPass;
			//   *(_OWORD *)&v17.value.tpScreenFx = *(_OWORD *)(v8 + 16);
			//   if ( !pass )
			//     goto LABEL_9;
			//   v11 = sub_1808313CC(v20, v9, pass, renderGraph);
			//   v12 = *(__m128i *)v11;
			//   v13 = *(_OWORD *)(v11 + 16);
			//   v14 = *(_QWORD *)(v11 + 32);
			//   *(_OWORD *)&v18.hasValue = *(_OWORD *)v11;
			//   *(_OWORD *)&v18.value.tpScreenFx = v13;
			//   *(_QWORD *)&v18.value.keepCamera = v14;
			//   if ( LOBYTE(v16.m_RenderPass) )
			//   {
			//     if ( (unsigned __int8)_mm_cvtsi128_si32(v12) )
			//     {
			//       System::Nullable<Beyond::Gameplay::Core::GameLevelLoader::SeamlessSetting>::get_Value(
			//         (GameLevelLoader_SeamlessSetting *)&v16,
			//         &v17,
			//         MethodInfo::System::Nullable<HG::Rendering::RenderGraphModule::HGRenderGraphBuilder>::get_Value);
			//       v19 = v16;
			//       System::Nullable<Beyond::Gameplay::Core::GameLevelLoader::SeamlessSetting>::get_Value(
			//         (GameLevelLoader_SeamlessSetting *)&v16,
			//         &v18,
			//         MethodInfo::System::Nullable<HG::Rendering::RenderGraphModule::HGRenderGraphBuilder>::get_Value);
			//       *(_OWORD *)&v17.hasValue = *(_OWORD *)&v16.m_RenderPass;
			//       *(_OWORD *)&v17.value.tpScreenFx = *(_OWORD *)&v16.m_RenderGraph;
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AddChildPass(&v19, (HGRenderGraphBuilder *)&v17, 0LL);
			//     }
			//   }
			// }
			// 
		}
	}
}
