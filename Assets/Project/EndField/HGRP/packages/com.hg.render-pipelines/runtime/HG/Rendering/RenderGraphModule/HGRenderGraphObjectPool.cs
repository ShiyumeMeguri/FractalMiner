using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.RenderGraphModule
{
	public sealed class HGRenderGraphObjectPool // TypeDefIndex: 37439
	{
		// Fields
		private Dictionary<ValueTuple<System.Type, int>, Stack<object>> m_ArrayPool; // 0x10
		private List<ValueTuple<object, ValueTuple<System.Type, int>>> m_AllocatedArrays; // 0x18
		private List<MaterialPropertyBlock> m_AllocatedMaterialPropertyBlocks; // 0x20
	
		// Nested types
		private class SharedObjectPool<T> // TypeDefIndex: 37438
			where T : new()
		{
			// Fields
			private Stack<T> m_Pool;
			private static readonly Lazy<SharedObjectPool<T>> s_Instance;
	
			// Properties
			public static SharedObjectPool<T> sharedPool { get => default; }
	
			// Constructors
			public SharedObjectPool() {}
			static SharedObjectPool() {}
	
			// Methods
			public T Get() => default;
			public void Release(T value) {}
		}
	
		// Constructors
		internal HGRenderGraphObjectPool() {} // 0x0000000183947170-0x0000000183947230
		// HGRenderGraphObjectPool()
		void HG::Rendering::RenderGraphModule::HGRenderGraphObjectPool::HGRenderGraphObjectPool(
		        HGRenderGraphObjectPool *this,
		        MethodInfo *method)
		{
		  Dictionary_2_System_ValueTuple_2_Object_Int32_System_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  Dictionary_2_System_ValueTuple_2_Type_Int32_Stack_1_System_Object_ *v6; // rdi
		  Type *v7; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  LowLevelList_1_System_Object_ *v10; // rax
		  List_1_System_ValueTuple_2_Object_ValueTuple_2_Type_Int32_ *v11; // rdi
		  Type *v12; // rdx
		  PropertyInfo_1 *v13; // r8
		  Int32__Array **v14; // r9
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v15; // rax
		  List_1_UnityEngine_MaterialPropertyBlock_ *v16; // rdi
		  Type *v17; // rdx
		  PropertyInfo_1 *v18; // r8
		  Int32__Array **v19; // r9
		  MethodInfo *v20; // [rsp+20h] [rbp-8h]
		  MethodInfo *v21; // [rsp+20h] [rbp-8h]
		  MethodInfo *v22; // [rsp+50h] [rbp+28h]
		
		  v3 = (Dictionary_2_System_ValueTuple_2_Object_Int32_System_Object_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::Dictionary<System::ValueTuple<System::Type,int>,System::Collections::Generic::Stack<System::Object>>);
		  v6 = (Dictionary_2_System_ValueTuple_2_Type_Int32_Stack_1_System_Object_ *)v3;
		  if ( !v3 )
		    goto LABEL_5;
		  System::Collections::Generic::Dictionary<System::ValueTuple<System::Object,int>,System::Object>::Dictionary(
		    v3,
		    MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<System::Type,int>,System::Collections::Generic::Stack<System::Object>>::Dictionary);
		  this->fields.m_ArrayPool = v6;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields, v7, v8, v9, v20);
		  v10 = (LowLevelList_1_System_Object_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<System::ValueTuple<System::Object,System::ValueTuple<System::Type,int>>>);
		  v11 = (List_1_System_ValueTuple_2_Object_ValueTuple_2_Type_Int32_ *)v10;
		  if ( !v10
		    || (System::Collections::Generic::LowLevelList<System::Object>::LowLevelList(
		          v10,
		          MethodInfo::System::Collections::Generic::List<System::ValueTuple<System::Object,System::ValueTuple<System::Type,int>>>::List),
		        this->fields.m_AllocatedArrays = v11,
		        sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_AllocatedArrays, v12, v13, v14, v21),
		        v15 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<UnityEngine::MaterialPropertyBlock>),
		        (v16 = (List_1_UnityEngine_MaterialPropertyBlock_ *)v15) == 0LL) )
		  {
		LABEL_5:
		    sub_1800D8260(v5, v4);
		  }
		  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		    v15,
		    MethodInfo::System::Collections::Generic::List<UnityEngine::MaterialPropertyBlock>::List);
		  this->fields.m_AllocatedMaterialPropertyBlocks = v16;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_AllocatedMaterialPropertyBlocks, v17, v18, v19, v22);
		}
		
	
		// Methods
		public T[] GetTempArray<T>(int size) => default;
		public MaterialPropertyBlock GetTempMaterialPropertyBlock() => default; // 0x0000000189B3729C-0x0000000189B37348
		// MaterialPropertyBlock GetTempMaterialPropertyBlock()
		MaterialPropertyBlock *HG::Rendering::RenderGraphModule::HGRenderGraphObjectPool::GetTempMaterialPropertyBlock(
		        HGRenderGraphObjectPool *this,
		        MethodInfo *method)
		{
		  HGRenderGraphObjectPool_SharedObjectPool_1_System_Object_ *sharedPool; // rax
		  __int64 v4; // rdx
		  List_1_System_Object_ *m_AllocatedMaterialPropertyBlocks; // rcx
		  Object *v6; // rax
		  Object *v7; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(273, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphObjectPool::SharedObjectPool<UnityEngine::MaterialPropertyBlock>);
		    sharedPool = HG::Rendering::RenderGraphModule::HGRenderGraphObjectPool::SharedObjectPool<System::Object>::get_sharedPool(MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphObjectPool::SharedObjectPool<UnityEngine::MaterialPropertyBlock>::get_sharedPool);
		    if ( sharedPool )
		    {
		      v6 = UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraphObjectPool::SharedObjectPool<System::Object>::Get(
		             (RenderGraphObjectPool_SharedObjectPool_1_System_Object_ *)sharedPool,
		             MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphObjectPool::SharedObjectPool<UnityEngine::MaterialPropertyBlock>::Get);
		      v7 = v6;
		      if ( v6 )
		      {
		        UnityEngine::MaterialPropertyBlock::Clear((MaterialPropertyBlock *)v6, 1, 0LL);
		        m_AllocatedMaterialPropertyBlocks = (List_1_System_Object_ *)this->fields.m_AllocatedMaterialPropertyBlocks;
		        if ( m_AllocatedMaterialPropertyBlocks )
		        {
		          sub_182F01190(m_AllocatedMaterialPropertyBlocks, v7);
		          return (MaterialPropertyBlock *)v7;
		        }
		      }
		    }
		LABEL_7:
		    sub_1800D8260(m_AllocatedMaterialPropertyBlocks, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(273, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_131(Patch, (Object *)this, 0LL);
		}
		
		internal void ReleaseAllTempAlloc() {} // 0x0000000189B37348-0x0000000189B37634
		// Void ReleaseAllTempAlloc()
		// Hidden C++ exception states: #wind=2
		void HG::Rendering::RenderGraphModule::HGRenderGraphObjectPool::ReleaseAllTempAlloc(
		        HGRenderGraphObjectPool *this,
		        MethodInfo *method)
		{
		  HGRenderGraphObjectPool *v2; // rbx
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  List_1_System_UInt64_ *m_AllocatedMaterialPropertyBlocks; // rdx
		  Object *buildingId; // xmm6_8
		  Dictionary_2_System_ValueTuple_2_Object_Int32_System_Object_ *m_ArrayPool; // rcx
		  __int64 v8; // rdx
		  List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *m_AllocatedArrays; // rcx
		  Object *current; // rdi
		  HGRenderGraphObjectPool_SharedObjectPool_1_System_Object_ *sharedPool; // rax
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v15; // rdx
		  __int64 v16; // rcx
		  _BYTE v17[32]; // [rsp+0h] [rbp-D8h] BYREF
		  Il2CppException *ex; // [rsp+20h] [rbp-B8h]
		  void *v19; // [rsp+28h] [rbp-B0h]
		  List_1_T_Enumerator_System_Object_ v20; // [rsp+30h] [rbp-A8h] BYREF
		  ValueTuple_2_Object_Int32_ v21; // [rsp+50h] [rbp-88h] BYREF
		  RemoteFactoryUtil_FillBuildingCheckResultIterationContext_BuildingDataEntry v22; // [rsp+60h] [rbp-78h]
		  List_1_T_Enumerator_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_BuildingDataEntry_ v23; // [rsp+80h] [rbp-58h] BYREF
		  Il2CppExceptionWrapper *v24; // [rsp+A8h] [rbp-30h] BYREF
		  Il2CppExceptionWrapper *v25; // [rsp+B0h] [rbp-28h] BYREF
		  Stack_1_System_Object_ *v27; // [rsp+F0h] [rbp+18h] BYREF
		
		  v2 = this;
		  v27 = 0LL;
		  memset(&v20, 0, sizeof(v20));
		  if ( IFix::WrappersManagerImpl::IsPatched(85, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(85, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v16, v15);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)v2, 0LL);
		  }
		  else
		  {
		    if ( !v2->fields.m_AllocatedArrays )
		      sub_1800D8260(v4, v3);
		    System::Collections::Generic::List<Beyond::UI::UIText_RichTextAnalyzer::RichTextParam>::GetEnumerator(
		      (List_1_T_Enumerator_Beyond_UI_UIText_RichTextAnalyzer_RichTextParam_ *)&v21,
		      (List_1_Beyond_UI_UIText_RichTextAnalyzer_RichTextParam_ *)v2->fields.m_AllocatedArrays,
		      MethodInfo::System::Collections::Generic::List<System::ValueTuple<System::Object,System::ValueTuple<System::Type,int>>>::GetEnumerator);
		    *(ValueTuple_2_Object_Int32_ *)&v23._list = v21;
		    v23._current = v22;
		    ex = 0LL;
		    v19 = &v23;
		    try
		    {
		      while ( System::Collections::Generic::List_1_T_::Enumerator<Beyond::Gameplay::RemoteFactory::RemoteFactoryUtil_FillBuildingCheckResultIterationContext::BuildingDataEntry>::MoveNext(
		                &v23,
		                MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<System::ValueTuple<System::Object,System::ValueTuple<System::Type,int>>>::MoveNext) )
		      {
		        buildingId = (Object *)v23._current.buildingId;
		        v22.buildingId = *(String **)&v23._current.chapterLimitedCount;
		        m_ArrayPool = (Dictionary_2_System_ValueTuple_2_Object_Int32_System_Object_ *)v2->fields.m_ArrayPool;
		        if ( !m_ArrayPool )
		          sub_1800D8250(0LL, m_AllocatedMaterialPropertyBlocks);
		        v21 = *(ValueTuple_2_Object_Int32_ *)&v23._current.chapterBuildable;
		        System::Collections::Generic::Dictionary<System::ValueTuple<System::Object,int>,System::Object>::TryGetValue(
		          m_ArrayPool,
		          &v21,
		          (Object **)&v27,
		          MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<System::Type,int>,System::Collections::Generic::Stack<System::Object>>::TryGetValue);
		        if ( !v27 )
		          sub_1800D8250(0LL, v8);
		        System::Collections::Generic::Stack<System::Object>::Push(
		          v27,
		          buildingId,
		          MethodInfo::System::Collections::Generic::Stack<System::Object>::Push);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v24 )
		    {
		      m_AllocatedMaterialPropertyBlocks = (List_1_System_UInt64_ *)v17;
		      ex = v24->ex;
		      if ( ex )
		        sub_18007E1E0(ex);
		      v2 = this;
		    }
		    m_AllocatedArrays = (List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *)v2->fields.m_AllocatedArrays;
		    if ( !m_AllocatedArrays )
		      goto LABEL_28;
		    System::Collections::Generic::List<Beyond::Gameplay::Core::AbilitySystem_ComboController_MappingModifier::Handle>::Clear(
		      m_AllocatedArrays,
		      MethodInfo::System::Collections::Generic::List<System::ValueTuple<System::Object,System::ValueTuple<System::Type,int>>>::Clear);
		    m_AllocatedMaterialPropertyBlocks = (List_1_System_UInt64_ *)v2->fields.m_AllocatedMaterialPropertyBlocks;
		    if ( !m_AllocatedMaterialPropertyBlocks )
		      goto LABEL_28;
		    System::Collections::Generic::List<unsigned long>::GetEnumerator(
		      (List_1_T_Enumerator_System_UInt64_ *)&v21,
		      m_AllocatedMaterialPropertyBlocks,
		      MethodInfo::System::Collections::Generic::List<UnityEngine::MaterialPropertyBlock>::GetEnumerator);
		    *(ValueTuple_2_Object_Int32_ *)&v20._list = v21;
		    v20._current = (Object *)v22.buildingId;
		    ex = 0LL;
		    v19 = &v20;
		    try
		    {
		      while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		                &v20,
		                MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::MaterialPropertyBlock>::MoveNext) )
		      {
		        current = v20._current;
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphObjectPool::SharedObjectPool<UnityEngine::MaterialPropertyBlock>);
		        sharedPool = HG::Rendering::RenderGraphModule::HGRenderGraphObjectPool::SharedObjectPool<System::Object>::get_sharedPool(MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphObjectPool::SharedObjectPool<UnityEngine::MaterialPropertyBlock>::get_sharedPool);
		        if ( !sharedPool )
		          sub_1800D8250(v13, v12);
		        UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraphObjectPool::SharedObjectPool<System::Object>::Release(
		          (RenderGraphObjectPool_SharedObjectPool_1_System_Object_ *)sharedPool,
		          current,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphObjectPool::SharedObjectPool<UnityEngine::MaterialPropertyBlock>::Release);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v25 )
		    {
		      m_AllocatedMaterialPropertyBlocks = (List_1_System_UInt64_ *)v17;
		      ex = v25->ex;
		      if ( ex )
		        sub_18007E1E0(ex);
		      v2 = this;
		    }
		    m_AllocatedArrays = (List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *)v2->fields.m_AllocatedMaterialPropertyBlocks;
		    if ( !m_AllocatedArrays )
		LABEL_28:
		      sub_1800D8250(m_AllocatedArrays, m_AllocatedMaterialPropertyBlocks);
		    sub_183127A90(
		      m_AllocatedArrays,
		      MethodInfo::System::Collections::Generic::List<UnityEngine::MaterialPropertyBlock>::Clear);
		  }
		}
		
		internal T Get<T>()
			where T : new() => default;
		internal void Release<T>(T value)
			where T : new() {}
	}
}
