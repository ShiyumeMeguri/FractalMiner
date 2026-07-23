using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.HyperGryph.ECS;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGEntityRenderHelperECSManager // TypeDefIndex: 37717
	{
		// Fields
		private Dictionary<Entity, EntityRenderHelperECSContext> m_contextDict; // 0x10
		private List<IEntityRenderHelperECS> m_activeHelpers; // 0x18
		public HelperCreateDelegate helperCreateDelegate; // 0x20
	
		// Nested types
		public delegate IEntityRenderHelperECS HelperCreateDelegate(Entity rendererEntity, ref HGFactoryRendererBinderComponent rendererBinder, int unitConfigAssetInstanceId, Matrix4x4 matrix); // TypeDefIndex: 37716; 0x0000000189D03794-0x0000000189D037E8
	
		// Constructors
		public HGEntityRenderHelperECSManager() {} // 0x0000000182ED8E00-0x0000000182ED8E80
		// HGEntityRenderHelperECSManager()
		void HG::Rendering::Runtime::HGEntityRenderHelperECSManager::HGEntityRenderHelperECSManager(
		        HGEntityRenderHelperECSManager *this,
		        MethodInfo *method)
		{
		  Dictionary_2_UnityEngine_HyperGryph_ECS_Entity_System_Single_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  Dictionary_2_UnityEngine_HyperGryph_ECS_Entity_HG_Rendering_Runtime_EntityRenderHelperECSContext_ *v6; // rdi
		  Type *v7; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v10; // rax
		  List_1_HG_Rendering_Runtime_IEntityRenderHelperECS_ *v11; // rdi
		  Type *v12; // rdx
		  PropertyInfo_1 *v13; // r8
		  Int32__Array **v14; // r9
		  MethodInfo *v15; // [rsp+20h] [rbp-8h]
		  MethodInfo *v16; // [rsp+50h] [rbp+28h]
		
		  v3 = (Dictionary_2_UnityEngine_HyperGryph_ECS_Entity_System_Single_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,HG::Rendering::Runtime::EntityRenderHelperECSContext>);
		  v6 = (Dictionary_2_UnityEngine_HyperGryph_ECS_Entity_HG_Rendering_Runtime_EntityRenderHelperECSContext_ *)v3;
		  if ( !v3
		    || (System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,float>::Dictionary(
		          v3,
		          MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,HG::Rendering::Runtime::EntityRenderHelperECSContext>::Dictionary),
		        this->fields.m_contextDict = v6,
		        sub_18002D1B0((SingleFieldAccessor *)&this->fields, v7, v8, v9, v15),
		        v10 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IEntityRenderHelperECS>),
		        (v11 = (List_1_HG_Rendering_Runtime_IEntityRenderHelperECS_ *)v10) == 0LL) )
		  {
		    sub_1800D8260(v5, v4);
		  }
		  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		    v10,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IEntityRenderHelperECS>::List);
		  this->fields.m_activeHelpers = v11;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_activeHelpers, v12, v13, v14, v16);
		}
		
	
		// Methods
		public void Register(Entity rendererEntity, int unitConfigAssetInstanceId, Matrix4x4 matrix) {} // 0x0000000189CF10F0-0x0000000189CF123C
		// Void Register(Entity, Int32, Matrix4x4)
		void HG::Rendering::Runtime::HGEntityRenderHelperECSManager::Register(
		        HGEntityRenderHelperECSManager *this,
		        Entity_1 rendererEntity,
		        int32_t unitConfigAssetInstanceId,
		        Matrix4x4 *matrix,
		        MethodInfo *method)
		{
		  Dictionary_2_UnityEngine_HyperGryph_ECS_Entity_HG_Rendering_Runtime_EntityRenderHelperECSContext_ *m_contextDict; // rsi
		  __int128 v10; // xmm0
		  __int128 v11; // xmm1
		  __int128 v12; // xmm0
		  __int128 v13; // xmm1
		  Type *v14; // rdx
		  PropertyInfo_1 *v15; // r8
		  Int32__Array **v16; // r9
		  __int64 v17; // rdx
		  __int64 v18; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v20; // xmm1
		  __int128 v21; // xmm0
		  __int128 v22; // xmm1
		  MethodInfo *v23; // [rsp+28h] [rbp-81h]
		  _BYTE v24[80]; // [rsp+38h] [rbp-71h] BYREF
		  __int64 v25; // [rsp+88h] [rbp-21h] BYREF
		  Matrix4x4 v26; // [rsp+98h] [rbp-11h] BYREF
		  __int128 v27; // [rsp+D8h] [rbp+2Fh]
		  __int64 v28; // [rsp+E8h] [rbp+3Fh]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1721, 0LL) )
		  {
		    m_contextDict = this->fields.m_contextDict;
		    sub_18033B9D0(v24, 0LL, 88LL);
		    v10 = *(_OWORD *)&matrix->m00;
		    v25 = 0LL;
		    v11 = *(_OWORD *)&matrix->m01;
		    *(Entity_1 *)&v24[68] = rendererEntity;
		    *(_OWORD *)&v24[4] = v10;
		    *(_DWORD *)v24 = unitConfigAssetInstanceId;
		    v12 = *(_OWORD *)&matrix->m02;
		    *(_OWORD *)&v24[20] = v11;
		    v13 = *(_OWORD *)&matrix->m03;
		    *(_OWORD *)&v24[36] = v12;
		    *(_OWORD *)&v24[52] = v13;
		    sub_18002D1B0((SingleFieldAccessor *)&v25, v14, v15, v16, v23);
		    if ( m_contextDict )
		    {
		      v26 = *(Matrix4x4 *)v24;
		      v27 = *(_OWORD *)&v24[64];
		      v28 = v25;
		      ((void (__fastcall *)(_QWORD, _QWORD, _QWORD, _QWORD))sub_1808AA940)(
		        m_contextDict,
		        rendererEntity,
		        &v26,
		        MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,HG::Rendering::Runtime::EntityRenderHelperECSContext>::set_Item);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(v18, v17);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1721, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  v20 = *(_OWORD *)&matrix->m01;
		  *(_OWORD *)&v26.m00 = *(_OWORD *)&matrix->m00;
		  v21 = *(_OWORD *)&matrix->m02;
		  *(_OWORD *)&v26.m01 = v20;
		  v22 = *(_OWORD *)&matrix->m03;
		  *(_OWORD *)&v26.m02 = v21;
		  *(_OWORD *)&v26.m03 = v22;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_691(
		    Patch,
		    (Object *)this,
		    rendererEntity,
		    unitConfigAssetInstanceId,
		    &v26,
		    0LL);
		}
		
		public void UnRegister(Entity rendererEntity) {} // 0x0000000189CF1300-0x0000000189CF13DC
		// Void UnRegister(Entity)
		void HG::Rendering::Runtime::HGEntityRenderHelperECSManager::UnRegister(
		        HGEntityRenderHelperECSManager *this,
		        Entity_1 rendererEntity,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  Dictionary_2_UnityEngine_HyperGryph_ECS_Entity_HG_Rendering_Runtime_EntityRenderHelperECSContext_ *m_contextDict; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  EntityRenderHelperECSContext value; // [rsp+20h] [rbp-68h] BYREF
		
		  sub_18033B9D0(&value, 0LL, 88LL);
		  if ( !IFix::WrappersManagerImpl::IsPatched(1722, 0LL) )
		  {
		    m_contextDict = this->fields.m_contextDict;
		    if ( m_contextDict )
		    {
		      if ( !System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,HG::Rendering::Runtime::EntityRenderHelperECSContext>::TryGetValue(
		              m_contextDict,
		              rendererEntity,
		              &value,
		              MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,HG::Rendering::Runtime::EntityRenderHelperECSContext>::TryGetValue) )
		        return;
		      m_contextDict = (Dictionary_2_UnityEngine_HyperGryph_ECS_Entity_HG_Rendering_Runtime_EntityRenderHelperECSContext_ *)this->fields.m_activeHelpers;
		      if ( m_contextDict )
		      {
		        System::Collections::Generic::List<System::Object>::Remove(
		          (List_1_System_Object_ *)m_contextDict,
		          (Object *)value.renderHelperInstance,
		          MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IEntityRenderHelperECS>::Remove);
		        if ( value.renderHelperInstance )
		          sub_180053A90(4LL, TypeInfo::HG::Rendering::Runtime::IEntityRenderHelperECS);
		        m_contextDict = this->fields.m_contextDict;
		        if ( m_contextDict )
		        {
		          System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,HG::Rendering::Runtime::EntityRenderHelperECSContext>::Remove(
		            m_contextDict,
		            rendererEntity,
		            MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,HG::Rendering::Runtime::EntityRenderHelperECSContext>::Remove);
		          return;
		        }
		      }
		    }
		LABEL_10:
		    sub_1800D8260(m_contextDict, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1722, 0LL);
		  if ( !Patch )
		    goto LABEL_10;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_692(Patch, (Object *)this, rendererEntity, 0LL);
		}
		
		public void Play(Entity rendererEntity, ref HGFactoryRendererBinderComponent rendererBinder, string vfxName) {} // 0x0000000189CF0EEC-0x0000000189CF10F0
		// Void Play(Entity, HGFactoryRendererBinderComponent ByRef, String)
		void HG::Rendering::Runtime::HGEntityRenderHelperECSManager::Play(
		        HGEntityRenderHelperECSManager *this,
		        Entity_1 rendererEntity,
		        HGFactoryRendererBinderComponent *rendererBinder,
		        String *vfxName,
		        MethodInfo *method)
		{
		  List_1_System_Object_ *helperCreateDelegate; // rcx
		  Dictionary_2_UnityEngine_HyperGryph_ECS_Entity_HG_Rendering_Runtime_EntityRenderHelperECSContext_ *m_contextDict; // rdx
		  __int64 (__fastcall *v11)(__int64, Entity_1, HGFactoryRendererBinderComponent *, _QWORD); // r10
		  __int64 v12; // rcx
		  Type *v13; // rdx
		  PropertyInfo_1 *v14; // r8
		  Int32__Array **v15; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  EntityRenderHelperECSContext v17; // [rsp+38h] [rbp-D0h] BYREF
		  __int128 v18; // [rsp+98h] [rbp-70h]
		  __int128 v19; // [rsp+A8h] [rbp-60h]
		  __int128 v20; // [rsp+B8h] [rbp-50h]
		  __int128 v21; // [rsp+C8h] [rbp-40h]
		  __int128 v22; // [rsp+D8h] [rbp-30h]
		  Object *item; // [rsp+E8h] [rbp-20h] BYREF
		  _BYTE var40[72]; // [rsp+F8h] [rbp-10h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1723, 0LL) )
		  {
		    m_contextDict = this->fields.m_contextDict;
		    if ( !m_contextDict )
		      goto LABEL_14;
		    System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,HG::Rendering::Runtime::EntityRenderHelperECSContext>::get_Item(
		      &v17,
		      m_contextDict,
		      rendererEntity,
		      MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,HG::Rendering::Runtime::EntityRenderHelperECSContext>::get_Item);
		    v19 = *(_OWORD *)&v17.matrix.m30;
		    v20 = *(_OWORD *)&v17.matrix.m31;
		    v21 = *(_OWORD *)&v17.matrix.m32;
		    item = (Object *)v17.renderHelperInstance;
		    v18 = *(_OWORD *)&v17.unitConfigAssetInstanceId;
		    v22 = *(_OWORD *)&v17.matrix.m33;
		    if ( !v17.renderHelperInstance )
		    {
		      helperCreateDelegate = (List_1_System_Object_ *)this->fields.helperCreateDelegate;
		      if ( !helperCreateDelegate )
		        goto LABEL_14;
		      v11 = *(__int64 (__fastcall **)(__int64, Entity_1, HGFactoryRendererBinderComponent *, _QWORD))&helperCreateDelegate->fields._size;
		      v12 = *(_QWORD *)&helperCreateDelegate[1].fields._size;
		      *(Matrix4x4 *)var40 = v17.matrix;
		      item = (Object *)((__int64 (__fastcall *)(_QWORD, _QWORD, _QWORD, _QWORD))v11)(
		                         v12,
		                         rendererEntity,
		                         rendererBinder,
		                         (unsigned int)_mm_cvtsi128_si32(*(__m128i *)&v17.unitConfigAssetInstanceId));
		      sub_18002D1B0((SingleFieldAccessor *)&item, v13, v14, v15, (MethodInfo *)var40);
		      helperCreateDelegate = (List_1_System_Object_ *)this->fields.m_contextDict;
		      if ( !helperCreateDelegate )
		        goto LABEL_14;
		      *(_OWORD *)&v17.unitConfigAssetInstanceId = v18;
		      *(_OWORD *)&v17.matrix.m30 = v19;
		      *(_OWORD *)&v17.matrix.m31 = v20;
		      *(_OWORD *)&v17.matrix.m32 = v21;
		      *(_OWORD *)&v17.matrix.m33 = v22;
		      v17.renderHelperInstance = (IEntityRenderHelperECS *)item;
		      ((void (__fastcall *)(_QWORD, _QWORD, _QWORD, _QWORD))sub_1808AA940)(
		        helperCreateDelegate,
		        rendererEntity,
		        &v17,
		        MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,HG::Rendering::Runtime::EntityRenderHelperECSContext>::set_Item);
		    }
		    if ( !item )
		      goto LABEL_14;
		    if ( !(unsigned __int8)sub_180042E60(3LL, TypeInfo::HG::Rendering::Runtime::IEntityRenderHelperECS) )
		    {
		      helperCreateDelegate = (List_1_System_Object_ *)this->fields.m_activeHelpers;
		      if ( !helperCreateDelegate )
		        goto LABEL_14;
		      sub_182F01190(helperCreateDelegate, item);
		    }
		    if ( item )
		    {
		      sub_18007CDB0(0LL, TypeInfo::HG::Rendering::Runtime::IEntityRenderHelperECS, item, vfxName);
		      return;
		    }
		LABEL_14:
		    sub_1800D8260(helperCreateDelegate, m_contextDict);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1723, 0LL);
		  if ( !Patch )
		    goto LABEL_14;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_693(
		    Patch,
		    (Object *)this,
		    rendererEntity,
		    rendererBinder,
		    (Object *)vfxName,
		    0LL);
		}
		
		public void Stop(Entity rendererEntity, string vfxName) {} // 0x0000000189CF123C-0x0000000189CF1300
		// Void Stop(Entity, String)
		void HG::Rendering::Runtime::HGEntityRenderHelperECSManager::Stop(
		        HGEntityRenderHelperECSManager *this,
		        Entity_1 rendererEntity,
		        String *vfxName,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  Dictionary_2_UnityEngine_HyperGryph_ECS_Entity_HG_Rendering_Runtime_EntityRenderHelperECSContext_ *m_contextDict; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  EntityRenderHelperECSContext value; // [rsp+30h] [rbp-68h] BYREF
		
		  sub_18033B9D0(&value, 0LL, 88LL);
		  if ( IFix::WrappersManagerImpl::IsPatched(1724, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1724, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_694(Patch, (Object *)this, rendererEntity, (Object *)vfxName, 0LL);
		      return;
		    }
		LABEL_7:
		    sub_1800D8260(m_contextDict, v7);
		  }
		  m_contextDict = this->fields.m_contextDict;
		  if ( !m_contextDict )
		    goto LABEL_7;
		  if ( System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,HG::Rendering::Runtime::EntityRenderHelperECSContext>::TryGetValue(
		         m_contextDict,
		         rendererEntity,
		         &value,
		         MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,HG::Rendering::Runtime::EntityRenderHelperECSContext>::TryGetValue) )
		  {
		    if ( value.renderHelperInstance )
		      sub_18007CDB0(2LL, TypeInfo::HG::Rendering::Runtime::IEntityRenderHelperECS, value.renderHelperInstance, vfxName);
		  }
		}
		
		public void Tick(float deltaTime) {} // 0x00000001832E1250-0x00000001832E12E0
		// Void Tick(Single)
		void HG::Rendering::Runtime::HGEntityRenderHelperECSManager::Tick(
		        HGEntityRenderHelperECSManager *this,
		        float deltaTime,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v4; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  int32_t i; // edi
		  List_1_HG_Rendering_Runtime_IEntityRenderHelperECS_ *m_activeHelpers; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Object *Item; // rax
		  __int64 v10; // r9
		
		  v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v4->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_9;
		  if ( wrapperArray->max_length.size <= 1725 )
		    goto LABEL_5;
		  if ( !v4->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v4);
		    v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v4 = (struct ILFixDynamicMethodWrapper_2__Class *)v4->static_fields->wrapperArray;
		  if ( !v4 )
		LABEL_9:
		    sub_1800D8260(v4, wrapperArray);
		  if ( LODWORD(v4->_0.namespaze) <= 0x6BD )
		    sub_1800D2AB0(v4, wrapperArray);
		  if ( *(_QWORD *)&v4[36]._1.interfaces_count )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1725, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_15(
		        (ILFixDynamicMethodWrapper_18 *)Patch,
		        (Object *)this,
		        deltaTime,
		        0LL);
		      return;
		    }
		    goto LABEL_9;
		  }
		LABEL_5:
		  for ( i = 0; ; ++i )
		  {
		    m_activeHelpers = this->fields.m_activeHelpers;
		    if ( !m_activeHelpers )
		      goto LABEL_9;
		    if ( i >= m_activeHelpers->fields._size )
		      break;
		    Item = System::Collections::Generic::List<System::Object>::get_Item(
		             (List_1_System_Object_ *)this->fields.m_activeHelpers,
		             i,
		             MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IEntityRenderHelperECS>::get_Item);
		    if ( !Item )
		      goto LABEL_9;
		    sub_1801F6448(1LL, TypeInfo::HG::Rendering::Runtime::IEntityRenderHelperECS, Item, v10);
		  }
		  HG::Rendering::Runtime::HGEntityRenderHelperECSManager::_RemoveInActive(this, 0LL);
		}
		
		private void _RemoveInActive() {} // 0x00000001832E12E0-0x00000001832E13A0
		// Void _RemoveInActive()
		void HG::Rendering::Runtime::HGEntityRenderHelperECSManager::_RemoveInActive(
		        HGEntityRenderHelperECSManager *this,
		        MethodInfo *method)
		{
		  List_1_System_Object_ *v3; // rcx
		  __int64 v4; // rdx
		  List_1_HG_Rendering_Runtime_IEntityRenderHelperECS_ *m_activeHelpers; // rbx
		  int32_t v6; // ebp
		  int32_t v7; // ebx
		  List_1_HG_Rendering_Runtime_IEntityRenderHelperECS_ *v8; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  char v10; // di
		  char v11; // r14
		  List_1_System_Object_ *v12; // r14
		  Object *Item; // rax
		  Object *v14; // r12
		  Object *v15; // rdi
		  char v16; // al
		  List_1_HG_Rendering_Runtime_IEntityRenderHelperECS_ *v17; // r8
		
		  v3 = (List_1_System_Object_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = (List_1_System_Object_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v4 = **(_QWORD **)&v3[4].fields._size;
		  if ( !v4 )
		    goto LABEL_10;
		  if ( *(int *)(v4 + 24) > 1726 )
		  {
		    if ( !v3[5].fields._size )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = (List_1_System_Object_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = **(List_1_System_Object_ ***)&v3[4].fields._size;
		    if ( !v3 )
		      goto LABEL_10;
		    if ( v3->fields._size <= 0x6BEu )
		      sub_1800D2AB0(v3, v4);
		    if ( v3[346].klass )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(1726, 0LL);
		      if ( Patch )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		        return;
		      }
		      goto LABEL_10;
		    }
		  }
		  m_activeHelpers = this->fields.m_activeHelpers;
		  v6 = 0;
		  if ( !m_activeHelpers )
		    goto LABEL_10;
		  v7 = m_activeHelpers->fields._size - 1;
		  if ( v7 > 0 )
		  {
		    do
		    {
		      v10 = 0;
		      v11 = 0;
		      while ( 1 )
		      {
		        v3 = (List_1_System_Object_ *)this->fields.m_activeHelpers;
		        if ( !v3
		          || !System::Collections::Generic::List<System::Object>::get_Item(
		                v3,
		                v6,
		                MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IEntityRenderHelperECS>::get_Item) )
		        {
		          goto LABEL_10;
		        }
		        if ( !(unsigned __int8)sub_180042E60(3LL, TypeInfo::HG::Rendering::Runtime::IEntityRenderHelperECS) )
		          break;
		        if ( ++v6 > v7 )
		          goto LABEL_26;
		      }
		      v10 = 1;
		LABEL_26:
		      if ( v7 > v6 )
		      {
		        while ( 1 )
		        {
		          v3 = (List_1_System_Object_ *)this->fields.m_activeHelpers;
		          if ( !v3
		            || !System::Collections::Generic::List<System::Object>::get_Item(
		                  v3,
		                  v7,
		                  MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IEntityRenderHelperECS>::get_Item) )
		          {
		            goto LABEL_10;
		          }
		          if ( (unsigned __int8)sub_180042E60(3LL, TypeInfo::HG::Rendering::Runtime::IEntityRenderHelperECS) )
		            break;
		          if ( --v7 <= v6 )
		            goto LABEL_33;
		        }
		        v11 = 1;
		      }
		LABEL_33:
		      if ( ((unsigned __int8)v11 & (unsigned __int8)v10) != 0 )
		      {
		        v12 = (List_1_System_Object_ *)this->fields.m_activeHelpers;
		        v3 = v12;
		        if ( !v12 )
		          goto LABEL_10;
		        Item = System::Collections::Generic::List<System::Object>::get_Item(
		                 v12,
		                 v7,
		                 MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IEntityRenderHelperECS>::get_Item);
		        v3 = (List_1_System_Object_ *)this->fields.m_activeHelpers;
		        v14 = Item;
		        if ( !v3 )
		          goto LABEL_10;
		        v15 = System::Collections::Generic::List<System::Object>::get_Item(
		                v3,
		                v6,
		                MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IEntityRenderHelperECS>::get_Item);
		        System::Collections::Generic::List<System::Object>::set_Item(
		          v12,
		          v6,
		          v14,
		          MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IEntityRenderHelperECS>::set_Item);
		        System::Collections::Generic::List<System::Object>::set_Item(
		          v12,
		          v7,
		          v15,
		          MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IEntityRenderHelperECS>::set_Item);
		        ++v6;
		        --v7;
		      }
		    }
		    while ( v6 < v7 );
		  }
		  v8 = this->fields.m_activeHelpers;
		  if ( !v8 )
		    goto LABEL_10;
		  if ( v6 < v8->fields._size )
		  {
		    if ( System::Collections::Generic::List<System::Object>::get_Item(
		           (List_1_System_Object_ *)this->fields.m_activeHelpers,
		           v6,
		           MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IEntityRenderHelperECS>::get_Item) )
		    {
		      v16 = sub_180042E60(3LL, TypeInfo::HG::Rendering::Runtime::IEntityRenderHelperECS);
		      v17 = this->fields.m_activeHelpers;
		      v4 = (unsigned int)(v6 + 1);
		      if ( !v16 )
		        v4 = (unsigned int)v6;
		      if ( v17 )
		      {
		        System::Collections::Generic::List<System::Object>::RemoveRange(
		          (List_1_System_Object_ *)this->fields.m_activeHelpers,
		          v4,
		          v17->fields._size - v4,
		          MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IEntityRenderHelperECS>::RemoveRange);
		        return;
		      }
		    }
		LABEL_10:
		    sub_1800D8260(v3, v4);
		  }
		}
		
		public void Dispose() {} // 0x0000000189CF0E78-0x0000000189CF0EEC
		// Void Dispose()
		void HG::Rendering::Runtime::HGEntityRenderHelperECSManager::Dispose(
		        HGEntityRenderHelperECSManager *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *m_activeHelpers; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1727, 0LL) )
		  {
		    m_activeHelpers = (Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *)this->fields.m_activeHelpers;
		    if ( m_activeHelpers )
		    {
		      sub_183127A90(
		        m_activeHelpers,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IEntityRenderHelperECS>::Clear);
		      m_activeHelpers = (Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *)this->fields.m_contextDict;
		      if ( m_activeHelpers )
		      {
		        System::Collections::Generic::Dictionary<Unity::VisualScripting::FullSerializer::Internal::fsPortableReflection::AttributeQuery,System::Object>::Clear(
		          m_activeHelpers,
		          MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,HG::Rendering::Runtime::EntityRenderHelperECSContext>::Clear);
		        return;
		      }
		    }
		LABEL_6:
		    sub_1800D8260(m_activeHelpers, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1727, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
	}
}
