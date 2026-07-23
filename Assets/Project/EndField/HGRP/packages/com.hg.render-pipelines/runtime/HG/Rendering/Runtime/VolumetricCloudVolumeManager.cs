using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class VolumetricCloudVolumeManager // TypeDefIndex: 38718
	{
		// Fields
		private const float FADE_TIME = 2f; // Metadata: 0x023040BD
		private Dictionary<int, VolumetricCloudState> m_states; // 0x10
		private List<IVolumetricCloudVolume> m_VolumetricCloudVolumes; // 0x18
	
		// Nested types
		private class VolumetricCloudState // TypeDefIndex: 38716
		{
			// Fields
			public EVolumetricState m_state; // 0x10
			public float m_fadeRatio; // 0x14
			public IVolumetricCloudVolume m_activeVolume; // 0x18
			public IVolumetricCloudVolume m_fadingVolume; // 0x20
	
			// Constructors
			public VolumetricCloudState() {} // 0x00000001815845C0-0x00000001815845D0
			// InteractionObject+Multiplier()
			void RootMotion::FinalIK::InteractionObject::Multiplier::Multiplier(
			        InteractionObject_Multiplier *this,
			        MethodInfo *method)
			{
			  this->fields.multiplier = 1.0;
			}
			
	
			// Methods
			public void UpdateState(HGCamera camera, IVolumetricCloudVolume activeVolume, bool instantDisappear) {} // 0x0000000182CB8E40-0x0000000182CB9970
			// Void UpdateState(HGCamera, IVolumetricCloudVolume, Boolean)
			void HG::Rendering::Runtime::VolumetricCloudVolumeManager::VolumetricCloudState::UpdateState(
			        VolumetricCloudVolumeManager_VolumetricCloudState *this,
			        HGCamera *camera,
			        IVolumetricCloudVolume *activeVolume,
			        bool instantDisappear,
			        MethodInfo *method)
			{
			  BOOL P3; // r12d
			  signed __int64 klass; // rcx
			  Object *v9; // r13
			  unsigned __int64 v10; // r8
			  bool v11; // zf
			  signed __int64 v12; // rtt
			  signed __int64 v13; // rtt
			  float v14; // xmm0_4
			  signed __int64 v15; // rtt
			  int32_t InstanceID; // eax
			  InsertionBehavior__Enum v17; // r9d
			  Dictionary_2_System_Int32_System_Boolean_ *v18; // rbp
			  int32_t v19; // r15d
			  struct MethodInfo *v20; // rsi
			  BOOL v21; // ecx
			  signed __int64 v22; // rtt
			  signed __int64 v23; // rtt
			  float (*v24)(void); // rax
			  float m_fadeRatio; // xmm6_4
			  float v26; // xmm0_4
			  __int64 v27; // rax
			
			  P3 = instantDisappear;
			  klass = (signed __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  v9 = (Object *)camera;
			  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
			    klass = (signed __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  v10 = **(_QWORD **)(klass + 184);
			  if ( !v10 )
			    goto LABEL_90;
			  if ( *(int *)(v10 + 24) > 833 )
			  {
			    if ( !*(_DWORD *)(klass + 224) )
			    {
			      il2cpp_runtime_class_init_1(klass);
			      klass = (signed __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			    }
			    camera = **(HGCamera ***)(klass + 184);
			    if ( !camera )
			      goto LABEL_90;
			    if ( camera->fields._taauRTSize_k__BackingField.m_X <= 0x341u )
			      goto LABEL_91;
			    if ( *(_QWORD *)&camera[2].fields.mainViewConstants.prevNonJitteredViewNoTransProjMatrix.m01 )
			    {
			      if ( !*(_DWORD *)(klass + 224) )
			      {
			        il2cpp_runtime_class_init_1(klass);
			        klass = (signed __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			      }
			      klass = **(_QWORD **)(klass + 184);
			      if ( !klass )
			        goto LABEL_90;
			      if ( *(_DWORD *)(klass + 24) > 0x341u )
			      {
			        klass = *(_QWORD *)(klass + 6696);
			        if ( klass )
			        {
			          IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_117(
			            (ILFixDynamicMethodWrapper_13 *)klass,
			            (Object *)this,
			            v9,
			            (Object *)activeVolume,
			            P3,
			            0LL);
			          return;
			        }
			LABEL_90:
			        sub_1800D8250(klass, camera);
			      }
			LABEL_91:
			      sub_1800D2AA0(klass, camera, v10);
			    }
			  }
			  if ( this->fields.m_state != 1 && activeVolume != this->fields.m_activeVolume && this->fields.m_activeVolume )
			  {
			    v11 = dword_18F35FD08 == 0;
			    this->fields.m_fadingVolume = this->fields.m_activeVolume;
			    this->fields.m_state = 1;
			    if ( !v11 )
			    {
			      camera = (HGCamera *)((((unsigned __int64)&this->fields.m_fadingVolume >> 12) & 0x1FFFFF) >> 6);
			      v10 = ((unsigned __int64)&this->fields.m_fadingVolume >> 12) & 0x3F;
			      _m_prefetchw(&qword_18F0BCBA0[(_QWORD)camera + 36190]);
			      do
			      {
			        klass = qword_18F0BCBA0[(_QWORD)camera + 36190] | (1LL << v10);
			        v12 = qword_18F0BCBA0[(_QWORD)camera + 36190];
			      }
			      while ( v12 != _InterlockedCompareExchange64(&qword_18F0BCBA0[(_QWORD)camera + 36190], klass, v12) );
			    }
			    v11 = dword_18F35FD08 == 0;
			    this->fields.m_activeVolume = 0LL;
			    if ( !v11 )
			    {
			      camera = (HGCamera *)((((unsigned __int64)&this->fields.m_activeVolume >> 12) & 0x1FFFFF) >> 6);
			      v10 = ((unsigned __int64)&this->fields.m_activeVolume >> 12) & 0x3F;
			      _m_prefetchw(&qword_18F0BCBA0[(_QWORD)camera + 36190]);
			      do
			      {
			        klass = qword_18F0BCBA0[(_QWORD)camera + 36190] | (1LL << v10);
			        v13 = qword_18F0BCBA0[(_QWORD)camera + 36190];
			      }
			      while ( v13 != _InterlockedCompareExchange64(&qword_18F0BCBA0[(_QWORD)camera + 36190], klass, v13) );
			    }
			    v14 = 1.0 - this->fields.m_fadeRatio;
			    if ( v14 <= 0.0 )
			      v14 = 0.0;
			    this->fields.m_fadeRatio = v14;
			  }
			  if ( !this->fields.m_state && activeVolume != this->fields.m_activeVolume )
			  {
			    v11 = dword_18F35FD08 == 0;
			    this->fields.m_state = 2;
			    this->fields.m_activeVolume = activeVolume;
			    if ( !v11 )
			    {
			      camera = (HGCamera *)((((unsigned __int64)&this->fields.m_activeVolume >> 12) & 0x1FFFFF) >> 6);
			      v10 = ((unsigned __int64)&this->fields.m_activeVolume >> 12) & 0x3F;
			      _m_prefetchw(&qword_18F0BCBA0[(_QWORD)camera + 36190]);
			      do
			      {
			        klass = qword_18F0BCBA0[(_QWORD)camera + 36190] | (1LL << v10);
			        v15 = qword_18F0BCBA0[(_QWORD)camera + 36190];
			      }
			      while ( v15 != _InterlockedCompareExchange64(&qword_18F0BCBA0[(_QWORD)camera + 36190], klass, v15) );
			    }
			    this->fields.m_fadeRatio = 0.0;
			    if ( !activeVolume )
			      goto LABEL_90;
			    if ( *(_DWORD *)&activeVolume->klass->_1.method_count == 3435 )
			    {
			      klass = (signed __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			      if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
			      {
			        il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
			        klass = (signed __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			      }
			      camera = **(HGCamera ***)(klass + 184);
			      if ( !camera )
			        goto LABEL_90;
			      if ( camera->fields._taauRTSize_k__BackingField.m_X <= 5014 )
			        goto LABEL_95;
			      if ( !*(_DWORD *)(klass + 224) )
			      {
			        il2cpp_runtime_class_init_1(klass);
			        klass = (signed __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			      }
			      camera = **(HGCamera ***)(klass + 184);
			      if ( !camera )
			        goto LABEL_90;
			      if ( camera->fields._taauRTSize_k__BackingField.m_X <= 0x1396u )
			        goto LABEL_91;
			      if ( *(_QWORD *)&camera[14].fields.mainViewConstants.prevViewProjMatrix.m23 )
			      {
			        if ( !*(_DWORD *)(klass + 224) )
			        {
			          il2cpp_runtime_class_init_1(klass);
			          klass = (signed __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			        }
			        klass = **(_QWORD **)(klass + 184);
			        if ( !klass )
			          goto LABEL_90;
			        if ( *(_DWORD *)(klass + 24) <= 0x1396u )
			          goto LABEL_91;
			        klass = *(_QWORD *)(klass + 40144);
			        if ( !klass )
			          goto LABEL_90;
			        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			          (ILFixDynamicMethodWrapper_39 *)klass,
			          (Object *)activeVolume,
			          v9,
			          0LL);
			      }
			      else
			      {
			LABEL_95:
			        if ( !v9 )
			          goto LABEL_90;
			        klass = (signed __int64)v9[6].klass;
			        if ( !klass )
			          goto LABEL_90;
			        InstanceID = UnityEngine::Object::GetInstanceID((Object_1 *)klass, 0LL);
			        v18 = (Dictionary_2_System_Int32_System_Boolean_ *)activeVolume[29].klass;
			        v19 = InstanceID;
			        if ( !v18 )
			          goto LABEL_90;
			        v20 = MethodInfo::System::Collections::Generic::Dictionary<int,bool>::set_Item;
			        if ( !*((_QWORD *)MethodInfo::System::Collections::Generic::Dictionary<int,bool>::set_Item->klass->rgctx_data[24].rgctxDataDummy
			              + 4) )
			          (*(void (**)(void))MethodInfo::System::Collections::Generic::Dictionary<int,bool>::set_Item->klass->rgctx_data[24].rgctxDataDummy)();
			        LOBYTE(v17) = 1;
			        System::Collections::Generic::Dictionary<int,bool>::TryInsert(
			          v18,
			          v19,
			          1,
			          v17,
			          (MethodInfo *)v20->klass->rgctx_data[24].rgctxDataDummy);
			      }
			    }
			    else
			    {
			      sub_1808B22D0(3LL, camera, activeVolume, v9);
			    }
			  }
			  v21 = 0;
			  if ( this->fields.m_state == 1 )
			    v21 = P3;
			  if ( v21 )
			    this->fields.m_fadeRatio = 1.0;
			  if ( this->fields.m_fadeRatio < 1.0 )
			  {
			    v24 = (float (*)(void))qword_18F36FFB8;
			    m_fadeRatio = this->fields.m_fadeRatio;
			    if ( !qword_18F36FFB8 )
			    {
			      v24 = (float (*)(void))il2cpp_resolve_icall_1("UnityEngine.Time::get_deltaTime()");
			      if ( !v24 )
			      {
			        v27 = sub_1802EE1B8("UnityEngine.Time::get_deltaTime()");
			        sub_18007E1B0(v27, 0LL);
			      }
			      qword_18F36FFB8 = (__int64)v24;
			    }
			    this->fields.m_fadeRatio = (float)(v24() * 0.5) + m_fadeRatio;
			  }
			  else
			  {
			    if ( activeVolume )
			    {
			      if ( this->fields.m_state < 2u )
			      {
			        *(_QWORD *)&this->fields.m_state = 2LL;
			        sub_189C440F0(activeVolume, v9);
			      }
			      else if ( this->fields.m_state == 2 )
			      {
			        this->fields.m_state = 3;
			        this->fields.m_fadeRatio = 1.0;
			      }
			    }
			    else
			    {
			      this->fields.m_state = 0;
			    }
			    v11 = dword_18F35FD08 == 0;
			    this->fields.m_activeVolume = activeVolume;
			    if ( !v11 )
			    {
			      camera = (HGCamera *)((((unsigned __int64)&this->fields.m_activeVolume >> 12) & 0x1FFFFF) >> 6);
			      _m_prefetchw(&qword_18F0BCBA0[(_QWORD)camera + 36190]);
			      do
			        v22 = qword_18F0BCBA0[(_QWORD)camera + 36190];
			      while ( v22 != _InterlockedCompareExchange64(
			                       &qword_18F0BCBA0[(_QWORD)camera + 36190],
			                       v22 | (1LL << (((unsigned __int64)&this->fields.m_activeVolume >> 12) & 0x3F)),
			                       v22) );
			    }
			    v11 = dword_18F35FD08 == 0;
			    this->fields.m_fadingVolume = 0LL;
			    if ( !v11 )
			    {
			      camera = (HGCamera *)((((unsigned __int64)&this->fields.m_fadingVolume >> 12) & 0x1FFFFF) >> 6);
			      _m_prefetchw(&qword_18F0BCBA0[(_QWORD)camera + 36190]);
			      do
			        v23 = qword_18F0BCBA0[(_QWORD)camera + 36190];
			      while ( v23 != _InterlockedCompareExchange64(
			                       &qword_18F0BCBA0[(_QWORD)camera + 36190],
			                       v23 | (1LL << (((unsigned __int64)&this->fields.m_fadingVolume >> 12) & 0x3F)),
			                       v23) );
			    }
			  }
			  v26 = this->fields.m_fadeRatio;
			  if ( v26 < 0.0 )
			  {
			    v26 = 0.0;
			  }
			  else if ( v26 > 1.0 )
			  {
			    v26 = 1.0;
			  }
			  v11 = this->fields.m_state == 1;
			  this->fields.m_fadeRatio = v26;
			  if ( v11 )
			  {
			    klass = (signed __int64)this->fields.m_fadingVolume;
			  }
			  else
			  {
			    if ( !this->fields.m_state )
			      return;
			    klass = (signed __int64)this->fields.m_activeVolume;
			  }
			  if ( !klass )
			    goto LABEL_90;
			  sub_182F9DD60((Object *)klass, v9);
			}
			
		}
	
		// Constructors
		public VolumetricCloudVolumeManager() {} // 0x0000000182ED85D0-0x0000000182ED8650
		// VolumetricCloudVolumeManager()
		void HG::Rendering::Runtime::VolumetricCloudVolumeManager::VolumetricCloudVolumeManager(
		        VolumetricCloudVolumeManager *this,
		        MethodInfo *method)
		{
		  Dictionary_2_System_Int32_System_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  Dictionary_2_System_Int32_HG_Rendering_Runtime_VolumetricCloudVolumeManager_VolumetricCloudState_ *v6; // rdi
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v10; // rax
		  List_1_HG_Rendering_Runtime_IVolumetricCloudVolume_ *v11; // rdi
		  HGRuntimeGrassQuery_Node *v12; // rdx
		  HGRuntimeGrassQuery_Node *v13; // r8
		  Int32__Array **v14; // r9
		  MethodInfo *v15; // [rsp+20h] [rbp-8h]
		  MethodInfo *v16; // [rsp+50h] [rbp+28h]
		
		  v3 = (Dictionary_2_System_Int32_System_Object_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::VolumetricCloudVolumeManager::VolumetricCloudState>);
		  v6 = (Dictionary_2_System_Int32_HG_Rendering_Runtime_VolumetricCloudVolumeManager_VolumetricCloudState_ *)v3;
		  if ( !v3
		    || (System::Collections::Generic::Dictionary<int,System::Object>::Dictionary(
		          v3,
		          MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::VolumetricCloudVolumeManager::VolumetricCloudState>::Dictionary),
		        this->fields.m_states = v6,
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields, v7, v8, v9, v15),
		        v10 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricCloudVolume>),
		        (v11 = (List_1_HG_Rendering_Runtime_IVolumetricCloudVolume_ *)v10) == 0LL) )
		  {
		    sub_1800D8260(v5, v4);
		  }
		  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		    v10,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricCloudVolume>::List);
		  this->fields.m_VolumetricCloudVolumes = v11;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_VolumetricCloudVolumes, v12, v13, v14, v16);
		}
		
	
		// Methods
		public void RegisterCloudVolume(IVolumetricCloudVolume volume) {} // 0x000000018454BED0-0x000000018454BF40
		// Void RegisterCloudVolume(IVolumetricCloudVolume)
		void HG::Rendering::Runtime::VolumetricCloudVolumeManager::RegisterCloudVolume(
		        VolumetricCloudVolumeManager *this,
		        IVolumetricCloudVolume *volume,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  List_1_System_Object_ *m_VolumetricCloudVolumes; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5022, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5022, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		        (ILFixDynamicMethodWrapper_39 *)Patch,
		        (Object *)this,
		        (Object *)volume,
		        0LL);
		      return;
		    }
		    goto LABEL_8;
		  }
		  if ( !volume )
		    return;
		  m_VolumetricCloudVolumes = (List_1_System_Object_ *)this->fields.m_VolumetricCloudVolumes;
		  if ( !m_VolumetricCloudVolumes )
		    goto LABEL_8;
		  if ( System::Collections::Generic::List<System::Object>::Contains(
		         m_VolumetricCloudVolumes,
		         (Object *)volume,
		         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricCloudVolume>::Contains) )
		  {
		    return;
		  }
		  m_VolumetricCloudVolumes = (List_1_System_Object_ *)this->fields.m_VolumetricCloudVolumes;
		  if ( !m_VolumetricCloudVolumes )
		LABEL_8:
		    sub_1800D8260(m_VolumetricCloudVolumes, v5);
		  sub_182F01190(m_VolumetricCloudVolumes, (Object *)volume);
		}
		
		public void UnregisterCloudVolume(IVolumetricCloudVolume volume) {} // 0x0000000189C4BE2C-0x0000000189C4BEF8
		// Void UnregisterCloudVolume(IVolumetricCloudVolume)
		void HG::Rendering::Runtime::VolumetricCloudVolumeManager::UnregisterCloudVolume(
		        VolumetricCloudVolumeManager *this,
		        IVolumetricCloudVolume *volume,
		        MethodInfo *method)
		{
		  __int64 v5; // rax
		  HGRuntimeGrassQuery_Node *v6; // rdx
		  __int64 v7; // rcx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  Object *v10; // rbx
		  List_1_System_Object_ *m_VolumetricCloudVolumes; // rsi
		  Predicate_1_Object_ *v12; // rax
		  Predicate_1_Object_ *v13; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v15; // [rsp+20h] [rbp-8h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5060, 0LL) )
		  {
		    v5 = sub_18002C620(TypeInfo::HG::Rendering::Runtime::VolumetricCloudVolumeManager::__c__DisplayClass5_0);
		    v10 = (Object *)v5;
		    if ( v5 )
		    {
		      *(_QWORD *)(v5 + 16) = volume;
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)(v5 + 16), v6, v8, v9, v15);
		      if ( !v10[1].klass )
		        return;
		      m_VolumetricCloudVolumes = (List_1_System_Object_ *)this->fields.m_VolumetricCloudVolumes;
		      v12 = (Predicate_1_Object_ *)sub_18002C620(TypeInfo::System::Predicate<HG::Rendering::Runtime::IVolumetricCloudVolume>);
		      v13 = v12;
		      if ( v12 )
		      {
		        System::Predicate<System::Object>::Predicate(
		          v12,
		          v10,
		          MethodInfo::HG::Rendering::Runtime::VolumetricCloudVolumeManager::__c__DisplayClass5_0::_UnregisterCloudVolume_b__0,
		          0LL);
		        if ( m_VolumetricCloudVolumes )
		        {
		          System::Collections::Generic::List<System::Object>::RemoveAll(
		            m_VolumetricCloudVolumes,
		            v13,
		            MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricCloudVolume>::RemoveAll);
		          return;
		        }
		      }
		    }
		LABEL_8:
		    sub_1800D8260(v7, v6);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5060, 0LL);
		  if ( !Patch )
		    goto LABEL_8;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)volume,
		    0LL);
		}
		
		public ValueTuple<EVolumetricState, float> GetFadeRatioAndState(HGCamera camera) => default; // 0x0000000183C6DCD0-0x0000000183C6DE80
		// ValueTuple`2[HG.Rendering.Runtime.EVolumetricState,Single] GetFadeRatioAndState(HGCamera)
		ValueTuple_2_HG_Rendering_Runtime_EVolumetricState_Single_ HG::Rendering::Runtime::VolumetricCloudVolumeManager::GetFadeRatioAndState(
		        VolumetricCloudVolumeManager *this,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *entries; // rcx
		  Object_1__StaticFields *wrapperArray; // rdx
		  Dictionary_2_System_Int32_System_Object_ *m_states; // rdi
		  Camera *v8; // rbx
		  struct Object_1__Class *v9; // rcx
		  char *m_CachedPtr; // rbx
		  int32_t v11; // esi
		  struct MethodInfo *v12; // rbx
		  int32_t Entry; // eax
		  HGRuntimeGrassQuery_Node *v14; // r8
		  Int32__Array **v15; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  int32_t OffsetOfInstanceIDInCPlusPlusObject; // eax
		  MethodInfo *v19; // [rsp+20h] [rbp-18h]
		  ValueTuple_2_HG_Rendering_Runtime_EVolumetricState_Single_ *v20; // [rsp+58h] [rbp+20h] BYREF
		
		  entries = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    entries = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = (Object_1__StaticFields *)entries->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_22;
		  if ( wrapperArray[6].OffsetOfInstanceIDInCPlusPlusObject <= 1155 )
		    goto LABEL_5;
		  if ( !entries->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(entries);
		    entries = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = (Object_1__StaticFields *)entries->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_22;
		  if ( wrapperArray[6].OffsetOfInstanceIDInCPlusPlusObject <= 0x483u )
		    goto LABEL_23;
		  if ( *(_QWORD *)&wrapperArray[2318].OffsetOfInstanceIDInCPlusPlusObject )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1155, 0LL);
		    if ( !Patch )
		      goto LABEL_22;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_436(Patch, (Object *)this, (Object *)camera, 0LL);
		  }
		  else
		  {
		LABEL_5:
		    m_states = (Dictionary_2_System_Int32_System_Object_ *)this->fields.m_states;
		    if ( !camera )
		      goto LABEL_22;
		    v8 = camera->fields.camera;
		    if ( !v8 )
		      goto LABEL_22;
		    if ( v8->fields._._._.m_CachedPtr )
		    {
		      v9 = TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v9 = TypeInfo::UnityEngine::Object;
		      }
		      if ( v9->static_fields->OffsetOfInstanceIDInCPlusPlusObject == -1 )
		      {
		        if ( !v9->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(v9);
		        OffsetOfInstanceIDInCPlusPlusObject = UnityEngine::Object::GetOffsetOfInstanceIDInCPlusPlusObject(0LL);
		        wrapperArray = TypeInfo::UnityEngine::Object->static_fields;
		        wrapperArray->OffsetOfInstanceIDInCPlusPlusObject = OffsetOfInstanceIDInCPlusPlusObject;
		        v9 = TypeInfo::UnityEngine::Object;
		      }
		      m_CachedPtr = (char *)v8->fields._._._.m_CachedPtr;
		      if ( !v9->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(v9);
		        v9 = TypeInfo::UnityEngine::Object;
		      }
		      entries = (struct ILFixDynamicMethodWrapper_2__Class *)v9->static_fields->OffsetOfInstanceIDInCPlusPlusObject;
		      v11 = *(_DWORD *)&m_CachedPtr[(_QWORD)entries];
		    }
		    else
		    {
		      v11 = 0;
		    }
		    if ( !m_states )
		      goto LABEL_22;
		    v12 = MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::VolumetricCloudVolumeManager::VolumetricCloudState>::TryGetValue;
		    if ( !*((_QWORD *)MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::VolumetricCloudVolumeManager::VolumetricCloudState>::TryGetValue->klass->rgctx_data[22].rgctxDataDummy
		          + 4) )
		      (*(void (__fastcall **)(const Il2CppRGCTXData *, Object_1__StaticFields *, MethodInfo *))MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::VolumetricCloudVolumeManager::VolumetricCloudState>::TryGetValue->klass->rgctx_data[22].rgctxDataDummy)(
		        MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::VolumetricCloudVolumeManager::VolumetricCloudState>::TryGetValue->klass->rgctx_data,
		        wrapperArray,
		        method);
		    Entry = System::Collections::Generic::Dictionary<int,System::Object>::FindEntry(
		              m_states,
		              v11,
		              (MethodInfo *)v12->klass->rgctx_data[22].rgctxDataDummy);
		    if ( Entry >= 0 )
		    {
		      entries = (struct ILFixDynamicMethodWrapper_2__Class *)m_states->fields._entries;
		      if ( !entries )
		        goto LABEL_22;
		      if ( (unsigned int)Entry < LODWORD(entries->_0.namespaze) )
		      {
		        v20 = (ValueTuple_2_HG_Rendering_Runtime_EVolumetricState_Single_ *)*((_QWORD *)&entries->_0.this_arg.data.dummy
		                                                                            + 3 * Entry);
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v20, (HGRuntimeGrassQuery_Node *)wrapperArray, v14, v15, v19);
		        if ( v20 )
		          return v20[2];
		LABEL_22:
		        sub_1800D8260(entries, wrapperArray);
		      }
		LABEL_23:
		      sub_1800D2AB0(entries, wrapperArray);
		    }
		    return (ValueTuple_2_HG_Rendering_Runtime_EVolumetricState_Single_)0x3F80000000000000LL;
		  }
		}
		
		public void UpdateFromCamera(HGCamera camera) {} // 0x0000000182F9E050-0x0000000182F9EBD0
		// Void UpdateFromCamera(HGCamera)
		// Hidden C++ exception states: #wind=2
		void HG::Rendering::Runtime::VolumetricCloudVolumeManager::UpdateFromCamera(
		        VolumetricCloudVolumeManager *this,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  Object *v3; // r13
		  __int64 *static_fields; // rcx
		  ILFixDynamicMethodWrapper_2__Array *v6; // rdx
		  Camera *klass; // rdi
		  __int64 (__fastcall *v8)(Camera *, ILFixDynamicMethodWrapper_2__Array *, MethodInfo *); // rax
		  Transform *v9; // rbx
		  Transform *FinalTrigger; // r15
		  Transform *v11; // r12
		  List_1_HG_Rendering_Runtime_IVolumetricCloudVolume_ *m_VolumetricCloudVolumes; // r9
		  unsigned __int64 v13; // rdx
		  signed __int64 v14; // rtt
		  __int64 v15; // rdx
		  __int64 v16; // rcx
		  Object *current; // rbx
		  struct IVolumetricCloudVolume__Class *v18; // rdi
		  Object__Class *v19; // r14
		  unsigned __int16 v20; // cx
		  unsigned __int16 v21; // dx
		  Il2CppRuntimeInterfaceOffsetPair *interfaceOffsets; // r8
		  __int64 v23; // r9
		  Object *v24; // rdi
		  struct Object_1__Class *v25; // rcx
		  void (__fastcall *v26)(Transform *, Il2CppException **); // rax
		  Il2CppException *v27; // xmm6_8
		  float v28; // r15d
		  int v29; // r14d
		  List_1_HG_Rendering_Runtime_IVolumetricCloudVolume_ *v30; // r9
		  unsigned __int64 v31; // rdx
		  signed __int64 v32; // rtt
		  __int64 v33; // rdx
		  __int64 v34; // rcx
		  __int64 v35; // r8
		  Object *v36; // rbx
		  char v37; // al
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  struct ILFixDynamicMethodWrapper_2__Class *v39; // rcx
		  ILFixDynamicMethodWrapper_2__Array *v40; // rcx
		  ILFixDynamicMethodWrapper_2 *v41; // rcx
		  HGEnvironmentPhase *InterpolatedPhase; // rax
		  bool instantDisappear; // r12
		  IVolumetricCloudVolume *v44; // rbx
		  __int64 v45; // rax
		  __int64 v46; // rax
		  Object__Class *v47; // rsi
		  InsertionBehavior__Enum v48; // r9d
		  int32_t InstanceID; // r15d
		  Dictionary_2_System_Int32_System_Boolean_ *monitor; // r14
		  struct MethodInfo *v51; // rsi
		  char IsCloudSdfAssetValid; // al
		  __int64 v53; // rax
		  __int64 v54; // rax
		  Object__Class *v55; // rsi
		  int32_t v56; // eax
		  int32_t v57; // edi
		  __int64 v58; // rax
		  __int64 v59; // rax
		  __int64 v60; // rax
		  Il2CppException *v61; // [rsp+30h] [rbp-E8h] BYREF
		  float v62; // [rsp+38h] [rbp-E0h]
		  _BYTE v63[24]; // [rsp+40h] [rbp-D8h] BYREF
		  Transform *v64; // [rsp+58h] [rbp-C0h]
		  List_1_T_Enumerator_System_Object_ v65; // [rsp+60h] [rbp-B8h] BYREF
		  Il2CppException *ex; // [rsp+80h] [rbp-98h] BYREF
		  List_1_T_Enumerator_System_Object_ *v67; // [rsp+88h] [rbp-90h]
		  Vector3 v68; // [rsp+90h] [rbp-88h] BYREF
		  Il2CppExceptionWrapper *v69; // [rsp+A0h] [rbp-78h] BYREF
		  Il2CppExceptionWrapper *v70; // [rsp+A8h] [rbp-70h] BYREF
		  Object *value; // [rsp+138h] [rbp+20h] BYREF
		
		  v3 = (Object *)camera;
		  value = 0LL;
		  memset(&v65, 0, sizeof(v65));
		  static_fields = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    static_fields = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v6 = *(ILFixDynamicMethodWrapper_2__Array **)static_fields[23];
		  if ( !v6 )
		    goto LABEL_160;
		  if ( v6->max_length.size > 832 )
		  {
		    if ( !*((_DWORD *)static_fields + 56) )
		    {
		      il2cpp_runtime_class_init_1(static_fields);
		      static_fields = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v6 = *(ILFixDynamicMethodWrapper_2__Array **)static_fields[23];
		    if ( !v6 )
		      goto LABEL_160;
		    if ( v6->max_length.size <= 0x340u )
		      goto LABEL_174;
		    if ( v6[23].vector[4] )
		    {
		      if ( !*((_DWORD *)static_fields + 56) )
		      {
		        il2cpp_runtime_class_init_1(static_fields);
		        static_fields = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      static_fields = *(__int64 **)static_fields[23];
		      if ( !static_fields )
		        goto LABEL_160;
		      if ( *((_DWORD *)static_fields + 6) > 0x340u )
		      {
		        static_fields = (__int64 *)static_fields[836];
		        if ( static_fields )
		        {
		          IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		            (ILFixDynamicMethodWrapper_39 *)static_fields,
		            (Object *)this,
		            v3,
		            0LL);
		          return;
		        }
		LABEL_160:
		        sub_1800D8250(static_fields, v6);
		      }
		LABEL_174:
		      sub_1800D2AA0(static_fields, v6, method);
		    }
		  }
		  if ( !v3 )
		    goto LABEL_160;
		  klass = (Camera *)v3[6].klass;
		  if ( !klass )
		    goto LABEL_160;
		  v8 = (__int64 (__fastcall *)(Camera *, ILFixDynamicMethodWrapper_2__Array *, MethodInfo *))qword_18F36FBC0;
		  if ( !qword_18F36FBC0 )
		  {
		    v8 = (__int64 (__fastcall *)(Camera *, ILFixDynamicMethodWrapper_2__Array *, MethodInfo *))il2cpp_resolve_icall_1(
		                                                                                                 "UnityEngine.Component::get_transform()");
		    if ( !v8 )
		    {
		      v59 = sub_1802EE1B8("UnityEngine.Component::get_transform()");
		      sub_18007E1B0(v59, 0LL);
		    }
		    qword_18F36FBC0 = (__int64)v8;
		  }
		  v9 = (Transform *)v8(klass, v6, method);
		  if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		  FinalTrigger = HG::Rendering::Runtime::HGEnvironmentManager::GetFinalTrigger(klass, v9, 0LL);
		  v11 = FinalTrigger;
		  v64 = FinalTrigger;
		  m_VolumetricCloudVolumes = this->fields.m_VolumetricCloudVolumes;
		  if ( !m_VolumetricCloudVolumes )
		    goto LABEL_160;
		  *(_OWORD *)&v63[8] = 0LL;
		  *(_QWORD *)v63 = m_VolumetricCloudVolumes;
		  if ( dword_18F35FD08 )
		  {
		    v13 = (((unsigned __int64)v63 >> 12) & 0x1FFFFF) >> 6;
		    _m_prefetchw(&qword_18F0BCBA0[v13 + 36190]);
		    do
		      v14 = qword_18F0BCBA0[v13 + 36190];
		    while ( v14 != _InterlockedCompareExchange64(
		                     &qword_18F0BCBA0[v13 + 36190],
		                     v14 | (1LL << (((unsigned __int64)v63 >> 12) & 0x3F)),
		                     v14) );
		  }
		  *(_DWORD *)&v63[8] = 0;
		  *(_DWORD *)&v63[12] = m_VolumetricCloudVolumes->fields._version;
		  *(_QWORD *)&v63[16] = 0LL;
		  *(_OWORD *)&v65._list = *(_OWORD *)v63;
		  v65._current = 0LL;
		  ex = 0LL;
		  v67 = &v65;
		  try
		  {
		    while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		              &v65,
		              MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IVolumetricCloudVolume>::MoveNext) )
		    {
		      current = v65._current;
		      if ( !v65._current )
		        sub_1800D8250(v16, v15);
		      if ( *(_DWORD *)&v65._current->klass->_1.method_count == 3435 )
		      {
		        HG::Rendering::Runtime::VolumetricCloudSDF::UpdateVisibility(
		          (VolumetricCloudSDF *)v65._current,
		          (HGCamera *)v3,
		          0,
		          0LL);
		      }
		      else
		      {
		        v18 = TypeInfo::HG::Rendering::Runtime::IVolumetricCloudVolume;
		        v19 = v65._current->klass;
		        sub_1800049A0(v65._current->klass);
		        v20 = 0;
		        v21 = *(_WORD *)&v19->_1.naturalAligment;
		        if ( v21 )
		        {
		          interfaceOffsets = v19->interfaceOffsets;
		          while ( (struct IVolumetricCloudVolume__Class *)interfaceOffsets[v20].interfaceType != v18 )
		          {
		            if ( ++v20 >= v21 )
		              goto LABEL_35;
		          }
		          v23 = (__int64)(&v19->vtable.GetHashCode.method + 2 * interfaceOffsets[v20].offset);
		        }
		        else
		        {
		LABEL_35:
		          v23 = sub_1800219C0(current, v18, 2LL);
		        }
		        (*(void (__fastcall **)(Object *, Object *, _QWORD, _QWORD))v23)(current, v3, 0LL, *(_QWORD *)(v23 + 8));
		      }
		    }
		  }
		  catch ( Il2CppExceptionWrapper *v69 )
		  {
		    ex = v69->ex;
		    if ( ex )
		      sub_18007E1E0(ex);
		    v3 = (Object *)camera;
		    v11 = v64;
		    FinalTrigger = v64;
		  }
		  v24 = 0LL;
		  v64 = 0LL;
		  v25 = TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v25 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v25 = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( FinalTrigger )
		  {
		    if ( !v25->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(v25);
		    if ( v11->fields._._.m_CachedPtr )
		    {
		      v61 = 0LL;
		      v62 = 0.0;
		      v26 = (void (__fastcall *)(Transform *, Il2CppException **))qword_18F3700F0;
		      if ( !qword_18F3700F0 )
		      {
		        v26 = (void (__fastcall *)(Transform *, Il2CppException **))il2cpp_resolve_icall_1(
		                                                                      "UnityEngine.Transform::get_position_Injected(Unity"
		                                                                      "Engine.Vector3&)");
		        if ( !v26 )
		        {
		          v60 = sub_1802EE1B8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		          sub_18007E1B0(v60, 0LL);
		        }
		        qword_18F3700F0 = (__int64)v26;
		      }
		      v26(v11, &v61);
		      v27 = v61;
		      v28 = v62;
		      v29 = 0x80000000;
		      v30 = this->fields.m_VolumetricCloudVolumes;
		      if ( !v30 )
		        goto LABEL_160;
		      *(_OWORD *)&v63[8] = 0LL;
		      *(_QWORD *)v63 = v30;
		      if ( dword_18F35FD08 )
		      {
		        v31 = (((unsigned __int64)v63 >> 12) & 0x1FFFFF) >> 6;
		        _m_prefetchw(&qword_18F0BCBA0[v31 + 36190]);
		        do
		          v32 = qword_18F0BCBA0[v31 + 36190];
		        while ( v32 != _InterlockedCompareExchange64(
		                         &qword_18F0BCBA0[v31 + 36190],
		                         v32 | (1LL << (((unsigned __int64)v63 >> 12) & 0x3F)),
		                         v32) );
		      }
		      *(_DWORD *)&v63[8] = 0;
		      *(_DWORD *)&v63[12] = v30->fields._version;
		      *(_QWORD *)&v63[16] = 0LL;
		      *(_OWORD *)&v65._list = *(_OWORD *)v63;
		      v65._current = 0LL;
		      *(_QWORD *)v63 = 0LL;
		      *(_QWORD *)&v63[8] = &v65;
		      try
		      {
		        while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		                  &v65,
		                  MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IVolumetricCloudVolume>::MoveNext) )
		        {
		          v36 = v65._current;
		          if ( !v65._current )
		            sub_1800D8250(v34, v33);
		          if ( *(_DWORD *)&v65._current->klass->_1.method_count == 3435 )
		          {
		            v39 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		            if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		            {
		              il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		              v39 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		            }
		            wrapperArray = v39->static_fields->wrapperArray;
		            if ( !wrapperArray )
		              sub_1800D8250(v39, 0LL);
		            if ( wrapperArray->max_length.size <= 5012 )
		              goto LABEL_187;
		            if ( !v39->_1.cctor_finished_or_no_cctor )
		            {
		              il2cpp_runtime_class_init_1(v39);
		              v39 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		            }
		            wrapperArray = v39->static_fields->wrapperArray;
		            if ( !wrapperArray )
		              sub_1800D8250(v39, 0LL);
		            if ( wrapperArray->max_length.size <= 0x1394u )
		              sub_1800D2AA0(v39, wrapperArray, v35);
		            if ( wrapperArray[139].vector[8] )
		            {
		              if ( !v39->_1.cctor_finished_or_no_cctor )
		              {
		                il2cpp_runtime_class_init_1(v39);
		                v39 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		              }
		              v40 = v39->static_fields->wrapperArray;
		              if ( !v40 )
		                sub_1800D8250(0LL, wrapperArray);
		              if ( v40->max_length.size <= 0x1394u )
		                sub_1800D2AA0(v40, wrapperArray, v35);
		              v41 = v40[139].vector[8];
		              if ( !v41 )
		                sub_1800D8250(0LL, wrapperArray);
		              *(_QWORD *)&v68.x = v27;
		              v68.z = v28;
		              v37 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_255(v41, v36, &v68, 0LL);
		            }
		            else
		            {
		LABEL_187:
		              if ( BYTE4(v36[27].monitor) )
		              {
		                v37 = 1;
		              }
		              else if ( v36[27].klass )
		              {
		                ex = v27;
		                *(float *)&v67 = v28;
		                v37 = Beyond::BeyondPolyLineShape::GetDistanceToEdgeInArea(
		                        (BeyondPolyLineShape *)v36[27].klass,
		                        (Vector3 *)&ex,
		                        0.1,
		                        0LL) > 0.0;
		              }
		              else
		              {
		                v37 = 0;
		              }
		            }
		          }
		          else
		          {
		            v61 = v27;
		            v62 = v28;
		            v37 = sub_180038B00(1LL, TypeInfo::HG::Rendering::Runtime::IVolumetricCloudVolume, v65._current, &v61);
		          }
		          if ( v37 )
		          {
		            if ( !v36 )
		              sub_1800D8250(v39, wrapperArray);
		            if ( (int)sub_189C4412C(v36) > v29 )
		            {
		              v29 = sub_189C4412C(v36);
		              v24 = v36;
		              v64 = (Transform *)v36;
		            }
		          }
		        }
		      }
		      catch ( Il2CppExceptionWrapper *v70 )
		      {
		        *(Il2CppExceptionWrapper *)v63 = (Il2CppExceptionWrapper)v70->ex;
		        if ( *(_QWORD *)v63 )
		          sub_18007E1E0(*(_QWORD *)v63);
		        v3 = (Object *)camera;
		        v24 = (Object *)v64;
		      }
		    }
		  }
		  if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		  InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase((HGCamera *)v3, 0LL);
		  if ( !InterpolatedPhase )
		    goto LABEL_160;
		  instantDisappear = InterpolatedPhase->fields.volumetricCloudConfig.instantDisappear;
		  if ( !v24 || InterpolatedPhase->fields.volumetricCloudConfig.enabled )
		  {
		    v44 = 0LL;
		    if ( v24 )
		    {
		      if ( *(_DWORD *)&v24->klass->_1.method_count == 3435 )
		      {
		        if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		        static_fields = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields->wrapperArray;
		        if ( !v6 )
		          goto LABEL_160;
		        if ( v6->max_length.size <= 5018 )
		          goto LABEL_110;
		        if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		        static_fields = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		        v45 = *static_fields;
		        if ( !*static_fields )
		          goto LABEL_160;
		        if ( *(_DWORD *)(v45 + 24) <= 0x139Au )
		          goto LABEL_174;
		        if ( *(_QWORD *)(v45 + 40176) )
		        {
		          if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		          static_fields = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		          v46 = *static_fields;
		          if ( !*static_fields )
		            goto LABEL_160;
		          if ( *(_DWORD *)(v46 + 24) <= 0x139Au )
		            goto LABEL_174;
		          static_fields = *(__int64 **)(v46 + 40176);
		          if ( !static_fields )
		            goto LABEL_160;
		          IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_39 *)static_fields, v24, v3, 0LL);
		        }
		        else
		        {
		LABEL_110:
		          v47 = v24[4].klass;
		          if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		          if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		          if ( v47 )
		          {
		            if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		              il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		            if ( v47->_0.name )
		            {
		              static_fields = (__int64 *)v3[6].klass;
		              if ( !static_fields )
		                goto LABEL_160;
		              InstanceID = UnityEngine::Object::GetInstanceID((Object_1 *)static_fields, 0LL);
		              monitor = (Dictionary_2_System_Int32_System_Boolean_ *)v24[28].monitor;
		              if ( !monitor )
		                goto LABEL_160;
		              v51 = MethodInfo::System::Collections::Generic::Dictionary<int,bool>::set_Item;
		              if ( !*((_QWORD *)MethodInfo::System::Collections::Generic::Dictionary<int,bool>::set_Item->klass->rgctx_data[24].rgctxDataDummy
		                    + 4) )
		                (*(void (**)(void))MethodInfo::System::Collections::Generic::Dictionary<int,bool>::set_Item->klass->rgctx_data[24].rgctxDataDummy)();
		              LOBYTE(v48) = 1;
		              System::Collections::Generic::Dictionary<int,bool>::TryInsert(
		                monitor,
		                InstanceID,
		                1,
		                v48,
		                (MethodInfo *)v51->klass->rgctx_data[24].rgctxDataDummy);
		            }
		          }
		        }
		      }
		      else
		      {
		        sub_1808B22D0(4LL, v6, v24, v3);
		      }
		      if ( *(_DWORD *)&v24->klass->_1.method_count == 3435 )
		      {
		        if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		        static_fields = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields->wrapperArray;
		        if ( !v6 )
		          goto LABEL_160;
		        if ( v6->max_length.size <= 5020 )
		          goto LABEL_140;
		        if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		        static_fields = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		        v53 = *static_fields;
		        if ( !*static_fields )
		          goto LABEL_160;
		        if ( *(_DWORD *)(v53 + 24) <= 0x139Cu )
		          goto LABEL_174;
		        if ( *(_QWORD *)(v53 + 40192) )
		        {
		          if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		          static_fields = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		          v54 = *static_fields;
		          if ( !*static_fields )
		            goto LABEL_160;
		          if ( *(_DWORD *)(v54 + 24) <= 0x139Cu )
		            goto LABEL_174;
		          static_fields = *(__int64 **)(v54 + 40192);
		          if ( !static_fields )
		            goto LABEL_160;
		          IsCloudSdfAssetValid = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14(
		                                   (ILFixDynamicMethodWrapper_20 *)static_fields,
		                                   v24,
		                                   0LL);
		        }
		        else
		        {
		LABEL_140:
		          v55 = v24[4].klass;
		          if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		          if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		          if ( !v55 )
		            goto LABEL_149;
		          if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		          if ( v55->_0.name )
		            IsCloudSdfAssetValid = HG::Rendering::Runtime::VolumetricCloudSDF::get_IsCloudSdfAssetValid(
		                                     (VolumetricCloudSDF *)v24,
		                                     0LL);
		          else
		LABEL_149:
		            IsCloudSdfAssetValid = 1;
		        }
		      }
		      else
		      {
		        IsCloudSdfAssetValid = sub_180042E60(5LL, TypeInfo::HG::Rendering::Runtime::IVolumetricCloudVolume);
		      }
		      if ( IsCloudSdfAssetValid )
		        v44 = (IVolumetricCloudVolume *)v24;
		    }
		  }
		  else
		  {
		    v44 = 0LL;
		  }
		  static_fields = (__int64 *)v3[6].klass;
		  if ( !static_fields )
		    goto LABEL_160;
		  v56 = UnityEngine::Object::GetInstanceID((Object_1 *)static_fields, 0LL);
		  v57 = v56;
		  static_fields = (__int64 *)this->fields.m_states;
		  if ( !static_fields )
		    goto LABEL_160;
		  if ( !System::Collections::Generic::Dictionary<int,System::Object>::TryGetValue(
		          (Dictionary_2_System_Int32_System_Object_ *)static_fields,
		          v56,
		          &value,
		          MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::VolumetricCloudVolumeManager::VolumetricCloudState>::TryGetValue) )
		  {
		    v58 = sub_18002C620(TypeInfo::HG::Rendering::Runtime::VolumetricCloudVolumeManager::VolumetricCloudState);
		    if ( !v58 )
		      goto LABEL_160;
		    *(_DWORD *)(v58 + 20) = 1065353216;
		    value = (Object *)v58;
		    static_fields = (__int64 *)this->fields.m_states;
		    if ( !static_fields )
		      goto LABEL_160;
		    System::Collections::Generic::Dictionary<int,System::Object>::Add(
		      (Dictionary_2_System_Int32_System_Object_ *)static_fields,
		      v57,
		      (Object *)v58,
		      MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::VolumetricCloudVolumeManager::VolumetricCloudState>::Add);
		  }
		  static_fields = (__int64 *)value;
		  if ( !value )
		    goto LABEL_160;
		  HG::Rendering::Runtime::VolumetricCloudVolumeManager::VolumetricCloudState::UpdateState(
		    (VolumetricCloudVolumeManager_VolumetricCloudState *)value,
		    (HGCamera *)v3,
		    v44,
		    instantDisappear,
		    0LL);
		}
		
	}
}
