using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine.HyperGryphEngineCode;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class InkSimulationPassConstructor : IPassConstructor // TypeDefIndex: 38332
	{
		// Constructors
		internal InkSimulationPassConstructor() {} // 0x00000001841E1670-0x00000001841E1680
		// Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
		void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
		        HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
		        HGWindConfig *cSrc,
		        HGWindConfig *cDst,
		        float t,
		        MethodInfo *method)
		{
		  ;
		}
		
	
		// Methods
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189BBA45C-0x0000000189BBA4B0
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::InkSimulationPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        InkSimulationPassConstructor *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3228, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3228, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		  }
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189BBA408-0x0000000189BBA45C
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::InkSimulationPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        InkSimulationPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3229, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3229, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189BBA3B4-0x0000000189BBA408
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::InkSimulationPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        InkSimulationPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3230, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3230, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		internal void ConstructPass(HGRenderGraph renderGraph) {} // 0x0000000189BBA27C-0x0000000189BBA3B4
		// Void ConstructPass(HGRenderGraph)
		void HG::Rendering::Runtime::InkSimulationPassConstructor::ConstructPass(
		        InkSimulationPassConstructor *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  HGRenderGraphContext *HGContext; // rax
		  CommandBuffer *cmd; // rdi
		  Texture *blackTexture; // rax
		  RenderTargetIdentifier *v10; // rax
		  __int128 v11; // xmm1
		  HGRenderGraphContext *v12; // rax
		  CommandBuffer *v13; // rbx
		  Texture *v14; // rax
		  RenderTargetIdentifier *v15; // rax
		  __int128 v16; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  RenderTargetIdentifier v18; // [rsp+20h] [rbp-68h] BYREF
		  RenderTargetIdentifier v19; // [rsp+50h] [rbp-38h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3231, 0LL) )
		  {
		    if ( renderGraph )
		    {
		      HGContext = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(renderGraph, 0LL);
		      if ( HGContext )
		      {
		        cmd = HGContext->fields.cmd;
		        blackTexture = (Texture *)UnityEngine::Texture2D::get_blackTexture(0LL);
		        v10 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v19, blackTexture, 0LL);
		        if ( cmd )
		        {
		          v11 = *(_OWORD *)&v10->m_BufferPointer;
		          *(_OWORD *)&v18.m_Type = *(_OWORD *)&v10->m_Type;
		          *(_QWORD *)&v18.m_DepthSlice = *(_QWORD *)&v10->m_DepthSlice;
		          *(_OWORD *)&v18.m_BufferPointer = v11;
		          UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, (String *)"_InkSimulationResultA", &v18, 0LL);
		          v12 = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(renderGraph, 0LL);
		          if ( v12 )
		          {
		            v13 = v12->fields.cmd;
		            v14 = (Texture *)UnityEngine::Texture2D::get_blackTexture(0LL);
		            v15 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v19, v14, 0LL);
		            if ( v13 )
		            {
		              v16 = *(_OWORD *)&v15->m_BufferPointer;
		              *(_OWORD *)&v18.m_Type = *(_OWORD *)&v15->m_Type;
		              *(_QWORD *)&v18.m_DepthSlice = *(_QWORD *)&v15->m_DepthSlice;
		              *(_OWORD *)&v18.m_BufferPointer = v16;
		              UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(v13, (String *)"_InkSimulationResultB", &v18, 0LL);
		              return;
		            }
		          }
		        }
		      }
		    }
		LABEL_9:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3231, 0LL);
		  if ( !Patch )
		    goto LABEL_9;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)renderGraph,
		    0LL);
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x0000000184D80140-0x0000000184D80170
		// Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::InkSimulationPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
		        InkSimulationPassConstructor *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3232, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3232, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)renderGraph,
		      0LL);
		  }
		}
		
	}
}
