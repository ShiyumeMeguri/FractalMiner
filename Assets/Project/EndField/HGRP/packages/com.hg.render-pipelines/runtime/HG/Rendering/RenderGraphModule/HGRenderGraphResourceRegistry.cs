using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.RendererUtils;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.RenderGraphModule
{
	internal class HGRenderGraphResourceRegistry // TypeDefIndex: 37461
	{
		// Fields
		private const int MAXIMUM_PRESERVED_RESOURCE_COUNT = 64; // Metadata: 0x02302D79
		private static HGRenderGraphResourceRegistry m_CurrentRegistry; // 0x00
		private HGRenderGraphResourcesData[] m_RenderGraphResources; // 0x10
		private DynamicArray<RendererListResource> m_RendererListResources; // 0x18
		private HGRenderGraphDebugParams m_RenderGraphDebug; // 0x20
		private HGRenderGraphLogger m_ResourceLogger; // 0x28
		private HGRenderGraphLogger m_FrameInformationLogger; // 0x30
		private int m_CurrentFrameIndex; // 0x38
		private int m_ExecutionCount; // 0x3C
		private int m_currentExecutorID; // 0x40
		private int m_currentExecutorFrameIndex; // 0x44
		private RTHandle[] m_CurrentBackbuffer; // 0x48
		private const int kInitialRendererListCount = 256; // Metadata: 0x02302D7B
		private List<RendererList> m_ActiveRendererLists; // 0x50
	
		// Properties
		internal static HGRenderGraphResourceRegistry current { get => default; set {} } // 0x0000000189B3BDE8-0x0000000189B3BE38 0x0000000189B3BE38-0x0000000189B3BEA0
		// HGRenderGraphResourceRegistry get_current()
		HGRenderGraphResourceRegistry *HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::get_current(
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(287, 0LL) )
		    return TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry->static_fields->m_CurrentRegistry;
		  Patch = IFix::WrappersManagerImpl::GetPatch(287, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v4, v3);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_136(Patch, 0LL);
		}
		

		// Void set_current(HGRenderGraphResourceRegistry)
		void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::set_current(
		        HGRenderGraphResourceRegistry *value,
		        MethodInfo *method)
		{
		  PropertyInfo_1 *v3; // r8
		  Int32__Array **v4; // r9
		  Type *static_fields; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  MethodInfo *v9; // [rsp+50h] [rbp+28h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(74, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(74, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)value, 0LL);
		  }
		  else
		  {
		    static_fields = (Type *)TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry->static_fields;
		    static_fields->klass = (Type__Class *)value;
		    sub_18002D1B0(
		      (SingleFieldAccessor *)TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry->static_fields,
		      static_fields,
		      v3,
		      v4,
		      v9);
		  }
		}
		
	
		// Nested types
		internal enum BackBufferType // TypeDefIndex: 37458
		{
			Color = 0,
			Depth = 1,
			Count = 2
		}
	
		private delegate void ResourceCallback(HGRenderGraphContext rgContext, IHGRenderGraphResource res); // TypeDefIndex: 37459; 0x00000001838E1420-0x00000001838E1430
	
		private class HGRenderGraphResourcesData // TypeDefIndex: 37460
		{
			// Fields
			public DynamicArray<IHGRenderGraphResource> resourceArray; // 0x10
			public IHGRenderGraphResourcePool pool; // 0x18
			public ResourceCallback createResourceCallback; // 0x20
			public ResourceCallback releaseResourceCallback; // 0x28
	
			// Constructors
			public HGRenderGraphResourcesData() {} // 0x0000000183947030-0x00000001839470A0
			// HGRenderGraphResourceRegistry+HGRenderGraphResourcesData()
			void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::HGRenderGraphResourcesData::HGRenderGraphResourcesData(
			        HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *this,
			        MethodInfo *method)
			{
			  DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo_ *v3; // rax
			  __int64 v4; // rdx
			  DynamicArray_1_HG_Rendering_RenderGraphModule_IHGRenderGraphResource_ *resourceArray; // rcx
			  DynamicArray_1_HG_Rendering_RenderGraphModule_IHGRenderGraphResource_ *v6; // rbx
			  Type *v7; // rdx
			  PropertyInfo_1 *v8; // r8
			  Int32__Array **v9; // r9
			  MethodInfo *v10; // [rsp+20h] [rbp-8h]
			
			  v3 = (DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo_ *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>);
			  v6 = (DynamicArray_1_HG_Rendering_RenderGraphModule_IHGRenderGraphResource_ *)v3;
			  if ( !v3
			    || (UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::DynamicArray(
			          v3,
			          MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::DynamicArray),
			        this->fields.resourceArray = v6,
			        sub_18002D1B0((SingleFieldAccessor *)&this->fields, v7, v8, v9, v10),
			        (resourceArray = this->fields.resourceArray) == 0LL) )
			  {
			    sub_1800D8260(resourceArray, v4);
			  }
			  UnityEngine::Rendering::DynamicArray<System::Object>::Resize(
			    (DynamicArray_1_System_Object_ *)resourceArray,
			    64,
			    0,
			    MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::Resize);
			}
			
	
			// Methods
			public void Clear(bool onException, int frameIndex) {} // 0x0000000189B3BEA0-0x0000000189B3BF3C
			// Void Clear(Boolean, Int32)
			void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::HGRenderGraphResourcesData::Clear(
			        HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *this,
			        bool onException,
			        int32_t frameIndex,
			        MethodInfo *method)
			{
			  IHGRenderGraphResourcePool *pool; // rdx
			  DynamicArray_1_HG_Rendering_RenderGraphModule_IHGRenderGraphResource_ *resourceArray; // rcx
			  __int64 v9; // r8
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(105, 0LL) )
			  {
			    resourceArray = this->fields.resourceArray;
			    if ( resourceArray )
			    {
			      UnityEngine::Rendering::DynamicArray<System::Object>::Resize(
			        (DynamicArray_1_System_Object_ *)resourceArray,
			        64,
			        0,
			        MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::Resize);
			      pool = this->fields.pool;
			      if ( pool )
			      {
			        LOBYTE(v9) = onException;
			        sub_1800D99B0(6LL, pool, v9, (unsigned int)frameIndex);
			        return;
			      }
			    }
			LABEL_6:
			    sub_1800D8260(resourceArray, pool);
			  }
			  Patch = IFix::WrappersManagerImpl::GetPatch(105, 0LL);
			  if ( !Patch )
			    goto LABEL_6;
			  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_316(
			    (ILFixDynamicMethodWrapper_6 *)Patch,
			    (Object *)this,
			    onException,
			    frameIndex,
			    0LL);
			}
			
			public void Cleanup() {} // 0x0000000183945480-0x00000001839454D0
			// Void Cleanup()
			void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::HGRenderGraphResourcesData::Cleanup(
			        HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *this,
			        MethodInfo *method)
			{
			  __int64 v3; // rcx
			  IHGRenderGraphResourcePool *pool; // rdx
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(125, 0LL) )
			  {
			    pool = this->fields.pool;
			    if ( pool )
			    {
			      sub_180003290(5LL, pool);
			      return;
			    }
			LABEL_4:
			    sub_1800D8260(v3, pool);
			  }
			  Patch = IFix::WrappersManagerImpl::GetPatch(125, 0LL);
			  if ( !Patch )
			    goto LABEL_4;
			  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
			}
			
			public void PurgeUnusedGraphicsResources(int frameIndex) {} // 0x0000000183946DB0-0x0000000183947030
			// Void PurgeUnusedGraphicsResources(Int32)
			// local variable allocation has failed, the output may be wrong!
			void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::HGRenderGraphResourcesData::PurgeUnusedGraphicsResources(
			        HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *this,
			        int32_t frameIndex,
			        MethodInfo *method)
			{
			  LoginSceneAnimCtrl_EState__Enum v4; // edi
			  _QWORD **v5; // rcx
			  __int64 v6; // r8
			  Object *pool; // rbx
			  void (*gc_desc)(AbilityAction *, AbilityAction_ResetReason__Enum, MethodInfo *); // r9
			  const char *name; // r8
			  unsigned __int8 (__fastcall *v10)(MonitorData *, _QWORD, const char *); // rax
			  MonitorData *monitor; // rsi
			  MonitorData *v12; // rsi
			  int (__fastcall *v13)(MonitorData *); // rax
			  MonitorData *v14; // rbx
			  void (__fastcall *v15)(MonitorData *, _QWORD); // rax
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  ILFixDynamicMethodWrapper_9 *v17; // rax
			  __int64 v18; // rax
			  __int64 v19; // rax
			  __int64 v20; // rax
			
			  v4 = frameIndex;
			  v5 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
			    v5 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  v6 = *v5[23];
			  if ( !v6 )
			    goto LABEL_34;
			  if ( *(int *)(v6 + 24) > 134 )
			  {
			    if ( !*((_DWORD *)v5 + 56) )
			    {
			      il2cpp_runtime_class_init_1(v5);
			      v5 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			    }
			    *(_QWORD *)&frameIndex = *v5[23];
			    if ( !*(_QWORD *)&frameIndex )
			      goto LABEL_34;
			    if ( *(_DWORD *)(*(_QWORD *)&frameIndex + 24LL) <= 0x86u )
			      goto LABEL_68;
			    if ( *(_QWORD *)(*(_QWORD *)&frameIndex + 1104LL) )
			    {
			      Patch = IFix::WrappersManagerImpl::GetPatch(134, 0LL);
			      if ( Patch )
			      {
			        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, v4, 0LL);
			        return;
			      }
			      goto LABEL_34;
			    }
			  }
			  pool = (Object *)this->fields.pool;
			  if ( !pool )
			    goto LABEL_34;
			  sub_1800049A0(pool->klass);
			  gc_desc = (void (*)(AbilityAction *, AbilityAction_ResetReason__Enum, MethodInfo *))pool->klass[1]._0.gc_desc;
			  name = pool->klass[1]._0.name;
			  if ( gc_desc == Beyond::Gameplay::Core::AbilityAction::OnReset )
			  {
			    v5 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
			    {
			      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
			      v5 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			    }
			    *(_QWORD *)&frameIndex = *v5[23];
			    if ( !*(_QWORD *)&frameIndex )
			      goto LABEL_34;
			    if ( *(int *)(*(_QWORD *)&frameIndex + 24LL) <= 3739 )
			      return;
			    if ( !*((_DWORD *)v5 + 56) )
			    {
			      il2cpp_runtime_class_init_1(v5);
			      v5 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			    }
			    *(_QWORD *)&frameIndex = *v5[23];
			    if ( !*(_QWORD *)&frameIndex )
			      goto LABEL_34;
			    if ( *(_DWORD *)(*(_QWORD *)&frameIndex + 24LL) > 0xE9Bu )
			    {
			      if ( !*(_QWORD *)(*(_QWORD *)&frameIndex + 29944LL) )
			        return;
			      v17 = (ILFixDynamicMethodWrapper_9 *)IFix::WrappersManagerImpl::GetPatch(3739, 0LL);
			      if ( !v17 )
			        goto LABEL_34;
			      goto LABEL_70;
			    }
			    goto LABEL_68;
			  }
			  if ( (char *)gc_desc == (char *)Beyond::Gameplay::Core::Skill::OnAbilitySystemEvent )
			  {
			    v5 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
			    {
			      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
			      v5 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			    }
			    *(_QWORD *)&frameIndex = *v5[23];
			    if ( !*(_QWORD *)&frameIndex )
			      goto LABEL_34;
			    if ( *(int *)(*(_QWORD *)&frameIndex + 24LL) <= 3816 )
			      return;
			    if ( !*((_DWORD *)v5 + 56) )
			    {
			      il2cpp_runtime_class_init_1(v5);
			      v5 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			    }
			    *(_QWORD *)&frameIndex = *v5[23];
			    if ( !*(_QWORD *)&frameIndex )
			      goto LABEL_34;
			    if ( *(_DWORD *)(*(_QWORD *)&frameIndex + 24LL) > 0xEE8u )
			    {
			      if ( !*(_QWORD *)(*(_QWORD *)&frameIndex + 30560LL) )
			        return;
			      v17 = (ILFixDynamicMethodWrapper_9 *)IFix::WrappersManagerImpl::GetPatch(3816, 0LL);
			      if ( !v17 )
			        goto LABEL_34;
			      goto LABEL_70;
			    }
			LABEL_68:
			    sub_1800D2AB0(v5, *(_QWORD *)&frameIndex);
			  }
			  if ( (char *)gc_desc != (char *)Beyond::Resource::Runtime::BundleLoader::AssetProxy::SetPriority )
			  {
			    ((void (__fastcall *)(Object *, _QWORD, const char *))gc_desc)(pool, v4, name);
			    return;
			  }
			  v5 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
			    v5 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  *(_QWORD *)&frameIndex = *v5[23];
			  if ( !*(_QWORD *)&frameIndex )
			    goto LABEL_34;
			  if ( *(int *)(*(_QWORD *)&frameIndex + 24LL) > 3037 )
			  {
			    if ( !*((_DWORD *)v5 + 56) )
			    {
			      il2cpp_runtime_class_init_1(v5);
			      v5 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			    }
			    v5 = (_QWORD **)*v5[23];
			    if ( !v5 )
			      goto LABEL_34;
			    if ( *((_DWORD *)v5 + 6) <= 0xBDDu )
			      goto LABEL_68;
			    if ( !v5[3041] )
			      goto LABEL_25;
			    v17 = (ILFixDynamicMethodWrapper_9 *)IFix::WrappersManagerImpl::GetPatch(3037, 0LL);
			    if ( !v17 )
			      goto LABEL_34;
			LABEL_70:
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_157(v17, pool, v4, 0LL);
			    return;
			  }
			LABEL_25:
			  if ( pool[13].monitor )
			  {
			    v10 = (unsigned __int8 (__fastcall *)(MonitorData *, _QWORD, const char *))qword_18F36FB90;
			    monitor = pool[13].monitor;
			    if ( !qword_18F36FB90 )
			    {
			      v10 = (unsigned __int8 (__fastcall *)(MonitorData *, _QWORD, const char *))il2cpp_resolve_icall_1(
			                                                                                   "UnityEngine.AsyncOperation::get_isDone()");
			      if ( !v10 )
			      {
			        v18 = sub_1802EE1B8("UnityEngine.AsyncOperation::get_isDone()");
			        sub_18007E1B0(v18, 0LL);
			      }
			      qword_18F36FB90 = (__int64)v10;
			    }
			    if ( !v10(monitor, *(_QWORD *)&frameIndex, name) )
			    {
			      v12 = pool[13].monitor;
			      if ( !v12 )
			        goto LABEL_34;
			      v13 = (int (__fastcall *)(MonitorData *))qword_18F36FB98;
			      if ( !qword_18F36FB98 )
			      {
			        v13 = (int (__fastcall *)(MonitorData *))il2cpp_resolve_icall_1("UnityEngine.AsyncOperation::get_priority()");
			        if ( !v13 )
			        {
			          v19 = sub_1802EE1B8("UnityEngine.AsyncOperation::get_priority()");
			          sub_18007E1B0(v19, 0LL);
			        }
			        qword_18F36FB98 = (__int64)v13;
			      }
			      if ( v13(v12) < (int)v4 )
			      {
			        v14 = pool[13].monitor;
			        if ( v14 )
			        {
			          v15 = (void (__fastcall *)(MonitorData *, _QWORD))qword_18F36FBA0;
			          if ( !qword_18F36FBA0 )
			          {
			            v15 = (void (__fastcall *)(MonitorData *, _QWORD))il2cpp_resolve_icall_1("UnityEngine.AsyncOperation::set_priority(System.Int32)");
			            if ( !v15 )
			            {
			              v20 = sub_1802EE1B8("UnityEngine.AsyncOperation::set_priority(System.Int32)");
			              sub_18007E1B0(v20, 0LL);
			            }
			            qword_18F36FBA0 = (__int64)v15;
			          }
			          v15(v14, v4);
			          return;
			        }
			LABEL_34:
			        sub_1800D8260(v5, *(_QWORD *)&frameIndex);
			      }
			    }
			  }
			}
			
			public int AddNewRenderGraphResource<ResType>(out ref ResType outRes, bool pooledResource = true /* Metadata: 0x02302D80 */)
				where ResType : IHGRenderGraphResource, new() {
				outRes = default;
				return default;
			}
		}
	
		// Constructors
		private HGRenderGraphResourceRegistry() {} // 0x0000000189B3BCF8-0x0000000189B3BDE8
		// HGRenderGraphResourceRegistry()
		void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::HGRenderGraphResourceRegistry(
		        HGRenderGraphResourceRegistry *this,
		        MethodInfo *method)
		{
		  Type *v3; // rdx
		  PropertyInfo_1 *v4; // r8
		  Int32__Array **v5; // r9
		  DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo_ *v6; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  DynamicArray_1_HG_Rendering_RenderGraphModule_RendererListResource_ *v9; // rdi
		  Type *v10; // rdx
		  PropertyInfo_1 *v11; // r8
		  Int32__Array **v12; // r9
		  HGRenderGraphLogger *v13; // rax
		  HGRenderGraphLogger *v14; // rdi
		  Type *v15; // rdx
		  PropertyInfo_1 *v16; // r8
		  Int32__Array **v17; // r9
		  Type *v18; // rdx
		  PropertyInfo_1 *v19; // r8
		  Int32__Array **v20; // r9
		  List_1_Beyond_Gameplay_Factory_ECSVATFSM_VATFSMProcessor_SetAnimatorParamRequest_ *v21; // rax
		  List_1_UnityEngine_Rendering_RendererUtils_RendererList_ *v22; // rdi
		  Type *v23; // rdx
		  PropertyInfo_1 *v24; // r8
		  Int32__Array **v25; // r9
		  MethodInfo *v26; // [rsp+20h] [rbp-8h]
		  MethodInfo *v27; // [rsp+20h] [rbp-8h]
		  MethodInfo *v28; // [rsp+20h] [rbp-8h]
		  MethodInfo *v29; // [rsp+20h] [rbp-8h]
		  MethodInfo *v30; // [rsp+50h] [rbp+28h]
		
		  this->fields.m_RenderGraphResources = (HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *)il2cpp_array_new_specific_1(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::HGRenderGraphResourcesData, 2LL);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields, v3, v4, v5, v26);
		  v6 = (DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo_ *)sub_18002C620(TypeInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::RendererListResource>);
		  v9 = (DynamicArray_1_HG_Rendering_RenderGraphModule_RendererListResource_ *)v6;
		  if ( !v6 )
		    goto LABEL_5;
		  UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::DynamicArray(
		    v6,
		    MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::RendererListResource>::DynamicArray);
		  this->fields.m_RendererListResources = v9;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_RendererListResources, v10, v11, v12, v27);
		  v13 = (HGRenderGraphLogger *)sub_18002C620(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphLogger);
		  v14 = v13;
		  if ( !v13
		    || (HG::Rendering::RenderGraphModule::HGRenderGraphLogger::HGRenderGraphLogger(v13, 0LL),
		        this->fields.m_ResourceLogger = v14,
		        sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_ResourceLogger, v15, v16, v17, v28),
		        this->fields.m_CurrentBackbuffer = (RTHandle__Array *)il2cpp_array_new_specific_1(
		                                                                TypeInfo::UnityEngine::Rendering::RTHandle,
		                                                                2LL),
		        sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_CurrentBackbuffer, v18, v19, v20, v29),
		        v21 = (List_1_Beyond_Gameplay_Factory_ECSVATFSM_VATFSMProcessor_SetAnimatorParamRequest_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<UnityEngine::Rendering::RendererUtils::RendererList>),
		        (v22 = (List_1_UnityEngine_Rendering_RendererUtils_RendererList_ *)v21) == 0LL) )
		  {
		LABEL_5:
		    sub_1800D8260(v8, v7);
		  }
		  System::Collections::Generic::List<Beyond::Gameplay::Factory::ECSVATFSM::VATFSMProcessor::SetAnimatorParamRequest>::List(
		    v21,
		    256,
		    MethodInfo::System::Collections::Generic::List<UnityEngine::Rendering::RendererUtils::RendererList>::List);
		  this->fields.m_ActiveRendererLists = v22;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_ActiveRendererLists, v23, v24, v25, v30);
		}
		
		internal HGRenderGraphResourceRegistry(HGRenderGraphDebugParams renderGraphDebug, HGRenderGraphLogger frameInformationLogger) {} // 0x00000001839466D0-0x00000001839469E0
		// HGRenderGraphResourceRegistry(HGRenderGraphDebugParams, HGRenderGraphLogger)
		void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::HGRenderGraphResourceRegistry(
		        HGRenderGraphResourceRegistry *this,
		        HGRenderGraphDebugParams *renderGraphDebug,
		        HGRenderGraphLogger *frameInformationLogger,
		        MethodInfo *method)
		{
		  Type *v7; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo_ *v10; // rax
		  Type *v11; // rdx
		  __int64 v12; // rcx
		  DynamicArray_1_HG_Rendering_RenderGraphModule_RendererListResource_ *v13; // rbx
		  Type *v14; // rdx
		  PropertyInfo_1 *v15; // r8
		  Int32__Array **v16; // r9
		  HGRenderGraphLogger *v17; // rax
		  HGRenderGraphLogger *v18; // rbx
		  Type *v19; // rdx
		  PropertyInfo_1 *v20; // r8
		  Int32__Array **v21; // r9
		  Type *v22; // rdx
		  PropertyInfo_1 *v23; // r8
		  Int32__Array **v24; // r9
		  __int64 v25; // rbx
		  __int64 v26; // rax
		  Type *v27; // rdx
		  PropertyInfo_1 *v28; // r8
		  Int32__Array **v29; // r9
		  Type *v30; // rdx
		  PropertyInfo_1 *v31; // r8
		  Int32__Array **v32; // r9
		  Type *v33; // rdx
		  PropertyInfo_1 *v34; // r8
		  Int32__Array **v35; // r9
		  Type *v36; // rdx
		  PropertyInfo_1 *v37; // r8
		  Int32__Array **v38; // r9
		  int i; // esi
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rbx
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *v41; // rax
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *v42; // rdi
		  PropertyInfo_1 *v43; // r8
		  Int32__Array **v44; // r9
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *v45; // rax
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *v46; // rbx
		  RenderFunc_1_System_Object_ *v47; // rax
		  RenderFunc_1_System_Object_ *v48; // rdi
		  PropertyInfo_1 *v49; // r8
		  Int32__Array **v50; // r9
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *v51; // r9
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *v52; // rbx
		  RenderFunc_1_System_Object_ *v53; // rax
		  RenderFunc_1_System_Object_ *v54; // rdi
		  PropertyInfo_1 *v55; // r8
		  Int32__Array **v56; // r9
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *v57; // r9
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *v58; // rbx
		  HGRenderGraphResourcePool_1_System_Object_ *v59; // rax
		  HGRenderGraphResourcePool_1_System_Object_ *v60; // rdi
		  PropertyInfo_1 *v61; // r8
		  Int32__Array **v62; // r9
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *v63; // rbx
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *v64; // rbx
		  HGRenderGraphResourcePool_1_System_Object_ *v65; // rax
		  HGRenderGraphResourcePool_1_System_Object_ *v66; // rdi
		  PropertyInfo_1 *v67; // r8
		  Int32__Array **v68; // r9
		  MethodInfo *v69; // [rsp+20h] [rbp-8h]
		  MethodInfo *v70; // [rsp+20h] [rbp-8h]
		  MethodInfo *v71; // [rsp+20h] [rbp-8h]
		  MethodInfo *v72; // [rsp+20h] [rbp-8h]
		  MethodInfo *v73; // [rsp+20h] [rbp-8h]
		  MethodInfo *v74; // [rsp+20h] [rbp-8h]
		  MethodInfo *v75; // [rsp+20h] [rbp-8h]
		  MethodInfo *v76; // [rsp+20h] [rbp-8h]
		  MethodInfo *v77; // [rsp+20h] [rbp-8h]
		  MethodInfo *v78; // [rsp+20h] [rbp-8h]
		  MethodInfo *v79; // [rsp+20h] [rbp-8h]
		  MethodInfo *v80; // [rsp+50h] [rbp+28h]
		
		  this->fields.m_RenderGraphResources = (HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *)il2cpp_array_new_specific_1(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::HGRenderGraphResourcesData, 2LL);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields, v7, v8, v9, v69);
		  v10 = (DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo_ *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::RendererListResource>);
		  v13 = (DynamicArray_1_HG_Rendering_RenderGraphModule_RendererListResource_ *)v10;
		  if ( !v10 )
		    goto LABEL_26;
		  UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::DynamicArray(
		    v10,
		    MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::RendererListResource>::DynamicArray);
		  this->fields.m_RendererListResources = v13;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_RendererListResources, v14, v15, v16, v70);
		  v17 = (HGRenderGraphLogger *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphLogger);
		  v18 = v17;
		  if ( !v17 )
		    goto LABEL_26;
		  HG::Rendering::RenderGraphModule::HGRenderGraphLogger::HGRenderGraphLogger(v17, 0LL);
		  this->fields.m_ResourceLogger = v18;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_ResourceLogger, v19, v20, v21, v71);
		  this->fields.m_CurrentBackbuffer = (RTHandle__Array *)il2cpp_array_new_specific_1(
		                                                          TypeInfo::UnityEngine::Rendering::RTHandle,
		                                                          2LL);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_CurrentBackbuffer, v22, v23, v24, v72);
		  v25 = sub_1800368D0(TypeInfo::System::Collections::Generic::List<UnityEngine::Rendering::RendererUtils::RendererList>);
		  if ( !v25 )
		    goto LABEL_26;
		  v26 = ((__int64 (__fastcall *)(_QWORD))sub_18011C4C0)((const Il2CppRGCTXData)MethodInfo::System::Collections::Generic::List<UnityEngine::Rendering::RendererUtils::RendererList>::List->klass->rgctx_data[1].rgctxDataDummy);
		  *(_QWORD *)(v25 + 16) = il2cpp_array_new_specific_1(v26, 256LL);
		  sub_18002D1B0((SingleFieldAccessor *)(v25 + 16), v27, v28, v29, v73);
		  this->fields.m_ActiveRendererLists = (List_1_UnityEngine_Rendering_RendererUtils_RendererList_ *)v25;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_ActiveRendererLists, v30, v31, v32, v74);
		  this->fields.m_RenderGraphDebug = renderGraphDebug;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_RenderGraphDebug, v33, v34, v35, v75);
		  this->fields.m_FrameInformationLogger = frameInformationLogger;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_FrameInformationLogger, v36, v37, v38, v76);
		  for ( i = 0; i < 2; sub_18002D1B0((SingleFieldAccessor *)&m_RenderGraphResources->vector[i++], v11, v43, v44, v77) )
		  {
		    m_RenderGraphResources = this->fields.m_RenderGraphResources;
		    v41 = (HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::HGRenderGraphResourcesData);
		    v42 = v41;
		    if ( !v41 )
		      goto LABEL_26;
		    HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::HGRenderGraphResourcesData::HGRenderGraphResourcesData(
		      v41,
		      0LL);
		    if ( !m_RenderGraphResources )
		      goto LABEL_26;
		    sub_180031B10(m_RenderGraphResources, v42);
		    if ( (unsigned int)i >= m_RenderGraphResources->max_length.size )
		      goto LABEL_27;
		    m_RenderGraphResources->vector[i] = v42;
		  }
		  v45 = this->fields.m_RenderGraphResources;
		  if ( !v45 )
		    goto LABEL_26;
		  if ( !v45->max_length.size )
		    goto LABEL_27;
		  v46 = v45->vector[0];
		  v47 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ResourceCallback);
		  v48 = v47;
		  if ( !v47 )
		    goto LABEL_26;
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v47,
		    (Object *)this,
		    MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CreateTextureCallback,
		    0LL);
		  if ( !v46 )
		    goto LABEL_26;
		  v46->fields.createResourceCallback = (HGRenderGraphResourceRegistry_ResourceCallback *)v48;
		  sub_18002D1B0((SingleFieldAccessor *)&v46->fields.createResourceCallback, v11, v49, v50, v77);
		  v51 = this->fields.m_RenderGraphResources;
		  if ( !v51 )
		    goto LABEL_26;
		  if ( !v51->max_length.size )
		    goto LABEL_27;
		  v52 = v51->vector[0];
		  v53 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ResourceCallback);
		  v54 = v53;
		  if ( !v53 )
		    goto LABEL_26;
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v53,
		    (Object *)this,
		    MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ReleaseTextureCallback,
		    0LL);
		  if ( !v52 )
		    goto LABEL_26;
		  v52->fields.releaseResourceCallback = (HGRenderGraphResourceRegistry_ResourceCallback *)v54;
		  sub_18002D1B0((SingleFieldAccessor *)&v52->fields.releaseResourceCallback, v11, v55, v56, v78);
		  v57 = this->fields.m_RenderGraphResources;
		  if ( !v57 )
		    goto LABEL_26;
		  if ( !v57->max_length.size )
		    goto LABEL_27;
		  v58 = v57->vector[0];
		  v59 = (HGRenderGraphResourcePool_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::TexturePool);
		  v60 = v59;
		  if ( !v59
		    || (HG::Rendering::RenderGraphModule::HGRenderGraphResourcePool<System::Object>::HGRenderGraphResourcePool(
		          v59,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourcePool<UnityEngine::Rendering::RTHandle>::HGRenderGraphResourcePool),
		        !v58)
		    || (v58->fields.pool = (IHGRenderGraphResourcePool *)v60,
		        sub_18002D1B0((SingleFieldAccessor *)&v58->fields.pool, v11, v61, v62, v79),
		        (v63 = this->fields.m_RenderGraphResources) == 0LL) )
		  {
		LABEL_26:
		    sub_1800D8260(v12, v11);
		  }
		  if ( v63->max_length.size <= 1u )
		LABEL_27:
		    sub_1800D2AB0(v12, v11);
		  v64 = v63->vector[1];
		  v65 = (HGRenderGraphResourcePool_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferPool);
		  v66 = v65;
		  if ( !v65 )
		    goto LABEL_26;
		  HG::Rendering::RenderGraphModule::HGRenderGraphResourcePool<System::Object>::HGRenderGraphResourcePool(
		    v65,
		    MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourcePool<UnityEngine::ComputeBuffer>::HGRenderGraphResourcePool);
		  if ( !v64 )
		    goto LABEL_26;
		  v64->fields.pool = (IHGRenderGraphResourcePool *)v66;
		  sub_18002D1B0((SingleFieldAccessor *)&v64->fields.pool, v11, v67, v68, v80);
		}
		
	
		// Methods
		internal RTHandle GetTexture([IsReadOnly] in TextureHandle handle) => default; // 0x0000000189B3A254-0x0000000189B3A368
		// RTHandle GetTexture(TextureHandle ByRef)
		RTHandle *HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetTexture(
		        HGRenderGraphResourceRegistry *this,
		        TextureHandle *handle,
		        MethodInfo *method)
		{
		  TextureResource *TextureResource; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  RTHandle *graphicsResource; // rsi
		  ResourceHandle fallBackResource; // rbx
		  TextureHandle *nullHandle; // rax
		  TextureResource *v11; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  TextureHandle v14; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(306, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(306, 0LL);
		    if ( !Patch )
		      goto LABEL_11;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_143(Patch, (Object *)this, handle, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		    if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(handle, 0LL) )
		    {
		      TextureResource = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetTextureResource(
		                          this,
		                          &handle->handle,
		                          0LL);
		      if ( !TextureResource )
		        goto LABEL_11;
		      graphicsResource = TextureResource->fields._.graphicsResource;
		      if ( !graphicsResource )
		      {
		        fallBackResource = handle->fallBackResource;
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
		        fallBackResource.m_Value = HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit(fallBackResource, 0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		        nullHandle = HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v14, 0LL);
		        if ( fallBackResource.m_Value != HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit(
		                                           nullHandle->handle,
		                                           0LL) )
		        {
		          v11 = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetTextureResource(
		                  this,
		                  &handle->fallBackResource,
		                  0LL);
		          if ( v11 )
		            return v11->fields._.graphicsResource;
		LABEL_11:
		          sub_1800D8260(v7, v6);
		        }
		      }
		      return graphicsResource;
		    }
		    else
		    {
		      return 0LL;
		    }
		  }
		}
		
		internal bool TextureNeedsFallback([IsReadOnly] in TextureHandle handle) => default; // 0x0000000189B3BB6C-0x0000000189B3BBFC
		// Boolean TextureNeedsFallback(TextureHandle ByRef)
		bool HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::TextureNeedsFallback(
		        HGRenderGraphResourceRegistry *this,
		        TextureHandle *handle,
		        MethodInfo *method)
		{
		  IHGRenderGraphResource *TextureResource; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(239, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(239, 0LL);
		    if ( !Patch )
		      goto LABEL_7;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_117(Patch, (Object *)this, handle, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		    if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(handle, 0LL) )
		    {
		      TextureResource = (IHGRenderGraphResource *)HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetTextureResource(
		                                                    this,
		                                                    &handle->handle,
		                                                    0LL);
		      if ( TextureResource )
		        return HG::Rendering::RenderGraphModule::IHGRenderGraphResource::NeedsFallBack(TextureResource, 0LL);
		LABEL_7:
		      sub_1800D8260(v7, v6);
		    }
		    return 0;
		  }
		}
		
		internal RendererList GetRendererList([IsReadOnly] in RendererListHandle handle) => default; // 0x0000000189B39E08-0x0000000189B39EE4
		// RendererList GetRendererList(RendererListHandle ByRef)
		RendererList *HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetRendererList(
		        RendererList *__return_ptr retstr,
		        HGRenderGraphResourceRegistry *this,
		        RendererListHandle *handle,
		        MethodInfo *method)
		{
		  int32_t v7; // eax
		  __int64 v8; // rdx
		  DynamicArray_1_HG_Rendering_RenderGraphModule_RendererListResource_ *m_RendererListResources; // rcx
		  DynamicArray_1_HG_Rendering_RenderGraphModule_RendererListResource_ *v10; // rbx
		  int32_t v11; // eax
		  RendererList nullRendererList; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  RendererList *result; // rax
		  RendererList v15; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(63, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(63, 0LL);
		    if ( Patch )
		    {
		      nullRendererList = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_32(&v15, Patch, (Object *)this, handle, 0LL);
		      goto LABEL_10;
		    }
		    goto LABEL_8;
		  }
		  if ( !HG::Rendering::RenderGraphModule::RendererListHandle::IsValid(handle, 0LL) )
		  {
		LABEL_6:
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::RendererUtils::RendererList);
		    nullRendererList = TypeInfo::UnityEngine::Rendering::RendererUtils::RendererList->static_fields->nullRendererList;
		    goto LABEL_10;
		  }
		  v7 = HG::Rendering::RenderGraphModule::RendererListHandle::op_Implicit(*handle, 0LL);
		  m_RendererListResources = this->fields.m_RendererListResources;
		  if ( !m_RendererListResources )
		LABEL_8:
		    sub_1800D8260(m_RendererListResources, v8);
		  if ( v7 >= m_RendererListResources->fields._size_k__BackingField )
		    goto LABEL_6;
		  v10 = this->fields.m_RendererListResources;
		  v11 = HG::Rendering::RenderGraphModule::RendererListHandle::op_Implicit(*handle, 0LL);
		  nullRendererList = UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RendererListResource>::get_Item(
		                       (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RendererListResource_ *)v10,
		                       v11,
		                       MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::RendererListResource>::get_Item)->rendererList;
		LABEL_10:
		  result = retstr;
		  *retstr = nullRendererList;
		  return result;
		}
		
		internal ComputeBuffer GetComputeBuffer([IsReadOnly] in ComputeBufferHandle handle) => default; // 0x0000000189B39AF0-0x0000000189B39B84
		// ComputeBuffer GetComputeBuffer(ComputeBufferHandle ByRef)
		ComputeBuffer *HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetComputeBuffer(
		        HGRenderGraphResourceRegistry *this,
		        ComputeBufferHandle *handle,
		        MethodInfo *method)
		{
		  ComputeBufferResource *ComputeBufferResource; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ComputeBufferHandle v10; // [rsp+48h] [rbp+20h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(288, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(288, 0LL);
		    if ( !Patch )
		      goto LABEL_7;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_138(Patch, (Object *)this, handle, 0LL);
		  }
		  else
		  {
		    v10 = *handle;
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
		    if ( HG::Rendering::RenderGraphModule::ComputeBufferHandle::IsValid(&v10, 0LL) )
		    {
		      ComputeBufferResource = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetComputeBufferResource(
		                                this,
		                                &handle->handle,
		                                0LL);
		      if ( ComputeBufferResource )
		        return ComputeBufferResource->fields._.graphicsResource;
		LABEL_7:
		      sub_1800D8260(v7, v6);
		    }
		    return 0LL;
		  }
		}
		
		internal void BeginRenderGraph(int executionCount, int currentExecutorID, int currentExecutorFrameIndex) {} // 0x0000000189B388DC-0x0000000189B389E4
		// Void BeginRenderGraph(Int32, Int32, Int32)
		void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::BeginRenderGraph(
		        HGRenderGraphResourceRegistry *this,
		        int32_t executionCount,
		        int32_t currentExecutorID,
		        int32_t currentExecutorFrameIndex,
		        MethodInfo *method)
		{
		  __int64 v9; // rdx
		  DynamicArray_1_System_Object_ *m_Array; // rcx
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rsi
		  int32_t v12; // edi
		  HGRenderGraphDebugParams *m_RenderGraphDebug; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(183, 0LL) )
		  {
		    this->fields.m_ExecutionCount = executionCount;
		    this->fields.m_currentExecutorID = currentExecutorID;
		    this->fields.m_currentExecutorFrameIndex = currentExecutorFrameIndex;
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
		    HG::Rendering::RenderGraphModule::ResourceHandle::NewFrame(executionCount, 0LL);
		    m_RenderGraphResources = this->fields.m_RenderGraphResources;
		    v12 = 0;
		    if ( m_RenderGraphResources )
		    {
		      while ( v12 < m_RenderGraphResources->max_length.size )
		      {
		        if ( (unsigned int)v12 >= m_RenderGraphResources->max_length.size )
		          sub_1800D2AB0(m_Array, v9);
		        m_Array = (DynamicArray_1_System_Object_ *)m_RenderGraphResources->vector[v12];
		        if ( !m_Array )
		          goto LABEL_14;
		        m_Array = (DynamicArray_1_System_Object_ *)m_Array->fields.m_Array;
		        if ( !m_Array )
		          goto LABEL_14;
		        UnityEngine::Rendering::DynamicArray<System::Object>::Resize(
		          m_Array,
		          64,
		          0,
		          MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::Resize);
		        ++v12;
		      }
		      m_RenderGraphDebug = this->fields.m_RenderGraphDebug;
		      if ( m_RenderGraphDebug )
		      {
		        if ( !m_RenderGraphDebug->fields.enableLogging )
		          return;
		        m_Array = (DynamicArray_1_System_Object_ *)this->fields.m_ResourceLogger;
		        if ( m_Array )
		        {
		          HG::Rendering::RenderGraphModule::HGRenderGraphLogger::Initialize(
		            (HGRenderGraphLogger *)m_Array,
		            (String *)"RenderGraph Resources",
		            0LL);
		          return;
		        }
		      }
		    }
		LABEL_14:
		    sub_1800D8260(m_Array, v9);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(183, 0LL);
		  if ( !Patch )
		    goto LABEL_14;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_247(
		    (ILFixDynamicMethodWrapper_6 *)Patch,
		    (Object *)this,
		    executionCount,
		    currentExecutorID,
		    currentExecutorFrameIndex,
		    0LL);
		}
		
		internal void BeginExecute(int currentFrameIndex) {} // 0x0000000189B3887C-0x0000000189B388DC
		// Void BeginExecute(Int32)
		void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::BeginExecute(
		        HGRenderGraphResourceRegistry *this,
		        int32_t currentFrameIndex,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(73, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(73, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3(
		      (ILFixDynamicMethodWrapper_29 *)Patch,
		      (Object *)this,
		      currentFrameIndex,
		      0LL);
		  }
		  else
		  {
		    this->fields.m_CurrentFrameIndex = currentFrameIndex;
		    HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::set_current(this, 0LL);
		  }
		}
		
		internal void EndExecute() {} // 0x0000000189B39770-0x0000000189B397C0
		// Void EndExecute()
		void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::EndExecute(
		        HGRenderGraphResourceRegistry *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(106, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(106, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::set_current(0LL, 0LL);
		  }
		}
		
		[IDTag(1)]
		private void CheckHandleValidity([IsReadOnly] in ResourceHandle res) {} // 0x0000000189B38B28-0x0000000189B38BB8
		// Void CheckHandleValidity(ResourceHandle ByRef)
		void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CheckHandleValidity(
		        HGRenderGraphResourceRegistry *this,
		        ResourceHandle *res,
		        MethodInfo *method)
		{
		  unsigned int type_k__BackingField; // ebx
		  int32_t index; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  ResourceHandle v10; // [rsp+48h] [rbp+20h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(42, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(42, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_23(Patch, (Object *)this, res, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
		    type_k__BackingField = res->_type_k__BackingField;
		    v10 = *res;
		    index = HG::Rendering::RenderGraphModule::ResourceHandle::get_index(&v10, 0LL);
		    HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CheckHandleValidity(
		      this,
		      (HGRenderGraphResourceType__Enum)type_k__BackingField,
		      index,
		      0LL);
		  }
		}
		
		[IDTag(0)]
		private void CheckHandleValidity(HGRenderGraphResourceType type, int index) {} // 0x0000000189B389E4-0x0000000189B38B28
		// Void CheckHandleValidity(HGRenderGraphResourceType, Int32)
		void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CheckHandleValidity(
		        HGRenderGraphResourceRegistry *this,
		        HGRenderGraphResourceType__Enum type,
		        int32_t index,
		        MethodInfo *method)
		{
		  __int64 v4; // rbx
		  __int64 v7; // rdx
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rcx
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *v9; // rax
		  DynamicArray_1_HG_Rendering_RenderGraphModule_IHGRenderGraphResource_ *resourceArray; // rax
		  __int64 v11; // rax
		  __int64 v12; // rax
		  Object *v13; // rdi
		  __int64 v14; // rax
		  Object *v15; // rbx
		  String *v16; // rax
		  String *v17; // rdi
		  __int64 v18; // rax
		  InvalidEnumArgumentException *v19; // rax
		  InvalidEnumArgumentException *v20; // rbx
		  __int64 v21; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  _DWORD v23[6]; // [rsp+30h] [rbp-18h] BYREF
		
		  v4 = (int)type;
		  if ( IFix::WrappersManagerImpl::IsPatched(44, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(44, 0LL);
		    if ( !Patch )
		      goto LABEL_11;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_272(
		      (ILFixDynamicMethodWrapper_6 *)Patch,
		      (Object *)this,
		      (UIInertiaViewPager_State__Enum)v4,
		      (UIInertiaViewPager_State__Enum)index,
		      0LL);
		  }
		  else
		  {
		    m_RenderGraphResources = this->fields.m_RenderGraphResources;
		    if ( !m_RenderGraphResources )
		      goto LABEL_11;
		    if ( (unsigned int)v4 >= m_RenderGraphResources->max_length.size )
		      sub_1800D2AB0(m_RenderGraphResources, v7);
		    v9 = m_RenderGraphResources->vector[v4];
		    if ( !v9 || (resourceArray = v9->fields.resourceArray) == 0LL )
		LABEL_11:
		      sub_1800D8260(m_RenderGraphResources, v7);
		    if ( index >= resourceArray->fields._size_k__BackingField )
		    {
		      v23[0] = v4;
		      v11 = sub_18007E180(&TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourceType);
		      v12 = il2cpp_value_box_0(v11, v23);
		      v23[0] = index;
		      v13 = (Object *)v12;
		      v14 = sub_18007E180(&TypeInfo::System::Int32);
		      v15 = (Object *)il2cpp_value_box_0(v14, v23);
		      v16 = (String *)sub_18007E180(&off_18E25C050);
		      v17 = System::String::Format(v16, v13, v15, 0LL);
		      v18 = sub_18007E180(&TypeInfo::System::ArgumentException);
		      v19 = (InvalidEnumArgumentException *)sub_1800368D0(v18);
		      v20 = v19;
		      if ( v19 )
		      {
		        System::ComponentModel::InvalidEnumArgumentException::InvalidEnumArgumentException(v19, v17, 0LL);
		        v21 = sub_18007E180(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CheckHandleValidity);
		        sub_18007E190(v20, v21);
		      }
		      goto LABEL_11;
		    }
		  }
		}
		
		internal void IncrementWriteCount([IsReadOnly] in ResourceHandle res) {} // 0x0000000189B3AC40-0x0000000189B3AD24
		// Void IncrementWriteCount(ResourceHandle ByRef)
		void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::IncrementWriteCount(
		        HGRenderGraphResourceRegistry *this,
		        ResourceHandle *res,
		        MethodInfo *method)
		{
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rbx
		  int32_t iType; // eax
		  __int64 v7; // rdx
		  Object *v8; // rcx
		  DynamicArray_1_System_Object_ *klass; // rbx
		  int32_t index; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ResourceHandle v12; // [rsp+48h] [rbp+20h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(224, 0LL) )
		  {
		    HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CheckHandleValidity(this, res, 0LL);
		    m_RenderGraphResources = this->fields.m_RenderGraphResources;
		    v12 = *res;
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
		    iType = HG::Rendering::RenderGraphModule::ResourceHandle::get_iType(&v12, 0LL);
		    if ( m_RenderGraphResources )
		    {
		      if ( (unsigned int)iType >= m_RenderGraphResources->max_length.size )
		        sub_1800D2AB0(v8, v7);
		      v8 = (Object *)m_RenderGraphResources->vector[iType];
		      if ( v8 )
		      {
		        klass = (DynamicArray_1_System_Object_ *)v8[1].klass;
		        v12 = *res;
		        index = HG::Rendering::RenderGraphModule::ResourceHandle::get_index(&v12, 0LL);
		        if ( klass )
		        {
		          v8 = *UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
		                  klass,
		                  index,
		                  MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
		          if ( v8 )
		          {
		            HG::Rendering::RenderGraphModule::IHGRenderGraphResource::IncrementWriteCount(
		              (IHGRenderGraphResource *)v8,
		              0LL);
		            return;
		          }
		        }
		      }
		    }
		LABEL_10:
		    sub_1800D8260(v8, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(224, 0LL);
		  if ( !Patch )
		    goto LABEL_10;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_23(Patch, (Object *)this, res, 0LL);
		}
		
		[IDTag(1)]
		internal string GetRenderGraphResourceName([IsReadOnly] in ResourceHandle res) => default; // 0x0000000189B39B84-0x0000000189B39C6C
		// String GetRenderGraphResourceName(ResourceHandle ByRef)
		String *HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetRenderGraphResourceName(
		        HGRenderGraphResourceRegistry *this,
		        ResourceHandle *res,
		        MethodInfo *method)
		{
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rbx
		  int32_t iType; // eax
		  Object *v7; // rdx
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *v8; // rcx
		  DynamicArray_1_System_Object_ *resourceArray; // rbx
		  int32_t index; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ResourceHandle v13; // [rsp+48h] [rbp+20h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(307, 0LL) )
		  {
		    HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CheckHandleValidity(this, res, 0LL);
		    m_RenderGraphResources = this->fields.m_RenderGraphResources;
		    v13 = *res;
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
		    iType = HG::Rendering::RenderGraphModule::ResourceHandle::get_iType(&v13, 0LL);
		    if ( m_RenderGraphResources )
		    {
		      if ( (unsigned int)iType >= m_RenderGraphResources->max_length.size )
		        sub_1800D2AB0(v8, v7);
		      v8 = m_RenderGraphResources->vector[iType];
		      if ( v8 )
		      {
		        resourceArray = (DynamicArray_1_System_Object_ *)v8->fields.resourceArray;
		        v13 = *res;
		        index = HG::Rendering::RenderGraphModule::ResourceHandle::get_index(&v13, 0LL);
		        if ( resourceArray )
		        {
		          v7 = *UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
		                  resourceArray,
		                  index,
		                  MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
		          if ( v7 )
		            return (String *)sub_180032CB0(5LL, v7);
		        }
		      }
		    }
		LABEL_10:
		    sub_1800D8260(v8, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(307, 0LL);
		  if ( !Patch )
		    goto LABEL_10;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_144(Patch, (Object *)this, res, 0LL);
		}
		
		[IDTag(0)]
		internal string GetRenderGraphResourceName(HGRenderGraphResourceType type, int index) => default; // 0x0000000189B39C6C-0x0000000189B39D28
		// String GetRenderGraphResourceName(HGRenderGraphResourceType, Int32)
		String *HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetRenderGraphResourceName(
		        HGRenderGraphResourceRegistry *this,
		        HGRenderGraphResourceType__Enum type,
		        int32_t index,
		        MethodInfo *method)
		{
		  __int64 v4; // rbx
		  Object *v7; // rdx
		  DynamicArray_1_System_Object_ *m_RenderGraphResources; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v4 = (int)type;
		  if ( !IFix::WrappersManagerImpl::IsPatched(94, 0LL) )
		  {
		    HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CheckHandleValidity(
		      this,
		      (HGRenderGraphResourceType__Enum)v4,
		      index,
		      0LL);
		    m_RenderGraphResources = (DynamicArray_1_System_Object_ *)this->fields.m_RenderGraphResources;
		    if ( m_RenderGraphResources )
		    {
		      if ( (unsigned int)v4 >= m_RenderGraphResources->fields._size_k__BackingField )
		        sub_1800D2AB0(m_RenderGraphResources, v7);
		      v7 = (Object *)*((_QWORD *)&m_RenderGraphResources[1].klass + v4);
		      if ( v7 )
		      {
		        m_RenderGraphResources = (DynamicArray_1_System_Object_ *)v7[1].klass;
		        if ( m_RenderGraphResources )
		        {
		          v7 = *UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
		                  m_RenderGraphResources,
		                  index,
		                  MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
		          if ( v7 )
		            return (String *)sub_180032CB0(5LL, v7);
		        }
		      }
		    }
		LABEL_10:
		    sub_1800D8260(m_RenderGraphResources, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(94, 0LL);
		  if ( !Patch )
		    goto LABEL_10;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_47(
		           Patch,
		           (Object *)this,
		           (HGRenderGraphResourceType__Enum)v4,
		           index,
		           0LL);
		}
		
		[IDTag(0)]
		internal bool IsRenderGraphResourceImported([IsReadOnly] in ResourceHandle res) => default; // 0x0000000189B3AE0C-0x0000000189B3AEE8
		// Boolean IsRenderGraphResourceImported(ResourceHandle ByRef)
		bool HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::IsRenderGraphResourceImported(
		        HGRenderGraphResourceRegistry *this,
		        ResourceHandle *res,
		        MethodInfo *method)
		{
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rbx
		  int32_t iType; // eax
		  __int64 v7; // rdx
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *v8; // rcx
		  DynamicArray_1_System_Object_ *resourceArray; // rbx
		  int32_t index; // eax
		  Object *v11; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ResourceHandle v14; // [rsp+48h] [rbp+20h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(41, 0LL) )
		  {
		    HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CheckHandleValidity(this, res, 0LL);
		    m_RenderGraphResources = this->fields.m_RenderGraphResources;
		    v14 = *res;
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
		    iType = HG::Rendering::RenderGraphModule::ResourceHandle::get_iType(&v14, 0LL);
		    if ( m_RenderGraphResources )
		    {
		      if ( (unsigned int)iType >= m_RenderGraphResources->max_length.size )
		        sub_1800D2AB0(v8, v7);
		      v8 = m_RenderGraphResources->vector[iType];
		      if ( v8 )
		      {
		        resourceArray = (DynamicArray_1_System_Object_ *)v8->fields.resourceArray;
		        v14 = *res;
		        index = HG::Rendering::RenderGraphModule::ResourceHandle::get_index(&v14, 0LL);
		        if ( resourceArray )
		        {
		          v11 = *UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
		                   resourceArray,
		                   index,
		                   MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
		          if ( v11 )
		            return (bool)v11[1].klass;
		        }
		      }
		    }
		LABEL_10:
		    sub_1800D8260(v8, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(41, 0LL);
		  if ( !Patch )
		    goto LABEL_10;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_24(Patch, (Object *)this, res, 0LL);
		}
		
		internal bool IsRenderGraphResourcePreserved(HGRenderGraphResourceType type, int index) => default; // 0x0000000189B3AF9C-0x0000000189B3B01C
		// Boolean IsRenderGraphResourcePreserved(HGRenderGraphResourceType, Int32)
		bool HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::IsRenderGraphResourcePreserved(
		        HGRenderGraphResourceRegistry *this,
		        HGRenderGraphResourceType__Enum type,
		        int32_t index,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(308, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(308, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_2(
		             (ILFixDynamicMethodWrapper_10 *)Patch,
		             (Object *)this,
		             type,
		             index,
		             0LL);
		  }
		  else
		  {
		    HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CheckHandleValidity(this, type, index, 0LL);
		    return index < 64;
		  }
		}
		
		internal bool IsGraphicsResourceCreated([IsReadOnly] in ResourceHandle res) => default; // 0x0000000189B3AD24-0x0000000189B3AE0C
		// Boolean IsGraphicsResourceCreated(ResourceHandle ByRef)
		bool HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::IsGraphicsResourceCreated(
		        HGRenderGraphResourceRegistry *this,
		        ResourceHandle *res,
		        MethodInfo *method)
		{
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rbx
		  int32_t iType; // eax
		  Object *v7; // rdx
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *v8; // rcx
		  DynamicArray_1_System_Object_ *resourceArray; // rbx
		  int32_t index; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ResourceHandle v13; // [rsp+48h] [rbp+20h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(212, 0LL) )
		  {
		    HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CheckHandleValidity(this, res, 0LL);
		    m_RenderGraphResources = this->fields.m_RenderGraphResources;
		    v13 = *res;
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
		    iType = HG::Rendering::RenderGraphModule::ResourceHandle::get_iType(&v13, 0LL);
		    if ( m_RenderGraphResources )
		    {
		      if ( (unsigned int)iType >= m_RenderGraphResources->max_length.size )
		        sub_1800D2AB0(v8, v7);
		      v8 = m_RenderGraphResources->vector[iType];
		      if ( v8 )
		      {
		        resourceArray = (DynamicArray_1_System_Object_ *)v8->fields.resourceArray;
		        v13 = *res;
		        index = HG::Rendering::RenderGraphModule::ResourceHandle::get_index(&v13, 0LL);
		        if ( resourceArray )
		        {
		          v7 = *UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
		                  resourceArray,
		                  index,
		                  MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
		          if ( v7 )
		            return sub_180006280(6LL, v7);
		        }
		      }
		    }
		LABEL_10:
		    sub_1800D8260(v8, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(212, 0LL);
		  if ( !Patch )
		    goto LABEL_10;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_24(Patch, (Object *)this, res, 0LL);
		}
		
		internal bool IsRendererListCreated([IsReadOnly] in RendererListHandle res) => default; // 0x0000000189B3B01C-0x0000000189B3B0B0
		// Boolean IsRendererListCreated(RendererListHandle ByRef)
		bool HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::IsRendererListCreated(
		        HGRenderGraphResourceRegistry *this,
		        RendererListHandle *res,
		        MethodInfo *method)
		{
		  DynamicArray_1_HG_Rendering_RenderGraphModule_RendererListResource_ *m_RendererListResources; // rdi
		  int32_t v6; // eax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  RendererListResource_1 *Item; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(214, 0LL) )
		  {
		    m_RendererListResources = this->fields.m_RendererListResources;
		    v6 = HG::Rendering::RenderGraphModule::RendererListHandle::op_Implicit(*res, 0LL);
		    if ( m_RendererListResources )
		    {
		      Item = UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RendererListResource>::get_Item(
		               (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RendererListResource_ *)m_RendererListResources,
		               v6,
		               MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::RendererListResource>::get_Item);
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::RendererUtils::RendererList);
		      return UnityEngine::Rendering::RendererUtils::RendererList::get_isValid(&Item->rendererList, 0LL);
		    }
		LABEL_5:
		    sub_1800D8260(v8, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(214, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_96(Patch, (Object *)this, res, 0LL);
		}
		
		[IDTag(1)]
		internal bool IsRenderGraphResourceImported(HGRenderGraphResourceType type, int index) => default; // 0x0000000189B3AEE8-0x0000000189B3AF9C
		// Boolean IsRenderGraphResourceImported(HGRenderGraphResourceType, Int32)
		bool HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::IsRenderGraphResourceImported(
		        HGRenderGraphResourceRegistry *this,
		        HGRenderGraphResourceType__Enum type,
		        int32_t index,
		        MethodInfo *method)
		{
		  __int64 v4; // rbx
		  __int64 v7; // rdx
		  DynamicArray_1_System_Object_ *m_RenderGraphResources; // rcx
		  Object *v9; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v4 = (int)type;
		  if ( !IFix::WrappersManagerImpl::IsPatched(96, 0LL) )
		  {
		    HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CheckHandleValidity(
		      this,
		      (HGRenderGraphResourceType__Enum)v4,
		      index,
		      0LL);
		    m_RenderGraphResources = (DynamicArray_1_System_Object_ *)this->fields.m_RenderGraphResources;
		    if ( m_RenderGraphResources )
		    {
		      if ( (unsigned int)v4 >= m_RenderGraphResources->fields._size_k__BackingField )
		        sub_1800D2AB0(m_RenderGraphResources, v7);
		      v7 = *((_QWORD *)&m_RenderGraphResources[1].klass + v4);
		      if ( v7 )
		      {
		        m_RenderGraphResources = *(DynamicArray_1_System_Object_ **)(v7 + 16);
		        if ( m_RenderGraphResources )
		        {
		          v9 = *UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
		                  m_RenderGraphResources,
		                  index,
		                  MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
		          if ( v9 )
		            return (bool)v9[1].klass;
		        }
		      }
		    }
		LABEL_10:
		    sub_1800D8260(m_RenderGraphResources, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(96, 0LL);
		  if ( !Patch )
		    goto LABEL_10;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_2(
		           (ILFixDynamicMethodWrapper_10 *)Patch,
		           (Object *)this,
		           v4,
		           index,
		           0LL);
		}
		
		internal int GetRenderGraphResourceTransientIndex([IsReadOnly] in ResourceHandle res) => default; // 0x0000000189B39D28-0x0000000189B39E08
		// Int32 GetRenderGraphResourceTransientIndex(ResourceHandle ByRef)
		int32_t HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetRenderGraphResourceTransientIndex(
		        HGRenderGraphResourceRegistry *this,
		        ResourceHandle *res,
		        MethodInfo *method)
		{
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rbx
		  int32_t iType; // eax
		  __int64 v7; // rdx
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *v8; // rcx
		  DynamicArray_1_System_Object_ *resourceArray; // rbx
		  int32_t index; // eax
		  Object *v11; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ResourceHandle v14; // [rsp+48h] [rbp+20h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(309, 0LL) )
		  {
		    HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CheckHandleValidity(this, res, 0LL);
		    m_RenderGraphResources = this->fields.m_RenderGraphResources;
		    v14 = *res;
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
		    iType = HG::Rendering::RenderGraphModule::ResourceHandle::get_iType(&v14, 0LL);
		    if ( m_RenderGraphResources )
		    {
		      if ( (unsigned int)iType >= m_RenderGraphResources->max_length.size )
		        sub_1800D2AB0(v8, v7);
		      v8 = m_RenderGraphResources->vector[iType];
		      if ( v8 )
		      {
		        resourceArray = (DynamicArray_1_System_Object_ *)v8->fields.resourceArray;
		        v14 = *res;
		        index = HG::Rendering::RenderGraphModule::ResourceHandle::get_index(&v14, 0LL);
		        if ( resourceArray )
		        {
		          v11 = *UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
		                   resourceArray,
		                   index,
		                   MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
		          if ( v11 )
		            return HIDWORD(v11[1].monitor);
		        }
		      }
		    }
		LABEL_10:
		    sub_1800D8260(v8, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(309, 0LL);
		  if ( !Patch )
		    goto LABEL_10;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_145(Patch, (Object *)this, res, 0LL);
		}
		
		[IDTag(0)]
		internal TextureHandle ImportTexture(RTHandle rt) => default; // 0x0000000189B3AA38-0x0000000189B3AC40
		// TextureHandle ImportTexture(RTHandle)
		TextureHandle *HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ImportTexture(
		        TextureHandle *__return_ptr retstr,
		        HGRenderGraphResourceRegistry *this,
		        RTHandle *rt,
		        MethodInfo *method)
		{
		  Type *v7; // rdx
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *v8; // rcx
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rax
		  int32_t v10; // eax
		  PropertyInfo_1 *v11; // r8
		  Int32__Array **v12; // r9
		  int32_t v13; // r15d
		  Object_1 *m_RT; // rbx
		  Object *v15; // r14
		  DepthBits__Enum v16; // ebx
		  GraphicsFormat__Enum depthStencilFormat; // eax
		  GraphicsFormat__Enum SupportedFormatForDepth; // eax
		  GraphicsFormat__Enum v19; // ebx
		  Object *v20; // r14
		  Object *v21; // r14
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v24; // [rsp+20h] [rbp-30h]
		  Object *outRes; // [rsp+30h] [rbp-20h] BYREF
		  TextureHandle v26; // [rsp+38h] [rbp-18h] BYREF
		  DepthBits__Enum depthBits; // [rsp+70h] [rbp+20h] BYREF
		
		  outRes = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(137, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(137, 0LL);
		    if ( Patch )
		    {
		      *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_62(&v26, Patch, (Object *)this, (Object *)rt, 0LL);
		      return retstr;
		    }
		    goto LABEL_25;
		  }
		  m_RenderGraphResources = this->fields.m_RenderGraphResources;
		  if ( !m_RenderGraphResources )
		    goto LABEL_25;
		  if ( !m_RenderGraphResources->max_length.size )
		    sub_1800D2AB0(v8, v7);
		  v8 = m_RenderGraphResources->vector[0];
		  if ( !v8 )
		    goto LABEL_25;
		  v10 = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::HGRenderGraphResourcesData::AddNewRenderGraphResource<System::Object>(
		          v8,
		          &outRes,
		          1,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::HGRenderGraphResourcesData::AddNewRenderGraphResource<HG::Rendering::RenderGraphModule::TextureResource>);
		  v8 = (HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *)outRes;
		  v13 = v10;
		  if ( !outRes )
		    goto LABEL_25;
		  outRes[9].monitor = (MonitorData *)rt;
		  sub_18002D1B0((SingleFieldAccessor *)&v8[3].monitor, v7, v11, v12, v24);
		  if ( !outRes )
		    goto LABEL_25;
		  LOBYTE(outRes[1].klass) = 1;
		  if ( !rt )
		    goto LABEL_23;
		  m_RT = (Object_1 *)rt->fields.m_RT;
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  if ( !UnityEngine::Object::op_Inequality(m_RT, 0LL, 0LL) )
		    goto LABEL_23;
		  v15 = outRes;
		  v16 = DepthBits__Enum_None;
		  depthBits = DepthBits__Enum_None;
		  if ( !outRes )
		    goto LABEL_25;
		  v8 = (HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *)rt->fields.m_RT;
		  if ( !v8 )
		    goto LABEL_25;
		  depthStencilFormat = UnityEngine::RenderTexture::get_depthStencilFormat((RenderTexture *)v8, 0LL);
		  v8 = (HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *)rt->fields.m_RT;
		  if ( depthStencilFormat )
		  {
		    if ( !v8 )
		      goto LABEL_25;
		    v19 = UnityEngine::RenderTexture::get_depthStencilFormat((RenderTexture *)v8, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		    SupportedFormatForDepth = HG::Rendering::Runtime::HGUtils::GetSupportedFormatForDepth(v19, &depthBits, 0LL);
		    v16 = depthBits;
		  }
		  else
		  {
		    if ( !v8 )
		      goto LABEL_25;
		    SupportedFormatForDepth = UnityEngine::RenderTexture::get_graphicsFormat((RenderTexture *)v8, 0LL);
		  }
		  LODWORD(v15[4].monitor) = SupportedFormatForDepth;
		  v20 = outRes;
		  if ( !outRes
		    || (v7 = (Type *)rt->fields.m_RT) == 0LL
		    || (LODWORD(v20[3].monitor) = sub_180002F70(5LL, v7), (v21 = outRes) == 0LL)
		    || (v7 = (Type *)rt->fields.m_RT) == 0LL
		    || (HIDWORD(v21[3].monitor) = sub_180002F70(7LL, v7), !outRes) )
		  {
		LABEL_25:
		    sub_1800D8260(v8, v7);
		  }
		  HIDWORD(outRes[4].klass) = v16;
		LABEL_23:
		  *retstr = 0LL;
		  HG::Rendering::RenderGraphModule::TextureHandle::TextureHandle(retstr, v13, 0, 0LL);
		  return retstr;
		}
		
		[IDTag(1)]
		internal TextureHandle ImportTexture(RTHandle rt, int width, int height) => default; // 0x0000000189B3A84C-0x0000000189B3AA38
		// TextureHandle ImportTexture(RTHandle, Int32, Int32)
		TextureHandle *HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ImportTexture(
		        TextureHandle *__return_ptr retstr,
		        HGRenderGraphResourceRegistry *this,
		        RTHandle *rt,
		        int32_t width,
		        int32_t height,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *v11; // rcx
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rax
		  int32_t v13; // eax
		  PropertyInfo_1 *v14; // r8
		  Int32__Array **v15; // r9
		  int32_t v16; // r12d
		  Object_1 *m_RT; // rbx
		  Object *v18; // r14
		  DepthBits__Enum v19; // ebx
		  GraphicsFormat__Enum depthStencilFormat; // eax
		  GraphicsFormat__Enum SupportedFormatForDepth; // eax
		  GraphicsFormat__Enum v22; // ebx
		  MethodInfo *v24; // [rsp+20h] [rbp-40h]
		  Object *outRes; // [rsp+40h] [rbp-20h] BYREF
		  TextureHandle v26; // [rsp+48h] [rbp-18h] BYREF
		  DepthBits__Enum depthBits; // [rsp+90h] [rbp+30h] BYREF
		
		  outRes = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(140, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(140, 0LL);
		    if ( Patch )
		    {
		      *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_63(
		                   &v26,
		                   Patch,
		                   (Object *)this,
		                   (Object *)rt,
		                   width,
		                   height,
		                   0LL);
		      return retstr;
		    }
		    goto LABEL_23;
		  }
		  m_RenderGraphResources = this->fields.m_RenderGraphResources;
		  if ( !m_RenderGraphResources )
		    goto LABEL_23;
		  if ( !m_RenderGraphResources->max_length.size )
		    sub_1800D2AB0(v11, Patch);
		  v11 = m_RenderGraphResources->vector[0];
		  if ( !v11 )
		    goto LABEL_23;
		  v13 = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::HGRenderGraphResourcesData::AddNewRenderGraphResource<System::Object>(
		          v11,
		          &outRes,
		          1,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::HGRenderGraphResourcesData::AddNewRenderGraphResource<HG::Rendering::RenderGraphModule::TextureResource>);
		  v11 = (HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *)outRes;
		  v16 = v13;
		  if ( !outRes )
		    goto LABEL_23;
		  outRes[9].monitor = (MonitorData *)rt;
		  sub_18002D1B0((SingleFieldAccessor *)&v11[3].monitor, (Type *)Patch, v14, v15, v24);
		  if ( !outRes )
		    goto LABEL_23;
		  LOBYTE(outRes[1].klass) = 1;
		  if ( !rt )
		    goto LABEL_21;
		  m_RT = (Object_1 *)rt->fields.m_RT;
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  if ( !UnityEngine::Object::op_Inequality(m_RT, 0LL, 0LL) )
		    goto LABEL_21;
		  v18 = outRes;
		  v19 = DepthBits__Enum_None;
		  depthBits = DepthBits__Enum_None;
		  if ( !outRes )
		    goto LABEL_23;
		  v11 = (HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *)rt->fields.m_RT;
		  if ( !v11 )
		    goto LABEL_23;
		  depthStencilFormat = UnityEngine::RenderTexture::get_depthStencilFormat((RenderTexture *)v11, 0LL);
		  v11 = (HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *)rt->fields.m_RT;
		  if ( depthStencilFormat )
		  {
		    if ( !v11 )
		      goto LABEL_23;
		    v22 = UnityEngine::RenderTexture::get_depthStencilFormat((RenderTexture *)v11, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		    SupportedFormatForDepth = HG::Rendering::Runtime::HGUtils::GetSupportedFormatForDepth(v22, &depthBits, 0LL);
		    v19 = depthBits;
		  }
		  else
		  {
		    if ( !v11 )
		      goto LABEL_23;
		    SupportedFormatForDepth = UnityEngine::RenderTexture::get_graphicsFormat((RenderTexture *)v11, 0LL);
		  }
		  LODWORD(v18[4].monitor) = SupportedFormatForDepth;
		  if ( !outRes
		    || (LODWORD(outRes[3].monitor) = width,
		        (v11 = (HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *)outRes) == 0LL)
		    || (HIDWORD(outRes[3].monitor) = height, !outRes) )
		  {
		LABEL_23:
		    sub_1800D8260(v11, Patch);
		  }
		  HIDWORD(outRes[4].klass) = v19;
		LABEL_21:
		  *retstr = 0LL;
		  HG::Rendering::RenderGraphModule::TextureHandle::TextureHandle(retstr, v16, 0, 0LL);
		  return retstr;
		}
		
		internal TextureHandle ImportDepthbuffer(RTHandle rt) => default; // 0x0000000189B3A6A8-0x0000000189B3A84C
		// TextureHandle ImportDepthbuffer(RTHandle)
		TextureHandle *HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ImportDepthbuffer(
		        TextureHandle *__return_ptr retstr,
		        HGRenderGraphResourceRegistry *this,
		        RTHandle *rt,
		        MethodInfo *method)
		{
		  Type *v7; // rdx
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *v8; // rcx
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rax
		  int32_t v10; // eax
		  PropertyInfo_1 *v11; // r8
		  Int32__Array **v12; // r9
		  int32_t v13; // ebp
		  Object_1 *m_RT; // rbx
		  Object *v15; // rbx
		  Object *v16; // rbx
		  Object *v17; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v20; // [rsp+20h] [rbp-28h]
		  TextureHandle v21; // [rsp+30h] [rbp-18h] BYREF
		  Object *outRes; // [rsp+50h] [rbp+8h] BYREF
		
		  outRes = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(142, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(142, 0LL);
		    if ( Patch )
		    {
		      *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_62(&v21, Patch, (Object *)this, (Object *)rt, 0LL);
		      return retstr;
		    }
		    goto LABEL_20;
		  }
		  m_RenderGraphResources = this->fields.m_RenderGraphResources;
		  if ( !m_RenderGraphResources )
		    goto LABEL_20;
		  if ( !m_RenderGraphResources->max_length.size )
		    sub_1800D2AB0(v8, v7);
		  v8 = m_RenderGraphResources->vector[0];
		  if ( !v8 )
		    goto LABEL_20;
		  v10 = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::HGRenderGraphResourcesData::AddNewRenderGraphResource<System::Object>(
		          v8,
		          &outRes,
		          1,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::HGRenderGraphResourcesData::AddNewRenderGraphResource<HG::Rendering::RenderGraphModule::TextureResource>);
		  v8 = (HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *)outRes;
		  v13 = v10;
		  if ( !outRes )
		    goto LABEL_20;
		  outRes[9].monitor = (MonitorData *)rt;
		  sub_18002D1B0((SingleFieldAccessor *)&v8[3].monitor, v7, v11, v12, v20);
		  if ( !outRes )
		    goto LABEL_20;
		  LOBYTE(outRes[1].klass) = 1;
		  v8 = (HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *)outRes;
		  if ( !outRes )
		    goto LABEL_20;
		  HIDWORD(outRes[4].klass) = 32;
		  if ( !rt )
		    goto LABEL_18;
		  m_RT = (Object_1 *)rt->fields.m_RT;
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  if ( !UnityEngine::Object::op_Inequality(m_RT, 0LL, 0LL) )
		    goto LABEL_18;
		  v15 = outRes;
		  if ( !outRes
		    || (v8 = (HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *)rt->fields.m_RT) == 0LL
		    || (LODWORD(v15[4].monitor) = UnityEngine::RenderTexture::get_depthStencilFormat((RenderTexture *)v8, 0LL),
		        (v16 = outRes) == 0LL)
		    || (v7 = (Type *)rt->fields.m_RT) == 0LL
		    || (LODWORD(v16[3].monitor) = sub_180002F70(5LL, v7), (v17 = outRes) == 0LL)
		    || (v7 = (Type *)rt->fields.m_RT) == 0LL )
		  {
		LABEL_20:
		    sub_1800D8260(v8, v7);
		  }
		  HIDWORD(v17[3].monitor) = sub_180002F70(7LL, v7);
		LABEL_18:
		  *retstr = 0LL;
		  HG::Rendering::RenderGraphModule::TextureHandle::TextureHandle(retstr, v13, 0, 0LL);
		  return retstr;
		}
		
		internal TextureHandle PreserveTexture(ref TextureHandle texture, int frameCount, HGRenderGraphContext context, string info) => default; // 0x0000000189B3B2B4-0x0000000189B3B598
		// TextureHandle PreserveTexture(TextureHandle ByRef, Int32, HGRenderGraphContext, String)
		TextureHandle *HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::PreserveTexture(
		        TextureHandle *__return_ptr retstr,
		        HGRenderGraphResourceRegistry *this,
		        TextureHandle *texture,
		        int32_t frameCount,
		        HGRenderGraphContext *context,
		        String *info,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  DynamicArray_1_System_Object_ *v12; // rcx
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rbx
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *v14; // rbx
		  DynamicArray_1_System_Object_ *resourceArray; // rbp
		  int32_t index; // eax
		  Object **Item; // rax
		  int32_t m_currentExecutorID; // r12d
		  int32_t m_currentExecutorFrameIndex; // edi
		  Object *v20; // rbp
		  int v21; // eax
		  int32_t v22; // ebp
		  int32_t v23; // edi
		  Object *v24; // rcx
		  SingleFieldAccessor *v25; // rdi
		  __int64 v26; // rax
		  PropertyInfo_1 *v27; // r8
		  Int32__Array **v28; // r9
		  DynamicArray_1_System_Object_ *v29; // rdi
		  int32_t v30; // eax
		  Object **v31; // rax
		  __int64 v32; // rax
		  TextureResource *v33; // r14
		  Object *v34; // rdi
		  HGRenderGraphResourceRegistry_ResourceCallback *createResourceCallback; // rbx
		  TextureResource *v36; // rdi
		  TextureHandle v37; // xmm0
		  int32_t v39; // [rsp+20h] [rbp-48h]
		  MethodInfo *v40; // [rsp+20h] [rbp-48h]
		  TextureHandle v41; // [rsp+40h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(158, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(158, 0LL);
		    if ( !Patch )
		      goto LABEL_30;
		    v37 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_79(
		             &v41,
		             Patch,
		             (Object *)this,
		             texture,
		             frameCount,
		             (Object *)context,
		             (Object *)info,
		             0LL);
		LABEL_32:
		    *retstr = v37;
		    return retstr;
		  }
		  m_RenderGraphResources = this->fields.m_RenderGraphResources;
		  if ( !m_RenderGraphResources )
		    goto LABEL_30;
		  if ( !m_RenderGraphResources->max_length.size )
		    sub_1800D2AB0(v12, Patch);
		  v14 = m_RenderGraphResources->vector[0];
		  if ( !v14 )
		    goto LABEL_30;
		  resourceArray = (DynamicArray_1_System_Object_ *)v14->fields.resourceArray;
		  sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
		  index = HG::Rendering::RenderGraphModule::ResourceHandle::get_index(&texture->handle, 0LL);
		  if ( !resourceArray )
		    goto LABEL_30;
		  Item = UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
		           resourceArray,
		           index,
		           MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
		  m_currentExecutorID = this->fields.m_currentExecutorID;
		  m_currentExecutorFrameIndex = this->fields.m_currentExecutorFrameIndex;
		  v20 = *Item;
		  if ( !sub_180005130(*Item, TypeInfo::HG::Rendering::RenderGraphModule::TextureResource) )
		    goto LABEL_30;
		  v21 = sub_180005130(v20, TypeInfo::HG::Rendering::RenderGraphModule::TextureResource);
		  v39 = frameCount;
		  sub_180517340(14, v21, m_currentExecutorID, m_currentExecutorFrameIndex, v39);
		  if ( HG::Rendering::RenderGraphModule::ResourceHandle::IsPreserved(&texture->handle, 0LL) )
		  {
		    v37 = *texture;
		    goto LABEL_32;
		  }
		  v22 = -1;
		  v23 = 0;
		  while ( 1 )
		  {
		    v12 = (DynamicArray_1_System_Object_ *)v14->fields.resourceArray;
		    if ( !v12 )
		      goto LABEL_30;
		    v24 = *UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
		             v12,
		             v23,
		             MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
		    if ( !v24 || !BYTE1(v24[1].klass) )
		      break;
		    if ( ++v23 >= 64 )
		      goto LABEL_16;
		  }
		  v22 = v23;
		LABEL_16:
		  v12 = (DynamicArray_1_System_Object_ *)v14->fields.resourceArray;
		  if ( !v12 )
		    goto LABEL_30;
		  if ( !*UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
		           v12,
		           v22,
		           MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item) )
		  {
		    v12 = (DynamicArray_1_System_Object_ *)v14->fields.resourceArray;
		    if ( !v12 )
		      goto LABEL_30;
		    v25 = (SingleFieldAccessor *)UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
		                                   v12,
		                                   v22,
		                                   MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
		    v26 = sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::TextureResource);
		    if ( !v26 )
		      goto LABEL_30;
		    v25->klass = (SingleFieldAccessor__Class *)v26;
		    sub_18002D1B0(v25, (Type *)Patch, v27, v28, v40);
		  }
		  v29 = (DynamicArray_1_System_Object_ *)v14->fields.resourceArray;
		  sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
		  v30 = HG::Rendering::RenderGraphModule::ResourceHandle::get_index(&texture->handle, 0LL);
		  if ( !v29 )
		    goto LABEL_30;
		  v31 = UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
		          v29,
		          v30,
		          MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
		  v32 = sub_180005130(*v31, TypeInfo::HG::Rendering::RenderGraphModule::TextureResource);
		  v12 = (DynamicArray_1_System_Object_ *)v14->fields.resourceArray;
		  v33 = (TextureResource *)v32;
		  if ( !v12 )
		    goto LABEL_30;
		  v34 = *UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
		           v12,
		           v22,
		           MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
		  if ( !v33 )
		    goto LABEL_30;
		  sub_1808ADC58(v12, v33, 0LL, info);
		  createResourceCallback = v14->fields.createResourceCallback;
		  v36 = (TextureResource *)sub_180005130(v34, TypeInfo::HG::Rendering::RenderGraphModule::TextureResource);
		  if ( createResourceCallback )
		    ((void (__fastcall *)(void *, HGRenderGraphContext *, TextureResource *, void *))createResourceCallback->fields._._.invoke_impl)(
		      createResourceCallback->fields._._.method_code,
		      context,
		      v33,
		      createResourceCallback->fields._._.method);
		  if ( !v36 )
		LABEL_30:
		    sub_1800D8260(v12, Patch);
		  HG::Rendering::RenderGraphModule::TextureResource::CopyFrom(v36, v33, 0LL);
		  *retstr = 0LL;
		  HG::Rendering::RenderGraphModule::TextureHandle::TextureHandle(retstr, v22, 1, 0LL);
		  return retstr;
		}
		
		internal void ReleasePreservedTexture(TextureHandle texture) {} // 0x0000000189B3B6DC-0x0000000189B3B7F0
		// Void ReleasePreservedTexture(TextureHandle)
		void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ReleasePreservedTexture(
		        HGRenderGraphResourceRegistry *this,
		        TextureHandle *texture,
		        MethodInfo *method)
		{
		  TextureResource *TextureResource; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  __int64 v8; // r9
		  TextureResource *v9; // rbx
		  __int64 v10; // rax
		  ProtocolViolationException *v11; // rbx
		  String *v12; // rax
		  __int64 v13; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  TextureHandle v15; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(310, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(310, 0LL);
		    if ( Patch )
		    {
		      v15 = *texture;
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_146(Patch, (Object *)this, &v15, 0LL);
		      return;
		    }
		LABEL_10:
		    sub_1800D8260(v7, v6);
		  }
		  sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
		  if ( HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit(texture->handle, 0LL) >= 64 )
		  {
		    v10 = sub_18007E180(&TypeInfo::System::InvalidOperationException);
		    v11 = (ProtocolViolationException *)sub_18002C620(v10);
		    if ( v11 )
		    {
		      v12 = (String *)sub_18007E180(&off_18E25C020);
		      System::Net::ProtocolViolationException::ProtocolViolationException(v11, v12, 0LL);
		      v13 = sub_18007E180(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ReleasePreservedTexture);
		      sub_18007E190(v11, v13);
		    }
		    goto LABEL_10;
		  }
		  TextureResource = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetTextureResource(
		                      this,
		                      &texture->handle,
		                      0LL);
		  v9 = TextureResource;
		  if ( !TextureResource )
		    goto LABEL_10;
		  if ( TextureResource->fields._.graphicsResource )
		  {
		    LOBYTE(v8) = 1;
		    sub_1800732B0(12LL, TextureResource, (unsigned int)this->fields.m_CurrentFrameIndex, v8);
		  }
		  sub_180082E60(v7, v9, 0LL);
		}
		
		internal TextureHandle ImportBackbuffer(RenderTargetIdentifier rt, ref TextureDesc desc, BackBufferType type) => default; // 0x0000000189B3A368-0x0000000189B3A5D0
		// TextureHandle ImportBackbuffer(RenderTargetIdentifier, TextureDesc ByRef, HGRenderGraphResourceRegistry+BackBufferType)
		TextureHandle *HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ImportBackbuffer(
		        TextureHandle *__return_ptr retstr,
		        HGRenderGraphResourceRegistry *this,
		        RenderTargetIdentifier *rt,
		        TextureDesc *desc,
		        HGRenderGraphResourceRegistry_BackBufferType__Enum type,
		        MethodInfo *method)
		{
		  Object *v10; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  ILFixDynamicMethodWrapper_2__Class **v12; // rsi
		  String *v13; // rax
		  String *v14; // rbx
		  __int128 v15; // xmm1
		  Type *v16; // rdx
		  PropertyInfo_1 *v17; // r8
		  Int32__Array **v18; // r9
		  __int128 v19; // xmm1
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rax
		  PropertyInfo_1 *v21; // r8
		  Int32__Array **v22; // r9
		  PropertyInfo_1 *v23; // r8
		  Int32__Array **v24; // r9
		  __int128 v25; // xmm1
		  __int128 v26; // xmm2
		  __int128 v27; // xmm3
		  __int128 v28; // xmm4
		  Color clearColor; // xmm5
		  int32_t v30; // r10d
		  __int128 v31; // xmm1
		  MethodInfo *v33; // [rsp+20h] [rbp-59h]
		  MethodInfo *v34; // [rsp+20h] [rbp-59h]
		  RenderTargetIdentifier v35; // [rsp+40h] [rbp-39h] BYREF
		  RenderTargetIdentifier v36; // [rsp+70h] [rbp-9h] BYREF
		  Object *outRes; // [rsp+D0h] [rbp+57h] BYREF
		
		  outRes = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(144, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(144, 0LL);
		    if ( Patch )
		    {
		      v31 = *(_OWORD *)&rt->m_BufferPointer;
		      *(_OWORD *)&v36.m_Type = *(_OWORD *)&rt->m_Type;
		      *(_QWORD *)&v36.m_DepthSlice = *(_QWORD *)&rt->m_DepthSlice;
		      *(_OWORD *)&v36.m_BufferPointer = v31;
		      *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_64(
		                   (TextureHandle *)&v35,
		                   Patch,
		                   (Object *)this,
		                   &v36,
		                   desc,
		                   type,
		                   0LL);
		      return retstr;
		    }
		    goto LABEL_17;
		  }
		  Patch = (ILFixDynamicMethodWrapper_2 *)this->fields.m_CurrentBackbuffer;
		  if ( !Patch )
		    goto LABEL_17;
		  v10 = (Object *)(int)type;
		  if ( type >= Patch->fields.methodId )
		LABEL_15:
		    sub_1800D2AB0(v10, Patch);
		  v12 = &Patch->klass + (int)type;
		  if ( v12[4] )
		  {
		    v10 = (Object *)v12[4];
		    if ( !v10 )
		      goto LABEL_17;
		    v19 = *(_OWORD *)&rt->m_BufferPointer;
		    *(_OWORD *)&v35.m_Type = *(_OWORD *)&rt->m_Type;
		    *(_QWORD *)&v35.m_DepthSlice = *(_QWORD *)&rt->m_DepthSlice;
		    *(_OWORD *)&v35.m_BufferPointer = v19;
		    UnityEngine::Rendering::RTHandle::SetTexture((RTHandle *)v10, &v35, 0LL);
		  }
		  else
		  {
		    *(_QWORD *)&v35.m_InstanceID = -1LL;
		    LODWORD(v35.m_BufferPointer) = type;
		    *(_QWORD *)&v35.m_Type = TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::BackBufferType;
		    v13 = System::Enum::ToString((Enum *)&v35, 0LL);
		    v14 = System::String::Concat((String *)"Backbuffer", v13, 0LL);
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::RTHandles);
		    v15 = *(_OWORD *)&rt->m_BufferPointer;
		    *(_OWORD *)&v35.m_Type = *(_OWORD *)&rt->m_Type;
		    *(_QWORD *)&v35.m_DepthSlice = *(_QWORD *)&rt->m_DepthSlice;
		    *(_OWORD *)&v35.m_BufferPointer = v15;
		    v12[4] = (ILFixDynamicMethodWrapper_2__Class *)UnityEngine::Rendering::RTHandles::Alloc(&v35, v14, 0LL);
		    sub_18002D1B0((SingleFieldAccessor *)(v12 + 4), v16, v17, v18, v33);
		  }
		  m_RenderGraphResources = this->fields.m_RenderGraphResources;
		  if ( !m_RenderGraphResources )
		LABEL_17:
		    sub_1800D8260(v10, Patch);
		  if ( !m_RenderGraphResources->max_length.size )
		    goto LABEL_15;
		  v10 = (Object *)m_RenderGraphResources->vector[0];
		  if ( !v10 )
		    goto LABEL_17;
		  HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::HGRenderGraphResourcesData::AddNewRenderGraphResource<System::Object>(
		    (HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *)v10,
		    &outRes,
		    1,
		    MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::HGRenderGraphResourcesData::AddNewRenderGraphResource<HG::Rendering::RenderGraphModule::TextureResource>);
		  v10 = outRes;
		  Patch = (ILFixDynamicMethodWrapper_2 *)v12[4];
		  if ( !outRes )
		    goto LABEL_17;
		  outRes[9].monitor = (MonitorData *)Patch;
		  sub_18002D1B0((SingleFieldAccessor *)&v10[9].monitor, (Type *)Patch, v21, v22, v33);
		  v24 = (Int32__Array **)outRes;
		  if ( !outRes )
		    goto LABEL_17;
		  LOBYTE(outRes[1].klass) = 1;
		  v10 = outRes;
		  v25 = *(_OWORD *)&desc->colorFormat;
		  v26 = *(_OWORD *)&desc->enableRandomWrite;
		  v27 = *(_OWORD *)&desc->bindTextureMS;
		  v28 = *(_OWORD *)&desc->fastMemoryDesc.inFastMemory;
		  clearColor = desc->clearColor;
		  if ( !outRes )
		    goto LABEL_17;
		  *(Object *)((char *)outRes + 56) = *(Object *)&desc->width;
		  *(_OWORD *)&v10[4].monitor = v25;
		  *(_OWORD *)&v10[5].monitor = v26;
		  *(_OWORD *)&v10[6].monitor = v27;
		  *(_OWORD *)&v10[7].monitor = v28;
		  *(Color *)&v10[8].monitor = clearColor;
		  sub_18002D1B0((SingleFieldAccessor *)&v10[7], (Type *)Patch, v23, v24, v34);
		  *retstr = 0LL;
		  HG::Rendering::RenderGraphModule::TextureHandle::TextureHandle(retstr, v30, 0, 0LL);
		  return retstr;
		}
		
		internal TextureHandle CreateTexture(ref TextureDesc desc, int transientPassIndex = -1 /* Metadata: 0x02302D76 */) => default; // 0x0000000189B3961C-0x0000000189B39770
		// TextureHandle CreateTexture(TextureDesc ByRef, Int32)
		TextureHandle *HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CreateTexture(
		        TextureHandle *__return_ptr retstr,
		        HGRenderGraphResourceRegistry *this,
		        TextureDesc *desc,
		        int32_t transientPassIndex,
		        MethodInfo *method)
		{
		  Type *v9; // rdx
		  Object *v10; // rcx
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rax
		  PropertyInfo_1 *v12; // r8
		  Int32__Array **v13; // r9
		  __int128 v14; // xmm1
		  __int128 v15; // xmm2
		  __int128 v16; // xmm3
		  __int128 v17; // xmm4
		  Color clearColor; // xmm5
		  int32_t v19; // r10d
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v22; // [rsp+20h] [rbp-28h]
		  TextureHandle v23; // [rsp+30h] [rbp-18h] BYREF
		  Object *outRes; // [rsp+50h] [rbp+8h] BYREF
		
		  outRes = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(147, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(147, 0LL);
		    if ( Patch )
		    {
		      *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_68(
		                   &v23,
		                   Patch,
		                   (Object *)this,
		                   desc,
		                   transientPassIndex,
		                   0LL);
		      return retstr;
		    }
		LABEL_11:
		    sub_1800D8260(v10, v9);
		  }
		  HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ValidateTextureDesc(this, desc, 0LL);
		  m_RenderGraphResources = this->fields.m_RenderGraphResources;
		  if ( !m_RenderGraphResources )
		    goto LABEL_11;
		  if ( !m_RenderGraphResources->max_length.size )
		    sub_1800D2AB0(v10, v9);
		  v10 = (Object *)m_RenderGraphResources->vector[0];
		  if ( !v10 )
		    goto LABEL_11;
		  HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::HGRenderGraphResourcesData::AddNewRenderGraphResource<System::Object>(
		    (HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *)v10,
		    &outRes,
		    1,
		    MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::HGRenderGraphResourcesData::AddNewRenderGraphResource<HG::Rendering::RenderGraphModule::TextureResource>);
		  v10 = outRes;
		  v14 = *(_OWORD *)&desc->colorFormat;
		  v15 = *(_OWORD *)&desc->enableRandomWrite;
		  v16 = *(_OWORD *)&desc->bindTextureMS;
		  v17 = *(_OWORD *)&desc->fastMemoryDesc.inFastMemory;
		  clearColor = desc->clearColor;
		  if ( !outRes )
		    goto LABEL_11;
		  *(Object *)((char *)outRes + 56) = *(Object *)&desc->width;
		  *(_OWORD *)&v10[4].monitor = v14;
		  *(_OWORD *)&v10[5].monitor = v15;
		  *(_OWORD *)&v10[6].monitor = v16;
		  *(_OWORD *)&v10[7].monitor = v17;
		  *(Color *)&v10[8].monitor = clearColor;
		  sub_18002D1B0((SingleFieldAccessor *)&v10[7], v9, v12, v13, v22);
		  if ( !outRes )
		    goto LABEL_11;
		  HIDWORD(outRes[1].monitor) = transientPassIndex;
		  LOBYTE(v10) = desc->fallBackToBlackTexture;
		  if ( !outRes )
		    goto LABEL_11;
		  BYTE2(outRes[1].klass) = (_BYTE)v10;
		  *retstr = 0LL;
		  HG::Rendering::RenderGraphModule::TextureHandle::TextureHandle(retstr, v19, 0, 0LL);
		  return retstr;
		}
		
		internal int GetTextureResourceCount() => default; // 0x0000000189B39EE4-0x0000000189B39F54
		// Int32 GetTextureResourceCount()
		int32_t HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetTextureResourceCount(
		        HGRenderGraphResourceRegistry *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rax
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *v6; // rax
		  DynamicArray_1_HG_Rendering_RenderGraphModule_IHGRenderGraphResource_ *resourceArray; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(32, 0LL) )
		  {
		    m_RenderGraphResources = this->fields.m_RenderGraphResources;
		    if ( m_RenderGraphResources )
		    {
		      if ( !m_RenderGraphResources->max_length.size )
		        sub_1800D2AB0(v4, v3);
		      v6 = m_RenderGraphResources->vector[0];
		      if ( v6 )
		      {
		        resourceArray = v6->fields.resourceArray;
		        if ( resourceArray )
		          return resourceArray->fields._size_k__BackingField;
		      }
		    }
		LABEL_9:
		    sub_1800D8260(v4, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(32, 0LL);
		  if ( !Patch )
		    goto LABEL_9;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		}
		
		private TextureResource GetTextureResource([IsReadOnly] in ResourceHandle handle) => default; // 0x0000000189B3A194-0x0000000189B3A254
		// TextureResource GetTextureResource(ResourceHandle ByRef)
		TextureResource *HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetTextureResource(
		        HGRenderGraphResourceRegistry *this,
		        ResourceHandle *handle,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *v6; // rcx
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rax
		  DynamicArray_1_System_Object_ *resourceArray; // rsi
		  ResourceHandle v9; // rbx
		  int32_t v10; // eax
		  Object **Item; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(240, 0LL) )
		  {
		    m_RenderGraphResources = this->fields.m_RenderGraphResources;
		    if ( m_RenderGraphResources )
		    {
		      if ( !m_RenderGraphResources->max_length.size )
		        sub_1800D2AB0(v6, v5);
		      v6 = m_RenderGraphResources->vector[0];
		      if ( v6 )
		      {
		        resourceArray = (DynamicArray_1_System_Object_ *)v6->fields.resourceArray;
		        v9 = *handle;
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
		        v10 = HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit(v9, 0LL);
		        if ( resourceArray )
		        {
		          Item = UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
		                   resourceArray,
		                   v10,
		                   MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
		          return (TextureResource *)sub_180005050(*Item, TypeInfo::HG::Rendering::RenderGraphModule::TextureResource);
		        }
		      }
		    }
		LABEL_9:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(240, 0LL);
		  if ( !Patch )
		    goto LABEL_9;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_116(Patch, (Object *)this, handle, 0LL);
		}
		
		internal TextureDesc GetTextureResourceDesc([IsReadOnly] in ResourceHandle handle) => default; // 0x0000000189B3A038-0x0000000189B3A194
		// TextureDesc GetTextureResourceDesc(ResourceHandle ByRef)
		TextureDesc *HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetTextureResourceDesc(
		        TextureDesc *__return_ptr retstr,
		        HGRenderGraphResourceRegistry *this,
		        ResourceHandle *handle,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *v8; // rcx
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rax
		  DynamicArray_1_System_Object_ *resourceArray; // rsi
		  ResourceHandle v11; // rbx
		  int32_t v12; // eax
		  Object **Item; // rax
		  Object *v14; // rbx
		  __int64 v15; // rax
		  __int128 v16; // xmm1
		  __int128 v17; // xmm0
		  __int128 v18; // xmm1
		  __int128 v19; // xmm0
		  Color clearColor; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  TextureDesc *v22; // rax
		  __int128 v23; // xmm1
		  __int128 v24; // xmm0
		  __int128 v25; // xmm1
		  TextureDesc *result; // rax
		  TextureDesc v27; // [rsp+30h] [rbp-68h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(155, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(155, 0LL);
		    if ( Patch )
		    {
		      v22 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_75(&v27, Patch, (Object *)this, handle, 0LL);
		      v23 = *(_OWORD *)&v22->colorFormat;
		      *(_OWORD *)&retstr->width = *(_OWORD *)&v22->width;
		      v24 = *(_OWORD *)&v22->enableRandomWrite;
		      *(_OWORD *)&retstr->colorFormat = v23;
		      v25 = *(_OWORD *)&v22->bindTextureMS;
		      *(_OWORD *)&retstr->enableRandomWrite = v24;
		      v19 = *(_OWORD *)&v22->fastMemoryDesc.inFastMemory;
		      *(_OWORD *)&retstr->bindTextureMS = v25;
		      clearColor = v22->clearColor;
		      goto LABEL_12;
		    }
		LABEL_10:
		    sub_1800D8260(v8, v7);
		  }
		  m_RenderGraphResources = this->fields.m_RenderGraphResources;
		  if ( !m_RenderGraphResources )
		    goto LABEL_10;
		  if ( !m_RenderGraphResources->max_length.size )
		    sub_1800D2AB0(v8, v7);
		  v8 = m_RenderGraphResources->vector[0];
		  if ( !v8 )
		    goto LABEL_10;
		  resourceArray = (DynamicArray_1_System_Object_ *)v8->fields.resourceArray;
		  v11 = *handle;
		  sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
		  v12 = HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit(v11, 0LL);
		  if ( !resourceArray )
		    goto LABEL_10;
		  Item = UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
		           resourceArray,
		           v12,
		           MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
		  v14 = *Item;
		  if ( !sub_180005050(*Item, TypeInfo::HG::Rendering::RenderGraphModule::TextureResource) )
		    goto LABEL_10;
		  v15 = sub_180005050(v14, TypeInfo::HG::Rendering::RenderGraphModule::TextureResource);
		  v16 = *(_OWORD *)(v15 + 72);
		  *(_OWORD *)&retstr->width = *(_OWORD *)(v15 + 56);
		  v17 = *(_OWORD *)(v15 + 88);
		  *(_OWORD *)&retstr->colorFormat = v16;
		  v18 = *(_OWORD *)(v15 + 104);
		  *(_OWORD *)&retstr->enableRandomWrite = v17;
		  v19 = *(_OWORD *)(v15 + 120);
		  *(_OWORD *)&retstr->bindTextureMS = v18;
		  clearColor = *(Color *)(v15 + 136);
		LABEL_12:
		  result = retstr;
		  *(_OWORD *)&retstr->fastMemoryDesc.inFastMemory = v19;
		  retstr->clearColor = clearColor;
		  return result;
		}
		
		internal ref TextureDesc GetTextureResourceDescRef(ref ResourceHandle handle) => ref _refReturnTypeForGetTextureResourceDescRef; // 0x0000000189B39F54-0x0000000189B3A038
		// TextureDesc& GetTextureResourceDescRef(ResourceHandle ByRef)
		TextureDesc *HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetTextureResourceDescRef(
		        HGRenderGraphResourceRegistry *this,
		        ResourceHandle *handle,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *v6; // rcx
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rax
		  DynamicArray_1_System_Object_ *resourceArray; // rsi
		  ResourceHandle v9; // rbx
		  int32_t v10; // eax
		  Object **Item; // rax
		  Object *v12; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(150, 0LL) )
		  {
		    m_RenderGraphResources = this->fields.m_RenderGraphResources;
		    if ( m_RenderGraphResources )
		    {
		      if ( !m_RenderGraphResources->max_length.size )
		        sub_1800D2AB0(v6, v5);
		      v6 = m_RenderGraphResources->vector[0];
		      if ( v6 )
		      {
		        resourceArray = (DynamicArray_1_System_Object_ *)v6->fields.resourceArray;
		        v9 = *handle;
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
		        v10 = HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit(v9, 0LL);
		        if ( resourceArray )
		        {
		          Item = UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
		                   resourceArray,
		                   v10,
		                   MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
		          v12 = *Item;
		          if ( sub_180005050(*Item, TypeInfo::HG::Rendering::RenderGraphModule::TextureResource) )
		            return (TextureDesc *)(sub_180005050(v12, TypeInfo::HG::Rendering::RenderGraphModule::TextureResource) + 56);
		        }
		      }
		    }
		LABEL_10:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(150, 0LL);
		  if ( !Patch )
		    goto LABEL_10;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_70(Patch, (Object *)this, handle, 0LL);
		}
		
		private ref TextureDesc _refReturnTypeForGetTextureResourceDescRef; // Dummy field
		internal bool TextureNeedsClear([IsReadOnly] in ResourceHandle handle) => default; // 0x0000000189B3BA88-0x0000000189B3BB6C
		// Boolean TextureNeedsClear(ResourceHandle ByRef)
		bool HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::TextureNeedsClear(
		        HGRenderGraphResourceRegistry *this,
		        ResourceHandle *handle,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *v6; // rcx
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rax
		  DynamicArray_1_System_Object_ *resourceArray; // rsi
		  ResourceHandle v9; // rbx
		  int32_t v10; // eax
		  Object **Item; // rax
		  Object *v12; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(167, 0LL) )
		  {
		    m_RenderGraphResources = this->fields.m_RenderGraphResources;
		    if ( m_RenderGraphResources )
		    {
		      if ( !m_RenderGraphResources->max_length.size )
		        sub_1800D2AB0(v6, v5);
		      v6 = m_RenderGraphResources->vector[0];
		      if ( v6 )
		      {
		        resourceArray = (DynamicArray_1_System_Object_ *)v6->fields.resourceArray;
		        v9 = *handle;
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
		        v10 = HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit(v9, 0LL);
		        if ( resourceArray )
		        {
		          Item = UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
		                   resourceArray,
		                   v10,
		                   MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
		          v12 = *Item;
		          if ( sub_180005050(*Item, TypeInfo::HG::Rendering::RenderGraphModule::TextureResource) )
		            return *(_BYTE *)(sub_180005050(v12, TypeInfo::HG::Rendering::RenderGraphModule::TextureResource) + 160);
		        }
		      }
		    }
		LABEL_10:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(167, 0LL);
		  if ( !Patch )
		    goto LABEL_10;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_24(Patch, (Object *)this, handle, 0LL);
		}
		
		internal void MarkTextureNeedsClearFlag([IsReadOnly] in ResourceHandle handle, bool flag) {} // 0x0000000189B3B1BC-0x0000000189B3B2B4
		// Void MarkTextureNeedsClearFlag(ResourceHandle ByRef, Boolean)
		void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::MarkTextureNeedsClearFlag(
		        HGRenderGraphResourceRegistry *this,
		        ResourceHandle *handle,
		        bool flag,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *v8; // rcx
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rax
		  DynamicArray_1_System_Object_ *resourceArray; // rbp
		  ResourceHandle v11; // rbx
		  int32_t v12; // eax
		  Object **Item; // rax
		  Object *v14; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(169, 0LL) )
		  {
		    m_RenderGraphResources = this->fields.m_RenderGraphResources;
		    if ( m_RenderGraphResources )
		    {
		      if ( !m_RenderGraphResources->max_length.size )
		        sub_1800D2AB0(v8, v7);
		      v8 = m_RenderGraphResources->vector[0];
		      if ( v8 )
		      {
		        resourceArray = (DynamicArray_1_System_Object_ *)v8->fields.resourceArray;
		        v11 = *handle;
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
		        v12 = HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit(v11, 0LL);
		        if ( resourceArray )
		        {
		          Item = UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
		                   resourceArray,
		                   v12,
		                   MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
		          v14 = *Item;
		          if ( sub_180005050(*Item, TypeInfo::HG::Rendering::RenderGraphModule::TextureResource) )
		          {
		            *(_BYTE *)(sub_180005050(v14, TypeInfo::HG::Rendering::RenderGraphModule::TextureResource) + 160) = flag;
		            return;
		          }
		        }
		      }
		    }
		LABEL_10:
		    sub_1800D8260(v8, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(169, 0LL);
		  if ( !Patch )
		    goto LABEL_10;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_81(Patch, (Object *)this, handle, flag, 0LL);
		}
		
		internal void ForceTextureClear([IsReadOnly] in ResourceHandle handle, UnityEngine.Color clearColor) {} // 0x0000000189B39804-0x0000000189B398B0
		// Void ForceTextureClear(ResourceHandle ByRef, Color)
		void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ForceTextureClear(
		        HGRenderGraphResourceRegistry *this,
		        ResourceHandle *handle,
		        Color *clearColor,
		        MethodInfo *method)
		{
		  TextureResource *TextureResource; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  TextureResource *v10; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Color v12; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(245, 0LL) )
		  {
		    TextureResource = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetTextureResource(
		                        this,
		                        handle,
		                        0LL);
		    if ( TextureResource )
		    {
		      TextureResource->fields._.desc.clearBuffer = 1;
		      v10 = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetTextureResource(this, handle, 0LL);
		      if ( v10 )
		      {
		        v10->fields._.desc.clearColor = *clearColor;
		        return;
		      }
		    }
		LABEL_6:
		    sub_1800D8260(v9, v8);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(245, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  v12 = *clearColor;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_118(Patch, (Object *)this, handle, &v12, 0LL);
		}
		
		internal RendererListHandle CreateRendererList([IsReadOnly] in RendererListDesc desc) => default; // 0x0000000189B38ED4-0x0000000189B39038
		// RendererListHandle CreateRendererList(RendererListDesc ByRef)
		RendererListHandle HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CreateRendererList(
		        HGRenderGraphResourceRegistry *this,
		        RendererListDesc *desc,
		        MethodInfo *method)
		{
		  DynamicArray_1_HG_Rendering_RenderGraphModule_RendererListResource_ *m_RendererListResources; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  RendererListResource_1 v10; // [rsp+20h] [rbp-1E8h] BYREF
		  RendererListResource_1 value; // [rsp+110h] [rbp-F8h] BYREF
		  RendererListHandle v12; // [rsp+228h] [rbp+20h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(171, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(171, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_84(Patch, (Object *)this, desc, 0LL);
		  }
		  else
		  {
		    HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ValidateRendererListDesc(this, desc, 0LL);
		    m_RendererListResources = this->fields.m_RendererListResources;
		    sub_18033B9D0(&v10, 0LL, 240LL);
		    UnityEngine::Experimental::Rendering::RenderGraphModule::RendererListResource::RendererListResource(&v10, desc, 0LL);
		    value = v10;
		    if ( !m_RendererListResources )
		      sub_1800D8260(&value.desc.overrideMaterial, 128LL);
		    *(_DWORD *)&v12.m_IsValid = 1;
		    v12._handle_k__BackingField = UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RendererListResource>::Add(
		                                    (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RendererListResource_ *)m_RendererListResources,
		                                    &value,
		                                    MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::RendererListResource>::Add);
		    return v12;
		  }
		}
		
		internal ComputeBufferHandle ImportComputeBuffer(ComputeBuffer computeBuffer) => default; // 0x0000000189B3A5D0-0x0000000189B3A6A8
		// ComputeBufferHandle ImportComputeBuffer(ComputeBuffer)
		ComputeBufferHandle HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ImportComputeBuffer(
		        HGRenderGraphResourceRegistry *this,
		        ComputeBuffer *computeBuffer,
		        MethodInfo *method)
		{
		  Type *v5; // rdx
		  Object *v6; // rcx
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rax
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  int32_t v10; // r10d
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ComputeBufferHandle v13; // [rsp+20h] [rbp-18h] BYREF
		  Object *outRes; // [rsp+58h] [rbp+20h] BYREF
		
		  outRes = 0LL;
		  if ( !IFix::WrappersManagerImpl::IsPatched(174, 0LL) )
		  {
		    m_RenderGraphResources = this->fields.m_RenderGraphResources;
		    if ( m_RenderGraphResources )
		    {
		      if ( m_RenderGraphResources->max_length.size <= 1u )
		        sub_1800D2AB0(v6, v5);
		      v6 = (Object *)m_RenderGraphResources->vector[1];
		      if ( v6 )
		      {
		        HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::HGRenderGraphResourcesData::AddNewRenderGraphResource<System::Object>(
		          (HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *)v6,
		          &outRes,
		          1,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::HGRenderGraphResourcesData::AddNewRenderGraphResource<HG::Rendering::RenderGraphModule::ComputeBufferResource>);
		        v6 = outRes;
		        if ( outRes )
		        {
		          outRes[5].klass = (Object__Class *)computeBuffer;
		          sub_18002D1B0((SingleFieldAccessor *)&v6[5], v5, v8, v9, *(MethodInfo **)&v13);
		          if ( outRes )
		          {
		            v13 = 0LL;
		            LOBYTE(outRes[1].klass) = 1;
		            HG::Rendering::RenderGraphModule::ComputeBufferHandle::ComputeBufferHandle(&v13, v10, 0, 0LL);
		            return v13;
		          }
		        }
		      }
		    }
		LABEL_10:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(174, 0LL);
		  if ( !Patch )
		    goto LABEL_10;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_85(Patch, (Object *)this, (Object *)computeBuffer, 0LL);
		}
		
		internal ComputeBufferHandle CreateComputeBuffer([IsReadOnly] in ComputeBufferDesc desc, int transientPassIndex = -1 /* Metadata: 0x02302D77 */) => default; // 0x0000000189B38C7C-0x0000000189B38D88
		// ComputeBufferHandle CreateComputeBuffer(ComputeBufferDesc ByRef, Int32)
		ComputeBufferHandle HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CreateComputeBuffer(
		        HGRenderGraphResourceRegistry *this,
		        ComputeBufferDesc *desc,
		        int32_t transientPassIndex,
		        MethodInfo *method)
		{
		  Type *v7; // rdx
		  Object *v8; // rcx
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rax
		  PropertyInfo_1 *v10; // r8
		  Int32__Array **v11; // r9
		  String *name; // xmm1_8
		  int32_t v13; // r10d
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v16; // [rsp+20h] [rbp-28h]
		  Object *outRes; // [rsp+30h] [rbp-18h] BYREF
		  ComputeBufferHandle v18; // [rsp+38h] [rbp-10h] BYREF
		
		  outRes = 0LL;
		  if ( !IFix::WrappersManagerImpl::IsPatched(176, 0LL) )
		  {
		    HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ValidateComputeBufferDesc(this, desc, 0LL);
		    m_RenderGraphResources = this->fields.m_RenderGraphResources;
		    if ( m_RenderGraphResources )
		    {
		      if ( m_RenderGraphResources->max_length.size <= 1u )
		        sub_1800D2AB0(v8, v7);
		      v8 = (Object *)m_RenderGraphResources->vector[1];
		      if ( v8 )
		      {
		        HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::HGRenderGraphResourcesData::AddNewRenderGraphResource<System::Object>(
		          (HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *)v8,
		          &outRes,
		          1,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::HGRenderGraphResourcesData::AddNewRenderGraphResource<HG::Rendering::RenderGraphModule::ComputeBufferResource>);
		        v8 = outRes;
		        name = desc->name;
		        if ( outRes )
		        {
		          *(Object *)((char *)outRes + 56) = *(Object *)&desc->count;
		          v8[4].monitor = (MonitorData *)name;
		          sub_18002D1B0((SingleFieldAccessor *)&v8[4].monitor, v7, v10, v11, v16);
		          if ( outRes )
		          {
		            v18 = 0LL;
		            HIDWORD(outRes[1].monitor) = transientPassIndex;
		            HG::Rendering::RenderGraphModule::ComputeBufferHandle::ComputeBufferHandle(&v18, v13, 0, 0LL);
		            return v18;
		          }
		        }
		      }
		    }
		LABEL_10:
		    sub_1800D8260(v8, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(176, 0LL);
		  if ( !Patch )
		    goto LABEL_10;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_87(Patch, (Object *)this, desc, transientPassIndex, 0LL);
		}
		
		internal ComputeBufferDesc GetComputeBufferResourceDesc([IsReadOnly] in ResourceHandle handle) => default; // 0x0000000189B39920-0x0000000189B39A30
		// ComputeBufferDesc GetComputeBufferResourceDesc(ResourceHandle ByRef)
		ComputeBufferDesc *HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetComputeBufferResourceDesc(
		        ComputeBufferDesc *__return_ptr retstr,
		        HGRenderGraphResourceRegistry *this,
		        ResourceHandle *handle,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *v8; // rcx
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rax
		  DynamicArray_1_System_Object_ *resourceArray; // rsi
		  ResourceHandle v11; // rbx
		  int32_t v12; // eax
		  Object **Item; // rax
		  Object *v14; // rbx
		  __int64 v15; // rax
		  __int128 v16; // xmm0
		  String *name; // xmm1_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ComputeBufferDesc *v19; // rax
		  ComputeBufferDesc *result; // rax
		  ComputeBufferDesc v21; // [rsp+30h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(179, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(179, 0LL);
		    if ( Patch )
		    {
		      v19 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_89(&v21, Patch, (Object *)this, handle, 0LL);
		      v16 = *(_OWORD *)&v19->count;
		      name = v19->name;
		      goto LABEL_12;
		    }
		LABEL_10:
		    sub_1800D8260(v8, v7);
		  }
		  m_RenderGraphResources = this->fields.m_RenderGraphResources;
		  if ( !m_RenderGraphResources )
		    goto LABEL_10;
		  if ( m_RenderGraphResources->max_length.size <= 1u )
		    sub_1800D2AB0(v8, v7);
		  v8 = m_RenderGraphResources->vector[1];
		  if ( !v8 )
		    goto LABEL_10;
		  resourceArray = (DynamicArray_1_System_Object_ *)v8->fields.resourceArray;
		  v11 = *handle;
		  sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
		  v12 = HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit(v11, 0LL);
		  if ( !resourceArray )
		    goto LABEL_10;
		  Item = UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
		           resourceArray,
		           v12,
		           MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
		  v14 = *Item;
		  if ( !sub_180005050(*Item, TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferResource) )
		    goto LABEL_10;
		  v15 = sub_180005050(v14, TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferResource);
		  v16 = *(_OWORD *)(v15 + 56);
		  name = *(String **)(v15 + 72);
		LABEL_12:
		  result = retstr;
		  *(_OWORD *)&retstr->count = v16;
		  retstr->name = name;
		  return result;
		}
		
		internal int GetComputeBufferResourceCount() => default; // 0x0000000189B398B0-0x0000000189B39920
		// Int32 GetComputeBufferResourceCount()
		int32_t HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetComputeBufferResourceCount(
		        HGRenderGraphResourceRegistry *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rax
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *v6; // rax
		  DynamicArray_1_HG_Rendering_RenderGraphModule_IHGRenderGraphResource_ *resourceArray; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(35, 0LL) )
		  {
		    m_RenderGraphResources = this->fields.m_RenderGraphResources;
		    if ( m_RenderGraphResources )
		    {
		      if ( m_RenderGraphResources->max_length.size <= 1u )
		        sub_1800D2AB0(v4, v3);
		      v6 = m_RenderGraphResources->vector[1];
		      if ( v6 )
		      {
		        resourceArray = v6->fields.resourceArray;
		        if ( resourceArray )
		          return resourceArray->fields._size_k__BackingField;
		      }
		    }
		LABEL_9:
		    sub_1800D8260(v4, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(35, 0LL);
		  if ( !Patch )
		    goto LABEL_9;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		}
		
		private ComputeBufferResource GetComputeBufferResource([IsReadOnly] in ResourceHandle handle) => default; // 0x0000000189B39A30-0x0000000189B39AF0
		// ComputeBufferResource GetComputeBufferResource(ResourceHandle ByRef)
		ComputeBufferResource *HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetComputeBufferResource(
		        HGRenderGraphResourceRegistry *this,
		        ResourceHandle *handle,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *v6; // rcx
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rax
		  DynamicArray_1_System_Object_ *resourceArray; // rsi
		  ResourceHandle v9; // rbx
		  int32_t v10; // eax
		  Object **Item; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(289, 0LL) )
		  {
		    m_RenderGraphResources = this->fields.m_RenderGraphResources;
		    if ( m_RenderGraphResources )
		    {
		      if ( m_RenderGraphResources->max_length.size <= 1u )
		        sub_1800D2AB0(v6, v5);
		      v6 = m_RenderGraphResources->vector[1];
		      if ( v6 )
		      {
		        resourceArray = (DynamicArray_1_System_Object_ *)v6->fields.resourceArray;
		        v9 = *handle;
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
		        v10 = HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit(v9, 0LL);
		        if ( resourceArray )
		        {
		          Item = UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
		                   resourceArray,
		                   v10,
		                   MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
		          return (ComputeBufferResource *)sub_180005050(
		                                            *Item,
		                                            TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferResource);
		        }
		      }
		    }
		LABEL_9:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(289, 0LL);
		  if ( !Patch )
		    goto LABEL_9;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_137(Patch, (Object *)this, handle, 0LL);
		}
		
		internal void ReleaseUnusedPreservedResources() {} // 0x0000000189B3B99C-0x0000000189B3BA88
		// Void ReleaseUnusedPreservedResources()
		void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ReleaseUnusedPreservedResources(
		        HGRenderGraphResourceRegistry *this,
		        MethodInfo *method)
		{
		  Object *v3; // rdx
		  unsigned int v4; // ebx
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rcx
		  DynamicArray_1_System_Object_ *klass; // rbp
		  int32_t v7; // esi
		  __int64 v8; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(89, 0LL) )
		  {
		    v4 = 0;
		    while ( 1 )
		    {
		      m_RenderGraphResources = this->fields.m_RenderGraphResources;
		      if ( !m_RenderGraphResources )
		        break;
		      if ( v4 >= m_RenderGraphResources->max_length.size )
		        sub_1800D2AB0(m_RenderGraphResources, v3);
		      v3 = (Object *)m_RenderGraphResources->vector[v4];
		      if ( !v3 )
		        break;
		      klass = (DynamicArray_1_System_Object_ *)v3[1].klass;
		      v7 = 0;
		      if ( !klass )
		        break;
		      do
		      {
		        v3 = *UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
		                klass,
		                v7,
		                MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
		        if ( v3
		          && BYTE1(v3[1].klass)
		          && LODWORD(v3[2].klass) == this->fields.m_currentExecutorID
		          && HIDWORD(v3[2].klass) + LODWORD(v3[2].monitor) - 1 < this->fields.m_currentExecutorFrameIndex )
		        {
		          LOBYTE(v8) = 1;
		          sub_1800732B0(12LL, v3, (unsigned int)this->fields.m_CurrentFrameIndex, v8);
		        }
		        ++v7;
		      }
		      while ( v7 < 64 );
		      if ( (int)++v4 >= 2 )
		        return;
		    }
		LABEL_17:
		    sub_1800D8260(m_RenderGraphResources, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(89, 0LL);
		  if ( !Patch )
		    goto LABEL_17;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		internal void ReleaseAllPreservedResources(int executorID) {} // 0x0000000183946620-0x00000001839466D0
		// Void ReleaseAllPreservedResources(Int32)
		void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ReleaseAllPreservedResources(
		        HGRenderGraphResourceRegistry *this,
		        int32_t executorID,
		        MethodInfo *method)
		{
		  Object *v5; // rdx
		  __int64 v6; // rcx
		  unsigned int v7; // esi
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rdi
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *v9; // rdi
		  DynamicArray_1_System_Object_ *resourceArray; // rdi
		  int32_t v11; // ebx
		  __int64 v12; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(165, 0LL) )
		  {
		    v7 = 0;
		    while ( 1 )
		    {
		      m_RenderGraphResources = this->fields.m_RenderGraphResources;
		      if ( !m_RenderGraphResources )
		        break;
		      if ( v7 >= m_RenderGraphResources->max_length.size )
		        sub_1800D2AB0(v6, v5);
		      v9 = m_RenderGraphResources->vector[v7];
		      if ( !v9 )
		        break;
		      resourceArray = (DynamicArray_1_System_Object_ *)v9->fields.resourceArray;
		      v11 = 0;
		      if ( !resourceArray )
		        break;
		      do
		      {
		        v5 = *UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
		                resourceArray,
		                v11,
		                MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
		        if ( v5 && BYTE1(v5[1].klass) && LODWORD(v5[2].klass) == executorID )
		        {
		          LOBYTE(v12) = 1;
		          sub_1800732B0(12LL, v5, (unsigned int)this->fields.m_CurrentFrameIndex, v12);
		        }
		        ++v11;
		      }
		      while ( v11 < 64 );
		      if ( (int)++v7 >= 2 )
		        return;
		    }
		LABEL_11:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(165, 0LL);
		  if ( !Patch )
		    goto LABEL_11;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, executorID, 0LL);
		}
		
		internal void CreatePooledResource(HGRenderGraphContext rgContext, int type, int index, string name) {} // 0x0000000189B38D88-0x0000000189B38ED4
		// Void CreatePooledResource(HGRenderGraphContext, Int32, Int32, String)
		void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CreatePooledResource(
		        HGRenderGraphResourceRegistry *this,
		        HGRenderGraphContext *rgContext,
		        int32_t type,
		        int32_t index,
		        String *name,
		        MethodInfo *method)
		{
		  __int64 v7; // rdi
		  __int64 v10; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // r8
		  Object **Item; // rax
		  __int64 v14; // r8
		  Object *v15; // rbx
		  HGRenderGraphDebugParams *m_RenderGraphDebug; // rax
		  __int64 v17; // rax
		  __int64 v18; // rax
		
		  v7 = type;
		  if ( IFix::WrappersManagerImpl::IsPatched(80, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(80, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_40(
		        Patch,
		        (Object *)this,
		        (Object *)rgContext,
		        v7,
		        index,
		        (Object *)name,
		        0LL);
		      return;
		    }
		    goto LABEL_19;
		  }
		  m_RenderGraphResources = this->fields.m_RenderGraphResources;
		  if ( !m_RenderGraphResources )
		    goto LABEL_19;
		  if ( (unsigned int)v7 >= m_RenderGraphResources->max_length.size )
		LABEL_17:
		    sub_1800D2AB0(Patch, v10);
		  Patch = (ILFixDynamicMethodWrapper_2 *)m_RenderGraphResources->vector[v7];
		  if ( !Patch )
		    goto LABEL_19;
		  Patch = (ILFixDynamicMethodWrapper_2 *)Patch->fields.virtualMachine;
		  if ( !Patch )
		    goto LABEL_19;
		  Item = UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
		           (DynamicArray_1_System_Object_ *)Patch,
		           index,
		           MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
		  v15 = *Item;
		  if ( !*Item )
		    goto LABEL_19;
		  if ( !LOBYTE(v15[1].klass) && !BYTE1(v15[1].klass) )
		  {
		    LOBYTE(v14) = 1;
		    sub_1808ADC58(Patch, *Item, v14, name);
		    m_RenderGraphDebug = this->fields.m_RenderGraphDebug;
		    if ( !m_RenderGraphDebug )
		      goto LABEL_19;
		    if ( m_RenderGraphDebug->fields.enableLogging )
		      sub_180073530(15LL, v15, this->fields.m_FrameInformationLogger);
		    Patch = (ILFixDynamicMethodWrapper_2 *)this->fields.m_RenderGraphResources;
		    if ( !Patch )
		      goto LABEL_19;
		    if ( (unsigned int)v7 < Patch->fields.methodId )
		    {
		      v17 = *((_QWORD *)&Patch->fields.anonObj + v7);
		      if ( v17 )
		      {
		        v18 = *(_QWORD *)(v17 + 32);
		        if ( v18 )
		          (*(void (__fastcall **)(_QWORD, HGRenderGraphContext *, Object *, _QWORD))(v18 + 24))(
		            *(_QWORD *)(v18 + 64),
		            rgContext,
		            v15,
		            *(_QWORD *)(v18 + 40));
		        return;
		      }
		LABEL_19:
		      sub_1800D8260(Patch, v10);
		    }
		    goto LABEL_17;
		  }
		}
		
		private void CreateTextureCallback(HGRenderGraphContext rgContext, IHGRenderGraphResource res) {} // 0x0000000189B3935C-0x0000000189B3961C
		// Void CreateTextureCallback(HGRenderGraphContext, IHGRenderGraphResource)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CreateTextureCallback(
		        HGRenderGraphResourceRegistry *this,
		        HGRenderGraphContext *rgContext,
		        IHGRenderGraphResource *res,
		        MethodInfo *method)
		{
		  __int64 v7; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  __int64 v10; // rdi
		  RTHandle *v11; // rsi
		  HGRenderGraphDebugParams *m_RenderGraphDebug; // rsi
		  bool v13; // r15
		  int v14; // esi
		  __m128 si128; // xmm2
		  CommandBuffer *cmd; // r14
		  RTHandle *v17; // r15
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v19; // rdx
		  __int64 v20; // rcx
		  char v21; // [rsp+40h] [rbp-58h] BYREF
		  __int64 v22; // [rsp+48h] [rbp-50h]
		  Il2CppExceptionWrapper *v23; // [rsp+50h] [rbp-48h] BYREF
		  FastMemoryFlags__Enum flags[4]; // [rsp+60h] [rbp-38h] BYREF
		  Il2CppException *ex; // [rsp+70h] [rbp-28h]
		  char *v26; // [rsp+78h] [rbp-20h]
		
		  v21 = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(311, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(311, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v20, v19);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
		      (ILFixDynamicMethodWrapper_30 *)Patch,
		      (Object *)this,
		      (Object *)rgContext,
		      (Object *)res,
		      0LL);
		  }
		  else
		  {
		    v7 = sub_180005050(res, TypeInfo::HG::Rendering::RenderGraphModule::TextureResource);
		    v10 = v7;
		    v22 = v7;
		    if ( !v7 )
		      sub_1800D8260(v9, v8);
		    *(_QWORD *)flags = *(_QWORD *)(v7 + 120);
		    if ( LOBYTE(flags[0]) )
		    {
		      v11 = *(RTHandle **)(v7 + 152);
		      if ( !rgContext )
		        sub_1800D8260(v9, v8);
		      if ( !v11 )
		        sub_1800D8260(v9, v8);
		      UnityEngine::Rendering::RTHandle::SwitchToFastMemory(
		        v11,
		        rgContext->fields.cmd,
		        *(float *)(v7 + 128),
		        flags[1],
		        0,
		        0LL);
		    }
		    if ( !v10 )
		      sub_1800D8260(v9, v8);
		    *(_BYTE *)(v10 + 160) = *(_BYTE *)(v10 + 133);
		    m_RenderGraphDebug = this->fields.m_RenderGraphDebug;
		    if ( !m_RenderGraphDebug )
		      sub_1800D8260(v9, v8);
		    if ( m_RenderGraphDebug->fields.clearRenderTargetsAtCreation )
		    {
		      v13 = *(_BYTE *)(v10 + 133) == 0;
		      if ( !rgContext )
		        sub_1800D8260(v9, v8);
		      UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		        (Int32Enum__Enum)(v13 + 2),
		        MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::RenderGraphModule::HGRenderGraphProfileId>);
		      ex = 0LL;
		      v26 = &v21;
		      try
		      {
		        v14 = *(_DWORD *)(v10 + 68) != 0 ? 5 : 0;
		        if ( v13 )
		          si128 = (__m128)_mm_load_si128((const __m128i *)&xmmword_18DA45B20);
		        else
		          si128 = (__m128)_mm_loadu_si128((const __m128i *)(v10 + 136));
		        cmd = rgContext->fields.cmd;
		        v17 = *(RTHandle **)(v10 + 152);
		        flags[0] = (FastMemoryFlags__Enum)si128.m128_i32[0];
		        flags[1] = _mm_shuffle_ps(si128, si128, 85).m128_u32[0];
		        flags[2] = _mm_shuffle_ps(si128, si128, 170).m128_u32[0];
		        flags[3] = _mm_shuffle_ps(si128, si128, 255).m128_u32[0];
		        sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		        UnityEngine::Rendering::CoreUtils::SetRenderTarget(
		          cmd,
		          v17,
		          (ClearFlag__Enum)(v14 + 1),
		          (Color *)flags,
		          0,
		          CubemapFace__Enum_Unknown,
		          -1,
		          0LL);
		      }
		      catch ( Il2CppExceptionWrapper *v23 )
		      {
		        ex = v23->ex;
		        if ( ex )
		          sub_18007E1E0(ex);
		        v10 = v22;
		      }
		      *(_BYTE *)(v10 + 160) = 0;
		    }
		  }
		}
		
		internal void ReleasePooledResource(HGRenderGraphContext rgContext, int type, int index) {} // 0x0000000189B3B598-0x0000000189B3B6DC
		// Void ReleasePooledResource(HGRenderGraphContext, Int32, Int32)
		void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ReleasePooledResource(
		        HGRenderGraphResourceRegistry *this,
		        HGRenderGraphContext *rgContext,
		        int32_t type,
		        int32_t index,
		        MethodInfo *method)
		{
		  __int64 v6; // rsi
		  __int64 v9; // rdx
		  DynamicArray_1_System_Object_ *m_RenderGraphResources; // rcx
		  Object *v11; // rbx
		  __int64 v12; // r9
		  __int64 v13; // rax
		  __int64 v14; // rax
		  HGRenderGraphDebugParams *m_RenderGraphDebug; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v6 = type;
		  if ( IFix::WrappersManagerImpl::IsPatched(86, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(86, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_72(
		        (ILFixDynamicMethodWrapper_8 *)Patch,
		        (Object *)this,
		        (Object *)rgContext,
		        v6,
		        index,
		        0LL);
		      return;
		    }
		    goto LABEL_20;
		  }
		  m_RenderGraphResources = (DynamicArray_1_System_Object_ *)this->fields.m_RenderGraphResources;
		  if ( !m_RenderGraphResources )
		    goto LABEL_20;
		  if ( (unsigned int)v6 >= m_RenderGraphResources->fields._size_k__BackingField )
		LABEL_18:
		    sub_1800D2AB0(m_RenderGraphResources, v9);
		  v9 = *((_QWORD *)&m_RenderGraphResources[1].klass + v6);
		  if ( !v9 )
		    goto LABEL_20;
		  m_RenderGraphResources = *(DynamicArray_1_System_Object_ **)(v9 + 16);
		  if ( !m_RenderGraphResources )
		    goto LABEL_20;
		  v11 = *UnityEngine::Rendering::DynamicArray<System::Object>::get_Item(
		           m_RenderGraphResources,
		           index,
		           MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::IHGRenderGraphResource>::get_Item);
		  if ( !v11 )
		    goto LABEL_20;
		  if ( LOBYTE(v11[1].klass) || BYTE1(v11[1].klass) )
		    return;
		  m_RenderGraphResources = (DynamicArray_1_System_Object_ *)this->fields.m_RenderGraphResources;
		  if ( !m_RenderGraphResources )
		LABEL_20:
		    sub_1800D8260(m_RenderGraphResources, v9);
		  if ( (unsigned int)v6 >= m_RenderGraphResources->fields._size_k__BackingField )
		    goto LABEL_18;
		  v13 = *((_QWORD *)&m_RenderGraphResources[1].klass + v6);
		  if ( !v13 )
		    goto LABEL_20;
		  v14 = *(_QWORD *)(v13 + 40);
		  if ( v14 )
		    (*(void (__fastcall **)(_QWORD, HGRenderGraphContext *, Object *, _QWORD))(v14 + 24))(
		      *(_QWORD *)(v14 + 64),
		      rgContext,
		      v11,
		      *(_QWORD *)(v14 + 40));
		  m_RenderGraphDebug = this->fields.m_RenderGraphDebug;
		  if ( !m_RenderGraphDebug )
		    goto LABEL_20;
		  if ( m_RenderGraphDebug->fields.enableLogging )
		    sub_180073530(16LL, v11, this->fields.m_FrameInformationLogger);
		  LOBYTE(v12) = 1;
		  sub_1800732B0(12LL, v11, (unsigned int)this->fields.m_CurrentFrameIndex, v12);
		}
		
		private void ReleaseTextureCallback(HGRenderGraphContext rgContext, IHGRenderGraphResource res) {} // 0x0000000189B3B7F0-0x0000000189B3B99C
		// Void ReleaseTextureCallback(HGRenderGraphContext, IHGRenderGraphResource)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ReleaseTextureCallback(
		        HGRenderGraphResourceRegistry *this,
		        HGRenderGraphContext *rgContext,
		        IHGRenderGraphResource *res,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  __int64 v9; // r14
		  HGRenderGraphDebugParams *m_RenderGraphDebug; // rdi
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  int v13; // edi
		  CommandBuffer *cmd; // rsi
		  RTHandle *v15; // r14
		  __m128i si128; // xmm6
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v18; // rdx
		  __int64 v19; // rcx
		  char v20; // [rsp+40h] [rbp-48h] BYREF
		  Il2CppExceptionWrapper *v21; // [rsp+48h] [rbp-40h] BYREF
		  Il2CppException *ex; // [rsp+50h] [rbp-38h]
		  char *v23; // [rsp+58h] [rbp-30h]
		  __m128i v24; // [rsp+60h] [rbp-28h] BYREF
		
		  v20 = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(312, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(312, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v19, v18);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
		      (ILFixDynamicMethodWrapper_30 *)Patch,
		      (Object *)this,
		      (Object *)rgContext,
		      (Object *)res,
		      0LL);
		  }
		  else
		  {
		    v9 = sub_180005050(res, TypeInfo::HG::Rendering::RenderGraphModule::TextureResource);
		    m_RenderGraphDebug = this->fields.m_RenderGraphDebug;
		    if ( !m_RenderGraphDebug )
		      sub_1800D8260(v8, v7);
		    if ( m_RenderGraphDebug->fields.clearRenderTargetsAtRelease )
		    {
		      if ( !rgContext )
		        sub_1800D8260(v8, v7);
		      UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		        (Int32Enum__Enum)3u,
		        MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::RenderGraphModule::HGRenderGraphProfileId>);
		      ex = 0LL;
		      v23 = &v20;
		      try
		      {
		        if ( !v9 )
		          sub_1800D8250(v12, v11);
		        v13 = *(_DWORD *)(v9 + 68) != 0 ? 5 : 0;
		        cmd = rgContext->fields.cmd;
		        v15 = *(RTHandle **)(v9 + 152);
		        si128 = _mm_load_si128((const __m128i *)&xmmword_18DA45B20);
		        sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		        v24 = si128;
		        UnityEngine::Rendering::CoreUtils::SetRenderTarget(
		          cmd,
		          v15,
		          (ClearFlag__Enum)(v13 + 1),
		          (Color *)&v24,
		          0,
		          CubemapFace__Enum_Unknown,
		          -1,
		          0LL);
		      }
		      catch ( Il2CppExceptionWrapper *v21 )
		      {
		        ex = v21->ex;
		        if ( ex )
		          sub_18007E1E0(ex);
		      }
		    }
		  }
		}
		
		private void ValidateTextureDesc(ref TextureDesc desc) {} // 0x0000000189B3BCA4-0x0000000189B3BCF8
		// Void ValidateTextureDesc(TextureDesc ByRef)
		void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ValidateTextureDesc(
		        HGRenderGraphResourceRegistry *this,
		        TextureDesc *desc,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(148, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(148, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_67(Patch, (Object *)this, desc, 0LL);
		  }
		}
		
		private void ValidateRendererListDesc([IsReadOnly] in RendererListDesc desc) {} // 0x0000000189B3BC50-0x0000000189B3BCA4
		// Void ValidateRendererListDesc(RendererListDesc ByRef)
		void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ValidateRendererListDesc(
		        HGRenderGraphResourceRegistry *this,
		        RendererListDesc *desc,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(172, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(172, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_83(Patch, (Object *)this, desc, 0LL);
		  }
		}
		
		private void ValidateComputeBufferDesc([IsReadOnly] in ComputeBufferDesc desc) {} // 0x0000000189B3BBFC-0x0000000189B3BC50
		// Void ValidateComputeBufferDesc(ComputeBufferDesc ByRef)
		void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ValidateComputeBufferDesc(
		        HGRenderGraphResourceRegistry *this,
		        ComputeBufferDesc *desc,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(177, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(177, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_86(Patch, (Object *)this, desc, 0LL);
		  }
		}
		
		internal void CreateRendererLists(List<RendererListHandle> rendererLists, ScriptableRenderContext context, bool manualDispatch = false /* Metadata: 0x02302D78 */) {} // 0x0000000189B39038-0x0000000189B3935C
		// Void CreateRendererLists(List`1[HG.Rendering.RenderGraphModule.RendererListHandle], ScriptableRenderContext, Boolean)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CreateRendererLists(
		        HGRenderGraphResourceRegistry *this,
		        List_1_HG_Rendering_RenderGraphModule_RendererListHandle_ *rendererLists,
		        ScriptableRenderContext context,
		        bool manualDispatch,
		        MethodInfo *method)
		{
		  bool P3; // si
		  Object *v7; // rdi
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Object__Class *klass; // rbx
		  DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RendererListResource_ *monitor; // rbx
		  int32_t v12; // eax
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		  RendererListResource_1 *Item; // rbx
		  RendererList *v16; // rax
		  __int64 v17; // rdx
		  SpawnerManager_SpawnDataDetail v18; // xmm0
		  List_1_Beyond_Gameplay_Core_SpawnerManager_SpawnDataDetail_ *v19; // rcx
		  List_1_UnityEngine_Rendering_RendererUtils_RendererList_ *v20; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v22; // rdx
		  __int64 v23; // rcx
		  Il2CppException *ex; // [rsp+30h] [rbp-248h]
		  List_1_T_Enumerator_Beyond_Gameplay_AI_CharacterNormalBattleBehavior_GuardSkillMoveState_CircleCoverageEvent_ v25; // [rsp+40h] [rbp-238h] BYREF
		  List_1_T_Enumerator_Beyond_Gameplay_AI_CharacterNormalBattleBehavior_GuardSkillMoveState_CircleCoverageEvent_ v26; // [rsp+58h] [rbp-220h] BYREF
		  Il2CppExceptionWrapper *v27; // [rsp+70h] [rbp-208h] BYREF
		  SpawnerManager_SpawnDataDetail v28; // [rsp+80h] [rbp-1F8h] BYREF
		  RendererListDesc desc; // [rsp+90h] [rbp-1E8h]
		  RendererListDesc v30; // [rsp+170h] [rbp-108h] BYREF
		  ScriptableRenderContext P2; // [rsp+290h] [rbp+18h] BYREF
		  bool v33; // [rsp+298h] [rbp+20h]
		
		  v33 = manualDispatch;
		  P2.m_Ptr = context.m_Ptr;
		  P3 = manualDispatch;
		  v7 = (Object *)this;
		  if ( IFix::WrappersManagerImpl::IsPatched(56, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(56, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v23, v22);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_30(Patch, v7, (Object *)rendererLists, P2, P3, 0LL);
		  }
		  else
		  {
		    klass = v7[5].klass;
		    if ( !klass )
		      sub_1800D8260(v9, v8);
		    ++HIDWORD(klass->_0.namespaze);
		    LODWORD(klass->_0.namespaze) = 0;
		    if ( !rendererLists )
		      sub_1800D8260(v9, v8);
		    System::Collections::Generic::List<Beyond::Gameplay::XiraniteNexusBrain_SplineScanElement::SplineProgressInterval>::GetEnumerator(
		      (List_1_T_Enumerator_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)&v26,
		      (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)rendererLists,
		      MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::RendererListHandle>::GetEnumerator);
		    v25 = v26;
		    try
		    {
		      while ( System::Collections::Generic::List_1_T_::Enumerator<Beyond::Gameplay::AI::CharacterNormalBattleBehavior_GuardSkillMoveState::CircleCoverageEvent>::MoveNext(
		                &v25,
		                MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::RendererListHandle>::MoveNext) )
		      {
		        monitor = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RendererListResource_ *)v7[1].monitor;
		        v12 = HG::Rendering::RenderGraphModule::RendererListHandle::op_Implicit((RendererListHandle)v25._current, 0LL);
		        if ( !monitor )
		          sub_1800D8250(v14, v13);
		        Item = UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RendererListResource>::get_Item(
		                 monitor,
		                 v12,
		                 MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::RendererListResource>::get_Item);
		        desc = Item->desc;
		        sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		        v30 = desc;
		        v16 = UnityEngine::Rendering::ScriptableRenderContext::CreateRendererList((RendererList *)&v26, &P2, &v30, 0LL);
		        v18 = (SpawnerManager_SpawnDataDetail)*v16;
		        Item->rendererList = *v16;
		        v19 = (List_1_Beyond_Gameplay_Core_SpawnerManager_SpawnDataDetail_ *)v7[5].klass;
		        if ( !v19 )
		          sub_1800D8250(0LL, v17);
		        v28 = v18;
		        System::Collections::Generic::List<Beyond::Gameplay::Core::SpawnerManager::SpawnDataDetail>::Add(
		          v19,
		          &v28,
		          MethodInfo::System::Collections::Generic::List<UnityEngine::Rendering::RendererUtils::RendererList>::Add);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v27 )
		    {
		      ex = v27->ex;
		      if ( ex )
		        sub_18007E1E0(ex);
		      P3 = v33;
		      v7 = (Object *)this;
		    }
		    if ( P3 )
		    {
		      v20 = (List_1_UnityEngine_Rendering_RendererUtils_RendererList_ *)v7[5].klass;
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		      UnityEngine::Rendering::ScriptableRenderContext::PrepareRendererListsAsync(&P2, v20, 0LL);
		    }
		  }
		}
		
		internal void Clear(bool onException) {} // 0x0000000189B38BB8-0x0000000189B38C7C
		// Void Clear(Boolean)
		void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::Clear(
		        HGRenderGraphResourceRegistry *this,
		        bool onException,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  int i; // edi
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *m_RenderGraphResources; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(103, 0LL) )
		  {
		    HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::LogResources(this, 0LL);
		    for ( i = 0; i < 2; ++i )
		    {
		      m_RenderGraphResources = (HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *)this->fields.m_RenderGraphResources;
		      if ( !m_RenderGraphResources )
		        goto LABEL_12;
		      if ( (unsigned int)i >= LODWORD(m_RenderGraphResources->fields.pool) )
		        sub_1800D2AB0(m_RenderGraphResources, v5);
		      m_RenderGraphResources = (HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *)*((_QWORD *)&m_RenderGraphResources->fields.createResourceCallback
		                                                                                           + i);
		      if ( !m_RenderGraphResources )
		        goto LABEL_12;
		      HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::HGRenderGraphResourcesData::Clear(
		        m_RenderGraphResources,
		        onException,
		        this->fields.m_CurrentFrameIndex,
		        0LL);
		    }
		    m_RenderGraphResources = (HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *)this->fields.m_RendererListResources;
		    if ( m_RenderGraphResources )
		    {
		      UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::Clear(
		        (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)m_RenderGraphResources,
		        MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::RendererListResource>::Clear);
		      m_RenderGraphResources = (HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *)this->fields.m_ActiveRendererLists;
		      if ( m_RenderGraphResources )
		      {
		        ++HIDWORD(m_RenderGraphResources->fields.pool);
		        LODWORD(m_RenderGraphResources->fields.pool) = 0;
		        return;
		      }
		    }
		LABEL_12:
		    sub_1800D8260(m_RenderGraphResources, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(103, 0LL);
		  if ( !Patch )
		    goto LABEL_12;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, onException, 0LL);
		}
		
		internal void PurgeUnusedGraphicsResources() {} // 0x0000000183946A70-0x0000000183946DB0
		// Void PurgeUnusedGraphicsResources()
		void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::PurgeUnusedGraphicsResources(
		        HGRenderGraphResourceRegistry *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v2; // rdx
		  HGRenderGraphResourceRegistry *v3; // rbp
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // r8
		  int32_t v5; // ebx
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rax
		  unsigned int m_CurrentFrameIndex; // r14d
		  Object *v8; // rdi
		  Object *monitor; // rdi
		  void (__fastcall *gc_desc)(Object *, _QWORD, const char *); // r9
		  const char *name; // r8
		  unsigned __int8 (__fastcall *v12)(MonitorData *, struct ILFixDynamicMethodWrapper_2__Class *, const char *); // rax
		  MonitorData *v13; // rsi
		  MonitorData *v14; // rsi
		  int (__fastcall *v15)(MonitorData *); // rax
		  MonitorData *v16; // rdi
		  void (__fastcall *v17)(MonitorData *, _QWORD); // rax
		  ILFixDynamicMethodWrapper_2__Array *v18; // r8
		  ILFixDynamicMethodWrapper_2 *v19; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ILFixDynamicMethodWrapper_9 *v21; // rax
		  __int64 v22; // rax
		  __int64 v23; // rax
		  __int64 v24; // rax
		
		  v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v3 = this;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v2->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_44;
		  if ( wrapperArray->max_length.size <= 133 )
		  {
		LABEL_5:
		    v5 = 0;
		    while ( 1 )
		    {
		      m_RenderGraphResources = v3->fields.m_RenderGraphResources;
		      if ( !m_RenderGraphResources )
		        goto LABEL_44;
		      if ( (unsigned int)v5 >= m_RenderGraphResources->max_length.size )
		        goto LABEL_53;
		      m_CurrentFrameIndex = v3->fields.m_CurrentFrameIndex;
		      this = (HGRenderGraphResourceRegistry *)v5;
		      v8 = (Object *)m_RenderGraphResources->vector[v5];
		      if ( !v8 )
		        goto LABEL_44;
		      if ( !v2->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(v2);
		        v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      this = (HGRenderGraphResourceRegistry *)v2->static_fields->wrapperArray;
		      if ( !this )
		        goto LABEL_44;
		      if ( SLODWORD(this->fields.m_RendererListResources) <= 134 )
		        goto LABEL_13;
		      if ( !v2->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(v2);
		        v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      this = (HGRenderGraphResourceRegistry *)v2->static_fields->wrapperArray;
		      if ( !this )
		        goto LABEL_44;
		      if ( LODWORD(this->fields.m_RendererListResources) <= 0x86 )
		        goto LABEL_53;
		      if ( this[12].fields.m_FrameInformationLogger )
		      {
		        Patch = IFix::WrappersManagerImpl::GetPatch(134, 0LL);
		        if ( !Patch )
		          goto LABEL_44;
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3(
		          (ILFixDynamicMethodWrapper_29 *)Patch,
		          v8,
		          m_CurrentFrameIndex,
		          0LL);
		      }
		      else
		      {
		LABEL_13:
		        monitor = (Object *)v8[1].monitor;
		        if ( !monitor )
		          goto LABEL_44;
		        sub_1800049A0(monitor->klass);
		        gc_desc = (void (__fastcall *)(Object *, _QWORD, const char *))monitor->klass[1]._0.gc_desc;
		        name = monitor->klass[1]._0.name;
		        if ( (char *)gc_desc == (char *)Beyond::Gameplay::Core::AbilityAction::OnReset )
		        {
		          this = (HGRenderGraphResourceRegistry *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		          if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		            this = (HGRenderGraphResourceRegistry *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		          }
		          v2 = *(struct ILFixDynamicMethodWrapper_2__Class **)this[2].monitor;
		          if ( !v2 )
		            goto LABEL_44;
		          if ( SLODWORD(v2->_0.namespaze) > 3739 )
		          {
		            if ( !LODWORD(this[2].fields.m_FrameInformationLogger) )
		            {
		              il2cpp_runtime_class_init_1(this);
		              this = (HGRenderGraphResourceRegistry *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		            }
		            this = *(HGRenderGraphResourceRegistry **)this[2].monitor;
		            if ( !this )
		              goto LABEL_44;
		            if ( LODWORD(this->fields.m_RendererListResources) <= 0xE9B )
		              goto LABEL_53;
		            if ( this[340].fields.m_RendererListResources )
		            {
		              v21 = (ILFixDynamicMethodWrapper_9 *)IFix::WrappersManagerImpl::GetPatch(3739, 0LL);
		              if ( !v21 )
		                goto LABEL_44;
		              goto LABEL_88;
		            }
		          }
		        }
		        else if ( (char *)gc_desc == (char *)Beyond::Gameplay::Core::Skill::OnAbilitySystemEvent )
		        {
		          this = (HGRenderGraphResourceRegistry *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		          if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		            this = (HGRenderGraphResourceRegistry *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		          }
		          v2 = *(struct ILFixDynamicMethodWrapper_2__Class **)this[2].monitor;
		          if ( !v2 )
		            goto LABEL_44;
		          if ( SLODWORD(v2->_0.namespaze) > 3816 )
		          {
		            if ( !LODWORD(this[2].fields.m_FrameInformationLogger) )
		            {
		              il2cpp_runtime_class_init_1(this);
		              this = (HGRenderGraphResourceRegistry *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		            }
		            this = *(HGRenderGraphResourceRegistry **)this[2].monitor;
		            if ( !this )
		              goto LABEL_44;
		            if ( LODWORD(this->fields.m_RendererListResources) <= 0xEE8 )
		              goto LABEL_53;
		            if ( this[347].fields.m_RendererListResources )
		            {
		              v21 = (ILFixDynamicMethodWrapper_9 *)IFix::WrappersManagerImpl::GetPatch(3816, 0LL);
		              if ( !v21 )
		                goto LABEL_44;
		              goto LABEL_88;
		            }
		          }
		        }
		        else
		        {
		          if ( (char *)gc_desc != (char *)Beyond::Resource::Runtime::BundleLoader::AssetProxy::SetPriority )
		          {
		            gc_desc(monitor, m_CurrentFrameIndex, name);
		            goto LABEL_18;
		          }
		          this = (HGRenderGraphResourceRegistry *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		          if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		            this = (HGRenderGraphResourceRegistry *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		          }
		          v2 = *(struct ILFixDynamicMethodWrapper_2__Class **)this[2].monitor;
		          if ( !v2 )
		            goto LABEL_44;
		          if ( SLODWORD(v2->_0.namespaze) > 3037 )
		          {
		            if ( !LODWORD(this[2].fields.m_FrameInformationLogger) )
		            {
		              il2cpp_runtime_class_init_1(this);
		              this = (HGRenderGraphResourceRegistry *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		            }
		            this = *(HGRenderGraphResourceRegistry **)this[2].monitor;
		            if ( !this )
		              goto LABEL_44;
		            if ( LODWORD(this->fields.m_RendererListResources) <= 0xBDD )
		              goto LABEL_53;
		            if ( this[276].fields.m_ResourceLogger )
		            {
		              v21 = (ILFixDynamicMethodWrapper_9 *)IFix::WrappersManagerImpl::GetPatch(3037, 0LL);
		              if ( !v21 )
		                goto LABEL_44;
		LABEL_88:
		              IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_157(
		                v21,
		                monitor,
		                (LoginSceneAnimCtrl_EState__Enum)m_CurrentFrameIndex,
		                0LL);
		              goto LABEL_18;
		            }
		          }
		          if ( monitor[13].monitor )
		          {
		            v12 = (unsigned __int8 (__fastcall *)(MonitorData *, struct ILFixDynamicMethodWrapper_2__Class *, const char *))qword_18F36FB90;
		            v13 = monitor[13].monitor;
		            if ( !qword_18F36FB90 )
		            {
		              v12 = (unsigned __int8 (__fastcall *)(MonitorData *, struct ILFixDynamicMethodWrapper_2__Class *, const char *))il2cpp_resolve_icall_1("UnityEngine.AsyncOperation::get_isDone()");
		              if ( !v12 )
		              {
		                v22 = sub_1802EE1B8("UnityEngine.AsyncOperation::get_isDone()");
		                sub_18007E1B0(v22, 0LL);
		              }
		              qword_18F36FB90 = (__int64)v12;
		            }
		            if ( !v12(v13, v2, name) )
		            {
		              v14 = monitor[13].monitor;
		              if ( !v14 )
		                goto LABEL_44;
		              v15 = (int (__fastcall *)(MonitorData *))qword_18F36FB98;
		              if ( !qword_18F36FB98 )
		              {
		                v15 = (int (__fastcall *)(MonitorData *))il2cpp_resolve_icall_1("UnityEngine.AsyncOperation::get_priority()");
		                if ( !v15 )
		                {
		                  v23 = sub_1802EE1B8("UnityEngine.AsyncOperation::get_priority()");
		                  sub_18007E1B0(v23, 0LL);
		                }
		                qword_18F36FB98 = (__int64)v15;
		              }
		              if ( v15(v14) < (int)m_CurrentFrameIndex )
		              {
		                v16 = monitor[13].monitor;
		                if ( !v16 )
		                  goto LABEL_44;
		                v17 = (void (__fastcall *)(MonitorData *, _QWORD))qword_18F36FBA0;
		                if ( !qword_18F36FBA0 )
		                {
		                  v17 = (void (__fastcall *)(MonitorData *, _QWORD))il2cpp_resolve_icall_1(
		                                                                      "UnityEngine.AsyncOperation::set_priority(System.Int32)");
		                  if ( !v17 )
		                  {
		                    v24 = sub_1802EE1B8("UnityEngine.AsyncOperation::set_priority(System.Int32)");
		                    sub_18007E1B0(v24, 0LL);
		                  }
		                  qword_18F36FBA0 = (__int64)v17;
		                }
		                v17(v16, m_CurrentFrameIndex);
		              }
		            }
		          }
		        }
		      }
		LABEL_18:
		      if ( ++v5 >= 2 )
		        return;
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		  }
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v18 = v2->static_fields->wrapperArray;
		  if ( !v18 )
		    goto LABEL_44;
		  if ( v18->max_length.size <= 0x85u )
		LABEL_53:
		    sub_1800D2AB0(this, v2);
		  if ( !v18[3].vector[25] )
		    goto LABEL_5;
		  v19 = IFix::WrappersManagerImpl::GetPatch(133, 0LL);
		  if ( !v19 )
		LABEL_44:
		    sub_1800D8260(this, v2);
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)v19, (Object *)v3, 0LL);
		}
		
		internal void Cleanup() {} // 0x00000001839459F0-0x0000000183945A90
		// Void Cleanup()
		void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::Cleanup(
		        HGRenderGraphResourceRegistry *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  int32_t v4; // ebx
		  int i; // edi
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rcx
		  RTHandle__Array *m_CurrentBackbuffer; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(124, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(124, 0LL);
		    if ( !Patch )
		LABEL_6:
		      sub_1800D8260(m_RenderGraphResources, v3);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    v4 = 0;
		    for ( i = 0; i < 2; ++i )
		    {
		      m_RenderGraphResources = this->fields.m_RenderGraphResources;
		      if ( !m_RenderGraphResources )
		        goto LABEL_6;
		      if ( (unsigned int)i >= m_RenderGraphResources->max_length.size )
		LABEL_16:
		        sub_1800D2AB0(m_RenderGraphResources, v3);
		      m_RenderGraphResources = (HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *)m_RenderGraphResources->vector[i];
		      if ( !m_RenderGraphResources )
		        goto LABEL_6;
		      HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::HGRenderGraphResourcesData::Cleanup(
		        (HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *)m_RenderGraphResources,
		        0LL);
		    }
		    if ( this->fields.m_CurrentBackbuffer )
		    {
		      m_CurrentBackbuffer = this->fields.m_CurrentBackbuffer;
		      while ( v4 < m_CurrentBackbuffer->max_length.size )
		      {
		        if ( (unsigned int)v4 >= m_CurrentBackbuffer->max_length.size )
		          goto LABEL_16;
		        m_RenderGraphResources = (HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *)m_CurrentBackbuffer->vector[v4];
		        if ( m_RenderGraphResources )
		          UnityEngine::Rendering::RTHandle::Release((RTHandle *)m_RenderGraphResources, 0LL);
		        ++v4;
		      }
		    }
		  }
		}
		
		internal void FlushLogs() {} // 0x0000000189B397C0-0x0000000189B39804
		// Void FlushLogs()
		void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::FlushLogs(
		        HGRenderGraphResourceRegistry *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(135, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(135, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		}
		
		private void LogResources() {} // 0x0000000189B3B0B0-0x0000000189B3B1BC
		// Void LogResources()
		void HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::LogResources(
		        HGRenderGraphResourceRegistry *this,
		        MethodInfo *method)
		{
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *pool; // rdx
		  HGRenderGraphResourceRegistry_HGRenderGraphResourcesData__Array *m_RenderGraphResources; // rcx
		  HGRenderGraphDebugParams *m_RenderGraphDebug; // rax
		  HGRenderGraphLogger *m_ResourceLogger; // rdi
		  Object__Array *v7; // rax
		  unsigned int v8; // edi
		  HGRenderGraphLogger *v9; // rsi
		  Object__Array *v10; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(104, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(104, 0LL);
		    if ( !Patch )
		      goto LABEL_15;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    m_RenderGraphDebug = this->fields.m_RenderGraphDebug;
		    if ( !m_RenderGraphDebug )
		      goto LABEL_15;
		    if ( m_RenderGraphDebug->fields.enableLogging )
		    {
		      m_ResourceLogger = this->fields.m_ResourceLogger;
		      v7 = (Object__Array *)sub_183AD6530(MethodInfo::System::Array::Empty<System::Object>);
		      if ( m_ResourceLogger )
		      {
		        HG::Rendering::RenderGraphModule::HGRenderGraphLogger::LogLine(
		          m_ResourceLogger,
		          (String *)"==== Allocated Resources ====\n",
		          v7,
		          0LL);
		        v8 = 0;
		        while ( 1 )
		        {
		          m_RenderGraphResources = this->fields.m_RenderGraphResources;
		          if ( !m_RenderGraphResources )
		            break;
		          if ( v8 >= m_RenderGraphResources->max_length.size )
		            sub_1800D2AB0(m_RenderGraphResources, pool);
		          pool = m_RenderGraphResources->vector[v8];
		          if ( !pool )
		            break;
		          pool = (HGRenderGraphResourceRegistry_HGRenderGraphResourcesData *)pool->fields.pool;
		          if ( !pool )
		            break;
		          sub_180073530(7LL, pool, this->fields.m_ResourceLogger);
		          v9 = this->fields.m_ResourceLogger;
		          v10 = (Object__Array *)sub_183AD6530(MethodInfo::System::Array::Empty<System::Object>);
		          if ( !v9 )
		            break;
		          HG::Rendering::RenderGraphModule::HGRenderGraphLogger::LogLine(v9, (String *)"", v10, 0LL);
		          if ( (int)++v8 >= 2 )
		            return;
		        }
		      }
		LABEL_15:
		      sub_1800D8260(m_RenderGraphResources, pool);
		    }
		  }
		}
		
	}
}
