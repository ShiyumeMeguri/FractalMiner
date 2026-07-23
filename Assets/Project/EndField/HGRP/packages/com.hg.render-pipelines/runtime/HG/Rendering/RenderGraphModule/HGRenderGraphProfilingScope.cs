using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.RenderGraphModule
{
	public struct HGRenderGraphProfilingScope : IDisposable // TypeDefIndex: 37433
	{
		// Fields
		private bool m_Disposed; // 0x00
		private ProfilingSampler m_Sampler; // 0x08
		private HGRenderGraph m_RenderGraph; // 0x10
	
		// Constructors
		public HGRenderGraphProfilingScope(HGRenderGraph renderGraph, ProfilingSampler sampler) {
			m_Disposed = default;
			m_Sampler = default;
			m_RenderGraph = default;
		} // 0x0000000189B38834-0x0000000189B3887C
		// HGRenderGraphProfilingScope(HGRenderGraph, ProfilingSampler)
		void HG::Rendering::RenderGraphModule::HGRenderGraphProfilingScope::HGRenderGraphProfilingScope(
		        HGRenderGraphProfilingScope *this,
		        HGRenderGraph *renderGraph,
		        ProfilingSampler *sampler,
		        MethodInfo *method)
		{
		  __int64 v4; // r9
		  __int64 v5; // r11
		  Type *v6; // rdx
		  PropertyInfo_1 *v7; // r8
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  HGRenderGraph *v10; // r10
		  ProfilingSampler *v11; // r11
		  _BYTE *v12; // r9
		  MethodInfo *v13; // [rsp+20h] [rbp-8h]
		  MethodInfo *v14; // [rsp+20h] [rbp-8h]
		
		  this->m_RenderGraph = renderGraph;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->m_RenderGraph,
		    (Type *)renderGraph,
		    (PropertyInfo_1 *)sampler,
		    (Int32__Array **)this,
		    v13);
		  *(_QWORD *)(v4 + 8) = v5;
		  sub_18002D1B0((SingleFieldAccessor *)(v4 + 8), v6, v7, (Int32__Array **)v4, v14);
		  *v12 = 0;
		  if ( !v10 )
		    sub_1800D8260(v9, v8);
		  HG::Rendering::RenderGraphModule::HGRenderGraph::BeginProfilingSampler(v10, v11, 0LL);
		}
		
	
		// Methods
		[IDTag(1)]
		public void Dispose() {} // 0x0000000189B387DC-0x0000000189B38834
		// Void Dispose()
		void HG::Rendering::RenderGraphModule::HGRenderGraphProfilingScope::Dispose(
		        HGRenderGraphProfilingScope *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(220, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(220, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_103(Patch, this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::RenderGraphModule::HGRenderGraphProfilingScope::Dispose(this, 1, 0LL);
		  }
		}
		
		[IDTag(0)]
		private void Dispose(bool disposing) {} // 0x0000000189B38764-0x0000000189B387DC
		// Void Dispose(Boolean)
		void HG::Rendering::RenderGraphModule::HGRenderGraphProfilingScope::Dispose(
		        HGRenderGraphProfilingScope *this,
		        bool disposing,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HGRenderGraph *m_RenderGraph; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(221, 0LL) )
		  {
		    if ( this->m_Disposed )
		      return;
		    if ( !disposing )
		      goto LABEL_6;
		    m_RenderGraph = this->m_RenderGraph;
		    if ( m_RenderGraph )
		    {
		      HG::Rendering::RenderGraphModule::HGRenderGraph::EndProfilingSampler(m_RenderGraph, this->m_Sampler, 0LL);
		LABEL_6:
		      this->m_Disposed = 1;
		      return;
		    }
		LABEL_8:
		    sub_1800D8260(m_RenderGraph, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(221, 0LL);
		  if ( !Patch )
		    goto LABEL_8;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_102(Patch, this, disposing, 0LL);
		}
		
	}
}
