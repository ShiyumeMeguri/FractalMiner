using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.RenderGraphModule
{
	[DebuggerDisplay("ComputeBufferResource ({desc.name})")]
	internal class ComputeBufferResource : HGRenderGraphResource<HG.Rendering.RenderGraphModule.ComputeBufferDesc, ComputeBuffer> // TypeDefIndex: 37452
	{
		// Constructors
		public ComputeBufferResource() {} // 0x00000001841E1670-0x00000001841E1680
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
		public override string GetName() => default; // 0x0000000189B3534C-0x0000000189B353AC
		// String GetName()
		String *HG::Rendering::RenderGraphModule::ComputeBufferResource::GetName(
		        ComputeBufferResource *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(291, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(291, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, 0LL);
		  }
		  else if ( this->fields._._.imported )
		  {
		    return (String *)"ImportedComputeBuffer";
		  }
		  else
		  {
		    return this->fields._.desc.name;
		  }
		}
		
		public override void CreatePooledGraphicsResource(bool frameRegister = true /* Metadata: 0x02302D71 */, string name = "" /* Metadata: 0x02302D72 */) {} // 0x0000000189B351E0-0x0000000189B3534C
		// Void CreatePooledGraphicsResource(Boolean, String)
		void HG::Rendering::RenderGraphModule::ComputeBufferResource::CreatePooledGraphicsResource(
		        ComputeBufferResource *this,
		        bool frameRegister,
		        String *name,
		        MethodInfo *method)
		{
		  int32_t HashCode; // edi
		  RenderGraphResourcePool_1_System_Object_ *v8; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  RenderGraphResourcePool_1_System_Object_ *v11; // rsi
		  Object *v12; // rbx
		  String *v13; // rax
		  String *v14; // rdi
		  __int64 v15; // rax
		  ProtocolViolationException *v16; // rax
		  ProtocolViolationException *v17; // rbx
		  __int64 v18; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(292, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(292, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_206(
		        (ILFixDynamicMethodWrapper_6 *)Patch,
		        (Object *)this,
		        frameRegister,
		        (Object *)name,
		        0LL);
		      return;
		    }
		LABEL_11:
		    sub_1800D8260(v10, v9);
		  }
		  HashCode = HG::Rendering::RenderGraphModule::ComputeBufferDesc::GetHashCode(&this->fields._.desc, 0LL);
		  if ( this->fields._.graphicsResource )
		  {
		    v12 = (Object *)sub_180032CB0(5LL, this);
		    v13 = (String *)sub_18007E180(&off_18E25BED0);
		    v14 = System::String::Format(v13, v12, 0LL);
		    v15 = sub_18007E180(&TypeInfo::System::InvalidOperationException);
		    v16 = (ProtocolViolationException *)sub_18002C620(v15);
		    v17 = v16;
		    if ( v16 )
		    {
		      System::Net::ProtocolViolationException::ProtocolViolationException(v16, v14, 0LL);
		      v18 = sub_18007E180(&MethodInfo::HG::Rendering::RenderGraphModule::ComputeBufferResource::CreatePooledGraphicsResource);
		      sub_18007E190(v17, v18);
		    }
		    goto LABEL_11;
		  }
		  v8 = (RenderGraphResourcePool_1_System_Object_ *)sub_180005050(
		                                                     this->fields._._.m_Pool,
		                                                     TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferPool);
		  v11 = v8;
		  if ( !v8 )
		    goto LABEL_11;
		  if ( !UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraphResourcePool<System::Object>::TryGetResource(
		          v8,
		          HashCode,
		          (Object **)&this->fields._.graphicsResource,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourcePool<UnityEngine::ComputeBuffer>::TryGetResource) )
		    sub_180052100(10LL, this, name);
		  this->fields._._.cachedHash = HashCode;
		  if ( frameRegister )
		    UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraphResourcePool<System::Object>::RegisterFrameAllocation(
		      v11,
		      HashCode,
		      (Object *)this->fields._.graphicsResource,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourcePool<UnityEngine::ComputeBuffer>::RegisterFrameAllocation);
		}
		
		public override void ReleasePooledGraphicsResource(int frameIndex, bool reset = true /* Metadata: 0x02302D73 */) {} // 0x0000000189B35530-0x0000000189B35690
		// Void ReleasePooledGraphicsResource(Int32, Boolean)
		void HG::Rendering::RenderGraphModule::ComputeBufferResource::ReleasePooledGraphicsResource(
		        ComputeBufferResource *this,
		        int32_t frameIndex,
		        bool reset,
		        MethodInfo *method)
		{
		  RenderGraphResourcePool_1_System_Object_ *v7; // rax
		  __int64 v8; // rcx
		  RenderGraphResourcePool_1_System_Object_ *v9; // rdi
		  String *v10; // rdi
		  String *v11; // rbx
		  String *v12; // rax
		  String *v13; // rdi
		  __int64 v14; // rax
		  ProtocolViolationException *v15; // rax
		  __int64 v16; // rdx
		  __int64 v17; // rcx
		  ProtocolViolationException *v18; // rbx
		  __int64 v19; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(294, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(294, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_28(
		        (ILFixDynamicMethodWrapper_8 *)Patch,
		        (Object *)this,
		        (EnergyShardType__Enum)frameIndex,
		        reset,
		        0LL);
		      return;
		    }
		LABEL_10:
		    sub_1800D8260(v17, v16);
		  }
		  if ( !this->fields._.graphicsResource )
		  {
		    v10 = (String *)sub_180032CB0(5LL, this);
		    v11 = (String *)sub_18007E180(&off_18E25BE48);
		    v12 = (String *)sub_18007E180(&off_18E25BE58);
		    v13 = System::String::Concat(v12, v10, v11, 0LL);
		    v14 = sub_18007E180(&TypeInfo::System::InvalidOperationException);
		    v15 = (ProtocolViolationException *)sub_18002C620(v14);
		    v18 = v15;
		    if ( v15 )
		    {
		      System::Net::ProtocolViolationException::ProtocolViolationException(v15, v13, 0LL);
		      v19 = sub_18007E180(&MethodInfo::HG::Rendering::RenderGraphModule::ComputeBufferResource::ReleasePooledGraphicsResource);
		      sub_18007E190(v18, v19);
		    }
		    goto LABEL_10;
		  }
		  v7 = (RenderGraphResourcePool_1_System_Object_ *)sub_180005050(
		                                                     this->fields._._.m_Pool,
		                                                     TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferPool);
		  v9 = v7;
		  if ( v7 )
		  {
		    UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraphResourcePool<System::Object>::ReleaseResource(
		      v7,
		      this->fields._._.cachedHash,
		      (Object *)this->fields._.graphicsResource,
		      frameIndex,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourcePool<UnityEngine::ComputeBuffer>::ReleaseResource);
		    UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraphResourcePool<System::Object>::UnregisterFrameAllocation(
		      v9,
		      this->fields._._.cachedHash,
		      (Object *)this->fields._.graphicsResource,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourcePool<UnityEngine::ComputeBuffer>::UnregisterFrameAllocation);
		  }
		  if ( reset )
		    sub_180082E60(v8, this, 0LL);
		}
		
		public override void CreateGraphicsResource(string name = "" /* Metadata: 0x02302D74 */) {} // 0x0000000189B35024-0x0000000189B351E0
		// Void CreateGraphicsResource(String)
		void HG::Rendering::RenderGraphModule::ComputeBufferResource::CreateGraphicsResource(
		        ComputeBufferResource *this,
		        String *name,
		        MethodInfo *method)
		{
		  int32_t count; // esi
		  int32_t stride; // r14d
		  unsigned int type; // r15d
		  ComputeBuffer *v8; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  ComputeBuffer *v11; // rbx
		  Type *v12; // rdx
		  PropertyInfo_1 *v13; // r8
		  Int32__Array **v14; // r9
		  ComputeBuffer *graphicsResource; // r14
		  __int64 v16; // rax
		  Object__Array *v17; // rsi
		  __int64 v18; // rbx
		  __int64 v19; // rbx
		  __int64 v20; // rbx
		  String *v21; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v23; // [rsp+20h] [rbp-28h]
		  int32_t v24; // [rsp+68h] [rbp+20h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(296, 0LL) )
		  {
		    count = this->fields._.desc.count;
		    stride = this->fields._.desc.stride;
		    type = this->fields._.desc.type;
		    v8 = (ComputeBuffer *)sub_18002C620(TypeInfo::UnityEngine::ComputeBuffer);
		    v11 = v8;
		    if ( v8 )
		    {
		      UnityEngine::ComputeBuffer::ComputeBuffer(v8, count, stride, (ComputeBufferType__Enum)type, 0LL);
		      this->fields._.graphicsResource = v11;
		      sub_18002D1B0((SingleFieldAccessor *)&this->fields._.graphicsResource, v12, v13, v14, v23);
		      graphicsResource = this->fields._.graphicsResource;
		      v16 = il2cpp_array_new_specific_1(TypeInfo::System::Object, 4LL);
		      v17 = (Object__Array *)v16;
		      if ( v16 )
		      {
		        sub_180031B10(v16, name);
		        sub_180005370(v17, 0LL, name);
		        v24 = this->fields._.desc.count;
		        v18 = il2cpp_value_box_0(TypeInfo::System::Int32, &v24);
		        sub_180031B10(v17, v18);
		        sub_180005370(v17, 1LL, v18);
		        v24 = this->fields._.desc.stride;
		        v19 = il2cpp_value_box_0(TypeInfo::System::Int32, &v24);
		        sub_180031B10(v17, v19);
		        sub_180005370(v17, 2LL, v19);
		        v24 = this->fields._.desc.type;
		        v20 = il2cpp_value_box_0(TypeInfo::UnityEngine::ComputeBufferType, &v24);
		        sub_180031B10(v17, v20);
		        sub_180005370(v17, 3LL, v20);
		        v21 = System::String::Format((String *)"{0}-RenderGraphComputeBuffer_{1}_{2}_{3}", v17, 0LL);
		        if ( graphicsResource )
		        {
		          UnityEngine::ComputeBuffer::SetName(graphicsResource, v21, 0LL);
		          return;
		        }
		      }
		    }
		LABEL_7:
		    sub_1800D8260(v10, v9);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(296, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)name,
		    0LL);
		}
		
		public override void ReleaseGraphicsResource() {} // 0x0000000189B354CC-0x0000000189B35530
		// Void ReleaseGraphicsResource()
		void HG::Rendering::RenderGraphModule::ComputeBufferResource::ReleaseGraphicsResource(
		        ComputeBufferResource *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(297, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(297, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    if ( this->fields._.graphicsResource )
		      UnityEngine::ComputeBuffer::Dispose(this->fields._.graphicsResource, 0LL);
		    this->fields._.graphicsResource = 0LL;
		  }
		}
		
		public override void LogCreation(HGRenderGraphLogger logger) {} // 0x0000000189B353AC-0x0000000189B3543C
		// Void LogCreation(HGRenderGraphLogger)
		void HG::Rendering::RenderGraphModule::ComputeBufferResource::LogCreation(
		        ComputeBufferResource *this,
		        HGRenderGraphLogger *logger,
		        MethodInfo *method)
		{
		  String *v5; // rdi
		  Object__Array *v6; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(298, 0LL) )
		  {
		    v5 = System::String::Concat((String *)"Created ComputeBuffer: ", this->fields._.desc.name, 0LL);
		    v6 = (Object__Array *)sub_183AD6530(MethodInfo::System::Array::Empty<System::Object>);
		    if ( logger )
		    {
		      HG::Rendering::RenderGraphModule::HGRenderGraphLogger::LogLine(logger, v5, v6, 0LL);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(v8, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(298, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)logger,
		    0LL);
		}
		
		public override void LogRelease(HGRenderGraphLogger logger) {} // 0x0000000189B3543C-0x0000000189B354CC
		// Void LogRelease(HGRenderGraphLogger)
		void HG::Rendering::RenderGraphModule::ComputeBufferResource::LogRelease(
		        ComputeBufferResource *this,
		        HGRenderGraphLogger *logger,
		        MethodInfo *method)
		{
		  String *v5; // rdi
		  Object__Array *v6; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(299, 0LL) )
		  {
		    v5 = System::String::Concat((String *)"Released ComputeBuffer: ", this->fields._.desc.name, 0LL);
		    v6 = (Object__Array *)sub_183AD6530(MethodInfo::System::Array::Empty<System::Object>);
		    if ( logger )
		    {
		      HG::Rendering::RenderGraphModule::HGRenderGraphLogger::LogLine(logger, v5, v6, 0LL);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(v8, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(299, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)logger,
		    0LL);
		}
		
		public string __iFixBaseProxy_GetName() => default; // 0x0000000189B356A0-0x0000000189B356A8
		// String <>iFixBaseProxy_GetName()
		String *HG::Rendering::RenderGraphModule::TextureResource::__iFixBaseProxy_GetName(
		        TextureResource *this,
		        MethodInfo *method)
		{
		  return HG::Rendering::RenderGraphModule::IHGRenderGraphResource::GetName((IHGRenderGraphResource *)this, 0LL);
		}
		
		public void __iFixBaseProxy_CreatePooledGraphicsResource(bool P0, string P1) {} // 0x0000000189B35698-0x0000000189B356A0
		// Void <>iFixBaseProxy_CreatePooledGraphicsResource(Boolean, String)
		void HG::Rendering::RenderGraphModule::TextureResource::__iFixBaseProxy_CreatePooledGraphicsResource(
		        TextureResource *this,
		        bool P0,
		        String *P1,
		        MethodInfo *method)
		{
		  HG::Rendering::RenderGraphModule::IHGRenderGraphResource::CreatePooledGraphicsResource(
		    (IHGRenderGraphResource *)this,
		    P0,
		    P1,
		    0LL);
		}
		
		public void __iFixBaseProxy_ReleasePooledGraphicsResource(int P0, bool P1) {} // 0x0000000189B356C0-0x0000000189B356C8
		// Void <>iFixBaseProxy_ReleasePooledGraphicsResource(Int32, Boolean)
		void HG::Rendering::RenderGraphModule::TextureResource::__iFixBaseProxy_ReleasePooledGraphicsResource(
		        TextureResource *this,
		        int32_t P0,
		        bool P1,
		        MethodInfo *method)
		{
		  HG::Rendering::RenderGraphModule::IHGRenderGraphResource::ReleasePooledGraphicsResource(
		    (IHGRenderGraphResource *)this,
		    P0,
		    P1,
		    0LL);
		}
		
		public void __iFixBaseProxy_CreateGraphicsResource(string P0) {} // 0x0000000189B35690-0x0000000189B35698
		// Void <>iFixBaseProxy_CreateGraphicsResource(String)
		void HG::Rendering::RenderGraphModule::TextureResource::__iFixBaseProxy_CreateGraphicsResource(
		        TextureResource *this,
		        String *P0,
		        MethodInfo *method)
		{
		  HG::Rendering::RenderGraphModule::IHGRenderGraphResource::CreateGraphicsResource(
		    (IHGRenderGraphResource *)this,
		    P0,
		    0LL);
		}
		
		public void __iFixBaseProxy_ReleaseGraphicsResource() {} // 0x0000000189B356B8-0x0000000189B356C0
		// Void <>iFixBaseProxy_ReleaseGraphicsResource()
		void HG::Rendering::RenderGraphModule::ComputeBufferResource::__iFixBaseProxy_ReleaseGraphicsResource(
		        ComputeBufferResource *this,
		        MethodInfo *method)
		{
		  HG::Rendering::RenderGraphModule::ComputeBufferResource::ReleaseGraphicsResource(this, 0LL);
		}
		
		public void __iFixBaseProxy_LogCreation(HGRenderGraphLogger P0) {} // 0x0000000189B356A8-0x0000000189B356B0
		// Void <>iFixBaseProxy_LogCreation(HGRenderGraphLogger)
		void HG::Rendering::RenderGraphModule::TextureResource::__iFixBaseProxy_LogCreation(
		        TextureResource *this,
		        HGRenderGraphLogger *P0,
		        MethodInfo *method)
		{
		  HG::Rendering::RenderGraphModule::IHGRenderGraphResource::LogCreation((IHGRenderGraphResource *)this, P0, 0LL);
		}
		
		public void __iFixBaseProxy_LogRelease(HGRenderGraphLogger P0) {} // 0x0000000189B356B0-0x0000000189B356B8
		// Void <>iFixBaseProxy_LogRelease(HGRenderGraphLogger)
		void HG::Rendering::RenderGraphModule::TextureResource::__iFixBaseProxy_LogRelease(
		        TextureResource *this,
		        HGRenderGraphLogger *P0,
		        MethodInfo *method)
		{
		  HG::Rendering::RenderGraphModule::IHGRenderGraphResource::LogRelease((IHGRenderGraphResource *)this, P0, 0LL);
		}
		
	}
}
