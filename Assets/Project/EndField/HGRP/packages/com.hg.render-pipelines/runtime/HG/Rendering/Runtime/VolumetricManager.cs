using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class VolumetricManager // TypeDefIndex: 38734
	{
		// Fields
		private List<HGVolumetricRenderItem> m_RenderItems; // 0x10
		private List<IVolumetricRenderObject> m_VolumetricRenderObjects; // 0x18
	
		// Properties
		public List<IVolumetricRenderObject> VolumetricRenderObjects { get => default; } // 0x0000000183EC9360-0x0000000183EC93C0 
		// List`1[HG.Rendering.Runtime.IVolumetricRenderObject] get_VolumetricRenderObjects()
		List_1_HG_Rendering_Runtime_IVolumetricRenderObject_ *HG::Rendering::Runtime::VolumetricManager::get_VolumetricRenderObjects(
		        VolumetricManager *this,
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
		  if ( wrapperArray->max_length.size <= 870 )
		    return this->fields.m_VolumetricRenderObjects;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x366 )
		    sub_1800D2AB0(v3, method);
		  if ( !*(_QWORD *)&v3[18]._1.cctor_finished_or_no_cctor )
		    return this->fields.m_VolumetricRenderObjects;
		  Patch = IFix::WrappersManagerImpl::GetPatch(870, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_343(Patch, (Object *)this, 0LL);
		}
		
	
		// Constructors
		public VolumetricManager() {} // 0x0000000182ED8E80-0x0000000182ED8F00
		// VolumetricManager()
		void HG::Rendering::Runtime::VolumetricManager::VolumetricManager(VolumetricManager *this, MethodInfo *method)
		{
		  LowLevelList_1_System_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  List_1_UnityEngine_HyperGryphEngineCode_HGVolumetricRenderItem_ *v6; // rdi
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v10; // rax
		  List_1_HG_Rendering_Runtime_IVolumetricRenderObject_ *v11; // rdi
		  HGRuntimeGrassQuery_Node *v12; // rdx
		  HGRuntimeGrassQuery_Node *v13; // r8
		  Int32__Array **v14; // r9
		  MethodInfo *v15; // [rsp+20h] [rbp-8h]
		  MethodInfo *v16; // [rsp+50h] [rbp+28h]
		
		  v3 = (LowLevelList_1_System_Object_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<UnityEngine::HyperGryphEngineCode::HGVolumetricRenderItem>);
		  v6 = (List_1_UnityEngine_HyperGryphEngineCode_HGVolumetricRenderItem_ *)v3;
		  if ( !v3
		    || (System::Collections::Generic::LowLevelList<System::Object>::LowLevelList(
		          v3,
		          MethodInfo::System::Collections::Generic::List<UnityEngine::HyperGryphEngineCode::HGVolumetricRenderItem>::List),
		        this->fields.m_RenderItems = v6,
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields, v7, v8, v9, v15),
		        v10 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>),
		        (v11 = (List_1_HG_Rendering_Runtime_IVolumetricRenderObject_ *)v10) == 0LL) )
		  {
		    sub_1800D8260(v5, v4);
		  }
		  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		    v10,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>::List);
		  this->fields.m_VolumetricRenderObjects = v11;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_VolumetricRenderObjects, v12, v13, v14, v16);
		}
		
	
		// Methods
		public void Release() {} // 0x0000000189C5409C-0x0000000189C540FC
		// Void Release()
		void HG::Rendering::Runtime::VolumetricManager::Release(VolumetricManager *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  List_1_HG_Rendering_Runtime_IVolumetricRenderObject_ *m_VolumetricRenderObjects; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2283, 0LL) )
		  {
		    m_VolumetricRenderObjects = this->fields.m_VolumetricRenderObjects;
		    if ( m_VolumetricRenderObjects )
		    {
		      sub_183127A90(
		        m_VolumetricRenderObjects,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>::Clear);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(m_VolumetricRenderObjects, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2283, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		public void RegisterVolumetricRenderObject(IVolumetricRenderObject vro) {} // 0x000000018454BE60-0x000000018454BED0
		// Void RegisterVolumetricRenderObject(IVolumetricRenderObject)
		void HG::Rendering::Runtime::VolumetricManager::RegisterVolumetricRenderObject(
		        VolumetricManager *this,
		        IVolumetricRenderObject *vro,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  List_1_System_Object_ *m_VolumetricRenderObjects; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5024, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5024, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		        (ILFixDynamicMethodWrapper_39 *)Patch,
		        (Object *)this,
		        (Object *)vro,
		        0LL);
		      return;
		    }
		    goto LABEL_8;
		  }
		  if ( !vro )
		    return;
		  m_VolumetricRenderObjects = (List_1_System_Object_ *)this->fields.m_VolumetricRenderObjects;
		  if ( !m_VolumetricRenderObjects )
		    goto LABEL_8;
		  if ( System::Collections::Generic::List<System::Object>::Contains(
		         m_VolumetricRenderObjects,
		         (Object *)vro,
		         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>::Contains) )
		  {
		    return;
		  }
		  m_VolumetricRenderObjects = (List_1_System_Object_ *)this->fields.m_VolumetricRenderObjects;
		  if ( !m_VolumetricRenderObjects )
		LABEL_8:
		    sub_1800D8260(m_VolumetricRenderObjects, v5);
		  sub_182F01190(m_VolumetricRenderObjects, (Object *)vro);
		}
		
		public void UnregisterVolumetricRenderObject(IVolumetricRenderObject vro) {} // 0x0000000189C540FC-0x0000000189C541C8
		// Void UnregisterVolumetricRenderObject(IVolumetricRenderObject)
		void HG::Rendering::Runtime::VolumetricManager::UnregisterVolumetricRenderObject(
		        VolumetricManager *this,
		        IVolumetricRenderObject *vro,
		        MethodInfo *method)
		{
		  __int64 v5; // rax
		  HGRuntimeGrassQuery_Node *v6; // rdx
		  __int64 v7; // rcx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  Object *v10; // rbx
		  List_1_System_Object_ *m_VolumetricRenderObjects; // rsi
		  Predicate_1_Object_ *v12; // rax
		  Predicate_1_Object_ *v13; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v15; // [rsp+20h] [rbp-8h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5057, 0LL) )
		  {
		    v5 = sub_18002C620(TypeInfo::HG::Rendering::Runtime::VolumetricManager::__c__DisplayClass6_0);
		    v10 = (Object *)v5;
		    if ( v5 )
		    {
		      *(_QWORD *)(v5 + 16) = vro;
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)(v5 + 16), v6, v8, v9, v15);
		      if ( !v10[1].klass )
		        return;
		      m_VolumetricRenderObjects = (List_1_System_Object_ *)this->fields.m_VolumetricRenderObjects;
		      v12 = (Predicate_1_Object_ *)sub_18002C620(TypeInfo::System::Predicate<HG::Rendering::Runtime::IVolumetricRenderObject>);
		      v13 = v12;
		      if ( v12 )
		      {
		        System::Predicate<System::Object>::Predicate(
		          v12,
		          v10,
		          MethodInfo::HG::Rendering::Runtime::VolumetricManager::__c__DisplayClass6_0::_UnregisterVolumetricRenderObject_b__0,
		          0LL);
		        if ( m_VolumetricRenderObjects )
		        {
		          System::Collections::Generic::List<System::Object>::RemoveAll(
		            m_VolumetricRenderObjects,
		            v13,
		            MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>::RemoveAll);
		          return;
		        }
		      }
		    }
		LABEL_8:
		    sub_1800D8260(v7, v6);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5057, 0LL);
		  if ( !Patch )
		    goto LABEL_8;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)vro,
		    0LL);
		}
		
		public void PipelineUpdate() {} // 0x00000001831C85C0-0x00000001831C87A0
		// Void PipelineUpdate()
		void HG::Rendering::Runtime::VolumetricManager::PipelineUpdate(VolumetricManager *this, MethodInfo *method)
		{
		  void *v3; // rcx
		  __int64 v4; // rdx
		  List_1_HG_Rendering_Runtime_IVolumetricRenderObject_ *m_VolumetricRenderObjects; // rbx
		  Comparison_1_HG_Rendering_Runtime_IVolumetricRenderObject_ *v6; // rdi
		  struct MethodInfo *v7; // rsi
		  Object__Array *items; // rbp
		  const Il2CppRGCTXData *rgctx_data; // rcx
		  int32_t size; // r14d
		  Il2CppRGCTXData v11; // rax
		  Object *v12; // rsi
		  Comparison_1_Object_ *v13; // rax
		  HGRuntimeGrassQuery_Node *v14; // rdx
		  HGRuntimeGrassQuery_Node *v15; // r8
		  Int32__Array **v16; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *methoda; // [rsp+20h] [rbp-18h]
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v4 = **((_QWORD **)v3 + 23);
		  if ( !v4 )
		    goto LABEL_17;
		  if ( *(int *)(v4 + 24) > 2342 )
		  {
		    if ( !*((_DWORD *)v3 + 56) )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (void *)**((_QWORD **)v3 + 23);
		    if ( !v3 )
		      goto LABEL_17;
		    if ( *((_DWORD *)v3 + 6) <= 0x926u )
		      sub_1800D2AB0(v3, v4);
		    if ( *((_QWORD *)v3 + 2346) )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(2342, 0LL);
		      if ( Patch )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		        return;
		      }
		      goto LABEL_17;
		    }
		  }
		  v3 = TypeInfo::HG::Rendering::Runtime::VolumetricManager::__c;
		  m_VolumetricRenderObjects = this->fields.m_VolumetricRenderObjects;
		  if ( !TypeInfo::HG::Rendering::Runtime::VolumetricManager::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VolumetricManager::__c);
		    v3 = TypeInfo::HG::Rendering::Runtime::VolumetricManager::__c;
		  }
		  v6 = *(Comparison_1_HG_Rendering_Runtime_IVolumetricRenderObject_ **)(*((_QWORD *)v3 + 23) + 8LL);
		  if ( !v6 )
		  {
		    if ( !*((_DWORD *)v3 + 56) )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::HG::Rendering::Runtime::VolumetricManager::__c;
		    }
		    v12 = (Object *)**((_QWORD **)v3 + 23);
		    v13 = (Comparison_1_Object_ *)sub_1800368D0(TypeInfo::System::Comparison<HG::Rendering::Runtime::IVolumetricRenderObject>);
		    v6 = (Comparison_1_HG_Rendering_Runtime_IVolumetricRenderObject_ *)v13;
		    if ( v13 )
		    {
		      System::Comparison<System::Object>::Comparison(
		        v13,
		        v12,
		        MethodInfo::HG::Rendering::Runtime::VolumetricManager::__c::_PipelineUpdate_b__7_0,
		        0LL);
		      TypeInfo::HG::Rendering::Runtime::VolumetricManager::__c->static_fields->__9__7_0 = v6;
		      sub_18002D1B0(
		        (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::VolumetricManager::__c->static_fields->__9__7_0,
		        v14,
		        v15,
		        v16,
		        methoda);
		      goto LABEL_8;
		    }
		LABEL_17:
		    sub_1800D8260(v3, v4);
		  }
		LABEL_8:
		  if ( !m_VolumetricRenderObjects )
		    goto LABEL_17;
		  v7 = MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>::Sort;
		  if ( !v6 )
		    System::ThrowHelper::ThrowArgumentNullException(ExceptionArgument__Enum_comparison, 0LL);
		  if ( m_VolumetricRenderObjects->fields._size > 1 )
		  {
		    items = (Object__Array *)m_VolumetricRenderObjects->fields._items;
		    rgctx_data = MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>::Sort->klass->rgctx_data;
		    size = m_VolumetricRenderObjects->fields._size;
		    v11.rgctxDataDummy = rgctx_data[52].rgctxDataDummy;
		    if ( (*((_BYTE *)v11.rgctxDataDummy + 312) & 1) == 0 )
		      sub_1800360B0((const Il2CppRGCTXData)rgctx_data[52].rgctxDataDummy, v4);
		    if ( !*((_DWORD *)v11.rgctxDataDummy + 56) )
		      ((void (__fastcall *)(_QWORD))il2cpp_runtime_class_init_1)((Il2CppRGCTXData)v11.rgctxDataDummy);
		    System::Collections::Generic::ArraySortHelper<System::Object>::Sort(
		      items,
		      0,
		      size,
		      (Comparison_1_Object_ *)v6,
		      (MethodInfo *)v7->klass->rgctx_data[51].rgctxDataDummy);
		  }
		  ++m_VolumetricRenderObjects->fields._version;
		}
		
		public List<HGVolumetricRenderItem> PrepareRenderItemsCPP(HGCamera hgCamera, ScriptableRenderContext renderContext, HGVolumetricCloudSettingParameters volumetricParameters) => default; // 0x0000000183398EF0-0x00000001833992C0
		// List`1[UnityEngine.HyperGryphEngineCode.HGVolumetricRenderItem] PrepareRenderItemsCPP(HGCamera, ScriptableRenderContext, HGVolumetricCloudSettingParameters)
		// Hidden C++ exception states: #wind=1
		List_1_UnityEngine_HyperGryphEngineCode_HGVolumetricRenderItem_ *HG::Rendering::Runtime::VolumetricManager::PrepareRenderItemsCPP(
		        VolumetricManager *this,
		        HGCamera *hgCamera,
		        ScriptableRenderContext renderContext,
		        HGVolumetricCloudSettingParameters *volumetricParameters,
		        MethodInfo *method)
		{
		  VolumetricManager *v8; // rdi
		  struct ILFixDynamicMethodWrapper_2__Class *v9; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rsi
		  ILFixDynamicMethodWrapper_2__Array *v11; // rsi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		  List_1_UnityEngine_HyperGryphEngineCode_HGVolumetricRenderItem_ *m_RenderItems; // rsi
		  List_1_HG_Rendering_Runtime_IVolumetricRenderObject_ *m_VolumetricRenderObjects; // rsi
		  __int64 v18; // rdx
		  MethodInfo *P3; // [rsp+20h] [rbp-68h]
		  HGRuntimeGrassQuery_Node v20; // [rsp+30h] [rbp-58h] BYREF
		
		  v8 = this;
		  v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v9->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    sub_1800D8260(v9, hgCamera);
		  if ( wrapperArray->max_length.size <= 1153 )
		    goto LABEL_12;
		  if ( !v9->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v9);
		    v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v11 = v9->static_fields->wrapperArray;
		  if ( !v11 )
		    sub_1800D8260(v9, hgCamera);
		  if ( v11->max_length.size <= 0x481u )
		    sub_1800D2AB0(v9, hgCamera);
		  if ( v11[32].vector[1] )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1153, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v14, v13);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_434(
		             Patch,
		             (Object *)v8,
		             (Object *)hgCamera,
		             renderContext,
		             (Object *)volumetricParameters,
		             0LL);
		  }
		  else
		  {
		LABEL_12:
		    m_RenderItems = v8->fields.m_RenderItems;
		    if ( !m_RenderItems )
		      sub_1800D8260(v9, hgCamera);
		    ++m_RenderItems->fields._version;
		    m_RenderItems->fields._size = 0;
		    m_VolumetricRenderObjects = v8->fields.m_VolumetricRenderObjects;
		    if ( !m_VolumetricRenderObjects )
		      sub_1800D8260(v9, hgCamera);
		    *(_OWORD *)&v20.monitor = 0LL;
		    v20.klass = (HGRuntimeGrassQuery_Node__Class *)m_VolumetricRenderObjects;
		    sub_18002D1B0(
		      &v20,
		      (HGRuntimeGrassQuery_Node *)hgCamera,
		      (HGRuntimeGrassQuery_Node *)renderContext.m_Ptr,
		      (Int32__Array **)volumetricParameters,
		      P3);
		    LODWORD(v20.monitor) = 0;
		    HIDWORD(v20.monitor) = m_VolumetricRenderObjects->fields._version;
		    *(_QWORD *)&v20.fields.bounds.m_Center.x = 0LL;
		    *(_OWORD *)&v20.fields.bounds.m_Extents.y = *(_OWORD *)&v20.klass;
		    v20.fields.left = 0LL;
		    v20.klass = 0LL;
		    v20.monitor = (MonitorData *)&v20.fields.bounds.m_Extents.y;
		    try
		    {
		      while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		                (List_1_T_Enumerator_System_Object_ *)&v20.fields.bounds.m_Extents.y,
		                MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IVolumetricRenderObject>::MoveNext) )
		      {
		        if ( !v20.fields.left )
		          sub_1800D8250(0LL, v18);
		        sub_1833990E0(
		          (Object *)v20.fields.left,
		          (Object *)hgCamera,
		          renderContext,
		          (Object *)volumetricParameters,
		          (Object *)v8->fields.m_RenderItems);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *(HGRuntimeGrassQuery_Node *)&v20.fields.bounds.m_Center.z )
		    {
		      v20.klass = **(HGRuntimeGrassQuery_Node__Class ***)&v20.fields.bounds.m_Center.z;
		      if ( v20.klass )
		        sub_18007E1E0(v20.klass);
		      v8 = this;
		    }
		    return v8->fields.m_RenderItems;
		  }
		}
		
	}
}
