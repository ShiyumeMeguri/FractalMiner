using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.RenderGraphModule
{
	internal class IHGRenderGraphResource // TypeDefIndex: 37466
	{
		// Fields
		public bool imported; // 0x10
		public bool preserved; // 0x11
		public bool requestFallBack; // 0x12
		public uint writeCount; // 0x14
		public int cachedHash; // 0x18
		public int transientPassIndex; // 0x1C
		public int preservedExecutorID; // 0x20
		public int preservedExecutorFrameIndex; // 0x24
		public int preservedResourceLifeSpan; // 0x28
		protected IHGRenderGraphResourcePool m_Pool; // 0x30
	
		// Constructors
		public IHGRenderGraphResource() {} // 0x00000001841E1670-0x00000001841E1680
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
		public virtual void Reset(IHGRenderGraphResourcePool pool) {} // 0x0000000189B3EC98-0x0000000189B3ED1C
		// Void Reset(IHGRenderGraphResourcePool)
		void HG::Rendering::RenderGraphModule::IHGRenderGraphResource::Reset(
		        IHGRenderGraphResource *this,
		        IHGRenderGraphResourcePool *pool,
		        MethodInfo *method)
		{
		  Type *v5; // rdx
		  PropertyInfo_1 *v6; // r8
		  Int32__Array **v7; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  MethodInfo *v11; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(295, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(295, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)pool,
		      0LL);
		  }
		  else
		  {
		    *(_WORD *)&this->fields.imported = 0;
		    this->fields.writeCount = 0;
		    this->fields.cachedHash = -1;
		    this->fields.transientPassIndex = -1;
		    this->fields.preservedExecutorID = -1;
		    this->fields.preservedExecutorFrameIndex = -1;
		    this->fields.preservedResourceLifeSpan = -1;
		    this->fields.requestFallBack = 0;
		    this->fields.m_Pool = pool;
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_Pool, v5, v6, v7, v11);
		  }
		}
		
		public virtual string GetName() => default; // 0x0000000189B3E8F8-0x0000000189B3E944
		// String GetName()
		String *HG::Rendering::RenderGraphModule::IHGRenderGraphResource::GetName(
		        IHGRenderGraphResource *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(95, 0LL) )
		    return (String *)"";
		  Patch = IFix::WrappersManagerImpl::GetPatch(95, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, 0LL);
		}
		
		public virtual bool IsCreated() => default; // 0x0000000189B3E9DC-0x0000000189B3EA28
		// Boolean IsCreated()
		bool HG::Rendering::RenderGraphModule::IHGRenderGraphResource::IsCreated(
		        IHGRenderGraphResource *this,
		        MethodInfo *method)
		{
		  bool result; // al
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  result = IFix::WrappersManagerImpl::IsPatched(213, 0LL);
		  if ( result )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(213, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		  }
		  return result;
		}
		
		public virtual void IncrementWriteCount() {} // 0x0000000189B3E990-0x0000000189B3E9DC
		// Void IncrementWriteCount()
		void HG::Rendering::RenderGraphModule::IHGRenderGraphResource::IncrementWriteCount(
		        IHGRenderGraphResource *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(225, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(225, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    ++this->fields.writeCount;
		  }
		}
		
		public virtual bool NeedsFallBack() => default; // 0x0000000189B3EAC8-0x0000000189B3EB24
		// Boolean NeedsFallBack()
		bool HG::Rendering::RenderGraphModule::IHGRenderGraphResource::NeedsFallBack(
		        IHGRenderGraphResource *this,
		        MethodInfo *method)
		{
		  bool result; // al
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  result = IFix::WrappersManagerImpl::IsPatched(241, 0LL);
		  if ( result )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(241, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		  }
		  else if ( this->fields.requestFallBack )
		  {
		    return this->fields.writeCount == 0;
		  }
		  return result;
		}
		
		public void CopyFrom(IHGRenderGraphResource other) {} // 0x0000000189B3E79C-0x0000000189B3E840
		// Void CopyFrom(IHGRenderGraphResource)
		void HG::Rendering::RenderGraphModule::IHGRenderGraphResource::CopyFrom(
		        IHGRenderGraphResource *this,
		        IHGRenderGraphResource *other,
		        MethodInfo *method)
		{
		  Type *v5; // rdx
		  __int64 v6; // rcx
		  PropertyInfo_1 *v7; // r8
		  Int32__Array **v8; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v10; // [rsp+20h] [rbp-8h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(316, 0LL) )
		  {
		    if ( other )
		    {
		      this->fields.imported = other->fields.imported;
		      this->fields.preserved = other->fields.preserved;
		      this->fields.requestFallBack = other->fields.requestFallBack;
		      this->fields.writeCount = other->fields.writeCount;
		      this->fields.cachedHash = other->fields.cachedHash;
		      this->fields.transientPassIndex = other->fields.transientPassIndex;
		      this->fields.preservedExecutorID = other->fields.preservedExecutorID;
		      this->fields.preservedExecutorFrameIndex = other->fields.preservedExecutorFrameIndex;
		      this->fields.preservedResourceLifeSpan = other->fields.preservedResourceLifeSpan;
		      this->fields.m_Pool = other->fields.m_Pool;
		      sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_Pool, v5, v7, v8, v10);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(316, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)other,
		    0LL);
		}
		
		public virtual void CreatePooledGraphicsResource(bool frameRegister = true /* Metadata: 0x02302D8D */, string name = "" /* Metadata: 0x02302D8E */) {} // 0x0000000189B3E894-0x0000000189B3E8F8
		// Void CreatePooledGraphicsResource(Boolean, String)
		void HG::Rendering::RenderGraphModule::IHGRenderGraphResource::CreatePooledGraphicsResource(
		        IHGRenderGraphResource *this,
		        bool frameRegister,
		        String *name,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(81, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(81, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_206(
		      (ILFixDynamicMethodWrapper_6 *)Patch,
		      (Object *)this,
		      frameRegister,
		      (Object *)name,
		      0LL);
		  }
		}
		
		public virtual void CreateGraphicsResource(string name = "" /* Metadata: 0x02302D8F */) {} // 0x0000000189B3E840-0x0000000189B3E894
		// Void CreateGraphicsResource(String)
		void HG::Rendering::RenderGraphModule::IHGRenderGraphResource::CreateGraphicsResource(
		        IHGRenderGraphResource *this,
		        String *name,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(293, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(293, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)name,
		      0LL);
		  }
		}
		
		public virtual void RenameGraphicsResource(string name = "" /* Metadata: 0x02302D90 */) {} // 0x0000000189B3EC44-0x0000000189B3EC98
		// Void RenameGraphicsResource(String)
		void HG::Rendering::RenderGraphModule::IHGRenderGraphResource::RenameGraphicsResource(
		        IHGRenderGraphResource *this,
		        String *name,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(317, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(317, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)name,
		      0LL);
		  }
		}
		
		public virtual void ReleasePooledGraphicsResource(int frameIndex, bool reset = true /* Metadata: 0x02302D91 */) {} // 0x0000000189B3EBE0-0x0000000189B3EC44
		// Void ReleasePooledGraphicsResource(Int32, Boolean)
		void HG::Rendering::RenderGraphModule::IHGRenderGraphResource::ReleasePooledGraphicsResource(
		        IHGRenderGraphResource *this,
		        int32_t frameIndex,
		        bool reset,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(88, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(88, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_28(
		      (ILFixDynamicMethodWrapper_8 *)Patch,
		      (Object *)this,
		      (EnergyShardType__Enum)frameIndex,
		      reset,
		      0LL);
		  }
		}
		
		public virtual void ReleaseGraphicsResource() {} // 0x0000000189B3EB9C-0x0000000189B3EBE0
		// Void ReleaseGraphicsResource()
		void HG::Rendering::RenderGraphModule::IHGRenderGraphResource::ReleaseGraphicsResource(
		        IHGRenderGraphResource *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(318, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(318, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		}
		
		public virtual void Preserve(int currentExecutorID, int currentExecutorFrameIndex, int frameCount) {} // 0x0000000189B3EB24-0x0000000189B3EB9C
		// Void Preserve(Int32, Int32, Int32)
		void HG::Rendering::RenderGraphModule::IHGRenderGraphResource::Preserve(
		        IHGRenderGraphResource *this,
		        int32_t currentExecutorID,
		        int32_t currentExecutorFrameIndex,
		        int32_t frameCount,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(159, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(159, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_247(
		      (ILFixDynamicMethodWrapper_6 *)Patch,
		      (Object *)this,
		      currentExecutorID,
		      currentExecutorFrameIndex,
		      frameCount,
		      0LL);
		  }
		}
		
		public virtual void LogCreation(HGRenderGraphLogger logger) {} // 0x0000000189B3EA28-0x0000000189B3EA78
		// Void LogCreation(HGRenderGraphLogger)
		void HG::Rendering::RenderGraphModule::IHGRenderGraphResource::LogCreation(
		        IHGRenderGraphResource *this,
		        HGRenderGraphLogger *logger,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(82, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(82, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)logger,
		      0LL);
		  }
		}
		
		public virtual void LogRelease(HGRenderGraphLogger logger) {} // 0x0000000189B3EA78-0x0000000189B3EAC8
		// Void LogRelease(HGRenderGraphLogger)
		void HG::Rendering::RenderGraphModule::IHGRenderGraphResource::LogRelease(
		        IHGRenderGraphResource *this,
		        HGRenderGraphLogger *logger,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(87, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(87, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)logger,
		      0LL);
		  }
		}
		
		public virtual int GetSortIndex() => default; // 0x0000000189B3E944-0x0000000189B3E990
		// Int32 GetSortIndex()
		int32_t HG::Rendering::RenderGraphModule::IHGRenderGraphResource::GetSortIndex(
		        IHGRenderGraphResource *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(319, 0LL) )
		    return 0;
		  Patch = IFix::WrappersManagerImpl::GetPatch(319, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		}
		
	}
}
