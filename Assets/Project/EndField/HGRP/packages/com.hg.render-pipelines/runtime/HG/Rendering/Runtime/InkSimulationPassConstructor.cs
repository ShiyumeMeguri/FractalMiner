using System;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;

namespace HG.Rendering.Runtime
{
	internal class InkSimulationPassConstructor : IPassConstructor
	{
		internal InkSimulationPassConstructor()
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

		private void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::InkSimulationPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         InkSimulationPassConstructor *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2693, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2693, 0LL);
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
			// void HG::Rendering::Runtime::InkSimulationPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         InkSimulationPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2694, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2694, 0LL);
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
			// void HG::Rendering::Runtime::InkSimulationPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         InkSimulationPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2695, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2695, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		internal void ConstructPass(HGRenderGraph renderGraph, Material material, float influence, Vector3 center, double deltaTime)
		{
			// // Void ConstructPass(HGRenderGraph, Material, Single, Vector3, Double)
			// void HG::Rendering::Runtime::InkSimulationPassConstructor::ConstructPass(
			//         InkSimulationPassConstructor *this,
			//         HGRenderGraph *renderGraph,
			//         Material *material,
			//         float influence,
			//         Vector3 *center,
			//         double deltaTime,
			//         MethodInfo *method)
			// {
			//   __int64 v10; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   HGRenderGraphContext *m_RenderGraphContext; // rax
			//   CommandBuffer *cmd; // rdi
			//   Texture2D *blackTexture; // rax
			//   RenderTargetIdentifier *v15; // rax
			//   __int128 v16; // xmm1
			//   HGRenderGraphContext *v17; // rbx
			//   CommandBuffer *v18; // rbx
			//   Texture2D *v19; // rax
			//   RenderTargetIdentifier *v20; // rax
			//   __int128 v21; // xmm1
			//   float z; // eax
			//   Vector3 v23; // [rsp+48h] [rbp-41h] BYREF
			//   RenderTargetIdentifier v24; // [rsp+58h] [rbp-31h] BYREF
			//   RenderTargetIdentifier v25; // [rsp+88h] [rbp-1h] BYREF
			// 
			//   if ( !byte_18D91957C )
			//   {
			//     sub_18003C530(&off_18D500F20);
			//     sub_18003C530(&off_18D500F30);
			//     byte_18D91957C = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2696, 0LL) )
			//   {
			//     if ( renderGraph )
			//     {
			//       m_RenderGraphContext = renderGraph.fields.m_RenderGraphContext;
			//       if ( m_RenderGraphContext )
			//       {
			//         cmd = m_RenderGraphContext.fields.cmd;
			//         blackTexture = UnityEngine::Texture2D::get_blackTexture(0LL);
			//         v15 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v25, (Texture *)blackTexture, 0LL);
			//         if ( cmd )
			//         {
			//           v16 = *(_OWORD *)&v15.m_BufferPointer;
			//           *(_OWORD *)&v24.m_Type = *(_OWORD *)&v15.m_Type;
			//           *(_QWORD *)&v24.m_DepthSlice = *(_QWORD *)&v15.m_DepthSlice;
			//           *(_OWORD *)&v24.m_BufferPointer = v16;
			//           UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, (String *)"_InkSimulationResultA", &v24, 0LL);
			//           v17 = renderGraph.fields.m_RenderGraphContext;
			//           if ( v17 )
			//           {
			//             v18 = v17.fields.cmd;
			//             v19 = UnityEngine::Texture2D::get_blackTexture(0LL);
			//             v20 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v25, (Texture *)v19, 0LL);
			//             if ( v18 )
			//             {
			//               v21 = *(_OWORD *)&v20.m_BufferPointer;
			//               *(_OWORD *)&v24.m_Type = *(_OWORD *)&v20.m_Type;
			//               *(_QWORD *)&v24.m_DepthSlice = *(_QWORD *)&v20.m_DepthSlice;
			//               *(_OWORD *)&v24.m_BufferPointer = v21;
			//               UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(v18, (String *)"_InkSimulationResultB", &v24, 0LL);
			//               return;
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_11:
			//     sub_180B536AC(Patch, v10);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2696, 0LL);
			//   if ( !Patch )
			//     goto LABEL_11;
			//   z = center.z;
			//   *(_QWORD *)&v23.x = *(_QWORD *)&center.x;
			//   v23.z = z;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_985(
			//     Patch,
			//     (Object *)this,
			//     (Object *)renderGraph,
			//     (Object *)material,
			//     influence,
			//     &v23,
			//     deltaTime,
			//     0LL);
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph renderGraph)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
			// void HG::Rendering::Runtime::InkSimulationPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
			//         InkSimulationPassConstructor *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2697, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2697, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)renderGraph,
			//       0LL);
			//   }
			//   else if ( this.fields.m_impl )
			//   {
			//     UnityEngine::HyperGryphEngineCode::HGRenderGraphCPP::InkSimulationPass_Destroy(this.fields.m_impl, 0LL);
			//   }
			// }
			// 
		}

		private long m_impl;
	}
}
