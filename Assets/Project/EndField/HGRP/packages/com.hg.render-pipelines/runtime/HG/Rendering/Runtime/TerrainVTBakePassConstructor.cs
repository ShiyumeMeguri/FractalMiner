using System;
using HG.Rendering.RenderGraphModule;
using UnityEngine.HyperGryphEngineCode;

namespace HG.Rendering.Runtime
{
	internal class TerrainVTBakePassConstructor : IPassConstructor
	{
		public TerrainVTBakePassConstructor()
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

		internal void ConstructPass(HGRenderGraph renderGraph, HGCamera camera)
		{
			// // Void ConstructPass(HGRenderGraph, HGCamera)
			// void HG::Rendering::Runtime::TerrainVTBakePassConstructor::ConstructPass(
			//         TerrainVTBakePassConstructor *this,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2849, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2849, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
			//       (ILFixDynamicMethodWrapper_28 *)Patch,
			//       (Object *)this,
			//       (Object *)renderGraph,
			//       (Object *)camera,
			//       0LL);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::TerrainVTBakePassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         TerrainVTBakePassConstructor *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2850, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2850, 0LL);
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
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::TerrainVTBakePassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         TerrainVTBakePassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   HGRenderGraph *renderGraph; // rdi
			//   ProfilingSampler *v6; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   __int64 vtFeedbackViewId; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v13; // rdx
			//   __int64 v14; // rcx
			//   Il2CppExceptionWrapper *v15; // [rsp+40h] [rbp-58h] BYREF
			//   HGRenderGraphBuilder v16; // [rsp+48h] [rbp-50h] BYREF
			//   HGRenderGraphBuilder v17; // [rsp+68h] [rbp-30h] BYREF
			//   Object *v18; // [rsp+B8h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D9195DB )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::TerrainVTBakePassConstructor::TerrainVTBakePassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::TerrainVTBakePassConstructor::TerrainVTBakePassData>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::TerrainVTBakePassConstructor);
			//     sub_18003C530(&off_18D503068);
			//     byte_18D9195DB = 1;
			//   }
			//   v18 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2851, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2851, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v14, v13);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			//   else
			//   {
			//     renderGraph = input.renderGraph;
			//     v6 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//            (Int32Enum__Enum)0x11u,
			//            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     if ( !renderGraph )
			//       sub_180B536AC(v8, v7);
			//     HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//       &v16,
			//       renderGraph,
			//       (String *)"TerrainVTBakePass",
			//       &v18,
			//       v6,
			//       1,
			//       ProfilingHGPass__Enum_PreDepth,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::TerrainVTBakePassConstructor::TerrainVTBakePassData>);
			//     v17 = v16;
			//     v16.m_RenderPass = 0LL;
			//     v16.m_Resources = (HGRenderGraphResourceRegistry *)&v17;
			//     try
			//     {
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v17, 0, 0LL);
			//       if ( !input.camera )
			//         sub_1802DC2C8(v10, v9);
			//       vtFeedbackViewId = (unsigned int)input.camera.fields.vtFeedbackViewId;
			//       if ( !v18 )
			//         sub_1802DC2C8(vtFeedbackViewId, v9);
			//       LODWORD(v18[1].klass) = vtFeedbackViewId;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::TerrainVTBakePassConstructor);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//         &v17,
			//         (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::TerrainVTBakePassConstructor.static_fields.s_terrainVTBakePassRenderFunc,
			//         0LL,
			//         0,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::TerrainVTBakePassConstructor::TerrainVTBakePassData>);
			//     }
			//     catch ( Il2CppExceptionWrapper *v15 )
			//     {
			//       v16.m_RenderPass = (HGRenderGraphPass *)v15.ex;
			//     }
			//     sub_180222690(&v16);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::TerrainVTBakePassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         TerrainVTBakePassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2852, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2852, 0LL);
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
			// void HG::Rendering::Runtime::TerrainVTBakePassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
			//         TerrainVTBakePassConstructor *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2853, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2853, 0LL);
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

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly RenderFunc<TerrainVTBakePassConstructor.TerrainVTBakePassData> s_terrainVTBakePassRenderFunc;

		public class TerrainVTBakePassData
		{
			public TerrainVTBakePassData()
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

			internal int feedbackViewId;
		}
	}
}
