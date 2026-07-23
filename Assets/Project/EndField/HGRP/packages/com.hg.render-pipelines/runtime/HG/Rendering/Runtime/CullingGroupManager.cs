using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class CullingGroupManager // TypeDefIndex: 38103
	{
		// Fields
		private static CullingGroupManager m_Instance; // 0x00
		private Stack<CullingGroup> m_FreeList; // 0x10
	
		// Properties
		public static CullingGroupManager instance { get => default; } // 0x0000000183949AF0-0x0000000183949B80 
		// CullingGroupManager get_instance()
		CullingGroupManager *HG::Rendering::Runtime::CullingGroupManager::get_instance(MethodInfo *method)
		{
		  struct CullingGroupManager__Class *v1; // rcx
		  CullingGroupManager *v2; // rax
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  CullingGroupManager *v5; // rbx
		  Type *v6; // rdx
		  PropertyInfo_1 *v7; // r8
		  Int32__Array **v8; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v11; // [rsp+20h] [rbp-8h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(554, 0LL) )
		  {
		    v1 = TypeInfo::HG::Rendering::Runtime::CullingGroupManager;
		    if ( TypeInfo::HG::Rendering::Runtime::CullingGroupManager->static_fields->m_Instance )
		      return v1->static_fields->m_Instance;
		    v2 = (CullingGroupManager *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::CullingGroupManager);
		    v5 = v2;
		    if ( v2 )
		    {
		      HG::Rendering::Runtime::CullingGroupManager::CullingGroupManager(v2, 0LL);
		      TypeInfo::HG::Rendering::Runtime::CullingGroupManager->static_fields->m_Instance = v5;
		      sub_18002D1B0(
		        (SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::CullingGroupManager->static_fields,
		        v6,
		        v7,
		        v8,
		        v11);
		      v1 = TypeInfo::HG::Rendering::Runtime::CullingGroupManager;
		      return v1->static_fields->m_Instance;
		    }
		LABEL_6:
		    sub_1800D8260(v4, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(554, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_232(Patch, 0LL);
		}
		
	
		// Constructors
		public CullingGroupManager() {} // 0x0000000183949D80-0x0000000183949E30
		// CullingGroupManager()
		void HG::Rendering::Runtime::CullingGroupManager::CullingGroupManager(CullingGroupManager *this, MethodInfo *method)
		{
		  Stack_1_System_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  Stack_1_UnityEngine_CullingGroup_ *v6; // rbx
		  Type *v7; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  MethodInfo *v10; // [rsp+50h] [rbp+28h]
		
		  v3 = (Stack_1_System_Object_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::Stack<UnityEngine::CullingGroup>);
		  v6 = (Stack_1_UnityEngine_CullingGroup_ *)v3;
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  System::Collections::Generic::Stack<System::Object>::Stack(
		    v3,
		    MethodInfo::System::Collections::Generic::Stack<UnityEngine::CullingGroup>::Stack);
		  this->fields.m_FreeList = v6;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields, v7, v8, v9, v10);
		}
		
	
		// Methods
		public CullingGroup Alloc() => default; // 0x0000000189B76070-0x0000000189B76104
		// CullingGroup Alloc()
		CullingGroup *HG::Rendering::Runtime::CullingGroupManager::Alloc(CullingGroupManager *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  Stack_1_UnityEngine_CullingGroup_ *m_FreeList; // rax
		  CullingGroup *v6; // rax
		  CullingGroup *v7; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2845, 0LL) )
		  {
		    m_FreeList = this->fields.m_FreeList;
		    if ( m_FreeList )
		    {
		      if ( m_FreeList->fields._size > 0 )
		        return (CullingGroup *)System::Collections::Generic::Stack<System::Object>::Pop(
		                                 (Stack_1_System_Object_ *)this->fields.m_FreeList,
		                                 MethodInfo::System::Collections::Generic::Stack<UnityEngine::CullingGroup>::Pop);
		      v6 = (CullingGroup *)sub_18002C620(TypeInfo::UnityEngine::CullingGroup);
		      v7 = v6;
		      if ( v6 )
		      {
		        UnityEngine::CullingGroup::CullingGroup(v6, 0LL);
		        return v7;
		      }
		    }
		LABEL_9:
		    sub_1800D8260(v4, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2845, 0LL);
		  if ( !Patch )
		    goto LABEL_9;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1037(Patch, (Object *)this, 0LL);
		}
		
		public void Free(CullingGroup group) {} // 0x0000000189B76104-0x0000000189B76174
		// Void Free(CullingGroup)
		void HG::Rendering::Runtime::CullingGroupManager::Free(
		        CullingGroupManager *this,
		        CullingGroup *group,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  Stack_1_System_Object_ *m_FreeList; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2846, 0LL) )
		  {
		    m_FreeList = (Stack_1_System_Object_ *)this->fields.m_FreeList;
		    if ( m_FreeList )
		    {
		      System::Collections::Generic::Stack<System::Object>::Push(
		        m_FreeList,
		        (Object *)group,
		        MethodInfo::System::Collections::Generic::Stack<UnityEngine::CullingGroup>::Push);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(m_FreeList, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2846, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)group,
		    0LL);
		}
		
		public void Cleanup() {} // 0x0000000184B514F0-0x0000000184B517A0
		// Void Cleanup()
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::CullingGroupManager::Cleanup(CullingGroupManager *this, MethodInfo *method)
		{
		  Object *v2; // r14
		  Type *v3; // rdx
		  __int64 v4; // rcx
		  PropertyInfo_1 *v5; // r8
		  Int32__Array **v6; // r9
		  Object__Class *klass; // rbx
		  __int64 *v8; // rdx
		  PropertyInfo_1 *v9; // r8
		  Int32__Array **v10; // r9
		  struct MethodInfo *v11; // rdi
		  void *descriptor; // rcx
		  int v13; // eax
		  __int64 v14; // rdx
		  Action_1_Google_Protobuf_IMessage_ *v15; // rax
		  int v16; // eax
		  __int64 v17; // rdx
		  Action_1_Google_Protobuf_IMessage_ *clearDelegate; // rdi
		  Object__Class *v19; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v21; // rdx
		  __int64 v22; // rcx
		  __int64 v23; // rax
		  __int64 v24; // rax
		  __int64 v25; // rax
		  ProtocolViolationException *v26; // rbx
		  String *v27; // rax
		  __int64 v28; // [rsp+0h] [rbp-68h] BYREF
		  MethodInfo *v29; // [rsp+20h] [rbp-48h] BYREF
		  SingleFieldAccessor v30; // [rsp+28h] [rbp-40h] BYREF
		
		  v2 = (Object *)this;
		  if ( !IFix::WrappersManagerImpl::IsPatched(555, 0LL) )
		  {
		    klass = v2[1].klass;
		    if ( !klass )
		      sub_1800D8260(v4, v3);
		    *(_OWORD *)&v30.monitor = 0LL;
		    v30.klass = (SingleFieldAccessor__Class *)klass;
		    sub_18002D1B0(&v30, v3, v5, v6, v29);
		    LODWORD(v30.monitor) = HIDWORD(klass->_0.namespaze);
		    HIDWORD(v30.monitor) = -2;
		    v30.fields._.getValueDelegate = 0LL;
		    *(_OWORD *)&v30.fields._.descriptor = *(_OWORD *)&v30.klass;
		    v30.fields.clearDelegate = 0LL;
		    v30.klass = 0LL;
		    v30.monitor = (MonitorData *)&v30.fields._.descriptor;
		    try
		    {
		      while ( 1 )
		      {
		        v11 = MethodInfo::System::Collections::Generic::Stack_1_T_::Enumerator<UnityEngine::CullingGroup>::MoveNext;
		        descriptor = v30.fields._.descriptor;
		        if ( !v30.fields._.descriptor )
		          sub_1800D8250(0LL, v8);
		        if ( LODWORD(v30.fields.setValueDelegate) != HIDWORD(v30.fields._.descriptor->fields._._FullName_k__BackingField) )
		        {
		          v25 = sub_18007E180(&TypeInfo::System::InvalidOperationException);
		          v26 = (ProtocolViolationException *)sub_1800368D0(v25);
		          sub_180003640(v26);
		          v27 = (String *)sub_18007E180(&off_18E2D4360);
		          System::Net::ProtocolViolationException::ProtocolViolationException(v26, v27, 0LL);
		          sub_18007E190(v26, v11);
		        }
		        if ( HIDWORD(v30.fields.setValueDelegate) == -2 )
		        {
		          v16 = LODWORD(v30.fields._.descriptor->fields._._FullName_k__BackingField) - 1;
		          HIDWORD(v30.fields.setValueDelegate) = v16;
		          if ( v16 < 0 )
		            goto LABEL_14;
		          v14 = *(_QWORD *)&v30.fields._.descriptor->fields._._Index_k__BackingField;
		          if ( !v14 )
		            sub_1800D8250(v30.fields._.descriptor, 0LL);
		          if ( (unsigned int)v16 >= *(_DWORD *)(v14 + 24) )
		            sub_1800D2AA0(v30.fields._.descriptor, v14, v9);
		          v15 = *(Action_1_Google_Protobuf_IMessage_ **)(v14 + 8LL * v16 + 32);
		        }
		        else
		        {
		          if ( HIDWORD(v30.fields.setValueDelegate) == -1 )
		            goto LABEL_14;
		          v13 = HIDWORD(v30.fields.setValueDelegate) - 1;
		          HIDWORD(v30.fields.setValueDelegate) = v13;
		          if ( v13 < 0 )
		          {
		            v30.fields.clearDelegate = 0LL;
		LABEL_14:
		            HIDWORD(v30.fields.setValueDelegate) = -1;
		            goto LABEL_41;
		          }
		          v14 = *(_QWORD *)&v30.fields._.descriptor->fields._._Index_k__BackingField;
		          if ( !v14 )
		            sub_1800D8250(v30.fields._.descriptor, 0LL);
		          if ( (unsigned int)v13 >= *(_DWORD *)(v14 + 24) )
		            sub_1800D2AA0(v13, v14, v9);
		          v15 = *(Action_1_Google_Protobuf_IMessage_ **)(v14 + 8LL * v13 + 32);
		        }
		        v30.fields.clearDelegate = v15;
		        sub_18002D1B0((SingleFieldAccessor *)&v30.fields.clearDelegate, (Type *)v14, v9, v10, v29);
		        if ( SHIDWORD(v30.fields.setValueDelegate) < 0 )
		        {
		          v23 = sub_18011C4C0(MethodInfo::System::Collections::Generic::Stack_1_T_::Enumerator<UnityEngine::CullingGroup>::get_Current->klass);
		          v24 = sub_1801F4878(*(_QWORD *)(v23 + 192), 0LL);
		          sub_18059A734(&v30.fields._.descriptor, v24);
		        }
		        clearDelegate = v30.fields.clearDelegate;
		        if ( !v30.fields.clearDelegate )
		          sub_1800D8250(
		            MethodInfo::System::Collections::Generic::Stack_1_T_::Enumerator<UnityEngine::CullingGroup>::get_Current,
		            v17);
		        UnityEngine::CullingGroup::DisposeInternal((CullingGroup *)v30.fields.clearDelegate, 0LL);
		        clearDelegate->fields._._.method_ptr = 0LL;
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v29 )
		    {
		      v8 = &v28;
		      v30.klass = (SingleFieldAccessor__Class *)v29->methodPointer;
		      *((_DWORD *)v30.monitor + 3) = -1;
		      descriptor = v30.klass;
		      if ( v30.klass )
		        sub_18007E1E0(v30.klass);
		      v2 = (Object *)this;
		    }
		LABEL_41:
		    v19 = v2[1].klass;
		    if ( !v19 )
		      sub_1800D8250(descriptor, v8);
		    System::Array::Clear((Array *)v19->_0.name, 0, (int32_t)v19->_0.namespaze, 0LL);
		    LODWORD(v19->_0.namespaze) = 0;
		    ++HIDWORD(v19->_0.namespaze);
		    return;
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(555, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v22, v21);
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, v2, 0LL);
		}
		
	}
}
