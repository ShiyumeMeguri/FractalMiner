using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.RenderGraphModule
{
	internal struct HGRenderGraphLogIndent : IDisposable // TypeDefIndex: 37436
	{
		// Fields
		private int m_Indentation; // 0x00
		private HGRenderGraphLogger m_Logger; // 0x08
		private bool m_Disposed; // 0x10
	
		// Constructors
		public HGRenderGraphLogIndent(HGRenderGraphLogger logger, int indentation = 1 /* Metadata: 0x02302D66 */) {
			m_Indentation = default;
			m_Logger = default;
			m_Disposed = default;
		} // 0x0000000189B36D98-0x0000000189B36DD4
		// HGRenderGraphLogIndent(HGRenderGraphLogger, Int32)
		// local variable allocation has failed, the output may be wrong!
		void HG::Rendering::RenderGraphModule::HGRenderGraphLogIndent::HGRenderGraphLogIndent(
		        HGRenderGraphLogIndent *this,
		        HGRenderGraphLogger *logger,
		        int32_t indentation,
		        MethodInfo *method)
		{
		  unsigned int *v4; // r9
		  HGRenderGraphLogger *v5; // rcx
		  __int64 v6; // rdx
		  MethodInfo *v7; // [rsp+20h] [rbp-8h]
		
		  this->m_Disposed = 0;
		  this->m_Indentation = indentation;
		  this->m_Logger = logger;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->m_Logger,
		    (Type *)logger,
		    *(PropertyInfo_1 **)&indentation,
		    (Int32__Array **)this,
		    v7);
		  v5 = (HGRenderGraphLogger *)*((_QWORD *)v4 + 1);
		  v6 = *v4;
		  if ( !v5 )
		    sub_1800D8260(0LL, v6);
		  HG::Rendering::RenderGraphModule::HGRenderGraphLogger::IncrementIndentation(v5, v6, 0LL);
		}
		
	
		// Methods
		[IDTag(1)]
		public void Dispose() {} // 0x0000000189B36CD0-0x0000000189B36D24
		// Void Dispose()
		void HG::Rendering::RenderGraphModule::HGRenderGraphLogIndent::Dispose(
		        HGRenderGraphLogIndent *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(52, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(52, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_28(Patch, this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::RenderGraphModule::HGRenderGraphLogIndent::Dispose(this, 1, 0LL);
		  }
		}
		
		[IDTag(0)]
		private void Dispose(bool disposing) {} // 0x0000000189B36D24-0x0000000189B36D98
		// Void Dispose(Boolean)
		void HG::Rendering::RenderGraphModule::HGRenderGraphLogIndent::Dispose(
		        HGRenderGraphLogIndent *this,
		        bool disposing,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(53, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(53, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_27(Patch, this, disposing, 0LL);
		  }
		  else if ( !this->m_Disposed )
		  {
		    if ( disposing )
		    {
		      if ( this->m_Logger )
		        HG::Rendering::RenderGraphModule::HGRenderGraphLogger::DecrementIndentation(
		          this->m_Logger,
		          this->m_Indentation,
		          0LL);
		    }
		    this->m_Disposed = 1;
		  }
		}
		
	}
}
