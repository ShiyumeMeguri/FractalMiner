using System;
using System.Runtime.InteropServices;

namespace HG.Rendering.RenderGraphModule
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct HGRenderGraphExecution : IDisposable
	{
		internal HGRenderGraphExecution(HGRenderGraph renderGraph)
		{
			// // Void WriteUnaligned[Object](Byte ByRef, Object)
			// void System::Runtime::CompilerServices::Unsafe::WriteUnaligned<System::Object>(
			//         uint8_t *destination,
			//         Object *value,
			//         MethodInfo *method)
			// {
			//   MessageDescriptor *v3; // r9
			//   String__Array *v4; // [rsp+28h] [rbp+28h]
			//   String *v5; // [rsp+30h] [rbp+30h]
			//   MethodInfo *v6; // [rsp+38h] [rbp+38h]
			// 
			//   *(_QWORD *)destination = value;
			//   sub_1800054D0((OneofDescriptor *)destination, (OneofDescriptorProto *)value, (FileDescriptor *)method, v3, v4, v5, v6);
			// }
			// 
		}

		public void Dispose()
		{
			// // Void Dispose()
			// void HG::Rendering::RenderGraphModule::HGRenderGraphExecution::Dispose(
			//         HGRenderGraphExecution *this,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   HGRenderGraph *renderGraph; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(31, 0LL) )
			//   {
			//     renderGraph = this.renderGraph;
			//     if ( this.renderGraph )
			//     {
			//       HG::Rendering::RenderGraphModule::HGRenderGraph::Execute(renderGraph, 0LL);
			//       return;
			//     }
			// LABEL_5:
			//     sub_180B536AC(renderGraph, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(31, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_54(Patch, this, 0LL);
			// }
			// 
		}

		private HGRenderGraph renderGraph;
	}
}
