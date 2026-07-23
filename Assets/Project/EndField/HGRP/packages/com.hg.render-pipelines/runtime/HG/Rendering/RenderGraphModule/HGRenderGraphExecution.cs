using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.RenderGraphModule
{
	public struct HGRenderGraphExecution : IDisposable // TypeDefIndex: 37416
	{
		// Fields
		private HGRenderGraph renderGraph; // 0x00
	
		// Constructors
		internal HGRenderGraphExecution(HGRenderGraph renderGraph) {
			this.renderGraph = default;
		} // 0x0000000185392320-0x0000000185392328
		// Void WriteUnaligned[Object](Byte ByRef, Object)
		void System::Runtime::CompilerServices::Unsafe::WriteUnaligned<System::Object>(
		        uint8_t *destination,
		        Object *value,
		        MethodInfo *method)
		{
		  Int32__Array **v3; // r9
		  MethodInfo *v4; // [rsp+28h] [rbp+28h]
		
		  *(_QWORD *)destination = value;
		  sub_18002D1B0((SingleFieldAccessor *)destination, (Type *)value, (PropertyInfo_1 *)method, v3, v4);
		}
		
	
		// Methods
		public void Dispose() {} // 0x0000000189B29014-0x0000000189B29068
		// Void Dispose()
		void HG::Rendering::RenderGraphModule::HGRenderGraphExecution::Dispose(
		        HGRenderGraphExecution *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  HGRenderGraph *renderGraph; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(26, 0LL) )
		  {
		    renderGraph = this->renderGraph;
		    if ( this->renderGraph )
		    {
		      HG::Rendering::RenderGraphModule::HGRenderGraph::Execute(renderGraph, 0LL);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(renderGraph, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(26, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_52(Patch, this, 0LL);
		}
		
	}
}
