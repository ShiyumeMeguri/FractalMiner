using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGTerrainStreamingManager : IDisposable // TypeDefIndex: 38650
	{
		// Fields
		public string atlasPageRootPath; // 0x10
	
		// Constructors
		public HGTerrainStreamingManager() {} // 0x00000001841E1670-0x00000001841E1680
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
		public void EarlyUpdate() {} // 0x0000000183335D40-0x0000000183335D90
		// Void EarlyUpdate()
		void HG::Rendering::Runtime::HGTerrainStreamingManager::EarlyUpdate(
		        HGTerrainStreamingManager *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_6;
		  if ( wrapperArray->max_length.size <= 2286 )
		    return;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  if ( LODWORD(v3->_0.namespaze) <= 0x8EE )
		    sub_1800D2AB0(v3, method);
		  if ( *(_QWORD *)&v3[48]._1.thread_static_fields_offset )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2286, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		      return;
		    }
		    goto LABEL_6;
		  }
		}
		
		public void GameplayUpdate() {} // 0x00000001832E1110-0x00000001832E1160
		// Void GameplayUpdate()
		void HG::Rendering::Runtime::HGTerrainStreamingManager::GameplayUpdate(
		        HGTerrainStreamingManager *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_6;
		  if ( wrapperArray->max_length.size <= 2296 )
		    return;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  if ( LODWORD(v3->_0.namespaze) <= 0x8F8 )
		    sub_1800D2AB0(v3, method);
		  if ( v3[48].vtable.GetHashCode.method )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2296, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		      return;
		    }
		    goto LABEL_6;
		  }
		}
		
		public void Dispose() {} // 0x00000001837E3130-0x00000001837E3170
		// Void Dispose()
		void HG::Rendering::Runtime::HGTerrainStreamingManager::Dispose(HGTerrainStreamingManager *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2268, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2268, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::HGTerrainStreamingManager::CleanupPendingRequests(this, 0LL);
		  }
		}
		
		public void CleanupPendingRequests() {} // 0x00000001837E3170-0x00000001837E31B0
		// Void CleanupPendingRequests()
		void HG::Rendering::Runtime::HGTerrainStreamingManager::CleanupPendingRequests(
		        HGTerrainStreamingManager *this,
		        MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v3; // rdx
		  HGRuntimeGrassQuery_Node *v4; // r8
		  Int32__Array **v5; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  MethodInfo *v9; // [rsp+50h] [rbp+28h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2269, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2269, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    this->fields.atlasPageRootPath = 0LL;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields, v3, v4, v5, v9);
		  }
		}
		
	}
}
