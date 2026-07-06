using System;
using System.Runtime.InteropServices;
using IFix.Core;
using UnityEngine.Rendering;

namespace HG.Rendering.RenderGraphModule
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct HGRenderGraphProfilingScope : IDisposable
	{
		public HGRenderGraphProfilingScope(HGRenderGraph renderGraph, ProfilingSampler sampler)
		{
		}

		[IDTag(1)]
		public void Dispose()
		{
			// // Void Dispose()
			// void HG::Rendering::RenderGraphModule::HGRenderGraphProfilingScope::Dispose(
			//         HGRenderGraphProfilingScope *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(218, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(218, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_102(Patch, this, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::RenderGraphModule::HGRenderGraphProfilingScope::Dispose(this, 1, 0LL);
			//   }
			// }
			// 
		}

		[IDTag(0)]
		private void Dispose(bool disposing)
		{
			// // Void Dispose(Boolean)
			// void HG::Rendering::RenderGraphModule::HGRenderGraphProfilingScope::Dispose(
			//         HGRenderGraphProfilingScope *this,
			//         bool disposing,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   HGRenderGraph *m_RenderGraph; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(219, 0LL) )
			//   {
			//     if ( this.m_Disposed )
			//       return;
			//     if ( !disposing )
			//       goto LABEL_6;
			//     m_RenderGraph = this.m_RenderGraph;
			//     if ( m_RenderGraph )
			//     {
			//       HG::Rendering::RenderGraphModule::HGRenderGraph::EndProfilingSampler(m_RenderGraph, this.m_Sampler, 0LL);
			// LABEL_6:
			//       this.m_Disposed = 1;
			//       return;
			//     }
			// LABEL_8:
			//     sub_180B536AC(m_RenderGraph, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(219, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_101(Patch, this, disposing, 0LL);
			// }
			// 
		}

		private bool m_Disposed;

		private ProfilingSampler m_Sampler;

		private HGRenderGraph m_RenderGraph;
	}
}
