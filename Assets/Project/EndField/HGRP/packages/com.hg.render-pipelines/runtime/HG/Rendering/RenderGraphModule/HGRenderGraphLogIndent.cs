using System;
using System.Runtime.InteropServices;
using IFix.Core;

namespace HG.Rendering.RenderGraphModule
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct HGRenderGraphLogIndent : IDisposable
	{
		public HGRenderGraphLogIndent(HGRenderGraphLogger logger, [MetadataOffset(Offset = "0x01F909F6")] int indentation = 1)
		{
		}

		[IDTag(1)]
		public void Dispose()
		{
			// // Void Dispose()
			// void HG::Rendering::RenderGraphModule::HGRenderGraphLogIndent::Dispose(
			//         HGRenderGraphLogIndent *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(53, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(53, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_30(Patch, this, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::RenderGraphModule::HGRenderGraphLogIndent::Dispose(this, 1, 0LL);
			//   }
			// }
			// 
		}

		[IDTag(0)]
		private void Dispose(bool disposing)
		{
			// // Void Dispose(Boolean)
			// void HG::Rendering::RenderGraphModule::HGRenderGraphLogIndent::Dispose(
			//         HGRenderGraphLogIndent *this,
			//         bool disposing,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(54, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(54, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_29(Patch, this, disposing, 0LL);
			//   }
			//   else if ( !this.m_Disposed )
			//   {
			//     if ( disposing )
			//     {
			//       if ( this.m_Logger )
			//         HG::Rendering::RenderGraphModule::HGRenderGraphLogger::DecrementIndentation(
			//           this.m_Logger,
			//           this.m_Indentation,
			//           0LL);
			//     }
			//     this.m_Disposed = 1;
			//   }
			// }
			// 
		}

		private int m_Indentation;

		private HGRenderGraphLogger m_Logger;

		private bool m_Disposed;
	}
}
